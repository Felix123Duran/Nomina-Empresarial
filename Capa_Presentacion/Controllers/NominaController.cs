using System;
using System.Collections.Generic;
using System.Linq;
using Capa_Entidaddes;
using Capa_Negocio;
using System.Web;
using System.Web.Mvc;

namespace Capa_Presentacion.Controllers
{
    public class NominaController : Controller
    {
        // GET: Nomina

        private readonly NominaNegocio _negocio;

        public NominaController()
        {
            _negocio = new NominaNegocio();
        }

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
        public ActionResult Crear(Nomina nomina)
        {
            _negocio.NominasCrear(nomina);
            return RedirectToAction(nameof(Index));
        }

        //Editar Empleeado
        [HttpGet]
        public ActionResult Editar(int id)
        {
            var nomina = _negocio.GetNomina(id);

            if (nomina == null)
            {
                return null;
            }

            return View(nomina);
        }

        [HttpPost]
        public ActionResult Editar(Nomina nomina)
        {
            if (ModelState.IsValid)
            {
                _negocio.Editar(nomina);
                return RedirectToAction(nameof(Index));
            }

            return View(nomina);
        }

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            var nomina = _negocio.GetNomina(id);

            if (nomina == null)
            {
                return null;
            }

            return View(nomina);
        }

        [HttpPost]
        public ActionResult Eliminar(Nomina nomina)
        {
            if (ModelState.IsValid)
            {
                _negocio.Eliminar(nomina);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }

}
