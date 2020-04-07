using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        private Stack<SweepStakes> sweepstakeStack;

        public Stack<SweepStakes> SweepstakeStack { get => sweepstakeStack; set => sweepstakeStack = value; }
    }
}
