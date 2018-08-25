﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;
using IMClass;

namespace IMClass
{
    public class Rcv
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Rcv()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Rcv(string p_user_id, int p_lang)
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
        protected string _db_type = "";
        protected int _lang = 1;

        protected string _po_no = "";
        protected string _item_no = "";
        protected string _item_desc = "";
        protected string _vendor_cd = "";
        protected double _po_qty = 0;
        protected double _recv_qty = 0;
		protected double _accept_qty = 0;
        protected string _po_umsr = "";
        protected int _po_due_date = 0;
        protected string _sch_id = "";
        protected string _buyer_cd = "";
        protected string _joc_cd = "";
        protected string _whs_cd = "";
        protected string _vendor_desc = "";
        protected string _whs_desc = "";
        protected string _buyer_desc = "";
        protected string _catg_cd = "";
        protected int _po_line_no = 0;
        protected double _order_status = 0.0;
        protected double _po_prc = 0.0;
        protected string _po_cur = "";
        protected double _po_amt = 0.0;
        protected string _po_note = "";
        protected string _insp_cd = "";
        protected double _lot_cntl_flag = 0.0;
        protected string _insp_name = "";
        protected string _data_int = "";
        //PurRcvの更新
        protected double _rej_qty = 0;
        protected double _recv_qty_pur_umsr = 0.0;
        protected string _po_slip_type = "";    //Add 2013.05.24 Ubiq-Sai
        //protected double _XFER_SCH_DATE = 0.0;//DEL 20090212 UBIQ-ZHAO
        protected int _xfer_sch_date = 0;
        protected string _delv_no = "";
        protected string _to_lot_no = "";
        protected string _to_location = "";
        protected int _dev_compl_type = 0;
        protected string _location = "";
        protected int _unit_prc_type = 0;
        //PurRcvCancel 
        protected int _recv_date = 0;
        protected int _partial_delv_compl_cnt = 0;
        //PurInsp 
        protected double _qty_pur_umsr = 0.0;
        protected double _destruct_qty_pur_umsr = 0.0;
        protected double _rej_qty_pur_umsr = 0.0;
        protected string _xfer_text = "";
        protected int _slip_date = 0;
        //PurReturn
        protected int _beg_eff_date = 0;
        protected int _end_eff_date = 0;
        protected int _return_date = 0;
        protected string _lot_no = "";
        protected double _return_qty = 0.0;
        protected string _return_umsr = "";
        protected double _return_prc = 0.0;
        protected string _return_cur = "";
        //PurReturn
        protected string _xfer_no = "";

        protected double _label_qty = 0.0;
        protected double _print_unit_qty = 0.0;
        protected int _print_flag = 0;
        protected string _sp_data_int = "";
        protected int _xfer_sch_date_from = 0;
        protected int _xfer_sch_date_to = 0;
        protected int _supply_type = 0;

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
        protected int _flag = 0;//ADD BY UBIQ-LIU 2010/6/17

        protected double _cmpl_input_prc = 0;   // IMV3 カートン通番
        protected double _cmpl_input_amt = 0;   // IMV3 カートン数
        protected double _umsr_conv_ratio = 0;   // IMV3
        protected string _inv_umsr_name = "";  // IMV3
        protected string _approve_user_id = "";  // IMV3 ラベル枚数
        protected string _pegging_type = "";  // IMV3
        protected string _supplier_lot_no = ""; // 2015.10.26

        protected string _part_no = "";
        protected string _optmethod = "";
        protected int _receive_qty = 0;
        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        public int lang { get { return _lang; } set { _lang = value; } }
        public string po_no { get { return _po_no; } set { _po_no = value; } }
        public string item_no { get { return _item_no; } set { _item_no = value; } }
        public string item_desc { get { return _item_desc; } set { _item_desc = value; } }
        public string vendor_cd { get { return _vendor_cd; } set { _vendor_cd = value; } }
        public double po_qty { get { return _po_qty; } set { _po_qty = value; } }
        public double recv_qty { get { return _recv_qty; } set { _recv_qty = value; } }
		public double accept_qty { get { return _accept_qty; } set { _accept_qty = value; } }
        public string po_umsr { get { return _po_umsr; } set { _po_umsr = value; } }
        public int po_due_date { get { return _po_due_date; } set { _po_due_date = value; } }
        public string sch_id { get { return _sch_id; } set { _sch_id = value; } }
        public string buyer_cd { get { return _buyer_cd; } set { _buyer_cd = value; } }
        public string joc_cd { get { return _joc_cd; } set { _joc_cd = value; } }
        public string whs_cd { get { return _whs_cd; } set { _whs_cd = value; } }
        public string vendor_desc { get { return _vendor_desc; } set { _vendor_desc = value; } }
        public string whs_desc { get { return _whs_desc; } set { _whs_desc = value; } }
        public string buyer_desc { get { return _buyer_desc; } set { _buyer_desc = value; } }
        public string catg_cd { get { return _catg_cd; } set { _catg_cd = value; } }
        public int po_line_no { get { return _po_line_no; } set { _po_line_no = value; } }
        public double order_status { get { return _order_status; } set { _order_status = value; } }
        public double po_prc { get { return _po_prc; } set { _po_prc = value; } }
        public string po_cur { get { return _po_cur; } set { _po_cur = value; } }
        public double po_amt { get { return _po_amt; } set { _po_amt = value; } }
        public string po_note { get { return _po_note; } set { _po_note = value; } }
        public string insp_cd { get { return _insp_cd; } set { _insp_cd = value; } }
        public string data_int { get { return _data_int; } set { _data_int = value; } }
        public double lot_cntl_flag { get { return _lot_cntl_flag; } set { _lot_cntl_flag = value; } }
        public double recv_qty_pur_umsr { get { return _recv_qty_pur_umsr; } set { _recv_qty_pur_umsr = value; } }
        public string po_slip_type { get { return _po_slip_type; } set { _po_slip_type = value; } }    //Add 2013.05.24 Ubiq-Sai
        public int xfer_sch_date { get { return _xfer_sch_date; } set { _xfer_sch_date = value; } }
        public string delv_no { get { return _delv_no; } set { _delv_no = value; } }
        public string to_lot_no { get { return _to_lot_no; } set { _to_lot_no = value; } }
        public string to_location { get { return _to_location; } set { _to_location = value; } }
        public int dev_compl_type { get { return _dev_compl_type; } set { _dev_compl_type = value; } }
        public string location { get { return _location; } set { _location = value; } }
        public int unit_prc_type { get { return _unit_prc_type; } set { _unit_prc_type = value; } }
        public string insp_name { get { return _insp_name; } set { _insp_name = value; } }
        public int recv_date { get { return _recv_date; } set { _recv_date = value; } }
        public int partial_delv_compl_cnt { get { return _partial_delv_compl_cnt; } set { _partial_delv_compl_cnt = value; } }
        public double qty_pur_umsr { get { return _qty_pur_umsr; } set { _qty_pur_umsr = value; } }
        public double destruct_qty_pur_umsr { get { return _destruct_qty_pur_umsr; } set { _destruct_qty_pur_umsr = value; } }
        public double rej_qty_pur_umsr { get { return _rej_qty_pur_umsr; } set { _rej_qty_pur_umsr = value; } }
        public string xfer_text { get { return _xfer_text; } set { _xfer_text = value; } }
        public int slip_date { get { return _slip_date; } set { _slip_date = value; } }
        public int beg_eff_date { get { return _beg_eff_date; } set { _beg_eff_date = value; } }
        public int end_eff_date { get { return _end_eff_date; } set { _end_eff_date = value; } }
        public int return_date { get { return _return_date; } set { _return_date = value; } }
        public string lot_no { get { return _lot_no; } set { _lot_no = value; } }
        public double return_qty { get { return _return_qty; } set { _return_qty = value; } }
        public string return_umsr { get { return _return_umsr; } set { _return_umsr = value; } }
        public double return_prc { get { return _return_prc; } set { _return_prc = value; } }
        public string return_cur { get { return _return_cur; } set { _return_cur = value; } }
        public string xfer_no { get { return _xfer_no; } set { _xfer_no = value; } }
        public double rej_qty { get { return _rej_qty; } set { _rej_qty = value; } }
        public double label_qty { get { return _label_qty; } set { _label_qty = value; } }
        public double print_unit_qty { get { return _print_unit_qty; } set { _print_unit_qty = value; } }
        public int print_flag { get { return _print_flag; } set { _print_flag = value; } }
        public string sp_data_int { get { return _sp_data_int; } set { _sp_data_int = value; } }
        public int xfer_sch_date_from { get { return _xfer_sch_date_from; } set { _xfer_sch_date_from = value; } }
        public int xfer_sch_date_to { get { return _xfer_sch_date_to; } set { _xfer_sch_date_to = value; } }
        public int supply_type { get { return _supply_type; } set { _supply_type = value; } }
        public int flag { get { return _flag; } set { _flag = value; } }

        public double cmpl_input_prc { get { return _cmpl_input_prc; } set { _cmpl_input_prc = value; } }   // IMV3
        public double cmpl_input_amt { get { return _cmpl_input_amt; } set { _cmpl_input_amt = value; } }   // IMV3
        public double umsr_conv_ratio { get { return _umsr_conv_ratio; } set { _umsr_conv_ratio = value; } }   // IMV3
        public string inv_umsr_name { get { return _inv_umsr_name; } set { _inv_umsr_name = value; } }
        public string approve_user_id { get { return _approve_user_id; } set { _approve_user_id = value; } }
        public string pegging_type { get { return _pegging_type; } set { _pegging_type = value; } }
        public string supplier_lot_no { get { return _supplier_lot_no; } set { _supplier_lot_no = value; } }

        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }

        public string part_no { get { return _part_no; } set { _part_no = value; } }
        public string optmethod { get { return _optmethod; } set { _optmethod = value; } }
        public int receive_qty { get { return _receive_qty; } set { _receive_qty = value; } }
        #endregion

        public int Insert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@PART_NO", _part_no, ComConst.DB_IN);
            db.DbPsetString("@OPTMETHOD", _optmethod, ComConst.DB_IN);
            db.DbPsetInt("@RECEIVE_QTY", _receive_qty, ComConst.DB_IN);
            db.DbPsetString("@CREATE_BY", _chg_user_id, ComConst.DB_IN);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);



            db.DbBeginTrans();
            rtn = db.DbStored("SP_MATERIAL_RECEIVE_INSERT");
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
        public DataSet GetPartNo(string PartNo)
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                        ");
            strSQL.Append(" PART_NO             ");
            strSQL.Append(" FROM ITEM_MASTER   ");
            strSQL.Append(" WHERE [PART_NO] = '" + PartNo + "' ");
            strSQL.Append(" ORDER BY PART_NO      ");

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "Cal");
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
        /// PurPoComeUpの取得
        /// <para>使用画面：MstPurPOComeUpInqMnt</para>
        /// </summary>
        public DataSet Get_Pur_PoComeUpList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                                   ");
            strSQL.Append("  CASE PUR.PO_NO WHEN NULL THEN NULL WHEN '' THEN NULL ELSE PUR.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),PUR.PO_LINE_NO),3) END AS PO_NO 	,	    		 ");
            strSQL.Append("  PUR.ITEM_NO					,PUR.ITEM_DESC	,		                                 ");
            strSQL.Append(" V.VENDOR_NAME ,                  PUR.PO_QTY                     ,PUR.RECV_QTY  ,         ");
            strSQL.Append(" PUR.ACCEPT_QTY	,                PUR.ACCEPT_QTY	                ,PUR.VENDOR_CD ,         ");
            strSQL.Append(" PUR.PO_UMSR ,                    PUR.PO_DUE_DATE	            ,PUR.SCH_ID ,            ");
            strSQL.Append(" PUR.SCH_ID,	                     PUR.BUYER_CD                   ,PUR.JOC_CD     ,        ");
            strSQL.Append(" W.WHS_DESC	,	                 RECV_QTY,                                               ");
			strSQL.Append(" I.CATG_CD ,		                 PUR.WHS_CD ,                                            ");
			strSQL.Append(" PUR.ACCEPT_QTY,		PUR.REJ_QTY, (CASE WHEN (PUR.PO_QTY-PUR.RECV_QTY+PUR.REJ_QTY) <0	");//2010/10/29 検収済数、不良数、発注残数を追加表示する。by liu
			strSQL.Append("  THEN 0 ELSE (PUR.PO_QTY-PUR.RECV_QTY+PUR.REJ_QTY) END) RESIDUEQTY,						");//2010/10/29 検収済数、不良数、発注残数を追加表示する。by liu
            strSQL.Append(" S2.DATA_CHAR AS SCH_NAME ,S3.DATA_CHAR AS BUYER_NAME	,S1.DATA_CHAR AS UMSR_NAME	     ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PUR_ORDER PUR , ITEM_MASTER I , VENDOR_MASTER  V , WAREHOUSE_MASTER  W,    ");
                strSQL.Append(" SYSTEM_PARAMETER  S1 , SYSTEM_PARAMETER  S2 ,                                   ");
                strSQL.Append(" SYSTEM_PARAMETER  S5                                                            ");
                strSQL.Append(" WHERE  PUR.ORDER_STATUS           >=:25                                         ");
                strSQL.Append("   AND PUR.ORDER_STATUS         < : 77                                           ");
                strSQL.Append("   AND PUR.ITEM_NO             = I.ITEM_NO(+)                                    ");
                strSQL.Append("   AND PUR.VENDOR_CD           = V.VENDOR_CD (+)                                 ");
                strSQL.Append("   AND PUR.WHS_CD              = W.WHS_CD (+)                                    ");
                strSQL.Append("   AND PUR.PO_UMSR               =S1.KEY02(+)  AND  S1.KEY01='ITEM_UMSR'         ");
                strSQL.Append("   AND PUR.SCH_ID                =S2.KEY02(+)  AND  S2.KEY01='SCH_ID'            ");
                strSQL.Append("   AND PUR.BUYER_CD              =S3.KEY02(+)  AND  S3.KEY01='BUYER_CD'          ");

                db.DbParametersClear();
                if (_po_due_date != 0)
                {
                    strSQL.Append("   AND PUR.PO_DUE_DATE        =:PO_DUE_DATE");
                    db.DbPsetInt("PO_DUE_DATE", _po_due_date);
                }
                if (_sch_id != "")
                {
                    strSQL.Append("   AND PUR.SCH_ID        =:SCH_ID");
                    db.DbPsetString("SCH_ID", _sch_id);
                }
                if (_buyer_cd != "")
                {
                    strSQL.Append("   AND PUR.BUYER_CD        =:BUYER_CD");
                    db.DbPsetString("BUYER_CD", _buyer_cd);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append("   AND PUR.VENDOR_CD        =:VENDOR_CD");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("   AND PUR.ITEM_NO        =:ITEM_NO");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_catg_cd != "")
                {
                    strSQL.Append("   AND I.CATG_CD       =:ITEM_TYPE");
                    db.DbPsetString("ITEM_TYPE", _catg_cd);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("   AND PUR.JOC_CD       =:JOC_CD");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append("   AND PUR.WHS_CD       =:WHS_CD");
                    db.DbPsetString("WHS_CD", _whs_cd);
                }
                strSQL.Append(" ORDER BY   PUR.PO_DUE_DATE                                                                       ");
            }
            else
            {
                strSQL.Append(" FROM PUR_ORDER PUR                                                                            ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER I ON PUR.ITEM_NO=I.ITEM_NO                                              ");
                strSQL.Append(" LEFT JOIN VENDOR_MASTER V ON PUR.VENDOR_CD=V.VENDOR_CD                                        ");
                strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER W ON PUR.WHS_CD=W.WHS_CD                                           ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON    S1.KEY01='ITEM_UMSR'  AND      PUR.PO_UMSR = S1.KEY02    ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S2 ON    S2.KEY01='SCH_ID'     AND      PUR.SCH_ID   = S2.KEY02   ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S3 ON    S3.KEY01='BUYER_CD'   AND      PUR.BUYER_CD  = S3.KEY02  ");
				//strSQL.Append(" WHERE  PUR.ORDER_STATUS >= 25                                                                 ");
				strSQL.Append(" WHERE  PUR.ORDER_STATUS >= 10                                                                 ");
                strSQL.Append(" AND PUR.ORDER_STATUS <75                                                                      ");

                db.DbParametersClear();

                if (_po_due_date != 0)
                {
                    strSQL.Append("   AND PUR.PO_DUE_DATE        <=@PO_DUE_DATE");
                    db.DbPsetInt("@PO_DUE_DATE", _po_due_date);
                }
                if (_sch_id != "")
                {
                    strSQL.Append("   AND PUR.SCH_ID        =@SCH_ID");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (_buyer_cd != "")
                {
                    strSQL.Append("   AND PUR.BUYER_CD        =@BUYER_CD");
                    db.DbPsetString("@BUYER_CD", _buyer_cd);
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
                if (_catg_cd != "")
                {
                    strSQL.Append("   AND I.CATG_CD       =@ITEM_TYPE");
                    db.DbPsetString("@ITEM_TYPE", _catg_cd);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("   AND PUR.JOC_CD       =@JOC_CD");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append("   AND PUR.WHS_CD       =@WHS_CD");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }

                strSQL.Append(" ORDER BY   PUR.PO_DUE_DATE                                                                       ");
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
        /// PurPoComeUpRptの取得
        /// <para>使用画面：MstPurPOComeUpRptMnt</para>
        /// </summary>
        public DataSet Get_Pur_PoComeUpRptList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                                       ");
            strSQL.Append(" CASE PUR.PO_NO WHEN NULL THEN NULL WHEN '' THEN NULL ELSE PUR.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),PUR.PO_LINE_NO),3) END AS PO_NO 	   ,PUR.ITEM_NO	,    ");
            strSQL.Append(" PUR.VENDOR_CD ,                  PUR.PO_QTY                      ,PUR.RECV_QTY    ,          ");
            strSQL.Append(" PUR.ACCEPT_QTY,                  PUR.PO_UMSR                     ,PUR.PO_DUE_DATE ,          ");
            strSQL.Append(" PUR.SCH_ID,                      PUR.BUYER_CD                    ,PUR.JOC_CD      ,          ");
            strSQL.Append(" PUR.WHS_CD	,	                 I.CATG_CD	                     ,V.VENDOR_NAME   ,          ");
            strSQL.Append(" W.WHS_DESC ,                     PUR.ITEM_DESC,                                              ");
			strSQL.Append(" S1.DATA_CHAR AS   UMSR_NAME ,    S2.DATA_CHAR AS SCH_NAME ,      	                         ");
			strSQL.Append(" PUR.ACCEPT_QTY,		PUR.REJ_QTY, (CASE WHEN (PUR.PO_QTY-PUR.RECV_QTY+PUR.REJ_QTY) <0			");//2010/10/29 検収済数、不良数、発注残数を追加表示する。by liu
			strSQL.Append("  THEN 0 ELSE (PUR.PO_QTY-PUR.RECV_QTY+PUR.REJ_QTY) END) RESIDUEQTY,								");//2010/10/29 検収済数、不良数、発注残数を追加表示する。by liu
            strSQL.Append(" S3.DATA_CHAR AS   BUYER_NAME     	                                                         ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PUR_ORDER PUR , ITEM_MASTER I,WAREHOUSE_MASTER W,                                   ");
                strSQL.Append(" WHERE  PUR.ORDER_STATUS           >=:25                                                  ");
                strSQL.Append("   AND PUR.ORDER_STATUS         < : 77                                                    ");
                strSQL.Append("   AND PUR.ITEM_NO = I.ITEM_NO(+)                                                         ");
                strSQL.Append("   AND PUR.VENDOR_CD = V.VENDOR_CD(+)                                                     ");
                strSQL.Append("   AND PUR.WHS_CD = W.WHS_CD(+)                                                           ");
                strSQL.Append("   AND PUR.PO_UMSR               =S1.KEY02(+) AND  S1.KEY01='ITEM_UMSR'                     ");
                strSQL.Append("   AND PUR.SCH_ID                =S2.KEY02(+) AND  S2.KEY01='SCH_ID'                      ");
                db.DbParametersClear();
                if (_po_due_date != 0)
                {
                    strSQL.Append(" AND PUR.PO_DUE_DATE        <=:PO_DUE_DATE");
                    db.DbPsetInt("PO_DUE_DATE", _po_due_date);
                }
                if (_sch_id != "")
                {
                    strSQL.Append("   AND PUR.SCH_ID        =:SCH_ID");
                    db.DbPsetString("SCH_ID", _sch_id);
                }
                if (_buyer_cd != "")
                {
                    strSQL.Append("   AND PUR.BUYER_CD        =:BUYER_CD");
                    db.DbPsetString("BUYER_CD", _buyer_cd);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append("   AND PUR.VENDOR_CD        =:VENDOR_CD");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("   AND PUR.ITEM_NO        =:ITEM_NO");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_catg_cd != "")
                {
                    strSQL.Append("   AND I.CATG_CD       =:ITEM_TYPE");
                    db.DbPsetString("ITEM_TYPE", _catg_cd);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("   AND PUR.JOC_CD       =:JOC_CD");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append("   AND PUR.WHS_CD       =:WHS_CD");
                    db.DbPsetString("WHS_CD", _whs_cd);
                }
                strSQL.Append(" ORDER  BY    PUR.PO_DUE_DATE                                                              ");
            }
            else
            {
                strSQL.Append(" FROM PUR_ORDER PUR                                                                     ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER I ON PUR.ITEM_NO=I.ITEM_NO                                       ");
                strSQL.Append(" LEFT JOIN VENDOR_MASTER V ON PUR.VENDOR_CD = V.VENDOR_CD                               ");
                strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER W ON PUR.WHS_CD=W.WHS_CD                                    ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON   PUR.PO_UMSR = S1.KEY02  AND  S1.KEY01='ITEM_UMSR'  ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S2 ON   PUR.SCH_ID = S2.KEY02   AND  S2.KEY01='SCH_ID'     ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S3 ON   PUR.BUYER_CD =S3.KEY02  AND  S3.KEY01='BUYER_CD'   ");
				//strSQL.Append(" WHERE  PUR.ORDER_STATUS >= 25                                                          ");
				strSQL.Append(" WHERE  PUR.ORDER_STATUS >= 10                                                          ");
                strSQL.Append(" AND PUR.ORDER_STATUS <75                                                               ");
                db.DbParametersClear();

                if (_po_due_date != 0)
                {
                    strSQL.Append("   AND PUR.PO_DUE_DATE        <=@PO_DUE_DATE");
                    db.DbPsetInt("@PO_DUE_DATE", _po_due_date);
                }
                if (_sch_id != "")
                {
                    strSQL.Append("   AND PUR.SCH_ID        =@SCH_ID");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (_buyer_cd != "")
                {
                    strSQL.Append("   AND PUR.BUYER_CD        =@BUYER_CD");
                    db.DbPsetString("@BUYER_CD", _buyer_cd);
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
                if (_catg_cd != "")
                {
                    strSQL.Append("   AND I.CATG_CD       =@ITEM_TYPE");
                    db.DbPsetString("@ITEM_TYPE", _catg_cd);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("   AND PUR.JOC_CD       =@JOC_CD");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append("   AND PUR.WHS_CD       =@WHS_CD");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }
                strSQL.Append(" ORDER  BY    PUR.PO_DUE_DATE                                                              ");
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
        /// PurRcvの取得
        /// <para>使用画面：PurRcv</para>
        /// </summary>
        public int Get_Pur_RcvDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append(" SELECT                                                                                              ");
            strSQL.Append(" PUR.ORDER_STATUS      ,PUR.ITEM_NO           ,PUR.ITEM_DESC      ,                                  ");
            strSQL.Append(" PUR.VENDOR_CD         ,V.VENDOR_NAME         ,PUR.PO_DUE_DATE    ,                                  ");
            strSQL.Append(" PUR.PO_QTY            ,PUR.PO_UMSR           ,PUR.RECV_QTY       ,                                  ");
            strSQL.Append(" PUR.UNIT_PRC_TYPE     ,PUR.PO_PRC            ,PUR.PO_CUR         ,                                  ");
            strSQL.Append(" PUR.PO_AMT            ,PUR.PO_CUR            ,PUR.JOC_CD         ,                                  ");
            strSQL.Append(" PUR.WHS_CD            ,PUR.PO_NOTE           ,PUR.SCH_ID         ,                                  ");
            strSQL.Append(" PUR.BUYER_CD          ,PUR.INSP_CD           ,I.LOT_CNTL_FLAG    ,                                  ");
            strSQL.Append(" PUR.PO_UMSR           ,PUR.PO_PRC            ,PUR.PO_CUR         ,                                  ");
            strSQL.Append(" I.LOCATION   ,S1.DATA_CHAR AS UMSR_NAME ,                                                           ");
            strSQL.Append(" S2.DATA_CHAR AS CUR_NAME ,S3.DATA_CHAR  AS ISNP_NAME ,S4.DATA_CHAR AS SCH_NAME ,                    ");
            strSQL.Append(" S5.DATA_CHAR AS BUYER_NAME ,S6.DATA_INT  ,W.WHS_DESC ,PUR.REJ_QTY                                   ");
            //ADD 20090916 --->
            strSQL.Append(" , (CASE WHEN PUR.INSP_CD = '' THEN                                                                  ");
            strSQL.Append("        (CASE WHEN ISNULL(PM.IDTAG_PRINT_FLAG,1) = 1 THEN                                            ");
            strSQL.Append("             (CASE WHEN ISNULL(PM.IDTAG_UNIT_QTY,0) = 0 THEN 1                                       ");
            strSQL.Append("              ELSE ceiling((PUR.PO_QTY-PUR.RECV_QTY+PUR.REJ_QTY)/PM.IDTAG_UNIT_QTY) END)             ");
            strSQL.Append("         ELSE 0 END)                                                                                 ");
            strSQL.Append("    ELSE (CASE WHEN SP.DATA_INT = 0 THEN                                                             ");
            strSQL.Append("              (CASE WHEN ISNULL(PM.IDTAG_PRINT_FLAG,1) = 1 THEN                                      ");
            strSQL.Append("                   (CASE WHEN ISNULL(PM.IDTAG_UNIT_QTY,0) = 0 THEN 1                                 ");
            strSQL.Append("                    ELSE ceiling((PUR.PO_QTY-PUR.RECV_QTY+PUR.REJ_QTY)/PM.IDTAG_UNIT_QTY) END)       ");
            strSQL.Append("               ELSE 0 END)                                                                           ");
            strSQL.Append("          ELSE 0 END)                                                                                ");
            strSQL.Append("    END) LABEL_QTY      ,ISNULL(PM.IDTAG_UNIT_QTY,0) IDTAG_UNIT_QTY,                                 ");
			strSQL.Append(" ISNULL(PM.IDTAG_PRINT_FLAG,1) IDTAG_PRINT_FLAG      , ISNULL(SP.DATA_INT,0) SP_DATA_INT             ");
            //strSQL.Append(" ,PUR.ACCEPT_QTY,		PUR.REJ_QTY																	");//ADD 2010/11/01 検収済数、不良数を追加表示する。
            strSQL.Append(" ,PUR.ACCEPT_QTY, PUR.REJ_QTY, V.PO_SLIP_TYPE														"); //Add 2013.05.24 仕入先の買掛計上区分追加
            strSQL.Append(" ,CASE ISNULL(PM.UMSR_CONV_RATIO,0) WHEN 0 THEN 1 ELSE PM.UMSR_CONV_RATIO END UMSR_CONV_RATIO, S7.DATA_CHAR AS INV_UMSR_NAME        "); // IMV3
            //ADD 20090916 <---
            strSQL.Append(" ,PUR.JOC_ITEM_NO SUPPLIER_LOT_NO  "); // 2015.10.26
            if (_db_type == "ORACLE")
            {
                strSQL.Append("FROM PUR_ORDER PUR , VENDOR_MASTER  V , ITEM_MASTER I ,                                          ");
                strSQL.Append(" SYSTEM_PARAMETER  S1 , SYSTEM_PARAMETER  S2 , SYSTEM_PARAMETER  S3 , SYSTEM_PARAMETER  S4  ,    ");
                strSQL.Append(" SYSTEM_PARAMETER  S5 ,SYSTEM_PARAMETER  S6  ,WAREHOUSE_MASTER   W ,  PURCHASE_MASTER PM ,  SYSTEM_PARAMETER SP ");
                strSQL.Append("WHERE PUR.VENDOR_CD          =V.VENDOR_CD(+)                                                     ");
                strSQL.Append("AND PUR.ITEM_NO              =I.ITEM_NO(+)                                                       ");
                strSQL.Append("AND PUR.WHS_CD               =W.WHS_CD(+)                                                        ");
                strSQL.Append("AND PUR.PO_UMSR              =S1.KEY02(+)      AND  S1.KEY01 ='ITEM_UMSR'                        ");
                strSQL.Append("AND PUR.PO_CUR               =S2.KEY02(+)      AND  S2.KEY01 ='CURRENCY_CD'                      ");
                strSQL.Append("AND PUR.INSP_CD              =S3.KEY02(+)      AND  S3.KEY01 ='INSP_CD'                          ");
                strSQL.Append("AND PUR.SCH_ID               =S4.KEY02(+)      AND  S4.KEY01 ='SCH_ID'                           ");
                strSQL.Append("AND PUR.BUYER_CD             =S5.KEY02(+)      AND  S5.KEY01 ='BUYER_CD'                         ");
                strSQL.Append("AND S6.KEY01='LOT_NUMBERING'(+)                AND  S6.key02='PUR'                               ");
                strSQL.Append(" AND PUR.PO_NO               =:PO_NO                                                             ");
                strSQL.Append(" AND PUR.PO_LINE_NO          =:PO_LINE_NO                                                        ");
                //ADD 20090916 --->
                strSQL.Append(" AND PUR.ITEM_NO             =PM.ITEM_NO(+)                                                      ");
                strSQL.Append(" AND PUR.SCH_COMPL_DATE      >=PM.BEG_EFF_DATE(+)                                                ");
                strSQL.Append(" AND PUR.SCH_COMPL_DATE      <=PM.END_EFF_DATE(+)                                                ");
                strSQL.Append(" AND PUR.VENDOR_CD           =PM.VENDOR_CD(+)                                                    ");
                strSQL.Append(" AND SP.KEY01                ='IDTAG_PRINT_TIMING'                                               ");
                //ADD 20090916 <---

                db.DbParametersClear();
                db.DbPsetString("PO_NO", _po_no);
                db.DbPsetInt("PO_LINE_NO", _po_line_no);

            }
            else
            {
                strSQL.Append(" FROM PUR_ORDER PUR                                                                          ");
                strSQL.Append(" LEFT  JOIN VENDOR_MASTER V ON   PUR.VENDOR_CD= V.VENDOR_CD                                  ");
                strSQL.Append(" LEFT  JOIN ITEM_MASTER   I ON   PUR.ITEM_NO = I.ITEM_NO                                     ");
                strSQL.Append(" LEFT  JOIN WAREHOUSE_MASTER   W ON   PUR.WHS_CD = W.WHS_CD                                  ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S1 ON   PUR.PO_UMSR  = S1.KEY02   AND  S1.KEY01 ='ITEM_UMSR'   ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S2 ON   PUR.PO_CUR   = S2.KEY02   AND  S2.KEY01 ='CURRENCY_CD' ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S3 ON   PUR.INSP_CD  = S3.KEY02   AND  S3.KEY01 ='INSP_CD'     ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S4 ON   PUR.SCH_ID   = S4.KEY02   AND  S4.KEY01 ='SCH_ID'      ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S5 ON   PUR.BUYER_CD = S5.KEY02   AND  S5.KEY01 ='BUYER_CD'    ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S6 ON   S6.KEY01='LOT_NUMBERING'  AND  S6.key02='PUR'          ");
                //ADD 20090916 --->
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S7 ON   PUR.ORDER_UMSR = S7.KEY02 AND  S7.KEY01='ITEM_UMSR'        ");  // IMV3
                strSQL.Append(" LEFT  JOIN PURCHASE_MASTER PM ON PUR.ITEM_NO   =  PM.ITEM_NO                                ");
                strSQL.Append("       AND  PUR.SCH_COMPL_DATE      >=       PM.BEG_EFF_DATE                                 ");
                strSQL.Append("       AND  PUR.SCH_COMPL_DATE      <=       PM.END_EFF_DATE                                 ");
                strSQL.Append("       AND  PUR.VENDOR_CD           =        PM.VENDOR_CD                                    ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  SP ON   SP.KEY01     = 'IDTAG_PRINT_TIMING'                    ");
                //ADD 20090916 <---
                strSQL.Append(" WHERE  1=1                                                                                  ");
                strSQL.Append(" AND PUR.PO_NO        =@PO_NO                                                                ");
                strSQL.Append(" AND PUR.PO_LINE_NO         =@PO_LINE_NO                                                     ");

                db.DbParametersClear();
                db.DbPsetString("@PO_NO", _po_no);
                db.DbPsetInt("@PO_LINE_NO", _po_line_no);

            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _order_status = double.Parse(db.Row("ORDER_STATUS"));
                _item_no = db.Row("ITEM_NO");
                _item_desc = db.Row("ITEM_DESC");
                _vendor_cd = db.Row("VENDOR_CD");
                _vendor_desc = db.Row("VENDOR_NAME");
                _po_due_date = int.Parse(db.Row("PO_DUE_DATE"));
                _po_qty = double.Parse(db.Row("PO_QTY"));
                _po_umsr = db.Row("PO_UMSR");
                _recv_qty = double.Parse(db.Row("RECV_QTY"));
                _po_prc = double.Parse(db.Row("PO_PRC"));
                _po_cur = db.Row("PO_CUR");
                _po_amt = double.Parse(db.Row("PO_AMT"));
                _joc_cd = db.Row("JOC_CD");
                _whs_cd = db.Row("WHS_CD");
                _whs_desc = db.Row("WHS_DESC");
                _po_note = db.Row("PO_NOTE");
                _sch_id = db.Row("SCH_NAME");
                _buyer_cd = db.Row("BUYER_NAME");
                _insp_name = db.Row("ISNP_NAME");
                _lot_cntl_flag = double.Parse(db.Row("LOT_CNTL_FLAG"));
                _location = db.Row("LOCATION");
                _unit_prc_type = int.Parse(db.Row("UNIT_PRC_TYPE"));
                _insp_cd = db.Row("INSP_CD");
                _data_int = db.Row("DATA_INT");
                _return_umsr = db.Row("UMSR_NAME");
                _return_cur = db.Row("CUR_NAME");
                _rej_qty = double.Parse(db.Row("REJ_QTY"));
                _po_slip_type = db.Row("PO_SLIP_TYPE");   //Add 2013.05.24 Ubiq-Sai
                _label_qty = double.Parse(db.Row("LABEL_QTY"));
                _print_unit_qty = double.Parse(db.Row("IDTAG_UNIT_QTY"));
                _print_flag = int.Parse(db.Row("IDTAG_PRINT_FLAG"));
                _sp_data_int = db.Row("SP_DATA_INT");
				//ADD BY liu 2010/11/01
				_accept_qty = double.Parse(db.Row("ACCEPT_QTY"));
				_rej_qty = double.Parse(db.Row("REJ_QTY"));
                _umsr_conv_ratio = double.Parse(db.Row("UMSR_CONV_RATIO"));  // IMV3
                _inv_umsr_name = db.Row("INV_UMSR_NAME");
                _supplier_lot_no = db.Row("SUPPLIER_LOT_NO");   // 2015.10.26
            }
            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// PurRcvの更新
        ///   
        /// <para>使用画面：PurRcv ,PurBlockRcv</para>
        /// </summary>
        public int Pur_Rcv(ComDB db)
        {
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PO_NO", _po_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_LINE_NO", _po_line_no, ComConst.DB_IN);
            db.DbPsetDouble("@I_RECV_QTY_PUR_UMSR", _recv_qty_pur_umsr, ComConst.DB_IN);
            db.DbPsetInt("@I_XFER_SCH_DATE", _xfer_sch_date, ComConst.DB_IN);
            db.DbPsetDouble("@I_PO_PRC", _po_prc, ComConst.DB_IN);
            db.DbPsetString("@I_DELV_NO", _delv_no, ComConst.DB_IN);
            db.DbPsetString("@I_LOT_NO", _to_lot_no, ComConst.DB_IN); // 2015.08.24
            db.DbPsetString("@I_TO_LOT_NO", _to_lot_no, ComConst.DB_OUT);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_TO_LOCATION", _to_location, ComConst.DB_IN);
            db.DbPsetInt("@I_DEV_COMPL_TYPE", _dev_compl_type, ComConst.DB_IN);
            db.DbPsetDouble("@I_CMPL_INPUT_PRC", _cmpl_input_prc, ComConst.DB_IN);  // カートン連番	IMV3
            db.DbPsetDouble("@I_CMPL_INPUT_AMT", _cmpl_input_amt, ComConst.DB_IN);  // カートン数	IMV3
            db.DbPsetString("@I_APPROVE_USER_ID", _approve_user_id, ComConst.DB_IN);    // ラベル枚数   IMV3
            db.DbPsetString("@I_SUPPLIER_LOT_NO", _supplier_lot_no, ComConst.DB_IN);    // 2015.10.26

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);
            //db.DbBeginTrans();  // IMV3

            rtn = db.DbStored("SP_PUR_RCV");
            rtn = db.DbPgetInt("RET");

            if (rtn == ComConst.SUCCEED)
            {
                _to_lot_no = db.DbPgetString("@I_TO_LOT_NO");
                return rtn;
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
        /// PurRcvCancelの取得
        ///
        ///<para>使用画面：PurRcvCancel</para>
        ///</summary>
        public DataSet Get_Pur_RcvCancelList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            // sql
            strSQL.Append(" SELECT                                                                                                                           ");
            strSQL.Append(" CASE TR.PO_NO WHEN NULL  THEN NULL WHEN ''  THEN NULL  ELSE  TR.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),TR.PO_LINE_NO),3) END AS PO_NO						,TR.PARTIAL_DELV_COMPL_CNT	,		     ");
            strSQL.Append(" TR.ITEM_NO                     ,TR.ITEM_DESC                         ,COALESCE(PUR.PO_QTY, TR.RECV_QTY_PUR_UMSR) PO_QTY, ");
            strSQL.Append(" TR.PUR_UMSR PO_UMSR            ,TR.RECV_QTY_PUR_UMSR                 ,TR.XFER_SCH_DATE AS RECV_DATE,             TR.ACT_PRC,                  ");
            strSQL.Append(" PUR.PO_CUR                     ,TR.DELV_NO	                         ,TR.TO_LOT_NO		        ,                                ");
            strSQL.Append(" TR.TO_JOC_CD                   ,TR.TO_WHS_CD                         ,                                                           ");
            strSQL.Append(" S1.DATA_CHAR AS UMSR_NAME      ,S2.DATA_CHAR AS CUR_NAME                                                                         ");
            strSQL.Append(",COALESCE(PUR.ORDER_NO,'*') PO_EXISTS"); // 2015.01.28
            strSQL.Append(",TR.PO_NO PUR_NO, TR.PO_LINE_NO "); // 2015.06.25
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM  PUR_ORDER  PUR, TRANSFER_TRANS TR ,                                                           ");
                strSQL.Append(" SYSTEM_PARAMETER  S1 , SYSTEM_PARAMETER  S2                                                         ");
                strSQL.Append(" WHERE PUR.PO_NO                  =TR.PO_NO(+)                                                       ");
                strSQL.Append(" AND PUR.PO_LINE_NO               =TR.PO_LINE_NO(+)                                                  ");
                strSQL.Append(" AND PUR.PO_UMSR = S1.KEY02(+)    AND S1.KEY01='ITEM_UMSR'                                           ");
                strSQL.Append(" AND PUR.PO_CUR  = S2.KEY02(+)    AND S2.KEY01='CURRENCY_CD'                                         ");
                strSQL.Append(" WHERE 1=1                                                                                           ");

                db.DbParametersClear();
                if (_recv_date != 0)
                {
                    strSQL.Append("   AND TR.XFER_SCH_DATE        =:RECV_DATE");
                    db.DbPsetInt("RECV_DATE", _recv_date);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append("   AND TR.FROM_VC_CD        =:VENDOR_CD");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                }
                if (_po_no != "")
                {
                    strSQL.Append("   AND TR.PO_NO        =:PO_NO");
                    db.DbPsetString("PO_NO", _po_no);
                }
                if (_po_line_no != 0.0)
                {
                    strSQL.Append("   AND TR.PO_LINE_NO        =:PO_LINE_NO");
                    db.DbPsetInt("PO_LINE_NO", _po_line_no);
                }
                if (_item_no != "")
                {
                    strSQL.Append("   AND TR.ITEM_NO        =:ITEM_NO");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append("   AND TR.TO_WHS_CD        =:TO_WHS_CD");
                    db.DbPsetString("TO_WHS_CD", _whs_cd);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("   AND TR.TO_JOC_CD        =:TO_JOC_CD");
                    db.DbPsetString("TO_JOC_CD", _joc_cd);
                }
                strSQL.Append("AND (TR.XFER_STATUS              =20 or TR.XFER_STATUS=50)  ");
                strSQL.Append("AND TR.REQ_TYPE              = '01'                         ");

            }
            else
            {
                //strSQL.Append(" FROM  PUR_ORDER  PUR                                                                                        ");
                //strSQL.Append(" LEFT  JOIN TRANSFER_TRANS TR ON   PUR.PO_NO= TR.PO_NO                                                       ");
                //strSQL.Append(" AND   PUR.PO_LINE_NO= TR.PO_LINE_NO                                                                         ");
                strSQL.Append(" FROM  TRANSFER_TRANS TR                                                                                        ");
                strSQL.Append(" LEFT  JOIN PUR_ORDER  PUR ON   PUR.PO_NO= TR.PO_NO                                                       ");

                strSQL.Append(" AND   PUR.PO_LINE_NO= TR.PO_LINE_NO                                                                         ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S1 ON   PUR.PO_UMSR = S1.KEY02  AND  S1.KEY01='ITEM_UMSR'                      ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S2 ON   PUR.PO_CUR  = S2.KEY02   AND  S2.KEY01='CURRENCY_CD'                   ");
                strSQL.Append(" WHERE 1=1                                                                                                   ");

                db.DbParametersClear();
                if (_recv_date != 0.0)
                {
                    strSQL.Append("   AND TR.XFER_SCH_DATE        =@RECV_DATE");
                    db.DbPsetInt("@RECV_DATE", _recv_date);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append("   AND TR.FROM_VC_CD        =@VENDOR_CD");
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                }
                if (_po_no != "")
                {
                    //strSQL.Append("   AND TR.PO_NO        =@PO_NO");
                    strSQL.Append(" AND TR.SLIP_NO  LIKE '" + _po_no + "%'");   // 2015.01.26

                    db.DbPsetString("@PO_NO", _po_no);
                }
                if (_po_line_no != 0)
                {
                    strSQL.Append("   AND TR.PO_LINE_NO        =@PO_LINE_NO");
                    db.DbPsetInt("@PO_LINE_NO", _po_line_no);
                }
                if (_item_no != "")
                {
                    strSQL.Append("   AND TR.ITEM_NO        =@ITEM_NO");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append("   AND TR.TO_WHS_CD        =@TO_WHS_CD");
                    db.DbPsetString("@TO_WHS_CD", _whs_cd);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("   AND TR.TO_JOC_CD        =@TO_JOC_CD");
                    db.DbPsetString("@TO_JOC_CD", _joc_cd);
                }
                strSQL.Append(" AND (TR.XFER_STATUS              = 0 or TR.XFER_STATUS=50)  ");
                strSQL.Append(" AND TR.REQ_TYPE              = '01'  ");

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
        /// PurRcvCancelの変更
        ///<para>使用画面：PurRcvCancel</para>
        ///</summary>
        public int Pur_RcvCancel()
        {
            int rtn = 0;
            ComDB db = new ComDB(_db_type);

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PO_NO", _po_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_LINE_NO", _po_line_no, ComConst.DB_IN);
            db.DbPsetDouble("@I_PARTIAL_DELV_COMPL_CNT", _partial_delv_compl_cnt, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);
            db.DbBeginTrans();

            rtn = db.DbStored("SP_PUR_RCVCANCEL");
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
        /// PurBlockRcvの取得
        ///
        /// <para>使用画面：PurBlockRcv</para>
        /// </summary>
        public DataSet Get_Pur_BlockRcvList()
        {

            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            // sql
            strSQL.Append("SELECT                                                                                      ");
            strSQL.Append("CASE PUR.PO_NO WHEN NULL THEN NULL WHEN '' THEN NULL ELSE PUR.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),PUR.PO_LINE_NO),3) END AS PO_NO 	  ,PUR.ITEM_NO	     , ");
            strSQL.Append("PUR.ITEM_DESC                  ,V.VENDOR_NAME                          ,PUR.PO_QTY        , ");
            strSQL.Append("PUR.PO_UMSR	                  ,PUR.PO_PRC                             ,I.LOT_CNTL_FLAG   , ");
            strSQL.Append("PUR.UNIT_PRC_TYPE              ,PUR.RECV_QTY                           ,S3.DATA_CHAR      , ");
            strSQL.Append("PUR.PO_CUR                     ,I.LOCATION	                          ,PUR.INSP_CD	     , ");
            strSQL.Append("PUR.PO_DUE_DATE                ,PUR.JOC_CD                             ,PUR.WHS_CD        , ");
            strSQL.Append("S1.DATA_CHAR AS UMSR_NAME      ,W.WHS_DESC                             ,S2.DATA_INT       , ");
            //strSQL.Append("(PUR.PO_QTY - PUR.RECV_QTY + PUR.REJ_QTY) SO_QTY,    '' SLIP_NO,       '' LOT_NO,           ");//ADD 20090525 UBIQ-LU  //Del 2013.05.24 Ubiq-Sai
            strSQL.Append("CASE WHEN V.PO_SLIP_TYPE = '1' THEN (PUR.PO_QTY - PUR.RECV_QTY) ELSE (PUR.PO_QTY - PUR.RECV_QTY + PUR.REJ_QTY) END SO_QTY, '' SLIP_NO, '' LOT_NO, "); //Add 2013.05.24 Ubiq-Sai
            strSQL.Append("PUR.REJ_QTY ,                    S4.DATA_CHAR   AS  CUR_NAME,            PUR.VENDOR_CD,     ");
            strSQL.Append("PUR.PO_NOTE       ");    // IMV3 
            strSQL.Append(",PUR.PO_NO PUR_NO, PUR.PO_LINE_NO  ");    // 2015.06.25
            //ADD IMV3  --->
            strSQL.Append(" , (CASE WHEN PUR.INSP_CD = '' THEN                                                                  ");
            strSQL.Append("        (CASE WHEN ISNULL(PM.IDTAG_PRINT_FLAG,1) = 1 THEN                                            ");
            strSQL.Append("             (CASE WHEN ISNULL(PM.IDTAG_UNIT_QTY,0) = 0 THEN 1                                       ");
            strSQL.Append("              ELSE ceiling((PUR.PO_QTY-PUR.RECV_QTY+PUR.REJ_QTY)/PM.IDTAG_UNIT_QTY) END)             ");
            strSQL.Append("         ELSE 1 END)                                                                                 ");
            strSQL.Append("    ELSE                                                                                             ");
            //strSQL.Append("         (CASE WHEN SP.DATA_INT = 0 THEN                                                             ");
            strSQL.Append("              (CASE WHEN ISNULL(PM.IDTAG_PRINT_FLAG,1) = 1 THEN                                      ");
            strSQL.Append("                   (CASE WHEN ISNULL(PM.IDTAG_UNIT_QTY,0) = 0 THEN 1                                 ");
            strSQL.Append("                    ELSE ceiling((PUR.PO_QTY-PUR.RECV_QTY+PUR.REJ_QTY)/PM.IDTAG_UNIT_QTY) END)       ");
            strSQL.Append("               ELSE 1 END)                                                                           ");
            //strSQL.Append("          ELSE 0 END)                                                                                ");
            strSQL.Append("    END) LABEL_QTY      ,ISNULL(PM.IDTAG_UNIT_QTY,0) IDTAG_UNIT_QTY,                                 ");
            strSQL.Append(" ISNULL(PM.IDTAG_PRINT_FLAG,1) IDTAG_PRINT_FLAG      , ISNULL(SP.DATA_INT,0) SP_DATA_INT             ");
            strSQL.Append(" ,CASE ISNULL(PM.UMSR_CONV_RATIO,0) WHEN 0 THEN 1 ELSE PM.UMSR_CONV_RATIO END UMSR_CONV_RATIO, S5.DATA_CHAR AS INV_UMSR_NAME        ");
            //ADD IMV3  <---
            strSQL.Append(",PUR.JOC_ITEM_NO SUPPLIER_LOT_NO  ");    // 2015.10.26

            if (_db_type == "ORACLE")
            {
                strSQL.Append("FROM  PUR_ORDER  PUR, VENDOR_MASTER V , ITEM_MASTER I,WAREHOUSE_MASTER   W,             ");
                strSQL.Append(" SYSTEM_PARAMETER  S1 , SYSTEM_PARAMETER  S2 , SYSTEM_PARAMETER  S2                     ");
                strSQL.Append("WHERE PUR.ORDER_STATUS      =25                                                         ");
                strSQL.Append("AND PUR.ITEM_NO             =I.ITEM_NO(+)                                               ");
                strSQL.Append("AND PUR.VENDOR_CD           =V.VENDOR_CD(+)                                             ");
                strSQL.Append("AND PUR.WHS_CD              = W.WHS_CD(+)                                               ");
                strSQL.Append("AND PUR.PO_UMSR             =S1.KEY02(+)  AND  S1.KEY01='ITEM_UMSR'                     ");
                strSQL.Append("AND PUR.INSP_CD             =S3.KEY02(+)  AND  S3.KEY01='INSP_CD'                       ");
                strSQL.Append("AND S2.KEY01='LOT_NUMBERING'  AND S2.KEY02='PUR'                                        ");


                db.DbParametersClear();
                if (_po_no != "")
                {
                    strSQL.Append("   AND PUR.PO_NO        =:PO_NO");
                    db.DbPsetString("PO_NO", _po_no);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append("   AND PUR.VENDOR_CD        =:VENDOR_CD");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append("   AND PUR.WHS_CD        =:WHS_CD");
                    db.DbPsetString("WHS_CD", _whs_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("   AND PUR.ITEM_NO        =:ITEM_NO");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("   AND PUR.JOC_CD        =:JOC_CD");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }
                if (_po_due_date != 0)
                {
                    //edit by wanghui 2010/04/30 start 
                    //strSQL.Append("   AND PUR.PO_DUE_DATE        =:PO_DUE_DATE");
                    strSQL.Append("   AND PUR.PO_DUE_DATE        <=:PO_DUE_DATE");
                    //edit by wanghui 2010/04/30 end
                    db.DbPsetInt("PO_DUE_DATE", _po_due_date);
                }
                strSQL.Append(" ORDER BY  PO_DUE_DATE, PUR.PO_NO                                                                           ");

            }
            else
            {
                strSQL.Append(" FROM  PUR_ORDER  PUR                                                                        ");
                //strSQL.Append(" LEFT JOIN VENDOR_MASTER V ON   PUR.VENDOR_CD= V.VENDOR_CD                                   ");
                //strSQL.Append(" LEFT JOIN ITEM_MASTER   I ON   PUR.ITEM_NO= I.ITEM_NO                                       ");
                //strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER   W ON   PUR.WHS_CD= W.WHS_CD                                    ");
                //strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON   PUR.PO_UMSR = S1.KEY02 AND  S1.KEY01='ITEM_UMSR'        ");
                //strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER S2 ON   S2.KEY01='LOT_NUMBERING'  AND S2.KEY02='PUR'            ");
                //strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER S3 ON   S3.KEY01='INSP_CD'  AND S3.KEY02=PUR.INSP_CD            ");
                //strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER S4 ON   S4.KEY01='CURRENCY_CD'  AND S4.KEY02=PUR.PO_CUR            ");
                ////ADD IMV3 --->
                //strSQL.Append(" LEFT  JOIN PURCHASE_MASTER PM ON PUR.ITEM_NO   =  PM.ITEM_NO                                ");
                //strSQL.Append("       AND  PUR.SCH_COMPL_DATE      >=       PM.BEG_EFF_DATE                                 ");
                //strSQL.Append("       AND  PUR.SCH_COMPL_DATE      <=       PM.END_EFF_DATE                                 ");
                //strSQL.Append("       AND  PUR.VENDOR_CD           =        PM.VENDOR_CD                                    ");
                //strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  SP ON   SP.KEY01     = 'IDTAG_PRINT_TIMING'                    ");
                //strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S5 ON   PUR.ORDER_UMSR = S5.KEY02 AND  S5.KEY01='ITEM_UMSR'        ");
                ////ADD IMV3 <---
                //strSQL.Append(" WHERE PUR.ORDER_STATUS      =25                                                             ");
                strSQL.Append(" WHERE PUR.FLAG = 0 ");

                db.DbParametersClear();
                //if (_po_no != "")
                //{
                //    //strSQL.Append("   AND PUR.PO_NO        =@PO_NO                  ");
                //    strSQL.Append("   AND (PUR.PO_NO = @PO_NO OR PUR.JOB_ORDER_NO = @PO_NO) "); // 2015.03.03

                //    db.DbPsetString("@PO_NO", _po_no);
                //}
                //if (_vendor_cd != "")
                //{
                //    strSQL.Append("   AND PUR.VENDOR_CD        =@VENDOR_CD");
                //    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                //}
                //if (_whs_cd != "")
                //{
                //    strSQL.Append("   AND PUR.WHS_CD        =@WHS_CD                ");
                //    db.DbPsetString("@WHS_CD", _whs_cd);
                //}
                if (_item_no != "")
                {
                    //strSQL.Append("   AND PUR.ITEM_NO        =@ITEM_NO              ");
                    strSQL.Append("   AND PUR.PART_NO        =@ITEM_NO              ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                //if (_joc_cd != "")
                //{
                //    strSQL.Append("   AND PUR.JOC_CD        =@JOC_CD                ");
                //    db.DbPsetString("@JOC_CD", _joc_cd);
                //}
                //if (_po_due_date != 0)
                //{
                //    //edit by wanghui 2010/04/30 start 
                //    //strSQL.Append("   AND PUR.PO_DUE_DATE        =@PO_DUE_DATE      ");
                //    strSQL.Append("   AND PUR.PO_DUE_DATE        <=@PO_DUE_DATE      ");
                //    //edit by wanghui 2010/04/30 end 
                //    db.DbPsetInt("@PO_DUE_DATE", _po_due_date);
                //}
                //// IMV3
                //if (pegging_type == "2")
                //    strSQL.Append("  AND PUR.PEGGING_TYPE	<> '1'	");
                //strSQL.Append(" ORDER BY     PO_DUE_DATE, PUR.PO_NO                 ");
                strSQL.Append(" WHERE PUR.FLAG = @ITEM_NO ");
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
        /// PurRcvImportの取得
        ///
        /// <para>使用画面：PurRcv</para>
        /// </summary>
        public DataSet Get_Pur_RcvImportList()
        {

            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            // sql
            //strSQL.Append("SELECT                                                                                      ");
            //strSQL.Append("CASE PUR.PO_NO WHEN NULL THEN NULL WHEN '' THEN NULL ELSE PUR.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),PUR.PO_LINE_NO),3) END AS PO_NO 	  ,PUR.ITEM_NO	     , ");
            //strSQL.Append("PUR.ITEM_DESC                  ,V.VENDOR_NAME                          ,PUR.PO_QTY        , ");
            //strSQL.Append("PUR.PO_UMSR	                  ,PUR.PO_PRC                             ,I.LOT_CNTL_FLAG   , ");
            //strSQL.Append("PUR.UNIT_PRC_TYPE              ,PUR.RECV_QTY                           ,S3.DATA_CHAR      , ");
            //strSQL.Append("PUR.PO_CUR                     ,I.LOCATION	                          ,PUR.INSP_CD	     , ");
            //strSQL.Append("PUR.PO_DUE_DATE                ,PUR.JOC_CD                             ,PUR.WHS_CD        , ");
            //strSQL.Append("S1.DATA_CHAR AS UMSR_NAME      ,W.WHS_DESC                             ,S2.DATA_INT       , ");
            ////strSQL.Append("(PUR.PO_QTY - PUR.RECV_QTY + PUR.REJ_QTY) SO_QTY,    '' SLIP_NO,       '' LOT_NO,           ");//ADD 20090525 UBIQ-LU  //Del 2013.05.24 Ubiq-Sai
            //strSQL.Append("CASE WHEN V.PO_SLIP_TYPE = '1' THEN (PUR.PO_QTY - PUR.RECV_QTY) ELSE (PUR.PO_QTY - PUR.RECV_QTY + PUR.REJ_QTY) END SO_QTY, '' SLIP_NO, '' LOT_NO, "); //Add 2013.05.24 Ubiq-Sai
            //strSQL.Append("PUR.REJ_QTY ,                    S4.DATA_CHAR   AS  CUR_NAME,            PUR.VENDOR_CD,     ");
            //strSQL.Append("PUR.PO_NOTE       ");    // IMV3 
            //strSQL.Append(",PUR.PO_NO PUR_NO, PUR.PO_LINE_NO  ");    // 2015.06.25
            ////ADD IMV3  --->
            //strSQL.Append(" , (CASE WHEN PUR.INSP_CD = '' THEN                                                                  ");
            //strSQL.Append("        (CASE WHEN ISNULL(PM.IDTAG_PRINT_FLAG,1) = 1 THEN                                            ");
            //strSQL.Append("             (CASE WHEN ISNULL(PM.IDTAG_UNIT_QTY,0) = 0 THEN 1                                       ");
            //strSQL.Append("              ELSE ceiling((PUR.PO_QTY-PUR.RECV_QTY+PUR.REJ_QTY)/PM.IDTAG_UNIT_QTY) END)             ");
            //strSQL.Append("         ELSE 1 END)                                                                                 ");
            //strSQL.Append("    ELSE                                                                                             ");
            ////strSQL.Append("         (CASE WHEN SP.DATA_INT = 0 THEN                                                             ");
            //strSQL.Append("              (CASE WHEN ISNULL(PM.IDTAG_PRINT_FLAG,1) = 1 THEN                                      ");
            //strSQL.Append("                   (CASE WHEN ISNULL(PM.IDTAG_UNIT_QTY,0) = 0 THEN 1                                 ");
            //strSQL.Append("                    ELSE ceiling((PUR.PO_QTY-PUR.RECV_QTY+PUR.REJ_QTY)/PM.IDTAG_UNIT_QTY) END)       ");
            //strSQL.Append("               ELSE 1 END)                                                                           ");
            ////strSQL.Append("          ELSE 0 END)                                                                                ");
            //strSQL.Append("    END) LABEL_QTY      ,ISNULL(PM.IDTAG_UNIT_QTY,0) IDTAG_UNIT_QTY,                                 ");
            //strSQL.Append(" ISNULL(PM.IDTAG_PRINT_FLAG,1) IDTAG_PRINT_FLAG      , ISNULL(SP.DATA_INT,0) SP_DATA_INT             ");
            //strSQL.Append(" ,CASE ISNULL(PM.UMSR_CONV_RATIO,0) WHEN 0 THEN 1 ELSE PM.UMSR_CONV_RATIO END UMSR_CONV_RATIO, S5.DATA_CHAR AS INV_UMSR_NAME        ");
            ////ADD IMV3  <---
            //strSQL.Append(",PUR.JOC_ITEM_NO SUPPLIER_LOT_NO  ");    // 2015.10.26
            strSQL.Append("SELECT                            ");
            strSQL.Append("PUR.PART_NO                       ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append("FROM  PUR_ORDER  PUR, VENDOR_MASTER V , ITEM_MASTER I,WAREHOUSE_MASTER   W,             ");
                strSQL.Append(" SYSTEM_PARAMETER  S1 , SYSTEM_PARAMETER  S2 , SYSTEM_PARAMETER  S2                     ");
                strSQL.Append("WHERE PUR.ORDER_STATUS      =25                                                         ");
                strSQL.Append("AND PUR.ITEM_NO             =I.ITEM_NO(+)                                               ");
                strSQL.Append("AND PUR.VENDOR_CD           =V.VENDOR_CD(+)                                             ");
                strSQL.Append("AND PUR.WHS_CD              = W.WHS_CD(+)                                               ");
                strSQL.Append("AND PUR.PO_UMSR             =S1.KEY02(+)  AND  S1.KEY01='ITEM_UMSR'                     ");
                strSQL.Append("AND PUR.INSP_CD             =S3.KEY02(+)  AND  S3.KEY01='INSP_CD'                       ");
                strSQL.Append("AND S2.KEY01='LOT_NUMBERING'  AND S2.KEY02='PUR'                                        ");


                db.DbParametersClear();
                if (_po_no != "")
                {
                    strSQL.Append("   AND PUR.PO_NO        =:PO_NO");
                    db.DbPsetString("PO_NO", _po_no);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append("   AND PUR.VENDOR_CD        =:VENDOR_CD");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append("   AND PUR.WHS_CD        =:WHS_CD");
                    db.DbPsetString("WHS_CD", _whs_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("   AND PUR.ITEM_NO        =:ITEM_NO");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("   AND PUR.JOC_CD        =:JOC_CD");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }
                if (_po_due_date != 0)
                {
                    //edit by wanghui 2010/04/30 start 
                    //strSQL.Append("   AND PUR.PO_DUE_DATE        =:PO_DUE_DATE");
                    strSQL.Append("   AND PUR.PO_DUE_DATE        <=:PO_DUE_DATE");
                    //edit by wanghui 2010/04/30 end
                    db.DbPsetInt("PO_DUE_DATE", _po_due_date);
                }
                strSQL.Append(" ORDER BY  PO_DUE_DATE, PUR.PO_NO                                                                           ");

            }
            else
            {
                strSQL.Append(" FROM  PUR_ORDER  PUR                                                                        ");
                strSQL.Append(" LEFT JOIN VENDOR_MASTER V ON   PUR.VENDOR_CD= V.VENDOR_CD                                   ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER   I ON   PUR.ITEM_NO= I.ITEM_NO                                       ");
                strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER   W ON   PUR.WHS_CD= W.WHS_CD                                    ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON   PUR.PO_UMSR = S1.KEY02 AND  S1.KEY01='ITEM_UMSR'        ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER S2 ON   S2.KEY01='LOT_NUMBERING'  AND S2.KEY02='PUR'            ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER S3 ON   S3.KEY01='INSP_CD'  AND S3.KEY02=PUR.INSP_CD            ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER S4 ON   S4.KEY01='CURRENCY_CD'  AND S4.KEY02=PUR.PO_CUR            ");
                //ADD IMV3 --->
                strSQL.Append(" LEFT  JOIN PURCHASE_MASTER PM ON PUR.ITEM_NO   =  PM.ITEM_NO                                ");
                strSQL.Append("       AND  PUR.SCH_COMPL_DATE      >=       PM.BEG_EFF_DATE                                 ");
                strSQL.Append("       AND  PUR.SCH_COMPL_DATE      <=       PM.END_EFF_DATE                                 ");
                strSQL.Append("       AND  PUR.VENDOR_CD           =        PM.VENDOR_CD                                    ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  SP ON   SP.KEY01     = 'IDTAG_PRINT_TIMING'                    ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S5 ON   PUR.ORDER_UMSR = S5.KEY02 AND  S5.KEY01='ITEM_UMSR'        ");
                //ADD IMV3 <---
                strSQL.Append(" WHERE PUR.ORDER_STATUS      =25                                                             ");

                db.DbParametersClear();
                if (_po_no != "")
                {
                    //strSQL.Append("   AND PUR.PO_NO        =@PO_NO                  ");
                    strSQL.Append("   AND (PUR.PO_NO = @PO_NO OR PUR.JOB_ORDER_NO = @PO_NO) "); // 2015.03.03

                    db.DbPsetString("@PO_NO", _po_no);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append("   AND PUR.VENDOR_CD        =@VENDOR_CD");
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append("   AND PUR.WHS_CD        =@WHS_CD                ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("   AND PUR.ITEM_NO        =@ITEM_NO              ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("   AND PUR.JOC_CD        =@JOC_CD                ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (_po_due_date != 0)
                {
                    //edit by wanghui 2010/04/30 start 
                    //strSQL.Append("   AND PUR.PO_DUE_DATE        =@PO_DUE_DATE      ");
                    strSQL.Append("   AND PUR.PO_DUE_DATE        <=@PO_DUE_DATE      ");
                    //edit by wanghui 2010/04/30 end 
                    db.DbPsetInt("@PO_DUE_DATE", _po_due_date);
                }
                // IMV3
                if (pegging_type == "2")
                    strSQL.Append("  AND PUR.PEGGING_TYPE	<> '1'	");
                strSQL.Append(" ORDER BY     PO_DUE_DATE, PUR.PO_NO                 ");
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
        /// PurInspの取 得
        ///
        /// <para>使用画面：PurInsp</para>
        /// </summary>
        public DataSet Get_Pur_InspList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            // sql
            strSQL.Append(" SELECT                                                                                                   ");
            strSQL.Append(" PUR.ORDER_STATUS                      ,TR.XFER_STATUS            ,TR.PARTIAL_DELV_COMPL_CNT     ,        ");
            strSQL.Append(" TR.RECV_QTY_PUR_UMSR                  ,TR.PUR_UMSR               ,TR.XFER_SCH_DATE              ,        ");
            strSQL.Append(" TR.QTY_PUR_UMSR                       ,TR.PUR_UMSR               ,TR.SLIP_DATE           ,               ");
            strSQL.Append(" S1.DATA_CHAR AS UMSR_NAME             ,TR.REJ_QTY_PUR_UMSR                                                                   ");//alter by zhao 2009/01/06
            strSQL.Append(" ,TR.CMPL_INPUT_PRC, TR.CMPL_INPUT_AMT ,TR.APPROVE_USER_ID                               "); // IMV3
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM  TRANSFER_TRANS TR, PUR_ORDER  PUR   ,                                                          ");
                strSQL.Append(" SYSTEM_PARAMETER  S1 , SYSTEM_PARAMETER  S2                                                          ");
                strSQL.Append(" WHERE  TR.PO_NO                =PUR.PO_NO(+)                                                         ");
                strSQL.Append(" AND    TR.PO_LINE_NO           =PUR.PO_LINE_NO                                                       ");
                strSQL.Append(" AND    TR.PUR_UMSR             =S1.KEY02(+)                                                          ");
                strSQL.Append(" AND    S1.KEY01                ='ITEM_UMSR'  AND S1.KEY02= TR.PUR_UMSR                               ");
                strSQL.Append(" AND    TR.REQ_TYPE             = '01'                                                                ");
                strSQL.Append(" AND    TR.XFER_STATUS         <= 60                                                                  ");
                strSQL.Append(" AND PUR.PO_NO                  =:PO_NO                                                               ");
                strSQL.Append(" AND PUR.PO_LINE_NO             =:PO_LINE_NO                                                          ");

                db.DbParametersClear();
                db.DbPsetString("PO_NO", _po_no);
                db.DbPsetInt("PO_LINE_NO", _po_line_no);

            }
            else
            {
                strSQL.Append(" FROM  TRANSFER_TRANS TR                                                                         ");
                strSQL.Append(" LEFT OUTER JOIN PUR_ORDER PUR ON   PUR.PO_NO= TR.PO_NO                                          ");
                strSQL.Append(" AND    TR.PO_LINE_NO        =PUR.PO_LINE_NO                                                     ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER  S1 ON   S1.KEY01='ITEM_UMSR'  AND S1.KEY02= TR.PUR_UMSR       ");
                strSQL.Append(" WHERE                                                                                           ");
                strSQL.Append("  TR.REQ_TYPE          = '01'                                                                    ");
                strSQL.Append("  AND TR.XFER_STATUS  <= 60                                                                      ");
                strSQL.Append("   AND PUR.PO_NO        =@PO_NO                                                                  ");
                strSQL.Append("   AND PUR.PO_LINE_NO        =@PO_LINE_NO                                                        ");

                db.DbParametersClear();
                db.DbPsetString("@PO_NO", _po_no);
                db.DbPsetInt("@PO_LINE_NO", _po_line_no);

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
        /// PurInspの明 细
        ///
        /// <para>使用画面：PurInsp</para>
        /// </summary>
        public int Get_Pur_InspDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append(" SELECT                                                                                              ");// alter by zhao 2008/01/06
            strSQL.Append(" PUR.ITEM_NO           ,PUR.ITEM_DESC         ,TR.RECV_QTY_PUR_UMSR  ,                               ");
            strSQL.Append(" PUR.VENDOR_CD         ,V.VENDOR_NAME         ,PUR.PO_DUE_DATE       ,                               ");
            strSQL.Append(" PUR.PO_QTY            ,PUR.PO_UMSR           ,PUR.RECV_QTY          ,                               ");
            strSQL.Append(" PUR.UNIT_PRC_TYPE     ,PUR.PO_PRC            ,PUR.PO_CUR            ,                               ");
            strSQL.Append(" PUR.PO_AMT            ,PUR.PO_CUR            ,PUR.JOC_CD            ,                               ");
            strSQL.Append(" PUR.WHS_CD            ,PUR.PO_NOTE           ,PUR.SCH_ID            ,                               ");
            strSQL.Append(" PUR.BUYER_CD          ,PUR.INSP_CD           ,I.LOT_CNTL_FLAG       ,                               ");
            strSQL.Append(" PUR.PO_UMSR           ,PUR.PO_PRC            ,TR.DELV_NO	        ,                               ");
            strSQL.Append(" I.LOCATION            ,S1.DATA_CHAR AS UMSR_NAME ,                                                  ");
            strSQL.Append(" S2.DATA_CHAR AS CUR_NAME ,S3.DATA_CHAR  AS ISNP_NAME ,S4.DATA_CHAR AS SCH_NAME    ,                 ");
            strSQL.Append(" PUR.ORDER_STATUS,      TR.QTY_PUR_UMSR,      TR.REJ_QTY_PUR_UMSR,                                   "); // add by zhao 2009/02/11
            strSQL.Append(" S5.DATA_CHAR AS BUYER_NAME   ,W.WHS_DESC      ,S6.DATA_INT          ,                               ");
            strSQL.Append(" TR.TO_LOT_NO           ,TR.TO_LOCATION                                                              ");
            //ADD 20090918 --->
            strSQL.Append(" , (CASE WHEN SP.DATA_INT = 1 THEN                                                                   ");
            strSQL.Append("        (CASE WHEN ISNULL(PM.IDTAG_PRINT_FLAG,1) = 1 THEN                                            ");
            strSQL.Append("             (CASE WHEN ISNULL(PM.IDTAG_UNIT_QTY,0) = 0 THEN 1                                       ");
            strSQL.Append("              ELSE ceiling((TR.RECV_QTY_PUR_UMSR - TR.QTY_PUR_UMSR - TR.REJ_QTY_PUR_UMSR)/PM.IDTAG_UNIT_QTY) END)   ");
            strSQL.Append("         ELSE 0 END)                                                                                 ");
            strSQL.Append("    ELSE 0 END) LABEL_QTY      ,ISNULL(PM.IDTAG_UNIT_QTY,0) IDTAG_UNIT_QTY,                          ");
			strSQL.Append(" ISNULL(PM.IDTAG_PRINT_FLAG,1) IDTAG_PRINT_FLAG      , ISNULL(SP.DATA_INT,0) SP_DATA_INT             ");
			strSQL.Append(" ,PUR.ACCEPT_QTY,		PUR.REJ_QTY																	");//ADD 2010/11/01 検収済数、不良数を追加表示する。
            //ADD 20090918 <---
            strSQL.Append(" ,TR.CMPL_INPUT_PRC, TR.CMPL_INPUT_AMT ,TR.APPROVE_USER_ID                               "); // IMV3
            strSQL.Append(" ,CASE ISNULL(PM.UMSR_CONV_RATIO,0) WHEN 0 THEN 1 ELSE PM.UMSR_CONV_RATIO END UMSR_CONV_RATIO, S7.DATA_CHAR AS INV_UMSR_NAME        "); // IMV3
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PUR_ORDER PUR , VENDOR_MASTER  V , ITEM_MASTER I ,TRANSFER_TRANS TR ,  SYSTEM_PARAMETER  S1 , ");
                strSQL.Append(" SYSTEM_PARAMETER  S2 , SYSTEM_PARAMETER  S3 , SYSTEM_PARAMETER  S4,  PURCHASE_MASTER PM ,  SYSTEM_PARAMETER SP  ");
                strSQL.Append(" SYSTEM_PARAMETER  S5  ,WAREHOUSE_MASTER                                                          ");
                strSQL.Append(" WHERE PUR.VENDOR_CD           =V.VENDOR_CD(+)                                                    ");
                strSQL.Append(" AND PUR.ITEM_NO               =I.ITEM_NO(+)                                                      ");
                strSQL.Append(" AND PUR.WHS_CD                =W.WHS_CD(+)                                                       ");
                strSQL.Append(" AND PUR.PO_UMSR               =S1.KEY02(+)  AND  S1.KEY01='ITEM_UMSR'                            ");
                strSQL.Append(" AND PUR.PO_CUR                =S2.KEY02(+)  AND  S2.KEY01='CURRENCY_CD'                          ");
                strSQL.Append(" AND PUR.INSP_CD               =S3.KEY02(+)  AND  S3.KEY01='INSP_CD'                              ");
                strSQL.Append(" AND PUR.SCH_ID                =S4.KEY02(+)  AND  S4.KEY01='SCH_ID'                               ");
                strSQL.Append(" AND PUR.BUYER_CD              =S5.KEY02(+)  AND  S5.KEY01='BUYER_CD'                             ");
                strSQL.Append(" AND S6.KEY02                  ='PUR'        AND  S6.KEY01='LOT_NUMBERING'                        ");
                strSQL.Append(" AND PUR.PO_NO                 =TR.PO_NO(+)                                                       ");
                strSQL.Append(" AND PUR.PO_LINE_NO            =TR.PO_LINE_NO                                                     ");
                strSQL.Append(" AND PUR.PO_NO                 =:PO_NO                                                            ");
                strSQL.Append(" AND PUR.PO_LINE_NO            =:PO_LINE_NO                                                       ");
                strSQL.Append(" AND TR.REQ_TYPE               ='01'                                                              ");
                strSQL.Append(" AND TR.PARTIAL_DELV_COMPL_CNT =:PARTIAL_DELV_COMPL_CNT                                           ");
                //ADD 20090918 --->
                strSQL.Append(" AND PUR.ITEM_NO             =PM.ITEM_NO(+)                                                      ");
                strSQL.Append(" AND PUR.SCH_COMPL_DATE      >=PM.BEG_EFF_DATE(+)                                                ");
                strSQL.Append(" AND PUR.SCH_COMPL_DATE      <=PM.END_EFF_DATE(+)                                                ");
                strSQL.Append(" AND PUR.VENDOR_CD           =PM.VENDOR_CD(+)                                                    ");
                strSQL.Append(" AND SP.KEY01                ='IDTAG_PRINT_TIMING'                                               ");
                //ADD 20090918 <---

                db.DbParametersClear();
                db.DbPsetString("PO_NO", _po_no);
                db.DbPsetInt("PO_LINE_NO", _po_line_no);
                db.DbPsetDouble("PARTIAL_DELV_COMPL_CNT", _partial_delv_compl_cnt);

            }
            else
            {
                strSQL.Append(" FROM PUR_ORDER PUR                                                                              ");
                strSQL.Append(" LEFT  JOIN VENDOR_MASTER V ON   PUR.VENDOR_CD= V.VENDOR_CD                                      ");
                strSQL.Append(" LEFT  JOIN ITEM_MASTER   I ON   PUR.ITEM_NO = I.ITEM_NO                                         ");
                strSQL.Append(" LEFT  JOIN TRANSFER_TRANS   TR  ON   PUR.PO_NO = TR.PO_NO                                       ");
                strSQL.Append(" AND   PUR.PO_LINE_NO = TR.PO_LINE_NO                                                            ");
                strSQL.Append(" LEFT  JOIN WAREHOUSE_MASTER   W ON   PUR.WHS_CD = W.WHS_CD                                      ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S1 ON   PUR.PO_UMSR  = S1.KEY02 AND   S1.KEY01='ITEM_UMSR'         ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S2 ON   PUR.PO_CUR   = S2.KEY02 AND   S2.KEY01='CURRENCY_CD'       ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S3 ON   PUR.INSP_CD  = S3.KEY02 AND   S3.KEY01='INSP_CD'           ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S4 ON   PUR.SCH_ID   = S4.KEY02 AND   S4.KEY01='SCH_ID'            ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S5 ON   PUR.BUYER_CD = S5.KEY02 AND   S5.KEY01='BUYER_CD'          ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S6 ON   S6.KEY02     ='PUR'     AND   S6.KEY01='LOT_NUMBERING'     ");
                //ADD 20090918 --->
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S7 ON   PUR.ORDER_UMSR = S7.KEY02 AND  S7.KEY01='ITEM_UMSR'        ");  // IMV3
                strSQL.Append(" LEFT  JOIN PURCHASE_MASTER PM ON PUR.ITEM_NO   =  PM.ITEM_NO                                ");
                strSQL.Append("       AND  PUR.SCH_COMPL_DATE      >=       PM.BEG_EFF_DATE                                 ");
                strSQL.Append("       AND  PUR.SCH_COMPL_DATE      <=       PM.END_EFF_DATE                                 ");
                strSQL.Append("       AND  PUR.VENDOR_CD           =        PM.VENDOR_CD                                    ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  SP ON   SP.KEY01     = 'IDTAG_PRINT_TIMING'                    ");
                //ADD 20090918 <---
                strSQL.Append(" WHERE  PUR.PO_NO           =@PO_NO                                                              ");
                strSQL.Append(" AND PUR.PO_LINE_NO         =@PO_LINE_NO                                                         ");
                strSQL.Append(" AND TR.REQ_TYPE            ='01'                                                                ");
                strSQL.Append(" AND TR.PARTIAL_DELV_COMPL_CNT            =@PARTIAL_DELV_COMPL_CNT                               ");
                strSQL.Append(" AND TR.XFER_STATUS < 90                               ");

                db.DbParametersClear();
                db.DbPsetString("@PO_NO", _po_no);
                db.DbPsetInt("@PO_LINE_NO", _po_line_no);
                db.DbPsetDouble("@PARTIAL_DELV_COMPL_CNT", _partial_delv_compl_cnt);
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
                _vendor_cd = db.Row("VENDOR_CD");
                _vendor_desc = db.Row("VENDOR_NAME");
                _po_due_date = int.Parse(db.Row("PO_DUE_DATE"));
                _po_qty = double.Parse(db.Row("PO_QTY"));
                _po_umsr = db.Row("UMSR_NAME");
                _recv_qty = double.Parse(db.Row("RECV_QTY"));
                _po_prc = double.Parse(db.Row("PO_PRC"));
                _po_cur = db.Row("CUR_NAME");
                _po_amt = double.Parse(db.Row("PO_AMT"));
                _joc_cd = db.Row("JOC_CD");
                _whs_cd = db.Row("WHS_CD");
                _whs_desc = db.Row("WHS_DESC");
                _po_note = db.Row("PO_NOTE");
                _sch_id = db.Row("SCH_NAME");
                _buyer_cd = db.Row("BUYER_NAME");
                _insp_name = db.Row("ISNP_NAME");
                _lot_cntl_flag = double.Parse(db.Row("LOT_CNTL_FLAG"));
                _location = db.Row("LOCATION");
                _unit_prc_type = int.Parse(db.Row("UNIT_PRC_TYPE"));
                _insp_cd = db.Row("INSP_CD");
                _delv_no = db.Row("DELV_NO");
                _recv_qty_pur_umsr = double.Parse(db.Row("RECV_QTY_PUR_UMSR"));
                _data_int = db.Row("DATA_INT");
                _order_status = double.Parse(db.Row("ORDER_STATUS")); // add by zhao 2009/02/11
                _to_lot_no = db.Row("TO_LOT_NO");
                _to_location = db.Row("TO_LOCATION");
                _qty_pur_umsr = double.Parse(db.Row("QTY_PUR_UMSR"));
                _rej_qty_pur_umsr = double.Parse(db.Row("REJ_QTY_PUR_UMSR"));
                //ADD 20090918
                _label_qty = double.Parse(db.Row("LABEL_QTY"));
                _print_unit_qty = double.Parse(db.Row("IDTAG_UNIT_QTY"));
                _print_flag = int.Parse(db.Row("IDTAG_PRINT_FLAG"));
                _sp_data_int = db.Row("SP_DATA_INT");
				//ADD BY UBIQ-LIU 2010/11/01
				_accept_qty = double.Parse(db.Row("ACCEPT_QTY"));
                _rej_qty = double.Parse(db.Row("REJ_QTY"));
                _cmpl_input_prc = double.Parse(db.Row("CMPL_INPUT_PRC"));  // IMV3
                _cmpl_input_amt = double.Parse(db.Row("CMPL_INPUT_AMT"));  // IMV3
                _umsr_conv_ratio = double.Parse(db.Row("UMSR_CONV_RATIO"));  // IMV3
                _approve_user_id = db.Row("APPROVE_USER_ID");   // IMV3
                _inv_umsr_name = db.Row("INV_UMSR_NAME");
            }
            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;

        }

        /// <summary>
        /// PurInspの追 加
        /// 
        /// <para>使用画面：PurInsp</para>
        /// </summary>
        public int Pur_Insp(ComDB db)
        {
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PO_NO", _po_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_LINE_NO", _po_line_no, ComConst.DB_IN);
            db.DbPsetDouble("@I_PARTIAL_DELV_COMPL_CNT", _partial_delv_compl_cnt, ComConst.DB_IN);
            db.DbPsetDouble("@I_QTY_PUR_UMSR", _qty_pur_umsr, ComConst.DB_IN);
            db.DbPsetDouble("@I_DESTRUCT_QTY_PUR_UMSR", _destruct_qty_pur_umsr, ComConst.DB_IN);
            db.DbPsetDouble("@I_REJ_QTY_PUR_UMSR", _rej_qty_pur_umsr, ComConst.DB_IN);
            db.DbPsetString("@I_XFER_TEXT", _xfer_text, ComConst.DB_IN);
            db.DbPsetDouble("@I_SLIP_DATE", _slip_date, ComConst.DB_IN);
            db.DbPsetString("@I_TO_LOT_NO", _to_lot_no, ComConst.DB_INOUT);   // IMV3 IN->INOUT
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_TO_LOCATION", _to_location, ComConst.DB_IN);
            db.DbPsetInt("@I_DEV_COMPL_TYPE", _dev_compl_type, ComConst.DB_IN);     //ADD UBIQ-SAI 09.01.16
            db.DbPsetDouble("@I_CMPL_INPUT_PRC", _cmpl_input_prc, ComConst.DB_IN);  // カートン連番	IMV3
            db.DbPsetDouble("@I_CMPL_INPUT_AMT", _cmpl_input_amt, ComConst.DB_IN);  // カートン数	IMV3
            db.DbPsetString("@I_APPROVE_USER_ID", _approve_user_id, ComConst.DB_IN);    // ラベル枚数   IMV3

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            //db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);         //DEL UBIQ-SAI 09.01.16
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);
            //db.DbBeginTrans();  // IMV3

            rtn = db.DbStored("SP_PUR_INSP");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                _to_lot_no = db.DbPgetString("@I_TO_LOT_NO");
                return rtn;
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
        /// PurBlockInspの取 得
        ///
        /// <para>使用画面：PurBlockInsp</para>
        /// </summary>
        public DataSet Get_Pur_BlockInspList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            // sql
            strSQL.Append(" SELECT                                                                                                           ");
            strSQL.Append(" CASE TR.PO_NO WHEN NULL  THEN NULL WHEN ''  THEN NULL  ELSE  TR.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),TR.PO_LINE_NO),3) END AS PO_NO            ,TR.PARTIAL_DELV_COMPL_CNT      ,  ");
            strSQL.Append(" TR.XFER_SCH_DATE             ,TR.ITEM_NO                ,TR.ITEM_DESC                                ,           ");
            strSQL.Append(" TR.RECV_QTY_PUR_UMSR                  ,TR.PUR_UMSR                ,PUR.INSP_CD                                 , ");
            strSQL.Append(" I.LOCATION                            ,I.LOT_CNTL_FLAG           ,TR.TO_JOC_CD                                ,  ");
            strSQL.Append(" TR.TO_WHS_CD                          ,W.WHS_DESC  ,              TR.REJ_QTY_PUR_UMSR,                           ");
            strSQL.Append(" S1.DATA_CHAR AS UMSR_NAME  ,S2.DATA_CHAR AS ISNP_NAME            ,S3.DATA_INT ,                                  ");
            strSQL.Append(" (TR.RECV_QTY_PUR_UMSR - TR.QTY_PUR_UMSR - TR.REJ_QTY_PUR_UMSR) AS QTY_PUR_UMSR  ,                                ");
            strSQL.Append(" TR.TO_LOT_NO           ,TR.TO_LOCATION,                                                                           ");
            strSQL.Append(" PUR.PO_NOTE,       ");    // IMV3 
            //strSQL.Append(" CASE TR.CMPL_INPUT_PRC WHEN 0 THEN TR.CMPL_INPUT_AMT ELSE 1.0 END LABEL_QTY       ");    // IMV3 
            strSQL.Append(" CONVERT(INT, TR.APPROVE_USER_ID) LABEL_QTY       ");    // IMV3 
            strSQL.Append(" ,TR.CMPL_INPUT_PRC ,TR.CMPL_INPUT_AMT,TR.APPROVE_USER_ID    ,ISNULL(PM.IDTAG_UNIT_QTY,0) IDTAG_UNIT_QTY  ");    // IMV3 
            strSQL.Append(" ,ISNULL(PM.IDTAG_PRINT_FLAG,1) IDTAG_PRINT_FLAG      , ISNULL(SP.DATA_INT,0) SP_DATA_INT             ");    // IMV3 
            strSQL.Append(" ,CASE ISNULL(PM.UMSR_CONV_RATIO,0) WHEN 0 THEN 1 ELSE PM.UMSR_CONV_RATIO END UMSR_CONV_RATIO, S5.DATA_CHAR AS INV_UMSR_NAME        ");
            strSQL.Append(" ,PUR.PO_NO PUR_NO, PUR.PO_LINE_NO, PUR.JOB_ORDER_NO, PUR.VENDOR_CD,V.VENDOR_NAME "); // 2015.06.25
            strSQL.Append(" ,(TR.RECV_QTY_PUR_UMSR - TR.QTY_PUR_UMSR - TR.REJ_QTY_PUR_UMSR) AS PO_QTY, PUR.PO_DUE_DATE        "); // 2015.06.25

            if (_db_type == "ORACLE")
            {
                strSQL.Append("FROM PUR_ORDER PUR ,  ITEM_MASTER I ,TRANSFER_TRANS TR , WAREHOUSE_MASTER W,                             ");
                strSQL.Append("SYSTEM_PARAMETER  S1 , SYSTEM_PARAMETER  S2 , SYSTEM_PARAMETER  S3                                       ");
                strSQL.Append("WHERE PUR.PO_NO               =TR.PO_NO(+)                                                               ");
                strSQL.Append("AND PUR.PO_LINE_NO            =TR.PO_LINE_NO                                                             ");
                strSQL.Append("AND PUR.PARTIAL_DELV_CNT      =TR.PARTIAL_DELV_CNT                                                       ");
                strSQL.Append("AND PUR.ITEM_NO               =I.ITEM_NO(+)                                                              ");
                strSQL.Append("AND PUR.PO_UMSR               =S1.KEY02(+) AND S1.KEY01='ITEM_UMSR'                                      ");
                strSQL.Append("AND PUR.INSP_CD               =S2.KEY02(+) AND S2.KEY01='INSP_CD'                                        ");
                strSQL.Append("AND S3.KEY02 = 'PUR'   AND S3.KEY01='LOT_NUMBERING'                                                      ");
                strSQL.Append("WHERE  TR.XFER_STATUS=0                                                                                  ");


                db.DbParametersClear();

                if (_po_no != "")
                {
                    strSQL.Append("   AND PUR.PO_NO              = :PO_NO");
                    db.DbPsetString("PO_NO", _po_no);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append("   AND PUR.VENDOR_CD              = :VENDOR_CD");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append("   AND PUR.WHS_CD              = :WHS_CD");
                    db.DbPsetString("WHS_CD", _whs_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("   AND PUR.ITEM_NO              = :ITEM_NO");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("   AND PUR.JOC_CD              = :JOC_CD");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }
                if (_xfer_sch_date != 0)
                {
                    strSQL.Append("   AND TR.XFER_SCH_DATE              = :XFER_SCH_DATE");
                    db.DbPsetInt("XFER_SCH_DATE", _xfer_sch_date);
                }
            }
            else
            {
                strSQL.Append(" FROM PUR_ORDER PUR                                                                           ");
                strSQL.Append(" INNER JOIN TRANSFER_TRANS TR ON   PUR.PO_NO= TR.PO_NO                                        ");
                strSQL.Append(" AND PUR.PO_LINE_NO             =TR.PO_LINE_NO                                                ");
                //strSQL.Append(" AND PUR.PARTIAL_DELV_CNT       =TR.PARTIAL_DELV_COMPL_CNT                                    ");
                strSQL.Append(" INNER JOIN ITEM_MASTER I ON   PUR.ITEM_NO= I.ITEM_NO                                         ");
                strSQL.Append(" LEFT  JOIN WAREHOUSE_MASTER W ON  TR.TO_WHS_CD=W.WHS_CD                                      ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S1 ON   PUR.PO_UMSR = S1.KEY02   AND S1.KEY01='ITEM_UMSR'       ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S2 ON   PUR.INSP_CD   = S2.KEY02 AND S2.KEY01='INSP_CD'         ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S3 ON   S3.KEY02 = 'PUR'   AND S3.KEY01='LOT_NUMBERING'         ");
                //ADD IMV3 --->
                strSQL.Append(" LEFT  JOIN PURCHASE_MASTER PM ON PUR.ITEM_NO   =  PM.ITEM_NO                                ");
                strSQL.Append("       AND  PUR.SCH_COMPL_DATE      >=       PM.BEG_EFF_DATE                                 ");
                strSQL.Append("       AND  PUR.SCH_COMPL_DATE      <=       PM.END_EFF_DATE                                 ");
                strSQL.Append("       AND  PUR.VENDOR_CD           =        PM.VENDOR_CD                                    ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  SP ON   SP.KEY01     = 'IDTAG_PRINT_TIMING'                    ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S5 ON   PUR.ORDER_UMSR = S5.KEY02 AND  S5.KEY01='ITEM_UMSR'        ");
                strSQL.Append(" LEFT JOIN VENDOR_MASTER V ON   PUR.VENDOR_CD= V.VENDOR_CD                                   "); // 2015.06.25
                //ADD IMV3 <---
                strSQL.Append(" WHERE  TR.XFER_STATUS=0                                                                      ");

                strSQL.Append("AND  TR.REQ_TYPE='01'                                                                         ");
                if (_po_no != "")
                {
                    strSQL.Append("   AND PUR.PO_NO              = @PO_NO");
                    db.DbPsetString("@PO_NO", _po_no);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append("   AND PUR.VENDOR_CD              = @VENDOR_CD");
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append("   AND PUR.WHS_CD              = @WHS_CD");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("   AND PUR.ITEM_NO              = @ITEM_NO");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("   AND PUR.JOC_CD              = @JOC_CD");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (_xfer_sch_date != 0)
                {
                    strSQL.Append("   AND TR.XFER_SCH_DATE              = @XFER_SCH_DATE");
                    db.DbPsetInt("@XFER_SCH_DATE", _xfer_sch_date);
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
        /// PurReturnの取 得
        ///
        /// <para>使用画面：PurReturn</para>
        /// </summary>
        public DataSet Get_Pur_ReturnUmsr()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            // sql
            strSQL.Append(" SELECT                                                                    ");
            strSQL.Append(" PUR.PUR_UMSR                ,PUR.PTY_NO                 ,I.ITEM_UMSR ,    ");
            strSQL.Append(" S1.DATA_CHAR AS  UMSR_NAME  ,S2.DATA_CHAR                                 ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM  PURCHASE_MASTER PUR  , ITEM_MASTER I,                             ");
                strSQL.Append(" SYSTEM_PARAMETER  S1        ,SYSTEM_PARAMETER  S2                       ");
                strSQL.Append(" WHERE  PUR.ITEM_NO     =I.ITEM_NO(+)                                    ");
                strSQL.Append(" AND PUR.PUR_UMSR = S1.KEY02(+)   AND S1.KEY01='ITEM_UMSR'               ");
                strSQL.Append(" AND I.ITEM_UMSR = S2.KEY02       AND S2.KEY01='ITEM_UMSR'               ");
                strSQL.Append(" AND  PUR.BEG_EFF_DATE   <=:BEG_EFF_DATE                                 ");
                strSQL.Append(" AND  PUR.END_EFF_DATE   >=:END_EFF_DATE                                 ");

                db.DbParametersClear();

                if (_item_no != "")
                {
                    strSQL.Append("   AND PUR.ITEM_NO              = :ITEM_NO");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append("   AND PUR.VENDOR_CD              = :VENDOR_CD");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                }

                db.DbPsetDouble("BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetDouble("END_EFF_DATE", _end_eff_date);
                strSQL.Append(" ORDER BY PUR.PTY_NO                                                     ");

            }
            else
            {
                strSQL.Append(" FROM  PURCHASE_MASTER PUR                                                                   ");
                strSQL.Append(" LEFT  JOIN ITEM_MASTER I ON   PUR.ITEM_NO= I.ITEM_NO                                        ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S1 ON   PUR.PUR_UMSR = S1.KEY02   AND S1.KEY01='ITEM_UMSR'     ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S2 ON   I.ITEM_UMSR = S2.KEY02    AND S2.KEY01='ITEM_UMSR'     ");
                strSQL.Append(" WHERE  1=1                                                                                  ");
                strSQL.Append(" AND  PUR.BEG_EFF_DATE  <= @BEG_EFF_DATE                                                    ");
                strSQL.Append(" AND  PUR.END_EFF_DATE  >= @END_EFF_DATE                                                    ");


                db.DbParametersClear();

                if (_item_no != "")
                {
                    strSQL.Append("   AND PUR.ITEM_NO              = @ITEM_NO");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append("   AND PUR.VENDOR_CD              = @VENDOR_CD");
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                }
                db.DbPsetDouble("@BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetDouble("@END_EFF_DATE", _end_eff_date);
                strSQL.Append(" ORDER BY PUR.PTY_NO                                                                         ");

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
        /// PurReturnの取 得
        ///
        /// <para>使用画面：PurReturn<para>
        /// </summary>
        public DataSet Get_Pur_ReturnPrice()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            // sql
            strSQL.Append(" SELECT                                                                          ");
            strSQL.Append(" P.COM_PRC_FLAG                ,P.TENTATIVE_PRC                 ,P.ACT_PRC,      ");
            strSQL.Append(" P.TENTATIVE_CUR               ,P.ACT_CUR  ,                                     ");
            strSQL.Append(" S1.DATA_CHAR AS  UMSR_NAME    ,S2.DATA_CHAR                                     ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM  PURCHASE_PRICE_MASTER P ,                                             ");
                strSQL.Append(" SYSTEM_PARAMETER  S1, SYSTEM_PARAMETER  S2                                  ");
                strSQL.Append(" WHERE                                                                       ");
                strSQL.Append(" AND P.TENTATIVE_CUR = S1.KEY02(+)   AND S1.KEY01='CURRENCY_CD'              ");
                strSQL.Append(" AND P.ACT_CUR = S2.KEY02(+)    AND S2.KEY01='CURRENCY_CD'                   ");
                strSQL.Append(" AND  P.BEG_EFF_DATE   >=:BEG_EFF_DATE                                       ");
                strSQL.Append(" AND  P.END_EFF_DATE   <=:END_EFF_DATE                                       ");

                db.DbParametersClear();

                if (_item_no != "")
                {
                    strSQL.Append("   AND P.ITEM_NO              = :ITEM_NO");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append("   AND P.VENDOR_CD              = :VENDOR_CD");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                }
                db.DbPsetDouble("BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetDouble("END_EFF_DATE", _end_eff_date);

            }
            else
            {
                strSQL.Append(" FROM  PURCHASE_PRICE_MASTER P                                                                            ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S1 ON   P.TENTATIVE_CUR = S1.KEY02   AND S1.KEY01='CURRENCY_CD'             ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S2 ON   P.ACT_CUR = S2.KEY02    AND S2.KEY01='CURRENCY_CD'                  ");
                strSQL.Append(" WHERE 1=1                                                                                                ");
                strSQL.Append(" AND P.BEG_EFF_DATE   <= @BEG_EFF_DATE                                                                    ");
                strSQL.Append(" AND  P.END_EFF_DATE  >= @BEG_EFF_DATE                                                                    ");

                db.DbParametersClear();

                if (_item_no != "")
                {
                    strSQL.Append("   AND P.ITEM_NO              = @ITEM_NO");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append("   AND P.VENDOR_CD              = @VENDOR_CD");
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                }
                db.DbPsetDouble("@BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetDouble("@END_EFF_DATE", _end_eff_date);

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
        /// PurReturnの変 更
        /// 
        /// <para>使用画面：PurReturn</para>
        /// </summary>
        public int Pur_Return()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PO_NO", _po_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_LINE_NO", _po_line_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_RECV_DATE", _recv_date, ComConst.DB_IN);
            db.DbPsetString("@I_JOC_CD", _joc_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_RETURN_DATE", _return_date, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION", _location, ComConst.DB_IN);
            db.DbPsetString("@I_LOT_NO", _lot_no, ComConst.DB_IN);
            db.DbPsetDouble("@I_RETURN_QTY", _return_qty, ComConst.DB_IN);
            db.DbPsetString("@I_RETURN_UMSR", _return_umsr, ComConst.DB_IN);
            db.DbPsetDouble("@I_RETURN_PRC", _return_prc, ComConst.DB_IN);
            db.DbPsetString("@I_RETURN_CUR", _return_cur, ComConst.DB_IN);
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

            rtn = db.DbStored("SP_PUR_RETURN");
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
        /// PurReturnの取 得
        ///
        /// <para>使用画面：PurReturn</para>
        /// </summary>
        public DataSet Get_Pur_ReturnPoDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            // sql
            strSQL.Append(" SELECT                                                                           ");
            strSQL.Append(" PUR.ITEM_NO             ,PUR.ITEM_DESC             ,PUR.VENDOR_CD  ,             ");
            strSQL.Append(" V.VENDOR_NAME           ,PUR.JOC_CD                ,PUR.PO_UMSR   ,              ");
            strSQL.Append(" PUR.PO_PRC              ,PUR.PO_CUR                ,PUR.PO_CUR ,                 ");
            strSQL.Append(" S1.DATA_CHAR AS  UMSR_NAME    ,S2.DATA_CHAR        ,RECV_DATE                    ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PUR_ORDER PUR , VENDOR_MASTER V                                        ");
                strSQL.Append(" SYSTEM_PARAMETER  S1 ,SYSTEM_PARAMETER  S2                                  ");
                strSQL.Append(" WHERE PUR.VENDOR_CD      = V.VENDOR_CD(+)                                   ");
                strSQL.Append(" AND PUR.PO_UMSR = S1.KEY02(+)   AND S1.KEY01='ITEM_UMSR'                    ");
                strSQL.Append(" AND PUR.PO_CUR = S2.KEY02(+)    AND S2.KEY01='CURRENCY_CD'                  ");
                strSQL.Append("AND PUR.PO_NO        =@PO_NO                                                                 ");
                strSQL.Append(" AND PUR.PO_LINE_NO        =@PO_LINE_NO                                                      ");
                db.DbParametersClear();

                db.DbPsetString("PO_NO", _po_no);
                db.DbPsetInt("PO_LINE_NO", _po_line_no);
            }
            else
            {
                strSQL.Append(" FROM PUR_ORDER PUR                                                                          ");
                strSQL.Append(" LEFT JOIN  VENDOR_MASTER V  ON PUR.VENDOR_CD=V.VENDOR_CD                                    ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S1 ON  PUR.PO_UMSR = S1.KEY02   AND S1.KEY01='ITEM_UMSR'       ");
                strSQL.Append(" LEFT  JOIN SYSTEM_PARAMETER  S2 ON  PUR.PO_CUR = S2.KEY02    AND S2.KEY01='CURRENCY_CD'     ");
                strSQL.Append(" WHERE 1=1                                                                                   ");
                strSQL.Append("AND PUR.PO_NO        =@PO_NO                                                                 ");
                strSQL.Append(" AND PUR.PO_LINE_NO        =@PO_LINE_NO                                                      ");
                db.DbParametersClear();

                db.DbPsetString("PO_NO", _po_no);
                db.DbPsetInt("PO_LINE_NO", _po_line_no);

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
        /// PurReturnの取 得
        ///
        /// <para>使用画面：PurReturn</para>
        /// </summary>
        public DataSet Get_Pur_ReturnPoList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            // sql
            strSQL.Append("SELECT                                                                                                                   ");
            strSQL.Append(" CASE PUR.PO_NO WHEN NULL THEN NULL WHEN '' THEN NULL ELSE PUR.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),PUR.PO_LINE_NO),3) END AS PO_NO    ,  PUR.ITEM_DESC             ,V.VENDOR_NAME  ,   ");
            strSQL.Append("PUR.ITEM_NO             ,PUR.PO_QTY                ,PUR.PO_UMSR  ,                                                       ");
            strSQL.Append("PUR.RECV_QTY            ,PUR.RECV_DATE             ,PUR.BUYER_CD  ,                                                      ");
            strSQL.Append("PUR.SCH_ID              ,PUR.JOC_CD                ,PUR.WHS_CD  ,                                                        ");
            strSQL.Append("S1.DATA_CHAR AS  UMSR_NAME            ,S2.DATA_CHAR AS BUYER_NAME                ,S3.DATA_CHAR AS SCH_NAME,              ");
            strSQL.Append(" W.WHS_DESC                                                                                                              ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PUR_ORDER PUR , VENDOR_MASTER V ,ITEM_MASTER  I ,                                              ");
                strSQL.Append("SYSTEM_PARAMETER  S1 , SYSTEM_PARAMETER  S2 , SYSTEM_PARAMETER  S3 ,                                 ");
                strSQL.Append(" WAREHOUSE_MASTER   W                                                                                ");
                strSQL.Append("WHERE PUR.VENDOR_CD         =V.VENDOR_CD(+)                                                          ");
                strSQL.Append("AND PUR.ITEM_NO             =I.ITEM_NO(+)                                                            ");
                strSQL.Append("AND PUR.PO_UMSR             =S1.KEY02(+)  AND S1.KEY01='ITEM_UMSR'                                   ");
                strSQL.Append("AND PUR.BUYER_CD            =S2.KEY02(+)  AND S1.KEY01='BUYER_CD'                                    ");
                strSQL.Append("AND PUR.SCH_ID              =S3.KEY02(+)  AND S1.KEY01='SCH_ID'                                      ");

                db.DbParametersClear();
                if (_recv_date != 0.0)
                {
                    strSQL.Append("AND PUR.RECV_DATE        =:RECV_DATE");
                    db.DbPsetDouble("RECV_DATE", _recv_date);
                }
                if (_buyer_cd != "")
                {
                    strSQL.Append("AND PUR.BUYER_CD        =:BUYER_CD");
                    db.DbPsetString("BUYER_CD", _buyer_cd);
                }
                if (_sch_id != "")
                {
                    strSQL.Append("AND PUR.SCH_ID        =:SCH_ID");
                    db.DbPsetString("SCH_ID", _sch_id);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append("AND PUR.VENDOR_CD        =:VENDOR_CD");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("AND PUR.ITEM_NO        =:ITEM_NO");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_catg_cd != "")
                {
                    strSQL.Append("AND I.CATG_CD        =:CATG_CD");
                    db.DbPsetString("CATG_CD", _catg_cd);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("AND PUR.JOC_CD        =:JOC_CD");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append("AND PUR.WHS_CD        =:WHS_CD");
                    db.DbPsetString("WHS_CD", _whs_cd);
                }
                strSQL.Append(" AND PUR.RECV_QTY > 0");
            }
            else
            {
                strSQL.Append(" FROM PUR_ORDER PUR                                                                                  ");
                strSQL.Append(" LEFT JOIN  VENDOR_MASTER  V ON   PUR.VENDOR_CD=V.VENDOR_CD                                          ");
                strSQL.Append(" LEFT JOIN  ITEM_MASTER    I   ON   PUR.ITEM_NO=I.ITEM_NO                                            ");
                strSQL.Append(" LEFT JOIN  WAREHOUSE_MASTER   W ON   PUR.WHS_CD=W.WHS_CD                                            ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER  S1 ON   PUR.PO_UMSR = S1.KEY02  AND S1.KEY01='ITEM_UMSR'          ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER  S2 ON   PUR.BUYER_CD  = S2.KEY02  AND S2.KEY01='BUYER_CD'         ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER  S3 ON   PUR.SCH_ID  = S3.KEY02 AND S3.KEY01='SCH_ID'              ");
                strSQL.Append(" WHERE 1=1                                                                                           ");

                db.DbParametersClear();
                if (_recv_date != 0.0)
                {
                    strSQL.Append(" AND PUR.RECV_DATE        =@RECV_DATE");
                    db.DbPsetDouble("@RECV_DATE", _recv_date);
                }
                if (_buyer_cd != "")
                {
                    strSQL.Append(" AND PUR.BUYER_CD        =@BUYER_CD");
                    db.DbPsetString("@BUYER_CD", _buyer_cd);
                }
                if (_sch_id != "")
                {
                    strSQL.Append(" AND PUR.SCH_ID        =@SCH_ID");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append(" AND PUR.VENDOR_CD        =@VENDOR_CD");
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND PUR.ITEM_NO        =@ITEM_NO");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD        =@CATG_CD");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append(" AND PUR.JOC_CD        =@JOC_CD");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND PUR.WHS_CD        =@WHS_CD");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }
                strSQL.Append(" AND PUR.RECV_QTY > 0");

                strSQL.Append(" ORDER BY PUR.ITEM_NO,PUR.RECV_DATE DESC,PUR.PO_NO");    // 2013.08.28 Add Hoshina
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
        /// PurInspRptの取 得
        ///
        /// <para>使用画面：PurInspRpt</para>
        /// </summary>
        public DataSet Get_Pur_InspRptList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();
            // sql
            strSQL.Append(" SELECT                                                                                                  ");
            strSQL.Append(" AP.TRANS_DATE                   ,AP.FROM_VC_CD             ,CASE AP.PO_NO WHEN NULL  THEN NULL WHEN ''  ");
            strSQL.Append(" THEN NULL  ELSE  AP.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),AP.PO_LINE_NO),3) END AS PO_NO  ,              ");
            strSQL.Append(" AP.ITEM_NO                      ,AP.ITEM_DESC              ,PUR.PO_QTY          ,                       ");
            strSQL.Append(" PUR.PO_UMSR                     ,AP.REJ_QTY                ,AP.QTY              ,                       ");
            strSQL.Append(" AP.ACT_PRC                      ,AP.ACT_AMT                ,AP.PO_CUR           ,                       ");
            strSQL.Append(" W.WHS_DESC                      ,AP.TO_VC_CD               ,V.VENDOR_NAME,      AP.TO_JOC_CD   ,        ");
            strSQL.Append(" PUR.BUYER_CD                    ,PUR.SCH_ID                ,PUR.JOC_CD     ,                            ");
            strSQL.Append(" S1.DATA_CHAR AS BUYER_NAME      ,S2.DATA_CHAR AS SCH_NAME , PUR.WHS_CD     ,                            ");
            strSQL.Append(" S3.DATA_CHAR AS ITEM_NAME       ,S4.DATA_CHAR AS CUR_NAME                                               ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM AP_TRANS AP , PUR_ORDER PUR , WAREHOUSE_MASTER  W ,VENDOR_MASTER V ,            ");
                strSQL.Append("SYSTEM_PARAMETER  S1 , SYSTEM_PARAMETER  S2                                           ");
                strSQL.Append(" WHERE  AP.PO_NO           =PUR.PO_NO(+)                                              ");
                strSQL.Append(" AND    AP.PO_LINE_NO      =PUR.PO_LINE_NO                                            ");
                strSQL.Append(" AND    AP.WHS_CD          =WAREHOUSE_MASTER.WHS_CD(+)                                ");
                strSQL.Append(" AND    PUR.FROM_VC_CD     =VENDOR_MASTER.VENDOR_CD(+)                                ");
                strSQL.Append(" AND    PUR.BUYER_CD       =S1.KEY02(+)  AND S1.KEY01='BUYER_CD'                      ");
                strSQL.Append(" AND    PUR.SCH_ID         =S2.KEY02(+)  AND S2.KEY01='SCH_ID'                        ");

                db.DbParametersClear();
                if (_vendor_cd != "")
                {
                    strSQL.Append("AND AP.FROM_VC_CD        =:VENDOR_CD ");
                    db.DbPsetString("VENDOR_CD ", _vendor_cd);
                }
                if (_beg_eff_date != 0.0)
                {
                    strSQL.Append("AND AP.BEG_EFF_DATE        =:BEG_EFF_DATE ");
                    db.DbPsetDouble("TRANS_DATE", _beg_eff_date);
                }
                if (_end_eff_date != 0.0)
                {
                    strSQL.Append("AND AP.END_EFF_DATE        =:END_EFF_DATE ");
                    db.DbPsetDouble("TRANS_DATE ", _end_eff_date);
                }
            }
            else
            {
                strSQL.Append(" FROM AP_TRANS AP                                                                            ");
                strSQL.Append(" LEFT JOIN  PUR_ORDER  PUR   ON    AP.PO_NO=PUR.PO_NO                                        ");
                strSQL.Append(" AND    AP.PO_LINE_NO=PUR.PO_LINE_NO                                                         ");
                strSQL.Append(" LEFT JOIN  WAREHOUSE_MASTER  W      ON    PUR.WHS_CD=W.WHS_CD                               ");
                strSQL.Append(" LEFT JOIN  VENDOR_MASTER     V      ON    AP.FROM_VC_CD=V.VENDOR_CD                         ");
                strSQL.Append(" LEFT JOIN  SYSTEM_PARAMETER    S1   ON    PUR.BUYER_CD=S1.KEY02 AND S1.KEY01='BUYER_CD'     ");
                strSQL.Append(" LEFT JOIN  SYSTEM_PARAMETER    S2   ON    PUR.SCH_ID=S2.KEY02   AND S2.KEY01='SCH_ID'       ");
                strSQL.Append(" LEFT JOIN  SYSTEM_PARAMETER    S3   ON    PUR.PO_UMSR=S3.KEY02   AND S3.KEY01='ITEM_UMSR'   ");
                strSQL.Append(" LEFT JOIN  SYSTEM_PARAMETER    S4   ON    AP.PO_CUR=S4.KEY02   AND S4.KEY01='CURRENCY_CD'   ");
                strSQL.Append(" WHERE  1=1                                                                                  ");

                db.DbParametersClear();
                if (_vendor_cd != "")
                {
                    strSQL.Append(" AND AP.FROM_VC_CD        =@VENDOR_CD ");
                    db.DbPsetString("@VENDOR_CD ", _vendor_cd);
                }
                if (_beg_eff_date != 0.0)
                {
                    strSQL.Append(" AND AP.TRANS_DATE       >=@BEG_EFF_DATE ");
                    db.DbPsetDouble("@BEG_EFF_DATE ", _beg_eff_date);
                }
                if (_end_eff_date != 0.0)
                {
                    strSQL.Append(" AND AP.TRANS_DATE        <=@END_EFF_DATE ");
                    db.DbPsetDouble("@END_EFF_DATE ", _end_eff_date);
                }

                strSQL.Append(" ORDER  BY  AP.TRANS_DATE,  AP.FROM_VC_CD ,PO_NO                      ");
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
        /// PurInspCancelの取 得
        ///
        /// <para>使用画面：PurInspCancel</para>
        /// </summary>
        public DataSet Get_Pur_InspCancelList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            // sql
            strSQL.Append(" SELECT                                                                                                                       ");
            strSQL.Append(" CASE TR.PO_NO WHEN NULL THEN NULL WHEN '' THEN NULL ELSE TR.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),TR.PO_LINE_NO),3) END AS PO_NO   ,TR.PARTIAL_DELV_COMPL_CNT          ,                   ");
            strSQL.Append(" TR.ITEM_NO             ,TR.ITEM_DESC              ,TR.RECV_QTY_PUR_UMSR  ,                                                   ");
            strSQL.Append(" TR.PUR_UMSR            ,TR2.QTY_PUR_UMSR          ,TR2.SLIP_DATE,            TR2.REJ_QTY_PUR_UMSR      ,TR2.XFER_TEXT,       ");
            strSQL.Append(" TR2.TO_LOT_NO          ,TR2.XFER_NO               ,TR.TO_JOC_CD              ,TR.TO_WHS_CD ,                                 ");
            strSQL.Append(" W.WHS_DESC             ,S1.DATA_CHAR AS UMSR_NAME ,TR.XFER_SCH_DATE          ,S2.DATA_CHAR  AS XFER_DESC                     ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM TRANSFER_TRANS TR ,  SYSTEM_PARAMETER  S1 ,  WAREHOUSE_MASTER W,           ");
                strSQL.Append(" FROM TRANSFER_TRANS TR2                                                         ");
                strSQL.Append(" WHERE TR.XFER_STATUS     =20                                                    ");
                strSQL.Append(" AND TR.REQ_TYPE          = '01'                                                 ");
                strSQL.Append(" AND TR.PUR_UMSR=S1.KEY02(+) AND  S1.KEY01='ITEM_UMSR'                           ");
                strSQL.Append(" AND TR.TO_WHS_CD          =W.WHS_CD(+)                                          ");
                strSQL.Append(" AND INNER JOIN           TR.XFER_NO=TR2.XFER_NO    AND TR2.XFER_STATUS <=50     ");


                db.DbParametersClear();
                if (_slip_date != 0.0)
                {
                    strSQL.Append(" AND TR2.SLIP_DATE       =:SLIP_DATE ");
                    db.DbPsetDouble("SLIP_DATE ", _slip_date);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append(" AND TR.FROM_VC_CD      =:VENDOR_CD ");
                    db.DbPsetString("VENDOR_CD ", _vendor_cd);
                }
                if (_po_no != "")
                {
                    strSQL.Append(" AND TR.PO_NO        =:PO_NO  ");
                    db.DbPsetString("PO_NO  ", _po_no);
                }
                if (_po_line_no != 0.0)
                {
                    strSQL.Append(" AND TR.PO_LINE_NO        =:PO_LINE_NO ");
                    db.DbPsetInt("PO_LINE_NO ", _po_line_no);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND TR.ITEM_NO        =:ITEM_NO ");
                    db.DbPsetString("ITEM_NO ", _item_no);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND TR.TO_WHS_CD        =:TO_WHS_CD ");
                    db.DbPsetString("TO_WHS_CD ", _whs_cd);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append(" AND TR.TO_JOC_CD        =:TO_JOC_CD ");
                    db.DbPsetString("TO_JOC_CD ", _joc_cd);
                }
            }
            else
            {
                strSQL.Append(" FROM TRANSFER_TRANS TR                                                                         ");
                strSQL.Append(" LEFT JOIN  SYSTEM_PARAMETER S1 ON TR.PUR_UMSR=S1.KEY02 AND  S1.KEY01='ITEM_UMSR'               ");
                strSQL.Append(" LEFT JOIN  SYSTEM_PARAMETER S2 ON TR.XFER_TEXT=S2.KEY02 AND  S2.KEY01='REJ_CD'                 ");
                strSQL.Append(" LEFT JOIN  WAREHOUSE_MASTER W  ON TR.TO_WHS_CD=W.WHS_CD                                        ");
                strSQL.Append(" INNER JOIN  TRANSFER_TRANS TR2 ON TR.XFER_NO=TR2.PARENT_XFER_NO    AND TR2.XFER_STATUS <=50    ");
                strSQL.Append(" WHERE TR.XFER_STATUS     <=20                                                                  ");
                strSQL.Append(" AND TR.REQ_TYPE          ='01'                                                                 ");

                db.DbParametersClear();
                if (_slip_date != 0.0)
                {
                    strSQL.Append(" AND TR2.SLIP_DATE        =@SLIP_DATE ");
                    db.DbPsetDouble("@SLIP_DATE ", _slip_date);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append(" AND TR.FROM_VC_CD        =@VENDOR_CD ");
                    db.DbPsetString("@VENDOR_CD ", _vendor_cd);
                }
                if (_po_no != "")
                {
                              //strSQL.Append(" AND TR.PO_NO        =@PO_NO  ");
                    //strSQL.Append("   AND (TR.PO_NO = @PO_NO OR TR.SLIP_NO = @PO_NO) "); // 2015.03.03
                    strSQL.Append("   AND (TR.PO_NO = @PO_NO OR TR.SLIP_NO = @PO_NO OR TR.SLIP_NO+RIGHT('000'+CONVERT(VARCHAR(3),TR.SLIP_LINE_NO),3) = @PO_NO) "); // 2015.03.07
                    db.DbPsetString("@PO_NO  ", _po_no);
                }
                if (_po_line_no != 0.0)
                {
                    strSQL.Append(" AND TR.PO_LINE_NO        =@PO_LINE_NO ");
                    db.DbPsetInt("@PO_LINE_NO ", _po_line_no);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND TR.ITEM_NO        =@ITEM_NO ");
                    db.DbPsetString("@ITEM_NO ", _item_no);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND TR.TO_WHS_CD        =@TO_WHS_CD ");
                    db.DbPsetString("@TO_WHS_CD ", _whs_cd);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append(" AND TR.TO_JOC_CD        =@TO_JOC_CD ");
                    db.DbPsetString("@TO_JOC_CD ", _joc_cd);
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
        /// PurInspCancelの取 得
        ///
        /// <para>使用画面：PurInspCancel</para>
        /// </summary>
        public int Pur_InspCancel()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);
            db.DbBeginTrans();

            rtn = db.DbStored("SP_PUR_INSPCANCEL");
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
        /// PurReturnCancelの取 得
        ///
        /// <para>使用画面：PurReturnCancel</para>
        /// </summary>
        public DataSet Get_Pur_ReturnCancelList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            // sql
            strSQL.Append(" SELECT                                                                                                               ");
            strSQL.Append(" TR.XFER_NO             ,CASE TR.PO_NO WHEN NULL  THEN NULL WHEN ''  THEN NULL  ELSE  TR.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),TR.PO_LINE_NO),3) END AS PO_NO        ,TR.SLIP_DATE    , ");
            strSQL.Append(" TR.ITEM_NO             ,TR.ITEM_DESC                          , TR.REJ_QTY_PUR_UMSR                                         , ");
            strSQL.Append(" TR.TO_JOC_CD           ,TR.FROM_WHS_CD                          , TR.XFER_TEXT   ,                                     ");
            strSQL.Append(" TR.PUR_UMSR            ,S1.DATA_CHAR AS UMSR_NAME             ,W.WHS_DESC                                            ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM TRANSFER_TRANS TR ,  SYSTEM_PARAMETER  S1 ,  WAREHOUSE_MASTER W    ");
                strSQL.Append(" WHERE                                                                   ");
                strSQL.Append(" TR.PUR_UMSR          =S1.KEY01(+)                                       ");
                strSQL.Append(" AND TR.FROM_WHS_CD          =W.WHS_CD(+)                                  ");
                strSQL.Append(" WHERE (TR.XFER_STATUS  = 20                                             ");
                strSQL.Append(" OR TR.XFER_STATUS     = 50   )                                          ");
                strSQL.Append(" AND TR.REQ_TYPE          = '25'                                         ");

                db.DbParametersClear();
                if (_slip_date != 0.0)
                {
                    strSQL.Append("AND TR.SLIP_DATE        =:SLIP_DATE ");
                    db.DbPsetDouble("SLIP_DATE ", _slip_date);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append("AND TR.TO_VC_CD        =:VENDOR_CD ");
                    db.DbPsetString("VENDOR_CD ", _vendor_cd);
                }
                if (_po_no != "")
                {
                    strSQL.Append("AND TR.PO_NO        =:PO_NO  ");
                    db.DbPsetString("PO_NO  ", _po_no);
                }
                if (_po_line_no != 0.0)
                {
                    strSQL.Append("AND TR.PO_LINE_NO        =:PO_LINE_NO ");
                    db.DbPsetInt("PO_LINE_NO ", _po_line_no);
                }
                if (_item_no != "")
                {
                    strSQL.Append("AND TR.ITEM_NO        =:ITEM_NO ");
                    db.DbPsetString("ITEM_NO ", _item_no);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append("AND TR.FROM_WHS_CD        =:FROM_WHS_CD ");
                    db.DbPsetString("FROM_WHS_CD ", _whs_cd);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("AND TR.TO_JOC_CD        =:TO_JOC_CD ");
                    db.DbPsetString("TO_JOC_CD ", _joc_cd);
                }

            }
            else
            {
                strSQL.Append(" FROM TRANSFER_TRANS TR                                                              ");
                strSQL.Append(" LEFT JOIN  SYSTEM_PARAMETER S1 ON TR.PUR_UMSR=S1.KEY02 AND  S1.KEY01='ITEM_UMSR'    ");
                strSQL.Append(" LEFT JOIN  WAREHOUSE_MASTER W  ON TR.FROM_WHS_CD=W.WHS_CD                           ");
                strSQL.Append(" WHERE (TR.XFER_STATUS  = 20                                                         ");
                strSQL.Append(" OR TR.XFER_STATUS     = 0                                                           "); // IMV3
                strSQL.Append(" OR TR.XFER_STATUS     = 50   )                                                      ");
                strSQL.Append(" AND TR.REQ_TYPE          = '25'                                                     ");


                db.DbParametersClear();
                if (_slip_date != 0.0)
                {
                    strSQL.Append(" AND TR.SLIP_DATE        =@SLIP_DATE ");
                    db.DbPsetDouble("@SLIP_DATE ", _slip_date);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append(" AND TR.TO_VC_CD        =@VENDOR_CD ");
                    db.DbPsetString("@VENDOR_CD ", _vendor_cd);
                }
                if (_po_no != "")
                {
                    //strSQL.Append(" AND TR.PO_NO        =@PO_NO  ");
                    strSQL.Append("   AND (TR.PO_NO = @PO_NO OR TR.SLIP_NO = @PO_NO) "); // 2015.03.03

                    db.DbPsetString("@PO_NO  ", _po_no);
                }
                if (_po_line_no != 0.0)
                {
                    strSQL.Append(" AND TR.PO_LINE_NO        =@PO_LINE_NO ");
                    db.DbPsetInt("@PO_LINE_NO ", _po_line_no);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND TR.ITEM_NO        =@ITEM_NO ");
                    db.DbPsetString("@ITEM_NO ", _item_no);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND TR.FROM_WHS_CD        =@FROM_WHS_CD ");
                    db.DbPsetString("@FROM_WHS_CD ", _whs_cd);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append(" AND TR.TO_JOC_CD        =@TO_JOC_CD ");
                    db.DbPsetString("@TO_JOC_CD ", _joc_cd);
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
        /// PurReturnCancelの実行
        ///
        /// <para>使用画面：PurReturnCancel</para>
        /// </summary>
        public int Pur_ReturnCancel()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);
            db.DbBeginTrans();

            rtn = db.DbStored("SP_PUR_RETURNCANCEL");
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

        ///<summary>
        ///振替依頼データ（受入）を検索
        ///
        ///<para>使用画面：PurActInq</para>
        ///</summary>
        public DataSet Get_Pur_RcvList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            // 2015.08.24
            strSQL.Append(" SELECT  TOP 2001                                                                            ");
            strSQL.Append(" XFER_SCH_DATE,  VENDOR_CD, VENDOR_NAME, ITEM_NO, ITEM_DESC, ");
            strSQL.Append(" PO_NO,  PO_QTY, SUM(RECV_QTY_PUR_UMSR) RECV_QTY_PUR_UMSR, PUR_UMSR, MIN(PARTIAL_DELV_COMPL_CNT) PARTIAL_DELV_COMPL_CNT, ");
            strSQL.Append(" TO_JOC_CD, TO_WHS_CD, TO_LOT_NO, SUM(LABLE_QTY) LABLE_QTY, ");
            strSQL.Append(" INSP_CD,  IDTAG_UNIT_QTY, IDTAG_PRINT_FLAG, TO_LOCATION, DATA_INT, ");
            strSQL.Append(" WHS_DESC,  MAX(CMPL_INPUT_PRC) CMPL_INPUT_PRC, SUM(CMPL_INPUT_AMT) CMPL_INPUT_AMT, SUM(CONVERT(INT,APPROVE_USER_ID)) APPROVE_USER_ID, SUM(INST_QTY) INST_QTY, ");
            strSQL.Append(" INV_UMSR_NAME,  UMSR_CONV_RATIO ");
            strSQL.Append(" FROM ( ");

            strSQL.Append(" SELECT ");
            strSQL.Append(" T.XFER_SCH_DATE,   T.FROM_VC_CD VENDOR_CD,                        ");
            strSQL.Append(" CASE T.REQ_TYPE WHEN '26' THEN C.CUST_NAME ELSE VENDOR_MASTER.VENDOR_NAME END VENDOR_NAME, "); // IMV3
            strSQL.Append(" T.ITEM_NO,     T.ITEM_DESC,                                       "); // IMV3
            strSQL.Append(" CASE T.REQ_TYPE WHEN '26' THEN '' ELSE T.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),T.PO_LINE_NO),3) END PO_NO, "); // IMV3
            strSQL.Append(" CASE T.REQ_TYPE WHEN '26' THEN T.INST_QTY ELSE PUR_ORDER.PO_QTY END PO_QTY,                "); // IMV3
            strSQL.Append(" CASE T.REQ_TYPE WHEN '26' THEN T.INST_QTY ELSE T.RECV_QTY_PUR_UMSR END RECV_QTY_PUR_UMSR,  "); // IMV3
            strSQL.Append("  CASE T.REQ_TYPE WHEN '26' THEN SRT_ITEMUMSR.DATA_CHAR ELSE S_PUR_UMSR.DATA_CHAR END PUR_UMSR,  T.PARTIAL_DELV_COMPL_CNT,");
            strSQL.Append(" T.TO_JOC_CD,       T.TO_WHS_CD,   T.TO_LOT_NO,       ");
            strSQL.Append(" CASE T.REQ_TYPE WHEN '26' THEN 1 ELSE                                                       ");
            strSQL.Append(" CASE WHEN PUR_ORDER.INSP_CD = '' THEN                                                       ");
            strSQL.Append(" 	(CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_PRINT_FLAG,1) = 1 THEN	                        ");
            strSQL.Append(" 		(CASE WHEN T.CMPL_INPUT_PRC = 0 THEN                                  "); // IMV3
            strSQL.Append(" 	  	    (CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_UNIT_QTY,0) = 0 THEN 1	                    "); // IMV3
            strSQL.Append(" 			    ELSE ceiling(T.RECV_QTY_PUR_UMSR/PURCHASE_MASTER.IDTAG_UNIT_QTY) END "); // IMV3
            strSQL.Append(" 		    )                                                                                   "); // IMV3
            strSQL.Append(" 			ELSE 1 END                                                                      "); // IMV3
            strSQL.Append(" 		)                                                                                   "); // IMV3
            strSQL.Append(" 	ELSE 0 END                                                                              ");
            strSQL.Append(" 	)                                                                                       ");
            strSQL.Append(" ELSE (CASE WHEN S.DATA_INT = 0 THEN                                                         ");
            strSQL.Append(" 	(CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_PRINT_FLAG,1) = 1 THEN                          ");
            strSQL.Append(" 	    CONVERT(int, T.APPROVE_USER_ID)                                        "); // IMV3
            strSQL.Append(" 	ELSE 0 END                                                                              ");
            strSQL.Append(" 	)                                                                                       ");
            strSQL.Append(" ELSE 0 END) END                                                                    ");
            strSQL.Append(" END LABLE_QTY,                                                                  ");
            strSQL.Append(" ISNULL(PURCHASE_MASTER.INSP_CD,'') INSP_CD,PURCHASE_MASTER.IDTAG_UNIT_QTY,ISNULL(PURCHASE_MASTER.IDTAG_PRINT_FLAG,1) IDTAG_PRINT_FLAG,          ");
            strSQL.Append(" T.TO_LOCATION,     ISNULL(S.DATA_INT,0) DATA_INT,      W.WHS_DESC              ");
            strSQL.Append(" ,T.CMPL_INPUT_PRC, T.CMPL_INPUT_AMT,T.APPROVE_USER_ID, T.INST_QTY,SRT_ITEMUMSR.DATA_CHAR AS INV_UMSR_NAME                               "); // IMV3
            strSQL.Append(" ,CASE ISNULL(PURCHASE_MASTER.UMSR_CONV_RATIO,0) WHEN 0 THEN 1 ELSE PURCHASE_MASTER.UMSR_CONV_RATIO END UMSR_CONV_RATIO        ");

            strSQL.Append(" FROM TRANSFER_TRANS T                                                               ");
            strSQL.Append(" LEFT OUTER JOIN PUR_ORDER ON T.PO_NO=PUR_ORDER.PO_NO                   ");
            strSQL.Append(" AND T.PO_LINE_NO=PUR_ORDER.PO_LINE_NO                                  ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER ON T.ITEM_NO=ITEM_MASTER.ITEM_NO           ");
            strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER ON T.FROM_VC_CD=VENDOR_MASTER.VENDOR_CD  ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01='IDTAG_PRINT_TIMING'                  ");
            strSQL.Append(" LEFT OUTER JOIN PURCHASE_MASTER ON PUR_ORDER.ITEM_NO = PURCHASE_MASTER.ITEM_NO      ");
            strSQL.Append(" AND PUR_ORDER.SCH_COMPL_DATE >= PURCHASE_MASTER.BEG_EFF_DATE                        ");
            strSQL.Append(" AND PUR_ORDER.SCH_COMPL_DATE <= PURCHASE_MASTER.END_EFF_DATE                        ");
            strSQL.Append(" AND PUR_ORDER.VENDOR_CD = PURCHASE_MASTER.VENDOR_CD                                 ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PUR_UMSR ON S_PUR_UMSR.KEY01 = 'ITEM_UMSR'       ");
            strSQL.Append(" AND S_PUR_UMSR.KEY02 = T.PUR_UMSR                                      ");
            strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON T.TO_WHS_CD = W.WHS_CD           ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SRT_ITEMUMSR ON SRT_ITEMUMSR.KEY01 = 'ITEM_UMSR'   "); // IMV3
            strSQL.Append(" AND SRT_ITEMUMSR.KEY02 = T.ITEM_UMSR                                   "); // IMV3
            strSQL.Append(" LEFT JOIN CUSTOMER_MASTER C ON T.FROM_VC_CD=C.CUST_CD                  "); // IMV3
            strSQL.Append(" AND T.FROM_COST_CENTER       = C.CUST_SUB_CD                           "); // IMV3

            strSQL.Append(" WHERE T.REQ_TYPE in ('01','26')                                        "); // IMV3 26:顧客返品
            strSQL.Append(" AND T.XFER_STATUS<90                                                   ");

            db.DbParametersClear();
            if (_buyer_cd != "")
            {
                strSQL.Append(" AND T.BUYER_CD = @BUYER_CD    ");
                db.DbPsetString("@BUYER_CD", _buyer_cd);
            }
            if (_vendor_cd != "")
            {
                strSQL.Append(" AND T.FROM_VC_CD = @FROM_VC_CD");
                db.DbPsetString("@FROM_VC_CD", _vendor_cd);
            }
            if (_sch_id != "")
            {
                strSQL.Append(" AND T.SCH_ID = @SCH_ID");
                db.DbPsetString("@SCH_ID", _sch_id);
            }
            if (_item_no != "")
            {
                strSQL.Append(" AND T.ITEM_NO = @ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_catg_cd != "")
            {
                strSQL.Append(" AND ITEM_MASTER.CATG_CD = @CATG_CD");
                db.DbPsetString("@CATG_CD", _catg_cd);
            }
            if (_joc_cd != "")
            {
                strSQL.Append(" AND T.TO_JOC_CD = @TO_JOC_CD");
                db.DbPsetString("@TO_JOC_CD", _joc_cd);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND T.TO_WHS_CD = @TO_WHS_CD");
                db.DbPsetString("@TO_WHS_CD", _whs_cd);
            }
            if (_xfer_sch_date_from != 0)
            {
                strSQL.Append(" AND T.XFER_SCH_DATE >= @XFER_SCH_DATE_FROM");
                db.DbPsetInt("@XFER_SCH_DATE_FROM", _xfer_sch_date_from);
            }
            if (_xfer_sch_date_to != 0)
            {
                strSQL.Append(" AND T.XFER_SCH_DATE <= @XFER_SCH_DATE_TO");
                db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
            }
            if (_po_no != "")
            {
                strSQL.Append("   AND (T.PO_NO = @PO_NO OR T.SLIP_NO = @PO_NO) "); // 2015.03.03

                db.DbPsetString("@PO_NO", _po_no);
            }
            if (_lot_no != "")
            {
                strSQL.Append(" AND T.TO_LOT_NO = @TO_LOT_NO");
                db.DbPsetString("@TO_LOT_NO", _lot_no);
            }
            strSQL.Append(" ) A");
            
            strSQL.Append(" GROUP BY XFER_SCH_DATE,  VENDOR_CD, VENDOR_NAME, ITEM_NO, ITEM_DESC, ");
            strSQL.Append(" PO_NO,  PO_QTY, PUR_UMSR, ");
            strSQL.Append(" TO_JOC_CD, TO_WHS_CD, TO_LOT_NO, ");
            strSQL.Append(" INSP_CD,  IDTAG_UNIT_QTY, IDTAG_PRINT_FLAG, TO_LOCATION, DATA_INT, ");
            strSQL.Append(" WHS_DESC, ");
            strSQL.Append(" INV_UMSR_NAME,  UMSR_CONV_RATIO ");


            strSQL.Append(" ORDER BY XFER_SCH_DATE DESC, VENDOR_CD, ITEM_NO ASC ");

            //// DEL
            //strSQL.Append(" SELECT  TOP 2001                                                                            ");
            //strSQL.Append(" T.XFER_SCH_DATE,   T.FROM_VC_CD VENDOR_CD,                        ");
            ////strSQL.Append(" VENDOR_MASTER.VENDOR_NAME,      T.ITEM_NO,     T.ITEM_DESC,       ");
            //strSQL.Append(" CASE T.REQ_TYPE WHEN '26' THEN C.CUST_NAME ELSE VENDOR_MASTER.VENDOR_NAME END VENDOR_NAME, "); // IMV3
            //strSQL.Append(" T.ITEM_NO,     T.ITEM_DESC,                                       "); // IMV3
            ////strSQL.Append(" T.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),T.PO_LINE_NO),3) AS PO_NO, ");
            ////strSQL.Append(" PUR_ORDER.PO_QTY,               T.RECV_QTY_PUR_UMSR,                           ");
            //strSQL.Append(" CASE T.REQ_TYPE WHEN '26' THEN '' ELSE T.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),T.PO_LINE_NO),3) END PO_NO, "); // IMV3
            //strSQL.Append(" CASE T.REQ_TYPE WHEN '26' THEN T.INST_QTY ELSE PUR_ORDER.PO_QTY END PO_QTY,                "); // IMV3
            //strSQL.Append(" CASE T.REQ_TYPE WHEN '26' THEN T.INST_QTY ELSE T.RECV_QTY_PUR_UMSR END RECV_QTY_PUR_UMSR,  "); // IMV3
            ////strSQL.Append(" S_PUR_UMSR.DATA_CHAR PUR_UMSR,  T.PARTIAL_DELV_COMPL_CNT,                                   ");
            //strSQL.Append("  CASE T.REQ_TYPE WHEN '26' THEN SRT_ITEMUMSR.DATA_CHAR ELSE S_PUR_UMSR.DATA_CHAR END PUR_UMSR,  T.PARTIAL_DELV_COMPL_CNT,                                   ");
            //strSQL.Append(" T.TO_JOC_CD,       T.TO_WHS_CD,   T.TO_LOT_NO,       ");
            //strSQL.Append(" CASE T.REQ_TYPE WHEN '26' THEN 1 ELSE                                                       ");
            //strSQL.Append(" CASE WHEN PUR_ORDER.INSP_CD = '' THEN                                                       ");
            //strSQL.Append(" 	(CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_PRINT_FLAG,1) = 1 THEN	                        ");
            ////strSQL.Append(" 		(CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_UNIT_QTY,0) = 0 THEN 1                      ");
            ////strSQL.Append(" 			ELSE ceiling(T.RECV_QTY_PUR_UMSR/PURCHASE_MASTER.IDTAG_UNIT_QTY) END ");
            ////strSQL.Append(" 		)                                                                                   ");
            //strSQL.Append(" 		(CASE WHEN T.CMPL_INPUT_PRC = 0 THEN                                  "); // IMV3
            //strSQL.Append(" 	  	    (CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_UNIT_QTY,0) = 0 THEN 1	                    "); // IMV3
            //strSQL.Append(" 			    ELSE ceiling(T.RECV_QTY_PUR_UMSR/PURCHASE_MASTER.IDTAG_UNIT_QTY) END "); // IMV3
            //strSQL.Append(" 		    )                                                                                   "); // IMV3
            //strSQL.Append(" 			ELSE 1 END                                                                      "); // IMV3
            //strSQL.Append(" 		)                                                                                   "); // IMV3
            //strSQL.Append(" 	ELSE 0 END                                                                              ");
            //strSQL.Append(" 	)                                                                                       ");
            //strSQL.Append(" ELSE (CASE WHEN S.DATA_INT = 0 THEN                                                         ");
            //strSQL.Append(" 	(CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_PRINT_FLAG,1) = 1 THEN                          ");
            ////strSQL.Append(" 		(CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_UNIT_QTY,0) = 0 THEN 1	                    ");
            ////strSQL.Append(" 			ELSE ceiling(T.RECV_QTY_PUR_UMSR/PURCHASE_MASTER.IDTAG_UNIT_QTY) END ");
            ////strSQL.Append(" 		)                                                                                   ");
            ////strSQL.Append(" 		(CASE WHEN T.CMPL_INPUT_PRC = 0 THEN                                  "); // IMV3
            ////strSQL.Append(" 	  	    (CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_UNIT_QTY,0) = 0 THEN 1	                    "); // IMV3
            ////strSQL.Append(" 			    ELSE ceiling(T.RECV_QTY_PUR_UMSR/PURCHASE_MASTER.IDTAG_UNIT_QTY) END "); // IMV3
            ////strSQL.Append(" 		    )                                                                                   "); // IMV3
            ////strSQL.Append(" 			ELSE 1 END                                                                      "); // IMV3
            ////strSQL.Append(" 		)                                                                                   "); // IMV3
            //strSQL.Append(" 	    CONVERT(int, T.APPROVE_USER_ID)                                        "); // IMV3
            //strSQL.Append(" 	ELSE 0 END                                                                              ");
            //strSQL.Append(" 	)                                                                                       ");
            //strSQL.Append(" ELSE 0 END) END                                                                    ");
            //strSQL.Append(" END LABLE_QTY,                                                                  ");
            //strSQL.Append(" ISNULL(PURCHASE_MASTER.INSP_CD,'') INSP_CD,PURCHASE_MASTER.IDTAG_UNIT_QTY,ISNULL(PURCHASE_MASTER.IDTAG_PRINT_FLAG,1) IDTAG_PRINT_FLAG,          ");
            //strSQL.Append(" T.TO_LOCATION,     ISNULL(S.DATA_INT,0) DATA_INT,      W.WHS_DESC              ");
            //strSQL.Append(" ,T.CMPL_INPUT_PRC, T.CMPL_INPUT_AMT,T.APPROVE_USER_ID, T.INST_QTY,SRT_ITEMUMSR.DATA_CHAR AS INV_UMSR_NAME                               "); // IMV3
            //strSQL.Append(" ,CASE ISNULL(PURCHASE_MASTER.UMSR_CONV_RATIO,0) WHEN 0 THEN 1 ELSE PURCHASE_MASTER.UMSR_CONV_RATIO END UMSR_CONV_RATIO        ");

            //strSQL.Append(" FROM TRANSFER_TRANS T                                                               ");
            //strSQL.Append(" LEFT OUTER JOIN PUR_ORDER ON T.PO_NO=PUR_ORDER.PO_NO                   ");
            //strSQL.Append(" AND T.PO_LINE_NO=PUR_ORDER.PO_LINE_NO                                  ");
            //strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER ON T.ITEM_NO=ITEM_MASTER.ITEM_NO           ");
            //strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER ON T.FROM_VC_CD=VENDOR_MASTER.VENDOR_CD  ");
            //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01='IDTAG_PRINT_TIMING'                  ");
            //strSQL.Append(" LEFT OUTER JOIN PURCHASE_MASTER ON PUR_ORDER.ITEM_NO = PURCHASE_MASTER.ITEM_NO      ");
            //strSQL.Append(" AND PUR_ORDER.SCH_COMPL_DATE >= PURCHASE_MASTER.BEG_EFF_DATE                        ");
            //strSQL.Append(" AND PUR_ORDER.SCH_COMPL_DATE <= PURCHASE_MASTER.END_EFF_DATE                        ");
            //strSQL.Append(" AND PUR_ORDER.VENDOR_CD = PURCHASE_MASTER.VENDOR_CD                                 ");
            //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PUR_UMSR ON S_PUR_UMSR.KEY01 = 'ITEM_UMSR'       ");
            //strSQL.Append(" AND S_PUR_UMSR.KEY02 = T.PUR_UMSR                                      ");
            //strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON T.TO_WHS_CD = W.WHS_CD           ");
            //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SRT_ITEMUMSR ON SRT_ITEMUMSR.KEY01 = 'ITEM_UMSR'   "); // IMV3
            //strSQL.Append(" AND SRT_ITEMUMSR.KEY02 = T.ITEM_UMSR                                   "); // IMV3
            //strSQL.Append(" LEFT JOIN CUSTOMER_MASTER C ON T.FROM_VC_CD=C.CUST_CD                  "); // IMV3
            //strSQL.Append(" AND T.FROM_COST_CENTER       = C.CUST_SUB_CD                           "); // IMV3

            ////strSQL.Append(" WHERE T.REQ_TYPE='01'                                                  ");
            //strSQL.Append(" WHERE T.REQ_TYPE in ('01','26')                                        "); // IMV3 26:顧客返品
            //strSQL.Append(" AND T.XFER_STATUS<90                                                   ");

            //db.DbParametersClear();
            //if (_buyer_cd != "")
            //{
            //    strSQL.Append(" AND T.BUYER_CD = @BUYER_CD    ");
            //    db.DbPsetString("@BUYER_CD", _buyer_cd);
            //}
            //if (_vendor_cd != "")
            //{
            //    strSQL.Append(" AND T.FROM_VC_CD = @FROM_VC_CD");
            //    db.DbPsetString("@FROM_VC_CD", _vendor_cd);
            //}
            //if (_sch_id != "")
            //{
            //    strSQL.Append(" AND T.SCH_ID = @SCH_ID");
            //    db.DbPsetString("@SCH_ID", _sch_id);
            //}
            //if (_item_no != "")
            //{
            //    strSQL.Append(" AND T.ITEM_NO = @ITEM_NO");
            //    db.DbPsetString("@ITEM_NO", _item_no);
            //}
            //if (_catg_cd != "")
            //{
            //    strSQL.Append(" AND ITEM_MASTER.CATG_CD = @CATG_CD");
            //    db.DbPsetString("@CATG_CD", _catg_cd);
            //}
            //if (_joc_cd != "")
            //{
            //    strSQL.Append(" AND T.TO_JOC_CD = @TO_JOC_CD");
            //    db.DbPsetString("@TO_JOC_CD", _joc_cd);
            //}
            //if (_whs_cd != "")
            //{
            //    strSQL.Append(" AND T.TO_WHS_CD = @TO_WHS_CD");
            //    db.DbPsetString("@TO_WHS_CD", _whs_cd);
            //}
            //if (_xfer_sch_date_from != 0)
            //{
            //    strSQL.Append(" AND T.XFER_SCH_DATE >= @XFER_SCH_DATE_FROM");
            //    db.DbPsetInt("@XFER_SCH_DATE_FROM", _xfer_sch_date_from);
            //}
            //if (_xfer_sch_date_to != 0)
            //{
            //    strSQL.Append(" AND T.XFER_SCH_DATE <= @XFER_SCH_DATE_TO");
            //    db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
            //}
            //if (_po_no != "")
            //{
            //    //strSQL.Append(" AND T.PO_NO = @PO_NO");
            //    strSQL.Append("   AND (T.PO_NO = @PO_NO OR T.SLIP_NO = @PO_NO) "); // 2015.03.03

            //    db.DbPsetString("@PO_NO", _po_no);
            //}
            //if (_lot_no != "")
            //{
            //    strSQL.Append(" AND T.TO_LOT_NO = @TO_LOT_NO");
            //    db.DbPsetString("@TO_LOT_NO", _lot_no);
            //}
            //strSQL.Append(" ORDER BY T.XFER_SCH_DATE DESC, T.FROM_VC_CD,              ");
            //strSQL.Append(" T.ITEM_NO ASC	                                                        ");

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

        ///<summary>
        ///振替依頼データ（受入）を検索
        ///
        ///<para>使用画面：PurActInq</para>
        ///</summary>
        public DataSet Get_Pur_RcvList_Detail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            // 2015.08.24
            strSQL.Append(" SELECT  ");
            strSQL.Append(" T.XFER_SCH_DATE,   T.FROM_VC_CD VENDOR_CD,                        ");
            //strSQL.Append(" VENDOR_MASTER.VENDOR_NAME,      T.ITEM_NO,     T.ITEM_DESC,       ");
            strSQL.Append(" CASE T.REQ_TYPE WHEN '26' THEN C.CUST_NAME ELSE VENDOR_MASTER.VENDOR_NAME END VENDOR_NAME, "); // IMV3
            strSQL.Append(" T.ITEM_NO,     T.ITEM_DESC,                                       "); // IMV3
            //strSQL.Append(" T.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),T.PO_LINE_NO),3) AS PO_NO, ");
            //strSQL.Append(" PUR_ORDER.PO_QTY,               T.RECV_QTY_PUR_UMSR,                           ");
            strSQL.Append(" CASE T.REQ_TYPE WHEN '26' THEN '' ELSE T.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),T.PO_LINE_NO),3) END PO_NO, "); // IMV3
            strSQL.Append(" CASE T.REQ_TYPE WHEN '26' THEN T.INST_QTY ELSE PUR_ORDER.PO_QTY END PO_QTY,                "); // IMV3
            strSQL.Append(" CASE T.REQ_TYPE WHEN '26' THEN T.INST_QTY ELSE T.RECV_QTY_PUR_UMSR END RECV_QTY_PUR_UMSR,  "); // IMV3
            //strSQL.Append(" S_PUR_UMSR.DATA_CHAR PUR_UMSR,  T.PARTIAL_DELV_COMPL_CNT,                                   ");
            strSQL.Append("  CASE T.REQ_TYPE WHEN '26' THEN SRT_ITEMUMSR.DATA_CHAR ELSE S_PUR_UMSR.DATA_CHAR END PUR_UMSR,  T.PARTIAL_DELV_COMPL_CNT,                                   ");
            strSQL.Append(" T.TO_JOC_CD,       T.TO_WHS_CD,   T.TO_LOT_NO,       ");
            strSQL.Append(" CASE T.REQ_TYPE WHEN '26' THEN 1 ELSE                                                       ");
            strSQL.Append(" CASE WHEN PUR_ORDER.INSP_CD = '' THEN                                                       ");
            strSQL.Append(" 	(CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_PRINT_FLAG,1) = 1 THEN	                        ");
            //strSQL.Append(" 		(CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_UNIT_QTY,0) = 0 THEN 1                      ");
            //strSQL.Append(" 			ELSE ceiling(T.RECV_QTY_PUR_UMSR/PURCHASE_MASTER.IDTAG_UNIT_QTY) END ");
            //strSQL.Append(" 		)                                                                                   ");
            strSQL.Append(" 		(CASE WHEN T.CMPL_INPUT_PRC = 0 THEN                                  "); // IMV3
            strSQL.Append(" 	  	    (CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_UNIT_QTY,0) = 0 THEN 1	                    "); // IMV3
            strSQL.Append(" 			    ELSE ceiling(T.RECV_QTY_PUR_UMSR/PURCHASE_MASTER.IDTAG_UNIT_QTY) END "); // IMV3
            strSQL.Append(" 		    )                                                                                   "); // IMV3
            strSQL.Append(" 			ELSE 1 END                                                                      "); // IMV3
            strSQL.Append(" 		)                                                                                   "); // IMV3
            strSQL.Append(" 	ELSE 0 END                                                                              ");
            strSQL.Append(" 	)                                                                                       ");
            strSQL.Append(" ELSE (CASE WHEN S.DATA_INT = 0 THEN                                                         ");
            strSQL.Append(" 	(CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_PRINT_FLAG,1) = 1 THEN                          ");
            //strSQL.Append(" 		(CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_UNIT_QTY,0) = 0 THEN 1	                    ");
            //strSQL.Append(" 			ELSE ceiling(T.RECV_QTY_PUR_UMSR/PURCHASE_MASTER.IDTAG_UNIT_QTY) END ");
            //strSQL.Append(" 		)                                                                                   ");
            //strSQL.Append(" 		(CASE WHEN T.CMPL_INPUT_PRC = 0 THEN                                  "); // IMV3
            //strSQL.Append(" 	  	    (CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_UNIT_QTY,0) = 0 THEN 1	                    "); // IMV3
            //strSQL.Append(" 			    ELSE ceiling(T.RECV_QTY_PUR_UMSR/PURCHASE_MASTER.IDTAG_UNIT_QTY) END "); // IMV3
            //strSQL.Append(" 		    )                                                                                   "); // IMV3
            //strSQL.Append(" 			ELSE 1 END                                                                      "); // IMV3
            //strSQL.Append(" 		)                                                                                   "); // IMV3
            strSQL.Append(" 	    CONVERT(int, T.APPROVE_USER_ID)                                        "); // IMV3
            strSQL.Append(" 	ELSE 0 END                                                                              ");
            strSQL.Append(" 	)                                                                                       ");
            strSQL.Append(" ELSE 0 END) END                                                                    ");
            strSQL.Append(" END LABLE_QTY,                                                                  ");
            strSQL.Append(" ISNULL(PURCHASE_MASTER.INSP_CD,'') INSP_CD,PURCHASE_MASTER.IDTAG_UNIT_QTY,ISNULL(PURCHASE_MASTER.IDTAG_PRINT_FLAG,1) IDTAG_PRINT_FLAG,          ");
            strSQL.Append(" T.TO_LOCATION,     ISNULL(S.DATA_INT,0) DATA_INT,      W.WHS_DESC              ");
            strSQL.Append(" ,T.CMPL_INPUT_PRC, T.CMPL_INPUT_AMT,T.APPROVE_USER_ID, T.INST_QTY,SRT_ITEMUMSR.DATA_CHAR AS INV_UMSR_NAME                               "); // IMV3
            strSQL.Append(" ,CASE ISNULL(PURCHASE_MASTER.UMSR_CONV_RATIO,0) WHEN 0 THEN 1 ELSE PURCHASE_MASTER.UMSR_CONV_RATIO END UMSR_CONV_RATIO        ");

            strSQL.Append(" FROM TRANSFER_TRANS T                                                               ");
            strSQL.Append(" LEFT OUTER JOIN PUR_ORDER ON T.PO_NO=PUR_ORDER.PO_NO                   ");
            strSQL.Append(" AND T.PO_LINE_NO=PUR_ORDER.PO_LINE_NO                                  ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER ON T.ITEM_NO=ITEM_MASTER.ITEM_NO           ");
            strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER ON T.FROM_VC_CD=VENDOR_MASTER.VENDOR_CD  ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01='IDTAG_PRINT_TIMING'                  ");
            strSQL.Append(" LEFT OUTER JOIN PURCHASE_MASTER ON PUR_ORDER.ITEM_NO = PURCHASE_MASTER.ITEM_NO      ");
            strSQL.Append(" AND PUR_ORDER.SCH_COMPL_DATE >= PURCHASE_MASTER.BEG_EFF_DATE                        ");
            strSQL.Append(" AND PUR_ORDER.SCH_COMPL_DATE <= PURCHASE_MASTER.END_EFF_DATE                        ");
            strSQL.Append(" AND PUR_ORDER.VENDOR_CD = PURCHASE_MASTER.VENDOR_CD                                 ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PUR_UMSR ON S_PUR_UMSR.KEY01 = 'ITEM_UMSR'       ");
            strSQL.Append(" AND S_PUR_UMSR.KEY02 = T.PUR_UMSR                                      ");
            strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON T.TO_WHS_CD = W.WHS_CD           ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SRT_ITEMUMSR ON SRT_ITEMUMSR.KEY01 = 'ITEM_UMSR'   "); // IMV3
            strSQL.Append(" AND SRT_ITEMUMSR.KEY02 = T.ITEM_UMSR                                   "); // IMV3
            strSQL.Append(" LEFT JOIN CUSTOMER_MASTER C ON T.FROM_VC_CD=C.CUST_CD                  "); // IMV3
            strSQL.Append(" AND T.FROM_COST_CENTER       = C.CUST_SUB_CD                           "); // IMV3

            //strSQL.Append(" WHERE T.REQ_TYPE='01'                                                  ");
            strSQL.Append(" WHERE T.REQ_TYPE in ('01','26')                                        "); // IMV3 26:顧客返品
            strSQL.Append(" AND T.XFER_STATUS<90                                                   ");

            db.DbParametersClear();
            if (_xfer_sch_date != 0)
            {
                strSQL.Append(" AND T.XFER_SCH_DATE = @XFER_SCH_DATE");
                db.DbPsetInt("@XFER_SCH_DATE", _xfer_sch_date);
            }
            if (_vendor_cd != "")
            {
                strSQL.Append(" AND T.FROM_VC_CD = @FROM_VC_CD");
                db.DbPsetString("@FROM_VC_CD", _vendor_cd);
            }
            if (_item_no != "")
            {
                strSQL.Append(" AND T.ITEM_NO = @ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_po_no != "")
            {
                strSQL.Append("   AND T.SLIP_NO = @PO_NO ");
                db.DbPsetString("@PO_NO", _po_no);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND T.TO_WHS_CD = @TO_WHS_CD");
                db.DbPsetString("@TO_WHS_CD", _whs_cd);
            }
            if (_lot_no != "")
            {
                strSQL.Append(" AND T.TO_LOT_NO = @TO_LOT_NO");
                db.DbPsetString("@TO_LOT_NO", _lot_no);
            }
            if (_location != "")
            {
                strSQL.Append(" AND T.TO_LOCATION = @TO_LOCATION");
                db.DbPsetString("@TO_LOCATION", _location);
            }
            strSQL.Append(" ORDER BY T.XFER_NO  ");

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

        ///<summary>
        ///検収実績データを検索
        ///
        ///<para>使用画面：PurActInq</para>
        ///</summary>
        public DataSet Get_Pur_Ap_TransList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            // 2015.08.24
            strSQL.Append(" SELECT  TOP 2001                                                                            ");
            strSQL.Append(" SLIP_DATE,  VENDOR_CD, VENDOR_NAME, ITEM_NO, ITEM_DESC, ");
            strSQL.Append(" PO_NO,  PO_QTY, SUM(RECV_QTY_PUR_UMSR) RECV_QTY_PUR_UMSR, SUM(QTY) QTY, SUM(RECV_QTY) RECV_QTY, PUR_UMSR, ");
            strSQL.Append(" MAX(ACT_PRC) ACT_PRC,  SUM(ACT_AMT) ACT_AMT, PO_CUR, MIN(PARTIAL_DELV_CNT) PARTIAL_DELV_CNT, ");

            strSQL.Append(" TO_JOC_CD, TO_WHS_CD, TO_LOT_NO, SUM(DESTRUCT_QTY_PUR_UMSR) DESTRUCT_QTY_PUR_UMSR, SUM(REJ_QTY_PUR_UMSR) REJ_QTY_PUR_UMSR, SUM(LABLE_QTY) LABLE_QTY, ");
            strSQL.Append(" INSP_CD,  IDTAG_UNIT_QTY, IDTAG_PRINT_FLAG, TO_LOCATION, DATA_INT, ");
            strSQL.Append(" WHS_DESC,  MAX(CMPL_INPUT_PRC) CMPL_INPUT_PRC, SUM(CMPL_INPUT_AMT) CMPL_INPUT_AMT, SUM(CONVERT(INT,APPROVE_USER_ID)) APPROVE_USER_ID, SUM(INST_QTY) INST_QTY, ");
            strSQL.Append(" INV_UMSR_NAME,  UMSR_CONV_RATIO ");
            strSQL.Append(" FROM ( ");

            strSQL.Append(" SELECT   ");
            strSQL.Append(" AP_TRANS.SLIP_DATE,                                                                                                                 ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN AP_TRANS.TO_VC_CD ELSE AP_TRANS.FROM_VC_CD END) VENDOR_CD,                                  ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN RV.VENDOR_NAME ELSE VENDOR_MASTER.VENDOR_NAME END) VENDOR_NAME,                             ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" AP_TRANS.ITEM_NO,                   AP_TRANS.ITEM_DESC,                                                                             ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN '' ELSE (AP_TRANS.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),AP_TRANS.PO_LINE_NO),3)) END) PO_NO, ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" ISNULL(PUR_ORDER.PO_QTY,0) PO_QTY,                                                          ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" AP_TRANS.RECV_QTY RECV_QTY_PUR_UMSR,   AP_TRANS.QTY,                                        ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" AP_TRANS.QTY RECV_QTY,                                                                      ");     //Add 10.10.19 Ubiq-Sai
            strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN SRT_POUMSR.DATA_CHAR ELSE S_PUR_UMSR.DATA_CHAR END) PUR_UMSR,   ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" AP_TRANS.ACT_PRC,                                                                                       ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" AP_TRANS.ACT_AMT,                                                                       ");     //Add 10.10.19 Ubiq-Sai
            strSQL.Append(" S_PO_CUR.DATA_CHAR PO_CUR,      AP_TRANS.PARTIAL_DELV_CNT,                              ");
            strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN AP_TRANS.FROM_JOC_CD ELSE AP_TRANS.TO_JOC_CD END) TO_JOC_CD,  ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN AP_TRANS.FROM_WHS_CD ELSE AP_TRANS.TO_WHS_CD END) TO_WHS_CD,  ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN AP_TRANS.FROM_LOT_NO ELSE AP_TRANS.TO_LOT_NO END) TO_LOT_NO,  ");     //Add 2013.03.09 Ubiq-Sai

            strSQL.Append(" AP_TRANS.DESTRUCT_QTY DESTRUCT_QTY_PUR_UMSR,					                        ");     //Add 10.11.20 Ubiq-Sai
            strSQL.Append(" AP_TRANS.REJ_QTY REJ_QTY_PUR_UMSR,								                        ");     //Add 10.11.20 Ubiq-Sai
            strSQL.Append(" CASE WHEN PUR_ORDER.INSP_CD != '' THEN                                                      ");
            strSQL.Append(" (CASE WHEN S.DATA_INT = 1 THEN                                                              ");
            strSQL.Append(" 	(CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_PRINT_FLAG,1) = 1 THEN                          ");
            //strSQL.Append(" 		(CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_UNIT_QTY,0) = 0 THEN 1	                    ");
            //strSQL.Append("			ELSE ceiling((CASE WHEN AP_TRANS.QTY < 0 THEN 0 ELSE AP_TRANS.QTY                   ");
            //strSQL.Append("			                END)/PURCHASE_MASTER.IDTAG_UNIT_QTY) END                            ");
            //strSQL.Append(" 		)                                                                                   ");
            //strSQL.Append(" 		(CASE WHEN TT.CMPL_INPUT_PRC = 0 THEN                                  "); // IMV3
            //strSQL.Append(" 		    (CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_UNIT_QTY,0) = 0 THEN 1	                    "); // IMV3
            //strSQL.Append("			    ELSE ceiling((CASE WHEN AP_TRANS.QTY < 0 THEN 0 ELSE AP_TRANS.QTY                   "); // IMV3
            //strSQL.Append("			                    END)/PURCHASE_MASTER.IDTAG_UNIT_QTY) END                            "); // IMV3
            //strSQL.Append(" 		    )                                                                                   "); // IMV3
            //strSQL.Append(" 			ELSE 1 END                                                                      "); // IMV3
            //strSQL.Append(" 		)                                                                                   "); // IMV3
            strSQL.Append(" 	    CONVERT(int, TT11.APPROVE_USER_ID)                                                  "); // IMV3
            strSQL.Append(" 	ELSE 0 END                                                                              ");
            strSQL.Append(" 	)                                                                                       ");
            strSQL.Append(" ELSE 0 END) END LABLE_QTY,                                                                  ");
            strSQL.Append(" PUR_ORDER.INSP_CD,      PURCHASE_MASTER.IDTAG_UNIT_QTY, PURCHASE_MASTER.IDTAG_PRINT_FLAG,   ");
            strSQL.Append(" AP_TRANS.TO_LOCATION,   ISNULL(S.DATA_INT,0) DATA_INT,  W.WHS_DESC                          ");
            strSQL.Append(" ,TT11.CMPL_INPUT_PRC, TT11.CMPL_INPUT_AMT,TT11.APPROVE_USER_ID, TT11.INST_QTY,SRT_ITEMUMSR.DATA_CHAR AS INV_UMSR_NAME        "); // IMV3
            strSQL.Append(" ,CASE ISNULL(PURCHASE_MASTER.UMSR_CONV_RATIO,0) WHEN 0 THEN 1 ELSE PURCHASE_MASTER.UMSR_CONV_RATIO END UMSR_CONV_RATIO        ");

            strSQL.Append(" FROM AP_TRANS                                                                   ");
            strSQL.Append(" LEFT OUTER JOIN PUR_ORDER ON AP_TRANS.PO_NO=PUR_ORDER.PO_NO                     ");
            strSQL.Append(" AND AP_TRANS.PO_LINE_NO=PUR_ORDER.PO_LINE_NO                                    ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER ON AP_TRANS.ITEM_NO=ITEM_MASTER.ITEM_NO             ");
            strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER ON AP_TRANS.FROM_VC_CD=VENDOR_MASTER.VENDOR_CD    ");
            strSQL.Append(" LEFT OUTER JOIN PURCHASE_MASTER ON PUR_ORDER.ITEM_NO=PURCHASE_MASTER.ITEM_NO    ");
            strSQL.Append(" AND PUR_ORDER.SCH_COMPL_DATE>=PURCHASE_MASTER.BEG_EFF_DATE                      ");
            strSQL.Append(" AND PUR_ORDER.SCH_COMPL_DATE<=PURCHASE_MASTER.END_EFF_DATE                      ");
            strSQL.Append(" AND PUR_ORDER.VENDOR_CD=PURCHASE_MASTER.VENDOR_CD                               ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01='IDTAG_PRINT_TIMING'              ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PUR_UMSR ON S_PUR_UMSR.KEY01 = 'ITEM_UMSR'   ");
            strSQL.Append(" AND S_PUR_UMSR.KEY02 = PUR_ORDER.PO_UMSR                                        ");     //Add 10.10.31 Ubiq-Sai
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PO_CUR ON S_PO_CUR.KEY01='CURRENCY_CD'       ");
            strSQL.Append(" AND S_PO_CUR.KEY02=AP_TRANS.PO_CUR                                              ");
            strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON AP_TRANS.TO_WHS_CD = W.WHS_CD             ");

            // IMV3 START
            strSQL.Append(" INNER JOIN TRANSFER_TRANS TT11 ON AP_TRANS.FROM_MNG_NO=TT11.XFER_NO            ");
            strSQL.Append(" AND TT11.REQ_TYPE='11' AND TT11.XFER_STATUS < 90                                    ");
            strSQL.Append(" LEFT OUTER JOIN TRANSFER_TRANS TT ON TT11.PARENT_XFER_NO=TT.XFER_NO                 ");
            strSQL.Append(" AND TT.REQ_TYPE='01' AND TT.XFER_STATUS < 90                                        ");
            // IMV3 END

            //Add 2013.05.09 Ubiq-Sai Begin
            strSQL.Append(" LEFT OUTER JOIN TRANSFER_TRANS RT ON AP_TRANS.SLIP_NO=RT.XFER_NO                    ");
            strSQL.Append(" AND RT.REQ_TYPE='25'                                                                ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SRT_POUMSR ON SRT_POUMSR.KEY01 = 'ITEM_UMSR'       ");
            strSQL.Append(" AND SRT_POUMSR.KEY02 = RT.PUR_UMSR                                                  ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SRT_ITEMUMSR ON SRT_ITEMUMSR.KEY01 = 'ITEM_UMSR'   ");
            strSQL.Append(" AND SRT_ITEMUMSR.KEY02 = TT11.ITEM_UMSR                                               ");
            strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER RV ON AP_TRANS.TO_VC_CD = RV.VENDOR_CD                ");
            //Add 2013.05.09 Ubiq-Sai End


            db.DbParametersClear();
            strSQL.Append(" WHERE 1=1                                 ");
            if (_buyer_cd != "")
            {
                strSQL.Append(" AND PUR_ORDER.BUYER_CD = @BUYER_CD    ");
                db.DbPsetString("@BUYER_CD", _buyer_cd);
            }
            if (_sch_id != "")
            {
                strSQL.Append(" AND PUR_ORDER.SCH_ID = @SCH_ID");
                db.DbPsetString("@SCH_ID", _sch_id);
            }
            if (_catg_cd != "")
            {
                strSQL.Append(" AND ITEM_MASTER.CATG_CD = @CATG_CD");
                db.DbPsetString("@CATG_CD", _catg_cd);
            }
            if (_vendor_cd != "")
            {
                strSQL.Append(" AND AP_TRANS.FROM_VC_CD = @FROM_VC_CD");
                db.DbPsetString("@FROM_VC_CD", _vendor_cd);
            }
            if (_item_no != "")
            {
                strSQL.Append(" AND AP_TRANS.ITEM_NO = @ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }

            if (_joc_cd != "")
            {
                strSQL.Append(" AND AP_TRANS.TO_JOC_CD = @TO_JOC_CD");
                db.DbPsetString("@TO_JOC_CD", _joc_cd);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND AP_TRANS.TO_WHS_CD = @TO_WHS_CD");
                db.DbPsetString("@TO_WHS_CD", _whs_cd);
            }
            if (_xfer_sch_date_from != 0)
            {
                strSQL.Append(" AND AP_TRANS.SLIP_DATE >= @XFER_SCH_DATE_FROM");
                db.DbPsetInt("@XFER_SCH_DATE_FROM", _xfer_sch_date_from);
            }
            if (_xfer_sch_date_to != 0)
            {
                strSQL.Append(" AND AP_TRANS.SLIP_DATE <= @XFER_SCH_DATE_TO");
                db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
            }
            if (_po_no != "")
            {
                strSQL.Append(" AND AP_TRANS.PO_NO = @PO_NO");
                db.DbPsetString("@PO_NO", _po_no);
            }
            if (_lot_no != "")
            {
                strSQL.Append(" AND AP_TRANS.TO_LOT_NO = @TO_LOT_NO");
                db.DbPsetString("@TO_LOT_NO", _lot_no);
            }
            strSQL.Append(" ) A");

            strSQL.Append(" GROUP BY SLIP_DATE,  VENDOR_CD, VENDOR_NAME, ITEM_NO, ITEM_DESC, ");
            strSQL.Append(" PO_NO,  PO_QTY, PUR_UMSR, PO_CUR,");
            strSQL.Append(" TO_JOC_CD, TO_WHS_CD, TO_LOT_NO, ");
            strSQL.Append(" INSP_CD,  IDTAG_UNIT_QTY, IDTAG_PRINT_FLAG, TO_LOCATION, DATA_INT, ");
            strSQL.Append(" WHS_DESC, ");
            strSQL.Append(" INV_UMSR_NAME,  UMSR_CONV_RATIO ");

            strSQL.Append(" ORDER BY SLIP_DATE DESC,VENDOR_CD ASC,ITEM_NO ASC   ");


            //strSQL.Append(" ORDER BY AP_TRANS.SLIP_DATE DESC,AP_TRANS.FROM_VC_CD ASC,AP_TRANS.ITEM_NO ASC   ");

            // DEL
            //strSQL.Append(" SELECT  TOP 2001                                                                        ");
            //strSQL.Append(" AP_TRANS.SLIP_DATE,                                                                                                                 ");     //Add 2013.03.09 Ubiq-Sai
            //strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN AP_TRANS.TO_VC_CD ELSE AP_TRANS.FROM_VC_CD END) VENDOR_CD,                                  ");     //Add 2013.03.09 Ubiq-Sai
            //strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN RV.VENDOR_NAME ELSE VENDOR_MASTER.VENDOR_NAME END) VENDOR_NAME,                             ");     //Add 2013.03.09 Ubiq-Sai
            //strSQL.Append(" AP_TRANS.ITEM_NO,                   AP_TRANS.ITEM_DESC,                                                                             ");     //Add 2013.03.09 Ubiq-Sai
            //strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN '' ELSE (AP_TRANS.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),AP_TRANS.PO_LINE_NO),3)) END) PO_NO, ");     //Add 2013.03.09 Ubiq-Sai
            //strSQL.Append(" ISNULL(PUR_ORDER.PO_QTY,0) PO_QTY,                                                          ");     //Add 2013.03.09 Ubiq-Sai
            //strSQL.Append(" AP_TRANS.RECV_QTY RECV_QTY_PUR_UMSR,   AP_TRANS.QTY,                                        ");     //Add 2013.03.09 Ubiq-Sai
            //strSQL.Append(" AP_TRANS.QTY RECV_QTY,                                                                      ");     //Add 10.10.19 Ubiq-Sai
            //strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN SRT_POUMSR.DATA_CHAR ELSE S_PUR_UMSR.DATA_CHAR END) PUR_UMSR,   ");     //Add 2013.03.09 Ubiq-Sai
            //strSQL.Append(" AP_TRANS.ACT_PRC,                                                                                       ");     //Add 2013.03.09 Ubiq-Sai
            //strSQL.Append(" AP_TRANS.ACT_AMT,                                                                       ");     //Add 10.10.19 Ubiq-Sai
            //strSQL.Append(" S_PO_CUR.DATA_CHAR PO_CUR,      AP_TRANS.PARTIAL_DELV_CNT,                              ");
            //strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN AP_TRANS.FROM_JOC_CD ELSE AP_TRANS.TO_JOC_CD END) TO_JOC_CD,  ");     //Add 2013.03.09 Ubiq-Sai
            //strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN AP_TRANS.FROM_WHS_CD ELSE AP_TRANS.TO_WHS_CD END) TO_WHS_CD,  ");     //Add 2013.03.09 Ubiq-Sai
            //strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN AP_TRANS.FROM_LOT_NO ELSE AP_TRANS.TO_LOT_NO END) TO_LOT_NO,  ");     //Add 2013.03.09 Ubiq-Sai

            //strSQL.Append(" AP_TRANS.DESTRUCT_QTY DESTRUCT_QTY_PUR_UMSR,					                        ");     //Add 10.11.20 Ubiq-Sai
            //strSQL.Append(" AP_TRANS.REJ_QTY REJ_QTY_PUR_UMSR,								                        ");     //Add 10.11.20 Ubiq-Sai
            //strSQL.Append(" CASE WHEN PUR_ORDER.INSP_CD != '' THEN                                                      ");
            //strSQL.Append(" (CASE WHEN S.DATA_INT = 1 THEN                                                              ");
            //strSQL.Append(" 	(CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_PRINT_FLAG,1) = 1 THEN                          ");
            ////strSQL.Append(" 		(CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_UNIT_QTY,0) = 0 THEN 1	                    ");
            ////strSQL.Append("			ELSE ceiling((CASE WHEN AP_TRANS.QTY < 0 THEN 0 ELSE AP_TRANS.QTY                   ");
            ////strSQL.Append("			                END)/PURCHASE_MASTER.IDTAG_UNIT_QTY) END                            ");
            ////strSQL.Append(" 		)                                                                                   ");
            ////strSQL.Append(" 		(CASE WHEN TT.CMPL_INPUT_PRC = 0 THEN                                  "); // IMV3
            ////strSQL.Append(" 		    (CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_UNIT_QTY,0) = 0 THEN 1	                    "); // IMV3
            ////strSQL.Append("			    ELSE ceiling((CASE WHEN AP_TRANS.QTY < 0 THEN 0 ELSE AP_TRANS.QTY                   "); // IMV3
            ////strSQL.Append("			                    END)/PURCHASE_MASTER.IDTAG_UNIT_QTY) END                            "); // IMV3
            ////strSQL.Append(" 		    )                                                                                   "); // IMV3
            ////strSQL.Append(" 			ELSE 1 END                                                                      "); // IMV3
            ////strSQL.Append(" 		)                                                                                   "); // IMV3
            //strSQL.Append(" 	    CONVERT(int, TT11.APPROVE_USER_ID)                                                  "); // IMV3
            //strSQL.Append(" 	ELSE 0 END                                                                              ");
            //strSQL.Append(" 	)                                                                                       ");
            //strSQL.Append(" ELSE 0 END) END LABLE_QTY,                                                                  ");
            //strSQL.Append(" PUR_ORDER.INSP_CD,      PURCHASE_MASTER.IDTAG_UNIT_QTY, PURCHASE_MASTER.IDTAG_PRINT_FLAG,   ");
            //strSQL.Append(" AP_TRANS.TO_LOCATION,   ISNULL(S.DATA_INT,0) DATA_INT,  W.WHS_DESC                          ");
            //strSQL.Append(" ,TT11.CMPL_INPUT_PRC, TT11.CMPL_INPUT_AMT,TT11.APPROVE_USER_ID, TT11.INST_QTY,SRT_ITEMUMSR.DATA_CHAR AS INV_UMSR_NAME        "); // IMV3
            //strSQL.Append(" ,PURCHASE_MASTER.IDTAG_UNIT_QTY, PURCHASE_MASTER.UMSR_CONV_RATIO        "); // IMV3
            //strSQL.Append(" ,CASE ISNULL(PURCHASE_MASTER.UMSR_CONV_RATIO,0) WHEN 0 THEN 1 ELSE PURCHASE_MASTER.UMSR_CONV_RATIO END UMSR_CONV_RATIO        ");

            //strSQL.Append(" FROM AP_TRANS                                                                   ");
            //strSQL.Append(" LEFT OUTER JOIN PUR_ORDER ON AP_TRANS.PO_NO=PUR_ORDER.PO_NO                     ");
            //strSQL.Append(" AND AP_TRANS.PO_LINE_NO=PUR_ORDER.PO_LINE_NO                                    ");
            //strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER ON AP_TRANS.ITEM_NO=ITEM_MASTER.ITEM_NO             ");
            //strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER ON AP_TRANS.FROM_VC_CD=VENDOR_MASTER.VENDOR_CD    ");
            //strSQL.Append(" LEFT OUTER JOIN PURCHASE_MASTER ON PUR_ORDER.ITEM_NO=PURCHASE_MASTER.ITEM_NO    ");
            //strSQL.Append(" AND PUR_ORDER.SCH_COMPL_DATE>=PURCHASE_MASTER.BEG_EFF_DATE                      ");
            //strSQL.Append(" AND PUR_ORDER.SCH_COMPL_DATE<=PURCHASE_MASTER.END_EFF_DATE                      ");
            //strSQL.Append(" AND PUR_ORDER.VENDOR_CD=PURCHASE_MASTER.VENDOR_CD                               ");
            //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01='IDTAG_PRINT_TIMING'              ");
            //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PUR_UMSR ON S_PUR_UMSR.KEY01 = 'ITEM_UMSR'   ");
            //strSQL.Append(" AND S_PUR_UMSR.KEY02 = PUR_ORDER.PO_UMSR                                        ");     //Add 10.10.31 Ubiq-Sai
            //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PO_CUR ON S_PO_CUR.KEY01='CURRENCY_CD'       ");
            //strSQL.Append(" AND S_PO_CUR.KEY02=AP_TRANS.PO_CUR                                              ");
            //strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON AP_TRANS.TO_WHS_CD = W.WHS_CD             ");

            //// IMV3 START
            //strSQL.Append(" INNER JOIN TRANSFER_TRANS TT11 ON AP_TRANS.FROM_MNG_NO=TT11.XFER_NO            ");
            //strSQL.Append(" AND TT11.REQ_TYPE='11' AND TT11.XFER_STATUS < 90                                    ");
            //strSQL.Append(" LEFT OUTER JOIN TRANSFER_TRANS TT ON TT11.PARENT_XFER_NO=TT.XFER_NO                 ");
            //strSQL.Append(" AND TT.REQ_TYPE='01' AND TT.XFER_STATUS < 90                                        ");
            //// IMV3 END

            ////Add 2013.05.09 Ubiq-Sai Begin
            //strSQL.Append(" LEFT OUTER JOIN TRANSFER_TRANS RT ON AP_TRANS.SLIP_NO=RT.XFER_NO                    ");
            //strSQL.Append(" AND RT.REQ_TYPE='25'                                                                ");
            //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SRT_POUMSR ON SRT_POUMSR.KEY01 = 'ITEM_UMSR'       ");
            //strSQL.Append(" AND SRT_POUMSR.KEY02 = RT.PUR_UMSR                                                  ");
            //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SRT_ITEMUMSR ON SRT_ITEMUMSR.KEY01 = 'ITEM_UMSR'   ");
            //strSQL.Append(" AND SRT_ITEMUMSR.KEY02 = TT11.ITEM_UMSR                                               ");
            //strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER RV ON AP_TRANS.TO_VC_CD = RV.VENDOR_CD                ");
            ////Add 2013.05.09 Ubiq-Sai End


            //db.DbParametersClear();
            //strSQL.Append(" WHERE 1=1                                 ");
            //if (_buyer_cd != "")
            //{
            //    strSQL.Append(" AND PUR_ORDER.BUYER_CD = @BUYER_CD    ");
            //    db.DbPsetString("@BUYER_CD", _buyer_cd);
            //}
            //if (_sch_id != "")
            //{
            //    strSQL.Append(" AND PUR_ORDER.SCH_ID = @SCH_ID");
            //    db.DbPsetString("@SCH_ID", _sch_id);
            //}
            //if (_catg_cd != "")
            //{
            //    strSQL.Append(" AND ITEM_MASTER.CATG_CD = @CATG_CD");
            //    db.DbPsetString("@CATG_CD", _catg_cd);
            //}
            //if (_vendor_cd != "")
            //{
            //    strSQL.Append(" AND AP_TRANS.FROM_VC_CD = @FROM_VC_CD");
            //    db.DbPsetString("@FROM_VC_CD", _vendor_cd);
            //}
            //if (_item_no != "")
            //{
            //    strSQL.Append(" AND AP_TRANS.ITEM_NO = @ITEM_NO");
            //    db.DbPsetString("@ITEM_NO", _item_no);
            //}

            //if (_joc_cd != "")
            //{
            //    strSQL.Append(" AND AP_TRANS.TO_JOC_CD = @TO_JOC_CD");
            //    db.DbPsetString("@TO_JOC_CD", _joc_cd);
            //}
            //if (_whs_cd != "")
            //{
            //    strSQL.Append(" AND AP_TRANS.TO_WHS_CD = @TO_WHS_CD");
            //    db.DbPsetString("@TO_WHS_CD", _whs_cd);
            //}
            //if (_xfer_sch_date_from != 0)
            //{
            //    strSQL.Append(" AND AP_TRANS.SLIP_DATE >= @XFER_SCH_DATE_FROM");
            //    db.DbPsetInt("@XFER_SCH_DATE_FROM", _xfer_sch_date_from);
            //}
            //if (_xfer_sch_date_to != 0)
            //{
            //    strSQL.Append(" AND AP_TRANS.SLIP_DATE <= @XFER_SCH_DATE_TO");
            //    db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
            //}
            //if (_po_no != "")
            //{
            //    strSQL.Append(" AND AP_TRANS.PO_NO = @PO_NO");
            //    db.DbPsetString("@PO_NO", _po_no);
            //}
            //if (_lot_no != "")
            //{
            //    strSQL.Append(" AND AP_TRANS.TO_LOT_NO = @TO_LOT_NO");
            //    db.DbPsetString("@TO_LOT_NO", _lot_no);
            //}
            //strSQL.Append(" ORDER BY AP_TRANS.SLIP_DATE DESC,AP_TRANS.FROM_VC_CD ASC,AP_TRANS.ITEM_NO ASC   ");

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

        ///<summary>
        ///検収実績データを検索
        ///
        ///<para>使用画面：PurActInq</para>
        ///</summary>
        public DataSet Get_Pur_Ap_TransList_Detail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            // 2015.08.24
            strSQL.Append(" SELECT   ");
            strSQL.Append(" AP_TRANS.SLIP_DATE,                                                                                                                 ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN AP_TRANS.TO_VC_CD ELSE AP_TRANS.FROM_VC_CD END) VENDOR_CD,                                  ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN RV.VENDOR_NAME ELSE VENDOR_MASTER.VENDOR_NAME END) VENDOR_NAME,                             ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" AP_TRANS.ITEM_NO,                   AP_TRANS.ITEM_DESC,                                                                             ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN '' ELSE (AP_TRANS.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),AP_TRANS.PO_LINE_NO),3)) END) PO_NO, ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" ISNULL(PUR_ORDER.PO_QTY,0) PO_QTY,                                                          ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" AP_TRANS.RECV_QTY RECV_QTY_PUR_UMSR,   AP_TRANS.QTY,                                        ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" AP_TRANS.QTY RECV_QTY,                                                                      ");     //Add 10.10.19 Ubiq-Sai
            strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN SRT_POUMSR.DATA_CHAR ELSE S_PUR_UMSR.DATA_CHAR END) PUR_UMSR,   ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" AP_TRANS.ACT_PRC,                                                                                       ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" AP_TRANS.ACT_AMT,                                                                       ");     //Add 10.10.19 Ubiq-Sai
            strSQL.Append(" S_PO_CUR.DATA_CHAR PO_CUR,      AP_TRANS.PARTIAL_DELV_CNT,                              ");
            strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN AP_TRANS.FROM_JOC_CD ELSE AP_TRANS.TO_JOC_CD END) TO_JOC_CD,  ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN AP_TRANS.FROM_WHS_CD ELSE AP_TRANS.TO_WHS_CD END) TO_WHS_CD,  ");     //Add 2013.03.09 Ubiq-Sai
            strSQL.Append(" (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN AP_TRANS.FROM_LOT_NO ELSE AP_TRANS.TO_LOT_NO END) TO_LOT_NO,  ");     //Add 2013.03.09 Ubiq-Sai

            strSQL.Append(" AP_TRANS.DESTRUCT_QTY DESTRUCT_QTY_PUR_UMSR,					                        ");     //Add 10.11.20 Ubiq-Sai
            strSQL.Append(" AP_TRANS.REJ_QTY REJ_QTY_PUR_UMSR,								                        ");     //Add 10.11.20 Ubiq-Sai
            strSQL.Append(" CASE WHEN PUR_ORDER.INSP_CD != '' THEN                                                      ");
            strSQL.Append(" (CASE WHEN S.DATA_INT = 1 THEN                                                              ");
            strSQL.Append(" 	(CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_PRINT_FLAG,1) = 1 THEN                          ");
            //strSQL.Append(" 		(CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_UNIT_QTY,0) = 0 THEN 1	                    ");
            //strSQL.Append("			ELSE ceiling((CASE WHEN AP_TRANS.QTY < 0 THEN 0 ELSE AP_TRANS.QTY                   ");
            //strSQL.Append("			                END)/PURCHASE_MASTER.IDTAG_UNIT_QTY) END                            ");
            //strSQL.Append(" 		)                                                                                   ");
            //strSQL.Append(" 		(CASE WHEN TT.CMPL_INPUT_PRC = 0 THEN                                  "); // IMV3
            //strSQL.Append(" 		    (CASE WHEN ISNULL(PURCHASE_MASTER.IDTAG_UNIT_QTY,0) = 0 THEN 1	                    "); // IMV3
            //strSQL.Append("			    ELSE ceiling((CASE WHEN AP_TRANS.QTY < 0 THEN 0 ELSE AP_TRANS.QTY                   "); // IMV3
            //strSQL.Append("			                    END)/PURCHASE_MASTER.IDTAG_UNIT_QTY) END                            "); // IMV3
            //strSQL.Append(" 		    )                                                                                   "); // IMV3
            //strSQL.Append(" 			ELSE 1 END                                                                      "); // IMV3
            //strSQL.Append(" 		)                                                                                   "); // IMV3
            strSQL.Append(" 	    CONVERT(int, TT11.APPROVE_USER_ID)                                                  "); // IMV3
            strSQL.Append(" 	ELSE 0 END                                                                              ");
            strSQL.Append(" 	)                                                                                       ");
            strSQL.Append(" ELSE 0 END) END LABLE_QTY,                                                                  ");
            strSQL.Append(" PUR_ORDER.INSP_CD,      PURCHASE_MASTER.IDTAG_UNIT_QTY, PURCHASE_MASTER.IDTAG_PRINT_FLAG,   ");
            strSQL.Append(" AP_TRANS.TO_LOCATION,   ISNULL(S.DATA_INT,0) DATA_INT,  W.WHS_DESC                          ");
            strSQL.Append(" ,TT11.CMPL_INPUT_PRC, TT11.CMPL_INPUT_AMT,TT11.APPROVE_USER_ID, TT11.INST_QTY,SRT_ITEMUMSR.DATA_CHAR AS INV_UMSR_NAME        "); // IMV3
            strSQL.Append(" ,CASE ISNULL(PURCHASE_MASTER.UMSR_CONV_RATIO,0) WHEN 0 THEN 1 ELSE PURCHASE_MASTER.UMSR_CONV_RATIO END UMSR_CONV_RATIO        ");

            strSQL.Append(" FROM AP_TRANS                                                                   ");
            strSQL.Append(" LEFT OUTER JOIN PUR_ORDER ON AP_TRANS.PO_NO=PUR_ORDER.PO_NO                     ");
            strSQL.Append(" AND AP_TRANS.PO_LINE_NO=PUR_ORDER.PO_LINE_NO                                    ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER ON AP_TRANS.ITEM_NO=ITEM_MASTER.ITEM_NO             ");
            strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER ON AP_TRANS.FROM_VC_CD=VENDOR_MASTER.VENDOR_CD    ");
            strSQL.Append(" LEFT OUTER JOIN PURCHASE_MASTER ON PUR_ORDER.ITEM_NO=PURCHASE_MASTER.ITEM_NO    ");
            strSQL.Append(" AND PUR_ORDER.SCH_COMPL_DATE>=PURCHASE_MASTER.BEG_EFF_DATE                      ");
            strSQL.Append(" AND PUR_ORDER.SCH_COMPL_DATE<=PURCHASE_MASTER.END_EFF_DATE                      ");
            strSQL.Append(" AND PUR_ORDER.VENDOR_CD=PURCHASE_MASTER.VENDOR_CD                               ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01='IDTAG_PRINT_TIMING'              ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PUR_UMSR ON S_PUR_UMSR.KEY01 = 'ITEM_UMSR'   ");
            strSQL.Append(" AND S_PUR_UMSR.KEY02 = PUR_ORDER.PO_UMSR                                        ");     //Add 10.10.31 Ubiq-Sai
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PO_CUR ON S_PO_CUR.KEY01='CURRENCY_CD'       ");
            strSQL.Append(" AND S_PO_CUR.KEY02=AP_TRANS.PO_CUR                                              ");
            strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON AP_TRANS.TO_WHS_CD = W.WHS_CD             ");

            // IMV3 START
            strSQL.Append(" INNER JOIN TRANSFER_TRANS TT11 ON AP_TRANS.FROM_MNG_NO=TT11.XFER_NO            ");
            strSQL.Append(" AND TT11.REQ_TYPE='11' AND TT11.XFER_STATUS < 90                                    ");
            strSQL.Append(" LEFT OUTER JOIN TRANSFER_TRANS TT ON TT11.PARENT_XFER_NO=TT.XFER_NO                 ");
            strSQL.Append(" AND TT.REQ_TYPE='01' AND TT.XFER_STATUS < 90                                        ");
            // IMV3 END

            //Add 2013.05.09 Ubiq-Sai Begin
            strSQL.Append(" LEFT OUTER JOIN TRANSFER_TRANS RT ON AP_TRANS.SLIP_NO=RT.XFER_NO                    ");
            strSQL.Append(" AND RT.REQ_TYPE='25'                                                                ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SRT_POUMSR ON SRT_POUMSR.KEY01 = 'ITEM_UMSR'       ");
            strSQL.Append(" AND SRT_POUMSR.KEY02 = RT.PUR_UMSR                                                  ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SRT_ITEMUMSR ON SRT_ITEMUMSR.KEY01 = 'ITEM_UMSR'   ");
            strSQL.Append(" AND SRT_ITEMUMSR.KEY02 = TT11.ITEM_UMSR                                               ");
            strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER RV ON AP_TRANS.TO_VC_CD = RV.VENDOR_CD                ");
            //Add 2013.05.09 Ubiq-Sai End


            db.DbParametersClear();
            strSQL.Append(" WHERE 1=1                                 ");
            if (_slip_date != 0)
            {
                strSQL.Append(" AND AP_TRANS.SLIP_DATE = @SLIP_DATE");
                db.DbPsetInt("@SLIP_DATE", _slip_date);
            }
            if (_vendor_cd != "")
            {
                strSQL.Append(" AND (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN AP_TRANS.TO_VC_CD ELSE AP_TRANS.FROM_VC_CD END) = @VENDOR_CD");
                db.DbPsetString("@VENDOR_CD", _vendor_cd);
            }
            if (_item_no != "")
            {
                strSQL.Append(" AND AP_TRANS.ITEM_NO = @ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_po_no != "")
            {
                strSQL.Append("   AND AP_TRANS.PO_NO+RIGHT('000'+CONVERT(VARCHAR(3),AP_TRANS.PO_LINE_NO),3) = @PO_NO ");
                db.DbPsetString("@PO_NO", _po_no);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN AP_TRANS.FROM_WHS_CD ELSE AP_TRANS.TO_WHS_CD END) = @TO_WHS_CD");
                db.DbPsetString("@TO_WHS_CD", _whs_cd);
            }
            if (_lot_no != "")
            {
                strSQL.Append(" AND (CASE WHEN PUR_ORDER.PO_NO IS NULL THEN AP_TRANS.FROM_LOT_NO ELSE AP_TRANS.TO_LOT_NO END) = @TO_LOT_NO");
                db.DbPsetString("@TO_LOT_NO", _lot_no);
            }
            if (_location != "")
            {
                strSQL.Append(" AND AP_TRANS.TO_LOCATION = @TO_LOCATION");
                db.DbPsetString("@TO_LOCATION", _location);
            }
            strSQL.Append(" ORDER BY AP_TRANS.SLIP_NO  ");

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

        ///<summary>
        ///振替依頼データ（支給）を検索
        ///
        ///<para>使用画面：PurActInq</para>
        ///</summary>
        public DataSet Get_Pur_SupplyActList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            strSQL.Append(" SELECT  TOP 2001														");
            strSQL.Append(" RCV_DISB_TRANS.TRANS_DATE,          TRANSFER_TRANS.TO_VC_CD VENDOR_CD,  ");
            strSQL.Append(" VENDOR_MASTER.VENDOR_NAME,          TRANSFER_TRANS.ITEM_NO,             ");
            strSQL.Append(" TRANSFER_TRANS.ITEM_DESC,           ISNULL(RCV_DISB_TRANS.QTY,0) QTY,   ");
            strSQL.Append(" S_ITEM_UMSR.DATA_CHAR ITEM_UMSR,    TRANSFER_TRANS.ACT_PRC,             ");
            strSQL.Append(" TRANSFER_TRANS.ACT_PRC * ISNULL(RCV_DISB_TRANS.QTY,0) ACT_AMT,          ");
            strSQL.Append(" S_SUPPLY_CUR.DATA_CHAR SUPPLY_CUR,  RCV_DISB_TRANS.FROM_JOC_CD,         ");
            strSQL.Append(" RCV_DISB_TRANS.FROM_WHS_CD,         RCV_DISB_TRANS.FROM_LOT_NO,         ");
            strSQL.Append(" TRANSFER_TRANS.TO_SUPPLY_TYPE                                           ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM TRANSFER_TRANS                                                            ");
                strSQL.Append(" LEFT OUTER JOIN RCV_DISB_TRANS ON TRANSFER_TRANS.XFER_NO=RCV_DISB_TRANS.XFER_NO ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER ON RCV_DISB_TRANS.ITEM_NO=ITEM_MASTER.ITEM_NO       ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER ON RCV_DISB_TRANS.TO_VC_CD=VENDOR_MASTER.VENDOR_CD      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_ITEM_UMSR ON S_ITEM_UMSR.KEY01 = 'ITEM_UMSR'  ");
                strSQL.Append(" AND S_ITEM_UMSR.KEY02 = RCV_DISB_TRANS.ITEM_UMSR   ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_SUPPLY_CUR ON S_SUPPLY_CUR.KEY01='CURRENCY_CD' ");
                strSQL.Append(" AND S_SUPPLY_CUR.KEY02=TRANSFER_TRANS.TO_CUR ");

                db.DbParametersClear();
                strSQL.Append(" WHERE TRANSFER_TRANS.REQ_TYPE='24'  ");
                strSQL.Append(" AND RCV_DISB_TRANS.REQ_TYPE='24'    ");      //Add 10.06.01 Ubiq-sai
                strSQL.Append(" AND TRANSFER_TRANS.XFER_STATUS<90   ");
                if (_buyer_cd != "")
                {
                    strSQL.Append(" AND TRANSFER_TRANS.BUYER_CD = :BUYER_CD    ");
                    db.DbPsetString("BUYER_CD", _buyer_cd);
                }
                if (_sch_id != "")
                {
                    strSQL.Append(" AND TRANSFER_TRANS.SCH_ID = :SCH_ID");
                    db.DbPsetString("SCH_ID", _sch_id);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append(" AND TRANSFER_TRANS.TO_VC_CD = :TO_VC_CD");
                    db.DbPsetString("TO_VC_CD", _vendor_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND TRANSFER_TRANS.ITEM_NO = :ITEM_NO");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_catg_cd != "")
                {
                    strSQL.Append(" AND ITEM_MASTER.CATG_CD = :CATG_CD");
                    db.DbPsetString("CATG_CD", _catg_cd);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append(" AND RCV_DISB_TRANS.FROM_JOC_CD = :FROM_JOC_CD");
                    db.DbPsetString("FROM_JOC_CD", _joc_cd);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND RCV_DISB_TRANS.FROM_WHS_CD = :FROM_WHS_CD");
                    db.DbPsetString("FROM_WHS_CD", _whs_cd);
                }
                if (_xfer_sch_date_from != 0)
                {
                    strSQL.Append(" AND RCV_DISB_TRANS.TRANS_DATE >= :XFER_SCH_DATE_FROM");
                    db.DbPsetInt("XFER_SCH_DATE_FROM", _xfer_sch_date_from);
                }
                if (_xfer_sch_date_to != 0)
                {
                    strSQL.Append(" AND RCV_DISB_TRANS.TRANS_DATE <= :XFER_SCH_DATE_TO");
                    db.DbPsetInt("XFER_SCH_DATE_TO", _xfer_sch_date_to);
                }
                if (_lot_no != "")
                {
                    strSQL.Append(" AND RCV_DISB_TRANS.FROM_LOT_NO = :FROM_LOT_NO");
                    db.DbPsetString("FROM_LOT_NO", _lot_no);
                }
                if (_supply_type != 0)
                {
                    strSQL.Append(" AND TRANSFER_TRANS.TO_SUPPLY_TYPE = :TO_SUPPLY_TYPE");
                    db.DbPsetInt("TO_SUPPLY_TYPE", _supply_type);
                }
                strSQL.Append(" AND ISNULL(RCV_DISB_TRANS.QTY,0)<>0 ");
            }
            else
            {
                strSQL.Append(" FROM TRANSFER_TRANS                                                                 ");
                strSQL.Append(" LEFT OUTER JOIN RCV_DISB_TRANS ON TRANSFER_TRANS.XFER_NO=RCV_DISB_TRANS.XFER_NO     ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER ON RCV_DISB_TRANS.ITEM_NO=ITEM_MASTER.ITEM_NO           ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER ON RCV_DISB_TRANS.TO_VC_CD=VENDOR_MASTER.VENDOR_CD    ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_ITEM_UMSR ON S_ITEM_UMSR.KEY01 = 'ITEM_UMSR'     ");
                strSQL.Append(" AND S_ITEM_UMSR.KEY02 = RCV_DISB_TRANS.ITEM_UMSR                                    ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_SUPPLY_CUR ON S_SUPPLY_CUR.KEY01='CURRENCY_CD'   ");
                strSQL.Append(" AND S_SUPPLY_CUR.KEY02=TRANSFER_TRANS.TO_CUR                                        ");

                db.DbParametersClear();
                strSQL.Append(" WHERE TRANSFER_TRANS.REQ_TYPE='24'  ");
                strSQL.Append(" AND RCV_DISB_TRANS.REQ_TYPE='24'    ");      //Add 10.06.01 Ubiq-sai
                strSQL.Append(" AND TRANSFER_TRANS.XFER_STATUS<90   ");
                if (_buyer_cd != "")
                {
                    strSQL.Append(" AND TRANSFER_TRANS.BUYER_CD = @BUYER_CD    ");
                    db.DbPsetString("@BUYER_CD", _buyer_cd);
                }
                if (_sch_id != "")
                {
                    strSQL.Append(" AND TRANSFER_TRANS.SCH_ID = @SCH_ID");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append(" AND TRANSFER_TRANS.TO_VC_CD = @TO_VC_CD");
                    db.DbPsetString("@TO_VC_CD", _vendor_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND TRANSFER_TRANS.ITEM_NO = @ITEM_NO");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_catg_cd != "")
                {
                    strSQL.Append(" AND ITEM_MASTER.CATG_CD = @CATG_CD");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append(" AND RCV_DISB_TRANS.FROM_JOC_CD = @FROM_JOC_CD");
                    db.DbPsetString("@FROM_JOC_CD", _joc_cd);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND RCV_DISB_TRANS.FROM_WHS_CD = @FROM_WHS_CD");
                    db.DbPsetString("@FROM_WHS_CD", _whs_cd);
                }
                if (_xfer_sch_date_from != 0)
                {
                    strSQL.Append(" AND RCV_DISB_TRANS.TRANS_DATE >= @XFER_SCH_DATE_FROM");
                    db.DbPsetInt("@XFER_SCH_DATE_FROM", _xfer_sch_date_from);
                }
                if (_xfer_sch_date_to != 0)
                {
                    strSQL.Append(" AND RCV_DISB_TRANS.TRANS_DATE <= @XFER_SCH_DATE_TO");
                    db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
                }
                if (_lot_no != "")
                {
                    strSQL.Append(" AND RCV_DISB_TRANS.FROM_LOT_NO = @FROM_LOT_NO");
                    db.DbPsetString("@FROM_LOT_NO", _lot_no);
                }
                if (_supply_type != 0)
                {
                    strSQL.Append(" AND TRANSFER_TRANS.TO_SUPPLY_TYPE = @TO_SUPPLY_TYPE");
                    db.DbPsetInt("@TO_SUPPLY_TYPE", _supply_type);
                }
                strSQL.Append(" AND ISNULL(RCV_DISB_TRANS.QTY,0)<>0 ");
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

        /* Del 10.10.19 Ubiq-Sai Start */
        /////<summary>
        /////振替依頼データ（返品）を検索
        /////
        /////<para>使用画面：PurActInq</para>
        /////</summary>
        //public DataSet Get_Pur_ReturnActList()
        //{
        //    ComDB db = new ComDB(_db_type);
        //    StringBuilder strSQL = new StringBuilder();
        //    DataSet ds = new DataSet();

        //    strSQL.Append(" SELECT                                                                                      ");
        //    strSQL.Append(" TRANSFER_TRANS.TRANS_DATE,          TRANSFER_TRANS.TO_VC_CD VENDOR_CD,                      ");
        //    strSQL.Append(" VENDOR_MASTER.VENDOR_NAME,          TRANSFER_TRANS.ITEM_NO,                                 ");
        //    strSQL.Append(" TRANSFER_TRANS.ITEM_DESC,           TRANSFER_TRANS.XFER_NO,                                 ");
        //    strSQL.Append(" TRANSFER_TRANS.REJ_QTY_PUR_UMSR,    S_PUR_UMSR.DATA_CHAR PUR_UMSR,                          ");
        //    strSQL.Append(" TRANSFER_TRANS.ACT_PRC,             TRANSFER_TRANS.ACT_AMT,                                 ");
        //    strSQL.Append(" S_FROM_CUR.DATA_CHAR FROM_CUR,      TRANSFER_TRANS.TO_JOC_CD,                               ");
        //    strSQL.Append(" TRANSFER_TRANS.FROM_WHS_CD,         TRANSFER_TRANS.FROM_LOT_NO,                             ");
        //    strSQL.Append(" TRANSFER_TRANS.PO_NO,               TRANSFER_TRANS.PO_LINE_NO,                              ");
        //    strSQL.Append(" PUR_ORDER.PO_QTY,                   PUR_ORDER.RECV_QTY,     PUR_ORDER.ACCEPT_QTY,           ");
        //    strSQL.Append(" S_PO_UMSR.DATA_CHAR PO_UMSR                                                                 ");
        //    if (_db_type == "ORACLE")
        //    {
        //        strSQL.Append(" FROM TRANSFER_TRANS                                                                 ");
        //        strSQL.Append(" LEFT OUTER JOIN PUR_ORDER ON TRANSFER_TRANS.PO_NO=PUR_ORDER.PO_NO                   ");
        //        strSQL.Append(" AND TRANSFER_TRANS.PO_LINE_NO=PUR_ORDER.PO_LINE_NO                                  ");
        //        strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER ON TRANSFER_TRANS.ITEM_NO=ITEM_MASTER.ITEM_NO           ");
        //        strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER ON TRANSFER_TRANS.TO_VC_CD=VENDOR_MASTER.VENDOR_CD    ");
        //        strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PUR_UMSR ON S_PUR_UMSR.KEY01 = 'ITEM_UMSR'       ");
        //        strSQL.Append(" AND S_PUR_UMSR.KEY02 = TRANSFER_TRANS.PUR_UMSR                                      ");
        //        strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_FROM_CUR ON S_FROM_CUR.KEY01='CURRENCY_CD'       ");
        //        strSQL.Append(" AND S_FROM_CUR.KEY02=TRANSFER_TRANS.FROM_CUR                                        ");
        //        strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PO_UMSR ON S_PO_UMSR.KEY01 = 'ITEM_UMSR'         ");
        //        strSQL.Append(" AND S_PO_UMSR.KEY02 = PUR_ORDER.PO_UMSR                                             ");

        //        db.DbParametersClear();
        //        strSQL.Append(" WHERE TRANSFER_TRANS.REQ_TYPE='25'  ");
        //        strSQL.Append(" AND TRANSFER_TRANS.XFER_STATUS<90   ");
        //        if (_buyer_cd != "")
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.BUYER_CD = @BUYER_CD    ");
        //            db.DbPsetString("@BUYER_CD", _buyer_cd);
        //        }
        //        if (_sch_id != "")
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.SCH_ID = @SCH_ID");
        //            db.DbPsetString("@SCH_ID", _sch_id);
        //        }
        //        if (_vendor_cd != "")
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.TO_VC_CD = @TO_VC_CD");
        //            db.DbPsetString("@TO_VC_CD", _vendor_cd);
        //        }
        //        if (_item_no != "")
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.ITEM_NO = @ITEM_NO");
        //            db.DbPsetString("@ITEM_NO", _item_no);
        //        }
        //        if (_catg_cd != "")
        //        {
        //            strSQL.Append(" AND ITEM_MASTER.CATG_CD = @CATG_CD");
        //            db.DbPsetString("@CATG_CD", _catg_cd);
        //        }
        //        if (_joc_cd != "")
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.TO_JOC_CD = @TO_JOC_CD");
        //            db.DbPsetString("@TO_JOC_CD", _joc_cd);
        //        }
        //        if (_whs_cd != "")
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.FROM_WHS_CD = @FROM_WHS_CD");
        //            db.DbPsetString("@FROM_WHS_CD", _whs_cd);
        //        }
        //        if (_xfer_sch_date_from != 0)
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.TRANS_DATE >= @XFER_SCH_DATE_FROM");
        //            db.DbPsetInt("@XFER_SCH_DATE_FROM", _xfer_sch_date_from);
        //        }
        //        if (_xfer_sch_date_to != 0)
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.TRANS_DATE <= @XFER_SCH_DATE_TO");
        //            db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
        //        }
        //        if (_po_no != "")
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.PO_NO = @PO_NO");
        //            db.DbPsetString("@PO_NO", _po_no);
        //        }
        //        if (_lot_no != "")
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.FROM_LOT_NO = @FROM_LOT_NO");
        //            db.DbPsetString("@FROM_LOT_NO", _lot_no);
        //        }
        //    }
        //    else
        //    {
        //        strSQL.Append(" FROM TRANSFER_TRANS                                                                 ");
        //        strSQL.Append(" LEFT OUTER JOIN PUR_ORDER ON TRANSFER_TRANS.PO_NO=PUR_ORDER.PO_NO                   ");
        //        strSQL.Append(" AND TRANSFER_TRANS.PO_LINE_NO=PUR_ORDER.PO_LINE_NO                                  ");
        //        strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER ON TRANSFER_TRANS.ITEM_NO=ITEM_MASTER.ITEM_NO           ");
        //        strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER ON TRANSFER_TRANS.TO_VC_CD=VENDOR_MASTER.VENDOR_CD    ");
        //        strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PUR_UMSR ON S_PUR_UMSR.KEY01 = 'ITEM_UMSR'       ");
        //        strSQL.Append(" AND S_PUR_UMSR.KEY02 = TRANSFER_TRANS.PUR_UMSR                                      ");
        //        strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_FROM_CUR ON S_FROM_CUR.KEY01='CURRENCY_CD'       ");
        //        strSQL.Append(" AND S_FROM_CUR.KEY02=TRANSFER_TRANS.FROM_CUR                                        ");
        //        strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PO_UMSR ON S_PO_UMSR.KEY01 = 'ITEM_UMSR'         ");
        //        strSQL.Append(" AND S_PO_UMSR.KEY02 = PUR_ORDER.PO_UMSR                                             ");

        //        db.DbParametersClear();
        //        strSQL.Append(" WHERE TRANSFER_TRANS.REQ_TYPE='25'  ");
        //        strSQL.Append(" AND TRANSFER_TRANS.XFER_STATUS<90   ");
        //        if (_buyer_cd != "")
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.BUYER_CD = @BUYER_CD    ");
        //            db.DbPsetString("@BUYER_CD", _buyer_cd);
        //        }
        //        if (_sch_id != "")
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.SCH_ID = @SCH_ID");
        //            db.DbPsetString("@SCH_ID", _sch_id);
        //        }
        //        if (_vendor_cd != "")
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.TO_VC_CD = @TO_VC_CD");
        //            db.DbPsetString("@TO_VC_CD", _vendor_cd);
        //        }
        //        if (_item_no != "")
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.ITEM_NO = @ITEM_NO");
        //            db.DbPsetString("@ITEM_NO", _item_no);
        //        }
        //        if (_catg_cd != "")
        //        {
        //            strSQL.Append(" AND ITEM_MASTER.CATG_CD = @CATG_CD");
        //            db.DbPsetString("@CATG_CD", _catg_cd);
        //        }
        //        if (_joc_cd != "")
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.TO_JOC_CD = @TO_JOC_CD");
        //            db.DbPsetString("@TO_JOC_CD", _joc_cd);
        //        }
        //        if (_whs_cd != "")
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.FROM_WHS_CD = @FROM_WHS_CD");
        //            db.DbPsetString("@FROM_WHS_CD", _whs_cd);
        //        }
        //        if (_xfer_sch_date_from != 0)
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.TRANS_DATE >= @XFER_SCH_DATE_FROM");
        //            db.DbPsetInt("@XFER_SCH_DATE_FROM", _xfer_sch_date_from);
        //        }
        //        if (_xfer_sch_date_to != 0)
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.TRANS_DATE <= @XFER_SCH_DATE_TO");
        //            db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
        //        }
        //        if (_po_no != "")
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.PO_NO = @PO_NO");
        //            db.DbPsetString("@PO_NO", _po_no);
        //        }
        //        if (_lot_no != "")
        //        {
        //            strSQL.Append(" AND TRANSFER_TRANS.FROM_LOT_NO = @FROM_LOT_NO");
        //            db.DbPsetString("@FROM_LOT_NO", _lot_no);
        //        }
        //    }
        //    try
        //    {
        //        ds = db.DbDataSet(strSQL.ToString(), "TABLE");
        //        if (ds == null)
        //        {
        //            _dbmsg = db.expmsg;
        //            _strErr = db.strErr;
        //        }
        //        if (db.State() == ConnectionState.Open)
        //            db.DbClose();
        //        return ds;
        //    }
        //    catch
        //    {
        //        _dbmsg = db.expmsg;
        //        _strErr = db.strErr;
        //        if (db.State() == ConnectionState.Open)
        //            db.DbClose();
        //        return null;
        //    }
        //}
        /* Del 10.10.19 Ubiq-Sai End */

        /* Add 10.10.19 Ubiq-Sai Start */
        ///<summary>
        ///振替依頼データ（返品）を検索
        ///
        ///<para>使用画面：PurActInq</para>
        ///</summary>
        public DataSet Get_Pur_ReturnActList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

			strSQL.Append(" SELECT TOP 2001                                                                         ");
            strSQL.Append(" AP_TRANS.SLIP_DATE TRANS_DATE,  AP_TRANS.TO_VC_CD VENDOR_CD,                            ");
            strSQL.Append(" VENDOR_MASTER.VENDOR_NAME,      AP_TRANS.ITEM_NO,                                       ");
            strSQL.Append(" AP_TRANS.ITEM_DESC,             AP_TRANS.SLIP_NO AS XFER_NO,                            ");
            strSQL.Append(" AP_TRANS.QTY REJ_QTY_PUR_UMSR,  S_PUR_UMSR.DATA_CHAR PUR_UMSR,                          ");
            strSQL.Append(" AP_TRANS.ACT_PRC,               AP_TRANS.ACT_AMT,                                       ");
            strSQL.Append(" S_PO_CUR.DATA_CHAR FROM_CUR,    AP_TRANS.TO_JOC_CD,                                     ");
            strSQL.Append(" AP_TRANS.FROM_WHS_CD,           AP_TRANS.FROM_LOT_NO,                                   ");
            strSQL.Append(" AP_TRANS.PO_NO,                 AP_TRANS.PO_LINE_NO,                                    ");
            strSQL.Append(" PUR_ORDER.PO_QTY,               PUR_ORDER.RECV_QTY,     PUR_ORDER.ACCEPT_QTY,           ");
            strSQL.Append(" S_PO_UMSR.DATA_CHAR PO_UMSR                                                             ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM AP_TRANS                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN PUR_ORDER ON AP_TRANS.PO_NO=PUR_ORDER.PO_NO                     ");
                strSQL.Append(" AND AP_TRANS.PO_LINE_NO=PUR_ORDER.PO_LINE_NO                                    ");

                strSQL.Append(" INNER JOIN TRANSFER_TRANS ON AP_TRANS.SLIP_NO=TRANSFER_TRANS.XFER_NO            ");
                strSQL.Append(" AND TRANSFER_TRANS.REQ_TYPE='25'                                                ");

                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER ON AP_TRANS.ITEM_NO=ITEM_MASTER.ITEM_NO             ");

                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER ON AP_TRANS.TO_VC_CD=VENDOR_MASTER.VENDOR_CD      ");

                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PUR_UMSR ON S_PUR_UMSR.KEY01 = 'ITEM_UMSR'   ");
                strSQL.Append(" AND S_PUR_UMSR.KEY02 = TRANSFER_TRANS.PUR_UMSR                                  ");

                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PO_CUR ON S_PO_CUR.KEY01='CURRENCY_CD'       ");
                strSQL.Append(" AND S_PO_CUR.KEY02=AP_TRANS.PO_CUR                                              ");

                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PO_UMSR ON S_PO_UMSR.KEY01 = 'ITEM_UMSR'         ");
                strSQL.Append(" AND S_PO_UMSR.KEY02 = PUR_ORDER.PO_UMSR                                             ");

                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON AP_TRANS.FROM_WHS_CD = W.WHS_CD           ");

                db.DbParametersClear();
                strSQL.Append(" WHERE 1=1                                 ");
                if (_buyer_cd != "")
                {
                    strSQL.Append(" AND PUR_ORDER.BUYER_CD = :BUYER_CD    ");
                    db.DbPsetString("BUYER_CD", _buyer_cd);
                }
                if (_sch_id != "")
                {
                    strSQL.Append(" AND PUR_ORDER.SCH_ID = :SCH_ID");
                    db.DbPsetString("SCH_ID", _sch_id);
                }
                if (_catg_cd != "")
                {
                    strSQL.Append(" AND ITEM.CATG_CD = :CATG_CD");
                    db.DbPsetString("CATG_CD", _catg_cd);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append(" AND AP_TRANS.TO_VC_CD = :TO_VC_CD");
                    db.DbPsetString("TO_VC_CD", _vendor_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND AP_TRANS.ITEM_NO = :ITEM_NO");
                    db.DbPsetString("ITEM_NO", _item_no);
                }

                if (_joc_cd != "")
                {
                    strSQL.Append(" AND AP_TRANS.TO_JOC_CD = :TO_JOC_CD");
                    db.DbPsetString("TO_JOC_CD", _joc_cd);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND AP_TRANS.FROM_WHS_CD = :FROM_WHS_CD");
                    db.DbPsetString("FROM_WHS_CD", _whs_cd);
                }
                if (_xfer_sch_date_from != 0)
                {
                    strSQL.Append(" AND AP_TRANS.SLIP_DATE >= :XFER_SCH_DATE_FROM");
                    db.DbPsetInt("XFER_SCH_DATE_FROM", _xfer_sch_date_from);
                }
                if (_xfer_sch_date_to != 0)
                {
                    strSQL.Append(" AND AP_TRANS.SLIP_DATE <= :XFER_SCH_DATE_TO");
                    db.DbPsetInt("XFER_SCH_DATE_TO", _xfer_sch_date_to);
                }
                if (_po_no != "")
                {
                    strSQL.Append(" AND AP_TRANS.PO_NO = :PO_NO");
                    db.DbPsetString("PO_NO", _po_no);
                }
                if (_lot_no != "")
                {
                    strSQL.Append(" AND AP_TRANS.FROM_LOT_NO = :FROM_LOT_NO");
                    db.DbPsetString("FROM_LOT_NO", _lot_no);
                }
                strSQL.Append(" ORDER BY AP_TRANS.SLIP_DATE DESC,AP_TRANS.TO_VC_CD ASC,AP_TRANS.ITEM_NO ASC   ");
            }
            else
            {
                strSQL.Append(" FROM AP_TRANS                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN PUR_ORDER ON AP_TRANS.PO_NO=PUR_ORDER.PO_NO                     ");
                strSQL.Append(" AND AP_TRANS.PO_LINE_NO=PUR_ORDER.PO_LINE_NO                                    ");

                strSQL.Append(" INNER JOIN TRANSFER_TRANS ON AP_TRANS.SLIP_NO=TRANSFER_TRANS.XFER_NO            ");
                strSQL.Append(" AND TRANSFER_TRANS.REQ_TYPE='25'                                                ");

                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER ON AP_TRANS.ITEM_NO=ITEM_MASTER.ITEM_NO             ");

                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER ON AP_TRANS.TO_VC_CD=VENDOR_MASTER.VENDOR_CD      ");

                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PUR_UMSR ON S_PUR_UMSR.KEY01 = 'ITEM_UMSR'   ");
                strSQL.Append(" AND S_PUR_UMSR.KEY02 = TRANSFER_TRANS.PUR_UMSR                                  ");

                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PO_CUR ON S_PO_CUR.KEY01='CURRENCY_CD'       ");
                strSQL.Append(" AND S_PO_CUR.KEY02=AP_TRANS.PO_CUR                                              ");

                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S_PO_UMSR ON S_PO_UMSR.KEY01 = 'ITEM_UMSR'         ");
                strSQL.Append(" AND S_PO_UMSR.KEY02 = PUR_ORDER.PO_UMSR                                             ");

                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON AP_TRANS.FROM_WHS_CD = W.WHS_CD           ");

                db.DbParametersClear();
                strSQL.Append(" WHERE 1=1                                 ");
                if (_buyer_cd != "")
                {
                    strSQL.Append(" AND PUR_ORDER.BUYER_CD = @BUYER_CD    ");
                    db.DbPsetString("@BUYER_CD", _buyer_cd);
                }
                if (_sch_id != "")
                {
                    strSQL.Append(" AND PUR_ORDER.SCH_ID = @SCH_ID");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (_catg_cd != "")
                {
                    strSQL.Append(" AND ITEM_MASTER.CATG_CD = @CATG_CD");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append(" AND AP_TRANS.TO_VC_CD = @TO_VC_CD");
                    db.DbPsetString("@TO_VC_CD", _vendor_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND AP_TRANS.ITEM_NO = @ITEM_NO");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }

                if (_joc_cd != "")
                {
                    strSQL.Append(" AND AP_TRANS.TO_JOC_CD = @TO_JOC_CD");
                    db.DbPsetString("@TO_JOC_CD", _joc_cd);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND AP_TRANS.FROM_WHS_CD = @FROM_WHS_CD");
                    db.DbPsetString("@FROM_WHS_CD", _whs_cd);
                }
                if (_xfer_sch_date_from != 0)
                {
                    strSQL.Append(" AND AP_TRANS.SLIP_DATE >= @XFER_SCH_DATE_FROM");
                    db.DbPsetInt("@XFER_SCH_DATE_FROM", _xfer_sch_date_from);
                }
                if (_xfer_sch_date_to != 0)
                {
                    strSQL.Append(" AND AP_TRANS.SLIP_DATE <= @XFER_SCH_DATE_TO");
                    db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
                }
                if (_po_no != "")
                {
                    //strSQL.Append(" AND AP_TRANS.PO_NO = @PO_NO");
                    strSQL.Append("   AND (AP_TRANS.PO_NO = @PO_NO OR TRANSFER_TRANS.SLIP_NO = @PO_NO) "); // 2015.03.03

                    db.DbPsetString("@PO_NO", _po_no);
                }
                if (_lot_no != "")
                {
                    strSQL.Append(" AND AP_TRANS.FROM_LOT_NO = @FROM_LOT_NO");
                    db.DbPsetString("@FROM_LOT_NO", _lot_no);
                }
                strSQL.Append(" ORDER BY AP_TRANS.SLIP_DATE DESC,AP_TRANS.TO_VC_CD ASC,AP_TRANS.ITEM_NO ASC   ");

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
        /* Add 10.10.19 Ubiq-Sai End */

        ///<summary>
        ///検収実績データ検索
        ///<para>使用画面：[PurInspPriceChg]</para>
        ///</summary>
        public DataSet Get_Pur_Ap_TransPriceList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            strSQL.Append(" SELECT                                                                                      ");
            strSQL.Append(" AT.SLIP_DATE,           AT.FROM_VC_CD,          VM.VENDOR_NAME,         AT.ITEM_NO,         ");
            strSQL.Append(" AT.ITEM_DESC,           AT.PO_NO+RIGHT(CAST(AT.PO_LINE_NO+1000 AS VARCHAR),3) PO_NO,        ");
            strSQL.Append(" AT.QTY,                 S1.DATA_CHAR PUR_UMSR,  AT.ACT_PRC ACT_PRC_NEW, AT.ACT_AMT,         ");
            strSQL.Append(" S2.DATA_CHAR PO_CUR,    AT.PARTIAL_DELV_CNT,    AT.TO_JOC_CD,           AT.TO_WHS_CD,       ");
            strSQL.Append(" AT.TO_LOT_NO,           AT.SLIP_NO,             AT.ACT_PRC,             AT.FLAG             ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM (SELECT 1 FLAG,    A.*                                                             ");
                strSQL.Append("       FROM AP_TRANS A                                                                   ");
                strSQL.Append("       INNER JOIN (SELECT M1.*                                                           ");
                strSQL.Append("                   FROM (SELECT SUBSTRING(SLIP_NO,1,16) SUB_SLIP_NO,MAX(SLIP_NO) MAX_SLIP_NO ");
                strSQL.Append("                         FROM AP_TRANS                                                   ");
                strSQL.Append("                         GROUP BY SUBSTRING(SLIP_NO,1,16) ) M1                           ");
                strSQL.Append("                   WHERE SUBSTRING(M1.MAX_SLIP_NO,18,1) <> '2'                           ");
                strSQL.Append("                  ) M ON A.SLIP_NO = M.MAX_SLIP_NO                                       ");
                strSQL.Append("       UNION ALL                                                                         ");
                strSQL.Append("       SELECT 0 FLAG,    A.*                                                             ");
                strSQL.Append("       FROM AP_TRANS A                                                                   ");
                strSQL.Append("       INNER JOIN (SELECT M1.*                                                           ");
                strSQL.Append("                   FROM (SELECT SUBSTRING(SLIP_NO,1,16) SUB_SLIP_NO,MAX(SLIP_NO) MAX_SLIP_NO ");
                strSQL.Append("                         FROM AP_TRANS                                                   ");
                strSQL.Append("                         GROUP BY SUBSTRING(SLIP_NO,1,16) ) M1                           ");
                strSQL.Append("                   WHERE SUBSTRING(M1.MAX_SLIP_NO,18,1) <> '2'                           ");
                strSQL.Append("                  ) M ON  M.SUB_SLIP_NO = SUBSTRING(A.SLIP_NO,1,16)                      ");
                strSQL.Append("             AND A.SLIP_NO <> M.MAX_SLIP_NO                                               ");
                strSQL.Append("      ) AT                                                                               ");
                strSQL.Append(" LEFT OUTER JOIN PUR_ORDER PO ON AT.PO_NO    =   PO.PO_NO                                ");
                strSQL.Append("         AND AT.PO_LINE_NO   =   PO.PO_LINE_NO                                           ");
				//strSQL.Append(" INNER JOIN TRANSFER_TRANS TT ON TT.XFER_NO    =   AT.FROM_MNG_NO                        ");//DEL BY UBIQ-LIU 2010/11/01
				//strSQL.Append("         AND TT.REQ_TYPE     =   '11'                                                    ");//（購入品：計画入庫）
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER VM ON AT.FROM_VC_CD   =   VM.VENDOR_CD                    ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON    AT.ITEM_NO      =   I.ITEM_NO                       ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01     =   'ITEM_UMSR'                     ");
				strSQL.Append("         AND S1.KEY02    =   PO.PUR_UMSR                                                 ");//UPD UBIQ-LIU 2010/11/01 [TT.PUR_UMSR] to [PO.PUR_UMSR]
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01     =   'CURRENCY_CD'                   ");
                strSQL.Append("         AND S2.KEY02    =   AT.PO_CUR                                                   ");

                strSQL.Append(" WHERE 1=1  ");
                if (_buyer_cd != "")
                {
                    strSQL.Append(" AND PO.BUYER_CD = :BUYER_CD     ");
                    db.DbPsetString("BUYER_CD", _buyer_cd);
                }
                if (_sch_id != "")
                {
                    strSQL.Append(" AND PO.SCH_ID = :SCH_ID         ");
                    db.DbPsetString("SCH_ID", _sch_id);
                }
                if (_catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD = :CATG_CD        ");
                    db.DbPsetString("CATG_CD", _catg_cd);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append(" AND AT.FROM_VC_CD = :FROM_VC_CD");
                    db.DbPsetString("FROM_VC_CD", _vendor_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND AT.ITEM_NO  = :ITEM_NO");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append(" AND AT.TO_JOC_CD = :TO_JOC_CD");
                    db.DbPsetString("TO_JOC_CD", _joc_cd);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND AT.TO_WHS_CD = :TO_WHS_CD");
                    db.DbPsetString("TO_WHS_CD", _whs_cd);
                }
                if (_xfer_sch_date_from != 0)
                {
                    strSQL.Append(" AND AT.SLIP_DATE >= :SLIP_DATE_FROM");
                    db.DbPsetInt("SLIP_DATE_FROM", _xfer_sch_date_from);
                }
                if (_xfer_sch_date_to != 0)
                {
                    strSQL.Append(" AND AT.SLIP_DATE <= :SLIP_DATE_TO");
                    db.DbPsetInt("SLIP_DATE_TO", _xfer_sch_date_to);
                }
                if (_po_no != "")
                {
                    strSQL.Append(" AND AT.PO_NO = :PO_NO");
                    db.DbPsetString("PO_NO", _po_no);
                }
                if (_lot_no != "")
                {
                    strSQL.Append(" AND AT.TO_LOT_NO = :TO_LOT_NO");
                    db.DbPsetString("TO_LOT_NO", _lot_no);
                }
                if (_flag == 1)
                {
                    strSQL.Append(" AND AT.FLAG = :FLAG");
                    db.DbPsetInt("FLAG", _flag);
                }
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM (SELECT 1 FLAG,    A.*                                                             ");
                strSQL.Append("       FROM AP_TRANS A                                                                   ");
                strSQL.Append("       INNER JOIN (SELECT M1.*                                                           ");
                strSQL.Append("                   FROM (SELECT SUBSTRING(SLIP_NO,1,16) SUB_SLIP_NO,MAX(SLIP_NO) MAX_SLIP_NO ");
                strSQL.Append("                         FROM AP_TRANS                                                   ");
                strSQL.Append("                         GROUP BY SUBSTRING(SLIP_NO,1,16) ) M1                           ");
                strSQL.Append("                   WHERE SUBSTRING(M1.MAX_SLIP_NO,18,1) <> '2'                           ");
                strSQL.Append("                  ) M ON A.SLIP_NO = M.MAX_SLIP_NO                                      ");
                strSQL.Append("       UNION ALL                                                                         ");
                strSQL.Append("       SELECT 0 FLAG,    A.*                                                             ");
                strSQL.Append("       FROM AP_TRANS A                                                                   ");
                strSQL.Append("       INNER JOIN (SELECT M1.*                                                           ");
                strSQL.Append("                   FROM (SELECT SUBSTRING(SLIP_NO,1,16) SUB_SLIP_NO,MAX(SLIP_NO) MAX_SLIP_NO ");
                strSQL.Append("                         FROM AP_TRANS                                                   ");
                strSQL.Append("                         GROUP BY SUBSTRING(SLIP_NO,1,16) ) M1                           ");
                strSQL.Append("                   WHERE SUBSTRING(M1.MAX_SLIP_NO,18,1) <> '2'                           ");
                strSQL.Append("                  ) M ON  M.SUB_SLIP_NO = SUBSTRING(A.SLIP_NO,1,16)                      ");
                strSQL.Append("             AND A.SLIP_NO <> M.MAX_SLIP_NO                                               ");
                strSQL.Append("      ) AT                                                                               ");
                strSQL.Append(" LEFT OUTER JOIN PUR_ORDER PO ON AT.PO_NO    =   PO.PO_NO                                ");
                strSQL.Append("         AND AT.PO_LINE_NO   =   PO.PO_LINE_NO                                           ");
				//strSQL.Append(" INNER JOIN TRANSFER_TRANS TT ON TT.XFER_NO    =   AT.FROM_MNG_NO                        ");//DEL BY UBIQ-LIU 2010/11/01
				//strSQL.Append("         AND TT.REQ_TYPE     =   '11'                                                    ");//（購入品：計画入庫）
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER VM ON AT.FROM_VC_CD   =   VM.VENDOR_CD                    ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON    AT.ITEM_NO      =   I.ITEM_NO                       ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01     =   'ITEM_UMSR'                     ");
				strSQL.Append("         AND S1.KEY02    =   PO.PO_UMSR													");//UPD UBIQ-LIU 2010/11/01 [TT.PUR_UMSR] to [PO.PO_UMSR]
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01     =   'CURRENCY_CD'                   ");
                strSQL.Append("         AND S2.KEY02    =   AT.PO_CUR                                                   ");

                strSQL.Append(" WHERE 1=1  ");
                if (_buyer_cd != "")
                {
                    strSQL.Append(" AND PO.BUYER_CD = @BUYER_CD     ");
                    db.DbPsetString("@BUYER_CD", _buyer_cd);
                }
                if (_sch_id != "")
                {
                    strSQL.Append(" AND PO.SCH_ID = @SCH_ID         ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (_catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD = @CATG_CD        ");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append(" AND AT.FROM_VC_CD = @FROM_VC_CD");
                    db.DbPsetString("@FROM_VC_CD", _vendor_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND AT.ITEM_NO  = @ITEM_NO");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append(" AND AT.TO_JOC_CD = @TO_JOC_CD");
                    db.DbPsetString("@TO_JOC_CD", _joc_cd);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND AT.TO_WHS_CD = @TO_WHS_CD");
                    db.DbPsetString("@TO_WHS_CD", _whs_cd);
                }
                if (_xfer_sch_date_from != 0)
                {
                    strSQL.Append(" AND AT.SLIP_DATE >= @SLIP_DATE_FROM");
                    db.DbPsetInt("@SLIP_DATE_FROM", _xfer_sch_date_from);
                }
                if (_xfer_sch_date_to != 0)
                {
                    strSQL.Append(" AND AT.SLIP_DATE <= @SLIP_DATE_TO");
                    db.DbPsetInt("@SLIP_DATE_TO", _xfer_sch_date_to);
                }
                if (_po_no != "")
                {
                    //strSQL.Append(" AND AT.PO_NO = @PO_NO");
                    strSQL.Append("   AND (AT.PO_NO = @PO_NO OR AT.SLIP_NO = @PO_NO) "); // 2015.03.03

                    db.DbPsetString("@PO_NO", _po_no);
                }
                if (_lot_no != "")
                {
                    strSQL.Append(" AND AT.TO_LOT_NO = @TO_LOT_NO");
                    db.DbPsetString("@TO_LOT_NO", _lot_no);
                }
                if (_flag == 1)
                {
                    strSQL.Append(" AND AT.FLAG = @FLAG");
                    db.DbPsetInt("@FLAG", _flag);
                }
            }
            strSQL.Append(" ORDER BY AT.FROM_VC_CD ASC,     AT.ITEM_NO,     AT.SLIP_NO ASC    ");
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
        /// 検収単価更新
        ///
        /// <para>使用画面：[PurInspPriceChg]</para>
        /// </summary>
        public int Pur_Insp_PriceChg()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_SLIP_NO", _po_no, ComConst.DB_IN);
            db.DbPsetDouble("@I_ACT_PRC", _po_prc, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);
            db.DbBeginTrans();

            rtn = db.DbStored("SP_PUR_INSP_PRICE_CHG");
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
		/// 振替依頼データ（受入）を検索して表示する
		/// <para>使用画面：[PurActInq]</para>
		/// </summary>
		public DataSet Get_Pur_RcvNoInspList()
		{
			ComDB db = new ComDB(_db_type);
			StringBuilder strSQL = new StringBuilder();
			DataSet ds = new DataSet();

            //2015.08.24
            strSQL.Append(" SELECT TOP 2001                                                                             ");
            strSQL.Append(" TT.XFER_SCH_DATE,       TT.FROM_VC_CD,          VM.VENDOR_NAME,         TT.ITEM_NO,         ");
            strSQL.Append(" TT.ITEM_DESC,           TT.PO_NO+RIGHT(CAST(TT.PO_LINE_NO+1000 AS VARCHAR),3) PO_NO,        ");
            strSQL.Append(" PO.PO_QTY,              SUM(TT.RECV_QTY_PUR_UMSR) RECV_QTY_PUR_UMSR,	SUM(TT.QTY_PUR_UMSR) QTY_PUR_UMSR,		SUM(TT.REJ_QTY_PUR_UMSR) REJ_QTY_PUR_UMSR,");
            strSQL.Append(" S1.DATA_CHAR UMSR_NAME, MIN(TT.PARTIAL_DELV_COMPL_CNT) PARTIAL_DELV_COMPL_CNT,    TT.TO_JOC_CD,     TT.TO_WHS_CD,       ");
            strSQL.Append(" TT.TO_LOT_NO																				");
            db.DbParametersClear();
            strSQL.Append(" FROM TRANSFER_TRANS TT                                                  ");
            strSQL.Append(" LEFT OUTER JOIN PUR_ORDER PO ON TT.PO_NO    =   PO.PO_NO                ");
            strSQL.Append("         AND TT.PO_LINE_NO   =   PO.PO_LINE_NO                           ");
            strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER VM ON TT.FROM_VC_CD   =   VM.VENDOR_CD    ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON    TT.ITEM_NO      =   I.ITEM_NO       ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01     =   'ITEM_UMSR'     ");
            strSQL.Append("         AND S1.KEY02    =   TT.PUR_UMSR									");
            strSQL.Append(" WHERE TT.REQ_TYPE		='01'											");
            strSQL.Append("   AND TT.XFER_STATUS	< 20											");
            if (_buyer_cd != "")
            {
                strSQL.Append(" AND TT.BUYER_CD = @BUYER_CD     ");
                db.DbPsetString("@BUYER_CD", _buyer_cd);
            }
            if (_sch_id != "")
            {
                strSQL.Append(" AND TT.SCH_ID = @SCH_ID         ");
                db.DbPsetString("@SCH_ID", _sch_id);
            }
            if (_catg_cd != "")
            {
                strSQL.Append(" AND I.CATG_CD = @CATG_CD        ");
                db.DbPsetString("@CATG_CD", _catg_cd);
            }
            if (_vendor_cd != "")
            {
                strSQL.Append(" AND TT.FROM_VC_CD = @FROM_VC_CD");
                db.DbPsetString("@FROM_VC_CD", _vendor_cd);
            }
            if (_item_no != "")
            {
                strSQL.Append(" AND TT.ITEM_NO  = @ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_joc_cd != "")
            {
                strSQL.Append(" AND TT.TO_JOC_CD = @TO_JOC_CD");
                db.DbPsetString("@TO_JOC_CD", _joc_cd);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND TT.TO_WHS_CD = @TO_WHS_CD");
                db.DbPsetString("@TO_WHS_CD", _whs_cd);
            }
            if (_xfer_sch_date_from != 0)
            {
                strSQL.Append(" AND TT.XFER_SCH_DATE >= @XFER_SCH_DATE_FROM");
                db.DbPsetInt("@XFER_SCH_DATE_FROM", _xfer_sch_date_from);
            }
            if (_xfer_sch_date_to != 0)
            {
                strSQL.Append(" AND TT.XFER_SCH_DATE <= @XFER_SCH_DATE_TO");
                db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
            }
            if (_po_no != "")
            {
                //strSQL.Append(" AND TT.PO_NO = @PO_NO");
                strSQL.Append("   AND (TT.PO_NO = @PO_NO OR TT.SLIP_NO = @PO_NO) "); // 2015.03.03

                db.DbPsetString("@PO_NO", _po_no);
            }
            if (_lot_no != "")
            {
                strSQL.Append(" AND TT.TO_LOT_NO = @TO_LOT_NO");
                db.DbPsetString("@TO_LOT_NO", _lot_no);
            }
            strSQL.Append(" GROUP BY ");
            strSQL.Append(" TT.XFER_SCH_DATE,       TT.FROM_VC_CD,          VM.VENDOR_NAME,         TT.ITEM_NO,         ");
            strSQL.Append(" TT.ITEM_DESC,           TT.PO_NO     ,          TT.PO_LINE_NO,        ");
            strSQL.Append(" PO.PO_QTY,              ");
            strSQL.Append(" S1.DATA_CHAR           , TT.TO_JOC_CD,     TT.TO_WHS_CD,       ");
            strSQL.Append(" TT.TO_LOT_NO																				");

            strSQL.Append(" ORDER BY TT.XFER_SCH_DATE DESC,		TT.FROM_VC_CD,     TT.ITEM_NO ASC    ");
            
            //2015.08.24DEL
            //strSQL.Append(" SELECT TOP 2001                                                                             ");
            //strSQL.Append(" TT.XFER_SCH_DATE,       TT.FROM_VC_CD,          VM.VENDOR_NAME,         TT.ITEM_NO,         ");
            //strSQL.Append(" TT.ITEM_DESC,           TT.PO_NO+RIGHT(CAST(TT.PO_LINE_NO+1000 AS VARCHAR),3) PO_NO,        ");
            //strSQL.Append(" PO.PO_QTY,              TT.RECV_QTY_PUR_UMSR,	TT.QTY_PUR_UMSR,		TT.REJ_QTY_PUR_UMSR,");
            //strSQL.Append(" S1.DATA_CHAR UMSR_NAME, TT.PARTIAL_DELV_COMPL_CNT,    TT.TO_JOC_CD,     TT.TO_WHS_CD,       ");
            //strSQL.Append(" TT.TO_LOT_NO																				");
            //db.DbParametersClear();
            //strSQL.Append(" FROM TRANSFER_TRANS TT                                                  ");
            //strSQL.Append(" LEFT OUTER JOIN PUR_ORDER PO ON TT.PO_NO    =   PO.PO_NO                ");
            //strSQL.Append("         AND TT.PO_LINE_NO   =   PO.PO_LINE_NO                           ");
            //strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER VM ON TT.FROM_VC_CD   =   VM.VENDOR_CD    ");
            //strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON    TT.ITEM_NO      =   I.ITEM_NO       ");
            //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01     =   'ITEM_UMSR'     ");
            //strSQL.Append("         AND S1.KEY02    =   TT.PUR_UMSR									");
            //strSQL.Append(" WHERE TT.REQ_TYPE		='01'											");
            //strSQL.Append("   AND TT.XFER_STATUS	< 20											");
            //if (_buyer_cd != "")
            //{
            //    strSQL.Append(" AND TT.BUYER_CD = @BUYER_CD     ");
            //    db.DbPsetString("@BUYER_CD", _buyer_cd);
            //}
            //if (_sch_id != "")
            //{
            //    strSQL.Append(" AND TT.SCH_ID = @SCH_ID         ");
            //    db.DbPsetString("@SCH_ID", _sch_id);
            //}
            //if (_catg_cd != "")
            //{
            //    strSQL.Append(" AND I.CATG_CD = @CATG_CD        ");
            //    db.DbPsetString("@CATG_CD", _catg_cd);
            //}
            //if (_vendor_cd != "")
            //{
            //    strSQL.Append(" AND TT.FROM_VC_CD = @FROM_VC_CD");
            //    db.DbPsetString("@FROM_VC_CD", _vendor_cd);
            //}
            //if (_item_no != "")
            //{
            //    strSQL.Append(" AND TT.ITEM_NO  = @ITEM_NO");
            //    db.DbPsetString("@ITEM_NO", _item_no);
            //}
            //if (_joc_cd != "")
            //{
            //    strSQL.Append(" AND TT.TO_JOC_CD = @TO_JOC_CD");
            //    db.DbPsetString("@TO_JOC_CD", _joc_cd);
            //}
            //if (_whs_cd != "")
            //{
            //    strSQL.Append(" AND TT.TO_WHS_CD = @TO_WHS_CD");
            //    db.DbPsetString("@TO_WHS_CD", _whs_cd);
            //}
            //if (_xfer_sch_date_from != 0)
            //{
            //    strSQL.Append(" AND TT.XFER_SCH_DATE >= @XFER_SCH_DATE_FROM");
            //    db.DbPsetInt("@XFER_SCH_DATE_FROM", _xfer_sch_date_from);
            //}
            //if (_xfer_sch_date_to != 0)
            //{
            //    strSQL.Append(" AND TT.XFER_SCH_DATE <= @XFER_SCH_DATE_TO");
            //    db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
            //}
            //if (_po_no != "")
            //{
            //    //strSQL.Append(" AND TT.PO_NO = @PO_NO");
            //    strSQL.Append("   AND (TT.PO_NO = @PO_NO OR TT.SLIP_NO = @PO_NO) "); // 2015.03.03

            //    db.DbPsetString("@PO_NO", _po_no);
            //}
            //if (_lot_no != "")
            //{
            //    strSQL.Append(" AND TT.TO_LOT_NO = @TO_LOT_NO");
            //    db.DbPsetString("@TO_LOT_NO", _lot_no);
            //}
			
            //strSQL.Append(" ORDER BY TT.XFER_SCH_DATE DESC,		TT.FROM_VC_CD,     TT.ITEM_NO ASC    ");
			
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
		/// 振替依頼データ（受入）を検索して表示する
		/// <para>使用画面：[PurRecSumm]</para>
		/// </summary>
		//public DataSet Get_Pur_RcvNoInspList2()
        //{
            //ComDB db = new ComDB(_db_type);
            //StringBuilder strSQL = new StringBuilder();
            //DataSet ds = new DataSet();

            ////2015.08.24
            //strSQL.Append(" SELECT TOP 2001                                                                             ");
            //strSQL.Append(" TT.XFER_SCH_DATE,       TT.FROM_VC_CD,          VM.VENDOR_NAME,         TT.ITEM_NO,         ");
            //strSQL.Append(" TT.ITEM_DESC,           TT.PO_NO+RIGHT(CAST(TT.PO_LINE_NO+1000 AS VARCHAR),3) PO_NO,        ");
            //strSQL.Append(" PO.PO_QTY,              SUM(TT.RECV_QTY_PUR_UMSR) RECV_QTY_PUR_UMSR,	SUM(TT.QTY_PUR_UMSR) QTY_PUR_UMSR,		SUM(TT.REJ_QTY_PUR_UMSR) REJ_QTY_PUR_UMSR,");
            //strSQL.Append(" S1.DATA_CHAR UMSR_NAME, MIN(TT.PARTIAL_DELV_COMPL_CNT) PARTIAL_DELV_COMPL_CNT,    TT.TO_JOC_CD,     TT.TO_WHS_CD,       ");
            //strSQL.Append(" TT.TO_LOT_NO																				");
            //db.DbParametersClear();
            //strSQL.Append(" FROM TRANSFER_TRANS TT                                                  ");
            //strSQL.Append(" LEFT OUTER JOIN PUR_ORDER PO ON TT.PO_NO    =   PO.PO_NO                ");
            //strSQL.Append("         AND TT.PO_LINE_NO   =   PO.PO_LINE_NO                           ");
            //strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER VM ON TT.FROM_VC_CD   =   VM.VENDOR_CD    ");
            //strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON    TT.ITEM_NO      =   I.ITEM_NO       ");
            //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01     =   'ITEM_UMSR'     ");
            //strSQL.Append("         AND S1.KEY02    =   TT.PUR_UMSR									");
            //strSQL.Append(" WHERE TT.REQ_TYPE		='01'											");
            //strSQL.Append("   AND TT.XFER_STATUS	< 20											");
            //if (_buyer_cd != "")
            //{
            //    strSQL.Append(" AND TT.BUYER_CD = @BUYER_CD     ");
            //    db.DbPsetString("@BUYER_CD", _buyer_cd);
            //}
            //if (_sch_id != "")
            //{
            //    strSQL.Append(" AND TT.SCH_ID = @SCH_ID         ");
            //    db.DbPsetString("@SCH_ID", _sch_id);
            //}
            //if (_catg_cd != "")
            //{
            //    strSQL.Append(" AND I.CATG_CD = @CATG_CD        ");
            //    db.DbPsetString("@CATG_CD", _catg_cd);
            //}
            //if (_vendor_cd != "")
            //{
            //    strSQL.Append(" AND TT.FROM_VC_CD = @FROM_VC_CD");
            //    db.DbPsetString("@FROM_VC_CD", _vendor_cd);
            //}
            //if (_item_no != "")
            //{
            //    strSQL.Append(" AND TT.ITEM_NO  = @ITEM_NO");
            //    db.DbPsetString("@ITEM_NO", _item_no);
            //}
            //if (_joc_cd != "")
            //{
            //    strSQL.Append(" AND TT.TO_JOC_CD = @TO_JOC_CD");
            //    db.DbPsetString("@TO_JOC_CD", _joc_cd);
            //}
            //if (_whs_cd != "")
            //{
            //    strSQL.Append(" AND TT.TO_WHS_CD = @TO_WHS_CD");
            //    db.DbPsetString("@TO_WHS_CD", _whs_cd);
            //}
            //if (_xfer_sch_date_from != 0)
            //{
            //    strSQL.Append(" AND TT.XFER_SCH_DATE >= @XFER_SCH_DATE_FROM");
            //    db.DbPsetInt("@XFER_SCH_DATE_FROM", _xfer_sch_date_from);
            //}
            //if (_xfer_sch_date_to != 0)
            //{
            //    strSQL.Append(" AND TT.XFER_SCH_DATE <= @XFER_SCH_DATE_TO");
            //    db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
            //}
            //if (_po_no != "")
            //{
            //    //strSQL.Append(" AND TT.PO_NO = @PO_NO");
            //    strSQL.Append("   AND (TT.PO_NO = @PO_NO OR TT.SLIP_NO = @PO_NO) "); // 2015.03.03

            //    db.DbPsetString("@PO_NO", _po_no);
            //}
            //if (_lot_no != "")
            //{
            //    strSQL.Append(" AND TT.TO_LOT_NO = @TO_LOT_NO");
            //    db.DbPsetString("@TO_LOT_NO", _lot_no);
            //}
            //strSQL.Append(" GROUP BY ");
            //strSQL.Append(" TT.XFER_SCH_DATE,       TT.FROM_VC_CD,          VM.VENDOR_NAME,         TT.ITEM_NO,         ");
            //strSQL.Append(" TT.ITEM_DESC,           TT.PO_NO     ,          TT.PO_LINE_NO,        ");
            //strSQL.Append(" PO.PO_QTY,              ");
            //strSQL.Append(" S1.DATA_CHAR           , TT.TO_JOC_CD,     TT.TO_WHS_CD,       ");
            //strSQL.Append(" TT.TO_LOT_NO																				");

            //strSQL.Append(" ORDER BY TT.XFER_SCH_DATE DESC,		TT.FROM_VC_CD,     TT.ITEM_NO ASC    ");

            ////2015.08.24DEL
            ////strSQL.Append(" SELECT TOP 2001                                                                             ");
            ////strSQL.Append(" TT.XFER_SCH_DATE,       TT.FROM_VC_CD,          VM.VENDOR_NAME,         TT.ITEM_NO,         ");
            ////strSQL.Append(" TT.ITEM_DESC,           TT.PO_NO+RIGHT(CAST(TT.PO_LINE_NO+1000 AS VARCHAR),3) PO_NO,        ");
            ////strSQL.Append(" PO.PO_QTY,              TT.RECV_QTY_PUR_UMSR,	TT.QTY_PUR_UMSR,		TT.REJ_QTY_PUR_UMSR,");
            ////strSQL.Append(" S1.DATA_CHAR UMSR_NAME, TT.PARTIAL_DELV_COMPL_CNT,    TT.TO_JOC_CD,     TT.TO_WHS_CD,       ");
            ////strSQL.Append(" TT.TO_LOT_NO																				");
            ////db.DbParametersClear();
            ////strSQL.Append(" FROM TRANSFER_TRANS TT                                                  ");
            ////strSQL.Append(" LEFT OUTER JOIN PUR_ORDER PO ON TT.PO_NO    =   PO.PO_NO                ");
            ////strSQL.Append("         AND TT.PO_LINE_NO   =   PO.PO_LINE_NO                           ");
            ////strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER VM ON TT.FROM_VC_CD   =   VM.VENDOR_CD    ");
            ////strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON    TT.ITEM_NO      =   I.ITEM_NO       ");
            ////strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01     =   'ITEM_UMSR'     ");
            ////strSQL.Append("         AND S1.KEY02    =   TT.PUR_UMSR									");
            ////strSQL.Append(" WHERE TT.REQ_TYPE		='01'											");
            ////strSQL.Append("   AND TT.XFER_STATUS	< 20											");
            ////if (_buyer_cd != "")
            ////{
            ////    strSQL.Append(" AND TT.BUYER_CD = @BUYER_CD     ");
            ////    db.DbPsetString("@BUYER_CD", _buyer_cd);
            ////}
            ////if (_sch_id != "")
            ////{
            ////    strSQL.Append(" AND TT.SCH_ID = @SCH_ID         ");
            ////    db.DbPsetString("@SCH_ID", _sch_id);
            ////}
            ////if (_catg_cd != "")
            ////{
            ////    strSQL.Append(" AND I.CATG_CD = @CATG_CD        ");
            ////    db.DbPsetString("@CATG_CD", _catg_cd);
            ////}
            ////if (_vendor_cd != "")
            ////{
            ////    strSQL.Append(" AND TT.FROM_VC_CD = @FROM_VC_CD");
            ////    db.DbPsetString("@FROM_VC_CD", _vendor_cd);
            ////}
            ////if (_item_no != "")
            ////{
            ////    strSQL.Append(" AND TT.ITEM_NO  = @ITEM_NO");
            ////    db.DbPsetString("@ITEM_NO", _item_no);
            ////}
            ////if (_joc_cd != "")
            ////{
            ////    strSQL.Append(" AND TT.TO_JOC_CD = @TO_JOC_CD");
            ////    db.DbPsetString("@TO_JOC_CD", _joc_cd);
            ////}
            ////if (_whs_cd != "")
            ////{
            ////    strSQL.Append(" AND TT.TO_WHS_CD = @TO_WHS_CD");
            ////    db.DbPsetString("@TO_WHS_CD", _whs_cd);
            ////}
            ////if (_xfer_sch_date_from != 0)
            ////{
            ////    strSQL.Append(" AND TT.XFER_SCH_DATE >= @XFER_SCH_DATE_FROM");
            ////    db.DbPsetInt("@XFER_SCH_DATE_FROM", _xfer_sch_date_from);
            ////}
            ////if (_xfer_sch_date_to != 0)
            ////{
            ////    strSQL.Append(" AND TT.XFER_SCH_DATE <= @XFER_SCH_DATE_TO");
            ////    db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
            ////}
            ////if (_po_no != "")
            ////{
            ////    //strSQL.Append(" AND TT.PO_NO = @PO_NO");
            ////    strSQL.Append("   AND (TT.PO_NO = @PO_NO OR TT.SLIP_NO = @PO_NO) "); // 2015.03.03

            ////    db.DbPsetString("@PO_NO", _po_no);
            ////}
            ////if (_lot_no != "")
            ////{
            ////    strSQL.Append(" AND TT.TO_LOT_NO = @TO_LOT_NO");
            ////    db.DbPsetString("@TO_LOT_NO", _lot_no);
            ////}

            ////strSQL.Append(" ORDER BY TT.XFER_SCH_DATE DESC,		TT.FROM_VC_CD,     TT.ITEM_NO ASC    ");

            //try
            //{
            //    ds = db.DbDataSet(strSQL.ToString(), "TABLE");
            //    if (ds == null)
            //    {
            //        _dbmsg = db.expmsg;
            //        _strErr = db.strErr;
            //    }
            //    if (db.State() == ConnectionState.Open)
            //        db.DbClose();
            //    return ds;
            //}
            //catch
            //{
            //    _dbmsg = db.expmsg;
            //    _strErr = db.strErr;
            //    if (db.State() == ConnectionState.Open)
            //        db.DbClose();
            //    return null;
            //}
        //}

        /// <summary>
        /// 検収実績データを検索して表示する。
        /// <para>使用画面：[PurActInq]</para>
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Pur_InspNoRcvWhsList()
		{
			ComDB db = new ComDB(_db_type);
			StringBuilder strSQL = new StringBuilder();
			DataSet ds = new DataSet();

            // 2015.08.24
            strSQL.Append(" SELECT TOP 2001                                                                             ");
            strSQL.Append(" AT.SLIP_DATE,			AT.FROM_VC_CD,          VM.VENDOR_NAME,         AT.ITEM_NO,         ");
            strSQL.Append(" AT.ITEM_DESC,           AT.PO_NO+RIGHT(CAST(AT.PO_LINE_NO+1000 AS VARCHAR),3) PO_NO,        ");
            strSQL.Append(" PO.PO_QTY,              SUM(AT.QTY) QTY,		SUM(TT.DESTRUCT_QTY_PUR_UMSR) DESTRUCT_QTY_PUR_UMSR,");
            strSQL.Append(" SUM(TT.INST_QTY-TT.DESTRUCT_QTY_PUR_UMSR) NORCVQTY,													");
            strSQL.Append(" S1.DATA_CHAR UMSR_NAME, MIN(AT.PARTIAL_DELV_CNT) PARTIAL_DELV_CNT,    AT.TO_JOC_CD,     AT.TO_WHS_CD,				");
            strSQL.Append(" AT.TO_LOT_NO																				");
            db.DbParametersClear();
            strSQL.Append(" FROM AP_TRANS AT														");
            strSQL.Append(" LEFT OUTER JOIN PUR_ORDER PO ON AT.PO_NO    =   PO.PO_NO                ");
            strSQL.Append("         AND AT.PO_LINE_NO   =   PO.PO_LINE_NO                           ");
            strSQL.Append(" INNER JOIN TRANSFER_TRANS TT ON AT.SLIP_NO		=	TT.FROM_MNG_NO  ");
            strSQL.Append("   AND TT.REQ_TYPE		='11'											");
            strSQL.Append("   AND TT.XFER_STATUS	< 20											");
            strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER VM ON TT.FROM_VC_CD   =   VM.VENDOR_CD    ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON    TT.ITEM_NO      =   I.ITEM_NO       ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01     =   'ITEM_UMSR'     ");
            strSQL.Append("         AND S1.KEY02    =   TT.PUR_UMSR									");
            strSQL.Append(" WHERE 1	=1                  											");
            if (_buyer_cd != "")
            {
                strSQL.Append(" AND PO.BUYER_CD = @BUYER_CD     ");
                db.DbPsetString("@BUYER_CD", _buyer_cd);
            }
            if (_sch_id != "")
            {
                strSQL.Append(" AND PO.SCH_ID = @SCH_ID         ");
                db.DbPsetString("@SCH_ID", _sch_id);
            }
            if (_catg_cd != "")
            {
                strSQL.Append(" AND I.CATG_CD = @CATG_CD        ");
                db.DbPsetString("@CATG_CD", _catg_cd);
            }
            if (_vendor_cd != "")
            {
                strSQL.Append(" AND AT.FROM_VC_CD = @FROM_VC_CD");
                db.DbPsetString("@FROM_VC_CD", _vendor_cd);
            }
            if (_item_no != "")
            {
                strSQL.Append(" AND AT.ITEM_NO  = @ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_joc_cd != "")
            {
                strSQL.Append(" AND AT.TO_JOC_CD = @TO_JOC_CD");
                db.DbPsetString("@TO_JOC_CD", _joc_cd);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND AT.TO_WHS_CD = @TO_WHS_CD");
                db.DbPsetString("@TO_WHS_CD", _whs_cd);
            }
            if (_xfer_sch_date_from != 0)
            {
                strSQL.Append(" AND AT.SLIP_DATE >= @XFER_SCH_DATE_FROM");
                db.DbPsetInt("@XFER_SCH_DATE_FROM", _xfer_sch_date_from);
            }
            if (_xfer_sch_date_to != 0)
            {
                strSQL.Append(" AND AT.SLIP_DATE <= @XFER_SCH_DATE_TO");
                db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
            }
            if (_po_no != "")
            {
                //strSQL.Append(" AND AT.PO_NO = @PO_NO");
                strSQL.Append("   AND (AT.PO_NO = @PO_NO OR TT.SLIP_NO = @PO_NO) "); // 2015.03.03

                db.DbPsetString("@PO_NO", _po_no);
            }
            if (_lot_no != "")
            {
                strSQL.Append(" AND AT.TO_LOT_NO = @TO_LOT_NO");
                db.DbPsetString("@TO_LOT_NO", _lot_no);
            }
            strSQL.Append(" GROUP BY ");
            strSQL.Append(" AT.SLIP_DATE,			AT.FROM_VC_CD,          VM.VENDOR_NAME,         AT.ITEM_NO,         ");
            strSQL.Append(" AT.ITEM_DESC,           AT.PO_NO    ,           AT.PO_LINE_NO,   ");
            strSQL.Append(" PO.PO_QTY,              ");
            strSQL.Append(" S1.DATA_CHAR,           AT.TO_JOC_CD,     AT.TO_WHS_CD,				");
            strSQL.Append(" AT.TO_LOT_NO																				");
            
            strSQL.Append(" ORDER BY AT.SLIP_DATE DESC,		AT.FROM_VC_CD ASC,     AT.ITEM_NO ASC    ");
            
            // 2015.08.24 DEL
            //strSQL.Append(" SELECT TOP 2001                                                                             ");
            //strSQL.Append(" AT.SLIP_DATE,			AT.FROM_VC_CD,          VM.VENDOR_NAME,         AT.ITEM_NO,         ");
            //strSQL.Append(" AT.ITEM_DESC,           AT.PO_NO+RIGHT(CAST(AT.PO_LINE_NO+1000 AS VARCHAR),3) PO_NO,        ");
            //strSQL.Append(" PO.PO_QTY,              AT.QTY,					TT.DESTRUCT_QTY_PUR_UMSR,					");
            //strSQL.Append(" (TT.INST_QTY-TT.DESTRUCT_QTY_PUR_UMSR) NORCVQTY,													");
            //strSQL.Append(" S1.DATA_CHAR UMSR_NAME, AT.PARTIAL_DELV_CNT,    AT.TO_JOC_CD,     AT.TO_WHS_CD,				");
            //strSQL.Append(" AT.TO_LOT_NO																				");
            //db.DbParametersClear();
            //strSQL.Append(" FROM AP_TRANS AT														");
            //strSQL.Append(" LEFT OUTER JOIN PUR_ORDER PO ON AT.PO_NO    =   PO.PO_NO                ");
            //strSQL.Append("         AND AT.PO_LINE_NO   =   PO.PO_LINE_NO                           ");
            //strSQL.Append(" INNER JOIN TRANSFER_TRANS TT ON AT.SLIP_NO		=	TT.FROM_MNG_NO  ");
            //strSQL.Append("   AND TT.REQ_TYPE		='11'											");
            //strSQL.Append("   AND TT.XFER_STATUS	< 20											");
            //strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER VM ON TT.FROM_VC_CD   =   VM.VENDOR_CD    ");
            //strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON    TT.ITEM_NO      =   I.ITEM_NO       ");
            //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01     =   'ITEM_UMSR'     ");
            //strSQL.Append("         AND S1.KEY02    =   TT.PUR_UMSR									");
            //strSQL.Append(" WHERE 1	=1                  											");
            //if (_buyer_cd != "")
            //{
            //    strSQL.Append(" AND PO.BUYER_CD = @BUYER_CD     ");
            //    db.DbPsetString("@BUYER_CD", _buyer_cd);
            //}
            //if (_sch_id != "")
            //{
            //    strSQL.Append(" AND PO.SCH_ID = @SCH_ID         ");
            //    db.DbPsetString("@SCH_ID", _sch_id);
            //}
            //if (_catg_cd != "")
            //{
            //    strSQL.Append(" AND I.CATG_CD = @CATG_CD        ");
            //    db.DbPsetString("@CATG_CD", _catg_cd);
            //}
            //if (_vendor_cd != "")
            //{
            //    strSQL.Append(" AND AT.FROM_VC_CD = @FROM_VC_CD");
            //    db.DbPsetString("@FROM_VC_CD", _vendor_cd);
            //}
            //if (_item_no != "")
            //{
            //    strSQL.Append(" AND AT.ITEM_NO  = @ITEM_NO");
            //    db.DbPsetString("@ITEM_NO", _item_no);
            //}
            //if (_joc_cd != "")
            //{
            //    strSQL.Append(" AND AT.TO_JOC_CD = @TO_JOC_CD");
            //    db.DbPsetString("@TO_JOC_CD", _joc_cd);
            //}
            //if (_whs_cd != "")
            //{
            //    strSQL.Append(" AND AT.TO_WHS_CD = @TO_WHS_CD");
            //    db.DbPsetString("@TO_WHS_CD", _whs_cd);
            //}
            //if (_xfer_sch_date_from != 0)
            //{
            //    strSQL.Append(" AND AT.SLIP_DATE >= @XFER_SCH_DATE_FROM");
            //    db.DbPsetInt("@XFER_SCH_DATE_FROM", _xfer_sch_date_from);
            //}
            //if (_xfer_sch_date_to != 0)
            //{
            //    strSQL.Append(" AND AT.SLIP_DATE <= @XFER_SCH_DATE_TO");
            //    db.DbPsetInt("@XFER_SCH_DATE_TO", _xfer_sch_date_to);
            //}
            //if (_po_no != "")
            //{
            //    //strSQL.Append(" AND AT.PO_NO = @PO_NO");
            //    strSQL.Append("   AND (AT.PO_NO = @PO_NO OR TT.SLIP_NO = @PO_NO) "); // 2015.03.03

            //    db.DbPsetString("@PO_NO", _po_no);
            //}
            //if (_lot_no != "")
            //{
            //    strSQL.Append(" AND AT.TO_LOT_NO = @TO_LOT_NO");
            //    db.DbPsetString("@TO_LOT_NO", _lot_no);
            //}
            //strSQL.Append(" ORDER BY AT.SLIP_DATE DESC,		AT.FROM_VC_CD ASC,     AT.ITEM_NO ASC    ");
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
