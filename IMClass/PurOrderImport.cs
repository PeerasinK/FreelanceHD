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
    public class RevImport
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public RevImport()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public RevImport(string p_user_id, int p_lang)
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
        protected string _content_no = "";
        protected string _part_no = "";
        protected string _part_name = "";
        protected string _color = "";
        protected string _proc_loc_from = "";
        protected string _proc_loc_to = "";
        protected string _inv_loc_cd = "";
        protected string _dock_no = "";
        protected string _kd_lot_no = "";
        protected string _pc_no = "";
        protected DateTime _delv_scdl_time;
        protected int _delv_scdl_qty = 0;
        protected string _inv_category = "";
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
        public string content_no { get { return _content_no; } set { _content_no = value; } }
        public string part_no { get { return _part_no; } set { _part_no = value; } }
        public string part_name { get { return _part_name; } set { _part_name = value; } }
        public string color { get { return _color; } set { _color = value; } }
        public string proc_loc_from { get { return _proc_loc_from; } set { _proc_loc_from = value; } }
        public string proc_loc_to { get { return _proc_loc_to; } set { _proc_loc_to = value; } }
        public string inv_loc_cd { get { return _inv_loc_cd; } set { _inv_loc_cd = value; } }
        public string dock_no { get { return _dock_no; } set { _dock_no = value; } }
        public string kd_lot_no { get { return _kd_lot_no; } set { _kd_lot_no = value; } }
        public string pc_no { get { return _pc_no; } set { _pc_no = value; } }
        public DateTime delv_scdl_time { get { return _delv_scdl_time; } set { _delv_scdl_time = value; } }
        public int delv_scdl_qty { get { return _delv_scdl_qty; } set { _delv_scdl_qty = value; } }
        public string inv_category { get { return _inv_category; } set { _inv_category = value; } }
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
            db.DbPsetString("@CONTENT_NO", _content_no, ComConst.DB_IN);
            db.DbPsetString("@PART_NO", _part_no, ComConst.DB_IN);
            db.DbPsetString("@PART_NAME", _part_name, ComConst.DB_IN);
            db.DbPsetString("@COLOR", _color, ComConst.DB_IN);
            db.DbPsetString("@PROC_LOC_FROM", _proc_loc_from, ComConst.DB_IN);
            db.DbPsetString("@PROC_LOC_TO", _proc_loc_to, ComConst.DB_IN);
            db.DbPsetString("@INV_LOC_CD", _inv_loc_cd, ComConst.DB_IN);
            db.DbPsetString("@DOCK_NO", _dock_no, ComConst.DB_IN);
            db.DbPsetString("@KD_LOT_NO", _kd_lot_no, ComConst.DB_IN);
            db.DbPsetString("@PC_NO", _pc_no, ComConst.DB_IN);
            db.DbPsetDate("@DELV_SCDL_TIME", _delv_scdl_time, ComConst.DB_IN);
            db.DbPsetInt("@DELV_SCDL_QTY", _delv_scdl_qty, ComConst.DB_IN);
            db.DbPsetString("@INV_CATEGORY", _inv_category, ComConst.DB_IN);
            //db.DbPsetInt("@FLAG", _flag, ComConst.DB_IN);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PUR_REC_IMPORT_INSERT");
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
            db.DbPsetString("@CONTENT_NO", _content_no, ComConst.DB_IN);
            db.DbPsetString("@PART_NO", _part_no, ComConst.DB_IN);
            db.DbPsetString("@PART_NAME", _part_name, ComConst.DB_IN);
            db.DbPsetString("@COLOR", _color, ComConst.DB_IN);
            db.DbPsetString("@PROC_LOC_FROM", _proc_loc_from, ComConst.DB_IN);
            db.DbPsetString("@PROC_LOC_TO", _proc_loc_to, ComConst.DB_IN);
            db.DbPsetString("@INV_LOC_CD", _inv_loc_cd, ComConst.DB_IN);
            db.DbPsetString("@DOCK_NO", _dock_no, ComConst.DB_IN);
            db.DbPsetString("@KD_LOT_NO", _kd_lot_no, ComConst.DB_IN);
            db.DbPsetString("@PC_NO", _pc_no, ComConst.DB_IN);
            db.DbPsetDate("@DELV_SCDL_TIME", _delv_scdl_time, ComConst.DB_IN);
            db.DbPsetInt("@DELV_SCDL_QTY", _delv_scdl_qty, ComConst.DB_IN);//ADD UBIQ-LIU 2010/05/26
            db.DbPsetString("@INV_CATEGORY", _inv_category, ComConst.DB_IN);
            db.DbPsetInt("@FLAG", _flag, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

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
            db.DbPsetString("@CONTENT_NO", _content_no, ComConst.DB_IN);
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
            strSQL.Append("CONTENT_NO,			PART_NO,			PART_NAME,			COLOR,			    ");
            strSQL.Append("PROC_LOC_FROM,	    PROC_LOC_TO,		INV_LOC_CD,		    DOCK_NO,	        ,");
            strSQL.Append("KD_LOT_NO,	        PC_NO,			    DELV_SCDL_TIME,		DELV_SCDL_QTY,		");
            strSQL.Append("INV_CATEGORY,	    FLAG        ");

            strSQL.Append(" FROM PUR_ORDER_IMPORT ");

            //if (_whs_type == 1)
            //    strSQL.Append(" WHERE WHS_TYPE = 1 ");

            strSQL.Append(" ORDER BY  CONTENT_NO");

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
