<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="HondaTraceabilitySystem.Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Menu - Honda Traceability System</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="flblTitle" runat="server" Style="height: 23px;" CssClass="TitleLabel"
                            Width="230px">Main Menu</asp:Label>
        </div>
        <div>
            <h4><asp:Label ID="lblMsg" runat="server" BackColor="Transparent"></asp:Label> </h4>
        </div>
        <div style="WIDTH: 230px; POSITION: relative; HEIGHT: 470px; left: 0px; top: 0px;">
            <asp:Button ID="btnPEMS" runat="server" style="left: 75px; POSITION: absolute; width:80px;"
                Text="PE/MS" OnClick="btnPEMS_Click">
            </asp:Button><br /><br />
            <%--<asp:Button ID="btnMC" runat="server" style="left: 75px; POSITION: absolute; width:80px;"
                Text="MC" OnClick="btnMC_Click">
            </asp:Button><br /><br />--%>
            <asp:Button ID="btnFE" runat="server" style="left: 75px; POSITION: absolute; width:80px;"
                Text="FE" OnClick="btnFE_Click">
            </asp:Button><br /><br />
            <asp:Button ID="btnAE" runat="server" style="left: 75px; POSITION: absolute; width:80px;"
                Text="AE" OnClick="btnAE_Click">
            </asp:Button><br /><br /><br /><br />
            <asp:Button ID="btnLogoff" runat="server" style="width:80px;"
                Text="LOG OFF" OnClick="imgLogoff_Click">
            </asp:Button>
        </div>
    </form>
</body>
</html>
