using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using IMClass;

namespace HondaTraceabilitySystem.Common.Search
{
    public partial class SrchMgmt : System.Web.UI.Page
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
            //   MyCookie = new HttpCookie("IMLastVisit");
            //   HttpCookieCollection MyCookieColl = Request.Cookies;
            //   MyCookie = MyCookieColl.Get("IMLastVisit");

            //   g_user_id = MyCookie.Values["USER_ID"];
            //   g_lang = int.Parse(MyCookie.Values["LANG"]);
            //   g_company_cd = MyCookie.Values["COMPANY_CD"];
            //   g_name = HttpUtility.UrlDecode(MyCookie.Values["NAME"]);
            //}
            //catch
            //{
            //   Response.Redirect("~/NotLoginErr.htm");
            //}

            g_user_id = "admin-e";
            g_lang = 2;
            g_name = "General manager (English)";
            if (!IsPostBack)
            {
                // 画面編集
                Init_Label();
                Init_Proc();

                //this.imgBack.Attributes["onclick"] = "JavaScript:window.close()";
            }

            Script_Proc();

        }

        #region : 初期画面ラベル編集
        //
        // 初期画面ラベル編集
        //
        protected void Init_Label()
        {
            //Dictionary dic = new Dictionary(g_user_id, g_lang);
            //dic.screen_id = "SrchDept";
            //DataSet ds = dic.GetLabelOfScreenList();

            //if (ds != null && ds.Tables.Count > 0)
            //{
            //    foreach (DataRow row in ds.Tables[0].Rows)
            //    {
            //        switch (row["CONTROL_ID"].ToString())
            //        {
            //            // ラベル
            //            case "flblTitle": flblTitle.Text = row["ITEM_DESC"].ToString(); break;
            //            case "flblCount": flblCount.Text = "[" + row["ITEM_DESC"].ToString() + " = 0]"; break;
            //            //case "DEPT_TYPE1": hdnDeptType1.Value = row["ITEM_DESC"].ToString(); break;
            //            //case "DEPT_TYPE2": hdnDeptType2.Value = row["ITEM_DESC"].ToString(); break;

            //            // 一覧スプレッド
            //            case "dgvSearch_1": this.dgvSearch.Columns[1].HeaderText = row["ITEM_DESC"].ToString(); break;
            //            case "dgvSearch_2": this.dgvSearch.Columns[2].HeaderText = row["ITEM_DESC"].ToString(); break;
            //            case "dgvSearch_3": this.dgvSearch.Columns[3].HeaderText = row["ITEM_DESC"].ToString(); break;
            //        }
            //    }
            //}
            ////
            //// 更新系ボタンイメージの編集     －      言語対応とSwapImage
            ////
            //switch (g_lang)
            //{
            //    case 1:
            //        //imgDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-1.jpg";
            //        //imgDisp.Attributes["onmouseover"] = "MM_swapImage('" + imgDisp.ClientID + "','','../../Contents/Image/BackGround/btn-ind2-1.jpg',1);";
            //        //imgDisp.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //imgBack.ImageUrl = "../../Contents/Image/BackGround/btn-Back1-1.jpg";
            //        //imgBack.Attributes["onmouseover"] = "MM_swapImage('" + imgBack.ClientID + "','','../../Contents/Image/BackGround/btn-Back2-1.jpg',1);";
            //        //imgBack.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        break;
            //    case 2:
            //        //imgDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-2.jpg";
            //        //imgDisp.Attributes["onmouseover"] = "MM_swapImage('" + imgDisp.ClientID + "','','../../Contents/Image/BackGround/btn-ind2-2.jpg',1);";
            //        //imgDisp.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //imgBack.ImageUrl = "../../Contents/Image/BackGround/btn-Back1-2.jpg";
            //        //imgBack.Attributes["onmouseover"] = "MM_swapImage('" + imgBack.ClientID + "','','../../Contents/Image/BackGround/btn-Back2-2.jpg',1);";
            //        //imgBack.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        break;
            //    case 3:
            //        //imgDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-3.jpg";
            //        //imgDisp.Attributes["onmouseover"] = "MM_swapImage('" + imgDisp.ClientID + "','','../../Contents/Image/BackGround/btn-ind2-3.jpg',1);";
            //        //imgDisp.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //imgBack.ImageUrl = "../../Contents/Image/BackGround/btn-Back1-3.jpg";
            //        //imgBack.Attributes["onmouseover"] = "MM_swapImage('" + imgBack.ClientID + "','','../../Contents/Image/BackGround/btn-Back2-3.jpg',1);";
            //        //imgBack.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        break;
            //    case 4:
            //        //imgDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-4.jpg";
            //        //imgDisp.Attributes["onmouseover"] = "MM_swapImage('" + imgDisp.ClientID + "','','../../Contents/Image/BackGround/btn-ind2-4.jpg',1);";
            //        //imgDisp.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        //imgBack.ImageUrl = "../../Contents/Image/BackGround/btn-Back1-4.jpg";
            //        //imgBack.Attributes["onmouseover"] = "MM_swapImage('" + imgBack.ClientID + "','','../../Contents/Image/BackGround/btn-Back2-4.jpg',1);";
            //        //imgBack.Attributes["onmouseout"] = "MM_swapImgRestore();";
            //        break;
            //}
        }
        #endregion

        #region : 初期画面編集
        //
        // 初期画面編集
        //
        protected void Init_Proc()
        {
            // Grid_View編集
            Edit_Grid();
        }
        //
        // Grid_View編集
        //
        protected void Edit_Grid()
        {
            // 品目マスタより一覧を得る
            string[] strcou;
            strcou = flblCount.Text.Split('=');
            Message msg = new Message(g_user_id, g_lang);

            Mgmt SrchMgmt = new Mgmt(g_user_id, g_lang);
            //SrchDept.dept_cd = txtDepartment.Text.ToUpper();
            DataSet ds = SrchMgmt.GetMGMTList();
            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                dgvSearch.DataSource = null;
                dgvSearch.DataBind();
                flblCount.Text = strcou[0] + " = 0]";
            }
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dgvSearch.DataSource = ds.Tables[0];
                dgvSearch.DataBind();
                ViewState["dgvSearch"] = ds.Tables[0];
                flblCount.Text = strcou[0] + " = " + ds.Tables[0].Rows.Count.ToString() + "]";
            }
        }

        //
        // クライアントスクリプト編集
        //
        protected void Script_Proc()
        {
            //[ 共通：クライアントスクリプトの生成 ]
            //
            //  検索・検索結果を起動元(親)画面に返すJavaScriptを記述
            //
            StringBuilder sb = new StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append(@"function SelectedRow(item1, item2) {");
            sb.Append(@"    $('#hdnML').val(item1);   ");
            sb.Append(@"    $('#hdnMLDesc').val(item2);   ");
            sb.Append(@"    $('#basicModalML').modal('hide');   ");
            //sb.Append(@"    $('#basicModalML2').modal('hide');   ");
            sb.Append(@"} ");
            //sb.Append(@"    var arr0 = item1;");   //工程コード
            //sb.Append(@"    var arr1 = item2;");   //工程名   
            //sb.Append(@"    var ret= new Array(arr0,arr1);    ");
            //sb.Append(@"    window.opener.").Append(Request["ScriptName"].ToString()).Append("(ret); ");
            //sb.Append(@"    __doPostBack();   ");
            //sb.Append(@"    window.close();   ");
            //sb.Append(@"} ");

            // onMouseover Event
            sb.Append(@"function MouseoverRow(ID) {");
            //sb.Append(@"    document.getElementById(ID).style.backgroundColor = 'orange' ");
            sb.Append(@"} ");

            // onMouseout Event
            sb.Append(@"function MouseoutRow(ID) {");
            //sb.Append(@"    document.getElementById(ID).style.backgroundColor = '' ");
            sb.Append(@"} ");

            sb.Append(@"</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "SelectedRow", sb.ToString());
        }
        #endregion

        // Sort
        //
        // Fixed logic. Do not change.
        //
        protected void dgvSearch_Sorting(object sender, GridViewSortEventArgs e)
        {
            string sortExpression = e.SortExpression;
            if (GridViewSortDirection == SortDirection.Ascending)
            {
                GridViewSortDirection = SortDirection.Descending;
                SortGridView(sortExpression, " DESC");
            }
            else
            {
                GridViewSortDirection = SortDirection.Ascending;
                SortGridView(sortExpression, " ASC");
            }
            Script_Proc();
        }
        public SortDirection GridViewSortDirection
        {
            get
            {
                if (ViewState["sortDirection"] == null)
                    ViewState["sortDirection"] = SortDirection.Ascending;
                return (SortDirection)ViewState["sortDirection"];
            }
            set { ViewState["sortDirection"] = value; }
        }
        private void SortGridView(string sortExpression, string direction)
        {
            DataTable dt = (DataTable)ViewState["dgvSearch"];
            DataView dv = new DataView(dt);
            dv.Sort = sortExpression + direction;
            dgvSearch.DataSource = dv;
            dgvSearch.DataBind();
        }

        protected void dgvSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Script_Proc();
        }

        //
        // Fixed logic. Do not change.
        //
        protected void dgvSearch_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvSearch.PageIndex = e.NewPageIndex;
            // Grid_View編集
            Edit_Grid();
        }

        /// <summary>
        /// 再表示ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void imgDisp_Click(object sender, ImageClickEventArgs e)
        {
            // Grid_View編集
            Edit_Grid();
        }

        protected void dgvSearch_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            string strEvent = "";
            ComLibrary com = new ComLibrary();
            string rowID = String.Empty;
            if (e.Row.DataItemIndex >= 0)
            {
                rowID = "row" + e.Row.RowIndex;
                e.Row.Attributes.Add("id", "row" + e.Row.RowIndex);
                strEvent = String.Format("SelectedRow('{0}', '{1}')", com.SetJsStr(((TextBox)e.Row.FindControl("lblMgmtLvl")).Text), com.SetJsStr(((TextBox)e.Row.FindControl("lblMgmtDesc")).Text));
                e.Row.Attributes.Add("onClick", strEvent);

                //strEvent = String.Format("MouseoverRow('{0}')", rowID);
                strEvent = String.Format("this.style.background='{0}'", "orange");
                e.Row.Attributes.Add("onmouseover", strEvent);

                //strEvent = String.Format("MouseoutRow('{0}')", rowID);
                strEvent = String.Format("this.style.background='{0}'", "");
                e.Row.Attributes.Add("onmouseout", strEvent);
            }
        }
    }
}