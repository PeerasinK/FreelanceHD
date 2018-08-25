using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IMClass;
using System.Drawing;
using System.Collections;
using System.Data;
using System.Web.Configuration;
using System.Text;

namespace HondaTraceabilitySystem
{
    public partial class FGRecSumm : System.Web.UI.Page
    {
        protected string g_user_id;
        protected int g_lang;
        protected string g_company_cd;
        protected string g_name;

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
            }
            catch
            {
                //Response.Redirect("~/NotLoginErr.htm");
                Response.Redirect("~/Login.aspx");
            }
            //g_user_id = "test";
            //g_lang = 2;
            //g_name = "TEST USER";
            //Page.Form.DefaultButton = cmdDisp.UniqueID;
            if (!IsPostBack)
            {
                //// 画面編集
                Init_Label();
                Init_Proc();
            }
            else
            {
                Edit_Screen();
            }
            lblMsg.Text = "";
            //Auth_Proc();
        }

        //
        // 初期画面ラベル編集
        //
        protected void Init_Label()
        {
            lblUserName.Text = g_name;

        }

        /// <summary>
        /// 初期画面編集
        /// </summary>
        protected void Init_Proc()
        {
            ddl_edit();
        }

        /// <summary>
        /// EDIT DROP DOWN LIST
        /// </summary>
        protected void ddl_edit()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("DEPT_NO"));
            dt.Columns.Add(new DataColumn("DEPT_NAME"));

            dt.Rows.Add("MC CKD", "MC CKD");
            dt.Rows.Add("FE CKD", "FE CKD");

            ddlTYPE.DataValueField = "DEPT_NO";
            ddlTYPE.DataTextField = "DEPT_NAME";
            ddlTYPE.DataSource = dt;
            ddlTYPE.DataBind();
        }

        #region ：画面権限編集
        /// <summary>
        /// 画面権限編集 
        /// </summary>
        protected void Auth_Proc()
        {
        }

        #endregion

        protected void cmdDisp_Click(object sender, EventArgs e)
        {
            Edit_Screen();
        }

        protected void Edit_Screen()
        {
            ComLibrary com = new ComLibrary();
            Message msg = new Message(g_user_id, g_lang);
            Inv inv = new Inv(g_user_id, g_lang);
            DataSet ds = new DataSet();

            gdvDetail.DataSource = null;
            gdvDetail.DataBind();
            ViewState["gdvDetail"] = null;

            inv.sch_id = ddlTYPE.SelectedValue;
            
            //ds = inv.GetRecvDisbList2();
            //if (ds == null)
            //{
            //    lblMsg.Text = inv.strErr;
            //    lblMsg.ForeColor = Color.Red;
            //    return;
            //}
            //if (ds.Tables[0].Rows.Count == 0)
            //{
            //    lblMsg.Text = msg.GetMessage("DATA_NOT_EXIST_ERR");
            //    lblMsg.ForeColor = Color.Red;
            //    return;
            //}
            //else
            //{
            //    DataTable dt = ds.Tables[0];
            //    ViewState["gdvDetail"] = dt;
            //    Edit_Grid();
            //}
        }

        protected void Edit_Grid()
        {
            DataTable dt = (DataTable)ViewState["gdvDetail"];
            gdvDetail.DataSource = dt;
            gdvDetail.DataBind();
        }

        protected void cmdCancel_Click(object sender, EventArgs e)
        {
            ViewState["gdvDetail"] = null;
        }

        protected void gdvDetail_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdvDetail.PageIndex = e.NewPageIndex;
            if (ViewState["gdvDetail"] != null)
            {
                gdvDetail.DataSource = (DataTable)ViewState["gdvDetail"];
                gdvDetail.DataBind();
            }
        }

        protected void gdvDetail_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }

        protected void ddlPROCESS_SelectedIndexChanged(object sender, EventArgs e)
        {
            Edit_Screen();
        }

        protected void imgReturn_Click(object sender, EventArgs e)
        {
            //string g_program_id = Request["program_id"].ToString();
            //int g_level = int.Parse(Request["level"].ToString());
            //IMClass.Common com = new IMClass.Common();
            //g_program_id = com.GetBackMenuGrp(g_program_id, g_level);
            //string strUrl = "~/Default.aspx?program_id=" + g_program_id + "&level=" + g_level.ToString();
            string strUrl = "Default.aspx";
            Response.Redirect(strUrl);
        }
    }
}