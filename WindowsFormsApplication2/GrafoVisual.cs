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
            refreshListView();
            this.Close();
        }
    }
}
