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
    public partial class FeOnProd : System.Web.UI.Page
    {
        protected string g_user_id;
        protected int g_lang;
        protected string g_company_cd;
        protected string g_name;
        protected string g_type;

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
                //g_type = WebConfigurationManager.AppSettings["db_type"];
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
                if (ViewState["gdvDetail"] != null)
                {
                    Edit_Grid();
                }
            }
            //SaveGridData();
            lblMsg.Text = "";
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

            dt.Columns.Add(new DataColumn("PROCESS_NO"));
            dt.Columns.Add(new DataColumn("PROCESS_NAME"));

            dt.Rows.Add("Crank Shaft", "Crank Shaft");
            dt.Rows.Add("Conn Rod", "Conn Rod");

            ddlPROCESS.DataValueField = "PROCESS_NO";
            ddlPROCESS.DataTextField = "PROCESS_NAME";
            ddlPROCESS.DataSource = dt;
            ddlPROCESS.DataBind();
        }

        protected void cmdDisp_Click(object sender, EventArgs e)
        {
            Edit_Screen();
        }

        protected void Edit_Screen()
        {
            ComLibrary com = new ComLibrary();
            Message msg = new Message(g_user_id, g_lang);
            Transfer tf = new Transfer(g_user_id, g_lang);
            DataSet ds = new DataSet();

            chkALL_SEL.Checked = false;
            gdvDetail.DataSource = null;
            gdvDetail.DataBind();
            ViewState["gdvDetail"] = null;

            tf.to_process_cd = ddlPROCESS.Text;

            ds = tf.GetUnplannedRcvActList2();
            if (ds == null)
            {
                lblMsg.Text = tf.strErr;
                lblMsg.ForeColor = Color.Red;
                return;
            }
            if (ds.Tables[0].Rows.Count == 0)
            {
                lblMsg.Text = msg.GetMessage("DATA_NOT_EXIST_ERR");
                lblMsg.ForeColor = Color.Red;
                return;
            }
            else
            {
                DataTable dt = ds.Tables[0];
                ViewState["gdvDetail"] = dt;
                Edit_Grid();
            }
        }

        protected void SaveGridData()
        {
            if (gdvDetail.Rows.Count != 0)
            {
                ComLibrary com = new ComLibrary();
                DataTable dt = (DataTable)(ViewState["gdvDetail"]);
                if (dt.Columns["SELECT"] == null)
                {
                    dt.Columns.Add("SELECT");
                }
                int j;
                for (int i = 0; i < gdvDetail.Rows.Count; i++)
                {
                    j = gdvDetail.Rows[i].DataItemIndex;
                    dt.Rows[j]["SELECT"] = com.BoolToInt(((CheckBox)gdvDetail.Rows[i].FindControl("chkSEL")).Checked);
                }
                ViewState["gdvDetail"] = dt;
            }
        }

        protected void Edit_Grid()
        {
            SaveGridData();
            int j;
            ComLibrary com = new ComLibrary();
            DataTable dt = (DataTable)ViewState["gdvDetail"];
            if (dt.Columns["SELECT"] == null)
            {
                dt.Columns.Add("SELECT");
            }
            gdvDetail.DataSource = dt;
            gdvDetail.DataBind();
            for (int i = 0; i < gdvDetail.Rows.Count; i++)
            {
                j = gdvDetail.Rows[i].DataItemIndex;
                if (dt.Rows[j]["SELECT"].ToString() != "")
                    ((CheckBox)gdvDetail.Rows[i].FindControl("chkSEL")).Checked = com.IntToBool(com.StringToInt(dt.Rows[j]["SELECT"].ToString()));
            }
        }

        protected void cmdIssue_Click(object sender, EventArgs e)
        {
            ComLibrary com = new ComLibrary();
            Message msg = new Message(g_user_id, g_lang);

            Transfer tf = new Transfer(g_user_id, g_lang);
            DataTable dt = (DataTable)(ViewState["gdvDetail"]);
            if (dt == null)
            {
                return;
            }
            bool Find_flg = false;
            int rtn = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["SELECT"].ToString() == "1")
                {
                    Find_flg = true;

                    tf.slip_no = dt.Rows[i]["Receive_No"].ToString();
                    tf.entry_date = DateTime.Now;

                    //tf.chg_pgm = "InvAdjAct";
                    tf.chg_user_id = g_user_id;

                    if (ddlPROCESS.SelectedValue == "Crank Shaft")
                    {
                        rtn = tf.UnplannedRcvDisbAct2();
                    }
                    else
                    {
                        rtn = tf.UnplannedRcvDisbAct2A();
                    }

                    if (rtn == ComConst.FAILED)
                    {
                        //db.DbRollback();
                        lblMsg.Text = tf.strErr;
                        lblMsg.ForeColor = Color.Red;
                        return;
                    }
                }
            }


            if (!Find_flg)
            {
                lblMsg.Text = msg.GetMessage("NO_CHECK_ERR");
                lblMsg.ForeColor = Color.Red;
                return;
            }
            else
            {
                Edit_Screen();
                lblMsg.Text = msg.GetMessage("NORMAL_UPDATE");
                lblMsg.ForeColor = Color.Blue;
            }
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

        protected void gdvDetail_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdvDetail.PageIndex = e.NewPageIndex;
            if (ViewState["gdvDetail"] != null)
            {
                Edit_Grid();
            }
        }

        protected void gdvDetail_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }

        protected void chkALL_SEL_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewState["gdvDetail"] != null)
            {
                DataTable dt = (DataTable)ViewState["gdvDetail"];
                string chk;
                if (chkALL_SEL.Checked)
                {
                    chk = "1";
                }
                else
                {
                    chk = "0";
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["SELECT"] = chk;
                }
                for (int i = 0; i < gdvDetail.Rows.Count; i++)
                {
                    ((CheckBox)gdvDetail.Rows[i].FindControl("chkSEL")).Checked = chkALL_SEL.Checked;
                }
            }
        }

        protected void ddlPROCESS_SelectedIndexChanged(object sender, EventArgs e)
        {
            Edit_Screen();
        }

        protected void chkSEL_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}