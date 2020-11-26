<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contratosInteligentes.aspx.cs" Inherits="pimweb.produtosCliente.contratosInteligentes" %>

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
       <asp:Label ID="lbl_teste" runat="server" ></asp:Label> <br/>
              <asp:LinkButton ID="solicitarlink" runat="server" OnClick="solicitarlink_Click">Efetuar nova contratação</asp:LinkButton><br/>
              <asp:Label ID="chamada" runat="server" Text=""></asp:Label>
                    <asp:TextBox ID="solicitacaoctt" runat="server" TextMode="multiline" Height="189px" Width="277px" visible="false" autocomplete="off" ></asp:TextBox><br/>
               <asp:Label ID="retorno" runat="server" Text=""></asp:Label></div><br/> 
               </div>
        <asp:Button ID="executar" runat="server" Text="Enviar" visible ="false" OnClick="Button2_Click" />
        <asp:Button ID="Button1" runat="server" Text="Voltar" OnClick="Button1_Click" />

     </form>
          </main>
</body>
</html>
