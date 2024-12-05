using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Biblioteca.Clases
{
    public class Prestamo
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public Prestamo()
        {
            con.ConnectionString = x.Conexion;
        }

        //Maestro
        public int id, idBibliotecario, idCliente, Estado;
        public string FechaPrestamo, FechaDevolucion;

        //Detalle
        public int idDet, idLibro, Cantidad;

        public void Guardar()
        {
            string consulta = $"insert into PRESTAMO (id, idBibliotecario, idCliente, FechaPrestamo, FechaDevolucion, Estado) values({id},{idBibliotecario}, {idCliente}, '{FechaPrestamo}', '{FechaDevolucion}',{Estado})";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void GuardarDetalle()
        {
            string consulta = $"insert into PRESTAMO_DETALLE (id, idPrestamo,idLibro, Cantidad) values((select isnull(max(id)+1,1)from PRESTAMO_DETALLE), {id}, {idLibro}, {Cantidad})";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
