﻿using System;
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
        ListaCiudades listaciudades = new ListaCiudades();

        Vuelo vuelo = new Vuelo();

        public Principal(ref ListaVuelos listaVuelos,ref ListaCiudades listaciudades)
        {
            
            InitializeComponent();
            this.listaVuelos = listaVuelos;
            this.listaciudades = listaciudades;
    

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
            VuelosLista ventanaVuelos = new VuelosLista(ref listaVuelos,ref listaciudades);
            ventanaVuelos.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UsuariosLista userlistwindow = new UsuariosLista(ref listaVuelos);
            userlistwindow.ShowDialog();
       }

        private void rutasbutton_Click(object sender, EventArgs e)
        {
            GrafoVisual grafo = new GrafoVisual(ref listaciudades, ref listaVuelos);
            grafo.ShowDialog();
        }
    }
}
