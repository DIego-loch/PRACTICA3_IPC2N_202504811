using System;
using Practica3;

namespace Practica3
{
    public class CodigoUnico
    {
        public string CodigoMascota()
        {
            Random cod = new Random();
            string Character = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] code = new char[8];
            for(int i = 0; i < 8; i++)
            {
                code[i] = Character[cod.Next(Character.Length)];
            }

            return new string(code);
        }
    }
}
