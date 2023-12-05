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
    public partial class LogInWinForm : Form
    {
        string userConfigPath = Directory.GetCurrentDirectory() + "\\UserInfos";
        string userConfigFile = "userInfos.json";
        List<UserConfigInfo> userConfigData = new List<UserConfigInfo>();
        public LogInWinForm()
        {
            InitializeComponent();
        }

        public void LoadUserInfos()
        {
            string fileAllPath = Path.Combine(userConfigPath, userConfigFile);
            if (!File.Exists(fileAllPath)) return;
            using (StreamReader sr = new StreamReader(fileAllPath))
            {
                string tempInfos = sr.ReadToEnd();
                var tempList = JsonConvert.DeserializeObject<List<UserConfigInfo>>(tempInfos);
                if (tempList == null) return;
                userConfigData = tempList;
            }
        }

        public void SaveUserInfos()
        {
            string fileAllPath = Path.Combine(userConfigPath, userConfigFile);
            if (File.Exists(fileAllPath)) File.Delete(fileAllPath);
            if(!Directory.Exists(userConfigPath)) Directory.CreateDirectory(userConfigPath);
            using (StreamWriter sw = new StreamWriter(fileAllPath))
            {
                string tempInfos = JsonConvert.SerializeObject(userConfigData);
                sw.WriteLine(tempInfos);
            }

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            foreach (var item in userConfigData)
            {
                if (item.UserConfigName.Equals(tbName.Text.Trim()) && item.UserPassward.Equals(tbPassward.Text.Trim()))
                {
                    this.DialogResult = DialogResult.OK;
                    break;
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserConfigInfo temp = new UserConfigInfo();
            temp.UserConfigName = this.tbName.Text.Trim();
            temp.UserPassward = this.tbPassward.Text.Trim();
            userConfigData.Add(temp);
        }
    }
}
