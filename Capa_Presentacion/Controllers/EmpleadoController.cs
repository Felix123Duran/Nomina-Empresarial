using Capa_Entidaddes;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capa_Presentacion.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly EmpleadosNegocio _negocio;

        public EmpleadoController()
        {
            _negocio = new EmpleadosNegocio();
        }

        // GET: Empleado
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
        public ActionResult Crear(Empleado empleado)
        {
            _negocio.EmpleadosCrear(empleado);
            return View("Index");
        }

        //Editar Empleeado
        [HttpGet]
        public ActionResult Editar(int id)
        {
            var empleado = _negocio.GetEmpleado(id);

            if (empleado == null)
            {
                return null;
            }

            return View(empleado);
        }

        [HttpPost]
        public ActionResult Editar(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                _negocio.Editar(empleado);
                return RedirectToAction(nameof(Index));
            }

            return View(empleado);
        }

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            var empleado = _negocio.GetEmpleado(id);

            if (empleado == null)
            {
                return null;
            }

            return View(empleado);
        }

        [HttpPost]
        public ActionResult Eliminar(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                _negocio.Eliminar(empleado);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}