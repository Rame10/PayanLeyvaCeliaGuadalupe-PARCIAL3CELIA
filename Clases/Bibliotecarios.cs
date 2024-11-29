using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Biblioteca.Clases
{
    public class Bibliotecarios
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public int id, idDomicilio, Turno;
        public string Nombre, APaterno, AMaterno, FechaDeNacimiento, Telefono, Email, RFC, NSS;

        public Bibliotecarios()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into BIBLIOTECARIO (id, Nombre, APaterno, AMaterno, idDomicilio,FechaDeNacimiento, Telefono, Email, RFC, NSS, Turno) values({id},'{Nombre}', '{APaterno}', '{AMaterno}', {idDomicilio},'{FechaDeNacimiento}','{Telefono}','{Email}', '{RFC}', '{NSS}', {Turno})";
                con.Open();
                SqlCommand cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();
                msj = "REGISTRO EXITOSO";
            }
            catch(Exception e)
            {
                msj = $"ERROR!!  {e.ToString()}";
            }
            return msj;
        }
        public string Actualizar()
        {
            string msj = "";
            string consulta = $"update BIBLIOTECARIO set Nombre = '{Nombre}', APaterno = '{APaterno}', AMaterno = '{AMaterno}', idDomicilio = {idDomicilio}, FechaDeNacimiento = '{FechaDeNacimiento}', Telefono = '{Telefono}', Email = '{Email}', RFC = '{RFC}', NSS = '{NSS}', Turno = {Turno} where id={id}";
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
            string consulta = $"delete from BIBLIOTECARIO where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "SE ELIMINÓ EL REGISTRO";
            return msj;
        }
    }
}
