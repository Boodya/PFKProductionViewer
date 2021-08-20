using System;
using System.Collections.Generic;

#nullable disable

namespace PFKProductionViewer.Models
{
    public partial class BinsActual
    {
        public float Thickness { get; set; }
        public int Bin1Sheets { get; set; }
        public float Bin1Volume { get; set; }
        public int Bin2Sheets { get; set; }
        public float Bin2Volume { get; set; }
        public int Bin3Sheets { get; set; }
        public float Bin3Volume { get; set; }
    }
}
