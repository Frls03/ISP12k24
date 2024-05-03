﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorERP;

//Programado por: Carol Chuy
namespace CapaVistaERP.Procesos
{
    public partial class OrdenesdeCompraMaestro : Form
    {
        private string id = "";
        private string nombre = "";
        private string domicilio = "";
        private string telefono = "";
        Controlador cn = new Controlador();
        public OrdenesdeCompraMaestro()
        {
            InitializeComponent();
            actualizardatagridview();
        }

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            OrdenesdeCompra OrdenesdeCompra = new OrdenesdeCompra(id, nombre, domicilio, telefono);
            OrdenesdeCompra.Show();
        }
        public void actualizardatagridview()
        {
            DataTable dt = cn.llenarTablas("tbl_ordenescompra");
            dataGridView1.DataSource = dt;
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            actualizardatagridview();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
