using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class LogicaPedidos : Form
    {
        public List<ListBox> cargaComida(ListBox entrada, ListBox platoFuerte, ListBox bebida, ListBox postre)
        {
            bebida.Items.Add("Cafe");
            bebida.Items.Add("Agua");
            bebida.Items.Add("Refresco");
            bebida.Items.Add("Jugo");
            bebida.Items.Add("Te");


            platoFuerte.Items.Add("Salmon en salsa de cilantro");
            platoFuerte.Items.Add("Pollo relleno con tocino");
            platoFuerte.Items.Add("Fajitas de pollo fáciles para cenar");
            platoFuerte.Items.Add("Chuleta con salasa de mostaza");
            platoFuerte.Items.Add("Filere de res con salasa de nuez");

            entrada.Items.Add("agua");
            entrada.Items.Add("Sopa de cebolla");
            entrada.Items.Add("Ensalada mixta");
            entrada.Items.Add("Berengena palmesana");
            entrada.Items.Add("Berengena palmesana");
            entrada.Items.Add("Crema de aullama");


            postre.Items.Add("bizcocho");
            postre.Items.Add("Pudin de pan");
            postre.Items.Add("Helado de bainilla");
            postre.Items.Add("Flan de leche");
            postre.Items.Add("coco al horno");


            List<ListBox> comidas = new List<ListBox>();

            comidas.Add(entrada);
            comidas.Add(platoFuerte);
            comidas.Add(bebida);
            comidas.Add(postre);

            return comidas; 
        }

        public Form nuevoPedido()
        {
            Form pedidos = new Form();
            pedidos.Size = new Size(904,475);
            pedidos.Show();

            //Nombre 
            Label nombreCliente = new Label();
            nombreCliente.Text = "nombre cliente";
           

            TextBox nombreClientePedido = new TextBox();
            nombreClientePedido.Visible = true;
            nombreClientePedido.Location = new Point(160, 371);
            nombreClientePedido.Size = new Size(241,20);
            pedidos.Controls.Add(nombreClientePedido);


            //Cerrar 
            Button cancelarPedido = new Button();
            cancelarPedido.Text = "Cancelar";
            cancelarPedido.Visible = true;
            cancelarPedido.Location = new Point(591, 366);
            cancelarPedido.Size = new Size(88, 34);
            pedidos.Controls.Add(cancelarPedido);

            // Comidas
            ListBox entrada = new ListBox();
            ListBox platoFuerte = new ListBox();
            ListBox bebida = new ListBox();
            ListBox postre = new ListBox();
            List<ListBox> comidas = new List<ListBox>();

            entrada.Location = new Point(86, 136);
            entrada.Size = new Size(120,186);

            platoFuerte.Size = new Size(124,186);
            platoFuerte.Location = new Point(277, 136);

            bebida.Location = new Point(481, 136);
            bebida.Size = new Size(120,186);

            postre.Size = new Size(120,186);
            postre.Location = new Point(691, 136);

            Label entradaLBL = new Label();
            pedidos.Controls.Add(entradaLBL);
            entradaLBL.Location = new Point(83, 98);
            entradaLBL.Visible = true;
            entradaLBL.Text = "Entrada";
            entradaLBL.Size = new Size(44, 36);

            Label platoFuerteLbl = new Label();
            pedidos.Controls.Add(platoFuerteLbl);
            platoFuerteLbl.Location = new Point(274,98);
            platoFuerteLbl.Visible = true;
            platoFuerteLbl.Text = "Plato fuerte";
            platoFuerteLbl.Size = new Size(66,15);

            Label bebidaLbl = new Label();
            pedidos.Controls.Add(bebidaLbl);
            bebidaLbl.Location = new Point(478, 98);
            bebidaLbl.Visible = true;
            bebidaLbl.Text = "Bebidas";
            bebidaLbl.Size = new Size(40,13);

            Label postreLbl = new Label();
            pedidos.Controls.Add(postreLbl);
            postreLbl.Location = new Point(688,98);
            postreLbl.Visible = true;
            postreLbl.Text = "Postre";
            postreLbl.Size = new Size(37,13);

            Label menuLbl = new Label();
            pedidos.Controls.Add(menuLbl);
            menuLbl.Location = new Point(351,9);
            menuLbl.Visible = true;
            menuLbl.Text = "Menu";
            menuLbl.Font = new Font("Microsoft Sans serif", 48);
            menuLbl.Size = new Size(193, 73);


            Label nombre = new Label();
            pedidos.Controls.Add(nombre);
            nombre.Location = new Point(99, 374);
            nombre.Visible = true;
            nombre.Text = "Nombre(s)";
            nombre.Size = new Size(55, 13);


            comidas = cargaComida(entrada,platoFuerte,bebida,postre);
 
                foreach (var comidaLista in comidas)
                {

                   pedidos.Controls.Add(comidaLista);
                  
                }        
            return pedidos;
        }
    }
}
