using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Logica
{
    [Serializable]
    public class contactos
    {
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String direccion { get; set; }
        public String telefonoPersonal { get; set; }
        public String usuarioDelContacto { get; set; }


        public contactos(String nombre, String apellido, String direccion , String telefonoPersonal, String usuarioDelcotacto)
        {

            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefonoPersonal = telefonoPersonal;
            this.usuarioDelContacto = usuarioDelcotacto;
        }



    }
}
