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
    public partial class Principal : Form
    {

      

        List<Vuelo> listaVuelos = new List<Vuelo>();
        List<Usuario> userlist = new List<Usuario>();

        Vuelo vuelo = new Vuelo();

        public Principal(ref List<Vuelo> listaVuelos,ref List<Usuario> userlist)
        {

            InitializeComponent();
            this.listaVuelos = listaVuelos;
            this.userlist = userlist;

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
            VuelosLista ventanaVuelos = new VuelosLista(ref listaVuelos,ref userlist);
            ventanaVuelos.ShowDialog();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (userlist.Count != 0)
            {
                UsuariosLista usuariolista = new UsuariosLista(ref userlist);
                usuariolista.ShowDialog();
            }

            else {

                MessageBox.Show("TODAVIA NO EXISTE NINGUN USUARIO", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
    }
}
