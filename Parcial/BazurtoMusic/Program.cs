using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Negocio;

namespace BazurtoMusic
{
    class Program
    {
        static void Main(string[] args)
        {

            Repositorio ll = new Repositorio();

            foreach (Cancion value in ll.getCancion())
                System.Console.WriteLine(value);

            System.Console.ReadKey();
        }
    }
}
