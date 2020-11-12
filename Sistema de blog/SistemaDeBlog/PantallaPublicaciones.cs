using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeBasesDatos;


namespace SistemaDeBlog
{
    class PantallaPublicaciones
    {
        private System.Windows.Forms.Label lbTituloPublicacion;
        private System.Windows.Forms.DataGridView listaPublicaciones;
        private System.Windows.Forms.RadioButton RBeditar;
        private System.Windows.Forms.RadioButton RBeliminar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.RadioButton RBmostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbContenido;
        private System.Windows.Forms.Button btnTrabajarPublicaciones;
        private System.Windows.Forms.RichTextBox txtContenido;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbContenidoTitulo;
        private System.Windows.Forms.Label lbContenidoFecha;
        private System.Windows.Forms.TextBox txtTituloUpdate;
        private System.Windows.Forms.Button btnGuardarEdicion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;

        private Form form;
        public static String valor;

        public void crearPantalla()
        {
            form = new Form();
            form.SuspendLayout();
            form.Size = new Size(1004, 700);
            form.Name = "Form1";
            form.Text = "Form1";
            form.Visible = true;

            this.lbTituloPublicacion = new System.Windows.Forms.Label();
            this.listaPublicaciones = new System.Windows.Forms.DataGridView();
            this.RBeditar = new System.Windows.Forms.RadioButton();
            this.RBeliminar = new System.Windows.Forms.RadioButton();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.RBmostrar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbContenido = new System.Windows.Forms.Label();
            this.btnTrabajarPublicaciones = new System.Windows.Forms.Button();
            this.txtContenido = new System.Windows.Forms.RichTextBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbContenidoTitulo = new System.Windows.Forms.Label();
            this.lbContenidoFecha = new System.Windows.Forms.Label();
            this.txtTituloUpdate = new System.Windows.Forms.TextBox();
            this.btnGuardarEdicion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            // 
            // lbTituloPublicacion
            // 
            this.lbTituloPublicacion.AutoSize = true;
            this.lbTituloPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPublicacion.Location = new System.Drawing.Point(12, 9);
            this.lbTituloPublicacion.Name = "lbTituloPublicacion";
            this.lbTituloPublicacion.Size = new System.Drawing.Size(268, 45);
            this.lbTituloPublicacion.TabIndex = 2;
            this.lbTituloPublicacion.Text = "Publicaciones";
            // 
            // listaPublicaciones
            // 
            this.listaPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaPublicaciones.Location = new System.Drawing.Point(18, 78);
            this.listaPublicaciones.Name = "listaPublicaciones";
            this.listaPublicaciones.RowHeadersWidth = 51;
            this.listaPublicaciones.RowTemplate.Height = 24;
            this.listaPublicaciones.Size = new System.Drawing.Size(298, 166);
            this.listaPublicaciones.TabIndex = 3;
            this.listaPublicaciones.ReadOnly = true;
            listaPublicaciones.CellClick += new DataGridViewCellEventHandler(DataGridView1_CellDoubleClick);
            // 
            // RBeditar
            // 
            this.RBeditar.AutoSize = true;
            this.RBeditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBeditar.Location = new System.Drawing.Point(12, 278);
            this.RBeditar.Name = "RBeditar";
            this.RBeditar.Size = new System.Drawing.Size(103, 33);
            this.RBeditar.TabIndex = 5;
            this.RBeditar.TabStop = true;
            this.RBeditar.Text = "Editar";
            this.RBeditar.UseVisualStyleBackColor = true;
            this.RBeditar.Hide();
            // 
            // RBeliminar
            // 
            this.RBeliminar.AutoSize = true;
            this.RBeliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBeliminar.Location = new System.Drawing.Point(12, 384);
            this.RBeliminar.Name = "RBeliminar";
            this.RBeliminar.Size = new System.Drawing.Size(130, 33);
            this.RBeliminar.TabIndex = 6;
            this.RBeliminar.TabStop = true;
            this.RBeliminar.Text = "Eliminar";
            this.RBeliminar.UseVisualStyleBackColor = true;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(444, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(104, 36);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "Titulo:";
            // 
            // RBmostrar
            // 
            this.RBmostrar.AutoSize = true;
            this.RBmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBmostrar.Location = new System.Drawing.Point(12, 334);
            this.RBmostrar.Name = "RBmostrar";
            this.RBmostrar.Size = new System.Drawing.Size(122, 33);
            this.RBmostrar.TabIndex = 8;
            this.RBmostrar.TabStop = true;
            this.RBmostrar.Text = "Mostrar";
            this.RBmostrar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 45);
            this.label2.TabIndex = 9;
            // 
            // lbContenido
            // 
            this.lbContenido.AutoSize = true;
            this.lbContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContenido.Location = new System.Drawing.Point(444, 208);
            this.lbContenido.Name = "lbContenido";
            this.lbContenido.Size = new System.Drawing.Size(170, 36);
            this.lbContenido.TabIndex = 10;
            this.lbContenido.Text = "Contenido:";
            // 
            // txtTituloUpdate
            // 
            this.txtTituloUpdate.AutoSize = true;
            this.txtTituloUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloUpdate.Location = new System.Drawing.Point(546, 63);
            this.txtTituloUpdate.Name = "txtTituloUpdate";
            this.txtTituloUpdate.Size = new System.Drawing.Size(170, 36);
            this.txtTituloUpdate.TabIndex = 10;
            this.txtTituloUpdate.Text = "Contenido:";
            this.txtTituloUpdate.Hide();
            // 
            // btnTrabajarPublicaciones
            // 
            this.btnTrabajarPublicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrabajarPublicaciones.Location = new System.Drawing.Point(44, 452);
            this.btnTrabajarPublicaciones.Name = "btnTrabajarPublicaciones";
            this.btnTrabajarPublicaciones.Size = new System.Drawing.Size(242, 69);
            this.btnTrabajarPublicaciones.TabIndex = 11;
            this.btnTrabajarPublicaciones.Text = "Trabajar con Publicaciones";
            this.btnTrabajarPublicaciones.UseVisualStyleBackColor = true;
            btnTrabajarPublicaciones.Click += new EventHandler(TrabajarConEncuesta);
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(450, 264);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(524, 310);
            this.txtContenido.TabIndex = 12;
            this.txtContenido.Text = "";
            this.txtContenido.ReadOnly = true;
            // this.txtContenido.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(444, 110);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(139, 45);
            this.lbFecha.TabIndex = 13;
            this.lbFecha.Text = "Fecha:";
            // 
            // lbContenidoTitulo
            // 
            this.lbContenidoTitulo.AutoSize = true;
            this.lbContenidoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContenidoTitulo.Location = new System.Drawing.Point(546, 63);
            this.lbContenidoTitulo.Name = "lbContenidoTitulo";
            this.lbContenidoTitulo.Size = new System.Drawing.Size(160, 36);
            this.lbContenidoTitulo.TabIndex = 14;
            this.lbContenidoTitulo.Text = "contenido";
            this.lbContenidoTitulo.Visible = false;
            // 
            // lbContenidoFecha
            // 
            this.lbContenidoFecha.AutoSize = true;
            this.lbContenidoFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContenidoFecha.Location = new System.Drawing.Point(546, 155);
            this.lbContenidoFecha.Name = "lbContenidoFecha";
            this.lbContenidoFecha.Size = new System.Drawing.Size(128, 29);
            this.lbContenidoFecha.TabIndex = 15;
            this.lbContenidoFecha.Text = "contenido";
            this.lbContenidoFecha.Visible = false;
            // 
            // btnGuardarEdicion
            // 
            this.btnGuardarEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEdicion.Location = new System.Drawing.Point(224, 366);
            this.btnGuardarEdicion.Name = "btnGuardarEdicion";
            this.btnGuardarEdicion.Size = new System.Drawing.Size(194, 68);
            this.btnGuardarEdicion.TabIndex = 16;
            this.btnGuardarEdicion.Text = "Editar";
            this.btnGuardarEdicion.UseVisualStyleBackColor = true;
            this.btnGuardarEdicion.Hide();
            btnGuardarEdicion.Click += new EventHandler(editarPublicacion);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(224, 453);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(194, 68);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Hide();
            btnCancelar.Click += new EventHandler(cancelarEditar);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(44, 529);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(242, 69);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += new EventHandler(agregarPublicidad);
            // 
            // Form5
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.Controls.Add(lbFecha);
            form.Controls.Add(txtContenido);
            form.Controls.Add(btnTrabajarPublicaciones);
            form.Controls.Add(lbContenido);
            form.Controls.Add(label2);
            form.Controls.Add(RBmostrar);
            form.Controls.Add(lbTitulo);
            form.Controls.Add(RBeliminar);
            form.Controls.Add(RBeditar);
            form.Controls.Add(listaPublicaciones);
            form.Controls.Add(lbTituloPublicacion);
            form.Controls.Add(lbContenidoTitulo);
            form.Controls.Add(lbContenidoFecha);
            form.Controls.Add(txtTituloUpdate);
            form.Controls.Add(btnCancelar);
            form.Controls.Add(btnGuardarEdicion);
            form.Controls.Add(btnAgregar);
            form.Name = "Form5";
            form.Text = "Form5";
            //form.Load += new System.EventHandler(form.Form5_Load);

            CargarEncuesta();
        }

        void CargarEncuesta()
        {
            usuarioNL usuarioNL = new usuarioNL();
            usuarioNL.CargarData(listaPublicaciones, Form1.paseNombre);
        }

        void TrabajarConEncuesta(object sender, EventArgs e)
        {
            if (RBeditar.Checked == false && RBeliminar.Checked == false && RBmostrar.Checked == false)
            {
                MessageBox.Show("Debe seleccionar una opcion");
            }
            else
            {
                if (listaPublicaciones.SelectedRows.Count > 0 && RBeliminar.Checked == true)
                {
                    int filaSeleccionada = listaPublicaciones.CurrentRow.Index;

                    usuarioNL usuarioNL = new usuarioNL();
                    usuarioNL.borrarPublicacion(valor);
                    listaPublicaciones.Columns.Clear();
                    listaPublicaciones.DataSource = "";
                    CargarEncuesta();

                    MessageBox.Show("Eliminar!!!");
                }

                else if (listaPublicaciones.SelectedRows.Count > 0 && RBeditar.Checked == true)
                {
                    int filaSeleccionada = listaPublicaciones.CurrentRow.Index;

                    usuarioNL nl = new usuarioNL();

                    // Elementos ocultar
                    RBeditar.Hide();
                    RBeliminar.Hide();
                    RBmostrar.Hide();

                    lbContenidoTitulo.Hide();
                    lbContenido.Hide();
                    btnTrabajarPublicaciones.Hide();
                    listaPublicaciones.Hide();
                    btnAgregar.Hide();

                    //Mostrados
                    txtTituloUpdate.Show();
                    txtTituloUpdate.Text = nl.CargarDataPublicacion(valor).titulo.ToString();
                    txtContenido.ReadOnly = false;

                    btnGuardarEdicion.Show();
                    btnCancelar.Show();
                }

                else if (listaPublicaciones.SelectedRows.Count > 0 && RBmostrar.Checked == true)
                {
                    int filaSeleccionada = listaPublicaciones.CurrentRow.Index;


                    usuarioNL nl = new usuarioNL();

                    lbContenidoFecha.Text = "";
                    lbContenidoFecha.Text = nl.CargarDataPublicacion(valor).fecha.ToString();
                    lbContenidoFecha.Visible = true;

                    lbContenidoTitulo.Text = "";
                    lbContenidoTitulo.Text = nl.CargarDataPublicacion(valor).titulo.ToString();
                    lbContenidoTitulo.Visible = true;

                    txtContenido.Text = "";
                    txtContenido.Text = nl.CargarDataPublicacion(valor).contenido.ToString();

                    RBeditar.Visible = true;
                }

                else
                {
                    MessageBox.Show("Debe seleccionar la columna pulsando en la columna a la izquierda del todo");
                }
            }

        }

        void DataGridView1_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            //obtienes el valor de la primer columna
            string valorPrimerCelda = listaPublicaciones.Rows[e.RowIndex].Cells[0].Value.ToString();
            valor = valorPrimerCelda;

        }

        void editarPublicacion(object sender, EventArgs e)
        {
            usuarioNL nl = new usuarioNL();
            nl.updatePublicacion(txtTituloUpdate.Text, txtContenido.Text, valor, Form1.paseNombre);
            form.Close();

            MessageBox.Show("Editado!!!");

            PantallaPublicaciones pu = new PantallaPublicaciones();
            pu.crearPantalla();
        }

        void cancelarEditar(object sender, EventArgs e)
        {
            // Elementos ocultar
            RBeditar.Show();
            RBeliminar.Show();
            RBmostrar.Show();

            lbContenidoTitulo.Show();
            lbContenido.Show();
            btnTrabajarPublicaciones.Show();
            listaPublicaciones.Show();

            //Mostrados
            txtTituloUpdate.Hide();

            btnGuardarEdicion.Hide();
            btnCancelar.Hide();
            btnAgregar.Hide();
           
        }

        void agregarPublicidad(object sender, EventArgs e)
        {
            form.Close();
            PantallaCrearPublicacion pcp = new PantallaCrearPublicacion();
            pcp.crearPantalla();
        }
    }
}
