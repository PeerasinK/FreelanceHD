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
using IMClass.CustomControls;

namespace HondaTraceabilitySystem
{
    public partial class MstMfgBomMnt : System.Web.UI.Page
    {
        protected string g_user_id;
        protected int g_lang;
        protected string g_company_cd;
        protected string g_name;

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
            //    g_company_cd = HttpUtility.UrlDecode(MyCookie.Values["COMPANY_CD"]);
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

            lblMsg.Text = "";
            if (!IsPostBack)
            {
                // 画面編集
                Init_Label();
            }
            else
            {
                Edit_grid((DataTable)ViewState["dgvDetail"]);
            }
        }

        #region # 画面の制御 #

        /// <summary>
        /// 初期画面ラベル編集
        /// </summary>
        protected void Init_Label()
        {
            //lblUserName.Text = g_name;
            //lblComp.Text = g_company_cd;

            //Dictionary dic = new Dictionary(g_user_id, g_lang);
            //dic.screen_id = "MstMfgBOMMnt_frmMain";
            //DataSet ds = dic.GetLabelOfScreenList();

            //if (ds != null && ds.Tables.Count > 0)
            //{
            //    foreach (DataRow row in ds.Tables[0].Rows)
            //    {
            //        switch (row["CONTROL_ID"].ToString())
            //        {
            //            // ラベル
            //            case "flblTitle": flblTitle.Text = row["ITEM_DESC"].ToString(); break;
            //            case "flblITEM_NO": flblITEM_NO.Text = row["ITEM_DESC"].ToString(); break;
            //                //case "flblWHS_CD": flblWHS_CD.Text = row["ITEM_DESC"].ToString(); break;
            //                //GridView HeadText
            //                //case "dgv_LOCATION": dgvDetail.Columns[1].HeaderText = row["ITEM_DESC"].ToString(); break;
            //                //case "dgv_LOCATION_DESC": dgvDetail.Columns[2].HeaderText = row["ITEM_DESC"].ToString(); break;
            //                //
            //                //case "flblSequent": flblSequent.Text = row["ITEM_DESC"].ToString(); break;
            //                //case "flblLOCATION_DESC": flblLOCATION_DESC.Text = row["ITEM_DESC"].ToString(); break;
            //        }
            //    }
            //}

            ////
            //// img系ボタンイメージの編集     －      言語対応とSwapImage
            ////
            //switch (g_lang)
            //{
            //    case 1:
            //        //imgReturn.ImageUrl = "../../Contents/Image/BackGround/btn-back1-1.jpg";
            //        //imgReturn.Attributes["onmouseover"] = "MM_swapImage('" + imgReturn.ClientID + "','','../../Contents/Image/BackGround/btn-back2-1.jpg',1);";
            //        //imgReturn.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnDET_ADD.ImageUrl = "../../Contents/Image/BackGround/btn-det_add1-1.jpg";
            //        //btnDET_ADD.Attributes["onmouseover"] = "MM_swapImage('" + btnDET_ADD.ClientID + "','','../../Contents/Image/BackGround/btn-det_add2-1.jpg',1);";
            //        //btnDET_ADD.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnDET_DEL.ImageUrl = "../../Contents/Image/BackGround/btn-det_del1-1.jpg";
            //        //btnDET_DEL.Attributes["onmouseover"] = "MM_swapImage('" + btnDET_DEL.ClientID + "','','../../Contents/Image/BackGround/btn-det_del2-1.jpg',1);";
            //        //btnDET_DEL.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnDET_CHANGE.ImageUrl = "../../Contents/Image/BackGround/btn-det_change1-1.jpg";
            //        //btnDET_CHANGE.Attributes["onmouseover"] = "MM_swapImage('" + btnDET_CHANGE.ClientID + "','','../../Contents/Image/BackGround/btn-det_change2-1.jpg',1);";
            //        //btnDET_CHANGE.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnRELEASE.ImageUrl = "../../Contents/Image/BackGround/btn-release1-1.jpg";
            //        //btnRELEASE.Attributes["onmouseover"] = "MM_swapImage('" + btnRELEASE.ClientID + "','','../../Contents/Image/BackGround/btn-release2-1.jpg',1);";
            //        //btnRELEASE.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnSearch.ImageUrl = "../../Contents/Image/BackGround/btn-search1-1.jpg";
            //        //btnSearch.Attributes["onmouseover"] = "MM_swapImage('" + btnSearch.ClientID + "','','../../Contents/Image/BackGround/btn-search2-1.jpg',1);";
            //        //btnSearch.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        break;
            //    case 2:
            //        //imgReturn.ImageUrl = "../../Contents/Image/BackGround/btn-back1-2.jpg";
            //        //imgReturn.Attributes["onmouseover"] = "MM_swapImage('" + imgReturn.ClientID + "','','../../Contents/Image/BackGround/btn-back2-2.jpg',1);";
            //        //imgReturn.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnDET_ADD.ImageUrl = "../../Contents/Image/BackGround/btn-det_add1-2.jpg";
            //        //btnDET_ADD.Attributes["onmouseover"] = "MM_swapImage('" + btnDET_ADD.ClientID + "','','../../Contents/Image/BackGround/btn-det_add2-2.jpg',1);";
            //        //btnDET_ADD.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnDET_DEL.ImageUrl = "../../Contents/Image/BackGround/btn-det_del1-2.jpg";
            //        //btnDET_DEL.Attributes["onmouseover"] = "MM_swapImage('" + btnDET_DEL.ClientID + "','','../../Contents/Image/BackGround/btn-det_del2-2.jpg',1);";
            //        //btnDET_DEL.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnDET_CHANGE.ImageUrl = "../../Contents/Image/BackGround/btn-det_change1-2.jpg";
            //        //btnDET_CHANGE.Attributes["onmouseover"] = "MM_swapImage('" + btnDET_CHANGE.ClientID + "','','../../Contents/Image/BackGround/btn-det_change2-2.jpg',1);";
            //        //btnDET_CHANGE.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnRELEASE.ImageUrl = "../../Contents/Image/BackGround/btn-release1-2.jpg";
            //        //btnRELEASE.Attributes["onmouseover"] = "MM_swapImage('" + btnRELEASE.ClientID + "','','../../Contents/Image/BackGround/btn-release2-2.jpg',1);";
            //        //btnRELEASE.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnSearch.ImageUrl = "../../Contents/Image/BackGround/btn-search1-2.jpg";
            //        //btnSearch.Attributes["onmouseover"] = "MM_swapImage('" + btnSearch.ClientID + "','','../../Contents/Image/BackGround/btn-search2-2.jpg',1);";
            //        //btnSearch.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        break;
            //    case 3:
            //        //imgReturn.ImageUrl = "../../Contents/Image/BackGround/btn-back1-3.jpg";
            //        //imgReturn.Attributes["onmouseover"] = "MM_swapImage('" + imgReturn.ClientID + "','','../../Contents/Image/BackGround/btn-back2-3.jpg',1);";
            //        //imgReturn.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnDET_ADD.ImageUrl = "../../Contents/Image/BackGround/btn-det_add1-3.jpg";
            //        //btnDET_ADD.Attributes["onmouseover"] = "MM_swapImage('" + btnDET_ADD.ClientID + "','','../../Contents/Image/BackGround/btn-det_add2-3.jpg',1);";
            //        //btnDET_ADD.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnDET_DEL.ImageUrl = "../../Contents/Image/BackGround/btn-det_del1-3.jpg";
            //        //btnDET_DEL.Attributes["onmouseover"] = "MM_swapImage('" + btnDET_DEL.ClientID + "','','../../Contents/Image/BackGround/btn-det_del2-3.jpg',1);";
            //        //btnDET_DEL.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnDET_CHANGE.ImageUrl = "../../Contents/Image/BackGround/btn-det_change1-3.jpg";
            //        //btnDET_CHANGE.Attributes["onmouseover"] = "MM_swapImage('" + btnDET_CHANGE.ClientID + "','','../../Contents/Image/BackGround/btn-det_change2-3.jpg',1);";
            //        //btnDET_CHANGE.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnRELEASE.ImageUrl = "../../Contents/Image/BackGround/btn-release1-3.jpg";
            //        //btnRELEASE.Attributes["onmouseover"] = "MM_swapImage('" + btnRELEASE.ClientID + "','','../../Contents/Image/BackGround/btn-release2-3.jpg',1);";
            //        //btnRELEASE.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnSearch.ImageUrl = "../../Contents/Image/BackGround/btn-search1-3.jpg";
            //        //btnSearch.Attributes["onmouseover"] = "MM_swapImage('" + btnSearch.ClientID + "','','../../Contents/Image/BackGround/btn-search2-3.jpg',1);";
            //        //btnSearch.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        break;
            //    case 4:
            //        //imgReturn.ImageUrl = "../../Contents/Image/BackGround/btn-back1-4.jpg";
            //        //imgReturn.Attributes["onmouseover"] = "MM_swapImage('" + imgReturn.ClientID + "','','../../Contents/Image/BackGround/btn-back2-4.jpg',1);";
            //        //imgReturn.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnDET_ADD.ImageUrl = "../../Contents/Image/BackGround/btn-det_add1-4.jpg";
            //        //btnDET_ADD.Attributes["onmouseover"] = "MM_swapImage('" + btnDET_ADD.ClientID + "','','../../Contents/Image/BackGround/btn-det_add2-4.jpg',1);";
            //        //btnDET_ADD.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnDET_DEL.ImageUrl = "../../Contents/Image/BackGround/btn-det_del1-4.jpg";
            //        //btnDET_DEL.Attributes["onmouseover"] = "MM_swapImage('" + btnDET_DEL.ClientID + "','','../../Contents/Image/BackGround/btn-det_del2-4.jpg',1);";
            //        //btnDET_DEL.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnDET_CHANGE.ImageUrl = "../../Contents/Image/BackGround/btn-det_change1-4.jpg";
            //        //btnDET_CHANGE.Attributes["onmouseover"] = "MM_swapImage('" + btnDET_CHANGE.ClientID + "','','../../Contents/Image/BackGround/btn-det_change2-4.jpg',1);";
            //        //btnDET_CHANGE.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnRELEASE.ImageUrl = "../../Contents/Image/BackGround/btn-release1-4.jpg";
            //        //btnRELEASE.Attributes["onmouseover"] = "MM_swapImage('" + btnRELEASE.ClientID + "','','../../Contents/Image/BackGround/btn-release2-4.jpg',1);";
            //        //btnRELEASE.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //btnSearch.ImageUrl = "../../Contents/Image/BackGround/btn-search1-4.jpg";
            //        //btnSearch.Attributes["onmouseover"] = "MM_swapImage('" + btnSearch.ClientID + "','','../../Contents/Image/BackGround/btn-search2-4.jpg',1);";
            //        //btnSearch.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        break;
            //}

            //btnWHS_CD.Attributes["onmouseover"] = "MM_swapImage('" + btnWHS_CD.ClientID + "','','../../Contents/Image/BackGround/sbtn_search_w2.gif',1);";
            //btnWHS_CD.Attributes["onmouseout"] = "MM_swapImgRestore();";

            flblTitle.Text = "BOM Master";
            //Detail Button
            btnDET_CHANGE.Enabled = false;
            btnDET_DEL.Enabled = false;
            btnRELEASE.Enabled = false;
            btnDET_ADD.Enabled = true;
            switch (g_lang)
            {
                case 1:
                    //btnDET_CHANGE.ImageUrl = "../../Contents/Image/BackGround/btn-det_change3-1.jpg";
                    //btnDET_DEL.ImageUrl = "../../Contents/Image/BackGround/btn-det_del3-1.jpg";
                    //btnRELEASE.ImageUrl = "../../Contents/Image/BackGround/btn-release3-1.jpg";
                    //btnDET_ADD.ImageUrl = "../../Contents/Image/BackGround/btn-det_add1-1.jpg";
                    break;
                case 2:
                    //btnDET_CHANGE.ImageUrl = "../../Contents/Image/BackGround/btn-det_change3-2.jpg";
                    //btnDET_DEL.ImageUrl = "../../Contents/Image/BackGround/btn-det_del3-2.jpg";
                    //btnRELEASE.ImageUrl = "../../Contents/Image/BackGround/btn-release3-2.jpg";
                    //btnDET_ADD.ImageUrl = "../../Contents/Image/BackGround/btn-det_add1-2.jpg";
                    break;
                case 3:
                    //btnDET_CHANGE.ImageUrl = "../../Contents/Image/BackGround/btn-det_change3-3.jpg";
                    //btnDET_DEL.ImageUrl = "../../Contents/Image/BackGround/btn-det_del3-3.jpg";
                    //btnRELEASE.ImageUrl = "../../Contents/Image/BackGround/btn-release3-3.jpg";
                    //btnDET_ADD.ImageUrl = "../../Contents/Image/BackGround/btn-det_add1-3.jpg";
                    break;
                case 4:
                    //btnDET_CHANGE.ImageUrl = "../../Contents/Image/BackGround/btn-det_change3-4.jpg";
                    //btnDET_DEL.ImageUrl = "../../Contents/Image/BackGround/btn-det_del3-4.jpg";
                    //btnRELEASE.ImageUrl = "../../Contents/Image/BackGround/btn-release3-4.jpg";
                    //btnDET_ADD.ImageUrl = "../../Contents/Image/BackGround/btn-det_add1-4.jpg";
                    break;
            }
        }

        /// <summary>
        /// 検索画面追加
        /// </summary>
        protected void Add_Search()
        {
            // 倉庫検索画面
            //Search srch = new Search();
            //srch.search_type = Search.SearchType.WHS;
            //srch.opener = this;
            //srch.opener_button = btnWHS_CD;
            //ArrayList arrObj = new ArrayList();
            //arrObj.Add(txtITEM_NO);
            //arrObj.Add(txtITEM_DESC);
            //srch.return_controls = arrObj;
            //int rtn = srch.CreateSearchWindow();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            dgvDetail.PageIndex = 0;
            Edit_Screen();
        }

        /// <summary>
        /// 画面編集
        /// </summary>
        protected void Edit_Screen()
        {
            ComLibrary com = new ComLibrary();
            Message msg = new Message(g_user_id, g_lang);
            Item item = new Item(g_user_id, g_lang);
            MfgBom Mfb = new MfgBom(g_user_id, g_lang);

            if (txtITEM_NO.Text.Trim() == "")
            {
                lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblITEM_NO.Text + ")";
                lblMsg.ForeColor = Color.Red;

                return;
            }
            else
            {
                item.item_no = txtITEM_NO.Text.ToUpper().Trim();
                if (item.GetItemDetail() == ComConst.SUCCEED)
                {
                    txtITEM_DESC.Text = item.item_desc;
                    txtITEM_DESC.ToolTip = item.item_desc;
                }
                else
                {
                    lblMsg.Text = msg.GetMessage("ITEM_NOT_EXIST_ERR");
                    lblMsg.ForeColor = Color.Red;
                    dgvDetail.DataSource = null;
                    dgvDetail.DataBind();
                    txtBOM_No.Text = "";
                    txtBOM_Level.Text = "";
                    txtBOM_Sub_Level.Text = "";
                    txtSequent.Text = "";
                    txtChild_Item.Text = "";
                    //txtChild_ItemDesc.Text = "";
                    txtUsg_Qty.Text = "";
                    txtITEM_DESC.Text = "";
                    return;
                }
            }

            //Warehouse whs = new Warehouse(g_user_id, g_lang);
            //whs.whs_cd = txtITEM_NO.Text.ToUpper();
            //txtITEM_NO.Text = whs.whs_cd;
            //int rtn = whs.GetWarehouseDetail();
            //if (rtn == ComConst.FAILED)
            //{
            //    txtITEM_DESC.Text = "";
            //    lblMsg.Text = msg.GetMessage("WAREHOUSE_NOT_EXIST_ERR");
            //    lblMsg.ForeColor = Color.Red;
            //    return;
            //}
            //txtITEM_DESC.Text = whs.whs_desc;

            // マスタを検索
            //Location loc = new Location(g_user_id, g_lang);
            //loc.whs_cd = txtITEM_NO.Text.ToUpper().Trim();

            //DataSet ds = loc.GetLocationList();
            Mfb.parent_item_no = txtITEM_NO.Text.ToUpper();
            txtITEM_NO.Text = Mfb.parent_item_no;
            DataSet ds = Mfb.GetMfgBomList();

            if (ds == null)
            {
                //lblMsg.Text = loc.strErr;
                lblMsg.Text = Mfb.strErr;
                lblMsg.ForeColor = Color.Red;
                dgvDetail.DataSource = null;
                dgvDetail.DataBind();
                txtBOM_No.Text = "";
                txtBOM_Level.Text = "";
                txtBOM_Sub_Level.Text = "";
                txtSequent.Text = "";
                txtChild_Item.Text = "";
                //txtChild_ItemDesc.Text = "";
                txtUsg_Qty.Text = "";
                return;
            }
            if (ds.Tables[0].Rows.Count == 0)
            {
                //Clear DataGridView
                dgvDetail.DataSource = null;
                dgvDetail.DataBind();
                lblMsg.Text = msg.GetMessage("DATA_NOT_EXIST_ERR");
                lblMsg.ForeColor = Color.Red;
                txtBOM_No.Text = "";
                txtBOM_Level.Text = "";
                txtBOM_Sub_Level.Text = "";
                txtSequent.Text = "";
                txtChild_Item.Text = "";
                //txtChild_ItemDesc.Text = "";
                txtUsg_Qty.Text = "";
                return;
            }
            txtBOM_No.Text = "";
            txtBOM_Level.Text = "";
            txtBOM_Sub_Level.Text = "";
            txtSequent.Text = "";
            txtChild_Item.Text = "";
            txtChild_ItemDesc.Text = "";
            txtUsg_Qty.Text = "";
            hdnITEM_NO.Value = "";
            hdnSequent.Value = "";
            hdnChild_Item.Value = "";

            Edit_grid(ds.Tables[0]);
            ViewState["dgvSearch"] = ds.Tables[0];

            dgvDetail.SelectedIndex = -1;
        }
        protected void Edit_grid(DataTable dt)
        {
            ComLibrary com = new ComLibrary();
            dgvDetail.DataSource = dt;
            dgvDetail.DataBind();
            ViewState["dgvDetail"] = dt;

        }
        #endregion

        #region # ボタン クリック #
        /// <summary>
        /// 戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void imgReturn_Click(object sender, EventArgs e)
        {
            //return Menu Add by zhao 20090508
            //string g_program_id = Request["program_id"].ToString();
            //int g_level = int.Parse(Request["level"].ToString());
            //IMClass.Common com = new IMClass.Common();
            //g_program_id = com.GetBackMenuGrp(g_program_id, g_level);
            //string strUrl = "~/Default.aspx?program_id=" + g_program_id + "&level=" + g_level.ToString();
            //string strUrl = "Default.aspx";
            //Response.Redirect(strUrl);
        }


        /// <summary>
        /// 明細追加ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDET_ADD_Click(object sender, EventArgs e)
        {
            ComLibrary com = new ComLibrary();
            Message msg = new Message(g_user_id, g_lang);
            //Location loc = new Location(g_user_id, g_lang);
            MfgBom Mfb = new MfgBom(g_user_id, g_lang);

            if (txtChild_Item.Text.Trim() == "")
            {
                lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblChild_Item.Text + ")";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            //if (txtChild_ItemDesc.Text.Trim() == "")
            //{
            //    lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblChild_Item.Text + ")";
            //    lblMsg.ForeColor = Color.Red;
            //    return;
            //}
            if (txtSequent.Text.Trim() == "")
            {
                lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblSequent.Text + ")";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            if (txtUsg_Qty.Text.Trim() == "")
            {
                lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblUsg_Qty.Text + ")";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            //loc.whs_cd = txtITEM_NO.Text.Trim().ToUpper();
            //loc.location = txtSequent.Text.Trim().ToUpper();
            //loc.location_desc = txtChild_Item.Text.Trim();
            //loc.chg_pgm = "MstLocationMnt";
            Mfb.data_char1 = txtBOM_No.Text.ToUpper();
            Mfb.data_num1 = com.StringToInt(txtBOM_Level.Text);
            Mfb.data_num2 = com.StringToInt(txtBOM_Sub_Level.Text);
            Mfb.parent_item_no = txtITEM_NO.Text.ToUpper();
            Mfb.child_item_no = txtChild_Item.Text.ToUpper();
            Mfb.part_seq = com.StringToInt(txtSequent.Text);
            Mfb.usage_dec = com.StringToDouble(txtUsg_Qty.Text);
            Mfb.chg_user_id = g_user_id;

            if (!Check_Bom(Mfb.parent_item_no, Mfb.child_item_no))
            {
                return;
            }
            //Mfb.chg_pgm = "MstMfgBOMMnt";
            //int rtn = loc.Insert();
            //if (rtn != ComConst.SUCCEED)
            //{
            //    lblMsg.Text = loc.strErr;
            //    lblMsg.ForeColor = Color.Red;
            //    return;
            //}

            int rtn = Mfb.Insert();
            if (rtn == ComConst.FAILED)
            {
                lblMsg.Text = Mfb.strErr;
                lblMsg.ForeColor = Color.Red;
                return;
            }

            Edit_Screen();
        }

        protected bool Check_Bom(string Parent, string Child)
        {
            Message msg = new Message(g_user_id, g_lang);
            MfgBom bom = new MfgBom(g_user_id, g_lang);
            DataSet ds = new DataSet();
            if (Parent == Child)
            {
                lblMsg.Text = msg.GetMessage("PARENT_AND_CHILD_SAME");
                lblMsg.ForeColor = Color.Red;
                return false;
            }

            return true;
        }

        /// <summary>
        /// 明細変更ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDET_CHANGE_Click(object sender, EventArgs e)
        {
            ComLibrary com = new ComLibrary();
            Message msg = new Message(g_user_id, g_lang);
            //Location loc = new Location(g_user_id, g_lang);
            MfgBom Mfb = new MfgBom(g_user_id, g_lang);

            if (txtSequent.Text.Trim() == "")
            {
                lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblSequent.Text + ")";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            if (txtUsg_Qty.Text.Trim() == "")
            {
                lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblUsg_Qty.Text + ")";
                lblMsg.ForeColor = Color.Red;
                return;
            }

            Mfb.data_char1 = txtBOM_No.Text.ToUpper();
            Mfb.data_num1 = com.StringToInt(txtBOM_Level.Text);
            Mfb.data_num2 = com.StringToInt(txtBOM_Sub_Level.Text);
            Mfb.parent_item_no = txtITEM_NO.Text.ToUpper();
            Mfb.part_seq = com.StringToInt(txtSequent.Text);
            Mfb.child_item_no = txtChild_Item.Text.ToUpper();
            Mfb.usage_dec = com.StringToDouble(txtUsg_Qty.Text);
            Mfb.chg_user_id = g_user_id;
            Mfb.chg_pgm = "MstMfgBOMMnt";

            int rtn = Mfb.Update();
            if (rtn == ComConst.FAILED)
            {
                lblMsg.Text = Mfb.strErr;
                lblMsg.ForeColor = Color.Red;
                return;
            }

            // ここでは削除して登録
            //loc.whs_cd = hdnITEM_NO.Value;
            //loc.location = hdnSequent.Value;
            //loc.chg_pgm = "MstLocationMnt";

            //int rtn = loc.Delete();
            //if (rtn != ComConst.SUCCEED)
            //{
            //    lblMsg.Text = loc.strErr;
            //    lblMsg.ForeColor = Color.Red;
            //    return;
            //}

            //loc.whs_cd = txtITEM_NO.Text.Trim().ToUpper();
            //loc.location = txtSequent.Text.Trim().ToUpper();
            //loc.location_desc = txtChild_Item.Text.Trim();
            //loc.chg_pgm = "MstLocationMnt";

            //rtn = loc.Insert();
            //if (rtn != ComConst.SUCCEED)
            //{
            //    lblMsg.Text = loc.strErr;
            //    lblMsg.ForeColor = Color.Red;
            //    return;
            //}

            Edit_Screen();

        }

        /// <summary>
        /// 明細削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDET_DEL_Click(object sender, EventArgs e)
        {
            ComLibrary com = new ComLibrary();
            Message msg = new Message(g_user_id, g_lang);
            //Location loc = new Location(g_user_id, g_lang);
            MfgBom Mfb = new MfgBom(g_user_id, g_lang);

            if (txtSequent.Text.Trim() == "")
            {
                lblMsg.Text = msg.GetMessage("INPUT_MANDATORY_ERR") + "(" + flblSequent.Text + ")";
                lblMsg.ForeColor = Color.Red;
                return;
            }

            // 削除
            //loc.whs_cd = hdnITEM_NO.Value;
            //loc.location = hdnSequent.Value;
            //loc.chg_pgm = "MstLocationMnt";
            Mfb.data_char1 = txtBOM_No.Text;
            Mfb.data_num1 = com.StringToInt(txtBOM_Level.Text);
            Mfb.data_num2 = com.StringToInt(txtBOM_Sub_Level.Text);
            Mfb.parent_item_no = hdnITEM_NO.Value;
            Mfb.part_seq = com.StringToInt(hdnSequent.Value);
            Mfb.child_item_no = hdnChild_Item.Value;

            /*int rtn = loc.Delete();
            if (rtn != ComConst.SUCCEED)
            {
                lblMsg.Text = loc.strErr;
                lblMsg.ForeColor = Color.Red;
                return;
            }*/
            int rtn = Mfb.Delete();
            if (rtn == ComConst.FAILED)
            {
                lblMsg.Text = Mfb.strErr;
                lblMsg.ForeColor = Color.Red;
                return;
            }
            if (dgvDetail.Rows.Count <= 1)
                dgvDetail.PageIndex = 0;

            Edit_Screen();
        }

        /// <summary>
        /// 行選択解除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRELEASE_Click(object sender, EventArgs e)
        {
            dgvDetail.SelectedIndex = -1;
            dgvDetail_SelectedIndexChanged(null, null);

        }
        #endregion

        #region # Grid 処理 #

        protected void dgvDetail_RowCreated(object sender, GridViewRowEventArgs e)
        {
            //選択ボタンセルを非表示にする(Visible = False だと制御ができないため） 
            if (e.Row.RowType != DataControlRowType.Pager)//保留Pager不被隐藏
            {
                e.Row.Cells[0].Style.Add("display", "none");
            }
            //// データ行ではない場合        
            if (e.Row.RowType != DataControlRowType.DataRow)
                return;

            //// 行をClickされた場合、JavaScriptを実行するよう設定する  
            e.Row.Attributes.Add("onclick", "javascript:__doPostBack('" + dgvDetail.UniqueID + "','Select$" + e.Row.RowIndex + "');");
        }

        /// <summary>
        /// GridView行選択
        /// </summary>
        protected void dgvDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComLibrary com = new ComLibrary();

            if (dgvDetail.SelectedIndex != -1)
            {
                txtBOM_No.Text = HttpUtility.HtmlDecode(((TextBox)dgvDetail.SelectedRow.FindControl("lblBOM_No")).Text).Trim();
                txtBOM_Level.Text = HttpUtility.HtmlDecode(((TextBox)dgvDetail.SelectedRow.FindControl("lblBOM_Level")).Text).Trim();
                txtBOM_Sub_Level.Text = HttpUtility.HtmlDecode(((TextBox)dgvDetail.SelectedRow.FindControl("lblBOM_Sub_Level")).Text).Trim();
                txtSequent.Text = HttpUtility.HtmlDecode(((TextBox)dgvDetail.SelectedRow.FindControl("lblSequent")).Text).Trim();
                txtChild_Item.Text = HttpUtility.HtmlDecode(((TextBox)dgvDetail.SelectedRow.FindControl("lblChild_Item")).Text).Trim();
                //txtChild_ItemDesc.Text = HttpUtility.HtmlDecode(((TextBox)dgvDetail.SelectedRow.FindControl("lblLOCATION_DESC")).Text).Trim();
                txtUsg_Qty.Text = HttpUtility.HtmlDecode(((TextBox)dgvDetail.SelectedRow.FindControl("lblUsage_Qty")).Text).Trim();

                hdnSequent.Value = txtSequent.Text;
                hdnITEM_NO.Value = txtITEM_NO.Text;
                hdnChild_Item.Value = txtChild_Item.Text;

                txtBOM_No.Enabled = false;
                txtBOM_Level.Enabled = false;
                txtBOM_Sub_Level.Enabled = false;
                txtSequent.Enabled = false;
                txtChild_Item.Enabled = false;
                //txtChild_ItemDesc.Enabled = false;
                
                btnParentItem.Visible = false;

                btnDET_CHANGE.Enabled = true;
                btnDET_DEL.Enabled = true;
                btnRELEASE.Enabled = true;
                btnDET_ADD.Enabled = false;

                switch (g_lang)
                {
                    case 1:
                        //btnDET_CHANGE.ImageUrl = "../../Contents/Image/BackGround/btn-det_change1-1.jpg";
                        //btnDET_DEL.ImageUrl = "../../Contents/Image/BackGround/btn-det_del1-1.jpg";
                        //btnRELEASE.ImageUrl = "../../Contents/Image/BackGround/btn-release1-1.jpg";
                        //btnDET_ADD.ImageUrl = "../../Contents/Image/BackGround/btn-det_add3-1.jpg";
                        break;
                    case 2:
                        //btnDET_CHANGE.ImageUrl = "../../Contents/Image/BackGround/btn-det_change1-2.jpg";
                        //btnDET_DEL.ImageUrl = "../../Contents/Image/BackGround/btn-det_del1-2.jpg";
                        //btnRELEASE.ImageUrl = "../../Contents/Image/BackGround/btn-release1-2.jpg";
                        //btnDET_ADD.ImageUrl = "../../Contents/Image/BackGround/btn-det_add3-2.jpg";
                        break;
                    case 3:
                        //btnDET_CHANGE.ImageUrl = "../../Contents/Image/BackGround/btn-det_change1-3.jpg";
                        //btnDET_DEL.ImageUrl = "../../Contents/Image/BackGround/btn-det_del1-3.jpg";
                        //btnRELEASE.ImageUrl = "../../Contents/Image/BackGround/btn-release1-3.jpg";
                        //btnDET_ADD.ImageUrl = "../../Contents/Image/BackGround/btn-det_add3-3.jpg";
                        break;
                    case 4:
                        //btnDET_CHANGE.ImageUrl = "../../Contents/Image/BackGround/btn-det_change1-4.jpg";
                        //btnDET_DEL.ImageUrl = "../../Contents/Image/BackGround/btn-det_del1-4.jpg";
                        //btnRELEASE.ImageUrl = "../../Contents/Image/BackGround/btn-release1-4.jpg";
                        //btnDET_ADD.ImageUrl = "../../Contents/Image/BackGround/btn-det_add3-4.jpg";
                        break;
                }
            }
            else
            {
                txtBOM_No.Text = "";
                txtBOM_Level.Text = "";
                txtBOM_Sub_Level.Text = "";
                txtSequent.Text = "";
                txtChild_Item.Text = "";
                //txtChild_ItemDesc.Text = "";
                txtUsg_Qty.Text = "";

                txtBOM_No.Enabled = true;
                txtBOM_Level.Enabled = true;
                txtBOM_Sub_Level.Enabled = true;
                txtSequent.Enabled = true;
                txtChild_Item.Enabled = true;
                //txtChild_ItemDesc.Enabled = true;
                btnParentItem.Visible = true;

                btnDET_CHANGE.Enabled = false;
                btnDET_DEL.Enabled = false;
                btnRELEASE.Enabled = false;
                btnDET_ADD.Enabled = true;

                switch (g_lang)
                {
                    case 1:
                        //btnDET_CHANGE.ImageUrl = "../../Contents/Image/BackGround/btn-det_change3-1.jpg";
                        //btnDET_DEL.ImageUrl = "../../Contents/Image/BackGround/btn-det_del3-1.jpg";
                        //btnRELEASE.ImageUrl = "../../Contents/Image/BackGround/btn-release3-1.jpg";
                        //btnDET_ADD.ImageUrl = "../../Contents/Image/BackGround/btn-det_add1-1.jpg";
                        break;
                    case 2:
                        //btnDET_CHANGE.ImageUrl = "../../Contents/Image/BackGround/btn-det_change3-2.jpg";
                        //btnDET_DEL.ImageUrl = "../../Contents/Image/BackGround/btn-det_del3-2.jpg";
                        //btnRELEASE.ImageUrl = "../../Contents/Image/BackGround/btn-release3-2.jpg";
                        //btnDET_ADD.ImageUrl = "../../Contents/Image/BackGround/btn-det_add1-2.jpg";
                        break;
                    case 3:
                        //btnDET_CHANGE.ImageUrl = "../../Contents/Image/BackGround/btn-det_change3-3.jpg";
                        //btnDET_DEL.ImageUrl = "../../Contents/Image/BackGround/btn-det_del3-3.jpg";
                        //btnRELEASE.ImageUrl = "../../Contents/Image/BackGround/btn-release3-3.jpg";
                        //btnDET_ADD.ImageUrl = "../../Contents/Image/BackGround/btn-det_add1-3.jpg";
                        break;
                    case 4:
                        //btnDET_CHANGE.ImageUrl = "../../Contents/Image/BackGround/btn-det_change3-4.jpg";
                        //btnDET_DEL.ImageUrl = "../../Contents/Image/BackGround/btn-det_del3-4.jpg";
                        //btnRELEASE.ImageUrl = "../../Contents/Image/BackGround/btn-release3-4.jpg";
                        //btnDET_ADD.ImageUrl = "../../Contents/Image/BackGround/btn-det_add1-4.jpg";
                        break;
                }
            }
        }

        protected void dgvDetail_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvDetail.SelectedIndex = -1;
            dgvDetail.PageIndex = e.NewPageIndex;
            dgvDetail.DataSource = (DataTable)ViewState["dgvDetail"];
            dgvDetail.DataBind();
        }

        #endregion
    }
}