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
    public partial class Operacional : Form
    {
        string opcaoBusca;
        private string _strConn = @"data source = LocalHost; database = Pim4final; integrated security = SSPI;";
        SqlCommand objCommand = null;
        SqlConnection objConnect = null;
        public Operacional()
        {
            InitializeComponent();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BuscaCliente buscacliente = new BuscaCliente();
            buscacliente.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            finaliza.Visible = true;
            string strSql = "select CTT_INT_ID, CLI_INT_ID, CTT_DAT_DATA FROM CTTCONOSCO WHERE SET_INT_ID = 1 and CTT_STR_PENDENTE = 'sim'";
            objConnect = new SqlConnection(_strConn);
            objCommand = new SqlCommand(strSql, objConnect);

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
            catch
            {
                MessageBox.Show("Erro");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select PROTECAODEATIVOS.PTA_INT_ID, PROTECAODEATIVOS.PTA_STR_DESC, CLIENTE.CLI_STR_NOME_RZSOCIAL, CLIENTE.CLI_STR_CPF_CNPJ, CLIENTE.CLI_STR_TELEFONE_FIXO, CLIENTE.CLI_STR_TELEFONE_CELULAR FROM PROTECAODEATIVOS, CLIENTE " +
            "WHERE PROTECAODEATIVOS.PTA_INT_ID = '" + numeroOS.Text + "' and PROTECAODEATIVOS.PTA_STR_PENDENTE = 'sim' and CLIENTE.CLI_INT_ID = PROTECAODEATIVOS.CLI_INT_ID");

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
            string retornoNomeRZ = "";
            string retornoCPFCNPJ = "";
            string retornoTELFIXO = "";
            string retornoTELCEL = "";
            string retornoDESC = "";
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
            nomeRZ.Text = retornoNomeRZ;
            telCel.Text = retornoTELCEL;
            telFix.Text = retornoTELFIXO;
            desc.Text = retornoDESC;
            cpfcnpj.Text = retornoCPFCNPJ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            finaliza.Visible = true;
            string strSql = "select PTA_INT_ID, CLI_INT_ID, PTA_DAT_DATA FROM PROTECAODEATIVOS WHERE SET_INT_ID = 1 and PTA_STR_PENDENTE = 'sim'";
            objConnect = new SqlConnection(_strConn);
            objCommand = new SqlCommand(strSql, objConnect);

            try
            {
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
                MessageBox.Show("Erro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            finaliza.Visible = true;
            string strSql = "select CTI_INT_ID, CLI_INT_ID, CTI_DAT_DATA FROM CONTRATOSINTELIGENTES WHERE SET_INT_ID = 1 and CTI_STR_PENDENTE = 'sim'";
            objConnect = new SqlConnection(_strConn);
            objCommand = new SqlCommand(strSql, objConnect);

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
            catch
            {
                MessageBox.Show("Erro");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            finaliza.Visible = true;
            string strSql = "select OPERACOESCARTEIRA.OPC_INT_ID, OPERACOESCARTEIRA.OPC_DOU_VALOR, OPERACOESCARTEIRA.CLI_INT_ID, OPERACOESCARTEIRA.OPC_DAT_DATA, OPERACOES.OPE_STR_TIPO FROM OPERACOESCARTEIRA, OPERACOES " +
                "WHERE OPERACOESCARTEIRA.SET_INT_ID = 1 and OPERACOESCARTEIRA.OPC_STR_PENDENTE = 'sim' and OPERACOES.OPE_INT_ID = OPERACOESCARTEIRA.OPE_INT_ID";
            objConnect = new SqlConnection(_strConn);
            objCommand = new SqlCommand(strSql, objConnect);

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
            catch
            {
                MessageBox.Show("Erro");
            }
        }

        private void finaliza_Click(object sender, EventArgs e)
        {
            string Operacao = "";
            string valorOper = "";
            string valorSaldo = "";
            string IdCliente = "";
            double Entrada;
            double Saldo;
            
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();

            SqlCommand cmd30 = new SqlCommand("select OPERACOESCARTEIRA.OPC_DOU_VALOR, OPERACOESCARTEIRA.OPE_INT_ID, CONSULTACARTEIRA.CLI_INT_ID, CONSULTACARTEIRA.CSC_DOU_VALOR FROM OPERACOESCARTEIRA, CONSULTACARTEIRA WHERE OPERACOESCARTEIRA.OPC_INT_ID = '" + numeroOS.Text +"' AND CONSULTACARTEIRA.CLI_INT_ID = OPERACOESCARTEIRA.CLI_INT_ID");
            cmd30.CommandType = System.Data.CommandType.Text;
            cmd30.Connection = conn;

                SqlDataReader reader = cmd30.ExecuteReader();

                if (reader.Read())
                {
                    valorOper = reader["OPC_DOU_VALOR"].ToString();     
                    valorSaldo = reader["CSC_DOU_VALOR"].ToString();
                    IdCliente = reader["CLI_INT_ID"].ToString();
                    Operacao = reader["OPE_INT_ID"].ToString();
            }
                else
                {
                    MessageBox.Show("Erro");
                }


            Entrada = Double.Parse(valorOper);
            Saldo = Double.Parse(valorSaldo);
            if (Operacao == "1" || Operacao == "4")
            {

                Saldo = Saldo - Entrada;
            }
            if (Operacao == "2" || Operacao == "3")
            {
                Saldo = Entrada + Saldo;
            }
                conn.Close();
            conn.Open();
            string sql12 = "UPDATE CONSULTACARTEIRA SET CSC_DOU_VALOR = '" + Saldo + "' where CLI_INT_ID = '" + IdCliente + "' ";
            SqlCommand cmd12 = new SqlCommand(sql12, conn);
            cmd12.ExecuteNonQuery();
            conn.Close();
            conn.Open();

            string sql = "UPDATE PROTECAODEATIVOS SET PTA_STR_DESC = '" + desc.Text + "', PTA_STR_RESOLUCAO = '" + resol.Text + "', PTA_STR_PENDENTE = 'nao' where PTA_INT_ID = '" + numeroOS.Text + "' ";

            string sql1 = "UPDATE CTTCONOSCO SET CTT_STR_DESC = '" + desc.Text + "', CTT_STR_RESOLUCAO = '" + resol.Text + "', CTT_STR_PENDENTE = 'nao' where CTT_INT_ID = '" + numeroOS.Text + "' ";

            string sql2 = "UPDATE CONTRATOSINTELIGENTES SET CTI_STR_DESC = '" + desc.Text + "', CTI_STR_RESOLUCAO = '" + resol.Text + "', CTI_STR_PENDENTE = 'nao' where CTI_INT_ID = '" + numeroOS.Text + "' ";

            string sql3 = "UPDATE OPERACOESCARTEIRA SET OPC_STR_RESOLUCAO = '" + resol.Text + "', OPC_STR_PENDENTE = 'nao' where OPC_INT_ID = '" + numeroOS.Text + "' ";

            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlCommand cmd2 = new SqlCommand(sql1, conn);
            SqlCommand cmd3 = new SqlCommand(sql2, conn);
            SqlCommand cmd4 = new SqlCommand(sql3, conn);

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
            MessageBox.Show("O.S. finalizada com sucesso!");
            finaliza.Visible = false;
            conn.Close();
        }
    }
}
