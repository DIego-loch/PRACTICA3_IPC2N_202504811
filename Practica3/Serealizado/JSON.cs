using System;
using System.Text.Json;
using System.IO;

namespace Practica3
{
    public class JSON
    {
        private readonly ListaModelo? ArchivoSerealizar;

        public JSON(ListaModelo modelo)
        {
            ArchivoSerealizar = modelo;
        }

        public void Serealizacion()
        {
            string json = JsonSerializer.Serialize(ArchivoSerealizar);
            File.WriteAllText("Serealizado/EnvioDatos.json", json);
        }
    }
}
