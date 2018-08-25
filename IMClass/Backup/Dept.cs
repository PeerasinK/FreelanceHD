using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Data;


namespace IMClass
{
    public class Dept
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Dept()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Dept(string p_user_id, int p_lang)
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
        protected string _dept_cd = "";
        protected string _dept_desc = "";
        protected string _dept_desc1 = "";
        protected string _dept_desc2 = "";
        protected string _dept_desc3 = "";
        protected string _dept_desc4 = "";
        protected int    _dept_type = -1;
        protected double _number_dept = 0;
        protected double _area_dept = 0;

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
        public string dept_cd { get { return _dept_cd; } set { _dept_cd = value; } }
        public string dept_desc { get { return _dept_desc; } set { _dept_desc = value; } }
        public string dept_desc1 { get { return _dept_desc1; } set { _dept_desc1 = value; } }
        public string dept_desc2 { get { return _dept_desc2; } set { _dept_desc2 = value; } }
        public string dept_desc3 { get { return _dept_desc3; } set { _dept_desc3 = value; } }
        public string dept_desc4 { get { return _dept_desc4; } set { _dept_desc4 = value; } }
        public int dept_type { get { return _dept_type; } set { _dept_type = value; } }
        public double number_dept { get { return _number_dept; } set { _number_dept = value; } }
        public double area_dept { get { return _area_dept; } set { _area_dept = value; } }

        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string errmsg { get { return _errmsg; } set { _errmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }
        public int errcode { get { return _errcode; } set { _errcode = value; } }
        public int sqlcode { get { return _sqlcode; } set { _sqlcode = value; } }
        public int lang { get { return _lang; } set { _lang = value; } }

        #endregion

        /// <summary>
        /// 部門の追加
        /// 
        /// 使用画面：MstDeptMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_DEPT_CD", _dept_cd, ComConst.DB_IN);
            db.DbPsetString("@I_DEPT_DESC1", _dept_desc1, ComConst.DB_IN);
            db.DbPsetString("@I_DEPT_DESC2", _dept_desc2, ComConst.DB_IN);
            db.DbPsetString("@I_DEPT_DESC3", _dept_desc3, ComConst.DB_IN);
            db.DbPsetString("@I_DEPT_DESC4", _dept_desc4, ComConst.DB_IN);
            db.DbPsetInt("@I_DEPT_TYPE", _dept_type, ComConst.DB_IN);
            db.DbPsetDouble("@I_NUMBER_DEPT", _number_dept, ComConst.DB_IN);
            db.DbPsetDouble("@I_AREA_DEPT", _area_dept, ComConst.DB_IN);

            //db.DbPsetDate("@I_ENTRY_DATE", DateTime.Now.ToLongDateString(), ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_DEPT_INSERT");
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
        /// 部門の変更
        /// 
        /// 使用画面：MstDeptMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_DEPT_CD", _dept_cd, ComConst.DB_IN);
            db.DbPsetString("@I_DEPT_DESC1", _dept_desc1, ComConst.DB_IN);
            db.DbPsetString("@I_DEPT_DESC2", _dept_desc2, ComConst.DB_IN);
            db.DbPsetString("@I_DEPT_DESC3", _dept_desc3, ComConst.DB_IN);
            db.DbPsetString("@I_DEPT_DESC4", _dept_desc4, ComConst.DB_IN);
            db.DbPsetInt("@I_DEPT_TYPE", _dept_type, ComConst.DB_IN);
            db.DbPsetDouble("@I_NUMBER_DEPT", _number_dept, ComConst.DB_IN);
            db.DbPsetDouble("@I_AREA_DEPT", _area_dept, ComConst.DB_IN);

            //db.DbPsetDate("@I_ENTRY_DATE", DateTime.Now.ToLongDateString(), ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_DEPT_UPDATE");
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
        /// 部門の削除
        /// 
        /// 使用画面：MstDeptMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_DEPT_CD", _dept_cd, ComConst.DB_IN);

            //db.DbPsetDate("@I_ENTRY_DATE", DateTime.Now.ToLongDateString(), ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_DEPT_DELETE");
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
        ///  部門詳細の取得

        /// 
        /// 使用画面：MstDeptMnt
        /// </summary>
        public int GetDEPTDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            strSQL.Append(" SELECT                                                                                                     ");
            strSQL.Append(" D.DEPT_CD,			D.DEPT_DESC1,	          D.DEPT_DESC2,             D.DEPT_DESC3,	                   ");
            strSQL.Append(" D.DEPT_DESC4,	    D.DEPT_TYPE,              D.NUMBER_DEPT,            D.AREA_DEPT	,                       ");
            switch (_lang)
            {
                case 2:
                    strSQL.Append(" DEPT_DESC2 AS DEPT_DESC ");
                    break;

                case 3:
                    strSQL.Append(" DEPT_DESC3 AS DEPT_DESC ");
                    break;

                case 4:
                    strSQL.Append(" DEPT_DESC4 AS DEPT_DESC ");
                    break;

                default:
                    strSQL.Append(" DEPT_DESC1 AS DEPT_DESC ");
                    break;
            }

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM DEPT_MASTER D ");
                strSQL.Append(" WHERE D.DEPT_CD            = :DEPT_CD");

                db.DbParametersClear();
                db.DbPsetString("DEPT_CD", _dept_cd);

            }
            else
            {
                strSQL.Append(" FROM DEPT_MASTER D ");
                strSQL.Append(" WHERE D.DEPT_CD            = @DEPT_CD");
                db.DbParametersClear();
                db.DbPsetString("@DEPT_CD", _dept_cd);
                if (_dept_type >= 0)
                {
                    strSQL.Append("   AND D.DEPT_TYPE       =@DEPT_TYPE");
                    db.DbPsetInt("@DEPT_TYPE", _dept_type);
                }
            }
            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _dept_cd = db.Row("DEPT_CD");
                _dept_desc = db.Row("DEPT_DESC");
                _dept_desc1 = db.Row("DEPT_DESC1");
                _dept_desc2 = db.Row("DEPT_DESC2");
                _dept_desc3 = db.Row("DEPT_DESC3");
                _dept_desc4 = db.Row("DEPT_DESC4");
                _dept_type = int.Parse(db.Row("DEPT_TYPE"));
                _number_dept = double.Parse(db.Row("NUMBER_DEPT"));
                _area_dept = double.Parse(db.Row("AREA_DEPT"));

            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        ///  部門詳細の取得

        /// 
        /// 使用画面：MstDeptMnt
        /// </summary>
        public DataSet GetDEPTList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            strSQL.Append(" SELECT                                                                                                     ");
            strSQL.Append(" D.DEPT_CD,			D.DEPT_DESC1,	          D.DEPT_DESC2,             D.DEPT_DESC3,	                   ");
            strSQL.Append(" D.DEPT_DESC4,	    D.DEPT_TYPE,              D.NUMBER_DEPT,            D.AREA_DEPT	,                       ");
            switch (_lang)
            {
                case 2:
                    strSQL.Append(" DEPT_DESC2 AS DEPT_DESC ");
                    break;

                case 3:
                    strSQL.Append(" DEPT_DESC3 AS DEPT_DESC ");
                    break;

                case 4:
                    strSQL.Append(" DEPT_DESC4 AS DEPT_DESC ");
                    break;

                default:
                    strSQL.Append(" DEPT_DESC1 AS DEPT_DESC ");
                    break;
            }

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM DEPT_MASTER D ");
                strSQL.Append(" WHERE D.DEPT_CD            = :DEPT_CD");

                db.DbParametersClear();
                db.DbPsetString("DEPT_CD", _dept_cd);

            }
            else
            {
                strSQL.Append(" FROM DEPT_MASTER D ");
                strSQL.Append(" WHERE 1=1          ");

                db.DbParametersClear();
                if (_dept_type >= 0)
                {
                    strSQL.Append("   AND D.DEPT_TYPE       =@DEPT_TYPE");
                    db.DbPsetInt("@DEPT_TYPE", _dept_type);
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
    }
}
