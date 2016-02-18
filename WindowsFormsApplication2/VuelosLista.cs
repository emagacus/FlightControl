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
        
        

        public VuelosLista(ref List<Vuelo> listaVuelos)
        {
            
            InitializeComponent();
            

            this.listaVuelos = listaVuelos;

         

           

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
            SeleccionAsiento ventanaAsientos = new SeleccionAsiento(ref temp,ref svuelo);
            ventanaAsientos.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            qksortbySeat(ref listaVuelos, 0, listaVuelos.Count - 1);
            listBox1.Items.Clear();
            for (int x = 0; x < this.listaVuelos.Count; x++)
            {

                listBox1.Items.Add(this.listaVuelos[x].ToString());

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            qksortbyDate(ref listaVuelos, 0, listaVuelos.Count-1);
            listBox1.Items.Clear();
            for (int x = 0; x < this.listaVuelos.Count; x++)
            {

                listBox1.Items.Add(this.listaVuelos[x].ToString());

            }

        }



        private int divideListByDate(ref List<Vuelo> listavuelos,int start, int end)
        {
            int left;
            int right;
            Vuelo pivot;
            Vuelo temp;

                   pivot = listavuelos[start];
            left = start;
            right = end;

            // Mientras no se cruzen los índices
            while (left < right)
            {
                while (listavuelos[right].getDate() > pivot.getDate())
                {
                    right--;
                }

                while ((left < right) && (listaVuelos[left].getDate() <= pivot.getDate()))
                {
                    left++;
                }

                // Si todavía no se cruzan los indices seguimos intercambiando
                if (left < right)
                {
                    temp = listaVuelos[left];
                    listavuelos[left] = listavuelos[right];
                    listavuelos[right] = temp;
                }
            }

            // Los índices ya se han cruzado, ponemos el pivot en el lugar que le corresponde
            temp = listavuelos[right];
            listavuelos[right] = listavuelos[start];
            listavuelos[start] = temp;

            // La nueva posición del pivot
            return right;

        }



        private int divideListBySeat(ref List<Vuelo> listavuelos, int start, int end)
        {
            int left;
            int right;
            Vuelo pivot;
            Vuelo temp;

            pivot = listavuelos[start];
            left = start;
            right = end;

            // Mientras no se cruzen los índices
            while (left < right)
            {
                while (listavuelos[right].getAsientosDisp() > pivot.getAsientosDisp())
                {
                    right--;
                }

                while ((left < right) && (listaVuelos[left].getAsientosDisp() <= pivot.getAsientosDisp()))
                {
                    left++;
                }

                // Si todavía no se cruzan los indices seguimos intercambiando
                if (left < right)
                {
                    temp = listaVuelos[left];
                    listavuelos[left] = listavuelos[right];
                    listavuelos[right] = temp;
                }
            }

            // Los índices ya se han cruzado, ponemos el pivot en el lugar que le corresponde
            temp = listavuelos[right];
            listavuelos[right] = listavuelos[start];
            listavuelos[start] = temp;

            // La nueva posición del pivot
            return right;

        }




        private void qksortbySeat(ref List<Vuelo> listaVuelos,int start,int end)
        {
            int pivot;

            if (start < end)
            {
                pivot = divideListBySeat(ref listaVuelos, start, end);

                // Ordeno la lista de los menores
                qksortbySeat(ref listaVuelos, start, pivot - 1);

                // Ordeno la lista de los mayores
                qksortbySeat(ref listaVuelos, pivot + 1, end);
            }
        }


        private void qksortbyDate(ref List<Vuelo> listaVuelos, int start, int end)
        {
            int pivot;

            if (start < end)
            {
                pivot = divideListByDate(ref listaVuelos, start, end);

                // Ordeno la lista de los menores
                qksortbyDate(ref listaVuelos, start, pivot - 1);

                // Ordeno la lista de los mayores
                qksortbyDate(ref listaVuelos, pivot + 1, end);
            }
        }






    }
}





