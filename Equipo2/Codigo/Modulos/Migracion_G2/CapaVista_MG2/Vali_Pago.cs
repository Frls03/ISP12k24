﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_MG2;
using System.Drawing.Printing;
namespace CapaVista_MG2
{
    public partial class GBP : Form
    {
        private Controlador controlador;
        private DataTable datosTabla;
        public CapaControlador_MG2.Controlador ctrl;
        public GBP()
        {
            InitializeComponent();
            this.ctrl = new CapaControlador_MG2.Controlador();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.ctrl.saveBol();
            MessageBox.Show("Pago realizado con exito");
            btn_imprimir.Enabled = true;
      
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            this.ctrl.consultBol();
        }
    }
}
