<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SrchRole.aspx.cs" Inherits="HondaTraceabilitySystem.Common.Search.SrchRole" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Group</title>

    <link href="../../Content/bootstrap.css" type="text/css" rel="stylesheet" />
    <link href="../../Content/site.css" type="text/css" rel="stylesheet" />

</head>
<body style="height: 100%;">
    <form id="form1" runat="server" style="height:100%;">
         <!-- Header -->
       <div style="position:absolute; top:0; left:0; width:100%">
		<table width="100%" style="position:absolute; top:0px; left:0px" cellspacing="0" cellpadding="0"border="0">
			<tr valign="top" style="width:100%">
				<td>
					<table style=" width: 100%" border="0" cellspacing="0">
						<tr>
							<td align="right" valign="bottom" width="10px">&nbsp;&nbsp;</td>
							<td align="left" valign="bottom" height="30px" width="200px">
								<h3><asp:label	 id="flblTitle" runat="server" CssClass="label label-success">LblTitle</asp:label>
                                    </h3>
							</td>
							<td align="left" valign="bottom" width="150px">
	    						<h3><asp:label id="flblCount" runat="server" CssClass="label label-danger" >[flblCount =&nbsp;</asp:label>
                                    </h3>
							</td>
							<td rowspan="2" style=" width:240px; ">
								<table width="100%" border="0" cellpadding="0" cellspacing="0">
									<tr>
									    <td style="width:50px">&nbsp;</td>
										<td style="width:85px;" valign="baseline">
											
										</td>
										
										<td>&nbsp;</td>
									</tr>
								</table>
							</td>
						</tr>
					
		
						</table>				
				
				</td>
			</tr>
			</table>
			</div>
	    <br />
        <br />
        <br />
			<div style="width:100%;">
			<table width="100%"  cellspacing="0" cellpadding="0"border="0">
			<!-- Detail -->
			<tr valign="top" >
				<td>
					<div class="w-100">
						<asp:GridView ID="dgvSearch" runat="server"  BackColor="White"
							AutoGenerateColumns="False" onsorting="dgvSearch_Sorting" 
							onselectedindexchanged="dgvSearch_SelectedIndexChanged" 
							AllowSorting="True" onpageindexchanging="dgvSearch_PageIndexChanging" 
							AllowPaging="False" onrowdatabound="dgvSearch_RowDataBound">
							
							<Columns>
                                <asp:TemplateField HeaderText="№">
                                        <ItemTemplate>
                                       <%# Container.DataItemIndex  + 1%>
                                        </ItemTemplate>  
                                         <HeaderStyle Width="24px" />
                                        <ItemStyle Width="24px" HorizontalAlign="Center"/>
                                </asp:TemplateField> 
								<asp:TemplateField HeaderText="User Group Code" >
                                <ItemTemplate>
                                    <asp:textbox ID="lblUG" runat="server" CssClass="form-control" Text='<%# Bind("USER_GROUP_CODE") %>' ToolTip='<%# Bind("USER_GROUP_CODE") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:textbox>                  
                                </ItemTemplate>
                                <ItemStyle  width="200px" />
                                <HeaderStyle Width="200px" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="User Group Name" >
                                    <ItemTemplate>
                                        <asp:textbox ID="lblUGDesc" runat="server" CssClass="form-control" Text='<%# Bind("USER_GROUP_NAME") %>' ToolTip='<%# Bind("USER_GROUP_NAME") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:textbox>
                                    </ItemTemplate>
                                    <ItemStyle width="300px" />
                                    <HeaderStyle width="300px" />
                                </asp:TemplateField>
							</Columns>
						</asp:GridView>
					
					
					</div>
					
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
