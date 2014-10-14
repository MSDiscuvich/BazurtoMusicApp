using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class Disco  : Productos
    {
        private string nombre { get; set; }
        private Cancion cancion{ get; set; }
        public int Cantidad { get; set; }
        private int _IdCancion;
        private Cancion _cancion = null;

        

        public Disco (string titulo, string artista, string descripcion, int duracion, double precio, double peso) 
           : base (titulo, artista, descripcion,duracion,precio,peso){
            this.nombre = nombre;
            this.cancion = cancion;
            this.IdCancion=IdCancion;
            this.Cantidad=Cantidad;
    }

        


            public int IdCancion
            {
                get { return _IdCancion; }
                set
                {
                    _cancion = null;
                    _IdCancion = value;
                }
            }

            public Cancion Cancion
            {
                get
                {
                    if (_cancion == null)
                    {
                        _cancion = new Cancion(IdCancion);
                    }
                    return _cancion;
                }
            }

            public string Descripcion
            {
                get { return Cancion.descripcion; }
            }
            public double PrecioUnitario
            {
                get { return Cancion.precio; }
            }
            public double Total
            {
                get { return PrecioUnitario * Cantidad; }
            }

            public Disco (int pId)
            {
                IdCancion = pId;
            }
            public bool Equals(Disco pItem)
            {
                return pItem.IdCancion == IdCancion;
            }
        }

        }


    

