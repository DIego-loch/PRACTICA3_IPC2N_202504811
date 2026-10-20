using System;
using Practica3;
using Microsoft.AspNetCore.Mvc;

namespace Practica3
{
    public class GatoController : Controller
    {
        private readonly Instancias instancia;

        public GatoController(Instancias instancias)
        {
            instancia = instancias;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(instancia.Gato);
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Gato Gatito)
        {
            instancia.Gato.IngresarLista(Gatito);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DetalleAnimales(string Codigo)
        {
            var Nodo = instancia.Gato.BuscarAnimal(Codigo);
            if (Nodo == null) return RedirectToAction("Index");
            return View(Nodo.Dato);
        }

        [HttpGet]
        public IActionResult EditarMascota(string Codigo)
        {
            var NodoEncontrado = instancia.Gato.BuscarAnimal(Codigo);
            if (NodoEncontrado == null) return RedirectToAction("Index");
            return View(NodoEncontrado.Dato);
        }

        [HttpPost]
        public IActionResult EditarMascota(Animales Mascota, string Codigo)
        {
            instancia.Gato.EditarAnimal(Mascota, Codigo);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EliminarMascota(string Codigo)
        {
            instancia.Gato.EliminarAnimal(Codigo);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult CambiarEstado(string Codigo, bool estado)
        {
            var Mascota = instancia.Gato.BuscarAnimal(Codigo);
            if (Mascota == null) return RedirectToAction("Index");
            Mascota.Dato.estado = estado;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CalcularDosis(double dosis, string Codigo)
        {
            var Mascota = instancia.Gato.BuscarAnimal(Codigo);
            if (Mascota == null) return RedirectToAction("Index");
            var Dosis = Mascota.Dato.CalcularDosis(dosis);
            return View(Dosis);
        }
    }
}
