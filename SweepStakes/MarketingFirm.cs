﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        private ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        public void CreateSweepStakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes(IUserInterface.SweepstakesName());
            string holding = IUserInterface.PickManager();
            if (holding == "stack")
            {
                SweepstakesStackManager.
            }
        }
    }
}
