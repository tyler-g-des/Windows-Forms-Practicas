using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Permissions;

namespace Logica
{
    public class CRUDCONTACTOS
    {

        public void crearDirectorio(String nombre,contactos contacto)
        {

            if (File.Exists("Datos\\contacto\\"+nombre) == false)
            {
                try
                {

                    GuardarContactos("Datos\\contacto\\"+nombre,nombre,contacto);
                }
                catch(Exception )
                {
                    MessageBox.Show("Error al crear Directorio para el contacto");
                }
            }
            else
            {
                MessageBox.Show("El usuario existe" );
            }


        }

        public void GuardarContactos(String ruta, String nombre, contactos contacto)
        {
            try {

                     
                    Stream st = File.Create(ruta);

                    var binfor = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    binfor.Serialize(st, contacto);

                    MessageBox.Show("REGISTRADO");
                
            }
            catch(Exception x)
            {
                MessageBox.Show("El usuario existe");
            }



        }
    }
}
