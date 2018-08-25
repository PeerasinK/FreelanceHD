<%@ Page Title="Production Swap" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FeOffSwap.aspx.cs" Inherits="HondaTraceabilitySystem.FeOffSwap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <table >
        <tr>
            <td>
                <asp:Label ID="flblTitle" runat="server" CssClass="TitleLabel" Text="Receiving"
                    Width="330">Middle Lot Swap</asp:Label>
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

                <%--<div class="form-group">
                    <asp:Label ID="flblOFF_NO" runat="server" >Offline No</asp:Label>
                        <div class="form-inline">
                            <asp:TextBox ID="txtOFF_NO" runat="server" CssClass="form-control" ></asp:TextBox>
                            <asp:LinkButton runat="server" cssclass="btn btn-default" ID="btnOffSearch" data-toggle="modal" data-target="#basicModalOffline" >
                                <span class="glyphicon glyphicon-search" aria-hidden="true">
                                </span>
                            </asp:LinkButton>
                        </div>
                </div>--%>

                <div class="form-group">
                    <asp:Label ID="flblLOT_NO_1" runat="server" >Lot No First</asp:Label>
                        <%--<div class="form-inline">--%>
                            <asp:TextBox ID="txtLOT_NO_1" runat="server" CssClass="form-control"></asp:TextBox>
                            <%--<asp:LinkButton runat="server" cssclass="btn btn-default" ID="btnLeser1Search" data-toggle="modal" data-target="#basicModalLeser1" >
                                    <span class="glyphicon glyphicon-search" aria-hidden="true">
                                    </span>
                            </asp:LinkButton>--%>
                        <%--</div>--%>
                </div>

                <%--<div class="form-group">
                    <asp:Label ID="flblSTATUS_1" runat="server" >Status First</asp:Label>
                        <asp:TextBox ID="txtSTATUS_1" runat="server" CssClass="form-control" MaxLength="2"></asp:TextBox>
                </div>--%>

                <div class="form-group">
                    <asp:Label ID="flblLOT_NO_2" runat="server" >Lot No Second</asp:Label>
                        <%--<div class="form-inline">--%>
                            <asp:TextBox ID="txtLOT_NO_2" runat="server" CssClass="form-control"></asp:TextBox>
                            <%--<asp:LinkButton runat="server" cssclass="btn btn-default" ID="btnLeser2Search" data-toggle="modal" data-target="#basicModalLeser2" >
                                    <span class="glyphicon glyphicon-search" aria-hidden="true">
                                    </span>
                            </asp:LinkButton>--%>
                        <%--</div>--%>
                </div>

                <%--<div class="form-group">
                    <asp:Label ID="flblSTATUS_2" runat="server" >Status Second</asp:Label>
                        <asp:TextBox ID="txtSTATUS_2" runat="server" CssClass="form-control" MaxLength="2"></asp:TextBox>
                </div>--%>

                <asp:Button ID="cmdSave" runat="server" 
                    CssClass="btn btn-success" Text="SAVE" OnClick="cmdSave_Click">
                </asp:Button>

            </asp:panel>
        </div>

 <div class="modal fade" id="basicModalOffline" tabindex="-1" role="dialog" aria-labelledby="basicModalOffline" aria-hidden="true">
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

 <div class="modal fade" id="basicModalLeser1" tabindex="-1" role="dialog" aria-labelledby="basicModalLeser1" aria-hidden="true">
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

 <div class="modal fade" id="basicModalLeser2" tabindex="-1" role="dialog" aria-labelledby="basicModalLeser2" aria-hidden="true">
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

<input type="hidden" id="hdnOffNo" />
<input type="hidden" id="hdnSN" />
<input type="hidden" id="hdnStatus" />
<input type="hidden" id="hdnSN2" />
<input type="hidden" id="hdnStatus2" />

 <script type = "text/javascript">  
     $.ajaxSetup({
    cache: false
})

$('#basicModalOffline').on('shown.bs.modal', function (e) {

     $(".modal-body").load("Common/Search/SrchOffline.aspx");
     });

     $('#basicModal').on('hidden.bs.modal', function () {
                var value1 = $('#hdnOffNo').val();
                document.getElementById('<%=txtOFF_NO.ClientID%>').value = value1;
     });

$('#basicModalLeser1').on('shown.bs.modal', function (e) {

     $(".modal-body").load("Common/Search/SrchLeser.aspx");
     });

     $('#basicModalLeser1').on('hidden.bs.modal', function () {
                var value1 = $('#hdnSN').val();
                var value2 = $('#hdnStatus').val();
                document.getElementById('<%=txtLOT_NO_1.ClientID%>').value = value1;
                document.getElementById('<%=txtSTATUS_1.ClientID%>').value = value2;
     });

$('#basicModalLeser2').on('shown.bs.modal', function (e) {

     $(".modal-body").load("Common/Search/SrchLeser.aspx");
     });

     $('#basicModalLeser2').on('hidden.bs.modal', function () {
                var value1 = $('#hdnSN2').val();
                var value2 = $('#hdnStatus2').val();
                document.getElementById('<%=txtLOT_NO_2.ClientID%>').value = value1;
                document.getElementById('<%=txtSTATUS_2.ClientID%>').value = value2;
     });

</script>
</asp:Content>
