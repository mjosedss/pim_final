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
    public partial class carteiraVirtual : System.Web.UI.Page
    {

        Class1 resultado35 = new Class1();
        //variavel global
        double saldoatual;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Pega Id usuario
            string resultado2 = Session["teste"].ToString();
            Session["teste"] = resultado2;
            //conectar base de dados
            string connStr = "data source = LocalHost; database = Pim4final; integrated security = SSPI;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            // criar comando para 
            SqlCommand cmd = new SqlCommand("SELECT CONSULTACARTEIRA.CSC_DOU_VALOR, OPERACOESCARTEIRA.OPC_STR_PENDENTE, OPERACOESCARTEIRA.OPC_DOU_VALOR, OPERACOESCARTEIRA.OPE_INT_ID, OPERACOESCARTEIRA.OPC_DAT_Data, OPERACOESCARTEIRA.CLI_INT_ID," +
            " OPERACOES.OPE_INT_ID, OPERACOES.OPE_STR_TIPO, COTACAO.COT_STR_VALOR FROM CONSULTACARTEIRA, OPERACOESCARTEIRA, OPERACOES, COTACAO WHERE CONSULTACARTEIRA.CLI_INT_ID = '" + resultado2 + "' AND OPERACOESCARTEIRA.CLI_INT_ID = '" + resultado2 + "'" +
            "AND OPERACOESCARTEIRA.OPE_INT_ID = OPERACOES.OPE_INT_ID AND OPERACOESCARTEIRA.OPC_STR_PENDENTE = 'nao'; ");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            string valor2 = "";
            double Saldo;
            string extrato = "";
            string cotacao = "";
            string valor = "";
            //variavel para loop
            int n = 1;
            //leitura base de dados
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //resultado = reader.GetInt32(0);

                extrato += "Operação: " + reader["OPE_STR_TIPO"].ToString() + " - Valor: " + reader["OPC_DOU_VALOR"].ToString() + " Bitcoins " + " - Data: " + reader["OPC_DAT_Data"].ToString() + "</br>";
                //parar o loop com condição
                if (n != 0)
                {
                    valor += "Saldo: " + reader["CSC_DOU_VALOR"].ToString() + " Bitcoins ";
                    cotacao += "Cotação do dia: 1 BitCoin = R$ " + reader["COT_STR_VALOR"].ToString();
                    valor2 = reader["CSC_DOU_VALOR"].ToString();
                }
                //Atribui novo valor a variavel que condiciona loop
                n = n * 0;

            }
            //Imprime dados em tela
            conn.Close();
            Saldo = Convert.ToDouble(valor2);
            saldoatual = Saldo;
            operacoes.Text = extrato;
            saldo.Text = valor;
            cotacao1.Text = cotacao;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //redireciona
            Response.Redirect("~/segundaTela.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //Executa alteracoes em tela
            textooperacoes.Text = "Depósito";
            valor.Visible = true;
            Executar.Visible = true;

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            textooperacoes.Text = "Saque";
            valor.Visible = true;
            Executar.Visible = true;

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            textooperacoes.Text = "Compra";
            valor.Visible = true;
            Executar.Visible = true;

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            textooperacoes.Text = "Venda";
            valor.Visible = true;
            Executar.Visible = true;

        }

        protected void Executar_Click(object sender, EventArgs e)
        {
            //Variaveis utilizadas no processo
            double Entrada;
            int oper = 0;
            //Atribui novo valor a variavel oper
            if (textooperacoes.Text == "Venda")
            {
                oper = 4;
            }
            else if (textooperacoes.Text == "Compra")
            {
                oper = 3;
            }
            else if (textooperacoes.Text == "Saque")
            {
                oper = 1;
            }
            else if (textooperacoes.Text == "Depósito")
            {
                oper = 2;
            }
            int setor = 5;
            //pegar data do sistema
            string strFormato = string.Empty;
            strFormato = DateTime.Now.Date.ToString("yyyy-MM-dd");
            //Variaveis utilizadas no processo de controle do banco
            string pendente = "sim";
            //pegar ID do cliente
            string resultado2 = Session["teste"].ToString();
            Session["teste"] = resultado2;

            //Conexao com o banco, para inserir dados
            SqlConnection conn = new SqlConnection("data source = LocalHost; database = Pim4final; integrated security = SSPI;");
            conn.Open();
            string sql = "INSERT INTO OPERACOESCARTEIRA (OPC_DOU_VALOR, CLI_INT_ID, OPC_STR_PENDENTE, OPE_INT_ID, OPC_DAT_Data, SET_INT_ID) VALUES (@valoroperacao, @resultado, @pendente, @operacaoefetuada, @data, @setor1)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@setor1", setor);
            cmd.Parameters.AddWithValue("@valoroperacao", valor.Text);
            cmd.Parameters.AddWithValue("@resultado", resultado2);
            cmd.Parameters.AddWithValue("@pendente", pendente);
            cmd.Parameters.AddWithValue("@operacaoefetuada", oper);
            cmd.Parameters.AddWithValue("@data", strFormato);
            

            //Condição
            if (valor.Text != "")
                
            {
                //Condição
                Entrada = Convert.ToDouble(valor.Text);
                if (saldoatual > Entrada && oper == 1 || saldoatual > Entrada && oper == 4 || oper == 2 || oper == 3)
                {
                    cmd.ExecuteNonQuery();

                    valor.Text = (" ");
                    valor.Visible = false;
                    Executar.Visible = false;
                    Confirmacao.Text = "  Sua solitação foi encaminhada com sucesso!";
                    conn.Close();
                }
                //Condição não satisfeita
                else
                {
                    Confirmacao.Text = "  Saldo insuficiente!";
                    valor.Text = (" ");

                    Executar.Visible = false;
                    conn.Close();
                }
            }
            //Condição não satisfeita
            else {
                Confirmacao.Text = "  Favor preencha o campo com o valor";
            }
        }

    }
}