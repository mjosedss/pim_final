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
    public partial class Administrativo : Form
    {
        private string _strConn = @"data source = LocalHost; database = Pim4final; integrated security = SSPI;";
        SqlCommand objCommand = null;
        SqlConnection objConnect = null;
        public Administrativo()
        {
            InitializeComponent();
            comboBoxCargo.Visible = false;
            comboBoxSetor.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            Confirma.Visible = false;
            comboBoxStatus.Visible = false;
            Status.Visible = false;
            ConfirmaAltera.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strSql = "select FUNCIONARIO.FUN_STR_NOME, FUNCIONARIO.FUN_STR_REGISTRO, FUNCIONARIO.FUN_STR_CPF, SETORES.SET_STR_SETOR, CARGO.CAR_STR_CARGO FROM FUNCIONARIO, SETORES, CARGO WHERE " +
                "SETORES.SET_INT_ID = FUNCIONARIO.SET_INT_ID AND CARGO.CAR_INT_ID = FUNCIONARIO.CAR_INT_ID";
            objConnect = new SqlConnection(_strConn);
            objCommand = new SqlCommand(strSql, objConnect);

            SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
            DataTable dtLista = new DataTable();
            objAdp.Fill(dtLista);
            dgDados.DataSource = dtLista;
            dgDados.Columns["FUN_STR_NOME"].HeaderText = "Nome";
            dgDados.Columns["FUN_STR_REGISTRO"].HeaderText = "Registro";
            dgDados.Columns["FUN_STR_CPF"].HeaderText = "CPF";
            dgDados.Columns["SET_STR_SETOR"].HeaderText = "Setor";
            dgDados.Columns["CAR_STR_CARGO"].HeaderText = "Cargo";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("select FUNCIONARIO.FUN_STR_NOME, FUNCIONARIO.FUN_STR_REGISTRO, FUNCIONARIO.FUN_STR_CPF, FUNCIONARIO.FUN_STR_TELCEL, FUNCIONARIO.FUN_STR_TELFIXO, FUNCIONARIO.FUN_STR_STATUS, SETORES.SET_STR_SETOR, CARGO.CAR_STR_CARGO FROM FUNCIONARIO, SETORES, CARGO WHERE " +
                "SETORES.SET_INT_ID = FUNCIONARIO.SET_INT_ID AND CARGO.CAR_INT_ID = FUNCIONARIO.CAR_INT_ID AND FUNCIONARIO.FUN_STR_REGISTRO = '" + numregistro.Text + "'");
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.Connection = conn;
            string retornoNome = "";
            string retornoCPFCNPJ = "";
            string retornoTELFIXO = "";
            string retornoTELCEL = "";
            string retornoSetor = "";
            string retornoCargo = "";
            string retornoStatus = "";

            SqlDataReader reader = cmd2.ExecuteReader();

            if (reader.Read())
            {
                retornoNome = reader["FUN_STR_NOME"].ToString();
                retornoCPFCNPJ = reader["FUN_STR_CPF"].ToString();
                retornoTELCEL = reader["FUN_STR_TELCEL"].ToString();
                retornoTELFIXO = reader["FUN_STR_TELFIXO"].ToString();
                retornoSetor = reader["SET_STR_SETOR"].ToString();
                retornoCargo = reader["CAR_STR_CARGO"].ToString();
                retornoStatus = reader["FUN_STR_STATUS"].ToString();



            }
            else
            {
                MessageBox.Show("Ordem de serviço não encontrada");
            }
            conn.Close();
            nome.Text = retornoNome;
            telCel.Text = retornoTELCEL;
            telFix.Text = retornoTELFIXO;
            statuus.Text = retornoStatus;
            setoor.Text = retornoSetor;
            cargoo.Text = retornoCargo;
            cpfcnpj.Text = retornoCPFCNPJ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();
            int setor = 0;
            int cargo = 0;
            string senha = "12345";
            string sql = "INSERT INTO FUNCIONARIO (FUN_STR_NOME, FUN_STR_CPF, FUN_STR_TELCEL, FUN_STR_TELFIXO, SET_INT_ID, CAR_INT_ID, FUN_STR_STATUS, FUN_STR_REGISTRO, FUN_STR_SENHA)" +
           "VALUES (@Nome, @CPF, @TelCel , @TelFixo, @Setor, @Cargo, @Status, @Registro, @senha)";
            SqlCommand cmd1 = new SqlCommand(sql, conn);

            if (comboBoxSetor.Text == "Operacional")
            {
                setor = 1;
            }
            if (comboBoxSetor.Text == "Administrativo")
            {
                setor = 2;
            }
            if (comboBoxSetor.Text == "Atendimento")
            {
                setor = 3;
            }
            if (comboBoxSetor.Text == "Financeiro")
            {
                setor = 4;
            }
            if (comboBoxSetor.Text == "Comercial")
            {
                setor = 5;
            }
            if (comboBoxCargo.Text == "Tecnico")
            {
                cargo = 1;
            }
            if (comboBoxCargo.Text == "Atendente")
            {
                cargo = 2;
            }
            if (comboBoxCargo.Text == "Gerente")
            {
                cargo = 3;
            }
            if (comboBoxCargo.Text == "Administrador")
            {
                cargo = 4;
            }
            if (comboBoxCargo.Text == "Supervisor")
            {
                cargo = 5;
            }
            cmd1.Parameters.AddWithValue("@Nome", nome.Text);
            cmd1.Parameters.AddWithValue("@CPF", cpfcnpj.Text);
            cmd1.Parameters.AddWithValue("@TelCel", telCel.Text);
            cmd1.Parameters.AddWithValue("@TelFixo", telFix.Text);
            cmd1.Parameters.AddWithValue("@Cargo", cargo);
            cmd1.Parameters.AddWithValue("@Setor", setor);
            cmd1.Parameters.AddWithValue("@Status", comboBoxStatus.Text);
            cmd1.Parameters.AddWithValue("@Registro", numregistro.Text);
            cmd1.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Dados Inseridos com Sucesso!");
            }
            catch
            {
                MessageBox.Show("Erro!");
            }
            nome.Text = ("");
            cpfcnpj.Text = ("");
            telFix.Text = ("");
            telCel.Text = ("");
            statuus.Text = ("");
            numregistro.Text = ("");
            setoor.Text = ("");
            cargoo.Text = ("");
            comboBoxCargo.Visible = false;
            comboBoxSetor.Visible = false;
            comboBoxStatus.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            IncluirFuncionario.Visible = true;
            Confirma.Visible = false;
            Status.Visible = false;
        }

        private void AlterarDados_Click(object sender, EventArgs e)
        {
            comboBoxCargo.Visible = true;
            comboBoxSetor.Visible = true;
            comboBoxStatus.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            IncluirFuncionario.Visible = false;
            Confirma.Visible = true;
            Status.Visible = true;
        }

        private void Confirma_Click(object sender, EventArgs e)
        {
            int setor = 0;
            int cargo = 0;
            if (comboBoxSetor.Text == "Operacional")
            {
                setor = 1;
            }
            if (comboBoxSetor.Text == "Administrativo")
            {
                setor = 2;
            }
            if (comboBoxSetor.Text == "Atendimento")
            {
                setor = 3;
            }
            if (comboBoxSetor.Text == "Financeiro")
            {
                setor = 4;
            }
            if (comboBoxSetor.Text == "Comercial")
            {
                setor = 5;
            }
            if (comboBoxCargo.Text == "Tecnico")
            {
                cargo = 1;
            }
            if (comboBoxCargo.Text == "Atendente")
            {
                cargo = 2;
            }
            if (comboBoxCargo.Text == "Gerente")
            {
                cargo = 3;
            }
            if (comboBoxCargo.Text == "Administrador")
            {
                cargo = 4;
            }
            if (comboBoxCargo.Text == "Supervisor")
            {
                cargo = 5;
            }
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();
            string sql = "UPDATE FUNCIONARIO SET FUN_STR_NOME = '" + nome.Text + "', FUN_STR_CPF = '" + cpfcnpj.Text + "', FUN_STR_TELCEL = '" + telCel.Text + "', FUN_STR_TELFIXO = '" + telFix.Text + "', FUN_STR_STATUS = '" + comboBoxStatus.Text + "', SET_INT_ID = '" + setor +"', CAR_INT_ID = '" + cargo +"' WHERE " +
                "FUN_STR_REGISTRO = '" + numregistro.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            try
            {
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Dados Inseridos com Sucesso!");
            }
            catch
            {


                MessageBox.Show("Erro!");
            }
            comboBoxCargo.Visible = false;
            comboBoxSetor.Visible = false;
            comboBoxStatus.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            Status.Visible = false;
            ConfirmaAltera.Visible = false;
            button1.Visible = true;
            nome.Text = ("");
            cpfcnpj.Text = ("");
            telFix.Text = ("");
            telCel.Text = ("");
            statuus.Text = ("");
            numregistro.Text = ("");
            setoor.Text = ("");
            cargoo.Text = ("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxCargo.Visible = true;
            comboBoxSetor.Visible = true;
            comboBoxStatus.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            Status.Visible = true;
            ConfirmaAltera.Visible = true;
            button1.Visible = false;
        }
    }
}
