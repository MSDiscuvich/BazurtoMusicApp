using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public abstract class Productos
    {
        #region variables
        private string titulo { get; set; }
        private string artista { get; set; }
        private string descripcion { get; set; }
        private int duracion { get; set; }
        private double peso { get; set; }
        double precio { get; set; }
        #endregion


        public Productos(){
            titulo = "";
            artista = "";
            descripcion = "";
            duracion = 0;
            peso = 0;
            precio = 0;
             }

        public Productos (string titulo,string artista,string descripcion,int duracion,double peso,double precio)
            {
                this.titulo = titulo;
                this.artista = artista;
                this.descripcion = descripcion;
                this.duracion = duracion;
                this.peso = peso;
                this.precio = precio;
            }

       
        
        }

    }

