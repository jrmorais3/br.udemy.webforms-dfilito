<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultiplicationTable.aspx.cs" Inherits="MultiplicationTable.MultiplicationTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <h1>Tabuada</h1>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="dLista" runat="server" OnSelectedIndexChanged="dLista_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Button ID="btExecutar" runat="server" OnClick="btExecutar_Click" Text="Executar" />
        </div>
        <asp:ListBox ID="lbDados" runat="server" Height="247px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="155px"></asp:ListBox>
    </form>
</body>
</html>
