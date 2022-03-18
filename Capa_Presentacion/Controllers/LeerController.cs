using System;
using Capa_Negocio;
using Capa_Entidaddes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capa_Presentacion.Controllers
{
    public class LeerController : Controller
    {
        // GET: Leer
        NegocioLeer Negocio = new NegocioLeer();
        public ActionResult Leer()
        {
            var leer = Negocio.LeerEmpleados();
            return View(leer);
        }

        public ActionResult LeerDepartamento()
        {
            var leer = Negocio.LeerDepartamento();
            return View(leer);
        }

        public ActionResult LeerPuesto()
        {
            var leer = Negocio.LeerPuesto();
            return View(leer);
        }

        public ActionResult LeerDetalles_nominia()
        {
            var leer = Negocio.LeerDetalles_nominia();
            return View(leer);
        }

        public ActionResult LeerNomina()
        {
            var leer = Negocio.LeerNomina();
            return View(leer);
        }

        public ActionResult LeerTransaccion()
        {
            var leer = Negocio.LeerTransaccion();
            return View(leer);
        }

        public ActionResult LeerTipos_Ingresos()
        {
            var leer = Negocio.LeerTipos_Ingresos();
            return View(leer);
        }
    }
}