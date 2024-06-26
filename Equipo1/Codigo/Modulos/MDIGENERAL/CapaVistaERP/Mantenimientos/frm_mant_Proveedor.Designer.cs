﻿namespace CapaVistaERP.Mantenimientos
{
    partial class frm_Mant_Proveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_prov = new System.Windows.Forms.DataGridView();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.telefono_prov = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nit_prov = new System.Windows.Forms.TextBox();
            this.domicilio_prov = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre_prov = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.navegador1 = new CapaVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dg_prov)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_prov
            // 
            this.dg_prov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_prov.Location = new System.Drawing.Point(26, 316);
            this.dg_prov.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dg_prov.Name = "dg_prov";
            this.dg_prov.RowHeadersWidth = 51;
            this.dg_prov.RowTemplate.Height = 24;
            this.dg_prov.Size = new System.Drawing.Size(993, 257);
            this.dg_prov.TabIndex = 50;
            this.dg_prov.Tag = "tbl_proveedor";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(508, 260);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(270, 22);
            this.txt_estado.TabIndex = 67;
            this.txt_estado.Tag = "estado_prov";
            this.txt_estado.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(413, 222);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 20);
            this.label16.TabIndex = 64;
            this.label16.Text = "Estado";
            // 
            // telefono_prov
            // 
            this.telefono_prov.Location = new System.Drawing.Point(143, 260);
            this.telefono_prov.Margin = new System.Windows.Forms.Padding(4);
            this.telefono_prov.Name = "telefono_prov";
            this.telefono_prov.Size = new System.Drawing.Size(211, 22);
            this.telefono_prov.TabIndex = 63;
            this.telefono_prov.Tag = "telefono_prov";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(413, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "NIT";
            // 
            // nit_prov
            // 
            this.nit_prov.Location = new System.Drawing.Point(508, 182);
            this.nit_prov.Margin = new System.Windows.Forms.Padding(4);
            this.nit_prov.Name = "nit_prov";
            this.nit_prov.Size = new System.Drawing.Size(270, 22);
            this.nit_prov.TabIndex = 60;
            this.nit_prov.Tag = "nit_prov";
            // 
            // domicilio_prov
            // 
            this.domicilio_prov.Location = new System.Drawing.Point(143, 220);
            this.domicilio_prov.Margin = new System.Windows.Forms.Padding(4);
            this.domicilio_prov.Name = "domicilio_prov";
            this.domicilio_prov.Size = new System.Drawing.Size(211, 22);
            this.domicilio_prov.TabIndex = 59;
            this.domicilio_prov.Tag = "domicilio_prov";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 264);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Teléfono";
            // 
            // nombre_prov
            // 
            this.nombre_prov.Location = new System.Drawing.Point(143, 182);
            this.nombre_prov.Margin = new System.Windows.Forms.Padding(4);
            this.nombre_prov.Name = "nombre_prov";
            this.nombre_prov.Size = new System.Drawing.Size(211, 22);
            this.nombre_prov.TabIndex = 57;
            this.nombre_prov.Tag = "nombre_prov";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Domicilio";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(508, 220);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(270, 24);
            this.comboBox2.TabIndex = 70;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(26, 36);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1001, 96);
            this.navegador1.TabIndex = 71;
            // 
            // frm_Mant_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 633);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.telefono_prov);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nit_prov);
            this.Controls.Add(this.domicilio_prov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombre_prov);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dg_prov);
            this.Name = "frm_Mant_Proveedor";
            this.Text = "8001-Mant. Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dg_prov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dg_prov;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox telefono_prov;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nit_prov;
        private System.Windows.Forms.TextBox domicilio_prov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre_prov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private CapaVista.Navegador navegador1;
    }
}