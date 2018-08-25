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
    public class KDImport
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public KDImport()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public KDImport(string p_user_id, int p_lang)
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
        protected string _order_no = "";
        protected DateTime _order_date;
        protected string _pc_no = "";
        protected string _part_delivery = "";
        protected DateTime _packing_date;
        protected DateTime _packing_list_to_lb;
        protected DateTime _etd_date;
        protected DateTime _eta_date;
        protected string _ship_by = "";
        protected DateTime _rta;
        protected DateTime _issue_date;
        protected string _model_code = "";
        protected string _model_type = "";
        protected string _issue_by = "";
        protected string _remark = "";
        protected string _kd_special_no = "";
        protected int _kd_line_no = 0;
        protected string _part_no = "";
        protected string _color = "";
        protected int _fg_qty = 0;
        protected string _del_from = "";
        protected string _del_to = "";
        protected string _plan_code = "";
        protected int _req_no = 0;



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
        public string order_no { get { return _order_no; } set { _order_no = value; } }
        public DateTime order_date { get { return _order_date; } set { _order_date = value; } }
        public string pc_no { get { return _pc_no; } set { _pc_no = value; } }
        public string part_delivery { get { return _part_delivery; } set { _part_delivery = value; } }
        public DateTime packing_date { get { return _packing_date; } set { _packing_date = value; } }
        public DateTime packing_list_to_lb { get { return _packing_list_to_lb; } set { _packing_list_to_lb = value; } }
        public DateTime etd_date { get { return _etd_date; } set { _etd_date = value; } }
        public DateTime eta_date { get { return _eta_date; } set { _eta_date = value; } }
        public string ship_by { get { return _ship_by; } set { _ship_by = value; } }
        public DateTime rta { get { return _rta; } set { _rta = value; } }
        public DateTime issue_date { get { return _issue_date; } set { _issue_date = value; } }
        public string model_code { get { return _model_code; } set { _model_code = value; } }
        public string model_type { get { return _model_type; } set { _model_type = value; } }
        public string issue_by { get { return _issue_by; } set { _issue_by = value; } }
        public string remark { get { return _remark; } set { _remark = value; } }
        public string kd_special_no { get { return _kd_special_no; } set { _kd_special_no = value; } }
        public int kd_line_no { get { return _kd_line_no; } set { _kd_line_no = value; } }
        public string part_no { get { return _part_no; } set { _part_no = value; } }
        public string color { get { return _color; } set { _color = value; } }
        public int fg_qty { get { return _fg_qty; } set { _fg_qty = value; } }
        public string del_from { get { return _del_from; } set { _del_from = value; } }
        public string del_to { get { return _del_to; } set { _del_to = value; } }
        public string plan_code { get { return _plan_code; } set { _plan_code = value; } }
        public int req_no { get { return _req_no; } set { _req_no = value; } }



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
            //rtnkd_prod_no = "";
            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@KD_SPECIAL_NO", _kd_special_no, ComConst.DB_IN);
            db.DbPsetString("@ORDER_NO", _order_no, ComConst.DB_IN);
            db.DbPsetDate("@ORDER_DATE", _order_date, ComConst.DB_IN);
            db.DbPsetString("@PC_NO", _pc_no, ComConst.DB_IN);
            db.DbPsetString("@PART_DELIVERY", _part_delivery, ComConst.DB_IN);
            db.DbPsetDate("@PACKING_DATE", _packing_date, ComConst.DB_IN);
            db.DbPsetDate("@PACKING_LIST_TO_LB", _packing_list_to_lb, ComConst.DB_IN);
            db.DbPsetDate("@ETD_DATE", _etd_date, ComConst.DB_IN);
            db.DbPsetDate("@ETA_DATE", _eta_date, ComConst.DB_IN);
            db.DbPsetString("@SHIP_BY", _ship_by, ComConst.DB_IN);
            db.DbPsetDate("@RTA", _rta, ComConst.DB_IN);
            db.DbPsetDate("@ISSUE_DATE", _issue_date, ComConst.DB_IN);
            db.DbPsetString("@MODEL_CODE", _model_code, ComConst.DB_IN);
            db.DbPsetString("@MODEL_TYPE", _model_type, ComConst.DB_IN);
            db.DbPsetString("@ISSUE_BY", _issue_by, ComConst.DB_IN);
            db.DbPsetString("@REMARK", _remark, ComConst.DB_IN);
            db.DbPsetString("@CREATE_BY", _chg_user_id, ComConst.DB_IN);
            //db.DbPsetString("@rtnHEAD_NO", rtnkd_prod_no, ComConst.DB_OUT);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PLAN_PROD_KD_HEADER_INSERT");
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
            //rtnkd_prod_no = db.DbPgetString("@rtnHEAD_NO");
            return rtn;
        }

        public int DetailInsert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;
            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@KD_SPECIAL_NO", _kd_special_no, ComConst.DB_IN);
            db.DbPsetInt("@KD_LINE_NO", _kd_line_no, ComConst.DB_IN);
            db.DbPsetString("@PART_NO", _part_no, ComConst.DB_IN);
            db.DbPsetString("@COLOR", _color, ComConst.DB_IN);
            db.DbPsetInt("@FG_QTY", _fg_qty, ComConst.DB_IN);
            db.DbPsetString("@DEL_FROM", _del_from, ComConst.DB_IN);
            db.DbPsetString("@DEL_TO", _del_to, ComConst.DB_IN);
            db.DbPsetString("@PLAN_CODE", _plan_code, ComConst.DB_IN);
            db.DbPsetInt("@REQ_NO", _req_no, ComConst.DB_IN);


            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PLAN_PROD_KD_DETAIL_INSERT");
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
            db.DbPsetString("@KD_SPECIAL_NO", _kd_special_no, ComConst.DB_IN);
            db.DbPsetString("@ORDER_NO", _order_no, ComConst.DB_IN);
            db.DbPsetDate("@ORDER_DATE", _order_date, ComConst.DB_IN);
            db.DbPsetString("@PC_NO", _pc_no, ComConst.DB_IN);
            db.DbPsetString("@PART_DELIVERY", _part_delivery, ComConst.DB_IN);
            db.DbPsetDate("@PACKING_DATE", _packing_date, ComConst.DB_IN);
            db.DbPsetDate("@PACKING_LIST_TO_LB", _packing_list_to_lb, ComConst.DB_IN);
            db.DbPsetDate("@ETD_DATE", _etd_date, ComConst.DB_IN);
            db.DbPsetDate("@ETA_DATE", _eta_date, ComConst.DB_IN);
            db.DbPsetString("@SHIP_BY", _ship_by, ComConst.DB_IN);
            db.DbPsetDate("@RTA", _rta, ComConst.DB_IN);
            db.DbPsetDate("@ISSUE_DATE", _issue_date, ComConst.DB_IN);
            db.DbPsetString("@MODEL_CODE", _model_code, ComConst.DB_IN);
            db.DbPsetString("@MODEL_TYPE", _model_type, ComConst.DB_IN);
            db.DbPsetString("@ISSUE_BY", _issue_by, ComConst.DB_IN);
            db.DbPsetString("@REMARK", _remark, ComConst.DB_IN);
            db.DbPsetString("@CREATE_BY", _chg_user_id, ComConst.DB_IN);


            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PLAN_PROD_KD_HEADER_UPDATE");
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
            db.DbPsetString("@KD_SPECIAL_NO", _kd_special_no, ComConst.DB_IN);
            db.DbPsetInt("@KD_LINE_NO", _kd_line_no, ComConst.DB_IN);
            db.DbPsetString("@PART_NO", _part_no, ComConst.DB_IN);
            db.DbPsetString("@COLOR", _color, ComConst.DB_IN);
            db.DbPsetInt("@FG_QTY", _fg_qty, ComConst.DB_IN);
            db.DbPsetString("@DEL_FROM", _del_from, ComConst.DB_IN);
            db.DbPsetString("@DEL_TO", _del_to, ComConst.DB_IN);
            db.DbPsetString("@PLAN_CODE", _plan_code, ComConst.DB_IN);
            db.DbPsetInt("@REQ_NO", _req_no, ComConst.DB_IN);


            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_PLAN_PROD_KD_DETAIL_UPDATE");
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
        public DataSet GetOrder()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                        ");
            strSQL.Append(" KD_SPECIAL_NO AS HEAD_NO            ");
            strSQL.Append(" FROM PLAN_PROD_KD_HEADER   ");
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
                strSQL.Append("DELETE FROM PLAN_PROD_KD_DETAIL ");
                strSQL.Append(" WHERE KD_SPECIAL_NO = :KD_SPECIAL_NO");

                db.DbParametersClear();
                db.DbPsetString("KD_SPECIAL_NO", _kd_special_no);
            }
            else
            {
                strSQL.Append("DELETE FROM PLAN_PROD_KD_DETAIL ");
                strSQL.Append(" WHERE KD_SPECIAL_NO = @KD_SPECIAL_NO");

                db.DbParametersClear();
                db.DbPsetString("@KD_SPECIAL_NO", _kd_special_no);
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
