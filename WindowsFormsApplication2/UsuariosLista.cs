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

        List<Usuario> userlist = new List<Usuario>();
        
        public UsuariosLista(ref List<Usuario> userlist)
        {

            InitializeComponent();
            
            foreach (Usuario u in userlist)
            {
                userList.Items.Add(u.ToString());
            }

            this.userlist = userlist;   
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
            int a = new int();
            a = userList.SelectedIndex;
            userlist.RemoveAt(a);
            userList.Items.RemoveAt(a);
        }
    }
}
