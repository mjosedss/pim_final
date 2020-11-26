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
    public partial class Login : Form
    {
        string setor;
        public Login(string recebeSetor)
        {
            InitializeComponent();
            //recebe variavel para validar tipo de usuario / senha
            setor = recebeSetor;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conexao banco de dados
            string connStr = "data source = LocalHost; database = Pim4final; integrated security = SSPI;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from FUNCIONARIO where FUN_STR_REGISTRO ='" + User.Text + "' and FUN_STR_SENHA = '" + Password.Text + "' and SET_INT_ID = '" + setor + "' ;");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();

           //validando senha, de acordo com o setor
         
                if (reader.Read())
                {
                if (setor == "5")
                {
                    this.Hide();
                    Comercial comercial = new Comercial();
                    comercial.ShowDialog();
                }
                if (setor == "3")
                {
                    this.Hide();
                    Atendimento atendimento = new Atendimento();
                    atendimento.ShowDialog();

                }
                if (setor == "1")
                {
                    this.Hide();
                    Operacional operacional = new Operacional();
                    operacional.ShowDialog();

                }
                if (setor == "4")
                {
                    this.Hide();
                    Financeiro financeiro = new Financeiro();
                    financeiro.ShowDialog();

                }
                if (setor == "2")
                {
                    this.Hide();
                    Administrativo administrativo = new Administrativo();
                    administrativo.ShowDialog();

                }
            }
            //condição não satisfeita
            else
            {
                MessageBox.Show("Senha e (ou) usuário incorretos");
            }
            conn.Close();

        }
       

        }
    }

