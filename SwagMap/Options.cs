using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwagMap
{
    class Options
    {
        private static int _width = 100;

        public static int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        private static int _height = 100;

        public static int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        private static bool _bottom = false;

        public static bool Bottom
        {
            get { return _bottom; }
            set { _bottom = value; }
        }
    }
}
