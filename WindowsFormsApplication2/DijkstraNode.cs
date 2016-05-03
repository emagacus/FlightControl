using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
   public class DijkstraNode
    {

        public CiudadNodo procedencia;
        public string nombre;
        public float peso;


        public DijkstraNode() { }

        public DijkstraNode(string nombre, float peso)
        {
            this.nombre = nombre;
            this.peso = peso;
        }

    }
}
