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
    public partial class ImpPurRec : System.Web.UI.Page
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
            FormControlDisable();

        }


        /// <summary>
        /// 画面権限編集 
        /// </summary>
        protected void Auth_Proc()
        {
        }

        protected void cmdDisp_Click(object sender, EventArgs e)
        {
            //IMV3 Sample Code Start
            //
            // パネルの取込ボタン
            //
            Message msg = new Message(g_user_id, g_lang);
            ComLibrary com = new ComLibrary();
            string filePath = "";

            Boolean fileOK = false;
            //int i = 2;
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
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Open(filePath, Type.Missing, false, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            Excel._Worksheet worksheet = workbook.Sheets[1];
            Excel.Range usedRange = worksheet.UsedRange;


            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                if (rdoTYPE.Items[0].Selected)
                {

                    dt.Columns.Add(new DataColumn("Content No"));
                    dt.Columns.Add(new DataColumn("Part No"));
                    dt.Columns.Add(new DataColumn("Part Name"));
                    dt.Columns.Add(new DataColumn("Color"));
                    dt.Columns.Add(new DataColumn("Proc Loc From"));
                    dt.Columns.Add(new DataColumn("Proc Loc To"));
                    dt.Columns.Add(new DataColumn("Inv Loc CD"));
                    dt.Columns.Add(new DataColumn("Dock No"));
                    dt.Columns.Add(new DataColumn("KD Lot No"));
                    dt.Columns.Add(new DataColumn("PC No"));
                    dt.Columns.Add(new DataColumn("Delv Scdl Date"));
                    //dt.Columns.Add(new DataColumn("Delv Scdl Time"));
                    dt.Columns.Add(new DataColumn("Delv Scdl Qty"));
                    dt.Columns.Add(new DataColumn("Inv Catergory"));


                    int i = 2;

                    while ((usedRange.Cells[i, 1] as Range).Value != null)
                    {
                        string Content_No = (string)(usedRange.Cells[i, 1] as Range).Value;
                        string Part_No = Convert.ToString((usedRange.Cells[i, 2] as Range).Value);
                        string Part_Name = (string)(usedRange.Cells[i, 3] as Range).Value;
                        string Color = (string)(usedRange.Cells[i, 4] as Range).Value;
                        string Proc_Loc_From = (string)(usedRange.Cells[i, 5] as Range).Value;
                        string Proc_Loc_To = (string)(usedRange.Cells[i, 6] as Range).Value;
                        string Inv_Loc_CD = (string)(usedRange.Cells[i, 7] as Range).Value;
                        string Dock_No = (string)(usedRange.Cells[i, 8] as Range).Value;
                        string KD_Lot_No = (string)(usedRange.Cells[i, 9] as Range).Value;
                        string PC_No = (string)(usedRange.Cells[i, 10] as Range).Value;
                        DateTime Delv_Scdl_Date = (DateTime)(usedRange.Cells[i, 11] as Range).Value;
                        //string Delv_Scdl_Time = (string)(usedRange.Cells[i, 12] as Range).Value;
                        int Delv_Scdl_Qty = (int)(usedRange.Cells[i, 13] as Range).Value;
                        string Inv_Catergory = (string)(usedRange.Cells[i, 14] as Range).Value;

                        DataRow dr = dt.NewRow();

                        dr["Content No"] = Content_No;
                        dr["Part No"] = Part_No;
                        dr["Part Name"] = Part_Name;
                        dr["Color"] = Color;
                        dr["Proc Loc From"] = Proc_Loc_From;
                        dr["Proc Loc To"] = Proc_Loc_To;
                        dr["Inv Loc CD"] = Inv_Loc_CD;
                        dr["Dock No"] = Dock_No;
                        dr["KD Lot No"] = KD_Lot_No;
                        dr["PC No"] = PC_No;
                        dr["Delv Scdl Date"] = Delv_Scdl_Date;
                        //dr["Delv Scdl Time"] = Delv_Scdl_Time;
                        dr["Delv Scdl Qty"] = Delv_Scdl_Qty;
                        dr["Inv Catergory"] = Inv_Catergory;

                        dt.Rows.Add(dr);
                        i += 1;
                    }
                }
                if (rdoTYPE.Items[1].Selected)
                {

                    dt.Columns.Add(new DataColumn("Date"));
                    dt.Columns.Add(new DataColumn("Time"));
                    dt.Columns.Add(new DataColumn("Proc Loc From"));
                    dt.Columns.Add(new DataColumn("Maker Name"));
                    dt.Columns.Add(new DataColumn("Ship To"));
                    dt.Columns.Add(new DataColumn("Part No"));
                    dt.Columns.Add(new DataColumn("Part Name"));
                    dt.Columns.Add(new DataColumn("Color"));
                    dt.Columns.Add(new DataColumn("Receive Cycle"));
                    dt.Columns.Add(new DataColumn("Inv Category"));
                    dt.Columns.Add(new DataColumn("Slip No"));
                    dt.Columns.Add(new DataColumn("KD Lot From"));
                    dt.Columns.Add(new DataColumn("KD Lot To"));
                    dt.Columns.Add(new DataColumn("Pro Loc To"));
                    dt.Columns.Add(new DataColumn("Delv Addr"));
                    dt.Columns.Add(new DataColumn("Delv Scdll Qty"));
                    dt.Columns.Add(new DataColumn("Part Unld Qty"));
                    dt.Columns.Add(new DataColumn("Progress"));
                    dt.Columns.Add(new DataColumn("Inv Loc CD"));

                    int i = 2;
                    while ((usedRange.Cells[i, 1] as Range).Value != null)
                    {
                        var DATE = Convert.ToString((usedRange.Cells[i, 1] as Excel.Range).Value);
                        var TIME = Convert.ToString((usedRange.Cells[i, 2] as Excel.Range).Value);
                        var PROC_LOC_FROM = (string)(usedRange.Cells[i, 3] as Excel.Range).Value;
                        var MAKER_NAME = (string)(usedRange.Cells[i, 4] as Excel.Range).Value;
                        var SHIP_TO = (string)(usedRange.Cells[i, 5] as Excel.Range).Value;
                        var PART_NO = Convert.ToString((usedRange.Cells[i, 6] as Excel.Range).Value);
                        var PART_NAME = (string)(usedRange.Cells[i, 7] as Excel.Range).Value;
                        var COLOR = (string)(usedRange.Cells[i, 8] as Excel.Range).Value;
                        var RECEIVE_CYCLE = (string)(usedRange.Cells[i, 9] as Excel.Range).Value;
                        var INV_CATEGORY = (string)(usedRange.Cells[i, 10] as Excel.Range).Value;
                        var SHIP_NO = Convert.ToString((usedRange.Cells[i, 11] as Excel.Range).Value);
                        var KD_LOT_FROM = (string)(usedRange.Cells[i, 12] as Excel.Range).Value;
                        var KD_LOT_TO = (string)(usedRange.Cells[i, 13] as Excel.Range).Value;
                        var PROC_LOC_TO = (string)(usedRange.Cells[i, 14] as Excel.Range).Value;
                        var DELV_ADDR = (string)(usedRange.Cells[i, 15] as Excel.Range).Value;
                        var DELV_SCDLL_QTY = Convert.ToInt32((usedRange.Cells[i, 16] as Excel.Range).Value);
                        var PART_UNLD_QTY = Convert.ToInt32((usedRange.Cells[i, 17] as Excel.Range).Value);
                        var PROGRESS = Convert.ToInt32((usedRange.Cells[i, 18] as Excel.Range).Value);
                        var INV_LOC_CD = Convert.ToString((usedRange.Cells[i, 19] as Excel.Range).Value);

                        DataRow dr = dt.NewRow();
                        dr["Date"] = DATE;
                        dr["Time"] = TIME;
                        dr["Proc Loc From"] = PROC_LOC_FROM;
                        dr["Maker Name"] = MAKER_NAME;
                        dr["Ship To"] = SHIP_TO;
                        dr["Part No"] = PART_NO;
                        dr["Part Name"] = PART_NAME;
                        dr["Color"] = COLOR;
                        dr["Receive Cycle"] = RECEIVE_CYCLE;
                        dr["Inv Category"] = INV_CATEGORY;
                        dr["Slip No"] = SHIP_NO;
                        dr["KD Lot From"] = KD_LOT_FROM;
                        dr["KD Lot To"] = KD_LOT_TO;
                        dr["Pro Loc To"] = PROC_LOC_TO;
                        dr["Delv Addr"] = DELV_ADDR;
                        dr["Delv Scdll Qty"] = DELV_SCDLL_QTY;
                        dr["Part Unld Qty"] = PART_UNLD_QTY;
                        dr["Progress"] = PROGRESS;
                        dr["Inv Loc CD"] = INV_LOC_CD;

                        dt.Rows.Add(dr);
                        i += 1;
                    }
                }
                ViewState["gdvDetail"] = dt;
                gdvDetail.DataSource = dt;
                gdvDetail.DataBind();

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


            //IMV3 Sample Code End
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
                //    msg.Text += "杀死" + processName + "失败！";
            }
        }
		protected void Edit_Screen()
        {
            // 画面編集

            gdvDetail.PageIndex = 0;
			EditGridView();

		}


        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = (System.Data.DataTable)this.gdvDetail.DataSource;
            RevImport revi = new RevImport(g_user_id, g_lang);
            RevLocal revl = new RevLocal(g_user_id, g_lang);

            int rtn = 0;
            try
            {
                for (int i = 0; i < gdvDetail.Rows.Count; i++)
                {
                    if (rdoTYPE.Items[0].Selected)
                    {
                        revi.content_no = dt.Rows[i]["Content No"].ToString();
                        revi.part_no = dt.Rows[i]["Part No"].ToString();
                        revi.part_name = dt.Rows[i]["Part Name"].ToString();
                        revi.color = dt.Rows[i]["Color"].ToString();
                        revi.proc_loc_from = dt.Rows[i]["Proc Loc From"].ToString();
                        revi.proc_loc_to = dt.Rows[i]["Proc Loc To"].ToString();
                        revi.inv_loc_cd = dt.Rows[i]["Inv Loc CD"].ToString();
                        revi.dock_no = dt.Rows[i]["Dock No"].ToString();
                        revi.kd_lot_no = dt.Rows[i]["KD Lot No"].ToString();
                        revi.pc_no = dt.Rows[i]["PC No"].ToString();
                        revi.delv_scdl_time = Convert.ToDateTime(dt.Rows[i]["Delv Scdl Date"]);
                        revi.delv_scdl_qty = Convert.ToInt32(dt.Rows[i]["Delv Scdl Qty"]);
                        revi.inv_category = dt.Rows[i]["Inv Catergory"].ToString();
                        //revi.flag = Convert.ToInt32(dt.Rows[i]["FLAG"]);
                        rtn = 0;
                        rtn = revi.Insert();
                        if (rtn == ComConst.FAILED)
                        {
                            lblMsg.Text = revi.strErr;
                            lblMsg.ForeColor = Color.Red;
                            return;
                        }
                    }
                    else
                    {
                        revl.slip_no = dt.Rows[i]["Slip No"].ToString();
                        revl.date = dt.Rows[i]["Date"].ToString();
                        revl.time = dt.Rows[i]["Time"].ToString();
                        revl.color = dt.Rows[i]["Color"].ToString();
                        revl.proc_loc_from = dt.Rows[i]["Proc Loc From"].ToString();
                        revl.maker_name = dt.Rows[i]["Maker Name"].ToString();
                        revl.ship_to = dt.Rows[i]["Ship To"].ToString();
                        revl.part_no = dt.Rows[i]["Part No"].ToString();
                        revl.part_name = dt.Rows[i]["Part Name"].ToString();
                        revl.color = dt.Rows[i]["COLOR"].ToString();
                        revl.receive_cycle = dt.Rows[i]["Receive Cycle"].ToString();
                        revl.inv_category = dt.Rows[i]["Inv Category"].ToString();
                        revl.kd_lot_from = dt.Rows[i]["KD Lot From"].ToString();
                        revl.kd_lot_to = dt.Rows[i]["KD Lot To"].ToString();
                        revl.proc_loc_to = dt.Rows[i]["Pro Loc To"].ToString();
                        revl.delv_addr = dt.Rows[i]["Delv Addr"].ToString();
                        revl.delv_scdll_qty = Convert.ToInt32(dt.Rows[i]["Delv Scdll Qty"]);
                        revl.part_unld_qty = Convert.ToInt32(dt.Rows[i]["Part Unld Qty"]);
                        revl.progress = Convert.ToInt32(dt.Rows[i]["Progress"]);
                        revl.inv_loc_cd = dt.Rows[i]["Inv Loc CD"].ToString();
                        //revl.flag = Convert.ToInt32(dt.Rows[i]["FLAG"]);
                        rtn = 0;
                        rtn = revl.Insert();
                        if (rtn == ComConst.FAILED)
                        {
                            lblMsg.Text = revl.strErr;
                            lblMsg.ForeColor = Color.Red;
                            return;
                        }
                    }  
                }
                lblMsg.Text = "Updated normally.";
                lblMsg.ForeColor = Color.Blue;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

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

        protected void rdoTYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void imgReturn_Click(object sender, EventArgs e)
        {
            string strUrl = "~/Default.aspx";
            Response.Redirect(strUrl);
        }
    }
}