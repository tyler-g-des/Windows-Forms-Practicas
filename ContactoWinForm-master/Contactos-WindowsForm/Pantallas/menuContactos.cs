using Logica;
using Logica.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contactos_WindowsForm.Pantallas
{
    public class menuContactos
    {
        #region objetos
        Form form;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbContactos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelelefono;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        String nombreGlobal;
        #endregion

        public void crearMenu(String nombre)
        {
            form = new Form();
            form.SuspendLayout();
            form.Size = new Size(844, 527);
            form.Name = "Form1";
            form.Text = "MENU CONTACTOS";
            form.Visible = true;

            nombreGlobal = nombre;

            this.label2 = new System.Windows.Forms.Label();
            this.cbContactos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelelefono = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(665, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = nombre.ToUpper();
            // 
            // cbContactos
            // 
            this.cbContactos.FormattingEnabled = true;
            this.cbContactos.Location = new System.Drawing.Point(42, 104);
            this.cbContactos.Name = "cbContactos";
            this.cbContactos.Size = new System.Drawing.Size(261, 24);
            this.cbContactos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "SELECCION USUARIO";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(375, 181);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(213, 40);
            this.lbApellido.TabIndex = 9;
            this.lbApellido.Text = "APELLIDO:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(375, 104);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(191, 40);
            this.lbNombre.TabIndex = 10;
            this.lbNombre.Text = "NOMBRE:";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(375, 256);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(235, 40);
            this.lbDireccion.TabIndex = 11;
            this.lbDireccion.Text = "DIRECCION:";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.Location = new System.Drawing.Point(375, 339);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(230, 40);
            this.lbTelefono.TabIndex = 12;
            this.lbTelefono.Text = "TELEFONO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 32);
            this.label7.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(572, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 22);
            this.txtNombre.TabIndex = 14;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(572, 191);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(208, 22);
            this.txtApellido.TabIndex = 15;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(572, 266);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(208, 22);
            this.txtDireccion.TabIndex = 16;
            // 
            // txtTelelefono
            // 
            this.txtTelelefono.Location = new System.Drawing.Point(572, 349);
            this.txtTelelefono.Name = "txtTelelefono";
            this.txtTelelefono.Size = new System.Drawing.Size(208, 22);
            this.txtTelelefono.TabIndex = 17;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(42, 402);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(169, 66);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "VER SELECCION";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new EventHandler(rellenarEditar);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(240, 402);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(188, 66);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(690, 435);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 44);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "EXIT";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new EventHandler(exitButton);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(423, 402);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 71);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "CARGAR - CONTACTOS";
            this.btnEliminar.Click += new EventHandler(cargarCombo);
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(690, 383);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 46);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new EventHandler(agregarButton);
            // 
            // Form3
            // 
            form.Controls.Add(this.btnEliminar);
            form.Controls.Add(this.btnSalir);
            form.Controls.Add(this.btnGuardar);
            form.Controls.Add(this.btnEditar);
            form.Controls.Add(this.txtTelelefono);
            form.Controls.Add(this.txtDireccion);
            form.Controls.Add(this.txtApellido);
            form.Controls.Add(this.txtNombre);
            form.Controls.Add(this.label7);
            form.Controls.Add(this.lbTelefono);
            form.Controls.Add(this.lbDireccion);
            form.Controls.Add(this.lbNombre);
            form.Controls.Add(this.lbApellido);
            form.Controls.Add(this.label1);
            form.Controls.Add(this.cbContactos);
            form.Controls.Add(this.label2);
            form.Controls.Add(this.btnAgregar);
            form.Name = "Form3";
            form.Text = "MENU CONTACTOS";
            form.ResumeLayout(false);
            form.PerformLayout();

        }

        public void exitButton(object sender, EventArgs e)
        {
            form.Close();

            Form1 ff = new Form1();
            ff.Visible = true;

        }

        public void agregarButton(object sender, EventArgs e)
        {
            form.Close();

            AgregarContacto ag = new AgregarContacto();
            ag.crearPantallaAgregarContacto(nombreGlobal);
        }

        public void cargarCombo(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles("Datos\\contacto\\");

            var binfor = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            Stream st;

            for (int i = 0; i <= files.Length-1; i++)
            {
                st = File.OpenRead(files[i]);
                contactos obj = (contactos)binfor.Deserialize(st);
               
                if(obj.usuarioDelContacto == nombreGlobal)
                {
                    if (cbContactos.Items.Contains(obj.nombre))
                    {
                        MessageBox.Show("La lista esta cargada");
                    }
                    else
                    {
                        cbContactos.Items.Add(obj.nombre.ToString());
                    }
                }

            }

        }

        public void rellenarEditar(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles("Datos\\contacto\\");


            int dd = cbContactos.SelectedIndex;
            var binfor = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream st;

            if (dd == -1 || dd == 0)
            {
                MessageBox.Show("Debe seleccionar contacto si no existen cargue la lista o agregue un contacto");
            }
            else
            {
                st = File.OpenRead(files[dd]);
                contactos obj = (contactos)binfor.Deserialize(st);
                txtNombre.Text = obj.nombre.ToString();
                txtApellido.Text = obj.apellido.ToString();
                txtTelelefono.Text = obj.telefonoPersonal.ToString();
                txtDireccion.Text = obj.direccion.ToString();
            }
        }
    }

}
