using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Biblioteca.Clases
{
    public class Domicilios
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public int id, idColonia;
        public string Calle, CP, Referencias;

        public Domicilios()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into DOMICILIO (id, Calle, CP, Referencias, idColonia) values({id}, '{Calle}', '{CP}', '{Referencias}', {idColonia})";
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
            string consulta = $"update DOMICILIO set Calle = '{Calle}', CP = '{CP}', Referencias = '{Referencias}', idColonia = {idColonia} where id = '{id}'";
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
            string consulta = $"delete from DOMICILIO where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "SE ELIMINÓ EL REGISTRO";
            return msj;
        }
    }
}
