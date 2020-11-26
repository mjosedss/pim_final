<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="segundaTela.aspx.cs" Inherits="pimweb.segundaTela" %>

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
       <img class="displayed" src="images/logo.png" alt="ok">  
  
  <main class="col-md-9 col-lg-5 col-sm-4 col-xs-3 login-container">
     
    <form id="form1" runat="server">
       <asp:Label ID="lbl_teste" runat="server" ></asp:Label> 

        <asp:Button ID="btnmeusdds" runat="server" OnClick="Button1_Click" Text="Meus Dados" />
        <asp:Button ID="btnprod" runat="server" OnClick="Button2_Click" Text="Produtos" />
        <asp:Button ID="btnctt" runat="server" OnClick="Button3_Click" Text="Contato Conosco" />
      
        <asp:Button ID="btnlogout" runat="server" OnClick="Button5_Click" Text="Logout" />
            

    </form>

     </main>
</body>
</html>
