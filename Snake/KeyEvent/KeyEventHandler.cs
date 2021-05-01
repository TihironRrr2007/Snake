using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Snake.KeyEvent
{
    public class KeyEventHandler
    {
        public static bool Exit = false;

        public static event Action PressButtonW;
        public static event Action PressButtonA;
        public static event Action PressButtonS;
        public static event Action PressButtonD;
        private static readonly Thread KeyRead;

        static KeyEventHandler()
        {
            KeyRead = new Thread(WaitKey);
            KeyRead.Start();
        }
        
        private static void WaitKey()
        {
            while (!Exit)
            {
                ConsoleKeyInfo Key = Console.ReadKey(true);
                PressKey(Key.Key);
            }
        }

        private static void PressKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.W:
                    {
                        PressButtonW?.Invoke();
                        break;
                    }
                case ConsoleKey.A:
                    {
                        PressButtonA?.Invoke();
                        break;
                    }
                case ConsoleKey.S:
                    {
                        PressButtonS?.Invoke();
                        break;
                    }
                case ConsoleKey.D:
                    {
                        PressButtonD?.Invoke();
                        break;
                    }
            }
        }
    }
}