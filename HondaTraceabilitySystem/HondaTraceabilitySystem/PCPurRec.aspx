<%@ Page Title="Receiving" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PCPurRec.aspx.cs" Inherits="HondaTraceabilitySystem.PCPurRec" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <table >
        <tr>
            <td>
                <asp:Label ID="flblTitle" runat="server" CssClass="TitleLabel" Text="Receiving"
                    Width="330"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <h4><asp:Label ID="lblMsg" runat="server" BackColor="Transparent"></asp:Label> </h4>
		</div>
        <div style="WIDTH: 1073px; POSITION: relative; HEIGHT: 470px; left: 0px; top: 0px;">
            <asp:panel id="pnlKey" style="Z-INDEX: 103; LEFT: 5px; POSITION: absolute; TOP: 5px; width: 725px; height: 30px;" 
                    runat="server">
				
				<asp:RadioButtonList ID="rdoTYPE" runat="server" RepeatDirection="Vertical" 
                        style=" LEFT: 8px; POSITION: absolute; TOP: 10px" AutoPostBack="True" >
                            <asp:ListItem Value="IMPORT" Selected="True">IMPORT </asp:ListItem> 
                            <asp:ListItem Value="LOCAL">LOCAL </asp:ListItem>
                </asp:RadioButtonList>
                
            </asp:panel>

            <asp:panel id="pnlDetail" style="Z-INDEX: 102; LEFT: 8px; POSITION: absolute; TOP: 85px; width: 725px; height: 300px;" 
                    runat="server">

                <div class="form-group">                      
                        <asp:Label ID="flblITEM_NO" runat="server" >Part No</asp:Label>
                        <asp:TextBox ID="txtITEM_NO" runat="server" MaxLength="17" CssClass="form-control"></asp:TextBox>
                    </div>

                <div class="form-group">                      
                        <asp:Label ID="flblRCV_QTY" runat="server" >Receive Qty</asp:Label>
                        <asp:TextBox ID="txtRCV_QTY" runat="server" MaxLength="7" CssClass="form-control"></asp:TextBox>
                    </div>

                <asp:Button ID="cmdSave" runat="server"
                    CssClass="btn btn-success" Text="SAVE" OnClick="cmdSave_Click">
                </asp:Button>

            </asp:panel>
        </div>
</asp:Content>
