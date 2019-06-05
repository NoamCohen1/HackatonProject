
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace HackatonProject.Models
{
    public class BusinessInfoModel
    {
        private static int counter = 0;
        private static BusinessInfoModel s_instace = null;
        public const string SCENARIO_FILE = "~/App_Data/{0}.txt";
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string Location { get; set; }
        public string TourOfDuty { get; set; }
        public string JobsRequirements { get; set; }

        public static BusinessInfoModel Instance
        {
            get
            {
                if (s_instace == null)
                {
                    s_instace = new BusinessInfoModel();
                }
                return s_instace;
            }
        }

        public void AddToDB()
        {
            string path = HttpContext.Current.Server.MapPath(String.Format(SCENARIO_FILE, CompanyName+counter));  
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                file.WriteLine(CompanyName);
                file.WriteLine(JobTitle);
                file.WriteLine(Location);
                file.WriteLine(TourOfDuty);
                file.WriteLine(JobsRequirements);
            }
            
        }
    }
}