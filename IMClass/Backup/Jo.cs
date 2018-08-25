﻿﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Runtime.Serialization;
using System.Data;

namespace IMClass
{
    [Serializable]
    public class Jo
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Jo()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Jo(string p_user_id, int p_lang)
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
        protected string _mrp_whs_grp = ""; //ADD BY UBIQ-SUO 2011/02/17

        protected string _db_type = "";
        protected int _lang = 1;
        protected string _sch_id = "";
        protected string _sch_name = "";
        protected int _sch_start_date = 0;
        protected int _sch_start_date1 = 0;
        protected string _ws_cd = "";
        protected string _ws_desc = "";
        protected string _order_no = "";
        protected string _item_no = "";
        protected string _item_desc = "";
        protected double _job_order_qty = 0;
        protected string _order_umsr = "";
        protected string _process_cd = "";
        protected string _process_desc = "";
        protected string _joc_cd = "";
        protected int _sch_compl_date = 0;
        protected int _joc_split_no = 0;
        protected int _chkflag = 0;
        protected int _pgmflag = 0;

        protected string _demand_no = "";

        protected string _whs_cd = "";
        protected string _slip_note = "";
        protected string _job_order_no = "";
        protected int _print_type = 0;
        protected string _catg_cd = "";

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
        protected string _plan_no = "";

        //add by wanghui 2010/5/5 start
        protected int _alloc_flag = 0;
        protected int _miss_disb = 0;
        //add by wanghui 2010/5/5 end       

        protected string _table_type = "";//ADD BY UBIQ-LIU 2010/5/10
        protected string _parent_item_no = "";
        protected string _parent_order_no = "";
        protected int _chg_type;
        protected int _sub_action_flag;
        protected int _sch_disb_date;
        protected string _sub_grp_cd;
        protected double _plan_qty;
        protected int _usage_type;
        protected double _usage_dec;
        protected int _usage_numerator;
        protected int _usage_denominator;

        protected string _rcv_no = "";  // IMV3
        protected int _rcv_line_no = 0;  // IMV3
        protected int _idtag_unit_qty = 0;  // IMV3

        protected string _mark = "";    // IMV3
        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        //add by wanghui 2010/5/5 start
        public string mrp_whs_grp { get { return _mrp_whs_grp; } set { _mrp_whs_grp = value; } }
        public int alloc_flag { get { return _alloc_flag; } set { _alloc_flag = value; } }
        public int miss_disb { get { return _miss_disb; } set { _miss_disb = value; } }
        //add by wanghui 2010/5/5 end
        public int lang { get { return _lang; } set { _lang = value; } }
        public string sch_id { get { return _sch_id; } set { _sch_id = value; } }
        public string sch_name { get { return _sch_name; } set { _sch_name = value; } }
        public int sch_start_date { get { return _sch_start_date; } set { _sch_start_date = value; } }
        public int sch_start_date1 { get { return _sch_start_date1; } set { _sch_start_date1 = value; } }
        public string ws_cd { get { return _ws_cd; } set { _ws_cd = value; } }
        public string ws_desc { get { return _ws_desc; } set { _ws_desc = value; } }
        public string order_no { get { return _order_no; } set { _order_no = value; } }
        public string item_no { get { return _item_no; } set { _item_no = value; } }
        public string item_desc { get { return _item_desc; } set { _item_desc = value; } }
        public double job_order_qty { get { return _job_order_qty; } set { _job_order_qty = value; } }
        public string order_umsr { get { return _order_umsr; } set { _order_umsr = value; } }
        public string process_cd { get { return _process_cd; } set { _process_cd = value; } }
        public string process_desc { get { return _process_desc; } set { _process_desc = value; } }
        public string joc_cd { get { return _joc_cd; } set { _joc_cd = value; } }
        public int sch_compl_date { get { return _sch_compl_date; } set { _sch_compl_date = value; } }
        public int joc_split_no { get { return _joc_split_no; } set { _joc_split_no = value; } }
        public int chkflag { get { return _chkflag; } set { _chkflag = value; } }
        public int pgmflag { get { return _pgmflag; } set { _pgmflag = value; } }

        public string demand_no { get { return _demand_no; } set { _demand_no = value; } }
        public string whs_cd { get { return _whs_cd; } set { _whs_cd = value; } }
        public string slip_note { get { return _slip_note; } set { _slip_note = value; } }
        public string job_order_no { get { return _job_order_no; } set { _job_order_no = value; } }
        public int print_type { get { return _print_type; } set { _print_type = value; } }
        public string catg_cd { get { return _catg_cd; } set { _catg_cd = value; } }
        public string plan_no { get { return _plan_no; } set { _plan_no = value; } }

        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }

        public string table_type { get { return _table_type; } set { _table_type = value; } }//ADD BY UBIQ-LIU 2010/5/10

        public string parent_item_no { get { return _parent_item_no; } set { _parent_item_no = value; } }
        public string parent_order_no { get { return _parent_order_no; } set { _parent_order_no = value; } }
        public int chg_type { get { return _chg_type; } set { _chg_type = value; } }
        public int sub_action_flag { get { return _sub_action_flag; } set { _sub_action_flag = value; } }
        public int sch_disb_date { get { return _sch_disb_date; } set { _sch_disb_date = value; } }
        public string sub_grp_cd { get { return _sub_grp_cd; } set { _sub_grp_cd = value; } }
        public double plan_qty { get { return _plan_qty; } set { _plan_qty = value; } }
        public int usage_type { get { return _usage_type; } set { _usage_type = value; } }
        public double usage_dec { get { return _usage_dec; } set { _usage_dec = value; } }
        public int usage_numerator { get { return _usage_numerator; } set { _usage_numerator = value; } }
        public int usage_denominator { get { return _usage_denominator; } set { _usage_denominator = value; } }

        public string rcv_no { get { return _rcv_no; } set { _rcv_no = value; } }  // IMV3
        public int rcv_line_no { get { return _rcv_line_no; } set { _rcv_line_no = value; } }  // IMV3
        public int idtag_unit_qty { get { return _idtag_unit_qty; } set { _idtag_unit_qty = value; } }  // IMV3

        public string mark { get { return _mark; } set { _mark = value; } } // IMV3
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Mfg_JoRlseRpt()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append("PO.SCH_ID,		S1.DATA_CHAR SCH_NAME,	PO.SCH_START_DATE,	PO.WS_CD,	    ");
            strSQL.Append("W.WS_DESC,	    PO.ORDER_NO,            PO.ITEM_NO,         PO.ITEM_DESC,   ");
            strSQL.Append("PO.ORDER_QTY,    PO.ORDER_UMSR,          JO.PROCESS_CD,      PM.PROCESS_DESC,");
            strSQL.Append("JO.SCH_SETUP_TIME,   JO.SCH_WORK_TIME,   JO.SCH_TRANSFER_TIME,               ");
            strSQL.Append("S2.DATA_CHAR UMSR_NAME,                                                      ");
            strSQL.Append("PO.SCH_COMPL_DATE,       PO.JOC_CD,      PO.WHS_CD,          WH.WHS_DESC     ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PLANNED_ORDER PO,SYSTEM_PARAMETER S1,WORKSHOP_MASTER W,ROUTINE_MASTER RM,");
                strSQL.Append(" PROCESS_MASTER PM,WAREHOUSE_MASTER WH");
                strSQL.Append(" WHERE  PO.SC_FLAG = 0                 ");
                strSQL.Append("   AND  PO.ITEM_TYPE <> '99'           ");
                if (sch_id != "")
                {
                    strSQL.Append("  AND PO.SCH_ID              = :SCH_ID ");
                    db.DbPsetString("SCH_ID", _sch_id);
                }
                if (ws_cd != "")
                {
                    strSQL.Append("  AND PO.WS_CD           = :WS_CD ");
                    db.DbPsetString("WS_CD", _ws_cd);
                }
                if (sch_start_date != 0)
                {
                    strSQL.Append("  AND PO.SCH_START_DATE   <= :SCH_START_DATE ");
                    db.DbPsetInt("SCH_START_DATE", _sch_start_date);
                }
                strSQL.Append("  AND S1.KEY01   = 'SCH_ID'              ");
                strSQL.Append("  AND PO.SCH_ID  = S1.KEY02(+)           ");
                strSQL.Append("  AND PO.WS_CD   = W.WS_CD(+)            ");
                strSQL.Append("  AND PO.ITEM_NO = RM.ITEM_NO            ");
                strSQL.Append("  AND PO.WS_CD   = RM.WS_CD              ");
                strSQL.Append("  AND RM.WS_CD = PM.WS_CD      ");
                strSQL.Append("  AND RM.PROCESS_CD = PM.PROCESS_CD      ");
                strSQL.Append("  AND PO.WHS_CD   = WH.WHS_CD(+)         ");
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM PLANNED_ORDER PO                                                   ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON PO.SCH_ID      = S1.KEY02        ");
                strSQL.Append("  AND S1.KEY01   = 'SCH_ID'                                              ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'ITEM_UMSR'           ");
                strSQL.Append(" AND S2.KEY02        =       PO.ORDER_UMSR                               ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON PO.WS_CD         = W.WS_CD         ");
                strSQL.Append(" LEFT OUTER JOIN JOB_ORDER_DETAIL JO ON JO.ORDER_NO     = PO.ORDER_NO    ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PM ON PM.WS_CD         = JO.WS_CD        ");
                strSQL.Append(" AND JO.PROCESS_CD     = PM.PROCESS_CD                                   ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WH ON PO.WHS_CD      = WH.WHS_CD       ");
                strSQL.Append(" WHERE  PO.SC_FLAG = 0                 ");
                strSQL.Append("   AND  PO.ITEM_TYPE <> '99'           ");
                if (sch_id != "")
                {
                    strSQL.Append("  AND PO.SCH_ID              = @SCH_ID ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (ws_cd != "")
                {
                    strSQL.Append("  AND PO.WS_CD           = @WS_CD ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (sch_start_date != 0)
                {
                    strSQL.Append("  AND PO.SCH_START_DATE   <= @SCH_START_DATE ");//change '>=' to '<=' UBIQ-LIU 20090218
                    db.DbPsetInt("@SCH_START_DATE", _sch_start_date);
                }
            }
            strSQL.Append(" ORDER BY PO.ORDER_NO,JO.PROCESS_SEQ ");
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
        /// 
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Mfg_JoRlseList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append("PO.ITEM_NO,		PO.ITEM_DESC,	   PO.WS_CD,	        PO.ORDER_QTY,       ");
            //strSQL.Append("PO.JOB_ORDER_QTY,PO.ORDER_UMSR,     PO.SCH_START_DATE,   PO.SCH_COMPL_DATE,  ");
            strSQL.Append("PO.ORDER_UMSR,     PO.SCH_START_DATE,   PO.SCH_COMPL_DATE,                   ");
            strSQL.Append("PO.JOC_CD,       PO.WHS_CD,         PO.ALLOC_FLAG,       PO.ORDER_NO,        ");
            strSQL.Append("W.WHS_DESC,      S.DATA_CHAR UMSR_NAME, WS.WS_DESC                           ");
            strSQL.Append(",PO.MRP_WHS_GRP                          ");         //ADD BY UBIQ-SUO 2011/02/18
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PLANNED_ORDER PO , WAREHOUSE_MASTER W                              ");
                strSQL.Append(" WHERE  PO.SC_FLAG = 0                                                   ");
                strSQL.Append("   AND  PO.ITEM_TYPE <> '99'           ");
                if (sch_id != "")
                {
                    strSQL.Append("  AND PO.SCH_ID              = :SCH_ID ");
                    db.DbPsetString("SCH_ID", _sch_id);
                }
                if (ws_cd != "")
                {
                    strSQL.Append("  AND PO.WS_CD           = :WS_CD ");
                    db.DbPsetString("WS_CD", _ws_cd);
                }
                if (joc_cd != "")
                {
                    strSQL.Append("  AND PO.JOC_CD   <= :JOC_CD ");
                    db.DbPsetInt("JOC_CD", _sch_start_date);
                }
                if (sch_start_date != 0)
                {
                    strSQL.Append("  AND PO.SCH_START_DATE   <= :SCH_START_DATE ");
                    db.DbPsetInt("SCH_START_DATE", _sch_start_date);
                }
                strSQL.Append("  AND PO.WHS_CD = W.WHS_CD(+)                    ");
                //Add 10.08.19 Ubiq-Sai Start
                strSQL.Append("  AND PO.JOC_CD NOT IN (SELECT D.JOC_CD                              ");
                strSQL.Append("                          FROM SALES_ORDER S, SALES_ORDER_DETAIL D   ");
                strSQL.Append("                         WHERE S.ORDER_NO = D.ORDER_NO               ");
                strSQL.Append("                           AND S.PO_TYPE <> 0 )                      ");
                //Add 10.08.19 Ubiq-Sai End
            }
            else
            {
                strSQL.Append(" FROM PLANNED_ORDER PO                                                   ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON PO.WHS_CD      = W.WHS_CD         ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON PO.WS_CD       = WS.WS_CD         ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'             ");
                strSQL.Append(" AND S.KEY02        =       PO.ORDER_UMSR                                ");
                strSQL.Append(" WHERE  PO.SC_FLAG = 0                                                   ");
                strSQL.Append("   AND  PO.ITEM_TYPE <> '99'           ");

                //Add 10.08.19 Ubiq-Sai Start
                strSQL.Append("  AND PO.JOC_CD NOT IN (SELECT D.JOC_CD                              ");
                strSQL.Append("                          FROM SALES_ORDER S                         ");
                strSQL.Append("                         INNER JOIN SALES_ORDER_DETAIL D             ");
                strSQL.Append("                            ON S.ORDER_NO = D.ORDER_NO               ");
                strSQL.Append("                         WHERE S.PO_TYPE <> 0 )                      ");
                //Add 10.08.19 Ubiq-Sai End

                if (sch_id != "")
                {
                    strSQL.Append("  AND PO.SCH_ID              = @SCH_ID ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (ws_cd != "")
                {
                    strSQL.Append("  AND PO.WS_CD           = @WS_CD ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (joc_cd != "")
                {
                    strSQL.Append("  AND PO.JOC_CD   = @JOC_CD ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (sch_start_date != 0)
                {
                    strSQL.Append("  AND PO.SCH_START_DATE   <= @SCH_START_DATE ");
                    db.DbPsetInt("@SCH_START_DATE", _sch_start_date);
                }
            }

            try
            {
                strSQL.Append("  ORDER BY PO.SCH_START_DATE,   PO.SCH_COMPL_DATE ");
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
        /// 作業指示処理
        /// 
        /// </summary>
        /// <returns></returns>
        public int Mfg_JoRlse()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ORDER_NO", _order_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            //db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_MFG_JORLSE");
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
        /// オーダー№の計画所要情報を検索して子部品明細画面に表示
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Mfg_JoRlseDemandList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                                       ");
            strSQL.Append("PO.ORDER_NO,     PO.ITEM_NO PARENT_ITEM, PO.ITEM_DESC PARENT_ITEM_DESC,  PO.ORDER_QTY,       ");
            strSQL.Append("PO.ORDER_UMSR,   PO.SCH_ID,              PO.JOC_CD,                      PO.SCH_START_DATE,  ");
            strSQL.Append("PO.WS_CD,        PD.ITEM_NO CHILD_ITEM,  IM.ITEM_DESC CHILD_ITEM_DESC,   PD.PLAN_QTY,        ");
            strSQL.Append("PD.PROCESS_CD,   PM.PROCESS_DESC,        PD.SCH_DISB_DATE,               PD.DISB_WHS,        ");
            //add by wanghui 2010/5/5 start
            //strSQL.Append(" PD.ALLOC_FLAG, PD.PLAN_DISB_QTY,                                                             ");
            //2011.06.08 ADD
            strSQL.Append(" CASE WHEN IM.AUTO_DISB_TYPE = 1 THEN  9  ELSE PD.ALLOC_FLAG    END ALLOC_FLAG ,                ");
            strSQL.Append(" CASE WHEN IM.AUTO_DISB_TYPE = 1 THEN  0  ELSE PD.PLAN_DISB_QTY END PLAN_DISB_QTY ,             ");
            //add by wanghui 2010/5/5 end
            strSQL.Append("isnull(INV.INV_QTY,0) INV_QTY,           isnull(WIP.WIP_QTY,0) WIP_QTY,                      ");
            strSQL.Append(" (CASE WHEN (PD.ALLOC_QTY-PD.ACT_DISB_QTY)<0 then 0 ELSE (PD.ALLOC_QTY-PD.ACT_DISB_QTY) END) ALLOC_QTY,       ");
            //add by wanghui 2010/5/5 start
            strSQL.Append("INV.INV_INV_BAL, WIP.WIP_INV_BAL,                                                            ");
            //add by wanghui 2010/5/5 end
            strSQL.Append("PD.DEMAND_NO,    PD.DEMAND_NO TO_DEMAND_NO,      COUNT(D2.ORDER_NO) QTY_FLAG,                ");
            strSQL.Append("isnull(WIPALLOC.WIP_ALLOC_QTY,0) WIP_ALLOC_QTY,          S.DATA_CHAR UMSR_NAME               ");
            //2009.08.11 ADD
            strSQL.Append(",W.WS_DESC,      S1.DATA_CHAR SCH_DESC                                                       ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PLANNED_DEMAND PD , PLANNED_ORDER PO,                              ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD,               ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) INV_QTY        ");
                //add by wanghui  2010/5/5 start
                strSQL.Append(" ,SUM(INVENTORY_DETAIL.INV_BAL) INV_INV_BAL                              ");	//SUM（INVENTORY_DETAIL.現在庫数）倉庫在庫数	
                //add by wanghui  2010/5/5 end  
                strSQL.Append(" FROM    INVENTORY_DETAIL,PLANNED_DEMAND                                 ");
                strSQL.Append(" WHERE   PLANNED_DEMAND.ORDER_NO =   :ORDER_NO                           ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 0                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.ITEM_NO = PLANNED_DEMAND.ITEM_NO(+)            ");
                strSQL.Append(" AND     INVENTORY_DETAIL.WHS_CD = PLANNED_DEMAND.DISB_WHS(+)  )  INV,   ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD,               ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) WIP_QTY        ");
                //add by wanghui  2010/5/5 start
                strSQL.Append(" ,SUM(INVENTORY_DETAIL.INV_BAL) WIP_INV_BAL                              ");//SUM（INVENTORY_DETAIL.	現在庫数）現場在庫数	
                //add by wanghui  2010/5/5 end    
                strSQL.Append(" FROM    INVENTORY_DETAIL,PLANNED_DEMAND                                 ");
                strSQL.Append(" WHERE   PLANNED_DEMAND.ORDER_NO =   :ORDER_NO                           ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 1                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.ITEM_NO = PLANNED_DEMAND.ITEM_NO(+)            ");
                strSQL.Append(" AND     INVENTORY_DETAIL.WS_CD = PLANNED_DEMAND.WS_CD(+)  )  WIP,       ");

                strSQL.Append(" (SELECT WIP_ALLOC.DEMAND_NO,SUM(WIP_ALLOC.ALLOC_QTY)                    ");
                strSQL.Append(" FROM    WIP_ALLOC,PLANNED_DEMAND                                        ");
                strSQL.Append(" WHERE   PLANNED_DEMAND.ORDER_NO =   :ORDER_NO                           ");
                strSQL.Append(" AND     PLANNED_DEMAND.ORDER_NO =   WIP_ALLOC.ORDER_NO                  ");
                strSQL.Append(" AND     WIP_ALLOC.ALLOC_STATUS  =   0                                   ");
                strSQL.Append(" AND     WIP_ALLOC.SCH_FLAG      IN (0,2)                  )  WIPALLOC   ");

                strSQL.Append(" WHERE  PD.ORDER_NO =   :ORDER_NO                                        ");
                strSQL.Append(" AND  PD.ITEM_NO =   INV.ITEM_NO                                         ");
                strSQL.Append(" AND  PD.WHS_CD =   INV.WHS_CD                                           ");
                strSQL.Append(" AND  PD.ITEM_NO =   WIP.ITEM_NO                                         ");
                strSQL.Append(" AND  PD.DISB_WHS =   WIP.WS_CD                                          ");
                strSQL.Append(" AND  PD.ORDER_NO =   PO.ORDER_NO                                        ");
                strSQL.Append(" AND  (PD.SUB_GRP_CD = '' OR (PD.SUB_GRP_CD <> '' AND PD.SUB_ACTION_FLAG = 1)) ");
                strSQL.Append(" AND  PD.ITEM_TYPE <> '99'           ");
                //add by wanghui 2010/5/5 start
                if (alloc_flag == 1)
                {
                    strSQL.Append(" AND   PD.PLAN_DISB_QTY > 0                   ");
                }
                //add by wanghui 2010/5/5 end

                db.DbPsetString("ORDER_NO", _order_no);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PLANNED_DEMAND PD                                                  ");
                strSQL.Append(" LEFT OUTER JOIN PLANNED_ORDER PO ON  PD.ORDER_NO =   PO.ORDER_NO        ");
                //2009.08.11 ADD BEGIN
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON  PO.WS_CD =   W.WS_CD              ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON  S1.KEY01 = 'SCH_ID'             ");
                strSQL.Append(" AND S1.KEY02 = PO.SCH_ID                                                ");
                // ADD END 
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD,               ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) INV_QTY        ");
                //add by wanghui  2010/5/5 start
                strSQL.Append(" ,SUM(INVENTORY_DETAIL.INV_BAL) INV_INV_BAL                              ");	//SUM（INVENTORY_DETAIL.現在庫数）倉庫在庫数	
                //add by wanghui  2010/5/5 end  

                //strSQL.Append(" FROM    INVENTORY_DETAIL,PLANNED_DEMAND                                 ");//DEL 20090713 UBIQ-LIU
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                //strSQL.Append(" WHERE   PLANNED_DEMAND.ORDER_NO =   @ORDER_NO                           ");
                //strSQL.Append(" AND     INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" WHERE     INVENTORY_DETAIL.INV_YM =   0                                 ");//UPD 20090713 UBIQ-LIU
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 0                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                //strSQL.Append(" AND     INVENTORY_DETAIL.ITEM_NO = PLANNED_DEMAND.ITEM_NO               ");
                //strSQL.Append(" AND     INVENTORY_DETAIL.WHS_CD = PLANNED_DEMAND.DISB_WHS               ");
                strSQL.Append(" GROUP BY  INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD )  INV ON    ");
                strSQL.Append("      PD.ITEM_NO =   INV.ITEM_NO                                         ");
                strSQL.Append(" AND  PD.DISB_WHS =   INV.WHS_CD                                         ");
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD,                ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) WIP_QTY        ");
                //add by wanghui  2010/5/5 start
                strSQL.Append(" ,SUM(INVENTORY_DETAIL.INV_BAL) WIP_INV_BAL                              ");//SUM（INVENTORY_DETAIL.	現在庫数）現場在庫数	
                //add by wanghui  2010/5/5 end  
                //strSQL.Append(" FROM    INVENTORY_DETAIL,PLANNED_DEMAND                                 ");
                //strSQL.Append(" WHERE   PLANNED_DEMAND.ORDER_NO =   @ORDER_NO                           ");
                //strSQL.Append(" AND     INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 1                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                //strSQL.Append(" AND     INVENTORY_DETAIL.ITEM_NO = PLANNED_DEMAND.ITEM_NO               ");
                //strSQL.Append(" AND     INVENTORY_DETAIL.WS_CD = PLANNED_DEMAND.WS_CD                   ");
                strSQL.Append(" GROUP BY  INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD  )  WIP  ON   ");
                strSQL.Append("      PD.ITEM_NO =   WIP.ITEM_NO                                         ");
                //strSQL.Append(" AND  PD.WS_CD =   WIP.WS_CD                                             ");
                strSQL.Append(" AND  WIP.WS_CD =   CASE WHEN COALESCE(W.REP_WS_CD,'') = '' THEN PD.WS_CD ELSE W.REP_WS_CD END "); // 2011.03.09
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT WIP_ALLOC.DEMAND_NO,SUM(WIP_ALLOC.ALLOC_QTY) WIP_ALLOC_QTY      ");
                strSQL.Append(" FROM    WIP_ALLOC,PLANNED_DEMAND                                        ");
                strSQL.Append(" WHERE   PLANNED_DEMAND.ORDER_NO =   @ORDER_NO                           ");
                strSQL.Append(" AND     PLANNED_DEMAND.DEMAND_NO =   WIP_ALLOC.DEMAND_NO                ");
                strSQL.Append(" AND     WIP_ALLOC.ALLOC_STATUS  =   0                                   ");
                strSQL.Append(" AND     WIP_ALLOC.SCH_FLAG      IN (0,2)                                ");
                strSQL.Append(" GROUP BY  WIP_ALLOC.DEMAND_NO   )  WIPALLOC  ON                         ");
                strSQL.Append("      PD.DEMAND_NO    =   WIPALLOC.DEMAND_NO                             ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER IM ON PD.ITEM_NO = IM.ITEM_NO               ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'             ");
                //strSQL.Append(" AND S.KEY02        =       PO.ORDER_UMSR                                ");   //Del 10.08.10 Ubiq-Sai
                strSQL.Append(" AND S.KEY02        =       PD.ITEM_UMSR                                ");      //Add 10.08.10 Ubiq-Sai

                strSQL.Append(" LEFT OUTER JOIN PLANNED_DEMAND D2 ON D2.ORDER_NO    =   PD.ORDER_NO     ");
                strSQL.Append(" AND  D2.SUB_GRP_CD     = PD.SUB_GRP_CD                                  ");
                strSQL.Append(" AND    D2.SUB_GRP_CD <> ''                                              ");
                strSQL.Append(" AND    D2.SUB_ACTION_FLAG = 0                                           ");
                strSQL.Append(" AND  D2.ITEM_TYPE <> '99'                                               ");

                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PM ON PD.WS_CD = PM.WS_CD AND PD.PROCESS_CD = PM.PROCESS_CD      ");
                strSQL.Append(" WHERE   PD.ORDER_NO     =   @ORDER_NO                                   ");
                strSQL.Append(" AND (PD.SUB_GRP_CD = '' OR (PD.SUB_GRP_CD <> '' AND PD.SUB_ACTION_FLAG = 1)) ");
                strSQL.Append(" AND  PD.ITEM_TYPE <> '99'                                               ");
                //add by wanghui 2010/5/5 start
                if (alloc_flag == 1)
                {
                    strSQL.Append("  AND   PD.PLAN_DISB_QTY > 0                   ");
                }
                //add by wanghui 2010/5/5 end

                db.DbPsetString("@ORDER_NO", _order_no);
            }
            strSQL.Append(" GROUP BY PO.ORDER_NO,       PO.ITEM_NO,     PO.ITEM_DESC,       PO.ORDER_QTY,       ");
            strSQL.Append("PO.ORDER_UMSR,   PO.SCH_ID,      PO.JOC_CD,                      PO.SCH_START_DATE,  ");
            strSQL.Append("PO.WS_CD,        PD.ITEM_NO ,    IM.ITEM_DESC ,                  PD.PLAN_QTY,        ");
            strSQL.Append("PD.PROCESS_CD,   PM.PROCESS_DESC,       PD.SCH_DISB_DATE,        PD.DISB_WHS,        ");
            //add by wanghui 2010/5/5 start
            strSQL.Append(" PD.ALLOC_FLAG, PD.PLAN_DISB_QTY,                                                    ");
            //add by wanghui 2010/5/5 end
            strSQL.Append("INV.INV_QTY,       PD.ALLOC_QTY,       WIP.WIP_QTY,                                  ");
            //add by wanghui 2010/5/5 start
            strSQL.Append(" INV.INV_INV_BAL, WIP.WIP_INV_BAL,                                                   ");
            //add by wanghui 2010/5/5 end   
            strSQL.Append("PD.DEMAND_NO, PD.PART_SEQ,                                                           ");     //10.08.25 Ubiq-Sai Add PART_SEQ
            strSQL.Append("WIPALLOC.WIP_ALLOC_QTY, PD.ACT_DISB_QTY,         S.DATA_CHAR                         ");
            strSQL.Append(",W.WS_DESC,      S1.DATA_CHAR                                                        ");
            strSQL.Append(",IM.AUTO_DISB_TYPE                                                                   ");     // 2011.06.08
            strSQL.Append(" ORDER BY PD.PART_SEQ, CHILD_ITEM                                                    ");     //10.08.25 Ubiq-Sai Add PART_SEQ

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
        /// 入力品目コード、作業区コード、指示数にて製造工程順序を検索して工程情報を表示する
        /// </summary>
        /// <returns></returns>
        public DataSet GetRoutineList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                           ");
            strSQL.Append("RM.PROCESS_CD,     PM.PROCESS_DESC,      RM.UNIT_TIME,       RM.UNIT_QTY,        ");
            strSQL.Append("RM.LT_TYPE,        RM.SETUP_TIME,        RM.TRANSFER_TIME,   RM.TRANSFER_LT,     ");
            strSQL.Append("RM.MFG_LT,         RM.DAILY_PROD_QTY                                             ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM ROUTINE_MASTER RM  ,PROCESS_MASTER PM                              ");
                strSQL.Append(" WHERE   RM.ITEM_NO = :ITEM_NO                                           ");
                strSQL.Append(" AND     RM.WS_CD   = :WS_CD                                             ");
                strSQL.Append(" AND     RM.BEG_EFF_DATE <= convert(char(8),getdate(),112)               ");
                strSQL.Append(" AND     RM.END_EFF_DATE >= convert(char(8),getdate(),112)               ");
                strSQL.Append(" AND     RM.WS_CD =PM.WS_CD(+)                                           ");
                strSQL.Append(" AND     RM.PROCESS_CD =PM.PROCESS_CD(+)                                 ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WS_CD", _ws_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM ROUTINE_MASTER RM                                                  ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PM  ON  RM.WS_CD =PM.WS_CD               ");
                strSQL.Append(" AND RM.PROCESS_CD =PM.PROCESS_CD                                        ");
                strSQL.Append(" WHERE   RM.ITEM_NO = @ITEM_NO                                           ");
                strSQL.Append(" AND     RM.WS_CD   = @WS_CD                                             ");
                strSQL.Append(" AND     RM.BEG_EFF_DATE <= convert(char(8),getdate(),112)               ");
                strSQL.Append(" AND     RM.END_EFF_DATE >= convert(char(8),getdate(),112)               ");

                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WS_CD", _ws_cd);
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
        ///// <summary>
        ///// 作業指示処理
        ///// 不使用
        ///// </summary>
        ///// <returns></returns>
        //public int Mfg_ManJoRlse()
        //{
        //    ComDB db = new ComDB(_db_type);
        //    int rtn = 0;

        //    db.DbParametersClear();

        //    db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
        //    db.DbPsetString("@I_SCH_ID", _sch_id, ComConst.DB_IN);
        //    db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
        //    db.DbPsetString("@I_ITEM_DESC", _item_desc, ComConst.DB_IN);
        //    db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
        //    db.DbPsetInt("@I_SCH_START_DATE", _sch_start_date, ComConst.DB_IN);
        //    db.DbPsetDouble("@I_JOB_ORDER_QTY", _job_order_qty, ComConst.DB_IN);
        //    db.DbPsetInt("@I_SCH_COMPL_DATE", _sch_compl_date, ComConst.DB_IN);
        //    db.DbPsetString("@I_JOC_CD", _joc_cd, ComConst.DB_IN);
        //    db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
        //    db.DbPsetString("@I_SLIP_NOTE", _slip_note, ComConst.DB_IN);
        //    db.DbPsetInt("@I_EXPL_FLAG", _chkflag, ComConst.DB_IN);
        //    db.DbPsetInt("@I_USE_MFG_LOT_FLAG", _usemfglotflag, ComConst.DB_IN);       // 2015.08.13
        //    db.DbPsetString("@I_RESOURCE_CD", _resource_cd, ComConst.DB_IN);    // IMV3
        //    db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
        //    db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
        //    db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
        //    //db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
        //    db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
        //    db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
        //    db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
        //    db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
        //    db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

        //    db.DbBeginTrans();
        //    rtn = db.DbStored("SP_MFG_MANJORLSE");
        //    rtn = db.DbPgetInt("RET");
        //    if (rtn == ComConst.SUCCEED)
        //    {
        //        db.DbCommit();
        //    }
        //    else
        //    {
        //        _errcode = db.DbPgetInt("@O_ERRCODE");
        //        _errmsg = db.DbPgetString("@O_MSG");
        //        _sqlcode = db.DbPgetInt("@O_SQLCODE");
        //        _dbmsg = db.DbPgetString("@O_SQLMSG");
        //        _proc_name = db.DbPgetString("@O_PROC_NAME");
        //        _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
        //        db.DbRollback();
        //        rtn = ComConst.FAILED;
        //    }

        //    return rtn;
        //}
        ///// <summary>
        ///// 作業指示取消処理を行う
        ///// 不使用
        ///// </summary>
        ///// <returns></returns>
        //public int Mfg_JoCancel()
        //{
        //    ComDB db = new ComDB(_db_type);
        //    int rtn = 0;

        //    db.DbParametersClear();

        //    db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
        //    db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
        //    db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
        //    db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
        //    db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
        //    //db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
        //    db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
        //    db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
        //    db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
        //    db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
        //    db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

        //    db.DbBeginTrans();
        //    rtn = db.DbStored("SP_MFG_JOCANCEL");
        //    rtn = db.DbPgetInt("RET");
        //    if (rtn == ComConst.SUCCEED)
        //    {
        //        db.DbCommit();
        //    }
        //    else
        //    {
        //        _errcode = db.DbPgetInt("@O_ERRCODE");
        //        _errmsg = db.DbPgetString("@O_MSG");
        //        _sqlcode = db.DbPgetInt("@O_SQLCODE");
        //        _dbmsg = db.DbPgetString("@O_SQLMSG");
        //        _proc_name = db.DbPgetString("@O_PROC_NAME");
        //        _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
        //        db.DbRollback();
        //        rtn = ComConst.FAILED;
        //    }

        //    return rtn;
        //}
        ///// <summary>
        ///// 指示済製造オーダのデータを検索する
        ///// 不使用
        ///// </summary>
        ///// <returns></returns>
        //public DataSet Get_Mfg_JoCancelList()
        //{
        //    ComDB db = new ComDB(_db_type);
        //    StringBuilder strSQL = new StringBuilder();
        //    DataSet ds = new DataSet();

        //    //--- sql
        //    strSQL.Append("SELECT                                                                               ");
        //    strSQL.Append("JO.JOB_ORDER_NO,         JO.ITEM_NO,         JO.ITEM_DESC,       JO.WS_CD,           ");
        //    strSQL.Append("JO.ORDER_QTY,            JO.JOB_ORDER_QTY,   JO.ORDER_UMSR,      JO.SCH_START_DATE,  ");
        //    strSQL.Append("JO.SCH_COMPL_DATE,       S1.DATA_CHAR UMSR_NAME,     WS.WS_DESC,                     ");
        //    strSQL.Append("JO.JOC_CD,               JO.WHS_CD,          JO.JOB_ORDER_COMPL_QTY                  ");
        //    if (_db_type == "ORACLE")
        //    {
        //        db.DbParametersClear();

        //        strSQL.Append(" FROM JOB_ORDER JO                                           ");
        //        strSQL.Append(" WHERE   JO.ORDER_STATUS     < 85                            ");
        //        strSQL.Append("   AND   JO.ITEM_TYPE <> '99'           ");
        //        if (_sch_id != "")
        //        {
        //            strSQL.Append(" AND     JO.SCH_ID           = :SCH_ID                       ");
        //            db.DbPsetString("SCH_ID", _sch_id);
        //        }
        //        if (_ws_cd != "")
        //        {
        //            strSQL.Append(" AND     JO.WS_CD            = :WS_CD                        ");
        //            db.DbPsetString("WS_CD", _ws_cd);
        //        }
        //        if (_joc_cd != "")
        //        {
        //            strSQL.Append(" AND     JO.JOC_CD           = :JOC_CD                       ");
        //            db.DbPsetString("JOC_CD", _joc_cd);
        //        }
        //        if (_sch_start_date != 0)
        //        {
        //            strSQL.Append(" AND     JO.SCH_START_DATE   <= :SCH_START_DATE              ");
        //            db.DbPsetInt("SCH_START_DATE", _sch_start_date);
        //        }

        //    }
        //    else
        //    {
        //        db.DbParametersClear();
        //        strSQL.Append(" FROM JOB_ORDER JO                                                       ");
        //        strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01 = 'ITEM_UMSR'           ");
        //        strSQL.Append(" AND S1.KEY02        =       JO.ORDER_UMSR                               ");
        //        strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON JO.WS_CD  = WS.WS_CD              ");
        //        strSQL.Append(" WHERE   JO.ORDER_STATUS     < 85                                        ");
        //        strSQL.Append("   AND   JO.ITEM_TYPE <> '99'           ");
        //        if (_sch_id != "")
        //        {
        //            strSQL.Append(" AND     JO.SCH_ID           = @SCH_ID                       ");
        //            db.DbPsetString("@SCH_ID", _sch_id);
        //        }
        //        if (_ws_cd != "")
        //        {
        //            strSQL.Append(" AND     JO.WS_CD            = @WS_CD                        ");
        //            db.DbPsetString("@WS_CD", _ws_cd);
        //        }
        //        if (_joc_cd != "")
        //        {
        //            strSQL.Append(" AND     JO.JOC_CD           = @JOC_CD                       ");
        //            db.DbPsetString("@JOC_CD", _joc_cd);
        //        }
        //        if (_sch_start_date != 0)
        //        {
        //            strSQL.Append(" AND     JO.SCH_START_DATE   <= @SCH_START_DATE              ");
        //            db.DbPsetInt("@SCH_START_DATE", _sch_start_date);
        //        }

        //    }

        //    try
        //    {
        //        ds = db.DbDataSet(strSQL.ToString(), "TABLE");
        //        if (ds == null)
        //        {
        //            _dbmsg = db.expmsg;
        //            _strErr = db.strErr;
        //        }
        //        if (db.State() == ConnectionState.Open)
        //            db.DbClose();

        //        return ds;
        //    }
        //    catch
        //    {
        //        _dbmsg = db.expmsg;
        //        _strErr = db.strErr;
        //        if (db.State() == ConnectionState.Open)
        //            db.DbClose();
        //        return null;
        //    }
        //}
        ///// <summary>
        ///// 製造オーダを検索して明細画面に表示
        ///// </summary>
        ///// <returns></returns>
        //public DataSet Get_Mfg_JoSheet()
        //{
        //    ComDB db = new ComDB(_db_type);
        //    StringBuilder strSQL = new StringBuilder();
        //    DataSet ds = new DataSet();

        //    //--- sql
        //    strSQL.Append("SELECT                                                                               ");
        //    strSQL.Append("JO.WS_CD,                WS.WS_DESC,         JO.ITEM_NO,         JO.ITEM_DESC,       ");
        //    strSQL.Append("JO.JOB_ORDER_NO,    JO.JOB_ORDER_QTY,   S1.DATA_CHAR UMSR_NAME,  WS.WORK_INST_TYPE   ");//UPD BY UBIQ-LIU 2010/6/10 [ADD WS.WORK_INST_TYPE]
        //    if (_db_type == "ORACLE")
        //    {
        //        db.DbParametersClear();

        //        strSQL.Append(" FROM JOB_ORDER JO ,WORKSHOP_MASTER WS                       ");
        //        strSQL.Append(" WHERE   JO.WS_CD     = WS.WS_CD                             ");
        //        strSQL.Append("   AND   JO.ITEM_TYPE <> '99'           ");
        //        if (_sch_id != "")
        //        {
        //            strSQL.Append(" AND     JO.SCH_ID           = :SCH_ID                       ");
        //            db.DbPsetString("SCH_ID", _sch_id);
        //        }
        //        if (_ws_cd != "")
        //        {
        //            strSQL.Append(" AND     JO.WS_CD            = :WS_CD                        ");
        //            db.DbPsetString("WS_CD", _ws_cd);
        //        }
        //        if (_sch_start_date != 0)
        //        {
        //            strSQL.Append(" AND     JO.SCH_START_DATE   <= :SCH_START_DATE              ");
        //            db.DbPsetInt("SCH_START_DATE", _sch_start_date);
        //        }
        //        if (print_type == 1)
        //        {
        //            strSQL.Append(" AND     JO.ORDER_STATUS            <  85                    ");
        //            strSQL.Append(" AND     JO.ORDER_STATUS            >= 25                    ");
        //            strSQL.Append(" AND     JO.SLIP_ISSUE_FLAG         = 1                      ");
        //        }
        //        else
        //        {
        //            strSQL.Append(" AND     JO.ORDER_STATUS            = 10                     ");
        //            strSQL.Append(" AND     JO.SLIP_ISSUE_FLAG         = 0                      ");
        //        }
        //    }
        //    else
        //    {
        //        db.DbParametersClear();
        //        strSQL.Append(" FROM JOB_ORDER JO                                              ");
        //        strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01 = 'ITEM_UMSR'  ");
        //        strSQL.Append(" AND S1.KEY02        =       JO.ORDER_UMSR                      ");
        //        strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON JO.WS_CD     = WS.WS_CD  ");
        //        strSQL.Append(" WHERE  1=1                                                     ");
        //        strSQL.Append("   AND  JO.ITEM_TYPE <> '99'           ");
        //        if (_sch_id != "")
        //        {
        //            strSQL.Append(" AND     JO.SCH_ID           = @SCH_ID                       ");
        //            db.DbPsetString("@SCH_ID", _sch_id);
        //        }
        //        if (_ws_cd != "")
        //        {
        //            strSQL.Append(" AND     JO.WS_CD            = @WS_CD                        ");
        //            db.DbPsetString("@WS_CD", _ws_cd);
        //        }
        //        if (_sch_start_date != 0)
        //        {
        //            strSQL.Append(" AND     JO.SCH_START_DATE   <= @SCH_START_DATE              ");
        //            db.DbPsetInt("@SCH_START_DATE", _sch_start_date);
        //        }
        //        if (print_type == 1)
        //        {
        //            strSQL.Append(" AND     JO.ORDER_STATUS            <  85                    ");
        //            strSQL.Append(" AND     JO.ORDER_STATUS            >= 25                    ");
        //            strSQL.Append(" AND     JO.SLIP_ISSUE_FLAG         = 1                      ");
        //        }
        //        else
        //        {
        //            strSQL.Append(" AND     JO.ORDER_STATUS            = 10                     ");
        //            strSQL.Append(" AND     JO.SLIP_ISSUE_FLAG         = 0                      ");
        //        }
        //    }
        //    strSQL.Append(" Order by WS_CD,ITEM_NO,JOB_ORDER_NO ");
        //    try
        //    {
        //        ds = db.DbDataSet(strSQL.ToString(), "TABLE");
        //        if (ds == null)
        //        {
        //            _dbmsg = db.expmsg;
        //            _strErr = db.strErr;
        //        }
        //        if (db.State() == ConnectionState.Open)
        //            db.DbClose();

        //        return ds;
        //    }
        //    catch
        //    {
        //        _dbmsg = db.expmsg;
        //        _strErr = db.strErr;
        //        if (db.State() == ConnectionState.Open)
        //            db.DbClose();
        //        return null;
        //    }
        //}
        /// <summary>
        /// 作業指示№に対して作業指示票発行を行
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Mfg_JoSheetDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            //strSQL.Append("SELECT distinct                                                              ");
            strSQL.Append("SELECT                                                                       "); // IMV3
            strSQL.Append("JO.JOB_ORDER_NO,     JO.WS_CD,       WS.WS_DESC,         JO.SCH_START_DATE,  ");
            strSQL.Append("JO.SCH_COMPL_DATE,   JO.ITEM_NO,     JO.ITEM_DESC,       JO.JOB_ORDER_QTY,   ");
            strSQL.Append("JO.JOC_CD,           I.DRAWING_NO,   JO.WHS_CD,          JO.INSP_CD,         ");
            strSQL.Append("JO.SCH_ID,  S1.DATA_CHAR SCH_NAME,  S2.DATA_CHAR INSP_NAME,     JO.SLIP_NOTE,");
            strSQL.Append("JO.RCV_LINE_NO ");  // IMV3
            //strSQL.Append("JOD.PROCESS_CD,PM.PROCESS_DESC,                                              "); // IMV3 COMMENT OUT
            //strSQL.Append("JOD.SCH_SETUP_TIME + JOD.SCH_WORK_TIME + JOD.SCH_TRANSFER_TIME AS WORK_TIME  "); // IMV3 COMMENT OUT
            db.DbParametersClear();

            strSQL.Append("FROM                                                                         ");
            strSQL.Append("JOB_ORDER   JO                                                               ");
            strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON    JO.WS_CD    = WS.WS_CD             ");
            strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I    ON  JO.ITEM_NO     = I.ITEM_NO             ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01='SCH_ID'                    ");
            strSQL.Append(" AND S1.KEY02 = JO.SCH_ID                                                    ");
            strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01='INSP_CD'                   ");
            strSQL.Append(" AND S2.KEY02 = JO.INSP_CD                                                   ");
            //strSQL.Append(" LEFT OUTER JOIN JOB_ORDER_DETAIL JOD ON  JO.JOB_ORDER_NO = JOD.JOB_ORDER_NO ");   // IMV3 COMMENT OUT
            //strSQL.Append(" LEFT OUTER JOIN  PROCESS_MASTER	PM  ON  JOD.PROCESS_CD     = PM.PROCESS_CD  "); // IMV3 COMMENT OUT
            //strSQL.Append(" AND JOD.WS_CD = PM.WS_CD                                                    ");
            strSQL.Append(" WHERE                                                                       ");

            //if (print_type == 1)
            //{
            //strSQL.Append("      JO.JOB_ORDER_NO            = @JOB_ORDER_NO                             "); // IMV3 COMMENT OUT
            strSQL.Append("      JO.RCV_NO            = @RCV_NO                             ");  // IMV3
            //db.DbPsetString("@JOB_ORDER_NO", _job_order_no); // IMV3 COMMENT OUT
            db.DbPsetString("@RCV_NO", _rcv_no);  // IMV3
            //strSQL.Append(" ORDER BY JO.JOB_ORDER_NO,JO.ITEM_NO,JOD.PROCESS_CD                           "); // IMV3 COMMENT OUT
            strSQL.Append(" ORDER BY JO.RCV_LINE_NO                                    ");
            //}
            //else
            //{
            //    if (_sch_id != "")
            //    {
            //        strSQL.Append(" AND     JO.SCH_ID           = @SCH_ID                       ");
            //        db.DbPsetString("@SCH_ID", _sch_id);
            //    }
            //    if (_ws_cd != "")
            //    {
            //        strSQL.Append(" AND     JO.WS_CD            = @WS_CD                        ");
            //        db.DbPsetString("@WS_CD", _ws_cd);
            //    }
            //    if (_sch_start_date != 0)
            //    {
            //        strSQL.Append(" AND     JO.SCH_START_DATE   <= @SCH_START_DATE              ");
            //        db.DbPsetInt("@SCH_START_DATE", _sch_start_date);
            //    }
            //    strSQL.Append(" AND     JO.ORDER_STATUS            = 10                     ");
            //    strSQL.Append(" AND     JO.SLIP_ISSUE_FLAG         = 0                      ");
            //}

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
        /// 作業指示票発行
        /// 
        /// </summary>
        /// <returns></returns>
        public int Mfg_JoSheetPrt(ComDB db)
        {
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            //db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_MFG_JOSHEETPRT");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                // db.DbCommit();
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                // db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }
        /// <summary>
        /// 製造オーダを検索して明細画面に表示
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Mfg_JoRpt()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                               ");
            strSQL.Append("JO.WS_CD,                WS.WS_DESC,         JO.SCH_ID,      S2.DATA_CHAR SCH_NAME,  ");
            strSQL.Append("COUNT(JO.JOB_ORDER_NO) CNT,      S1.DATA_CHAR UMSR_NAME,   JO.SCH_START_DATE         ");
            //strSQL.Append("JO.WS_CD,                WS.WS_DESC,         JO.ITEM_NO,         JO.ITEM_DESC,       ");
            //strSQL.Append("JO.JOB_ORDER_NO,         JO.JOB_ORDER_QTY,   S1.DATA_CHAR UMSR_NAME                  ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER JO ,WORKSHOP_MASTER WS                       ");
                strSQL.Append(" WHERE   JO.WS_CD     = WS.WS_CD                             ");
                strSQL.Append("   AND   JO.ITEM_TYPE <> '99'                                ");
                if (_sch_id != "")
                {
                    strSQL.Append(" AND     JO.SCH_ID           = :SCH_ID                       ");
                    db.DbPsetString("SCH_ID", _sch_id);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND     JO.WS_CD            = :WS_CD                        ");
                    db.DbPsetString("WS_CD", _ws_cd);
                }
                if (_sch_start_date != 0)
                {
                    strSQL.Append(" AND     JO.SCH_START_DATE   <= :SCH_START_DATE              ");
                    db.DbPsetInt("SCH_START_DATE", _sch_start_date);
                }
                if (print_type == 1)
                {
                    strSQL.Append(" AND     JO.ORDER_STATUS            >= 25                    ");
                    strSQL.Append(" AND     JO.SLIP_ISSUE_FLAG         = 1                      ");
                }
                else
                {
                    strSQL.Append(" AND     JO.ORDER_STATUS            = 10                     ");
                    strSQL.Append(" AND     JO.SLIP_ISSUE_FLAG         = 0                      ");
                }
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER JO                                               ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01 = 'ITEM_UMSR'   ");
                strSQL.Append(" AND S1.KEY02        =       JO.ORDER_UMSR                       ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'SCH_ID'      ");
                strSQL.Append(" AND S2.KEY02        =       JO.SCH_ID                           ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON JO.WS_CD     = WS.WS_CD   ");
                strSQL.Append(" WHERE  JO.ITEM_TYPE <> '99'                                     ");
                if (_sch_id != "")
                {
                    strSQL.Append(" AND     JO.SCH_ID           = @SCH_ID                       ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND     JO.WS_CD            = @WS_CD                        ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_sch_start_date != 0)
                {
                    strSQL.Append(" AND     JO.SCH_START_DATE   >= @SCH_START_DATE              ");
                    db.DbPsetInt("@SCH_START_DATE", _sch_start_date);
                }
                if (_sch_start_date1 != 0)
                {
                    strSQL.Append(" AND     JO.SCH_START_DATE   <= @SCH_START_DATE1             ");
                    db.DbPsetInt("@SCH_START_DATE1", _sch_start_date1);
                }
                strSQL.Append(" AND     JO.ORDER_STATUS            < 85                    ");
            }

            strSQL.Append(" GROUP by JO.WS_CD,      WS.WS_DESC,     JO.SCH_ID,     S2.DATA_CHAR,    ");
            strSQL.Append(" S1.DATA_CHAR,       JO.SCH_START_DATE                                   ");
            strSQL.Append(" Order by SCH_ID,    WS_CD,      SCH_START_DATE                          ");
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
        /// 作業指示№に対して作業指示票発行を行
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Mfg_JoRptDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append("'*' + JO.JOB_ORDER_NO + '*' BAR_CODE,                                        ");     //Add 10.04.23
            strSQL.Append("JO.JOB_ORDER_NO,     JO.WS_CD,       WS.WS_DESC,         JO.SCH_START_DATE,  ");
            strSQL.Append("JO.SCH_COMPL_DATE,   JO.ITEM_NO,     JO.ITEM_DESC,       JO.JOB_ORDER_QTY,   ");
            strSQL.Append("JO.JOC_CD,           I.DRAWING_NO,   JO.WHS_CD,          JO.INSP_CD,         ");
            strSQL.Append("JO.SCH_ID,  S1.DATA_CHAR SCH_NAME,  S2.DATA_CHAR INSP_NAME,     JO.SLIP_NOTE,");
            strSQL.Append("JOD.PROCESS_CD,PM.PROCESS_DESC,  JO.ORDER_UMSR,   S3.DATA_CHAR UMSR_NAME,    ");
            strSQL.Append("JOD.SCH_SETUP_TIME + JOD.SCH_WORK_TIME + JOD.SCH_TRANSFER_TIME AS WORK_TIME  ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append("FROM                                                                     ");
                strSQL.Append("JOB_ORDER JO,    WORKSHOP_MASTER WS, ITEM_MASTER I,  SYSTEM_PARAMETER S,	");
                strSQL.Append("JOB_ORDER_DETAIL JOD,        PROCESS_MASTER	PM                          ");
                strSQL.Append(" WHERE       JO.WS_CD           = WS.WS_CD                               ");
                strSQL.Append(" AND         JO.JOB_ORDER_NO    = JOD.JOB_ORDER_NO(+)                    ");
                strSQL.Append(" AND         JOD.WS_CD     = PM.WS_CD(+)                       ");
                strSQL.Append(" AND         JOD.PROCESS_CD     = PM.PROCESS_CD(+)                       ");

                if (print_type == 0)
                {
                    strSQL.Append(" AND     JO.JOB_ORDER_NO            = :JOB_ORDER_NO          ");
                    db.DbPsetString("JOB_ORDER_NO", _job_order_no);
                }
                else
                {
                    strSQL.Append(" AND     JO.SCH_ID           = :SCH_ID                       ");
                    strSQL.Append(" AND     JO.WS_CD            = :WS_CD                        ");
                    strSQL.Append(" AND     JO.SCH_START_DATE   = :SCH_START_DATE               ");
                    strSQL.Append(" AND     JO.ORDER_STATUS            = 10                     ");
                    strSQL.Append(" AND     JO.SLIP_ISSUE_FLAG         = 0                      ");
                    db.DbPsetString("WS_CD", _ws_cd);
                    db.DbPsetString("SCH_ID", _sch_id);
                    db.DbPsetInt("SCH_START_DATE", _sch_start_date);
                }
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append("FROM                                                                         ");
                strSQL.Append("JOB_ORDER   JO                                                               ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON    JO.WS_CD    = WS.WS_CD             ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I    ON  JO.ITEM_NO     = I.ITEM_NO             ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01='SCH_ID'                    ");
                strSQL.Append(" AND S1.KEY02 = JO.SCH_ID                                                    ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01='INSP_CD'                   ");
                strSQL.Append(" AND S2.KEY02 = JO.INSP_CD                                                   ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S3 ON S3.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND S3.KEY02        =       JO.ORDER_UMSR                                   ");
                strSQL.Append(" LEFT OUTER JOIN JOB_ORDER_DETAIL JOD ON  JO.JOB_ORDER_NO = JOD.JOB_ORDER_NO ");
                //strSQL.Append(" AND S2.KEY02 = JO.INSP_CD                                                   ");
                strSQL.Append(" LEFT OUTER JOIN  PROCESS_MASTER	PM  ON  JOD.PROCESS_CD     = PM.PROCESS_CD  ");
                strSQL.Append(" AND JOD.WS_CD = PM.WS_CD                                                    ");
                strSQL.Append(" WHERE    JO.ITEM_TYPE <> '99'                                               ");

                if (print_type == 0)
                {
                    strSQL.Append(" AND     JO.JOB_ORDER_NO            = @JOB_ORDER_NO          ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
                else//作業指示一覧表発行明細
                {
                    strSQL.Append(" AND     JO.SCH_ID           = @SCH_ID                       ");
                    strSQL.Append(" AND     JO.WS_CD            = @WS_CD                        ");
                    strSQL.Append(" AND     JO.SCH_START_DATE   = @SCH_START_DATE               ");
                    strSQL.Append(" AND     JO.ORDER_STATUS            < 85                     ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                    db.DbPsetString("@WS_CD", _ws_cd);
                    db.DbPsetInt("@SCH_START_DATE", _sch_start_date);
                }
            }

            strSQL.Append(" ORDER BY JO.JOB_ORDER_NO,JO.ITEM_NO,JOD.PROCESS_CD                           ");
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
        /// 作業指示№ 明細
        /// CHECK JOB_ORDER_NO 有无
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Job_OrderDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT   *                                                                   ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM                                                                    ");
                strSQL.Append(" JOB_ORDER JO                                                            ");
                strSQL.Append(" WHERE     JO.JOB_ORDER_NO            = :JOB_ORDER_NO                    ");
                db.DbPsetString("JOB_ORDER_NO", _job_order_no);
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM                                                                    ");
                strSQL.Append(" JOB_ORDER JO                                                            ");
                strSQL.Append(" WHERE     JO.JOB_ORDER_NO            = @JOB_ORDER_NO                    ");
                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
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
        /// 生産計画データを検索
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Mfg_JocPlanList() //ADD 2008.12.02
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append(" PR.SCH_ID,      PR.JOC_CD+'-'+CONVERT(VARCHAR(3),PR.JOC_SPLIT_NO) JOC_CD,   ");//Add Convert(...) 2008.1.5 liu
            strSQL.Append(" PR.ITEM_NO,     S.DATA_CHAR UMSR_NAME,                                      ");
            strSQL.Append(" I.ITEM_DESC,    PR.MPS_QTY,         PR.COMPL_QTY,           I.ITEM_UMSR,    ");
            strSQL.Append(" PR.DUE_DATE,    PR.SCH_START_DATE,  PR.ORDER_STATUS,        PR.PLAN_NO      ");
            strSQL.Append(" ,S2.DATA_CHAR SCH_DESC                                                      ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM                                                                    ");
                strSQL.Append(" PRODUCTION_PLAN PR,ITEM_MASTER I                                        ");
                strSQL.Append(" WHERE   PR.ITEM_NO            = I.ITEM_NO                               ");

                if (chkflag == 1)
                {
                    strSQL.Append(" AND     PR.ORDER_STATUS       < 20                               ");
                }
                else
                {
                    if (pgmflag == 1)
                    {
                        //Add 10.08.25 Ubiq-Sai Start
                        strSQL.Append("  AND PR.JOC_CD NOT IN (SELECT D.JOC_CD                              ");
                        strSQL.Append("                          FROM SALES_ORDER S, SALES_ORDER_DETAIL D   ");
                        strSQL.Append("                         WHERE S.ORDER_NO = D.ORDER_NO               ");
                        strSQL.Append("                           AND S.PO_TYPE <> 0 )                      ");
                        //Add 10.08.25 Ubiq-Sai End
                        strSQL.Append(" AND     PR.ORDER_STATUS       < 30                               ");
                    }
                }
                if (joc_cd != "")
                {
                    strSQL.Append(" AND     PR.JOC_CD            = :JOC_CD                       ");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }
                if (item_no != "")
                {
                    strSQL.Append(" AND     PR.ITEM_NO           = :ITEM_NO                       ");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (sch_id != "")
                {
                    strSQL.Append(" AND     PR.SCH_ID           = :SCH_ID                       ");
                    db.DbPsetString("SCH_ID", _sch_id);
                }
                if (catg_cd != "")
                {
                    strSQL.Append(" AND     I.CATG_CD           = :CATG_CD                       ");
                    db.DbPsetString("CATG_CD", _catg_cd);
                }
                strSQL.Append("ORDER BY PR.SCH_ID, PR.DUE_DATE, JOC_CD ASC ");
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM                                                                    ");
                strSQL.Append(" PRODUCTION_PLAN PR                                                      ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON PR.ITEM_NO = I.ITEM_NO                 ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON I.ITEM_UMSR = S.KEY02             ");
                strSQL.Append(" AND      S.KEY01    ='ITEM_UMSR'                                        ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'SCH_ID' AND          ");
                strSQL.Append(" S2.KEY02 = PR.SCH_ID                                                    ");
                //----->
                //strSQL.Append(" WHERE   PR.ORDER_STATUS       < 20                              ");
                //strSQL.Append(" WHERE   1=1                              ");//upd 20090306 UBIQ-LIU
                strSQL.Append(" WHERE   PR.ITEM_NO = I.ITEM_NO                                          ");

                if (chkflag == 1)
                {
                    strSQL.Append(" AND     PR.ORDER_STATUS       < 20                               ");
                }
                else
                {
                    if (pgmflag == 1)
                    {
                        //Add 10.08.25 Ubiq-Sai Start
                        strSQL.Append("  AND PR.JOC_CD NOT IN (SELECT D.JOC_CD                              ");
                        strSQL.Append("                          FROM SALES_ORDER S                         ");
                        strSQL.Append("                         INNER JOIN SALES_ORDER_DETAIL D             ");
                        strSQL.Append("                            ON S.ORDER_NO = D.ORDER_NO               ");
                        strSQL.Append("                         WHERE S.PO_TYPE <> 0 )                      ");
                        //Add 10.08.25 Ubiq-Sai End
                        strSQL.Append(" AND     PR.ORDER_STATUS       < 30                               ");
                    }
                }
                if (joc_cd != "")
                {
                    strSQL.Append(" AND     PR.JOC_CD            = @JOC_CD                       ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (item_no != "")
                {
                    strSQL.Append(" AND     PR.ITEM_NO           = @ITEM_NO                       ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (sch_id != "")
                {
                    strSQL.Append(" AND     PR.SCH_ID           = @SCH_ID                       ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (catg_cd != "")//move 20090214 UBIQ-LIU   <-----
                {
                    strSQL.Append(" AND     I.CATG_CD           = @CATG_CD                       ");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }
                strSQL.Append("ORDER BY PR.SCH_ID, PR.DUE_DATE, JOC_CD ASC ");
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
        /// 生産計画データを検索
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Mfg_JocRlseList() //ADD 2008.12.02
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                      ");
            strSQL.Append(" PR.SCH_ID,      PR.JOC_CD+'-'+CONVERT(VARCHAR(100),PR.JOC_SPLIT_NO) JOC_CD, ");//Add Convert(...) 2008.1.5 liuWS_VENDOR_DESC
            strSQL.Append(" PR.ITEM_NO,                                                                 ");
            //strSQL.Append(" I.ITEM_DESC,    PR.MPS_QTY,         PR.COMPL_QTY,   I.ITEM_UMSR PR_UMSR,    ");   //Del 10.08.25 Ubiq-Sai
            strSQL.Append(" I.ITEM_DESC,    PR.MPS_QTY,         PR.COMPL_QTY COMPL_QTY1,   I.ITEM_UMSR PR_UMSR,    ");  //Add 10.08.25 Ubiq-Sai
            strSQL.Append(" PR.SCH_START_DATE,  PR.ORDER_STATUS PRORDER_STATUS,                         ");
            strSQL.Append(" AL.ALARM_TYPE,  ISNULL(PR.DUE_DATE,0) DUE_DATE0,                            ");
            strSQL.Append(" SYS.DATA_CHAR SCH_NAME, S2.DATA_CHAR UMSR_NAME,                             ");
            //---detail
            strSQL.Append(" A.L L,    A.CHILD_ITEM_NO,        A.CHILD_ITEM_DESC,    A.PLAN_QTY,         ");
            strSQL.Append(" A.DEMAND_QTY,   A.INV_BAL,                                                  ");//ADD BY UBIQ-LIU 2010/8/25
            strSQL.Append(" A.ITEM_UMSR,    A.ORDER_QTY,        A.COMPL_QTY,        A.SC_FLAG,          ");
            strSQL.Append(" A.WS_VENDOR_CD, A.DUE_DATE,         A.COMPL_DATE,       A.START_DATE,       ");
            strSQL.Append(" A.WS_VENDOR_DESC,A.WHS_CD,                                                  ");
            strSQL.Append(" A.ALLOC_FLAG,   A.ORDER_STATUS,     A.ORDER_NO,         A.JOB_ORDER_NO      ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM                                                                        ");
                strSQL.Append(" (                                                                           ");
                strSQL.Append(" SELECT  L,      CHILD_ITEM_NO,      CHILD_ITEM_DESC,      PLAN_QTY,         ");
                strSQL.Append(" ITEM_UMSR,      ORDER_QTY,          COMPL_QTY,          SC_FLAG,            ");
                strSQL.Append(" WS_VENDOR_CD,   DUE_DATE,           COMPL_DATE,         START_DATE,         ");
                strSQL.Append(" ALLOC_FLAG,     ORDER_STATUS,       ORDER_NO,           JOB_ORDER_NO        ");
                strSQL.Append(" FROM (                                                                      ");

                strSQL.Append(" SELECT                                                                      ");
                strSQL.Append(" 0 L,  ITEM_NO CHILD_ITEM_NO, ITEM_DESC CHILD_ITEM_DESC, ORDER_QTY PLAN_QTY, ");
                strSQL.Append(" ORDER_UMSR ITEM_UMSR,  0 ORDER_QTY, 0 COMPL_QTY,              SC_FLAG,      ");
                strSQL.Append(" CASE WHEN SC_FLAG = 0 THEN WS_CD                                            ");
                strSQL.Append("  WHEN SC_FLAG = 1 THEN VENDOR_CD END AS WS_VENDOR_CD,                       ");
                strSQL.Append(" CASE WHEN SC_FLAG = 0 THEN SCH_COMPL_DATE                                   ");
                strSQL.Append("  WHEN SC_FLAG = 1 THEN PO_DUE_DATE END AS DUE_DATE,                         ");
                strSQL.Append(" 0 COMPL_DATE,     SCH_START_DATE START_DATE,                                ");
                strSQL.Append(" WHS_CD,                                                                     ");//ADD 20090701 UBIQ-LIU
                strSQL.Append(" ALLOC_FLAG,    ORDER_STATUS, ORDER_NO,      '' JOB_ORDER_NO                 ");
                strSQL.Append(" FROM                                                                        ");
                strSQL.Append(" PLANNED_ORDER                                                               ");
                strSQL.Append(" WHERE JOC_CD    =       @JOC_CD                                             ");
                strSQL.Append(" AND JOC_SPLIT_NO    =   @JOC_SPLIT_NO                                       ");
                strSQL.Append(" AND ITEM_NO    =        @ITEM_NO                                            ");
                strSQL.Append(" UNION ALL                                                                   ");

                strSQL.Append(" SELECT                                                                      ");
                strSQL.Append(" 0 L,  ITEM_NO CHILD_ITEM_NO, ITEM_DESC CHILD_ITEM_DESC, ORDER_QTY PLAN_QTY, ");
                strSQL.Append(" ORDER_UMSR ITEM_UMSR,               JOB_ORDER_QTY ORDER_QTY,                ");
                strSQL.Append(" JOB_ORDER_COMPL_QTY COMPL_QTY,      0 SC_FLAG,                              ");
                strSQL.Append(" WS_CD WS_VENDOR_CD,                                                         ");
                strSQL.Append(" SCH_COMPL_DATE DUE_DATE,                                                    ");
                strSQL.Append(" JOB_ORDER_COMPL_DATE COMPL_DATE,     SCH_START_DATE START_DATE,             ");
                strSQL.Append(" WHS_CD,                                                                     ");//ADD 20090701 UBIQ-LIU
                strSQL.Append(" ALLOC_FLAG,    ORDER_STATUS,    ORDER_NO,   JOB_ORDER_NO                    ");
                strSQL.Append(" FROM                                                                        ");
                strSQL.Append(" JOB_ORDER                                                                   ");
                strSQL.Append(" WHERE JOC_CD    =       @JOC_CD                                             ");
                strSQL.Append(" AND JOC_SPLIT_NO    =   @JOC_SPLIT_NO                                       ");
                strSQL.Append(" AND ITEM_NO    =        @ITEM_NO                                            ");
                strSQL.Append(" UNION ALL                                                                   ");

                strSQL.Append(" SELECT                                                                      ");
                strSQL.Append(" 0 L,  ITEM_NO CHILD_ITEM_NO, ITEM_DESC CHILD_ITEM_DESC, ORDER_QTY PLAN_QTY, ");
                strSQL.Append(" ORDER_UMSR ITEM_UMSR,               JOB_ORDER_QTY ORDER_QTY,                ");
                strSQL.Append(" JOB_ORDER_COMPL_QTY COMPL_QTY,      1 SC_FLAG,                              ");
                strSQL.Append(" VENDOR_CD WS_VENDOR_CD,                                                     ");
                strSQL.Append(" PO_DUE_DATE DUE_DATE,                                                       ");
                strSQL.Append(" JOB_ORDER_COMPL_DATE COMPL_DATE,     SCH_START_DATE START_DATE,             ");
                strSQL.Append(" WHS_CD,                                                                     ");//ADD 20090701 UBIQ-LIU
                strSQL.Append(" ALLOC_FLAG,    ORDER_STATUS,    ORDER_NO,       JOB_ORDER_NO                ");
                strSQL.Append(" FROM                                                                        ");
                strSQL.Append(" PUR_ORDER                                                                   ");
                strSQL.Append(" WHERE JOC_CD    =       @JOC_CD                                             ");
                strSQL.Append(" AND JOC_SPLIT_NO    =   @JOC_SPLIT_NO                                       ");
                strSQL.Append(" AND ITEM_NO    =        @ITEM_NO                                            ");

                strSQL.Append(" UNION ALL                                                                   ");
                //strSQL.Append(" SELECT                                                                     "); //Del Ubiq-Sai 11.02.26
                strSQL.Append(" SELECT DISTINCT                                                             ");  //Add Ubiq-Sai 11.02.26
                strSQL.Append(" JOC.LVL L, JOC.CHILD_ITEM_NO, JOC.ITEM_DESC CHILD_ITEM_DESC, JOC.PLAN_QTY,  ");
                strSQL.Append(" JOC.ITEM_UMSR,    JOC.ORDER_QTY,    JOC.COMPL_QTY,        JOC.SC_FLAG,      ");
                strSQL.Append(" JOC.WS_VENDOR_CD,                                                           ");
                strSQL.Append(" JOC.WS_VENDOR_DESC, JOC.DUE_DATE,   JOC.COMPL_DATE,       JOC.START_DATE,   ");
                strSQL.Append(" JOC.WHS_CD,                                                                 ");//ADD 20090701 UBIQ-LIU
                strSQL.Append(" JOC.ALLOC_FLAG,   JOC.ORDER_STATUS, JOC.ORDER_NO,         JOC.JOB_ORDER_NO  ");
                strSQL.Append(" FROM                                                                        ");
                strSQL.Append(" dbo.JOCRLSEORDER(@ITEM_NO,@JOC_CD,@JOC_SPLIT_NO) JOC                        ");
                strSQL.Append("  ) A                                                                        ");
                strSQL.Append(" LEFT OUTER JOIN PRODUCTION_PLAN PR ON  PR.PLAN_NO = @PLAN_NO                ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON PR.ITEM_NO = I.ITEM_NO                     ");
                strSQL.Append(" LEFT OUTER JOIN MRP_ALARM AL ON AL.ORDER_NO = A.ORDER_NO                    ");

                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@JOC_CD", _joc_cd);
                db.DbPsetInt("@JOC_SPLIT_NO", _joc_split_no);
                db.DbPsetString("@PLAN_NO", _plan_no);
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM (                                                                      ");
                //↓↓↓ADD BY UBIQ-LIU 2010/8/25↓↓↓
                strSQL.Append(" SELECT                                                                      ");
                strSQL.Append(" JOC.L L, JOC.CHILD_ITEM_NO, JOC.CHILD_ITEM_DESC, JOC.PLAN_QTY,              ");
                strSQL.Append(" JOC.DEMAND_QTY,     JOC.INV_BAL,                                            ");
                strSQL.Append(" JOC.ITEM_UMSR,    JOC.ORDER_QTY,    JOC.COMPL_QTY,        JOC.SC_FLAG,      ");
                strSQL.Append(" JOC.WS_VENDOR_CD,                                                           ");
                strSQL.Append(" JOC.WS_VENDOR_DESC, JOC.DUE_DATE,     JOC.COMPL_DATE,       JOC.START_DATE, ");
                strSQL.Append(" JOC.WHS_CD,                                                                 ");
                strSQL.Append(" JOC.ALLOC_FLAG,   JOC.ORDER_STATUS, JOC.ORDER_NO,         JOC.JOB_ORDER_NO  ");
                strSQL.Append(" FROM  (                                                                     ");
                strSQL.Append(" SELECT  ORD.*,  ISNULL(INV.INV_BAL,0) INV_BAL   FROM (                      ");
                //↑↑↑ADD BY UBIQ-LIU 2010/8/25↑↑↑
                strSQL.Append(" SELECT                                                                      ");
                strSQL.Append(" 0 L,  ITEM_NO CHILD_ITEM_NO, ITEM_DESC CHILD_ITEM_DESC,                     ");
                strSQL.Append(" ORDER_QTY DEMAND_QTY,       ORDER_QTY PLAN_QTY,                             ");//ADD BY UBIQ-LIU 2010/8/25 [DEMAND_QTY]
                strSQL.Append(" ORDER_UMSR ITEM_UMSR,  0 ORDER_QTY, 0 COMPL_QTY,            P.SC_FLAG,      ");
                strSQL.Append(" CASE WHEN P.SC_FLAG = 0 THEN P.WS_CD                                        ");
                strSQL.Append("  WHEN P.SC_FLAG = 1 THEN P.VENDOR_CD END AS WS_VENDOR_CD,                   ");
                strSQL.Append(" CASE WHEN P.SC_FLAG = 0 THEN W.WS_DESC                                      ");
                strSQL.Append("  WHEN P.SC_FLAG = 1 THEN V.VENDOR_DESC END AS WS_VENDOR_DESC,               ");
                strSQL.Append(" CASE WHEN P.SC_FLAG = 0 THEN P.SCH_COMPL_DATE                               ");
                strSQL.Append("  WHEN P.SC_FLAG = 1 THEN P.PO_DUE_DATE END AS DUE_DATE,                     ");
                strSQL.Append(" 0 COMPL_DATE,     SCH_START_DATE START_DATE,                                ");
                strSQL.Append(" WHS_CD,           JOC_CD,                                                   ");//ADD 20090701 UBIQ-LIU
                strSQL.Append(" ALLOC_FLAG,    ORDER_STATUS,        ORDER_NO,       '' JOB_ORDER_NO         ");
                strSQL.Append(" FROM                                                                        ");
                strSQL.Append(" PLANNED_ORDER P                                                             ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON V.VENDOR_CD = P.VENDOR_CD                ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON W.WS_CD = P.WS_CD                      ");
                strSQL.Append(" WHERE JOC_CD    =       @JOC_CD                                             ");
                strSQL.Append(" AND JOC_SPLIT_NO    =   @JOC_SPLIT_NO                                       ");
                strSQL.Append(" AND ITEM_NO    =        @ITEM_NO                                            ");
                strSQL.Append(" UNION ALL                                                                   ");

                strSQL.Append(" SELECT                                                                      ");
                strSQL.Append(" 0 L,  ITEM_NO CHILD_ITEM_NO, ITEM_DESC CHILD_ITEM_DESC,                     ");
                strSQL.Append(" ORDER_QTY DEMAND_QTY,       ORDER_QTY PLAN_QTY,                             ");//ADD BY UBIQ-LIU 2010/8/25 [DEMAND_QTY]
                strSQL.Append(" ORDER_UMSR ITEM_UMSR,               JOB_ORDER_QTY ORDER_QTY,                ");
                strSQL.Append(" JOB_ORDER_COMPL_QTY COMPL_QTY,      0 SC_FLAG,                              ");
                strSQL.Append(" J.WS_CD WS_VENDOR_CD,  W.WS_DESC  WS_VENDOR_DESC,                           ");
                strSQL.Append(" SCH_COMPL_DATE DUE_DATE,                                                    ");
                strSQL.Append(" JOB_ORDER_COMPL_DATE COMPL_DATE,     SCH_START_DATE START_DATE,             ");
                strSQL.Append(" WHS_CD,              JOC_CD,                                                ");//ADD 20090701 UBIQ-LIU
                strSQL.Append(" ALLOC_FLAG,    ORDER_STATUS,        ORDER_NO,       JOB_ORDER_NO            ");
                strSQL.Append(" FROM                                                                        ");
                strSQL.Append(" JOB_ORDER J                                                                 ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON W.WS_CD = J.WS_CD                      ");
                strSQL.Append(" WHERE JOC_CD    =       @JOC_CD                                             ");
                strSQL.Append(" AND JOC_SPLIT_NO    =   @JOC_SPLIT_NO                                       ");
                strSQL.Append(" AND ITEM_NO    =        @ITEM_NO                                            ");
                strSQL.Append(" UNION ALL                                                                   ");

                strSQL.Append(" SELECT                                                                      ");
                strSQL.Append(" 0 L,  ITEM_NO CHILD_ITEM_NO, ITEM_DESC CHILD_ITEM_DESC,                     ");
                strSQL.Append(" ORDER_QTY DEMAND_QTY,       ORDER_QTY PLAN_QTY,                             ");//ADD BY UBIQ-LIU 2010/8/25 [DEMAND_QTY]
                strSQL.Append(" ORDER_UMSR ITEM_UMSR,               JOB_ORDER_QTY ORDER_QTY,                ");
                strSQL.Append(" JOB_ORDER_COMPL_QTY COMPL_QTY,      1 SC_FLAG,                              ");
                strSQL.Append(" P.VENDOR_CD WS_VENDOR_CD, V.VENDOR_DESC WS_VENDOR_DESC,                     ");
                strSQL.Append(" PO_DUE_DATE DUE_DATE,                                                       ");
                strSQL.Append(" JOB_ORDER_COMPL_DATE COMPL_DATE,     SCH_START_DATE START_DATE,             ");
                strSQL.Append(" WHS_CD,              JOC_CD,                                                ");//ADD 20090701 UBIQ-LIU
                strSQL.Append(" ALLOC_FLAG,    ORDER_STATUS,        ORDER_NO,       JOB_ORDER_NO            ");
                strSQL.Append(" FROM                                                                        ");
                strSQL.Append(" PUR_ORDER P                                                                 ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON V.VENDOR_CD = P.VENDOR_CD                ");
                strSQL.Append(" WHERE JOC_CD    =       @JOC_CD                                             ");
                strSQL.Append(" AND JOC_SPLIT_NO    =   @JOC_SPLIT_NO                                       ");
                strSQL.Append(" AND ITEM_NO    =        @ITEM_NO                                            ");
                //↓↓↓ADD BY UBIQ-LIU 2010/8/25↓↓↓
                strSQL.Append(" ) ORD                                                                       ");
                strSQL.Append(" LEFT JOIN (SELECT ITEM_NO,  WHS_CD, JOC_CD, SUM(INV_BAL) INV_BAL            ");

                strSQL.Append(" FROM INVENTORY_DETAIL                                                       ");
                strSQL.Append(" WHERE INV_YM            =0                                                  ");
                strSQL.Append("   AND INV_WIP_TYPE      =0                                                  ");
                strSQL.Append("   AND INV_TYPE          =0                                                  ");
                strSQL.Append(" GROUP BY ITEM_NO,WHS_CD,JOC_CD                                              ");
                strSQL.Append("     ) INV ON    ORD.CHILD_ITEM_NO     = INV.ITEM_NO                         ");
                strSQL.Append("           AND   ORD.WHS_CD      =INV.WHS_CD                                 ");
                strSQL.Append("           AND   ORD.JOC_CD      =INV.JOC_CD                                 ");
                strSQL.Append("   ) JOC                                                                     ");
                //↑↑↑ADD BY UBIQ-LIU 2010/8/25↑↑↑
                strSQL.Append(" UNION ALL                                                                   ");
                strSQL.Append(" SELECT                                                                      ");
                strSQL.Append(" JOC.LVL L, JOC.CHILD_ITEM_NO, JOC.ITEM_DESC CHILD_ITEM_DESC, JOC.PLAN_QTY,  ");
                strSQL.Append(" JOC.DEMAND_QTY,     JOC.INV_BAL,                                            ");
                strSQL.Append(" JOC.ITEM_UMSR,    JOC.ORDER_QTY,    JOC.COMPL_QTY,        JOC.SC_FLAG,      ");
                strSQL.Append(" JOC.WS_VENDOR_CD,                                                           ");
                strSQL.Append(" JOC.WS_VENDOR_DESC, JOC.DUE_DATE,     JOC.COMPL_DATE,       JOC.START_DATE, ");
                strSQL.Append(" JOC.WHS_CD,                                                                 ");//ADD 20090701 UBIQ-LIU
                strSQL.Append(" JOC.ALLOC_FLAG,   JOC.ORDER_STATUS, JOC.ORDER_NO,         JOC.JOB_ORDER_NO  ");
                strSQL.Append(" FROM                                                                        ");

                //strSQL.Append(" (SELECT ORD.*,  ISNULL(INV.INV_BAL,0) INV_BAL  FROM                		"); //Del Ubiq-Sai 11.02.26
                strSQL.Append(" (SELECT DISTINCT ORD.*,  ISNULL(INV.INV_BAL,0) INV_BAL  FROM                "); //Add Ubiq-Sai 11.02.26
                strSQL.Append(" dbo.JOCRLSEORDER(@ITEM_NO,@JOC_CD,@JOC_SPLIT_NO) ORD                        ");
                //↓↓↓ADD BY UBIQ-LIU 2010/8/25↓↓↓
                strSQL.Append(" LEFT JOIN (SELECT ITEM_NO,  WHS_CD, JOC_CD, SUM(INV_BAL) INV_BAL            ");
                strSQL.Append(" FROM INVENTORY_DETAIL                                                       ");
                strSQL.Append(" WHERE INV_YM            =0                                                  ");
                strSQL.Append("   AND INV_WIP_TYPE      =0                                                  ");
                strSQL.Append("   AND INV_TYPE          =0                                                  ");
                strSQL.Append(" GROUP BY ITEM_NO,WHS_CD,JOC_CD                                              ");
                strSQL.Append("     ) INV ON    ORD.CHILD_ITEM_NO     = INV.ITEM_NO                         ");
                strSQL.Append("           AND   ORD.WHS_CD      =INV.WHS_CD                                 ");
                strSQL.Append("           AND   ORD.JOC_CD      =INV.JOC_CD                                 ");
                strSQL.Append(" ) JOC                                                                       ");
                //↑↑↑ADD BY UBIQ-LIU 2010/8/25↑↑↑
                strSQL.Append("  ) A                                                                        ");
                strSQL.Append(" LEFT OUTER JOIN PRODUCTION_PLAN PR ON  PR.PLAN_NO = @PLAN_NO                ");
                //strSQL.Append(" AND A.PARENT_ITEM_NO = PR.ITEM_NO                                           ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON PR.ITEM_NO = I.ITEM_NO                     ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER IM ON A.CHILD_ITEM_NO = IM.ITEM_NO              ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SYS ON SYS.KEY01 = 'SCH_ID'                ");
                strSQL.Append(" AND SYS.KEY02 = PR.SCH_ID                                                   ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND S2.KEY02 = A.ITEM_UMSR                                                  ");
                strSQL.Append(" LEFT OUTER JOIN MRP_ALARM AL ON AL.ORDER_NO = A.ORDER_NO                    ");
                strSQL.Append(" WHERE IM.ITEM_TYPE <> '99'                                                  ");

                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@JOC_CD", _joc_cd);
                db.DbPsetInt("@JOC_SPLIT_NO", _joc_split_no);
                db.DbPsetString("@PLAN_NO", _plan_no);
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
        /// 製番指定手配指示
        /// SP_MFG_JOCRLSE
        /// </summary>
        /// <returns></returns>
        public int Mfg_JocRlse()//ADD 2008.12.02
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ORDER_NO", _order_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_MFG_JOCRLSE");
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
        /// 製番展開
        /// SP_MFG_JOC_DEVELOPMENT
        /// </summary>
        /// <returns></returns>
        public int Mfg_Joc_Development()//ADD 2008.12.02
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PLAN_NO", _plan_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_MFG_JOC_DEVELOPMENT");
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
        /// 部品在庫引当
        /// SP_MFG_DISB_ALLOC
        /// </summary>
        /// <returns></returns>
        public int Mfg_Disb_Alloc()//ADD 2008.12.02
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ORDER_NO", _order_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            //db.DbPsetInt("@I_UPDATE_CNTR", _update_cntr, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_DISB_ALLOC");
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
        /// 部品取り揃え表対象データを検索する
        /// </summary>
        /// <returns></returns>
        public DataSet GetMfgPartCollectingList()//20090203 ADD UBIQ_LIU
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                               ");
            strSQL.Append("JO.JOB_ORDER_NO,         JO.WS_CD,           WS.WS_DESC,     JO.ITEM_NO JO_ITEM_NO,  ");
            strSQL.Append("JO.ITEM_DESC JO_ITEM_DESC,JO.JOB_ORDER_QTY,  S1.DATA_CHAR ORDER_UMSR,    JO.JOC_CD,  ");
            strSQL.Append("JO.SCH_START_DATE,       JO.SCH_COMPL_DATE,  DM.ITEM_NO,     ITE.ITEM_DESC,          ");
            strSQL.Append("DM.PLAN_QTY, S2.DATA_CHAR ITEM_UMSR,         DM.WIP_ALLOC_QTY,   DM.PLAN_DISB_QTY,   ");
            strSQL.Append("ITE.PO_TYPE                                                                          ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER JO,  DEMAND DM,  WORKSHOP_MASTER WS, SYSTEM_PARAMETER S1,        ");
                strSQL.Append(" SYSTEM_PARAMETER S2,    ITEM_MASTER ITE                                         ");
                strSQL.Append(" WHERE   JO.ORDER_NO = DM.ORDER_NO                                               ");
                strSQL.Append(" AND     (DM.SUB_GRP_CD = '' OR (DM.SUB_GRP_CD <> '' AND DM.SUB_ACTION_FLAG = 1))");
                strSQL.Append(" AND 	DM.ITEM_TYPE <> '99'                            ");
                strSQL.Append(" AND     JO.WS_CD    = WS.WS_CD                                                  ");
                strSQL.Append(" AND     JO.ORDER_UMSR   =   S1.KEY02                                            ");
                strSQL.Append(" AND     S1.KEY01        =   'ITEM_UMSR'                                         ");
                strSQL.Append(" AND     DM.ITEM_NO      =   ITE.ITEM_NO                                         ");
                strSQL.Append(" AND     DM.ITEM_UMSR    =   S2.KEY02                                            ");
                strSQL.Append(" AND     S2.KEY01        =   'ITEM_UMSR'                                         ");
                strSQL.Append(" AND     JO.ORDER_STATUS >=  25                                                  ");
                strSQL.Append(" AND     JO.ORDER_STATUS <  85                                                   ");//Change <= to < 20090408 BY LIU
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND     JO.WS_CD =  :WS_CD                                                  ");
                    db.DbPsetString("WS_CD", _ws_cd);
                }
                if (_job_order_no != "")
                {
                    strSQL.Append(" AND     JO.JOB_ORDER_NO =  :JOB_ORDER_NO                                    ");
                    db.DbPsetString("JOB_ORDER_NO", _job_order_no);
                }
                if (_sch_start_date != 0)
                {
                    strSQL.Append(" AND     JO.SCH_START_DATE <=  :SCH_START_DATE                                ");
                    db.DbPsetInt("SCH_START_DATE", _sch_start_date);
                }
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER JO                                                               ");
                strSQL.Append(" LEFT OUTER JOIN DEMAND DM  ON  JO.ORDER_NO = DM.ORDER_NO                        ");
                strSQL.Append(" AND     (DM.SUB_GRP_CD = '' OR (DM.SUB_GRP_CD <> '' AND DM.SUB_ACTION_FLAG = 1))");
                strSQL.Append(" AND 	DM.ITEM_TYPE <> '99'                            ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS  ON  JO.WS_CD    = WS.WS_CD                  ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1  ON  JO.ORDER_UMSR   =   S1.KEY02           ");
                strSQL.Append(" AND     S1.KEY01        =   'ITEM_UMSR'                                         ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER ITE ON ITE.ITEM_NO      =       DM.ITEM_NO          ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2  ON DM.ITEM_NO      =   ITE.ITEM_NO         ");
                strSQL.Append(" AND     DM.ITEM_UMSR    =   S2.KEY02                                            ");
                strSQL.Append(" AND     S2.KEY01        =   'ITEM_UMSR'                                         ");
                strSQL.Append(" WHERE  JO.ORDER_STATUS >=  25                                                   ");
                strSQL.Append(" AND     JO.ORDER_STATUS <  85                                                   ");//Change <= to < 20090408 BY LIU
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND     JO.WS_CD =  @WS_CD                                                  ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_job_order_no != "")
                {
                    strSQL.Append(" AND     JO.JOB_ORDER_NO =  @JOB_ORDER_NO                                    ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
                if (_sch_start_date != 0)
                {
                    strSQL.Append(" AND     JO.SCH_START_DATE <=  @SCH_START_DATE                               ");
                    db.DbPsetInt("@SCH_START_DATE", _sch_start_date);
                }
            }
            strSQL.Append("ORDER BY JO.JOB_ORDER_NO, DM.PART_SEQ, DM.ITEM_NO"); //10.08.25 Ubiq-Sai Add PART_SEQ
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
        /// オーダー№の所要情報を検索して子部品明細画面に表示する
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Mfg_JoReleasedDemandList()//20090219 ADD UBIQ-LIU
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            //add by wanghui 2010/5/5 start
            strSQL.Append(" SELECT     * FROM (                                       ");

            //add by wanghui 2010/5/5 start
            strSQL.Append("SELECT                                                                                       ");
            strSQL.Append("JO.JOB_ORDER_NO,         JO.WS_CD,           WS.WS_DESC,         JO.JOC_CD,                  ");
            strSQL.Append("JO.ITEM_NO PARENT_ITEM,  JO.ITEM_DESC PARENT_ITEM_DESC,          JO.JOB_ORDER_QTY,           ");
            strSQL.Append("JO.ORDER_UMSR,           S1.DATA_CHAR USMR_NAME,                                             ");
            strSQL.Append("D.ITEM_NO CHILD_ITEM,    IM.ITEM_DESC CHILD_ITEM_DESC,           D.PLAN_QTY,                 ");
            strSQL.Append("D.SCRAP_QTY,                 ");  //ADD BY UBIQ-SUO 2010/12/29 BUG 953
            strSQL.Append("D.PROCESS_CD,            PM.PROCESS_DESC,    D.SCH_DISB_DATE,    D.DISB_WHS,                 ");
            strSQL.Append("isnull(INV.INV_QTY,0) INV_QTY,                                                               ");

            //add by wanghui 2010/5/5 start
            strSQL.Append(" INV.INV_INV_BAL, WIP.WIP_INV_BAL,                                                            ");
            //add by wanghui 2010/5/5 end

            //UPD 20090930 --->
            strSQL.Append(" (CASE WHEN (ISNULL(D.ALLOC_QTY,0)-ISNULL(D.ACT_DISB_QTY,0))<0 THEN 0                        ");
            strSQL.Append("  ELSE (ISNULL(D.ALLOC_QTY,0)-ISNULL(D.ACT_DISB_QTY,0)) END) ALLOC_QTY,                      ");
            //UPD 20090930 <---
            strSQL.Append(" isnull(WIP.WIP_QTY,0) WIP_QTY,                                                              ");
            strSQL.Append("ISNULL(D.ACT_DISB_QTY,0) ACT_DISB_QTY,                                                       ");//ADD 20090610 UBIQ_LIU
            strSQL.Append("isnull(WIPALLOC.WIP_ALLOC_QTY,0) WIP_ALLOC_QTY                                               ");
            //strSQL.Append(",ISNULL(D.PLAN_DISB_QTY,0) PLAN_DISB_QTY,    D.DEMAND_NO                                     ");//ADD 20090910 UBIQ_HU
            strSQL.Append(",CASE IM.AUTO_DISB_TYPE WHEN 1 THEN 0 ELSE ISNULL(D.PLAN_DISB_QTY,0) END PLAN_DISB_QTY,    D.DEMAND_NO ");//2011.06.08
            strSQL.Append(",D.PART_SEQ ");      //10.08.25 Ubiq-Sai Add PART_SEQ
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM DEMAND D , JOB_ORDER PO,                                           ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD,               ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) INV_QTY        ");
                //add by wanghui  2010/5/5 start
                strSQL.Append(" ,SUM(INVENTORY_DETAIL.INV_BAL) INV_INV_BAL                              ");	//SUM（INVENTORY_DETAIL.現在庫数）倉庫在庫数	
                //add by wanghui  2010/5/5 end  
                strSQL.Append(" FROM    INVENTORY_DETAIL,DEMAND,JOB_ORDER                               ");
                strSQL.Append(" WHERE   JOB_ORDER.JOB_ORDER_NO  =   :JOB_ORDER_NO                       ");
                strSQL.Append(" AND     DEMAND.ORDER_NO         =   JOB_ORDER.ORDER_NO                  ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 0                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.ITEM_NO = DEMAND.ITEM_NO(+)                    ");
                strSQL.Append(" AND     INVENTORY_DETAIL.WHS_CD = DEMAND.DISB_WHS(+)  )  INV,           ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD,               ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) WIP_QTY        ");
                //add by wanghui  2010/5/5 start
                strSQL.Append(" ,SUM(INVENTORY_DETAIL.INV_BAL) WIP_INV_BAL                              ");//SUM（INVENTORY_DETAIL.	現在庫数）現場在庫数	
                //add by wanghui  2010/5/5 end 
                strSQL.Append(" FROM    INVENTORY_DETAIL,DEMAND,JOB_ORDER                               ");
                strSQL.Append(" WHERE   JOB_ORDER.JOB_ORDER_NO  =   :JOB_ORDER_NO                       ");
                strSQL.Append(" AND     DEMAND.ORDER_NO         =   JOB_ORDER.ORDER_NO(+)               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 1                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.ITEM_NO = DEMAND.ITEM_NO(+)                    ");
                strSQL.Append(" AND     INVENTORY_DETAIL.WS_CD = DEMAND.WS_CD(+)  )  WIP,               ");

                strSQL.Append(" (SELECT WIP_ALLOC.DEMAND_NO,SUM(WIP_ALLOC.ALLOC_QTY)                    ");
                strSQL.Append(" FROM    WIP_ALLOC,DEMAND ,JOB_ORDER                                     ");
                strSQL.Append(" WHERE   DEMAND.ORDER_NO =   :JOB_ORDER_NO                               ");
                strSQL.Append(" AND     DEMAND.ORDER_NO =   JOB_ORDER.ORDER_NO                          ");
                strSQL.Append(" AND     DEMAND.DEMAND_NO =   JOB_ORDER.DEMAND_NO                        ");
                //strSQL.Append(" AND     WIP_ALLOC.ALLOC_STATUS  <=   20                                 ");   //Del 11.01.03 Ubiq-Sai
                strSQL.Append(" AND     WIP_ALLOC.ALLOC_STATUS  <   20                                  ");     //Add 11.01.03 Ubiq-Sai
                strSQL.Append(" AND     WIP_ALLOC.SCH_FLAG      IN (0,2)                  )  WIPALLOC   ");

                strSQL.Append(" WHERE  D.ORDER_NO =   :ORDER_NO                                        ");
                strSQL.Append(" AND  D.ITEM_NO =   INV.ITEM_NO                                         ");
                strSQL.Append(" AND  D.WHS_CD =   INV.WHS_CD                                           ");
                strSQL.Append(" AND  D.ITEM_NO =   WIP.ITEM_NO                                         ");
                //strSQL.Append(" AND  D.DISB_WHS =   WIP.WS_CD                                          ");
                strSQL.Append(" AND  D.WS_CD    =   WIP.WS_CD                                           "); // 2011.03.09
                strSQL.Append(" AND  D.ORDER_NO =   PO.ORDER_NO                                        ");
                strSQL.Append(" AND  (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1)) ");
                strSQL.Append(" AND  D.ITEM_TYPE <> '99'                            ");
                //add by wanghui 2010/5/5 start

                strSQL.Append(" ) TBL  WHERE 1=1 ");
                if (alloc_flag == 1)
                {
                    strSQL.Append(" AND   PLAN_DISB_QTY > 0                  ");
                }

                if (miss_disb == 1)
                {
                    strSQL.Append(" AND   ALLOC_QTY >0                  ");
                }
                //add by wanghui 2010/5/5 end


                db.DbPsetString("ORDER_NO", _order_no);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER JO                                                       ");
                strSQL.Append(" LEFT OUTER JOIN DEMAND D ON     JO.ORDER_NO     =   D.ORDER_NO          ");
                //strSQL.Append(" FROM DEMAND D                                                           ");
                //strSQL.Append(" LEFT OUTER JOIN JOB_ORDER JO ON  D.ORDER_NO =   JO.ORDER_NO             ");
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD,               ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) INV_QTY        ");
                //add by wanghui  2010/5/5 start
                strSQL.Append(" ,SUM(INVENTORY_DETAIL.INV_BAL) INV_INV_BAL                              ");	//SUM（INVENTORY_DETAIL.現在庫数）倉庫在庫数	
                //add by wanghui  2010/5/5 end  
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                //strSQL.Append(" FROM    INVENTORY_DETAIL,DEMAND,JOB_ORDER                               ");
                //strSQL.Append(" WHERE   JOB_ORDER.JOB_ORDER_NO  =   @JOB_ORDER_NO                       ");
                //strSQL.Append(" AND     DEMAND.ORDER_NO         =   JOB_ORDER.ORDER_NO                  ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 0                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                //strSQL.Append(" AND     INVENTORY_DETAIL.ITEM_NO = DEMAND.ITEM_NO                       ");
                //strSQL.Append(" AND     INVENTORY_DETAIL.WS_CD = DEMAND.WS_CD                           ");
                //strSQL.Append(" AND     INVENTORY_DETAIL.WHS_CD = DEMAND.DISB_WHS                       ");
                strSQL.Append(" GROUP BY  INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WHS_CD )  INV ON    ");
                strSQL.Append("      D.ITEM_NO =   INV.ITEM_NO                                          ");
                strSQL.Append(" AND  D.DISB_WHS =   INV.WHS_CD                                          ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON JO.WS_CD = WS.WS_CD               ");
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD,                ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) WIP_QTY        ");
                //add by wanghui  2010/5/5 start
                strSQL.Append(" ,SUM(INVENTORY_DETAIL.INV_BAL) WIP_INV_BAL                              ");//SUM（INVENTORY_DETAIL.	現在庫数）現場在庫数	
                //add by wanghui  2010/5/5 end  
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                //strSQL.Append(" FROM    INVENTORY_DETAIL,DEMAND,JOB_ORDER                               ");
                //strSQL.Append(" WHERE   JOB_ORDER.JOB_ORDER_NO  =   @JOB_ORDER_NO                       ");
                //strSQL.Append(" AND     DEMAND.ORDER_NO         =   JOB_ORDER.ORDER_NO                  ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM =   0                                   ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE = 1                               ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE = 0                                   ");
                //strSQL.Append(" AND     INVENTORY_DETAIL.ITEM_NO = DEMAND.ITEM_NO                       ");
                //strSQL.Append(" AND     INVENTORY_DETAIL.WS_CD = DEMAND.WS_CD                           ");
                strSQL.Append(" GROUP BY  INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD )  WIP ON     ");
                strSQL.Append("      D.ITEM_NO =   WIP.ITEM_NO                                          ");
                //strSQL.Append(" AND  D.WS_CD =   WIP.WS_CD                                              ");
                strSQL.Append(" AND  WIP.WS_CD =   CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN D.WS_CD ELSE WS.REP_WS_CD END "); // 2011.03.09
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT WIP_ALLOC.DEMAND_NO,SUM(WIP_ALLOC.ALLOC_QTY)  WIP_ALLOC_QTY     ");
                strSQL.Append(" FROM    WIP_ALLOC                                                       ");
                //strSQL.Append(" FROM    WIP_ALLOC,DEMAND ,JOB_ORDER                                     ");
                //strSQL.Append(" WHERE   DEMAND.ORDER_NO =   @JOB_ORDER_NO                               ");
                //strSQL.Append(" AND     DEMAND.ORDER_NO =   JOB_ORDER.ORDER_NO                          ");
                //strSQL.Append(" AND     DEMAND.DEMAND_NO =   WIP_ALLOC.DEMAND_NO                        ");
                //strSQL.Append(" WHERE   WIP_ALLOC.ALLOC_STATUS  <=   20                                 ");   //Del 11.01.03 Ubiq-Sai
                strSQL.Append(" WHERE   WIP_ALLOC.ALLOC_STATUS  <   20                                  ");     //Add 11.01.03 Ubiq-Sai
                strSQL.Append(" AND     WIP_ALLOC.SCH_FLAG      IN (0,2)                                ");
                strSQL.Append(" GROUP BY  WIP_ALLOC.DEMAND_NO   )  WIPALLOC  ON                         ");
                strSQL.Append("      D.DEMAND_NO    =   WIPALLOC.DEMAND_NO                              ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER IM ON D.ITEM_NO = IM.ITEM_NO                ");
                //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON JO.ORDER_UMSR = S1.KEY02         ");   //Del 10.11.04 Ubiq-Sai
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON D.ITEM_UMSR = S1.KEY02         ");       //Add 10.11.04 Ubiq-Sai
                strSQL.Append(" AND      S1.KEY01   =   'ITEM_UMSR'                                      ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PM ON D.WS_CD = PM.WS_CD AND D.PROCESS_CD = PM.PROCESS_CD       ");
                strSQL.Append(" WHERE   JO.JOB_ORDER_NO     =   @JOB_ORDER_NO                           ");
                strSQL.Append(" AND (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1)) ");
                strSQL.Append(" AND  D.ITEM_TYPE <> '99'                            ");

                //add by wanghui 2010/5/5 start

                strSQL.Append(" ) TBL  WHERE 1=1 ");

                if (alloc_flag == 1)
                {
                    strSQL.Append(" AND   PLAN_DISB_QTY > 0                  ");
                }

                if (miss_disb == 1)
                {
                    strSQL.Append(" AND   ALLOC_QTY >0                  ");
                }
                //add by wanghui 2010/5/5 end
                strSQL.Append(" ORDER BY PART_SEQ, CHILD_ITEM   ");     //10.08.25 Ubiq-Sai Add PART_SEQ


                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
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
        /// DEMAND_NOを条件に同じグループのデマンドを検索
        /// [MfgJORlse]
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Mfg_JoRlseGroupDemandDetail()//20090701 ADD UBIQ-LIU
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                                                   ");
            strSQL.Append(" PD.ITEM_NO,     I.ITEM_DESC,    ISNULL(INV.FREE_QTY,0) I_FREE_QTY,      PD.PLAN_QTY,                    ");
            strSQL.Append(" (CASE WHEN (PD.ALLOC_QTY-PD.ACT_DISB_QTY)<0 then 0 ELSE (PD.ALLOC_QTY-PD.ACT_DISB_QTY) END) ALLOC_QTY,  ");
            strSQL.Append(" ISNULL(WIP.FREE_QTY,0) W_FREE_QTY,   ISNULL(WIPALLOC.WIP_ALLOC_QTY,0) WIP_ALLOC_QTY,  PD.DEMAND_NO,     ");
            strSQL.Append(" PD.PROCESS_CD,      PM.PROCESS_DESC,     PD.SCH_DISB_DATE,     PD.DISB_WHS                              ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM ITEM_MASTER I , PROCESS_MASTER PM,                                 ");
                strSQL.Append(" (SELECT *                                                               ");
                strSQL.Append(" FROM    PLANNED_DEMAND                                                  ");
                strSQL.Append(" WHERE   SUB_GRP_CD IN  (SELECT SUB_GRP_CD FROM PLANNED_DEMAND           ");
                strSQL.Append(" WHERE   DEMAND_NO   =   :DEMAND_NO                                      ");
                strSQL.Append(" ) AND   ORDER_NO    IN  ( SELECT  ORDER_NO FROM PLANNED_DEMAND          ");
                strSQL.Append(" WHERE   DEMAND_NO   =   :DEMAND_NO   )                                  ");
                strSQL.Append(" AND     SUB_GRP_CD         <>   ''                                      ");
                strSQL.Append(" AND     SUB_ACTION_FLAG    =    0  ) PD,                                ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,WHS_CD,                                ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) FREE_QTY       ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM      =       0                          ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE=       0                          ");
                strSQL.Append("GROUP BY INVENTORY_DETAIL.ITEM_NO,WHS_CD                                 ");
                strSQL.Append(" ) INV ON    PD.ITEM_NO          =   INV.ITEM_NO                         ");
                strSQL.Append(" AND         PD.DISB_WHS         =   INV.WHS_CD                          ");
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" ( SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD,               ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) FREE_QTY       ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM      =       0                          ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE=       1                          ");
                strSQL.Append("GROUP BY INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD                 ");
                strSQL.Append(" ) WIP,                                                                  ");
                strSQL.Append(" ( SELECT DEMAND_NO, SUM(ALLOC_QTY) WIP_ALLOC_QTY                        ");
                strSQL.Append(" FROM    WIP_ALLOC                                                       ");
                strSQL.Append(" WHERE   ALLOC_STATUS    =       0                                       ");
                strSQL.Append(" AND     SCH_FLAG       IN     (0,2)                                     ");
                strSQL.Append("GROUP BY DEMAND_NO                                                       ");
                strSQL.Append(" ) WIPALLOC                                                              ");

                strSQL.Append(" WHERE     PD.ITEM_NO         =   INV.ITEM_NO                            ");
                strSQL.Append(" AND     PD.DISB_WHS =   INV.WHS_CD(+)                                   ");
                strSQL.Append(" AND     PD.ITEM_NO = WIP.ITEM_NO                                        ");
                strSQL.Append(" AND     PD.WS_CD = WIP.WS_CD(+)                                         ");
                strSQL.Append(" AND     PD.DEMAND_NO = WIPALLOC.DEMAND_NO(+)                            ");
                strSQL.Append(" AND     PD.ITEM_NO  = I.ITEM_NO                                         ");
                strSQL.Append(" AND     PD.PROCESS_CD  = PM.PROCESS_CD                                  ");
                strSQL.Append(" AND     PD.WS_CD       = PM.WS_CD                                       ");

                db.DbPsetString("DEMAND_NO", _demand_no);
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM (SELECT *                                                          ");
                strSQL.Append(" FROM    PLANNED_DEMAND                                                  ");
                strSQL.Append(" WHERE   SUB_GRP_CD IN  (SELECT SUB_GRP_CD FROM PLANNED_DEMAND           ");
                strSQL.Append(" WHERE   DEMAND_NO   =   @DEMAND_NO                                      ");
                strSQL.Append(" ) AND   ORDER_NO    IN  ( SELECT  ORDER_NO FROM PLANNED_DEMAND          ");
                strSQL.Append(" WHERE   DEMAND_NO   =   @DEMAND_NO   )                                  ");
                strSQL.Append(" AND     SUB_GRP_CD         <>   ''                                      ");
                strSQL.Append(" AND     SUB_ACTION_FLAG    =    0  ) PD                                 ");
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" (SELECT INVENTORY_DETAIL.ITEM_NO,WHS_CD,                                ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) FREE_QTY       ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                                ");
                //strSQL.Append(" FROM    INVENTORY_DETAIL,PLANNED_DEMAND                                 ");
                //strSQL.Append(" ,(SELECT *                                                              ");
                //strSQL.Append(" FROM    PLANNED_DEMAND                                                  ");
                //strSQL.Append(" WHERE   SUB_GRP_CD IN  (SELECT SUB_GRP_CD FROM PLANNED_DEMAND           ");
                //strSQL.Append(" WHERE   DEMAND_NO   =   @DEMAND_NO                                      ");
                //strSQL.Append(" ) AND   ORDER_NO    IN  ( SELECT  ORDER_NO FROM PLANNED_DEMAND          ");
                //strSQL.Append(" WHERE   DEMAND_NO   =   @DEMAND_NO   )                                  ");
                //strSQL.Append(" AND     SUB_GRP_CD         <>   ''                                      ");
                //strSQL.Append(" AND     SUB_ACTION_FLAG    =    0  ) PD                                 ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM      =       0                          ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE=       0                          ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE       = 0                             ");
                //strSQL.Append(" AND     INVENTORY_DETAIL.ITEM_NO = PLANNED_DEMAND.ITEM_NO               ");
                //strSQL.Append(" AND     INVENTORY_DETAIL.WHS_CD = PLANNED_DEMAND.DISB_WHS               ");
                strSQL.Append("GROUP BY INVENTORY_DETAIL.ITEM_NO,WHS_CD                                 ");
                strSQL.Append(" ) INV ON    PD.ITEM_NO          =   INV.ITEM_NO                         ");
                strSQL.Append(" AND         PD.DISB_WHS         =   INV.WHS_CD                          ");

                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON WS.WS_CD = PD.WS_CD               "); // 2011.03.09

                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" ( SELECT INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD,               ");
                strSQL.Append(" SUM(INVENTORY_DETAIL.INV_BAL-INVENTORY_DETAIL.ALLOC_QTY) FREE_QTY       ");
                strSQL.Append(" FROM    INVENTORY_DETAIL                                ");
                strSQL.Append(" WHERE   INVENTORY_DETAIL.INV_YM      =       0                          ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_WIP_TYPE=       1                          ");
                strSQL.Append(" AND     INVENTORY_DETAIL.INV_TYPE       = 0                             ");
                strSQL.Append("GROUP BY INVENTORY_DETAIL.ITEM_NO,INVENTORY_DETAIL.WS_CD                 ");
                strSQL.Append(" ) WIP ON    PD.ITEM_NO          =   WIP.ITEM_NO                         ");
                //strSQL.Append(" AND         PD.WS_CD            =   WIP.WS_CD                           ");
                strSQL.Append(" AND         WIP.WS_CD            =   CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN PD.WS_CD ELSE WS.REP_WS_CD END "); // 2011.03.09
                strSQL.Append(" LEFT OUTER JOIN                                                         ");
                strSQL.Append(" ( SELECT WIP_ALLOC.DEMAND_NO, SUM(WIP_ALLOC.ALLOC_QTY) WIP_ALLOC_QTY    ");
                strSQL.Append(" FROM    WIP_ALLOC,PLANNED_DEMAND                                        ");
                strSQL.Append(" WHERE   ALLOC_STATUS    =       0                                       ");
                strSQL.Append(" AND     SCH_FLAG       IN     (0,2)                                     ");
                strSQL.Append(" AND     PLANNED_DEMAND.DEMAND_NO =   WIP_ALLOC.DEMAND_NO                ");
                strSQL.Append("GROUP BY WIP_ALLOC.DEMAND_NO                                             ");
                strSQL.Append(" ) WIPALLOC ON  PD.DEMAND_NO = WIPALLOC.DEMAND_NO                        ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PM ON  PD.PROCESS_CD= PM.PROCESS_CD      ");
                strSQL.Append(" AND     PM.WS_CD         =   PD.WS_CD                                   ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON  PD.ITEM_NO= I.ITEM_NO                 ");

                //strSQL.Append(" WHERE   PD.DEMAND_NO     =   @DEMAND_NO                                   ");
                //strSQL.Append(" AND (PD.SUB_GRP_CD = '' OR (PD.SUB_GRP_CD <> '' AND PD.SUB_ACTION_FLAG = 1)) ");
                //strSQL.Append(" AND  PD.ITEM_TYPE <> '99'                                               ");


                db.DbPsetString("@DEMAND_NO", _demand_no);
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
        /// 製造オーダ対象データを検索する
        /// <para>使用画面：[MfgDemandMnt]</para>
        /// </summary>
        public DataSet Get_Mfg_DemandMntJobOrderList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT  *  FROM                                                                              ");
            //・計画オーダ
            strSQL.Append("(SELECT                                                                                      ");
            strSQL.Append("P.SCH_ID,            P.JOC_CD,               P.ITEM_NO,              P.ITEM_DESC,            ");
            strSQL.Append("P.ORDER_QTY,         P.ORDER_UMSR,           P.SCH_START_DATE,       P.SCH_COMPL_DATE,       ");
            strSQL.Append("P.ALLOC_FLAG,        S1.DATA_CHAR UMSR_NAME, P.ORDER_STATUS,         P.ORDER_NO,             ");
            strSQL.Append("P.WS_CD,             'P' TABLE_TYPE,         S2.DATA_CHAR SCH_NAME                           ");

            strSQL.Append(" FROM PLANNED_ORDER P                                      ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S1 ON S1.KEY01= 'ITEM_UMSR'    ");
            strSQL.Append(" AND S1.KEY02= P.ORDER_UMSR                                ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S2 ON S2.KEY01= 'SCH_ID'       ");
            strSQL.Append(" AND S2.KEY02= P.SCH_ID                                    ");
            strSQL.Append("  WHERE P.SC_FLAG    =   0                                 ");
            strSQL.Append("  AND   P.ITEM_TYPE  <>  99                                ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                if (_joc_cd != "")
                {
                    strSQL.Append(" AND P.JOC_CD = :JOC_CD                  ");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }

                if (_sch_compl_date != 0)
                {
                    strSQL.Append(" AND P.SCH_COMPL_DATE <= :SCH_COMPL_DATE                  ");
                    db.DbPsetInt("SCH_COMPL_DATE", _sch_compl_date);
                }

                if (_sch_id != "")
                {
                    strSQL.Append(" AND P.SCH_ID = :SCH_ID                  ");
                    db.DbPsetString("SCH_ID", _sch_id);
                }

                if (_item_no != "")
                {
                    strSQL.Append(" AND P.ITEM_NO = :ITEM_NO                  ");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
            }
            else
            {
                db.DbParametersClear();
                if (_joc_cd != "")
                {
                    strSQL.Append(" AND P.JOC_CD = @JOC_CD                  ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }

                if (_sch_compl_date != 0)
                {
                    strSQL.Append(" AND P.SCH_COMPL_DATE <= @SCH_COMPL_DATE                  ");
                    db.DbPsetInt("@SCH_COMPL_DATE", _sch_compl_date);
                }

                if (_sch_id != "")
                {
                    strSQL.Append(" AND P.SCH_ID = @SCH_ID                  ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }

                if (_item_no != "")
                {
                    strSQL.Append(" AND P.ITEM_NO = @ITEM_NO                  ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
            }
            strSQL.Append(" AND P.JOC_CD IN (SELECT JOC_CD FROM JOC_MASTER)        ");

            strSQL.Append("UNION ALL                                                                                    ");
            //製造オーダ
            strSQL.Append("SELECT                                                                                       ");
            strSQL.Append("J.SCH_ID,            J.JOC_CD,               J.ITEM_NO,              J.ITEM_DESC,            ");
            strSQL.Append("J.ORDER_QTY,         J.ORDER_UMSR,           J.SCH_START_DATE,       J.SCH_COMPL_DATE,       ");
            strSQL.Append("J.ALLOC_FLAG,        S1.DATA_CHAR UMSR_NAME, J.ORDER_STATUS,         J.ORDER_NO,             ");
            strSQL.Append("J.WS_CD,             'R' TABLE_TYPE,         S2.DATA_CHAR SCH_NAME                           ");

            strSQL.Append(" FROM JOB_ORDER J                                        ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S1 ON S1.KEY01= 'ITEM_UMSR'  ");
            strSQL.Append(" AND S1.KEY02= J.ORDER_UMSR                              ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S2 ON S2.KEY01= 'SCH_ID'     ");
            strSQL.Append(" AND S2.KEY02= J.SCH_ID                                  ");
            strSQL.Append(" WHERE  J.ITEM_TYPE      <>   '99'                       ");
            strSQL.Append(" AND    J.ORDER_STATUS    <   40                         ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                if (_joc_cd != "")
                {
                    strSQL.Append(" AND J.JOC_CD = :JOC_CD                  ");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }

                if (_sch_compl_date != 0)
                {
                    strSQL.Append(" AND J.SCH_COMPL_DATE <= :SCH_COMPL_DATE                  ");
                    db.DbPsetInt("SCH_COMPL_DATE", _sch_compl_date);
                }

                if (_sch_id != "")
                {
                    strSQL.Append(" AND J.SCH_ID = :SCH_ID                  ");
                    db.DbPsetString("SCH_ID", _sch_id);
                }

                if (_item_no != "")
                {
                    strSQL.Append(" AND J.ITEM_NO = :ITEM_NO                  ");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
            }
            else
            {
                db.DbParametersClear();
                if (_joc_cd != "")
                {
                    strSQL.Append(" AND J.JOC_CD = @JOC_CD                  ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }

                if (_sch_compl_date != 0)
                {
                    strSQL.Append(" AND J.SCH_COMPL_DATE <= @SCH_COMPL_DATE                  ");
                    db.DbPsetInt("@SCH_COMPL_DATE", _sch_compl_date);
                }

                if (_sch_id != "")
                {
                    strSQL.Append(" AND J.SCH_ID = @SCH_ID                  ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }

                if (_item_no != "")
                {
                    strSQL.Append(" AND J.ITEM_NO = @ITEM_NO                  ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
            }
            strSQL.Append(") A                  ");
            strSQL.Append("ORDER BY SCH_START_DATE,SCH_COMPL_DATE                 ");
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
        /// オーダー№の所要情報を検索して子部品明細画面に表示する
        /// <para>使用画面：[MfgDemandMnt]</para>
        /// </summary>
        public DataSet Get_Mfg_DemandMntList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                                       ");
            strSQL.Append("D.ITEM_NO,           I.ITEM_DESC,            D.ITEM_TYPE,            D.PROCESS_CD,           ");
            strSQL.Append("P.PROCESS_DESC,      D.PLAN_QTY,             D.ITEM_UMSR,            D.ALLOC_QTY,            ");
            strSQL.Append("(D.WIP_ALLOC_QTY-D.ALLOC_QTY) WIP_ALLOC_QTY, D.SCH_DISB_DATE,        D.ACT_DISB_QTY,         ");
            strSQL.Append("D.DISB_WHS,          D.SUB_GRP_CD,           D.SUB_ACTION_FLAG,      S1.DATA_CHAR UMSR_NAME, ");
            strSQL.Append("D.DEMAND_NO,         0 CHG_TYPE, D.PLAN_QTY NEW_PLAN_QTY, D.SCH_DISB_DATE NEW_SCH_DISB_DATE, ");
            strSQL.Append(" D.SUB_ACTION_FLAG NEW_SUB_ACTION_FLAG,      D.USAGE_TYPE,   (CASE D.USAGE_TYPE WHEN 0 THEN  ");
            strSQL.Append(" CONVERT(VARCHAR,D.USAGE_DEC) ELSE CONVERT(VARCHAR,D.USAGE_NUMERATOR)+'/'                    ");
            strSQL.Append(" +CONVERT(VARCHAR,D.USAGE_DENOMINATOR) END) USAGE_DEC,(CASE D.USAGE_TYPE WHEN 0              ");
            strSQL.Append(" THEN CONVERT(VARCHAR,D.USAGE_DEC) ELSE CONVERT(VARCHAR,D.USAGE_NUMERATOR)+'/'               ");
            strSQL.Append(" +CONVERT(VARCHAR,D.USAGE_DENOMINATOR) END) NEW_USAGE_DEC,                                   ");
            strSQL.Append(" D.USAGE_TYPE NEW_USAGE_TYPE                                                                 ");
            if (table_type == "P")//・計画所要
            {
                strSQL.Append(" FROM PLANNED_DEMAND D                                                                   ");
            }
            else//table_type=="R"・所要
            {
                strSQL.Append(" FROM DEMAND D                                                                           ");
            }
            strSQL.Append(" LEFT JOIN PROCESS_MASTER P ON P.PROCESS_CD= D.PROCESS_CD                                    ");
            strSQL.Append(" AND P.WS_CD= D.WS_CD                                                                        ");
            strSQL.Append(" LEFT JOIN ITEM_MASTER I ON I.ITEM_NO= D.ITEM_NO                                             ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S1 ON S1.KEY01= 'ITEM_UMSR'                                      ");
            strSQL.Append(" AND S1.KEY02= D.ITEM_UMSR                                                                   ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append("  WHERE D.ORDER_NO    =   :ORDER_NO                   ");

                db.DbPsetString("ORDER_NO", _order_no);

            }
            else
            {
                db.DbParametersClear();
                strSQL.Append("  WHERE D.ORDER_NO    =   @ORDER_NO                   ");

                db.DbPsetString("@ORDER_NO", _order_no);
            }
            strSQL.Append("  AND D.ITEM_TYPE    <>   '99'                   ");//ADD BY UBIQ-LIU 2010/5/21 品目区分<>ダミー品の条件を追加する
            strSQL.Append("  ORDER BY D.PART_SEQ, D.ITEM_NO                 "); //10.08.25 Ubiq-Sai Add PART_SEQ
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
        /// デマンドメンテナンス更新処理
        /// 
        ///<para>使用画面：[MfgDemandMnt]</para>
        /// </summary>
        public int Mfg_DemandMnt()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_DEMAND_NO", _demand_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_PARENT_ITEM_NO", _parent_item_no, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetString("@I_SCH_ID", _sch_id, ComConst.DB_IN);
            db.DbPsetString("@I_JOC_CD", _joc_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PARENT_ORDER_NO", _parent_order_no, ComConst.DB_IN);
            db.DbPsetInt("@I_USAGE_TYPE", _usage_type, ComConst.DB_IN);
            db.DbPsetDouble("@I_USAGE_DEC", _usage_dec, ComConst.DB_IN);
            db.DbPsetInt("@I_USAGE_NUMERATOR", _usage_numerator, ComConst.DB_IN);
            db.DbPsetInt("@I_USAGE_DENOMINATOR", _usage_denominator, ComConst.DB_IN);
            db.DbPsetDouble("@I_PLAN_QTY", _plan_qty, ComConst.DB_IN);
            db.DbPsetInt("@I_SCH_DISB_DATE", _sch_disb_date, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetString("@I_DISB_WHS", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_SUB_GRP_CD", _sub_grp_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_SUB_ACTION_FLAG", _sub_action_flag, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_TYPE", _table_type, ComConst.DB_IN);
            db.DbPsetInt("@I_CHG_TYPE", _chg_type, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_MFG_DEMAND_MNT");
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
        /// 作業指示№に対して作業指示票発行を行
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Mfg_JoProcessSheetDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                       ");
            strSQL.Append("'*' + JO.JOB_ORDER_NO + '*' BAR_CODE,                                        ");     //Add 10.04.23
            strSQL.Append("JO.JOB_ORDER_NO,     JO.WS_CD,       WS.WS_DESC,         JO.SCH_START_DATE,  ");
            strSQL.Append("JO.SCH_COMPL_DATE,   JO.ITEM_NO,     JO.ITEM_DESC,       JO.JOB_ORDER_QTY,   ");
            strSQL.Append("JO.JOC_CD,           I.DRAWING_NO,   JO.WHS_CD,          JO.INSP_CD,         ");
            strSQL.Append("JO.SCH_ID,  S1.DATA_CHAR SCH_NAME,  S2.DATA_CHAR INSP_NAME,     JO.SLIP_NOTE,");
            strSQL.Append("JOD.PROCESS_CD,PM.PROCESS_DESC,  JO.ORDER_UMSR,   S3.DATA_CHAR UMSR_NAME,    ");
            strSQL.Append("JOD.SCH_SETUP_TIME + JOD.SCH_WORK_TIME + JOD.SCH_TRANSFER_TIME AS WORK_TIME  ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append("FROM                                                                     ");
                strSQL.Append("JOB_ORDER JO,    WORKSHOP_MASTER WS, ITEM_MASTER I,  SYSTEM_PARAMETER S,	");
                strSQL.Append("JOB_ORDER_DETAIL JOD,        PROCESS_MASTER	PM                          ");
                strSQL.Append(" WHERE       JO.WS_CD           = WS.WS_CD                               ");
                strSQL.Append(" AND         JO.JOB_ORDER_NO    = JOD.JOB_ORDER_NO(+)                    ");
                strSQL.Append(" AND         JOD.WS_CD     = PM.WS_CD(+)                       ");
                strSQL.Append(" AND         JOD.PROCESS_CD     = PM.PROCESS_CD(+)                       ");

                if (print_type == 0)
                {
                    strSQL.Append(" AND     JO.JOB_ORDER_NO            = :JOB_ORDER_NO          ");
                    db.DbPsetString("JOB_ORDER_NO", _job_order_no);
                }
                else
                {
                    strSQL.Append(" AND     JO.SCH_ID           = :SCH_ID                       ");
                    strSQL.Append(" AND     JO.WS_CD            = :WS_CD                        ");
                    strSQL.Append(" AND     JO.SCH_START_DATE   = :SCH_START_DATE               ");
                    strSQL.Append(" AND     JO.ORDER_STATUS            = 10                     ");
                    strSQL.Append(" AND     JO.SLIP_ISSUE_FLAG         = 0                      ");
                    db.DbPsetString("WS_CD", _ws_cd);
                    db.DbPsetString("SCH_ID", _sch_id);
                    db.DbPsetInt("SCH_START_DATE", _sch_start_date);
                }
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append("FROM                                                                         ");
                strSQL.Append("JOB_ORDER   JO                                                               ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON    JO.WS_CD    = WS.WS_CD             ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I    ON  JO.ITEM_NO     = I.ITEM_NO             ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01='SCH_ID'                    ");
                strSQL.Append(" AND S1.KEY02 = JO.SCH_ID                                                    ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01='INSP_CD'                   ");
                strSQL.Append(" AND S2.KEY02 = JO.INSP_CD                                                   ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S3 ON S3.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND S3.KEY02        =       JO.ORDER_UMSR                                   ");
                strSQL.Append(" LEFT OUTER JOIN JOB_ORDER_DETAIL JOD ON  JO.JOB_ORDER_NO = JOD.JOB_ORDER_NO ");
                strSQL.Append(" LEFT OUTER JOIN  PROCESS_MASTER	PM  ON  JOD.PROCESS_CD     = PM.PROCESS_CD  ");
                strSQL.Append(" AND JOD.WS_CD = PM.WS_CD                                                    ");
                strSQL.Append(" WHERE    JO.ITEM_TYPE <> '99'                                               ");

                if (print_type == 0)
                {
                    strSQL.Append(" AND     JO.JOB_ORDER_NO            = @JOB_ORDER_NO          ");
                    db.DbPsetString("@JOB_ORDER_NO", _job_order_no);
                }
                else//作業指示一覧表発行明細
                {
                    strSQL.Append(" AND     JO.SCH_ID           = @SCH_ID                       ");
                    strSQL.Append(" AND     JO.WS_CD            = @WS_CD                        ");
                    strSQL.Append(" AND     JO.SCH_START_DATE   = @SCH_START_DATE               ");
                    strSQL.Append(" AND     JO.ORDER_STATUS            < 85                     ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                    db.DbPsetString("@WS_CD", _ws_cd);
                    db.DbPsetInt("@SCH_START_DATE", _sch_start_date);
                }
            }

            strSQL.Append(" ORDER BY JO.JOB_ORDER_NO,JO.ITEM_NO,JOD.PROCESS_CD                           ");
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
        /// 製作指示数の取得
        /// <para>使用画面：受注変更・取消[OrdSOUpd]</para>
        /// </summary>
        public int GetMpsQty()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql 
            strSQL.Append("SELECT ISNULL(SUM(P.MPS_QTY),0) MPS_QTY       ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PRODUCTION_PLAN P                  ");
                strSQL.Append(" WHERE   P.ITEM_NO         = :ITEM_NO    ");
                strSQL.Append(" AND     P.JOC_CD          = :JOC_CD     ");

                db.DbParametersClear();
                db.DbPsetString("JOC_CD", _joc_cd);
                db.DbPsetString("ITEM_NO", _item_no);
            }
            else
            {
                strSQL.Append(" FROM PRODUCTION_PLAN P                  ");
                strSQL.Append(" WHERE   P.ITEM_NO         = @ITEM_NO    ");
                strSQL.Append(" AND     P.JOC_CD          = @JOC_CD     ");

                db.DbParametersClear();
                db.DbPsetString("@JOC_CD", _joc_cd);
                db.DbPsetString("@ITEM_NO", _item_no);

            }
            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _job_order_qty = double.Parse(db.Row("MPS_QTY"));
            }
            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        //-->ADD BY UBIQ-SUO 2011/1/25
        /// <summary>
        /// 作業指示№に対して作業指示票発行を行
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Mfg_JoRlsePlannedOrderDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT distinct                                                              ");
            strSQL.Append("PO.ORDER_NO,     PO.WS_CD,       WS.WS_DESC,         PO.SCH_START_DATE,      ");
            strSQL.Append("PO.SCH_COMPL_DATE,   PO.ITEM_NO,     PO.ITEM_DESC,       PO.ORDER_QTY,       ");
            strSQL.Append("S.DATA_CHAR UMSR_NAME,           PO.WHS_CD,   WH.WHS_DESC,   PO.INSP_CD,     ");
            strSQL.Append("PO.JOC_CD  ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append("FROM                                                                     ");
                strSQL.Append("PLANNED_ORDER PO,    WORKSHOP_MASTER WS, WAREHOUSE_MASTER WH， SYSTEM_PARAMETER S");
                strSQL.Append(" WHERE       PO.WS_CD           = WS.WS_CD(+)                            ");
                strSQL.Append(" AND         PO.WHS_CD    = WH.WHS_CD(+)                                 ");
                strSQL.Append(" AND         PO.ORDER_UMSR    = S.KEY02(+)                               ");
                strSQL.Append(" AND         S.KEY01  = 'ITEM_UMSR'                                      ");

                strSQL.Append(" AND     PO.ORDER_NO            = :ORDER_NO                              ");
                db.DbPsetString("ORDER_NO", _order_no);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM                                                                        ");
                strSQL.Append(" PLANNED_ORDER   PO                                                          ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON    PO.WS_CD    = WS.WS_CD             ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WH    ON  PO.WHS_CD     = WH.WHS_CD        ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01  = 'ITEM_UMSR'                ");
                strSQL.Append("  AND    S.KEY02  = PO.ORDER_UMSR                                           ");
                strSQL.Append(" WHERE                                                                       ");

                strSQL.Append("      PO.ORDER_NO            = @ORDER_NO                             ");
                db.DbPsetString("@ORDER_NO", _order_no);                              
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
        /// 
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Mfg_JoRlseJobOrderDetailList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT   DISTINCT                                                  ");
            strSQL.Append("JOD.PROCESS_SEQ,		JOD.PROCESS_CD,	   PM.PROCESS_DESC,	");
            strSQL.Append("JOD.SCH_WORK_TIME + JOD.SCH_SETUP_TIME + JOD.SCH_TRANSFER_TIME TIME");            
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER_DETAIL JOD , PROCESS_MASTER PM                              ");
                strSQL.Append(" WHERE                                                     ");
                strSQL.Append("  JOD.PROCESS_CD = PM.PROCESS_CD(+)          ");
                strSQL.Append("  AND JOD.ORDER_NO = :ORDER_NO               ");
                db.DbPsetString("ORDER_NO", _order_no);                              
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM JOB_ORDER_DETAIL JOD                                               ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PM ON JOD.PROCESS_CD = PM.PROCESS_CD     ");
                strSQL.Append(" WHERE  JOD.ORDER_NO = @ORDER_NO                                         ");
                db.DbPsetString("@ORDER_NO", _order_no); 
            }

            try
            {
                strSQL.Append("  ORDER BY JOD.PROCESS_SEQ ");
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
        /// 現在庫の取得
        /// 使用画面：MfgJORlse
        /// </summary>
        /// <returns></returns>
        public DataSet GetInvBal()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                   ");
            strSQL.Append(" SUM(ID.INV_BAL) INV_BAL,IM.SAFETY_STOCK_TYPE,IM.SAFETY_STOCK,    ");
            strSQL.Append(" IM.SAFETY_STOCK_DAYS,IM.SAFETY_STOCK_RATIO              ");
            strSQL.Append(" FROM INVENTORY_DETAIL ID                                ");
            strSQL.Append(" LEFT JOIN ITEM_MASTER IM ON ID.ITEM_NO = IM.ITEM_NO     ");

            db.DbParametersClear();
            strSQL.Append(" WHERE ID.INV_YM = 0                                     ");
            //strSQL.Append(" AND  ID.INV_WIP_TYPE IN (CASE IM.WIP_TYPE WHEN  1 THEN 0 WHEN 0 THEN (0,1) ELSE 5 END )");
            strSQL.Append(" AND  (ID.INV_WIP_TYPE = (CASE IM.WIP_TYPE WHEN  1 THEN 0 WHEN 0 THEN 0 ELSE 5 END ) ");
            strSQL.Append("  or ID.INV_WIP_TYPE = (CASE IM.WIP_TYPE WHEN  1 THEN 0 WHEN 0 THEN 1 ELSE 5 END ) )");
            strSQL.Append(" AND  ID.INV_TYPE = 0                                    ");

            strSQL.Append(" AND  ID.ITEM_NO = @ITEM_NO                              ");
            db.DbPsetString("@ITEM_NO",_item_no);
            strSQL.Append(" AND  ID.WHS_CD IN (SELECT WHS_CD FROM WAREHOUSE_MASTER  WM WHERE WM.MRP_WHS = @MRP_WHS)                              ");
            db.DbPsetString("@MRP_WHS", _mrp_whs_grp);

            try
            {
                strSQL.Append("  GROUP BY IM.SAFETY_STOCK_TYPE,IM.SAFETY_STOCK,IM.SAFETY_STOCK_DAYS,IM.SAFETY_STOCK_RATIO");
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
        /// 現在庫の取得
        /// 使用画面：MfgJORlse
        /// </summary>
        /// <returns></returns>
        public DataSet GetOrderList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT A.* ");
            strSQL.Append(" FROM (");
            strSQL.Append(" SELECT I.SCH_COMPL_DATE DATE, '' WS_CD, 0 PLAN_QTY,0 QTY, I.ORDER_QTY, I.JOB_ORDER_NO,");
            strSQL.Append(" I.JOC_CD,  0 SORT");
            strSQL.Append(" FROM");
            strSQL.Append(" (SELECT PLO.SCH_COMPL_DATE, PLO.ORDER_QTY, '' JOB_ORDER_NO,");
            strSQL.Append(" PLO.JOC_CD");
            strSQL.Append(" FROM PLANNED_ORDER PLO");
            strSQL.Append(" WHERE PLO.ITEM_NO = @ITEM_NO");
            strSQL.Append(" AND   PLO.MRP_WHS_GRP = @MRP_WHS_GRP");
            strSQL.Append(" UNION ");
            strSQL.Append(" SELECT PUO.SCH_COMPL_DATE, PUO.JOB_ORDER_QTY - PUO.JOB_ORDER_COMPL_QTY ORDER_QTY, ");
            strSQL.Append(" PUO.JOB_ORDER_NO, PUO.JOC_CD");
            strSQL.Append(" FROM PUR_ORDER PUO");
            strSQL.Append(" WHERE PUO.ORDER_STATUS <= 30");
            strSQL.Append(" AND   PUO.ITEM_NO = @ITEM_NO");
            strSQL.Append(" AND   PUO.MRP_WHS_GRP = @MRP_WHS_GRP");
            strSQL.Append(" UNION");
            strSQL.Append(" SELECT JO.SCH_COMPL_DATE, JO.JOB_ORDER_QTY - JO.JOB_ORDER_COMPL_QTY ORDER_QTY, ");
            strSQL.Append(" JO.JOB_ORDER_NO,JO.JOC_CD");
            strSQL.Append(" FROM JOB_ORDER JO");
            strSQL.Append(" WHERE JO.ORDER_STATUS <= 30");
            strSQL.Append(" AND   JO.ITEM_NO = @ITEM_NO");
            strSQL.Append(" AND   JO.MRP_WHS_GRP = @MRP_WHS_GRP");
            strSQL.Append(" ) I");
            strSQL.Append(" UNION");
            strSQL.Append(" SELECT O.SCH_DISB_DATE DATE,O.WS_CD,O.PLAN_QTY,0 QTY, 0 ORDER_QTY, ''JOB_ORDER_NO,");
            strSQL.Append(" O.JOC_CD, 1 SORT");
            strSQL.Append(" FROM");
            strSQL.Append(" (SELECT PD.SCH_DISB_DATE,PD.WS_CD,PD.PLAN_QTY,PD.JOC_CD");
            strSQL.Append(" FROM PLANNED_DEMAND PD");
            strSQL.Append(" WHERE PD.ITEM_NO = @ITEM_NO");
            strSQL.Append(" AND   PD.MRP_WHS_GRP = @MRP_WHS_GRP");
            strSQL.Append(" UNION");
            strSQL.Append(" SELECT D.SCH_DISB_DATE,D.WS_CD,D.PLAN_QTY - D.ACT_DISB_QTY PLAN_QTY,");
            strSQL.Append(" D.JOC_CD");
            strSQL.Append(" FROM DEMAND D");
            strSQL.Append(" WHERE D.DEMAND_STATUS <= 30");
            strSQL.Append(" AND   D.ITEM_NO = @ITEM_NO");
            strSQL.Append(" AND   D.MRP_WHS_GRP = @MRP_WHS_GRP");
            strSQL.Append(" AND   D.PLAN_QTY - D.ACT_DISB_QTY > 0 ");    // 2011.02.22
            strSQL.Append(" UNION");
            strSQL.Append(" SELECT SOD.SHIP_REQ_DATE,'' WS_CD, SOD.ORDER_QTY - SOD.ACTUAL_SHIP_QTY PLAN_QTY,");
            strSQL.Append(" SOD.JOC_CD");
            strSQL.Append(" FROM SALES_ORDER_DETAIL SOD");
            strSQL.Append(" WHERE SOD.ITEM_NO = @ITEM_NO");
            strSQL.Append(" AND   SOD.SHIP_WHS = @MRP_WHS_GRP");
            strSQL.Append(" AND   SOD.ORDER_QTY - SOD.ACTUAL_SHIP_QTY > 0 ");    // 2011.02.22
            strSQL.Append(" ) O )A");
            strSQL.Append(" ORDER BY A.DATE ,A.SORT");

            db.DbParametersClear();
            db.DbPsetString("@ITEM_NO",_item_no);
            db.DbPsetString("@MRP_WHS_GRP", _mrp_whs_grp);

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
        //<--ADD BY UBIQ-SUO 2011/1/25

        // IMV3
        /// <summary>
        /// 完成品受入情報入力プロシジャ
        /// 使用画面：InvManWhs
        /// </summary>
        /// <returns></returns>
        public int Inv_ManWhsInsert(ComDB db)
        {
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_RCV_NO", _rcv_no, ComConst.DB_IN);
            db.DbPsetInt("@I_RCV_LINE_NO", _rcv_line_no, ComConst.DB_IN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_DESC", _item_desc, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_JOB_ORDER_QTY", _job_order_qty, ComConst.DB_IN);
            db.DbPsetString("@I_LOT_NO", _slip_note, ComConst.DB_IN); // slip_noにLOT_NOが入っている

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_INV_MANWHS_INSERT");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                rtn = ComConst.FAILED;
            }

            return rtn;
        }
        /// <summary>
        /// 完成品受入情報明細削除プロシジャ
        /// 使用画面：InvManWhsUpd
        /// </summary>
        /// <returns></returns>
        public int Inv_ManWhsDetailDelete(ComDB db)
        {
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_RCV_NO", _rcv_no, ComConst.DB_IN);
            db.DbPsetInt("@I_RCV_LINE_NO", _rcv_line_no, ComConst.DB_IN);
            db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_INV_MANWHS_DETAIL_DELETE");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                rtn = ComConst.FAILED;
            }

            return rtn;
        }

        ///// <summary>
        ///// 完成品受入情報明細更新プロシジャ
        ///// 使用画面：InvManWhsUpd
        ///// </summary>
        ///// <returns></returns>
        //public int Inv_ManWhsUpdate()
        //{
        //    ComDB db = new ComDB(_db_type);
        //    int rtn = 0;

        //    db.DbParametersClear();

        //    db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
        //    db.DbPsetString("@I_RCV_NO", _rcv_no, ComConst.DB_IN);
        //    db.DbPsetInt("@I_RCV_LINE_NO", _rcv_line_no, ComConst.DB_IN);
        //    db.DbPsetString("@I_JOB_ORDER_NO", _job_order_no, ComConst.DB_IN);
        //    db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
        //    db.DbPsetString("@I_ITEM_DESC", _item_desc, ComConst.DB_IN);
        //    db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
        //    db.DbPsetDouble("@I_JOB_ORDER_QTY", _job_order_qty, ComConst.DB_IN);
        //    db.DbPsetString("@I_LOT_NO", _slip_note, ComConst.DB_IN); // slip_noにLOT_NOが入っている

        //    db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
        //    db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
        //    db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
        //    db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
        //    db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
        //    db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
        //    db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
        //    db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

        //    db.DbBeginTrans();
        //    rtn = db.DbStored("SP_INV_MANWHS_UPDATE");
        //    rtn = db.DbPgetInt("RET");
        //    if (rtn == ComConst.SUCCEED)
        //    {
        //        db.DbCommit();
        //    }
        //    else
        //    {
        //        _errcode = db.DbPgetInt("@O_ERRCODE");
        //        _errmsg = db.DbPgetString("@O_MSG");
        //        _sqlcode = db.DbPgetInt("@O_SQLCODE");
        //        _dbmsg = db.DbPgetString("@O_SQLMSG");
        //        _proc_name = db.DbPgetString("@O_PROC_NAME");
        //        _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
        //        db.DbRollback();
        //        rtn = ComConst.FAILED;
        //    }

        //    return rtn;
        //}

        /// <summary>
        /// 完成品受入情報削除プロシジャ
        /// 使用画面：InvManWhsUpd
        /// </summary>
        /// <returns></returns>
        public int Inv_ManWhsDelete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_RCV_NO", _rcv_no, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_INV_MANWHS_DELETE");
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
        /// 完成品受入情報の取得
        /// <para>使用画面：InvManWhsUpd</para>
        /// </summary>
        public DataSet Get_Inv_ManWhsList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                      ");
            strSQL.Append(" JO.RCV_NO,         JO.RCV_LINE_NO,	        JO.JOB_ORDER_NO,	        ");
            strSQL.Append(" JO.ITEM_NO,        JO.ITEM_DESC,		    ");
            //strSQL.Append(" JO.WS_CD,          V.WS_DESC,               JO.JOB_ORDER_QTY,                         ");
            strSQL.Append(" JO.WS_CD,          V.WS_DESC,  CASE JO.SCH_FIX_FLAG WHEN 0 THEN JO.JOB_ORDER_QTY ELSE JO.JOB_ORDER_COMPL_QTY END JOB_ORDER_QTY , ");    // 2015.08.14
            strSQL.Append(" JO.ORDER_UMSR,     JO.SLIP_NOTE,            ");
            strSQL.Append(" JO.WHS_CD,         W.WHS_DESC,              ");
            strSQL.Append(" S1.DATA_CHAR AS UMSR_NAME, JO.SCH_FIX_FLAG	     ");

            strSQL.Append(" FROM JOB_ORDER JO                                                                            ");
            strSQL.Append(" LEFT JOIN WORKSHOP_MASTER V ON JO.WS_CD=V.WS_CD                                              ");
            strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER W ON JO.WHS_CD=W.WHS_CD                                           ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON    S1.KEY01='ITEM_UMSR'  AND      JO.ORDER_UMSR = S1.KEY02 ");
            strSQL.Append(" WHERE  JO.ORDER_STATUS >= 10                                                                 ");
            strSQL.Append(" AND JO.ORDER_STATUS <=85 ");
            if (_chkflag != 1)
                strSQL.Append(" AND JO.STOCK_QTY < JO.JOB_ORDER_QTY  ");
            //strSQL.Append(" AND (JO.SCH_FIX_FLAG = 0 OR JO.SCH_FIX_FLAG = 1 AND JO.JOB_ORDER_COMPL_QTY > 0)      "); // JO.SCH_FIX_FLAG = 1はWIP
            strSQL.Append(" AND JO.SCH_FIX_FLAG = 0 "); // 完成品受入情報入力(RM) のみ 2015.09.25 JO.SCH_FIX_FLAG = 1はWIP

            db.DbParametersClear();

            if (_ws_cd != "")
            {
                strSQL.Append("   AND JO.WS_CD        =@WS_CD");
                db.DbPsetString("@WS_CD", _ws_cd);
            }
            if (_item_no != "")
            {
                strSQL.Append("   AND JO.ITEM_NO        =@ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_rcv_no != "")
            {
                strSQL.Append("   AND JO.RCV_NO        =@RCV_NO");
                db.DbPsetString("@RCV_NO", _rcv_no);
            }
            if (_slip_note != "")
            {
                strSQL.Append("   AND JO.SLIP_NOTE        =@SLIP_NOTE");
                db.DbPsetString("@SLIP_NOTE", _slip_note);
            }

            strSQL.Append(" ORDER BY   JO.JOB_ORDER_NO");

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
        /// 完成品FGラベル対象情報の取得
        /// <para>使用画面：MfgFGLabel</para>
        /// </summary>
        public DataSet Get_Mfg_FGLabelList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                      ");
            strSQL.Append(" JO.RCV_NO,         JO.RCV_LINE_NO,	        JO.JOB_ORDER_NO,	        ");
            strSQL.Append(" JO.ITEM_NO,        JO.ITEM_DESC,		    ");
            strSQL.Append(" JO.WS_CD,          V.WS_DESC,  CASE JO.SCH_FIX_FLAG WHEN 0 THEN JO.JOB_ORDER_QTY ELSE JO.JOB_ORDER_COMPL_QTY END JOB_ORDER_QTY , ");    // 2015.08.14
            strSQL.Append(" JO.ORDER_UMSR,     JO.SLIP_NOTE,            ");
            strSQL.Append(" JO.WHS_CD,         W.WHS_DESC,              ");
            strSQL.Append(" S1.DATA_CHAR AS UMSR_NAME, JO.SCH_FIX_FLAG,	     ");
            strSQL.Append(" COALESCE(TR.LABEL_QTY,1) LABEL_QTY ");

            strSQL.Append(" FROM JOB_ORDER JO                                                                            ");
            strSQL.Append(" LEFT JOIN WORKSHOP_MASTER V ON JO.WS_CD=V.WS_CD                                              ");
            strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER W ON JO.WHS_CD=W.WHS_CD                                           ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON    S1.KEY01='ITEM_UMSR'  AND      JO.ORDER_UMSR = S1.KEY02 ");
            strSQL.Append(" LEFT JOIN ( ");
            strSQL.Append(" SELECT SLIP_NO, COALESCE(SUM(CONVERT(INT, APPROVE_USER_ID)),1) LABEL_QTY FROM TRANSFER_TRANS   ");
            strSQL.Append(" WHERE REQ_TYPE='12' AND XFER_STATUS < 90 GROUP BY SLIP_NO ");
            strSQL.Append(" ) TR ON JO.JOB_ORDER_NO=TR.SLIP_NO ");
            strSQL.Append(" WHERE  JO.ORDER_STATUS >= 10                                                                 ");
            strSQL.Append(" AND JO.ORDER_STATUS <=85 ");
            strSQL.Append(" AND JO.SCH_FIX_FLAG = 1 "); // WIP製造実績のみ 2015.09.25 JO.SCH_FIX_FLAG = 1はWIP
            strSQL.Append(" AND JO.JOB_ORDER_COMPL_QTY > 0 "); // 

            db.DbParametersClear();

            if (_ws_cd != "")
            {
                strSQL.Append("   AND JO.WS_CD        =@WS_CD");
                db.DbPsetString("@WS_CD", _ws_cd);
            }
            if (_item_no != "")
            {
                strSQL.Append("   AND JO.ITEM_NO        =@ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_rcv_no != "")
            {
                strSQL.Append("   AND JO.RCV_NO        =@RCV_NO");
                db.DbPsetString("@RCV_NO", _rcv_no);
            }
            if (_slip_note != "")
            {
                strSQL.Append("   AND JO.SLIP_NOTE        =@SLIP_NOTE");
                db.DbPsetString("@SLIP_NOTE", _slip_note);
            }
            if (_job_order_no != "")
            {
                strSQL.Append("   AND JO.JOB_ORDER_NO        =@JOB_ORDER_NO");
                db.DbPsetString("@JOB_ORDER_NO", _job_order_no);    // 2015.11.04
            }

            strSQL.Append(" ORDER BY   JO.JOB_ORDER_NO");

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
        /// 完成品受入情報（明細）の取得
        /// <para>使用画面：InvManWhsUpd</para>
        /// </summary>
        public DataSet Get_Inv_ManWhsDetailList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                      ");
            strSQL.Append(" JO.RCV_NO,         JO.RCV_LINE_NO,	        JO.JOB_ORDER_NO,");
            strSQL.Append(" JO.ITEM_NO,        JO.ITEM_DESC,		    ");
            strSQL.Append(" JO.WS_CD,          V.WS_DESC,               JO.JOB_ORDER_QTY,             ");
            strSQL.Append(" JO.ORDER_UMSR,     JO.SLIP_NOTE,            ");
            strSQL.Append(" JO.WHS_CD,         W.WHS_DESC,              ");
            strSQL.Append(" S1.DATA_CHAR AS UMSR_NAME, 'EXIST' MARK     ");
            strSQL.Append(" ,I.DATA_NUM1 IDTAG_UNIT_QTY                 ");

            strSQL.Append(" FROM JOB_ORDER JO                                                                            ");
            strSQL.Append(" LEFT JOIN WORKSHOP_MASTER V ON JO.WS_CD=V.WS_CD                                              ");
            strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER W ON JO.WHS_CD=W.WHS_CD                                           ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON    S1.KEY01='ITEM_UMSR'  AND      JO.ORDER_UMSR = S1.KEY02    ");
            strSQL.Append(" LEFT JOIN ITEM_MASTER I ON JO.ITEM_NO=I.ITEM_NO                                              ");
            strSQL.Append(" WHERE  JO.ORDER_STATUS >= 10                                                                 ");
            strSQL.Append(" AND JO.ORDER_STATUS <=85                                                                      ");
            strSQL.Append(" AND JO.SCH_FIX_FLAG =0            ");    // IMV3 WIP分(SCH_FIX_FLAG=1)を除く

            db.DbParametersClear();

            strSQL.Append("   AND JO.RCV_NO        =@RCV_NO");
            db.DbPsetString("@RCV_NO", _rcv_no);

            strSQL.Append(" ORDER BY   JO.RCV_LINE_NO");

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
        /// 完成品受入情報（ラベル）の取得
        /// <para>使用画面：InvManWhsUpd</para>
        /// </summary>
        public DataSet Get_Inv_ManWhsLabelList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                  ");
            strSQL.Append(" JO.ITEM_NO,        JO.ITEM_DESC,	        JO.WHS_CD,  ");
            strSQL.Append(" W.WHS_DESC,        TR.INST_QTY ACT_QTY,		            ");
            strSQL.Append(" S1.DATA_CHAR AS ITEM_UMSR_NAME,                         ");
            strSQL.Append(" TR.TO_LOT_NO LOT_NO, TR.TO_LOCATION LOCATION, TR.SLIP_DATE, ");
            strSQL.Append(" TR.CMPL_INPUT_PRC, TR.CMPL_INPUT_AMT, TR.APPROVE_USER_ID, I.DATA_NUM1 IDTAG_UNIT_QTY ");

            strSQL.Append(" FROM JOB_ORDER JO                                                         ");
            strSQL.Append(" INNER JOIN TRANSFER_TRANS TR ON JO.JOB_ORDER_NO=TR.SLIP_NO                ");
            strSQL.Append(" AND TR.REQ_TYPE='12' AND TR.XFER_STATUS < 90                                            ");
            //strSQL.Append(" LEFT JOIN WORKSHOP_MASTER V ON JO.WS_CD=V.WS_CD                                              ");
            strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER W ON JO.WHS_CD=W.WHS_CD                                           ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON    S1.KEY01='ITEM_UMSR'  AND      JO.ORDER_UMSR = S1.KEY02    ");
            strSQL.Append(" LEFT JOIN ITEM_MASTER I ON JO.ITEM_NO=I.ITEM_NO                                              ");
            strSQL.Append(" WHERE  JO.ORDER_STATUS <=85                                                                      ");

            db.DbParametersClear();

            strSQL.Append("   AND JO.JOB_ORDER_NO        =@JOB_ORDER_NO");
            db.DbPsetString("@JOB_ORDER_NO", _job_order_no);

            strSQL.Append(" ORDER BY   TR.XFER_NO");

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
        /// 完成品受入情報（ラベル）の取得（受入番号一括）
        /// <para>使用画面：InvManWhs</para>
        /// </summary>
        public DataSet Get_Inv_ManWhsLabelList2()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                  ");
            strSQL.Append(" JO.RCV_NO,         JO.RCV_LINE_NO,	        JO.JOB_ORDER_NO,  ");
            strSQL.Append(" JO.ITEM_NO,        JO.ITEM_DESC,	        JO.WHS_CD,  ");
            strSQL.Append(" W.WHS_DESC,        TR.INST_QTY ACT_QTY,		            ");
            strSQL.Append(" S1.DATA_CHAR AS ITEM_UMSR_NAME,                         ");
            strSQL.Append(" TR.TO_LOT_NO LOT_NO, TR.TO_LOCATION LOCATION, TR.SLIP_DATE, ");
            strSQL.Append(" TR.CMPL_INPUT_PRC, TR.CMPL_INPUT_AMT, TR.APPROVE_USER_ID, I.DATA_NUM1 IDTAG_UNIT_QTY ");

            strSQL.Append(" FROM JOB_ORDER JO                                                         ");
            strSQL.Append(" INNER JOIN TRANSFER_TRANS TR ON JO.JOB_ORDER_NO=TR.SLIP_NO                ");
            strSQL.Append(" AND TR.REQ_TYPE='12' AND TR.XFER_STATUS < 90                                            ");
            //strSQL.Append(" LEFT JOIN WORKSHOP_MASTER V ON JO.WS_CD=V.WS_CD                                              ");
            strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER W ON JO.WHS_CD=W.WHS_CD                                           ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S1 ON    S1.KEY01='ITEM_UMSR'  AND      JO.ORDER_UMSR = S1.KEY02    ");
            strSQL.Append(" LEFT JOIN ITEM_MASTER I ON JO.ITEM_NO=I.ITEM_NO                                              ");
            strSQL.Append(" WHERE  JO.ORDER_STATUS <=85                                                                      ");

            db.DbParametersClear();

            strSQL.Append("   AND JO.RCV_NO        =@RCV_NO");
            db.DbPsetString("@RCV_NO", _rcv_no);

            strSQL.Append(" ORDER BY JO.JOB_ORDER_NO,  TR.XFER_NO");

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
