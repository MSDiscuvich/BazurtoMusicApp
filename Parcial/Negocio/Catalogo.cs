using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class Catalogo
    {
        public List<Disco> Discos{get; set;}
        public List<Cancion> Canciones { get; set; }
        public string Nombre;


        public Catalogo(String nombre,List <Disco> discos, List<Cancion> canciones)
        {
            this.Nombre = nombre;
            this.Canciones = canciones;
            this.Discos = discos;
         }

        public Catalogo()
        {
            Nombre = "";
            Discos = null;
            Canciones = null;
        }


        public override string ToString()
        {
            String info = "Nombre: " + Nombre + 
            "\n" + "Discos: " + "\n\t" + 
            "\n" + "Canciones " + "\n\t";
            foreach (Disco d in Discos)
            {
                info += d.Titulo;

            }
            return info;
           foreach(Cancion d in Canciones)
           {
               info += d.Titulo;

           } return info;
        }

        public override bool Equals(object obj)
        {
            bool result = false;
            Catalogo c = (Catalogo)obj;
            if(Nombre==c.Nombre && Discos == c.Discos && Canciones == c.Canciones)
            return true;

            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
