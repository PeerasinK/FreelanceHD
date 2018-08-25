using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data;
using IMClass;
using System.Drawing;
using System.Collections;

namespace HondaTraceabilitySystem
{
    public partial class MstCalendarMnt : System.Web.UI.Page
    {
        protected string g_user_id;
        protected int g_lang;
        protected string g_company_cd;
        protected string g_name;
        protected string g_menu_grp;

        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie MyCookie;

            //try
            //{
            //    MyCookie = new HttpCookie("IMLastVisit");
            //    HttpCookieCollection MyCookieColl = Request.Cookies;
            //    MyCookie = MyCookieColl.Get("IMLastVisit");

            //    g_user_id = MyCookie.Values["USER_ID"];
            //    g_lang = int.Parse(MyCookie.Values["LANG"]);
            //    g_company_cd = MyCookie.Values["COMPANY_CD"];
            //    g_name = HttpUtility.UrlDecode(MyCookie.Values["NAME"]);

            //}
            //catch
            //{
            //    Response.Redirect("~/NotLoginErr.htm");
            //}
            // 検索画面追加[初期処理より処理の前に記述]
            //g_user_id = "admin-e";
            g_lang = 2;
            //g_name = "General manager (English)";
            //Add_Search();

            if (!IsPostBack)
            {
                // 画面編集
                Init_Label();
                Init_Proc();
            }
            Page.Form.DefaultButton = cmdDisp.UniqueID;
            lblMsg.Text = "";
        }

        //
        // 初期画面ラベル編集
        //
        protected void Init_Label()
        {
            Dictionary dic = new Dictionary(g_user_id, g_lang);
            dic.screen_id = "MstCalMnt_frmMain";
            DataSet ds = dic.GetLabelOfScreenList();

            //
            // 更新系ボタンイメージの編集     －      言語対応とSwapImage
            //
            switch (g_lang)
            {
                case 1:
                    //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-1.jpg";
                    //cmdDisp.Attributes["onmouseover"] = "MM_swapImage('" + cmdDisp.ClientID + "','','../../Contents/Image/BackGround/btn-ind2-1.jpg',1);";
                    //cmdDisp.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update1-1.jpg";
                    //cmdUpdate.Attributes["onmouseover"] = "MM_swapImage('" + cmdUpdate.ClientID + "','','../../Contents/Image/BackGround/btn-update2-1.jpg',1);";
                    //cmdUpdate.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //cmdCancel.ImageUrl = "../../Contents/Image/BackGround/btn-cancel1-1.jpg";
                    //cmdCancel.Attributes["onmouseover"] = "MM_swapImage('" + cmdCancel.ClientID + "','','../../Contents/Image/BackGround/btn-cancel2-1.jpg',1);";
                    //cmdCancel.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    break;
                case 2:
                    //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-2.jpg";
                    //cmdDisp.Attributes["onmouseover"] = "MM_swapImage('" + cmdDisp.ClientID + "','','../../Contents/Image/BackGround/btn-ind2-2.jpg',1);";
                    //cmdDisp.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update1-2.jpg";
                    //cmdUpdate.Attributes["onmouseover"] = "MM_swapImage('" + cmdUpdate.ClientID + "','','../../Contents/Image/BackGround/btn-update2-2.jpg',1);";
                    //cmdUpdate.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //cmdCancel.ImageUrl = "../../Contents/Image/BackGround/btn-cancel1-2.jpg";
                    //cmdCancel.Attributes["onmouseover"] = "MM_swapImage('" + cmdCancel.ClientID + "','','../../Contents/Image/BackGround/btn-cancel2-2.jpg',1);";
                    //cmdCancel.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    break;
                case 3:
                    //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-3.jpg";
                    //cmdDisp.Attributes["onmouseover"] = "MM_swapImage('" + cmdDisp.ClientID + "','','../../Contents/Image/BackGround/btn-ind2-3.jpg',1);";
                    //cmdDisp.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update1-3.jpg";
                    //cmdUpdate.Attributes["onmouseover"] = "MM_swapImage('" + cmdUpdate.ClientID + "','','../../Contents/Image/BackGround/btn-update2-3.jpg',1);";
                    //cmdUpdate.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //cmdCancel.ImageUrl = "../../Contents/Image/BackGround/btn-cancel1-3.jpg";
                    //cmdCancel.Attributes["onmouseover"] = "MM_swapImage('" + cmdCancel.ClientID + "','','../../Contents/Image/BackGround/btn-cancel2-3.jpg',1);";
                    //cmdCancel.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    break;
                case 4:
                    //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-4.jpg";
                    //cmdDisp.Attributes["onmouseover"] = "MM_swapImage('" + cmdDisp.ClientID + "','','../../Contents/Image/BackGround/btn-ind2-4.jpg',1);";
                    //cmdDisp.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update1-4.jpg";
                    //cmdUpdate.Attributes["onmouseover"] = "MM_swapImage('" + cmdUpdate.ClientID + "','','../../Contents/Image/BackGround/btn-update2-4.jpg',1);";
                    //cmdUpdate.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    //cmdCancel.ImageUrl = "../../Contents/Image/BackGround/btn-cancel1-4.jpg";
                    //cmdCancel.Attributes["onmouseover"] = "MM_swapImage('" + cmdCancel.ClientID + "','','../../Contents/Image/BackGround/btn-cancel2-4.jpg',1);";
                    //cmdCancel.Attributes["onmouseout"] = "MM_swapImgRestore();";
                    break;
            }

            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    switch (row["CONTROL_ID"].ToString())
                    {
                        // ラベル
                        case "flblYear": flblYear.Text = row["ITEM_DESC"].ToString(); break;
                        case "flblMonth": flblMonth.Text = row["ITEM_DESC"].ToString(); break;
                        case "flblTitle": flblTitle.Text = row["ITEM_DESC"].ToString(); break;
                        //ボタン
                        case "btnLast": btnLast.Text = row["ITEM_DESC"].ToString(); break;
                        case "btnNext": btnNext.Text = row["ITEM_DESC"].ToString(); break;
                        //GridviewHeadText
                        case "dgvCalendar_Date":
                            dgvCalendarF.Columns[0].HeaderText = row["ITEM_DESC"].ToString();
                            dgvCalendarA.Columns[0].HeaderText = row["ITEM_DESC"].ToString();
                            break;
                        case "dgvCalendar_Week":
                            dgvCalendarF.Columns[1].HeaderText = row["ITEM_DESC"].ToString();
                            dgvCalendarA.Columns[1].HeaderText = row["ITEM_DESC"].ToString();
                            break;
                        case "dgvCalendar_Holiday":
                            dgvCalendarF.Columns[2].HeaderText = row["ITEM_DESC"].ToString();
                            dgvCalendarA.Columns[2].HeaderText = row["ITEM_DESC"].ToString();
                            break;
                        case "dgvCalendar_RLS":
                            dgvCalendarF.Columns[3].HeaderText = row["ITEM_DESC"].ToString();
                            dgvCalendarA.Columns[3].HeaderText = row["ITEM_DESC"].ToString();
                            break;
                        case "dgvCalendar_WHOUR":
                            dgvCalendarF.Columns[4].HeaderText = row["ITEM_DESC"].ToString();
                            dgvCalendarA.Columns[4].HeaderText = row["ITEM_DESC"].ToString();
                            break;
                        //DayOfWeek
                        case "Monday": ViewState["weekday1"] = row["ITEM_DESC"].ToString(); break;
                        case "Tuesday": ViewState["weekday2"] = row["ITEM_DESC"].ToString(); break;
                        case "Wednesday": ViewState["weekday3"] = row["ITEM_DESC"].ToString(); break;
                        case "Thursday": ViewState["weekday4"] = row["ITEM_DESC"].ToString(); break;
                        case "Friday": ViewState["weekday5"] = row["ITEM_DESC"].ToString(); break;
                        case "Saturday": ViewState["weekday6"] = row["ITEM_DESC"].ToString(); break;
                        case "Sunday": ViewState["weekday7"] = row["ITEM_DESC"].ToString(); break;

                    }
                }
            }

            //初始set
            #region **DropDownList Year&Month**

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
            #endregion
            //標準稼働時間

            //SystemParameter sys = new SystemParameter(g_user_id, g_lang);
            //sys.key01 = "STD_WORKING_HOUR";
            //ds = sys.GetDetailList();
            //if (ds == null)
            //{
            //    lblMsg.Text = sys.strErr;
            //    lblMsg.ForeColor = Color.Red;
            //    return;
            //}
            //ViewState["STD_WORKING_HOUR"] = double.Parse(ds.Tables[0].Rows[0]["DATA_DEC"].ToString());
            flblTitle.Text = "Calendar Master";
            ViewState["STD_WORKING_HOUR"] = "24";
        }

        //
        // 初期画面編集
        //
        protected void Init_Proc()
        {
            //Auth_Proc();//ADD BY UBIQ-LIU 2010/8/4
            //dt用于扩充gridview行列
            DataTable dt = new DataTable();
            Message msg = new Message(g_user_id, g_lang);
            for (int i = 0; i < 16; i++)
            {
                if (dt.Columns.Count == 0)
                {
                    dt.Columns.Add("co1");
                    dt.Columns.Add("co2");
                    dt.Columns.Add("co3");
                    dt.Columns.Add("co4");
                    dt.Columns.Add("co5");
                }
                if (dt.Rows.Count < 16)
                {
                    dt.Rows.Add();
                }
            }
            dgvCalendarF.DataSource = dt;
            dgvCalendarF.DataBind();
            dgvCalendarA.DataSource = dt;
            dgvCalendarA.DataBind();
            ComLibrary com = new ComLibrary();
            // Calendarマスタを検索
            IMClass.Calendar cal = new IMClass.Calendar(g_user_id, g_lang);
            cal.calendar_id = "00";
            cal.calendar_cym = Convert.ToInt32(ddlYear.Text + ddlMonth.Text);

            DataSet ds = cal.GetCalendarMonthlyDetail();
            if (ds == null)
            {
                lblMsg.Text = cal.strErr;
                lblMsg.ForeColor = Color.Red;
                return;
            }
            if (ds.Tables[0].Rows.Count != 0)
            {
                //前半月
                for (int i = 0; i < dgvCalendarF.Rows.Count; i++)
                {
                    dgvCalendarF.Rows[i].Cells[0].Text = ds.Tables[0].Rows[i]["Calendar_date"].ToString().Substring(6, 2);
                    switch (ds.Tables[0].Rows[i]["Day_of_week"].ToString())
                    {
                        case "1": dgvCalendarF.Rows[i].Cells[1].Text = ViewState["weekday1"].ToString(); break;
                        case "2": dgvCalendarF.Rows[i].Cells[1].Text = ViewState["weekday2"].ToString(); break;
                        case "3": dgvCalendarF.Rows[i].Cells[1].Text = ViewState["weekday3"].ToString(); break;
                        case "4": dgvCalendarF.Rows[i].Cells[1].Text = ViewState["weekday4"].ToString(); break;
                        case "5": dgvCalendarF.Rows[i].Cells[1].Text = ViewState["weekday5"].ToString(); break;
                        case "6": dgvCalendarF.Rows[i].Cells[1].Text = ViewState["weekday6"].ToString(); break;
                        case "7": dgvCalendarF.Rows[i].Cells[1].Text = ViewState["weekday7"].ToString(); break;
                    }
                    ((CheckBox)dgvCalendarF.Rows[i].FindControl("ckbh1")).Checked = com.IntToBool(com.StringToInt(ds.Tables[0].Rows[i]["HOLIDAY_FLAG"].ToString()));

                    //((CheckBox)dgvCalendarF.Rows[i].FindControl("ckbp1")).Checked = com.IntToBool(com.StringToInt(ds.Tables[0].Rows[i]["PO_RLS_FLAG"].ToString()));
                    ((CheckBox)dgvCalendarF.Rows[i].FindControl("ckbp1")).Checked = com.IntToBool(com.StringToInt(ds.Tables[0].Rows[i]["PROCESS_FLAG"].ToString()));

                    //if (com.StringToDouble(ds.Tables[0].Rows[i]["STD_WORKING_HOUR"].ToString()) != 0)
                    //{
                    //    ((TextBox)dgvCalendarF.Rows[i].FindControl("txtWHour1")).Text = ds.Tables[0].Rows[i]["STD_WORKING_HOUR"].ToString();
                    //}
                    if (com.StringToDouble(ds.Tables[0].Rows[i]["STD_WORKING"].ToString()) != 0)
                    {
                        ((TextBox)dgvCalendarF.Rows[i].FindControl("txtWHour1")).Text = ds.Tables[0].Rows[i]["STD_WORKING"].ToString();
                    }
                    //else
                    //{
                    //    ((TextBox)dgvCalendarF.Rows[i].FindControl("txtWHour1")).Text = "";
                    //}
                }
                dgvCalendarF.Rows[15].Visible = false;
                //后半月
                for (int i = 0; i < dgvCalendarA.Rows.Count; i++)
                {
                    if (i < DateTime.DaysInMonth(Convert.ToInt16(ddlYear.Text), Convert.ToInt16(ddlMonth.Text)) - 15)
                    {
                        dgvCalendarA.Rows[i].Cells[0].Text = ds.Tables[0].Rows[i + 15]["Calendar_date"].ToString().Substring(6, 2);
                        switch (ds.Tables[0].Rows[i + 15]["Day_of_week"].ToString())
                        {
                            case "1": dgvCalendarA.Rows[i].Cells[1].Text = ViewState["weekday1"].ToString(); break;
                            case "2": dgvCalendarA.Rows[i].Cells[1].Text = ViewState["weekday2"].ToString(); break;
                            case "3": dgvCalendarA.Rows[i].Cells[1].Text = ViewState["weekday3"].ToString(); break;
                            case "4": dgvCalendarA.Rows[i].Cells[1].Text = ViewState["weekday4"].ToString(); break;
                            case "5": dgvCalendarA.Rows[i].Cells[1].Text = ViewState["weekday5"].ToString(); break;
                            case "6": dgvCalendarA.Rows[i].Cells[1].Text = ViewState["weekday6"].ToString(); break;
                            case "7": dgvCalendarA.Rows[i].Cells[1].Text = ViewState["weekday7"].ToString(); break;
                        }
                        ((CheckBox)dgvCalendarA.Rows[i].FindControl("ckbh2")).Checked = com.IntToBool(com.StringToInt(ds.Tables[0].Rows[i + 15]["HOLIDAY_FLAG"].ToString()));
                        //((CheckBox)dgvCalendarA.Rows[i].FindControl("ckbp2")).Checked = com.IntToBool(com.StringToInt(ds.Tables[0].Rows[i + 15]["PO_RLS_FLAG"].ToString()));
                        ((CheckBox)dgvCalendarA.Rows[i].FindControl("ckbp2")).Checked = com.IntToBool(com.StringToInt(ds.Tables[0].Rows[i + 15]["PROCESS_FLAG"].ToString()));

                        //if (com.StringToDouble(ds.Tables[0].Rows[i + 15]["STD_WORKING_HOUR"].ToString()) != 0)
                        //{
                        //    ((TextBox)dgvCalendarA.Rows[i].FindControl("txtWHour2")).Text = ds.Tables[0].Rows[i + 15]["STD_WORKING_HOUR"].ToString();
                        //}
                        if (com.StringToDouble(ds.Tables[0].Rows[i + 15]["STD_WORKING"].ToString()) != 0)
                        {
                            ((TextBox)dgvCalendarA.Rows[i].FindControl("txtWHour2")).Text = ds.Tables[0].Rows[i + 15]["STD_WORKING"].ToString();
                        }
                        //else //set text = "" then the text well change to 0.00
                        //{
                        //    ((TextBox)dgvCalendarA.Rows[i].FindControl("txtWHour2")).Text = "";
                        //}
                    }
                    else
                    {
                        dgvCalendarA.Rows[i].Visible = false;
                    }
                }
                //cmdUpdate.Enabled = true;//DEL BY UBIQ-LIU 2010/8/4
                //switch (g_lang)
                //{
                //    case 1:
                //        //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-1.jpg";
                //        cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update1-1.jpg";
                //        break;
                //    case 2:
                //        //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-2.jpg";
                //        cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update1-2.jpg";
                //        break;
                //    case 3:
                //        //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-3.jpg";
                //        cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update1-3.jpg";
                //        break;
                //    case 4:
                //        //cmdDisp.ImageUrl = "../../Contents/Image/BackGround/btn-ind1-4.jpg";
                //        cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update1-4.jpg";
                //        break;
                //}
            }
            else
            {
                lblMsg.Text = msg.GetMessage("NOT_EXIST_ERR");
                lblMsg.ForeColor = Color.Red;
                return;
            }
        }

        /// <summary>
        /// 初期画面権限編集
        /// </summary>
        protected void Auth_Proc()
        {
            IM_Menu menu = new IM_Menu(g_user_id, g_lang);
            menu.user_id = g_user_id;
            menu.program_id = "MstCalanderMnt";//カレンダマスタ
            menu.GetUserProgramAuthority();
            int g_auth = menu.executable_flag;
            if (g_auth == 2)//実行権限=2（変更）の場合。
            {
                //do nothing
            }
            else//照会権限のみのときは、更新ボタンを無効にしてください。
            {
                cmdUpdate.Enabled = false;
                switch (g_lang)
                {
                    case 1:
                        //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update3-1.jpg";
                        break;
                    case 2:
                        //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update3-2.jpg"; ;
                        break;
                    case 3:
                        //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update3-3.jpg";
                        break;
                    case 4:
                        //cmdUpdate.ImageUrl = "../../Contents/Image/BackGround/btn-update3-4.jpg";
                        break;
                }
            }
        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            Message msg = new Message(g_user_id, g_lang);
            IMClass.Calendar cal = new IMClass.Calendar(g_user_id, g_lang);

            ComLibrary com = new ComLibrary();
            // Calendarマスタを更新
            // 画面から項目を編集

            //First Year's Firstday 
            DateTime mDatetime = new DateTime(Convert.ToInt16(ddlYear.Text), 1, 1);//yea   
            int firstweekfirstday = Convert.ToInt32(mDatetime.DayOfWeek);//First Year's Firstday   
            int days = (int)(7 - firstweekfirstday) + 1;

            cal.calendar_id = "00";//默认00
            cal.lang = g_lang;
            for (int i = 0; i < 15; i++)
            {
                cal.calendar_date = Convert.ToInt32(ddlYear.Text + ddlMonth.Text + (Convert.ToInt16(dgvCalendarF.Rows[i].Cells[0].Text)).ToString("0#"));
                //cal.calendar_cym = Convert.ToInt32(ddlYear.Text + ddlMonth.Text);
                DateTime datecal = new DateTime(Convert.ToInt32(ddlYear.Text), Convert.ToInt16(ddlMonth.Text), Convert.ToInt16(dgvCalendarF.Rows[i].Cells[0].Text));
                //if (datecal.DayOfYear <= days)//first week
                //{
                //    cal.week_no = Convert.ToInt32(ddlYear.Text + "01");
                //}
                //else
                //{
                //    cal.week_no = Convert.ToInt32(ddlYear.Text + (((datecal.DayOfYear - days - 1) / 7) + 2).ToString("0#"));
                //}

                //switch (datecal.DayOfWeek.ToString())//Convert.ToInt32(mDatetime.DayOfWeek) to int
                //{
                //    case "Monday": cal.day_of_week = 1; break;
                //    case "Tuesday": cal.day_of_week = 2; break;
                //    case "Wednesday": cal.day_of_week = 3; break;
                //    case "Thursday": cal.day_of_week = 4; break;
                //    case "Friday": cal.day_of_week = 5; break;
                //    case "Saturday": cal.day_of_week = 6; break;
                //    case "Sunday": cal.day_of_week = 7; break;
                //}
                //cal.day_of_week = Convert.ToInt16(datecal.DayOfWeek());

                if (((CheckBox)dgvCalendarF.Rows[i].FindControl("ckbh1")).Checked)
                {
                    cal.holiday_flag = 1;
                }
                else
                {
                    cal.holiday_flag = 0;
                }

                if (((CheckBox)dgvCalendarF.Rows[i].FindControl("ckbp1")).Checked)
                {
                    cal.po_rls_flag = 1;
                }
                else
                {
                    cal.po_rls_flag = 0;
                }

                if (((TextBox)dgvCalendarF.Rows[i].FindControl("txtWHour1")).Text == "")//|| cal.holiday_flag == 1)
                {
                    cal.std_working_hour = 0;
                }
                else
                {
                    cal.std_working_hour = com.StringToDouble(((TextBox)dgvCalendarF.Rows[i].FindControl("txtWHour1")).Text.ToString());
                }
                //cal.user_group = "";
                //cal.chg_pgm = "MstCalendarMnt";
                cal.chg_user_id = g_user_id;

                int rtn = 0;
                rtn = cal.Update();
                if (rtn == ComConst.FAILED)
                {
                    lblMsg.Text = cal.strErr;
                    lblMsg.ForeColor = Color.Red;
                    return;
                }
            }
            for (int i = 0; i < DateTime.DaysInMonth(Convert.ToInt16(ddlYear.Text), Convert.ToInt16(ddlMonth.Text)) - 15; i++)
            {
                cal.calendar_date = Convert.ToInt32(ddlYear.Text + ddlMonth.Text + Convert.ToInt32(dgvCalendarA.Rows[i].Cells[0].Text).ToString("0#"));
                //cal.calendar_cym = Convert.ToInt32(ddlYear.Text + ddlMonth.Text);
                //DateTime datecal = new DateTime(Convert.ToInt32(ddlYear.Text), Convert.ToInt16(ddlMonth.Text), Convert.ToInt16(dgvCalendarA.Rows[i].Cells[0].Text));

                //cal.week_no = Convert.ToInt32(ddlYear.Text + (((datecal.DayOfYear - days - 1) / 7) + 2).ToString("0#"));
                //switch (datecal.DayOfWeek.ToString())
                //{
                //    case "Monday": cal.day_of_week = 1; break;
                //    case "Tuesday": cal.day_of_week = 2; break;
                //    case "Wednesday": cal.day_of_week = 3; break;
                //    case "Thursday": cal.day_of_week = 4; break;
                //    case "Friday": cal.day_of_week = 5; break;
                //    case "Saturday": cal.day_of_week = 6; break;
                //    case "Sunday": cal.day_of_week = 7; break;
                //}

                if (((CheckBox)dgvCalendarA.Rows[i].FindControl("ckbh2")).Checked)
                {
                    cal.holiday_flag = 1;
                }
                else
                {
                    cal.holiday_flag = 0;
                }

                if (((CheckBox)dgvCalendarA.Rows[i].FindControl("ckbp2")).Checked)
                {
                    cal.po_rls_flag = 1;
                }
                else
                {
                    cal.po_rls_flag = 0;
                }

                if (((TextBox)dgvCalendarA.Rows[i].FindControl("txtWHour2")).Text == "")//|| cal.holiday_flag == 1)
                {
                    cal.std_working_hour = 0;
                }
                else
                {
                    cal.std_working_hour = com.StringToDouble(((TextBox)dgvCalendarA.Rows[i].FindControl("txtWHour2")).Text.ToString());
                }
                //cal.user_group = "";
                //cal.chg_pgm = "MstCalendarMnt";
                cal.chg_user_id = g_user_id;

                int rtn = 0;

                rtn = cal.Update();
                if (rtn == ComConst.FAILED)
                {
                    lblMsg.Text = cal.strErr;
                    lblMsg.ForeColor = Color.Red;
                    return;
                }

            }
            cal.calendar_id = "00";
            cal.lang = g_lang;
            cal.calendar_date = com.StringToInt(ddlYear.Text + ddlMonth.Text + "01");
            int rtn2 = 0;
            rtn2 = cal.Work_Days_Update();
            if (rtn2 == ComConst.FAILED)
            {
                lblMsg.Text = cal.strErr;
                lblMsg.ForeColor = Color.Red;
                return;
            }
            lblMsg.Text = msg.GetMessage("NORMAL_UPDATE");

            lblMsg.ForeColor = Color.Blue;
        }

        protected void btnLast_Click(object sender, EventArgs e)
        {
            ComLibrary com = new ComLibrary();
            if (com.StringToInt(ddlMonth.Text) == 1)
            {
                if (com.StringToInt(ddlYear.Text) == 2008)
                {
                    return;
                }
                ddlMonth.Text = "12";
                ddlYear.Text = (com.StringToInt(ddlYear.Text) - 1).ToString();
            }
            else
            {
                ddlMonth.Text = (com.StringToInt(ddlMonth.Text) - 1).ToString("0#");
            }
            ddlMonth_SelectedIndexChanged(null, null);
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            ComLibrary com = new ComLibrary();
            if (com.StringToInt(ddlMonth.Text) == 12)
            {
                if (com.StringToInt(ddlYear.Text) == 2037)
                {
                    return;
                }
                ddlMonth.Text = "01";
                ddlYear.Text = (com.StringToInt(ddlYear.Text) + 1).ToString();
            }
            else
            {
                ddlMonth.Text = (com.StringToInt(ddlMonth.Text) + 1).ToString("0#");
            }
            ddlMonth_SelectedIndexChanged(null, null);
        }

        protected void cmdDisp_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            Init_Proc();
        }

        protected void ddlMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdDisp_Click(null, null);
        }

    }
}