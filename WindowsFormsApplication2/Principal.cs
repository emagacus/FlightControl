using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Principal : Form
    {

      

        ListaVuelos listaVuelos = new ListaVuelos();
        

        Vuelo vuelo = new Vuelo();

        public Principal(ref ListaVuelos listaVuelos)
        {
            
            InitializeComponent();
            this.listaVuelos = listaVuelos;
    

        }

        ///buscar sobrecarga


        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button clicked");
            VuelosLista ventanaVuelos = new VuelosLista(ref listaVuelos);
            ventanaVuelos.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UsuariosLista userlistwindow = new UsuariosLista(ref listaVuelos);
            userlistwindow.ShowDialog();
       }


        
       

    }
}
