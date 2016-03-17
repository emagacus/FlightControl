using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
   public class ListaCiudades:List<CiudadNodo>
    {

        public int getcityIndex(string s)
        {

            for (int x = 0; x < this.Count; x++)
            {
                if (this[x].getName() == s) { return x; }
            }
            return 0;
        }

        private bool isIsolated(string s)
        {
            foreach(CiudadNodo c in this)
            {
                foreach(AristaCiudad a in c.Aristas)
                {
                    if (a.getname() == s) { return false; }
                }
            }

            return true;
        }


        public void deleteC(string s)
        {
            
            for (int indexc=0; indexc < this.Count; indexc++)
            {
                if (this[indexc].getName() == s) { this.RemoveAt(indexc);indexc--; } else
                {
                   
                    for (int indexi=0; indexi < this[indexc].Aristas.Count; indexi++)
                    {
                        if (this[indexc].Aristas[indexi].getname() == s)
                        {
                            this[indexc].Aristas.RemoveAt(indexi);
                            indexi--;
                        }

                    }//fin for 2

                    if (this[indexc].Aristas.Count == 0 && isIsolated(this[indexc].getName())) { this.RemoveAt(indexc); indexc--; }

                }//fin else
            }//fin for 1

            
        }


        public void deletArista(string o,string d)
        {
            for(int x = 0; x < this.Count; x++)
            {
                if(this[x].getName()==o)
                {
                    for(int y = 0; y < this[x].Aristas.Count; y++)
                    {

                        if (this[x].Aristas[y].getname() == d)
                        {
                            this[x].Aristas.RemoveAt(y);
                            y--;
                        }

                    }//fin for



                }//fin if

                if (this[x].Aristas.Count == 0 && isIsolated(this[x].getName())) { this.RemoveAt(x); x--; }

            }//fin for 1
        }



    }
}
