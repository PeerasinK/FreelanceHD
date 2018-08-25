<%@ Page Title="User Master" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MstUserMnt.aspx.cs" Inherits="HondaTraceabilitySystem.MstUserMnt" %>
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
                <asp:Label ID="flblTitle" runat="server" CssClass="TitleLabel" Text="ﾕｰｻﾞマスタ"
                    Width="330"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <h4><asp:Label ID="lblMsg" runat="server" BackColor="Transparent"></asp:Label> </h4>
		</div>

<input type="hidden" id="hdnUserID" />
<input type="hidden" id="hdnPassword" runat="server" />

 <div class="modal fade" id="basicModalUser" tabindex="-1" role="dialog" aria-labelledby="basicModalUser" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <%--<h4 class="modal-title" id="myModalLabelUser">User Search</h4>--%>
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

 <div class="modal fade" id="basicModalReset" tabindex="-1" role="dialog" aria-labelledby="basicModalReset" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
          <h4 class="modal-title" id="myModalLabelReset">Password Reset</h4>
      </div>
      <div class="modal-body">
          <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-primary" data-dismiss="modal">Reset</button>
      </div>
    </div>
  </div>
</div>

 <script type = "text/javascript"> 
      $.ajaxSetup({
         cache: false
     })

       $('#basicModalUser').on('shown.bs.modal', function (e) {

        $(".modal-body").load("Common/Search/SrchUser.aspx");
     });

  $('#basicModalUser').on('hidden.bs.modal', function () {
                var value1 = $('#hdnUserID').val();
                //var value2 = $('#hdnUserName').val();
      document.getElementById('<%=txtUserId.ClientID%>').value = value1;
      document.getElementById('<%=cmdDisp.ClientID%>').click();
                <%--document.getElementById('<%=lblWS_DESC.ClientID%>').value = value2;--%>
     });

       $('#basicModalReset').on('shown.bs.modal', function (e) {

     });

  $('#basicModalReset').on('hidden.bs.modal', function () {
                var value1 = document.getElementById('<%=txtPassword.ClientID%>').value;
                $('#hdnPassword').val = value1;
      document.getElementById('<%=btnReset.ClientID%>').click();
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
         <div id="Div0" runat = "server" class="form-inline">
        <asp:label id="flblUserId" 
                     runat="server" 
                  >User ID</asp:label>
         <asp:textbox id="txtUserId"  
                    runat="server" MaxLength="20"
                    AUTOCOMPLETE="off" CssClass="form-control" ></asp:textbox> 
       <%-- <img id="btnUSERSearch" 
                    style="Z-INDEX: 107; POSITION: absolute; TOP: 4px; left: 270px;" 
                    src="../../Contents/Image/BackGround/sbtn_srch.gif" runat="server" alt=""/> --%>
             <asp:LinkButton runat="server" cssclass="btn btn-default" ID="btnUSERSearch" data-toggle="modal" data-target="#basicModalUser">
                                 <span class="glyphicon glyphicon-search" aria-hidden="true">
                                 </span>
                         </asp:LinkButton>
            <asp:Button ID="btnSearchSubmit" runat="server" style="display:none" onclick="btnSearchSubmit_Click"/>
           </div>  
           <div id="Div1" runat = "server">  
       <asp:label id="flblFirstName" 
                    runat="server" 
                    >Firstname</asp:label>
         <asp:textbox id="txtFirstName"  
                    runat="server" MaxLength="20"
                     CssClass="form-control" ></asp:textbox>
           <asp:label id="flblLastName" 
                    runat="server" 
                    >Lastname</asp:label>
         <asp:textbox id="txtLastName" 
                    runat="server"  MaxLength="20"
                    CssClass="form-control" ></asp:textbox>
           <asp:label id="flblDescription" 
                    runat="server" 
                    >Description</asp:label>
         <asp:textbox id="txtDescription" 
                    runat="server"  MaxLength="60"
                    CssClass="form-control" ></asp:textbox>
                <asp:Label ID="flblUser_Group" runat="server" >User Group</asp:Label>
                <asp:DropDownList ID="ddl_USER_GROUP" runat="server" AUTOCOMPLETE="off" MaxLength="30" CssClass="form-control">
							</asp:DropDownList>
                <asp:Label ID="flblDept_No" runat="server" >Department No</asp:Label>
                <asp:DropDownList ID="ddl_DEPT_NO" runat="server" AUTOCOMPLETE="off" MaxLength="10" CssClass="form-control">
							</asp:DropDownList>
                <asp:Label ID="flblMgmt_Level" runat="server" >Management Level</asp:Label>
                <asp:DropDownList ID="ddl_MGMT_LEVEL" runat="server" AUTOCOMPLETE="off" MaxLength="10" CssClass="form-control">
							</asp:DropDownList>
           <asp:label id="flblPosition" 
                    runat="server" 
                    >Position</asp:label>
         <asp:textbox id="txtPosition" 
                    runat="server"  MaxLength="30"
                    CssClass="form-control" ></asp:textbox>

               <div style="height: 50px;"></div>

         <Button ID="cmdReset" type="button"
                    class="btn btn-success" data-toggle="modal" data-target="#basicModalReset">
                RESET PASSWORD</Button>
         <asp:Button ID="btnReset" runat="server" style="display:none" Onclick="btnReset_Click" />
        </div>  
            </asp:panel>

 
 </div>

 </div>
    <asp:ScriptManagerProxy ID="ScriptManager1" runat="server" />
</asp:Content>
