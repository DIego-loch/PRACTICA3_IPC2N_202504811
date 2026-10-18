using System;
using Practica3;

namespace Practica3
{
    public class Gato : Animales
    {
        public string raza { get; set; }
        public string esterelizado { get; set; }

        public Gato
        (string Nombre, double Peso, string Sexo, int Edad, string propie, bool Estado, string raza, string Esterelizado) :
        base(Nombre, Peso, Sexo, Edad, propie, Estado)
        {
            this.raza = raza;
           esterelizado = Esterelizado;
        }

        public override double CalcularDosis(double DosisMascota)
        {
            return base.CalcularDosis(DosisMascota) * 0.90;
        }
    }
}
