using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class Usuario
    {
        string Nombre;
        string Pass;
        string Email;

        
        public Usuario(string nombre, string pass, string email)
        {
            Nombre = nombre;
            Pass = pass;
            Email = email;
          

        }

        public Usuario()
        {
            Nombre = "nombre";
            Pass = "";
            Email = "Email";
            
        }

        public override string ToString()
        {
            return "Titulo: " + Nombre + "\n" +
                "Contraseña: " + Pass + "\n" +
                "Email: " + Email;
               
        }

        public override bool Equals(object obj)
        {
            Usuario d = (Usuario)obj;
            bool result = false;

            if (Nombre == d.Nombre
                && Pass == d.Pass
                && Email == d.Email)
                return true;

            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



    }

    

}
