﻿using System;
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
    public class Transfer
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Transfer()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Transfer(string p_user_id, int p_lang)
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
        //protected string _req_type = "";
        //protected DateTime _req_date = DateTime.Now;
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
        protected int _rcv_disb_flag = 0;
        protected string _whs_cd = "";
        protected string _rcv_disb_type = "";
        protected string _job_order_no = "";
        protected string _cost_center = "";
        protected string _vendor_cd = "";
        protected string _ws_cd = "";
        protected double _req_qty = 0;
        protected string _lot_no = "";
        protected string _location = "";
        protected int _req_type = 0;
        protected int _req_date = 0;
        protected double _transfer_qty = 0;
        protected int _supply_type = 0;
        protected int _reissue_flag = 0;

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
        //ADD 20090207 LIU
        protected int _request_no = 0;
        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        public int lang { get { return _lang; } set { _lang = value; } }
        public int xfer_status { get { return _xfer_status; } set { _xfer_status = value; } }
        //public string req_type { get { return _req_type; } set { _req_type = value; } }
        //public DateTime req_date { get { return _req_date; } set { _req_date = value; } }
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

        public string alloc { get { return _alloc; } set { _alloc = value; } }
        public string disb_no { get { return _disb_no; } set { _disb_no = value; } }
        public int act_disb_date { get { return _act_disb_date; } set { _act_disb_date = value; } }
        public int house_type { get { return _house_type; } set { _house_type = value; } }
        public int rcv_disb_flag { get { return _rcv_disb_flag; } set { _rcv_disb_flag = value; } }

        public string whs_cd { get { return _whs_cd; } set { _whs_cd = value; } }
        public string rcv_disb_type { get { return _rcv_disb_type; } set { _rcv_disb_type = value; } }
        public string job_order_no { get { return _job_order_no; } set { _job_order_no = value; } }
        public string cost_center { get { return _cost_center; } set { _cost_center = value; } }
        public string vendor_cd { get { return _vendor_cd; } set { _vendor_cd = value; } }
        public string ws_cd { get { return _ws_cd; } set { _ws_cd = value; } }
        public double req_qty { get { return _req_qty; } set { _req_qty = value; } }
        public string lot_no { get { return _lot_no; } set { _lot_no = value; } }
        public string location { get { return _location; } set { _location = value; } }
        public int req_type { get { return _req_type; } set { _req_type = value; } }
        public int req_date { get { return _req_date; } set { _req_date = value; } }
        public double transfer_qty { get { return _transfer_qty; } set { _transfer_qty = value; } }
        public int supply_type { get { return _supply_type; } set { _supply_type = value; } }
        public int reissue_flag { get { return _reissue_flag; } set { _reissue_flag = value; } }

        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }

        public int request_no { get { return _request_no; } set { _request_no = value; } }
        #endregion

        /// <summary>
        /// 計画外入出庫実績
        ///
        /// UPD BY CHEN 2009.01.24
        /// UPD BY CHEN 2009.02.16
        /// 
        /// 使用画面：InvAdjAct
        /// </summary>
        /// 
        public DataSet GetUnplannedRcvActList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql 
            strSQL.Append(" SELECT                                                              ");
            strSQL.Append(" T.SLIP_LINE_NO,T.ITEM_NO,T.ITEM_DESC,T.INST_QTY,                    ");
            strSQL.Append(" S.DATA_CHAR ITEM_UMSR,T.INST_QTY RCV_QTY,T.TO_LOCATION LOCATION,    ");
            strSQL.Append(" T.TO_LOT_NO LOT_NO,T.TO_JOC_CD JOC_CD,T.XFER_NO,T.XFER_STATUS       ");
            strSQL.Append(", T.TO_WS_CD WS_CD, W.WS_DESC, T.FROM_VC_CD VENDOR_CD, V.VENDOR_DESC ");   // ubiq-harada (add)
            strSQL.Append(", T.TO_WHS_CD WHS_CD,0 AS DISB_QTY,T.TO_SUPPLY_TYPE SUPPLY_TYPE      ");
            strSQL.Append(", WHS.WHS_DESC ,I.DATA_NUM1 IDTAG_UNIT_QTY,T.TRANS_DATE,T.XFER_STATUS ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM ");
                strSQL.Append(" TRANSFER_TRANS T,SYSTEM_PARAMETER S,WORKSHOP_MASTER W,VENDOR_MASTER V,  ");
                strSQL.Append(" WAREHOUSE_MASTER WHS                                                    ");
                strSQL.Append(" WHERE                                                                   ");
                strSQL.Append(" T.REQ_TYPE='13'                                                         ");
                strSQL.Append(" AND T.XFER_STATUS=10                                                    ");
                strSQL.Append(" AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR                     ");
                strSQL.Append(" AND T.TO_WS_CD = W.WS_CD                                                ");
                strSQL.Append(" AND T.FROM_VC_CD = V.VENDOR_CD                                          ");
                strSQL.Append(" AND T.TO_WHS_CD = W.WHS_CD                                              ");

                strSQL.Append(" AND T.SLIP_NO = :SLIP_NO ");
                db.DbPsetString("SLIP_NO", _slip_no);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T                                                           ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");                
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER W ON T.TO_WS_CD = W.WS_CD                             ");
                strSQL.Append(" LEFT JOIN VENDOR_MASTER V ON T.FROM_VC_CD = V.VENDOR_CD                         ");
                strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER WHS ON T.TO_WHS_CD = WHS.WHS_CD                      ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER I ON T.ITEM_NO=I.ITEM_NO                                  ");

                strSQL.Append(" WHERE                                   ");
                strSQL.Append(" T.REQ_TYPE='13'                         ");
                if (_xfer_status == 0)
                    strSQL.Append(" AND T.XFER_STATUS=10                    ");
                else
                {
                    strSQL.Append(" AND T.XFER_STATUS>=10                    ");
                    strSQL.Append(" AND T.XFER_STATUS<90                    ");
                }

                strSQL.Append(" AND T.SLIP_NO = @SLIP_NO                ");
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
        /// 計画外入出庫実績
        ///
        /// UPD BY CHEN 2009.01.24
        /// UPD BY CHEN 2009.02.16
        /// 
        /// 使用画面：InvAdjAct
        /// </summary>
        public DataSet GetUnplannedDisbActList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                              ");
            strSQL.Append(" T.SLIP_LINE_NO,T.ITEM_NO,T.ITEM_DESC,D.ALLOC_QTY INST_QTY,          ");
            strSQL.Append(" S.DATA_CHAR ITEM_UMSR,D.ALLOC_QTY DISB_QTY,D.LOCATION,D.LOT_NO,     ");
            strSQL.Append(" D.JOC_CD,T.XFER_NO,T.XFER_STATUS,0 AS RCV_QTY,T.TO_WS_CD WS_CD,     ");
            strSQL.Append(" W.WS_DESC,T.TO_VC_CD VENDOR_CD,V.VENDOR_DESC,T.FROM_WHS_CD WHS_CD   ");
            strSQL.Append(" ,T.FROM_SUPPLY_TYPE SUPPLY_TYPE,WHS.WHS_DESC                        ");
            strSQL.Append(" , I.DATA_NUM1 IDTAG_UNIT_QTY,T.TRANS_DATE,T.XFER_STATUS     ");
            
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM ");
                strSQL.Append(" TRANSFER_TRANS T,DISB_ALLOC D,SYSTEM_PARAMETER S,WORKSHOP_MASTER W,VENDOR_MASTER V  ");
                strSQL.Append(" ,WAREHOUSE_MASTER WHS                                                               ");
                strSQL.Append(" WHERE                                                                               ");
                strSQL.Append(" T.XFER_NO = D.XFER_NO                                                               ");
                strSQL.Append(" AND T.REQ_TYPE='23'                                                                 ");
                strSQL.Append(" AND T.XFER_STATUS=10                                                                ");
                strSQL.Append(" AND D.ALLOC_STATUS=0                                                                ");
                strSQL.Append(" AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR                                 ");
                strSQL.Append(" AND T.TO_WS_CD = W.WS_CD                                                            ");
                strSQL.Append(" AND T.TO_VC_CD = V.VENDOR_CD                                                        ");
                strSQL.Append(" AND T.FROM_WHS_CD = WHS.WHS_CD                                                      ");
                strSQL.Append(" AND T.SLIP_NO = :SLIP_NO ");
                db.DbPsetString("SLIP_NO", _slip_no);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T                                                           ");
                strSQL.Append(" INNER JOIN DISB_ALLOC D ON T.XFER_NO = D.XFER_NO                                ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER W ON T.TO_WS_CD = W.WS_CD                             ");
                strSQL.Append(" LEFT JOIN VENDOR_MASTER V ON T.TO_VC_CD = V.VENDOR_CD                           ");
                strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER WHS ON T.FROM_WHS_CD = WHS.WHS_CD                    ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER I ON T.ITEM_NO=I.ITEM_NO                                  ");
                strSQL.Append(" WHERE                                                                           ");
                strSQL.Append(" T.REQ_TYPE='23'                                                                 ");
                strSQL.Append(" AND T.XFER_STATUS=10                                                            ");
                strSQL.Append(" AND D.ALLOC_STATUS = 0                                                          ");

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
        /// 計画外入出庫実績
        /// 
        /// 使用画面：InvAdjAct
        /// </summary>
        public int UnplannedRcvDisbAct()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_SLIP_NO", _slip_no, ComConst.DB_IN);
            db.DbPsetInt("@I_SLIP_LINE_NO", _slip_line_no, ComConst.DB_IN);
            db.DbPsetInt("@I_ACT_DATE", _act_date, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_UNPLANNED_RCV_DISB_ACT");
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
        /// 計画外入庫伝票
        /// 
        /// 使用画面：InvAdjList
        /// </summary>
        public DataSet GetAdjHousingList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                                  ");
            strSQL.Append(" T.SLIP_NO,      T.XFER_SCH_DATE,        T.SLIP_NO,      T.TO_WHS_CD,        W.WHS_DESC, ");
            strSQL.Append(" T.SLIP_LINE_NO, T.XFER_TEXT,            T.ITEM_NO,      T.ITEM_DESC,        T.INST_QTY, ");     
            strSQL.Append(" S.DATA_CHAR ITEM_UMSR,                  T.TO_LOCATION,  T.TO_LOT_NO,        T.TO_JOC_CD,");
            strSQL.Append(" T.FROM_VC_CD,   V.VENDOR_NAME,          T.TO_SUPPLY_TYPE SUPPLY_TYPE                    ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM ");
                strSQL.Append(" TRANSFER_TRANS T,WAREHOUSE_MASTER W,VENDOR_MASTER V,SYSTEM_PARAMETER S ");
                strSQL.Append(" WHERE ");
                strSQL.Append(" T.TO_WHS_CD=W.WHS_CD ");
                strSQL.Append(" AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");
                strSQL.Append(" AND T.FROM_VC_CD=V.VENDOR_CD(+) ");
                strSQL.Append(" AND T.REQ_TYPE='13' ");
                if (reissue_flag == 0)
                {
                    strSQL.Append(" AND T.XFER_STATUS=0         ");
                }
                else
                {
                    strSQL.Append(" AND T.XFER_STATUS=10         ");
                }

                if (_whs_cd != "")
                {
                    strSQL.Append(" AND T.TO_WHS_CD = :WHS_CD ");
                    db.DbPsetString("WHS_CD", _whs_cd);
                }
                strSQL.Append(" ORDER BY ");
                strSQL.Append(" T.TO_WHS_CD,T.XFER_SCH_DATE,T.SLIP_NO,T.SLIP_LINE_NO ");
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T                                                                       ");
                strSQL.Append(" INNER JOIN WAREHOUSE_MASTER W ON T.TO_WHS_CD=W.WHS_CD                                       ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR       ");
                //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'RCV_DISB_TYPE' AND S2.KEY02 = T.XFER_TEXT");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON T.FROM_VC_CD=V.VENDOR_CD                                 ");

                strSQL.Append(" WHERE                       ");
                strSQL.Append(" T.REQ_TYPE='13'             ");
                if (reissue_flag == 0)
                {
                    strSQL.Append(" AND T.XFER_STATUS=0         ");
                }
                else
                {
                    strSQL.Append(" AND T.XFER_STATUS=10         ");
                }

                if (_whs_cd != "")
                {
                    strSQL.Append(" AND T.TO_WHS_CD = @WHS_CD ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }
                strSQL.Append(" ORDER BY ");
                strSQL.Append(" T.TO_WHS_CD,T.XFER_SCH_DATE,T.SLIP_NO,T.SLIP_LINE_NO ");
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
        /// 計画外出庫伝票
        /// 
        /// 使用画面：InvAdjList
        /// </summary>
        public DataSet GetAdjDisbList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                                  ");
            strSQL.Append(" T.SLIP_NO,      T.XFER_SCH_DATE,    T.FROM_WHS_CD,      W.WHS_DESC,                     ");
            strSQL.Append(" T.TO_WS_CD,     WS.WS_DESC,         T.SLIP_LINE_NO,     T.XFER_TEXT,                    ");
            strSQL.Append(" T.ITEM_NO,      T.ITEM_DESC,        D.ALLOC_QTY,        S.DATA_CHAR ITEM_UMSR,          ");
            strSQL.Append(" D.LOCATION,     D.LOT_NO,           D.JOC_CD,           T.FROM_SUPPLY_TYPE SUPPLY_TYPE  ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM ");
                strSQL.Append(" TRANSFER_TRANS T,DISB_ALLOC D,WORKSHOP_MASTER WS, ");
                strSQL.Append(" WAREHOUSE_MASTER W,SYSTEM_PARAMETER S ");
                strSQL.Append(" WHERE ");
                strSQL.Append(" T.XFER_NO=D.XFER_NO ");
                strSQL.Append(" AND T.TO_WS_CD=WS.WS_CD(+) ");
                strSQL.Append(" AND T.FROM_WHS_CD=W.WHS_CD(+) ");
                strSQL.Append(" AND S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");
                strSQL.Append(" AND T.REQ_TYPE='23' ");
                if (reissue_flag == 0)
                {
                    strSQL.Append(" AND T.XFER_STATUS=0 ");
                }
                else
                {
                    strSQL.Append(" AND T.XFER_STATUS=10 ");
                }
                strSQL.Append(" AND D.ALLOC_STATUS=0 ");

                if (_whs_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WHS_CD = :WHS_CD ");
                    db.DbPsetString("_WHS_CD", _whs_cd);
                }
                strSQL.Append(" ORDER BY ");
                strSQL.Append(" T.XFER_SCH_DATE,T.FROM_WHS_CD,T.TO_WS_CD,");
                strSQL.Append(" T.SLIP_NO,T.SLIP_LINE_NO ");
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T ");
                strSQL.Append(" INNER JOIN DISB_ALLOC D ON T.XFER_NO=D.XFER_NO ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON T.TO_WS_CD=WS.WS_CD ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON T.FROM_WHS_CD=W.WHS_CD ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");

                strSQL.Append(" WHERE ");
                strSQL.Append(" T.REQ_TYPE='23' ");
                if (reissue_flag == 0)
                {
                    strSQL.Append(" AND T.XFER_STATUS=0 ");
                }
                else
                {
                    strSQL.Append(" AND T.XFER_STATUS=10 ");
                }
                strSQL.Append(" AND D.ALLOC_STATUS=0 ");

                if (_whs_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WHS_CD = @WHS_CD ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }
                strSQL.Append(" ORDER BY ");
                strSQL.Append(" T.XFER_SCH_DATE,T.FROM_WHS_CD,T.TO_WS_CD,");
                strSQL.Append(" T.SLIP_NO,T.SLIP_LINE_NO ");
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
        /// 計画外入出庫依頼
        /// 
        /// 使用画面：InvAdjReq
        /// </summary>
        public int UnplannedRcvDisbReq()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetInt("@I_RCV_DISB_FLAG", _rcv_disb_flag, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_RCV_DISB_TYPE", _rcv_disb_type, ComConst.DB_IN);
            db.DbPsetInt("@I_REQ_DATE", _req_date, ComConst.DB_IN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db.DbPsetString("@I_JOC_CD", _joc_cd, ComConst.DB_IN);
            db.DbPsetString("@I_COST_CENTER", _cost_center, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_REQ_QTY", _req_qty, ComConst.DB_IN);
            db.DbPsetString("@I_LOT_NO", _lot_no, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION", _location, ComConst.DB_IN);
            db.DbPsetInt("@I_REQ_TYPE", _req_type, ComConst.DB_IN);
            db.DbPsetInt("@I_SUPPLY_TYPE", _supply_type, ComConst.DB_IN);
            db.DbPsetString("@I_TRACE_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);   // トレース用製造指示№	 2015.06.19
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
            rtn = db.DbStored("SP_UNPLANNED_RCV_DISB_REQ");
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
        /// 製番振替
        /// 
        /// 使用画面：InvJOCTransfer
        /// </summary>
        public int JOCTransfer()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION", _location, ComConst.DB_IN);
            db.DbPsetString("@I_LOT_NO", _lot_no, ComConst.DB_IN);
            db.DbPsetString("@I_FROM_JOC_CD", _from_joc_cd, ComConst.DB_IN);
            db.DbPsetString("@I_TO_JOC_CD", _to_joc_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_TRANSFER_QTY", _transfer_qty, ComConst.DB_IN);
            db.DbPsetInt("@I_ACT_DATE", _act_date, ComConst.DB_IN);     // Add 2012.03.01 Ubiq-Sai
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_JOC_TRANSFER");
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
        /// 倉庫間振替
        /// 
        /// 使用画面：InvWhsTransfer
        /// </summary>
        public int WhsTransfer()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);

            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_FROM_WHS_CD", _from_whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_FROM_LOCATION", _from_location, ComConst.DB_IN);
            db.DbPsetString("@I_LOT_NO", _lot_no, ComConst.DB_IN);
            db.DbPsetString("@I_JOC_CD", _joc_cd, ComConst.DB_IN);
            db.DbPsetString("@I_TO_WHS_CD", _to_whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_TO_LOCATION", _to_location, ComConst.DB_IN);
            db.DbPsetDouble("@I_TRANSFER_QTY", _transfer_qty, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_WHS_TRANSFER");
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
        /// 倉庫間振替実績対象
        /// 
        /// 使用画面：InvWhsTransferAct
        /// </summary>
        public DataSet GetWhsTransferActList()//20090207 ADD LIU
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                                      ");
            strSQL.Append(" T.FROM_WHS_CD,  WHS1.WHS_DESC FROM_WHS_DESC,   T.TO_WHS_CD,     WHS2.WHS_DESC TO_WHS_DESC,  ");
            strSQL.Append(" T.SLIP_LINE_NO,     T.ITEM_NO,      T.ITEM_DESC,    T.FROM_LOCATION,    T.TO_LOCATION,      ");
            strSQL.Append(" T.TO_LOT_NO,        T.TO_JOC_CD,    T.INST_QTY,     S.DATA_CHAR ITEM_UMSR,  T.XFER_NO,      ");
            strSQL.Append(" T.XFER_STATUS                                                                               ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM                                        ");
                strSQL.Append(" TRANSFER_TRANS T,   WAREHOUSE_MASTER WHS1,  ");
                strSQL.Append(" WAREHOUSE_MASTER WHS2,SYSTEM_PARAMETER S    ");
                strSQL.Append(" WHERE                                       ");
                strSQL.Append(" T.REQ_TYPE      =       '31'                ");
                strSQL.Append(" AND T.TO_WHS_CD =       WHS2.WHS_CD(+)      ");
                strSQL.Append(" AND T.FROM_WHS_CD=      WHS1.WHS_CD(+)      ");
                strSQL.Append(" AND S.KEY01     =       'ITEM_UMSR'         ");
                strSQL.Append(" AND S.KEY02     =       T.ITEM_UMSR         ");
                strSQL.Append(" AND T.XFER_STATUS   =       10              ");
                strSQL.Append(" AND T.SLIP_NO   =       :SLIP_NO            ");

                db.DbPsetString("SLIP_NO", _slip_no);

            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T                                               ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WHS2 ON T.TO_WHS_CD  =WHS2.WHS_CD  ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WHS1 ON T.FROM_WHS_CD=WHS1.WHS_CD  ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'         ");
                strSQL.Append(" AND S.KEY02         = T.ITEM_UMSR                                   ");
                strSQL.Append(" WHERE                                                               ");
                strSQL.Append(" T.REQ_TYPE          =       '31'                                    ");
                strSQL.Append(" AND T.XFER_STATUS   =       10                                      ");
                strSQL.Append(" AND T.SLIP_NO       =       @SLIP_NO                                ");
                strSQL.Append(" AND T.DELV_NO       <>      '1'                                     "); // IMV3 DELV_NO='1'はHTで実績をあげる⇒倉庫間振替実績(HT)にて処理
                db.DbPsetString("@SLIP_NO", _slip_no);
            }
            strSQL.Append(" ORDER BY                                    ");
            strSQL.Append(" T.SLIP_LINE_NO,T.ITEM_NO                    ");

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
        /// 倉庫間振替実績HT対象(IMV3)
        /// 
        /// 使用画面：InvWhsTransferActHT
        /// </summary>
        public DataSet GetWhsTransferActListHT()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT T.SLIP_NO + '-' + LTRIM(STR(T.SLIP_LINE_NO)) SLIP_NO,                                                   ");
            strSQL.Append(" T.XFER_NO,T.TRANS_DATE REC_DATE,T.ITEM_NO,T.ITEM_DESC,T.FROM_WHS_CD,T.FROM_LOCATION,  ");
            strSQL.Append(" S.DATA_CHAR ITEM_UMSR,HT.HT_ACT_QTY ACT_QTY,HT.HT_ACT_LOCATION TO_LOCATION,HT_ACT_LOT_NO TO_LOT_NO, ");
            strSQL.Append(" T.TO_WHS_CD                                                             ");

            db.DbParametersClear();

            strSQL.Append(" FROM HOUSING_LOT_IF HT ");
            strSQL.Append(" INNER JOIN TRANSFER_TRANS T ON T.XFER_NO = HT.XFER_NO AND T.REQ_TYPE = HT.REQ_TYPE ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");
            strSQL.Append(" WHERE ");
            strSQL.Append(" HT.REQ_TYPE = '31' AND HT.HT_SEND_STATUS < 3 AND HT.HT_ACT_QTY > 0 ");

            db.DbParametersClear();
            // 
            if (_item_no != "")
            {
                strSQL.Append(" AND T.ITEM_NO   =       @ITEM_NO                            ");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_xfer_sch_date != 0)
            {
                strSQL.Append(" AND T.TRANS_DATE   =       @TRANS_DATE                            ");
                db.DbPsetInt("@TRANS_DATE", _xfer_sch_date);
            }
            
            //
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
        /// 倉庫間振替実績
        /// 
        /// 使用画面：InvWhsTransferAct
        /// </summary>
        public int WhsTransferAct()//20090207 ADD LIU
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);

            db.DbPsetString("@I_SLIP_NO", _slip_no, ComConst.DB_IN);
            db.DbPsetInt("@I_SLIP_LINE_NO", _slip_line_no, ComConst.DB_IN);
            db.DbPsetInt("@I_ACT_DATE", _act_date, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_WHS_TRANSFER_ACT");
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
        /// 倉庫間振替実績 IMV3
        /// 
        /// 使用画面：InvWhsTransferActHT
        /// </summary>
        public int WhsTransferActHT()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);

            db.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_IN);
            db.DbPsetInt("@I_ACT_DATE", _act_date, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_WHS_TRANSFER_ACT_HT");
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
        /// 倉庫間振替依頼
        /// 
        /// 使用画面：InvWhsTransferReq
        /// </summary>
        public int WhsTransferReq()//20090207 ADD LIU
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_FROM_WHS_CD", _from_whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_FROM_LOCATION", _from_location, ComConst.DB_IN);
            db.DbPsetString("@I_LOT_NO", _lot_no, ComConst.DB_IN);
            db.DbPsetString("@I_JOC_CD", _joc_cd, ComConst.DB_IN);
            db.DbPsetString("@I_TO_WHS_CD", _to_whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_TO_LOCATION", _to_location, ComConst.DB_IN);
            db.DbPsetDouble("@I_TRANSFER_QTY", _transfer_qty, ComConst.DB_IN);
            db.DbPsetInt("@I_REQUEST_NO", _request_no, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_WHS_TRANSFER_REQ");
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
        /// 倉庫間振替伝票発行
        /// 
        /// <para>使用画面：[InvWhsTransferList]</para>
        /// </summary>
        public DataSet GetWhsTransferList()//20090207 ADD LIU
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                                      ");
            strSQL.Append(" T.SLIP_NO,          T.XFER_SCH_DATE,                T.FROM_WHS_CD,                          ");
            strSQL.Append(" WHS1.WHS_DESC FROM_WHS_DESC,        T.TO_WHS_CD,    WHS2.WHS_DESC TO_WHS_DESC,              ");
            strSQL.Append(" T.SLIP_LINE_NO,     T.ITEM_NO,      T.ITEM_DESC,    T.FROM_LOCATION,    T.TO_LOCATION,      ");
            //strSQL.Append(" T.TO_LOT_NO,        T.TO_JOC_CD,    T.INST_QTY,     S.DATA_CHAR ITEM_UMSR                   ");
            strSQL.Append(" T.TO_LOT_NO,        T.XFER_NO TO_JOC_CD,    T.INST_QTY,     S.DATA_CHAR ITEM_UMSR                   "); // IMV3

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM                                        ");
                strSQL.Append(" TRANSFER_TRANS T,   WAREHOUSE_MASTER WHS1,  ");
                strSQL.Append(" WAREHOUSE_MASTER WHS2,SYSTEM_PARAMETER S    ");
                strSQL.Append(" WHERE                                       ");
                strSQL.Append(" T.REQ_TYPE      =       :REQ_TYPE           ");
                strSQL.Append(" AND T.TO_WHS_CD =       WHS2.WHS_CD(+)      ");
                strSQL.Append(" AND T.FROM_WHS_CD=      WHS1.WHS_CD(+)      ");
                strSQL.Append(" AND S.KEY01     =       'ITEM_UMSR'         ");
                strSQL.Append(" AND S.KEY02     =       T.ITEM_UMSR         ");
                strSQL.Append(" AND T.XFER_STATUS   =    0                  ");
                if (_from_whs_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WHS_CD   =    FROM_WHS_CD        ");
                    db.DbPsetString("FROM_WHS_CD", _from_whs_cd);
                }
                db.DbPsetInt("REQ_TYPE", _req_type);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T                                               ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WHS2 ON T.TO_WHS_CD  =WHS2.WHS_CD  ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WHS1 ON T.FROM_WHS_CD=WHS1.WHS_CD  ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'         ");
                strSQL.Append(" AND S.KEY02 = T.ITEM_UMSR                                           ");
                strSQL.Append(" WHERE  T.REQ_TYPE          =       @REQ_TYPE                        ");
                if (reissue_flag == 0)//発行の場合
                {
                    strSQL.Append(" AND T.XFER_STATUS=0         ");
                }
                else//再発行の場合
                {
                    strSQL.Append(" AND T.XFER_STATUS=10         ");
                }
                if (_from_whs_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WHS_CD   =       @FROM_WHS_CD                            ");
                    db.DbPsetString("@FROM_WHS_CD", _from_whs_cd);
                }

                // IMV3
                if (_from_location != "")
                {
                    strSQL.Append(" AND T.FROM_LOCATION   =       @FROM_LOCATION                            ");
                    db.DbPsetString("@FROM_LOCATION", _from_location);
                }

                db.DbPsetInt("@REQ_TYPE", _req_type);
            }
            strSQL.Append(" ORDER BY                                    ");
            //strSQL.Append(" T.SLIP_LINE_NO,T.ITEM_NO                    ");
            strSQL.Append(" T.FROM_WHS_CD,  T.XFER_SCH_DATE,    T.SLIP_NO,      T.SLIP_LINE_NO,     T.ITEM_NO  ");//UPD UBIQ-LIU 2010/07/16

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
        /// 倉庫間振替伝票出力プロシージャをCALLして、TRANSFER_TRANSのステータスを更新する。
        /// 
        /// 使用画面：InvWhsTransferAct
        /// </summary>
        public int WhsTransferListPrint(ComDB db)//20090207 ADD LIU
        {
            //ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_SLIP_NO", _slip_no, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_WHS_TRANSFER_LIST_PRINT");
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
        /// 仕入先返品実績対象(IMV3)
        /// 
        /// 使用画面：PurReturnAct
        /// </summary>
        public DataSet GetPurReturnActList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT T.SLIP_NO + '-' + LTRIM(STR(T.SLIP_LINE_NO)) SLIP_NO, T.PO_NO,                  ");
            strSQL.Append(" T.XFER_NO,T.TRANS_DATE REC_DATE,T.ITEM_NO,T.ITEM_DESC,T.FROM_WHS_CD,T.FROM_LOCATION,  ");
            strSQL.Append(" S.DATA_CHAR ITEM_UMSR,HT.HT_ACT_QTY ACT_QTY,HT.HT_ACT_LOCATION TO_LOCATION,HT_ACT_LOT_NO FROM_LOT_NO, ");
            strSQL.Append(" T.TO_WHS_CD,T.XFER_TEXT                                                            ");

            db.DbParametersClear();

            strSQL.Append(" FROM VENDOR_RETURN_IF HT ");
            strSQL.Append(" INNER JOIN TRANSFER_TRANS T ON T.XFER_NO = HT.XFER_NO AND T.REQ_TYPE = 25 ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = T.ITEM_UMSR ");
            strSQL.Append(" WHERE ");
            strSQL.Append(" HT.HT_SEND_STATUS < 3 AND HT.HT_ACT_QTY > 0 ");

            db.DbParametersClear();
            // 
            if (_item_no != "")
            {
                strSQL.Append(" AND T.ITEM_NO   =       @ITEM_NO                            ");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_xfer_sch_date != 0)
            {
                strSQL.Append(" AND T.TRANS_DATE   =       @TRANS_DATE                            ");
                db.DbPsetInt("@TRANS_DATE", _xfer_sch_date);
            }
            if (_vendor_cd != "")
            {
                strSQL.Append(" AND T.TO_VC_CD   =       @TO_VC_CD                            ");
                db.DbPsetString("@TO_VC_CD", _vendor_cd);
            }
            if (_po_no != "")
            {
                //strSQL.Append(" AND T.PO_NO   =       @PO_NO                            ");
                strSQL.Append("   AND (T.PO_NO = @PO_NO OR T.SLIP_NO = @PO_NO) "); // 2015.03.03                db.DbPsetString("@PO_NO", _po_no);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND T.FROM_WHS_CD   =       @FROM_WHS_CD                            ");
                db.DbPsetString("@FROM_WHS_CD", _whs_cd);
            }

            //
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
        /// 仕入先返品伝票発行(IMV3)
        /// 
        /// <para>使用画面：[PurReturnList]</para>
        /// </summary>
        public DataSet GetPurReturnList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                                      ");
            strSQL.Append(" T.SLIP_NO,          T.XFER_SCH_DATE,                T.FROM_WHS_CD,                          ");
            strSQL.Append(" WHS1.WHS_DESC FROM_WHS_DESC,                                                                ");
            strSQL.Append(" T.SLIP_LINE_NO,     T.ITEM_NO,      T.ITEM_DESC,    T.FROM_LOCATION,                        ");
            strSQL.Append(" T.FROM_LOT_NO TO_LOT_NO,        T.XFER_NO TO_JOC_CD,    T.INST_QTY,     S.DATA_CHAR ITEM_UMSR,   ");
            strSQL.Append(" V.VENDOR_NAME TO_LOCATION   ");

            db.DbParametersClear();

            strSQL.Append(" FROM TRANSFER_TRANS T                                               ");
            strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON T.TO_VC_CD  =V.VENDOR_CD  ");
            strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WHS1 ON T.FROM_WHS_CD=WHS1.WHS_CD  ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'         ");
            strSQL.Append(" AND S.KEY02 = T.ITEM_UMSR                                           ");
            strSQL.Append(" WHERE  T.REQ_TYPE          =       @REQ_TYPE                        ");
            if (reissue_flag == 0)//発行の場合
            {
                strSQL.Append(" AND T.XFER_STATUS=0         ");
            }
            else//再発行の場合
            {
                strSQL.Append(" AND T.XFER_STATUS=10         ");
            }
            if (_from_whs_cd != "")
            {
                strSQL.Append(" AND T.FROM_WHS_CD   =       @FROM_WHS_CD                            ");
                db.DbPsetString("@FROM_WHS_CD", _from_whs_cd);
            }

            // IMV3
            if (_from_location != "")
            {
                strSQL.Append(" AND T.FROM_LOCATION   =       @FROM_LOCATION                            ");
                db.DbPsetString("@FROM_LOCATION", _from_location);
            }

            db.DbPsetInt("@REQ_TYPE", _req_type);

            strSQL.Append(" ORDER BY                                    ");
            //strSQL.Append(" T.SLIP_LINE_NO,T.ITEM_NO                    ");
            strSQL.Append(" T.FROM_WHS_CD,  T.XFER_SCH_DATE,    T.SLIP_NO,      T.SLIP_LINE_NO,     T.ITEM_NO  ");//UPD UBIQ-LIU 2010/07/16

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
        /// 仕入先返品実績 IMV3
        /// 
        /// 使用画面：PurReturnAct
        /// </summary>
        public int PurReturnAct()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);

            db.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_IN);
            db.DbPsetInt("@I_ACT_DATE", _act_date, ComConst.DB_IN);
            db.DbPsetString("@I_XFER_TEXT", _xfer_text, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PUR_RETURN_ACT");
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
        /// 仕掛在庫調整
        /// 
        /// 使用画面：WipAdjReq
        /// </summary>
        public int UnplannedWipRcvDisbReq()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetInt("@I_RCV_DISB_FLAG", _rcv_disb_flag, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetString("@I_RCV_DISB_TYPE", _rcv_disb_type, ComConst.DB_IN);
            db.DbPsetInt("@I_REQ_DATE", _req_date, ComConst.DB_IN);
            db.DbPsetString("@I_FROM_WHS_CD", _from_whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db.DbPsetString("@I_JOC_CD", _joc_cd, ComConst.DB_IN);
            db.DbPsetString("@I_COST_CENTER", _cost_center, ComConst.DB_IN);
            db.DbPsetString("@I_TO_WHS_CD", _to_whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_TO_LOCATION", _to_location, ComConst.DB_IN);
            db.DbPsetDouble("@I_REQ_QTY", _req_qty, ComConst.DB_IN);
            db.DbPsetString("@I_LOT_NO", _lot_no, ComConst.DB_IN);
            db.DbPsetInt("@I_REQ_TYPE", _req_type, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USERID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@I_INV_TYPE", 0, ComConst.DB_IN);
            db.DbPsetString("@I_MNG_NO", "", ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", "", ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_UNPLANNED_WIP_RCV_DISB_REQ");
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
        /// 倉庫間振替依頼(SDMIF)
        /// 
        /// <para>使用画面：[SDMIFWhsTransfer]</para>
        /// </summary>
        public int SDMIFWhsTransfer()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_FROM_WHS_CD", _from_whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_FROM_LOCATION", _from_location, ComConst.DB_IN);
            db.DbPsetString("@I_LOT_NO", _lot_no, ComConst.DB_IN);
            db.DbPsetString("@I_JOC_CD", _joc_cd, ComConst.DB_IN);
            db.DbPsetString("@I_TO_WHS_CD", _to_whs_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_TRANSFER_QTY", _transfer_qty, ComConst.DB_IN);
            db.DbPsetInt("@I_REQUEST_NO", _request_no, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_SDMIF_WHS_TRANSFER_REQ");
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
        /// 倉替伝票出力プロシージャ(SDMIF)
        /// 
        /// <para>使用画面：[SDMIFWhsTransferList]</para>
        /// </summary>
        public int SDMIFWhsTransferPrint(ComDB db)
        {
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_SLIP_NO", _slip_no, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();
            rtn = db.DbStored("SP_SDMIF_WHS_TRANSFER_PRINT");
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
        /// 倉替伝票(SDMIF)発行
        /// 
        /// <para>使用画面：[SDMIFWhsTransferList]</para>
        /// </summary>
        public DataSet GetSdmifWhsTransferList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                                      ");
            strSQL.Append(" T.SLIP_NO,          T.XFER_SCH_DATE,                T.FROM_WHS_CD,                          ");
            strSQL.Append(" WHS1.WHS_DESC FROM_WHS_DESC,        T.TO_WHS_CD,    WHS2.WHS_DESC TO_WHS_DESC,              ");
            strSQL.Append(" T.SLIP_LINE_NO,     T.ITEM_NO,      T.ITEM_DESC,    T.TO_LOCATION,                          ");
            strSQL.Append(" T.TO_LOT_NO,        T.TO_JOC_CD,    T.INST_QTY,     S.DATA_CHAR ITEM_UMSR                   ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM TRANSFER_TRANS T                                               ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WHS2 ON T.TO_WHS_CD  =WHS2.WHS_CD  ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WHS1 ON T.FROM_WHS_CD=WHS1.WHS_CD  ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'         ");
                strSQL.Append(" AND S.KEY02 = T.ITEM_UMSR                                           ");
                strSQL.Append(" WHERE  T.REQ_TYPE          =       @REQ_TYPE                        ");
                if (reissue_flag == 0)//発行の場合
                {
                    strSQL.Append(" AND T.SLIP_PRINT_FLAG=0         ");
                }
                else//再発行の場合
                {
                    strSQL.Append(" AND T.SLIP_PRINT_FLAG=1         ");
                }
                if (_from_whs_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WHS_CD   =       @FROM_WHS_CD                            ");
                    db.DbPsetString("@FROM_WHS_CD", _from_whs_cd);
                }
                db.DbPsetInt("@REQ_TYPE", _req_type);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T                                               ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WHS2 ON T.TO_WHS_CD  =WHS2.WHS_CD  ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WHS1 ON T.FROM_WHS_CD=WHS1.WHS_CD  ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'         ");
                strSQL.Append(" AND S.KEY02 = T.ITEM_UMSR                                           ");
                strSQL.Append(" WHERE  T.REQ_TYPE          =       @REQ_TYPE                        ");
                if (reissue_flag == 0)//発行の場合
                {
                    strSQL.Append(" AND T.SLIP_PRINT_FLAG=0         ");
                }
                else//再発行の場合
                {
                    strSQL.Append(" AND T.SLIP_PRINT_FLAG=1         ");
                }
                if (_from_whs_cd != "")
                {
                    strSQL.Append(" AND T.FROM_WHS_CD   =       @FROM_WHS_CD                            ");
                    db.DbPsetString("@FROM_WHS_CD", _from_whs_cd);
                }
                db.DbPsetInt("@REQ_TYPE", _req_type);
            }
            strSQL.Append(" ORDER BY                                                                            ");
            strSQL.Append(" T.FROM_WHS_CD,  T.XFER_SCH_DATE,    T.SLIP_NO,      T.SLIP_LINE_NO,     T.ITEM_NO   ");
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
