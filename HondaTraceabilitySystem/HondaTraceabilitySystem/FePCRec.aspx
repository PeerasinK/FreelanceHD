<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FePCRec.aspx.cs" Inherits="HondaTraceabilitySystem.FePCRec" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <table >
        <tr>
            <td>
                <asp:Label ID="flblTitle" runat="server" CssClass="TitleLabel" Text="Receiving"
                    Width="330">FE Receiving</asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <h4><asp:Label ID="lblMsg" runat="server" BackColor="Transparent"></asp:Label> </h4>
		</div>
        <div style="WIDTH: 1073px; POSITION: relative; HEIGHT: 470px; left: 0px; top: 0px;">
            <asp:panel id="pnlKey" style="Z-INDEX: 103; LEFT: 5px; POSITION: absolute; TOP: 5px; width: 725px; height: 30px;" 
                    runat="server">
				
		        <asp:Label ID="flblPROCESS" runat="server" 
                        style=" LEFT: 8px; POSITION: absolute; TOP: 15px" 
                        Width="80px">Process:</asp:Label>
                <asp:DropDownList ID="ddlPROCESS" runat="server" CssClass="form-control" Height="30px" Width="150px" 
                        style=" LEFT: 100px; POSITION: absolute; TOP: 10px" AutoPostBack="True" OnSelectedIndexChanged="ddlPROCESS_SelectedIndexChanged" >
                    </asp:DropDownList>
                
            </asp:panel>

            <asp:panel id="pnlDetail" 
                    style="Z-INDEX: 102; LEFT: 8px; POSITION: absolute; TOP: 75px; height: 300px; width: 1000px;" 
                    runat="server">

                <div class="form-group">
                    <asp:Label ID="flblITEM_NO" runat="server" >Part No</asp:Label>
                        <div class="form-inline">
                            <asp:TextBox ID="txtITEM_NO" runat="server" CssClass="form-control" OnTextChanged="txtITEM_NO_TextChanged"></asp:TextBox>
                            <asp:LinkButton runat="server" cssclass="btn btn-default" ID="btnITEMSearch" data-toggle="modal" data-target="#basicModal" >
                                <span class="glyphicon glyphicon-search" aria-hidden="true">
                                </span>
                            </asp:LinkButton>
                        </div>
                </div>

                <div class="form-group">
                    <asp:Label ID="flblLOT_NO" runat="server" >Lot No</asp:Label>
                        <asp:TextBox ID="txtLOT_NO" runat="server" CssClass="form-control" MaxLength="8"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="flblRCV_QTY" runat="server" >Receive Qty</asp:Label>
                        <asp:TextBox ID="txtRCV_QTY" runat="server" CssClass="form-control" MaxLength="4"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="flblDIE_NO" runat="server" >Die No</asp:Label>
                        <asp:TextBox ID="txtDIE_NO" runat="server" CssClass="form-control" MaxLength="4"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="flblSHIFT" runat="server" >Shift</asp:Label>
                        <asp:TextBox ID="txtSHIFT_NO" runat="server" CssClass="form-control" MaxLength="1"></asp:TextBox>
                </div>

                <asp:Button ID="cmdSave" runat="server" 
                    CssClass="btn btn-success" Text="SAVE" OnClick="cmdSave_Click">
                </asp:Button>

            </asp:panel>
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
      </div>
    </div>
  </div>
</div>

<input type="hidden" id="hdnItemNo" />
<input type="hidden" id="hdnItemNoDesc" />

 <script type = "text/javascript">  
     $.ajaxSetup({
    cache: false
})

$('#basicModal').on('shown.bs.modal', function (e) {

     $(".modal-body").load("Common/Search/SrchItem.aspx");
     });

     $('#basicModal').on('hidden.bs.modal', function () {
                var value1 = $('#hdnItemNo').val();
                var value2 = $('#hdnItemNoDesc').val();
                document.getElementById('<%=txtITEM_NO.ClientID%>').value = value1;
     });
</script>
</asp:Content>
