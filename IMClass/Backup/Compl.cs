/*|------------------------------------------------------------------------------------------|*/
/*|  プロジェクト名　：　CLASS                   　                                          |*/
/*|  機能名　　　　　：　作業実績   　　　　　　　                                           |*/
/*|          　　　　  　Compl                                                               |*/
/*|          　　　　  　                                                                    |*/
/*|  プログラムID  　：　Compl　　　　　　　　　　　                                         |*/
/*|------------------------------------------------------------------------------------------|*/
/*|  [History]                                                                               |*/
/*|  2008/11/27     Ubiq_Liu   　Creation                                                    |*/
/*|  2010/05/10     UBIQ-LIU   　[工程別]関連した追加；Get_Mfg_ComplDetail Update            |*/
/*|------------------------------------------------------------------------------------------|*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Data;

namespace IMClass
{
    public class Compl
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Compl()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Compl(string p_user_id, int p_lang)
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
        protected string _sch_id = "";
        //protected string _sch_name = "";
        protected int _beg_slip_date = 0;
        protected int _end_slip_date = 0;
        protected int _beg_compl_date = 0;
        protected int _end_compl_date = 0;

        protected int _sch_compl_date = 0; //ADD BY UBIQ-SUO 2011/02/10

        protected string _ws_cd = "";
        //protected string _ws_desc = "";
        //protected string _order_no = "";
        protected string _item_no = "";
        protected string _parent_item_no = "";  //Add Ubiq-Sai 2010/09/17
        //protected string _item_desc = "";
        //protected double _job_order_qty = 0;
        //protected string _order_umsr = "";
        protected string _process_cd = "";//ADD BY UBIQ-LIU 2010/6/7
        protected int _seq = 0;//ADD BY UBIQ-LIU 2010/6/7
        protected string _parent_xfer_no = "";//ADD BY UBIQ-LIU 2010/6/8
        protected string _joc_cd = "";
        protected int _unfinish_flag = 0;
        protected int _compl_flag = 0;

        protected string _whs_cd = "";
        protected string _to_lot_no = "";
        protected string _job_order_no = "";
        protected double _job_order_compl_qty = 0;
        protected double _job_order_rej_qty = 0;
        protected int _job_order_compl_date = 0;
        protected string _lot_no = "";
        protected string _location = "";
        protected int _dev_compl_type = 0;
        protected int _partial_delv_compl_cnt = 0;
        protected string _user_id = "";
        protected string _demand_no = "";
        protected string _to_demand_no = "";
        protected string _xfer_no = "";
        protected double _input_qty = 0;
        protected int _update_type = 0;
        protected int _auto_disb_type = 0;
        protected string _req_user_id = "";
        protected int _working_date = 0;
        protected double _working_hours = 0;
        protected int _working_hour = 0;//ADD BY UBIQ-LIU 2010/6/9
        protected double _compl_qty = 0;
        protected int _sch_compl_date_from = 0;
        protected int _sch_compl_date_to = 0;
        protected int _job_order_compl_date_from = 0;
        protected int _job_order_compl_date_to = 0;
        protected double _inst_qty = 0;
        protected string _item_umsr = "";
        protected string _item_desc = "";
        protected int _slip_line_no = 0;
        protected double _inv_qty = 0;
        protected double _alloc_qty = 0;
        protected double _wip_qty = 0;
        protected double _w_alloc_qty = 0;
        //ADD BY UBIQ-LIU 2010/12/09
        protected double _parts_input_qty = 0;
        protected int _job_order_start_date = 0;
        protected double _parts_scrap_qty = 0;
        protected double _scrap_qty = 0;

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
        public string sch_id { get { return _sch_id; } set { _sch_id = value; } }
        //public string sch_name { get { return _sch_name; } set { _sch_name = value; } }
        public int beg_slip_date { get { return _beg_slip_date; } set { _beg_slip_date = value; } }
        public int end_slip_date { get { return _end_slip_date; } set { _end_slip_date = value; } }
        public int beg_compl_date { get { return _beg_compl_date; } set { _beg_compl_date = value; } }
        public int end_compl_date { get { return _end_compl_date; } set { _end_compl_date = value; } }

        public int sch_compl_date { get { return _sch_compl_date; } set { _sch_compl_date = value; } }
        public string ws_cd { get { return _ws_cd; } set { _ws_cd = value; } }
        public string to_lot_no { get { return _to_lot_no; } set { _to_lot_no = value; } }
        //public string order_no { get { return _order_no; } set { _order_no = value; } }
        public string item_no { get { return _item_no; } set { _item_no = value; } }
        public string parent_item_no { get { return _parent_item_no; } set { _parent_item_no = value; } }   //Add Ubiq-Sai 2010/09/17
        //public string item_desc { get { return _item_desc; } set { _item_desc = value; } }
        //public double job_order_qty { get { return _job_order_qty; } set { _job_order_qty = value; } }
        //public string order_umsr { get { return _order_umsr; } set { _order_umsr = value; } }
        public string process_cd { get { return _process_cd; } set { _process_cd = value; } }
        public int seq { get { return _seq; } set { _seq = value; } }
        public string parent_xfer_no { get { return _parent_xfer_no; } set { _parent_xfer_no = value; } }
        public string joc_cd { get { return _joc_cd; } set { _joc_cd = value; } }
        public int compl_flag { get { return _compl_flag; } set { _compl_flag = value; } }
        public int unfinish_flag { get { return _unfinish_flag; } set { _unfinish_flag = value; } }

        public string whs_cd { get { return _whs_cd; } set { _whs_cd = value; } }
        //public string slip_note { get { return _slip_note; } set { _slip_note = value; } }
        public string job_order_no { get { return _job_order_no; } set { _job_order_no = value; } }
        public int job_order_compl_date { get { return _job_order_compl_date; } set { _job_order_compl_date = value; } }
        public string location { get { return _location; } set { _location = value; } }
        public string lot_no { get { return _lot_no; } set { _lot_no = value; } }
        public string user_id { get { return _user_id; } set { _user_id = value; } }
        public int dev_compl_type { get { return _dev_compl_type; } set { _dev_compl_type = value; } }
        public int partial_delv_compl_cnt { get { return _partial_delv_compl_cnt; } set { _partial_delv_compl_cnt = value; } }
        public double job_order_compl_qty { get { return _job_order_compl_qty; } set { _job_order_compl_qty = value; } }
        public double job_order_rej_qty { get { return _job_order_rej_qty; } set { _job_order_rej_qty = value; } }
        public string demand_no { get { return _demand_no; } set { _demand_no = value; } }
        public string to_demand_no { get { return _to_demand_no; } set { _to_demand_no = value; } }
        public string xfer_no { get { return _xfer_no; } set { _xfer_no = value; } }
        public double input_qty { get { return _input_qty; } set { _input_qty = value; } }
        public int update_type { get { return _update_type; } set { _update_type = value; } }
        public int auto_disb_type { get { return _auto_disb_type; } set { _auto_disb_type = value; } }
        public string req_user_id { get { return _req_user_id; } set { _req_user_id = value; } }
        public int working_date { get { return _working_date; } set { _working_date = value; } }
        public double working_hours { get { return _working_hours; } set { _working_hours = value; } }
        public int working_hour { get { return _working_hour; } set { _working_hour = value; } }
        public double compl_qty { get { return _compl_qty; } set { _compl_qty = value; } }
        public int sch_compl_date_from { get { return _sch_compl_date_from; } set { _sch_compl_date_from = value; } }
        public int sch_compl_date_to { get { return _sch_compl_date_to; } set { _sch_compl_date_to = value; } }
        public int job_order_compl_date_from { get { return _job_order_compl_date_from; } set { _job_order_compl_date_from = value; } }
        public int job_order_compl_date_to { get { return _job_order_compl_date_to; } set { _job_order_compl_date_to = value; } }
        public double inst_qty { get { return _inst_qty; } set { _inst_qty = value; } }
        public string item_umsr { get { return _item_umsr; } set { _item_umsr = value; } }
        public string item_desc { get { return _item_desc; } set { _item_desc = value; } }
        public int slip_line_no { get { return _slip_line_no; } set { _slip_line_no = value; } }
        public double inv_qty { get { return _inv_qty; } set { _inv_qty = value; } }
        public double wip_qty { get { return _wip_qty; } set { _wip_qty = value; } }
        public int job_order_start_date { get { return _job_order_start_date; } set { _job_order_start_date = value; } }
        public double parts_input_qty { get { return _parts_input_qty; } set { _parts_input_qty = value; } }
        public double scrap_qty { get { return _scrap_qty; } set { _scrap_qty = value; } }
        public double parts_scrap_qty { get { return _parts_scrap_qty; } set { _parts_scrap_qty = value; } }

        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }

        #endregion

        /// <summary>
        /// 指示済製造オーダを検索
        /// </summary>
        public DataSet Get_Mfg_ComplDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append(" WS.COMPL_FLAG,	    JOD.INPUT_FLAG,                                         ");//UPD BY UBIQ-LIU 2010/6/10 ;ADD [INPUT_FLAG] BY LIU 2010/12/10
            strSQL.Append("JO.ORDER_STATUS,		JO.WS_CD,	    WS.WS_DESC,	        JO.SCH_START_DATE,	");
            strSQL.Append("JO.SCH_COMPL_DATE,	JO.ITEM_NO,     JO.ITEM_DESC,       JO.JOB_ORDER_QTY,   ");
            strSQL.Append("JO.ORDER_UMSR,       JO.JOB_ORDER_COMPL_QTY,  JO.WHS_CD, WHS.WHS_DESC,       ");
            strSQL.Append("JO.INSP_CD,          JO.SLIP_NOTE,   IM.LOCATION,        JOD.PROCESS_CD,     ");
            strSQL.Append("PM.PROCESS_DESC,     S2.DATA_CHAR UMSR_NAME,                                                        ");
            //strSQL.Append("PM.PROCESS_DESC,     RM.UNIT_TIME,   RM.UNIT_QTY,        RM.LT_TYPE,         ");//DEL BY UBIQ-LIU 2010/6/10
            //strSQL.Append("RM.MFG_LT,           RM.SETUP_TIME,  RM.TRANSFER_TIME,                       ");//DEL BY UBIQ-LIU 2010/6/10
            strSQL.Append("IM.LOT_CNTL_FLAG,    S1.DATA_INT AUTO_TYPE,              JO.JOC_CD,          ");//ADD20090206
            //strSQL.Append("RM.DAILY_PROD_QTY,   RM.TRANSFER_LT, S2.DATA_CHAR UMSR_NAME                  ");//DEL BY UBIQ-LIU 2010/6/10
            strSQL.Append("JOD.SCH_WORK_TIME + JOD.SCH_SETUP_TIME + JOD.SCH_TRANSFER_TIME WORKTIME,     ");//ADD20090727
            //ADD 20090922 --->
            strSQL.Append("(CASE WHEN ISNULL(IW.IDTAG_PRINT_FLAG,1) = 1 THEN                            ");
            strSQL.Append("     (CASE WHEN ISNULL(IW.IDTAG_UNIT_QTY,0) = 0 THEN 1                       ");
            strSQL.Append("      ELSE ceiling((JO.JOB_ORDER_QTY-JO.JOB_ORDER_COMPL_QTY)/IW.IDTAG_UNIT_QTY) END)  ");
            strSQL.Append(" ELSE 0 END) LABEL_QTY,  ISNULL(IW.IDTAG_UNIT_QTY,0) IDTAG_UNIT_QTY,         ");
            strSQL.Append(" ISNULL(IW.IDTAG_PRINT_FLAG,1) IDTAG_PRINT_FLAG                              ");
            strSQL.Append(" ,JO.REJ_QTY																	");//ADD BY UBIQ-LIU 2010/11/01
            //ADD 20090922 <---
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER JO                                                       ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS  ON JO.WS_CD     = WS.WS_CD          ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WHS ON JO.WHS_CD   = WHS.WHS_CD        ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER     IM  ON JO.ITEM_NO   = IM.ITEM_NO        ");
                strSQL.Append(" LEFT JOIN JOB_ORDER_DETAIL      JOD ON                                  ");
                strSQL.Append(" JO.JOB_ORDER_NO     = JOD.JOB_ORDER_NO                                  ");
                strSQL.Append(" LEFT JOIN PROCESS_MASTER PM ON JOD.PROCESS_CD      = PM.PROCESS_CD      ");
                strSQL.Append(" AND JOD.WS_CD = PM.WS_CD                                                ");//ADD BY LIU 2008.12.30
                //strSQL.Append(" LEFT JOIN ROUTINE_MASTER RM ON JOD.ITEM_NO         = RM.ITEM_NO         ");//DEL BY UBIQ-LIU 2010/6/10
                //strSQL.Append("  AND    JOD.WS_CD           = RM.WS_CD                                  ");//DEL BY UBIQ-LIU 2010/6/10
                //strSQL.Append("  AND    JOD.PROCESS_CD      = RM.PROCESS_CD                             ");//DEL BY UBIQ-LIU 2010/6/10
                //strSQL.Append("  AND    JOD.PROCESS_SEQ     = RM.ROUTINE_SEQ                            ");//DEL BY UBIQ-LIU 2010/6/10
                //strSQL.Append("  AND    JOD.SCH_START_DATE  >= RM.BEG_EFF_DATE                          ");//DEL BY UBIQ-LIU 2010/6/10
                //strSQL.Append("  AND    JOD.PROCESS_CD      = RM.PROCESS_CD                             ");//DEL BY UBIQ-LIU 2010/6/10
                //strSQL.Append("  AND    JOD.SCH_START_DATE  <= RM.END_EFF_DATE                          ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S1 ON S1.KEY01  = 'LOT_NUMBERING'            ");//UPD 20090218 UBIQ-LIU
                strSQL.Append("  AND    S1.KEY02  = 'MFG'                                               ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S2 ON S2.KEY01  = 'ITEM_UMSR'                ");//UPD 20090218 UBIQ-LIU
                strSQL.Append("  AND    S2.KEY02  = JO.ORDER_UMSR                                       ");
                //ADD 20090922 --->
                strSQL.Append(" LEFT JOIN ITEM_WS_MASTER IW ON JO.ITEM_NO   = IW.ITEM_NO                ");
                strSQL.Append("  AND    JO.WS_CD            =  IW.WS_CD                                 ");
                strSQL.Append("  AND    JO.SCH_COMPL_DATE   >= IW.BEG_EFF_DATE                          ");
                strSQL.Append("  AND    JO.SCH_COMPL_DATE   <= IW.END_EFF_DATE                          ");
                //ADD 20090922 <---
                strSQL.Append(" WHERE  JO.JOB_ORDER_NO      = :JOB_ORDER_NO                             ");
                db.DbPsetString("JOB_ORDER_NO", _job_order_no);
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER JO                                                       ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS  ON JO.WS_CD     = WS.WS_CD          ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WHS ON JO.WHS_CD   = WHS.WHS_CD        ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER     IM  ON JO.ITEM_NO   = IM.ITEM_NO        ");
                strSQL.Append(" LEFT JOIN JOB_ORDER_DETAIL      JOD ON                                  ");
                strSQL.Append(" JO.JOB_ORDER_NO     = JOD.JOB_ORDER_NO                                  ");
                strSQL.Append(" LEFT JOIN PROCESS_MASTER PM ON JOD.PROCESS_CD      = PM.PROCESS_CD      ");
                strSQL.Append(" AND JOD.WS_CD = PM.WS_CD                                                ");//ADD BY LIU 2008.12.30
                //strSQL.Append(" LEFT JOIN ROUTINE_MASTER RM ON JOD.ITEM_NO         = RM.ITEM_NO         ");//DEL BY UBIQ-LIU 2010/6/10
                //strSQL.Append("  AND    JOD.WS_CD           = RM.WS_CD                                  ");//DEL BY UBIQ-LIU 2010/6/10
                //strSQL.Append("  AND    JOD.PROCESS_CD      = RM.PROCESS_CD                             ");//DEL BY UBIQ-LIU 2010/6/10
                //strSQL.Append("  AND    JOD.PROCESS_SEQ     = RM.ROUTINE_SEQ                            ");//DEL BY UBIQ-LIU 2010/6/10
                //strSQL.Append("  AND    JOD.SCH_START_DATE  >= RM.BEG_EFF_DATE                          ");//DEL BY UBIQ-LIU 2010/6/10
                //strSQL.Append("  AND    JOD.PROCESS_CD      = RM.PROCESS_CD                             ");//DEL BY UBIQ-LIU 2010/6/10
                //strSQL.Append("  AND    JOD.SCH_START_DATE  <= RM.END_EFF_DATE                          ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S1 ON S1.KEY01  = 'LOT_NUMBERING'            ");//UPD 20090218 UBIQ-LIU
                strSQL.Append("  AND    S1.KEY02  = 'MFG'                                               ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S2 ON S2.KEY01  = 'ITEM_UMSR'                ");//UPD 20090218 UBIQ-LIU
                strSQL.Append("  AND    S2.KEY02  = JO.ORDER_UMSR                                       ");
                //ADD 20090922 --->
                strSQL.Append(" LEFT JOIN ITEM_WS_MASTER IW ON JO.ITEM_NO   = IW.ITEM_NO                ");
                strSQL.Append("  AND    JO.WS_CD            =  IW.WS_CD                                 ");
                strSQL.Append("  AND    JO.SCH_COMPL_DATE   >= IW.BEG_EFF_DATE                          ");
                strSQL.Append("  AND    JO.SCH_COMPL_DATE   <= IW.END_EFF_DATE                          ");
                //ADD 20090922 <---
                strSQL.Append(" WHERE  JO.JOB_ORDER_NO      = @JOB_ORDER_NO                             ");
                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
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
        /// 作業実績
        /// Mfg_Compl_Detail
        /// </summary>
        public int Mfg_Compl(ComDB db)
        {
            //ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db.DbPsetDouble("@I_JOB_ORDER_COMPL_QTY", _job_order_compl_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_JOB_ORDER_REJ_QTY", _job_order_rej_qty, ComConst.DB_IN);
            db.DbPsetString("@I_LOT_NO", _lot_no, ComConst.DB_INOUT);     //Upd Ubiq-Sai 10.10.03 DB_OUT->DB_INOUT
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION", _location, ComConst.DB_IN);
            db.DbPsetString("@I_USER_ID", _user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_JOB_ORDER_COMPL_DATE", _job_order_compl_date, ComConst.DB_IN);
            db.DbPsetInt("@I_DEV_COMPL_TYPE", _dev_compl_type, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            //db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();
            rtn = db.DbStored("SP_MFG_COMPL");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                _lot_no = db.DbPgetString("@I_LOT_NO");
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
        /// 作業実績データを検索
        /// </summary>
        public DataSet Get_Mfg_ComplCancelList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append("JO.JOB_ORDER_NO,		JO.ITEM_NO,	    JO.ITEM_DESC,	    JO.WS_CD,	        ");
            //strSQL.Append("TR.ACT_QTY,	        TR.ITEM_UMSR,   TR.SLIP_DATE,       TR.TO_LOT_NO,       ");
            strSQL.Append("TR.INST_QTY,	        TR.ITEM_UMSR,   TR.SLIP_DATE,       TR.TO_LOT_NO,       ");//20090304 Upd UBIQ-LIU
            strSQL.Append("TR.TO_JOC_CD,    TR.TO_WHS_CD,   TR.REJ_QTY,   TR.PARTIAL_DELV_COMPL_CNT,    ");
            strSQL.Append("WS.WS_DESC,          S1.DATA_CHAR UMSR_NAME                                  ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER JO,TRANSFER_TRANS TR,WORKSHOP_MASTER WS,SYSTEM_PARAMETER S1 ");
                strSQL.Append(" WHERE   JO.ORDER_STATUS     >= 25                                       ");
                strSQL.Append("  AND    JO.ORDER_NO         = TR.ORDER_NO                               ");
                strSQL.Append("  AND    TR.PO_LINE_NO       = 0                                         ");//ADD BY UBIQ-LIU 2010/6/10
                strSQL.Append("  AND    TR.XFER_STATUS      < 90                                        ");
                strSQL.Append("  AND    TR.REQ_TYPE         = '06'                                      ");//UPD BY UBIQ-LIU 2010/6/10 12→06
                strSQL.Append("  AND    WS.WS_CD            = JO.WS_CD                                  ");
                strSQL.Append("  AND    S1.KEY01            = 'ITEM_UMSR'                               ");
                strSQL.Append("  AND    S1.KEY02            = TR.ITEM_UMSR                              ");
                if (_job_order_no != "")
                {
                    strSQL.Append("  AND    JO.JOB_ORDER_NO     = :JOB_ORDER_NO                             ");
                    db.DbPsetString("JOB_ORDER_NO", _job_order_no);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND    JO.WS_CD            = :WS_CD                                    ");
                    db.DbPsetString("WS_CD", _ws_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("  AND    JO.ITEM_NO          = :ITEM_NO                                  ");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_to_lot_no != "")
                {
                    strSQL.Append("  AND    TR.TO_LOT_NO        = :TO_LOT_NO                                ");
                    db.DbPsetString("TO_LOT_NO", _to_lot_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("  AND    JO.JOC_CD           = :JOC_CD                                   ");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }
                if (_beg_slip_date != 0)
                {
                    strSQL.Append("  AND    TR.SLIP_DATE        >= :BEG_SLIP_DATE                           ");
                    db.DbPsetInt("BEG_SLIP_DATE", _beg_slip_date);
                }
                if (_end_slip_date != 0)
                {
                    strSQL.Append("  AND    TR.SLIP_DATE        <= :END_SLIP_DATE                           ");
                    db.DbPsetInt("END_SLIP_DATE", _end_slip_date);
                }
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER JO                                                       ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON  JO.WS_CD   = WS.WS_CD            ");
                strSQL.Append(" INNER JOIN TRANSFER_TRANS TR ON  JO.ORDER_NO   = TR.ORDER_NO            ");
                //strSQL.Append("  AND    TR.PO_LINE_NO       = 0                                         ");//ADD BY UBIQ-LIU 2010/6/10	//DEL 2010.11.09
                strSQL.Append("  AND    TR.TO_PROCESS_CD    = ''                                        ");//ADD BY UBIQ-LIU 2010/6/10		//ADD 2010.11.09
                strSQL.Append("  AND    TR.XFER_STATUS      < 90                                        ");
                strSQL.Append("  AND    TR.REQ_TYPE         = '06'                                      ");//UPD BY UBIQ-LIU 2010/6/10 12→06
                if (_to_lot_no != "")
                {
                    strSQL.Append("  AND    TR.TO_LOT_NO        = @TO_LOT_NO                            ");
                    db.DbPsetString("@TO_LOT_NO", _to_lot_no);
                }
                if (_beg_slip_date != 0)
                {
                    strSQL.Append("  AND    TR.SLIP_DATE        >= @BEG_SLIP_DATE                       ");
                    db.DbPsetInt("@BEG_SLIP_DATE", _beg_slip_date);
                }
                if (_end_slip_date != 0)
                {
                    strSQL.Append("  AND    TR.SLIP_DATE        <= @END_SLIP_DATE                       ");
                    db.DbPsetInt("@END_SLIP_DATE", _end_slip_date);
                }
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON  S1.KEY01  = 'ITEM_UMSR'         ");
                strSQL.Append("  AND    S1.KEY02            = TR.ITEM_UMSR                              ");
                strSQL.Append(" WHERE   JO.ORDER_STATUS     >= 25                                       ");
                if (_job_order_no != "")
                {
                    strSQL.Append("  AND    JO.JOB_ORDER_NO     = @JOB_ORDER_NO                         ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND    JO.WS_CD            = @WS_CD                                ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("  AND    JO.ITEM_NO          = @ITEM_NO                              ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("  AND    JO.JOC_CD           = @JOC_CD                               ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
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
        /// 実績取消
        /// </summary>
        public int Mfg_ComplCancel()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PARTIAL_DELV_COMPL_CNT", _partial_delv_compl_cnt, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            //db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_MFG_COMPLCANCEL");
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
        /// 作業実績データを検索
        /// </summary>
        public DataSet Get_Mfg_ProgressInqList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                                   ");
            strSQL.Append("JO.JOB_ORDER_NO,		JO.ITEM_NO,	    JO.ITEM_DESC,	    JO.WS_CD,	                    ");
            strSQL.Append("JO.JOB_ORDER_QTY,	TR.ACT_QTY,     JO.ORDER_UMSR ITEM_UMSR,      JO.SCH_COMPL_DATE,    ");
            strSQL.Append("TR.SLIP_DATE,        TR.TO_LOT_NO,   TR.FROM_PROCESS_CD,     PM.PROCESS_DESC,            ");//UPD BY UBIQ-LIU 2010/6/10 [ADD 工程]
            strSQL.Append(" TR.PO_LINE_NO,                                                                          ");//ADD BY UBIQ-LIU 2010/6/10
            strSQL.Append("JO.JOC_CD TO_JOC_CD, JO.WHS_CD TO_WHS_CD,   TR.REJ_QTY,   TR.PARTIAL_DELV_COMPL_CNT,     ");
            strSQL.Append("WS.WS_DESC,          S1.DATA_CHAR UMSR_NAME,     JO.ALLOC_FLAG,    ORDER_STATUS          ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER JO                                                       ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON  JO.WS_CD   = WS.WS_CD            ");
                strSQL.Append(" LEFT OUTER JOIN ( SELECT T1.*   FROM TRANSFER_TRANS T1                  ");//UPD BY UBIQ-LIU 2010/6/10 BUG815
                //strSQL.Append("       ,(SELECT PO_NO, MAX(PO_LINE_NO) PO_LINE_NO FROM TRANSFER_TRANS    ");//DEL BY UBIQ-SUO 2010/12/21 BUG948
                //strSQL.Append("         WHERE XFER_STATUS < 90      AND REQ_TYPE    = '06'              ");//DEL BY UBIQ-SUO 2010/12/21 BUG948
                //strSQL.Append("         GROUP BY PO_NO) T2                                              ");//DEL BY UBIQ-SUO 2010/12/21 BUG948
                //strSQL.Append("     WHERE T1.PO_NO       =   T2.PO_NO                                   ");//DEL BY UBIQ-SUO 2010/12/21 BUG948
                //strSQL.Append("     AND   T1.PO_LINE_NO  =   T2.PO_LINE_NO                              ");//DEL BY UBIQ-SUO 2010/12/21 BUG948
                strSQL.Append("     WHERE   T1.XFER_STATUS <   90                                         ");
                strSQL.Append("     AND   T1.REQ_TYPE    =   '06'                                       ");
                strSQL.Append(" ) TR ON  JO.ORDER_NO   = TR.ORDER_NO                                    ");
                //strSQL.Append("  AND    TR.XFER_STATUS      < 90                                        ");
                //strSQL.Append("  AND    TR.REQ_TYPE         = 12                                        ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON  S1.KEY01  = 'ITEM_UMSR'         ");
                strSQL.Append("  AND    S1.KEY02            = JO.ORDER_UMSR                             ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PM ON  TR.FROM_WS_CD   = PM.WS_CD        ");
                strSQL.Append("     AND    PM.PROCESS_CD      = TR.FROM_PROCESS_CD                      ");
                strSQL.Append(" WHERE   JO.ORDER_STATUS     >= 10                                       ");
                strSQL.Append("   AND   JO.ITEM_TYPE        <> '99'   									");
                if (_job_order_no != "")
                {
                    strSQL.Append("  AND    JO.JOB_ORDER_NO     = :JOB_ORDER_NO                         ");
                    db.DbPsetString("JOB_ORDER_NO", _job_order_no);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND    JO.WS_CD            = :WS_CD                                ");
                    db.DbPsetString("WS_CD", _ws_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("  AND    JO.ITEM_NO          = :ITEM_NO                              ");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("  AND    JO.JOC_CD           = :JOC_CD                               ");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }
                if (_beg_compl_date != 0)
                {
                    strSQL.Append("  AND    JO.SCH_COMPL_DATE        >= :BEG_COMPL_DATE                           ");
                    db.DbPsetInt("BEG_COMPL_DATE", _beg_compl_date);
                }
                if (_end_compl_date != 0)
                {
                    strSQL.Append("  AND    JO.SCH_COMPL_DATE        <= :END_COMPL_DATE                           ");
                    db.DbPsetInt("END_COMPL_DATE", _end_compl_date);
                }
                if (_to_lot_no != "")
                {
                    strSQL.Append("  AND    TR.TO_LOT_NO        = :TO_LOT_NO                            ");
                    strSQL.Append("  AND    TR.TO_LOT_NO    is not null                                 ");//ADD BY UBIQ-LIU 20090224
                    db.DbPsetString("TO_LOT_NO", _to_lot_no);
                }

                if (_beg_slip_date != 0)
                {
                    strSQL.Append("  AND    (TR.SLIP_DATE        >= :BEG_SLIP_DATE                      ");
                    strSQL.Append("  or    TR.SLIP_DATE       is null  )                                ");//ADD BY UBIQ-LIU 20090224
                    db.DbPsetInt("@BEG_SLIP_DATE", _beg_slip_date);
                }
                if (_end_slip_date != 0)
                {
                    strSQL.Append("  AND    (TR.SLIP_DATE        <= :END_SLIP_DATE                      ");
                    strSQL.Append("  or    TR.SLIP_DATE       is null)                                  ");//ADD BY UBIQ-LIU 20090224
                    db.DbPsetInt("END_SLIP_DATE", _end_slip_date);
                }
                if (_sch_id != "")
                {
                    strSQL.Append("  AND    JO.SCH_ID           = :SCH_ID                               ");//ADD BY UBIQ-LIU 20090701
                    db.DbPsetString("SCH_ID", _sch_id);
                }

                if (_compl_flag != 0 && _unfinish_flag == 0)
                {
                    strSQL.Append("  AND    JO.ORDER_STATUS  = 85                           ");
                }
                if (_compl_flag == 0 && _unfinish_flag != 0)
                {
                    strSQL.Append("  AND    JO.ORDER_STATUS  < 85                           ");
                }
                if (_compl_flag == 0 && _unfinish_flag == 0)
                {
                    strSQL.Append("  AND    JO.ORDER_STATUS  > 99                           ");
                }

                strSQL.Append("ORDER BY JO.SCH_COMPL_DATE,  JO.JOB_ORDER_NO ASC ");
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER JO                                                       ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON  JO.WS_CD   = WS.WS_CD            ");
                strSQL.Append(" LEFT OUTER JOIN ( SELECT T1.*   FROM TRANSFER_TRANS T1                  ");//UPD BY UBIQ-LIU 2010/6/10 BUG815
                //strSQL.Append("       ,(SELECT PO_NO, MAX(PO_LINE_NO) PO_LINE_NO FROM TRANSFER_TRANS    ");//DEL BY UBIQ-SUO 2010/12/21 BUG948
                //strSQL.Append("         WHERE XFER_STATUS < 90      AND REQ_TYPE    = '06'              ");//DEL BY UBIQ-SUO 2010/12/21 BUG948
                //strSQL.Append("         GROUP BY PO_NO) T2                                              ");//DEL BY UBIQ-SUO 2010/12/21 BUG948
                //strSQL.Append("     WHERE T1.PO_NO       =   T2.PO_NO                                   ");//DEL BY UBIQ-SUO 2010/12/21 BUG948
                //strSQL.Append("     AND   T1.PO_LINE_NO  =   T2.PO_LINE_NO                              ");//DEL BY UBIQ-SUO 2010/12/21 BUG948
                strSQL.Append("     WHERE   T1.XFER_STATUS <   90                                         ");
                strSQL.Append("     AND   T1.REQ_TYPE    =   '06'                                       ");
                strSQL.Append(" ) TR ON  JO.ORDER_NO   = TR.ORDER_NO                                    ");
                //strSQL.Append("  AND    TR.XFER_STATUS      < 90                                        ");
                //strSQL.Append("  AND    TR.REQ_TYPE         = 12                                        ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON  S1.KEY01  = 'ITEM_UMSR'         ");
                strSQL.Append("     AND    S1.KEY02           = JO.ORDER_UMSR                           ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PM ON  TR.FROM_WS_CD   = PM.WS_CD        ");
                strSQL.Append("     AND    PM.PROCESS_CD      = TR.FROM_PROCESS_CD                      ");
                strSQL.Append(" WHERE   JO.ORDER_STATUS     >= 10                                       ");
                strSQL.Append("   AND   JO.ITEM_TYPE        <> '99'   									");
                if (_job_order_no != "")
                {
                    strSQL.Append("  AND    JO.JOB_ORDER_NO     = @JOB_ORDER_NO                         ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND    JO.WS_CD            = @WS_CD                                ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("  AND    JO.ITEM_NO          = @ITEM_NO                              ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("  AND    JO.JOC_CD           = @JOC_CD                               ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (_beg_compl_date != 0)
                {
                    strSQL.Append("  AND    JO.SCH_COMPL_DATE        >= @BEG_COMPL_DATE                           ");
                    db.DbPsetInt("@BEG_COMPL_DATE", _beg_compl_date);
                }
                if (_end_compl_date != 0)
                {
                    strSQL.Append("  AND    JO.SCH_COMPL_DATE        <= @END_COMPL_DATE                           ");
                    db.DbPsetInt("@END_COMPL_DATE", _end_compl_date);
                }
                if (_to_lot_no != "")
                {
                    strSQL.Append("  AND    TR.TO_LOT_NO        = @TO_LOT_NO                            ");
                    strSQL.Append("  AND    TR.TO_LOT_NO    is not null                                 ");//ADD BY UBIQ-LIU 20090224
                    db.DbPsetString("@TO_LOT_NO", _to_lot_no);
                }

                if (_beg_slip_date != 0)
                {
                    strSQL.Append("  AND    (TR.SLIP_DATE        >= @BEG_SLIP_DATE                      ");
                    strSQL.Append("  or    TR.SLIP_DATE       is null  )                                ");//ADD BY UBIQ-LIU 20090224
                    db.DbPsetInt("@BEG_SLIP_DATE", _beg_slip_date);
                }
                if (_end_slip_date != 0)
                {
                    strSQL.Append("  AND    (TR.SLIP_DATE        <= @END_SLIP_DATE                      ");
                    strSQL.Append("  or    TR.SLIP_DATE       is null)                                  ");//ADD BY UBIQ-LIU 20090224
                    db.DbPsetInt("@END_SLIP_DATE", _end_slip_date);
                }
                if (_sch_id != "")
                {
                    strSQL.Append("  AND    JO.SCH_ID           = @SCH_ID                               ");//ADD BY UBIQ-LIU 20090701
                    db.DbPsetString("@SCH_ID", _sch_id);
                }

                if (_compl_flag != 0 && _unfinish_flag == 0)
                {
                    strSQL.Append("  AND    JO.ORDER_STATUS  = 85                           ");
                }
                if (_compl_flag == 0 && _unfinish_flag != 0)
                {
                    strSQL.Append("  AND    JO.ORDER_STATUS  < 85                           ");
                }
                if (_compl_flag == 0 && _unfinish_flag == 0)
                {
                    strSQL.Append("  AND    JO.ORDER_STATUS  > 99                           ");
                }
                strSQL.Append("ORDER BY JO.SCH_COMPL_DATE,  JO.JOB_ORDER_NO ASC ");
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
        /// 作業実績データを検索
        /// </summary>
        public DataSet Get_Mfg_ProgressInqDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append("JO.JOB_ORDER_NO,	    JO.WS_CD,		WS.WS_DESC,     JOD.SCH_START_DATE,     ");
            strSQL.Append("JOD.SCH_COMPL_DATE,   JO.ITEM_NO,	    JO.ITEM_DESC,	JO.JOB_ORDER_QTY,   ");
            //strSQL.Append("JO.ORDER_UMSR,		S1.DATA_CHAR UMSR_NAME ,        JO.JOB_ORDER_COMPL_QTY, ");
            strSQL.Append("JO.ORDER_UMSR,		S1.DATA_CHAR UMSR_NAME ,        JOD.COMPL_QTY,          ");//UPD 2010/07/16 UBIQ-LIU
            strSQL.Append("JO.JOC_CD,           JO.SCH_ID,      JO.WHS_CD,      WHS.WHS_DESC,           ");
            strSQL.Append("JO.INSP_CD,          S3.DATA_CHAR INSP_NAME ,  JO.SLIP_NOTE,     TR.ACT_QTY, ");
            strSQL.Append("TR.ITEM_UMSR,        S2.DATA_CHAR ITEM_UMSR_NAME,        TR.REJ_QTY,         ");
            strSQL.Append(" TR.TO_LOT_NO,       TR.TO_LOCATION LOCATION,                                ");
            strSQL.Append("TR.REQ_USER_ID,      TR.SLIP_DATE,   JOD.PROCESS_CD, PM.PROCESS_DESC,        ");
            //strSQL.Append("RM.UNIT_TIME,        RM.UNIT_QTY,    RM.MFG_LT,      RM.TRANSFER_LT,         ");//DEL UBIQ-LIU 2010/06/12
            //strSQL.Append("RM.LT_TYPE,     RM.SETUP_TIME,  RM.TRANSFER_TIME,    RM.DAILY_PROD_QTY       ");
            //strSQL.Append(",JOD.SCH_WORK_TIME + JOD.SCH_SETUP_TIME + JOD.SCH_TRANSFER_TIME WORKTIME     ");//ADD20090727
            strSQL.Append("(CASE WHEN ISNULL(IW.IDTAG_PRINT_FLAG,1) = 1 THEN                           ");//ADD 20090914
            strSQL.Append("     (CASE WHEN ISNULL(IW.IDTAG_UNIT_QTY,0) = 0 THEN 1                       ");
            strSQL.Append("     ELSE CEILING(ISNULL(TR.ACT_QTY,0)/IW.IDTAG_UNIT_QTY) END)               ");
            strSQL.Append("     ELSE 0 END) LABEL_QTY,                                                  ");
            strSQL.Append(" ISNULL(IW.IDTAG_UNIT_QTY,0) IDTAG_UNIT_QTY,                                 ");
            strSQL.Append(" ISNULL(IW.IDTAG_PRINT_FLAG,1) PRINT_FLAG                                    ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER JO,TRANSFER_TRANS TR,WORKSHOP_MASTER WS,SYSTEM_PARAMETER S1, ");
                strSQL.Append(" WAREHOUSE_MASTER WHS,JOB_ORDER_DETAIL JOD,SYSTEM_PARAMETER S2,          ");
                strSQL.Append(" SYSTEM_PARAMETER S3                                                     ");
                strSQL.Append(" WHERE   JO.ORDER_NO         = TR.ORDER_NO                               ");
                strSQL.Append("  AND    TR.PARTIAL_DELV_COMPL_CNT = :PARTIAL_DELV_COMPL_CNT             ");
                strSQL.Append("  AND    WS.WS_CD            = JO.WS_CD                                  ");
                strSQL.Append("  AND    JO.WHS_CD           = WHS.WHS_CD                                ");
                strSQL.Append("  AND    S1.KEY01            = 'ITEM_UMSR'                               ");
                strSQL.Append("  AND    S1.KEY02            = JO.ORDER_UMSR                             ");
                strSQL.Append("  AND    S2.KEY01            = 'ITEM_UMSR'                               ");
                strSQL.Append("  AND    S2.KEY02            = TR.ITEM_UMSR                              ");
                strSQL.Append("  AND    S3.KEY01            = 'ITEM_UMSR'                               ");
                strSQL.Append("  AND    S3.KEY02            = JO.INSP_CD                                ");
                strSQL.Append("  AND    JO.JOB_ORDER_NO     = :JOB_ORDER_NO                             ");
                strSQL.Append("  AND    JO.JOB_ORDER_NO = JOD.JOB_ORDER_NO                              ");
                strSQL.Append("  AND    JOD.PROCESS_CD     = PM.PROCESS_CD                              ");
                strSQL.Append("  AND    JOD.ITEM_NO        = RM.ITEM_NO                                 ");
                strSQL.Append(" AND JOD.WS_CD   = RM.WS_CD        AND JOD.PROCESS_CD    = RM.PROCESS_CD ");
                strSQL.Append(" AND JOD.PROCESS_SEQ               =         RM.ROUTINE_SEQ              ");
                strSQL.Append(" AND JOD.SCH_START_DATE            >=        RM.BEG_EFF_DATE             ");
                strSQL.Append(" AND JOD.SCH_START_DATE            <=        RM.END_EFF_DATE             ");

                db.DbPsetInt("PARTIAL_DELV_COMPL_CNT", _partial_delv_compl_cnt);
                db.DbPsetString("JOB_ORDER_NO", _job_order_no);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER JO                                                           ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON JO.WS_CD = WS.WS_CD                   ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WHS ON JO.WHS_CD = WHS.WHS_CD              ");
                strSQL.Append(" LEFT OUTER JOIN TRANSFER_TRANS TR ON  JO.ORDER_NO   = TR.ORDER_NO           ");
                strSQL.Append("  AND    TR.PARTIAL_DELV_COMPL_CNT    = @PARTIAL_DELV_COMPL_CNT              ");
                strSQL.Append("  AND    TR.PO_LINE_NO    = @PROCESS_SEQ                                     ");
                strSQL.Append("  AND    TR.XFER_STATUS   < 90                                               ");
                strSQL.Append("  AND    TR.REQ_TYPE      = '06'                                             ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON  S1.KEY01  = 'ITEM_UMSR'             ");
                strSQL.Append("  AND    S1.KEY02            = JO.ORDER_UMSR                                 ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON  S2.KEY01  = 'ITEM_UMSR'             ");
                strSQL.Append("  AND    S2.KEY02            = TR.ITEM_UMSR                                  ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S3 ON  S3.KEY01  = 'INSP_CD'               ");
                strSQL.Append("  AND    S3.KEY02            = JO.INSP_CD                                    ");

                strSQL.Append(" LEFT OUTER JOIN JOB_ORDER_DETAIL JOD ON JO.JOB_ORDER_NO = JOD.JOB_ORDER_NO  ");
                strSQL.Append("                                  AND JOD.PROCESS_SEQ     = @PROCESS_SEQ     ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PM ON JOD.WS_CD     = PM.WS_CD               ");
                strSQL.Append("                                  AND JOD.PROCESS_CD     = PM.PROCESS_CD     ");
                //strSQL.Append(" LEFT OUTER JOIN ROUTINE_MASTER RM ON JOD.ITEM_NO        = RM.ITEM_NO        ");//DEL BY UBIQ-LIU 2010/6/11
                //strSQL.Append(" AND JOD.WS_CD   = RM.WS_CD        AND JOD.PROCESS_CD    = RM.PROCESS_CD     ");
                //strSQL.Append(" AND JOD.PROCESS_SEQ               =         RM.ROUTINE_SEQ                  ");
                //strSQL.Append(" AND JOD.SCH_START_DATE            >=        RM.BEG_EFF_DATE                 ");
                //strSQL.Append(" AND JOD.SCH_START_DATE            <=        RM.END_EFF_DATE                 ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_WS_MASTER IW ON JO.ITEM_NO = IW.ITEM_NO                "); //ADD 20090914
                strSQL.Append("  AND    JO.WS_CD             =       IW.WS_CD                               ");
                strSQL.Append("  AND    JO.SCH_START_DATE    >=      IW.BEG_EFF_DATE                        ");
                strSQL.Append("  AND    JO.SCH_COMPL_DATE    <=      IW.END_EFF_DATE                        ");

                strSQL.Append(" WHERE                                                                       ");
                strSQL.Append(" JO.JOB_ORDER_NO                   =         @JOB_ORDER_NO                   ");

                db.DbPsetInt("@PARTIAL_DELV_COMPL_CNT", _partial_delv_compl_cnt);
                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                db.DbPsetInt("@PROCESS_SEQ", _seq);
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
        /// 入力作業指示№条件でデマンドを検索
        /// </summary>
        public DataSet Get_Mfg_ComplDemandDetail()//ADD 20090211 UBIQ-LIU
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append("JO.ORDER_STATUS,	    D.ITEM_NO,		I.ITEM_DESC,    D.PLAN_QTY,             ");
            strSQL.Append("D.WIP_ALLOC_QTY,     D.INPUT_QTY,	D.ITEM_UMSR,	D.SUB_GRP_CD,           ");
            strSQL.Append("D.AUTO_DISB_TYPE,	D.DEMAND_NO,    S.DATA_CHAR UMSR_NAME,                  ");
            strSQL.Append("(CASE D.USAGE_TYPE WHEN 0 THEN D.USAGE_DEC                                   ");
            strSQL.Append("ELSE D.USAGE_NUMERATOR/D.USAGE_DENOMINATOR END) USAGE_QTY                    ");
            strSQL.Append(",COUNT(D2.ORDER_NO) QTY_FLAG                                                 ");//ADD 20090330 UBIQ-LIU
            //ADD 20090709 UBIQ-CHEN
            strSQL.Append(",isnull(INV.INV_QTY,0) INV_QTY,           isnull(WIP.WIP_QTY,0) WIP_QTY,     ");
            strSQL.Append(" (CASE WHEN (ISNULL(D.ALLOC_QTY,0)-ISNULL(D.ACT_DISB_QTY,0))<0 then 0 ELSE   ");
            strSQL.Append("  (ISNULL(D.ALLOC_QTY,0)-ISNULL(D.ACT_DISB_QTY,0)) END) ALLOC_QTY,           ");
            strSQL.Append(" isnull(WIPALLOC.WIP_ALLOC_QTY,0) W_ALLOC_QTY                                ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER JO,DEMAND D,ITEM_MASTER I                                ");
                strSQL.Append(" WHERE   JO.ORDER_NO         = D.ORDER_NO(+)                             ");
                strSQL.Append(" AND    D.ITEM_NO           = I.ITEM_NO(+)                               ");
                strSQL.Append(" AND    JO.JOB_ORDER_NO     = :JOB_ORDER_NO                              ");
                strSQL.Append(" AND  ( D.SUB_GRP_CD = ''                                                ");
                strSQL.Append(" OR  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1)       )              ");
                strSQL.Append(" AND    D.ITEM_TYPE         <> '99' 			                            ");
                db.DbPsetString("JOB_ORDER_NO", _job_order_no);

            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER JO                                                       ");
                strSQL.Append(" LEFT OUTER JOIN DEMAND D ON     JO.ORDER_NO     =   D.ORDER_NO          ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON D.ITEM_NO      =   I.ITEM_NO           ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'             ");
                strSQL.Append(" AND S.KEY02 = D.ITEM_UMSR                                               ");
                strSQL.Append(" LEFT OUTER JOIN DEMAND D2 ON D2.ORDER_NO      =   JO.ORDER_NO           ");//ADD 20090330 UBIQ-LIU
                strSQL.Append(" AND  D2.SUB_GRP_CD     = D.SUB_GRP_CD                                   ");
                strSQL.Append(" AND    D2.SUB_GRP_CD <> ''                                              ");
                strSQL.Append(" AND    D2.SUB_ACTION_FLAG = 0                                           ");
                strSQL.Append(" AND    D2.ITEM_TYPE  <> '99' 			                                ");

                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON WS.WS_CD = JO.WS_CD               "); // 2011.03.09
                
                //ADD BEGIN 20090709 UBIQ-CHEN
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD,               ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) INV_QTY        ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 0                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                strSQL.Append(" GROUP BY  INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD )  INV ON    ");
                strSQL.Append("      D.ITEM_NO =   INV.ITEM_NO                                          ");
                strSQL.Append(" AND  D.DISB_WHS =   INV.WHS_CD                                          ");
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD,                ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) WIP_QTY        ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 1                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                strSQL.Append(" GROUP BY  INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD  )  WIP  ON   ");
                strSQL.Append("      D.ITEM_NO =   WIP.ITEM_NO                                          ");
                //strSQL.Append(" AND  D.WS_CD =   WIP.WS_CD                                              ");
                strSQL.Append(" AND  WIP.WS_CD =   CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN D.WS_CD ELSE WS.REP_WS_CD END "); // 2011.03.09
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT WIP_ALLOC.DEMAND_NO,SUM(WIP_ALLOC.ALLOC_QTY) WIP_ALLOC_QTY      ");
                strSQL.Append(" FROM    WIP_ALLOC                                                       ");
                strSQL.Append(" WHERE     WIP_ALLOC.ALLOC_STATUS  =   0                                 ");
                strSQL.Append(" AND     WIP_ALLOC.SCH_FLAG      IN (0,2)                                ");
                strSQL.Append(" GROUP BY  WIP_ALLOC.DEMAND_NO   )  WIPALLOC  ON                         ");
                strSQL.Append("      D.DEMAND_NO    =   WIPALLOC.DEMAND_NO                              ");
                //ADD END 20090709 UBIQ-CHEN
                strSQL.Append(" WHERE                                                                   ");
                strSQL.Append(" JO.JOB_ORDER_NO                   =         @JOB_ORDER_NO               ");
                strSQL.Append(" AND  ( D.SUB_GRP_CD = ''                                                ");
                strSQL.Append(" OR  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1)    )                 ");
                strSQL.Append(" AND    D.ITEM_TYPE         <> '99' 			                            ");
                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
            }

            strSQL.Append("GROUP BY   JO.ORDER_STATUS,	    D.ITEM_NO,		I.ITEM_DESC,    D.PLAN_QTY, ");//ADD 20090330 UBIQ-LIU
            strSQL.Append("D.WIP_ALLOC_QTY,     D.INPUT_QTY,	D.ITEM_UMSR,	D.SUB_GRP_CD,           ");
            strSQL.Append("D.AUTO_DISB_TYPE,	D.DEMAND_NO,    S.DATA_CHAR ,     D2.DEMAND_NO  ,       ");
            strSQL.Append("D.USAGE_TYPE,        D.USAGE_DEC,                                            ");
            strSQL.Append("D.USAGE_NUMERATOR,   D.USAGE_DENOMINATOR                                     ");
            strSQL.Append(",isnull(INV.INV_QTY,0),           isnull(WIP.WIP_QTY,0),                     ");
            strSQL.Append(" D.ALLOC_QTY,    D.ACT_DISB_QTY,                                             ");
            strSQL.Append("isnull(WIPALLOC.WIP_ALLOC_QTY,0)                                             ");

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
        /// DEMAND_NOを条件に同じグループのデマンドを検索して代替品目選択画面
        /// </summary>
        public DataSet Get_Mfg_ComplGroupDemandDetail()//ADD 20090211 UBIQ-LIU (**)
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append("D.ITEM_NO,		    I.ITEM_DESC,    D.PLAN_QTY,                             ");
            strSQL.Append("D.WIP_ALLOC_QTY,     D.INPUT_QTY,	D.ITEM_UMSR,	D.SUB_GRP_CD,           ");
            strSQL.Append("D.AUTO_DISB_TYPE,	D.DEMAND_NO,    D.DISB_WHS,                             ");
            strSQL.Append("(CASE D.USAGE_TYPE WHEN 0 THEN D.USAGE_DEC                                   ");
            strSQL.Append("ELSE D.USAGE_NUMERATOR/D.USAGE_DENOMINATOR END) USAGE_QTY                    ");
            //ADD 20090709 UBIQ-CHEN
            strSQL.Append(" ,ISNULL(INV.FREE_QTY,0) I_FREE_QTY,     ISNULL(WIP.FREE_QTY,0) W_FREE_QTY,  ");
            strSQL.Append(" (CASE WHEN (D.ALLOC_QTY-D.ACT_DISB_QTY)<0 then 0                            ");
            strSQL.Append("  ELSE (D.ALLOC_QTY-D.ACT_DISB_QTY) END) ALLOC_QTY,                          ");
            strSQL.Append(" ISNULL(WIPALLOC.WIP_ALLOC_QTY,0) WIP_ALLOC_QTY                              ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM    DEMAND D,ITEM_MASTER I                                          ");
                strSQL.Append(" WHERE                                                                   ");
                strSQL.Append(" D.ITEM_NO           = I.ITEM_NO(+)                                      ");
                strSQL.Append(" AND    D.SUB_GRP_CD IN  (   SELECT SUB_GRP_CD FROM DEMAND               ");
                strSQL.Append(" WHERE  DEMAND_NO    = :DEMAND_NO )                                      ");
                strSQL.Append(" AND    D.ORDER_NO IN  ( SELECT ORDER_NO FROM DEMAND                     ");
                strSQL.Append(" WHERE  DEMAND_NO    = @DEMAND_NO )                                      ");
                strSQL.Append(" AND    D.SUB_GRP_CD <> ''                                               ");
                strSQL.Append(" AND    D.SUB_ACTION_FLAG = 0                                            ");
                strSQL.Append(" AND    D.ITEM_TYPE  <> '99' 			 		                        ");

                db.DbPsetString("DEMAND_NO", _demand_no);

            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM (SELECT *                                                          ");
                strSQL.Append(" FROM    DEMAND                                                          ");
                strSQL.Append(" WHERE   SUB_GRP_CD IN  (SELECT SUB_GRP_CD FROM DEMAND                   ");
                strSQL.Append(" WHERE   DEMAND_NO   =   @DEMAND_NO                                      ");
                strSQL.Append(" ) AND   ORDER_NO    IN  ( SELECT  ORDER_NO FROM DEMAND                  ");
                strSQL.Append(" WHERE   DEMAND_NO   =   @DEMAND_NO   )                                  ");
                //strSQL.Append(" AND   DEMAND_NO   <>   @DEMAND_NO ) D                                    ");
                strSQL.Append(" AND     SUB_GRP_CD         <>   ''                                      ");
                strSQL.Append(" AND     SUB_ACTION_FLAG    =    0  AND ITEM_TYPE         <> '99') D     ");
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,WHS_CD,                                ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) FREE_QTY       ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");//UPD UBIQ-LIU 20090714                
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM      =       0                          ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE=       0                          ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE       = 0                             ");//ADD UBIQ-LIU 20090714                
                strSQL.Append("GROUP BY INVENTORY_DETAIL.ITEM_NO,WHS_CD                                 ");
                strSQL.Append(" ) INV ON    D.ITEM_NO          =   INV.ITEM_NO                          ");
                strSQL.Append(" AND         D.DISB_WHS         =   INV.WHS_CD                           ");

                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON WS.WS_CD = D.WS_CD               "); // 2011.03.09
                
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" ( SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD,               ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) FREE_QTY       ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM      =       0                          ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE=       1                          ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE       = 0                             ");//ADD UBIQ-LIU 20090714                
                strSQL.Append("GROUP BY INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD                 ");
                strSQL.Append(" ) WIP ON    D.ITEM_NO          =   WIP.ITEM_NO                          ");
                //strSQL.Append(" AND         D.WS_CD            =   WIP.WS_CD                            ");
                strSQL.Append(" AND  WIP.WS_CD =   CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN D.WS_CD ELSE WS.REP_WS_CD END "); // 2011.03.09
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" ( SELECT WIP_ALLOC.DEMAND_NO, SUM(WIP_ALLOC.ALLOC_QTY) WIP_ALLOC_QTY    ");
                strSQL.Append(" FROM    WIP_ALLOC                                                       ");
                strSQL.Append(" WHERE   WIP_ALLOC.ALLOC_STATUS    =       0                             ");
                strSQL.Append(" AND     WIP_ALLOC.SCH_FLAG       IN     (0,2)                           ");
                strSQL.Append("GROUP BY WIP_ALLOC.DEMAND_NO                                             ");
                strSQL.Append(" ) WIPALLOC ON  D.DEMAND_NO = WIPALLOC.DEMAND_NO                         ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON  D.ITEM_NO= I.ITEM_NO                  ");

                //strSQL.Append(" FROM DEMAND D                                                           ");
                //strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON D.ITEM_NO      =   I.ITEM_NO           ");

                //strSQL.Append(" WHERE                                                                   ");
                //strSQL.Append(" D.SUB_GRP_CD IN  (   SELECT SUB_GRP_CD FROM DEMAND                      ");
                //strSQL.Append(" WHERE  DEMAND_NO    = @DEMAND_NO )                                      ");
                //strSQL.Append(" AND    D.ORDER_NO IN  ( SELECT ORDER_NO FROM DEMAND                     ");
                //strSQL.Append(" WHERE  DEMAND_NO    = @DEMAND_NO )                                      ");
                //strSQL.Append(" AND    D.SUB_GRP_CD <> ''                                               ");
                //strSQL.Append(" AND    D.SUB_ACTION_FLAG = 0                                            ");
                //strSQL.Append(" AND    D.ITEM_TYPE         <> '99' 			                          ");

                db.DbPsetString("@DEMAND_NO", _demand_no);

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
        /// グループ内使用子部品の切替処理
        /// </summary>
        public int Mfg_Demand_Item_Chg(ComDB db_o)//ADD 20090211 UBIQ-LIU
        {
            //ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db_o.DbParametersClear();

            db_o.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db_o.DbPsetString("@I_FROM_DEMAND_NO", _demand_no, ComConst.DB_IN);
            db_o.DbPsetString("@I_TO_DEMAND_NO", _to_demand_no, ComConst.DB_IN);
            db_o.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db_o.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db_o.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db_o.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db_o.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db_o.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db_o.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db_o.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db_o.DbBeginTrans();
            rtn = db_o.DbStored("SP_MFG_DEMAND_ITEM_CHG");
            rtn = db_o.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                //db.DbCommit();
            }
            else
            {
                _errcode = db_o.DbPgetInt("@O_ERRCODE");
                _errmsg = db_o.DbPgetString("@O_MSG");
                _sqlcode = db_o.DbPgetInt("@O_SQLCODE");
                _dbmsg = db_o.DbPgetString("@O_SQLMSG");
                _proc_name = db_o.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                //db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 完成実績データを検索
        /// <para>使用画面[MfgConsumptionChg]</para>
        /// </summary>
        public DataSet Get_Mfg_CompledDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT   X.* FROM                                                                    ");
            strSQL.Append("(SELECT                                                                               ");
            strSQL.Append("J.JOB_ORDER_NO,      T.PARTIAL_DELV_COMPL_CNT,   J.ITEM_NO,      J.ITEM_DESC,        ");
            strSQL.Append("J.WS_CD,W.WS_DESC,   J.JOB_ORDER_QTY,            T.INST_QTY,     T.REJ_QTY,          ");
            strSQL.Append("T.ITEM_UMSR,         T.SLIP_DATE,                T.TO_LOT_NO,    T.TO_JOC_CD,        ");
            strSQL.Append("T.TO_WHS_CD,         T.XFER_NO,                  T.REQ_USER_ID,                      ");
            strSQL.Append("S.DATA_CHAR UMSR_NAME,   T.FROM_PROCESS_CD,      P.PROCESS_DESC,                     ");//ADD BY UBIQ-LIU 2010/6/12 [工程列追加]
            strSQL.Append("ISNULL(D.INPUT_FLAG,'0') INPUT_FLAG,T.PO_LINE_NO                     ");//ADD BY UBIQ-SUO 2010/12/28 BUG950
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER J                                                        ");
                strSQL.Append(" LEFT OUTER JOIN TRANSFER_TRANS T ON J.ORDER_NO = T.ORDER_NO             ");
                strSQL.Append(" LEFT OUTER JOIN JOB_ORDER_DETAIL D ON J.JOB_ORDER_NO = D.JOB_ORDER_NO   ");//ADD BY UBIQ-SUO 2010/12/28
                strSQL.Append("         AND    D.PROCESS_CD = T.FROM_PROCESS_CD                         ");//ADD BY UBIQ-SUO 2010/12/28
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON J.WS_CD = W.WS_CD                  ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER P ON T.FROM_WS_CD = P.WS_CD              ");
                strSQL.Append("         AND    T.FROM_PROCESS_CD = P.PROCESS_CD                         ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON  S.KEY01  = 'ITEM_UMSR'           ");
                strSQL.Append("         AND    S.KEY02 = T.ITEM_UMSR                                    ");
                strSQL.Append("  WHERE    T.XFER_STATUS < 90                                            ");
                strSQL.Append("         AND T.REQ_TYPE = '06'                                           ");//UPD BY UBIQ-LIU 2010/6/12[12→06]
                strSQL.Append("         AND ISNULL(D.INPUT_FLAG,'0') = '0'                              ");//ADD BY UBIQ-SUO 2010/12/28

                if (_job_order_no != "")
                {
                    strSQL.Append("  AND    J.JOB_ORDER_NO     = :JOB_ORDER_NO                         ");
                    db.DbPsetString("JOB_ORDER_NO", _job_order_no);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND    J.WS_CD            = :WS_CD                                ");
                    db.DbPsetString("WS_CD", _ws_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("  AND    J.ITEM_NO          = :ITEM_NO                              ");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_to_lot_no != "")
                {
                    strSQL.Append("  AND    T.TO_LOT_NO        = :TO_LOT_NO                            ");
                    db.DbPsetString("TO_LOT_NO", _to_lot_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("  AND    J.JOC_CD           = :JOC_CD                               ");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }
                if (_beg_slip_date != 0)
                {
                    strSQL.Append("  AND    T.SLIP_DATE        >= :BEG_SLIP_DATE                       ");
                    db.DbPsetInt("BEG_SLIP_DATE", _beg_slip_date);
                }
                if (_end_slip_date != 0)
                {
                    strSQL.Append("  AND    T.SLIP_DATE        <= :END_SLIP_DATE                       ");
                    db.DbPsetInt("END_SLIP_DATE", _end_slip_date);
                }
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER J                                                        ");
                strSQL.Append(" LEFT OUTER JOIN TRANSFER_TRANS T ON J.ORDER_NO = T.ORDER_NO             ");
                strSQL.Append(" LEFT OUTER JOIN JOB_ORDER_DETAIL D ON J.JOB_ORDER_NO = D.JOB_ORDER_NO   ");//ADD BY UBIQ-SUO 2010/12/28
                strSQL.Append("         AND    D.PROCESS_CD = T.FROM_PROCESS_CD                         ");//ADD BY UBIQ-SUO 2010/12/28
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON J.WS_CD = W.WS_CD                  ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER P ON T.FROM_WS_CD = P.WS_CD              ");
                strSQL.Append("         AND    T.FROM_PROCESS_CD = P.PROCESS_CD                         ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON  S.KEY01  = 'ITEM_UMSR'           ");
                strSQL.Append("         AND    S.KEY02 = T.ITEM_UMSR                                    ");
                strSQL.Append("  WHERE    T.XFER_STATUS < 90                                            ");
                strSQL.Append("         AND T.REQ_TYPE = '06'                                           ");//UPD BY UBIQ-LIU 2010/6/12[12→06]
                strSQL.Append("         AND ISNULL(D.INPUT_FLAG,'0') = '0'                              ");//ADD BY UBIQ-SUO 2010/12/28

                if (_job_order_no != "")
                {
                    strSQL.Append("  AND    J.JOB_ORDER_NO     = @JOB_ORDER_NO                         ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND    J.WS_CD            = @WS_CD                                ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("  AND    J.ITEM_NO          = @ITEM_NO                              ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_to_lot_no != "")
                {
                    strSQL.Append("  AND    T.TO_LOT_NO        = @TO_LOT_NO                            ");
                    db.DbPsetString("@TO_LOT_NO", _to_lot_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("  AND    J.JOC_CD           = @JOC_CD                               ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (_beg_slip_date != 0)
                {
                    strSQL.Append("  AND    T.SLIP_DATE        >= @BEG_SLIP_DATE                       ");
                    db.DbPsetInt("@BEG_SLIP_DATE", _beg_slip_date);
                }
                if (_end_slip_date != 0)
                {
                    strSQL.Append("  AND    T.SLIP_DATE        <= @END_SLIP_DATE                       ");
                    db.DbPsetInt("@END_SLIP_DATE", _end_slip_date);
                }
            }
            //ADD BY UBIQ-SUO 2010/12/28  START
            strSQL.Append("UNION ALL                                                                               ");
            strSQL.Append("SELECT                                                                               ");
            strSQL.Append("J.JOB_ORDER_NO,      T.PARTIAL_DELV_COMPL_CNT,   J.ITEM_NO,      J.ITEM_DESC,        ");
            strSQL.Append("J.WS_CD,W.WS_DESC,   J.JOB_ORDER_QTY,            T.INST_QTY,     T.REJ_QTY,          ");
            strSQL.Append("T.ITEM_UMSR,         T.SLIP_DATE,                T.TO_LOT_NO,    T.TO_JOC_CD,        ");
            strSQL.Append("T.TO_WHS_CD,         T.XFER_NO,                  T.REQ_USER_ID,                      ");
            strSQL.Append("S.DATA_CHAR UMSR_NAME,   T.FROM_PROCESS_CD,      P.PROCESS_DESC,                     ");
            strSQL.Append("ISNULL(D.INPUT_FLAG,'0') INPUT_FLAG,T.PO_LINE_NO                      ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER J                                                        ");
                strSQL.Append(" LEFT OUTER JOIN TRANSFER_TRANS T ON J.ORDER_NO = T.ORDER_NO             ");
                strSQL.Append(" LEFT OUTER JOIN JOB_ORDER_DETAIL D ON J.JOB_ORDER_NO = D.JOB_ORDER_NO   ");
                strSQL.Append("         AND    D.PROCESS_CD = T.FROM_PROCESS_CD                         ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON J.WS_CD = W.WS_CD                  ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER P ON T.FROM_WS_CD = P.WS_CD              ");
                strSQL.Append("         AND    T.FROM_PROCESS_CD = P.PROCESS_CD                         ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON  S.KEY01  = 'ITEM_UMSR'           ");
                strSQL.Append("         AND    S.KEY02 = T.ITEM_UMSR                                    ");
                strSQL.Append("  WHERE    T.XFER_STATUS < 90                                            ");
                strSQL.Append("         AND T.REQ_TYPE = '62'                                           ");
                strSQL.Append("         AND ISNULL(D.INPUT_FLAG,'0') = '1'                                  ");

                if (_job_order_no != "")
                {
                    strSQL.Append("  AND    J.JOB_ORDER_NO     = :JOB_ORDER_NO                         ");
                    db.DbPsetString("JOB_ORDER_NO", _job_order_no);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND    J.WS_CD            = :WS_CD                                ");
                    db.DbPsetString("WS_CD", _ws_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("  AND    J.ITEM_NO          = :ITEM_NO                              ");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_to_lot_no != "")
                {
                    strSQL.Append("  AND    T.TO_LOT_NO        = :TO_LOT_NO                            ");
                    db.DbPsetString("TO_LOT_NO", _to_lot_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("  AND    J.JOC_CD           = :JOC_CD                               ");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }
                if (_beg_slip_date != 0)
                {
                    strSQL.Append("  AND    T.SLIP_DATE        >= :BEG_SLIP_DATE                       ");
                    db.DbPsetInt("BEG_SLIP_DATE", _beg_slip_date);
                }
                if (_end_slip_date != 0)
                {
                    strSQL.Append("  AND    T.SLIP_DATE        <= :END_SLIP_DATE                       ");
                    db.DbPsetInt("END_SLIP_DATE", _end_slip_date);
                }
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER J                                                        ");
                strSQL.Append(" LEFT OUTER JOIN TRANSFER_TRANS T ON J.ORDER_NO = T.ORDER_NO             ");
                strSQL.Append(" LEFT OUTER JOIN JOB_ORDER_DETAIL D ON J.JOB_ORDER_NO = D.JOB_ORDER_NO   ");//ADD BY UBIQ-SUO 2010/12/28
                strSQL.Append("         AND    D.PROCESS_CD = T.FROM_PROCESS_CD                         ");//ADD BY UBIQ-SUO 2010/12/28
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON J.WS_CD = W.WS_CD                  ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER P ON T.FROM_WS_CD = P.WS_CD              ");
                strSQL.Append("         AND    T.FROM_PROCESS_CD = P.PROCESS_CD                         ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON  S.KEY01  = 'ITEM_UMSR'           ");
                strSQL.Append("         AND    S.KEY02 = T.ITEM_UMSR                                    ");
                strSQL.Append("  WHERE    T.XFER_STATUS < 90                                            ");
                strSQL.Append("         AND T.REQ_TYPE = '62'                                           ");//UPD BY UBIQ-LIU 2010/6/12[12→06]
                strSQL.Append("         AND ISNULL(D.INPUT_FLAG,'0') = '1'                                  ");//ADD BY UBIQ-SUO 2010/12/28

                if (_job_order_no != "")
                {
                    strSQL.Append("  AND    J.JOB_ORDER_NO     = @JOB_ORDER_NO                         ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND    J.WS_CD            = @WS_CD                                ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("  AND    J.ITEM_NO          = @ITEM_NO                              ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_to_lot_no != "")
                {
                    strSQL.Append("  AND    T.TO_LOT_NO        = @TO_LOT_NO                            ");
                    db.DbPsetString("@TO_LOT_NO", _to_lot_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("  AND    J.JOC_CD           = @JOC_CD                               ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (_beg_slip_date != 0)
                {
                    strSQL.Append("  AND    T.SLIP_DATE        >= @BEG_SLIP_DATE                       ");
                    db.DbPsetInt("@BEG_SLIP_DATE", _beg_slip_date);
                }
                if (_end_slip_date != 0)
                {
                    strSQL.Append("  AND    T.SLIP_DATE        <= @END_SLIP_DATE                       ");
                    db.DbPsetInt("@END_SLIP_DATE", _end_slip_date);
                }
            }
            //ADD BY UBIQ-SUO 2010/12/28  END

            strSQL.Append(") X ORDER BY X.JOB_ORDER_NO,   X.PARTIAL_DELV_COMPL_CNT,   X.PO_LINE_NO    "); //UPD BY UBIQ-SUO 2010/12/29 BUG950

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
        /// 受払履歴、デマンドを検索
        /// </summary>
        public DataSet Get_Mfg_ComplDisbDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                               ");
            strSQL.Append("RCV.ITEM_NO,                         RCV.ITEM_DESC,                                  ");
            strSQL.Append("USAGE_QTY = CASE ISNULL(D.USAGE_TYPE,2) WHEN 0 THEN D.USAGE_DEC                      ");
            strSQL.Append("WHEN 1 THEN D.USAGE_NUMERATOR/D.USAGE_DENOMINATOR ELSE 0 END,                        ");
            //ADD 2009.08.20
            strSQL.Append("PLAN_QTY = CASE ISNULL(D.USAGE_TYPE,2) WHEN 0 THEN D.USAGE_DEC                      ");
            strSQL.Append("WHEN 1 THEN D.USAGE_NUMERATOR/D.USAGE_DENOMINATOR ELSE 0 END,                        ");
            //strSQL.Append("ISNULL(D.PLAN_QTY,0) PLAN_QTY,       ISNULL(D.WIP_ALLOC_QTY,0) WIP_ALLOC_QTY,        ");
            strSQL.Append("D.INPUT_QTY INPUT_QTY2,                    ");      //ADD UBIQ-SAI 09.08.07

            //upd 2009.06.30
            strSQL.Append("ISNULL(D.INPUT_QTY,SUM(RCV.QTY)) INPUT_QTY,     SUM(RCV.QTY) QTY,                    ");
            strSQL.Append("RCV.ITEM_UMSR,                       ISNULL(D.SUB_GRP_CD,'')	SUB_GRP_CD,	            ");
            strSQL.Append("ISNULL(D.AUTO_DISB_TYPE,             ISNULL(I.AUTO_DISB_TYPE,0)) AUTO_DISB_TYPE,     ");
            strSQL.Append("ISNULL(D.DEMAND_NO,'') TO_DEMAND_NO, ISNULL(D.DEMAND_NO,'')	DEMAND_NO,              ");
            strSQL.Append("RCV.PARENT_XFER_NO,                  SUM(RCV.QTY) PLAN_INPUT_QTY,                    ");
            strSQL.Append("0 AS CHG_FLAG,                       S.DATA_CHAR UMSR_NAME                           ");
            strSQL.Append(",COUNT(D2.ORDER_NO) QTY_FLAG,                                                        ");//ADD 20090330 UBIQ-LIU
            strSQL.Append("FROM_WHS_CD = CASE WHEN ISNULL(RCV.FROM_WHS_CD,'') = '' THEN ISNULL(D.DISB_WHS,'') ELSE RCV.FROM_WHS_CD END  ");//ADD 20090330 UBIQ-LIU
            //ADD 20090709 UBIQ-CHEN
            strSQL.Append(",isnull(INV.INV_QTY,0) INV_QTY,           isnull(WIP.WIP_QTY,0) WIP_QTY              ");
            //strSQL.Append(" (CASE WHEN (ISNULL(D.ALLOC_QTY,0)-ISNULL(D.ACT_DISB_QTY,0))<0 then 0 ELSE (ISNULL(D.ALLOC_QTY,0)-ISNULL(D.ACT_DISB_QTY,0)) END) ALLOC_QTY,       ");
            //strSQL.Append("isnull(WIPALLOC.WIP_ALLOC_QTY,0) W_ALLOC_QTY                                         ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM RCV_DISB_TRANS RCV                                                 ");
                strSQL.Append(" LEFT OUTER JOIN DEMAND D ON RCV.FROM_MNG_NO = D.DEMAND_NO               ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON RCV.ITEM_NO = I.ITEM_NO                ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'             ");
                strSQL.Append(" AND RCV.ITEM_UMSR = S.KEY02                                             ");

                strSQL.Append("  WHERE                                                                  ");
                strSQL.Append("  RCV.PARENT_XFER_NO     = :XFER_NO                                      ");
                db.DbPsetString("XFER_NO", _xfer_no);

                strSQL.Append(" GROUP BY                                                                ");
                strSQL.Append(" RCV.ITEM_NO,                RCV.ITEM_DESC,                              ");
                strSQL.Append(" CASE ISNULL(D.USAGE_TYPE,2) WHEN 0 THEN D.USAGE_DEC                     ");
                strSQL.Append(" WHEN 1 THEN D.USAGE_NUMERATOR/D.USAGE_DENOMINATOR ELSE 0 END,           ");
                strSQL.Append(" ISNULL(D.PLAN_QTY,0),       ISNULL(D.WIP_ALLOC_QTY,0),                  ");
                strSQL.Append(" ISNULL(D.INPUT_QTY,0) ,     RCV.ITEM_UMSR,      ISNULL(D.SUB_GRP_CD,''),");
                strSQL.Append(" ISNULL(D.AUTO_DISB_TYPE,    ISNULL(I.AUTO_DISB_TYPE,0)),                ");
                strSQL.Append(" ISNULL(D.DEMAND_NO,''),     ISNULL(D.DEMAND_NO,''),                     ");
                strSQL.Append(" RCV.PARENT_XFER_NO,         S.DATA_CHAR                                 ");
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM RCV_DISB_TRANS RCV                                                 ");
                strSQL.Append(" LEFT OUTER JOIN DEMAND D ON RCV.FROM_MNG_NO = D.DEMAND_NO               ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON RCV.ITEM_NO = I.ITEM_NO                ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'             ");
                strSQL.Append(" AND RCV.ITEM_UMSR = S.KEY02                                             ");
                
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON WS.WS_CD = D.WS_CD               "); // 2011.03.09

                strSQL.Append(" LEFT OUTER JOIN DEMAND D2 ON D2.SUB_GRP_CD     = D.SUB_GRP_CD           ");//ADD 20090330 UBIQ-LIU
                strSQL.Append(" AND    D2.ORDER_NO   = RCV.ORDER_NO                                     ");//ADD 20090702 UBIQ-SAI
                strSQL.Append(" AND    D2.SUB_GRP_CD <> ''                                              ");
                strSQL.Append(" AND    D2.SUB_ACTION_FLAG = 0                                           ");
                strSQL.Append(" AND    D2.ITEM_TYPE        <> '99' 			                            ");
                //ADD BEGIN 20090709 UBIQ-CHEN
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD,               ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) INV_QTY        ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 0                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                strSQL.Append(" GROUP BY  INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD )  INV ON    ");
                strSQL.Append("      D.ITEM_NO =   INV.ITEM_NO                                          ");
                strSQL.Append(" AND  D.DISB_WHS =   INV.WHS_CD                                          ");
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD,                ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) WIP_QTY        ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 1                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                strSQL.Append(" GROUP BY  INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD  )  WIP  ON   ");
                strSQL.Append("      D.ITEM_NO =   WIP.ITEM_NO                                          ");
                //strSQL.Append(" AND  D.WS_CD =   WIP.WS_CD                                              ");
                strSQL.Append(" AND  WIP.WS_CD =   CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN D.WS_CD ELSE WS.REP_WS_CD END "); // 2011.03.09

                //del 2009.08.20
                //strSQL.Append(" LEFT OUTER JOIN                                                         ");
                //strSQL.Append(" (SELECT WIP_ALLOC.DEMAND_NO,SUM(WIP_ALLOC.ALLOC_QTY) WIP_ALLOC_QTY      ");
                //strSQL.Append(" FROM    WIP_ALLOC                                                       ");
                //strSQL.Append(" WHERE     WIP_ALLOC.ALLOC_STATUS  =   0                                 ");
                //strSQL.Append(" AND     WIP_ALLOC.SCH_FLAG      IN (0,2)                                ");
                //strSQL.Append(" GROUP BY  WIP_ALLOC.DEMAND_NO   )  WIPALLOC  ON                         ");
                //strSQL.Append("      D.DEMAND_NO    =   WIPALLOC.DEMAND_NO                              ");
                //ADD END 20090709 UBIQ-CHEN
                strSQL.Append("  WHERE                                                                  ");
                strSQL.Append("  RCV.PARENT_XFER_NO     = @XFER_NO                                      ");
                db.DbPsetString("@XFER_NO", _xfer_no);
                strSQL.Append(" AND    RCV.REQ_TYPE        = '81' 			                            ");

                strSQL.Append(" GROUP BY                                                                ");
                strSQL.Append("RCV.ITEM_NO,                         RCV.ITEM_DESC,                      ");
                strSQL.Append("CASE ISNULL(D.USAGE_TYPE,2) WHEN 0 THEN D.USAGE_DEC                      ");
                strSQL.Append("WHEN 1 THEN D.USAGE_NUMERATOR/D.USAGE_DENOMINATOR ELSE 0 END,            ");
                //strSQL.Append("ISNULL(D.PLAN_QTY,0),                ISNULL(D.WIP_ALLOC_QTY,0),          ");//del 2009.08.20
                strSQL.Append("RCV.ITEM_UMSR,                       ISNULL(D.SUB_GRP_CD,''),	        ");
                strSQL.Append("ISNULL(D.AUTO_DISB_TYPE,             ISNULL(I.AUTO_DISB_TYPE,0)),        ");
                strSQL.Append("ISNULL(D.DEMAND_NO,''),              ISNULL(D.DEMAND_NO,''),             ");
                strSQL.Append("RCV.PARENT_XFER_NO,                                                      ");
                //strSQL.Append("0 AS CHG_FLAG,                       S.DATA_CHAR UMSR_NAME               ");   //DEL UBIQ-SAI 09.08.07
                strSQL.Append("S.DATA_CHAR,              D.INPUT_QTY, ");   //ADD UBIQ-SAI 09.08.07
                //strSQL.Append(",COUNT(D2.ORDER_NO) QTY_FLAG,                                            ");   //DEL UBIQ-SAI 09.08.07
                strSQL.Append("CASE WHEN ISNULL(RCV.FROM_WHS_CD,'') = '' THEN ISNULL(D.DISB_WHS,'') ELSE RCV.FROM_WHS_CD END  ");
                strSQL.Append(",isnull(INV.INV_QTY,0),           isnull(WIP.WIP_QTY,0)                  ");
                //strSQL.Append(" (CASE WHEN (ISNULL(D.ALLOC_QTY,0)-ISNULL(D.ACT_DISB_QTY,0))<0 then 0 ELSE (ISNULL(D.ALLOC_QTY,0)-ISNULL(D.ACT_DISB_QTY,0)) END),       ");
                //strSQL.Append("isnull(WIPALLOC.WIP_ALLOC_QTY,0)                                         ");
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
        /// 消費子部品変更処理y>
        /// </summary>
        public int Mfg_Consumption_Chg(ComDB db)//ADD 20090423 UBIQ-CHEN
        {
            //ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PARENT_XFER_NO", _xfer_no, ComConst.DB_IN);
            db.DbPsetString("@I_FROM_DEMAND_NO", _demand_no, ComConst.DB_IN);
            db.DbPsetString("@I_TO_DEMAND_NO", _to_demand_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            //db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_INPUT_QTY", _input_qty, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_TYPE", _update_type, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_MFG_CONSUMPTION_CHG");
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
        /// 消費子部品ロット変更処理
        /// </summary>
        public int Mfg_Consumption_LotChg(ComDB db)//ADD 20090423 UBIQ-CHEN
        {
            //ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PARENT_XFER_NO", _xfer_no, ComConst.DB_IN);
            db.DbPsetInt("@I_SLIP_LINE_NO", _slip_line_no, ComConst.DB_IN);
            db.DbPsetString("@I_DEMAND_NO", _demand_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION", _location, ComConst.DB_IN);
            db.DbPsetString("@I_LOT_NO", _lot_no, ComConst.DB_IN);
            db.DbPsetString("@I_JOC_CD", _joc_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_INPUT_QTY", _input_qty, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_MFG_CONSUMPTION_LOTCHG");
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
        /// 受払履歴、在庫明細、デマンドを検索
        /// </summary>
        public DataSet Get_Mfg_Consumption_LotDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                                       ");
            //strSQL.Append("RCV.FROM_WHS_CD,     RCV.ITEM_NO,            RCV.ITEM_DESC,          RCV.FROM_LOCATION,      ");
            //strSQL.Append("RCV.FROM_LOT_NO,     RCV.FROM_JOC_CD,        INV.INV_BAL,            INV.ALLOC_QTY,          ");
            //strSQL.Append("RCV.QTY,             RCV.PARENT_XFER_NO,     RCV.FROM_MNG_NO,        RCV.QTY PLAN_INPUT_QTY  ");
            //upd 2009.06.23
            strSQL.Append("INV.WHS_CD,     INV.LOCATION,        INV.LOT_NO,             INV.JOC_CD,         ");
            strSQL.Append("INV.INV_BAL,    INV.ALLOC_QTY,       ISNULL(RCV.QTY,0) QTY,  @XFER_NO PARENT_XFER_NO, ");
            strSQL.Append("ISNULL(RCV.SLIP_LINE_NO,0) SLIP_LINE_NO,                     @DEMAND_NO FROM_MNG_NO,    ");
            strSQL.Append("ISNULL(RCV.QTY,0) PLAN_INPUT_QTY                                                           ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL INV                                               ");
                strSQL.Append(" LEFT OUTER JOIN RCV_DISB_TRANS RCV ON                                   ");
                strSQL.Append(" INV.WHS_CD=RCV.FROM_WHS_CD AND INV.WS_CD=RCV.FROM_WS_CD                 ");
                strSQL.Append(" AND INV.ITEM_NO=RCV.ITEM_NO AND INV.LOCATION=RCV.FROM_LOCATION          ");
                strSQL.Append(" AND INV.LOT_NO=RCV.FROM_LOT_NO AND INV.JOC_CD=RCV.FROM_JOC_CD           ");
                strSQL.Append(" AND RCV.PARENT_XFER_NO     = :XFER_NO                                      ");
                strSQL.Append(" AND RCV.FROM_MNG_NO     = :DEMAND_NO                                   ");
                strSQL.Append(" AND RCV.ITEM_NO     = :ITEM_NO                                         ");
                strSQL.Append(" AND RCV.REQ_TYPE     = '81'                                            ");
                strSQL.Append(" WHERE                                                                  ");
                db.DbPsetString("XFER_NO", _xfer_no);
                db.DbPsetString("DEMAND_NO", _demand_no);
                db.DbPsetString("ITEM_NO", _item_no);
                strSQL.Append("  INV.INV_YM=0 AND INV.INV_TYPE=0                                    ");
                //みなし出庫の場合、倉庫在庫、みなし出庫でない場合、仕掛在庫
                strSQL.Append("  AND INV.INV_WIP_TYPE=:AUTO_DISB_TYPE                              ");
                strSQL.Append("  AND INV.ITEM_NO     = :ITEM_NO                                         ");
                if (auto_disb_type == 1)
                {
                    strSQL.Append("  AND INV.WHS_CD     = :WHS_CD                                       ");
                }
                else
                {
                    strSQL.Append("  AND INV.WS_CD     = :WS_CD                                         ");
                }

                db.DbPsetInt("AUTO_DISB_TYPE", _auto_disb_type);
                db.DbPsetString("WHS_CD", _whs_cd);
                db.DbPsetString("WS_CD", _ws_cd);

            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL INV                                               ");
                strSQL.Append(" LEFT OUTER JOIN RCV_DISB_TRANS RCV ON                                   ");
                strSQL.Append(" INV.WHS_CD=RCV.FROM_WHS_CD AND INV.WS_CD=RCV.FROM_WS_CD                 ");
                strSQL.Append(" AND INV.ITEM_NO=RCV.ITEM_NO AND INV.LOCATION=RCV.FROM_LOCATION          ");
                strSQL.Append(" AND INV.LOT_NO=RCV.FROM_LOT_NO AND INV.JOC_CD=RCV.FROM_JOC_CD           ");
                strSQL.Append(" AND RCV.PARENT_XFER_NO     = @XFER_NO                                      ");
                strSQL.Append(" AND RCV.FROM_MNG_NO     = @DEMAND_NO                                   ");
                strSQL.Append(" AND RCV.ITEM_NO     = @ITEM_NO                                         ");
                strSQL.Append(" AND RCV.REQ_TYPE     = '81'                                            ");

                strSQL.Append("  WHERE                                                                  ");
                strSQL.Append("  INV.INV_YM=0 AND INV.INV_TYPE=0                                    ");
                //みなし出庫の場合、倉庫在庫、みなし出庫でない場合、仕掛在庫
                strSQL.Append("  AND INV.ITEM_NO     = @ITEM_NO                                         ");
                if (auto_disb_type == 1)
                {
                    strSQL.Append("  AND INV.WHS_CD     = @WHS_CD                                       ");
                    strSQL.Append("  AND INV.INV_WIP_TYPE=0                                             ");
                }
                else
                {
                    strSQL.Append("  AND INV.WS_CD     = @WS_CD                                         ");
                    strSQL.Append("  AND INV.INV_WIP_TYPE=1                                             ");
                }

                db.DbPsetString("@XFER_NO", _xfer_no);
                db.DbPsetString("@DEMAND_NO", _demand_no);
                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetInt("@AUTO_DISB_TYPE", _auto_disb_type);
                db.DbPsetString("@WHS_CD", _whs_cd);
                db.DbPsetString("@WS_CD", _ws_cd);

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
        /// 作業実績、工数実績データを検索する
        /// </summary>
        public DataSet Get_Mfg_ActManHourList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            db.DbParametersClear();
            if (compl_flag == 1)
            {
                strSQL.Append(" SELECT                                                                                      ");
                strSQL.Append(" J.JOB_ORDER_NO,     T.PARTIAL_DELV_COMPL_CNT,   J.ITEM_NO,      J.ITEM_DESC,                ");
                strSQL.Append(" T.INST_QTY,         J.ORDER_UMSR,               ISNULL(M.REQ_USER_ID, '') REQ_USER_ID,      ");
                //strSQL.Append(" ISNULL(M.WORKING_HOURS, 0) WORKING_HOURS,       S.DATA_CHAR UMSR_NAME                     ");     //Del 2012.06.08 Ubiq-Sai
                strSQL.Append(" ISNULL(M.WORKING_HOURS, 0) WORKING_HOURS,       S.DATA_CHAR UMSR_NAME, M.WORKING_DATE       ");     //Add 2012.06.08 Ubiq-Sai

                if (_db_type == "ORACLE")
                {
                    strSQL.Append(" FROM TRANSFER_TRANS T                                                                   ");
                    strSQL.Append(" INNER JOIN JOB_ORDER J ON T.ORDER_NO = J.ORDER_NO                                       ");
                    strSQL.Append("  AND T.XFER_STATUS <	90                                                              ");
                    strSQL.Append("  AND T.REQ_TYPE ='12'                                                                   ");
                    strSQL.Append(" LEFT OUTER JOIN MAN_HOUR_RESULTS M ON T.SLIP_NO = M.JOB_ORDER_NO                        ");
                    strSQL.Append(" AND T.PARTIAL_DELV_COMPL_CNT = M.PARTIAL_DELV_COMPL_CNT                                 ");
                    strSQL.Append("  AND M.WORKING_DATE = :WORKING_DATE                                                     ");
                    db.DbPsetInt("WORKING_DATE", _working_date);
                    if (req_user_id != "")
                    {
                        strSQL.Append("  AND M.REQ_USER_ID =:REQ_USER_ID               ");
                        db.DbPsetString("REQ_USER_ID", _req_user_id);
                    }
                    strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = J.ORDER_UMSR  ");

                    strSQL.Append("  WHERE                                              ");

                    strSQL.Append("  J.ORDER_STATUS = 85                                ");

                    if (ws_cd != "")
                    {
                        strSQL.Append("  AND J.WS_CD = :WS_CD               ");
                        db.DbPsetString("WS_CD", _ws_cd);
                    }
                    if (item_no != "")
                    {
                        strSQL.Append("  AND J.ITEM_NO = :ITEM_NO               ");
                        db.DbPsetString("ITEM_NO", _item_no);
                    }
                    if (sch_compl_date_from != 0)
                    {
                        strSQL.Append("  AND J.SCH_COMPL_DATE >= :SCH_COMPL_DATE_FROM         ");
                        db.DbPsetInt("SCH_COMPL_DATE_FROM", _sch_compl_date_from);
                    }
                    if (sch_compl_date_to != 0)
                    {
                        strSQL.Append("  AND J.SCH_COMPL_DATE <= :SCH_COMPL_DATE_TO           ");
                        db.DbPsetInt("SCH_COMPL_DATE_TO", _sch_compl_date_to);
                    }
                    if (sch_compl_date_from != 0)
                    {
                        strSQL.Append("  AND T.SLIP_DATE >= :JOB_ORDER_COMPL_DATE_FROM         ");
                        db.DbPsetInt("@JOB_ORDER_COMPL_DATE_FROM", _job_order_compl_date_from);
                    }
                    if (sch_compl_date_to != 0)
                    {
                        strSQL.Append("  AND T.SLIP_DATE <= :JOB_ORDER_COMPL_DATE_TO           ");
                        db.DbPsetInt("JOB_ORDER_COMPL_DATE_TO", _sch_compl_date_to);
                    }
                }
                else
                {
                    strSQL.Append(" FROM TRANSFER_TRANS T                                                                   ");
                    strSQL.Append(" INNER JOIN JOB_ORDER J ON T.ORDER_NO = J.ORDER_NO                                       ");
                    strSQL.Append(" LEFT JOIN JOB_ORDER_DETAIL D ON T.ORDER_NO = D.ORDER_NO AND T.PO_LINE_NO = D.PROCESS_SEQ "); //Add 2012.04.05 Ubiq-Sai
                    //strSQL.Append("  AND T.XFER_STATUS <	90                                                              ");  //Del 2012.04.05 Ubiq-Sai
                    //strSQL.Append("  AND T.REQ_TYPE ='12'                                                                 ");  //Del 2012.04.05 Ubiq-Sai
                    strSQL.Append(" LEFT OUTER JOIN MAN_HOUR_RESULTS M ON T.SLIP_NO = M.JOB_ORDER_NO                        ");
                    strSQL.Append(" AND T.PARTIAL_DELV_COMPL_CNT = M.PARTIAL_DELV_COMPL_CNT                                 ");
                    strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = J.ORDER_UMSR  ");
                    strSQL.Append("  WHERE                                                                                  ");
                    //strSQL.Append("  J.ORDER_STATUS = 85                                                                  ");  //Del 2012.04.05 Ubiq-Sai
                    strSQL.Append("  J.ORDER_STATUS <= 85                                                                   ");
                    strSQL.Append("  AND T.XFER_STATUS < 90                                                                 ");
                    strSQL.Append("  AND T.REQ_TYPE ='06'                                                                   ");  //Add 2012.04.05 Ubiq-Sai
                    strSQL.Append("  AND ISNULL(D.LAST_FLAG, 1) = 1                                                         ");  //Add 2012.04.05 Ubiq-Sai
                    //strSQL.Append("  AND M.WORKING_DATE = @WORKING_DATE                                                   ");  //Del 2012.06.08 Ubiq-Sai
                    //db.DbPsetInt("@WORKING_DATE", _working_date);     //Del 2012.06.08 Ubiq-Sai

                    if (req_user_id != "")
                    {
                        strSQL.Append("  AND M.REQ_USER_ID = @REQ_USER_ID                       ");
                        db.DbPsetString("@REQ_USER_ID", _req_user_id);
                    }

                    if (ws_cd != "")
                    {
                        strSQL.Append("  AND J.WS_CD = @WS_CD                                   ");
                        db.DbPsetString("@WS_CD", _ws_cd);
                    }
                    if (item_no != "")
                    {
                        strSQL.Append("  AND J.ITEM_NO = @ITEM_NO                               ");
                        db.DbPsetString("@ITEM_NO", _item_no);
                    }
                    if (sch_compl_date_from != 0)
                    {
                        strSQL.Append("  AND J.SCH_COMPL_DATE >= @SCH_COMPL_DATE_FROM           ");
                        db.DbPsetInt("@SCH_COMPL_DATE_FROM", _sch_compl_date_from);
                    }
                    if (sch_compl_date_to != 0)
                    {
                        strSQL.Append("  AND J.SCH_COMPL_DATE <= @SCH_COMPL_DATE_TO             ");
                        db.DbPsetInt("@SCH_COMPL_DATE_TO", _sch_compl_date_to);
                    }
                    if (job_order_compl_date_from != 0)
                    {
                        strSQL.Append("  AND T.SLIP_DATE >= @JOB_ORDER_COMPL_DATE_FROM          ");
                        db.DbPsetInt("@JOB_ORDER_COMPL_DATE_FROM", _job_order_compl_date_from);
                    }
                    if (job_order_compl_date_to != 0)
                    {
                        strSQL.Append("  AND T.SLIP_DATE <= @JOB_ORDER_COMPL_DATE_TO            ");
                        db.DbPsetInt("@JOB_ORDER_COMPL_DATE_TO", _job_order_compl_date_to);
                    }
                }
            }
            if (unfinish_flag == 1)
            {
                if (compl_flag == 1)
                {
                    strSQL.Append(" UNION ALL SELECT                                                                      ");
                }
                else
                {
                    strSQL.Append(" SELECT                                                                                ");
                }
                strSQL.Append(" J.JOB_ORDER_NO,     ISNULL(T.PARTIAL_DELV_COMPL_CNT,J.COMPL_CNT+1) PARTIAL_DELV_COMPL_CNT,  ");
                strSQL.Append(" J.ITEM_NO,          J.ITEM_DESC,        ISNULL(T.INST_QTY, 0) INST_QTY,     J.ORDER_UMSR,   ");
                strSQL.Append(" ISNULL(M.REQ_USER_ID, '') REQ_USER_ID,      ISNULL(M.WORKING_HOURS, 0) WORKING_HOURS,       ");
                strSQL.Append(" S.DATA_CHAR UMSR_NAME                                                                       ");

                if (_db_type == "ORACLE")
                {
                    strSQL.Append(" FROM TRANSFER_TRANS T                                                                   ");
                    strSQL.Append(" INNER JOIN JOB_ORDER J ON T.ORDER_NO = J.ORDER_NO                                       ");
                    strSQL.Append("  AND T.XFER_STATUS <	90                                                              ");
                    strSQL.Append("  AND T.REQ_TYPE ='12'                                                                   ");
                    strSQL.Append(" LEFT OUTER JOIN MAN_HOUR_RESULTS M ON T.SLIP_NO = M.JOB_ORDER_NO                        ");
                    strSQL.Append(" AND T.PARTIAL_DELV_COMPL_CNT = M.PARTIAL_DELV_COMPL_CNT                                 ");
                    strSQL.Append("  AND M.WORKING_DATE = :WORKING_DATE                                                     ");

                    if (req_user_id != "")
                    {
                        strSQL.Append("  AND M.REQ_USER_ID =:REQ_USER_ID               ");
                    }
                    strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = J.ORDER_UMSR  ");

                    strSQL.Append("  WHERE                                              ");
                    strSQL.Append("  J.ORDER_STATUS < 85                                ");

                    if (ws_cd != "")
                    {
                        strSQL.Append("  AND J.WS_CD = :WS_CD               ");
                    }
                    if (item_no != "")
                    {
                        strSQL.Append("  AND J.ITEM_NO = :ITEM_NO               ");
                    }
                    if (sch_compl_date_from != 0)
                    {
                        strSQL.Append("  AND J.SCH_COMPL_DATE >= :SCH_COMPL_DATE_FROM         ");
                    }
                    if (sch_compl_date_to != 0)
                    {
                        strSQL.Append("  AND J.SCH_COMPL_DATE <= :SCH_COMPL_DATE_TO           ");
                    }
                    if (sch_compl_date_from != 0)
                    {
                        strSQL.Append("  AND T.SLIP_DATE >= :JOB_ORDER_COMPL_DATE_FROM         ");
                    }
                    if (sch_compl_date_to != 0)
                    {
                        strSQL.Append("  AND T.SLIP_DATE <= :JOB_ORDER_COMPL_DATE_TO           ");
                    }
                }
                else
                {
                    strSQL.Append(" FROM TRANSFER_TRANS T                                                                   ");
                    strSQL.Append(" LEFT OUTER JOIN JOB_ORDER J ON T.ORDER_NO = J.ORDER_NO                                  ");
                    strSQL.Append("  AND T.XFER_STATUS <	90                                                              ");
                    strSQL.Append("  AND T.REQ_TYPE ='12'                                                                   ");
                    strSQL.Append(" LEFT OUTER JOIN MAN_HOUR_RESULTS M ON T.SLIP_NO = M.JOB_ORDER_NO                        ");
                    strSQL.Append(" AND T.PARTIAL_DELV_COMPL_CNT = M.PARTIAL_DELV_COMPL_CNT                                 ");
                    strSQL.Append("  AND M.WORKING_DATE = @WORKING_DATE                                                     ");

                    if (req_user_id != "")
                    {
                        strSQL.Append("  AND M.REQ_USER_ID = @REQ_USER_ID               ");
                    }
                    strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = J.ORDER_UMSR  ");

                    strSQL.Append("  WHERE                                              ");
                    strSQL.Append("  J.ORDER_STATUS < 85                            ");

                    if (ws_cd != "")
                    {
                        strSQL.Append("  AND J.WS_CD = @WS_CD               ");
                    }
                    if (item_no != "")
                    {
                        strSQL.Append("  AND J.ITEM_NO = @ITEM_NO               ");
                    }
                    if (sch_compl_date_from != 0)
                    {
                        strSQL.Append("  AND J.SCH_COMPL_DATE >= @SCH_COMPL_DATE_FROM         ");
                    }
                    if (sch_compl_date_to != 0)
                    {
                        strSQL.Append("  AND J.SCH_COMPL_DATE <= @SCH_COMPL_DATE_TO           ");
                    }
                    if (job_order_compl_date_from != 0)
                    {
                        strSQL.Append("  AND T.SLIP_DATE >= @JOB_ORDER_COMPL_DATE_FROM         ");
                    }
                    if (job_order_compl_date_to != 0)
                    {
                        strSQL.Append("  AND T.SLIP_DATE <= @JOB_ORDER_COMPL_DATE_TO           ");
                    }
                }
                strSQL.Append(" UNION ALL SELECT                                                                            ");
                strSQL.Append(" J.JOB_ORDER_NO,     ISNULL(M.PARTIAL_DELV_COMPL_CNT,J.COMPL_CNT+1) PARTIAL_DELV_COMPL_CNT,  ");
                strSQL.Append(" J.ITEM_NO,          J.ITEM_DESC,        ISNULL(M.COMPL_QTY, 0) INST_QTY,    J.ORDER_UMSR,   ");
                strSQL.Append(" ISNULL(M.REQ_USER_ID, '') REQ_USER_ID,  ISNULL(M.WORKING_HOURS, 0) WORKING_HOURS,           ");
                strSQL.Append(" S.DATA_CHAR UMSR_NAME                                                                       ");

                if (_db_type == "ORACLE")
                {
                    strSQL.Append(" FROM JOB_ORDER J                                                                        ");
                    strSQL.Append(" LEFT OUTER JOIN MAN_HOUR_RESULTS M ON J.JOB_ORDER_NO = M.JOB_ORDER_NO                   ");
                    strSQL.Append("  AND M.WORKING_DATE = :WORKING_DATE                                                     ");
                    if (req_user_id != "")
                    {
                        strSQL.Append("  AND M.REQ_USER_ID = :REQ_USER_ID                                                   ");
                    }
                    strSQL.Append(" AND J.JOC_SPLIT_NO + 1 = M.PARTIAL_DELV_COMPL_CNT                                       ");
                    strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = J.ORDER_UMSR  ");

                    strSQL.Append("  WHERE                                              ");
                    strSQL.Append("  J.ORDER_STATUS < 85                                ");

                    if (ws_cd != "")
                    {
                        strSQL.Append("  AND J.WS_CD = :WS_CD                   ");
                    }
                    if (item_no != "")
                    {
                        strSQL.Append("  AND J.ITEM_NO = :ITEM_NO               ");
                    }
                    if (sch_compl_date_from != 0)
                    {
                        strSQL.Append("  AND J.SCH_COMPL_DATE >= :SCH_COMPL_DATE_FROM         ");
                    }
                    if (sch_compl_date_to != 0)
                    {
                        strSQL.Append("  AND J.SCH_COMPL_DATE <= :SCH_COMPL_DATE_TO           ");
                    }
                    if (compl_flag != 1)
                    {
                        db.DbPsetInt("WORKING_DATE", _working_date);
                        db.DbPsetString("REQ_USER_ID", _req_user_id);
                        db.DbPsetString("WS_CD", _ws_cd);
                        db.DbPsetString("ITEM_NO", _item_no);
                        db.DbPsetInt("SCH_COMPL_DATE_FROM", _sch_compl_date_from);
                        db.DbPsetInt("SCH_COMPL_DATE_TO", _sch_compl_date_to);
                        db.DbPsetInt("JOB_ORDER_COMPL_DATE_FROM", _job_order_compl_date_from);
                        db.DbPsetInt("JOB_ORDER_COMPL_DATE_TO", _job_order_compl_date_to);
                    }
                }
                else
                {
                    strSQL.Append(" FROM JOB_ORDER J                                                                        ");
                    strSQL.Append(" LEFT OUTER JOIN MAN_HOUR_RESULTS M ON J.JOB_ORDER_NO = M.JOB_ORDER_NO                   ");
                    strSQL.Append(" AND J.JOC_SPLIT_NO + 1 = M.PARTIAL_DELV_COMPL_CNT                                       ");
                    strSQL.Append("  AND M.WORKING_DATE = @WORKING_DATE                                                     ");
                    if (req_user_id != "")
                    {
                        strSQL.Append("  AND M.REQ_USER_ID = @REQ_USER_ID                                                   ");
                    }

                    strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR' AND S.KEY02 = J.ORDER_UMSR  ");

                    strSQL.Append("  WHERE                                              ");
                    strSQL.Append("  J.ORDER_STATUS < 85                                ");

                    if (ws_cd != "")
                    {
                        strSQL.Append("  AND J.WS_CD = @WS_CD               ");
                    }
                    if (item_no != "")
                    {
                        strSQL.Append("  AND J.ITEM_NO = @ITEM_NO               ");
                    }
                    if (sch_compl_date_from != 0)
                    {
                        strSQL.Append("  AND J.SCH_COMPL_DATE >= @SCH_COMPL_DATE_FROM         ");
                    }
                    if (sch_compl_date_to != 0)
                    {
                        strSQL.Append("  AND J.SCH_COMPL_DATE <= @SCH_COMPL_DATE_TO           ");
                    }
                    if (compl_flag != 1)
                    {
                        db.DbPsetInt("@WORKING_DATE", _working_date);
                        db.DbPsetString("@REQ_USER_ID", _req_user_id);
                        db.DbPsetString("@WS_CD", _ws_cd);
                        db.DbPsetString("@ITEM_NO", _item_no);
                        db.DbPsetInt("@SCH_COMPL_DATE_FROM", _sch_compl_date_from);
                        db.DbPsetInt("@SCH_COMPL_DATE_TO", _sch_compl_date_to);
                        db.DbPsetInt("@JOB_ORDER_COMPL_DATE_FROM", _job_order_compl_date_from);
                        db.DbPsetInt("@JOB_ORDER_COMPL_DATE_TO", _job_order_compl_date_to);
                    }
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
        /// 工数実績登録・更新処理
        /// </summary>
        public int Mfg_Manhour_Act(ComDB db)
        {
            //ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PARTIAL_DELV_COMPL_CNT", _partial_delv_compl_cnt, ComConst.DB_IN);
            db.DbPsetString("@I_REQ_USER_ID", _req_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_WORKING_DATE", _working_date, ComConst.DB_IN);
            db.DbPsetDouble("@I_WORKING_HOURS", _working_hours, ComConst.DB_IN);
            db.DbPsetDouble("@I_COMPL_QTY", _compl_qty, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_MFG_MANHOUR_ACT");
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
        /// 出庫元倉庫を編集する
        /// 使用画面：MfgConsumptionChg
        /// </summary>
        public int Get_From_Whs_Cd()/*****************update by ubiq-chen 2009.06.23****************/
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;
            //--- sql            
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append("WHS_CD=                                                                      ");
            strSQL.Append("	    CASE WHEN I.BOND_TYPE= 1 THEN                                           ");
            strSQL.Append(" 		(CASE WHEN I.ITEM_TYPE <= 30 THEN                                   ");
            strSQL.Append(" 			(CASE WHEN I.BOND_DISB_WHS = '' THEN                            ");
            strSQL.Append(" 				IWS.BOND_SEMI_WHS ELSE I.BOND_DISB_WHS END)                 ");
            strSQL.Append("			WHEN I.ITEM_TYPE > 30 THEN                                          ");
            strSQL.Append(" 			(CASE WHEN I.BOND_DISB_WHS = '' THEN                            ");
            strSQL.Append(" 				IWS.BOND_DISB_WHS ELSE I.BOND_DISB_WHS END) END )           ");
            strSQL.Append(" 	WHEN I.BOND_TYPE= 0 THEN                                                ");
            strSQL.Append(" 		(CASE WHEN I.ITEM_TYPE <= 30 THEN                                   ");
            strSQL.Append(" 			(CASE WHEN I.DISB_WHS = '' THEN                                 ");
            strSQL.Append(" 				IWS.SEMI_WHS ELSE I.DISB_WHS END)                           ");
            strSQL.Append("			WHEN I.ITEM_TYPE > 30 THEN                                          ");
            strSQL.Append(" 			(CASE WHEN I.DISB_WHS = '' THEN                                 ");
            strSQL.Append(" 				IWS.DISB_WHS ELSE I.DISB_WHS END) END ) END                 ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM (SELECT DISB_WHS,BOND_DISB_WHS,ITEM_TYPE,BOND_TYPE,ITEM_UMSR,          ");
                //strSQL.Append(" AUTO_DISB_TYPE FROM ITEM_MASTER WHERE ITEM_NO = :PARENT_ITEM_NO) I          ");   //Del Ubiq-Sai 2010/09/17
                strSQL.Append(" AUTO_DISB_TYPE FROM ITEM_MASTER WHERE ITEM_NO = :ITEM_NO) I                 ");     //Add Ubiq-Sai 2010/09/17
                strSQL.Append(" LEFT JOIN (SELECT SEMI_WHS, BOND_SEMI_WHS,DISB_WHS,BOND_DISB_WHS            ");
                strSQL.Append("  FROM ITEM_WS_MASTER	WHERE ITEM_NO=:PARENT_ITEM_NO                       ");
                strSQL.Append("	AND WS_CD = :WS_CD                                                          ");
                strSQL.Append(" AND BEG_EFF_DATE <= CONVERT(varchar(8), GETDATE(), 112)                     ");
                strSQL.Append("  AND END_EFF_DATE >= CONVERT(varchar(8), GETDATE(), 112)) IWS ON 0 = 0      ");

                db.DbParametersClear();
                //db.DbPsetString("PARENT_ITEM_NO", _item_no);          //Del Ubiq-Sai 2010/09/17
                db.DbPsetString("PARENT_ITEM_NO", _parent_item_no);     //Add Ubiq-Sai 2010/09/17
                db.DbPsetString("ITEM_NO", _item_no);                   //Add Ubiq-Sai 2010/09/17
                db.DbPsetString("WS_CD", _ws_cd);
            }
            else
            {
                strSQL.Append(" FROM (SELECT DISB_WHS,BOND_DISB_WHS,ITEM_TYPE,BOND_TYPE,ITEM_UMSR,          ");
                //strSQL.Append(" AUTO_DISB_TYPE FROM ITEM_MASTER WHERE ITEM_NO = @PARENT_ITEM_NO) I          ");   //Del Ubiq-Sai 2010/09/17
                strSQL.Append(" AUTO_DISB_TYPE FROM ITEM_MASTER WHERE ITEM_NO = @ITEM_NO) I                 ");     //Add Ubiq-Sai 2010/09/17
                strSQL.Append(" LEFT JOIN (SELECT SEMI_WHS, BOND_SEMI_WHS,DISB_WHS,BOND_DISB_WHS            ");
                strSQL.Append("  FROM ITEM_WS_MASTER	WHERE ITEM_NO=@PARENT_ITEM_NO                       ");
                strSQL.Append("	AND WS_CD = @WS_CD                                                          ");
                strSQL.Append(" AND BEG_EFF_DATE <= CONVERT(varchar(8), GETDATE(), 112)                     ");
                strSQL.Append("  AND END_EFF_DATE >= CONVERT(varchar(8), GETDATE(), 112)) IWS ON 0 = 0      ");

                db.DbParametersClear();

                //db.DbPsetString("@PARENT_ITEM_NO", _item_no);         //Del Ubiq-Sai 2010/09/17
                db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);    //Add Ubiq-Sai 2010/09/17
                db.DbPsetString("@ITEM_NO", _item_no);                  //Add Ubiq-Sai 2010/09/17
                db.DbPsetString("@WS_CD", _ws_cd);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _whs_cd = db.Row("WHS_CD");
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// 倉庫在庫、現場在庫を抽出表示する
        /// </summary>
        public int Get_INV_BAL()//ADD 20090820 UBIQ-CHEN (**)
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;
            ComLibrary com = new ComLibrary();

            //--- sql
            strSQL.Append(" SELECT                                                                      ");
            //strSQL.Append(" ISNULL(INV.INV_QTY,0) INV_QTY,     ISNULL(WIP.WIP_QTY,0) WIP_QTY            "); 
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM                                                                    ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,WHS_CD,                                ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) INV_QTY        ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM      =       0                          ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE=       0                          ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE       = 0                             ");
                strSQL.Append("GROUP BY INVENTORY_DETAIL.ITEM_NO,WHS_CD                                 ");
                strSQL.Append(" ) INV                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" ( SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD,               ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) WIP_QTY        ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM      =       0                          ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE=       1                          ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE       = 0                             ");
                strSQL.Append("GROUP BY INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD                 ");
                strSQL.Append(" ) WIP ON    0     =   0                                                 ");

                strSQL.Append(" WHERE  INV.ITEM_NO    = :ITEM_NO                                        ");
                strSQL.Append(" AND INV.WHS_CD = :WHS_CD                                                ");
                strSQL.Append(" AND WIP.ITEM_NO = :ITEM_NO                                              ");
                strSQL.Append(" AND WIP.WS_CD = :WS_CD                                                  ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
                db.DbPsetString("WS_CD", _ws_cd);
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" (SELECT                                     ");
                strSQL.Append(" SUM(INV_BAL-ALLOC_QTY) INV_QTY              ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                    ");
                strSQL.Append(" WHERE   INV_YM          = 0                 ");
                strSQL.Append(" AND     INV_WIP_TYPE    = 0                 ");
                strSQL.Append(" AND     INV_TYPE        = 0                 ");
                strSQL.Append(" AND     ITEM_NO         = @ITEM_NO          ");
                strSQL.Append(" AND     WHS_CD          = @WHS_CD           ");
                strSQL.Append(" GROUP BY ITEM_NO,WHS_CD                     ");
                strSQL.Append(" ) INV_QTY,                                  ");
                strSQL.Append(" ( SELECT                                    ");
                strSQL.Append(" SUM(INV_BAL-ALLOC_QTY) WIP_QTY              ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                    ");
                strSQL.Append(" WHERE   INV_YM          =       0           ");
                strSQL.Append(" AND     INV_WIP_TYPE    =       1           ");
                strSQL.Append(" AND     INV_TYPE        = 0                 ");
                strSQL.Append(" AND     ITEM_NO         = @ITEM_NO          ");
                strSQL.Append(" AND     WS_CD           = @WS_CD            ");
                strSQL.Append("GROUP BY ITEM_NO,WS_CD                       ");
                strSQL.Append(" ) WIP_QTY                                   ");
                //strSQL.Append(" FROM                                                                    ");//UPD BY UBIQ-LIU 2010/8/27 BUG 886
                //strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,WHS_CD,                                ");
                //strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) INV_QTY        ");
                //strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                //strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM      =       0                          ");
                //strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE=       0                          ");
                //strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE       = 0                             ");
                //strSQL.Append("GROUP BY INVENTORY_DETAIL.ITEM_NO,WHS_CD                                 ");
                //strSQL.Append(" ) INV                                                                   ");
                //strSQL.Append(" LEFT OUTER JOIN                                                         ");
                //strSQL.Append(" ( SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD,               ");
                //strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) WIP_QTY        ");
                //strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                //strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM      =       0                          ");
                //strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE=       1                          ");
                //strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE       = 0                             ");
                //strSQL.Append("GROUP BY INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD                 ");
                //strSQL.Append(" ) WIP ON    0     =   0                                                 ");

                //strSQL.Append(" WHERE  INV.ITEM_NO    = @ITEM_NO                                        ");
                //strSQL.Append(" AND INV.WHS_CD = @WHS_CD                                                ");
                //strSQL.Append(" AND WIP.ITEM_NO = @ITEM_NO                                              ");
                //strSQL.Append(" AND WIP.WS_CD = @WS_CD                                                  ");

                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WHS_CD", _whs_cd);
                db.DbPsetString("@WS_CD", _ws_cd);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _inv_qty = com.StringToDouble(db.Row("INV_QTY"));
                _wip_qty = com.StringToDouble(db.Row("WIP_QTY"));
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// 親展開ロットトレース関数情報を検索
        /// </summary>
        public DataSet GetLotListViewFwd()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT 0 LVL, '' PARENT_ITEM_NO,                                                        ");
            strSQL.Append(" '' PARENT_JOB_PO_NO,                                                                    ");  // 2012.01.06
            strSQL.Append(" T.ITEM_NO,  T.ITEM_DESC,    T.TO_LOT_NO LOT_NO,                                         ");
            strSQL.Append(" (CASE WHEN T.REQ_TYPE = '11' THEN T.FROM_VC_CD  ELSE T.FROM_WS_CD END) WS_VENDOR_CD,    ");
            strSQL.Append(" (CASE WHEN T.REQ_TYPE = '11' THEN VM.VENDOR_DESC  ELSE WM.WS_DESC END) WS_VENDOR_DESC,  ");
            strSQL.Append(" T.SLIP_NO,                                                                              ");
            strSQL.Append(" (CASE WHEN T.REQ_TYPE = '11' THEN T.QTY_PUR_UMSR  ELSE T.INST_QTY END) COMPL_QTY,       ");
            strSQL.Append(" (CASE WHEN T.REQ_TYPE = '11' THEN T.PUR_UMSR  ELSE T.ITEM_UMSR END) PUR_UMSR,           ");
            strSQL.Append(" T.SLIP_DATE COMPL_DATE,         T.TO_WHS_CD WHS_CD,         T.TO_JOC_CD JOC_CD,         ");
            strSQL.Append(" ISNULL(SP.DATA_CHAR,'') UMSR_NAME                                                       ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T                                                   ");
                strSQL.Append(" LEFT JOIN VENDOR_MASTER VM  ON  T.FROM_VC_CD = VM.VENDOR_CD             ");
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WM  ON  T.FROM_WS_CD = WM.WS_CD               ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER SP  ON  SP.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND ((T.REQ_TYPE='11' AND SP.KEY02   = T.PUR_UMSR )                     ");
                strSQL.Append("     OR (T.REQ_TYPE='12' AND SP.KEY02   = T.ITEM_UMSR ))                 ");
                strSQL.Append(" WHERE                                                                   ");
                strSQL.Append(" T.SLIP_NO   = :SLIP_NO                                                  ");
                strSQL.Append(" AND T.TO_LOT_NO   = :LOT_NO                                             ");
                strSQL.Append(" AND T.XFER_STATUS  <> 90                                                ");
                strSQL.Append(" AND T.REQ_TYPE      IN  ('11','12')                                     ");
                db.DbPsetString("SLIP_NO", _job_order_no);
                db.DbPsetString("LOT_NO", _lot_no);

            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T                                                   ");
                strSQL.Append(" LEFT JOIN VENDOR_MASTER VM  ON  T.FROM_VC_CD = VM.VENDOR_CD             ");
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WM  ON  T.FROM_WS_CD = WM.WS_CD               ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER SP  ON  SP.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND ((T.REQ_TYPE='11' AND SP.KEY02   = T.PUR_UMSR )                     ");
                strSQL.Append("     OR (T.REQ_TYPE='12' AND SP.KEY02   = T.ITEM_UMSR ))                 ");
                strSQL.Append(" WHERE                                                                   ");
                strSQL.Append(" T.SLIP_NO   = @SLIP_NO                                                  ");
                strSQL.Append(" AND T.TO_LOT_NO   = @LOT_NO                                             ");
                strSQL.Append(" AND T.XFER_STATUS  <> 90                                                ");
                strSQL.Append(" AND T.REQ_TYPE      IN  ('11','12')                                     ");
                db.DbPsetString("@SLIP_NO", _job_order_no);
                db.DbPsetString("@LOT_NO", _lot_no);
            }

            strSQL.Append(" UNION ALL                                                                       ");

            strSQL.Append(" SELECT  LVL, PARENT_ITEM_NO,                                                    ");
            strSQL.Append(" PARENT_JOB_PO_NO,                                                               ");  // 2012.01.06
            strSQL.Append(" ITEM_NO,    ITEM_DESC,      JOB_PO_LOT_NO LOT_NO,                               ");
            strSQL.Append(" WS_VENDOR_CD,                                                                   ");
            strSQL.Append(" WS_VENDOR_DESC,                                                                 ");
            strSQL.Append(" JOB_PO_NO SLIP_NO,                                                              ");
            strSQL.Append(" JOB_PO_COMPL_QTY COMPL_QTY,                                                     ");
            strSQL.Append(" JOB_PO_UMSR PUR_UMSR,                                                           ");
            strSQL.Append(" JOB_PO_COMPL_DATE COMPL_DATE ,  JOB_PO_WHS_CD WHS_CD,   JOB_PO_JOC_CD JOC_CD,   ");
            strSQL.Append(" ISNULL(SP.DATA_CHAR,'') UMSR_NAME                                               ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM dbo.LOT_TRACE_FWD(:SLIP_NO,:LOT_NO)                                ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER SP  ON  SP.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND SP.KEY02   =  JOB_PO_UMSR                                           ");
                db.DbPsetString("SLIP_NO", _job_order_no);
                db.DbPsetString("LOT_NO", _lot_no);

            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM dbo.LOT_TRACE_FWD(@SLIP_NO,@LOT_NO)                                ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER SP  ON  SP.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND SP.KEY02   = JOB_PO_UMSR                                            ");
                db.DbPsetString("@SLIP_NO", _job_order_no);
                db.DbPsetString("@LOT_NO", _lot_no);
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
        /// 子展開ロットトレース関数情報を検索
        /// </summary>
        public DataSet GetLotListViewRvs()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT 0 LVL, '' PARENT_ITEM_NO,                                                        ");
            strSQL.Append(" '' PARENT_JOB_PO_NO,                                                                    ");  // 2012.01.06
            strSQL.Append(" T.ITEM_NO,  T.ITEM_DESC,    T.TO_LOT_NO LOT_NO,                                         ");
            strSQL.Append(" (CASE WHEN T.REQ_TYPE = '11' THEN T.FROM_VC_CD  ELSE T.FROM_WS_CD END) WS_VENDOR_CD,    ");
            strSQL.Append(" (CASE WHEN T.REQ_TYPE = '11' THEN VM.VENDOR_DESC  ELSE WM.WS_DESC END) WS_VENDOR_DESC,  ");
            strSQL.Append(" T.SLIP_NO,                                                                              ");
            strSQL.Append(" (CASE WHEN T.REQ_TYPE = '11' THEN T.QTY_PUR_UMSR  ELSE T.INST_QTY END) COMPL_QTY,       ");
            strSQL.Append(" (CASE WHEN T.REQ_TYPE = '11' THEN T.PUR_UMSR  ELSE T.ITEM_UMSR END) PUR_UMSR,           ");
            strSQL.Append(" T.SLIP_DATE COMPL_DATE,         T.TO_WHS_CD WHS_CD,         T.TO_JOC_CD JOC_CD,         ");
            strSQL.Append(" ISNULL(SP.DATA_CHAR,'') UMSR_NAME                                                       ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T                                                   ");
                strSQL.Append(" LEFT JOIN VENDOR_MASTER VM  ON  T.FROM_VC_CD = VM.VENDOR_CD             ");
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WM  ON  T.FROM_WS_CD = WM.WS_CD               ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER SP  ON  SP.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND ((T.REQ_TYPE='11' AND SP.KEY02   = T.PUR_UMSR )                     ");
                strSQL.Append("     OR (T.REQ_TYPE='12' AND SP.KEY02   = T.ITEM_UMSR ))                 ");
                strSQL.Append(" WHERE                                                                   ");
                strSQL.Append(" T.SLIP_NO   = :SLIP_NO                                                  ");
                strSQL.Append(" AND T.TO_LOT_NO   = :LOT_NO                                             ");
                strSQL.Append(" AND T.XFER_STATUS  <> 90                                                ");
                strSQL.Append(" AND T.REQ_TYPE      IN  ('11','12')                                     ");
                db.DbPsetString("SLIP_NO", _job_order_no);
                db.DbPsetString("LOT_NO", _lot_no);

            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS T                                                   ");
                strSQL.Append(" LEFT JOIN VENDOR_MASTER VM  ON  T.FROM_VC_CD = VM.VENDOR_CD             ");
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WM  ON  T.FROM_WS_CD = WM.WS_CD               ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER SP  ON  SP.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND ((T.REQ_TYPE='11' AND SP.KEY02   = T.PUR_UMSR )                     ");
                strSQL.Append("     OR (T.REQ_TYPE='12' AND SP.KEY02   = T.ITEM_UMSR ))                 ");
                strSQL.Append(" WHERE                                                                   ");
                strSQL.Append(" T.SLIP_NO   = @SLIP_NO                                                  ");
                strSQL.Append(" AND T.TO_LOT_NO   = @LOT_NO                                             ");
                strSQL.Append(" AND T.XFER_STATUS  <> 90                                                ");
                strSQL.Append(" AND T.REQ_TYPE      IN  ('11','12')                                     ");
                db.DbPsetString("@SLIP_NO", _job_order_no);
                db.DbPsetString("@LOT_NO", _lot_no);

            }

            strSQL.Append(" UNION ALL                                                                      ");

            strSQL.Append(" SELECT  LVL, PARENT_ITEM_NO,                                                   ");
            strSQL.Append(" PARENT_JOB_PO_NO,                                                               ");  // 2012.01.06
            strSQL.Append(" ITEM_NO,    ITEM_DESC,      JOB_PO_LOT_NO LOT_NO,                              ");
            strSQL.Append(" WS_VENDOR_CD,                                                                  ");
            strSQL.Append(" WS_VENDOR_DESC,                                                                ");
            strSQL.Append(" JOB_PO_NO SLIP_NO,                                                             ");
            strSQL.Append(" JOB_PO_COMPL_QTY COMPL_QTY,                                                    ");
            strSQL.Append(" JOB_PO_UMSR PUR_UMSR,                                                          ");
            strSQL.Append(" JOB_PO_COMPL_DATE COMPL_DATE ,  JOB_PO_WHS_CD WHS_CD,   JOB_PO_JOC_CD JOC_CD,  ");
            strSQL.Append(" ISNULL(SP.DATA_CHAR,'') UMSR_NAME                                              ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM dbo.LOT_TRACE_RVS(:SLIP_NO,:LOT_NO)                                ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER SP  ON  SP.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND SP.KEY02   =  JOB_PO_UMSR                                           ");
                db.DbPsetString("SLIP_NO", _job_order_no);
                db.DbPsetString("LOT_NO", _lot_no);

            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM dbo.LOT_TRACE_RVS(@SLIP_NO,@LOT_NO)                                ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER SP  ON  SP.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND SP.KEY02   = JOB_PO_UMSR                                            ");
                db.DbPsetString("@SLIP_NO", _job_order_no);
                db.DbPsetString("@LOT_NO", _lot_no);
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
        /// ロットトレース用に指定作業指示№、出荷番号のロットを得る
        /// </summary>
        public DataSet GetLotList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT   ");
            strSQL.Append(" T.ITEM_NO,  T.ITEM_DESC,    T.TO_LOT_NO LOT_NO,                                         ");
            strSQL.Append(" (CASE WHEN T.REQ_TYPE = '11' THEN T.FROM_VC_CD  ELSE T.FROM_WS_CD END) WS_VENDOR_CD,    ");
            strSQL.Append(" (CASE WHEN T.REQ_TYPE = '11' THEN VM.VENDOR_DESC  ELSE WM.WS_DESC END) WS_VENDOR_DESC,  ");
            strSQL.Append(" T.SLIP_NO,                                                                              ");
            strSQL.Append(" (CASE WHEN T.REQ_TYPE = '11' THEN T.QTY_PUR_UMSR  ELSE T.INST_QTY END) COMPL_QTY,       ");
            strSQL.Append(" (CASE WHEN T.REQ_TYPE = '11' THEN T.PUR_UMSR  ELSE T.ITEM_UMSR END) PUR_UMSR,           ");
            strSQL.Append(" T.SLIP_DATE COMPL_DATE,         T.TO_WHS_CD WHS_CD,         T.TO_JOC_CD JOC_CD,         ");
            strSQL.Append(" ISNULL(SP.DATA_CHAR,'') UMSR_NAME                                                       ");

            db.DbParametersClear();

            strSQL.Append(" FROM TRANSFER_TRANS T                                                   ");
            strSQL.Append(" LEFT JOIN VENDOR_MASTER VM  ON  T.FROM_VC_CD = VM.VENDOR_CD             ");
            strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WM  ON  T.FROM_WS_CD = WM.WS_CD               ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER SP  ON  SP.KEY01 = 'ITEM_UMSR'               ");
            strSQL.Append(" AND ((T.REQ_TYPE='11' AND SP.KEY02   = T.PUR_UMSR )                     ");
            strSQL.Append("     OR (T.REQ_TYPE='12' AND SP.KEY02   = T.ITEM_UMSR ))                 ");
            strSQL.Append(" WHERE                                                                   ");
            strSQL.Append(" T.PO_NO   = @PO_NO                                                  ");
            //strSQL.Append(" AND T.TO_LOT_NO   = @LOT_NO                                             ");
            strSQL.Append(" AND T.XFER_STATUS  <> 90                                                ");
            strSQL.Append(" AND T.REQ_TYPE      IN  ('11','12','22')  ");   // 22 は出荷
            strSQL.Append(" AND T.INST_QTY > 0 ");  // 2015.06.25
            db.DbPsetString("@PO_NO", _job_order_no);
            //db.DbPsetString("@LOT_NO", _lot_no);
            if (_item_no != "")
            {
                strSQL.Append(" AND T.ITEM_NO = @ITEM_NO ");  // 2015.06.25
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            strSQL.Append(" ORDER BY T.TO_LOT_NO ");

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
        /// 作業指示№入力条件で指示済製造オーダの作業指示の工程明細を検索して表示する。[工程別]
        /// </summary>
        public DataSet Get_Mfg_ProcessList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                           ");
            strSQL.Append("CAST(JD.PROCESS_SEQ AS VARCHAR)+':'+JD.PROCESS_CD+':'+P.PROCESS_DESC PROCESS,    ");
            strSQL.Append("J.ORDER_STATUS,   WS.COMPL_FLAG,     JD.LAST_FLAG                                ");
            strSQL.Append(",JD.INPUT_FLAG                              ");//ADD BY UBIQ-SUO 2011/1/10
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER J                                                    ");
                strSQL.Append(" LEFT JOIN JOB_ORDER_DETAIL JD ON JD.JOB_ORDER_NO = J.JOB_ORDER_NO   ");
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WS ON JD.WS_CD = WS.WS_CD                 ");
                strSQL.Append(" LEFT JOIN PROCESS_MASTER P ON  JD.PROCESS_CD  = P.PROCESS_CD        ");
                strSQL.Append("                           AND  JD.WS_CD  = P.WS_CD                  ");
                if (_job_order_no != "")
                {
                    strSQL.Append("  WHERE    J.JOB_ORDER_NO     = :JOB_ORDER_NO                    ");
                    db.DbPsetString("JOB_ORDER_NO", _job_order_no);
                }
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER J                                                    ");
                strSQL.Append(" LEFT JOIN JOB_ORDER_DETAIL JD ON JD.JOB_ORDER_NO = J.JOB_ORDER_NO   ");
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WS ON JD.WS_CD = WS.WS_CD                 ");
                strSQL.Append(" LEFT JOIN PROCESS_MASTER P ON  JD.PROCESS_CD  = P.PROCESS_CD        ");
                strSQL.Append("                           AND  JD.WS_CD  = P.WS_CD                  ");
                if (_job_order_no != "")
                {
                    strSQL.Append("  WHERE    J.JOB_ORDER_NO     = @JOB_ORDER_NO                    ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
            }
            strSQL.Append("  ORDER BY JD.LAST_FLAG,   JD.PROCESS_SEQ                        ");

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
        /// 作業指示№と選択工程で指示済製造オーダ、作業指示を検索して表示する。[工程別]
        /// </summary>
        public DataSet Get_Mfg_ProcessComplDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                              ");
            strSQL.Append(" J.JOB_ORDER_NO,     JD.JOB_ORDER_STATUS,        JD.WS_CD,           WS.WS_DESC,     ");
            strSQL.Append(" JD.SCH_START_DATE,  JD.SCH_COMPL_DATE,          JD.ITEM_NO,         J.ITEM_DESC,    ");
            strSQL.Append(" J.JOB_ORDER_QTY,    J.ORDER_UMSR,               JD.COMPL_QTY,       J.WHS_CD,       ");
            strSQL.Append(" WHS.WHS_DESC,       J.INSP_CD,                  J.JOC_CD,           J.SLIP_NOTE,    ");
            strSQL.Append(" I.LOCATION,         ISNULL(IW.IDTAG_UNIT_QTY,0) IDTAG_UNIT_QTY,                     ");
            strSQL.Append(" I.LOT_CNTL_FLAG,    S1.DATA_INT AUTO_TYPE,      JD.REJ_QTY,			JD.INPUT_FLAG,	");
            strSQL.Append(" ISNULL(IW.IDTAG_PRINT_FLAG,1) IDTAG_PRINT_FLAG, S.DATA_CHAR UMSR_NAME               ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER J                                                        ");
                strSQL.Append(" INNER JOIN JOB_ORDER_DETAIL JD ON J.JOB_ORDER_NO = JD.JOB_ORDER_NO      ");
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WS ON J.WS_CD = WS.WS_CD                      ");
                strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER WHS ON J.WHS_CD = WHS.WHS_CD                 ");
                strSQL.Append(" LEFT JOIN ITEM_WS_MASTER IW ON J.WS_CD = IW.WS_CD                       ");
                strSQL.Append("                         AND    J.ITEM_NO = IW.ITEM_NO                   ");
                strSQL.Append("                         AND    J.SCH_COMPL_DATE >= IW.BEG_EFF_DATE      ");
                strSQL.Append("                         AND    J.SCH_COMPL_DATE <= IW.END_EFF_DATE      ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER I ON J.ITEM_NO = I.ITEM_NO                        ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON  S.KEY01  = 'ITEM_UMSR'                 ");
                strSQL.Append("  AND    S.KEY02 = J.ORDER_UMSR                                          ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S1 ON S1.KEY01  = 'LOT_NUMBERING'            ");
                strSQL.Append("  AND    S1.KEY02  = 'MFG'                                               ");
                strSQL.Append("  WHERE      J.JOB_ORDER_NO      = :JOB_ORDER_NO                         ");
                strSQL.Append("  AND        JD.PROCESS_CD       = :PROCESS_CD                           ");
                strSQL.Append("  AND        JD.PROCESS_SEQ      = :PROCESS_SEQ                          ");

                db.DbPsetString("JOB_ORDER_NO", _job_order_no);
                db.DbPsetString("PROCESS_CD", _process_cd);
                db.DbPsetInt("PROCESS_SEQ", _seq);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER J                                                        ");
                strSQL.Append(" INNER JOIN JOB_ORDER_DETAIL JD ON J.JOB_ORDER_NO = JD.JOB_ORDER_NO      ");
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WS ON J.WS_CD = WS.WS_CD                      ");
                strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER WHS ON J.WHS_CD = WHS.WHS_CD                 ");
                strSQL.Append(" LEFT JOIN ITEM_WS_MASTER IW ON J.WS_CD = IW.WS_CD                       ");
                strSQL.Append("                         AND    J.ITEM_NO = IW.ITEM_NO                   ");
                strSQL.Append("                         AND    J.SCH_COMPL_DATE >= IW.BEG_EFF_DATE      ");
                strSQL.Append("                         AND    J.SCH_COMPL_DATE <= IW.END_EFF_DATE      ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER I ON J.ITEM_NO = I.ITEM_NO                        ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON  S.KEY01  = 'ITEM_UMSR'                 ");
                strSQL.Append("  AND    S.KEY02 = J.ORDER_UMSR                                          ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S1 ON S1.KEY01  = 'LOT_NUMBERING'            ");
                strSQL.Append("  AND    S1.KEY02  = 'MFG'                                               ");
                strSQL.Append("  WHERE      J.JOB_ORDER_NO      = @JOB_ORDER_NO                         ");
                strSQL.Append("  AND        JD.PROCESS_CD       = @PROCESS_CD                           ");
                strSQL.Append("  AND        JD.PROCESS_SEQ      = @PROCESS_SEQ                          ");

                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                db.DbPsetString("@PROCESS_CD", _process_cd);
                db.DbPsetInt("@PROCESS_SEQ", _seq);
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
        /// 作業指示№で指示済製造オーダ、作業指示にて工程情報を検索して表示する。[工程別]
        /// </summary>
        public DataSet Get_Mfg_ProcessComplList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                               ");
            strSQL.Append("JD.PROCESS_CD,           P.PROCESS_DESC,         JD.COMPL_QTY,       ");
            strSQL.Append("JD.SCH_WORK_TIME+JD.SCH_SETUP_TIME+JD.SCH_TRANSFER_TIME WORKTIME,    ");
            strSQL.Append("JD.WORK_OPERATIONPRODUCTIONTIME,                                      ");
            strSQL.Append("JD.REJ_QTY,                                                            ");//ADD BY UBIQ-SUO 2010/12/21 BUG946
            strSQL.Append(" CASE WHEN JD.JOB_ORDER_STATUS = 30 THEN '30' WHEN JD.JOB_ORDER_STATUS = 35 THEN '35'"); //ADD BY UBIQ-SUO 2010/12/21 BUG946
            strSQL.Append(" WHEN JD.JOB_ORDER_STATUS = 40 THEN '40' WHEN JD.JOB_ORDER_STATUS = 85 AND JD.INPUT_QTY > JD.COMPL_QTY THEN '851'");//ADD BY UBIQ-SUO 2010/12/21 BUG946
            strSQL.Append(" WHEN JD.JOB_ORDER_STATUS = 85 AND JD.INPUT_QTY <= JD.COMPL_QTY THEN '852' END JOB_ORDER_STATUS");//ADD BY UBIQ-SUO 2010/12/21 BUG946
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER J                                                    ");
                strSQL.Append(" LEFT JOIN JOB_ORDER_DETAIL JD ON JD.JOB_ORDER_NO = J.JOB_ORDER_NO   ");
                strSQL.Append(" LEFT JOIN ROUTINE_MASTER R ON  JD.ITEM_NO   = R.ITEM_NO             ");
                strSQL.Append("                           AND  JD.WS_CD     = R.WS_CD               ");
                strSQL.Append("                           AND  JD.PROCESS_CD  = R.PROCESS_CD        ");
                strSQL.Append(" LEFT JOIN PROCESS_MASTER P ON  JD.PROCESS_CD  = P.PROCESS_CD        ");
                strSQL.Append("                           AND  JD.WS_CD  = P.WS_CD                  ");
                if (_job_order_no != "")
                {
                    strSQL.Append("  WHERE    J.JOB_ORDER_NO     = :JOB_ORDER_NO                    ");
                    db.DbPsetString("JOB_ORDER_NO", _job_order_no);
                }
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER J                                                    ");
                strSQL.Append(" LEFT JOIN JOB_ORDER_DETAIL JD ON JD.JOB_ORDER_NO = J.JOB_ORDER_NO   ");
                strSQL.Append(" LEFT JOIN ROUTINE_MASTER R ON  JD.ITEM_NO   = R.ITEM_NO             ");
                strSQL.Append("                           AND  JD.WS_CD     = R.WS_CD               ");
                strSQL.Append("                           AND  JD.PROCESS_CD  = R.PROCESS_CD        ");
                strSQL.Append(" LEFT JOIN PROCESS_MASTER P ON  JD.PROCESS_CD  = P.PROCESS_CD        ");
                strSQL.Append("                           AND  JD.WS_CD  = P.WS_CD                  ");
                if (_job_order_no != "")
                {
                    strSQL.Append("  WHERE    J.JOB_ORDER_NO     = @JOB_ORDER_NO                    ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
            }
            strSQL.Append("  ORDER BY R.ROUTINE_SEQ                                                 ");

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
        /// 作業実績処理[工程別]
        /// <para>使用画面[MfgProcessCompl]</para>
        /// </summary>
        public int Mfg_ProcessCompl(ComDB db)
        {
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PROCESS_SEQ", _seq, ComConst.DB_IN);
            db.DbPsetDouble("@I_JOB_ORDER_COMPL_QTY", _job_order_compl_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_JOB_ORDER_REJ_QTY", _job_order_rej_qty, ComConst.DB_IN);
            db.DbPsetInt("@I_WORKING_HOURS", _working_hour, ComConst.DB_IN);
            db.DbPsetString("@I_LOT_NO", _lot_no, ComConst.DB_INOUT);   //Upd Ubiq-Sai 10.10.03 DB_OUT->DB_INOUT
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION", _location, ComConst.DB_IN);
            db.DbPsetString("@I_USER_ID", _user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_JOB_ORDER_COMPL_DATE", _job_order_compl_date, ComConst.DB_IN);
            db.DbPsetInt("@I_DEV_COMPL_TYPE", _dev_compl_type, ComConst.DB_IN);
            db.DbPsetString("@I_PARENT_XFER_NO", _parent_xfer_no, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);
            try
            {
                //db.DbBeginTrans();  // IMV3
                rtn = db.DbStored("SP_MFG_PROCESS_COMPL");
                rtn = db.DbPgetInt("RET");
                if (rtn == ComConst.SUCCEED)
                {
                    _lot_no = db.DbPgetString("@I_LOT_NO");
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
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return ComConst.FAILED;
            }
            return rtn;
        }

        /// <summary>
        /// 入力作業指示№条件でデマンドを検索[工程別]
        /// </summary>
        public DataSet Get_Mfg_ProcessComplDemandDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                      ");
            strSQL.Append(" JO.JOB_ORDER_STATUS,	D.ITEM_NO,		I.ITEM_DESC,    D.PLAN_QTY,         ");
            strSQL.Append(" D.WIP_ALLOC_QTY,        D.INPUT_QTY,	D.ITEM_UMSR,	D.SUB_GRP_CD,       ");
            strSQL.Append(" D.AUTO_DISB_TYPE,	    D.DEMAND_NO,    S.DATA_CHAR UMSR_NAME,              ");
            strSQL.Append(" (CASE D.USAGE_TYPE WHEN 0 THEN D.USAGE_DEC                                  ");
            strSQL.Append(" ELSE D.USAGE_NUMERATOR/D.USAGE_DENOMINATOR END) USAGE_QTY,                  ");
            strSQL.Append(" COUNT(D2.ORDER_NO) QTY_FLAG,                                                ");
            strSQL.Append(" ISNULL(INV.INV_QTY,0) INV_QTY,           ISNULL(WIP.WIP_QTY,0) WIP_QTY,     ");
            strSQL.Append(" (CASE WHEN (ISNULL(D.ALLOC_QTY,0)-ISNULL(D.ACT_DISB_QTY,0))<0 THEN 0 ELSE   ");
            strSQL.Append(" (ISNULL(D.ALLOC_QTY,0)-ISNULL(D.ACT_DISB_QTY,0)) END) ALLOC_QTY,            ");
            strSQL.Append(" ISNULL(WIPALLOC.WIP_ALLOC_QTY,0) W_ALLOC_QTY                                ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER_DETAIL JO                                                ");
                strSQL.Append(" LEFT OUTER JOIN DEMAND D ON     JO.ORDER_NO     =   D.ORDER_NO          ");
                strSQL.Append("                         AND     JO.PROCESS_CD   =   D.PROCESS_CD        ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON D.ITEM_NO      =   I.ITEM_NO           ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01   =   'ITEM_UMSR'         ");
                strSQL.Append("                                   AND S.KEY02   =   D.ITEM_UMSR         ");
                strSQL.Append(" LEFT OUTER JOIN DEMAND D2 ON    D2.ORDER_NO     =   JO.ORDER_NO         ");
                strSQL.Append("                             AND D2.PROCESS_CD   =   D.PROCESS_CD        ");
                strSQL.Append("                             AND D2.SUB_GRP_CD   =   D.SUB_GRP_CD        ");
                strSQL.Append("                             AND D2.SUB_GRP_CD   <>  ''                  ");
                strSQL.Append("                             AND D2.SUB_ACTION_FLAG = 0                  ");
                strSQL.Append("                             AND D2.ITEM_TYPE    <>  '99' 			    ");

                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON WS.WS_CD = D.WS_CD               "); // 2011.03.09

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO,    WHS_CD,   SUM(INV_BAL-ALLOC_QTY) INV_QTY            ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INV_YM          =   0                                           ");
                strSQL.Append("     AND INV_WIP_TYPE    =   0                                           ");
                strSQL.Append("     AND INV_TYPE        =   0                                           ");
                strSQL.Append(" GROUP BY  ITEM_NO,  WHS_CD )  INV ON D.ITEM_NO  =   INV.ITEM_NO         ");
                strSQL.Append("                                  AND D.DISB_WHS =   INV.WHS_CD          ");

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO,    WS_CD,     SUM(INV_BAL-ALLOC_QTY) WIP_QTY           ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INV_YM          =   0                                           ");
                strSQL.Append("     AND INV_WIP_TYPE    =   1                                           ");
                strSQL.Append("     AND INV_TYPE        =   0                                           ");
                strSQL.Append(" GROUP BY  ITEM_NO,  WS_CD  )  WIP  ON D.ITEM_NO =   WIP.ITEM_NO         ");
                //strSQL.Append("                                   AND D.WS_CD   =   WIP.WS_CD           ");
                strSQL.Append(" AND  WIP.WS_CD =   CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN D.WS_CD ELSE WS.REP_WS_CD END "); // 2011.03.09

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT DEMAND_NO,      SUM(ALLOC_QTY) WIP_ALLOC_QTY                    ");
                strSQL.Append(" FROM    WIP_ALLOC                                                       ");
                strSQL.Append(" WHERE   ALLOC_STATUS  =   0                                             ");
                strSQL.Append("     AND SCH_FLAG      IN (0,2)                                          ");
                strSQL.Append(" GROUP BY  DEMAND_NO)  WIPALLOC  ON  D.DEMAND_NO = WIPALLOC.DEMAND_NO    ");
                strSQL.Append(" WHERE  JO.JOB_ORDER_NO  =  :JOB_ORDER_NO                                ");
                strSQL.Append("     AND    JO.PROCESS_CD = :PROCESS_CD 			                        ");
                strSQL.Append("     AND    JO.PROCESS_SEQ = :PROCESS_SEQ		                        ");
                strSQL.Append("     AND  ( D.SUB_GRP_CD = ''                                            ");
                strSQL.Append("            OR  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1)    )      ");
                strSQL.Append("     AND    D.ITEM_TYPE         <> '99' 			                        ");

                db.DbPsetString("JOB_ORDER_NO", _job_order_no);
                db.DbPsetString("PROCESS_CD", _process_cd);
                db.DbPsetInt("PROCESS_SEQ", _seq);

            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER_DETAIL JO                                                ");
                strSQL.Append(" LEFT OUTER JOIN DEMAND D ON     JO.ORDER_NO     =   D.ORDER_NO          ");
                strSQL.Append("                         AND     JO.PROCESS_CD   =   D.PROCESS_CD        ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON D.ITEM_NO      =   I.ITEM_NO           ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01   =   'ITEM_UMSR'         ");
                strSQL.Append("                                   AND S.KEY02   =   D.ITEM_UMSR         ");
                strSQL.Append(" LEFT OUTER JOIN DEMAND D2 ON    D2.ORDER_NO     =   JO.ORDER_NO         ");
                strSQL.Append("                             AND D2.PROCESS_CD   =   D.PROCESS_CD        ");
                strSQL.Append("                             AND D2.SUB_GRP_CD   =   D.SUB_GRP_CD        ");
                strSQL.Append("                             AND D2.SUB_GRP_CD   <>  ''                  ");
                strSQL.Append("                             AND D2.SUB_ACTION_FLAG = 0                  ");
                strSQL.Append("                             AND D2.ITEM_TYPE    <>  '99' 			    ");

                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON WS.WS_CD = D.WS_CD               "); // 2011.03.09
                
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO,    WHS_CD,   SUM(INV_BAL-ALLOC_QTY) INV_QTY            ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INV_YM          =   0                                           ");
                strSQL.Append("     AND INV_WIP_TYPE    =   0                                           ");
                strSQL.Append("     AND INV_TYPE        =   0                                           ");
                strSQL.Append(" GROUP BY  ITEM_NO,  WHS_CD )  INV ON D.ITEM_NO  =   INV.ITEM_NO         ");
                strSQL.Append("                                  AND D.DISB_WHS =   INV.WHS_CD          ");

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO,    WS_CD,     SUM(INV_BAL-ALLOC_QTY) WIP_QTY           ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INV_YM          =   0                                           ");
                strSQL.Append("     AND INV_WIP_TYPE    =   1                                           ");
                strSQL.Append("     AND INV_TYPE        =   0                                           ");
                strSQL.Append(" GROUP BY  ITEM_NO,  WS_CD  )  WIP  ON D.ITEM_NO =   WIP.ITEM_NO         ");
                //strSQL.Append("                                   AND D.WS_CD   =   WIP.WS_CD           ");
                strSQL.Append(" AND  WIP.WS_CD =   CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN D.WS_CD ELSE WS.REP_WS_CD END "); // 2011.03.09

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT DEMAND_NO,      SUM(ALLOC_QTY) WIP_ALLOC_QTY                    ");
                strSQL.Append(" FROM    WIP_ALLOC                                                       ");
                strSQL.Append(" WHERE   ALLOC_STATUS  =   0                                             ");
                strSQL.Append("     AND SCH_FLAG      IN (0,2)                                          ");
                strSQL.Append(" GROUP BY  DEMAND_NO)  WIPALLOC  ON  D.DEMAND_NO = WIPALLOC.DEMAND_NO    ");
                strSQL.Append(" WHERE  JO.JOB_ORDER_NO  =  @JOB_ORDER_NO                                ");
                strSQL.Append("     AND    JO.PROCESS_CD = @PROCESS_CD 			                        ");
                strSQL.Append("     AND    JO.PROCESS_SEQ = @PROCESS_SEQ		                        ");
                strSQL.Append("     AND  ( D.SUB_GRP_CD = ''                                            ");
                strSQL.Append("            OR  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1)    )      ");
                strSQL.Append("     AND    D.ITEM_TYPE         <> '99' 			                        ");
                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                db.DbPsetString("@PROCESS_CD", _process_cd);
                db.DbPsetInt("@PROCESS_SEQ", _seq);
            }

            strSQL.Append(" GROUP BY JO.JOB_ORDER_STATUS,	    D.ITEM_NO,  I.ITEM_DESC,    D.PLAN_QTY, ");
            strSQL.Append(" D.WIP_ALLOC_QTY,     D.INPUT_QTY,	D.ITEM_UMSR,	D.SUB_GRP_CD,           ");
            strSQL.Append(" D.AUTO_DISB_TYPE,	D.DEMAND_NO,    S.DATA_CHAR,     D2.DEMAND_NO,          ");
            strSQL.Append(" D.USAGE_TYPE,        D.USAGE_DEC,                                           ");
            strSQL.Append(" D.USAGE_NUMERATOR,   D.USAGE_DENOMINATOR,                                   ");
            strSQL.Append(" INV.INV_QTY,        WIP.WIP_QTY,                                            ");
            strSQL.Append(" D.ALLOC_QTY,    D.ACT_DISB_QTY,                                             ");
            strSQL.Append(" WIPALLOC.WIP_ALLOC_QTY                                                      ");

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
        /// 作業実績データを検索[工程別]
        /// </summary>
        public DataSet Get_Mfg_ProcessComplCancelList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append("TR.PO_NO,		    TR.ITEM_NO,	        TR.ITEM_DESC,	    TR.FROM_WS_CD,	");
            strSQL.Append("WS.WS_DESC,	        TR.FROM_PROCESS_CD, PM.PROCESS_DESC,    TR.ACT_QTY,     ");
            strSQL.Append("TR.ITEM_UMSR,        TR.SLIP_DATE,       TR.TO_LOT_NO,       TR.TO_JOC_CD,   ");
            strSQL.Append("TR.TO_WHS_CD,        TR.REJ_QTY,         TR.PARTIAL_DELV_COMPL_CNT,          ");
            strSQL.Append("TR.PO_LINE_NO,       S1.DATA_CHAR UMSR_NAME                                  ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS TR                                                  ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON  TR.FROM_WS_CD   = WS.WS_CD       ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PM ON  TR.FROM_WS_CD    = PM.WS_CD        ");
                strSQL.Append("                               AND  TR.FROM_PROCESS_CD  = PM.PROCESS_CD   ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON  S1.KEY01  = 'ITEM_UMSR'         ");
                strSQL.Append("                                    AND  S1.KEY02  = TR.ITEM_UMSR        ");
                strSQL.Append(" WHERE   TR.XFER_NO      = TR.PARENT_XFER_NO                             ");
                strSQL.Append("     AND TR.XFER_STATUS  <  90                                           ");//取消
                strSQL.Append("     AND TR.REQ_TYPE     = '06'                                          ");//工程完成

                if (_job_order_no != "")
                {
                    strSQL.Append("  AND    TR.PO_NO     = @JOB_ORDER_NO                         ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND    TR.FROM_WS_CD            = @WS_CD                           ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_process_cd != "")
                {
                    strSQL.Append("  AND    TR.FROM_PROCESS_CD       = @PROCESS_CD                      ");
                    db.DbPsetString("@PROCESS_CD", _process_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("  AND    TR.ITEM_NO          = @ITEM_NO                              ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_to_lot_no != "")
                {
                    strSQL.Append("  AND    TR.TO_LOT_NO        = @TO_LOT_NO                            ");
                    db.DbPsetString("@TO_LOT_NO", _to_lot_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("  AND    TR.TO_JOC_CD        = @JOC_CD                               ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (_beg_slip_date != 0)
                {
                    strSQL.Append("  AND    TR.SLIP_DATE        >= @BEG_SLIP_DATE                       ");
                    db.DbPsetInt("@BEG_SLIP_DATE", _beg_slip_date);
                }
                if (_end_slip_date != 0)
                {
                    strSQL.Append("  AND    TR.SLIP_DATE        <= @END_SLIP_DATE                       ");
                    db.DbPsetInt("@END_SLIP_DATE", _end_slip_date);
                }
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS TR                                                  ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON  TR.FROM_WS_CD   = WS.WS_CD       ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PM ON  TR.FROM_WS_CD    = PM.WS_CD        ");
                strSQL.Append("                               AND  TR.FROM_PROCESS_CD  = PM.PROCESS_CD   ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON  S1.KEY01  = 'ITEM_UMSR'         ");
                strSQL.Append("                                    AND  S1.KEY02  = TR.ITEM_UMSR        ");
                strSQL.Append(" WHERE   TR.XFER_NO      = TR.PARENT_XFER_NO                             ");
                strSQL.Append("     AND TR.XFER_STATUS  <  90                                           ");//取消
                strSQL.Append("     AND TR.TO_PROCESS_CD <> ''                                          ");//ADD 2010.11.09
                strSQL.Append("     AND TR.REQ_TYPE     = '06'                                          ");//工程完成

                if (_job_order_no != "")
                {
                    strSQL.Append("  AND    TR.PO_NO     = @JOB_ORDER_NO                         ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND    TR.FROM_WS_CD            = @WS_CD                           ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_process_cd != "")
                {
                    strSQL.Append("  AND    TR.FROM_PROCESS_CD       = @PROCESS_CD                      ");
                    db.DbPsetString("@PROCESS_CD", _process_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("  AND    TR.ITEM_NO          = @ITEM_NO                              ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_to_lot_no != "")
                {
                    strSQL.Append("  AND    TR.TO_LOT_NO        = @TO_LOT_NO                            ");
                    db.DbPsetString("@TO_LOT_NO", _to_lot_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("  AND    TR.TO_JOC_CD        = @JOC_CD                               ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (_beg_slip_date != 0)
                {
                    strSQL.Append("  AND    TR.SLIP_DATE        >= @BEG_SLIP_DATE                       ");
                    db.DbPsetInt("@BEG_SLIP_DATE", _beg_slip_date);
                }
                if (_end_slip_date != 0)
                {
                    strSQL.Append("  AND    TR.SLIP_DATE        <= @END_SLIP_DATE                       ");
                    db.DbPsetInt("@END_SLIP_DATE", _end_slip_date);
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
        /// 作業実績取消[工程別]
        /// </summary>
        public int Mfg_ProcessComplCancel()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PARTIAL_DELV_COMPL_CNT", _partial_delv_compl_cnt, ComConst.DB_IN);
            db.DbPsetInt("@I_PROCESS_SEQ", _seq, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_MFG_PROCESS_COMPLCANCEL");
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
        /// 指示済製造オーダを検索
        /// <para>使用画面[MfgInput]</para>
        /// </summary>
        public DataSet Get_Mfg_InputDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                      ");
            strSQL.Append(" JO.ORDER_STATUS,	WS.COMPL_FLAG,		JOD.INPUT_FLAG,						");
            strSQL.Append("	JO.WS_CD,			WS.WS_DESC,	        JO.SCH_START_DATE,					");
            strSQL.Append("JO.SCH_COMPL_DATE,	JO.ITEM_NO,     JO.ITEM_DESC,       JO.JOB_ORDER_QTY,   ");
            strSQL.Append("JO.ORDER_UMSR,       JO.JOB_ORDER_COMPL_QTY,  JO.WHS_CD, WHS.WHS_DESC,       ");
            strSQL.Append("JO.INSP_CD,          JO.SLIP_NOTE,		JOD.PROCESS_CD,						");
            strSQL.Append("PM.PROCESS_DESC,     S2.DATA_CHAR UMSR_NAME,      JOD.INPUT_QTY,				");
            strSQL.Append(" JO.JOC_CD,																	");
            strSQL.Append("JOD.SCH_WORK_TIME + JOD.SCH_SETUP_TIME + JOD.SCH_TRANSFER_TIME WORKTIME,     ");
            strSQL.Append("JO.REJ_QTY																	");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER JO                                                       ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS  ON JO.WS_CD     = WS.WS_CD          ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WHS ON JO.WHS_CD   = WHS.WHS_CD        ");
                strSQL.Append(" LEFT JOIN JOB_ORDER_DETAIL      JOD ON                                  ");
                strSQL.Append(" JO.JOB_ORDER_NO     = JOD.JOB_ORDER_NO                                  ");
                strSQL.Append(" LEFT JOIN PROCESS_MASTER PM ON JOD.PROCESS_CD      = PM.PROCESS_CD      ");
                strSQL.Append(" AND JOD.WS_CD = PM.WS_CD                                                ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S2 ON S2.KEY01  = 'ITEM_UMSR'                ");
                strSQL.Append("  AND    S2.KEY02  = JO.ORDER_UMSR                                       ");
                strSQL.Append(" WHERE  JO.JOB_ORDER_NO      = :JOB_ORDER_NO                             ");
                db.DbPsetString("JOB_ORDER_NO", _job_order_no);
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER JO                                                       ");
                strSQL.Append(" INNER JOIN ITEM_MASTER IM  ON JO.ITEM_NO		= IM.ITEM_NO			");
                strSQL.Append(" INNER JOIN WORKSHOP_MASTER WS  ON JO.WS_CD		= WS.WS_CD				");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WHS ON JO.WHS_CD   = WHS.WHS_CD        ");
                strSQL.Append(" LEFT JOIN JOB_ORDER_DETAIL      JOD ON                                  ");
                strSQL.Append(" JO.JOB_ORDER_NO     = JOD.JOB_ORDER_NO                                  ");
                strSQL.Append(" LEFT JOIN PROCESS_MASTER PM ON JOD.PROCESS_CD      = PM.PROCESS_CD      ");
                strSQL.Append(" AND JOD.WS_CD = PM.WS_CD                                                ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S2 ON S2.KEY01  = 'ITEM_UMSR'                ");
                strSQL.Append("  AND    S2.KEY02  = JO.ORDER_UMSR                                       ");
                strSQL.Append(" WHERE  JO.JOB_ORDER_NO      = @JOB_ORDER_NO                             ");
                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "MFGINPUT");
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

        #region 投入
        /// <summary>
        /// 入力作業指示№条件でデマンドを検索
        /// <para>使用画面[MfgInput]</para>
        /// </summary>
        public DataSet Get_Mfg_InputDemandDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                      ");
            strSQL.Append(" JO.ORDER_STATUS,	    D.ITEM_NO,		I.ITEM_DESC,						");
            strSQL.Append("	D.SUB_GRP_CD,   D.AUTO_DISB_TYPE,	D.DEMAND_NO,    S.DATA_CHAR UMSR_NAME,  ");
            strSQL.Append(" (CASE D.USAGE_TYPE WHEN 0 THEN D.USAGE_DEC                                  ");
            strSQL.Append(" ELSE D.USAGE_NUMERATOR/D.USAGE_DENOMINATOR END) USAGE_QTY                   ");
            strSQL.Append(" ,ISNULL(INV.INV_QTY,0) INV_QTY,           ISNULL(WIP.WIP_QTY,0) WIP_QTY,    ");
            strSQL.Append(" (CASE WHEN (ISNULL(D.ALLOC_QTY,0)-ISNULL(D.ACT_DISB_QTY,0))<0 THEN 0 ELSE   ");
            strSQL.Append(" (ISNULL(D.ALLOC_QTY,0)-ISNULL(D.ACT_DISB_QTY,0)) END) ALLOC_QTY,            ");
            strSQL.Append(" ISNULL(WIPALLOC.WIP_ALLOC_QTY,0) W_ALLOC_QTY                                ");
            //strSQL.Append(" ,(CASE WHEN D.DEFECT_PCT>=1 THEN 0 ELSE D.DEFECT_PCT END) DEFECT_PCT        ");
            strSQL.Append(" ,D.DEFECT_PCT        ");    // 2011.06.13
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER JO                                                       ");
                //strSQL.Append(" LEFT OUTER JOIN DEMAND D ON     JO.ORDER_NO     =   D.ORDER_NO          ");       //Del 11.01.03 Ubiq-Sai
                strSQL.Append(" INNER JOIN DEMAND D ON  JO.ORDER_NO    =   D.ORDER_NO                   ");         //Add 11.01.03 Ubiq-Sai
                strSQL.Append("                         AND ( D.SUB_GRP_CD = ''                         ");         //Add 11.01.03 Ubiq-Sai
                strSQL.Append("                         OR  ( D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1) ) ");   //Add 11.01.03 Ubiq-Sai
                strSQL.Append("                         AND D.ITEM_TYPE    <> '99' 			            ");         //Add 11.01.03 Ubiq-Sai
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON D.ITEM_NO      =   I.ITEM_NO           ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'             ");
                strSQL.Append(" AND S.KEY02 = D.ITEM_UMSR                                               ");
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD,               ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) INV_QTY        ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 0                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                strSQL.Append(" GROUP BY  INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD )  INV ON    ");
                strSQL.Append("      D.ITEM_NO =   INV.ITEM_NO                                          ");
                strSQL.Append(" AND  D.DISB_WHS =   INV.WHS_CD                                          ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON WS.WS_CD = D.WS_CD               "); // 2011.03.09
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD,                ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) WIP_QTY        ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 1                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                strSQL.Append(" GROUP BY  INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD  )  WIP  ON   ");
                strSQL.Append("      D.ITEM_NO =   WIP.ITEM_NO                                          ");
                //strSQL.Append(" AND  D.WS_CD =   WIP.WS_CD                                              ");
                strSQL.Append(" AND  WIP.WS_CD =   CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN D.WS_CD ELSE WS.REP_WS_CD END "); // 2011.03.09
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT WIP_ALLOC.DEMAND_NO,SUM(WIP_ALLOC.ALLOC_QTY) WIP_ALLOC_QTY      ");
                strSQL.Append(" FROM    WIP_ALLOC                                                       ");
                strSQL.Append(" WHERE     WIP_ALLOC.ALLOC_STATUS  =   0                                 ");
                strSQL.Append(" AND     WIP_ALLOC.SCH_FLAG      IN (0,2)                                ");
                strSQL.Append(" GROUP BY  WIP_ALLOC.DEMAND_NO   )  WIPALLOC  ON                         ");
                strSQL.Append("      D.DEMAND_NO    =   WIPALLOC.DEMAND_NO                              ");
                strSQL.Append(" WHERE                                                                   ");
                strSQL.Append(" JO.JOB_ORDER_NO                   =         @JOB_ORDER_NO               ");
                //strSQL.Append(" AND  ( D.SUB_GRP_CD = ''                                                ");   //Del 11.01.03 Ubiq-Sai
                //strSQL.Append(" OR  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1)    )                 ");   //Del 11.01.03 Ubiq-Sai
                //strSQL.Append(" AND    D.ITEM_TYPE         <> '99' 			                          ");   //Del 11.01.03 Ubiq-Sai
                db.DbPsetString("JOB_ORDER_NO", _job_order_no);
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER JO                                                       ");
                //strSQL.Append(" LEFT OUTER JOIN DEMAND D ON     JO.ORDER_NO     =   D.ORDER_NO          ");       //Del 11.01.03 Ubiq-Sai
                strSQL.Append(" INNER JOIN DEMAND D ON  JO.ORDER_NO    =   D.ORDER_NO                   ");         //Add 11.01.03 Ubiq-Sai
                strSQL.Append("                         AND ( D.SUB_GRP_CD = ''                         ");         //Add 11.01.03 Ubiq-Sai
                strSQL.Append("                         OR  ( D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1) ) ");   //Add 11.01.03 Ubiq-Sai
                strSQL.Append("                         AND D.ITEM_TYPE    <> '99' 			            ");         //Add 11.01.03 Ubiq-Sai
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON D.ITEM_NO      =   I.ITEM_NO           ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'             ");
                strSQL.Append(" AND S.KEY02 = D.ITEM_UMSR                                               ");
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD,               ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) INV_QTY        ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 0                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                strSQL.Append(" GROUP BY  INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD )  INV ON    ");
                strSQL.Append("      D.ITEM_NO =   INV.ITEM_NO                                          ");
                strSQL.Append(" AND  D.DISB_WHS =   INV.WHS_CD                                          ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON WS.WS_CD = D.WS_CD               "); // 2011.03.09
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD,                ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) WIP_QTY        ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 1                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                strSQL.Append(" GROUP BY  INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD  )  WIP  ON   ");
                strSQL.Append("      D.ITEM_NO =   WIP.ITEM_NO                                          ");
                //strSQL.Append(" AND  D.WS_CD =   WIP.WS_CD                                              ");
                strSQL.Append(" AND  WIP.WS_CD =   CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN D.WS_CD ELSE WS.REP_WS_CD END "); // 2011.03.09
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT WIP_ALLOC.DEMAND_NO,SUM(WIP_ALLOC.ALLOC_QTY) WIP_ALLOC_QTY      ");
                strSQL.Append(" FROM    WIP_ALLOC                                                       ");
                strSQL.Append(" WHERE     WIP_ALLOC.ALLOC_STATUS  =   0                                 ");
                strSQL.Append(" AND     WIP_ALLOC.SCH_FLAG      IN (0,2)                                ");
                strSQL.Append(" GROUP BY  WIP_ALLOC.DEMAND_NO   )  WIPALLOC  ON                         ");
                strSQL.Append("      D.DEMAND_NO    =   WIPALLOC.DEMAND_NO                              ");
                strSQL.Append(" WHERE                                                                   ");
                strSQL.Append(" JO.JOB_ORDER_NO                   =         @JOB_ORDER_NO               ");
                //strSQL.Append(" AND  ( D.SUB_GRP_CD = ''                                                ");   //Del 11.01.03 Ubiq-Sai
                //strSQL.Append(" OR  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1)    )                 ");   //Del 11.01.03 Ubiq-Sai
                //strSQL.Append(" AND    D.ITEM_TYPE         <> '99' 			                          ");   //Del 11.01.03 Ubiq-Sai
                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
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
        /// 親投入実績
        /// </summary>
        public int Mfg_Input(ComDB db_o)
        {
            int rtn = 0;

            db_o.DbParametersClear();

            db_o.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db_o.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db_o.DbPsetDouble("@I_INPUT_QTY", _input_qty, ComConst.DB_IN);
            db_o.DbPsetString("@I_USER_ID", _user_id, ComConst.DB_IN);
            db_o.DbPsetInt("@I_JOB_ORDER_START_DATE", _job_order_start_date, ComConst.DB_IN);
            db_o.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_OUT);
            db_o.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db_o.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db_o.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db_o.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db_o.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db_o.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db_o.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db_o.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db_o.DbBeginTrans();
            rtn = db_o.DbStored("SP_MFG_INPUT");
            if (rtn == ComConst.SUCCEED)
            {
                _xfer_no = db_o.DbPgetString("@I_XFER_NO");
            }
            else
            {
                _errcode = db_o.DbPgetInt("@O_ERRCODE");
                _errmsg = db_o.DbPgetString("@O_MSG");
                _sqlcode = db_o.DbPgetInt("@O_SQLCODE");
                _dbmsg = db_o.DbPgetString("@O_SQLMSG");
                _proc_name = db_o.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 子部品投入実績
        /// </summary>
        public int Mfg_Parts_Input(ComDB db_o)
        {
            int rtn = 0;

            db_o.DbParametersClear();

            db_o.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db_o.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_IN);
            db_o.DbPsetString("@I_DEMAND_NO", _demand_no, ComConst.DB_IN);
            db_o.DbPsetDouble("@I_PARTS_INPUT_QTY", _parts_input_qty, ComConst.DB_IN);
            db_o.DbPsetInt("@I_JOB_ORDER_START_DATE", _job_order_start_date, ComConst.DB_IN);//ADD BY UBIQ-SUO 2010/12/29
            db_o.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db_o.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db_o.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db_o.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db_o.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db_o.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db_o.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db_o.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db_o.DbBeginTrans();
            rtn = db_o.DbStored("SP_MFG_PARTS_INPUT");
            if (rtn == ComConst.SUCCEED)
            {
                //do nothing
            }
            else
            {
                _errcode = db_o.DbPgetInt("@O_ERRCODE");
                _errmsg = db_o.DbPgetString("@O_MSG");
                _sqlcode = db_o.DbPgetInt("@O_SQLCODE");
                _dbmsg = db_o.DbPgetString("@O_SQLMSG");
                _proc_name = db_o.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 作業指示№と選択工程で指示済製造オーダ、作業指示を検索して表示する。[工程別投入]
        /// </summary>
        public DataSet Get_Mfg_ProcessInputDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                              ");
            strSQL.Append(" JD.JOB_ORDER_STATUS ORDER_STATUS,     WS.COMPL_FLAG,   JD.INPUT_FLAG,     J.WS_CD,        WS.WS_DESC, ");//UPD BY UBIQ-SUO 2011/1/10
            strSQL.Append(" J.SCH_START_DATE,	J.SCH_COMPL_DATE,			J.ITEM_NO,			J.ITEM_DESC,	");
            strSQL.Append(" J.JOB_ORDER_QTY,    J.ORDER_UMSR,               JD.INPUT_QTY,       J.WHS_CD,       ");
            strSQL.Append(" WHS.WHS_DESC,       J.INSP_CD,                  J.JOC_CD,           J.SLIP_NOTE,    ");
            //strSQL.Append(" J.REJ_QTY,																			");     //Del 11.01.03 Ubiq-Sai
            strSQL.Append(" JD.REJ_QTY,																			");         //Add 11.01.03 Ubiq-Sai
            //strSQL.Append(" JD.INPUT_QTY,       J.JOB_ORDER_COMPL_QTY,		S.DATA_CHAR UMSR_NAME				");     //Del 11.01.03 Ubiq-Sai
            strSQL.Append(" JD.INPUT_QTY,       JD.COMPL_QTY JOB_ORDER_COMPL_QTY,	S.DATA_CHAR UMSR_NAME		");         //Add 11.01.03 Ubiq-Sai
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER J                                                        ");
                strSQL.Append(" INNER JOIN JOB_ORDER_DETAIL JD ON J.JOB_ORDER_NO = JD.JOB_ORDER_NO      ");
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WS ON J.WS_CD = WS.WS_CD                      ");
                strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER WHS ON J.WHS_CD = WHS.WHS_CD                 ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON  S.KEY01  = 'ITEM_UMSR'                 ");
                strSQL.Append("  AND    S.KEY02 = J.ORDER_UMSR                                          ");
                strSQL.Append("  WHERE      J.JOB_ORDER_NO      = :JOB_ORDER_NO                         ");
                strSQL.Append("  AND        JD.PROCESS_CD       = :PROCESS_CD                           ");
                strSQL.Append("  AND        JD.PROCESS_SEQ      = :PROCESS_SEQ                          ");

                db.DbPsetString("JOB_ORDER_NO", _job_order_no);
                db.DbPsetString("PROCESS_CD", _process_cd);
                db.DbPsetInt("PROCESS_SEQ", _seq);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER J                                                        ");
                strSQL.Append(" INNER JOIN JOB_ORDER_DETAIL JD ON J.JOB_ORDER_NO = JD.JOB_ORDER_NO      ");
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WS ON J.WS_CD = WS.WS_CD                      ");
                strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER WHS ON J.WHS_CD = WHS.WHS_CD                 ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON  S.KEY01  = 'ITEM_UMSR'                 ");
                strSQL.Append("  AND    S.KEY02 = J.ORDER_UMSR                                          ");
                strSQL.Append("  WHERE      J.JOB_ORDER_NO      = @JOB_ORDER_NO                         ");
                strSQL.Append("  AND        JD.PROCESS_CD       = @PROCESS_CD                           ");
                strSQL.Append("  AND        JD.PROCESS_SEQ      = @PROCESS_SEQ                          ");

                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                db.DbPsetString("@PROCESS_CD", _process_cd);
                db.DbPsetInt("@PROCESS_SEQ", _seq);
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
        /// 入力作業指示№条件でデマンドを検索[工程別投入]
        /// </summary>
        public DataSet Get_Mfg_ProcessInputDemandDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                      ");
            strSQL.Append(" JO.ORDER_STATUS,		D.ITEM_NO,		I.ITEM_DESC,						");
            strSQL.Append(" D.ITEM_UMSR,			D.SUB_GRP_CD,										");
            strSQL.Append(" D.AUTO_DISB_TYPE,	    D.DEMAND_NO,    S.DATA_CHAR UMSR_NAME,              ");
            strSQL.Append(" (CASE D.USAGE_TYPE WHEN 0 THEN D.USAGE_DEC                                  ");
            strSQL.Append(" ELSE D.USAGE_NUMERATOR/D.USAGE_DENOMINATOR END) USAGE_QTY,                  ");
            strSQL.Append(" ISNULL(INV.INV_QTY,0) INV_QTY,           ISNULL(WIP.WIP_QTY,0) WIP_QTY,     ");
            strSQL.Append(" (CASE WHEN (ISNULL(D.ALLOC_QTY,0)-ISNULL(D.ACT_DISB_QTY,0))<0 THEN 0 ELSE   ");
            strSQL.Append(" (ISNULL(D.ALLOC_QTY,0)-ISNULL(D.ACT_DISB_QTY,0)) END) ALLOC_QTY,            ");
            strSQL.Append(" ISNULL(WIPALLOC.WIP_ALLOC_QTY,0) W_ALLOC_QTY                                ");	// 2011.07.11 , とる
            //strSQL.Append(" (CASE WHEN D.DEFECT_PCT>=1 THEN 0 ELSE D.DEFECT_PCT END) DEFECT_PCT         ");
            strSQL.Append(" ,D.DEFECT_PCT        ");    // 2011.06.13
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER JO														");
                strSQL.Append(" LEFT OUTER JOIN JOB_ORDER_DETAIL JOD ON									");
                strSQL.Append("								JO.JOB_ORDER_NO     =   JOD.JOB_ORDER_NO	");
                //strSQL.Append(" LEFT OUTER JOIN DEMAND D ON     JOD.ORDER_NO    =   D.ORDER_NO          ");       //Del 11.01.03 Ubiq-Sai
                strSQL.Append(" INNER JOIN DEMAND D ON          JOD.ORDER_NO    =   D.ORDER_NO          ");         //Add 11.01.03 Ubiq-Sai
                strSQL.Append("                         AND     JOD.PROCESS_CD  =   D.PROCESS_CD        ");
                strSQL.Append("                         AND  ( D.SUB_GRP_CD = ''                        ");         //Add 11.01.03 Ubiq-Sai
                strSQL.Append("                          OR  ( D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1) ) ");  //Add 11.01.03 Ubiq-Sai
                strSQL.Append("                         AND    D.ITEM_TYPE         <> '99' 			    ");         //Add 11.01.03 Ubiq-Sai
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON D.ITEM_NO      =   I.ITEM_NO           ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01   =   'ITEM_UMSR'         ");
                strSQL.Append("                                   AND S.KEY02   =   D.ITEM_UMSR         ");

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO,    WHS_CD,   SUM(INV_BAL-ALLOC_QTY) INV_QTY            ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INV_YM          =   0                                           ");
                strSQL.Append("     AND INV_WIP_TYPE    =   0                                           ");
                strSQL.Append("     AND INV_TYPE        =   0                                           ");
                strSQL.Append(" GROUP BY  ITEM_NO,  WHS_CD )  INV ON D.ITEM_NO  =   INV.ITEM_NO         ");
                strSQL.Append("                                  AND D.DISB_WHS =   INV.WHS_CD          ");

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO,    WS_CD,     SUM(INV_BAL-ALLOC_QTY) WIP_QTY           ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INV_YM          =   0                                           ");
                strSQL.Append("     AND INV_WIP_TYPE    =   1                                           ");
                strSQL.Append("     AND INV_TYPE        =   0                                           ");
                strSQL.Append(" GROUP BY  ITEM_NO,  WS_CD  )  WIP  ON D.ITEM_NO =   WIP.ITEM_NO         ");
                strSQL.Append("                                   AND D.WS_CD   =   WIP.WS_CD           ");

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT DEMAND_NO,      SUM(ALLOC_QTY) WIP_ALLOC_QTY                    ");
                strSQL.Append(" FROM    WIP_ALLOC                                                       ");
                strSQL.Append(" WHERE   ALLOC_STATUS  =   0                                             ");
                strSQL.Append("     AND SCH_FLAG      IN (0,2)                                          ");
                strSQL.Append(" GROUP BY  DEMAND_NO)  WIPALLOC  ON  D.DEMAND_NO = WIPALLOC.DEMAND_NO    ");
                strSQL.Append(" WHERE  JO.JOB_ORDER_NO  =  @JOB_ORDER_NO                                ");
                strSQL.Append("     AND    JOD.PROCESS_CD = @PROCESS_CD 			                    ");
                strSQL.Append("     AND    JOD.PROCESS_SEQ = @PROCESS_SEQ		                        ");
                //strSQL.Append("     AND  ( D.SUB_GRP_CD = ''                                            ");   //Del 11.01.03 Ubiq-Sai
                //strSQL.Append("            OR  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1)    )      ");   //Del 11.01.03 Ubiq-Sai
                //strSQL.Append("     AND    D.ITEM_TYPE         <> '99' 			                      ");   //Del 11.01.03 Ubiq-Sai
                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                db.DbPsetString("@PROCESS_CD", _process_cd);
                db.DbPsetInt("@PROCESS_SEQ", _seq);
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER JO														");
                strSQL.Append(" LEFT OUTER JOIN JOB_ORDER_DETAIL JOD ON									");
                strSQL.Append("								JO.JOB_ORDER_NO     =   JOD.JOB_ORDER_NO	");
                //strSQL.Append(" LEFT OUTER JOIN DEMAND D ON     JOD.ORDER_NO    =   D.ORDER_NO          ");       //Del 11.01.03 Ubiq-Sai
                strSQL.Append(" INNER JOIN DEMAND D ON          JOD.ORDER_NO    =   D.ORDER_NO          ");         //Add 11.01.03 Ubiq-Sai
                strSQL.Append("                         AND     JOD.PROCESS_CD  =   D.PROCESS_CD        ");
                strSQL.Append("                         AND  ( D.SUB_GRP_CD = ''                        ");         //Add 11.01.03 Ubiq-Sai
                strSQL.Append("                          OR  ( D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1) ) ");  //Add 11.01.03 Ubiq-Sai
                strSQL.Append("                         AND    D.ITEM_TYPE         <> '99' 			    ");         //Add 11.01.03 Ubiq-Sai
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON D.ITEM_NO      =   I.ITEM_NO           ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01   =   'ITEM_UMSR'         ");
                strSQL.Append("                                   AND S.KEY02   =   D.ITEM_UMSR         ");

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO,    WHS_CD,   SUM(INV_BAL-ALLOC_QTY) INV_QTY            ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INV_YM          =   0                                           ");
                strSQL.Append("     AND INV_WIP_TYPE    =   0                                           ");
                strSQL.Append("     AND INV_TYPE        =   0                                           ");
                strSQL.Append(" GROUP BY  ITEM_NO,  WHS_CD )  INV ON D.ITEM_NO  =   INV.ITEM_NO         ");
                strSQL.Append("                                  AND D.DISB_WHS =   INV.WHS_CD          ");

                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON WS.WS_CD = D.WS_CD               "); // 2011.03.09

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO,    WS_CD,     SUM(INV_BAL-ALLOC_QTY) WIP_QTY           ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INV_YM          =   0                                           ");
                strSQL.Append("     AND INV_WIP_TYPE    =   1                                           ");
                strSQL.Append("     AND INV_TYPE        =   0                                           ");
                strSQL.Append(" GROUP BY  ITEM_NO,  WS_CD  )  WIP  ON D.ITEM_NO =   WIP.ITEM_NO         ");
                //strSQL.Append("                                   AND D.WS_CD   =   WIP.WS_CD           ");
                strSQL.Append(" AND  WIP.WS_CD =   CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN D.WS_CD ELSE WS.REP_WS_CD END "); // 2011.03.09

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT DEMAND_NO,      SUM(ALLOC_QTY) WIP_ALLOC_QTY                    ");
                strSQL.Append(" FROM    WIP_ALLOC                                                       ");
                strSQL.Append(" WHERE   ALLOC_STATUS  =   0                                             ");
                strSQL.Append("     AND SCH_FLAG      IN (0,2)                                          ");
                strSQL.Append(" GROUP BY  DEMAND_NO)  WIPALLOC  ON  D.DEMAND_NO = WIPALLOC.DEMAND_NO    ");
                strSQL.Append(" WHERE  JO.JOB_ORDER_NO  =  @JOB_ORDER_NO                                ");
                strSQL.Append("     AND    JOD.PROCESS_CD = @PROCESS_CD 			                    ");
                strSQL.Append("     AND    JOD.PROCESS_SEQ = @PROCESS_SEQ		                        ");
                //strSQL.Append("     AND  ( D.SUB_GRP_CD = ''                                            ");   //Del 11.01.03 Ubiq-Sai
                //strSQL.Append("            OR  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1)    )      ");   //Del 11.01.03 Ubiq-Sai
                //strSQL.Append("     AND    D.ITEM_TYPE         <> '99' 			                      ");   //Del 11.01.03 Ubiq-Sai
                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                db.DbPsetString("@PROCESS_CD", _process_cd);
                db.DbPsetInt("@PROCESS_SEQ", _seq);
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
        /// 親投入実績[工程別投入]
        /// </summary>
        public int Mfg_ProcessInput(ComDB db_o)
        {
            int rtn = 0;

            db_o.DbParametersClear();

            db_o.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db_o.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db_o.DbPsetInt("@I_PROCESS_SEQ", _seq, ComConst.DB_IN);
            db_o.DbPsetDouble("@I_INPUT_QTY", _input_qty, ComConst.DB_IN);
            db_o.DbPsetString("@I_USER_ID", _user_id, ComConst.DB_IN);
            db_o.DbPsetInt("@I_JOB_ORDER_START_DATE", _job_order_start_date, ComConst.DB_IN);
            db_o.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_OUT);
            db_o.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db_o.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db_o.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db_o.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db_o.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db_o.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db_o.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db_o.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db_o.DbBeginTrans();
            rtn = db_o.DbStored("SP_MFG_PROCESS_INPUT");
            if (rtn == ComConst.SUCCEED)
            {
                _xfer_no = db_o.DbPgetString("@I_XFER_NO");
            }
            else
            {
                _errcode = db_o.DbPgetInt("@O_ERRCODE");
                _errmsg = db_o.DbPgetString("@O_MSG");
                _sqlcode = db_o.DbPgetInt("@O_SQLCODE");
                _dbmsg = db_o.DbPgetString("@O_SQLMSG");
                _proc_name = db_o.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 入力条件で投入実績データを検索する
        /// </summary>
        public DataSet Get_Mfg_InputCancelList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append("JO.JOB_ORDER_NO,		JO.ITEM_NO,			JO.ITEM_DESC,	    JO.WS_CD,	    ");
            strSQL.Append("TR.INST_QTY,	        TR.ITEM_UMSR,		TR.SLIP_DATE,						");
            strSQL.Append("TR.TO_JOC_CD,		TR.TO_WHS_CD,		TR.PARTIAL_DELV_COMPL_CNT,			");
            strSQL.Append("WS.WS_DESC,          TR.XFER_NO,			S1.DATA_CHAR UMSR_NAME				");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER JO                                                       ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON  JO.WS_CD   = WS.WS_CD            ");
                strSQL.Append(" INNER JOIN TRANSFER_TRANS TR ON  JO.ORDER_NO   = TR.ORDER_NO            ");
                strSQL.Append("  AND    TR.TO_PROCESS_CD    = ''                                        ");
                strSQL.Append("  AND    TR.XFER_STATUS      < 90                                        ");
                strSQL.Append("  AND    TR.REQ_TYPE         = '62'                                      ");
                if (_beg_slip_date != 0)
                {
                    strSQL.Append("  AND    TR.SLIP_DATE        >= @BEG_SLIP_DATE                       ");
                    db.DbPsetInt("@BEG_SLIP_DATE", _beg_slip_date);
                }
                if (_end_slip_date != 0)
                {
                    strSQL.Append("  AND    TR.SLIP_DATE        <= @END_SLIP_DATE                       ");
                    db.DbPsetInt("@END_SLIP_DATE", _end_slip_date);
                }
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON  S1.KEY01  = 'ITEM_UMSR'         ");
                strSQL.Append("  AND    S1.KEY02            = TR.ITEM_UMSR                              ");
                strSQL.Append(" WHERE   1=1																");
                if (_job_order_no != "")
                {
                    strSQL.Append("  AND    JO.JOB_ORDER_NO     = @JOB_ORDER_NO                         ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND    JO.WS_CD            = @WS_CD                                ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("  AND    JO.ITEM_NO          = @ITEM_NO                              ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("  AND    JO.JOC_CD           = @JOC_CD                               ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER JO                                                       ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON  JO.WS_CD   = WS.WS_CD            ");
                strSQL.Append(" INNER JOIN TRANSFER_TRANS TR ON  JO.ORDER_NO   = TR.ORDER_NO            ");
                strSQL.Append("  AND    TR.TO_PROCESS_CD    = ''                                        ");
                strSQL.Append("  AND    TR.XFER_STATUS      < 90                                        ");
                strSQL.Append("  AND    TR.REQ_TYPE         = '62'                                      ");
                if (_beg_slip_date != 0)
                {
                    strSQL.Append("  AND    TR.SLIP_DATE        >= @BEG_SLIP_DATE                       ");
                    db.DbPsetInt("@BEG_SLIP_DATE", _beg_slip_date);
                }
                if (_end_slip_date != 0)
                {
                    strSQL.Append("  AND    TR.SLIP_DATE        <= @END_SLIP_DATE                       ");
                    db.DbPsetInt("@END_SLIP_DATE", _end_slip_date);
                }
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON  S1.KEY01  = 'ITEM_UMSR'         ");
                strSQL.Append("  AND    S1.KEY02            = TR.ITEM_UMSR                              ");
                strSQL.Append(" WHERE   1=1																");
                if (_job_order_no != "")
                {
                    strSQL.Append("  AND    JO.JOB_ORDER_NO     = @JOB_ORDER_NO                         ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND    JO.WS_CD            = @WS_CD                                ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("  AND    JO.ITEM_NO          = @ITEM_NO                              ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("  AND    JO.JOC_CD           = @JOC_CD                               ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
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
        /// 投入実績データを検索[工程別]
        /// </summary>
        public DataSet Get_Mfg_ProcessInputCancelList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append("TR.PO_NO,		    TR.ITEM_NO,	        TR.ITEM_DESC,	    TR.TO_WS_CD,	");
            strSQL.Append("WS.WS_DESC,	        TR.TO_PROCESS_CD,	PM.PROCESS_DESC,    TR.INST_QTY,    ");
            strSQL.Append("TR.ITEM_UMSR,        TR.SLIP_DATE,       TR.TO_JOC_CD,		TR.TO_WHS_CD,	");
            strSQL.Append("TR.PARTIAL_DELV_COMPL_CNT,		TR.XFER_NO,			S1.DATA_CHAR UMSR_NAME	");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS TR                                                  ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON  TR.TO_WS_CD   = WS.WS_CD			");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PM ON  TR.TO_WS_CD    = PM.WS_CD			");
                strSQL.Append("                               AND  TR.TO_PROCESS_CD  = PM.PROCESS_CD	");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON  S1.KEY01  = 'ITEM_UMSR'         ");
                strSQL.Append("                                    AND  S1.KEY02  = TR.ITEM_UMSR        ");
                strSQL.Append(" WHERE   TR.XFER_STATUS  <  90                                           ");//取消
                strSQL.Append("     AND TR.TO_PROCESS_CD <> ''                                          ");
                strSQL.Append("     AND TR.REQ_TYPE     = '62'                                          ");

                if (_job_order_no != "")
                {
                    strSQL.Append("  AND    TR.PO_NO     = @JOB_ORDER_NO                         ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND    TR.TO_WS_CD            = @WS_CD                           ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_process_cd != "")
                {
                    strSQL.Append("  AND    TR.TO_PROCESS_CD       = @PROCESS_CD                      ");
                    db.DbPsetString("@PROCESS_CD", _process_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("  AND    TR.ITEM_NO          = @ITEM_NO                              ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("  AND    TR.TO_JOC_CD        = @JOC_CD                               ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (_beg_slip_date != 0)
                {
                    strSQL.Append("  AND    TR.SLIP_DATE        >= @BEG_SLIP_DATE                       ");
                    db.DbPsetInt("@BEG_SLIP_DATE", _beg_slip_date);
                }
                if (_end_slip_date != 0)
                {
                    strSQL.Append("  AND    TR.SLIP_DATE        <= @END_SLIP_DATE                       ");
                    db.DbPsetInt("@END_SLIP_DATE", _end_slip_date);
                }
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM TRANSFER_TRANS TR                                                  ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON  TR.TO_WS_CD   = WS.WS_CD			");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PM ON  TR.TO_WS_CD    = PM.WS_CD			");
                strSQL.Append("                               AND  TR.TO_PROCESS_CD  = PM.PROCESS_CD	");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON  S1.KEY01  = 'ITEM_UMSR'         ");
                strSQL.Append("                                    AND  S1.KEY02  = TR.ITEM_UMSR        ");
                strSQL.Append(" WHERE   TR.XFER_STATUS  <  90                                           ");//取消
                strSQL.Append("     AND TR.TO_PROCESS_CD <> ''                                          ");
                strSQL.Append("     AND TR.REQ_TYPE     = '62'                                          ");

                if (_job_order_no != "")
                {
                    strSQL.Append("  AND    TR.PO_NO     = @JOB_ORDER_NO                         ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND    TR.TO_WS_CD            = @WS_CD                           ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_process_cd != "")
                {
                    strSQL.Append("  AND    TR.TO_PROCESS_CD       = @PROCESS_CD                      ");
                    db.DbPsetString("@PROCESS_CD", _process_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append("  AND    TR.ITEM_NO          = @ITEM_NO                              ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("  AND    TR.TO_JOC_CD        = @JOC_CD                               ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (_beg_slip_date != 0)
                {
                    strSQL.Append("  AND    TR.SLIP_DATE        >= @BEG_SLIP_DATE                       ");
                    db.DbPsetInt("@BEG_SLIP_DATE", _beg_slip_date);
                }
                if (_end_slip_date != 0)
                {
                    strSQL.Append("  AND    TR.SLIP_DATE        <= @END_SLIP_DATE                       ");
                    db.DbPsetInt("@END_SLIP_DATE", _end_slip_date);
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
        /// 作業着手・投入取消
        /// </summary>
        public int Mfg_InputCancel()
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
            rtn = db.DbStored("SP_MFG_INPUTCANCEL");
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
        #endregion

        #region 償却処理
        /// <summary>
        /// 入力検索条件で指示済未完成の製造オーダを検索して表示する。
        /// <para>使用画面:償却処理</para>
        /// </summary>
        public DataSet Get_Mfg_ScrapList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT																			");
            strSQL.Append(" J.JOB_ORDER_NO,	    J.ITEM_NO,			J.ITEM_DESC,		J.WS_CD,			");
            strSQL.Append("	WS.WS_DESC,			JD.PROCESS_CD,		P.PROCESS_DESC,		JD.SCH_COMPL_DATE,	");
            strSQL.Append("	J.ORDER_QTY,		JD.COMPL_QTY,		JD.REJ_QTY,			J.ORDER_UMSR,		");
            strSQL.Append("	S.DATA_CHAR UMSR_NAME,					JD.COMPL_DATE,		J.JOC_CD,			");
            strSQL.Append("	J.WHS_CD																		");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER J															");
                strSQL.Append(" LEFT OUTER JOIN JOB_ORDER_DETAIL JD ON  J.JOB_ORDER_NO   =  JD.JOB_ORDER_NO ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'					");
                strSQL.Append("									AND S.KEY02 = J.ORDER_UMSR					");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON  J.WS_CD   =  WS.WS_CD				");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER P ON  JD.WS_CD   =  P.WS_CD					");
                strSQL.Append("									AND JD.PROCESS_CD = P.PROCESS_CD			");
                strSQL.Append(" WHERE  J.ORDER_STATUS < 85                                                  ");
                if (_job_order_no != "")
                {
                    strSQL.Append(" AND	J.JOB_ORDER_NO        =         @JOB_ORDER_NO               ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append(" AND	J.JOC_CD        =         @JOC_CD               ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND	J.WS_CD        =         @WS_CD               ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_sch_compl_date_from != 0)
                {
                    strSQL.Append(" AND	JD.SCH_COMPL_DATE        >=         @SCH_COMPL_DATE_FROM               ");
                    db.DbPsetInt("@SCH_COMPL_DATE_FROM", _sch_compl_date_from);
                }
                if (_sch_compl_date_to != 0)
                {
                    strSQL.Append(" AND	JD.SCH_COMPL_DATE        <=         @SCH_COMPL_DATE_TO               ");
                    db.DbPsetInt("@SCH_COMPL_DATE_TO", _sch_compl_date_to);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND	J.ITEM_NO        =         @ITEM_NO               ");
                    db.DbPsetString("@WS_CD", _item_no);
                }
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER J															");
                strSQL.Append(" LEFT OUTER JOIN JOB_ORDER_DETAIL JD ON  J.JOB_ORDER_NO   =  JD.JOB_ORDER_NO ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'					");
                strSQL.Append("									AND S.KEY02 = J.ORDER_UMSR					");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON  J.WS_CD   =  WS.WS_CD				");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER P ON  JD.WS_CD   =  P.WS_CD					");
                strSQL.Append("									AND JD.PROCESS_CD = P.PROCESS_CD			");
                strSQL.Append(" WHERE  J.ORDER_STATUS < 85                                                  ");
                if (_job_order_no != "")
                {
                    strSQL.Append(" AND	J.JOB_ORDER_NO        =         @JOB_ORDER_NO               ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append(" AND	J.JOC_CD        =         @JOC_CD               ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND	J.WS_CD        =         @WS_CD               ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_sch_compl_date_from != 0)
                {
                    strSQL.Append(" AND	JD.SCH_COMPL_DATE        >=         @SCH_COMPL_DATE_FROM               ");
                    db.DbPsetInt("@SCH_COMPL_DATE_FROM", _sch_compl_date_from);
                }
                if (_sch_compl_date_to != 0)
                {
                    strSQL.Append(" AND	JD.SCH_COMPL_DATE        <=         @SCH_COMPL_DATE_TO               ");
                    db.DbPsetInt("@SCH_COMPL_DATE_TO", _sch_compl_date_to);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND	J.ITEM_NO        =         @ITEM_NO               ");
                    db.DbPsetString("@ITEM_NO", _item_no);
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
        /// 
        /// <para>使用画面:償却処理</para>
        /// </summary>
        public DataSet Get_Mfg_ScrapDemandDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                      ");
            strSQL.Append(" D.ITEM_NO,			I.ITEM_DESC,		D.ITEM_UMSR,		D.SUB_GRP_CD,	");
            strSQL.Append(" D.AUTO_DISB_TYPE,	D.DEMAND_NO,		S.DATA_CHAR UMSR_NAME,              ");
            strSQL.Append(" D.PLAN_QTY,			D.INPUT_QTY,											");
            strSQL.Append(" (CASE D.USAGE_TYPE WHEN 0 THEN D.USAGE_DEC                                  ");
            strSQL.Append(" ELSE D.USAGE_NUMERATOR/D.USAGE_DENOMINATOR END) USAGE_QTY,                  ");
            strSQL.Append(" ISNULL(INV.INV_QTY,0) INV_QTY,           ISNULL(WIP.WIP_QTY,0) WIP_QTY,     ");
            strSQL.Append(" (CASE WHEN (ISNULL(D.ALLOC_QTY,0)-ISNULL(D.ACT_DISB_QTY,0))<0 THEN 0 ELSE   ");
            strSQL.Append(" (ISNULL(D.ALLOC_QTY,0)-ISNULL(D.ACT_DISB_QTY,0)) END) ALLOC_QTY,            ");
            strSQL.Append(" ISNULL(WIPALLOC.WIP_ALLOC_QTY,0) W_ALLOC_QTY                                ");		// 2011.07.11 , とる
            //strSQL.Append(" (CASE WHEN D.DEFECT_PCT>=1 THEN 0 ELSE D.DEFECT_PCT END) DEFECT_PCT         ");
            strSQL.Append(" ,D.DEFECT_PCT        ");    // 2011.06.13
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER JO														");
                strSQL.Append(" INNER JOIN JOB_ORDER_DETAIL JOD ON										");
                strSQL.Append("								JO.JOB_ORDER_NO     =   JOD.JOB_ORDER_NO	");
                strSQL.Append(" LEFT OUTER JOIN DEMAND D ON     JOD.ORDER_NO    =   D.ORDER_NO          ");
                strSQL.Append("                         AND     JOD.PROCESS_CD  =   D.PROCESS_CD        ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON D.ITEM_NO      =   I.ITEM_NO           ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01   =   'ITEM_UMSR'         ");
                strSQL.Append("                                   AND S.KEY02   =   D.ITEM_UMSR         ");

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO,    WHS_CD,   SUM(INV_BAL-ALLOC_QTY) INV_QTY            ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INV_YM          =   0                                           ");
                strSQL.Append("     AND INV_WIP_TYPE    =   0                                           ");
                strSQL.Append("     AND INV_TYPE        =   0                                           ");
                strSQL.Append(" GROUP BY  ITEM_NO,  WHS_CD )  INV ON D.ITEM_NO  =   INV.ITEM_NO         ");
                strSQL.Append("                                  AND D.DISB_WHS =   INV.WHS_CD          ");

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO,    WS_CD,     SUM(INV_BAL-ALLOC_QTY) WIP_QTY           ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INV_YM          =   0                                           ");
                strSQL.Append("     AND INV_WIP_TYPE    =   1                                           ");
                strSQL.Append("     AND INV_TYPE        =   0                                           ");
                strSQL.Append(" GROUP BY  ITEM_NO,  WS_CD  )  WIP  ON D.ITEM_NO =   WIP.ITEM_NO         ");
                strSQL.Append("                                   AND D.WS_CD   =   WIP.WS_CD           ");

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT DEMAND_NO,      SUM(ALLOC_QTY) WIP_ALLOC_QTY                    ");
                strSQL.Append(" FROM    WIP_ALLOC                                                       ");
                strSQL.Append(" WHERE   ALLOC_STATUS  =   0                                             ");
                strSQL.Append("     AND SCH_FLAG      IN (0,2)                                          ");
                strSQL.Append(" GROUP BY  DEMAND_NO)  WIPALLOC  ON  D.DEMAND_NO = WIPALLOC.DEMAND_NO    ");
                strSQL.Append(" WHERE  JO.JOB_ORDER_NO  =  @JOB_ORDER_NO                                ");
                strSQL.Append("     AND    JOD.PROCESS_CD = @PROCESS_CD 			                    ");
                strSQL.Append("     AND    JOD.PROCESS_SEQ = @PROCESS_SEQ		                        ");
                strSQL.Append("     AND  ( D.SUB_GRP_CD = ''                                            ");
                strSQL.Append("            OR  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1)    )      ");
                strSQL.Append("     AND    D.ITEM_TYPE         <> '99' 			                        ");
                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                db.DbPsetString("@PROCESS_CD", _process_cd);

            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER JO														");
                strSQL.Append(" INNER JOIN JOB_ORDER_DETAIL JOD ON										");
                strSQL.Append("								JO.JOB_ORDER_NO     =   JOD.JOB_ORDER_NO	");
                strSQL.Append(" LEFT OUTER JOIN DEMAND D ON     JOD.ORDER_NO    =   D.ORDER_NO          ");
                strSQL.Append("                         AND     JOD.PROCESS_CD  =   D.PROCESS_CD        ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON D.ITEM_NO      =   I.ITEM_NO           ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01   =   'ITEM_UMSR'         ");
                strSQL.Append("                                   AND S.KEY02   =   D.ITEM_UMSR         ");

                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON WS.WS_CD = D.WS_CD               "); // 2011.03.09

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO,    WHS_CD,   SUM(INV_BAL-ALLOC_QTY) INV_QTY            ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INV_YM          =   0                                           ");
                strSQL.Append("     AND INV_WIP_TYPE    =   0                                           ");
                strSQL.Append("     AND INV_TYPE        =   0                                           ");
                strSQL.Append(" GROUP BY  ITEM_NO,  WHS_CD )  INV ON D.ITEM_NO  =   INV.ITEM_NO         ");
                strSQL.Append("                                  AND D.DISB_WHS =   INV.WHS_CD          ");

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO,    WS_CD,     SUM(INV_BAL-ALLOC_QTY) WIP_QTY           ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INV_YM          =   0                                           ");
                strSQL.Append("     AND INV_WIP_TYPE    =   1                                           ");
                strSQL.Append("     AND INV_TYPE        =   0                                           ");
                strSQL.Append(" GROUP BY  ITEM_NO,  WS_CD  )  WIP  ON D.ITEM_NO =   WIP.ITEM_NO         ");
                //strSQL.Append("                                   AND D.WS_CD   =   WIP.WS_CD           ");
                strSQL.Append(" AND  WIP.WS_CD =   CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN D.WS_CD ELSE WS.REP_WS_CD END "); // 2011.03.09

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT DEMAND_NO,      SUM(ALLOC_QTY) WIP_ALLOC_QTY                    ");
                strSQL.Append(" FROM    WIP_ALLOC                                                       ");
                strSQL.Append(" WHERE   ALLOC_STATUS  =   0                                             ");
                strSQL.Append("     AND SCH_FLAG      IN (0,2)                                          ");
                strSQL.Append(" GROUP BY  DEMAND_NO)  WIPALLOC  ON  D.DEMAND_NO = WIPALLOC.DEMAND_NO    ");
                strSQL.Append(" WHERE  JO.JOB_ORDER_NO  =  @JOB_ORDER_NO                                ");
                strSQL.Append("     AND    JOD.PROCESS_CD = @PROCESS_CD 			                    ");
                strSQL.Append("     AND  ( D.SUB_GRP_CD = ''                                            ");
                strSQL.Append("            OR  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1)    )      ");
                strSQL.Append("     AND    D.ITEM_TYPE         <> '99' 			                        ");
                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                db.DbPsetString("@PROCESS_CD", _process_cd);
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
        /// 親償却実績登録
        /// </summary>
        public int Mfg_Scrap(ComDB db_o)
        {
            int rtn = 0;

            db_o.DbParametersClear();

            db_o.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db_o.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db_o.DbPsetDouble("@I_SCRAP_QTY", _scrap_qty, ComConst.DB_IN);
            db_o.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_OUT);
            db_o.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db_o.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db_o.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db_o.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db_o.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db_o.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db_o.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db_o.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db_o.DbBeginTrans();
            rtn = db_o.DbStored("SP_MFG_SCRAP");
            if (rtn == ComConst.SUCCEED)
            {
                _xfer_no = db_o.DbPgetString("@I_XFER_NO");
            }
            else
            {
                _errcode = db_o.DbPgetInt("@O_ERRCODE");
                _errmsg = db_o.DbPgetString("@O_MSG");
                _sqlcode = db_o.DbPgetInt("@O_SQLCODE");
                _dbmsg = db_o.DbPgetString("@O_SQLMSG");
                _proc_name = db_o.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 子部品償却実績登録
        /// </summary>
        public int Mfg_Parts_Scrap(ComDB db_o)
        {
            int rtn = 0;

            db_o.DbParametersClear();

            db_o.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db_o.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_IN);
            db_o.DbPsetString("@I_DEMAND_NO", _demand_no, ComConst.DB_IN);
            db_o.DbPsetDouble("@I_PARTS_SCRAP_QTY", _parts_scrap_qty, ComConst.DB_IN);
            db_o.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db_o.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db_o.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db_o.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db_o.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db_o.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db_o.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db_o.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db_o.DbBeginTrans();
            rtn = db_o.DbStored("SP_MFG_PARTS_SCRAP");
            if (rtn == ComConst.SUCCEED)
            {
                //do nothing
            }
            else
            {
                _errcode = db_o.DbPgetInt("@O_ERRCODE");
                _errmsg = db_o.DbPgetString("@O_MSG");
                _sqlcode = db_o.DbPgetInt("@O_SQLCODE");
                _dbmsg = db_o.DbPgetString("@O_SQLMSG");
                _proc_name = db_o.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        /// <summary>
        /// 償却実績と仕掛引当明細データを検索して引当結果
        /// <para>使用画面:償却処理</para>
        /// </summary>
        public DataSet Get_Mfg_ScrapAllocDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                      ");
            strSQL.Append(" TT.ITEM_NO,			TT.ITEM_DESC,		TT.FROM_WHS_CD,		TT.INST_QTY,	");
            strSQL.Append(" TT.FROM_SUPPLY_TYPE,					S.DATA_CHAR UMSR_NAME,              ");
            strSQL.Append(" ISNULL(INV.INV_QTY,0) INV_QTY,           ISNULL(WIP.WIP_QTY,0) WIP_QTY,     ");
            strSQL.Append(" ISNULL(WIPALLOC.ALLOC_QTY,0) ALLOC_QTY,										");
            strSQL.Append(" ISNULL(WIPALLOC.WIP_ALLOC_QTY,0) WIP_ALLOC_QTY,								");
            strSQL.Append(" (TT.INST_QTY-ISNULL(WIPALLOC.ALLOC_QTY,0)-ISNULL(WIPALLOC.WIP_ALLOC_QTY,0)) MISS_QTY");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM TRANSFER_TRANS TT													");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01   =   'ITEM_UMSR'         ");
                strSQL.Append("                                   AND S.KEY02   =   TT.ITEM_UMSR        ");

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO,    WHS_CD,   SUM(INV_BAL) INV_QTY						");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INV_YM          =   0                                           ");
                strSQL.Append("     AND INV_WIP_TYPE    =   0                                           ");
                strSQL.Append("     AND INV_TYPE        =   0                                           ");
                strSQL.Append(" GROUP BY  ITEM_NO,  WHS_CD )  INV ON TT.ITEM_NO  =   INV.ITEM_NO        ");
                strSQL.Append("                               AND TT.FROM_WHS_CD =   INV.WHS_CD         ");

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO,    WS_CD,     SUM(INV_BAL) WIP_QTY						");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INV_YM          =   0                                           ");
                strSQL.Append("     AND INV_WIP_TYPE    =   1                                           ");
                strSQL.Append("     AND INV_TYPE        =   0                                           ");
                strSQL.Append(" GROUP BY  ITEM_NO,  WS_CD  )  WIP  ON TT.ITEM_NO =   WIP.ITEM_NO        ");
                strSQL.Append("                                   AND TT.FROM_WS_CD   =   WIP.WS_CD     ");

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT SCRAP_XFER_NO,      SUM(WIP_ALLOC_QTY) WIP_ALLOC_QTY,           ");
                strSQL.Append(" SUM(ALLOC_QTY) ALLOC_QTY												");
                strSQL.Append(" FROM  (																	");
                strSQL.Append("			SELECT SCRAP_XFER_NO,                                           ");
                strSQL.Append("			CASE WHEN (SCH_FLAG = 0 OR SCH_FLAG = 2) THEN ALLOC_QTY ELSE 0 END WIP_ALLOC_QTY, ");   //Upd 11.01.03 Ubiq-Sai
                strSQL.Append("			CASE WHEN SCH_FLAG = 1 THEN ALLOC_QTY ELSE 0 END ALLOC_QTY		");                     //Upd 11.01.03 Ubiq-Sai
                strSQL.Append("			FROM WIP_ALLOC													");
                strSQL.Append("			WHERE ALLOC_STATUS = 0											");
                //strSQL.Append("			  AND SCH_FLAG      IN (0,2)                                    ");     //Del 11.01.03 Ubiq-Sai
                strSQL.Append("			  AND (SCRAP_XFER_NO IS NOT NULL OR SCRAP_XFER_NO <>'')			");
                strSQL.Append("		  )	WIP_ALLOC														");
                strSQL.Append(" GROUP BY SCRAP_XFER_NO) WIPALLOC ON TT.XFER_NO = WIPALLOC.SCRAP_XFER_NO ");
                strSQL.Append(" WHERE  TT.PARENT_XFER_NO  =  @PARENT_XFER_NO                            ");
                strSQL.Append("   AND  REQ_TYPE = '82'                                                  ");         //Add 11.01.03 Ubiq-Sai
                db.DbPsetString("@PARENT_XFER_NO", _xfer_no);
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM TRANSFER_TRANS TT													");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01   =   'ITEM_UMSR'         ");
                strSQL.Append("                                   AND S.KEY02   =   TT.ITEM_UMSR        ");

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO,    WHS_CD,   SUM(INV_BAL) INV_QTY						");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INV_YM          =   0                                           ");
                strSQL.Append("     AND INV_WIP_TYPE    =   0                                           ");
                strSQL.Append("     AND INV_TYPE        =   0                                           ");
                strSQL.Append(" GROUP BY  ITEM_NO,  WHS_CD )  INV ON TT.ITEM_NO  =   INV.ITEM_NO        ");
                strSQL.Append("                               AND TT.FROM_WHS_CD =   INV.WHS_CD         ");

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT ITEM_NO,    WS_CD,     SUM(INV_BAL) WIP_QTY						");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INV_YM          =   0                                           ");
                strSQL.Append("     AND INV_WIP_TYPE    =   1                                           ");
                strSQL.Append("     AND INV_TYPE        =   0                                           ");
                strSQL.Append(" GROUP BY  ITEM_NO,  WS_CD  )  WIP  ON TT.ITEM_NO =   WIP.ITEM_NO        ");
                strSQL.Append("                                   AND TT.FROM_WS_CD   =   WIP.WS_CD     ");

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT SCRAP_XFER_NO,      SUM(WIP_ALLOC_QTY) WIP_ALLOC_QTY,           ");
                strSQL.Append(" SUM(ALLOC_QTY) ALLOC_QTY												");
                strSQL.Append(" FROM  (																	");
                strSQL.Append("			SELECT SCRAP_XFER_NO,                                           ");
                strSQL.Append("			CASE WHEN (SCH_FLAG = 0 OR SCH_FLAG = 2) THEN ALLOC_QTY ELSE 0 END WIP_ALLOC_QTY, ");   //Upd 11.01.03 Ubiq-Sai
                strSQL.Append("			CASE WHEN SCH_FLAG = 1 THEN ALLOC_QTY ELSE 0 END ALLOC_QTY		");                     //Upd 11.01.03 Ubiq-Sai
                strSQL.Append("			FROM WIP_ALLOC													");
                strSQL.Append("			WHERE ALLOC_STATUS = 0											");
                //strSQL.Append("			  AND SCH_FLAG      IN (0,2)                                    ");     //Del 11.01.03 Ubiq-Sai
                strSQL.Append("			  AND (SCRAP_XFER_NO IS NOT NULL OR SCRAP_XFER_NO <>'')			");
                strSQL.Append("		  )	WIP_ALLOC														");
                strSQL.Append(" GROUP BY SCRAP_XFER_NO) WIPALLOC ON TT.XFER_NO = WIPALLOC.SCRAP_XFER_NO ");
                strSQL.Append(" WHERE  TT.PARENT_XFER_NO  =  @PARENT_XFER_NO                            ");
                strSQL.Append("   AND  REQ_TYPE = '82'                                                  ");         //Add 11.01.03 Ubiq-Sai
                db.DbPsetString("@PARENT_XFER_NO", _xfer_no);
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
        #endregion

        /// <summary>
        /// 指示済製造オーダを検索
        /// </summary>
        public DataSet Get_Mfg_ComplList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT   DISTINCT                                                            ");
            //strSQL.Append(" JO.ORDER_STATUS, WS.COMPL_FLAG,	                                            ");
            //strSQL.Append("  JOD.INPUT_FLAG,                                                            ");
            strSQL.Append("	JO.JOB_ORDER_NO, JO.ITEM_NO,     JO.ITEM_DESC,	JO.WS_CD,	    WS.WS_DESC,	");
            strSQL.Append(" JO.JOB_ORDER_QTY - JO.JOB_ORDER_COMPL_QTY JOB_ORDER_QTY, JO.ORDER_UMSR, S2.DATA_CHAR UMSR_NAME, JO.SCH_START_DATE,	");
            strSQL.Append(" JO.SCH_COMPL_DATE, JO.JOB_ORDER_COMPL_QTY, 0.00 REJ_QTY, JO.JOC_CD, JO.WHS_CD,");
            strSQL.Append(" WHS.WHS_DESC,  0.00 COMPL_QTY, '' COMPL_LOT_NO, IM.LOCATION,  ");
            strSQL.Append("  IM.LOT_CNTL_FLAG,    S1.DATA_INT AUTO_TYPE, '' SHARETYPE, WS.INPUT_FLAG    ");
            //strSQL.Append("(CASE WHEN ISNULL(IW.IDTAG_PRINT_FLAG,1) = 1 THEN                            ");
            //strSQL.Append("     (CASE WHEN ISNULL(IW.IDTAG_UNIT_QTY,0) = 0 THEN 1                       ");
            //strSQL.Append("      ELSE ceiling((JO.JOB_ORDER_QTY-JO.JOB_ORDER_COMPL_QTY)/IW.IDTAG_UNIT_QTY) END)  ");
            //strSQL.Append(" ELSE 0 END) LABEL_QTY,  ISNULL(IW.IDTAG_UNIT_QTY,0) IDTAG_UNIT_QTY,         ");
            //strSQL.Append(" ISNULL(IW.IDTAG_PRINT_FLAG,1) IDTAG_PRINT_FLAG                              ");
            //strSQL.Append(" ,																");            
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER JO                                                       ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS  ON JO.WS_CD     = WS.WS_CD          ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WHS ON JO.WHS_CD   = WHS.WHS_CD        ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER     IM  ON JO.ITEM_NO   = IM.ITEM_NO        ");
                strSQL.Append(" LEFT JOIN JOB_ORDER_DETAIL      JOD ON                                  ");
                strSQL.Append(" JO.JOB_ORDER_NO     = JOD.JOB_ORDER_NO                                  ");
                strSQL.Append(" LEFT JOIN PROCESS_MASTER PM ON JOD.PROCESS_CD = PM.PROCESS_CD           ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S1 ON S1.KEY01  = 'LOT_NUMBERING'            ");
                strSQL.Append("  AND    S1.KEY02  = 'MFG'                                               ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S2 ON S2.KEY01  = 'ITEM_UMSR'                ");
                strSQL.Append("  AND    S2.KEY02  = JO.ORDER_UMSR                                       ");
                strSQL.Append(" LEFT JOIN ITEM_WS_MASTER IW ON JO.ITEM_NO   = IW.ITEM_NO                ");
                strSQL.Append("  AND    JO.WS_CD            =  IW.WS_CD                                 ");
                strSQL.Append("  AND    JO.SCH_COMPL_DATE   >= IW.BEG_EFF_DATE                          ");
                strSQL.Append("  AND    JO.SCH_COMPL_DATE   <= IW.END_EFF_DATE                          ");
                strSQL.Append(" WHERE  1      = 1                                                       ");
                if (_sch_id != "")
                {
                    strSQL.Append("  AND  JO.SCH_ID      = @SCH_ID                                      ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("  AND  JO.JOC_CD      = @JOC_CD                                      ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND JO.WS_CD      = @WS_CD                                             ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_sch_compl_date != 0)
                {
                    strSQL.Append("  AND  JO.SCH_COMPL_DATE     <= @SCH_COMPL_DATE                           ");
                    db.DbPsetInt("@SCH_COMPL_DATE", sch_compl_date);

                    if (_job_order_compl_date != 0)
                    {
                        strSQL.Append("  AND  JO.JOB_ORDER_COMPL_DATE   = @JOB_ORDER_COMPL_DATE                 ");
                        db.DbPsetInt("@JOB_ORDER_COMPL_DATE", _job_order_compl_date);
                    }
                    strSQL.Append("  AND  (JO.ORDER_STATUS    > 25 OR JOD.INPUT_FLAG <> '1'                 ");
                    strSQL.Append("  AND  WS.COMPL_FLAG <>  0                ");
                    strSQL.Append("  AND  JO.ORDER_STATUS < 85                ");
                }
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER JO                                                       ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS  ON JO.WS_CD     = WS.WS_CD          ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WHS ON JO.WHS_CD   = WHS.WHS_CD        ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER     IM  ON JO.ITEM_NO   = IM.ITEM_NO        ");
                strSQL.Append(" LEFT JOIN JOB_ORDER_DETAIL      JOD ON                                  ");
                strSQL.Append(" JO.JOB_ORDER_NO     = JOD.JOB_ORDER_NO                                  ");
                strSQL.Append(" LEFT JOIN PROCESS_MASTER PM ON JOD.PROCESS_CD = PM.PROCESS_CD           ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S1 ON S1.KEY01  = 'LOT_NUMBERING'            ");
                strSQL.Append("  AND    S1.KEY02  = 'MFG'                                               ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S2 ON S2.KEY01  = 'ITEM_UMSR'                ");
                strSQL.Append("  AND    S2.KEY02  = JO.ORDER_UMSR                                       ");
                strSQL.Append(" LEFT JOIN ITEM_WS_MASTER IW ON JO.ITEM_NO   = IW.ITEM_NO                ");
                strSQL.Append("  AND    JO.WS_CD            =  IW.WS_CD                                 ");
                strSQL.Append("  AND    JO.SCH_COMPL_DATE   >= IW.BEG_EFF_DATE                          ");
                strSQL.Append("  AND    JO.SCH_COMPL_DATE   <= IW.END_EFF_DATE                          ");
                strSQL.Append(" WHERE  1      = 1                                                       ");
                if (_sch_id != "")
                {
                    strSQL.Append("  AND  JO.SCH_ID      = @SCH_ID                                      ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append("  AND  JO.JOC_CD      = @JOC_CD                                      ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND JO.WS_CD      = @WS_CD                                             ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_sch_compl_date != 0)
                {
                    strSQL.Append("  AND  JO.SCH_COMPL_DATE     <= @SCH_COMPL_DATE                           ");
                    db.DbPsetInt("@SCH_COMPL_DATE", sch_compl_date);
                }
                if (_job_order_compl_date != 0)
                {
                    strSQL.Append("  AND  JO.JOB_ORDER_COMPL_DATE   = @JOB_ORDER_COMPL_DATE                 ");
                    db.DbPsetInt("@JOB_ORDER_COMPL_DATE", _job_order_compl_date);
                }

                strSQL.Append("  AND  (JO.ORDER_STATUS    > 25 OR JOD.INPUT_FLAG <> '1' )                ");
                strSQL.Append("  AND  WS.COMPL_FLAG <>  0                ");
                strSQL.Append("  AND  JO.ORDER_STATUS < 85                ");

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

    }
}