using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capa_Negocio;
using Capa_Entidaddes;
using System.Web.Mvc;

namespace Capa_Presentacion.Controllers
{
    public class detalles_NominaController : Controller
    {
        // GET: detalles_Nomina
        private readonly Detalles_NominaNegocio _negocio;

        public detalles_NominaController()
        {
            _negocio = new Detalles_NominaNegocio();
        }

        // GET: detalles_Nomina
        public ActionResult Index()
        {
            var leer = _negocio.leer();
            return View(leer);
        }

        //Crear Empleeado
        public ActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear(Detalles_nomina detalles_Nomina)
        {
            _negocio.Detalles_NominasCrear(detalles_Nomina);
            return View();
        }

        //Editar Empleeado
        [HttpGet]
        public ActionResult Editar(int id)
        {
            var detalles_Nomina = _negocio.GetDetalles_Nomina(id);

            if (detalles_Nomina == null)
            {
                return null;
            }

            return View(detalles_Nomina);
        }

        [HttpPost]
        public ActionResult Editar(Detalles_nomina detalles_Nomina)
        {
            if (ModelState.IsValid)
            {
                _negocio.Editar(detalles_Nomina);
                return RedirectToAction(nameof(Index));
            }

            return View(detalles_Nomina);
        }

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            var detalles_Nomina = _negocio.GetDetalles_Nomina(id);

            if (detalles_Nomina == null)
            {
                return null;
            }

            return View(detalles_Nomina);
        }

        [HttpPost]
        public ActionResult Eliminar(Detalles_nomina detalles_Nomina)
        {
            if (ModelState.IsValid)
            {
                _negocio.Eliminar(detalles_Nomina);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}