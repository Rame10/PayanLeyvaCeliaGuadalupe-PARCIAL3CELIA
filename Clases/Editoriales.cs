using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Biblioteca.Clases
{
    public class Editoriales
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public int id;
        public string Nombre;
        public Editoriales()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into EDITORIAL (id, Nombre) values({id}, '{Nombre}')";
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
            string consulta = $"update EDITORIAL set Nombre = '{Nombre}'  where id = '{id}'";
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
            string consulta = $"delete from EDITORIAL where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "SE ELIMINÓ EL REGISTRO";
            return msj;
        }
    }
}
