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
    public partial class FeHTRec2 : System.Web.UI.Page
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
            //    g_company_cd = MyCookie.Values["COMPANY_CD"];
            //    g_name = HttpUtility.UrlDecode(MyCookie.Values["NAME"]);
            //}
            //catch
            //{
            //    Response.Redirect("~/NotLoginErr.htm");
            //}
            g_user_id = "admin-e";
            g_lang = 2;
            g_name = "General manager (English)";
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
            DataSet dt = new DataSet();
            ComLibrary com = new ComLibrary();

            Transfer tf = new Transfer(g_user_id, g_lang);

            tf.to_process_cd = "Crank Shaft";
            dt = tf.GetUnplannedRcvActList2();

            DataTable dt2 = new DataTable();

            dt2.Columns.Add(new DataColumn("PROCESS_NO"));
            dt2.Columns.Add(new DataColumn("PROCESS_NAME"));

            dt2.Rows.Add("Crank Shaft", "Crank Shaft");
            //dt2.Rows.Add("Conn Rod", "Conn Rod");

            ddlPROCESS.DataValueField = "PROCESS_NO";
            ddlPROCESS.DataTextField = "PROCESS_NAME";
            ddlPROCESS.DataSource = dt2;
            ddlPROCESS.DataBind();

            dt2 = null;

            dt2 = dt.Tables[0];
            ViewState["detail"] = dt2;

            if (dt2.Rows.Count > 0)
            {
                hdnNo.Value = "1";
                hdnMaxNo.Value = dt2.Rows.Count.ToString();
                lblNo.Text = hdnNo.Value + " of " + hdnMaxNo.Value;
                txtITEM_NO.Text = dt2.Rows[0]["PART_NO"].ToString();
                txtLOT_NO.Text = dt2.Rows[0]["LOT_NO"].ToString();
                txtRCV_QTY.Text = dt2.Rows[0]["RECEIVE_QTY"].ToString();
                txtDIE_NO.Text = dt2.Rows[0]["DIE_NO"].ToString();
                txtSHIFT_NO.Text = dt2.Rows[0]["SHIFT"].ToString();
            }
        }

        protected void update_list()
        {
            DataSet dt = new DataSet();
            ComLibrary com = new ComLibrary();

            Transfer tf = new Transfer(g_user_id, g_lang);

            tf.to_process_cd = ddlPROCESS.Text;
            dt = tf.GetUnplannedRcvActList2();

            DataTable dt2 = new DataTable();

            dt2 = dt.Tables[0];
            ViewState["detail"] = dt2;

            if (dt2.Rows.Count > 0)
            {
                hdnNo.Value = "1";
                hdnMaxNo.Value = dt2.Rows.Count.ToString();
                lblNo.Text = hdnNo.Value + " of " + hdnMaxNo.Value;
                txtITEM_NO.Text = dt2.Rows[0]["PART_NO"].ToString();
                txtLOT_NO.Text = dt2.Rows[0]["LOT_NO"].ToString();
                txtRCV_QTY.Text = dt2.Rows[0]["RECEIVE_QTY"].ToString();
                txtDIE_NO.Text = dt2.Rows[0]["DIE_NO"].ToString();
                txtSHIFT_NO.Text = dt2.Rows[0]["SHIFT"].ToString();
            }
            else
            {
                hdnNo.Value = "1";
                hdnMaxNo.Value = "1";
                lblNo.Text = "";
                txtITEM_NO.Text = "";
                txtLOT_NO.Text = "";
                txtRCV_QTY.Text = "";
                txtDIE_NO.Text = "";
                txtSHIFT_NO.Text = "";
            }
        }

        protected void cmdSave_Click(object sender, EventArgs e)
        {
            //Transfer tran = new Transfer(g_user_id, g_lang);
            //Message msg = new Message(g_user_id, g_lang);
            //ComLibrary com = new ComLibrary();
            //tran.item_no = txtITEM_NO.Text;
            //tran.lot_no = txtLOT_NO.Text;
            //tran.act_qty = com.StringToDouble(txtRCV_QTY.Text);
            //tran.die_no = txtDIE_NO.Text;
            //tran.shift = txtSHIFT_NO.Text;
            //if (tran.FEReceiveHT() == ComConst.FAILED)
            //{
            //    lblMsg.Text = tran.strErr;
            //    lblMsg.ForeColor = Color.Red;
            //    return;
            //}
            //lblMsg.Text = msg.GetMessage("NORMAL_UPDATE");
            //lblMsg.ForeColor = Color.Blue;
        }

        protected void imgReturn_Click(object sender, EventArgs e)
        {
            //string g_program_id = Request["program_id"].ToString();
            //int g_level = int.Parse(Request["level"].ToString());
            //IMClass.Common com = new IMClass.Common();
            //g_program_id = com.GetBackMenuGrp(g_program_id, g_level);
            //string strUrl = "~/Default.aspx?program_id=" + g_program_id + "&level=" + g_level.ToString();
            string strUrl = "Default2.aspx";
            Response.Redirect(strUrl);
        }

        protected void ddlPROCESS_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_list();
        }

        protected void btnPrev_Click(object sender, EventArgs e)
        {
            if (hdnNo.Value != "1")
            {
                DataTable dt = (DataTable)ViewState["detail"];
                int i = int.Parse(hdnNo.Value) - 1;
                hdnNo.Value = (i).ToString();
                lblNo.Text = hdnNo.Value + " of " + hdnMaxNo.Value;
                txtITEM_NO.Text = dt.Rows[i]["PART_NO"].ToString();
                txtLOT_NO.Text = dt.Rows[i]["LOT_NO"].ToString();
                txtRCV_QTY.Text = dt.Rows[i]["RECEIVE_QTY"].ToString();
                txtDIE_NO.Text = dt.Rows[i]["DIE_NO"].ToString();
                txtSHIFT_NO.Text = dt.Rows[i]["SHIFT"].ToString();
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            if (hdnNo.Value != hdnMaxNo.Value)
            {
                DataTable dt = (DataTable)ViewState["detail"];
                int i = int.Parse(hdnNo.Value);
                hdnNo.Value = (i + 1).ToString();
                lblNo.Text = hdnNo.Value + " of " + hdnMaxNo.Value;
                txtITEM_NO.Text = dt.Rows[i]["PART_NO"].ToString();
                txtLOT_NO.Text = dt.Rows[i]["LOT_NO"].ToString();
                txtRCV_QTY.Text = dt.Rows[i]["RECEIVE_QTY"].ToString();
                txtDIE_NO.Text = dt.Rows[i]["DIE_NO"].ToString();
                txtSHIFT_NO.Text = dt.Rows[i]["SHIFT"].ToString();
            }
        }
    }
}