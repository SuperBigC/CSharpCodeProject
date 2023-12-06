using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace WinFormVisualSolution
{
    //public partial class LogInWinForm : Form
    //{
    //    string userConfigPath = Directory.GetCurrentDirectory() + "\\UserInfos";
    //    string userConfigFile = "userInfos.json";
    //    List<UserConfigInfo> userConfigData = new List<UserConfigInfo>();
    //    public LogInWinForm()
    //    {
    //        InitializeComponent();
    //    }

    //    public void LoadUserInfos()
    //    {
    //        string fileAllPath = Path.Combine(userConfigPath, userConfigFile);
    //        if (!File.Exists(fileAllPath)) return;
    //        using (StreamReader sr = new StreamReader(fileAllPath))
    //        {
    //            string tempInfos = sr.ReadToEnd();
    //            var tempList = JsonConvert.DeserializeObject<List<UserConfigInfo>>(tempInfos);
    //            if (tempList == null) return;
    //            userConfigData = tempList;
    //        }
    //    }

    //    public void SaveUserInfos()
    //    {
    //        string fileAllPath = Path.Combine(userConfigPath, userConfigFile);
    //        if (File.Exists(fileAllPath)) File.Delete(fileAllPath);
    //        if(!Directory.Exists(userConfigPath)) Directory.CreateDirectory(userConfigPath);
    //        using (StreamWriter sw = new StreamWriter(fileAllPath))
    //        {
    //            string tempInfos = JsonConvert.SerializeObject(userConfigData);
    //            sw.WriteLine(tempInfos);
    //        }

    //    }

    //    private void btnLogIn_Click(object sender, EventArgs e)
    //    {
    //        this.DialogResult = DialogResult.No;
    //        foreach (var item in userConfigData)
    //        {
    //            if (item.UserConfigName.Equals(tbName.Text.Trim()) && item.UserPassward.Equals(tbPassward.Text.Trim()))
    //            {
    //                this.DialogResult = DialogResult.OK;
    //                break;
    //            }
    //        }
    //    }

    //    private void btnRegister_Click(object sender, EventArgs e)
    //    {
    //        UserConfigInfo temp = new UserConfigInfo();
    //        temp.UserConfigName = this.tbName.Text.Trim();
    //        temp.UserPassward = this.tbPassward.Text.Trim();
    //        userConfigData.Add(temp);
    //    }
    //}

    public partial class LogInWinForm : Form
    {
        //创建一个用户信息管理类的实例
        private UserInfoManager userInfoManager = new UserInfoManager();

        public LogInWinForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //获取用户输入的用户名和密码
            string userName = tbName.Text.Trim();
            string userPassword = tbPassward.Text.Trim();
            //判断用户名和密码是否为空
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPassword))
            {
                MessageBox.Show("用户名或密码不能为空！");
                return;
            }
            //查询用户信息列表，判断是否存在匹配的用户
            var user = userInfoManager.GetUser(userName, userPassword);
            if (user != null)
            {
                //如果存在匹配的用户，设置窗体的返回值为OK，并关闭窗体
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                //如果不存在匹配的用户，显示提示信息，并清空文本框
                MessageBox.Show("用户名或密码错误！");
                tbName.Clear();
                tbPassward.Clear();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //获取用户输入的用户名和密码
            string userName = tbName.Text.Trim();
            string userPassword = tbPassward.Text.Trim();
            //判断用户名和密码是否为空
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPassword))
            {
                MessageBox.Show("用户名或密码不能为空！");
                return;
            }
            //创建一个用户信息对象，并赋值用户名和密码
            UserConfigInfo user = new UserConfigInfo();
            user.UserConfigName = userName;
            user.UserPassward = userPassword;
            //将用户信息对象添加到用户信息列表中，并保存到文件中
            userInfoManager.AddUser(user);
            //显示提示信息，并清空文本框
            MessageBox.Show("注册成功！");
            tbName.Clear();
            tbPassward.Clear();
        }
    }

    //定义一个用户信息管理类，用来封装用户信息的加载和保存功能
    public class UserInfoManager
    {
        //定义用户信息的文件路径和文件名
        private string userConfigPath = Directory.GetCurrentDirectory() + "\\UserInfos";
        private string userConfigFile = "userInfos.json";
        //定义一个用户信息列表，用来存储用户信息
        private List<UserConfigInfo> userConfigData = new List<UserConfigInfo>();

        //在构造函数中调用加载用户信息的方法
        public UserInfoManager()
        {
            LoadUserInfos();
        }

        //定义一个加载用户信息的方法
        public void LoadUserInfos()
        {
            //拼接用户信息的文件全路径
            string fileAllPath = Path.Combine(userConfigPath, userConfigFile);
            //判断文件是否存在
            if (!File.Exists(fileAllPath)) return;
            //使用File.ReadAllText方法读取文件的内容
            string tempInfos = File.ReadAllText(fileAllPath);
            //使用JsonConvert.DeserializeObject方法将文件内容反序列化为用户信息列表
            var tempList = JsonConvert.DeserializeObject<List<UserConfigInfo>>(tempInfos);
            //判断用户信息列表是否为空
            if (tempList == null) return;
            //将用户信息列表赋值给userConfigData
            userConfigData = tempList;
        }

        //定义一个保存用户信息的方法
        public void SaveUserInfos()
        {
            //拼接用户信息的文件全路径
            string fileAllPath = Path.Combine(userConfigPath, userConfigFile);
            //判断文件是否存在，如果存在则删除
            if (File.Exists(fileAllPath)) File.Delete(fileAllPath);
            //判断文件夹是否存在，如果不存在则创建
            if (!Directory.Exists(userConfigPath)) Directory.CreateDirectory(userConfigPath);
            //使用JsonConvert.SerializeObject方法将用户信息列表序列化为字符串
            string tempInfos = JsonConvert.SerializeObject(userConfigData);
            //使用File.WriteAllText方法将字符串写入文件中
            File.WriteAllText(fileAllPath, tempInfos);
        }

        //定义一个添加用户信息的方法
        public void AddUser(UserConfigInfo user)
        {
            //判断用户信息是否为空
            if (user == null) return;
            //将用户信息添加到用户信息列表中
            userConfigData.Add(user);
            //调用保存用户信息的方法
            SaveUserInfos();
        }

        //定义一个查询用户信息的方法，根据用户名和密码返回匹配的用户信息对象
        public UserConfigInfo? GetUser(string userName, string userPassword)
        {
            //判断用户名和密码是否为空
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPassword)) return null;
            //使用LINQ表达式查询用户信息列表，返回匹配的用户信息对象，如果没有匹配的则返回null
            return userConfigData.FirstOrDefault(u => u.UserConfigName == userName && u.UserPassward == userPassword);
        }
    }

}
