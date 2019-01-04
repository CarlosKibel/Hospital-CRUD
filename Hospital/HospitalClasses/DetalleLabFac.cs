using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.HospitalClasses
{
    class DetalleLabFac
    {
        public int Id_Detalle { get; set; }
        public string Descripcion { get; set; }
        public int Id_FacturaLab { get; set; }
        public int Precio { get; set; }
        public int Id_Laboratorio { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["Connstrng"].ConnectionString;

        public DataTable SELECT()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM DetalleLabFac";
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

