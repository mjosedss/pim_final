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
    public partial class Historico : Form
    {
        string opcaoBusca;

        private string _strConn = @"data source = LocalHost; database = Pim4final; integrated security = SSPI;";
        SqlCommand objCommand = null;
        SqlConnection objConnect = null;
        public Historico()
        {
            InitializeComponent();
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select PROTECAODEATIVOS.PTA_INT_ID, PROTECAODEATIVOS.PTA_STR_DESC, CLIENTE.CLI_STR_NOME_RZSOCIAL, CLIENTE.CLI_STR_CPF_CNPJ, CLIENTE.CLI_STR_TELEFONE_FIXO, CLIENTE.CLI_STR_TELEFONE_CELULAR FROM PROTECAODEATIVOS, CLIENTE " +
            "WHERE PROTECAODEATIVOS.PTA_INT_ID = '" + chaveBusca.Text + "' and CLIENTE.CLI_INT_ID = PROTECAODEATIVOS.CLI_INT_ID");

            SqlCommand cmd2 = new SqlCommand("select CTTCONOSCO.CTT_INT_ID, CTTCONOSCO.CTT_STR_DESC, CLIENTE.CLI_STR_NOME_RZSOCIAL, CLIENTE.CLI_STR_CPF_CNPJ, CLIENTE.CLI_STR_TELEFONE_FIXO, CLIENTE.CLI_STR_TELEFONE_CELULAR FROM CTTCONOSCO, CLIENTE " +
            "WHERE CTTCONOSCO.CTT_INT_ID = '" + chaveBusca.Text + "' and CLIENTE.CLI_INT_ID = CTTCONOSCO.CLI_INT_ID");

            SqlCommand cmd3 = new SqlCommand("select CONTRATOSINTELIGENTES.CTI_INT_ID, CONTRATOSINTELIGENTES.CTI_STR_DESC, CLIENTE.CLI_STR_NOME_RZSOCIAL, CLIENTE.CLI_STR_CPF_CNPJ, CLIENTE.CLI_STR_TELEFONE_FIXO, CLIENTE.CLI_STR_TELEFONE_CELULAR FROM CONTRATOSINTELIGENTES, CLIENTE " +
            "WHERE CONTRATOSINTELIGENTES.CTI_INT_ID = '" + chaveBusca.Text + "' and CLIENTE.CLI_INT_ID = CONTRATOSINTELIGENTES.CLI_INT_ID");

            SqlCommand cmd4 = new SqlCommand("select OPERACOESCARTEIRA.OPC_INT_ID, OPERACOESCARTEIRA.OPC_DOU_VALOR, CLIENTE.CLI_STR_NOME_RZSOCIAL, CLIENTE.CLI_STR_CPF_CNPJ, CLIENTE.CLI_STR_TELEFONE_FIXO, CLIENTE.CLI_STR_TELEFONE_CELULAR, OPERACOES.OPE_STR_TIPO FROM OPERACOESCARTEIRA, CLIENTE, OPERACOES " +
            "WHERE OPERACOESCARTEIRA.OPC_INT_ID = '" + chaveBusca.Text + "' and CLIENTE.CLI_INT_ID = OPERACOESCARTEIRA.CLI_INT_ID AND OPERACOES.OPE_INT_ID = OPERACOESCARTEIRA.OPE_INT_ID");

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strSql = "select CTI_INT_ID, CLI_INT_ID, CTI_DAT_DATA, CTI_STR_PENDENTE FROM CONTRATOSINTELIGENTES WHERE CLI_INT_ID = '" + textBox1.Text + "'";
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
                dgDados.Columns["CTI_STR_PENDENTE"].HeaderText = "Pendência";
                opcaoBusca = "3";
            }
            catch
            {
                MessageBox.Show("Cliente não localizado");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strSql = "select OPERACOESCARTEIRA.OPC_INT_ID, OPERACOESCARTEIRA.OPC_DOU_VALOR, OPERACOESCARTEIRA.CLI_INT_ID, OPERACOESCARTEIRA.OPC_DAT_DATA, OPERACOESCARTEIRA.OPC_STR_PENDENTE, OPERACOES.OPE_STR_TIPO FROM OPERACOESCARTEIRA, OPERACOES " +
               "WHERE CLI_INT_ID = '" + textBox1.Text + "' and OPERACOES.OPE_INT_ID = OPERACOESCARTEIRA.OPE_INT_ID";
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
                dgDados.Columns["OPC_STR_PENDENTE"].HeaderText = "Pendência";
                opcaoBusca = "4";
            }
            catch
            {
                MessageBox.Show("Cliente não localizado");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strSql = "select CTT_INT_ID, CLI_INT_ID, CTT_DAT_DATA, CTT_STR_PENDENTE FROM CTTCONOSCO WHERE CLI_INT_ID = '" + textBox1.Text + "'";
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
                dgDados.Columns["CTT_STR_PENDENTE"].HeaderText = "Pendência";
             
                opcaoBusca = "2";
            }
            catch
            {
                MessageBox.Show("Cliente não localizado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strSql = "select PTA_INT_ID, CLI_INT_ID, PTA_DAT_DATA, PTA_STR_PENDENTE FROM PROTECAODEATIVOS WHERE CLI_INT_ID = '" + textBox1.Text + "'";
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
                dgDados.Columns["PTA_STR_PENDENTE"].HeaderText = "Pendência";
                opcaoBusca = "1";

            }
            catch
            {
                MessageBox.Show("Cliente não localizado");
            }
        }

        private void Historico_Load(object sender, EventArgs e)
        {

        }
    }
}
