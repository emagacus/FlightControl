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
        ListaCiudades listaciudades = new ListaCiudades();

        public RegVuelos(ref ListaVuelos listavuelos, ref ListaCiudades listaciudades)
        {
            InitializeComponent();
            this.listavuelos = listavuelos;
            this.listaciudades = listaciudades;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
        }


        int CiudadExiste(char s)
        {
            int index = 0;
            foreach(CiudadNodo c in listaciudades)
            {
                if (s.ToString() == c.getName()) { return index; }
                index++;
            }

            return -1;
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
                    
                    if (CiudadExiste(od[0])==-1){

                        MessageBox.Show("Haga click en la imagen para seleccionar la ubicacion de la ciudad origen", "Ayuda",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);

                        GrafoVisual selecCity = new GrafoVisual(ref listaciudades,od[0].ToString());
                        selecCity.ShowDialog();
                     
                    }

                    int indexO = CiudadExiste(od[0]);


                    if (CiudadExiste(od[1])==-1)
                    {

                        MessageBox.Show("Haga click en la imagen para seleccionar la ubicacion de la ciudad destino", "Ayuda",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);

                        GrafoVisual selecCity = new GrafoVisual(ref listaciudades,od[1].ToString());
                        selecCity.ShowDialog();                   

                       AristaCiudad arista = new AristaCiudad(listaciudades[listaciudades.Count - 1].X, listaciudades[listaciudades.Count - 1].Y, od[0].ToString(), od[1].ToString(), int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown1.Value.ToString()));
                        listaciudades[indexO].Aristas.Add(arista);

                    }
                    else
                    {
                        int ExisteCiudad = CiudadExiste(od[1]);

                        AristaCiudad arista = new AristaCiudad(listaciudades[ExisteCiudad].X, listaciudades[ExisteCiudad].Y, od[0].ToString(), od[1].ToString(), int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown1.Value.ToString()));
                        listaciudades[indexO].Aristas.Add(arista);

                    }

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

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La ruta debe ser de 5 caracteres, los dos ultimos caracteres corresponden a el origen y el destino respectivamente", "Ayuda",
         MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
