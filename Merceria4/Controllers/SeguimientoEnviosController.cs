using Merceria4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Merceria4.Controllers
{
    public class SeguimientoEnviosController : Controller
    {
        // GET: SeguimientoEnvios
        public ActionResult Index(int id)
        {
            contextMerceria2 db = new contextMerceria2();

            List<Envios> listaEnvios = null;

            var query = from e in db.Envios
                        where e.Ventas.Id_Usuario == id
                        select e;
            listaEnvios = query.ToList();

            ViewBag.listaEnvios = listaEnvios;

            return View();
        }
    }
}