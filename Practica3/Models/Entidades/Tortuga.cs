using System;
using Practica3;

namespace Practica3
{
    public class Tortuga : Animales
    {
        public string caparazon { get; set; }
        public bool acuatico { get; set; }

        public Tortuga
        (string Nombre, double Peso, string Sexo, int Edad, string propie, bool Estado, string Caparazon, bool Actuatico) :
        base(Nombre, Peso, Sexo, Edad, propie, Estado)
        {
            caparazon = Caparazon;
            acuatico = Actuatico;
        }

        public override double CalcularDosis(double DosisMascota)
        {
            return base.CalcularDosis(DosisMascota) * 0.80;
        }
    }
}
