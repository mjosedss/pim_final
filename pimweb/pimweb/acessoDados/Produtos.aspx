<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Produtos.aspx.cs" Inherits="pimweb.acessoDados.Produtos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/styles.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    
     <img class="displayed" src="../images/logo.png" alt="ok">   
      <main class="col-md-9 col-lg-5 col-sm-4 col-xs-3 login-container">
    <form id="form1" runat="server">
       <asp:Label ID="lbl_teste" runat="server" ></asp:Label>   
        <asp:Button ID="Button1" runat="server" Text="Proteção de ativos" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Contratos inteligentes" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Carteira virtual" OnClick="Button3_Click" />
          <asp:Button ID="Button4" runat="server" Text="Voltar" OnClick="Button4_Click" />
    </form>
          </main>
</body>
</html>
