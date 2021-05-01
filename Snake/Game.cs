using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Game : ConsoleGC
    {
        public Vector2 WSize;

        public Game()
        {

        }

        public void NewGame(Vector2 WorldSize,  bool doublePixels)
        {
            WSize = WorldSize;
            DrawPicture(new Vector2(0, 0), Newframe(WSize, '█'), ConsoleColor.Red, doublePixels);
        }
    }
}
