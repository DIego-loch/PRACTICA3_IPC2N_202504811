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

        public void EditarAnimal(Animales MascotaActualizada, string codigo)
        {
            NodoAnimales? aux = BuscarAnimal(codigo);
            if (aux == null) return;
            aux.Dato = MascotaActualizada;
            return;
        }

        public void EliminarAnimal(string codigo)
        {
            if (NodoRaiz == null) return;

            // el nodo a eliminar es la raiz
            if (NodoRaiz.Dato.CodigoUnicos == codigo)
            {
                NodoRaiz = NodoRaiz.NodoSiguiente;
                return;
            }

            NodoAnimales? NodoAnterior = null;
            NodoAnimales? NodoActual = NodoRaiz;

            while (NodoActual != null)
            {
                if (NodoActual.Dato.CodigoUnicos == codigo)
                {
                    NodoAnterior?.NodoSiguiente = NodoActual.NodoSiguiente;
                    return;
                }
                NodoAnterior = NodoActual;
                NodoActual = NodoActual.NodoSiguiente;
            }
            return;

        }
    }
}
