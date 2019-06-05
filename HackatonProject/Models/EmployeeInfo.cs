using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HackatonProject.Models
{
    public class EmployeeInfo
    {
        private static EmployeeInfo s_instace = null;

        public static EmployeeInfo Instance
        {
            get
            {
                if (s_instace == null)
                {
                    s_instace = new EmployeeInfo();
                }
                return s_instace;
            }
        }

        public const string SCENARIO_FILE = "~/App_Data/{0}.txt";           // The Path of the Secnario


        public void RData()
        {
            string path = HttpContext.Current.Server.MapPath(String.Format(SCENARIO_FILE, Fullname));



            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                file.WriteLine(Fullname);
                file.WriteLine(typeOfJob);
                file.WriteLine(Location);
                file.WriteLine(TourOfDuty);
                file.WriteLine(Age);
                file.WriteLine(drivingLicense);
                file.WriteLine(PhoneNumber);
                file.WriteLine(Notes);
                file.WriteLine(EmailAddress);
            }

        }


        public string Fullname { get; set; }
        public string typeOfJob { get; set; }
        public string Location { get; set; }
        public string TourOfDuty { get; set; }
        public string Age { get; set; }
        public string drivingLicense { get; set; }
        public string PhoneNumber { get; set; }
        public string Notes { get; set; }
        public string EmailAddress { get; set; }
    }
}