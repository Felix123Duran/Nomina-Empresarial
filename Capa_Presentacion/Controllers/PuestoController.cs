using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capa_Entidaddes;
using Capa_Negocio;
using System.Web.Mvc;

namespace Capa_Presentacion.Controllers
{
    public class PuestoController : Controller
    {
        // GET: Puesto
        private readonly PuestoNegocio _negocio;

        public PuestoController()
        {
            _negocio = new PuestoNegocio();
        }

        // GET: Empleado
        public ActionResult Index()
        {
            var leer = _negocio.leer();
            return View(leer);
        }

        //Crear Puesto
        public ActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear(Puesto puesto)
        {
            _negocio.puestoCrear(puesto);
            return RedirectToAction(nameof(Index));
        }

        //Editar Puesto
        [HttpGet]
        public ActionResult Editar(int id)
        {
            var puesto = _negocio.Getpuesto(id);

            if (puesto == null)
            {
                return null;
            }

            return View(puesto);
        }

        [HttpPost]
        public ActionResult Editar(Puesto puesto)
        {
            if (ModelState.IsValid)
            {
                _negocio.Editar(puesto);
                return RedirectToAction(nameof(Index));

            }

            return View(puesto);
        }

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            var puesto = _negocio.Getpuesto(id);

            if (puesto == null)
            {
                return null;
            }

            return View(puesto);
        }

        [HttpPost]
        public ActionResult Eliminar(Puesto puesto)
        {
            if (ModelState.IsValid)
            {
                _negocio.Eliminar(puesto);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}