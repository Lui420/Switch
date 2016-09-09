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
            //ovning1
            Console.WriteLine("Mata i tal 1-4");
            int tal = int.Parse(Console.ReadLine());

            switch (tal)
            {
                case 1:
                    Console.WriteLine("ett");
                    break;
                case 2:
                    Console.WriteLine("två");
                    break;
                case 3:
                    Console.WriteLine("tre");
                    break;
                case 4:
                    Console.WriteLine("fyra");
                    break;
                default:
                    Console.WriteLine("ogiltlig alternativ");
                    break;
            }



            //ovning2
            Console.WriteLine("Mata i bokstaven n,s,e,w");
            string bokstav = Console.ReadLine();

            switch (bokstav)
            {
                case "n":
                    Console.WriteLine("You walk north");
                    break;
                case "s":
                    Console.WriteLine("You travel south");
                    break;
                case "e":
                    Console.WriteLine("You wander east");
                    break;
                case "w":
                    Console.WriteLine("You stroll west");
                    break;
                default:
                    Console.WriteLine("i dont understand");
                    break;

            }

            //ovning3

            Console.ReadKey();
        }
    }
}
         
        
    
