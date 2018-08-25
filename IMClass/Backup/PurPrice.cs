using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// 購入単価クラス
/// </summary>
namespace IMClass
{
    public class PurPrice
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public PurPrice()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public PurPrice(string p_user_id, int p_lang)
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
        protected string _ws_cd = "";
        protected string _process_cd = "";
        protected string _vendor_cd = "";
        protected int _beg_eff_date = 0;
        protected int _end_eff_date = 0;
        protected int _unit_prc_type = 0;
        protected int _unit_prc_base = 0;
        protected int _com_prc_flag = 0;
        protected double _tentative_prc = 0;
        protected string _tentative_cur = "";
        protected double _act_prc = 0;
        protected string _act_cur = "";
        protected double _duty_pct = 0;
        protected int _tax_type = 0;
        protected string _tax_cd = "";
        protected double _value_add_tax_pct = 0;
        protected string _pay_terms = "";

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

        protected string _item_desc = "";
        protected string _vendor_name = "";
        protected string _check_flag = "";


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
        public string ws_cd { get { return _ws_cd; } set { _ws_cd = value; } }
        public string process_cd { get { return _process_cd; } set { _process_cd = value; } }
        public string vendor_cd { get { return _vendor_cd; } set { _vendor_cd = value; } }
        public int beg_eff_date { get { return _beg_eff_date; } set { _beg_eff_date = value; } }
        public int end_eff_date { get { return _end_eff_date; } set { _end_eff_date = value; } }
        public int unit_prc_type { get { return _unit_prc_type; } set { _unit_prc_type = value; } }
        public int unit_prc_base { get { return _unit_prc_base; } set { _unit_prc_base = value; } }
        public int com_prc_flag { get { return _com_prc_flag; } set { _com_prc_flag = value; } }
        public double tentative_prc { get { return _tentative_prc; } set { _tentative_prc = value; } }
        public string tentative_cur { get { return _tentative_cur; } set { _tentative_cur = value; } }
        public double act_prc { get { return _act_prc; } set { _act_prc = value; } }
        public string act_cur { get { return _act_cur; } set { _act_cur = value; } }
        public double duty_pct { get { return _duty_pct; } set { _duty_pct = value; } }
        public int tax_type { get { return _tax_type; } set { _tax_type = value; } }
        public string tax_cd { get { return _tax_cd; } set { _tax_cd = value; } }
        public double value_add_tax_pct { get { return _value_add_tax_pct; } set { _value_add_tax_pct = value; } }
        public string pay_terms { get { return _pay_terms; } set { _pay_terms = value; } }
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

        public string item_desc { get { return _item_desc; } set { _item_desc = value; } }
        public string vendor_name { get { return _vendor_name; } set { _vendor_name = value; } }
        public string check_flag { get { return _check_flag; } set { _check_flag = value; } }

        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }
        #endregion

        /// <summary>
        /// 購入単価の追加
        /// 
        /// 使用画面：MstPurPriceMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);

            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_BEG_EFF_DATE", _beg_eff_date, ComConst.DB_IN);
            db.DbPsetInt("@I_END_EFF_DATE", _end_eff_date, ComConst.DB_IN);
            db.DbPsetInt("@I_UNIT_PRC_TYPE", _unit_prc_type, ComConst.DB_IN);
            db.DbPsetInt("@I_UNIT_PRC_BASE", _unit_prc_base, ComConst.DB_IN);
            db.DbPsetInt("@I_COM_PRC_FLAG", _com_prc_flag, ComConst.DB_IN);
            db.DbPsetDouble("@I_TENTATIVE_PRC", _tentative_prc, ComConst.DB_IN);
            db.DbPsetString("@I_TENTATIVE_CUR", _tentative_cur, ComConst.DB_IN);
            db.DbPsetDouble("@I_ACT_PRC", _act_prc, ComConst.DB_IN);
            db.DbPsetString("@I_ACT_CUR", _act_cur, ComConst.DB_IN);
            db.DbPsetDouble("@I_DUTY_PCT", _duty_pct, ComConst.DB_IN);
            db.DbPsetInt("@I_TAX_TYPE", _tax_type, ComConst.DB_IN);
            db.DbPsetString("@I_TAX_CD", _tax_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_VALUE_ADD_TAX_PCT", _value_add_tax_pct, ComConst.DB_IN);
            db.DbPsetString("@I_PAY_TERMS", _pay_terms, ComConst.DB_IN);

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
            rtn = db.DbStored("SP_PURCHASE_PRICE_INSERT");
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
        /// 購入単価の変更
        /// 
        /// 使用画面：MstPurPriceMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_BEG_EFF_DATE", _beg_eff_date, ComConst.DB_IN);
            db.DbPsetInt("@I_END_EFF_DATE", _end_eff_date, ComConst.DB_IN);
            db.DbPsetInt("@I_UNIT_PRC_TYPE", _unit_prc_type, ComConst.DB_IN);
            db.DbPsetInt("@I_UNIT_PRC_BASE", _unit_prc_base, ComConst.DB_IN);
            db.DbPsetInt("@I_COM_PRC_FLAG", _com_prc_flag, ComConst.DB_IN);
            db.DbPsetDouble("@I_TENTATIVE_PRC", _tentative_prc, ComConst.DB_IN);
            db.DbPsetString("@I_TENTATIVE_CUR", _tentative_cur, ComConst.DB_IN);
            db.DbPsetDouble("@I_ACT_PRC", _act_prc, ComConst.DB_IN);
            db.DbPsetString("@I_ACT_CUR", _act_cur, ComConst.DB_IN);
            db.DbPsetDouble("@I_DUTY_PCT", _duty_pct, ComConst.DB_IN);
            db.DbPsetInt("@I_TAX_TYPE", _tax_type, ComConst.DB_IN);
            db.DbPsetString("@I_TAX_CD", _tax_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_VALUE_ADD_TAX_PCT", _value_add_tax_pct, ComConst.DB_IN);
            db.DbPsetString("@I_PAY_TERMS", _pay_terms, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_PURCHASE_PRICE_UPDATE");
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
        /// 購入単価の削除
        /// 
        /// 使用画面：MstPurPriceMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_PURCHASE_PRICE_DELETE");
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
        /// 購入単価一覧の取得
        /// 
        /// 使用画面：MstPurPriceMnt
        /// </summary>
        public DataSet GetPurPriceList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql

            strSQL.Append("SELECT                                                                                           ");
            strSQL.Append("P1.ITEM_NO,			I.ITEM_DESC,        P.PROCESS_CD,				                            ");
            strSQL.Append("P.BEG_EFF_DATE,		P.END_EFF_DATE,		P.UNIT_PRC_TYPE,	P.UNIT_PRC_BASE,	P.COM_PRC_FLAG, ");
            strSQL.Append("P.TENTATIVE_PRC,	    P.TENTATIVE_CUR,	P.ACT_PRC,	        P.ACT_CUR,		                    ");
            strSQL.Append("P.DUTY_PCT,	        P.TAX_TYPE,		    P.TAX_CD,		    P.VALUE_ADD_TAX_PCT,			    ");
            strSQL.Append("P.PAY_TERMS,	        P.DATA_CHAR1,		P.DATA_CHAR2,			                                ");
            strSQL.Append("P.DATA_CHAR3,		P.DATA_CHAR4,		P.DATA_CHAR5,		P.DATA_CHAR6,			            ");
            strSQL.Append("P.DATA_CHAR7,		P.DATA_CHAR8,		P.DATA_CHAR9,		P.DATA_CHAR10,  		            ");
            strSQL.Append("P.DATA_NUM1,			P.DATA_NUM2,		P.DATA_NUM3,		P.DATA_NUM4,			            ");
            strSQL.Append("P.DATA_NUM5,			P.DATA_NUM6,		P.DATA_NUM7,		P.DATA_NUM8,			            ");
            strSQL.Append("P.DATA_NUM9,			P.DATA_NUM10,		P.DATA_FLAG1,		P.DATA_FLAG2,			            ");
            strSQL.Append("P.DATA_FLAG3,		P.DATA_FLAG4,		P.DATA_FLAG5,		P.DATA_FLAG6,			            ");
            strSQL.Append("P.DATA_FLAG7,		P.DATA_FLAG8,		P.DATA_FLAG9,		P.DATA_FLAG10,	    	            ");
            strSQL.Append("P.ENTRY_DATE,		P.CHG_DATE,			P.CHG_PGM,			P.CHG_USERID,			            ");
            strSQL.Append("P.UPDATE_CNTR,                                                                                   ");
            strSQL.Append(" '*' AS WS_CD,		P1.VENDOR_CD,		V.VENDOR_NAME,  P1.PTY_NO,  P.VENDOR_CD,    P.BEG_EFF_DATE, ");
            strSQL.Append(" '*' AS WS_DESC ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PURCHASE_PRICE_MASTER P, PURCHASE_MASTER P1 ,VENDOR_MASTER V,ITEM_MASTER I ");
                strSQL.Append(" WHERE P1.ITEM_NO = P.ITEM_NO(+) AND P1.BEG_EFF_DATE = P.BEG_EFF_DATE(+)");
                strSQL.Append(" AND P1.VENDOR_CD = V.VENDOR_CD(+) ");
                strSQL.Append(" AND I.ITEM_NO = P1.ITEM_NO ");
                strSQL.Append(" AND I.ITEM_TYPE >= '52' ");
                strSQL.Append(" AND P.ITEM_NO       = :ITEM_NO");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);
            }
            else
            {
                strSQL.Append(" FROM PURCHASE_MASTER P1                         ");
                strSQL.Append(" LEFT OUTER JOIN PURCHASE_PRICE_MASTER P         ");
                strSQL.Append("     ON P1.ITEM_NO = P.ITEM_NO                   ");
                strSQL.Append("     AND P1.VENDOR_CD = P.VENDOR_CD              ");
                strSQL.Append("     AND P.WS_CD = '*'                           ");
                strSQL.Append(" LEFT OUTER JOIN  VENDOR_MASTER V                ");
                strSQL.Append("     ON P1.VENDOR_CD = V.VENDOR_CD               ");
                strSQL.Append(" LEFT OUTER JOIN  ITEM_MASTER I                  ");
                strSQL.Append("     ON P1.ITEM_NO = I.ITEM_NO                   ");
                strSQL.Append(" WHERE P1.ITEM_NO = @ITEM_NO                     ");
                strSQL.Append("     AND I.ITEM_TYPE >= '52'                     ");

                db.DbParametersClear();
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            strSQL.Append(" UNION                                                                                           ");
            strSQL.Append(" SELECT                                                                                          ");
            strSQL.Append("IW.ITEM_NO,			I.ITEM_DESC,        P.PROCESS_CD,					                        ");
            strSQL.Append("P.BEG_EFF_DATE,		P.END_EFF_DATE,		P.UNIT_PRC_TYPE,	P.UNIT_PRC_BASE,	P.COM_PRC_FLAG, ");
            strSQL.Append("P.TENTATIVE_PRC,	    P.TENTATIVE_CUR,	P.ACT_PRC,	        P.ACT_CUR,		                    ");
            strSQL.Append("P.DUTY_PCT,	        P.TAX_TYPE,		    P.TAX_CD,		    P.VALUE_ADD_TAX_PCT,			    ");
            strSQL.Append("P.PAY_TERMS,	        P.DATA_CHAR1,		P.DATA_CHAR2,			                                ");
            strSQL.Append("P.DATA_CHAR3,		P.DATA_CHAR4,		P.DATA_CHAR5,		P.DATA_CHAR6,			");
            strSQL.Append("P.DATA_CHAR7,		P.DATA_CHAR8,		P.DATA_CHAR9,		P.DATA_CHAR10,  		");
            strSQL.Append("P.DATA_NUM1,			P.DATA_NUM2,		P.DATA_NUM3,		P.DATA_NUM4,			");
            strSQL.Append("P.DATA_NUM5,			P.DATA_NUM6,		P.DATA_NUM7,		P.DATA_NUM8,			");
            strSQL.Append("P.DATA_NUM9,			P.DATA_NUM10,		P.DATA_FLAG1,		P.DATA_FLAG2,			");
            strSQL.Append("P.DATA_FLAG3,		P.DATA_FLAG4,		P.DATA_FLAG5,		P.DATA_FLAG6,			");
            strSQL.Append("P.DATA_FLAG7,		P.DATA_FLAG8,		P.DATA_FLAG9,		P.DATA_FLAG10,	    	");
            strSQL.Append("P.ENTRY_DATE,		P.CHG_DATE,			P.CHG_PGM,			P.CHG_USERID,			");
            strSQL.Append("P.UPDATE_CNTR,                                                                       ");
            strSQL.Append("IW.WS_CD,            P1.VENDOR_CD,	    V.VENDOR_NAME,      P1.PTY_NO,              ");             
            strSQL.Append("P.VENDOR_CD,         P.BEG_EFF_DATE,     WS.WS_DESC                                  ");//UPD UBIQ-LIU 2010/05/25 [WS_DESC]ADD
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM    ITEM_WS_MASTER IW,   PURCHASE_PRICE_MASTER P,	PURCHASE_MASTER P1 ,VENDOR_MASTER V,ITEM_MASTER	I ");
                strSQL.Append(" WHERE 	IW.ITEM_NO = P1.ITEM_NO AND AND IW.PTY_NO = P1.PTY_NO ");
                strSQL.Append(" AND     IW.BEG_EFF_DATE <= P1.BEG_EFF_DATE AND IW.END_EFF_DATE >= P1.BEG_EFF_DATE ");
                strSQL.Append(" AND     IW.ITEM_NO = I.ITEM_NO ");
                strSQL.Append(" AND     IW.ITEM_NO       = :ITEM_NO");
                strSQL.Append(" AND     I.ITEM_TYPE <= '51' ");

            }
            else
            {
                strSQL.Append(" FROM ITEM_WS_MASTER IW                                              ");
                strSQL.Append(" INNER JOIN PURCHASE_MASTER P1 ON IW.ITEM_NO = P1.ITEM_NO            ");
                strSQL.Append("         AND IW.PTY_NO = P1.PTY_NO                                   ");
                strSQL.Append("         AND IW.BEG_EFF_DATE <= P1.BEG_EFF_DATE                      ");
                strSQL.Append("         AND IW.END_EFF_DATE >= P1.BEG_EFF_DATE                      ");
                strSQL.Append(" LEFT OUTER JOIN  VENDOR_MASTER V  ON P1.VENDOR_CD = V.VENDOR_CD     ");
                strSQL.Append(" LEFT OUTER JOIN  ITEM_MASTER I ON    IW.ITEM_NO = I.ITEM_NO         ");
                strSQL.Append(" LEFT OUTER JOIN PURCHASE_PRICE_MASTER P  ON IW.ITEM_NO = P.ITEM_NO  ");
                strSQL.Append("         AND IW.WS_CD = P.WS_CD                                      ");
                strSQL.Append("         AND P1.VENDOR_CD = P.VENDOR_CD                              ");
                strSQL.Append(" LEFT OUTER JOIN  WORKSHOP_MASTER WS   ON WS.WS_CD = IW.WS_CD        ");//ADD UBIQ-LIU 2010/05/25
                strSQL.Append(" WHERE IW.ITEM_NO = @ITEM_NO                                         ");
                strSQL.Append("         AND I.ITEM_TYPE <= '51'                                     ");

            }
            strSQL.Append(" ORDER BY  P1.PTY_NO,P.VENDOR_CD,P.BEG_EFF_DATE   ");//2009.03.04 add 

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
        /// 購入単価詳細の取得
        /// 
        /// 使用画面：MstPurPriceMnt
        /// </summary>
        public int GetPurPriceDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT ");
            //strSQL.Append("P.ITEM_NO,			P.WS_CD,			P.PROCESS_CD,		P.VENDOR_CD,	P.BEG_EFF_DATE,");
            strSQL.Append("P.END_EFF_DATE,		P.UNIT_PRC_TYPE,	P.UNIT_PRC_BASE,	P.COM_PRC_FLAG,");
            strSQL.Append("P.TENTATIVE_PRC,	    P.TENTATIVE_CUR,	P.ACT_PRC,	        P.ACT_CUR,		");
            strSQL.Append("P.DUTY_PCT,	        P.TAX_TYPE,		    P.TAX_CD,		    P.VALUE_ADD_TAX_PCT,			");
            strSQL.Append("P.PAY_TERMS,	        P.DATA_CHAR1,		P.DATA_CHAR2,			");
            strSQL.Append("P.DATA_CHAR3,		P.DATA_CHAR4,		P.DATA_CHAR5,		P.DATA_CHAR6,			");
            strSQL.Append("P.DATA_CHAR7,		P.DATA_CHAR8,		P.DATA_CHAR9,		P.DATA_CHAR10,  		");
            strSQL.Append("P.DATA_NUM1,			P.DATA_NUM2,		P.DATA_NUM3,		P.DATA_NUM4,			");
            strSQL.Append("P.DATA_NUM5,			P.DATA_NUM6,		P.DATA_NUM7,		P.DATA_NUM8,			");
            strSQL.Append("P.DATA_NUM9,			P.DATA_NUM10,		P.DATA_FLAG1,		P.DATA_FLAG2,			");
            strSQL.Append("P.DATA_FLAG3,		P.DATA_FLAG4,		P.DATA_FLAG5,		P.DATA_FLAG6,			");
            strSQL.Append("P.DATA_FLAG7,		P.DATA_FLAG8,		P.DATA_FLAG9,		P.DATA_FLAG10,	    	");
            strSQL.Append("P.ENTRY_DATE,		P.CHG_DATE,			P.CHG_PGM,			P.CHG_USERID,			");
            strSQL.Append("P.UPDATE_CNTR,");
            strSQL.Append("I.ITEM_DESC ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PURCHASE_PRICE_MASTER P, ITEM_MASTER I ");
                strSQL.Append(" WHERE P.ITEM_NO       = :ITEM_NO");
                strSQL.Append("   AND P.WS_CD         = :WS_CD");
                strSQL.Append("   AND P.PROCESS_CD    = :PROCESS_CD");
                strSQL.Append("   AND P.VENDOR_CD     = :VENDOR_CD");
                strSQL.Append("   AND P.BEG_EFF_DATE  = :BEG_EFF_DATE");
                strSQL.Append("   AND P.ITEM_NO  = I.ITEM_NO");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WS_CD", _ws_cd);
                db.DbPsetString("PROCESS_CD", _process_cd);
                db.DbPsetString("VENDOR_CD", _vendor_cd);
                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM PURCHASE_PRICE_MASTER P ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON P.ITEM_NO  = I.ITEM_NO ");
                strSQL.Append(" WHERE P.ITEM_NO = @ITEM_NO");
                strSQL.Append("   AND P.WS_CD         = @WS_CD");
                strSQL.Append("   AND P.PROCESS_CD    = @PROCESS_CD");
                strSQL.Append("   AND P.VENDOR_CD     = @VENDOR_CD");
                strSQL.Append("   AND P.BEG_EFF_DATE  = @BEG_EFF_DATE");

                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WS_CD", _ws_cd);
                db.DbPsetString("@PROCESS_CD", _process_cd);
                db.DbPsetString("@VENDOR_CD", _vendor_cd);
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
                //_item_no = db.Row("ITEM_NO");
                //_ws_cd = db.Row("WS_CD");
                //_process_cd = db.Row("PROCESS_CD");
                //_vendor_cd = db.Row("VENDOR_CD");
                //_beg_eff_date = int.Parse(db.Row("BEG_EFF_DATE"));
                _end_eff_date = int.Parse(db.Row("END_EFF_DATE"));
                _unit_prc_type = int.Parse(db.Row("UNIT_PRC_TYPE"));
                _unit_prc_base = int.Parse(db.Row("UNIT_PRC_BASE"));
                _com_prc_flag = int.Parse(db.Row("COM_PRC_FLAG"));
                _tentative_prc = double.Parse(db.Row("TENTATIVE_PRC"));
                _tentative_cur = db.Row("TENTATIVE_CUR");
                _act_prc = double.Parse(db.Row("ACT_PRC"));
                _act_cur = db.Row("ACT_CUR");
                _duty_pct = double.Parse(db.Row("DUTY_PCT"));
                _tax_type = int.Parse(db.Row("TAX_TYPE"));
                _tax_cd = db.Row("TAX_CD");
                _value_add_tax_pct = double.Parse(db.Row("VALUE_ADD_TAX_PCT"));
                _pay_terms = db.Row("PAY_TERMS");
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

            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }
        /// <summary>
        /// 購入単価一覧の取得
        /// 
        /// 使用画面：MstItemMnt
        /// </summary>
        public DataSet GetPurPriceList_Item()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                               ");
            strSQL.Append("P.ITEM_NO,			P.PROCESS_CD,	    P.VENDOR_CD,		P.WS_CD,        	    ");
            strSQL.Append("P.BEG_EFF_DATE,		P.END_EFF_DATE,     P.UNIT_PRC_TYPE,	P.UNIT_PRC_BASE,        ");
            strSQL.Append("P.TENTATIVE_PRC,	    P.TENTATIVE_CUR,	P.ACT_PRC,	        P.ACT_CUR,		        ");
            strSQL.Append("P.DUTY_PCT,	        P.TAX_TYPE,		    P.TAX_CD,		    P.VALUE_ADD_TAX_PCT,    ");
            strSQL.Append("P.ENTRY_DATE,		P.CHG_DATE,			P.CHG_PGM,			P.CHG_USERID,			");
            strSQL.Append("P.UPDATE_CNTR,	    P.COM_PRC_FLAG,     WS.WS_DESC,         P.PAY_TERMS,            ");
            strSQL.Append("P.DATA_CHAR1,		P.DATA_CHAR2,					                                ");//ADD BY UBIQ-LIU 2010/5/24
            strSQL.Append("P.DATA_CHAR3,		P.DATA_CHAR4,		P.DATA_CHAR5,		P.DATA_CHAR6,			");
            strSQL.Append("P.DATA_CHAR7,		P.DATA_CHAR8,		P.DATA_CHAR9,		P.DATA_CHAR10,  		");
            strSQL.Append("P.DATA_NUM1,			P.DATA_NUM2,		P.DATA_NUM3,		P.DATA_NUM4,			");
            strSQL.Append("P.DATA_NUM5,			P.DATA_NUM6,		P.DATA_NUM7,		P.DATA_NUM8,			");
            strSQL.Append("P.DATA_NUM9,			P.DATA_NUM10,		P.DATA_FLAG1,		P.DATA_FLAG2,			");
            strSQL.Append("P.DATA_FLAG3,		P.DATA_FLAG4,		P.DATA_FLAG5,		P.DATA_FLAG6,			");
            strSQL.Append("P.DATA_FLAG7,		P.DATA_FLAG8,		P.DATA_FLAG9,		P.DATA_FLAG10,	    	");//ADD BY UBIQ-LIU 2010/5/24
            strSQL.Append("V.VENDOR_NAME,       S.DATA_CHAR AS T_CUR_NAME, S1.DATA_CHAR AS ACT_CUR_NAME         ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PURCHASE_PRICE_MASTER P                                        ");
                strSQL.Append(" LEFT OUTER JOIN  WORKSHOP_MASTER WS ON P.WS_CD      =   WS.WS_CD    ");
                strSQL.Append(" LEFT OUTER JOIN  VENDOR_MASTER V                                    ");
                strSQL.Append(" ON P.VENDOR_CD = V.VENDOR_CD                                        ");
                strSQL.Append(" WHERE P.ITEM_NO = @ITEM_NO                                          ");

                db.DbParametersClear();
                db.DbPsetString("@ITEM_NO", _item_no);

                if (check_flag == "1")
                {
                    strSQL.Append("   AND P.WS_CD         = :WS_CD                  ");
                    strSQL.Append("   AND P.PROCESS_CD    = :PROCESS_CD             ");
                    strSQL.Append("   AND P.VENDOR_CD     = :VENDOR_CD              ");
                    strSQL.Append("   AND P.BEG_EFF_DATE <= :END_EFF_DATE           ");
                    strSQL.Append("   AND P.END_EFF_DATE >= :BEG_EFF_DATE           ");
                    strSQL.Append("   AND P.BEG_EFF_DATE <> :END_EFF_DATE           ");

                    db.DbPsetString("WS_CD", _ws_cd);
                    db.DbPsetString("PROCESS_CD", _process_cd);
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                    db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                    db.DbPsetInt("END_EFF_DATE", _end_eff_date);
                }
                else if (check_flag == "2")
                {
                    strSQL.Append("   AND P.WS_CD         = :WS_CD                  ");
                    strSQL.Append("   AND P.PROCESS_CD    = :PROCESS_CD             ");
                    strSQL.Append("   AND P.VENDOR_CD     = :VENDOR_CD              ");
                    strSQL.Append("   AND P.BEG_EFF_DATE <= :END_EFF_DATE           ");
                    strSQL.Append("   AND P.END_EFF_DATE >= :BEG_EFF_DATE           ");

                    db.DbPsetString("WS_CD", _ws_cd);
                    db.DbPsetString("PROCESS_CD", _process_cd);
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                    db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                    db.DbPsetInt("END_EFF_DATE", _end_eff_date);
                }
                else
                {
                    strSQL.Append(" AND P.BEG_EFF_DATE <= :BEG_EFF_DATE                                 ");
                    strSQL.Append(" AND P.END_EFF_DATE >= :END_EFF_DATE                                 ");
                    db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                    db.DbPsetInt("END_EFF_DATE", _end_eff_date);
                }
            }
            else
            {
                strSQL.Append(" FROM PURCHASE_PRICE_MASTER P                                                            ");
                strSQL.Append(" LEFT OUTER JOIN  WORKSHOP_MASTER WS ON P.WS_CD      =   WS.WS_CD                        ");
                strSQL.Append(" LEFT JOIN   SYSTEM_PARAMETER S ON P.TENTATIVE_CUR=S.KEY02 AND  S.KEY01='CURRENCY_CD'    ");
                strSQL.Append(" LEFT JOIN   SYSTEM_PARAMETER S1 ON P.ACT_CUR=S1.KEY02 AND  S1.KEY01='CURRENCY_CD'       ");
                strSQL.Append(" LEFT OUTER JOIN  VENDOR_MASTER V                                                        ");
                strSQL.Append(" ON P.VENDOR_CD = V.VENDOR_CD                                                            ");
                strSQL.Append(" WHERE P.ITEM_NO = @ITEM_NO                                                              ");
                
                db.DbParametersClear();
                db.DbPsetString("@ITEM_NO", _item_no);
                                
                if (check_flag == "1")
                {
                    strSQL.Append("   AND P.WS_CD         = @WS_CD                  ");
                    strSQL.Append("   AND P.PROCESS_CD    = @PROCESS_CD             ");
                    strSQL.Append("   AND P.VENDOR_CD     = @VENDOR_CD              ");
                    strSQL.Append("   AND P.BEG_EFF_DATE  < @BEG_EFF_DATE           ");//UPD UBIQ-LIU 2010/05/25 "<="→"<"
                    strSQL.Append("   AND P.END_EFF_DATE >= @END_EFF_DATE           ");
                    //strSQL.Append("   AND P.BEG_EFF_DATE <> @BEG_EFF_DATE           ");//DEL BY UBIQ-LIU 2010/5/25

                    db.DbPsetString("@WS_CD", _ws_cd);
                    db.DbPsetString("@PROCESS_CD", _process_cd);
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                    db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                    db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
                }
                else if (check_flag == "2")
                {
                    strSQL.Append("   AND P.WS_CD         = @WS_CD                  ");
                    strSQL.Append("   AND P.PROCESS_CD    = @PROCESS_CD             ");
                    strSQL.Append("   AND P.VENDOR_CD     = @VENDOR_CD              ");
                    strSQL.Append("   AND P.BEG_EFF_DATE <= @END_EFF_DATE           ");
                    strSQL.Append("   AND P.END_EFF_DATE >= @BEG_EFF_DATE           ");

                    db.DbPsetString("@WS_CD", _ws_cd);
                    db.DbPsetString("@PROCESS_CD", _process_cd);
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                    db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                    db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
                }
                else if (check_flag == "3")
                {
                    strSQL.Append(" AND P.BEG_EFF_DATE <= @BEG_EFF_DATE             ");
                    strSQL.Append(" AND P.END_EFF_DATE >= @END_EFF_DATE             ");
                    strSQL.Append(" AND P.VENDOR_CD     = @VENDOR_CD                ");
                    db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                    db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                }
                else// 使用画面：[MstItemEntry]
                {
                    if (_beg_eff_date != 0)
                    {
                        strSQL.Append(" AND P.BEG_EFF_DATE <= @BEG_EFF_DATE             ");
                        db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                    }
                    if (_end_eff_date != 0)
                    {
                        strSQL.Append(" AND P.END_EFF_DATE >= @END_EFF_DATE             ");
                        db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
                    }
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
        
    }
}
