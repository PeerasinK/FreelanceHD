using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IMClass;
using System.Data;
using System.Drawing;

namespace HondaTraceabilitySystem
{
    public partial class _Default : Page
    {
        protected string g_user_id;
        protected int g_lang;
        protected string g_company_cd;
        protected string g_name;
        protected string g_menu_grp;
        protected string g_program_id;
        protected int g_level;

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie MyCookie;

            MyCookie = new HttpCookie("IMLastVisit");
            HttpCookieCollection MyCookieColl = Request.Cookies;
            MyCookie = MyCookieColl.Get("IMLastVisit");

            try
            {
                g_user_id = MyCookie.Values["USER_ID"];
                g_lang = int.Parse(MyCookie.Values["LANG"]);
                g_company_cd = MyCookie.Values["COMPANY_CD"];
                g_name = HttpUtility.UrlDecode(MyCookie.Values["NAME"]);

                g_menu_grp = MyCookie.Values["MENU_GRP0"];
                g_program_id = MyCookie.Values["MENU_GRP0"];
                g_level = int.Parse(MyCookie.Values["LEVEL"]);
            }
            catch
            {
                //Response.Redirect("~/NotLoginErr.htm");
                //Response.Redirect("~/Common/Login/frmLogin.aspx");
                Response.Redirect("~/Login.aspx");
            }
            //g_user_id = "test";
            //g_lang = 2;
            //g_name = "TEST USER";
            //g_program_id = "1";
            //g_level = 1;

            //Urlより、ﾌﾟﾛｸﾞﾗﾑID,Lvlの取得
            //try
            //{
            //    if (Request["program_id"].ToString() != "")
            //    {
            //        g_program_id = Request["program_id"].ToString();
            //    }
            //    if (Request["level"].ToString() != "")
            //    {
            //        g_level = int.Parse(Request["level"].ToString());
            //    }
            //}
            //catch
            //{

            //}

            if (!IsPostBack)
            {
                // 画面編集
                Init_Label();
            }
        }

        //
        // 初期画面ラベル編集
        //
        protected void Init_Label()
        {
            //Display Menu based on User Department and Management Level
            if (g_program_id == "1")
            {
                MasterMenu.Visible = true;
                PEMSAdminMenu.Visible = true;
                MCMenu.Visible = true;
                FEMenu.Visible = true;
                AEMenu.Visible = true;
            }
            if (g_program_id == "45492")
            {
                if (g_level == 1)
                {
                }
                if (g_level == 2)
                {   
                }
                MCMenu.Visible = true;
            }
            
        }

        protected void imgLogoff_Click(object sender, EventArgs e)
        {
            string strUrl = "Login.aspx";
            Response.Redirect(strUrl);
        }
    }
}