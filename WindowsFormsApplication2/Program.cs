using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{



    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Principal());

            

            ListaVuelos listaVuelos = new ListaVuelos();

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("infoVuelos.txt"))
                {
                    // Read the stream to a string, and write the string to the console.

                    while (!sr.EndOfStream)
                    {

                        String line = sr.ReadLine();
                        string[] datavuelo = line.Split('|');
                        DateTime date = DateTime.Parse(datavuelo[5]);
                        Vuelo vuelo = new Vuelo(int.Parse(datavuelo[0]),datavuelo[1], datavuelo[2], int.Parse(datavuelo[3]), int.Parse(datavuelo[4]),date);
                        listaVuelos.Add(vuelo);


                    }
                    
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            //Leyendo usuarios

            try {
                using (StreamReader ifile = new StreamReader("usuarios.txt"))
                {

                    while(!ifile.EndOfStream)
                    {
                        string uline = ifile.ReadLine();
                        string[] du = uline.Split('|');
                        int indexV = int.Parse(du[0]);
                       
                        Usuario user = new Usuario(du[1], du[2], du[4], int.Parse(du[3]));

                        listaVuelos[indexV].userlist.Add(user);
                        listaVuelos[indexV].setAsientoTomado(int.Parse(du[3]));
                    }



                }
            }
            catch(Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);

            }

            Principal ventanaPrincipal = new Principal(ref listaVuelos);

            ventanaPrincipal.ShowDialog();
            //codigo para escribir
            //string lines = "First line.\r\nSecond line.\r\nThird line.";

            StreamWriter file = new StreamWriter("infoVuelos.txt");
            StreamWriter file2 = new StreamWriter("usuarios.txt");

            int vindex=0;

            foreach (Vuelo v in listaVuelos)
            {
                file.WriteLine(v.ToString('|'));
                
                foreach(Usuario u in v.userlist)
                {
                    
                    file2.WriteLine(vindex.ToString()+'|'+u.ToString());
                }

                vindex++;
            }
            file.Close();
            file2.Close();

            Console.WriteLine("fin del programa");  
        }
    }
}
