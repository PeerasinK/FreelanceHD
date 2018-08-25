using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

namespace IMClass
{
    public class HTSimulation
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public HTSimulation()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public HTSimulation(string p_user_id, int p_lang)
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
        protected double _physical_cnt_qty = 0;
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
        protected string _lot_no = "";
        protected int _to_inv_wip_type = 0;
        protected int _to_inv_type = 0;
        protected int _to_supply_type = 0;
        protected int _to_supplied_type = 0;
        protected string _to_mng_no = "";
        protected string _to_whs_cd = "";
        protected string _location = "";
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
        protected string _rcv_no = "";
        protected int _po_line_no = 0;
        protected string _note = "";
        protected string _delv_no = "";
        protected double _cmpl_input_prc = 0;
        protected double _compl_input_amt = 0;
        protected DateTime _approve_date = DateTime.Now;
        protected string _approve_user_id = "";

        protected int _physical_cnt_yymm = 0;
        protected int _page_no = 0;
        protected int _act_date = 0;
        protected int _line_no = 0;
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
        protected int _physical_cnt_status = 0;
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
        protected DateTime _actual_time = DateTime.Now;  // IMV3
        protected string _actual_type = "";    // IMV3
        protected string _resource_cd = "";    // IMV3
        protected string _process_cd = "";    // IMV3
        protected double _compl_qty = 0;  // IMV3
        protected double _hold_qty = 0;  // IMV3
        protected string _worker_id = "";    // IMV3
        protected string _shift_cd = "";    // IMV3
        protected string _down_reason_cd = "";    // IMV3
        protected string _ng_reason_cd = "";    // IMV3
        protected int _process_seq = 0;  // IMV3
        protected int _worker_cnt = 0;  // IMV3
        protected string _act_worker_id1 = "";    // IMV3
        protected string _act_worker_id2 = "";    // IMV3
        protected string _act_worker_id3 = "";    // IMV3
        protected string _act_worker_id4 = "";    // IMV3
        protected string _act_worker_id5 = "";    // IMV3
        protected int _inv_wip_type = 0;
        protected int _actual_cnt = 0;
        protected int _label_type = 0;


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
        public double physical_cnt_qty { get { return _physical_cnt_qty; } set { _physical_cnt_qty = value; } }
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
        public string lot_no { get { return _lot_no; } set { _lot_no = value; } }
        public int to_inv_wip_type { get { return _to_inv_wip_type; } set { _to_inv_wip_type = value; } }
        public int to_inv_type { get { return _to_inv_type; } set { _to_inv_type = value; } }
        public int to_supply_type { get { return _to_supply_type; } set { _to_supply_type = value; } }
        public int to_supplied_type { get { return _to_supplied_type; } set { _to_supplied_type = value; } }
        public string to_mng_no { get { return _to_mng_no; } set { _to_mng_no = value; } }
        public string to_whs_cd { get { return _to_whs_cd; } set { _to_whs_cd = value; } }
        public string location { get { return _location; } set { _location = value; } }
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
        public string rcv_no { get { return _rcv_no; } set { _rcv_no = value; } }
        public int po_line_no { get { return _po_line_no; } set { _po_line_no = value; } }
        public string note { get { return _note; } set { _note = value; } }
        public string delv_no { get { return _delv_no; } set { _delv_no = value; } }
        public double cmpl_input_prc { get { return _cmpl_input_prc; } set { _cmpl_input_prc = value; } }
        public double compl_input_amt { get { return _compl_input_amt; } set { _compl_input_amt = value; } }
        public DateTime approve_date { get { return _approve_date; } set { _approve_date = value; } }
        public string approve_user_id { get { return _approve_user_id; } set { _approve_user_id = value; } }

        public int physical_cnt_yymm { get { return _physical_cnt_yymm; } set { _physical_cnt_yymm = value; } }
        public int page_no { get { return _page_no; } set { _page_no = value; } }
        public int act_date { get { return _act_date; } set { _act_date = value; } }
        public int line_no { get { return _line_no; } set { _line_no = value; } }
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
        public int physical_cnt_status { get { return _physical_cnt_status; } set { _physical_cnt_status = value; } }
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

        public DateTime actual_time { get { return _actual_time; } set { _actual_time = value; } } // IMV3
        public string actual_type { get { return _actual_type; } set { _actual_type = value; } } // IMV3
        public string resource_cd { get { return _resource_cd; } set { _resource_cd = value; } } // IMV3
        public string process_cd { get { return _process_cd; } set { _process_cd = value; } } // IMV3
        public double compl_qty { get { return _compl_qty; } set { _compl_qty = value; } } // IMV3
        public double hold_qty { get { return _hold_qty; } set { _hold_qty = value; } } // IMV3
        public string worker_id { get { return _worker_id; } set { _worker_id = value; } } // IMV3
        public string shift_cd { get { return _shift_cd; } set { _shift_cd = value; } } // IMV3
        public string down_reason_cd { get { return _down_reason_cd; } set { _down_reason_cd = value; } } // IMV3
        public string ng_reason_cd { get { return _ng_reason_cd; } set { _ng_reason_cd = value; } } // IMV3
        public int process_seq { get { return _process_seq; } set { _process_seq = value; } }   // IMV3
        public int worker_cnt { get { return _worker_cnt; } set { _worker_cnt = value; } }   // IMV3
        public string act_worker_id1 { get { return _act_worker_id1; } set { _act_worker_id1 = value; } } // IMV3
        public string act_worker_id2 { get { return _act_worker_id2; } set { _act_worker_id2 = value; } } // IMV3
        public string act_worker_id3 { get { return _act_worker_id3; } set { _act_worker_id3 = value; } } // IMV3
        public string act_worker_id4 { get { return _act_worker_id4; } set { _act_worker_id4 = value; } } // IMV3
        public string act_worker_id5 { get { return _act_worker_id5; } set { _act_worker_id5 = value; } } // IMV3
        public int inv_wip_type { get { return _inv_wip_type; } set { _inv_wip_type = value; } }
        public int actual_cnt { get { return _actual_cnt; } set { _actual_cnt = value; } }
        public int label_type { get { return _label_type; } set { _label_type = value; } }


        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }
        #endregion

        /// <summary>
        /// HT受入対象抽出
        /// 
        /// 使用画面：HTWhsAct
        /// </summary>
        public DataSet Get_HT_WhsList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql    
            strSQL.Append(" SELECT HT.XFER_NO,                                                                          ");
            strSQL.Append(" CASE HT.REQ_TYPE WHEN 31 THEN T.SLIP_NO WHEN 25 THEN T.SLIP_NO WHEN 26 THEN T.SLIP_NO ELSE SUBSTRING(T.SLIP_NO, 1, 7) END RCV_NO,        ");
            strSQL.Append(" HT.ITEM_NO,         I.ITEM_DESC,                  ");
            strSQL.Append(" T.REQ_DATE,         S.DATA_CHAR ITEM_UMSR,                   HT.WHS_CD,                     ");
            strSQL.Append(" HT.LOT_NO,          HT.LOCATION,        HT.PLAN_QTY,                                        ");
            strSQL.Append(" HT.LOT_NO HT_ACT_LOT_NO,   HT.LOCATION HT_ACT_LOCATION,      HT.PLAN_QTY HT_ACT_QTY        ");

            db.DbParametersClear();

            strSQL.Append(" FROM HOUSING_LOT_IF HT                                                                   ");
            strSQL.Append(" INNER JOIN TRANSFER_TRANS T ON T.XFER_NO = HT.XFER_NO                           ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = HT.ITEM_UMSR  ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON I.ITEM_NO = HT.ITEM_NO  ");
            strSQL.Append(" WHERE                                                                                   ");
            strSQL.Append(" HT_SEND_STATUS < 2                                                ");

            if (_rcv_no != "")
            {
                //strSQL.Append(" AND  SUBSTRING(T.SLIP_NO, 1, 7) = @RCV_NO ");
                //strSQL.Append(" AND  (T.PO_NO = @RCV_NO OR T.SLIP_NO = @RCV_NO) "); // 2015.03.03
                strSQL.Append(" AND  (T.PO_NO LIKE @RCV_NO + '%' OR T.SLIP_NO LIKE @RCV_NO + '%') "); // 2015.09.25

                db.DbPsetString("@RCV_NO", _rcv_no);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND HT.WHS_CD = @WHS_CD ");
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            strSQL.Append(" ORDER BY T.SLIP_NO          ");

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
        /// HT棚入れ更新
        /// 
        /// 使用画面：HTWhsAct
        /// </summary>
        public int HT_Act_Whs(ComDB db)
        {
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_IN);
            db.DbPsetString("@I_HT_ACT_LOT_NO", _lot_no, ComConst.DB_IN);
            db.DbPsetString("@I_HT_ACT_LOCATION", _location, ComConst.DB_IN);
            db.DbPsetDouble("@I_HT_ACT_QTY", _act_qty, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

//            db.DbBeginTrans();
            rtn = db.DbStored("SP_HT_ACT_WHS");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
//                db.DbCommit();
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
//                db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// HT仕入先返品対象抽出
        /// 
        /// 使用画面：HTPurReturnAct
        /// </summary>
        public DataSet Get_HT_PurReturnList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql    
            strSQL.Append(" SELECT HT.XFER_NO,                                                                          ");
            strSQL.Append(" HT.RETURN_NO + '-' + LTRIM(STR(HT.RETURN_LINE_NO)) RETURN_NO,        ");
            strSQL.Append(" HT.ITEM_NO,         I.ITEM_DESC,                  ");
            strSQL.Append(" T.REQ_DATE,         S.DATA_CHAR ITEM_UMSR,                   HT.WHS_CD,                     ");
            strSQL.Append(" HT.LOT_NO,          HT.LOCATION,        HT.PLAN_QTY,                                        ");
            strSQL.Append(" HT.LOT_NO HT_ACT_LOT_NO,   HT.LOCATION HT_ACT_LOCATION,      HT.PLAN_QTY HT_ACT_QTY        ");

            db.DbParametersClear();

            strSQL.Append(" FROM VENDOR_RETURN_IF HT                                                                   ");
            strSQL.Append(" INNER JOIN TRANSFER_TRANS T ON T.XFER_NO = HT.XFER_NO                           ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = HT.ITEM_UMSR  ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON I.ITEM_NO = HT.ITEM_NO  ");
            strSQL.Append(" WHERE                                                                                   ");
            strSQL.Append(" HT_SEND_STATUS < 2                                                ");

            if (_rcv_no != "")
            {
                strSQL.Append(" AND  HT.RETURN_NO = @RCV_NO ");
                db.DbPsetString("@RCV_NO", _rcv_no);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND HT.WHS_CD = @WHS_CD ");
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            strSQL.Append(" ORDER BY T.SLIP_NO          ");

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
        /// HT仕入先返品更新
        /// 
        /// 使用画面：HTPurReturnAct
        /// </summary>
        public int HT_Act_PurReturn(ComDB db)
        {
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_IN);
            db.DbPsetString("@I_HT_ACT_LOT_NO", _lot_no, ComConst.DB_IN);
            db.DbPsetString("@I_HT_ACT_LOCATION", _location, ComConst.DB_IN);
            db.DbPsetDouble("@I_HT_ACT_QTY", _act_qty, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //            db.DbBeginTrans();
            rtn = db.DbStored("SP_HT_ACT_PUR_RETURN");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                //                db.DbCommit();
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                //                db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// HTピッキング対象抽出
        /// 
        /// 使用画面：HTPickingAct
        /// </summary>
        public DataSet Get_HT_PickingList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql    
            strSQL.Append(" SELECT HT.PICKING_NO, HT.PICKING_LINE_NO, HT.SEQ_NO, 1 ACTUAL_SEQ_NO,                      ");
            strSQL.Append(" HT.ITEM_NO,          I.ITEM_DESC,        CONVERT(INT, CONVERT(VARCHAR, HT.ENTRY_DATE, 112)) REQ_DATE, ");
            strSQL.Append(" S.DATA_CHAR ITEM_UMSR,                   HT.WHS_CD,       W.WHS_DESC,              ");
            strSQL.Append(" HT.LOT_NO,          HT.LOCATION,        HT.PLAN_QTY,                                        ");
            strSQL.Append(" HT.LOT_NO HT_ACT_LOT_NO,   HT.LOCATION HT_ACT_LOCATION,      HT.PLAN_QTY HT_ACT_QTY        ");

            db.DbParametersClear();

            strSQL.Append(" FROM PICKING_LOT_IF HT                                                                   ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = HT.ITEM_UMSR  ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON I.ITEM_NO = HT.ITEM_NO  ");
            strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON W.WHS_CD = HT.WHS_CD  ");
            strSQL.Append(" WHERE                                                                                   ");
            strSQL.Append(" HT_SEND_STATUS < 2                                                ");

            if (_picking_no != "")
            {
                strSQL.Append(" AND  HT.PICKING_NO = @PICKING_NO ");
                db.DbPsetString("@PICKING_NO", _picking_no);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND HT.WHS_CD = @WHS_CD ");
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            strSQL.Append(" ORDER BY HT.PICKING_NO, HT.PICKING_LINE_NO, HT.SEQ_NO   ");

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
        /// HTピッキング更新
        /// 
        /// 使用画面：HTPickingAct
        /// </summary>
        public int HT_Act_Picking(ComDB db)
        {
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PICKING_NO", _picking_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PICKING_LINE_NO", _picking_line_no, ComConst.DB_IN);
            db.DbPsetInt("@I_SEQ_NO", _seq_no, ComConst.DB_IN);
            db.DbPsetInt("@I_ACTUAL_SEQ_NO", _actual_seq_no, ComConst.DB_IN);
            db.DbPsetString("@I_HT_ACT_LOT_NO", _lot_no, ComConst.DB_IN);
            db.DbPsetString("@I_HT_ACT_LOCATION", _location, ComConst.DB_IN);
            db.DbPsetDouble("@I_HT_ACT_QTY", _act_qty, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //            db.DbBeginTrans();
            rtn = db.DbStored("SP_HT_ACT_PICKING");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                //                db.DbCommit();
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                //                db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        ///  棚卸結果登録
        /// 
        /// 使用画面：HTStockTakingAct
        /// </summary>
        public DataSet Get_ActCountHT()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT COUNT1,COUNT2 FROM                                                 ");
            strSQL.Append(" ( SELECT COUNT(*) COUNT1   FROM                                       ");
            strSQL.Append(" PHISICAL_COUNT_IF  PH                                                    ");
            strSQL.Append(" LEFT JOIN ITEM_MASTER I ON PH.ITEM_NO=I.ITEM_NO                       ");
            strSQL.Append(" WHERE PH.INV_WIP_TYPE=0                                               ");
            strSQL.Append(" AND   PH.INV_TYPE=0                                                   ");
            strSQL.Append(" AND   PH.HT_SEND_STATUS<2                                        ");
            db.DbParametersClear();
            if (_physical_cnt_yymm != 0)
            {
                strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM = @PHYSICAL_CNT_YYMM");
                db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND PH.WHS_CD = @WHS_CD");
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            if (_item_no != "")
            {
                strSQL.Append(" AND PH.ITEM_NO = @ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_page_no != 0)
            {
                strSQL.Append(" AND PH.PAGE_NO = @PAGE_NO");
                db.DbPsetDouble("@PAGE_NO", _page_no);
            }

            // IMV3
            if (_location != "")
            {
                strSQL.Append(" AND PH.LOCATION = @LOCATION");
                db.DbPsetString("@LOCATION", _location);
            }
            strSQL.Append("  ) A ,(                                                               ");
            strSQL.Append(" SELECT COUNT(*) COUNT2 FROM                                           ");
            strSQL.Append(" PHISICAL_COUNT_IF  PH                                                    ");
            strSQL.Append(" LEFT JOIN ITEM_MASTER I ON PH.ITEM_NO=I.ITEM_NO                       ");
            strSQL.Append(" WHERE PH.INV_WIP_TYPE=0                                               ");
            strSQL.Append(" AND   PH.INV_TYPE=0                                                   ");
            strSQL.Append(" AND   PH.HT_SEND_STATUS>=2                                    ");

            db.DbParametersClear();
            if (_physical_cnt_yymm != 0)
            {
                strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM = @PHYSICAL_CNT_YYMM");
                db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND PH.WHS_CD = @WHS_CD");
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            if (_item_no != "")
            {
                strSQL.Append(" AND PH.ITEM_NO = @ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_page_no != 0)
            {
                strSQL.Append(" AND PH.PAGE_NO = @PAGE_NO");
                db.DbPsetDouble("@PAGE_NO", _page_no);
            }
            // IMV3
            if (_location != "")
            {
                strSQL.Append(" AND PH.LOCATION = @LOCATION");
                db.DbPsetString("@LOCATION", _location);
            }
            strSQL.Append("   ) B                                                                   ");

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
        ///  棚卸結果登録
        /// 
        /// 使用画面：HTStockTakingAct
        /// </summary>
        public DataSet Get_ActListHT()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //sql
            strSQL.Append(" SELECT                                                                  ");
            strSQL.Append(" PH.PAGE_NO	,				PH.LINE_NO	,			PH.LOCATION	,       ");
            strSQL.Append(" PH.ITEM_NO	,				I.ITEM_DESC	,			PH.JOC_CD	,       ");
            strSQL.Append(" PH.LOT_NO	,				I.ITEM_UMSR	,       ");
            strSQL.Append(" CASE PH.HT_SEND_STATUS WHEN 0 THEN PH.INV_BAL WHEN 1 THEN PH.INV_BAL ELSE PH.HT_ACT_QTY END INV_BAL,  ");  // 2015.03.31
            //strSQL.Append(" PH.INV_BAL PHYSICAL_CNT_QTY,  ");
            strSQL.Append(" CASE PH.HT_SEND_STATUS WHEN 0 THEN PH.INV_BAL WHEN 1 THEN PH.INV_BAL ELSE PH.HT_ACT_QTY END PHYSICAL_CNT_QTY,  ");  // 2015.03.31
            strSQL.Append(" S.DATA_CHAR AS UMSR_NAME         ");
            strSQL.Append(" , PH.SUPPLY_TYPE, PH.WHS_CD ,         ");
            //strSQL.Append(" PH.INV_BAL PHYSICAL_CNT_QTY1,                                  ");
            strSQL.Append(" CASE PH.HT_SEND_STATUS WHEN 0 THEN PH.INV_BAL WHEN 1 THEN PH.INV_BAL ELSE PH.HT_ACT_QTY END PHYSICAL_CNT_QTY1,  ");  // 2015.03.31
            strSQL.Append(" PH.HT_SEND_STATUS                                                      ");
            strSQL.Append(" FROM  PHISICAL_COUNT_IF	PH                                              ");

            strSQL.Append(" LEFT JOIN   ITEM_MASTER I ON 	PH.ITEM_NO=I.ITEM_NO                    ");
            strSQL.Append(" LEFT JOIN   SYSTEM_PARAMETER S ON I.ITEM_UMSR=S.KEY02                   ");
            strSQL.Append(" AND  S.KEY01='ITEM_UMSR'                                                ");
            strSQL.Append(" WHERE  PH.INV_WIP_TYPE=0                                                ");
            strSQL.Append(" AND    PH.INV_TYPE=0                                                    ");
            //strSQL.Append(" AND    PH.HT_SEND_STATUS < 2                                            ");

            db.DbParametersClear();
            if (_physical_cnt_yymm != 0)
            {
                strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM = @PHYSICAL_CNT_YYMM");
                db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND PH.WHS_CD = @WHS_CD");
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            if (_item_no != "")
            {
                strSQL.Append(" AND PH.ITEM_NO = @ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_page_no != 0)
            {
                strSQL.Append(" AND PH.PAGE_NO = @PAGE_NO");
                db.DbPsetDouble("@PAGE_NO", _page_no);
            }

            // IMV3
            if (_location != "")
            {
                strSQL.Append(" AND PH.LOCATION = @LOCATION");
                db.DbPsetString("@LOCATION", _location);
            }
            if (_lot_no != "")
            {
                strSQL.Append(" AND PH.LOT_NO = @LOT_NO");
                db.DbPsetString("@LOT_NO", _lot_no);
            }

            //if (_physical_cnt_status > -1)
            //{
            //    strSQL.Append(" AND PH.PHYSICAL_CNT_STATUS = @PHYSICAL_CNT_STATUS");
            //    db.DbPsetDouble("@PHYSICAL_CNT_STATUS", _physical_cnt_status);
            //}
            strSQL.Append(" ORDER BY  PH.PAGE_NO ,PH.LINE_NO   ");

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
        ///  棚卸結果登録
        /// 
        /// 使用画面：HTStockTakingAct
        /// </summary>
        public int HTStockTakingAct()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetDouble("@I_PHYSICAL_CNT_YYMM", _physical_cnt_yymm, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_PAGE_NO", _page_no, ComConst.DB_IN);
            db.DbPsetDouble("@I_LINE_NO", _line_no, ComConst.DB_IN);
            db.DbPsetDouble("@I_HT_ACT_QTY", _physical_cnt_qty, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_HT_ACT_STOCKTAKING");
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
        /// HT部材投入実績更新
        /// 
        /// 使用画面：HTProcessAct
        /// </summary>
        public int HT_Material_Input(ComDB db, int mode)
        {
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PROCESS_SEQ", _process_seq, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetString("@I_LOT_NO", _lot_no, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION", _location, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_DESC", _item_desc, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_UMSR", _item_umsr, ComConst.DB_IN);
            db.DbPsetDouble("@I_ACT_QTY", _act_qty, ComConst.DB_IN);
            db.DbPsetInt("@I_INV_WIP_TYPE", _inv_wip_type, ComConst.DB_IN);
            db.DbPsetInt("@I_LABEL_TYPE", _label_type, ComConst.DB_IN);
            db.DbPsetInt("@I_JOB_TYPE", _to_joc_type, ComConst.DB_IN);
            db.DbPsetInt("@I_ACTUAL_CNT", _actual_cnt, ComConst.DB_IN);    // 2015.06.07
            db.DbPsetInt("@I_MODE", mode, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //            db.DbBeginTrans();
            rtn = db.DbStored("SP_HT_MATERIAL_INPUT");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                //                db.DbCommit();
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                //                db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// HT棚卸品目追加
        /// 
        /// 使用画面：HTStockTakingAct
        /// </summary>
        public int HT_Act_Stocktaking_Add()
        {
            int rtn = 0;
            ComDB db = new ComDB(_db_type);

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetInt("@I_PHYSICAL_CNT_YYMM", _physical_cnt_yymm, ComConst.DB_IN);
            db.DbPsetString("@I_LOT_NO", _lot_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION", _location, ComConst.DB_IN);
            db.DbPsetDouble("@I_ACT_QTY", _act_qty, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_HT_ACT_STOCKTAKING_ADD");
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
        ///  製造実績抽出
        /// 
        /// 使用画面：HTProcessAct
        /// </summary>
        public DataSet GetProcessActList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //sql
            strSQL.Append(" SELECT                                                                  ");
            strSQL.Append(" PA.JOB_ORDER_NO,    convert(varchar, PA.ACTUAL_TIME, 111) + ' ' + convert(varchar, PA.ACTUAL_TIME, 108)	ACTUAL_TIME,");
            strSQL.Append(" J.ITEM_NO	,		convert(varchar, PA.ACTUAL_TYPE) ACTUAL_TYPE	,PA.RESOURCE_CD	,       ");
            strSQL.Append(" R.RESOURCE_DESC	,	PA.PROCESS_CD PROCESS_CDX	,			PR.PROCESS_DESC,       ");
            strSQL.Append(" J.JOB_ORDER_QTY,  PA.COMPL_QTY, PA.REJ_QTY, PA.HOLD_QTY, PA.WORKER_ID, PA.SHIFT_CD  ");
            strSQL.Append(" , PA.DOWN_REASON_CD, PA.NG_REASON_CD          ");
            strSQL.Append(" , PA.ACT_WORKER_ID1	,PA.ACT_WORKER_ID2	,PA.ACT_WORKER_ID3		,PA.ACT_WORKER_ID4, PA.ACT_WORKER_ID5	,PA.WORKER_CNT ");  // 2015.08.14
            strSQL.Append(" , J.WS_CD ");   // 2015.08.20
            strSQL.Append(" , CONVERT(VARCHAR,COALESCE(JD.PROCESS_SEQ,0)) + ':' + PA.PROCESS_CD PROCESS_CD "); // 2015.08.20
            strSQL.Append(" , COALESCE(P1.ACTUAL_CNT, COALESCE(P2.ACTUAL_CNT, COALESCE(P3.ACTUAL_CNT,0))) ACTUAL_CNT "); // 2015.08.20

            strSQL.Append(" FROM  PRODUCTION_ACTUAL_IF	PA                                              ");
            strSQL.Append(" LEFT JOIN   JOB_ORDER J ON 	PA.JOB_ORDER_NO=J.JOB_ORDER_NO                    ");
            strSQL.Append(" LEFT JOIN   RESOURCE_MASTER R ON 	R.RESOURCE_CD=PA.RESOURCE_CD AND R.PROCESS_CD = PA.PROCESS_CD ");
            strSQL.Append(" LEFT JOIN   PROCESS_MASTER PR ON 	PR.PROCESS_CD=PA.PROCESS_CD AND PR.WS_CD = J.WS_CD ");
            //strSQL.Append(" LEFT JOIN   JOB_ORDER_DETAIL JD ON 	PA.JOB_ORDER_NO=JD.JOB_ORDER_NO AND PA.RESOURCE_CD = JD.RESOURCE_CD "); // 2015.05.25
            strSQL.Append(" LEFT JOIN   JOB_ORDER_DETAIL JD ON 	PA.JOB_ORDER_NO=JD.JOB_ORDER_NO AND PA.RESOURCE_CD = JD.RESOURCE_CD AND PA.PROCESS_CD = JD.PROCESS_CD"); // 2016.01.27
            //strSQL.Append(" LEFT JOIN   ITEM_MASTER I ON 	PH.ITEM_NO=I.ITEM_NO                    ");
            //strSQL.Append(" LEFT JOIN   SYSTEM_PARAMETER S ON I.ITEM_UMSR=S.KEY02                   ");
            //strSQL.Append(" AND  S.KEY01='ITEM_UMSR'                                                ");
            strSQL.Append(" LEFT JOIN  PRODUCTION_ACTUAL P1 ON P1.JOB_ORDER_NO = PA.JOB_ORDER_NO AND P1.RESOURCE_CD = PA.RESOURCE_CD AND P1.PROCESS_CD = PA.PROCESS_CD AND P1.ACTUAL_TYPE = PA.ACTUAL_TYPE AND P1.ACT_START_TIME = PA.ACTUAL_TIME   ");
            strSQL.Append(" LEFT JOIN  PRODUCTION_ACTUAL P2 ON P2.JOB_ORDER_NO = PA.JOB_ORDER_NO AND P2.RESOURCE_CD = PA.RESOURCE_CD AND P2.PROCESS_CD = PA.PROCESS_CD AND P2.ACTUAL_TYPE = PA.ACTUAL_TYPE+1 AND P2.ACT_START_TIME = PA.ACTUAL_TIME  ");
            strSQL.Append(" LEFT JOIN  PRODUCTION_ACTUAL P3 ON P3.JOB_ORDER_NO = PA.JOB_ORDER_NO AND P3.RESOURCE_CD = PA.RESOURCE_CD AND P3.PROCESS_CD = PA.PROCESS_CD AND P3.ACTUAL_TYPE = PA.ACTUAL_TYPE AND P3.ACT_END_TIME = PA.ACTUAL_TIME  ");
            
            strSQL.Append(" WHERE  1=1                                             ");

            db.DbParametersClear();
            if (_job_order_no != "")
            {
                strSQL.Append(" AND PA.JOB_ORDER_NO = @JOB_ORDER_NO");
                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
            }
            if (_sch_start_date != 0)
            {
                strSQL.Append(" AND convert(varchar, PA.ACTUAL_TIME, 112) >= @SCH_START_DATE");
                db.DbPsetInt("@SCH_START_DATE", _sch_start_date);
            }
            if (_sch_compl_date != 0)
            {
                strSQL.Append(" AND convert(varchar, PA.ACTUAL_TIME, 112) <= @SCH_COMPL_DATE");
                db.DbPsetInt("@SCH_COMPL_DATE", _sch_compl_date);
            }

            strSQL.Append(" ORDER BY  PA.ACTUAL_TIME ");

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
        /// 　対応する製造実績（完成）の抽出
        /// 
        /// 使用画面：HTProcessAct
        /// </summary>
        public DataSet GetProcessActCompl()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //sql
            strSQL.Append(" SELECT                                                                  ");
            strSQL.Append(" PA.JOB_ORDER_NO ");
            strSQL.Append(" , COALESCE(P1.ACTUAL_CNT, 0) ACTUAL_CNT "); // 2015.08.20

            strSQL.Append(" FROM  PRODUCTION_ACTUAL_IF	PA ");

            strSQL.Append(" LEFT JOIN  PRODUCTION_ACTUAL P1 ON P1.JOB_ORDER_NO = PA.JOB_ORDER_NO AND P1.RESOURCE_CD = PA.RESOURCE_CD AND P1.PROCESS_CD = PA.PROCESS_CD AND P1.ACTUAL_TYPE = PA.ACTUAL_TYPE+1 AND P1.ACT_START_TIME = PA.ACTUAL_TIME   ");

            strSQL.Append(" WHERE  PA.ACTUAL_TYPE = @ACTUAL_TYPE ");
            strSQL.Append(" AND PA.JOB_ORDER_NO = @JOB_ORDER_NO");
            strSQL.Append(" AND PA.RESOURCE_CD = @RESOURCE_CD");
            strSQL.Append(" AND PA.PROCESS_CD = @PROCESS_CD");
            strSQL.Append(" AND PA.ACTUAL_TIME = @ACTUAL_TIME");

            db.DbParametersClear();
            db.DbPsetString("@ACTUAL_TYPE", _actual_type);
            db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
            db.DbPsetString("@RESOURCE_CD", _resource_cd);
            db.DbPsetString("@PROCESS_CD", _process_cd);
            db.DbPsetDate("@ACTUAL_TIME", _actual_time);

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
        ///  部材投入抽出
        /// 
        /// 使用画面：HTProcessAct
        /// </summary>
        public DataSet GetMaterialInputList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //sql
            //strSQL.Append(" SELECT   ");
            strSQL.Append(" SELECT DISTINCT "); // 2015.06.15
            strSQL.Append(" M.JOB_ORDER_NO, M.PROCESS_CD, M.LOT_NO, M.ITEM_NO, M.ITEM_DESC, M.ITEM_UMSR, M.ACT_QTY, M.LABEL_TYPE, M.JOB_TYPE, '' UPD_FLAG, '1' INV_WIP_TYPE, '' LOCATION ");

            strSQL.Append(" FROM  MATERIAL_INPUT M  ");
            //strSQL.Append(" LEFT JOIN INVENTORY_DETAIL INV ON INV.LOT_NO = M.LOT_NO AND INV.ITEM_NO = M.ITEM_NO");

            db.DbParametersClear();

            strSQL.Append(" WHERE  1=1                                             ");
            strSQL.Append(" AND M.JOB_TYPE = @JOB_TYPE ");  // 0:Prod,1:Premix
            db.DbPsetInt("@JOB_TYPE", _to_joc_type);

            if (_job_order_no != "")
            {
                strSQL.Append(" AND M.JOB_ORDER_NO = @JOB_ORDER_NO");
                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
            }
            if (_process_cd != "")
            {
                strSQL.Append(" AND M.PROCESS_CD = @PROCESS_CD");
                db.DbPsetString("@PROCESS_CD", _process_cd);
            }
            if (_actual_cnt != 0)
            {
                strSQL.Append(" AND M.ACTUAL_CNT = @ACTUAL_CNT");   // 2015.05.13
                db.DbPsetInt("@ACTUAL_CNT", _actual_cnt);
            }

            strSQL.Append(" ORDER BY  M.ITEM_NO, M.LOT_NO ");

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
        ///  製造実績登録
        /// 
        /// 使用画面：HTProcessAct
        /// </summary>
        public int HTProcessAct(int mode)
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db.DbPsetDate("@I_ACTUAL_TIME", _actual_time, ComConst.DB_IN);
            db.DbPsetString("@I_ACTUAL_TYPE", _actual_type, ComConst.DB_IN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_COMPL_QTY", _compl_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_REJ_QTY", _rej_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_HOLD_QTY", _hold_qty, ComConst.DB_IN);
            db.DbPsetString("@I_WORKER_ID", _worker_id, ComConst.DB_IN);
            db.DbPsetString("@I_SHIFT_CD", _shift_cd, ComConst.DB_IN);
            db.DbPsetString("@I_DOWN_REASON_CD", _down_reason_cd, ComConst.DB_IN);
            db.DbPsetString("@I_NG_REASON_CD", _ng_reason_cd, ComConst.DB_IN);
            db.DbPsetString("@I_ACT_WORKER_ID1", _act_worker_id1, ComConst.DB_IN);    // 2015.08.14
            db.DbPsetString("@I_ACT_WORKER_ID2", _act_worker_id2, ComConst.DB_IN);    // 2015.08.14
            db.DbPsetString("@I_ACT_WORKER_ID3", _act_worker_id3, ComConst.DB_IN);    // 2015.08.14
            db.DbPsetString("@I_ACT_WORKER_ID4", _act_worker_id4, ComConst.DB_IN);    // 2015.08.14
            db.DbPsetString("@I_ACT_WORKER_ID5", _act_worker_id5, ComConst.DB_IN);    // 2015.08.14
            db.DbPsetInt("@I_WORKER_CNT", _worker_cnt, ComConst.DB_IN);    // 2015.08.14
            db.DbPsetInt("@I_MODE", mode, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_HT_ACT_PROCESS");
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
        /// 製造実績の取得
        /// HTProcessAct
        /// </summary>
        public DataSet GetProdAct()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT '0' TYPE,                                      ");
            strSQL.Append("  P.JOB_ORDER_NO, P.ITEM_NO, COALESCE(JO.ITEM_DESC,I.ITEM_DESC) ITEM_DESC, P.PROCESS_CD, PR.PROCESS_DESC,");
            strSQL.Append("  P.RESOURCE_CD, RS.RESOURCE_DESC,");
            strSQL.Append("  convert(varchar, P.ACT_START_TIME, 111) + ' ' + convert(varchar, P.ACT_START_TIME, 108) ACT_START_TIME,");
            strSQL.Append("  convert(varchar, P.ACT_END_TIME, 111) + ' ' + convert(varchar, P.ACT_END_TIME, 108) ACT_END_TIME,");
            strSQL.Append("  CASE P.ACTUAL_TYPE WHEN 12 THEN ACT_SETUP_TIME WHEN 22 THEN ACT_WORK_TIME WHEN 32 THEN ACT_BREAK_TIME WHEN 42 THEN ACT_AFTER_SETUP_TIME ELSE 0 END ACT_TIME,");
            strSQL.Append("  P.COMPL_QTY,  P.REJ_QTY,  (CASE P.END_WORKER_ID WHEN '' THEN P.START_WORKER_ID ELSE P.END_WORKER_ID END) WORKER_ID,  S2.DATA_CHAR AS WORKER_DESC,  DW.DOWN_REASON_DESC,  NG.NG_REASON_DESC,");
            strSQL.Append("  S1.DATA_CHAR AS UMSR_NAME, convert(varchar, P.ACTUAL_TYPE) ACTUAL_TYPE     ");

            strSQL.Append(" FROM PRODUCTION_ACTUAL P                                                                            ");
            strSQL.Append(" LEFT JOIN JOB_ORDER JO ON JO.JOB_ORDER_NO=P.JOB_ORDER_NO                                              ");
            strSQL.Append(" LEFT JOIN PROCESS_MASTER PR ON P.WS_CD=PR.WS_CD AND P.PROCESS_CD = PR.PROCESS_CD            ");
            strSQL.Append(" LEFT JOIN RESOURCE_MASTER RS ON P.RESOURCE_CD = RS.RESOURCE_CD ");  // 
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON    S1.KEY01='ITEM_UMSR'  AND P.ITEM_UMSR = S1.KEY02    ");
            strSQL.Append(" LEFT JOIN PROCESS_NG_REASON_MASTER NG ON P.WS_CD=NG.WS_CD AND P.PROCESS_CD = NG.PROCESS_CD AND P.NG_REASON_CD = NG.NG_REASON_CD ");
            strSQL.Append(" LEFT JOIN DOWN_REASON_MASTER DW ON P.RESOURCE_CD=DW.RESOURCE_CD AND P.DOWN_REASON_CD = DW.DOWN_REASON_CD ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S2 ON    S2.KEY01='WORKER_CD'  AND (CASE P.END_WORKER_ID WHEN '' THEN P.START_WORKER_ID ELSE P.END_WORKER_ID END) = S2.KEY02    ");
            strSQL.Append(" LEFT JOIN ITEM_MASTER I ON P.ITEM_NO=I.ITEM_NO                                              ");
            strSQL.Append(" WHERE  1=1  ");

            db.DbParametersClear();

            if (_job_order_no != "")
            {
                strSQL.Append("   AND P.JOB_ORDER_NO        =@JOB_ORDER_NO");
                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
            }
            if (_item_no != "")
            {
                strSQL.Append("   AND P.ITEM_NO        =@ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_process_cd != "")
            {
                strSQL.Append("   AND P.PROCESS_CD        =@PROCESS_CD");
                db.DbPsetString("@PROCESS_CD", _process_cd);
            }
            //if (_resource_cd != "")
            //{
            //    strSQL.Append("   AND P.RESOURCE_CD        =@RESOURCE_CD");
            //    db.DbPsetString("@RESOURCE_CD", _resource_cd);
            //}
            if (_actual_type != "")
            {

                strSQL.Append("   AND P.ACTUAL_TYPE = @ACTUAL_TYPE");
                db.DbPsetString("@ACTUAL_TYPE", _actual_type);
            }
            if (_process_seq != 0)
            {
                strSQL.Append("   AND P.PROCESS_SEQ = @PROCESS_SEQ");   // 2015.05.25
                db.DbPsetInt("@PROCESS_SEQ", _process_seq);   // 2015.05.25
            }
            strSQL.Append(" ORDER BY 1, 9, 2");

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
