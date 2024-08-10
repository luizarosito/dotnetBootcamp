using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetBootcamp.FundamentalsChallenge
{
    public class MenuWOnRent
    {
        WOnRentModel response = new WOnRentModel();

        decimal initialPrice = 5;
        decimal hourlyRate = 3;

        

        public void Menu(){
            WheelsOnRent rent = new WheelsOnRent();

            Console.WriteLine("Welcome Wheels on Rent");

            string opcao = string.Empty;
            bool showMenu = true;

            while (showMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Rent transpot");
                Console.WriteLine("2 - Remove transpot");
                Console.WriteLine("3 - Show transpot rent");
                Console.WriteLine("4 - Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        rent.AddTransport();
                        break;

                    case "2":
                        rent.RemoveTransport();
                        break;

                    case "3":
                        rent.ListTransports();
                        break;

                    case "4":
                        showMenu = false;
                        break;

                    default:
                    Console.WriteLine("Invalid option");
                    break;
                }
            }
            Console.WriteLine("Program exit");
        }
    }
}