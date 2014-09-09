<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaAcoes.aspx.cs" Inherits="SistemaDeGestaoDeAcoesMVP.ListaAcoes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="BtnGravar" runat="server" Height="29px" OnClick="BtnGravar_Click" Text="Gravar" />
    
        <asp:GridView ID="GridView1" runat="server" style="margin-bottom: 0px">
        </asp:GridView>
    
    </form>
</body>
</html>
