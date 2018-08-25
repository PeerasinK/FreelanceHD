using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IMClass;
using System.Drawing;
using System.Globalization;
using System.Collections;
using System.Data;
using System.Web.Configuration;
using System.Text;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace HondaTraceabilitySystem
{
    public partial class UpdPlanProdOrd : System.Web.UI.Page
    {
        protected string g_user_id;
        protected int g_lang;
        protected string g_company_cd;
        protected string g_name;
        public static System.Data.DataTable dt = null;
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
            dt.Rows.Add("MC CKD", "MC CKD");
            dt.Rows.Add("FE", "FE");
            dt.Rows.Add("FE CKD", "FE CKD");
            dt.Rows.Add("KD", "KD");
            dt.Rows.Add("Special Part", "Special Part");

            ddlTYPE.DataValueField = "DEPT_NO";
            ddlTYPE.DataTextField = "DEPT_NAME";
            ddlTYPE.DataSource = dt;
            ddlTYPE.DataBind();

            //DropDownList Year Item add
            if (ddlYear.Items.Count == 0)
            {
                for (int i = 2008; i <= 2037; i++)
                {
                    ddlYear.Items.Add(i.ToString());
                }
            }
            //DropDownList Month Item add
            if (ddlMonth.Items.Count == 0)
            {
                for (int i = 1; i <= 12; i++)
                {
                    ddlMonth.Items.Add(i.ToString("0#"));
                }
            }
            //当前年月

            ddlYear.Text = DateTime.Now.Year.ToString();
            ddlMonth.Text = DateTime.Now.Month.ToString("0#");

            //int NowYear = Convert.ToInt32(ddlYear.Text.ToString());
            //int NowMouth = Convert.ToInt32(ddlMonth.Text.ToString());

            //ds = mc1.GetOrder(NowYear,NowMouth);
            //ddlOrderNo.DataTextField = "HEAD_NO";
            //ddlOrderNo.DataValueField = "HEAD_NO";

            //if (ds !=null )
            //{
            //    ddlOrderNo.DataSource = ds.Tables[0];
            //    ddlOrderNo.DataBind();
            //    ddlOrderNo.Items.Clear();
            //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //    {
            //        ddlOrderNo.Items.Add(ds.Tables[0].Rows[i]["HEAD_NO"].ToString());
            //    }
            //}
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
            EditGridView(out dt);

            switch (ddlTYPE.Text.ToString())
            {
                case "MC":
                    MC_Import(filePath);
                    break;
                case "MC CKD":
                    MCCKD_Import(filePath);
                    break;
                case "FE":
                    FE_Import(filePath);
                    break;
                case "FE CKD":
                    FECKD_Import(filePath);
                    break;
                case "KD":
                    KD_Import(filePath);
                    break;
                case "Special Part":
                    SPECPART_Import(filePath);
                    break;
            }
        }
        protected void EditGridView(out System.Data.DataTable dt)
        {
            System.Data.DataTable dt1 = new System.Data.DataTable();
            dt1.Columns.Add(new DataColumn("Types"));
            dt1.Columns.Add(new DataColumn("Plan_Date"));
            dt1.Columns.Add(new DataColumn("Part_No"));
            dt1.Columns.Add(new DataColumn("Model"));
            dt1.Columns.Add(new DataColumn("Engine_code"));
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
            dt1.Columns.Add(new DataColumn("Total_Quantity"));
            dt1.Columns.Add(new DataColumn("Line_No"));
            dt1.Columns.Add(new DataColumn("Del_N_2"));
            dt1.Columns.Add(new DataColumn("Vendor"));
            dt1.Columns.Add(new DataColumn("Dist"));
            dt1.Columns.Add(new DataColumn("PC_No"));
            dt1.Columns.Add(new DataColumn("Block_Qty"));
            dt1.Columns.Add(new DataColumn("Head_Qty"));
            dt1.Columns.Add(new DataColumn("Van_Original"));
            dt1.Columns.Add(new DataColumn("Cy_Cut"));
            dt1.Columns.Add(new DataColumn("Time_Icd"));
            dt1.Columns.Add(new DataColumn("ETD"));
            dt1.Columns.Add(new DataColumn("Vessel"));
            dt1.Columns.Add(new DataColumn("Part_Delivery"));
            dt1.Columns.Add(new DataColumn("Order_No"));
            dt1.Columns.Add(new DataColumn("Order_Date"));
            dt1.Columns.Add(new DataColumn("Packing_Date"));
            dt1.Columns.Add(new DataColumn("Packing_List_To_Ib"));
            dt1.Columns.Add(new DataColumn("ETD_Date"));
            dt1.Columns.Add(new DataColumn("ETA_Date"));
            dt1.Columns.Add(new DataColumn("Ship_By"));
            dt1.Columns.Add(new DataColumn("RTA"));
            dt1.Columns.Add(new DataColumn("Issue_Date"));
            dt1.Columns.Add(new DataColumn("Model_Type"));
            dt1.Columns.Add(new DataColumn("Issue_By"));
            dt1.Columns.Add(new DataColumn("Color"));
            dt1.Columns.Add(new DataColumn("FG_Qty"));
            dt1.Columns.Add(new DataColumn("Del_From"));
            dt1.Columns.Add(new DataColumn("Del_To"));
            dt1.Columns.Add(new DataColumn("Plan_Code"));
            dt1.Columns.Add(new DataColumn("Req_No"));
            dt1.Columns.Add(new DataColumn("Remark"));
            dt1.Columns.Add(new DataColumn("SEMI_FIXED_FIRST"));
            dt1.Columns.Add(new DataColumn("SEMI_FIXED_SECOND"));
            dt1.Columns.Add(new DataColumn("ORDER"));
            dt1.Columns.Add(new DataColumn("DIFF"));

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

            try
            {
                string Types = "MC";
                string Plan_Date = Convert.ToString((usedRange.Cells[2, 12] as Excel.Range).Value);
                var Part_No = (string)(usedRange.Cells[21, 3] as Excel.Range).Value;
                var vLine = (string)(usedRange.Cells[20, 2] as Excel.Range).Value;
                var ENG_MTO = (string)(usedRange.Cells[21, 5] as Excel.Range).Value;
                ENG_MTO = ENG_MTO + (string)(usedRange.Cells[21, 6] as Excel.Range).Value;
                var Total_Quantity = (double)(usedRange.Cells[21, 38] as Excel.Range).Value;
                var Remark = (string)(usedRange.Cells[44, 1] as Excel.Range).Value;
                Remark = Remark + (string)(usedRange.Cells[45, 1] as Excel.Range).Value;
                Remark = Remark + (string)(usedRange.Cells[46, 1] as Excel.Range).Value;
                Remark = Remark + (string)(usedRange.Cells[47, 1] as Excel.Range).Value;
                var C1 = (usedRange.Cells[21, 7] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 7] as Excel.Range).Value;
                var C2 = (usedRange.Cells[21, 8] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 8] as Excel.Range).Value;
                var C3 = (usedRange.Cells[21, 9] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 9] as Excel.Range).Value;
                var C4 = (usedRange.Cells[21, 10] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 10] as Excel.Range).Value;
                var C5 = (usedRange.Cells[21, 11] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 11] as Excel.Range).Value;
                var C6 = (usedRange.Cells[21, 12] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 12] as Excel.Range).Value;
                var C7 = (usedRange.Cells[21, 13] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 13] as Excel.Range).Value;
                var C8 = (usedRange.Cells[21, 14] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 14] as Excel.Range).Value;
                var C9 = (usedRange.Cells[21, 15] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 15] as Excel.Range).Value;
                var C10 = (usedRange.Cells[21, 16] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 16] as Excel.Range).Value;
                var C11 = (usedRange.Cells[21, 17] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 17] as Excel.Range).Value;
                var C12 = (usedRange.Cells[21, 18] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 18] as Excel.Range).Value;
                var C13 = (usedRange.Cells[21, 19] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 19] as Excel.Range).Value;
                var C14 = (usedRange.Cells[21, 20] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 20] as Excel.Range).Value;
                var C15 = (usedRange.Cells[21, 21] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 21] as Excel.Range).Value;
                var C16 = (usedRange.Cells[21, 22] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 22] as Excel.Range).Value;
                var C17 = (usedRange.Cells[21, 23] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 23] as Excel.Range).Value;
                var C18 = (usedRange.Cells[21, 24] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 24] as Excel.Range).Value;
                var C19 = (usedRange.Cells[21, 25] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 25] as Excel.Range).Value;
                var C20 = (usedRange.Cells[21, 26] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 26] as Excel.Range).Value;
                var C21 = (usedRange.Cells[21, 27] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 27] as Excel.Range).Value;
                var C22 = (usedRange.Cells[21, 28] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 28] as Excel.Range).Value;
                var C23 = (usedRange.Cells[21, 29] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 29] as Excel.Range).Value;
                var C24 = (usedRange.Cells[21, 30] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 30] as Excel.Range).Value;
                var C25 = (usedRange.Cells[21, 31] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 31] as Excel.Range).Value;
                var C26 = (usedRange.Cells[21, 32] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 32] as Excel.Range).Value;
                var C27 = (usedRange.Cells[21, 33] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 33] as Excel.Range).Value;
                var C28 = (usedRange.Cells[21, 34] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 34] as Excel.Range).Value;
                var C29 = (usedRange.Cells[21, 35] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 35] as Excel.Range).Value;
                var C30 = (usedRange.Cells[21, 36] as Excel.Range).Value == null ? 0 : (usedRange.Cells[21, 36] as Excel.Range).Value;

                DataRow dr = dt.NewRow();
                dr["Types"] = Types;
                dr["Plan_Date"] = Plan_Date;
                dr["Part_No"] = Part_No;
                //dr["Part_Name"] = Part_Name;
                dr["Line_No"] = vLine;
                dr["Engine_code"] = ENG_MTO;
                dr["Total_Quantity"] = Total_Quantity;
                dr["Remark"] = Remark;
                dr["1"] = C1; dr["2"] = C2; dr["3"] = C3; dr["4"] = C4; dr["5"] = C5;
                dr["6"] = C6; dr["7"] = C7; dr["8"] = C8; dr["9"] = C9; dr["10"] = C10;
                dr["11"] = C11; dr["12"] = C12; dr["13"] = C13; dr["14"] = C14; dr["15"] = C15;
                dr["16"] = C16; dr["17"] = C17; dr["18"] = C18; dr["19"] = C19; dr["20"] = C20;
                dr["21"] = C21; dr["22"] = C22; dr["23"] = C23; dr["24"] = C24; dr["25"] = C25;
                dr["26"] = C26; dr["27"] = C27; dr["28"] = C28; dr["29"] = C29; dr["30"] = C30;
                dt.Rows.Add(dr);


                Part_No = (string)(usedRange.Cells[29, 3] as Excel.Range).Value;
                vLine = (string)(usedRange.Cells[29, 2] as Excel.Range).Value;
                ENG_MTO = (string)(usedRange.Cells[29, 5] as Excel.Range).Value;
                ENG_MTO = ENG_MTO + (string)(usedRange.Cells[29, 6] as Excel.Range).Value;
                Total_Quantity = (double)(usedRange.Cells[29, 38] as Excel.Range).Value;

                C1 = (usedRange.Cells[29, 7] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 7] as Excel.Range).Value;
                C2 = (usedRange.Cells[29, 8] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 8] as Excel.Range).Value;
                C3 = (usedRange.Cells[29, 9] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 9] as Excel.Range).Value;
                C4 = (usedRange.Cells[29, 10] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 10] as Excel.Range).Value;
                C5 = (usedRange.Cells[29, 11] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 11] as Excel.Range).Value;
                C6 = (usedRange.Cells[29, 12] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 12] as Excel.Range).Value;
                C7 = (usedRange.Cells[29, 13] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 13] as Excel.Range).Value;
                C8 = (usedRange.Cells[29, 14] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 14] as Excel.Range).Value;
                C9 = (usedRange.Cells[29, 15] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 15] as Excel.Range).Value;
                C10 = (usedRange.Cells[29, 16] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 16] as Excel.Range).Value;
                C11 = (usedRange.Cells[29, 17] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 17] as Excel.Range).Value;
                C12 = (usedRange.Cells[29, 18] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 18] as Excel.Range).Value;
                C13 = (usedRange.Cells[29, 19] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 19] as Excel.Range).Value;
                C14 = (usedRange.Cells[29, 20] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 20] as Excel.Range).Value;
                C15 = (usedRange.Cells[29, 21] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 21] as Excel.Range).Value;
                C16 = (usedRange.Cells[29, 22] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 22] as Excel.Range).Value;
                C17 = (usedRange.Cells[29, 23] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 23] as Excel.Range).Value;
                C18 = (usedRange.Cells[29, 24] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 24] as Excel.Range).Value;
                C19 = (usedRange.Cells[29, 25] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 25] as Excel.Range).Value;
                C20 = (usedRange.Cells[29, 26] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 26] as Excel.Range).Value;
                C21 = (usedRange.Cells[29, 27] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 27] as Excel.Range).Value;
                C22 = (usedRange.Cells[29, 28] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 28] as Excel.Range).Value;
                C23 = (usedRange.Cells[29, 29] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 29] as Excel.Range).Value;
                C24 = (usedRange.Cells[29, 30] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 30] as Excel.Range).Value;
                C25 = (usedRange.Cells[29, 31] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 31] as Excel.Range).Value;
                C26 = (usedRange.Cells[29, 32] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 32] as Excel.Range).Value;
                C27 = (usedRange.Cells[29, 33] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 33] as Excel.Range).Value;
                C28 = (usedRange.Cells[29, 34] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 34] as Excel.Range).Value;
                C29 = (usedRange.Cells[29, 35] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 35] as Excel.Range).Value;
                C30 = (usedRange.Cells[29, 36] as Excel.Range).Value == null ? 0 : (usedRange.Cells[29, 36] as Excel.Range).Value;

                dr = dt.NewRow();
                dr["Types"] = Types;
                dr["Plan_Date"] = Plan_Date;
                dr["Part_No"] = Part_No;
                //dr["Part_Name"] = Part_Name;
                dr["Line_No"] = vLine;
                dr["Engine_code"] = ENG_MTO;
                dr["Total_Quantity"] = Total_Quantity;
                dr["Remark"] = Remark;
                dr["1"] = C1; dr["2"] = C2; dr["3"] = C3; dr["4"] = C4; dr["5"] = C5;
                dr["6"] = C6; dr["7"] = C7; dr["8"] = C8; dr["9"] = C9; dr["10"] = C10;
                dr["11"] = C11; dr["12"] = C12; dr["13"] = C13; dr["14"] = C14; dr["15"] = C15;
                dr["16"] = C16; dr["17"] = C17; dr["18"] = C18; dr["19"] = C19; dr["20"] = C20;
                dr["21"] = C21; dr["22"] = C22; dr["23"] = C23; dr["24"] = C24; dr["25"] = C25;
                dr["26"] = C26; dr["27"] = C27; dr["28"] = C28; dr["29"] = C29; dr["30"] = C30;
                dt.Rows.Add(dr);

                Part_No = (string)(usedRange.Cells[36, 3] as Excel.Range).Value;
                vLine = (string)(usedRange.Cells[20, 2] as Excel.Range).Value;
                ENG_MTO = (string)(usedRange.Cells[36, 5] as Excel.Range).Value;
                ENG_MTO = ENG_MTO + (string)(usedRange.Cells[36, 6] as Excel.Range).Value;
                Total_Quantity = (double)(usedRange.Cells[36, 38] as Excel.Range).Value;


                C1 = (usedRange.Cells[36, 7] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 7] as Excel.Range).Value;
                C2 = (usedRange.Cells[36, 8] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 8] as Excel.Range).Value;
                C3 = (usedRange.Cells[36, 9] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 9] as Excel.Range).Value;
                C4 = (usedRange.Cells[36, 10] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 10] as Excel.Range).Value;
                C5 = (usedRange.Cells[36, 11] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 11] as Excel.Range).Value;
                C6 = (usedRange.Cells[36, 12] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 12] as Excel.Range).Value;
                C7 = (usedRange.Cells[36, 13] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 13] as Excel.Range).Value;
                C8 = (usedRange.Cells[36, 14] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 14] as Excel.Range).Value;
                C9 = (usedRange.Cells[36, 15] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 15] as Excel.Range).Value;
                C10 = (usedRange.Cells[36, 16] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 16] as Excel.Range).Value;
                C11 = (usedRange.Cells[36, 17] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 17] as Excel.Range).Value;
                C12 = (usedRange.Cells[36, 18] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 18] as Excel.Range).Value;
                C13 = (usedRange.Cells[36, 19] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 19] as Excel.Range).Value;
                C14 = (usedRange.Cells[36, 20] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 20] as Excel.Range).Value;
                C15 = (usedRange.Cells[36, 21] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 21] as Excel.Range).Value;
                C16 = (usedRange.Cells[36, 22] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 22] as Excel.Range).Value;
                C17 = (usedRange.Cells[36, 23] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 23] as Excel.Range).Value;
                C18 = (usedRange.Cells[36, 24] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 24] as Excel.Range).Value;
                C19 = (usedRange.Cells[36, 25] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 25] as Excel.Range).Value;
                C20 = (usedRange.Cells[36, 26] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 26] as Excel.Range).Value;
                C21 = (usedRange.Cells[36, 27] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 27] as Excel.Range).Value;
                C22 = (usedRange.Cells[36, 28] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 28] as Excel.Range).Value;
                C23 = (usedRange.Cells[36, 29] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 29] as Excel.Range).Value;
                C24 = (usedRange.Cells[36, 30] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 30] as Excel.Range).Value;
                C25 = (usedRange.Cells[36, 31] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 31] as Excel.Range).Value;
                C26 = (usedRange.Cells[36, 32] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 32] as Excel.Range).Value;
                C27 = (usedRange.Cells[36, 33] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 33] as Excel.Range).Value;
                C28 = (usedRange.Cells[36, 34] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 34] as Excel.Range).Value;
                C29 = (usedRange.Cells[36, 35] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 35] as Excel.Range).Value;
                C30 = (usedRange.Cells[36, 36] as Excel.Range).Value == null ? 0 : (usedRange.Cells[36, 36] as Excel.Range).Value;


                dr = dt.NewRow();
                dr["Types"] = Types;
                dr["Plan_Date"] = Plan_Date;
                dr["Part_No"] = Part_No;
                //dr["Part_Name"] = Part_Name;
                dr["Line_No"] = vLine;
                dr["Engine_code"] = ENG_MTO;
                dr["Total_Quantity"] = Total_Quantity;
                dr["Remark"] = Remark;
                dr["1"] = C1; dr["2"] = C2; dr["3"] = C3; dr["4"] = C4; dr["5"] = C5;
                dr["6"] = C6; dr["7"] = C7; dr["8"] = C8; dr["9"] = C9; dr["10"] = C10;
                dr["11"] = C11; dr["12"] = C12; dr["13"] = C13; dr["14"] = C14; dr["15"] = C15;
                dr["16"] = C16; dr["17"] = C17; dr["18"] = C18; dr["19"] = C19; dr["20"] = C20;
                dr["21"] = C21; dr["22"] = C22; dr["23"] = C23; dr["24"] = C24; dr["25"] = C25;
                dr["26"] = C26; dr["27"] = C27; dr["28"] = C28; dr["29"] = C29; dr["30"] = C30;
                dt.Rows.Add(dr);

                ViewState["gdvDetail"] = dt;
                gdvDetail.DataSource = dt;
                gdvDetail.DataBind();
                gdvDetail.Columns[1].Visible = false;
                gdvDetail.Columns[67].Visible = false;
                gdvDetail.Columns[68].Visible = false;
                gdvDetail.Columns[69].Visible = false;
                gdvDetail.Columns[70].Visible = false;
                gdvDetail.Columns[71].Visible = false;
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
        private void MCCKD_Import(string filePath)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Open(filePath, Type.Missing, false, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            Excel._Worksheet worksheet = workbook.Sheets[1];
            Excel.Range usedRange = worksheet.UsedRange;
            //System.Data.DataTable dt = new System.Data.DataTable();
            EditGridView(out dt);

            try
            {
                int MCCKDRows = 9;
                string Types = "MCCKD";
                string Plan_Date = Convert.ToString((usedRange.Cells[5, 15] as Excel.Range).Value);

                for (int i = MCCKDRows; i < usedRange.Rows.Count; i++)
                {
                    if ((usedRange.Cells[i, 1] as Range).Value != null)
                    {
                        var DEL_N2 = Convert.ToString((usedRange.Cells[i, 1] as Excel.Range).Value);
                        //var TRIP = Convert.ToString((usedRange.Cells[i, 2] as Excel.Range).Value);
                        var Vendor = Convert.ToString((usedRange.Cells[i, 3] as Excel.Range).Value);
                        var DIST = Convert.ToString((usedRange.Cells[i, 4] as Excel.Range).Value);
                        var MODEL = Convert.ToString((usedRange.Cells[i, 5] as Excel.Range).Value);
                        var QTY = Convert.ToString((usedRange.Cells[i, 6] as Excel.Range).Value);
                        var PC_NO = Convert.ToString((usedRange.Cells[i, 7] as Excel.Range).Value);
                        var BLOCK = Convert.ToString((usedRange.Cells[i, 8] as Excel.Range).Value);
                        var HEAD = Convert.ToString((usedRange.Cells[i, 9] as Excel.Range).Value);
                        var VAN_ORIGINAL = Convert.ToString((usedRange.Cells[i, 12] as Excel.Range).Value);
                        var CY_CUT = Convert.ToString((usedRange.Cells[i, 13] as Excel.Range).Value);
                        var TIME_ICD = Convert.ToString((usedRange.Cells[i, 14] as Excel.Range).Value);
                        var ETD = Convert.ToString((usedRange.Cells[i, 15] as Excel.Range).Value);
                        var VESSEL = Convert.ToString((usedRange.Cells[i, 16] as Excel.Range).Value);
                        var REMARK = Convert.ToString((usedRange.Cells[i, 17] as Excel.Range).Value);

                        DataRow dr = dt.NewRow();
                        dr["Types"] = Types;
                        dr["Plan_Date"] = Plan_Date;
                        dr["Del_N_2"] = DEL_N2;
                        dr["Vendor"] = Vendor;
                        dr["Dist"] = DIST;
                        dr["Model"] = MODEL;
                        dr["Total_Quantity"] = QTY;
                        dr["PC_No"] = PC_NO;
                        dr["Block_Qty"] = BLOCK;
                        dr["Head_Qty"] = HEAD;
                        dr["Van_Original"] = VAN_ORIGINAL;
                        dr["Cy_Cut"] = CY_CUT;
                        dr["Time_Icd"] = TIME_ICD;
                        dr["ETD"] = ETD;
                        dr["Vessel"] = VESSEL;
                        dr["REMARK"] = REMARK;
                        dt.Rows.Add(dr);
                    }
                }
                ViewState["gdvDetail"] = dt;
                gdvDetail.DataSource = dt;
                gdvDetail.DataBind();
                gdvDetail.Columns[1].Visible = false;
                gdvDetail.Columns[67].Visible = false;
                gdvDetail.Columns[68].Visible = false;
                gdvDetail.Columns[69].Visible = false;
                gdvDetail.Columns[70].Visible = false;
                gdvDetail.Columns[71].Visible = false;

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
        private void FE_Import(string filePath)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Open(filePath, Type.Missing, false, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            Excel._Worksheet worksheet = workbook.Sheets[1];
            Excel.Range usedRange = worksheet.UsedRange;
            //System.Data.DataTable dt = new System.Data.DataTable();
            EditGridView(out dt);

            try
            {
                int FECrankshaftRows = 18;
                int FEConnRodRows = 29;
                string Types = "FE";
                string Plan_Date = Convert.ToString((usedRange.Cells[4, 15] as Excel.Range).Value);

                for (int i = FECrankshaftRows; i < FECrankshaftRows + 5; i++)
                {
                    if ((usedRange.Cells[i, 2] as Range).Value != null)
                    {
                        var Model = Convert.ToString((usedRange.Cells[i, 2] as Excel.Range).Value);
                        var Part_No = Convert.ToString((usedRange.Cells[i, 4] as Excel.Range).Value);
                        //var Part_Name = Convert.ToString((usedRange.Cells[i, 7] as Excel.Range).Value);
                        var Total_Quantity = Convert.ToString((usedRange.Cells[i, 41] as Excel.Range).Value);
                        var Remark = Convert.ToString((usedRange.Cells[i, 42] as Excel.Range).Value);
                        var C1 = (usedRange.Cells[i, 10] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 10] as Excel.Range).Value;
                        var C2 = (usedRange.Cells[i, 11] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 11] as Excel.Range).Value;
                        var C3 = (usedRange.Cells[i, 12] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 12] as Excel.Range).Value;
                        var C4 = (usedRange.Cells[i, 13] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 13] as Excel.Range).Value;
                        var C5 = (usedRange.Cells[i, 14] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 14] as Excel.Range).Value;
                        var C6 = (usedRange.Cells[i, 15] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 15] as Excel.Range).Value;
                        var C7 = (usedRange.Cells[i, 16] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 16] as Excel.Range).Value;
                        var C8 = (usedRange.Cells[i, 17] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 17] as Excel.Range).Value;
                        var C9 = (usedRange.Cells[i, 18] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 18] as Excel.Range).Value;
                        var C10 = (usedRange.Cells[i, 19] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 19] as Excel.Range).Value;
                        var C11 = (usedRange.Cells[i, 20] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 20] as Excel.Range).Value;
                        var C12 = (usedRange.Cells[i, 21] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 21] as Excel.Range).Value;
                        var C13 = (usedRange.Cells[i, 22] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 22] as Excel.Range).Value;
                        var C14 = (usedRange.Cells[i, 23] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 23] as Excel.Range).Value;
                        var C15 = (usedRange.Cells[i, 24] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 24] as Excel.Range).Value;
                        var C16 = (usedRange.Cells[i, 25] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 25] as Excel.Range).Value;
                        var C17 = (usedRange.Cells[i, 26] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 26] as Excel.Range).Value;
                        var C18 = (usedRange.Cells[i, 27] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 27] as Excel.Range).Value;
                        var C19 = (usedRange.Cells[i, 28] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 28] as Excel.Range).Value;
                        var C20 = (usedRange.Cells[i, 29] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 29] as Excel.Range).Value;
                        var C21 = (usedRange.Cells[i, 30] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 30] as Excel.Range).Value;
                        var C22 = (usedRange.Cells[i, 31] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 31] as Excel.Range).Value;
                        var C23 = (usedRange.Cells[i, 32] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 32] as Excel.Range).Value;
                        var C24 = (usedRange.Cells[i, 33] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 33] as Excel.Range).Value;
                        var C25 = (usedRange.Cells[i, 34] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 34] as Excel.Range).Value;
                        var C26 = (usedRange.Cells[i, 35] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 35] as Excel.Range).Value;
                        var C27 = (usedRange.Cells[i, 36] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 36] as Excel.Range).Value;
                        var C28 = (usedRange.Cells[i, 37] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 37] as Excel.Range).Value;
                        var C29 = (usedRange.Cells[i, 38] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 38] as Excel.Range).Value;
                        var C30 = (usedRange.Cells[i, 39] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 39] as Excel.Range).Value;
                        //var C1 = Convert.ToString((usedRange.Cells[i, 10] as Excel.Range).Value); var C2 = Convert.ToString((usedRange.Cells[i, 11] as Excel.Range).Value);
                        //var C3 = Convert.ToString((usedRange.Cells[i, 12] as Excel.Range).Value); var C4 = Convert.ToString((usedRange.Cells[i, 13] as Excel.Range).Value);
                        //var C5 = Convert.ToString((usedRange.Cells[i, 14] as Excel.Range).Value); var C6 = Convert.ToString((usedRange.Cells[i, 15] as Excel.Range).Value);
                        //var C7 = Convert.ToString((usedRange.Cells[i, 16] as Excel.Range).Value); var C8 = Convert.ToString((usedRange.Cells[i, 17] as Excel.Range).Value);
                        //var C9 = Convert.ToString((usedRange.Cells[i, 18] as Excel.Range).Value); var C10 = Convert.ToString((usedRange.Cells[i, 19] as Excel.Range).Value);
                        //var C11 = Convert.ToString((usedRange.Cells[i, 20] as Excel.Range).Value); var C12 = Convert.ToString((usedRange.Cells[i, 21] as Excel.Range).Value);
                        //var C13 = Convert.ToString((usedRange.Cells[i, 22] as Excel.Range).Value); var C14 = Convert.ToString((usedRange.Cells[i, 23] as Excel.Range).Value);
                        //var C15 = Convert.ToString((usedRange.Cells[i, 24] as Excel.Range).Value); var C16 = Convert.ToString((usedRange.Cells[i, 25] as Excel.Range).Value);
                        //var C17 = Convert.ToString((usedRange.Cells[i, 26] as Excel.Range).Value); var C18 = Convert.ToString((usedRange.Cells[i, 27] as Excel.Range).Value);
                        //var C19 = Convert.ToString((usedRange.Cells[i, 28] as Excel.Range).Value); var C20 = Convert.ToString((usedRange.Cells[i, 29] as Excel.Range).Value);
                        //var C21 = Convert.ToString((usedRange.Cells[i, 30] as Excel.Range).Value); var C22 = Convert.ToString((usedRange.Cells[i, 31] as Excel.Range).Value);
                        //var C23 = Convert.ToString((usedRange.Cells[i, 32] as Excel.Range).Value); var C24 = Convert.ToString((usedRange.Cells[i, 33] as Excel.Range).Value);
                        //var C25 = Convert.ToString((usedRange.Cells[i, 34] as Excel.Range).Value); var C26 = Convert.ToString((usedRange.Cells[i, 35] as Excel.Range).Value);
                        //var C27 = Convert.ToString((usedRange.Cells[i, 36] as Excel.Range).Value); var C28 = Convert.ToString((usedRange.Cells[i, 37] as Excel.Range).Value);
                        //var C29 = Convert.ToString((usedRange.Cells[i, 38] as Excel.Range).Value); var C30 = Convert.ToString((usedRange.Cells[i, 39] as Excel.Range).Value);
                        DataRow dr = dt.NewRow();
                        dr["Types"] = Types;
                        dr["Plan_Date"] = Plan_Date;
                        dr["Model"] = Model;
                        dr["Part_No"] = Part_No;
                        dr["Total_Quantity"] = Total_Quantity;
                        dr["Remark"] = Remark;
                        dr["1"] = C1; dr["2"] = C2; dr["3"] = C3; dr["4"] = C4; dr["5"] = C5;
                        dr["6"] = C6; dr["7"] = C7; dr["8"] = C8; dr["9"] = C9; dr["10"] = C10;
                        dr["11"] = C11; dr["12"] = C12; dr["13"] = C13; dr["14"] = C14; dr["15"] = C15;
                        dr["16"] = C16; dr["17"] = C17; dr["18"] = C18; dr["19"] = C19; dr["20"] = C20;
                        dr["21"] = C21; dr["22"] = C22; dr["23"] = C23; dr["24"] = C24; dr["25"] = C25;
                        dr["26"] = C26; dr["27"] = C27; dr["28"] = C28; dr["29"] = C29; dr["30"] = C30;
                        dt.Rows.Add(dr);
                    }
                }

                for (int i = FEConnRodRows; i < FEConnRodRows + 5; i++)
                {
                    if ((usedRange.Cells[i, 2] as Range).Value != null)
                    {
                        var Model = Convert.ToString((usedRange.Cells[i, 2] as Excel.Range).Value);
                        var Part_No = Convert.ToString((usedRange.Cells[i, 4] as Excel.Range).Value);
                        //var Part_Name = Convert.ToString((usedRange.Cells[i, 7] as Excel.Range).Value);
                        var Total_Quantity = Convert.ToString((usedRange.Cells[i, 41] as Excel.Range).Value);
                        var Remark = Convert.ToString((usedRange.Cells[i, 42] as Excel.Range).Value); /*+ Convert.ToString((usedRange.Cells[i, 43] as Excel.Range).Value) + Convert.ToString((usedRange.Cells[i, 44] as Excel.Range).Value)*/
                        var C1 = (usedRange.Cells[i, 10] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 10] as Excel.Range).Value;
                        var C2 = (usedRange.Cells[i, 11] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 11] as Excel.Range).Value;
                        var C3 = (usedRange.Cells[i, 12] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 12] as Excel.Range).Value;
                        var C4 = (usedRange.Cells[i, 13] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 13] as Excel.Range).Value;
                        var C5 = (usedRange.Cells[i, 14] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 14] as Excel.Range).Value;
                        var C6 = (usedRange.Cells[i, 15] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 15] as Excel.Range).Value;
                        var C7 = (usedRange.Cells[i, 16] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 16] as Excel.Range).Value;
                        var C8 = (usedRange.Cells[i, 17] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 17] as Excel.Range).Value;
                        var C9 = (usedRange.Cells[i, 18] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 18] as Excel.Range).Value;
                        var C10 = (usedRange.Cells[i, 19] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 19] as Excel.Range).Value;
                        var C11 = (usedRange.Cells[i, 20] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 20] as Excel.Range).Value;
                        var C12 = (usedRange.Cells[i, 21] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 21] as Excel.Range).Value;
                        var C13 = (usedRange.Cells[i, 22] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 22] as Excel.Range).Value;
                        var C14 = (usedRange.Cells[i, 23] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 23] as Excel.Range).Value;
                        var C15 = (usedRange.Cells[i, 24] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 24] as Excel.Range).Value;
                        var C16 = (usedRange.Cells[i, 25] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 25] as Excel.Range).Value;
                        var C17 = (usedRange.Cells[i, 26] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 26] as Excel.Range).Value;
                        var C18 = (usedRange.Cells[i, 27] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 27] as Excel.Range).Value;
                        var C19 = (usedRange.Cells[i, 28] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 28] as Excel.Range).Value;
                        var C20 = (usedRange.Cells[i, 29] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 29] as Excel.Range).Value;
                        var C21 = (usedRange.Cells[i, 30] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 30] as Excel.Range).Value;
                        var C22 = (usedRange.Cells[i, 31] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 31] as Excel.Range).Value;
                        var C23 = (usedRange.Cells[i, 32] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 32] as Excel.Range).Value;
                        var C24 = (usedRange.Cells[i, 33] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 33] as Excel.Range).Value;
                        var C25 = (usedRange.Cells[i, 34] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 34] as Excel.Range).Value;
                        var C26 = (usedRange.Cells[i, 35] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 35] as Excel.Range).Value;
                        var C27 = (usedRange.Cells[i, 36] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 36] as Excel.Range).Value;
                        var C28 = (usedRange.Cells[i, 37] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 37] as Excel.Range).Value;
                        var C29 = (usedRange.Cells[i, 38] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 38] as Excel.Range).Value;
                        var C30 = (usedRange.Cells[i, 39] as Excel.Range).Value == null ? null : (usedRange.Cells[i, 39] as Excel.Range).Value;

                        DataRow dr = dt.NewRow();
                        dr["Types"] = Types;
                        dr["Plan_Date"] = Plan_Date;
                        dr["Model"] = Model;
                        dr["Part_No"] = Part_No;
                        dr["Total_Quantity"] = Total_Quantity;
                        dr["Remark"] = Remark;
                        dr["1"] = C1; dr["2"] = C2; dr["3"] = C3; dr["4"] = C4; dr["5"] = C5;
                        dr["6"] = C6; dr["7"] = C7; dr["8"] = C8; dr["9"] = C9; dr["10"] = C10;
                        dr["11"] = C11; dr["12"] = C12; dr["13"] = C13; dr["14"] = C14; dr["15"] = C15;
                        dr["16"] = C16; dr["17"] = C17; dr["18"] = C18; dr["19"] = C19; dr["20"] = C20;
                        dr["21"] = C21; dr["22"] = C22; dr["23"] = C23; dr["24"] = C24; dr["25"] = C25;
                        dr["26"] = C26; dr["27"] = C27; dr["28"] = C28; dr["29"] = C29; dr["30"] = C30;
                        dt.Rows.Add(dr);
                    }
                }
                ViewState["gdvDetail"] = dt;
                gdvDetail.DataSource = dt;
                gdvDetail.DataBind();
                gdvDetail.Columns[1].Visible = false;
                gdvDetail.Columns[67].Visible = false;
                gdvDetail.Columns[68].Visible = false;
                gdvDetail.Columns[69].Visible = false;
                gdvDetail.Columns[70].Visible = false;
                gdvDetail.Columns[71].Visible = false;
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
        private void FECKD_Import(string filePath)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Open(filePath, Type.Missing, false, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            Excel._Worksheet worksheet = workbook.Sheets[1];
            Excel.Range usedRange = worksheet.UsedRange;
            //System.Data.DataTable dt = new System.Data.DataTable();
            EditGridView(out dt);

            try
            {
                int FECKDRows = 9;
                string Types = "FECKD";
                string Plan_Date = Convert.ToString((usedRange.Cells[5, 14] as Excel.Range).Value);
                for (int i = FECKDRows; i < usedRange.Rows.Count; i++)
                {
                    if ((usedRange.Cells[i, 1] as Range).Value != null)
                    {
                        var DEL_N2 = Convert.ToString((usedRange.Cells[i, 1] as Excel.Range).Value);
                        var Vendor = Convert.ToString((usedRange.Cells[i, 3] as Excel.Range).Value);
                        var DIST = Convert.ToString((usedRange.Cells[i, 4] as Excel.Range).Value);
                        var MODEL = Convert.ToString((usedRange.Cells[i, 5] as Excel.Range).Value);
                        var QTY = Convert.ToString((usedRange.Cells[i, 6] as Excel.Range).Value);
                        var PC_NO = Convert.ToString((usedRange.Cells[i, 7] as Excel.Range).Value);
                        var VAN_ORIGINAL = Convert.ToString((usedRange.Cells[i, 11] as Excel.Range).Value);
                        var CY_CUT = Convert.ToString((usedRange.Cells[i, 12] as Excel.Range).Value);
                        var TIME_ICD = Convert.ToString((usedRange.Cells[i, 13] as Excel.Range).Value);
                        var ETD = Convert.ToString((usedRange.Cells[i, 14] as Excel.Range).Value);
                        var VESSEL = Convert.ToString((usedRange.Cells[i, 15] as Excel.Range).Value);
                        var REMARK = Convert.ToString((usedRange.Cells[i, 16] as Excel.Range).Value);

                        DataRow dr = dt.NewRow();
                        dr["Types"] = Types;
                        dr["Plan_Date"] = Plan_Date;
                        dr["Del_N_2"] = DEL_N2;
                        //dr["TRIP"] = TRIP;
                        dr["Vendor"] = Vendor;
                        dr["Dist"] = DIST;
                        dr["Model"] = MODEL;
                        dr["Total_Quantity"] = QTY;
                        dr["PC_No"] = PC_NO;
                        dr["Van_Original"] = VAN_ORIGINAL;
                        dr["Cy_Cut"] = CY_CUT;
                        dr["Time_Icd"] = TIME_ICD;
                        dr["ETD"] = ETD;
                        dr["Vessel"] = VESSEL;
                        dr["REMARK"] = REMARK;
                        dt.Rows.Add(dr);
                    }
                }
                ViewState["gdvDetail"] = dt;
                gdvDetail.DataSource = dt;
                gdvDetail.DataBind();
                gdvDetail.Columns[1].Visible = false;
                gdvDetail.Columns[67].Visible = false;
                gdvDetail.Columns[68].Visible = false;
                gdvDetail.Columns[69].Visible = false;
                gdvDetail.Columns[70].Visible = false;
                gdvDetail.Columns[71].Visible = false;
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
        private void KD_Import(string filePath)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Open(filePath, Type.Missing, false, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            Excel._Worksheet worksheet = workbook.Sheets[1];
            Excel.Range usedRange = worksheet.UsedRange;
            Excel._Worksheet worksheet1 = workbook.Sheets[2];
            Excel.Range usedRange1 = worksheet1.UsedRange;
            //System.Data.DataTable dt = new System.Data.DataTable();
            EditGridView(out dt);
            try
            {
                int KDRows = 4;
                //int MCCKDColumn = 0;
                string Types = "KD";
                string Plan_Date = Convert.ToString((usedRange.Cells[14, 3] as Excel.Range).Value);
                var ORDER_NO = Convert.ToString((usedRange.Cells[11, 3] as Excel.Range).Value);
                var ORDER_DATE = Convert.ToString((usedRange.Cells[14, 3] as Excel.Range).Value);
                var PC_NO = Convert.ToString((usedRange.Cells[5, 14] as Excel.Range).Value);
                var PART_DELIVERY = Convert.ToString((usedRange.Cells[11, 14] as Excel.Range).Value);
                var PACKING_DATE = Convert.ToString((usedRange.Cells[14, 14] as Excel.Range).Value);
                var PACKING_LIST_TO_IB = Convert.ToString((usedRange.Cells[17, 14] as Excel.Range).Value);
                var ETD_DATE = Convert.ToString((usedRange.Cells[20, 14] as Excel.Range).Value);
                var ETA_DATE = Convert.ToString((usedRange.Cells[24, 14] as Excel.Range).Value);
                var SHIP_BY = Convert.ToString((usedRange.Cells[28, 14] as Excel.Range).Value);
                var RTA = Convert.ToString((usedRange.Cells[28, 3] as Excel.Range).Value);
                var ISSUE_DATE = Convert.ToString((usedRange.Cells[3, 23] as Excel.Range).Value);
                var Model_Code = Convert.ToString((usedRange.Cells[6, 26] as Excel.Range).Value);
                var Model_Type = Convert.ToString((usedRange.Cells[8, 26] as Excel.Range).Value);
                var ISSUE_BY = Convert.ToString((usedRange.Cells[28, 8] as Excel.Range).Value);
                var Remark = Convert.ToString((usedRange.Cells[5, 21] as Excel.Range).Value);
                for (int i = KDRows; i < usedRange1.Rows.Count - 1; i++)
                {
                    var ENDDATA = Convert.ToString((usedRange1.Cells[i, 2] as Excel.Range).Value);
                    if (ENDDATA != "END DATA")
                    {
                        var PART_NO = Convert.ToString((usedRange1.Cells[i, 2] as Excel.Range).Value);
                        var PART_NAME = Convert.ToString((usedRange1.Cells[i, 3] as Excel.Range).Value);
                        var COLOR = Convert.ToString((usedRange1.Cells[i, 4] as Excel.Range).Value);
                        var FG_QTY = Convert.ToString((usedRange1.Cells[i, 5] as Excel.Range).Value);
                        var vFrom = Convert.ToString((usedRange1.Cells[i, 6] as Excel.Range).Value);
                        var vTo = Convert.ToString((usedRange1.Cells[i, 7] as Excel.Range).Value);
                        var PLAN_CODE = Convert.ToString((usedRange1.Cells[i, 8] as Excel.Range).Value);
                        var Requistion_No = Convert.ToString((usedRange1.Cells[i, 9] as Excel.Range).Value);

                        DataRow dr = dt.NewRow();
                        dr["Types"] = Types;
                        dr["Plan_Date"] = Plan_Date;
                        dr["Part_No"] = PART_NO;
                        dr["Order_No"] = ORDER_NO;
                        dr["Order_Date"] = ORDER_DATE;
                        dr["PC_No"] = PC_NO;
                        dr["Part_Delivery"] = PART_DELIVERY;
                        dr["Packing_Date"] = PACKING_DATE;
                        dr["Packing_List_To_Ib"] = PACKING_LIST_TO_IB;
                        dr["ETD_Date"] = ETD_DATE;
                        dr["ETA_Date"] = ETA_DATE;
                        dr["Ship_By"] = SHIP_BY;
                        dr["RTA"] = RTA;
                        dr["Issue_Date"] = ISSUE_DATE;
                        dr["Model"] = Model_Code;
                        dr["Model_Type"] = Model_Type;
                        dr["Issue_By"] = ISSUE_BY;
                        dr["Remark"] = Remark;
                        dr["Part_No"] = PART_NO;
                        //dr["PART_NAME"] = PART_NAME;
                        dr["Color"] = COLOR;
                        dr["FG_Qty"] = FG_QTY;
                        dr["Del_From"] = vFrom;
                        dr["Del_To"] = vTo;
                        dr["Plan_Code"] = PLAN_CODE;
                        dr["Req_No"] = Requistion_No;
                        dt.Rows.Add(dr);
                    }
                }
                ViewState["gdvDetail"] = dt;
                gdvDetail.DataSource = dt;
                gdvDetail.DataBind();
                gdvDetail.Columns[1].Visible = false;
                gdvDetail.Columns[67].Visible = false;
                gdvDetail.Columns[68].Visible = false;
                gdvDetail.Columns[69].Visible = false;
                gdvDetail.Columns[70].Visible = false;
                gdvDetail.Columns[71].Visible = false;
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
        private void SPECPART_Import(string filePath)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Open(filePath, Type.Missing, false, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            Excel._Worksheet worksheet = workbook.Sheets[1];
            Excel.Range usedRange = worksheet.UsedRange;
            //System.Data.DataTable dt = new System.Data.DataTable();
            EditGridView(out dt);
            int[] SPRows = new int[10];
            int[] SPRowsMAX = new int[10];
            SPRows[1] = 26;
            SPRows[2] = 127;
            SPRows[3] = 234;
            SPRows[4] = 340;
            SPRows[5] = 447;
            SPRows[6] = 603;
            SPRows[7] = 759;
            SPRows[8] = 916;
            SPRows[9] = 1022;
            SPRowsMAX[1] = 30;
            SPRowsMAX[2] = 8;
            SPRowsMAX[3] = 52;
            SPRowsMAX[4] = 29;
            SPRowsMAX[5] = 70;
            SPRowsMAX[6] = 62;
            SPRowsMAX[7] = 45;
            SPRowsMAX[8] = 29;
            SPRowsMAX[9] = 19;

            string Types = "Special Part";
            string dateString = Convert.ToString((usedRange.Cells[3, 35] as Excel.Range).Value);
            dateString = dateString.Substring(33).ToString();
            DateTime monthYear = DateTime.ParseExact(dateString, "MMM yyyy", new CultureInfo("en-us"));
            string Plan_Date = Convert.ToString(dateString);
            for (int j = 1; j < 10; j++)
            {
                for (int i = SPRows[j]; i < SPRows[j] + SPRowsMAX[j]; i++)
                {
                    if ((usedRange.Cells[i, 3] as Range).Value != null)
                    {
                        var Part_No = Convert.ToString((usedRange.Cells[i, 3] as Excel.Range).Value);
                        //var Part_Name = Convert.ToString((usedRange.Cells[i, 7] as Excel.Range).Value);
                        var Model = Convert.ToString((usedRange.Cells[i, 11] as Excel.Range).Value);
                        var ORDER = Convert.ToString((usedRange.Cells[i, 14] as Excel.Range).Value);
                        var DIFF = Convert.ToString((usedRange.Cells[i, 15] as Excel.Range).Value);
                        var SEMI_FIXED_FIRST = Convert.ToString((usedRange.Cells[i, 48] as Excel.Range).Value);
                        var SEMI_FIXED_SECOND = Convert.ToString((usedRange.Cells[i, 49] as Excel.Range).Value);
                        var Total_Quantity = Convert.ToString((usedRange.Cells[i, 47] as Excel.Range).Value);
                        var C1 = Convert.ToString((usedRange.Cells[i, 16] as Excel.Range).Value); var C2 = Convert.ToString((usedRange.Cells[i, 17] as Excel.Range).Value);
                        var C3 = Convert.ToString((usedRange.Cells[i, 18] as Excel.Range).Value); var C4 = Convert.ToString((usedRange.Cells[i, 19] as Excel.Range).Value);
                        var C5 = Convert.ToString((usedRange.Cells[i, 20] as Excel.Range).Value); var C6 = Convert.ToString((usedRange.Cells[i, 21] as Excel.Range).Value);
                        var C7 = Convert.ToString((usedRange.Cells[i, 22] as Excel.Range).Value); var C8 = Convert.ToString((usedRange.Cells[i, 23] as Excel.Range).Value);
                        var C9 = Convert.ToString((usedRange.Cells[i, 24] as Excel.Range).Value); var C10 = Convert.ToString((usedRange.Cells[i, 25] as Excel.Range).Value);
                        var C11 = Convert.ToString((usedRange.Cells[i, 26] as Excel.Range).Value); var C12 = Convert.ToString((usedRange.Cells[i, 27] as Excel.Range).Value);
                        var C13 = Convert.ToString((usedRange.Cells[i, 28] as Excel.Range).Value); var C14 = Convert.ToString((usedRange.Cells[i, 29] as Excel.Range).Value);
                        var C15 = Convert.ToString((usedRange.Cells[i, 30] as Excel.Range).Value); var C16 = Convert.ToString((usedRange.Cells[i, 31] as Excel.Range).Value);
                        var C17 = Convert.ToString((usedRange.Cells[i, 32] as Excel.Range).Value); var C18 = Convert.ToString((usedRange.Cells[i, 33] as Excel.Range).Value);
                        var C19 = Convert.ToString((usedRange.Cells[i, 34] as Excel.Range).Value); var C20 = Convert.ToString((usedRange.Cells[i, 35] as Excel.Range).Value);
                        var C21 = Convert.ToString((usedRange.Cells[i, 36] as Excel.Range).Value); var C22 = Convert.ToString((usedRange.Cells[i, 37] as Excel.Range).Value);
                        var C23 = Convert.ToString((usedRange.Cells[i, 38] as Excel.Range).Value); var C24 = Convert.ToString((usedRange.Cells[i, 39] as Excel.Range).Value);
                        var C25 = Convert.ToString((usedRange.Cells[i, 40] as Excel.Range).Value); var C26 = Convert.ToString((usedRange.Cells[i, 41] as Excel.Range).Value);
                        var C27 = Convert.ToString((usedRange.Cells[i, 42] as Excel.Range).Value); var C28 = Convert.ToString((usedRange.Cells[i, 43] as Excel.Range).Value);
                        var C29 = Convert.ToString((usedRange.Cells[i, 44] as Excel.Range).Value); var C30 = Convert.ToString((usedRange.Cells[i, 45] as Excel.Range).Value);
                        var C31 = Convert.ToString((usedRange.Cells[i, 46] as Excel.Range).Value);

                        DataRow dr = dt.NewRow();
                        dr["Types"] = Types;
                        dr["Plan_Date"] = Plan_Date;
                        dr["Part_No"] = Part_No;
                        //dr["Part_Name"] = Part_Name;
                        dr["Model"] = Model;
                        dr["ORDER"] = ORDER;
                        dr["DIFF"] = DIFF;
                        dr["SEMI_FIXED_FIRST"] = SEMI_FIXED_FIRST;
                        dr["SEMI_FIXED_SECOND"] = SEMI_FIXED_SECOND;
                        dr["Total_Quantity"] = Total_Quantity;
                        dr["1"] = C1; dr["2"] = C2; dr["3"] = C3; dr["4"] = C4; dr["5"] = C5;
                        dr["6"] = C6; dr["7"] = C7; dr["8"] = C8; dr["9"] = C9; dr["10"] = C10;
                        dr["11"] = C11; dr["12"] = C12; dr["13"] = C13; dr["14"] = C14; dr["15"] = C15;
                        dr["16"] = C16; dr["17"] = C17; dr["18"] = C18; dr["19"] = C19; dr["20"] = C20;
                        dr["21"] = C21; dr["22"] = C22; dr["23"] = C23; dr["24"] = C24; dr["25"] = C25;
                        dr["26"] = C26; dr["27"] = C27; dr["28"] = C28; dr["29"] = C29; dr["30"] = C30;
                        dr["31"] = C31;
                        dt.Rows.Add(dr);
                    }
                }
            }

            ViewState["gdvDetail"] = dt;
            gdvDetail.DataSource = dt;
            gdvDetail.DataBind();
            gdvDetail.Columns[1].Visible = false;
            gdvDetail.Columns[67].Visible = false;
            gdvDetail.Columns[68].Visible = false;
            gdvDetail.Columns[69].Visible = false;
            gdvDetail.Columns[70].Visible = false;
            gdvDetail.Columns[71].Visible = false;
            FormControlEnable();
            excel.Quit();
            excel = null;
            KillProcess("EXCEL");
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

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            
            int rtn = 0;
            int linecnt = 0;
            string rtnHEADNO = this.ddlOrderNo.Text.ToString();
            DataSet ds = new DataSet();
            ComLibrary comlb = new ComLibrary();
            MCImport mc1 = new MCImport(g_user_id, g_lang);
            MCCKDImport mcckd1 = new MCCKDImport(g_user_id, g_lang);
            FEImport fe1 = new FEImport(g_user_id, g_lang);
            FECKDImport feckd1 = new FECKDImport(g_user_id, g_lang);
            KDImport kd1 = new KDImport(g_user_id, g_lang);
            SPImport sp1 = new SPImport(g_user_id, g_lang);
            switch (ddlTYPE.Text.ToString())
            {
                case "MC":
                        mc1.year = Convert.ToInt32(ddlYear.Text);
                        mc1.month = Convert.ToInt32(ddlMonth.Text);
                        rtn = 0;
                        rtn = mc1.HeadUpdate();

                        if (rtn == ComConst.FAILED)
                        {
                            lblMsg.Text = mc1.strErr;
                            lblMsg.ForeColor = Color.Red;
                            return;
                        }
                    ds = mc1.GetOrder(mc1.year,mc1.month);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        mc1.mc_prod_no= ds.Tables[0].Rows[i]["HEAD_NO"].ToString();
                        rtn = 0;
                        mc1.Delete();

                        if (rtn == ComConst.FAILED)
                        {
                            lblMsg.Text = mcckd1.strErr;
                            lblMsg.ForeColor = Color.Red;
                            return;
                        }
                        for (int j = 1; j < 31; j++)
                        {
                            if (dt.Rows[i]["" + j + ""].ToString().Trim() != "0")
                            {
                                linecnt += 1;
                                mc1.mc_prod_no = ds.Tables[0].Rows[i]["HEAD_NO"].ToString();
                                mc1.mc_line_no = linecnt;
                                mc1.part_no = dt.Rows[i]["Part_No"].ToString();
                                //mc1.type_part = "";
                                mc1.production_plan_date = DateTime.ParseExact(mc1.year + mc1.month.ToString().PadLeft(2, '0') + j.ToString().PadLeft(2, '0'), "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
                                mc1.plan_qty = Convert.ToInt32(dt.Rows[i]["" + j + ""].ToString());

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
                    }
                    lblMsg.Text = "Updated normally.";
                    lblMsg.ForeColor = Color.Blue;
                    break;
                case "MC CKD":
                    mcckd1.mc_ckd_no = rtnHEADNO;
                    mcckd1.year = Convert.ToInt32(Convert.ToDateTime(dt.Rows[0]["Plan_Date"]).Year);
                    mcckd1.month = Convert.ToInt32(Convert.ToDateTime(dt.Rows[0]["Plan_Date"]).Month);
                    //mcckd1.version = 0;


                    rtn = 0;
                    rtn = mcckd1.HeadUpdate();

                    if (rtn == ComConst.FAILED)
                    {
                        lblMsg.Text = mcckd1.strErr;
                        lblMsg.ForeColor = Color.Red;
                        return;
                    }

                    rtn = 0;
                    mcckd1.Delete();

                    if (rtn == ComConst.FAILED)
                    {
                        lblMsg.Text = mcckd1.strErr;
                        lblMsg.ForeColor = Color.Red;
                        return;
                    }
                    for (int j = 1; j < dt.Rows.Count; j++)
                    {
                        mcckd1.mc_ckd_no = rtnHEADNO;
                        mcckd1.mc_ckd_line = j;
                        mcckd1.mc_del_n_2 = Convert.ToDateTime(dt.Rows[j]["Del_N_2"].ToString());
                        mcckd1.vendor = dt.Rows[j]["Vendor"].ToString();
                        mcckd1.dist = dt.Rows[j]["Dist"].ToString();
                        mcckd1.model = dt.Rows[j]["Model"].ToString();
                        mcckd1.qty = Convert.ToInt32(dt.Rows[j]["Total_Quantity"].ToString());
                        mcckd1.pc_no = dt.Rows[j]["PC_No"].ToString();
                        mcckd1.block_qty = Convert.ToInt32(dt.Rows[j]["Block_Qty"].ToString());
                        mcckd1.head_qty = Convert.ToInt32(dt.Rows[j]["Head_Qty"].ToString());
                        mcckd1.van_original = Convert.ToDateTime(dt.Rows[j]["Van_Original"].ToString());
                        if (dt.Rows[j]["Cy_Cut"].ToString() != "-")
                        {
                            mcckd1.cy_cut = dt.Rows[j]["Cy_Cut"].ToString();
                        }
                        else
                        {
                            mcckd1.cy_cut = null;
                        }
                        mcckd1.time_lcd = dt.Rows[j]["Time_Icd"].ToString();
                        mcckd1.etd = Convert.ToDateTime(dt.Rows[j]["ETD"].ToString());
                        mcckd1.vessel = dt.Rows[j]["Vessel"].ToString();
                        mcckd1.remark = dt.Rows[j]["Remark"].ToString();
                        mcckd1.flag = 0;

                        rtn = 0;
                        rtn = mcckd1.DetailInsert();

                        if (rtn == ComConst.FAILED)
                        {
                            lblMsg.Text = mcckd1.strErr;
                            lblMsg.ForeColor = Color.Red;
                            return;
                        }
                    }

                    lblMsg.Text = "Updated normally.";
                    lblMsg.ForeColor = Color.Blue;
                    break;
                case "FE":

                    fe1.year = Convert.ToInt32(ddlYear.Text);
                    fe1.month = Convert.ToInt32(ddlMonth.Text);
                    rtn = 0;
                    rtn = fe1.HeadUpdate();

                    if (rtn == ComConst.FAILED)
                    {
                        lblMsg.Text = fe1.strErr;
                        lblMsg.ForeColor = Color.Red;
                        return;
                    }
                        
                     ds = fe1.GetOrder(fe1.year, fe1.month);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        fe1.fe_prod_no = ds.Tables[0].Rows[i]["HEAD_NO"].ToString();
                        rtn = 0;
                        fe1.Delete();

                        if (rtn == ComConst.FAILED)
                        {
                            lblMsg.Text = mcckd1.strErr;
                            lblMsg.ForeColor = Color.Red;
                            return;
                        }
                        for (int j = 1; j < 31; j++)
                        {
                            if (dt.Rows[i]["" + j + ""].ToString().Trim() != "")
                            {
                                linecnt += 1;
                                fe1.fe_prod_no = ds.Tables[0].Rows[i]["HEAD_NO"].ToString(); 
                                fe1.fe_line_no = linecnt;
                                fe1.part_no = dt.Rows[i]["Part_No"].ToString();
                                fe1.type_part = "";
                                fe1.production_plan_date = DateTime.ParseExact(fe1.year + fe1.month.ToString().PadLeft(2, '0') + j.ToString().PadLeft(2, '0'), "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
                                fe1.plan_qty = Convert.ToInt32(dt.Rows[i]["" + j + ""].ToString());

                                rtn = 0;
                                rtn = fe1.DetailInsert();

                                if (rtn == ComConst.FAILED)
                                {
                                    lblMsg.Text = fe1.strErr;
                                    lblMsg.ForeColor = Color.Red;
                                    return;
                                }
                            }
                        }
                    }
                    lblMsg.Text = "Updated normally.";
                    lblMsg.ForeColor = Color.Blue;
                    break;
                case "FE CKD":
                    feckd1.fe_ckd_no = rtnHEADNO; 
                    feckd1.year = Convert.ToInt32(Convert.ToDateTime(dt.Rows[0]["Plan_Date"]).Year);
                    feckd1.month = Convert.ToInt32(Convert.ToDateTime(dt.Rows[0]["Plan_Date"]).Month);

                    rtn = 0;
                    rtn = feckd1.HeadUpdate();

                    if (rtn == ComConst.FAILED)
                    {
                        lblMsg.Text = feckd1.strErr;
                        lblMsg.ForeColor = Color.Red;
                        return;
                    }
                    rtn = 0;
                    feckd1.Delete();

                    if (rtn == ComConst.FAILED)
                    {
                        lblMsg.Text = mcckd1.strErr;
                        lblMsg.ForeColor = Color.Red;
                        return;
                    }
                    for (int j = 1; j < dt.Rows.Count; j++)
                    {
                        feckd1.fe_ckd_no = rtnHEADNO;
                        feckd1.fe_ckd_line = j;
                        feckd1.fe_del_n_2 = Convert.ToDateTime(dt.Rows[j]["Del_N_2"].ToString());
                        feckd1.vendor = dt.Rows[j]["Vendor"].ToString();
                        feckd1.dist = dt.Rows[j]["Dist"].ToString();
                        feckd1.model = dt.Rows[j]["Model"].ToString();
                        feckd1.qty = Convert.ToInt32(dt.Rows[j]["Total_Quantity"].ToString());
                        feckd1.pc_no = dt.Rows[j]["PC_No"].ToString();
                        if (dt.Rows[j]["Block_Qty"].ToString() == "")
                        {
                            feckd1.block_qty = 0;
                        }
                        else
                        {
                            feckd1.block_qty = Convert.ToInt32(dt.Rows[j]["Block_Qty"].ToString());
                        }
                        if (dt.Rows[j]["Head_Qty"].ToString() == "")
                        {
                            feckd1.head_qty = 0;
                        }
                        else
                        {
                            feckd1.head_qty = Convert.ToInt32(dt.Rows[j]["Head_Qty"].ToString());
                        }
                        feckd1.van_original = Convert.ToDateTime(dt.Rows[j]["Van_Original"].ToString());
                        if (dt.Rows[j]["Cy_Cut"].ToString() != "-")
                        {
                            feckd1.cy_cut = dt.Rows[j]["Cy_Cut"].ToString();
                        }
                        else
                        {
                            feckd1.cy_cut = "";
                        }
                        feckd1.time_lcd = dt.Rows[j]["Time_Icd"].ToString();
                        feckd1.etd = Convert.ToDateTime(dt.Rows[j]["ETD"].ToString());
                        feckd1.vessel = dt.Rows[j]["Vessel"].ToString();
                        feckd1.remark = dt.Rows[j]["Remark"].ToString();
                        feckd1.flag = 0;

                        rtn = 0;
                        rtn = feckd1.DetailInsert();

                        if (rtn == ComConst.FAILED)
                        {
                            lblMsg.Text = feckd1.strErr;
                            lblMsg.ForeColor = Color.Red;
                            return;
                        }
                    }

                    lblMsg.Text = "Updated normally.";
                    lblMsg.ForeColor = Color.Blue;
                    break;
                case "KD":
                    kd1.kd_special_no = rtnHEADNO;
                    kd1.order_no = dt.Rows[0]["Order_No"].ToString();
                    kd1.order_date = Convert.ToDateTime(dt.Rows[0]["Order_Date"].ToString());
                    kd1.pc_no = dt.Rows[0]["PC_No"].ToString();
                    kd1.part_delivery = dt.Rows[0]["Part_Delivery"].ToString();
                    kd1.packing_date = Convert.ToDateTime(dt.Rows[0]["Packing_Date"].ToString());
                    kd1.packing_list_to_lb = Convert.ToDateTime(dt.Rows[0]["Packing_List_To_Ib"].ToString());
                    kd1.etd_date = Convert.ToDateTime(dt.Rows[0]["ETD_Date"].ToString());
                    kd1.eta_date = Convert.ToDateTime(dt.Rows[0]["ETA_Date"].ToString());
                    kd1.ship_by = dt.Rows[0]["Ship_By"].ToString();
                    kd1.rta = Convert.ToDateTime(dt.Rows[0]["RTA"].ToString());
                    kd1.issue_date = Convert.ToDateTime(dt.Rows[0]["Issue_Date"].ToString());
                    kd1.model_code = dt.Rows[0]["Model"].ToString();
                    kd1.model_type = dt.Rows[0]["Model_Type"].ToString();
                    kd1.issue_by = dt.Rows[0]["Issue_By"].ToString();
                    kd1.remark = dt.Rows[0]["Remark"].ToString();
                    rtn = 0;
                    rtn = kd1.HeadUpdate();

                    if (rtn == ComConst.FAILED)
                    {
                        lblMsg.Text = kd1.strErr;
                        lblMsg.ForeColor = Color.Red;
                        return;
                    }

                    rtn = 0;
                    kd1.Delete();

                    if (rtn == ComConst.FAILED)
                    {
                        lblMsg.Text = mcckd1.strErr;
                        lblMsg.ForeColor = Color.Red;
                        return;
                    }

                    for (int j = 1; j < dt.Rows.Count; j++)
                    {
                        kd1.kd_special_no = rtnHEADNO;
                        kd1.kd_line_no = j;
                        kd1.part_no = dt.Rows[j]["Part_No"].ToString();
                        kd1.color = dt.Rows[j]["Color"].ToString();
                        kd1.fg_qty = Convert.ToInt32(dt.Rows[j]["FG_Qty"].ToString());
                        kd1.del_from = dt.Rows[j]["Del_From"].ToString();
                        kd1.del_to = dt.Rows[j]["Del_To"].ToString();
                        kd1.plan_code = dt.Rows[j]["Plan_Code"].ToString();
                        if (comlb.IsNumeric(dt.Rows[j]["Req_No"].ToString()))
                        {
                            kd1.req_no = Convert.ToInt32(dt.Rows[j]["Req_No"].ToString());
                        }
                        else
                        {
                            kd1.req_no = 0;
                        }
                        rtn = 0;
                        rtn = kd1.DetailInsert();

                        if (rtn == ComConst.FAILED)
                        {
                            lblMsg.Text = kd1.strErr;
                            lblMsg.ForeColor = Color.Red;
                            return;
                        }
                    }

                    lblMsg.Text = "Updated normally.";
                    lblMsg.ForeColor = Color.Blue;
                    break;
                case "Special Part":

                        sp1.year = Convert.ToInt32(ddlYear.Text);
                        sp1.month = Convert.ToInt32(ddlMonth.Text);

                        rtn = 0;
                        rtn = sp1.HeadUpdate();

                        if (rtn == ComConst.FAILED)
                        {
                            lblMsg.Text = sp1.strErr;
                            lblMsg.ForeColor = Color.Red;
                            return;
                        }
                    ds = sp1.GetOrder(sp1.year, sp1.month);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        sp1.server_part_no = ds.Tables[0].Rows[i]["HEAD_NO"].ToString();
                        rtn = 0;
                        sp1.Delete();

                        if (rtn == ComConst.FAILED)
                        {
                            lblMsg.Text = mcckd1.strErr;
                            lblMsg.ForeColor = Color.Red;
                            return;
                        }
                        for (int j = 1; j < 32; j++)
                        {
                            if (dt.Rows[i]["" + j + ""].ToString().Trim() != "")
                            {
                                linecnt += 1;
                                sp1.server_part_no = ds.Tables[0].Rows[i]["HEAD_NO"].ToString(); ;
                                sp1.server_part_line = linecnt;
                                sp1.part_no = dt.Rows[i]["Part_No"].ToString();
                                sp1.model = dt.Rows[i]["Model"].ToString();
                                sp1.order = Convert.ToInt32(dt.Rows[i]["ORDER"].ToString());
                                sp1.diff = Convert.ToInt32(dt.Rows[i]["DIFF"].ToString());
                                sp1.delivery_plan_date = DateTime.ParseExact(sp1.year + sp1.month.ToString().PadLeft(2, '0') + j.ToString().PadLeft(2, '0'), "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
                                sp1.plan_qty = Convert.ToInt32(dt.Rows[i]["" + j + ""].ToString());

                                rtn = 0;
                                rtn = sp1.DetailInsert();

                                if (rtn == ComConst.FAILED)
                                {
                                    lblMsg.Text = sp1.strErr;
                                    lblMsg.ForeColor = Color.Red;
                                    return;
                                }
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
            gdvDetail.PageIndex = e.NewPageIndex;
            if (ViewState["gdvDetail"] != null)
            {
                gdvDetail.DataSource = (System.Data.DataTable)ViewState["gdvDetail"];
                gdvDetail.DataBind();
            }
        }

        protected void gdvDetail_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }
        
        protected void ddlTYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComLibrary com = new ComLibrary();
            DataSet ds = new DataSet();

            MCImport mc1 = new MCImport(g_user_id, g_lang);
            MCCKDImport mcckd1 = new MCCKDImport(g_user_id, g_lang);
            FEImport fe1 = new FEImport(g_user_id, g_lang);
            FECKDImport feckd1 = new FECKDImport(g_user_id, g_lang);
            KDImport kd1 = new KDImport(g_user_id, g_lang);
            SPImport sp1 = new SPImport(g_user_id, g_lang);

            switch (ddlTYPE.Text.ToString())
            {
                case "MC":
                    //ds = mc1.GetOrder();
                    //ddlYear.DataTextField = "HEAD_NO";
                    //ddlYear.DataValueField = "HEAD_NO";

                    //ddlYear.DataSource = ds.Tables[0];
                    //ddlYear.DataBind();
                    //ddlYear.Items.Clear();
                    //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    //{
                    //    ddlYear.Items.Add(ds.Tables[0].Rows[i]["HEAD_NO"].ToString());
                    //}
                    flblOrderNo.Visible = false;
                    ddlOrderNo.Visible = false;
                    break;
                case "MC CKD":
                    ds = mcckd1.GetOrder();
                    ddlOrderNo.DataTextField = "HEAD_NO";
                    ddlOrderNo.DataValueField = "HEAD_NO";

                    if (ds != null)
                    {
                        ddlOrderNo.DataSource = ds.Tables[0];
                        ddlOrderNo.DataBind();
                        ddlOrderNo.Items.Clear();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            ddlOrderNo.Items.Add(ds.Tables[0].Rows[i]["HEAD_NO"].ToString());
                        }
                    }
                    flblOrderNo.Visible = true;
                    ddlOrderNo.Visible = true;
                    break;
                case "FE":
                    //ds = fe1.GetOrder();
                    //ddlYear.DataTextField = "HEAD_NO";
                    //ddlYear.DataValueField = "HEAD_NO";

                    //ddlYear.DataSource = ds.Tables[0];
                    //ddlYear.DataBind();
                    //ddlYear.Items.Clear();
                    //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    //{
                    //    ddlYear.Items.Add(ds.Tables[0].Rows[i]["HEAD_NO"].ToString());
                    //}
                    flblOrderNo.Visible = false;
                    ddlOrderNo.Visible = false;
                    break;
                case "FE CKD":
                    ds = feckd1.GetOrder();
                    ddlOrderNo.DataTextField = "HEAD_NO";
                    ddlOrderNo.DataValueField = "HEAD_NO";

                    if (ds != null)
                    {
                        ddlOrderNo.DataSource = ds.Tables[0];
                        ddlOrderNo.DataBind();
                        ddlOrderNo.Items.Clear();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            ddlOrderNo.Items.Add(ds.Tables[0].Rows[i]["HEAD_NO"].ToString());
                        }
                    }
                    flblOrderNo.Visible = true;
                    ddlOrderNo.Visible = true;
                    break;
                case "KD":
                    ds = kd1.GetOrder();
                    ddlOrderNo.DataTextField = "HEAD_NO";
                    ddlOrderNo.DataValueField = "HEAD_NO";

                    if (ds != null)
                    {
                        ddlOrderNo.DataSource = ds.Tables[0];
                        ddlOrderNo.DataBind();
                        ddlOrderNo.Items.Clear();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            ddlOrderNo.Items.Add(ds.Tables[0].Rows[i]["HEAD_NO"].ToString());
                        }
                    }
                    flblOrderNo.Visible = true;
                    ddlOrderNo.Visible = true;
                    break;
                case "Special Part":
                    //ds = sp1.GetOrder();
                    //ddlYear.DataTextField = "HEAD_NO";
                    //ddlYear.DataValueField = "HEAD_NO";

                    //ddlYear.DataSource = ds.Tables[0];
                    //ddlYear.DataBind();
                    //ddlYear.Items.Clear();
                    //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    //{
                    //    ddlYear.Items.Add(ds.Tables[0].Rows[i]["HEAD_NO"].ToString());
                    //}
                    flblOrderNo.Visible = false;
                    ddlOrderNo.Visible = false;
                    break;

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
    }
}