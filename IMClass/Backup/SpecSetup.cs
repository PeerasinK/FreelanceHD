/*|------------------------------------------------------------------------------------------|*/
/*|  プロジェクト名　：　ProductionMaster        　                                          |*/
/*|  機能名　　　　　：　仕様別段取条件マスタラクタ　　　                                    |*/
/*|          　　　　  　Spec Setup Maintenance                                              |*/
/*|          　　　　  　                                                                    |*/
/*|  プログラムID  　：　SpecSetup.cs 　　　　　　　　　　                                   |*/
/*|------------------------------------------------------------------------------------------|*/
/*|  [History]                                                                               |*/
/*|  2009/07/27     Ubiq_ZHU   　Creation                                                    |*/
/*|------------------------------------------------------------------------------------------|*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

namespace IMClass
{
    /// <summary>
    /// 仕様別段取条件マスタラクタ
    /// </summary>   
    public class SpecSetup
    {
        #region contructor
        //contructor
        public SpecSetup()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }

        public SpecSetup(string p_user_id, int p_lang)
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

        #region  変数の定義
        /// <summary>
        /// 変数の定義
        /// </summary>
        protected string _db_type = "";
        protected int _lang = 1;

        protected string _spec_no = "";
        protected string _prev_spec_no = "";
        protected string _resource_cd = "";
        protected double _setup_time = 0;

        protected string _resource_desc = "";
        protected string _spec_desc = "";
        protected string _prev_spec_desc = "";

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

        public string spec_no { get { return _spec_no; } set { _spec_no = value; } }
        public string prev_spec_no { get { return _prev_spec_no; } set { _prev_spec_no = value; } }
        public string resource_cd { get { return _resource_cd; } set { _resource_cd = value; } }
        public double setup_time { get { return _setup_time; } set { _setup_time = value; } }
        public string resource_desc { get { return _resource_desc; } set { _resource_desc = value; } }
        public string spec_desc { get { return _spec_desc; } set { _spec_desc = value; } }
        public string prev_spec_desc { get { return _prev_spec_desc; } set { _prev_spec_desc = value; } }

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
        /// 仕様別段取条件マスタを検索して明細部を編集する

        /// 
        /// 使用画面：MstSpecSetupMnt 
        /// </summary>
        public DataSet GetSpecSetupList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();
            //--- sql
            strSQL.Append("SELECT                                                                                            ");
            strSQL.Append("SSM.RESOURCE_CD, R.RESOURCE_DESC,SSM.SPEC_CD,S1.DATA_CHAR AS SPEC_DESC,                           ");
            strSQL.Append("SSM.PREV_SPEC_CD,S2.DATA_CHAR AS PREV_SPEC_DESC, SSM.SETUP_TIME                                   ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM SPEC_SETUP_MASTER SSM                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN RESOURCE_MASTER R ON SSM.RESOURCE_CD = R.RESOURCE_CD                         ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON SSM.SPEC_CD = S1.KEY02  AND S1.KEY01 = 'SPEC_CD'      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON SSM.PREV_SPEC_CD = S2.KEY02  AND S2.KEY01 = 'SPEC_CD' ");
                strSQL.Append(" WHERE                                                                                        ");
                strSQL.Append(" SSM.RESOURCE_CD = :RESOURCE_CD                                                               ");

                db.DbPsetString("RESOURCE_CD", _resource_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM SPEC_SETUP_MASTER SSM                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN RESOURCE_MASTER R ON SSM.RESOURCE_CD = R.RESOURCE_CD                         ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON SSM.SPEC_CD = S1.KEY02 AND S1.KEY01 = 'SPEC_CD'       ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON SSM.PREV_SPEC_CD = S2.KEY02 AND S2.KEY01 = 'SPEC_CD'  ");
                strSQL.Append(" WHERE                                                                                        ");
                strSQL.Append(" SSM.RESOURCE_CD = @RESOURCE_CD                                                               ");

                db.DbPsetString("@RESOURCE_CD", _resource_cd);
            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TBLSUB");
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
        /// 仕様別段取条件マスタ詳細の取得

        /// 
        /// 使用画面：MstSpecSetupMnt
        /// </summary>
        public int GetSpecSetupDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT                                                                                            ");
            strSQL.Append(" SSM.RESOURCE_CD, R.RESOURCE_DESC,SSM.SPEC_CD,  S1.DATA_CHAR AS SPEC_DESC,                        ");
            strSQL.Append(" SSM.PREV_SPEC_CD,S2.DATA_CHAR AS PREV_SPEC_DESC, SSM.SETUP_TIME                                  ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM SPEC_SETUP_MASTER SSM                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN RESOURCE_MASTER R ON SSM.RESOURCE_CD = R.RESOURCE_CD                         ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON SSM.SPEC_CD = S1.KEY02 AND S1.KEY01 ='SPEC_CD'        ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON SSM.PREV_SPEC_CD = S2.KEY02 AND S2.KEY01 ='SPEC_CD'   ");
                strSQL.Append(" WHERE                                                                                        ");
                strSQL.Append(" ISM.RESOURCE_CD = :RESOURCE_CD                                                               ");
                strSQL.Append(" AND ISM.SPEC_NO = :SPEC_NO                                                                   ");
                strSQL.Append(" AND ISM.PREV_SPEC_NO = :PREV_SPEC_NO                                                         ");

                db.DbPsetString("RESOURCE_CD", _resource_cd);
                db.DbPsetString("SPEC_NO", _spec_no);
                db.DbPsetString("PREV_SPEC_NO", _prev_spec_no);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM SPEC_SETUP_MASTER SSM                                                                  ");
                strSQL.Append(" LEFT OUTER JOIN RESOURCE_MASTER R ON SSM.RESOURCE_CD = R.RESOURCE_CD                        ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON SSM.SPEC_CD = S1.KEY02 AND S1.KEY01 = 'SPEC_CD'      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON SSM.PREV_SPEC_CD = S2.KEY02 AND S2.KEY01 = 'SPEC_CD' ");
                strSQL.Append(" WHERE                                                                                       ");
                strSQL.Append(" SSM.RESOURCE_CD = @RESOURCE_CD                                                              ");
                strSQL.Append(" AND SSM.SPEC_CD = @SPEC_CD                                                                  ");
                strSQL.Append(" AND SSM.PREV_SPEC_CD = @PREV_SPEC_CD                                                        ");

                db.DbPsetString("@RESOURCE_CD", _resource_cd);
                db.DbPsetString("@SPEC_CD", _spec_no);
                db.DbPsetString("@PREV_SPEC_CD", _prev_spec_no);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }//SETUP_SPEC
            else
            {
                _resource_cd = db.Row("RESOURCE_CD");
                _resource_desc = db.Row("RESOURCE_DESC");
                _spec_desc = db.Row("SPEC_CD");
                _prev_spec_no = db.Row("PREV_SPEC_CD");
                _setup_time = double.Parse(db.Row("SETUP_TIME"));
                _spec_desc = db.Row("SPEC_DESC");
                _prev_spec_desc = db.Row("PREV_SPEC_DESC");
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }
        /// <summary>
        /// 仕様別段取条件マスタ登録
        /// 
        /// 使用画面：MstSpecSetupMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);
            db.DbPsetString("@I_SPEC_CD", _spec_no, ComConst.DB_IN);
            db.DbPsetString("@I_PREV_SPEC_CD", _prev_spec_no, ComConst.DB_IN);
            db.DbPsetDouble("@I_SETUP_TIME", _setup_time, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_SPEC_SETUP_INSERT");
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
        /// 仕様別段取条件マスタ更新
        /// 
        /// 使用画面：MstSpecSetupMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);
            db.DbPsetString("@I_SPEC_CD", _spec_no, ComConst.DB_IN);
            db.DbPsetString("@I_PREV_SPEC_CD", _prev_spec_no, ComConst.DB_IN);
            db.DbPsetDouble("@I_SETUP_TIME", _setup_time, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_SPEC_SETUP_UPDATE");
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
        /// 仕様別段取条件マスタ削除
        /// 
        /// 使用画面：MstSpecSetupMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);
            db.DbPsetString("@I_SPEC_CD", _spec_no, ComConst.DB_IN);
            db.DbPsetString("@I_PREV_SPEC_CD", _prev_spec_no, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_SPEC_SETUP_DELETE");
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
