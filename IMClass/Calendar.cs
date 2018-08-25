using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;
/// <summary>
/// Calendarクラス
/// </summary>
namespace IMClass
{
    public class Calendar
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Calendar()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Calendar(string p_user_id, int p_lang)
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
        protected string _calendar_id = "00";
        protected int _calendar_date = 0;
        protected int _calendar_cym = 0;
        protected int _week_no = 0;
        protected int _day_of_week = 0;
        protected int _holiday_flag = 0;
        protected int _po_rls_flag = 0;
        protected int _ttl_work_days = 0;
        protected int _ttl_days = 0;
        protected int _ttl_week = 0;
        protected Double _std_working_hour = 0;
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
        //add 2008/11/13
        protected int _add_no = 0;
        protected int _date_type = 0;
        protected int _calendar_cym_end = 0;
        //20090203
        protected int _from_ttl_work_days = 0;
        protected int _to_ttl_work_days = 0;

        protected string _user_group = "";
        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        public int lang { get { return _lang; } set { _lang = value; } }
        public string calendar_id { get { return _calendar_id; } set { _calendar_id = value; } }
        public int calendar_date { get { return _calendar_date; } set { _calendar_date = value; } }
        public int calendar_cym { get { return _calendar_cym; } set { _calendar_cym = value; } }
        public int week_no { get { return _week_no; } set { _week_no = value; } }
        public int day_of_week { get { return _day_of_week; } set { _day_of_week = value; } }
        public int holiday_flag { get { return _holiday_flag; } set { _holiday_flag = value; } }
        public int po_rls_flag { get { return _po_rls_flag; } set { _po_rls_flag = value; } }
        public int ttl_work_days { get { return _ttl_work_days; } set { _ttl_work_days = value; } }
        public int ttl_days { get { return _ttl_days; } set { _ttl_days = value; } }
        public int ttl_week { get { return _ttl_week; } set { _ttl_week = value; } }
        public Double std_working_hour { get { return _std_working_hour; } set { _std_working_hour = value; } }
        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }

        public int add_no { get { return _add_no; } set { _add_no = value; } }
        public int date_type { get { return _date_type; } set { _date_type = value; } }
        public int calendar_cym_end { get { return _calendar_cym_end; } set { _calendar_cym_end = value; } }

        public int from_ttl_work_days { get { return _from_ttl_work_days; } set { _from_ttl_work_days = value; } }
        public int to_ttl_work_days { get { return _to_ttl_work_days; } set { _to_ttl_work_days = value; } }

        public string user_group { get { return _user_group; } set { _user_group = value; } }
        #endregion

        /// <summary>
        /// Calendarの追加&更新
        /// 使用画面：MstCalendarMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_CALENDAR_ID", _calendar_id, ComConst.DB_IN);
            db.DbPsetInt("@I_CALENDAR_DATE", _calendar_date, ComConst.DB_IN);
            //db.DbPsetInt("@I_CALENDAR_CYM", _calendar_cym, ComConst.DB_IN);
            //db.DbPsetInt("@I_WEEK_NO", _week_no, ComConst.DB_IN);
            //db.DbPsetInt("@I_DAY_OF_WEEK", _day_of_week, ComConst.DB_IN);
            db.DbPsetInt("@I_HOLIDAY_FLAG", _holiday_flag, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_RLS_FLAG", _po_rls_flag, ComConst.DB_IN);
            //db.DbPsetInt("@I_TTL_WORK_DAYS", _ttl_work_days, ComConst.DB_IN);
            //db.DbPsetInt("@I_TTL_DAYS", _ttl_days, ComConst.DB_IN);
            //db.DbPsetInt("@I_TTL_WEEK", _ttl_week, ComConst.DB_IN);
            db.DbPsetDouble("@I_STD_WORKING_HOUR", _std_working_hour, ComConst.DB_IN);
            db.DbPsetString("@I_USER_GROUP", _user_group, ComConst.DB_IN);    // HTS
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USERID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);
            //db.DbConnection ();          
            db.DbBeginTrans();
            rtn = db.DbStored("SP_CALENDAR_UPDATE");
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
            db.DbClose();
            return rtn;
        }
        /// <summary>
        /// Calendarの通算稼働日更新 
        /// 使用画面：MstCalendarMnt
        /// </summary>
        public int Work_Days_Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_CALENDAR_ID", _calendar_id, ComConst.DB_IN);
            db.DbPsetInt("@I_CALENDAR_DATE", _calendar_date, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USERID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);
            //db.DbConnection ();          
            db.DbBeginTrans();
            rtn = db.DbStored("SP_CALENDAR_TTL_WORK_DAYS_UPDATE");
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
            db.DbClose();
            return rtn;
        }
        /// <summary>
        /// Calendar詳細の取得Month
        /// 
        /// 使用画面：MstCalendarMnt
        /// </summary>
        public DataSet GetCalendarMonthlyDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            //strSQL.Append("SELECT ");
            //strSQL.Append("CALENDAR_DATE,   CALENDAR_CYM,   WEEK_NO,		DAY_OF_WEEK, ");
            //strSQL.Append("HOLIDAY_FLAG,    PO_RLS_FLAG,    TTL_WORK_DAYS,  CALENDAR_ID,");
            //strSQL.Append("TTL_DAYS,        TTL_WEEK,       STD_WORKING_HOUR, ");
            //strSQL.Append("CHG_PGM,         CHG_USERID,     UPDATE_CNTR ");
            strSQL.Append("SELECT ");
            strSQL.Append("CALENDAR_DATE,   CALENDAR_CYM,   WEEK_NO,		DAY_OF_WEEK, ");
            strSQL.Append("HOLIDAY_FLAG,    PROCESS_FLAG,   TTL_WORK_DAYS,  CALENDAR_ID, ");
            strSQL.Append("TTL_DAYS,        TTL_WEEK,       STD_WORKING,    USER_GROUP_CODE, ");
            strSQL.Append("ENTRY_DATE,      UPDATE_DATE,    USER_CREATE,    USER_UPDATE ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM CALENDAR_MASTER ");
                strSQL.Append(" WHERE CALENDAR_ID   = :CALENDAR_ID");
                strSQL.Append("   AND CALENDAR_CYM  = :CALENDAR_CYM");
                strSQL.Append(" ORDER BY CALENDAR_DATE ");

                db.DbParametersClear();
                db.DbPsetString("CALENDAR_ID", _calendar_id);
                db.DbPsetInt("CALENDAR_CYM", _calendar_cym);
            }
            else
            {
                strSQL.Append(" FROM CALENDAR_MASTER ");
                strSQL.Append(" WHERE CALENDAR_ID = @CALENDAR_ID");
                strSQL.Append(" AND CALENDAR_CYM = @CALENDAR_CYM");
                strSQL.Append(" ORDER BY CALENDAR_DATE ");

                db.DbParametersClear();
                db.DbPsetString("@CALENDAR_ID", _calendar_id);
                db.DbPsetInt("@CALENDAR_CYM", _calendar_cym);
            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "Tabel");
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
        /// Calendar詳細の取得Date
        /// 
        /// 使用画面：PurManPOPlanRpt
        /// </summary>
        public int GetCalendarDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("CALENDAR_DATE,   CALENDAR_CYM,   WEEK_NO,		DAY_OF_WEEK, ");
            strSQL.Append("HOLIDAY_FLAG,    PO_RLS_FLAG,    TTL_WORK_DAYS,  CALENDAR_ID,");
            strSQL.Append("TTL_DAYS,        TTL_WEEK,       STD_WORKING_HOUR, ");
            strSQL.Append("CHG_PGM,         CHG_USERID,     UPDATE_CNTR ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM CALENDAR_MASTER ");
                strSQL.Append(" WHERE CALENDAR_ID   = :CALENDAR_ID");
                strSQL.Append("   AND CALENDAR_DATE  = :CALENDAR_DATE");
                strSQL.Append(" ORDER BY CALENDAR_DATE ");

                db.DbParametersClear();
                db.DbPsetString("CALENDAR_ID", _calendar_id);
                db.DbPsetInt("CALENDAR_DATE", _calendar_date);
            }
            else
            {
                strSQL.Append(" FROM CALENDAR_MASTER ");
                strSQL.Append(" WHERE CALENDAR_ID = @CALENDAR_ID");
                strSQL.Append(" AND CALENDAR_DATE = @CALENDAR_DATE");
                strSQL.Append(" ORDER BY CALENDAR_DATE ");

                db.DbParametersClear();
                db.DbPsetString("@CALENDAR_ID", _calendar_id);
                db.DbPsetInt("@CALENDAR_DATE", _calendar_date);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _calendar_date = int.Parse(db.Row("CALENDAR_DATE"));
                _calendar_cym = int.Parse(db.Row("CALENDAR_CYM"));
                _week_no = int.Parse(db.Row("WEEK_NO"));
                _day_of_week = int.Parse(db.Row("DAY_OF_WEEK"));
                _holiday_flag = int.Parse(db.Row("HOLIDAY_FLAG"));
                _po_rls_flag = int.Parse(db.Row("PO_RLS_FLAG"));
                _ttl_work_days = int.Parse(db.Row("TTL_WORK_DAYS"));
                _ttl_days = int.Parse(db.Row("TTL_DAYS"));
                _ttl_week = int.Parse(db.Row("TTL_WEEK"));
                _std_working_hour = double.Parse(db.Row("STD_WORKING_HOUR"));
                _chg_pgm = db.Row("CHG_PGM");
                _update_cntr = int.Parse(db.Row("UPDATE_CNTR"));
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// input DATE and Week Add NO
        /// OUTPUT Month and Week no
        /// 使用画面：PurManPOPlanRpt
        /// </summary>
        public DataSet GetWeekOfMonth()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT DISTINCT                ");
            strSQL.Append("CALENDAR_CYM,    TTL_WEEK      ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM CALENDAR_MASTER                                    ");
                strSQL.Append(" WHERE TTL_WEEK = (select TTL_WEEK FROM CALENDAR_MASTER  ");
                strSQL.Append(" WHERE CALENDAR_ID   = :CALENDAR_ID                      ");
                strSQL.Append("   AND CALENDAR_DATE  = :CALENDAR_DATE ) + :ADD_NO       ");
                strSQL.Append(" AND CALENDAR_ID   = :CALENDAR_ID ");
                db.DbParametersClear();
                db.DbPsetString("CALENDAR_ID", _calendar_id);
                db.DbPsetInt("CALENDAR_DATE", _calendar_date);
                db.DbPsetInt("ADD_NO", _add_no);
            }
            else
            {
                strSQL.Append(" FROM CALENDAR_MASTER                                    ");
                strSQL.Append(" WHERE TTL_WEEK = (select TTL_WEEK FROM CALENDAR_MASTER  ");
                strSQL.Append(" WHERE CALENDAR_ID   = @CALENDAR_ID                      ");
                strSQL.Append("   AND CALENDAR_DATE  = @CALENDAR_DATE ) + @ADD_NO       ");
                strSQL.Append(" AND CALENDAR_ID   = @CALENDAR_ID                            ");
                db.DbParametersClear();
                db.DbPsetString("@CALENDAR_ID", _calendar_id);
                db.DbPsetInt("@CALENDAR_DATE", _calendar_date);
                db.DbPsetInt("@ADD_NO", _add_no);
            }
            strSQL.Append(" ORDER BY CALENDAR_CYM ");

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "Tabel");
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
        /// 使用画面：PurManPOPlanRpt
        /// </summary>
        public DataSet GetDayOfWeek()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT DISTINCT                ");
            strSQL.Append("CALENDAR_CYM,  DAY_OF_WEEK,    TTL_WEEK      ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM CALENDAR_MASTER                                    ");
                strSQL.Append(" WHERE  CALENDAR_ID   = :CALENDAR_ID                     ");
                strSQL.Append(" AND CALENDAR_DATE  = :CALENDAR_DATE                     ");
                db.DbParametersClear();
                db.DbPsetString("CALENDAR_ID", _calendar_id);
                db.DbPsetInt("CALENDAR_DATE", _calendar_date);
            }
            else
            {
                strSQL.Append(" FROM CALENDAR_MASTER                                    ");
                strSQL.Append(" WHERE  CALENDAR_ID   = @CALENDAR_ID                     ");
                strSQL.Append(" AND CALENDAR_DATE  = @CALENDAR_DATE                     ");
                db.DbParametersClear();
                db.DbPsetString("@CALENDAR_ID", _calendar_id);
                db.DbPsetInt("@CALENDAR_DATE", _calendar_date);
            }
            strSQL.Append(" ORDER BY CALENDAR_CYM ");

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "Tabel");
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
        /// input Week or Month 
        /// OUTPUT NEXT 8 Month and Week no
        /// 使用画面：PurManPOPlanRpt
        /// </summary>
        public DataSet GetWeekOFNext()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            if (date_type == 0)
            {
                strSQL.Append("SELECT  DISTINCT                                                                          ");
                strSQL.Append("TTL_WEEK , min(CALENDAR_DATE) MIN_DATE,  max(CALENDAR_DATE) MAX_DATE                      ");
            }
            else
            {
                strSQL.Append("SELECT  DISTINCT                                                                          ");
                strSQL.Append("CALENDAR_CYM , min(CALENDAR_DATE) MIN_DATE,  max(CALENDAR_DATE) MAX_DATE                  ");
            }
            if (_db_type == "ORACLE")
            {
                if (date_type == 0)
                {
                    strSQL.Append(" FROM CALENDAR_MASTER  ");
                    strSQL.Append(" WHERE TTL_WEEK >= :TTL_WEEK  AND TTL_WEEK <= :TTL_WEEK + 7              ");
                    strSQL.Append(" AND   CALENDAR_ID = @CALENDAR_ID                                        ");
                    strSQL.Append(" GROUP BY   TTL_WEEK                                                     ");
                    db.DbParametersClear();
                    db.DbPsetString("CALENDAR_ID", _calendar_id);
                    db.DbPsetInt("TTL_WEEK", _ttl_week);
                }
                else
                {
                    strSQL.Append(" FROM CALENDAR_MASTER  ");
                    strSQL.Append(" WHERE CALENDAR_DATE >= :CALENDAR_DATE  AND CALENDAR_DATE <= :CALENDAR_CYM_END ");
                    strSQL.Append(" AND   CALENDAR_ID = @CALENDAR_ID                                           ");
                    strSQL.Append(" GROUP BY   CALENDAR_CYM                                                    ");
                    db.DbParametersClear();
                    db.DbPsetString("CALENDAR_ID", _calendar_id);
                    db.DbPsetInt("CALENDAR_CYM", _calendar_cym);
                }
            }
            else
            {
                if (date_type == 0)
                {
                    strSQL.Append(" FROM CALENDAR_MASTER                                                                    ");
                    strSQL.Append(" WHERE TTL_WEEK >= @TTL_WEEK AND TTL_WEEK <= @TTL_WEEK + 7 AND CALENDAR_ID = @CALENDAR_ID  ");
                    strSQL.Append(" GROUP BY TTL_WEEK                                                                       ");
                    db.DbParametersClear();
                    db.DbPsetString("@CALENDAR_ID", _calendar_id);
                    db.DbPsetInt("@TTL_WEEK", _ttl_week);
                }
                else
                {
                    strSQL.Append(" FROM CALENDAR_MASTER                                                                             ");
                    strSQL.Append(" WHERE CALENDAR_DATE >= @CALENDAR_DATE  AND CALENDAR_DATE <=                                      ");
                    strSQL.Append(" CONVERT(VARCHAR(8), DATEADD(DAY,-1,(DATEADD(MONTH,8,CONVERT(DATETIME,CONVERT(VARCHAR(8),@CALENDAR_DATE))))), 112)  ");//UPD BY UBIQ-LIU 2010/09/03
                    strSQL.Append(" AND   CALENDAR_ID = @CALENDAR_ID                                                                 ");
                    strSQL.Append(" GROUP BY CALENDAR_CYM                                                                       ");
                    db.DbParametersClear();
                    db.DbPsetString("@CALENDAR_ID", _calendar_id);
                    db.DbPsetInt("@CALENDAR_DATE", _calendar_date);
                }
            }
            //strSQL.Append(" ORDER BY CALENDAR_CYM ");
            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "Tabel");
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
        /// input Week or Month and range
        /// OUTPUT NEXT range Month and Week no
        /// 使用画面：PurManPOPlanRpt
        /// </summary>
        public DataSet GetWeekOFNext(int range)
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            if (date_type == 0)
            {
                strSQL.Append("SELECT  DISTINCT                                                                          ");
                strSQL.Append("TTL_WEEK , min(CALENDAR_DATE) MIN_DATE,  max(CALENDAR_DATE) MAX_DATE                      ");
            }
            else
            {
                strSQL.Append("SELECT  DISTINCT                                                                          ");
                strSQL.Append("CALENDAR_CYM , min(CALENDAR_DATE) MIN_DATE,  max(CALENDAR_DATE) MAX_DATE                  ");
            }
            if (_db_type == "ORACLE")
            {
                if (date_type == 0)
                {
                    strSQL.Append(" FROM CALENDAR_MASTER  ");
                    strSQL.Append(" WHERE TTL_WEEK >= :TTL_WEEK  AND TTL_WEEK <= :TTL_WEEK + :RANGE - 1     ");
                    strSQL.Append(" AND   CALENDAR_ID = @CALENDAR_ID                                        ");
                    strSQL.Append(" GROUP BY   TTL_WEEK                                                     ");
                    db.DbParametersClear();
                    db.DbPsetInt("RANGE", range);
                    db.DbPsetString("CALENDAR_ID", _calendar_id);
                    db.DbPsetInt("TTL_WEEK", _ttl_week);
                }
                else
                {
                    strSQL.Append(" FROM CALENDAR_MASTER  ");
                    strSQL.Append(" WHERE CALENDAR_DATE >= :CALENDAR_DATE  AND CALENDAR_DATE <= :CALENDAR_CYM_END ");
                    strSQL.Append(" AND   CALENDAR_ID = @CALENDAR_ID                                           ");
                    strSQL.Append(" GROUP BY   CALENDAR_CYM                                                    ");
                    db.DbParametersClear();
                    db.DbPsetString("CALENDAR_ID", _calendar_id);
                    db.DbPsetInt("CALENDAR_CYM", _calendar_cym);
                }
            }
            else
            {
                if (date_type == 0)
                {
                    strSQL.Append(" FROM CALENDAR_MASTER                                                                    ");
                    strSQL.Append(" WHERE TTL_WEEK >= @TTL_WEEK AND TTL_WEEK <= @TTL_WEEK + @RANGE - 1 AND CALENDAR_ID = @CALENDAR_ID  ");
                    strSQL.Append(" GROUP BY TTL_WEEK                                                                       ");
                    db.DbParametersClear();
                    db.DbPsetString("@CALENDAR_ID", _calendar_id);
                    db.DbPsetInt("@TTL_WEEK", _ttl_week);
                    db.DbPsetInt("@RANGE", range);
                }
                else
                {
                    strSQL.Append(" FROM CALENDAR_MASTER                                                                             ");
                    strSQL.Append(" WHERE CALENDAR_DATE >= @CALENDAR_DATE  AND CALENDAR_DATE <=                                      ");
                    strSQL.Append(" CONVERT(VARCHAR(8), DATEADD(DAY,-1,(DATEADD(MONTH,@RANGE,CONVERT(DATETIME,CONVERT(VARCHAR(8),@CALENDAR_DATE))))), 112)  ");
                    strSQL.Append(" AND   CALENDAR_ID = @CALENDAR_ID                                                                 ");
                    strSQL.Append(" GROUP BY CALENDAR_CYM                                                                       ");
                    db.DbParametersClear();
                    db.DbPsetString("@CALENDAR_ID", _calendar_id);
                    db.DbPsetInt("@CALENDAR_DATE", _calendar_date);
                    db.DbPsetInt("@RANGE", range);
                }
            }
            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "Tabel");
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
        /// 稼働日Calendar詳細の取得
        /// 
        /// 使用画面：PlanProdPlan
        /// </summary>
        public DataSet GetWeekDayCalendarList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("CALENDAR_DATE,   CALENDAR_CYM,   WEEK_NO,		DAY_OF_WEEK, ");
            strSQL.Append("HOLIDAY_FLAG,    PO_RLS_FLAG,    TTL_WORK_DAYS,  CALENDAR_ID,");
            strSQL.Append("TTL_DAYS,        TTL_WEEK,       STD_WORKING_HOUR, ");
            strSQL.Append("CHG_PGM,         CHG_USERID,     UPDATE_CNTR ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM CALENDAR_MASTER ");
                strSQL.Append(" WHERE CALENDAR_ID   = :CALENDAR_ID");
                strSQL.Append("   AND CALENDAR_CYM  = :CALENDAR_CYM");
                strSQL.Append(" ORDER BY CALENDAR_DATE ");

                db.DbParametersClear();
                db.DbPsetString("CALENDAR_ID", _calendar_id);
                db.DbPsetInt("CALENDAR_CYM", _calendar_cym);
            }
            else
            {
                strSQL.Append(" FROM CALENDAR_MASTER ");
                strSQL.Append(" WHERE CALENDAR_ID = @CALENDAR_ID");
                strSQL.Append("   AND HOLIDAY_FLAG = 0");
                strSQL.Append("   AND CALENDAR_DATE BETWEEN @FROM_TTL_WORK_DAYS AND @TO_TTL_WORK_DAYS");
                strSQL.Append(" ORDER BY CALENDAR_DATE ");

                db.DbParametersClear();
                db.DbPsetString("@CALENDAR_ID", _calendar_id);
                db.DbPsetInt("@FROM_TTL_WORK_DAYS", _from_ttl_work_days);
                db.DbPsetInt("@TO_TTL_WORK_DAYS", _to_ttl_work_days);
            }

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
        /// 棚卸結果登録Calendar詳細の取得
        /// 
        /// 使用画面：InvStockTakingAct
        /// </summary>
        public DataSet GetCalendarYearMonth()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                              ");
            strSQL.Append(" DISTINCT(SUBSTRING(CONVERT(VARCHAR(6),CALENDAR_CYM),1,4) )  AS CALENDAR_CYM         ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM CALENDAR_MASTER       ");
                strSQL.Append(" WHERE CALENDAR_ID   = :00  ");
                strSQL.Append(" ORDER BY CALENDAR_CYM      ");
            }
            else
            {
                strSQL.Append(" FROM CALENDAR_MASTER      ");
                strSQL.Append(" WHERE CALENDAR_ID ='00'   ");
                strSQL.Append(" ORDER BY CALENDAR_CYM     ");
            }
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
        /// 指定日期或星期数
        /// 用于マニュアル発注計画表week变化
        /// </summary>
        /// <param name="flag">0:TTL_WEEK;1:CALENDAR_DATE</param>
        /// <returns></returns>
        public int GetMonthWeek(int flag)
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            db.DbParametersClear();
            //--- sql
            strSQL.Append("SELECT                                                           ");
            strSQL.Append("CALENDAR_DATE,   CALENDAR_CYM,   WEEK_NO,		DAY_OF_WEEK,    ");
            strSQL.Append("HOLIDAY_FLAG,    PO_RLS_FLAG,    TTL_WORK_DAYS,  CALENDAR_ID,    ");
            strSQL.Append("TTL_DAYS,        TTL_WEEK,       STD_WORKING_HOUR,               ");
            strSQL.Append("CHG_PGM,         CHG_USERID,     UPDATE_CNTR                     ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM CALENDAR_MASTER                    ");
                strSQL.Append(" WHERE CALENDAR_ID   = :CALENDAR_ID      ");
                if (flag == 0)
                {
                    strSQL.Append(" AND TTL_WEEK = :TTL_WEEK                ");
                    db.DbPsetInt("TTL_WEEK", _ttl_week);
                }
                else
                {
                    strSQL.Append(" AND TTL_WEEK = (SELECT TTL_WEEK FROM CALENDAR_MASTER            ");
                    strSQL.Append(" WHERE CALENDAR_ID=:CALENDAR_ID AND CALENDAR_DATE=:CALENDAR_DATE)");
                    db.DbPsetInt("CALENDAR_DATE", _calendar_date);
                }
                strSQL.Append(" AND DAY_OF_WEEK = :DAY_OF_WEEK          ");
                strSQL.Append(" ORDER BY CALENDAR_DATE                  ");

                db.DbParametersClear();
                db.DbPsetString("CALENDAR_ID", _calendar_id);
                db.DbPsetInt("DAY_OF_WEEK", _day_of_week);
            }
            else
            {
                strSQL.Append(" FROM CALENDAR_MASTER                    ");
                strSQL.Append(" WHERE CALENDAR_ID = @CALENDAR_ID        ");
                if (flag == 0)
                {
                    strSQL.Append(" AND TTL_WEEK = @TTL_WEEK                ");
                    db.DbPsetInt("@TTL_WEEK", _ttl_week);
                }
                else if (flag == 1)
                {
                    strSQL.Append(" AND TTL_WEEK = (SELECT TTL_WEEK FROM CALENDAR_MASTER            ");
                    strSQL.Append(" WHERE CALENDAR_ID=@CALENDAR_ID AND CALENDAR_DATE=@CALENDAR_DATE)");
                    db.DbPsetInt("@CALENDAR_DATE", _calendar_date);
                }
                strSQL.Append(" AND DAY_OF_WEEK = @DAY_OF_WEEK          ");
                strSQL.Append(" ORDER BY CALENDAR_DATE                  ");

                db.DbPsetString("@CALENDAR_ID", _calendar_id);
                db.DbPsetInt("@DAY_OF_WEEK", _day_of_week);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _calendar_date = int.Parse(db.Row("CALENDAR_DATE"));
                _calendar_cym = int.Parse(db.Row("CALENDAR_CYM"));
                _week_no = int.Parse(db.Row("WEEK_NO"));
                _day_of_week = int.Parse(db.Row("DAY_OF_WEEK"));
                _holiday_flag = int.Parse(db.Row("HOLIDAY_FLAG"));
                _po_rls_flag = int.Parse(db.Row("PO_RLS_FLAG"));
                _ttl_work_days = int.Parse(db.Row("TTL_WORK_DAYS"));
                _ttl_days = int.Parse(db.Row("TTL_DAYS"));
                _ttl_week = int.Parse(db.Row("TTL_WEEK"));
                _std_working_hour = double.Parse(db.Row("STD_WORKING_HOUR"));
                _chg_pgm = db.Row("CHG_PGM");
                _update_cntr = int.Parse(db.Row("UPDATE_CNTR"));
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }
        /// <summary>
        /// 获取某月第一周的TTL_WEEK
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public int GetMonthFirstWeek()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            db.DbParametersClear();
            //--- sql
            strSQL.Append("SELECT                                                           ");
            strSQL.Append("CALENDAR_DATE,   CALENDAR_CYM,   WEEK_NO,		DAY_OF_WEEK,    ");
            strSQL.Append("HOLIDAY_FLAG,    PO_RLS_FLAG,    TTL_WORK_DAYS,  CALENDAR_ID,    ");
            strSQL.Append("TTL_DAYS,        TTL_WEEK,       STD_WORKING_HOUR,               ");
            strSQL.Append("CHG_PGM,         CHG_USERID,     UPDATE_CNTR                     ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM CALENDAR_MASTER                                                ");
                strSQL.Append(" WHERE CALENDAR_ID = :CALENDAR_ID                                    ");
                strSQL.Append(" AND CALENDAR_DATE = (SELECT MIN(CALENDAR_DATE) FROM CALENDAR_MASTER ");
                strSQL.Append(" WHERE CALENDAR_ID = :CALENDAR_ID AND DAY_OF_WEEK = :DAY_OF_WEEK     ");
                strSQL.Append(" AND CALENDAR_CYM = :CALENDAR_CYM)                                   ");

                db.DbParametersClear();
                db.DbPsetString("CALENDAR_ID", _calendar_id);
                db.DbPsetInt("DAY_OF_WEEK", _day_of_week);
                db.DbPsetInt("CALENDAR_CYM", _calendar_cym);
            }
            else
            {
                strSQL.Append(" FROM CALENDAR_MASTER                                                ");
                strSQL.Append(" WHERE CALENDAR_ID = @CALENDAR_ID                                    ");
                strSQL.Append(" AND CALENDAR_DATE = (SELECT MIN(CALENDAR_DATE) FROM CALENDAR_MASTER ");
                strSQL.Append(" WHERE CALENDAR_ID = @CALENDAR_ID AND DAY_OF_WEEK = @DAY_OF_WEEK     ");
                strSQL.Append(" AND CALENDAR_CYM = @CALENDAR_CYM)                                   ");

                db.DbPsetString("@CALENDAR_ID", _calendar_id);
                db.DbPsetInt("@DAY_OF_WEEK", _day_of_week);
                db.DbPsetInt("@CALENDAR_CYM", _calendar_cym);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _calendar_date = int.Parse(db.Row("CALENDAR_DATE"));
                _calendar_cym = int.Parse(db.Row("CALENDAR_CYM"));
                _week_no = int.Parse(db.Row("WEEK_NO"));
                _day_of_week = int.Parse(db.Row("DAY_OF_WEEK"));
                _holiday_flag = int.Parse(db.Row("HOLIDAY_FLAG"));
                _po_rls_flag = int.Parse(db.Row("PO_RLS_FLAG"));
                _ttl_work_days = int.Parse(db.Row("TTL_WORK_DAYS"));
                _ttl_days = int.Parse(db.Row("TTL_DAYS"));
                _ttl_week = int.Parse(db.Row("TTL_WEEK"));
                _std_working_hour = double.Parse(db.Row("STD_WORKING_HOUR"));
                _chg_pgm = db.Row("CHG_PGM");
                _update_cntr = int.Parse(db.Row("UPDATE_CNTR"));
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }


        //--> ADD BY UBIQ-SUO 2010/9/17
        /// <summary>
        /// 获取系统日期以后最开始的歴日
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public int GetMinCalendardate()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;
            db.DbParametersClear();
            //--- sql
            strSQL.Append("SELECT                                                           ");
            strSQL.Append("MIN(CALENDAR_DATE)  CALENDAR_DATE   FROM CALENDAR_MASTER         ");           

            if (_db_type == "ORACLE")
            {
                strSQL.Append("WHERE CALENDAR_DATE > TO_CHAR(SYSDATE,'YYYYMMDD')                ");
                strSQL.Append("AND PO_RLS_FLAG = 1                                              ");
            }
            else
            {
                strSQL.Append("WHERE CALENDAR_DATE > CONVERT(VARCHAR(30),GETDATE(),112)         ");
                strSQL.Append("AND PO_RLS_FLAG = 1        ");
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _calendar_date = int.Parse(db.Row("CALENDAR_DATE"));               
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }
        //<-- ADD BY UBIQ-SUO 2010/9/17
    }
}
