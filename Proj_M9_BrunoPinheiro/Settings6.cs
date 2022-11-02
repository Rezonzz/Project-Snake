using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_M9_BrunoPinheiro
{
    internal class Settings6
    {
        public static int Width { get; set; }
        public static int Height { get; set; }

        public static string directions;

        public Settings6()
        {
            Width = 16;
            Height = 16;
            directions = "left";
        }
    }
}
