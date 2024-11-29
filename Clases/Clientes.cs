using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Biblioteca.Clases
{
    public class Clientes
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public int id, idDomicilio;
        public string Nombre, APaterno, AMaterno, Telefono, Email, CURP;

        public Clientes()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into CLIENTE (id, Nombre, APaterno, AMaterno, idDomicilio, Telefono, Email, CURP) values({id},'{Nombre}', '{APaterno}', '{AMaterno}', {idDomicilio},'{Telefono}','{Email}','{CURP}')";
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
            string consulta = $"update CLIENTE set Nombre = '{Nombre}', APaterno = '{APaterno}', AMaterno = '{AMaterno}', Telefono = '{Telefono}', Email = '{Email}', CURP = '{CURP}', idDomicilio = {idDomicilio} where id={id}";
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
            string consulta = $"delete from CLIENTE where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "SE ELIMINÓ EL REGISTRO";
            return msj;
        }
    }
}
