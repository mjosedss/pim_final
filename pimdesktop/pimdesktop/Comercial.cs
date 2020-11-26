using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pimdesktop
{   
    
    public partial class Comercial : Form
    {
        //varivel global
        string opcaoBusca;
        int clienteId;
        //conexao banco
        private string _strConn = @"data source = LocalHost; database = Pim4final; integrated security = SSPI;";
        SqlCommand objCommand = null;
        SqlConnection objConnect = null;
        public Comercial()
        {
            InitializeComponent();
            //ordena itens visuais
            valor.Visible = false;
            valortexto.Visible = false;
            button8.Visible = false;
            button9.Visible = false;

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //ordena itens visuais
            encaminha.Visible = true;
            finaliza.Visible = true;
            //conecta com o banco
            string strSql = "select PTA_INT_ID, CLI_INT_ID, PTA_DAT_DATA FROM PROTECAODEATIVOS WHERE SET_INT_ID = 5 and PTA_STR_PENDENTE = 'sim'";
              objConnect = new SqlConnection(_strConn);
              objCommand = new SqlCommand(strSql, objConnect);

              try
              {
                //executa preenchimento de tabela
                  SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                  DataTable dtLista = new DataTable();
                  objAdp.Fill(dtLista);
                  dgDados.DataSource = dtLista;
                  dgDados.Columns["PTA_INT_ID"].HeaderText = "Nº da Ordem de Serviço";
                  dgDados.Columns["CLI_INT_ID"].HeaderText = "Código do cliente";
                  dgDados.Columns["PTA_DAT_DATA"].HeaderText = "Data da solicitação";
                opcaoBusca = "1";
                
            }
              catch
              {
                //Reporta Erro
                  MessageBox.Show("Erro Comercial/ProtecaodeAtivos");
              }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ordena itens visuais
            encaminha.Visible = true;
            finaliza.Visible = true;
            //conexao
            string strSql = "select CTT_INT_ID, CLI_INT_ID, CTT_DAT_DATA FROM CTTCONOSCO WHERE SET_INT_ID = 5 and CTT_STR_PENDENTE = 'sim'";
            objConnect = new SqlConnection(_strConn);
            objCommand = new SqlCommand(strSql, objConnect);

            //executa preenchimento de tabela
            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);
                dgDados.DataSource = dtLista;
                dgDados.Columns["CTT_INT_ID"].HeaderText = "Nº da Ordem de Serviço";
                dgDados.Columns["CLI_INT_ID"].HeaderText = "Código do cliente";
                dgDados.Columns["CTT_DAT_DATA"].HeaderText = "Data da solicitação";
                opcaoBusca = "2";
            }

            //Reporta Erro
            catch
            {
                MessageBox.Show("Erro/Comercial/CttConosco");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ordena itens visuais
            encaminha.Visible = true;
            finaliza.Visible = true;
            //conexao
            string strSql = "select CTI_INT_ID, CLI_INT_ID, CTI_DAT_DATA FROM CONTRATOSINTELIGENTES WHERE SET_INT_ID = 5 and CTI_STR_PENDENTE = 'sim'";
            objConnect = new SqlConnection(_strConn);
            objCommand = new SqlCommand(strSql, objConnect);

            //executa preenchimento de tabela
            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);
                dgDados.DataSource = dtLista;
                dgDados.Columns["CTI_INT_ID"].HeaderText = "Nº da Ordem de Serviço";
                dgDados.Columns["CLI_INT_ID"].HeaderText = "Código do cliente";
                dgDados.Columns["CTI_DAT_DATA"].HeaderText = "Data da solicitação";
                opcaoBusca = "3";
            }
            //Reporta erro
            catch
            {
                MessageBox.Show("Erro/Comercial/ContratosInteligentes");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ordena itens visuais
            encaminha.Visible = true;
            finaliza.Visible = true;
            //conexao
            string strSql = "select OPERACOESCARTEIRA.OPC_INT_ID, OPERACOESCARTEIRA.OPC_DOU_VALOR, OPERACOESCARTEIRA.CLI_INT_ID, OPERACOESCARTEIRA.OPC_DAT_DATA, OPERACOES.OPE_STR_TIPO FROM OPERACOESCARTEIRA, OPERACOES " +
                "WHERE OPERACOESCARTEIRA.SET_INT_ID = 5 and OPERACOESCARTEIRA.OPC_STR_PENDENTE = 'sim' and OPERACOES.OPE_INT_ID = OPERACOESCARTEIRA.OPE_INT_ID";
            objConnect = new SqlConnection(_strConn);
            objCommand = new SqlCommand(strSql, objConnect);

            //executa preenchimento de tabela
            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);
                dgDados.DataSource = dtLista;
                dgDados.Columns["OPC_INT_ID"].HeaderText = "Nº da Ordem de Serviço";
                dgDados.Columns["OPC_DOU_VALOR"].HeaderText = "Valor da operação";
                dgDados.Columns["CLI_INT_ID"].HeaderText = "Código do cliente";
                dgDados.Columns["OPC_DAT_DATA"].HeaderText = "Data da solicitação";
                dgDados.Columns["OPE_STR_TIPO"].HeaderText = "Tipo de operação";
                opcaoBusca = "4";
            }
            //reporta erro
            catch
            {
                MessageBox.Show("Erro/Comercial/OperacoesCarteira");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //CONEXAO BANCO DE DADOS
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select PROTECAODEATIVOS.PTA_INT_ID, PROTECAODEATIVOS.PTA_STR_DESC, CLIENTE.CLI_STR_NOME_RZSOCIAL, CLIENTE.CLI_STR_CPF_CNPJ, CLIENTE.CLI_STR_TELEFONE_FIXO, CLIENTE.CLI_STR_TELEFONE_CELULAR FROM PROTECAODEATIVOS, CLIENTE " +
            "WHERE PROTECAODEATIVOS.PTA_INT_ID = '"+ numeroOS.Text + "' and PROTECAODEATIVOS.PTA_STR_PENDENTE = 'sim' and CLIENTE.CLI_INT_ID = PROTECAODEATIVOS.CLI_INT_ID");

            SqlCommand cmd2 = new SqlCommand("select CTTCONOSCO.CTT_INT_ID, CTTCONOSCO.CTT_STR_DESC, CLIENTE.CLI_STR_NOME_RZSOCIAL, CLIENTE.CLI_STR_CPF_CNPJ, CLIENTE.CLI_STR_TELEFONE_FIXO, CLIENTE.CLI_STR_TELEFONE_CELULAR FROM CTTCONOSCO, CLIENTE " +
            "WHERE CTTCONOSCO.CTT_INT_ID = '" + numeroOS.Text + "' and CTTCONOSCO.CTT_STR_PENDENTE = 'sim' and CLIENTE.CLI_INT_ID = CTTCONOSCO.CLI_INT_ID");

            SqlCommand cmd3 = new SqlCommand("select CONTRATOSINTELIGENTES.CTI_INT_ID, CONTRATOSINTELIGENTES.CTI_STR_DESC, CLIENTE.CLI_STR_NOME_RZSOCIAL, CLIENTE.CLI_STR_CPF_CNPJ, CLIENTE.CLI_STR_TELEFONE_FIXO, CLIENTE.CLI_STR_TELEFONE_CELULAR FROM CONTRATOSINTELIGENTES, CLIENTE " +
            "WHERE CONTRATOSINTELIGENTES.CTI_INT_ID = '" + numeroOS.Text + "' and CONTRATOSINTELIGENTES.CTI_STR_PENDENTE = 'sim' and CLIENTE.CLI_INT_ID = CONTRATOSINTELIGENTES.CLI_INT_ID");

            SqlCommand cmd4 = new SqlCommand("select OPERACOESCARTEIRA.OPC_INT_ID, OPERACOESCARTEIRA.OPC_DOU_VALOR, CLIENTE.CLI_STR_NOME_RZSOCIAL, CLIENTE.CLI_STR_CPF_CNPJ, CLIENTE.CLI_STR_TELEFONE_FIXO, CLIENTE.CLI_STR_TELEFONE_CELULAR, OPERACOES.OPE_STR_TIPO FROM OPERACOESCARTEIRA, CLIENTE, OPERACOES " +
            "WHERE OPERACOESCARTEIRA.OPC_INT_ID = '" + numeroOS.Text + "' and OPERACOESCARTEIRA.OPC_STR_PENDENTE = 'sim' and CLIENTE.CLI_INT_ID = OPERACOESCARTEIRA.CLI_INT_ID AND OPERACOES.OPE_INT_ID = OPERACOESCARTEIRA.OPE_INT_ID");

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.Connection = conn;
            cmd3.CommandType = System.Data.CommandType.Text;
            cmd3.Connection = conn;
            cmd4.CommandType = System.Data.CommandType.Text;
            cmd4.Connection = conn;
            // variaveis que receberao dados do banco
            string retornoNomeRZ = "";
            string retornoCPFCNPJ = "";
            string retornoTELFIXO = "";
            string retornoTELCEL = "";
            string retornoDESC = "";
            //condicao com variavel referente a query que sera executada 
            if (opcaoBusca == "1")
            {
                SqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                    retornoNomeRZ = reader["CLI_STR_NOME_RZSOCIAL"].ToString();
                    retornoCPFCNPJ = reader["CLI_STR_CPF_CNPJ"].ToString();
                    retornoTELCEL = reader["CLI_STR_TELEFONE_CELULAR"].ToString();
                    retornoTELFIXO = reader["CLI_STR_TELEFONE_FIXO"].ToString();
                    retornoDESC = reader["PTA_STR_DESC"].ToString();

                }
                //Dados nao encontrados
                else
                {
                    MessageBox.Show("Ordem de serviço não encontrada");
                }
            }
            if (opcaoBusca == "2")
            {
                SqlDataReader reader = cmd2.ExecuteReader();

                if (reader.Read())
                {
                    retornoNomeRZ = reader["CLI_STR_NOME_RZSOCIAL"].ToString();
                    retornoCPFCNPJ = reader["CLI_STR_CPF_CNPJ"].ToString();
                    retornoTELCEL = reader["CLI_STR_TELEFONE_CELULAR"].ToString();
                    retornoTELFIXO = reader["CLI_STR_TELEFONE_FIXO"].ToString();
                    retornoDESC = reader["CTT_STR_DESC"].ToString();

                }
                else
                {
                    MessageBox.Show("Ordem de serviço não encontrada");
                }
            }
            if (opcaoBusca == "3")
            {
                SqlDataReader reader = cmd3.ExecuteReader();

                if (reader.Read())
                {
                    retornoNomeRZ = reader["CLI_STR_NOME_RZSOCIAL"].ToString();
                    retornoCPFCNPJ = reader["CLI_STR_CPF_CNPJ"].ToString();
                    retornoTELCEL = reader["CLI_STR_TELEFONE_CELULAR"].ToString();
                    retornoTELFIXO = reader["CLI_STR_TELEFONE_FIXO"].ToString();
                    retornoDESC = reader["CTI_STR_DESC"].ToString();

                }
                else
                {
                    MessageBox.Show("Ordem de serviço não encontrada");
                }
            }
            if (opcaoBusca == "4")
            {
                SqlDataReader reader = cmd4.ExecuteReader();

                if (reader.Read())
                {
                    retornoNomeRZ = reader["CLI_STR_NOME_RZSOCIAL"].ToString();
                    retornoCPFCNPJ = reader["CLI_STR_CPF_CNPJ"].ToString();
                    retornoTELCEL = reader["CLI_STR_TELEFONE_CELULAR"].ToString();
                    retornoTELFIXO = reader["CLI_STR_TELEFONE_FIXO"].ToString();
                    retornoDESC = "Valor= " + reader["OPC_DOU_vALOR"].ToString() + " Operação= " + reader["OPE_STR_TIPO"].ToString();

                }
                else
                {
                    MessageBox.Show("Ordem de serviço não encontrada");
                }
            }
            conn.Close();
            //imprime dados em tela
            nomeRZ.Text = retornoNomeRZ;
            telCel.Text = retornoTELCEL;
            telFix.Text = retornoTELFIXO;
            desc.Text = retornoDESC;
            cpfcnpj.Text = retornoCPFCNPJ;
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Conexao Banco de dados
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();
            
            string sql = "UPDATE PROTECAODEATIVOS SET PTA_STR_DESC = '" + desc.Text + "', PTA_STR_RESOLUCAO = '" + resol.Text + "', PTA_STR_PENDENTE = 'nao' where PTA_INT_ID = '" + numeroOS.Text + "' ";

            string sql1 = "UPDATE CTTCONOSCO SET CTT_STR_DESC = '" + desc.Text + "', CTT_STR_RESOLUCAO = '" + resol.Text + "', CTT_STR_PENDENTE = 'nao' where CTT_INT_ID = '" + numeroOS.Text + "' ";

            string sql2 = "UPDATE CONTRATOSINTELIGENTES SET CTI_STR_DESC = '" + desc.Text + "', CTI_STR_RESOLUCAO = '" + resol.Text + "', CTI_STR_PENDENTE = 'nao' where CTI_INT_ID = '" + numeroOS.Text + "' ";

            string sql3 = "UPDATE OPERACOESCARTEIRA SET OPC_STR_RESOLUCAO = '" + resol.Text + "', OPC_STR_PENDENTE = 'nao' where OPC_INT_ID = '" + numeroOS.Text + "' ";

            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlCommand cmd2 = new SqlCommand(sql1, conn);
            SqlCommand cmd3 = new SqlCommand(sql2, conn);
            SqlCommand cmd4 = new SqlCommand(sql3, conn);
            try
            {
                //Execucao de query, de acordo tipo de O.S. e condicao
                if (numeroOS.Text != "" && resol.Text != "")
                {
                    if (opcaoBusca == "1")
                    {
                        cmd1.ExecuteNonQuery();
                    }
                    if (opcaoBusca == "2")
                    {
                        cmd2.ExecuteNonQuery();
                    }
                    if (opcaoBusca == "3")
                    {
                        cmd3.ExecuteNonQuery();
                    }
                    if (opcaoBusca == "4")
                    {
                        cmd4.ExecuteNonQuery();
                    }
                    //Reseta valores
                    nomeRZ.Text = ("");
                    telCel.Text = ("");
                    telFix.Text = ("");
                    desc.Text = ("");
                    cpfcnpj.Text = ("");
                    resol.Text = ("");
                    //imprime em tela
                    MessageBox.Show("O.S. finalizada com sucesso!");
                    finaliza.Visible = false;
                    conn.Close();
                }
                //condicao nao atendida
                else
                {
                    MessageBox.Show("Verifique se os campos necessários estão devidamente preenchidos");
                }
            }
            catch
            {
                MessageBox.Show("Erro/Comercial/FinalizarO.S.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //conexao
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();

            string sql = "UPDATE PROTECAODEATIVOS SET SET_INT_ID = '1', PTA_STR_DESC = '" + desc.Text + "', PTA_STR_RESOLUCAO = '" + resol.Text + "' where PTA_INT_ID = '" + numeroOS.Text + "' ";

            string sql1 = "UPDATE CTTCONOSCO SET SET_INT_ID = '1', CTT_STR_DESC = '" + desc.Text + "', CTT_STR_RESOLUCAO = '" + resol.Text + "' where CTT_INT_ID = '" + numeroOS.Text + "' ";

            string sql2 = "UPDATE CONTRATOSINTELIGENTES SET SET_INT_ID = '1', CTI_STR_DESC = '" + desc.Text + "', CTI_STR_RESOLUCAO = '" + resol.Text + "' where CTI_INT_ID = '" + numeroOS.Text + "' ";

            string sql3 = "UPDATE OPERACOESCARTEIRA SET SET_INT_ID = '1', OPC_STR_RESOLUCAO = '" + resol.Text + "' where OPC_INT_ID = '" + numeroOS.Text + "' ";

            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlCommand cmd2 = new SqlCommand(sql1, conn);
            SqlCommand cmd3 = new SqlCommand(sql2, conn);
            SqlCommand cmd4 = new SqlCommand(sql3, conn);

            try
            {
                //condicao

                if (numeroOS.Text != "" && desc.Text != "")
                {
                    if (opcaoBusca == "1")
                    {
                        cmd1.ExecuteNonQuery();
                    }
                    if (opcaoBusca == "2")
                    {
                        cmd2.ExecuteNonQuery();
                    }
                    if (opcaoBusca == "3")
                    {
                        cmd3.ExecuteNonQuery();
                    }
                    if (opcaoBusca == "4")
                    {
                        cmd4.ExecuteNonQuery();
                    }
                    nomeRZ.Text = ("");
                    telCel.Text = ("");
                    telFix.Text = ("");
                    desc.Text = ("");
                    cpfcnpj.Text = ("");
                    resol.Text = ("");
                    MessageBox.Show("O.S. encaminhada com sucesso!");
                    encaminha.Visible = false;
                    conn.Close();
                }
                //condicao nao atendida
                else
                {
                    MessageBox.Show("Verifique se os campos necessários estão devidamente preenchidos");
                }
            }
            //identifar erro
            catch {
                MessageBox.Show("Erro/Comercial/EncaminharO.S.");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            BuscaCliente buscacliente = new BuscaCliente();
            buscacliente.button4.Visible = true;
            buscacliente.ShowDialog();
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //Organizar itens visuais em tela
            valor.Visible = true;
            valortexto.Visible = true;
            button7.Visible = false;
            button8.Visible = true;
            label7.Text = "Insira o Cpf/Cnpj, para efetuar a busca.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //conexao
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("select CLI_INT_ID, CLI_STR_NOME_RZSOCIAL, CLI_STR_CPF_CNPJ, CLI_STR_TELEFONE_FIXO, CLI_STR_TELEFONE_CELULAR FROM CLIENTE WHERE CLI_STR_CPF_CNPJ = '" + cpfcnpj.Text + "'");
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.Connection = conn;
            //variaveis q recebera informacoes do banco
            string retornoNomeRZ = "";
            string retornoCPFCNPJ = "";
            string retornoTELFIXO = "";
            string retornoTELCEL = "";
            string retornoCLIID = "";
            SqlDataReader reader = cmd2.ExecuteReader();
            int opcao = 0;
            //condicoes
            if(cpfcnpj.Text != "") 
            {

                if (reader.Read())
                {
                    retornoNomeRZ = reader["CLI_STR_NOME_RZSOCIAL"].ToString();
                    retornoCPFCNPJ = reader["CLI_STR_CPF_CNPJ"].ToString();
                    retornoTELCEL = reader["CLI_STR_TELEFONE_CELULAR"].ToString();
                    retornoTELFIXO = reader["CLI_STR_TELEFONE_FIXO"].ToString();
                    retornoCLIID = reader["CLI_INT_ID"].ToString();
                    clienteidd.Text = retornoCLIID;
  
                    conn.Close();
      
  
                    opcao = 1;
                    
                }
                
                //condicao nao alcancada
                else
                {
                    MessageBox.Show("Cliente não localizado");
                }
   

            }
            //tratar erro
            else
            {
                MessageBox.Show("Digite os dados corretamente!");
            }//confirmacao se cliente ja possui conta
            if(opcao == 1)
            {
                conn.Open();
                SqlCommand cmd3 = new SqlCommand("select CLI_INT_ID FROM CONSULTACARTEIRA WHERE CLI_INT_ID = '" + clienteidd.Text + "'");
                cmd3.CommandType = System.Data.CommandType.Text;
                cmd3.Connection = conn;
                SqlDataReader reader2 = cmd3.ExecuteReader();
                if (reader2.Read())
                {
                    MessageBox.Show("Cliente ja possui conta cadastrada");
                    conn.Close();
                }
                else
                {//reseta valores em tela
                    nomeRZ.Text = retornoNomeRZ;
                    telCel.Text = retornoTELCEL;
                    telFix.Text = retornoTELFIXO;
                    cpfcnpj.Text = retornoCPFCNPJ;
                    //
                    button8.Visible = false;
                    button9.Visible = true;
                    clienteId = int.Parse(clienteidd.Text);
                    conn.Close();
                }
                }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //variaveis de controle do banco
            int opcao =0;
            int setor = 5;
            int oper = 0;
            string pendente = "nao";
            // pega data do sistema
            string strFormato = string.Empty;
            strFormato = DateTime.Now.Date.ToString("yyyy-MM-dd");
            //variaveis para operacoes no codigo
            double Entrada;
            string valorEntrada = "";
            // conexao para insercao de dados no saldo
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();
            string sql = "INSERT INTO CONSULTACARTEIRA (CSC_DOU_VALOR, CLI_INT_ID) VALUES (@valor, @clienteId)";

            try
            {
                
                valorEntrada = valor.Text;
                Entrada = Double.Parse(valorEntrada);
                SqlCommand cmd1 = new SqlCommand(sql, conn);



                cmd1.Parameters.AddWithValue("@valor", Entrada);
                cmd1.Parameters.AddWithValue("@clienteId", clienteId);
                cmd1.ExecuteNonQuery();
            }
            catch
            {
                
                opcao = 1;
            }


            if (opcao == 0)
            {//insercao de dados da operacao deposito
                string sql33 = "INSERT INTO OPERACOESCARTEIRA (CLI_INT_ID, OPC_DOU_VALOR, OPC_DAT_DATA, OPE_INT_ID, OPC_STR_PENDENTE, SET_INT_ID)" +
           "VALUES (@Cli, @Desc, @Data , @Oper, @Pen, @Setor)";

                SqlCommand cmd11 = new SqlCommand(sql33, conn);
                oper = 2;
                cmd11.Parameters.AddWithValue("@Cli", clienteId);
                cmd11.Parameters.AddWithValue("@Desc", valor.Text);
                cmd11.Parameters.AddWithValue("@Data", strFormato);
                cmd11.Parameters.AddWithValue("@Oper", oper);
                cmd11.Parameters.AddWithValue("@Pen", pendente);
                cmd11.Parameters.AddWithValue("@Setor", setor);

                cmd11.ExecuteNonQuery();
                nomeRZ.Text = ("");
                telCel.Text = ("");
                telFix.Text = ("");
                desc.Text = ("");
                cpfcnpj.Text = ("");
                resol.Text = ("");
                label7.Text = "CPF/CNPJ.";
                conn.Close();
                MessageBox.Show("Dados inseridos com sucesso!");
                button9.Visible = false;
                button7.Visible = true;
                valor.Visible = false;
                valortexto.Visible = false;
            }
            else
            {
                MessageBox.Show("Preencha os dadso corretamente!");
            }
        
        }
    }
}
