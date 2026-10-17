using System;
using Practica3;

namespace Practica3
{
    public abstract class Animales
    {
        public string nombre { get; set; }
        public double peso { get; set; }
        public string sexo { get; set; }
        public int edad { get; set; }
        public string propietario { get; set; }
        public string? CodigoUnicos { get; set; }
        public bool estado { get; set; }

        public Animales(string Nombre, double Peso, string Sexo, int Edad, string propie, bool Estado)
        {

            nombre = Nombre;
            peso = Peso;
            sexo = Sexo;
            edad = Edad;
            propietario = propie;
            estado = Estado;
        }

        public virtual double CalcularDosis(double DosisMascota)
        {
            return (peso * DosisMascota);
        }

        public bool EstadoMascota()
        {
            return estado ? true : false;
        }

        public virtual void Codigo()
        {
            CodigoUnico codigo = new CodigoUnico();
            CodigoUnicos = codigo.CodigoMascota();
        }

    }
}
