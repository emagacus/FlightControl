using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
   public class Usuario
    {


        string Nombre;
        string Apellidos;
        string Vuelo;
        int Asiento;
       
        

        public Usuario(string Nombre,string Apellidos,string Vuelo,int Asiento)
        {

            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Vuelo = Vuelo;
            this.Asiento = Asiento;

        }


        public int getAsiento() { return Asiento; }

        public override string ToString()
        {
            return Nombre.ToString() +"|"+ Apellidos.ToString() + "|" + Asiento.ToString() + "|" + Vuelo.ToString();
        }

    }
}
