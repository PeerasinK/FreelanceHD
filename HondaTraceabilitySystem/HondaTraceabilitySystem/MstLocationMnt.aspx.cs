using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using IMClass;
using System.Drawing;
using System.Collections;

namespace HondaTraceabilitySystem
{
    public partial class MstLocationMnt : System.Web.UI.Page
    {
        protected string g_user_id;
        protected int g_lang;
        protected string g_company_cd;
        protected string g_name;
        protected string g_menu_grp;

        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie MyCookie;

            //try
            //{
            //    MyCookie = new HttpCookie("IMLastVisit");
            //    HttpCookieCollection MyCookieColl = Request.Cookies;
            //    MyCookie = MyCookieColl.Get("IMLastVisit");

            //    g_user_id = MyCookie.Values["USER_ID"];
            //    g_lang = int.Parse(MyCookie.Values["LANG"]);
            //    g_company_cd = MyCookie.Values["COMPANY_CD"];
            //    g_name = HttpUtility.UrlDecode(MyCookie.Values["NAME"]);

            //}
            //catch
            //{
            //    Response.Redirect("~/NotLoginErr.htm");
            //}
            // 検索画面追加[初期処理より処理の前に記述]
            //g_user_id = "admin-e";
            g_lang = 2;
            //g_name = "General manager (English)";
            //Add_Search();

            if (!IsPostBack)
            {
                //// 画面編集
                Init_Label();
                Init_Proc();
                txtLocation.Text = Request.QueryString["ROLE"];
                if (txtLocation.Text.Trim() != "")
                {
                    Edit_Screen();
                }
            }
            Page.Form.DefaultButton = cmdDisp.UniqueID;
            lblMsg.Text = "";
        }

        //
        // 初期画面ラベル編集
        //
        protected void Init_Label()
        {
            //lblUserName.Text = g_name;
            //lblComp.Text = g_company_cd;
            ShowPanel(pnlSUB2, true, 50, 50);
            //Dictionary dic = new Dictionary(g_user_id, g_lang);
            //dic.screen_id = "MstLocationMnt_frmMain";
            //DataSet ds = dic.GetLabelOfScreenList();

            //if (ds != null && ds.Tables.Count > 0)
            //{
            //    foreach (DataRow row in ds.Tables[0].Rows)
            //    {
            //        switch (row["CONTROL_ID"].ToString())
            //        {
            //            // ラベル
            //            case "flblTitle": flblTitle.Text = row["ITEM_DESC"].ToString(); break;
            //            case "flblLocation": flblLocation.Text = row["ITEM_DESC"].ToString(); break;
            //            case "flblLocationName": flblLocationName.Text = row["ITEM_DESC"].ToString(); break;
            //            case "flblLocationDesc": flblLocationDesc.Text = row["ITEM_DESC"].ToString(); break;
            //                //case "flblManagementDesc3": flblManagementDesc3.Text = row["ITEM_DESC"].ToString(); break;
            //                //case "flblManagementDesc4": flblManagementDesc4.Text = row["ITEM_DESC"].ToString(); break;

            //        }
            //    }
            //}
            ////
            //// 更新系ボタンイメージの編集     －      言語対応とSwapImage
            ////
            ////btnRoleSearch.Attributes["onmouseover"] = "MM_swapImage('" + btnRoleSearch.ClientID + "','','../../Contents/Image/BackGround/sbtn_srch_f2.gif',1);";
            ////btnRoleSearch.Attributes["onmouseout"] = "MM_swapImgRestore();";
            ////
            //// 更新系ボタンイメージの編集     －      言語対応とSwapImage
            ////
            //switch (g_lang)
            //{
            //    case 1:
            //        //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-1.jpg";
            //        //cmdDisp.Attributes["onmouseover"] = "MM_swapImage('" + cmdDisp.ClientID + "','','../../Contents/Image/BackGround/btn-ind2-1.jpg',1);";
            //        //cmdDisp.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update1-1.jpg";
            //        //cmdUpdate.Attributes["onmouseover"] = "MM_swapImage('" + cmdUpdate.ClientID + "','','../../Contents/Image/BackGround/btn-update2-1.jpg',1);";
            //        //cmdUpdate.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdUserRole.ImageUrl = "../../Contents/Image/BackGround/btn-user_role1-1.jpg";
            //        //cmdUserRole.Attributes["onmouseover"] = "MM_swapImage('" + cmdUserRole.ClientID + "','','../../Contents/Image/BackGround/btn-user_role2-1.jpg',1);";
            //        //cmdUserRole.Attributes["onmouseout"] = "MM_swapImgRestore();";
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
            //        //cmdUserRole.ImageUrl = "../../Contents/Image/BackGround/btn-user_role1-2.jpg";
            //        //cmdUserRole.Attributes["onmouseover"] = "MM_swapImage('" + cmdUserRole.ClientID + "','','../../Contents/Image/BackGround/btn-user_role2-2.jpg',1);";
            //        //cmdUserRole.Attributes["onmouseout"] = "MM_swapImgRestore();";
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
            //        //cmdUserRole.ImageUrl = "../../Contents/Image/BackGround/btn-user_role1-3.jpg";
            //        //cmdUserRole.Attributes["onmouseover"] = "MM_swapImage('" + cmdUserRole.ClientID + "','','../../Contents/Image/BackGround/btn-user_role2-3.jpg',1);";
            //        //cmdUserRole.Attributes["onmouseout"] = "MM_swapImgRestore();";
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
            //        //cmdUserRole.ImageUrl = "../../Contents/Image/BackGround/btn-user_role1-4.jpg";
            //        //cmdUserRole.Attributes["onmouseover"] = "MM_swapImage('" + cmdUserRole.ClientID + "','','../../Contents/Image/BackGround/btn-user_role2-4.jpg',1);";
            //        //cmdUserRole.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //cmdCancel.ImageUrl = "../../Contents/Image/BackGround/btn-cancel1-4.jpg";
            //        //cmdCancel.Attributes["onmouseover"] = "MM_swapImage('" + cmdCancel.ClientID + "','','../../Contents/Image/BackGround/btn-cancel2-4.jpg',1);";
            //        //cmdCancel.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        break;
            //}
            //imgReturn.Attributes["onmouseover"] = "MM_swapImage('" + imgReturn.ClientID + "','','../../Contents/Image/BackGround/btn-menu3.jpg',1);";
            //imgReturn.Attributes["onmouseout"] = "MM_swapImgRestore();";

            flblTitle.Text = "Location Master";
            Init_Mode();
        }

        //
        // モード系ボタンイメージの編集
        //
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

        //
        // 初期画面編集
        //
        protected void Init_Proc()
        {
            // 初期状態は照会モードとする
            hdnInputMode.Value = "0";
            ddl_edit();
            Screen_Control("0");
            Edit_Grid();
        }

        protected void ddl_edit()
        {
            DataSet dt = new DataSet();
            ComLibrary com = new ComLibrary();
            Dept dept = new Dept(g_user_id, g_lang);

            dt = dept.GetDEPTList();
            ddl_DEPT_NO.DataValueField = "DEPT_NO";
            ddl_DEPT_NO.DataTextField = "DEPT_NAME";
            ddl_DEPT_NO.DataSource = dt;
            ddl_DEPT_NO.DataBind();
            ddl_DEPT_NO.Items.Insert(0, "");
        }

        /// <summary>
        /// 初期画面権限編集
        /// </summary>
        protected void Auth_Proc()
        {
            IM_Menu menu = new IM_Menu(g_user_id, g_lang);
            menu.user_id = g_user_id;
            menu.program_id = "MstRoleMnt";
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
                switch (g_lang)
                {
                    case 1:
                        //btnMadd.ImageUrl = "../../Contents/Image/BackGround/btn-new4-1.jpg";
                        //btnMupd.ImageUrl = "../../Contents/Image/BackGround/btn-change4-1.jpg";
                        //btnMdel.ImageUrl = "../../Contents/Image/BackGround/btn-delete4-1.jpg";
                        break;
                    case 2:
                        //btnMadd.ImageUrl = "../../Contents/Image/BackGround/btn-new4-2.jpg";
                        //btnMupd.ImageUrl = "../../Contents/Image/BackGround/btn-change4-2.jpg";
                        //btnMdel.ImageUrl = "../../Contents/Image/BackGround/btn-delete4-2.jpg";
                        break;
                    case 3:
                        //btnMadd.ImageUrl = "../../Contents/Image/BackGround/btn-new4-3.jpg";
                        //btnMupd.ImageUrl = "../../Contents/Image/BackGround/btn-change4-3.jpg";
                        //btnMdel.ImageUrl = "../../Contents/Image/BackGround/btn-delete4-3.jpg";
                        break;
                    case 4:
                        //btnMadd.ImageUrl = "../../Contents/Image/BackGround/btn-new4-4.jpg";
                        //btnMupd.ImageUrl = "../../Contents/Image/BackGround/btn-change4-4.jpg";
                        //btnMdel.ImageUrl = "../../Contents/Image/BackGround/btn-delete4-4.jpg";
                        break;
                }
            }
        }

        /// <summary>
        /// 検索画面追加
        /// </summary>
        protected void Add_Search()
        {
            //ロール検索画面
            //Search srch = new Search();
            //srch.search_type = Search.SearchType.ROLE;
            //srch.opener = this;
            //srch.opener_button = btnRoleSearch;
            /*** ADD 20090629 UBIQ-LIU  ***/
            //srch.submit_type = 1;
            //srch.btn_id = btnSearchSubmit.ClientID;
            /***            END         ***/
            //ArrayList arrObj = new ArrayList();
            //arrObj.Add(txtLocation);
            //srch.return_controls = arrObj;
            //int rtn = srch.CreateSearchWindow();
        }

        protected void btnSearchSubmit_Click(object sender, EventArgs e)
        {
            cmdDisp_Click(null, null);
        }
        //
        // 画面の制御
        //
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
                    btnMdsp.Enabled = false;
                    //txtManagement.Enabled = false;
                    //btnRoleSearch.Visible = false;
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
                    com.Set_Attributes(DivPnlKey, 1);
                    com.Set_Attributes(DivPnlDetail, 0);
                    btnRoleSearch.Visible = true;
                    cmdUpdate.Enabled = false;
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
                    com.SetInitialFocus(txtLocation);
                    break;
                case "1":
                    if (hdnUpdMode.Value == "0")
                    {
                        com.Set_Attributes(DivPnlKey, 1);
                        btnRoleSearch.Visible = true;
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
                        com.Set_Attributes(DivPnlKey, 0);
                        btnRoleSearch.Visible = false;
                        cmdDisp.Enabled = false;
                        cmdUpdate.Enabled = true;
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

                    // 照会、削除時は明細入力を許さない
                    if (hdnUpdMode.Value == "0" || hdnUpdMode.Value == "3")
                    {
                        com.Set_Attributes(DivPnlDetail, 0);
                    }
                    else
                    {
                        com.Set_Attributes(DivPnlDetail, 1);
                    }
                    break;
            }
        }

        protected void Clear_Screen(int flag)
        {
            if (flag == 1)
            {
                txtLocation.Text = "";
            }
            txtLocationName.Text = "";
            txtLocationDesc.Text = "";
            ddl_DEPT_NO.SelectedIndex = 0;
        }

        protected void cmdDisp_Click(object sender, EventArgs e)
        {
            if (hdnUpdMode.Value == "0")
            {
                ShowPanel(pnlSUB2, true, 50, 50);
                Edit_Grid();
            }
            else
            {
                ShowPanel(pnlSUB2, false, 50, 50);
                Edit_Screen();
            }
        }

        protected void ShowPanel(Panel panal, bool visable, int top, int left)
        {
            if (visable)
            {
                panal.Style.Add("top", string.Format("{0}px;", top));
                panal.Style.Add("left", string.Format("{0}px;", left));
            }
            //panal.Visible = visable;
            if (visable)
            {
                pnlSUB2.Style.Add("display", "block");

                pnlDetail.Style.Add("display", "none");
            }
            else
            {
                pnlSUB2.Style.Add("display", "none");   // KGC

                pnlDetail.Style.Add("display", "block");
            }
        }

        protected void Edit_Screen()
        {
            ComLibrary com = new ComLibrary();
            // ロールマスタを検索
            Location loc = new Location(g_user_id, g_lang);
            //loc.whs_cd = txtLocation.Text.ToUpper().Trim();
            loc.location = txtLocation.Text.ToUpper().Trim();
            txtLocation.Text = loc.location;

            Clear_Screen(0);
            // 必須項目のチェック
            if (txtLocation.Text == "")
            {
                Message msg = new Message(g_user_id, g_lang);
                lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblLocation.Text + ")";
                lblMsg.ForeColor = Color.Red;
                return;
            }

            int rtn = loc.GetLocationDetail();

            if (hdnUpdMode.Value == "1")
            {
                //
                // 新規のときは、すでに存在すればエラー
                //
                if (rtn != ComConst.FAILED)
                {
                    Message msg = new Message(g_user_id, g_lang);
                    lblMsg.Text = msg.GetMessage("ALREADY_EXIST_ERR");
                    lblMsg.ForeColor = Color.Red;
                    return;
                }
            }
            else
            {
                //
                // 新規以外のときは、存在しなければエラー
                //
                if (rtn == ComConst.FAILED)
                {
                    Message msg = new Message(g_user_id, g_lang);
                    lblMsg.Text = msg.GetMessage("NOT_EXIST_ERR");
                    lblMsg.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    // 画面編集

                    txtLocationName.Text = loc.location_desc;
                    txtLocationDesc.Text = loc.location_desc2;
                    try
                    {
                        ddl_DEPT_NO.SelectedValue = loc.dept_no;
                    }
                    catch
                    {

                    }
                }
            }
            hdnInputMode.Value = "1";
            Screen_Control(hdnUpdMode.Value);
        }

        protected void Edit_Grid()
        {
            // 品目マスタより一覧を得る
            string[] strcou;
            //strcou = flblCount.Text.Split('=');
            Message msg = new Message(g_user_id, g_lang);

            Location SrchLoc = new Location(g_user_id, g_lang);
            SrchLoc.location = txtLocation.Text.ToUpper().Trim();
            DataSet ds = SrchLoc.GetLocationList();
            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                dgvSearch.DataSource = null;
                dgvSearch.DataBind();
                //flblCount.Text = strcou[0] + " = 0]";
            }
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dgvSearch.DataSource = ds.Tables[0];
                dgvSearch.DataBind();
                ViewState["dgvSearch"] = ds.Tables[0];
                //flblCount.Text = strcou[0] + " = " + ds.Tables[0].Rows.Count.ToString() + "]";
            }
        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            Message msg = new Message(g_user_id, g_lang);
            Location loc = new Location(g_user_id, g_lang);
            //loc.whs_cd = txtLocation.Text.ToUpper().Trim();
            loc.location = txtLocation.Text.ToUpper().Trim();

            //if (hdnUpdMode.Value == "3")
            //{
            //    DataSet ds = new DataSet();
            //    ds = management.GetUserListByManagement();
            //    if (ds.Tables[0].Rows.Count > 0)
            //    {
            //        lblMsg.Text = msg.GetMessage("ROLE_DEL_ERR");
            //        lblMsg.ForeColor = Color.Red;
            //        return;
            //    }
            //}

            //必須項目のチェック
            if (txtLocationName.Text == "")
            {
                lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblLocationName.Text + ")";
                lblMsg.ForeColor = Color.Red;
                return;
            }

            ComLibrary com = new ComLibrary();
            // ロールマスタを更新
            // 画面から項目を編集
            loc.location = txtLocation.Text;
            loc.location_desc = txtLocationName.Text;
            loc.location_desc2 = txtLocationDesc.Text;
            loc.dept_no = ddl_DEPT_NO.SelectedValue.ToString();
            loc.chg_user_id = g_user_id;
            //role.chg_pgm = "MstRoleMnt";

            int rtn = 0;
            switch (hdnUpdMode.Value)
            {
                case "1":   // Insert
                    rtn = loc.Insert();
                    break;
                case "2":   // Update
                    rtn = loc.Update();
                    break;
                case "3":   // Delete
                    rtn = loc.Delete();
                    break;
            }
            if (rtn == ComConst.FAILED)
            {
                lblMsg.Text = loc.strErr;
                lblMsg.ForeColor = Color.Red;
                return;
            }

            lblMsg.Text = msg.GetMessage("NORMAL_UPDATE");
            lblMsg.ForeColor = Color.Blue;
            if (hdnUpdMode.Value == "3")
            {
                Clear_Screen(1);
            }
            hdnInputMode.Value = "0";
            Screen_Control(hdnUpdMode.Value);
        }
        //
        // ユーザーロールボタンの処理
        //
        protected void cmdUserRole_Click(object sender, EventArgs e)
        {
            string strRole;

            if (txtLocation.Text.Trim() != "")
            {
                strRole = txtLocation.Text.Trim().ToUpper();
                //ViewState["Role"] = strRole;
                //Response.Redirect("frmDetail.aspx?Role=" + strRole);
                Response.Redirect("frmDetail.aspx?Role=" + strRole
                    + "&program_id=" + Request["program_id"] + "&level=" + Request["level"]);
            }
            else
            {
                Message msg = new Message(g_user_id, g_lang);
                lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblLocation.Text + ")";
                lblMsg.ForeColor = Color.Red;
                return;
            }
        }

        protected void imgReturn_Click(object sender, EventArgs e)
        {
            //return Menu
            //string g_program_id = Request["program_id"].ToString();
            //int g_level = int.Parse(Request["level"].ToString());
            //IMClass.Common com = new IMClass.Common();
            //g_program_id = com.GetBackMenuGrp(g_program_id, g_level);
            //string strUrl = "~/Default.aspx?program_id=" + g_program_id + "&level=" + g_level.ToString();
            string strUrl = "Default.aspx";
            Response.Redirect(strUrl);
        }

        protected void btnMdsp_Click(object sender, EventArgs e)
        {
            hdnInputMode.Value = "0";//Recovery By UBIQ-LIU 2010/01/08
            Screen_Control("0");
            Mode_Chg();
            ShowPanel(pnlSUB2, true, 50, 50);
            Edit_Grid();
        }

        protected void btnMadd_Click(object sender, EventArgs e)
        {
            hdnInputMode.Value = "0";
            Screen_Control("1");
            Clear_Screen(0);
            Mode_Chg();
            ShowPanel(pnlSUB2, false, 50, 50);
        }

        protected void btnMupd_Click(object sender, EventArgs e)
        {
            hdnInputMode.Value = "0";//Recovery By UBIQ-LIU 2010/01/08
            Screen_Control("2");
            Clear_Screen(0);
            Mode_Chg();
            ShowPanel(pnlSUB2, false, 50, 50);
        }

        protected void btnMdel_Click(object sender, EventArgs e)
        {
            hdnInputMode.Value = "0";//Recovery By UBIQ-LIU 2010/01/08
            Screen_Control("3");
            Clear_Screen(0);
            Mode_Chg();
            ShowPanel(pnlSUB2, false, 50, 50);
        }

        protected void cmdCancel_Click(object sender, EventArgs e)
        {
            //hdnInputMode.Value = "0";
            //Screen_Control(hdnUpdMode.Value);
            //Clear_Screen(1);
            if (hdnInputMode.Value == "0")
            {
                Clear_Screen(1);
            }
            else
            {
                Clear_Screen(0);
            }
            hdnInputMode.Value = "0";
            Screen_Control(hdnUpdMode.Value);
        }
        /// <summary>
        /// Mode Change
        /// </summary>
        protected void Mode_Chg()
        {
            if (txtLocation.Text != "")
            {
                cmdDisp_Click(null, null);
            }
        }
    }
}