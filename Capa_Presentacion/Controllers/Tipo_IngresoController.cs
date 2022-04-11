
using System;
using System.Collections.Generic;
using System.Linq;
using Capa_Negocio;
using Capa_Entidaddes;
using System.Web;
using System.Web.Mvc;

namespace Capa_Presentacion.Controllers
{
    public class tipo_IngresoController : Controller
    {
        // GET: Yipo_Ingreso
        private readonly NegocioTipo_Ingreso _negocio;

        public tipo_IngresoController()
        {
            _negocio = new NegocioTipo_Ingreso();
        }

        // GET: Tipo_Ingreso
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
        public ActionResult Crear(Tipos_Ingresos Tipo_Ingreso)
        {
            _negocio.EmpleadosCrear(Tipo_Ingreso);
            return View();
        }

        //Editar Empleeado
        [HttpGet]
        public ActionResult Editar(int id)
        {
            var Tipo_Ingreso = _negocio.GetTipos_Ingresos(id);

            if (Tipo_Ingreso == null)
            {
                return null;
            }

            return View(Tipo_Ingreso);
        }

        [HttpPost]
        public ActionResult Editar(Tipos_Ingresos Tipo_Ingreso)
        {
            if (ModelState.IsValid)
            {
                _negocio.Editar(Tipo_Ingreso);
                return RedirectToAction(nameof(Index));
            }

            return View(Tipo_Ingreso);
        }

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            var Tipo_Ingreso = _negocio.GetTipos_Ingresos(id);

            if (Tipo_Ingreso == null)
            {
                return null;
            }

            return View(Tipo_Ingreso);
        }

        [HttpPost]
        public ActionResult Eliminar(Tipos_Ingresos Tipo_Ingreso)
        {
            if (ModelState.IsValid)
            {
                _negocio.Eliminar(Tipo_Ingreso);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}