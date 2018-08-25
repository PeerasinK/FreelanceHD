<%@ Page Title="FG Receiving" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FGPCRec.aspx.cs" Inherits="HondaTraceabilitySystem.FGPCRec" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <table >
        <tr>
            <td>
                <asp:Label ID="flblTitle" runat="server" CssClass="TitleLabel" Text="Receiving"
                    Width="330">FE Receiving</asp:Label>
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
				
		        <asp:Label ID="flblTYPE" runat="server" 
                        style=" LEFT: 8px; POSITION: absolute; TOP: 15px" 
                        Width="80px">Department:</asp:Label>
                <asp:DropDownList ID="ddlTYPE" runat="server" CssClass="form-control" Height="30px" Width="150px" 
                        style=" LEFT: 100px; POSITION: absolute; TOP: 10px" AutoPostBack="True" >
                    </asp:DropDownList>
                
            </asp:panel>

            <asp:panel id="pnlDetail" style="Z-INDEX: 102; LEFT: 8px; POSITION: absolute; TOP: 85px; width: 725px; height: 300px;" 
                    runat="server">

                <div class="form-group">
                    <asp:Label ID="flblLOT_NO" runat="server" >KD Lot No</asp:Label>
                        <asp:TextBox ID="txtLOT_NO" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="flblDEL_TYPE" runat="server" >Del Type</asp:Label>
                        <asp:TextBox ID="txtDEL_TYPE" runat="server" CssClass="form-control" MaxLength="3"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="flblLOT_NO2" runat="server" >FG Lot No</asp:Label>
                        <asp:TextBox ID="txtLOT_NO2" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

            </asp:panel>
        </div>
</asp:Content>
