using System;

namespace Practica3
{
    public class NodoAnimales
    {
        public Animales Dato { get; set; }
        public NodoAnimales? NodoSiguiente { get; set; }

        public NodoAnimales(Animales datos)
        {
            Dato = datos;
            NodoSiguiente = null;
        }
    }
}
