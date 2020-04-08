using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
            public string firstName;
            public string lastName;
            public string emailAddress;
            public int registrationNumber;
            public Contestant contestant;

        public Contestant(string firstName, string lastName, string emailAddress, int registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.registrationNumber = registrationNumber;
        }

        public void AddContestant(Contestant contestant)
        {
            List<string> contestants = new List<string>();
            contestant.Add("first name");
            contestant.Add("last name");
            contestant.Add("email address");
            contestant.Add("registration number");


        }

        private void Add(string v)
        {
            
        }
    }
}
