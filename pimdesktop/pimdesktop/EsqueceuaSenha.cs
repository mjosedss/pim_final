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
    public partial class EsqueceuaSenha : Form
    {
        //conexao banco de dados
        private string _strConn = @"data source = LocalHost; database = Pim4final; integrated security = SSPI;";
        SqlCommand objCommand = null;
        SqlConnection objConnect = null;
        public EsqueceuaSenha()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //conexao banco de dados
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();
            //conexao para comparação de dados
            SqlCommand cmd = new SqlCommand("select * from FUNCIONARIO where FUN_STR_REGISTRO ='" + NumReg.Text + "' and FUN_STR_CPF = '" + cpfcnpj.Text + "';");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();

        
            //condição
            if (reader.Read()) {
                conn.Close();
                conn.Open();

                string sql = "UPDATE FUNCIONARIO SET FUN_STR_SENHA = '" + ConfSenha.Text + "' where FUN_STR_REGISTRO = '" + NumReg.Text + "' AND FUN_STR_CPF = '" + cpfcnpj.Text + "' ";

                SqlCommand cmd1 = new SqlCommand(sql, conn);
                //condição
                if (ConfSenha.Text == EntraSenha.Text && ConfSenha.Text != "")
                {
                                      
                        cmd1.ExecuteNonQuery();
                    button5.Visible = false;
                    NumReg.Text = ("");
                    cpfcnpj.Text = ("");
                    ConfSenha.Text = ("");
                    EntraSenha.Text = ("");
                    MessageBox.Show("Alteração efetuada com sucesso!");
   


                }
                //condição não cumprida
                else
                {
                    MessageBox.Show("Verifique se as senhas digitadas são as mesmas!");
                }

            }
            //condição não cumprida
            else
            {
                MessageBox.Show("Usuário não localizado!");
            }
                                
        }
    }
}
