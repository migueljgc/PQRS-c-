﻿namespace SistemaInventarioNet
{
    partial class FrmIndex
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btncerrarsesion = new Button();
            btnConfiguracion = new Button();
            btnReportes = new Button();
            btnCrearAdmin = new Button();
            btnGestionUsuario = new Button();
            btnVerUsuarios = new Button();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            btncerrar = new Button();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 162, 253);
            panel1.Controls.Add(btncerrarsesion);
            panel1.Controls.Add(btnConfiguracion);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnCrearAdmin);
            panel1.Controls.Add(btnGestionUsuario);
            panel1.Controls.Add(btnVerUsuarios);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 568);
            panel1.TabIndex = 0;
            // 
            // btncerrarsesion
            // 
            btncerrarsesion.Dock = DockStyle.Bottom;
            btncerrarsesion.FlatAppearance.BorderSize = 0;
            btncerrarsesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btncerrarsesion.FlatStyle = FlatStyle.Flat;
            btncerrarsesion.ForeColor = Color.Black;
            btncerrarsesion.ImageAlign = ContentAlignment.MiddleLeft;
            btncerrarsesion.Location = new Point(0, 542);
            btncerrarsesion.Name = "btncerrarsesion";
            btncerrarsesion.Size = new Size(200, 26);
            btncerrarsesion.TabIndex = 9;
            btncerrarsesion.Text = "Salir";
            btncerrarsesion.UseVisualStyleBackColor = true;
            btncerrarsesion.Click += btncerrarsesion_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Dock = DockStyle.Top;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.ForeColor = Color.Black;
            btnConfiguracion.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.Location = new Point(0, 259);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(200, 26);
            btnConfiguracion.TabIndex = 8;
            btnConfiguracion.Text = "Crear Secretario de Despacho";
            btnConfiguracion.UseVisualStyleBackColor = true;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.ForeColor = Color.Black;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 233);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(200, 26);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Crear Secretarias De Despacho";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnCrearAdmin
            // 
            btnCrearAdmin.Dock = DockStyle.Top;
            btnCrearAdmin.FlatAppearance.BorderSize = 0;
            btnCrearAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnCrearAdmin.FlatStyle = FlatStyle.Flat;
            btnCrearAdmin.ForeColor = Color.Black;
            btnCrearAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrearAdmin.Location = new Point(0, 207);
            btnCrearAdmin.Name = "btnCrearAdmin";
            btnCrearAdmin.Size = new Size(200, 26);
            btnCrearAdmin.TabIndex = 6;
            btnCrearAdmin.Text = "Crear Administradores";
            btnCrearAdmin.UseVisualStyleBackColor = true;
            btnCrearAdmin.Click += btnCrearAdmin_Click;
            // 
            // btnGestionUsuario
            // 
            btnGestionUsuario.Dock = DockStyle.Top;
            btnGestionUsuario.FlatAppearance.BorderSize = 0;
            btnGestionUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnGestionUsuario.FlatStyle = FlatStyle.Flat;
            btnGestionUsuario.ForeColor = Color.Black;
            btnGestionUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionUsuario.Location = new Point(0, 181);
            btnGestionUsuario.Name = "btnGestionUsuario";
            btnGestionUsuario.Size = new Size(200, 26);
            btnGestionUsuario.TabIndex = 4;
            btnGestionUsuario.Text = "Gestion Usuario";
            btnGestionUsuario.UseVisualStyleBackColor = true;
            btnGestionUsuario.Click += btnActualizarUsuario_Click;
            // 
            // btnVerUsuarios
            // 
            btnVerUsuarios.Dock = DockStyle.Top;
            btnVerUsuarios.FlatAppearance.BorderSize = 0;
            btnVerUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnVerUsuarios.FlatStyle = FlatStyle.Flat;
            btnVerUsuarios.ForeColor = Color.Black;
            btnVerUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerUsuarios.Location = new Point(0, 155);
            btnVerUsuarios.Name = "btnVerUsuarios";
            btnVerUsuarios.Size = new Size(200, 26);
            btnVerUsuarios.TabIndex = 3;
            btnVerUsuarios.Text = "Ver Usuarios";
            btnVerUsuarios.UseVisualStyleBackColor = true;
            btnVerUsuarios.Click += btnGestionUsuarios_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 55);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 100);
            panel5.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Pqrs_C_.Properties.Resources.iconprofile;
            pictureBox1.Location = new Point(53, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.NavajoWhite;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 55);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.BlanchedAlmond;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(btncerrar);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(200, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(844, 55);
            panel3.TabIndex = 1;
            panel3.MouseDown += panel3_MouseDown;
            panel3.MouseMove += panel3_MouseMove;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Pqrs_C_.Properties.Resources.pqrspng;
            pictureBox2.Location = new Point(236, -7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(223, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btncerrar
            // 
            btncerrar.Dock = DockStyle.Right;
            btncerrar.FlatAppearance.BorderSize = 0;
            btncerrar.FlatStyle = FlatStyle.Flat;
            btncerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btncerrar.ForeColor = Color.White;
            btncerrar.Location = new Point(803, 0);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(41, 55);
            btncerrar.TabIndex = 0;
            btncerrar.Text = "X";
            btncerrar.UseVisualStyleBackColor = true;
            btncerrar.Click += btncerrar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(200, 55);
            panel4.Name = "panel4";
            panel4.Size = new Size(844, 513);
            panel4.TabIndex = 2;
            // 
            // FrmIndex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 568);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmIndex";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btncerrar;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Button btnVerUsuarios;
        private Button btnConfiguracion;
        private Button btnReportes;
        private Button btnCrearAdmin;
        private Button btnGestionUsuario;
        private Button btncerrarsesion;
        private PictureBox pictureBox2;
    }
}
