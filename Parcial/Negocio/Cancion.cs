using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Cancion : Productos
    {
       
        public  int Id { get; set; }
        
        


        public Cancion(string titulo, string artista,string descripcion,string duracion, string genero, int peso, double precio, int Sold)
            : base(titulo, artista,descripcion, duracion,genero, peso, precio, Sold)
        {
            this.Id = Id;

             }


        #region
        public Cancion():base()
        {
        Id=0;
        
        }
        #endregion

        public override string ToString()
        {
 	 return base.ToString() +
         "Nombre cancion:" + Titulo + "\n" +
         "Nombre:" + Titulo;
        }

        public override bool Equals(object obj)
{
            bool result= false;

            Cancion p= (Cancion)obj;
            if (base.Equals(p) && Id == p.Id && Titulo ==  p.Titulo)
 	 return true;

            return result;

}

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Contar()
        {
            this.Sold++;
        
    }



       
    }

}
