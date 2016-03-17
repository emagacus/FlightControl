using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
   public class CiudadNodo
    {
        
        public CiudadNodo(float X,float Y,string name,List<AristaCiudad> Aristas)
        {
            this.X = X;
            this.Y = Y;
            this.name = name;
            this.Aristas = Aristas;
        }

      



        string name;
        public float X;
        public float Y;
       public string getName() { return name; }

        public List<AristaCiudad> Aristas;
         

    }

}
