using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerOne = new Player("Marko", 300, 20);
            Player playerTwo = new Player("JABE", 200, 30);

            string option = "Continue";

            Console.WriteLine("<Attack> <Defend> <Quit>");
            option = Console.ReadLine();
            option = option.ToLower().Trim();
            Console.Clear();

            while (option != "quit")
            {
                switch (option)
                {
                    case "attack":
                        if (playerTwo.HitPoints != 0)
                        {
                            Console.WriteLine(playerOne.Name + " attacks!");
                            playerTwo.TakeDamage();

                            playerTwo.Print();


                            option = Console.ReadLine();
                            option = option.ToLower().Trim();

                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine(playerTwo.Name + " dies.");
                            return;
                        }
                        break;
                    case "defend":
                        Console.WriteLine(playerTwo.Name + " attacks!");
                        playerOne.TakeDamage();

                        playerOne.Print();

                        option = Console.ReadLine();
                        option = option.ToLower().Trim();
                        Console.Clear();
                        break;
                    case "quit":
                        break;
                    default:
                        Console.WriteLine("Invalid option, try again.\n");
                        option = Console.ReadLine();
                        option = option.ToLower().Trim();
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("Quit.");

        }
    }
}
