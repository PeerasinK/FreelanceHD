using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using IMClass;
using System.IO;
using System.Text;

namespace HondaTraceabilitySystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected string g_menu_grp;

        protected void Page_Load(object sender, EventArgs e)
        {
            //バージョン情報の読み込み      //2013.06.10 add
            //lblVersion.Text = string.Empty;
            //try
            //{
            //    StreamReader sr = new StreamReader(Server.MapPath("~/Version.txt"), Encoding.GetEncoding("Shift_JIS"));
            //    lblVersion.Text = sr.ReadToEnd().Trim();
            //    sr.Close();
            //}
            //catch
            //{

            //}

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            // Loginボタンが押されたとき
            User user = new User();

            user.user_id = txtUserID.Text;
            user.login_password = txtPassword.Text;

            int rtn = user.Login();

            switch (rtn)
            {
                // ログイン成功
                case ComConst.SUCCEED:
                    // ログイン情報をクッキーに書き込む
                    Wite_Cookie(user);

                    // パスワード変更警告画面
                    //if (user.end_eff_date > 0)
                    //{
                    //    Dictionary dic = new Dictionary(user.user_id, user.lang);
                    //    dic.screen_id = "Login";
                    //    DataSet ds = dic.GetLabelOfScreenList();

                    //    if (ds != null && ds.Tables.Count > 0)
                    //    {
                    //        foreach (DataRow row in ds.Tables[0].Rows)
                    //        {
                    //            switch (row["CONTROL_ID"].ToString())
                    //            {
                    //                case "flblPwdMsg1":
                    //                    flblPwdMsg1.Text = row["ITEM_DESC"].ToString();
                    //                    break;
                    //                case "flblPwdMsg2":
                    //                    flblPwdMsg2.Text = row["ITEM_DESC"].ToString();
                    //                    break;
                    //                case "flblPwdMsg3":
                    //                    flblPwdMsg3.Text = row["ITEM_DESC"].ToString();
                    //                    break;
                    //                case "btnChgPwd":
                    //                    btnChgPwd.Text = row["ITEM_DESC"].ToString();
                    //                    break;
                    //                case "btnContinue":
                    //                    btnContinue.Text = row["ITEM_DESC"].ToString();
                    //                    break;
                    //            }
                    //        }

                    //        pnlConfirm.Visible = true;
                    //        lblDays.Text = user.end_eff_date.ToString();
                    //        return;

                    //    }

                    //}

                    // メニュー画面の表示
                    //Response.Redirect("../../Default.aspx?menu_grp=");
                    Response.Redirect("Default.aspx");
                    break;

                // ユーザーが存在しない
                case ComConst.USER_UNMATCH:
                    Message msg = new Message(user.user_id, user.lang);
                    lblMsg.Text = msg.GetMessage("USER_UNMATCH_ERR");
                    break;

                // パスワード不一致
                case ComConst.PWD_UNMATCH:
                    msg = new Message(user.user_id, user.lang);
                    lblMsg.Text = msg.GetMessage("PWD_UNMATCH_ERR");
                    break;

                // アカウントロック
                //case ComConst.USER_LOCKED:
                //    msg = new Message(user.user_id, user.lang);
                //    lblMsg.Text = msg.GetMessage("USER_LOCKED_ERR");
                //    break;

                // パスワード変更
                //case ComConst.PWD_CHG:
                //    // ログイン情報をクッキーに書き込む
                //    Wite_Cookie(user);

                //    // パスワード変更画面の表示
                //    //Response.Redirect("~/Common/Login/frmPwdChg.aspx?program_id=" + g_menu_grp + "&level=0" + "&Psd_Flag=0");
                //    msg = new Message(user.user_id, user.lang);
                //    lblMsg.Text = msg.GetMessage("USER_UNMATCH_ERR");
                //    break;

                // その他、予期せぬエラー
                default:
                    msg = new Message(user.user_id, user.lang);
                    lblMsg.Text = msg.GetMessage("UNEXPECTED_ERR");
                    break;
            }
        }

        protected void btnPwdChg_Click(object sender, EventArgs e)
        {
            //Password変更ボタンが押されたとき
            //User user = new User();

            //user.user_id = txtUserID.Text;
            //user.login_password = txtPassword.Text;

            //int rtn = user.Login();

            //switch (rtn)
            //{
            //    // ログイン成功
            //    case ComConst.SUCCEED:
            //        // ログイン情報をクッキーに書き込む
            //        Wite_Cookie(user);
            //        // パスワード変更画面の表示
            //        Response.Redirect("~/Common/Login/frmPwdChg.aspx?program_id=" + g_menu_grp + "&level=0" + "&Psd_Flag=0" + "&USERID=" + txtUserID.Text);
            //        break;

            //    // ユーザーが存在しない
            //    case ComConst.USER_UNMATCH:
            //        Message msg = new Message(user.user_id, user.lang);
            //        lblMsg.Text = msg.GetMessage("USER_UNMATCH_ERR");
            //        break;

            //    // パスワード不一致
            //    case ComConst.PWD_UNMATCH:
            //        msg = new Message(user.user_id, user.lang);
            //        lblMsg.Text = msg.GetMessage("PWD_UNMATCH_ERR");
            //        break;

            //    // アカウントロック
            //    case ComConst.USER_LOCKED:
            //        msg = new Message(user.user_id, user.lang);
            //        lblMsg.Text = msg.GetMessage("USER_LOCKED_ERR");
            //        break;

            //    // パスワード変更
            //    case ComConst.PWD_CHG:
            //        // ログイン情報をクッキーに書き込む
            //        Wite_Cookie(user);

            //        // パスワード変更画面の表示
            //        Response.Redirect("~/Common/Login/frmPwdChg.aspx?program_id=" + g_menu_grp + "&level=0" + "&Psd_Flag=0" + "&USERID=" + txtUserID.Text);
            //        break;

            //    // その他、予期せぬエラー
            //    default:
            //        msg = new Message(user.user_id, user.lang);
            //        lblMsg.Text = msg.GetMessage("UNEXPECTED_ERR");
            //        break;
            //}
        }

        protected void Wite_Cookie(User user)
        {
            SystemParameter sys = new SystemParameter(user.user_id, user.lang);
            HttpCookie MyCookie = new HttpCookie("IMLastVisit");

            // ログイン情報をクッキーに書き込む
            MyCookie.Values["USER_ID"] = user.user_id;
            MyCookie.Values["LANG"] = user.lang.ToString();
            MyCookie.Values["COMPANY_CD"] = ""; // user.company_cd;
            MyCookie.Values["NAME"] = HttpUtility.UrlEncode(user.name);
            //MyCookie.Values["NAME"] = user.name;
            //トップメニューグループ

            //MyCookie.Values["MENU_GRP0"] = user.menu_grp;
            MyCookie.Values["MENU_GRP0"] = user.dept_cd;
            g_menu_grp = user.menu_grp;
            MyCookie.Values["LEVEL"] = user.mgmt_no;

            //******** ADD BY LIU *********
            //sys.key01 = "PRINT_LANG";
            //sys.key02 = "*";
            //sys.key03 = "*";
            //sys.key04 = "*";
            //if (sys.GetDetail() == ComConst.SUCCEED)
            //{
            //    MyCookie.Values["PRINT_LANG"] = sys.data_int.ToString();
            //}
            //else
            //{
            //    MyCookie.Values["PRINT_LANG"] = "1";
            //}

            Response.Cookies.Add(MyCookie);

        }

        //
        // パスワード有効期限間近の確認画面でパスワード変更時の処理
        //
        protected void btnChgPwd_Click(object sender, EventArgs e)
        {
            // パスワード変更画面の表示
            //Response.Redirect("~/Common/Login/frmPwdChg.aspx?program_id=" + g_menu_grp + "&level=0" + "&Psd_Flag=0" + "&USERID=" + txtUserID.Text);
        }

        //
        // パスワード有効期限間近の確認画面で続行時の処理
        //
        protected void btnContinue_Click(object sender, EventArgs e)
        {
            // メニュー画面の表示
            //Response.Redirect("../../Default.aspx?program_id=" + g_menu_grp + "&level=0");
        }
    }
}