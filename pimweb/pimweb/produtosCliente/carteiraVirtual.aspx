<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="carteiraVirtual.aspx.cs" Inherits="pimweb.produtosCliente.carteiraVirtual" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
          <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <script src="../js/jquery-3.5.1.min.js"></script>
    <link href="../css/styles.css" rel="stylesheet" />
    
    <title></title>
</head>
<body>
     <img class="displayed" src="../images/logo.png" alt="ok">      </img>  
    			
  
  <main class="col-md-9 col-lg-5 col-sm-4 col-xs-3 login-container">
         <form id="form1" runat="server">
              <p>Extrato</p>
               <div class = "lbl">  
      <asp:Label ID="operacoes" runat="server"></asp:Label><br>
      <asp:Label ID="saldo" runat="server"></asp:Label></br><br>
                    <asp:Label ID="cotacao1" runat="server"></asp:Label></br><br>
                   <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Deposito</asp:LinkButton>
                     <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Saque</asp:LinkButton>
                     <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Compra</asp:LinkButton>
                   <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Venda</asp:LinkButton><br>
                   <asp:Label ID="textooperacoes" runat="server" Text=""></asp:Label><br>
                   <div class ="caixa">
                   <asp:TextBox ID="valor" runat="server" Height="22px" Width="112px" placeholder="Digite o valor" visible="false" autocomplete="off"></asp:TextBox></br>
                   </div><br>
                   
                   <asp:Label ID="Confirmacao" runat="server" Text=""></asp:Label>
                   
                   <asp:Button ID="Executar" runat="server" Text="Executar" visible ="false" OnClick="Executar_Click"/>
      
          
     </div>
        <asp:Button ID="Button1" runat="server" Text="Voltar" OnClick="Button1_Click" />


    </form>
          </main>
</body>
</html>
