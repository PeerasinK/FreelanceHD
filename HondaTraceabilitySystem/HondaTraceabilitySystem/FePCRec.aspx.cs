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
    public partial class FePCRec : System.Web.UI.Page
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
            //g_user_id = "test";
            g_lang = 2;
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

            dt.Columns.Add(new DataColumn("PROCESS_NO"));
            dt.Columns.Add(new DataColumn("PROCESS_NAME"));

            dt.Rows.Add("Crank Shaft", "Crank Shaft");
            dt.Rows.Add("Conn Rod", "Conn Rod");

            ddlPROCESS.DataValueField = "PROCESS_NO";
            ddlPROCESS.DataTextField = "PROCESS_NAME";
            ddlPROCESS.DataSource = dt;
            ddlPROCESS.DataBind();
        }

        protected void txtITEM_NO_TextChanged(object sender, EventArgs e)
        {
            // Convert 2D Barcode Data
            //string inputtext = txtITEM_NO.Text;
            //string[] Splits = inputtext.Split(',');
            //txtITEM_NO.Text = Splits[0].ToString();
            //txtLOT_NO.Text = Splits[1].ToString();
            //txtRCV_QTY.Text = Splits[2].ToString();
            //txtDIE_NO.Text = Splits[3].ToString();
            //txtSHIFT_NO.Text = Splits[4].ToString();
        }

        protected void cmdSave_Click(object sender, EventArgs e)
        {
            Transfer tran = new Transfer(g_user_id, g_lang);
            Message msg = new Message(g_user_id, g_lang);
            ComLibrary com = new ComLibrary();
            tran.item_no = txtITEM_NO.Text;
            tran.lot_no = txtLOT_NO.Text;
            tran.act_qty = com.StringToDouble(txtRCV_QTY.Text);
            tran.die_no = txtDIE_NO.Text;
            tran.shift = txtSHIFT_NO.Text;
            if (ddlPROCESS.SelectedValue == "Crank Shaft")
            {
                if (tran.FEReceivePC() == ComConst.FAILED)
                {
                    lblMsg.Text = tran.strErr;
                    lblMsg.ForeColor = Color.Red;
                    return;
                }
            }
            if (ddlPROCESS.SelectedValue == "Conn Rod")
            {
                if (tran.FEReceivePCA() == ComConst.FAILED)
                {
                    lblMsg.Text = tran.strErr;
                    lblMsg.ForeColor = Color.Red;
                    return;
                }
            }
            lblMsg.Text = msg.GetMessage("NORMAL_UPDATE");
            lblMsg.ForeColor = Color.Blue;
            txtITEM_NO.Text = "";
            txtLOT_NO.Text = "";
            txtRCV_QTY.Text = "";
            txtDIE_NO.Text = "";
            txtSHIFT_NO.Text = "";
        }

        protected void ddlPROCESS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}