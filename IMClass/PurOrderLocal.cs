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
    public class RevLocal
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public RevLocal()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public RevLocal(string p_user_id, int p_lang)
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
        protected string _slip_no = "";
        protected string _date = "";
        protected string _time = "";
        protected string _proc_loc_from = "";
        protected string _maker_name = "";
        protected string _ship_to = "";
        protected string _part_no = "";
        protected string _part_name = "";
        protected string _color = "";
        protected string _receive_cycle = "";
        protected string _inv_category = "";
        protected string _kd_lot_from = "";
        protected string _kd_lot_to = "";
        protected string _proc_loc_to = "";
        protected string _delv_addr = "";
        protected int _delv_scdll_qty = 0;
        protected int _part_unld_qty = 0;
        protected int _progress = 0;
        protected string _inv_loc_cd = "";
        protected int _flag = 0;

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
        public string slip_no { get { return _slip_no; } set { _slip_no = value; } }
        public string date { get { return _date; } set { _date = value; } }
        public string time { get { return _time; } set { _time = value; } }
        public string proc_loc_from { get { return _proc_loc_from; } set { _proc_loc_from = value; } }
        public string maker_name { get { return _maker_name; } set { _maker_name = value; } }
        public string ship_to { get { return _ship_to; } set { _ship_to = value; } }
        public string part_no { get { return _part_no; } set { _part_no = value; } }
        public string part_name { get { return _part_name; } set { _part_name = value; } }
        public string color { get { return _color; } set { _color = value; } }
        public string receive_cycle { get { return _receive_cycle; } set { _receive_cycle = value; } }
        public string inv_category { get { return _inv_category; } set { _inv_category = value; } }
        public string kd_lot_from { get { return _kd_lot_from; } set { _kd_lot_from = value; } }
        public string kd_lot_to { get { return _kd_lot_to; } set { _kd_lot_to = value; } }
        public string proc_loc_to { get { return _proc_loc_to; } set { _proc_loc_to = value; } }
        public string delv_addr { get { return _delv_addr; } set { _delv_addr = value; } }
        public int delv_scdll_qty { get { return _delv_scdll_qty; } set { _delv_scdll_qty = value; } }
        public int part_unld_qty { get { return _part_unld_qty; } set { _part_unld_qty = value; } }
        public int progress { get { return _progress; } set { _progress = value; } }
        public string inv_loc_cd { get { return _inv_loc_cd; } set { _inv_loc_cd = value; } }
        public int flag { get { return _flag; } set { _flag = value; } }

        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }

        #endregion

        public int Insert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@SLIP_NO", _slip_no, ComConst.DB_IN);
            db.DbPsetString("@DATE", _date, ComConst.DB_IN);
            db.DbPsetString("@TIME", _time, ComConst.DB_IN);
            db.DbPsetString("@PROC_LOC_FROM", _proc_loc_from, ComConst.DB_IN);
            db.DbPsetString("@MAKER_NAME", _maker_name, ComConst.DB_IN);
            db.DbPsetString("@SHIP_TO", _ship_to, ComConst.DB_IN);
            db.DbPsetString("@PART_NO", _part_no, ComConst.DB_IN);
            db.DbPsetString("@PART_NAME", _part_name, ComConst.DB_IN);
            db.DbPsetString("@COLOR", _color, ComConst.DB_IN);
            db.DbPsetString("@RECEIVE_CYCLE", _receive_cycle, ComConst.DB_IN);
            db.DbPsetString("@INV_CATEGORY", _inv_category, ComConst.DB_IN);
            db.DbPsetString("@KD_LOT_FROM", _kd_lot_from, ComConst.DB_IN);
            db.DbPsetString("@KD_LOT_TO", _kd_lot_to, ComConst.DB_IN);
            db.DbPsetString("@PROC_LOC_TO", _proc_loc_to, ComConst.DB_IN);
            db.DbPsetString("@DELV_ADDR", _delv_addr, ComConst.DB_IN);
            db.DbPsetInt("@DELV_SCDLL_QTY", _delv_scdll_qty, ComConst.DB_IN);
            db.DbPsetInt("@PART_UNLD_QTY", _part_unld_qty, ComConst.DB_IN);
            db.DbPsetInt("@PROGRESS", _progress, ComConst.DB_IN);
            db.DbPsetString("@INV_LOC_CD", _inv_category, ComConst.DB_IN);
            //db.DbPsetInt("@FLAG", _flag, ComConst.DB_IN);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PUR_REC_LOCAL_INSERT");
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


        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@SLIP_NO", _slip_no, ComConst.DB_IN);
            db.DbPsetString("@DATE", _date, ComConst.DB_IN);
            db.DbPsetString("@TIME", _time, ComConst.DB_IN);
            db.DbPsetString("@PROC_LOC_FROM", _proc_loc_from, ComConst.DB_IN);
            db.DbPsetString("@MAKER_NAME", _maker_name, ComConst.DB_IN);
            db.DbPsetString("@SHIP_TO", _ship_to, ComConst.DB_IN);
            db.DbPsetString("@PART_NO", _part_no, ComConst.DB_IN);
            db.DbPsetString("@PART_NAME", _part_name, ComConst.DB_IN);
            db.DbPsetString("@COLOR", _color, ComConst.DB_IN);
            db.DbPsetString("@RECEIVE_CYCLE", _receive_cycle, ComConst.DB_IN);
            db.DbPsetString("@INV_CATEGORY", _inv_category, ComConst.DB_IN);
            db.DbPsetString("@KD_LOT_FROM", _kd_lot_from, ComConst.DB_IN);
            db.DbPsetString("@KD_LOT_TO", _kd_lot_to, ComConst.DB_IN);
            db.DbPsetString("@PROC_LOC_TO", _proc_loc_to, ComConst.DB_IN);
            db.DbPsetString("@DELV_ADDR", _delv_addr, ComConst.DB_IN);
            db.DbPsetInt("@DELV_SCDLL_QTY", _delv_scdll_qty, ComConst.DB_IN);
            db.DbPsetInt("@PART_UNLD_QTY", _part_unld_qty, ComConst.DB_IN);
            db.DbPsetInt("@PROGRESS", _progress, ComConst.DB_IN);
            db.DbPsetString("@INV_LOC_CD", _inv_category, ComConst.DB_IN);
            db.DbPsetInt("@FLAG", _flag, ComConst.DB_IN);

            db.DbBeginTrans();
            rtn = db.DbStored("Update_Pur_Rec_Import");
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

        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@SLIP_NO", _slip_no, ComConst.DB_IN);
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
            rtn = db.DbStored("Delete_Pur_Rec_Import");
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

        public DataSet GetOrderImportList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("SLIP_NO,			DATE,			    TIME,			PROC_LOC_FROM,	    ");
            strSQL.Append("MAKER_NAME,	    SHIP_TO,		    PART_NO,		PART_NAME,	        ");
            strSQL.Append("COLOR,	        RECEIVE_CYCLE,	    INV_CATEGORY,   KD_LOT_FROM,		");
            strSQL.Append("KD_LOT_TO,	    PROC_LOC_TO,	    DELV_ADDR,		DELV_SCDLL_QTY,		");
            strSQL.Append("PART_UNLD_QTY,	PROGRESS,			INV_LOC_CD,				");
            strSQL.Append("FLAG        ");

            strSQL.Append(" FROM PUR_ORDER_LOCAL ");

            //if (_whs_type == 1)
            //    strSQL.Append(" WHERE WHS_TYPE = 1 ");

            strSQL.Append(" ORDER BY  SLIP_NO");

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
    }
}
