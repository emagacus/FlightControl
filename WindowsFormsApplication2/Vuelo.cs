using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace WindowsFormsApplication2
{



    public class Vuelo
    {
        DateTime date;
        char origen;
        char destino;
        int costo;
        int tiempo;
        string ruta;
        bool[] asientos = new bool[30];
        int AsientosDisp;


        public static int CompareVueloAsiento(Vuelo v1, Vuelo v2)
        {
            
            return v1.getAsientosDisp().CompareTo(v2.getAsientosDisp());

        }

        public List<Usuario> userlist = new List<Usuario>(); 

        public DateTime getDate() { return date; }

        public Vuelo()
        {

        }


        public Vuelo(int AsientosDisp,string od,string ruta,int costo, int tiempo,DateTime date)
        {
            origen = od[0];
            destino = od[1];
            this.ruta = ruta;
            this.costo = costo;
            this.tiempo = tiempo;
            AsientosDisp = 30;
            this.AsientosDisp = AsientosDisp;

            this.date = date; 

        }


        public int getCosto(){    return this.costo;}
        public char getOrigen() { return this.origen; }
        public char getDestino() { return this.destino; }
        public int getTiempo() { return this.origen; }
        public string getRuta() { return this.ruta; }
        public bool getAsientos(int n) { return this.asientos[n]; }
        public DateTime getFecha() { return date; }

        public void setAsientoTomado(int a)
        {
            if (!asientos[a - 1])
            {
                asientos[a - 1] = true;
                AsientosDisp--;
            }
            else {
                AsientosDisp++;
                asientos[a - 1] = false; }
            }
        public int getAsientosDisp()
        {
            return AsientosDisp;
        }
        

        public override string ToString()
        {

            return getAsientosDisp().ToString() + ' ' + origen.ToString() + ' ' + destino.ToString() + ' ' + tiempo.ToString() + ' ' + ruta.ToString() + ' ' + costo.ToString() + ' ' + date.ToString() ;
           
        }


        public string ToString(char c)
        {

            return getAsientosDisp().ToString() + c + origen.ToString() + destino.ToString() + c + ruta.ToString() + c + tiempo.ToString() + c + costo.ToString() + c + date.ToString();

        }

    }
}
