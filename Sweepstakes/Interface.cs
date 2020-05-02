using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class Interface
    {
        private static int registrationNumber;

        public static string FirstName()
        {
            Console.WriteLine("Enter first name.");
            return Console.ReadLine();
        }

        public static string LastName()
        {
             Console.WriteLine("Enter last name.");
             return Console.ReadLine();
        } 
        
        public static string EmailAdress()
        {
            Console.WriteLine("Enter email address.");
            return Console.ReadLine();
        }

        public static int RegistrationNumber()
        {
            registrationNumber = +1;
            Console.WriteLine("What is your registration number?");
            return registrationNumber;
        }  
    }
}
