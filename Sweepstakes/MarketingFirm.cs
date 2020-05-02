﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        public  ISweepstakesManager manager;

        public MarketingFirm()
        {
        }

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        public void CreateSweepstakes()
        {
            sweepstakes Sweepstakes = new sweepstakes();
            manager.InsertSweepstakes(Sweepstakes);
        }
    }
}
