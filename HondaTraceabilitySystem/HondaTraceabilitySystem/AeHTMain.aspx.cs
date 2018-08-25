using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HondaTraceabilitySystem
{
    public partial class AeHTMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void btnFERec_Click(object sender, EventArgs e)
        {
            string strUrl = "HTPurRec.aspx";
            Response.Redirect(strUrl);
        }
        protected void btnAECRS_Click(object sender, EventArgs e)
        {
            string strUrl = "AeHTCrankShaftP.aspx";
            Response.Redirect(strUrl);
        }
        protected void btnAEHEA_Click(object sender, EventArgs e)
        {
            string strUrl = "AeHTHeadP.aspx";
            Response.Redirect(strUrl);
        }
        protected void btnAECRSS_Click(object sender, EventArgs e)
        {
            string strUrl = "AeHTCrankShaftSP.aspx";
            Response.Redirect(strUrl);
        }
        protected void btnAEHEAS_Click(object sender, EventArgs e)
        {
            string strUrl = "AeHTHeadSP.aspx";
            Response.Redirect(strUrl);
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