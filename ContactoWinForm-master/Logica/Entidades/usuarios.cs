using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Entidades
{
    [Serializable]
    public class usuarios
    {

        public String nombre { get; set; }
        public String apellido { get; set; }
        public String nombreUsuario { get; set; }
        public String clave { get; set; }


        public usuarios(String nombre, String apellido, String nombreUsuario, String clave)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.clave = clave;
        }

        public void GuardarUsuario(String nombre)
        {
            try
            {

                if (!File.Exists("Datos\\usuario\\" + nombre))
                {

                    Stream st = File.Create("Datos\\usuario\\" + nombre);

                    var binfor = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    binfor.Serialize(st, this);

                    MessageBox.Show("REGISTRADO");
                }
                else
                {
                    MessageBox.Show("Este usuario ya exite");

                }

            }
            catch
            {
                MessageBox.Show("Este usuario no esta registrado");
            }
        }
        public int ValidarUsuario()
        {
            try
            {
                using (System.Windows.Forms.SaveFileDialog dialogo = new System.Windows.Forms.SaveFileDialog())
                {
                    if (dialogo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (Stream st = File.Open(dialogo.FileName, FileMode.Create))
                        {
                            var binfor = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                            contactos obj = (contactos)binfor.Deserialize(st);

                            

                                return 0;
                        }
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
