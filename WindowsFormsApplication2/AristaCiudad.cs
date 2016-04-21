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
         string origen;
         string destino;
         int costo;
         int tiempo;
         


        
       public AristaCiudad(float X,float Y,string origen,string destino,int costo, int tiempo)
        {
            this.X = X;
            this.Y = Y;
            this.origen = origen;
            this.destino = destino;
            this.costo = costo;
            this.tiempo = tiempo;
        }


        public string getDest()
        {
            return destino;
        }
        public string getOrigen()
        {
            return origen;
        }

        public int getTiempo() { return tiempo; }
        public int getCosto() { return costo; }



        public override string ToString()
        {
            return X.ToString() + '|' + Y.ToString() + '|' + destino + '|' + costo.ToString() + '|' + tiempo.ToString(); 
        }


    }
}
