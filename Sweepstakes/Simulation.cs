﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Simulation
    {
        public void CreateMarketingFirmManager()
        {
            MarketingFirm marketingFirm = new MarketingFirm();
            marketingFirm.CreateSweepstakes();
        }
    }
}
