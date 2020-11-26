using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using pimwebId;

namespace pimweb.produtosCliente
{
    public partial class protecaoDeAtivos : System.Web.UI.Page
    {
        Class1 resultado = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Pega Id do cliente
            string resultado3 = Session["teste"].ToString();
            Session["teste"] = resultado3;
            //conectar base de dados
            string connStr = "data source = lOCALHOST; database = Pim4final; integrated security = SSPI;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            // criar comando
            SqlCommand cmd = new SqlCommand("SELECT PROTECAODEATIVOS.PTA_STR_DESC, PROTECAODEATIVOS.PTA_STR_PENDENTE, PROTECAODEATIVOS.PTA_DAT_DATA, PROTECAODEATIVOS.OPE_INT_ID, PROTECAODEATIVOS.CLI_INT_ID, OPERACOES.OPE_INT_ID, OPERACOES.OPE_STR_TIPO " +
            "FROM PROTECAODEATIVOS, OPERACOES WHERE PROTECAODEATIVOS.CLI_INT_ID = '" + resultado3 + "' AND PROTECAODEATIVOS.OPE_INT_ID = OPERACOES.OPE_INT_ID AND PROTECAODEATIVOS.PTA_STR_PENDENTE = 'nao'; ");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            string temp = "";

            //leitura base de daods
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                

                temp += "Tipo: " + reader["OPE_STR_TIPO"].ToString() + " / Descrição: " + reader["PTA_STR_DESC"].ToString() + " / Data: " + reader["PTA_DAT_Data"].ToString() + "</br>";


            }

            conn.Close();
            //imprime dados em tela
            lbl_teste.Text = temp;
        }
        protected void solicitarlink_Click(object sender, EventArgs e)
        {
            //imprime dados em tela
            chamada.Text = "Explique em poucas palavras o tipo de contrato que deseja registrar.";
            solicitacaoctt.Visible = true;
            executar.Visible = true;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //redireciona
            Response.Redirect("~/segundaTela.aspx");
        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            //variaveis usadas para controle no banco
            int setor = 5;
            int oper = 5;
            //pega data do sistema
            string strFormato = string.Empty;
            strFormato = DateTime.Now.Date.ToString("yyyy-MM-dd");
            string pendente = "sim";
            //pega id do cliente 
            string resultado2 = Session["teste"].ToString();
            Session["teste"] = resultado2;

            // conecta no banco
            SqlConnection conn = new SqlConnection("data source = lOCALHOST; database = Pim4final; integrated security = SSPI;");
            conn.Open();
            string sql = "INSERT INTO PROTECAODEATIVOS (PTA_STR_DESC, CLI_INT_ID, PTA_STR_PENDENTE, OPE_INT_ID, PTA_DAT_Data, SET_INT_ID) VALUES (@descricao, @resultado, @pendente, @operacaoefetuada, @data, @setor1)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@setor1", setor);
            cmd.Parameters.AddWithValue("@descricao", solicitacaoctt.Text);
            cmd.Parameters.AddWithValue("@resultado", resultado2);
            cmd.Parameters.AddWithValue("@pendente", pendente);
            cmd.Parameters.AddWithValue("@operacaoefetuada", oper);
            cmd.Parameters.AddWithValue("@data", strFormato);

            //condicão
            if(solicitacaoctt.Text != "")
            {
                cmd.ExecuteNonQuery();

                solicitacaoctt.Text = (" ");
                chamada.Visible = false;
                solicitacaoctt.Visible = false;
                executar.Visible = false;
                retorno.Text = "  Sua solitação foi encaminhada com sucesso!";
                conn.Close();
                // condição não atendida
            }else

            {
                retorno.Text = "  Favor preencha o campo requisitado, para envio da solitação!";
            }
        }
    }
}