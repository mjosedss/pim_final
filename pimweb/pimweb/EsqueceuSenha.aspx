<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EsqueceuSenha.aspx.cs" Inherits="pimweb.EsqueceuSenha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/styles.css" rel="stylesheet" />
    <script src="js/jquery-3.5.1.min.js"></script>
    <title></title>
</head>
<body>
       <IMG class="displayed" src="images/logo.png" alt="ok">        
    			
  
  <main class="col-md-9 col-lg-5 col-sm-4 col-xs-3 login-container">
    <form id="form1" runat="server">
           <h1><p style="text-align:center;">Alterar Senha</p></h1>
        <asp:TextBox ID="txtemail" placeholder="Digite seu e-mail" autocomplete="off" runat="server"></asp:TextBox>
         <asp:TextBox ID="txtcpfcnpj" placeholder="Digite seu CPF/CNPJ" autocomplete="off" runat="server"></asp:TextBox>
         <asp:TextBox ID="txtnomerz" placeholder="Digite seu nome/razão social" autocomplete="off" runat="server"></asp:TextBox>
        <p>Digite sua nova senha</p>
         <asp:TextBox ID="txtsenha" type="password" placeholder="Digite sua nova senha" autocomplete="off" runat="server"></asp:TextBox>
         <asp:TextBox ID="Txtredsenha" type="password" placeholder="Re-digite sua nova senha" autocomplete="off" runat="server"></asp:TextBox>
        <asp:Label ID="confereSenha" runat="server" Text=""></asp:Label>
         <asp:Button ID="Enviar" runat="server" Text="Enviar" OnClick="Enviar_Click" />
        <asp:Button ID="voltar" runat="server" Text="Voltar" OnClick="voltar_Click" />
        <div>
        </div>
    </form>
       </main>
</body>
</html>
