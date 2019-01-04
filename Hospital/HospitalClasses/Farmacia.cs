using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.HospitalClasses
{
    class Farmacia
    {
        public int Id_Farmacia { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; } //Cambiarlo a string cuando lo tome de la interfaz

        static string myconnstring = ConfigurationManager.ConnectionStrings["Connstrng"].ConnectionString;

        public DataTable SELECT()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Farmacia";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
