using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<sweepstakes> queue = new Queue<sweepstakes>();

        public SweepstakesQueueManager()
        {

        }
        public void InsertSweepstakes(sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
        public sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
        }


    }

    public interface ISweepstakesManager
    {
        void InsertSweepstakes(sweepstakes newSweepstakes);
    }
}
