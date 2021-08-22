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
        private readonly LatheContext _latheContext;
        public RauteVEController(LatheContext latheContext)
        {
            _latheContext = latheContext;
        }

        public IActionResult Index(string type)
        {
            if (type == Consts.UrlParameters.Current)
                ViewData["PageHead"] = "Текущая смена";
            else if(type == Consts.UrlParameters.Previous)
                ViewData["PageHead"] = "Предыдущая смена";
            return View("RauteVE");
        }

        [HttpGet]
        public ActionResult RauteTotalView(string type)
        {
            var model = type == Consts.UrlParameters.Current ?
                new RauteTotalViewModel(_latheContext.ShiftActuals.FirstOrDefault()) :
                new RauteTotalViewModel(_latheContext.ShiftPrevious.FirstOrDefault());
            return PartialView("RauteTotalView", model);
        }
        [HttpGet]
        public ActionResult RauteTableView(string type)
        {
            return PartialView("RauteTableView", 
                _latheContext.BinsActuals.FirstOrDefault());
        }
        [HttpGet]
        public ActionResult RauteChurakView(string type)
        {
            var model = type == Consts.UrlParameters.Current ?
                new RauteChurakViewModel(_latheContext.ShiftActuals.FirstOrDefault(),
                    _latheContext.BinsActuals.FirstOrDefault()) :
                new RauteChurakViewModel(_latheContext.ShiftPrevious.FirstOrDefault(),
                    _latheContext.BinsActuals.FirstOrDefault());

            return PartialView("RauteChurakView", model);                    
        }
        [HttpGet]
        public ActionResult RauteShponView(string type)
        {
            var model = type == Consts.UrlParameters.Current ?
                new RauteShponViewModel(_latheContext.ShiftActuals.FirstOrDefault()) :
                new RauteShponViewModel(_latheContext.ShiftPrevious.FirstOrDefault());
            return PartialView("RauteShponView", model);
        }
        [HttpGet]
        public ActionResult RauteTab(string type)
        {
            return PartialView("RauteTab");
        }
    }
}
