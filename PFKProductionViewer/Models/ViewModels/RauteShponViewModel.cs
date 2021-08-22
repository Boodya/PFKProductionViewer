using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFKProductionViewer.Models
{
    public class RauteShponViewModel
    {
        public int CollPack11 { get; set; }
        public int OveralCollList11 { get; set; }
        public float OveralVList11 { get; set; }
        public int CollPack12 { get; set; }
        public int OveralCollList12 { get; set; }
        public float OveralVList12 { get; set; }
        public int CollPack13 { get; set; }
        public int OveralCollList13 { get; set; }
        public float OveralVList13 { get; set; }

        public RauteShponViewModel(ShiftActual actualShift)
        {
            CollPack11 = actualShift.CollPack11;
            CollPack12 = actualShift.CollPack12;
            CollPack13 = actualShift.CollPack13;
            OveralCollList11 = actualShift.OveralCollList11;
            OveralCollList12 = actualShift.OveralCollList12;
            OveralCollList13 = actualShift.OveralCollList13;
            OveralVList11 = actualShift.OveralVList11;
            OveralVList12 = actualShift.OveralVList12;
            OveralVList13 = actualShift.OveralVList13;
        }

        public RauteShponViewModel(ShiftPreviou previousShift)
        {
            CollPack11 = previousShift.CollPack11;
            CollPack12 = previousShift.CollPack12;
            CollPack13 = previousShift.CollPack13;
            OveralCollList11 = previousShift.OveralCollList11;
            OveralCollList12 = previousShift.OveralCollList12;
            OveralCollList13 = previousShift.OveralCollList13;
            OveralVList11 = previousShift.OveralVList11;
            OveralVList12 = previousShift.OveralVList12;
            OveralVList13 = previousShift.OveralVList13;
        }
    }
}
