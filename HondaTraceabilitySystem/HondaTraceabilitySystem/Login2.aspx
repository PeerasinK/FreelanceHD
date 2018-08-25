<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login2.aspx.cs" Inherits="HondaTraceabilitySystem.Login2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login - Honda Traceability System</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3><asp:Label ID="Label4" runat="server" Text="Honda Traceability System"></asp:Label> </h3>
        </div>
        <div style="WIDTH: 230px; POSITION: relative; HEIGHT: 470px; left: 0px; top: 0px;">
            <asp:panel id="pnlKey" style="Z-INDEX: 103; LEFT: 5px; POSITION: absolute; TOP: 5px; width: 225px; height: 0px;" 
                    runat="server">

                <asp:Label ID="Label1" runat="server" Text="Please enter User ID and Password."></asp:Label><br /><br />

                <asp:Label ID="Label2" runat="server" Text="User ID"></asp:Label><br />
                    <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox><br /><br />     

                <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label><br/>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br /><br />

                <asp:Button ID="btnLogin" runat="server" style="left: 35px; POSITION: absolute; width: 80px;" 
                    Text="Login" OnClick="btnLogin_Click">
                </asp:Button><br /><br />
                
                <h4><asp:Label ID="lblMsg" runat="server" BackColor="Transparent"></asp:Label> </h4>

            </asp:panel>
        </div>
    </form>
</body>
</html>
