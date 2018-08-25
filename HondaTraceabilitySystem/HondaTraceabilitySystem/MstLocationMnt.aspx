<%@ Page Title="Location Master Maintenance" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MstLocationMnt.aspx.cs" Inherits="HondaTraceabilitySystem.MstLocationMnt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <table >
        <tr>
            <td>
                <asp:Label ID="flblTitle" runat="server" CssClass="TitleLabel" Text="ロケーションマスタメンテ"
                    Width="330"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <h4><asp:Label ID="lblMsg" runat="server" BackColor="Transparent"></asp:Label> </h4>
		</div>

<input type="hidden" id="hdnLocNo" />
<input type="hidden" id="hdnLocNoDesc" />
<input type="hidden" id="hdnProcessNo" />
    <input type="hidden" id="hdnProcessNoDesc" />

 <div class="modal fade" id="basicModalLoc" tabindex="-1" role="dialog" aria-labelledby="basicModalLoc" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <%--<h4 class="modal-title" id="myModalLabelLoc">Location Search</h4>--%>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">×</span>
        </button>
      </div>
      <div class="modal-body">
        
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
        <%--<button type="button" class="btn btn-primary">Save changes</button>--%>
      </div>
    </div>
  </div>
</div>

 <script type = "text/javascript"> 
      $.ajaxSetup({
         cache: false
     })

       $('#basicModalLoc').on('shown.bs.modal', function (e) {

        $(".modal-body").load("Common/Search/SrchLocation.aspx");
     });

  $('#basicModalLoc').on('hidden.bs.modal', function () {
                var value1 = $('#hdnLocNo').val();
                //var value2 = $('#hdnLocNoDesc').val();
      document.getElementById('<%=txtLocation.ClientID%>').value = value1;
      document.getElementById('<%=cmdDisp.ClientID%>').click();
                <%--document.getElementById('<%=lblWS_DESC.ClientID%>').value = value2;--%>
     });

</script>

     <div class="row">
            <div class="col-md-1">
                <asp:HiddenField ID="hdnUpdMode" runat="server" />
        <asp:HiddenField ID="hdnInputMode" runat="server" />
                    <div class="btn-group-vertical">
					    <asp:Button ID="btnMdsp" runat="server" CssClass="btn btn-info" OnClick="btnMdsp_Click" Text="INQUIRY"  />
	                   <br />
                        <asp:Button ID="btnMadd" runat="server" CssClass="btn btn-primary" OnClick="btnMadd_Click" Text="NEW" />
					    <br />
                        <asp:Button ID="btnMupd" runat="server" CssClass="btn btn-success" OnClick="btnMupd_Click" Text="CHANGE"  />		
					    <br />
                        <asp:Button ID="btnMdel" runat="server" CssClass="btn btn-danger" OnClick="btnMdel_Click" Text="DELETE" />		
				    </div>
		   </div>

 <div class="col-md-9">
    
     	<asp:panel id="pnlKey"
                    runat="server">
        <div id = "DivPnlKey" runat = "server" class="form-inline">   
        <asp:label id="flblLocation" 
                     runat="server" >Location No</asp:label>
         <asp:textbox id="txtLocation" 
                    runat="server"  MaxLength="20"
                    AUTOCOMPLETE="off" CssClass="form-control" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);"></asp:textbox> 
       <%-- <img id="btnRoleSearch" 
                    style="Z-INDEX: 107; POSITION: absolute; TOP: 12px; left: 270px;" 
                    src="../../Contents/Image/BackGround/sbtn_srch.gif" runat="server" 
                alt=""/> --%>
            <asp:LinkButton runat="server" cssclass="btn btn-default" ID="btnRoleSearch" data-toggle="modal" data-target="#basicModalLoc">
                                 <span class="glyphicon glyphicon-search" aria-hidden="true">
                                 </span>
                         </asp:LinkButton>
            <asp:Button ID="btnSearchSubmit" runat="server" style="display:none" onclick="btnSearchSubmit_Click"/>
                </div>
            </asp:panel>
      <asp:Panel ID="pnlDetail" runat="server" >
            <div id = "DivPnlDetail" runat = "server" >   
             <asp:label id="flblLocationName" 
                    runat="server" >Location Name</asp:label>
         <asp:textbox id="txtLocationName"  
                    runat="server" MaxLength="20"
                    AUTOCOMPLETE="off" CssClass="form-control"  
                    BackColor="#CCFFFF"></asp:textbox>
      <asp:label id="flblLocationDesc" 
                    runat="server" 
                    >Location Desc</asp:label>
         <asp:textbox id="txtLocationDesc"   
                    runat="server"  MaxLength="20"
                    AUTOCOMPLETE="off" CssClass="form-control" ></asp:textbox>
                <asp:Label ID="flblDept_No" runat="server" >Department No</asp:Label>
                <asp:DropDownList ID="ddl_DEPT_NO" runat="server" AUTOCOMPLETE="off" MaxLength="10" CssClass="form-control">
							</asp:DropDownList>
        </div>
        </asp:Panel>

     <asp:Panel ID="pnlSUB2" runat="server" >
                                <asp:GridView ID="dgvSearch" runat="server" BackColor="White"  AutoGenerateColumns="False"
                           
                            AllowSorting="True" 
                            AllowPaging="False"   >
                            <Columns>
                                <%--<asp:CommandField ShowSelectButton="True" />--%>
                                <asp:TemplateField HeaderText="№">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex  + 1%>
                                    </ItemTemplate>
                                      <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" width="24px" />
                                     <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="24px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Location No">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblDept_No" runat="server"  Text='<%# Bind("LOCATION_NO") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("LOCATION_NO") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="110px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Location Name" >
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblDept_Name" runat="server"  Text='<%# Bind("LOCATION_NAME") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("LOCATION_NAME") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                     <HeaderStyle  width="200px" />
                                     <ItemStyle  Width="210px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Location Desc" >
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblDept_Desc" runat="server"  Text='<%# Bind("LOCATION_DESCRIPTION") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("LOCATION_DESCRIPTION") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                     <HeaderStyle  width="200px" />
                                     <ItemStyle  Width="210px"/>
                                </asp:TemplateField>
                                   <asp:TemplateField HeaderText="Department No" >
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblDepartment_no" runat="server"  Text='<%# Bind("DEPT_NO") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("DEPT_NO") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                     <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="100px"/>
                                </asp:TemplateField>
                                  <asp:TemplateField HeaderText="User Create" >
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblUser_Create" runat="server"  Text='<%# Bind("USER_CREATE") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("USER_CREATE") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                     <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="100px"/>
                                </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Entry Date" >
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblEntry_Date" runat="server"  Text='<%# Bind("ENTRY_DATE") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("ENTRY_DATE") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                     <HeaderStyle  width="200px" />
                                     <ItemStyle  Width="200px"/>
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="User Update" >
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblUser_Update" runat="server"  Text='<%# Bind("USER_UPDATE") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("USER_UPDATE") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                     <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="100px"/>
                                </asp:TemplateField>
                                           <asp:TemplateField HeaderText="Update Date" >
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblUpdate_Date" runat="server"  Text='<%# Bind("UPDATE_DATE") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("UPDATE_DATE") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                     <HeaderStyle  width="200px" />
                                     <ItemStyle  Width="200px"/>
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
                 </asp:Panel>
 
 </div>

 </div>
    <asp:ScriptManagerProxy ID="ScriptManager1" runat="server" />
</asp:Content>
