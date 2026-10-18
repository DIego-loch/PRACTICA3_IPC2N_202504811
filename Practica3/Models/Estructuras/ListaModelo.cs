using System;

namespace Practica3
{
    public abstract class ListaModelo
    {
        public NodoAnimales? NodoRaiz { get; set; }
        public void IngresarLista(Animales animal)
        {
            NodoAnimales Nodo = new NodoAnimales(animal);

            if (NodoRaiz == null)
            {
                NodoRaiz = Nodo;
                return;
            }

            Nodo.NodoSiguiente = NodoRaiz;
            NodoRaiz = Nodo;
        }

        public NodoAnimales? BuscarAnimal(string codigo)
        {
            NodoAnimales? aux = NodoRaiz;
            while (aux != null)
            {
                if (codigo == aux.Dato.CodigoUnicos) return aux;
                aux = aux.NodoSiguiente;
            }

            return null;
        }

        public bool EditarAnimal(Animales MascotaActualizada, string codigo)
        {
            NodoAnimales? aux = BuscarAnimal(codigo);
            if (aux == null) return false;
            aux.Dato = MascotaActualizada;
            return true;
        }

        public bool EliminarAnimal(string codigo)
        {
            if (NodoRaiz == null) return false;

            // el nodo a eliminar es la raiz
            if (NodoRaiz.Dato.CodigoUnicos == codigo)
            {
                NodoRaiz = NodoRaiz.NodoSiguiente;
                return true;
            }

            NodoAnimales? NodoAnterior = null;
            NodoAnimales? NodoActual = NodoRaiz;

            while (NodoActual != null)
            {
                if (NodoActual.Dato.CodigoUnicos == codigo)
                {
                    NodoAnterior.NodoSiguiente = NodoActual.NodoSiguiente;
                    return true;
                }
                NodoAnterior = NodoActual;
                NodoActual = NodoActual.NodoSiguiente;
            }
            return false;

        }
    }
}
