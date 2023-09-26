using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ediliziaweb
{
    public partial class aggiungiPagamenti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO pagamenti VALUES(@data,@importo,@stipendio,@IDdipendente)";
                cmd.Parameters.AddWithValue("data", Date.Text);
                cmd.Parameters.AddWithValue("importo", IMPORTO.Text);
                cmd.Parameters.AddWithValue("stipendio", Stipendio.Text);
                cmd.Parameters.AddWithValue("IDdipendente",IDDIP.Text);
               

                int inserimentoEffettuato = cmd.ExecuteNonQuery();


                if (inserimentoEffettuato > 0)
                {
                    Response.Write("Inserimento effettuato con successo");
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }



        }
    }
}
    
