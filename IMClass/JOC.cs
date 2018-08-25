using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

namespace IMClass
{
    public class JOC
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public JOC()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public JOC(string p_user_id, int p_lang)
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
        protected string _joc_cd = "";
        protected int _beg_eff_date = 0;
        protected int _end_eff_date = 0;
        protected int _joc_status = 0;
        protected int _joc_type = 0;
        protected string _joc_desc = "";
        protected string _joc_desc2 = "";
        protected string _cost_center = "";
        protected string _ws_cd = "";
        protected string _process_cd = "";
        protected string _ws_desc = "";
        protected string _cost_center_desc = "";

        protected int _srchflag = 0;
        protected string _item_no = "";

        protected string _db_type = "";
        protected int _lang = 1;
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

        protected bool _range;  //ADD BY UBIQ-SUO 2010/09/25
        #endregion

        #region : プロパティ
        public string joc_cd { get { return _joc_cd; } set { _joc_cd = value; } }
        public int beg_eff_date { get { return _beg_eff_date; } set { _beg_eff_date = value; } }
        public int end_eff_date { get { return _end_eff_date; } set { _end_eff_date = value; } }
        public int joc_status { get { return _joc_status; } set { _joc_status = value; } }
        public int joc_type { get { return _joc_type; } set { _joc_type = value; } }
        public string joc_desc { get { return _joc_desc; } set { _joc_desc = value; } }
        public string joc_desc2 { get { return _joc_desc2; } set { _joc_desc2 = value; } }
        public string cost_center { get { return _cost_center; } set { _cost_center = value; } }
        public string ws_cd { get { return _ws_cd; } set { _ws_cd = value; } }
        public string process_cd { get { return _process_cd; } set { _process_cd = value; } }
        public string ws_desc { get { return _ws_desc; } set { _ws_desc = value; } }
        public string cost_center_desc { get { return _cost_center_desc; } set { _cost_center_desc = value; } }

        public int srchflag { get { return _srchflag; } set { _srchflag = value; } }
        public string item_no { get { return _item_no; } set { _item_no = value; } }

        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string errmsg { get { return _errmsg; } set { _errmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }
        public int errcode { get { return _errcode; } set { _errcode = value; } }
        public int sqlcode { get { return _sqlcode; } set { _sqlcode = value; } }
        public int lang { get { return _lang; } set { _lang = value; } }

        public bool range { get { return _range; } set { _range = value; } } //ADD BY UBIQ-SUO 2010/09/25
        #endregion

        /// <summary>
        /// JOCの追加
        /// 
        /// 使用画面：MstJOCMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_JOC_CD", _joc_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_BEG_EFF_DATE", _beg_eff_date, ComConst.DB_IN);
            db.DbPsetInt("@I_END_EFF_DATE", _end_eff_date, ComConst.DB_IN);
            db.DbPsetInt("@I_JOC_STATUS", 0, ComConst.DB_IN);
            db.DbPsetInt("@I_JOC_TYPE", _joc_type, ComConst.DB_IN);
            db.DbPsetString("@I_JOC_DESC", _joc_desc, ComConst.DB_IN);
            db.DbPsetString("@I_JOC_DESC2", _joc_desc2, ComConst.DB_IN);
            db.DbPsetString("@I_COST_CENTER", _cost_center, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USERID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_JOC_INSERT");
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
        /// JOCの変更
        /// 
        /// 使用画面：MstJOCMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_JOC_CD", _joc_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_BEG_EFF_DATE", _beg_eff_date, ComConst.DB_IN);
            db.DbPsetInt("@I_END_EFF_DATE", _end_eff_date, ComConst.DB_IN);
            db.DbPsetInt("@I_JOC_STATUS", _joc_status, ComConst.DB_IN);
            db.DbPsetInt("@I_JOC_TYPE", _joc_type, ComConst.DB_IN);
            db.DbPsetString("@I_JOC_DESC", _joc_desc, ComConst.DB_IN);
            db.DbPsetString("@I_JOC_DESC2", _joc_desc2, ComConst.DB_IN);
            db.DbPsetString("@I_COST_CENTER", _cost_center, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USERID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_JOC_UPDATE");
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
        /// JOCの消除
        /// 
        /// 使用画面：MstJOCMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_JOC_CD", _joc_cd, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USERID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_JOC_DELETE");
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
        /// JOCの取得

        /// 
        /// 使用画面：Mst JOCMnt
        /// </summary>
        public int GetJOCDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql 
            strSQL.Append("SELECT                                                                             ");
            strSQL.Append("J.JOC_CD     ,         J.BEG_EFF_DATE   ,          J.END_EFF_DATE ,                ");
            strSQL.Append("J.JOC_STATUS ,         J.JOC_TYPE ,                                                ");
            strSQL.Append("J.JOC_DESC   ,         J.JOC_DESC2 ,                                               ");
            strSQL.Append("J.COST_CENTER,         J.WS_CD ,                                                   ");
            strSQL.Append("J.PROCESS_CD,			 J.CHG_PGM,			J.CHG_USERID, J.ENTRY_DATE,              ");
            strSQL.Append("J.UPDATE_CNTR,         J.CHG_DATE ,                                                ");
            strSQL.Append("W.WS_DESC AS WS_DESC ,                                                             ");
            strSQL.Append("D.DEPT_DESC1 AS COST_CENTER_DESC                                                    ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM JOC_MASTER J, WORKSHOP_MASTER W, SYSTEM_PARAMETER S ,   ");
                strSQL.Append(" WHERE J.JOC_CD            = :JOC_CD                          ");
                strSQL.Append("   AND J.WS_CD             = W.WS_CD (+)                      ");
                strSQL.Append("   AND J.COST_CENTER       = S.KEY02 (+)                      ");
                strSQL.Append("   AND S.KEY01             = 'COST_CENTER'                    ");


                db.DbParametersClear();
                db.DbPsetString("JOC_CD", _joc_cd);
            }
            else
            {
                strSQL.Append("  FROM JOC_MASTER J ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W  ON J.WS_CD  = W.WS_CD         ");
                strSQL.Append(" LEFT OUTER JOIN DEPT_MASTER D ON J.COST_CENTER =D.DEPT_CD        ");
                strSQL.Append(" WHERE J.JOC_CD = @JOC_CD                                         ");

                db.DbParametersClear();
                db.DbPsetString("@JOC_CD", _joc_cd);

            }
            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _joc_cd = db.Row("JOC_CD");
                _beg_eff_date = int.Parse(db.Row("BEG_EFF_DATE"));
                _end_eff_date = int.Parse(db.Row("END_EFF_DATE"));
                _joc_status = int.Parse(db.Row("JOC_STATUS"));
                _joc_type = int.Parse(db.Row("JOC_TYPE"));
                _joc_desc = db.Row("JOC_DESC");
                _joc_desc2 = db.Row("JOC_DESC2");
                _cost_center = db.Row("COST_CENTER");
                _ws_cd = db.Row("WS_CD");
                _process_cd = db.Row("PROCESS_CD");
                _ws_desc = db.Row("WS_DESC");
                _cost_center_desc = db.Row("COST_CENTER_DESC");

                _entry_date = DateTime.Parse(db.Row("ENTRY_DATE"));
                _chg_date = DateTime.Parse(db.Row("CHG_DATE"));
                _chg_pgm = db.Row("CHG_PGM");
                _chg_user_id = db.Row("CHG_USERID");
                _update_cntr = int.Parse(db.Row("UPDATE_CNTR"));

            }
            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// JOCの取得

        /// 
        /// <para>使用画面：SearchJoc</para> 
        /// </summary>
        public DataSet GetJOCList()//UPD UBIQ-LIU 2010/07/01
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();
            ComLibrary comlibrary = new ComLibrary();
            //--- sql

            //--> ADD BY UBIQ-SUO 2010/09/25
            strSQL.Append(" SELECT  COUNT(*)                                                ");
            //strSQL.Append(" J.JOC_CD,           J.BEG_EFF_DATE,     J.END_EFF_DATE,         ");
            //strSQL.Append(" J.JOC_STATUS,       J.JOC_TYPE,         J.JOC_DESC,             ");
            //strSQL.Append(" J.JOC_DESC2,        J.COST_CENTER,      J.WS_CD,                ");
            //strSQL.Append(" J.PROCESS_CD,	    J.CHG_PGM,			J.CHG_USERID,		    ");
            //strSQL.Append(" J.UPDATE_CNTR,      W.WS_DESC AS WS_DESC,                       ");
            //strSQL.Append(" S.DATA_CHAR AS COST_CENTER_DESC                                 ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM JOC_MASTER J                                           ");
                //strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W  ON J.WS_CD  = W.WS_CD    ");
                //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 ='COST_CENTER'");
                //strSQL.Append(" AND J.COST_CENTER =S.KEY02                                  ");
                strSQL.Append(" WHERE J.JOC_TYPE              = @JOC_TYPE                   ");
                strSQL.Append(" AND  JOC_STATUS  =  @JOC_STATUS                             ");
                db.DbParametersClear();
                if (_item_no != "")
                {
                    strSQL.Append(" AND  J.JOC_ITEM_NO   =  @ITEM_NO       ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                db.DbPsetInt("@JOC_STATUS", _srchflag);
                db.DbPsetInt("@JOC_TYPE", _joc_type);
            }
            else
            {
                strSQL.Append(" FROM JOC_MASTER J                                           ");
                //strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W  ON J.WS_CD  = W.WS_CD    ");
                //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 ='COST_CENTER'");
                //strSQL.Append(" AND J.COST_CENTER =S.KEY02                                  ");
                strSQL.Append(" WHERE J.JOC_TYPE              = @JOC_TYPE                   ");
                strSQL.Append(" AND  JOC_STATUS  =  @JOC_STATUS                             ");
                db.DbParametersClear();
                if (_item_no != "")
                {
                    strSQL.Append(" AND  J.JOC_ITEM_NO   =  @ITEM_NO       ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                db.DbPsetInt("@JOC_STATUS", _srchflag);
                db.DbPsetInt("@JOC_TYPE", _joc_type);
            }
            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                    return null;
                }
                //if (db.State() == ConnectionState.Open)
                //    db.DbClose();
                if (comlibrary.StringToInt(ds.Tables[0].Rows[0][0].ToString()) > 2000)
                {
                    _range = true;
                }
                else
                {
                    _range = false;
                }
                
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
            strSQL = new StringBuilder();
            //<-- ADD BY UBIQ-SUO 2010/09/25

            strSQL.Append(" SELECT  TOP 2000                                                "); //UPD BY UBIQ-SUO 2010/09/25 ADD TOP 2000
            strSQL.Append(" J.JOC_CD,           J.BEG_EFF_DATE,     J.END_EFF_DATE,         ");
            strSQL.Append(" J.JOC_STATUS,       J.JOC_TYPE,         J.JOC_DESC,             ");
            strSQL.Append(" J.JOC_DESC2,        J.COST_CENTER,      J.WS_CD,                ");
            strSQL.Append(" J.PROCESS_CD,	    J.CHG_PGM,			J.CHG_USERID,		    ");
            strSQL.Append(" J.UPDATE_CNTR,      W.WS_DESC AS WS_DESC,                       ");
            strSQL.Append(" S.DATA_CHAR AS COST_CENTER_DESC                                 ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM JOC_MASTER J                                           ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W  ON J.WS_CD  = W.WS_CD    ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 ='COST_CENTER'");
                strSQL.Append(" AND J.COST_CENTER =S.KEY02                                  ");
                strSQL.Append(" WHERE J.JOC_TYPE              = @JOC_TYPE                   ");
                strSQL.Append(" AND  JOC_STATUS  =  @JOC_STATUS                             ");
                db.DbParametersClear();
                if (_item_no != "")
                {
                    strSQL.Append(" AND  J.JOC_ITEM_NO   =  @ITEM_NO       ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                db.DbPsetInt("@JOC_STATUS", _srchflag);
                db.DbPsetInt("@JOC_TYPE", _joc_type);
            }
            else
            {
                strSQL.Append(" FROM JOC_MASTER J                                           ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W  ON J.WS_CD  = W.WS_CD    ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 ='COST_CENTER'");
                strSQL.Append(" AND J.COST_CENTER =S.KEY02                                  ");
                strSQL.Append(" WHERE J.JOC_TYPE              = @JOC_TYPE                   ");
                strSQL.Append(" AND  JOC_STATUS  =  @JOC_STATUS                             ");
                db.DbParametersClear();
                if (_item_no != "")
                {
                    strSQL.Append(" AND  J.JOC_ITEM_NO   =  @ITEM_NO       ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                db.DbPsetInt("@JOC_STATUS", _srchflag);
                db.DbPsetInt("@JOC_TYPE", _joc_type);
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

        /// <summary>
        /// 製番検索2のDATA取得

        /// 
        /// <para>使用画面：MstJOC2Mnt</para>
        /// </summary>
        public DataSet GetJOCList2()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();
            //--- sql
            //-->ADD BY UBIQ-SUO 2010/09/25
            if (_joc_type == 0)//製番区分=製造製番の場合

            {
                strSQL.Append(" SELECT DISTINCT                                                   ");
                strSQL.Append("  J.JOC_CD,  J.ITEM_NO JOC_DESC,   0 JOC_TYPE,    J.ITEM_NO,       ");
                strSQL.Append("  I.ITEM_DESC                                                      ");

                strSQL.Append(" FROM PRODUCTION_PLAN J                                  ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER I ON J.ITEM_NO = I.ITEM_NO        ");
                strSQL.Append(" WHERE                                                   ");
                if (_srchflag == 0)//未完の場合

                {
                    strSQL.Append("   ORDER_STATUS  <  90                   ");
                }
                else//完了の場合

                {
                    strSQL.Append("   ORDER_STATUS  >=  90                  ");
                }
                if (_db_type == "ORACLE")
                {
                    db.DbParametersClear();
                    if (_item_no != "")
                    {
                        strSQL.Append("  AND J.ITEM_NO              = :ITEM_NO ");
                        db.DbPsetString("ITEM_NO", _item_no);
                    }

                }
                else
                {
                    db.DbParametersClear();
                    if (_item_no != "")
                    {
                        strSQL.Append("  AND J.ITEM_NO              = @ITEM_NO ");
                        db.DbPsetString("@ITEM_NO", _item_no);
                    }
                }
            }
            else//製番区分=個別製番の場合

            {
                strSQL.Append(" SELECT                                                            ");
                strSQL.Append(" J.JOC_CD,  J.JOC_DESC,    1 JOC_TYPE,     J.JOC_ITEM_NO ITEM_NO,  ");
                strSQL.Append(" I.ITEM_DESC                                                       ");

                strSQL.Append(" FROM JOC_MASTER J                                       ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER I ON J.JOC_ITEM_NO = I.ITEM_NO    ");
                strSQL.Append(" WHERE JOC_TYPE = 1                                      ");
                if (_db_type == "ORACLE")
                {
                    db.DbParametersClear();
                    strSQL.Append(" AND  JOC_STATUS  =  :JOC_STATUS    ");
                    if (_item_no != "")
                    {
                        strSQL.Append(" AND  J.JOC_ITEM_NO   =  :ITEM_NO       ");
                        db.DbPsetString("ITEM_NO", _item_no);
                    }

                    db.DbPsetInt("JOC_STATUS", _srchflag);
                }
                else
                {
                    db.DbParametersClear();
                    strSQL.Append(" AND  JOC_STATUS  =  @JOC_STATUS    ");
                    if (_item_no != "")
                    {
                        strSQL.Append(" AND  J.JOC_ITEM_NO   =  @ITEM_NO       ");
                        db.DbPsetString("@ITEM_NO", _item_no);
                    }
                    db.DbPsetInt("@JOC_STATUS", _srchflag);
                }
            }
            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "TABLE");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                    return null;
                }
                //if (db.State() == ConnectionState.Open)
                //    db.DbClose();

                if (ds.Tables[0].Rows.Count > 2000)
                {
                    _range = true;
                }
                else
                {
                    _range = false;
                }
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return null;
            }
            strSQL = new StringBuilder();
            //<--ADD BY UBIQ-SUO 2010/09/25

            if (_joc_type == 0)//製番区分=製造製番の場合

            {
                strSQL.Append(" SELECT TOP 2000 A.* FROM (SELECT DISTINCT                         "); //UPD BY UBIQ-SUO 2010/09/26
                strSQL.Append("  J.JOC_CD,  J.ITEM_NO JOC_DESC,   0 JOC_TYPE,    J.ITEM_NO,       ");
                strSQL.Append("  I.ITEM_DESC                                                      ");

                strSQL.Append(" FROM PRODUCTION_PLAN J                                  ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER I ON J.ITEM_NO = I.ITEM_NO        ");
                strSQL.Append(" WHERE                                                   ");
                if (_srchflag == 0)//未完の場合

                {
                    strSQL.Append("   ORDER_STATUS  <  90                   ");
                }
                else//完了の場合

                {
                    strSQL.Append("   ORDER_STATUS  >=  90                  ");
                }
                if (_db_type == "ORACLE")
                {
                    db.DbParametersClear();
                    if (_item_no != "")
                    {
                        strSQL.Append("  AND J.ITEM_NO              = :ITEM_NO )");
                        db.DbPsetString("ITEM_NO", _item_no);
                    }

                }
                else
                {
                    db.DbParametersClear();
                    if (_item_no != "")
                    {
                        strSQL.Append("  AND J.ITEM_NO              = @ITEM_NO ) A");
                        db.DbPsetString("@ITEM_NO", _item_no);
                    }
                }
                strSQL.Append(" ) A                                          ");        //Add Ubiq-Sai 2011.08.25
            }
            else//製番区分=個別製番の場合

            {
                strSQL.Append(" SELECT  TOP 2000                                                  "); //UPD BY UBIQ-SUO 2010/09/26 ADD TOP 2000
                strSQL.Append(" J.JOC_CD,  J.JOC_DESC,    1 JOC_TYPE,     J.JOC_ITEM_NO ITEM_NO,  ");
                strSQL.Append(" I.ITEM_DESC                                                       ");

                strSQL.Append(" FROM JOC_MASTER J                                       ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER I ON J.JOC_ITEM_NO = I.ITEM_NO    ");
                strSQL.Append(" WHERE JOC_TYPE = 1                                      ");
                if (_db_type == "ORACLE")
                {
                    db.DbParametersClear();
                    strSQL.Append(" AND  JOC_STATUS  =  :JOC_STATUS    ");
                    if (_item_no != "")
                    {
                        strSQL.Append(" AND  J.JOC_ITEM_NO   =  :ITEM_NO       ");
                        db.DbPsetString("ITEM_NO", _item_no);
                    }

                    db.DbPsetInt("JOC_STATUS", _srchflag);
                }
                else
                {
                    db.DbParametersClear();
                    strSQL.Append(" AND  JOC_STATUS  =  @JOC_STATUS    ");
                    if (_item_no != "")
                    {
                        strSQL.Append(" AND  J.JOC_ITEM_NO   =  @ITEM_NO       ");
                        db.DbPsetString("@ITEM_NO", _item_no);
                    }
                    db.DbPsetInt("@JOC_STATUS", _srchflag);
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
        
        /// <summary>
        /// 製番検索2のチェック
        /// 
        /// <para>使用画面：[MstBOMMnt][MstItemEntry]</para>
        /// </summary>
        public int GetJOC2Detail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql 
            strSQL.Append(" SELECT                                                    ");
            strSQL.Append(" J.JOC_CD ,J.JOC_DESC                                      ");
            strSQL.Append(" FROM JOC_MASTER J                                         ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" WHERE J.JOC_CD            = :JOC_CD                   ");
                strSQL.Append(" UNION ALL                                             ");
                strSQL.Append(" SELECT                                                ");
                strSQL.Append(" P.JOC_CD ,P.ITEM_NO JOC_DESC                          ");
                strSQL.Append(" FROM PRODUCTION_PLAN P                                ");
                strSQL.Append(" WHERE P.JOC_CD            = :JOC_CD                   ");
                db.DbParametersClear();
                db.DbPsetString("JOC_CD", _joc_cd);
            }
            else
            {
                strSQL.Append(" WHERE J.JOC_CD            = @JOC_CD                   ");
                strSQL.Append(" UNION ALL                                             ");
                strSQL.Append(" SELECT                                                ");
                strSQL.Append(" P.JOC_CD ,P.ITEM_NO JOC_DESC                          ");
                strSQL.Append(" FROM PRODUCTION_PLAN P                                ");
                strSQL.Append(" WHERE P.JOC_CD            = @JOC_CD                   ");
                db.DbParametersClear();
                db.DbPsetString("@JOC_CD", _joc_cd);

            }
            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _joc_cd = db.Row("JOC_CD");
                _joc_desc = db.Row("JOC_DESC");
            }
            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }
    }
}
