using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Biblioteca.Clases
{
    public class Libros
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public int id,idAutor,idGenero,idEditorial,idCategoría;
        public string Titulo, ISBN;

        public Libros()
        {
            con.ConnectionString = x.Conexion;
        }


    }
}
