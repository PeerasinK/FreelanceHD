<%@ Page Title="Part Master Maintenance" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MstItemMnt.aspx.cs" Inherits="HondaTraceabilitySystem.MstItemMnt" %>
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
                <asp:Label ID="flblTitle" runat="server" CssClass="TitleLabel" Text="品目マスタメンテナンス"
                    Width="330"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <h4><asp:Label ID="lblMsg" runat="server" BackColor="Transparent"></asp:Label> </h4>
		</div>
         
    <asp:Panel ID="Panel2" runat="server" Height="100%" Width="100%">

              <div id="keydiv" >
                        <div class="row">  
                        <div class="col-md-1">
                            </div>
                         <div class="col-md-9">
                        <asp:Panel ID="pnlKey" runat="server" >
                            <div id="Div0" runat="server" class="form-inline">

                                <asp:Label ID="flblITEM_NO" runat="server" >Part No.</asp:Label>
                                <asp:TextBox ID="txtITEM_NO"  runat="server"  AUTOCOMPLETE="off" CssClass="form-control"
                                    MaxLength="20"></asp:TextBox>
                                
                                <asp:LinkButton runat="server" cssclass="btn btn-default" ID="btnITEMSearch" data-toggle="modal" data-target="#basicModal" >
                                     <span class="glyphicon glyphicon-search" aria-hidden="true">
                                     </span>
                        </asp:LinkButton>                       
                                <asp:TextBox ID="lblITEM_DESC"  runat="server" CssClass="form-control" ReadOnly="True" ></asp:TextBox>
                                <asp:Button ID="btnSearchSubmit" runat="server" Style="display: none" OnClick="btnSearchSubmit_Click" />
                            </div>
                        </asp:Panel>
             </div>
                        </div>

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

 <div class="modal fade" id="basicModalWHS" tabindex="-1" role="dialog" aria-labelledby="basicModalWHS" aria-hidden="true">
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
        <%--<button type="button" class="btn btn-primary">Save changes</button>--%>
      </div>
    </div>
  </div>
</div>

<div class="modal fade" id="basicModalWHS2" tabindex="-1" role="dialog" aria-labelledby="basicModalWHS2" aria-hidden="true">
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
        <%--<button type="button" class="btn btn-primary">Save changes</button>--%>
      </div>
    </div>
  </div>
</div>

<input type="hidden" id="hdnItemNo" />
<input type="hidden" id="hdnItemNoDesc" />
<input type="hidden" id="hdnShipWH" />
    <input type="hidden" id="hdnShipWHDesc" />

 <script type = "text/javascript">  
     $.ajaxSetup({
    cache: false
})

$('#basicModal').on('shown.bs.modal', function (e) {

     $(".modal-body").load("Common/Search/SrchItem.aspx");
    //$(".modal-body").html('<iframe width="540px" height="450px" frameborder="0" allowtransparency="true" src="Common/Search/SrchItem.aspx"></iframe>');
     });

     $('#basicModal').on('hidden.bs.modal', function () {
                var value1 = $('#hdnItemNo').val();
                var value2 = $('#hdnItemNoDesc').val();
                document.getElementById('<%=txtITEM_NO.ClientID%>').value = value1;
                document.getElementById('<%=lblITEM_DESC.ClientID%>').value = value2;
         document.getElementById('<%=txtITEM_DESC.ClientID%>').value = value2;
          document.getElementById('<%=cmdDisp.ClientID%>').click();
            });

     $('#basicModalWHS').on('shown.bs.modal', function (e) {

          $(".modal-body").load("Common/Search/SrchWhs.aspx");
    //$(".modal-body").html('<iframe width="540px" height="450px" frameborder="0" allowtransparency="true" src="Common/Search/SrchWhs.aspx"></iframe>');
     });

         <%--$('#basicModalWHS').on('hidden.bs.modal', function () {
                var value1 = $('#hdnShipWH').val();
                var value2 = $('#hdnShipWHDesc').val();
                document.getElementById('<%=txtDISB_WHS.ClientID%>').value = value1;
             document.getElementById('<%=lblDISB_WHS.ClientID%>').value = value2; 

     });--%>

          $('#basicModalWHS2').on('shown.bs.modal', function (e) {

          $(".modal-body").load("Common/Search/SrchWhs.aspx");
    //$(".modal-body").html('<iframe width="540px" height="450px" frameborder="0" allowtransparency="true" src="Common/Search/SrchWhs.aspx"></iframe>');
     });

         <%--$('#basicModalWHS2').on('hidden.bs.modal', function () {
                var value1 = $('#hdnShipWH').val();
                var value2 = $('#hdnShipWHDesc').val();
             document.getElementById('<%=txtBOND_DISB_WHS.ClientID%>').value = value1;
                document.getElementById('<%=lblBOND_DISB_WHS.ClientID%>').value = value2;
            });--%>
</script>
          <div class="row">
            <div class="col-md-1">
                <div class="btn-group-vertical">
                         <asp:Button ID="btnMdsp" Text="INQUIRY" runat="server" CssClass="btn btn-info" OnClick="btnMdsp_Click">
                                    </asp:Button><br />
                                    <asp:Button ID="btnMadd" Text="NEW" runat="server" CssClass="btn btn-primary" OnClick="btnMadd_Click">
                                    </asp:Button><br />
                                    <asp:Button  ID="btnMupd" Text="CHANGE" runat="server" CssClass="btn btn-success" OnClick="btnMupd_Click">
                                    </asp:Button><br />
                                    <asp:Button  ID="btnMdel" Text="DELETE" runat="server" CssClass="btn btn-danger" OnClick="btnMdel_Click">
                                    </asp:Button>
                       </div>
                </div>
              <div class="col-md-9">
                        <asp:Panel ID="pnlDetail"  runat="server">
                           
<%--                            <ul class="nav nav-pills" role="tablist">
                <li class="active"><a href="#t1" role="tab" data-toggle="tab">No 1</a></li>
                <li><a href="#t2" role="tab" data-toggle="tab">No 2</a></li>
                <li><a href="#t3" role="tab" data-toggle="tab">No 3</a></li>
                <li><a href="#t4" role="tab" data-toggle="tab">No 4</a></li>
                <li><a href="#t5" role="tab" data-toggle="tab">No 5</a></li>
            </ul>--%>
                           <%--<div class="tab-content">
                 <div class="tab-pane active" id="t1">--%>
                                        <div id="Div1" runat="server">
                                            <div class="form-group">                      
                                                 <asp:Label ID="flblITEM_DESC"  runat="server" >Part Name</asp:Label>
                                                <asp:TextBox ID="txtITEM_DESC" runat="server" MaxLength="50" CssClass="form-control" BackColor="#CCFFFF"></asp:TextBox>
                                         </div>
                                            <div class="form-group">
                                                
                                                <asp:Label ID="flblITEM_DESC2"  runat="server" >Part Description</asp:Label>
                                                <asp:TextBox ID="txtITEM_DESC2" runat="server" AUTOCOMPLETE="off" MaxLength="50"
                                                CssClass="form-control"></asp:TextBox>
                                            </div>
                                            <div class = "form-group">
                                               <asp:Label ID="flblITEM_TYPE" runat="server">Item Type</asp:Label>
                                               <asp:TextBox ID="rdoITEM_TYPE"  runat="server" AUTOCOMPLETE="off" MaxLength="50"
                                                CssClass="form-control"></asp:TextBox>
                                                <%--<asp:RadioButtonList ID="rdoITEM_TYPE" runat="server"   RepeatDirection="Vertical" 
                                                 AutoPostBack="True" OnSelectedIndexChanged="rdoITEM_TYPE_SelectedIndexChanged">
                                                <asp:ListItem Value="21" Selected="True">見込生産製品  </asp:ListItem> 
                                                <asp:ListItem Value="22">受注生産製品  </asp:ListItem>
                                                <asp:ListItem Value="30">半製品  </asp:ListItem>
                                                <asp:ListItem Value="51">加工部品  </asp:ListItem>
                                                <asp:ListItem Value="52">購入部品  </asp:ListItem>
                                                <asp:ListItem Value="91">客先支給部品  </asp:ListItem>
                                                <asp:ListItem Value="99">ダミー品  </asp:ListItem>
                                            </asp:RadioButtonList>--%>
                                           </div>
                                            <div class="form-group">
                                                 <asp:Label ID="flblDept" runat="server" >Dept No</asp:Label>
                                               <%--<asp:TextBox ID="txtDept"  runat="server" AUTOCOMPLETE="off" MaxLength="50"
                                                CssClass="form-control"></asp:TextBox>--%>
                                                <asp:DropDownList ID="ddl_DEPT_NO" runat="server" AUTOCOMPLETE="off" MaxLength="10" CssClass="form-control">
							                                </asp:DropDownList>
                                           </div>
                                            <div class="form-group">
                                                 <asp:Label ID="flblSPEC_DESC" runat="server">Model Type</asp:Label>
                                                  <asp:TextBox ID="txtSPEC_DECS"  runat="server" AUTOCOMPLETE="off" MaxLength="50"
                                                CssClass="form-control"></asp:TextBox>
                                             </div>
                                            <div class="form-group">
                                                 <asp:Label ID="flblMaker_From" runat="server" >Maker From</asp:Label>
                                               <asp:TextBox ID="txtMaker_From"  runat="server" AUTOCOMPLETE="off" MaxLength="50"
                                                CssClass="form-control"></asp:TextBox>
                                           </div>
                                             <div class="form-group">
                                                 <asp:Label ID="flblMaker_Code" runat="server" >Maker Code</asp:Label>
                                               <asp:TextBox ID="txtMaker_Code"  runat="server" AUTOCOMPLETE="off" MaxLength="50"
                                                CssClass="form-control"></asp:TextBox>
                                           </div>
                                               <div class="form-group">
                                                 <asp:Label ID="flblDept_To" runat="server" >Dept To</asp:Label>
                                               <%--<asp:TextBox ID="txtDept_To"  runat="server" AUTOCOMPLETE="off" MaxLength="50"
                                                CssClass="form-control"></asp:TextBox>--%>
                                                <asp:DropDownList ID="ddl_DEPT_TO" runat="server" AUTOCOMPLETE="off" MaxLength="10" CssClass="form-control">
							                                </asp:DropDownList>
                                           </div>
                                            <asp:Label ID="flblStock_Area" runat="server" >Stock Area</asp:Label>
                                               <asp:TextBox ID="txtStock_Area"  runat="server" AUTOCOMPLETE="off" MaxLength="50"
                                                CssClass="form-control"></asp:TextBox>
                                            <div class="form-group">
                                                 <asp:Label ID="flblSCH_ID" runat="server" >Line Prod</asp:Label>
                                               <asp:TextBox ID="txtSCH_ID"  runat="server" AUTOCOMPLETE="off" MaxLength="50"
                                                CssClass="form-control"></asp:TextBox>
                                           </div>
                                            <div class="form-group">
                                               <asp:Label ID="flblCATG_CD" runat="server">Category</asp:Label>
                                              <asp:TextBox ID="ddlCATG_CD"  runat="server" AUTOCOMPLETE="off" MaxLength="50" CssClass="form-control">
                                            </asp:TextBox>
                                          </div>
                                            <div class="form-group">
                                                 <asp:Label ID="flblREMARKS" runat="server" >Remark</asp:Label>
                                               <asp:TextBox ID="txtMREMARKS"  runat="server" AUTOCOMPLETE="off" MaxLength="50"
                                                CssClass="form-control"></asp:TextBox>
                                           </div>
                                            <div class ="form-group">
                                                  <asp:Label ID="flblDRAWING_NO" runat="server" >Drawing No.</asp:Label>
                                                <asp:TextBox ID="txtDRAWING_NO"  runat="server" AUTOCOMPLETE="off" MaxLength="50"
                                                CssClass="form-control"></asp:TextBox>
                                            </div>
                                           </div>
                                           <%--<div class="form-group">
                                                 <asp:Label ID="flblITEM_UMSR"  runat="server">在庫単位</asp:Label>
                                            <asp:DropDownList runat="server" ID="ddlITEM_UMSR" CssClass="form-control" >
                                            </asp:DropDownList>
                                           </div>--%>
                                            <%--<div class="form-group">
                                                  <asp:Label ID="flblDISB_LOT_SIZE"  runat="server" >出庫まるめ数</asp:Label>
                                                   <asp:TextBox ID="txtDISB_LOT_SIZE" runat="server"  DecimalSymbol="."
                                                MaxLength="11" CssClass="form-control" Befor_Value="0" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);"></asp:TextBox>
                                            </div>--%>
                                           <%-- <div class="form-group">
                                                <asp:Label ID="flblPUR_LOT_SIZE"  runat="server" >製造ロット</asp:Label>
                                                <asp:TextBox ID="txtPUR_LOT_SIZE" runat="server" DecimalSymbol="."
                                                MaxLength="11" CssClass="form-control" Befor_Value="0" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);"></asp:TextBox>
                                            </div>--%>
                                            <%--<div class="form-group">
                                                 <asp:Label ID="flblAUTO_DISB_TYPE"  runat="server">みなし出庫</asp:Label>
                                            <asp:RadioButtonList ID="rdoAUTO_DISB_TYPE" runat="server"  RepeatDirection="Vertical">
                                                <asp:ListItem Value="0" Selected="True">しない</asp:ListItem>
                                                <asp:ListItem Value="1">する</asp:ListItem>
                                            </asp:RadioButtonList>
                                            </div>--%>
                              <%--</div>--%>
                               <%-- <div class="tab-pane" id="t2">
                                        <div id="Div2" runat="server">
                                            <div class="form-group">
                                                <asp:Label ID="flblDISB_WHS" runat="server" >出庫倉庫</asp:Label>
                                                <div class="form-inline">
                                                       <asp:TextBox ID="txtDISB_WHS"  runat="server"  CssClass="form-control" 
                                                MaxLength="5" BackColor="#CCFFFF"></asp:TextBox>
                                                       <asp:LinkButton runat="server" cssclass="btn btn-default" ID="btnOutStorage" data-toggle="modal" data-target="#basicModalWHS">
                                                         <span class="glyphicon glyphicon-search" aria-hidden="true">
                                                         </span>
                                                    </asp:LinkButton>
                                                     <asp:TextBox ID="lblDISB_WHS" runat="server"  CssClass="form-control" ></asp:TextBox>
                                                </div>
                                            </div>

                                            <div class="form-group">
                                                   <asp:Label ID="flblBOND_DISB_WHS" runat="server" >出庫倉庫（保税)</asp:Label>
                                                 <div class="form-inline">
                                                       <asp:TextBox ID="txtBOND_DISB_WHS" runat="server"  CssClass="form-control" 
                                                MaxLength="5"></asp:TextBox>
                                                     <asp:LinkButton runat="server" cssclass="btn btn-default" ID="btnOutStorageBond" data-toggle="modal" data-target="#basicModalWHS2" >
                                                     <span class="glyphicon glyphicon-search" aria-hidden="true">
                                                     </span>
                                                </asp:LinkButton>
                                                      <asp:TextBox ID="lblBOND_DISB_WHS" runat="server"  CssClass="form-control"></asp:TextBox>
                                                 </div>
                                            </div>
                                            
                                            <div class="form-group">
                                                  <asp:Label ID="flblBOND_TYPE" runat="server" >保税部品</asp:Label>
                                                <asp:RadioButtonList ID="rdoBOND_TYPE" runat="server"  RepeatDirection="Vertical">
                                                <asp:ListItem Value="0" Selected="True">No</asp:ListItem>
                                                <asp:ListItem Value="1">Yes</asp:ListItem>
                                            </asp:RadioButtonList>
                                            </div>
                                            
                                           <div class="form-group">
                                                <asp:Label ID="flblLOCATION" runat="server" >ロケーション</asp:Label>
                                               <asp:TextBox ID="txtLOCATION" runat="server" AUTOCOMPLETE="off" MaxLength="10" CssClass="form-control"></asp:TextBox>
                                           </div>
                                            
                                            <div class="form-group">
                                                <asp:Label ID="flblLOT_CNTL_FLAG" runat="server" >ロット管理</asp:Label>
                                                 <asp:RadioButtonList ID="rdoLOT_CNTL_FLAG" runat="server"  RepeatDirection="Vertical">
                                                <asp:ListItem Value="0" Selected="True">しない</asp:ListItem>
                                                <asp:ListItem Value="1">する</asp:ListItem>
                                            </asp:RadioButtonList>
                                            </div>                          
                                        </div>
                                    </div>
                                <div class="tab-pane" id="t3">
                                        <div id="Div3" runat="server">
                                            <div class="row">
                                                <div class="col-md-2">
                                                    <asp:Label ID="flblITEM_IMAGE" runat="server" >品目イメージ</asp:Label>
                                                 </div>
                                                <div class="col-md-1">
                                                    <asp:Image ID="IPicture" runat="server" />
                                                </div>
                                                <div class="col-md-1">
                                                    <asp:Label ID="flblITEM_IMAGE1"  runat="server" >アップロード</asp:Label>
                                                </div>
                                                <div class="col-md-3">    
                                                      <div class="input-group">  
                                                           <asp:FileUpload ID="FileUpload1" cssclass="form-control-file"  runat="server"  />        
                                                       <span class="input-group-btn">
                                                        <asp:Button ID="btnITEM_IMAGE" runat="server"  cssclass="btn btn-success btn-sm" Text="ｱｯﾌﾟﾛｰﾄﾞ" OnClick="btnITEM_IMAGE_Click" />
                                                         </span>
                                                       </div>
                                                  </div>
                                              </div>
                                            <br />
                                            <div class="row">
                                                <div class="col-md-2">
                                                        <asp:Label ID="flblASSY_IMAGE" runat="server">組立イメージ</asp:Label>
                                                 </div>
                                                <div class="col-md-1">
                                                         <asp:Image ID="APicture" runat="server"  />
                                                    </div>
                                                <div class="col-md-1">
                                                        <asp:Label ID="flblASSY_IMAGE1"  runat="server">アップロード</asp:Label>
                                                    </div>
                                                <div class="col-md-3">
                                                    <div class="input-group"> 
                                                        <asp:FileUpload ID="FileUpload2" runat="server" />
                                                        <span class="input-group-btn">
                                                            <asp:Button ID="btnASSY_IMAGE" runat="server" cssclass="btn btn-success btn-sm" OnClick="btnASSY_IMAGE_Click" Text="ｱｯﾌﾟﾛｰﾄﾞ" />
                                                        </span> 
                                                    </div>
                                              </div>                      
                                        </div>
                                    </div>
                                  </div>
                               <div class="tab-pane" id="t4">
                                        <div id="Div4" runat="server">
                                            <div class="form-group">
                                                 <div class="form-inline">
                                                    <asp:Label ID="flblDATA_CHAR1" runat="server" > 汎用文字項目1</asp:Label>
                                                     <asp:TextBox ID="txtDATA_CHAR1" runat="server" CssClass="form-control"
                                                AUTOCOMPLETE="off" MaxLength="30"> </asp:TextBox>
                                                    <asp:Label ID="flblDATA_CHAR2" runat="server" > 汎用文字項目2</asp:Label>
                                                      <asp:TextBox ID="txtDATA_CHAR2" runat="server" CssClass="form-control"
                                                AUTOCOMPLETE="off" MaxLength="30"></asp:TextBox>
                                                     </div>
                                                </div>
                                            <div class="form-group">
                                                <div class="form-inline">
                                                     <asp:Label ID="flblDATA_CHAR3" runat="server" > 汎用文字項目3</asp:Label>
                                                    <asp:TextBox ID="txtDATA_CHAR3"  runat="server" CssClass="form-control"
                                                AUTOCOMPLETE="off" MaxLength="30"></asp:TextBox>
                                                    <asp:Label ID="flblDATA_CHAR4" runat="server" > 汎用文字項目4</asp:Label>
                                                    <asp:TextBox ID="txtDATA_CHAR4"  runat="server" CssClass="form-control"
                                                AUTOCOMPLETE="off" MaxLength="30"></asp:TextBox>
                                                </div>
                                            </div>
                                           <div class="form-group">
                                                <div class="form-inline">
                                                     <asp:Label ID="flblDATA_CHAR5" runat="server" > 汎用文字項目5</asp:Label>
                                                     <asp:TextBox ID="txtDATA_CHAR5"  runat="server" CssClass="form-control"
                                                AUTOCOMPLETE="off" MaxLength="30"></asp:TextBox>
                                                     <asp:Label ID="flblDATA_CHAR6" runat="server" > 汎用文字項目6</asp:Label>
                                                    <asp:TextBox ID="txtDATA_CHAR6"  runat="server" CssClass="form-control"
                                                AUTOCOMPLETE="off" MaxLength="30"></asp:TextBox>
                                                  </div>
                                            </div>
                                           <div class="form-group">
                                                <div class="form-inline">
                                                     <asp:Label ID="flblDATA_CHAR7" runat="server"> 汎用文字項目7</asp:Label>
                                                    <asp:TextBox ID="txtDATA_CHAR7"  runat="server" CssClass="form-control"
                                                AUTOCOMPLETE="off" MaxLength="30"></asp:TextBox>
                                                    <asp:Label ID="flblDATA_CHAR8" runat="server"> 汎用文字項目8</asp:Label>
                                                    <asp:TextBox ID="txtDATA_CHAR8"  runat="server" CssClass="form-control"
                                                AUTOCOMPLETE="off" MaxLength="30"></asp:TextBox>
                                                </div>
                                             </div>
                                           <div class="form-group">
                                                <div class="form-inline">
                                                    <asp:Label ID="flblDATA_CHAR9" runat="server"> 汎用文字項目9</asp:Label>
                                                    <asp:TextBox ID="txtDATA_CHAR9"  runat="server" CssClass="form-control"
                                                AUTOCOMPLETE="off" MaxLength="30"></asp:TextBox>
                                                    <asp:Label ID="flblDATA_CHAR10" runat="server" > 汎用文字項目10</asp:Label>
                                                    <asp:TextBox ID="txtDATA_CHAR10"  runat="server" CssClass="form-control"
                                                AUTOCOMPLETE="off" MaxLength="30"></asp:TextBox>
                                                </div>
                                             </div>
                                            <div class="form-group">
                                                <div class="form-inline">
                                                    <asp:Label ID="flblDATA_NUM1"  runat="server" > 汎用数字項目1</asp:Label>
                                                    <asp:TextBox ID="txtDATA_NUM1" runat="server" DecimalPlaces="5"  CssClass="form-control"
                                                DecimalSymbol="." MaxLength="16" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);"></asp:TextBox>
                                           
                                                    <asp:Label ID="flblDATA_NUM2"  runat="server" > 汎用数字項目2</asp:Label>
                                                     <asp:TextBox ID="txtDATA_NUM2" runat="server" DecimalPlaces="5"  CssClass="form-control"
                                                DecimalSymbol="." MaxLength="16" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);"></asp:TextBox>
                                                </div>
                                             </div>
                                            <div class="form-group">
                                                <div class="form-inline">
                                                    <asp:Label ID="flblDATA_NUM3"  runat="server" > 汎用数字項目3</asp:Label>
                                                    <asp:TextBox ID="txtDATA_NUM3" runat="server" DecimalPlaces="5"  CssClass="form-control"
                                                DecimalSymbol="." MaxLength="16" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);">      </asp:TextBox>
                         
                                                    <asp:Label ID="flblDATA_NUM4"  runat="server" > 汎用数字項目4</asp:Label>
                                                  <asp:TextBox ID="txtDATA_NUM4" runat="server" DecimalPlaces="5"  CssClass="form-control"
                                                DecimalSymbol="." MaxLength="16" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);"></asp:TextBox>
                                                </div>
                                             </div>
                                            <div class="form-group">
                                                <div class="form-inline">
                                                    <asp:Label ID="flblDATA_NUM5"  runat="server" > 汎用数字項目5</asp:Label>
                                                    <asp:TextBox ID="txtDATA_NUM5" runat="server" DecimalPlaces="5"  CssClass="form-control"
                                                DecimalSymbol="." MaxLength="16" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);">         </asp:TextBox>

                                                    <asp:Label ID="flblDATA_NUM6"  runat="server" > 汎用数字項目6</asp:Label>
                                                  <asp:TextBox ID="txtDATA_NUM6" runat="server" DecimalPlaces="5"  CssClass="form-control"
                                                DecimalSymbol="." MaxLength="16" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);">        </asp:TextBox>
                                                </div>
                                             </div>
                                            <div class="form-group">
                                                <div class="form-inline">
                                                     <asp:Label ID="flblDATA_NUM7"  runat="server" > 汎用数字項目7</asp:Label>
                                                     <asp:TextBox ID="txtDATA_NUM7" runat="server" DecimalPlaces="5"  CssClass="form-control"
                                                DecimalSymbol="." MaxLength="16" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);">    </asp:TextBox>
                                         
                                                    <asp:Label ID="flblDATA_NUM8"  runat="server" > 汎用数字項目8</asp:Label>
                                                       <asp:TextBox ID="txtDATA_NUM8" runat="server" DecimalPlaces="5"  CssClass="form-control"
                                                DecimalSymbol="." MaxLength="16" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);"></asp:TextBox>
                                                </div>
                                             </div>
                                            <div class="form-group">
                                                <div class="form-inline">
                                                      <asp:Label ID="flblDATA_NUM9"  runat="server" > 汎用数字項目9</asp:Label>
                                                    <asp:TextBox ID="txtDATA_NUM9" runat="server" DecimalPlaces="5"  CssClass="form-control"
                                                DecimalSymbol="." MaxLength="16" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);">    </asp:TextBox>
                                            
                                                      <asp:Label ID="flblDATA_NUM10" runat="server" > 汎用数字項目10</asp:Label>
                                                    <asp:TextBox ID="txtDATA_NUM10" runat="server" DecimalPlaces="5"  CssClass="form-control"
                                                DecimalSymbol="." MaxLength="16" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);">    </asp:TextBox>
                                                </div>
                                             </div>
                                            <div class="form-group">
                                                <div class="form-inline">
                                                    <asp:Label ID="flblDATA_FLAG1" runat="server" > 汎用フラグ1</asp:Label>
                                                    <asp:CheckBox ID="chkDATA_FLAG1" runat="server"  />
                                            
                                                    <asp:Label ID="flblDATA_FLAG2"  runat="server" > 汎用フラグ2</asp:Label>
                                                    <asp:CheckBox ID="chkDATA_FLAG2" runat="server"  />
                                                </div>
                                             </div>
                                            <div class="form-group">
                                                <div class="form-inline">
                                                    <asp:Label ID="flblDATA_FLAG3" runat="server" > 汎用フラグ3</asp:Label>
                                                    <asp:CheckBox ID="chkDATA_FLAG3" runat="server"  />
                                           
                                                      <asp:Label ID="flblDATA_FLAG4" runat="server" > 汎用フラグ4</asp:Label>
                                                     <asp:CheckBox ID="chkDATA_FLAG4" runat="server"  />
                                                    </div>
                                                </div>
                                            <div class="form-group">
                                                <div class="form-inline">
                                                    <asp:Label ID="flblDATA_FLAG5" runat="server" > 汎用フラグ5</asp:Label>
                                                     <asp:CheckBox ID="chkDATA_FLAG5" runat="server"  />
                                           
                                                    <asp:Label ID="flblDATA_FLAG6"  runat="server" > 汎用フラグ6</asp:Label>
                                                     <asp:CheckBox ID="chkDATA_FLAG6" runat="server"  />
                                                    </div>
                                                </div>
                                            <div class="form-group">
                                                <div class="form-inline">
                                                    <asp:Label ID="flblDATA_FLAG7" runat="server" > 汎用フラグ7</asp:Label>
                                                    <asp:CheckBox ID="chkDATA_FLAG7" runat="server"  />
                                            
                                                    <asp:Label ID="flblDATA_FLAG8" runat="server" > 汎用フラグ8</asp:Label>
                                                    <asp:CheckBox ID="chkDATA_FLAG8" runat="server"  />
                                                    </div>
                                                </div>
                                             <div class="form-group">
                                                <div class="form-inline">
                                                    <asp:Label ID="flblDATA_FLAG9"  runat="server" > 汎用フラグ9</asp:Label>
                                                    <asp:CheckBox ID="chkDATA_FLAG9" runat="server"  />
                                            
                                                    <asp:Label ID="flblDATA_FLAG10"  runat="server" > 汎用フラグ10</asp:Label>
                                                    <asp:CheckBox ID="chkDATA_FLAG10" runat="server" />
                                                    </div>
                                                </div>
                                        </div>
                                    </div>
                                <div class="tab-pane" id="t5">
                                        <div id="Div5" runat="server">
                                            <asp:Button ID="btnPurchase" runat="server" Text="購買情報" 
                                                OnClick="btnPurchase_Click" cssclass="btn btn-default" />
                                            <asp:GridView ID="dvgPurchase" runat="server"  
                                                CellPadding="1" AllowPaging="False" AutoGenerateColumns="False" OnPageIndexChanging="dvgPurchase_PageIndexChanging">
                                                <Columns>
                                                    <asp:BoundField HeaderText="優先№" DataField="PTY_NO">
                                                        <ItemStyle CssClass="GVCellLbl_Pty_No" />
                                                    </asp:BoundField>
                                                    <asp:BoundField HeaderText="仕入先" DataField="VENDOR_CD">
                                                        <ItemStyle CssClass="GVCellLbl_Vendor_Item" />
                                                    </asp:BoundField>
                                                    <asp:TemplateField HeaderText="仕入先名">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="lblWSDesc" runat="server" CssClass="GVCellText_VendorName_Item"
                                                                Text='<%# Bind("VENDOR_NAME") %>' ToolTip='<%# Bind("VENDOR_NAME") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                        <ItemStyle CssClass="GVCellLbl_VendorName_Item" />
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="BEG_EFF_DATE" HeaderText="有効開始">
                                                        <ItemStyle HorizontalAlign="Center" CssClass="GVCellLbl_Beg_Eff_Date" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="END_EFF_DATE" HeaderText="有効終了">
                                                        <ItemStyle HorizontalAlign="Center" CssClass="GVCellLbl_End_Eff_Date" />
                                                    </asp:BoundField>
                                                    <asp:BoundField HeaderText="発注担当" DataField="BUYER_CD">
                                                        <ItemStyle CssClass="GVCellLbl_Buyer_Item" />
                                                    </asp:BoundField>
                                                    <asp:BoundField HeaderText="支給区分" DataField="SUPPLY_TYPE">
                                                        <ItemStyle CssClass="GVCellLbl_Supply_Type" />
                                                    </asp:BoundField>
                                                    <asp:BoundField HeaderText="納入LT" DataField="DELV_LT" DataFormatString="{0:N2}">
                                                        <ItemStyle CssClass="GVCellLbl_Delv_Lt" />
                                                    </asp:BoundField>
                                                    <asp:BoundField HeaderText="検査" DataField="INSP_LT" DataFormatString="{0:N2}">
                                                        <ItemStyle CssClass="GVCellLbl_Insp_Lt" />
                                                    </asp:BoundField>
                                                    <asp:BoundField HeaderText="最小発注" DataField="MIN_PUR_QTY" DataFormatString="{0:N0}">
                                                        <ItemStyle CssClass="GVCellLbl_Min_Pur_Qty" />
                                                    </asp:BoundField>
                                                    <asp:BoundField HeaderText="発注ﾛｯﾄ" DataField="PUR_LOT_SIZE" DataFormatString="{0:N0}">
                                                        <ItemStyle CssClass="GVCellLbl_Pur_Lot_Size" />
                                                    </asp:BoundField>
                                                </Columns>
                                                <FooterStyle CssClass="GVFooter" />
                                                <PagerStyle CssClass="GVPager" />
                                                <SelectedRowStyle CssClass="GVSelectedRow" />
                                                <HeaderStyle CssClass="GVHeader" />
                                                <AlternatingRowStyle CssClass="GVAlternatingRow" />
                                                <RowStyle CssClass="GVRow" />
                                            </asp:GridView>
                                        </div>
                                </div>--%>
                           <%-- </div> --%>
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
                                <asp:TemplateField HeaderText="Part No">
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblItemCd" runat="server"  Text='<%# Bind("PART_NO") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("PART_NO") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <HeaderStyle  width="100px" />
                                     <ItemStyle  Width="100px"/>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Part Name" >
                                    <ItemTemplate>
                                        <asp:TextBox ID="lblItemDesc" runat="server"  Text='<%# Bind("PART_NAME") %>' CssClass="form-control"
                                            ToolTip='<%# Bind("PART_NAME") %>' ReadOnly="true" BorderStyle="None" BackColor="Transparent" BorderWidth="0px"></asp:TextBox>
                                    </ItemTemplate>
                                     <HeaderStyle  width="200px" />
                                     <ItemStyle  Width="200px"/>
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
               </div>
             </div>

    </asp:Panel>
    <asp:HiddenField ID="hdnUpdMode" runat="server" />
    <asp:HiddenField ID="hdnInputMode" runat="server" />
    <asp:HiddenField ID="hdnLLC" runat="server" />
    <asp:HiddenField ID="ItemPicture" runat="server" />
    <asp:HiddenField ID="AssyPicture" runat="server" />
    <asp:ScriptManagerProxy ID="ScriptManager1" runat="server">
    </asp:ScriptManagerProxy>
</asp:Content>
