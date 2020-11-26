using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace pimweb.acessoDados
{
    public partial class cttConosco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/segundaTela.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Pega data do sistema
            string strFormato = string.Empty;
            strFormato = DateTime.Now.Date.ToString("yyyy-MM-dd");
            // variaveis para controle no banco
            string pendente = "sim";
            int setor = 3;
            //Pega Id do cliente
            string resultado3 = Session["teste"].ToString();
          
            //Conexao com o banco
            SqlConnection conn = new SqlConnection("data source = LocalHost; database = Pim4final; integrated security = SSPI;");
            conn.Open();

            string sql = "INSERT INTO CTTCONOSCO (CTT_STR_DESC, CLI_INT_ID, CTT_STR_PENDENTE, SET_INT_ID, CTT_DAT_DATA) VALUES (@Faleconosco, @resultado, @pendente, @setor, @data)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            //Atribui valores 
            cmd.Parameters.AddWithValue("@Faleconosco", Faleconosco.Text);
            cmd.Parameters.AddWithValue("@resultado", resultado3);
            cmd.Parameters.AddWithValue("@pendente", pendente);
            cmd.Parameters.AddWithValue("@setor", setor);
            cmd.Parameters.AddWithValue("@data", strFormato);
            
            //Verifica se campo esta Null
            if (Faleconosco.Text != "")
            {
                cmd.ExecuteNonQuery();
                Faleconosco.Text = (" ");
                Button2.Visible = false;
                Confirmacao.Text = "  Sua solitação foi encaminhada com sucesso!";
            }
            // Campo Null
            else
            {
                Confirmacao.Text = "  Favor preencher sua solitação";
            }
   
        }
    }
}