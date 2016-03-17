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
    public partial class UsuariosLista : Form
    {

        ListaVuelos listaVuelos = new ListaVuelos();
        int VueloId = new int();
        
        
        public UsuariosLista(ref ListaVuelos listaVuelos)
        {

            InitializeComponent();
            button_buscar.Enabled = false;
            VueloId = 0;
            button1.Enabled = false;
            this.listaVuelos = listaVuelos;
            refreshListview();

       //     if (userList.Items.Count <= 0)
         //   {
          //      button1.Enabled = false;
          //  }



        }


        private void refreshListview()
        {
            listView1.Items.Clear();
            foreach (Vuelo v in listaVuelos)

            {


                foreach (Usuario u in v.userlist)
                {

                    string[] datos = u.ToString().Split('|');

                    ListViewItem item = new ListViewItem(datos);
                    item.SubItems.Add(VueloId.ToString());
                    listView1.Items.Add(item);

                }

                VueloId++;
            }
        }

        private void UsuariosLista_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int IndexVuelo = Int32.Parse(listView1.Items[listView1.FocusedItem.Index].SubItems[4].Text);
            int IndexAsiento = Int32.Parse(listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text);

            listaVuelos[IndexVuelo].setAsientoTomado(IndexAsiento);


            int a = 0;
            int x = new int();

            foreach(Usuario user in listaVuelos[IndexVuelo].userlist)
            {
                if (user.getAsiento() == IndexAsiento)
                {
                    x = a;
                }
                a++;
            }
        try {
                listaVuelos[IndexVuelo].userlist.RemoveAt(x);

                listView1.Items.RemoveAt(listView1.FocusedItem.Index);

                if (listView1.Items.Count == 0)
                {
                    button1.Enabled = false;
                    button_buscar.Enabled = false;
                }
                 
            }
            catch (ArgumentOutOfRangeException) { }

        }

    

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.ToString() != null)
            {
                this.button1.Enabled = true;
            }
        }

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {
            if(textBox_buscar.Text!=null && listView1.Items.Count > 0)
            {
                button_buscar.Enabled = true;
            }
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            int x = 0;
            
            foreach (ListViewItem i in listView1.Items)
            {
                string itemstr=new string(' ',1);
                itemstr = i.SubItems[0].ToString()+ i.SubItems[1].ToString();
               

                if (itemstr.IndexOf(textBox_buscar.Text.ToString(),StringComparison.OrdinalIgnoreCase) <= 0)
                    //!itemstr.Contains(textBox_buscar.Text))
                {
                    listView1.Items.RemoveAt(x);
                    x--;
                }

                x++;
            }

            button_buscar.Enabled = false;
        }

        private void buttonRecargar_Click(object sender, EventArgs e)
        {
            refreshListview();
        }
    }
}
