using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Biblioteca.Clases
{
    public class Categorias
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public int id;
        public string Categoria;
        public Categorias()
        {
            con.ConnectionString = x.Conexion;
        }
        public string Guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into CATEGORIA (id, Categoria) values({id}, '{Categoria}')";
                con.Open();
                SqlCommand cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();
                msj = "REGISTRO EXITOSO";
            }
            catch
            {
                msj = "¡ERROR!";
            }
            return msj;
        }
        public string Actualizar()
        {
            string msj = "";
            string consulta = $"update CATEGORIA set Categoria = '{Categoria}'  where id = '{id}'";
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
            string consulta = $"delete from CATEGORIA where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "SE ELIMINÓ EL REGISTRO";
            return msj;
        }
    }
}
