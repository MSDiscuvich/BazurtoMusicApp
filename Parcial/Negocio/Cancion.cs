using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Cancion : Productos
    {
        private string titulo { get; set; }
        private string artista { get; set; }
       public string descripcion { get; set; }
        private int duracion { get; set; }
        private double peso { get; set; }
       public double precio { get; set; }
        int id { get; set; }


        public Cancion()
            : base()
        {
            this.titulo = "";
            this.artista = "";
            this.descripcion = "";
            this.duracion = 0;
            this.peso = 0;
            this.precio = 0;
            this.id = 0;

        }


        #region
        public Cancion(string titulo, string artista, string descripcion, int duracion, double precio, double peso)
            : base(titulo, artista, descripcion, duracion, precio, peso)
        {

            this.titulo = titulo;
            this.artista = artista;
            this.descripcion = descripcion;
            this.duracion = duracion;
            this.peso = peso;
            this.precio = precio;
            this.id = id;
        }
        #endregion


        public Cancion(int idc)
        {

            id = idc;


            switch (idc)
            {
                case 1:
                    titulo = "The reason";
                    artista = "Hoobastank";
                    descripcion = "album 2";
                    peso = 50.90;
                    precio = 3500;
                    break;

                case 2:
                    titulo = "In the end";
                    artista = "Linkin park";
                    descripcion = "Season 4";
                    peso = 134.90;
                    precio = 5500;
                    break;

                case 3:
                    titulo = "Who says";
                    artista = "Selena Gomez";
                    descripcion = "Underneath";
                    peso = 150.90;
                    precio = 2500;
                    break;

                case 4:
                    titulo = "Earth";
                    artista = "Michael Jackson";
                    descripcion = "Help world";
                    peso = 134.90;
                    precio = 500;
                    break;


                case 5:
                    titulo = "Sheila ki jawani";
                    artista = "Katrina";
                    descripcion = "Sheila's youth";
                    peso = 124.90;
                    precio = 2100;
                    break;

                case 6:
                    titulo = "Thug le";
                    artista = "Amrita Arora";
                    descripcion = "Ladies Vs Ricky ball";
                    peso = 158.90;
                    precio = 3400;
                    break;

                case 7:
                    titulo = "Thriller";
                    artista = "Michael Jackson";
                    descripcion = "Thriller";
                    peso = 154.90;
                    precio = 1900;
                    break;

            }


        }
    }

}
