using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace pimweb
{
    public partial class EsqueceuSenha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void voltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            //Averiguação de confirmação de senha
            if (txtsenha.Text != Txtredsenha.Text || txtsenha.Text == "")
            {
                confereSenha.Text = "";
                confereSenha.Text = "Senhas não conferem";
                

            }
            else
            {   //Conexão com o Banco, para verificar requisitos solicitados
                string connStr = "data source = LocalHost; database = Pim4final; integrated security = SSPI;";
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT CLI_STR_NOME_RZSOCIAL FROM CLIENTE  WHERE CLI_STR_NOME_RZSOCIAL = '" + txtnomerz.Text + "' and CLI_STR_CPF_CNPJ =  '" + txtcpfcnpj.Text + "' and CLI_STR_EMAIL = '" + txtemail.Text + "';");
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;

                SqlDataReader reader = cmd.ExecuteReader();


                    if (reader.Read())
                    {
                        //Conexão para atualizar dados
                        conn.Close();
                        conn.Open();
                        string sql = "UPDATE CLIENTE SET CLI_STR_SENHA = '" + txtsenha.Text + "' WHERE CLI_STR_NOME_RZSOCIAL = '" + txtnomerz.Text + "' and CLI_STR_CPF_CNPJ =  '" + txtcpfcnpj.Text + "' and CLI_STR_EMAIL = '" + txtemail.Text + "'";

                        SqlCommand cmd1 = new SqlCommand(sql, conn);

                        cmd1.ExecuteNonQuery();
                        confereSenha.Text = "";
                        confereSenha.Text = "Sua senha foi alterada com sucesso!" + "</br>";
                    }
                    //Retorno de falha no processo 
                    else
                    {
                        confereSenha.Text = "";
                        confereSenha.Text = "Por favor, preencha todos os campos solicitados, corretamente!" + "</br>";
                    }
                }
       
               
            }
        }
    }
