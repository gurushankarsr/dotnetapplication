// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace BusTicketBooking
{
    class Program
    {
    static void Main(string[] args)
    {
        DeleteSeat obj = new DeleteSeat();
        obj.logreg();
        obj.availableBus();
        obj.busbook();
        obj.cancel();
    }
}
}