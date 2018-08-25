<%@ Page Title="MfgBOM Master Maintenance" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MstMfgBomMnt.aspx.cs" Inherits="HondaTraceabilitySystem.MstMfgBomMnt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table width="100%" border="0">
        <tr>
            <td width="90" valign="bottom">
                <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-info" Text="SEARCH" OnClick="btnSearch_Click"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <table >
        <tr>
            <td>
                <asp:Label ID="flblTitle" runat="server" CssClass="TitleLabel" Text="部品表マスタメンテ"
                    Width="330"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>   
    <table>
        <tr>
            <td>
                <%--<asp:TextBox ID="lblMsg" Style="z-index: 108; left: 25px; position: absolute; top: 110px"
                    TabIndex="-1" runat="server" Width="704px" BorderStyle="None" BackColor="Transparent"
                    AUTOCOMPLETE="off" MaxLength="999" Font-Bold="True" ReadOnly="True" ForeColor="Red"></asp:TextBox>--%>
                <h4><asp:Label ID="lblMsg" runat="server" BackColor="Transparent"></asp:Label> </h4>
                <div >
                                       
                    <asp:Panel ID="Panel1" runat="server" >
                        <asp:Panel ID="pnlKey" runat="server" >
                            <div class="form-inline">
				        <asp:Label ID="flblITEM_NO" runat="server" >Parent Item</asp:Label>
                        <asp:TextBox ID="txtITEM_NO" 
                                runat="server" MaxLength="17" CssClass="form-control"></asp:TextBox>
                             <%--<img id="btnWHS_CD" 
                            style=" POSITION: absolute; TOP: 10px; left: 210px;" 
                            src="../../Contents/Image/BackGround/sbtn_srch.gif" runat="server"  
                            alt=""/>--%>
                             <asp:LinkButton runat="server" cssclass="btn btn-default" ID="btnParentItem" data-toggle="modal" data-target="#basicModal" >
                                     <span class="glyphicon glyphicon-search" aria-hidden="true">
                                     </span>
                        </asp:LinkButton>  
                         <asp:TextBox ID="txtITEM_DESC"  
                                runat="server" BackColor="#CCCCCC" 
                                    BorderWidth="1px" ReadOnly="true" TabIndex="-1" CssClass="form-control" ></asp:TextBox>
                               
 <div class="modal fade" id="basicModal" tabindex="-1" role="dialog" aria-labelledby="basicModal" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">×</span>
        </button>
      </div>
      <div class="modal-body">
        
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
       <%-- <button type="button" class="btn btn-primary">Save changes</button>--%>
      </div>
    </div>
  </div>
</div>

 <div class="modal fade" id="basicModal2" tabindex="-1" role="dialog" aria-labelledby="basicModal2" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">×</span>
        </button>
      </div>
      <div class="modal-body">
        
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
       <%-- <button type="button" class="btn btn-primary">Save changes</button>--%>
      </div>
    </div>
  </div>
</div>
<input type="hidden" id="hdnItemNo" />
<input type="hidden" id="hdnItemNoDesc" />
                          <script type = "text/javascript">  
                                $('#basicModal').on('shown.bs.modal', function (e) {

                                         $(".modal-body").load("Common/Search/SrchItem.aspx");
                                        //$(".modal-body").html('<iframe width="540px" height="450px" frameborder="0" allowtransparency="true" src="Common/Search/SrchItem.aspx"></iframe>');
                              });

                              $('#basicModal').on('hidden.bs.modal', function () {
                var value1 = $('#hdnItemNo').val();
                var value2 = $('#hdnItemNoDesc').val();
                document.getElementById('<%=txtITEM_NO.ClientID%>').value = value1;
         document.getElementById('<%=txtITEM_DESC.ClientID%>').value = value2;
          document.getElementById('<%=btnSearch.ClientID%>').click();
            });

                              $('#basicModal2').on('shown.bs.modal', function (e) {

                                         $(".modal-body").load("Common/Search/SrchItem.aspx");
                                        //$(".modal-body").html('<iframe width="540px" height="450px" frameborder="0" allowtransparency="true" src="Common/Search/SrchItem.aspx"></iframe>');
                              });

                              $('#basicModal2').on('hidden.bs.modal', function () {
                var value1 = $('#hdnItemNo').val();
                var value2 = $('#hdnItemNoDesc').val();
                document.getElementById('<%=txtChild_Item.ClientID%>').value = value1;
                                  document.getElementById('<%=txtChild_ItemDesc.ClientID%>').value = value2;
            });
                           </script>
                                <style type="text/css">
                                     .GVSelectedRow {
	                                         background-color:greenyellow;
                                        }

                                     .GVCell_HIDE
                                        {
	                                        display:none;
                                        }
                                </style>

 <asp:GridView ID="dgvDetail" runat="server" 
                        AutoGenerateColumns="False" BorderColor="#999999"
                                            BorderWidth="1px" AllowPaging="False" 
                        OnRowCreated="dgvDetail_RowCreated" 
                                             OnPageIndexChanging="dgvDetail_PageIndexChanging" 
                                            
                        OnSelectedIndexChanged="dgvDetail_SelectedIndexChanged">
                                            
                                            <Columns>
                                                <asp:CommandField ShowSelectButton="True" HeaderStyle-CssClass="GVCell_HIDE" ItemStyle-CssClass="GVCell_HIDE"/>
                                                <asp:TemplateField HeaderText="BOM No">
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="lblBom_No" runat="server" CssClass="form-control" 
                                                            ReadOnly="true" TabIndex="-1" Text='<%# Bind("BOM_NO") %>' 
                                                            ToolTip='<%# Bind("BOM_NO") %>' BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle width="206px" />
                                                    <ItemStyle width="100px" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="BOM Level">
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="lblBom_Level" runat="server" CssClass="form-control" 
                                                            ReadOnly="true" TabIndex="-1" Text='<%# Bind("BOM_LEVEL") %>' 
                                                            ToolTip='<%# Bind("BOM_LEVEL") %>' BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle width="206px" />
                                                    <ItemStyle width="100px" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="BOM Sub Level">
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="lblBOM_Sub_Level" runat="server" CssClass="form-control" 
                                                            ReadOnly="true" TabIndex="-1" Text='<%# Bind("BOM_SUB_LEVEL") %>' 
                                                            ToolTip='<%# Bind("BOM_SUB_LEVEL") %>' BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle width="206px" />
                                                    <ItemStyle width="100px" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Sequent">
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="lblSequent" runat="server" CssClass="form-control" 
                                                            ReadOnly="true" TabIndex="-1" Text='<%# Bind("SEQUENT") %>' 
                                                            ToolTip='<%# Bind("SEQUENT") %>' BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle width="206px" />
                                                    <ItemStyle width="100px" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Child Item">
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="lblChild_Item" runat="server" CssClass="form-control" 
                                                            ReadOnly="true" TabIndex="-1" Text='<%# Bind("CHILD_ITEM") %>' 
                                                            ToolTip='<%# Bind("CHILD_ITEM") %>' BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle width="206px" />
                                                    <ItemStyle width="100px" />
                                                </asp:TemplateField>
                                                 <asp:TemplateField HeaderText="Usage Qty">
                                                    <ItemTemplate>
                                                        <asp:TextBox ID="lblUsage_Qty" runat="server" CssClass="form-control" 
                                                            ReadOnly="true" TabIndex="-1" Text='<%# Bind("USAGE_QUANTITY") %>' 
                                                            ToolTip='<%# Bind("USAGE_QUANTITY") %>' BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="206px" />
                                                    <ItemStyle width="100px" />
                                                </asp:TemplateField>
                                            </Columns>
                          
                                            <SelectedRowStyle CssClass="GVSelectedRow" />
                                        </asp:GridView>
                        </div>
                       </asp:Panel>
                        <asp:Panel ID="pnlDetail" runat="server">
                                    <asp:Panel ID="Panel2" runat="server">
                                    </asp:Panel>
                                    <%--<script type="text/javascript">
                                        var obj = window.document.getElementById("<%= dgvDetail.ClientID%>");
                                        if (obj != null) {
                                            obj.parentNode.className = "fakeContainer";

                                            (function() {
                                                var start = new Date();
                                                superTable("<%= dgvDetail.ClientID%>", {
                                                    //fixHeight: 200,
                                                    //fixWidth: 375,
                                                    onFinish: function() {
                                                        return;
                                                    }
                                                });
                                            })();
                                        }                    
                                    </script>--%>

                                    <asp:Panel ID="Panel3" runat="server" >
                                        <table>
                                            <tr>
                                                <td width="100">
                                                    <asp:Label ID="flblBOM_No" runat="server" Text="BOM No" ></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtBOM_No" runat="server" MaxLength="15" CssClass="form-control"
                                                       ></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width="100">
                                                    <asp:Label ID="flblBOM_Level" runat="server" Text="BOM Level" ></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtBOM_Level" runat="server" MaxLength="10" CssClass="form-control"
                                                       ></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width="100">
                                                    <asp:Label ID="flblBOM_Sub_Level" runat="server" Text="BOM Sub Level" ></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtBOM_Sub_Level" runat="server" MaxLength="10" CssClass="form-control"
                                                       ></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width="100">
                                                    <asp:Label ID="flblSequent" runat="server" Text="Sequent" ></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtSequent" runat="server" MaxLength="10" CssClass="form-control"
                                                       ></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width="100">
                                                    <asp:Label ID="flblChild_Item" runat="server" Text="Child Item"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtChild_Item" runat="server" MaxLength="30" CssClass="form-control"
                                                        ></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:LinkButton runat="server" cssclass="btn btn-default" ID="btnChildItem" data-toggle="modal" data-target="#basicModal2" >
                                     <span class="glyphicon glyphicon-search" aria-hidden="true">
                                     </span>
                        </asp:LinkButton>  
                                                </td>
                                                 <td>
                                                    <asp:TextBox ID="txtChild_ItemDesc" runat="server" MaxLength="30" CssClass="form-control"
                                                        ></asp:TextBox>
                                                </td>
                                            </tr>
                                              <tr>
                                                <td width="100">
                                                    <asp:Label ID="flblUsg_Qty" runat="server" Text="Usage Qty"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtUsg_Qty" runat="server" MaxLength="30" CssClass="form-control"
                                                        onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="5">
                                                    <table>
                                                        <tr>
                                                            <td width="120" align="center">
                                                                <%--<asp:ImageButton ID="btnDET_ADD" runat="server" ImageUrl="~/Contents/Image/BackGround/btn-det_add1-1.jpg"
                                                                    OnClick="btnDET_ADD_Click" />--%>
                                                                <asp:Button ID="btnDET_ADD"  runat="server"
                                                                        CssClass="btn btn-success" Text="ADD" OnClick="btnDET_ADD_Click">
                                                                    </asp:Button>
                                                            </td>
                                                            <td width="120" align="center">
                                                                <%--<asp:ImageButton ID="btnDET_CHANGE" runat="server" ImageUrl="~/Contents/Image/BackGround/btn-det_change1-1.jpg"
                                                                    OnClick="btnDET_CHANGE_Click" />--%>
                                                                 <asp:Button ID="btnDET_CHANGE"  runat="server"
                                                                        CssClass="btn btn-warning" Text="CHANGE" OnClick="btnDET_CHANGE_Click">
                                                                    </asp:Button>
                                                            </td>
                                                            <td width="120" align="center">
                                                                <%--<asp:ImageButton ID="btnDET_DEL" runat="server" ImageUrl="~/Contents/Image/BackGround/btn-det_del1-1.jpg"
                                                                    OnClick="btnDET_DEL_Click" />--%>
                                                                <asp:Button ID="btnDET_DEL"  runat="server"
                                                                        CssClass="btn btn-danger" Text="DELETE" OnClick="btnDET_DEL_Click">
                                                                    </asp:Button>
                                                            </td>
                                                            <td width="120" align="center">
                                                               <%-- <asp:ImageButton ID="btnRELEASE" runat="server" ImageUrl="~/Contents/Image/BackGround/btn-release1-1.jpg"
                                                                    OnClick="btnRELEASE_Click" />--%>
                                                                <asp:Button ID="btnRELEASE"  runat="server"
                                                                        CssClass="btn btn-info" Text="CANCEL" OnClick="btnRELEASE_Click">
                                                                    </asp:Button>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                        </asp:Panel>
                    </asp:Panel>
				<table id="tblSelect" style="Z-INDEX: 106; LEFT: 8px; WIDTH: 120px; POSITION: absolute; TOP: 12px;  border-color:#ffffff;" cellspacing="0" bordercolordark="#ffffff" cellpadding="2" width="120" bordercolorlight="#ffffff" border="0" runat="server">
					</table>
                </div>
            </td>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
    </table>
    <%-- <table border="0" cellpadding="0" cellspacing="0" style="height: 27px;" width="100%">
        <tr>
            <td style="height: 16px; background-image: url(../../Contents/Image/BackGround/footer.gif);
                background-position: right top; background-repeat: no-repeat;" width="50%">
                <img height="16" src="../../Contents/Image/BackGround/spacer.gif" width="16" alt="" /></td>
            <td style="height: 16px;">
                <img alt="" src="../../Contents/Image/BackGround/copyright.gif" /></td>
        </tr>
        <tr>
            <td colspan="2" style="height:15px;background-image: url(../../Contents/Image/BackGround/bottom.png);  background-repeat: repeat;">
            </td>
        </tr>
    </table> --%>
    </div>
        <asp:ScriptManagerProxy ID="ScriptManager1" runat="server">
    </asp:ScriptManagerProxy>
    <asp:HiddenField ID="hdnSequent" runat="server" />
    <asp:HiddenField ID="hdnITEM_NO" runat="server" />
    <asp:HiddenField ID="hdnChild_Item" runat="server" />
	<asp:HiddenField ID="hdnIndex" runat="server" /> 
    <input type="hidden" name="SubmitAction" id="SubmitAction" />

</asp:Content>
