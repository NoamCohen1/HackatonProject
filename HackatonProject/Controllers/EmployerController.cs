using HackatonProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HackatonProject.Controllers
{
    public class EmployerController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employer
        public ActionResult BusinessInfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(BusinessInfoModel data)
        {
            BusinessInfoModel.Instance.CompanyName = data.CompanyName;
            BusinessInfoModel.Instance.JobTitle = data.JobTitle;
            BusinessInfoModel.Instance.JobsRequirements = data.JobsRequirements;
            BusinessInfoModel.Instance.Location = data.Location;
            BusinessInfoModel.Instance.TourOfDuty = data.TourOfDuty;

            BusinessInfoModel.Instance.AddToDB();
            return Json(HttpStatusCode.OK);
        }
    }
}