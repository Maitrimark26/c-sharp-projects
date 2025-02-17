using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypesOfClasses;

namespace RockPaperScissors
{
    internal class B : A
    {

        public B()
        {
            Console.WriteLine("Child");
            a += 10;
        }
    }
    enum Enumvalue {
    Rock,
    Paper,
    Scissor
    }

    internal class Program
    {



        static void Main(string[] args)
        {

            int choice = 1;
            while (true)
            {
                Console.WriteLine("Welcome to Rock Paper Scissors");

                Console.WriteLine("Enter Rock || Paper || Scissor");
                string input= Console.ReadLine();
                if (Enum.TryParse(input, out Enumvalue move)) {
                    Console.WriteLine("You Played "+move.ToString());
                    Console.WriteLine("Computer's move");
                    Random random = new Random();
                    int CompValue = random.Next(0, 3);

                    Console.WriteLine($"Computer played {(Enumvalue)CompValue}");
                    if ((Enumvalue)CompValue == move)
                    {
                        Console.WriteLine("Draw");
                    }
                    else if ((move == Enumvalue.Rock && (Enumvalue)CompValue == Enumvalue.Scissor) ||
                             (move == Enumvalue.Paper && (Enumvalue)CompValue == Enumvalue.Rock) ||
                             (move == Enumvalue.Scissor && (Enumvalue)CompValue == Enumvalue.Paper))
                    {
                        Console.WriteLine("You Win!");
                    }
                    else
                    {
                        Console.WriteLine("Computer Wins!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }





                Console.WriteLine("Do you want to continue playing(yes -> 1 / No -> 0)");
                choice=int.Parse(Console.ReadLine());
                if (choice == 0)
                {
                    break;
                }
            }

            }
        }
}
