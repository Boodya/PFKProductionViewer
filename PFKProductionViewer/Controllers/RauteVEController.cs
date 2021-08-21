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
            if (type == "Current")
                ViewData["PageHead"] = "Текущая смена";
            else if(type == "Previous")
                ViewData["PageHead"] = "Предыдущая смена";
            return View("RauteVE");
        }

        [HttpGet]
        public ActionResult RauteTotalView(string type)
        {
            return PartialView("RauteTotalView", 
                new RauteTotalViewModel(
                    _dbData.LatheContext.ShiftActuals.FirstOrDefault()));
        }
        [HttpGet]
        public ActionResult RauteTableView(string type)
        {
            return PartialView("RauteTableView", 
                _dbData.LatheContext.BinsActuals.FirstOrDefault());
        }
        [HttpGet]
        public ActionResult RauteChurakView(string type)
        {
            return PartialView("RauteChurakView", 
                new RauteChurakViewModel(
                    _dbData.LatheContext.ShiftActuals.FirstOrDefault(),
                    _dbData.LatheContext.BinsActuals.FirstOrDefault()));
        }
        [HttpGet]
        public ActionResult RauteShponView(string type)
        {
            return PartialView("RauteShponView", 
                new RauteShponViewModel(_dbData.LatheContext
                    .ShiftActuals.FirstOrDefault()));
        }
    }
}
