using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HondaTraceabilitySystem
{
    public partial class FeHTMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFERec_Click(object sender, EventArgs e)
        {
            string strUrl = "FeHTRec2.aspx";
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

        protected void btnFEIssue_Click(object sender, EventArgs e)
        {
            string strUrl = "FeHTIssue.aspx";
            Response.Redirect(strUrl);
        }

        protected void btnFESwap_Click(object sender, EventArgs e)
        {
            string strUrl = "FeHTSwap.aspx";
            Response.Redirect(strUrl);
        }

        protected void btnFEGsn_Click(object sender, EventArgs e)
        {
            string strUrl = "FeHTGsn.aspx";
            Response.Redirect(strUrl);
        }

        protected void btnFESwap2_Click(object sender, EventArgs e)
        {
            string strUrl = "FeHTSwap2.aspx";
            Response.Redirect(strUrl);
        }

        protected void btnFENg_Click(object sender, EventArgs e)
        {
            string strUrl = "FeHTNg.aspx";
            Response.Redirect(strUrl);
        }
    }
}