using System;
namespace BusTicketBooking
{
    class ChosenBus : AvailableBus
    {
        public int[] Seats=new int[10];
        public void busbook()
        {
            Console.WriteLine("The Available Seats : 10");
            Console.WriteLine("Enter seat NUMBER to Book : ");
            string temp =Console.ReadLine();
            int sNum=int.Parse(temp);
            
            if(Seats[sNum-1]==0)
            {
                Seats[sNum-1]=1;
                Console.WriteLine("\nYour Seat Booked Successfully");
            }
            else
            {
                Console.WriteLine("\nSeat Already Booked... Try Another");
            }
            }
        }
  }
