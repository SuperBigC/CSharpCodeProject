using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormVisualSolution
{
    internal class ProjectData
    {
        public string ProjectName { get; set; }
        public string CreatedTime { get; set; }
        public string AuthorName { get; set; }

        public ProjectData() 
        {
            ProjectName = "ImageProcess";
            CreatedTime = DateTime.Now.ToString("yyyyMMddHHmmss");
            AuthorName = "Author";
        }

    }
}
