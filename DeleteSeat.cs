using System;
namespace BusTicketBooking
{
    class DeleteSeat : ChosenBus
    {
        public string value;
        int values;
         public void cancel()
                {
                    do{
                        Console.WriteLine("Enter 1 to Delete Seat");
                        Console.WriteLine("If not Enter 2");
                        Console.WriteLine("Enter correct option");
                        value = Console.ReadLine();
                        values=int.Parse(value.ToString());
                    }while(values <=0 && values >2);

                    if(values == 1)
                    {
                    Console.WriteLine("\nYour Ticket Cancelled Successfully");
                    Console.WriteLine("Sorry your are not eligible for Travel..");
                    Console.WriteLine("BOOK AGAIN:)\nThankyou:)");    
                    }
                    else{
                        Console.WriteLine("Have a Safe Ride :)");
                    }
                    
                }
    }
}