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
    public partial class ImpDelPlan : System.Web.UI.Page
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
        protected void Init_Proc()
        {
            ddl_edit();
        }
        protected void ddl_edit()
        {
            System.Data.DataTable dt = new System.Data.DataTable();

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
                case "MC":
                    MC_Import(filePath);
                    break;
            }
        }
        protected void EditGridView(out System.Data.DataTable dt)
        {
            System.Data.DataTable dt1 = new System.Data.DataTable();
            dt1.Columns.Add(new DataColumn("Types"));
            dt1.Columns.Add(new DataColumn("Plan_Date"));
            dt1.Columns.Add(new DataColumn("Vendor"));
            dt1.Columns.Add(new DataColumn("Dest"));
            dt1.Columns.Add(new DataColumn("Model"));
            dt1.Columns.Add(new DataColumn("Part_No"));
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
            dt1.Columns.Add(new DataColumn("B1")); dt1.Columns.Add(new DataColumn("B2")); dt1.Columns.Add(new DataColumn("B3"));
            dt1.Columns.Add(new DataColumn("B4")); dt1.Columns.Add(new DataColumn("B5")); dt1.Columns.Add(new DataColumn("B6"));
            dt1.Columns.Add(new DataColumn("B7")); dt1.Columns.Add(new DataColumn("B8")); dt1.Columns.Add(new DataColumn("B9"));
            dt1.Columns.Add(new DataColumn("B10")); dt1.Columns.Add(new DataColumn("B11")); dt1.Columns.Add(new DataColumn("B12"));
            dt1.Columns.Add(new DataColumn("B13")); dt1.Columns.Add(new DataColumn("B14")); dt1.Columns.Add(new DataColumn("B15"));
            dt1.Columns.Add(new DataColumn("B16")); dt1.Columns.Add(new DataColumn("B17")); dt1.Columns.Add(new DataColumn("B18"));
            dt1.Columns.Add(new DataColumn("B19")); dt1.Columns.Add(new DataColumn("B20")); dt1.Columns.Add(new DataColumn("B21"));
            dt1.Columns.Add(new DataColumn("B22")); dt1.Columns.Add(new DataColumn("B23")); dt1.Columns.Add(new DataColumn("B24"));
            dt1.Columns.Add(new DataColumn("B25")); dt1.Columns.Add(new DataColumn("B26")); dt1.Columns.Add(new DataColumn("B27"));
            dt1.Columns.Add(new DataColumn("B28")); dt1.Columns.Add(new DataColumn("B29")); dt1.Columns.Add(new DataColumn("B30"));
            dt1.Columns.Add(new DataColumn("B31"));
            dt1.Columns.Add(new DataColumn("H1")); dt1.Columns.Add(new DataColumn("H2")); dt1.Columns.Add(new DataColumn("H3"));
            dt1.Columns.Add(new DataColumn("H4")); dt1.Columns.Add(new DataColumn("H5")); dt1.Columns.Add(new DataColumn("H6"));
            dt1.Columns.Add(new DataColumn("H7")); dt1.Columns.Add(new DataColumn("H8")); dt1.Columns.Add(new DataColumn("H9"));
            dt1.Columns.Add(new DataColumn("H10")); dt1.Columns.Add(new DataColumn("H11")); dt1.Columns.Add(new DataColumn("H12"));
            dt1.Columns.Add(new DataColumn("H13")); dt1.Columns.Add(new DataColumn("H14")); dt1.Columns.Add(new DataColumn("H15"));
            dt1.Columns.Add(new DataColumn("H16")); dt1.Columns.Add(new DataColumn("H17")); dt1.Columns.Add(new DataColumn("H18"));
            dt1.Columns.Add(new DataColumn("H19")); dt1.Columns.Add(new DataColumn("H20")); dt1.Columns.Add(new DataColumn("H21"));
            dt1.Columns.Add(new DataColumn("H22")); dt1.Columns.Add(new DataColumn("H23")); dt1.Columns.Add(new DataColumn("H24"));
            dt1.Columns.Add(new DataColumn("H25")); dt1.Columns.Add(new DataColumn("H26")); dt1.Columns.Add(new DataColumn("H27"));
            dt1.Columns.Add(new DataColumn("H28")); dt1.Columns.Add(new DataColumn("H29")); dt1.Columns.Add(new DataColumn("H30"));
            dt1.Columns.Add(new DataColumn("H31"));
            dt = dt1;
        }
        private void MC_Import(string filePath)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Open(filePath, Type.Missing, false, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            Excel._Worksheet worksheet = workbook.Sheets[1];
            Excel.Range usedRange = worksheet.UsedRange;
            //System.Data.DataTable dt = new System.Data.DataTable();
            //EditGridView(out dt);

            int MCBLOCKRows = 12;
            int MCHEADRows = 24;
            //int MCCKDColumn = 0;
            try
            { 
            string Types = "MC";
            string Plan_Date = Convert.ToString((usedRange.Cells[2, 18] as Excel.Range).Value);

            var Vendor = Convert.ToString((usedRange.Cells[11, 1] as Excel.Range).Value);
            var Dest = Convert.ToString((usedRange.Cells[11, 2] as Excel.Range).Value);
            for (int i = MCBLOCKRows; i < MCBLOCKRows + 8; i += 2)
            {
                if ((usedRange.Cells[i, 4] as Range).Value != null)
                {
                    var Model = Convert.ToString((usedRange.Cells[i, 4] as Excel.Range).Value);
                    var Part_No = Convert.ToString((usedRange.Cells[i, 8] as Excel.Range).Value);
                    var C1 = Convert.ToString((usedRange.Cells[i, 12] as Excel.Range).Value); var C2 = Convert.ToString((usedRange.Cells[i, 13] as Excel.Range).Value);
                    var C3 = Convert.ToString((usedRange.Cells[i, 14] as Excel.Range).Value); var C4 = Convert.ToString((usedRange.Cells[i, 15] as Excel.Range).Value);
                    var C5 = Convert.ToString((usedRange.Cells[i, 16] as Excel.Range).Value); var C6 = Convert.ToString((usedRange.Cells[i, 17] as Excel.Range).Value);
                    var C7 = Convert.ToString((usedRange.Cells[i, 18] as Excel.Range).Value); var C8 = Convert.ToString((usedRange.Cells[i, 19] as Excel.Range).Value);
                    var C9 = Convert.ToString((usedRange.Cells[i, 20] as Excel.Range).Value); var C10 = Convert.ToString((usedRange.Cells[i, 21] as Excel.Range).Value);
                    var C11 = Convert.ToString((usedRange.Cells[i, 22] as Excel.Range).Value); var C12 = Convert.ToString((usedRange.Cells[i, 23] as Excel.Range).Value);
                    var C13 = Convert.ToString((usedRange.Cells[i, 24] as Excel.Range).Value); var C14 = Convert.ToString((usedRange.Cells[i, 25] as Excel.Range).Value);
                    var C15 = Convert.ToString((usedRange.Cells[i, 26] as Excel.Range).Value); var C16 = Convert.ToString((usedRange.Cells[i, 27] as Excel.Range).Value);
                    var C17 = Convert.ToString((usedRange.Cells[i, 28] as Excel.Range).Value); var C18 = Convert.ToString((usedRange.Cells[i, 29] as Excel.Range).Value);
                    var C19 = Convert.ToString((usedRange.Cells[i, 30] as Excel.Range).Value); var C20 = Convert.ToString((usedRange.Cells[i, 31] as Excel.Range).Value);
                    var C21 = Convert.ToString((usedRange.Cells[i, 32] as Excel.Range).Value); var C22 = Convert.ToString((usedRange.Cells[i, 33] as Excel.Range).Value);
                    var C23 = Convert.ToString((usedRange.Cells[i, 34] as Excel.Range).Value); var C24 = Convert.ToString((usedRange.Cells[i, 35] as Excel.Range).Value);
                    var C25 = Convert.ToString((usedRange.Cells[i, 36] as Excel.Range).Value); var C26 = Convert.ToString((usedRange.Cells[i, 37] as Excel.Range).Value);
                    var C27 = Convert.ToString((usedRange.Cells[i, 38] as Excel.Range).Value); var C28 = Convert.ToString((usedRange.Cells[i, 39] as Excel.Range).Value);
                    var C29 = Convert.ToString((usedRange.Cells[i, 40] as Excel.Range).Value); var C30 = Convert.ToString((usedRange.Cells[i, 41] as Excel.Range).Value);
                    var C31 = Convert.ToString((usedRange.Cells[i, 42] as Excel.Range).Value);

                    var P1 = Convert.ToString((usedRange.Cells[i + 1, 12] as Excel.Range).Value); var P2 = Convert.ToString((usedRange.Cells[i + 1, 13] as Excel.Range).Value);
                    var P3 = Convert.ToString((usedRange.Cells[i + 1, 14] as Excel.Range).Value); var P4 = Convert.ToString((usedRange.Cells[i + 1, 15] as Excel.Range).Value);
                    var P5 = Convert.ToString((usedRange.Cells[i + 1, 16] as Excel.Range).Value); var P6 = Convert.ToString((usedRange.Cells[i + 1, 17] as Excel.Range).Value);
                    var P7 = Convert.ToString((usedRange.Cells[i + 1, 18] as Excel.Range).Value); var P8 = Convert.ToString((usedRange.Cells[i + 1, 19] as Excel.Range).Value);
                    var P9 = Convert.ToString((usedRange.Cells[i + 1, 20] as Excel.Range).Value); var P10 = Convert.ToString((usedRange.Cells[i + 1, 21] as Excel.Range).Value);
                    var P11 = Convert.ToString((usedRange.Cells[i + 1, 22] as Excel.Range).Value); var P12 = Convert.ToString((usedRange.Cells[i + 1, 23] as Excel.Range).Value);
                    var P13 = Convert.ToString((usedRange.Cells[i + 1, 24] as Excel.Range).Value); var P14 = Convert.ToString((usedRange.Cells[i + 1, 25] as Excel.Range).Value);
                    var P15 = Convert.ToString((usedRange.Cells[i + 1, 26] as Excel.Range).Value); var P16 = Convert.ToString((usedRange.Cells[i + 1, 27] as Excel.Range).Value);
                    var P17 = Convert.ToString((usedRange.Cells[i + 1, 28] as Excel.Range).Value); var P18 = Convert.ToString((usedRange.Cells[i + 1, 29] as Excel.Range).Value);
                    var P19 = Convert.ToString((usedRange.Cells[i + 1, 30] as Excel.Range).Value); var P20 = Convert.ToString((usedRange.Cells[i + 1, 31] as Excel.Range).Value);
                    var P21 = Convert.ToString((usedRange.Cells[i + 1, 32] as Excel.Range).Value); var P22 = Convert.ToString((usedRange.Cells[i + 1, 33] as Excel.Range).Value);
                    var P23 = Convert.ToString((usedRange.Cells[i + 1, 34] as Excel.Range).Value); var P24 = Convert.ToString((usedRange.Cells[i + 1, 35] as Excel.Range).Value);
                    var P25 = Convert.ToString((usedRange.Cells[i + 1, 36] as Excel.Range).Value); var P26 = Convert.ToString((usedRange.Cells[i + 1, 37] as Excel.Range).Value);
                    var P27 = Convert.ToString((usedRange.Cells[i + 1, 38] as Excel.Range).Value); var P28 = Convert.ToString((usedRange.Cells[i + 1, 39] as Excel.Range).Value);
                    var P29 = Convert.ToString((usedRange.Cells[i + 1, 40] as Excel.Range).Value); var P30 = Convert.ToString((usedRange.Cells[i + 1, 41] as Excel.Range).Value);
                    var P31 = Convert.ToString((usedRange.Cells[i + 1, 42] as Excel.Range).Value);


                    var B1 = Convert.ToString((usedRange.Cells[36, 12] as Excel.Range).Value); var B2 = Convert.ToString((usedRange.Cells[36, 13] as Excel.Range).Value);
                    var B3 = Convert.ToString((usedRange.Cells[36, 14] as Excel.Range).Value); var B4 = Convert.ToString((usedRange.Cells[36, 15] as Excel.Range).Value);
                    var B5 = Convert.ToString((usedRange.Cells[36, 16] as Excel.Range).Value); var B6 = Convert.ToString((usedRange.Cells[36, 17] as Excel.Range).Value);
                    var B7 = Convert.ToString((usedRange.Cells[36, 18] as Excel.Range).Value); var B8 = Convert.ToString((usedRange.Cells[36, 19] as Excel.Range).Value);
                    var B9 = Convert.ToString((usedRange.Cells[36, 20] as Excel.Range).Value); var B10 = Convert.ToString((usedRange.Cells[36, 21] as Excel.Range).Value);
                    var B11 = Convert.ToString((usedRange.Cells[36, 22] as Excel.Range).Value); var B12 = Convert.ToString((usedRange.Cells[36, 23] as Excel.Range).Value);
                    var B13 = Convert.ToString((usedRange.Cells[36, 24] as Excel.Range).Value); var B14 = Convert.ToString((usedRange.Cells[36, 25] as Excel.Range).Value);
                    var B15 = Convert.ToString((usedRange.Cells[36, 26] as Excel.Range).Value); var B16 = Convert.ToString((usedRange.Cells[36, 27] as Excel.Range).Value);
                    var B17 = Convert.ToString((usedRange.Cells[36, 28] as Excel.Range).Value); var B18 = Convert.ToString((usedRange.Cells[36, 29] as Excel.Range).Value);
                    var B19 = Convert.ToString((usedRange.Cells[36, 30] as Excel.Range).Value); var B20 = Convert.ToString((usedRange.Cells[36, 31] as Excel.Range).Value);
                    var B21 = Convert.ToString((usedRange.Cells[36, 32] as Excel.Range).Value); var B22 = Convert.ToString((usedRange.Cells[36, 33] as Excel.Range).Value);
                    var B23 = Convert.ToString((usedRange.Cells[36, 34] as Excel.Range).Value); var B24 = Convert.ToString((usedRange.Cells[36, 35] as Excel.Range).Value);
                    var B25 = Convert.ToString((usedRange.Cells[36, 36] as Excel.Range).Value); var B26 = Convert.ToString((usedRange.Cells[36, 37] as Excel.Range).Value);
                    var B27 = Convert.ToString((usedRange.Cells[36, 38] as Excel.Range).Value); var B28 = Convert.ToString((usedRange.Cells[36, 39] as Excel.Range).Value);
                    var B29 = Convert.ToString((usedRange.Cells[36, 40] as Excel.Range).Value); var B30 = Convert.ToString((usedRange.Cells[36, 41] as Excel.Range).Value);
                    var B31 = Convert.ToString((usedRange.Cells[36, 42] as Excel.Range).Value);

                    var H1 = Convert.ToString((usedRange.Cells[37, 12] as Excel.Range).Value); var H2 = Convert.ToString((usedRange.Cells[37, 13] as Excel.Range).Value);
                    var H3 = Convert.ToString((usedRange.Cells[37, 14] as Excel.Range).Value); var H4 = Convert.ToString((usedRange.Cells[37, 15] as Excel.Range).Value);
                    var H5 = Convert.ToString((usedRange.Cells[37, 16] as Excel.Range).Value); var H6 = Convert.ToString((usedRange.Cells[37, 17] as Excel.Range).Value);
                    var H7 = Convert.ToString((usedRange.Cells[37, 18] as Excel.Range).Value); var H8 = Convert.ToString((usedRange.Cells[37, 19] as Excel.Range).Value);
                    var H9 = Convert.ToString((usedRange.Cells[37, 20] as Excel.Range).Value); var H10 = Convert.ToString((usedRange.Cells[37, 21] as Excel.Range).Value);
                    var H11 = Convert.ToString((usedRange.Cells[37, 22] as Excel.Range).Value); var H12 = Convert.ToString((usedRange.Cells[37, 23] as Excel.Range).Value);
                    var H13 = Convert.ToString((usedRange.Cells[37, 24] as Excel.Range).Value); var H14 = Convert.ToString((usedRange.Cells[37, 25] as Excel.Range).Value);
                    var H15 = Convert.ToString((usedRange.Cells[37, 26] as Excel.Range).Value); var H16 = Convert.ToString((usedRange.Cells[37, 27] as Excel.Range).Value);
                    var H17 = Convert.ToString((usedRange.Cells[37, 28] as Excel.Range).Value); var H18 = Convert.ToString((usedRange.Cells[37, 29] as Excel.Range).Value);
                    var H19 = Convert.ToString((usedRange.Cells[37, 30] as Excel.Range).Value); var H20 = Convert.ToString((usedRange.Cells[37, 31] as Excel.Range).Value);
                    var H21 = Convert.ToString((usedRange.Cells[37, 32] as Excel.Range).Value); var H22 = Convert.ToString((usedRange.Cells[37, 33] as Excel.Range).Value);
                    var H23 = Convert.ToString((usedRange.Cells[37, 34] as Excel.Range).Value); var H24 = Convert.ToString((usedRange.Cells[37, 35] as Excel.Range).Value);
                    var H25 = Convert.ToString((usedRange.Cells[37, 36] as Excel.Range).Value); var H26 = Convert.ToString((usedRange.Cells[37, 37] as Excel.Range).Value);
                    var H27 = Convert.ToString((usedRange.Cells[37, 38] as Excel.Range).Value); var H28 = Convert.ToString((usedRange.Cells[37, 39] as Excel.Range).Value);
                    var H29 = Convert.ToString((usedRange.Cells[37, 40] as Excel.Range).Value); var H30 = Convert.ToString((usedRange.Cells[37, 41] as Excel.Range).Value);
                    var H31 = Convert.ToString((usedRange.Cells[37, 42] as Excel.Range).Value);


                    DataRow dr = dt.NewRow();
                    dr["Types"] = Types;
                    dr["Plan_Date"] = Plan_Date;
                    dr["Vendor"] = Vendor;
                    dr["Dest"] = Dest;
                    dr["Model"] = Model;
                    dr["Part_No"] = Part_No;
                    dr["1"] = C1; dr["2"] = C2; dr["3"] = C3; dr["4"] = C4; dr["5"] = C5;
                    dr["6"] = C6; dr["7"] = C7; dr["8"] = C8; dr["9"] = C9; dr["10"] = C10;
                    dr["11"] = C11; dr["12"] = C12; dr["13"] = C13; dr["14"] = C14; dr["15"] = C15;
                    dr["16"] = C16; dr["17"] = C17; dr["18"] = C18; dr["19"] = C19; dr["20"] = C20;
                    dr["21"] = C21; dr["22"] = C22; dr["23"] = C23; dr["24"] = C24; dr["25"] = C25;
                    dr["26"] = C26; dr["27"] = C27; dr["28"] = C28; dr["29"] = C29; dr["30"] = C30;
                    dr["31"] = C31;
                    dr["P1"] = P1; dr["P2"] = P2; dr["P3"] = P3; dr["P4"] = P4; dr["P5"] = P5;
                    dr["P6"] = P6; dr["P7"] = P7; dr["P8"] = P8; dr["P9"] = P9; dr["P10"] = P10;
                    dr["P11"] = P11; dr["P12"] = P12; dr["P13"] = P13; dr["P14"] = P14; dr["P15"] = P15;
                    dr["P16"] = P16; dr["P17"] = P17; dr["P18"] = P18; dr["P19"] = P19; dr["P20"] = P20;
                    dr["P21"] = P21; dr["P22"] = P22; dr["P23"] = P23; dr["P24"] = P24; dr["P25"] = P25;
                    dr["P26"] = P26; dr["P27"] = P27; dr["P28"] = P28; dr["P29"] = P29; dr["P30"] = P30;
                    dr["P31"] = P31;
                    dr["B1"] = B1; dr["B2"] = B2; dr["B3"] = B3; dr["B4"] = B4; dr["B5"] = B5;
                    dr["B6"] = B6; dr["B7"] = B7; dr["B8"] = B8; dr["B9"] = B9; dr["B10"] = B10;
                    dr["B11"] = B11; dr["B12"] = B12; dr["B13"] = B13; dr["B14"] = B14; dr["B15"] = B15;
                    dr["B16"] = B16; dr["B17"] = B17; dr["B18"] = B18; dr["B19"] = B19; dr["B20"] = B20;
                    dr["B21"] = B21; dr["B22"] = B22; dr["B23"] = B23; dr["B24"] = B24; dr["B25"] = B25;
                    dr["B26"] = B26; dr["B27"] = B27; dr["B28"] = B28; dr["B29"] = B29; dr["B30"] = B30;
                    dr["B31"] = B31;
                    dr["H1"] = H1; dr["H2"] = H2; dr["H3"] = H3; dr["H4"] = H4; dr["H5"] = H5;
                    dr["H6"] = H6; dr["H7"] = H7; dr["H8"] = H8; dr["H9"] = H9; dr["H10"] = H10;
                    dr["H11"] = H11; dr["H12"] = H12; dr["H13"] = H13; dr["H14"] = H14; dr["H15"] = H15;
                    dr["H16"] = H16; dr["H17"] = H17; dr["H18"] = H18; dr["H19"] = H19; dr["H20"] = H20;
                    dr["H21"] = H21; dr["H22"] = H22; dr["H23"] = H23; dr["H24"] = H24; dr["H25"] = H25;
                    dr["H26"] = H26; dr["H27"] = H27; dr["H28"] = H28; dr["H29"] = H29; dr["H30"] = H30;
                    dr["H31"] = H31;

                    dt.Rows.Add(dr);
                }
            }
            ViewState["gdvDetail"] = dt;
            gdvDetail.DataSource = dt;
            gdvDetail.DataBind();
            int k = gdvDetail.Columns.Count;
            for (int i = 6; i < 130; i++)
            {
                gdvDetail.Columns[i].Visible = false;
            }


            for (int i = MCHEADRows; i < MCHEADRows + 6; i += 2)
            {
                if ((usedRange.Cells[i, 4] as Range).Value != null)
                {
                    var Model = Convert.ToString((usedRange.Cells[i, 4] as Excel.Range).Value);
                    var Part_No = Convert.ToString((usedRange.Cells[i, 9] as Excel.Range).Value);
                    var C1 = Convert.ToString((usedRange.Cells[i, 12] as Excel.Range).Value); var C2 = Convert.ToString((usedRange.Cells[i, 13] as Excel.Range).Value);
                    var C3 = Convert.ToString((usedRange.Cells[i, 14] as Excel.Range).Value); var C4 = Convert.ToString((usedRange.Cells[i, 15] as Excel.Range).Value);
                    var C5 = Convert.ToString((usedRange.Cells[i, 16] as Excel.Range).Value); var C6 = Convert.ToString((usedRange.Cells[i, 17] as Excel.Range).Value);
                    var C7 = Convert.ToString((usedRange.Cells[i, 18] as Excel.Range).Value); var C8 = Convert.ToString((usedRange.Cells[i, 19] as Excel.Range).Value);
                    var C9 = Convert.ToString((usedRange.Cells[i, 20] as Excel.Range).Value); var C10 = Convert.ToString((usedRange.Cells[i, 21] as Excel.Range).Value);
                    var C11 = Convert.ToString((usedRange.Cells[i, 22] as Excel.Range).Value); var C12 = Convert.ToString((usedRange.Cells[i, 23] as Excel.Range).Value);
                    var C13 = Convert.ToString((usedRange.Cells[i, 24] as Excel.Range).Value); var C14 = Convert.ToString((usedRange.Cells[i, 25] as Excel.Range).Value);
                    var C15 = Convert.ToString((usedRange.Cells[i, 26] as Excel.Range).Value); var C16 = Convert.ToString((usedRange.Cells[i, 27] as Excel.Range).Value);
                    var C17 = Convert.ToString((usedRange.Cells[i, 28] as Excel.Range).Value); var C18 = Convert.ToString((usedRange.Cells[i, 29] as Excel.Range).Value);
                    var C19 = Convert.ToString((usedRange.Cells[i, 30] as Excel.Range).Value); var C20 = Convert.ToString((usedRange.Cells[i, 31] as Excel.Range).Value);
                    var C21 = Convert.ToString((usedRange.Cells[i, 32] as Excel.Range).Value); var C22 = Convert.ToString((usedRange.Cells[i, 33] as Excel.Range).Value);
                    var C23 = Convert.ToString((usedRange.Cells[i, 34] as Excel.Range).Value); var C24 = Convert.ToString((usedRange.Cells[i, 35] as Excel.Range).Value);
                    var C25 = Convert.ToString((usedRange.Cells[i, 36] as Excel.Range).Value); var C26 = Convert.ToString((usedRange.Cells[i, 37] as Excel.Range).Value);
                    var C27 = Convert.ToString((usedRange.Cells[i, 38] as Excel.Range).Value); var C28 = Convert.ToString((usedRange.Cells[i, 39] as Excel.Range).Value);
                    var C29 = Convert.ToString((usedRange.Cells[i, 40] as Excel.Range).Value); var C30 = Convert.ToString((usedRange.Cells[i, 41] as Excel.Range).Value);
                    var C31 = Convert.ToString((usedRange.Cells[i, 42] as Excel.Range).Value);

                    var P1 = Convert.ToString((usedRange.Cells[i + 1, 12] as Excel.Range).Value); var P2 = Convert.ToString((usedRange.Cells[i + 1, 13] as Excel.Range).Value);
                    var P3 = Convert.ToString((usedRange.Cells[i + 1, 14] as Excel.Range).Value); var P4 = Convert.ToString((usedRange.Cells[i + 1, 15] as Excel.Range).Value);
                    var P5 = Convert.ToString((usedRange.Cells[i + 1, 16] as Excel.Range).Value); var P6 = Convert.ToString((usedRange.Cells[i + 1, 17] as Excel.Range).Value);
                    var P7 = Convert.ToString((usedRange.Cells[i + 1, 18] as Excel.Range).Value); var P8 = Convert.ToString((usedRange.Cells[i + 1, 19] as Excel.Range).Value);
                    var P9 = Convert.ToString((usedRange.Cells[i + 1, 20] as Excel.Range).Value); var P10 = Convert.ToString((usedRange.Cells[i + 1, 21] as Excel.Range).Value);
                    var P11 = Convert.ToString((usedRange.Cells[i + 1, 22] as Excel.Range).Value); var P12 = Convert.ToString((usedRange.Cells[i + 1, 23] as Excel.Range).Value);
                    var P13 = Convert.ToString((usedRange.Cells[i + 1, 24] as Excel.Range).Value); var P14 = Convert.ToString((usedRange.Cells[i + 1, 25] as Excel.Range).Value);
                    var P15 = Convert.ToString((usedRange.Cells[i + 1, 26] as Excel.Range).Value); var P16 = Convert.ToString((usedRange.Cells[i + 1, 27] as Excel.Range).Value);
                    var P17 = Convert.ToString((usedRange.Cells[i + 1, 28] as Excel.Range).Value); var P18 = Convert.ToString((usedRange.Cells[i + 1, 29] as Excel.Range).Value);
                    var P19 = Convert.ToString((usedRange.Cells[i + 1, 30] as Excel.Range).Value); var P20 = Convert.ToString((usedRange.Cells[i + 1, 31] as Excel.Range).Value);
                    var P21 = Convert.ToString((usedRange.Cells[i + 1, 32] as Excel.Range).Value); var P22 = Convert.ToString((usedRange.Cells[i + 1, 33] as Excel.Range).Value);
                    var P23 = Convert.ToString((usedRange.Cells[i + 1, 34] as Excel.Range).Value); var P24 = Convert.ToString((usedRange.Cells[i + 1, 35] as Excel.Range).Value);
                    var P25 = Convert.ToString((usedRange.Cells[i + 1, 36] as Excel.Range).Value); var P26 = Convert.ToString((usedRange.Cells[i + 1, 37] as Excel.Range).Value);
                    var P27 = Convert.ToString((usedRange.Cells[i + 1, 38] as Excel.Range).Value); var P28 = Convert.ToString((usedRange.Cells[i + 1, 39] as Excel.Range).Value);
                    var P29 = Convert.ToString((usedRange.Cells[i + 1, 40] as Excel.Range).Value); var P30 = Convert.ToString((usedRange.Cells[i + 1, 41] as Excel.Range).Value);
                    var P31 = Convert.ToString((usedRange.Cells[i + 1, 42] as Excel.Range).Value);


                    var B1 = Convert.ToString((usedRange.Cells[36, 12] as Excel.Range).Value); var B2 = Convert.ToString((usedRange.Cells[36, 13] as Excel.Range).Value);
                    var B3 = Convert.ToString((usedRange.Cells[36, 14] as Excel.Range).Value); var B4 = Convert.ToString((usedRange.Cells[36, 15] as Excel.Range).Value);
                    var B5 = Convert.ToString((usedRange.Cells[36, 16] as Excel.Range).Value); var B6 = Convert.ToString((usedRange.Cells[36, 17] as Excel.Range).Value);
                    var B7 = Convert.ToString((usedRange.Cells[36, 18] as Excel.Range).Value); var B8 = Convert.ToString((usedRange.Cells[36, 19] as Excel.Range).Value);
                    var B9 = Convert.ToString((usedRange.Cells[36, 20] as Excel.Range).Value); var B10 = Convert.ToString((usedRange.Cells[36, 21] as Excel.Range).Value);
                    var B11 = Convert.ToString((usedRange.Cells[36, 22] as Excel.Range).Value); var B12 = Convert.ToString((usedRange.Cells[36, 23] as Excel.Range).Value);
                    var B13 = Convert.ToString((usedRange.Cells[36, 24] as Excel.Range).Value); var B14 = Convert.ToString((usedRange.Cells[36, 25] as Excel.Range).Value);
                    var B15 = Convert.ToString((usedRange.Cells[36, 26] as Excel.Range).Value); var B16 = Convert.ToString((usedRange.Cells[36, 27] as Excel.Range).Value);
                    var B17 = Convert.ToString((usedRange.Cells[36, 28] as Excel.Range).Value); var B18 = Convert.ToString((usedRange.Cells[36, 29] as Excel.Range).Value);
                    var B19 = Convert.ToString((usedRange.Cells[36, 30] as Excel.Range).Value); var B20 = Convert.ToString((usedRange.Cells[36, 31] as Excel.Range).Value);
                    var B21 = Convert.ToString((usedRange.Cells[36, 32] as Excel.Range).Value); var B22 = Convert.ToString((usedRange.Cells[36, 33] as Excel.Range).Value);
                    var B23 = Convert.ToString((usedRange.Cells[36, 34] as Excel.Range).Value); var B24 = Convert.ToString((usedRange.Cells[36, 35] as Excel.Range).Value);
                    var B25 = Convert.ToString((usedRange.Cells[36, 36] as Excel.Range).Value); var B26 = Convert.ToString((usedRange.Cells[36, 37] as Excel.Range).Value);
                    var B27 = Convert.ToString((usedRange.Cells[36, 38] as Excel.Range).Value); var B28 = Convert.ToString((usedRange.Cells[36, 39] as Excel.Range).Value);
                    var B29 = Convert.ToString((usedRange.Cells[36, 40] as Excel.Range).Value); var B30 = Convert.ToString((usedRange.Cells[36, 41] as Excel.Range).Value);
                    var B31 = Convert.ToString((usedRange.Cells[36, 42] as Excel.Range).Value);

                    var H1 = Convert.ToString((usedRange.Cells[37, 12] as Excel.Range).Value); var H2 = Convert.ToString((usedRange.Cells[37, 13] as Excel.Range).Value);
                    var H3 = Convert.ToString((usedRange.Cells[37, 14] as Excel.Range).Value); var H4 = Convert.ToString((usedRange.Cells[37, 15] as Excel.Range).Value);
                    var H5 = Convert.ToString((usedRange.Cells[37, 16] as Excel.Range).Value); var H6 = Convert.ToString((usedRange.Cells[37, 17] as Excel.Range).Value);
                    var H7 = Convert.ToString((usedRange.Cells[37, 18] as Excel.Range).Value); var H8 = Convert.ToString((usedRange.Cells[37, 19] as Excel.Range).Value);
                    var H9 = Convert.ToString((usedRange.Cells[37, 20] as Excel.Range).Value); var H10 = Convert.ToString((usedRange.Cells[37, 21] as Excel.Range).Value);
                    var H11 = Convert.ToString((usedRange.Cells[37, 22] as Excel.Range).Value); var H12 = Convert.ToString((usedRange.Cells[37, 23] as Excel.Range).Value);
                    var H13 = Convert.ToString((usedRange.Cells[37, 24] as Excel.Range).Value); var H14 = Convert.ToString((usedRange.Cells[37, 25] as Excel.Range).Value);
                    var H15 = Convert.ToString((usedRange.Cells[37, 26] as Excel.Range).Value); var H16 = Convert.ToString((usedRange.Cells[37, 27] as Excel.Range).Value);
                    var H17 = Convert.ToString((usedRange.Cells[37, 28] as Excel.Range).Value); var H18 = Convert.ToString((usedRange.Cells[37, 29] as Excel.Range).Value);
                    var H19 = Convert.ToString((usedRange.Cells[37, 30] as Excel.Range).Value); var H20 = Convert.ToString((usedRange.Cells[37, 31] as Excel.Range).Value);
                    var H21 = Convert.ToString((usedRange.Cells[37, 32] as Excel.Range).Value); var H22 = Convert.ToString((usedRange.Cells[37, 33] as Excel.Range).Value);
                    var H23 = Convert.ToString((usedRange.Cells[37, 34] as Excel.Range).Value); var H24 = Convert.ToString((usedRange.Cells[37, 35] as Excel.Range).Value);
                    var H25 = Convert.ToString((usedRange.Cells[37, 36] as Excel.Range).Value); var H26 = Convert.ToString((usedRange.Cells[37, 37] as Excel.Range).Value);
                    var H27 = Convert.ToString((usedRange.Cells[37, 38] as Excel.Range).Value); var H28 = Convert.ToString((usedRange.Cells[37, 39] as Excel.Range).Value);
                    var H29 = Convert.ToString((usedRange.Cells[37, 40] as Excel.Range).Value); var H30 = Convert.ToString((usedRange.Cells[37, 41] as Excel.Range).Value);
                    var H31 = Convert.ToString((usedRange.Cells[37, 42] as Excel.Range).Value);


                    DataRow dr1 = dt2.NewRow();
                    dr1["Types"] = Types;
                    dr1["Plan_Date"] = Plan_Date;
                    dr1["Vendor"] = Vendor;
                    dr1["Dest"] = Dest;
                    dr1["Model"] = Model;
                    dr1["Part_No"] = Part_No;
                    dr1["1"] = C1; dr1["2"] = C2; dr1["3"] = C3; dr1["4"] = C4; dr1["5"] = C5;
                    dr1["6"] = C6; dr1["7"] = C7; dr1["8"] = C8; dr1["9"] = C9; dr1["10"] = C10;
                    dr1["11"] = C11; dr1["12"] = C12; dr1["13"] = C13; dr1["14"] = C14; dr1["15"] = C15;
                    dr1["16"] = C16; dr1["17"] = C17; dr1["18"] = C18; dr1["19"] = C19; dr1["20"] = C20;
                    dr1["21"] = C21; dr1["22"] = C22; dr1["23"] = C23; dr1["24"] = C24; dr1["25"] = C25;
                    dr1["26"] = C26; dr1["27"] = C27; dr1["28"] = C28; dr1["29"] = C29; dr1["30"] = C30;
                    dr1["31"] = C31;
                    dr1["P1"] = P1; dr1["P2"] = P2; dr1["P3"] = P3; dr1["P4"] = P4; dr1["P5"] = P5;
                    dr1["P6"] = P6; dr1["P7"] = P7; dr1["P8"] = P8; dr1["P9"] = P9; dr1["P10"] = P10;
                    dr1["P11"] = P11; dr1["P12"] = P12; dr1["P13"] = P13; dr1["P14"] = P14; dr1["P15"] = P15;
                    dr1["P16"] = P16; dr1["P17"] = P17; dr1["P18"] = P18; dr1["P19"] = P19; dr1["P20"] = P20;
                    dr1["P21"] = P21; dr1["P22"] = P22; dr1["P23"] = P23; dr1["P24"] = P24; dr1["P25"] = P25;
                    dr1["P26"] = P26; dr1["P27"] = P27; dr1["P28"] = P28; dr1["P29"] = P29; dr1["P30"] = P30;
                    dr1["P31"] = P31;
                    dr1["B1"] = B1; dr1["B2"] = B2; dr1["B3"] = B3; dr1["B4"] = B4; dr1["B5"] = B5;
                    dr1["B6"] = B6; dr1["B7"] = B7; dr1["B8"] = B8; dr1["B9"] = B9; dr1["B10"] = B10;
                    dr1["B11"] = B11; dr1["B12"] = B12; dr1["B13"] = B13; dr1["B14"] = B14; dr1["B15"] = B15;
                    dr1["B16"] = B16; dr1["B17"] = B17; dr1["B18"] = B18; dr1["B19"] = B19; dr1["B20"] = B20;
                    dr1["B21"] = B21; dr1["B22"] = B22; dr1["B23"] = B23; dr1["B24"] = B24; dr1["B25"] = B25;
                    dr1["B26"] = B26; dr1["B27"] = B27; dr1["B28"] = B28; dr1["B29"] = B29; dr1["B30"] = B30;
                    dr1["B31"] = B31;
                    dr1["H1"] = H1; dr1["H2"] = H2; dr1["H3"] = H3; dr1["H4"] = H4; dr1["H5"] = H5;
                    dr1["H6"] = H6; dr1["H7"] = H7; dr1["H8"] = H8; dr1["H9"] = H9; dr1["H10"] = H10;
                    dr1["H11"] = H11; dr1["H12"] = H12; dr1["H13"] = H13; dr1["H14"] = H14; dr1["H15"] = H15;
                    dr1["H16"] = H16; dr1["H17"] = H17; dr1["H18"] = H18; dr1["H19"] = H19; dr1["H20"] = H20;
                    dr1["H21"] = H21; dr1["H22"] = H22; dr1["H23"] = H23; dr1["H24"] = H24; dr1["H25"] = H25;
                    dr1["H26"] = H26; dr1["H27"] = H27; dr1["H28"] = H28; dr1["H29"] = H29; dr1["H30"] = H30;
                    dr1["H31"] = H31;

                    dt2.Rows.Add(dr1);
                }
            }
            ViewState["gdvDetail1"] = dt2;
            gdvDetail1.DataSource = dt2;
            gdvDetail1.DataBind();
            for (int j = 6; j < 130; j++)
            {
                gdvDetail1.Columns[j].Visible = false;
            }
            FormControlEnable();
            excel.Quit();
            excel = null;
            KillProcess("EXCEL");
            }
            catch (Exception ex)
            {
                excel.Quit();
                excel = null;
                KillProcess("EXCEL");
                lblMsg.Text = lblMsg.Text + ex.ToString();
            }
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
            System.Data.DataTable dt = (System.Data.DataTable)this.gdvDetail.DataSource;
            System.Data.DataTable dt1 = (System.Data.DataTable)this.gdvDetail1.DataSource;
            int rtn = 0;
            string rtnHEADNO = "";
            int linecnt = 0;
            MCDel mc1 = new MCDel(g_user_id, g_lang);

            switch (ddlTYPE.Text.ToString())
            {
                case "MC":
                    mc1.year = Convert.ToInt32(Convert.ToDateTime(dt.Rows[0]["Plan_Date"]).Year);
                    mc1.month = Convert.ToInt32(Convert.ToDateTime(dt.Rows[0]["Plan_Date"]).Month);
                    //mc1.version = 0;
                    rtn = 0;
                    rtn = mc1.HeadInsert(out rtnHEADNO);

                    if (rtn == ComConst.FAILED)
                    {
                        lblMsg.Text = mc1.strErr;
                        lblMsg.ForeColor = Color.Red;
                        return;
                    }
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        mc1.vendor = dt.Rows[i]["Vendor"].ToString();
                        mc1.dest = dt.Rows[i]["Dest"].ToString();
                        mc1.model = dt.Rows[i]["Model"].ToString();
                        for (int j = 1; j < 32; j++)
                        {
                            linecnt += 1;
                            mc1.mc_hum_no = rtnHEADNO;
                            mc1.mc_ckd_line = linecnt;
                            mc1.mc_del_n_2 = DateTime.ParseExact(mc1.year + mc1.month.ToString().PadLeft(2, '0') + j.ToString().PadLeft(2, '0'), "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
                            if (dt.Rows[i]["" + j + ""].ToString() == "")
                            {
                                mc1.qty = 0;
                            }
                            else
                            {
                                mc1.qty = Convert.ToInt32(dt.Rows[i]["" + j + ""].ToString());
                            }
                            mc1.pc_no = dt.Rows[i]["P" + j].ToString();
                            mc1.block_qty = Convert.ToInt32(dt.Rows[i]["B" + j].ToString());
                            mc1.head_qty = Convert.ToInt32(dt.Rows[i]["H" + j].ToString());
                            rtn = 0;
                            rtn = mc1.DetailInsert();

                            if (rtn == ComConst.FAILED)
                            {
                                lblMsg.Text = mc1.strErr;
                                lblMsg.ForeColor = Color.Red;
                                return;
                            }
                        }
                    }
                    for (int i = 0; i < dt2.Rows.Count; i++)
                    {
                        mc1.vendor = dt2.Rows[i]["Vendor"].ToString();
                        mc1.dest = dt2.Rows[i]["Dest"].ToString();
                        mc1.model = dt2.Rows[i]["Model"].ToString();

                        for (int j = 1; j < 32; j++)
                        {
                            linecnt += 1;
                            mc1.mc_hum_no = rtnHEADNO;
                            mc1.mc_ckd_line = linecnt;
                            mc1.mc_del_n_2 = DateTime.ParseExact(mc1.year + mc1.month.ToString().PadLeft(2, '0') + j.ToString().PadLeft(2, '0'), "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
                            if (dt2.Rows[i]["" + j + ""].ToString() == "")
                            {
                                mc1.qty = 0;
                            }
                            else
                            {
                                mc1.qty = Convert.ToInt32(dt2.Rows[i]["" + j + ""].ToString());
                            }
                            mc1.pc_no = dt2.Rows[i]["P" + j].ToString();
                            mc1.block_qty = Convert.ToInt32(dt2.Rows[i]["B" + j].ToString());
                            mc1.head_qty = Convert.ToInt32(dt2.Rows[i]["H" + j].ToString());
                            rtn = 0;
                            rtn = mc1.DetailInsert();

                            if (rtn == ComConst.FAILED)
                            {
                                lblMsg.Text = mc1.strErr;
                                lblMsg.ForeColor = Color.Red;
                                return;
                            }
                        }
                    }
                    lblMsg.Text = "Updated normally.";
                    lblMsg.ForeColor = Color.Blue;
                    break;
            }

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
        protected void gdvDetail1_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }
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
        protected void imgReturn_Click(object sender, EventArgs e)
        {
            //string g_program_id = Request["program_id"].ToString();
            //int g_level = int.Parse(Request["level"].ToString());
            //IMClass.Common com = new IMClass.Common();
            //g_program_id = com.GetBackMenuGrp(g_program_id, g_level);
            //string strUrl = "~/Default.aspx?program_id=" + g_program_id + "&level=" + g_level.ToString();
            string strUrl = "~/Default.aspx";
            Response.Redirect(strUrl);
        }
    }
}