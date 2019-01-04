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
    class FacturaLab
    {
        public int Id_FacturaLab { get; set; }
        public DateTime Fecha { get; set; }
        public int CostoTotal { get; set; }
        public int RNC { get; set; }
        public int Id_Laboratorio { get; set; }
        public int Id_Analisis { get; set; }
        public int Id_Receta { get; set; }
        public int Id_Seguro_Medico { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["Connstrng"].ConnectionString;

        public DataTable SELECT()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM FacturaLab";
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

