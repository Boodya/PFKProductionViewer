using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFKProductionViewer.Models
{
    public class Shifts
    {
        public ShiftActual ShiftActual { get; set; }
        public ShiftPreviou ShiftPrevious { get; set; }

        public Shifts()
        {

        }

        public Shifts(string type, LatheContext dbDataContext)
        {
            if (type == Consts.UrlParameters.Current)
                ShiftActual = dbDataContext.ShiftActuals.FirstOrDefault();
            if (type == Consts.UrlParameters.Current)
                ShiftPrevious = dbDataContext.ShiftPrevious.LastOrDefault();
        }
    }
}
