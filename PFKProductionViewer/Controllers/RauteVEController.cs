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
        private static LatheDataService _dbData;
        public RauteVEController(IServiceProvider serviceProvider)
        {
            _dbData = (LatheDataService)serviceProvider
                .GetService(typeof(LatheDataService));
        }

        public IActionResult Index(string type)
        {
            return View("RauteVE");
        }

        public IActionResult Current()
        {
            return View("RauteVECurrent", _dbData.GetContext());
        }

        [HttpGet]
        public ActionResult RauteVECurrent()
        {
            return PartialView("RauteVECurrent", _dbData.GetContext());
        }

        [HttpGet]
        public ActionResult RauteVEPrevious()
        {
            return PartialView("RauteVEPrevious", _dbData.GetContext());
        }

        public IActionResult Previous()
        {
            return View("RauteVEPrevious", _dbData.GetContext());
        }

        [HttpGet]
        public ActionResult RauteTotalView()
        {
            return PartialView("RauteTotalView", new RauteTotalViewModel());
        }
        [HttpGet]
        public ActionResult RauteTableView()
        {
            return PartialView("RauteTableView", new RauteTableViewModel());
        }
        [HttpGet]
        public ActionResult RauteChurakView()
        {
            return PartialView("RauteChurakView", new RauteChurakViewModel());
        }
        [HttpGet]
        public ActionResult RauteShponView()
        {
            return PartialView("RauteShponView", new RauteShponViewModel());
        }
    }
}
