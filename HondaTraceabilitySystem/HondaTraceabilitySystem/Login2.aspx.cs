using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IMClass;
using System.Collections;
using System.Data;
using System.Text;

namespace HondaTraceabilitySystem
{
    public partial class Login2 : System.Web.UI.Page
    {
        protected string g_menu_grp;

        protected void Page_Load(object sender, EventArgs e)
        {

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
                    Response.Redirect("Default2.aspx");
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
                    // ログイン情報をクッキーに書き込む
                    //Wite_Cookie(user);

                    // パスワード変更画面の表示
                    //Response.Redirect("~/Common/Login/frmPwdChg.aspx?program_id=" + g_menu_grp + "&level=0" + "&Psd_Flag=0");
                    //msg = new Message(user.user_id, user.lang);
                    //lblMsg.Text = msg.GetMessage("USER_UNMATCH_ERR");
                    //break;

                // その他、予期せぬエラー
                default:
                    msg = new Message(user.user_id, user.lang);
                    lblMsg.Text = msg.GetMessage("UNEXPECTED_ERR");
                    break;
            }
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

    }
}