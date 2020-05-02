using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack = new Stack<Sweepstakes>();

        public SweepstakesStackManager()
        {

        }
        public void InsertSweepstakes(Sweepstakes sweepStakes)
        {
            stack.Push(sweepStakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            Interface.registrationNumber();
            return stack.Pop();
        }
    }
}
