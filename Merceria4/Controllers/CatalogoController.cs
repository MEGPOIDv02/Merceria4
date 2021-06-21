using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Merceria4.Models;
namespace Merceria4.Controllers
{
    public class CatalogoController : Controller
    {
        private contextMerceria2 db = new contextMerceria2();
        // GET: Catalogo
        public ActionResult Index()
        {
            return View();
        }

        


    }
}