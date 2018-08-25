﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Data;

namespace IMClass
{
    public class Mrp
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Mrp()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Mrp(string p_user_id, int p_lang)
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
        protected string _whs_cd = "";
        protected string _job_order_no = "";
        protected string _vendor_name = "";
        protected double _job_order_qty = 0;
        protected int _sch_compl_date = 0;
        protected int _suggested_due_date = 0;
        protected int _num_of_days = 0;
        protected int _qty = 0;
        protected string _buyer_cd = "";
        protected string _sch_id = "";
        protected int _count1 = 0;
        protected int _count2 = 0;
        protected int _count3 = 0;
        protected int _count4 = 0;
        protected int _count5 = 0;
        protected int _count6 = 0;
        protected int _alarm_type = 0;
        protected int _alarm_type2 = 0;

        protected int _logymd = 0;
        protected int _logymd2 = 0;
        protected int _loghms = 0;
        protected int _loghms2 = 0;

        protected string _section_id = "";
        protected int _seqno = 0;

        protected string _joc_cd = "";

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

        protected string _dept_cd = "*";
        protected string _dept_name = "";
        protected int _count = 0;
        //-->ADD UBIQ-LIU 20100519
        protected int _count7 = 0;
        protected int _proc_type = 0;
        protected string _proc_id = "";  
        //<--ADD END
        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        public int lang { get { return _lang; } set { _lang = value; } }
        public string item_no { get { return _item_no; } set { _item_no = value; } }
        public string item_desc { get { return _item_desc; } set { _item_desc = value; } }
        public string whs_cd { get { return _whs_cd; } set { _whs_cd = value; } }
        public string job_order_no { get { return _job_order_no; } set { _job_order_no = value; } }
        public string vendor_name { get { return _vendor_name; } set { _vendor_name = value; } }
        public double job_order_qty { get { return _job_order_qty; } set { _job_order_qty = value; } }
        public int sch_compl_date { get { return _sch_compl_date; } set { _sch_compl_date = value; } }
        public int suggested_due_date { get { return _suggested_due_date; } set { _suggested_due_date = value; } }
        public int num_of_days { get { return _num_of_days; } set { _num_of_days = value; } }
        public int qty { get { return _qty; } set { _qty = value; } }
        public string buyer_cd { get { return _buyer_cd; } set { _buyer_cd = value; } }
        public string sch_id { get { return _sch_id; } set { _sch_id = value; } }
        public string joc_cd { get { return _joc_cd; } set { _joc_cd = value; } }

        /// <summary>
        /// 緊急	件数
        /// </summary>
        public int count1 { get { return _count1; } set { _count1 = value; } }
        /// <summary>
        ///前倒し件数
        /// </summary>
        public int count2 { get { return _count2; } set { _count2 = value; } }
        /// <summary>
        /// 後ろ倒し件数
        /// </summary>
        public int count3 { get { return _count3; } set { _count3 = value; } }
        /// <summary>
        /// キャンセル件数の合計

        /// </summary>
        public int count4 { get { return _count4; } set { _count4 = value; } }
        /// <summary>
        /// 余剰在庫件数の合計

        /// </summary>
        public int count5 { get { return _count5; } set { _count5 = value; } }
        /// <summary>
        /// 在庫不足			
        /// </summary>
        public int count6 { get { return _count6; } set { _count6 = value; } }
        /// <summary>
        /// 出荷ｱﾗｰﾑ件数			
        /// </summary>
        public int count7 { get { return _count7; } set { _count7 = value; } }

        public int logymd { get { return _logymd; } set { _logymd = value; } }
        public int logymd2 { get { return _logymd2; } set { _logymd2 = value; } }
        public int loghms { get { return _loghms; } set { _loghms = value; } }
        public int loghms2 { get { return _loghms2; } set { _loghms2 = value; } }
        public string section_id { get { return _section_id; } set { _section_id = value; } }
        public int seqno { get { return _seqno; } set { _seqno = value; } }

        public int alarm_type { get { return _alarm_type; } set { _alarm_type = value; } }
        public int alarm_type2 { get { return _alarm_type2; } set { _alarm_type2 = value; } }
        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }

        /// <summary>
        /// 部署コード

        /// </summary>
        public string dept_cd { get { return _dept_cd; } set { _dept_cd = value; } }
        /// <summary>
        /// 部署名称
        /// </summary>
        public string dept_name { get { return _dept_name; } set { _dept_name = value; } }
        /// <summary>
        /// 部署毎のｱﾗｰﾑ件数
        /// </summary>
        public int count { get { return _count; } set { _count = value; } }

        /// <summary>
        /// 機能区分

        /// <para>0:MRP計算実行</para>
        /// <para>1:スケジュール受信処理</para>
        /// </summary>
        public int proc_type { get { return _proc_type; } set { _proc_type = value; } }
        public string proc_id { get { return _proc_id; } set { _proc_id = value; } }
        #endregion

        /// <summary>
        /// アラーム件数を表示
        /// 
        /// 使用画面：MrpAlmInq
        /// </summary>
        public int GetAlarmCount()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT                                                           ");
            strSQL.Append("COUNT1,			COUNT2,			    COUNT3,			    COUNT4,	");
            strSQL.Append("COUNT5,	        COUNT6,             COUNT7               	    ");//UPD BY UBIQ-LIU 2010/5/19
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM                                                            ");
                strSQL.Append(" (SELECT COUNT(*) COUNT1 FROM MRP_ALARM WHERE ALARM_TYPE = 1 AND ");
                strSQL.Append(" SCH_ID = :SCH_ID) C1,                                           ");
                strSQL.Append(" (SELECT COUNT(*) COUNT2 FROM MRP_ALARM WHERE ALARM_TYPE = 2 AND ");
                strSQL.Append(" SCH_ID = :SCH_ID) C2,                                           ");
                strSQL.Append(" (SELECT COUNT(*) COUNT3 FROM MRP_ALARM WHERE ALARM_TYPE = 8 AND ");
                strSQL.Append(" SCH_ID = :SCH_ID) C3,                                           ");
                strSQL.Append(" (SELECT COUNT(*) COUNT4 FROM MRP_ALARM WHERE ALARM_TYPE IN (3,6)");//UPD BY UBIQ-LIU 2010/5/19
                strSQL.Append(" AND SCH_ID = :SCH_ID) C4,                                       ");
                strSQL.Append(" (SELECT COUNT(*) COUNT5 FROM MRP_ALARM WHERE ALARM_TYPE IN (4,7)");//UPD BY UBIQ-LIU 2010/5/19
                strSQL.Append(" AND SCH_ID = :SCH_ID) C5,                                       ");
                strSQL.Append(" (SELECT COUNT(*) COUNT6 FROM MRP_ALARM WHERE ALARM_TYPE = 5 AND ");
                strSQL.Append(" SCH_ID = :SCH_ID) C6,                                           ");
                strSQL.Append(" (SELECT COUNT(*) COUNT7 FROM MRP_ALARM WHERE ALARM_TYPE = 9 AND ");//ADD BY UBIQ-LIU 2010/5/19
                strSQL.Append(" SCH_ID = :SCH_ID) C7                                            ");

                db.DbParametersClear();
                db.DbPsetString("SCH_ID", _sch_id);
            }
            else
            {
                strSQL.Append(" FROM                                                            ");
                strSQL.Append(" (SELECT COUNT(*) COUNT1 FROM MRP_ALARM WHERE ALARM_TYPE = 1 AND ");
                strSQL.Append(" SCH_ID = @SCH_ID) C1,                                           ");
                strSQL.Append(" (SELECT COUNT(*) COUNT2 FROM MRP_ALARM WHERE ALARM_TYPE = 2 AND ");
                strSQL.Append(" SCH_ID = @SCH_ID) C2,                                           ");
                strSQL.Append(" (SELECT COUNT(*) COUNT3 FROM MRP_ALARM WHERE ALARM_TYPE = 8 AND ");
                strSQL.Append(" SCH_ID = @SCH_ID) C3,                                           ");
                strSQL.Append(" (SELECT COUNT(*) COUNT4 FROM MRP_ALARM WHERE ALARM_TYPE IN (3,6)");//UPD BY UBIQ-LIU 2010/5/19
                strSQL.Append(" AND SCH_ID = @SCH_ID) C4,                                       ");
                strSQL.Append(" (SELECT COUNT(*) COUNT5 FROM MRP_ALARM WHERE ALARM_TYPE IN (4,7)");//UPD BY UBIQ-LIU 2010/5/19
                strSQL.Append(" AND SCH_ID = @SCH_ID) C5,                                       ");
                strSQL.Append(" (SELECT COUNT(*) COUNT6 FROM MRP_ALARM WHERE ALARM_TYPE = 5 AND ");
                strSQL.Append(" SCH_ID = @SCH_ID) C6,                                           ");
                strSQL.Append(" (SELECT COUNT(*) COUNT7 FROM MRP_ALARM WHERE ALARM_TYPE = 9 AND ");//ADD BY UBIQ-LIU 2010/5/19
                strSQL.Append(" SCH_ID = @SCH_ID) C7                                            ");

                db.DbParametersClear();
                db.DbPsetString("@SCH_ID", _sch_id);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _count1 = int.Parse(db.Row("COUNT1"));
                _count2 = int.Parse(db.Row("COUNT2"));
                _count3 = int.Parse(db.Row("COUNT3"));
                _count4 = int.Parse(db.Row("COUNT4"));
                _count5 = int.Parse(db.Row("COUNT5"));
                _count6 = int.Parse(db.Row("COUNT6"));
                _count7 = int.Parse(db.Row("COUNT7"));//ADD BY UBIQ-LIU 2010/5/19
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// MRPアラームの明細を検索
        /// 
        /// 使用画面：MrpAlmInq
        /// </summary>
        public DataSet GetAlarmList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                  ");
            strSQL.Append(" MA.ITEM_NO,         I.ITEM_DESC,        MA.WHS_CD,                      ");
            strSQL.Append(" MA.NUM_OF_DAYS,	    MA.QTY,             VM.VENDOR_NAME,	                ");
            strSQL.Append(" MA.SUGGESTED_DUE_DATE,  ISNULL(PO.SCH_COMPL_DATE,0) SCH_COMPL_DATE,     ");
            strSQL.Append(" PO.BUYER_CD,	    S.DATA_CHAR BUYER_DESC,                             ");
            if (_alarm_type != 1)
            {
                strSQL.Append("PO.JOB_ORDER_NO,    PO.JOB_ORDER_QTY               ");
            }
            else
            {
                strSQL.Append("'' JOB_ORDER_NO,    PO.PO_QTY JOB_ORDER_QTY        ");
            }
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM  MRP_ALARM MA,PUR_ORDER PO,VERDOR_MASTER VM,ITEM_MASTER I  ");
                strSQL.Append(" WHERE MA.ITEM_NO    = I.ITEM_NO                                 ");
                strSQL.Append(" AND MA.ORDER_NO     = PO.ORDER_NO(+)                            ");
                strSQL.Append(" AND PO.VENDOR_CD    = VM.VENDOR_CD(+)                           ");
                strSQL.Append(" AND MA.SCH_ID       = :SCH_ID                                   ");
                strSQL.Append(" AND MA.ALARM_TYPE   = :ALARM_TYPE                               ");

                db.DbParametersClear();
                if (_alarm_type2 != 0)
                {
                    strSQL.Append(" AND MA.ALARM_TYPE IN (:ALARM_TYPE,:ALARM_TYPE2)                 ");
                    db.DbPsetInt("ALARM_TYPE2", _alarm_type2);
                }
                else
                {
                    strSQL.Append(" AND MA.ALARM_TYPE   = @ALARM_TYPE                               ");
                }
                db.DbPsetString("SCH_ID", _sch_id);
                db.DbPsetInt("ALARM_TYPE", _alarm_type);
            }
            else
            {
                strSQL.Append(" FROM  MRP_ALARM MA                                                  ");
                strSQL.Append(" INNER JOIN ITEM_MASTER I ON MA.ITEM_NO = I.ITEM_NO                  ");
                if (_alarm_type != 1)
                {
                    strSQL.Append(" LEFT OUTER JOIN PUR_ORDER PO ON MA.ORDER_NO = PO.ORDER_NO       ");
                }
                else
                {
                    strSQL.Append(" LEFT OUTER JOIN PLANNED_ORDER PO ON MA.ORDER_NO = PO.ORDER_NO   ");
                }
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER VM ON PO.VENDOR_CD = VM.VENDOR_CD     ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'BUYER_CD' AND      ");
                strSQL.Append(" S.KEY02 = PO.BUYER_CD                                               ");
                strSQL.Append(" WHERE MA.SCH_ID     = @SCH_ID                                       ");
                db.DbParametersClear();
                if (_alarm_type2 != 0)
                {
                    strSQL.Append(" AND MA.ALARM_TYPE IN (@ALARM_TYPE,@ALARM_TYPE2)                 ");
                    db.DbPsetInt("@ALARM_TYPE2", _alarm_type2);
                }
                else
                {
                    strSQL.Append(" AND MA.ALARM_TYPE   = @ALARM_TYPE                               ");
                }
                db.DbPsetString("@SCH_ID", _sch_id);
                db.DbPsetInt("@ALARM_TYPE", _alarm_type);
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
        /// MRPログを検索する
        /// 
        /// <para>使用画面：[MrpExce][ASRcv]</para>
        /// </summary>
        public DataSet GetLogList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                              ");
            strSQL.Append(" LOGYMD,      LOGHMS,        MSG_CD,      MSG_DESC1,	");
            strSQL.Append(" MSG_DESC2,	 MSG_DESC3,     SEQNO                   ");
            strSQL.Append(" FROM  MRP_LOG                                       ");
            if (_db_type == "ORACLE")
            {
                switch (proc_type)//Update UBIQ-LIU 2010/05/19
                {
                    case 0:
                        {
                            strSQL.Append(" WHERE SCH_ID        = :SCH_ID      ");
                            //strSQL.Append(" AND LOGYMD          = :LOGYMD      ");
                            //strSQL.Append(" AND LOGHMS          = :LOGHMS      ");

                            db.DbParametersClear();
                            db.DbPsetString("SCH_ID", _sch_id);
                            //db.DbPsetInt("LOGYMD", _logymd);
                            //db.DbPsetInt("LOGHMS", _loghms);
                        }
                        break;
                    case 1:
                        {
                            strSQL.Append(" WHERE PROC_ID        = :PROC_ID     ");
                            strSQL.Append(" ORDER BY SEQNO                      ");
                            db.DbParametersClear();
                            db.DbPsetString("PROC_ID", _proc_id);
                        }
                        break;
                }

            }
            else
            {
                switch (proc_type)//Update UBIQ-LIU 2010/05/19
                {
                    case 0:
                        {
                            strSQL.Append(" WHERE SCH_ID        = @SCH_ID      ");
                            //strSQL.Append(" AND LOGYMD          = @LOGYMD      ");
                            //strSQL.Append(" AND LOGHMS          = @LOGHMS      ");

                            db.DbParametersClear();
                            db.DbPsetString("@SCH_ID", _sch_id);
                            //db.DbPsetInt("@LOGYMD", _logymd);
                            //db.DbPsetInt("@LOGHMS", _loghms);  
                        }
                        break;
                    case 1:
                        {
                            strSQL.Append(" WHERE PROC_ID        = @PROC_ID     ");
                            strSQL.Append(" ORDER BY SEQNO                      ");
                            db.DbParametersClear();
                            db.DbPsetString("@PROC_ID", _proc_id);
                        }
                        break;
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

        /// <summary>
        /// 日付・時刻の編集

        /// 
        /// 
        /// 使用画面：MrpLogInq
        /// </summary>
        public DataSet GetLogDateList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT DISTINCT                         ");
            strSQL.Append("LOGYMD,      LOGHMS                     ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM  MRP_LOG                      ");
                strSQL.Append(" WHERE SCH_ID        = :SCH_ID      ");

                db.DbParametersClear();
                db.DbPsetString("SCH_ID", _sch_id);
            }
            else
            {
                strSQL.Append(" FROM  MRP_LOG                      ");
                strSQL.Append(" WHERE SCH_ID        = @SCH_ID      ");

                db.DbParametersClear();
                db.DbPsetString("@SCH_ID", _sch_id);
            }
            strSQL.Append(" ORDER BY LOGYMD DESC, LOGHMS DESC ");
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
        /// 在庫予定を検索
        /// 
        /// 使用画面：MrpSchInvInq
        /// </summary>
        public DataSet GetOrderQtyList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            if (_db_type == "ORACLE")
            {
                //・入庫予定



                strSQL.Append("SELECT                                                                   ");
                strSQL.Append("A.SCH_COMPL_DATE SCH_DATE,  A.ORDER_QTY, A.JOB_ORDER_NO,  A.VENDOR_CD,   ");
                strSQL.Append("A.JOC_CD,      M.ALARM_TYPE,     null  WS_CD, null WS_DESC,       null   PLAN_QTY ,   ");
                strSQL.Append("null PARENT_ITEM_NO,      null ITEM_DESC,     null  ORDER_QTY            ");
                strSQL.Append("FROM  (                                                                  ");
                strSQL.Append("SELECT                                                                   ");
                strSQL.Append(" SCH_COMPL_DATE,      ORDER_QTY,      Null JOB_ORDER_NO,      VENDOR_CD, ");
                strSQL.Append(" JOC_CD        ,      ORDER_NO                                           ");
                strSQL.Append(" FROM   PLANNED_ORDER                                                    ");
                strSQL.Append(" WHERE ITEM_NO        = :ITEM_NO                                         ");
                strSQL.Append(" AND WHS_CD        = :WHS_CD                                             "); //UPD BY UBIQ-SUO 2010/09/18

                strSQL.Append(" UNION                                                                   ");
                strSQL.Append("SELECT                                                                   ");
                strSQL.Append(" SCH_COMPL_DATE,    JOB_ORDER_QTY - JOB_ORDER_COMPL_QTY ORDER_QTY,       ");
                strSQL.Append(" JOB_ORDER_NO,      VENDOR_CD,       JOC_CD         ,ORDER_NO            ");
                strSQL.Append(" FROM   PUR_ORDER                                                        ");
                strSQL.Append(" WHERE ITEM_NO        = :ITEM_NO                                         ");
                strSQL.Append(" AND WHS_CD           = :WHS_CD                                          ");
                strSQL.Append(" AND ORDER_STATUS     <= 85                                              ");

                strSQL.Append(" UNION                                                                   ");
                strSQL.Append("SELECT                                                                   ");
                strSQL.Append(" SCH_COMPL_DATE,    JOB_ORDER_QTY - JOB_ORDER_COMPL_QTY ORDER_QTY,       ");
                strSQL.Append(" JOB_ORDER_NO,      WS_CD VENDOR_CD,       JOC_CD   ,ORDER_NO            ");
                strSQL.Append(" FROM   JOB_ORDER                                                        ");
                strSQL.Append(" WHERE ITEM_NO        = :ITEM_NO                                         ");
                strSQL.Append(" AND WHS_CD           = :WHS_CD                                          ");
                strSQL.Append(" AND ORDER_STATUS     <= 85                                              ");
                strSQL.Append(" ) A ,MRP_ALARM M                                                        ");
                strSQL.Append(" WHERE A.ORDER_NO = M.ORDER_NO(+)                                        ");
                strSQL.Append(" UNION                                                                   ");
                //・出庫予定


                strSQL.Append("SELECT                                                                   ");
                strSQL.Append("A.SCH_DISB_DATE SCH_DATE,null ORDER_QTY,null JOB_ORDER_NO,null VENDOR_CD,");
                strSQL.Append("A.JOC_CD        , null ALARM_TYPE ,  A.WHS_CD,    A.WS_CD, WS.WS_DESC,   A.PLAN_QTY ,"); //UPD BY UBIQ-SUO 2010/09/18  ADD A.WHS_CD
                strSQL.Append("A.PARENT_ITEM_NO        , A.ITEM_DESC ,      A.ORDER_QTY                 ");
                strSQL.Append("FROM  (                                                                  ");
                strSQL.Append("SELECT                                                                   ");
                strSQL.Append(" PD.SCH_DISB_DATE, PD.WHS_CD, PD.WS_CD,      PD.PLAN_QTY,      PD.JOC_CD,      "); //UPD BY UBIQ-SUO 2010/09/18  ADD PD.WHS_CD
                strSQL.Append(" PD.PARENT_ITEM_NO,     PO.ITEM_DESC,  PO.ORDER_QTY                      ");
                strSQL.Append(" FROM  PLANNED_DEMAND PD, PLANNED_ORDER PO                               ");
                strSQL.Append(" WHERE PD.ORDER_NO        = PO.ORDER_NO                                  ");
                strSQL.Append(" AND (PD.SUB_GRP_CD = '' OR (PD.SUB_GRP_CD <> '' AND PD.SUB_ACTION_FLAG = 1))  ");
                strSQL.Append(" AND PD.ITEM_TYPE <> '99'                            ");
                strSQL.Append(" AND PD.WHS_CD        = :WHS_CD                                          ");
                strSQL.Append(" AND PD.ITEM_NO        = :ITEM_NO                                        ");
                strSQL.Append(" UNION                                                                   ");
                strSQL.Append("SELECT                                                                   ");
                strSQL.Append(" D.SCH_DISB_DATE,  D.WHS_CD,  D.WS_CD,      D.PLAN_QTY-D.ACT_DISB_QTY PLAN_QTY,   "); //UPD BY UBIQ-SUO 2010/09/18  ADD D.WHS_CD
                strSQL.Append(" D.JOC_CD,           D.PARENT_ITEM_NO,    JO.ITEM_DESC,  JO.ORDER_QTY    ");
                strSQL.Append(" FROM  DEMAND D, JOB_ORDER JO                                            ");
                strSQL.Append(" WHERE D.ORDER_NO        = JO.ORDER_NO                                   ");
                strSQL.Append(" AND (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))  ");
                strSQL.Append(" AND D.ITEM_TYPE <> '99'                            ");
                strSQL.Append(" AND D.DEMAND_STATUS     <= 30                                           ");
                strSQL.Append(" AND D.WHS_CD        = :WHS_CD                                           ");
                strSQL.Append(" AND D.ITEM_NO        = :ITEM_NO                                         ");
                strSQL.Append(" ) A ,   WORKSHOP_MASTER                                                 ");
                strSQL.Append(" WHERE  A.WS_CD = WS.WS_CD                                               ");

                db.DbParametersClear();
                db.DbPsetString("WHS_CD", _whs_cd);
                db.DbPsetString("ITEM_NO", _item_no);
            }
            else
            {
                //・入庫予定

                strSQL.Append("SELECT  0 AS TYPE,                                                       ");
                strSQL.Append("A.SCH_COMPL_DATE SCH_DATE,  A.ORDER_QTY, A.JOB_ORDER_NO,  A.VENDOR_CD,   ");
                strSQL.Append("A.JOC_CD,      M.ALARM_TYPE,    null WHS_CD, null  WS_CD,  null WS_DESC,      null   PLAN_QTY ,   "); //UPD BY UBIQ-SUO 2010/09/18  ADD null WHS_CD
                strSQL.Append("null PARENT_ITEM_NO,      null ITEM_DESC,     null  PARENT_ORDER_QTY     ");
                strSQL.Append(",V.VENDOR_NAME                                                           ");
                strSQL.Append("FROM  (                                                                  ");
                strSQL.Append("SELECT                                                                   ");
                strSQL.Append(" SCH_COMPL_DATE,      ORDER_QTY,      Null JOB_ORDER_NO,      VENDOR_CD, ");
                strSQL.Append(" JOC_CD        ,      ORDER_NO                                           ");
                strSQL.Append(" FROM   PLANNED_ORDER                                                    ");
                strSQL.Append(" WHERE ITEM_NO        = @ITEM_NO                                         ");
                strSQL.Append(" AND MRP_WHS_GRP        = @WHS_CD                                        "); //UPD BY UBIQ-SUO 2010/09/18 WHS_CD => MRP_WHS_GRP

                //strSQL.Append(" UNION                                                                   ");   //Del 2012.09.28 Ubiq-Sai
                strSQL.Append(" UNION ALL                                                               ");     //Add 2012.09.28 Ubiq-Sai
                strSQL.Append("SELECT                                                                   ");
                strSQL.Append(" SCH_COMPL_DATE,    JOB_ORDER_QTY - STOCK_QTY ORDER_QTY,                 ");
                strSQL.Append(" JOB_ORDER_NO,      VENDOR_CD,       JOC_CD         ,ORDER_NO            ");
                strSQL.Append(" FROM   PUR_ORDER                                                        ");
                strSQL.Append(" WHERE ITEM_NO        = @ITEM_NO                                         ");
                strSQL.Append(" AND MRP_WHS_GRP      = @WHS_CD                                          "); //UPD BY UBIQ-SUO 2010/09/18 WHS_CD => MRP_WHS_GRP
                strSQL.Append(" AND JOB_ORDER_QTY - STOCK_QTY   > 0                                     ");
                strSQL.Append(" AND ORDER_STATUS     < 77                                               ");
                //検収済未入庫
                //strSQL.Append(" UNION                                                         			"); //Del 2012.09.28 Ubiq-Sai
                strSQL.Append(" UNION ALL                                                               ");     //Add 2012.09.28 Ubiq-Sai
                strSQL.Append(" SELECT                                                         			");
                strSQL.Append(" 	 PO.SCH_COMPL_DATE,    TR.ORDER_QTY,       							");
                strSQL.Append(" 	 PO.JOB_ORDER_NO,      PO.VENDOR_CD,       PO.JOC_CD   ,PO.ORDER_NO ");
                strSQL.Append(" FROM PUR_ORDER PO														");
                strSQL.Append(" INNER JOIN                                                				");
                strSQL.Append(" (SELECT ORDER_NO, ISNULL(SUM(INST_QTY), 0) ORDER_QTY					");
                strSQL.Append("    FROM TRANSFER_TRANS													");
                strSQL.Append("   WHERE REQ_TYPE = '11' 												");
                strSQL.Append("     AND XFER_STATUS < 20												");
                strSQL.Append("     AND ORDER_NO IN ( SELECT ORDER_NO 									");
                strSQL.Append(" 					    FROM PUR_ORDER									");
                strSQL.Append(" 					   WHERE ITEM_NO  = @ITEM_NO						");
                strSQL.Append(" 					     AND MRP_WHS_GRP   = @WHS_CD					"); //UPD BY UBIQ-SUO 2010/09/18 WHS_CD => MRP_WHS_GRP
                strSQL.Append(" 					     AND (ORDER_STATUS = 77 OR ORDER_STATUS = 85) )	");
                strSQL.Append("  GROUP BY ORDER_NO ) TR													");
                strSQL.Append(" ON PO.ORDER_NO = TR.ORDER_NO											");
                strSQL.Append(" WHERE TR.ORDER_QTY > 0      											");

                //strSQL.Append(" UNION                                                                   ");   //Del 2012.09.28 Ubiq-Sai
                strSQL.Append(" UNION ALL                                                               ");     //Add 2012.09.28 Ubiq-Sai
                strSQL.Append("SELECT                                                                   ");
                strSQL.Append(" SCH_COMPL_DATE,    JOB_ORDER_QTY - STOCK_QTY ORDER_QTY,                 ");
                strSQL.Append(" JOB_ORDER_NO,      WS_CD VENDOR_CD,       JOC_CD   ,ORDER_NO            ");
                strSQL.Append(" FROM   JOB_ORDER                                                        ");
                strSQL.Append(" WHERE ITEM_NO        = @ITEM_NO                                         ");
                strSQL.Append(" AND MRP_WHS_GRP           = @WHS_CD                                     "); //UPD BY UBIQ-SUO 2010/09/18 WHS_CD => MRP_WHS_GRP
                strSQL.Append(" AND JOB_ORDER_QTY - STOCK_QTY   > 0                                     ");
                strSQL.Append(" AND ORDER_STATUS     < 85                                               ");
                //完成済未入庫
                //strSQL.Append(" UNION                                                         		  ");   //Del 2012.09.28 Ubiq-Sai
                strSQL.Append(" UNION ALL                                                               ");     //Add 2012.09.28 Ubiq-Sai
                strSQL.Append(" SELECT                                                         					");
                strSQL.Append(" 	 JO.SCH_COMPL_DATE,    TR.ORDER_QTY,                                        ");
                strSQL.Append(" 	 JO.JOB_ORDER_NO,      JO.WS_CD VENDOR_CD,       JO.JOC_CD   ,JO.ORDER_NO   ");
                strSQL.Append("   FROM JOB_ORDER JO                                                             ");
                strSQL.Append(" INNER JOIN                                                                      ");
                strSQL.Append(" (SELECT ORDER_NO, ISNULL(SUM(INST_QTY), 0) ORDER_QTY                            ");
                strSQL.Append("    FROM TRANSFER_TRANS                                                          ");
                strSQL.Append("   WHERE REQ_TYPE = '12'                                                         ");
                strSQL.Append("     AND XFER_STATUS < 20                                                        ");
                strSQL.Append("     AND ORDER_NO IN ( SELECT ORDER_NO                                           ");
                strSQL.Append(" 					    FROM JOB_ORDER                                          ");
                strSQL.Append(" 					   WHERE ITEM_NO  = @ITEM_NO                                ");
                strSQL.Append(" 					     AND MRP_WHS_GRP   = @WHS_CD                            "); //UPD BY UBIQ-SUO 2010/09/18 WHS_CD => MRP_WHS_GRP
                strSQL.Append(" 					     AND ORDER_STATUS = 85 )                                ");
                strSQL.Append("  GROUP BY ORDER_NO ) TR                                                         ");
                strSQL.Append(" ON JO.ORDER_NO = TR.ORDER_NO                                                    ");
                strSQL.Append(" WHERE TR.ORDER_QTY > 0      											");

                strSQL.Append(" ) A                                                                     ");
                //strSQL.Append(" LEFT OUTER JOIN MRP_ALARM M ON A.ORDER_NO = M.ORDER_NO                ");   //Del 2012.05.10 Ubiq-Sai
                //Add 2012.05.10 Ubiq-Sai Start
                strSQL.Append(" LEFT OUTER JOIN (                                                       ");
                strSQL.Append("  SELECT ORDER_NO, MIN(ALARM_TYPE) ALARM_TYPE                            ");
                strSQL.Append("  FROM MRP_ALARM M                                                       ");
                strSQL.Append("  GROUP BY ORDER_NO ) M                                                  ");
                strSQL.Append(" ON A.ORDER_NO = M.ORDER_NO                                              ");
                //Add 2012.05.10 Ubiq-Sai End

                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON V.VENDOR_CD = A.VENDOR_CD            ");

                //strSQL.Append(" UNION                                                                   ");   //Del 2012.09.28 Ubiq-Sai
                strSQL.Append(" UNION ALL                                                               ");     //Add 2012.09.28 Ubiq-Sai
                //・出庫予定


                strSQL.Append("SELECT  1 AS TYPE,                                                       ");
                strSQL.Append("A.SCH_DISB_DATE SCH_DATE,null ORDER_QTY,null JOB_ORDER_NO,null VENDOR_CD,");
                strSQL.Append("A.JOC_CD        , null ALARM_TYPE ,   A.DISB_WHS WHS_CD,   A.WS_CD, WS.WS_DESC,   A.PLAN_QTY ,");//UPD BY UBIQ-SUO 2010/09/18  ADD A.WHS_CD
                strSQL.Append("A.PARENT_ITEM_NO        , A.ITEM_DESC ,     A.ORDER_QTY PARENT_ORDER_QTY ");
                strSQL.Append(",null VENDOR_NAME                                                        ");
                strSQL.Append(" FROM  (                                                                 ");
                strSQL.Append("SELECT                                                                   ");
                //strSQL.Append(" PD.SCH_DISB_DATE, PD.DISB_WHS,PD.WS_CD, CASE WHEN IM.WIP_TYPE = 1 THEN PD.PLAN_QTY ELSE (CASE WHEN PD.ALLOC_FLAG <> 0 THEN PD.PLAN_DISB_QTY + PD.ALLOC_QTY - PD.ACT_DISB_QTY ELSE PD.PLAN_QTY END) END PLAN_QTY,      PD.JOC_CD,      "); //UPD BY UBIQ-SUO 2010/09/18  ADD PD.DISB_WHS  UPD BY UBIQ-SAI WIP_TYPE = 0 -> WIP_TYPE = 1
                //!!!strSQL.Append(" PD.SCH_DISB_DATE, PD.DISB_WHS,CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN PD.WS_CD ELSE WS.REP_WS_CD END WS_CD, CASE WHEN IM.WIP_TYPE = 1 THEN PD.PLAN_QTY ELSE (CASE WHEN PD.ALLOC_FLAG <> 0 THEN PD.PLAN_DISB_QTY + PD.ALLOC_QTY - PD.ACT_DISB_QTY ELSE PD.PLAN_QTY END) END PLAN_QTY,      PD.JOC_CD,      "); // 2011.03.09
                strSQL.Append(" PD.SCH_DISB_DATE, PD.DISB_WHS,CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN PD.WS_CD ELSE WS.REP_WS_CD END WS_CD, CASE WHEN IM.WIP_TYPE = 0 THEN PD.PLAN_QTY ELSE (CASE WHEN PD.ALLOC_FLAG <> 0 THEN PD.PLAN_DISB_QTY + PD.ALLOC_QTY - PD.ACT_DISB_QTY ELSE PD.PLAN_QTY END) END PLAN_QTY,      PD.JOC_CD,      "); // 2011.12.26
                strSQL.Append(" PO.ITEM_NO PARENT_ITEM_NO,     PO.ITEM_DESC,  PO.ORDER_QTY              ");
                //strSQL.Append(" FROM  PLANNED_DEMAND PD, PLANNED_ORDER PO, ITEM_MASTER IM               ");
                strSQL.Append(" FROM  PLANNED_DEMAND PD                                                 "); // 2011.03.09
                strSQL.Append(" INNER JOIN PLANNED_ORDER PO ON PD.ORDER_NO        = PO.ORDER_NO         "); // 2011.03.09
                strSQL.Append(" INNER JOIN ITEM_MASTER IM ON PD.ITEM_NO         = IM.ITEM_NO            "); // 2011.03.09
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WS ON PD.WS_CD = WS.WS_CD                     "); // 2011.03.09
                //strSQL.Append(" WHERE PD.ORDER_NO        = PO.ORDER_NO                                  ");
                //strSQL.Append(" AND   PD.ITEM_NO         = IM.ITEM_NO                                    ");
                //strSQL.Append(" AND (PD.SUB_GRP_CD = '' OR (PD.SUB_GRP_CD <> '' AND PD.SUB_ACTION_FLAG = 1)) ");
                strSQL.Append(" WHERE (PD.SUB_GRP_CD = '' OR (PD.SUB_GRP_CD <> '' AND PD.SUB_ACTION_FLAG = 1)) "); // 2011.03.09
                strSQL.Append(" AND PD.ITEM_TYPE <> '99'                            ");
                strSQL.Append(" AND PD.MRP_WHS_GRP    = @WHS_CD                                        "); //UPD BY UBIQ-SUO 2010/09/18 DISB_WHS => MRP_WHS_GRP 
                strSQL.Append(" AND PD.ITEM_NO        = @ITEM_NO                                        ");
                strSQL.Append(" UNION ALL                                                               ");
                strSQL.Append("SELECT                                                                   ");
                //strSQL.Append(" D.SCH_DISB_DATE, D.DISB_WHS, D.WS_CD , CASE WHEN IM.WIP_TYPE = 1 THEN D.PLAN_QTY - D.INPUT_QTY ELSE D.PLAN_DISB_QTY + D.ALLOC_QTY - D.ACT_DISB_QTY END PLAN_QTY,          "); //UPD BY UBIQ-SUO 2010/09/18  ADD D.DISB_WHS  UPD BY UBIQ-SAI WIP_TYPE = 0 -> WIP_TYPE = 1
                //!!!strSQL.Append(" D.SCH_DISB_DATE, D.DISB_WHS, CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN D.WS_CD ELSE WS.REP_WS_CD END , CASE WHEN IM.WIP_TYPE = 1 THEN D.PLAN_QTY - D.INPUT_QTY ELSE D.PLAN_DISB_QTY + D.ALLOC_QTY - D.ACT_DISB_QTY END PLAN_QTY,          "); // 2011.03.09
                strSQL.Append(" D.SCH_DISB_DATE, D.DISB_WHS, CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN D.WS_CD ELSE WS.REP_WS_CD END , CASE WHEN IM.WIP_TYPE = 0 THEN D.PLAN_QTY - D.INPUT_QTY ELSE D.PLAN_DISB_QTY + D.ALLOC_QTY - D.ACT_DISB_QTY END PLAN_QTY,          "); // 2011.12.26
                strSQL.Append(" D.JOC_CD,           JO.ITEM_NO PARENT_ITEM_NO,    JO.ITEM_DESC,  JO.ORDER_QTY    ");
                //strSQL.Append(" FROM  DEMAND D, JOB_ORDER JO, ITEM_MASTER IM                                     ");
                strSQL.Append(" FROM  DEMAND D                                                 "); // 2011.03.09
                strSQL.Append(" INNER JOIN JOB_ORDER JO ON D.ORDER_NO        = JO.ORDER_NO         "); // 2011.03.09
                strSQL.Append(" INNER JOIN ITEM_MASTER IM ON D.ITEM_NO         = IM.ITEM_NO            "); // 2011.03.09
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WS ON D.WS_CD = WS.WS_CD                      "); // 2011.03.09
                //strSQL.Append(" WHERE D.ORDER_NO        = JO.ORDER_NO                                   ");
                //strSQL.Append(" AND   D.ITEM_NO         = IM.ITEM_NO                                    ");
                //strSQL.Append(" AND (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1)) ");
                strSQL.Append(" WHERE (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1)) "); // 2011.03.09
                strSQL.Append(" AND D.ITEM_TYPE <> '99'                            ");
                strSQL.Append(" AND D.DEMAND_STATUS     <= 30                                           ");
                strSQL.Append(" AND D.MRP_WHS_GRP    = @WHS_CD                                          ");  //UPD BY UBIQ-SUO 2010/09/18 DISB_WHS => MRP_WHS_GRP 
                strSQL.Append(" AND D.ITEM_NO        = @ITEM_NO                                         ");
                //strSQL.Append(" AND D.PLAN_DISB_QTY + D.ALLOC_QTY - D.ACT_DISB_QTY > 0                  ");
                strSQL.Append(" UNION ALL                                                               ");
                strSQL.Append("SELECT                                                                   ");
                //strSQL.Append(" D.SCH_DISB_DATE, D.DISB_WHS, D.WS_CD , CASE WHEN IM.WIP_TYPE = 1 THEN D.PLAN_QTY - D.INPUT_QTY ELSE D.PLAN_DISB_QTY + D.ALLOC_QTY - D.ACT_DISB_QTY END PLAN_QTY,          "); //UPD BY UBIQ-SUO 2010/09/18  ADD D.DISB_WHS  UPD BY UBIQ-SAI WIP_TYPE = 0 -> WIP_TYPE = 1
                //!!!strSQL.Append(" D.SCH_DISB_DATE, D.DISB_WHS, CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN D.WS_CD ELSE WS.REP_WS_CD END, CASE WHEN IM.WIP_TYPE = 1 THEN D.PLAN_QTY - D.INPUT_QTY ELSE D.PLAN_DISB_QTY + D.ALLOC_QTY - D.ACT_DISB_QTY END PLAN_QTY,          "); //2011.03.09 
                strSQL.Append(" D.SCH_DISB_DATE, D.DISB_WHS, CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN D.WS_CD ELSE WS.REP_WS_CD END, CASE WHEN IM.WIP_TYPE = 0 THEN D.PLAN_QTY - D.INPUT_QTY ELSE D.PLAN_DISB_QTY + D.ALLOC_QTY - D.ACT_DISB_QTY END PLAN_QTY,          "); //2011.12.26
                strSQL.Append(" D.JOC_CD,        PU.ITEM_NO PARENT_ITEM_NO,    PU.ITEM_DESC,  PU.ORDER_QTY    ");
                //strSQL.Append(" FROM  DEMAND D, PUR_ORDER PU, ITEM_MASTER IM                            ");
                strSQL.Append(" FROM  DEMAND D                                                 "); // 2011.03.09
                strSQL.Append(" INNER JOIN PUR_ORDER PU ON D.ORDER_NO        = PU.ORDER_NO         "); // 2011.03.09
                strSQL.Append(" INNER JOIN ITEM_MASTER IM ON D.ITEM_NO         = IM.ITEM_NO            "); // 2011.03.09
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WS ON D.WS_CD = WS.WS_CD                      "); // 2011.03.09
                //strSQL.Append(" WHERE D.ORDER_NO        = PU.ORDER_NO                                   ");
                //strSQL.Append(" AND   D.ITEM_NO         = IM.ITEM_NO                                    ");
                //strSQL.Append(" AND (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))  ");
                strSQL.Append(" WHERE (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))  "); // 2011.03.09
                strSQL.Append(" AND D.ITEM_TYPE <> '99'                                                 ");
                strSQL.Append(" AND D.DEMAND_STATUS     <= 30                                           ");
                strSQL.Append(" AND D.MRP_WHS_GRP    = @WHS_CD                                          "); //UPD BY UBIQ-SUO 2010/09/18 DISB_WHS => MRP_WHS_GRP 
                strSQL.Append(" AND D.ITEM_NO        = @ITEM_NO                                         ");
                
                //Add 10.09.02 Ubiq-Sai Start 
                strSQL.Append(" UNION ALL                                                               ");
                strSQL.Append("SELECT                                                                   ");
                //strSQL.Append(" D.SCH_DISB_DATE, D.DISB_WHS, D.WS_CD , D.PLAN_QTY - D.INPUT_QTY PLAN_QTY,   "); //UPD BY UBIQ-SUO 2010/09/18  ADD D.DISB_WHS
                strSQL.Append(" D.SCH_DISB_DATE, D.DISB_WHS, CASE WHEN COALESCE(WS.REP_WS_CD,'') = '' THEN D.WS_CD ELSE WS.REP_WS_CD END, D.PLAN_QTY - D.INPUT_QTY PLAN_QTY,   "); // 2011.03.09
                strSQL.Append(" D.JOC_CD,        S.ITEM_NO PARENT_ITEM_NO,    IM.ITEM_DESC,  S.ORDER_QTY    ");
                //strSQL.Append(" FROM  DEMAND D, SALES_ORDER_DETAIL S, ITEM_MASTER IM                    ");
                strSQL.Append(" FROM  DEMAND D                                                 "); // 2011.03.09
                strSQL.Append(" INNER JOIN SALES_ORDER_DETAIL S ON D.ORDER_NO        = S.ORDER_NO  AND   D.JOC_SPLIT_NO = S.ORDER_LINE_NO       "); // 2011.03.09
                strSQL.Append(" INNER JOIN ITEM_MASTER IM ON D.ITEM_NO         = IM.ITEM_NO            "); // 2011.03.09
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WS ON D.WS_CD = WS.WS_CD                      "); // 2011.03.09
                //strSQL.Append(" WHERE D.SO_NO        = S.ORDER_NO                                       ");
                //strSQL.Append(" AND   D.JOC_SPLIT_NO = S.ORDER_LINE_NO                                  ");
                //strSQL.Append(" AND   D.ITEM_NO         = IM.ITEM_NO                                    ");
                //strSQL.Append(" AND (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))  ");
                strSQL.Append(" WHERE (D.SUB_GRP_CD = '' OR (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))  "); // 2011.03.09
                strSQL.Append(" AND D.ITEM_TYPE <> '99'                                                 ");
                strSQL.Append(" AND D.DEMAND_STATUS     <= 30                                           ");
                strSQL.Append(" AND D.MRP_WHS_GRP    = @WHS_CD                                          "); //UPD BY UBIQ-SUO 2010/09/18 DISB_WHS => MRP_WHS_GRP 
                strSQL.Append(" AND D.ITEM_NO        = @ITEM_NO                                         ");
                //Add 10.09.02 Ubiq-Sai End

                //Add 10.10.08 Ubiq-Suo Start 
                strSQL.Append(" UNION ALL                                                               ");
                strSQL.Append("SELECT S.SHIP_REQ_DATE SCH_DISB_DATE, S.SHIP_WHS DISB_WHS, null WS_CD,   ");
                strSQL.Append("S.ORDER_QTY - S.ACTUAL_SHIP_QTY PLAN_QTY, S.JOC_CD, null PARENT_ITEM_NO, null ITEM_DESC, null ORDER_QTY");
                strSQL.Append(" FROM SALES_ORDER_DETAIL S                                               ");
                strSQL.Append(" WHERE S.SHIP_WHS    = @WHS_CD                                          ");
                strSQL.Append(" AND   S.ITEM_NO        = @ITEM_NO                                         ");
                //Add 10.10.08 Ubiq-Suo End

                //strSQL.Append(" AND D.PLAN_DISB_QTY + D.ALLOC_QTY - D.ACT_DISB_QTY > 0                  ");
                strSQL.Append(" ) A                                                                     ");
                //strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WS ON A.DISB_WHS = WS.WS_CD                      ");
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WS ON A.WS_CD = WS.WS_CD                      "); // 2011.03.09
                strSQL.Append(" WHERE A.PLAN_QTY > 0 ");

                db.DbParametersClear();
                db.DbPsetString("@WHS_CD", _whs_cd);
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            strSQL.Append(" ORDER BY 2, 1 ");
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
        /// 業務アラーム件数を表示
        /// 
        /// 使用画面：Menu
        /// </summary>
        public DataSet GetApllogDeptList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("S.DEPT_CD,			S.DEPT_NAME,			    COUNT(*) COUNT ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append("  FROM APL_LOG A,                                                ");

                strSQL.Append("(SELECT                                                          ");
                strSQL.Append(" S1.KEY02 MSG_CD, S1.DATA_CHAR2 DEPT_CD,  ");
                switch (_lang)
                {
                    case 2:
                        strSQL.Append(" S2.DATA_CHAR1 DEPT_NAME ");
                        break;

                    case 3:
                        strSQL.Append(" S2.DATA_CHAR2 DEPT_NAME ");
                        break;

                    case 4:
                        strSQL.Append(" S2.DATA_CHAR3 DEPT_NAME ");
                        break;

                    default:
                        strSQL.Append(" S2.DATA_CHAR DEPT_NAME ");
                        break;
                }
                strSQL.Append(" FROM SYSTEM_PARAMETER S1, SYSTEM_PARAMETER S2                   ");
                strSQL.Append(" WHERE S1.KEY01 = 'BUSINESS_ALARM'                               ");
                strSQL.Append(" AND S2.KEY01 = 'SECTION'                                        ");
                strSQL.Append(" AND S1.DATA_CHAR2 = S2.KEY02 ) S                                 ");

                strSQL.Append(" WHERE A.MSG_CD = S.MSG_CD                                       ");

                if (dept_cd != "")
                {
                    strSQL.Append("   AND S.DEPT_CD = :DEPT_CD                                  ");

                    db.DbParametersClear();
                    db.DbPsetString("DEPT_CD", _dept_cd);
                }
            }
            else
            {
                strSQL.Append(" FROM APL_LOG A                                                  ");
                strSQL.Append(" INNER JOIN                                                      ");

                strSQL.Append("(SELECT                                                          ");
                strSQL.Append(" S1.KEY02 MSG_CD, S1.DATA_CHAR2 DEPT_CD, ");
                switch (_lang)
                {
                    case 2:
                        strSQL.Append(" S2.DATA_CHAR2 DEPT_NAME ");
                        break;

                    case 3:
                        strSQL.Append(" S2.DATA_CHAR3 DEPT_NAME ");
                        break;

                    case 4:
                        strSQL.Append(" S2.DATA_CHAR4 DEPT_NAME ");
                        break;

                    default:
                        strSQL.Append(" S2.DATA_CHAR DEPT_NAME ");
                        break;
                }
                strSQL.Append(" FROM SYSTEM_PARAMETER S1                                        ");
                strSQL.Append(" INNER JOIN SYSTEM_PARAMETER S2                                  ");
                strSQL.Append(" ON  S1.KEY01 = 'BUSINESS_ALARM'                                 ");
                strSQL.Append(" AND S2.KEY01 = 'SECTION'                                        ");
                strSQL.Append(" AND S1.DATA_CHAR2 = S2.KEY02 ) S                                 ");

                strSQL.Append(" ON  A.MSG_CD = S.MSG_CD                                         ");

                if (dept_cd != "")
                {
                    strSQL.Append(" AND S.DEPT_CD = @DEPT_CD                                ");

                    db.DbParametersClear();
                    db.DbPsetString("@DEPT_CD", _dept_cd);
                }
            }
            strSQL.Append(" GROUP BY S.DEPT_CD, S.DEPT_NAME                                 ");

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
        /// 日付ドロップダウンの編集

        /// 
        /// 使用画面：BusinessAlarmInq
        /// </summary>
        public DataSet GetApl_LogDateList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT DISTINCT                                                                      ");
            strSQL.Append("LOGYMD,CONVERT(VARCHAR(10),CONVERT(DATETIME,CONVERT(VARCHAR(8),LOGYMD)),111) YMD     ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM  APL_LOG                           ");
                if (_section_id != "")
                {
                    strSQL.Append(" WHERE SCH_ID        = :SECTION_ID       ");

                    db.DbPsetString("SECTION_ID", _section_id);
                }
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM  APL_LOG                               ");
                if (_section_id != "")
                {
                    strSQL.Append(" WHERE SECTION_ID        = @SECTION_ID       ");

                    db.DbPsetString("@SECTION_ID", _section_id);
                }
            }
            strSQL.Append(" ORDER BY LOGYMD DESC");
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
        /// 時刻ドロップダウンの編集

        /// 
        /// 使用画面：BusinessAlarmInq
        /// </summary>
        public DataSet GetApl_LogTimeList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT DISTINCT                       ");
            strSQL.Append("LOGHMS                                ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM  APL_LOG                           ");
                if (_section_id != "")
                {
                    strSQL.Append(" WHERE SCH_ID        = :SECTION_ID       ");
                    db.DbPsetString("SECTION_ID", _section_id);
                }
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM  APL_LOG                               ");
                strSQL.Append(" WHERE LOGYMD        = @LOGYMD               ");
                if (_section_id != "")
                {
                    strSQL.Append(" AND SECTION_ID        = @SECTION_ID       ");
                    db.DbPsetString("@SECTION_ID", _section_id);
                }
                db.DbPsetInt("@LOGYMD", _logymd);
            }
            strSQL.Append(" ORDER BY LOGHMS DESC");
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
        /// 対応するAPLログの明細を検索する
        /// 
        /// 使用画面：BusinessAlarmInq
        /// </summary>
        public DataSet GetApl_LogList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                 ");
            strSQL.Append("SECTION_ID,      CHAR2,      CHAR3,      CHAR4,      CHAR5,      NUM1, ");
            //strSQL.Append("M.MSG_DESC,      LOGYMD,     LOGHMS,                                   ");
            strSQL.Append("COALESCE(M.MSG_DESC,MSG_DESC1) MSG_DESC,      LOGYMD,     LOGHMS,                                   ");


            if (lang == 1)
                strSQL.Append("DM.ITEM_DESC1  ITEM_DESC,                                    ");
            else if (lang == 2)
                strSQL.Append("DM.ITEM_DESC2  ITEM_DESC,                                    ");
            else if (lang == 3)
                strSQL.Append("DM.ITEM_DESC3  ITEM_DESC,                                    ");
            else if (lang == 4)
                strSQL.Append("DM.ITEM_DESC4  ITEM_DESC,                                    ");

            strSQL.Append("SEQNO,           S.DATA_CHAR                                     ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM  APL_LOG, SYSTEM_PARAMETER                             ");
                strSQL.Append(" WHERE LOGYMD        = :LOGYMD                               ");
                if (_section_id != "")
                {
                    strSQL.Append(" AND SECTION_ID        = :SECTION_ID       ");
                    db.DbPsetString("SECTION_ID", _section_id);
                }
                if (_loghms != 0)
                {
                    strSQL.Append(" AND LOGHMS        = :LOGHMS                 ");
                    db.DbPsetInt("LOGHMS", _loghms);
                }
                db.DbPsetInt("@LOGYMD", _logymd);
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM  APL_LOG A                                                  ");
                strSQL.Append(" LEFT JOIN  SYSTEM_PARAMETER S ON S.KEY01 = 'SECTION'            ");
                strSQL.Append(" AND S.KEY02 = SECTION_ID                                        ");
                strSQL.Append(" LEFT JOIN  DICTIONARY_MASTER DM ON DM.STD_ITEM = CHAR1          ");
                strSQL.Append(" LEFT JOIN  MESSAGE_MASTER M ON M.MSG_CD = A.MSG_CD              ");
                strSQL.Append(" AND M.LANG = @LANG                                              ");
                strSQL.Append(" WHERE LOGYMD        = @LOGYMD                                   ");
                if (_section_id != "")
                {
                    strSQL.Append(" AND SECTION_ID        = @SECTION_ID         ");
                    db.DbPsetString("@SECTION_ID", _section_id);
                }
                if (_loghms != 0)
                {
                    strSQL.Append(" AND LOGHMS        = @LOGHMS                 ");
                    db.DbPsetInt("@LOGHMS", _loghms);
                }
                db.DbPsetInt("@LOGYMD", _logymd);
                db.DbPsetInt("@LANG", _lang);
            }
            strSQL.Append(" ORDER BY LOGYMD DESC, LOGHMS DESC, SEQNO");
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
        /// 確認済

        /// 
        /// 使用画面：業務アラーム照会

        /// </summary>
        public int Apl_Log_Del()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetInt("@I_LOGYMD", _logymd, ComConst.DB_IN);
            db.DbPsetInt("@I_LOGHMS", _loghms, ComConst.DB_IN);
            db.DbPsetInt("@I_SEQNO", _seqno, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_APL_LOG_DELETE");
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
        /// MRPアラームの明細を検索
        /// 
        /// 使用画面：MrpAlmInq
        /// </summary>
        public DataSet GetAlarmList_Inv()//ADD 2009.09.02
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                  ");
            strSQL.Append(" MA.ITEM_NO,         I.ITEM_DESC,            MA.WHS_CD,                  ");
            strSQL.Append(" MA.QTY                                                                  ");
            strSQL.Append(" ,0 AS NUM_OF_DAYS,	'' AS VENDOR_NAME,	    0 AS SUGGESTED_DUE_DATE,    ");
            strSQL.Append(" '' AS JOB_ORDER_NO, 0 AS SCH_COMPL_DATE,    '' AS BUYER_CD,             ");
            strSQL.Append(" 0 AS JOB_ORDER_QTY, '' AS BUYER_DESC                                    ");
           
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM  MRP_ALARM MA,ITEM_MASTER I                                ");
                strSQL.Append(" WHERE MA.ITEM_NO    = I.ITEM_NO                                 ");
               
                strSQL.Append(" AND MA.SCH_ID       = :SCH_ID                                   ");
                strSQL.Append(" AND MA.ALARM_TYPE   = :ALARM_TYPE                               ");

                db.DbParametersClear();
                if (_alarm_type2 != 0)
                {
                    strSQL.Append(" OR MA.ALARM_TYPE   = :ALARM_TYPE2                           ");
                    db.DbPsetInt("ALARM_TYPE2", _alarm_type2);
                }
                db.DbPsetString("SCH_ID", _sch_id);
                db.DbPsetInt("ALARM_TYPE", _alarm_type);
            }
            else
            {
                strSQL.Append(" FROM  MRP_ALARM MA                                                  ");
                strSQL.Append(" INNER JOIN ITEM_MASTER I ON MA.ITEM_NO = I.ITEM_NO                  ");
                
                strSQL.Append(" WHERE MA.SCH_ID     = @SCH_ID                                       ");
                db.DbParametersClear();
                if (_alarm_type2 != 0)
                {
                    strSQL.Append(" AND (MA.ALARM_TYPE   = @ALARM_TYPE                              ");
                    strSQL.Append(" OR MA.ALARM_TYPE   = @ALARM_TYPE2 )                             ");
                }
                else
                {
                    strSQL.Append(" AND MA.ALARM_TYPE   = @ALARM_TYPE                               ");
                }
                db.DbPsetString("@SCH_ID", _sch_id);
                db.DbPsetInt("@ALARM_TYPE", _alarm_type);
                if (_alarm_type2 != 0)
                {
                    db.DbPsetInt("@ALARM_TYPE2", _alarm_type2);
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
