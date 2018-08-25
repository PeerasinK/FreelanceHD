using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HondaTraceabilitySystem
{
    public partial class SiteMaster : MasterPage
    {
        protected string g_user_id;
        protected int g_lang;
        protected string g_company_cd;
        protected string g_name;
        protected string g_menu_grp;
        //protected string g_program_id;
        protected int g_level;

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

                g_menu_grp = MyCookie.Values["MENU_GRP0"];
                //g_program_id = MyCookie.Values["MENU_GRP0"];
                g_level = int.Parse(MyCookie.Values["LEVEL"]);
            }
            catch
            {
                //Response.Redirect("~/NotLoginErr.htm");
                Response.Redirect("~/Login.aspx");
            }
            //g_user_id = "test";
            //g_name = "TEST USER";
            //g_menu_grp = "1";
            //g_level = 1;
            if (!IsPostBack)
            {
                //// 画面編集

                //imgReturn.Attributes["onmouseover"] = "MM_swapImage('" + imgReturn.ClientID + "','','../../Contents/Image/BackGround/btn-menu3.jpg',1);";
                //imgReturn.Attributes["onmouseout"] = "MM_swapImgRestore();";

                lblUserName.Text = g_name;
                //lblComp.Text = g_company_cd;

                // Display Menu based on User Department
                if (g_menu_grp == "1")
                {
                }
                if (g_menu_grp == "45492")
                {
                    if (g_level == 1)
                    {
                    }
                    if (g_level == 2)
                    {
                    }
                    Menu00.Visible = false;
                    Menu10.Visible = false;
                    Menu40.Visible = false;
                    Menu60.Visible = false;
                }
            }
        }

        protected void imgReturn_Click(object sender, EventArgs e)
        {
            //return Menu Add by zhao 20090508
            //string g_program_id = Request["program_id"].ToString();
            //int g_level = int.Parse(Request["level"].ToString());
            //IMClass.Common com = new IMClass.Common();
            //g_program_id = com.GetBackMenuGrp(g_program_id, g_level);
            //string strUrl = "/IM/Default.aspx?program_id=" + g_program_id + "&level=" + g_level.ToString();
            string strUrl = "Default.aspx";
            Response.Redirect(strUrl);
        }

        protected void btnUser_Click(object sender, EventArgs e)
        {
            string strUrl = "MstUserMnt.aspx?USERID=" + g_user_id;
            Response.Redirect(strUrl);
        }
    }
}