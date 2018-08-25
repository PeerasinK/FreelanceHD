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
using System.IO;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
namespace HondaTraceabilitySystem
{
    public partial class FGDelPlan : System.Web.UI.Page
    {
        protected string g_user_id;
        protected int g_lang;
        protected string g_company_cd;
        protected string g_name;
        public static System.Data.DataTable dt = null;
        public static System.Data.DataTable dt2 = null;
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
                Edit_Screen();
            }
            lblMsg.Text = "";
        }

        //
        // 初期画面ラベル編集
        //
        protected void Init_Label()
        {
            lblUserName.Text = g_name;
            FormControlDisable();
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
            System.Data.DataTable dt = new System.Data.DataTable();

            dt.Columns.Add(new DataColumn("DEPT_NO"));
            dt.Columns.Add(new DataColumn("DEPT_NAME"));

            dt.Rows.Add("MC CKD", "MC CKD");
            dt.Rows.Add("FE CKD", "FE CKD");

            ddlTYPE.DataValueField = "DEPT_NO";
            ddlTYPE.DataTextField = "DEPT_NAME";
            ddlTYPE.DataSource = dt;
            ddlTYPE.DataBind();
        }

        /// <summary>
        /// 禁止使用[执行]相关按钮
        /// </summary>
        private void FormControlDisable()
        {
            cmdDisp.Enabled = true;
            cmdUpdate.Enabled = false;
        }

        /// <summary>
        /// 允许使用[执行]相关按钮
        /// </summary>
        private void FormControlEnable()
        {
            cmdDisp.Enabled = true;
            cmdUpdate.Enabled = true;
        }

        protected void cmdDisp_Click(object sender, EventArgs e)
        {
            Message msg = new Message(g_user_id, g_lang);
            ComLibrary com = new ComLibrary();
            string filePath = "";

            Boolean fileOK = false;

            if (FileUpload1.HasFile)
            {
                try
                {
                    filePath = Server.MapPath("~/Excel/" + FileUpload1.FileName);

                    FileUpload1.SaveAs(filePath);
                    fileOK = true;
                }
                catch (Exception ex)
                {
                    //lblMsg.Text = msg.GetMessage("UPLOAD_FAILED");
                    lblMsg.Text = lblMsg.Text + ex.ToString();
                }
            }

            if (!fileOK)
            {
                lblMsg.Text = msg.GetMessage("UPLOAD_FAILED");
                return;
            }
            dt = null;
            dt2 = null;
            EditGridView(out dt);
            EditGridView(out dt2);

            switch (ddlTYPE.Text.ToString())
            {
                case "MC CKD":
                    MCCKD_Import(filePath);
                    break;
                case "FE CKD":
                    FECKD_Import(filePath);
                    break;
            }
        }

        protected void EditGridView(out System.Data.DataTable dt)
        {
            System.Data.DataTable dt1 = new System.Data.DataTable();
            dt1.Columns.Add(new DataColumn("Types"));
            dt1.Columns.Add(new DataColumn("Part_No"));
            dt1.Columns.Add(new DataColumn("Part_Name"));
            dt1.Columns.Add(new DataColumn("1")); dt1.Columns.Add(new DataColumn("2")); dt1.Columns.Add(new DataColumn("3"));
            dt1.Columns.Add(new DataColumn("4")); dt1.Columns.Add(new DataColumn("5")); dt1.Columns.Add(new DataColumn("6"));
            dt1.Columns.Add(new DataColumn("7")); dt1.Columns.Add(new DataColumn("8")); dt1.Columns.Add(new DataColumn("9"));
            dt1.Columns.Add(new DataColumn("10")); dt1.Columns.Add(new DataColumn("11")); dt1.Columns.Add(new DataColumn("12"));
            dt1.Columns.Add(new DataColumn("13")); dt1.Columns.Add(new DataColumn("14")); dt1.Columns.Add(new DataColumn("15"));
            dt1.Columns.Add(new DataColumn("16")); dt1.Columns.Add(new DataColumn("17")); dt1.Columns.Add(new DataColumn("18"));
            dt1.Columns.Add(new DataColumn("19")); dt1.Columns.Add(new DataColumn("20")); dt1.Columns.Add(new DataColumn("21"));
            dt1.Columns.Add(new DataColumn("22")); dt1.Columns.Add(new DataColumn("23")); dt1.Columns.Add(new DataColumn("24"));
            dt1.Columns.Add(new DataColumn("25")); dt1.Columns.Add(new DataColumn("26")); dt1.Columns.Add(new DataColumn("27"));
            dt1.Columns.Add(new DataColumn("28")); dt1.Columns.Add(new DataColumn("29")); dt1.Columns.Add(new DataColumn("30"));
            dt1.Columns.Add(new DataColumn("31"));
            dt1.Columns.Add(new DataColumn("P1")); dt1.Columns.Add(new DataColumn("P2")); dt1.Columns.Add(new DataColumn("P3"));
            dt1.Columns.Add(new DataColumn("P4")); dt1.Columns.Add(new DataColumn("P5")); dt1.Columns.Add(new DataColumn("P6"));
            dt1.Columns.Add(new DataColumn("P7")); dt1.Columns.Add(new DataColumn("P8")); dt1.Columns.Add(new DataColumn("P9"));
            dt1.Columns.Add(new DataColumn("P10")); dt1.Columns.Add(new DataColumn("P11")); dt1.Columns.Add(new DataColumn("P12"));
            dt1.Columns.Add(new DataColumn("P13")); dt1.Columns.Add(new DataColumn("P14")); dt1.Columns.Add(new DataColumn("P15"));
            dt1.Columns.Add(new DataColumn("P16")); dt1.Columns.Add(new DataColumn("P17")); dt1.Columns.Add(new DataColumn("P18"));
            dt1.Columns.Add(new DataColumn("P19")); dt1.Columns.Add(new DataColumn("P20")); dt1.Columns.Add(new DataColumn("P21"));
            dt1.Columns.Add(new DataColumn("P22")); dt1.Columns.Add(new DataColumn("P23")); dt1.Columns.Add(new DataColumn("P24"));
            dt1.Columns.Add(new DataColumn("P25")); dt1.Columns.Add(new DataColumn("P26")); dt1.Columns.Add(new DataColumn("P27"));
            dt1.Columns.Add(new DataColumn("P28")); dt1.Columns.Add(new DataColumn("P29")); dt1.Columns.Add(new DataColumn("P30"));
            dt1.Columns.Add(new DataColumn("P31"));
            dt = dt1;
        }

        private void MCCKD_Import(string filePath)
        {
        }

        private void FECKD_Import(string filePath)
        {
        }

        protected void Edit_Screen()
        {
            gdvDetail.PageIndex = 0;
            EditGridView();
        }

        protected void EditGridView()
        {
            System.Data.DataTable dt = (System.Data.DataTable)ViewState["gdvDetail"];
            gdvDetail.DataSource = dt;
            gdvDetail.DataBind();

        }

        private void KillProcess(string processName)
        {
            System.Diagnostics.Process myproc = new System.Diagnostics.Process();
            //得到所有打开的进程
            try
            {
                //processName = "EXCEL";
                foreach (System.Diagnostics.Process thisproc in System.Diagnostics.Process.GetProcessesByName(processName))
                {
                    if (!thisproc.CloseMainWindow())
                    {
                        thisproc.Kill();
                    }
                }
            }
            catch (Exception Excel)
            {
                lblMsg.Text += Excel.Message;
            }
        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {

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
    }
}