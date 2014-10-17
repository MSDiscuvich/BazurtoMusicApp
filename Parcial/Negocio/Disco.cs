using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Disco  : Productos
    {
        public string Nombre { get; set; }
        private Cancion cancion { get; set; }
        public int Cantidad { get; set; }
        private Cancion _cancion = null;
        private List<Cancion> canciones;
        public int CC { get; set; }

        
        public Disco():base ()
    {
    canciones=null;

    }

        public Disco (string titulo, string artista, string descripcion, List<Cancion> canciones) 
           : base (titulo, artista) 
        {
            this.Nombre = Nombre;
            this.cancion = cancion;
            this.Sold=Sold;
    }

        public List<Cancion> Canciones
        {
            get { return canciones; }
        }

        public void Agregar(Cancion cancion)
        {
        canciones.Add(cancion);
        }

        public void Eliminar(Cancion cancion)
        {
            canciones.Remove(cancion);
        }

        public Cancion Buscar(Cancion cancion)
        {
            {
                foreach (Cancion Cancion in this.canciones)
                {
                    if (Cancion.Titulo == Titulo)
                    {
                        return Cancion;
                    }
                }
                return null;
            }
        }

        public override string ToString()
        {
            String info = base.ToString() + "Total Canciones: " + CC + "\n"+ "Titulos: ";
            if (Canciones != null)
            {
                foreach (Cancion disco in Canciones)
                {
                    info += disco.Titulo;
                }
            } return info;
           
        }

        public override bool Equals(object obj)
        {
            bool result = false;
            Disco d = (Disco)obj;
            if (base.Equals(d) && CC == d.CC && Canciones == d.Canciones)
            {
                return true;

            }return result;
        }

 
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }

        }


    

