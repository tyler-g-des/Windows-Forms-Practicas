using SistemaDeBlog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDeBasesDatos
{
    public class usuarioNL
    {
        public usuario GuardarUsuario(String user, String apellido, String correo,  String nombreUsuario, String pass)
        {
            try
            {
                return Conexion.getInstance().GuardarUsuario(user, apellido, correo, nombreUsuario, pass);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        public void CargarData(DataGridView dgv, String usuario)
        {
            try
            {
                Conexion.getInstance().cargarPublicacion(dgv, usuario);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        public publicacion CargarDataPublicacion(String titulo)
        {

            publicacion pu;
            try
            {
               pu =  Conexion.getInstance().cargarPublicacion(titulo);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

            return pu;
        }

        public void borrarPublicacion(String titulo)
        {
            try
            {
                Conexion.getInstance().borrarPublicacion(titulo);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        public void updatePublicacion(String titulo,String contenido,String cambiar, String usuario)
        {
            try
            {
                Conexion.getInstance().editarPublicacion(titulo,contenido,cambiar,usuario);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        public void guardarPublicacion(String titulo, String contenido, String fecha, String usuario)
        {
            try
            {
                Conexion.getInstance().guardarPublicacion(titulo, contenido, fecha, usuario);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }
    } 
}
