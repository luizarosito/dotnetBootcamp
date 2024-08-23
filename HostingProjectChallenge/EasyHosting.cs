using dotnetBootcamp.HostingProjectChallenge.Models;

namespace dotnetBootcamp.HostingProjectChallenge
{
    public class EasyHosting
    {
        public void AddReservationtion()
        {
            List<Person> guest = new List<Person>();

            Person p1 = new Person(name: "Guest 1");
            Person p2 = new Person(name: "Guest 2");

            guest.Add(p1);
            guest.Add(p2);

            Home home = new Home(type: "Entire house", capacity: 2, monthlyValue: 1500);

            Reservationtion reservation = new Reservationtion(monthsReservation: 5);
            reservation.RegisterHome(home);
            reservation.RegisterGuest(guest);

            Console.WriteLine($"Guest: {reservation.GetNumberGuest()}");
            Console.WriteLine($"Monthly value: {reservation.CalculateMonthlyValue()}");
        }
        
    }
}