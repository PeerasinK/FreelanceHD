using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

namespace IMClass
{
    public class ResourceCalendar
    {
        #region : 資源別カレンダマスタラクタ
        /// <summary>
        /// 資源別カレンダマスタラクタ
        /// </summary>
        public ResourceCalendar()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public ResourceCalendar(string p_user_id, int p_lang)
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
        protected int _logymd = 0;
        protected int _loghms = 0;
        protected string _item_no = "";
        protected int _yymm = 0;
        
        protected string _resource_cd = "";
        protected int _calendar_date = 0;
        protected int _working_time = 0;
        protected string _time_desc = "";

        protected DateTime _entry_date = DateTime.Now;
        protected DateTime _chg_date = DateTime.Now;
        protected string _chg_pgm = "";
        protected string _chg_user_id = "";
        protected int _update_cntr = 0;
        protected string _dbmsg = "";
        protected string _errmsg = "";
        protected int _errcode = 0;
        protected int _sqlcode = 0;
        protected string _strErr = "";
        protected string _proc_name = "";
        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        public int lang { get { return _lang; } set { _lang = value; } }
        public int yymm { get { return _yymm; } set { _yymm = value; } }
        public int logymd { get { return _logymd; } set { _logymd = value; } }
        public int loghms { get { return _loghms; } set { _loghms = value; } }
        public string item_no { get { return _item_no; } set { _item_no = value; } }

        public string resource_cd { get { return _resource_cd; } set { _resource_cd = value; } }
        public int calendar_date { get { return _calendar_date; } set { _calendar_date = value; } }
        public int working_time { get { return _working_time; } set { _working_time = value; } }
        public string time_desc { get { return _time_desc; } set { _time_desc = value; } }

        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string errmsg { get { return _errmsg; } set { _errmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }
        public int errcode { get { return _errcode; } set { _errcode = value; } }
        public int sqlcode { get { return _sqlcode; } set { _sqlcode = value; } }
        public string proc_name { get { return _proc_name; } set { _proc_name = value; } }

        #endregion

        /// <summary>
        /// 資源別カレンダマスタ、カレンダマスタを検索して明細部を編集する

        /// 
        /// 使用画面：MstResourceCalendarMnt 
        /// </summary>
        public DataSet GetResourceCalendarListByMonth()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();
            //--- sql
            strSQL.Append("SELECT                                                                           ");
            //strSQL.Append(" C.CALENDAR_DATE,    C.DAY_OF_WEEK,      C.STD_WORKING_HOUR,    C.HOLIDAY_FLAG,");
            strSQL.Append(" C.CALENDAR_DATE,    C.DAY_OF_WEEK,      C.HOLIDAY_FLAG,                         ");

            strSQL.Append(" STD_WORKING_HOUR = CASE WHEN RC.CALENDAR_DATE IS NULL THEN                      ");
            strSQL.Append(" (CASE WHEN C.HOLIDAY_FLAG = 1 THEN 0 ELSE C.STD_WORKING_HOUR END )              ");
            strSQL.Append(" ELSE RC.WORKING_TIME END,                                                       ");

            strSQL.Append(" WORKING_TIME = CASE WHEN RC.CALENDAR_DATE IS NULL THEN                          ");
            strSQL.Append(" (CASE WHEN C.HOLIDAY_FLAG = 1 THEN 0 ELSE (SELECT STD_WORKING_TIME FROM RESOURCE_MASTER WHERE RESOURCE_CD = @RESOURCE_CD) END ) ");
            strSQL.Append(" ELSE RC.WORKING_TIME END,                                                       ");
            strSQL.Append(" TIME_DESC = CASE WHEN RC.CALENDAR_DATE IS NULL THEN                             ");
            strSQL.Append(" (CASE WHEN C.HOLIDAY_FLAG = 1 THEN '' ELSE (SELECT TIME_DESC FROM RESOURCE_MASTER WHERE RESOURCE_CD = @RESOURCE_CD) END )       ");
            strSQL.Append(" ELSE RC.TIME_DESC END                                                           ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM CALENDAR_MASTER C                                                      ");
                strSQL.Append(" LEFT OUTER JOIN RESOURCE_CALENDAR RC ON RC.CALENDAR_DATE = C.CALENDAR_DATE  ");
                strSQL.Append(" AND RC.RESOURCE_CD = :RESOURCE_CD                                           ");
                strSQL.Append(" WHERE                                                                       ");
                strSQL.Append(" C.CALENDAR_ID = '00'                                                        ");
                strSQL.Append(" AND C.CALENDAR_DATE = :CALENDAR_DATE                                        ");

                db.DbPsetString("RESOURCE_CD", _resource_cd);
                db.DbPsetInt("CALENDAR_DATE", _calendar_date);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM CALENDAR_MASTER C                                                      ");
                strSQL.Append(" LEFT OUTER JOIN RESOURCE_CALENDAR RC ON RC.CALENDAR_DATE = C.CALENDAR_DATE  ");
                strSQL.Append(" AND RC.RESOURCE_CD = @RESOURCE_CD                                           ");
                strSQL.Append(" WHERE                                                                       ");
                strSQL.Append(" C.CALENDAR_ID = '00'                                                        ");
                strSQL.Append(" AND C.CALENDAR_CYM = @CALENDAR_DATE                                         ");

                db.DbPsetString("@RESOURCE_CD", _resource_cd);
                db.DbPsetInt("@CALENDAR_DATE", _calendar_date);
                strSQL.Append(" ORDER BY C.CALENDAR_DATE                                                    ");
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
        /// カレンダマスタ更新
        /// 
        /// 使用画面：MstResourceCalendarMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_CALENDAR_DATE", _calendar_date, ComConst.DB_IN);
            db.DbPsetInt("@I_WORKING_TIME", _working_time, ComConst.DB_IN);
            db.DbPsetString("@I_TIME_DESC", _time_desc, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_RESOURCE_CALENDAR_UDPATE");
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
