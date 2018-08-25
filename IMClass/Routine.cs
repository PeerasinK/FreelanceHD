using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Data;
/// <summary>
/// 製造工順クラス
/// </summary>
namespace IMClass
{
    public class Routine
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Routine()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Routine(string p_user_id, int p_lang)
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
        protected string _item_no = "";
        protected string _item_desc = "";
        protected string _ws_cd = "";
        protected string _ws_desc = "";
        protected int _routine_seq = 0;
        protected string _process_cd = "";
        protected string _process_desc = "";
        protected int _beg_eff_date = 0;
        protected int _end_eff_date = 0;
        protected int _lt_type = 0;
        protected int _next_proc_cont_flag = 0;
        protected double _setup_time = 0;
        protected double _unit_time = 0;
        protected double _unit_qty = 0;
        protected double _transfer_time = 0;
        protected double _daily_prod_qty = 0;
        protected double _mfg_lt = 0;
        protected double _transfer_lt = 0;
        protected double _yield = 0;
        protected int _mh_adopt_flag = 0;
        protected string _compl_umsr = "";
        protected double _process_conv_ratio = 0;
        protected double _eng_conv_ratio = 0;
        protected int _compl_round_unit = 0;
        protected int _supply_lt = 0;
        protected string _resource_cd = "";
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

        protected double _after_setup_time = 0; // IMV3
        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        public int lang { get { return _lang; } set { _lang = value; } }
        public string item_no { get { return _item_no; } set { _item_no = value; } }
        public string item_name { get { return _item_desc; } set { _item_desc = value; } }
        public string ws_cd { get { return _ws_cd; } set { _ws_cd = value; } }
        public string ws_name { get { return _ws_desc; } set { _ws_desc = value; } }
        public int beg_eff_date { get { return _beg_eff_date; } set { _beg_eff_date = value; } }
        public int end_eff_date { get { return _end_eff_date; } set { _end_eff_date = value; } }
        public int routine_seq { get { return _routine_seq; } set { _routine_seq = value; } }
        public string process_cd { get { return _process_cd; } set { _process_cd = value; } }
        public string process_desc { get { return _process_desc; } set { _process_desc = value; } }
        public int lt_type { get { return _lt_type; } set { _lt_type = value; } }
        public int next_proc_cont_flag { get { return _next_proc_cont_flag; } set { _next_proc_cont_flag = value; } }
        public double setup_time { get { return _setup_time; } set { _setup_time = value; } }
        public double unit_time { get { return _unit_time; } set { _unit_time = value; } }
        public double unit_qty { get { return _unit_qty; } set { _unit_qty = value; } }
        public double transfer_time { get { return _transfer_time; } set { _transfer_time = value; } }
        public double daily_prod_qty { get { return _daily_prod_qty; } set { _daily_prod_qty = value; } }
        public double mfg_lt { get { return _mfg_lt; } set { _mfg_lt = value; } }
        public double transfer_lt { get { return _transfer_lt; } set { _transfer_lt = value; } }
        public double yield { get { return _yield; } set { _yield = value; } }
        public int mh_adopt_flag { get { return _mh_adopt_flag; } set { _mh_adopt_flag = value; } }
        public string compl_umsr { get { return _compl_umsr; } set { _compl_umsr = value; } }
        public double process_conv_ratio { get { return _process_conv_ratio; } set { _process_conv_ratio = value; } }
        public double eng_conv_ratio { get { return _eng_conv_ratio; } set { _eng_conv_ratio = value; } }
        public int compl_round_unit { get { return _compl_round_unit; } set { _compl_round_unit = value; } }
        public int supply_lt { get { return _supply_lt; } set { _supply_lt = value; } }
        public string resource_cd { get { return _resource_cd; } set { _resource_cd = value; } }
        public string data_char1 { get { return _data_char1; } set { _data_char1 = value; } }
        public string data_char2 { get { return _data_char2; } set { _data_char2 = value; } }
        public string data_char3 { get { return _data_char3; } set { _data_char3 = value; } }
        public string data_char4 { get { return _data_char4; } set { _data_char4 = value; } }
        public string data_char5 { get { return _data_char5; } set { _data_char5 = value; } }
        public string data_char6 { get { return _data_char6; } set { _data_char6 = value; } }
        public string data_char7 { get { return _data_char7; } set { _data_char7 = value; } }
        public string data_char8 { get { return _data_char8; } set { _data_char8 = value; } }
        public string data_char9 { get { return _data_char9; } set { _data_char9 = value; } }
        public string data_char10 { get { return _data_char10; } set { _data_char10 = value; } }
        public double data_num1 { get { return _data_num1; } set { _data_num1 = value; } }
        public double data_num2 { get { return _data_num2; } set { _data_num2 = value; } }
        public double data_num3 { get { return _data_num3; } set { _data_num3 = value; } }
        public double data_num4 { get { return _data_num4; } set { _data_num4 = value; } }
        public double data_num5 { get { return _data_num5; } set { _data_num5 = value; } }
        public double data_num6 { get { return _data_num6; } set { _data_num6 = value; } }
        public double data_num7 { get { return _data_num7; } set { _data_num7 = value; } }
        public double data_num8 { get { return _data_num8; } set { _data_num8 = value; } }
        public double data_num9 { get { return _data_num9; } set { _data_num9 = value; } }
        public double data_num10 { get { return _data_num10; } set { _data_num10 = value; } }
        public int data_flag1 { get { return _data_flag1; } set { _data_flag1 = value; } }
        public int data_flag2 { get { return _data_flag2; } set { _data_flag2 = value; } }
        public int data_flag3 { get { return _data_flag3; } set { _data_flag3 = value; } }
        public int data_flag4 { get { return _data_flag4; } set { _data_flag4 = value; } }
        public int data_flag5 { get { return _data_flag5; } set { _data_flag5 = value; } }
        public int data_flag6 { get { return _data_flag6; } set { _data_flag6 = value; } }
        public int data_flag7 { get { return _data_flag7; } set { _data_flag7 = value; } }
        public int data_flag8 { get { return _data_flag8; } set { _data_flag8 = value; } }
        public int data_flag9 { get { return _data_flag9; } set { _data_flag9 = value; } }
        public int data_flag10 { get { return _data_flag10; } set { _data_flag10 = value; } }
        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }

        public double after_setup_time { get { return _after_setup_time; } set { _after_setup_time = value; } } // IMV3
        #endregion

        /// <summary>
        /// 製造工順詳細の取得

        /// 
        /// 使用画面：MstRoutineMnt
        /// </summary>
        public int GetRoutineDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("R.ITEM_NO,			R.WS_CD,			R.ROUTINE_SEQ,      R.BEG_EFF_DATE,	        ");
            strSQL.Append("R.END_EFF_DATE,	    R.PROCESS_CD,       R.LT_TYPE,          R.NEXT_PROC_CONT_FLAG,  ");
            strSQL.Append("R.SETUP_TIME,	    R.UNIT_TIME,		R.UNIT_QTY,	        R.TRANSFER_TIME,        ");
            strSQL.Append("R.DAILY_PROD_QTY,    R.MFG_LT,           R.TRANSFER_LT,      R.YIELD,                ");
            strSQL.Append("R.MH_ADOPT_FLAG,     R.COMPL_UMSR,       R.PROCESS_CONV_RATIO,R.ENG_CONV_RATIO,      ");
            strSQL.Append("R.COMPL_ROUND_UNIT,  R.SUPPLY_LT,        R.RESOURCE_CD,                              ");
            strSQL.Append("R.DATA_CHAR1,	    R.DATA_CHAR2,			    ");
            strSQL.Append("R.DATA_CHAR3,		R.DATA_CHAR4,		R.DATA_CHAR5,		R.DATA_CHAR6,			");
            strSQL.Append("R.DATA_CHAR7,		R.DATA_CHAR8,		R.DATA_CHAR9,		R.DATA_CHAR10,  		");
            strSQL.Append("R.DATA_NUM1,			R.DATA_NUM2,		R.DATA_NUM3,		R.DATA_NUM4,			");
            strSQL.Append("R.DATA_NUM5,			R.DATA_NUM6,		R.DATA_NUM7,		R.DATA_NUM8,			");
            strSQL.Append("R.DATA_NUM9,			R.DATA_NUM10,		R.DATA_FLAG1,		R.DATA_FLAG2,			");
            strSQL.Append("R.DATA_FLAG3,		R.DATA_FLAG4,		R.DATA_FLAG5,		R.DATA_FLAG6,			");
            strSQL.Append("R.DATA_FLAG7,		R.DATA_FLAG8,		R.DATA_FLAG9,		R.DATA_FLAG10,	    	");
            strSQL.Append("R.ENTRY_DATE,		R.CHG_DATE,			R.CHG_PGM,			R.CHG_USERID,			");
            strSQL.Append("R.UPDATE_CNTR,       R.AFTER_SETUP_TIME,");   // IMV3
            strSQL.Append("I.ITEM_DESC AS ITEM_DESC,");
            strSQL.Append("M.WS_DESC AS WS_DESC, P.PROCESS_DESC AS PROCESS_DESC ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ROUTINE_MASTER R, ITEM_MASTER I ,WORKSHOP_MASTER M ,PROCESS_MASTER P");
                strSQL.Append(" WHERE R.ITEM_NO             = :ITEM_NO");
                strSQL.Append("   AND R.WS_CD               = :WS_CD");
                strSQL.Append("   AND R.ROUTINE_SEQ         = :ROUTINE_SEQ");
                strSQL.Append("   AND R.BEG_EFF_DATE        <= :BEG_EFF_DATE");
                strSQL.Append("   AND R.END_EFF_DATE        >= :BEG_EFF_DATE");
                strSQL.Append("   AND R.ITEM_NO             = I.ITEM_NO(+)");
                strSQL.Append("   AND R.WS_CD               = M.WS_CD(+)");
                strSQL.Append("   AND R.WS_CD               = P.WS_CD(+)");
                strSQL.Append("   AND R.PROCESS_CD          = P.PROCESS_CD(+)");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WS_CD", _ws_cd);
                db.DbPsetInt("ROUTINE_SEQ", _routine_seq);
                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
            }
            else
            {
                strSQL.Append(" FROM ROUTINE_MASTER R ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER M ON R.WS_CD = M.WS_CD");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON R.ITEM_NO = I.ITEM_NO");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER P ON R.WS_CD = P.WS_CD AND R.PROCESS_CD = P.PROCESS_CD");
                strSQL.Append(" WHERE R.ITEM_NO = @ITEM_NO");
                strSQL.Append("   AND R.WS_CD = @WS_CD");
                strSQL.Append("   AND R.ROUTINE_SEQ = @ROUTINE_SEQ");
                strSQL.Append("   AND R.BEG_EFF_DATE <= @BEG_EFF_DATE");
                strSQL.Append("   AND R.END_EFF_DATE >= @BEG_EFF_DATE");

                db.DbParametersClear();
                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WS_CD", _ws_cd);
                db.DbPsetInt("@ROUTINE_SEQ", _routine_seq);
                db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _item_no = db.Row("ITEM_NO");
                _ws_cd = db.Row("WS_CD");
                _routine_seq = int.Parse(db.Row("ROUTINE_SEQ"));
                _beg_eff_date = int.Parse(db.Row("BEG_EFF_DATE"));
                _end_eff_date = int.Parse(db.Row("END_EFF_DATE"));
                _process_cd = db.Row("PROCESS_CD");
                _lt_type = int.Parse(db.Row("LT_TYPE"));
                _next_proc_cont_flag = int.Parse(db.Row("NEXT_PROC_CONT_FLAG"));
                _setup_time = double.Parse(db.Row("SETUP_TIME"));
                _unit_time = double.Parse(db.Row("UNIT_TIME"));
                _unit_qty = double.Parse(db.Row("UNIT_QTY"));
                _transfer_time = double.Parse(db.Row("TRANSFER_TIME"));
                _daily_prod_qty = double.Parse(db.Row("DAILY_PROD_QTY"));
                _mfg_lt = double.Parse(db.Row("MFG_LT"));
                _transfer_lt = double.Parse(db.Row("TRANSFER_LT"));
                _yield = double.Parse(db.Row("YIELD"));
                _mh_adopt_flag = int.Parse(db.Row("MH_ADOPT_FLAG"));
                _compl_umsr = db.Row("COMPL_UMSR");
                _process_conv_ratio = double.Parse(db.Row("PROCESS_CONV_RATIO"));
                _eng_conv_ratio = double.Parse(db.Row("ENG_CONV_RATIO"));
                _compl_round_unit = int.Parse(db.Row("COMPL_ROUND_UNIT"));
                _supply_lt = int.Parse(db.Row("SUPPLY_LT"));
                _resource_cd = db.Row("RESOURCE_CD");
                _data_char1 = db.Row("DATA_CHAR1");
                _data_char2 = db.Row("DATA_CHAR2");
                _data_char3 = db.Row("DATA_CHAR3");
                _data_char4 = db.Row("DATA_CHAR4");
                _data_char5 = db.Row("DATA_CHAR5");
                _data_char6 = db.Row("DATA_CHAR6");
                _data_char7 = db.Row("DATA_CHAR7");
                _data_char8 = db.Row("DATA_CHAR8");
                _data_char9 = db.Row("DATA_CHAR9");
                _data_char10 = db.Row("DATA_CHAR10");
                _data_num1 = double.Parse(db.Row("DATA_NUM1"));
                _data_num2 = double.Parse(db.Row("DATA_NUM2"));
                _data_num3 = double.Parse(db.Row("DATA_NUM3"));
                _data_num4 = double.Parse(db.Row("DATA_NUM4"));
                _data_num5 = double.Parse(db.Row("DATA_NUM5"));
                _data_num6 = double.Parse(db.Row("DATA_NUM6"));
                _data_num7 = double.Parse(db.Row("DATA_NUM7"));
                _data_num8 = double.Parse(db.Row("DATA_NUM8"));
                _data_num9 = double.Parse(db.Row("DATA_NUM9"));
                _data_num10 = double.Parse(db.Row("DATA_NUM10"));
                _data_flag1 = int.Parse(db.Row("DATA_FLAG1"));
                _data_flag2 = int.Parse(db.Row("DATA_FLAG2"));
                _data_flag3 = int.Parse(db.Row("DATA_FLAG3"));
                _data_flag4 = int.Parse(db.Row("DATA_FLAG4"));
                _data_flag5 = int.Parse(db.Row("DATA_FLAG5"));
                _data_flag6 = int.Parse(db.Row("DATA_FLAG6"));
                _data_flag7 = int.Parse(db.Row("DATA_FLAG7"));
                _data_flag8 = int.Parse(db.Row("DATA_FLAG8"));
                _data_flag9 = int.Parse(db.Row("DATA_FLAG9"));
                _data_flag10 = int.Parse(db.Row("DATA_FLAG10"));
                _entry_date = DateTime.Parse(db.Row("ENTRY_DATE"));
                _chg_date = DateTime.Parse(db.Row("CHG_DATE"));
                _chg_pgm = db.Row("CHG_PGM");
                _chg_user_id = db.Row("CHG_USERID");
                _update_cntr = int.Parse(db.Row("UPDATE_CNTR"));
                _item_desc = db.Row("ITEM_DESC");
                _ws_desc = db.Row("WS_DESC");
                _setup_time = double.Parse(db.Row("SETUP_TIME"));
                _after_setup_time = double.Parse(db.Row("AFTER_SETUP_TIME")); // IMV3
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }
        /// <summary>
        /// 製造工順一覧の取得

        /// 
        /// 使用画面：MstRoutineMnt
        /// </summary>
        public DataSet GetRoutineList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("R.ITEM_NO,			R.WS_CD,			R.ROUTINE_SEQ,      R.BEG_EFF_DATE,	        ");
            strSQL.Append("R.END_EFF_DATE,	    R.PROCESS_CD,       R.LT_TYPE,          R.NEXT_PROC_CONT_FLAG,  ");
            strSQL.Append("R.SETUP_TIME,	    R.UNIT_TIME,		R.UNIT_QTY,	        R.TRANSFER_TIME,        ");
            strSQL.Append("R.DAILY_PROD_QTY,    R.MFG_LT,           R.TRANSFER_LT,      R.YIELD,                ");
            strSQL.Append("R.MH_ADOPT_FLAG,     R.COMPL_UMSR,       R.PROCESS_CONV_RATIO,R.ENG_CONV_RATIO,      ");
            strSQL.Append("R.COMPL_ROUND_UNIT,  R.SUPPLY_LT,        R.RESOURCE_CD,                              ");
            strSQL.Append("R.DATA_CHAR1,	    R.DATA_CHAR2,			    ");
            strSQL.Append("R.DATA_CHAR3,		R.DATA_CHAR4,		R.DATA_CHAR5,		R.DATA_CHAR6,			");
            strSQL.Append("R.DATA_CHAR7,		R.DATA_CHAR8,		R.DATA_CHAR9,		R.DATA_CHAR10,  		");
            strSQL.Append("R.DATA_NUM1,			R.DATA_NUM2,		R.DATA_NUM3,		R.DATA_NUM4,			");
            strSQL.Append("R.DATA_NUM5,			R.DATA_NUM6,		R.DATA_NUM7,		R.DATA_NUM8,			");
            strSQL.Append("R.DATA_NUM9,			R.DATA_NUM10,		R.DATA_FLAG1,		R.DATA_FLAG2,			");
            strSQL.Append("R.DATA_FLAG3,		R.DATA_FLAG4,		R.DATA_FLAG5,		R.DATA_FLAG6,			");
            strSQL.Append("R.DATA_FLAG7,		R.DATA_FLAG8,		R.DATA_FLAG9,		R.DATA_FLAG10,	    	");
            strSQL.Append("R.ENTRY_DATE,		R.CHG_DATE,			R.CHG_PGM,			R.CHG_USERID,			");
            strSQL.Append("R.UPDATE_CNTR,       R.AFTER_SETUP_TIME,");   // IMV3
            strSQL.Append("I.ITEM_DESC AS ITEM_DESC,");
            strSQL.Append("M.WS_DESC AS WS_DESC, P.PROCESS_DESC AS PROCESS_DESC ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ROUTINE_MASTER R, ITEM_MASTER I ,WORKSHOP_MASTER M ,PROCESS_MASTER P");
                strSQL.Append(" WHERE R.ITEM_NO            = :ITEM_NO");
                strSQL.Append("   AND R.WS_CD              = :WS_CD");
                strSQL.Append("   AND R.ITEM_NO             = I.ITEM_NO(+)");
                strSQL.Append("   AND R.WS_CD               = M.WS_CD(+)");
                strSQL.Append("   AND R.WS_CD               = P.WS_CD(+)");
                strSQL.Append("   AND R.PROCESS_CD          = P.PROCESS_CD(+)");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WS_CD", _ws_cd);
            }
            else
            {

                strSQL.Append(" FROM ROUTINE_MASTER R ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER M ON R.WS_CD = M.WS_CD");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON R.ITEM_NO = I.ITEM_NO");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER P ON R.WS_CD = P.WS_CD AND R.PROCESS_CD = P.PROCESS_CD");
                strSQL.Append(" WHERE R.ITEM_NO = @ITEM_NO");
                strSQL.Append("   AND R.WS_CD = @WS_CD");

                db.DbParametersClear();
                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WS_CD", _ws_cd);
            }
            strSQL.Append(" ORDER BY  R.ROUTINE_SEQ");
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
        /// 製造工順の変更
        /// 
        /// 使用画面：MstRoutineMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_ROUTINE_SEQ", _routine_seq, ComConst.DB_IN);
            db.DbPsetInt("@I_BEG_EFF_DATE", _beg_eff_date, ComConst.DB_IN);
            db.DbPsetInt("@I_END_EFF_DATE", _end_eff_date, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_LT_TYPE", _lt_type, ComConst.DB_IN);
            db.DbPsetInt("@I_NEXT_PROC_CONT_FLAG", _next_proc_cont_flag, ComConst.DB_IN);
            db.DbPsetDouble("@I_SETUP_TIME", _setup_time, ComConst.DB_IN);
            db.DbPsetDouble("@I_AFTER_SETUP_TIME", _after_setup_time, ComConst.DB_IN);  // IMV3
            db.DbPsetDouble("@I_UNIT_TIME", _unit_time, ComConst.DB_IN);
            db.DbPsetDouble("@I_UNIT_QTY", _unit_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_TRANSFER_TIME", _transfer_time, ComConst.DB_IN);
            db.DbPsetDouble("@I_DAILY_PROD_QTY", _daily_prod_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_MFG_LT", _mfg_lt, ComConst.DB_IN);
            db.DbPsetDouble("@I_TRANSFER_LT", _transfer_lt, ComConst.DB_IN);
            db.DbPsetDouble("@I_YIELD", _yield, ComConst.DB_IN);
            db.DbPsetInt("@I_MH_ADOPT_FLAG", _mh_adopt_flag, ComConst.DB_IN);
            db.DbPsetString("@I_COMPL_UMSR", _compl_umsr, ComConst.DB_IN);
            db.DbPsetDouble("@I_PROCESS_CONV_RATIO", _process_conv_ratio, ComConst.DB_IN);
            db.DbPsetDouble("@I_ENG_CONV_RATIO", _eng_conv_ratio, ComConst.DB_IN);
            db.DbPsetInt("@I_COMPL_ROUND_UNIT", _compl_round_unit, ComConst.DB_IN);
            db.DbPsetInt("@I_SUPPLY_LT", _supply_lt, ComConst.DB_IN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);  
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
            rtn = db.DbStored("SP_ROUTINE_UPDATE");
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
        /// 製造工順の追加
        /// 
        /// 使用画面：MstRoutineMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_ROUTINE_SEQ", _routine_seq, ComConst.DB_IN);
            db.DbPsetInt("@I_BEG_EFF_DATE", _beg_eff_date, ComConst.DB_IN);
            db.DbPsetInt("@I_END_EFF_DATE", _end_eff_date, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_LT_TYPE", _lt_type, ComConst.DB_IN);
            db.DbPsetInt("@I_NEXT_PROC_CONT_FLAG", _next_proc_cont_flag, ComConst.DB_IN);
            db.DbPsetDouble("@I_SETUP_TIME", _setup_time, ComConst.DB_IN);
            db.DbPsetDouble("@I_AFTER_SETUP_TIME", _after_setup_time, ComConst.DB_IN);  // IMV3
            db.DbPsetDouble("@I_UNIT_TIME", _unit_time, ComConst.DB_IN);
            db.DbPsetDouble("@I_UNIT_QTY", _unit_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_TRANSFER_TIME", _transfer_time, ComConst.DB_IN);
            db.DbPsetDouble("@I_DAILY_PROD_QTY", _daily_prod_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_MFG_LT", _mfg_lt, ComConst.DB_IN);
            db.DbPsetDouble("@I_TRANSFER_LT", _transfer_lt, ComConst.DB_IN);
            db.DbPsetDouble("@I_YIELD", _yield, ComConst.DB_IN);
            db.DbPsetInt("@I_MH_ADOPT_FLAG", _mh_adopt_flag, ComConst.DB_IN);
            db.DbPsetString("@I_COMPL_UMSR", _compl_umsr, ComConst.DB_IN);
            db.DbPsetDouble("@I_PROCESS_CONV_RATIO", _process_conv_ratio, ComConst.DB_IN);
            db.DbPsetDouble("@I_ENG_CONV_RATIO", _eng_conv_ratio, ComConst.DB_IN);
            db.DbPsetInt("@I_COMPL_ROUND_UNIT", _compl_round_unit, ComConst.DB_IN);
            db.DbPsetInt("@I_SUPPLY_LT", _supply_lt, ComConst.DB_IN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_ROUTINE_INSERT");
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
        /// 製造工順の削除
        /// 
        /// 使用画面：MstRoutineMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_ROUTINE_SEQ", _routine_seq, ComConst.DB_IN);
            db.DbPsetInt("@I_BEG_EFF_DATE", _beg_eff_date, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_ROUTINE_DELETE");
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
        /// 製造工順の检索
        /// 
        /// 使用画面：MstItemMnt
        /// </summary>
        public DataSet GetRoutineList_item()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                               ");
            strSQL.Append("R.ITEM_NO,			R.WS_CD,			R.ROUTINE_SEQ,      R.BEG_EFF_DATE,	        ");
            strSQL.Append("R.END_EFF_DATE,	    R.PROCESS_CD,       R.LT_TYPE,          R.NEXT_PROC_CONT_FLAG,  ");
            strSQL.Append("R.SETUP_TIME,	    R.UNIT_TIME,		R.UNIT_QTY,	        R.TRANSFER_TIME,        ");
            strSQL.Append("R.DAILY_PROD_QTY,    R.MFG_LT,           R.TRANSFER_LT,      R.YIELD,                ");
            strSQL.Append("R.MH_ADOPT_FLAG,     R.COMPL_UMSR,       R.PROCESS_CONV_RATIO,R.ENG_CONV_RATIO,      ");
            strSQL.Append("R.COMPL_ROUND_UNIT,  R.SUPPLY_LT,        R.RESOURCE_CD,                              ");
            strSQL.Append("R.DATA_CHAR1,	    R.DATA_CHAR2,			                                        ");
            strSQL.Append("R.DATA_CHAR3,		R.DATA_CHAR4,		R.DATA_CHAR5,		R.DATA_CHAR6,			");
            strSQL.Append("R.DATA_CHAR7,		R.DATA_CHAR8,		R.DATA_CHAR9,		R.DATA_CHAR10,  		");
            strSQL.Append("R.DATA_NUM1,			R.DATA_NUM2,		R.DATA_NUM3,		R.DATA_NUM4,			");
            strSQL.Append("R.DATA_NUM5,			R.DATA_NUM6,		R.DATA_NUM7,		R.DATA_NUM8,			");
            strSQL.Append("R.DATA_NUM9,			R.DATA_NUM10,		R.DATA_FLAG1,		R.DATA_FLAG2,			");
            strSQL.Append("R.DATA_FLAG3,		R.DATA_FLAG4,		R.DATA_FLAG5,		R.DATA_FLAG6,			");
            strSQL.Append("R.DATA_FLAG7,		R.DATA_FLAG8,		R.DATA_FLAG9,		R.DATA_FLAG10,	    	");
            strSQL.Append("R.ENTRY_DATE,		R.CHG_DATE,			R.CHG_PGM,			R.CHG_USERID,			");
            strSQL.Append("R.UPDATE_CNTR,       R.AFTER_SETUP_TIME  ,                                           "); // IMV3
            strSQL.Append("I.ITEM_DESC AS ITEM_DESC,                                                            ");
            strSQL.Append("M.WS_DESC AS WS_DESC, P.PROCESS_DESC AS PROCESS_DESC                                 ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ROUTINE_MASTER R, ITEM_MASTER I ,WORKSHOP_MASTER M ,PROCESS_MASTER P");
                strSQL.Append(" WHERE R.ITEM_NO            = :ITEM_NO");
                strSQL.Append("   AND R.ITEM_NO             = I.ITEM_NO(+)");
                strSQL.Append("   AND R.WS_CD               = M.WS_CD(+)");
                strSQL.Append("   AND R.WS_CD               = P.WS_CD(+)");
                strSQL.Append("   AND R.PROCESS_CD          = P.PROCESS_CD(+)");
                strSQL.Append("   AND R.BEG_EFF_DATE <=: @BEG_EFF_DATE");
                strSQL.Append("   AND R.END_EFF_DATE >=: @END_EFF_DATE");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("END_EFF_DATE", _end_eff_date);
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM ROUTINE_MASTER R                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER M ON R.WS_CD = M.WS_CD                                  ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON R.ITEM_NO = I.ITEM_NO                                  ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER P ON R.WS_CD = P.WS_CD AND R.PROCESS_CD = P.PROCESS_CD   ");
                strSQL.Append(" WHERE R.ITEM_NO = @ITEM_NO                                                              ");
                if (_beg_eff_date != 0)
                {
                    strSQL.Append(" AND R.BEG_EFF_DATE <= @BEG_EFF_DATE");
                    db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                }
                if (_end_eff_date != 0)
                {
                    strSQL.Append(" AND R.END_EFF_DATE >= @END_EFF_DATE");
                    db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
                }
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            strSQL.Append(" ORDER BY  R.ROUTINE_SEQ");
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
