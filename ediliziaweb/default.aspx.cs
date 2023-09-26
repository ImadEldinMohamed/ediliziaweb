using ediliziaweb.classi;
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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


           if(!IsPostBack)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand("select * from dipendenti", conn);
                SqlDataReader sqlDataReader;
                conn.Open();

                List<Dipendenti> lista = new List<Dipendenti>();
                sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Dipendenti dipendente = new Dipendenti();
                    dipendente.IDdipendente = Convert.ToInt32(sqlDataReader["IDdipendente"]);
                    dipendente.Nome = sqlDataReader["nome"].ToString();
                    dipendente.Cognome = sqlDataReader["cognome"].ToString();
                    dipendente.Indirizzo = sqlDataReader["indirizzo"].ToString();
                    dipendente.Cf = sqlDataReader["cf"].ToString();
                    dipendente.Sposato = Convert.ToBoolean(sqlDataReader["sposato"]);
                    dipendente.Figli = Convert.ToInt16(sqlDataReader["figli"]);
                    dipendente.Mansione = sqlDataReader["mansione"].ToString();
                    lista.Add(dipendente);
                }

                GridView12.DataSource = lista;
                GridView12.DataBind();


                conn.Close();
            }



        }

        protected void pagamento_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            int IDdipendente = Convert.ToInt32(btn.CommandArgument);
            Response.Redirect($"aggiungiPagamenti.aspx?IdDipendente={IDdipendente}");
        }

      
    }
}