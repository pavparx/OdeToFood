using System;
using System.Web.Mvc;
using OdeToFood.Filters;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine

        //[Authorize]
        [Log]
        public ActionResult Search(string name = "french")
        {

            throw new Exception("Something happened");
            var message = Server.HtmlEncode(name);

            return Content(message);
        }

       
    }
}