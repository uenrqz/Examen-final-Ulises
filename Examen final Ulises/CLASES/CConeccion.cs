using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Examen_final_Ulises.CLASES
{
    internal class CConeccion
    {
        MySqlConnection conex = new MySqlConnection();
        static string servidor = "localhost";
        static string db = "escuela";
        static string usuario = "root";
        static string password = "Telephono.98";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + db + ";";

        public MySqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                //MessageBox.Show("SE CONECTÓ A LA BASE DE DATOS");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE CONECTÓ A LA BASE DE DATOS, ERROR: " + ex.ToString());
            }
            return conex;
        }

        public void cerrarConexion()
        {
            if (conex != null && conex.State == System.Data.ConnectionState.Open)
            {
                conex.Close();
            }
        }
    }
}
