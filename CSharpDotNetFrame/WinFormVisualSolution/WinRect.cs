using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormVisualSolution
{
    internal class WinRect
    {
        public string Name { get; set; }
        public WinRect? Parent { get; set; }
        public List<WinRect> Childrens { get; set; }
        public Rectangle selfRect { get; set; }

        public WinRect()
        {
            Name = "Win";
            Parent = null;
            Childrens = new List<WinRect>();
            selfRect = new Rectangle();
        }
    }
}
