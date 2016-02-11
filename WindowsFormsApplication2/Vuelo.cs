using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Vuelo
    {

        char origen;
        char destino;
        int costo;
        int tiempo;
        string ruta;
        bool[] asientos = new bool[30];

        public Vuelo()
        {

        }

        public Vuelo(string od,string ruta,int costo, int tiempo)
        {
            origen = od[0];
            destino = od[1];
            this.ruta = ruta;
            this.costo = costo;
            this.tiempo = tiempo;
        }


        public int getCosto(){    return this.costo;}
        public char getOrigen() { return this.origen; }
        public char getDestino() { return this.destino; }
        public int getTiempo() { return this.origen; }
        public string getRuta() { return this.ruta; }
        public bool getAsientos(int n) { return this.asientos[n]; }
        public void setAsientoTomado(int a)
        {
            asientos[a-1] = true;
        }

        

        public override string ToString()
        {

            return origen.ToString() + ' ' + destino.ToString() + ' ' + tiempo.ToString() + ' ' + ruta.ToString() + ' ' + costo.ToString();
            
        }

    }
}
