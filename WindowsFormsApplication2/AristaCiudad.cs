using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
  public class AristaCiudad
    {
        public float X;
        public float Y;
         string nombre;
         int costo;
         int tiempo;
         


        
       public AristaCiudad(float X,float Y,string nombre,int costo, int tiempo)
        {
            this.X = X;
            this.Y = Y;
            this.nombre = nombre;
            this.costo = costo;
            this.tiempo = tiempo;
        }


        public string getname()
        {
            return nombre;
        }
        public int getTiempo() { return tiempo; }
        public int getCosto() { return costo; }

        public override string ToString()
        {
            return X.ToString() + '|' + Y.ToString() + '|' + nombre + '|' + costo.ToString() + '|' + tiempo.ToString(); 
        }


    }
}
