using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<sweepstakes> stack = new Stack<sweepstakes>();

        public SweepstakesStackManager()
        {

        }
        public void InsertSweepstakes(sweepstakes sweepStakes)
        {
            stack.Push(sweepStakes);
        }
        public sweepstakes GetSweepstakes()
        {
            Interface.RegistrationNumber();
            return stack.Pop();
        }
    }
}
