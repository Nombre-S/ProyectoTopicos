
namespace Taller_Mecanico
{
    partial class frmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblRepuesto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRep = new System.Windows.Forms.TextBox();
            this.txtCostoRep = new System.Windows.Forms.TextBox();
            this.txtMano = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtEuros = new System.Windows.Forms.TextBox();
            this.txtPesetas = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtMecanico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdEliminar.BackgroundImage = global::Taller_Mecanico.Properties.Resources.IconoEliminar;
            this.cmdEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdEliminar.Location = new System.Drawing.Point(626, 12);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(50, 50);
            this.cmdEliminar.TabIndex = 17;
            this.cmdEliminar.UseVisualStyleBackColor = false;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdConsultar.BackgroundImage = global::Taller_Mecanico.Properties.Resources.IconoConsulta;
            this.cmdConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdConsultar.Location = new System.Drawing.Point(682, 12);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(50, 50);
            this.cmdConsultar.TabIndex = 18;
            this.cmdConsultar.UseVisualStyleBackColor = false;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdSalir.BackgroundImage = global::Taller_Mecanico.Properties.Resources.IconoSalir;
            this.cmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdSalir.Location = new System.Drawing.Point(738, 12);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(50, 50);
            this.cmdSalir.TabIndex = 19;
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdModificar.BackgroundImage = global::Taller_Mecanico.Properties.Resources.IconoModificar;
            this.cmdModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdModificar.Location = new System.Drawing.Point(570, 12);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(50, 50);
            this.cmdModificar.TabIndex = 16;
            this.cmdModificar.UseVisualStyleBackColor = false;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdGuardar.BackgroundImage = global::Taller_Mecanico.Properties.Resources.IconoGuardar;
            this.cmdGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdGuardar.Location = new System.Drawing.Point(514, 12);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(50, 50);
            this.cmdGuardar.TabIndex = 15;
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(12, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(93, 20);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "ID Factura:";
            // 
            // lblRepuesto
            // 
            this.lblRepuesto.AutoSize = true;
            this.lblRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepuesto.Location = new System.Drawing.Point(12, 58);
            this.lblRepuesto.Name = "lblRepuesto";
            this.lblRepuesto.Size = new System.Drawing.Size(85, 20);
            this.lblRepuesto.TabIndex = 21;
            this.lblRepuesto.Text = "Repuesto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Costo Repuesto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mano de Obra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Total Factura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Total Euros:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Total Pesetas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "DNI Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "ID Mecanico:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(202, 9);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(156, 27);
            this.txtID.TabIndex = 29;
            // 
            // txtRep
            // 
            this.txtRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRep.Location = new System.Drawing.Point(202, 55);
            this.txtRep.Name = "txtRep";
            this.txtRep.Size = new System.Drawing.Size(156, 27);
            this.txtRep.TabIndex = 30;
            // 
            // txtCostoRep
            // 
            this.txtCostoRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoRep.Location = new System.Drawing.Point(202, 98);
            this.txtCostoRep.Name = "txtCostoRep";
            this.txtCostoRep.Size = new System.Drawing.Size(156, 27);
            this.txtCostoRep.TabIndex = 31;
            // 
            // txtMano
            // 
            this.txtMano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMano.Location = new System.Drawing.Point(202, 146);
            this.txtMano.Name = "txtMano";
            this.txtMano.Size = new System.Drawing.Size(156, 27);
            this.txtMano.TabIndex = 32;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(202, 192);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(156, 27);
            this.txtTotal.TabIndex = 33;
            // 
            // txtEuros
            // 
            this.txtEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuros.Location = new System.Drawing.Point(202, 240);
            this.txtEuros.Name = "txtEuros";
            this.txtEuros.Size = new System.Drawing.Size(156, 27);
            this.txtEuros.TabIndex = 34;
            // 
            // txtPesetas
            // 
            this.txtPesetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesetas.Location = new System.Drawing.Point(202, 287);
            this.txtPesetas.Name = "txtPesetas";
            this.txtPesetas.Size = new System.Drawing.Size(156, 27);
            this.txtPesetas.TabIndex = 35;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(202, 332);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(156, 27);
            this.txtCliente.TabIndex = 36;
            // 
            // txtMecanico
            // 
            this.txtMecanico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMecanico.Location = new System.Drawing.Point(202, 371);
            this.txtMecanico.Name = "txtMecanico";
            this.txtMecanico.Size = new System.Drawing.Size(156, 27);
            this.txtMecanico.TabIndex = 37;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Taller_Mecanico.Properties.Resources.FondoPantalla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMecanico);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtPesetas);
            this.Controls.Add(this.txtEuros);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtMano);
            this.Controls.Add(this.txtCostoRep);
            this.Controls.Add(this.txtRep);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRepuesto);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFactura";
            this.Text = "Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblRepuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtRep;
        private System.Windows.Forms.TextBox txtCostoRep;
        private System.Windows.Forms.TextBox txtMano;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtEuros;
        private System.Windows.Forms.TextBox txtPesetas;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtMecanico;
    }
}