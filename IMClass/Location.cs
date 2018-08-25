using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// ロケーションクラス
/// </summary>
namespace IMClass
{
    public class Location
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Location()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Location(string p_user_id, int p_lang)
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
        protected string _whs_cd = "";
        protected string _whs_desc = "";
        protected string _location = "";
        protected string _location_desc = "";

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

        protected string _location_desc2 = "";
        protected string _dept_no = "";

        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        public int lang { get { return _lang; } set { _lang = value; } }
        public string whs_cd { get { return _whs_cd; } set { _whs_cd = value; } }
        public string whs_desc { get { return _whs_desc; } set { _whs_desc = value; } }
        public string location { get { return _location; } set { _location = value; } }
        public string location_desc { get { return _location_desc; } set { _location_desc = value; } }

        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }

        public string location_desc2 { get { return _location_desc2; } set { _location_desc2 = value; } }
        public string dept_no { get { return _dept_no; } set { _dept_no = value; } }

        #endregion

        /// <summary>
        /// ロケーションの追加
        /// 
        /// 使用画面：MstLocationMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION", _location, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION_DESC", _location_desc, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION_DESC2", _location_desc2, ComConst.DB_IN);    // HTS
            db.DbPsetString("@I_DEPT_NO", _dept_no, ComConst.DB_IN);    // HTS
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_LOCATION_INSERT");
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
        /// ロケーションの追加 HTS
        /// 
        /// 使用画面：MstLocationMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION", _location, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION_DESC", _location_desc, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION_DESC2", _location_desc2, ComConst.DB_IN);    // HTS
            db.DbPsetString("@I_DEPT_NO", _dept_no, ComConst.DB_IN);    // HTS
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_LOCATION_UPDATE");
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
        /// ロケーションの削除
        /// 
        /// 使用画面：MstLocationMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION", _location, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_LOCATION_DELETE");
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
        /// ロケーション一覧の取得
        /// 
        /// 使用画面：MstLocationMnt
        /// </summary>
        public DataSet GetLocationList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            //strSQL.Append("SELECT ");
            //strSQL.Append("LOCATION,			LOCATION_DESC	");
            //strSQL.Append(" FROM LOCATION_MASTER ");
            //strSQL.Append(" WHERE WHS_CD = @WHS_CD ");
            //strSQL.Append(" ORDER BY  LOCATION");
            strSQL.Append("SELECT ");
            strSQL.Append("LOCATION_NO,     LOCATION_NAME,      LOCATION_DESCRIPTION,       DEPT_NO,     	");
            strSQL.Append("ENTRY_DATE,      UPDATE_DATE,        USER_CREATE,               USER_UPDATE     	");
            strSQL.Append(" FROM LOCATION_MASTER ");

            //db.DbParametersClear();
            //db.DbPsetString("@WHS_CD", _whs_cd);

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
        /// ロケーション一覧の取得
        /// 
        /// 使用画面：MstLocationLblPrt
        /// </summary>
        public DataSet GetLocationListAll()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("L.WHS_CD,			W.WHS_DESC,	");
            strSQL.Append("L.LOCATION,			L.LOCATION_DESC	");
            strSQL.Append(" FROM LOCATION_MASTER L ");
            strSQL.Append(" INNER JOIN WAREHOUSE_MASTER W ON W.WHS_CD = L.WHS_CD ");
            strSQL.Append(" WHERE 1 = 1 ");
            if(_whs_cd != "")
                strSQL.Append(" AND L.WHS_CD = @WHS_CD ");
            if (_location != "")
                strSQL.Append(" AND L.LOCATION = @LOCATION ");
            strSQL.Append(" ORDER BY  L.WHS_CD, L.LOCATION");

            db.DbParametersClear();
            if (_whs_cd != "")
                db.DbPsetString("@WHS_CD", _whs_cd);
            if (_location != "")
                db.DbPsetString("@LOCATION", _location);

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
        /// ロケーション詳細の取得

        /// 
        /// 使用画面：InvStockInq
        /// </summary>
        public int GetLocationDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            //strSQL.Append(" SELECT ");
            //strSQL.Append(" L.WHS_CD,   L.LOCATION,			L.LOCATION_DESC			                          ");
            //strSQL.Append(" FROM LOCATION_MASTER L                                                ");
            //strSQL.Append(" WHERE L.WHS_CD = @WHS_CD                                              ");
            //strSQL.Append("   AND L.LOCATION = @LOCATION                                          ");
            strSQL.Append("SELECT ");
            strSQL.Append("LOCATION_NO,     LOCATION_NAME,      LOCATION_DESCRIPTION,       DEPT_NO,     	");
            strSQL.Append("ENTRY_DATE,      UPDATE_DATE,        USER_CREATE,               USER_UPDATE     	");
            strSQL.Append(" FROM LOCATION_MASTER L ");
            strSQL.Append(" WHERE L.LOCATION_NO = @LOCATION                                                 ");

            db.DbParametersClear();
            //db.DbPsetString("@WHS_CD", _whs_cd);
            db.DbPsetString("@LOCATION", _location);

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                //_whs_cd = db.Row("WHS_CD");
                //_location = db.Row("LOCATION");
                //_location_desc = db.Row("LOCATION_DESC");
                _location = db.Row("LOCATION_NO");
                _location_desc = db.Row("LOCATION_NAME");
                _location_desc2 = db.Row("LOCATION_DESCRIPTION");
                _dept_no = db.Row("DEPT_NO");
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

    }
}
