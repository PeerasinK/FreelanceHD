using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

namespace IMClass
{
    public class Resource
    {
        #region : 資源マスタメンテ


        /// <summary>
        /// 資源マスタメンテ

        /// </summary>
        public Resource()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Resource(string p_user_id, int p_lang)
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
        /// 資源の追加
        /// 
        /// 使用画面：MstResourceMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);
            db.DbPsetString("@I_RESOURCE_DESC", _resource_desc, ComConst.DB_IN);
            db.DbPsetString("@I_RESOURCE_DESC2", _resource_desc2, ComConst.DB_IN);
            db.DbPsetInt("@I_RESOURCE_TYPE", _resource_type, ComConst.DB_IN);
            db.DbPsetString("@I_RESOURCE_GRP", _resource_grp, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_DISPLAY_SEQ", _display_seq, ComConst.DB_IN);
            db.DbPsetInt("@I_STD_WORKING_TIME", _std_working_time, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_RESOURCE_INSERT");
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
        /// 資源の変更
        /// 
        /// 使用画面：MstResourceMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);
            db.DbPsetString("@I_RESOURCE_DESC", _resource_desc, ComConst.DB_IN);
            db.DbPsetString("@I_RESOURCE_DESC2", _resource_desc2, ComConst.DB_IN);
            db.DbPsetInt("@I_RESOURCE_TYPE", _resource_type, ComConst.DB_IN);
            db.DbPsetString("@I_RESOURCE_GRP", _resource_grp, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_DISPLAY_SEQ", _display_seq, ComConst.DB_IN);
            db.DbPsetInt("@I_STD_WORKING_TIME", _std_working_time, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_RESOURCE_UPDATE");
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
        /// 資源の削除
        /// 
        /// 使用画面：MstResourceMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_RESOURCE_DELETE");
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
        /// 資源明細の取得

        /// 
        /// 使用画面：MstResourceMnt
        /// </summary>
        public int GetResourceDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql 
            strSQL.Append("SELECT                                                                        ");
            strSQL.Append("R.RESOURCE_CD,		    R.RESOURCE_DESC,		    R.RESOURCE_DESC2,        ");
            strSQL.Append("R.RESOURCE_TYPE,		    R.RESOURCE_GRP,		        R.WS_CD,                 ");
            strSQL.Append("R.PROCESS_CD,			R.DISPLAY_SEQ,		        R.STD_WORKING_TIME,      ");
            strSQL.Append("R.TIME_DESC,             W.WS_DESC,			        P.PROCESS_DESC           ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM RESOURCE_MASTER R, WORKSHOP_MASTER W, PROCESS_MASTER P ");
                strSQL.Append(" WHERE R.RESOURCE_CD =: RESOURCE_CD  ");
                strSQL.Append(" AND R.WS_CD=W.WS_CD                 ");
                strSQL.Append(" AND R.PROCESS_CD=P.PROCESS_CD       ");

                db.DbParametersClear();
                db.DbPsetString("RESOURCE_CD", _resource_cd);
            }
            else
            {
                strSQL.Append(" FROM RESOURCE_MASTER R                                        ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON R.WS_CD=W.WS_CD          ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER P ON R.PROCESS_CD=P.PROCESS_CD ");
                strSQL.Append(" WHERE R.RESOURCE_CD = @RESOURCE_CD  ");

                db.DbParametersClear();
                db.DbPsetString("@RESOURCE_CD", _resource_cd);

            }
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
                _resource_desc2 = db.Row("RESOURCE_DESC2");
                _resource_type = int.Parse(db.Row("RESOURCE_TYPE"));
                _resource_grp = db.Row("RESOURCE_GRP");
                _ws_cd = db.Row("WS_CD");
                _ws_desc = db.Row("WS_DESC");
                _process_cd = db.Row("PROCESS_CD");
                _process_desc = db.Row("PROCESS_DESC");
                _display_seq = int.Parse(db.Row("DISPLAY_SEQ"));
                _std_working_time = int.Parse(db.Row("STD_WORKING_TIME"));
                _time_desc = db.Row("TIME_DESC");

                //_entry_date = DateTime.Parse(db.Row("ENTRY_DATE"));
                //_chg_date = DateTime.Parse(db.Row("CHG_DATE"));
                //_chg_pgm = db.Row("CHG_PGM");
                //_chg_user_id = db.Row("CHG_USER_ID");
                //_update_cntr = int.Parse(db.Row("UPDATE_CNTR"));

            }
            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        ///  資源詳細の取得

        /// 
        /// 使用画面：SrchResource
        /// </summary>
        public DataSet GetResourceList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            strSQL.Append("SELECT                                                                        ");
            strSQL.Append("R.RESOURCE_CD,		    R.RESOURCE_DESC,		    R.RESOURCE_DESC2,        ");
            strSQL.Append("R.RESOURCE_TYPE,		    R.RESOURCE_GRP,		        R.WS_CD,                 ");
            strSQL.Append("R.PROCESS_CD,			R.DISPLAY_SEQ,		        R.STD_WORKING_TIME,      ");
            strSQL.Append("R.TIME_DESC                                                                   ");
            strSQL.Append(" FROM RESOURCE_MASTER R ");
            strSQL.Append(" ORDER BY RESOURCE_CD ");

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
