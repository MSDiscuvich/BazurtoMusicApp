using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;


namespace Datos
{
    public class Repositorio
    {
        public IEnumerable<Productos> getProductos()
        {
            List<Productos> lista = new List<Productos>();

            Cancion c = new Cancion();
            Cancion c2 = new Cancion();
             Disco d = new Disco();
            Disco d2 = new Disco();
            

            lista.Add(c);
            lista.Add(c2);
            lista.Add(d);
            lista.Add(d2);
            

            return lista;
        }


        public IEnumerable<Cancion> getCancion()
        {
            List<Cancion> lista = new List<Cancion>();

            Cancion c = new Cancion("In the end", "Linkin park", "Año 2012", "03:05", "Rock", 12, 2500, 2);
            Cancion c2 = new Cancion("Lalala", "Shakira", "año 2014","04:19", "Pop", 10, 3200, 1);
            Cancion c3 = new Cancion("Waka waka", "Shakiraa", "Año 2010", "03:05", "Pop", 12, 5500, 3);
            Cancion c4 = new Cancion("Innocence", "Aoi Eir", "Año 2010", "03:05", "Pop", 8, 1500, 0);
            Cancion c5 = new Cancion("Ame", "Sid", "Año 2009", "03:05", "Rock", 9, 2500, 2);

            lista.Add(c);
            lista.Add(c2);
            lista.Add(c3);
            lista.Add(c4);
            lista.Add(c5);

            return lista;

        }


        

    }
}
