using SistemaDeBlog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDeBasesDatos
{
    public class Conexion
    {
        private static Conexion instancia = null;
        private Conexion() { }

        public static Conexion getInstance()
        {
            if (instancia == null)
            {
                instancia = new Conexion();
            }
            return instancia;
        }

        public SqlConnection ConexionBD()
        {
            SqlConnection conexion = new SqlConnection(" Data Source = DESKTOP-KJ1LQ8U\\SQLEXPRESS; Initial Catalog = blog; Integrated Security = True");
            return conexion;
        }

        //Usuario
        public usuario AccesoSistema(String user, String pass)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            usuario usuario = null;
            SqlDataReader sr = null;

            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spAccesoSistema", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmUser", user);
                cmd.Parameters.AddWithValue("@prmPass", pass);
                conexion.Open();

                sr = cmd.ExecuteReader();

                if (sr.Read())
                {
                    usuario = new usuario();
                    usuario.nombreUsuario = sr["nombreUsuario"].ToString();
                    usuario.clave = sr["clave"].ToString();

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

            return usuario;

        }

        public usuario GuardarUsuario(String user, String apellido,String correo, String nombreUsuario, String pass)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            usuario usuario = null;
            SqlDataReader sr = null;

            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spRegistrarUsuario", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmNombre", user);
                cmd.Parameters.AddWithValue("@prmApellido", apellido);
                cmd.Parameters.AddWithValue("@prmCorreo", correo);
                cmd.Parameters.AddWithValue("@prmUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@prmClave", pass);

                conexion.Open();

                sr = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

            return usuario;

        }


        // Publicacion 
        public void cargarPublicacion(DataGridView dgv, String usuario)
        {
            SqlConnection conexion = null;
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                conexion.Open();
                da = new SqlDataAdapter("select titulo from publicacion where usuario = '" + usuario + "'", conexion);
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar consultas " + ex.ToString());
            }
        }

        public publicacion cargarPublicacion(String titulo)
        {
            SqlConnection conexion = null;
            SqlDataReader sr = null;
            SqlCommand cmd = null;
            publicacion pu = null;


            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                conexion.Open();
                cmd = new SqlCommand("select * from publicacion where titulo = '" + titulo + "'", conexion);
                sr = cmd.ExecuteReader();

                if (sr.Read())
                {
                    pu = new publicacion();
                    pu.titulo = sr["titulo"].ToString();
                    pu.contenido = sr["contenido"].ToString();
                    pu.usuario = sr["usuario"].ToString();
                    pu.fecha = sr["fecharCreacion"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar consultas " + ex.ToString());
            }


            return pu;
        }

        public void borrarPublicacion(String titulo)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            SqlDataReader sr = null;

            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spEliminarPublicacion", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmTitulo", titulo);

                conexion.Open();

                sr = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        public void editarPublicacion(String titulo, String contenido, String editar,String usuario)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            SqlDataReader sr = null;

            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spEditarPublicacion", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmTitulo", titulo);
                cmd.Parameters.AddWithValue("@prmContenido", contenido);
                cmd.Parameters.AddWithValue("@prmEditar", editar);
                cmd.Parameters.AddWithValue("@prmUsuario", usuario);
                conexion.Open();

                sr = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        public void guardarPublicacion(String titulo, String contenido, String fecha, String usuario)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            SqlDataReader sr = null;

            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spRegistrarPublicidad", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmTitulo", titulo);
                cmd.Parameters.AddWithValue("@prmContenido", contenido);
                cmd.Parameters.AddWithValue("@prmFecha", fecha);
                cmd.Parameters.AddWithValue("@prmUsuario", usuario);
                conexion.Open();

                sr = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }
    }
}
