using Contactos_WindowsForm.Pantallas;
using Logica;
using Logica.Entidades;
using System;
using System.IO;
using System.Windows.Forms;

namespace Contactos_WindowsForm
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        void btnLoguearButton(object sender, EventArgs e)
        {

            try
            {
                Stream st = File.OpenRead("Datos\\usuario\\" + nombreIngresado.Text.ToLower());

                var binfor = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                usuarios obj = (usuarios)binfor.Deserialize(st);

                if (obj.nombreUsuario == nombreIngresado.Text.ToLower() && obj.clave == nombreClave.Text)
                {
                    MessageBox.Show("Logueado");
                    menuContactos mc = new menuContactos();
                    mc.crearMenu(nombreIngresado.Text);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o clave incorrecta");

                }
            }
            catch
            {
                MessageBox.Show("Este usuario no esta registrado");
            }

        }

        void btnRegistrarButton(object sender, EventArgs e)
        {
            PantallaRegistrar pr = new PantallaRegistrar();
            pr.CrearPantallaRegistrar();
            this.Hide();
        }

    }
}

