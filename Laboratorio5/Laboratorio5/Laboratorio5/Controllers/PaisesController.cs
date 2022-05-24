﻿using Laboratorio5.Handlers;
using Laboratorio5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio5.Controllers
{
    public class PaisesController : Controller
    {
        public IActionResult Index()
        {
            PaisesHandler paisesHandler = new PaisesHandler();
            var paises = paisesHandler.ObtenerPaises();
            ViewBag.MainTitle = "Lista de países";
            return View(paises); ;
        }

        [HttpGet]
        public ActionResult CrearPais()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CrearPais(PaisModel pais)
        {
            ViewBag.ExitoAlCrear = false;
            try
            {
                if (ModelState.IsValid)
                {
                    PaisesHandler paisesHandler = new PaisesHandler();
                    ViewBag.ExitoAlCrear = paisesHandler.CrearPais(pais);
                    if (ViewBag.ExitoAlCrear)
                    {
                        ViewBag.Message = "El país" + " " + pais.Nombre + " fue creada con éxito.";
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                ViewBag.Message = "Algo salió mal y no fue posible crear el país";
                return View();
            }

        }

        [HttpGet]
        public ActionResult EditarPais(int? identificador)
        {
            ActionResult vista;
            try
            {
                var paisesHandler = new PaisesHandler();
                var pais = paisesHandler.ObtenerPaises().Find(model => model.Id == identificador);
                if (pais == null)
                {
                    vista = RedirectToAction("Index");
                }
                else
                {
                    vista = View(pais);
                }
            }
            catch
            {
                vista = RedirectToAction("Index");
            }
            return vista;
        }

        [HttpPost]
        public ActionResult EditarPais(PaisModel pais)
        {
            try
            {
                var paisesHandler = new PaisesHandler();
                paisesHandler.EditarPais(pais);
                return RedirectToAction("Index", "Paises");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult BorrarPais(int identificador)
        {
            ActionResult vista;
            try
            {
                var paisesHandler = new PaisesHandler();
                
                PaisModel pais=new PaisModel();
                pais.Id = identificador;
                bool exito = paisesHandler.BorrarPais(pais);
                if (exito)
                {
                    vista = RedirectToAction("Index");
                    ViewBag.Message = "El país fue borrado con éxito";
                } else
                {
                    ViewBag.Message = "Algo salió mal y no fue posible borrar el país";
                    vista = RedirectToAction("Index");
                }
            }
            catch
            {
                vista = RedirectToAction("Index");
            }
            return vista;
        }

    }

}
