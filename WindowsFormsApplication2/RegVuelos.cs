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
    public partial class RegVuelos : Form
    {
        ListaVuelos listavuelos=new ListaVuelos();
        public RegVuelos(ref ListaVuelos listavuelos)
        {
            InitializeComponent();
            this.listavuelos = listavuelos;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
        }


        private bool isValidOD(string od)
        {
            char o = od[0];
            char d = od[1];

            foreach(Vuelo v in listavuelos)
            {
                if(v.getOrigen() == o && v.getDestino() == d)
                {
                    return false;
                }
            }


            return true;
        }

        private void button_accept_Click(object sender, EventArgs e)
        {
            
            string datestring = dateTimePicker1.Value.ToShortDateString() +' '+ dateTimePicker2.Value.ToShortTimeString();
            DateTime date=DateTime.Parse(datestring);
            string rutadata = textBox1.Text.ToUpper();
            string od;
           

            if (rutadata.Length == 5)
            {
                od = rutadata.Substring(rutadata.Length - 2);


                if (isValidOD(od))
                {
                    Vuelo vuelo = new Vuelo(30, od, rutadata, int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown1.Value.ToString()), date);
                    listavuelos.Add(vuelo);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("LA RUTA YA EXISTE", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("EL FORMATO ES INVALIDO", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
