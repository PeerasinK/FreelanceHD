using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

namespace IMClass
{
    public class Item
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Item()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Item(string p_user_id, int p_lang)
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
        protected int    _lang = 1;
        protected string _item_no = "";
        protected string _item_desc = "";
        protected string _item_desc2 = "";
        protected string _drawing_no = "";
        protected string _catg_cd = "";
        protected string _spec_desc = "";
        protected string _remarks = "";
        protected int    _po_stop_flag = 0;
        protected int    _llc = 0;
        protected string _item_type = "";
        protected string _sch_id = "";
        protected int    _po_type = 0;
        protected string _item_umsr = "";
        protected double _reorder_point = 0.0;
        protected int    _auto_disb_type = 0;
        protected double _disb_lot_size = 0.0;
        protected int    _demand_roud_type = 0;
        protected double _min_pur_qty = 0.0;
        protected double _pur_lot_size = 0.0;
        protected int    _demand_period = 0;
        protected int    _pur_period = 0;
        protected int    _safety_stock_type = 0;
        protected double _safety_stock = 0.0;
        protected int    _safety_stock_days = 0;
        protected double _safety_stock_ratio = 0.0;
        protected int    _ss_calc_condtn = 0;
        protected int    _ss_inv_condtn = 0;
        protected double _item_addn_order_ratio = 0.0;
        protected int    _plant_lt = 0;
        protected int    _backwd_allowance_days = 0;
        protected int    _order_control_flag = 0;
        protected string _disb_whs = "";
        protected string _bond_disb_whs = "";
        protected int    _bond_type = 0;
        protected string _location = "";
        protected int    _supply_type = 0;
        protected int    _lot_cntl_flag = 0;
        protected string _item_abc_cd = "";
        protected int    _exp_date = 0;
        protected int    _neg_bal_flag = 0;
        protected string _item_image = "";
        protected string _assy_image = "";
        protected string _whs_desc = "";
        protected string _bond_whs_desc = "";
        protected int _wip_type = 0;
        protected double _item_addn_rcv_ratio = 0;

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

        protected bool _range;      //ADD BY UBIQ-SUO 2010/09/25

        protected string _umsr_desc = "";
        #endregion

        #region : プロパティ

        public string item_no { get { return _item_no; } set { _item_no = value; } }
        public string item_desc { get { return _item_desc; } set { _item_desc = value; } }
        public string item_desc2 { get { return _item_desc2; } set { _item_desc2 = value; } }
        public string drawing_no { get { return _drawing_no; } set { _drawing_no = value; } }
        public string catg_cd { get { return _catg_cd; } set { _catg_cd = value; } }
        public string spec_desc { get { return _spec_desc; } set { _spec_desc = value; } }
        public string remarks { get { return _remarks; } set { _remarks = value; } }
        public int po_stop_flag { get { return _po_stop_flag; } set { _po_stop_flag = value; } }
        public int llc { get { return _llc; } set { _llc = value; } }
        public string item_type { get { return _item_type; } set { _item_type = value; } }
        public string sch_id { get { return _sch_id; } set { _sch_id = value; } }
        public int po_type { get { return _po_type; } set { _po_type = value; } }
        public string item_umsr { get { return _item_umsr; } set { _item_umsr = value; } }
        public double reorder_point { get { return _reorder_point; } set { _reorder_point = value; } }
        public int auto_disb_type { get { return _auto_disb_type; } set { _auto_disb_type = value; } }
        public double disb_lot_size { get { return _disb_lot_size; } set { _disb_lot_size = value; } }
        public int demand_roud_type { get { return _demand_roud_type; } set { _demand_roud_type = value; } }
        public double min_pur_qty { get { return _min_pur_qty; } set { _min_pur_qty = value; } }
        public double pur_lot_size { get { return _pur_lot_size; } set { _pur_lot_size = value; } }
        public int demand_period { get { return _demand_period; } set { _demand_period = value; } }
        public int pur_period { get { return _pur_period; } set { _pur_period = value; } }
        public int safety_stock_type { get { return _safety_stock_type; } set { _safety_stock_type = value; } }
        public double safety_stock { get { return _safety_stock; } set { _safety_stock = value; } }
        public int safety_stock_days { get { return _safety_stock_days; } set { _safety_stock_days = value; } }
        public double safety_stock_ratio { get { return _safety_stock_ratio; } set { _safety_stock_ratio = value; } }
        public int ss_calc_condtn { get { return _ss_calc_condtn; } set { _ss_calc_condtn = value; } }
        public int ss_inv_condtn { get { return _ss_inv_condtn; } set { _ss_inv_condtn = value; } }
        public double item_addn_order_ratio { get { return _item_addn_order_ratio; } set { _item_addn_order_ratio = value; } }
        public int plant_lt { get { return _plant_lt; } set { _plant_lt = value; } }
        public int backwd_allowance_days { get { return _backwd_allowance_days; } set { _backwd_allowance_days = value; } }
        public int order_control_flag { get { return _order_control_flag; } set { _order_control_flag = value; } }
        public string disb_whs { get { return _disb_whs; } set { _disb_whs = value; } }
        public string bond_disb_whs { get { return _bond_disb_whs; } set { _bond_disb_whs = value; } }
        public int bond_type { get { return _bond_type; } set { _bond_type = value; } }
        public string location { get { return _location; } set { _location = value; } }
        public int supply_type { get { return _supply_type; } set { _supply_type = value; } }
        public int lot_cntl_flag { get { return _lot_cntl_flag; } set { _lot_cntl_flag = value; } }
        public string item_abc_cd { get { return _item_abc_cd; } set { _item_abc_cd = value; } }
        public int exp_date { get { return _exp_date; } set { _exp_date = value; } }
        public int neg_bal_flag { get { return _neg_bal_flag; } set { _neg_bal_flag = value; } }
        public string item_image { get { return _item_image; } set { _item_image = value; } }
        public string assy_image { get { return _assy_image; } set { _assy_image = value; } }
        public string whs_desc { get { return _whs_desc; } set { _whs_desc = value; } }
        public string bond_whs_desc { get { return _bond_whs_desc; } set { _bond_whs_desc = value; } }
        public int wip_type { get { return _wip_type; } set { _wip_type = value; } }
        public double item_addn_rcv_ratio { get { return _item_addn_rcv_ratio; } set { _item_addn_rcv_ratio = value; } }

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

        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string errmsg { get { return _errmsg; } set { _errmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }
        public int errcode { get { return _errcode; } set { _errcode = value; } }
        public int sqlcode { get { return _sqlcode; } set { _sqlcode = value; } }
        public int lang { get { return _lang; } set { _lang = value; } }
        //public string _proc_name { get { return_proc_name; } set { _proc_name = value; } }

        public string umsr_desc { get { return _umsr_desc; } set { _umsr_desc = value; } }

        public bool range { get { return _range; } set { _range = value; } }  //ADD BY UBIQ-SUO 2010/09/25
        #endregion

        /// <summary>
        /// 品目の追加
        /// 
        /// 使用画面：MstItemMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_DESC", _item_desc, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_DESC2", _item_desc2, ComConst.DB_IN);
            db.DbPsetString("@I_DRAWING_NO", _drawing_no, ComConst.DB_IN);
            db.DbPsetString("@I_CATG_CD ", _catg_cd, ComConst.DB_IN);
            db.DbPsetString("@I_SPEC_DESC", _spec_desc, ComConst.DB_IN);
            db.DbPsetString("@I_REMARKS", _remarks, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_STOP_FLAG ", _po_stop_flag, ComConst.DB_IN);
            db.DbPsetInt("@I_LLC", _llc, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_TYPE", _item_type, ComConst.DB_IN);
            db.DbPsetString("@I_SCH_ID", _sch_id, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_TYPE", _po_type, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_UMSR", _item_umsr, ComConst.DB_IN);
            db.DbPsetDouble("@I_REORDER_POINT", _reorder_point, ComConst.DB_IN);
            db.DbPsetInt("@I_AUTO_DISB_TYPE", _auto_disb_type, ComConst.DB_IN);
            db.DbPsetDouble("@I_DISB_LOT_SIZE", _disb_lot_size, ComConst.DB_IN);
            db.DbPsetInt("@I_DEMAND_ROUD_TYPE", _demand_roud_type, ComConst.DB_IN);
            db.DbPsetDouble("@I_MIN_PUR_QTY ", _min_pur_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_PUR_LOT_SIZE", _pur_lot_size, ComConst.DB_IN);
            db.DbPsetInt("@I_DEMAND_PERIOD", _demand_period, ComConst.DB_IN);
            db.DbPsetInt("@I_PUR_PERIOD", _pur_period, ComConst.DB_IN);
            db.DbPsetInt("@I_SAFETY_STOCK_TYPE", _safety_stock_type, ComConst.DB_IN);
            db.DbPsetDouble("@I_SAFETY_STOCK", _safety_stock, ComConst.DB_IN);
            db.DbPsetInt("@I_SAFETY_STOCK_DAYS", _safety_stock_days, ComConst.DB_IN);
            db.DbPsetDouble("@I_SAFETY_STOCK_RATIO", _safety_stock_ratio, ComConst.DB_IN);
            db.DbPsetInt("@I_SS_CALC_CONDTN", _ss_calc_condtn, ComConst.DB_IN);
            db.DbPsetInt("@I_SS_INV_CONDTN", _ss_inv_condtn, ComConst.DB_IN);
            db.DbPsetDouble("@I_ITEM_ADDN_ORDER_RATIO", _item_addn_order_ratio, ComConst.DB_IN);
            db.DbPsetDouble("@I_ITEM_ADDN_RCV_RATIO", _item_addn_rcv_ratio, ComConst.DB_IN);
            db.DbPsetInt("@I_PLANT_LT", _plant_lt, ComConst.DB_IN);
            db.DbPsetInt("@I_BACKWD_ALLOWANCE_DAYS", _backwd_allowance_days, ComConst.DB_IN);
            db.DbPsetInt("@I_ORDER_CONTROL_FLAG", _order_control_flag, ComConst.DB_IN);
            db.DbPsetString("@I_DISB_WHS", _disb_whs, ComConst.DB_IN);
            db.DbPsetString("@I_BOND_DISB_WHS", _bond_disb_whs, ComConst.DB_IN);
            db.DbPsetInt("@I_BOND_TYPE", _bond_type, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION", _location, ComConst.DB_IN);
            db.DbPsetInt("@I_SUPPLY_TYPE", _supply_type, ComConst.DB_IN);
            db.DbPsetInt("@I_LOT_CNTL_FLAG", _lot_cntl_flag, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_ABC_CD", _item_abc_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_EXP_DATE", _exp_date, ComConst.DB_IN);
            db.DbPsetInt("@I_NEG_BAL_FLAG", _neg_bal_flag, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_IMAGE", _item_image, ComConst.DB_IN);
            db.DbPsetString("@I_ASSY_IMAGE", _assy_image, ComConst.DB_IN);
            db.DbPsetDouble("@I_WIP_TYPE", _wip_type, ComConst.DB_IN);

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
            rtn = db.DbStored("SP_ITEM_INSERT");
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
        /// 品目の追加
        /// 
        /// 使用画面：MstItemMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_DESC", _item_desc, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_DESC2", _item_desc2, ComConst.DB_IN);
            db.DbPsetString("@I_DRAWING_NO", _drawing_no, ComConst.DB_IN);
            db.DbPsetString("@I_CATG_CD ", _catg_cd, ComConst.DB_IN);
            db.DbPsetString("@I_SPEC_DESC", _spec_desc, ComConst.DB_IN);
            db.DbPsetString("@I_REMARKS", _remarks, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_STOP_FLAG ", _po_stop_flag, ComConst.DB_IN);
            db.DbPsetInt("@I_LLC", _llc, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_TYPE", _item_type, ComConst.DB_IN);
            db.DbPsetString("@I_SCH_ID", _sch_id, ComConst.DB_IN);
            db.DbPsetInt("@I_PO_TYPE", _po_type, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_UMSR", _item_umsr, ComConst.DB_IN);
            db.DbPsetDouble("@I_REORDER_POINT", _reorder_point, ComConst.DB_IN);
            db.DbPsetInt("@I_AUTO_DISB_TYPE", _auto_disb_type, ComConst.DB_IN);
            db.DbPsetDouble("@I_DISB_LOT_SIZE", _disb_lot_size, ComConst.DB_IN);
            db.DbPsetInt("@I_DEMAND_ROUD_TYPE", _demand_roud_type, ComConst.DB_IN);
            db.DbPsetDouble("@I_MIN_PUR_QTY ", _min_pur_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_PUR_LOT_SIZE", _pur_lot_size, ComConst.DB_IN);
            db.DbPsetInt("@I_DEMAND_PERIOD", _demand_period, ComConst.DB_IN);
            db.DbPsetInt("@I_PUR_PERIOD", _pur_period, ComConst.DB_IN);
            db.DbPsetInt("@I_SAFETY_STOCK_TYPE", _safety_stock_type, ComConst.DB_IN);
            db.DbPsetDouble("@I_SAFETY_STOCK", _safety_stock, ComConst.DB_IN);
            db.DbPsetInt("@I_SAFETY_STOCK_DAYS", _safety_stock_days, ComConst.DB_IN);
            db.DbPsetDouble("@I_SAFETY_STOCK_RATIO", _safety_stock_ratio, ComConst.DB_IN);
            db.DbPsetInt("@I_SS_CALC_CONDTN", _ss_calc_condtn, ComConst.DB_IN);
            db.DbPsetInt("@I_SS_INV_CONDTN", _ss_inv_condtn, ComConst.DB_IN);
            db.DbPsetDouble("@I_ITEM_ADDN_ORDER_RATIO", _item_addn_order_ratio, ComConst.DB_IN);
            db.DbPsetDouble("@I_ITEM_ADDN_RCV_RATIO", _item_addn_rcv_ratio, ComConst.DB_IN);
            db.DbPsetInt("@I_PLANT_LT", _plant_lt, ComConst.DB_IN);
            db.DbPsetInt("@I_BACKWD_ALLOWANCE_DAYS", _backwd_allowance_days, ComConst.DB_IN);
            db.DbPsetInt("@I_ORDER_CONTROL_FLAG", _order_control_flag, ComConst.DB_IN);
            db.DbPsetString("@I_DISB_WHS", _disb_whs, ComConst.DB_IN);
            db.DbPsetString("@I_BOND_DISB_WHS", _bond_disb_whs, ComConst.DB_IN);
            db.DbPsetInt("@I_BOND_TYPE", _bond_type, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION", _location, ComConst.DB_IN);
            db.DbPsetInt("@I_SUPPLY_TYPE", _supply_type, ComConst.DB_IN);
            db.DbPsetInt("@I_LOT_CNTL_FLAG", _lot_cntl_flag, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_ABC_CD", _item_abc_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_EXP_DATE", _exp_date, ComConst.DB_IN);
            db.DbPsetInt("@I_NEG_BAL_FLAG", _neg_bal_flag, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_IMAGE", _item_image, ComConst.DB_IN);
            db.DbPsetString("@I_ASSY_IMAGE", _assy_image, ComConst.DB_IN);
            db.DbPsetDouble("@I_WIP_TYPE", _wip_type, ComConst.DB_IN);

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
            rtn = db.DbStored("SP_ITEM_UPDATE");
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
        /// 品目の変更
        /// 
        /// 使用画面：MstItemMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_ITEM_DELETE");
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
        ///  品目詳細の取得
        ///         
        /// 使用画面：MstItemMnt
        /// </summary>
        public int GetItemDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            //strSQL.Append(" SELECT                                                                                                          ");
            //strSQL.Append(" I.ITEM_NO,			I.ITEM_DESC,	        I.ITEM_DESC2,             I.DRAWING_NO,	                            ");
            //strSQL.Append(" I.CATG_CD,	        I.SPEC_DESC,            I.REMARKS,                I.PO_STOP_FLAG,	                        ");
            //strSQL.Append(" I.LLC,	            I.ITEM_TYPE,		    I.SCH_ID,	              I.PO_TYPE,	I.WIP_TYPE ,	            ");
            //strSQL.Append(" I.AUTO_DISB_TYPE,	I.DISB_LOT_SIZE,        I.DEMAND_ROUD_TYPE,	      I.MIN_PUR_QTY,		                    ");
            //strSQL.Append(" I.PUR_LOT_SIZE,	    I.DEMAND_PERIOD,        I.PUR_PERIOD,	          I.SAFETY_STOCK_TYPE,		                ");
            //strSQL.Append(" I.SAFETY_STOCK,	    I.SAFETY_STOCK_DAYS,    I.SAFETY_STOCK_RATIO ,    I.SS_CALC_CONDTN,		                    ");
            //strSQL.Append(" I.SS_INV_CONDTN,	I.ITEM_ADDN_ORDER_RATIO,I.PLANT_LT,	              I.BACKWD_ALLOWANCE_DAYS,		            ");
            //strSQL.Append(" I.ORDER_CONTROL_FLAG,I.DISB_WHS,		    I.BOND_DISB_WHS,	      I.BOND_TYPE,		                        ");
            //strSQL.Append(" I.LOCATION  ,	    I.SUPPLY_TYPE,          I.LOT_CNTL_FLAG,	      I.ITEM_ABC_CD,		                    ");
            //strSQL.Append(" I.EXP_DATE ,	    I.NEG_BAL_FLAG,		    I.ITEM_IMAGE,	          I.ASSY_IMAGE,		                        ");
            //strSQL.Append(" I.ITEM_UMSR ,	    I.REORDER_POINT,	I.DATA_CHAR1,	    I.DATA_CHAR2,			                            ");
            //strSQL.Append(" I.DATA_CHAR3,		I.DATA_CHAR4,		I.DATA_CHAR5,		I.DATA_CHAR6,			                            ");
            //strSQL.Append(" I.DATA_CHAR7,		I.DATA_CHAR8,		I.DATA_CHAR9,		I.DATA_CHAR10,  		                            ");
            //strSQL.Append(" I.DATA_NUM1,	    I.DATA_NUM2,		I.DATA_NUM3,		I.DATA_NUM4,			                            ");
            //strSQL.Append(" I.DATA_NUM5,		I.DATA_NUM6,		I.DATA_NUM7,		I.DATA_NUM8,			                            ");
            //strSQL.Append(" I.DATA_NUM9,		I.DATA_NUM10,		I.DATA_FLAG1,		I.DATA_FLAG2,			                            ");
            //strSQL.Append(" I.DATA_FLAG3,		I.DATA_FLAG4,		I.DATA_FLAG5,		I.DATA_FLAG6,			                            ");
            //strSQL.Append(" I.DATA_FLAG7,		I.DATA_FLAG8,		I.DATA_FLAG9,		I.DATA_FLAG10,	    	                            ");
            //strSQL.Append(" I.ENTRY_DATE,		I.CHG_DATE,			I.CHG_PGM,			I.CHG_USERID,			                            ");
            //strSQL.Append(" I.UPDATE_CNTR,      I.ITEM_ADDN_RCV_RATIO,                                                                      ");
            //strSQL.Append("W1.WHS_DESC AS WHS_DESC,  W2.WHS_DESC AS BOND_WHS_DESC,                                                          ");
            //strSQL.Append("S1.DATA_CHAR UMSR_DESC                                                                                           ");
            strSQL.Append(" SELECT                                                                                                          ");
            strSQL.Append(" I.PART_NO,			I.PART_NAME,	        I.PART_DESCRIPTION,       I.ITEM_TYPE,	                            ");
            strSQL.Append(" I.DEPT_NO,	        I.MODEL_TYPE,           I.MAKER_FROM,             I.MAKER_CODE,	                            ");
            strSQL.Append(" I.DEPT_TO,	        I.STOCK_AREA,		    I.LINE_PROD,	          I.CATEGORY,		                        ");
            strSQL.Append(" I.REMARK,	        I.FLAG,                 I.DRAWING_NO,	          		                                    ");
            strSQL.Append(" I.ENTRY_DATE,		I.UPDATE_DATE,			I.USER_CREATE,			  I.USER_UPDATE                             ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ITEM_MASTER I, WAREHOUSE_MASTER W1,WAREHOUSE_MASTER W2,SYSTEM_PARAMETER S1  ");
                strSQL.Append(" WHERE I.ITEM_NO            = :ITEM_NO");
                strSQL.Append("   AND I.DISB_WHS          = W1.WHS_CD(+)");
                strSQL.Append("   AND I.BOND_DISB_WHS     = W2.WHS_CD(+)");
                strSQL.Append("   AND I.ITEM_UMSR         = S1.KEY02(+) ");
                strSQL.Append("   AND S1.KEY01            = 'ITEM_UMSR' ");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);
            }
            else
            {
                strSQL.Append(" FROM ITEM_MASTER I ");
                //strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W1 ON I.DISB_WHS  = W1.WHS_CD      ");
                //strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W2 ON I.BOND_DISB_WHS = W2.WHS_CD  ");
                //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01 = 'ITEM_UMSR'       ");
                //strSQL.Append(" AND S1.KEY02 = I.ITEM_UMSR                                          ");

                //strSQL.Append(" WHERE I.ITEM_NO = @ITEM_NO");
                strSQL.Append(" WHERE I.PART_NO = @PART_NO");
                db.DbParametersClear();
                //db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@PART_NO", _item_no);

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
                //_item_desc = db.Row("ITEM_DESC");
                //_item_desc2 = db.Row("ITEM_DESC2");
                //_drawing_no = db.Row("DRAWING_NO");
                //_catg_cd = db.Row("CATG_CD");
                //_spec_desc = db.Row("SPEC_DESC");
                //_remarks = db.Row("REMARKS");
                //_po_stop_flag = int.Parse(db.Row("PO_STOP_FLAG"));
                //_llc = int.Parse(db.Row("LLC"));
                //_item_type = db.Row("ITEM_TYPE");
                //_sch_id = db.Row("SCH_ID");
                //_po_type = int.Parse(db.Row("PO_TYPE"));
                //_item_umsr = db.Row("ITEM_UMSR");
                //_reorder_point = double.Parse(db.Row("REORDER_POINT"));
                //_pur_period = int.Parse(db.Row("PUR_PERIOD"));
                //_auto_disb_type = int.Parse(db.Row("AUTO_DISB_TYPE"));
                //_disb_lot_size = double.Parse(db.Row("DISB_LOT_SIZE"));
                //_demand_roud_type = int.Parse(db.Row("DEMAND_ROUD_TYPE"));
                //_min_pur_qty = double.Parse(db.Row("MIN_PUR_QTY"));
                //_pur_lot_size = double.Parse(db.Row("PUR_LOT_SIZE"));
                //_demand_period = int.Parse(db.Row("DEMAND_PERIOD"));
                //_pur_period = int.Parse(db.Row("PUR_PERIOD"));
                //_safety_stock_type = int.Parse(db.Row("SAFETY_STOCK_TYPE"));
                //_safety_stock = double.Parse(db.Row("SAFETY_STOCK"));
                //_safety_stock_days = int.Parse(db.Row("SAFETY_STOCK_DAYS"));
                //_safety_stock_ratio = double.Parse(db.Row("SAFETY_STOCK_RATIO"));
                //_ss_calc_condtn = int.Parse(db.Row("SS_CALC_CONDTN"));
                //_ss_inv_condtn = int.Parse(db.Row("SS_INV_CONDTN"));
                //_item_addn_order_ratio = double.Parse(db.Row("ITEM_ADDN_ORDER_RATIO"));
                //_plant_lt = int.Parse(db.Row("PLANT_LT"));
                //_backwd_allowance_days = int.Parse(db.Row("BACKWD_ALLOWANCE_DAYS"));
                //_order_control_flag = int.Parse(db.Row("ORDER_CONTROL_FLAG"));
                //_disb_whs = db.Row("DISB_WHS");
                //_bond_disb_whs = db.Row("BOND_DISB_WHS");
                //_bond_type = int.Parse(db.Row("BOND_TYPE"));
                //_location = db.Row("LOCATION");
                //_item_no = db.Row("ITEM_NO");
                //_supply_type = int.Parse(db.Row("SUPPLY_TYPE"));
                //_lot_cntl_flag = int.Parse(db.Row("LOT_CNTL_FLAG"));
                //_item_abc_cd = db.Row("ITEM_ABC_CD");
                //_exp_date = int.Parse(db.Row("EXP_DATE"));
                //_neg_bal_flag = int.Parse(db.Row("NEG_BAL_FLAG"));
                //_item_image = db.Row("ITEM_IMAGE");
                //_assy_image = db.Row("ASSY_IMAGE");
                //_whs_desc = db.Row("WHS_DESC");
                //_bond_whs_desc = db.Row("BOND_WHS_DESC");
                //_wip_type = int.Parse(db.Row("WIP_TYPE"));
                //_item_addn_rcv_ratio = double.Parse(db.Row("ITEM_ADDN_RCV_RATIO"));
                _item_no = db.Row("PART_NO");
                _item_desc = db.Row("PART_NAME");
                _item_desc2 = db.Row("PART_DESCRIPTION");
                _item_type = db.Row("ITEM_TYPE");
                _data_num1 = int.Parse(db.Row("DEPT_NO"));
                _spec_desc = db.Row("MODEL_TYPE");
                _data_char1 = db.Row("MAKER_FROM");
                _data_char1 = db.Row("MAKER_CODE");
                _data_num2 = int.Parse(db.Row("DEPT_TO"));
                _location = db.Row("STOCK_AREA");
                _sch_id = db.Row("LINE_PROD");
                _catg_cd = db.Row("CATEGORY");
                _remarks = db.Row("REMARK");
                _drawing_no = db.Row("DRAWING_NO");

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
                ////ADD BY LIU 2008.11.19
                //_umsr_desc = db.Row("UMSR_DESC");
                _entry_date = DateTime.Parse(db.Row("ENTRY_DATE"));
                _chg_date = DateTime.Parse(db.Row("UPDATE_DATE"));
                _chg_user_id = db.Row("USER_UPDATE");

            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;

        }

        /// <summary>
        ///  品目詳細の取得
        /// 
        /// 使用画面：MstItemMnt
        /// </summary>
        public DataSet GetItemList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();
            ComLibrary comlibrary = new ComLibrary();

            //--> ADD BY UBIQ-SUO 2010/09/25
            strSQL.Append("SELECT COUNT (*)");   //UPD BY UBIQ-SUO 2010/09/25 ADD TOP 2000
            //strSQL.Append("I.ITEM_NO,			I.ITEM_DESC,			    I.ITEM_DESC2,			I.DRAWING_NO,	                    ");
            //strSQL.Append("I.CATG_CD,	        I.SPEC_DESC,                I.REMARKS,              I.PO_STOP_FLAG,	                    ");
            //strSQL.Append("I.LLC,	            I.ITEM_TYPE,		        I.SCH_ID,	            I.PO_TYPE,		    I.WIP_TYPE,     ");
            //strSQL.Append("I.AUTO_DISB_TYPE,	I.DISB_LOT_SIZE,            I.DEMAND_ROUD_TYPE,	    I.MIN_PUR_QTY,		                ");
            //strSQL.Append("I.PUR_LOT_SIZE,	    I.DEMAND_PERIOD,            I.PUR_PERIOD,	        I.SAFETY_STOCK_TYPE,		        ");
            //strSQL.Append("I.SAFETY_STOCK,	    I.SAFETY_STOCK_DAYS,        I.SAFETY_STOCK_RATIO ,  I.SS_CALC_CONDTN,		            ");
            //strSQL.Append("I.SS_INV_CONDTN,	    I.ITEM_ADDN_ORDER_RATIO,    I.PLANT_LT,	            I.BACKWD_ALLOWANCE_DAYS,		    ");
            //strSQL.Append("I.ORDER_CONTROL_FLAG,I.DISB_WHS,		            I.BOND_DISB_WHS,	    I.BOND_TYPE,		                ");
            //strSQL.Append("I.LOCATION  ,	    I.SUPPLY_TYPE,		        I.LOT_CNTL_FLAG,	    I.ITEM_ABC_CD,		                ");
            //strSQL.Append("I.EXP_DATE ,	        I.NEG_BAL_FLAG,             I.ITEM_IMAGE,	        I.ASSY_IMAGE,		                ");
            //strSQL.Append("I.ITEM_UMSR ,	    I.REORDER_POINT,	I.DATA_CHAR1,	   I.DATA_CHAR2,			                        ");
            //strSQL.Append("I.DATA_CHAR3,		I.DATA_CHAR4,		I.DATA_CHAR5,		I.DATA_CHAR6,			                        ");
            //strSQL.Append("I.DATA_CHAR7,		I.DATA_CHAR8,		I.DATA_CHAR9,		I.DATA_CHAR10,  		                        ");
            //strSQL.Append("I.DATA_NUM1,			I.DATA_NUM2,		I.DATA_NUM3,		I.DATA_NUM4,			                        ");
            //strSQL.Append("I.DATA_NUM5,			I.DATA_NUM6,		I.DATA_NUM7,		I.DATA_NUM8,			                        ");
            //strSQL.Append("I.DATA_NUM9,			I.DATA_NUM10,		I.DATA_FLAG1,		I.DATA_FLAG2,			                        ");
            //strSQL.Append("I.DATA_FLAG3,		I.DATA_FLAG4,		I.DATA_FLAG5,		I.DATA_FLAG6,			                        ");
            //strSQL.Append("I.DATA_FLAG7,		I.DATA_FLAG8,		I.DATA_FLAG9,		I.DATA_FLAG10,	    	                        ");
            //strSQL.Append("I.ENTRY_DATE,		I.CHG_DATE,			I.CHG_PGM,			I.CHG_USERID,			                        ");
            //strSQL.Append("I.UPDATE_CNTR,       I.ITEM_ADDN_RCV_RATIO,                                                                  ");
            //strSQL.Append("W1.WHS_DESC AS WHS_DESC,  W2.WHS_DESC AS BOND_WHS_DESC                                                       ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ITEM_MASTER I ");              
                db.DbParametersClear();
                //db.DbPsetString("ITEM_NO", _ITEM_NO);
            }
            else
            {
                strSQL.Append(" FROM ITEM_MASTER I ");
                //strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W1 ON I.DISB_WHS  = W1.WHS_CD");
                //strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W2 ON I.BOND_DISB_WHS = W2.WHS_CD");
                strSQL.Append(" WHERE 1=1 ");
                db.DbParametersClear();
                if (_item_no != "")
                {
                    //strSQL.Append(" AND I.ITEM_NO LIKE '%" + _item_no + "%'");
                    strSQL.Append(" AND I.PART_NO LIKE '%" + _item_no + "%'");
                }

                if (_item_desc != "")
                {
                    //strSQL.Append(" AND I.ITEM_DESC LIKE '%" + _item_desc + "%'");
                    strSQL.Append(" AND I.PART_NAME LIKE '%" + _item_desc + "%'");

                }
                if (_item_type != "")
                {
                    strSQL.Append(" AND I.ITEM_TYPE = @ITEM_TYPE");
                    db.DbPsetString("@ITEM_TYPE", _item_type);
                }
                //strSQL.Append(" WHERE I.ITEM_NO = @ITEM_NO");              
                //db.DbPsetString("@ITEM_NO", _ITEM_NO);
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
            //<-- ADD BY UBIQ-SUO 2010/09/25


            strSQL = new StringBuilder();
            //--- sql
            strSQL.Append("SELECT TOP 2000");   //UPD BY UBIQ-SUO 2010/09/25 ADD TOP 2000
            strSQL.Append(" I.PART_NO,			I.PART_NAME,	        I.PART_DESCRIPTION,       I.ITEM_TYPE,	                            ");
            strSQL.Append(" I.DEPT_NO,	        I.MODEL_TYPE,           I.MAKER_FROM,             I.MAKER_CODE,	                            ");
            strSQL.Append(" I.DEPT_TO,	        I.STOCK_AREA,		    I.LINE_PROD,	          I.CATEGORY,		                        ");
            strSQL.Append(" I.REMARK,	        I.FLAG,                 I.DRAWING_NO,	          		                                    ");
            strSQL.Append(" I.ENTRY_DATE,		I.UPDATE_DATE,			I.USER_CREATE,			  I.USER_UPDATE                             ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ITEM_MASTER I, WAREHOUSE_MASTER W1,WAREHOUSE_MASTER W2,  ");
                strSQL.Append(" WHERE I.DISB_WHS          = W1.WHS_CD(+)");
                strSQL.Append("   AND I.BOND_DISB_WHS     = W2.WHS_CD(+)");
                db.DbParametersClear();
                //db.DbPsetString("ITEM_NO", _ITEM_NO);
            }
            else
            {
                strSQL.Append(" FROM ITEM_MASTER I ");
                //strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W1 ON I.DISB_WHS  = W1.WHS_CD");
                //strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W2 ON I.BOND_DISB_WHS = W2.WHS_CD");
                strSQL.Append(" WHERE 1=1 ");
                db.DbParametersClear();
                if (_item_no != "")
                {
                    //strSQL.Append(" AND I.ITEM_NO LIKE '%" + _item_no + "%'");
                    strSQL.Append(" AND I.PART_NO LIKE '%" + _item_no + "%'");
                }

                if (_item_desc != "")
                {
                    //strSQL.Append(" AND I.ITEM_DESC LIKE '%" + _item_desc + "%'");
                    strSQL.Append(" AND I.PART_NAME LIKE '%" + _item_desc + "%'");

                }
                if (_item_type != "")
                {
                    strSQL.Append(" AND I.ITEM_TYPE = @ITEM_TYPE");
                    db.DbPsetString("@ITEM_TYPE", _item_type);
                }
                //strSQL.Append(" WHERE I.ITEM_NO = @ITEM_NO");              
                //db.DbPsetString("@ITEM_NO", _ITEM_NO);
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
        ///  品目Picture Update
        /// 
        /// 使用画面：MstItemMnt
        /// </summary>
        public int Picture_Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_IMAGE", _item_image, ComConst.DB_IN);
            db.DbPsetString("@I_ASSY_IMAGE", _assy_image, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_ITEM_PICTURE_UPDATE");
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
