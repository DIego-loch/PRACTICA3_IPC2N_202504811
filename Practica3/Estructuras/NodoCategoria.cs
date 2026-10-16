using System;
using Practica3;
namespace Practica3
{
    public class NodoCategoria
    {
        public string NombreCategoria { get; set; }
        public NodoAnimales NodoActual { get; set; }
        public NodoCategoria? NodoSiguiente { get; set; }

        public NodoCategoria(NodoAnimales datos, string nombre)
        {
            NombreCategoria = nombre;
            NodoActual = datos;
            NodoSiguiente = null;
        }
    }
}
