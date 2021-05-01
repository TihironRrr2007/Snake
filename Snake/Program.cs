using System;
using System.Linq;

namespace Snake
{
    class Program
    {

        public static Game GameManager = new Game();
        static void Main()
        {
            Console.WriteLine("Ведите размер мира(минимум - 10)");
            int Size;
            bool DoublePixels;
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out Size) && Size > 9)
                {
                    break;
                }
                else
                {
                    Console.Write("Введите ЧИСЛО БОЛЬШЕ 9");
                    Console.WriteLine();
                }
            }
            Console.Clear();
            
            Console.WriteLine("Хотите нормальный мир? Y/N");
            while (true)
            {
                string str = Console.ReadLine().ToLower();
                if (str == "y")
                {
                    DoublePixels = true;
                    break;
                }
                else if (str == "n")
                {
                    DoublePixels = false;
                    break;
                }
                else
                {
                    Console.Write("Это не y/n");
                    Console.WriteLine();
                }
            }
            Console.Clear();
            GameManager.NewGame(new Vector2(Size, Size), DoublePixels);
        }
    }
}