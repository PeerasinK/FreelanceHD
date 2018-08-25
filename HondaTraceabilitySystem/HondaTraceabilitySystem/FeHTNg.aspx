<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FeHTNg.aspx.cs" Inherits="HondaTraceabilitySystem.FeHTNg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FE NG - Honda Traceability System</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="flblTitle" runat="server" Style="height: 23px;" CssClass="TitleLabel"
                            Width="230px">FE - NG</asp:Label>
        </div>
        <div>
            <h4><asp:Label ID="lblMsg" runat="server" BackColor="Transparent"></asp:Label> </h4>
		</div>
        <div style="WIDTH: 230px; POSITION: relative; HEIGHT: 470px; left: 0px; top: 0px;">
            <asp:panel id="pnlKey" style="Z-INDEX: 103; LEFT: 5px; POSITION: absolute; TOP: 5px; width: 225px; height: 0px;" 
                    runat="server">
                
		        <asp:Label ID="flblPROCESS" runat="server" >Process</asp:Label><br />
                    <asp:DropDownList ID="ddlPROCESS" runat="server" style="width: 150px;" >
                    </asp:DropDownList>

            </asp:panel>

            <asp:panel id="pnlDetail" style="Z-INDEX: 102; LEFT: 8px; POSITION: absolute; TOP: 50px; width: 225px; height: 300px;" 
                    runat="server">

                <asp:Label ID="flblQR_Code" runat="server" >Please Scan 2D Barcode</asp:Label><br/>
                    <asp:TextBox ID="txtQR_Code" runat="server"></asp:TextBox><br /><br />

                <asp:Label ID="flblMachine" runat="server" >Machine No</asp:Label><br/>
                    <asp:TextBox ID="txtMachine" runat="server" MaxLength="11"></asp:TextBox><br /><br />

                <asp:Label ID="flblNG" runat="server" >NG Code</asp:Label><br/>
                    <asp:TextBox ID="txtNG" runat="server" MaxLength="5"></asp:TextBox><br /><br />

                <asp:Label ID="flblShift" runat="server" >Shift</asp:Label><br/>
                    <asp:TextBox ID="txtShift" runat="server" MaxLength="1"></asp:TextBox><br /><br />

                <asp:Button ID="cmdSave" runat="server" style="left: 35px; POSITION: absolute; width: 80px;" 
                    Text="SAVE" OnClick="cmdSave_Click">
                </asp:Button><br /><br /><br />

                <asp:Button ID="btnReturn" runat="server" style="width:80px;"
                    Text="BACK" OnClick="imgReturn_Click">
                </asp:Button>

            </asp:panel>
        </div>
    </form>
</body>
</html>
