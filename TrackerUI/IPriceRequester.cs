using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentTracker.Models;

namespace TrackerUI
{
    public interface IPriceRequester
    {
        void PriceComplete(PriceModel model);
    }
}
