<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImpPlanProdOrd.aspx.cs" Inherits="HondaTraceabilitySystem.ImpPlanProdOrd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Import Production Order - Honda Traceability System</title>

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
                            Width="330px">Import Production Order</asp:Label>
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
                        style=" LEFT: 100px; POSITION: absolute; TOP: 10px; right: 475px;" AutoPostBack="True" >
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
                    BorderColor="#999999" BorderWidth="1px" 
                    AllowPaging="True" PageSize="50" 
                    onrowcreated="gdvDetail_RowCreated" Height="991px" OnPageIndexChanging="gdvDetail_PageIndexChanging" AutoGenerateColumns="False"
                     >
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
                                <asp:TemplateField HeaderText="Part_No">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblPart_No" runat="server"  Text='<%# Bind("Part_No") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Part_No") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="200px"/>
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
                                <asp:TemplateField HeaderText="Engine_code">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblEngine_code" runat="server"  Text='<%# Bind("Engine_code") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Engine_code") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="100px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="150px"/>
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
                                <asp:TemplateField HeaderText="Total_Quantity">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblTotal_Quantity" runat="server"  Text='<%# Bind("Total_Quantity") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Total_Quantity") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="120px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Line_No">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblLine_No" runat="server"  Text='<%# Bind("Line_No") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Line_No") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Del_N_2">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblDel_N_2" runat="server"  Text='<%# Bind("Del_N_2") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Del_N_2") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Vendor">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblVendor" runat="server"  Text='<%# Bind("Vendor") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Vendor") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="80px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Dist">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblDist" runat="server"  Text='<%# Bind("Dist") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Dist") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="80px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="PC_No">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblPC_No" runat="server"  Text='<%# Bind("PC_No") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("PC_No") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Block_Qty">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblBlock_Qty" runat="server"  Text='<%# Bind("Block_Qty") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Block_Qty") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="80px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Head_Qty">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblHead_Qty" runat="server"  Text='<%# Bind("Head_Qty") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Head_Qty") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="80px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Van_Original">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblVan_Original" runat="server"  Text='<%# Bind("Van_Original") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Van_Original") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Cy_Cut">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblCy_Cut" runat="server"  Text='<%# Bind("Cy_Cut") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Cy_Cut") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Time_Icd">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblTime_Icd" runat="server"  Text='<%# Bind("Time_Icd") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Time_Icd") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ETD">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblETD" runat="server"  Text='<%# Bind("ETD") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("ETD") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Vessel">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblVessel" runat="server"  Text='<%# Bind("Vessel") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Vessel") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="120px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Part_Delivery">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblPart_Delivery" runat="server"  Text='<%# Bind("Part_Delivery") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Part_Delivery") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Order_No">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblOrder_No" runat="server"  Text='<%# Bind("Order_No") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Order_No") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="120px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Order_Date">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblOrder_Date" runat="server"  Text='<%# Bind("Order_Date") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Order_Date") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Packing_Date">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblPacking_Date" runat="server"  Text='<%# Bind("Packing_Date") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Packing_Date") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Packing_List_To_Ib">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblPacking_List_To_Ib" runat="server"  Text='<%# Bind("Packing_List_To_Ib") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Packing_List_To_Ib") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ETD_Date">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblETD_Date" runat="server"  Text='<%# Bind("ETD_Date") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("ETD_Date") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ETA_Date">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblETA_Date" runat="server"  Text='<%# Bind("ETA_Date") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("ETA_Date") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Ship_By">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblShip_By" runat="server"  Text='<%# Bind("Ship_By") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Ship_By") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="120px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="RTA">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblRTA" runat="server"  Text='<%# Bind("RTA") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("RTA") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Issue_Date">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblIssue_Date" runat="server"  Text='<%# Bind("Issue_Date") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Issue_Date") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="150px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Model_Type">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblModel_Type" runat="server"  Text='<%# Bind("Model_Type") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Model_Type") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="80px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Issue_By">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblIssue_By" runat="server"  Text='<%# Bind("Issue_By") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Issue_By") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="120px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Color">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblColor" runat="server"  Text='<%# Bind("Color") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Color") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="FG_Qty">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblFG_Qty" runat="server"  Text='<%# Bind("FG_Qty") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("FG_Qty") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Del_From">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblDel_From" runat="server"  Text='<%# Bind("Del_From") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Del_From") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="100px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Del_To">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblDel_To" runat="server"  Text='<%# Bind("Del_To") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Del_To") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="100px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Plan_Code">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblPlan_Code" runat="server"  Text='<%# Bind("Plan_Code") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Plan_Code") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="80px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Req_No">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblReq_No" runat="server"  Text='<%# Bind("Req_No") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Req_No") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Remark">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblRemark" runat="server"  Text='<%# Bind("Remark") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("Remark") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="300px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="SEMI_FIXED_FIRST">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblSEMI_FIXED_FIRST" runat="server"  Text='<%# Bind("SEMI_FIXED_FIRST") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("SEMI_FIXED_FIRST") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="SEMI_FIXED_SECOND">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblSEMI_FIXED_SECOND" runat="server"  Text='<%# Bind("SEMI_FIXED_SECOND") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("SEMI_FIXED_SECOND") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ORDER">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblORDER" runat="server"  Text='<%# Bind("ORDER") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("ORDER") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle Width="60px" />
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="DIFF">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblDIFF" runat="server"  Text='<%# Bind("DIFF") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("DIFF") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
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
