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
    public partial class SeleccionAsiento : Form
    {

        Vuelo vueloObject;
        string vuelo;
        List<Button> Botones;
        List<Usuario> userlist=new List<Usuario>();

        public SeleccionAsiento(ref Vuelo vueloObject,ref string vuelo,ref List<Usuario> userlist)
        {
            InitializeComponent();
            Botones = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30 };
            this.vuelo = vuelo;
            this.vueloObject = vueloObject;
            this.userlist = userlist;

            for (int x = 0; x < 30; x++)
            {
                int y = x + 1;
                Botones[x].Text = "Asiento " + y.ToString();

                if (vueloObject.getAsientos(x) == true)
                {
                    Botones[x].BackColor = Color.Red;
                    Botones[x].Enabled = false;
                }
                else { Botones[x].BackColor = Color.Green; }

            }

        }



        private void SeleccionAsiento_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button1.Text, 1, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button2.Text, 2, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button3.Text, 3, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button4.Text, 4, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button5.Text, 5, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button6.Text, 6, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button7.Text, 7, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button8.Text, 8, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button9.Text, 9, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button10.Text, 10, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button11.Text, 11, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button12_Click(object sender, EventArgs e)
        {
            button12.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button12.Text, 12, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button13.Text, 13, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button14_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button14.Text, 14, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button15_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button15.Text, 15, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button16_Click(object sender, EventArgs e)
        {
            button16.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button16.Text, 16, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button17_Click(object sender, EventArgs e)
        {
            button17.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button17.Text, 17, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button18_Click(object sender, EventArgs e)
        {
            button18.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button18.Text, 18, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button19_Click(object sender, EventArgs e)
        {
            button19.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button19.Text, 19, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button20_Click(object sender, EventArgs e)
        {
            button20.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button20.Text, 20, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button21_Click(object sender, EventArgs e)
        {
            button21.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button21.Text, 21, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button22_Click(object sender, EventArgs e)
        {
            button22.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button22.Text, 22, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button23_Click(object sender, EventArgs e)
        {
            button23.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button23.Text, 23, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button24_Click(object sender, EventArgs e)
        {
            button24.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button24.Text, 24, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button25_Click(object sender, EventArgs e)
        {
            button25.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button25.Text, 25, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button26_Click(object sender, EventArgs e)
        {
            button26.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button26.Text, 26, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button27_Click(object sender, EventArgs e)
        {
            button27.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button27.Text, 27, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button28_Click(object sender, EventArgs e)
        {
            button28.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button28.Text, 28, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button29_Click(object sender, EventArgs e)
        {
            button29.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button29.Text, 29, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


        private void button30_Click(object sender, EventArgs e)
        {
            button30.Enabled = false;
            this.Hide();
            Registro registro = new Registro(vuelo, button30.Text, 30, ref vueloObject, ref userlist);

            registro.ShowDialog();
        }


    }
}
