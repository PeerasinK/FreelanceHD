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
    public class FEImport
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FEImport()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public FEImport(string p_user_id, int p_lang)
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
        protected string _part_no = "";
        protected string _remark = "";
        protected string _fe_prod_no = "";
        protected int _fe_line_no = 0;
        protected string _type_part = "";
        protected DateTime _production_plan_date;
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
        public string part_no { get { return _part_no; } set { _part_no = value; } }
        public string remark { get { return _remark; } set { _remark = value; } }
        public string fe_prod_no { get { return _fe_prod_no; } set { _fe_prod_no = value; } }
        public int fe_line_no { get { return _fe_line_no; } set { _fe_line_no = value; } }
        public string type_part { get { return _type_part; } set { _type_part = value; } }
        public DateTime production_plan_date { get { return _production_plan_date; } set { _production_plan_date = value; } }
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
            //rtnfe_prod_no = "";
            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@FE_PROD_NO", _fe_prod_no, ComConst.DB_IN);
            db.DbPsetInt("@YEAR", _year, ComConst.DB_IN);
            db.DbPsetInt("@MONTH", _month, ComConst.DB_IN);
            db.DbPsetInt("@VERSION", _version, ComConst.DB_IN);
            db.DbPsetString("@PART_NO", _part_no, ComConst.DB_IN);
            db.DbPsetString("@REMARK", _remark, ComConst.DB_IN);
            //db.DbPsetDate("@ENTRY_DATE", _entry_date, ComConst.DB_IN);
            //db.DbPsetDate("@UPDATE_DATE", _chg_date, ComConst.DB_IN);
            db.DbPsetString("@USER_CREATE", _chg_user_id, ComConst.DB_IN);
            //db.DbPsetString("@USER_UPDATE", _chg_user_id, ComConst.DB_IN);
            //db.DbPsetString("@rtnHEAD_NO", rtnfe_prod_no, ComConst.DB_OUT);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PLAN_PROD_FE_HEADER_INSERT");
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
            //rtnfe_prod_no=db.DbPgetString("@rtnHEAD_NO");
            return rtn;
        }

        public int DetailInsert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;
            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@FE_PROD_NO", _fe_prod_no, ComConst.DB_IN);
            db.DbPsetInt("@FE_LINE_NO", _fe_line_no, ComConst.DB_IN);
            db.DbPsetString("@PART_NO", _part_no, ComConst.DB_IN);
            //db.DbPsetString("@TYPE_PART", _type_part, ComConst.DB_IN);
            db.DbPsetDate("@PRODUCTION_PLAN_DATE", _production_plan_date, ComConst.DB_IN);
            db.DbPsetInt("@PLAN_QTY", _plan_qty, ComConst.DB_IN);


            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PLAN_PROD_FE_DETAIL_INSERT");
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
            //db.DbPsetString("@FE_PROD_NO", _fe_prod_no, ComConst.DB_IN);
            db.DbPsetInt("@YEAR", _year, ComConst.DB_IN);
            db.DbPsetInt("@MONTH", _month, ComConst.DB_IN);
            //db.DbPsetInt("@VERSION", _version, ComConst.DB_IN);
            //db.DbPsetString("@PART_NO", _part_no, ComConst.DB_IN);
            //db.DbPsetString("@REMARK", _remark, ComConst.DB_IN);
            ////db.DbPsetDate("@ENTRY_DATE", _entry_date, ComConst.DB_IN);
            //db.DbPsetDate("@UPDATE_DATE", _chg_date, ComConst.DB_IN);
            //db.DbPsetString("@USER_CREATE", _chg_user_id, ComConst.DB_IN);
            db.DbPsetString("@USER_UPDATE", _chg_user_id, ComConst.DB_IN);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PLAN_PROD_FE_HEADER_UPDATE");
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
            db.DbPsetString("@FE_PROD_NO", _fe_prod_no, ComConst.DB_IN);
            db.DbPsetInt("@FE_LINE_NO", _fe_line_no, ComConst.DB_IN);
            db.DbPsetString("@PART_NO", _part_no, ComConst.DB_IN);
            db.DbPsetString("@TYPE_PART", _type_part, ComConst.DB_IN);
            db.DbPsetDate("@PRODUCTION_PLAN_DATE", _production_plan_date, ComConst.DB_IN);
            db.DbPsetInt("@PLAN_QTY", _plan_qty, ComConst.DB_IN);


            //db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            //db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            //db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            //db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            //db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PLAN_PROD_FE_DETAIL_UPDATE");
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
            strSQL.Append(" FE_PROD_NO AS HEAD_NO            ");
            strSQL.Append(" FROM PLAN_PROD_FE_HEADER   ");
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
                strSQL.Append("DELETE FROM PLAN_PROD_FE_DETAIL ");
                strSQL.Append(" WHERE FE_PROD_NO = :FE_PROD_NO");

                db.DbParametersClear();
                db.DbPsetString("FE_PROD_NO", _fe_prod_no);
            }
            else
            {
                strSQL.Append("DELETE FROM PLAN_PROD_FE_DETAIL ");
                strSQL.Append(" WHERE FE_PROD_NO = @FE_PROD_NO");

                db.DbParametersClear();
                db.DbPsetString("@FE_PROD_NO", _fe_prod_no);
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
