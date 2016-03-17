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


        ListaVuelos listaVuelos = new ListaVuelos();
        ListaCiudades listaciudades = new ListaCiudades();
        

        public VuelosLista(ref ListaVuelos listaVuelos,ref ListaCiudades listaciudades)
        {
            
            InitializeComponent();

            Buscar.Enabled = false;
            this.listaVuelos = listaVuelos;
            this.listaciudades = listaciudades;
            Button_delete.Enabled = false;



            int index = 0;
            foreach(Vuelo v in listaVuelos)
            {
                string[] datav = v.ToString('|').Split('|');
                ListViewItem dv = new ListViewItem(datav);
                dv.SubItems.Add(index.ToString());
                listView1.Items.Add(dv);
                index++;
            }



        }

  
        private void RefreshListView()
        {
            listView1.Items.Clear();
            int index = 0;
            foreach (Vuelo v in listaVuelos)
            {
                string[] datav = v.ToString('|').Split('|');
                ListViewItem dv = new ListViewItem(datav);
                dv.SubItems.Add(index.ToString());
                listView1.Items.Add(dv);
                index++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            this.listView1.FocusedItem.ToString();
            Console.WriteLine(this.listView1.FocusedItem.ToString());
         
            //   Registro ventanaRegistro = new Registro(this.listBox1.SelectedItem.ToString());
           // ventanaRegistro.ShowDialog();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.FocusedItem.ToString() != null) {
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
            svuelo = listView1.FocusedItem.SubItems[2].Text;
            temp = listaVuelos[int.Parse(listView1.FocusedItem.SubItems[6].Text)];
            this.Hide();
            SeleccionAsiento ventanaAsientos = new SeleccionAsiento(ref temp,ref svuelo);
            ventanaAsientos.ShowDialog();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            listaVuelos.SortBySeats(0, listaVuelos.Count - 1);
            listView1.Items.Clear();

            RefreshListView();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            listaVuelos.SortByDate(0, listaVuelos.Count-1);
            listView1.Items.Clear();

            RefreshListView();

        }

        
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                Buscar.Enabled = true;
            }
        }



        private void Buscar_Click(object sender, EventArgs e)
        {
            

            RefreshListView();
            


            int index = 0;
            string mystring;

            foreach(Vuelo v  in listaVuelos)
            {
                mystring = v.ToString() ;
                if ( mystring.IndexOf(textBox1.Text.ToString(),StringComparison.OrdinalIgnoreCase) <= 0)
                    //!v.ToString().Contains(textBox1.Text.ToString()))
                {

                  listView1.Items.RemoveAt(index);
                  index--;

                }

                index++;
                }//fin foreach

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.ToString() != null)
            {
                button2.Enabled = true;
                Button_delete.Enabled = true;
            }
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {


            if (listView1.FocusedItem != null)
            {

                listaciudades.deletArista(listaVuelos[int.Parse(listView1.FocusedItem.SubItems[6].Text)].getOrigen().ToString(), listaVuelos[int.Parse(listView1.FocusedItem.SubItems[6].Text)].getDestino().ToString());
                listaVuelos.RemoveAt(int.Parse(listView1.FocusedItem.SubItems[6].Text));
                listView1.Items.Clear();
                 

                RefreshListView();

            }//fin if

        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            RegVuelos regvuelo = new RegVuelos(ref listaVuelos,ref listaciudades);
            regvuelo.ShowDialog();
            RefreshListView();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshListView();
        }


        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            DateTime currentdate = DateTime.Now;
            Console.WriteLine(currentdate.ToString());
            int index = 0;
            List<int> listindex=new List<int>();

            foreach(Vuelo v in listaVuelos)
            {
                if (DateTime.Compare(v.getFecha(), currentdate) < 0)
                {
                    listindex.Add(index);
                }
                index++;
            }

            int temp = 0;

            foreach(int i in listindex)
            {
                listaVuelos.RemoveAt(i - temp);
                temp++;
            }

            RefreshListView();
        }
    }
}





