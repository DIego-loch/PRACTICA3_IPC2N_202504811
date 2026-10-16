using System;
using Practica3;

namespace Practica3
{
    public class Tortuga : Animales
    {
        public string raza { get; set; }
        public string tamaño { get; set; }

        public Tortuga
        (string Nombre, double Peso, string Sexo, int Edad, string propie, bool Estado, string raza, string tamaño) :
        base(Nombre, Peso, Sexo, Edad, propie, Estado)
        {
            this.raza = raza;
            this.tamaño = tamaño;
        }

    }
}
