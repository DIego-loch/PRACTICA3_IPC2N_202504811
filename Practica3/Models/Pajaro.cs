using System;
using Practica3;

namespace Practica3
{
    public class Pajaro : Animales
    {
        public string raza { get; set; }
        public string tamaño { get; set; }

        public Pajaro
        (string Nombre, double Peso, string Sexo, int Edad, string propie, bool Estado, string raza, string tamaño) :
        base(Nombre, Peso, Sexo, Edad, propie, Estado)
        {
            this.raza = raza;
            this.tamaño = tamaño;
        }

    }
}
