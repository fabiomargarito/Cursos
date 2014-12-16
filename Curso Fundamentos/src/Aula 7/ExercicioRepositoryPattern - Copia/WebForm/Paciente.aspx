<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Paciente.aspx.cs" Inherits="WebForm.Paciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="CPF" runat="server"></asp:TextBox>
        <asp:TextBox ID="Nome" runat="server"></asp:TextBox>
        <asp:Button ID="Gravar" runat="server" OnClick="Gravar_Click" Text="Button" />
    
    </div>
        <asp:GridView ID="GridDePacientes" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
