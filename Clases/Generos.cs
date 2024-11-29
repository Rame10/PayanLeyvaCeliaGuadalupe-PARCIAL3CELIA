using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Biblioteca.Clases
{
    public class Generos
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public int id;
        public string Nombre;
        public Generos() 
        {
            con.ConnectionString = x.Conexion;
        }
        public string Guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into GENERO (id, Nombre) values({id}, '{Nombre}')";
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
            string consulta = $"update GENERO set Nombre = '{Nombre}'  where id = '{id}'";
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
            string consulta = $"delete from GENERO where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "SE ELIMINÓ EL REGISTRO";
            return msj;
        }
    }
}
