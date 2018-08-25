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
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace HondaTraceabilitySystem
{
    public partial class PickingList : System.Web.UI.Page
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
                Init_Label();
                Init_Proc();
            }
            else
            {
                FormControlDisable();
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
        /// 画面権限編集 
        /// </summary>
        protected void Auth_Proc()
        {
        }

        /// <summary>
        /// EDIT DROP DOWN LIST
        /// </summary>
        protected void ddl_edit()
        {
            MCImport mc1 = new MCImport(g_user_id, g_lang);
            System.Data.DataTable dt = new System.Data.DataTable();
            DataSet ds = new DataSet();

            dt.Columns.Add(new DataColumn("DEPT_NO"));
            dt.Columns.Add(new DataColumn("DEPT_NAME"));

            dt.Rows.Add("MC", "MC");
            //dt.Rows.Add("MC CKD", "MC CKD");
            //dt.Rows.Add("FE", "FE");
            //dt.Rows.Add("FE CKD", "FE CKD");
            //dt.Rows.Add("KD", "KD");
            //dt.Rows.Add("Special Part", "Special Part");

            ddlTYPE.DataValueField = "DEPT_NO";
            ddlTYPE.DataTextField = "DEPT_NAME";
            ddlTYPE.DataSource = dt;
            ddlTYPE.DataBind();

            ds = mc1.GetPickingOrder();
            ddlFILE.DataTextField = "HEAD_NO";
            ddlFILE.DataValueField = "HEAD_NO";

            ddlFILE.DataSource = ds.Tables[0];
            ddlFILE.DataBind();
            ddlFILE.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ddlFILE.Items.Add(ds.Tables[0].Rows[i]["HEAD_NO"].ToString());
            }
        }


        private void FormControlDisable()
        {
            cmdDisp.Enabled = true;
            cmdUpdate.Enabled = false;
        }
        private void FormControlEnable()
        {
            cmdDisp.Enabled = true;
            cmdUpdate.Enabled = true;
        }



        protected void cmdCancel_Click(object sender, EventArgs e)
        {
            ViewState["gdvDetail"] = null;
        }

        protected void gdvDetail_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            
        }

        protected void gdvDetail_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }
        
        protected void ddlTYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComLibrary com = new ComLibrary();
            DataSet ds = new DataSet();

            MCImport mc1 = new MCImport(g_user_id, g_lang);


            switch (ddlTYPE.Text.ToString())
            {
                case "MC":
                    ds = mc1.GetPickingOrder();
                    ddlFILE.DataTextField = "HEAD_NO";
                    ddlFILE.DataValueField = "HEAD_NO";

                    ddlFILE.DataSource = ds.Tables[0];
                    ddlFILE.DataBind();
                    ddlFILE.Items.Clear();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ddlFILE.Items.Add(ds.Tables[0].Rows[i]["HEAD_NO"].ToString());
                    }
                    break;


            }


        }

        protected void ddlFILE_SelectedIndexChanged(object sender, EventArgs e)
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
        protected void cmdDisp_Click(object sender, EventArgs e)
        {

        }
        protected void cmdUpdate_Click(object sender, EventArgs e)
        {


        }
        protected void cmdPnt_Click(object sender, EventArgs e)
        {
            MCImport mc1 = new MCImport(g_user_id, g_lang);
            Message msg = new Message(g_user_id, g_lang);
            DataSet dsList= new DataSet();
            //Crystal_Report.PickingListRpt pl = new Crystal_Report.PickingListRpt();
            dsList = mc1.GetPickingList();
            //pl.SetDataSource(dsList);

            ReportClass Rpt = null;

            //Rpt = new HondaTraceabilitySystem.Common.Report.FeOnline();
            Rpt = new HondaTraceabilitySystem.Crystal_Report.PickingListRpt();
            string ReportName = "PickingList";

            try
            {
                //Rpt.Subreports["SubReport"].SetDataSource(prtDtTotal);
                Rpt.SetDataSource(dsList.Tables[0]);
                //Rpt.SetParameterValue("H_TITLE", "INSPECTION SHEET(SEMICONDUCTOR");

                PdfRtfWordFormatOptions pdfFormatOpts = new PdfRtfWordFormatOptions();
                DiskFileDestinationOptions diskOpts = new DiskFileDestinationOptions();

                // exportOpts;
                ExportOptions exportOpts = Rpt.ExportOptions;
                exportOpts.ExportDestinationType = ExportDestinationType.DiskFile;
                exportOpts.ExportFormatType = ExportFormatType.PortableDocFormat;
                exportOpts.FormatOptions = pdfFormatOpts;
                string tmpFilenm = ReportName + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";

                diskOpts.DiskFileName = Server.MapPath(WebConfigurationManager.ConnectionStrings["ReportOutDir"].ConnectionString + tmpFilenm);

                exportOpts.DestinationOptions = diskOpts;
                //print
                Rpt.Export();
                Type cstype = this.GetType();
                this.Page.ClientScript.RegisterClientScriptBlock(cstype, "a", @"<script>window.open('" + WebConfigurationManager.ConnectionStrings["ReportOutDir"].ConnectionString + tmpFilenm + "', '" + ReportName + "', 'status,resizable=yes');</script>");
            }
            catch (Exception ex)
            {
                string strErr = ex.ToString();
                lblMsg.Text = ex.ToString();
                return;
            }
            lblMsg.Text = msg.GetMessage("NORMAL_PRINT");
            lblMsg.ForeColor = Color.Blue;

        }
    }
}