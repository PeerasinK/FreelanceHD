using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// 工程クラス
/// </summary>
namespace IMClass
{
    public class Process
    {
        
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Process()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Process(string p_user_id, int p_lang)
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
        protected string _ws_cd = "";
        protected string _process_cd = "";
        protected string _process_desc = "";
        protected string _process_desc2 = "";
        protected string _cost_center = "";
        protected int _sc_flag	= 0;
        protected string _vendor_cd = "";
        protected string _data_char1 = "";
        protected string _data_char2 = "";
        protected string _data_char3 = "";
        protected string _data_char4 = "";
        protected string _data_char5 = "";
        protected string _data_char6 = "";
        protected string _data_char7 = "";
        protected string _data_char8 = "";
        protected string _data_char9 = "";
        protected string _data_char10 = "";
        protected double _data_num1 = 0;
        protected double _data_num2 = 0;
        protected double _data_num3 = 0;
        protected double _data_num4 = 0;
        protected double _data_num5 = 0;
        protected double _data_num6 = 0;
        protected double _data_num7 = 0;
        protected double _data_num8 = 0;
        protected double _data_num9 = 0;
        protected double _data_num10 = 0;
        protected int _data_flag1 = 0;
        protected int _data_flag2 = 0;
        protected int _data_flag3 = 0;
        protected int _data_flag4 = 0;
        protected int _data_flag5 = 0;
        protected int _data_flag6 = 0;
        protected int _data_flag7 = 0;
        protected int _data_flag8 = 0;
        protected int _data_flag9 = 0;
        protected int _data_flag10 = 0;

        protected string _cost_center_name = "";
        protected string _vendor_name = "";
        protected double _capa_mh = 0;

        protected string _time_constraint = ""; // IMV3
        protected string _ws_desc = ""; // IMV3
       
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
        ///
        public int lang        {            get { return _lang; }            set { _lang = value; }        }
        public string ws_cd        {            get { return _ws_cd; }            set { _ws_cd = value; }        }
        public string process_cd { get { return _process_cd; } set { _process_cd = value; } }
        public string process_desc { get { return _process_desc; } set { _process_desc = value; } }
        public string process_desc2 { get { return _process_desc2; } set { _process_desc2 = value; } }
        public string cost_center        {            get { return _cost_center; }            set { _cost_center = value; }        }
        public int sc_flag        {            get { return _sc_flag; }            set { _sc_flag = value; }        }
        public string vendor_cd        {            get { return _vendor_cd; }            set { _vendor_cd = value; }        }
        public string data_char1        {            get { return _data_char1; }            set { _data_char1 = value; }        }
        public string data_char2        {            get { return _data_char2; }            set { _data_char2 = value; }        }
        public string data_char3        {            get { return _data_char3; }            set { _data_char3 = value; }        }
        public string data_char4        {            get { return _data_char4; }            set { _data_char4 = value; }        }
        public string data_char5        {            get { return _data_char5; }            set { _data_char5 = value; }        }
        public string data_char6        {            get { return _data_char6; }            set { _data_char6 = value; }        }
        public string data_char7        {            get { return _data_char7; }            set { _data_char7 = value; }        }
        public string data_char8        {            get { return _data_char8; }            set { _data_char8 = value; }        }
        public string data_char9        {            get { return _data_char9; }            set { _data_char9 = value; }        }
        public string data_char10       {            get { return _data_char10; }            set { _data_char10 = value; }        }
        public double data_num1        {            get { return _data_num1; }            set { _data_num1 = value; }        }
        public double data_num2        {            get { return _data_num2; }            set { _data_num2 = value; }        }
        public double data_num3        {            get { return _data_num3; }            set { _data_num3 = value; }        }
        public double data_num4        {            get { return _data_num4; }            set { _data_num4 = value; }        }
        public double data_num5        {            get { return _data_num5; }            set { _data_num5 = value; }        }
        public double data_num6        {            get { return _data_num6; }            set { _data_num6 = value; }        }
        public double data_num7        {            get { return _data_num7; }            set { _data_num7 = value; }        }
        public double data_num8        {            get { return _data_num8; }            set { _data_num8 = value; }        }
        public double data_num9        {            get { return _data_num9; }            set { _data_num9 = value; }        }
        public double data_num10       {            get { return _data_num10; }            set { _data_num10 = value; }        }
        public int data_flag1        {            get { return _data_flag1; }            set { _data_flag1 = value; }        }
        public int data_flag2        {            get { return _data_flag2; }            set { _data_flag2 = value; }        }
        public int data_flag3        {            get { return _data_flag3; }            set { _data_flag3 = value; }        }
        public int data_flag4        {            get { return _data_flag4; }            set { _data_flag4 = value; }        }
        public int data_flag5        {            get { return _data_flag5; }            set { _data_flag5 = value; }        }
        public int data_flag6        {            get { return _data_flag6; }            set { _data_flag6 = value; }        }
        public int data_flag7        {            get { return _data_flag7; }            set { _data_flag7 = value; }        }
        public int data_flag8        {            get { return _data_flag8; }            set { _data_flag8 = value; }        }
        public int data_flag9        {            get { return _data_flag9; }            set { _data_flag9 = value; }        }
        public int data_flag10        {            get { return _data_flag10; }            set { _data_flag10 = value; }        }

        public string cost_center_name { get { return _cost_center_name; } set { _cost_center_name = value; } }
        public string vendor_name { get { return _vendor_name; } set { _vendor_name = value; } }
        public double capa_mh { get { return _capa_mh; } set { _capa_mh = value; } }
        public string time_constraint { get { return _time_constraint; } set { _time_constraint = value; } }    // IMV3
        public string ws_desc { get { return _ws_desc; } set { _ws_desc = value; } }    // IMV3
     
        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date        {            get { return _chg_date; }            set { _chg_date = value; }        }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }
        #endregion

        /// <summary>
        /// 工程の追加
        /// 
        /// 使用画面：MstProcessMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
          
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_DESC", _process_desc, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_DESC2", _process_desc2, ComConst.DB_IN);
            db.DbPsetString("@I_COST_CENTER", _cost_center, ComConst.DB_IN);
            db.DbPsetInt("@I_SC_FLAG", _sc_flag, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_CAPA_MH", _capa_mh, ComConst.DB_IN);
            db.DbPsetString("@I_TIME_CONSTRAINT", _time_constraint, ComConst.DB_IN);    // IMV3
            db.DbPsetString("@I_DATA_CHAR1", _data_char1, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR2", _data_char2, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR3", _data_char3, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR4", _data_char4, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR5", _data_char5, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR6", _data_char6, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR7", _data_char7, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR8", _data_char8, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR9", _data_char9, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR10", _data_char10, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM1", _data_num1, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM2", _data_num2, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM3", _data_num3, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM4", _data_num4, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM5", _data_num5, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM6", _data_num6, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM7", _data_num7, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM8", _data_num8, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM9", _data_num9, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM10", _data_num10, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG1", _data_flag1, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG2", _data_flag2, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG3", _data_flag3, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG4", _data_flag4, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG5", _data_flag5, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG6", _data_flag6, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG7", _data_flag7, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG8", _data_flag8, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG9", _data_flag9, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG10", _data_flag10, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_PROCESS_INSERT");
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
        /// 工程の変更
        /// 
        /// 使用画面：MstProcessMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_DESC", _process_desc, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_DESC2", _process_desc2, ComConst.DB_IN);
            db.DbPsetString("@I_COST_CENTER", _cost_center, ComConst.DB_IN);
            db.DbPsetInt("@I_SC_FLAG", _sc_flag, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_CAPA_MH", _capa_mh, ComConst.DB_IN);
            db.DbPsetString("@I_TIME_CONSTRAINT", _time_constraint, ComConst.DB_IN);    // IMV3
            db.DbPsetString("@I_DATA_CHAR1", _data_char1, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR2", _data_char2, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR3", _data_char3, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR4", _data_char4, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR5", _data_char5, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR6", _data_char6, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR7", _data_char7, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR8", _data_char8, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR9", _data_char9, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR10", _data_char10, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM1", _data_num1, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM2", _data_num2, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM3", _data_num3, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM4", _data_num4, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM5", _data_num5, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM6", _data_num6, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM7", _data_num7, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM8", _data_num8, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM9", _data_num9, ComConst.DB_IN);
            db.DbPsetDouble("@I_DATA_NUM10", _data_num10, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG1", _data_flag1, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG2", _data_flag2, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG3", _data_flag3, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG4", _data_flag4, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG5", _data_flag5, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG6", _data_flag6, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG7", _data_flag7, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG8", _data_flag8, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG9", _data_flag9, ComConst.DB_IN);
            db.DbPsetInt("@I_DATA_FLAG10", _data_flag10, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_PROCESS_UPDATE");
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
        /// 工程の削除
        /// 
        /// 使用画面：MstProcessMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
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
            rtn = db.DbStored("SP_PROCESS_DELETE");
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
        /// 工程一覧の取得
        /// <para>使用画面：[MfgProcessComplCancel]</para>
        /// </summary>
        public DataSet GetProcessList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            //strSQL.Append("SELECT ");
            //strSQL.Append("WS_CD,				PROCESS_CD,			PROCESS_DESC,		PROCESS_DESC2,	COST_CENTER,	");
            //strSQL.Append("SC_FLAG,			    VENDOR_CD,		    CAPA_MH,            TIME_CONSTRAINT,    DATA_CHAR1,		DATA_CHAR2,     ");
            //strSQL.Append("DATA_CHAR3,			DATA_CHAR4,			DATA_CHAR5,			DATA_CHAR6,			");
            //strSQL.Append("DATA_CHAR7,			DATA_CHAR8,			DATA_CHAR9,			DATA_CHAR10,		");
            //strSQL.Append("DATA_NUM1,			DATA_NUM2,			DATA_NUM3,			DATA_NUM4,			");
            //strSQL.Append("DATA_NUM5,			DATA_NUM6,			DATA_NUM7,			DATA_NUM8,			");
            //strSQL.Append("DATA_NUM9,			DATA_NUM10,			DATA_FLAG1,			DATA_FLAG2,			");
            //strSQL.Append("DATA_FLAG3,			DATA_FLAG4,			DATA_FLAG5,			DATA_FLAG6,			");
            //strSQL.Append("DATA_FLAG7,			DATA_FLAG8,			DATA_FLAG9,			DATA_FLAG10,		");
            //strSQL.Append("ENTRY_DATE,			CHG_DATE,			CHG_PGM,			CHG_USERID,			");
            //strSQL.Append("UPDATE_CNTR");
            //strSQL.Append(" FROM PROCESS_MASTER ");
            strSQL.Append("SELECT ");
            strSQL.Append("PROCESS_NO,			PROCESS_NAME,		PROCESS_DESCRIPTION,                    ");
            strSQL.Append("ENTRY_DATE,			UPDATE_DATE,		USER_CREATE,            USER_UPDATE     ");
            strSQL.Append(" FROM PROCESS_MASTER ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                if (_process_cd != "")
                {
                    strSQL.Append(" WHERE PROCESS_CD = :PROCESS_CD ");
                    db.DbPsetString("PROCESS_CD", _process_cd);
                }
            }
            else
            {
                db.DbParametersClear();
                if (_process_cd != "")
                {
                    //strSQL.Append(" WHERE PROCESS_CD = @PROCESS_CD ");
                    strSQL.Append(" WHERE PROCESS_NO = @PROCESS_CD ");
                    db.DbPsetString("@PROCESS_CD", _process_cd);
                }
            }
            //strSQL.Append(" ORDER BY  WS_CD");

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
        /// 工程一覧の取得
        /// 
        /// 使用画面：MstProcessMnt
        /// </summary>
        public DataSet GetProcessSearch()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("WS_CD,				PROCESS_CD,			PROCESS_DESC,		PROCESS_DESC2,		COST_CENTER,	");
            strSQL.Append("SC_FLAG,			    VENDOR_CD,		    CAPA_MH,            TIME_CONSTRAINT,    DATA_CHAR1,			DATA_CHAR2,     ");
            strSQL.Append("DATA_CHAR3,			DATA_CHAR4,			DATA_CHAR5,			DATA_CHAR6,			");
            strSQL.Append("DATA_CHAR7,			DATA_CHAR8,			DATA_CHAR9,			DATA_CHAR10,		");
            strSQL.Append("DATA_NUM1,			DATA_NUM2,			DATA_NUM3,			DATA_NUM4,			");
            strSQL.Append("DATA_NUM5,			DATA_NUM6,			DATA_NUM7,			DATA_NUM8,			");
            strSQL.Append("DATA_NUM9,			DATA_NUM10,			DATA_FLAG1,			DATA_FLAG2,			");
            strSQL.Append("DATA_FLAG3,			DATA_FLAG4,			DATA_FLAG5,			DATA_FLAG6,			");
            strSQL.Append("DATA_FLAG7,			DATA_FLAG8,			DATA_FLAG9,			DATA_FLAG10,		");
            strSQL.Append("ENTRY_DATE,			CHG_DATE,			CHG_PGM,			CHG_USERID,			");
            strSQL.Append("UPDATE_CNTR                                                                      ");
            strSQL.Append(" FROM PROCESS_MASTER                                                             ");
            if (_ws_cd != "")
            {
                strSQL.Append(" WHERE WS_CD = @WS_CD                                                        ");
            }
            strSQL.Append(" ORDER BY  PROCESS_CD                                                            ");

            db.DbParametersClear();
            if (_ws_cd != "")
            {
                db.DbPsetString("@WS_CD", _ws_cd, ComConst.DB_IN);
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
        /// 工程詳細の取得
        /// 
        /// 使用画面：MstProcessMnt
        /// </summary>
        public int GetProcessDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            //strSQL.Append("SELECT ");
            //strSQL.Append("P.WS_CD,			    P.PROCESS_CD,		P.PROCESS_DESC,	    P.PROCESS_DESC2,    P.COST_CENTER,");
            //strSQL.Append("P.SC_FLAG,			P.VENDOR_CD,        P.CAPA_MH,  	    P.TIME_CONSTRAINT,  P.DATA_CHAR1,		P.DATA_CHAR2, ");
            //strSQL.Append("P.DATA_CHAR3,		P.DATA_CHAR4,		P.DATA_CHAR5,		P.DATA_CHAR6,			");
            //strSQL.Append("P.DATA_CHAR7,		P.DATA_CHAR8,		P.DATA_CHAR9,		P.DATA_CHAR10,  		");
            //strSQL.Append("P.DATA_NUM1,			P.DATA_NUM2,		P.DATA_NUM3,		P.DATA_NUM4,			");
            //strSQL.Append("P.DATA_NUM5,			P.DATA_NUM6,		P.DATA_NUM7,		P.DATA_NUM8,			");
            //strSQL.Append("P.DATA_NUM9,			P.DATA_NUM10,		P.DATA_FLAG1,		P.DATA_FLAG2,			");
            //strSQL.Append("P.DATA_FLAG3,		P.DATA_FLAG4,		P.DATA_FLAG5,		P.DATA_FLAG6,			");
            //strSQL.Append("P.DATA_FLAG7,		P.DATA_FLAG8,		P.DATA_FLAG9,		P.DATA_FLAG10,	    	");
            //strSQL.Append("P.ENTRY_DATE,		P.CHG_DATE,			P.CHG_PGM,			P.CHG_USERID,			");
            //strSQL.Append("P.UPDATE_CNTR,       V.VENDOR_NAME,                                                  ");
            //strSQL.Append("W.WS_DESC                                      ");   // IMV3
            //strSQL.Append("S.DATA_CHAR AS COST_CENTER_NAME,        V.VENDOR_NAME  ");
            strSQL.Append("SELECT ");
            strSQL.Append("PROCESS_NO,			PROCESS_NAME,		PROCESS_DESCRIPTION,                    ");
            strSQL.Append("ENTRY_DATE,			UPDATE_DATE,		USER_CREATE,            USER_UPDATE     ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PROCESS_MASTER P, SYSTEM_PARAMETER S, VENDOR_MASTER V");
                strSQL.Append(" WHERE P.WS_CD              = :WS_CD");
                //strSQL.Append(" AND P.PROCESS_CD          = :PROCESS_CD");
                //strSQL.Append("   AND P.COST_CENTER         = S.KEY02(+)");
                strSQL.Append("   AND S.KEY01         = 'COST_CENTER'");
                strSQL.Append("   AND P.VENDOR_CD           = V.VENDOR_CD(+)");
               
                db.DbParametersClear();
                db.DbPsetString("WS_CD", _ws_cd);
                db.DbPsetString("PROCESS_CD", _process_cd);
            }
            else
            {
                strSQL.Append(" FROM PROCESS_MASTER P ");
                //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'COST_CENTER' AND P.COST_CENTER = S.KEY02 ");
                //strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD = V.VENDOR_CD");
                //strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON W.WS_CD = P.WS_CD");
                //strSQL.Append(" WHERE P.WS_CD = @WS_CD AND P.PROCESS_CD = @PROCESS_CD ");
                strSQL.Append(" WHERE P.PROCESS_NO = @PROCESS_CD ");

                db.DbParametersClear();
                //db.DbPsetString("@WS_CD", _ws_cd);
                db.DbPsetString("@PROCESS_CD", _process_cd);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                //_ws_cd = db.Row("WS_CD");
                //_process_cd = db.Row("PROCESS_CD");
                //_process_desc = db.Row("PROCESS_DESC");
                //_process_desc2 = db.Row("PROCESS_DESC2");
                //_cost_center = db.Row("COST_CENTER");
                //_sc_flag = int.Parse(db.Row("SC_FLAG"));
                //_vendor_cd = db.Row("VENDOR_CD");
                //_capa_mh = double.Parse(db.Row("CAPA_MH"));
                //_time_constraint = db.Row("TIME_CONSTRAINT");   // IMV3
                //_data_char1 = db.Row("DATA_CHAR1");
                //_data_char2 = db.Row("DATA_CHAR2");
                //_data_char3 = db.Row("DATA_CHAR3");
                //_data_char4 = db.Row("DATA_CHAR4");
                //_data_char5 = db.Row("DATA_CHAR5");
                //_data_char6 = db.Row("DATA_CHAR6");
                //_data_char7 = db.Row("DATA_CHAR7");
                //_data_char8 = db.Row("DATA_CHAR8");
                //_data_char9 = db.Row("DATA_CHAR9");
                //_data_char10 = db.Row("DATA_CHAR10");
                //_data_num1 = double.Parse(db.Row("DATA_NUM1"));
                //_data_num2 = double.Parse(db.Row("DATA_NUM2"));
                //_data_num3 = double.Parse(db.Row("DATA_NUM3"));
                //_data_num4 = double.Parse(db.Row("DATA_NUM4"));
                //_data_num5 = double.Parse(db.Row("DATA_NUM5"));
                //_data_num6 = double.Parse(db.Row("DATA_NUM6"));
                //_data_num7 = double.Parse(db.Row("DATA_NUM7"));
                //_data_num8 = double.Parse(db.Row("DATA_NUM8"));
                //_data_num9 = double.Parse(db.Row("DATA_NUM9"));
                //_data_num10 = double.Parse(db.Row("DATA_NUM10"));
                //_data_flag1 = int.Parse(db.Row("DATA_FLAG1"));
                //_data_flag2 = int.Parse(db.Row("DATA_FLAG2"));
                //_data_flag3 = int.Parse(db.Row("DATA_FLAG3"));
                //_data_flag4 = int.Parse(db.Row("DATA_FLAG4"));
                //_data_flag5 = int.Parse(db.Row("DATA_FLAG5"));
                //_data_flag6 = int.Parse(db.Row("DATA_FLAG6"));
                //_data_flag7 = int.Parse(db.Row("DATA_FLAG7"));
                //_data_flag8 = int.Parse(db.Row("DATA_FLAG8"));
                //_data_flag9 = int.Parse(db.Row("DATA_FLAG9"));
                //_data_flag10 = int.Parse(db.Row("DATA_FLAG10"));
                //_entry_date = DateTime.Parse(db.Row("ENTRY_DATE"));
                //_chg_date = DateTime.Parse(db.Row("CHG_DATE"));
                //_chg_pgm = db.Row("CHG_PGM");
                //_chg_user_id = db.Row("CHG_USERID");
                //_update_cntr = int.Parse(db.Row("UPDATE_CNTR"));
                ////_cost_center_name = db.Row("COST_CENTER_NAME");
                //_vendor_name = db.Row("VENDOR_NAME");
                //_ws_desc = db.Row("WS_DESC");
                _process_cd = db.Row("PROCESS_NO");
                _process_desc = db.Row("PROCESS_NAME");
                _process_desc2 = db.Row("PROCESS_DESCRIPTION");
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }
    }
}
