
namespace Taller_Mecanico
{
    partial class frmMecanico
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
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtIDR = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtFK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdEliminar.BackgroundImage = global::Taller_Mecanico.Properties.Resources.IconoEliminar;
            this.cmdEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdEliminar.Location = new System.Drawing.Point(570, 12);
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
            this.cmdConsultar.Location = new System.Drawing.Point(626, 12);
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
            this.cmdSalir.Location = new System.Drawing.Point(682, 12);
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
            this.cmdModificar.Location = new System.Drawing.Point(514, 12);
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
            this.cmdGuardar.Location = new System.Drawing.Point(458, 12);
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
            this.lblID.Size = new System.Drawing.Size(108, 20);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "ID Mecanico:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(12, 55);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(150, 20);
            this.lblNom.TabIndex = 21;
            this.lblNom.Text = "Nombre Mecanico:";
            // 
            // txtIDR
            // 
            this.txtIDR.AutoSize = true;
            this.txtIDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDR.Location = new System.Drawing.Point(12, 98);
            this.txtIDR.Name = "txtIDR";
            this.txtIDR.Size = new System.Drawing.Size(99, 20);
            this.txtIDR.TabIndex = 22;
            this.txtIDR.Text = "ID Registro:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(169, 9);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(162, 27);
            this.txtID.TabIndex = 23;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(169, 52);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(162, 27);
            this.txtNom.TabIndex = 24;
            // 
            // txtFK
            // 
            this.txtFK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFK.Location = new System.Drawing.Point(169, 95);
            this.txtFK.Name = "txtFK";
            this.txtFK.Size = new System.Drawing.Size(162, 27);
            this.txtFK.TabIndex = 25;
            // 
            // frmMecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Taller_Mecanico.Properties.Resources.FondoPantalla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.txtFK);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtIDR);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdGuardar);
            this.Name = "frmMecanico";
            this.Text = "Mecanico";
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
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label txtIDR;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtFK;
    }
}