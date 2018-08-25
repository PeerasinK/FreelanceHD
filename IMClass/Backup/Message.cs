using System;
using System.Web;
using System.Data;
using System.Text;
using System.Web.Configuration;

namespace IMClass
{
    public class Message
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Message()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Message(string p_user_id, int p_lang)
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
        protected string _msg_cd = "";
        protected string _msg_desc = "";
        protected string _msg_desc1 = "";
        protected string _msg_desc2 = "";
        protected string _msg_desc3 = "";
        protected string _msg_desc4 = "";
        protected string _rank = "";
        protected DateTime _entry_date = DateTime.Now;
        protected DateTime _chg_date = DateTime.Now;
        protected string _chg_user_id = "";
        protected int _update_cntr = 0;
        protected string _dbmsg = "";
        protected string _strErr = "";
        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        public int lang
        {
            get { return _lang; }
            set { _lang = value; }
        }
        public string msg_cd
        {
            get { return _msg_cd; }
            set { _msg_cd = value; }
        }
        public string msg_desc
        {
            get { return _msg_desc; }
            set { _msg_desc = value; }
        }
        public string msg_desc1
        {
            get { return _msg_desc1; }
            set { _msg_desc1 = value; }
        }
        public string msg_desc2
        {
            get { return _msg_desc2; }
            set { _msg_desc2 = value; }
        }
        public string msg_desc3
        {
            get { return _msg_desc3; }
            set { _msg_desc3 = value; }
        }
        public string msg_desc4
        {
            get { return _msg_desc4; }
            set { _msg_desc4 = value; }
        }
        public string rank
        {
            get { return _rank; }
            set { _rank = value; }
        }
        public DateTime entry_date
        {
            get { return _entry_date; }
            set { _entry_date = value; }
        }
        public DateTime chg_date
        {
            get { return _chg_date; }
            set { _chg_date = value; }
        }
        public string chg_user_id
        {
            get { return _chg_user_id; }
            set { _chg_user_id = value; }
        }
        public int update_cntr
        {
            get { return _update_cntr; }
            set { _update_cntr = value; }
        }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }
        #endregion

        /// <summary>
        /// メッセージの追加
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            if (_db_type == "ORACLE")
            {
                strSQL.Append("INSERT INTO MESSAGE_MASTER ");
                strSQL.Append("(");
                strSQL.Append("MSG_CD, LANG, MSG_DESC, RANK,");
                strSQL.Append("ENTRY_DATE, CHG_DATE, CHG_USER_ID, UPDATE_CNTR");
                strSQL.Append(") VALUES (");
                strSQL.Append(":MSG_CD, :LANG, :MSG_DESC, :RANK,");
                strSQL.Append(":ENTRY_DATE, :CHG_DATE, :CHG_USER_ID, :UPDATE_CNTR)");

                db.DbParametersClear();
                db.DbPsetString("MSG_CD", _msg_cd);
                db.DbPsetInt("LANG", _lang);
                db.DbPsetString("MSG_DESC", _msg_desc);
                db.DbPsetString("RANK", _rank);
                db.DbPsetDate("ENTRY_DATE", DateTime.Now);
                db.DbPsetDate("CHG_DATE", DateTime.Now);
                db.DbPsetString("CHG_USER_ID", _chg_user_id);
                db.DbPsetInt("UPDATE_CNTR", _update_cntr);
            }
            else
            {
                strSQL.Append("INSERT INTO MESSAGE_MASTER ");
                strSQL.Append("(");
                strSQL.Append("MSG_CD, LANG, MSG_DESC, RANK,");
                strSQL.Append("ENTRY_DATE, CHG_DATE, CHG_USER_ID, UPDATE_CNTR");
                strSQL.Append(") VALUES (");
                strSQL.Append("@MSG_CD, @LANG, @MSG_DESC, @RANK,");
                strSQL.Append("@ENTRY_DATE, @CHG_DATE, @CHG_USER_ID, @UPDATE_CNTR)");

                db.DbParametersClear();
                db.DbPsetString("@MSG_CD", _msg_cd);
                db.DbPsetInt("@LANG", _lang);
                db.DbPsetString("@MSG_DESC", _msg_desc);
                db.DbPsetString("@RANK", _rank);
                db.DbPsetDate("@ENTRY_DATE", DateTime.Now);
                db.DbPsetDate("@CHG_DATE", DateTime.Now);
                db.DbPsetString("@CHG_USER_ID", _chg_user_id);
                db.DbPsetInt("@UPDATE_CNTR", _update_cntr);
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

        /// <summary>
        /// メッセージの変更
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            if (_db_type == "ORACLE")
            {
                strSQL.Append("UPDATE MESSAGE_MASTER ");
                strSQL.Append("SET ");
                strSQL.Append("MSG_DESC = :MSG_DESC,");
                strSQL.Append("RANK = :RANK,");
                strSQL.Append("CHG_DATE = :CHG_DATE,");
                strSQL.Append("CHG_USER_ID = :CHG_USER_ID,");
                strSQL.Append("UPDATE_CNTR = UPDATE_CNTR + 1");
                strSQL.Append(" WHERE MSG_CD = :MSG_CD");
                strSQL.Append("   AND LANG = :LANG");

                db.DbParametersClear();
                db.DbPsetString("MSG_DESC", _msg_desc);
                db.DbPsetString("RANK", _rank);
                db.DbPsetDate("CHG_DATE", DateTime.Now);
                db.DbPsetString("CHG_USER_ID", _chg_user_id);
                db.DbPsetString("MSG_CD", _msg_cd);
                db.DbPsetInt("LANG", _lang);
            }
            else
            {
                strSQL.Append("UPDATE MESSAGE_MASTER ");
                strSQL.Append("SET ");
                strSQL.Append("MSG_DESC = @MSG_DESC,");
                strSQL.Append("RANK = @RANK,");
                strSQL.Append("CHG_DATE = @CHG_DATE,");
                strSQL.Append("CHG_USERID = @CHG_USER_ID,");
                strSQL.Append("UPDATE_CNTR = UPDATE_CNTR + 1");
                strSQL.Append(" WHERE MSG_CD = @MSG_CD");
                strSQL.Append("   AND LANG = @LANG");

                db.DbParametersClear();
                db.DbPsetString("@MSG_DESC", _msg_desc);
                db.DbPsetString("@RANK", _rank);
                db.DbPsetDate("@CHG_DATE", DateTime.Now);
                db.DbPsetString("@CHG_USER_ID", _chg_user_id);
                db.DbPsetString("@MSG_CD", _msg_cd);
                db.DbPsetInt("@LANG", _lang);
            }

            db.DbBeginTrans();
            
            rtn = db.DbExecute(strSQL.ToString());
            if (rtn != ComConst.FAILED)
            {
                rtn = ComConst.SUCCEED;
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

        /// <summary>
        /// メッセージの削除
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            if (_db_type == "ORACLE")
            {
                strSQL.Append("DELETE FROM MESSAGE_MASTER ");
                strSQL.Append(" WHERE MSG_CD = :MSG_CD");
                strSQL.Append("   AND LANG = :LANG");

                db.DbParametersClear();
                db.DbPsetString("MSG_CD", _msg_cd);
                db.DbPsetInt("LANG", _lang);
            }
            else
            {
                strSQL.Append("DELETE FROM MESSAGE_MASTER ");
                strSQL.Append(" WHERE MSG_CD = @MSG_CD");
                strSQL.Append("   AND LANG = @LANG");

                db.DbParametersClear();
                db.DbPsetString("@MSG_CD", _msg_cd);
                db.DbPsetInt("@LANG", _lang);
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

        /// <summary>
        /// メッセージ一覧の取得
        /// </summary>
        public DataSet GetMessageList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT MSG_CD, LANG, MSG_DESC, RANK, ");
            strSQL.Append(" ENTRY_DATE, CHG_DATE, CHG_USER_ID,");
            strSQL.Append(" UPDATE_CNTR");
            strSQL.Append(" FROM MESSAGE_MASTER ");
            strSQL.Append(" ORDER BY MSG_CD");

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "msg");
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
        /// メッセージ一覧の取得
        /// </summary>
        public DataSet GetMessageEditList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            db.DbParametersClear();
            strSQL.Append("SELECT M.MSG_CD, M1.MSG_DESC MSG_DESC1,M2.MSG_DESC MSG_DESC2,M3.MSG_DESC MSG_DESC3,M4.MSG_DESC MSG_DESC4, M.RANK ");
            strSQL.Append(" FROM ( ");
            strSQL.Append(" SELECT DISTINCT MSG_CD, RANK FROM MESSAGE_MASTER  ");
            if (_msg_cd != "" || _msg_desc1 != "" || _msg_desc2 != "" || _msg_desc3 != "" || _msg_desc4 != "")
            {
                strSQL.Append(" WHERE 1 = 0 ");
                if (_msg_cd != "")
                {
                    strSQL.Append(" OR MSG_CD LIKE @MSG_CD ");
                    db.DbPsetString("@MSG_CD", "%" + _msg_cd + "%");
                }
                if (_msg_desc1 != "")
                {
                    strSQL.Append(" OR (MSG_DESC LIKE @MSG_DESC1 AND LANG = 1)");
                    db.DbPsetString("@MSG_DESC1", "%" + _msg_desc1 + "%");
                }
                if (_msg_desc2 != "")
                {
                    strSQL.Append(" OR (MSG_DESC LIKE @MSG_DESC2 AND LANG = 2)");
                    db.DbPsetString("@MSG_DESC2", "%" + _msg_desc2 + "%");
                }
                if (_msg_desc3 != "")
                {
                    strSQL.Append(" OR (MSG_DESC LIKE @MSG_DESC3 AND LANG = 3)");
                    db.DbPsetString("@MSG_DESC3", "%" + _msg_desc3 + "%");
                }
                if (_msg_desc4 != "")
                {
                    strSQL.Append(" OR (MSG_DESC LIKE @MSG_DESC4 AND LANG = 4)");
                    db.DbPsetString("@MSG_DESC4", "%" + _msg_desc4 + "%");
                }
            }
            strSQL.Append(" ) M ");
            strSQL.Append(" LEFT JOIN MESSAGE_MASTER M1 ON M1.MSG_CD = M.MSG_CD AND M1.LANG = 1 ");
            strSQL.Append(" LEFT JOIN MESSAGE_MASTER M2 ON M2.MSG_CD = M.MSG_CD AND M2.LANG = 2 ");
            strSQL.Append(" LEFT JOIN MESSAGE_MASTER M3 ON M3.MSG_CD = M.MSG_CD AND M3.LANG = 3 ");
            strSQL.Append(" LEFT JOIN MESSAGE_MASTER M4 ON M4.MSG_CD = M.MSG_CD AND M4.LANG = 4 ");
            strSQL.Append(" ORDER BY 1 ");

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "msg");
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
        /// メッセージ詳細の取得
        /// </summary>
        public int GetMessageDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT MSG_DESC, RANK, ");
            strSQL.Append(" ENTRY_DATE, CHG_DATE, CHG_USER_ID,");
            strSQL.Append(" UPDATE_CNTR");
            strSQL.Append(" FROM MESSAGE_MASTER ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" WHERE MSG_CD = :MSG_CD");
                strSQL.Append("   AND LANG = :LANG");

                db.DbParametersClear();
                db.DbPsetString("MSG_CD", _msg_cd);
                db.DbPsetInt("LANG", _lang);
            }
            else
            {
                strSQL.Append(" WHERE MSG_CD = @MSG_CD");
                strSQL.Append("   AND LANG = @LANG");

                db.DbParametersClear();
                db.DbPsetString("@MSG_CD", _msg_cd);
                db.DbPsetInt("@LANG", _lang);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _msg_desc = db.Row("MSG_DESC");
                _rank = db.Row("RANK");
                _entry_date = DateTime.Parse(db.Row("ENTRY_DATE"));
                _chg_date = DateTime.Parse(db.Row("CHG_DATE"));
                _chg_user_id = db.Row("CHG_USER_ID");
                _update_cntr = int.Parse(db.Row("UPDATE_CNTR"));
            }
            if (db.State() == ConnectionState.Open)
                db.DbClose();

            return rtn;
        }

        /// <summary>
        /// メッセージの取得
        /// </summary>
        public string GetMessage(string msgcd)
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT MSG_DESC, RANK ");
            strSQL.Append(" FROM MESSAGE_MASTER ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" WHERE MSG_CD = :MSG_CD");
                strSQL.Append("   AND LANG = :LANG");

                db.DbParametersClear();
                db.DbPsetString("MSG_CD", msgcd);
                db.DbPsetInt("LANG", _lang);
            }
            else
            {
                strSQL.Append(" WHERE MSG_CD = @MSG_CD");
                strSQL.Append("   AND LANG = @LANG");

                db.DbParametersClear();
                db.DbPsetString("@MSG_CD", msgcd);
                db.DbPsetInt("@LANG", _lang);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                _msg_desc = "No Corresponding Message.";
            }
            else
            {
                _msg_desc = db.Row("MSG_DESC");
                _rank = db.Row("RANK");
            }
            if (db.State() == ConnectionState.Open)
                db.DbClose();

            return _msg_desc;
        }
    }
}