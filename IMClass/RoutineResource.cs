using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

namespace IMClass
{
    public class RoutineResource
    {
        #region : 資源マスタメンテ

        /// <summary>
        /// 資源マスタメンテ

        /// </summary>
        public RoutineResource()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public RoutineResource(string p_user_id, int p_lang)
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
        protected int _pty_no = 0;
        protected string _resource_cd = "";
        protected string _resource_desc = "";
        protected double _setup_time = 0;
        protected double _unit_time = 0;
        protected double _unit_qty = 0;
        protected double _transfer_time = 0;
        protected double _mfg_lot_qty = 0;
        protected string _spec_cd = "";
        protected string _spec_desc = "";
        protected string _jigu = "";
        protected string _die = "";

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

        public int lang { get { return _lang; } set { _lang = value; } }
        public string item_no { get { return _item_no; } set { _item_no = value; } }
        public string item_desc { get { return _item_desc; } set { _item_desc = value; } }
        public string ws_cd { get { return _ws_cd; } set { _ws_cd = value; } }
        public string ws_desc { get { return _ws_desc; } set { _ws_desc = value; } }
        public int routine_seq { get { return _routine_seq; } set { _routine_seq = value; } }
        public string process_cd { get { return _process_cd; } set { _process_cd = value; } }
        public string process_desc { get { return _process_desc; } set { _process_desc = value; } }
        public int pty_no { get { return _pty_no; } set { _pty_no = value; } }
        public string resource_cd { get { return _resource_cd; } set { _resource_cd = value; } }
        public string resource_desc { get { return _resource_desc; } set { _resource_desc = value; } }
        public double setup_time { get { return _setup_time; } set { _setup_time = value; } }
        public double unit_time { get { return _unit_time; } set { _unit_time = value; } }
        public double unit_qty { get { return _unit_qty; } set { _unit_qty = value; } }
        public double transfer_time { get { return _transfer_time; } set { _transfer_time = value; } }
        public double mfg_lot_qty { get { return _mfg_lot_qty; } set { _mfg_lot_qty = value; } }
        public string spec_cd { get { return _spec_cd; } set { _spec_cd = value; } }
        public string spec_desc { get { return _spec_desc; } set { _spec_desc = value; } }
        public string jigu { get { return _jigu; } set { _jigu = value; } }
        public string die { get { return _die; } set { _die = value; } }

        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string errmsg { get { return _errmsg; } set { _errmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }
        public int errcode { get { return _errcode; } set { _errcode = value; } }
        public int sqlcode { get { return _sqlcode; } set { _sqlcode = value; } }
        #endregion

        /// <summary>
        /// 製造資源の追加
        /// 
        /// 使用画面：MstRoutineResourceMnt
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
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_PTY_NO", _pty_no, ComConst.DB_IN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_SETUP_TIME", _setup_time, ComConst.DB_IN);
            db.DbPsetDouble("@I_UNIT_TIME", _unit_time, ComConst.DB_IN);
            db.DbPsetDouble("@I_UNIT_QTY", _unit_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_TRANSFER_TIME", _transfer_time, ComConst.DB_IN);
            db.DbPsetDouble("@I_MFG_LOT_QTY", _mfg_lot_qty, ComConst.DB_IN);
            db.DbPsetString("@I_SPEC_CD", _spec_cd, ComConst.DB_IN);
            db.DbPsetString("@I_JIGU", _jigu, ComConst.DB_IN);
            db.DbPsetString("@I_DIE", _die, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_ROUTINE_RESOURCE_INSERT");
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
        /// 製造資源の変更
        /// 
        /// 使用画面：MstRoutineResourceMnt
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
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_PTY_NO", _pty_no, ComConst.DB_IN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_SETUP_TIME", _setup_time, ComConst.DB_IN);
            db.DbPsetDouble("@I_UNIT_TIME", _unit_time, ComConst.DB_IN);
            db.DbPsetDouble("@I_UNIT_QTY", _unit_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_TRANSFER_TIME", _transfer_time, ComConst.DB_IN);
            db.DbPsetDouble("@I_MFG_LOT_QTY", _mfg_lot_qty, ComConst.DB_IN);
            db.DbPsetString("@I_SPEC_CD", _spec_cd, ComConst.DB_IN);
            db.DbPsetString("@I_JIGU", _jigu, ComConst.DB_IN);
            db.DbPsetString("@I_DIE", _die, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_ROUTINE_RESOURCE_UPDATE");
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
        /// 製造資源の削除
        /// 
        /// 使用画面：MstRoutineResourceMnt
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
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_PTY_NO", _pty_no, ComConst.DB_IN);
            db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);            

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);

            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_ROUTINE_RESOURCE_DELETE");
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
        /// 製造資源一覧の取得

        /// 
        /// 使用画面：MstRoutineResourceMnt
        /// </summary>
        public DataSet GetItemRoutineResourceList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("R.ITEM_NO,			R.WS_CD,			R.ROUTINE_SEQ,		R.PROCESS_CD,	  ");
            strSQL.Append("R.BEG_EFF_DATE,		R.END_EFF_DATE,      ");
            strSQL.Append("RR.PTY_NO,			RR.RESOURCE_CD,        ");
            strSQL.Append("I.ITEM_DESC AS ITEM_DESC, W.WS_DESC AS WS_DESC,    ");
            strSQL.Append("P.PROCESS_DESC AS PROCESS_DESC,");
            strSQL.Append("RE.RESOURCE_DESC AS RESOURCE_DESC ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ROUTINE_MASTER R, ROUTINE_RESOURCE_MASTER RR, ITEM_MASTER I, ");
                strSQL.Append(" WORKSHOP_MASTER W, PROCESS_MASTER P, RESOURCE_MASTER RE");
                strSQL.Append(" WHERE R.ITEM_NO             = :ITEM_NO");
                strSQL.Append("   AND R.WS_CD               = :WS_CD");
                strSQL.Append("   AND R.ITEM_NO             = RR.ITEM_NO(+)");
                strSQL.Append("   AND R.WS_CD               = RR.WS_CD(+)");
                strSQL.Append("   AND R.ROUTINE_SEQ         = RR.ROUTINE_SEQ(+)");
                strSQL.Append("   AND R.PROCESS_CD          = RR.PROCESS_CD(+)");
                //strSQL.Append("   AND R.RESOURCE_CD         = RR.RESOURCE_CD(+)");
                strSQL.Append("   AND R.ITEM_NO             = I.ITEM_NO(+)");
                strSQL.Append("   AND R.WS_CD               = W.WS_CD(+)");
                strSQL.Append("   AND R.WS_CD               = P.WS_CD(+)");
                strSQL.Append("   AND R.PROCESS_CD          = P.PROCESS_CD(+)");
                strSQL.Append("   AND RR.RESOURCE_CD        = RE.RESOURCE_CD(+)");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WS_CD", _ws_cd);
            }
            else
            {

                strSQL.Append(" FROM ROUTINE_MASTER R ");
                strSQL.Append(" LEFT OUTER JOIN ROUTINE_RESOURCE_MASTER RR ON R.ITEM_NO=RR.ITEM_NO ");
                strSQL.Append("      AND R.WS_CD=RR.WS_CD AND R.ROUTINE_SEQ=RR.ROUTINE_SEQ");
                strSQL.Append("      AND R.PROCESS_CD=RR.PROCESS_CD ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON R.WS_CD = W.WS_CD");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON R.ITEM_NO = I.ITEM_NO");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER P ON R.WS_CD = P.WS_CD AND R.PROCESS_CD = P.PROCESS_CD");
                strSQL.Append(" LEFT OUTER JOIN RESOURCE_MASTER RE ON RR.RESOURCE_CD=RE.RESOURCE_CD");
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
        /// 製造資源詳細の取得

        /// 
        /// 使用画面：MstRoutineResourceMnt
        /// </summary>
        public int GetRoutineResourceDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("R.ITEM_NO,			R.WS_CD,			R.ROUTINE_SEQ,		R.PROCESS_CD,	  ");
            strSQL.Append("R.PTY_NO,			R.RESOURCE_CD,		R.SETUP_TIME,	    R.UNIT_TIME,      ");
            strSQL.Append("R.UNIT_QTY,			R.TRANSFER_TIME,	R.MFG_LOT_QTY,		R.SPEC_CD,        ");
            strSQL.Append("R.JIGU,				R.DIE,                                                    ");
            strSQL.Append("I.ITEM_DESC AS ITEM_DESC,");
            strSQL.Append("W.WS_DESC AS WS_DESC, P.PROCESS_DESC AS PROCESS_DESC, ");
            strSQL.Append("RO.BEG_EFF_DATE AS BEG_EFF_DATE, RO.END_EFF_DATE AS END_EFF_DATE, ");
            strSQL.Append("RE.RESOURCE_DESC AS RESOURCE_DESC, ");
            strSQL.Append("SP.DATA_CHAR AS SPEC_DESC ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ROUTINE_RESOURCE_MASTER R, ROUTINE_MASTER RO, ITEM_MASTER I, ");
                strSQL.Append(" WORKSHOP_MASTER W, PROCESS_MASTER P, RESOURCE_MASTER RE, SYSTEM_PARAMETER SP");
                strSQL.Append(" WHERE R.ITEM_NO             = :ITEM_NO");
                strSQL.Append("   AND R.WS_CD               = :WS_CD");
                strSQL.Append("   AND R.ROUTINE_SEQ         = :ROUTINE_SEQ");
                strSQL.Append("   AND R.PROCESS_CD          = :PROCESS_CD");
                //strSQL.Append("   AND R.PTY_NO              = :PTY_NO");
                strSQL.Append("   AND R.RESOURCE_CD         = :RESOURCE_CD");
                strSQL.Append("   AND R.ITEM_NO             = RO.ITEM_NO(+)");
                strSQL.Append("   AND R.WS_CD               = RO.WS_CD(+)");
                strSQL.Append("   AND R.ROUTINE_SEQ         = RO.ROUTINE_SEQ(+)");
                strSQL.Append("   AND R.ITEM_NO             = I.ITEM_NO(+)");
                strSQL.Append("   AND R.WS_CD               = W.WS_CD(+)");
                strSQL.Append("   AND R.WS_CD               = P.WS_CD(+)");
                strSQL.Append("   AND R.PROCESS_CD          = P.PROCESS_CD(+)");
                strSQL.Append("   AND R.RESOURCE_CD         = RE.RESOURCE_CD(+)");
                strSQL.Append("   AND SP.KEY01              = 'SPEC_CD'");
                strSQL.Append("   AND SP.KEY02              = R.SPEC_CD(+)");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WS_CD", _ws_cd);
                db.DbPsetInt("ROUTINE_SEQ", _routine_seq);
                db.DbPsetString("PROCESS_CD", _process_cd);
                //db.DbPsetInt("PTY_NO", _pty_no);
                db.DbPsetString("RESOURCE_CD", _resource_cd);
            }
            else
            {
                strSQL.Append(" FROM ROUTINE_RESOURCE_MASTER R ");
                strSQL.Append(" LEFT OUTER JOIN ROUTINE_MASTER RO ON R.ITEM_NO=RO.ITEM_NO ");
                strSQL.Append("      AND R.WS_CD=RO.WS_CD AND R.ROUTINE_SEQ=RO.ROUTINE_SEQ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON R.WS_CD = W.WS_CD");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON R.ITEM_NO = I.ITEM_NO");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER P ON R.WS_CD = P.WS_CD AND R.PROCESS_CD = P.PROCESS_CD");
                strSQL.Append(" LEFT OUTER JOIN RESOURCE_MASTER RE ON R.RESOURCE_CD=RE.RESOURCE_CD");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SP ON SP.KEY01 = 'SPEC_CD' AND SP.KEY02=R.SPEC_CD");
                strSQL.Append(" WHERE R.ITEM_NO = @ITEM_NO ");
                strSQL.Append("   AND R.WS_CD = @WS_CD ");
                strSQL.Append("   AND R.ROUTINE_SEQ = @ROUTINE_SEQ");
                strSQL.Append("   AND R.PROCESS_CD = @PROCESS_CD");
                //strSQL.Append("   AND R.PTY_NO = @PTY_NO");
                strSQL.Append("   AND R.RESOURCE_CD = @RESOURCE_CD");

                db.DbParametersClear();
                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WS_CD", _ws_cd);
                db.DbPsetInt("@ROUTINE_SEQ", _routine_seq);
                db.DbPsetString("@PROCESS_CD", _process_cd);
                //db.DbPsetInt("@PTY_NO", _pty_no);
                db.DbPsetString("@RESOURCE_CD", _resource_cd);
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
                _process_cd = db.Row("PROCESS_CD");                
                _pty_no = int.Parse(db.Row("PTY_NO"));
                _resource_cd = db.Row("RESOURCE_CD");                
                _setup_time = double.Parse(db.Row("SETUP_TIME"));
                _unit_time = double.Parse(db.Row("UNIT_TIME"));
                _unit_qty = double.Parse(db.Row("UNIT_QTY"));
                _transfer_time = double.Parse(db.Row("TRANSFER_TIME"));
                _mfg_lot_qty = double.Parse(db.Row("MFG_LOT_QTY"));
                _spec_cd = db.Row("SPEC_CD");                
                _jigu = db.Row("JIGU");
                _die = db.Row("DIE");
                _item_desc = db.Row("ITEM_DESC");
                _ws_desc = db.Row("WS_DESC");
                _process_desc = db.Row("PROCESS_DESC");
                _resource_desc = db.Row("RESOURCE_DESC");
                _spec_desc = db.Row("SPEC_DESC");
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

    }
}
