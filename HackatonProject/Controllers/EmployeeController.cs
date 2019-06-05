using HackatonProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HackatonProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewProfile()
        {

            return View();
        }

        [HttpPost]
        public ActionResult WriteNewProfile(EmployeeInfo input)
        {
            EmployeeInfo.Instance.Fullname = input.Fullname;
            EmployeeInfo.Instance.typeOfJob = input.typeOfJob;
            EmployeeInfo.Instance.Location = input.Location;
            EmployeeInfo.Instance.TourOfDuty = input.TourOfDuty;
            EmployeeInfo.Instance.Age = input.Age;
            EmployeeInfo.Instance.drivingLicense = input.drivingLicense;
            EmployeeInfo.Instance.PhoneNumber = input.PhoneNumber;
            EmployeeInfo.Instance.Notes = input.Notes;
            EmployeeInfo.Instance.EmailAddress = input.EmailAddress;


            EmployeeInfo.Instance.RData();
            return Json(HttpStatusCode.OK);
        }
    }
}