using AppointmentMaker.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentMaker.Controllers
{
    public class AppointmentController : Controller
    {
        static List<AppointmentModel> appointments = new List<AppointmentModel>();
        public IActionResult Index()
        {
            return View(appointments);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(AppointmentModel appointment) 
        {
            if(!(appointment == null)) 
            {
                appointments.Add(appointment);
            }
            return View(appointment);
        }
    }
}
