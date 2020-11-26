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
    public partial class Atendimento : Form
    {
        string opcaoBusca;
        int clienteId;
        private string _strConn = @"data source = LocalHost; database = Pim4final; integrated security = SSPI;";
        SqlCommand objCommand = null;
        SqlConnection objConnect = null;
        public Atendimento()
        {
            InitializeComponent();
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            valor.Visible = false;
            valortexto.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BuscaCliente buscacliente = new BuscaCliente();
            buscacliente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            encaminha.Visible = true;
            finaliza.Visible = true;
            string strSql = "select CTT_INT_ID, CLI_INT_ID, CTT_DAT_DATA FROM CTTCONOSCO WHERE SET_INT_ID = 3 and CTT_STR_PENDENTE = 'sim'";
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
                opcaoBusca = "1";
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
            SqlCommand cmd2 = new SqlCommand("select CTTCONOSCO.CTT_INT_ID, CTTCONOSCO.CTT_STR_DESC, CLIENTE.CLI_INT_ID, CLIENTE.CLI_STR_NOME_RZSOCIAL, CLIENTE.CLI_STR_CPF_CNPJ, CLIENTE.CLI_STR_TELEFONE_FIXO, CLIENTE.CLI_STR_TELEFONE_CELULAR FROM CTTCONOSCO, CLIENTE " +
          "WHERE CTTCONOSCO.CTT_INT_ID = '" + numeroOS.Text + "' and CTTCONOSCO.CTT_STR_PENDENTE = 'sim' and CLIENTE.CLI_INT_ID = CTTCONOSCO.CLI_INT_ID");
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.Connection = conn;
            string retornoNomeRZ = "";
            string retornoCPFCNPJ = "";
            string retornoTELFIXO = "";
            string retornoTELCEL = "";
            string retornoDESC = "";
        
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
            conn.Close();
            nomeRZ.Text = retornoNomeRZ;
            telCel.Text = retornoTELCEL;
            telFix.Text = retornoTELFIXO;
            desc.Text = retornoDESC;
            cpfcnpj.Text = retornoCPFCNPJ;
          

        }

        private void finaliza_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();
            string sql1 = "UPDATE CTTCONOSCO SET CTT_STR_DESC = '" + desc.Text + "', CTT_STR_RESOLUCAO = '" + resol.Text + "', CTT_STR_PENDENTE = 'nao' where CTT_INT_ID = '" + numeroOS.Text + "' ";
            SqlCommand cmd2 = new SqlCommand(sql1, conn);
            cmd2.ExecuteNonQuery();
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

        private void encaminha_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();
            string sql1 = "UPDATE CTTCONOSCO SET SET_INT_ID = '5', CTT_STR_DESC = '" + desc.Text + "', CTT_STR_RESOLUCAO = '" + resol.Text + "' where CTT_INT_ID = '" + numeroOS.Text + "' ";
            SqlCommand cmd2 = new SqlCommand(sql1, conn);
            cmd2.ExecuteNonQuery();
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

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            button1.Visible = false;
            valor.Visible = true;
            valortexto.Visible = true;

            button4.Visible = true;
            cpfcnpj.Text = "Entre com o CPF/CNPJ do cliente, para efetuar a busca";
            label7.Text = "Insira o Cpf/Cnpj, para efetuar a busca.";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int setor = 5;
            int oper = 0;
            string pendente = "sim";
            string strFormato = string.Empty;
            strFormato = DateTime.Now.Date.ToString("yyyy-MM-dd");
            
            string valorOper = "";
            string valorSaldo = "";
            string IdCliente = "";
            double Entrada;
            double Saldo = 0;

            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();

            SqlCommand cmd30 = new SqlCommand("select * FROM CONSULTACARTEIRA WHERE CLI_INT_ID = '"+ clienteidd.Text +"'");
            cmd30.CommandType = System.Data.CommandType.Text;
            cmd30.Connection = conn;

            SqlDataReader reader = cmd30.ExecuteReader();

            if (reader.Read())
            {
               
                valorSaldo = reader["CSC_DOU_VALOR"].ToString();
                IdCliente = reader["CLI_INT_ID"].ToString();
           
            }
            else
            {
                MessageBox.Show("Erro");
            }

           
            valorOper = valor.Text;
            Saldo = Double.Parse(valorSaldo);
            Entrada = Double.Parse(valorOper);
            conn.Close();
            
            
            conn.Open();
            string sql = "INSERT INTO PROTECAODEATIVOS (CLI_INT_ID, PTA_STR_DESC, PTA_DAT_DATA, OPE_INT_ID, PTA_STR_PENDENTE, SET_INT_ID)" +
            "VALUES (@Cli, @Desc, @Data , @Oper, @Pen, @Setor)";

            string sql1 = "INSERT INTO CONTRATOSINTELIGENTES (CLI_INT_ID, CTI_STR_DESC, CTI_DAT_DATA, OPE_INT_ID, CTI_STR_PENDENTE, SET_INT_ID)" +
            "VALUES (@Cli, @Desc, @Data , @Oper, @Pen, @Setor)";

            string sql2 = "INSERT INTO CTTCONOSCO (CLI_INT_ID, CTT_STR_DESC, CTT_DAT_DATA, CTT_STR_PENDENTE, SET_INT_ID)" +
       "VALUES (@Cli, @Desc, @Data , @Pen, @Setor)";

            string sql3 = "INSERT INTO OPERACOESCARTEIRA (CLI_INT_ID, OPC_DOU_VALOR, OPC_DAT_DATA, OPE_INT_ID, OPC_STR_PENDENTE, SET_INT_ID)" +
       "VALUES (@Cli, @Desc, @Data , @Oper, @Pen, @Setor)";

            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlCommand cmd2 = new SqlCommand(sql1, conn);
            SqlCommand cmd3 = new SqlCommand(sql2, conn);
            SqlCommand cmd4 = new SqlCommand(sql3, conn);

            if (radioButton1.Checked)
            {
              oper = 5;
                cmd1.Parameters.AddWithValue("@Cli", clienteId);
                cmd1.Parameters.AddWithValue("@Desc", desc.Text);
                cmd1.Parameters.AddWithValue("@Data", strFormato);
                cmd1.Parameters.AddWithValue("@Oper", oper);
                cmd1.Parameters.AddWithValue("@Pen", pendente);
                cmd1.Parameters.AddWithValue("@Setor", setor);
                cmd1.ExecuteNonQuery();
            }

            if (radioButton2.Checked)
            {
                oper = 6;
                cmd2.Parameters.AddWithValue("@Cli", clienteId);
                cmd2.Parameters.AddWithValue("@Desc", desc.Text);
                cmd2.Parameters.AddWithValue("@Data", strFormato);
                cmd2.Parameters.AddWithValue("@Oper", oper);
                cmd2.Parameters.AddWithValue("@Pen", pendente);
                cmd2.Parameters.AddWithValue("@Setor", setor);
          
                cmd2.ExecuteNonQuery();
            }

            if (radioButton4.Checked)
            {
                pendente = "nao";
                cmd3.Parameters.AddWithValue("@Cli", clienteId);
                cmd3.Parameters.AddWithValue("@Desc", desc.Text);
                cmd3.Parameters.AddWithValue("@Data", strFormato);
                cmd3.Parameters.AddWithValue("@Pen", pendente);
                cmd3.Parameters.AddWithValue("@Setor", setor);

                cmd3.ExecuteNonQuery();
            }

            if (radioButton3.Checked)
            {
                if (Saldo > Entrada)
                {
                    oper = 1;
                    cmd4.Parameters.AddWithValue("@Cli", clienteId);
                    cmd4.Parameters.AddWithValue("@Desc", valor.Text);
                    cmd4.Parameters.AddWithValue("@Data", strFormato);
                    cmd4.Parameters.AddWithValue("@Oper", oper);
                    cmd4.Parameters.AddWithValue("@Pen", pendente);
                    cmd4.Parameters.AddWithValue("@Setor", setor);

                    cmd4.ExecuteNonQuery();
                }
            }
            if (radioButton6.Checked)
            {

                oper = 3;
                cmd4.Parameters.AddWithValue("@Cli", clienteId);
                cmd4.Parameters.AddWithValue("@Desc", valor.Text);
                cmd4.Parameters.AddWithValue("@Data", strFormato);
                cmd4.Parameters.AddWithValue("@Oper", oper);
                cmd4.Parameters.AddWithValue("@Pen", pendente);
                cmd4.Parameters.AddWithValue("@Setor", setor);

                cmd4.ExecuteNonQuery();
            }
            if (radioButton5.Checked )
            {
                if (Saldo > Entrada)
                {
                    oper = 4;
                    cmd4.Parameters.AddWithValue("@Cli", clienteId);
                    cmd4.Parameters.AddWithValue("@Desc", valor.Text);
                    cmd4.Parameters.AddWithValue("@Data", strFormato);
                    cmd4.Parameters.AddWithValue("@Oper", oper);
                    cmd4.Parameters.AddWithValue("@Pen", pendente);
                    cmd4.Parameters.AddWithValue("@Setor", setor);

                    cmd4.ExecuteNonQuery();
                }
            }
            if (radioButton7.Checked)
            {

                oper = 2;
                cmd4.Parameters.AddWithValue("@Cli", clienteId);
                cmd4.Parameters.AddWithValue("@Desc", valor.Text);
                cmd4.Parameters.AddWithValue("@Data", strFormato);
                cmd4.Parameters.AddWithValue("@Oper", oper);
                cmd4.Parameters.AddWithValue("@Pen", pendente);
                cmd4.Parameters.AddWithValue("@Setor", setor);

                cmd4.ExecuteNonQuery();
            }
            if (Saldo < Entrada && radioButton5.Checked || Saldo < Entrada && radioButton3.Checked)
            {
                MessageBox.Show("Saldo Insuficiente!");

            }

            button3.Visible = false;
            button1.Visible = true;
           
            button3.Visible = false;
            nomeRZ.Text = ("");
            telCel.Text = ("");
            telFix.Text = ("");
            cpfcnpj.Text = ("");
            clienteidd.Text = ("");
            desc.Text = ("");
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            valor.Visible = false;
            valortexto.Visible = false;
            //estado.Text = ("");
            if (Saldo > Entrada)
            {
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            conn.Close();
            label7.Text = "CPF/CNPJ.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("select CLI_INT_ID, CLI_STR_NOME_RZSOCIAL, CLI_STR_CPF_CNPJ, CLI_STR_TELEFONE_FIXO, CLI_STR_TELEFONE_CELULAR FROM CLIENTE WHERE CLI_STR_CPF_CNPJ = '" + cpfcnpj.Text + "'");
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.Connection = conn;
            string retornoNomeRZ = "";
            string retornoCPFCNPJ = "";
            string retornoTELFIXO = "";
            string retornoTELCEL = "";
            string retornoCLIID = "";
            try
            {
                SqlDataReader reader = cmd2.ExecuteReader();

                if (reader.Read())
                {
                    retornoNomeRZ = reader["CLI_STR_NOME_RZSOCIAL"].ToString();
                    retornoCPFCNPJ = reader["CLI_STR_CPF_CNPJ"].ToString();
                    retornoTELCEL = reader["CLI_STR_TELEFONE_CELULAR"].ToString();
                    retornoTELFIXO = reader["CLI_STR_TELEFONE_FIXO"].ToString();
                    retornoCLIID = reader["CLI_INT_ID"].ToString();


                }
                else
                {
                    MessageBox.Show("Ordem de serviço não encontrada");
                }
                conn.Close();
                nomeRZ.Text = retornoNomeRZ;
                telCel.Text = retornoTELCEL;
                telFix.Text = retornoTELFIXO;
                cpfcnpj.Text = retornoCPFCNPJ;
                clienteidd.Text = retornoCLIID;
                clienteId = int.Parse(retornoCLIID);
                button3.Visible = true;
                button4.Visible = false;
            }
            catch
            {
                MessageBox.Show("Digite os dados corretamente!");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Historico historico = new Historico();

            historico.ShowDialog();

        }
    }
    }

