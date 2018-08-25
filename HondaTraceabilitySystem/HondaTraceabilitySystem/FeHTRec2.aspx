<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FeHTRec2.aspx.cs" Inherits="HondaTraceabilitySystem.FeHTRec2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FE Verify Receiving - Honda Traceability System</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="flblTitle" runat="server" Style="height: 23px;" CssClass="TitleLabel"
                            Width="230px">FE - Receiving</asp:Label>
        </div>
        <div>
            <h4><asp:Label ID="lblMsg" runat="server" BackColor="Transparent"></asp:Label> </h4>
		</div>
        <div style="WIDTH: 230px; POSITION: relative; HEIGHT: 470px; left: 0px; top: 0px;">
            <asp:panel id="pnlKey" style="Z-INDEX: 103; LEFT: 5px; POSITION: absolute; TOP: 5px; width: 225px; height: 0px;" 
                    runat="server">

                <asp:Label ID="flblPROCESS" runat="server" >Process</asp:Label><br />
                    <asp:DropDownList ID="ddlPROCESS" runat="server" style="width: 150px;" OnSelectedIndexChanged="ddlPROCESS_SelectedIndexChanged" AutoPostBack="True" >
                    </asp:DropDownList>
                
            </asp:panel>

            <asp:panel id="pnlDetail" style="Z-INDEX: 102; LEFT: 8px; POSITION: absolute; TOP: 70px; width: 225px; height: 300px;" 
                    runat="server">

                <asp:Label ID="flblITEM_NO" runat="server" >Part No</asp:Label><br />
                    <asp:TextBox ID="txtITEM_NO" runat="server"></asp:TextBox><br /><br />     

                <asp:Label ID="flblLOT_NO" runat="server" >Lot No</asp:Label><br/>
                    <asp:TextBox ID="txtLOT_NO" runat="server" MaxLength="8"></asp:TextBox><br /><br />

                <asp:Label ID="flblRCV_QTY" runat="server" >Receive Qty</asp:Label><br/>
                    <asp:TextBox ID="txtRCV_QTY" runat="server" MaxLength="4"></asp:TextBox><br /><br />

                <asp:Label ID="flblDIE_NO" runat="server" >Die No</asp:Label><br/>
                    <asp:TextBox ID="txtDIE_NO" runat="server" MaxLength="4"></asp:TextBox><br /><br />

                <asp:Label ID="flblSHIFT" runat="server" >Shift</asp:Label><br/>
                    <asp:TextBox ID="txtSHIFT_NO" runat="server" MaxLength="1"></asp:TextBox><br /><br />

                <asp:Label ID="lblNo" runat="server" ></asp:Label><br /><br />

                <asp:Button ID="btnPrev" runat="server" style="width:80px;"
                    Text="BACK" OnClick="btnPrev_Click">
                </asp:Button>

                <asp:Button ID="btnNext" runat="server" style="left: 100px; POSITION: absolute; width:80px;"
                    Text="NEXT" OnClick="btnNext_Click">
                </asp:Button>

                <asp:Button ID="cmdSave" runat="server" style="left: 35px; POSITION: absolute; width: 80px;" 
                    Text="SAVE" OnClick="cmdSave_Click" Visible="False">
                </asp:Button><br /><br /><br />

                <asp:Button ID="btnReturn" runat="server" style="width:80px;"
                    Text="BACK" OnClick="imgReturn_Click">
                </asp:Button>

            </asp:panel>
<asp:HiddenField ID="hdnNo" runat="server" />
<asp:HiddenField ID="hdnMaxNo" runat="server" />
        </div>
    </form>
</body>
</html>
