<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HTMain.aspx.cs" Inherits="HondaTraceabilitySystem.HTMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PE/MS - Honda Traceability System</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="flblTitle" runat="server" Style="height: 23px;" CssClass="TitleLabel"
                            Width="230px">PE/MS</asp:Label>
        </div>
        <div>
            <h4><asp:Label ID="lblMsg" runat="server" BackColor="Transparent"></asp:Label> </h4>
        </div>
        <div style="WIDTH: 230px; POSITION: relative; HEIGHT: 470px; left: 0px; top: 0px;">
            <asp:Button ID="btnRec" runat="server" style="left: 75px; POSITION: absolute; width:90px;"
                Text="Receiving" OnClick="btnRec_Click">
            </asp:Button><br /><br /><br /><br />
            <asp:Button ID="btnReturn" runat="server" style="width:80px;"
                Text="BACK" OnClick="imgReturn_Click">
            </asp:Button>
        </div>
    </form>
</body>
</html>
