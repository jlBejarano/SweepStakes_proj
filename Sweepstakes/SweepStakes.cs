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

        public Contestant PickWinner()
        {
            winnersNumber = random.Next(0, (contestants.Count - 1));
            foreach(KeyValuePair<int, Contestant> contestant in contestants)
            {

                if(contestants.Count == 0)
                {
                    Console.WriteLine("No registered contestants.");
                }
                else if (contestant.Key == winnersNumber)
                {
                return contestant.Value;
                }
            }
            return PickWinner();
           
        }
        

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName + contestant.lastName + contestant.emailAddress + contestant.registrationNumber);
        }




       
        

        



        
        
        

    }


   
}
