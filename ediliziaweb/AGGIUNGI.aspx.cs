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
    public partial class AGGIUNGI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO dipendenti VALUES(@nome, @cognome, @indirizzo,@cf,@sposato,@figli,@mansione)";
                cmd.Parameters.AddWithValue("nome", NOME.Text);
                cmd.Parameters.AddWithValue("cognome", COGNOME.Text);
                cmd.Parameters.AddWithValue("indirizzo", INDIRIZZO.Text);
                cmd.Parameters.AddWithValue("cf", CF.Text);
                cmd.Parameters.AddWithValue("sposato", SPOSATO.Checked);
                cmd.Parameters.AddWithValue("figli", FIGLI.Text);
                cmd.Parameters.AddWithValue("mansione", MANSIONE.Text);

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