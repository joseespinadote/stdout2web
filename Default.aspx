<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="txtArgumentos" Text="2.0 3.0"></asp:TextBox>
            <asp:Button runat="server" ID="btnBoton" Text="Aprietame suavecito" OnClick="btnBoton_Click"/>
            <asp:Label runat="server" ID="lblSalida" Text="Acá va la salida del .exe"></asp:Label>
        </div>
    </form>
</body>
</html>
