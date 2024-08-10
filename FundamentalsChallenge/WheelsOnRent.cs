using System.Collections.Concurrent;
using System.Net.Cache;

namespace dotnetBootcamp.FundamentalsChallenge 
{
    public class WheelsOnRent{
        public static List<string> bikes = new List<string>();

        WOnRentModel request = new WOnRentModel();
        public WheelsOnRent() {
            
        }

        public void AddTransport() 
        {
            Console.WriteLine("Write transport code do you want rent:");
            request.wheelCode = Convert.ToString(Console.ReadLine());

            bikes.Add(request.wheelCode);
        }

        public void RemoveTransport() {
            
            Console.WriteLine("Write transport code do you want return:");   

            if (request.transport.Any(x => x.ToUpper() == request.wheelCode.ToUpper())) 
            {
                Console.WriteLine("What time do you stay with bike?");   

                request.totalPrice = (request.initialPrice + request.hourlyRate) * request.totalTime;
                
                // remover da lista de alugados 

                Console.WriteLine($"The transport {request.wheelCode} has been removed and total price is: $ {request.totalPrice}");
            }
            else 
            {
                Console.WriteLine("Sorry, this code is incorrect. Please, try again.");

            }
        }

        public void ListTransports() 
        {
            if (request.transport.Any()) {
                Console.WriteLine("Transports rented:");
                foreach(var bikes in request.transport)
                {
                    Console.WriteLine(bikes);
                }
            } 
            else 
            {
                Console.WriteLine("All transport is available.");
            }
        }

    }
}

