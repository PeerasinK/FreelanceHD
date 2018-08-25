<%@ Page Title="Main Menu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HondaTraceabilitySystem._Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table width="100%" border="0">
        <tr>
            <td width="180" valign="bottom">
            </td>
            <td width="90" valign="bottom">
                <asp:Button ID="imgLogoff" runat="server" CssClass="btn btn-primary" Text="LOG OFF" OnClick="imgLogoff_Click"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <table >
        <tr>
            <td>
                <asp:Label ID="flblTitle" runat="server" CssClass="TitleLabel" Text="Main Menu"
                    Width="330"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <h4><asp:Label ID="lblMsg" runat="server" CssClass="label label-default" BackColor="Transparent"></asp:Label> </h4>
		</div>
    <div class="row">
        <div class="col-md-2">
            <div runat="server" id="MasterMenu" class="list-group" visible="False">
              <a runat="server" href="#" class="list-group-item">Master</a>
              <a runat="server" href="~/MstItemMnt" class="list-group-item">Part Master</a>
              <a runat="server" href="~/MstMfgBomMnt" class="list-group-item">BOM Master</a>
              <a runat="server" href="~/MstUserGroupMnt" class="list-group-item">User Group Master</a>
              <a runat="server" href="~/MstUserMnt" class="list-group-item">User Master</a>
              <a runat="server" href="~/MstCalendarMnt" class="list-group-item">Calendar Master</a>
              <a runat="server" href="~/MstMgmtLevelMnt" class="list-group-item">Management Level Master</a>
              <a runat="server" href="~/MstDeptMnt" class="list-group-item">Department Master</a>
              <a runat="server" href="~/MstProcessMnt" class="list-group-item">Process Master</a>
              <a runat="server" href="~/MstLocationMnt" class="list-group-item">Location Master</a>
            </div>
        </div>
        <div class="col-md-2">
            <div runat="server" id="PEMSAdminMenu" class="list-group" visible="False">
              <a runat="server" href="#" class="list-group-item">PE/MS</a>
              <a runat="server" href="~/ImpPlanProdOrd" class="list-group-item">Import Production Order</a>
              <a runat="server" href="~/UpdPlanProdOrd" class="list-group-item">Update Production Order</a>
              <a runat="server" href="~/ImpPurRec" class="list-group-item">Import Receiving</a>
              <a runat="server" href="~/PCPurRec" class="list-group-item">Receiving</a>
              <a runat="server" href="~/PurRecSumm" class="list-group-item">Receiving Summary</a>
              <a runat="server" href="~/ImpDelPlan" class="list-group-item">Delivery Plan</a>
              <a runat="server" href="~/PickingList" class="list-group-item">Picking List</a>
              <a runat="server" href="~/FGDelPlan" class="list-group-item">FG Delivery Plan</a>
              <a runat="server" href="~/FGPCRec" class="list-group-item">FG Receiving</a>
              <a runat="server" href="~/FGRecSumm" class="list-group-item">FG Receiving Summary</a>
              <a runat="server" href="~/FGOnRpt" class="list-group-item">FG Online Summary Report</a>
              <a runat="server" href="~/FGOffRpt" class="list-group-item">FG Offline Summary Report</a>
              <a runat="server" href="~/FGDelSumm" class="list-group-item">FG Delivery Summary</a>
              <a runat="server" href="~/StkProdRpt" class="list-group-item">Prod & Stock Report</a>
            </div>
            <div runat="server" id="PEMSMenu" class="list-group" visible="False">
              <a runat="server" href="#" class="list-group-item">PE/MS</a>
              <a runat="server" href="~/PCPurRec" class="list-group-item">Receiving</a>
              <a runat="server" href="~/PurRecSumm" class="list-group-item">Receiving Summary</a>
              <a runat="server" href="~/PickingList" class="list-group-item">Picking List</a>
                <a runat="server" href="~/FGPCRec" class="list-group-item">FG Receiving</a>
              <a runat="server" href="~/FGRecSumm" class="list-group-item">FG Receiving Summary</a>
              <a runat="server" href="~/FGOnRpt" class="list-group-item">FG Online Summary Report</a>
              <a runat="server" href="~/FGOffRpt" class="list-group-item">FG Offline Summary Report</a>
              <a runat="server" href="~/FGDelSumm" class="list-group-item">FG Delivery Summary</a>
              <a runat="server" href="~/StkProdRpt" class="list-group-item">Prod & Stock Report</a>
            </div>
        </div>
        <div class="col-md-2">
            <div runat="server" id="MCMenu" class="list-group" visible="False">
              <a runat="server" href="#" class="list-group-item">MC</a>
              <a runat="server" href="~/MCDaily" class="list-group-item">Daily Generate</a>
            </div>
        </div>
        <div class="col-md-2">
            <div runat="server" id="FEMenu" class="list-group" visible="False">
              <a runat="server" href="#" class="list-group-item">FE</a>
              <a runat="server" href="~/FePCRec" class="list-group-item">FE Receiving</a>
              <a runat="server" href="~/FeOnProd" class="list-group-item">Online Production</a>
              <a runat="server" href="~/FeOnProdRpt" class="list-group-item">Online Summary Report</a>
              <a runat="server" href="~/FeOnProd2" class="list-group-item">Middle Lot Production</a>
              <%--<a runat="server" href="~/FeOnSwap" class="list-group-item">Middle Lot Swap</a>--%>
              <a runat="server" href="~/FeOffProd" class="list-group-item">Offline Production</a>
              <a runat="server" href="~/FeOffProdRpt" class="list-group-item">Offline Summary Report</a>
              <%--<a runat="server" href="~/FeOffSwap" class="list-group-item">Production Swap</a>--%>
              <a runat="server" href="~/FePartCtrlTag" class="list-group-item">Part Control Tag</a>
              <a runat="server" href="~/FeStkProdRpt" class="list-group-item">Prod & Stock Report</a>
            </div>
        </div>
        <div class="col-md-2">
            <div runat="server" id="AEMenu" class="list-group" visible="False">
              <a runat="server" href="#" class="list-group-item">AE</a>
              <a runat="server" href="~/AeOnProdBlockRpt" class="list-group-item">Online Block Summary Report</a>
              <a runat="server" href="~/AeOnProdConnRodRpt" class="list-group-item">Online Conn Rod Summary Report</a>
              <a runat="server" href="~/AeOnProdCrabkShaftRpt" class="list-group-item">Online Crank Shaft Summary Report</a>
              <a runat="server" href="~/AeOnProdHeadRpt" class="list-group-item">Online Head Summary Report</a>
              <a runat="server" href="~/AeOffProdRpt" class="list-group-item">Offline Summary Report</a>
            </div>
        </div>

    </div>
</asp:Content>