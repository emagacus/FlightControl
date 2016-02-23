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

            

            List<Vuelo> listaVuelos = new List<Vuelo>();

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("infoVuelos.txt"))
                {
                    // Read the stream to a string, and write the string to the console.

                    while (!sr.EndOfStream)
                    {

                        String line = sr.ReadLine();
                        string[] datavuelo = line.Split('|');
                        Vuelo vuelo = new Vuelo(int.Parse(datavuelo[0]),datavuelo[1], datavuelo[2], int.Parse(datavuelo[3]), int.Parse(datavuelo[4]));
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



            /*  Vuelo vuelo0 = new Vuelo("AB", "SK1AB", 50, 600);
              Vuelo vuelo1 = new Vuelo("AF", "SK1AF", 90, 1050);
              Vuelo vuelo2 = new Vuelo("AG", "SK1AG", 80, 1150);
              Vuelo vuelo3 = new Vuelo("BA", "SK1BA", 50, 600);
              Vuelo vuelo4 = new Vuelo("BC", "SK1BC", 40, 750);
              Vuelo vuelo5 = new Vuelo("BD", "SK1BD", 60, 650);
              Vuelo vuelo6 = new Vuelo("BE", "SK1BE", 70, 1850);
              Vuelo vuelo7 = new Vuelo("CB", "SK1CB", 35, 800);
              Vuelo vuelo8 = new Vuelo("CE", "SK1CE", 50, 850);
              Vuelo vuelo9 = new Vuelo("EG", "SK1EG", 45, 750);
              Vuelo vuelo10 = new Vuelo("EL", "SK1EL", 80, 1150);
              Vuelo vuelo11 = new Vuelo("ED", "SK1ED", 60, 1650);
              Vuelo vuelo12 = new Vuelo("DE", "SK1DE", 35, 700);
              Vuelo vuelo13 = new Vuelo("DB", "SK1DB", 45, 900);
              Vuelo vuelo14 = new Vuelo("FB", "SK1FB", 55, 700);
              Vuelo vuelo15 = new Vuelo("FL", "SK1FL", 65, 800);
              Vuelo vuelo16 = new Vuelo("FB", "SK1FB", 140, 2850);
              Vuelo vuelo17 = new Vuelo("FL", "SK1FL", 95, 1250);
              Vuelo vuelo18 = new Vuelo("GA", "SK1GA", 75, 1175);
              Vuelo vuelo19 = new Vuelo("GE", "SK1GE", 135, 2675);
              Vuelo vuelo20 = new Vuelo("GL", "SK1GL", 60, 1400);
              Vuelo vuelo21 = new Vuelo("GJ", "SK1GJ", 25, 450);
              Vuelo vuelo22 = new Vuelo("GH", "SK1GH", 30, 350);
              Vuelo vuelo23 = new Vuelo("HG", "SK1HG", 35, 400);
              Vuelo vuelo24 = new Vuelo("HI", "SK1HI", 35, 400);
              Vuelo vuelo25 = new Vuelo("IH", "SK1IH", 25, 400);
              Vuelo vuelo26 = new Vuelo("IK", "SK1IK", 40, 400);
              Vuelo vuelo27 = new Vuelo("KI", "SK1KI", 70, 300);
              Vuelo vuelo28 = new Vuelo("KJ", "SK1KJ", 40, 750);
              Vuelo vuelo29 = new Vuelo("JL", "SK1JL", 70, 1450);
              Vuelo vuelo30 = new Vuelo("JM", "SK1JM", 40, 650);
              Vuelo vuelo31 = new Vuelo("LM", "SK1LM", 70, 700);
              Vuelo vuelo32 = new Vuelo("LK", "SK1LK", 60, 1550);
              Vuelo vuelo33 = new Vuelo("LE", "SK1LE", 40, 700);








          //    listaVuelos.Add(vuelo0);
              listaVuelos.Add(vuelo1);
              listaVuelos.Add(vuelo2);
              listaVuelos.Add(vuelo3);
              listaVuelos.Add(vuelo4);
              listaVuelos.Add(vuelo5);
              listaVuelos.Add(vuelo6);
              listaVuelos.Add(vuelo7);
              listaVuelos.Add(vuelo8);
              listaVuelos.Add(vuelo9);
              listaVuelos.Add(vuelo10);
              listaVuelos.Add(vuelo11);
              listaVuelos.Add(vuelo12);
              listaVuelos.Add(vuelo13);
              listaVuelos.Add(vuelo14);
              listaVuelos.Add(vuelo15);
              listaVuelos.Add(vuelo16);
              listaVuelos.Add(vuelo17);
              listaVuelos.Add(vuelo18);
              listaVuelos.Add(vuelo19);
              listaVuelos.Add(vuelo20);
              listaVuelos.Add(vuelo21);
              listaVuelos.Add(vuelo22);
              listaVuelos.Add(vuelo23);
              listaVuelos.Add(vuelo24);
              listaVuelos.Add(vuelo25);
              listaVuelos.Add(vuelo26);
              listaVuelos.Add(vuelo27);
              listaVuelos.Add(vuelo28);
              listaVuelos.Add(vuelo29);
              listaVuelos.Add(vuelo30);
              listaVuelos.Add(vuelo31);
              listaVuelos.Add(vuelo32);
              listaVuelos.Add(vuelo33);
              */


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
