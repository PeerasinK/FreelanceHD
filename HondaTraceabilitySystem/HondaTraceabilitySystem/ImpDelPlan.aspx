<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImpDelPlan.aspx.cs" Inherits="HondaTraceabilitySystem.ImpDelPlan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delivery Plan - Honda Traceability System</title>

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
                                <%--<li id="Menu51" runat="server"><a runat="server" href="~/FeOnProdRpt">H Main Summary Report</a></li>
                                <li id="Menu52" runat="server"><a runat="server" href="~/FeOnProdRpt">H Sub Summary Report</a></li>
                                <li id="Menu53" runat="server"><a runat="server" href="~/FeOnProdRpt">Balance Summary Report</a></li>--%>
                                <li id="Menu54" runat="server"><a runat="server" href="~/MCDaily">Daily Generate</a></li>
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
                                <asp:Button ID="cmdUpdate" runat="server" CssClass="btn btn-success" Text="UPDATE" OnClick="cmdUpdate_Click"></asp:Button>
                            </td>
                            <td style="padding-left: 5px" width="90" valign="bottom">
                                <asp:Button ID="cmdCancel"  runat="server" CssClass="btn btn-warning" Text="CANCEL" OnClick="cmdCancel_Click"></asp:Button>
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
                            Width="330px">Delivery Plan</asp:Label>
                </td>
            </tr>
            </table>
        </div>
        <div class="container body-content">
            <h4><asp:Label ID="lblMsg" runat="server" BackColor="Transparent"></asp:Label></h4>
        </div>
        <div style="WIDTH: 1073px; POSITION: relative; HEIGHT: 470px; left: 0px; top: 0px;" >
            <asp:panel id="pnlKey" 
                    style="Z-INDEX: 103; LEFT: 45px; POSITION: absolute; TOP: 5px; width: 725px; height: 50px;" 
                    runat="server">
				
				<asp:Label ID="flblTYPE" runat="server" 
                        style=" LEFT: 8px; POSITION: absolute; TOP: 15px" 
                        Width="80px">Department:</asp:Label>
                <asp:DropDownList ID="ddlTYPE" runat="server" CssClass="form-control" Height="35px" Width="150px" 
                        style=" LEFT: 100px; POSITION: absolute; TOP: 10px" AutoPostBack="True" >
                    </asp:DropDownList>
                           
                <asp:Label ID="flblUPLOAD" runat="server" 
                        style=" LEFT: 8px; POSITION: absolute; TOP: 65px" 
                        Width="80px">Excel File:</asp:Label>
                <asp:FileUpload ID="FileUpload1" runat="server" 
                        style="position: absolute; top: 60px; left: 100px; height: 30px; width: 257px;"/>

            </asp:panel>

            <asp:panel id="pnlDetail" 
                    style="Z-INDEX: 102; LEFT: 7px; POSITION: absolute; TOP: 120px; height: 300px; width: 1000px;" 
                    runat="server">

                <asp:GridView ID="gdvDetail" runat="server"
                    AutoGenerateColumns="False" BorderColor="#999999" 
                    BorderWidth="1px" AllowPaging="True" PageSize="20" 
                    onrowcreated="gdvDetail_RowCreated"  >
                    <Columns>
                                <asp:TemplateField HeaderText="Types">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblTypes" runat="server"  Text='<%# Bind("Types") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Types") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="100px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="150px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Plan_Date">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblPlan_Date" runat="server"  Text='<%# Bind("Plan_Date") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Plan_Date") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="200px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Vendor">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblVendor" runat="server"  Text='<%# Bind("Vendor") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Vendor") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="200px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Dest">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblDest" runat="server"  Text='<%# Bind("Dest") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Dest") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="100px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="150px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Model">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblModel" runat="server"  Text='<%# Bind("Model") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Model") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="200px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Part_No">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblPart_No" runat="server"  Text='<%# Bind("Part_No") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Part_No") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="200px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="1">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl1" runat="server"  Text='<%# Bind("1") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("1") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="2">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl2" runat="server"  Text='<%# Bind("2") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("2") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="3">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl3" runat="server"  Text='<%# Bind("3") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("3") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="4">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl4" runat="server"  Text='<%# Bind("4") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("4") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="5">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl5" runat="server"  Text='<%# Bind("5") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("5") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="6">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl6" runat="server"  Text='<%# Bind("6") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("6") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="7">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl7" runat="server"  Text='<%# Bind("7") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("7") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="8">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl8" runat="server"  Text='<%# Bind("8") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("8") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="9">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl9" runat="server"  Text='<%# Bind("9") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("9") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="10">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl10" runat="server"  Text='<%# Bind("10") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("10") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="11">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl11" runat="server"  Text='<%# Bind("11") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("11") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="12">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl12" runat="server"  Text='<%# Bind("12") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("12") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="13">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl13" runat="server"  Text='<%# Bind("13") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("13") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="14">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl14" runat="server"  Text='<%# Bind("14") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("14") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="15">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl15" runat="server"  Text='<%# Bind("15") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("15") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="16">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl16" runat="server"  Text='<%# Bind("16") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("16") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="17">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl17" runat="server"  Text='<%# Bind("17") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("17") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="18">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl18" runat="server"  Text='<%# Bind("18") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("18") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="19">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl19" runat="server"  Text='<%# Bind("19") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("19") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="20">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl20" runat="server"  Text='<%# Bind("20") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("20") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="21">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl21" runat="server"  Text='<%# Bind("21") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("21") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="22">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl22" runat="server"  Text='<%# Bind("22") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("22") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="23">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl23" runat="server"  Text='<%# Bind("23") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("23") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="24">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl24" runat="server"  Text='<%# Bind("24") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("24") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="25">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl25" runat="server"  Text='<%# Bind("25") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("25") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="26">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl26" runat="server"  Text='<%# Bind("26") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("26") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="27">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl27" runat="server"  Text='<%# Bind("27") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("27") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="28">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl28" runat="server"  Text='<%# Bind("28") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("28") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="29">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl29" runat="server"  Text='<%# Bind("29") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("29") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="30">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl30" runat="server"  Text='<%# Bind("30") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("30") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="31">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl31" runat="server"  Text='<%# Bind("31") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("31") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P1">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP1" runat="server"  Text='<%# Bind("P1") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P1") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P2">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP2" runat="server"  Text='<%# Bind("P2") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P2") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P3">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP3" runat="server"  Text='<%# Bind("P3") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P3") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P4">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP4" runat="server"  Text='<%# Bind("P4") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P4") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P5">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP5" runat="server"  Text='<%# Bind("P5") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P5") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P6">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP6" runat="server"  Text='<%# Bind("P6") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P6") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P7">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP7" runat="server"  Text='<%# Bind("P7") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P7") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P8">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP8" runat="server"  Text='<%# Bind("P8") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P8") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P9">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP9" runat="server"  Text='<%# Bind("P9") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P9") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P10">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP10" runat="server"  Text='<%# Bind("P10") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P10") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P11">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP11" runat="server"  Text='<%# Bind("P11") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P11") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P12">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP12" runat="server"  Text='<%# Bind("P12") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P12") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P13">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP13" runat="server"  Text='<%# Bind("P13") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P13") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P14">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP14" runat="server"  Text='<%# Bind("P14") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P14") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P15">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP15" runat="server"  Text='<%# Bind("P15") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P15") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P16">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP16" runat="server"  Text='<%# Bind("P16") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P16") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P17">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP17" runat="server"  Text='<%# Bind("P17") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P17") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P18">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP18" runat="server"  Text='<%# Bind("P18") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P18") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P19">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP19" runat="server"  Text='<%# Bind("P19") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P19") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P20">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP20" runat="server"  Text='<%# Bind("P20") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P20") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P21">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP21" runat="server"  Text='<%# Bind("P21") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P21") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P22">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP22" runat="server"  Text='<%# Bind("P22") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P22") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P23">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP23" runat="server"  Text='<%# Bind("P23") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P23") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P24">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP24" runat="server"  Text='<%# Bind("P24") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P24") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P25">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP25" runat="server"  Text='<%# Bind("P25") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P25") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P26">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP26" runat="server"  Text='<%# Bind("P26") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P26") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P27">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP27" runat="server"  Text='<%# Bind("P27") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P27") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P28">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP28" runat="server"  Text='<%# Bind("P28") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P28") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P29">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP29" runat="server"  Text='<%# Bind("P29") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P29") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P30">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP30" runat="server"  Text='<%# Bind("P30") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P30") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P31">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP31" runat="server"  Text='<%# Bind("P31") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P31") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H1">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH1" runat="server"  Text='<%# Bind("H1") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H1") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H2">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH2" runat="server"  Text='<%# Bind("H2") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H2") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H3">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH3" runat="server"  Text='<%# Bind("H3") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H3") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H4">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH4" runat="server"  Text='<%# Bind("H4") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H4") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H5">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH5" runat="server"  Text='<%# Bind("H5") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H5") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H6">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH6" runat="server"  Text='<%# Bind("H6") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H6") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H7">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH7" runat="server"  Text='<%# Bind("H7") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H7") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H8">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH8" runat="server"  Text='<%# Bind("H8") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H8") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H9">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH9" runat="server"  Text='<%# Bind("H9") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H9") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H10">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH10" runat="server"  Text='<%# Bind("H10") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H10") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H11">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH11" runat="server"  Text='<%# Bind("H11") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H11") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H12">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH12" runat="server"  Text='<%# Bind("H12") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H12") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H13">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH13" runat="server"  Text='<%# Bind("H13") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H13") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H14">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH14" runat="server"  Text='<%# Bind("H14") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H14") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H15">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH15" runat="server"  Text='<%# Bind("H15") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H15") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H16">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH16" runat="server"  Text='<%# Bind("H16") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H16") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H17">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH17" runat="server"  Text='<%# Bind("H17") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H17") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H18">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH18" runat="server"  Text='<%# Bind("H18") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H18") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H19">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH19" runat="server"  Text='<%# Bind("H19") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H19") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H20">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH20" runat="server"  Text='<%# Bind("H20") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H20") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H21">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH21" runat="server"  Text='<%# Bind("H21") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H21") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H22">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH22" runat="server"  Text='<%# Bind("H22") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H22") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H23">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH23" runat="server"  Text='<%# Bind("H23") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H23") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H24">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH24" runat="server"  Text='<%# Bind("H24") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H24") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H25">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH25" runat="server"  Text='<%# Bind("H25") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H25") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H26">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH26" runat="server"  Text='<%# Bind("H26") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H26") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H27">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH27" runat="server"  Text='<%# Bind("H27") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H27") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H28">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH28" runat="server"  Text='<%# Bind("H28") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H28") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H29">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH29" runat="server"  Text='<%# Bind("H29") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H29") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H30">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH30" runat="server"  Text='<%# Bind("H30") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H30") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H31">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH31" runat="server"  Text='<%# Bind("H31") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H31") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B1">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB1" runat="server"  Text='<%# Bind("B1") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B1") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B2">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB2" runat="server"  Text='<%# Bind("B2") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B2") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B3">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB3" runat="server"  Text='<%# Bind("B3") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B3") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B4">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB4" runat="server"  Text='<%# Bind("B4") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B4") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B5">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB5" runat="server"  Text='<%# Bind("B5") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B5") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B6">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB6" runat="server"  Text='<%# Bind("B6") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B6") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B7">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB7" runat="server"  Text='<%# Bind("B7") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B7") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B8">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB8" runat="server"  Text='<%# Bind("B8") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B8") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B9">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB9" runat="server"  Text='<%# Bind("B9") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B9") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B10">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB10" runat="server"  Text='<%# Bind("B10") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B10") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B11">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB11" runat="server"  Text='<%# Bind("B11") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B11") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B12">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB12" runat="server"  Text='<%# Bind("B12") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B12") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B13">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB13" runat="server"  Text='<%# Bind("B13") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B13") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B14">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB14" runat="server"  Text='<%# Bind("B14") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B14") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B15">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB15" runat="server"  Text='<%# Bind("B15") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B15") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B16">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB16" runat="server"  Text='<%# Bind("B16") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B16") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B17">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB17" runat="server"  Text='<%# Bind("B17") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B17") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B18">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB18" runat="server"  Text='<%# Bind("B18") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B18") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B19">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB19" runat="server"  Text='<%# Bind("B19") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B19") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B20">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB20" runat="server"  Text='<%# Bind("B20") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B20") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B21">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB21" runat="server"  Text='<%# Bind("B21") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B21") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B22">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB22" runat="server"  Text='<%# Bind("B22") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B22") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B23">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB23" runat="server"  Text='<%# Bind("B23") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B23") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B24">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB24" runat="server"  Text='<%# Bind("B24") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B24") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B25">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB25" runat="server"  Text='<%# Bind("B25") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B25") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B26">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB26" runat="server"  Text='<%# Bind("B26") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B26") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B27">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB27" runat="server"  Text='<%# Bind("B27") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B27") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B28">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB28" runat="server"  Text='<%# Bind("B28") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B28") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B29">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB29" runat="server"  Text='<%# Bind("B29") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B29") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B30">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB30" runat="server"  Text='<%# Bind("B30") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B30") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B31">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB31" runat="server"  Text='<%# Bind("B31") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B31") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                        </Columns>
                </asp:GridView>

            </asp:panel>
                        <asp:panel id="Panel2" 
                    style="Z-INDEX: 102; LEFT: 7px; POSITION: absolute; TOP: 420px; height: 300px; width: 1000px;" 
                    runat="server">

                <asp:GridView ID="gdvDetail1" runat="server"
                    AutoGenerateColumns="False" BorderColor="#999999" 
                    BorderWidth="1px" AllowPaging="True" PageSize="20" 
                    onrowcreated="gdvDetail1_RowCreated"  >
                    <Columns>
                                <asp:TemplateField HeaderText="Types">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblTypes" runat="server"  Text='<%# Bind("Types") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Types") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="100px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="150px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Plan_Date">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblPlan_Date" runat="server"  Text='<%# Bind("Plan_Date") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Plan_Date") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="200px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Vendor">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblVendor" runat="server"  Text='<%# Bind("Vendor") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Vendor") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="200px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Dest">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblDest" runat="server"  Text='<%# Bind("Dest") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Dest") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="100px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="150px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Model">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblModel" runat="server"  Text='<%# Bind("Model") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Model") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="200px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Part_No">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblPart_No" runat="server"  Text='<%# Bind("Part_No") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Part_No") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="200px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="1">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl1" runat="server"  Text='<%# Bind("1") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("1") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="2">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl2" runat="server"  Text='<%# Bind("2") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("2") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="3">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl3" runat="server"  Text='<%# Bind("3") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("3") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="4">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl4" runat="server"  Text='<%# Bind("4") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("4") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="5">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl5" runat="server"  Text='<%# Bind("5") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("5") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="6">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl6" runat="server"  Text='<%# Bind("6") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("6") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="7">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl7" runat="server"  Text='<%# Bind("7") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("7") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="8">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl8" runat="server"  Text='<%# Bind("8") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("8") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="9">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl9" runat="server"  Text='<%# Bind("9") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("9") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="10">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl10" runat="server"  Text='<%# Bind("10") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("10") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="11">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl11" runat="server"  Text='<%# Bind("11") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("11") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="12">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl12" runat="server"  Text='<%# Bind("12") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("12") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="13">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl13" runat="server"  Text='<%# Bind("13") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("13") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="14">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl14" runat="server"  Text='<%# Bind("14") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("14") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="15">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl15" runat="server"  Text='<%# Bind("15") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("15") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="16">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl16" runat="server"  Text='<%# Bind("16") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("16") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="17">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl17" runat="server"  Text='<%# Bind("17") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("17") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="18">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl18" runat="server"  Text='<%# Bind("18") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("18") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="19">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl19" runat="server"  Text='<%# Bind("19") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("19") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="20">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl20" runat="server"  Text='<%# Bind("20") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("20") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="21">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl21" runat="server"  Text='<%# Bind("21") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("21") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="22">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl22" runat="server"  Text='<%# Bind("22") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("22") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="23">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl23" runat="server"  Text='<%# Bind("23") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("23") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="24">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl24" runat="server"  Text='<%# Bind("24") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("24") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="25">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl25" runat="server"  Text='<%# Bind("25") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("25") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="26">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl26" runat="server"  Text='<%# Bind("26") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("26") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="27">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl27" runat="server"  Text='<%# Bind("27") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("27") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="28">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl28" runat="server"  Text='<%# Bind("28") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("28") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="29">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl29" runat="server"  Text='<%# Bind("29") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("29") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="30">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl30" runat="server"  Text='<%# Bind("30") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("30") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="31">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lbl31" runat="server"  Text='<%# Bind("31") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("31") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P1">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP1" runat="server"  Text='<%# Bind("P1") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P1") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P2">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP2" runat="server"  Text='<%# Bind("P2") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P2") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P3">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP3" runat="server"  Text='<%# Bind("P3") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P3") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P4">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP4" runat="server"  Text='<%# Bind("P4") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P4") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P5">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP5" runat="server"  Text='<%# Bind("P5") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P5") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P6">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP6" runat="server"  Text='<%# Bind("P6") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P6") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P7">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP7" runat="server"  Text='<%# Bind("P7") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P7") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P8">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP8" runat="server"  Text='<%# Bind("P8") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P8") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P9">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP9" runat="server"  Text='<%# Bind("P9") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P9") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P10">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP10" runat="server"  Text='<%# Bind("P10") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P10") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P11">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP11" runat="server"  Text='<%# Bind("P11") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P11") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P12">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP12" runat="server"  Text='<%# Bind("P12") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P12") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P13">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP13" runat="server"  Text='<%# Bind("P13") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P13") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P14">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP14" runat="server"  Text='<%# Bind("P14") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P14") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P15">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP15" runat="server"  Text='<%# Bind("P15") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P15") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P16">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP16" runat="server"  Text='<%# Bind("P16") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P16") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P17">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP17" runat="server"  Text='<%# Bind("P17") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P17") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P18">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP18" runat="server"  Text='<%# Bind("P18") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P18") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P19">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP19" runat="server"  Text='<%# Bind("P19") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P19") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P20">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP20" runat="server"  Text='<%# Bind("P20") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P20") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P21">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP21" runat="server"  Text='<%# Bind("P21") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P21") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P22">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP22" runat="server"  Text='<%# Bind("P22") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P22") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P23">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP23" runat="server"  Text='<%# Bind("P23") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P23") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P24">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP24" runat="server"  Text='<%# Bind("P24") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P24") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P25">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP25" runat="server"  Text='<%# Bind("P25") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P25") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P26">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP26" runat="server"  Text='<%# Bind("P26") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P26") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P27">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP27" runat="server"  Text='<%# Bind("P27") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P27") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P28">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP28" runat="server"  Text='<%# Bind("P28") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P28") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P29">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP29" runat="server"  Text='<%# Bind("P29") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P29") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P30">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP30" runat="server"  Text='<%# Bind("P30") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P30") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="P31">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblP31" runat="server"  Text='<%# Bind("P31") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("P31") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H1">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH1" runat="server"  Text='<%# Bind("H1") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H1") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H2">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH2" runat="server"  Text='<%# Bind("H2") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H2") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H3">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH3" runat="server"  Text='<%# Bind("H3") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H3") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H4">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH4" runat="server"  Text='<%# Bind("H4") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H4") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H5">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH5" runat="server"  Text='<%# Bind("H5") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H5") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H6">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH6" runat="server"  Text='<%# Bind("H6") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H6") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H7">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH7" runat="server"  Text='<%# Bind("H7") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H7") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H8">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH8" runat="server"  Text='<%# Bind("H8") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H8") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H9">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH9" runat="server"  Text='<%# Bind("H9") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H9") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H10">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH10" runat="server"  Text='<%# Bind("H10") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H10") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H11">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH11" runat="server"  Text='<%# Bind("H11") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H11") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H12">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH12" runat="server"  Text='<%# Bind("H12") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H12") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H13">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH13" runat="server"  Text='<%# Bind("H13") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H13") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H14">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH14" runat="server"  Text='<%# Bind("H14") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H14") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H15">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH15" runat="server"  Text='<%# Bind("H15") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H15") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H16">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH16" runat="server"  Text='<%# Bind("H16") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H16") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H17">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH17" runat="server"  Text='<%# Bind("H17") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H17") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H18">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH18" runat="server"  Text='<%# Bind("H18") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H18") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H19">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH19" runat="server"  Text='<%# Bind("H19") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H19") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H20">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH20" runat="server"  Text='<%# Bind("H20") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H20") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H21">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH21" runat="server"  Text='<%# Bind("H21") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H21") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H22">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH22" runat="server"  Text='<%# Bind("H22") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H22") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H23">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH23" runat="server"  Text='<%# Bind("H23") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H23") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H24">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH24" runat="server"  Text='<%# Bind("H24") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H24") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H25">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH25" runat="server"  Text='<%# Bind("H25") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H25") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H26">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH26" runat="server"  Text='<%# Bind("H26") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H26") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H27">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH27" runat="server"  Text='<%# Bind("H27") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H27") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H28">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH28" runat="server"  Text='<%# Bind("H28") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H28") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H29">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH29" runat="server"  Text='<%# Bind("H29") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H29") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H30">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH30" runat="server"  Text='<%# Bind("H30") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H30") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="H31">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblH31" runat="server"  Text='<%# Bind("H31") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("H31") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B1">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB1" runat="server"  Text='<%# Bind("B1") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B1") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B2">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB2" runat="server"  Text='<%# Bind("B2") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B2") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B3">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB3" runat="server"  Text='<%# Bind("B3") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B3") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B4">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB4" runat="server"  Text='<%# Bind("B4") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B4") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B5">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB5" runat="server"  Text='<%# Bind("B5") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B5") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B6">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB6" runat="server"  Text='<%# Bind("B6") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B6") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B7">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB7" runat="server"  Text='<%# Bind("B7") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B7") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B8">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB8" runat="server"  Text='<%# Bind("B8") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B8") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B9">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB9" runat="server"  Text='<%# Bind("B9") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B9") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B10">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB10" runat="server"  Text='<%# Bind("B10") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B10") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B11">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB11" runat="server"  Text='<%# Bind("B11") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B11") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B12">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB12" runat="server"  Text='<%# Bind("B12") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B12") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B13">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB13" runat="server"  Text='<%# Bind("B13") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B13") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B14">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB14" runat="server"  Text='<%# Bind("B14") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B14") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B15">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB15" runat="server"  Text='<%# Bind("B15") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B15") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B16">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB16" runat="server"  Text='<%# Bind("B16") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B16") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B17">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB17" runat="server"  Text='<%# Bind("B17") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B17") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B18">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB18" runat="server"  Text='<%# Bind("B18") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B18") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B19">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB19" runat="server"  Text='<%# Bind("B19") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B19") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B20">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB20" runat="server"  Text='<%# Bind("B20") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B20") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B21">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB21" runat="server"  Text='<%# Bind("B21") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B21") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B22">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB22" runat="server"  Text='<%# Bind("B22") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B22") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B23">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB23" runat="server"  Text='<%# Bind("B23") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B23") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B24">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB24" runat="server"  Text='<%# Bind("B24") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B24") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B25">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB25" runat="server"  Text='<%# Bind("B25") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B25") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B26">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB26" runat="server"  Text='<%# Bind("B26") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B26") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B27">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB27" runat="server"  Text='<%# Bind("B27") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B27") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B28">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB28" runat="server"  Text='<%# Bind("B28") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B28") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B29">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB29" runat="server"  Text='<%# Bind("B29") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B29") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B30">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB30" runat="server"  Text='<%# Bind("B30") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B30") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="B31">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblB31" runat="server"  Text='<%# Bind("B31") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("B31") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                        </Columns>
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
