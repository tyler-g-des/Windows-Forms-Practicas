using CapaDeBasesDatos;
using System;
using System.Windows.Forms;

namespace SistemaDeBlog
{
    partial class Form1
    {
        public static String paseNombre;


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

        void btnLogin(object sender, EventArgs e)
        {
            String nombre = nombreIngresado.Text.ToString();
            String clave = nombreClave.Text.ToString();
           

            usuario usuario = Conexion.getInstance().AccesoSistema(nombre, clave);


            if (usuario != null)
            {
                MessageBox.Show("Logueado");
                this.Hide();
                paseNombre = nombre;
                PantallaPublicaciones pu = new PantallaPublicaciones();
                pu.crearPantalla();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        void btnRegistrarUsuario(object sender, EventArgs e)
        {
            PantallaRegistrar pg = new PantallaRegistrar();
            pg.CrearPantallaRegistrar();
            this.Hide();
        }
    }
}

