<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AeOnProdCrabkShaftRpt.aspx.cs" Inherits="HondaTraceabilitySystem.AeOnProdCrabkShaftRpt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AE Crank Shaft Summary Report - Honda Traceability System</title>

    <link href="Content/bootstrap.css" type="text/css" rel="stylesheet" />
    <link href="Content/site.css" type="text/css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.js" type="text/javascript"></script>
    <script src="Scripts/bootstrap.js" type="text/javascript"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar navbar-default navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" runat="server" href="~/">Honda Traceability System</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li id="Menu00" runat="server" class="dropdown">
                            <a href="#" class="dropdown-toggle" runat="server" data-toggle="dropdown" role="button" aria-expanded="false">Master <span class="caret"></span></a>
                            <ul class="dropdown-menu" role="menu">
                                <li id="Menu01" runat="server"><a runat="server" href="~/MstItemMnt">Part Master</a></li>
                                <li id="Menu02" runat="server"><a runat="server" href="~/MstMfgBomMnt">BOM Master</a></li>
                                <li id="Menu03" runat="server"><a runat="server" href="~/MstUserGroupMnt">User Group Master</a></li>
                                <li id="Menu04" runat="server"><a runat="server" href="~/MstUserMnt">User Master</a></li>
                                <li id="Menu05" runat="server"><a runat="server" href="~/MstCalendarMnt">Calendar Master</a></li>
                                <li id="Menu06" runat="server"><a runat="server" href="~/MstMgmtLevelMnt">Management Level Master</a></li>
                                <li id="Menu07" runat="server"><a runat="server" href="~/MstDeptMnt">Department Master</a></li>
                                <li id="Menu08" runat="server"><a runat="server" href="~/MstProcessMnt">Process Master</a></li>
                                <li id="Menu09" runat="server"><a runat="server" href="~/MstLocationMnt">Location Master</a></li>
                            </ul>
                        </li>
                        <li id="Menu10" runat="server" class="dropdown">
                            <a href="#" class="dropdown-toggle" runat="server" data-toggle="dropdown" role="button" aria-expanded="false">PE/MS <span class="caret"></span></a>
                            <ul class="dropdown-menu" role="menu">
                                <li id="Menu11" runat="server"><a runat="server" href="~/ImpPlanProdOrd">Import Production Order</a></li>
                                <li id="Menu12" runat="server"><a runat="server" href="~/UpdPlanProdOrd">Update Production Order</a></li>
                                <li id="Menu21" runat="server"><a runat="server" href="~/ImpPurRec">Import Receiving</a></li>
                                <li id="Menu22" runat="server"><a runat="server" href="~/PCPurRec">Receiving</a></li>
                                <li id="Menu23" runat="server"><a runat="server" href="~/PurRecSumm">Receiving Summary</a></li>
                                <li id="Menu24" runat="server"><a runat="server" href="~/ImpDelPlan">Delivery Plan</a></li>
                                <li id="Menu25" runat="server"><a runat="server" href="~/PickingList">Picking List</a></li>
                                <li id="Menu31" runat="server"><a runat="server" href="~/FGDelPlan">FG Delivery Plan</a></li>
                                <li id="Menu32" runat="server"><a runat="server" href="~/FGPCRec">FG Receiving</a></li>
                                <li id="Menu33" runat="server"><a runat="server" href="~/FGRecSumm">FG Receiving Summary</a></li>
                                <li id="Menu34" runat="server"><a runat="server" href="~/FGOnRpt">FG Online Summary Report</a></li>
                                <li id="Menu35" runat="server"><a runat="server" href="~/FGOffRpt">FG Offline Summary Report</a></li>
                                <li id="Menu36" runat="server"><a runat="server" href="~/FGDelSumm">FG Delivery Summary</a></li>
                                <li id="Menu37" runat="server"><a runat="server" href="~/StkProdRpt">Prod & Stock Report</a></li>
                            </ul>
                        </li>
                        <li id="Menu50" runat="server" class="dropdown">
                            <a href="#" class="dropdown-toggle" runat="server" data-toggle="dropdown" role="button" aria-expanded="false">MC <span class="caret"></span></a>
                            <ul class="dropdown-menu" role="menu">
                                <li id="Menu51" runat="server"><a runat="server" href="~/FeOnProdRpt">H Main Summary Report</a></li>
                                <li id="Menu52" runat="server"><a runat="server" href="~/FeOnProdRpt">H Sub Summary Report</a></li>
                                <li id="Menu53" runat="server"><a runat="server" href="~/FeOnProdRpt">Balance Summary Report</a></li>
                                <%--<li id="Menu54" runat="server"><a runat="server" href="~/MCDaily">Daily Generate</a></li>--%>
                            </ul>
                        </li>
                        <li id="Menu40" runat="server" class="dropdown">
                            <a href="#" class="dropdown-toggle" runat="server" data-toggle="dropdown" role="button" aria-expanded="false">FE <span class="caret"></span></a>
                            <ul class="dropdown-menu" role="menu">
                                <li id="Menu41" runat="server"><a runat="server" href="~/FePCRec">FE Receiving</a></li>
                                <li id="Menu42" runat="server"><a runat="server" href="~/FeOnProd">Online Production</a></li>
                                <li id="Menu43" runat="server"><a runat="server" href="~/FeOnProdRpt">Online Summary Report</a></li>
                                <li id="Menu44" runat="server"><a runat="server" href="~/FeOnProd2">Middle Lot Production</a></li>
                                <%--<li id="Menu45" runat="server"><a runat="server" href="~/FeOnSwap">Middle Lot Swap</a></li>--%>
                                <li id="Menu45" runat="server"><a runat="server" href="~/FeOffProd">Offline Production</a></li>
                                <li id="Menu46" runat="server"><a runat="server" href="~/FeOffProdRpt">Offline Summary Report</a></li>
                                <%--<li id="Menu48" runat="server"><a runat="server" href="~/FeOffSwap">Production Swap</a></li>--%>
                                <li id="Menu47" runat="server"><a runat="server" href="~/FePartCtrlTag">Part Control Tag</a></li>
                                <li id="Menu48" runat="server"><a runat="server" href="~/FeStkProdRpt">Prod & Stock Report</a></li>
                            </ul>
                        </li>
                        <li id="Menu60" runat="server" class="dropdown">
                            <a href="#" class="dropdown-toggle" runat="server" data-toggle="dropdown" role="button" aria-expanded="false">AE <span class="caret"></span></a>
                            <ul class="dropdown-menu" role="menu">
                                <li id="Menu61" runat="server"><a runat="server" href="~/AeOnProdBlockRpt">Online Block Summary Report</a></li>
                                <li id="Menu62" runat="server"><a runat="server" href="~/AeOnProdConnRodRpt">Online Conn Rod Summary Report</a></li>
                                <li id="Menu63" runat="server"><a runat="server" href="~/AeOnProdCrabkShaftRpt">Online Crank Shaft Summary Report</a></li>
                                <li id="Menu64" runat="server"><a runat="server" href="~/AeOnProdHeadRpt">Online Head Summary Report</a></li>
                                <li id="Menu65" runat="server"><a runat="server" href="~/AeOffProdRpt">Offline Summary Report</a></li>
                               
                            </ul>
                        </li>
                    </ul>
                    <ul class="nav navbar-nav navbar-right">
                        <li>
                            <button type="button" style="padding-top: 13px; padding-bottom: 13px;" class="btn btn-info" onclick="location.href = 'MstUserMnt.aspx';">
                            <span class="glyphicon glyphicon-user" aria-hidden="true"></span>
                            <asp:label ID="lblUserName" runat="server">USER NAME</asp:label></button>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="container body-content">
            <table style="width: 100%" border="0" cellspacing="0">
            <tr>
                <td style="width: 200px; height: 45px;" valign="top" colspan="2">
                </td>
                <td style="width: 180px;">
                    <table width="100%" border="0">
                        <tr>
                            <td width="90" valign="bottom">
                                <asp:Button ID="cmdDisp" runat="server" CssClass="btn btn-primary" Text="DISPLAY" OnClick="cmdDisp_Click"></asp:Button>
                            </td>
                            <td style="padding-left: 5px" width="90" valign="bottom">
                                <asp:Button ID="cmdPrint"  runat="server" CssClass="btn btn-success" Text="PRINT" OnClick="cmdPrint_Click"></asp:Button>
                            </td>
                        </tr>
                    </table>
                </td>
                <td style="width: 200px;">
                    <table width="100%" border="0">
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td valign="bottom">
                                <asp:LinkButton runat="server" CssClass="btn btn-info" ID="imgReturn" OnClick="imgReturn_Click">
                                  <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"> BACK TO MENU</span>
                                </asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="width: 200px; height: 45px;" valign="top" colspan="2">
                    <asp:Label ID="flblTitle" runat="server" Style="height: 23px;" CssClass="TitleLabel"
                            Width="500px">Online Crank Shaft Summary Report</asp:Label>
                </td>
            </tr>
            </table>
        </div>
        <div class="container body-content">
            <h4><asp:Label ID="lblMsg" runat="server" BackColor="Transparent"></asp:Label></h4>
        </div>
        <div style="WIDTH: 1073px; POSITION: relative; HEIGHT: 470px; left: 0px; top: 0px;" >
            <asp:panel id="pnlKey" 
                    style="Z-INDEX: 103; LEFT: 45px; POSITION: absolute; TOP: 5px; width: 725px; height: 30px;" 
                    runat="server">

                <asp:Label ID="flblPROCESS" runat="server" 
                        style=" LEFT: 8px; POSITION: absolute; TOP: 65px" 
                        Width="80px" Visible="False">Process:</asp:Label>
                <asp:DropDownList ID="ddlPROCESS" runat="server" CssClass="form-control" Height="30px" Width="150px" 
                        style=" LEFT: 100px; POSITION: absolute; TOP: 60px" AutoPostBack="True" OnSelectedIndexChanged="ddlPROCESS_SelectedIndexChanged" Visible="False" >
                    </asp:DropDownList>

            </asp:panel>

            <asp:panel id="pnlDetail" 
                    style="Z-INDEX: 102; LEFT: 7px; POSITION: absolute; TOP: 0px; height: 300px; width: 1000px;" 
                    runat="server">

                <%--<asp:CheckBox ID="chkALL_SEL" runat="server" style="LEFT: 12px; POSITION: absolute; TOP: 56px; width:127px;" 
                        CssClass="fi_mtitle" Text="All Selected" AutoPostBack="True" oncheckedchanged="chkALL_SEL_CheckedChanged" 
                        />--%>

                <asp:GridView ID="gdvDetail" runat="server"
                    AutoGenerateColumns="False" BorderColor="#999999"
                    BorderWidth="1px" AllowPaging="True"
                    onrowcreated="gdvDetail_RowCreated"
                    onpageindexchanging="gdvDetail_PageIndexChanging"
                    AutoGenerateSelectButton="False" >
                    <Columns>
                        <asp:TemplateField HeaderText="AE_Assy_Crank_No">                                
                            <ItemTemplate>
                                <asp:TextBox ID="lbl_AE_Assy_Crank_No" runat="server" CssClass="form-control" 
                                    Text='<%# Bind("AE_Assy_Crank_No") %>' ToolTip='<%# Bind("AE_Assy_Crank_No") %>' 
                                    ReadOnly="True" TabIndex="-1"></asp:TextBox>
                            </ItemTemplate>
                            <ItemStyle width="100px"/>
                            <HeaderStyle width="100px"/>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Model">
                            <ItemTemplate>
                                <asp:TextBox ID="lbl_Model" runat="server" CssClass="form-control" 
                                    ReadOnly="true" TabIndex="-1" Text='<%# Bind("Model") %>' 
                                    ToolTip='<%# Bind("Model") %>'></asp:TextBox>
                            </ItemTemplate>
                            <HeaderStyle width="200px" />
                            <ItemStyle width="200px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Part_No">
                            <ItemTemplate>
                                <asp:TextBox ID="lbl_Part_No" runat="server" CssClass="form-control" 
                                    ReadOnly="true" TabIndex="-1" Text='<%# Bind("Part_No") %>' 
                                    ToolTip='<%# Bind("Part_No") %>'></asp:TextBox>
                            </ItemTemplate>
                            <HeaderStyle width="200px" />
                            <ItemStyle width="200px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Engine_No">
                            <ItemTemplate>
                                <asp:TextBox ID="lbl_Engine_No" runat="server" CssClass="form-control" 
                                    ReadOnly="true" TabIndex="-1" Text='<%# Bind("Engine_No") %>' 
                                    ToolTip='<%# Bind("Engine_No") %>'></asp:TextBox>
                            </ItemTemplate>
                            <HeaderStyle width="200px" />
                            <ItemStyle width="200px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Crank_Offline_Lot">
                            <ItemTemplate>
                                <asp:TextBox ID="lbl_Crank_Offline_Lot" runat="server" CssClass="form-control" 
                                    ReadOnly="true" TabIndex="-1" Text='<%# Bind("Crank_Offline_Lot") %>' 
                                    ToolTip='<%# Bind("Crank_Offline_Lot") %>'></asp:TextBox>
                            </ItemTemplate>
                            <HeaderStyle width="200px" />
                            <ItemStyle width="200px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Create_Date">
                            <ItemTemplate>
                                <asp:TextBox ID="lbl_Create_Date" runat="server" CssClass="form-control" 
                                    ReadOnly="true" TabIndex="-1" Text='<%# Bind("Create_Date") %>' 
                                    ToolTip='<%# Bind("Create_Date") %>'></asp:TextBox>
                            </ItemTemplate>
                            <HeaderStyle width="200px" />
                            <ItemStyle width="200px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Create_By">
                            <ItemTemplate>
                                <asp:TextBox ID="lbl_Create_By" runat="server" CssClass="form-control" 
                                    ReadOnly="true" TabIndex="-1" Text='<%# Bind("Create_By") %>' 
                                    ToolTip='<%# Bind("Create_By") %>'></asp:TextBox>
                            </ItemTemplate>
                            <HeaderStyle width="200px" />
                            <ItemStyle width="200px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Shift">
                            <ItemTemplate>
                                <asp:TextBox ID="lbl_Shift" runat="server" CssClass="form-control" 
                                    ReadOnly="true" TabIndex="-1" Text='<%# Bind("Shift") %>' 
                                    ToolTip='<%# Bind("Shift") %>'></asp:TextBox>
                            </ItemTemplate>
                            <HeaderStyle width="200px" />
                            <ItemStyle width="200px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Model">
                            <ItemTemplate>
                                <asp:TextBox ID="lbl_Flag" runat="server" CssClass="form-control" 
                                    ReadOnly="true" TabIndex="-1" Text='<%# Bind("Flag") %>' 
                                    ToolTip='<%# Bind("Flag") %>'></asp:TextBox>
                            </ItemTemplate>
                            <HeaderStyle width="200px" />
                            <ItemStyle width="200px" />
                        </asp:TemplateField>
                    </Columns>
                    <%--<FooterStyle CssClass="GVFooter" />
                    <PagerStyle CssClass ="GVPager" />
                    <SelectedRowStyle CssClass ="GVSelectedRow" />
                    <HeaderStyle CssClass ="GVHeader" />
                    <AlternatingRowStyle CssClass ="GVAlternatingRow" />
                    <RowStyle CssClass="GVRow" />--%>
                </asp:GridView>

            </asp:panel>
        </div>

    <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Scripts>
            <%--To learn more about bundling scripts in ScriptManager see https://go.microsoft.com/fwlink/?LinkID=301884 --%>
            <%--Framework Scripts--%>
            <%--<asp:ScriptReference Name="MsAjaxBundle" />
            <asp:ScriptReference Name="jquery" />
            <asp:ScriptReference Name="bootstrap" />
            <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
            <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
            <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
            <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
            <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
            <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
            <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
            <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
            <asp:ScriptReference Name="WebFormsBundle" />--%>
            <%--Site Scripts--%>
        </Scripts>
    </asp:ScriptManager>
    </form>
</body>
</html>
