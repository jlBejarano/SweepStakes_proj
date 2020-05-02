using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class sweepstakes
    {
        public string name { get; set; }
        public int winnersNumber;
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        Random random = new Random();

        public sweepstakes(string name)
        {
            this.name = name;
        }

        public sweepstakes()
        {
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.firstName = Interface.FirstName();
            contestant.lastName = Interface.LastName();
            contestant.emailAddress = Interface.EmailAdress();
            contestant.registrationNumber = Interface.RegistrationNumber();
        }

        public void GetWinner()
        {
            Random random = new Random();
            winnersNumber = random.Next();
        }




       
        

        



        
        
        

    }


   
}
