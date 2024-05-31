using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_final_Ulises.CLASES
{
    internal class CAlumnos
    {
        public void mostrarAlumnos(DataGridView tablaAlumnos)
        {
            try
            {
                CConeccion objetoConexion = new CConeccion();

                string query = "select * from alumnos";
                tablaAlumnos.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaAlumnos.DataSource = dt;
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE MOSTRARON LOS DATOS DE LA BASE DE DATOS, ERROR:" + ex.ToString());
            }
        }


        public void GuardarAlumnos(TextBox nombres, TextBox apellido)
        {
            try
            {
                CConeccion objetoConexion = new CConeccion();
                string query = "insert into alumnos (nombres,apellido)" +
                    "values ('" + nombres.Text + "','" + apellido.Text + "');";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("SE GUARDÓ CORRECTAMENTE LOS REGISTROS");

                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE MOSTRARON LOS DATOS DE LA BASE DE DATOS, ERROR:" + ex.ToString());
            }
        }


        public void SeleecionarAlumnos(DataGridView tablaAlumnos, TextBox id , TextBox nombres, TextBox apellido)
        {
            try
            {
                id.Text = tablaAlumnos.CurrentRow.Cells[0].Value.ToString();
                nombres.Text = tablaAlumnos.CurrentRow.Cells[1].Value.ToString();
                apellido.Text = tablaAlumnos.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO SELECCIONAR LOS DATOS DE LA BASE DE DATOS, ERROR:" + ex.ToString());
            }
        }

        public void modificarAlumnos(TextBox id, TextBox nombres, TextBox apellido)
        {
            try
            {
                CConeccion objetoConexion = new CConeccion();
                string query = "update alumnos set nombres ='" +
                    nombres.Text + "', apellido='" + apellido.Text + "' where id = '" + id.Text + "';";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("SE MODIFICÓ CORRECTAMENTE LOS REGISTROS");

                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE ACTUALIZÓ LA BASE DE DATOS, ERROR:" + ex.ToString());
            }
        }
        public void eliminarAlumnos(TextBox id)
        {
            try
            {
                CConeccion objetoConexion = new CConeccion();
                string query = "delete from alumnos where id= '" + id.Text + "';";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("SE ELIMINÓ CORRECTAMENTE LOS DATOS");

                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE ACTUALIZÓ LA BASE DE DATOS, ERROR:" + ex.ToString());
            }
        }
    }
}
