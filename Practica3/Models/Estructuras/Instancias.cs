using System;
using Practica3;

namespace Practica3
{
    public class Instancias
    {
       public ListaModelo Perro { get; } = new ListaPerro();
       public ListaModelo Gato { get; } = new ListaGato();
       public ListaModelo Pajaro { get; } = new ListaPajaro();
       public ListaModelo Tortuga { get; } = new ListaTortuga();
    }
}
