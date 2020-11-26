using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pimweb.acessoDados
{
    public partial class Produtos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // guarda ID Clente
            string resultado1 = Session["teste"].ToString();
            Session["teste"] = resultado1;
            //Redireciona
            Response.Redirect("~/produtosCliente/protecaoDeAtivos.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            string resultado1 = Session["teste"].ToString();
            Session["teste"] = resultado1;
            Response.Redirect("~/produtosCliente/contratosInteligentes.aspx");
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            string resultado1 = Session["teste"].ToString();
            Session["teste"] = resultado1;
            Response.Redirect("~/produtosCliente/carteiraVirtual.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/segundaTela.aspx");
        }
    }
}