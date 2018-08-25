<%@ Page Title="Calendar Master Maintenance" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MstCalendarMnt.aspx.cs" Inherits="HondaTraceabilitySystem.MstCalendarMnt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table width="100%" border="0">
        <tr>
            <td width="90" valign="bottom">
                <asp:Button ID="cmdDisp" runat="server" CssClass="btn btn-primary" Text="DISPLAY" OnClick="cmdDisp_Click"></asp:Button>
            </td>
            <td style="padding-left: 5px" width="90" valign="bottom">
                <asp:Button ID="cmdUpdate" runat="server" CssClass="btn btn-success" Text="UPDATE" OnClick="cmdUpdate_Click"></asp:Button>
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
            <h4><asp:Label ID="lblMsg" runat="server" CssClass="label label-default" BackColor="Transparent"></asp:Label> </h4>
		</div>

    <table>
    
    <tr>
    <td style="width:80px;">
             </td>
    <td>
      <asp:Label 
                ID="flblYear" runat="server" Text="”N"></asp:Label>
        </td>
    <td>
        <asp:DropDownList ID="ddlYear" runat="server" CssClass="form-control"
            AutoPostBack = "true" OnSelectedIndexChanged = "ddlMonth_SelectedIndexChanged" >
        </asp:DropDownList>
        </td>
    <td><asp:Label ID="flblMonth" runat="server" Text="ŒŽ"></asp:Label></td> 
    <td><asp:DropDownList ID="ddlMonth" runat="server" CssClass="form-control" AutoPostBack = "true" 
            OnSelectedIndexChanged = "ddlMonth_SelectedIndexChanged" ></asp:DropDownList></td>
            
    <td><asp:Button ID="btnLast" runat="server" Text="‘OŒŽ" CssClass="btn btn-primary" onclick="btnLast_Click" /></td>                
    <td><asp:Button ID="btnNext" runat="server" Text="ŽŸŒŽ" CssClass="btn btn-primary" onclick="btnNext_Click" /></td>
        
    </tr>
    </table>

    <div class="row">
        <div class="col-md-5">
            <asp:Panel ID="Panel2" runat="server" Height="500px">
                <asp:GridView ID="dgvCalendarF" runat="server" AutoGenerateColumns="False" 
            Width="440px" BorderColor="#000066" 
                BorderStyle="Solid" BorderWidth="1px" 
                style="top: 120px; left: 92px; ">
                    <Columns>
                        <asp:BoundField HeaderText="“ú•t" ItemStyle-CssClass="GVCellLbl_Date" ItemStyle-HorizontalAlign="Center"/>
                        <asp:BoundField HeaderText="—j“ú" ItemStyle-CssClass="GVCellLbl_Date" ItemStyle-HorizontalAlign="Center"/>
                        <asp:TemplateField HeaderText="‹x“ú">
                            <ItemTemplate>
                                <asp:CheckBox ID="ckbh1" runat="server" />
                            </ItemTemplate>
                            <ItemStyle CssClass ="GVCellLbl_Date" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="”­’“ú">
                            <ItemTemplate>
                                <asp:CheckBox ID="ckbp1" runat="server" />
                            </ItemTemplate>
                            <ItemStyle CssClass ="GVCellLbl_Date" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="‰Ò“­ŽžŠÔ(•ª)">
                            <ItemTemplate>
                                <asp:Textbox ID="txtWHour1" runat="server" DecimalPlaces="2"  
                                MaxLength="7" CssClass="form-control">
                                </asp:Textbox>
                            </ItemTemplate>
                            <ItemStyle CssClass="GVCellLbl_StdWorkingHour"/> 
                            <%--<HeaderStyle Width="85px" />--%>
                        </asp:TemplateField>
                    </Columns>
                    <%--<HeaderStyle BackColor="#0066FF" ForeColor="White" />
                    <HeaderStyle CssClass ="GVHeader" />
                    <AlternatingRowStyle CssClass ="GVAlternatingRow" />
                        <RowStyle CssClass="GVRow" />--%>
                </asp:GridView>
            </asp:Panel>
        </div>
        <div class="col-md-5">
            <asp:Panel ID="Panel3" runat="server" Height="500px">
                <asp:GridView ID="dgvCalendarA" runat="server" AutoGenerateColumns="False" 
            Width="440px" BorderColor="#000066" BorderStyle="Solid" 
            BorderWidth="1px" style="top: 120px; left: 482px;">
                    <Columns>
                        <asp:BoundField HeaderText="“ú•t" ItemStyle-CssClass="GVCellLbl_Date" ItemStyle-HorizontalAlign="Center" />                       
                        <asp:BoundField HeaderText="—j“ú" ItemStyle-CssClass="GVCellLbl_Date" ItemStyle-HorizontalAlign="Center"/>
                        <asp:TemplateField HeaderText="‹x“ú">
                            <ItemTemplate>
                                <asp:CheckBox ID="ckbh2" runat="server"  />
                            </ItemTemplate>
                            <ItemStyle CssClass ="GVCellLbl_Date" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="”­’“ú">
                            <ItemTemplate>
                                <asp:CheckBox ID="ckbp2" runat="server"  />
                            </ItemTemplate>
                            <ItemStyle CssClass ="GVCellLbl_Date" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="‰Ò“­ŽžŠÔ(•ª)">
                            <ItemTemplate>
                                <asp:Textbox ID="txtWHour2" runat="server" DecimalPlaces="2" 
                                MaxLength="7" CssClass="form-control">
                                </asp:Textbox>
                            </ItemTemplate>
                            <ItemStyle CssClass="GVCellLbl_StdWorkingHour"/> 
                            <%--<HeaderStyle Width="85px" />--%>
                            <ItemStyle HorizontalAlign="Right" />
                        </asp:TemplateField>
                    </Columns>
                    <%--<HeaderStyle CssClass ="GVHeader" />
                    <AlternatingRowStyle CssClass ="GVAlternatingRow" />
                    <RowStyle CssClass="GVRow" />--%>
                </asp:GridView>
            </asp:Panel>
        </div>
    </div>

</asp:Content>
