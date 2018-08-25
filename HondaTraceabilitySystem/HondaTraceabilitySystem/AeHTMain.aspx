<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AeHTMain.aspx.cs" Inherits="HondaTraceabilitySystem.AeHTMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AE - Honda Traceability System</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="flblTitle" runat="server" Style="height: 23px;" CssClass="TitleLabel"
                            Width="230px">AE</asp:Label>
        </div>
        <div>
            <h4><asp:Label ID="lblMsg" runat="server" BackColor="Transparent"></asp:Label> </h4>
        </div>
        <div style="WIDTH: 230px; POSITION: relative; HEIGHT: 470px; left: 0px; top: 0px;">
            <asp:Button ID="btnAECRS" runat="server" style="left: 5px; POSITION: absolute; width:140px; top: 0px;"
                Text="Crank Shaft" OnClick="btnAECRS_Click">
            </asp:Button><br /><br />
             <asp:Button ID="btnAECRSS" runat="server" style="left: 5px; POSITION: absolute; width:140px; "
                Text="Crank Shaft Swap" OnClick="btnAECRSS_Click">
            </asp:Button><br /><br />
            <asp:Button ID="btnAEHEA" runat="server" style="left: 5px; POSITION: absolute; width:140px;"
                Text="Head" OnClick="btnAEHEA_Click">
            </asp:Button><br /><br />
             <asp:Button ID="btnAEHEAS" runat="server" style="left: 5px; POSITION: absolute; width:140px; "
                Text="Head Swap" OnClick="btnAEHEAS_Click">
            </asp:Button><br /><br /><br /><br />
            <asp:Button ID="btnReturn" runat="server" style="width:80px;"
                Text="BACK" OnClick="imgReturn_Click">
            </asp:Button>
        </div>
    </form>
</body>
</html>
