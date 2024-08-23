using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetBootcamp.HostingProjectChallenge.Models
{
    public class Reservationtion
    {
        public List<Person> Guest {get; set; }
        public Home Home { get; set; }
        public int MonthsReservation { get; set; }

        public Reservationtion() {}

        public Reservationtion(int monthsReservation) 
        {
            MonthsReservation = monthsReservation;
        }

        public int GetNumberGuest()
        {
            int numberGuest = Guest.Count;
            Console.WriteLine(numberGuest);
            return numberGuest;
        }
        public void RegisterGuest(List<Person> guest)
        {
            if (GetNumberGuest() <= Home.Capacity)
            {
                Guest = guest;
                Console.WriteLine("Register sucessfull.");
            }
            else
            {
                Console.WriteLine($"Sorry, This house is for up to {Home.Capacity} people.");
            }
        }

         public void RegisterHome(Home home)
        {
            Home = home;
        }

        public decimal CalculateMonthlyValue()
        {
            decimal value = 0;

            // If months >= 6, apply 10% discount
            if (MonthsReservation >= 6)
            {
                var discount = 10 / 100;
                value = (Home.MonthlyValue * MonthsReservation) - discount ;
            }
            else {
                value = Home.MonthlyValue * MonthsReservation;
            }
            Console.WriteLine($"Total price: {value}");
            return value;
        }

    }
}