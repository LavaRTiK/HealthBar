using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthBare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 5, maxhealth = 10;
            int mana = 7, maxman = 20;
            while (true)
            {
                DrawBar(health, maxhealth, ConsoleColor.Red, 0, '|');
                DrawBar(mana, maxman, ConsoleColor.Blue, 1);

                Console.SetCursorPosition(0, 5);
                Console.Write("Введите число, на которые изменяться жизни:");
                health += Int32.Parse(Console.ReadLine());
                Console.Write("Введите число, на которые изменяться мана:");
                mana += Int32.Parse(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();
            }
            Console.ReadKey();
        }

        static void DrawBar(int value, int maxValue, ConsoleColor clor, int position, char symbol = '_')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";
            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }
            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = clor;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";
            for (int i = value; i < maxValue; i++)
            {
                bar += symbol;
            }
            Console.Write(bar + ']');
        }
    }
}
