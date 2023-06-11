using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Company.Controllers
{
    public class LandingpageController : Controller
    {
        // GET: Landingpage
        public ActionResult Index()
        {
            ViewBag.Company_name = "AD Technology";
            ViewBag.Bio = "Welcome to AD Technology, a leading provider of innovative technology solutions. At AD Technology, we specialize in developing cutting-edge software and delivering exceptional IT services to help businesses thrive in the digital age. With our expertise in web development, mobile applications, and enterprise solutions, we empower our clients to stay ahead of the competition.";
            return View();
        }
        public ActionResult Services()
        {

            ViewBag.Software_Development = "Software Development = Designing, developing, and maintaining software solutions, including web applications, mobile apps, custom software, and enterprise software.";




            ViewBag.Web_Development = "Web Development = Creating websites, web applications, and e-commerce platforms, including front-end and back-end development, user interface (UI) and user experience (UX) design, content management systems (CMS), and website maintenance.";




            ViewBag.Mobile_App_Development = " Mobile App Development = Developing native or cross-platform mobile applications for iOS and Android devices, including UI/UX design, integration with backend systems, and app maintenance.";





            ViewBag.IT_Consulting = " IT Consulting = Providing technology consulting services to help businesses align their IT strategies with their overall goals, recommending suitable technologies, optimizing processes, and conducting IT audits.";





            ViewBag.Data_Analytics = " Data Analytics = Analyzing and interpreting data to extract valuable insights, creating dashboards and reports, implementing data visualization tools, and providing predictive analytics solutions.";

            
           

            return View();
        }
        public ActionResult Teams_and_members()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        
    }

    internal class Services
    {
        internal string Software_Development;
        internal string Web_Development;
        internal string Mobile_App_Development;
        internal string IT_Consulting;
        internal string Data_Analytics;

        public Services()
        {
        }
    }
}