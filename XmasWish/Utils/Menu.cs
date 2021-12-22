using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmasWish.Utils
{
    public class Menu
    {
        public void mainMenu()
        {
            //FamilyTree familyTree = new();
            //familyTree.StarkFamily();

            bool run = true;

            Console.WriteLine("---XMAS WISH---");
            Thread.Sleep(2000);
            Console.Clear();

            while (run)
            {
                Console.WriteLine("------Menu------");
                Console.WriteLine("1) Show ALL ");
                Console.WriteLine("2) Create:");
                Console.WriteLine("3) Create:");
                Console.WriteLine("4) Create:");
                Console.WriteLine("5) Read: ");
                Console.WriteLine("6) Read: ");
                Console.WriteLine("7) Read: ");
                Console.WriteLine("8) Update:");
                Console.WriteLine("9) Update:");
                Console.WriteLine("10) Update:");
                Console.WriteLine("11) Delete:");
                Console.WriteLine("12) Delete:");
                Console.WriteLine("13) Delete:");
                Console.WriteLine("14) Exit");

                string userInput = Console.ReadLine();
                int menuInput = 0;
                int.TryParse(userInput, out menuInput);
               // PersonCrud personCrud = new PersonCrud();

                switch (menuInput)
                {
                    case 1:
                       
                        Console.Clear();
                        break;
                    case 2:
                  
                        Console.Clear();
                        break;
                    case 3:
                     
                        Console.Clear();
                        break;
                    case 4:
                      
                        Console.Clear();
                        break;
                    case 5:
                      
                        Console.Clear();
                        break;
                    case 6:
                    
                        Console.Clear();
                        break;
                    case 7:
                      
                        Console.Clear();
                        break;
                    case 8:
                   
                        Console.Clear();
                        break;
                    case 9:
                       
                        Console.Clear();
                        break;
                    case 10:
                     
                        Console.Clear();
                        break;
                    case 11:
                    
                        Console.Clear();
                        break;
                    case 12:
                       
                        Console.Clear();
                        break;
                    case 13:
                      
                        Console.Clear();
                        break;
                    case 14:
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Input a number between 1-14.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
