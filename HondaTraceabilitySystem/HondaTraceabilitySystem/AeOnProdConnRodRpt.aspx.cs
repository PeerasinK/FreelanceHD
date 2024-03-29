﻿using System;
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
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace HondaTraceabilitySystem
{
    public partial class AeOnProdConnRodRpt : System.Web.UI.Page
    {
        protected string g_user_id;
        protected int g_lang;
        protected string g_company_cd;
        protected string g_name;
        protected int form_load = 0;

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
                if (ViewState["gdvDetail"] != null)
                {
                    Edit_Grid();
                }
            }
            SaveGridData();
            lblMsg.Text = "";
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

        protected void cmdDisp_Click(object sender, EventArgs e)
        {
            gdvDetail.DataSource = null;
            gdvDetail.DataBind();
            ViewState["gdvDetail"] = null;

            Edit_Screen();
        }

        protected void Edit_Screen()
        {
            // Testing
            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("MODEL"));
            dt.Columns.Add(new DataColumn("Part_No"));

            DataRow dr = dt.NewRow();
            dr["MODEL"] = "NP4 1.6";
            dr["Part_No"] = "12207P8A-A001H1";

            dt.Rows.Add(dr);

            ViewState["gdvDetail"] = dt;
            Edit_Grid();
            // Actual Codes
            //ComLibrary com = new ComLibrary();
            //Message msg = new Message(g_user_id, g_lang);

            //chkALL_SEL.Checked = false;

            //// 製造指示情報を検索
            //WIPJo jo = new WIPJo(g_user_id, g_lang);
            //jo.process_cd = ddlPROCESS.Text;
            //jo.chkflag = chkSTART.Checked ? 1 : 0;  // 着手済含む　2015.09.25

            //DataSet ds = jo.Get_ONList();

            //if (ds == null)
            //{
            //    lblMsg.Text = jo.strErr;
            //    lblMsg.ForeColor = Color.Red;
            //    return;
            //}

            //if (ds.Tables[0].Rows.Count == 0)
            //{
            //    lblMsg.Text = msg.GetMessage("DATA_NOT_EXIST_ERR");
            //    lblMsg.ForeColor = Color.Red;
            //    return;
            //}
            //else
            //{
            //    // 画面編集

            //    gdvDetail.PageIndex = 0;
            //    ViewState["gdvDetail"] = ds.Tables[0];
            //    Edit_grid();

            //}
        }

        protected void SaveGridData()
        {
            if (gdvDetail.Rows.Count != 0)
            {
                ComLibrary com = new ComLibrary();
                DataTable dt = (DataTable)(ViewState["gdvDetail"]);
                if (dt.Columns["SELECT"] == null)
                {
                    dt.Columns.Add("SELECT");
                }
                int j;
                for (int i = 0; i < gdvDetail.Rows.Count; i++)
                {
                    j = gdvDetail.Rows[i].DataItemIndex;
                    dt.Rows[j]["SELECT"] = com.BoolToInt(((CheckBox)gdvDetail.Rows[i].FindControl("chkSEL")).Checked);
                }
                ViewState["gdvDetail"] = dt;
            }
        }

        protected void Edit_Grid()
        {
            int j;
            ComLibrary com = new ComLibrary();
            DataTable dt = (DataTable)ViewState["gdvDetail"];
            if (dt.Columns["SELECT"] == null)
            {
                dt.Columns.Add("SELECT");
            }
            gdvDetail.DataSource = dt;
            gdvDetail.DataBind();
            for (int i = 0; i < gdvDetail.Rows.Count; i++)
            {
                j = gdvDetail.Rows[i].DataItemIndex;
                if (dt.Rows[j]["SELECT"].ToString() != "")
                    ((CheckBox)gdvDetail.Rows[i].FindControl("chkSEL")).Checked = com.IntToBool(com.StringToInt(dt.Rows[j]["SELECT"].ToString()));
            }
        }

        protected void cmdPrint_Click(object sender, EventArgs e)
        {
            //
            // 製造指示表リスト発行
            //
            ComLibrary com = new ComLibrary();
            Message msg = new Message(g_user_id, g_lang);
            MfgBom mbom = new MfgBom(g_user_id, g_lang);

            DataTable dt = (DataTable)(ViewState["gdvDetail"]);
            if (dt == null)
            {
                return;
            }
            bool print_flag = false;
            //int seqno = 0;
            //Print Data
            DataTable prtDt = new DataTable();
            //SubReport Data
            //DataTable prtDtTotal = new DataTable();

            // 対象の行を探す
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (com.IntToBool(com.StringToInt(dt.Rows[i]["SELECT"].ToString())))
                {
                    //印刷マーク
                    print_flag = true;
                    //seqno++;

                    // Testing    
                    prtDt.Columns.Add(new DataColumn("FE_CRANK_ONLINE_NO"));
                    prtDt.Columns.Add(new DataColumn("PRODUCTION_DATE"));
                    prtDt.Columns.Add(new DataColumn("SHIFT"));
                    prtDt.Columns.Add(new DataColumn("MODEL"));
                    prtDt.Columns.Add(new DataColumn("LOTNO_ZOZAI"));
                    prtDt.Columns.Add(new DataColumn("DIE_NO"));
                    prtDt.Columns.Add(new DataColumn("ONLINE_DATE"));
                    prtDt.Columns.Add(new DataColumn("ONLINE_STAMPING"));
                    prtDt.Columns.Add(new DataColumn("REMARK"));

                    DataRow dr = prtDt.NewRow();
                    dr["FE_CRANK_ONLINE_NO"] = "CRON-20180101-0001";
                    dr["PRODUCTION_DATE"] = "2018-04-23 00:00:00.000";
                    dr["SHIFT"] = "X";
                    dr["MODEL"] = "55A";
                    dr["LOTNO_ZOZAI"] = "P50203N7";
                    dr["DIE_NO"] = "99";
                    dr["ONLINE_DATE"] = "100";
                    dr["ONLINE_STAMPING"] = "H-0746";
                    dr["REMARK"] = "";

                    prtDt.Rows.Add(dr);
                    // Actual Codes
                    // データ検索
                    //WIPJo jo = new WIPJo(g_user_id, g_lang);
                    //jo.job_order_no = dt.Rows[i]["Online_No"].ToString();
                    //jo.item_no = dt.Rows[i]["Part_No"].ToString();
                    //DataSet ds = jo.Get_OnRptDetail();
                    //if (ds == null)
                    //{
                    //    lblMsg.Text = jo.strErr;
                    //    lblMsg.ForeColor = Color.Red;
                    //    return;
                    //}
                    //prtDt = ds.Tables[0];
                }
            }
            if (print_flag == false)
            {
                lblMsg.Text = msg.GetMessage("PRINT_DATA_NOT_EXIST_ERR");
                lblMsg.ForeColor = Color.Red;
                return;
            }

            ReportClass Rpt = null;
            Rpt = new HondaTraceabilitySystem.Common.Report.FeOnline();
            string ReportName = "MfgJOList";

            try
            {
                //Rpt.Subreports["SubReport"].SetDataSource(prtDtTotal);
                Rpt.SetDataSource(prtDt);
                Rpt.SetParameterValue("H_TITLE", "INSPECTION SHEET(SEMICONDUCTOR");

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

        protected void ChangeColor(int i, bool Flag)
        {
            int j;
            if (gdvDetail.PageIndex != i / gdvDetail.PageSize)
            {
                gdvDetail.PageIndex = (i / gdvDetail.PageSize);
                Edit_Grid();
            }
            j = i - ((gdvDetail.PageIndex) * gdvDetail.PageSize);
            if (Flag)
            {
                gdvDetail.Rows[j].BackColor = Color.Red;
            }
            else
            {
                gdvDetail.Rows[j].BackColor = Color.Transparent;
            }
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

        protected void gdvDetail_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdvDetail.PageIndex = e.NewPageIndex;
            if (ViewState["gdvDetail"] != null)
            {
                Edit_Grid();
            }
        }

        protected void gdvDetail_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }

        protected void chkALL_SEL_CheckedChanged(object sender, EventArgs e)
        {
            //if (ViewState["gdvDetail"] != null)
            //{
            //    DataTable dt = (DataTable)ViewState["gdvDetail"];
            //    string chk;
            //    if (chkALL_SEL.Checked)
            //    {
            //        chk = "1";
            //    }
            //    else
            //    {
            //        chk = "0";
            //    }
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        dt.Rows[i]["SELECT"] = chk;
            //    }
            //    for (int i = 0; i < gdvDetail.Rows.Count; i++)
            //    {
            //        ((CheckBox)gdvDetail.Rows[i].FindControl("chkSEL")).Checked = chkALL_SEL.Checked;
            //    }
            //}
        }

        protected void ddlPROCESS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}