using CapaNegocio;
using CapaNegocio.Mesas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CapaNegocio.LogicaPedidos;

namespace CapaUI
{
    public partial class Programa : Form
    {
        MesaLogica logica = new MesaLogica();
        LogicaPedidos logicaPedidos = new LogicaPedidos();    

        #region ControlesInicio
        //Seleccionar el numero de mesas
        ListBox lista = new ListBox();
        Button[] boton = new Button[10];
        int seleccion;
        #endregion

        #region ControlesMesa

        Label etiqueta = new Label();
        TextBox txtMesaOrden = new TextBox();
        Button btnSeleccionarMesa = new Button();
        ListBox listaPersonas = new ListBox();
        int numeroDePersonas;
        Button btn = new Button();
        Button enviarOrdenes = new Button();
        Button cancelarOrdenes = new Button();
        Label cantidadMesa = new Label();
        Label cantidadPersona = new Label();
        Button Detalle = new Button();

        #endregion

        #region pedidos
        Form pedidos = new Form();
        int mesaEnUso;
        int contadorPedido=1;

        Button siguientePedido = new Button();
        #endregion


        public Programa()
        {
            InitializeComponent();

            // Boton para crear mas ordenes 
            siguientePedido.Click += new EventHandler(continuar_Pedido);
        }

        private void SeleccionarMesa_Load(object sender, EventArgs e)
        {

            Label lb = new Label();
            lb.Visible = true;
            lb.Text = "Seleccione una mesa";
            lb.Font = new Font("Microsoft Sans serif", 20);
            lb.Location = new Point(43, 9);
            lb.Size = new Size(272, 31);
            this.Controls.Add(lb);

            Button atendido = new Button();
            atendido.Visible = true;
            atendido.Text = "";
            atendido.BackColor = Color.Green;
            atendido.Location = new Point(447,61);
            atendido.Size = new Size(33, 23);
            this.Controls.Add(atendido);

            Button proceso = new Button();
            proceso.Visible = true;
            proceso.Text = "";
            proceso.BackColor = Color.Yellow;
            proceso.Location = new Point(447, 90);
            proceso.Size = new Size(33, 23);
            this.Controls.Add(proceso);

            Label t1 = new Label();
            t1.Visible = true;
            t1.Text = "Atendido";
            t1.Location = new Point(500, 66);
            t1.Size = new Size(49,13);
            this.Controls.Add(t1);

            Label t2 = new Label();
            t2.Visible = true;
            t2.Text = "Proceso de atencion";
            t2.Location = new Point(500, 95);
            t2.Size = new Size(105, 13);
            this.Controls.Add(t2);


            //Numero De mesas
            lista.Items.Add("");
            lista.Items.Add("1");
            lista.Items.Add("2");
            lista.Items.Add("3");
            lista.Items.Add("4");
            lista.Items.Add("5");
            lista.Items.Add("6");
            lista.Items.Add("7");
            lista.Items.Add("8");

 
            lista.Size = new Size(353,212);
            lista.Location = new Point(49,60);
            this.Controls.Add(lista);


            //Boton Para Seleccionar la cantidad de mesas
            btn.Text = "Seleccionar una mesa";
            btn.Visible = true;
            btn.Location = new Point(171, 290);
            btn.Size = new Size(231,36);
            this.Controls.Add(btn);
             

            //Eventos botones
            btn.Click += new EventHandler(crear_FomularioMesa);
            this.Controls.Add(btn);

            btnSeleccionarMesa.Click += new EventHandler(crear_Pedido);
            enviarOrdenes.Click += new EventHandler(enviar_Pedido);
            txtMesaOrden.KeyPress += new KeyPressEventHandler(noTexto);
            cancelarOrdenes.Click += new EventHandler(cancelar_Pedido);
        }

        private void crear_FomularioMesa(object sender, System.EventArgs e)
        {

            Form mesas = new Form();
            seleccion = lista.SelectedIndex+1;

            //Gerenrar mesa
            for (int i = 1; i < seleccion; i++)
            {
                boton[i] = new Button();
                boton[i].Width = 75;
                boton[i].Height = 23;
                boton[i].Text = String.Format("{0}", i);
                boton[i].Top = i * 40;

                boton[i].Enabled = false;
                mesas.Controls.Add(boton[i]);
            }

            //Otro controles de la mesa
            if (seleccion >= 1 && seleccion <= 9)
            {
                mesas.Size = new Size(563,473);
                mesas.Text = "Mesas";

                mesas.Controls.Add(txtMesaOrden);
                txtMesaOrden.Location = new System.Drawing.Point(270, 312);
                txtMesaOrden.Size = new Size(57,26);

                mesas.Controls.Add(btnSeleccionarMesa);
                btnSeleccionarMesa.Text = "Tomar orden";
                btnSeleccionarMesa.Location = new System.Drawing.Point(252, 381);
                mesas.Visible = true;
                btnSeleccionarMesa.Size=new Size(75,23);

                logica.ListaPersona(listaPersonas);
                mesas.Controls.Add(listaPersonas);
                listaPersonas.Location = new System.Drawing.Point(97, 51);
                listaPersonas.Size = new Size(378,238);

                mesas.Controls.Add(enviarOrdenes);
                enviarOrdenes.Location = new System.Drawing.Point(116, 381);
                enviarOrdenes.Visible = true;
                enviarOrdenes.Text = "Enviar ordenes";
                enviarOrdenes.Size = new Size(75,23);
                

                mesas.Controls.Add(cancelarOrdenes);
                cancelarOrdenes.Location = new System.Drawing.Point(400, 381);
                cancelarOrdenes.Visible = true;
                cancelarOrdenes.Text = "Cancelar";
                cancelarOrdenes.Size = new Size(75,23);

                mesas.Controls.Add(cantidadPersona);
                cantidadPersona.Location = new Point(94,9);
                cantidadPersona.Visible = true;
                cantidadPersona.Text = "Cantidad de personas";
                cantidadPersona.Font = new Font("Microsoft Sans serif",20);
                cantidadPersona.Size = new Size (279,31);

                mesas.Controls.Add(cantidadMesa);
                cantidadMesa.Location = new Point(93,312);
                cantidadMesa.Visible = true;
                cantidadMesa.Text = "Seleccionar mesa";
                cantidadMesa.Font = new Font("Microsoft Sans serif", 12);
                cantidadMesa.Size = new Size(235,20);

                mesas.Controls.Add(Detalle);
                Detalle.Location = new Point(400, 320);
                Detalle.Visible = true;
                Detalle.Text = "Detalle";
                Detalle.Size = new Size(75, 23);

                //siguientePedido.Text = "Siguiente Pedido";
                //mesas.Controls.Add(siguientePedido);


                this.Hide();
            }
            else
            {
                MessageBox.Show("Seleccionar un numero");
            }


        }

        private void crear_Pedido(object sender, System.EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "logicaPedidos").SingleOrDefault<Form>();
            
            if (String.IsNullOrEmpty(txtMesaOrden.Text) || String.IsNullOrEmpty(listaPersonas.Text))
            {
                MessageBox.Show("Elija una mesa y la cantidad de personas");
            }
            else
            {
                mesaEnUso = 0;
                mesaEnUso = int.Parse(txtMesaOrden.Text.ToString());
                numeroDePersonas = int.Parse(listaPersonas.Text.ToString());
                logica.EstadoMesa(boton[mesaEnUso]);
                continuar_Pedido(this,new EventArgs());
            }
             
        }

        private void continuar_Pedido(object sender, System.EventArgs e)
        {
            //pedido p1 = new pedido(nombreClientePedido.Text.ToString(),
            //                        platoEntrada.SelectedIndex.ToString(), 
            //                        platoFuerte.SelectedIndex.ToString(),
            //                        bebida.SelectedIndex.ToString(),
            //                        platoPostre.SelectedIndex.ToString());

            //todosPedidos.Add(p1);
            if (contadorPedido < numeroDePersonas)
            {

                Button siguientePedido = new Button();
                siguientePedido.Click += new EventHandler(continuar_Pedido);
                siguientePedido.Text = "Siguiente";
                siguientePedido.Visible = true;
                siguientePedido.Location = new Point(723, 366);
                siguientePedido.Size = new Size(88,34);
                pedidos.Controls.Add(siguientePedido);

                logicaPedidos.nuevoPedido().Controls.Add(siguientePedido);
            }
            
             if (contadorPedido == numeroDePersonas)
             {

                    Button finalizar = new Button();
                    finalizar.Click += new EventHandler(finalizar_Orden);
                    finalizar.Text = "Finalizar";
                    finalizar.Visible = true;
                    finalizar.Location = new Point(723, 366);
                    finalizar.Size = new Size(88, 34);
                    logicaPedidos.nuevoPedido().Controls.Add(finalizar);
             }
            contadorPedido++;
        }

        private void finalizar_Orden(object sender, System.EventArgs e)
        {
            btnSeleccionarMesa.Enabled = true;
            this.Close();
            crear_FomularioMesa(this, new EventArgs());
            
        }

        private void enviar_Pedido(object sender, System.EventArgs e)
        {
            MesaLogica mm = new MesaLogica();
            Color cc = new Color();
            cc = Color.Green;
            mm.Estados(boton,cc);
            contadorPedido = 1;
        }

        private void cancelar_Pedido(object sender, System.EventArgs e)
        {
            MesaLogica mm = new MesaLogica();
            Color cc = new Color();
            cc = Color.Green;

            mm.Estados(boton,cc);
            contadorPedido = 1;
        }

        private void noTexto(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
