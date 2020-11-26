using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pimweb
{
    public partial class segundaTela : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
               

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //resgata ID do usuãrio logado
            string resultado1 = Session["teste"].ToString();
            Session["teste"] = resultado1;
           
            //redireciona a próxima tela
            Response.Redirect("~/acessoDados/meusDados.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/acessoDados/Produtos.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string resultado1 = Session["teste"].ToString();
            Session["teste"] = resultado1;
            

            Response.Redirect("~/acessoDados/cttConosco.aspx");

        }

   

        protected void Button5_Click(object sender, EventArgs e)
        {
            //Limpa variavel que guarda ID do cliente e retorna Tela Inicial
            Session["teste"] = "NULL";
            Session.Remove("User");
            Response.Redirect("~/Default.aspx");
        }
    }
}