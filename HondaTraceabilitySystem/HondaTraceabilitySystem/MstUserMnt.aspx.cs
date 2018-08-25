using System;
using System.Collections;
using System.Collections.Generic;
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
using System.Drawing;

namespace HondaTraceabilitySystem
{
    public partial class MstUserMnt : System.Web.UI.Page
    {
        protected string g_user_id;
        protected int g_lang;
        protected string g_company_cd;
        protected string g_name;
        //protected string user_id;

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie MyCookie;

            try
            {
                MyCookie = new HttpCookie("IMLastVisit");
                HttpCookieCollection MyCookieColl = Request.Cookies;
                MyCookie = MyCookieColl.Get("IMLastVisit");

                g_user_id = MyCookie.Values["USER_ID"];
                g_lang = int.Parse(MyCookie.Values["LANG"]);
                g_company_cd = MyCookie.Values["COMPANY_CD"];
                g_name = HttpUtility.UrlDecode(MyCookie.Values["NAME"]);
                //user_id = Request.QueryString["USERID"];

            }
            catch
            {
                //Response.Redirect("~/NotLoginErr.htm");
            }
            // 検索画面追加[初期処理より処理の前に記述]
            //g_user_id = "admin-e";
            //g_lang = 2;
            //g_name = "General manager (English)";
            //Add_Search();

            if (!IsPostBack)
            {
                // 画面編集

                txtUserId.Text = g_user_id;
                Init_Label();
                Init_Proc();
                cmdDisp_Click(null, null);
            }
            else
            {

            }
            lblMsg.Text = "";
        }

        protected void Init_Label()
        {

            //Dictionary dic = new Dictionary(g_user_id, g_lang);
            //dic.screen_id = "MstUserMnt_frmMain";
            //DataSet ds = dic.GetLabelOfScreenList();

            //if (ds != null && ds.Tables.Count > 0)
            //{
            //    foreach (DataRow row in ds.Tables[0].Rows)
            //    {
            //        switch (row["CONTROL_ID"].ToString())
            //        {
            //            // ラベル
            //            case "flblTitle": flblTitle.Text = row["ITEM_DESC"].ToString(); break;
            //            case "flblUserId": flblUserId.Text = row["ITEM_DESC"].ToString(); break;
            //            //case "flblLang": flblLang.Text = row["ITEM_DESC"].ToString(); break;
            //            //case "flblFamilyName": flblFamilyName.Text = row["ITEM_DESC"].ToString(); break;
            //            case "flblFamilyName": flblLastName.Text = row["ITEM_DESC"].ToString(); break;
            //            case "flblFirstName": flblFirstName.Text = row["ITEM_DESC"].ToString(); break;
            //            //case "flblEmailSendFlag": flblEmailSendFlag.Text = row["ITEM_DESC"].ToString(); break;
            //            //case "flblEmail": flblEmail.Text = row["ITEM_DESC"].ToString(); break;
            //            //case "flblTelNo": flblTelNo.Text = row["ITEM_DESC"].ToString(); break;
            //            //case "flblMenuGrp": flblMenuGrp.Text = row["ITEM_DESC"].ToString(); break;
            //        }
            //    }
            //}
            //switch (g_lang)
            //{
            //    case 1:
            //        //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-1.jpg";
            //        //cmdDisp.Attributes["onmouseover"] = "MM_swapImage('" + cmdDisp.ClientID + "','','../../Contents/Image/BackGround/btn-ind2-1.jpg',1);";
            //        //cmdDisp.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update1-1.jpg";
            //        //cmdUpdate.Attributes["onmouseover"] = "MM_swapImage('" + cmdUpdate.ClientID + "','','../../Contents/Image/BackGround/btn-update2-1.jpg',1);";
            //        //cmdUpdate.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdRole.ImageUrl = "../../Contents/Image/BackGround/btn-role1-1.jpg";
            //        //cmdRole.Attributes["onmouseover"] = "MM_swapImage('" + cmdRole.ClientID + "','','../../Contents/Image/BackGround/btn-role2-1.jpg',1);";
            //        //cmdRole.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdPassWord.ImageUrl = "../../Contents/Image/BackGround/btn-password_reset1-1.jpg";
            //        //cmdPassWord.Attributes["onmouseover"] = "MM_swapImage('" + cmdPassWord.ClientID + "','','../../Contents/Image/BackGround/btn-password_reset2-1.jpg',1);";
            //        //cmdPassWord.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdCancel.ImageUrl = "../../Contents/Image/BackGround/btn-cancel1-1.jpg";
            //        //cmdCancel.Attributes["onmouseover"] = "MM_swapImage('" + cmdCancel.ClientID + "','','../../Contents/Image/BackGround/btn-cancel2-1.jpg',1);";
            //        //cmdCancel.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        break;
            //    case 2:
            //        //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-2.jpg";
            //        //cmdDisp.Attributes["onmouseover"] = "MM_swapImage('" + cmdDisp.ClientID + "','','../../Contents/Image/BackGround/btn-ind2-2.jpg',1);";
            //        //cmdDisp.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update1-2.jpg";
            //        //cmdUpdate.Attributes["onmouseover"] = "MM_swapImage('" + cmdUpdate.ClientID + "','','../../Contents/Image/BackGround/btn-update2-2.jpg',1);";
            //        //cmdUpdate.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdRole.ImageUrl = "../../Contents/Image/BackGround/btn-role1-2.jpg";
            //        //cmdRole.Attributes["onmouseover"] = "MM_swapImage('" + cmdRole.ClientID + "','','../../Contents/Image/BackGround/btn-role2-2.jpg',1);";
            //        //cmdRole.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdPassWord.ImageUrl = "../../Contents/Image/BackGround/btn-password_reset1-2.jpg";
            //        //cmdPassWord.Attributes["onmouseover"] = "MM_swapImage('" + cmdPassWord.ClientID + "','','../../Contents/Image/BackGround/btn-password_reset2-2.jpg',1);";
            //        //cmdPassWord.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdCancel.ImageUrl = "../../Contents/Image/BackGround/btn-cancel1-2.jpg";
            //        //cmdCancel.Attributes["onmouseover"] = "MM_swapImage('" + cmdCancel.ClientID + "','','../../Contents/Image/BackGround/btn-cancel2-2.jpg',1);";
            //        //cmdCancel.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        break;
            //    case 3:
            //        //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-3.jpg";
            //        //cmdDisp.Attributes["onmouseover"] = "MM_swapImage('" + cmdDisp.ClientID + "','','../../Contents/Image/BackGround/btn-ind2-3.jpg',1);";
            //        //cmdDisp.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update1-3.jpg";
            //        //cmdUpdate.Attributes["onmouseover"] = "MM_swapImage('" + cmdUpdate.ClientID + "','','../../Contents/Image/BackGround/btn-update2-3.jpg',1);";
            //        //cmdUpdate.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdRole.ImageUrl = "../../Contents/Image/BackGround/btn-role1-3.jpg";
            //        //cmdRole.Attributes["onmouseover"] = "MM_swapImage('" + cmdRole.ClientID + "','','../../Contents/Image/BackGround/btn-role2-3.jpg',1);";
            //        //cmdRole.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdPassWord.ImageUrl = "../../Contents/Image/BackGround/btn-password_reset1-3.jpg";
            //        //cmdPassWord.Attributes["onmouseover"] = "MM_swapImage('" + cmdPassWord.ClientID + "','','../../Contents/Image/BackGround/btn-password_reset2-3.jpg',1);";
            //        //cmdPassWord.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdCancel.ImageUrl = "../../Contents/Image/BackGround/btn-cancel1-3.jpg";
            //        //cmdCancel.Attributes["onmouseover"] = "MM_swapImage('" + cmdCancel.ClientID + "','','../../Contents/Image/BackGround/btn-cancel2-3.jpg',1);";
            //        //cmdCancel.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        break;
            //    case 4:
            //        //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-4.jpg";
            //        //cmdDisp.Attributes["onmouseover"] = "MM_swapImage('" + cmdDisp.ClientID + "','','../../Contents/Image/BackGround/btn-ind2-4.jpg',1);";
            //        //cmdDisp.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update1-4.jpg";
            //        //cmdUpdate.Attributes["onmouseover"] = "MM_swapImage('" + cmdUpdate.ClientID + "','','../../Contents/Image/BackGround/btn-update2-4.jpg',1);";
            //        //cmdUpdate.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdRole.ImageUrl = "../../Contents/Image/BackGround/btn-role1-4.jpg";
            //        //cmdRole.Attributes["onmouseover"] = "MM_swapImage('" + cmdRole + "','','../../Contents/Image/BackGround/btn-role2-4.jpg',1);";
            //        //cmdRole.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdPassWord.ImageUrl = "../../Contents/Image/BackGround/btn-password_reset1-4.jpg";
            //        //cmdPassWord.Attributes["onmouseover"] = "MM_swapImage('" + cmdPassWord.ClientID + "','','../../Contents/Image/BackGround/btn-password_reset2-4.jpg',1);";
            //        //cmdPassWord.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdCancel.ImageUrl = "../../Contents/Image/BackGround/btn-cancel1-4.jpg";
            //        //cmdCancel.Attributes["onmouseover"] = "MM_swapImage('" + cmdCancel.ClientID + "','','../../Contents/Image/BackGround/btn-cancel2-4.jpg',1);";
            //        //cmdCancel.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        break;
            //}

            //btnUSERSearch.Attributes["onmouseover"] = "MM_swapImage('" + btnUSERSearch.ClientID + "','','../../Contents/Image/BackGround/sbtn_srch_f2.gif',1);";
            //btnUSERSearch.Attributes["onmouseout"] = "MM_swapImgRestore();";
            flblTitle.Text = "User Master";
            Init_Mode();

        }

        protected void Init_Mode()
        {
            //
            // モード系ボタンイメージの編集     －      言語対応とSwapImage
            //
            switch (g_lang)
            {
                case 1:
                    //btnMdsp.ImageUrl = "../../Contents/Image/BackGround/btn-inq1-1.jpg";
                    //btnMdsp.Attributes["onmouseover"] = "MM_swapImage('" + btnMdsp.ClientID + "','','../../Contents/Image/BackGround/btn-inq2-1.jpg',1);";
                    //btnMdsp.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //btnMadd.ImageUrl = "../../Contents/Image/BackGround/btn-new1-1.jpg";
                    //btnMadd.Attributes["onmouseover"] = "MM_swapImage('" + btnMadd.ClientID + "','','../../Contents/Image/BackGround/btn-new2-1.jpg',1);";
                    //btnMadd.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //btnMupd.ImageUrl = "../../Contents/Image/BackGround/btn-change1-1.jpg";
                    //btnMupd.Attributes["onmouseover"] = "MM_swapImage('" + btnMupd.ClientID + "','','../../Contents/Image/BackGround/btn-change2-1.jpg',1);";
                    //btnMupd.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //btnMdel.ImageUrl = "../../Contents/Image/BackGround/btn-delete1-1.jpg";
                    //btnMdel.Attributes["onmouseover"] = "MM_swapImage('" + btnMdel.ClientID + "','','../../Contents/Image/BackGround/btn-delete2-1.jpg',1);";
                    //btnMdel.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    break;
                case 2:
                    //btnMdsp.ImageUrl = "../../Contents/Image/BackGround/btn-inq1-2.jpg";
                    //btnMdsp.Attributes["onmouseover"] = "MM_swapImage('" + btnMdsp.ClientID + "','','../../Contents/Image/BackGround/btn-inq2-2.jpg',1);";
                    //btnMdsp.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //btnMadd.ImageUrl = "../../Contents/Image/BackGround/btn-new1-2.jpg";
                    //btnMadd.Attributes["onmouseover"] = "MM_swapImage('" + btnMadd.ClientID + "','','../../Contents/Image/BackGround/btn-new2-2.jpg',1);";
                    //btnMadd.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //btnMupd.ImageUrl = "../../Contents/Image/BackGround/btn-change1-2.jpg";
                    //btnMupd.Attributes["onmouseover"] = "MM_swapImage('" + btnMupd.ClientID + "','','../../Contents/Image/BackGround/btn-change2-2.jpg',1);";
                    //btnMupd.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //btnMdel.ImageUrl = "../../Contents/Image/BackGround/btn-delete1-2.jpg";
                    //btnMdel.Attributes["onmouseover"] = "MM_swapImage('" + btnMdel.ClientID + "','','../../Contents/Image/BackGround/btn-delete2-2.jpg',1);";
                    //btnMdel.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    break;
                case 3:
                    //btnMdsp.ImageUrl = "../../Contents/Image/BackGround/btn-inq1-3.jpg";
                    //btnMdsp.Attributes["onmouseover"] = "MM_swapImage('" + btnMdsp.ClientID + "','','../../Contents/Image/BackGround/btn-inq2-3.jpg',1);";
                    //btnMdsp.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //btnMadd.ImageUrl = "../../Contents/Image/BackGround/btn-new1-3.jpg";
                    //btnMadd.Attributes["onmouseover"] = "MM_swapImage('" + btnMadd.ClientID + "','','../../Contents/Image/BackGround/btn-new2-3.jpg',1);";
                    //btnMadd.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //btnMupd.ImageUrl = "../../Contents/Image/BackGround/btn-change1-3.jpg";
                    //btnMupd.Attributes["onmouseover"] = "MM_swapImage('" + btnMupd.ClientID + "','','../../Contents/Image/BackGround/btn-change2-3.jpg',1);";
                    //btnMupd.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //btnMdel.ImageUrl = "../../Contents/Image/BackGround/btn-delete1-3.jpg";
                    //btnMdel.Attributes["onmouseover"] = "MM_swapImage('" + btnMdel.ClientID + "','','../../Contents/Image/BackGround/btn-delete2-3.jpg',1);";
                    //btnMdel.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    break;
                case 4:
                    //btnMdsp.ImageUrl = "../../Contents/Image/BackGround/btn-inq1-4.jpg";
                    //btnMdsp.Attributes["onmouseover"] = "MM_swapImage('" + btnMdsp.ClientID + "','','../../Contents/Image/BackGround/btn-inq2-4.jpg',1);";
                    //btnMdsp.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //btnMadd.ImageUrl = "../../Contents/Image/BackGround/btn-new1-4.jpg";
                    //btnMadd.Attributes["onmouseover"] = "MM_swapImage('" + btnMadd.ClientID + "','','../../Contents/Image/BackGround/btn-new2-4.jpg',1);";
                    //btnMadd.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //btnMupd.ImageUrl = "../../Contents/Image/BackGround/btn-change1-4.jpg";
                    //btnMupd.Attributes["onmouseover"] = "MM_swapImage('" + btnMupd.ClientID + "','','../../Contents/Image/BackGround/btn-change2-4.jpg',1);";
                    //btnMupd.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //btnMdel.ImageUrl = "../../Contents/Image/BackGround/btn-delete1-4.jpg";
                    //btnMdel.Attributes["onmouseover"] = "MM_swapImage('" + btnMdel.ClientID + "','','../../Contents/Image/BackGround/btn-delete2-4.jpg',1);";
                    //btnMdel.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    break;
            }
        }

        /// <summary>
        /// 初期画面権限編集
        /// </summary>
        protected void Auth_Proc()
        {
            IM_Menu menu = new IM_Menu(g_user_id, g_lang);
            menu.user_id = g_user_id;
            menu.program_id = "MstUserMnt";
            menu.GetUserProgramAuthority();
            int g_auth = menu.executable_flag;
            if (g_auth == 2)//実行権限=2（変更）の場合、照会、新規、変更、削除ボタンを選択可に制御する。
            {
                //do nothing
            }
            else//実行権限=1（照会）の場合、照会のみ選択可にして、新規、変更、削除ボタンは選択不可に制御する。
            {
                btnMadd.Enabled = false;
                btnMdel.Enabled = false;
                btnMupd.Enabled = false;
                //cmdPassWord.Enabled = false;
                switch (g_lang)
                {
                    case 1:
                        //btnMadd.ImageUrl = "../../Contents/Image/BackGround/btn-new4-1.jpg";
                        //btnMupd.ImageUrl = "../../Contents/Image/BackGround/btn-change4-1.jpg";
                        //btnMdel.ImageUrl = "../../Contents/Image/BackGround/btn-delete4-1.jpg";
                        //cmdPassWord.ImageUrl = "../../Contents/Image/BackGround/btn-password_reset3-1.jpg";
                        break;
                    case 2:
                        //btnMadd.ImageUrl = "../../Contents/Image/BackGround/btn-new4-2.jpg";
                        //btnMupd.ImageUrl = "../../Contents/Image/BackGround/btn-change4-2.jpg";
                        //btnMdel.ImageUrl = "../../Contents/Image/BackGround/btn-delete4-2.jpg";
                        //cmdPassWord.ImageUrl = "../../Contents/Image/BackGround/btn-password_reset3-2.jpg";
                        break;
                    case 3:
                        //btnMadd.ImageUrl = "../../Contents/Image/BackGround/btn-new4-3.jpg";
                        //btnMupd.ImageUrl = "../../Contents/Image/BackGround/btn-change4-3.jpg";
                        //btnMdel.ImageUrl = "../../Contents/Image/BackGround/btn-delete4-3.jpg";
                        //cmdPassWord.ImageUrl = "../../Contents/Image/BackGround/btn-password_reset3-3.jpg";
                        break;
                    case 4:
                        //btnMadd.ImageUrl = "../../Contents/Image/BackGround/btn-new4-4.jpg";
                        //btnMupd.ImageUrl = "../../Contents/Image/BackGround/btn-change4-4.jpg";
                        //btnMdel.ImageUrl = "../../Contents/Image/BackGround/btn-delete4-4.jpg";
                        //cmdPassWord.ImageUrl = "../../Contents/Image/BackGround/btn-password_reset3-4.jpg";
                        break;
                }
            }
        }

        protected void Screen_Control(string pUpdMode)
        {
            ComLibrary com = new ComLibrary();
            // モードボタンを選択状態から戻す
            Init_Mode();
            btnMdsp.Enabled = true;
            btnMadd.Enabled = true;
            btnMupd.Enabled = true;
            btnMdel.Enabled = true;
            hdnUpdMode.Value = pUpdMode;
            //Auth_Proc();//ADD BY UBIQ-LIU 2010/8/4
            // モードボタンを選択状態にする
            switch (pUpdMode)
            {
                case "0":   // 照会
                    cmdDisp.Enabled = true;

                    btnMdsp.Enabled = false;
                    switch (g_lang)
                    {
                        case 1:
                            //btnMdsp.ImageUrl = "../../Contents/Image/BackGround/btn-inq3-1.jpg";
                            break;
                        case 2:
                            //btnMdsp.ImageUrl = "../../Contents/Image/BackGround/btn-inq3-2.jpg";
                            break;
                        case 3:
                            //btnMdsp.ImageUrl = "../../Contents/Image/BackGround/btn-inq3-3.jpg";
                            break;
                        case 4:
                            //btnMdsp.ImageUrl = "../../Contents/Image/BackGround/btn-inq3-4.jpg";
                            break;
                    }
                    break;
                case "1":   // 新規
                    btnMadd.Enabled = false;
                    switch (g_lang)
                    {
                        case 1:
                            //btnMadd.ImageUrl = "../../Contents/Image/BackGround/btn-new3-1.jpg";
                            break;
                        case 2:
                            //btnMadd.ImageUrl = "../../Contents/Image/BackGround/btn-new3-2.jpg";
                            break;
                        case 3:
                            //btnMadd.ImageUrl = "../../Contents/Image/BackGround/btn-new3-3.jpg";
                            break;
                        case 4:
                            //btnMadd.ImageUrl = "../../Contents/Image/BackGround/btn-new3-4.jpg";
                            break;
                    }
                    break;
                case "2":   // 変更
                    btnMupd.Enabled = false;
                    switch (g_lang)
                    {
                        case 1:
                            //btnMupd.ImageUrl = "../../Contents/Image/BackGround/btn-change3-1.jpg";
                            break;
                        case 2:
                            //btnMupd.ImageUrl = "../../Contents/Image/BackGround/btn-change3-2.jpg";
                            break;
                        case 3:
                            //btnMupd.ImageUrl = "../../Contents/Image/BackGround/btn-change3-3.jpg";
                            break;
                        case 4:
                            //btnMupd.ImageUrl = "../../Contents/Image/BackGround/btn-change3-4.jpg";
                            break;
                    }
                    break;
                case "3":   // 削除
                    btnMdel.Enabled = false;
                    switch (g_lang)
                    {
                        case 1:
                            //btnMdel.ImageUrl = "../../Contents/Image/BackGround/btn-delete3-1.jpg";
                            break;
                        case 2:
                            //btnMdel.ImageUrl = "../../Contents/Image/BackGround/btn-delete3-2.jpg";
                            break;
                        case 3:
                            //btnMdel.ImageUrl = "../../Contents/Image/BackGround/btn-delete3-3.jpg";
                            break;
                        case 4:
                            //btnMdel.ImageUrl = "../../Contents/Image/BackGround/btn-delete3-4.jpg";
                            break;
                    }
                    break;
            }
            // 画面プロテクト
            switch (hdnInputMode.Value)
            {
                case "0":
                    com.Set_Attributes(Div0, 1);
                    com.Set_Attributes(Div1, 0);
                    cmdUpdate.Enabled = false;
                    btnUSERSearch.Visible = true;
                    cmdDisp.Enabled = true;
                    switch (g_lang)
                    {
                        case 1:
                            //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-1.jpg";
                            //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update3-1.jpg";
                            break;
                        case 2:
                            //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-2.jpg";
                            //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update3-2.jpg";
                            break;
                        case 3:
                            //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-3.jpg";
                            //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update3-3.jpg";
                            break;
                        case 4:
                            //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-4.jpg";
                            //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update3-4.jpg";
                            break;
                    }
                    com.SetInitialFocus(txtUserId);
                    break;
                case "1":
                    if (hdnUpdMode.Value == "0")
                    {
                        cmdDisp.Enabled = true;
                        cmdUpdate.Enabled = false;
                        switch (g_lang)
                        {
                            case 1:
                                //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-1.jpg";
                                //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update3-1.jpg";
                                break;
                            case 2:
                                //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-2.jpg";
                                //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update3-2.jpg";
                                break;
                            case 3:
                                //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-3.jpg";
                                //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update3-3.jpg";
                                break;
                            case 4:
                                //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-4.jpg";
                                //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update3-4.jpg";
                                break;
                        }
                    }
                    else
                    {
                        cmdUpdate.Enabled = true;
                        cmdDisp.Enabled = false;
                        switch (g_lang)
                        {
                            case 1:
                                //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind3-1.jpg";
                                //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update1-1.jpg";
                                break;
                            case 2:
                                //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind3-2.jpg";
                                //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update1-2.jpg";
                                break;
                            case 3:
                                //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind3-3.jpg";
                                //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update1-3.jpg";
                                break;
                            case 4:
                                //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind3-4.jpg";
                                //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update1-4.jpg";
                                break;
                        }
                    }
                    if (hdnUpdMode.Value == "0" || hdnUpdMode.Value == "3")
                    {
                        com.Set_Attributes(Div0, 1);
                        com.Set_Attributes(Div1, 0);
                        btnUSERSearch.Visible = true;

                    }
                    else
                    {
                        com.Set_Attributes(Div0, 0);
                        com.Set_Attributes(Div1, 1);
                        btnUSERSearch.Visible = false;
                    }
                    break;
            }
        }

        protected void Init_Proc()
        {
            // 初期状態は照会モードとする
            ddl_edit();
            hdnInputMode.Value = "0";

            Screen_Control("0");
        }

        protected void ddl_edit()
        {
            DataSet dt = new DataSet();
            ComLibrary com = new ComLibrary();
            Role role = new Role(g_user_id, g_lang);

            dt = role.GetRoleList();
            ddl_USER_GROUP.DataValueField = "USER_GROUP_CODE";
            ddl_USER_GROUP.DataTextField = "USER_GROUP_NAME";
            ddl_USER_GROUP.DataSource = dt;
            ddl_USER_GROUP.DataBind();
            ddl_USER_GROUP.Items.Insert(0, "");

            dt = null;

            Dept dept = new Dept(g_user_id, g_lang);

            dt = dept.GetDEPTList();
            ddl_DEPT_NO.DataValueField = "DEPT_NO";
            ddl_DEPT_NO.DataTextField = "DEPT_NAME";
            ddl_DEPT_NO.DataSource = dt;
            ddl_DEPT_NO.DataBind();
            ddl_DEPT_NO.Items.Insert(0, "");

            dt = null;

            Mgmt mgmt = new Mgmt(g_user_id, g_lang);

            dt = mgmt.GetMGMTList();
            ddl_MGMT_LEVEL.DataValueField = "MANAGEMENT_LEVEL";
            ddl_MGMT_LEVEL.DataTextField = "MANAGEMENT_DESCRIPTION";
            ddl_MGMT_LEVEL.DataSource = dt;
            ddl_MGMT_LEVEL.DataBind();
            ddl_MGMT_LEVEL.Items.Insert(0, "");            
        }

        protected void Add_Search()
        {
            // 用户検索画面
            //Search srch = new Search();
            //srch.search_type = Search.SearchType.USER;
            //srch.opener = this;
            //srch.opener_button = btnUSERSearch;
            /*** ADD 20090629 UBIQ-LIU  ***/
            //srch.submit_type = 1;
            //srch.btn_id = btnSearchSubmit.ClientID;
            /***            END         ***/
            //ArrayList arrObj = new ArrayList();
            //arrObj.Add(txtUserId);
            //srch.return_controls = arrObj;
            //int rtn = srch.CreateSearchWindow();
        }

        protected void btnSearchSubmit_Click(object sender, EventArgs e)
        {
            cmdDisp_Click(null, null);
        }

        protected void cmdDisp_Click(object sender, EventArgs e)
        {
            Edit_Screen();
        }

        protected void Edit_Screen()
        {
            ComLibrary com = new ComLibrary();
            Message msg = new Message(g_user_id, g_lang);
            int rtn = 0;
            if (txtUserId.Text.Trim() == "")
            {
                lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblUserId.Text + ")";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            User us = new User(g_user_id, g_lang);
            us.user_id = txtUserId.Text;
            rtn = us.GetDetail();

            if (rtn == ComConst.FAILED)
            {
                if (hdnUpdMode.Value == "1")
                {
                    hdnInputMode.Value = "1";
                    Screen_Control("1");
                }
                else
                {
                    FromClear(1);
                    lblMsg.Text = msg.GetMessage("USER_NOT_EXIST_ERR");
                    lblMsg.ForeColor = Color.Red;
                    return;
                }
            }
            else
            {
                if (hdnUpdMode.Value == "1")
                {
                    lblMsg.Text = msg.GetMessage("ALREADY_EXIST_ERR");
                    lblMsg.ForeColor = Color.Red;
                    return;
                }
                //ddlLang.SelectedValue = us.lang.ToString();
                txtFirstName.Text = us.user_first_name;
                //txtFamilyName.Text = us.user_family_name;
                txtLastName.Text = us.user_family_name;
                //ddlEmailSendFlag.SelectedValue = us.email_send_flag.ToString();
                //txtEmail.Text = us.email;
                //txtTelNo.Text = us.tel_no;
                //ddlMenuGrp.SelectedValue = us.menu_grp;
                txtDescription.Text = us.name;
                try
                {
                    ddl_USER_GROUP.SelectedValue = us.menu_grp;
                }
                catch
                {

                }
                try
                {
                    ddl_DEPT_NO.SelectedValue = us.dept_cd;
                }
                catch
                {

                }
                try
                {
                    ddl_MGMT_LEVEL.SelectedValue = us.mgmt_no;
                }
                catch
                {

                }
                txtPosition.Text = us.position;

                hdnInputMode.Value = "1";
                Screen_Control(hdnUpdMode.Value);
            }

        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            ComLibrary com = new ComLibrary();
            Message msg = new Message(g_user_id, g_lang);
            User user = new User(g_user_id, g_lang);
            int rtn = 0;
            if (txtUserId.Text.Trim() == "")
            {
                lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblUserId.Text + ")";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            //if (txtFamilyName.Text.Trim() == "")
            //{
            //    lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblFamilyName.Text + ")";
            //    lblMsg.ForeColor = Color.Red;
            //    return;
            //}
            if (txtFirstName.Text.Trim() == "")
            {
                lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblFirstName.Text + ")";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            if (txtLastName.Text.Trim() == "")
            {
                lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblLastName.Text + ")";
                lblMsg.ForeColor = Color.Red;
                return;
            }

            user.user_id = txtUserId.Text;
            //user.lang = com.StringToInt(ddlLang.SelectedValue);
            //user.user_family_name = txtFamilyName.Text;
            user.user_family_name = txtLastName.Text;
            user.user_first_name = txtFirstName.Text;
            user.name = txtDescription.Text;
            //user.tel_no = txtTelNo.Text;
            //user.email = txtEmail.Text;
            //user.menu_grp = ddlMenuGrp.SelectedValue;
            //user.email_send_flag = com.StringToInt(ddlEmailSendFlag.SelectedValue);
            user.menu_grp = ddl_USER_GROUP.SelectedValue;
            user.dept_cd = ddl_DEPT_NO.SelectedValue;
            user.mgmt_no = ddl_MGMT_LEVEL.SelectedValue;
            user.position = txtPosition.Text;
            user.password = txtUserId.Text;

            switch (hdnUpdMode.Value)
            {
                case "1":   // Insert
                    rtn = user.Insert();
                    break;
                case "2":   // Update
                    rtn = user.Update();
                    break;
                case "3":   // Delete
                    //Role role = new Role(g_user_id, g_lang);
                    //role.user_id = txtUserId.Text;
                    //DataSet ds = role.GetRoleListByUser();

                    //if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    //{
                    //    lblMsg.Text = msg.GetMessage("USER_ROLE_DEL_ERR");
                    //    lblMsg.ForeColor = Color.Red;
                    //    return;

                    //}
                    //else
                    //{
                        rtn = user.Delete();
                    //}

                    break;
            }
            if (rtn == ComConst.FAILED)
            {
                lblMsg.Text = user.strErr;
                lblMsg.ForeColor = Color.Red;
                return;
            }
            lblMsg.Text = msg.GetMessage("NORMAL_UPDATE");
            lblMsg.ForeColor = Color.Blue;
            FromClear(1);
            hdnInputMode.Value = "0";
            Screen_Control(hdnUpdMode.Value);
        }

        protected void cmdCancel_Click(object sender, EventArgs e)
        {
            //hdnInputMode.Value = "0";
            //FromClear(0);
            //Screen_Control(hdnUpdMode.Value);
            if (hdnInputMode.Value == "0")
            {
                FromClear(0);
            }
            else
            {
                FromClear(1);
            }
            hdnInputMode.Value = "0";
            Screen_Control(hdnUpdMode.Value);
        }

        protected void btnMdsp_Click(object sender, EventArgs e)
        {
            hdnInputMode.Value = "0";//Recovery By UBIQ-LIU 2010/01/08
            FromClear(1);
            Screen_Control("0");
            Mode_Chg();
        }

        protected void btnMadd_Click(object sender, EventArgs e)
        {
            hdnInputMode.Value = "0";
            FromClear(1);
            Screen_Control("1");
            Mode_Chg();
        }

        protected void btnMupd_Click(object sender, EventArgs e)
        {
            hdnInputMode.Value = "0";//Recovery By UBIQ-LIU 2010/01/08
            FromClear(1);
            Screen_Control("2");
            Mode_Chg();
        }

        protected void btnMdel_Click(object sender, EventArgs e)
        {
            hdnInputMode.Value = "0";//Recovery By UBIQ-LIU 2010/01/08
            FromClear(1);
            Screen_Control("3");
            Mode_Chg();
        }

        /// <summary>
        /// Mode Change
        /// </summary>
        protected void Mode_Chg()
        {
            if (txtUserId.Text != "")
            {
                cmdDisp_Click(null, null);
            }
        }

        protected void FromClear(int flg)
        {
            if (flg == 0)
            {
                txtUserId.Text = "";
            }
            //ddlLang.SelectedIndex = 0;
            //txtFamilyName.Text = "";
            txtLastName.Text = "";
            //txtFirstName.Text = "";
            txtFirstName.Text = "";
            //txtTelNo.Text = "";
            //txtEmail.Text = "";
            //ddlMenuGrp.SelectedIndex = 0;
            txtDescription.Text = "";
            ddl_USER_GROUP.SelectedIndex = 0;
            ddl_DEPT_NO.SelectedIndex = 0;
            ddl_MGMT_LEVEL.SelectedIndex = 0;
            txtPosition.Text = "";
        }

        protected void cmdRole_Click(object sender, EventArgs e)
        {
            ComLibrary com = new ComLibrary();
            Message msg = new Message(g_user_id, g_lang);
            int rtn = 0;
            if (txtUserId.Text == "")
            {
                lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblUserId.Text + ")";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            User us = new User(g_user_id, g_lang);
            us.user_id = txtUserId.Text;
            rtn = us.GetDetail();

            if (rtn == ComConst.FAILED)
            {
                lblMsg.Text = msg.GetMessage("USER_NOT_EXIST_ERR");
                lblMsg.ForeColor = Color.Red;
                return;
            }
            string strUrl = "~/Master/MstUserMnt/frmDetail.aspx?USERID=" + txtUserId.Text + "&program_id=" + Request["program_id"] + "&level=" + Request["level"];
            Response.Redirect(strUrl);
        }

        protected void cmdPassWord_Click(object sender, EventArgs e)
        {
            ComLibrary com = new ComLibrary();
            Message msg = new Message(g_user_id, g_lang);
            int rtn = 0;
            if (txtUserId.Text == "")
            {
                lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblUserId.Text + ")";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            User us = new User(g_user_id, g_lang);
            us.user_id = txtUserId.Text;
            rtn = us.GetDetail();

            if (rtn == ComConst.FAILED)
            {
                lblMsg.Text = msg.GetMessage("USER_NOT_EXIST_ERR");
                lblMsg.ForeColor = Color.Red;
                return;
            }
            string strUrl = "~/Common/Login/frmPwdChg.aspx?USERID=" + txtUserId.Text + "&program_id=" + Request["program_id"] + "&level=" + Request["level"] + "&Psd_Flag=1";
            Response.Redirect(strUrl);
        }

        protected void imgReturn_Click(object sender, EventArgs e)
        {
            //return Menu add by zhao 20090508
            //string g_program_id = Request["program_id"].ToString();
            //int g_level = int.Parse(Request["level"].ToString());
            //IMClass.Common com = new IMClass.Common();
            //g_program_id = com.GetBackMenuGrp(g_program_id, g_level);
            //string strUrl = "~/Default.aspx?program_id=" + g_program_id + "&level=" + g_level.ToString();
            string strUrl = "Default.aspx";
            Response.Redirect(strUrl);
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            if (hdnPassword.Value == "")
            {
                //Message msg = new Message(g_user_id, g_lang);
                //lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR");
                return;
            }

            // パスワード更新
            User user = new User(g_user_id, g_lang);
            user.password = hdnPassword.Value;
            user.user_id = txtUserId.Text;
            int rtn = user.UpdatePassword();

            // 結果判定
            //switch (rtn)
            //{
            //    // 変更なし
            //    case ComConst.PWD_NO_CHG:
            //        Message msg = new Message(g_user_id, g_lang);
            //        lblMsg.Text = msg.GetMessage("PWD_NO_CHG_ERR");
            //        break;

            //    case ComConst.PWD_NO_CHG1:
            //        msg = new Message(g_user_id, g_lang);
            //        lblMsg.Text = msg.GetMessage("PWD_NO_CHG_ERR1");
            //        break;

            //    case ComConst.PWD_NO_CHG2:
            //        msg = new Message(g_user_id, g_lang);
            //        lblMsg.Text = msg.GetMessage("PWD_NO_CHG_ERR2");
            //        break;

            //    case ComConst.PWD_NO_CHG3:
            //        msg = new Message(g_user_id, g_lang);
            //        lblMsg.Text = msg.GetMessage("PWD_NO_CHG_ERR3");
            //        break;

            //    // 最小桁数に満たない
            //    case ComConst.PWD_MIN_LEN_ERR:
            //        msg = new Message(g_user_id, g_lang);
            //        lblMsg.Text = msg.GetMessage("PWD_MIN_LEN_ERR");
            //        break;

            //    // 予期せぬエラー
            //    case ComConst.FAILED:
            //        msg = new Message(g_user_id, g_lang);
            //        lblMsg.Text = msg.GetMessage("UNEXPECTED_ERR");
            //        break;

            //    // 更新成功
            //    default:
            //        // メニュー画面の表示
            //        //return Menu Add by zhao 20090508
            //        string g_program_id = Request["program_id"].ToString();
            //        int g_level = int.Parse(Request["level"].ToString());
            //        IMClass.Common com = new IMClass.Common();
            //        g_program_id = com.GetBackMenuGrp(g_program_id, g_level);
            //        string strUrl = "~/Default.aspx?program_id=" + g_program_id + "&level=" + g_level.ToString();
            //        Response.Redirect(strUrl);
            //        break;
            //}
        }
    }
}