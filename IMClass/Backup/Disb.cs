using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Runtime.Serialization;
using System.Web.Configuration;

/// <summary>
/// クラス
/// </summary>
namespace IMClass
{
    [Serializable]
    public class Disb
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Disb()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Disb(string p_user_id, int p_lang)
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

        protected int _xfer_status = 0;
        protected string _req_type = "";
        protected DateTime _req_date = DateTime.Now;
        protected string _req_pgm = "";
        protected string _req_user_id = "";
        protected int _trans_date = 0;
        protected string _slip_no = "";
        protected int _slip_line_no = 0;
        protected int _slip_date = 0;
        protected int _slip_print_flag = 0;
        protected string _slip_issue_no = "";
        protected int _slip_issue_date = 0;
        protected string _xfer_no = "";
        protected int _seq_no = 0;
        protected string _xfer_grp = "";
        protected string _order_no = "";
        protected string _parent_xfer_no = "";
        protected int _partial_delv_compl_cnt = 0;
        protected string _item_no = "";
        protected string _item_desc = "";
        protected string _item_umsr = "";
        protected string _parent_item_no = "";
        protected double _net_qty = 0;
        protected double _inst_qty = 0;
        protected double _alloc_qty = 0;
        protected double _act_qty = 0;
        protected double _rej_qty = 0;
        protected double _act_prc = 0;
        protected double _act_amt = 0;
        protected string _tax_code = "";
        protected double _std_prc = 0;
        protected double _std_amt = 0;
        protected string _sch_id = "";
        protected string _buyer_cd = "";
        protected string _from_vc_cd = "";
        protected string _from_cost_center = "";
        protected string _from_lot_no = "";
        protected int _from_inv_wip_type = 0;
        protected int _from_inv_type = 0;
        protected int _from_supply_type = 0;
        protected int _from_supplied_type = 0;
        protected string _from_mng_no = "";
        protected string _from_whs_cd = "";
        protected string _from_location = "";
        protected string _from_ws_cd = "";
        protected string _from_process_cd = "";
        protected int _from_joc_type = 0;
        protected string _from_joc_cd = "";
        protected string _from_jon = "";
        protected string _from_cur = "";
        protected string _to_vc_cd = "";
        protected string _to_cost_center = "";
        protected string _to_lot_no = "";
        protected int _to_inv_wip_type = 0;
        protected int _to_inv_type = 0;
        protected int _to_supply_type = 0;
        protected int _to_supplied_type = 0;
        protected string _to_mng_no = "";
        protected string _to_whs_cd = "";
        protected string _to_location = "";
        protected string _to_ws_cd = "";
        protected string _to_process_cd = "";
        protected int _to_joc_type = 0;
        protected string _to_joc_cd = "";
        protected string _to_jon = "";
        protected string _to_cur = "";
        protected int _xfer_sch_date = 0;
        protected int _xfer_sch_time = 0;
        protected string _xfer_text = "";
        protected string _destruction_joc = "";
        protected string _destruction_cost_center = "";
        protected string _pur_umsr = "";
        protected double _umsr_conv_patio = 0;
        protected double _recv_qty_pur_umsr = 0;
        protected double _qty_pur_umsr = 0;
        protected double _rej_qty_pur_umsr = 0;
        protected double _destruct_qty_pur_umsr = 0;
        protected double _destruct_qty = 0;
        protected string _po_no = "";
        protected int _po_line_no = 0;
        protected string _note = "";
        protected string _delv_no = "";
        protected double _cmpl_input_prc = 0;
        protected double _compl_input_amt = 0;
        protected DateTime _approve_date = DateTime.Now;
        protected string _approve_user_id = "";

        protected int _xfer_sch_date_from = 0;
        protected int _xfer_sch_date_to = 0;
        protected int _act_date = 0;
        protected int _po_due_date = 0;
        protected double _po_qty = 0;
        protected string _po_umsr = "";
        protected double _po_prc = 0;
        protected string _po_cur = "";
        protected double _po_amt = 0;
        protected string _po_note = "";
        protected string _insp_cd = "";
        protected int _lot_cntl_flag = 0;
        protected string _ws_desc = "";
        protected int _sch_start_date = 0;
        protected int _sch_compl_date = 0;
        protected double _job_order_qty = 0;
        protected double _job_order_compl_qty = 0;
        protected string _joc_cd = "";
        protected string _whs_desc = "";
        protected string _slip_note = "";
        protected string _sch_name = "";
        protected string _vendor_name = "";

        protected string _alloc = "";
        protected string _disb_no = "";
        protected int _act_disb_date = 0;
        protected int _house_type = 0;
        protected double _plan_qty = 0;
        protected double _wip_alloc_qty = 0;
        protected double _plan_disb_qty = 0;
        protected double _inv_bal = 0;
        protected double _use_qty = 0;
        protected string _whs_cd = "";
        protected bool _reissue = false;

        protected string _picking_no = "";  // IMV3
        protected int _picking_line_no = 0;  // IMV3
        protected int _picking_status = 0;  // IMV3
        protected string _mark = "";    // IMV3
        protected string _item_kind = "";    // IMV3
        protected int _actual_seq_no = 0;  // IMV3
        protected int _ignore_ht = 0;  // IMV3
        protected string _job_order_no = "";    // IMV3

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
        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        public int lang { get { return _lang; } set { _lang = value; } }
        public int xfer_status { get { return _xfer_status; } set { _xfer_status = value; } }
        public string req_type { get { return _req_type; } set { _req_type = value; } }
        public DateTime req_date { get { return _req_date; } set { _req_date = value; } }
        public string req_pgm { get { return _req_pgm; } set { _req_pgm = value; } }
        public string req_user_id { get { return _req_user_id; } set { _req_user_id = value; } }
        public int trans_date { get { return _trans_date; } set { _trans_date = value; } }
        public string slip_no { get { return _slip_no; } set { _slip_no = value; } }
        public int slip_line_no { get { return _slip_line_no; } set { _slip_line_no = value; } }
        public int slip_date { get { return _slip_date; } set { _slip_date = value; } }
        public int slip_print_flag { get { return _slip_print_flag; } set { _slip_print_flag = value; } }
        public string slip_issue_no { get { return _slip_issue_no; } set { _slip_issue_no = value; } }
        public int slip_issue_date { get { return _slip_issue_date; } set { _slip_issue_date = value; } }
        public string xfer_no { get { return _xfer_no; } set { _xfer_no = value; } }
        public int seq_no { get { return _seq_no; } set { _seq_no = value; } }
        public string xfer_grp { get { return _xfer_grp; } set { _xfer_grp = value; } }
        public string order_no { get { return _order_no; } set { _order_no = value; } }
        public string parent_xfer_no { get { return _parent_xfer_no; } set { _parent_xfer_no = value; } }
        public int partial_delv_compl_cnt { get { return _partial_delv_compl_cnt; } set { _partial_delv_compl_cnt = value; } }
        public string item_no { get { return _item_no; } set { _item_no = value; } }
        public string item_desc { get { return _item_desc; } set { _item_desc = value; } }
        public string item_umsr { get { return _item_umsr; } set { _item_umsr = value; } }
        public string parent_item_no { get { return _parent_item_no; } set { _parent_item_no = value; } }
        public double net_qty { get { return _net_qty; } set { _net_qty = value; } }
        public double inst_qty { get { return _inst_qty; } set { _inst_qty = value; } }
        public double alloc_qty { get { return _alloc_qty; } set { _alloc_qty = value; } }
        public double act_qty { get { return _act_qty; } set { _act_qty = value; } }
        public double rej_qty { get { return _rej_qty; } set { _rej_qty = value; } }
        public double act_prc { get { return _act_prc; } set { _act_prc = value; } }
        public double act_amt { get { return _act_amt; } set { _act_amt = value; } }
        public string tax_code { get { return _tax_code; } set { _tax_code = value; } }
        public double std_prc { get { return _std_prc; } set { _std_prc = value; } }
        public double std_amt { get { return _std_amt; } set { _std_amt = value; } }
        public string sch_id { get { return _sch_id; } set { _sch_id = value; } }
        public string buyer_cd { get { return _buyer_cd; } set { _buyer_cd = value; } }
        public string from_vc_cd { get { return _from_vc_cd; } set { _from_vc_cd = value; } }
        public string from_cost_center { get { return _from_cost_center; } set { _from_cost_center = value; } }
        public string from_lot_no { get { return _from_lot_no; } set { _from_lot_no = value; } }
        public int from_inv_wip_type { get { return _from_inv_wip_type; } set { _from_inv_wip_type = value; } }
        public int from_inv_type { get { return _from_inv_type; } set { _from_inv_type = value; } }
        public int from_supply_type { get { return _from_supply_type; } set { _from_supply_type = value; } }
        public int from_supplied_type { get { return _from_supplied_type; } set { _from_supplied_type = value; } }
        public string from_mng_no { get { return _from_mng_no; } set { _from_mng_no = value; } }
        public string from_whs_cd { get { return _from_whs_cd; } set { _from_whs_cd = value; } }
        public string from_location { get { return _from_location; } set { _from_location = value; } }
        public string from_ws_cd { get { return _from_ws_cd; } set { _from_ws_cd = value; } }
        public string from_process_cd { get { return _from_process_cd; } set { _from_process_cd = value; } }
        public int from_joc_type { get { return _from_joc_type; } set { _from_joc_type = value; } }
        public string from_joc_cd { get { return _from_joc_cd; } set { _from_joc_cd = value; } }
        public string from_jon { get { return _from_jon; } set { _from_jon = value; } }
        public string from_cur { get { return _from_cur; } set { _from_cur = value; } }
        public string to_vc_cd { get { return _to_vc_cd; } set { _to_vc_cd = value; } }
        public string to_cost_center { get { return _to_cost_center; } set { _to_cost_center = value; } }
        public string to_lot_no { get { return _to_lot_no; } set { _to_lot_no = value; } }
        public int to_inv_wip_type { get { return _to_inv_wip_type; } set { _to_inv_wip_type = value; } }
        public int to_inv_type { get { return _to_inv_type; } set { _to_inv_type = value; } }
        public int to_supply_type { get { return _to_supply_type; } set { _to_supply_type = value; } }
        public int to_supplied_type { get { return _to_supplied_type; } set { _to_supplied_type = value; } }
        public string to_mng_no { get { return _to_mng_no; } set { _to_mng_no = value; } }
        public string to_whs_cd { get { return _to_whs_cd; } set { _to_whs_cd = value; } }
        public string to_location { get { return _to_location; } set { _to_location = value; } }
        public string to_ws_cd { get { return _to_ws_cd; } set { _to_ws_cd = value; } }
        public string to_process_cd { get { return _to_process_cd; } set { _to_process_cd = value; } }
        public int to_joc_type { get { return _to_joc_type; } set { _to_joc_type = value; } }
        public string to_joc_cd { get { return _to_joc_cd; } set { _to_joc_cd = value; } }
        public string to_jon { get { return _to_jon; } set { _to_jon = value; } }
        public string to_cur { get { return _to_cur; } set { _to_cur = value; } }
        public int xfer_sch_date { get { return _xfer_sch_date; } set { _xfer_sch_date = value; } }
        public int xfer_sch_time { get { return _xfer_sch_time; } set { _xfer_sch_time = value; } }
        public string xfer_text { get { return _xfer_text; } set { _xfer_text = value; } }
        public string destruction_joc { get { return _destruction_joc; } set { _destruction_joc = value; } }
        public string destruction_cost_center { get { return _destruction_cost_center; } set { _destruction_cost_center = value; } }
        public string pur_umsr { get { return _pur_umsr; } set { _pur_umsr = value; } }
        public double umsr_conv_patio { get { return _umsr_conv_patio; } set { _umsr_conv_patio = value; } }
        public double recv_qty_pur_umsr { get { return _recv_qty_pur_umsr; } set { _recv_qty_pur_umsr = value; } }
        public double qty_pur_umsr { get { return _qty_pur_umsr; } set { _qty_pur_umsr = value; } }
        public double rej_qty_pur_umsr { get { return _rej_qty_pur_umsr; } set { _rej_qty_pur_umsr = value; } }
        public double destruct_qty_pur_umsr { get { return _destruct_qty_pur_umsr; } set { _destruct_qty_pur_umsr = value; } }
        public double destruct_qty { get { return _destruct_qty; } set { _destruct_qty = value; } }
        public string po_no { get { return _po_no; } set { _po_no = value; } }
        public int po_line_no { get { return _po_line_no; } set { _po_line_no = value; } }
        public string note { get { return _note; } set { _note = value; } }
        public string delv_no { get { return _delv_no; } set { _delv_no = value; } }
        public double cmpl_input_prc { get { return _cmpl_input_prc; } set { _cmpl_input_prc = value; } }
        public double compl_input_amt { get { return _compl_input_amt; } set { _compl_input_amt = value; } }
        public DateTime approve_date { get { return _approve_date; } set { _approve_date = value; } }
        public string approve_user_id { get { return _approve_user_id; } set { _approve_user_id = value; } }

        public int xfer_sch_date_from { get { return _xfer_sch_date_from; } set { _xfer_sch_date_from = value; } }
        public int xfer_sch_date_to { get { return _xfer_sch_date_to; } set { _xfer_sch_date_to = value; } }
        public int act_date { get { return _act_date; } set { _act_date = value; } }
        public int po_due_date { get { return _po_due_date; } set { _po_due_date = value; } }
        public double po_qty { get { return _po_qty; } set { _po_qty = value; } }
        public string po_umsr { get { return _po_umsr; } set { _po_umsr = value; } }
        public double po_prc { get { return _po_prc; } set { _po_prc = value; } }
        public string po_cur { get { return _po_cur; } set { _po_cur = value; } }
        public double po_amt { get { return _po_amt; } set { _po_amt = value; } }
        public string po_note { get { return _po_note; } set { _po_note = value; } }
        public string insp_cd { get { return _insp_cd; } set { _insp_cd = value; } }
        public int lot_cntl_flag { get { return _lot_cntl_flag; } set { _lot_cntl_flag = value; } }
        public string ws_desc { get { return _ws_desc; } set { _ws_desc = value; } }
        public int sch_start_date { get { return _sch_start_date; } set { _sch_start_date = value; } }
        public int sch_compl_date { get { return _sch_compl_date; } set { _sch_compl_date = value; } }
        public double job_order_qty { get { return _job_order_qty; } set { _job_order_qty = value; } }
        public double job_order_compl_qty { get { return _job_order_compl_qty; } set { _job_order_compl_qty = value; } }
        public string joc_cd { get { return _joc_cd; } set { _joc_cd = value; } }
        public string whs_desc { get { return _whs_desc; } set { _whs_desc = value; } }
        public string slip_note { get { return _slip_note; } set { _slip_note = value; } }
        public string sch_name { get { return _sch_name; } set { _sch_name = value; } }
        public string vendor_name { get { return _vendor_name; } set { _vendor_name = value; } }

        public string alloc { get { return _alloc; } set { _alloc = value; } }
        public string disb_no { get { return _disb_no; } set { _disb_no = value; } }
        public int act_disb_date { get { return _act_disb_date; } set { _act_disb_date = value; } }
        public int house_type { get { return _house_type; } set { _house_type = value; } }
        public double plan_qty { get { return _plan_qty; } set { _plan_qty = value; } }
        public double wip_alloc_qty { get { return _wip_alloc_qty; } set { _wip_alloc_qty = value; } }
        public double plan_disb_qty { get { return _plan_disb_qty; } set { _plan_disb_qty = value; } }
        public double inv_bal { get { return _inv_bal; } set { _inv_bal = value; } }
        public double use_qty { get { return _use_qty; } set { _use_qty = value; } }
        public string whs_cd { get { return _whs_cd; } set { _whs_cd = value; } }
        public bool reissue { get { return _reissue; } set { _reissue = value; } }

        public string picking_no { get { return _picking_no; } set { _picking_no = value; } }   // IMV3
        public int picking_line_no { get { return _picking_line_no; } set { _picking_line_no = value; } }   // IMV3
        public int picking_status { get { return _picking_status; } set { _picking_status = value; } }   // IMV3
        public string mark { get { return _mark; } set { _mark = value; } } // IMV3
        public string item_kind { get { return _item_kind; } set { _item_kind = value; } } // IMV3
        public int actual_seq_no { get { return _actual_seq_no; } set { _actual_seq_no = value; } }   // IMV3
        public int ignore_ht { get { return _ignore_ht; } set { _ignore_ht = value; } }   // IMV3
        public string job_order_no { get { return _job_order_no; } set { _job_order_no = value; } } // IMV3

        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }
        #endregion

        /// <summary>
        /// 部品出庫指示
        /// 
        /// 使用画面：InvDisbInst
        /// </summary>
        public DataSet GetDisbInstList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql    
            strSQL.Append(" SELECT                                                                                      ");
            strSQL.Append(" T.ITEM_NO,          T.ITEM_DESC,        T.TO_WS_CD,     T.TO_PROCESS_CD,        T.NET_QTY,  ");
            strSQL.Append(" S.DATA_CHAR ITEM_UMSR,T.ALLOC_QTY,      T.NET_QTY - T.ALLOC_QTY SHORTAGE_QTY,               ");
            strSQL.Append(" ALLOC = CASE WHEN T.NET_QTY - T.ALLOC_QTY = 0 THEN 'OK' ELSE 'NG' END,                      ");
            strSQL.Append(" T.XFER_NO,          T.FROM_WHS_CD,      WHS.WHS_DESC,   T.TO_JOC_CD,                        ");
            strSQL.Append(" W.WS_DESC,          P.PROCESS_DESC                                                          ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM TRANSFER_TRANS T,SYSTEM_PARAMETER S,WORKSHOP_MASTER W, ");
                strSQL.Append(" PROCESS_MASTER P,WAREHOUSE_MASTER WHS ");
                strSQL.Append(" WHERE ");
                strSQL.Append(" T.WHS_CD = WHS.WHS_CD ");
                strSQL.Append(" AND T.REQ_TYPE = '21' AND T.XFER_STATUS < 10 ");
                strSQL.Append(" AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");
                //strSQL.Append(" AND T.TO_WS_CD = W.WS_CD AND T.TO_PROCESS_CD = P.PROCESS_CD ");
                //strSQL.Append(" T.FROM_WHS_CD = WHS.WHS_CD ");

                if (sch_id != "")
                {
                    strSQL.Append(" AND T.SCH_ID = :SCH_ID ");
                    db.DbPsetString("SCH_ID", _sch_id);
                }
                if (from_whs_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WHS_CD = :FROM_WHS_CD ");
                    db.DbPsetString("FROM_WHS_CD", _from_whs_cd);
                }
                if (to_ws_cd != "")
                {
                    strSQL.Append(" AND T.TO_WS_CD = :TO_WS_CD ");
                    db.DbPsetString("TO_WS_CD", _to_ws_cd);
                }
                if (to_joc_cd != "")
                {
                    strSQL.Append(" AND T.TO_JOC_CD = :TO_JOC_CD ");
                    db.DbPsetString("TO_JOC_CD", _to_joc_cd);
                }
                if (xfer_sch_date_to != 0)
                {
                    strSQL.Append(" AND T.XFER_SCH_DATE <= :XFER_SCH_DATE_TO ");
                    db.DbPsetInt("XFER_SCH_DATE_TO", _xfer_sch_date_to);
                }
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR   ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON T.TO_WS_CD = W.WS_CD                               ");
                strSQL.Append(" LEFT OUTER JOIN PROCESSS_MASTER P T.TO_PROCESS_CD = P.PROCESS_CD                        ");
                strSQL.Append(" INNER JOIN WAREHOUSE_MASTER WHS ON T.FROM_WHS_CD = WHS.WHS_CD                           ");
                strSQL.Append(" WHERE                                                                                   ");
                strSQL.Append(" T.REQ_TYPE = '21' AND T.XFER_STATUS < 10                                                ");

                if (sch_id != "")
                {
                    strSQL.Append(" AND T.SCH_ID = @SCH_ID ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (from_whs_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WHS_CD = @FROM_WHS_CD ");
                    db.DbPsetString("@FROM_WHS_CD", _from_whs_cd);
                }
                if (to_ws_cd != "")
                {
                    strSQL.Append(" AND T.TO_WS_CD = @TO_WS_CD ");
                    db.DbPsetString("@TO_WS_CD", _to_ws_cd);
                }
                if (to_joc_cd != "")
                {
                    strSQL.Append(" AND T.TO_JOC_CD = @TO_JOC_CD ");
                    db.DbPsetString("@TO_JOC_CD", _to_joc_cd);
                }
                if (xfer_sch_date_to != 0)
                {
                    strSQL.Append(" AND T.XFER_SCH_DATE <= @XFER_SCH_DATE_TO ");
                    db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
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
        /// 出庫指示
        /// 
        /// 使用画面：InvDisbInst
        /// </summary>
        public int DisbInst()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USERID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_DISB_INST");
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
        /// 在庫引当

        /// 
        /// 使用画面：InvDisbInst
        /// </summary>
        public int DisbAllocByXferNo()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USERID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_DISB_ALLOC_BY_XFER_NO");
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
        /// 引当解除
        /// 
        /// 使用画面：InvDisbInst
        /// </summary>
        public int DisbUnAllocByXferNo()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USERID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_DISB_UNALLOC_BY_XFER_NO");
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
        /// 出庫指示表一覧表データを検索
        /// 
        /// 使用画面：InvDisbList
        /// </summary>
        public DataSet GetDisbListData()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql    
            strSQL.Append(" SELECT                                                                                      ");
            strSQL.Append(" T.XFER_SCH_DATE,    T.SLIP_NO,              T.TO_WS_CD,     WS.WS_DESC,                     ");
            //strSQL.Append(" T.TO_WHS_CD,        W.WHS_DESC,             D.SEQ_NO,       T.ITEM_NO,      T.ITEM_DESC,    ");
            strSQL.Append(" T.FROM_WHS_CD,      W.WHS_DESC,             D.SEQ_NO,       T.ITEM_NO,      T.ITEM_DESC,    ");//UPD 20090623 UBIQ-LIU
            strSQL.Append(" D.ALLOC_QTY,        S.DATA_CHAR ITEM_UMSR,  D.LOCATION,     D.LOT_NO,       D.JOC_CD,       ");
            strSQL.Append(" T.TO_VC_CD,         V.VENDOR_NAME,          T.REQ_TYPE,                                     ");//ADD BY UBIQ-LIU 2010/6/13
            strSQL.Append(" T.TO_PROCESS_CD,    P.PROCESS_DESC,         T.SLIP_LINE_NO                                  ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T,DISB_ALLOC D,WORKSHOP_MASTER WS,  ");
                strSQL.Append(" WAREHOUSE_MASTER W,PROCESS_MASTER P                     ");
                strSQL.Append(" WHERE                                                   ");
                strSQL.Append(" T.XFER_NO=D.XFER_NO AND                                 ");
                strSQL.Append(" T.TO_WS_CD=WS.WS_CD(+) AND                              ");
                strSQL.Append(" T.FROM_WHS_CD=W.WHS_CD(+) AND                           ");
                strSQL.Append(" T.TO_PROCESS_CD=P.PROCESS_CD(+) AND                     ");
                strSQL.Append(" T.REQ_TYPE IN ('21','24') AND                           ");
                strSQL.Append(" T.XFER_STATUS=5 AND                                     ");
                strSQL.Append(" D.ALLOC_STATUS=0                                        ");

                if (from_whs_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WHS_CD = :FROM_WHS_CD ");
                    db.DbPsetString("FROM_WHS_CD", _from_whs_cd);
                }
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T                                                               ");
                strSQL.Append(" INNER JOIN DISB_ALLOC D ON T.XFER_NO=D.XFER_NO                                      ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON T.TO_WS_CD=WS.WS_CD                           ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON T.FROM_WHS_CD=W.WHS_CD                        ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON T.TO_VC_CD=V.VENDOR_CD                           ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER P ON T.TO_WS_CD=P.WS_CD                              ");
                strSQL.Append("                                 AND T.TO_PROCESS_CD=P.PROCESS_CD                    ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01='ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");
                strSQL.Append(" WHERE                                                                               ");
                strSQL.Append(" T.REQ_TYPE IN ('21','24')                                                           ");
                if (reissue == false )
                {
                    strSQL.Append(" AND T.XFER_STATUS=5                 ");
                }
                else
                {
                    //UPD 2009.09.01
                    //strSQL.Append(" AND T.XFER_STATUS=10                ");
                    strSQL.Append(" AND T.SLIP_NO = @SLIP_NO ");
                    db.DbPsetString("@SLIP_NO", _slip_no);
                }
                strSQL.Append(" AND D.ALLOC_STATUS=0                ");

                if (from_whs_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WHS_CD = @FROM_WHS_CD ");
                    db.DbPsetString("@FROM_WHS_CD", _from_whs_cd);
                }

            }
            strSQL.Append(" ORDER BY                                                                                    ");
            strSQL.Append(" T.XFER_SCH_DATE,T.FROM_WHS_CD,T.TO_WS_CD,T.SLIP_NO,D.LOCATION,T.ITEM_NO,D.LOT_NO,D.JOC_CD   ");

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
        /// 出庫指示票印刷
        /// 
        /// 使用画面：InvDisbList
        /// </summary>
        /// 2009.01.22 Upd By Chen
        public int DisbPrint(ComDB db)
        {
            //ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_SLIP_NO", _slip_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USERID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_DISB_PRINT");
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
        /// 欠品リスト対象データを検索
        /// 
        /// 使用画面：InvShortageList
        /// </summary>
        public DataSet GetDisbShortageList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql    
            strSQL.Append(" SELECT                                                                              ");
            strSQL.Append(" T.FROM_WHS_CD,      W.WHS_DESC,     T.TO_WS_CD,      T.ITEM_NO,      T.ITEM_DESC,   ");
            strSQL.Append(" SUM(T.NET_QTY) NET_QTY,             S.DATA_CHAR ITEM_UMSR,                          ");
            strSQL.Append(" SUM(T.NET_QTY - T.ALLOC_QTY) SHORTAGE_QTY                                           ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T,WAREHOUSE_MASTER W,SYSTEM_PARAMETER S ");
                strSQL.Append(" WHERE                                                       ");
                strSQL.Append(" T.FROM_WHS_CD=W.WHS_CD(+)                                   ");
                strSQL.Append(" AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR         ");
                strSQL.Append(" AND T.REQ_TYPE='21'	                                        ");
                strSQL.Append(" AND T.XFER_STATUS>=5 AND T.XFER_STATUS<= 10                 ");
                strSQL.Append(" AND T.NET_QTY - T.ALLOC_QTY>0                               ");

                if (from_whs_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WHS_CD = :FROM_WHS_CD ");
                    db.DbPsetString("FROM_WHS_CD", _from_whs_cd);
                }
                strSQL.Append(" AND T.XFER_SCH_DATE <= :XFER_SCH_DATE ");
                db.DbPsetInt("XFER_SCH_DATE", _xfer_sch_date);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T                                                               ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON T.FROM_WHS_CD=W.WHS_CD                        ");
                strSQL.Append(" INNER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR    ");
                strSQL.Append(" WHERE                                                                               ");
                strSQL.Append(" T.REQ_TYPE='21'                                                                     ");
                strSQL.Append(" AND T.XFER_STATUS>=5 AND T.XFER_STATUS<=10                                          ");
                strSQL.Append(" AND T.NET_QTY - T.ALLOC_QTY>0                                                       ");

                if (from_whs_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WHS_CD = @FROM_WHS_CD ");
                    db.DbPsetString("@FROM_WHS_CD", _from_whs_cd);
                }
                strSQL.Append(" AND T.XFER_SCH_DATE <= @XFER_SCH_DATE ");
                db.DbPsetInt("@XFER_SCH_DATE", _xfer_sch_date);
            }

            strSQL.Append(" GROUP BY                                                                        ");
            strSQL.Append(" T.FROM_WHS_CD,  W.WHS_DESC, T.TO_WS_CD, T.ITEM_NO,  T.ITEM_DESC,    S.DATA_CHAR ");
            strSQL.Append(" ORDER BY                                                                        ");
            strSQL.Append(" T.FROM_WHS_CD,T.TO_WS_CD,T.ITEM_NO                                              ");

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
        /// 部品出庫実績入力

        /// 
        /// 使用画面：InvDisbAct
        /// </summary>
        public DataSet GetDisbActList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql    
            strSQL.Append(" SELECT                                                                          ");
            strSQL.Append(" T.FROM_WHS_CD,          W.WHS_DESC,         T.TO_WS_CD,         WS.WS_DESC,     ");
            strSQL.Append(" T.SLIP_LINE_NO,         T.ITEM_NO,          T.ITEM_DESC,        D.ALLOC_QTY,    ");
            strSQL.Append(" S.DATA_CHAR ITEM_UMSR,  D.ALLOC_QTY,        D.LOCATION,         D.LOT_NO,       ");
            strSQL.Append(" D.JOC_CD,               T.XFER_NO,          T.XFER_STATUS,      D.SEQ_NO        ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM DISB_ALLOC D,TRANSFER_TRANS T,WAREHOUSE_MASTER W, ");
                strSQL.Append(" WORKSHOP_MASTER WS,PROCESS_MASTER P,SYSTEM_PARAMETER S ");
                strSQL.Append(" WHERE ");
                strSQL.Append(" T.XFER_NO = D.XFER_NO ");
                strSQL.Append(" AND T.FROM_WHS_CD = W.WHS_CD ");
                strSQL.Append(" AND T.TO_WS_CD = WS.WS_CD  ");
                strSQL.Append(" AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");
                strSQL.Append(" AND T.TO_PROCESS_CD = P.PROCESS_CD(+)  ");
                strSQL.Append(" AND T.REQ_TYPE in ('21','24') ");
                //strSQL.Append(" AND T.XFER_STATUS =10           ");
                strSQL.Append(" AND (T.XFER_STATUS >=5 AND T.XFER_STATUS <=10)  ");     // 2011.02.22
                strSQL.Append(" AND D.ALLOC_STATUS = 0 ");

                strSQL.Append(" AND T.SLIP_NO = :SLIP_NO ");
                db.DbPsetString("SLIP_NO", _slip_no);

            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T                                                                   ");
                strSQL.Append(" INNER JOIN DISB_ALLOC D ON T.XFER_NO = D.XFER_NO                                        ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON T.FROM_WHS_CD = W.WHS_CD                          ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON T.TO_WS_CD = WS.WS_CD                             ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR   ");
                //strSQL.Append(" LEFT  JOIN PROCESS_MASTER P ON T.TO_PROCESS_CD = P.PROCESS_CD                         ");
                strSQL.Append(" WHERE                           ");
                strSQL.Append(" T.REQ_TYPE in ('21','24')       ");
                //strSQL.Append(" AND T.XFER_STATUS =10           ");
                strSQL.Append(" AND (T.XFER_STATUS >=5 AND T.XFER_STATUS <=10)  ");     // 2011.02.22
                strSQL.Append(" AND D.ALLOC_STATUS = 0          ");

                strSQL.Append(" AND T.SLIP_NO = @SLIP_NO ");
                db.DbPsetString("@SLIP_NO", _slip_no);
            }
            strSQL.Append(" ORDER BY                                            ");
            strSQL.Append(" T.SLIP_NO,D.LOCATION,T.ITEM_NO,D.LOT_NO,D.JOC_CD    ");

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
        /// 部品出庫実績入力

        /// 
        /// 使用画面：InvDisbAct
        /// </summary>
        public int DisbAct()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_IN);
            db.DbPsetInt("@I_SEQ_NO", _seq_no, ComConst.DB_IN);
            db.DbPsetInt("@I_ACT_DISB_DATE", _act_disb_date, ComConst.DB_IN);
            db.DbPsetDouble("@I_ACT_QTY", _act_qty, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USERID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_DISB_ACT");
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
        /// 部品出庫実績入力

        /// 
        /// 使用画面：InvDisbAct
        /// </summary>
        public int GetDemandQtyData()
        {
            ComLibrary com = new ComLibrary();
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append(" SELECT                                                                  ");
            strSQL.Append(" SUM(D.PLAN_QTY) PLAN_QTY,S.DATA_CHAR ITEM_UMSR,                         ");
            strSQL.Append(" SUM(D.WIP_ALLOC_QTY) WIP_ALLOC_QTY,SUM(D.PLAN_DISB_QTY) PLAN_DISB_QTY   ");
           
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM DEMAND D                                               ");
                strSQL.Append(" INNER JOIN DEMAND_ALLOC DA ON D.DEMAND_NO = DA.DEMAND_NO    ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON                       ");
                strSQL.Append(" S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = D.ITEM_UMSR             ");
                strSQL.Append(" WHERE                                                       ");
                strSQL.Append(" DA.XFER_NO = :XFER_NO AND DA.SEQ_NO = :SEQ_NO               ");
                strSQL.Append(" GROUP BY S.DATA_CHAR                                        ");

                db.DbParametersClear();
                db.DbPsetString("XFER_NO", _xfer_no);
                db.DbPsetInt("SEQ_NO", _seq_no);
            }
            else
            {
                strSQL.Append(" FROM DEMAND D                                               ");
                strSQL.Append(" INNER JOIN DEMAND_ALLOC DA ON D.DEMAND_NO = DA.DEMAND_NO    ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON                       ");
                strSQL.Append(" S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = D.ITEM_UMSR             ");
                strSQL.Append(" WHERE                                                       ");
                strSQL.Append(" DA.XFER_NO = @XFER_NO AND DA.SEQ_NO = @SEQ_NO               ");
                strSQL.Append(" GROUP BY S.DATA_CHAR                                        ");

                db.DbParametersClear();
                db.DbPsetString("@XFER_NO", _xfer_no);
                db.DbPsetInt("@SEQ_NO", _seq_no);
            }
            strSQL.Append(" UNION SELECT                                                            ");
            strSQL.Append(" SUM(P.PLAN_QTY) PLAN_QTY,S.DATA_CHAR ITEM_UMSR,                         ");
            strSQL.Append(" SUM(P.WIP_ALLOC_QTY) WIP_ALLOC_QTY,SUM(P.PLAN_DISB_QTY) PLAN_DISB_QTY   ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PLANNED_DEMAND P                                       ");
                strSQL.Append(" INNER JOIN DEMAND_ALLOC DA ON P.DEMAND_NO = DA.DEMAND_NO    ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S                          ");
                strSQL.Append(" ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = P.ITEM_UMSR          ");
                strSQL.Append(" WHERE                                                       ");
                strSQL.Append(" DA.XFER_NO = :XFER_NO AND DA.SEQ_NO = :SEQ_NO               ");
                strSQL.Append(" GROUP BY S.DATA_CHAR                                        ");
            }
            else
            {
                strSQL.Append(" FROM PLANNED_DEMAND P                                       ");
                strSQL.Append(" INNER JOIN DEMAND_ALLOC DA ON P.DEMAND_NO = DA.DEMAND_NO    ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S                          ");
                strSQL.Append(" ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = P.ITEM_UMSR          ");
                strSQL.Append(" WHERE                                                       ");
                strSQL.Append(" DA.XFER_NO = @XFER_NO AND DA.SEQ_NO = @SEQ_NO               ");
                strSQL.Append(" GROUP BY S.DATA_CHAR                                        ");
            
            }
            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _plan_qty = com.StringToDouble(db.Row("PLAN_QTY"));
                _item_umsr = db.Row("ITEM_UMSR");
                _wip_alloc_qty = com.StringToDouble(db.Row("WIP_ALLOC_QTY"));
                _plan_disb_qty = com.StringToDouble(db.Row("PLAN_DISB_QTY"));               
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }
        /// <summary>
        /// 部品出庫実績入力

        /// 
        /// 使用画面：InvDisbAct
        /// </summary>
        public int GetInvDetailData()
        {
            ComLibrary com = new ComLibrary();
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append(" SELECT                                                          ");
            strSQL.Append(" SUM(INV.INV_BAL) INV_BAL,SUM(INV.INV_BAL-INV.ALLOC_QTY) USE_QTY ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM DEMAND D                                               ");
                strSQL.Append(" INNER JOIN DEMAND_ALLOC DA ON D.DEMAND_NO = DA.DEMAND_NO    ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON                       ");
                strSQL.Append(" S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = D.ITEM_UMSR             ");
                strSQL.Append(" WHERE                                                       ");
                strSQL.Append(" DA.XFER_NO = :XFER_NO AND DA.SEQ_NO = :SEQ_NO               ");
                strSQL.Append(" GROUP BY S.DATA_CHAR                                        ");

                db.DbParametersClear();
                db.DbPsetString("XFER_NO", _xfer_no);
                db.DbPsetInt("SEQ_NO", _seq_no);
            }
            else
            {
                strSQL.Append(" FROM INVENTORY_DETAIL INV                                           ");
                strSQL.Append(" INNER JOIN ITEM_MASTER I ON INV.ITEM_NO=I.ITEM_NO                   ");
                strSQL.Append(" WHERE                                                               ");
                strSQL.Append(" INV.INV_YM=0 AND INV.ITEM_NO=@ITEM_NO AND INV.INV_WIP_TYPE=0        ");
                strSQL.Append(" AND INV.INV_TYPE=0 AND INV.WHS_CD=@WHS_CD                           ");
                strSQL.Append(" AND INV.JOC_CD=CASE WHEN I.PO_TYPE = 4 THEN @JOC_CD ELSE '*' END	");

                db.DbParametersClear();
                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WHS_CD", _whs_cd);
                db.DbPsetString("@JOC_CD", _joc_cd);
            }
           
            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _inv_bal = com.StringToDouble(db.Row("INV_BAL"));
                _use_qty = com.StringToDouble(db.Row("USE_QTY"));
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }        
        /// <summary>
        /// 所要

        /// 
        /// 使用画面：InvDisbAct
        /// </summary>
        public DataSet GetDisbParentList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql    
            strSQL.Append(" SELECT                                                                                  ");
            strSQL.Append(" J.ITEM_NO,          J.ITEM_DESC,        J.SCH_START_DATE,       J.SCH_COMPL_DATE,       ");
            strSQL.Append(" J.JOB_ORDER_NO,     J.JOB_ORDER_QTY,    D.PLAN_QTY,             D.DEFECT_PCT,           ");
            strSQL.Append(" D.JOC_CD                                                                                ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER J,DEMAND D ");
                strSQL.Append(" WHERE ");
                strSQL.Append(" D.ORDER_NO = J.ORDER_NO ");
                strSQL.Append(" AND (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1)) ");
                strSQL.Append(" AND D.ITEM_TYPE         <> '99' 			                              ");

                strSQL.Append(" AND D.DISB_NO = :DISB_NO ");
                db.DbPsetString("DISB_NO", _disb_no);

            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM DEMAND D                                                               ");
                strSQL.Append(" INNER JOIN JOB_ORDER J ON D.ORDER_NO = J.ORDER_NO                           ");
                strSQL.Append(" INNER JOIN DEMAND_ALLOC DA ON D.DEMAND_NO = DA.DEMAND_NO                    ");
                strSQL.Append(" WHERE                                                                       ");
                strSQL.Append(" (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))       ");
                strSQL.Append(" AND D.ITEM_TYPE         <> '99' 				                            ");
                strSQL.Append(" AND DA.XFER_NO = @XFER_NO                                                   ");
                strSQL.Append(" AND DA.SEQ_NO = @SEQ_NO                                                     ");
            }
            strSQL.Append(" UNION SELECT                                                                            ");
            strSQL.Append(" PUR.ITEM_NO,        PUR.ITEM_DESC,      PUR.SCH_START_DATE,     PUR.SCH_COMPL_DATE,     ");
            strSQL.Append(" PUR.JOB_ORDER_NO,   PUR.JOB_ORDER_QTY,  D.PLAN_QTY,             D.DEFECT_PCT,           ");
            strSQL.Append(" D.JOC_CD                                                                                ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM JOB_ORDER J,DEMAND D ");
                strSQL.Append(" WHERE ");
                strSQL.Append(" D.ORDER_NO = J.ORDER_NO ");
                strSQL.Append(" AND (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1)) ");
                strSQL.Append(" AND D.ITEM_TYPE         <> '99' 			                            ");
                
            }
            else
            {
                strSQL.Append(" FROM DEMAND D                                                               ");
                strSQL.Append(" INNER JOIN PUR_ORDER PUR ON D.ORDER_NO = PUR.ORDER_NO                       ");
                strSQL.Append(" INNER JOIN DEMAND_ALLOC DA ON D.DEMAND_NO = DA.DEMAND_NO                    ");
                strSQL.Append(" WHERE                                                                       ");
                strSQL.Append(" (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))       ");
                strSQL.Append(" AND D.ITEM_TYPE         <> '99' 				                            ");
                strSQL.Append(" AND DA.XFER_NO = @XFER_NO                                                   ");
                strSQL.Append(" AND DA.SEQ_NO = @SEQ_NO                                                     ");
            }
            strSQL.Append(" UNION SELECT                                                                                ");
            strSQL.Append(" PO.ITEM_NO,         PO.ITEM_DESC,               PO.SCH_START_DATE,      PO.SCH_COMPL_DATE,  ");
            strSQL.Append(" '' AS JOB_ORDER_NO, PO.ORDER_QTY JOB_ORDER_QTY, P.PLAN_QTY,             P.DEFECT_PCT,       ");
            strSQL.Append(" P.JOC_CD                                                                                    ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PLANNED_ORDER PO,PLANNED_DEMAND P ");
                strSQL.Append(" WHERE ");
                strSQL.Append(" PO.ORDER_NO = P.ORDER_NO ");
                strSQL.Append(" AND (P.SUB_GRP_CD = '' OR (P.SUB_GRP_CD <> '' AND P.SUB_ACTION_FLAG = 1)) ");
                strSQL.Append(" AND P.ITEM_TYPE         <> '99' 				                          ");
            }
            else
            {
                strSQL.Append(" FROM PLANNED_DEMAND P                                                       ");
                strSQL.Append(" INNER JOIN PLANNED_ORDER PO ON P.ORDER_NO = PO.ORDER_NO                     ");
                strSQL.Append(" INNER JOIN DEMAND_ALLOC DA ON P.DEMAND_NO = DA.DEMAND_NO                    ");
                strSQL.Append(" WHERE                                                                       ");
                strSQL.Append(" DA.XFER_NO = @XFER_NO                                                       ");
                strSQL.Append(" AND DA.SEQ_NO = @SEQ_NO                                                     ");

                db.DbPsetString("@XFER_NO", _xfer_no);
                db.DbPsetInt("@SEQ_NO", _seq_no);
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
        /// 出庫実績取消対象データを検索
        /// 
        /// 使用画面：InvDisbActCancel
        /// </summary>
        public DataSet GetDisbActCancelList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql    
            strSQL.Append(" SELECT                                                                                          ");
            strSQL.Append(" T.FROM_WHS_CD,      W.WHS_DESC,     T.TO_WS_CD,         WS.WS_DESC,     T.XFER_SCH_DATE,        ");
            strSQL.Append(" T.SLIP_LINE_NO,     T.ITEM_NO,      T.ITEM_DESC,        D.ALLOC_QTY,    S.DATA_CHAR ITEM_UMSR,  ");
            strSQL.Append(" D.ACT_QTY,          D.LOCATION,     D.LOT_NO,           D.JOC_CD,       T.TO_PROCESS_CD,        ");
            strSQL.Append(" T.XFER_NO,          T.XFER_STATUS,  D.SEQ_NO,           RCV_DISB_TRANS.TRANS_DATE               ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM DISB_ALLOC D,TRANSFER_TRANS T,WAREHOUSE_MASTER W,                  ");
                strSQL.Append(" WORKSHOP_MASTER WS,SYSTEM_PARAMETER S                                   ");
                strSQL.Append("`,(SELECT XFER_NO, PARTIAL_DELV_COMPL_CNT, MAX(TRANS_DATE) TRANS_DATE    ");
                strSQL.Append(" FROM RCV_DISB_TRANS WHERE REQ_TYPE IN ('21', '24') AND SLIP_TYPE = '02' ");
                strSQL.Append(" GROUP BY XFER_NO, PARTIAL_DELV_COMPL_CNT ) RCV_DISB_TRANS               ");
                strSQL.Append(" WHERE                                                                   ");
                strSQL.Append(" T.XFER_NO = D.XFER_NO                                   ");
                strSQL.Append(" AND T.FROM_WHS_CD = W.WHS_CD                            ");
                strSQL.Append(" AND T.TO_WS_CD = WS.WS_CD                               ");
                strSQL.Append(" AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR     ");
                strSQL.Append(" AND D.XFER_NO = RCV_DISB_TRANS.XFER_NO                  ");
                strSQL.Append(" AND D.SEQ_NO = RCV_DISB_TRANS.PARTIAL_DELV_COMPL_CNT    ");
                strSQL.Append(" AND T.REQ_TYPE in ('21','24')                           ");
                strSQL.Append(" AND T.XFER_STATUS<=30                                   ");
                strSQL.Append(" AND AND D.ALLOC_STATUS=20                               ");

                strSQL.Append(" AND T.SLIP_NO = :SLIP_NO                                ");
                db.DbPsetString("SLIP_NO", _slip_no);

            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T                                                                   ");
                strSQL.Append(" INNER JOIN DISB_ALLOC D ON T.XFER_NO = D.XFER_NO                                        ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON T.FROM_WHS_CD = W.WHS_CD                          ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON T.TO_WS_CD = WS.WS_CD                             ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR   ");
                strSQL.Append(" LEFT OUTER JOIN (SELECT XFER_NO, PARTIAL_DELV_COMPL_CNT, MAX(TRANS_DATE) TRANS_DATE     ");
                strSQL.Append(" FROM RCV_DISB_TRANS WHERE REQ_TYPE IN ('21', '24') AND SLIP_TYPE = '02'                 ");
                strSQL.Append(" GROUP BY XFER_NO, PARTIAL_DELV_COMPL_CNT ) RCV_DISB_TRANS                               ");
                strSQL.Append(" ON D.XFER_NO = RCV_DISB_TRANS.XFER_NO                                                   ");
                strSQL.Append(" AND D.SEQ_NO = RCV_DISB_TRANS.PARTIAL_DELV_COMPL_CNT                                    ");
                strSQL.Append(" WHERE                                           ");
                strSQL.Append(" T.REQ_TYPE in ('21','24')                       ");
                strSQL.Append(" AND T.XFER_STATUS<=30                           ");
                //strSQL.Append(" AND (T.XFER_STATUS=20 OR T.XFER_STATUS=30)      ");
                strSQL.Append(" AND D.ALLOC_STATUS = 20                         ");

                strSQL.Append(" AND T.SLIP_NO = @SLIP_NO ");
                db.DbPsetString("@SLIP_NO", _slip_no);
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
        /// 出庫実績取消対象データを検索
        /// 
        /// 使用画面：InvDisbIMCancel
        /// </summary>
        public DataSet GetDisbIMCancelList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql    
            strSQL.Append(" SELECT SUBSTRING(T.SLIP_NO,1,7) + '-' +  CONVERT(VARCHAR,CONVERT(INT,SUBSTRING(T.SLIP_NO,8,3))) PICKING_NO, ");
            strSQL.Append(" T.FROM_WHS_CD,      W.WHS_DESC,     T.TO_WS_CD,         WS.WS_DESC,     T.XFER_SCH_DATE,        ");
            strSQL.Append(" T.SLIP_LINE_NO,     T.ITEM_NO,      T.ITEM_DESC,        D.ALLOC_QTY,    S.DATA_CHAR ITEM_UMSR,  ");
            strSQL.Append(" D.ACT_QTY,          D.LOCATION,     D.LOT_NO,           D.JOC_CD,       T.TO_PROCESS_CD,        ");
            strSQL.Append(" T.XFER_NO,          T.XFER_STATUS,  D.SEQ_NO,           RCV_DISB_TRANS.TRANS_DATE               ");

            db.DbParametersClear();

            strSQL.Append(" FROM TRANSFER_TRANS T                                                                   ");
            strSQL.Append(" INNER JOIN DISB_ALLOC D ON T.XFER_NO = D.XFER_NO                                        ");
            strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON T.FROM_WHS_CD = W.WHS_CD                          ");
            strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON T.TO_WS_CD = WS.WS_CD                             ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR   ");
            strSQL.Append(" LEFT OUTER JOIN (SELECT XFER_NO, PARTIAL_DELV_COMPL_CNT, MAX(TRANS_DATE) TRANS_DATE     ");
            strSQL.Append(" FROM RCV_DISB_TRANS WHERE REQ_TYPE IN ('21', '24') AND SLIP_TYPE = '02'                 ");
            strSQL.Append(" GROUP BY XFER_NO, PARTIAL_DELV_COMPL_CNT ) RCV_DISB_TRANS                               ");
            strSQL.Append(" ON D.XFER_NO = RCV_DISB_TRANS.XFER_NO                                                   ");
            strSQL.Append(" AND D.SEQ_NO = RCV_DISB_TRANS.PARTIAL_DELV_COMPL_CNT                                    ");
            strSQL.Append(" WHERE                                           ");
            strSQL.Append(" T.REQ_TYPE in ('21','24')                       ");
            strSQL.Append(" AND T.XFER_STATUS<=50                           ");
            //strSQL.Append(" AND (T.XFER_STATUS=20 OR T.XFER_STATUS=30)      ");
            strSQL.Append(" AND D.ALLOC_STATUS = 20                         ");

            if (_picking_no != "")
            {
                strSQL.Append(" AND     SUBSTRING(T.SLIP_NO,1,7)            = @PICKING_NO                          ");
                db.DbPsetString("@PICKING_NO", _picking_no);
            }
            if (_item_no != "")
            {
                strSQL.Append(" AND     T.ITEM_NO               = @ITEM_NO                             ");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND     T.FROM_WHS_CD               = @WHS_CD                             ");
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            if (_act_date != 0)
            {
                strSQL.Append(" AND     T.TRANS_DATE     = @ACT_DATE                            ");
                db.DbPsetInt("@ACT_DATE", _act_date);
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
        /// 出庫実績取消

        /// 
        /// 使用画面：InvDisbActCancel
        /// </summary>
        public int DisbActCancel()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_IN);
            db.DbPsetInt("@I_SEQ_NO", _seq_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USERID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_DISB_ACT_CANCEL");
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
        /// 計画外入出庫伝票出力

        /// 
        /// 使用画面：InvAdjList
        /// </summary>
        public int AdjListPrint(ComDB db)
        {
            //ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_SLIP_NO", _slip_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USERID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_ADJ_LIST_PRINT");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                //db.DbCommit();
                //db.DbCommit();					// 2009.01.16 ubiq-harada
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
        /// 発行済の部品出庫指示情報を抽出
        /// 
        /// 使用画面：InvDisbList
        /// ADD 2009.09.01
        /// </summary>
        public DataSet GetDisbList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql    
            strSQL.Append(" SELECT DISTINCT                                             ");
            strSQL.Append(" T.FROM_WHS_CD,  T.SLIP_DATE,    T.SLIP_NO                   ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T                           ");
                strSQL.Append(" INNER JOIN DISB_ALLOC D                         ");
                strSQL.Append(" ON T.XFER_NO = D.XFER_NO                        ");
                strSQL.Append(" AND D.ALLOC_STATUS = 0                          ");
                strSQL.Append(" WHERE                                           ");
                strSQL.Append(" T.REQ_TYPE in ('21','24')                       ");
                strSQL.Append(" AND T.XFER_STATUS = 10                          ");
                if (from_whs_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WHS_CD = :FROM_WHS_CD    ");
                    db.DbPsetString("FROM_WHS_CD", _from_whs_cd);
                }
                strSQL.Append(" ORDER BY T.FROM_WHS_CD,T.SLIP_DATE,T.SLIP_NO    ");
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T                           ");
                strSQL.Append(" INNER JOIN DISB_ALLOC D                         ");
                strSQL.Append(" ON T.XFER_NO = D.XFER_NO                        ");
                strSQL.Append(" AND D.ALLOC_STATUS = 0                          ");
                strSQL.Append(" WHERE                                           ");
                strSQL.Append(" T.REQ_TYPE in ('21','24')                       ");
                strSQL.Append(" AND T.XFER_STATUS = 10                          ");
                if (from_whs_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WHS_CD = @FROM_WHS_CD    ");
                    db.DbPsetString("@FROM_WHS_CD",_from_whs_cd);
                }
                strSQL.Append(" ORDER BY T.FROM_WHS_CD,T.SLIP_DATE,T.SLIP_NO    ");
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

        //-->ADD BY UBIQ-SUO 2011/1/27
        /// <summary>
        /// 出庫指示検索
        /// 
        /// 使用画面：SrchInvDisbAct
        /// </summary>
        public DataSet GetDisbActListAll()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql    
            strSQL.Append(" SELECT                                                                          ");
            strSQL.Append(" TT.FROM_WHS_CD, WM.WHS_DESC, TT.SLIP_NO, TT.TO_WS_CD,");
            strSQL.Append(" WS.WS_DESC, TT.XFER_SCH_DATE, TT.ITEM_NO, TT.ITEM_DESC,");
            strSQL.Append(" DA.ALLOC_QTY, S.DATA_CHAR ITEM_UMSR, DA.LOCATION,  DA.LOT_NO,       ");
            strSQL.Append(" DA.JOC_CD, TT.TO_VC_CD, VM.VENDOR_NAME        ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS TT,DISB_ALLOC DA,WORKSHOP_MASTER WS, ");
                strSQL.Append(" WAREHOUSE_MASTER WM,PROCESS_MASTER PM,VENDOR_MASTER VM,SYSTEM_PARAMETER S ");
                strSQL.Append(" WHERE ");
                strSQL.Append(" TT.XFER_NO = DA.XFER_NO ");
                strSQL.Append(" AND TT.TO_WS_CD = WS.WS_CD(+)  ");
                strSQL.Append(" AND TT.FROM_WHS_CD = WM.WHS_CD(+) ");
                strSQL.Append(" AND TT.TO_PROCESS_CD = PM.PROCESS_CD(+) ");
                strSQL.Append(" AND TT.TO_VC_CD = VM.VENDOR_CD(+) ");

                strSQL.Append(" AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = TT.ITEM_UMSR(+) ");
                //strSQL.Append(" AND TT.TO_PROCESS_CD = P.PROCESS_CD(+)  ");
                strSQL.Append(" AND TT.REQ_TYPE in ('21','24') ");
                strSQL.Append(" AND (TT.XFER_STATUS = 5 OR TT.XFER_STATUS = 10) ");
                if (from_whs_cd != "")
                {
                    strSQL.Append(" AND TT.FROM_WHS_CD = :FROM_WHS_CD    ");
                    db.DbPsetString("FROM_WHS_CD", _from_whs_cd);
                }
                if (xfer_sch_date != 0)
                {
                    strSQL.Append(" AND TT.XFER_SCH_DATE = :XFER_SCH_DATE    ");
                    db.DbPsetInt("XFER_SCH_DATE",_xfer_sch_date);
                }

                strSQL.Append(" AND DA.ALLOC_STATUS = 0 ");                
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS TT                                                                   ");
                strSQL.Append(" INNER JOIN DISB_ALLOC DA ON TT.XFER_NO = DA.XFER_NO                                        ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WM ON TT.FROM_WHS_CD = WM.WHS_CD                          ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON TT.TO_WS_CD = WS.WS_CD                             ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PM ON TT.TO_PROCESS_CD = PM.PROCESS_CD                   ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER VM ON TT.TO_VC_CD = VM.VENDOR_CD                          ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = TT.ITEM_UMSR  ");
                //strSQL.Append(" LEFT  JOIN PROCESS_MASTER P ON T.TO_PROCESS_CD = P.PROCESS_CD                         ");
                strSQL.Append(" WHERE                           ");
                strSQL.Append(" TT.REQ_TYPE in ('21','24')       ");
                strSQL.Append(" AND (TT.XFER_STATUS = 5 OR TT.XFER_STATUS = 10) ");
                if (from_whs_cd != "")
                {
                    strSQL.Append(" AND TT.FROM_WHS_CD = @FROM_WHS_CD    ");
                    db.DbPsetString("@FROM_WHS_CD", _from_whs_cd);
                }
                if (xfer_sch_date != 0)
                {
                    strSQL.Append(" AND TT.XFER_SCH_DATE = @XFER_SCH_DATE    ");
                    db.DbPsetInt("@XFER_SCH_DATE", _xfer_sch_date);
                }
                strSQL.Append(" AND DA.ALLOC_STATUS = 0          ");
                
            }
            strSQL.Append(" ORDER BY                                            ");
            strSQL.Append(" TT.FROM_WHS_CD,TT.XFER_SCH_DATE,TT.TO_WS_CD,TT.SLIP_NO ");

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
        //<--ADD BY UBIQ-SUO 2011/1/27

        //-->ADD BY UBIQ-MATSUNO 2011/6/15
        /// <summary>
        /// 出庫実績検索 2011.06.15
        /// 
        /// 使用画面：SrchInvDisbActCancel
        /// </summary>
        public DataSet GetDisbActCancelListAll()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql    
            strSQL.Append(" SELECT                                                                          ");
            strSQL.Append(" TT.FROM_WHS_CD, WM.WHS_DESC, TT.SLIP_NO, TT.TO_WS_CD,");
            strSQL.Append(" WS.WS_DESC, TT.XFER_SCH_DATE, TT.ITEM_NO, TT.ITEM_DESC,");
            strSQL.Append(" DA.ACT_QTY, S.DATA_CHAR ITEM_UMSR, DA.LOCATION,  DA.LOT_NO,       ");
            strSQL.Append(" DA.JOC_CD, TT.TO_VC_CD, VM.VENDOR_NAME,RCV_DISB_TRANS.TRANS_DATE        ");

                db.DbParametersClear();

            strSQL.Append(" FROM TRANSFER_TRANS TT                                                                   ");
            strSQL.Append(" INNER JOIN DISB_ALLOC DA ON TT.XFER_NO = DA.XFER_NO                                        ");
            strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WM ON TT.FROM_WHS_CD = WM.WHS_CD                          ");
            strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON TT.TO_WS_CD = WS.WS_CD                             ");
            strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PM ON TT.TO_PROCESS_CD = PM.PROCESS_CD                   ");
            strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER VM ON TT.TO_VC_CD = VM.VENDOR_CD                          ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = TT.ITEM_UMSR  ");
            strSQL.Append(" LEFT OUTER JOIN (SELECT XFER_NO, PARTIAL_DELV_COMPL_CNT, COALESCE(MAX(TRANS_DATE),0) TRANS_DATE     ");
            strSQL.Append(" FROM RCV_DISB_TRANS WHERE REQ_TYPE IN ('21', '24') AND SLIP_TYPE = '02'                 ");
            strSQL.Append(" GROUP BY XFER_NO, PARTIAL_DELV_COMPL_CNT ) RCV_DISB_TRANS                               ");
            strSQL.Append(" ON DA.XFER_NO = RCV_DISB_TRANS.XFER_NO                                                  ");
            strSQL.Append(" AND DA.SEQ_NO = RCV_DISB_TRANS.PARTIAL_DELV_COMPL_CNT                                   ");

            //strSQL.Append(" LEFT  JOIN PROCESS_MASTER P ON T.TO_PROCESS_CD = P.PROCESS_CD                         ");
            strSQL.Append(" WHERE                           ");
            strSQL.Append(" TT.REQ_TYPE in ('21','24')       ");
            strSQL.Append(" AND TT.XFER_STATUS<=30                           ");
            if (from_whs_cd != "")
            {
                strSQL.Append(" AND TT.FROM_WHS_CD = @FROM_WHS_CD    ");
                db.DbPsetString("@FROM_WHS_CD", _from_whs_cd);
            }
            if (_xfer_sch_date_from != 0)
            {
                strSQL.Append(" AND RCV_DISB_TRANS.TRANS_DATE >= @XFER_SCH_DATE    ");
                db.DbPsetInt("@XFER_SCH_DATE", _xfer_sch_date_from);
            }
            if (_xfer_sch_date_to != 0)
            {
                strSQL.Append(" AND RCV_DISB_TRANS.TRANS_DATE <= @XFER_SCH_DATE2    ");
                db.DbPsetInt("@XFER_SCH_DATE2", _xfer_sch_date_to);
            }
            strSQL.Append(" AND DA.ALLOC_STATUS = 20          ");

            strSQL.Append(" ORDER BY                                            ");
            strSQL.Append(" TT.FROM_WHS_CD,RCV_DISB_TRANS.TRANS_DATE,TT.TO_WS_CD,TT.SLIP_NO ");

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
        //<--ADD BY UBIQ-MATSUNO 2011/6/15


        //
        // IMV3
        //
        /// <summary>
        /// 指示№に対してピッキング指示を得る
        /// 使用画面：InvPickingUpd
        /// </summary>
        /// <returns></returns>
        public DataSet Get_PickingDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                     ");
            strSQL.Append("P.PICKING_NO,   P.PICKING_LINE_NO,    P.ITEM_NO,  P.PLAN_QTY,  P.ITEM_UMSR UMSR,");
            strSQL.Append("P.WHS_CD,       P.INST_DATE,          P.ACT_PICKING_DATE,      P.ACT_DISB_DATE,   ");
            strSQL.Append("I.ITEM_DESC,    S1.DATA_CHAR ITEM_UMSR, 'EXIST' AS MARK,       P.ITEM_KIND   ");
            strSQL.Append(",P.JOB_ORDER_NO  "); // 2015.06.22
            db.DbParametersClear();

            strSQL.Append("FROM                                                                        ");
            strSQL.Append("PICKING_TRANS   P                                                           ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I    ON  P.ITEM_NO     = I.ITEM_NO             ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01='ITEM_UMSR'                ");
            strSQL.Append(" AND S1.KEY02 = P.ITEM_UMSR                                                 ");
            strSQL.Append(" WHERE                                                                      ");
            strSQL.Append("      P.PICKING_NO            = @PICKING_NO                             ");  
            db.DbPsetString("@PICKING_NO", _picking_no);
            strSQL.Append(" ORDER BY P.PICKING_LINE_NO                                    ");

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
        /// 親品目指定に対してピッキング指示対象の子品目を得る
        /// 使用画面：InvPickingUpdByParent
        /// </summary>
        /// <returns></returns>
        public DataSet Get_PickingItem()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("M.PART_SEQ,			I.ITEM_NO,          I.ITEM_DESC,	        ");
            strSQL.Append(" (ISNULL(CASE    WHEN M.USAGE_TYPE = 0 THEN M.USAGE_DEC                                  ");
            strSQL.Append("                 WHEN  M.USAGE_TYPE = 1 THEN                                             ");
            strSQL.Append("                 (M.USAGE_DENOMINATOR/M.USAGE_NUMERATOR) END,0)* @INST_QTY) PLAN_QTY,    ");

            strSQL.Append("CASE I.DISB_LOT_SIZE WHEN 0 THEN ");
            strSQL.Append(" (ISNULL(CASE    WHEN M.USAGE_TYPE = 0 THEN M.USAGE_DEC                                  ");
            strSQL.Append("                 WHEN  M.USAGE_TYPE = 1 THEN                                             ");
            strSQL.Append("                 (M.USAGE_DENOMINATOR/M.USAGE_NUMERATOR) END,0)* @INST_QTY)     ");
            strSQL.Append("ELSE ");
            strSQL.Append(" FLOOR(ISNULL(CASE    WHEN M.USAGE_TYPE = 0 THEN M.USAGE_DEC                                  ");
            strSQL.Append("                 WHEN  M.USAGE_TYPE = 1 THEN                                             ");
            strSQL.Append("                 (M.USAGE_DENOMINATOR/M.USAGE_NUMERATOR) END,0)* @INST_QTY/I.DISB_LOT_SIZE) * I.DISB_LOT_SIZE ");
            strSQL.Append(" + CASE WHEN ");
            strSQL.Append(" (ISNULL(CASE    WHEN M.USAGE_TYPE = 0 THEN M.USAGE_DEC                                  ");
            strSQL.Append("                 WHEN  M.USAGE_TYPE = 1 THEN                                             ");
            strSQL.Append("                 (M.USAGE_DENOMINATOR/M.USAGE_NUMERATOR) END,0)* @INST_QTY) %  I.DISB_LOT_SIZE > 0    ");
            strSQL.Append("   THEN I.DISB_LOT_SIZE ELSE 0 END ");
            strSQL.Append(" END INST_QTY,");
            strSQL.Append(" S3.DATA_CHAR UMSR_NAME, I.ITEM_UMSR ");

            strSQL.Append(" FROM MFG_BOM_MASTER M ");
            strSQL.Append(" INNER JOIN ITEM_MASTER I ON M.CHILD_ITEM_NO    = I.ITEM_NO");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S3 ON S3.KEY01 = 'ITEM_UMSR'               ");
            strSQL.Append(" AND S3.KEY02        =       I.ITEM_UMSR                                   ");

            strSQL.Append(" WHERE M.PARENT_ITEM_NO  = @PARENT_ITEM_NO                       ");
            strSQL.Append("   AND M.MBOM_SUB_CD     = @MBOM_SUB_CD                          ");
            strSQL.Append("   AND M.BEG_EFF_DATE    <= @TODAY                          ");
            strSQL.Append("   AND M.END_EFF_DATE    >= @TODAY                          ");
            strSQL.Append("   AND I.AUTO_DISB_TYPE  = 0 "); // みなし出庫は除外

            db.DbParametersClear();
            db.DbPsetString("@PARENT_ITEM_NO", _item_no);
            db.DbPsetString("@MBOM_SUB_CD", "");
            db.DbPsetInt("@TODAY", int.Parse(DateTime.Now.ToString("yyyyMMdd")));
            db.DbPsetDouble("@INST_QTY", _inst_qty);
            strSQL.Append(" ORDER BY  M.PART_SEQ");

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
        /// ピッキング指示登録プロシジャ
        /// 使用画面：InvPickingInst
        /// </summary>
        /// <returns></returns>
        public int PickingInsert(ComDB db)
        {
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PICKING_NO", _picking_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PICKING_LINE_NO", _picking_line_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_DESC", _item_desc, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_KIND", _item_kind, ComConst.DB_IN);
            db.DbPsetDouble("@I_PLAN_QTY", _plan_qty, ComConst.DB_IN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);      // 2015.06.20

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_PICKING_INSERT");
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
        //
        /// <summary>
        /// ピッキング指示を得る
        /// 使用画面：InvPickingUpd
        /// </summary>
        /// <returns></returns>
        public DataSet Get_PickingList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                     ");
            strSQL.Append("P.PICKING_NO,   P.PICKING_LINE_NO,    P.ITEM_NO,  P.PLAN_QTY,  P.ITEM_UMSR UMSR,");
            strSQL.Append("P.WHS_CD,       P.INST_DATE,          P.ACT_PICKING_DATE,      P.ACT_DISB_DATE,   ");
            strSQL.Append("I.ITEM_DESC,    S1.DATA_CHAR ITEM_UMSR, '*' + P.PICKING_NO + '*' PICKING_NO_BCD   ");
            strSQL.Append(",P.JOB_ORDER_NO  "); // 2015.06.20
            strSQL.Append(",'*' + P.ITEM_NO + '*' ITEM_NO_BCD  "); // 2015.08.14
            db.DbParametersClear();

            strSQL.Append("FROM                                                                        ");
            strSQL.Append("PICKING_TRANS   P                                                           ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I    ON  P.ITEM_NO     = I.ITEM_NO             ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01='ITEM_UMSR'                ");
            strSQL.Append(" AND S1.KEY02 = P.ITEM_UMSR                                                 ");
            strSQL.Append(" WHERE                                                                      ");
            strSQL.Append("      1 = 1                                                                 ");
            if (_picking_no != "")
            {
                strSQL.Append(" AND     P.PICKING_NO            = @PICKING_NO                          ");
                db.DbPsetString("@PICKING_NO", _picking_no);
            }
            if (_item_no != "")
            {
                strSQL.Append(" AND     P.ITEM_NO               = @ITEM_NO                             ");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_picking_status != 0)
            {
                strSQL.Append(" AND     P.PICKING_STATUS            < @PICKING_STATUS                             ");
                db.DbPsetInt("@PICKING_STATUS", _picking_status);
            }
            if (_item_kind != "")
            {
                strSQL.Append(" AND     P.ITEM_KIND            = @ITEM_KIND                             ");
                db.DbPsetString("@ITEM_KIND", _item_kind);
            }
            strSQL.Append(" ORDER BY P.PICKING_NO,P.PICKING_LINE_NO                                    ");

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
        /// ピッキング実績を得る(HTなし)
        /// 使用画面：InvPickingUpd
        /// </summary>
        /// <returns></returns>
        public DataSet Get_PickingActList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                     ");
            strSQL.Append("P.PICKING_NO,   P.PICKING_LINE_NO,    P.SEQ_NO,                1 ACTUAL_SEQ_NO,   ");
            strSQL.Append("P.ITEM_NO,      P.PLAN_QTY,           P.ITEM_UMSR,             P.LOCATION     ,   P.LOT_NO   ,");
            strSQL.Append("P.LOCATION HT_ACT_LOCATION,           P.LOT_NO HT_ACT_LOT_NO,         P.PLAN_QTY HT_ACT_QTY   ,");
            strSQL.Append("P.WHS_CD,       P.INST_DATE REC_DATE,           ");
            strSQL.Append("I.ITEM_DESC,    S1.DATA_CHAR ITEM_UMSR,W.WHS_DESC, '*' + P.PICKING_NO + '*' PICKING_NO_BCD         ");
            strSQL.Append(",PT.JOB_ORDER_NO "); // 2015.06.22
            strSQL.Append(",'*' + P.ITEM_NO + '*' ITEM_NO_BCD  "); // 2015.08.14
            strSQL.Append(",'*' + P.LOT_NO + '*' LOT_NO_BCD  "); // 2015.08.14
            db.DbParametersClear();

            strSQL.Append("FROM                                                                        ");
            strSQL.Append("PICKING_LOT   P                                                           ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I    ON  P.ITEM_NO     = I.ITEM_NO             ");
            strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W    ON  P.WHS_CD     = W.WHS_CD             ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01='ITEM_UMSR'                ");
            strSQL.Append(" AND S1.KEY02 = P.ITEM_UMSR                                                 ");
            strSQL.Append(" LEFT JOIN PICKING_TRANS PT ON  P.PICKING_NO = PT.PICKING_NO AND P.PICKING_LINE_NO = PT.PICKING_LINE_NO "); // 2015.06.22
            strSQL.Append(" WHERE ");
            strSQL.Append(" P.PICKING_STATUS < 20 ");
            if (_picking_no != "")
            {
                strSQL.Append(" AND     P.PICKING_NO            = @PICKING_NO                          ");
                db.DbPsetString("@PICKING_NO", _picking_no);
            }
            if (_item_no != "")
            {
                strSQL.Append(" AND     P.ITEM_NO               = @ITEM_NO                             ");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND     P.WHS_CD               = @WHS_CD                             ");
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            if(_act_date != 0)
            {
                strSQL.Append(" AND     P.INST_DATE            = @ACT_DATE                            ");
                db.DbPsetInt("@ACT_DATE", _act_date);
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

        //
        /// <summary>
        /// ピッキング指示を得る
        /// 使用画面：InvPickingUpd
        /// </summary>
        /// <returns></returns>
        public DataSet Get_PickingListShip()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                     ");
            strSQL.Append("P.PICKING_NO,   P.PICKING_LINE_NO,    P.ITEM_NO,  P.PLAN_QTY,  P.ITEM_UMSR UMSR,");
            strSQL.Append("P.WHS_CD,       P.INST_DATE,          P.ACT_PICKING_DATE,      P.ACT_DISB_DATE,   ");
            strSQL.Append("I.ITEM_DESC,    S1.DATA_CHAR ITEM_UMSR, '*' + P.PICKING_NO + '*' PICKING_NO_BCD   ");
            strSQL.Append(",'*' + P.ITEM_NO + '*' ITEM_NO_BCD  "); // 2015.08.14
            db.DbParametersClear();

            strSQL.Append("FROM                                                                        ");
            strSQL.Append("PICKING_TRANS   P                                                           ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I    ON  P.ITEM_NO     = I.ITEM_NO             ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01='ITEM_UMSR'                ");
            strSQL.Append(" AND S1.KEY02 = P.ITEM_UMSR                                                 ");
            strSQL.Append(" WHERE                                                                      ");
            strSQL.Append("      P.PICKING_STATUS = 0                                                  ");
            strSQL.Append(" AND     P.ITEM_KIND            = 2                                         ");
            strSQL.Append(" ORDER BY P.PICKING_NO,P.PICKING_LINE_NO                                    ");

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
        /// ピッキング実績を得る(HTなし)
        /// 使用画面：InvPickingUpd
        /// </summary>
        /// <returns></returns>
        public DataSet Get_PickingActListShip()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                     ");
            strSQL.Append("P.PICKING_NO,   P.PICKING_LINE_NO,    P.SEQ_NO,                1 ACTUAL_SEQ_NO,   ");
            strSQL.Append("P.ITEM_NO,      P.PLAN_QTY,           P.ITEM_UMSR,             P.LOCATION     ,   P.LOT_NO   ,");
            strSQL.Append("P.LOCATION HT_ACT_LOCATION,           P.LOT_NO HT_ACT_LOT_NO,         P.PLAN_QTY HT_ACT_QTY   ,");
            strSQL.Append("P.WHS_CD,       P.INST_DATE REC_DATE,           ");
            strSQL.Append("I.ITEM_DESC,    S1.DATA_CHAR ITEM_UMSR,W.WHS_DESC, '*' + P.PICKING_NO + '*' PICKING_NO_BCD         ");
            strSQL.Append(",'*' + P.ITEM_NO + '*' ITEM_NO_BCD  "); // 2015.08.14
            strSQL.Append(",'*' + P.LOT_NO + '*' LOT_NO_BCD  "); // 2015.08.14
            db.DbParametersClear();

            strSQL.Append("FROM                                                                        ");
            strSQL.Append("PICKING_LOT   P                                                           ");
            strSQL.Append("INNER JOIN PICKING_TRANS PT ON  P.PICKING_NO = PT.PICKING_NO AND P.PICKING_LINE_NO = PT.PICKING_LINE_NO ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I    ON  P.ITEM_NO     = I.ITEM_NO             ");
            strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W    ON  P.WHS_CD     = W.WHS_CD             ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01='ITEM_UMSR'                ");
            strSQL.Append(" AND S1.KEY02 = P.ITEM_UMSR                                                 ");
            strSQL.Append(" WHERE ");
            strSQL.Append("      PT.PICKING_STATUS = 0                                                  ");
            strSQL.Append(" AND     PT.ITEM_KIND            = 2                                         ");

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
        /// ピッキング実績を得る(HT)
        /// 使用画面：InvPickingUpd
        /// </summary>
        /// <returns></returns>
        public DataSet Get_PickingActHTList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                     ");
            strSQL.Append("P.PICKING_NO,   P.PICKING_LINE_NO,    P.SEQ_NO,                P.ACTUAL_SEQ_NO,   ");
            strSQL.Append("P.ITEM_NO,      P.PLAN_QTY,           P.ITEM_UMSR,             P.LOCATION     ,   P.LOT_NO   ,");
            strSQL.Append("P.HT_ACT_LOCATION,                    P.HT_ACT_LOT_NO,         P.HT_ACT_QTY   ,");
            strSQL.Append("P.WHS_CD,       P.REC_DATE,           ");
            strSQL.Append("I.ITEM_DESC,    S1.DATA_CHAR ITEM_UMSR,W.WHS_DESC         ");
            db.DbParametersClear();

            strSQL.Append("FROM                                                                        ");
            strSQL.Append("PICKING_LOT_IF   P                                                           ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I    ON  P.ITEM_NO     = I.ITEM_NO             ");
            strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W    ON  P.WHS_CD     = W.WHS_CD             ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01='ITEM_UMSR'                ");
            strSQL.Append(" AND S1.KEY02 = P.ITEM_UMSR                                                 ");
            strSQL.Append(" WHERE ");
            //strSQL.Append(" P.HT_SEND_STATUS < 3 AND P.HT_ACT_QTY > 0 ");
            strSQL.Append(" P.HT_SEND_STATUS = 2 ");
            if (_picking_no != "")
            {
                strSQL.Append(" AND     P.PICKING_NO            = @PICKING_NO                          ");
                db.DbPsetString("@PICKING_NO", _picking_no);
            }
            if (_item_no != "")
            {
                strSQL.Append(" AND     P.ITEM_NO               = @ITEM_NO                             ");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND     P.WHS_CD               = @WHS_CD                             ");
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            if (_act_date != 0)
            {
                strSQL.Append(" AND     P.REC_DATE            = @ACT_DATE                            ");
                db.DbPsetInt("@ACT_DATE", _act_date);
            }
            strSQL.Append(" ORDER BY P.PICKING_NO,P.PICKING_LINE_NO,P.SEQ_NO,P.ACTUAL_SEQ_NO         ");

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
        /// ピッキング実績を得る 個別
        /// 使用画面：InvPickingUpd
        /// </summary>
        /// <returns></returns>
        public int Get_PickingActData()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT                                                                     ");
            strSQL.Append("P.ITEM_NO,      P.PLAN_QTY,           P.LOCATION     ,         P.LOT_NO   ,");
            strSQL.Append("P.HT_ACT_LOCATION,                    P.HT_ACT_LOT_NO,         P.HT_ACT_QTY   ,");
            strSQL.Append("P.WHS_CD,       P.INST_DATE,           ");
            strSQL.Append("I.ITEM_DESC,    S1.DATA_CHAR ITEM_UMSR,W.WHS_DESC         ");
            strSQL.Append("FROM                                                                        ");
            strSQL.Append("PICKING_LOT   P                                                           ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I    ON  P.ITEM_NO     = I.ITEM_NO             ");
            strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W    ON  P.WHS_CD     = W.WHS_CD             ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01='ITEM_UMSR'                ");
            strSQL.Append(" AND S1.KEY02 = P.ITEM_UMSR                                                 ");
            strSQL.Append(" WHERE ");
            strSQL.Append("         P.PICKING_NO            = @PICKING_NO                          ");
            strSQL.Append(" AND     P.PICKING_LINE_NO       = @PICKING_LINE_NO                     ");
            strSQL.Append(" AND     P.SEQ_NO                = @SEQ_NO                              ");
            strSQL.Append(" AND     P.ACTUAL_SEQ_NO         = @ACTUAL_SEQ_NO                       ");

            db.DbParametersClear();

            db.DbPsetString("@PICKING_NO", _picking_no);
            db.DbPsetInt("@PICKING_LINE_NO", _picking_line_no);
            db.DbPsetInt("@SEQ_NO", _seq_no);
            db.DbPsetInt("@ACTUAL_SEQ_NO", _actual_seq_no);

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
                _to_location = db.Row("LOCATION");
                _to_lot_no = db.Row("LOT_NO");

                _plan_qty = double.Parse(db.Row("PLAN_QTY"));
                _act_qty = double.Parse(db.Row("PLAN_QTY"));

                _whs_cd = db.Row("WHS_CD");
                _whs_desc = db.Row("WHS_DESC");
                _item_umsr = db.Row("ITEM_UMSR");

                _sch_start_date = int.Parse(db.Row("INST_DATE"));
                _act_date = int.Parse(db.Row("INST_DATE"));

            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// ピッキング実績を得る(HT)個別
        /// 使用画面：InvPickingUpd
        /// </summary>
        /// <returns></returns>
        public int Get_PickingActHTData()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT                                                                     ");
            strSQL.Append("P.ITEM_NO,      P.PLAN_QTY,           P.LOCATION     ,         P.LOT_NO   ,");
            strSQL.Append("P.HT_ACT_LOCATION,                    P.HT_ACT_LOT_NO,         P.HT_ACT_QTY   ,");
            strSQL.Append("P.WHS_CD,       P.REC_DATE,           ");
            strSQL.Append("I.ITEM_DESC,    S1.DATA_CHAR ITEM_UMSR,W.WHS_DESC         ");
            strSQL.Append("FROM                                                                        ");
            strSQL.Append("PICKING_LOT_IF   P                                                           ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I    ON  P.ITEM_NO     = I.ITEM_NO             ");
            strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W    ON  P.WHS_CD     = W.WHS_CD             ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01='ITEM_UMSR'                ");
            strSQL.Append(" AND S1.KEY02 = P.ITEM_UMSR                                                 ");
            strSQL.Append(" WHERE ");
            strSQL.Append("         P.PICKING_NO            = @PICKING_NO                          ");
            strSQL.Append(" AND     P.PICKING_LINE_NO       = @PICKING_LINE_NO                     ");
            strSQL.Append(" AND     P.SEQ_NO                = @SEQ_NO                              ");
            strSQL.Append(" AND     P.ACTUAL_SEQ_NO         = @ACTUAL_SEQ_NO                       ");

            db.DbParametersClear();

            db.DbPsetString("@PICKING_NO", _picking_no);
            db.DbPsetInt("@PICKING_LINE_NO", _picking_line_no);
            db.DbPsetInt("@SEQ_NO", _seq_no);
            db.DbPsetInt("@ACTUAL_SEQ_NO", _actual_seq_no);

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
                _to_location = db.Row("HT_ACT_LOCATION");
                _to_lot_no = db.Row("HT_ACT_LOT_NO");

                _plan_qty = double.Parse(db.Row("PLAN_QTY"));
                _act_qty = double.Parse(db.Row("HT_ACT_QTY"));

                _whs_cd = db.Row("WHS_CD");
                _whs_desc = db.Row("WHS_DESC");
                _item_umsr = db.Row("ITEM_UMSR");

                _sch_start_date = int.Parse(db.Row("REC_DATE"));
                _act_date = int.Parse(db.Row("REC_DATE"));

            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// 出庫実績用ピッキング実績を得る
        /// 使用画面：InvDisbIM
        /// </summary>
        /// <returns></returns>
        public DataSet Get_DisbIMActList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                     ");
            strSQL.Append("P.PICKING_NO,   P.PICKING_LINE_NO,    P.SEQ_NO,                P.ACTUAL_SEQ_NO,   ");
            strSQL.Append("P.ITEM_NO,      P.PLAN_QTY,           P.ITEM_UMSR,             P.LOCATION     ,   P.LOT_NO   ,");
            strSQL.Append("P.ACT_LOCATION,                    P.ACT_LOT_NO,         P.ACT_QTY   ,");
            strSQL.Append("P.WHS_CD,       P.ACT_PICKING_DATE,           ");
            strSQL.Append("I.ITEM_DESC,    S1.DATA_CHAR ITEM_UMSR,W.WHS_DESC         ");
            strSQL.Append(",T.JOB_ORDER_NO ");  // 2015.06.25
            db.DbParametersClear();

            strSQL.Append("FROM                                                                        ");
            strSQL.Append("PICKING_LOT  P                                                           ");
            strSQL.Append(" INNER JOIN PICKING_TRANS T ON P.PICKING_NO = T.PICKING_NO AND P.PICKING_LINE_NO = T.PICKING_LINE_NO             ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I    ON  P.ITEM_NO     = I.ITEM_NO             ");
            strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W    ON  P.WHS_CD     = W.WHS_CD             ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01='ITEM_UMSR'                ");
            strSQL.Append(" AND S1.KEY02 = P.ITEM_UMSR                                                 ");
            strSQL.Append(" WHERE ");
            //strSQL.Append(" T.PICKING_STATUS = 20 AND  ");
            strSQL.Append(" P.PICKING_STATUS = 20 ");
            if (_picking_no != "")
            {
                strSQL.Append(" AND     P.PICKING_NO            = @PICKING_NO                          ");
                db.DbPsetString("@PICKING_NO", _picking_no);
            }
            if (_item_no != "")
            {
                strSQL.Append(" AND     P.ITEM_NO               = @ITEM_NO                             ");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND     P.WHS_CD               = @WHS_CD                             ");
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            if (_act_date != 0)
            {
                strSQL.Append(" AND     P.ACT_PICKING_DATE     = @ACT_DATE                            ");
                db.DbPsetInt("@ACT_DATE", _act_date);
            }
            strSQL.Append(" AND T.ITEM_KIND <> 2     ");
            strSQL.Append(" ORDER BY P.PICKING_NO,P.PICKING_LINE_NO,P.SEQ_NO,P.ACTUAL_SEQ_NO         ");

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
        /// 出庫処理用ピッキング実績を得る 個別
        /// 使用画面：InvDisbIM
        /// </summary>
        /// <returns></returns>
        public int Get_DisbIMActData()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT                                                                     ");
            strSQL.Append("P.ITEM_NO,      P.PLAN_QTY,           P.LOCATION     ,         P.LOT_NO   ,");
            strSQL.Append("P.ACT_LOCATION,                    P.ACT_LOT_NO,         P.ACT_QTY   ,  P.ACT_PICKING_DATE, ");
            strSQL.Append("P.WHS_CD,       P.INST_DATE,           ");
            strSQL.Append("I.ITEM_DESC,    S1.DATA_CHAR ITEM_UMSR,W.WHS_DESC         ");
            strSQL.Append("FROM                                                                        ");
            strSQL.Append("PICKING_LOT   P                                                           ");
            strSQL.Append(" INNER JOIN PICKING_TRANS T ON P.PICKING_NO = T.PICKING_NO AND P.PICKING_LINE_NO = T.PICKING_LINE_NO             ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I    ON  P.ITEM_NO     = I.ITEM_NO             ");
            strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W    ON  P.WHS_CD     = W.WHS_CD             ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01='ITEM_UMSR'                ");
            strSQL.Append(" AND S1.KEY02 = P.ITEM_UMSR                                                 ");
            strSQL.Append(" WHERE ");
            strSQL.Append("         P.PICKING_NO            = @PICKING_NO                          ");
            strSQL.Append(" AND     P.PICKING_LINE_NO       = @PICKING_LINE_NO                     ");
            strSQL.Append(" AND     P.SEQ_NO                = @SEQ_NO                              ");
            strSQL.Append(" AND     P.ACTUAL_SEQ_NO         = @ACTUAL_SEQ_NO                       ");
            strSQL.Append(" AND T.ITEM_KIND <> 2     ");

            db.DbParametersClear();

            db.DbPsetString("@PICKING_NO", _picking_no);
            db.DbPsetInt("@PICKING_LINE_NO", _picking_line_no);
            db.DbPsetInt("@SEQ_NO", _seq_no);
            db.DbPsetInt("@ACTUAL_SEQ_NO", _actual_seq_no);

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
                _to_location = db.Row("LOCATION");
                _to_lot_no = db.Row("LOT_NO");

                _plan_qty = double.Parse(db.Row("PLAN_QTY"));
                _act_qty = double.Parse(db.Row("ACT_QTY"));

                _whs_cd = db.Row("WHS_CD");
                _whs_desc = db.Row("WHS_DESC");
                _item_umsr = db.Row("ITEM_UMSR");

                _sch_start_date = int.Parse(db.Row("INST_DATE"));
                _act_date = int.Parse(db.Row("ACT_PICKING_DATE"));

            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }


        /// <summary>
        /// ピッキング指示明細削除プロシジャ
        /// 使用画面：InvPickingUpd
        /// </summary>
        /// <returns></returns>
        public int PickingDetailDelete(ComDB db)
        {
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PICKING_NO", _picking_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PICKING_LINE_NO", _picking_line_no, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_PICKING_DETAIL_DELETE");
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
        /// ピッキング指示削除プロシジャ
        /// 使用画面：InvPickingUpd
        /// </summary>
        /// <returns></returns>
        public int PickingDelete()
        {
            int rtn = 0;
            ComDB db = new ComDB(_db_type);

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PICKING_NO", _picking_no, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PICKING_DELETE");
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
        /// ピッキング実績プロシジャ
        /// 使用画面：InvPickingAct
        /// </summary>
        /// <returns></returns>
        public int InvPickingAct(ComDB db)
        {
            int rtn = 0;
            //ComDB db = new ComDB(_db_type);

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PICKING_NO", _picking_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PICKING_LINE_NO", _picking_line_no, ComConst.DB_IN);
            db.DbPsetInt("@I_SEQ_NO", _seq_no, ComConst.DB_IN);
            db.DbPsetInt("@I_ACTUAL_SEQ_NO", _actual_seq_no, ComConst.DB_IN);
            db.DbPsetInt("@I_ACT_PICKING_DATE", _act_date, ComConst.DB_IN);
            db.DbPsetDouble("@I_ACT_QTY", _act_qty, ComConst.DB_IN);
            db.DbPsetString("@I_ACT_LOCATION", _to_location, ComConst.DB_IN);
            db.DbPsetString("@I_ACT_LOT_NO", _to_lot_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_IGNORE_HT", _ignore_ht, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();
            rtn = db.DbStored("SP_PICKING_ACTUAL");
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
        /// 出庫処理プロシジャ
        /// 使用画面：InvDisbIM
        /// </summary>
        /// <returns></returns>
        public int InvDisbIM(ComDB db)
        {
            int rtn = 0;
            //ComDB db = new ComDB(_db_type);

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PICKING_NO", _picking_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PICKING_LINE_NO", _picking_line_no, ComConst.DB_IN);
            db.DbPsetInt("@I_SEQ_NO", _seq_no, ComConst.DB_IN);
            db.DbPsetInt("@I_ACTUAL_SEQ_NO", _actual_seq_no, ComConst.DB_IN);
            db.DbPsetInt("@I_ACT_DATE", _act_date, ComConst.DB_IN);
            db.DbPsetDouble("@I_ACT_QTY", _act_qty, ComConst.DB_IN);
            db.DbPsetString("@I_ACT_LOCATION", _to_location, ComConst.DB_IN);
            db.DbPsetString("@I_ACT_LOT_NO", _to_lot_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();
            rtn = db.DbStored("SP_DISB_IM");
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
        /// ピッキングステータスを指示済に変更（出荷時ピッキングリスト発行済）
        /// </summary>
        public int UpdatePickingStatus()
        {
            ComDB db = new ComDB();
            int rtn = 0;
            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("UPDATE PICKING_TRANS ");
            strSQL.Append(" SET ");
            strSQL.Append("  PICKING_STATUS = 10 ");
            strSQL.Append(" WHERE PICKING_STATUS = 0");

            db.DbParametersClear();

            try
            {
                db.DbBeginTrans();

                rtn = db.DbExecute(strSQL.ToString());
                if (rtn != ComConst.FAILED)
                {
                    db.DbCommit();
                    rtn = ComConst.SUCCEED;
                }
                else
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                    db.DbRollback();
                    rtn = ComConst.FAILED;
                }
            }
            catch (Exception ex)
            {
                db.DbRollback();
                _dbmsg = ex.Message;
                _strErr = ex.Message;
                rtn = ComConst.FAILED;
            }

            return rtn;
        }
    }
}
