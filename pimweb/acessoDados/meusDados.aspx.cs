using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using pimwebId;

namespace acessoDados
{
    public partial class meusDados : System.Web.UI.Page
    {
        pimwebId.Class1 resultado = new pimwebId.Class1();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = "data source = DESKTOP-UJTBLAJ; database = Login; integrated security = SSPI;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            // criar comando
            SqlCommand cmd = new SqlCommand("SELECT [id],[Username],[Password] FROM[tbl_login]");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            string temp = "";

            //leitura base de daods
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //resultado = reader.GetInt32(0);
                temp += "<h1> Login </ h1 >";
                temp += reader["Username"].ToString();
                temp += "<br/>";
                temp += reader["Password"].ToString();
                temp += "<br/>";

                //temp += resultado.ToString();
                temp += "<br/>";

            }


            conn.Close();

            lbl_teste.Text = temp;
        }
    }
}