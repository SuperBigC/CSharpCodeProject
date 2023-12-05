using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormVisualSolution
{
    internal class UserConfigInfo
    {
        public string UserConfigName {  get; set; }
        public string UserPassward {  get; set; }
        public string UserConfigPath { get; set;}
        public UserConfigInfo() 
        {
            UserConfigName = "Visual Solution";
            UserPassward = "";
            UserConfigPath = "";
        }
    }
}
