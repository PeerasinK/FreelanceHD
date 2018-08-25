<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FeHTMain.aspx.cs" Inherits="HondaTraceabilitySystem.FeHTMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FE - Honda Traceability System</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="flblTitle" runat="server" Style="height: 23px;" CssClass="TitleLabel"
                            Width="230px">FE</asp:Label>
        </div>
        <div>
            <h4><asp:Label ID="lblMsg" runat="server" BackColor="Transparent"></asp:Label> </h4>
        </div>
        <div style="WIDTH: 230px; POSITION: relative; HEIGHT: 470px; left: 0px; top: 0px;">
            <asp:Button ID="btnFERec" runat="server" style="left: 65px; POSITION: absolute; width:110px;"
                Text="FE Receiving" OnClick="btnFERec_Click">
            </asp:Button><br /><br />
            <asp:Button ID="btnFEIssue" runat="server" style="left: 65px; POSITION: absolute; width:110px;"
                Text="FE Issue" OnClick="btnFEIssue_Click">
            </asp:Button><br /><br />
            <asp:Button ID="btnFESwap" runat="server" style="left: 65px; POSITION: absolute; width:110px;"
                Text="FE Middle Swap" OnClick="btnFESwap_Click">
            </asp:Button><br /><br />
            <asp:Button ID="btnFEGsn" runat="server" style="left: 65px; POSITION: absolute; width:110px;"
                Text="FE GSN" OnClick="btnFEGsn_Click">
            </asp:Button><br /><br />
            <asp:Button ID="btnFESwap2" runat="server" style="left: 65px; POSITION: absolute; width:110px;"
                Text="FE Offline Swap" OnClick="btnFESwap2_Click">
            </asp:Button><br /><br />
            <asp:Button ID="btnFENg" runat="server" style="left: 65px; POSITION: absolute; width:110px;"
                Text="FE NG" OnClick="btnFENg_Click">
            </asp:Button><br /><br /><br /><br />
            <asp:Button ID="btnReturn" runat="server" style="width:80px;"
                Text="BACK" OnClick="imgReturn_Click">
            </asp:Button>
        </div>
    </form>
</body>
</html>
