using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager SweepstakesManager;

        public MarketingFirm()
        {
            this.SweepstakesManager = new ISweepstakesManager();
        }
    }
}
