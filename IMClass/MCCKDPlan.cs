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
    public class MCCKDImport
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MCCKDImport()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public MCCKDImport(string p_user_id, int p_lang)
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
        protected int _year = 0;
        protected int _month = 0;
        protected int _version = 0;
        protected string _mc_ckd_no = "";
        protected int _mc_ckd_line = 0;
        protected DateTime _mc_del_n_2;
        protected string _vendor = "";
        protected string _dist = "";
        protected string _model = "";
        protected int _qty = 0;
        protected string _pc_no = "";
        protected int _block_qty = 0;
        protected int _head_qty = 0;
        protected DateTime _van_original;
        protected string _cy_cut;
        protected string _time_lcd = "";
        protected DateTime _etd;
        protected string _vessel = "";
        protected string _remark = "";
        protected int _flag;


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
        public int year { get { return _year; } set { _year = value; } }
        public int month { get { return _month; } set { _month = value; } }
        public int version { get { return _version; } set { _version = value; } }
        public string mc_ckd_no { get { return _mc_ckd_no; } set { _mc_ckd_no = value; } }
        public int mc_ckd_line { get { return _mc_ckd_line; } set { _mc_ckd_line = value; } }
        public DateTime mc_del_n_2 { get { return _mc_del_n_2; } set { _mc_del_n_2 = value; } }
        public string vendor { get { return _vendor; } set { _vendor = value; } }
        public string dist { get { return _dist; } set { _dist = value; } }
        public string model { get { return _model; } set { _model = value; } }
        public int qty { get { return _qty; } set { _qty = value; } }
        public string pc_no { get { return _pc_no; } set { _pc_no = value; } }
        public int block_qty { get { return _block_qty; } set { _block_qty = value; } }
        public int head_qty { get { return _head_qty; } set { _head_qty = value; } }
        public DateTime van_original { get { return _van_original; } set { _van_original = value; } }
        public string cy_cut { get { return _cy_cut; } set { _cy_cut = value; } }
        public string time_lcd { get { return _time_lcd; } set { _time_lcd = value; } }
        public DateTime etd { get { return _etd; } set { _etd = value; } }
        public string vessel { get { return _vessel; } set { _vessel = value; } }
        public string remark { get { return _remark; } set { _remark = value; } }
        public int flag { get { return _flag; } set { _flag = value; } }


        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }

        #endregion

        public int HeadInsert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;
            //rtnmc_ckd_no = "";
            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@MC_CKD_NO", _mc_ckd_no, ComConst.DB_IN);
            db.DbPsetInt("@YEAR", _year, ComConst.DB_IN);
            db.DbPsetInt("@MONTH", _month, ComConst.DB_IN);
            db.DbPsetInt("@VERSION", _version, ComConst.DB_IN);
            db.DbPsetString("@USER_CREATE", _chg_user_id, ComConst.DB_IN);
            //db.DbPsetString("@rtnHEAD_NO", _mc_ckd_no, ComConst.DB_OUT);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PLAN_PROD_MCCKD_HEADER_INSERT");
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
            //rtnmc_ckd_no = db.DbPgetString("@rtnHEAD_NO");
            return rtn;
        }

        public int DetailInsert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;
            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@MC_CKD_NO", _mc_ckd_no, ComConst.DB_IN);
            db.DbPsetInt("@MC_CKD_LINE", _mc_ckd_line, ComConst.DB_IN);
            db.DbPsetDate("@MC_DEL_N_2", _mc_del_n_2, ComConst.DB_IN);
            db.DbPsetString("@VENDOR", _vendor, ComConst.DB_IN);
            db.DbPsetString("@DIST", _dist, ComConst.DB_IN);
            db.DbPsetString("@MODEL", _model, ComConst.DB_IN);
            db.DbPsetInt("@QTY", _qty, ComConst.DB_IN);
            db.DbPsetString("@PC_NO", _pc_no, ComConst.DB_IN);
            db.DbPsetInt("@BLOCK_QTY", _block_qty, ComConst.DB_IN);
            db.DbPsetInt("@HEAD_QTY", _head_qty, ComConst.DB_IN);
            db.DbPsetDate("@VAN_ORIGINAL", _van_original, ComConst.DB_IN);
            db.DbPsetString("@CY_CUT", _cy_cut, ComConst.DB_IN);
            db.DbPsetString("@TIME_LCD", _time_lcd, ComConst.DB_IN);
            db.DbPsetDate("@ETD", _etd, ComConst.DB_IN);
            db.DbPsetString("@VESSEL", _vessel, ComConst.DB_IN);
            db.DbPsetString("@REMARK", _remark, ComConst.DB_IN);
            db.DbPsetInt("@FLAG", _flag, ComConst.DB_IN);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PLAN_PROD_MCCKD_DETAIL_INSERT");
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
        public int HeadUpdate()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@MC_CKD_NO", _mc_ckd_no, ComConst.DB_IN);
            db.DbPsetInt("@YEAR", _year, ComConst.DB_IN);
            db.DbPsetInt("@MONTH", _month, ComConst.DB_IN);
            //db.DbPsetInt("@VERSION", _version, ComConst.DB_IN);
            //db.DbPsetDate("@UPDATE_DATE", _chg_date, ComConst.DB_IN);
            db.DbPsetString("@USER_UPDATE", _chg_user_id, ComConst.DB_IN);


            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PLAN_PROD_MCCKD_HEADER_UPDATE");
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

        public int DetailUpdate()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;
            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@MC_CKD_NO", _mc_ckd_no, ComConst.DB_IN);
            db.DbPsetInt("@MC_CKD_LINE", _mc_ckd_line, ComConst.DB_IN);
            db.DbPsetDate("@MC_DEL_N_2", _mc_del_n_2, ComConst.DB_IN);
            db.DbPsetString("@VENDOR", _vendor, ComConst.DB_IN);
            db.DbPsetString("@DIST", _dist, ComConst.DB_IN);
            db.DbPsetString("@MODEL", _model, ComConst.DB_IN);
            db.DbPsetInt("@QTY", _qty, ComConst.DB_IN);
            db.DbPsetString("@PC_NO", _pc_no, ComConst.DB_IN);
            db.DbPsetInt("@BLOCK_QTY", _block_qty, ComConst.DB_IN);
            db.DbPsetInt("@HEAD_QTY", _head_qty, ComConst.DB_IN);
            db.DbPsetDate("@VAN_ORIGINAL", _van_original, ComConst.DB_IN);
            db.DbPsetString("@CY_CUT", _cy_cut, ComConst.DB_IN);
            db.DbPsetString("@TIME_LCD", _time_lcd, ComConst.DB_IN);
            db.DbPsetDate("@ETD", _etd, ComConst.DB_IN);
            db.DbPsetString("@VESSEL", _vessel, ComConst.DB_IN);
            db.DbPsetString("@REMARK", _remark, ComConst.DB_IN);
            db.DbPsetInt("@FLAG", _flag, ComConst.DB_IN);

            //db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            //db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            //db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            //db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            //db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PLAN_PROD_MCCKD_DETAIL_UPDATE");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                db.DbCommit();
            }
            else
            {
                //_errcode = db.DbPgetInt("@O_ERRCODE");
                //_errmsg = db.DbPgetString("@O_MSG");
                //_sqlcode = db.DbPgetInt("@O_SQLCODE");
                //_dbmsg = db.DbPgetString("@O_SQLMSG");
                //_proc_name = db.DbPgetString("@O_PROC_NAME");
                //_strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }
        public DataSet GetOrder()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                        ");
            strSQL.Append(" MC_CKD_NO AS HEAD_NO                ");
            strSQL.Append(" FROM PLAN_PROD_MC_CKD_HEADER                  ");
            strSQL.Append(" ORDER BY HEAD_NO      ");

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "Cal");
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
        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            if (_db_type == "ORACLE")
            {
                strSQL.Append("DELETE FROM PLAN_PROD_MC_CKD_DETAIL ");
                strSQL.Append(" WHERE MC_CKD_NO = :MC_CKD_NO");

                db.DbParametersClear();
                db.DbPsetString("MC_CKD_NO", _mc_ckd_no);
            }
            else
            {
                strSQL.Append("DELETE FROM PLAN_PROD_MC_CKD_DETAIL ");
                strSQL.Append(" WHERE MC_CKD_NO = @MC_CKD_NO");

                db.DbParametersClear();
                db.DbPsetString("@MC_CKD_NO", _mc_ckd_no);
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
    }
}
