using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// 倉庫クラス
/// </summary>
namespace IMClass
{
    public class SPImport
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SPImport()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public SPImport(string p_user_id, int p_lang)
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
        protected int _year = 0;
        protected int _month = 0;
        protected int _version = 0;
        protected int _semi_fixed_first;
        protected int _semi_fixed_second;
        protected string _server_part_no = "";
        protected int _server_part_line = 0;
        protected string _part_no = "";
        protected string _model = "";
        protected int _order = 0;
        protected int _diff = 0;
        protected DateTime _delivery_plan_date;
        protected int _plan_qty = 0;


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
        public int year { get { return _year; } set { _year = value; } }
        public int month { get { return _month; } set { _month = value; } }
        public int version { get { return _version; } set { _version = value; } }
        public int semi_fixed_first { get { return _semi_fixed_first; } set { _semi_fixed_first = value; } }
        public int semi_fixed_second { get { return _semi_fixed_second; } set { _semi_fixed_second = value; } }
        public string server_part_no { get { return _server_part_no; } set { _server_part_no = value; } }
        public int server_part_line { get { return _server_part_line; } set { _server_part_line = value; } }
        public string part_no { get { return _part_no; } set { _part_no = value; } }
        public string model { get { return _model; } set { _model = value; } }
        public int order { get { return _order; } set { _order = value; } }
        public int diff { get { return _diff; } set { _diff = value; } }
        public DateTime delivery_plan_date { get { return _delivery_plan_date; } set { _delivery_plan_date = value; } }
        public int plan_qty { get { return _plan_qty; } set { _plan_qty = value; } }


        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }

        #endregion

        public int HeadInsert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;
            //rtnsp_prod_no = "";
            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@SERVICE_PART_NO", _server_part_no, ComConst.DB_IN);
            db.DbPsetInt("@YEAR", _year, ComConst.DB_IN);
            db.DbPsetInt("@MONTH", _month, ComConst.DB_IN);
            db.DbPsetInt("@VERSION", _version, ComConst.DB_IN);
            db.DbPsetString("@PART_NO", _part_no, ComConst.DB_IN);
            db.DbPsetInt("@SEMI_FIXED_FIRST", _semi_fixed_first, ComConst.DB_IN);
            db.DbPsetInt("@SEMI_FIXED_SECOND", _semi_fixed_second, ComConst.DB_IN);
            //db.DbPsetDate("@ENTRY_DATE", _entry_date, ComConst.DB_IN);
            //db.DbPsetDate("@UPDATE_DATE", _chg_date, ComConst.DB_IN);
            db.DbPsetString("@USER_CREATE", _chg_user_id, ComConst.DB_IN);
            //db.DbPsetString("@USER_UPDATE", _chg_user_id, ComConst.DB_IN);
            //db.DbPsetString("@rtnHEAD_NO", rtnsp_prod_no, ComConst.DB_OUT);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PLAN_PROD_SVC_HEADER_INSERT");
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
            //rtnsp_prod_no = db.DbPgetString("@rtnHEAD_NO");
            return rtn;
        }

        public int DetailInsert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;
            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@SERVICE_PART_NO", _server_part_no, ComConst.DB_IN);
            db.DbPsetInt("@SERVICE_PART_LINE", _server_part_line, ComConst.DB_IN);
            db.DbPsetString("@PART_NO", _part_no, ComConst.DB_IN);
            db.DbPsetString("@MODEL", _model, ComConst.DB_IN);
            db.DbPsetInt("@ORDER", _order, ComConst.DB_IN);
            db.DbPsetInt("@DIFF", _diff, ComConst.DB_IN);
            db.DbPsetDate("@DELIVERY_PLAN_DATE", _delivery_plan_date, ComConst.DB_IN);
            db.DbPsetInt("@PLAN_QTY", _plan_qty, ComConst.DB_IN);


            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PLAN_PROD_SVC_DETAIL_INSERT");
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

        public int HeadUpdate()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            //db.DbPsetString("@SERVICE_PART_NO", _server_part_no, ComConst.DB_IN);
            db.DbPsetInt("@YEAR", _year, ComConst.DB_IN);
            db.DbPsetInt("@MONTH", _month, ComConst.DB_IN);
            //db.DbPsetInt("@VERSION", _version, ComConst.DB_IN);
            //db.DbPsetInt("@SEMI_FIXED_FIRST", _semi_fixed_first, ComConst.DB_IN);
            //db.DbPsetInt("@SEMI_FIXED_SECOND", _semi_fixed_second, ComConst.DB_IN);
            //db.DbPsetDate("@ENTRY_DATE", _entry_date, ComConst.DB_IN);
            //db.DbPsetDate("@UPDATE_DATE", _chg_date, ComConst.DB_IN);
            //db.DbPsetString("@USER_CREATE", _chg_user_id, ComConst.DB_IN);
            //db.DbPsetString("@USER_UPDATE", _chg_user_id, ComConst.DB_IN);
            //db.DbPsetString("@rtnHEAD_NO", rtnsp_prod_no, ComConst.DB_OUT);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PLAN_PROD_SVC_HEADER_UPDATE");
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

        public int DetailUpdate()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;
            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@SERVICE_PART_NO", _server_part_no, ComConst.DB_IN);
            db.DbPsetInt("@SERVICE_PART_LINE", _server_part_line, ComConst.DB_IN);
            db.DbPsetString("@PART_NO", _part_no, ComConst.DB_IN);
            db.DbPsetString("@MODEL", _model, ComConst.DB_IN);
            db.DbPsetInt("@ORDER", _order, ComConst.DB_IN);
            db.DbPsetInt("@DIFF", _diff, ComConst.DB_IN);
            db.DbPsetDate("@DELIVERY_PLAN_DATE", _delivery_plan_date, ComConst.DB_IN);
            db.DbPsetInt("@PLAN_QTY", _plan_qty, ComConst.DB_IN);


            //db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            //db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            //db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            //db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            //db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PLAN_PROD_SVC_DETAIL_UPDATE");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                db.DbCommit();
            }
            else
            {
                //_errcode = db.DbPgetInt("@O_ERRCODE");
                //_errmsg = db.DbPgetString("@O_MSG");
                //_sqlcode = db.DbPgetInt("@O_SQLCODE");
                //_dbmsg = db.DbPgetString("@O_SQLMSG");
                //_proc_name = db.DbPgetString("@O_PROC_NAME");
                //_strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }
        public DataSet GetOrder(int syear, int smonth)
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                        ");
            strSQL.Append(" SERVICE_PART_NO AS HEAD_NO            ");
            strSQL.Append(" FROM PLAN_PROD_SVC_HEADER   ");
            strSQL.Append(" WHERE [YEAR] = " + syear + "   AND  [MONTH] = " + smonth);
            strSQL.Append(" ORDER BY HEAD_NO      ");

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
        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            if (_db_type == "ORACLE")
            {
                strSQL.Append("DELETE FROM PLAN_PROD_SVC_DETAIL ");
                strSQL.Append(" WHERE SERVICE_PART_NO = :SERVICE_PART_NO");

                db.DbParametersClear();
                db.DbPsetString("SERVICE_PART_NO", _server_part_no);
            }
            else
            {
                strSQL.Append("DELETE FROM PLAN_PROD_SVC_DETAIL ");
                strSQL.Append(" WHERE SERVICE_PART_NO = @SERVICE_PART_NO");

                db.DbParametersClear();
                db.DbPsetString("@SERVICE_PART_NO", _server_part_no);
            }


            db.DbBeginTrans();

            rtn = db.DbExecute(strSQL.ToString());
            if (rtn != ComConst.FAILED)
            {
                db.DbCommit();
            }
            else
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                db.DbRollback();
            }

            return rtn;
        }
    }
}
