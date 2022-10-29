using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_M9_BrunoPinheiro
{
    internal class Settings3
    {
        public static int Width { get; set; }
        public static int Height { get; set; }

        public static string directions;

        public Settings3()
        {
            Width = 12;
            Height = 12;
            directions = "left";
        }
    }
}
