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

    public partial class VuelosLista : Form
    {


        List<Vuelo> listaVuelos = new List<Vuelo>();
        List<Usuario> userlist = new List<Usuario>();
        

        public VuelosLista(ref List<Vuelo> listaVuelos,ref List<Usuario> userlist)
        {
            
            InitializeComponent();
            this.Ok_button.Enabled = false;

            this.listaVuelos = listaVuelos;
            this.userlist = userlist;

            for(int x = 0; x < this.listaVuelos.Count; x++)
            {

                listBox1.Items.Add(this.listaVuelos[x].ToString());
                
            }

        }

  
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            this.listBox1.SelectedItem.ToString();
            Console.WriteLine(this.listBox1.SelectedItem.ToString());
         //   Registro ventanaRegistro = new Registro(this.listBox1.SelectedItem.ToString());
           // ventanaRegistro.ShowDialog();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem.ToString() != null) {
                this.button2.Enabled = true;
            }
        }

        private void VuelosLista_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vuelo temp;
            string svuelo;
            svuelo = listBox1.SelectedItem.ToString();
            temp = listaVuelos[listBox1.SelectedIndex];
            this.Hide();
            SeleccionAsiento ventanaAsientos = new SeleccionAsiento(ref temp,ref svuelo,ref userlist);
            ventanaAsientos.ShowDialog();
        }
    }
}





