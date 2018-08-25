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
using System.Globalization;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace HondaTraceabilitySystem
{
    public partial class FeStkProdRpt : System.Web.UI.Page
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
                Response.Redirect("~/Login.aspx");
            }
            //g_user_id = "test";
            //g_lang = 2;
            //g_name = "TEST USER";
            //Page.Form.DefaultButton = cmdDisp.UniqueID;
            if (!IsPostBack)
            {
                //// 画面編集
                txtDate.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");
                Init_Label();
                Init_Proc();
            }
            else
            {
                Edit_Screen();
            }
            lblMsg.Text = "";
            //Auth_Proc();
        }

        //
        // 初期画面ラベル編集
        //
        protected void Init_Label()
        {
            lblUserName.Text = g_name;

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

        #region ：画面権限編集
        /// <summary>
        /// 画面権限編集 
        /// </summary>
        protected void Auth_Proc()
        {
        }

        #endregion

        protected void cmdDisp_Click(object sender, EventArgs e)
        {
        }

        protected void Edit_Screen()
        {
        }

        protected void Edit_Grid()
        {
        }

        protected void cmdCancel_Click(object sender, EventArgs e)
        {
        }

        protected void cmdPnt_Click(object sender, EventArgs e)
        {
            //ComLibrary com = new ComLibrary();
            //Message msg = new Message(g_user_id, g_lang);
            //Inv inv = new Inv(g_user_id, g_lang);
            //DataSet ds = new DataSet();

            //inv.sch_id = ddlPROCESS.SelectedValue;
            //inv.entry_date = DateTime.ParseExact(txtDate.Text, "dd-MM-yyyy", new CultureInfo("en-us"));
            //ds = inv.GetRecvDisbList5();

            //ReportClass Rpt = null;

            ////Rpt = new HondaTraceabilitySystem.Common.Report.FeOnline();
            //string ReportName = "StkProdRpt";

            //try
            //{
            //    //Rpt.Subreports["SubReport"].SetDataSource(prtDtTotal);
            //    Rpt.SetDataSource(ds.Tables[0]);
            //    //Rpt.SetParameterValue("H_TITLE", "HATC-M P-EGD   Production Sheet Control");

            //    PdfRtfWordFormatOptions pdfFormatOpts = new PdfRtfWordFormatOptions();
            //    DiskFileDestinationOptions diskOpts = new DiskFileDestinationOptions();

            //    // exportOpts;
            //    ExportOptions exportOpts = Rpt.ExportOptions;
            //    exportOpts.ExportDestinationType = ExportDestinationType.DiskFile;
            //    exportOpts.ExportFormatType = ExportFormatType.PortableDocFormat;
            //    exportOpts.FormatOptions = pdfFormatOpts;
            //    string tmpFilenm = ReportName + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";

            //    diskOpts.DiskFileName = Server.MapPath(WebConfigurationManager.ConnectionStrings["ReportOutDir"].ConnectionString + tmpFilenm);

            //    exportOpts.DestinationOptions = diskOpts;
            //    //print
            //    Rpt.Export();
            //    Type cstype = this.GetType();
            //    this.Page.ClientScript.RegisterClientScriptBlock(cstype, "a", @"<script>window.open('" + WebConfigurationManager.ConnectionStrings["ReportOutDir"].ConnectionString + tmpFilenm + "', '" + ReportName + "', 'status,resizable=yes');</script>");
            //}
            //catch (Exception ex)
            //{
            //    string strErr = ex.ToString();
            //    lblMsg.Text = ex.ToString();
            //    return;
            //}
            //lblMsg.Text = msg.GetMessage("NORMAL_PRINT");
            //lblMsg.ForeColor = Color.Blue;

        }

        protected void gdvDetail_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void gdvDetail_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }

        protected void imgReturn_Click(object sender, EventArgs e)
        {
            //string g_program_id = Request["program_id"].ToString();
            //int g_level = int.Parse(Request["level"].ToString());
            //IMClass.Common com = new IMClass.Common();
            //g_program_id = com.GetBackMenuGrp(g_program_id, g_level);
            //string strUrl = "~/Default.aspx?program_id=" + g_program_id + "&level=" + g_level.ToString();
            string strUrl = "Default.aspx";
            Response.Redirect(strUrl);
        }

        protected void ddlPROCESS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}