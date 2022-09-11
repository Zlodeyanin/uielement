using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uielement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxHealth = 10;
            const int maxMana = 10;
            const string exit = "exit";
            bool isWork = true;
            int health = 0;
            int mana = 0;
                      
            while (isWork)
            {
                DrawBar(health, maxHealth, ConsoleColor.Red, 0, '#');
                DrawBar(mana, maxMana, ConsoleColor.Blue, 1, '#');
                health = 0;
                mana = 0;
                Console.SetCursorPosition(0, 5);
                Console.Write("Введите процент жизней: ");
                health+= Convert.ToInt32(Console.ReadLine()) / maxHealth;
                Console.Write("Введите процент маны: ");
                mana += Convert.ToInt32(Console.ReadLine()) / maxMana;
                Console.WriteLine($"Введите {exit}, чтобы выйти из программы. Нажмите любую клавишу для продолжения работы...");
                string userInput= Console.ReadLine();
                Console.ReadKey();               
                Console.Clear();

                if(userInput == exit)
                {
                    isWork = false;
                }
            }
        }

        static void DrawBar(int value, int maxValue,ConsoleColor color ,int position , char symbol = ' ')
        {
            ConsoleColor consoleColor = Console.BackgroundColor;
            string bar = "";

            for(int i = 0; i < value; i++)
            {
                bar += symbol;
            }
            Console.SetCursorPosition(0, position);
            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = consoleColor;
            bar = "";

            for(int i = value; i < maxValue; i++)
            {
                bar += ' ';
            }
            Console.Write(bar + ']');
        }
    }
}
