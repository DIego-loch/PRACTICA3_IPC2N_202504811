using System;
using Practica3;

namespace Practica3
{
    public class ListaCategorias
    {
        public NodoCategoria? Cabeza { get; set; }

        public void Ingresar(NodoAnimales Animales, string NombreCategorias)
        {

            NodoCategoria? aux = Cabeza;

            // verifica si existe y si es null la cabeza sale y asigna nodo a Cabeza
            while ((aux != null) && (aux.NombreCategoria != NombreCategorias))
            {
                aux = aux.NodoSiguiente;
            }

            if (aux == null)
            {
                // cremos instancia de NodoCategorias
                NodoCategoria NodoCate = new NodoCategoria(Animales, NombreCategorias);

                // Enlazamos el nodo creado ah la lista que ya teniamos (o si esta vacia a null)
                NodoCate.NodoSiguiente = Cabeza;

                // hacemos que cabeza apunte a la lista ya completa
                Cabeza = NodoCate;

            } else
            {
                Animales.NodoSiguiente = aux.NodoActual;
                aux.NodoActual = Animales;
            }

        }
    }
}
