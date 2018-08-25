﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Runtime.Serialization;
using System.Web.Configuration;

/// <summary>
/// 購買オーダクラス
/// </summary>
namespace IMClass
{
    [Serializable]
    public class Po
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Po()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Po(string p_user_id, int p_lang)
        {
            _chg_user_id = p_user_id;
            _lang = p_lang;
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        #endregion

        #region : フィールド

        /// <summary>
        /// フィールド

        /// </summary>
        protected string _db_type = "";
        protected int _lang = 1;
        protected string _order_no = "";
        protected int _order_status = 0;
        protected string _item_type = "";
        protected string _item_no = "";
        protected string _item_desc = "";
        protected int _po_type = 0;
        protected string _mfg_flag = "";
        protected int _sc_flag = 0;
        protected string _sch_id = "";
        protected string _joc_type = "";
        protected string _joc_cd = "";
        protected int _joc_split_no = 0;
        protected string _cost_center = "";
        protected string _joc_item_no = "";
        protected string _parent_order_no = "";
        protected string _plan_no = "";
        protected int _parent_start_date = 0;
        protected int _parent_compl_date = 0;
        protected int _sch_start_date = 0;
        protected int _sch_compl_date = 0;
        protected double _order_qty = 0;
        protected string _order_umsr = "";
        protected int _alloc_flag = 0;
        protected string _job_order_no = "";
        protected int _job_order_date = 0;
        protected double _job_order_qty = 0;
        protected int _job_order_compl_date = 0;
        protected double _job_order_compl_qty = 0;
        protected double _job_order_rej_qty = 0;
        protected string _ws_cd = "";
        protected string _process_cd = "";
        protected string _whs_cd = "";
        protected string _mrp_whs_grp = "";
        protected string _po_header_no = "";
        protected string _po_no = "";
        protected int _po_line_no = 0;
        protected string _po_issue_flag = "";
        protected int _po_issue_date = 0;
        protected string _po_cancel_no = "";
        protected int _po_cancel_date = 0;
        protected int _po_chg_items = 0;
        protected int _po_due_date = 0;
        protected double _po_qty = 0;
        protected string _po_umsr = "";
        protected double _umsr_conv_ratio = 0;
        protected string _buyer_cd = "";
        protected string _vendor_cd = "";
        protected string _trade_type = "";
        protected double _alloc_ratio = 0;
        protected int _auto_po_flag = 0;
        protected string _recv_loc = "";
        protected string _insp_cd = "";
        protected int _unit_prc_type = 0;
        protected int _tentative_price_type = 0;
        protected string _po_cur = "";
        protected double _po_prc = 0;
        protected int _discount_ratio = 0;
        protected double _po_amt = 0;
        protected string _po_note = "";
        protected string _tax_cd = "";
        protected double _tax_rate = 0;
        protected string _tax_cur = "";
        protected double _tax_amt = 0;
        protected int _partial_deliv_cnt = 0;
        protected int _recv_date = 0;
        protected int _partial_recv_cnt = 0;
        protected double _recv_qty = 0;
        protected double _recv_prc = 0;
        protected double _recv_amt = 0;
        protected int _insp_date = 0;
        protected double _accept_qty = 0;
        protected double _accept_amt = 0;
        protected double _rej_qty = 0;
        protected double _rej_amt = 0;
        protected double _est_unit_prc = 0;
        protected string _pegging_type = "";

        protected string _catg_cd = "";
        protected int _alarm_type = 0;
        protected string _vendor_desc = "";
        protected string _whs_desc = "";
        protected string _buyer_name = "";
        protected string _sch_name = "";
        protected string _amt_scope = "";
        protected string _print_mode = "";
        protected int _reissue_flag = 0;
        protected int _num_of_dtls = 0;
        protected string _to_vc_cd = "";
        protected string _parent_item_no = "";
        protected string _xfer_no = "";
        protected string _child_item_no = "";
        protected double _inst_qty = 0;
        protected int _supply_type = 0;
        protected double _qty = 0;
        protected double _cur_ratio = 0;
        protected int _request_no = 0;
        protected string _po_cur_name = "";
        protected int _short_flag = 0;
        protected int _parent_child_flag = 0;

        protected DateTime _entry_date;
        protected DateTime _chg_date;
        protected string _chg_pgm = "";
        protected string _chg_user_id = "";
        protected int _update_cntr = 0;
        protected string _dbmsg = "";
        protected string _errmsg = "";
        protected string _strErr = "";
        protected int _errcode = 0;
        protected int _sqlcode = 0;
        protected string _proc_name = "";
        protected int _trans_date = 0;

        //ADD BY LIU
        protected int _date_type = 0;
        protected int _calendar_cym = 0;
        protected int _calendar_cym_end = 0;
        protected int _calendar_date = 0;
        protected int _ttl_week = 0;
        //20090209 UBIQ-LIU
        protected string _vendor_item_desc = "";
        protected string _vendor_item_no = "";
        protected string _vendor_name = "";

        protected string _mark = "";    // IMV3
        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        public int lang { get { return _lang; } set { _lang = value; } }
        public string order_no { get { return _order_no; } set { _order_no = value; } }
        public int order_status { get { return _order_status; } set { _order_status = value; } }
        public string item_type { get { return _item_type; } set { _item_type = value; } }
        public string item_no { get { return _item_no; } set { _item_no = value; } }
        public string item_desc { get { return _item_desc; } set { _item_desc = value; } }
        public int po_type { get { return _po_type; } set { _po_type = value; } }
        public string mfg_flag { get { return _mfg_flag; } set { _mfg_flag = value; } }
        public int sc_flag { get { return _sc_flag; } set { _sc_flag = value; } }
        public string sch_id { get { return _sch_id; } set { _sch_id = value; } }
        public string joc_type { get { return _joc_type; } set { _joc_type = value; } }
        public string joc_cd { get { return _joc_cd; } set { _joc_cd = value; } }
        public int joc_split_no { get { return _joc_split_no; } set { _joc_split_no = value; } }
        public string cost_center { get { return _cost_center; } set { _cost_center = value; } }
        public string joc_item_no { get { return _joc_item_no; } set { _joc_item_no = value; } }
        public string parent_order_no { get { return _parent_order_no; } set { _parent_order_no = value; } }
        public string plan_no { get { return _plan_no; } set { _plan_no = value; } }
        public int parent_start_date { get { return _parent_start_date; } set { _parent_start_date = value; } }
        public int parent_compl_date { get { return _parent_compl_date; } set { _parent_compl_date = value; } }
        public int sch_start_date { get { return _sch_start_date; } set { _sch_start_date = value; } }
        public int sch_compl_date { get { return _sch_compl_date; } set { _sch_compl_date = value; } }
        public double order_qty { get { return _order_qty; } set { _order_qty = value; } }
        public string order_umsr { get { return _order_umsr; } set { _order_umsr = value; } }
        public int alloc_flag { get { return _alloc_flag; } set { _alloc_flag = value; } }
        public string job_order_no { get { return _job_order_no; } set { _job_order_no = value; } }
        public int job_order_date { get { return _job_order_date; } set { _job_order_date = value; } }
        public double job_order_qty { get { return _job_order_qty; } set { _job_order_qty = value; } }
        public int job_order_compl_date { get { return _job_order_compl_date; } set { _job_order_compl_date = value; } }
        public double job_order_compl_qty { get { return _job_order_compl_qty; } set { _job_order_compl_qty = value; } }
        public double job_order_rej_qty { get { return _job_order_rej_qty; } set { _job_order_rej_qty = value; } }
        public string ws_cd { get { return _ws_cd; } set { _ws_cd = value; } }
        public string process_cd { get { return _process_cd; } set { _process_cd = value; } }
        public string whs_cd { get { return _whs_cd; } set { _whs_cd = value; } }
        public string mrp_whs_grp { get { return _mrp_whs_grp; } set { _mrp_whs_grp = value; } }
        public string po_header_no { get { return _po_header_no; } set { _po_header_no = value; } }
        public string po_no { get { return _po_no; } set { _po_no = value; } }
        public int po_line_no { get { return _po_line_no; } set { _po_line_no = value; } }
        public string po_issue_flag { get { return _po_issue_flag; } set { _po_issue_flag = value; } }
        public int po_issue_date { get { return _po_issue_date; } set { _po_issue_date = value; } }
        public string po_cancel_no { get { return _po_cancel_no; } set { _po_cancel_no = value; } }
        public int po_cancel_date { get { return _po_cancel_date; } set { _po_cancel_date = value; } }
        public int po_chg_items { get { return _po_chg_items; } set { _po_chg_items = value; } }
        public int po_due_date { get { return _po_due_date; } set { _po_due_date = value; } }
        public double po_qty { get { return _po_qty; } set { _po_qty = value; } }
        public string po_umsr { get { return _po_umsr; } set { _po_umsr = value; } }
        public double umsr_conv_ratio { get { return _umsr_conv_ratio; } set { _umsr_conv_ratio = value; } }
        public string buyer_cd { get { return _buyer_cd; } set { _buyer_cd = value; } }
        public string vendor_cd { get { return _vendor_cd; } set { _vendor_cd = value; } }
        public string trade_type { get { return _trade_type; } set { _trade_type = value; } }
        public double alloc_ratio { get { return _alloc_ratio; } set { _alloc_ratio = value; } }
        public int auto_po_flag { get { return _auto_po_flag; } set { _auto_po_flag = value; } }
        public string recv_loc { get { return recv_loc; } set { _recv_loc = value; } }
        public string insp_cd { get { return _insp_cd; } set { _insp_cd = value; } }
        public int unit_prc_type { get { return _unit_prc_type; } set { _unit_prc_type = value; } }
        public int tentative_prc_type { get { return _tentative_price_type; } set { _tentative_price_type = value; } }
        public string po_cur { get { return _po_cur; } set { _po_cur = value; } }
        public double po_prc { get { return _po_prc; } set { _po_prc = value; } }
        public int discount_ratio { get { return _discount_ratio; } set { _discount_ratio = value; } }
        public double po_amt { get { return _po_amt; } set { _po_amt = value; } }
        public string po_note { get { return _po_note; } set { _po_note = value; } }
        public string tax_cd { get { return _tax_cd; } set { _tax_cd = value; } }
        public double tax_rate { get { return _tax_rate; } set { _tax_rate = value; } }
        public string tax_cur { get { return _tax_cur; } set { _tax_cur = value; } }
        public double tax_amt { get { return _tax_amt; } set { _tax_amt = value; } }
        public int partial_delv_cnt { get { return partial_delv_cnt; } set { _partial_deliv_cnt = value; } }
        public int recv_date { get { return recv_date; } set { _recv_date = value; } }
        public int partial_recv_cnt { get { return _partial_recv_cnt; } set { _partial_recv_cnt = value; } }
        public double recv_qty { get { return _recv_qty; } set { _recv_qty = value; } }
        public double recv_prc { get { return _recv_prc; } set { _recv_prc = value; } }
        public double recv_amt { get { return _recv_amt; } set { _recv_amt = value; } }
        public int insp_date { get { return _insp_date; } set { _insp_date = value; } }
        public double accept_qty { get { return _accept_qty; } set { _accept_qty = value; } }
        public double accept_amt { get { return _accept_amt; } set { _accept_amt = value; } }
        public double rej_qty { get { return _rej_qty; } set { _rej_qty = value; } }
        public double rej_amt { get { return _rej_amt; } set { _rej_amt = value; } }
        public double est_unit_prc { get { return _est_unit_prc; } set { _est_unit_prc = value; } }
        public string pegging_type { get { return _pegging_type; } set { _pegging_type = value; } }

        public string catg_cd { get { return _catg_cd; } set { _catg_cd = value; } }
        public int alarm_type { get { return _alarm_type; } set { _alarm_type = value; } }
        public string vendor_desc { get { return _vendor_desc; } set { _vendor_desc = value; } }
        public string whs_desc { get { return _whs_desc; } set { _whs_desc = value; } }
        public string buyer_name { get { return _buyer_name; } set { _buyer_name = value; } }
        public string sch_name { get { return _sch_name; } set { _sch_name = value; } }
        public string amt_scope { get { return _amt_scope; } set { _amt_scope = value; } }
        public string print_mode { get { return _print_mode; } set { _print_mode = value; } }
        public int reissue_flag { get { return _reissue_flag; } set { _reissue_flag = value; } }
        public int num_of_dtls { get { return _num_of_dtls; } set { _num_of_dtls = value; } }
        public string to_vc_cd { get { return _to_vc_cd; } set { _to_vc_cd = value; } }
        public string parent_item_no { get { return _parent_item_no; } set { _parent_item_no = value; } }
        public string xfer_no { get { return _xfer_no; } set { _xfer_no = value; } }
        public string child_item_no { get { return _child_item_no; } set { _child_item_no = value; } }
        public double inst_qty { get { return _inst_qty; } set { _inst_qty = value; } }
        public int supply_type { get { return _supply_type; } set { _supply_type = value; } }
        public double qty { get { return _qty; } set { _qty = value; } }
        public int trans_date { get { return _trans_date; } set { _trans_date = value; } }
        public double cur_ratio { get { return _cur_ratio; } set { _cur_ratio = value; } }
        public int request_no { get { return _request_no; } set { _request_no = value; } }//2009.01.21
        public string po_cur_name { get { return _po_cur_name; } set { _po_cur_name = value; } }
        //ADD BY LIU
        public int date_type { get { return _date_type; } set { _date_type = value; } }
        public int calendar_cym { get { return _calendar_cym; } set { _calendar_cym = value; } }
        public int calendar_cym_end { get { return _calendar_cym; } set { _calendar_cym = value; } }
        public int calendar_date { get { return _calendar_date; } set { _calendar_date = value; } }
        public int ttl_week { get { return _ttl_week; } set { _ttl_week = value; } }

        public string vendor_item_desc { get { return _vendor_item_desc; } set { _vendor_item_desc = value; } }
        public string vendor_item_no { get { return _vendor_item_no; } set { _vendor_item_no = value; } }
        public string vendor_name { get { return _vendor_name; } set { _vendor_name = value; } }
        public int short_flag { get { return _short_flag; } set { _short_flag = value; } }
        public int parent_child_flag { get { return _parent_child_flag; } set { _parent_child_flag = value; } }

        public string mark { get { return _mark; } set { _mark = value; } } // IMV3

        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }
        #endregion

        /// <summary>
        /// 購買オーダ一覧の取得
        /// 
        /// 使用画面：PurPOChg
        /// </summary>
        public DataSet Get_Pur_PoChgList()//UPDATE BY UBIQ-CHEN 2009.02.05
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql           
            strSQL.Append(" SELECT                                                                          ");
            //ADD BY UBIQ-CHEN 2009.06.01
            strSQL.Append(" P.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),P.PO_LINE_NO),3) AS PO_NO,               ");
            strSQL.Append(" P.ITEM_NO,		I.ITEM_DESC,	    V.VENDOR_DESC,			                    ");
            strSQL.Append(" P.PO_QTY,	    P.PO_UMSR,			P.PO_PRC,		    P.PO_AMT,	            ");
            strSQL.Append(" P.PO_CUR,       P.PO_DUE_DATE,	    P.JOC_CD,		    P.WHS_CD,		        ");
            strSQL.Append(" P.ORDER_NO,		S.DATA_CHAR UMSR_DESC,                  S2.DATA_CHAR CUR_DESC   ");
            strSQL.Append(" ,P.VENDOR_CD                                                                    ");
            strSQL.Append(" ,P.JOB_ORDER_DATE                                                               "); // 2011.06.14 Add
            db.DbParametersClear();
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PUR_ORDER P, ITEM_MASTER I,VENDOR_MASTER V ");
                strSQL.Append(" WHERE  ");
                strSQL.Append("   P.ORDER_STATUS                 <     75 ");

                if (po_no != "")
                {
                    strSQL.Append("  AND P.PO_NO              = :PO_NO ");
                    db.DbPsetString("ORDER_NO", _order_no);
                }
                if (buyer_cd != "")
                {
                    strSQL.Append("   AND P.BUYER_CD         = :BUYER_CD ");
                    db.DbPsetString("BUYER_CD", _buyer_cd);
                }
                if (sch_id != "")
                {
                    strSQL.Append("   AND P.SCH_ID               = :SCH_ID ");
                    db.DbPsetString("SCH_ID", _sch_id);
                }
                if (vendor_cd != "")
                {
                    strSQL.Append("   AND P.VENDOR_CD               = :VENDOR_CD ");
                    strSQL.Append("   AND P.VENDOR_CD               = V.VENDOR_CD ");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                }
                if (item_no != "")
                {
                    strSQL.Append("   AND P.ITEM_NO            = :ITEM_NO ");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (catg_cd != "")
                {
                    strSQL.Append("   AND I.CATG_CD        = :CATG_CD ");
                    strSQL.Append("   AND P.ITEM_NO            = I.ITEM_NO ");
                    db.DbPsetString("CATG_CD", _catg_cd);
                }
                if (joc_cd != "")
                {
                    strSQL.Append("   AND P.JOC_CD              = :JOC_CD ");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }
            }
            else
            {
                strSQL.Append(" FROM PUR_ORDER P ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON P.ITEM_NO = I.ITEM_NO");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD = V.VENDOR_CD");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = P.PO_UMSR     ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'CURRENCY_CD' AND S2.KEY02 = P.PO_CUR ");

                db.DbParametersClear();
                strSQL.Append(" WHERE  ");
                strSQL.Append("   P.ORDER_STATUS                 <     75 ");

                if (po_no != "")
                {
                    //strSQL.Append("   AND P.PO_NO              = @PO_NO ");
                    strSQL.Append("   AND (P.PO_NO = @PO_NO OR P.JOB_ORDER_NO = @PO_NO) "); // 2015.03.03                    
                    db.DbPsetString("@PO_NO", _po_no);
                }

                if (buyer_cd != "")
                {
                    strSQL.Append("   AND P.BUYER_CD         = @BUYER_CD ");
                    db.DbPsetString("@BUYER_CD", _buyer_cd);
                }
                if (sch_id != "")
                {
                    strSQL.Append("   AND P.SCH_ID               = @SCH_ID ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (vendor_cd != "")
                {
                    strSQL.Append("   AND P.VENDOR_CD               = @VENDOR_CD ");
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                }
                if (item_no != "")
                {
                    strSQL.Append("   AND P.ITEM_NO            = @ITEM_NO ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (catg_cd != "")
                {
                    strSQL.Append("   AND I.CATG_CD        = @CATG_CD ");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }
                if (joc_cd != "")
                {
                    strSQL.Append("   AND P.JOC_CD              = @JOC_CD ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                //if (joc_item_no != "")
                //{
                //    strSQL.Append("   AND P.JOC_ITEM_NO              = @JOC_ITEM_NO ");
                //    db.DbPsetString("@JOC_ITEM_NO", _joc_item_no);
                //}

                // IMV3
                strSQL.Append("  AND P.PEGGING_TYPE	<> '1'	");

            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 購買オーダ詳細の取得
        /// 
        /// 使用画面：PurPOChg
        /// </summary>
        public int Get_Pur_PoChgDetail()/*****************update by ubiq-chen 2009.02.05****************/
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql            
            strSQL.Append(" SELECT ");
            strSQL.Append(" P.PO_NO,	    P.PO_LINE_NO,		P.ORDER_STATUS,		P.SCH_ID,			        ");
            strSQL.Append(" P.BUYER_CD,	    P.ITEM_NO,			P.ITEM_DESC,		P.VENDOR_CD,	            ");
            strSQL.Append(" P.PO_QTY,	    P.PO_PRC,		    P.PO_AMT,           P.PO_DUE_DATE,              ");
            strSQL.Append(" P.JOC_CD,		P.WHS_CD,		    P.PO_NOTE,	        P.RECV_QTY, 	            ");
            //strSQL.Append(" ISNULL(M.ALARM_TYPE,0) ALARM_TYPE,  V.VENDOR_DESC,      W.WHS_DESC ,                ");
            strSQL.Append(" 0 ALARM_TYPE,  V.VENDOR_DESC,      W.WHS_DESC ,                ");  // IMV3
            strSQL.Append(" S1.DATA_CHAR PO_UMSR,               P.PO_CUR,           S2.DATA_CHAR  PO_CUR_NAME, 	");
            strSQL.Append(" P.VENDOR_NAME,   P.VENDOR_ITEM_NO,  P.VENDOR_ITEM_DESC		                        ");
            strSQL.Append(" ,S_SCH.DATA_CHAR SCH_NAME,          S_BUY.DATA_CHAR BUYER_NAME                      ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PUR_ORDER P, MRP_ALARM M, VENDOR_MASTER V, WAREHOUSE_MASTER W ");
                strSQL.Append(" WHERE P.PO_NO              = :PO_NO ");
                strSQL.Append("   AND P.SCH_ID             = :SCH_ID");
                strSQL.Append("   AND P.VENDOR_CD          = V.VENDOR_CD");
                strSQL.Append("   AND P.WHS_CD          = W.WHS_CD");

                db.DbParametersClear();
                db.DbPsetString("ORDER_NO", _order_no);
                db.DbPsetString("SCH_ID", _sch_id);
            }
            else
            {
                strSQL.Append(" FROM PUR_ORDER P                                                    ");
                //strSQL.Append(" LEFT OUTER JOIN MRP_ALARM M ON P.ORDER_NO         = M.ORDER_NO      ");   // IMV3 COMMENT OUT
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD      = V.VENDOR_CD   ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON P.WHS_CD      = W.WHS_CD      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01 = 'ITEM_UMSR' AND P.PO_UMSR    = S1.KEY02           ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'CURRENCY_CD' AND P.PO_CUR     = S2.KEY02         ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_SCH ON S_SCH.KEY01 = 'SCH_ID' AND P.SCH_ID    = S_SCH.KEY02      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_BUY ON S_BUY.KEY01 = 'BUYER_CD' AND P.BUYER_CD    = S_BUY.KEY02  ");
                strSQL.Append(" WHERE P.ORDER_NO              = @ORDER_NO ");
                //strSQL.Append("   AND M.ORDER_NO              = @ORDER_NO");

                db.DbParametersClear();
                db.DbPsetString("@ORDER_NO", _order_no);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _po_no = db.Row("PO_NO");
                _po_line_no = int.Parse(db.Row("PO_LINE_NO"));
                _order_status = int.Parse(db.Row("ORDER_STATUS"));
                _sch_id = db.Row("SCH_ID");
                _buyer_cd = db.Row("BUYER_CD");
                _item_no = db.Row("ITEM_NO");
                _item_desc = db.Row("ITEM_DESC");
                _vendor_cd = db.Row("VENDOR_CD");
                _po_qty = double.Parse(db.Row("PO_QTY"));
                _po_prc = double.Parse(db.Row("PO_PRC"));
                _po_amt = double.Parse(db.Row("PO_AMT"));
                _po_due_date = int.Parse(db.Row("PO_DUE_DATE"));
                _joc_cd = db.Row("JOC_CD");
                _whs_cd = db.Row("WHS_CD");
                _po_note = db.Row("PO_NOTE");
                _recv_qty = double.Parse(db.Row("RECV_QTY"));
                _alarm_type = int.Parse(db.Row("ALARM_TYPE"));
                _vendor_desc = db.Row("VENDOR_DESC");
                _whs_desc = db.Row("WHS_DESC");
                _po_umsr = db.Row("PO_UMSR");
                _po_cur = db.Row("PO_CUR");
                _po_cur_name = db.Row("PO_CUR_NAME");
                _vendor_name = db.Row("VENDOR_NAME");
                _vendor_item_no = db.Row("VENDOR_ITEM_NO");
                _vendor_item_desc = db.Row("VENDOR_ITEM_DESC");
                _sch_name = db.Row("SCH_NAME");
                _buyer_name = db.Row("BUYER_NAME");
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }
        /// <summary>
        /// 直近の発注情報
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Pur_OrderList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT    TOP 10                                                                 ");
            strSQL.Append("P.VENDOR_CD,			P.PO_QTY,		    P.PO_PRC,		P.PO_DUE_DATE,			");
            strSQL.Append("P.JOB_ORDER_NO,	    V.VENDOR_DESC,      S1.DATA_CHAR PO_UMSR	                ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PUR_ORDER P,VENDOR_MASTER V,SYSTEM_PARAMETER S1");
                strSQL.Append(" WHERE                                               ");
                strSQL.Append("  P.VENDOR_CD      = V.VENDOR_CD(+)                  ");
                strSQL.Append("  AND S1.KEY01     = 'ITEM_UMSR'                     ");
                strSQL.Append("  AND P.PO_UMSR    = S1.KEY02                        ");
                strSQL.Append("  AND P.JOB_ORDER_DATE   >= getdate()-14             ");
                strSQL.Append("  AND P.ORDER_STATUS     != 99                       ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);

            }
            else
            {
                strSQL.Append(" FROM PUR_ORDER P                                                    ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD      = V.VENDOR_CD   ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01 = 'ITEM_UMSR'       ");
                strSQL.Append(" AND P.PO_UMSR    = S1.KEY02                                         ");
                db.DbParametersClear();

                strSQL.Append(" WHERE                               ");
                strSQL.Append("  P.ITEM_NO              = @ITEM_NO  ");
                strSQL.Append("  AND P.WHS_CD           = @WHS_CD   ");
                strSQL.Append("  AND P.ORDER_STATUS     <> 99       ");
                //strSQL.Append("  AND P.JOB_ORDER_DATE   <= CONVERT(varchar(8), GETDATE(), 112) ");
                //strSQL.Append("  AND P.JOB_ORDER_DATE   >= CONVERT(varchar(8), DATEADD(week,-2,GetDate()), 112) ");
                // IMV3
                if (pegging_type != "1")
                    strSQL.Append("  AND P.PEGGING_TYPE	<> '1'	");

                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            strSQL.Append("  ORDER BY PO_DUE_DATE DESC     ");

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 購買オーダの変更
        /// 
        /// 使用画面：PurPOChg
        /// </summary>
        public int Pur_PoChg()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PO_NO", _po_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_LINE_NO", _po_line_no, ComConst.DB_IN);
            //ADD BY UBIQ-CHEN 2009.02.10
            db.DbPsetString("@I_VENDOR_NAME", _vendor_name, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_ITEM_NO", _vendor_item_no, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_ITEM_DESC", _vendor_item_desc, ComConst.DB_IN);
            //ADD END
            db.DbPsetDouble("@I_PO_QTY", _po_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_PO_PRC", _po_prc, ComConst.DB_IN);
            db.DbPsetString("@I_PO_CUR", _po_cur, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_DUE_DATE", _po_due_date, ComConst.DB_IN);
            db.DbPsetString("@I_PO_NOTE", _po_note, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PUR_POCHG");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                db.DbCommit();
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 購買オーダの変更
        /// 
        /// 使用画面：PurPOChg
        /// </summary>
        public int Pur_PoCancel()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PO_NO", _po_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_LINE_NO", _po_line_no, ComConst.DB_IN);
            db.DbPsetString("@I_PO_NOTE", _po_note, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PUR_POCANCEL");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                db.DbCommit();
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 購買オーダを検索
        /// 
        /// 使用画面：PurPOInq
        /// </summary>
        public DataSet Get_Pur_PoInqList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("P.BUYER_CD,	    P.SCH_ID,		  P.VENDOR_CD,		P.WHS_CD,			");
            strSQL.Append("P.ITEM_NO,	    P.ITEM_DESC,	  P.PO_QTY,         P.PO_PRC,			");
            strSQL.Append("P.PO_AMT,	    P.PO_DUE_DATE,    P.JOC_CD,         P.ORDER_NO,			");
			strSQL.Append("P.PO_NOTE,	    P.RECV_QTY,	        P.ACCEPT_QTY,						");
			strSQL.Append("P.REJ_QTY,		(CASE WHEN (P.PO_QTY-P.RECV_QTY+P.REJ_QTY) <0			");//2010/11/01 不良数、発注残数を追加表示する。by liu
			strSQL.Append(" THEN 0 ELSE (P.PO_QTY-P.RECV_QTY+P.REJ_QTY) END) RESIDUEQTY,			");//2010/11/01 不良数、発注残数を追加表示する。by liu
            strSQL.Append("S1.DATA_CHAR BUYER_NAME,		S2.DATA_CHAR SCH_NAME,      V.VENDOR_DESC,	");
            strSQL.Append("S3.DATA_CHAR PO_UMSR,		S4.DATA_CHAR PO_CUR 						");
            strSQL.Append(",P.PO_LINE_NO	,P.PO_NO"); // 2015.01.27

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PUR_ORDER P,SYSTEM_PARAMETER S1,SYSTEM_PARAMETER S2,VENDOR_MASTER V,SYSTEM_PARAMETER S3,SYSTEM_PARAMETER S4 ");
                strSQL.Append(" WHERE  ");
                strSQL.Append("  P.ORDER_STATUS     >= 25 ");
                strSQL.Append("  AND P.ORDER_STATUS   <77 ");
                strSQL.Append("  AND P.PO_NO              = :PO_NO ");
                strSQL.Append("  AND S1.KEY01 = 'BUYER_CD' AND P.BUYER_CD    = S1.KEY02  ");
                strSQL.Append("  AND S2.KEY01 = 'SCH_ID' AND P.SCH_ID     = S2.KEY02 ");
                strSQL.Append("  AND P.VENDOR_CD      = V.VENDOR_CD  ");
                strSQL.Append("  AND S3.KEY01 = 'ITEM_UMSR' AND P.PO_UMSR    = S3.KEY02 ");
                strSQL.Append("  AND S4.KEY01 = 'CURRENCY_CD' AND P.PO_CUR     = S4.KEY02 ");

                db.DbPsetString("PO_NO", _po_no);
            }
            else
            {
                strSQL.Append(" FROM PUR_ORDER P ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01 = 'BUYER_CD' AND P.BUYER_CD    = S1.KEY02  ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'SCH_ID' AND P.SCH_ID     = S2.KEY02 ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD      = V.VENDOR_CD ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S3 ON S3.KEY01 = 'ITEM_UMSR' AND P.PO_UMSR    = S3.KEY02  ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S4 ON S4.KEY01 = 'CURRENCY_CD' AND P.PO_CUR     = S4.KEY02 ");

                db.DbParametersClear();

                strSQL.Append(" WHERE								");
				//strSQL.Append("  P.ORDER_STATUS			>=	25		");//UPD 2010/11/01 UBIQ-LIU
				strSQL.Append("  P.ORDER_STATUS			>=	10		");
                strSQL.Append("  AND P.ORDER_STATUS		<	77		");
                 if (_po_no != "")
                   //strSQL.Append("  AND P.PO_NO			=	@PO_NO	");
                    strSQL.Append("   AND (P.PO_NO = @PO_NO OR P.JOB_ORDER_NO = @PO_NO) "); // 2015.03.03


                // IMV3
                if(pegging_type != "1")
                    strSQL.Append("  AND P.PEGGING_TYPE	<> '1'	");

                strSQL.Append("  ORDER BY PO_LINE_NO	");

                if (_po_no != "")
                	db.DbPsetString("@PO_NO", _po_no);

            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 購買オーダ情報を検索
        /// 
        /// 使用画面：PurPOInq
        /// </summary>
        public int Get_Pur_PoInqDetail()//UPD BY UBIQ-CHEN 2009.02.10 
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql            
            strSQL.Append("SELECT																	");
            strSQL.Append("P.ITEM_NO,	    P.ITEM_DESC,	  P.PO_QTY,         P.PO_PRC,			");
            strSQL.Append("P.PO_AMT,	    P.PO_DUE_DATE,    P.JOC_CD,         P.RECV_QTY,			");
            strSQL.Append("P.ACCEPT_QTY,    P.PO_NOTE,        S1.DATA_CHAR PO_UMSR,					");
			strSQL.Append("S2.DATA_CHAR PO_CUR,               P.VENDOR_NAME,    P.VENDOR_ITEM_NO,	");
            strSQL.Append("P.VENDOR_ITEM_DESC														");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PUR_ORDER P,SYSTEM_PARAMETER S1,SYSTEM_PARAMETER S2 ");
                strSQL.Append(" WHERE  ");
                strSQL.Append("  P.ORDER_NO              = :ORDER_NO ");
                strSQL.Append("  AND S1.KEY01 = 'ITEM_UMSR' AND P.PO_UMSR    = S1.KEY02 ");
                strSQL.Append("  AND S2.KEY01 = 'CURRENCY_CD' AND P.PO_CUR     = S2.KEY02 ");

                db.DbPsetString("ORDER_NO", _order_no);
            }
            else
            {
                strSQL.Append(" FROM PUR_ORDER P ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01 = 'ITEM_UMSR' AND P.PO_UMSR    = S1.KEY02  ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'CURRENCY_CD' AND P.PO_CUR   = S2.KEY02 ");

                db.DbParametersClear();

                strSQL.Append(" WHERE  ");
                strSQL.Append("   P.ORDER_NO              = @ORDER_NO ");

                db.DbPsetString("@ORDER_NO", _order_no);
            }
            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _item_no = db.Row("ITEM_NO");
                _item_desc = db.Row("ITEM_DESC");
                _po_qty = double.Parse(db.Row("PO_QTY"));
                _po_prc = double.Parse(db.Row("PO_PRC"));
                _po_amt = double.Parse(db.Row("PO_AMT"));
                _po_due_date = int.Parse(db.Row("PO_DUE_DATE"));
                _joc_cd = db.Row("JOC_CD");
                _recv_qty = double.Parse(db.Row("RECV_QTY"));
                _accept_qty = double.Parse(db.Row("ACCEPT_QTY"));
                _po_note = db.Row("PO_NOTE");
                _po_umsr = db.Row("PO_UMSR");
                _po_cur = db.Row("PO_CUR");
                _vendor_name = db.Row("VENDOR_NAME");
                _vendor_item_no = db.Row("VENDOR_ITEM_NO");
                _vendor_item_desc = db.Row("VENDOR_ITEM_DESC");
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// 明細品目コードの購買オーダを検索
        /// 
        /// 使用画面：PurPOInq
        /// </summary>
        public DataSet Get_Pur_OrderHincdList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("P.VENDOR_CD,			P.PO_QTY,		    P.PO_PRC,		P.PO_DUE_DATE,			");
            strSQL.Append("P.JOB_ORDER_NO,	    V.VENDOR_DESC	        ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PUR_ORDER P ,VENDOR_MASTER");
                strSQL.Append(" WHERE  ");
                strSQL.Append("  P.ITEM_NO              = :ITEM_NO ");
                strSQL.Append("  AND P.ORDER_STATUS     >= 25 ");
                strSQL.Append("  AND P.ORDER_STATUS     < 77 ");

                db.DbPsetString("ITEM_NO", _item_no);
            }
            else
            {
                strSQL.Append(" FROM PUR_ORDER P ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD      = V.VENDOR_CD ");
                db.DbParametersClear();

                strSQL.Append(" WHERE  ");
                strSQL.Append("  P.ITEM_NO              = @ITEM_NO ");
                strSQL.Append("  AND P.ORDER_STATUS     >= 25 ");
                strSQL.Append("  AND P.ORDER_STATUS     < 77 ");

                // IMV3
                strSQL.Append("  AND P.PEGGING_TYPE	<> '1'	");

                db.DbPsetString("@ITEM_NO", _item_no);

            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 発注計画データを抽出して印刷
        /// 
        /// 使用画面：PurManPOPlanRpt
        /// </summary>
        public DataSet Get_Pur_ManPoPlanRpt()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                          ");
            strSQL.Append(" PM.BUYER_CD,		S1.DATA_CHAR BUYER_NAME,PD.SCH_ID,	S2.DATA_CHAR SCH_NAME,  ");
            strSQL.Append(" V.VENDOR_NAME,	    PD.ITEM_NO,         I.ITEM_DESC,    PM.DELV_LT,	            ");
            strSQL.Append(" PD.DISB_WHS,        W.WHS_DESC,	        S4.DATA_CHAR ACT_CUR_NAME,              ");
            strSQL.Append(" S3.DATA_CHAR UMSR,  PM.VENDOR_CD,   PP.TENTATIVE_PRC,   INV.INV_BAL,            ");
            strSQL.Append(" PP.TENTATIVE_CUR,	PP.ACT_PRC,         PP.ACT_CUR,     PP.COM_PRC_FLAG,	    ");
            strSQL.Append(" S5.DATA_CHAR TEN_CUR_NAME,	S6.DATA_CHAR ITEM_UMSR,                             ");
            strSQL.Append(" SUM(PO.PO_QTY) PO_QTY,                                                          ");//発注残
            strSQL.Append(" SUM(CASE WHEN PD.PLAN_QTY-PD.INPUT_QTY<0 THEN 0 ELSE PD.PLAN_QTY-PD.INPUT_QTY   ");
            strSQL.Append("     END) PLAN_QTY,                                                              ");//所要数量
            strSQL.Append(" MIN(C.CALENDAR_DATE) MIN_DATE,MAX(C.CALENDAR_DATE) MAX_DATE,                    ");
            if (_date_type == 0)
            {
                strSQL.Append(" C.TTL_WEEK DATE_NO                                                          ");
            }
            else
            {
                strSQL.Append(" C.CALENDAR_CYM DATE_NO                                                      ");
            }
            if (_db_type == "ORACLE")
            {
                #region DataBase ORACLE
                db.DbParametersClear();

                strSQL.Append(" FROM PLANNED_DEMAND PD,CALENDAR_MASTER C,ITEM_MASTER I,PURCHASE_MASTER PM,");
                strSQL.Append(" PURCHASE_PRICE_MASTER PP,VENDOR_MASTER V,SYSTEM_PARAMETER S1,SYSTEM_PARAMETER S2,");
                strSQL.Append(" SYSTEM_PARAMETER S3,SYSTEM_PARAMETER S4 ");
                strSQL.Append(" WHERE  ");
                strSQL.Append(" PD.SCH_ID         = :SCH_ID ");
                strSQL.Append(" AND (PD.SUB_GRP_CD = '' OR (PD.SUB_GRP_CD <> '' AND PD.SUB_ACTION_FLAG = 1))  ");
                strSQL.Append(" AND  PD.ITEM_TYPE <> '99'           ");
                if (_date_type == 1)
                {//Month
                    strSQL.Append(" AND C.CALENDAR_DATE  = PD.SCH_DISB_DATE ");
                    strSQL.Append(" AND C.CALENDAR_DATE  >= (SELECT MIN(CALENDAR_DATE) from CALENDAR_MASTER WHERE CALENDAR_CYM = :CALENDAR_CYM) ");
                    strSQL.Append(" AND C.CALENDAR_DATE  <= (SELECT MAX(CALENDAR_DATE) from CALENDAR_MASTER WHERE CALENDAR_CYM = :CALENDAR_CYM_END)  ");
                    db.DbPsetInt("CALENDAR_CYM", _calendar_cym);
                }
                else
                {
                    //Week
                    strSQL.Append(" AND C.CALENDAR_DATE  = PD.SCH_DISB_DATE ");
                    strSQL.Append(" AND C.CALENDAR_DATE  >= (SELECT MIN(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = :TTL_WEEK) ");
                    strSQL.Append(" AND C.CALENDAR_DATE  <= (SELECT MAX(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = :TTL_WEEK + 7)  ");
                    db.DbPsetInt("TTL_WEEK", _ttl_week);
                }
                strSQL.Append(" AND I.ITEM_NO  = PD.ITEM_NO ");
                //if not null
                if (_catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD  = :CATG_CD ");
                    //db.DbPsetString("CATG_CD", _catg_cd);
                }
                strSQL.Append(" AND PM.ITEM_NO  = PD.ITEM_NO ");
                strSQL.Append(" AND PM.PTY_NO  = ( SELECT MIN(PTY_NO) FROM PURCHASE_MASTER ");
                strSQL.Append(" WHERE ITEM_NO = PLANNED_DEMAND.ITEM_NO ");
                strSQL.Append(" AND BEG_EFF_DATE <= PLANNED_DEMAND.SCH_DISB_DATE ");
                strSQL.Append(" AND END_EFF_DATE >= PLANNED_DEMAND.SCH_DISB_DATE AND ROWNUM = 1)");
                strSQL.Append(" AND PM.BEG_EFF_DATE <= PLANNED_DEMAND.SCH_DISB_DATE ");
                strSQL.Append(" AND PM.END_EFF_DATE >= PLANNED_DEMAND.SCH_DISB_DATE ");
                //if not null
                if (_buyer_cd != "")
                {
                    strSQL.Append(" PM.BUYER_CD = :BUYER_CD                         ");
                    db.DbPsetString("BUYER_CD", _buyer_cd);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append(" AND PM.VENDOR_CD = :VENDOR_CD                       ");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                }
                strSQL.Append(" AND PP.ITEM_NO = PURCHASE_MASTER.ITEM_NO");
                strSQL.Append(" AND PP.WS_CD = '*'");
                strSQL.Append(" AND PP.PROCESS_CD = '*'");
                strSQL.Append(" AND PP.VENDOR_CD = PM.VENDOR_CD");
                strSQL.Append(" AND PP.BEG_EFF_DATE <= convert(char(8),getdate(),112)");
                strSQL.Append(" AND PP.END_EFF_DATE >= convert(char(8),getdate(),112)");
                strSQL.Append(" AND V.VENDOR_CD = PM.VENDOR_CD");
                strSQL.Append(" AND V.BEG_EFF_DATE <= PD.SCH_DISB_DATE ");
                strSQL.Append(" AND V.END_EFF_DATE >= PD.SCH_DISB_DATE ");
                strSQL.Append(" AND S1.KEY01 = 'BUYER_CD'");
                strSQL.Append(" AND S1.KEY02 = PM.BUYER_CD");
                strSQL.Append(" AND S2.KEY01 = 'SCH_ID'");
                strSQL.Append(" AND S2.KEY02 = PD.SCH_ID");
                strSQL.Append(" AND S3.KEY01 = 'ITEM_UMSR'");
                strSQL.Append(" AND S3.KEY02 = PM.PUR_UMSR");
                strSQL.Append(" AND S4.KEY01 = 'CURRENCY_CD'");
                strSQL.Append(" AND S4.KEY02 = PP.ACT_CUR");
                if (_catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD  = :CATG_CD ");
                    //db.DbPsetString("CATG_CD", _catg_cd);
                }
                db.DbPsetString("CATG_CD", _catg_cd);
                #endregion
            }
            else
            {
                #region DataBase SQL
                db.DbParametersClear();
                strSQL.Append(" FROM                                                                                            ");
                strSQL.Append(" 	 (																							");
                strSQL.Append(" 		SELECT P.DEMAND_NO, P.SCH_ID, P.ITEM_NO, P.DISB_WHS, P.PLAN_QTY, P.SCH_DISB_DATE, 		");
                strSQL.Append(" 		   P.SUB_GRP_CD, P.SUB_ACTION_FLAG, P.PO_TYPE,P.INPUT_QTY,	                            ");
                strSQL.Append(" 		   ISNULL(MIN(PTY_NO),0) PTY_NO															");
                strSQL.Append(" 		FROM                                       												");
                strSQL.Append(" 	       (   																				    ");
                strSQL.Append(" 		    SELECT DEMAND_NO, SCH_ID, ITEM_NO, DISB_WHS, PLAN_QTY, SCH_DISB_DATE,               ");
                strSQL.Append(" 		           SUB_GRP_CD, SUB_ACTION_FLAG, PO_TYPE, 0 INPUT_QTY            	            ");
                strSQL.Append(" 		    FROM PLANNED_DEMAND                  												");
                strSQL.Append(" 			 WHERE ITEM_TYPE <> '99'                            								");
                strSQL.Append(" 		    UNION ALL                             												");
                strSQL.Append(" 		    SELECT DEMAND_NO, SCH_ID, ITEM_NO, DISB_WHS, PLAN_QTY, SCH_DISB_DATE,               ");
                strSQL.Append(" 		           SUB_GRP_CD, SUB_ACTION_FLAG, PO_TYPE, INPUT_QTY						        ");
                strSQL.Append(" 		    FROM DEMAND                           												");
                strSQL.Append(" 		    WHERE DEMAND_STATUS < 85               												");
                strSQL.Append(" 			 AND ITEM_TYPE <> '99'                            									");
                strSQL.Append(" 	       ) P																				    ");
                strSQL.Append(" 		LEFT OUTER JOIN PURCHASE_MASTER M														");
                strSQL.Append(" 		ON P.ITEM_NO = M.ITEM_NO   																");
                strSQL.Append(" 		AND P.SCH_DISB_DATE >= M.BEG_EFF_DATE													");
                strSQL.Append(" 		AND P.SCH_DISB_DATE <= M.END_EFF_DATE													");
                strSQL.Append(" 		GROUP BY P.DEMAND_NO, P.SCH_ID, P.ITEM_NO, P.DISB_WHS, P.PLAN_QTY, P.SCH_DISB_DATE, 	");
                strSQL.Append(" 			  	 P.SUB_GRP_CD, P.SUB_ACTION_FLAG, P.PO_TYPE,P.INPUT_QTY 						");
                strSQL.Append(" 	) PD																						");

                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON W.WHS_CD  = PD.DISB_WHS                                   ");
                //strSQL.Append(" JOIN CALENDAR_MASTER C ON C.CALENDAR_DATE  = PD.SCH_DISB_DATE                                   ");
                strSQL.Append(" JOIN (SELECT * FROM CALENDAR_MASTER                                                             ");//UPD BY UBIQ-LIU 2010/8/19
                if (_date_type == 1)
                {
                    //Month
                    strSQL.Append(" WHERE CALENDAR_DATE  >= (SELECT MIN(CALENDAR_DATE) FROM CALENDAR_MASTER WHERE CALENDAR_DATE >= @CALENDAR_DATE)      ");
                    strSQL.Append(" AND CALENDAR_DATE  <= (SELECT MAX(CALENDAR_DATE) FROM CALENDAR_MASTER WHERE CALENDAR_DATE <=                      ");
                    //strSQL.Append(" CONVERT(VARCHAR(8), DATEADD(MONTH,6,CONVERT(DATETIME,CONVERT(VARCHAR(8),@CALENDAR_DATE))), 112))                    ");
                    strSQL.Append(" CONVERT(VARCHAR(8), DATEADD(DAY,-1,(DATEADD(MONTH,7,CONVERT(DATETIME,CONVERT(VARCHAR(8),@CALENDAR_DATE))))), 112))  ");
                    //strSQL.Append(" CONVERT(VARCHAR(8), DATEADD(MONTH,7,CONVERT(DATETIME,CONVERT(VARCHAR(8),@CALENDAR_DATE))), 112))                    ");//UPD BY UBIQ-LIU 2010/8/19
                    //db.DbPsetInt("@CALENDAR_DATE", _calendar_date);
                }
                else
                {
                    //Week
                    strSQL.Append(" WHERE CALENDAR_DATE  >= (SELECT MIN(CALENDAR_DATE) FROM CALENDAR_MASTER WHERE TTL_WEEK = @TTL_WEEK)      ");
                    strSQL.Append(" AND CALENDAR_DATE  <= (SELECT MAX(CALENDAR_DATE) FROM CALENDAR_MASTER WHERE TTL_WEEK = @TTL_WEEK + 6)  ");
                    //strSQL.Append(" AND C.CALENDAR_DATE  <= (SELECT MAX(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = @TTL_WEEK + 7)  ");//UPD BY UBIQ-LIU 2010/8/19
                    //db.DbPsetInt("@TTL_WEEK", _ttl_week);
                }
                strSQL.Append(" ) C ON C.CALENDAR_DATE  = PD.SCH_DISB_DATE                                                      ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON I.ITEM_NO  = PD.ITEM_NO ");
                if (_catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD  = @CATG_CD ");
                }
                strSQL.Append(" LEFT OUTER JOIN PURCHASE_MASTER PM ON PM.ITEM_NO  = PD.ITEM_NO                      ");
                strSQL.Append(" AND PM.PTY_NO  = PD.PTY_NO                                                          ");
                strSQL.Append(" AND PM.BEG_EFF_DATE <= PD.SCH_DISB_DATE                                             ");
                strSQL.Append(" AND PM.END_EFF_DATE >= PD.SCH_DISB_DATE                                             ");
                if (_buyer_cd != "")
                {
                    strSQL.Append(" AND PM.BUYER_CD = @BUYER_CD               ");
                    //db.DbPsetString("@BUYER_CD", _buyer_cd);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append(" AND PM.VENDOR_CD = @VENDOR_CD             ");
                    //db.DbPsetString("@VENDOR_CD", _vendor_cd);
                }
                strSQL.Append(" LEFT OUTER JOIN                                                                         ");
                strSQL.Append("(SELECT ITEM_NO, WHS_CD, SUM(INV_BAL) INV_BAL                                            ");
                strSQL.Append("   FROM INVENTORY_DETAIL INV                                                             ");
                strSQL.Append("  WHERE INV.INV_YM = 0                                                                   ");
                strSQL.Append("	   AND INV.INV_WIP_TYPE IN (0,1)                                                        ");//UPD BY UBIQ-LIU 2010/8/19
                strSQL.Append("	   AND INV.INV_TYPE=0                                                                   ");
                strSQL.Append("  GROUP BY ITEM_NO, WHS_CD) INV                                                          ");
                strSQL.Append(" ON INV.ITEM_NO = PD.ITEM_NO AND INV.WHS_CD = PD.DISB_WHS                                ");

                strSQL.Append(" LEFT OUTER JOIN                                                                         ");
                strSQL.Append(" ( SELECT IW.ITEM_NO, IW.WS_CD, IW.BEG_EFF_DATE, IW.END_EFF_DATE, MIW.PTY_NO, WM.SC_FLAG ");
                strSQL.Append("   FROM ITEM_WS_MASTER IW                                                                ");
                strSQL.Append("   INNER JOIN                                                                            ");
                strSQL.Append(" 	(                                                                                   ");
                strSQL.Append(" 	 SELECT ITEM_NO, MIN(PTY_NO) PTY_NO                                                 ");
                strSQL.Append(" 		FROM ITEM_WS_MASTER                                                             ");
                strSQL.Append(" 	  GROUP BY ITEM_NO                                                                  ");
                strSQL.Append(" 	) MIW                                                                               ");
                strSQL.Append("   ON IW.ITEM_NO = MIW.ITEM_NO                                                           ");
                strSQL.Append("   AND IW.PTY_NO = MIW.PTY_NO                                                            ");
                strSQL.Append("   INNER JOIN WORKSHOP_MASTER WM                                                         ");
                strSQL.Append("   ON IW.WS_CD = WM.WS_CD) IW                                                            ");
                strSQL.Append(" ON PD.ITEM_NO = IW.ITEM_NO                                                              ");
                strSQL.Append(" AND PD.SCH_DISB_DATE >= IW.BEG_EFF_DATE                                                 ");
                strSQL.Append(" AND PD.SCH_DISB_DATE <= IW.END_EFF_DATE                                                 ");

                strSQL.Append(" LEFT OUTER JOIN PURCHASE_PRICE_MASTER PP ON PP.ITEM_NO = PM.ITEM_NO");
                strSQL.Append(" AND PP.WS_CD = ISNULL(IW.WS_CD,'*')                                ");
                strSQL.Append(" AND PP.PROCESS_CD = '*'                                            ");
                strSQL.Append(" AND PP.VENDOR_CD = PM.VENDOR_CD                                    ");
                strSQL.Append(" AND PP.BEG_EFF_DATE <= PD.SCH_DISB_DATE                            ");
                strSQL.Append(" AND PP.END_EFF_DATE >= PD.SCH_DISB_DATE                            ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON V.VENDOR_CD = PM.VENDOR_CD      ");
                strSQL.Append(" AND V.BEG_EFF_DATE <= PD.SCH_DISB_DATE                             ");
                strSQL.Append(" AND V.END_EFF_DATE >= PD.SCH_DISB_DATE                             ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01 = 'BUYER_CD'       ");
                strSQL.Append(" AND S1.KEY02 = PM.BUYER_CD                                         ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'SCH_ID'         ");
                strSQL.Append(" AND S2.KEY02 = PD.SCH_ID                                           ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S3 ON S3.KEY01 = 'ITEM_UMSR'      ");
                strSQL.Append(" AND S3.KEY02 = PM.PUR_UMSR                                         ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S4 ON S4.KEY01 = 'CURRENCY_CD'    ");
                strSQL.Append(" AND S4.KEY02 = PP.ACT_CUR                                          ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S5 ON S5.KEY01 = 'CURRENCY_CD'    ");
                strSQL.Append(" AND S5.KEY02 = PP.TENTATIVE_CUR                                    ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S6 ON S6.KEY01 = 'ITEM_UMSR'      ");
                strSQL.Append(" AND S6.KEY02 = I.ITEM_UMSR                                         ");
                //発注残の抽出 ADD BY UBIQ-LIU 2010/08/20
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO, WHS_CD, (CASE WHEN PO_QTY-STOCK_QTY < 0 THEN 0 ELSE    ");
                strSQL.Append(" PO_QTY-STOCK_QTY END) * (CASE WHEN ISNULL(UMSR_CONV_RATIO,1) = 0 THEN 1 ");
                strSQL.Append(" ELSE ISNULL(UMSR_CONV_RATIO,1) END) PO_QTY, PO_DUE_DATE                 ");
                strSQL.Append("   FROM PUR_ORDER                                                        ");
                strSQL.Append(" WHERE ORDER_STATUS < 77 ) PO                                            ");
                strSQL.Append(" ON PO.ITEM_NO = PD.ITEM_NO AND PO.WHS_CD = PD.DISB_WHS                  ");
                strSQL.Append("                   AND PO.PO_DUE_DATE = C.CALENDAR_DATE                  ");

                strSQL.Append(" WHERE                                                                   ");
                strSQL.Append(" (PD.SUB_GRP_CD = '' OR (PD.SUB_GRP_CD <> '' AND PD.SUB_ACTION_FLAG = 1))");
                strSQL.Append(" AND ISNULL(IW.SC_FLAG,1) = 1                                            ");
                strSQL.Append(" AND PD.PO_TYPE = 3                                                      ");
                if (_sch_id != "")
                {
                    strSQL.Append(" AND PD.SCH_ID         = @SCH_ID                                     ");
                    //db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (_catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD  = @CATG_CD ");
                }
                //db.DbPsetString("@CATG_CD", _catg_cd);

                strSQL.Append(" GROUP BY                                                                ");
                strSQL.Append(" PM.BUYER_CD,		S1.DATA_CHAR,		PD.SCH_ID,		S2.DATA_CHAR,   ");
                strSQL.Append(" V.VENDOR_NAME,	    PD.ITEM_NO,         I.ITEM_DESC,    PM.DELV_LT,	    ");
                strSQL.Append(" PD.DISB_WHS,        W.WHS_DESC,	        S4.DATA_CHAR,   S5.DATA_CHAR,   S6.DATA_CHAR, ");
                strSQL.Append(" S3.DATA_CHAR,       PM.VENDOR_CD,   PP.TENTATIVE_PRC,   INV.INV_BAL,    ");
                strSQL.Append(" PP.TENTATIVE_CUR,	PP.ACT_PRC,         PP.ACT_CUR,     PP.COM_PRC_FLAG,");
                if (_date_type == 0)
                    strSQL.Append(" C.TTL_WEEK         ");
                else
                    strSQL.Append(" C.CALENDAR_CYM     ");

                #endregion
            }
            //ADD BY UBIQ-LIU 2010/8/19 ↓
            strSQL.Append(" UNION ALL                                                                       ");
            strSQL.Append(" SELECT                                                                          ");
            strSQL.Append(" PM.BUYER_CD,		S1.DATA_CHAR BUYER_NAME,PD.SCH_ID,	S2.DATA_CHAR SCH_NAME,  ");
            strSQL.Append(" V.VENDOR_NAME,	    PD.ITEM_NO,         I.ITEM_DESC,    PM.DELV_LT,	            ");
            strSQL.Append(" PD.DISB_WHS,        W.WHS_DESC,	        S4.DATA_CHAR ACT_CUR_NAME,              ");
            strSQL.Append(" S3.DATA_CHAR UMSR,  PM.VENDOR_CD,   PP.TENTATIVE_PRC,   INV.INV_BAL,            ");
            strSQL.Append(" PP.TENTATIVE_CUR,	PP.ACT_PRC,         PP.ACT_CUR,     PP.COM_PRC_FLAG,	    ");
            strSQL.Append(" S5.DATA_CHAR TEN_CUR_NAME,	S6.DATA_CHAR ITEM_UMSR,                             ");
            strSQL.Append(" SUM(PO.PO_QTY) PO_QTY,                                                          ");//発注残
            strSQL.Append(" SUM(CASE WHEN PD.PLAN_QTY-PD.INPUT_QTY<0 THEN 0 ELSE PD.PLAN_QTY-PD.INPUT_QTY   ");
            strSQL.Append("     END) PLAN_QTY,                                                              ");//所要数量
            if (_date_type == 0)
            {
                strSQL.Append(" 0 MIN_DATE,     MAX(C.CALENDAR_DATE) MAX_DATE,                              ");
                strSQL.Append(" 0 DATE_NO                                                                   ");
            }
            else
            {
                strSQL.Append(" 0 MIN_DATE,     MAX(C.CALENDAR_DATE) MAX_DATE,                              ");
                strSQL.Append(" 0 DATE_NO                                                                   ");
            }
            if (_db_type == "ORACLE")
            {
                #region DataBase ORACLE
                db.DbParametersClear();

                strSQL.Append(" FROM PLANNED_DEMAND PD,CALENDAR_MASTER C,ITEM_MASTER I,PURCHASE_MASTER PM,");
                strSQL.Append(" PURCHASE_PRICE_MASTER PP,VENDOR_MASTER V,SYSTEM_PARAMETER S1,SYSTEM_PARAMETER S2,");
                strSQL.Append(" SYSTEM_PARAMETER S3,SYSTEM_PARAMETER S4 ");
                strSQL.Append(" WHERE  ");
                strSQL.Append(" PD.SCH_ID         = :SCH_ID ");
                strSQL.Append(" AND (PD.SUB_GRP_CD = '' OR (PD.SUB_GRP_CD <> '' AND PD.SUB_ACTION_FLAG = 1))  ");
                strSQL.Append(" AND  PD.ITEM_TYPE <> '99'           ");
                if (_date_type == 1)
                {//Month
                    strSQL.Append(" AND C.CALENDAR_DATE  = PD.SCH_DISB_DATE ");
                    strSQL.Append(" AND C.CALENDAR_DATE  >= (SELECT MIN(CALENDAR_DATE) from CALENDAR_MASTER WHERE CALENDAR_CYM = :CALENDAR_CYM) ");
                    strSQL.Append(" AND C.CALENDAR_DATE  <= (SELECT MAX(CALENDAR_DATE) from CALENDAR_MASTER WHERE CALENDAR_CYM = :CALENDAR_CYM_END)  ");
                    db.DbPsetInt("CALENDAR_CYM", _calendar_cym);
                }
                else
                {
                    //Week
                    strSQL.Append(" AND C.CALENDAR_DATE  = PD.SCH_DISB_DATE ");
                    strSQL.Append(" AND C.CALENDAR_DATE  >= (SELECT MIN(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = :TTL_WEEK) ");
                    strSQL.Append(" AND C.CALENDAR_DATE  <= (SELECT MAX(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = :TTL_WEEK + 7)  ");
                    db.DbPsetInt("TTL_WEEK", _ttl_week);
                }
                strSQL.Append(" AND I.ITEM_NO  = PD.ITEM_NO ");
                //if not null
                if (_catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD  = :CATG_CD ");
                    //db.DbPsetString("CATG_CD", _catg_cd);
                }
                strSQL.Append(" AND PM.ITEM_NO  = PD.ITEM_NO ");
                strSQL.Append(" AND PM.PTY_NO  = ( SELECT MIN(PTY_NO) FROM PURCHASE_MASTER ");
                strSQL.Append(" WHERE ITEM_NO = PLANNED_DEMAND.ITEM_NO ");
                strSQL.Append(" AND BEG_EFF_DATE <= PLANNED_DEMAND.SCH_DISB_DATE ");
                strSQL.Append(" AND END_EFF_DATE >= PLANNED_DEMAND.SCH_DISB_DATE AND ROWNUM = 1)");
                strSQL.Append(" AND PM.BEG_EFF_DATE <= PLANNED_DEMAND.SCH_DISB_DATE ");
                strSQL.Append(" AND PM.END_EFF_DATE >= PLANNED_DEMAND.SCH_DISB_DATE ");
                //if not null
                if (_buyer_cd != "")
                {
                    strSQL.Append(" PM.BUYER_CD = :BUYER_CD                         ");
                    db.DbPsetString("BUYER_CD", _buyer_cd);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append(" AND PM.VENDOR_CD = :VENDOR_CD                       ");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                }
                strSQL.Append(" AND PP.ITEM_NO = PURCHASE_MASTER.ITEM_NO");
                strSQL.Append(" AND PP.WS_CD = '*'");
                strSQL.Append(" AND PP.PROCESS_CD = '*'");
                strSQL.Append(" AND PP.VENDOR_CD = PM.VENDOR_CD");
                strSQL.Append(" AND PP.BEG_EFF_DATE <= convert(char(8),getdate(),112)");
                strSQL.Append(" AND PP.END_EFF_DATE >= convert(char(8),getdate(),112)");
                strSQL.Append(" AND V.VENDOR_CD = PM.VENDOR_CD");
                strSQL.Append(" AND V.BEG_EFF_DATE <= PD.SCH_DISB_DATE ");
                strSQL.Append(" AND V.END_EFF_DATE >= PD.SCH_DISB_DATE ");
                strSQL.Append(" AND S1.KEY01 = 'BUYER_CD'");
                strSQL.Append(" AND S1.KEY02 = PM.BUYER_CD");
                strSQL.Append(" AND S2.KEY01 = 'SCH_ID'");
                strSQL.Append(" AND S2.KEY02 = PD.SCH_ID");
                strSQL.Append(" AND S3.KEY01 = 'ITEM_UMSR'");
                strSQL.Append(" AND S3.KEY02 = PM.PUR_UMSR");
                strSQL.Append(" AND S4.KEY01 = 'CURRENCY_CD'");
                strSQL.Append(" AND S4.KEY02 = PP.ACT_CUR");
                if (_catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD  = :CATG_CD ");
                    //db.DbPsetString("CATG_CD", _catg_cd);
                }
                db.DbPsetString("CATG_CD", _catg_cd);
                #endregion
            }
            else
            {
                #region DataBase SQL
                strSQL.Append(" FROM                                                                                            ");
                strSQL.Append(" 	 (																							");
                strSQL.Append(" 		SELECT P.DEMAND_NO, P.SCH_ID, P.ITEM_NO, P.DISB_WHS, P.PLAN_QTY, P.SCH_DISB_DATE, 		");
                strSQL.Append(" 		   P.SUB_GRP_CD, P.SUB_ACTION_FLAG, P.PO_TYPE,P.INPUT_QTY,							    ");
                strSQL.Append(" 		   ISNULL(MIN(PTY_NO),0) PTY_NO															");
                strSQL.Append(" 		FROM                                       												");
                strSQL.Append(" 	       (   																				    ");
                strSQL.Append(" 		    SELECT DEMAND_NO, SCH_ID, ITEM_NO, DISB_WHS, PLAN_QTY, SCH_DISB_DATE,               ");
                strSQL.Append(" 		           SUB_GRP_CD, SUB_ACTION_FLAG, PO_TYPE,0 INPUT_QTY						        ");
                strSQL.Append(" 		    FROM PLANNED_DEMAND                  												");
                strSQL.Append(" 			 WHERE ITEM_TYPE <> '99'                            								");
                strSQL.Append(" 		    UNION ALL                             												");
                strSQL.Append(" 		    SELECT DEMAND_NO, SCH_ID, ITEM_NO, DISB_WHS, PLAN_QTY, SCH_DISB_DATE,               ");
                strSQL.Append(" 		           SUB_GRP_CD, SUB_ACTION_FLAG, PO_TYPE,INPUT_QTY						        ");
                strSQL.Append(" 		    FROM DEMAND                           												");
                strSQL.Append(" 		    WHERE DEMAND_STATUS < 85               												");
                strSQL.Append(" 			 AND ITEM_TYPE <> '99'                            									");
                strSQL.Append(" 	       ) P																				    ");
                strSQL.Append(" 		LEFT OUTER JOIN PURCHASE_MASTER M														");
                strSQL.Append(" 		ON P.ITEM_NO = M.ITEM_NO   																");
                strSQL.Append(" 		AND P.SCH_DISB_DATE >= M.BEG_EFF_DATE													");
                strSQL.Append(" 		AND P.SCH_DISB_DATE <= M.END_EFF_DATE													");
                strSQL.Append(" 		GROUP BY P.DEMAND_NO, P.SCH_ID, P.ITEM_NO, P.DISB_WHS, P.PLAN_QTY, P.SCH_DISB_DATE, 	");
                strSQL.Append(" 			  	 P.SUB_GRP_CD, P.SUB_ACTION_FLAG, P.PO_TYPE,P.INPUT_QTY							");
                strSQL.Append(" 	) PD																						");

                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON W.WHS_CD  = PD.DISB_WHS                                   ");
                strSQL.Append(" JOIN (SELECT * FROM CALENDAR_MASTER                                                             ");
                if (_date_type == 1)
                {
                    //Month
                    strSQL.Append(" WHERE CALENDAR_DATE  <= (SELECT MAX(CALENDAR_DATE) FROM CALENDAR_MASTER WHERE             ");
                    strSQL.Append("                          CALENDAR_DATE < @CALENDAR_DATE)                                    ");
                    db.DbPsetInt("@CALENDAR_DATE", _calendar_date);
                }
                else
                {
                    //Week
                    strSQL.Append(" WHERE CALENDAR_DATE  <= (SELECT MAX(CALENDAR_DATE) FROM CALENDAR_MASTER WHERE TTL_WEEK = @TTL_WEEK-1)  ");
                    db.DbPsetInt("@TTL_WEEK", _ttl_week);
                }
                strSQL.Append(" ) C ON C.CALENDAR_DATE  = PD.SCH_DISB_DATE                                   ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON I.ITEM_NO  = PD.ITEM_NO                    ");
                if (_catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD  = @CATG_CD ");
                }
                strSQL.Append(" LEFT OUTER JOIN PURCHASE_MASTER PM ON PM.ITEM_NO  = PD.ITEM_NO                      ");
                strSQL.Append(" AND PM.PTY_NO  = PD.PTY_NO                                                          ");
                strSQL.Append(" AND PM.BEG_EFF_DATE <= PD.SCH_DISB_DATE                                             ");
                strSQL.Append(" AND PM.END_EFF_DATE >= PD.SCH_DISB_DATE                                             ");
                if (_buyer_cd != "")
                {
                    strSQL.Append(" AND PM.BUYER_CD = @BUYER_CD               ");
                    db.DbPsetString("@BUYER_CD", _buyer_cd);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append(" AND PM.VENDOR_CD = @VENDOR_CD             ");
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                }
                strSQL.Append(" LEFT OUTER JOIN                                                                         ");
                strSQL.Append("(SELECT ITEM_NO, WHS_CD, SUM(INV_BAL) INV_BAL                                            ");
                strSQL.Append("   FROM INVENTORY_DETAIL INV                                                             ");
                strSQL.Append("  WHERE INV.INV_YM = 0                                                                   ");
                strSQL.Append("	   AND INV.INV_WIP_TYPE IN (0,1)                                                        ");
                strSQL.Append("	   AND INV.INV_TYPE=0                                                                   ");
                strSQL.Append("  GROUP BY ITEM_NO, WHS_CD) INV                                                          ");
                strSQL.Append(" ON INV.ITEM_NO = PD.ITEM_NO AND INV.WHS_CD = PD.DISB_WHS                                ");

                strSQL.Append(" LEFT OUTER JOIN                                                                         ");
                strSQL.Append(" ( SELECT IW.ITEM_NO, IW.WS_CD, IW.BEG_EFF_DATE, IW.END_EFF_DATE, MIW.PTY_NO, WM.SC_FLAG ");
                strSQL.Append("   FROM ITEM_WS_MASTER IW                                                                ");
                strSQL.Append("   INNER JOIN                                                                            ");
                strSQL.Append(" 	(                                                                                   ");
                strSQL.Append(" 	 SELECT ITEM_NO, MIN(PTY_NO) PTY_NO                                                 ");
                strSQL.Append(" 		FROM ITEM_WS_MASTER                                                             ");
                strSQL.Append(" 	  GROUP BY ITEM_NO                                                                  ");
                strSQL.Append(" 	) MIW                                                                               ");
                strSQL.Append("   ON IW.ITEM_NO = MIW.ITEM_NO                                                           ");
                strSQL.Append("   AND IW.PTY_NO = MIW.PTY_NO                                                            ");
                strSQL.Append("   INNER JOIN WORKSHOP_MASTER WM                                                         ");
                strSQL.Append("   ON IW.WS_CD = WM.WS_CD) IW                                                            ");
                strSQL.Append(" ON PD.ITEM_NO = IW.ITEM_NO                                                              ");
                strSQL.Append(" AND PD.SCH_DISB_DATE >= IW.BEG_EFF_DATE                                                 ");
                strSQL.Append(" AND PD.SCH_DISB_DATE <= IW.END_EFF_DATE                                                 ");

                strSQL.Append(" LEFT OUTER JOIN PURCHASE_PRICE_MASTER PP ON PP.ITEM_NO = PM.ITEM_NO     ");
                strSQL.Append(" AND PP.WS_CD = ISNULL(IW.WS_CD,'*')                                     ");
                strSQL.Append(" AND PP.PROCESS_CD = '*'                                                 ");
                strSQL.Append(" AND PP.VENDOR_CD = PM.VENDOR_CD                                         ");
                strSQL.Append(" AND PP.BEG_EFF_DATE <= PD.SCH_DISB_DATE                                 ");
                strSQL.Append(" AND PP.END_EFF_DATE >= PD.SCH_DISB_DATE                                 ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON V.VENDOR_CD = PM.VENDOR_CD           ");
                strSQL.Append(" AND V.BEG_EFF_DATE <= PD.SCH_DISB_DATE                                  ");
                strSQL.Append(" AND V.END_EFF_DATE >= PD.SCH_DISB_DATE                                  ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01 = 'BUYER_CD'            ");
                strSQL.Append(" AND S1.KEY02 = PM.BUYER_CD                                              ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'SCH_ID'              ");
                strSQL.Append(" AND S2.KEY02 = PD.SCH_ID                                                ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S3 ON S3.KEY01 = 'ITEM_UMSR'           ");
                strSQL.Append(" AND S3.KEY02 = PM.PUR_UMSR                                              ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S4 ON S4.KEY01 = 'CURRENCY_CD'         ");
                strSQL.Append(" AND S4.KEY02 = PP.ACT_CUR                                               ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S5 ON S5.KEY01 = 'CURRENCY_CD'         ");
                strSQL.Append(" AND S5.KEY02 = PP.TENTATIVE_CUR                                         ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S6 ON S6.KEY01 = 'ITEM_UMSR'           ");
                strSQL.Append(" AND S6.KEY02 = I.ITEM_UMSR                                              ");
                //発注残の抽出
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO, WHS_CD, (CASE WHEN PO_QTY-STOCK_QTY < 0 THEN 0 ELSE    ");
                strSQL.Append(" PO_QTY-STOCK_QTY END) * (CASE WHEN ISNULL(UMSR_CONV_RATIO,1) = 0 THEN 1 ");
                strSQL.Append(" ELSE ISNULL(UMSR_CONV_RATIO,1) END) PO_QTY,PO_DUE_DATE                  ");
                strSQL.Append("   FROM PUR_ORDER                                                        ");
                strSQL.Append("  WHERE ORDER_STATUS < 77 ) PO                                           ");
                strSQL.Append(" ON PO.ITEM_NO = PD.ITEM_NO AND PO.WHS_CD = PD.DISB_WHS                  ");
                strSQL.Append("                   AND PO.PO_DUE_DATE = C.CALENDAR_DATE                  ");
                strSQL.Append(" WHERE                                                                   ");
                strSQL.Append(" (PD.SUB_GRP_CD = '' OR (PD.SUB_GRP_CD <> '' AND PD.SUB_ACTION_FLAG = 1))");
                strSQL.Append(" AND ISNULL(IW.SC_FLAG,1) = 1                                            ");
                strSQL.Append(" AND PD.PO_TYPE = 3                                                      ");
                if (_sch_id != "")
                {
                    strSQL.Append(" AND PD.SCH_ID         = @SCH_ID                                     ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (_catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD  = @CATG_CD ");
                }
                db.DbPsetString("@CATG_CD", _catg_cd);

                strSQL.Append(" GROUP BY                                                                ");
                strSQL.Append(" PM.BUYER_CD,		S1.DATA_CHAR,		PD.SCH_ID,		S2.DATA_CHAR,   ");
                strSQL.Append(" V.VENDOR_NAME,	    PD.ITEM_NO,         I.ITEM_DESC,    PM.DELV_LT,	    ");
                strSQL.Append(" PD.DISB_WHS, W.WHS_DESC,S4.DATA_CHAR,   S5.DATA_CHAR,   S6.DATA_CHAR,   ");
                strSQL.Append(" S3.DATA_CHAR,       PM.VENDOR_CD,   PP.TENTATIVE_PRC,   INV.INV_BAL,    ");
                strSQL.Append(" PP.TENTATIVE_CUR,	PP.ACT_PRC,         PP.ACT_CUR,     PP.COM_PRC_FLAG ");

                #endregion
            }

            strSQL.Append(" ORDER BY PD.ITEM_NO, DATE_NO ");
            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 計画発注対象データを検索
        /// 
        /// 使用画面：PurPORlse
        /// </summary>
        public DataSet Get_Pur_PoRlseList()//2009.02.04 UPDATE BY UBIQ-CHEN
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql 
            strSQL.Append("SELECT                                                                                       ");
            strSQL.Append("P.SCH_ID,P.ITEM_NO,P.ITEM_DESC,P.VENDOR_CD,                                                  ");
            strSQL.Append("P.PO_QTY,P.PO_DUE_DATE,P.JOC_CD,P.WHS_CD,P.ORDER_NO,                                         ");
            strSQL.Append("V.VENDOR_DESC,S1.DATA_CHAR PO_UMSR, P1.COM_PRC_FLAG,                                    ");
            strSQL.Append("PO_PRC = ISNULL(CASE WHEN ISNULL(P1.TENTATIVE_PRC,-1) = -1                                   ");
            //strSQL.Append("THEN P2.ACT_PRC ELSE P1.TENTATIVE_PRC END, 0),");  //UPD UBIQ-SAI 09.01.16
            strSQL.Append("THEN (CASE WHEN P2.COM_PRC_FLAG = 0 THEN P2.ACT_PRC ELSE P2.TENTATIVE_PRC END)               ");
            strSQL.Append("ELSE (CASE WHEN P1.COM_PRC_FLAG = 0 THEN P1.ACT_PRC ELSE P1.TENTATIVE_PRC END) END, 0),      ");
            strSQL.Append(" ROUND(                                                                                      ");
            strSQL.Append(" P.PO_QTY * ISNULL(CASE WHEN ISNULL(P1.TENTATIVE_PRC,-1) = -1                                ");
            //strSQL.Append("THEN P2.ACT_PRC ELSE P1.TENTATIVE_PRC END, 0),");  //UPD UBIQ-SAI 09.01.16
            strSQL.Append("THEN (CASE WHEN P2.COM_PRC_FLAG = 0 THEN P2.ACT_PRC ELSE P2.TENTATIVE_PRC END)                ");
            strSQL.Append("ELSE (CASE WHEN P1.COM_PRC_FLAG = 0 THEN P1.ACT_PRC ELSE P1.TENTATIVE_PRC END) END, 0),2)     ");
            strSQL.Append("PO_AMT,                                                                                       ");
            strSQL.Append("PO_CUR = ISNULL(CASE WHEN ISNULL(S2.KEY02,'' )= '' THEN S3.KEY02 ELSE S2.KEY02 END,''),       ");
            strSQL.Append("PO_CUR_NAME = ISNULL(CASE WHEN ISNULL(S2.DATA_CHAR,'' )= '' THEN S3.DATA_CHAR ELSE S2.DATA_CHAR END,''),       ");
            strSQL.Append("P.SCH_START_DATE,   S_SCH.DATA_CHAR SCH_DESC                                                   ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PLANNED_ORDER P, ITEM_MASTER I,VENDOR_MASTER V ");
                strSQL.Append(" WHERE  ");
                strSQL.Append("   P.SC_FLAG                 =  1 ");
                strSQL.Append(" AND  P.ITEM_TYPE            <> '99' ");

                //Add 10.08.25 Ubiq-Sai Start
                strSQL.Append("  AND P.JOC_CD NOT IN (SELECT D.JOC_CD                              ");
                strSQL.Append("                          FROM SALES_ORDER S, SALES_ORDER_DETAIL D   ");
                strSQL.Append("                         WHERE S.ORDER_NO = D.ORDER_NO               ");
                strSQL.Append("                           AND S.PO_TYPE <> 0 )                      ");
                //Add 10.08.25 Ubiq-Sai End

                if (order_no != "")
                {
                    strSQL.Append("  AND P.PO_NO              = :PO_NO ");
                    db.DbPsetString("ORDER_NO", _order_no);
                }
                //if (buyer_cd != "")
                //{
                strSQL.Append("   AND P.BUYER_CD         = :BUYER_CD ");
                db.DbPsetString("BUYER_CD", _buyer_cd);
                //}
                if (sch_id != "")
                {
                    strSQL.Append("   AND P.SCH_ID               = :SCH_ID ");
                    db.DbPsetString("SCH_ID", _sch_id);
                }
                if (vendor_cd != "")
                {
                    strSQL.Append("   AND P.VENDOR_CD               = :VENDOR_CD ");
                    strSQL.Append("   AND P.VENDOR_CD               = V.VENDOR_CD ");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                }
                if (item_no != "")
                {
                    strSQL.Append("   AND P.ITEM_NO            = :ITEM_NO ");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (catg_cd != "")
                {
                    strSQL.Append("   AND I.CATG_CD        = :CATG_CD ");
                    strSQL.Append("   AND P.ITEM_NO            = I.ITEM_NO ");
                    db.DbPsetString("CATG_CD", _catg_cd);
                }
                if (joc_item_no != "")
                {
                    strSQL.Append("   AND P.JOC_ITEM_NO              = :JOC_ITEM_NO ");
                    db.DbPsetString("JOC_ITEM_NO", _joc_item_no);
                }
            }
            else
            {
                strSQL.Append("   FROM PLANNED_ORDER P                                                          ");
                strSQL.Append("   LEFT JOIN PURCHASE_PRICE_MASTER P1                                            ");
                //strSQL.Append("   ON  P.ITEM_NO = P1.ITEM_NO AND P.WS_CD = P1.WS_CD ");   //UPD UBIQ-SAI 09.01.16
                strSQL.Append("   ON  P.ITEM_NO = P1.ITEM_NO AND P.WS_CD =                                      ");
                strSQL.Append("   CASE WHEN P1.WS_CD = '*' THEN '' ELSE P1.WS_CD END                            ");
                strSQL.Append("   AND P.PROCESS_CD = P1.PROCESS_CD AND P.VENDOR_CD = P1.VENDOR_CD               ");
                strSQL.Append("   AND P1.BEG_EFF_DATE <= P.SCH_START_DATE                                       ");
                strSQL.Append("   AND P1.END_EFF_DATE >= P.SCH_START_DATE  AND P1.UNIT_PRC_BASE = 0             ");
                strSQL.Append("   LEFT JOIN PURCHASE_PRICE_MASTER P2                                            ");
                //strSQL.Append("   ON  P2.ITEM_NO = P.ITEM_NO AND P2.WS_CD = P.WS_CD  ");  //UPD UBIQ-SAI 09.01.16
                strSQL.Append("   ON  P2.ITEM_NO = P.ITEM_NO AND CASE WHEN P2.WS_CD = '*' THEN ''               ");
                strSQL.Append("   ELSE P2.WS_CD END = P.WS_CD                                                   ");
                strSQL.Append("   AND P2.PROCESS_CD = P.PROCESS_CD AND P2.VENDOR_CD = P.VENDOR_CD               ");
                strSQL.Append("   AND P2.BEG_EFF_DATE <= P.SCH_COMPL_DATE                                       ");
                strSQL.Append("   AND P2.END_EFF_DATE >= P.SCH_COMPL_DATE AND P2.UNIT_PRC_BASE = 1              ");
                strSQL.Append("   LEFT OUTER JOIN ITEM_MASTER I ON P.ITEM_NO = I.ITEM_NO                        ");
                strSQL.Append("   LEFT JOIN VENDOR_MASTER V ON P.VENDOR_CD = V.VENDOR_CD                        ");
                strSQL.Append("   LEFT OUTER JOIN SYSTEM_PARAMETER S1                                           ");
                strSQL.Append("   ON S1.KEY01 = 'ITEM_UMSR' AND S1.KEY02 = P.PO_UMSR                            ");
                strSQL.Append("   LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'CURRENCY_CD'               ");
                //strSQL.Append("   AND S2.KEY02 = ISNULL(CASE WHEN ISNULL(P1.TENTATIVE_CUR,-1) = -1  ");   //UPD UBIQ-SAI 09.01.16
                //strSQL.Append("   THEN P2.ACT_CUR ELSE P1.TENTATIVE_CUR END,'1')  ");                     //UPD UBIQ-SAI 09.01.16
                strSQL.Append("   AND S2.KEY02 = ISNULL(CASE WHEN ISNULL(P1.TENTATIVE_PRC,-1) = -1              ");
                strSQL.Append("   THEN (CASE WHEN P2.COM_PRC_FLAG = 0 THEN P2.ACT_CUR ELSE P2.TENTATIVE_CUR END)");
                strSQL.Append("   ELSE (CASE WHEN P1.COM_PRC_FLAG = 0 THEN P1.ACT_CUR ELSE P1.TENTATIVE_CUR END)");
                strSQL.Append("   END,'')  ");
                strSQL.Append("   LEFT OUTER JOIN SYSTEM_PARAMETER S3 ON S3.KEY01 = 'CURRENCY_CD'               ");
                strSQL.Append("   AND S3.DATA_INT = 1                                                           ");
                strSQL.Append("   LEFT OUTER JOIN SYSTEM_PARAMETER S_SCH ON S_SCH.KEY01 = 'SCH_ID'              ");
                strSQL.Append("   AND S_SCH.KEY02 = P.SCH_ID                                                    ");

                db.DbParametersClear();
                strSQL.Append(" WHERE                               ");
                strSQL.Append("   P.SC_FLAG                 =     1 ");
                strSQL.Append(" AND  P.ITEM_TYPE            <> '99' ");

                //Add 10.08.25 Ubiq-Sai Start
                strSQL.Append("  AND P.JOC_CD NOT IN (SELECT D.JOC_CD                              ");
                strSQL.Append("                          FROM SALES_ORDER S, SALES_ORDER_DETAIL D   ");
                strSQL.Append("                         WHERE S.ORDER_NO = D.ORDER_NO               ");
                strSQL.Append("                           AND S.PO_TYPE <> 0 )                      ");
                //Add 10.08.25 Ubiq-Sai End

                //if (buyer_cd != "")
                //{
                strSQL.Append("   AND P.BUYER_CD         = @BUYER_CD ");
                db.DbPsetString("@BUYER_CD", _buyer_cd);
                //}
                if (sch_id != "")
                {
                    strSQL.Append("   AND P.SCH_ID               = @SCH_ID ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (vendor_cd != "")
                {
                    strSQL.Append("   AND P.VENDOR_CD               = @VENDOR_CD ");
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                }
                if (joc_cd != "")
                {
                    strSQL.Append("   AND P.JOC_CD            = @JOC_CD ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (item_no != "")  // 2011.08.01
                {
                    strSQL.Append("   AND P.ITEM_NO            = @ITEM_NO ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (catg_cd != "")
                {
                    strSQL.Append("   AND I.CATG_CD        = @CATG_CD ");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }
                if (sch_start_date != 0)
                {
                    strSQL.Append("   AND P.SCH_START_DATE              <= @SCH_START_DATE ");
                    db.DbPsetInt("@SCH_START_DATE", _sch_start_date);
                }
                if (amt_scope == "0") //2009.01.21
                {
                    if (po_amt != 0)
                    {
                        strSQL.Append(" AND P.PO_QTY * ISNULL(CASE WHEN ISNULL(P1.TENTATIVE_PRC,-1) = -1                ");
                        strSQL.Append(" THEN (CASE WHEN P2.COM_PRC_FLAG = 0 THEN P2.ACT_PRC ELSE P2.TENTATIVE_PRC END)  ");
                        strSQL.Append(" ELSE (CASE WHEN P1.COM_PRC_FLAG = 0 THEN P1.ACT_PRC ELSE P1.TENTATIVE_PRC END)  ");
                        strSQL.Append(" END, 0)   <= @PO_AMT                                                            ");

                        db.DbPsetDouble("@PO_AMT", _po_amt);
                    }
                }
                else
                {
                    if (po_amt != 0)
                    {
                        strSQL.Append(" AND P.PO_QTY * ISNULL(CASE WHEN ISNULL(P1.TENTATIVE_PRC,-1) = -1                ");
                        strSQL.Append(" THEN (CASE WHEN P2.COM_PRC_FLAG = 0 THEN P2.ACT_PRC ELSE P2.TENTATIVE_PRC END)  ");
                        strSQL.Append(" ELSE (CASE WHEN P1.COM_PRC_FLAG = 0 THEN P1.ACT_PRC ELSE P1.TENTATIVE_PRC END)  ");
                        strSQL.Append(" END, 0)   >= @PO_AMT                                                            ");
                        db.DbPsetDouble("@PO_AMT", _po_amt);
                    }
                }
                if (po_cur != "")
                {
                    strSQL.Append("   AND  CASE WHEN ISNULL(P1.TENTATIVE_PRC,-1) = -1                        ");
                    strSQL.Append("   THEN (CASE WHEN P2.COM_PRC_FLAG = 0 THEN P2.ACT_CUR ELSE P2.TENTATIVE_CUR END)");
                    strSQL.Append("   ELSE (CASE WHEN P1.COM_PRC_FLAG = 0 THEN P1.ACT_CUR ELSE P1.TENTATIVE_CUR END)");
                    strSQL.Append("   END  = @PO_CUR ");
                    //strSQL.Append(" AND CASE WHEN ISNULL(P1.TENTATIVE_CUR,-1) = -1 THEN P2.ACT_CUR ");
                    //strSQL.Append(" ELSE P1.TENTATIVE_CUR END = @PO_CUR  ");

                    db.DbPsetString("@PO_CUR", _po_cur);
                }
                strSQL.Append(" ORDER BY P.SCH_START_DATE ");
            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 購買オーダ情報を検索
        /// 
        /// 使用画面：PurPORlse
        /// </summary>
        public int Get_Pur_PoRlseDetail()//2009.02.04 UPDATE BY UBIQ-CHEN
        {
            ComDB db = new ComDB(_db_type);
            ComLibrary com = new ComLibrary();
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql            
            strSQL.Append("SELECT ");
            strSQL.Append("P.ORDER_NO,M.ALARM_TYPE,P.SCH_ID,P.ITEM_NO,P.ITEM_DESC,P.VENDOR_CD,V.VENDOR_DESC,            ");
            strSQL.Append("P.PO_QTY, S1.DATA_CHAR PO_UMSR, PO_PRC =                                                     ");
            //strSQL.Append("ISNULL(CASE WHEN ISNULL(P1.TENTATIVE_PRC,-1) = -1  THEN P2.ACT_PRC ELSE P1.TENTATIVE_PRC END, 0),  "); //UPD UBIQ-SAI 09.01.16
            strSQL.Append("ISNULL(CASE WHEN ISNULL(P1.TENTATIVE_PRC,-1) = -1                                            ");
            strSQL.Append("THEN (CASE WHEN P2.COM_PRC_FLAG = 0 THEN P2.ACT_PRC ELSE P2.TENTATIVE_PRC END)               ");
            strSQL.Append("ELSE (CASE WHEN P1.COM_PRC_FLAG = 0 THEN P1.ACT_PRC ELSE P1.TENTATIVE_PRC END) END, 0),      ");
            //strSQL.Append("P.PO_QTY * CASE WHEN ISNULL(P1.TENTATIVE_PRC,-1) = -1 THEN P2.ACT_PRC ELSE P1.TENTATIVE_PRC  END PO_AMT,	"); //UPD UBIQ-SAI 09.01.16
            strSQL.Append("P.PO_QTY * ISNULL(CASE WHEN ISNULL(P1.TENTATIVE_PRC,-1) = -1 ");
            strSQL.Append("THEN (CASE WHEN P2.COM_PRC_FLAG = 0 THEN P2.ACT_PRC ELSE P2.TENTATIVE_PRC END)               ");
            strSQL.Append("ELSE (CASE WHEN P1.COM_PRC_FLAG = 0 THEN P1.ACT_PRC ELSE P1.TENTATIVE_PRC END) END,0) PO_AMT,");
            strSQL.Append("PO_CUR = ISNULL(CASE WHEN ISNULL(S2.KEY02,'' )= '' THEN S3.KEY02 ELSE S2.KEY02 END,''),      ");
            strSQL.Append("PO_CUR_NAME = ISNULL(CASE WHEN ISNULL(S2.DATA_CHAR,'' )= '' THEN S3.DATA_CHAR ELSE S2.DATA_CHAR END,''),       ");
            strSQL.Append("P.PO_DUE_DATE,P.JOC_CD,P.WHS_CD,  W.WHS_DESC,    S4.DATA_CHAR SCH_NAME                       ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PUR_ORDER P,SYSTEM_PARAMETER S1,SYSTEM_PARAMETER S2 ");
                strSQL.Append(" WHERE  ");
                strSQL.Append("  P.ORDER_NO              = :ORDER_NO ");
                strSQL.Append("  AND S1.KEY01 = 'ITEM_UMSR' AND P.PO_UMSR    = S1.KEY02 ");
                strSQL.Append("  AND S2.KEY01 = 'CURRENCY_CD' AND P.PO_CUR     = S2.KEY02 ");

                db.DbPsetString("ORDER_NO", _order_no);
            }
            else
            {
                strSQL.Append(" FROM PLANNED_ORDER P ");
                strSQL.Append(" LEFT JOIN PURCHASE_PRICE_MASTER P1     ON  P.ITEM_NO = P1.ITEM_NO                   ");
                //strSQL.Append(" AND P.WS_CD = P1.WS_CD    AND P.PROCESS_CD = P1.PROCESS_CD AND P.VENDOR_CD = P1.VENDOR_CD "); //UPD UBIQ-SAI 09.01.16
                strSQL.Append(" AND P.WS_CD = CASE WHEN P1.WS_CD = '*' THEN '' ELSE P1.WS_CD END                    ");
                strSQL.Append(" AND P.PROCESS_CD = P1.PROCESS_CD AND P.VENDOR_CD = P1.VENDOR_CD                     ");
                strSQL.Append(" AND P1.BEG_EFF_DATE <= P.SCH_START_DATE    AND P1.END_EFF_DATE >= P.SCH_START_DATE  ");
                strSQL.Append(" AND P1.UNIT_PRC_BASE = 0    LEFT JOIN PURCHASE_PRICE_MASTER P2    ON   ");
                //strSQL.Append(" P.ITEM_NO = P2.ITEM_NO AND P.WS_CD = P2.WS_CD     AND P.PROCESS_CD = P2.PROCESS_CD  ");   //UPD UBIQ-SAI 09.01.16
                strSQL.Append(" P.ITEM_NO = P2.ITEM_NO AND P.WS_CD = CASE WHEN P2.WS_CD = '*'                       ");
                strSQL.Append(" THEN '' ELSE P2.WS_CD END AND P.PROCESS_CD = P2.PROCESS_CD                          ");
                strSQL.Append(" AND P.VENDOR_CD = P2.VENDOR_CD    AND P2.BEG_EFF_DATE <= P.SCH_COMPL_DATE AND       ");
                strSQL.Append(" P2.END_EFF_DATE >= P.SCH_COMPL_DATE AND P2.UNIT_PRC_BASE = 1                        ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER I ON P.ITEM_NO = I.ITEM_NO                                    ");
                strSQL.Append(" LEFT JOIN VENDOR_MASTER V ON P.VENDOR_CD = V.VENDOR_CD                              ");
                strSQL.Append(" LEFT JOIN MRP_ALARM M ON P.ORDER_NO = M.ORDER_NO                                    ");
                strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER W ON P.WHS_CD = W.WHS_CD                                 ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S1 ON S1.KEY01 = 'ITEM_UMSR' AND S1.KEY02 = P.PO_UMSR    ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'CURRENCY_CD' AND                       ");
                //strSQL.Append(" S2.KEY02 = ISNULL(CASE WHEN ISNULL(P1.TENTATIVE_CUR,-1) = -1   ");        //UPD UBIQ-SAI 09.01.16
                //strSQL.Append(" THEN P2.ACT_CUR ELSE P1.TENTATIVE_CUR END,'1') ");                        //UPD UBIQ-SAI 09.01.16
                strSQL.Append(" S2.KEY02 = ISNULL(CASE WHEN ISNULL(P1.TENTATIVE_PRC,-1) = -1                        ");
                strSQL.Append(" THEN (CASE WHEN P2.COM_PRC_FLAG = 0 THEN P2.ACT_CUR ELSE P2.TENTATIVE_CUR END)      ");
                strSQL.Append(" ELSE (CASE WHEN P1.COM_PRC_FLAG = 0 THEN P1.ACT_CUR ELSE P1.TENTATIVE_CUR END) END,'')  ");
                strSQL.Append("   LEFT OUTER JOIN SYSTEM_PARAMETER S3 ON S3.KEY01 = 'CURRENCY_CD'               ");
                strSQL.Append("   AND S3.DATA_INT = 1                                                           ");
                strSQL.Append("   LEFT OUTER JOIN SYSTEM_PARAMETER S4 ON S4.KEY01 = 'SCH_ID'                    ");
                strSQL.Append("   AND S4.KEY02 = P.SCH_ID                                                       ");

                db.DbParametersClear();

                strSQL.Append(" WHERE  ");
                strSQL.Append("   P.ORDER_NO              = @ORDER_NO ");

                db.DbPsetString("@ORDER_NO", _order_no);

            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _order_no = db.Row("ORDER_NO");
                _alarm_type = com.StringToInt(db.Row("ALARM_TYPE"));
                _sch_id = db.Row("SCH_ID");
                _item_no = db.Row("ITEM_NO");
                _item_desc = db.Row("ITEM_DESC");
                _vendor_cd = db.Row("VENDOR_CD");
                _vendor_desc = db.Row("VENDOR_DESC");
                _po_qty = com.StringToDouble(db.Row("PO_QTY"));
                _po_umsr = db.Row("PO_UMSR");
                _po_prc = com.StringToDouble(db.Row("PO_PRC"));
                _po_amt = com.StringToDouble(db.Row("PO_AMT"));
                _po_cur = db.Row("PO_CUR");
                _po_cur_name = db.Row("PO_CUR_NAME");
                _po_due_date = com.StringToInt(db.Row("PO_DUE_DATE"));
                _joc_cd = db.Row("JOC_CD");
                _whs_cd = db.Row("WHS_CD");
                _whs_desc = db.Row("WHS_DESC");
                _sch_name = db.Row("SCH_NAME");

            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// 発注指示
        /// 
        /// 使用画面：PurPORlse
        /// </summary>
        public int Pur_PoRlse()// UPD BY UBIQ-CHEN 2009.02.02
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ORDER_NO", _order_no, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
            //ADD BY UBIQ-CHEN 2009.02.10
            db.DbPsetString("@I_VENDOR_NAME", _vendor_name, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_ITEM_NO", _vendor_item_no, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_ITEM_DESC", _vendor_item_desc, ComConst.DB_IN);
            //ADD END
            db.DbPsetDouble("@I_PO_QTY", _po_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_PO_PRC", _po_prc, ComConst.DB_IN);
            db.DbPsetString("@I_PO_CUR", _po_cur, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_DUE_DATE", po_due_date, ComConst.DB_IN);
            db.DbPsetString("@I_PO_NOTE", _po_note, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PUR_PORLSE");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                db.DbCommit();
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 発注計画一覧表を検索
        /// 
        /// 使用画面：PurPORlseRpt
        /// </summary>
        public DataSet Get_Pur_PoRlseRpt()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql            
            strSQL.Append(" SELECT                                                                                  ");
            strSQL.Append(" PO.SCH_START_DATE,                                                                      ");//ADD BY LIU 2010/09/29
            strSQL.Append(" PO.BUYER_CD,S_BUYER_NAME.DATA_CHAR BUYER_NAME,PO.SCH_ID,S_SCH_NAME.DATA_CHAR SCH_NAME,  ");
            strSQL.Append(" PO.ORDER_NO,PO.ITEM_NO,PO.ITEM_DESC,PO.PO_QTY,S_PUMSR_NAME.DATA_CHAR PUMSR_NAME,        ");
            strSQL.Append(" PO.VENDOR_CD,       VM.VENDOR_NAME,                 ISNULL(CASE PPM.COM_PRC_FLAG        ");
            strSQL.Append(" WHEN 1 THEN PPM.TENTATIVE_PRC WHEN 0 THEN PPM.ACT_PRC END,0) PRICE,                     ");
            strSQL.Append(" (PO.PO_QTY * ISNULL(CASE PPM.COM_PRC_FLAG WHEN 1 THEN PPM.TENTATIVE_PRC                 ");
            strSQL.Append(" WHEN 0 THEN PPM.ACT_PRC END,0)) PO_AMT,                                                 ");
            strSQL.Append(" S_CUR_NAME2.DATA_CHAR PO_CUR,S_BASE_CUR.DATA_DEC3 CUR_RATIO,PO.PO_DUE_DATE,             ");
            strSQL.Append(" (PO.PO_QTY * ISNULL(CASE PPM.COM_PRC_FLAG WHEN 1 THEN PPM.TENTATIVE_PRC                 ");
            strSQL.Append(" WHEN 0 THEN PPM.ACT_PRC END,0) * S_BASE_CUR.DATA_DEC3) BASE_AMT                         ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PLANNED_ORDER PO, ");
                strSQL.Append(" ITEM_MASTER IM, ");
                strSQL.Append("      PURCHASE_PRICE_MASTER PPM, ");
                strSQL.Append("  VENDOR_MASTER VM, ");
                strSQL.Append("  SYSTEM_PARAMETER S_BUYER_NAME,");
                strSQL.Append("  SYSTEM_PARAMETER S_SCH_NAME, ");
                //strSQL.Append("  SYSTEM_PARAMETER S_CUR_NAME1,");
                strSQL.Append("  SYSTEM_PARAMETER S_CUR_NAME2,");
                strSQL.Append("  SYSTEM_PARAMETER S_PUMSR_NAME ");

                strSQL.Append(" WHERE  ");
                strSQL.Append("   PO.ITEM_NO = IM.ITEM_NO ");
                strSQL.Append(" AND PO.ITEM_TYPE  <> '99' ");
                if (sch_id != "")
                {
                    strSQL.Append("   AND   PO.SCH_ID  = :SCH_ID ");
                    db.DbPsetString("SCH_ID", _sch_id);
                }
                strSQL.Append("   AND S_SCH_NAME.KEY01 = 'SCH_ID' AND S_SCH_NAME.KEY02 = PO.SCH_ID(+) ");
                if (buyer_cd != "")
                {
                    strSQL.Append("   AND PO.BUYER_CD  = :BUYER_CD ");
                    db.DbPsetString("BUYER_CD", _buyer_cd);
                }
                strSQL.Append("   AND S_BUYER_NAME.KEY01 = 'BUYER_CD' AND S_BUYER_NAME.KEY02 = PO.BUYER_CD(+) ");

                if (sch_start_date != 0)
                {
                    strSQL.Append(" AND PO.SCH_START_DATE  <= :SCH_START_DATE ");
                    db.DbPsetInt("SCH_START_DATE", _sch_start_date);
                }
                if (joc_cd != "")
                {
                    strSQL.Append("   AND PO.JOC_CD              = :JOC_CD ");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }
                if (catg_cd != "")
                {
                    strSQL.Append("   AND IM.CATG_CD        = :CATG_CD ");
                    db.DbPsetString("CATG_CD", _catg_cd);
                }
                if (vendor_cd != "")
                {
                    strSQL.Append("   AND P.VENDOR_CD               = :VENDOR_CD ");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                }
                strSQL.Append(" AND PO.VENDOR_CD = VM.VENDOR_CD(+)  ");
                strSQL.Append(" AND PO.PO_DUE_DATE >= VM.BEG_EFF_DATE(+)  ");
                strSQL.Append(" AND PO.PO_DUE_DATE <= VM.END_EFF_DATE(+)  ");
                strSQL.Append(" AND PO.ITEM_NO = PPM.ITEM_NO(+) ");
                strSQL.Append(" AND PO.VENDOR_CD = PPM.VENDOR_CD(+) ");
                strSQL.Append(" AND PO.WS_CD = PPM.WS_CD(+) ");
                strSQL.Append(" AND PO.PROCESS_CD = PPM.PROCESS_CD(+) ");
                strSQL.Append(" AND SP_GET_EFF_DATE(PO.ITEM_NO, PO.WS_CD, PO.PROCESS_CD, PO.VENDOR_CD, PO.SCH_START_DATE, PO.SCH_COMPL_DATE)(+) >= PPM.BEG_EFF_DATE  ");
                strSQL.Append(" AND SP_GET_EFF_DATE(PO.ITEM_NO, PO.WS_CD, PO.PROCESS_CD, PO.VENDOR_CD, PO.SCH_START_DATE, PO.SCH_COMPL_DATE)(+) <= PPM.END_EFF_DATE  ");
                //if (po_cur != "")
                //{
                //    strSQL.Append(" AND S_CUR_NAME1.KEY01 = 'CURRENCY_CD'  ");
                //    strSQL.Append(" AND   S_CUR_NAME1.KEY02 = :PO_CUR  ");
                //    db.DbPsetString("PO_CUR", _po_cur);
                //    strSQL.Append(" AND   CASE PPM.COM_PRC_FLAG WHEN 0 THEN PPM.ACT_CUR ELSE PPM.TENTATIVE_CUR END = PO_CUR  ");
                //    db.DbPsetString("PO_CUR", _po_cur);
                //}
                if (po_amt != 0)
                {
                    strSQL.Append(" AND   (PO.PO_QTY * (CASE PPM.COM_PRC_FLAG WHEN 1 THEN PPM.TENTATIVE_PRC WHEN 0 THEN PPM.ACT_PRC END)) <= :PO_AMT  ");
                    db.DbPsetDouble("PO_AMT", _po_amt);
                }

                strSQL.Append(" AND   S_CUR_NAME2.KEY01 = 'CURRENCY_CD'  ");
                strSQL.Append(" AND   S_CUR_NAME2.KEY02(+) = CASE PPM.COM_PRC_FLAG WHEN 0 THEN PPM.ACT_CUR ELSE PPM.TENTATIVE_CUR END  ");
                strSQL.Append(" AND   S_PUMSR_NAME.KEY01 = 'ITEM_UMSR'  ");
                strSQL.Append(" AND   S_PUMSR_NAME.KEY02(+) = PO.PO_UMSR  ");
            }
            else
            {
                strSQL.Append("   FROM PLANNED_ORDER PO                                                     ");
                strSQL.Append("   INNER JOIN ITEM_MASTER IM ON PO.ITEM_NO = IM.ITEM_NO                      ");
                strSQL.Append("   LEFT OUTER JOIN PURCHASE_PRICE_MASTER PPM1 ON PO.ITEM_NO = PPM1.ITEM_NO   ");
                strSQL.Append("   AND PO.VENDOR_CD = PPM1.VENDOR_CD AND PO.WS_CD = CASE WHEN PPM1.WS_CD = '*' THEN '' ELSE PPM1.WS_CD END  ");
                strSQL.Append("   AND PO.PROCESS_CD = PPM1.PROCESS_CD                                       ");
                strSQL.Append("   AND PO.SCH_START_DATE >= PPM1.BEG_EFF_DATE                                ");
                strSQL.Append("   AND PO.SCH_START_DATE <= PPM1.END_EFF_DATE                                ");
                strSQL.Append("   LEFT OUTER JOIN PURCHASE_PRICE_MASTER PPM2 ON PO.ITEM_NO = PPM2.ITEM_NO   ");
                strSQL.Append("   AND PO.VENDOR_CD = PPM2.VENDOR_CD AND PO.WS_CD = CASE WHEN PPM2.WS_CD = '*' THEN '' ELSE PPM2.WS_CD END   ");
                strSQL.Append("   AND PO.PROCESS_CD = PPM2.PROCESS_CD                                       ");
                strSQL.Append("   AND PO.SCH_COMPL_DATE >= PPM2.BEG_EFF_DATE                                ");
                strSQL.Append("   AND PO.SCH_COMPL_DATE <= PPM2.END_EFF_DATE                                ");
                strSQL.Append("   LEFT OUTER JOIN PURCHASE_PRICE_MASTER PPM ON PO.ITEM_NO = PPM.ITEM_NO     ");
                strSQL.Append("   AND PO.VENDOR_CD = PPM.VENDOR_CD AND PO.WS_CD = CASE WHEN PPM.WS_CD = '*' THEN '' ELSE PPM.WS_CD END      ");
                strSQL.Append("   AND PO.PROCESS_CD = PPM.PROCESS_CD                                        ");
                strSQL.Append("   AND ISNULL(CASE WHEN ISNULL((CASE WHEN ISNULL(PPM1.BEG_EFF_DATE,-1) = -1 THEN PPM1.END_EFF_DATE ELSE PPM1.BEG_EFF_DATE END),-1) = -1        ");
                strSQL.Append("   THEN (CASE WHEN ISNULL(PPM2.BEG_EFF_DATE,-1) = -1 THEN PPM2.END_EFF_DATE ELSE PPM2.BEG_EFF_DATE END)                                        ");
                strSQL.Append("   ELSE (CASE WHEN ISNULL(PPM1.BEG_EFF_DATE,-1) = -1 THEN PPM1.END_EFF_DATE ELSE PPM1.BEG_EFF_DATE END) END, 0)                                ");
                strSQL.Append("   >= PPM.BEG_EFF_DATE                                                       ");
                strSQL.Append("   AND ISNULL(CASE WHEN ISNULL((CASE WHEN ISNULL(PPM1.BEG_EFF_DATE,-1) = -1 THEN PPM1.END_EFF_DATE ELSE PPM1.BEG_EFF_DATE END),-1) = -1        ");
                strSQL.Append("   THEN (CASE WHEN ISNULL(PPM2.BEG_EFF_DATE,-1) = -1 THEN PPM2.END_EFF_DATE ELSE PPM2.BEG_EFF_DATE END)                                        ");
                strSQL.Append("   ELSE (CASE WHEN ISNULL(PPM1.BEG_EFF_DATE,-1) = -1 THEN PPM1.END_EFF_DATE ELSE PPM1.BEG_EFF_DATE END) END, 0)                                ");
                strSQL.Append("   <= PPM.END_EFF_DATE                                                       ");
                strSQL.Append("   LEFT OUTER JOIN VENDOR_MASTER VM  ON PO.VENDOR_CD = VM.VENDOR_CD          ");
                strSQL.Append("   AND PO.PO_DUE_DATE >= VM.BEG_EFF_DATE                                     ");
                strSQL.Append("   AND PO.PO_DUE_DATE <= VM.END_EFF_DATE                                     ");
                strSQL.Append("   LEFT OUTER JOIN SYSTEM_PARAMETER S_BUYER_NAME                             ");
                strSQL.Append("   ON S_BUYER_NAME.KEY01 = 'BUYER_CD' AND S_BUYER_NAME.KEY02 = PO.BUYER_CD   ");
                strSQL.Append("   LEFT OUTER JOIN SYSTEM_PARAMETER S_SCH_NAME                               ");
                strSQL.Append("   ON S_SCH_NAME.KEY01 = 'SCH_ID' AND S_SCH_NAME.KEY02 = PO.SCH_ID           ");
                //strSQL.Append("   LEFT OUTER JOIN SYSTEM_PARAMETER S_CUR_NAME1 ");
                //strSQL.Append("   ON S_CUR_NAME1.KEY01 = 'CURRENCY_CD' AND   S_CUR_NAME1.KEY02 = 画面選択通貨コード  ");
                strSQL.Append("   LEFT OUTER JOIN SYSTEM_PARAMETER S_CUR_NAME2                              ");
                strSQL.Append("   ON S_CUR_NAME2.KEY01 = 'CURRENCY_CD'                                      ");
                strSQL.Append("   AND S_CUR_NAME2.KEY02 = CASE PPM.COM_PRC_FLAG                             ");
                strSQL.Append("   WHEN 0 THEN PPM.ACT_CUR ELSE PPM.TENTATIVE_CUR END                        ");
                strSQL.Append("   LEFT OUTER JOIN SYSTEM_PARAMETER S_PUMSR_NAME                             ");
                strSQL.Append("   ON S_PUMSR_NAME.KEY01 = 'ITEM_UMSR' AND S_PUMSR_NAME.KEY02 = PO.PO_UMSR   ");
                strSQL.Append("   LEFT OUTER JOIN SYSTEM_PARAMETER S_BASE_CUR ON S_BASE_CUR.KEY01 = 'CURRENCY_CD'   ");
                strSQL.Append("   AND S_BASE_CUR.DATA_INT = 1                                                       ");

                db.DbParametersClear();
                strSQL.Append(" WHERE  PO.SC_FLAG = 1 ");
                strSQL.Append(" AND PO.ITEM_TYPE  <> '99' ");

                if (buyer_cd != "")
                {
                    strSQL.Append(" AND PO.BUYER_CD = @BUYER_CD                 ");
                    db.DbPsetString("@BUYER_CD", _buyer_cd);
                }
                if (sch_id != "")
                {
                    strSQL.Append("   AND PO.SCH_ID = @SCH_ID                   ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (vendor_cd != "")
                {
                    strSQL.Append("   AND PO.VENDOR_CD  = @VENDOR_CD            ");
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                }

                if (sch_start_date != 0)
                {
                    strSQL.Append("   AND PO.SCH_START_DATE  <= @SCH_START_DATE ");
                    db.DbPsetInt("@SCH_START_DATE", _sch_start_date);
                }
                if (joc_cd != "")
                {
                    strSQL.Append("   AND PO.JOC_CD  = @JOC_CD                  ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (catg_cd != "")
                {
                    strSQL.Append("   AND IM.CATG_CD  = @CATG_CD                ");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }
                if (po_cur != "")
                {
                    strSQL.Append(" AND CASE PPM.COM_PRC_FLAG WHEN 0 THEN PPM.ACT_CUR   ");
                    strSQL.Append(" ELSE PPM.TENTATIVE_CUR END = @PO_CUR                ");
                    db.DbPsetString("@PO_CUR", _po_cur);
                }
                if (po_amt != 0)
                {
                    strSQL.Append(" AND (PO.PO_QTY * ISNULL(CASE PPM.COM_PRC_FLAG WHEN 1 THEN PPM.TENTATIVE_PRC ");
                    strSQL.Append(" WHEN 0 THEN PPM.ACT_PRC END,0))  <= @PO_AMT                                 ");

                    db.DbPsetDouble("@PO_AMT", _po_amt);
                }

            }
            strSQL.Append(" ORDER BY PO.BUYER_CD, PO.SCH_ID, PO.ORDER_NO, PO.ITEM_NO    ");

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 在庫予定を検索
        /// 
        /// 使用画面：PurManPORlse
        /// </summary>
        public DataSet Get_View_Sch_StockList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            ////・入庫予定
            //strSQL.Append(" SELECT          TYPE,           ORDER_NO,                                                   ");
            //strSQL.Append(" SCH_DATE,       ORDER_QTY,      ORDER_UMSR,         JOB_ORDER_NO,       VENDOR_CD,          ");
            ////strSQL.Append(" JOC_CD,         ALARM_TYPE,     WS_CD,              PLAN_QTY ,          ITEM_UMSR,          ");
            //strSQL.Append(" JOC_CD,         ALARM_TYPE,     WS_CD,              PLAN_QTY ,                              ");//UPD 20090216 UBIQ-LIU
            //strSQL.Append(" PARENT_ITEM_NO, ITEM_DESC,      PARENT_ORDER_QTY,   S.DATA_CHAR UMSR_DESC                   ");
            //strSQL.Append(" FROM  (                                                                                     ");
            //strSQL.Append(" SELECT   0 AS TYPE,         A.ORDER_NO,                                                     ");
            //strSQL.Append(" A.SCH_COMPL_DATE SCH_DATE,  A.ORDER_QTY, A.ORDER_UMSR, A.JOB_ORDER_NO,  A.VENDOR_CD,        ");
            ////strSQL.Append(" A.JOC_CD,      M.ALARM_TYPE,     null  WS_CD,        null   PLAN_QTY ,  null ITEM_UMSR,  ");
            ////strSQL.Append(" A.JOC_CD,      M.ALARM_TYPE,     null  WS_CD,        null   PLAN_QTY ,                      ");//UPD 20090216 UBIQ-LIU
            //strSQL.Append(" A.JOC_CD,      0 ALARM_TYPE,     null  WS_CD,        null   PLAN_QTY ,                      ");//IMV3
            //strSQL.Append(" null PARENT_ITEM_NO,      null ITEM_DESC,     null  PARENT_ORDER_QTY                        ");
            //strSQL.Append(" FROM  (                                                                                     ");
            //// IMV3 COMMENT OUT
            ////strSQL.Append(" SELECT                                                                                      ");
            ////strSQL.Append(" SCH_COMPL_DATE,      ORDER_QTY, ORDER_UMSR,    Null JOB_ORDER_NO,      VENDOR_CD,           ");
            ////strSQL.Append(" JOC_CD        ,      ORDER_NO                                                               ");
            ////strSQL.Append(" FROM   PLANNED_ORDER                                                    ");
            ////strSQL.Append(" WHERE ITEM_NO        = @ITEM_NO                                         ");
            ////strSQL.Append(" AND WHS_CD        = @WHS_CD                                             ");
            /////*-------Add By Ubiq-Chen 2009.06.05 Begin------*/
            ////if (short_flag == 1)
            ////{
            ////    strSQL.Append(" AND SCH_ID        = @SCH_ID                                      ");
            ////    //strSQL.Append(" AND WS_CD        = @WS_CD                                        ");  //Del Ubiq-Sai 09.08.04
            ////}
            /////*-------Add By Ubiq-Chen 2009.06.05 End-------*/
            ////strSQL.Append(" UNION                                                                   ");
            //strSQL.Append("SELECT                                                                   ");
            //strSQL.Append(" SCH_COMPL_DATE,    JOB_ORDER_QTY - STOCK_QTY ORDER_QTY,  ORDER_UMSR,     ");
            //strSQL.Append(" JOB_ORDER_NO,      VENDOR_CD,       JOC_CD         ,ORDER_NO            ");
            //strSQL.Append(" FROM   PUR_ORDER                                                        ");
            //strSQL.Append(" WHERE ITEM_NO        = @ITEM_NO                                         ");
            //strSQL.Append(" AND WHS_CD           = @WHS_CD                                          ");
            ///*-------Add By Ubiq-Chen 2009.06.05 Begin------*/
            //if (short_flag == 1)
            //{
            //    strSQL.Append(" AND SCH_ID        = @SCH_ID                                      ");
            //    //strSQL.Append(" AND WS_CD        = @WS_CD                                        ");  //Del Ubiq-Sai 09.08.04
            //}
            ///*-------Add By Ubiq-Chen 2009.06.05 End-------*/
            ////strSQL.Append(" AND ORDER_STATUS     <= 30                                              ");//20090325 UBIQ-LIU ADD
            //strSQL.Append(" AND JOB_ORDER_QTY - STOCK_QTY   > 0                                     ");
            //strSQL.Append(" AND ORDER_STATUS     < 77                                               ");

            ////検収済未入庫
            //strSQL.Append(" UNION                                                         			");
            //strSQL.Append(" SELECT                                                         			");
            //strSQL.Append(" 	 PO.SCH_COMPL_DATE,    TR.ORDER_QTY,       PO.ORDER_UMSR,  			");
            //strSQL.Append(" 	 PO.JOB_ORDER_NO,      PO.VENDOR_CD,       PO.JOC_CD   ,PO.ORDER_NO ");
            //strSQL.Append(" FROM PUR_ORDER PO														");
            //strSQL.Append(" INNER JOIN                                                				");
            //strSQL.Append(" (SELECT ORDER_NO, ISNULL(SUM(INST_QTY), 0) ORDER_QTY					");
            //strSQL.Append("    FROM TRANSFER_TRANS													");
            //strSQL.Append("   WHERE REQ_TYPE = '11' 												");
            //strSQL.Append("     AND XFER_STATUS < 20												");
            //strSQL.Append("     AND ORDER_NO IN ( SELECT ORDER_NO 									");
            //strSQL.Append(" 					    FROM PUR_ORDER									");
            //strSQL.Append(" 					   WHERE ITEM_NO  = @ITEM_NO						");
            //strSQL.Append(" 					     AND WHS_CD   = @WHS_CD							");
            //strSQL.Append(" 					     AND (ORDER_STATUS = 77 OR ORDER_STATUS = 85) )	");
            //strSQL.Append("  GROUP BY ORDER_NO ) TR													");
            //strSQL.Append(" ON PO.ORDER_NO = TR.ORDER_NO											");
            //strSQL.Append(" WHERE TR.ORDER_QTY > 0      											");
            //if (short_flag == 1)
            //{
            //    strSQL.Append(" AND PO.SCH_ID        = @SCH_ID                                      ");
            //}

            //strSQL.Append(" UNION                                                                   ");
            //strSQL.Append("SELECT                                                                   ");
            //strSQL.Append(" SCH_COMPL_DATE,    JOB_ORDER_QTY - STOCK_QTY ORDER_QTY,  ORDER_UMSR,     ");
            //strSQL.Append(" JOB_ORDER_NO,      WS_CD VENDOR_CD,       JOC_CD   ,ORDER_NO            ");
            //strSQL.Append(" FROM   JOB_ORDER                                                        ");
            //strSQL.Append(" WHERE ITEM_NO        = @ITEM_NO                                         ");
            //strSQL.Append(" AND WHS_CD           = @WHS_CD                                          ");
            ///*-------Add By Ubiq-Chen 2009.06.05 Begin------*/
            //if (short_flag == 1)
            //{
            //    strSQL.Append(" AND SCH_ID        = @SCH_ID                                      ");
            //    //strSQL.Append(" AND WS_CD        = @WS_CD                                        ");  //Del Ubiq-Sai 09.08.04
            //}
            ///*-------Add By Ubiq-Chen 2009.06.05 End-------*/
            ////strSQL.Append(" AND ORDER_STATUS     <= 30                                              ");
            //strSQL.Append(" AND JOB_ORDER_QTY - STOCK_QTY   > 0                                     ");
            //strSQL.Append(" AND ORDER_STATUS     < 85                                               ");

            ////完成済未入庫
            //strSQL.Append(" UNION                                                         					");
            //strSQL.Append(" SELECT                                                         					");
            //strSQL.Append(" 	 JO.SCH_COMPL_DATE,    TR.ORDER_QTY,             JO.ORDER_UMSR,             ");
            //strSQL.Append(" 	 JO.JOB_ORDER_NO,      JO.WS_CD VENDOR_CD,       JO.JOC_CD   ,JO.ORDER_NO   ");
            //strSQL.Append("   FROM JOB_ORDER JO                                                             ");
            //strSQL.Append(" INNER JOIN                                                                      ");
            //strSQL.Append(" (SELECT ORDER_NO, ISNULL(SUM(INST_QTY), 0) ORDER_QTY                            ");
            //strSQL.Append("    FROM TRANSFER_TRANS                                                          ");
            //strSQL.Append("   WHERE REQ_TYPE = '12'                                                         ");
            //strSQL.Append("     AND XFER_STATUS < 20                                                        ");
            //strSQL.Append("     AND ORDER_NO IN ( SELECT ORDER_NO                                           ");
            //strSQL.Append(" 					    FROM JOB_ORDER                                          ");
            //strSQL.Append(" 					   WHERE ITEM_NO  = @ITEM_NO                                ");
            //strSQL.Append(" 					     AND WHS_CD   = @WHS_CD                                 ");
            //strSQL.Append(" 					     AND ORDER_STATUS = 85 )                                ");
            //strSQL.Append("  GROUP BY ORDER_NO ) TR                                                         ");
            //strSQL.Append(" ON JO.ORDER_NO = TR.ORDER_NO                                                    ");
            //strSQL.Append(" WHERE TR.ORDER_QTY > 0      											");
            //if (short_flag == 1)
            //{
            //    strSQL.Append(" AND JO.SCH_ID        = @SCH_ID                                      ");
            //}

            //strSQL.Append(" ) A                                                                     ");
            ////strSQL.Append(" LEFT OUTER JOIN MRP_ALARM M ON A.ORDER_NO = M.ORDER_NO                  ");   // IMV3
            //strSQL.Append(" UNION                                                                   ");
            ////・出庫予定
            //strSQL.Append("SELECT  1 AS TYPE,    A.ORDER_NO,                                        ");
            ////strSQL.Append("A.SCH_DISB_DATE SCH_DATE,null ORDER_QTY, null ORDER_UMSR, null JOB_ORDER_NO,null VENDOR_CD,");
            ////strSQL.Append("A.JOC_CD        , null ALARM_TYPE ,      A.WS_CD,    A.PLAN_QTY ,  A.ITEM_UMSR,      ");
            //strSQL.Append("A.SCH_DISB_DATE SCH_DATE,null ORDER_QTY, A.ITEM_UMSR ORDER_UMSR, null JOB_ORDER_NO,null VENDOR_CD,");
            //strSQL.Append("A.JOC_CD        , null ALARM_TYPE ,      A.WS_CD,    A.PLAN_QTY,         ");//UPD 20090216 UBIQ-LIU
            //strSQL.Append("A.PARENT_ITEM_NO        , A.ITEM_DESC ,     A.ORDER_QTY PARENT_ORDER_QTY ");
            //strSQL.Append(" FROM  (                                                                 ");
            //// IMV3 COMMENT OUT
            ////strSQL.Append("SELECT                                                                   ");
            ////strSQL.Append(" PD.SCH_DISB_DATE, PD.WS_CD, CASE WHEN IM.WIP_TYPE = 0 THEN PD.PLAN_QTY ELSE (CASE WHEN PD.ALLOC_FLAG <> 0 THEN PD.PLAN_DISB_QTY + PD.ALLOC_QTY - PD.ACT_DISB_QTY ELSE PD.PLAN_QTY END) END PLAN_QTY,  PD.ITEM_UMSR,   PD.JOC_CD,      ");	//UPD BY UBIQ-SAI WIP_TYPE = 0 -> WIP_TYPE = 1
            ////strSQL.Append(" PO.ITEM_NO PARENT_ITEM_NO,  PO.ITEM_DESC,  PO.ORDER_QTY,PO.ORDER_NO     ");
            ////strSQL.Append(" FROM  PLANNED_DEMAND PD, PLANNED_ORDER PO, ITEM_MASTER IM               ");
            ////strSQL.Append(" WHERE PD.ORDER_NO        = PO.ORDER_NO                                  ");
            ////strSQL.Append(" AND   PD.ITEM_NO         = IM.ITEM_NO                                    ");
            ////strSQL.Append(" AND (PD.SUB_GRP_CD = '' OR (PD.SUB_GRP_CD <> '' AND PD.SUB_ACTION_FLAG = 1))  ");
            ////strSQL.Append(" AND PD.ITEM_TYPE  <> '99' 												");
            ////strSQL.Append(" AND PD.DISB_WHS        = @WHS_CD                                        ");
            ////strSQL.Append(" AND PD.ITEM_NO        = @ITEM_NO                                        ");
            /////*-------Add By Ubiq-Chen 2009.06.05 Begin------*/
            ////if (short_flag == 1)
            ////{
            ////    strSQL.Append(" AND PD.SCH_ID        = @SCH_ID                                      ");
            ////    strSQL.Append(" AND PD.WS_CD        = @WS_CD                                        ");
            ////}

            //////Add 10.09.02 Ubiq-Sai Start
            ////strSQL.Append(" UNION ALL                                                               ");
            ////strSQL.Append("SELECT                                                                   ");
            ////strSQL.Append(" D.SCH_DISB_DATE, D.WS_CD , D.PLAN_QTY - D.INPUT_QTY PLAN_QTY, D.ITEM_UMSR,  ");
            ////strSQL.Append(" D.JOC_CD,        S.ITEM_NO PARENT_ITEM_NO,    IM.ITEM_DESC,  S.ORDER_QTY,   ");
            ////strSQL.Append(" S.ORDER_NO ");
            ////strSQL.Append(" FROM  DEMAND D, SALES_ORDER_DETAIL S, ITEM_MASTER IM                    ");
            ////strSQL.Append(" WHERE D.SO_NO        = S.ORDER_NO                                       ");
            ////strSQL.Append(" AND   D.JOC_SPLIT_NO = S.ORDER_LINE_NO                                  ");
            ////strSQL.Append(" AND   D.ITEM_NO         = IM.ITEM_NO                                    ");
            ////strSQL.Append(" AND (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))  ");
            ////strSQL.Append(" AND D.ITEM_TYPE <> '99'                                                 ");
            ////strSQL.Append(" AND D.DEMAND_STATUS     <= 30                                           ");
            ////strSQL.Append(" AND D.DISB_WHS       = @WHS_CD                                          ");
            ////strSQL.Append(" AND D.ITEM_NO        = @ITEM_NO                                         ");
            ////if (short_flag == 1)
            ////{
            ////    strSQL.Append(" AND D.SCH_ID        = @SCH_ID                                      ");
            ////}
            //////Add 10.09.02 Ubiq-Sai End

            /////*-------Add By Ubiq-Chen 2009.06.05 End-------*/
            ////strSQL.Append(" UNION ALL                                                               ");
            //strSQL.Append("SELECT                                                                   ");
            //strSQL.Append(" D.SCH_DISB_DATE, D.WS_CD , CASE WHEN IM.WIP_TYPE = 0 THEN D.PLAN_QTY -  ");		//UPD BY UBIQ-SAI WIP_TYPE = 0 -> WIP_TYPE = 1
            //strSQL.Append(" D.INPUT_QTY ELSE D.PLAN_DISB_QTY + D.ALLOC_QTY - D.ACT_DISB_QTY         ");
            //strSQL.Append(" END PLAN_QTY, D.ITEM_UMSR,                                              ");
            //strSQL.Append(" D.JOC_CD,   JO.ITEM_NO PARENT_ITEM_NO,  JO.ITEM_DESC,  JO.ORDER_QTY,    ");
            //strSQL.Append(" JO.ORDER_NO                                                             ");
            //strSQL.Append(" FROM  DEMAND D, JOB_ORDER JO, ITEM_MASTER IM                            ");
            //strSQL.Append(" WHERE D.ORDER_NO        = JO.ORDER_NO                                   ");
            //strSQL.Append(" AND   D.ITEM_NO         = IM.ITEM_NO                                    ");
            //strSQL.Append(" AND (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))  ");
            //strSQL.Append(" AND D.ITEM_TYPE  <> '99' 												");
            //strSQL.Append(" AND D.DEMAND_STATUS     <= 30                                           ");
            //strSQL.Append(" AND D.DISB_WHS       = @WHS_CD                                          ");
            //strSQL.Append(" AND D.ITEM_NO        = @ITEM_NO                                         ");
            ///*-------Add By Ubiq-Chen 2009.06.05 Begin------*/
            //if (short_flag == 1)
            //{
            //    strSQL.Append(" AND D.SCH_ID        = @SCH_ID                                      ");
            //    strSQL.Append(" AND D.WS_CD        = @WS_CD                                        ");
            //}
            ///*-------Add By Ubiq-Chen 2009.06.05 End-------*/
            ////strSQL.Append(" AND D.PLAN_DISB_QTY + D.ALLOC_QTY - D.ACT_DISB_QTY > 0                  ");//ADD 20090324 UBIQ-LIU
            //strSQL.Append(" UNION ALL                                                               ");
            //strSQL.Append("SELECT                                                                   ");
            //strSQL.Append(" D.SCH_DISB_DATE, D.WS_CD , CASE WHEN IM.WIP_TYPE = 0 THEN D.PLAN_QTY - D.INPUT_QTY ELSE D.PLAN_DISB_QTY + D.ALLOC_QTY - D.ACT_DISB_QTY END PLAN_QTY, D.ITEM_UMSR,       ");	//UPD BY UBIQ-SAI WIP_TYPE = 0 -> WIP_TYPE = 1
            //strSQL.Append(" D.JOC_CD,   PU.ITEM_NO PARENT_ITEM_NO,    PU.ITEM_DESC,  PU.ORDER_QTY,  ");
            //strSQL.Append(" PU.ORDER_NO                                                             ");
            //strSQL.Append(" FROM  DEMAND D, PUR_ORDER PU, ITEM_MASTER IM                            ");
            //strSQL.Append(" WHERE D.ORDER_NO        = PU.ORDER_NO                                   ");
            //strSQL.Append(" AND   D.ITEM_NO         = IM.ITEM_NO                                    ");
            //strSQL.Append(" AND (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))  ");
            //strSQL.Append(" AND D.ITEM_TYPE  <> '99' 												");
            //strSQL.Append(" AND D.DEMAND_STATUS     <= 30                                           ");
            //strSQL.Append(" AND D.DISB_WHS       = @WHS_CD                                          ");
            //strSQL.Append(" AND D.ITEM_NO        = @ITEM_NO                                         ");
            ///*-------Add By Ubiq-Chen 2009.06.05 Begin------*/
            //if (short_flag == 1)
            //{
            //    strSQL.Append(" AND D.SCH_ID        = @SCH_ID                                      ");
            //    strSQL.Append(" AND D.WS_CD        = @WS_CD                                        ");
            //    db.DbPsetString("@SCH_ID", _sch_id);
            //    db.DbPsetString("@WS_CD", _ws_cd);
            //}
            ///*-------Add By Ubiq-Chen 2009.06.05 End-------*/
            ////strSQL.Append(" AND D.PLAN_DISB_QTY + D.ALLOC_QTY - D.ACT_DISB_QTY > 0                  ");//ADD 20090324 UBIQ-LIU
            //strSQL.Append(" ) A                                                                     ");
            //strSQL.Append(" WHERE A.PLAN_QTY > 0                                                    ");
            //strSQL.Append("                        ) VIEW_DATE                                      ");
            //strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 =   'ITEM_UMSR'                 ");
            //strSQL.Append(" AND S.KEY02     =   ORDER_UMSR                                          ");
            ////strSQL.Append(" WHERE    SCH_DATE >= CONVERT(varchar(8), GETDATE(), 112)                ");
            ////strSQL.Append("  AND SCH_DATE   <= CONVERT(varchar(8), DATEADD(week,2,GetDate()), 112)  ");

            ////db.DbParametersClear();

            //db.DbPsetString("@WHS_CD", _whs_cd);
            //db.DbPsetString("@ITEM_NO", _item_no);
            
            //strSQL.Append(" ORDER BY SCH_DATE, TYPE ");

            // IMV3
            //・入庫予定
            strSQL.Append(" SELECT          TYPE,           ORDER_NO,                                                   ");
            strSQL.Append(" SCH_DATE,       ORDER_QTY,      ORDER_UMSR,         JOB_ORDER_NO,       VENDOR_CD,          ");
            //strSQL.Append(" JOC_CD,         ALARM_TYPE,     WS_CD,              PLAN_QTY ,          ITEM_UMSR,          ");
            strSQL.Append(" JOC_CD,         ALARM_TYPE,     WS_CD,              PLAN_QTY ,                              ");//UPD 20090216 UBIQ-LIU
            strSQL.Append(" PARENT_ITEM_NO, ITEM_DESC,      PARENT_ORDER_QTY,   S.DATA_CHAR UMSR_DESC                   ");
            strSQL.Append(" FROM  (                                                                                     ");
            strSQL.Append(" SELECT   0 AS TYPE,         A.ORDER_NO,                                                     ");
            strSQL.Append(" A.SCH_COMPL_DATE SCH_DATE,  A.ORDER_QTY, A.ORDER_UMSR, A.JOB_ORDER_NO,  A.VENDOR_CD,        ");
            //strSQL.Append(" A.JOC_CD,      M.ALARM_TYPE,     null  WS_CD,        null   PLAN_QTY ,  null ITEM_UMSR,  ");
            //strSQL.Append(" A.JOC_CD,      M.ALARM_TYPE,     null  WS_CD,        null   PLAN_QTY ,                      ");//UPD 20090216 UBIQ-LIU
            strSQL.Append(" A.JOC_CD,      0 ALARM_TYPE,     null  WS_CD,        null   PLAN_QTY ,                      ");//IMV3
            strSQL.Append(" null PARENT_ITEM_NO,      null ITEM_DESC,     null  PARENT_ORDER_QTY                        ");
            strSQL.Append(" FROM  (                                                                                     ");
            strSQL.Append("SELECT                                                                   ");
            strSQL.Append(" SCH_COMPL_DATE,    JOB_ORDER_QTY - STOCK_QTY ORDER_QTY,  ORDER_UMSR,     ");
            strSQL.Append(" JOB_ORDER_NO,      VENDOR_CD,       JOC_CD         ,ORDER_NO            ");
            strSQL.Append(" FROM   PUR_ORDER                                                        ");
            strSQL.Append(" WHERE ITEM_NO        = @ITEM_NO                                         ");
            strSQL.Append(" AND WHS_CD           = @WHS_CD                                          ");
            strSQL.Append(" AND JOB_ORDER_QTY - STOCK_QTY   > 0                                     ");
            strSQL.Append(" AND ORDER_STATUS     < 77                                               ");

            //検収済未入庫
            strSQL.Append(" UNION ALL                                                     			");
            strSQL.Append(" SELECT                                                         			");
            strSQL.Append(" 	 PO.SCH_COMPL_DATE,    TR.ORDER_QTY,       PO.ORDER_UMSR,  			");
            strSQL.Append(" 	 PO.JOB_ORDER_NO,      PO.VENDOR_CD,       PO.JOC_CD   ,PO.ORDER_NO ");
            strSQL.Append(" FROM PUR_ORDER PO														");
            strSQL.Append(" INNER JOIN                                                				");
            strSQL.Append(" (SELECT ORDER_NO, ISNULL(SUM(INST_QTY), 0) ORDER_QTY					");
            strSQL.Append("    FROM TRANSFER_TRANS													");
            strSQL.Append("   WHERE REQ_TYPE = '11' 												");
            strSQL.Append("     AND XFER_STATUS < 20												");
            strSQL.Append("     AND ORDER_NO IN ( SELECT ORDER_NO 									");
            strSQL.Append(" 					    FROM PUR_ORDER									");
            strSQL.Append(" 					   WHERE ITEM_NO  = @ITEM_NO						");
            strSQL.Append(" 					     AND WHS_CD   = @WHS_CD							");
            strSQL.Append(" 					     AND (ORDER_STATUS = 77 OR ORDER_STATUS = 85) )	");
            strSQL.Append("  GROUP BY ORDER_NO ) TR													");
            strSQL.Append(" ON PO.ORDER_NO = TR.ORDER_NO											");
            strSQL.Append(" WHERE TR.ORDER_QTY > 0      											");
            if (short_flag == 1)
            {
                strSQL.Append(" AND PO.SCH_ID        = @SCH_ID                                      ");
            }

            strSQL.Append(" UNION ALL                                                               ");
            strSQL.Append("SELECT                                                                   ");
            strSQL.Append(" SCH_COMPL_DATE,    JOB_ORDER_QTY - STOCK_QTY ORDER_QTY,  ORDER_UMSR,     ");
            strSQL.Append(" JOB_ORDER_NO,      WS_CD VENDOR_CD,       JOC_CD   ,ORDER_NO            ");
            strSQL.Append(" FROM   JOB_ORDER                                                        ");
            strSQL.Append(" WHERE ITEM_NO        = @ITEM_NO                                         ");
            strSQL.Append(" AND WHS_CD           = @WHS_CD                                          ");
            strSQL.Append(" AND JOB_ORDER_QTY - STOCK_QTY   > 0                                     ");
            strSQL.Append(" AND ORDER_STATUS     < 85                                               ");

            //完成済未入庫
            strSQL.Append(" UNION ALL                                                     					");
            strSQL.Append(" SELECT                                                         					");
            strSQL.Append(" 	 JO.SCH_COMPL_DATE,    TR.ORDER_QTY,             JO.ORDER_UMSR,             ");
            strSQL.Append(" 	 JO.JOB_ORDER_NO,      JO.WS_CD VENDOR_CD,       JO.JOC_CD   ,JO.ORDER_NO   ");
            strSQL.Append("   FROM JOB_ORDER JO                                                             ");
            strSQL.Append(" INNER JOIN                                                                      ");
            strSQL.Append(" (SELECT ORDER_NO, ISNULL(SUM(INST_QTY), 0) ORDER_QTY                            ");
            strSQL.Append("    FROM TRANSFER_TRANS                                                          ");
            strSQL.Append("   WHERE REQ_TYPE = '12'                                                         ");
            strSQL.Append("     AND XFER_STATUS < 20                                                        ");
            strSQL.Append("     AND ORDER_NO IN ( SELECT ORDER_NO                                           ");
            strSQL.Append(" 					    FROM JOB_ORDER                                          ");
            strSQL.Append(" 					   WHERE ITEM_NO  = @ITEM_NO                                ");
            strSQL.Append(" 					     AND WHS_CD   = @WHS_CD                                 ");
            strSQL.Append(" 					     AND ORDER_STATUS = 85 )                                ");
            strSQL.Append("  GROUP BY ORDER_NO ) TR                                                         ");
            strSQL.Append(" ON JO.ORDER_NO = TR.ORDER_NO                                                    ");
            strSQL.Append(" WHERE TR.ORDER_QTY > 0      											");
            if (short_flag == 1)
            {
                strSQL.Append(" AND JO.SCH_ID        = @SCH_ID                                      ");
            }

            strSQL.Append(" ) A                                                                     ");
            strSQL.Append(" UNION ALL                                                               ");
            //・出庫予定
            strSQL.Append("SELECT  1 AS TYPE,    A.ORDER_NO,                                        ");
            strSQL.Append("A.SCH_DISB_DATE SCH_DATE,null ORDER_QTY, A.ITEM_UMSR ORDER_UMSR, null JOB_ORDER_NO,null VENDOR_CD,");
            strSQL.Append("A.JOC_CD        , null ALARM_TYPE ,      A.WS_CD,    A.PLAN_QTY,         ");//UPD 20090216 UBIQ-LIU
            strSQL.Append("A.PARENT_ITEM_NO        , A.ITEM_DESC ,     A.ORDER_QTY PARENT_ORDER_QTY ");
            strSQL.Append(" FROM  (                                                                 ");
            strSQL.Append("SELECT                                                                   ");
            strSQL.Append(" D.INST_DATE SCH_DISB_DATE, '' WS_CD , D.PLAN_QTY,                        ");
            strSQL.Append(" D.ITEM_UMSR,                                              ");
            strSQL.Append(" '' JOC_CD,   '' PARENT_ITEM_NO,  '' ITEM_DESC,  0 ORDER_QTY,    ");
            strSQL.Append(" '' ORDER_NO                                                             ");
            strSQL.Append(" FROM  PICKING_TRANS D                                                   ");
            strSQL.Append(" WHERE D.PICKING_STATUS     < 30                                         ");
            strSQL.Append(" AND D.WHS_CD       = @WHS_CD                                          ");
            strSQL.Append(" AND D.ITEM_NO        = @ITEM_NO                                         ");
            strSQL.Append(" UNION ALL                                                               ");
            strSQL.Append("SELECT                                                                   ");
            strSQL.Append(" D.INST_DATE SCH_DISB_DATE, '' WS_CD , D.PLAN_QTY, D.ITEM_UMSR,          ");
            strSQL.Append(" '' JOC_CD,   '' PARENT_ITEM_NO,  '' ITEM_DESC,  0 ORDER_QTY,    ");
            strSQL.Append(" '' ORDER_NO                                                             ");
            strSQL.Append(" FROM  PICKING_TRANS D                                                   ");
            strSQL.Append(" WHERE D.PICKING_STATUS     < 30                                         ");
            strSQL.Append(" AND D.WHS_CD       = @WHS_CD                                          ");
            strSQL.Append(" AND D.ITEM_NO        = @ITEM_NO                                         ");
            strSQL.Append(" ) A                                                                     ");
            strSQL.Append(" WHERE A.PLAN_QTY > 0                                                    ");
            strSQL.Append("                        ) VIEW_DATE                                      ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 =   'ITEM_UMSR'                 ");
            strSQL.Append(" AND S.KEY02     =   ORDER_UMSR                                          ");

            //db.DbParametersClear();

            db.DbPsetString("@WHS_CD", _whs_cd);
            db.DbPsetString("@ITEM_NO", _item_no);

            strSQL.Append(" ORDER BY SCH_DATE, TYPE ");
           
            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 注文書発行対象データを検索
        /// 
        /// 使用画面：PurPOSheetPrt
        /// </summary>
        public DataSet Get_Pur_PoSheet()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql 
            strSQL.Append("SELECT                                                   ");
            strSQL.Append("P.VENDOR_CD,V.VENDOR_NAME,P.PO_NO,COUNT(*) NUM_OF_DTLS   ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PUR_ORDER P,VENDOR_MASTER V    ");
                strSQL.Append(" WHERE                               ");
                strSQL.Append(" P.VENDOR_CD = V.VENDOR_CD           ");

                if (buyer_cd != "")
                {
                    strSQL.Append("   AND P.BUYER_CD         = :BUYER_CD ");
                    db.DbPsetString("BUYER_CD", _buyer_cd);
                }
                if (vendor_cd != "")
                {
                    strSQL.Append("   AND P.VENDOR_CD               = :VENDOR_CD ");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                }

                if (print_mode == "0")
                {
                    if (reissue_flag == 0)
                    {
                        strSQL.Append(" AND P.ORDER_STATUS = 10 AND P.PO_ISSUE_FLAG = 0 AND P.PO_NO NOT IN  ");
                        strSQL.Append(" (	SELECT P1.PO_NO FROM PUR_ORDER P1 WHERE P1.ORDER_STATUS = '99') ");
                    }
                    else
                    {
                        if (po_no == "")
                        {
                            strSQL.Append(" AND PO_NO IN (SELECT PO_NO FROM PUR_ORDER P WHERE P.ORDER_STATUS = '25' AND P.PO_ISSUE_FLAG = 1) ");
                        }
                        else
                        {
                            strSQL.Append(" AND P.PO_NO = '' AND P.PO_ISSUE_FLAG = 1 ");
                        }
                    }
                }
                else
                {
                    if (reissue_flag == 0)
                    {
                        strSQL.Append(" AND P.PO_NO IN (SELECT P2.PO_NO FROM PUR_ORDER P2 WHERE (P2.ORDER_NO = '23' OR P2.ORDER_NO = '97' OR P2.ORDER_NO = '77')  ");
                        strSQL.Append(" AND P2.PO_ISSUE_FLAG = 0) AND P.PO_ISSUE_FLAG = 0 ");
                    }
                }
                strSQL.Append(" GROUP BY P.VENDOR_CD,P.PO_NO,V.VENDOR_NAME ");
            }
            else
            {
                strSQL.Append("   FROM PUR_ORDER P                                          ");
                strSQL.Append("   LEFT JOIN VENDOR_MASTER V ON P.VENDOR_CD = V.VENDOR_CD    ");

                db.DbParametersClear();
                strSQL.Append(" WHERE 1=1 ");

                if (buyer_cd != "")
                {
                    strSQL.Append("   AND P.BUYER_CD         = @BUYER_CD ");
                    db.DbPsetString("@BUYER_CD", _buyer_cd);
                }
                if (vendor_cd != "")
                {
                    strSQL.Append("   AND P.VENDOR_CD               = @VENDOR_CD ");
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                }
                if (print_mode == "0")
                {
                    if (reissue_flag == 0)
                    {
                        //strSQL.Append(" AND P.ORDER_STATUS = 10 AND P.PO_ISSUE_FLAG = 0 AND P.PO_NO NOT IN  ");
                        //strSQL.Append(" (	SELECT P1.PO_NO FROM PUR_ORDER P1 WHERE P1.ORDER_STATUS = '99') ");
                        strSQL.Append(" AND P.ORDER_STATUS = 10 AND P.PO_ISSUE_FLAG = 0  ");    // 2012.06.04
                    }
                    else
                    {
                        if (po_no == "")
                        {
                            strSQL.Append(" AND PO_NO IN (SELECT PO_NO FROM PUR_ORDER P WHERE P.ORDER_STATUS = '25' AND P.PO_ISSUE_FLAG = 1) ");
                        }
                        else
                        {
                            strSQL.Append(" AND P.PO_NO = '' AND P.PO_ISSUE_FLAG = 1 ");
                        }
                    }
                }
                else
                {
                    if (reissue_flag == 0)
                    {
                        strSQL.Append(" AND P.PO_NO IN (SELECT P2.PO_NO FROM PUR_ORDER P2 WHERE                         ");
                        strSQL.Append(" P2.ORDER_STATUS = '23' OR P2.ORDER_STATUS = '97' OR P2.ORDER_STATUS = '77')     ");
                        //strSQL.Append(" AND P2.PO_ISSUE_FLAG = 0) AND P.PO_ISSUE_FLAG = 0                               ");
                    }
                }
                strSQL.Append(" GROUP BY P.VENDOR_CD,P.PO_NO,V.VENDOR_NAME ");
            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 購買オーダのオーダステータスを注文書発行済に更新
        /// 
        /// 使用画面：PurPOSheetPrt
        /// </summary>
        public int Pur_PoSheetPrt(ComDB db)
        {
            //ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PO_NO", _po_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_PUR_POSHEETPRT");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                //db.DbCommit();
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                //db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 注文書発行対象データを検索/発注№ﾁｪｯｸ
        /// 
        /// <para>使用画面：[PurPOSheetPrt][PurInspPriceChg]</para>
        /// </summary>
        public DataSet Get_Pur_PoSheetDetail()//UPD BY UBIQ-CHEN 2009.02.10
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql 
            strSQL.Append("SELECT                                                                           ");
            strSQL.Append("V.ZIP_CD,V.ADDRESS1,V.ADDRESS2,V.ADDRESS3,V.ADDRESS4,V.VENDOR_DESC,P.VENDOR_CD,  ");
            strSQL.Append("V.VENDOR_ATTN,V.TELNO,V.FAXNO,S.DATA_CHAR COMPANY_NAME,                          ");
            strSQL.Append("S.DATA_CHAR3 COMPANY_ADDRESS1,S.DATA_CHAR4 COMPANY_ADDRESS2,                     ");
            strSQL.Append("P.BUYER_CD,S.DATA_CHAR5 COMPANY_TELNO,S.DATA_CHAR6 COMPANY_FAXNO,                ");
            strSQL.Append("P.PO_NO,P.PO_LINE_NO,P.ITEM_NO,P.ITEM_DESC,P.PO_QTY,S2.DATA_CHAR PO_UMSR,        ");
            strSQL.Append("P.PO_PRC,P.PO_AMT,S3.DATA_CHAR PO_CUR,P.PO_DUE_DATE,P.JOC_CD,P.ORDER_STATUS      ");
            //ADD BY UBIQ-CHEN 2009.02.10
            strSQL.Append(",P.RECV_LOC,P.VENDOR_NAME,P.VENDOR_ITEM_NO,P.VENDOR_ITEM_DESC,P.PO_CHG_TIMES,    ");
            //ADD BY UBIQ-CHEN 2009.04.13
            strSQL.Append("CASE ISNULL(S5.DATA_INT,0) WHEN 0 THEN  S4.DATA_INT ELSE S5.DATA_INT END LANG    ");
            strSQL.Append(",S6.DATA_CHAR BUYER_NAME                                                         ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PUR_ORDER P,VENDOR_MASTER V,SYSTEM_PARAMETER S,SYSTEM_PARAMETER S2,SYSTEM_PARAMETER S3  ");
                strSQL.Append(" WHERE  ");
                strSQL.Append(" P.VENDOR_CD = V.VENDOR_CD  AND S.KEY01 = 'COMPANY_CD' AND S.KEY02 = '*' ");
                strSQL.Append(" AND S2.KEY01 = 'ITEM_UMSR' AND S2.KEY02 = P.PO_UMSR ");
                strSQL.Append(" AND S3.KEY01 = 'CURRENCY_CD' AND S3.KEY02 = P.PO_CUR ");

                strSQL.Append("   AND P.PO_NO         = :PO_NO ");
                db.DbPsetString("PO_NO", _po_no);

            }
            else
            {
                strSQL.Append("   FROM PUR_ORDER P                                                                  ");
                strSQL.Append("   LEFT JOIN VENDOR_MASTER V ON P.VENDOR_CD = V.VENDOR_CD                            ");//************  MOD BY LIU 2009.1.16  ***************
                strSQL.Append("   LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'COMPANY_CD' AND S.KEY02 = '*'          ");
                strSQL.Append("   LEFT JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'ITEM_UMSR' AND S2.KEY02 = P.PO_UMSR  ");
                strSQL.Append("   LEFT JOIN SYSTEM_PARAMETER S3 ON S3.KEY01 = 'CURRENCY_CD' AND S3.KEY02 = P.PO_CUR ");
                strSQL.Append("   LEFT JOIN SYSTEM_PARAMETER S4 ON S4.KEY01 = 'PRINT_LANG' AND  S4.KEY02 = '*'      ");
                strSQL.Append("   LEFT JOIN SYSTEM_PARAMETER S5 ON S5.KEY01 = 'COUNTRY_CD'                          ");
                strSQL.Append("   AND  S5.KEY02 = V.COUNTRY_CD                                                      ");
                strSQL.Append("   LEFT JOIN SYSTEM_PARAMETER S6 ON S6.KEY01 = 'BUYER_CD' AND S6.KEY02 = P.BUYER_CD  ");

                db.DbParametersClear();
                strSQL.Append(" WHERE  ");

                strSQL.Append("   P.PO_NO         = @PO_NO ");
                db.DbPsetString("@PO_NO", _po_no);

                // IMV3
                strSQL.Append("  AND P.PEGGING_TYPE	<> '1'	");

                if (print_mode == "0")
                {
                    //if (reissue_flag == 0)
                    //{
                    //    strSQL.Append(" AND P.PO_NO IN (SELECT P2.PO_NO FROM PUR_ORDER P2 WHERE (P2.ORDER_STATUS = '23' OR P2.ORDER_STATUS = '97' OR P2.ORDER_STATUS = '77')  ");
                    //    strSQL.Append(" AND P2.PO_ISSUE_FLAG = 0) AND P.PO_ISSUE_FLAG = 0 ");
                    //}
                    //add by ubiq-chen 2009.03.24
                    if (reissue_flag == 1)
                    {
                        strSQL.Append(" AND P.PO_NO NOT IN ( SELECT PO_NO FROM PUR_ORDER_HISTORY WHERE ORDER_STATUS = 23 ) ");  //Add 2012.06.07 Ubiq-Sai 発注残変更なし

                        strSQL.Append(" AND P.PO_ISSUE_FLAG = 1 ");
                    }
                }
                //Add 2012.06.07 Ubiq-Sai Begin
                else
                {
                    if (reissue_flag == 1)
                    {
                        strSQL.Append(" AND P.PO_NO IN ( SELECT PO_NO FROM PUR_ORDER_HISTORY WHERE ORDER_STATUS = 23 ) ");  //発注残変更あり

                        strSQL.Append(" AND P.PO_ISSUE_FLAG = 1 ");
                    }
                }
                //Add 2012.06.07 Ubiq-Sai End

                strSQL.Append(" ORDER BY P.PO_LINE_NO  ");
            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 発注指示プロシジャ
        /// 使用画面：PurManPORlse
        /// </summary>
        /// <returns></returns>
        public int Pur_ManPoRlse()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_BUYER_CD", _buyer_cd, ComConst.DB_IN);
            db.DbPsetString("@I_SCH_ID", _sch_id, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_DESC", _item_desc, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
            //ADD 20090210 UBIQ-LIU
            db.DbPsetString("@I_VENDOR_NAME", _vendor_name, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_ITEM_NO", _vendor_item_no, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_ITEM_DESC", _vendor_item_desc, ComConst.DB_IN);
            // ADD END
            db.DbPsetDouble("@I_PO_QTY", _po_qty, ComConst.DB_IN);
            db.DbPsetString("@I_PO_UMSR", _po_umsr, ComConst.DB_IN);
            db.DbPsetDouble("@I_PO_PRC", _po_prc, ComConst.DB_IN);
            db.DbPsetString("@I_PO_CUR", _po_cur, ComConst.DB_IN);
            db.DbPsetString("@I_JOC_CD", _joc_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_DUE_DATE", po_due_date, ComConst.DB_IN);
            db.DbPsetString("@I_PO_NOTE", _po_note, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PUR_MANPORLSE");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                db.DbCommit();
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 振替依頼データを検索
        /// 
        /// 使用画面：Pur_SupplyInst
        /// </summary>
        public DataSet Get_Pur_SupplyInstPList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql 
            strSQL.Append("SELECT ");
            strSQL.Append("T.TO_VC_CD VENDOR_CD,    T.XFER_NO,T.ITEM_NO, T.ITEM_DESC,           T.INST_QTY,                     ");
            strSQL.Append("S.DATA_CHAR ITEM_UMSR,   T.TO_SUPPLY_TYPE,    T.FROM_WHS_CD WHS_CD,  ISNULL(INV.INV_BAL,0) INV_BAL,  ");
            strSQL.Append("ISNULL(INV.INV_BAL,0)-ISNULL(INV.ALLOC_QTY,0) FREE_BAL,              V.VENDOR_DESC                   ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T,SYSTEM_PARAMETER S  ");
                strSQL.Append(" WHERE  ");
                strSQL.Append(" S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");
                strSQL.Append(" AND T.REQ_TYPE = '24' AND T.XFER_STATUS<5 ");

                if (buyer_cd != "")
                {
                    strSQL.Append("   AND T.BUYER_CD         = :BUYER_CD ");
                    db.DbPsetString("BUYER_CD", _buyer_cd);
                }
                if (sch_id != "")
                {
                    strSQL.Append("   AND T.SCH_ID        = :SCH_ID ");
                    db.DbPsetString("SCH_ID", _sch_id);
                }
                if (to_vc_cd != "")
                {
                    strSQL.Append("   AND T.TO_VC_CD         = :TO_VC_CD ");
                    db.DbPsetString("TO_VC_CD", _to_vc_cd);
                }

            }
            else
            {
                strSQL.Append("   FROM TRANSFER_TRANS T                                                                 ");
                strSQL.Append("   LEFT JOIN (SELECT WHS_CD, ITEM_NO,   SUM(INV_BAL) INV_BAL,    SUM(ALLOC_QTY) ALLOC_QTY");
                strSQL.Append("   FROM INVENTORY_DETAIL WHERE INV_YM = 0 AND INV_WIP_TYPE = 0 AND INV_TYPE = 0          ");
                strSQL.Append("   GROUP BY WHS_CD,ITEM_NO) INV ON T.ITEM_NO = INV.ITEM_NO AND T.FROM_WHS_CD=INV.WHS_CD  ");
                strSQL.Append("   LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR       ");
                strSQL.Append("   LEFT JOIN VENDOR_MASTER V ON T.TO_VC_CD = V.VENDOR_CD                                 ");
                db.DbParametersClear();

                strSQL.Append(" WHERE  ");
                strSQL.Append(" T.REQ_TYPE = '24' AND T.XFER_STATUS<5 ");//2009.02.06 UPD//

                if (buyer_cd != "")
                {
                    strSQL.Append("   AND T.BUYER_CD         = @BUYER_CD ");
                    db.DbPsetString("@BUYER_CD", _buyer_cd);
                }
                if (sch_id != "")
                {
                    strSQL.Append("   AND T.SCH_ID        = @SCH_ID ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (vendor_cd != "")
                {
                    strSQL.Append("   AND T.TO_VC_CD         = @VENDOR_CD ");
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                }
                strSQL.Append("   ORDER BY T.TO_VC_CD,  T.XFER_NO,  T.ITEM_NO   ");
            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 振替依頼データを検索
        /// 
        /// 使用画面：Pur_SupplyInst
        /// </summary>
        public DataSet Get_Pur_SupplyInstMList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql  //2009.01.22 Upd
            //--- sql  //2009.02.06 Upd 
            //--- sql  //2010/07/07　整理 UBIQ-LIU
            if (parent_child_flag == 0)//親品目指定の場合
            {
                strSQL.Append("SELECT                                                                                   ");
                strSQL.Append(" '' AS XFER_NO,      P.VENDOR_CD,    M.CHILD_ITEM_NO ITEM_NO,    I.ITEM_DESC,            ");
                if (_db_type == "ORACLE")
                {
                    strSQL.Append(" INST_QTY = CASE WHEN M.USAGE_TYPE = 0 THEN M.USAGE_DEC * :INST_QTY                  ");
                    strSQL.Append(" WHEN  M.USAGE_TYPE = 1 THEN (M.USAGE_DENOMINATOR/M.USAGE_NUMERATOR) * :INST_QTY END,");
                    strSQL.Append(" S.DATA_CHAR ITEM_UMSR,P.SUPPLY_TYPE TO_SUPPLY_TYPE                                  ");
                    strSQL.Append("   FROM MFG_BOM_MASTER M, ITEM_MASTER I, SYSTEM_PARAMETER S, PURCHASE_MASTER P       ");

                    strSQL.Append(" WHERE                                                               ");
                    strSQL.Append("  M.PARENT_ITEM_NO = I.ITEM_NO                                       ");
                    strSQL.Append("   AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = I.ITEM_UMSR               ");
                    strSQL.Append("   AND M.PARENT_ITEM_NO = P.ITEM_NO                                  ");
                    strSQL.Append(" AND M.BEG_EFF_DATE <= CONVERT(varchar(8), GETDATE(), 112)           ");
                    strSQL.Append(" AND M.END_EFF_DATE >= CONVERT(varchar(8), GETDATE(), 112)           ");

                    strSQL.Append(" AND M.PARENT_ITEM_NO         = :PARENT_ITEM_NO                      ");
                    db.DbPsetString("PARENT_ITEM_NO", _parent_item_no);

                    strSQL.Append(" AND P.BEG_EFF_DATE <= CONVERT(varchar(8), GETDATE(), 112)           ");
                    strSQL.Append(" AND P.END_EFF_DATE >= CONVERT(varchar(8), GETDATE(), 112)           ");

                    strSQL.Append(" AND  P.ITEM_NO         = :ITEM_NO                                   ");
                    db.DbPsetString("ITEM_NO", _parent_item_no);

                    strSQL.Append(" AND  P.VENDOR_CD         = :VENDOR_CD                               ");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);

                    strSQL.Append(" AND P.PTY_NO = (SELECT MIN(P1.PTY_NO) FROM PURCHASE_MASTER P1 WHERE ");

                    strSQL.Append(" P1.ITEM_NO         = :ITEM_NO ");
                    db.DbPsetString("ITEM_NO", _parent_item_no);

                    strSQL.Append(" AND P1.BEG_EFF_DATE <= CONVERT(varchar(8), GETDATE(), 112)          ");
                    strSQL.Append(" AND P1.END_EFF_DATE >= CONVERT(varchar(8), GETDATE(), 112)          ");

                    strSQL.Append(" AND  P1.VENDOR_CD         = :VENDOR_CD)                             ");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);

                    strSQL.Append(" AND P.SUPPLY_TYPE <> 0                                              ");
                    db.DbPsetDouble("INST_QTY", _inst_qty);
                }
                else
                {
                    strSQL.Append(" (ISNULL(CASE    WHEN M.USAGE_TYPE = 0 THEN M.USAGE_DEC                                  ");
                    strSQL.Append("                 WHEN  M.USAGE_TYPE = 1 THEN                                             ");
                    strSQL.Append("                 (M.USAGE_DENOMINATOR/M.USAGE_NUMERATOR) END,0)* @INST_QTY) INST_QTY,    ");
                    strSQL.Append(" S.DATA_CHAR ITEM_UMSR,      P.SUPPLY_TYPE TO_SUPPLY_TYPE,                               ");
                    strSQL.Append(" (CASE WHEN I.BOND_TYPE= 1 THEN                                                          ");
                    strSQL.Append("      (CASE WHEN I.BOND_DISB_WHS <> '' THEN                                              ");
                    strSQL.Append("      	    I.BOND_DISB_WHS                                                             ");
                    strSQL.Append("            ELSE (CASE WHEN I.ITEM_TYPE = '30' THEN                                      ");
                    strSQL.Append("      	    		    IWS.BOND_SEMI_WHS                                               ");
                    strSQL.Append("      	            ELSE                                                                ");
                    strSQL.Append("      	    	    	IWS.BOND_DISB_WHS 	                                            ");
                    strSQL.Append("      	            END)                                                                ");
                    strSQL.Append("            END)                                                                         ");
                    strSQL.Append("      ELSE (CASE  WHEN I.DISB_WHS <> '' THEN                                             ");
                    strSQL.Append("      		        I.DISB_WHS                                                          ");
                    strSQL.Append("                  ELSE (CASE WHEN I.ITEM_TYPE = '30' THEN                                ");
                    strSQL.Append("                  				IWS.SEMI_WHS                                            ");
                    strSQL.Append("                  		   ELSE                                                         ");
                    strSQL.Append("                  				IWS.DISB_WHS                                            ");
                    strSQL.Append("                  		   END)                                                         ");
                    strSQL.Append("                  END)                                                                   ");
                    strSQL.Append("      END) WHS_CD,                                                                       ");
                    strSQL.Append("  ISNULL(INV.INV_BAL,0) INV_BAL,ISNULL(INV.INV_BAL,0)-ISNULL(INV.ALLOC_QTY,0) FREE_BAL,  ");
                    strSQL.Append("  V.VENDOR_DESC                                                                          ");
                    strSQL.Append("   FROM MFG_BOM_MASTER M                                                                 ");
                    strSQL.Append("   LEFT JOIN ITEM_MASTER I ON I.ITEM_NO = M.CHILD_ITEM_NO                                ");//結合条件追加 UBIQ-LIU 2010/06/30
                    strSQL.Append("   LEFT JOIN (SELECT W1.MRP_WHS SEMI_WHS,        W2.MRP_WHS BOND_SEMI_WHS,               ");
                    strSQL.Append("                     W3.MRP_WHS DISB_WHS,        W4.MRP_WHS BOND_DISB_WHS                ");
                    strSQL.Append("              FROM   ITEM_WS_MASTER IW                                                   ");
                    strSQL.Append("              LEFT JOIN WAREHOUSE_MASTER W1 ON W1.WHS_CD     =   IW.SEMI_WHS             ");//<-- ADD UBIQ-LIU 2010/07/07
                    strSQL.Append("              LEFT JOIN WAREHOUSE_MASTER W2 ON W2.WHS_CD     =   IW.BOND_SEMI_WHS        ");
                    strSQL.Append("              LEFT JOIN WAREHOUSE_MASTER W3 ON W3.WHS_CD     =   IW.DISB_WHS             ");
                    strSQL.Append("              LEFT JOIN WAREHOUSE_MASTER W4 ON W4.WHS_CD     =   IW.BOND_DISB_WHS        ");//--> END UBIQ-LIU 2010/07/07
                    strSQL.Append("              WHERE  ITEM_NO     =   @PARENT_ITEM_NO                                     ");
                    strSQL.Append("                 AND IW.BEG_EFF_DATE <= CONVERT(varchar(8), GETDATE(), 112)              ");
                    strSQL.Append("                 AND IW.END_EFF_DATE >= CONVERT(varchar(8), GETDATE(), 112)              ");
                    strSQL.Append("                 AND IW.PTY_NO IN (SELECT MIN(P1.PTY_NO) FROM PURCHASE_MASTER P1 WHERE   ");
                    strSQL.Append("                          P1.ITEM_NO     =   @PARENT_ITEM_NO                             ");
                    strSQL.Append("                          AND P1.BEG_EFF_DATE <= CONVERT(varchar(8), GETDATE(), 112)     ");
                    strSQL.Append("                          AND P1.END_EFF_DATE >= CONVERT(varchar(8), GETDATE(), 112)     ");
                    strSQL.Append("                          AND  P1.VENDOR_CD   =  @VENDOR_CD)) IWS ON 0 = 0               ");
                    strSQL.Append("   LEFT JOIN (SELECT WHS_CD,  ITEM_NO,  SUM(INV_BAL) INV_BAL,  SUM(ALLOC_QTY) ALLOC_QTY  ");
                    strSQL.Append("              FROM INVENTORY_DETAIL                                                      ");
                    strSQL.Append("              WHERE INV_YM = 0 AND INV_WIP_TYPE = 0 AND INV_TYPE = 0                     ");
                    strSQL.Append("              GROUP BY WHS_CD,ITEM_NO) INV ON INV.ITEM_NO = M.CHILD_ITEM_NO              ");//結合条件追加 UBIQ-LIU 2010/06/30
                    strSQL.Append("   LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = I.ITEM_UMSR       ");
                    strSQL.Append("   LEFT JOIN PURCHASE_MASTER P ON 0= 0                                                   ");
                    strSQL.Append("   LEFT JOIN VENDOR_MASTER V ON P.VENDOR_CD = V.VENDOR_CD                                ");
                    strSQL.Append(" WHERE                                                                                   ");
                    strSQL.Append("   M.CHILD_ITEM_NO = I.ITEM_NO AND M.CHILD_ITEM_NO = INV.ITEM_NO                         ");
                    strSQL.Append("   AND INV.WHS_CD=CASE WHEN I.BOND_TYPE= 1 THEN                                          ");
                    strSQL.Append("                         (CASE WHEN I.BOND_DISB_WHS <> '' THEN                           ");
                    strSQL.Append("                         	    I.BOND_DISB_WHS                                         ");
                    strSQL.Append("                               ELSE (CASE WHEN I.ITEM_TYPE = '30' THEN                   ");
                    strSQL.Append("                         	    		    IWS.BOND_SEMI_WHS                           ");
                    strSQL.Append("                         	            ELSE                                            ");
                    strSQL.Append("                         	    	    	IWS.BOND_DISB_WHS 	                        ");
                    strSQL.Append("                         	            END)                                            ");
                    strSQL.Append("                               END)                                                      ");
                    strSQL.Append("                     ELSE (CASE  WHEN I.DISB_WHS <> '' THEN                              ");
                    strSQL.Append("                     		        I.DISB_WHS                                          ");
                    strSQL.Append("                                 ELSE (CASE WHEN I.ITEM_TYPE = '30' THEN                 ");
                    strSQL.Append("                                 				IWS.SEMI_WHS                            ");
                    strSQL.Append("                                 		   ELSE                                         ");
                    strSQL.Append("                                 				IWS.DISB_WHS                            ");
                    strSQL.Append("                                 		   END)                                         ");
                    strSQL.Append("                                 END)                                                    ");
                    strSQL.Append("                     END                                                                 ");
                    strSQL.Append(" AND M.BEG_EFF_DATE <= CONVERT(varchar(8), GETDATE(), 112)                               ");
                    strSQL.Append(" AND M.END_EFF_DATE >= CONVERT(varchar(8), GETDATE(), 112)                               ");
                    strSQL.Append(" AND M.MBOM_SUB_CD            = @JOC                                                     ");//仕様追加 UBIQ-LIU 2010/06/30 BUG828
                    strSQL.Append(" AND M.PARENT_ITEM_NO         = @PARENT_ITEM_NO                                          ");
                    strSQL.Append(" AND P.BEG_EFF_DATE <= CONVERT(varchar(8), GETDATE(), 112)                               ");
                    strSQL.Append(" AND P.END_EFF_DATE >= CONVERT(varchar(8), GETDATE(), 112)                               ");
                    strSQL.Append(" AND P.ITEM_NO         = @PARENT_ITEM_NO                                                 ");
                    strSQL.Append(" AND P.VENDOR_CD         = @VENDOR_CD                                                    ");
                    strSQL.Append(" AND P.PTY_NO = (SELECT MIN(P1.PTY_NO) FROM PURCHASE_MASTER P1 WHERE                     ");
                    strSQL.Append("                 P1.ITEM_NO         = @PARENT_ITEM_NO                                    ");
                    strSQL.Append("                 AND P1.BEG_EFF_DATE <= CONVERT(varchar(8), GETDATE(), 112)              ");
                    strSQL.Append("                 AND P1.END_EFF_DATE >= CONVERT(varchar(8), GETDATE(), 112)              ");
                    strSQL.Append("                 AND  P1.VENDOR_CD         = @VENDOR_CD)                                 ");
                    strSQL.Append(" AND P.SUPPLY_TYPE <> 0                                                                  ");

                    db.DbPsetDouble("@INST_QTY", _inst_qty);
                    db.DbPsetString("@JOC", _joc_cd);
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                }
            }
            else//子品目指定の場合
            {
                strSQL.Append("SELECT                                                                                           ");
                strSQL.Append("'' AS XFER_NO,   @VENDOR_CD VENDOR_CD,    INV.ITEM_NO, I.ITEM_DESC,    @INST_QTY INST_QTY,       ");
                strSQL.Append("S.DATA_CHAR ITEM_UMSR,   '' AS TO_SUPPLY_TYPE,    INV.WHS_CD,  ISNULL(INV.INV_BAL,0) INV_BAL,    ");
                strSQL.Append("ISNULL(INV.INV_BAL,0)-ISNULL(INV.ALLOC_QTY,0) FREE_BAL,              V.VENDOR_DESC               ");
                if (_db_type == "ORACLE")
                {
                    db.DbParametersClear();
                    strSQL.Append("   FROM ITEM_MASTER I                                                                    ");
                    strSQL.Append("   LEFT JOIN (SELECT WHS_CD, ITEM_NO,   SUM(INV_BAL) INV_BAL,    SUM(ALLOC_QTY) ALLOC_QTY");
                    strSQL.Append("   FROM INVENTORY_DETAIL WHERE INV_YM = 0 AND INV_WIP_TYPE = 0 AND INV_TYPE = 0          ");
                    strSQL.Append("   GROUP BY WHS_CD,ITEM_NO) INV ON  0 = 0                                                ");
                    strSQL.Append("   LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = I.ITEM_UMSR AND S.KEY02 = T.ITEM_UMSR       ");
                    strSQL.Append("   LEFT JOIN VENDOR_MASTER V ON @VENDOR_CD = V.VENDOR_CD                                 ");

                    strSQL.Append(" WHERE I.ITEM_NO = :PARENT_ITEM_NO ");
                    strSQL.Append(" AND INV.ITEM_NO = :PARENT_ITEM_NO ");
                    strSQL.Append(" AND INV.WHS_CD = :WHS_CD ");

                    db.DbPsetString("PARENT_ITEM_NO", _parent_item_no);
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                    db.DbPsetString("WHS_CD", _whs_cd);
                    db.DbPsetDouble("INST_QTY", _inst_qty);
                }
                else
                {
                    db.DbParametersClear();
                    strSQL.Append("   FROM ITEM_MASTER I                                                                    ");
                    strSQL.Append("   LEFT JOIN (SELECT WHS_CD, ITEM_NO,   SUM(INV_BAL) INV_BAL,    SUM(ALLOC_QTY) ALLOC_QTY");
                    strSQL.Append("   FROM INVENTORY_DETAIL WHERE INV_YM = 0 AND INV_WIP_TYPE = 0 AND INV_TYPE = 0          ");
                    strSQL.Append("   GROUP BY WHS_CD,ITEM_NO) INV ON  INV.ITEM_NO = @PARENT_ITEM_NO                        ");//結合条件追加 UBIQ-LIU 2010/06/30
                    strSQL.Append("   LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = I.ITEM_UMSR       ");
                    strSQL.Append("   LEFT JOIN VENDOR_MASTER V ON @VENDOR_CD = V.VENDOR_CD                                 ");

                    strSQL.Append(" WHERE I.ITEM_NO = @PARENT_ITEM_NO ");
                    strSQL.Append(" AND INV.ITEM_NO = @PARENT_ITEM_NO ");
                    strSQL.Append(" AND INV.WHS_CD = @WHS_CD ");

                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                    db.DbPsetString("@WHS_CD", _whs_cd);
                    db.DbPsetDouble("@INST_QTY", _inst_qty);

                }
            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 支給指示プロシジャ
        /// 使用画面：Pur_SupplyInst
        /// </summary>
        /// <returns></returns>
        public int Pur_SupplyInst()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_SCH_ID", _sch_id, ComConst.DB_IN);
            db.DbPsetString("@I_BUYER_CD", _buyer_cd, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PARENT_ITEM_NO", _parent_item_no, ComConst.DB_IN);
            db.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHILD_ITEM_NO", _child_item_no, ComConst.DB_IN);
            db.DbPsetDouble("@I_INST_QTY", _inst_qty, ComConst.DB_IN);
            db.DbPsetInt("@I_SUPPLY_TYPE", _supply_type, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_REQUEST_NO", _request_no, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PUR_SUPPLYINST");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                db.DbCommit();
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// フォーキャスト明細に表示
        /// 使用画面：Pur_SupplyInst
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Pur_FcstInqList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                           ");
            strSQL.Append(" PO.ITEM_NO,         PO.ITEM_DESC,                                               ");
            strSQL.Append(" CASE PM.DELV_LT_TYPE WHEN 0 THEN convert(varchar,PM.DELV_LT) WHEN 1             ");
            strSQL.Append(" THEN convert(varchar,PM.DELV_LT_PROPORTION)   + '(LOT:' +                       ");
            strSQL.Append(" convert(varchar,PM.STD_LOT_SIZE) + ')' END DELV_LT ,SUM(PO.PO_QTY) PO_QTY,      ");
            if (_date_type == 0)
            {
                strSQL.Append(" CAL.TTL_WEEK DATE_NO                                                        ");
            }
            else
            {
                strSQL.Append(" CAL.CALENDAR_CYM  DATE_NO                                                   ");
            }
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PLANNED_ORDER PO,CALENDAR_MASTER CAL,PURCHASE_MASTER PM               ");
                strSQL.Append(" WHERE                                                                       ");
                strSQL.Append("  PO.ITEM_NO=PM.ITEM_NO                                                      ");
                strSQL.Append(" AND PO.VENDOR_CD = PM.VENDOR_CD                                             ");
                strSQL.Append(" AND PO.PO_DUE_DATE >= PM.BEG_EFF_DATE                                       ");
                strSQL.Append(" AND PO.PO_DUE_DATE <= PM.END_EFF_DATE                                       ");
                strSQL.Append("CAL.CALENDAR_DATE = PO.PO_DUE_DATE                                           ");
                if (date_type == 1)
                {//Month
                    strSQL.Append("AND CAL.CALENDAR_DATE >= @CALENDAR_DATE  AND CAL.CALENDAR_DATE <=            ");
                    strSQL.Append("CONVERT(varchar(8), DATEADD(Month,8,convert(datetime,@CALENDAR_DATE)), 112)  ");

                    db.DbPsetInt("CALENDAR_DATE", _calendar_date);
                }
                else
                {
                    //Week
                    strSQL.Append(" AND CAL.CALENDAR_DATE  >= (SELECT MIN(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = :TTL_WEEK) ");
                    strSQL.Append(" AND CAL.CALENDAR_DATE  <= (SELECT MAX(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = :TTL_WEEK + 7)  ");
                    db.DbPsetInt("TTL_WEEK", _ttl_week);
                }
                strSQL.Append(" AND PO.VENDOR_CD = :VENDOR_CD                       ");
                if (item_no != "")
                {
                    strSQL.Append(" AND PO.ITEM_NO = :ITEM_NO                       ");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                strSQL.Append(" AND PO.SC_FLAG = 1                                  ");
                strSQL.Append(" AND PO.ITEM_TYPE <> '99'           					");
                strSQL.Append(" and sch_start_date >=                               ");
                if (date_type == 1)
                {//Month
                    strSQL.Append("AND PO.PO_DUE_DATE >= @CALENDAR_DATE  AND PO.PO_DUE_DATE <=            ");
                    strSQL.Append("CONVERT(varchar(8), DATEADD(Month,8,convert(datetime,@CALENDAR_DATE)), 112)  ");

                    db.DbPsetInt("CALENDAR_DATE", _calendar_date);
                }
                else
                {
                    //Week
                    strSQL.Append(" AND PO.PO_DUE_DATE  >= (SELECT MIN(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = :TTL_WEEK) ");
                    strSQL.Append(" AND PO.PO_DUE_DATE  <= (SELECT MAX(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = :TTL_WEEK + 7)  ");
                    db.DbPsetInt("TTL_WEEK", _ttl_week);
                }
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PLANNED_ORDER PO                                                    ");
                strSQL.Append(" LEFT JOIN CALENDAR_MASTER CAL ON CAL.CALENDAR_DATE  = PO.PO_DUE_DATE     ");
                if (_date_type == 1)
                {
                    //Month
                    strSQL.Append(" AND CAL.CALENDAR_DATE  >= (SELECT MIN(CALENDAR_DATE) from CALENDAR_MASTER WHERE CALENDAR_DATE >= @CALENDAR_DATE)      ");
                    strSQL.Append(" AND CAL.CALENDAR_DATE  <= (SELECT MAX(CALENDAR_DATE) from CALENDAR_MASTER WHERE CALENDAR_DATE <=                      ");
                    //strSQL.Append(" CONVERT(varchar(8), DATEADD(Month,7,convert(datetime,convert(varchar(8),@CALENDAR_DATE))), 112))                     ");
                    strSQL.Append(" CONVERT(VARCHAR(8), DATEADD(DAY,-1,(DATEADD(MONTH,8,CONVERT(DATETIME,CONVERT(VARCHAR(8),@CALENDAR_DATE))))), 112))  ");//UPD BY UBIQ-LIU 2010/09/03
                }
                else
                {
                    //Week
                    strSQL.Append(" AND CAL.CALENDAR_DATE  >= (SELECT MIN(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = @TTL_WEEK)      ");
                    strSQL.Append(" AND CAL.CALENDAR_DATE  <= (SELECT MAX(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = @TTL_WEEK + 7)  ");
                }
                strSQL.Append(" LEFT OUTER JOIN PURCHASE_MASTER PM ON PM.ITEM_NO  = PO.ITEM_NO                      ");
                strSQL.Append(" AND PO.VENDOR_CD = PM.VENDOR_CD                                                     ");
                strSQL.Append(" AND PO.PO_DUE_DATE >= PM.BEG_EFF_DATE                                               ");
                strSQL.Append("  AND PO.PO_DUE_DATE <= PM.END_EFF_DATE                                              ");
                strSQL.Append(" WHERE PO.SC_FLAG = 1                                                                ");
                strSQL.Append(" AND PO.ITEM_TYPE <> '99'           													");
                strSQL.Append(" AND PO.VENDOR_CD = @VENDOR_CD                                                       ");
                db.DbPsetString("@VENDOR_CD", _vendor_cd);
                if (item_no != "")
                {
                    strSQL.Append(" AND PO.ITEM_NO = @ITEM_NO                       ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (date_type == 1)
                {//Month
                    strSQL.Append("AND PO.PO_DUE_DATE >= @CALENDAR_DATE  AND PO.PO_DUE_DATE <=            ");
                    strSQL.Append("CONVERT(varchar(8), DATEADD(Month,8,convert(datetime,convert(varchar(8),@CALENDAR_DATE))), 112)  ");

                    db.DbPsetInt("@CALENDAR_DATE", _calendar_date);
                }
                else
                {
                    //Week
                    strSQL.Append(" AND PO.PO_DUE_DATE  >= (SELECT MIN(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = @TTL_WEEK) ");
                    strSQL.Append(" AND PO.PO_DUE_DATE  <= (SELECT MAX(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = @TTL_WEEK + 7)  ");
                    db.DbPsetInt("@TTL_WEEK", _ttl_week);
                }
            }
            strSQL.Append(" GROUP BY PO.ITEM_NO,    PO.ITEM_DESC,                                           ");
            strSQL.Append(" CASE PM.DELV_LT_TYPE WHEN 0 THEN convert(varchar,PM.DELV_LT) WHEN 1             ");
            strSQL.Append(" THEN convert(varchar,PM.DELV_LT_PROPORTION)   + '(LOT:' +                       ");
            strSQL.Append(" convert(varchar,PM.STD_LOT_SIZE) + ')' END,                                     ");
            if (_date_type == 0)
                strSQL.Append(" CAL.TTL_WEEK                                                ");
            else
                strSQL.Append(" CAL.CALENDAR_CYM                                            ");

            strSQL.Append(" ORDER BY PO.ITEM_NO ");
            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }


        //--> ADD BY UBIQ-SUO 2010/9/13
        /// <summary>
        /// フォーキャスト明細に表示
        /// 使用画面：Pur_SupplyInst
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Pur_FcstInqList(int range)
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                           ");
            strSQL.Append(" PO.ITEM_NO,         PO.ITEM_DESC,                                               ");
            strSQL.Append(" CASE PM.DELV_LT_TYPE WHEN 0 THEN convert(varchar,PM.DELV_LT) WHEN 1             ");
            strSQL.Append(" THEN convert(varchar,PM.DELV_LT_PROPORTION)   + '(LOT:' +                       ");
            strSQL.Append(" convert(varchar,PM.STD_LOT_SIZE) + ')' END DELV_LT ,SUM(PO.PO_QTY) PO_QTY,      ");
            if (_date_type == 0)
            {
                strSQL.Append(" CAL.TTL_WEEK DATE_NO                                                        ");
            }
            else
            {
                strSQL.Append(" CAL.CALENDAR_CYM  DATE_NO                                                   ");
            }
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PLANNED_ORDER PO,CALENDAR_MASTER CAL,PURCHASE_MASTER PM               ");
                strSQL.Append(" WHERE                                                                       ");
                strSQL.Append("  PO.ITEM_NO=PM.ITEM_NO                                                      ");
                strSQL.Append(" AND PO.VENDOR_CD = PM.VENDOR_CD                                             ");
                strSQL.Append(" AND PO.PO_DUE_DATE >= PM.BEG_EFF_DATE                                       ");
                strSQL.Append(" AND PO.PO_DUE_DATE <= PM.END_EFF_DATE                                       ");
                strSQL.Append("CAL.CALENDAR_DATE = PO.PO_DUE_DATE                                           ");
                if (date_type == 1)
                {//Month
                    strSQL.Append("AND CAL.CALENDAR_DATE >= :CALENDAR_DATE  AND CAL.CALENDAR_DATE <=            ");
                    strSQL.Append("CONVERT(varchar(8), DATEADD(Month,:RANGE,convert(datetime,:CALENDAR_DATE)), 112)  "); //UPD BY UBIQ-SUO 2010/9/13 8 => :RANGE

                    db.DbPsetInt("CALENDAR_DATE", _calendar_date);
                    db.DbPsetInt("RANGE", range);
                }
                else
                {
                    //Week
                    strSQL.Append(" AND CAL.CALENDAR_DATE  >= (SELECT MIN(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = :TTL_WEEK) ");
                    strSQL.Append(" AND CAL.CALENDAR_DATE  <= (SELECT MAX(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = :TTL_WEEK + :RANGE - 1)  ");//UPD BY UBIQ-SUO 2010/9/13 7 => :RANGE - 1
                    db.DbPsetInt("TTL_WEEK", _ttl_week);
                    db.DbPsetInt("RANGE", range);
                }
                strSQL.Append(" AND PO.VENDOR_CD = :VENDOR_CD                       ");
                if (item_no != "")
                {
                    strSQL.Append(" AND PO.ITEM_NO = :ITEM_NO                       ");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                strSQL.Append(" AND PO.SC_FLAG = 1                                  ");
                strSQL.Append(" AND PO.ITEM_TYPE <> '99'           					");
                strSQL.Append(" and sch_start_date >=                               ");
                if (date_type == 1)
                {//Month
                    strSQL.Append("AND PO.PO_DUE_DATE >= @CALENDAR_DATE  AND PO.PO_DUE_DATE <=            ");
                    strSQL.Append("CONVERT(varchar(8), DATEADD(Month,:RANGE,convert(datetime,@CALENDAR_DATE)), 112)  ");

                    db.DbPsetInt("CALENDAR_DATE", _calendar_date);
                    db.DbPsetInt("RANGE", range);
                }
                else
                {
                    //Week
                    strSQL.Append(" AND PO.PO_DUE_DATE  >= (SELECT MIN(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = :TTL_WEEK) ");
                    strSQL.Append(" AND PO.PO_DUE_DATE  <= (SELECT MAX(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = :TTL_WEEK + :RANGE - 1)  ");
                    db.DbPsetInt("TTL_WEEK", _ttl_week);
                    db.DbPsetInt("RANGE", range);
                }
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PLANNED_ORDER PO                                                    ");
                strSQL.Append(" LEFT JOIN CALENDAR_MASTER CAL ON CAL.CALENDAR_DATE  = PO.PO_DUE_DATE     ");
                if (_date_type == 1)
                {
                    //Month
                    strSQL.Append(" AND CAL.CALENDAR_DATE  >= (SELECT MIN(CALENDAR_DATE) from CALENDAR_MASTER WHERE CALENDAR_DATE >= @CALENDAR_DATE)      ");
                    strSQL.Append(" AND CAL.CALENDAR_DATE  <= (SELECT MAX(CALENDAR_DATE) from CALENDAR_MASTER WHERE CALENDAR_DATE <=                      ");
                    strSQL.Append(" CONVERT(VARCHAR(8), DATEADD(DAY,-1,(DATEADD(MONTH,@RANGE,CONVERT(DATETIME,CONVERT(VARCHAR(8),@CALENDAR_DATE))))), 112))  ");
                }
                else
                {
                    //Week
                    strSQL.Append(" AND CAL.CALENDAR_DATE  >= (SELECT MIN(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = @TTL_WEEK)      ");
                    strSQL.Append(" AND CAL.CALENDAR_DATE  <= (SELECT MAX(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = @TTL_WEEK + @RANGE - 1)  ");
                }
                strSQL.Append(" LEFT OUTER JOIN PURCHASE_MASTER PM ON PM.ITEM_NO  = PO.ITEM_NO                      ");
                strSQL.Append(" AND PO.VENDOR_CD = PM.VENDOR_CD                                                     ");
                strSQL.Append(" AND PO.PO_DUE_DATE >= PM.BEG_EFF_DATE                                               ");
                strSQL.Append("  AND PO.PO_DUE_DATE <= PM.END_EFF_DATE                                              ");
                strSQL.Append(" WHERE PO.SC_FLAG = 1                                                                ");
                strSQL.Append(" AND PO.ITEM_TYPE <> '99'           													");
                strSQL.Append(" AND PO.VENDOR_CD = @VENDOR_CD                                                       ");
                db.DbPsetString("@VENDOR_CD", _vendor_cd);
                if (item_no != "")
                {
                    strSQL.Append(" AND PO.ITEM_NO = @ITEM_NO                       ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (date_type == 1)
                {
                    //Month
                    strSQL.Append("AND PO.PO_DUE_DATE >= @CALENDAR_DATE  AND PO.PO_DUE_DATE <=            ");
                    strSQL.Append("CONVERT(varchar(8), DATEADD(Month,@RANGE,convert(datetime,convert(varchar(8),@CALENDAR_DATE))), 112)  ");

                    db.DbPsetInt("@CALENDAR_DATE", _calendar_date);
                    db.DbPsetInt("@RANGE", range);
                }
                else
                {
                    //Week
                    strSQL.Append(" AND PO.PO_DUE_DATE  >= (SELECT MIN(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = @TTL_WEEK) ");
                    strSQL.Append(" AND PO.PO_DUE_DATE  <= (SELECT MAX(CALENDAR_DATE) from CALENDAR_MASTER WHERE TTL_WEEK = @TTL_WEEK + @RANGE - 1)  ");
                    db.DbPsetInt("@TTL_WEEK", _ttl_week);
                    db.DbPsetInt("@RANGE", range);
                }
            }
            strSQL.Append(" GROUP BY PO.ITEM_NO,    PO.ITEM_DESC,                                           ");
            strSQL.Append(" CASE PM.DELV_LT_TYPE WHEN 0 THEN convert(varchar,PM.DELV_LT) WHEN 1             ");
            strSQL.Append(" THEN convert(varchar,PM.DELV_LT_PROPORTION)   + '(LOT:' +                       ");
            strSQL.Append(" convert(varchar,PM.STD_LOT_SIZE) + ')' END,                                     ");
            if (_date_type == 0)
                strSQL.Append(" CAL.TTL_WEEK                                                ");
            else
                strSQL.Append(" CAL.CALENDAR_CYM                                            ");

            strSQL.Append(" ORDER BY PO.ITEM_NO ");
            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        //<-- ADD BY UBIQ-SUO 2010/9/13

        /// <summary>
        /// 振替依頼データを検索
        /// 
        /// 2009.02.13 UPD BY CHEN
        /// 
        /// 使用画面：PurSupplySheetPrt
        /// </summary>
        public DataSet Get_Pur_SupplySheetList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql 
            strSQL.Append(" SELECT                                                              ");
            strSQL.Append(" T.BUYER_CD,T.TO_VC_CD VENDOR_CD, V.VENDOR_NAME, COUNT(*) NUM_OF_DTLS");
            strSQL.Append(" ,S.DATA_CHAR BUYER_DESC                                             ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T,VENDOR_MASTER V  ");
                strSQL.Append(" WHERE  ");
                strSQL.Append(" T.REQ_TYPE = '24' ");

                if (buyer_cd != "")
                {
                    strSQL.Append(" AND T.BUYER_CD         = :BUYER_CD ");
                    db.DbPsetString("BUYER_CD", _buyer_cd);
                }

                if (to_vc_cd != "")
                {
                    strSQL.Append(" AND T.TO_VC_CD         = :TO_VC_CD ");
                    db.DbPsetString("TO_VC_CD", _to_vc_cd);
                }
                strSQL.Append("   AND T.TO_VC_CD = V.VENDOR_CD ");
                if (reissue_flag == 0)
                {
                    strSQL.Append(" AND T.XFER_STATUS = 20 AND T.SLIP_PRINT_FLAG = 0 ");
                }
                else if (reissue_flag == 1)
                {
                    strSQL.Append(" AND T.XFER_STATUS = 30 AND T.TRANS_DATE = :TRANS_DATE AND T.SLIP_PRINT_FLAG = 1 ");
                    db.DbPsetInt("TRANS_DATE", _trans_date);
                }

                strSQL.Append("   GROUP BY TO_VC_CD,VENDOR_NAME ");

            }
            else
            {
                strSQL.Append(" FROM TRANSFER_TRANS T ");
                strSQL.Append(" LEFT JOIN VENDOR_MASTER V ON T.TO_VC_CD = V.VENDOR_CD   ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'BUYER_CD'    ");
                strSQL.Append(" AND S.KEY02 = T.BUYER_CD                                ");

                db.DbParametersClear();

                strSQL.Append(" WHERE  ");
                strSQL.Append(" T.REQ_TYPE = 24 ");

                if (buyer_cd != "")
                {
                    strSQL.Append("   AND T.BUYER_CD         = @BUYER_CD ");
                    db.DbPsetString("@BUYER_CD", _buyer_cd);
                }
                if (to_vc_cd != "")
                {
                    strSQL.Append("   AND T.TO_VC_CD         = @TO_VC_CD ");
                    db.DbPsetString("@TO_VC_CD", _to_vc_cd);
                }
                //strSQL.Append("   AND T.TO_VC_CD = V.VENDOR_CD ");
                if (reissue_flag == 0)
                {
                    strSQL.Append(" AND T.XFER_STATUS = 20 AND T.SLIP_PRINT_FLAG = 0 ");
                }
                else if (reissue_flag == 1)
                {
                    strSQL.Append(" AND T.XFER_STATUS = 30 AND ROUND(T.TRANS_DATE/100,0) = @TRANS_DATE AND T.SLIP_PRINT_FLAG = 1 ");
                    db.DbPsetInt("@TRANS_DATE", _trans_date);
                }

                strSQL.Append("   GROUP BY T.BUYER_CD,  T.TO_VC_CD, V.VENDOR_NAME,  S.DATA_CHAR ");
            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 振替依頼データを検索
        /// 
        /// 使用画面：PurSupplySheetPrt
        /// UPD BY BUIQ-CHEN 2009.03.23
        /// </summary>        
        public DataSet Get_Pur_SupplySheetDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql 
            strSQL.Append(" SELECT                                                                                  ");
            strSQL.Append(" T.TO_VC_CD VENDOR_CD,   V.VENDOR_NAME,      S.DATA_CHAR COMPANY_CD,     T.ITEM_NO,      ");
            strSQL.Append(" T.ITEM_DESC,            T.ACT_QTY QTY,      S2.DATA_CHAR ITEM_UMSR,                     ");
            strSQL.Append(" ACT_PRC = ISNULL(CASE WHEN T.TO_SUPPLY_TYPE = '2' THEN 0 WHEN T.TO_SUPPLY_TYPE = '1'    ");
            strSQL.Append(" THEN T.ACT_PRC END,0),                                                                  ");
            strSQL.Append(" T.ACT_QTY * ISNULL(CASE WHEN T.TO_SUPPLY_TYPE = '2' THEN 0                              ");
            strSQL.Append(" WHEN T.TO_SUPPLY_TYPE = '1' THEN T.ACT_PRC END,0)  ACT_AMT,                             ");
            strSQL.Append(" ISNULL(S3.DATA_CHAR,'') TO_CUR,T.TO_SUPPLY_TYPE,T.BUYER_CD,                             ");
            strSQL.Append(" CASE ISNULL(S5.DATA_INT,0) WHEN 0 THEN  S4.DATA_INT ELSE S5.DATA_INT END LANG           ");//ADD BY CHEN 20090413

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T,VENDOR_MASTER V,SYSTEM_PARAMETER S,SYSTEM_PARAMETER S2,SYSTEM_PARAMETER S3  ");
                strSQL.Append(" WHERE  ");
                strSQL.Append(" T.REQ_TYPE = '24' ");
                strSQL.Append(" AND T.TO_VC_CD = V.VENDOR_CD ");
                strSQL.Append(" AND S.KEY01 = 'COMPANY_CD' AND S.KEY02 = '*' ");
                strSQL.Append(" AND S2.KEY01 = 'ITEM_UMSR' AND S2.KEY02 = T.ITEM_UMSR ");
                strSQL.Append(" AND S3.KEY01 = 'CURRENCY_CD' AND S3.KEY02 = T.TO_CUR ");

                if (buyer_cd != "")
                {
                    strSQL.Append(" AND T.BUYER_CD         = :BUYER_CD ");
                    db.DbPsetString("BUYER_CD", _buyer_cd);
                }

                if (to_vc_cd != "")
                {
                    strSQL.Append(" AND T.TO_VC_CD         = :TO_VC_CD ");
                    db.DbPsetString("TO_VC_CD", _to_vc_cd);
                }

                if (reissue_flag == 0)
                {
                    strSQL.Append(" AND T.XFER_STATUS = 20 AND T.SLIP_PRINT_FLAG = 0 ");
                }
                else if (reissue_flag == 1)
                {
                    strSQL.Append(" AND T.XFER_STATUS = 30 AND T.TRANS_DATE = :TRANS_DATE  AND T.SLIP_PRINT_FLAG = 1 ");
                    db.DbPsetInt("TRANS_DATE", _trans_date);
                }

                strSQL.Append("   GROUP BY T.TO_VC_CD,V.VENDOR_NAME, S.DATA_CHAR,T.ITEM_NO,                 ");
                strSQL.Append("   T.ITEM_DESC,S2.DATA_CHAR,ACT_PRC,S3.DATA_CHAR,T.TO_SUPPLY_TYPE            ");
                strSQL.Append("   ORDER BY T.TO_VC_CD,T.ITEM_NO,T.TO_SUPPLY_TYPE,S3.DATA_CHAR               ");
            }
            else
            {
                strSQL.Append("   FROM TRANSFER_TRANS T                                                                 ");
                strSQL.Append("   LEFT JOIN VENDOR_MASTER V ON T.TO_VC_CD = V.VENDOR_CD                                 ");
                strSQL.Append("   LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'COMPANY_CD' AND S.KEY02 = '*'              ");
                strSQL.Append("   LEFT JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'ITEM_UMSR' AND S2.KEY02 = T.ITEM_UMSR    ");
                strSQL.Append("   LEFT JOIN SYSTEM_PARAMETER S3 ON S3.KEY01 = 'CURRENCY_CD' AND S3.KEY02 = T.TO_CUR     ");
                strSQL.Append("   LEFT JOIN SYSTEM_PARAMETER S4 ON S4.KEY01  = 'PRINT_LANG'                             ");
                strSQL.Append("   AND  S4.KEY02   =   '*'                                                               ");
                strSQL.Append("   LEFT JOIN SYSTEM_PARAMETER S5 ON S5.KEY01  = 'COUNTRY_CD'                             ");
                strSQL.Append("   AND  S5.KEY02   =   V.COUNTRY_CD                                                      ");
                db.DbParametersClear();

                strSQL.Append(" WHERE  ");
                strSQL.Append(" T.REQ_TYPE = '24' ");

                if (buyer_cd != "")
                {
                    strSQL.Append("   AND T.BUYER_CD         = @BUYER_CD ");
                    db.DbPsetString("@BUYER_CD", _buyer_cd);
                }
                if (to_vc_cd != "")
                {
                    strSQL.Append("   AND T.TO_VC_CD         = @TO_VC_CD ");
                    db.DbPsetString("@TO_VC_CD", _to_vc_cd);
                }
                if (reissue_flag == 0)
                {
                    strSQL.Append(" AND T.XFER_STATUS = 20 AND T.SLIP_PRINT_FLAG = 0 ");
                }
                else if (reissue_flag == 1)
                {
                    strSQL.Append(" AND T.XFER_STATUS = 30 AND ROUND(T.TRANS_DATE/100,0) = @TRANS_DATE AND T.SLIP_PRINT_FLAG = 1 ");
                    db.DbPsetInt("@TRANS_DATE", _trans_date);
                }

                //strSQL.Append("   GROUP BY T.TO_VC_CD,V.VENDOR_NAME, S.DATA_CHAR,T.ITEM_NO,                 ");
                //strSQL.Append("   T.ITEM_DESC,S2.DATA_CHAR,ACT_PRC,S3.DATA_CHAR,                            ");
                //strSQL.Append("   T.TO_SUPPLY_TYPE,T.BUYER_CD,                                              ");
                //strSQL.Append("   CASE ISNULL(S5.DATA_INT,0) WHEN 0 THEN  S4.DATA_INT ELSE S5.DATA_INT END  ");
                strSQL.Append("   ORDER BY T.TO_VC_CD,T.ITEM_NO,T.TO_SUPPLY_TYPE,S3.DATA_CHAR               ");
            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 注文書発行済に更新プロシジャ
        /// 使用画面：PurSupplySheetPrt
        /// </summary>
        /// <returns></returns>
        public int Pur_SupplySheetPrt(ComDB db)
        {
            //ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_BUYER_CD", _buyer_cd, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_PUR_SUPPLYSHEETPRT");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                //db.DbCommit();
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                //db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 仕入先が明細編集
        /// 使用画面：計画発注指示PurPORlse
        /// </summary>        
        public int Get_Pur_PoRlseVendorChgDetail()
        {
            ComLibrary com = new ComLibrary();
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql 
            strSQL.Append(" SELECT                                                                                      ");
            strSQL.Append(" P.VENDOR_NAME,          P.VENDOR_ITEM_NO,      P.VENDOR_ITEM_DESC,     PO.PO_QTY,           ");
            strSQL.Append(" PO_PRC =  ISNULL(CASE WHEN ISNULL(P1.TENTATIVE_PRC,-1) = -1                                 ");
            strSQL.Append("THEN (CASE WHEN P2.COM_PRC_FLAG = 0 THEN P2.ACT_PRC ELSE P2.TENTATIVE_PRC END)               ");
            strSQL.Append("ELSE (CASE WHEN P1.COM_PRC_FLAG = 0 THEN P1.ACT_PRC ELSE P1.TENTATIVE_PRC END) END, 0),      ");
            strSQL.Append("PO.PO_QTY * ISNULL(CASE WHEN ISNULL(P1.TENTATIVE_PRC,-1) = -1                                ");
            strSQL.Append("THEN (CASE WHEN P2.COM_PRC_FLAG = 0 THEN P2.ACT_PRC ELSE P2.TENTATIVE_PRC END)               ");
            strSQL.Append("ELSE (CASE WHEN P1.COM_PRC_FLAG = 0 THEN P1.ACT_PRC ELSE P1.TENTATIVE_PRC END) END,0) PO_AMT,");
            strSQL.Append("PO_CUR = ISNULL(CASE WHEN ISNULL(S2.KEY02,'' )= '' THEN S3.KEY02 ELSE S2.KEY02 END,''),      ");
            strSQL.Append("PO_CUR_NAME = ISNULL(CASE WHEN ISNULL(S2.DATA_CHAR,'' )= ''                                  ");
            strSQL.Append(" THEN S3.DATA_CHAR ELSE S2.DATA_CHAR END,'')                                                 ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T,VENDOR_MASTER V,SYSTEM_PARAMETER S,SYSTEM_PARAMETER S2,SYSTEM_PARAMETER S3  ");
                strSQL.Append(" WHERE  ");
                strSQL.Append(" T.REQ_TYPE = '24' ");
                strSQL.Append(" AND T.TO_VC_CD = V.VENDOR_CD ");
                strSQL.Append(" AND S.KEY01 = 'COMPANY_CD' AND S.KEY02 = '*' ");
                strSQL.Append(" AND S2.KEY01 = 'ITEM_UMSR' AND S2.KEY02 = T.ITEM_UMSR ");
                strSQL.Append(" AND S3.KEY01 = 'CURRENCY_CD' AND S3.KEY02 = T.TO_CUR ");

                if (buyer_cd != "")
                {
                    strSQL.Append(" AND T.BUYER_CD         = :BUYER_CD ");
                    db.DbPsetString("BUYER_CD", _buyer_cd);
                }

                if (to_vc_cd != "")
                {
                    strSQL.Append(" AND T.TO_VC_CD         = :TO_VC_CD ");
                    db.DbPsetString("TO_VC_CD", _to_vc_cd);
                }

                if (reissue_flag == 0)
                {
                    strSQL.Append(" AND T.XFER_STATUS = 20 AND T.SLIP_PRINT_FLAG = 0 ");
                }
                else if (reissue_flag == 1)
                {
                    strSQL.Append(" AND T.XFER_STATUS = 30 AND T.TRANS_DATE = :TRANS_DATE  AND T.SLIP_PRINT_FLAG = 1 ");
                    db.DbPsetInt("TRANS_DATE", _trans_date);
                }

                strSQL.Append("   GROUP BY T.TO_VC_CD,V.VENDOR_NAME, S.DATA_CHAR,T.ITEM_NO, ");
                strSQL.Append("   T.ITEM_DESC,S2.DATA_CHAR,ACT_PRC,S3.DATA_CHAR,T.TO_SUPPLY_TYPE ");
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM PLANNED_ORDER PO                                                               ");
                //購買マスタよりメーカー名、メーカー品番、メーカー品名の抽出条件（外部結合）
                strSQL.Append(" LEFT JOIN PURCHASE_MASTER P ON    P.ITEM_NO       =       PO.ITEM_NO                ");
                strSQL.Append(" AND P.BEG_EFF_DATE <= PO.PO_DUE_DATE                                                ");
                strSQL.Append(" AND P.END_EFF_DATE >= PO.PO_DUE_DATE                                                ");
                strSQL.Append(" AND P.PTY_NO       = (SELECT MIN(PTY_NO)  FROM    PURCHASE_MASTER PM,               ");
                strSQL.Append(" PLANNED_ORDER PO1                                                                   ");
                strSQL.Append(" WHERE PO1.ORDER_NO   = @ORDER_NO                                                    ");
                strSQL.Append(" AND PM.ITEM_NO       = PO1.ITEM_NO                                                  ");
                strSQL.Append(" AND PM.BEG_EFF_DATE <= PO1.PO_DUE_DATE                                              ");
                strSQL.Append(" AND PM.END_EFF_DATE >= PO1.PO_DUE_DATE                                              ");
                strSQL.Append(" AND PM.VENDOR_CD      = @VENDOR_CD     )                                            ");
                //品目作業場所マスタより、作業区コードの抽出（外部結合）
                strSQL.Append(" LEFT JOIN ITEM_WS_MASTER IW ON    IW.ITEM_NO       =       PO.ITEM_NO               ");
                strSQL.Append(" AND IW.BEG_EFF_DATE <= PO.PO_DUE_DATE                                               ");
                strSQL.Append(" AND IW.END_EFF_DATE >= PO.PO_DUE_DATE                                               ");
                strSQL.Append(" AND IW.PTY_NO       = (SELECT MIN(PTY_NO)  FROM    PURCHASE_MASTER PM,              ");
                strSQL.Append(" PLANNED_ORDER PO1                                                                   ");
                strSQL.Append(" WHERE PO1.ORDER_NO   = @ORDER_NO                                                    ");
                strSQL.Append(" AND PM.ITEM_NO       = PO1.ITEM_NO                                                  ");
                strSQL.Append(" AND PM.BEG_EFF_DATE <= PO1.PO_DUE_DATE                                              ");
                strSQL.Append(" AND PM.END_EFF_DATE >= PO1.PO_DUE_DATE                                              ");
                strSQL.Append(" AND PM.VENDOR_CD      = @VENDOR_CD     )                                            ");
                //計画オーダの予定着手日にて購入単価マスタより単価を抽出する。
                strSQL.Append(" LEFT JOIN PURCHASE_PRICE_MASTER P1     ON  PO.ITEM_NO = P1.ITEM_NO                  ");
                strSQL.Append(" AND P1.WS_CD = (CASE WHEN ISNULL(IW.WS_CD,'' )= '' THEN '*' ELSE IW.WS_CD END)      ");
                strSQL.Append(" AND P1.PROCESS_CD = '*' AND P1.VENDOR_CD = @VENDOR_CD                               ");
                strSQL.Append(" AND P1.BEG_EFF_DATE <= PO.SCH_START_DATE                                            ");
                strSQL.Append(" AND P1.END_EFF_DATE >= PO.SCH_START_DATE                                            ");
                strSQL.Append(" AND P1.UNIT_PRC_BASE = 0                                                            ");
                //計画オーダの予定完成日にて購入単価マスタより単価を抽出する。
                strSQL.Append(" LEFT JOIN PURCHASE_PRICE_MASTER P2    ON   PO.ITEM_NO = P2.ITEM_NO                  ");
                strSQL.Append(" AND P2.WS_CD = (CASE WHEN ISNULL(IW.WS_CD,'' )= '' THEN '*' ELSE IW.WS_CD END)      ");
                strSQL.Append(" AND P2.PROCESS_CD        = '*'                                                      ");
                strSQL.Append(" AND P2.VENDOR_CD         = @VENDOR_CD                                               ");
                strSQL.Append(" AND P2.BEG_EFF_DATE     <= PO.SCH_COMPL_DATE AND                                    ");
                strSQL.Append(" P2.END_EFF_DATE         >= PO.SCH_COMPL_DATE                                        ");
                strSQL.Append(" AND P2.UNIT_PRC_BASE    = 1                                                         ");

                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'CURRENCY_CD' AND                       ");
                strSQL.Append(" S2.KEY02 = ISNULL(CASE WHEN ISNULL(P1.TENTATIVE_PRC,-1) = -1                        ");
                strSQL.Append(" THEN (CASE WHEN P2.COM_PRC_FLAG = 0 THEN P2.ACT_CUR ELSE P2.TENTATIVE_CUR END)      ");
                strSQL.Append(" ELSE (CASE WHEN P1.COM_PRC_FLAG = 0 THEN P1.ACT_CUR ELSE P1.TENTATIVE_CUR END)      ");
                strSQL.Append(" END,'')                                                                             ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S3 ON S3.KEY01 = 'CURRENCY_CD'                     ");
                strSQL.Append(" AND S3.DATA_INT = 1                                                                 ");

                strSQL.Append(" WHERE                                                                               ");
                strSQL.Append(" PO.ORDER_NO         = @ORDER_NO                                                     ");

                db.DbPsetString("@VENDOR_CD", _vendor_cd);
                db.DbPsetString("@ORDER_NO", _order_no);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _vendor_name = db.Row("VENDOR_NAME");
                _vendor_item_no = db.Row("VENDOR_ITEM_NO");
                _vendor_item_desc = db.Row("VENDOR_ITEM_DESC");
                _po_qty = com.StringToDouble(db.Row("PO_QTY"));
                _po_prc = com.StringToDouble(db.Row("PO_PRC"));
                _po_amt = com.StringToDouble(db.Row("PO_AMT"));
                _po_cur = db.Row("PO_CUR");
                _po_cur_name = db.Row("PO_CUR_NAME");
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;

        }

        /// <summary>
        /// オーダー№の所要情報を検索して子部品明細画面に表示する
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Pur_PoReleasedDemandList()//20090319 ADD UBIQ-LIU
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                                       ");
            strSQL.Append("PUR.ORDER_NO,            PUR.WHS_CD,           WHS.WHS_DESC,        PUR.JOC_CD,              ");
            strSQL.Append("PUR.ITEM_NO PARENT_ITEM, PUR.ITEM_DESC PARENT_ITEM_DESC,         PUR.PO_QTY,                 ");
            strSQL.Append("PUR.PO_UMSR,             S1.DATA_CHAR USMR_NAME,                                             ");
            strSQL.Append("D.ITEM_NO CHILD_ITEM,    IM.ITEM_DESC CHILD_ITEM_DESC,           D.PLAN_QTY,                 ");
            strSQL.Append("D.PROCESS_CD,            PM.PROCESS_DESC,    D.SCH_DISB_DATE,    D.DISB_WHS,                 ");
            strSQL.Append("ISNULL(INV.INV_QTY,0) INV_QTY,  D.ALLOC_QTY,  ISNULL(WIP.WIP_QTY,0) WIP_QTY,                 ");
            strSQL.Append("ISNULL(D.ACT_DISB_QTY,0) ACT_DISB_QTY,                                                       ");//ADD 20090610 UBIQ_LIU
            strSQL.Append("ISNULL(WIPALLOC.WIP_ALLOC_QTY,0) WIP_ALLOC_QTY                                               ");
            strSQL.Append(",ISNULL(D.PLAN_DISB_QTY,0) PLAN_DISB_QTY,    D.DEMAND_NO                                     ");//ADD 20090910 UBIQ_HU
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM DEMAND D , INVENTORY_DETAIL INV,                                   ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD,               ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) INV_QTY        ");
                strSQL.Append(" FROM    INVENTORY_DETAIL,DEMAND,JOB_ORDER                               ");
                strSQL.Append(" WHERE   PUR_ORDER.ORDER_NO      =   :ORDER_NO                           ");
                strSQL.Append(" AND     DEMAND.ORDER_NO         =   PUR.ORDER_NO                        ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 0                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.ITEM_NO = DEMAND.ITEM_NO(+)                    ");
                strSQL.Append(" AND     INVENTORY_DETAIL.WHS_CD = DEMAND.DISB_WHS(+)  )  INV,           ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD,               ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) WIP_QTY        ");
                strSQL.Append(" FROM    INVENTORY_DETAIL,DEMAND,JOB_ORDER                               ");
                strSQL.Append(" WHERE   PUR.JOB_ORDER_NO        =   :ORDER_NO                           ");
                strSQL.Append(" AND     DEMAND.ORDER_NO         =   PUR_ORDER.ORDER_NO(+)               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 1                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.ITEM_NO = DEMAND.ITEM_NO                       ");
                strSQL.Append(" AND     INVENTORY_DETAIL.WS_CD = DEMAND.WS_CD  )  WIP,                  ");

                strSQL.Append(" (SELECT WIP_ALLOC.DEMAND_NO,SUM(WIP_ALLOC.ALLOC_QTY)                    ");
                strSQL.Append(" FROM    WIP_ALLOC,DEMAND ,JOB_ORDER                                     ");
                strSQL.Append(" WHERE   DEMAND.ORDER_NO         =   :ORDER_NO                           ");
                strSQL.Append(" AND     DEMAND.ORDER_NO =   PUR_ORDER.ORDER_NO                          ");
                strSQL.Append(" AND     DEMAND.DEMAND_NO =   WIP_ALLOC.DEMAND_NO                        ");
                strSQL.Append(" AND     WIP_ALLOC.ALLOC_STATUS  <=   20                                 ");
                strSQL.Append(" AND     WIP_ALLOC.SCH_FLAG      IN (0,2)                  )  WIPALLOC   ");

                strSQL.Append(" WHERE  D.ORDER_NO =   :ORDER_NO                                        ");
                strSQL.Append(" AND  D.ITEM_NO =   INV.ITEM_NO                                         ");
                strSQL.Append(" AND  D.WHS_CD =   INV.WHS_CD                                           ");
                strSQL.Append(" AND  D.ITEM_NO =   WIP.ITEM_NO                                         ");
                strSQL.Append(" AND  D.DISB_WHS =   WIP.WS_CD                                          ");
                strSQL.Append(" AND  D.ORDER_NO =   PO.ORDER_NO                                        ");
                strSQL.Append(" AND  (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1)) ");
                strSQL.Append(" AND  D.ITEM_TYPE  <> '99' 												");

                db.DbPsetString("ORDER_NO", _order_no);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM DEMAND D                                                               ");
                strSQL.Append(" LEFT OUTER JOIN PUR_ORDER PUR ON  D.ORDER_NO =   PUR.ORDER_NO               ");
                strSQL.Append(" INNER JOIN ITEM_MASTER IM ON D.ITEM_NO = IM.ITEM_NO                         ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER VM ON PUR.VENDOR_CD = VM.VENDOR_CD            ");
                strSQL.Append(" LEFT OUTER JOIN                                                             ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD,                   ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) INV_QTY            ");
                strSQL.Append(" FROM    INVENTORY_DETAIL,   DEMAND,    PUR_ORDER                            ");
                strSQL.Append(" WHERE   PUR_ORDER.ORDER_NO      =   @ORDER_NO                               ");
                strSQL.Append(" AND     DEMAND.ORDER_NO         =   PUR_ORDER.ORDER_NO                      ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_YM =   0                                       ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                       ");
                strSQL.Append(" AND     INVENTORY_DETAIL.ITEM_NO = DEMAND.ITEM_NO                           ");
                strSQL.Append(" AND     INVENTORY_DETAIL.WHS_CD = DEMAND.DISB_WHS                           ");
                strSQL.Append(" GROUP BY  INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD )  INV ON        ");
                strSQL.Append("      D.ITEM_NO =   INV.ITEM_NO                                              ");
                strSQL.Append(" AND  D.DISB_WHS =   INV.WHS_CD                                              ");
                strSQL.Append(" LEFT OUTER JOIN                                                             ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD,                   ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) WIP_QTY            ");
                strSQL.Append(" FROM    INVENTORY_DETAIL,    PUR_ORDER                                      ");
                strSQL.Append(" LEFT OUTER JOIN DEMAND ON DEMAND.ORDER_NO   =   PUR_ORDER.ORDER_NO          ");
                strSQL.Append(" INNER JOIN ITEM_MASTER ON DEMAND.ITEM_NO   =   ITEM_MASTER.ITEM_NO          ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER ON VENDOR_MASTER.VENDOR_CD=PUR_ORDER.VENDOR_CD");
                strSQL.Append(" WHERE   PUR_ORDER.ORDER_NO      =   @ORDER_NO                               ");
                strSQL.Append(" AND     DEMAND.ORDER_NO         =   PUR_ORDER.ORDER_NO                      ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_YM =   0                                       ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                       ");
                strSQL.Append(" AND     INVENTORY_DETAIL.ITEM_NO = DEMAND.ITEM_NO                           ");
                strSQL.Append(" AND     INVENTORY_DETAIL.WHS_CD = CASE ITEM_MASTER.BOND_TYPE WHEN 1 THEN    ");
                strSQL.Append(" VENDOR_MASTER.BOND_SUPPLY_WHS ELSE VENDOR_MASTER.SUPPLY_WHS END             ");//ADD BY UBIQ-LIU 2010/6/21 ADD'VENDOR_MASTER.'
                strSQL.Append(" GROUP BY  INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD )  WIP ON        ");
                strSQL.Append("      D.ITEM_NO =   WIP.ITEM_NO                                              ");
                strSQL.Append(" AND CASE IM.BOND_TYPE WHEN 1 THEN VM.BOND_SUPPLY_WHS                        ");
                strSQL.Append(" ELSE VM.SUPPLY_WHS END =   WIP.WHS_CD                                       ");
                strSQL.Append(" LEFT OUTER JOIN                                                             ");
                strSQL.Append(" (SELECT WIP_ALLOC.DEMAND_NO,SUM(WIP_ALLOC.ALLOC_QTY)  WIP_ALLOC_QTY         ");
                strSQL.Append(" FROM    WIP_ALLOC,DEMAND ,PUR_ORDER                                         ");
                strSQL.Append(" WHERE   DEMAND.ORDER_NO =   @ORDER_NO                                       ");
                strSQL.Append(" AND     DEMAND.ORDER_NO =   PUR_ORDER.ORDER_NO                              ");
                strSQL.Append(" AND     DEMAND.DEMAND_NO =   WIP_ALLOC.DEMAND_NO                            ");
                strSQL.Append(" AND     WIP_ALLOC.ALLOC_STATUS  <=   20                                     ");
                strSQL.Append(" AND     WIP_ALLOC.SCH_FLAG      IN (0,2)                                    ");
                strSQL.Append(" GROUP BY  WIP_ALLOC.DEMAND_NO   )  WIPALLOC  ON                             ");
                strSQL.Append("      D.DEMAND_NO    =   WIPALLOC.DEMAND_NO                                  ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WHS ON PUR.WHS_CD = WHS.WHS_CD             ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON PUR.ORDER_UMSR = S1.KEY02            ");
                strSQL.Append(" AND      S1.KEY01   =   'ITEM_UMSR'                                         ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PM ON D.WS_CD = PM.WS_CD AND D.PROCESS_CD = PM.PROCESS_CD           ");
                strSQL.Append(" WHERE   PUR.ORDER_NO     =   @ORDER_NO                                      ");
                strSQL.Append(" AND (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))   ");
                strSQL.Append(" AND D.ITEM_TYPE  <> '99' 													");
                strSQL.Append(" ORDER BY CHILD_ITEM                                                         ");

                db.DbPsetString("@ORDER_NO", _order_no);
            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 納品書発行対象データを検索
        /// 
        /// 使用画面：PurPODeliveryPrt
        /// </summary>
        public DataSet Get_Pur_Delivery()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql 
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append("P.BUYER_CD,      S1.DATA_CHAR BUYER_NAME,                                    ");
            strSQL.Append("P.VENDOR_CD,     V.VENDOR_NAME,      P.PO_DUE_DATE,  COUNT(*) NUM_OF_DTLS    ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PUR_ORDER P,VENDOR_MASTER V                ");
                strSQL.Append(" WHERE                                           ");
                strSQL.Append(" P.VENDOR_CD = V.VENDOR_CD                       ");

                if (buyer_cd != "")
                {
                    strSQL.Append("   AND P.BUYER_CD         = :BUYER_CD ");
                    db.DbPsetString("BUYER_CD", _buyer_cd);
                }
                if (vendor_cd != "")
                {
                    strSQL.Append("   AND P.VENDOR_CD        = :VENDOR_CD ");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                }
                if (po_due_date != 0)
                {
                    strSQL.Append("   AND P.PO_DUE_DATE      = :PO_DUE_DATE ");
                    db.DbPsetInt("PO_DUE_DATE", _po_due_date);
                }

                if (request_no == 1)//1:納品書発行モード
                {
                    strSQL.Append(" AND  P.RECV_QTY                  =      0         ");
                    if (reissue_flag == 0)//発行の場合                        
                    {
                        strSQL.Append(" AND P.DELIVERY_PRINT_FLAG       =       0     ");//納品書未発行                        
                    }
                    else//再発行の場合
                    {
                        strSQL.Append(" AND P.DELIVERY_PRINT_FLAG       =       1     ");//納品書発行済
                    }
                }
                else//2:分納品書発行モード
                {
                    if (reissue_flag == 0)//発行の場合
                    {
                        strSQL.Append(" AND P.DELIVERY_PRINT_FLAG       =       0     ");//納品書未発行
                        strSQL.Append(" AND P.RECV_QTY                  >      0      ");
                    }
                    else//再発行の場合
                    {
                        strSQL.Append(" AND P.DELIVERY_PRINT_FLAG       =       1     ");//納品書発行済
                        strSQL.Append(" AND P.RECV_QTY                  >      0      ");
                    }
                }
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append("   FROM PUR_ORDER P                                          ");
                strSQL.Append("   LEFT JOIN SYSTEM_PARAMETER S1 ON S1.KEY01 = 'BUYER_CD'    ");
                strSQL.Append(" AND S1.KEY02      =      P.BUYER_CD                         ");
                strSQL.Append("   LEFT JOIN VENDOR_MASTER V ON P.VENDOR_CD = V.VENDOR_CD    ");
                strSQL.Append(" WHERE P.ORDER_STATUS    >=      25                          ");
                strSQL.Append(" AND P.ORDER_STATUS      <       30                          ");

                if (buyer_cd != "")
                {
                    strSQL.Append("   AND P.BUYER_CD         = @BUYER_CD    ");
                    db.DbPsetString("@BUYER_CD", _buyer_cd);
                }
                if (vendor_cd != "")
                {
                    strSQL.Append("   AND P.VENDOR_CD        = @VENDOR_CD   ");
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                }
                if (po_due_date != 0)
                {
                    strSQL.Append("   AND P.PO_DUE_DATE      = @PO_DUE_DATE ");
                    db.DbPsetInt("PO_DUE_DATE", _po_due_date);
                }
                if (request_no == 1)//1:納品書発行モード
                {
                    strSQL.Append(" AND  P.RECV_QTY                  =      0         ");
                    if (reissue_flag == 0)//発行の場合
                    {
                        strSQL.Append(" AND P.DELIVERY_PRINT_FLAG       =       0     ");//納品書未発行
                    }
                    else//再発行の場合                        
                    {
                        strSQL.Append(" AND P.DELIVERY_PRINT_FLAG       =       1     ");//納品書発行済
                    }
                }
                else//2:分納品書発行モード
                {
                    strSQL.Append(" AND P.RECV_QTY                  >      0     ");
                    if (reissue_flag == 0)//発行の場合
                    {
                        strSQL.Append(" AND P.DELIVERY_PRINT_FLAG       =       0     ");//納品書未発行
                    }
                    else//再発行の場合
                    {
                        strSQL.Append(" AND P.DELIVERY_PRINT_FLAG       =       1     ");//納品書発行済
                    }
                }
            }
            strSQL.Append(" GROUP BY P.VENDOR_CD,   P.PO_DUE_DATE,  V.VENDOR_NAME,  P.BUYER_CD,     S1.DATA_CHAR   ");

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 購買オーダの納品書発行ﾌﾗｸﾞを発行済に更新
        /// 
        /// 使用画面：PurPODeliveryPrt
        /// </summary>
        public int Pur_DeliveryPrt(ComDB db)
        {
            //ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_BUYER_CD", _buyer_cd, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_DUE_DATE", _po_due_date, ComConst.DB_IN);
            db.DbPsetInt("@I_REQUEST_NO", _request_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_PUR_DELIVERYPRT");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                //db.DbCommit();
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                //db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 納品書発行対象データを明細行
        /// 
        /// 使用画面：PurPODeliveryPrt
        /// </summary>
        public DataSet Get_Pur_DeliveryDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql 
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append("V.ZIP_CD,       V.ADDRESS1,      V.ADDRESS2,    V.ADDRESS3,   V.ADDRESS4,    ");
            strSQL.Append("V.VENDOR_DESC,       V.VENDOR_ATTN,      V.TELNO,            V.FAXNO,        ");
            strSQL.Append("P.PO_DUE_DATE,       S1.DATA_CHAR,       S1.DATA_CHAR3,      S1.DATA_CHAR4,  ");
            strSQL.Append("P.BUYER_CD,          S1.DATA_CHAR5,      S1.DATA_CHAR6,      P.PO_NO,        ");
            strSQL.Append("P.PO_LINE_NO,        P.ITEM_NO,          P.ITEM_DESC,        P.PO_QTY,       ");
            strSQL.Append("P.PO_UMSR,           P.VENDOR_NAME,      P.JOC_CD,         P.VENDOR_ITEM_NO, ");
            strSQL.Append("P.VENDOR_ITEM_DESC,  S2.DATA_CHAR UMSR_NAME,P.RECV_QTY,      P.REJ_QTY,      ");
            strSQL.Append("P.RECV_LOC,     S3.DATA_CHAR BUYER_NAME, V.VENDOR_CD,                        ");
            strSQL.Append("CASE ISNULL(S5.DATA_INT,0) WHEN 0 THEN  S4.DATA_INT ELSE S5.DATA_INT END LANG");//ADD BY LIU 20090410

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PUR_ORDER P,VENDOR_MASTER V                            ");
                strSQL.Append(" WHERE                                                       ");
                strSQL.Append(" P.VENDOR_CD             = V.VENDOR_CD                       ");
                strSQL.Append(" AND P.VENDOR_CD         = :VENDOR_CD                        ");
                strSQL.Append(" AND P.PO_DUE_DATE       = :PO_DUE_DATE                      ");
                db.DbPsetString("VENDOR_CD", _vendor_cd);
                db.DbPsetInt("PO_DUE_DATE", _po_due_date);

                if (request_no == 1)//1:納品書発行モード
                {
                    strSQL.Append(" AND  P.RECV_QTY                  =      0         ");
                    if (reissue_flag == 0)//発行の場合
                    {
                        strSQL.Append(" AND P.DELIVERY_PRINT_FLAG       =       0     ");//納品書未発行
                    }
                    else//再発行の場合
                    {
                        strSQL.Append(" AND P.DELIVERY_PRINT_FLAG       =       1     ");//納品書発行済
                    }
                }
                else//2:分納品書発行モード
                {
                    strSQL.Append(" AND P.RECV_QTY                  >       0     ");
                    if (reissue_flag == 0)//発行の場合                        
                    {
                        strSQL.Append(" AND P.DELIVERY_PRINT_FLAG       =       0     ");//納品書未発行
                    }
                    else//再発行の場合                        
                    {
                        strSQL.Append(" AND P.DELIVERY_PRINT_FLAG       =       1     ");//納品書発行済
                    }
                }
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM PUR_ORDER P                                            ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S1 ON S1.KEY01  = 'COMPANY_CD'   ");
                strSQL.Append(" AND  S1.KEY02   =   '*'                                     ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S2 ON P.PO_UMSR = S2.KEY02       ");
                strSQL.Append(" AND  S2.KEY01   =   'ITEM_UMSR'                             ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S3 ON S3.KEY01 = 'BUYER_CD'      ");
                strSQL.Append(" AND S3.KEY02      =      P.BUYER_CD                         ");
                strSQL.Append(" LEFT JOIN VENDOR_MASTER V ON P.VENDOR_CD = V.VENDOR_CD      ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S4 ON S4.KEY01  = 'PRINT_LANG'   ");
                strSQL.Append(" AND  S4.KEY02   =   '*'                                     ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S5 ON S5.KEY01  = 'COUNTRY_CD'   ");
                strSQL.Append(" AND  S5.KEY02   =   V.COUNTRY_CD                            ");
                strSQL.Append(" WHERE P.ORDER_STATUS    >=      25                          ");
                strSQL.Append(" AND P.ORDER_STATUS      <       30                          ");
                strSQL.Append(" AND P.VENDOR_CD         =       @VENDOR_CD                  ");
                strSQL.Append(" AND P.PO_DUE_DATE       =       @PO_DUE_DATE                ");

                db.DbPsetString("@VENDOR_CD", _vendor_cd);
                db.DbPsetInt("@PO_DUE_DATE", _po_due_date);

                if (request_no == 1)//1:納品書発行モード
                {
                    strSQL.Append(" AND  P.RECV_QTY                  =      0         ");
                    if (reissue_flag == 0)//発行の場合
                    {
                        strSQL.Append(" AND P.DELIVERY_PRINT_FLAG       =       0     ");//納品書未発行
                    }
                    else//再発行の場合
                    {
                        strSQL.Append(" AND P.DELIVERY_PRINT_FLAG       =       1     ");//納品書発行済
                    }
                }
                else//2:分納品書発行モード                   
                {
                    strSQL.Append(" AND P.RECV_QTY                  >      0     ");
                    if (reissue_flag == 0)//発行の場合
                    {
                        strSQL.Append(" AND P.DELIVERY_PRINT_FLAG       =       0     ");//納品書未発行
                    }
                    else//再発行の場合
                    {
                        strSQL.Append(" AND P.DELIVERY_PRINT_FLAG       =       1     ");//納品書発行済
                    }
                }
            }
            strSQL.Append(" ORDER BY P.VENDOR_CD,   P.PO_DUE_DATE,  V.VENDOR_NAME   ");

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 購入品受入情報入力プロシジャ
        /// 使用画面：PurManRcv
        /// </summary>
        /// <returns></returns>
        public int Pur_ManRcvInsert(ComDB db)
        {
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PO_NO", _po_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_LINE_NO", po_line_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_DESC", _item_desc, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_PO_QTY", _po_qty, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_DUE_DATE", po_due_date, ComConst.DB_IN);
            db.DbPsetString("@I_INVOICE_NO", _joc_cd, ComConst.DB_IN);  // joc_cdにINVOICE_NOが入っている
            db.DbPsetString("@I_LOT_NO", _joc_item_no, ComConst.DB_IN); // joc_item_noにLOT_NOが入っている
            
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_PUR_MANRCV_INSERT");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 購入品受入情報明細削除プロシジャ
        /// 使用画面：PurManRcvUpd
        /// </summary>
        /// <returns></returns>
        public int Pur_ManRcvDetailDelete(ComDB db)
        {
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PO_NO", _po_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_LINE_NO", po_line_no, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_PUR_MANRCV_DETAIL_DELETE");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 購入品受入情報明細更新プロシジャ
        /// 使用画面：PurManRcvUpd
        /// </summary>
        /// <returns></returns>
        public int Pur_ManRcvUpdate(ComDB db)
        {
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PO_NO", _po_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_LINE_NO", po_line_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_DESC", _item_desc, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_PO_QTY", _po_qty, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_DUE_DATE", po_due_date, ComConst.DB_IN);
            db.DbPsetString("@I_INVOICE_NO", _joc_cd, ComConst.DB_IN);  // joc_cdにINVOICE_NOが入っている
            db.DbPsetString("@I_LOT_NO", _joc_item_no, ComConst.DB_IN); // joc_item_noにLOT_NOが入っている

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_PUR_MANRCV_UPDATE");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 購入品受入情報削除プロシジャ
        /// 使用画面：PurManRcvUpd
        /// </summary>
        /// <returns></returns>
        public int Pur_ManRcvDelete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PO_NO", _po_no, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PUR_MANRCV_DELETE");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                db.DbCommit();
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 購入品受入情報の取得
        /// <para>使用画面：PurManRcvUpd</para>
        /// </summary>
        public DataSet Get_Pur_ManRcvList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                      ");
            strSQL.Append(" PUR.PO_NO,          PUR.PO_LINE_NO,	        ");
            strSQL.Append(" PUR.ITEM_NO,        PUR.ITEM_DESC,		    ");
            strSQL.Append(" PUR.VENDOR_CD,      V.VENDOR_NAME VENDOR_DESC, PUR.PO_QTY,                         ");
            strSQL.Append(" PUR.PO_UMSR,        PUR.PO_DUE_DATE,	    PUR.PO_NOTE,                       ");
            strSQL.Append(" PUR.WHS_CD,         W.WHS_DESC,             PUR.WHS_CD,                         ");
            strSQL.Append(" S1.DATA_CHAR AS UMSR_NAME	     ");

            strSQL.Append(" FROM PUR_ORDER PUR                                                                            ");
            strSQL.Append(" LEFT JOIN VENDOR_MASTER V ON PUR.VENDOR_CD=V.VENDOR_CD                                        ");
            strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER W ON PUR.WHS_CD=W.WHS_CD                                           ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON    S1.KEY01='ITEM_UMSR'  AND      PUR.PO_UMSR = S1.KEY02    ");
            strSQL.Append(" WHERE  PUR.ORDER_STATUS >= 25                                                                 ");
            strSQL.Append(" AND PUR.ORDER_STATUS <75                                                                      ");
            strSQL.Append(" AND PUR.PEGGING_TYPE = '1'      "); // 購入品受入情報は、PEGGIN_TYPE=1

            db.DbParametersClear();

            if (_sch_start_date != 0)
            {
                strSQL.Append("   AND PUR.PO_DUE_DATE        >=@PO_DUE_DATE");
                db.DbPsetInt("@PO_DUE_DATE", _sch_start_date);
            }
            if (_sch_compl_date != 0)
            {
                strSQL.Append("   AND PUR.PO_DUE_DATE        <=@PO_DUE_DATE2");
                db.DbPsetInt("@PO_DUE_DATE2", _sch_compl_date);
            }
            if (_vendor_cd != "")
            {
                strSQL.Append("   AND PUR.VENDOR_CD        =@VENDOR_CD");
                db.DbPsetString("@VENDOR_CD", _vendor_cd);
            }
            if (_item_no != "")
            {
                strSQL.Append("   AND PUR.ITEM_NO        =@ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_po_no != "")
            {
                //strSQL.Append("   AND PUR.PO_NO        =@PO_NO");
                strSQL.Append("   AND (PUR.PO_NO = @PO_NO OR PUR.JOB_ORDER_NO = @PO_NO) "); // 2015.03.03

                db.DbPsetString("@PO_NO", _po_no);
            }

            strSQL.Append(" ORDER BY   PUR.PO_NO, PUR.PO_LINE_NO, PUR.PO_DUE_DATE");
            
            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// 購入品受入情報（明細）の取得
        /// <para>使用画面：PurManRcvUpd</para>
        /// </summary>
        public DataSet Get_Pur_ManRcvDetailList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                      ");
            strSQL.Append(" PUR.PO_NO,          PUR.PO_LINE_NO,	        ");
            strSQL.Append(" PUR.ITEM_NO,        PUR.ITEM_DESC,		    ");
            strSQL.Append(" PUR.VENDOR_CD,      V.VENDOR_NAME VENDOR_DESC, PUR.PO_QTY,                         ");
            strSQL.Append(" PUR.PO_UMSR,        PUR.PO_DUE_DATE,	    PUR.PO_NOTE,                       ");
            strSQL.Append(" PUR.WHS_CD,         W.WHS_DESC,             PUR.WHS_CD,                         ");
            strSQL.Append(" S1.DATA_CHAR AS UMSR_NAME, 'EXIST' MARK     ");

            strSQL.Append(" FROM PUR_ORDER PUR                                                                            ");
            strSQL.Append(" LEFT JOIN VENDOR_MASTER V ON PUR.VENDOR_CD=V.VENDOR_CD                                        ");
            strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER W ON PUR.WHS_CD=W.WHS_CD                                           ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON    S1.KEY01='ITEM_UMSR'  AND      PUR.PO_UMSR = S1.KEY02    ");
            strSQL.Append(" WHERE  PUR.ORDER_STATUS >= 25                                                                 ");
            strSQL.Append(" AND PUR.ORDER_STATUS <75                                                                      ");
            strSQL.Append(" AND PUR.PEGGING_TYPE = '1'      "); // 購入品受入情報は、PEGGIN_TYPE=1

            db.DbParametersClear();

            strSQL.Append("   AND PUR.PO_NO        =@PO_NO");
            db.DbPsetString("@PO_NO", _po_no);

            strSQL.Append(" ORDER BY   PUR.PO_LINE_NO");

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }
                if (db.State() == ConnectionState.Open)
                    db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
        }
    }
}
