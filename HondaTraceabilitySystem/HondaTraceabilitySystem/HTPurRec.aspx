<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HTPurRec.aspx.cs" Inherits="HondaTraceabilitySystem.HTPurRec" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Receiving - Honda Traceability System</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="flblTitle" runat="server" Style="height: 23px;" CssClass="TitleLabel"
                            Width="230px">Receiving</asp:Label>
        </div>
        <div>
            <h4><asp:Label ID="lblMsg" runat="server" BackColor="Transparent"></asp:Label> </h4>
		</div>
        <div style="WIDTH: 230px; POSITION: relative; HEIGHT: 470px; left: 0px; top: 0px;">
            <asp:panel id="pnlKey" style="Z-INDEX: 103; LEFT: 5px; POSITION: absolute; TOP: 5px; width: 225px; height: 30px;" 
                    runat="server">
				
		        <asp:RadioButtonList ID="rdoTYPE" runat="server" RepeatDirection="Vertical" 
                        style=" LEFT: 8px; POSITION: absolute; TOP: 10px" AutoPostBack="True" OnSelectedIndexChanged="rdoTYPE_SelectedIndexChanged">
                            <asp:ListItem Value="IMPORT" Selected="True">IMPORT </asp:ListItem> 
                            <asp:ListItem Value="LOCAL">LOCAL </asp:ListItem>
                </asp:RadioButtonList>
                
            </asp:panel>

            <asp:panel id="pnlDetail" style="Z-INDEX: 102; LEFT: 8px; POSITION: absolute; TOP: 85px; width: 225px; height: 300px;" 
                    runat="server">

                <asp:Label ID="flblITEM_NO" runat="server" >Part No</asp:Label><br />
                    <asp:TextBox ID="txtITEM_NO" runat="server" MaxLength="17"></asp:TextBox><br />     

                <asp:Label ID="flblRCV_QTY" runat="server" >Receive Qty</asp:Label><br/>
                    <asp:TextBox ID="txtRCV_QTY" runat="server" MaxLength="7"></asp:TextBox><br /><br />

                <asp:Button ID="cmdSave" runat="server" style="left: 35px; POSITION: absolute; width: 80px;" 
                    Text="SAVE" OnClick="cmdSave_Click">
                </asp:Button><br /><br /><br />

                <asp:Button ID="Button1" runat="server" style="width:80px;"
                    Text="BACK" OnClick="imgReturn_Click">
                </asp:Button>

            </asp:panel>
        </div>
    </form>
</body>
</html>
