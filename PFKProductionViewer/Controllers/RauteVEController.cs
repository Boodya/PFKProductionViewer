using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PFKProductionViewer.Models;
using PFKProductionViewer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFKProductionViewer.Controllers
{
    public class RauteVEController : Controller
    {
        private IConfiguration _config { get; }
        private static LatheDataService _dbData;
        public RauteVEController(IConfiguration config)
        {
            _config = config;
            if(_dbData == null)
                _dbData = new LatheDataService(_config);
        }

        public IActionResult Index()
        {
            return View("RauteVECurrent");
        }

        public IActionResult Current()
        {
            ViewData["Bins"] = _dbData.GetAllBins();
            ViewData["CurrentShifts"] = _dbData.GetAllShiftsActual();
            _dbData.SubscribeToDataUpdate(OnDBDataUpdated);
            return View("RauteVECurrent");
        }

        public IActionResult Previous()
        {
            ViewData["Bins"] = _dbData.GetAllBins();
            ViewData["PreviousShifts"] = _dbData.GetAllShiftsPrevious();
            _dbData.SubscribeToDataUpdate(OnDBDataUpdated);
            return View("RauteVEPrevious");
        }

        private void OnDBDataUpdated(LatheContext data)
        {
            ViewData["Bins"] = _dbData.GetAllBins();
            ViewData["PreviousShifts"] = _dbData.GetAllShiftsPrevious();
            ViewData["PreviousShifts"] = _dbData.GetAllShiftsPrevious();
        }
    }
}
