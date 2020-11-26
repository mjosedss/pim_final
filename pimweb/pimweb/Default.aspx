<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="pimweb.Default" %>

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
        <h1><p style="text-align:center;">Login</p></h1>
        
           
            <asp:TextBox ID="txtusername" placeholder="Digite seu usuário" runat="server"></asp:TextBox></br>
            
     
            <asp:TextBox ID="txtpassword" type="password" placeholder="Digite sua senha"  autocomplete="off" runat="server" ></asp:TextBox></br>
            <asp:Label ID="Erro" runat="server" Text=""></asp:Label>
           
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Esqueçeu a senha?</asp:LinkButton>
            <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" />

     
    </div>
           
        </form>
     </main>
  
        

   
    
</body>
</html>
