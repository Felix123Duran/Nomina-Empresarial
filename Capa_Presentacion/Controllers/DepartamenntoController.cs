using System;
using Capa_Negocio;
using Capa_Entidaddes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capa_Presentacion.Controllers
{
    public class DepartamenntoController : Controller
    {
        private readonly DepartamentoNegocio _negocio;

        public DepartamenntoController()
        {
            _negocio = new DepartamentoNegocio();
        }
        // GET: Departamennto
        public ActionResult Index()
        {
            var leer = _negocio.leer();
            return View(leer);
        }

        //Crear Departamento
        public ActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear(Departamento departamento)
        {
            _negocio.DepartamentoCrear(departamento);
            return View();
        }


        //Editar Empleeado
        [HttpGet]
        public ActionResult Editar(int id)
        {
            var departamento = _negocio.GetDepartamento(id);

            if (departamento == null)
            {
                return null;
            }

            return View(departamento);
        }

        [HttpPost]
        public ActionResult Editar(Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                _negocio.Editar(departamento);
                return RedirectToAction(nameof(Index));
            }

            return View(departamento);
        }

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            var departamento = _negocio.GetDepartamento(id);

            if (departamento == null)
            {
                return null;
            }

            return View(departamento);
        }

        [HttpPost]
        public ActionResult Eliminar(Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                _negocio.Eliminar(departamento);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}