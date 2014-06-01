using System;

namespace SwagGUI
{
    internal class Options
    {
        public static String name = "Herp";
        public static String profession = "Derp";
        private int hp = 0;
        public static RECT healthBox = new RECT(920, 1008, 990, 1040);

        public int HP
        {
            get { return hp; }
            set
            {
                if (value != hp)
                {
                    hp = value;
                }
            }
        }
    }
}