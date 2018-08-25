using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// クラス
/// </summary>
namespace IMClass
{
    public class Housing
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Housing()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Housing(string p_user_id, int p_lang)
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
        /// 
        /// </summary>
        protected string _db_type = "";
        protected int _lang = 1;
        
        protected int _xfer_status = 0;
        protected string _req_type = "";
        protected DateTime _req_date = DateTime.Now;
        protected string _req_pgm = "";
        protected string _req_user_id = "";
        protected int _trans_date	= 0;
        protected string _slip_no = "";
        protected int _slip_line_no = 0;
        protected int _slip_date = 0;
        protected int _slip_print_flag = 0;
        protected string _slip_issue_no = "";
        protected int _slip_issue_date = 0;
        protected string _xfer_no = "";       
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
        protected string _buyer_desc = "";
        protected int _auto_type = 0;
        //protected double _qty_pur_umsr = 0;
             
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
        public string buyer_desc { get { return _buyer_desc; } set { _buyer_desc = value; } }
        public int auto_type { get { return _auto_type; } set { _auto_type = value; } }
        //public double qty_pur_umsr { get { return _qty_pur_umsr; } set { _qty_pur_umsr = value; } }

        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date        {            get { return _chg_date; }            set { _chg_date = value; }        }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }
        #endregion

        /// <summary>
        /// 入庫対象データを検索
        /// 
        /// 使用画面：InvRcvWhs
        /// </summary>
        public DataSet GetPurHousingList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                  ");
            strSQL.Append(" T.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),T.PO_LINE_NO),3) AS PO_NO,       ");
            strSQL.Append(" T.XFER_SCH_DATE,        T.ITEM_NO,      T.ITEM_DESC                     ");
            //2009.09.08 ADD
            strSQL.Append(" ,T.QTY_PUR_UMSR,    S2.DATA_CHAR PUR_UMSR                               ");
            //strSQL.Append(" ,T.INST_QTY,        S.DATA_CHAR ITEM_UMSR,  T.TO_LOCATION,  T.TO_LOT_NO ");                       //del by ubiq-sai 2012/02/01
            strSQL.Append(" ,(T.INST_QTY-T.ACT_QTY) INST_QTY,        S.DATA_CHAR ITEM_UMSR,  T.TO_LOCATION,  T.TO_LOT_NO ");    //add by ubiq-sai 2012/02/01
            strSQL.Append(" ,T.TO_JOC_CD,       T.TO_WHS_CD,            T.XFER_NO        ");    
        
            //add by wanghui 2010/3/11 start
            strSQL.Append(" , T.SCH_ID ,ST.DATA_CHAR SCH_NM");
            //add by wanghui 2010/3/11 end
            strSQL.Append(" , CASE T.TO_LOT_NO WHEN '' THEN convert(varchar,convert(int, T.CMPL_INPUT_PRC)) + '/' + convert(varchar,convert(int, T.CMPL_INPUT_AMT)) + '-' +  ");  // IMV3
            strSQL.Append(" convert(varchar,convert(int, T.APPROVE_USER_ID)+convert(int, T.CMPL_INPUT_PRC)-1) + '/' + convert(varchar,convert(int, T.CMPL_INPUT_AMT)) ");  // IMV3
            strSQL.Append(" ELSE convert(varchar,convert(int, T.CMPL_INPUT_PRC)) + '/' + convert(varchar,convert(int, T.CMPL_INPUT_AMT)) END CARTON ");  // IMV3

            
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                //edit by wanghui 2010/3/11 start
                //strSQL.Append(" FROM TRANSFER_TRANS T,SYSTEM_PARAMETER S ");
                //strSQL.Append(" WHERE ");
                //strSQL.Append(" T.REQ_TYPE = '11' AND T.XFER_STATUS < 20 ");
                //strSQL.Append("  AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");

                strSQL.Append(" FROM TRANSFER_TRANS T,SYSTEM_PARAMETER S,SYSTEM_PARAMETER S2, SYSTEM_PARAMETER ST ");
                strSQL.Append(" WHERE ");
                strSQL.Append(" T.REQ_TYPE = '11' AND T.XFER_STATUS < 20 ");
                strSQL.Append("  AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");
                strSQL.Append("  AND S2.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T2.PUR_UMSR ");
                strSQL.Append("  AND ST.KEY01 = 'SCH_ID' AND ST.KEY02 = T.SCH_ID ");
                //edit by wanghui 2010/3/11 end
                if (po_no != "")
                {
                    strSQL.Append(" AND T.PO_NO = :PO_NO ");
                    db.DbPsetString("PO_NO", _po_no);
                }
                if (from_vc_cd != "")
                {
                    strSQL.Append(" AND T.FROM_VC_CD = :FROM_VC_CD ");
                    db.DbPsetString("FROM_VC_CD", _from_vc_cd);
                }
                if (to_whs_cd != "")
                {
                    strSQL.Append(" AND T.TO_WHS_CD = :TO_WHS_CD ");
                    db.DbPsetString("TO_WHS_CD", _to_whs_cd);
                }
                if (item_no != "")
                {
                    strSQL.Append(" AND T.ITEM_NO = :ITEM_NO ");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (to_joc_cd != "")
                {
                    strSQL.Append(" AND T.TO_JOC_CD = :TO_JOC_CD ");
                    db.DbPsetString("TO_JOC_CD", _to_joc_cd);
                }                
                if (xfer_sch_date_from != 0)
                {
                    strSQL.Append(" AND T.XFER_SCH_DATE >= :XFER_SCH_DATE_FROM ");
                    db.DbPsetInt("XFER_SCH_DATE_FROM", _xfer_sch_date_from);
                }
                if (xfer_sch_date_to != 0)
                {
                    strSQL.Append(" AND T.XFER_SCH_DATE <= :XFER_SCH_DATE_TO ");
                    db.DbPsetInt("XFER_SCH_DATE_TO", _xfer_sch_date_to);
                }

                //add by wanghui 2010/3/12 start
                if (sch_id != "")
                {
                    strSQL.Append(" AND T.SCH_ID = : SCH_ID ");
                    db.DbPsetString("SCH_ID", sch_id);
                }
                //add by wanghui 2010/3/12 end
            }
            else
            {
                strSQL.Append(" FROM TRANSFER_TRANS T                                   ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'   ");
                strSQL.Append(" AND S.KEY02 = T.ITEM_UMSR                               ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'ITEM_UMSR'   ");
                strSQL.Append(" AND S2.KEY02 = T.PUR_UMSR                               ");
                //edit by wanghui 2010/3/11 strat
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER ST ON ST.KEY01 = 'SCH_ID'   ");
                strSQL.Append(" AND ST.KEY02 = T.SCH_ID                               ");
                //edit by wanghui 2010/3/11 end
                strSQL.Append(" WHERE                                                   ");
                strSQL.Append(" T.REQ_TYPE = '11' AND T.XFER_STATUS < 20                ");

                db.DbParametersClear();

                if (po_no != "")
                {
                    //strSQL.Append(" AND T.PO_NO = @PO_NO ");
                    strSQL.Append("   AND (T.PO_NO = @PO_NO OR T.SLIP_NO = @PO_NO) "); // 2015.03.03

                    db.DbPsetString("@PO_NO", _po_no);
                }
                if (from_vc_cd != "")
                {
                    strSQL.Append(" AND T.FROM_VC_CD = @FROM_VC_CD ");
                    db.DbPsetString("@FROM_VC_CD", _from_vc_cd);
                }
                if (to_whs_cd != "")
                {
                    strSQL.Append(" AND T.TO_WHS_CD = @TO_WHS_CD ");
                    db.DbPsetString("@TO_WHS_CD", _to_whs_cd);
                }
                if (item_no != "")
                {
                    strSQL.Append(" AND T.ITEM_NO = @ITEM_NO ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (to_joc_cd != "")
                {
                    strSQL.Append(" AND T.TO_JOC_CD = @TO_JOC_CD ");
                    db.DbPsetString("@TO_JOC_CD", _to_joc_cd);
                }               
                if (xfer_sch_date_from != 0)
                {
                    strSQL.Append(" AND T.XFER_SCH_DATE >= @XFER_SCH_DATE_FROM ");
                    db.DbPsetInt("@XFER_SCH_DATE_FROM", _xfer_sch_date_from);
                }
                if (xfer_sch_date_to != 0)
                {
                    strSQL.Append(" AND T.XFER_SCH_DATE <= @XFER_SCH_DATE_TO ");
                    db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
                }
                //add by wanghui 2010/3/12 start
                if (sch_id != "")
                {
                    strSQL.Append(" AND T.SCH_ID = @SCH_ID ");
                    db.DbPsetString("@SCH_ID", sch_id);
                }
                //add by wanghui 2010/3/12 end
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
        /// 入庫対象データHT実績を検索
        /// 
        /// 使用画面：InvRcvWhs
        /// </summary>
        public DataSet GetPurHousingHTList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                   ");
            strSQL.Append(" T.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),T.PO_LINE_NO),3) AS PO_NO,       ");
            strSQL.Append(" T.XFER_SCH_DATE,        T.ITEM_NO,      T.ITEM_DESC                     ");
            strSQL.Append(" ,T.QTY_PUR_UMSR,    S2.DATA_CHAR PUR_UMSR                               ");
            strSQL.Append(" ,HT.HT_ACT_QTY INST_QTY,        S.DATA_CHAR ITEM_UMSR,  HT_ACT_LOCATION TO_LOCATION,HT_ACT_LOT_NO TO_LOT_NO ");
            strSQL.Append(" ,T.TO_JOC_CD,       T.TO_WHS_CD,            T.XFER_NO        ");
            
            strSQL.Append(" , T.SCH_ID ,ST.DATA_CHAR SCH_NM");
            strSQL.Append(" , CASE T.TO_LOT_NO WHEN '' THEN convert(varchar,convert(int, T.CMPL_INPUT_PRC)) + '/' + convert(varchar,convert(int, T.CMPL_INPUT_AMT)) + '-' +  ");  // IMV3
            strSQL.Append(" convert(varchar,convert(int, T.APPROVE_USER_ID)+convert(int, T.CMPL_INPUT_PRC)-1) + '/' + convert(varchar,convert(int, T.CMPL_INPUT_AMT)) ");  // IMV3
            strSQL.Append(" ELSE convert(varchar,convert(int, T.CMPL_INPUT_PRC)) + '/' + convert(varchar,convert(int, T.CMPL_INPUT_AMT)) END CARTON ");  // IMV3

            db.DbParametersClear();

            strSQL.Append(" FROM HOUSING_LOT_IF HT ");
            strSQL.Append(" INNER JOIN TRANSFER_TRANS T ON T.XFER_NO = HT.XFER_NO AND T.REQ_TYPE = HT.REQ_TYPE ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'ITEM_UMSR' AND S2.KEY02 = T.PUR_UMSR ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER ST ON ST.KEY01 = 'SCH_ID'   ");
            strSQL.Append(" AND ST.KEY02 = T.SCH_ID                               ");
            strSQL.Append(" WHERE ");
            strSQL.Append(" HT.REQ_TYPE = '11' AND HT.HT_SEND_STATUS < 3 AND HT.HT_ACT_QTY > 0 ");

            if (po_no != "")
            {
                //strSQL.Append(" AND T.PO_NO = @PO_NO ");
                strSQL.Append("   AND (T.PO_NO = @PO_NO OR T.SLIP_NO = @PO_NO) "); // 2015.03.03

                db.DbPsetString("@PO_NO", _po_no);
            }
            if (from_ws_cd != "")
            {
                strSQL.Append(" AND T.FROM_WS_CD = @FROM_WS_CD ");
                db.DbPsetString("@FROM_WS_CD", _from_ws_cd);
            }
            if (to_whs_cd != "")
            {
                strSQL.Append(" AND T.TO_WHS_CD = @TO_WHS_CD ");
                db.DbPsetString("@TO_WHS_CD", _to_whs_cd);
            }
            if (item_no != "")
            {
                strSQL.Append(" AND T.ITEM_NO = @ITEM_NO ");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (to_joc_cd != "")
            {
                strSQL.Append(" AND T.TO_JOC_CD = @TO_JOC_CD ");
                db.DbPsetString("@TO_JOC_CD", _to_joc_cd);
            }
            if (to_lot_no != "")
            {
                strSQL.Append(" AND T.TO_LOT_NO = @TO_LOT_NO ");
                db.DbPsetString("@TO_LOT_NO", _to_lot_no);
            }
            if (xfer_sch_date != 0)
            {
                strSQL.Append(" AND T.XFER_SCH_DATE <= @XFER_SCH_DATE ");
                db.DbPsetInt("@XFER_SCH_DATE", _xfer_sch_date);
            }
            //add by wanghui 2010/4/2 start
            if (sch_id != "")
            {
                strSQL.Append(" AND T.SCH_ID = @SCH_ID ");
                db.DbPsetString("@SCH_ID", sch_id);
            }
            //add by wanghui 2010/4/2 end

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
        /// 使用画面：InvRcvWhs
        /// </summary>
        public int GetPurHousingData()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append(" SELECT                                                                                          ");
            strSQL.Append(" T.PO_NO,            T.PO_LINE_NO,       T.ITEM_NO,      T.ITEM_DESC,        T.FROM_VC_CD        ");
            strSQL.Append(" ,V.VENDOR_NAME,     P.PO_DUE_DATE,      P.PO_QTY,       S.DATA_CHAR PO_UMSR,T.RECV_QTY_PUR_UMSR ");
            strSQL.Append(" ,S2.DATA_CHAR PUR_UMSR,P.PO_PRC,        S3.DATA_CHAR PO_CUR,P.PO_AMT,       T.TO_JOC_CD         ");
            strSQL.Append(" ,T.TO_WHS_CD,       P.PO_NOTE,          P.SCH_ID,       P.BUYER_CD,         P.INSP_CD           ");
            //2009.09.08 ADD
            strSQL.Append(" ,T.QTY_PUR_UMSR                                                                                 ");
            //strSQL.Append(" ,I.LOT_CNTL_FLAG,   T.INST_QTY,         S4.DATA_CHAR ITEM_UMSR,             T.SLIP_NO         ");   //Del by Ubiq-Sai 2012.02.01
            strSQL.Append(" ,I.LOT_CNTL_FLAG,   (T.INST_QTY-T.ACT_QTY) INST_QTY,    S4.DATA_CHAR ITEM_UMSR,   T.SLIP_NO     ");   //Add by Ubiq-Sai 2012.02.01
            strSQL.Append(" ,T.TO_LOCATION,     T.TO_LOT_NO,        S5.DATA_CHAR SCH_DESC,           S6.DATA_CHAR BUYER_DESC");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM TRANSFER_TRANS T, VENDOR_MASTER V, PUR_ORDER P,ITEM_MASTER I, ");
                strSQL.Append(" SYSTEM_PARAMETER S,SYSTEM_PARAMETER S2,SYSTEM_PARAMETER S3,SYSTEM_PARAMETER S4 ");
                strSQL.Append(" WHERE T.XFER_NO = :XFER_NO ");
                strSQL.Append("  AND T.ITEM_NO = I.ITEM_NO(+) ");
                strSQL.Append("  AND T.ORDER_NO = P.ORDER_NO ");
                strSQL.Append("  AND T.FROM_VC_CD = V.VENDOR_CD(+) ");
                strSQL.Append("  AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = P.PO_UMSR ");
                strSQL.Append("  AND S2.KEY01 = 'ITEM_UMSR' AND S2.KEY02 = T.PUR_UMSR ");
                strSQL.Append("  AND S3.KEY01 = 'CURRENCY_CD' AND S3.KEY02 = P.PO_CUR ");
                strSQL.Append("  AND S4.KEY01 = 'ITEM_UMSR' AND S4.KEY02 = T.ITEM_UMSR ");
                
                db.DbParametersClear();
                db.DbPsetString("XFER_NO", _xfer_no);
            }
            else
            {
                strSQL.Append(" FROM TRANSFER_TRANS T                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON T.ITEM_NO = I.ITEM_NO                                  ");
                strSQL.Append(" INNER JOIN PUR_ORDER P ON T.PO_NO = P.PO_NO AND T.PO_LINE_NO = P.PO_LINE_NO             ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON T.FROM_VC_CD = V.VENDOR_CD                           ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = P.PO_UMSR     ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'ITEM_UMSR' AND S2.KEY02 = T.PUR_UMSR ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S3 ON S3.KEY01 = 'CURRENCY_CD' AND S3.KEY02 = P.PO_CUR ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S4 ON S4.KEY01 = 'ITEM_UMSR' AND S4.KEY02 = T.ITEM_UMSR");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S5 ON S5.KEY01 = 'SCH_ID' AND S5.KEY02 = P.SCH_ID      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S6 ON S6.KEY01 = 'BUYER_CD' AND S6.KEY02 = P.BUYER_CD  ");

                strSQL.Append(" WHERE T.XFER_NO = @XFER_NO ");

                db.DbParametersClear();
                db.DbPsetString("@XFER_NO", _xfer_no);
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
                _item_no = db.Row("ITEM_NO");
                _item_desc = db.Row("ITEM_DESC");
                _from_vc_cd = db.Row("FROM_VC_CD");
                _vendor_name = db.Row("VENDOR_NAME");
                _po_due_date = int.Parse(db.Row("PO_DUE_DATE"));
                _po_qty = double.Parse(db.Row("PO_QTY"));
                _po_umsr = db.Row("PO_UMSR");
                _recv_qty_pur_umsr = double.Parse(db.Row("RECV_QTY_PUR_UMSR"));
                _pur_umsr = db.Row("PUR_UMSR");
                _po_prc = double.Parse(db.Row("PO_PRC"));
                _po_cur = db.Row("PO_CUR");
                _po_amt = double.Parse(db.Row("PO_AMT"));
                _to_joc_cd = db.Row("TO_JOC_CD");
                _to_whs_cd = db.Row("TO_WHS_CD");
                _po_note = db.Row("PO_NOTE");
                _sch_id = db.Row("SCH_ID");
                _buyer_cd = db.Row("BUYER_CD");
                _insp_cd = db.Row("INSP_CD");
                _lot_cntl_flag = int.Parse(db.Row("LOT_CNTL_FLAG"));
                _inst_qty = double.Parse(db.Row("INST_QTY"));
                _item_umsr = db.Row("ITEM_UMSR");
                _slip_no = db.Row("SLIP_NO");
                _to_location = db.Row("TO_LOCATION");
                _to_lot_no = db.Row("TO_LOT_NO");
                _sch_name = db.Row("SCH_DESC");
                _buyer_desc = db.Row("BUYER_DESC");
                _qty_pur_umsr = double.Parse(db.Row("QTY_PUR_UMSR"));
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// 振替依頼データを検索
        /// 
        /// 使用画面：InvRcvWhs
        /// </summary>
        public int GetPurHousingHTData()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append(" SELECT                                                                                          ");
            strSQL.Append(" T.PO_NO,            T.PO_LINE_NO,       T.ITEM_NO,      T.ITEM_DESC,        T.FROM_VC_CD        ");
            strSQL.Append(" ,V.VENDOR_NAME,     P.PO_DUE_DATE,      P.PO_QTY,       S.DATA_CHAR PO_UMSR,T.RECV_QTY_PUR_UMSR ");
            strSQL.Append(" ,S2.DATA_CHAR PUR_UMSR,P.PO_PRC,        S3.DATA_CHAR PO_CUR,P.PO_AMT,       T.TO_JOC_CD         ");
            strSQL.Append(" ,T.TO_WHS_CD,       P.PO_NOTE,          P.SCH_ID,       P.BUYER_CD,         P.INSP_CD           ");
            //2009.09.08 ADD
            strSQL.Append(" ,T.QTY_PUR_UMSR                                                                                 ");
            //strSQL.Append(" ,I.LOT_CNTL_FLAG,   T.INST_QTY,         S4.DATA_CHAR ITEM_UMSR,             T.SLIP_NO         ");   //Del by Ubiq-Sai 2012.02.01
            strSQL.Append(" ,I.LOT_CNTL_FLAG,   HT.HT_ACT_QTY INST_QTY,    S4.DATA_CHAR ITEM_UMSR,   T.SLIP_NO     ");   //Add by Ubiq-Sai 2012.02.01
            strSQL.Append(" ,HT_ACT_LOCATION TO_LOCATION,HT_ACT_LOT_NO TO_LOT_NO,        S5.DATA_CHAR SCH_DESC,           S6.DATA_CHAR BUYER_DESC");

            strSQL.Append(" FROM HOUSING_LOT_IF HT ");
            strSQL.Append(" INNER JOIN TRANSFER_TRANS T ON T.XFER_NO = HT.XFER_NO AND T.REQ_TYPE = HT.REQ_TYPE ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON T.ITEM_NO = I.ITEM_NO                                  ");
            strSQL.Append(" INNER JOIN PUR_ORDER P ON T.PO_NO = P.PO_NO AND T.PO_LINE_NO = P.PO_LINE_NO             ");
            strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON T.FROM_VC_CD = V.VENDOR_CD                           ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = P.PO_UMSR     ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'ITEM_UMSR' AND S2.KEY02 = T.PUR_UMSR ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S3 ON S3.KEY01 = 'CURRENCY_CD' AND S3.KEY02 = P.PO_CUR ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S4 ON S4.KEY01 = 'ITEM_UMSR' AND S4.KEY02 = T.ITEM_UMSR");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S5 ON S5.KEY01 = 'SCH_ID' AND S5.KEY02 = P.SCH_ID      ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S6 ON S6.KEY01 = 'BUYER_CD' AND S6.KEY02 = P.BUYER_CD  ");

            strSQL.Append(" WHERE T.XFER_NO = @XFER_NO ");

            db.DbParametersClear();
            db.DbPsetString("@XFER_NO", _xfer_no);

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
                _item_no = db.Row("ITEM_NO");
                _item_desc = db.Row("ITEM_DESC");
                _from_vc_cd = db.Row("FROM_VC_CD");
                _vendor_name = db.Row("VENDOR_NAME");
                _po_due_date = int.Parse(db.Row("PO_DUE_DATE"));
                _po_qty = double.Parse(db.Row("PO_QTY"));
                _po_umsr = db.Row("PO_UMSR");
                _recv_qty_pur_umsr = double.Parse(db.Row("RECV_QTY_PUR_UMSR"));
                _pur_umsr = db.Row("PUR_UMSR");
                _po_prc = double.Parse(db.Row("PO_PRC"));
                _po_cur = db.Row("PO_CUR");
                _po_amt = double.Parse(db.Row("PO_AMT"));
                _to_joc_cd = db.Row("TO_JOC_CD");
                _to_whs_cd = db.Row("TO_WHS_CD");
                _po_note = db.Row("PO_NOTE");
                _sch_id = db.Row("SCH_ID");
                _buyer_cd = db.Row("BUYER_CD");
                _insp_cd = db.Row("INSP_CD");
                _lot_cntl_flag = int.Parse(db.Row("LOT_CNTL_FLAG"));
                _inst_qty = double.Parse(db.Row("INST_QTY"));
                _item_umsr = db.Row("ITEM_UMSR");
                _slip_no = db.Row("SLIP_NO");
                _to_location = db.Row("TO_LOCATION");
                _to_lot_no = db.Row("TO_LOT_NO");
                _sch_name = db.Row("SCH_DESC");
                _buyer_desc = db.Row("BUYER_DESC");
                _qty_pur_umsr = double.Parse(db.Row("QTY_PUR_UMSR"));
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// 入庫対象データを検索
        /// 
        /// 使用画面：InvComplWhs
        /// </summary>
        public DataSet GetComplHousingList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                   ");
            strSQL.Append(" T.PO_NO,T.XFER_SCH_DATE,T.ITEM_NO,T.ITEM_DESC,T.FROM_WS_CD,T.INST_QTY,  ");
            //strSQL.Append(" S.DATA_CHAR ITEM_UMSR,T.INST_QTY,T.TO_LOCATION,T.TO_LOT_NO,T.TO_JOC_CD, ");                       //Del 2012.02.01 Ubiq-Sai
            strSQL.Append(" S.DATA_CHAR ITEM_UMSR,(T.INST_QTY - T.ACT_QTY) ACT_QTY,T.TO_LOCATION,T.TO_LOT_NO,T.TO_JOC_CD, ");  //Add 2012.02.01 Ubiq-Sai
            strSQL.Append(" T.TO_WHS_CD,T.XFER_NO,W.WS_DESC                                         ");

            //add by wanghui 2010/3/12 start
            strSQL.Append(" , T.SCH_ID ,ST.DATA_CHAR SCH_NM");
            //add by wanghui 2010/3/12 end
            strSQL.Append(" , CASE T.TO_LOT_NO WHEN '' THEN convert(varchar,convert(int, T.CMPL_INPUT_PRC)) + '/' + convert(varchar,convert(int, T.CMPL_INPUT_AMT)) + '-' +  ");  // IMV3
            strSQL.Append(" convert(varchar,convert(int, T.APPROVE_USER_ID)+convert(int, T.CMPL_INPUT_PRC)-1) + '/' + convert(varchar,convert(int, T.CMPL_INPUT_AMT)) ");  // IMV3
            strSQL.Append(" ELSE convert(varchar,convert(int, T.CMPL_INPUT_PRC)) + '/' + convert(varchar,convert(int, T.CMPL_INPUT_AMT)) END CARTON ");  // IMV3
     
            if (_db_type == "ORACLE")
            {              
                db.DbParametersClear(); 
                //edit by wanghui 2010/3/12 start
                //strSQL.Append(" FROM TRANSFER_TRANS T,SYSTEM_PARAMETER S ");
                //strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON W.WS_CD = T.FROM_WS_CD ");
                //strSQL.Append(" WHERE ");
                //strSQL.Append(" T.REQ_TYPE = '12' AND T.XFER_STATUS < 5 ");
                //strSQL.Append("  AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");

                strSQL.Append(" FROM TRANSFER_TRANS T,SYSTEM_PARAMETER S, SYSTEM_PARAMETER ST ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON W.WS_CD = T.FROM_WS_CD ");
                strSQL.Append(" WHERE ");
                strSQL.Append(" T.REQ_TYPE = '12' AND T.XFER_STATUS < 5 ");
                strSQL.Append("  AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");
                strSQL.Append("  AND ST.KEY01 = 'SCH_ID' AND ST.KEY02 = T.SCH_ID ");
                //edit by wanghui 2010/3/12 end
                if (po_no != "")
                {
                    strSQL.Append(" AND T.PO_NO = :PO_NO ");
                    db.DbPsetString("PO_NO", _po_no);
                }
                if (from_ws_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WS_CD = :FROM_WS_CD ");
                    db.DbPsetString("FROM_WS_CD", _from_ws_cd);
                }
                if (to_whs_cd != "")
                {
                    strSQL.Append(" AND T.TO_WHS_CD = :TO_WHS_CD ");
                    db.DbPsetString("TO_WHS_CD", _to_whs_cd);
                }
                if (item_no != "")
                {
                    strSQL.Append(" AND T.ITEM_NO = :ITEM_NO ");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (to_joc_cd != "")
                {
                    strSQL.Append(" AND T.TO_JOC_CD = :TO_JOC_CD ");
                    db.DbPsetString("TO_JOC_CD", _to_joc_cd);
                }
                 if (to_lot_no != "")
                {
                    strSQL.Append(" AND T.TO_LOT_NO = :TO_LOT_NO ");
                    db.DbPsetString("TO_LOT_NO", _to_lot_no);
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

                strSQL.Append(" FROM TRANSFER_TRANS T ");
                strSQL.Append("  LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON W.WS_CD = T.FROM_WS_CD ");
                //edit by wanghui 2010/3/11 strat
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER ST ON ST.KEY01 = 'SCH_ID'   ");
                strSQL.Append(" AND ST.KEY02 = T.SCH_ID                               ");
                //edit by wanghui 2010/3/11 end
                strSQL.Append(" WHERE ");
                strSQL.Append(" T.REQ_TYPE = '12' AND T.XFER_STATUS < 5 ");

                if (po_no != "")
                {
                    //strSQL.Append(" AND T.PO_NO = @PO_NO ");
                    strSQL.Append("   AND (T.PO_NO = @PO_NO OR T.SLIP_NO = @PO_NO) "); // 2015.03.03

                    db.DbPsetString("@PO_NO", _po_no);
                }
                if (from_ws_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WS_CD = @FROM_WS_CD ");
                    db.DbPsetString("@FROM_WS_CD", _from_ws_cd);
                }
                if (to_whs_cd != "")
                {
                    strSQL.Append(" AND T.TO_WHS_CD = @TO_WHS_CD ");
                    db.DbPsetString("@TO_WHS_CD", _to_whs_cd);
                }
                if (item_no != "")
                {
                    strSQL.Append(" AND T.ITEM_NO = @ITEM_NO ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (to_joc_cd != "")
                {
                    strSQL.Append(" AND T.TO_JOC_CD = @TO_JOC_CD ");
                    db.DbPsetString("@TO_JOC_CD", _to_joc_cd);
                }
                if (to_lot_no != "")
                {
                    strSQL.Append(" AND T.TO_LOT_NO = @TO_LOT_NO ");
                    db.DbPsetString("@TO_LOT_NO", _to_lot_no);
                }
                if (xfer_sch_date != 0)
                {
                    strSQL.Append(" AND T.XFER_SCH_DATE <= @XFER_SCH_DATE ");
                    db.DbPsetInt("@XFER_SCH_DATE", _xfer_sch_date);
                }
                //add by wanghui 2010/4/2 start
                if (sch_id != "")
                {
                    strSQL.Append(" AND T.SCH_ID = @SCH_ID ");
                    db.DbPsetString("@SCH_ID", sch_id);
                }
                //add by wanghui 2010/4/2 end
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
        /// 入庫対象データHT実績を検索
        /// 
        /// 使用画面：InvComplWhs
        /// </summary>
        public DataSet GetComplHousingHTList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                   ");
            strSQL.Append(" T.PO_NO,T.XFER_SCH_DATE,T.ITEM_NO,T.ITEM_DESC,T.FROM_WS_CD,T.INST_QTY,  ");
            strSQL.Append(" S.DATA_CHAR ITEM_UMSR,HT.HT_ACT_QTY ACT_QTY,HT.HT_ACT_LOCATION TO_LOCATION,HT_ACT_LOT_NO TO_LOT_NO,T.TO_JOC_CD, ");
            strSQL.Append(" T.TO_WHS_CD,T.XFER_NO,W.WS_DESC                                         ");

            strSQL.Append(" , T.SCH_ID ,ST.DATA_CHAR SCH_NM");
            strSQL.Append(" , CASE T.TO_LOT_NO WHEN '' THEN convert(varchar,convert(int, T.CMPL_INPUT_PRC)) + '/' + convert(varchar,convert(int, T.CMPL_INPUT_AMT)) + '-' +  ");  // IMV3
            strSQL.Append(" convert(varchar,convert(int, T.APPROVE_USER_ID)+convert(int, T.CMPL_INPUT_PRC)-1) + '/' + convert(varchar,convert(int, T.CMPL_INPUT_AMT)) ");  // IMV3
            strSQL.Append(" ELSE convert(varchar,convert(int, T.CMPL_INPUT_PRC)) + '/' + convert(varchar,convert(int, T.CMPL_INPUT_AMT)) END CARTON ");  // IMV3

            db.DbParametersClear();

            strSQL.Append(" FROM HOUSING_LOT_IF HT ");
            strSQL.Append(" INNER JOIN TRANSFER_TRANS T ON T.XFER_NO = HT.XFER_NO AND T.REQ_TYPE = HT.REQ_TYPE ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");
            strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON W.WS_CD = T.FROM_WS_CD ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER ST ON ST.KEY01 = 'SCH_ID'   ");
            strSQL.Append(" AND ST.KEY02 = T.SCH_ID                               ");
            strSQL.Append(" WHERE ");
            strSQL.Append(" HT.REQ_TYPE = '12' AND HT.HT_SEND_STATUS < 3 AND HT.HT_ACT_QTY > 0 ");

            if (po_no != "")
            {
                //strSQL.Append(" AND T.PO_NO = @PO_NO ");
                strSQL.Append("   AND (T.PO_NO = @PO_NO OR T.SLIP_NO = @PO_NO) "); // 2015.03.03

                db.DbPsetString("@PO_NO", _po_no);
            }
            if (from_ws_cd != "")
            {
                strSQL.Append(" AND T.FROM_WS_CD = @FROM_WS_CD ");
                db.DbPsetString("@FROM_WS_CD", _from_ws_cd);
            }
            if (to_whs_cd != "")
            {
                strSQL.Append(" AND T.TO_WHS_CD = @TO_WHS_CD ");
                db.DbPsetString("@TO_WHS_CD", _to_whs_cd);
            }
            if (item_no != "")
            {
                strSQL.Append(" AND T.ITEM_NO = @ITEM_NO ");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (to_joc_cd != "")
            {
                strSQL.Append(" AND T.TO_JOC_CD = @TO_JOC_CD ");
                db.DbPsetString("@TO_JOC_CD", _to_joc_cd);
            }
            if (to_lot_no != "")
            {
                strSQL.Append(" AND T.TO_LOT_NO = @TO_LOT_NO ");
                db.DbPsetString("@TO_LOT_NO", _to_lot_no);
            }
            if (xfer_sch_date != 0)
            {
                strSQL.Append(" AND T.XFER_SCH_DATE <= @XFER_SCH_DATE ");
                db.DbPsetInt("@XFER_SCH_DATE", _xfer_sch_date);
            }
            //add by wanghui 2010/4/2 start
            if (sch_id != "")
            {
                strSQL.Append(" AND T.SCH_ID = @SCH_ID ");
                db.DbPsetString("@SCH_ID", sch_id);
            }
            //add by wanghui 2010/4/2 end

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
        /// 使用画面：InvComplWhs
        /// </summary>
        public int GetComplHousingData()
        {
            ComLibrary com = new ComLibrary();
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append(" T.PO_NO,            T.FROM_WS_CD,       W.WS_DESC,      J.SCH_START_DATE,   ");
            strSQL.Append(" J.SCH_COMPL_DATE,   T.ITEM_NO,          T.ITEM_DESC,    J.JOB_ORDER_QTY,    ");
            strSQL.Append(" S.DATA_CHAR ITEM_UMSR,J.JOB_ORDER_COMPL_QTY,J.JOC_CD,   J.SCH_ID,           ");
            strSQL.Append(" S2.DATA_CHAR SCH_NAME,T.TO_WHS_CD,      WH.WHS_DESC,    J.INSP_CD,          ");
            strSQL.Append(" J.SLIP_NOTE,        T.XFER_SCH_DATE,    T.REJ_QTY,      T.INST_QTY,         ");
            strSQL.Append(" I.LOT_CNTL_FLAG,    T.TO_LOT_NO,        T.TO_LOCATION,  T.XFER_NO           ");
            strSQL.Append(" ,S_AUTO_TYPE.DATA_INT AUTO_TYPE,        (T.INST_QTY-T.ACT_QTY) ACT_QTY      ");     //Add by Ubiq-Sai 2012.02.01 ACT_QTY
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM TRANSFER_TRANS T,WORKSHOP_MASTER W,JOB_ORDER J,WAREHOUSE_MASTER WH, ");
                strSQL.Append(" SYSTEM_PARAMETER S,SYSTEM_PARAMETER S2,ITEM_MASTER I ");
                strSQL.Append(" WHERE T.XFER_NO = :XFER_NO ");
                strSQL.Append("  AND T.ITEM_NO = I.ITEM_NO(+) ");
                strSQL.Append("  AND T.FROM_WS_CD = W.WS_CD(+) ");
                strSQL.Append("  AND T.PO_NO = J.ORDER_NO ");
                strSQL.Append("  AND T.TO_WHS_CD = WH.WHS_CD(+) ");
                strSQL.Append("  AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");
                strSQL.Append("  AND S2.KEY01 = 'SCH_ID' AND S2.KEY02 = J.SCH_ID ");
             
                db.DbParametersClear();
                db.DbPsetString("XFER_NO", _xfer_no);
            }
            else
            {
                strSQL.Append(" FROM TRANSFER_TRANS T                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON T.FROM_WS_CD = W.WS_CD                             ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON T.ITEM_NO = I.ITEM_NO                                  ");
                strSQL.Append("  INNER JOIN JOB_ORDER J ON T.PO_NO = J.JOB_ORDER_NO                                     ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WH ON T.TO_WHS_CD = WH.WHS_CD                          ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR   ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'SCH_ID' AND S2.KEY02 = J.SCH_ID      ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S_AUTO_TYPE ON S_AUTO_TYPE.KEY01  = 'LOT_NUMBERING'          "); //UPD 20090819 UBIQ-CHEN
                strSQL.Append("  AND    S_AUTO_TYPE.KEY02  = 'MFG'                                                      ");

                strSQL.Append(" WHERE T.XFER_NO = @XFER_NO ");

                db.DbParametersClear();
                db.DbPsetString("@XFER_NO", _xfer_no);
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
                _from_ws_cd = db.Row("FROM_WS_CD");
                _ws_desc = db.Row("WS_DESC");
                _sch_start_date = com.StringToInt(db.Row("SCH_START_DATE"));
                _sch_compl_date = com.StringToInt(db.Row("SCH_COMPL_DATE"));                
                _item_no = db.Row("ITEM_NO");
                _item_desc = db.Row("ITEM_DESC");
                _job_order_qty = com.StringToDouble(db.Row("JOB_ORDER_QTY"));
                _item_umsr = db.Row("ITEM_UMSR");
                _job_order_compl_qty = com.StringToDouble(db.Row("JOB_ORDER_COMPL_QTY"));
                _joc_cd = db.Row("JOC_CD");
                _sch_id = db.Row("SCH_ID");
                _sch_name = db.Row("SCH_NAME");
                _to_whs_cd = db.Row("TO_WHS_CD");
                _whs_desc = db.Row("WHS_DESC");
                _insp_cd = db.Row("INSP_CD");
                _slip_note = db.Row("SLIP_NOTE");
                _xfer_sch_date = com.StringToInt(db.Row("XFER_SCH_DATE"));
                _rej_qty = com.StringToDouble(db.Row("REJ_QTY"));
                _inst_qty = com.StringToDouble(db.Row("INST_QTY"));
                _lot_cntl_flag = com.StringToInt(db.Row("LOT_CNTL_FLAG"));
                _to_lot_no = db.Row("TO_LOT_NO");
                _to_location = db.Row("TO_LOCATION");
                _xfer_no = db.Row("XFER_NO");
                _auto_type = com.StringToInt(db.Row("AUTO_TYPE"));
                _act_qty = com.StringToDouble(db.Row("ACT_QTY"));   //Add by Ubiq-Sai 2012.02.01  

            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// 振替依頼データを検索
        /// 
        /// 使用画面：InvComplWhs
        /// </summary>
        public int GetComplHousingHTData()
        {
            ComLibrary com = new ComLibrary();
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append(" T.PO_NO,            T.FROM_WS_CD,       W.WS_DESC,      J.SCH_START_DATE,   ");
            strSQL.Append(" J.SCH_COMPL_DATE,   T.ITEM_NO,          T.ITEM_DESC,    J.JOB_ORDER_QTY,    ");
            strSQL.Append(" S.DATA_CHAR ITEM_UMSR,J.JOB_ORDER_COMPL_QTY,J.JOC_CD,   J.SCH_ID,           ");
            strSQL.Append(" S2.DATA_CHAR SCH_NAME,T.TO_WHS_CD,      WH.WHS_DESC,    J.INSP_CD,          ");
            strSQL.Append(" J.SLIP_NOTE,        T.XFER_SCH_DATE,    T.REJ_QTY,      T.INST_QTY,         ");
            strSQL.Append(" I.LOT_CNTL_FLAG,    HT_ACT_LOCATION TO_LOCATION,HT_ACT_LOT_NO TO_LOT_NO,  T.XFER_NO           ");
            strSQL.Append(" ,S_AUTO_TYPE.DATA_INT AUTO_TYPE,        HT.HT_ACT_QTY ACT_QTY      ");     //Add by Ubiq-Sai 2012.02.01 ACT_QTY


            strSQL.Append(" FROM HOUSING_LOT_IF HT ");
            strSQL.Append(" INNER JOIN TRANSFER_TRANS T ON T.XFER_NO = HT.XFER_NO AND T.REQ_TYPE = HT.REQ_TYPE ");
            strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON T.FROM_WS_CD = W.WS_CD                             ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON T.ITEM_NO = I.ITEM_NO                                  ");
            strSQL.Append("  INNER JOIN JOB_ORDER J ON T.PO_NO = J.JOB_ORDER_NO                                     ");
            strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WH ON T.TO_WHS_CD = WH.WHS_CD                          ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR   ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'SCH_ID' AND S2.KEY02 = J.SCH_ID      ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S_AUTO_TYPE ON S_AUTO_TYPE.KEY01  = 'LOT_NUMBERING'          "); //UPD 20090819 UBIQ-CHEN
            strSQL.Append("  AND    S_AUTO_TYPE.KEY02  = 'MFG'                                                      ");

            strSQL.Append(" WHERE T.XFER_NO = @XFER_NO ");

            db.DbParametersClear();
            db.DbPsetString("@XFER_NO", _xfer_no);

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _po_no = db.Row("PO_NO");
                _from_ws_cd = db.Row("FROM_WS_CD");
                _ws_desc = db.Row("WS_DESC");
                _sch_start_date = com.StringToInt(db.Row("SCH_START_DATE"));
                _sch_compl_date = com.StringToInt(db.Row("SCH_COMPL_DATE"));
                _item_no = db.Row("ITEM_NO");
                _item_desc = db.Row("ITEM_DESC");
                _job_order_qty = com.StringToDouble(db.Row("JOB_ORDER_QTY"));
                _item_umsr = db.Row("ITEM_UMSR");
                _job_order_compl_qty = com.StringToDouble(db.Row("JOB_ORDER_COMPL_QTY"));
                _joc_cd = db.Row("JOC_CD");
                _sch_id = db.Row("SCH_ID");
                _sch_name = db.Row("SCH_NAME");
                _to_whs_cd = db.Row("TO_WHS_CD");
                _whs_desc = db.Row("WHS_DESC");
                _insp_cd = db.Row("INSP_CD");
                _slip_note = db.Row("SLIP_NOTE");
                _xfer_sch_date = com.StringToInt(db.Row("XFER_SCH_DATE"));
                _rej_qty = com.StringToDouble(db.Row("REJ_QTY"));
                _inst_qty = com.StringToDouble(db.Row("INST_QTY"));
                _lot_cntl_flag = com.StringToInt(db.Row("LOT_CNTL_FLAG"));
                _to_lot_no = db.Row("TO_LOT_NO");
                _to_location = db.Row("TO_LOCATION");
                _xfer_no = db.Row("XFER_NO");
                _auto_type = com.StringToInt(db.Row("AUTO_TYPE"));
                _act_qty = com.StringToDouble(db.Row("ACT_QTY"));   //Add by Ubiq-Sai 2012.02.01  

            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }
        
        /// <summary>
        /// 計画入庫
        /// 
        /// 使用画面：InvComplWhs,使用画面：InvRcvWhs
        /// </summary>
        public int ComplHousing(ComDB db)
        {
            //ComDB db = new ComDB(_db_type);  // IMV3
            int rtn = 0;

            db.DbParametersClear();			

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_IN);
            db.DbPsetInt("@I_ACT_DATE", _act_date, ComConst.DB_IN);
            db.DbPsetDouble("@I_ACT_QTY", _act_qty, ComConst.DB_IN);
            db.DbPsetString("@I_LOT_NO", _to_lot_no, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION", _to_location, ComConst.DB_IN);
            db.DbPsetString("@I_REQ_TYPE", _req_type, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_HOUSING");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                //db.DbCommit();  // IMV3
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                //db.DbRollback();  // IMV3
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 入庫取消対象データを検索
        /// 
        /// 使用画面：InvRcvWhsCancel
        /// </summary>
        public DataSet GetPurHousingCancelList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                                      ");
            //UPD 2009.06.16
            strSQL.Append(" T.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),T.PO_LINE_NO),3) AS PO_NO,                           ");
            //strSQL.Append(" T.XFER_SCH_DATE,        T.ITEM_NO,      T.ITEM_DESC,        T.INST_QTY,                   ");
            strSQL.Append(" T.XFER_SCH_DATE,        T.ITEM_NO,      T.ITEM_DESC,        T.QTY_PUR_UMSR INST_QTY,        ");
            //strSQL.Append(" S.DATA_CHAR ITEM_UMSR,  T.ACT_QTY,      T.TO_LOCATION,  T.TO_LOT_NO,        T.TO_JOC_CD,  ");   
            //strSQL.Append(" S.DATA_CHAR PUR_UMSR,   T.ACT_QTY,      T.TO_LOCATION,      S2.DATA_CHAR ITEM_UMSR,       ");   //del by ubiq-sai 2012/02/01
            strSQL.Append(" S.DATA_CHAR PUR_UMSR,   R.QTY ACT_QTY,    R.TO_LOCATION,      S2.DATA_CHAR ITEM_UMSR,       ");   //add by ubiq-sai 2012/02/01
            //strSQL.Append(" T.TO_LOT_NO,            T.TO_JOC_CD,    T.TO_WHS_CD,        T.XFER_NO,                    ");   //del by ubiq-sai 2012/02/01
            strSQL.Append(" R.TO_LOT_NO,            T.TO_JOC_CD,    T.TO_WHS_CD,        T.XFER_NO,                      ");   //add by ubiq-sai 2012/02/01
            //strSQL.Append(" T.SLIP_DATE,            T.FROM_VC_CD,   V.VENDOR_NAME                                     ");   //del by ubiq-sai 2012/02/01
            strSQL.Append(" R.TRANS_DATE SLIP_DATE, T.FROM_VC_CD,   V.VENDOR_NAME,      R.SLIP_LINE_NO                  ");   //add by ubiq-sai 2012/02/01

            //add by wanghui 2010/3/11 start
            strSQL.Append(" , T.SCH_ID ,ST.DATA_CHAR SCH_NM");
            //add by wanghui 2010/3/11 end

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM TRANSFER_TRANS T,SYSTEM_PARAMETER S,SYSTEM_PARAMETER S2,VENDOR_MASTER V ");
                //add by wanghui 2010/3/11 start
                strSQL.Append(" , SYSTEM_PARAMETER ST ");
                //add by wanghui 2010/3/11 end
                strSQL.Append(" WHERE ");
                strSQL.Append(" T.REQ_TYPE = '11' AND T.XFER_STATUS >= 20 AND T.XFER_STATUS < 50 ");
                strSQL.Append("  AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.PUR_UMSR ");
                strSQL.Append("  AND S2.KEY01 = 'ITEM_UMSR' AND S2.KEY02 = T.ITEM_UMSR ");
                strSQL.Append("  AND T.FROM_VC_CD = V.VENDOR_CD ");

                //add by wanghui 2010/3/11 start
                strSQL.Append("  AND ST.KEY01 = 'SCH_ID' AND ST.KEY02 = T.SCH_ID ");
                //add by wanghui 2010/3/11 end
                if (po_no != "")
                {
                    strSQL.Append(" AND T.PO_NO = :PO_NO ");
                    db.DbPsetString("PO_NO", _po_no);
                }
                if (from_vc_cd != "")
                {
                    strSQL.Append(" AND T.FROM_VC_CD = :FROM_VC_CD ");
                    db.DbPsetString("FROM_VC_CD", _from_vc_cd);
                }
                if (to_whs_cd != "")
                {
                    strSQL.Append(" AND T.TO_WHS_CD = :TO_WHS_CD ");
                    db.DbPsetString("TO_WHS_CD", _to_whs_cd);
                }
                if (item_no != "")
                {
                    strSQL.Append(" AND T.ITEM_NO = :ITEM_NO ");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (to_joc_cd != "")
                {
                    strSQL.Append(" AND T.TO_JOC_CD = :TO_JOC_CD ");
                    db.DbPsetString("TO_JOC_CD", _to_joc_cd);
                }
                if (xfer_sch_date_from != 0)
                {
                    strSQL.Append(" AND T.SLIP_DATE >= :XFER_SCH_DATE_FROM ");
                    db.DbPsetInt("XFER_SCH_DATE_FROM", _xfer_sch_date_from);
                }
                if (xfer_sch_date_to != 0)
                {
                    strSQL.Append(" AND T.SLIP_DATE <= :XFER_SCH_DATE_TO ");
                    db.DbPsetInt("XFER_SCH_DATE_TO", _xfer_sch_date_to);
                }

                //add by wanghui 2010/3/12 start
                if (sch_id != "")
                {
                    strSQL.Append(" AND T.SCH_ID = : SCH_ID ");
                    db.DbPsetString("SCH_ID", sch_id);
                }
                //add by wanghui 2010/3/12 end
            }
            else
            {
                db.DbParametersClear();
              
                strSQL.Append(" FROM TRANSFER_TRANS T                                                               ");
                
                //add by ubiq-sai 2012/02/01 begin
                strSQL.Append(" INNER JOIN 															                ");
                strSQL.Append(" (	SELECT XFER_NO, QTY, TO_LOT_NO, TO_LOCATION, SLIP_LINE_NO, TRANS_DATE	        ");
                strSQL.Append(" 	  FROM RCV_DISB_TRANS											                ");
                strSQL.Append(" 	 WHERE XFER_NO + CAST(SLIP_LINE_NO AS CHAR) NOT IN				                ");
                strSQL.Append(" 				(													                ");
                strSQL.Append(" 					SELECT XFER_NO + CAST(SLIP_LINE_NO AS CHAR)		                ");
                strSQL.Append(" 					  FROM RCV_DISB_TRANS							                ");
                strSQL.Append(" 					 WHERE REQ_TYPE = '11'							                ");
                strSQL.Append(" 					   AND SLIP_TYPE = '01'							                ");
                strSQL.Append(" 					   AND QTY < 0									                ");
                strSQL.Append(" 				)													                ");
                strSQL.Append(" 	   AND REQ_TYPE = '11'											                ");
                strSQL.Append(" 	   AND SLIP_TYPE = '01'											                ");
                strSQL.Append(" ) R																	                ");
                strSQL.Append(" ON T.XFER_NO = R.XFER_NO											                ");
                //add by ubiq-sai 2012/02/01 end

                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.PUR_UMSR      ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'ITEM_UMSR' AND S2.KEY02 = T.ITEM_UMSR  ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON T.FROM_VC_CD = V.VENDOR_CD                       ");
                //add by wanghui 2010/3/11 start
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER ST ON ST.KEY01 = 'SCH_ID' AND ST.KEY02 = T.SCH_ID ");
                //add by wanghui 2010/3/11 end
                strSQL.Append(" WHERE                                                                               ");
                //strSQL.Append(" T.REQ_TYPE = '11' AND T.XFER_STATUS >= 20 AND T.XFER_STATUS < 50                    ");   //del by ubiq-sai 2012/02/01
                strSQL.Append(" T.REQ_TYPE = '11' AND T.XFER_STATUS < 50                                            ");     //add by ubiq-sai 2012/02/01

                if (po_no != "")
                {
                    //strSQL.Append(" AND T.PO_NO = @PO_NO ");
                    strSQL.Append("   AND (T.PO_NO = @PO_NO OR T.SLIP_NO = @PO_NO) "); // 2015.03.03                    db.DbPsetString("@PO_NO", _po_no);
                }
                if (from_vc_cd != "")
                {
                    strSQL.Append(" AND T.FROM_VC_CD = @FROM_VC_CD ");
                    db.DbPsetString("@FROM_VC_CD", _from_vc_cd);
                }
                if (to_whs_cd != "")
                {
                    strSQL.Append(" AND T.TO_WHS_CD = @TO_WHS_CD ");
                    db.DbPsetString("@TO_WHS_CD", _to_whs_cd);
                }
                if (item_no != "")
                {
                    strSQL.Append(" AND T.ITEM_NO = @ITEM_NO ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (to_joc_cd != "")
                {
                    strSQL.Append(" AND T.TO_JOC_CD = @TO_JOC_CD ");
                    db.DbPsetString("@TO_JOC_CD", _to_joc_cd);
                }
                if (xfer_sch_date_from != 0)
                {
                    strSQL.Append(" AND T.SLIP_DATE >= @XFER_SCH_DATE_FROM ");
                    db.DbPsetInt("@XFER_SCH_DATE_FROM", _xfer_sch_date_from);
                }
                if (xfer_sch_date_to != 0)
                {
                    strSQL.Append(" AND T.SLIP_DATE <= @XFER_SCH_DATE_TO ");
                    db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
                }
                //add by wanghui 2010/3/12 start
                if (sch_id != "")
                {
                    strSQL.Append(" AND T.SCH_ID = @SCH_ID ");
                    db.DbPsetString("@SCH_ID", sch_id);
                }
                //add by wanghui 2010/3/12 end
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
        /// 完成入庫取消対象データを検索
        /// 
        /// 使用画面：InvComplWhsCancel
        /// </summary>
        public DataSet GetComplHousingCancelList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                      ");
            //strSQL.Append(" T.PO_NO,        T.SLIP_DATE XFER_SCH_DATE,  T.ITEM_NO,      T.ITEM_DESC,  ");   //del by ubiq-sai 2012/02/01
            strSQL.Append(" T.PO_NO,        R.TRANS_DATE XFER_SCH_DATE,  T.ITEM_NO,      T.ITEM_DESC,   ");   //add by ubiq-sai 2012/02/01
            //strSQL.Append(" T.FROM_WS_CD,   T.INST_QTY,     S.DATA_CHAR ITEM_UMSR,      T.TO_LOCATION,");   //del by ubiq-sai 2012/02/01
            strSQL.Append(" T.FROM_WS_CD,   T.INST_QTY, R.QTY ACT_QTY, S.DATA_CHAR ITEM_UMSR, R.TO_LOCATION,  ");   //add by ubiq-sai 2012/02/01
            //strSQL.Append(" T.TO_LOT_NO,    T.TO_JOC_CD,                T.TO_WHS_CD,    T.XFER_NO,    ");   //del by ubiq-sai 2012/02/01
            strSQL.Append(" R.TO_LOT_NO,    T.TO_JOC_CD,                T.TO_WHS_CD,    T.XFER_NO,      ");   //add by ubiq-sai 2012/02/01
            strSQL.Append(" W.WS_DESC                                                                   ");
            //add by wanghui 2010/3/11 start
            strSQL.Append(" , T.SCH_ID ,ST.DATA_CHAR SCH_NM");
            //add by wanghui 2010/3/11 end
            strSQL.Append(" , R.SLIP_LINE_NO                                                            ");     //add by ubiq-sai 2012/02/01

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM TRANSFER_TRANS T,SYSTEM_PARAMETER S ");
                //add by wanghui 2010/3/11 start
                strSQL.Append(" , SYSTEM_PARAMETER ST ");
                //add by wanghui 2010/3/11 end
                strSQL.Append(" WHERE ");
                strSQL.Append(" T.REQ_TYPE = '12' AND T.XFER_STATUS >= 20 AND T.XFER_STATUS < 50 ");
                strSQL.Append("  AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");
                //add by wanghui 2010/3/11 start
                strSQL.Append("  AND ST.KEY01 = 'SCH_ID' AND ST.KEY02 = T.SCH_ID ");
                //add by wanghui 2010/3/11 end

                if (po_no != "")
                {
                    strSQL.Append(" AND T.PO_NO = :PO_NO ");
                    db.DbPsetString("PO_NO", _po_no);
                }
                if (from_ws_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WS_CD = :FROM_WS_CD ");
                    db.DbPsetString("FROM_WS_CD", _from_ws_cd);
                }
                if (to_whs_cd != "")
                {
                    strSQL.Append(" AND T.TO_WHS_CD = :TO_WHS_CD ");
                    db.DbPsetString("TO_WHS_CD", _to_whs_cd);
                }
                if (item_no != "")
                {
                    strSQL.Append(" AND T.ITEM_NO = :ITEM_NO ");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (to_joc_cd != "")
                {
                    strSQL.Append(" AND T.TO_JOC_CD = :TO_JOC_CD ");
                    db.DbPsetString("TO_JOC_CD", _to_joc_cd);
                }
                if (to_lot_no != "")
                {
                    strSQL.Append(" AND T.TO_LOT_NO = :TO_LOT_NO ");
                    db.DbPsetString("TO_LOT_NO", _to_lot_no);
                }
                if (xfer_sch_date_from != 0)
                {
                    strSQL.Append(" AND T.SLIP_DATE >= :XFER_SCH_DATE_FROM ");
                    db.DbPsetInt("XFER_SCH_DATE_FROM", _xfer_sch_date_from);
                }
                if (xfer_sch_date_to != 0)
                {
                    strSQL.Append(" AND T.SLIP_DATE <= :XFER_SCH_DATE_TO ");
                    db.DbPsetInt("XFER_SCH_DATE_TO", _xfer_sch_date_to);
                }
                //add by wanghui 2010/3/12 start
                if (sch_id != "")
                {
                    strSQL.Append(" AND T.SCH_ID = : SCH_ID ");
                    db.DbPsetString("SCH_ID", sch_id);
                }
                //add by wanghui 2010/3/12 end
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T ");
                //add by ubiq-sai 2012/02/01 begin
                strSQL.Append(" INNER JOIN 															            ");
                strSQL.Append(" (	SELECT XFER_NO, QTY, TO_LOT_NO, TO_LOCATION, SLIP_LINE_NO, TRANS_DATE	    ");
                strSQL.Append(" 	  FROM RCV_DISB_TRANS											            ");
                strSQL.Append(" 	 WHERE XFER_NO + CAST(SLIP_LINE_NO AS CHAR) NOT IN				            ");
                strSQL.Append(" 				(													            ");
                strSQL.Append(" 					SELECT XFER_NO + CAST(SLIP_LINE_NO AS CHAR)		            ");
                strSQL.Append(" 					  FROM RCV_DISB_TRANS							            ");
                strSQL.Append(" 					 WHERE REQ_TYPE = '12'							            ");
                strSQL.Append(" 					   AND SLIP_TYPE = '01'							            ");
                strSQL.Append(" 					   AND QTY < 0									            ");
                strSQL.Append(" 				)													            ");
                strSQL.Append(" 	   AND REQ_TYPE = '12'											            ");
                strSQL.Append(" 	   AND SLIP_TYPE = '01'											            ");
                strSQL.Append(" ) R																	            ");
                strSQL.Append(" ON T.XFER_NO = R.XFER_NO											            ");
                //add by ubiq-sai 2012/02/01 end

                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON T.FROM_WS_CD = W.WS_CD                     ");
                //add by wanghui 2010/3/11 start
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER ST ON ST.KEY01 = 'SCH_ID' AND ST.KEY02 = T.SCH_ID ");
                //add by wanghui 2010/3/11 end
                strSQL.Append(" WHERE ");
                //strSQL.Append(" T.REQ_TYPE = '12' AND T.XFER_STATUS >= 20 AND T.XFER_STATUS < 50 ");  //Del by Ubiq-Sai 2012.02.01
                strSQL.Append(" T.REQ_TYPE = '12' AND T.XFER_STATUS < 50 ");                            //Add by Ubiq-Sai 2012.02.01

                if (po_no != "")
                {
                    //strSQL.Append(" AND T.PO_NO = @PO_NO ");
                    strSQL.Append("   AND (T.PO_NO = @PO_NO OR T.SLIP_NO = @PO_NO) "); // 2015.03.03

                    db.DbPsetString("@PO_NO", _po_no);
                }
                if (from_ws_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WS_CD = @FROM_WS_CD ");
                    db.DbPsetString("@FROM_WS_CD", _from_ws_cd);
                }
                if (to_whs_cd != "")
                {
                    strSQL.Append(" AND T.TO_WHS_CD = @TO_WHS_CD ");
                    db.DbPsetString("@TO_WHS_CD", _to_whs_cd);
                }
                if (item_no != "")
                {
                    strSQL.Append(" AND T.ITEM_NO = @ITEM_NO ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (to_joc_cd != "")
                {
                    strSQL.Append(" AND T.TO_JOC_CD = @TO_JOC_CD ");
                    db.DbPsetString("@TO_JOC_CD", _to_joc_cd);
                }
                if (to_lot_no != "")
                {
                    strSQL.Append(" AND T.TO_LOT_NO = @TO_LOT_NO ");
                    db.DbPsetString("@TO_LOT_NO", _to_lot_no);
                }
                if (xfer_sch_date_from != 0)
                {
                    strSQL.Append(" AND T.SLIP_DATE >= @XFER_SCH_DATE_FROM ");
                    db.DbPsetInt("@XFER_SCH_DATE_FROM", _xfer_sch_date_from);
                }
                if (xfer_sch_date_to != 0)
                {
                    strSQL.Append(" AND T.SLIP_DATE <= @XFER_SCH_DATE_TO ");
                    db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
                }
                //add by wanghui 2010/3/12 start
                if (sch_id != "")
                {
                    strSQL.Append(" AND T.SCH_ID = @SCH_ID ");
                    db.DbPsetString("@SCH_ID", sch_id);
                }
                //add by wanghui 2010/3/12 end
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
        /// 入庫取消
        /// 
        /// 使用画面：InvComplWhsCancel,使用画面：InvRcvWhsCancel
        /// </summary>
        public int HousingCancel()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_IN);
            db.DbPsetInt("@I_SLIP_LINE_NO", _slip_line_no, ComConst.DB_IN);     //add by ubiq-sai 2012/02/01
            db.DbPsetString("@I_REQ_TYPE", _req_type, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_HOUSING_CANCEL");
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
    }
}
