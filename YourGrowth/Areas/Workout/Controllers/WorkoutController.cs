using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YourGrowth.Areas.Workout.Controllers
{
    public class WorkoutController : Controller
    {
        // GET: Workout/Workout
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}