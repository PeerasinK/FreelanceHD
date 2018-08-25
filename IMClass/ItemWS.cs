using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;
/// <summary>
/// ItemWSクラス
/// </summary>
namespace IMClass
{
   public class ItemWS
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ItemWS()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public ItemWS(string p_user_id, int p_lang)
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
        /// 
        /// </summary>
        protected string _db_type = "";
        protected int _lang = 1;
        protected string _item_no = "";
        protected string _item_name = "";
        protected int _pty_no = 0;
        protected string _ws_cd = "";
        protected string _ws_name = "";
        protected int _beg_eff_date = 0;
        protected int _end_eff_date = 0;
        protected string _rep_routine_item_no = "";
        protected string _rep_routine_item_name = "";
        protected string _rep_routine_ws_cd = "";
        protected string _rep_routine_ws_name = "";
        protected double _insp_lt = 0;
        protected int _disb_lt = 0;
        protected int _plant_lt = 0;
        protected string _compl_whs = "";
        protected string _compl_whs_name = "";
        protected string _semi_whs = "";
        protected string _semi_whs_name = "";
        protected string _disb_whs = "";
        protected string _disb_whs_name = "";
        protected string _bond_semi_whs = "";
        protected string _bond_semi_whs_name = "";
        protected string _bond_disb_whs = "";
        protected string _bond_disb_whs_name = "";
        protected int _idtag_print_flag = 0;
        protected double _idtag_unit_qty = 0;

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
        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        public int lang { get { return _lang; } set { _lang = value; } }
        public string item_no { get { return _item_no; } set { _item_no = value; } }
        public string item_name { get { return _item_name; } set { _item_name = value; } }
        public int pty_no { get { return _pty_no; } set { _pty_no = value; } }
        public string ws_cd { get { return _ws_cd; } set { _ws_cd = value; } }
        public string ws_name { get { return _ws_name; } set { _ws_name = value; } }
        public int beg_eff_date { get { return _beg_eff_date; } set { _beg_eff_date = value; } }
        public int end_eff_date { get { return _end_eff_date; } set { _end_eff_date = value; } }
        public string rep_routine_item_no { get { return _rep_routine_item_no; } set { _rep_routine_item_no = value; } }
        public string rep_routine_item_name { get { return _rep_routine_item_name; } set { _rep_routine_item_name = value; } }
        public string rep_routine_ws_cd { get { return _rep_routine_ws_cd; } set { _rep_routine_ws_cd = value; } }
        public string rep_routine_ws_name { get { return _rep_routine_ws_name; } set { _rep_routine_ws_name = value; } }
        public double insp_lt { get { return _insp_lt; } set { _insp_lt = value; } }
        public int disb_lt { get { return _disb_lt; } set { _disb_lt = value; } }
        public int plant_lt { get { return _plant_lt; } set { _plant_lt = value; } }
        public string compl_whs { get { return _compl_whs; } set { _compl_whs = value; } }
        public string compl_whs_name { get { return _compl_whs_name; } set { _compl_whs_name = value; } }
        public string semi_whs { get { return _semi_whs; } set { _semi_whs = value; } }
        public string semi_whs_name { get { return _semi_whs_name; } set { _semi_whs_name = value; } }
        public string disb_whs { get { return _disb_whs; } set { _disb_whs = value; } }
        public string disb_whs_name { get { return _disb_whs_name; } set { _disb_whs_name = value; } }
        public string bond_semi_whs { get { return _bond_semi_whs; } set { _bond_semi_whs = value; } }
        public string bond_semi_whs_name { get { return _bond_semi_whs_name; } set { _bond_semi_whs_name = value; } }
        public string bond_disb_whs { get { return _bond_disb_whs; } set { _bond_disb_whs = value; } }
        public string bond_disb_whs_name { get { return _bond_disb_whs_name; } set { _bond_disb_whs_name = value; } }
        public double idtag_unit_qty { get { return _idtag_unit_qty; } set { _idtag_unit_qty = value; } }
        public int idtag_print_flag { get { return _idtag_print_flag; } set { _idtag_print_flag = value; } }

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
        #endregion

        /// <summary>
        /// 品目作業場所詳細の取得
        /// 
        /// 使用画面：MstItemWSMnt
        /// </summary>
        public int GetItemWsDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("I.ITEM_NO,			I.PTY_NO,			    I.WS_CD,			    I.BEG_EFF_DATE,	");
            strSQL.Append("I.END_EFF_DATE,	    I.REP_ROUTINE_ITEM_NO,  I.REP_ROUTINE_WS_CD,    I.INSP_LT,	    ");
            strSQL.Append("I.DISB_LT,");//ADD 2008-10-8 LIU 
            strSQL.Append("I.PLANT_LT,	        I.COMPL_WHS,		I.SEMI_WHS,	        I.DISB_WHS,		        ");
            strSQL.Append("I.BOND_SEMI_WHS,	    I.BOND_DISB_WHS,	I.IDTAG_UNIT_QTY,   I.IDTAG_PRINT_FLAG, 	");
            strSQL.Append("I.DATA_CHAR1,	    I.DATA_CHAR2,			                                        ");
            strSQL.Append("I.DATA_CHAR3,		I.DATA_CHAR4,		I.DATA_CHAR5,		I.DATA_CHAR6,			");
            strSQL.Append("I.DATA_CHAR7,		I.DATA_CHAR8,		I.DATA_CHAR9,		I.DATA_CHAR10,  		");
            strSQL.Append("I.DATA_NUM1,			I.DATA_NUM2,		I.DATA_NUM3,		I.DATA_NUM4,			");
            strSQL.Append("I.DATA_NUM5,			I.DATA_NUM6,		I.DATA_NUM7,		I.DATA_NUM8,			");
            strSQL.Append("I.DATA_NUM9,			I.DATA_NUM10,		I.DATA_FLAG1,		I.DATA_FLAG2,			");
            strSQL.Append("I.DATA_FLAG3,		I.DATA_FLAG4,		I.DATA_FLAG5,		I.DATA_FLAG6,			");
            strSQL.Append("I.DATA_FLAG7,		I.DATA_FLAG8,		I.DATA_FLAG9,		I.DATA_FLAG10,	    	");
            strSQL.Append("I.ENTRY_DATE,		I.CHG_DATE,			I.CHG_PGM,			I.CHG_USERID,			");
            strSQL.Append("I.UPDATE_CNTR,");
            strSQL.Append("W1.WHS_DESC AS COMPL_WHS_DESC, W2.WHS_DESC AS SEMI_WHS_DESC , W3.WHS_DESC AS DISB_WHS_DESC,");
            strSQL.Append("W4.WHS_DESC AS BOND_SEMI_WHS_DESC, W5.WHS_DESC AS BOND_DISB_WHS_DESC,");
            strSQL.Append("I1.ITEM_DESC AS ITEM_DESC, I2.ITEM_DESC AS REP_ROUTINE_ITEM_DESC,");
            strSQL.Append("M1.WS_DESC AS WS_DESC, M2.WS_DESC AS REP_ROUTINE_WS_DESC");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ITEM_WS_MASTER I, WAREHOUSE_MASTER W1,WAREHOUSE_MASTER W2, WAREHOUSE_MASTER W3,WAREHOUSE_MASTER W4,WAREHOUSE_MASTER W5, ");
                strSQL.Append(" ITEM_MASTER I1,ITEM_MASTER I2,WORKSHOP_MASTER M1,WORKSHOP_MASTER M2 ");
                strSQL.Append(" WHERE I.ITEM_NO            = :ITEM_NO");
                strSQL.Append("   AND I.PTY_NO             = :PTY_NO");
                strSQL.Append("   AND I.BEG_EFF_DATE       <= :BEG_EFF_DATE");
                strSQL.Append("   AND I.END_EFF_DATE       >= :BEG_EFF_DATE");
                strSQL.Append("   AND I.COMPL_WHS          = W1.WHS_CD(+)");
                strSQL.Append("   AND I.SEMI_WHS            = W2.WHS_CD(+)");
                strSQL.Append("   AND I.DISB_WHS            = W3.WHS_CD(+)");
                strSQL.Append("   AND I.BOND_SEMI_WHS       = W4.WHS_CD(+)");
                strSQL.Append("   AND I.BOND_DISB_WHS       = W5.WHS_CD(+)");
                strSQL.Append("   AND I.ITEM_NO             = I1.ITEM_NO(+)");
                strSQL.Append("   AND I.REP_ROUTINE_ITEM_NO = I2.ITEM_NO(+)");
                strSQL.Append("   AND I.WS_CD               = M1.WS_CD(+)");
                strSQL.Append("   AND I.REP_ROUTINE_WS_CD   = M2.WS_CD(+)");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetInt("PTY_NO", _pty_no);
                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
            }
            else
            {
                strSQL.Append(" FROM ITEM_WS_MASTER I ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W1 ON I.COMPL_WHS = W1.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W2 ON I.SEMI_WHS = W2.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W3 ON I.DISB_WHS = W3.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W4 ON I.BOND_SEMI_WHS = W4.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W5 ON I.BOND_DISB_WHS = W5.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER M1 ON I.WS_CD = M1.WS_CD");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER M2 ON I.REP_ROUTINE_WS_CD = M2.WS_CD");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I1 ON I.ITEM_NO = I1.ITEM_NO");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I2 ON I.REP_ROUTINE_ITEM_NO = I2.ITEM_NO");
                strSQL.Append(" WHERE I.ITEM_NO = @ITEM_NO");
                strSQL.Append("   AND I.PTY_NO = @PTY_NO");
                strSQL.Append("   AND I.BEG_EFF_DATE <= @BEG_EFF_DATE");
                strSQL.Append("   AND I.END_EFF_DATE >= @BEG_EFF_DATE");

                db.DbParametersClear();
                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetInt("@PTY_NO", _pty_no);
                db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                //db.DbPsetInt("@END_EFF_DATE", _beg_eff_date);
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
                _pty_no = int.Parse(db.Row("PTY_NO"));
                _ws_cd = db.Row("WS_CD");
                _beg_eff_date = int.Parse(db.Row("BEG_EFF_DATE"));
                _end_eff_date = int.Parse(db.Row("END_EFF_DATE"));
                _rep_routine_item_no = db.Row("REP_ROUTINE_ITEM_NO");
                _rep_routine_ws_cd = db.Row("REP_ROUTINE_WS_CD");
                _insp_lt = double.Parse(db.Row("INSP_LT"));
                _disb_lt = int.Parse(db.Row("DISB_LT"));
                _plant_lt = int.Parse(db.Row("PLANT_LT"));
                _compl_whs = db.Row("COMPL_WHS");
                _semi_whs = db.Row("SEMI_WHS");
                _disb_whs = db.Row("DISB_WHS");
                _bond_semi_whs = db.Row("BOND_SEMI_WHS");
                _bond_disb_whs = db.Row("BOND_DISB_WHS");
                _idtag_unit_qty = double.Parse(db.Row("IDTAG_UNIT_QTY"));
                _idtag_print_flag = int.Parse(db.Row("IDTAG_PRINT_FLAG"));
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
                _compl_whs_name  = db.Row("COMPL_WHS_DESC");
                _disb_whs_name = db.Row("DISB_WHS_DESC");
                _semi_whs_name = db.Row("SEMI_WHS_DESC");
                _bond_disb_whs_name = db.Row("BOND_DISB_WHS_DESC");
                _bond_semi_whs_name = db.Row("BOND_SEMI_WHS_DESC");
                _rep_routine_item_name = db.Row("REP_ROUTINE_ITEM_DESC");
                _rep_routine_ws_name = db.Row("REP_ROUTINE_WS_DESC");
                _item_name = db.Row("ITEM_DESC");
                _ws_name = db.Row("WS_DESC");
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }
        /// <summary>
        /// 品目作業場所一覧の取得
        /// 
        /// 使用画面：MstItemWSMnt
        /// </summary>
        public DataSet GetItemWSList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();
            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("I.ITEM_NO,			I.PTY_NO,			    I.WS_CD,			    I.BEG_EFF_DATE,	            ");
            strSQL.Append("I.END_EFF_DATE,	    I.REP_ROUTINE_ITEM_NO,  I.REP_ROUTINE_WS_CD,    I.INSP_LT,	                ");
            strSQL.Append("I.DISB_LT,                                                                                       ");//ADD 2008-10-8 LIU 
            strSQL.Append("I.PLANT_LT,	        I.COMPL_WHS,		    I.SEMI_WHS,	        I.DISB_WHS,	                    ");
            strSQL.Append("I.BOND_SEMI_WHS,	    I.BOND_DISB_WHS,		I.IDTAG_UNIT_QTY,   I.IDTAG_PRINT_FLAG,	            ");
            strSQL.Append("I.DATA_CHAR1,	    I.DATA_CHAR2,			                                                    ");
            strSQL.Append("I.DATA_CHAR3,		I.DATA_CHAR4,		I.DATA_CHAR5,		I.DATA_CHAR6,			            ");
            strSQL.Append("I.DATA_CHAR7,		I.DATA_CHAR8,		I.DATA_CHAR9,		I.DATA_CHAR10,  		            ");
            strSQL.Append("I.DATA_NUM1,			I.DATA_NUM2,		I.DATA_NUM3,		I.DATA_NUM4,			            ");
            strSQL.Append("I.DATA_NUM5,			I.DATA_NUM6,		I.DATA_NUM7,		I.DATA_NUM8,			            ");
            strSQL.Append("I.DATA_NUM9,			I.DATA_NUM10,		I.DATA_FLAG1,		I.DATA_FLAG2,			            ");
            strSQL.Append("I.DATA_FLAG3,		I.DATA_FLAG4,		I.DATA_FLAG5,		I.DATA_FLAG6,			            ");
            strSQL.Append("I.DATA_FLAG7,		I.DATA_FLAG8,		I.DATA_FLAG9,		I.DATA_FLAG10,	    	            ");
            strSQL.Append("I.ENTRY_DATE,		I.CHG_DATE,			I.CHG_PGM,			I.CHG_USERID,			            ");
            strSQL.Append("I.UPDATE_CNTR,                                                                                   ");
            strSQL.Append(" W1.WHS_DESC AS COMPL_WHS_DESC,  W2.WHS_DESC AS SEMI_WHS_DESC ,  W3.WHS_DESC AS DISB_WHS_DESC,   ");
            strSQL.Append(" W4.WHS_DESC AS BOND_SEMI_WHS_DESC,  W5.WHS_DESC AS BOND_DISB_WHS_DESC,                          ");
            strSQL.Append(" I1.ITEM_DESC AS ITEM_DESC,  I2.ITEM_DESC AS REP_ROUTINE_ITEM_DESC,                              ");
            strSQL.Append(" M1.WS_DESC AS WS_DESC,  M2.WS_DESC AS REP_ROUTINE_WS_DESC                                       ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ITEM_WS_MASTER I, WAREHOUSE_MASTER W1,WAREHOUSE_MASTER W2, WAREHOUSE_MASTER W3,WAREHOUSE_MASTER W4,WAREHOUSE_MASTER W5, ");
                strSQL.Append(" ITEM_MASTER I1,ITEM_MASTER I2,WORKSHOP_MASTER M1,WORKSHOP_MASTER M2 ");
                strSQL.Append(" WHERE I.ITEM_NO            = :ITEM_NO           ");
                strSQL.Append(" AND I.BEG_EFF_DATE <= :BEG_EFF_DATE             ");
                strSQL.Append(" AND I.END_EFF_DATE >= :END_EFF_DATE             ");
                strSQL.Append("   AND I.COMPL_WHS          = W1.WHS_CD(+)       ");
                strSQL.Append("   AND I.SEMI_WHS            = W2.WHS_CD(+)      ");
                strSQL.Append("   AND I.DISB_WHS            = W3.WHS_CD(+)      ");
                strSQL.Append("   AND I.BOND_SEMI_WHS       = W4.WHS_CD(+)      ");
                strSQL.Append("   AND I.BOND_DISB_WHS       = W5.WHS_CD(+)      ");
                strSQL.Append("   AND I.ITEM_NO             = I1.ITEM_NO(+)     ");
                strSQL.Append("   AND I.REP_ROUTINE_ITEM_NO = I2.ITEM_NO(+)     ");
                strSQL.Append("   AND I.WS_CD               = M1.WS_CD(+)       ");
                strSQL.Append("   AND I.REP_ROUTINE_WS_CD   = M2.WS_CD(+)       ");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("END_EFF_DATE", _end_eff_date);
            }
            else
            {
                strSQL.Append(" FROM ITEM_WS_MASTER I ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W1 ON I.COMPL_WHS = W1.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W2 ON I.SEMI_WHS = W2.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W3 ON I.DISB_WHS = W3.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W4 ON I.BOND_SEMI_WHS = W4.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W5 ON I.BOND_DISB_WHS = W5.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER M1 ON I.WS_CD = M1.WS_CD");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER M2 ON I.REP_ROUTINE_WS_CD = M2.WS_CD");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I1 ON I.ITEM_NO = I1.ITEM_NO");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I2 ON I.REP_ROUTINE_ITEM_NO = I2.ITEM_NO");
                strSQL.Append(" WHERE I.ITEM_NO = @ITEM_NO");
                db.DbParametersClear();
                if (_beg_eff_date != 0)
                {
                    strSQL.Append(" AND I.BEG_EFF_DATE <= @BEG_EFF_DATE");
                    db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                }
                if (_end_eff_date != 0)
                {
                    strSQL.Append(" AND I.END_EFF_DATE >= @END_EFF_DATE");
                    db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
                }
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            strSQL.Append(" ORDER BY  I.PTY_NO");
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
        /// 品目作業場所の変更
        /// 
        /// 使用画面：MstITEMWSMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PTY_NO", _pty_no, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_BEG_EFF_DATE", _beg_eff_date, ComConst.DB_IN);
            db.DbPsetInt("@I_END_EFF_DATE", _end_eff_date, ComConst.DB_IN);
            db.DbPsetString("@I_REP_ROUTINE_ITEM_NO", _rep_routine_item_no, ComConst.DB_IN);
            db.DbPsetString("@I_REP_ROUTINE_WS_CD", _rep_routine_ws_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_INSP_LT", _insp_lt, ComConst.DB_IN);
            db.DbPsetInt("@I_DISB_LT", _disb_lt, ComConst.DB_IN);
            db.DbPsetInt("@I_PLANT_LT", _plant_lt, ComConst.DB_IN);
            db.DbPsetString("@I_COMPL_WHS", _compl_whs, ComConst.DB_IN);
            db.DbPsetString("@I_SEMI_WHS", _semi_whs, ComConst.DB_IN);
            db.DbPsetString("@I_DISB_WHS", _disb_whs, ComConst.DB_IN);
            db.DbPsetString("@I_BOND_SEMI_WHS", _bond_semi_whs, ComConst.DB_IN);
            db.DbPsetString("@I_BOND_DISB_WHS", _bond_disb_whs, ComConst.DB_IN);
            db.DbPsetDouble("@I_IDTAG_UNIT_QTY",_idtag_unit_qty,ComConst.DB_IN);
            db.DbPsetInt("@I_IDTAG_PRINT_FLAG",_idtag_print_flag,ComConst.DB_IN);
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
            rtn = db.DbStored("SP_ITEM_WS_UPDATE");
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
        /// 品目作業場所の追加
        /// 
        /// 使用画面：MstItemWSMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PTY_NO", _pty_no, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_BEG_EFF_DATE", _beg_eff_date, ComConst.DB_IN);
            db.DbPsetInt("@I_END_EFF_DATE", _end_eff_date, ComConst.DB_IN);
            db.DbPsetString("@I_REP_ROUTINE_ITEM_NO", _rep_routine_item_no, ComConst.DB_IN);
            db.DbPsetString("@I_REP_ROUTINE_WS_CD", _rep_routine_ws_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_INSP_LT", _insp_lt, ComConst.DB_IN);
            db.DbPsetInt("@I_DISB_LT", _disb_lt, ComConst.DB_IN);
            db.DbPsetInt("@I_PLANT_LT", _plant_lt, ComConst.DB_IN);
            db.DbPsetString("@I_COMPL_WHS", _compl_whs, ComConst.DB_IN);
            db.DbPsetString("@I_SEMI_WHS", _semi_whs, ComConst.DB_IN);
            db.DbPsetString("@I_DISB_WHS", _disb_whs, ComConst.DB_IN);
            db.DbPsetString("@I_BOND_SEMI_WHS", _bond_semi_whs, ComConst.DB_IN);
            db.DbPsetString("@I_BOND_DISB_WHS", _bond_disb_whs, ComConst.DB_IN);
            db.DbPsetDouble("@I_IDTAG_UNIT_QTY", _idtag_unit_qty, ComConst.DB_IN);
            db.DbPsetInt("@I_IDTAG_PRINT_FLAG", _idtag_print_flag, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_ITEM_WS_INSERT");
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
        /// 品目作業場所の削除
        /// 
        /// 使用画面：MstItemWSMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PTY_NO", _pty_no, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_ITEM_WS_DELETE");
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
        /// 入力品目コード、作業区コードにて品目作業場所マスタより、詳細の取得
        /// 
        /// 使用画面：MfgManJORlse
        /// </summary>
        public int GetItemWsDetail2()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("I.ITEM_NO,			I.PTY_NO,			    I.WS_CD,			    I.BEG_EFF_DATE,	");
            strSQL.Append("I.END_EFF_DATE,	    I.REP_ROUTINE_ITEM_NO,  I.REP_ROUTINE_WS_CD,    I.INSP_LT,	    ");
            strSQL.Append("I.DISB_LT,");//ADD 2008-10-8 LIU 
            strSQL.Append("I.PLANT_LT,	        I.COMPL_WHS,		I.SEMI_WHS,	        I.DISB_WHS,		        ");
            strSQL.Append("I.BOND_SEMI_WHS,	    I.BOND_DISB_WHS,	I.IDTAG_UNIT_QTY,   I.IDTAG_PRINT_FLAG,	    ");
            strSQL.Append("I.DATA_CHAR1,	    I.DATA_CHAR2,			                                        ");
            strSQL.Append("I.DATA_CHAR3,		I.DATA_CHAR4,		I.DATA_CHAR5,		I.DATA_CHAR6,			");
            strSQL.Append("I.DATA_CHAR7,		I.DATA_CHAR8,		I.DATA_CHAR9,		I.DATA_CHAR10,  		");
            strSQL.Append("I.DATA_NUM1,			I.DATA_NUM2,		I.DATA_NUM3,		I.DATA_NUM4,			");
            strSQL.Append("I.DATA_NUM5,			I.DATA_NUM6,		I.DATA_NUM7,		I.DATA_NUM8,			");
            strSQL.Append("I.DATA_NUM9,			I.DATA_NUM10,		I.DATA_FLAG1,		I.DATA_FLAG2,			");
            strSQL.Append("I.DATA_FLAG3,		I.DATA_FLAG4,		I.DATA_FLAG5,		I.DATA_FLAG6,			");
            strSQL.Append("I.DATA_FLAG7,		I.DATA_FLAG8,		I.DATA_FLAG9,		I.DATA_FLAG10,	    	");
            strSQL.Append("I.ENTRY_DATE,		I.CHG_DATE,			I.CHG_PGM,			I.CHG_USERID,			");
            strSQL.Append("I.UPDATE_CNTR,");
            strSQL.Append("W1.WHS_DESC AS COMPL_WHS_DESC, W2.WHS_DESC AS SEMI_WHS_DESC , W3.WHS_DESC AS DISB_WHS_DESC,");
            strSQL.Append("W4.WHS_DESC AS BOND_SEMI_WHS_DESC, W5.WHS_DESC AS BOND_DISB_WHS_DESC,");
            strSQL.Append("I1.ITEM_DESC AS ITEM_DESC, I2.ITEM_DESC AS REP_ROUTINE_ITEM_DESC,");
            strSQL.Append("M1.WS_DESC AS WS_DESC, M2.WS_DESC AS REP_ROUTINE_WS_DESC");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ITEM_WS_MASTER I, WAREHOUSE_MASTER W1,WAREHOUSE_MASTER W2, WAREHOUSE_MASTER W3,WAREHOUSE_MASTER W4,WAREHOUSE_MASTER W5, ");
                strSQL.Append(" ITEM_MASTER I1,ITEM_MASTER I2,WORKSHOP_MASTER M1,WORKSHOP_MASTER M2 ");
                strSQL.Append(" WHERE I.ITEM_NO            = :ITEM_NO       ");
                strSQL.Append("   AND I.WS_CD             = :WS_CD          ");
                strSQL.Append("   AND I.BEG_EFF_DATE       <= :BEG_EFF_DATE ");
                strSQL.Append("   AND I.END_EFF_DATE       >= :BEG_EFF_DATE ");
                strSQL.Append("   AND I.COMPL_WHS          = W1.WHS_CD(+)   ");
                strSQL.Append("   AND I.SEMI_WHS            = W2.WHS_CD(+)  ");
                strSQL.Append("   AND I.DISB_WHS            = W3.WHS_CD(+)  ");
                strSQL.Append("   AND I.BOND_SEMI_WHS       = W4.WHS_CD(+)  ");
                strSQL.Append("   AND I.BOND_DISB_WHS       = W5.WHS_CD(+)  ");
                strSQL.Append("   AND I.ITEM_NO             = I1.ITEM_NO(+) ");
                strSQL.Append("   AND I.REP_ROUTINE_ITEM_NO = I2.ITEM_NO(+) ");
                strSQL.Append("   AND I.WS_CD               = M1.WS_CD(+)   ");
                strSQL.Append("   AND I.REP_ROUTINE_WS_CD   = M2.WS_CD(+)   ");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WS_CD", _ws_cd);
                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
            }
            else
            {
                strSQL.Append(" FROM ITEM_WS_MASTER I ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W1 ON I.COMPL_WHS = W1.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W2 ON I.SEMI_WHS = W2.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W3 ON I.DISB_WHS = W3.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W4 ON I.BOND_SEMI_WHS = W4.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W5 ON I.BOND_DISB_WHS = W5.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER M1 ON I.WS_CD = M1.WS_CD");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER M2 ON I.REP_ROUTINE_WS_CD = M2.WS_CD");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I1 ON I.ITEM_NO = I1.ITEM_NO");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I2 ON I.REP_ROUTINE_ITEM_NO = I2.ITEM_NO");
                strSQL.Append(" WHERE I.ITEM_NO = @ITEM_NO");
                strSQL.Append("   AND I.WS_CD = @WS_CD");
                strSQL.Append("   AND I.BEG_EFF_DATE <= @BEG_EFF_DATE");
                strSQL.Append("   AND I.END_EFF_DATE >= @BEG_EFF_DATE");

                db.DbParametersClear();
                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WS_CD", _ws_cd);
                db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                //db.DbPsetInt("@END_EFF_DATE", _beg_eff_date);
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
                _pty_no = int.Parse(db.Row("PTY_NO"));
                _ws_cd = db.Row("WS_CD");
                _beg_eff_date = int.Parse(db.Row("BEG_EFF_DATE"));
                _end_eff_date = int.Parse(db.Row("END_EFF_DATE"));
                _rep_routine_item_no = db.Row("REP_ROUTINE_ITEM_NO");
                _rep_routine_ws_cd = db.Row("REP_ROUTINE_WS_CD");
                _insp_lt = double.Parse(db.Row("INSP_LT"));
                _disb_lt = int.Parse(db.Row("DISB_LT"));
                _plant_lt = int.Parse(db.Row("PLANT_LT"));
                _compl_whs = db.Row("COMPL_WHS");
                _semi_whs = db.Row("SEMI_WHS");
                _disb_whs = db.Row("DISB_WHS");
                _bond_semi_whs = db.Row("BOND_SEMI_WHS");
                _bond_disb_whs = db.Row("BOND_DISB_WHS");
                _idtag_unit_qty = double.Parse(db.Row("IDTAG_UNIT_QTY"));
                _idtag_print_flag = int.Parse(db.Row("IDTAG_PRINT_FLAG"));
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
                _compl_whs_name = db.Row("COMPL_WHS_DESC");
                _disb_whs_name = db.Row("DISB_WHS_DESC");
                _semi_whs_name = db.Row("SEMI_WHS_DESC");
                _bond_disb_whs_name = db.Row("BOND_DISB_WHS_DESC");
                _bond_semi_whs_name = db.Row("BOND_SEMI_WHS_DESC");
                _rep_routine_item_name = db.Row("REP_ROUTINE_ITEM_DESC");
                _rep_routine_ws_name = db.Row("REP_ROUTINE_WS_DESC");
                _item_name = db.Row("ITEM_DESC");
                _ws_name = db.Row("WS_DESC");
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }
        /// <summary>
        /// 入力品目コード、作業区コードにて品目作業場所マスタより、詳細の取得
        /// 
        /// 使用画面：MfgManJORlse
        /// </summary>
        public int GetItemWsDetail3()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("I.ITEM_NO,			I.PTY_NO,			    I.WS_CD,			    I.BEG_EFF_DATE,	");
            strSQL.Append("I.END_EFF_DATE,	    I.REP_ROUTINE_ITEM_NO,  I.REP_ROUTINE_WS_CD,    I.INSP_LT,	    ");
            strSQL.Append("I.DISB_LT,");//ADD 2008-10-8 LIU 
            strSQL.Append("I.PLANT_LT,	        I.COMPL_WHS,		I.SEMI_WHS,	        I.DISB_WHS,		        ");
            strSQL.Append("I.BOND_SEMI_WHS,	    I.BOND_DISB_WHS,	I.IDTAG_UNIT_QTY,   I.IDTAG_PRINT_FLAG,	    ");
            strSQL.Append("I.DATA_CHAR1,	    I.DATA_CHAR2,			                                        ");
            strSQL.Append("I.DATA_CHAR3,		I.DATA_CHAR4,		I.DATA_CHAR5,		I.DATA_CHAR6,			");
            strSQL.Append("I.DATA_CHAR7,		I.DATA_CHAR8,		I.DATA_CHAR9,		I.DATA_CHAR10,  		");
            strSQL.Append("I.DATA_NUM1,			I.DATA_NUM2,		I.DATA_NUM3,		I.DATA_NUM4,			");
            strSQL.Append("I.DATA_NUM5,			I.DATA_NUM6,		I.DATA_NUM7,		I.DATA_NUM8,			");
            strSQL.Append("I.DATA_NUM9,			I.DATA_NUM10,		I.DATA_FLAG1,		I.DATA_FLAG2,			");
            strSQL.Append("I.DATA_FLAG3,		I.DATA_FLAG4,		I.DATA_FLAG5,		I.DATA_FLAG6,			");
            strSQL.Append("I.DATA_FLAG7,		I.DATA_FLAG8,		I.DATA_FLAG9,		I.DATA_FLAG10,	    	");
            strSQL.Append("I.ENTRY_DATE,		I.CHG_DATE,			I.CHG_PGM,			I.CHG_USERID,			");
            strSQL.Append("I.UPDATE_CNTR,");
            strSQL.Append("W1.WHS_DESC AS COMPL_WHS_DESC, W2.WHS_DESC AS SEMI_WHS_DESC , W3.WHS_DESC AS DISB_WHS_DESC,");
            strSQL.Append("W4.WHS_DESC AS BOND_SEMI_WHS_DESC, W5.WHS_DESC AS BOND_DISB_WHS_DESC,");
            strSQL.Append("I1.ITEM_DESC AS ITEM_DESC, I2.ITEM_DESC AS REP_ROUTINE_ITEM_DESC,");
            strSQL.Append("M1.WS_DESC AS WS_DESC, M2.WS_DESC AS REP_ROUTINE_WS_DESC");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ITEM_WS_MASTER I, WAREHOUSE_MASTER W1,WAREHOUSE_MASTER W2, WAREHOUSE_MASTER W3,WAREHOUSE_MASTER W4,WAREHOUSE_MASTER W5, ");
                strSQL.Append(" ITEM_MASTER I1,ITEM_MASTER I2,WORKSHOP_MASTER M1,WORKSHOP_MASTER M2 ");
                strSQL.Append(" WHERE I.ITEM_NO            = :ITEM_NO       ");
                strSQL.Append("   AND I.WS_CD             = :WS_CD          ");
                //strSQL.Append("   AND I.BEG_EFF_DATE       <= :BEG_EFF_DATE ");
                //strSQL.Append("   AND I.END_EFF_DATE       >= :BEG_EFF_DATE ");
                strSQL.Append("   AND I.COMPL_WHS          = W1.WHS_CD(+)   ");
                strSQL.Append("   AND I.SEMI_WHS            = W2.WHS_CD(+)  ");
                strSQL.Append("   AND I.DISB_WHS            = W3.WHS_CD(+)  ");
                strSQL.Append("   AND I.BOND_SEMI_WHS       = W4.WHS_CD(+)  ");
                strSQL.Append("   AND I.BOND_DISB_WHS       = W5.WHS_CD(+)  ");
                strSQL.Append("   AND I.ITEM_NO             = I1.ITEM_NO(+) ");
                strSQL.Append("   AND I.REP_ROUTINE_ITEM_NO = I2.ITEM_NO(+) ");
                strSQL.Append("   AND I.WS_CD               = M1.WS_CD(+)   ");
                strSQL.Append("   AND I.REP_ROUTINE_WS_CD   = M2.WS_CD(+)   ");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WS_CD", _ws_cd);
            }
            else
            {
                strSQL.Append(" FROM ITEM_WS_MASTER I ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W1 ON I.COMPL_WHS = W1.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W2 ON I.SEMI_WHS = W2.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W3 ON I.DISB_WHS = W3.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W4 ON I.BOND_SEMI_WHS = W4.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W5 ON I.BOND_DISB_WHS = W5.WHS_CD");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER M1 ON I.WS_CD = M1.WS_CD");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER M2 ON I.REP_ROUTINE_WS_CD = M2.WS_CD");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I1 ON I.ITEM_NO = I1.ITEM_NO");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I2 ON I.REP_ROUTINE_ITEM_NO = I2.ITEM_NO");
                strSQL.Append(" WHERE I.ITEM_NO = @ITEM_NO");
                strSQL.Append("   AND I.WS_CD = @WS_CD");
                //strSQL.Append("   AND I.BEG_EFF_DATE <= @BEG_EFF_DATE");
                //strSQL.Append("   AND I.END_EFF_DATE >= @BEG_EFF_DATE");

                db.DbParametersClear();
                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WS_CD", _ws_cd);
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
                _pty_no = int.Parse(db.Row("PTY_NO"));
                _ws_cd = db.Row("WS_CD");
                _beg_eff_date = int.Parse(db.Row("BEG_EFF_DATE"));
                _end_eff_date = int.Parse(db.Row("END_EFF_DATE"));
                _rep_routine_item_no = db.Row("REP_ROUTINE_ITEM_NO");
                _rep_routine_ws_cd = db.Row("REP_ROUTINE_WS_CD");
                _insp_lt = double.Parse(db.Row("INSP_LT"));
                _disb_lt = int.Parse(db.Row("DISB_LT"));
                _plant_lt = int.Parse(db.Row("PLANT_LT"));
                _compl_whs = db.Row("COMPL_WHS");
                _semi_whs = db.Row("SEMI_WHS");
                _disb_whs = db.Row("DISB_WHS");
                _bond_semi_whs = db.Row("BOND_SEMI_WHS");
                _bond_disb_whs = db.Row("BOND_DISB_WHS");
                _idtag_unit_qty = double.Parse(db.Row("IDTAG_UNIT_QTY"));
                _idtag_print_flag = int.Parse(db.Row("IDTAG_PRINT_FLAG"));
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
                _compl_whs_name = db.Row("COMPL_WHS_DESC");
                _disb_whs_name = db.Row("DISB_WHS_DESC");
                _semi_whs_name = db.Row("SEMI_WHS_DESC");
                _bond_disb_whs_name = db.Row("BOND_DISB_WHS_DESC");
                _bond_semi_whs_name = db.Row("BOND_SEMI_WHS_DESC");
                _rep_routine_item_name = db.Row("REP_ROUTINE_ITEM_DESC");
                _rep_routine_ws_name = db.Row("REP_ROUTINE_WS_DESC");
                _item_name = db.Row("ITEM_DESC");
                _ws_name = db.Row("WS_DESC");
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// 入力品目コードにて品目作業場所一覧の取得
        /// 
        /// 使用画面：SrchItem_WS
        /// </summary>
        public DataSet GetItemWSList1()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();
            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("I.WS_CD,         W.WS_DESC ");
            //strSQL.Append("I.ITEM_NO,			I.PTY_NO,			    I.WS_CD,			    I.BEG_EFF_DATE,	            ");
            //strSQL.Append("I.END_EFF_DATE,	    I.REP_ROUTINE_ITEM_NO,  I.REP_ROUTINE_WS_CD,    I.INSP_LT,	                ");
            //strSQL.Append("I.DISB_LT,                                                                                       ");
            //strSQL.Append("I.PLANT_LT,	        I.COMPL_WHS,		I.SEMI_WHS,	        I.DISB_WHS,		                    ");
            //strSQL.Append("I.BOND_SEMI_WHS,	    I.BOND_DISB_WHS,		I.DATA_CHAR1,	I.DATA_CHAR2,			            ");
            //strSQL.Append("I.DATA_CHAR3,		I.DATA_CHAR4,		I.DATA_CHAR5,		I.DATA_CHAR6,			            ");
            //strSQL.Append("I.DATA_CHAR7,		I.DATA_CHAR8,		I.DATA_CHAR9,		I.DATA_CHAR10,  		            ");
            //strSQL.Append("I.DATA_NUM1,			I.DATA_NUM2,		I.DATA_NUM3,		I.DATA_NUM4,			            ");
            //strSQL.Append("I.DATA_NUM5,			I.DATA_NUM6,		I.DATA_NUM7,		I.DATA_NUM8,			            ");
            //strSQL.Append("I.DATA_NUM9,			I.DATA_NUM10,		I.DATA_FLAG1,		I.DATA_FLAG2,			            ");
            //strSQL.Append("I.DATA_FLAG3,		I.DATA_FLAG4,		I.DATA_FLAG5,		I.DATA_FLAG6,			            ");
            //strSQL.Append("I.DATA_FLAG7,		I.DATA_FLAG8,		I.DATA_FLAG9,		I.DATA_FLAG10,	    	            ");
            //strSQL.Append("I.ENTRY_DATE,		I.CHG_DATE,			I.CHG_PGM,			I.CHG_USERID,			            ");
            //strSQL.Append("I.UPDATE_CNTR,       W.WS_DESC                                                                   ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ITEM_WS_MASTER I, WORKSHOP_MASTER W,ITEM_MASTER IT ");
                strSQL.Append(" WHERE I.ITEM_NO            = :ITEM_NO           ");
                strSQL.Append("   AND W ON I.WS_CD=W.WS_CD(+)       ");
                if (_item_no != "")
                {
                    strSQL.Append("   AND I.ITEM_NO = IT.ITEM_NO(+)      ");

                    db.DbParametersClear();
                    db.DbPsetString("ITEM_NO", _item_no);
                }
            }
            else
            {
                strSQL.Append(" FROM ITEM_WS_MASTER I ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON I.WS_CD=W.WS_CD ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER IT ON I.ITEM_NO = IT.ITEM_NO");
                strSQL.Append(" WHERE 1=1 ");
                if (_item_no != "")
                {
                    strSQL.Append(" AND I.ITEM_NO = @ITEM_NO");
                    db.DbParametersClear();

                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_beg_eff_date != 0)
                {
                    strSQL.Append(" AND I.BEG_EFF_DATE <= @BEG_EFF_DATE");
                    db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                }
                if (_end_eff_date != 0)
                {
                    strSQL.Append(" AND I.END_EFF_DATE >= @END_EFF_DATE");
                    db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
                }
            }
            strSQL.Append(" ORDER BY  I.PTY_NO");
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

        // ADD BY UBIQ-SUO 2010/10/08 START
        /// <summary>
        /// 入力品目コードにて品目作業場所一覧の取得
        /// 
        /// 使用画面：OrdSOEntry
        /// </summary>
        public DataSet GetItemWSList2()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();
            //--- sql
            strSQL.Append("SELECT * ");                               
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ITEM_WS_MASTER ");                            
                if (_item_no != "")
                {                   
                    strSQL.Append(" WHERE ITEM_NO            = :ITEM_NO           ");  

                    db.DbParametersClear();
                    db.DbPsetString("ITEM_NO", _item_no);
                }
            }
            else
            {
                strSQL.Append(" FROM ITEM_WS_MASTER  ");             
                if (_item_no != "")
                {
                    strSQL.Append(" WHERE ITEM_NO = @ITEM_NO");
                    db.DbParametersClear();

                    db.DbPsetString("@ITEM_NO", _item_no);
                }
            }
            strSQL.Append(" ORDER BY  I.PTY_NO");
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
        // ADD BY UBIQ-SUO 2010/10/08 END
       
        // add by wanghui 2010/4/15 start
        /// <summary>
        /// 入力品目コード 優先No.の一番小さいにて品目作業場所マスタより、詳細の取得
        /// 
        /// 使用画面：OrdSOEntry
        /// </summary>
        public int GetItemWsDetail4()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT TOP 1 ");
            strSQL.Append("I.ITEM_NO,	I.PTY_NO, I.WS_CD, I.BEG_EFF_DATE,	");
            strSQL.Append("I.END_EFF_DATE  ,I.COMPL_WHS   ");     
          
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ITEM_WS_MASTER I");    
                strSQL.Append(" WHERE I.ITEM_NO            = :ITEM_NO");               
                strSQL.Append("   AND I.BEG_EFF_DATE       <= :BEG_EFF_DATE");
                strSQL.Append("   AND I.END_EFF_DATE       >= :BEG_EFF_DATE");
                strSQL.Append("  ORDER BY I.PTY_NO ");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);               
                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
            }
            else
            {
                strSQL.Append(" FROM ITEM_WS_MASTER I ");                
                strSQL.Append(" WHERE I.ITEM_NO = @ITEM_NO");               
                strSQL.Append("   AND I.BEG_EFF_DATE <= @BEG_EFF_DATE");
                strSQL.Append("   AND I.END_EFF_DATE >= @BEG_EFF_DATE");
                strSQL.Append(" ORDER BY  I.PTY_NO");
         

                db.DbParametersClear();
                db.DbPsetString("@ITEM_NO", _item_no);                
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
                _pty_no = int.Parse(db.Row("PTY_NO"));
                _ws_cd = db.Row("WS_CD");
                _compl_whs = db.Row("COMPL_WHS");
                
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        // add by wanghui 2010/4/15 end
    }
}
