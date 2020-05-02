using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        
        public string name;
        public int winnersNumber;
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        Random random = new Random();

        public Sweepstakes(string name)
        {
            this.name = name;
        
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.firstName = Interface.firstName();
            Interface.ConterstantfirstName();
        }


       
        

        



        
        
        

    }


   
}
