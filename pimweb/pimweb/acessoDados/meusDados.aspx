<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="meusDados.aspx.cs" Inherits="pimweb.acessoDados.meusDados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <script src="../js/jquery-3.5.1.min.js"></script>
    <link href="../css/styles.css" rel="stylesheet" />
    <script src="../js/jquery-3.5.1.min.js"></script>
    <script src="../js/jquery.mask.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function(){
            $("#CEP1").mask("00000-000")
            $("#CPFCNPJ").mask("000.000.000-00")
            $("#Telefone1").mask("(00) 00000-0000  (00) 0000-0000")
            })
            </script>
    <title></title>
</head>
<body>
   <img class="displayed" src="../images/logo.png" alt="ok">      </img>  
    			
  
  <main class="col-md-9 col-lg-5 col-sm-4 col-xs-3 login-container">
    
       
    <form id="form1" runat="server">
            <div class = "lbl">  
            <p><span style="color: orange;">Razão Social: </span><br /> 
            <asp:Label ID="RazaoSocial" runat="server" ></asp:Label>   </p>
             <p><span style="color: orange;">Nome Fantasia: </span><br />
            <asp:Label ID="NomeFantasia" runat="server" ></asp:Label> </p>
            <p><span style="color: orange;">CPF/CNPJ: </span><br />
            <asp:Label ID="CPFCNPJ" runat="server" ></asp:Label></p>
            <p><span style="color: orange;">Email: </span><br />
            <asp:Label ID="Email1" runat="server" ></asp:Label></p>
            <p><span style="color: orange;">Telefones: </span><br />
            <asp:Label ID="Telefone1" runat="server" ></asp:Label></p>
            <p><span style="color: orange;">Site: </span><br />
            <asp:Label ID="Site1" runat="server" ></asp:Label></p>
            <p><span style="color: orange;">Logradouro: </span><br />
            <asp:Label ID="Logradouro1" runat="server" ></asp:Label></p>
            <p><span style="color: orange;">Bairro: </span><br />
            <asp:Label ID="Bairro1" runat="server" ></asp:Label></p>
            <p><span style="color: orange;">Cidade: </span><br />
            <asp:Label ID="Cidade1" runat="server" ></asp:Label></p>
            <p><span style="color: orange;">CEP: </span><br />
            <asp:Label ID="CEP1" runat="server" ></asp:Label></p>



        </div>
       
           <asp:Button ID="Button1" runat="server" Text="Voltar" OnClick="Button1_Click" />
  
            </form>
       </main>
</body>
   
</html>
