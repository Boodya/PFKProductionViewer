using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PFKProductionViewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFKProductionViewer.Controllers
{
    public class RauteVEController : Controller
    {
        private IConfiguration _config { get; }
        public RauteVEController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            return View("RauteVECurrent");
        }

        public IActionResult Current()
        {
            ViewData["Bins"] = LatheContext.GetAllBins(
                _config.GetConnectionString("RauteVE"));
            ViewData["Shifts"] = LatheContext.GetAllShiftsActual(
                _config.GetConnectionString("RauteVE"));
            return View("RauteVECurrent");
        }

        public IActionResult Previous()
        {
            ViewData["Bins"] = LatheContext.GetAllBins(
                _config.GetConnectionString("RauteVE"));
            ViewData["Shifts"] = LatheContext.GetAllShiftsPrevious(
                _config.GetConnectionString("RauteVE"));
            return View("RauteVEPrevious");
        }
    }
}
