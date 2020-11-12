using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio.Mesas
{
    public class MesaLogica
    {

        public Control ListaPersona(ListBox lista)
        {
            for (int i = 1; i < 5; i++)
            {
                lista.Items.Add(i);
            }
            return lista;
        }

        public void EstadoMesa(Button btn)
        {
            if (btn is null) {
                MessageBox.Show("Mesa no hailitada");

            }
            else
            {
                btn.BackColor = System.Drawing.Color.Yellow;

            }
        }

        public void Estados(Button[] boton, Color color)
        {
            for (int i = 1; i <= boton.Length; i++)
            {
                if (boton[i] == null)
                {
                    i++;
                }
                else
                {
                    if (boton[i].BackColor == Color.Yellow)
                    {
                        boton[i].BackColor = color;
                    }
                }
            }

        }
    }
}
