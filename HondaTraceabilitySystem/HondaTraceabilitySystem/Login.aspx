<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HondaTraceabilitySystem.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Login - Honda Traceability System</title>

    <link href="Content/bootstrap.css" type="text/css" rel="stylesheet" />
    <link href="Content/site.css" type="text/css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.js" type="text/javascript"></script>
    <script src="Scripts/bootstrap.js" type="text/javascript"></script>

</head>
<body style="background-color:#f5f5f5">
    <form id="WebForm1" method="post" runat="server" class="form-signin" style="width:100%; height:100%;" >
		<div style="width:100%; POSITION: relative;  top:-20px ">
			<%-- <table style=" width: 100%" border="0" cellspacing="0" >
				<tr>
				<td style="width:205px;" rowspan="3" valign="middle">
			    <img src="../../Contents/Image/BackGround/head1.gif" height="58" width="130" border="0" alt=""/>
				</td>
				<td>&nbsp;</td>
				<td width="180px" style="height:25px; width:180px" valign="bottom">
					
                </td>
                <td width="150px">
                   

                </td>
                <td>&nbsp;</td>
                </tr>
                <tr>
                <td style="height:40px" valign="bottom">
                <img src="../../Contents/Image/BackGround/head2.gif" height="18" width="150" border="0" alt=""/>
                </td>
                <td colspan="2" style="background-image:url(../../Contents/Image/BackGround/top-1b.gif); background-position:top; background-repeat:no-repeat; width:65%;">
                		<table width="100%" border="0" style="height:30px">
						<tr>
						<td>&nbsp;</td>
												
						<td style="width:5px; height: 29px"></td>
						</tr>
					    </table>
                </td>
                <td style="width:180px; background-image:url(../../Contents/Image/BackGround/top-2b.gif); background-position:left top;  background-repeat:no-repeat;">
                        <table width="100%" border="0" style="height:30px">
						<tr>
						<td style="width:30px;">
						<img src="../../Contents/Image/BackGround/spacer.gif" width="30px" alt=""/></td>
						<td style="width:130px;" valign="bottom">
							<img src="../../Contents/Image/BackGround/spacer.gif" width="130px" height="30px" alt="" />
						</td>
						<td style="width:5px;">&nbsp;</td>
						</tr>
					    </table>
                </td>
                </tr>
                <tr>
                <td style="width:200px; height:45px;" valign="top" colspan="2">
				
				</td>
				<td colspan="2" style="background-image:url(../../Contents/Image/BackGround/top-3b.gif); background-position:left top;  background-repeat:no-repeat;">
				</td>
				</tr>
			</table> --%>
		</div>
          <h3 class="text-center"><asp:Label ID="Label4" runat="server" Text="Honda Traceability System" ></asp:Label> </h3>
		<table>
		<tr><td>
			<div style="WIDTH: 927px; POSITION: relative; HEIGHT: 471px; left: 250px; top: 0px;" >
				<asp:panel id="pnlKey" 
                    style="Z-INDEX: 103; LEFT: 216px; POSITION: absolute; TOP: 93px; width: 456px; height:278px;" 
                    runat="server">
                         <table style=" width: 100%;" border="0" cellspacing="0">
                         <%-- <tr>
                             <td style="background-image:url(../../Contents/Image/BackGround/corner_01.gif); background-position:bottom right; background-repeat:no-repeat; width:14px; height:14px;"></td>
                             <td style="background-image:url(../../Contents/Image/BackGround/edge_01.gif); background-position:bottom;"></td>
                             <td style="background-image:url(../../Contents/Image/BackGround/corner_02.gif); background-position:bottom left; background-repeat:no-repeat; width:14px; height:14px;"></td>
                         </tr> --%>
                         <tr>
                             <%--<td style="background-image:url(../../Contents/Image/BackGround/edge_03.gif); background-position:right; background-repeat:repeat-y; width:14px; height:200px;"></td>--%>
                             <td style="background-color:#FFFFFF; padding:15px;">
                                 <asp:Label ID="Label1" runat="server" Text="Please enter User ID and Password."  ></asp:Label>
                                <table>
                                <tr>
                                <td style="width:15px;" height="35px">&nbsp;</td>
                                <%--<td >
                                    <img src="../../Contents/Image/BackGround/arrow.gif" alt="" /></td>--%>
                                <td colspan="2">
                                    
                                </td>
                                <td></td>
                                <td style="width:15px">&nbsp;</td>
                                </tr>
                                <tr>
                                <td colspan="2">&nbsp;</td>
                                <td width="100px">
                                    <asp:Label ID="Label2" runat="server" Text="User ID" 
                                     ></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtUserID" runat="server" 
                                        CssClass="form-control"></asp:TextBox></td>
                                <td></td>
                                <td></td>
                                </tr>
                                <tr>
                                <td colspan="2">&nbsp;</td>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="Password" 
                                     ></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtPassword" runat="server" 
                                        CssClass="form-control" TextMode="Password"></asp:TextBox></td>
                                <td></td>
                                <td></td>
                                </tr>
                                <tr>
                                <td colspan="3" height="50px"></td>
                                <td valign="bottom" colspan="2">
                                  
                                    <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-success" Text="Login" OnClick="btnLogin_Click"></asp:Button>
                                     <%--<asp:Button ID="btnPwdChg" runat="server" CssClass="btn btn-danger" Text="Change Password" OnClick="btnPwdChg_Click"></asp:Button>--%>
                                
                                </td>
                                </tr>
                                <!--2013.06.10 add-start-->
                                <%--<tr><td colspan="4"></td>
                                <td align="right">
                                <asp:Label ID="lblVersion" runat="server" CssClass="i_mtitle_b" Style="text-align:right;" Text=""></asp:Label>
                                </td></tr>--%>
                                <!--2013.06.10 add-end-->
                                </table>
                             </td>
                             <%--<td style="background-image:url(../../Contents/Image/BackGround/edge_04.gif); background-position:left; background-repeat:repeat-y; width:14px;"></td>--%>
                         </tr>
                         <tr>
                             <%--<td style="background-image:url(../../Contents/Image/BackGround/corner_03.gif); background-position:top right; background-repeat:no-repeat; width:14px; height:14px;"></td>
                             <td style="background-image:url(../../Contents/Image/BackGround/edge_02.gif); background-position:top;" align="right"></td>
                             <td style="background-image:url(../../Contents/Image/BackGround/corner_04.gif); background-position:top left; background-repeat:no-repeat; width:14px; height:14px;"></td>--%>
                         <td>
                         <asp:Label ID="lblMsg" runat="server" ForeColor="Red" Style="left: 3px; position: absolute;
                            top: 239px; height: 20px; width: 451px;"></asp:Label></td>
                        </tr>
                        </table>                    
                    </asp:panel>
                   <asp:Panel ID="pnlConfirm" runat="server" BackColor="#C0C0FF" Height="208px" Style="z-index: 104;
            left: 187px; position: absolute; top: 98px" Width="502px" BorderColor="Navy" 
                BorderStyle="Double" Visible="False">
            <asp:Label ID="lblDays" runat="server" Style="z-index: 100; left: 251px; position: absolute;
                top: 41px"></asp:Label>
            <asp:Label ID="flblPwdMsg1" runat="server" Style="z-index: 101; left: 67px; position: absolute;
                top: 40px" Text="Your password will expire in " Width="180px"></asp:Label>
            <asp:Label ID="flblPwdMsg2" runat="server" Style="z-index: 102; left: 291px; position: absolute;
                top: 41px" Text="days." Width="61px"></asp:Label>
            <asp:Button ID="btnChgPwd" runat="server" Style="z-index: 103; left: 95px; position: absolute;
                top: 128px" Text="Change Password" Width="126px" OnClick="btnChgPwd_Click" />
            <asp:Button ID="btnContinue" runat="server" Style="z-index: 104; left: 252px; position: absolute;
                top: 128px" Text="Continue" Width="128px" OnClick="btnContinue_Click" />
            <asp:Label ID="flblPwdMsg3" runat="server" Style="z-index: 106; left: 65px; position: absolute;
                top: 77px" Text="Are you going to change your password now ?" Width="291px"></asp:Label>
        </asp:Panel>
         
				<table id="tblSelect" style="Z-INDEX: 106; LEFT: 8px; WIDTH: 120px; POSITION: absolute; TOP: 12px;  border-color:#ffffff;" cellspacing="0" bordercolordark="#ffffff" cellpadding="2" width="120" bordercolorlight="#ffffff" border="0" runat="server">
					</table>
				
			</div>
        </td>
        </tr>
		</table>
		<%-- <table border="0" cellpadding="0" cellspacing="0" style="height:27px;" 
                width="100%">
                <tr>
                    <td style="height: 16px; background-image: url(../../Contents/Image/new/footer.gif); background-position: right top; background-repeat: no-repeat;" 
                        width="50%">
                        <img height="16" src="../../Contents/Image/BackGround/spacer.gif" width="16" 
                            alt=""/></td>
                    <td style="height:16px;">
                        <img alt="" src="../../Contents/Image/BackGround/copyright.gif" /></td>
                </tr>
                <tr>
                    <td colspan="2" style="height:15px;background-image: url(../../Contents/Image/BackGround/bottom.png);  background-repeat: repeat;">
                    </td>
                </tr>
            </table> --%>
        <asp:HiddenField ID="hdnUpdMode" runat="server" />
        <asp:HiddenField ID="hdnInputMode" runat="server" />
    </form>
</body>
</html>
