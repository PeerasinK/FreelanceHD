using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// 倉庫クラス
/// </summary>
namespace IMClass
{
    public class Warehouse
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Warehouse()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Warehouse(string p_user_id, int p_lang)
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
        protected string _whs_cd = "";
        protected string _mrp_whs = "";
        protected string _whs_desc = "";
        protected string _whs_desc2 = "";
        protected string _recv_loc = "";
        protected int _whs_type	= 0;
        protected int _whs_item_type = 0;
        protected int _location_ctrl_flag = 0;
        protected int _auto_housing_type = 0;
        protected int _direct_ship_flag = 0;
        protected string _vendor_cd = "";
        protected int _cons_whs_flag = 0;
        protected string _cons_vendor_cd = "";
        protected string _pass_thru_whs_cd = "";
        protected int _bond_flag = 0;
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

        protected string _mrp_whs_desc = "";
        protected string _vendor_name = "";
        protected string _cons_vendor_name = "";
        protected string _pass_thru_whs_desc = "";

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

        protected int _supply_type;//ADD UBIQ-LIU 2010/05/26 支給区分の追加
        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        public int lang        {            get { return _lang; }            set { _lang = value; }        }
        public string whs_cd        {            get { return _whs_cd; }            set { _whs_cd = value; }        }
        public string mrp_whs        {            get { return _mrp_whs; }            set { _mrp_whs = value; }        }
        public string whs_desc        {            get { return _whs_desc; }            set { _whs_desc = value; }        }
        public string whs_desc2        {            get { return _whs_desc2; }            set { _whs_desc2 = value; }        }
        public string recv_loc        {            get { return _recv_loc; }            set { _recv_loc = value; }        }
        public int whs_type        {            get { return _whs_type; }            set { _whs_type = value; }        }
        public int whs_item_type        {            get { return _whs_item_type; }            set { _whs_item_type = value; }        }
        public int location_ctrl_flag { get { return _location_ctrl_flag; } set { _location_ctrl_flag = value; } }
        public int auto_housing_type { get { return _auto_housing_type; } set { _auto_housing_type = value; } }
        public int direct_ship_flag { get { return _direct_ship_flag; } set { _direct_ship_flag = value; } }
        public string vendor_cd        {            get { return _vendor_cd; }            set { _vendor_cd = value; }        }
        public int cons_whs_flag        {            get { return _cons_whs_flag; }            set { _cons_whs_flag = value; }        }
        public string cons_vendor_cd        {            get { return _cons_vendor_cd; }            set { _cons_vendor_cd = value; }        }
        public string pass_thru_whs_cd        {            get { return _pass_thru_whs_cd; }            set { _pass_thru_whs_cd = value; }        }
        public int bond_flag        {            get { return _bond_flag; }            set { _bond_flag = value; }        }
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

        public string mrp_whs_desc { get { return _mrp_whs_desc; } set { _mrp_whs_desc = value; } }
        public string vendor_name { get { return _vendor_name; } set { _vendor_name = value; } }
        public string cons_vendor_name { get { return _cons_vendor_name; } set { _cons_vendor_name = value; } }
        public string pass_thru_whs_desc { get { return _pass_thru_whs_desc; } set { _pass_thru_whs_desc = value; } }
        
        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date        {            get { return _chg_date; }            set { _chg_date = value; }        }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }

        public int supply_type { get { return _supply_type; } set { _supply_type = value; } }
        #endregion

        /// <summary>
        /// 倉庫の追加
        /// 
        /// 使用画面：MstWhsMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_MRP_WHS", _mrp_whs, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_DESC", _whs_desc, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_DESC2", _whs_desc2, ComConst.DB_IN);
            db.DbPsetString("@I_RECV_LOC", _recv_loc, ComConst.DB_IN);
            db.DbPsetInt("@I_WHS_TYPE", _whs_type, ComConst.DB_IN);
            db.DbPsetInt("@I_WHS_ITEM_TYPE", _whs_item_type, ComConst.DB_IN);
            db.DbPsetInt("@I_LOCATION_CTRL_FLAG", _location_ctrl_flag, ComConst.DB_IN);
            db.DbPsetInt("@I_AUTO_HOUSING_TYPE", _auto_housing_type, ComConst.DB_IN);
            db.DbPsetInt("@I_DIRECT_SHIP_FLAG", _direct_ship_flag, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_SUPPLY_TYPE", _supply_type, ComConst.DB_IN);//ADD UBIQ-LIU 2010/05/26
            db.DbPsetInt("@I_CONS_WHS_FLAG", _cons_whs_flag, ComConst.DB_IN);
            db.DbPsetString("@I_CONS_VENDOR_CD", _cons_vendor_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PASS_THRU_WHS_CD", _pass_thru_whs_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_BOND_FLAG", _bond_flag, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_WAREHOUSE_INSERT");
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
        /// 倉庫の変更
        /// 
        /// 使用画面：MstWhsMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_MRP_WHS", _mrp_whs, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_DESC", _whs_desc, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_DESC2", _whs_desc2, ComConst.DB_IN);
            db.DbPsetString("@I_RECV_LOC", _recv_loc, ComConst.DB_IN);
            db.DbPsetInt("@I_WHS_TYPE", _whs_type, ComConst.DB_IN);
            db.DbPsetInt("@I_WHS_ITEM_TYPE", _whs_item_type, ComConst.DB_IN);
            db.DbPsetInt("@I_LOCATION_CTRL_FLAG", _location_ctrl_flag, ComConst.DB_IN);
            db.DbPsetInt("@I_AUTO_HOUSING_TYPE", _auto_housing_type, ComConst.DB_IN);
            db.DbPsetInt("@I_DIRECT_SHIP_FLAG", _direct_ship_flag, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_SUPPLY_TYPE", _supply_type, ComConst.DB_IN);//ADD UBIQ-LIU 2010/05/26
            db.DbPsetInt("@I_CONS_WHS_FLAG", _cons_whs_flag, ComConst.DB_IN);
            db.DbPsetString("@I_CONS_VENDOR_CD", _cons_vendor_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PASS_THRU_WHS_CD", _pass_thru_whs_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_BOND_FLAG", _bond_flag, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_WAREHOUSE_UPDATE");
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
        /// 倉庫の削除
        /// 
        /// 使用画面：MstWhsMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_WAREHOUSE_DELETE");
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
        /// 倉庫一覧の取得

        /// 
        /// 使用画面：MstWhsMnt
        /// </summary>
        public DataSet GetWarehosueList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("WHS_CD,				MRP_WHS,			WHS_DESC,			WHS_DESC2,			");
            strSQL.Append("RECV_LOC,			WHS_TYPE,			WHS_ITEM_TYPE,		LOCATION_CTRL_FLAG,	AUTO_HOUSING_TYPE,");
            strSQL.Append("DIRECT_SHIP_FLAG,	VENDOR_CD,			CONS_WHS_FLAG,		CONS_VENDOR_CD,		");
            strSQL.Append("PASS_THRU_WHS_CD,	BOND_FLAG,			DATA_CHAR1,			DATA_CHAR2,			");
            strSQL.Append("DATA_CHAR3,			DATA_CHAR4,			DATA_CHAR5,			DATA_CHAR6,			");
            strSQL.Append("DATA_CHAR7,			DATA_CHAR8,			DATA_CHAR9,			DATA_CHAR10,		");
            strSQL.Append("DATA_NUM1,			DATA_NUM2,			DATA_NUM3,			DATA_NUM4,			");
            strSQL.Append("DATA_NUM5,			DATA_NUM6,			DATA_NUM7,			DATA_NUM8,			");
            strSQL.Append("DATA_NUM9,			DATA_NUM10,			DATA_FLAG1,			DATA_FLAG2,			");
            strSQL.Append("DATA_FLAG3,			DATA_FLAG4,			DATA_FLAG5,			DATA_FLAG6,			");
            strSQL.Append("DATA_FLAG7,			DATA_FLAG8,			DATA_FLAG9,			DATA_FLAG10,		");
            strSQL.Append("ENTRY_DATE,			CHG_DATE,			CHG_PGM,			CHG_USERID,			");
            strSQL.Append("UPDATE_CNTR,         SUPPLY_TYPE                                                 ");//ADD UBIQ-LIU 2010/05/26 SUPPLY_TYPE ADD
            strSQL.Append(" FROM WAREHOUSE_MASTER ");

            if (_whs_type == 1)
                strSQL.Append(" WHERE WHS_TYPE = 1 ");
            
            strSQL.Append(" ORDER BY  WHS_CD");

            db.DbParametersClear();

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

        //-->ADD BY UBIQ-SUO 2010/09/19
        /// <summary>
        /// MRP倉庫一覧の取得

        /// 
        /// 使用画面：SrchMrpWhs
        /// </summary>
        public DataSet GetMrpWarehouseList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("WHS_CD,				MRP_WHS,			WHS_DESC,			WHS_DESC2,			");
            strSQL.Append("RECV_LOC,			WHS_TYPE,			WHS_ITEM_TYPE,		LOCATION_CTRL_FLAG,	AUTO_HOUSING_TYPE,");
            strSQL.Append("DIRECT_SHIP_FLAG,	VENDOR_CD,			CONS_WHS_FLAG,		CONS_VENDOR_CD,		");
            strSQL.Append("PASS_THRU_WHS_CD,	BOND_FLAG,			DATA_CHAR1,			DATA_CHAR2,			");
            strSQL.Append("DATA_CHAR3,			DATA_CHAR4,			DATA_CHAR5,			DATA_CHAR6,			");
            strSQL.Append("DATA_CHAR7,			DATA_CHAR8,			DATA_CHAR9,			DATA_CHAR10,		");
            strSQL.Append("DATA_NUM1,			DATA_NUM2,			DATA_NUM3,			DATA_NUM4,			");
            strSQL.Append("DATA_NUM5,			DATA_NUM6,			DATA_NUM7,			DATA_NUM8,			");
            strSQL.Append("DATA_NUM9,			DATA_NUM10,			DATA_FLAG1,			DATA_FLAG2,			");
            strSQL.Append("DATA_FLAG3,			DATA_FLAG4,			DATA_FLAG5,			DATA_FLAG6,			");
            strSQL.Append("DATA_FLAG7,			DATA_FLAG8,			DATA_FLAG9,			DATA_FLAG10,		");
            strSQL.Append("ENTRY_DATE,			CHG_DATE,			CHG_PGM,			CHG_USERID,			");
            strSQL.Append("UPDATE_CNTR,         SUPPLY_TYPE                                                 ");
            strSQL.Append(" FROM WAREHOUSE_MASTER ");
            strSQL.Append(" WHERE WHS_CD = MRP_WHS ");
            if (_mrp_whs != "")
            {
                strSQL.Append(" AND MRP_WHS = @MRP_WHS ");
                db.DbParametersClear();
                db.DbPsetString("@MRP_WHS", _mrp_whs);
            }
            strSQL.Append(" ORDER BY  WHS_CD");

            //db.DbParametersClear();

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
        //<--ADD BY UBIQ-SUO 2010/09/19

        /// <summary>
        /// 倉庫詳細の取得

        /// 
        /// 使用画面：MstWhsMnt
        /// </summary>
        public int GetWarehouseDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append(" SELECT                                                                                                        ");
            strSQL.Append(" W.WHS_CD,			W.MRP_WHS,			W.WHS_DESC,			W.WHS_DESC2,			                          ");
            strSQL.Append(" W.RECV_LOC,			W.WHS_TYPE,			W.WHS_ITEM_TYPE,	W.LOCATION_CTRL_FLAG,	W.AUTO_HOUSING_TYPE,      ");
            strSQL.Append(" W.DIRECT_SHIP_FLAG,	W.VENDOR_CD,		W.CONS_WHS_FLAG,	W.CONS_VENDOR_CD,		                          ");
            strSQL.Append(" W.PASS_THRU_WHS_CD,	W.BOND_FLAG,		W.DATA_CHAR1,		W.DATA_CHAR2,			                          ");
            strSQL.Append(" W.DATA_CHAR3,		W.DATA_CHAR4,		W.DATA_CHAR5,		W.DATA_CHAR6,			                          ");
            strSQL.Append(" W.DATA_CHAR7,		W.DATA_CHAR8,		W.DATA_CHAR9,		W.DATA_CHAR10,  		                          ");
            strSQL.Append(" W.DATA_NUM1,		W.DATA_NUM2,		W.DATA_NUM3,		W.DATA_NUM4,			                          ");
            strSQL.Append(" W.DATA_NUM5,		W.DATA_NUM6,		W.DATA_NUM7,		W.DATA_NUM8,			                          ");
            strSQL.Append(" W.DATA_NUM9,		W.DATA_NUM10,		W.DATA_FLAG1,		W.DATA_FLAG2,			                          ");
            strSQL.Append(" W.DATA_FLAG3,		W.DATA_FLAG4,		W.DATA_FLAG5,		W.DATA_FLAG6,			                          ");
            strSQL.Append(" W.DATA_FLAG7,		W.DATA_FLAG8,		W.DATA_FLAG9,		W.DATA_FLAG10,	    	                          ");
            strSQL.Append(" W.ENTRY_DATE,		W.CHG_DATE,			W.CHG_PGM,			W.CHG_USERID,			                          ");
            strSQL.Append(" W.UPDATE_CNTR,      W.SUPPLY_TYPE,                                                                            ");
            strSQL.Append(" W2.WHS_DESC AS MRP_WHS_DESC,         W3.WHS_DESC AS PASS_THRU_WHS_DESC,        V.VENDOR_NAME,               ");
            strSQL.Append(" V2.VENDOR_NAME AS CONS_VENDOR_NAME                                                                          ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM WAREHOUSE_MASTER W, WAREHOUSE_MASTER W2, WAREHOUSE_MASTER W3,VENDOR_MASTER V, VENDOR_MASTER V2       ");
                strSQL.Append(" WHERE W.WHS_CD              = :WHS_CD                                                                     ");
                strSQL.Append("   AND W.MRP_WHS             = W2.WHS_CD(+)                                                                ");
                strSQL.Append("   AND W.PASS_THRU_WHS_CD    = W3.WHS_CD(+)                                                                ");
                strSQL.Append("   AND W.VENDOR_CD           = V.VENDOR_CD(+)                                                              ");
                strSQL.Append("   AND W.CONS_VENDOR_CD      = V2.VENDOR_CD(+)                                                             ");

                db.DbParametersClear();
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                strSQL.Append(" FROM WAREHOUSE_MASTER W                                                                                    ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W2 ON W.MRP_WHS = W2.WHS_CD                                               ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W3 ON W.PASS_THRU_WHS_CD = W3.WHS_CD                                      ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON W.VENDOR_CD = V.VENDOR_CD                                               ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V2 ON W.CONS_VENDOR_CD = V2.VENDOR_CD                                        ");
                strSQL.Append(" WHERE W.WHS_CD = @WHS_CD                                                                                   ");

                db.DbParametersClear();
                db.DbPsetString("@WHS_CD", _whs_cd);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _whs_cd = db.Row("WHS_CD");
                _mrp_whs = db.Row("MRP_WHS");
                _whs_desc = db.Row("WHS_DESC");
                _whs_desc2 = db.Row("WHS_DESC2");
                _recv_loc = db.Row("RECV_LOC");
                _whs_type = int.Parse(db.Row("WHS_TYPE"));
                _whs_item_type = int.Parse(db.Row("WHS_ITEM_TYPE"));
                _location_ctrl_flag = int.Parse(db.Row("LOCATION_CTRL_FLAG"));
                _auto_housing_type = int.Parse(db.Row("AUTO_HOUSING_TYPE"));
                _direct_ship_flag = int.Parse(db.Row("DIRECT_SHIP_FLAG"));
                _vendor_cd = db.Row("VENDOR_CD");
                _cons_whs_flag = int.Parse(db.Row("CONS_WHS_FLAG"));
                _cons_vendor_cd = db.Row("CONS_VENDOR_CD");
                _pass_thru_whs_cd = db.Row("PASS_THRU_WHS_CD");
                _bond_flag = int.Parse(db.Row("BOND_FLAG"));
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
                _mrp_whs_desc = db.Row("MRP_WHS_DESC");
                _vendor_name = db.Row("VENDOR_NAME");
                _cons_vendor_name = db.Row("CONS_VENDOR_NAME");
                _pass_thru_whs_desc = db.Row("PASS_THRU_WHS_DESC");
                _supply_type = int.Parse(db.Row("SUPPLY_TYPE"));
          }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// 営業倉庫一覧の取得

        /// <para>使用画面：[SrchSDMWhs]</para>
        /// </summary>
        public DataSet GetSDMWarehosueList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT  *               ");           
            strSQL.Append(" FROM WHS_MST            ");
            strSQL.Append(" ORDER BY  WHS_CD        ");
            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "WHS_CD");
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
        /// 営業倉庫詳細の取得

        /// <para>使用画面：[SrchSDMWhs]</para>
        /// </summary>
        public int GetSDMWarehouseDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append(" SELECT  *                   ");
            strSQL.Append(" FROM WHS_MST W              ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" WHERE W.WHS_CD = :WHS_CD        ");

                db.DbParametersClear();
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                strSQL.Append(" WHERE W.WHS_CD = @WHS_CD        ");

                db.DbParametersClear();
                db.DbPsetString("@WHS_CD", _whs_cd);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _whs_cd = db.Row("WHS_CD");
                _whs_desc = db.Row("WHS_NAME");
                _recv_loc = db.Row("RECV_LOC");
                _whs_type = int.Parse(db.Row("WHS_TYPE"));
                _whs_item_type = int.Parse(db.Row("WHS_ITEM_TYPE"));
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

    }
}
