using System;
using Practica3;

namespace Practica3
{
    public class Pajaro : Animales
    {
        public int envergadura { get; set; }
        public bool volar { get; set; }

        public Pajaro
        (string Nombre, double Peso, string Sexo, int Edad, string propie, bool Estado, int Envergadura, bool vuela) :
        base(Nombre, Peso, Sexo, Edad, propie, Estado)
        {
            envergadura = Envergadura;
            volar = vuela;
        }

        public override double CalcularDosis(double DosisMascota)
        {
            return base.CalcularDosis(DosisMascota) * 0.50;
        }
    }
}
