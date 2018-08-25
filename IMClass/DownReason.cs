using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;
namespace IMClass
{
    public class DownReason
    {
        #region : 資源ダウン理由マスタメンテ


        /// <summary>
        /// 資源ダウン理由マスタメンテ

        /// </summary>
        public DownReason()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public DownReason(string p_user_id, int p_lang)
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
        protected string _resource_cd = "";
        protected string _resource_desc = "";
        protected string _resource_desc2 = "";
        protected int _resource_type = 0;
        protected string _resource_grp = "";
        protected string _ws_cd = "";
        protected string _ws_desc = "";
        protected string _process_cd = "";
        protected string _process_desc = "";
        protected int _display_seq = 0;
        protected int _std_working_time = 0;
        protected string _time_desc = "";
        protected string _down_reason_cd = "";
        protected string _down_reason_desc = "";

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

        public string resource_cd { get { return _resource_cd; } set { _resource_cd = value; } }
        public string resource_desc { get { return _resource_desc; } set { _resource_desc = value; } }
        public string resource_desc2 { get { return _resource_desc2; } set { _resource_desc2 = value; } }
        public int resource_type { get { return _resource_type; } set { _resource_type = value; } }
        public string resource_grp { get { return _resource_grp; } set { _resource_grp = value; } }
        public string ws_cd { get { return _ws_cd; } set { _ws_cd = value; } }
        public string ws_desc { get { return _ws_desc; } set { _ws_desc = value; } }
        public string process_cd { get { return _process_cd; } set { _process_cd = value; } }
        public string process_desc { get { return _process_desc; } set { _process_desc = value; } }
        public int display_seq { get { return _display_seq; } set { _display_seq = value; } }
        public int std_working_time { get { return _std_working_time; } set { _std_working_time = value; } }
        public string time_desc { get { return _time_desc; } set { _time_desc = value; } }
        public string down_reason_cd { get { return _down_reason_cd; } set { _down_reason_cd = value; } }
        public string down_reason_desc { get { return _down_reason_desc; } set { _down_reason_desc = value; } }

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
        /// 資源ダウン理由の追加
        /// 
        /// 使用画面：MstDownReasonMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);
            db.DbPsetString("@I_DOWN_REASON_CD", _down_reason_cd, ComConst.DB_IN);
            db.DbPsetString("@I_DOWN_REASON_DESC", _down_reason_desc, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_DOWN_REASON_INSERT");
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
        /// 資源ダウン理由の変更
        /// 
        /// 使用画面：MstDownReasonMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);
            db.DbPsetString("@I_DOWN_REASON_CD", _down_reason_cd, ComConst.DB_IN);
            db.DbPsetString("@I_DOWN_REASON_DESC", _down_reason_desc, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_DOWN_REASON_UPDATE");
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
        /// 資源ダウン理由の削除
        /// 
        /// 使用画面：MstDownReasonMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);
            db.DbPsetString("@I_DOWN_REASON_CD", _down_reason_cd, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_DOWN_REASON_DELETE");
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
        ///  資源ダウン理由の取得

        /// 
        /// 使用画面：MstDownReasonMnt
        /// </summary>
        public DataSet GetResourceList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            strSQL.Append("SELECT                                                                        ");
            strSQL.Append("D.RESOURCE_CD,		    R.RESOURCE_DESC,		    D.DOWN_REASON_CD,        ");
            strSQL.Append("D.DOWN_REASON_DESC                                                            ");

            strSQL.Append(" FROM DOWN_REASON_MASTER D                                        ");
            strSQL.Append(" LEFT JOIN RESOURCE_MASTER R ON D.RESOURCE_CD = R.RESOURCE_CD     ");
            strSQL.Append(" WHERE D.RESOURCE_CD = @RESOURCE_CD  ");
            strSQL.Append(" ORDER BY  D.DOWN_REASON_CD ");

            db.DbParametersClear();
            db.DbPsetString("@RESOURCE_CD", _resource_cd);
            
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
        /// 資源ダウン理由明細の取得

        /// 
        /// 使用画面：
        /// </summary>
        public int GetDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql 
            strSQL.Append("SELECT                                                                        ");
            strSQL.Append("D.RESOURCE_CD,		    R.RESOURCE_DESC,		    D.DOWN_REASON_CD,        ");
            strSQL.Append("D.DOWN_REASON_DESC                                                            ");

            strSQL.Append(" FROM DOWN_REASON_MASTER D                                        ");
            strSQL.Append(" LEFT JOIN RESOURCE_MASTER R ON D.RESOURCE_CD = R.RESOURCE_CD     ");
            strSQL.Append(" WHERE D.RESOURCE_CD = @RESOURCE_CD  ");
            strSQL.Append(" AND D.DOWN_REASON_CD = @DOWN_REASON_CD ");

            db.DbParametersClear();
            db.DbPsetString("@RESOURCE_CD", _resource_cd);
            db.DbPsetString("@DOWN_REASON_CD", _down_reason_cd);

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _resource_cd = db.Row("RESOURCE_CD");
                _resource_desc = db.Row("RESOURCE_DESC");
                _down_reason_cd = db.Row("DOWN_REASON_CD");
                _down_reason_desc = db.Row("DOWN_REASON_DESC");

            }
            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

    }
}
