using System;
namespace BusTicketBooking
{
    class Credential
    {
        int choice,length;
        String loginName,registrationName,registrationPassword,loginPassword;
        public void logreg()//Registration and Login Credential.
        {
            Console.WriteLine("::: Welcome to RedBus :::");
            do{
            Console.WriteLine("Enter 1 for Registration \nEnter 2 for login ");
            Console.WriteLine("Note : If user name or password forgoted please create anthor account");
            Console.WriteLine("By Enter 1 for new account.");

            choice = int.Parse(Console.ReadLine());
            }while(choice != 1 && choice != 2);

            switch(choice)
            {
                case 1:
                {
                    Console.WriteLine("THANK YOU FOR CHOOSING");
                    Console.WriteLine("    OUR APPLICATION:) ");
                    Console.WriteLine("Registration    ");
                    Console.WriteLine("User Name :");
                    registrationName = Console.ReadLine();
                    do{
                    Console.WriteLine("Password :");
                    Console.WriteLine("condition : must be in 8 character");
                    registrationPassword = Console.ReadLine();
                    length = registrationPassword.Length;
                    }while(length != 8);
                    break;
                }
                case 2:
                {
                    do{
                    Console.WriteLine(":::   Login Credential   :::");
                    Console.WriteLine("***Enter Correct User Name And Password***");
                    Console.WriteLine("User Name :");
                    loginName = Console.ReadLine();
                    Console.WriteLine("Password :");
                    loginPassword = Console.ReadLine();
                    }while(loginName != registrationName || loginPassword != registrationPassword);
                    break;
                }
                default :
                {
                    Console.WriteLine("There is no way to come in default because i have used do while loop");
                    break;
                }
                
            }
        }
    }

}
    