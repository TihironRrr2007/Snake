using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Vector2
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector2()
        {

        }
        public Vector2(int Xpos, int Ypos)
        {
            X = Xpos;
            Y = Ypos;
        }
    }
}
