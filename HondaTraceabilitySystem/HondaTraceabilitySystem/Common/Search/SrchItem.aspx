<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SrchItem.aspx.cs" Inherits="HondaTraceabilitySystem.Common.Search.SrchItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ITEM Search</title>

    <link href="../../Content/bootstrap.css" type="text/css" rel="stylesheet" />
    <link href="../../Content/site.css" type="text/css" rel="stylesheet" />

</head>
<body style="height: 100%;">
    <form id="form1" runat="server" style="height: 100%;">
        <!-- Header -->
    <div style="position: absolute; top: 0; left: 0; width: 100%">
        <table width="100%" style="table-layout: fixed" cellspacing="0" cellpadding="0" border="0">
            <tr valign="top" style="width: 100%">
                <td>
                    <table style="width: 100%" border="0" cellspacing="0">
                        <tr>
                            <td align="right" valign="bottom" width="10px">
                                &nbsp;&nbsp;
                            </td>
                            <td align="left" valign="bottom" height="30px" width="200px">
                               
                                <h3><asp:label	 id="flblTitle" runat="server" CssClass="label label-success">LblTitle</asp:label>
                                    </h3>
                            </td>
                            <td align="left" valign="bottom" width="150px">
                                <h3><asp:label id="flblCount" runat="server" CssClass="label label-danger" >[flblCount =&nbsp;</asp:label>
                                    </h3>
                            </td>
                            <td rowspan="2" style="width: 240px;">
                                <table width="100%" border="0" cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td style="width: 50px">
                                            &nbsp;
                                        </td>
                                        <td style="width: 85px;" valign="baseline">
                                         <%--   <asp:button id="imgDisp"  Runat="server" onclick="imgDisp_Click" CssClass="btn btn-info" Text="DISPLAY">
											</asp:button>--%>
                                        </td>
                          
                                        <td>
                                            &nbsp;
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>

                    </table>
                </td>
            </tr>
        </table>
    </div>
    <div style="width: 100%;">
        <table width="100%" cellspacing="0" cellpadding="0" border="0" >
           
            <!-- Detail -->
            <tr valign="top">
                <td>
                    <div class="w-100">
                         <asp:textbox id="lblMsg"  tabIndex="-1" runat="server" 
            Width="704px" BorderStyle="None" BackColor="Transparent"  AUTOCOMPLETE="off" MaxLength="999" Font-Bold="True" 
            ReadOnly="True" ForeColor="Red"></asp:textbox>
                    </div>
                     <%--  <div class="form-inline"> 
                        
                           <asp:Label ID="flblITEM_NO" runat="server"  Text="品目コード" ></asp:Label>
                        <asp:TextBox ID="txtITEM_NO" runat="server"  MaxLength="20" CssClass="form-control" AUTOCOMPLETE="off"></asp:TextBox>
                        <asp:Label ID="flblITEM_DESC" runat="server"  Text="品目名称"></asp:Label>
                        <asp:TextBox ID="txtITEM_DESC" runat="server" MaxLength="50" CssClass="form-control" AUTOCOMPLETE="off"></asp:TextBox>
                        <asp:Label ID="flblITEM_TYPE"  runat="server" >品目区分</asp:Label>
                        <asp:DropDownList ID="ddlITEM_TYPE" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                      </div>--%>
                    <br />
                        <asp:GridView ID="dgvSearch" runat="server" BackColor="White"  AutoGenerateColumns="False"
                            OnSorting="dgvSearch_Sorting" OnSelectedIndexChanged="dgvSearch_SelectedIndexChanged"
                            AllowSorting="True" OnPageIndexChanging="dgvSearch_PageIndexChanging" OnRowCreated="dgvSearch_RowCreated"
                            AllowPaging="False" OnRowDataBound="dgvSearch_RowDataBound" >
                            <Columns>
                                <asp:CommandField ShowSelectButton="True" />
                                <asp:TemplateField HeaderText="№">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex  + 1%>
                                    </ItemTemplate>
                                      <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" width="24px" />
                                     <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="24px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="品目コード">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblItemCd" runat="server"  Text='<%# Bind("PART_NO") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("PART_NO") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <HeaderStyle  width="200px" />
                                     <ItemStyle  Width="200px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="品目名称" >
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblItemDesc" runat="server"  Text='<%# Bind("PART_NAME") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("PART_NAME") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                     <HeaderStyle  width="300px" />
                                     <ItemStyle  Width="300px"/>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    

                    <%--<script type="text/javascript">
                    var   obj=window.document.getElementById("<%= dgvSearch.ClientID%>");   
                    if   (obj   !=   null)   
                    {   
                     obj.parentNode.className = "fakeContainer";

                        (function() {
                            var start = new Date();
                            superTable("<%= dgvSearch.ClientID%>", {  
                            
                               onFinish : function () 
                               {                                      
                                    return;         
                               }
                            });
                        })(); 
                    }                    
                    </script>--%>

                </td>
            </tr>
        </table>
    </div>
    <!-- Footer -->

    </form>
</body>
</html>
