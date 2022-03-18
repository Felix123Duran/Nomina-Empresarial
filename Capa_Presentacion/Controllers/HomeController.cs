using System;
using System.Collections.Generic;
using System.Linq;
using Capa_Entidaddes;
using Capa_Negocio;
using System.Web;
using System.Web.Mvc;

namespace Capa_Presentacion.Controllers
{
    public class HomeController : Controller
    {   
      //Recuerda mover el menu del proyecto 
        public ActionResult Index()
        {
            return View();
        }
        
        //Area de creacion
        NegocionCrear negocio = new NegocionCrear();
        public ActionResult About()
        {
            return View();
        }
        [HttpPost]
        public ActionResult About(Empleado empleado)
        {
            negocio.Empleados(empleado);
            return View();
        }

        public ActionResult CrearDepartamento()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CrearDepartamento(Departamento departamento)
        {
            negocio.Departamento(departamento);
            return View();
        }

        public ActionResult CrearPuesto()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CrearPuesto(Puesto puesto)
        {
            negocio.Puesto(puesto);
            return View();
        }

        public ActionResult CrearTipoIngreso()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CrearTipoIngreso(Tipos_Ingresos TIngreso)
        {
            negocio.TipoIngreso(TIngreso);
            return View();
        }

        public ActionResult CrearTransacciones()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CrearTransacciones(Transaccion transacciones)
        {
            negocio.Transacciones(transacciones);
            return View();
        }

        public ActionResult CrearNomina()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CrearNomina(Nomina nomina)
        {
            negocio.nomina(nomina);
            return View();
        }

        public ActionResult Detalles_Nomina()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Detalles_Nomina(Detalles_nomina detalles_Nomina)
        {
            negocio.Detalles_Nomina(detalles_Nomina);
            return View();
        }
    }
      
}