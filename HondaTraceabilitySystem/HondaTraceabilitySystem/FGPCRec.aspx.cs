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
    public partial class FGPCRec : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                //// 画面編集
                Init_Label();
                Init_Proc();
            }
            lblMsg.Text = "";
        }

        //
        // 初期画面ラベル編集
        //
        protected void Init_Label()
        {

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

            dt.Rows.Add("Block", "Block");
            dt.Rows.Add("Head", "Head");
            dt.Rows.Add("Crank Shaft", "Crank Shaft");
            dt.Rows.Add("Conn Rod", "Conn Rod");

            ddlTYPE.DataValueField = "DEPT_NO";
            ddlTYPE.DataTextField = "DEPT_NAME";
            ddlTYPE.DataSource = dt;
            ddlTYPE.DataBind();
        }

        protected void cmdSave_Click(object sender, EventArgs e)
        {
            Jo jo = new Jo(g_user_id, g_lang);
            Message msg = new Message(g_user_id, g_lang);
            ComLibrary com = new ComLibrary();
            jo.plan_no = txtLOT_NO.Text;
            jo.catg_cd = txtDEL_TYPE.Text;
            jo.demand_no = txtLOT_NO2.Text;
            if (ddlTYPE.SelectedValue == "Block")
            {
                if (jo.Inv_ManWhsInsert() == ComConst.FAILED)
                {
                    lblMsg.Text = jo.strErr;
                    lblMsg.ForeColor = Color.Red;
                    return;
                }
            }
            if (ddlTYPE.SelectedValue == "Head")
            {
                if (jo.Inv_ManWhsInsertA() == ComConst.FAILED)
                {
                    lblMsg.Text = jo.strErr;
                    lblMsg.ForeColor = Color.Red;
                    return;
                }
            }
            if (ddlTYPE.SelectedValue == "Crank Shaft")
            {
                if (jo.Inv_ManWhsInsertB() == ComConst.FAILED)
                {
                    lblMsg.Text = jo.strErr;
                    lblMsg.ForeColor = Color.Red;
                    return;
                }
            }
            if (ddlTYPE.SelectedValue == "Conn Rod")
            {
                if (jo.Inv_ManWhsInsertC() == ComConst.FAILED)
                {
                    lblMsg.Text = jo.strErr;
                    lblMsg.ForeColor = Color.Red;
                    return;
                }
            }
            lblMsg.Text = msg.GetMessage("NORMAL_UPDATE");
            lblMsg.ForeColor = Color.Blue;
            txtLOT_NO.Text = "";
            txtDEL_TYPE.Text = "";
            txtLOT_NO2.Text = "";
        }

    }
}