using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class VentaAvanzada : Form
    {

        List<Vuelo> vuelosRuta = new List<Vuelo>();

        public VentaAvanzada(string ruta, ref List<Vuelo> vuelosRuta)
        {
            InitializeComponent();
            textBoxRuta.Text = ruta;
            textBoxRuta.Enabled = false;

            this.vuelosRuta = vuelosRuta;



        }

        private void textBoxRuta_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
        }

        private void textBoxApellido_Click(object sender, EventArgs e)
        {
            textBoxApellido.Text = "";
        }

        private void VentaAvanzada_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Vuelo v in vuelosRuta)
            {
                Vuelo fv = v;
                string fvdata = fv.ToString();

                Console.WriteLine(v.ToString());

                SeleccionAsiento venta = new SeleccionAsiento(ref fv,ref fvdata,textBoxName.Text,textBoxApellido.Text);
                venta.ShowDialog();

                    
            }

            this.Close();

        }
    }
}
