using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class ConsoleGC
    {
        public void DrawPixel(Vector2 pos, char pixel = '█', ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(pos.X, pos.Y);
            Console.Write(pixel);
        }

        public void DrawDoublePixel(Vector2 pos, char pixel = '█', ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(pos.X*2, pos.Y);
            Console.Write(pixel);
            Console.Write(pixel);
        }

        public void DrawString(Vector2 pos, string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(pos.X, pos.Y);
            Console.Write(text);
        }

        public void DrawPicture(Vector2 pos, char[][] picture, ConsoleColor color = ConsoleColor.White, bool DoublePixel = false)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(pos.X, pos.Y);
            for (int i = 0; i < picture.Length; i++)
            {
                for (int j = 0; j < picture[i].Length; j++)
                {
                    if (DoublePixel)
                        DrawDoublePixel(new Vector2(pos.X + i, pos.Y + j), picture[i][j], color);
                    else
                        DrawPixel(new Vector2(pos.X + i, pos.Y + j), picture[i][j], color);
                }
            }
        }

        public void DrawCords(IEnumerable<Vector2> poses, char pixel = 'S', ConsoleColor color = ConsoleColor.White)
        {
            foreach (Vector2 vector in poses)
            {
                DrawPixel(vector, pixel, color);
            }
        }

        public void DrawDoubleCords(IEnumerable<Vector2> poses, char pixel = 'S', ConsoleColor color = ConsoleColor.White)
        {
            foreach (Vector2 vector in poses)
            {
                DrawDoublePixel(vector, pixel, color);
            }
        }

        public char[][] Newframe(Vector2 voidSize, char pixel = 'S', bool doublePixel = false)
        {
            char[][] returnka;
            if (doublePixel)
            {
                returnka = new char[voidSize.Y*2][];
            }
            else
            {
                returnka = new char[voidSize.Y][];
            }
            for (int i = 0; i < returnka.Length; i++)
            {
                char[] MassY = new char[voidSize.X];
                for (int j = 0; j < MassY.Length; j++)
                {
                    if (doublePixel)
                    {
                        if (i <= 1  || i >= returnka.Length - 2 || j <= 0 || j == MassY.Length - 1)
                            MassY[j] = pixel;
                    }
                    else
                    {
                        if (i == 0 || i == returnka.Length - 1 || j == 0 || j == MassY.Length - 1)
                            MassY[j] = pixel;
                    }
                }
                returnka[i] = MassY;
            }
            

            return returnka;
        }
    }
}