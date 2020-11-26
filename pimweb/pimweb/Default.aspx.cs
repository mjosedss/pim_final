using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace pimweb
{

    public partial class Default : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnlogin_Click(object sender, EventArgs e)
        {// Variavel que guardará ID do Cliente
           int resultado1;
            
            //conectar base de dados
            string connStr = "data source = LocalHost; database = Pim4final; integrated security = SSPI;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
           //Conecta com o Baco, para averiguar dados solicitados
            SqlCommand cmd = new SqlCommand("select CLI_INT_ID from CLIENTE where CLI_STR_EMAIL ='" + txtusername.Text + "' and CLI_STR_SENHA = '" + txtpassword.Text + "';");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;



           //string temp = "";
            SqlDataReader reader = cmd.ExecuteReader();

            //Averigua dados e da prosseguimento ao processo
            if (reader.Read())
            {
  
               
                resultado1 = reader.GetInt32(0);
       
                Session["teste"] = resultado1;
                Session["User"] = txtusername.Text;
                
               Response.Redirect("~/segundaTela.aspx");
     
                
            }
            //Retorna informação sobre erro
            else
            {
                Erro.Text = "Senha e (ou) usuário incorretos!"+"</br>";
            }
            conn.Close();

          
    

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EsqueceuSenha.aspx");
        }
    }
}