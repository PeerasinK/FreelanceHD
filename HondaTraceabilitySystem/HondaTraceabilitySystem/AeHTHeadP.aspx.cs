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
using System.Reflection;

namespace HondaTraceabilitySystem
{
    public partial class AeHTHeadP : System.Web.UI.Page
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
            Transfer tran = new Transfer(g_user_id, g_lang);
            Message msg = new Message(g_user_id, g_lang);
            ComLibrary com = new ComLibrary();
            tran.item_no = txtITEM_NO.Text;
            tran.lot_no = "0";
            tran.act_qty = com.StringToDouble("1");
            tran.die_no = "0";
            tran.shift = txtSHIFT_NO.Text;
            //tran.Data_1 = "0";
            //tran.Data_2 = "0";
            //tran.Data_3 = "0";
            //tran.Data_4 = "0";
            //tran.Data_5 = "0";
            if (tran.FEReceiveHT() == ComConst.FAILED)
            {
                lblMsg.Text = tran.strErr;
                lblMsg.ForeColor = Color.Red;
                return;
            }
            lblMsg.Text = msg.GetMessage("NORMAL_UPDATE");
            lblMsg.ForeColor = Color.Blue;
        }

        protected void imgReturn_Click(object sender, EventArgs e)
        {
            //string g_program_id = Request["program_id"].ToString();
            //int g_level = int.Parse(Request["level"].ToString());
            //IMClass.Common com = new IMClass.Common();
            //g_program_id = com.GetBackMenuGrp(g_program_id, g_level);
            //string strUrl = "~/Default.aspx?program_id=" + g_program_id + "&level=" + g_level.ToString();
            string strUrl = "AeHTMain.aspx";
            Response.Redirect(strUrl);
        }

        protected void txtITEM_NO_TextChanged(object sender, EventArgs e)
        {
            // Convert 2D Barcode Data
            string inputtext = txtITEM_NO.Text;
            string[] Splits = inputtext.Split(',');
            txtITEM_NO.Text = Splits[0].ToString();
            //txtLOT_NO.Text = Splits[1].ToString();
            //txtRCV_QTY.Text = Splits[2].ToString();
            //txtDIE_NO.Text = Splits[3].ToString();
            txtSHIFT_NO.Text = Splits[4].ToString();
        }
    }
}