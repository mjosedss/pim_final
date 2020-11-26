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
    public partial class Financeiro : Form
    {
        private string _strConn = @"data source = LocalHost; database = Pim4final; integrated security = SSPI;";
        SqlCommand objCommand = null;
        SqlConnection objConnect = null;
        public Financeiro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int confirma = 0;

            try
            {
                string strSql = "select OPC_INT_ID, OPC_DOU_VALOR, OPC_DAT_DATA FROM OPERACOESCARTEIRA WHERE OPC_STR_PENDENTE = 'nao' AND OPC_DAT_DATA BETWEEN '" + DateTime.Parse(datInicial.Text) + "' AND '" + DateTime.Parse(datFinal.Text) + "' order by  OPC_DAT_DATA";
                objConnect = new SqlConnection(_strConn);
                objCommand = new SqlCommand(strSql, objConnect);

            }
            catch
            {
                MessageBox.Show("Dados não encontrados");
            }

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);
                dgDados.DataSource = dtLista;
                dgDados.Columns["OPC_INT_ID"].HeaderText = "Nº da Ordem de Serviço";
                dgDados.Columns["OPC_DOU_vALOR"].HeaderText = "Valor da Operação";
                dgDados.Columns["OPC_DAT_DATA"].HeaderText = "Data da solicitação";
                confirma = 1;
                objConnect.Close();

            }
            catch
            {

            }

            if (confirma != 0)
            {
                string strSql2 = "SELECT SUM(OPC_DOU_VALOR) AS total FROM OPERACOESCARTEIRA WHERE OPC_STR_PENDENTE = 'nao' AND OPC_DAT_DATA BETWEEN '" + DateTime.Parse(datInicial.Text) + "' AND '" + DateTime.Parse(datFinal.Text) + "'";
                objConnect = new SqlConnection(_strConn);
                objCommand = new SqlCommand(strSql2, objConnect);
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);
                //dgDados.DataSource = dtLista;
                somaa.Text = (dtLista.Rows[0]["total"].ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Historico historico = new Historico();

            historico.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            string strSql = "select CLI_INT_ID, CSC_DOU_VALOR FROM CONSULTACARTEIRA";
            objConnect = new SqlConnection(_strConn);
            objCommand = new SqlCommand(strSql, objConnect);

            SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
            DataTable dtLista = new DataTable();
            objAdp.Fill(dtLista);
            dgDados.DataSource = dtLista;
            dgDados.Columns["CLI_INT_ID"].HeaderText = "Id do Cliente";
            dgDados.Columns["CSC_DOU_vALOR"].HeaderText = "Saldo";


            objConnect.Close();


            string strSql2 = "SELECT SUM(CSC_DOU_VALOR) AS total FROM CONSULTACARTEIRA";
            objConnect = new SqlConnection(_strConn);
            objCommand = new SqlCommand(strSql2, objConnect);
            SqlDataAdapter objAdpp = new SqlDataAdapter(objCommand);
            DataTable dtListaa = new DataTable();
            objAdpp.Fill(dtListaa);
            //dgDados.DataSource = dtLista;
            Saldoo.Text = (dtListaa.Rows[0]["total"].ToString());


        }
    }
}