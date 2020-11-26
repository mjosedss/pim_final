using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using pimwebId;




namespace pimweb.acessoDados
{
    public partial class meusDados : System.Web.UI.Page
    {
        
        Class1 resultado35 = new Class1();

       

        
     

        protected void Page_Load(object sender, EventArgs e)
        {
            string resultado2 = Session["teste"].ToString();
            Session["teste"] = resultado2;
            //conectar base de dados
            string connStr = "data source = LocalHost; database = Pim4final; integrated security = SSPI;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            // criar comando de consulta no banco de dados
            
            SqlCommand cmd = new SqlCommand("SELECT CLIENTE.CLI_INT_ID, CLIENTE.CLI_STR_NOME_RZSOCIAL, CLIENTE.CLI_STR_NOME_FANTASIA, CLIENTE.CLI_STR_CPF_CNPJ, CLIENTE.CLI_STR_EMAIL, CLIENTE.CLI_STR_TELEFONE_CELULAR, " +
            "CLIENTE.CLI_STR_TELEFONE_FIXO, CLIENTE.CLI_STR_SITE, CLIENTE.CLI_STR_LOGRADOURO, CLIENTE.CLI_STR_NUMERO,CLIENTE.CLI_STR_SITE, CLIENTE.CLI_STR_BAIRRO, CLIENTE.CLI_STR_CEP, ESTADO.EST_STR_DESC, ESTADO.EST_STR_SIGLA FROM CLIENTE, ESTADO " +
            "WHERE CLIENTE.CLI_INT_ID = '" + resultado2 + "' AND ESTADO.EST_INT_ID = CLIENTE.EST_INT_ID; ");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            
            // variaveis que irão receber dadso do banco
            string Rzsocial = "";
            string NomeF = "";
            string Cpfcnpj = "";
            string Email = "";
            string Telefone = "";
            string Site = "";
            string Logradouro = "";
            string Bairro = "";
            string Cidade = "";
            string Cep = "";

            //leitura base de daods
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                // guardando dados em variaveis
                
                Rzsocial += reader["CLI_STR_NOME_RZSOCIAL"].ToString();
                NomeF += reader["CLI_STR_NOME_FANTASIA"].ToString();
                Cpfcnpj += reader["CLI_STR_CPF_CNPJ"].ToString();
                Email += reader["CLI_STR_EMAIL"].ToString();
                Telefone += reader["CLI_STR_TELEFONE_CELULAR"].ToString() + reader["CLI_STR_TELEFONE_FIXO"].ToString();
                Site += reader["CLI_STR_SITE"].ToString();
                Logradouro += reader["CLI_STR_LOGRADOURO"].ToString();
                Logradouro += ", ";
                Logradouro += reader["CLI_STR_NUMERO"].ToString();
                Bairro += reader["CLI_STR_BAIRRO"].ToString();
                Cidade += reader["EST_STR_DESC"].ToString();
                Cidade += " - ";
                Cidade += reader["EST_STR_SIGLA"].ToString();
                Cep += reader["CLI_STR_CEP"].ToString();



            }
           

            conn.Close();
            // imprimindo dados em tela
            RazaoSocial.Text = Rzsocial;
            NomeFantasia.Text = NomeF;
            CPFCNPJ.Text = Cpfcnpj;
            Email1.Text = Email;
            Telefone1.Text = Telefone;
            Site1.Text = Site;
            Logradouro1.Text = Logradouro;
            Bairro1.Text = Bairro;
            Cidade1.Text = Cidade;
            CEP1.Text = Cep;
        
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // redirecionamento
            Response.Redirect("~/segundaTela.aspx");
        }
    }
}