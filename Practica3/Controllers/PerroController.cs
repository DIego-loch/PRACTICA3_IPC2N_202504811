using System;
using Practica3;
using Microsoft.AspNetCore.Mvc;

namespace Practica3
{


    public class PerroController : Controller
    {
        private readonly ListaModelo? ListaPerro;
        public PerroController(ListaModelo Instancias)
        {
            ListaPerro = Instancias;
        }

    }
}
