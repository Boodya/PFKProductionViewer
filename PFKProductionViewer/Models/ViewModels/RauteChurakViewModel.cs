using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFKProductionViewer.Models
{
    public class RauteChurakViewModel
    {
        public float PercentLossVeneer { get; set; }
        public float RateMedium { get; set; }
        public int ColBlock { get; set; }
        public int MediumDBlock { get; set; }
        public float VBlock { get; set; }
        public float VCil { get; set; }
        public float VCore { get; set; }
        public float LossCil { get; set; }
        public float LossCore { get; set; }
        public float MediumDCore { get; set; }
        public float Thickness { get; set; }

        public RauteChurakViewModel(ShiftActual actualShift, BinsActual actualBins)
        {
            PercentLossVeneer = actualShift.PercentLossVeneer;
            RateMedium = actualShift.RateMedium;
            ColBlock = actualShift.ColBlock;
            MediumDBlock = actualShift.MediumDBlock;
            VBlock = actualShift.VBlock;
            VCil = actualShift.VCil;
            VCore = actualShift.VCore;
            LossCil = actualShift.LossCil;
            LossCore = actualShift.LossCore;
            MediumDCore = actualShift.MediumDCore;
            Thickness = actualBins.Thickness;
        }

        public RauteChurakViewModel(ShiftPreviou previousShift, BinsActual actualBins)
        {
            PercentLossVeneer = previousShift.PercentLossVeneer;
            RateMedium = previousShift.RateMedium;
            ColBlock = previousShift.ColBlock;
            MediumDBlock = previousShift.MediumDBlock;
            VBlock = previousShift.VBlock;
            VCil = previousShift.VCil;
            VCore = previousShift.VCore;
            LossCil = previousShift.LossCil;
            LossCore = previousShift.LossCore;
            MediumDCore = previousShift.MediumDCore;
            Thickness = actualBins.Thickness;
        }
    }
}
