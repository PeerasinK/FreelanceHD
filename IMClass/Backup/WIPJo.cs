using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Data;

namespace IMClass
{
    public class WIPJo
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WIPJo()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public WIPJo(string p_user_id, int p_lang)
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
        protected string _mrp_whs_grp = ""; //ADD BY UBIQ-SUO 2011/02/17

        protected string _db_type = "";
        protected int _lang = 1;
        protected string _sch_id = "";
        protected string _sch_name = "";
        protected int _sch_start_date = 0;
        protected int _sch_start_date1 = 0;
        protected string _ws_cd = "";
        protected string _ws_desc = "";
        protected string _order_no = "";
        protected string _item_no = "";
        protected string _item_desc = "";
        protected double _job_order_qty = 0;
        protected string _order_umsr = "";
        protected string _process_cd = "";
        protected string _process_desc = "";
        protected string _joc_cd = "";
        protected int _sch_compl_date = 0;
        protected int _joc_split_no = 0;
        protected int _chkflag = 0;
        protected int _usemfglotflag = 0;
        protected int _pgmflag = 0;

        protected string _demand_no = "";

        protected string _whs_cd = "";
        protected string _slip_note = "";
        protected string _job_order_no = "";
        protected int _print_type = 0;
        protected string _catg_cd = "";

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
        protected string _plan_no = "";

        //add by wanghui 2010/5/5 start
        protected int _alloc_flag = 0;
        protected int _miss_disb = 0;
        //add by wanghui 2010/5/5 end       

        protected string _table_type = "";//ADD BY UBIQ-LIU 2010/5/10
        protected string _parent_item_no = "";
        protected string _parent_order_no = "";
        protected int _chg_type;
        protected int _sub_action_flag;
        protected int _sch_disb_date;
        protected string _sub_grp_cd;
        protected double _plan_qty;
        protected int _usage_type;
        protected double _usage_dec;
        protected int _usage_numerator;
        protected int _usage_denominator;

        protected string _rcv_no = "";  // IMV3
        protected int _rcv_line_no = 0;  // IMV3
        protected int _idtag_unit_qty = 0;  // IMV3

        protected string _mark = "";    // IMV3
        protected string _resource_cd = "";    // IMV3
        protected int _setup_flag = 0;  // IMV3
        protected int _prod_flag = 0;  // IMV3
        protected int _suspend_flag = 0;  // IMV3
        protected int _after_setup_flag = 0;  // IMV3
        protected DateTime _start_date;  // IMV3
        protected DateTime _end_date;  // IMV3
        protected string _status = "";    // IMV3
        protected int _not_start_flag = 0;  // IMV3
        protected int _process_seq = 0;  // IMV3
        
        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        //add by wanghui 2010/5/5 start
        public string mrp_whs_grp { get { return _mrp_whs_grp; } set { _mrp_whs_grp = value; } }
        public int alloc_flag { get { return _alloc_flag; } set { _alloc_flag = value; } }
        public int miss_disb { get { return _miss_disb; } set { _miss_disb = value; } }
        //add by wanghui 2010/5/5 end
        public int lang { get { return _lang; } set { _lang = value; } }
        public string sch_id { get { return _sch_id; } set { _sch_id = value; } }
        public string sch_name { get { return _sch_name; } set { _sch_name = value; } }
        public int sch_start_date { get { return _sch_start_date; } set { _sch_start_date = value; } }
        public int sch_start_date1 { get { return _sch_start_date1; } set { _sch_start_date1 = value; } }
        public string ws_cd { get { return _ws_cd; } set { _ws_cd = value; } }
        public string ws_desc { get { return _ws_desc; } set { _ws_desc = value; } }
        public string order_no { get { return _order_no; } set { _order_no = value; } }
        public string item_no { get { return _item_no; } set { _item_no = value; } }
        public string item_desc { get { return _item_desc; } set { _item_desc = value; } }
        public double job_order_qty { get { return _job_order_qty; } set { _job_order_qty = value; } }
        public string order_umsr { get { return _order_umsr; } set { _order_umsr = value; } }
        public string process_cd { get { return _process_cd; } set { _process_cd = value; } }
        public string process_desc { get { return _process_desc; } set { _process_desc = value; } }
        public string joc_cd { get { return _joc_cd; } set { _joc_cd = value; } }
        public int sch_compl_date { get { return _sch_compl_date; } set { _sch_compl_date = value; } }
        public int joc_split_no { get { return _joc_split_no; } set { _joc_split_no = value; } }
        public int chkflag { get { return _chkflag; } set { _chkflag = value; } }
        public int usemfglotflag { get { return _usemfglotflag; } set { _usemfglotflag = value; } }
        public int pgmflag { get { return _pgmflag; } set { _pgmflag = value; } }

        public string demand_no { get { return _demand_no; } set { _demand_no = value; } }
        public string whs_cd { get { return _whs_cd; } set { _whs_cd = value; } }
        public string slip_note { get { return _slip_note; } set { _slip_note = value; } }
        public string job_order_no { get { return _job_order_no; } set { _job_order_no = value; } }
        public int print_type { get { return _print_type; } set { _print_type = value; } }
        public string catg_cd { get { return _catg_cd; } set { _catg_cd = value; } }
        public string plan_no { get { return _plan_no; } set { _plan_no = value; } }

        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }

        public string table_type { get { return _table_type; } set { _table_type = value; } }//ADD BY UBIQ-LIU 2010/5/10

        public string parent_item_no { get { return _parent_item_no; } set { _parent_item_no = value; } }
        public string parent_order_no { get { return _parent_order_no; } set { _parent_order_no = value; } }
        public int chg_type { get { return _chg_type; } set { _chg_type = value; } }
        public int sub_action_flag { get { return _sub_action_flag; } set { _sub_action_flag = value; } }
        public int sch_disb_date { get { return _sch_disb_date; } set { _sch_disb_date = value; } }
        public string sub_grp_cd { get { return _sub_grp_cd; } set { _sub_grp_cd = value; } }
        public double plan_qty { get { return _plan_qty; } set { _plan_qty = value; } }
        public int usage_type { get { return _usage_type; } set { _usage_type = value; } }
        public double usage_dec { get { return _usage_dec; } set { _usage_dec = value; } }
        public int usage_numerator { get { return _usage_numerator; } set { _usage_numerator = value; } }
        public int usage_denominator { get { return _usage_denominator; } set { _usage_denominator = value; } }

        public string rcv_no { get { return _rcv_no; } set { _rcv_no = value; } }  // IMV3
        public int rcv_line_no { get { return _rcv_line_no; } set { _rcv_line_no = value; } }  // IMV3
        public int idtag_unit_qty { get { return _idtag_unit_qty; } set { _idtag_unit_qty = value; } }  // IMV3

        public string mark { get { return _mark; } set { _mark = value; } } // IMV3

        public string resource_cd { get { return _resource_cd; } set { _resource_cd = value; } } // IMV3
        public int setup_flag { get { return _setup_flag; } set { _setup_flag = value; } }  // IMV3
        public int prod_flag { get { return _prod_flag; } set { _prod_flag = value; } }  // IMV3
        public int suspend_flag { get { return _suspend_flag; } set { _suspend_flag = value; } }  // IMV3
        public int after_setup_flag { get { return _after_setup_flag; } set { _after_setup_flag = value; } }  // IMV3
        public int not_start_flag { get { return _not_start_flag; } set { _not_start_flag = value; } }  // IMV3
        public int process_seq { get { return _process_seq; } set { _process_seq = value; } }  // IMV3

        public DateTime start_date { get { return _start_date; } set { _start_date = value; } }  // IMV3
        public DateTime end_date { get { return _end_date; } set { _end_date = value; } }  // IMV3
        public string status { get { return _status; } set { _status = value; } } // IMV3
        #endregion

        /// <summary>
        /// 入力品目コード、作業区コード、指示数にて製造工程順序を検索して工程情報を表示する
        /// 未使用
        /// </summary>
        /// <returns></returns>
        public DataSet GetRoutineList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                           ");
            strSQL.Append("RM.PROCESS_CD,     PM.PROCESS_DESC,      RM.UNIT_TIME,       RM.UNIT_QTY,        ");
            strSQL.Append("RM.LT_TYPE,        RM.SETUP_TIME,        RM.TRANSFER_TIME,   RM.TRANSFER_LT,     ");
            strSQL.Append("RM.MFG_LT,         RM.DAILY_PROD_QTY                                             ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM ROUTINE_MASTER RM  ,PROCESS_MASTER PM                              ");
                strSQL.Append(" WHERE   RM.ITEM_NO = :ITEM_NO                                           ");
                strSQL.Append(" AND     RM.WS_CD   = :WS_CD                                             ");
                strSQL.Append(" AND     RM.BEG_EFF_DATE <= convert(char(8),getdate(),112)               ");
                strSQL.Append(" AND     RM.END_EFF_DATE >= convert(char(8),getdate(),112)               ");
                strSQL.Append(" AND     RM.WS_CD =PM.WS_CD(+)                                           ");
                strSQL.Append(" AND     RM.PROCESS_CD =PM.PROCESS_CD(+)                                 ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WS_CD", _ws_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM ROUTINE_MASTER RM                                                  ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PM  ON  RM.WS_CD =PM.WS_CD               ");
                strSQL.Append(" AND RM.PROCESS_CD =PM.PROCESS_CD                                        ");
                strSQL.Append(" WHERE   RM.ITEM_NO = @ITEM_NO                                           ");
                strSQL.Append(" AND     RM.WS_CD   = @WS_CD                                             ");
                strSQL.Append(" AND     RM.BEG_EFF_DATE <= convert(char(8),getdate(),112)               ");
                strSQL.Append(" AND     RM.END_EFF_DATE >= convert(char(8),getdate(),112)               ");

                db.DbPsetString("@ITEM_NO", _item_no);
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
        /// 作業指示処理
        /// MfgJOEntry
        /// </summary>
        /// <returns></returns>
        public int Mfg_ManJoRlse()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_DESC", _item_desc, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_SCH_START_DATE", _sch_start_date, ComConst.DB_IN);
            db.DbPsetDouble("@I_JOB_ORDER_QTY", _job_order_qty, ComConst.DB_IN);
            db.DbPsetInt("@I_SCH_COMPL_DATE", _sch_compl_date, ComConst.DB_IN);
            db.DbPsetString("@I_JOC_CD", _joc_cd, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_SLIP_NOTE", _slip_note, ComConst.DB_IN);
            db.DbPsetInt("@I_EXPL_FLAG", _chkflag, ComConst.DB_IN);
            db.DbPsetInt("@I_USE_MFG_LOT_FLAG", _usemfglotflag, ComConst.DB_IN);       // 2015.08.13
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);    // IMV3
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
            rtn = db.DbStored("SP_MFG_MANJORLSE");
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
        /// 作業指示変更処理
        /// MfgJOUpd
        /// </summary>
        /// <returns></returns>
        public int Mfg_JoUpd()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_DESC", _item_desc, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_SCH_START_DATE", _sch_start_date, ComConst.DB_IN);
            db.DbPsetDouble("@I_JOB_ORDER_QTY", _job_order_qty, ComConst.DB_IN);
            db.DbPsetInt("@I_SCH_COMPL_DATE", _sch_compl_date, ComConst.DB_IN);
            db.DbPsetString("@I_JOC_CD", _joc_cd, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_SLIP_NOTE", _slip_note, ComConst.DB_IN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);    // IMV3
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
            rtn = db.DbStored("SP_MFG_JOUPD");
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
        /// 作業指示取消処理を行う
        /// MfgJOUpd
        /// 
        /// </summary>
        /// <returns></returns>
        public int Mfg_JoCancel()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_MFG_JOCANCEL");
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
        /// JOB_ORDER検索
        /// 使用画面：MfgJOEntry, MfgJOUpd
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Mfg_JoSheetDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            //strSQL.Append("SELECT distinct                                                              ");
            strSQL.Append("SELECT                                                                       "); // IMV3
            strSQL.Append("JO.JOB_ORDER_NO,     JO.WS_CD,       WS.WS_DESC,         JO.SCH_START_DATE,  ");
            strSQL.Append("JO.SCH_COMPL_DATE,   JO.ITEM_NO,     JO.ITEM_DESC,       JO.JOB_ORDER_QTY,   ");
            strSQL.Append("JO.JOC_CD,           I.DRAWING_NO,   JO.WHS_CD,          JO.INSP_CD,         ");
            strSQL.Append("JO.SCH_ID,  S1.DATA_CHAR SCH_NAME,  S2.DATA_CHAR INSP_NAME,     JO.SLIP_NOTE,");
            strSQL.Append("JO.RCV_LINE_NO ");  // IMV3
            strSQL.Append(",S3.DATA_CHAR AS UMSR_NAME	     ");    // IMV3
            //strSQL.Append("JOD.PROCESS_CD,PM.PROCESS_DESC,                                              "); // IMV3 COMMENT OUT
            //strSQL.Append("JOD.SCH_SETUP_TIME + JOD.SCH_WORK_TIME + JOD.SCH_TRANSFER_TIME AS WORK_TIME  "); // IMV3 COMMENT OUT
            db.DbParametersClear();

            strSQL.Append("FROM                                                                         ");
            strSQL.Append("JOB_ORDER   JO                                                               ");
            strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON    JO.WS_CD    = WS.WS_CD             ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I    ON  JO.ITEM_NO     = I.ITEM_NO             ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01='SCH_ID'                    ");
            strSQL.Append(" AND S1.KEY02 = JO.SCH_ID                                                    ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01='INSP_CD'                   ");
            strSQL.Append(" AND S2.KEY02 = JO.INSP_CD                                                   ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S3 ON    S3.KEY01='ITEM_UMSR'  AND      JO.ORDER_UMSR = S3.KEY02 ");    // IMV3
            //strSQL.Append(" LEFT OUTER JOIN JOB_ORDER_DETAIL JOD ON  JO.JOB_ORDER_NO = JOD.JOB_ORDER_NO ");   // IMV3 COMMENT OUT
            //strSQL.Append(" LEFT OUTER JOIN  PROCESS_MASTER	PM  ON  JOD.PROCESS_CD     = PM.PROCESS_CD  "); // IMV3 COMMENT OUT
            //strSQL.Append(" AND JOD.WS_CD = PM.WS_CD                                                    ");
            strSQL.Append(" WHERE                                                                       ");

            //if (print_type == 1)
            //{
            strSQL.Append("      JO.JOB_ORDER_NO            = @JOB_ORDER_NO                             ");
            db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
            strSQL.Append(" ORDER BY JO.JOB_ORDER_NO,JO.ITEM_NO                           ");
            //}
            //else
            //{
            //    if (_sch_id != "")
            //    {
            //        strSQL.Append(" AND     JO.SCH_ID           = @SCH_ID                       ");
            //        db.DbPsetString("@SCH_ID", _sch_id);
            //    }
            //    if (_ws_cd != "")
            //    {
            //        strSQL.Append(" AND     JO.WS_CD            = @WS_CD                        ");
            //        db.DbPsetString("@WS_CD", _ws_cd);
            //    }
            //    if (_sch_start_date != 0)
            //    {
            //        strSQL.Append(" AND     JO.SCH_START_DATE   <= @SCH_START_DATE              ");
            //        db.DbPsetInt("@SCH_START_DATE", _sch_start_date);
            //    }
            //    strSQL.Append(" AND     JO.ORDER_STATUS            = 10                     ");
            //    strSQL.Append(" AND     JO.SLIP_ISSUE_FLAG         = 0                      ");
            //}

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
        /// 作業指示№に対して作業指示票発行を行
        /// MfgJOList, HTProcessAct
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Mfg_JoRptDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append("'*' + JO.JOB_ORDER_NO + '*' BAR_CODE,                                        ");     //Add 10.04.23
            strSQL.Append("JO.JOB_ORDER_NO,     JO.WS_CD,       WS.WS_DESC,         JO.SCH_START_DATE,  ");
            strSQL.Append("JO.SCH_COMPL_DATE,   JO.ITEM_NO,     JO.ITEM_DESC,       JO.JOB_ORDER_QTY,   ");
            strSQL.Append("JO.JOC_CD,           I.DRAWING_NO,   JO.WHS_CD,          JO.INSP_CD,         ");
            strSQL.Append("JO.SCH_ID,  S1.DATA_CHAR SCH_NAME,  S2.DATA_CHAR INSP_NAME,     JO.SLIP_NOTE,");
            strSQL.Append("JOD.PROCESS_CD,PM.PROCESS_DESC,  JO.ORDER_UMSR,   S3.DATA_CHAR UMSR_NAME,    ");
            strSQL.Append("JOD.SCH_SETUP_TIME + JOD.SCH_WORK_TIME + JOD.SCH_TRANSFER_TIME AS WORK_TIME,  ");
            strSQL.Append("'' AS CHILD_ITEM_NO1,   '' AS CHILD_ITEM_DESC1,   ");
            strSQL.Append("'' AS CHILD_ITEM_NO2,   '' AS CHILD_ITEM_DESC2,   ");
            strSQL.Append("'' AS CHILD_ITEM_NO3,   '' AS CHILD_ITEM_DESC3,   ");
            strSQL.Append("'' AS CHILD_ITEM_NO4,   '' AS CHILD_ITEM_DESC4,   ");
            strSQL.Append("'' AS CHILD_ITEM_NO5,   '' AS CHILD_ITEM_DESC5,   ");
            strSQL.Append("'' AS CHILD_ITEM_NO6,   '' AS CHILD_ITEM_DESC6,   ");
            strSQL.Append("'' AS CHILD_ITEM_NO7,   '' AS CHILD_ITEM_DESC7,   ");
            strSQL.Append("'' AS CHILD_ITEM_NO8,   '' AS CHILD_ITEM_DESC8,   ");
            strSQL.Append("'' AS CHILD_ITEM_NO9,   '' AS CHILD_ITEM_DESC9,   ");
            strSQL.Append("'' AS CHILD_ITEM_NO10,   '' AS CHILD_ITEM_DESC10,  ");
            strSQL.Append("'' AS CHILD_QTY1, '' AS CHILD_UMSR1,   ");
            strSQL.Append("'' AS CHILD_QTY2, '' AS CHILD_UMSR2,  ");
            strSQL.Append("'' AS CHILD_QTY3, '' AS CHILD_UMSR3,  ");
            strSQL.Append("'' AS CHILD_QTY4, '' AS CHILD_UMSR4,  ");
            strSQL.Append("'' AS CHILD_QTY5, '' AS CHILD_UMSR5,  ");
            strSQL.Append("'' AS CHILD_QTY6, '' AS CHILD_UMSR6,  ");
            strSQL.Append("'' AS CHILD_QTY7, '' AS CHILD_UMSR7,  ");
            strSQL.Append("'' AS CHILD_QTY8, '' AS CHILD_UMSR8,  ");
            strSQL.Append("'' AS CHILD_QTY9, '' AS CHILD_UMSR9,  ");
            strSQL.Append("'' AS CHILD_QTY10, '' AS CHILD_UMSR10,  ");
            strSQL.Append("'*' + JOD.PROCESS_CD + '*' PROCESS_BCD  ");
            strSQL.Append(",JOD.RESOURCE_CD, RM.RESOURCE_DESC  ");
            strSQL.Append(",JOD.JOB_ORDER_STATUS  ");   // 2015.06.22
            strSQL.Append(",JOD.SCH_SETUP_TIME  ");   // 2015.11.13
            strSQL.Append(",(JOD.SCH_COMPL_QTY - JOD.COMPL_QTY) REMAIN_QTY , JO.WS_CD ");   // 2015.08.20
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append("FROM                                                                     ");
                strSQL.Append("JOB_ORDER JO,    WORKSHOP_MASTER WS, ITEM_MASTER I,  SYSTEM_PARAMETER S,	");
                strSQL.Append("JOB_ORDER_DETAIL JOD,        PROCESS_MASTER	PM                          ");
                strSQL.Append(" WHERE       JO.WS_CD           = WS.WS_CD                               ");
                strSQL.Append(" AND         JO.JOB_ORDER_NO    = JOD.JOB_ORDER_NO(+)                    ");
                strSQL.Append(" AND         JOD.WS_CD     = PM.WS_CD(+)                       ");
                strSQL.Append(" AND         JOD.PROCESS_CD     = PM.PROCESS_CD(+)                       ");

                if (print_type == 0)
                {
                    strSQL.Append(" AND     JO.JOB_ORDER_NO            = :JOB_ORDER_NO          ");
                    db.DbPsetString("JOB_ORDER_NO", _job_order_no);
                }
                else
                {
                    strSQL.Append(" AND     JO.SCH_ID           = :SCH_ID                       ");
                    strSQL.Append(" AND     JO.WS_CD            = :WS_CD                        ");
                    strSQL.Append(" AND     JO.SCH_START_DATE   = :SCH_START_DATE               ");
                    strSQL.Append(" AND     JO.ORDER_STATUS            = 10                     ");
                    strSQL.Append(" AND     JO.SLIP_ISSUE_FLAG         = 0                      ");
                    db.DbPsetString("WS_CD", _ws_cd);
                    db.DbPsetString("SCH_ID", _sch_id);
                    db.DbPsetInt("SCH_START_DATE", _sch_start_date);
                }
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append("FROM                                                                         ");
                strSQL.Append("JOB_ORDER   JO                                                               ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON    JO.WS_CD    = WS.WS_CD             ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I    ON  JO.ITEM_NO     = I.ITEM_NO             ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01='SCH_ID'                    ");
                strSQL.Append(" AND S1.KEY02 = JO.SCH_ID                                                    ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01='INSP_CD'                   ");
                strSQL.Append(" AND S2.KEY02 = JO.INSP_CD                                                   ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S3 ON S3.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND S3.KEY02        =       JO.ORDER_UMSR                                   ");
                strSQL.Append(" LEFT OUTER JOIN JOB_ORDER_DETAIL JOD ON  JO.JOB_ORDER_NO = JOD.JOB_ORDER_NO ");
                //strSQL.Append(" AND S2.KEY02 = JO.INSP_CD                                                   ");
                strSQL.Append(" LEFT OUTER JOIN  PROCESS_MASTER	PM  ON  JOD.PROCESS_CD     = PM.PROCESS_CD  ");
                strSQL.Append(" AND JOD.WS_CD = PM.WS_CD                                                    ");
                strSQL.Append(" LEFT OUTER JOIN  RESOURCE_MASTER	RM  ON  JOD.RESOURCE_CD     = RM.RESOURCE_CD  ");
                strSQL.Append(" WHERE    JO.ITEM_TYPE <> '99'                                               ");

                if (print_type == 0)
                {
                    strSQL.Append(" AND     JO.JOB_ORDER_NO            = @JOB_ORDER_NO          ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
                else//作業指示一覧表発行明細
                {
                    strSQL.Append(" AND     JO.SCH_ID           = @SCH_ID                       ");
                    strSQL.Append(" AND     JO.WS_CD            = @WS_CD                        ");
                    strSQL.Append(" AND     JO.SCH_START_DATE   = @SCH_START_DATE               ");
                    strSQL.Append(" AND     JO.ORDER_STATUS            < 85                     ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                    db.DbPsetString("@WS_CD", _ws_cd);
                    db.DbPsetInt("@SCH_START_DATE", _sch_start_date);
                }
            }

            if (print_type == 0)
                strSQL.Append(" ORDER BY JO.JOB_ORDER_NO,JOD.PROCESS_SEQ ");    // 2015.06.22
            else
                strSQL.Append(" ORDER BY JO.JOB_ORDER_NO,JO.ITEM_NO,JOD.PROCESS_CD                           ");
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


        // IMV3
        /// <summary>
        /// 完成品受入情報入力プロシジャ
        /// 未使用
        /// </summary>
        /// <returns></returns>
        public int Inv_ManWhsInsert(ComDB db)
        {
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_RCV_NO", _rcv_no, ComConst.DB_IN);
            db.DbPsetInt("@I_RCV_LINE_NO", _rcv_line_no, ComConst.DB_IN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_DESC", _item_desc, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_JOB_ORDER_QTY", _job_order_qty, ComConst.DB_IN);
            db.DbPsetString("@I_LOT_NO", _slip_note, ComConst.DB_IN); // slip_noにLOT_NOが入っている

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_INV_MANWHS_INSERT");
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
        /// 完成品受入情報明細削除プロシジャ
        /// 未使用
        /// </summary>
        /// <returns></returns>
        public int Inv_ManWhsDetailDelete(ComDB db)
        {
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_RCV_NO", _rcv_no, ComConst.DB_IN);
            db.DbPsetInt("@I_RCV_LINE_NO", _rcv_line_no, ComConst.DB_IN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_INV_MANWHS_DETAIL_DELETE");
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
        /// 完成品受入情報削除プロシジャ
        /// 未使用
        /// </summary>
        /// <returns></returns>
        public int Inv_ManWhsDelete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_RCV_NO", _rcv_no, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_INV_MANWHS_DELETE");
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
        ///製造指示情報の取得
        /// MfgJOUpd
        /// </summary>
        public DataSet Get_JOList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                      ");
            strSQL.Append(" JO.RCV_NO,         JO.RCV_LINE_NO,	        JO.JOB_ORDER_NO,	        ");
            strSQL.Append(" JO.ITEM_NO,        JO.ITEM_DESC,		    ");
            strSQL.Append(" JO.WS_CD,          V.WS_DESC,               JO.JOB_ORDER_QTY,                         ");
            strSQL.Append(" JO.ORDER_UMSR,     JO.SLIP_NOTE,            ");
            strSQL.Append(" JO.WHS_CD,         W.WHS_DESC,              ");
            strSQL.Append(" S1.DATA_CHAR AS UMSR_NAME, JO.SCH_START_DATE	     ");

            strSQL.Append(" FROM JOB_ORDER JO                                                                            ");
            strSQL.Append(" LEFT JOIN WORKSHOP_MASTER V ON JO.WS_CD=V.WS_CD                                              ");
            strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER W ON JO.WHS_CD=W.WHS_CD                                           ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON    S1.KEY01='ITEM_UMSR'  AND      JO.ORDER_UMSR = S1.KEY02 ");
            strSQL.Append(" WHERE  JO.ORDER_STATUS >= 10                                                                 ");
            strSQL.Append(" AND JO.SCH_FIX_FLAG = 1         "); // RMで作成したデータを除く
            if(_prod_flag == 0)
                strSQL.Append(" AND JO.ORDER_STATUS < 85        "); // 完成済を除く
            if (_chkflag == 0)
                strSQL.Append(" AND JO.ORDER_STATUS < 35        "); // 着手済を除く 2015.09.25

            db.DbParametersClear();

            if (_ws_cd != "")
            {
                strSQL.Append("   AND JO.WS_CD        =@WS_CD");
                db.DbPsetString("@WS_CD", _ws_cd);
            }
            if (_item_no != "")
            {
                strSQL.Append("   AND JO.ITEM_NO        =@ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_rcv_no != "")
            {
                strSQL.Append("   AND JO.RCV_NO        =@RCV_NO");
                db.DbPsetString("@RCV_NO", _rcv_no);
            }
            if (_slip_note != "")
            {
                strSQL.Append("   AND JO.SLIP_NOTE        =@SLIP_NOTE");
                db.DbPsetString("@SLIP_NOTE", _slip_note);
            }
            if (sch_start_date != 0)
            {
                strSQL.Append("  AND JO.SCH_START_DATE   >= @SCH_START_DATE ");
                db.DbPsetInt("@SCH_START_DATE", _sch_start_date);
            }
            if (sch_start_date1 != 0)
            {
                strSQL.Append("  AND JO.SCH_START_DATE   <= @SCH_START_DATE1 ");
                db.DbPsetInt("@SCH_START_DATE1", _sch_start_date1);
            }

            strSQL.Append(" ORDER BY   JO.JOB_ORDER_NO");

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
        /// 製造実績の取得
        /// MfgJOInq
        /// </summary>
        public DataSet GetProdActList()
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
            strSQL.Append("  P.COMPL_QTY,  P.REJ_QTY,  (CASE P.END_WORKER_ID WHEN '' THEN P.START_WORKER_ID ELSE P.END_WORKER_ID END) WORKER_ID,  COALESCE(S2.DATA_CHAR,'') AS WORKER_DESC,  DW.DOWN_REASON_DESC,  NG.NG_REASON_DESC,");
            strSQL.Append("  S1.DATA_CHAR AS UMSR_NAME, convert(varchar, P.ACTUAL_TYPE) ACTUAL_TYPE     ");
            strSQL.Append("  ,P.START_WORKER_ID ,P.END_WORKER_ID  "); // 2015.05.22

            strSQL.Append(" FROM PRODUCTION_ACTUAL P                                                                            ");
            strSQL.Append(" LEFT JOIN JOB_ORDER JO ON JO.JOB_ORDER_NO=P.JOB_ORDER_NO                                              ");
            //strSQL.Append(" LEFT JOIN WORKSHOP_MASTER W ON P.WS_CD=W.WS_CD                                              ");
            strSQL.Append(" LEFT JOIN PROCESS_MASTER PR ON P.WS_CD=PR.WS_CD AND P.PROCESS_CD = PR.PROCESS_CD            ");
            strSQL.Append(" LEFT JOIN RESOURCE_MASTER RS ON P.WS_CD=RS.WS_CD AND P.PROCESS_CD = RS.PROCESS_CD AND P.RESOURCE_CD = RS.RESOURCE_CD ");
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
            if (_ws_cd != "")
            {
                strSQL.Append("   AND P.WS_CD        =@WS_CD");
                db.DbPsetString("@WS_CD", _ws_cd);
            }
            if (_process_cd != "")
            {
                strSQL.Append("   AND P.PROCESS_CD        =@PROCESS_CD");
                db.DbPsetString("@PROCESS_CD", _process_cd);
            }
            if (_resource_cd != "")
            {
                strSQL.Append("   AND P.RESOURCE_CD        =@RESOURCE_CD");
                db.DbPsetString("@RESOURCE_CD", _resource_cd);
            }
            if (_sch_start_date != 0)
            {

                strSQL.Append("   AND (P.ACT_END_TIME >= @ACT_END_TIME OR P.ACT_END_TIME IS NULL AND P.ACT_START_TIME >= @ACT_END_TIME)");
                db.DbPsetDate("@ACT_END_TIME", _start_date);
            }
            if (sch_compl_date != 0)
            {

                strSQL.Append("   AND P.ACT_START_TIME <= @ACT_START_TIME");
                db.DbPsetDate("@ACT_START_TIME", _end_date);
            }
            string strActualType = "";
            if (_setup_flag == 1)
            {
                strActualType = "11,12";
            }
            if (_prod_flag == 1)
            {
                if(strActualType != "")
                    strActualType = strActualType + ",";
                strActualType = strActualType + "21,22";
            }
            if (_suspend_flag == 1)
            {
                if(strActualType != "")
                    strActualType = strActualType + ",";
                strActualType = strActualType + "31,32";
            }
            if (_after_setup_flag == 1)
            {
                if (strActualType != "")
                    strActualType = strActualType + ",";
                strActualType = strActualType + "41,42";
            }
            if (strActualType != "")
            {
                strSQL.Append("   AND P.ACTUAL_TYPE IN (" + strActualType + ")");
            }
            else
            {
                // 2016.01.27
                strSQL.Append("   AND P.ACTUAL_TYPE NOT IN (11,12,21,22,31,32,41,42)");
            }

            // 未着手分

            if (_not_start_flag == 1)
            {
                strSQL.Append(" UNION ALL SELECT '1' TYPE,                                     ");
                strSQL.Append("  JO.JOB_ORDER_NO, JO.ITEM_NO, COALESCE(JO.ITEM_DESC,I.ITEM_DESC) ITEM_DESC, JD.PROCESS_CD, PR.PROCESS_DESC,");
                strSQL.Append("  JD.RESOURCE_CD, RS.RESOURCE_DESC,");
                strSQL.Append("  '' ACT_START_TIME,");
                strSQL.Append("  ''  ACT_END_TIME,");
                strSQL.Append("  0 ACT_TIME,");
                strSQL.Append("  0 COMPL_QTY,  0 REJ_QTY, '' WORKER_ID,  '' WORKER_DESC,  '' DOWN_REASON_DESC,  '' NG_REASON_DESC,");
                strSQL.Append("  S1.DATA_CHAR AS UMSR_NAME, '00' ACTUAL_TYPE     ");
                strSQL.Append("  ,'' START_WORKER_ID ,'' END_WORKER_ID  "); // 2015.05.22

                strSQL.Append(" FROM JOB_ORDER_DETAIL JD ");
                strSQL.Append(" INNER JOIN JOB_ORDER JO ON JO.JOB_ORDER_NO = JD.JOB_ORDER_NO ");
                strSQL.Append(" LEFT JOIN PROCESS_MASTER PR ON JD.WS_CD=PR.WS_CD AND JD.PROCESS_CD = PR.PROCESS_CD            ");
                strSQL.Append(" LEFT JOIN RESOURCE_MASTER RS ON JD.WS_CD=RS.WS_CD AND JD.PROCESS_CD = RS.PROCESS_CD AND JD.RESOURCE_CD = RS.RESOURCE_CD ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON    S1.KEY01='ITEM_UMSR'  AND JO.ORDER_UMSR = S1.KEY02    ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER I ON JO.ITEM_NO=I.ITEM_NO                                              ");
                strSQL.Append(" LEFT JOIN PRODUCTION_ACTUAL PA ON PA.JOB_ORDER_NO = JD.JOB_ORDER_NO AND PA.WS_CD = JD.WS_CD AND PA.PROCESS_CD = JD.PROCESS_CD AND PA.PROCESS_SEQ = JD.PROCESS_SEQ  ");
                strSQL.Append(" WHERE COALESCE(PA.JOB_ORDER_NO,'*') = '*' ");

                if (_job_order_no != "")
                {
                    strSQL.Append("   AND JO.JOB_ORDER_NO        =@JOB_ORDER_NO2");
                    db.DbPsetString("@JOB_ORDER_NO2", _job_order_no);
                }
                if (_item_no != "")
                {
                    strSQL.Append("   AND JO.ITEM_NO        =@ITEM_NO2");
                    db.DbPsetString("@ITEM_NO2", _item_no);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append("   AND JD.WS_CD        =@WS_CD2");
                    db.DbPsetString("@WS_CD2", _ws_cd);
                }
                if (_process_cd != "")
                {
                    strSQL.Append("   AND JD.PROCESS_CD        =@PROCESS_CD2");
                    db.DbPsetString("@PROCESS_CD2", _process_cd);
                }
                if (_resource_cd != "")
                {
                    strSQL.Append("   AND JD.RESOURCE_CD        =@RESOURCE_CD2");
                    db.DbPsetString("@RESOURCE_CD2", _resource_cd);
                }
            }
            //strSQL.Append(" ORDER BY P.ACT_START_TIME");
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

        /// <summary>
        /// 資源状況確認：製造実績の取得
        /// AlsResource
        /// </summary>
        public DataSet GetResourceStatus()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                      ");
            strSQL.Append("  RS.WS_CD,W.WS_DESC,RS.PROCESS_CD, PR.PROCESS_DESC,RS.RESOURCE_CD, RS.RESOURCE_DESC, P.JOB_ORDER_NO, P.ITEM_NO, COALESCE(JO.ITEM_DESC,I.ITEM_DESC) ITEM_DESC, ");
            strSQL.Append("  COALESCE(DW.DOWN_REASON_DESC,  COALESCE(NG.NG_REASON_DESC, '')) REASON_DESC,");
            strSQL.Append("  convert(varchar, COALESCE(P.ACTUAL_TYPE, 0)) ACTUAL_TYPE ");

            strSQL.Append(" FROM (   ");
            strSQL.Append("     SELECT A.ACT_TIME,PA.*   ");
            strSQL.Append("     FROM PRODUCTION_ACTUAL PA   ");
            strSQL.Append("     INNER JOIN (  ");
            //                      作業区、工程、資源ごとで最後の着手時刻を得る
            strSQL.Append("         SELECT WS_CD,PROCESS_CD,RESOURCE_CD,MAX(ACT_START_TIME) ACT_TIME FROM PRODUCTION_ACTUAL   ");
            strSQL.Append("         GROUP BY WS_CD,PROCESS_CD,RESOURCE_CD  ");
            strSQL.Append("     ) A ON A.WS_CD = PA.WS_CD AND A.PROCESS_CD = PA.PROCESS_CD AND A.RESOURCE_CD = PA.RESOURCE_CD   ");
            strSQL.Append("     AND A.ACT_TIME = PA.ACT_START_TIME  ");
            strSQL.Append("     WHERE  1=1    ");
            strSQL.Append("       AND  PA.ACTUAL_TYPE IN (11,21,31,41)   ");    // 
            strSQL.Append(" ) P  ");
            strSQL.Append(" FULL JOIN RESOURCE_MASTER RS ON P.WS_CD=RS.WS_CD AND P.PROCESS_CD = RS.PROCESS_CD AND P.RESOURCE_CD = RS.RESOURCE_CD ");
            strSQL.Append(" LEFT JOIN JOB_ORDER JO ON JO.JOB_ORDER_NO=P.JOB_ORDER_NO                                              ");
            strSQL.Append(" LEFT JOIN ITEM_MASTER I ON P.ITEM_NO=I.ITEM_NO                                              ");
            strSQL.Append(" LEFT JOIN WORKSHOP_MASTER W ON RS.WS_CD=W.WS_CD                                              ");
            strSQL.Append(" LEFT JOIN PROCESS_MASTER PR ON RS.WS_CD=PR.WS_CD AND RS.PROCESS_CD = PR.PROCESS_CD            ");
            //strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON    S1.KEY01='ITEM_UMSR'  AND P.ITEM_UMSR = S1.KEY02    ");
            strSQL.Append(" LEFT JOIN PROCESS_NG_REASON_MASTER NG ON P.WS_CD=NG.WS_CD AND P.PROCESS_CD = NG.PROCESS_CD AND P.NG_REASON_CD = NG.NG_REASON_CD ");
            strSQL.Append(" LEFT JOIN DOWN_REASON_MASTER DW ON P.RESOURCE_CD=DW.RESOURCE_CD AND P.DOWN_REASON_CD = DW.DOWN_REASON_CD ");
            //strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S2 ON    S2.KEY01='WORKER_CD'  AND (CASE P.END_WORKER_ID WHEN '' THEN P.START_WORKER_ID ELSE P.END_WORKER_ID END) = S2.KEY02    ");
            strSQL.Append(" WHERE  1=1  ");

            db.DbParametersClear();

            if (_ws_cd != "")
            {
                strSQL.Append("   AND RS.WS_CD        =@WS_CD");
                db.DbPsetString("@WS_CD", _ws_cd);
            }
            if (_process_cd != "")
            {
                strSQL.Append("   AND RS.PROCESS_CD        =@PROCESS_CD");
                db.DbPsetString("@PROCESS_CD", _process_cd);
            }
            if (_resource_cd != "")
            {
                strSQL.Append("   AND RS.RESOURCE_CD        =@RESOURCE_CD");
                db.DbPsetString("@RESOURCE_CD", _resource_cd);
            }
            strSQL.Append(" ORDER BY RS.WS_CD, RS.PROCESS_CD, RS.RESOURCE_CD");

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
        /// 工程進捗状況確認：製造実績の取得
        /// AlsProcess
        /// </summary>
        public DataSet GetProcessProgress()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT DISTINCT     "); // 2015.06.25 DISTINCT
            strSQL.Append(" JO.JOB_ORDER_NO, JO.ITEM_NO, JO.ITEM_DESC, JO.WS_CD, W.WS_DESC,  ");
            //strSQL.Append(" CASE JO.COMPL_CNT WHEN 0 THEN P.PROCESS_CD ELSE '' END PROCESS_CD,     ");
            //strSQL.Append(" CASE JO.COMPL_CNT WHEN 0 THEN PR.PROCESS_DESC ELSE '' END PROCESS_DESC,    ");
            //strSQL.Append(" P.PROCESS_CD ,     ");    // 2015.05.14
            strSQL.Append(" COALESCE(P.PROCESS_CD,COALESCE(Q.PROCESS_CD,JOD.PROCESS_CD)) PROCESS_CD ,     ");    // 2015.05.14
            strSQL.Append(" PR.PROCESS_DESC ,    ");    // 2015.05.14

            strSQL.Append(" JO.SCH_START_DATE, COALESCE(JOD.SCH_COMPL_DATE,JO.SCH_COMPL_DATE) SCH_COMPL_DATE,    ");
            strSQL.Append(" JOD.COMPL_DATE ACT_COMPL_DATE, COALESCE(JOD.SCH_COMPL_QTY,JO.JOB_ORDER_QTY) JOB_ORDER_QTY,   ");
            strSQL.Append(" JOD.COMPL_QTY, JOD.PARTIAL_COMPL_CNT COMPL_CNT    "); 
            strSQL.Append(",COALESCE(P.SETUP_USER_ID,Q.SETUP_USER_ID) SETUP_USER_ID,COALESCE(P.START_USER_ID,Q.START_USER_ID) START_USER_ID, COALESCE(P.END_USER_ID,Q.END_USER_ID) END_USER_ID,CASE WHEN COALESCE(P.SUSPEND_USER_ID,'') = '' THEN Q.SUSPEND_USER_ID ELSE P.SUSPEND_USER_ID END SUSPEND_USER_ID   ");   // 2015.05.14  
            strSQL.Append(",JOD.START_DATE ACT_START_DATE ");    // 2015.05.14
            strSQL.Append(" FROM    ");
            strSQL.Append(" (           ");
            strSQL.Append("     SELECT A.ACT_TIME,PA.*        FROM PRODUCTION_ACTUAL PA      ");     
            strSQL.Append("     INNER JOIN (   ");
            //                      製造指示№ごとで最大の製造実績（製造開始または終了）のあがっている工順の最後の着手時刻を資源ごとに得る
            strSQL.Append("         SELECT X.JOB_ORDER_NO,X.WS_CD,X.PROCESS_SEQ,X.PROCESS_CD,X.RESOURCE_CD,MAX(X.ACT_START_TIME) ACT_TIME    ");
            strSQL.Append("         FROM PRODUCTION_ACTUAL X   ");
            strSQL.Append("         INNER JOIN (   ");
            //                          製造指示№ごとで最大の製造実績（製造開始または終了）のあがっている工順
            strSQL.Append("             SELECT JOB_ORDER_NO,MAX(PROCESS_SEQ) PROCESS_SEQ FROM PRODUCTION_ACTUAL   ");
            strSQL.Append("             where ACTUAL_TYPE IN (21,22)      ");             
            strSQL.Append("             GROUP BY JOB_ORDER_NO   ");
            strSQL.Append("          )Y ON X.JOB_ORDER_NO = Y.JOB_ORDER_NO AND X.PROCESS_SEQ = Y.PROCESS_SEQ   ");
            strSQL.Append("         where X.ACTUAL_TYPE IN (21,22)             ");      
            strSQL.Append("         GROUP BY X.JOB_ORDER_NO,X.WS_CD,X.PROCESS_SEQ,X.PROCESS_CD,X.RESOURCE_CD   ");
            strSQL.Append("      ) A ON A.WS_CD = PA.WS_CD AND A.PROCESS_CD = PA.PROCESS_CD AND A.RESOURCE_CD = PA.RESOURCE_CD      ");     
            strSQL.Append("     AND A.ACT_TIME = PA.ACT_START_TIME          ");
            strSQL.Append("     WHERE  1=1           AND  PA.ACTUAL_TYPE IN (21,22)       ");
            strSQL.Append("  ) P    ");
            //strSQL.Append(" FULL JOIN JOB_ORDER JO ON JO.JOB_ORDER_NO=P.JOB_ORDER_NO AND JO.SCH_FIX_FLAG = 1  ");   // WIPのみ
            //strSQL.Append(" LEFT JOIN JOB_ORDER_DETAIL JOD ON JOD.JOB_ORDER_NO=P.JOB_ORDER_NO AND JOD.PROCESS_SEQ = P.PROCESS_SEQ AND JOD.PROCESS_CD = P.PROCESS_CD   ");
            strSQL.Append(" FULL JOIN JOB_ORDER_DETAIL JOD ON JOD.JOB_ORDER_NO=P.JOB_ORDER_NO AND JOD.PROCESS_SEQ = P.PROCESS_SEQ AND JOD.PROCESS_CD = P.PROCESS_CD   ");
            strSQL.Append(" INNER JOIN JOB_ORDER JO ON JO.JOB_ORDER_NO=JOD.JOB_ORDER_NO AND JO.SCH_FIX_FLAG = 1  ");   // WIPのみ
            // 2015.05.15
            strSQL.Append(" LEFT JOIN (           ");
            strSQL.Append("     SELECT A.ACT_TIME,PA.*        FROM PRODUCTION_ACTUAL PA      ");
            strSQL.Append("     INNER JOIN (   ");
            //                      製造指示№ごとで最大の製造実績のあがっている工順の最後の着手時刻を資源ごとに得る
            strSQL.Append("         SELECT X.JOB_ORDER_NO,X.WS_CD,X.PROCESS_SEQ,X.PROCESS_CD,X.RESOURCE_CD,MAX(X.ACT_START_TIME) ACT_TIME    ");
            strSQL.Append("         FROM PRODUCTION_ACTUAL X   ");
            strSQL.Append("         INNER JOIN (   ");
            //                          製造指示№ごとで最大の製造実績のあがっている工順
            strSQL.Append("             SELECT JOB_ORDER_NO,MAX(PROCESS_SEQ) PROCESS_SEQ FROM PRODUCTION_ACTUAL   ");
            strSQL.Append("             GROUP BY JOB_ORDER_NO   ");
            strSQL.Append("          )Y ON X.JOB_ORDER_NO = Y.JOB_ORDER_NO AND X.PROCESS_SEQ = Y.PROCESS_SEQ   ");
            strSQL.Append("         GROUP BY X.JOB_ORDER_NO,X.WS_CD,X.PROCESS_SEQ,X.PROCESS_CD,X.RESOURCE_CD   ");
            strSQL.Append("      ) A ON A.WS_CD = PA.WS_CD AND A.PROCESS_CD = PA.PROCESS_CD AND A.RESOURCE_CD = PA.RESOURCE_CD      ");
            strSQL.Append("     AND A.ACT_TIME = PA.ACT_START_TIME          ");
            strSQL.Append("  ) Q ON JOD.JOB_ORDER_NO = Q.JOB_ORDER_NO AND JOD.PROCESS_SEQ = Q.PROCESS_SEQ   ");

            strSQL.Append(" LEFT JOIN WORKSHOP_MASTER W ON JO.WS_CD=W.WS_CD                                              ");
            //strSQL.Append(" LEFT JOIN PROCESS_MASTER PR ON P.WS_CD=PR.WS_CD AND P.PROCESS_CD = PR.PROCESS_CD            ");
            strSQL.Append(" LEFT JOIN PROCESS_MASTER PR ON COALESCE(P.WS_CD,JOD.WS_CD)=PR.WS_CD AND COALESCE(P.PROCESS_CD,COALESCE(Q.PROCESS_CD,JOD.PROCESS_CD)) = PR.PROCESS_CD            ");    // 2015.05.15
            //strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON    S1.KEY01='ITEM_UMSR'  AND P.ITEM_UMSR = S1.KEY02    ");
            //strSQL.Append(" LEFT JOIN PROCESS_NG_REASON_MASTER NG ON P.WS_CD=NG.WS_CD AND P.PROCESS_CD = NG.PROCESS_CD AND P.NG_REASON_CD = NG.NG_REASON_CD ");
            //strSQL.Append(" LEFT JOIN DOWN_REASON_MASTER DW ON P.RESOURCE_CD=DW.RESOURCE_CD AND P.DOWN_REASON_CD = DW.DOWN_REASON_CD ");
            //strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S2 ON    S2.KEY01='WORKER_CD'  AND (CASE P.END_WORKER_ID WHEN '' THEN P.START_WORKER_ID ELSE P.END_WORKER_ID END) = S2.KEY02    ");
            strSQL.Append(" WHERE  JO.SCH_FIX_FLAG = 1  ");   // WIPのみ

            db.DbParametersClear();

            if (_job_order_no != "")
            {
                strSQL.Append("   AND JO.JOB_ORDER_NO        =@JOB_ORDER_NO");
                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
            }
            if (_ws_cd != "")
            {
                strSQL.Append("   AND JO.WS_CD        =@WS_CD");
                db.DbPsetString("@WS_CD", _ws_cd);
            }
            if (_item_no != "")
            {
                strSQL.Append("   AND JO.ITEM_NO        =@ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_sch_start_date != 0)
            {
                strSQL.Append("   AND JO.SCH_START_DATE        >= @SCH_START_DATE");
                db.DbPsetInt("@SCH_START_DATE", _sch_start_date);
            }
            if (_sch_start_date1 != 0)
            {
                strSQL.Append("   AND JO.SCH_START_DATE        <= @SCH_START_DATE1");
                db.DbPsetInt("@SCH_START_DATE1", _sch_start_date1);
            }
            if (_sch_compl_date != 0)
            {
                strSQL.Append("   AND COALESCE(JOD.COMPL_DATE,0)        >= @COMPL_DATE");
                db.DbPsetInt("@COMPL_DATE", _sch_compl_date);
            }
            if (_sch_disb_date != 0)
            {
                strSQL.Append("   AND COALESCE(JOD.COMPL_DATE,0)        <= @COMPL_DATE2");
                db.DbPsetInt("@COMPL_DATE2", _sch_disb_date);
            }
            if (_setup_flag == 1 && _prod_flag == 0)   // 未完成のみ
            {
                strSQL.Append("   AND JO.ORDER_STATUS        < 85");
            }
            if (_prod_flag == 1 && _setup_flag == 0)   // 完成済のみ
            {
                strSQL.Append("   AND JO.ORDER_STATUS        >= 85");
            }
            if (_prod_flag == 1 && _setup_flag == 1)   // 両方
            {
                strSQL.Append("   AND 1 = 1");
            }
            if (_setup_flag == 0 && _prod_flag == 0)
            {
                strSQL.Append("   AND 1 = 0 ");
            }
            strSQL.Append(" ORDER BY JO.JOB_ORDER_NO");

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
        /// JOB_ORDER進捗検索
        /// 使用画面：AlsProcess_frmDetail
        /// </summary>
        /// <returns></returns>
        public DataSet GetProcessProgressOfJO()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            //strSQL.Append("SELECT distinct                                                              ");
            strSQL.Append("SELECT                                                                       "); // IMV3
            strSQL.Append("JO.JOB_ORDER_NO,     JO.WS_CD,       WS.WS_DESC,         JO.SCH_START_DATE,  ");
            strSQL.Append("JO.SCH_COMPL_DATE,   JO.ITEM_NO,     JO.ITEM_DESC,       JO.JOB_ORDER_QTY,   ");
            strSQL.Append("JO.JOB_ORDER_COMPL_QTY COMPL_QTY,    JO.JOB_ORDER_REJ_QTY REJ_QTY,         ");
            strSQL.Append("JO.JOB_ORDER_COMPL_DATE COMPL_DATE, '' WORKER_ID, '' WORKER_DESC,");
            strSQL.Append("S3.DATA_CHAR AS UMSR_NAME,	     ");
            strSQL.Append("'' PROCESS_CD, '' PROCESS_DESC    ");
            //strSQL.Append("JOD.PROCESS_CD,PM.PROCESS_DESC,                                              "); // IMV3 COMMENT OUT
            //strSQL.Append("JOD.SCH_SETUP_TIME + JOD.SCH_WORK_TIME + JOD.SCH_TRANSFER_TIME AS WORK_TIME  "); // IMV3 COMMENT OUT
            db.DbParametersClear();

            strSQL.Append("FROM                                                                         ");
            strSQL.Append("JOB_ORDER   JO                                                               ");
            strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON    JO.WS_CD    = WS.WS_CD             ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S3 ON    S3.KEY01='ITEM_UMSR'  AND      JO.ORDER_UMSR = S3.KEY02 ");    // IMV3
            //strSQL.Append(" LEFT OUTER JOIN JOB_ORDER_DETAIL JOD ON  JO.JOB_ORDER_NO = JOD.JOB_ORDER_NO ");   // IMV3 COMMENT OUT
            //strSQL.Append(" LEFT OUTER JOIN  PROCESS_MASTER	PM  ON  JOD.PROCESS_CD     = PM.PROCESS_CD  "); // IMV3 COMMENT OUT
            //strSQL.Append(" AND JOD.WS_CD = PM.WS_CD                                                    ");
            strSQL.Append(" WHERE                                                                       ");

            strSQL.Append("      JO.JOB_ORDER_NO            = @JOB_ORDER_NO                             ");
            db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
            //strSQL.Append(" ORDER BY JO.JOB_ORDER_NO,JO.ITEM_NO                           ");

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
        /// JOB_ORDER 最終工程進捗検索
        /// 使用画面：AlsProcess_frmDetail
        /// </summary>
        /// <returns></returns>
        public DataSet GetProcessProgressOfJOD()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            //strSQL.Append("SELECT distinct                                                              ");
            strSQL.Append("SELECT                                                                       "); // IMV3
            strSQL.Append("JO.JOB_ORDER_NO,     JO.WS_CD,       WS.WS_DESC,         JOD.SCH_START_DATE,  ");
            strSQL.Append("JOD.SCH_COMPL_DATE,   JO.ITEM_NO,     JO.ITEM_DESC,       JO.JOB_ORDER_QTY,   ");
            strSQL.Append("JOD.COMPL_QTY COMPL_QTY,    JOD.REJ_QTY REJ_QTY,         ");
            strSQL.Append("JOD.COMPL_DATE COMPL_DATE, (CASE P.END_WORKER_ID WHEN '' THEN P.START_WORKER_ID ELSE P.END_WORKER_ID END) WORKER_ID,  COALESCE(S2.DATA_CHAR,'') AS WORKER_DESC,");
            strSQL.Append("S3.DATA_CHAR AS UMSR_NAME,	     ");    // IMV3
            strSQL.Append("JOD.PROCESS_CD,PM.PROCESS_DESC                                              "); // IMV3 COMMENT OUT
            //strSQL.Append("JOD.SCH_SETUP_TIME + JOD.SCH_WORK_TIME + JOD.SCH_TRANSFER_TIME AS WORK_TIME  "); // IMV3 COMMENT OUT
            db.DbParametersClear();

            strSQL.Append("FROM                                                                         ");
            strSQL.Append("JOB_ORDER   JO                                                               ");
            strSQL.Append(" INNER JOIN JOB_ORDER_DETAIL   JOD ON JO.JOB_ORDER_NO = JOD.JOB_ORDER_NO ");
            strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON    JO.WS_CD    = WS.WS_CD             ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S3 ON    S3.KEY01='ITEM_UMSR'  AND      JO.ORDER_UMSR = S3.KEY02 ");    // IMV3
            strSQL.Append(" LEFT OUTER JOIN  PROCESS_MASTER	PM  ON  JOD.PROCESS_CD     = PM.PROCESS_CD  AND JOD.WS_CD = PM.WS_CD  ");

            strSQL.Append("     LEFT JOIN (   ");
            //                      製造指示№ごとで最後の製造開始のあがっている工程と作業者
            strSQL.Append("         SELECT X.JOB_ORDER_NO,X.PROCESS_CD,X.START_WORKER_ID,x.END_WORKER_ID   ");
            strSQL.Append("         FROM PRODUCTION_ACTUAL X   ");
            strSQL.Append("         INNER JOIN (   ");
            //                          製造指示№ごとで最大の製造実績（製造開始または終了）のあがっている工順
            strSQL.Append("             SELECT JOB_ORDER_NO,PROCESS_CD,MAX(ACT_START_TIME) ACT_START_TIME FROM PRODUCTION_ACTUAL   ");
            strSQL.Append("             WHERE ACTUAL_TYPE IN (21,22)      ");
            strSQL.Append("             GROUP BY JOB_ORDER_NO,PROCESS_CD   ");
            strSQL.Append("          )Y ON X.JOB_ORDER_NO = Y.JOB_ORDER_NO AND X.PROCESS_CD = Y.PROCESS_CD AND X.ACT_START_TIME = Y.ACT_START_TIME   ");
            strSQL.Append("         WHERE X.ACTUAL_TYPE IN (21,22)             ");
            strSQL.Append("      ) P ON P.JOB_ORDER_NO = JOD.JOB_ORDER_NO AND P.PROCESS_CD = JOD.PROCESS_CD ");
            
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S2 ON    S2.KEY01='WORKER_CD'  AND (CASE P.END_WORKER_ID WHEN '' THEN P.START_WORKER_ID ELSE P.END_WORKER_ID END) = S2.KEY02    ");

            strSQL.Append(" WHERE                                                                       ");

            strSQL.Append("      JO.JOB_ORDER_NO            = @JOB_ORDER_NO                             ");
            strSQL.Append(" AND  JOD.PROCESS_CD            = @PROCESS_CD                             ");
            db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
            db.DbPsetString("@PROCESS_CD", _process_cd);
            strSQL.Append(" ORDER BY JOD.PROCESS_SEQ   ");

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
        /// 工程進捗状況確認：JO製造実績工程の取得
        /// AlsProcess_frmDetail
        /// </summary>
        public DataSet GetProcessProgressOfJOProcess()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT      ");
            strSQL.Append(" JOD.PROCESS_CD, PR.PROCESS_DESC, JOD.SCH_SETUP_TIME + JOD.SCH_WORK_TIME SCH_TIME, P.ACT_SETUP_TIME + P.ACT_WORK_TIME ACT_TIME,  ");
            strSQL.Append(" JOD.COMPL_QTY, JOD.REJ_QTY, P.ACT_START_TIME, P.ACT_END_TIME, P.RESOURCE_CD, RS.RESOURCE_DESC,  ");
            strSQL.Append(" P.BREAK_START_TIME, P.BREAK_END_TIME, P.ACT_BREAK_TIME, CONVERT(VARCHAR, P.ACT_BREAK_TIME) DOWN_TIME, '' STATUS, ");
            strSQL.Append(" (CASE P.END_WORKER_ID WHEN '' THEN P.START_WORKER_ID ELSE P.END_WORKER_ID END) WORKER_ID,  COALESCE(S2.DATA_CHAR,'') AS WORKER_DESC");
            strSQL.Append(",P.SETUP_USER_ID,P.START_USER_ID,P.END_USER_ID,P.SUSPEND_USER_ID   ");   // 2015.05.14  
            strSQL.Append(",P.SETUP_START_TIME,P.SETUP_END_TIME   ");   // 2015.05.14  
            strSQL.Append(" FROM JOB_ORDER_DETAIL JOD    ");
            strSQL.Append(" INNER JOIN JOB_ORDER JO ON JO.JOB_ORDER_NO=JOD.JOB_ORDER_NO AND JO.SCH_FIX_FLAG = 1  ");   // WIPのみ
            strSQL.Append(" LEFT JOIN    ");
            strSQL.Append(" (           ");
            ////                  製造指示№、工順、工程、資源ごとで最後の製造実績（製造開始または終了）の情報
            ////strSQL.Append("     SELECT X.JOB_ORDER_NO,X.WS_CD,X.PROCESS_SEQ,X.PROCESS_CD,X.RESOURCE_CD,Y.COMPL_QTY,Y.REJ_QTY,X.ACT_START_TIME,X.ACT_END_TIME,Y.ACT_WORK_TIME,              ");
            //strSQL.Append("     SELECT X.JOB_ORDER_NO,X.WS_CD,X.PROCESS_SEQ,X.PROCESS_CD,X.RESOURCE_CD,Y.COMPL_QTY,Y.REJ_QTY,Y.ACT_START_TIME,Y.ACT_END_TIME,Y.ACT_WORK_TIME,              "); // 2015.05.15
            //strSQL.Append("      Z.BREAK_START_TIME,Z.BREAK_END_TIME,Z.ACT_BREAK_TIME,X.START_WORKER_ID,X.END_WORKER_ID,Q.ACT_SETUP_TIME              ");
            //strSQL.Append("     ,Q.SETUP_START_TIME,Q.SETUP_END_TIME   ");   // 2015.05.14  
            //strSQL.Append("     ,X.SETUP_USER_ID,X.START_USER_ID,X.END_USER_ID,X.SUSPEND_USER_ID   ");   // 2015.05.14  
            //strSQL.Append("       FROM PRODUCTION_ACTUAL X  ");
            ////strSQL.Append("     INNER JOIN (   ");
            //strSQL.Append("     LEFT JOIN (   ");   // 2015.05.15
            ////                      製造指示№、工順、工程、資源ごとで最後の製造実績（製造開始または終了）
            //strSQL.Append("         SELECT JOB_ORDER_NO,PROCESS_SEQ,PROCESS_CD,RESOURCE_CD,MAX(ACT_START_TIME) ACT_START_TIME,   ");
            //strSQL.Append("         MAX(ACT_END_TIME) ACT_END_TIME,   ");   // 2015.05.14 
            //strSQL.Append("         COALESCE(SUM(COMPL_QTY),0) COMPL_QTY, COALESCE(SUM(REJ_QTY),0) REJ_QTY,      ");
            //strSQL.Append("         COALESCE(SUM(ACT_SETUP_TIME),0) ACT_SETUP_TIME, COALESCE(SUM(ACT_WORK_TIME),0) ACT_WORK_TIME      ");
            //strSQL.Append("         FROM PRODUCTION_ACTUAL      ");
            //strSQL.Append("         WHERE ACTUAL_TYPE IN (21,22)      ");
            //strSQL.Append("         GROUP BY JOB_ORDER_NO,PROCESS_SEQ,PROCESS_CD,RESOURCE_CD   ");
            //strSQL.Append("      )Y ON X.JOB_ORDER_NO = Y.JOB_ORDER_NO AND X.PROCESS_SEQ = Y.PROCESS_SEQ AND X.PROCESS_CD = Y.PROCESS_CD AND X.RESOURCE_CD = Y.RESOURCE_CD AND X.ACT_START_TIME = Y.ACT_START_TIME   ");
            //strSQL.Append("     LEFT JOIN (   ");
            ////                      製造指示№、工順、工程、資源ごとで最後の中断実績（中断開始または終了）
            //strSQL.Append("         SELECT JOB_ORDER_NO,PROCESS_SEQ,PROCESS_CD,RESOURCE_CD,MAX(ACT_START_TIME) BREAK_START_TIME,MAX(ACT_END_TIME) BREAK_END_TIME,   ");
            //strSQL.Append("         COALESCE(SUM(ACT_BREAK_TIME),0) ACT_BREAK_TIME      ");
            //strSQL.Append("         FROM PRODUCTION_ACTUAL      ");
            //strSQL.Append("         WHERE ACTUAL_TYPE IN (31,32)      ");
            //strSQL.Append("         GROUP BY JOB_ORDER_NO,PROCESS_SEQ,PROCESS_CD,RESOURCE_CD   ");
            //strSQL.Append("      )Z ON X.JOB_ORDER_NO = Z.JOB_ORDER_NO AND X.PROCESS_SEQ = Z.PROCESS_SEQ AND X.PROCESS_CD = Z.PROCESS_CD AND X.RESOURCE_CD = Z.RESOURCE_CD    ");
            //strSQL.Append("     LEFT JOIN (   ");
            ////                      製造指示№、工順、工程、資源ごとで最後の段取実績（段取開始または終了）
            //strSQL.Append("         SELECT JOB_ORDER_NO,PROCESS_SEQ,PROCESS_CD,RESOURCE_CD,MAX(ACT_START_TIME) SETUP_START_TIME,MAX(ACT_END_TIME) SETUP_END_TIME,   ");
            //strSQL.Append("         COALESCE(SUM(ACT_SETUP_TIME),0) ACT_SETUP_TIME      ");
            //strSQL.Append("         FROM PRODUCTION_ACTUAL      ");
            //strSQL.Append("         WHERE ACTUAL_TYPE IN (11,12)      ");
            //strSQL.Append("         GROUP BY JOB_ORDER_NO,PROCESS_SEQ,PROCESS_CD,RESOURCE_CD   ");
            //strSQL.Append("      )Q ON X.JOB_ORDER_NO = Q.JOB_ORDER_NO AND X.PROCESS_SEQ = Q.PROCESS_SEQ AND X.PROCESS_CD = Q.PROCESS_CD AND X.RESOURCE_CD = Q.RESOURCE_CD    ");
            ////strSQL.Append("     WHERE X.ACTUAL_TYPE IN (21,22)             ");    // 2015.05.15
            //strSQL.Append("     WHERE X.ENTRY_DATE = (SELECT MAX(A.ENTRY_DATE) FROM PRODUCTION_ACTUAL A WHERE A.JOB_ORDER_NO=X.JOB_ORDER_NO AND A.PROCESS_SEQ = X.PROCESS_SEQ) ");    // 2015.05.15
            // 2015.05.15 START
            strSQL.Append("     	SELECT  ");
            strSQL.Append("     	JOB_ORDER_NO,WS_CD,PROCESS_SEQ,PROCESS_CD,RESOURCE_CD, ");
            strSQL.Append("     		MIN(ACT_START_TIME) ACT_START_TIME,MAX(ACT_END_TIME) ACT_END_TIME,             ");
            strSQL.Append("     		COALESCE(SUM(COMPL_QTY),0) COMPL_QTY, COALESCE(SUM(REJ_QTY),0) REJ_QTY, COALESCE(SUM(HOLD_QTY),0) HOLD_QTY,                ");
            strSQL.Append("     		COALESCE(SUM(ACT_WORK_TIME),0) ACT_WORK_TIME,                ");
            strSQL.Append("     		MIN(BREAK_START_TIME) BREAK_START_TIME, MAX(BREAK_END_TIME) BREAK_END_TIME, COALESCE(SUM(ACT_BREAK_TIME),0) ACT_BREAK_TIME,MAX(SUSPEND_USER_ID) SUSPEND_USER_ID, ");
            strSQL.Append("     		MIN(SETUP_START_TIME) SETUP_START_TIME, MAX(SETUP_END_TIME) SETUP_END_TIME, COALESCE(SUM(ACT_SETUP_TIME),0) ACT_SETUP_TIME,MAX(SETUP_USER_ID) SETUP_USER_ID, ");
            strSQL.Append("     		MAX(START_USER_ID) START_USER_ID, MAX(END_USER_ID) END_USER_ID, ");
            strSQL.Append("     		MAX(START_WORKER_ID) START_WORKER_ID,MAX(END_WORKER_ID) END_WORKER_ID ");
            strSQL.Append("     	FROM (             ");
            strSQL.Append("     		SELECT JOB_ORDER_NO,WS_CD,PROCESS_SEQ,PROCESS_CD,RESOURCE_CD, ");
            strSQL.Append("     		MIN(ACT_START_TIME) ACT_START_TIME,MAX(ACT_END_TIME) ACT_END_TIME,             ");
            strSQL.Append("     		COALESCE(SUM(COMPL_QTY),0) COMPL_QTY, COALESCE(SUM(REJ_QTY),0) REJ_QTY, COALESCE(SUM(HOLD_QTY),0) HOLD_QTY,                ");
            strSQL.Append("     		COALESCE(SUM(ACT_WORK_TIME),0) ACT_WORK_TIME,                ");
            strSQL.Append("     		NULL BREAK_START_TIME, NULL BREAK_END_TIME, 0 ACT_BREAK_TIME,'' SUSPEND_USER_ID, ");
            strSQL.Append("     		NULL SETUP_START_TIME, NULL SETUP_END_TIME, 0 ACT_SETUP_TIME,'' SETUP_USER_ID, ");
            strSQL.Append("     		START_USER_ID, END_USER_ID, ");
            strSQL.Append("     		START_WORKER_ID,END_WORKER_ID ");
            strSQL.Append("     		FROM PRODUCTION_ACTUAL                ");
            strSQL.Append("     		WHERE ACTUAL_TYPE IN (21,22)   and JOB_ORDER_NO        ='PRD-001582'             ");
            strSQL.Append("     		GROUP BY JOB_ORDER_NO,WS_CD,PROCESS_SEQ,PROCESS_CD,RESOURCE_CD,START_USER_ID, END_USER_ID,START_WORKER_ID,END_WORKER_ID  ");
            strSQL.Append("     	UNION ALL            ");
            strSQL.Append("     		SELECT JOB_ORDER_NO,WS_CD,PROCESS_SEQ,PROCESS_CD,RESOURCE_CD, ");
            strSQL.Append("     		NULL ACT_START_TIME, NULL ACT_END_TIME, 0 COMPL_QTY, 0 REJ_QTY, 0 HOLD_QTY, ");
            strSQL.Append("     		0 ACT_WORK_TIME,            ");
            strSQL.Append("     		MAX(ACT_START_TIME) BREAK_START_TIME,MAX(ACT_END_TIME) BREAK_END_TIME,  ");
            strSQL.Append("     		COALESCE(SUM(ACT_BREAK_TIME),0) ACT_BREAK_TIME,SUSPEND_USER_ID,                ");
            strSQL.Append("     		NULL SETUP_START_TIME, NULL SETUP_END_TIME, 0 ACT_SETUP_TIME,'' SETUP_USER_ID, ");
            strSQL.Append("     		'' START_USER_ID, '' END_USER_ID, ");
            strSQL.Append("     		'' START_WORKER_ID,'' END_WORKER_ID ");
            strSQL.Append("     		FROM PRODUCTION_ACTUAL                ");
            strSQL.Append("     		WHERE ACTUAL_TYPE IN (31,32)   and JOB_ORDER_NO        ='PRD-001582'               ");
            strSQL.Append("     		GROUP BY JOB_ORDER_NO,WS_CD,PROCESS_SEQ,PROCESS_CD,RESOURCE_CD,SUSPEND_USER_ID          ");
            strSQL.Append("     	UNION ALL            ");
            strSQL.Append("     		SELECT JOB_ORDER_NO,WS_CD,PROCESS_SEQ,PROCESS_CD,RESOURCE_CD, ");
            strSQL.Append("     		NULL ACT_START_TIME, NULL ACT_END_TIME, 0 COMPL_QTY, 0 REJ_QTY, 0 HOLD_QTY, ");
            strSQL.Append("     		0 ACT_WORK_TIME,            ");
            strSQL.Append("     		NULL BREAK_START_TIME, NULL BREAK_END_TIME, 0 ACT_BREAK_TIME,'' SUSPEND_USER_ID, ");
            strSQL.Append("     		MAX(ACT_START_TIME) SETUP_START_TIME,MAX(ACT_END_TIME) SETUP_END_TIME,             ");
            strSQL.Append("     		COALESCE(SUM(ACT_SETUP_TIME),0) ACT_SETUP_TIME,SETUP_USER_ID,                ");
            strSQL.Append("     		'' START_USER_ID, '' END_USER_ID, ");
            strSQL.Append("     		'' START_WORKER_ID,'' END_WORKER_ID ");
            strSQL.Append("     		FROM PRODUCTION_ACTUAL                ");
            strSQL.Append("     		WHERE ACTUAL_TYPE IN (11,12)   and JOB_ORDER_NO        ='PRD-001582'               ");
            strSQL.Append("     		GROUP BY JOB_ORDER_NO,WS_CD,PROCESS_SEQ,PROCESS_CD,RESOURCE_CD,SETUP_USER_ID          ");
            strSQL.Append("     	) A ");
            strSQL.Append("     	GROUP BY JOB_ORDER_NO,WS_CD,PROCESS_SEQ,PROCESS_CD,RESOURCE_CD ");
            // 2015.05.15 END
            strSQL.Append("  ) P    ");
            strSQL.Append(" ON JOD.JOB_ORDER_NO=P.JOB_ORDER_NO AND JOD.PROCESS_SEQ = P.PROCESS_SEQ AND JOD.PROCESS_CD = P.PROCESS_CD  ");
            strSQL.Append(" LEFT JOIN WORKSHOP_MASTER W ON JO.WS_CD=W.WS_CD                                              ");
            strSQL.Append(" LEFT JOIN PROCESS_MASTER PR ON JO.WS_CD=PR.WS_CD AND JOD.PROCESS_CD = PR.PROCESS_CD            ");

            strSQL.Append(" LEFT JOIN RESOURCE_MASTER RS ON P.WS_CD=RS.WS_CD AND P.PROCESS_CD = RS.PROCESS_CD AND P.RESOURCE_CD = RS.RESOURCE_CD ");
            
            //strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON    S1.KEY01='ITEM_UMSR'  AND P.ITEM_UMSR = S1.KEY02    ");
            //strSQL.Append(" LEFT JOIN PROCESS_NG_REASON_MASTER NG ON P.WS_CD=NG.WS_CD AND P.PROCESS_CD = NG.PROCESS_CD AND P.NG_REASON_CD = NG.NG_REASON_CD ");
            //strSQL.Append(" LEFT JOIN DOWN_REASON_MASTER DW ON P.RESOURCE_CD=DW.RESOURCE_CD AND P.DOWN_REASON_CD = DW.DOWN_REASON_CD ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S2 ON    S2.KEY01='WORKER_CD'  AND (CASE P.END_WORKER_ID WHEN '' THEN P.START_WORKER_ID ELSE P.END_WORKER_ID END) = S2.KEY02    ");
            strSQL.Append(" WHERE  JO.SCH_FIX_FLAG = 1  ");   // WIPのみ

            db.DbParametersClear();

            strSQL.Append("   AND JOD.JOB_ORDER_NO        =@JOB_ORDER_NO");
            db.DbPsetString("@JOB_ORDER_NO", _job_order_no);

            strSQL.Append(" ORDER BY JOD.PROCESS_SEQ, P.ACT_START_TIME ");
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
        /// 生産性分析－製造指示：JO製造実績工程ごとの取得
        /// AlsProd_frmMain
        /// </summary>
        public DataSet GetProcessActualOfJOProcess()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT      ");
            strSQL.Append(" P.PROCESS_CD, PR.PROCESS_DESC, P.SETUP_START_TIME, P.SETUP_END_TIME, convert(varchar,P.ACT_SETUP_TIME) ACT_SETUP_TIME, P.ACT_START_TIME, P.ACT_END_TIME, convert(varchar,P.ACT_WORK_TIME) ACT_WORK_TIME, convert(varchar,P.ACT_BREAK_TIME) ACT_BREAK_TIME,  ");
            strSQL.Append(" JO.JOB_ORDER_QTY,JOD.COMPL_QTY, JOD.REJ_QTY   ");
            strSQL.Append(" FROM  ");
            strSQL.Append(" (           ");
            //                  製造指示№、工順、工程ごとで最後の製造実績（製造開始または終了）の情報
            strSQL.Append("     SELECT X.JOB_ORDER_NO,X.WS_CD,X.PROCESS_SEQ,X.PROCESS_CD,Y.COMPL_QTY,Y.REJ_QTY,X.ACT_START_TIME,X.ACT_END_TIME,Y.ACT_WORK_TIME,              ");
            strSQL.Append("      Z.BREAK_START_TIME,Z.BREAK_END_TIME,Z.ACT_BREAK_TIME,Q.SETUP_START_TIME,Q.SETUP_END_TIME,X.START_WORKER_ID,X.END_WORKER_ID,Q.ACT_SETUP_TIME              ");
            strSQL.Append("       FROM PRODUCTION_ACTUAL X  ");
            strSQL.Append("     INNER JOIN (   ");
            //                      製造指示№、工順、工程ごとで最後の製造実績（製造開始または終了）
            strSQL.Append("         SELECT JOB_ORDER_NO,PROCESS_SEQ,PROCESS_CD,MAX(ACT_START_TIME) ACT_START_TIME,   ");
            strSQL.Append("         COALESCE(SUM(COMPL_QTY),0) COMPL_QTY, COALESCE(SUM(REJ_QTY),0) REJ_QTY,      ");
            strSQL.Append("         COALESCE(SUM(ACT_SETUP_TIME),0) ACT_SETUP_TIME, COALESCE(SUM(ACT_WORK_TIME),0) ACT_WORK_TIME      ");
            strSQL.Append("         FROM PRODUCTION_ACTUAL      ");
            strSQL.Append("         WHERE ACTUAL_TYPE IN (21,22)      ");
            strSQL.Append("         GROUP BY JOB_ORDER_NO,PROCESS_SEQ,PROCESS_CD   ");
            strSQL.Append("      )Y ON X.JOB_ORDER_NO = Y.JOB_ORDER_NO AND X.PROCESS_SEQ = Y.PROCESS_SEQ AND X.PROCESS_CD = Y.PROCESS_CD AND X.ACT_START_TIME = Y.ACT_START_TIME   ");
            strSQL.Append("     LEFT JOIN (   ");
            //                      製造指示№、工順、工程ごとで最後の中断実績（中断開始または終了）
            strSQL.Append("         SELECT JOB_ORDER_NO,PROCESS_SEQ,PROCESS_CD,MAX(ACT_START_TIME) BREAK_START_TIME,MAX(ACT_END_TIME) BREAK_END_TIME,   ");
            strSQL.Append("         COALESCE(SUM(ACT_BREAK_TIME),0) ACT_BREAK_TIME      ");
            strSQL.Append("         FROM PRODUCTION_ACTUAL      ");
            strSQL.Append("         WHERE ACTUAL_TYPE IN (31,32)      ");
            strSQL.Append("         GROUP BY JOB_ORDER_NO,PROCESS_SEQ,PROCESS_CD   ");
            strSQL.Append("      )Z ON X.JOB_ORDER_NO = Z.JOB_ORDER_NO AND X.PROCESS_SEQ = Z.PROCESS_SEQ AND X.PROCESS_CD = Z.PROCESS_CD    ");
            strSQL.Append("     LEFT JOIN (   ");
            //                      製造指示№、工順、工程ごとで最後の段取実績（段取開始または終了）
            strSQL.Append("         SELECT JOB_ORDER_NO,PROCESS_SEQ,PROCESS_CD,MAX(ACT_START_TIME) SETUP_START_TIME,MAX(ACT_END_TIME) SETUP_END_TIME,   ");
            strSQL.Append("         COALESCE(SUM(ACT_SETUP_TIME),0) ACT_SETUP_TIME      ");
            strSQL.Append("         FROM PRODUCTION_ACTUAL      ");
            strSQL.Append("         WHERE ACTUAL_TYPE IN (11,12)      ");
            strSQL.Append("         GROUP BY JOB_ORDER_NO,PROCESS_SEQ,PROCESS_CD   ");
            strSQL.Append("      )Q ON X.JOB_ORDER_NO = Q.JOB_ORDER_NO AND X.PROCESS_SEQ = Q.PROCESS_SEQ AND X.PROCESS_CD = Q.PROCESS_CD    ");
            strSQL.Append("     WHERE X.ACTUAL_TYPE IN (21,22)             ");
            strSQL.Append("  ) P    ");

            strSQL.Append(" LEFT JOIN JOB_ORDER_DETAIL JOD ON JOD.JOB_ORDER_NO=P.JOB_ORDER_NO AND JOD.PROCESS_SEQ = P.PROCESS_SEQ AND JOD.PROCESS_CD = P.PROCESS_CD  ");   // 
            strSQL.Append(" LEFT JOIN JOB_ORDER JO ON JO.JOB_ORDER_NO=P.JOB_ORDER_NO AND JO.SCH_FIX_FLAG = 1  ");   // WIPのみ
            //strSQL.Append(" LEFT JOIN WORKSHOP_MASTER W ON P.WS_CD=W.WS_CD                                              ");
            strSQL.Append(" LEFT JOIN PROCESS_MASTER PR ON P.WS_CD=PR.WS_CD AND P.PROCESS_CD = PR.PROCESS_CD            ");
            //strSQL.Append(" LEFT JOIN RESOURCE_MASTER RS ON P.WS_CD=RS.WS_CD AND P.PROCESS_CD = RS.PROCESS_CD AND P.RESOURCE_CD = RS.RESOURCE_CD ");

            //strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON    S1.KEY01='ITEM_UMSR'  AND P.ITEM_UMSR = S1.KEY02    ");
            //strSQL.Append(" LEFT JOIN PROCESS_NG_REASON_MASTER NG ON P.WS_CD=NG.WS_CD AND P.PROCESS_CD = NG.PROCESS_CD AND P.NG_REASON_CD = NG.NG_REASON_CD ");
            //strSQL.Append(" LEFT JOIN DOWN_REASON_MASTER DW ON P.RESOURCE_CD=DW.RESOURCE_CD AND P.DOWN_REASON_CD = DW.DOWN_REASON_CD ");
            //strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S2 ON    S2.KEY01='WORKER_CD'  AND (CASE P.END_WORKER_ID WHEN '' THEN P.START_WORKER_ID ELSE P.END_WORKER_ID END) = S2.KEY02    ");
            strSQL.Append(" WHERE  1 = 1  ");

            db.DbParametersClear();

            strSQL.Append("   AND JOD.JOB_ORDER_NO        =@JOB_ORDER_NO");
            db.DbPsetString("@JOB_ORDER_NO", _job_order_no);

            strSQL.Append(" ORDER BY JOD.PROCESS_SEQ ");
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
        /// 生産性分析－資源：資源ごとの実績取得
        /// AlsProd_frmMain2
        /// </summary>
        public DataSet GetProcessActualOfResource()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            db.DbParametersClear();

            strSQL.Append(" SELECT      ");
            strSQL.Append(" P.WS_CD, W.WS_DESC, P.PROCESS_CD, PR.PROCESS_DESC, P.RESOURCE_CD, RS.RESOURCE_DESC, convert(varchar,P.ACT_SETUP_TIME) ACT_SETUP_TIME, convert(varchar,P.ACT_WORK_TIME) ACT_WORK_TIME, convert(varchar,P.ACT_BREAK_TIME) ACT_BREAK_TIME  ");
            strSQL.Append(" FROM  ");
            strSQL.Append(" (           ");
            //                  製造指示№、工順、工程ごとの製造実績サマリの情報
            strSQL.Append("     SELECT X.WS_CD,X.PROCESS_CD,X.RESOURCE_CD,COALESCE(SUM(ACT_SETUP_TIME),0) ACT_SETUP_TIME,COALESCE(SUM(ACT_WORK_TIME),0) ACT_WORK_TIME,COALESCE(SUM(ACT_BREAK_TIME),0) ACT_BREAK_TIME              ");
            strSQL.Append("       FROM PRODUCTION_ACTUAL X  ");
            //strSQL.Append("     WHERE X.WS_CD <> ''      ");
            strSQL.Append("     WHERE 1 = 1  ");    // 2015.05.29

            if (_resource_cd != "")
            {
                strSQL.Append("   AND X.RESOURCE_CD        =@RESOURCE_CD");
                db.DbPsetString("@RESOURCE_CD", _resource_cd);
            }
            if (_ws_cd != "")
            {
                strSQL.Append("   AND X.WS_CD        =@WS_CD");
                db.DbPsetString("@WS_CD", _ws_cd);
            }
            if (_process_cd != "")
            {
                strSQL.Append("   AND X.PROCESS_CD        =@PROCESS_CD");
                db.DbPsetString("@PROCESS_CD", _process_cd);
            }
            if (_sch_start_date != 0)
            {

                strSQL.Append("   AND (X.ACT_END_TIME >= @ACT_END_TIME OR X.ACT_END_TIME IS NULL AND X.ACT_START_TIME >= @ACT_END_TIME)");
                db.DbPsetDate("@ACT_END_TIME", _start_date);
            }
            if (sch_compl_date != 0)
            {

                strSQL.Append("   AND X.ACT_START_TIME <= @ACT_START_TIME");
                db.DbPsetDate("@ACT_START_TIME", _end_date);
            }

            strSQL.Append("     GROUP BY  X.WS_CD,X.PROCESS_CD,X.RESOURCE_CD ");
            strSQL.Append("  ) P    ");

            //strSQL.Append(" LEFT JOIN JOB_ORDER_DETAIL JOD ON JOD.JOB_ORDER_NO=P.JOB_ORDER_NO AND JOD.PROCESS_SEQ = P.PROCESS_SEQ AND JOD.PROCESS_CD = P.PROCESS_CD  ");   // 
            //strSQL.Append(" LEFT JOIN JOB_ORDER JO ON JO.JOB_ORDER_NO=P.JOB_ORDER_NO AND JO.SCH_FIX_FLAG = 1  ");   // WIPのみ
            strSQL.Append(" LEFT JOIN WORKSHOP_MASTER W ON P.WS_CD=W.WS_CD                                              ");
            strSQL.Append(" LEFT JOIN PROCESS_MASTER PR ON P.WS_CD=PR.WS_CD AND P.PROCESS_CD = PR.PROCESS_CD            ");
            strSQL.Append(" LEFT JOIN RESOURCE_MASTER RS ON P.WS_CD=RS.WS_CD AND P.PROCESS_CD = RS.PROCESS_CD AND P.RESOURCE_CD = RS.RESOURCE_CD ");

            //strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON    S1.KEY01='ITEM_UMSR'  AND P.ITEM_UMSR = S1.KEY02    ");
            //strSQL.Append(" LEFT JOIN PROCESS_NG_REASON_MASTER NG ON P.WS_CD=NG.WS_CD AND P.PROCESS_CD = NG.PROCESS_CD AND P.NG_REASON_CD = NG.NG_REASON_CD ");
            //strSQL.Append(" LEFT JOIN DOWN_REASON_MASTER DW ON P.RESOURCE_CD=DW.RESOURCE_CD AND P.DOWN_REASON_CD = DW.DOWN_REASON_CD ");
            //strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S2 ON    S2.KEY01='WORKER_CD'  AND (CASE P.END_WORKER_ID WHEN '' THEN P.START_WORKER_ID ELSE P.END_WORKER_ID END) = S2.KEY02    ");
            //strSQL.Append(" WHERE  1 = 1  ");


            strSQL.Append(" ORDER BY P.WS_CD, P.PROCESS_CD, P.RESOURCE_CD ");
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
        /// 生産性分析－品目：品目ごとの実績取得
        /// AlsProd_frmMain3
        /// </summary>
        public DataSet GetProcessActualOfItem()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            db.DbParametersClear();

            strSQL.Append(" SELECT      ");
            strSQL.Append(" P.ITEM_NO, I.ITEM_DESC, P.COMPL_QTY, P.REJ_QTY, convert(varchar,P.ACT_SETUP_TIME) ACT_SETUP_TIME, convert(varchar,P.ACT_WORK_TIME) ACT_WORK_TIME, convert(varchar,P.ACT_BREAK_TIME) ACT_BREAK_TIME  ");
            strSQL.Append(" FROM  ");
            strSQL.Append(" (           ");
            //                  品目ごとでの製造実績サマリの情報
            //strSQL.Append("     SELECT X.ITEM_NO,COALESCE(SUM(COMPL_QTY),0) COMPL_QTY,COALESCE(SUM(REJ_QTY),0) REJ_QTY,COALESCE(SUM(ACT_SETUP_TIME),0) ACT_SETUP_TIME,COALESCE(SUM(ACT_WORK_TIME),0) ACT_WORK_TIME,COALESCE(SUM(ACT_BREAK_TIME),0) ACT_BREAK_TIME              ");
            strSQL.Append("     SELECT X.ITEM_NO ");
            strSQL.Append("       ,COALESCE(SUM(CASE LAST_FLAG WHEN 0 THEN 0 ELSE COMPL_QTY END),0) COMPL_QTY ");   // 2015.09.25
            strSQL.Append("       ,COALESCE(SUM(REJ_QTY),0) REJ_QTY,COALESCE(SUM(ACT_SETUP_TIME),0) ACT_SETUP_TIME,COALESCE(SUM(ACT_WORK_TIME),0) ACT_WORK_TIME,COALESCE(SUM(ACT_BREAK_TIME),0) ACT_BREAK_TIME              ");
            strSQL.Append("       FROM PRODUCTION_ACTUAL X  ");
            strSQL.Append("     WHERE X.ITEM_NO <> ''      ");
            if (_item_no != "")
            {
                strSQL.Append("   AND X.ITEM_NO        =@ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_sch_start_date != 0)
            {

                strSQL.Append("   AND (X.ACT_END_TIME >= @ACT_END_TIME OR X.ACT_END_TIME IS NULL AND X.ACT_START_TIME >= @ACT_END_TIME)");
                db.DbPsetDate("@ACT_END_TIME", _start_date);
            }
            if (sch_compl_date != 0)
            {

                strSQL.Append("   AND X.ACT_START_TIME <= @ACT_START_TIME");
                db.DbPsetDate("@ACT_START_TIME", _end_date);
            }

            strSQL.Append("     GROUP BY  X.ITEM_NO ");
            strSQL.Append("  ) P    ");

            strSQL.Append(" LEFT JOIN ITEM_MASTER I ON P.ITEM_NO=I.ITEM_NO       ");

            strSQL.Append(" ORDER BY P.ITEM_NO ");
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
        /// WIP在庫検索
        /// 使用画面：InvWIPStockInq
        /// </summary>
        /// <returns></returns>
        public DataSet GetWIPInventory()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            db.DbParametersClear();

            //if (_status == "" || _status == "OK")
            //{
            //    strSQL.Append(" SELECT      ");
            //    strSQL.Append(" P.WS_CD, W.WS_DESC, P.ITEM_NO, P.ITEM_DESC, P.ITEM_TYPE, SUM(P.COMPL_QTY) INV_QTY, 'OK' STATUS ");
            //    strSQL.Append(" FROM  ");
            //    strSQL.Append(" (           ");
            //    //                  良品数は製造指示№ごとで最後の工程のみ（未完成の製造指示のみ）
            //    //                  製造指示№、工順、工程ごとで最後の工順の製造実績（製造開始または終了）の情報
            //    strSQL.Append("     SELECT X.JOB_ORDER_NO,X.WS_CD,X.PROCESS_SEQ,X.PROCESS_CD,JO.ITEM_NO,JO.ITEM_DESC,JO.ITEM_TYPE,              ");
            //    strSQL.Append("         COALESCE(SUM(X.COMPL_QTY),0) COMPL_QTY      ");
            //    strSQL.Append("       FROM PRODUCTION_ACTUAL X  ");
            //    strSQL.Append("     INNER JOIN (   ");
            //    //                      製造指示№ごとで製造実績（製造開始または終了）の最後の工順
            //    strSQL.Append("         SELECT JOB_ORDER_NO,MAX(PROCESS_SEQ) PROCESS_SEQ   ");
            //    strSQL.Append("         FROM PRODUCTION_ACTUAL      ");
            //    strSQL.Append("         WHERE ACTUAL_TYPE IN (21,22)      ");
            //    strSQL.Append("         GROUP BY JOB_ORDER_NO   ");
            //    strSQL.Append("      )Y ON X.JOB_ORDER_NO = Y.JOB_ORDER_NO AND X.PROCESS_SEQ = Y.PROCESS_SEQ ");
            //    strSQL.Append("     INNER JOIN JOB_ORDER JO ON JO.JOB_ORDER_NO=X.JOB_ORDER_NO AND JO.SCH_FIX_FLAG = 1 AND JO.ORDER_STATUS < 40 ");   // WIPのみ,未完成のみ
            //    if (_job_order_no != "")
            //    {
            //        strSQL.Append("   AND JO.JOB_ORDER_NO        =@JOB_ORDER_NO");
            //        db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
            //    }
            //    strSQL.Append("     GROUP BY X.JOB_ORDER_NO,X.WS_CD,X.PROCESS_SEQ,X.PROCESS_CD,JO.ITEM_NO,JO.ITEM_DESC,JO.ITEM_TYPE ");
            //    strSQL.Append("  ) P    ");
            //    strSQL.Append(" LEFT JOIN WORKSHOP_MASTER W ON P.WS_CD=W.WS_CD      ");
            //    strSQL.Append(" WHERE P.COMPL_QTY <> 0  ");
            //    if (_item_no != "")
            //    {
            //        strSQL.Append("   AND P.ITEM_NO        =@ITEM_NO");
            //        db.DbPsetString("@ITEM_NO", _item_no);
            //    }
            //    if (_ws_cd != "")
            //    {
            //        strSQL.Append("   AND P.WS_CD        =@WS_CD");
            //        db.DbPsetString("@WS_CD", _ws_cd);
            //    }
            //    strSQL.Append(" GROUP BY P.WS_CD, W.WS_DESC, P.ITEM_NO, P.ITEM_DESC, P.ITEM_TYPE  ");
            //}
            //if (_status == "")
            //{
            //    strSQL.Append(" UNION ALL  ");
            //}
            //if (_status == "" || _status == "NG")
            //{
            //    strSQL.Append(" SELECT      ");
            //    strSQL.Append(" P.WS_CD, W.WS_DESC, P.ITEM_NO, P.ITEM_DESC, P.ITEM_TYPE, P.REJ_QTY INV_QTY, 'NG' STATUS ");
            //    strSQL.Append(" FROM  ");
            //    strSQL.Append(" (           ");
            //    //                  不良数は作業区ごとで不良数を合計（未完成の製造指示のみ）
            //    strSQL.Append("     SELECT X.WS_CD,JO.ITEM_NO,JO.ITEM_DESC,JO.ITEM_TYPE,              ");
            //    strSQL.Append("         COALESCE(SUM(X.REJ_QTY),0) REJ_QTY      ");
            //    strSQL.Append("       FROM PRODUCTION_ACTUAL X  ");
            //    strSQL.Append("     INNER JOIN JOB_ORDER JO ON JO.JOB_ORDER_NO=X.JOB_ORDER_NO AND JO.SCH_FIX_FLAG = 1 AND JO.ORDER_STATUS < 40 ");   // WIPのみ,未完成のみ
            //    if (_job_order_no != "")
            //    {
            //        strSQL.Append("   AND JO.JOB_ORDER_NO        =@JOB_ORDER_NO2");
            //        db.DbPsetString("@JOB_ORDER_NO2", _job_order_no);
            //    }
            //    strSQL.Append("     GROUP BY X.WS_CD,JO.ITEM_NO,JO.ITEM_DESC,JO.ITEM_TYPE ");
            //    strSQL.Append("  ) P    ");
            //    strSQL.Append(" LEFT JOIN WORKSHOP_MASTER W ON P.WS_CD=W.WS_CD                                              ");
            //    strSQL.Append(" WHERE P.REJ_QTY <> 0  ");
            //    if (_item_no != "")
            //    {
            //        strSQL.Append("   AND P.ITEM_NO        =@ITEM_NO2");
            //        db.DbPsetString("@ITEM_NO2", _item_no);
            //    }
            //    if (_ws_cd != "")
            //    {
            //        strSQL.Append("   AND P.WS_CD        =@WS_CD2");
            //        db.DbPsetString("@WS_CD2", _ws_cd);
            //    }
            //}

            //strSQL.Append(" ORDER BY 1, 5, 3, 7 ");

            // 2015.06.12
            strSQL.Append(" SELECT  INV1.WS_CD, INV1.WS_DESC, '' WHS_CD,INV1.ITEM_NO,INV1.ITEM_DESC,INV1.ITEM_TYPE,INV1.INV_BAL INV_QTY,INV1.ALLOC_QTY,INV1.ITEM_UMSR, ");
            //strSQL.Append(" INV2.LAST_RECV_DATE,INV2.LAST_DISB_DATE, '' PROCESS_CD, '' PROCESS_DESC ");
            //strSQL.Append(" '' LOT_NO,     '' JOC_CD,     '' SUPPLY_TYPE,        '' WHS_DESC,'' INV_TYPE  ");
            strSQL.Append(" INV1.STATUS   "); // 2015.03.05
            //strSQL.Append(" ,'' VENDOR_LOT_NO1 ,'' VENDOR_LOT_NO2 ,'' VENDOR_LOT_NO3 ,'' VENDOR_LOT_NO4 ,'' VENDOR_LOT_NO5, 'OK' STATUS      "); // 2015.05.29
            strSQL.Append(" FROM   "); // 2015.03.05
            strSQL.Append(" (SELECT                                                                            ");
            strSQL.Append(" INV.WS_CD, WS.WS_DESC,  INV.ITEM_NO,            I.ITEM_DESC,        I.ITEM_TYPE,    ");
            //strSQL.Append(" SUM(INV.INV_BAL) INV_BAL,    SUM(INV.ALLOC_QTY) ALLOC_QTY,  SP.DATA_CHAR ITEM_UMSR ");
            strSQL.Append(" SUM(INV.INV_BAL) INV_BAL,    SUM(INV.ALLOC_QTY) ALLOC_QTY,  SP.DATA_CHAR ITEM_UMSR ");   // 2015.04.24
            strSQL.Append(" ,CASE INV.INV_TYPE WHEN 3 THEN 'On Process' ELSE 'OK' END STATUS      "); // 2015.01.28
            db.DbParametersClear();

            strSQL.Append(" FROM INVENTORY_DETAIL INV                                                                   ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON INV.ITEM_NO=I.ITEM_NO                                      ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SP ON SP.KEY01 = 'ITEM_UMSR' AND SP.KEY02 = I.ITEM_UMSR    ");
            strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON INV.WHS_CD=W.WHS_CD                                   ");
            strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON INV.WS_CD=WS.WS_CD                                    ");

            strSQL.Append(" WHERE INV.INV_YM       = 0  ");
            strSQL.Append("   AND INV.INV_WIP_TYPE = 1  ");
            if (_status == "")
                strSQL.Append("   AND INV.INV_TYPE     IN (3,4)  ");
            if (_status == "OK")
                strSQL.Append("   AND INV.INV_TYPE     IN (4)  ");
            if (_status == "On Process")
                strSQL.Append("   AND INV.INV_TYPE     IN (3)  ");
            strSQL.Append("   AND (INV.INV_BAL    <> 0  ");
            strSQL.Append("   OR INV.ALLOC_QTY    <> 0) ");

            if (item_no != "" && parent_item_no == "")
            {
                strSQL.Append(" AND INV.ITEM_NO=@ITEM_NO     ");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            else if (item_no != "" && parent_item_no != "")
            {
                strSQL.Append(" AND (INV.ITEM_NO=@ITEM_NO AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                  ");
                strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO ))                                 ");
                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);

            }
            else if (item_no == "" && parent_item_no != "")
            {
                strSQL.Append(" AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                                           ");
                strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO )                                 ");
                db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
            }

            if (whs_cd != "")
            {
                strSQL.Append(" AND INV.WHS_CD=@WHS_CD       ");
                db.DbPsetString("@WHS_CD", _whs_cd);
            }

            if (ws_cd != "")
            {
                strSQL.Append(" AND INV.WS_CD=@WS_CD       ");
                db.DbPsetString("@WS_CD", _ws_cd);
            }
            if (_job_order_no != "")
            {
                strSQL.Append(" AND INV.JOB_ORDER_NO=@JOB_ORDER_NO       ");
                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
            }
            if (catg_cd != "")
            {
                strSQL.Append(" AND I.CATG_CD=@CATG_CD       ");
                db.DbPsetString("@CATG_CD", _catg_cd);
            }
            if (_status == "NG")
                strSQL.Append(" AND 1 = 0  ");

            strSQL.Append(" GROUP BY ");
            strSQL.Append(" INV.WS_CD, WS.WS_DESC, INV.ITEM_NO, I.ITEM_DESC, I.ITEM_TYPE, SP.DATA_CHAR, INV.INV_TYPE) INV1 ");
            strSQL.Append(" ORDER BY WS_CD,ITEM_NO");

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
        /// <summary>SEQ
        /// 製造指示変更（明細）、再加工指示：JO製造工程の計画・実績取得
        /// MfgJOUpd_frmDetail,MfgJOUpd_frmDetail2
        /// </summary>
        public DataSet GetJobOrderDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT      ");
            strSQL.Append(" JOD.PROCESS_SEQ,JOD.PROCESS_CD, PR.PROCESS_DESC, SUM(JOD.SCH_COMPL_QTY) SCH_COMPL_QTY,SUM(JOD.COMPL_QTY) COMPL_QTY, SUM(JOD.REJ_QTY) REJ_QTY, ");
            strSQL.Append(" MAX(JOD.FIRST_FLAG) FIRST_FLAG,MAX(JOD.LAST_FLAG) LAST_FLAG ");
            strSQL.Append(" ,JOD.RESOURCE_CD, RM.RESOURCE_DESC ");
            strSQL.Append(" FROM JOB_ORDER_DETAIL JOD    ");
            strSQL.Append(" LEFT JOIN JOB_ORDER JO ON JO.JOB_ORDER_NO=JOD.JOB_ORDER_NO    ");
            strSQL.Append(" LEFT JOIN PROCESS_MASTER PR ON JO.WS_CD=PR.WS_CD AND JOD.PROCESS_CD = PR.PROCESS_CD            ");
            strSQL.Append(" LEFT JOIN RESOURCE_MASTER RM ON JOD.RESOURCE_CD=RM.RESOURCE_CD ");
            strSQL.Append(" WHERE  1 = 1  ");   // WIPのみ

            db.DbParametersClear();

            //strSQL.Append("   AND JOD.JOB_ORDER_NO LIKE @JOB_ORDER_NO");
            //db.DbPsetString("@JOB_ORDER_NO", _job_order_no + "%");
            strSQL.Append("   AND JOD.JOB_ORDER_NO = @JOB_ORDER_NO");
            db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
            if (_process_seq != 0)
            {
                strSQL.Append("   AND JOD.PROCESS_SEQ = @PROCESS_SEQ");   // 2015.05.25
                db.DbPsetInt("@PROCESS_SEQ", _process_seq);
            }

            strSQL.Append(" GROUP BY JOD.PROCESS_SEQ,JOD.PROCESS_CD, PR.PROCESS_DESC,JOD.RESOURCE_CD, RM.RESOURCE_DESC ");
            strSQL.Append(" ORDER BY JOD.PROCESS_SEQ ");
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

        /// <summary>SEQ
        /// JOD取得
        /// HTProcessAct
        /// </summary>
        public DataSet GetJobOrderDetailWIP()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT      ");
            strSQL.Append(" JOD.PROCESS_SEQ,JOD.PROCESS_CD, PR.PROCESS_DESC, JOD.SCH_COMPL_QTY,JOD.COMPL_QTY, JOD.REJ_QTY,JOD.SCH_SETUP_TIME, ");
            strSQL.Append(" JOD.FIRST_FLAG,JOD.LAST_FLAG ");
            strSQL.Append(" ,JOD.RESOURCE_CD, RM.RESOURCE_DESC, JOD.JOB_ORDER_STATUS ");
            strSQL.Append(" FROM JOB_ORDER_DETAIL JOD    ");
            strSQL.Append(" LEFT JOIN JOB_ORDER JO ON JO.JOB_ORDER_NO=JOD.JOB_ORDER_NO    ");
            strSQL.Append(" LEFT JOIN PROCESS_MASTER PR ON JO.WS_CD=PR.WS_CD AND JOD.PROCESS_CD = PR.PROCESS_CD            ");
            strSQL.Append(" LEFT JOIN RESOURCE_MASTER RM ON JOD.RESOURCE_CD=RM.RESOURCE_CD ");
            strSQL.Append(" WHERE  1 = 1  ");   // WIPのみ

            db.DbParametersClear();

            //strSQL.Append("   AND JOD.JOB_ORDER_NO LIKE @JOB_ORDER_NO");
            //db.DbPsetString("@JOB_ORDER_NO", _job_order_no + "%");
            strSQL.Append("   AND JOD.JOB_ORDER_NO = @JOB_ORDER_NO");
            db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
            if (_process_seq != 0)
            {
                strSQL.Append("   AND JOD.PROCESS_SEQ = @PROCESS_SEQ");   // 2015.05.25
                db.DbPsetInt("@PROCESS_SEQ", _process_seq);
            }

            strSQL.Append(" ORDER BY JOD.PROCESS_SEQ ");
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

        /// <summary>SEQ
        /// 製造指示統合チェック用JOの計画・実績取得
        /// MfgJOUpd
        /// </summary>
        public DataSet GetJobOrderForCombine()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT      ");
            strSQL.Append(" JO.JOB_ORDER_NO,JO.ORDER_STATUS,JO.JOB_ORDER_QTY,JO.JOB_ORDER_COMPL_QTY,JO.SCH_START_DATE,");
            strSQL.Append(" COALESCE(MAX(PT.PICKING_STATUS),0) PICKING_STATUS ");
            strSQL.Append(" FROM JOB_ORDER JO    ");
            //strSQL.Append(" LEFT JOIN JOB_ORDER_DETAIL JOD ON JO.JOB_ORDER_NO=JOD.JOB_ORDER_NO    ");
            strSQL.Append(" LEFT JOIN PICKING_TRANS PT ON JO.JOB_ORDER_NO=PT.JOB_ORDER_NO    ");
            //strSQL.Append(" LEFT JOIN PROCESS_MASTER PR ON JO.WS_CD=PR.WS_CD AND JOD.PROCESS_CD = PR.PROCESS_CD            ");
            //strSQL.Append(" LEFT JOIN RESOURCE_MASTER RM ON JOD.RESOURCE_CD=RM.RESOURCE_CD ");
            strSQL.Append(" WHERE  1 = 1  ");   // WIPのみ
            strSQL.Append(" AND JO.ORDER_STATUS < 85        "); // 完成済を除く

            db.DbParametersClear();

            strSQL.Append("   AND JO.JOB_ORDER_NO = @JOB_ORDER_NO");
            db.DbPsetString("@JOB_ORDER_NO", _job_order_no);

            strSQL.Append(" GROUP BY JO.JOB_ORDER_NO,JO.ORDER_STATUS,JO.JOB_ORDER_QTY,JO.JOB_ORDER_COMPL_QTY,JO.SCH_START_DATE");
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
        /// 再加工指示処理
        /// MfgJOUpd_frmDetail2
        /// </summary>
        /// <returns></returns>
        public int Mfg_JoRework()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_DESC", _item_desc, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_SCH_START_DATE", _sch_start_date, ComConst.DB_IN);
            db.DbPsetDouble("@I_JOB_ORDER_QTY", _job_order_qty, ComConst.DB_IN);
            db.DbPsetInt("@I_SCH_COMPL_DATE", _sch_compl_date, ComConst.DB_IN);
            db.DbPsetString("@I_SLIP_NOTE", _slip_note, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_SEQ", _process_desc, ComConst.DB_IN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);    // IMV3
            db.DbPsetString("@I_FIRST_FLAG", _sch_id, ComConst.DB_IN);
            db.DbPsetString("@I_LAST_FLAG", _sch_name, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_MFG_JOREWORK");
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
        /// JO統合処理
        /// MfgJOUpd
        /// </summary>
        /// <returns></returns>
        public int Mfg_JoCombine()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_BASE_JOB_ORDER_NO", _order_no, ComConst.DB_IN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetInt("@I_SCH_START_DATE", _sch_start_date, ComConst.DB_IN);
            db.DbPsetDouble("@I_JOB_ORDER_QTY", _job_order_qty, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            //db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetString("@O_JOB_ORDER_NO", _plan_no, ComConst.DB_OUT);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_MFG_JOCOMBINE");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                _plan_no = db.DbPgetString("@O_JOB_ORDER_NO");
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
        /// 製造指示入力：工程情報取得
        /// MfgJOEntry
        /// </summary>
        public DataSet GetRoutineResourceList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT      ");
            strSQL.Append(" R.ROUTINE_SEQ		,R.PROCESS_CD   ,PR.PROCESS_DESC ");
            strSQL.Append(" ,0.0 SCH_COMPL_QTY  ,RR.RESOURCE_CD ,RM.RESOURCE_DESC ");
            strSQL.Append(",S3.DATA_CHAR AS UMSR_NAME	     ");    // IMV3

            strSQL.Append(" FROM ROUTINE_MASTER R    ");
            strSQL.Append(" LEFT JOIN ROUTINE_RESOURCE_MASTER RR ON R.ITEM_NO = RR.ITEM_NO AND R.WS_CD   = RR.WS_CD AND R.ROUTINE_SEQ = RR.ROUTINE_SEQ AND R.PROCESS_CD = RR.PROCESS_CD ");
            strSQL.Append(" AND RR.PTY_NO = (SELECT MIN(RR2.PTY_NO) FROM ROUTINE_RESOURCE_MASTER RR2 WHERE R.ITEM_NO = RR2.ITEM_NO AND R.WS_CD   = RR2.WS_CD AND R.ROUTINE_SEQ = RR2.ROUTINE_SEQ AND PROCESS_CD = RR2.PROCESS_CD) ");
            strSQL.Append(" LEFT JOIN PROCESS_MASTER PR ON R.WS_CD=PR.WS_CD AND R.PROCESS_CD = PR.PROCESS_CD            ");
            strSQL.Append(" LEFT JOIN RESOURCE_MASTER RM ON RR.RESOURCE_CD=RM.RESOURCE_CD ");
            strSQL.Append(" LEFT JOIN ITEM_MASTER I    ON  R.ITEM_NO     = I.ITEM_NO             ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S3 ON    S3.KEY01='ITEM_UMSR'  AND      I.ITEM_UMSR = S3.KEY02 ");
            strSQL.Append(" WHERE  1 = 1  ");

            strSQL.Append("   AND R.ITEM_NO = @ITEM_NO");
            strSQL.Append("   AND R.WS_CD = @WS_CD");

            strSQL.Append(" ORDER BY R.ROUTINE_SEQ ");

            db.DbParametersClear();

            db.DbPsetString("@ITEM_NO", _item_no);
            db.DbPsetString("@WS_CD", _ws_cd);
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
