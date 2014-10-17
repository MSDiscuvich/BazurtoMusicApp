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
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public string Descripcion { get; set; }
        public string Duracion { get; set; }
        public string Genero { get; set; }
        public double Peso { get; set; }
        public double Precio { get; set; }
        public int Sold { get; set; }
        #endregion


        public Productos(string titulo, string artista,string descripcion,string duracion, string genero, double peso, double precio,int sold )
        {
            Titulo = titulo;
            Artista = artista;
            Descripcion = descripcion;
            Duracion = duracion;
            Genero = genero;
            Peso = peso;
            Precio = precio;
            Sold = 0;
             }

        public Productos (string genero,string titulo)
            {
                this.Titulo = titulo;
                this.Artista = "";
                this.Descripcion = "";
                this.Duracion = "";
                this.Peso = 0;
                this.Precio = 0;
                this.Sold = 0;
                this.Genero = genero;
            }

        public Productos()
        {
            Titulo = "titulo";
            Artista = "artista";
            Descripcion = "descripcion cancion";
            Duracion = "duracion";
            Peso = 0;
            Precio = 0;
            Sold = 0;
            Genero = "genero";
        }

        public override string ToString()
        {
            return "titulo: " + Titulo + "\n" +
                    "artista: " + Artista + "\n" +
                    "descripcion: " + Descripcion + "\n" +
                     "duracion: " + Duracion + "\n" +
                    "peso: " + Peso + "\n" +
                    "precio: " + Precio + "\n" +
                     "genero: " + Genero + "\n" +
                     "canciones vendidas" + Sold + "\n";
                 }

        public override bool Equals(object obj)
        {
            Productos p = (Productos)obj;
            bool result = false;
            if (Titulo == p.Titulo
                && Artista == p.Artista
                 && Descripcion == p.Descripcion
                  && Duracion == p.Duracion
                && Peso == p.Peso
                 && Precio == p.Precio
                && Genero == p.Genero
                && Sold == p.Sold)
                return true;

            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Contar() { 
        
        }

        }

    }

