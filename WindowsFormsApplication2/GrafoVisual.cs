using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{

 
   
    public partial class GrafoVisual : Form
    {
        bool NewMarkerEnabled = false;
        Pen pen1 = new Pen(Color.Blue, 10);
        Pen penarrow= new Pen(Color.Gray, 6);
        string name=" ";
        ListaVuelos listaVuelos = new ListaVuelos();

        Graphics g;
        ListaCiudades listaciudades = new ListaCiudades();
        




        public GrafoVisual(ref ListaCiudades listaciudades, ref ListaVuelos listaVuelos)
        {
            InitializeComponent();
            checkBoxCosto.Checked = true;
            this.listaVuelos = listaVuelos;
            buttonDelete.Enabled = false;
            this.listaciudades = listaciudades;
            refreshListView();


            pictureBox1.Image = new Bitmap(pictureBox1.Image);
           


            g = Graphics.FromImage(pictureBox1.Image);
            g.SmoothingMode = SmoothingMode.AntiAlias;                  // The smoothing mode specifies whether lines, curves, and the edges of filled areas use smoothing (also called antialiasing). One exception is that path gradient brushes do not obey the smoothing mode. Areas filled using a PathGradientBrush are rendered the same way (aliased) regardless of the SmoothingMode property.
            g.InterpolationMode = InterpolationMode.HighQualityBicubic; // The interpolation mode determines how intermediate values between two endpoints are calculated.
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;            // Use this property to specify either higher quality, slower rendering, or lower quality, faster rendering of the contents of this Graphics object.
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;


            penarrow.StartCap = LineCap.ArrowAnchor;
            penarrow.EndCap = LineCap.ArrowAnchor;

            

            foreach (CiudadNodo c in listaciudades)
            {
                
                g.DrawEllipse(pen1, c.X, c.Y, 10, 10);
                g.DrawString(c.getName(), new Font("Tahoma", 8),Brushes.White,c.X,c.Y);

                foreach (AristaCiudad a in c.Aristas)
                {
                    penarrow.Color = Color.FromArgb(100,Color.Red);
                    g.DrawLine(penarrow, a.X, a.Y, c.X, c.Y);
                    g.DrawString(a.getCosto().ToString()+"  "+a.getTiempo().ToString(), new Font("Tahoma", 8), Brushes.Blue, calcMedPoint(a.X, c.X), calcMedPoint(a.Y, c.Y));
                    // g.DrawEllipse(pen1,a.X, a.Y, 10, 10);

                }
            }

         

        }


        //RECORRIDOS


            //Dibujando ARM

            void drawArm(ref List<AristaCiudad> arm)
             {
            //  g.Clear(Color.AliceBlue);
            int costoTotal=0;int TiempoTotal = 0;

            pictureBox1.Image = Properties.Resources.mapa;
            pictureBox1.Image = new Bitmap(pictureBox1.Image);
            g = Graphics.FromImage(pictureBox1.Image);
            penarrow.Color = Color.FromArgb(255, Color.Green);


            foreach (AristaCiudad a in arm) {

                foreach (CiudadNodo c in listaciudades)
                {
                    if (c.getName() == a.getOrigen()  || c.getName() == a.getDest())
                    {
                        if (c.X != a.X)
                        {
                            g.DrawLine(penarrow, a.X, a.Y, c.X, c.Y);
                            g.DrawString(a.getCosto().ToString() + "  " + a.getTiempo().ToString(), new Font("Tahoma", 8), Brushes.Blue, calcMedPoint(a.X, c.X), calcMedPoint(a.Y, c.Y));
                            costoTotal = costoTotal + a.getCosto();
                            TiempoTotal = TiempoTotal + a.getTiempo();
                        }
                    }
                }
                    }

            foreach(CiudadNodo c in listaciudades)
            {
                g.DrawEllipse(pen1, c.X, c.Y, 10, 10);
                g.DrawString(c.getName(), new Font("Tahoma", 8), Brushes.White, c.X, c.Y);
            }


            textBox1.Text = "Costo total: "+costoTotal.ToString() + " Tiempo Total: " + TiempoTotal.ToString();

            }



            public void PrintGrafoAristas()
        {

            

            List<AristaCiudad> Krus = Kruskal();
            List<AristaCiudad> Prim = prim();

            drawArm(ref Krus);
           // drawArm(ref Prim);

            Console.WriteLine("Kruskal");

           foreach(AristaCiudad a in Krus)
                {
                Console.WriteLine(a.getOrigen() + " " + a.getDest() + " " + a.getTiempo());
                }

           Console.WriteLine("Prim");

            foreach (AristaCiudad a in Prim)
            {
                Console.WriteLine(a.getOrigen() + " " + a.getDest() + " " + a.getTiempo());
            }


            //Rehaciendo Dirigido

            foreach (CiudadNodo c in listaciudades)
            {
                int indx = 0;
                for (int x = 0; x < c.Aristas.Count; x++)
                {
                    Console.WriteLine("c: " + c.getName() + c.X.ToString() + c.Y.ToString() + "-- a: " + c.Aristas[indx].getOrigen() + c.Aristas[indx].X.ToString() + c.Aristas[indx].Y.ToString());

                    //if (c.X != c.Aristas[x].X) {
                    

                    indx++;
                }
                Console.WriteLine("\n");
            }

            //fin de rehaciendo dirigido


        }
        //Kruskal----ARM MENOR TIEMPO


        int[] isCC(ref List<string> compConexo,string o, string d)
        {
            int[] indices=new int[] { -1, -1, -1 };

            int indx = 0;
            foreach(string s in compConexo)
            {
                if (s.Contains(o) && !s.Contains(d)) { indices[0] = indx; Console.WriteLine("o esta aqui"); }
                if (s.Contains(d) && !s.Contains(o)) { indices[1] = indx; Console.WriteLine("d esta aqui"); }
                if (s.Contains(o) && s.Contains(d)) { indices[2] = indx; Console.WriteLine("od estan aqui"); }

                indx++;
            }

          return indices;
        }




               public List<AristaCiudad> Kruskal()
        {
            List<AristaCiudad> aristas = new List<AristaCiudad>();
            List<AristaCiudad> Arm=new List<AristaCiudad>();
            List<string> compConexos = new List<string>(); 
                         
            //Cargar Aristas y ordenar

            foreach(CiudadNodo c in listaciudades)
            {
                compConexos.Add(c.getName());
                foreach(AristaCiudad a in c.Aristas)
                {
                    aristas.Add(a);                    
                }
            }

            if (checkBoxTiempo.Checked == true) { aristas.Sort((x, y) => x.getTiempo().CompareTo(y.getTiempo())); } else
            { aristas.Sort((x, y) => x.getCosto().CompareTo(y.getCosto())); }
          

            //

           int[] ccs=new int[3];
           
        


                foreach(AristaCiudad a in aristas)
                {

                ccs = isCC(ref compConexos, a.getOrigen(), a.getDest());

                if (ccs[2] == -1)
                {
                    
                    compConexos.Add(compConexos[ccs[0]] + compConexos[ccs[1]]);

                    compConexos.RemoveAt(ccs[0]);
                    

                    Arm.Add(a);
                    

                }

                


            }//fin foreach aristas

           

            return Arm;
        } 


                //

               // PRIM-----ARM MENOR COSTO 
                    
                  
          List<AristaCiudad> prim()
        {
            List<AristaCiudad> Arm=new List<AristaCiudad>();
            List<CiudadNodo> Nododisp = new List<CiudadNodo>();
        
            List<AristaCiudad> aristasposibles = new List<AristaCiudad>();

            List<CiudadNodo> nodosTemp = new List<CiudadNodo>(listaciudades);


            ///Temporal Fix

            List<AristaCiudad> aristas = new List<AristaCiudad>();

            foreach (CiudadNodo c in listaciudades)
            {
                foreach (AristaCiudad a in c.Aristas)
                {
                    aristas.Add(a);
                }
            }


            /// 


            //Revisar a partir de Nododisp

            //Haciendolo no dirigido

            foreach (CiudadNodo c in nodosTemp)
            {
                int x = c.Aristas.Count;

                for (int y = 0; y < x; y++) {

                    AristaCiudad a = c.Aristas[y];
                    AristaCiudad atemp = new AristaCiudad(a.X, a.Y, a.getDest(), a.getOrigen(), a.getCosto(), a.getTiempo());
                    foreach(CiudadNodo c1 in nodosTemp) {if (atemp.getOrigen() == c1.getName()) { c1.Aristas.Add(atemp); } }
                    
                }
            }
              
           
            //

            //Empiezo con el primer nodo
            Nododisp.Add(nodosTemp[0]);
            string compConexos = Nododisp[0].getName().ToString();

            //



            int nArista = 0;


            while (nArista < listaciudades.Count - 1)
            {
                foreach(CiudadNodo c in Nododisp)
                {
                    Console.WriteLine("revisando: " + c.getName());
                    foreach(AristaCiudad a in c.Aristas)
                    {
                        if (!compConexos.Contains(a.getDest())) {

                            Console.WriteLine("añadido a posibles"+ a.getOrigen()+a.getDest());
                            aristasposibles.Add(a);

                        }
                    }//for aristas

                    
                }//for ciudades


              
                //  Console.WriteLine(aristasposibles[0].getDest().ToString() + aristasposibles[0].getCosto().ToString());

                //*******En caso de ser no conexo
                if (aristasposibles.Count == 0)
               {

                    if (compConexos.Length < listaciudades.Count)
                    { foreach (CiudadNodo c in listaciudades) { if (!compConexos.Contains(c.getName())) { Nododisp.Add(c);break; } }//fin foreach para buscar nuevo nodo



                        foreach (CiudadNodo c in Nododisp)
                        {
                            Console.WriteLine("revisando: " + c.getName());
                            foreach (AristaCiudad a in c.Aristas)
                            {
                                if (!compConexos.Contains(a.getDest()))
                                {

                                    Console.WriteLine("añadido a posibles" + a.getOrigen() + a.getDest());
                                    aristasposibles.Add(a);

                                }
                            }//for aristas


                        }//for ciudades



                    }




                    else {

                        foreach (CiudadNodo c in nodosTemp) { c.Aristas.Clear(); }

                        foreach (AristaCiudad a in aristas) { foreach (CiudadNodo c in listaciudades) { if (a.getOrigen() == c.getName()) { c.Aristas.Add(a); } } }
                        Console.WriteLine("Early retirement");
                        return Arm;
                    }//fin else 
                }



                //
                if (checkBoxCosto.Checked == true) { aristasposibles.Sort((x, y) => x.getCosto().CompareTo(y.getCosto())); }
                else
                {
                    aristasposibles.Sort((x, y) => x.getTiempo().CompareTo(y.getTiempo()));
                }

                compConexos = compConexos + aristasposibles[0].getDest().ToString();
                    Console.WriteLine("conjunto L: " + compConexos);
                    foreach (CiudadNodo c in listaciudades) { if (aristasposibles[0].getDest() == c.getName()) { Nododisp.Add(c); } }
                    nArista++;
                    Arm.Add(aristasposibles[0]);

                    aristasposibles.Clear();
                      

            }

            
            Nododisp.Clear();

            //nodosTemp.Clear();

            //Rehaciendo Dirigido

            foreach(CiudadNodo c in nodosTemp){c.Aristas.Clear();}

            foreach(AristaCiudad a in aristas) {foreach(CiudadNodo c in listaciudades) { if (a.getOrigen() == c.getName()) { c.Aristas.Add(a); } } }

            //fin de rehaciendo dirigido

            
                 return Arm;
        }     




               //



            //*****   DIJKSTRA      
            

                //        ****          ***        ***        *   *     *****    *****     *****      *****        // 
               //        *   *          *          *         *  *      *   *      *       *   *      *   *        //
              //        *    *         *          *         * *       *   *      *       *   *      *   *        //
             //        *     *        *          *         **        *          *       *****      *****        //
            //        *     *        *          *         **        *****      *       *  *       *   *        //
           //        *    *         *      *   *         * *           *      *       *   *      *   *        //
          //        *   *          *       *  *         *  *      *   *      *       *    *     *   *        //
         //        ****          ***       ***         *   *     *****      *       *    *     *   *        //



           CiudadNodo dijskUpdate(ref CiudadNodo nodoactual, ref List<DijkstraNode> caminos, ref string Definitivos)
           {

            DijkstraNode nuevo=new DijkstraNode();

            foreach(DijkstraNode d in caminos) { if (d.nombre == nodoactual.name) { nuevo.peso = d.peso; } }

          
            foreach(AristaCiudad a in nodoactual.Aristas)
            {

                foreach(DijkstraNode d in caminos)
                {
                    if (a.getDest() == d.nombre)
                    {
                       
                        if((a.getCosto()+nuevo.peso) < d.peso )
                        {

                            d.peso = a.getCosto()+nuevo.peso;
                            d.procedencia = nodoactual;

                        }
                    }        
                }

            }//fin foreach arista
              

            

           caminos.Sort((x, y) => x.peso.CompareTo(y.peso));
            foreach(DijkstraNode d in caminos) { if (!Definitivos.Contains(d.nombre)) { nuevo = d; break; } }
            Definitivos = Definitivos + nuevo.nombre;

            foreach (CiudadNodo c in listaciudades) { if (c.getName() == nuevo.nombre) { nodoactual = c;break; } }
                        
            return nodoactual;

        }


            List<DijkstraNode> Dijkstra(CiudadNodo origen)
            {

            List<DijkstraNode> caminos = new List<DijkstraNode>();
            CiudadNodo nodoActual=origen;
            string Definitivos = "";
            int numDef=0;


            //Se crea el vector de caminos

            foreach (CiudadNodo c in listaciudades)
            {

                DijkstraNode nodo = new DijkstraNode(c.getName(), 1000000000);

                if (c.getName()==origen.getName())
                { 
                    nodo.peso = 0;
                    nodo.procedencia = origen;
                }

                    caminos.Add(nodo);
            }


            //*** Se inicia con el origen;

             Definitivos = origen.getName();
             numDef++;
                         
            //***


            while(numDef != listaciudades.Count)
            {

                dijskUpdate(ref nodoActual, ref caminos, ref Definitivos);
                numDef++;
                                
            }



            return caminos;

            }















            //******


        //






        public GrafoVisual(ref ListaCiudades listaciudades,string name)
        {
            InitializeComponent();
            
            buttonDelete.Enabled = false;
            this.listaciudades = listaciudades;
            refreshListView();
            listView1.Enabled = false;

            this.name = name;
            NewMarkerEnabled = true;


            pictureBox1.Image = new Bitmap(pictureBox1.Image);

            g = Graphics.FromImage(pictureBox1.Image);
            g.SmoothingMode = SmoothingMode.AntiAlias;                  // The smoothing mode specifies whether lines, curves, and the edges of filled areas use smoothing (also called antialiasing). One exception is that path gradient brushes do not obey the smoothing mode. Areas filled using a PathGradientBrush are rendered the same way (aliased) regardless of the SmoothingMode property.
            g.InterpolationMode = InterpolationMode.HighQualityBicubic; // The interpolation mode determines how intermediate values between two endpoints are calculated.
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;            // Use this property to specify either higher quality, slower rendering, or lower quality, faster rendering of the contents of this Graphics object.
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;


            penarrow.StartCap = LineCap.ArrowAnchor;



            foreach (CiudadNodo c in listaciudades)
            {
                Console.WriteLine(c.getName());
                g.DrawEllipse(pen1, c.X, c.Y, 10, 10);
                g.DrawString(c.getName(), new Font("Tahoma", 8), Brushes.White, c.X, c.Y);

                foreach (AristaCiudad a in c.Aristas)
                {
                    penarrow.Color = Color.FromArgb(100, Color.Red);
                    g.DrawLine(penarrow, a.X, a.Y, c.X, c.Y);
                    g.DrawString(a.getCosto().ToString() + "  " + a.getTiempo().ToString(), new Font("Tahoma", 8), Brushes.Blue, calcMedPoint(a.X, c.X), calcMedPoint(a.Y, c.Y));
                    // g.DrawEllipse(pen1,a.X, a.Y, 10, 10);

                }
            }



        }


        private void refreshListView()

        {


            pictureBox1.Image = new Bitmap(pictureBox1.Image);

            g = Graphics.FromImage(pictureBox1.Image);
            g.SmoothingMode = SmoothingMode.AntiAlias;                  // The smoothing mode specifies whether lines, curves, and the edges of filled areas use smoothing (also called antialiasing). One exception is that path gradient brushes do not obey the smoothing mode. Areas filled using a PathGradientBrush are rendered the same way (aliased) regardless of the SmoothingMode property.
            g.InterpolationMode = InterpolationMode.HighQualityBicubic; // The interpolation mode determines how intermediate values between two endpoints are calculated.
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;            // Use this property to specify either higher quality, slower rendering, or lower quality, faster rendering of the contents of this Graphics object.
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;


            penarrow.StartCap = LineCap.ArrowAnchor;


            foreach (CiudadNodo c in listaciudades)
            {
                ListViewItem i = new ListViewItem(c.getName());
                listView1.Items.Add(i);
                g.DrawEllipse(pen1, c.X, c.Y, 10, 10);
                g.DrawString(c.getName(), new Font("Tahoma", 8), Brushes.White, c.X, c.Y);

                foreach (AristaCiudad a in c.Aristas)
                {
                    penarrow.Color = Color.FromArgb(100, Color.Red);
                    g.DrawLine(penarrow, a.X, a.Y, c.X, c.Y);
                    g.DrawString(a.getCosto().ToString() + "  " + a.getTiempo().ToString(), new Font("Tahoma", 8), Brushes.Blue, calcMedPoint(a.X, c.X), calcMedPoint(a.Y, c.Y));
                    // g.DrawEllipse(pen1,a.X, a.Y, 10, 10);

                }

            }
        }



        private float calcMedPoint(float a, float b)
        {
            float c;

            if (a >= b)
            {
                c = a - b;
                c = c / 2;
                c = c + b;
            }
            else
            {
                c = b - a;
                c = c / 2;
                c = c + a;
            }

            return c;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

            var mouseEventArgs = e as MouseEventArgs;

            if (NewMarkerEnabled)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Image);
                g = Graphics.FromImage(pictureBox1.Image);                
                g.DrawEllipse(pen1, mouseEventArgs.X, mouseEventArgs.Y, 10, 10);
                NewMarkerEnabled = false;

                List<AristaCiudad> aris = new List<AristaCiudad>();
                CiudadNodo city = new CiudadNodo(mouseEventArgs.X, mouseEventArgs.Y, name,aris);
                listaciudades.Add(city);

                this.Close();

            }
        }



         ~GrafoVisual()
        {
            pictureBox1.Dispose();
            g.Dispose();
            pen1.Dispose();
            penarrow.Dispose();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.FocusedItem.Text != null)
            {
                buttonDelete.Enabled = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listaciudades.deleteC(listView1.FocusedItem.Text);

            
            for(int index = 0;index<listaVuelos.Count;index++)
            {
                if (listaVuelos[index].getDestino().ToString() == listView1.FocusedItem.Text || listaVuelos[index].getOrigen().ToString() == listView1.FocusedItem.Text)
                {
                    listaVuelos.RemoveAt(index);
                    index--;
                }
                    
            }

            buttonDelete.Enabled = false;


            listView1.Clear();
           
            RecargarGrafo();
            refreshListView();
            this.Close();
        }

        private void buttonKrus_Click(object sender, EventArgs e)
        {
            
            List<AristaCiudad> arm = Kruskal();
            drawArm(ref arm);
            Console.WriteLine("-------Kruskal Realizado------");

            arm.Clear();
        }

        private void primButton_Click(object sender, EventArgs e)
        {
          

            List<AristaCiudad> arm = prim();
           
            drawArm(ref arm);
            Console.WriteLine("-------Prim Realizado------");
            PrintGrafoAristas();
            arm.Clear();
        }


        void RecargarGrafo() {

            pictureBox1.Image = Properties.Resources.mapa;
            pictureBox1.Image = new Bitmap(pictureBox1.Image);
            g = Graphics.FromImage(pictureBox1.Image);



            foreach (CiudadNodo c in listaciudades)
            {

                g.DrawEllipse(pen1, c.X, c.Y, 10, 10);
                g.DrawString(c.getName(), new Font("Tahoma", 8), Brushes.White, c.X, c.Y);

                foreach (AristaCiudad a in c.Aristas)
                {
                    penarrow.Color = Color.FromArgb(100, Color.Red);
                    g.DrawLine(penarrow, a.X, a.Y, c.X, c.Y);
                    g.DrawString(a.getCosto().ToString() + "  " + a.getTiempo().ToString(), new Font("Tahoma", 8), Brushes.Blue, calcMedPoint(a.X, c.X), calcMedPoint(a.Y, c.Y));
                    // g.DrawEllipse(pen1,a.X, a.Y, 10, 10);

                }
            }
        }

        private void RecargaGrafoButton_Click(object sender, EventArgs e)
        {

            RecargarGrafo();
        }

        private void checkBoxTiempo_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCosto.Checked = false;
            
        }

        private void checkBoxCosto_CheckedChanged(object sender, EventArgs e)
        {
           checkBoxTiempo.Checked = false;
            
        }

        private void buttonDijk_Click(object sender, EventArgs e)
        {
            List<DijkstraNode> caminos = Dijkstra(listaciudades[0]);

            foreach (DijkstraNode d in caminos)
            {
                if (d.procedencia != null)
                {
                    Console.WriteLine(d.nombre + "----" + d.peso.ToString() + "from----- " + d.procedencia.name);
                }
                }
        }
    }
}
