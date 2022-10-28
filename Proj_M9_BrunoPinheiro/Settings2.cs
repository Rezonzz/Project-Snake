using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_M9_BrunoPinheiro
{
    internal class Settings2
    {
        public static int Width { get; set; }
        public static int Height { get; set; }

        public static string directions;

        public Settings2()
        {
            Width = 14;
            Height = 14;
            directions = "left";
        }
    }
}
