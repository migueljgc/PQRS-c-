﻿namespace Pqrs_C_.App.User_Admin
{
    partial class FrmRegistroAdmin
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
            label4 = new Label();
            label5 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            BtnRegistar2 = new Button();
            TxtContraseña = new TextBox();
            TxtUsuario = new TextBox();
            label1 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 137);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 19;
            label4.Text = "APELLIDO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 85);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 18;
            label5.Text = "NOMBRE";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.White;
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Location = new Point(318, 155);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(139, 23);
            txtApellido.TabIndex = 17;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(318, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(138, 23);
            txtNombre.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 259);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 15;
            label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 194);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 14;
            label2.Text = "USUARIO";
            // 
            // BtnRegistar2
            // 
            BtnRegistar2.BackColor = Color.FromArgb(70, 162, 253);
            BtnRegistar2.FlatAppearance.BorderSize = 0;
            BtnRegistar2.FlatStyle = FlatStyle.Flat;
            BtnRegistar2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegistar2.ForeColor = Color.White;
            BtnRegistar2.Location = new Point(318, 345);
            BtnRegistar2.Name = "BtnRegistar2";
            BtnRegistar2.Size = new Size(138, 39);
            BtnRegistar2.TabIndex = 13;
            BtnRegistar2.Text = "Registrar";
            BtnRegistar2.UseVisualStyleBackColor = false;
            BtnRegistar2.Click += BtnRegistar2_Click;
            // 
            // TxtContraseña
            // 
            TxtContraseña.BackColor = Color.White;
            TxtContraseña.BorderStyle = BorderStyle.FixedSingle;
            TxtContraseña.Location = new Point(318, 277);
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.PasswordChar = '*';
            TxtContraseña.Size = new Size(139, 23);
            TxtContraseña.TabIndex = 12;
            // 
            // TxtUsuario
            // 
            TxtUsuario.BackColor = Color.White;
            TxtUsuario.BorderStyle = BorderStyle.FixedSingle;
            TxtUsuario.Location = new Point(318, 212);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(138, 23);
            TxtUsuario.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(70, 162, 253);
            label1.Location = new Point(247, 26);
            label1.Name = "label1";
            label1.Size = new Size(301, 29);
            label1.TabIndex = 10;
            label1.Text = "Registro De Administradores";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(462, 65);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 22;
            // 
            // FrmRegistroAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(844, 513);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnRegistar2);
            Controls.Add(TxtContraseña);
            Controls.Add(TxtUsuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistroAdmin";
            Text = "FrmRegistroAdministradores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label5;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Button BtnRegistar2;
        private TextBox TxtContraseña;
        private TextBox TxtUsuario;
        private Label label1;
        private Label label7;
    }
}