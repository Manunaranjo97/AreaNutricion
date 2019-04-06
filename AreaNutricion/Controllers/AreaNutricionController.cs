
using System.Web.Mvc;

namespace AreaNutricion.Controllers
{
    public class AreaNutricionController : Controller
    {
        public ActionResult Migrante()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Local()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Indicadores()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpPost]
        public ActionResult Migrante(FormCollection form)
        {
            ViewBag.mensaje = "La información fue guardada";

            return View();
        }

        [HttpPost]
        public ActionResult Local(FormCollection form)
        {
            ViewBag.mensaje = "La información fue guardada";

            return View();
        }

        [HttpPost]
        public ActionResult Indicadores(FormCollection form)
        {
            ViewBag.mensaje = "La información fue guardada";

            return View();
        }
    }
}


