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
        public CiudadNodo IdNodo;
        public float peso;
        public float AristaPeso;

        public DijkstraNode() { AristaPeso = 0; }

        public DijkstraNode(CiudadNodo IdNodo, float peso)
        {
            AristaPeso = 0;
            this.IdNodo = IdNodo;
            this.peso = peso;
        }

    }
}
