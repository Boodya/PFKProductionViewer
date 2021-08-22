using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFKProductionViewer.Models
{
    public class RauteTotalViewModel : RauteShponViewModel
    {
        public int SquarePacks { get { return CollPack11 + CollPack12; } }
        public int SquareSheets { get { return OveralCollList11 + OveralCollList12; } }
        public float SquareVolume { get { return OveralVList11 + OveralVList12; } }
        public int BigFormatPacks { get { return CollPack13; } }
        public int BigFormatSheets { get { return OveralCollList13; } }
        public float BigFormatVolume { get { return OveralVList13; } }
        public int TotalPacks { get { return SquarePacks + BigFormatPacks; } }
        public int OveralCollList { get; set; }
        public float OveralVList { get; set; }

        public RauteTotalViewModel(ShiftActual actualShift) : base(actualShift)
        {
            OveralCollList = actualShift.OveralCollList;
            OveralVList = actualShift.OveralVList;
        }

        public RauteTotalViewModel(ShiftPreviou previousShift) : base(previousShift)
        {
            OveralCollList = previousShift.OveralCollList;
            OveralVList = previousShift.OveralVList;
        }
    }
}
