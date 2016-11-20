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
    public partial class Registro : Form
    {
        string  asiento; int No_asiento;
        Vuelo vueloObject;
        

        public Registro()
        {
            InitializeComponent();
        }

        public Registro(string asiento,int No_asiento, ref Vuelo vueloObject,string nombre,string apellido)
        {
            
            this.vueloObject = vueloObject;
            this.asiento = asiento;
            this.No_asiento = No_asiento;
            InitializeComponent();
            vuelo_textBox.Text = vueloObject.ToString().Substring(3);
            this.vuelo_textBox.Enabled = false;
            this.textBox2.Text = asiento;
            this.textBox2.Enabled = false;
            textBox3.Text = nombre;
            textBox4.Text = apellido;
        }




        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vueloObject.setAsientoTomado(No_asiento);
            Usuario user = new Usuario(textBox3.Text, textBox4.Text,vuelo_textBox.Text ,No_asiento);
            vueloObject.userlist.Add(user);
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
