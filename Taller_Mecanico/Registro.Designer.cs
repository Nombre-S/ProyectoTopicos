
namespace Taller_Mecanico
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.lblID_Registro = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.txtFec = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.dtgvRegistro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID_Registro
            // 
            this.lblID_Registro.AutoSize = true;
            this.lblID_Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_Registro.Location = new System.Drawing.Point(12, 9);
            this.lblID_Registro.Name = "lblID_Registro";
            this.lblID_Registro.Size = new System.Drawing.Size(99, 20);
            this.lblID_Registro.TabIndex = 0;
            this.lblID_Registro.Text = "ID Registro:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(12, 49);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(83, 20);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "Matricula:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 90);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(151, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha de Entrada: ";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(12, 132);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(132, 20);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora de Entrada";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(191, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(182, 27);
            this.txtID.TabIndex = 4;
            // 
            // txtMat
            // 
            this.txtMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMat.Location = new System.Drawing.Point(191, 46);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(182, 27);
            this.txtMat.TabIndex = 5;
            // 
            // txtFec
            // 
            this.txtFec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFec.Location = new System.Drawing.Point(191, 87);
            this.txtFec.Name = "txtFec";
            this.txtFec.Size = new System.Drawing.Size(182, 27);
            this.txtFec.TabIndex = 6;
            // 
            // txtHora
            // 
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(191, 129);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(182, 27);
            this.txtHora.TabIndex = 7;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdEliminar.BackgroundImage = global::Taller_Mecanico.Properties.Resources.IconoEliminar;
            this.cmdEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdEliminar.Location = new System.Drawing.Point(531, 12);
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
            this.cmdConsultar.Location = new System.Drawing.Point(587, 12);
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
            this.cmdSalir.Location = new System.Drawing.Point(643, 12);
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
            this.cmdModificar.Location = new System.Drawing.Point(475, 12);
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
            this.cmdGuardar.Location = new System.Drawing.Point(419, 12);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(50, 50);
            this.cmdGuardar.TabIndex = 15;
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // dtgvRegistro
            // 
            this.dtgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRegistro.Location = new System.Drawing.Point(12, 288);
            this.dtgvRegistro.Name = "dtgvRegistro";
            this.dtgvRegistro.ReadOnly = true;
            this.dtgvRegistro.RowHeadersWidth = 51;
            this.dtgvRegistro.RowTemplate.Height = 24;
            this.dtgvRegistro.Size = new System.Drawing.Size(678, 150);
            this.dtgvRegistro.TabIndex = 20;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Taller_Mecanico.Properties.Resources.FondoPantalla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.dtgvRegistro);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtFec);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblID_Registro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID_Registro;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.TextBox txtFec;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.DataGridView dtgvRegistro;
    }
}