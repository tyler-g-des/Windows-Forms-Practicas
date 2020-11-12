using CapaDeBasesDatos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeBlog
{
    public class PantallaCrearPublicacion
    {
        private System.Windows.Forms.Label lbTituloo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lbContenido;
        private System.Windows.Forms.RichTextBox txtContenido;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Button btnGuardarEdicion;
        DateTime now = Convert.ToDateTime( new DateTime());

        Form form;

        public void crearPantalla()
        {
            form = new Form();
            form.SuspendLayout();
            form.Size = new Size(1015, 601);
            form.Name = "Form1";
            form.Text = "Form1";
            form.Visible = true;

            this.lbTituloo = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lbContenido = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.RichTextBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.btnGuardarEdicion = new System.Windows.Forms.Button();
            // 
            // lbTituloo
            // 
            this.lbTituloo.AutoSize = true;
            this.lbTituloo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloo.Location = new System.Drawing.Point(12, 9);
            this.lbTituloo.Name = "lbTituloo";
            this.lbTituloo.Size = new System.Drawing.Size(289, 45);
            this.lbTituloo.TabIndex = 14;
            this.lbTituloo.Text = "Crear Pregunta";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(125, 54);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(104, 36);
            this.lbTitulo.TabIndex = 15;
            this.lbTitulo.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(219, 93);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(396, 22);
            this.txtTitulo.TabIndex = 16;
            // 
            // lbContenido
            // 
            this.lbContenido.AutoSize = true;
            this.lbContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContenido.Location = new System.Drawing.Point(125, 160);
            this.lbContenido.Name = "lbContenido";
            this.lbContenido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbContenido.Size = new System.Drawing.Size(170, 36);
            this.lbContenido.TabIndex = 17;
            this.lbContenido.Text = "Contenido:";
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(221, 232);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(394, 199);
            this.txtContenido.TabIndex = 18;
            this.txtContenido.Text = "";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(621, 476);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbFecha.Size = new System.Drawing.Size(102, 36);
            this.lbFecha.TabIndex = 19;
            this.lbFecha.Text = now.ToString();
            // 
            // btnGuardarEdicion
            // 
            this.btnGuardarEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEdicion.Location = new System.Drawing.Point(70, 462);
            this.btnGuardarEdicion.Name = "btnGuardarEdicion";
            this.btnGuardarEdicion.Size = new System.Drawing.Size(194, 68);
            this.btnGuardarEdicion.TabIndex = 20;
            this.btnGuardarEdicion.Text = "Guardar";
            this.btnGuardarEdicion.UseVisualStyleBackColor = true;
            btnGuardarEdicion.Click += new EventHandler(crearPublicacion);
            // 
            // Form6
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.Controls.Add(lbFecha);
            form.Controls.Add(txtContenido);
            form.Controls.Add(lbContenido);
            form.Controls.Add(txtTitulo);
            form.Controls.Add(lbTitulo);
            form.Controls.Add(lbTituloo);
            form.Controls.Add(btnGuardarEdicion);
            form.Name = "Form6";
            form.Text = "Form6";
            form.ResumeLayout(false);
            form.PerformLayout();
        }


        public void  crearPublicacion(object sender, EventArgs e)
        {
            if(txtTitulo.Text == "" || 
               txtTitulo.Text == null ||
               txtContenido.Text == "" ||
               txtContenido.Text == null)
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                usuarioNL us = new usuarioNL();
                us.guardarPublicacion(txtTitulo.Text,txtContenido.Text,lbFecha.Text.ToString(),Form1.paseNombre);

                MessageBox.Show("Creado!!!");

                form.Close();
                PantallaPublicaciones pu = new PantallaPublicaciones();
                pu.crearPantalla();
            }
        }


    }

}
