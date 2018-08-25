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
    public partial class PCPurRec : System.Web.UI.Page
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
            }
            lblMsg.Text = "";
        }

        //
        // 初期画面ラベル編集
        //
        protected void Init_Label()
        {

        }

        protected void cmdSave_Click(object sender, EventArgs e)
        {
            ComDB db = new ComDB();
            ComLibrary comlb = new ComLibrary();
            Message msg = new Message(g_user_id, g_lang);
            ComLibrary com = new ComLibrary();
            DataSet ds = new DataSet();
            Rcv rc1 = new Rcv(g_user_id, g_lang);
            int rtn = 0;

            if (txtITEM_NO.Text == "")
            {
                lblMsg.Text = msg.GetMessage("ITEM_NOT_EXIST_ERR");
                lblMsg.ForeColor = Color.Red;
                return;
            }
            ds = rc1.GetPartNo(txtITEM_NO.Text);
            if (ds==null || ds.Tables[0].Rows.Count==0)
            {
                lblMsg.Text = msg.GetMessage("ITEM_NOT_EXIST_ERR");
                lblMsg.ForeColor = Color.Red;
                return;
            }
            if (!comlb.IsNumeric(txtRCV_QTY.Text.ToString()))
            {
                lblMsg.Text = "Receive Qty Error";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            
            rc1.part_no = txtITEM_NO.Text;
            rc1.receive_qty = com.StringToInt(txtRCV_QTY.Text);
            rc1.optmethod = "PC";
            rtn = rc1.Insert();
            if (rtn == ComConst.FAILED)
            {
                lblMsg.Text = rc1.strErr;
                lblMsg.ForeColor = Color.Red;
                return;
            }
            lblMsg.Text = msg.GetMessage("NORMAL_UPDATE");
            lblMsg.ForeColor = Color.Blue;
            txtITEM_NO.Text = "";
            txtRCV_QTY.Text = "";
        }

    }
}