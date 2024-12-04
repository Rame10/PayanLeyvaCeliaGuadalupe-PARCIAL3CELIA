using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoFinal_Biblioteca.Clases
{
    public class Libros
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public int id,idAutor,idGenero,idEditorial,idCategoria;
        public string Titulo, ISBN;

        public Libros()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into LIBRO (id, Titulo, ISBN, idAutor, idGenero, idEditorial,idCategoria) values ({id}, '{Titulo}', '{ISBN}', {idAutor}, {idGenero}, {idEditorial}, {idCategoria})";
                con.Open();
                SqlCommand cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();
                msj = "REGISTRO EXITOSO";
            }
            catch
            {
                msj = $"ERROR!!";
            }
            return msj;
        }
        public string Actualizar()
        {
            string msj = "";
            string consulta = $"update LIBRO set Titulo = '{Titulo}', ISBN = '{ISBN}', idAutor = {idAutor}, idGenero = {idGenero}, idEditorial = {idEditorial}, idCategoria = {idCategoria} where id={id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "SE ACTUALIZARON LOS CAMBIOS";
            return msj;
        }
        public string Eliminar()
        {
            string msj = "";
            string consulta = $"delete from LIBRO where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "SE ELIMINÓ EL REGISTRO";
            return msj;
        }
    }
}
