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
    public partial class BuscaCliente : Form
    {
        string recebeCodSigla = "";
        private string _strConn = @"data source = LocalHost; database = Pim4final; integrated security = SSPI;";
        SqlCommand objCommand = null;
        SqlConnection objConnect = null;
        public BuscaCliente()
        {
            InitializeComponent();
            comboBox1.Visible = false;
            button1.Visible = false;
            numeroCampo.Visible = false;
            numeroLabel.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void log_TextChanged(object sender, EventArgs e)
        {

        }

        private void busca_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select CLIENTE.CLI_INT_ID, CLIENTE.CLI_STR_NOME_RZSOCIAL, CLIENTE.CLI_STR_NOME_FANTASIA, CLIENTE.CLI_STR_CPF_CNPJ, CLIENTE.CLI_STR_TELEFONE_FIXO, CLIENTE.CLI_STR_TELEFONE_CELULAR, CLIENTE.CLI_STR_EMAIL, CLIENTE.CLI_STR_SITE, " +
           "CLIENTE.CLI_STR_LOGRADOURO, CLIENTE.CLI_STR_NUMERO, CLIENTE.CLI_STR_CEP, CLIENTE.CLI_STR_BAIRRO, CLIENTE.CLI_STR_COMP, ESTADO.EST_STR_DESC, EST_STR_SIGLA FROM CLIENTE, ESTADO WHERE CLIENTE.CLI_STR_CPF_CNPJ = '" + cpfcnpjbusca.Text + "' " +
           "and ESTADO.EST_INT_ID = CLIENTE.EST_INT_ID");


            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            string retornoNomeRZ = "";
            string retornoCI = "";
            string retornoTELFIXO = "";
            string retornoTELCEL = "";
            string retornoEmail = "";
            string retornoNF = "";
            string retornoSite = "";
            string retornoEnd = "";
            string retornoCEP = "";
            string retornoBairro = "";
            string retornoComp = "";
            string retornoEst = "";
            string retornoUF = "";

            SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    retornoNomeRZ = reader["CLI_STR_NOME_RZSOCIAL"].ToString();
                    retornoCI = reader["CLI_INT_ID"].ToString();
                    retornoTELCEL = reader["CLI_STR_TELEFONE_CELULAR"].ToString();
                    retornoTELFIXO = reader["CLI_STR_TELEFONE_FIXO"].ToString();
                    retornoEmail = reader["CLI_STR_EMAIL"].ToString();
                    retornoSite = reader["CLI_STR_SITE"].ToString();
                    retornoNF = reader["CLI_STR_NOME_FANTASIA"].ToString();
                    retornoEnd = reader["CLI_STR_LOGRADOURO"].ToString() + ", " + reader["CLI_STR_NUMERO"].ToString();
                    retornoCEP = reader["CLI_STR_CEP"].ToString();
                    retornoBairro = reader["CLI_STR_BAIRRO"].ToString();
                    retornoComp = reader["CLI_STR_COMP"].ToString();
                    retornoEst = reader["EST_STR_DESC"].ToString();
                    retornoUF = reader["EST_STR_SIGLA"].ToString();
            }
                else
                {
                    //MessageBox.Show("Cliente não encontrado");
                }
            nomerz.Text = retornoNomeRZ;
            clienteid.Text = retornoCI;
            telcel.Text = retornoTELCEL;
            telfixo.Text = retornoTELFIXO;
            email.Text = retornoEmail;
            site.Text = retornoSite;
            nomefantasia.Text = retornoNF;
            log.Text = retornoEnd;
            cep.Text = retornoCEP;
            bairro.Text = retornoBairro;
            comp.Text = retornoComp;
            estado.Text = retornoEst;
            UF.Text = retornoUF;

            conn.Close();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT EST_INT_ID FROM ESTADO where EST_STR_SIGLA = '" + comboBox1.Text + "' ");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            string codSigla = "";
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                codSigla = reader["EST_INT_ID"].ToString();

            }
            conn.Close();
            conn.Open();
            int clienteIdInt;
            clienteIdInt = int.Parse(clienteid.Text);
            string sql = "UPDATE CLIENTE SET EST_INT_ID = '" + codSigla + "', CLI_STR_NOME_FANTASIA= '" + nomefantasia.Text + "', CLI_STR_TELEFONE_FIXO = '" + telfixo.Text + "', CLI_STR_TELEFONE_CELULAR = '" + telcel.Text + "', CLI_STR_EMAIL = '" + email.Text + "', CLI_STR_SITE = '" + site.Text + "', " +
           "CLI_STR_LOGRADOURO = '" + log.Text + "', CLI_STR_NUMERO = '" + numeroCampo.Text + "', CLI_STR_CEP = '" + cep.Text + "',CLI_STR_BAIRRO = '" + bairro.Text + "', CLI_STR_COMP = '" + comp.Text + "'where CLI_INT_ID = '" + clienteIdInt + "'";
          


            SqlCommand cmd1 = new SqlCommand(sql, conn);
            cmd1.ExecuteNonQuery();
            comboBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
            numeroCampo.Visible = false;
            numeroLabel.Visible = false;
            MessageBox.Show("Alteração efetuada com sucesso!");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            button2.Visible = false;
            button1.Visible = true;
            numeroCampo.Visible = true;
            numeroLabel.Visible = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Senha = "12345";
            string strFormato = string.Empty;
            strFormato = DateTime.Now.Date.ToString("yyyy-MM-dd");
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT EST_INT_ID FROM ESTADO where EST_STR_SIGLA = '" + comboBox1.Text + "' ");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            string codSigla = "";
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                codSigla = reader["EST_INT_ID"].ToString();

            }
            conn.Close();
            conn.Open();
           
            string sql = "INSERT INTO ClIENTE (EST_INT_ID, CLI_STR_NOME_RZSOCIAL, CLI_STR_NOME_FANTASIA, CLI_STR_TELEFONE_FIXO, CLI_STR_TELEFONE_CELULAR, CLI_STR_EMAIL, CLI_STR_SITE, CLI_STR_LOGRADOURO, CLI_STR_NUMERO, CLI_STR_CEP, CLI_STR_BAIRRO, CLI_STR_COMP, CLI_STR_CPF_CNPJ, CLI_DAT_DATA, CLI_STR_SENHA) " +
            "VALUES (@EstadoId, @RZ , @NF, @TelFix, @TelCel, @Email, @Site, @End, @Num, @Cep, @Bairro, @Comp, @CpfCnpj, @Data, @Senha)";

            try
            {
                SqlCommand cmd1 = new SqlCommand(sql, conn);

                cmd1.Parameters.AddWithValue("@EstadoId", codSigla);
                cmd1.Parameters.AddWithValue("@RZ", nomerz.Text);
                cmd1.Parameters.AddWithValue("@NF", nomefantasia.Text);
                cmd1.Parameters.AddWithValue("@TelFix", telfixo.Text);
                cmd1.Parameters.AddWithValue("@TelCel", telcel.Text);
                cmd1.Parameters.AddWithValue("@Email", email.Text);
                cmd1.Parameters.AddWithValue("@Site", site.Text);
                cmd1.Parameters.AddWithValue("@End", log.Text);
                cmd1.Parameters.AddWithValue("@Num", numeroCampo.Text);
                cmd1.Parameters.AddWithValue("@Cep", cep.Text);
                cmd1.Parameters.AddWithValue("@Bairro", bairro.Text);
                cmd1.Parameters.AddWithValue("@Comp", comp.Text);
                cmd1.Parameters.AddWithValue("@CpfCnpj", cpfcnpjbusca.Text);
                cmd1.Parameters.AddWithValue("@Data", strFormato);
                cmd1.Parameters.AddWithValue("@Senha", Senha);
                cmd1.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Erro!");
            }

            button3.Visible = false;
            button4.Visible = true;
            comboBox1.Visible = false;
            numeroCampo.Visible = false;
            numeroLabel.Visible = false;
            nomerz.Text = ("");
            nomefantasia.Text = ("");
            telcel.Text = ("");
            telfixo.Text = ("");
            email.Text = ("");
            site.Text = ("");
            log.Text = ("");
            numeroCampo.Text = ("");
            cep.Text = ("");
            bairro.Text = ("");
            cpfcnpjbusca.Text = ("");
            comp.Text = ("");
            estado.Text = ("");
            MessageBox.Show("Dados inseridos com sucesso!");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            numeroCampo.Visible = true;
            numeroLabel.Visible = true;
        }
    }
}
