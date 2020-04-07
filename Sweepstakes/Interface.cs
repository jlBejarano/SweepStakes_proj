using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Interface
    {
        public string getfirstName, getlastName, getemailAddress;
        public int getregistrationNumber;

        public string regNum { get; set; }

        public void GetFirstName()
        {
             Console.WriteLine("What is your first name?");
             Console.ReadLine();
        } 
        
        public void GetLastName()
        {
            Console.WriteLine("What is your last name?");
            Console.ReadLine();
        }

        public void GetEmailAddress()
        {
            Console.WriteLine("What is your email address?");
            Console.ReadLine();
        }

        public void GetRegistrationNumber()
        {
            Console.WriteLine("The registration number is "+regNum);
            Console.ReadLine();
        }
       
       
    }
}
