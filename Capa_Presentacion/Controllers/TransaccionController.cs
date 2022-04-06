﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capa_Entidaddes;
using Capa_Negocio;
using System.Web.Mvc;

namespace Capa_Presentacion.Controllers
{
    public class TransaccionController : Controller
    {
        // GET: Transaccion
        private readonly TransaccionNegocio _negocio;

        public TransaccionController()
        {
            _negocio = new TransaccionNegocio();
        }

        // GET: Transaccion
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
        public ActionResult Crear(Transaccion transaccion)
        {
            _negocio.TransaccionsCrear(transaccion);
            return RedirectToAction(nameof(Index));
        }

        //Editar Empleeado
        [HttpGet]
        public ActionResult Editar(int id)
        {
            var transaccion = _negocio.GetTransaccion(id);

            if (transaccion == null)
            {
                return null;
            }

            return View(transaccion);
        }

        [HttpPost]
        public ActionResult Editar(Transaccion Transaccion)
        {
            if (ModelState.IsValid)
            {
                _negocio.Editar(Transaccion);
                return RedirectToAction(nameof(Index));
            }

            return View(Transaccion);
        }

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            var Transaccion = _negocio.GetTransaccion(id);

            if (Transaccion == null)
            {
                return null;
            }

            return View(Transaccion);
        }

        [HttpPost]
        public ActionResult Eliminar(Transaccion Transaccion)
        {
            if (ModelState.IsValid)
            {
                _negocio.Eliminar(Transaccion);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}