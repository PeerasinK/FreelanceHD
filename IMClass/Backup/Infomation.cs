using System;
using System.Web;
//using System.Web.Services;
//using System.Web.Services.Protocols;
using System.Data;
using System.Text;
using System.Web.Configuration;

/// <summary>
/// お知らせ情報クラス
/// </summary>
namespace IMClass
{
    public class Information
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Information()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }

        public Information(string p_company_cd, string p_user_id, int p_lang)
        {
            //_company_cd = p_company_cd;
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
        protected int _lang = 0;
        //protected string _company_cd = "*";
        protected int _rec_no = 0;
        protected int _info_date = 0;
        protected string _info_msg = "";
        protected int _important_flg = 0;
        protected int _beg_eff_date = 0;
        protected int _end_eff_date = 0;
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

        //public string company_cd
        //{
        //    get { return _company_cd; }
        //    set { _company_cd = value; }
        //}
        
        public int rec_no
        {
            get { return _rec_no; }
            set { _rec_no = value; }
        }
        
        public int info_date
        {
            get { return _info_date; }
            set { _info_date = value; }
        }
        
        public string info_msg
        {
            get { return _info_msg; }
            set { _info_msg = value; }
        }
        
        public int important_flg
        {
            get { return _important_flg; }
            set { _important_flg = value; }
        }
        
        public int beg_eff_date
        {
            get { return _beg_eff_date; }
            set { _beg_eff_date = value; }
        }
        
        public int end_eff_date
        {
            get { return _end_eff_date; }
            set { _end_eff_date = value; }
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
        
        public string dbmsg 
        { 
            get { return _dbmsg; } 
            set { _dbmsg = value; } 
        }
        
        public string strErr 
        { 
            get { return _strErr; } 
            set { _strErr = value; } 
        }
        #endregion

        /// <summary>
        /// お知らせ情報の追加
        /// 
        /// 使用画面：MstInfoMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB(_db_type,"COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            // 最大のREC_NOを得る
            strSQL.Append("SELECT ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append("NVL(MAX(REC_NO),0) ");
            }
            else
            {
                strSQL.Append("ISNULL(MAX(REC_NO),0) ");
            }
            
            strSQL.Append(" AS REC_NO");

            strSQL.Append(" FROM INFO_MASTER ");
            
            //if (_db_type == "ORACLE")
            //{
            //    strSQL.Append(" WHERE COMPANY_CD = :COMPANY_CD");

            //    db.DbParametersClear();
            //    db.DbPsetString("COMPANY_CD", _company_cd);
            //}
            //else
            //{
            //    strSQL.Append(" WHERE COMPANY_CD = @COMPANY_CD");

            //    db.DbParametersClear();
            //    db.DbPsetString("@COMPANY_CD", _company_cd);
            //}
            

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _rec_no = 1;
            }
            else
            {
                try
                {
                    _rec_no = int.Parse(db.Row("REC_NO"));
                }
                catch
                {
                    _rec_no = 0;
                }

                _rec_no += 1;

            }
            
            db.DbCloseReader();

            // Insert
            strSQL = new StringBuilder();
            if (_db_type == "ORACLE")
            {
                strSQL.Append("INSERT INTO INFO_MASTER ");
                strSQL.Append("(");
                //strSQL.Append("COMPANY_CD, REC_NO, LANG, INFO_DATE, INFO_MSG,");
                strSQL.Append("REC_NO, LANG, INFO_DATE, INFO_MSG,");
                strSQL.Append("IMPORTANT_FLG, BEG_EFF_DATE, END_EFF_DATE,");
                strSQL.Append("ENTRY_DATE, CHG_DATE, CHG_USER_ID, UPDATE_CNTR");
                strSQL.Append(") VALUES (");
                //strSQL.Append(":COMPANY_CD, :REC_NO, :LANG, :INFO_DATE, :INFO_MSG,");
                strSQL.Append(":REC_NO, :LANG, :INFO_DATE, :INFO_MSG,");
                strSQL.Append(":IMPORTANT_FLG, :BEG_EFF_DATE, :END_EFF_DATE,");
                strSQL.Append(":ENTRY_DATE, :CHG_DATE, :CHG_USER_ID, :UPDATE_CNTR)");

                db.DbParametersClear();

                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetInt("REC_NO", _rec_no);
                db.DbPsetInt("LANG", _lang);
                db.DbPsetInt("INFO_DATE", _info_date);
                db.DbPsetString("INFO_MSG", _info_msg);
                db.DbPsetInt("IMPORTANT_FLG", _important_flg);
                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("END_EFF_DATE", _end_eff_date);
                db.DbPsetDate("ENTRY_DATE", DateTime.Now);
                db.DbPsetDate("CHG_DATE", DateTime.Now);
                db.DbPsetString("CHG_USER_ID", _chg_user_id);
                db.DbPsetInt("UPDATE_CNTR", _update_cntr);
            }
            else
            {
                strSQL.Append("INSERT INTO INFO_MASTER ");
                strSQL.Append("(");
                //strSQL.Append("COMPANY_CD, REC_NO, LANG, INFO_DATE, INFO_MSG,");
                strSQL.Append("REC_NO, LANG, INFO_DATE, INFO_MSG,");
                strSQL.Append("IMPORTANT_FLG, BEG_EFF_DATE, END_EFF_DATE,");
                strSQL.Append("ENTRY_DATE, CHG_DATE, CHG_USER_ID, UPDATE_CNTR");
                strSQL.Append(") VALUES (");
                //strSQL.Append("@COMPANY_CD, @REC_NO, @LANG, @INFO_DATE, @INFO_MSG,");
                strSQL.Append("@REC_NO, @LANG, @INFO_DATE, @INFO_MSG,");
                strSQL.Append("@IMPORTANT_FLG, @BEG_EFF_DATE, @END_EFF_DATE,");
                strSQL.Append("@ENTRY_DATE, @CHG_DATE, @CHG_USER_ID, @UPDATE_CNTR)");

                db.DbParametersClear();

                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetInt("@REC_NO", _rec_no);
                db.DbPsetInt("@LANG", _lang);
                db.DbPsetInt("@INFO_DATE", _info_date);
                db.DbPsetString("@INFO_MSG", _info_msg);
                db.DbPsetInt("@IMPORTANT_FLG", _important_flg);
                db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
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
        /// お知らせ情報の変更
        /// 
        /// 使用画面：MstInfoMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            if (_db_type == "ORACLE")
            {
                strSQL.Append("UPDATE INFO_MASTER ");
                strSQL.Append("SET ");
                strSQL.Append("LANG = :LANG,");
                strSQL.Append("INFO_DATE = :INFO_DATE,");
                strSQL.Append("INFO_MSG = :INFO_MSG,");
                strSQL.Append("IMPORTANT_FLG = :IMPORTANT_FLG,");
                strSQL.Append("BEG_EFF_DATE = :BEG_EFF_DATE,");
                strSQL.Append("END_EFF_DATE = :END_EFF_DATE,");
                strSQL.Append("CHG_DATE = :CHG_DATE,");
                strSQL.Append("CHG_USER_ID = :CHG_USER_ID,");
                strSQL.Append("UPDATE_CNTR = UPDATE_CNTR + 1");
                //strSQL.Append(" WHERE COMPANY_CD = :COMPANY_CD");
                strSQL.Append("   WHERE REC_NO = :REC_NO");

                db.DbParametersClear();

                db.DbPsetInt("LANG", _lang);
                db.DbPsetInt("INFO_DATE", _info_date);
                db.DbPsetString("INFO_MSG", _info_msg);
                db.DbPsetInt("IMPORTANT_FLG", _important_flg);
                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("END_EFF_DATE", _end_eff_date);
                db.DbPsetDate("CHG_DATE", DateTime.Now);
                db.DbPsetString("CHG_USER_ID", _chg_user_id);
                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetInt("REC_NO", _rec_no);
            }
            else
            {
                strSQL.Append("UPDATE INFO_MASTER ");
                strSQL.Append("SET ");
                strSQL.Append("LANG = @LANG,");
                strSQL.Append("INFO_DATE = @INFO_DATE,");
                strSQL.Append("INFO_MSG = @INFO_MSG,");
                strSQL.Append("IMPORTANT_FLG = @IMPORTANT_FLG,");
                strSQL.Append("BEG_EFF_DATE = @BEG_EFF_DATE,");
                strSQL.Append("END_EFF_DATE = @END_EFF_DATE,");
                strSQL.Append("CHG_DATE = @CHG_DATE,");
                strSQL.Append("CHG_USER_ID = @CHG_USER_ID,");
                strSQL.Append("UPDATE_CNTR = @UPDATE_CNTR + 1");
                //strSQL.Append(" WHERE COMPANY_CD = @COMPANY_CD");
                strSQL.Append("   WHERE REC_NO = @REC_NO");

                db.DbParametersClear();

                db.DbPsetInt("@LANG", _lang);
                db.DbPsetInt("@INFO_DATE", _info_date);
                db.DbPsetString("@INFO_MSG", _info_msg);
                db.DbPsetInt("@IMPORTANT_FLG", _important_flg);
                db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
                db.DbPsetDate("@CHG_DATE", DateTime.Now);
                db.DbPsetString("@CHG_USER_ID", _chg_user_id);
                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetInt("@REC_NO", _rec_no);
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
        /// お知らせ情報の削除
        /// 
        /// 使用画面：MstInfoMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            if (_db_type == "ORACLE")
            {
                strSQL.Append("DELETE FROM INFO_MASTER ");
                //strSQL.Append(" WHERE COMPANY_CD = :COMPANY_CD");
                strSQL.Append("   WHERE REC_NO = :REC_NO");

                db.DbParametersClear();

                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetInt("REC_NO", _rec_no);
            }
            else
            {
                strSQL.Append("DELETE FROM INFO_MASTER ");
                //strSQL.Append(" WHERE COMPANY_CD = @COMPANY_CD");
                strSQL.Append("   WHERE REC_NO = @REC_NO");

                db.DbParametersClear();

                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetInt("@REC_NO", _rec_no);
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
        /// お知らせ情報一覧の取得
        /// 
        /// 使用画面：MstInfoMnt
        /// </summary>
        public DataSet GetInfoList()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT REC_NO, LANG, INFO_DATE, INFO_MSG, ");
            strSQL.Append(" IMPORTANT_FLG, BEG_EFF_DATE, END_EFF_DATE,");
            strSQL.Append(" ENTRY_DATE, CHG_DATE, CHG_USER_ID,");
            strSQL.Append(" UPDATE_CNTR");
            strSQL.Append(" FROM INFO_MASTER ");

            if (_db_type == "ORACLE")
            {
                //strSQL.Append(" WHERE COMPANY_CD = :COMPANY_CD");
                if (_lang != -1)
                {
                    strSQL.Append("   AND LANG = :LANG");
                }

                strSQL.Append(" ORDER BY REC_NO");

                db.DbParametersClear();

                //db.DbPsetString("COMPANY_CD", _company_cd);
                if (_lang != -1)
                {
                    db.DbPsetInt("LANG", _lang);
                }
            }
            else
            {
                //strSQL.Append(" WHERE COMPANY_CD = @COMPANY_CD");
                if (_lang != -1)
                {
                    strSQL.Append("   AND LANG = @LANG");
                }

                strSQL.Append(" ORDER BY REC_NO");

                db.DbParametersClear();

                //db.DbPsetString("@COMPANY_CD", _company_cd);
                if (_lang != -1)
                {
                    db.DbPsetInt("@LANG", _lang);
                }
            }
            
            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "info");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }

                if (db.State() == ConnectionState.Open) db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open) db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// お知らせ情報詳細の取得
        /// 
        /// 使用画面：MstInfoMnt
        /// </summary>
        public int GetInfoDetail()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT LANG, INFO_DATE, INFO_MSG, ");
            strSQL.Append(" IMPORTANT_FLG, BEG_EFF_DATE, END_EFF_DATE,");
            strSQL.Append(" ENTRY_DATE, CHG_DATE, CHG_USER_ID,");
            strSQL.Append(" UPDATE_CNTR");
            strSQL.Append(" FROM INFO_MASTER ");
            
            if (_db_type == "ORACLE")
            {
                //strSQL.Append(" WHERE COMPANY_CD = :COMPANY_CD");
                strSQL.Append("   WHERE REC_NO = :REC_NO");

                db.DbParametersClear();

                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetInt("REC_NO", _rec_no);
            }
            else
            {
                //strSQL.Append(" WHERE COMPANY_CD = @COMPANY_CD");
                strSQL.Append("   WHERE REC_NO = @REC_NO");

                db.DbParametersClear();

                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetInt("@REC_NO", _rec_no);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _lang = int.Parse(db.Row("LANG"));
                _info_date = int.Parse(db.Row("INFO_DATE"));
                _info_msg = db.Row("INFO_MSG");
                _important_flg = int.Parse(db.Row("IMPORTANT_FLG"));
                _beg_eff_date = int.Parse(db.Row("BEG_EFF_DATE"));
                _end_eff_date = int.Parse(db.Row("END_EFF_DATE"));
                _entry_date = DateTime.Parse(db.Row("ENTRY_DATE"));
                _chg_date = DateTime.Parse(db.Row("CHG_DATE"));
                _chg_user_id = db.Row("CHG_USER_ID");
                _update_cntr = int.Parse(db.Row("UPDATE_CNTR"));
            }

            if (db.State() == ConnectionState.Open) db.DbClose();

            return rtn;
        }

        /// <summary>
        /// 本日のお知らせ情報の取得
        /// 
        /// 使用画面：AppUserMenu
        /// </summary>
        public DataSet GetInfoListToday()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            int intToday = DateTime.Now.Year * 10000 + DateTime.Now.Month * 100 + DateTime.Now.Day;

            //--- sql
            if (_db_type == "ORACLE")
            {
                strSQL.Append("SELECT INFO_DATE || ' : ' || INFO_MSG AS TEXT, IMPORTANT_FLG ");
            }
            else
            {
                strSQL.Append("SELECT CAST(INFO_DATE AS VARCHAR) + ' : ' + INFO_MSG AS TEXT, IMPORTANT_FLG ");
            }
            
            strSQL.Append(" FROM INFO_MASTER ");

            if (_db_type == "ORACLE")
            {
                //strSQL.Append(" WHERE COMPANY_CD = :COMPANY_CD");
                strSQL.Append("   WHERE (LANG = :LANG OR LANG = 0)");
                strSQL.Append("   AND BEG_EFF_DATE <= :BEG_EFF_DATE");
                strSQL.Append("   AND END_EFF_DATE >= :END_EFF_DATE");

                strSQL.Append(" ORDER BY INFO_DATE DESC, REC_NO DESC");

                db.DbParametersClear();

                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetInt("LANG", _lang);
                db.DbPsetInt("BEG_EFF_DATE", intToday);
                db.DbPsetInt("END_EFF_DATE", intToday);
            }
            else
            {
                //strSQL.Append(" WHERE COMPANY_CD = @COMPANY_CD");
                strSQL.Append("   WHERE (LANG = @LANG OR LANG = 0)");
                strSQL.Append("   AND BEG_EFF_DATE <= @BEG_EFF_DATE");
                strSQL.Append("   AND END_EFF_DATE >= @END_EFF_DATE");

                strSQL.Append(" ORDER BY INFO_DATE DESC, REC_NO DESC");

                db.DbParametersClear();

                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetInt("@LANG", _lang);
                db.DbPsetInt("@BEG_EFF_DATE", intToday);
                db.DbPsetInt("@END_EFF_DATE", intToday);
            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "info");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }

                if (db.State() == ConnectionState.Open) db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open) db.DbClose();
                return null;
            }
        }
    }
}