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
    public partial class Default2 : System.Web.UI.Page
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
                Response.Redirect("~/Login2.aspx");
            }
        }

        protected void btnPEMS_Click(object sender, EventArgs e)
        {
            string strUrl = "HTMain.aspx";
            Response.Redirect(strUrl);
        }

        protected void btnMC_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnFE_Click(object sender, EventArgs e)
        {
            string strUrl = "FeHTMain.aspx";
            Response.Redirect(strUrl);
        }

        protected void btnAE_Click(object sender, EventArgs e)
        {
            string strUrl = "AeHTMain.aspx";
            Response.Redirect(strUrl);
        }

        protected void imgLogoff_Click(object sender, EventArgs e)
        {
            string strUrl = "Login2.aspx";
            Response.Redirect(strUrl);
        }
    }
}