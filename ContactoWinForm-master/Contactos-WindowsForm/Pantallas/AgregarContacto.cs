using Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contactos_WindowsForm.Pantallas
{
    public class AgregarContacto
    {
         System.Windows.Forms.TextBox txtApellido;
         System.Windows.Forms.Label lbApellido;
         System.Windows.Forms.TextBox txtNombre;
          System.Windows.Forms.Label lbNombre;
          System.Windows.Forms.TextBox txtDireccion;
         System.Windows.Forms.Label lbDireccion;
         System.Windows.Forms.TextBox txtTelefono;
         System.Windows.Forms.Label lbTelfono;
         System.Windows.Forms.Button btnRegitrar;
         System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        String nombreGLOBAL;
        Form form;

        public void crearPantallaAgregarContacto(String nombre)
        {
            form = new Form();
            form.Name = "Form1";
            form.Text = "AGREGAR CONTACTO";
            form.Visible = true;

            nombreGLOBAL = nombre;

            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbTelfono = new System.Windows.Forms.Label();
            this.btnRegitrar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(183, 206);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(332, 22);
            this.txtApellido.TabIndex = 8;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(54, 157);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(161, 32);
            this.lbApellido.TabIndex = 7;
            this.lbApellido.Text = "APELLIDO";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(183, 93);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(332, 22);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.Text = "";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(54, 43);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(144, 32);
            this.lbNombre.TabIndex = 5;
            this.lbNombre.Text = "NOMBRE";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(183, 318);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(332, 22);
            this.txtDireccion.TabIndex = 10;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(54, 258);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(179, 32);
            this.lbDireccion.TabIndex = 9;
            this.lbDireccion.Text = "DIRECCION";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(183, 431);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(332, 22);
            // 
            // lbTelfono
            // 
            this.lbTelfono.AutoSize = true;
            this.lbTelfono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelfono.Location = new System.Drawing.Point(54, 381);
            this.lbTelfono.Name = "lbTelfono";
            this.lbTelfono.Size = new System.Drawing.Size(345, 32);
            this.lbTelfono.TabIndex = 11;
            this.lbTelfono.Text = "TELEFONO PERSONAL";
            // 
            // btnRegitrar
            // 
            this.btnRegitrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegitrar.Location = new System.Drawing.Point(569, 206);
            this.btnRegitrar.Name = "btnRegitrar";
            this.btnRegitrar.Size = new System.Drawing.Size(241, 110);
            this.btnRegitrar.TabIndex = 13;
            this.btnRegitrar.Text = "REGISTRAR";
            this.btnRegitrar.UseVisualStyleBackColor = true;
            this.btnRegitrar.Click += new EventHandler(agregarContactoListaButton);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(133, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // Form2
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.ClientSize = new System.Drawing.Size(850, 524);
            form.Controls.Add(this.flowLayoutPanel1);
            form.Controls.Add(this.btnRegitrar);
            form.Controls.Add(this.txtTelefono);
            form.Controls.Add(this.lbTelfono);
            form.Controls.Add(this.txtDireccion);
            form.Controls.Add(this.lbDireccion);
            form.Controls.Add(this.txtApellido);
            form.Controls.Add(this.lbApellido);
            form.Controls.Add(this.txtNombre);
            form.Controls.Add(this.lbNombre);
            form.Text = "AGREGAR CONTACTO";
        }


        public void agregarContactoListaButton(object sender, EventArgs e)
        {
           

            CRUDCONTACTOS cdc = new CRUDCONTACTOS();
            cdc.crearDirectorio(txtNombre.Text,tomarDatos());

            form.Close();

            menuContactos mc = new menuContactos();
            mc.crearMenu(nombreGLOBAL);
        }

        public contactos tomarDatos()
        {

           String nombre = txtNombre.Text;
           String apellido = txtApellido.Text;
           String direccion = txtApellido.Text;
           String telefono = txtTelefono.Text;
           String usuario = nombreGLOBAL;

            contactos ct = new contactos(nombre,apellido,direccion,telefono,usuario);


            return ct;
        }


    }

}

