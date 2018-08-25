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
    public partial class FeHTNg : System.Web.UI.Page
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
            WIPJo jo = new WIPJo(g_user_id, g_lang);
            Message msg = new Message(g_user_id, g_lang);
            jo.demand_no = txtQR_Code.Text;
            jo.resource_cd = txtMachine.Text;
            jo.whs_cd = txtNG.Text;
            jo.ws_cd = txtShift.Text;
            jo.entry_date = DateTime.Now;
            if (ddlPROCESS.SelectedValue == "Crank Shaft")
            {
                if (jo.Mfg_JoUpd5() == ComConst.FAILED)
                {
                    lblMsg.Text = jo.strErr;
                    lblMsg.ForeColor = Color.Red;
                    return;
                }
            }
            else
            {
                if (jo.Mfg_JoUpd5A() == ComConst.FAILED)
                {
                    lblMsg.Text = jo.strErr;
                    lblMsg.ForeColor = Color.Red;
                    return;
                }
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
            string strUrl = "Default2.aspx";
            Response.Redirect(strUrl);
        }
    }
}