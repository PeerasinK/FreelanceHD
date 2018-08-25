﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Data;

namespace IMClass
{
    public class Inv
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Inv()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Inv(string p_user_id, int p_lang)
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
        protected string _whs_cd = "";
        protected double _inv_bal = 0;
        protected int _safety_stock_type = 0;
        protected double _safety_stock = 0;
        protected int _safety_stock_days = 0;
        protected double _safety_stock_ratio = 0;
        protected string _ws_cd = "";
        protected string _joc_cd = "";
        protected int _trans_date_beg = 0;
        protected int _trans_date_end = 0;

        protected string _parent_item_no = "";
        protected int _act_beg_date = 0;
        protected int _act_end_date = 0;
        protected string _location = "";
        protected string _catg_cd = "";
        protected double _po_prc = 0;
        protected double _std_amt = 0;
        protected string _lot_no = "";
        protected string _from_whs_cd = "";
        protected double _alloc_qty;
        protected int _sch_disb_beg_date = 0;
        protected int _sch_disb_end_date = 0;
        protected int _sch_disb_date = 0;
        protected int _supply_type = 0;
        protected int _supply_flag = 0;
        protected string _demand_no = "";
        protected string _xfer_no = "";
        protected int _seq_no = 0;
        protected int _request_no = 0;
        protected string _umsr_desc = "";
        protected string _sch_id = "";
        protected int _short_flag = 0;
        protected int _sch_type = 0;

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
        //ADD BY UBIQ-LIU 2010/5/14
        protected int _yymm;
        protected int _prc_type;
        protected string _item_type_str = "";
        protected int _input_type;
        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        public int lang { get { return _lang; } set { _lang = value; } }
        public string item_no { get { return _item_no; } set { _item_no = value; } }
        public string whs_cd { get { return _whs_cd; } set { _whs_cd = value; } }
        public string ws_cd { get { return _ws_cd; } set { _ws_cd = value; } }
        public string joc_cd { get { return _joc_cd; } set { _joc_cd = value; } }
        public double inv_bal { get { return _inv_bal; } set { _inv_bal = value; } }
        public int safety_stock_type { get { return _safety_stock_type; } set { _safety_stock_type = value; } }
        public double safety_stock { get { return _safety_stock; } set { _safety_stock = value; } }
        public int safety_stock_days { get { return _safety_stock_days; } set { _safety_stock_days = value; } }
        public int trans_date_beg { get { return _trans_date_beg; } set { _trans_date_beg = value; } }
        public int trans_date_end { get { return _trans_date_end; } set { _trans_date_end = value; } }
        public double safety_stock_ratio { get { return _safety_stock_ratio; } set { _safety_stock_ratio = value; } }
        public string parent_item_no { get { return _parent_item_no; } set { _parent_item_no = value; } }
        public int act_beg_date { get { return _act_beg_date; } set { _act_beg_date = value; } }
        public int act_end_date { get { return _act_end_date; } set { _act_end_date = value; } }
        public string location { get { return _location; } set { _location = value; } }
        public string catg_cd { get { return _catg_cd; } set { _catg_cd = value; } }
        public double po_prc { get { return _po_prc; } set { _po_prc = value; } }
        public double std_amt { get { return _std_amt; } set { _std_amt = value; } }
        public string lot_no { get { return _lot_no; } set { _lot_no = value; } }
        public string from_whs_cd { get { return _from_whs_cd; } set { _from_whs_cd = value; } }
        public double alloc_qty { get { return _alloc_qty; } set { _alloc_qty = value; } }
        public int sch_disb_beg_date { get { return _sch_disb_beg_date; } set { _sch_disb_beg_date = value; } }
        public int sch_disb_end_date { get { return _sch_disb_end_date; } set { _sch_disb_end_date = value; } }
        public int sch_disb_date { get { return _sch_disb_date; } set { _sch_disb_date = value; } }
        public int supply_type { get { return _supply_type; } set { _supply_type = value; } }
        public int supply_flag { get { return _supply_flag; } set { _supply_flag = value; } }
        public string demand_no { get { return _demand_no; } set { _demand_no = value; } }
        public string xfer_no { get { return _xfer_no; } set { _xfer_no = value; } }
        public int seq_no { get { return _seq_no; } set { _seq_no = value; } }
        public int request_no { get { return _request_no; } set { _request_no = value; } }
        public string umsr_desc { get { return _umsr_desc; } set { _umsr_desc = value; } }
        public string sch_id { get { return _sch_id; } set { _sch_id = value; } }
        public int short_flag { get { return _short_flag; } set { _short_flag = value; } }
        public int sch_type { get { return _sch_type; } set { _sch_type = value; } }
        //ADD BY UBIQ-LIU 2010/5/14
        public int yymm { get { return _yymm; } set { _yymm = value; } }
        public int prc_type { get { return _prc_type; } set { _prc_type = value; } }
        public string item_type_str { get { return _item_type_str; } set { _item_type_str = value; } }
        public int input_type { get { return _input_type; } set { _input_type = value; } }

        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }

        #endregion

        /// <summary>
        /// 品目情報を検索 現在庫の取得
        /// 
        /// 使用画面：MrpSchInvInq
        /// </summary>
        public int GetInvSumByItemWhs()//UPD 20090205 UBIQ-LIU
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            ComLibrary com = new ComLibrary();
            int rtn = 0;

            //--- sql
            //strSQL.Append("SELECT ");
            //strSQL.Append("SUM(INV.INV_BAL) INV_BAL, I.SAFETY_STOCK_TYPE, I.SAFETY_STOCK, I.SAFETY_STOCK_DAYS,	");
            //strSQL.Append("I.SAFETY_STOCK_RATIO                                                                 ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append("SELECT 																	");
                strSQL.Append("	CASE WHEN I.WIP_TYPE = 1 THEN 											");
                strSQL.Append("							 (SELECT SUM(INV.INV_BAL) 						");
                strSQL.Append("									FROM INVENTORY_DETAIL INV  				");
                strSQL.Append("								  WHERE INV.INV_TYPE           = 0			");
                strSQL.Append("									AND INV.INV_YM             = 0			");
                strSQL.Append("									AND INV.INV_WIP_TYPE IN (0)				");
                strSQL.Append("									AND INV.ITEM_NO            = :ITEM_NO	");
                //strSQL.Append("									AND INV.WHS_CD             = :WHS_CD	");
                strSQL.Append("									AND INV.WHS_CD            IN        	"); //ADD BY UBIQ-SUO 2010/09/18
                strSQL.Append("								 (SELECT WHS_CD FROM WAREHOUSE_MASTER WHERE MRP_WHS = :WHS_CD)"); //ADD BY UBIQ-SUO 2010/09/18
                strSQL.Append("								 )											");
                strSQL.Append("	WHEN I.WIP_TYPE = 0 THEN 												");
                strSQL.Append("							 (SELECT SUM(INV.INV_BAL) 						");
                strSQL.Append("									FROM INVENTORY_DETAIL INV  				");
                strSQL.Append("								  WHERE INV.INV_TYPE           = 0			");
                strSQL.Append("									AND INV.INV_YM             = 0			");
                strSQL.Append("									AND ((INV.INV_WIP_TYPE IN (0)			");
                //strSQL.Append("									    AND INV.WHS_CD         = :WHS_CD )  ");
                strSQL.Append("									AND INV.WHS_CD            IN        	"); //ADD BY UBIQ-SUO 2010/09/18
                strSQL.Append("								 (SELECT WHS_CD FROM WAREHOUSE_MASTER WHERE MRP_WHS = :WHS_CD))"); //ADD BY UBIQ-SUO 2010/09/18
                if (short_flag == 1)
                {
                    strSQL.Append("									 OR  (INV.INV_WIP_TYPE IN (1)	    ");
                    strSQL.Append("									AND INV.WS_CD          = :WS_CD	 ) )");
                }
                else
                {
                    strSQL.Append("									 OR  (INV.INV_WIP_TYPE IN (1)	 ) )");
                }
                strSQL.Append("									AND INV.ITEM_NO            = :ITEM_NO	");
                strSQL.Append("								 )											");
                strSQL.Append("	ELSE																	");
                strSQL.Append("							 (SELECT SUM(INV.INV_BAL) 						");
                strSQL.Append("									FROM INVENTORY_DETAIL INV  				");
                strSQL.Append("								  WHERE INV.INV_TYPE           = 0			");
                strSQL.Append("									AND INV.INV_YM             = 0			");
                strSQL.Append("									AND INV.INV_WIP_TYPE IN (5)				");
                strSQL.Append("									AND INV.ITEM_NO            = :ITEM_NO	");
                //strSQL.Append("									AND INV.WHS_CD             = :WHS_CD	");
                strSQL.Append("									AND INV.WHS_CD            IN        	"); //ADD BY UBIQ-SUO 2010/09/18
                strSQL.Append("								 (SELECT WHS_CD FROM WAREHOUSE_MASTER WHERE MRP_WHS = :WHS_CD)"); //ADD BY UBIQ-SUO 2010/09/18
                strSQL.Append("								 )											");
                strSQL.Append("	END INV_BAL, 															");
                strSQL.Append("	I.SAFETY_STOCK_TYPE, I.SAFETY_STOCK, I.SAFETY_STOCK_DAYS,				");
                strSQL.Append("	I.SAFETY_STOCK_RATIO 													");
                strSQL.Append("FROM ITEM_MASTER I														");
                strSQL.Append("WHERE I.ITEM_NO = :ITEM_NO												");


                db.DbParametersClear();
                //strSQL.Append(" FROM INVENTORY_DETAIL INV,ITEM_MASTER I         ");
                //strSQL.Append(" WHERE INV.ITEM_NO            = :ITEM_NO         ");
                //strSQL.Append("   AND INV.WHS_CD             = :WHS_CD          ");
                /*-------Add By Ubiq-Chen 2009.06.05 Begin------*/
                if (short_flag == 1)
                {
                    //strSQL.Append(" AND INV.SCH_ID        = :SCH_ID                         ");
                    //strSQL.Append(" AND INV.WS_CD        = :WS_CD                           ");
                    //db.DbPsetString("SCH_ID", _sch_id);
                    db.DbPsetString("WS_CD", _ws_cd);
                }
                /*-------Add By Ubiq-Chen 2009.06.05 End------*/
                //strSQL.Append("   AND INV.YM                 = 0                ");
                //strSQL.Append("   AND INV.INV_WIP_TYPE       = 0                ");
                //strSQL.Append("   AND INV.INV_TYPE           = 0                ");
                //strSQL.Append("   AND INV.ITEM_NO            = I.ITEM_NO(+)     ");
                //strSQL.Append(" GROUP BY I.SAFETY_STOCK_TYPE, I.SAFETY_STOCK, I.SAFETY_STOCK_DAYS, I.SAFETY_STOCK_RATIO  ");

                //db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                strSQL.Append("SELECT 																	");
                strSQL.Append("	CASE WHEN I.WIP_TYPE = 1 THEN 											");
                strSQL.Append("							 (SELECT SUM(INV.INV_BAL) 						");
                strSQL.Append("									FROM INVENTORY_DETAIL INV  				");
                strSQL.Append("								  WHERE INV.INV_TYPE           = 0			");
                strSQL.Append("									AND INV.INV_YM             = 0			");
                strSQL.Append("									AND INV.INV_WIP_TYPE IN (0)				");
                strSQL.Append("									AND INV.ITEM_NO            = @ITEM_NO	");
                //strSQL.Append("									AND INV.WHS_CD             = @WHS_CD	"); 
                strSQL.Append("									AND INV.WHS_CD            IN        	"); //ADD BY UBIQ-SUO 2010/09/18
                strSQL.Append("								 (SELECT WHS_CD FROM WAREHOUSE_MASTER WHERE MRP_WHS = @WHS_CD)"); //ADD BY UBIQ-SUO 2010/09/18
                strSQL.Append("								 )											");
                strSQL.Append("	WHEN I.WIP_TYPE = 0 THEN 												");
                strSQL.Append("							 (SELECT SUM(INV.INV_BAL) 						");     //DEL BY UBIQ-SAI 2011/11/10
                //strSQL.Append("							 (SELECT SUM(CASE WHEN INV.INV_WIP_TYPE = 1 THEN INV.INV_BAL - INV.ALLOC_QTY ELSE INV.INV_BAL END) 	");     //ADD BY UBIQ-SAI 2011/11/10
                strSQL.Append("									FROM INVENTORY_DETAIL INV  				");
                strSQL.Append("								  WHERE INV.INV_TYPE           = 0			");
                strSQL.Append("									AND INV.INV_YM             = 0			");
                strSQL.Append("									AND ((INV.INV_WIP_TYPE IN (0)			");
                //strSQL.Append("									    AND INV.WHS_CD         = @WHS_CD )  ");
                strSQL.Append("									AND INV.WHS_CD            IN        	"); //ADD BY UBIQ-SUO 2010/09/18
                strSQL.Append("								 (SELECT WHS_CD FROM WAREHOUSE_MASTER WHERE MRP_WHS = @WHS_CD))"); //ADD BY UBIQ-SUO 2010/09/18
                if (short_flag == 1)
                {
                    strSQL.Append("									 OR  (INV.INV_WIP_TYPE IN (1)	    ");
                    strSQL.Append("									AND INV.WS_CD          = @WS_CD	 ) )");                    
                }
                else
                {
                    strSQL.Append("									 OR  (INV.INV_WIP_TYPE IN (1)	 ) )");
                }
                strSQL.Append("									AND INV.ITEM_NO            = @ITEM_NO	");
                strSQL.Append("								 )											");
                strSQL.Append("	ELSE																	");
                strSQL.Append("							 (SELECT SUM(INV.INV_BAL) 						");
                strSQL.Append("									FROM INVENTORY_DETAIL INV  				");
                strSQL.Append("								  WHERE INV.INV_TYPE           = 0			");
                strSQL.Append("									AND INV.INV_YM             = 0			");
                strSQL.Append("									AND INV.INV_WIP_TYPE IN (5)				");
                strSQL.Append("									AND INV.ITEM_NO            = @ITEM_NO	");
                //strSQL.Append("									AND INV.WHS_CD             = @WHS_CD	");
                strSQL.Append("									AND INV.WHS_CD            IN        	"); //ADD BY UBIQ-SUO 2010/09/18
                strSQL.Append("								 (SELECT WHS_CD FROM WAREHOUSE_MASTER WHERE MRP_WHS = @WHS_CD)"); //ADD BY UBIQ-SUO 2010/09/18
                strSQL.Append("								 )											");
                strSQL.Append("	END INV_BAL, 															");
                strSQL.Append("	I.SAFETY_STOCK_TYPE, I.SAFETY_STOCK, I.SAFETY_STOCK_DAYS,				");
                strSQL.Append("	I.SAFETY_STOCK_RATIO 													");
                strSQL.Append("FROM ITEM_MASTER I														");
                strSQL.Append("WHERE I.ITEM_NO = @ITEM_NO												");

                db.DbParametersClear();
                //strSQL.Append(" FROM INVENTORY_DETAIL INV ");
                //strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON INV.ITEM_NO = I.ITEM_NO");
                //strSQL.Append(" WHERE INV.INV_TYPE           = 0                        ");
                //strSQL.Append("   AND INV.INV_YM             = 0                        ");
                //if (short_flag == 0)
                //{
                //    strSQL.Append(" AND INV.INV_WIP_TYPE IN CASE WHEN I.WIP_TYPE = 1    ");
                //    strSQL.Append(" THEN (0) WHEN I.WIP_TYPE = 0 THEN (0,1) ELSE (5) END");
                //}
                //else
                //{
                //    strSQL.Append("   AND INV.INV_WIP_TYPE       = 0                        ");
                //}

                //strSQL.Append("   AND INV.ITEM_NO            = @ITEM_NO                 ");
                //strSQL.Append("   AND INV.WHS_CD             = @WHS_CD                  ");
                if (short_flag == 1)
                {
                    //strSQL.Append(" AND INV.SCH_ID        = @SCH_ID                         ");
                    //strSQL.Append(" AND INV.WS_CD        = @WS_CD                           ");
                    //    db.DbPsetString("@SCH_ID", _sch_id);
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                //strSQL.Append(" GROUP BY I.SAFETY_STOCK_TYPE, I.SAFETY_STOCK, I.SAFETY_STOCK_DAYS, I.SAFETY_STOCK_RATIO  ");

                //db.DbParametersClear();
                //if (_item_no != "")
                //{
                db.DbPsetString("@ITEM_NO", _item_no);
                //}
                //if (_whs_cd != "")
                //{
                db.DbPsetString("@WHS_CD", _whs_cd);
                //}
                //db.DbPsetInt("@END_EFF_DATE", _beg_eff_date);
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
                _inv_bal = com.StringToDouble(db.Row("INV_BAL"));
                _safety_stock_type = com.StringToInt(db.Row("SAFETY_STOCK_TYPE"));
                _safety_stock = com.StringToDouble(db.Row("SAFETY_STOCK"));
                _safety_stock_days = com.StringToInt(db.Row("SAFETY_STOCK_DAYS"));
                _safety_stock_ratio = com.StringToDouble(db.Row("SAFETY_STOCK_RATIO"));
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }
        /// <summary>
        /// 入出庫履歴対象の取得
        /// 
        /// 使用画面：InvTransInq
        /// </summary>
        public DataSet GetRecvDisbList()//2008.12.08 ADD BY LIU
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                                  ");
            strSQL.Append(" RDT.TRANS_DATE,		RDT.TRANS_TIME,		RDT.FROM_VC_CD,		RDT.FROM_WHS_CD,	        ");
            strSQL.Append(" RDT.FROM_WS_CD,     RDT.SLIP_TYPE,      RDT.QTY,            RDT.TO_VC_CD,               ");
            strSQL.Append(" RDT.TO_WHS_CD,      RDT.TO_WS_CD,       RDT.ITEM_UMSR,      RDT.XFER_TEXT,              ");
            strSQL.Append(" RDT.TO_LOCATION,	RDT.FROM_LOCATION,	RDT.TO_LOT_NO,	    RDT.FROM_LOT_NO,		    ");
            //strSQL.Append(" S2.DATA_CHAR XFER_NAME,                                                                 ");
            strSQL.Append(" RDT.TO_JOC_CD,	    RDT.FROM_JOC_CD,    S1.DATA_CHAR UMSR_NAME                          ");
            //ADD 20090710 
            strSQL.Append(" ,V.VENDOR_DESC,     W.WHS_DESC,         WS.WS_DESC                                      ");
            //strSQL.Append(" ,V1.VENDOR_DESC TO_VENDOR_DESC,W1.WHS_DESC TO_WHS_DESC,WS1.WS_DESC TO_WS_DESC           ");
            strSQL.Append(" ,V1.CUST_DESC TO_VENDOR_DESC                              ");   // 2012.01.06
            strSQL.Append(" ,W1.WHS_DESC TO_WHS_DESC,WS1.WS_DESC TO_WS_DESC           ");
            strSQL.Append(" ,RDT.SLIP_NO                                                                            ");//ADD 20090907 
            strSQL.Append(" ,RDT.FROM_PROCESS_CD,RDT.TO_PROCESS_CD                                                  ");//ADD BY UBIQ-SUO 2010/12/29 BUG952

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM RCV_DISB_TRANS RDT                        ");
                strSQL.Append(" WHERE RDT.ITEM_NO     = :ITEM_NO                ");
                db.DbPsetString("ITEM_NO", _item_no);
                if (whs_cd != "")
                {
                    strSQL.Append(" AND (RDT.FROM_WHS_CD        = :WHS_CD       ");
                    strSQL.Append(" OR RDT.TO_WHS_CD            = :WHS_CD )     ");
                    db.DbPsetString("WHS_CD", _whs_cd);
                }
                if (ws_cd != "")
                {
                    strSQL.Append(" AND (RDT.FROM_WS_CD         = :WS_CD        ");
                    strSQL.Append(" OR RDT.TO_WS_CD             = :WS_CD )      ");
                    db.DbPsetString("WS_CD", _ws_cd);
                }
                if (joc_cd != "")
                {
                    strSQL.Append(" AND (RDT.FROM_JOC_CD        = :JOC_CD       ");
                    strSQL.Append(" OR RDT.TO_JOC_CD            = :JOC_CD )     ");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }
                if (trans_date_beg != 0)
                {
                    strSQL.Append(" AND RDT.TRANS_DATE    >= :TRANS_DATE_BEG    ");
                    db.DbPsetInt("TRANS_DATE_BEG", _trans_date_beg);
                }
                if (trans_date_beg != 0)
                {
                    strSQL.Append(" AND RDT.TRANS_DATE    <= :TRANS_DATE_END    ");
                    db.DbPsetInt("TRANS_DATE_END", _trans_date_end);
                }

            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM RCV_DISB_TRANS RDT                         ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON          ");
                strSQL.Append("     S1.KEY01    =   'ITEM_UMSR'                 ");
                strSQL.Append(" AND S1.KEY02    =   RDT.ITEM_UMSR               ");
                //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON          ");
                //strSQL.Append("     S2.KEY01    =   'RCV_DISB_TYPE'             ");
                //strSQL.Append(" AND S2.KEY02    =   RDT.XFER_TEXT               ");
                //ADD 20090710
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON              ");
                strSQL.Append("     RDT.FROM_VC_CD    =   V.VENDOR_CD           ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON           ");
                strSQL.Append("     RDT.FROM_WHS_CD    =   W.WHS_CD             ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON           ");
                strSQL.Append("     RDT.FROM_WS_CD    =   WS.WS_CD              ");
                //strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V1 ON             ");
                //strSQL.Append("     RDT.TO_VC_CD    =   V1.VENDOR_CD            ");
                strSQL.Append(" LEFT OUTER JOIN CUSTOMER_MASTER V1 ON             ");
                strSQL.Append("     RDT.TO_VC_CD    =   V1.CUST_CD            ");   // 2012.01.06
                strSQL.Append(" AND RDT.TO_COST_CENTER  =   V1.CUST_SUB_CD            ");   // 2012.01.06
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W1 ON          ");
                strSQL.Append("     RDT.TO_WHS_CD    =   W1.WHS_CD              ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS1 ON          ");
                strSQL.Append("     RDT.TO_WS_CD    =   WS1.WS_CD               ");
                //
                strSQL.Append(" WHERE RDT.ITEM_NO     = @ITEM_NO                ");
                db.DbPsetString("@ITEM_NO", _item_no);
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND (RDT.FROM_WHS_CD        = @WHS_CD       ");
                    strSQL.Append(" OR RDT.TO_WHS_CD            = @WHS_CD )     ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND (RDT.FROM_WS_CD         = @WS_CD        ");
                    strSQL.Append(" OR RDT.TO_WS_CD             = @WS_CD )      ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_joc_cd != "")
                {
                    strSQL.Append(" AND (RDT.FROM_JOC_CD        = @JOC_CD       ");
                    strSQL.Append(" OR RDT.TO_JOC_CD            = @JOC_CD )     ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (_trans_date_beg != 0)
                {
                    strSQL.Append(" AND RDT.TRANS_DATE    >= @TRANS_DATE_BEG    ");
                    db.DbPsetInt("@TRANS_DATE_BEG", _trans_date_beg);
                }
                if (_trans_date_end != 0)
                {
                    strSQL.Append(" AND RDT.TRANS_DATE    <= @TRANS_DATE_END    ");
                    db.DbPsetInt("@TRANS_DATE_END", _trans_date_end);
                }
                if (_location != "")
                {
                    strSQL.Append(" AND (RDT.FROM_LOCATION        = @LOCATION       ");
                    strSQL.Append(" OR RDT.TO_LOCATION            = @LOCATION )     ");
                    db.DbPsetString("@LOCATION", _location);
                }
                //ADD 20090611 UBIQ-LIU
                if (_sch_type == 0)//倉庫入出庫履歴
                {
                    strSQL.Append(" AND RDT.SLIP_TYPE IN ('01','02','11','12','91','92') ");
                    strSQL.Append(" AND (RDT.REQ_TYPE    BETWEEN 11 AND 41                ");
                    strSQL.Append(" or RDT.REQ_TYPE    = '81' )              "); //ADD BY UBIQ-SAI 2011/07/14
                }
                else//現場入出庫履歴
                {
                    strSQL.Append(" AND RDT.SLIP_TYPE IN ('21','22','92')                ");
                    strSQL.Append(" AND (RDT.REQ_TYPE    BETWEEN '62' AND '92'           ");
                    strSQL.Append(" or RDT.REQ_TYPE    = '06' )              "); //ADD BY UBIQ-SUO 2010/12/28 BUG952
                }
            }
            strSQL.Append(" ORDER BY RDT.TRANS_DATE DESC, RDT.TRANS_TIME DESC, RDT.SLIP_TYPE ASC  ");
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
        /// 入出庫履歴対象の取得
        /// 
        /// 使用画面：FGRecSumm
        /// </summary>
        //public DataSet GetRecvDisbList2()//2008.12.08 ADD BY LIU
        //{
        //ComDB db = new ComDB(_db_type);
        //StringBuilder strSQL = new StringBuilder();
        //DataSet ds = new DataSet();

        ////--- sql
        //strSQL.Append(" SELECT                                                                                  ");
        //strSQL.Append(" RDT.TRANS_DATE,		RDT.TRANS_TIME,		RDT.FROM_VC_CD,		RDT.FROM_WHS_CD,	        ");
        //strSQL.Append(" RDT.FROM_WS_CD,     RDT.SLIP_TYPE,      RDT.QTY,            RDT.TO_VC_CD,               ");
        //strSQL.Append(" RDT.TO_WHS_CD,      RDT.TO_WS_CD,       RDT.ITEM_UMSR,      RDT.XFER_TEXT,              ");
        //strSQL.Append(" RDT.TO_LOCATION,	RDT.FROM_LOCATION,	RDT.TO_LOT_NO,	    RDT.FROM_LOT_NO,		    ");
        ////strSQL.Append(" S2.DATA_CHAR XFER_NAME,                                                                 ");
        //strSQL.Append(" RDT.TO_JOC_CD,	    RDT.FROM_JOC_CD,    S1.DATA_CHAR UMSR_NAME                          ");
        ////ADD 20090710 
        //strSQL.Append(" ,V.VENDOR_DESC,     W.WHS_DESC,         WS.WS_DESC                                      ");
        ////strSQL.Append(" ,V1.VENDOR_DESC TO_VENDOR_DESC,W1.WHS_DESC TO_WHS_DESC,WS1.WS_DESC TO_WS_DESC           ");
        //strSQL.Append(" ,V1.CUST_DESC TO_VENDOR_DESC                              ");   // 2012.01.06
        //strSQL.Append(" ,W1.WHS_DESC TO_WHS_DESC,WS1.WS_DESC TO_WS_DESC           ");
        //strSQL.Append(" ,RDT.SLIP_NO                                                                            ");//ADD 20090907 
        //strSQL.Append(" ,RDT.FROM_PROCESS_CD,RDT.TO_PROCESS_CD                                                  ");//ADD BY UBIQ-SUO 2010/12/29 BUG952

        //if (_db_type == "ORACLE")
        //{
        //    strSQL.Append(" FROM RCV_DISB_TRANS RDT                        ");
        //    strSQL.Append(" WHERE RDT.ITEM_NO     = :ITEM_NO                ");
        //    db.DbPsetString("ITEM_NO", _item_no);
        //    if (whs_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WHS_CD        = :WHS_CD       ");
        //        strSQL.Append(" OR RDT.TO_WHS_CD            = :WHS_CD )     ");
        //        db.DbPsetString("WHS_CD", _whs_cd);
        //    }
        //    if (ws_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WS_CD         = :WS_CD        ");
        //        strSQL.Append(" OR RDT.TO_WS_CD             = :WS_CD )      ");
        //        db.DbPsetString("WS_CD", _ws_cd);
        //    }
        //    if (joc_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_JOC_CD        = :JOC_CD       ");
        //        strSQL.Append(" OR RDT.TO_JOC_CD            = :JOC_CD )     ");
        //        db.DbPsetString("JOC_CD", _joc_cd);
        //    }
        //    if (trans_date_beg != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    >= :TRANS_DATE_BEG    ");
        //        db.DbPsetInt("TRANS_DATE_BEG", _trans_date_beg);
        //    }
        //    if (trans_date_beg != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    <= :TRANS_DATE_END    ");
        //        db.DbPsetInt("TRANS_DATE_END", _trans_date_end);
        //    }

        //}
        //else
        //{
        //    db.DbParametersClear();

        //    strSQL.Append(" FROM RCV_DISB_TRANS RDT                         ");
        //    strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON          ");
        //    strSQL.Append("     S1.KEY01    =   'ITEM_UMSR'                 ");
        //    strSQL.Append(" AND S1.KEY02    =   RDT.ITEM_UMSR               ");
        //    //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON          ");
        //    //strSQL.Append("     S2.KEY01    =   'RCV_DISB_TYPE'             ");
        //    //strSQL.Append(" AND S2.KEY02    =   RDT.XFER_TEXT               ");
        //    //ADD 20090710
        //    strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON              ");
        //    strSQL.Append("     RDT.FROM_VC_CD    =   V.VENDOR_CD           ");
        //    strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON           ");
        //    strSQL.Append("     RDT.FROM_WHS_CD    =   W.WHS_CD             ");
        //    strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON           ");
        //    strSQL.Append("     RDT.FROM_WS_CD    =   WS.WS_CD              ");
        //    //strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V1 ON             ");
        //    //strSQL.Append("     RDT.TO_VC_CD    =   V1.VENDOR_CD            ");
        //    strSQL.Append(" LEFT OUTER JOIN CUSTOMER_MASTER V1 ON             ");
        //    strSQL.Append("     RDT.TO_VC_CD    =   V1.CUST_CD            ");   // 2012.01.06
        //    strSQL.Append(" AND RDT.TO_COST_CENTER  =   V1.CUST_SUB_CD            ");   // 2012.01.06
        //    strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W1 ON          ");
        //    strSQL.Append("     RDT.TO_WHS_CD    =   W1.WHS_CD              ");
        //    strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS1 ON          ");
        //    strSQL.Append("     RDT.TO_WS_CD    =   WS1.WS_CD               ");
        //    //
        //    strSQL.Append(" WHERE RDT.ITEM_NO     = @ITEM_NO                ");
        //    db.DbPsetString("@ITEM_NO", _item_no);
        //    if (_whs_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WHS_CD        = @WHS_CD       ");
        //        strSQL.Append(" OR RDT.TO_WHS_CD            = @WHS_CD )     ");
        //        db.DbPsetString("@WHS_CD", _whs_cd);
        //    }
        //    if (_ws_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WS_CD         = @WS_CD        ");
        //        strSQL.Append(" OR RDT.TO_WS_CD             = @WS_CD )      ");
        //        db.DbPsetString("@WS_CD", _ws_cd);
        //    }
        //    if (_joc_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_JOC_CD        = @JOC_CD       ");
        //        strSQL.Append(" OR RDT.TO_JOC_CD            = @JOC_CD )     ");
        //        db.DbPsetString("@JOC_CD", _joc_cd);
        //    }
        //    if (_trans_date_beg != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    >= @TRANS_DATE_BEG    ");
        //        db.DbPsetInt("@TRANS_DATE_BEG", _trans_date_beg);
        //    }
        //    if (_trans_date_end != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    <= @TRANS_DATE_END    ");
        //        db.DbPsetInt("@TRANS_DATE_END", _trans_date_end);
        //    }
        //    if (_location != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_LOCATION        = @LOCATION       ");
        //        strSQL.Append(" OR RDT.TO_LOCATION            = @LOCATION )     ");
        //        db.DbPsetString("@LOCATION", _location);
        //    }
        //    //ADD 20090611 UBIQ-LIU
        //    if (_sch_type == 0)//倉庫入出庫履歴
        //    {
        //        strSQL.Append(" AND RDT.SLIP_TYPE IN ('01','02','11','12','91','92') ");
        //        strSQL.Append(" AND (RDT.REQ_TYPE    BETWEEN 11 AND 41                ");
        //        strSQL.Append(" or RDT.REQ_TYPE    = '81' )              "); //ADD BY UBIQ-SAI 2011/07/14
        //    }
        //    else//現場入出庫履歴
        //    {
        //        strSQL.Append(" AND RDT.SLIP_TYPE IN ('21','22','92')                ");
        //        strSQL.Append(" AND (RDT.REQ_TYPE    BETWEEN '62' AND '92'           ");
        //        strSQL.Append(" or RDT.REQ_TYPE    = '06' )              "); //ADD BY UBIQ-SUO 2010/12/28 BUG952
        //    }
        //}
        //strSQL.Append(" ORDER BY RDT.TRANS_DATE DESC, RDT.TRANS_TIME DESC, RDT.SLIP_TYPE ASC  ");
        //try
        //{
        //    ds = db.DbDataSet(strSQL.ToString(), "TABLE");
        //    if (ds == null)
        //    {
        //        _dbmsg = db.expmsg;
        //        _strErr = db.strErr;
        //    }
        //    if (db.State() == ConnectionState.Open)
        //        db.DbClose();

        //    return ds;
        //}
        //catch
        //{
        //    _dbmsg = db.expmsg;
        //    _strErr = db.strErr;
        //    if (db.State() == ConnectionState.Open)
        //        db.DbClose();
        //    return null;
        //}
        //}
        /// <summary>
        /// 入出庫履歴対象の取得
        /// 
        /// 使用画面：FGDelSumm
        /// </summary>
        //public DataSet GetRecvDisbList3()//2008.12.08 ADD BY LIU
        //{
        //ComDB db = new ComDB(_db_type);
        //StringBuilder strSQL = new StringBuilder();
        //DataSet ds = new DataSet();

        ////--- sql
        //strSQL.Append(" SELECT                                                                                  ");
        //strSQL.Append(" RDT.TRANS_DATE,		RDT.TRANS_TIME,		RDT.FROM_VC_CD,		RDT.FROM_WHS_CD,	        ");
        //strSQL.Append(" RDT.FROM_WS_CD,     RDT.SLIP_TYPE,      RDT.QTY,            RDT.TO_VC_CD,               ");
        //strSQL.Append(" RDT.TO_WHS_CD,      RDT.TO_WS_CD,       RDT.ITEM_UMSR,      RDT.XFER_TEXT,              ");
        //strSQL.Append(" RDT.TO_LOCATION,	RDT.FROM_LOCATION,	RDT.TO_LOT_NO,	    RDT.FROM_LOT_NO,		    ");
        ////strSQL.Append(" S2.DATA_CHAR XFER_NAME,                                                                 ");
        //strSQL.Append(" RDT.TO_JOC_CD,	    RDT.FROM_JOC_CD,    S1.DATA_CHAR UMSR_NAME                          ");
        ////ADD 20090710 
        //strSQL.Append(" ,V.VENDOR_DESC,     W.WHS_DESC,         WS.WS_DESC                                      ");
        ////strSQL.Append(" ,V1.VENDOR_DESC TO_VENDOR_DESC,W1.WHS_DESC TO_WHS_DESC,WS1.WS_DESC TO_WS_DESC           ");
        //strSQL.Append(" ,V1.CUST_DESC TO_VENDOR_DESC                              ");   // 2012.01.06
        //strSQL.Append(" ,W1.WHS_DESC TO_WHS_DESC,WS1.WS_DESC TO_WS_DESC           ");
        //strSQL.Append(" ,RDT.SLIP_NO                                                                            ");//ADD 20090907 
        //strSQL.Append(" ,RDT.FROM_PROCESS_CD,RDT.TO_PROCESS_CD                                                  ");//ADD BY UBIQ-SUO 2010/12/29 BUG952

        //if (_db_type == "ORACLE")
        //{
        //    strSQL.Append(" FROM RCV_DISB_TRANS RDT                        ");
        //    strSQL.Append(" WHERE RDT.ITEM_NO     = :ITEM_NO                ");
        //    db.DbPsetString("ITEM_NO", _item_no);
        //    if (whs_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WHS_CD        = :WHS_CD       ");
        //        strSQL.Append(" OR RDT.TO_WHS_CD            = :WHS_CD )     ");
        //        db.DbPsetString("WHS_CD", _whs_cd);
        //    }
        //    if (ws_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WS_CD         = :WS_CD        ");
        //        strSQL.Append(" OR RDT.TO_WS_CD             = :WS_CD )      ");
        //        db.DbPsetString("WS_CD", _ws_cd);
        //    }
        //    if (joc_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_JOC_CD        = :JOC_CD       ");
        //        strSQL.Append(" OR RDT.TO_JOC_CD            = :JOC_CD )     ");
        //        db.DbPsetString("JOC_CD", _joc_cd);
        //    }
        //    if (trans_date_beg != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    >= :TRANS_DATE_BEG    ");
        //        db.DbPsetInt("TRANS_DATE_BEG", _trans_date_beg);
        //    }
        //    if (trans_date_beg != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    <= :TRANS_DATE_END    ");
        //        db.DbPsetInt("TRANS_DATE_END", _trans_date_end);
        //    }

        //}
        //else
        //{
        //    db.DbParametersClear();

        //    strSQL.Append(" FROM RCV_DISB_TRANS RDT                         ");
        //    strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON          ");
        //    strSQL.Append("     S1.KEY01    =   'ITEM_UMSR'                 ");
        //    strSQL.Append(" AND S1.KEY02    =   RDT.ITEM_UMSR               ");
        //    //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON          ");
        //    //strSQL.Append("     S2.KEY01    =   'RCV_DISB_TYPE'             ");
        //    //strSQL.Append(" AND S2.KEY02    =   RDT.XFER_TEXT               ");
        //    //ADD 20090710
        //    strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON              ");
        //    strSQL.Append("     RDT.FROM_VC_CD    =   V.VENDOR_CD           ");
        //    strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON           ");
        //    strSQL.Append("     RDT.FROM_WHS_CD    =   W.WHS_CD             ");
        //    strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON           ");
        //    strSQL.Append("     RDT.FROM_WS_CD    =   WS.WS_CD              ");
        //    //strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V1 ON             ");
        //    //strSQL.Append("     RDT.TO_VC_CD    =   V1.VENDOR_CD            ");
        //    strSQL.Append(" LEFT OUTER JOIN CUSTOMER_MASTER V1 ON             ");
        //    strSQL.Append("     RDT.TO_VC_CD    =   V1.CUST_CD            ");   // 2012.01.06
        //    strSQL.Append(" AND RDT.TO_COST_CENTER  =   V1.CUST_SUB_CD            ");   // 2012.01.06
        //    strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W1 ON          ");
        //    strSQL.Append("     RDT.TO_WHS_CD    =   W1.WHS_CD              ");
        //    strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS1 ON          ");
        //    strSQL.Append("     RDT.TO_WS_CD    =   WS1.WS_CD               ");
        //    //
        //    strSQL.Append(" WHERE RDT.ITEM_NO     = @ITEM_NO                ");
        //    db.DbPsetString("@ITEM_NO", _item_no);
        //    if (_whs_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WHS_CD        = @WHS_CD       ");
        //        strSQL.Append(" OR RDT.TO_WHS_CD            = @WHS_CD )     ");
        //        db.DbPsetString("@WHS_CD", _whs_cd);
        //    }
        //    if (_ws_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WS_CD         = @WS_CD        ");
        //        strSQL.Append(" OR RDT.TO_WS_CD             = @WS_CD )      ");
        //        db.DbPsetString("@WS_CD", _ws_cd);
        //    }
        //    if (_joc_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_JOC_CD        = @JOC_CD       ");
        //        strSQL.Append(" OR RDT.TO_JOC_CD            = @JOC_CD )     ");
        //        db.DbPsetString("@JOC_CD", _joc_cd);
        //    }
        //    if (_trans_date_beg != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    >= @TRANS_DATE_BEG    ");
        //        db.DbPsetInt("@TRANS_DATE_BEG", _trans_date_beg);
        //    }
        //    if (_trans_date_end != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    <= @TRANS_DATE_END    ");
        //        db.DbPsetInt("@TRANS_DATE_END", _trans_date_end);
        //    }
        //    if (_location != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_LOCATION        = @LOCATION       ");
        //        strSQL.Append(" OR RDT.TO_LOCATION            = @LOCATION )     ");
        //        db.DbPsetString("@LOCATION", _location);
        //    }
        //    //ADD 20090611 UBIQ-LIU
        //    if (_sch_type == 0)//倉庫入出庫履歴
        //    {
        //        strSQL.Append(" AND RDT.SLIP_TYPE IN ('01','02','11','12','91','92') ");
        //        strSQL.Append(" AND (RDT.REQ_TYPE    BETWEEN 11 AND 41                ");
        //        strSQL.Append(" or RDT.REQ_TYPE    = '81' )              "); //ADD BY UBIQ-SAI 2011/07/14
        //    }
        //    else//現場入出庫履歴
        //    {
        //        strSQL.Append(" AND RDT.SLIP_TYPE IN ('21','22','92')                ");
        //        strSQL.Append(" AND (RDT.REQ_TYPE    BETWEEN '62' AND '92'           ");
        //        strSQL.Append(" or RDT.REQ_TYPE    = '06' )              "); //ADD BY UBIQ-SUO 2010/12/28 BUG952
        //    }
        //}
        //strSQL.Append(" ORDER BY RDT.TRANS_DATE DESC, RDT.TRANS_TIME DESC, RDT.SLIP_TYPE ASC  ");
        //try
        //{
        //    ds = db.DbDataSet(strSQL.ToString(), "TABLE");
        //    if (ds == null)
        //    {
        //        _dbmsg = db.expmsg;
        //        _strErr = db.strErr;
        //    }
        //    if (db.State() == ConnectionState.Open)
        //        db.DbClose();

        //    return ds;
        //}
        //catch
        //{
        //    _dbmsg = db.expmsg;
        //    _strErr = db.strErr;
        //    if (db.State() == ConnectionState.Open)
        //        db.DbClose();
        //    return null;
        //}
        //}
        /// <summary>
        /// 入出庫履歴対象の取得
        /// 
        /// 使用画面：StkProdRpt
        /// </summary>
        //public DataSet GetRecvDisbList4()//2008.12.08 ADD BY LIU
        //{
        //ComDB db = new ComDB(_db_type);
        //StringBuilder strSQL = new StringBuilder();
        //DataSet ds = new DataSet();

        ////--- sql
        //strSQL.Append(" SELECT                                                                                  ");
        //strSQL.Append(" RDT.TRANS_DATE,		RDT.TRANS_TIME,		RDT.FROM_VC_CD,		RDT.FROM_WHS_CD,	        ");
        //strSQL.Append(" RDT.FROM_WS_CD,     RDT.SLIP_TYPE,      RDT.QTY,            RDT.TO_VC_CD,               ");
        //strSQL.Append(" RDT.TO_WHS_CD,      RDT.TO_WS_CD,       RDT.ITEM_UMSR,      RDT.XFER_TEXT,              ");
        //strSQL.Append(" RDT.TO_LOCATION,	RDT.FROM_LOCATION,	RDT.TO_LOT_NO,	    RDT.FROM_LOT_NO,		    ");
        ////strSQL.Append(" S2.DATA_CHAR XFER_NAME,                                                                 ");
        //strSQL.Append(" RDT.TO_JOC_CD,	    RDT.FROM_JOC_CD,    S1.DATA_CHAR UMSR_NAME                          ");
        ////ADD 20090710 
        //strSQL.Append(" ,V.VENDOR_DESC,     W.WHS_DESC,         WS.WS_DESC                                      ");
        ////strSQL.Append(" ,V1.VENDOR_DESC TO_VENDOR_DESC,W1.WHS_DESC TO_WHS_DESC,WS1.WS_DESC TO_WS_DESC           ");
        //strSQL.Append(" ,V1.CUST_DESC TO_VENDOR_DESC                              ");   // 2012.01.06
        //strSQL.Append(" ,W1.WHS_DESC TO_WHS_DESC,WS1.WS_DESC TO_WS_DESC           ");
        //strSQL.Append(" ,RDT.SLIP_NO                                                                            ");//ADD 20090907 
        //strSQL.Append(" ,RDT.FROM_PROCESS_CD,RDT.TO_PROCESS_CD                                                  ");//ADD BY UBIQ-SUO 2010/12/29 BUG952

        //if (_db_type == "ORACLE")
        //{
        //    strSQL.Append(" FROM RCV_DISB_TRANS RDT                        ");
        //    strSQL.Append(" WHERE RDT.ITEM_NO     = :ITEM_NO                ");
        //    db.DbPsetString("ITEM_NO", _item_no);
        //    if (whs_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WHS_CD        = :WHS_CD       ");
        //        strSQL.Append(" OR RDT.TO_WHS_CD            = :WHS_CD )     ");
        //        db.DbPsetString("WHS_CD", _whs_cd);
        //    }
        //    if (ws_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WS_CD         = :WS_CD        ");
        //        strSQL.Append(" OR RDT.TO_WS_CD             = :WS_CD )      ");
        //        db.DbPsetString("WS_CD", _ws_cd);
        //    }
        //    if (joc_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_JOC_CD        = :JOC_CD       ");
        //        strSQL.Append(" OR RDT.TO_JOC_CD            = :JOC_CD )     ");
        //        db.DbPsetString("JOC_CD", _joc_cd);
        //    }
        //    if (trans_date_beg != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    >= :TRANS_DATE_BEG    ");
        //        db.DbPsetInt("TRANS_DATE_BEG", _trans_date_beg);
        //    }
        //    if (trans_date_beg != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    <= :TRANS_DATE_END    ");
        //        db.DbPsetInt("TRANS_DATE_END", _trans_date_end);
        //    }

        //}
        //else
        //{
        //    db.DbParametersClear();

        //    strSQL.Append(" FROM RCV_DISB_TRANS RDT                         ");
        //    strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON          ");
        //    strSQL.Append("     S1.KEY01    =   'ITEM_UMSR'                 ");
        //    strSQL.Append(" AND S1.KEY02    =   RDT.ITEM_UMSR               ");
        //    //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON          ");
        //    //strSQL.Append("     S2.KEY01    =   'RCV_DISB_TYPE'             ");
        //    //strSQL.Append(" AND S2.KEY02    =   RDT.XFER_TEXT               ");
        //    //ADD 20090710
        //    strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON              ");
        //    strSQL.Append("     RDT.FROM_VC_CD    =   V.VENDOR_CD           ");
        //    strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON           ");
        //    strSQL.Append("     RDT.FROM_WHS_CD    =   W.WHS_CD             ");
        //    strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON           ");
        //    strSQL.Append("     RDT.FROM_WS_CD    =   WS.WS_CD              ");
        //    //strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V1 ON             ");
        //    //strSQL.Append("     RDT.TO_VC_CD    =   V1.VENDOR_CD            ");
        //    strSQL.Append(" LEFT OUTER JOIN CUSTOMER_MASTER V1 ON             ");
        //    strSQL.Append("     RDT.TO_VC_CD    =   V1.CUST_CD            ");   // 2012.01.06
        //    strSQL.Append(" AND RDT.TO_COST_CENTER  =   V1.CUST_SUB_CD            ");   // 2012.01.06
        //    strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W1 ON          ");
        //    strSQL.Append("     RDT.TO_WHS_CD    =   W1.WHS_CD              ");
        //    strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS1 ON          ");
        //    strSQL.Append("     RDT.TO_WS_CD    =   WS1.WS_CD               ");
        //    //
        //    strSQL.Append(" WHERE RDT.ITEM_NO     = @ITEM_NO                ");
        //    db.DbPsetString("@ITEM_NO", _item_no);
        //    if (_whs_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WHS_CD        = @WHS_CD       ");
        //        strSQL.Append(" OR RDT.TO_WHS_CD            = @WHS_CD )     ");
        //        db.DbPsetString("@WHS_CD", _whs_cd);
        //    }
        //    if (_ws_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WS_CD         = @WS_CD        ");
        //        strSQL.Append(" OR RDT.TO_WS_CD             = @WS_CD )      ");
        //        db.DbPsetString("@WS_CD", _ws_cd);
        //    }
        //    if (_joc_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_JOC_CD        = @JOC_CD       ");
        //        strSQL.Append(" OR RDT.TO_JOC_CD            = @JOC_CD )     ");
        //        db.DbPsetString("@JOC_CD", _joc_cd);
        //    }
        //    if (_trans_date_beg != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    >= @TRANS_DATE_BEG    ");
        //        db.DbPsetInt("@TRANS_DATE_BEG", _trans_date_beg);
        //    }
        //    if (_trans_date_end != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    <= @TRANS_DATE_END    ");
        //        db.DbPsetInt("@TRANS_DATE_END", _trans_date_end);
        //    }
        //    if (_location != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_LOCATION        = @LOCATION       ");
        //        strSQL.Append(" OR RDT.TO_LOCATION            = @LOCATION )     ");
        //        db.DbPsetString("@LOCATION", _location);
        //    }
        //    //ADD 20090611 UBIQ-LIU
        //    if (_sch_type == 0)//倉庫入出庫履歴
        //    {
        //        strSQL.Append(" AND RDT.SLIP_TYPE IN ('01','02','11','12','91','92') ");
        //        strSQL.Append(" AND (RDT.REQ_TYPE    BETWEEN 11 AND 41                ");
        //        strSQL.Append(" or RDT.REQ_TYPE    = '81' )              "); //ADD BY UBIQ-SAI 2011/07/14
        //    }
        //    else//現場入出庫履歴
        //    {
        //        strSQL.Append(" AND RDT.SLIP_TYPE IN ('21','22','92')                ");
        //        strSQL.Append(" AND (RDT.REQ_TYPE    BETWEEN '62' AND '92'           ");
        //        strSQL.Append(" or RDT.REQ_TYPE    = '06' )              "); //ADD BY UBIQ-SUO 2010/12/28 BUG952
        //    }
        //}
        //strSQL.Append(" ORDER BY RDT.TRANS_DATE DESC, RDT.TRANS_TIME DESC, RDT.SLIP_TYPE ASC  ");
        //try
        //{
        //    ds = db.DbDataSet(strSQL.ToString(), "TABLE");
        //    if (ds == null)
        //    {
        //        _dbmsg = db.expmsg;
        //        _strErr = db.strErr;
        //    }
        //    if (db.State() == ConnectionState.Open)
        //        db.DbClose();

        //    return ds;
        //}
        //catch
        //{
        //    _dbmsg = db.expmsg;
        //    _strErr = db.strErr;
        //    if (db.State() == ConnectionState.Open)
        //        db.DbClose();
        //    return null;
        //}
        //}
        /// <summary>
        /// 入出庫履歴対象の取得
        /// 
        /// 使用画面：FeStkProdRpt
        /// </summary>
        //public DataSet GetRecvDisbList5()//2008.12.08 ADD BY LIU
        //{
        //ComDB db = new ComDB(_db_type);
        //StringBuilder strSQL = new StringBuilder();
        //DataSet ds = new DataSet();

        ////--- sql
        //strSQL.Append(" SELECT                                                                                  ");
        //strSQL.Append(" RDT.TRANS_DATE,		RDT.TRANS_TIME,		RDT.FROM_VC_CD,		RDT.FROM_WHS_CD,	        ");
        //strSQL.Append(" RDT.FROM_WS_CD,     RDT.SLIP_TYPE,      RDT.QTY,            RDT.TO_VC_CD,               ");
        //strSQL.Append(" RDT.TO_WHS_CD,      RDT.TO_WS_CD,       RDT.ITEM_UMSR,      RDT.XFER_TEXT,              ");
        //strSQL.Append(" RDT.TO_LOCATION,	RDT.FROM_LOCATION,	RDT.TO_LOT_NO,	    RDT.FROM_LOT_NO,		    ");
        ////strSQL.Append(" S2.DATA_CHAR XFER_NAME,                                                                 ");
        //strSQL.Append(" RDT.TO_JOC_CD,	    RDT.FROM_JOC_CD,    S1.DATA_CHAR UMSR_NAME                          ");
        ////ADD 20090710 
        //strSQL.Append(" ,V.VENDOR_DESC,     W.WHS_DESC,         WS.WS_DESC                                      ");
        ////strSQL.Append(" ,V1.VENDOR_DESC TO_VENDOR_DESC,W1.WHS_DESC TO_WHS_DESC,WS1.WS_DESC TO_WS_DESC           ");
        //strSQL.Append(" ,V1.CUST_DESC TO_VENDOR_DESC                              ");   // 2012.01.06
        //strSQL.Append(" ,W1.WHS_DESC TO_WHS_DESC,WS1.WS_DESC TO_WS_DESC           ");
        //strSQL.Append(" ,RDT.SLIP_NO                                                                            ");//ADD 20090907 
        //strSQL.Append(" ,RDT.FROM_PROCESS_CD,RDT.TO_PROCESS_CD                                                  ");//ADD BY UBIQ-SUO 2010/12/29 BUG952

        //if (_db_type == "ORACLE")
        //{
        //    strSQL.Append(" FROM RCV_DISB_TRANS RDT                        ");
        //    strSQL.Append(" WHERE RDT.ITEM_NO     = :ITEM_NO                ");
        //    db.DbPsetString("ITEM_NO", _item_no);
        //    if (whs_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WHS_CD        = :WHS_CD       ");
        //        strSQL.Append(" OR RDT.TO_WHS_CD            = :WHS_CD )     ");
        //        db.DbPsetString("WHS_CD", _whs_cd);
        //    }
        //    if (ws_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WS_CD         = :WS_CD        ");
        //        strSQL.Append(" OR RDT.TO_WS_CD             = :WS_CD )      ");
        //        db.DbPsetString("WS_CD", _ws_cd);
        //    }
        //    if (joc_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_JOC_CD        = :JOC_CD       ");
        //        strSQL.Append(" OR RDT.TO_JOC_CD            = :JOC_CD )     ");
        //        db.DbPsetString("JOC_CD", _joc_cd);
        //    }
        //    if (trans_date_beg != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    >= :TRANS_DATE_BEG    ");
        //        db.DbPsetInt("TRANS_DATE_BEG", _trans_date_beg);
        //    }
        //    if (trans_date_beg != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    <= :TRANS_DATE_END    ");
        //        db.DbPsetInt("TRANS_DATE_END", _trans_date_end);
        //    }

        //}
        //else
        //{
        //    db.DbParametersClear();

        //    strSQL.Append(" FROM RCV_DISB_TRANS RDT                         ");
        //    strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON          ");
        //    strSQL.Append("     S1.KEY01    =   'ITEM_UMSR'                 ");
        //    strSQL.Append(" AND S1.KEY02    =   RDT.ITEM_UMSR               ");
        //    //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON          ");
        //    //strSQL.Append("     S2.KEY01    =   'RCV_DISB_TYPE'             ");
        //    //strSQL.Append(" AND S2.KEY02    =   RDT.XFER_TEXT               ");
        //    //ADD 20090710
        //    strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON              ");
        //    strSQL.Append("     RDT.FROM_VC_CD    =   V.VENDOR_CD           ");
        //    strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON           ");
        //    strSQL.Append("     RDT.FROM_WHS_CD    =   W.WHS_CD             ");
        //    strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON           ");
        //    strSQL.Append("     RDT.FROM_WS_CD    =   WS.WS_CD              ");
        //    //strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V1 ON             ");
        //    //strSQL.Append("     RDT.TO_VC_CD    =   V1.VENDOR_CD            ");
        //    strSQL.Append(" LEFT OUTER JOIN CUSTOMER_MASTER V1 ON             ");
        //    strSQL.Append("     RDT.TO_VC_CD    =   V1.CUST_CD            ");   // 2012.01.06
        //    strSQL.Append(" AND RDT.TO_COST_CENTER  =   V1.CUST_SUB_CD            ");   // 2012.01.06
        //    strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W1 ON          ");
        //    strSQL.Append("     RDT.TO_WHS_CD    =   W1.WHS_CD              ");
        //    strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS1 ON          ");
        //    strSQL.Append("     RDT.TO_WS_CD    =   WS1.WS_CD               ");
        //    //
        //    strSQL.Append(" WHERE RDT.ITEM_NO     = @ITEM_NO                ");
        //    db.DbPsetString("@ITEM_NO", _item_no);
        //    if (_whs_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WHS_CD        = @WHS_CD       ");
        //        strSQL.Append(" OR RDT.TO_WHS_CD            = @WHS_CD )     ");
        //        db.DbPsetString("@WHS_CD", _whs_cd);
        //    }
        //    if (_ws_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WS_CD         = @WS_CD        ");
        //        strSQL.Append(" OR RDT.TO_WS_CD             = @WS_CD )      ");
        //        db.DbPsetString("@WS_CD", _ws_cd);
        //    }
        //    if (_joc_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_JOC_CD        = @JOC_CD       ");
        //        strSQL.Append(" OR RDT.TO_JOC_CD            = @JOC_CD )     ");
        //        db.DbPsetString("@JOC_CD", _joc_cd);
        //    }
        //    if (_trans_date_beg != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    >= @TRANS_DATE_BEG    ");
        //        db.DbPsetInt("@TRANS_DATE_BEG", _trans_date_beg);
        //    }
        //    if (_trans_date_end != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    <= @TRANS_DATE_END    ");
        //        db.DbPsetInt("@TRANS_DATE_END", _trans_date_end);
        //    }
        //    if (_location != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_LOCATION        = @LOCATION       ");
        //        strSQL.Append(" OR RDT.TO_LOCATION            = @LOCATION )     ");
        //        db.DbPsetString("@LOCATION", _location);
        //    }
        //    //ADD 20090611 UBIQ-LIU
        //    if (_sch_type == 0)//倉庫入出庫履歴
        //    {
        //        strSQL.Append(" AND RDT.SLIP_TYPE IN ('01','02','11','12','91','92') ");
        //        strSQL.Append(" AND (RDT.REQ_TYPE    BETWEEN 11 AND 41                ");
        //        strSQL.Append(" or RDT.REQ_TYPE    = '81' )              "); //ADD BY UBIQ-SAI 2011/07/14
        //    }
        //    else//現場入出庫履歴
        //    {
        //        strSQL.Append(" AND RDT.SLIP_TYPE IN ('21','22','92')                ");
        //        strSQL.Append(" AND (RDT.REQ_TYPE    BETWEEN '62' AND '92'           ");
        //        strSQL.Append(" or RDT.REQ_TYPE    = '06' )              "); //ADD BY UBIQ-SUO 2010/12/28 BUG952
        //    }
        //}
        //strSQL.Append(" ORDER BY RDT.TRANS_DATE DESC, RDT.TRANS_TIME DESC, RDT.SLIP_TYPE ASC  ");
        //try
        //{
        //    ds = db.DbDataSet(strSQL.ToString(), "TABLE");
        //    if (ds == null)
        //    {
        //        _dbmsg = db.expmsg;
        //        _strErr = db.strErr;
        //    }
        //    if (db.State() == ConnectionState.Open)
        //        db.DbClose();

        //    return ds;
        //}
        //catch
        //{
        //    _dbmsg = db.expmsg;
        //    _strErr = db.strErr;
        //    if (db.State() == ConnectionState.Open)
        //        db.DbClose();
        //    return null;
        //}
        //}
        /// <summary>
        /// 入出庫履歴対象の取得
        /// 
        /// 使用画面：FeStkProdRpt
        /// </summary>
        //public DataSet GetRecvDisbList5()//2008.12.08 ADD BY LIU
        //{
        //ComDB db = new ComDB(_db_type);
        //StringBuilder strSQL = new StringBuilder();
        //DataSet ds = new DataSet();

        ////--- sql
        //strSQL.Append(" SELECT                                                                                  ");
        //strSQL.Append(" RDT.TRANS_DATE,		RDT.TRANS_TIME,		RDT.FROM_VC_CD,		RDT.FROM_WHS_CD,	        ");
        //strSQL.Append(" RDT.FROM_WS_CD,     RDT.SLIP_TYPE,      RDT.QTY,            RDT.TO_VC_CD,               ");
        //strSQL.Append(" RDT.TO_WHS_CD,      RDT.TO_WS_CD,       RDT.ITEM_UMSR,      RDT.XFER_TEXT,              ");
        //strSQL.Append(" RDT.TO_LOCATION,	RDT.FROM_LOCATION,	RDT.TO_LOT_NO,	    RDT.FROM_LOT_NO,		    ");
        ////strSQL.Append(" S2.DATA_CHAR XFER_NAME,                                                                 ");
        //strSQL.Append(" RDT.TO_JOC_CD,	    RDT.FROM_JOC_CD,    S1.DATA_CHAR UMSR_NAME                          ");
        ////ADD 20090710 
        //strSQL.Append(" ,V.VENDOR_DESC,     W.WHS_DESC,         WS.WS_DESC                                      ");
        ////strSQL.Append(" ,V1.VENDOR_DESC TO_VENDOR_DESC,W1.WHS_DESC TO_WHS_DESC,WS1.WS_DESC TO_WS_DESC           ");
        //strSQL.Append(" ,V1.CUST_DESC TO_VENDOR_DESC                              ");   // 2012.01.06
        //strSQL.Append(" ,W1.WHS_DESC TO_WHS_DESC,WS1.WS_DESC TO_WS_DESC           ");
        //strSQL.Append(" ,RDT.SLIP_NO                                                                            ");//ADD 20090907 
        //strSQL.Append(" ,RDT.FROM_PROCESS_CD,RDT.TO_PROCESS_CD                                                  ");//ADD BY UBIQ-SUO 2010/12/29 BUG952

        //if (_db_type == "ORACLE")
        //{
        //    strSQL.Append(" FROM RCV_DISB_TRANS RDT                        ");
        //    strSQL.Append(" WHERE RDT.ITEM_NO     = :ITEM_NO                ");
        //    db.DbPsetString("ITEM_NO", _item_no);
        //    if (whs_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WHS_CD        = :WHS_CD       ");
        //        strSQL.Append(" OR RDT.TO_WHS_CD            = :WHS_CD )     ");
        //        db.DbPsetString("WHS_CD", _whs_cd);
        //    }
        //    if (ws_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WS_CD         = :WS_CD        ");
        //        strSQL.Append(" OR RDT.TO_WS_CD             = :WS_CD )      ");
        //        db.DbPsetString("WS_CD", _ws_cd);
        //    }
        //    if (joc_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_JOC_CD        = :JOC_CD       ");
        //        strSQL.Append(" OR RDT.TO_JOC_CD            = :JOC_CD )     ");
        //        db.DbPsetString("JOC_CD", _joc_cd);
        //    }
        //    if (trans_date_beg != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    >= :TRANS_DATE_BEG    ");
        //        db.DbPsetInt("TRANS_DATE_BEG", _trans_date_beg);
        //    }
        //    if (trans_date_beg != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    <= :TRANS_DATE_END    ");
        //        db.DbPsetInt("TRANS_DATE_END", _trans_date_end);
        //    }

        //}
        //else
        //{
        //    db.DbParametersClear();

        //    strSQL.Append(" FROM RCV_DISB_TRANS RDT                         ");
        //    strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON          ");
        //    strSQL.Append("     S1.KEY01    =   'ITEM_UMSR'                 ");
        //    strSQL.Append(" AND S1.KEY02    =   RDT.ITEM_UMSR               ");
        //    //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON          ");
        //    //strSQL.Append("     S2.KEY01    =   'RCV_DISB_TYPE'             ");
        //    //strSQL.Append(" AND S2.KEY02    =   RDT.XFER_TEXT               ");
        //    //ADD 20090710
        //    strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON              ");
        //    strSQL.Append("     RDT.FROM_VC_CD    =   V.VENDOR_CD           ");
        //    strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON           ");
        //    strSQL.Append("     RDT.FROM_WHS_CD    =   W.WHS_CD             ");
        //    strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON           ");
        //    strSQL.Append("     RDT.FROM_WS_CD    =   WS.WS_CD              ");
        //    //strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V1 ON             ");
        //    //strSQL.Append("     RDT.TO_VC_CD    =   V1.VENDOR_CD            ");
        //    strSQL.Append(" LEFT OUTER JOIN CUSTOMER_MASTER V1 ON             ");
        //    strSQL.Append("     RDT.TO_VC_CD    =   V1.CUST_CD            ");   // 2012.01.06
        //    strSQL.Append(" AND RDT.TO_COST_CENTER  =   V1.CUST_SUB_CD            ");   // 2012.01.06
        //    strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W1 ON          ");
        //    strSQL.Append("     RDT.TO_WHS_CD    =   W1.WHS_CD              ");
        //    strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS1 ON          ");
        //    strSQL.Append("     RDT.TO_WS_CD    =   WS1.WS_CD               ");
        //    //
        //    strSQL.Append(" WHERE RDT.ITEM_NO     = @ITEM_NO                ");
        //    db.DbPsetString("@ITEM_NO", _item_no);
        //    if (_whs_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WHS_CD        = @WHS_CD       ");
        //        strSQL.Append(" OR RDT.TO_WHS_CD            = @WHS_CD )     ");
        //        db.DbPsetString("@WHS_CD", _whs_cd);
        //    }
        //    if (_ws_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_WS_CD         = @WS_CD        ");
        //        strSQL.Append(" OR RDT.TO_WS_CD             = @WS_CD )      ");
        //        db.DbPsetString("@WS_CD", _ws_cd);
        //    }
        //    if (_joc_cd != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_JOC_CD        = @JOC_CD       ");
        //        strSQL.Append(" OR RDT.TO_JOC_CD            = @JOC_CD )     ");
        //        db.DbPsetString("@JOC_CD", _joc_cd);
        //    }
        //    if (_trans_date_beg != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    >= @TRANS_DATE_BEG    ");
        //        db.DbPsetInt("@TRANS_DATE_BEG", _trans_date_beg);
        //    }
        //    if (_trans_date_end != 0)
        //    {
        //        strSQL.Append(" AND RDT.TRANS_DATE    <= @TRANS_DATE_END    ");
        //        db.DbPsetInt("@TRANS_DATE_END", _trans_date_end);
        //    }
        //    if (_location != "")
        //    {
        //        strSQL.Append(" AND (RDT.FROM_LOCATION        = @LOCATION       ");
        //        strSQL.Append(" OR RDT.TO_LOCATION            = @LOCATION )     ");
        //        db.DbPsetString("@LOCATION", _location);
        //    }
        //    //ADD 20090611 UBIQ-LIU
        //    if (_sch_type == 0)//倉庫入出庫履歴
        //    {
        //        strSQL.Append(" AND RDT.SLIP_TYPE IN ('01','02','11','12','91','92') ");
        //        strSQL.Append(" AND (RDT.REQ_TYPE    BETWEEN 11 AND 41                ");
        //        strSQL.Append(" or RDT.REQ_TYPE    = '81' )              "); //ADD BY UBIQ-SAI 2011/07/14
        //    }
        //    else//現場入出庫履歴
        //    {
        //        strSQL.Append(" AND RDT.SLIP_TYPE IN ('21','22','92')                ");
        //        strSQL.Append(" AND (RDT.REQ_TYPE    BETWEEN '62' AND '92'           ");
        //        strSQL.Append(" or RDT.REQ_TYPE    = '06' )              "); //ADD BY UBIQ-SUO 2010/12/28 BUG952
        //    }
        //}
        //strSQL.Append(" ORDER BY RDT.TRANS_DATE DESC, RDT.TRANS_TIME DESC, RDT.SLIP_TYPE ASC  ");
        //try
        //{
        //    ds = db.DbDataSet(strSQL.ToString(), "TABLE");
        //    if (ds == null)
        //    {
        //        _dbmsg = db.expmsg;
        //        _strErr = db.strErr;
        //    }
        //    if (db.State() == ConnectionState.Open)
        //        db.DbClose();

        //    return ds;
        //}
        //catch
        //{
        //    _dbmsg = db.expmsg;
        //    _strErr = db.strErr;
        //    if (db.State() == ConnectionState.Open)
        //        db.DbClose();
        //    return null;
        //}
        //}

        /// <summary>
        /// 在庫データを検索
        /// 
        /// 使用画面：InvTransInq
        /// </summary>
        public DataSet GetInvListByItem()//2008.12.08 ADD BY LIU
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                              ");
            strSQL.Append(" INV.WHS_CD,		    INV.WS_CD,		    INV.LOCATION,		INV.LOT_NO,	            ");
            strSQL.Append(" INV.JOC_CD,         INV.INV_BAL,        I.ITEM_UMSR,        S1.DATA_CHAR UMSR_NAME  ");
            strSQL.Append(" ,W.WS_DESC                                                                          ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                strSQL.Append(" FROM INVENTORY_DETAIL INV,ITEM_MASTER I         ");
                strSQL.Append(" WHERE   INV.ITEM_NO         = :ITEM_NO          ");
                strSQL.Append(" AND     INV.INV_YM          = 0                 ");
                strSQL.Append(" AND     INV.INV_TYPE        IN (0,3,4)          ");//UPD BY UBIQ-SUO 2010/12/29
                strSQL.Append(" AND     INV.ITEM_NO         = I.ITEM_NO         ");
                strSQL.Append(" AND     INV.INV_BAL         > 0                 ");//ADD 20090611 UBIQ-LIU
                db.DbPsetString("ITEM_NO", _item_no);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL INV                                               ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON INV.ITEM_NO         = I.ITEM_NO        ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON                                  ");
                strSQL.Append("     S1.KEY01    =   'ITEM_UMSR'                                         ");
                strSQL.Append(" AND S1.KEY02    =   I.ITEM_UMSR                                         ");
                //2009.08.13 add begin
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON W.WS_CD = INV.WS_CD                ");
                //2009.08.13 add end
                strSQL.Append(" WHERE   INV.ITEM_NO         = @ITEM_NO                                  ");
                strSQL.Append(" AND     INV.INV_YM          = 0                                         ");
                strSQL.Append(" AND     INV.INV_TYPE        IN (0,3,4)                                  ");//UPD BY UBIQ-SUO 2010/12/29 BUG952

                //ADD 20090611 UBIQ-LIU
                if (_sch_type == 0)//倉庫入出庫履歴
                {
                    strSQL.Append(" AND     INV.INV_WIP_TYPE    = 0                                     ");
                }
                else//現場入出庫履歴
                {
                    strSQL.Append(" AND     INV.INV_WIP_TYPE    = 1                                     ");
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND INV.WHS_CD              = @WHS_CD      ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }
                if (_location != "")
                {
                    strSQL.Append(" AND INV.LOCATION            = @LOCATION      ");
                    db.DbPsetString("@LOCATION", _location);
                }
                if (_lot_no != "")  // 2015.08.20
                {
                    strSQL.Append(" AND INV.LOT_NO            = @LOT_NO      ");
                    db.DbPsetString("@LOT_NO", _lot_no);
                }
                if (_ws_cd != "")  // 2015.08.20
                {
                    strSQL.Append(" AND (INV.WS_CD            = @WS_CD OR INV.WS_CD = '')      ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                strSQL.Append(" AND     INV.INV_BAL         > 0                                         ");//ADD 20090611 UBIQ-LIU
                db.DbPsetString("@ITEM_NO", _item_no);
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
        /// 在庫データを検索
        /// 
        /// <para>使用画面：[InvAdjReq];[InvWhsTransferReq];[SDMIFWhsTransfer]</para>
        /// </summary>
        public DataSet GetInvListByItemWhs()//2008.12.10 ADD BY CHEN
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                              ");
            strSQL.Append(" I.JOC_CD,                   I.LOT_NO,       SUM(I.INV_BAL) INV_BAL, ");
            strSQL.Append(" SUM(I.ALLOC_QTY) ALLOC_QTY, I.LOCATION,     I.SUPPLY_TYPE,          ");
            strSQL.Append(" 0 JOC_TYPE                                                          ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL I                                             ");
                strSQL.Append(" WHERE                                                               ");
                strSQL.Append(" I.INV_YM=0                                                          ");
                strSQL.Append(" AND I.INV_WIP_TYPE  =0                                              ");
                strSQL.Append(" AND I.INV_TYPE      =0                                              ");
                strSQL.Append(" AND I.ITEM_NO       =@ITEM_NO                                       ");
                strSQL.Append(" AND I.WHS_CD        =@WHS_CD                                        ");
                strSQL.Append(" AND (I.INV_BAL      <> 0                                            ");
                strSQL.Append(" OR I.ALLOC_QTY      <> 0)                                           ");
                strSQL.Append(" AND I.JOC_CD    IN                                                  "); //ADD BY UBIQ-LIU 2010/08/09
                strSQL.Append("  (SELECT DATA_CHAR FROM SYSTEM_PARAMETER                            ");
                strSQL.Append("    WHERE KEY01    ='FREE_JOC_CD'                                    ");
                strSQL.Append("      AND KEY02    = '*'                                             ");
                strSQL.Append("      AND KEY03    = '*'                                             ");
                strSQL.Append("      AND KEY04    = '*')                                            ");

                strSQL.Append(" UNION ALL                                                           ");
                strSQL.Append(" SELECT                                                              ");
                strSQL.Append(" I.JOC_CD,                   I.LOT_NO,       SUM(I.INV_BAL) INV_BAL, ");
                strSQL.Append(" SUM(I.ALLOC_QTY) ALLOC_QTY, I.LOCATION,     I.SUPPLY_TYPE,          ");
                strSQL.Append(" 1 JOC_TYPE                                                          ");
                strSQL.Append(" FROM INVENTORY_DETAIL I                                             ");
                strSQL.Append(" WHERE                                                               ");
                strSQL.Append(" I.INV_YM=0                                                          ");
                strSQL.Append(" AND I.INV_WIP_TYPE  =0                                              ");
                strSQL.Append(" AND I.INV_TYPE      =0                                              ");
                strSQL.Append(" AND I.ITEM_NO       =@ITEM_NO                                       ");
                strSQL.Append(" AND I.WHS_CD        =@WHS_CD                                        ");
                strSQL.Append(" AND (I.INV_BAL      <> 0                                            ");
                strSQL.Append("  OR I.ALLOC_QTY     <> 0)                                           ");
                strSQL.Append(" AND I.JOC_CD NOT IN                                                 ");
                strSQL.Append("  (SELECT DATA_CHAR FROM SYSTEM_PARAMETER                            ");
                strSQL.Append("    WHERE KEY01    ='FREE_JOC_CD'                                    ");
                strSQL.Append("      AND KEY02    = '*'                                             ");
                strSQL.Append("      AND KEY03    = '*'                                             ");
                strSQL.Append("      AND KEY04    = '*')                                            ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL I                                             ");
                strSQL.Append(" WHERE                                                               ");
                strSQL.Append(" I.INV_YM=0                                                          ");
                strSQL.Append(" AND I.INV_WIP_TYPE  =0                                              ");
                strSQL.Append(" AND I.INV_TYPE      =0                                              ");
                strSQL.Append(" AND I.ITEM_NO       =@ITEM_NO                                       ");
                strSQL.Append(" AND I.WHS_CD        =@WHS_CD                                        ");
                strSQL.Append(" AND (I.INV_BAL      <> 0                                            ");
                strSQL.Append(" OR I.ALLOC_QTY      <> 0)                                           ");
                strSQL.Append(" AND I.JOC_CD    IN                                                  "); //ADD BY UBIQ-LIU 2010/08/09
                strSQL.Append("  (SELECT DATA_CHAR FROM SYSTEM_PARAMETER                            ");
                strSQL.Append("    WHERE KEY01    ='FREE_JOC_CD'                                    ");
                strSQL.Append("      AND KEY02    = '*'                                             ");
                strSQL.Append("      AND KEY03    = '*'                                             ");
                strSQL.Append("      AND KEY04    = '*')                                            ");
                strSQL.Append(" GROUP BY I.JOC_CD,I.LOT_NO,I.LOCATION,I.SUPPLY_TYPE                 ");

                strSQL.Append(" UNION ALL                                                           ");
                strSQL.Append(" SELECT                                                              ");
                strSQL.Append(" I.JOC_CD,                   I.LOT_NO,       SUM(I.INV_BAL) INV_BAL, ");
                strSQL.Append(" SUM(I.ALLOC_QTY) ALLOC_QTY, I.LOCATION,     I.SUPPLY_TYPE,          ");
                strSQL.Append(" 1 JOC_TYPE                                                          ");
                strSQL.Append(" FROM INVENTORY_DETAIL I                                             ");
                strSQL.Append(" WHERE                                                               ");
                strSQL.Append(" I.INV_YM=0                                                          ");
                strSQL.Append(" AND I.INV_WIP_TYPE  =0                                              ");
                strSQL.Append(" AND I.INV_TYPE      =0                                              ");
                strSQL.Append(" AND I.ITEM_NO       =@ITEM_NO                                       ");
                strSQL.Append(" AND I.WHS_CD        =@WHS_CD                                        ");
                if (_location != "")
                    strSQL.Append(" AND I.LOCATION        =@LOCATION                                        ");  // IMV3
                strSQL.Append(" AND (I.INV_BAL      <> 0                                            ");
                strSQL.Append("  OR I.ALLOC_QTY     <> 0)                                           ");
                strSQL.Append(" AND I.JOC_CD NOT IN                                                 ");
                strSQL.Append("  (SELECT DATA_CHAR FROM SYSTEM_PARAMETER                            ");
                strSQL.Append("    WHERE KEY01    ='FREE_JOC_CD'                                    ");
                strSQL.Append("      AND KEY02    = '*'                                             ");
                strSQL.Append("      AND KEY03    = '*'                                             ");
                strSQL.Append("      AND KEY04    = '*')                                            ");
                strSQL.Append(" GROUP BY I.JOC_CD,I.LOT_NO,I.LOCATION,I.SUPPLY_TYPE                 ");
                strSQL.Append(" ORDER BY JOC_TYPE,I.JOC_CD                                          ");


                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WHS_CD", _whs_cd);
                if(_location != "")
                    db.DbPsetString("@LOCATION", _location);  // IMV3
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
        /// 在庫データを検索
        /// 
        /// 使用画面：InvStockInq
        /// 
        /// 
        ///		2009.01.18 All Change Ubiq-harada
        /// </summary>
        /// <summary>
        /// <summary>
        /// 倉庫在庫データを検索
        /// 
        /// 使用画面：InvStockInq
        /// </summary>
        public DataSet GetInvList()//2008.12.12 ADD BY CHEN
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                                      ");
            strSQL.Append(" INV.WHS_CD,     INV.ITEM_NO,            I.ITEM_DESC,        I.ITEM_TYPE,        INV.INV_BAL,");
            strSQL.Append(" INV.ALLOC_QTY,  SP.DATA_CHAR ITEM_UMSR,                                                     ");
            strSQL.Append(" CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE THEN INV.LAST_RECV_DATE                ");
            strSQL.Append(" ELSE INV.LAST_ADJ_IN_DATE END LAST_RECV_DATE,                                               ");
            strSQL.Append(" CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE THEN INV.LAST_DISB_DATE               ");
            strSQL.Append(" ELSE INV.LAST_ADJ_OUT_DATE END LAST_DISB_DATE,                                              ");
            strSQL.Append(" INV.LOCATION,   INV.LOT_NO,             INV.JOC_CD,         INV.SUPPLY_TYPE                 ");
            strSQL.Append(" ,W.WHS_DESC                                                                                 ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL I    ");
                strSQL.Append(" WHERE                      ");
                strSQL.Append(" I.INV_YM=0                 ");
                strSQL.Append(" AND I.INV_WIP_TYPE=0       ");
                strSQL.Append(" AND I.INV_TYPE=0           ");
                strSQL.Append(" AND I.ITEM_NO=:ITEM_NO     ");
                strSQL.Append(" AND I.WHS_CD=:WHS_CD       ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL INV                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON INV.ITEM_NO=I.ITEM_NO                                      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SP ON SP.KEY01 = 'ITEM_UMSR' AND SP.KEY02 = I.ITEM_UMSR    ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON INV.WHS_CD=W.WHS_CD                                   ");

                strSQL.Append(" WHERE INV.INV_YM       = 0  ");
                strSQL.Append("   AND INV.INV_WIP_TYPE = 0  ");
                strSQL.Append("   AND INV.INV_TYPE     = 0  ");
                //2009.04.14 ADD

                //update by wanghui 2010/3/18 start 在庫表示ﾌﾗｸﾞを追加して、在庫数＝０の品目も表示できるようにしてほしい。
                //strSQL.Append("   AND (INV.INV_BAL    <> 0  ");
                if (inv_bal == 0)
                {
                    strSQL.Append("   AND (INV.INV_BAL    <> 0  ");
                    strSQL.Append("   OR INV.ALLOC_QTY    <> 0) ");
                }
                //update by wanghui 2010/3/18 end 在庫表示ﾌﾗｸﾞを追加して、在庫数＝０の品目も表示できるようにしてほしい。


                if (item_no != "" && parent_item_no == "")
                {
                    strSQL.Append(" AND INV.ITEM_NO=@ITEM_NO     ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                else if (item_no != "" && parent_item_no != "")
                {
                    strSQL.Append(" AND (INV.ITEM_NO=@ITEM_NO AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                  ");
                    //strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO AND BEG_EFF_DATE >= @ACT_BEG_DATE ");
                    //strSQL.Append(" AND BEG_EFF_DATE <= @ACT_END_DATE ))                                                    ");
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO ))                                 ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);

                    //if (act_beg_date != 0)
                    //{
                    //    db.DbPsetInt("@ACT_BEG_DATE", _act_beg_date);
                    //}
                    //else
                    //{
                    //    db.DbPsetInt("@ACT_BEG_DATE", 0);
                    //}
                    //if (act_end_date != 0)
                    //{
                    //    db.DbPsetInt("@ACT_END_DATE", _act_end_date);
                    //}
                    //else
                    //{
                    //    db.DbPsetInt("@ACT_END_DATE", 99999999);
                    //}
                }
                else if (item_no == "" && parent_item_no != "")
                {
                    strSQL.Append(" AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                                           ");
                    //strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO AND BEG_EFF_DATE >= @ACT_BEG_DATE ");
                    //strSQL.Append(" AND BEG_EFF_DATE <= @ACT_END_DATE )                                                     ");
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO)                           ");

                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);

                    //if (act_beg_date != 0)
                    //{
                    //    db.DbPsetInt("@ACT_BEG_DATE", _act_beg_date);
                    //}
                    //else
                    //{
                    //    db.DbPsetInt("@ACT_BEG_DATE", 0);
                    //}
                    //if (act_end_date != 0)
                    //{
                    //    db.DbPsetInt("@ACT_END_DATE", _act_end_date);
                    //}
                    //else
                    //{
                    //    db.DbPsetInt("@ACT_END_DATE", 99999999);
                    //}
                }

                if (whs_cd != "")
                {
                    strSQL.Append(" AND INV.WHS_CD=@WHS_CD       ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }

                if (location != "")
                {
                    strSQL.Append(" AND INV.LOCATION=@LOCATION       ");
                    db.DbPsetString("@LOCATION", _location);
                }

                if (joc_cd != "")
                {
                    strSQL.Append(" AND INV.JOC_CD=@JOC_CD       ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD=@CATG_CD       ");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }

                //if (act_beg_date != 0)
                //{
                //    strSQL.Append(" AND (   (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE  ");
                //    strSQL.Append("          THEN INV.LAST_RECV_DATE                               ");
                //    strSQL.Append("          ELSE INV.LAST_ADJ_IN_DATE END) >= @ACT_BEG_DATE       ");
                //    strSQL.Append("      OR (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE ");
                //    strSQL.Append("          THEN INV.LAST_DISB_DATE                               ");
                //    strSQL.Append("          ELSE INV.LAST_ADJ_OUT_DATE END)>= @ACT_BEG_DATE       ");
                //    strSQL.Append("     )                                                          ");
                //    //strSQL.Append(" AND (INV.LAST_RECV_DATE>=@ACT_BEG_DATE      ");
                //    //strSQL.Append(" OR INV.LAST_DISB_DATE>=@ACT_BEG_DATE        ");
                //    //strSQL.Append(" OR INV.LAST_ADJ_IN_DATE>=@ACT_BEG_DATE      ");
                //    //strSQL.Append(" OR INV.LAST_ADJ_OUT_DATE>=@ACT_BEG_DATE)    ");
                //    db.DbPsetInt("@ACT_BEG_DATE", _act_beg_date);
                //}

                //if (act_end_date != 0)
                //{
                //    strSQL.Append(" AND (   (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE  ");
                //    strSQL.Append("          THEN INV.LAST_RECV_DATE                               ");
                //    strSQL.Append("          ELSE INV.LAST_ADJ_IN_DATE END) <= @ACT_END_DATE       ");
                //    strSQL.Append("      OR (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE ");
                //    strSQL.Append("          THEN INV.LAST_DISB_DATE                               ");
                //    strSQL.Append("          ELSE INV.LAST_ADJ_OUT_DATE END)<= @ACT_END_DATE       ");
                //    strSQL.Append("     )                                                          ");
                //    //strSQL.Append(" AND (INV.LAST_RECV_DATE<=@ACT_END_DATE      ");
                //    //strSQL.Append(" OR INV.LAST_DISB_DATE<=@ACT_END_DATE        ");
                //    //strSQL.Append(" OR INV.LAST_ADJ_IN_DATE<=@ACT_END_DATE      ");
                //    //strSQL.Append(" OR INV.LAST_ADJ_OUT_DATE<=@ACT_END_DATE)    ");
                //    db.DbPsetInt("@ACT_END_DATE", _act_end_date);
                //}

                if (act_end_date == 0)
                {
                    act_end_date = 99999999;
                }

                strSQL.Append(" AND (                                                                 ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) >= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) <= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     OR                                                                ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)>= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)<= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     )                                                                   ");

                db.DbPsetInt("@ACT_BEG_DATE", _act_beg_date);
                db.DbPsetInt("@ACT_END_DATE", _act_end_date);

                if (po_prc != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                       ");
                    //UPD 2009.07.01
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)) ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)))");
                    strSQL.Append(" >=@PO_PRC                                                           ");

                    db.DbPsetDouble("@PO_PRC", _po_prc);
                }
                if (std_amt != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                                       ");
                    //UPD 2009.07.01
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))                 ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))) * INV.INV_BAL  ");
                    strSQL.Append(" >=@STD_AMT                                                                          ");

                    db.DbPsetDouble("@STD_AMT", _std_amt);
                }
            }

            strSQL.Append(" ORDER BY ");
            strSQL.Append(" INV.WHS_CD,INV.ITEM_NO,INV.LOCATION,INV.JOC_CD,INV.LOT_NO ");

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

        //-->ADD BY UBIQ-SUO 2011/1/7
        /// <summary>
        /// 在庫データを検索    
        /// </summary>
        /// <summary>
        /// <summary>
        /// 品目コード・倉庫コードのラジオボタン選択時倉庫在庫データを検索
        /// 
        /// 使用画面：InvStockInq
        /// </summary>
        public DataSet GetItemWhsInvSumList()
        {
            DataSet ds = new DataSet();
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();            

            //--- sql
            strSQL.Append(" SELECT INV1.WHS_CD,INV1.ITEM_NO,INV1.ITEM_DESC,INV1.ITEM_TYPE,INV1.INV_BAL,INV1.ALLOC_QTY,INV1.ITEM_UMSR,");
            strSQL.Append(" INV2.LAST_RECV_DATE,INV2.LAST_DISB_DATE, ");
            strSQL.Append(" '' LOCATION,  '' LOT_NO,             '' JOC_CD,         '' SUPPLY_TYPE                 ");
            strSQL.Append(" ,'' WHS_DESC                           FROM                                                      ");
            strSQL.Append(" (SELECT                                                                                     ");
            strSQL.Append(" INV.WHS_CD, INV.ITEM_NO,            I.ITEM_DESC,        I.ITEM_TYPE,  ");
            strSQL.Append(" SUM(INV.INV_BAL) INV_BAL,SUM(INV.ALLOC_QTY) ALLOC_QTY,  SP.DATA_CHAR ITEM_UMSR             ");          
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL I    ");
                strSQL.Append(" WHERE                      ");
                strSQL.Append(" I.INV_YM=0                 ");
                strSQL.Append(" AND I.INV_WIP_TYPE=0       ");
                strSQL.Append(" AND I.INV_TYPE=0           ");
                strSQL.Append(" AND I.ITEM_NO=:ITEM_NO     ");
                strSQL.Append(" AND I.WHS_CD=:WHS_CD       ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL INV                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON INV.ITEM_NO=I.ITEM_NO                                      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SP ON SP.KEY01 = 'ITEM_UMSR' AND SP.KEY02 = I.ITEM_UMSR    ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON INV.WHS_CD=W.WHS_CD                                   ");

                strSQL.Append(" WHERE INV.INV_YM       = 0  ");
                strSQL.Append("   AND INV.INV_WIP_TYPE = 0  ");
                strSQL.Append("   AND INV.INV_TYPE     = 0  ");
               
                if (inv_bal == 0)
                {
                    strSQL.Append("   AND (INV.INV_BAL    <> 0  ");
                    strSQL.Append("   OR INV.ALLOC_QTY    <> 0) ");
                }               

                if (item_no != "" && parent_item_no == "")
                {
                    strSQL.Append(" AND INV.ITEM_NO=@ITEM_NO     ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                else if (item_no != "" && parent_item_no != "")
                {
                    strSQL.Append(" AND (INV.ITEM_NO=@ITEM_NO AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                  ");                    
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO ))                                 ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                }
                else if (item_no == "" && parent_item_no != "")
                {
                    strSQL.Append(" AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                                           ");                   
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO)                           ");

                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                }

                if (whs_cd != "")
                {
                    strSQL.Append(" AND INV.WHS_CD=@WHS_CD       ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }

                if (location != "")
                {
                    strSQL.Append(" AND INV.LOCATION=@LOCATION       ");
                    db.DbPsetString("@LOCATION", _location);
                }

                if (joc_cd != "")
                {
                    strSQL.Append(" AND INV.JOC_CD=@JOC_CD       ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD=@CATG_CD       ");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }
              
                if (act_end_date == 0)
                {
                    act_end_date = 99999999;
                }

                strSQL.Append(" AND (                                                                 ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) >= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) <= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     OR                                                                ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)>= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)<= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     )                                                                   ");

                db.DbPsetInt("@ACT_BEG_DATE", _act_beg_date);
                db.DbPsetInt("@ACT_END_DATE", _act_end_date);

                if (po_prc != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                       ");                   
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)) ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)))");
                    strSQL.Append(" >=@PO_PRC                                                           ");

                    db.DbPsetDouble("@PO_PRC", _po_prc);
                }
                if (std_amt != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                                       ");                   
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))                 ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))) * INV.INV_BAL  ");
                    strSQL.Append(" >=@STD_AMT                                                                          ");

                    db.DbPsetDouble("@STD_AMT", _std_amt);
                }
            }
            strSQL.Append(" GROUP BY ");
            strSQL.Append(" INV.WHS_CD, INV.ITEM_NO, I.ITEM_DESC, I.ITEM_TYPE,  SP.DATA_CHAR) INV1");

            strSQL.Append(" INNER JOIN ");

            strSQL.Append(" (SELECT                                                                                     ");
            strSQL.Append(" INV.WHS_CD,  INV.ITEM_NO,            I.ITEM_DESC,        I.ITEM_TYPE,  ");
            strSQL.Append(" SP.DATA_CHAR ITEM_UMSR, MAX(INV.LAST_RECV_DATE) LAST_RECV_DATE, ");
            strSQL.Append(" MAX(INV.LAST_DISB_DATE) LAST_DISB_DATE ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL I    ");
                strSQL.Append(" WHERE                      ");
                strSQL.Append(" I.INV_YM=0                 ");
                strSQL.Append(" AND I.INV_WIP_TYPE=0       ");
                strSQL.Append(" AND I.INV_TYPE=0           ");
                strSQL.Append(" AND I.ITEM_NO=:ITEM_NO     ");
                strSQL.Append(" AND I.WHS_CD=:WHS_CD       ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL INV                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON INV.ITEM_NO=I.ITEM_NO                                      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SP ON SP.KEY01 = 'ITEM_UMSR' AND SP.KEY02 = I.ITEM_UMSR    ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON INV.WHS_CD=W.WHS_CD                                   ");

                strSQL.Append(" WHERE INV.INV_YM       = 0  ");
                strSQL.Append("   AND INV.INV_WIP_TYPE = 0  ");
                strSQL.Append("   AND INV.INV_TYPE     = 0  ");

                if (inv_bal == 0)
                {
                    strSQL.Append("   AND (INV.INV_BAL    <> 0  ");
                    strSQL.Append("   OR INV.ALLOC_QTY    <> 0) ");
                }

                if (item_no != "" && parent_item_no == "")
                {
                    strSQL.Append(" AND INV.ITEM_NO=@ITEM_NO     ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                else if (item_no != "" && parent_item_no != "")
                {
                    strSQL.Append(" AND (INV.ITEM_NO=@ITEM_NO AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                  ");
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO ))                                 ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                }
                else if (item_no == "" && parent_item_no != "")
                {
                    strSQL.Append(" AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                                           ");
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO)                           ");

                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                }

                if (whs_cd != "")
                {
                    strSQL.Append(" AND INV.WHS_CD=@WHS_CD       ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }

                if (location != "")
                {
                    strSQL.Append(" AND INV.LOCATION=@LOCATION       ");
                    db.DbPsetString("@LOCATION", _location);
                }

                if (joc_cd != "")
                {
                    strSQL.Append(" AND INV.JOC_CD=@JOC_CD       ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD=@CATG_CD       ");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }

                if (act_end_date == 0)
                {
                    act_end_date = 99999999;
                }

                strSQL.Append(" AND (                                                                 ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) >= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) <= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     OR                                                                ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)>= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)<= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     )                                                                   ");

                db.DbPsetInt("@ACT_BEG_DATE", _act_beg_date);
                db.DbPsetInt("@ACT_END_DATE", _act_end_date);

                if (po_prc != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                       ");
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)) ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)))");
                    strSQL.Append(" >=@PO_PRC                                                           ");

                    db.DbPsetDouble("@PO_PRC", _po_prc);
                }
                if (std_amt != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                                       ");
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))                 ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))) * INV.INV_BAL  ");
                    strSQL.Append(" >=@STD_AMT                                                                          ");

                    db.DbPsetDouble("@STD_AMT", _std_amt);
                }
            }

            strSQL.Append(" GROUP BY ");
            strSQL.Append(" INV.WHS_CD, INV.ITEM_NO, I.ITEM_DESC, I.ITEM_TYPE,  SP.DATA_CHAR) INV2");
            strSQL.Append(" ON INV1.WHS_CD = INV2.WHS_CD");
            strSQL.Append(" AND INV1.ITEM_NO = INV2.ITEM_NO");
            strSQL.Append(" ORDER BY WHS_CD,ITEM_NO");

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
        //<--ADD BY UBIQ-SUO 2011/1/7

        //-->ADD BY UBIQ-SUO 2011/1/7
        /// <summary>
        /// 在庫データを検索    
        /// </summary>
        /// <summary>
        /// <summary>
        /// 品目コードのラジオボタン選択時倉庫在庫データを検索
        /// 
        /// 使用画面：InvStockInq
        /// </summary>
        public DataSet GetItemInvSumList()
        {
            DataSet ds = new DataSet();
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();            

            //--- sql
            strSQL.Append(" SELECT '' WHS_CD,INV1.ITEM_NO,INV1.ITEM_DESC,INV1.ITEM_TYPE,INV1.INV_BAL,INV1.ALLOC_QTY,INV1.ITEM_UMSR,");
            strSQL.Append(" INV2.LAST_RECV_DATE,INV2.LAST_DISB_DATE, ");
            strSQL.Append(" '' LOCATION,  '' LOT_NO,             '' JOC_CD,         '' SUPPLY_TYPE                 ");
            strSQL.Append(" ,'' WHS_DESC                           FROM                                                      ");
            strSQL.Append(" (SELECT                                                                                     ");
            strSQL.Append(" INV.ITEM_NO,            I.ITEM_DESC,        I.ITEM_TYPE,  ");
            strSQL.Append(" SUM(INV.INV_BAL) INV_BAL,SUM(INV.ALLOC_QTY) ALLOC_QTY,  SP.DATA_CHAR ITEM_UMSR             ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL I    ");
                strSQL.Append(" WHERE                      ");
                strSQL.Append(" I.INV_YM=0                 ");
                strSQL.Append(" AND I.INV_WIP_TYPE=0       ");
                strSQL.Append(" AND I.INV_TYPE=0           ");
                strSQL.Append(" AND I.ITEM_NO=:ITEM_NO     ");
                strSQL.Append(" AND I.WHS_CD=:WHS_CD       ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL INV                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON INV.ITEM_NO=I.ITEM_NO                                      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SP ON SP.KEY01 = 'ITEM_UMSR' AND SP.KEY02 = I.ITEM_UMSR    ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON INV.WHS_CD=W.WHS_CD                                   ");

                strSQL.Append(" WHERE INV.INV_YM       = 0  ");
                strSQL.Append("   AND INV.INV_WIP_TYPE = 0  ");
                strSQL.Append("   AND INV.INV_TYPE     = 0  ");

                if (inv_bal == 0)
                {
                    strSQL.Append("   AND (INV.INV_BAL    <> 0  ");
                    strSQL.Append("   OR INV.ALLOC_QTY    <> 0) ");
                }

                if (item_no != "" && parent_item_no == "")
                {
                    strSQL.Append(" AND INV.ITEM_NO=@ITEM_NO     ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                else if (item_no != "" && parent_item_no != "")
                {
                    strSQL.Append(" AND (INV.ITEM_NO=@ITEM_NO AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                  ");
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO ))                                 ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                }
                else if (item_no == "" && parent_item_no != "")
                {
                    strSQL.Append(" AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                                           ");
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO)                           ");

                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                }

                if (whs_cd != "")
                {
                    strSQL.Append(" AND INV.WHS_CD=@WHS_CD       ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }

                if (location != "")
                {
                    strSQL.Append(" AND INV.LOCATION=@LOCATION       ");
                    db.DbPsetString("@LOCATION", _location);
                }

                if (joc_cd != "")
                {
                    strSQL.Append(" AND INV.JOC_CD=@JOC_CD       ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD=@CATG_CD       ");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }

                if (act_end_date == 0)
                {
                    act_end_date = 99999999;
                }

                strSQL.Append(" AND (                                                                 ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) >= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) <= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     OR                                                                ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)>= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)<= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     )                                                                   ");

                db.DbPsetInt("@ACT_BEG_DATE", _act_beg_date);
                db.DbPsetInt("@ACT_END_DATE", _act_end_date);

                if (po_prc != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                       ");
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)) ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)))");
                    strSQL.Append(" >=@PO_PRC                                                           ");

                    db.DbPsetDouble("@PO_PRC", _po_prc);
                }
                if (std_amt != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                                       ");
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))                 ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))) * INV.INV_BAL  ");
                    strSQL.Append(" >=@STD_AMT                                                                          ");

                    db.DbPsetDouble("@STD_AMT", _std_amt);
                }
            }
            strSQL.Append(" GROUP BY ");
            strSQL.Append(" INV.ITEM_NO, I.ITEM_DESC, I.ITEM_TYPE,  SP.DATA_CHAR) INV1");

            strSQL.Append(" INNER JOIN ");

            strSQL.Append(" (SELECT                                                                                     ");
            strSQL.Append(" INV.ITEM_NO,            I.ITEM_DESC,        I.ITEM_TYPE,  ");
            strSQL.Append(" SP.DATA_CHAR ITEM_UMSR, MAX(INV.LAST_RECV_DATE) LAST_RECV_DATE, ");
            strSQL.Append(" MAX(INV.LAST_DISB_DATE) LAST_DISB_DATE ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL I    ");
                strSQL.Append(" WHERE                      ");
                strSQL.Append(" I.INV_YM=0                 ");
                strSQL.Append(" AND I.INV_WIP_TYPE=0       ");
                strSQL.Append(" AND I.INV_TYPE=0           ");
                strSQL.Append(" AND I.ITEM_NO=:ITEM_NO     ");
                strSQL.Append(" AND I.WHS_CD=:WHS_CD       ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL INV                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON INV.ITEM_NO=I.ITEM_NO                                      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SP ON SP.KEY01 = 'ITEM_UMSR' AND SP.KEY02 = I.ITEM_UMSR    ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON INV.WHS_CD=W.WHS_CD                                   ");

                strSQL.Append(" WHERE INV.INV_YM       = 0  ");
                strSQL.Append("   AND INV.INV_WIP_TYPE = 0  ");
                strSQL.Append("   AND INV.INV_TYPE     = 0  ");

                if (inv_bal == 0)
                {
                    strSQL.Append("   AND (INV.INV_BAL    <> 0  ");
                    strSQL.Append("   OR INV.ALLOC_QTY    <> 0) ");
                }

                if (item_no != "" && parent_item_no == "")
                {
                    strSQL.Append(" AND INV.ITEM_NO=@ITEM_NO     ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                else if (item_no != "" && parent_item_no != "")
                {
                    strSQL.Append(" AND (INV.ITEM_NO=@ITEM_NO AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                  ");
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO ))                                 ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                }
                else if (item_no == "" && parent_item_no != "")
                {
                    strSQL.Append(" AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                                           ");
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO)                           ");

                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                }

                if (whs_cd != "")
                {
                    strSQL.Append(" AND INV.WHS_CD=@WHS_CD       ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }

                if (location != "")
                {
                    strSQL.Append(" AND INV.LOCATION=@LOCATION       ");
                    db.DbPsetString("@LOCATION", _location);
                }

                if (joc_cd != "")
                {
                    strSQL.Append(" AND INV.JOC_CD=@JOC_CD       ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD=@CATG_CD       ");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }

                if (act_end_date == 0)
                {
                    act_end_date = 99999999;
                }

                strSQL.Append(" AND (                                                                 ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) >= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) <= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     OR                                                                ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)>= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)<= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     )                                                                   ");

                db.DbPsetInt("@ACT_BEG_DATE", _act_beg_date);
                db.DbPsetInt("@ACT_END_DATE", _act_end_date);

                if (po_prc != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                       ");
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)) ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)))");
                    strSQL.Append(" >=@PO_PRC                                                           ");

                    db.DbPsetDouble("@PO_PRC", _po_prc);
                }
                if (std_amt != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                                       ");
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))                 ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))) * INV.INV_BAL  ");
                    strSQL.Append(" >=@STD_AMT                                                                          ");

                    db.DbPsetDouble("@STD_AMT", _std_amt);
                }
            }

            strSQL.Append(" GROUP BY ");
            strSQL.Append(" INV.ITEM_NO, I.ITEM_DESC, I.ITEM_TYPE,  SP.DATA_CHAR) INV2");
            strSQL.Append(" ON INV1.ITEM_NO = INV2.ITEM_NO");
            strSQL.Append(" ORDER BY ITEM_NO");

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
        //<--ADD BY UBIQ-SUO 2011/1/7

        /// <summary>
        /// 在庫データを検索
        /// 
        /// 使用画面：InvStockInq       
        /// 現場在庫データを検索
        /// 
        /// 使用画面：InvStockInq
        /// </summary>
        public DataSet GetWipList()//2008.12.12 ADD BY CHEN
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                                      ");
            strSQL.Append(" INV.WS_CD,      INV.WHS_CD,     INV.ITEM_NO,            I.ITEM_DESC,        I.ITEM_TYPE,    ");
            strSQL.Append(" INV.INV_BAL,    INV.ALLOC_QTY,  SP.DATA_CHAR ITEM_UMSR,                                     ");
            strSQL.Append(" CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE THEN INV.LAST_RECV_DATE                ");
            strSQL.Append(" ELSE INV.LAST_ADJ_IN_DATE END LAST_RECV_DATE,                                               ");
            strSQL.Append(" CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE THEN INV.LAST_DISB_DATE               ");
            strSQL.Append(" ELSE INV.LAST_ADJ_OUT_DATE END LAST_DISB_DATE, '' PROCESS_CD, '' PROCESS_DESC,'' INV_TYPE,  ");
            strSQL.Append(" INV.LOT_NO,     INV.JOC_CD,     INV.SUPPLY_TYPE,        W.WHS_DESC,         WS.WS_DESC      ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL I    ");
                strSQL.Append(" WHERE                      ");
                strSQL.Append(" I.INV_YM=0                 ");
                strSQL.Append(" AND I.INV_WIP_TYPE=1       ");
                strSQL.Append(" AND I.INV_TYPE=0           ");
                strSQL.Append(" AND I.ITEM_NO=:ITEM_NO     ");
                strSQL.Append(" AND I.WHS_CD=:WHS_CD       ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL INV                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON INV.ITEM_NO=I.ITEM_NO                                      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SP ON SP.KEY01 = 'ITEM_UMSR' AND SP.KEY02 = I.ITEM_UMSR    ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON INV.WHS_CD=W.WHS_CD                                   ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON INV.WS_CD=WS.WS_CD                                    ");

                strSQL.Append(" WHERE INV.INV_YM       = 0  ");
                strSQL.Append("   AND INV.INV_WIP_TYPE = 1  ");
                strSQL.Append("   AND INV.INV_TYPE     = 0  ");
                //2009.04.14 ADD 
                strSQL.Append("   AND (INV.INV_BAL    <> 0  ");
                strSQL.Append("   OR INV.ALLOC_QTY    <> 0) ");

                if (item_no != "" && parent_item_no == "")
                {
                    strSQL.Append(" AND INV.ITEM_NO=@ITEM_NO     ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                else if (item_no != "" && parent_item_no != "")
                {
                    strSQL.Append(" AND (INV.ITEM_NO=@ITEM_NO AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                  ");
                    //strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO AND BEG_EFF_DATE >= @ACT_BEG_DATE ");
                    //strSQL.Append(" AND BEG_EFF_DATE <= @ACT_END_DATE ))                                                    ");
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO ))                                 ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);

                    //if (act_beg_date != 0)
                    //{
                    //    db.DbPsetInt("@ACT_BEG_DATE", _act_beg_date);
                    //}
                    //else
                    //{
                    //    db.DbPsetInt("@ACT_BEG_DATE", 0);
                    //}
                    //if (act_end_date != 0)
                    //{
                    //    db.DbPsetInt("@ACT_END_DATE", _act_end_date);
                    //}
                    //else
                    //{
                    //    db.DbPsetInt("@ACT_END_DATE", 99999999);
                    //}
                }
                else if (item_no == "" && parent_item_no != "")
                {
                    strSQL.Append(" AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                                           ");
                    //strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO AND BEG_EFF_DATE >= @ACT_BEG_DATE ");
                    //strSQL.Append(" AND BEG_EFF_DATE <= @ACT_END_DATE )                                                     ");
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO )                                 ");
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);

                    //if (act_beg_date != 0)
                    //{
                    //    db.DbPsetInt("@ACT_BEG_DATE", _act_beg_date);
                    //}
                    //else
                    //{
                    //    db.DbPsetInt("@ACT_BEG_DATE", 0);
                    //}
                    //if (act_end_date != 0)
                    //{
                    //    db.DbPsetInt("@ACT_END_DATE", _act_end_date);
                    //}
                    //else
                    //{
                    //    db.DbPsetInt("@ACT_END_DATE", 99999999);
                    //}
                }

                if (whs_cd != "")
                {
                    strSQL.Append(" AND INV.WHS_CD=@WHS_CD       ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }

                if (ws_cd != "")
                {
                    strSQL.Append(" AND INV.WS_CD=@WS_CD       ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (joc_cd != "")
                {
                    strSQL.Append(" AND INV.JOC_CD=@JOC_CD       ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD=@CATG_CD       ");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }

                //if (act_beg_date != 0)
                //{
                //    strSQL.Append(" AND (INV.LAST_RECV_DATE>=@ACT_BEG_DATE      ");
                //    strSQL.Append(" OR INV.LAST_DISB_DATE>=@ACT_BEG_DATE        ");
                //    strSQL.Append(" OR INV.LAST_ADJ_IN_DATE>=@ACT_BEG_DATE      ");
                //    strSQL.Append(" OR INV.LAST_ADJ_OUT_DATE>=@ACT_BEG_DATE)    ");
                //    //if (parent_item_no == "")
                //    //{
                //    db.DbPsetInt("@ACT_BEG_DATE", _act_beg_date);
                //    //}
                //}

                //if (act_end_date != 0)
                //{
                //    strSQL.Append(" AND (INV.LAST_RECV_DATE<=@ACT_END_DATE      ");
                //    strSQL.Append(" OR INV.LAST_DISB_DATE<=@ACT_END_DATE        ");
                //    strSQL.Append(" OR INV.LAST_ADJ_IN_DATE<=@ACT_END_DATE      ");
                //    strSQL.Append(" OR INV.LAST_ADJ_OUT_DATE<=@ACT_END_DATE)    ");
                //    //if (parent_item_no == "")
                //    //{
                //    db.DbPsetInt("@ACT_END_DATE", _act_end_date);
                //    //}
                //}

                if (act_end_date == 0)
                {
                    act_end_date = 99999999;
                }

                strSQL.Append(" AND (                                                                 ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) >= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) <= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     OR                                                                ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)>= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)<= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     )                                                                   ");

                db.DbPsetInt("@ACT_BEG_DATE", _act_beg_date);
                db.DbPsetInt("@ACT_END_DATE", _act_end_date);

                if (po_prc != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                       ");
                    //UPD 2009.07.01
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)) ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)))");
                    strSQL.Append(" >=@PO_PRC                                                           ");

                    db.DbPsetDouble("@PO_PRC", _po_prc);
                }
                if (std_amt != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                                       ");
                    //UPD 2009.07.01
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))                 ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))) * INV.INV_BAL  ");
                    strSQL.Append(" >=@STD_AMT                                                                          ");

                    db.DbPsetDouble("@STD_AMT", _std_amt);
                }
            }

            strSQL.Append(" ORDER BY ");
            strSQL.Append(" INV.WS_CD,INV.WHS_CD,INV.ITEM_NO,INV.JOC_CD,INV.LOT_NO ");

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

        //-->ADD BY UBIQ-SUO 2011/1/7
        /// <summary>
        /// 在庫データを検索
        /// 
        /// 使用画面：InvStockInq       
        /// 品目コードのラジオボタン選択時現場在庫データを検索
        /// 
        /// 使用画面：InvStockInq
        /// </summary>
        public DataSet GetItemWipSumList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT '' WS_CD,'' WS_DESC,'' WHS_CD,INV1.ITEM_NO,INV1.ITEM_DESC,INV1.ITEM_TYPE,INV1.INV_BAL,INV1.ALLOC_QTY,INV1.ITEM_UMSR, ");
            strSQL.Append(" INV2.LAST_RECV_DATE,INV2.LAST_DISB_DATE, '' PROCESS_CD, '' PROCESS_DESC,");
            strSQL.Append(" '' LOT_NO,     '' JOC_CD,     '' SUPPLY_TYPE,        '' WHS_DESC,'' INV_TYPE  FROM");
            strSQL.Append(" (SELECT                                                                            ");
            strSQL.Append(" INV.ITEM_NO,            I.ITEM_DESC,        I.ITEM_TYPE,    ");
            strSQL.Append(" SUM(INV.INV_BAL) INV_BAL,    SUM(INV.ALLOC_QTY) ALLOC_QTY,  SP.DATA_CHAR ITEM_UMSR ");            
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL I    ");
                strSQL.Append(" WHERE                      ");
                strSQL.Append(" I.INV_YM=0                 ");
                strSQL.Append(" AND I.INV_WIP_TYPE=1       ");
                strSQL.Append(" AND I.INV_TYPE=0           ");
                strSQL.Append(" AND I.ITEM_NO=:ITEM_NO     ");
                strSQL.Append(" AND I.WHS_CD=:WHS_CD       ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL INV                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON INV.ITEM_NO=I.ITEM_NO                                      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SP ON SP.KEY01 = 'ITEM_UMSR' AND SP.KEY02 = I.ITEM_UMSR    ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON INV.WHS_CD=W.WHS_CD                                   ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON INV.WS_CD=WS.WS_CD                                    ");

                strSQL.Append(" WHERE INV.INV_YM       = 0  ");
                strSQL.Append("   AND INV.INV_WIP_TYPE = 1  ");
                strSQL.Append("   AND INV.INV_TYPE     = 0  ");               
                strSQL.Append("   AND (INV.INV_BAL    <> 0  ");
                strSQL.Append("   OR INV.ALLOC_QTY    <> 0) ");

                if (item_no != "" && parent_item_no == "")
                {
                    strSQL.Append(" AND INV.ITEM_NO=@ITEM_NO     ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                else if (item_no != "" && parent_item_no != "")
                {
                    strSQL.Append(" AND (INV.ITEM_NO=@ITEM_NO AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                  ");                   
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO ))                                 ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                    
                }
                else if (item_no == "" && parent_item_no != "")
                {
                    strSQL.Append(" AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                                           ");                    
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO )                                 ");
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);                  
                }

                if (whs_cd != "")
                {
                    strSQL.Append(" AND INV.WHS_CD=@WHS_CD       ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }

                if (ws_cd != "")
                {
                    strSQL.Append(" AND INV.WS_CD=@WS_CD       ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (joc_cd != "")
                {
                    strSQL.Append(" AND INV.JOC_CD=@JOC_CD       ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD=@CATG_CD       ");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }               
                if (act_end_date == 0)
                {
                    act_end_date = 99999999;
                }

                strSQL.Append(" AND (                                                                 ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) >= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) <= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     OR                                                                ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)>= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)<= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     )                                                                   ");

                db.DbPsetInt("@ACT_BEG_DATE", _act_beg_date);
                db.DbPsetInt("@ACT_END_DATE", _act_end_date);

                if (po_prc != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                       ");                    
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)) ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)))");
                    strSQL.Append(" >=@PO_PRC                                                           ");

                    db.DbPsetDouble("@PO_PRC", _po_prc);
                }
                if (std_amt != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                                       ");                   
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))                 ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))) * INV.INV_BAL  ");
                    strSQL.Append(" >=@STD_AMT                                                                          ");

                    db.DbPsetDouble("@STD_AMT", _std_amt);
                }
            }

            strSQL.Append(" GROUP BY ");
            strSQL.Append(" INV.ITEM_NO, I.ITEM_DESC, I.ITEM_TYPE, SP.DATA_CHAR) INV1 ");

            strSQL.Append(" INNER JOIN  ");

            strSQL.Append(" (SELECT                                                                            ");
            strSQL.Append(" INV.ITEM_NO,            I.ITEM_DESC,        I.ITEM_TYPE,    ");
            strSQL.Append(" SP.DATA_CHAR ITEM_UMSR, MAX(INV.LAST_RECV_DATE) LAST_RECV_DATE, MAX(INV.LAST_DISB_DATE) LAST_DISB_DATE ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL I    ");
                strSQL.Append(" WHERE                      ");
                strSQL.Append(" I.INV_YM=0                 ");
                strSQL.Append(" AND I.INV_WIP_TYPE=1       ");
                strSQL.Append(" AND I.INV_TYPE=0           ");
                strSQL.Append(" AND I.ITEM_NO=:ITEM_NO     ");
                strSQL.Append(" AND I.WHS_CD=:WHS_CD       ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL INV                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON INV.ITEM_NO=I.ITEM_NO                                      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SP ON SP.KEY01 = 'ITEM_UMSR' AND SP.KEY02 = I.ITEM_UMSR    ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON INV.WHS_CD=W.WHS_CD                                   ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON INV.WS_CD=WS.WS_CD                                    ");

                strSQL.Append(" WHERE INV.INV_YM       = 0  ");
                strSQL.Append("   AND INV.INV_WIP_TYPE = 1  ");
                strSQL.Append("   AND INV.INV_TYPE     = 0  ");
                strSQL.Append("   AND (INV.INV_BAL    <> 0  ");
                strSQL.Append("   OR INV.ALLOC_QTY    <> 0) ");

                if (item_no != "" && parent_item_no == "")
                {
                    strSQL.Append(" AND INV.ITEM_NO=@ITEM_NO     ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                else if (item_no != "" && parent_item_no != "")
                {
                    strSQL.Append(" AND (INV.ITEM_NO=@ITEM_NO AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                  ");
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO ))                                 ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);

                }
                else if (item_no == "" && parent_item_no != "")
                {
                    strSQL.Append(" AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                                           ");
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO )                                 ");
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                }

                if (whs_cd != "")
                {
                    strSQL.Append(" AND INV.WHS_CD=@WHS_CD       ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }

                if (ws_cd != "")
                {
                    strSQL.Append(" AND INV.WS_CD=@WS_CD       ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (joc_cd != "")
                {
                    strSQL.Append(" AND INV.JOC_CD=@JOC_CD       ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD=@CATG_CD       ");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }
                if (act_end_date == 0)
                {
                    act_end_date = 99999999;
                }

                strSQL.Append(" AND (                                                                 ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) >= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) <= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     OR                                                                ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)>= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)<= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     )                                                                   ");

                db.DbPsetInt("@ACT_BEG_DATE", _act_beg_date);
                db.DbPsetInt("@ACT_END_DATE", _act_end_date);

                if (po_prc != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                       ");
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)) ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)))");
                    strSQL.Append(" >=@PO_PRC                                                           ");

                    db.DbPsetDouble("@PO_PRC", _po_prc);
                }
                if (std_amt != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                                       ");
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))                 ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))) * INV.INV_BAL  ");
                    strSQL.Append(" >=@STD_AMT                                                                          ");

                    db.DbPsetDouble("@STD_AMT", _std_amt);
                }
            }

            strSQL.Append(" GROUP BY ");
            strSQL.Append(" INV.ITEM_NO, I.ITEM_DESC, I.ITEM_TYPE, SP.DATA_CHAR) INV2 ");
            strSQL.Append(" ON  INV1.ITEM_NO = INV2.ITEM_NO");
            strSQL.Append(" ORDER BY ITEM_NO");

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
        /// 在庫データを検索
        /// 
        /// 使用画面：InvStockInq       
        /// 品目コード・作業区コードのラジオボタン選択時現場在庫データを検索
        /// 
        /// 使用画面：InvStockInq
        /// </summary>
        public DataSet GetItemWsWipSumList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT  INV1.WS_CD, INV1.WS_DESC, '' WHS_CD,INV1.ITEM_NO,INV1.ITEM_DESC,INV1.ITEM_TYPE,INV1.INV_BAL,INV1.ALLOC_QTY,INV1.ITEM_UMSR, ");
            strSQL.Append(" INV2.LAST_RECV_DATE,INV2.LAST_DISB_DATE, '' PROCESS_CD, '' PROCESS_DESC, ");
            strSQL.Append(" '' LOT_NO,     '' JOC_CD,     '' SUPPLY_TYPE,        '' WHS_DESC,'' INV_TYPE  FROM");
            strSQL.Append(" (SELECT                                                                            ");
            strSQL.Append(" INV.WS_CD, WS.WS_DESC,  INV.ITEM_NO,            I.ITEM_DESC,        I.ITEM_TYPE,    ");
            strSQL.Append(" SUM(INV.INV_BAL) INV_BAL,    SUM(INV.ALLOC_QTY) ALLOC_QTY,  SP.DATA_CHAR ITEM_UMSR ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL I    ");
                strSQL.Append(" WHERE                      ");
                strSQL.Append(" I.INV_YM=0                 ");
                strSQL.Append(" AND I.INV_WIP_TYPE=1       ");
                strSQL.Append(" AND I.INV_TYPE=0           ");
                strSQL.Append(" AND I.ITEM_NO=:ITEM_NO     ");
                strSQL.Append(" AND I.WHS_CD=:WHS_CD       ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL INV                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON INV.ITEM_NO=I.ITEM_NO                                      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SP ON SP.KEY01 = 'ITEM_UMSR' AND SP.KEY02 = I.ITEM_UMSR    ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON INV.WHS_CD=W.WHS_CD                                   ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON INV.WS_CD=WS.WS_CD                                    ");

                strSQL.Append(" WHERE INV.INV_YM       = 0  ");
                strSQL.Append("   AND INV.INV_WIP_TYPE = 1  ");
                strSQL.Append("   AND INV.INV_TYPE     = 0  ");
                strSQL.Append("   AND (INV.INV_BAL    <> 0  ");
                strSQL.Append("   OR INV.ALLOC_QTY    <> 0) ");

                if (item_no != "" && parent_item_no == "")
                {
                    strSQL.Append(" AND INV.ITEM_NO=@ITEM_NO     ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                else if (item_no != "" && parent_item_no != "")
                {
                    strSQL.Append(" AND (INV.ITEM_NO=@ITEM_NO AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                  ");
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO ))                                 ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);

                }
                else if (item_no == "" && parent_item_no != "")
                {
                    strSQL.Append(" AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                                           ");
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO )                                 ");
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                }

                if (whs_cd != "")
                {
                    strSQL.Append(" AND INV.WHS_CD=@WHS_CD       ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }

                if (ws_cd != "")
                {
                    strSQL.Append(" AND INV.WS_CD=@WS_CD       ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (joc_cd != "")
                {
                    strSQL.Append(" AND INV.JOC_CD=@JOC_CD       ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD=@CATG_CD       ");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }
                if (act_end_date == 0)
                {
                    act_end_date = 99999999;
                }

                strSQL.Append(" AND (                                                                 ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) >= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) <= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     OR                                                                ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)>= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)<= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     )                                                                   ");

                db.DbPsetInt("@ACT_BEG_DATE", _act_beg_date);
                db.DbPsetInt("@ACT_END_DATE", _act_end_date);

                if (po_prc != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                       ");
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)) ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)))");
                    strSQL.Append(" >=@PO_PRC                                                           ");

                    db.DbPsetDouble("@PO_PRC", _po_prc);
                }
                if (std_amt != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                                       ");
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))                 ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))) * INV.INV_BAL  ");
                    strSQL.Append(" >=@STD_AMT                                                                          ");

                    db.DbPsetDouble("@STD_AMT", _std_amt);
                }
            }

            strSQL.Append(" GROUP BY ");
            strSQL.Append(" INV.WS_CD, WS.WS_DESC, INV.ITEM_NO, I.ITEM_DESC, I.ITEM_TYPE, SP.DATA_CHAR) INV1 ");

            strSQL.Append(" INNER JOIN  ");

            strSQL.Append(" (SELECT                                                                            ");
            strSQL.Append(" INV.WS_CD, WS.WS_DESC, INV.ITEM_NO,            I.ITEM_DESC,        I.ITEM_TYPE,    ");
            strSQL.Append(" SP.DATA_CHAR ITEM_UMSR, MAX(INV.LAST_RECV_DATE) LAST_RECV_DATE, MAX(INV.LAST_DISB_DATE) LAST_DISB_DATE ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL I    ");
                strSQL.Append(" WHERE                      ");
                strSQL.Append(" I.INV_YM=0                 ");
                strSQL.Append(" AND I.INV_WIP_TYPE=1       ");
                strSQL.Append(" AND I.INV_TYPE=0           ");
                strSQL.Append(" AND I.ITEM_NO=:ITEM_NO     ");
                strSQL.Append(" AND I.WHS_CD=:WHS_CD       ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL INV                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON INV.ITEM_NO=I.ITEM_NO                                      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SP ON SP.KEY01 = 'ITEM_UMSR' AND SP.KEY02 = I.ITEM_UMSR    ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON INV.WHS_CD=W.WHS_CD                                   ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON INV.WS_CD=WS.WS_CD                                    ");

                strSQL.Append(" WHERE INV.INV_YM       = 0  ");
                strSQL.Append("   AND INV.INV_WIP_TYPE = 1  ");
                strSQL.Append("   AND INV.INV_TYPE     = 0  ");
                strSQL.Append("   AND (INV.INV_BAL    <> 0  ");
                strSQL.Append("   OR INV.ALLOC_QTY    <> 0) ");

                if (item_no != "" && parent_item_no == "")
                {
                    strSQL.Append(" AND INV.ITEM_NO=@ITEM_NO     ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                else if (item_no != "" && parent_item_no != "")
                {
                    strSQL.Append(" AND (INV.ITEM_NO=@ITEM_NO AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                  ");
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO ))                                 ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);

                }
                else if (item_no == "" && parent_item_no != "")
                {
                    strSQL.Append(" AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                                           ");
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO )                                 ");
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                }

                if (whs_cd != "")
                {
                    strSQL.Append(" AND INV.WHS_CD=@WHS_CD       ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }

                if (ws_cd != "")
                {
                    strSQL.Append(" AND INV.WS_CD=@WS_CD       ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (joc_cd != "")
                {
                    strSQL.Append(" AND INV.JOC_CD=@JOC_CD       ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD=@CATG_CD       ");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }
                if (act_end_date == 0)
                {
                    act_end_date = 99999999;
                }

                strSQL.Append(" AND (                                                                 ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) >= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) <= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     OR                                                                ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)>= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)<= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     )                                                                   ");

                db.DbPsetInt("@ACT_BEG_DATE", _act_beg_date);
                db.DbPsetInt("@ACT_END_DATE", _act_end_date);

                if (po_prc != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                       ");
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)) ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)))");
                    strSQL.Append(" >=@PO_PRC                                                           ");

                    db.DbPsetDouble("@PO_PRC", _po_prc);
                }
                if (std_amt != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                                       ");
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))                 ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))) * INV.INV_BAL  ");
                    strSQL.Append(" >=@STD_AMT                                                                          ");

                    db.DbPsetDouble("@STD_AMT", _std_amt);
                }
            }

            strSQL.Append(" GROUP BY ");
            strSQL.Append(" INV.WS_CD, WS.WS_DESC, INV.ITEM_NO, I.ITEM_DESC, I.ITEM_TYPE, SP.DATA_CHAR) INV2 ");
            strSQL.Append(" ON  INV1.WS_CD = INV2.WS_CD");
            strSQL.Append(" AND  INV1.ITEM_NO = INV2.ITEM_NO");
            strSQL.Append(" ORDER BY WS_CD,ITEM_NO");

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
        //<--ADD BY UBIQ-SUO 2011/1/7

        //-->ADD BY UBIQ-SUO 2010/12/29 BUG951
        /// <summary>
        /// 在庫データを検索
        /// 
        /// 使用画面：InvStockInq       
        /// 親品目の場合現場在庫データを検索
        /// 
        /// 使用画面：InvStockInq
        /// </summary>
        public DataSet GetParentWipList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                                      ");
            strSQL.Append(" INV.WS_CD,      ");
            //INV.WHS_CD,                           //DEL BY UBIQ-SUO 2011/1/7
            strSQL.Append(" '' WHS_CD,INV.PROCESS_CD, PC.PROCESS_DESC,     ");//ADD BY UBIQ-SUO 2011/1/7
            strSQL.Append(" INV.ITEM_NO,            I.ITEM_DESC,        I.ITEM_TYPE,    ");
            strSQL.Append(" INV.INV_BAL,    INV.ALLOC_QTY,  SP.DATA_CHAR ITEM_UMSR,                                     ");
            strSQL.Append(" CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE THEN INV.LAST_RECV_DATE                ");
            strSQL.Append(" ELSE INV.LAST_ADJ_IN_DATE END LAST_RECV_DATE,                                               ");
            strSQL.Append(" CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE THEN INV.LAST_DISB_DATE               ");
            strSQL.Append(" ELSE INV.LAST_ADJ_OUT_DATE END LAST_DISB_DATE,                                              ");
            strSQL.Append(" INV.LOT_NO,     INV.JOC_CD,     INV.SUPPLY_TYPE,        W.WHS_DESC,         WS.WS_DESC      ");
            strSQL.Append(" ,CASE WHEN INV.INV_TYPE = 3 THEN '3' ELSE '4' END   INV_TYPE   ");//ADD BY UBIQ-SUO 2011/1/7
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL I    ");
                strSQL.Append(" WHERE                      ");
                strSQL.Append(" I.INV_YM=0                 ");
                strSQL.Append(" AND I.INV_WIP_TYPE=1       ");
                strSQL.Append(" AND I.INV_TYPE IN (3,4)    ");
                strSQL.Append(" AND I.ITEM_NO=:ITEM_NO     ");
                strSQL.Append(" AND I.WHS_CD=:WHS_CD       ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL INV                                                                   ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON INV.ITEM_NO=I.ITEM_NO                                      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SP ON SP.KEY01 = 'ITEM_UMSR' AND SP.KEY02 = I.ITEM_UMSR    ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON INV.WHS_CD=W.WHS_CD                                   ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER WS ON INV.WS_CD=WS.WS_CD                                    ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER PC ON INV.WS_CD=PC.WS_CD                                    ");  //ADD BY UBIQ-SUO 2011/1/7
                strSQL.Append(" AND INV.PROCESS_CD = PC.PROCESS_CD                                    ");                       //ADD BY UBIQ-SUO 2011/1/7

                strSQL.Append(" WHERE INV.INV_YM       = 0  ");
                strSQL.Append("   AND INV.INV_WIP_TYPE = 1  ");
                strSQL.Append("   AND INV.INV_TYPE     IN (3,4)  ");                
                strSQL.Append("   AND (INV.INV_BAL    <> 0  ");
                strSQL.Append("   OR INV.ALLOC_QTY    <> 0) ");

                if (item_no != "" && parent_item_no == "")
                {
                    strSQL.Append(" AND INV.ITEM_NO=@ITEM_NO     ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                else if (item_no != "" && parent_item_no != "")
                {
                    strSQL.Append(" AND (INV.ITEM_NO=@ITEM_NO AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                  ");                    
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO ))                                 ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                }
                else if (item_no == "" && parent_item_no != "")
                {
                    strSQL.Append(" AND INV.ITEM_NO IN (SELECT CHILD_ITEM_NO FROM                                           ");                    
                    strSQL.Append(" MFG_BOM_MASTER WHERE PARENT_ITEM_NO = @PARENT_ITEM_NO )                                 ");
                    db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);                 
                }

                if (whs_cd != "")
                {
                    strSQL.Append(" AND INV.WHS_CD=@WHS_CD       ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }

                if (ws_cd != "")
                {
                    strSQL.Append(" AND INV.WS_CD=@WS_CD       ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (joc_cd != "")
                {
                    strSQL.Append(" AND INV.JOC_CD=@JOC_CD       ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                if (catg_cd != "")
                {
                    strSQL.Append(" AND I.CATG_CD=@CATG_CD       ");
                    db.DbPsetString("@CATG_CD", _catg_cd);
                }                

                if (act_end_date == 0)
                {
                    act_end_date = 99999999;
                }

                strSQL.Append(" AND (                                                                 ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) >= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_RECV_DATE >= INV.LAST_ADJ_IN_DATE       ");
                strSQL.Append("              THEN INV.LAST_RECV_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_IN_DATE END) <= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     OR                                                                ");
                strSQL.Append("       (   ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)>= @ACT_BEG_DATE      )     ");
                strSQL.Append("       AND ( (CASE WHEN INV.LAST_DISB_DATE >= INV.LAST_ADJ_OUT_DATE      ");
                strSQL.Append("              THEN INV.LAST_DISB_DATE                                    ");
                strSQL.Append("              ELSE INV.LAST_ADJ_OUT_DATE END)<= @ACT_END_DATE      )     ");
                strSQL.Append("       )                                                                 ");
                strSQL.Append("     )                                                                   ");

                db.DbPsetInt("@ACT_BEG_DATE", _act_beg_date);
                db.DbPsetInt("@ACT_END_DATE", _act_end_date);

                if (po_prc != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                       ");
                    
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)) ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112)))");
                    strSQL.Append(" >=@PO_PRC                                                           ");

                    db.DbPsetDouble("@PO_PRC", _po_prc);
                }
                if (std_amt != 0)
                {
                    strSQL.Append(" AND (SELECT S.STD_PRC FROM STD_PRICE_MASTER S                                       ");
                    strSQL.Append(" WHERE INV.ITEM_NO = S.ITEM_NO                                                       ");
                    
                    strSQL.Append(" AND S.BEG_EFF_DATE <=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))                 ");
                    strSQL.Append(" AND S.END_EFF_DATE >=CONVERT(INT,CONVERT(varchar(6),GETDATE(),112))) * INV.INV_BAL  ");
                    strSQL.Append(" >=@STD_AMT                                                                          ");

                    db.DbPsetDouble("@STD_AMT", _std_amt);
                }
            }

            strSQL.Append(" ORDER BY ");
            strSQL.Append(" INV.WS_CD,INV.WHS_CD,INV.ITEM_NO,INV.JOC_CD,INV.LOT_NO ");

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
        //<--ADD BY UBIQ-SUO 2010/12/29 BUG951

        /// <summary>
        /// 在庫データを検索
        /// 
        /// 使用画面：InvStockInq
        /// </summary>
        public int GetStockListByItemWhs()//2008.12.12 ADD BY CHEN
        {
            ComLibrary com = new ComLibrary();
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append(" SELECT                                              ");
            strSQL.Append(" SUM(I.INV_BAL) INV_BAL,SUM(I.ALLOC_QTY) ALLOC_QTY   ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL I,ITEM_MASTER IM ");
                strSQL.Append(" WHERE                      ");
                strSQL.Append(" I.ITEM_NO = IM.ITEM_NO     ");
                strSQL.Append(" AND I.INV_YM=0             ");
                strSQL.Append(" AND I.INV_WIP_TYPE=0       ");
                strSQL.Append(" AND I.INV_TYPE=0           ");
                strSQL.Append(" AND I.ITEM_NO=:ITEM_NO     ");
                strSQL.Append(" AND I.WHS_CD=:WHS_CD       ");
                strSQL.Append(" AND I.LOCATION=:LOCATION   ");
                strSQL.Append(" AND I.LOT_NO=:LOT_NO       ");
                strSQL.Append(" AND I.JOC_CD=:JOC_CD       ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
                db.DbPsetString("LOCATION", _location);
                db.DbPsetString("LOT_NO", _lot_no);
                db.DbPsetString("JOC_CD", _joc_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL I                             ");
                strSQL.Append(" INNER JOIN ITEM_MASTER IM ON I.ITEM_NO = IM.ITEM_NO ");
                strSQL.Append(" WHERE                                               ");
                strSQL.Append(" I.INV_YM=0                                          ");
                strSQL.Append(" AND I.INV_WIP_TYPE=0                                ");
                strSQL.Append(" AND I.INV_TYPE=0                                    ");
                strSQL.Append(" AND I.ITEM_NO=@ITEM_NO                              ");
                strSQL.Append(" AND I.WHS_CD=@WHS_CD                                ");
                strSQL.Append(" AND I.LOCATION=@LOCATION                            ");
                strSQL.Append(" AND I.LOT_NO=@LOT_NO                                ");
                strSQL.Append(" AND I.JOC_CD=@JOC_CD                                ");
                strSQL.Append(" AND I.SUPPLY_TYPE=@SUPPLY_TYPE                      ");

                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WHS_CD", _whs_cd);
                db.DbPsetString("@LOCATION", _location);
                db.DbPsetString("@LOT_NO", _lot_no);
                db.DbPsetString("@JOC_CD", _joc_cd);
                db.DbPsetInt("@SUPPLY_TYPE", _supply_type);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _inv_bal = com.StringToDouble(db.Row("INV_BAL"));
                _alloc_qty = com.StringToDouble(db.Row("ALLOC_QTY"));

            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// 在庫データを検索
        /// 
        /// 使用画面：InvStockInq
        /// </summary>
        public int GetStockListByItemWip()//2008.12.12 ADD BY CHEN
        {
            ComLibrary com = new ComLibrary();
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append(" SELECT                                              ");
            strSQL.Append(" SUM(I.INV_BAL) INV_BAL,SUM(I.ALLOC_QTY) ALLOC_QTY   ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL I,ITEM_MASTER IM ");
                strSQL.Append(" WHERE                      ");
                strSQL.Append(" I.ITEM_NO = IM.ITEM_NO     ");
                strSQL.Append(" AND I.INV_YM=0             ");
                strSQL.Append(" AND I.INV_WIP_TYPE=0       ");
                strSQL.Append(" AND I.INV_TYPE=0           ");
                strSQL.Append(" AND I.ITEM_NO=:ITEM_NO     ");
                strSQL.Append(" AND I.WHS_CD=:WHS_CD       ");
                strSQL.Append(" AND I.LOCATION=:LOCATION   ");
                strSQL.Append(" AND I.LOT_NO=:LOT_NO       ");
                strSQL.Append(" AND I.JOC_CD=:JOC_CD       ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
                db.DbPsetString("LOCATION", _location);
                db.DbPsetString("LOT_NO", _lot_no);
                db.DbPsetString("JOC_CD", _joc_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL I                             ");
                strSQL.Append(" INNER JOIN ITEM_MASTER IM ON I.ITEM_NO = IM.ITEM_NO ");
                strSQL.Append(" WHERE                                               ");
                strSQL.Append(" I.INV_YM=0                                          ");
                strSQL.Append(" AND I.INV_WIP_TYPE=1                                ");
                strSQL.Append(" AND I.INV_TYPE=0                                    ");
                strSQL.Append(" AND I.ITEM_NO=@ITEM_NO                              ");
                strSQL.Append(" AND I.WS_CD=@WS_CD                                  ");
                strSQL.Append(" AND I.WHS_CD=@WHS_CD                                ");
                strSQL.Append(" AND I.LOT_NO=@LOT_NO                                ");
                strSQL.Append(" AND I.JOC_CD=@JOC_CD                                ");

                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WS_CD", _ws_cd);
                db.DbPsetString("@WHS_CD", _whs_cd);
                db.DbPsetString("@LOT_NO", _lot_no);
                db.DbPsetString("@JOC_CD", _joc_cd);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _inv_bal = com.StringToDouble(db.Row("INV_BAL"));
                _alloc_qty = com.StringToDouble(db.Row("ALLOC_QTY"));

            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// 出庫引当データを検索
        /// 
        /// 使用画面：InvStockInq
        /// </summary>
        public DataSet GetAllocListByItemnWhs()//2009.1.22 ADD BY CHEN
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                                              ");
            strSQL.Append(" J.ITEM_NO,          J.ITEM_DESC,    J.SCH_START_DATE,       DM.SCH_DISB_DATE SCH_COMPL_DATE,       J.JOB_ORDER_NO, ");
            strSQL.Append(" J.JOB_ORDER_QTY,    DM.PLAN_QTY,    DM.DEFECT_PCT,          D.ALLOC_QTY,            D.DEMAND_NO,    ");
            strSQL.Append(" D.XFER_NO,          D.seq_no,       -1 AS ALLOC_SEQ_NO                                              ");//UPD BY UBIQ-LIU 2010/7/21 ALLOC_SEQ_NO (0→-1)

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER J                                                               ");
                strSQL.Append(" INNER JOIN DEMAND DM ON J.ORDER_NO = DM.ORDER_NO                               ");
                strSQL.Append(" INNER JOIN DEMAND_ALLOC D ON DM.DEMAND_NO = D.DEMAND_NO                        ");
                strSQL.Append(" INNER JOIN DISB_ALLOC DA ON DA.XFER_NO = D.XFER_NO AND DA.SEQ_NO = D.SEQ_NO    ");
                strSQL.Append(" INNER JOIN TRANSFER_TRANS T ON DA.XFER_NO = T.XFER_NO                          ");

                strSQL.Append(" WHERE DA.ALLOC_STATUS = 0           ");
                strSQL.Append(" AND (DM.SUB_GRP_CD = '' OR                           ");
                strSQL.Append(" (DM.SUB_GRP_CD <> '' AND DM.SUB_ACTION_FLAG = 1))    ");
                strSQL.Append(" AND DM.ITEM_TYPE         <> '99' 			         ");
                strSQL.Append(" AND T.ITEM_NO=:ITEM_NO              ");
                strSQL.Append(" AND T.FROM_WHS_CD=:FROM_WHS_CD      ");
                strSQL.Append(" AND DA.LOCATION=:LOCATION           ");
                strSQL.Append(" AND DA.JOC_CD=:JOC_CD               ");
                strSQL.Append(" AND DA.LOT_NO=:LOT_NO               ");
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM DEMAND DM                                                                 ");
                strSQL.Append(" INNER JOIN JOB_ORDER J ON J.ORDER_NO = DM.ORDER_NO                             ");
                strSQL.Append(" INNER JOIN DEMAND_ALLOC D ON DM.DEMAND_NO = D.DEMAND_NO                        ");
                strSQL.Append(" INNER JOIN DISB_ALLOC DA ON DA.XFER_NO = D.XFER_NO AND DA.SEQ_NO = D.SEQ_NO    ");
                strSQL.Append(" INNER JOIN TRANSFER_TRANS T ON DA.XFER_NO = T.XFER_NO                          ");

                strSQL.Append(" WHERE DA.ALLOC_STATUS = 0                           ");
                strSQL.Append(" AND (DM.SUB_GRP_CD = '' OR                           ");
                strSQL.Append(" (DM.SUB_GRP_CD <> '' AND DM.SUB_ACTION_FLAG = 1))    ");
                strSQL.Append(" AND DM.ITEM_TYPE         <> '99' 			        ");
                strSQL.Append(" AND T.ITEM_NO = @ITEM_NO                            ");
                strSQL.Append(" AND T.FROM_WHS_CD = @FROM_WHS_CD                    ");
                strSQL.Append(" AND DA.LOCATION = @LOCATION                         ");
                strSQL.Append(" AND DA.JOC_CD = @JOC_CD                             ");
                strSQL.Append(" AND DA.LOT_NO = @LOT_NO                             ");
            }

            strSQL.Append(" UNION ALL SELECT     ");
            strSQL.Append(" P.ITEM_NO,          P.ITEM_DESC,    P.SCH_START_DATE,       DM.SCH_DISB_DATE SCH_COMPL_DATE,       P.JOB_ORDER_NO, ");
            strSQL.Append(" P.JOB_ORDER_QTY,    DM.PLAN_QTY,    DM.DEFECT_PCT,          D.ALLOC_QTY,            D.DEMAND_NO,    ");
            strSQL.Append(" D.XFER_NO,          D.seq_no,       -1 AS ALLOC_SEQ_NO                                              ");//UPD BY UBIQ-LIU 2010/7/21 ALLOC_SEQ_NO (0→-1)

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM DEMAND DM                                                                 ");
                strSQL.Append(" INNER JOIN PUR_ORDER P ON P.ORDER_NO = DM.ORDER_NO                             ");
                strSQL.Append(" INNER JOIN DEMAND_ALLOC D ON DM.DEMAND_NO = D.DEMAND_NO                        ");
                strSQL.Append(" INNER JOIN DISB_ALLOC DA ON DA.XFER_NO = D.XFER_NO AND DA.SEQ_NO = D.SEQ_NO    ");
                strSQL.Append(" INNER JOIN TRANSFER_TRANS T ON DA.XFER_NO = T.XFER_NO                          ");
                strSQL.Append(" WHERE DA.ALLOC_STATUS = 0           ");
                strSQL.Append(" AND (DM.SUB_GRP_CD = '' OR                           ");
                strSQL.Append(" (DM.SUB_GRP_CD <> '' AND DM.SUB_ACTION_FLAG = 1))    ");
                strSQL.Append(" AND DM.ITEM_TYPE <> '99'                             ");
                strSQL.Append(" AND T.ITEM_NO=:ITEM_NO              ");
                strSQL.Append(" AND T.FROM_WHS_CD=:FROM_WHS_CD      ");
                strSQL.Append(" AND DA.LOCATION=:LOCATION           ");
                strSQL.Append(" AND DA.JOC_CD=:JOC_CD               ");
                strSQL.Append(" AND DA.LOT_NO=:LOT_NO               ");
            }
            else
            {
                strSQL.Append(" FROM DEMAND DM                                                                 ");
                strSQL.Append(" INNER JOIN PUR_ORDER P ON P.ORDER_NO = DM.ORDER_NO                             ");
                strSQL.Append(" INNER JOIN DEMAND_ALLOC D ON DM.DEMAND_NO = D.DEMAND_NO                        ");
                strSQL.Append(" INNER JOIN DISB_ALLOC DA ON DA.XFER_NO = D.XFER_NO AND DA.SEQ_NO = D.SEQ_NO    ");
                strSQL.Append(" INNER JOIN TRANSFER_TRANS T ON DA.XFER_NO = T.XFER_NO                          ");
                strSQL.Append(" WHERE DA.ALLOC_STATUS = 0                           ");
                strSQL.Append(" AND (DM.SUB_GRP_CD = '' OR                           ");
                strSQL.Append(" (DM.SUB_GRP_CD <> '' AND DM.SUB_ACTION_FLAG = 1))    ");
                strSQL.Append(" AND DM.ITEM_TYPE <> '99'                             ");
                strSQL.Append(" AND T.ITEM_NO = @ITEM_NO                            ");
                strSQL.Append(" AND T.FROM_WHS_CD = @FROM_WHS_CD                    ");
                strSQL.Append(" AND DA.LOCATION = @LOCATION                         ");
                strSQL.Append(" AND DA.JOC_CD = @JOC_CD                             ");
                strSQL.Append(" AND DA.LOT_NO = @LOT_NO                             ");
            }
            strSQL.Append(" UNION ALL SELECT     ");
            strSQL.Append(" PO.ITEM_NO,          PO.ITEM_DESC,    PO.SCH_START_DATE,       PD.SCH_DISB_DATE SCH_COMPL_DATE,   '' AS JOB_ORDER_NO, ");
            strSQL.Append(" PO.ORDER_QTY JOB_ORDER_QTY,           PD.PLAN_QTY,             PD.DEFECT_PCT,       D.ALLOC_QTY,        ");
            strSQL.Append(" D.DEMAND_NO,         D.XFER_NO,       D.seq_no,                -1 AS ALLOC_SEQ_NO                       ");//UPD BY UBIQ-LIU 2010/7/21 ALLOC_SEQ_NO (0→-1)

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PLANNED_ORDER PO                                                          ");
                strSQL.Append(" INNER JOIN PLANNED_DEMAND PD ON PO.ORDER_NO = PD.ORDER_NO                      ");
                strSQL.Append(" INNER JOIN DEMAND_ALLOC D ON PD.DEMAND_NO = D.DEMAND_NO                        ");
                strSQL.Append(" INNER JOIN DISB_ALLOC DA ON DA.XFER_NO = D.XFER_NO AND DA.SEQ_NO = D.SEQ_NO    ");
                strSQL.Append(" INNER JOIN TRANSFER_TRANS T ON DA.XFER_NO = T.XFER_NO                          ");
                strSQL.Append(" WHERE DA.ALLOC_STATUS = 0           ");
                strSQL.Append(" AND (PD.SUB_GRP_CD = '' OR                           ");
                strSQL.Append(" (PD.SUB_GRP_CD <> '' AND PD.SUB_ACTION_FLAG = 1))    ");
                strSQL.Append(" AND PD.ITEM_TYPE <> '99'                             ");
                strSQL.Append(" AND T.ITEM_NO=:ITEM_NO              ");
                strSQL.Append(" AND T.FROM_WHS_CD=:FROM_WHS_CD      ");
                strSQL.Append(" AND DA.LOCATION=:LOCATION           ");
                strSQL.Append(" AND DA.JOC_CD=:JOC_CD               ");
                strSQL.Append(" AND DA.LOT_NO=:LOT_NO               ");
            }
            else
            {
                strSQL.Append(" FROM PLANNED_DEMAND PD                                                         ");
                strSQL.Append(" INNER JOIN PLANNED_ORDER PO ON PO.ORDER_NO = PD.ORDER_NO                       ");
                strSQL.Append(" INNER JOIN DEMAND_ALLOC D ON PD.DEMAND_NO = D.DEMAND_NO                        ");
                strSQL.Append(" INNER JOIN DISB_ALLOC DA ON DA.XFER_NO = D.XFER_NO AND DA.SEQ_NO = D.SEQ_NO    ");
                strSQL.Append(" INNER JOIN TRANSFER_TRANS T ON DA.XFER_NO = T.XFER_NO                          ");
                strSQL.Append(" WHERE DA.ALLOC_STATUS = 0                           ");
                strSQL.Append(" AND (PD.SUB_GRP_CD = '' OR                           ");
                strSQL.Append(" (PD.SUB_GRP_CD <> '' AND PD.SUB_ACTION_FLAG = 1))    ");
                strSQL.Append(" AND PD.ITEM_TYPE <> '99'                             ");
                strSQL.Append(" AND T.ITEM_NO = @ITEM_NO                            ");
                strSQL.Append(" AND T.FROM_WHS_CD = @FROM_WHS_CD                    ");
                strSQL.Append(" AND DA.LOCATION = @LOCATION                         ");
                strSQL.Append(" AND DA.JOC_CD = @JOC_CD                             ");
                strSQL.Append(" AND DA.LOT_NO = @LOT_NO                             ");
            }
            strSQL.Append(" UNION ALL SELECT                                                                                                 ");
            strSQL.Append(" '' AS ITEM_NO,      '' AS ITEM_DESC,    0 AS SCH_START_DATE,    T.XFER_SCH_DATE AS SCH_COMPL_DATE,    T.SLIP_NO JOB_ORDER_NO, ");
            strSQL.Append(" 0 AS JOB_ORDER_QTY, 0 AS PLAN_QTY,      0 AS DEFECT_PCT,        D.ALLOC_QTY,            '' AS DEMAND_NO,        ");
            strSQL.Append(" D.XFER_NO,          D.seq_no,          -1 AS ALLOC_SEQ_NO                                                      ");//UPD BY UBIQ-LIU 2010/7/21 ALLOC_SEQ_NO (0→-1)

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM  DISB_ALLOC D                                                             ");
                strSQL.Append(" INNER JOIN TRANSFER_TRANS T ON D.XFER_NO = T.XFER_NO                           ");
                //strSQL.Append(" INNER JOIN DEMAND_ALLOC ON D.XFER_NO NOT IN (SELECT XFER_NO FROM DEMAND_ALLOC) ");

                strSQL.Append(" WHERE D.ALLOC_STATUS = 0           ");
                strSQL.Append(" AND D.XFER_NO + CAST(D.SEQ_NO AS VARCHAR) NOT IN (SELECT XFER_NO + CAST(SEQ_NO AS VARCHAR) FROM DEMAND_ALLOC)     ");
                strSQL.Append(" AND T.ITEM_NO=:ITEM_NO             ");
                strSQL.Append(" AND T.FROM_WHS_CD=:FROM_WHS_CD     ");
                strSQL.Append(" AND D.LOCATION=:LOCATION           ");
                strSQL.Append(" AND D.JOC_CD=:JOC_CD               ");
                strSQL.Append(" AND D.LOT_NO=:LOT_NO               ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("FROM_WHS_CD", _from_whs_cd);
                db.DbPsetString("LOCATION", _location);
                db.DbPsetString("JOC_CD", _joc_cd);
                db.DbPsetString("LOT_NO", _lot_no);
            }
            else
            {
                strSQL.Append(" FROM  TRANSFER_TRANS T                                                             ");
                strSQL.Append(" INNER JOIN DISB_ALLOC D ON D.XFER_NO = T.XFER_NO                                   ");
                //strSQL.Append(" INNER JOIN DEMAND_ALLOC ON D.XFER_NO NOT IN (SELECT XFER_NO FROM DEMAND_ALLOC)     ");

                strSQL.Append(" WHERE D.ALLOC_STATUS = 0            ");
                strSQL.Append(" AND D.XFER_NO + CAST(D.SEQ_NO AS VARCHAR) NOT IN (SELECT XFER_NO + CAST(SEQ_NO AS VARCHAR) FROM DEMAND_ALLOC)     ");
                strSQL.Append(" AND T.ITEM_NO = @ITEM_NO            ");
                strSQL.Append(" AND T.FROM_WHS_CD = @FROM_WHS_CD    ");
                strSQL.Append(" AND D.LOCATION = @LOCATION          ");
                strSQL.Append(" AND D.JOC_CD = @JOC_CD              ");
                strSQL.Append(" AND D.LOT_NO = @LOT_NO              ");

            }
            strSQL.Append(" UNION ALL SELECT                                                                                 ");
            strSQL.Append(" '' AS ITEM_NO,          '' AS ITEM_DESC,        0 AS SCH_START_DATE,    SS.SCH_SHIP_DATE AS SCH_COMPL_DATE,    ");
            strSQL.Append(" S.ORDER_NO + RIGHT(CAST(Power(10,4)+S.ORDER_LINE_NO   as   varchar),3) JOB_ORDER_NO,            ");
            strSQL.Append(" 0 AS JOB_ORDER_QTY,     0 AS PLAN_QTY,          0 AS DEFECT_PCT,        S.ALLOC_QTY,            ");
            strSQL.Append(" S.ORDER_NO DEMAND_NO,   CONVERT (VARCHAR,S.ORDER_LINE_NO) XFER_NO,      S.SHIP_SEQ seq_no,     ");
            strSQL.Append(" S.ALLOC_SEQ_NO                                                                                  ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM  SHIPPING_ALLOCATION S         ");
                strSQL.Append(" INNER JOIN SHIPPING_SCHEDULE SS     ");
                strSQL.Append(" ON S.ORDER_NO = SS.ORDER_NO AND S.ORDER_LINE_NO = SS.ORDER_LINE_NO AND S.SHIP_SEQ = SS.SHIP_SEQ   ");
                strSQL.Append(" AND SS.ORDER_STATUS < 90            ");//ADD BY UBIQ-LIU 2010/6/21

                strSQL.Append(" WHERE                               ");
                strSQL.Append(" S.ITEM_NO = :ITEM_NO                ");
                strSQL.Append(" AND S.WHS_CD = :FROM_WHS_CD         ");
                strSQL.Append(" AND S.LOCATION = :LOCATION          ");
                strSQL.Append(" AND S.JOC_CD = :JOC_CD              ");
                strSQL.Append(" AND S.LOT_NO = :LOT_NO              ");
                strSQL.Append(" AND S.SCH_ALLOC_FLAG = 0            ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("FROM_WHS_CD", _from_whs_cd);
                db.DbPsetString("LOCATION", _location);
                db.DbPsetString("JOC_CD", _joc_cd);
                db.DbPsetString("LOT_NO", _lot_no);
            }
            else
            {
                strSQL.Append(" FROM  SHIPPING_ALLOCATION S         ");
                strSQL.Append(" INNER JOIN SHIPPING_SCHEDULE SS     ");
                strSQL.Append(" ON S.ORDER_NO = SS.ORDER_NO AND S.ORDER_LINE_NO = SS.ORDER_LINE_NO AND S.SHIP_SEQ = SS.SHIP_SEQ   ");
                strSQL.Append(" AND SS.ORDER_STATUS < 90            ");//ADD BY UBIQ-LIU 2010/6/21

                strSQL.Append(" WHERE                               ");
                strSQL.Append(" S.ITEM_NO = @ITEM_NO                ");
                strSQL.Append(" AND S.WHS_CD = @FROM_WHS_CD         ");
                strSQL.Append(" AND S.LOCATION = @LOCATION          ");
                strSQL.Append(" AND S.JOC_CD = @JOC_CD              ");
                strSQL.Append(" AND S.LOT_NO = @LOT_NO              ");
                strSQL.Append(" AND S.SCH_ALLOC_FLAG = 0            ");

                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@FROM_WHS_CD", _from_whs_cd);
                db.DbPsetString("@LOCATION", _location);
                db.DbPsetString("@JOC_CD", _joc_cd);
                db.DbPsetString("@LOT_NO", _lot_no);
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
        /// 倉庫が支給品倉庫の場合 出庫引当データを検索
        /// 
        /// 使用画面：InvStockInq
        /// </summary>
        public DataSet GetAllocListByItemnSupplyWhs()//2009.1.22 ADD BY CHEN
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                                              ");
            strSQL.Append(" J.ITEM_NO,          J.ITEM_DESC,    J.SCH_START_DATE,       DM.SCH_DISB_DATE SCH_COMPL_DATE,       J.JOB_ORDER_NO, ");
            strSQL.Append(" J.JOB_ORDER_QTY,    DM.PLAN_QTY,    DM.DEFECT_PCT,          W.ALLOC_QTY,            W.DEMAND_NO,    ");
            strSQL.Append(" '' AS XFER_NO,      W.seq_no,       0 AS ALLOC_SEQ_NO                                              ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER J                                                               ");
                strSQL.Append(" INNER JOIN DEMAND DM ON J.ORDER_NO = DM.ORDER_NO                               ");
                strSQL.Append(" INNER JOIN WIP_ALLOC W ON DM.DEMAND_NO = W.DEMAND_NO                           ");

                strSQL.Append(" WHERE W.ALLOC_STATUS = 0            ");
                strSQL.Append(" AND W.SCH_FLAG IN (0,2)             ");
                strSQL.Append(" AND DM.ITEM_NO = :ITEM_NO           ");
                strSQL.Append(" AND W.WHS_CD = :WHS_CD              ");
                strSQL.Append(" AND D.LOCATION = :LOCATION          ");
                strSQL.Append(" AND W.JOC_CD = :JOC_CD              ");
                strSQL.Append(" AND W.LOT_NO = :LOT_NO              ");
                strSQL.Append(" AND W.SUPPLY_TYPE = :SUPPLY_TYPE    ");
                strSQL.Append(" AND (DM.SUB_GRP_CD = '' OR                          ");
                strSQL.Append(" (DM.SUB_GRP_CD <> '' AND DM.SUB_ACTION_FLAG = 1))   ");
                strSQL.Append(" AND DM.ITEM_TYPE <> '99'                            ");
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM DEMAND DM                                                               ");
                strSQL.Append(" INNER JOIN JOB_ORDER J ON J.ORDER_NO = DM.ORDER_NO                           ");
                strSQL.Append(" INNER JOIN WIP_ALLOC W ON DM.DEMAND_NO = W.DEMAND_NO                         ");

                strSQL.Append(" WHERE W.ALLOC_STATUS = 0                            ");
                strSQL.Append(" AND W.SCH_FLAG IN (0,2)                             ");
                strSQL.Append(" AND DM.ITEM_NO = @ITEM_NO                           ");
                strSQL.Append(" AND W.WHS_CD = @WHS_CD                              ");
                strSQL.Append(" AND W.LOCATION = @LOCATION                          ");
                strSQL.Append(" AND W.JOC_CD = @JOC_CD                              ");
                strSQL.Append(" AND W.LOT_NO = @LOT_NO                              ");
                strSQL.Append(" AND W.SUPPLY_TYPE = @SUPPLY_TYPE                    ");
                strSQL.Append(" AND (DM.SUB_GRP_CD = '' OR                          ");
                strSQL.Append(" (DM.SUB_GRP_CD <> '' AND DM.SUB_ACTION_FLAG = 1))   ");
                strSQL.Append(" AND DM.ITEM_TYPE <> '99'                            ");
            }

            strSQL.Append(" UNION ALL SELECT                                                                                        ");
            strSQL.Append(" P.ITEM_NO,          P.ITEM_DESC,    P.SCH_START_DATE,       DM.SCH_DISB_DATE SCH_COMPL_DATE,       P.JOB_ORDER_NO, ");
            strSQL.Append(" P.JOB_ORDER_QTY,    DM.PLAN_QTY,    DM.DEFECT_PCT,          W.ALLOC_QTY,            W.DEMAND_NO,    ");
            strSQL.Append(" '' AS XFER_NO,      W.seq_no,       0 AS ALLOC_SEQ_NO                                              ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PUR_ORDER P                                                            ");
                strSQL.Append(" INNER JOIN DEMAND DM ON P.ORDER_NO = DM.ORDER_NO                            ");
                strSQL.Append(" INNER JOIN WIP_ALLOC W ON DM.DEMAND_NO = W.DEMAND_NO                        ");

                strSQL.Append(" WHERE W.ALLOC_STATUS = 0            ");
                strSQL.Append(" AND W.SCH_FLAG IN (0,2)             ");
                strSQL.Append(" AND DM.ITEM_NO = :ITEM_NO           ");
                strSQL.Append(" AND W.WHS_CD = :WHS_CD              ");
                strSQL.Append(" AND D.LOCATION = :LOCATION          ");
                strSQL.Append(" AND W.JOC_CD = :JOC_CD              ");
                strSQL.Append(" AND W.LOT_NO = :LOT_NO              ");
                strSQL.Append(" AND W.SUPPLY_TYPE = :SUPPLY_TYPE    ");
                strSQL.Append(" AND (DM.SUB_GRP_CD = '' OR                          ");
                strSQL.Append(" (DM.SUB_GRP_CD <> '' AND DM.SUB_ACTION_FLAG = 1))   ");
                strSQL.Append(" AND DM.ITEM_TYPE <> '99'                            ");
            }
            else
            {
                strSQL.Append(" FROM DEMAND DM                                                              ");
                strSQL.Append(" INNER JOIN PUR_ORDER P ON P.ORDER_NO = DM.ORDER_NO                          ");
                strSQL.Append(" INNER JOIN WIP_ALLOC W ON DM.DEMAND_NO = W.DEMAND_NO                        ");

                strSQL.Append(" WHERE W.ALLOC_STATUS = 0                            ");
                strSQL.Append(" AND W.SCH_FLAG IN (0,2)                             ");
                strSQL.Append(" AND DM.ITEM_NO = @ITEM_NO                           ");
                strSQL.Append(" AND W.WHS_CD = @WHS_CD                              ");
                strSQL.Append(" AND W.LOCATION = @LOCATION                          ");
                strSQL.Append(" AND W.JOC_CD = @JOC_CD                              ");
                strSQL.Append(" AND W.LOT_NO = @LOT_NO                              ");
                strSQL.Append(" AND W.SUPPLY_TYPE = @SUPPLY_TYPE                    ");
                strSQL.Append(" AND (DM.SUB_GRP_CD = '' OR                          ");
                strSQL.Append(" (DM.SUB_GRP_CD <> '' AND DM.SUB_ACTION_FLAG = 1))   ");
                strSQL.Append(" AND DM.ITEM_TYPE <> '99'                            ");

            }
            strSQL.Append(" UNION ALL SELECT                                                                                            ");
            strSQL.Append(" PO.ITEM_NO,         PO.ITEM_DESC,    PO.SCH_START_DATE,       PD.SCH_DISB_DATE SCH_COMPL_DATE,   '' AS JOB_ORDER_NO, ");
            strSQL.Append(" PO.ORDER_QTY JOB_ORDER_QTY,          PD.PLAN_QTY,             PD.DEFECT_PCT,       W.ALLOC_QTY,         ");
            strSQL.Append(" W.DEMAND_NO,        '' AS XFER_NO,      W.seq_no,             0 AS ALLOC_SEQ_NO                        ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PLANNED_ORDER PO                                                          ");
                strSQL.Append(" INNER JOIN PLANNED_DEMAND PD ON PO.ORDER_NO = PD.ORDER_NO                      ");
                strSQL.Append(" INNER JOIN WIP_ALLOC W ON PD.DEMAND_NO = W.DEMAND_NO                           ");

                strSQL.Append(" WHERE W.ALLOC_STATUS = 0            ");
                strSQL.Append(" AND W.SCH_FLAG IN (0,2)             ");
                strSQL.Append(" AND (PD.SUB_GRP_CD = '' OR                          ");
                strSQL.Append(" (PD.SUB_GRP_CD <> '' AND PD.SUB_ACTION_FLAG = 1))   ");
                strSQL.Append(" AND PD.ITEM_TYPE <> '99'                            ");
                strSQL.Append(" AND PD.ITEM_NO = :ITEM_NO           ");
                strSQL.Append(" AND W.WHS_CD = :WHS_CD              ");
                strSQL.Append(" AND D.LOCATION = :LOCATION          ");
                strSQL.Append(" AND W.JOC_CD = :JOC_CD              ");
                strSQL.Append(" AND W.LOT_NO = :LOT_NO              ");
                strSQL.Append(" AND W.SUPPLY_TYPE = :SUPPLY_TYPE    ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
                db.DbPsetString("LOCATION", _location);
                db.DbPsetString("JOC_CD", _joc_cd);
                db.DbPsetString("LOT_NO", _lot_no);
                db.DbPsetInt("SUPPLY_TYPE", _supply_type);
            }
            else
            {
                strSQL.Append(" FROM PLANNED_DEMAND PD                                                         ");
                strSQL.Append(" INNER JOIN PLANNED_ORDER PO ON PO.ORDER_NO = PD.ORDER_NO                       ");
                strSQL.Append(" INNER JOIN WIP_ALLOC W ON PD.DEMAND_NO = W.DEMAND_NO                           ");

                strSQL.Append(" WHERE W.ALLOC_STATUS = 0                            ");
                strSQL.Append(" AND W.SCH_FLAG IN (0,2)                             ");
                strSQL.Append(" AND (PD.SUB_GRP_CD = '' OR                          ");
                strSQL.Append(" (PD.SUB_GRP_CD <> '' AND PD.SUB_ACTION_FLAG = 1))   ");
                strSQL.Append(" AND PD.ITEM_TYPE <> '99'                            ");
                strSQL.Append(" AND PD.ITEM_NO = @ITEM_NO                           ");
                strSQL.Append(" AND W.WHS_CD = @WHS_CD                              ");
                strSQL.Append(" AND W.LOCATION = @LOCATION                          ");
                strSQL.Append(" AND W.JOC_CD = @JOC_CD                              ");
                strSQL.Append(" AND W.LOT_NO = @LOT_NO                              ");
                strSQL.Append(" AND W.SUPPLY_TYPE = @SUPPLY_TYPE                    ");

                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WHS_CD", _whs_cd);
                db.DbPsetString("@JOC_CD", _joc_cd);
                db.DbPsetString("@LOT_NO", _lot_no);
                db.DbPsetString("@LOCATION", _location);
                db.DbPsetInt("@SUPPLY_TYPE", _supply_type);

            }
            strSQL.Append(" UNION ALL SELECT                                                                                                                    ");
            strSQL.Append(" '' AS ITEM_NO,      '' AS ITEM_DESC,    0 AS SCH_START_DATE,    T.XFER_SCH_DATE AS SCH_COMPL_DATE,    T.SLIP_NO JOB_ORDER_NO,   ");
            strSQL.Append(" 0 AS JOB_ORDER_QTY, 0 AS PLAN_QTY,      0 AS DEFECT_PCT,        D.ALLOC_QTY,            D.XFER_NO DEMAND_NO,                    ");
            strSQL.Append(" D.XFER_NO,          D.seq_no,           0 AS ALLOC_SEQ_NO                                                                       ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM  TRANSFER_TRANS T                                                       ");
                strSQL.Append(" INNER JOIN DISB_ALLOC D ON D.XFER_NO = T.XFER_NO AND T.REQ_TYPE = '23'       ");

                strSQL.Append(" WHERE D.ALLOC_STATUS = 0                ");
                strSQL.Append(" AND T.ITEM_NO = :ITEM_NO                ");
                strSQL.Append(" AND T.FROM_WHS_CD = :WHS_CD             ");
                strSQL.Append(" AND D.LOCATION = :LOCATION              ");
                strSQL.Append(" AND D.JOC_CD = :JOC_CD                  ");
                strSQL.Append(" AND D.LOT_NO = :LOT_NO                  ");
                strSQL.Append(" AND T.FROM_SUPPLY_TYPE = :SUPPLY_TYPE   ");
            }
            else
            {
                strSQL.Append(" FROM  TRANSFER_TRANS T                                                      ");
                strSQL.Append(" INNER JOIN DISB_ALLOC D ON D.XFER_NO = T.XFER_NO AND T.REQ_TYPE = '23'      ");

                strSQL.Append(" WHERE D.ALLOC_STATUS = 0                ");
                strSQL.Append(" AND T.ITEM_NO = @ITEM_NO                ");
                strSQL.Append(" AND T.FROM_WHS_CD = @WHS_CD             ");
                strSQL.Append(" AND D.LOCATION = @LOCATION              ");
                strSQL.Append(" AND D.JOC_CD = @JOC_CD                  ");
                strSQL.Append(" AND D.LOT_NO = @LOT_NO                  ");
                strSQL.Append(" AND T.FROM_SUPPLY_TYPE = @SUPPLY_TYPE   ");
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
        /// 出庫引当データを検索
        /// 
        /// 使用画面：InvStockInq
        /// </summary>
        public DataSet GetAllocListByItemnWip()//2009.1.22 ADD BY CHEN
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                                              ");
            strSQL.Append(" J.ITEM_NO,          J.ITEM_DESC,    J.SCH_START_DATE,       DM.SCH_DISB_DATE SCH_COMPL_DATE,       J.JOB_ORDER_NO, ");
            strSQL.Append(" J.JOB_ORDER_QTY,    DM.PLAN_QTY,    DM.DEFECT_PCT,          W.ALLOC_QTY,            W.DEMAND_NO,    ");
            strSQL.Append(" '' AS XFER_NO,      W.seq_no,       0 AS ALLOC_SEQ_NO                                              ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER J                                                               ");
                strSQL.Append(" INNER JOIN DEMAND DM ON J.ORDER_NO = DM.ORDER_NO                               ");
                strSQL.Append(" INNER JOIN WIP_ALLOC W ON DM.DEMAND_NO = W.DEMAND_NO                           ");

                strSQL.Append(" WHERE W.ALLOC_STATUS = 0            ");
                strSQL.Append(" AND W.SCH_FLAG IN (0,2)             ");
                strSQL.Append(" AND DM.ITEM_NO = :ITEM_NO           ");
                strSQL.Append(" AND W.WS_CD = :WS_CD                ");
                strSQL.Append(" AND W.WHS_CD = :WHS_CD              ");
                strSQL.Append(" AND W.JOC_CD = :JOC_CD              ");
                strSQL.Append(" AND W.LOT_NO = :LOT_NO              ");
                strSQL.Append(" AND W.SUPPLY_TYPE = :SUPPLY_TYPE    ");
                strSQL.Append(" AND (DM.SUB_GRP_CD = '' OR                           ");
                strSQL.Append(" (DM.SUB_GRP_CD <> '' AND DM.SUB_ACTION_FLAG = 1))    ");
                strSQL.Append(" AND DM.ITEM_TYPE <> '99'                            ");
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM DEMAND DM                                                               ");
                strSQL.Append(" INNER JOIN JOB_ORDER J ON J.ORDER_NO = DM.ORDER_NO                           ");
                strSQL.Append(" INNER JOIN WIP_ALLOC W ON DM.DEMAND_NO = W.DEMAND_NO                         ");

                strSQL.Append(" WHERE W.ALLOC_STATUS = 0                            ");
                strSQL.Append(" AND W.SCH_FLAG IN (0,2)                             ");
                strSQL.Append(" AND DM.ITEM_NO = @ITEM_NO                           ");
                strSQL.Append(" AND W.WS_CD = @WS_CD                                ");
                strSQL.Append(" AND W.WHS_CD = @WHS_CD                              ");
                strSQL.Append(" AND W.JOC_CD = @JOC_CD                              ");
                strSQL.Append(" AND W.LOT_NO = @LOT_NO                              ");
                strSQL.Append(" AND (DM.SUB_GRP_CD = '' OR                           ");
                strSQL.Append(" (DM.SUB_GRP_CD <> '' AND DM.SUB_ACTION_FLAG = 1))    ");
                strSQL.Append(" AND DM.ITEM_TYPE <> '99'                            ");
            }

            strSQL.Append(" UNION ALL SELECT                                                                                        ");
            strSQL.Append(" P.ITEM_NO,          P.ITEM_DESC,    P.SCH_START_DATE,       DM.SCH_DISB_DATE SCH_COMPL_DATE,       P.JOB_ORDER_NO, ");
            strSQL.Append(" P.JOB_ORDER_QTY,    DM.PLAN_QTY,    DM.DEFECT_PCT,          W.ALLOC_QTY,            W.DEMAND_NO,    ");
            strSQL.Append(" '' AS XFER_NO,      W.seq_no,       0 AS ALLOC_SEQ_NO                                              ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PUR_ORDER P                                                            ");
                strSQL.Append(" INNER JOIN DEMAND DM ON P.ORDER_NO = DM.ORDER_NO                            ");
                strSQL.Append(" INNER JOIN WIP_ALLOC W ON DM.DEMAND_NO = W.DEMAND_NO                        ");

                strSQL.Append(" WHERE W.ALLOC_STATUS = 0            ");
                strSQL.Append(" AND W.SCH_FLAG IN (0,2)             ");
                strSQL.Append(" AND DM.ITEM_NO = :ITEM_NO           ");
                strSQL.Append(" AND W.WS_CD = :WS_CD                ");
                strSQL.Append(" AND W.WHS_CD = :WHS_CD              ");
                strSQL.Append(" AND W.JOC_CD = :JOC_CD              ");
                strSQL.Append(" AND W.LOT_NO = :LOT_NO              ");
                strSQL.Append(" AND W.SUPPLY_TYPE = :SUPPLY_TYPE    ");
                strSQL.Append(" AND (DM.SUB_GRP_CD = '' OR                           ");
                strSQL.Append(" (DM.SUB_GRP_CD <> '' AND DM.SUB_ACTION_FLAG = 1))    ");
                strSQL.Append(" AND DM.ITEM_TYPE <> '99'                            ");
            }
            else
            {
                strSQL.Append(" FROM DEMAND DM                                                              ");
                strSQL.Append(" INNER JOIN PUR_ORDER P ON P.ORDER_NO = DM.ORDER_NO                          ");
                strSQL.Append(" INNER JOIN WIP_ALLOC W ON DM.DEMAND_NO = W.DEMAND_NO                        ");

                strSQL.Append(" WHERE W.ALLOC_STATUS = 0                            ");
                strSQL.Append(" AND W.SCH_FLAG IN (0,2)                             ");
                strSQL.Append(" AND DM.ITEM_NO = @ITEM_NO                           ");
                strSQL.Append(" AND W.WS_CD = @WS_CD                                ");
                strSQL.Append(" AND W.WHS_CD = @WHS_CD                              ");
                strSQL.Append(" AND W.JOC_CD = @JOC_CD                              ");
                strSQL.Append(" AND W.LOT_NO = @LOT_NO                              ");
                strSQL.Append(" AND (DM.SUB_GRP_CD = '' OR                           ");
                strSQL.Append(" (DM.SUB_GRP_CD <> '' AND DM.SUB_ACTION_FLAG = 1))    ");
                strSQL.Append(" AND DM.ITEM_TYPE <> '99'                            ");
            }
            strSQL.Append(" UNION ALL SELECT    ");
            strSQL.Append(" PO.ITEM_NO,         PO.ITEM_DESC,    PO.SCH_START_DATE,       PD.SCH_DISB_DATE SCH_COMPL_DATE,   '' AS JOB_ORDER_NO, ");
            strSQL.Append(" PO.ORDER_QTY JOB_ORDER_QTY,          PD.PLAN_QTY,             PD.DEFECT_PCT,       W.ALLOC_QTY,        ");
            strSQL.Append(" W.DEMAND_NO,        '' AS XFER_NO,      W.seq_no,             0 AS ALLOC_SEQ_NO                       ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PLANNED_ORDER PO                                                          ");
                strSQL.Append(" INNER JOIN PLANNED_DEMAND PD ON PO.ORDER_NO = PD.ORDER_NO                      ");
                strSQL.Append(" INNER JOIN WIP_ALLOC W ON PD.DEMAND_NO = W.DEMAND_NO                           ");

                strSQL.Append(" WHERE W.ALLOC_STATUS = 0            ");
                strSQL.Append(" AND W.SCH_FLAG IN (0,2)             ");
                strSQL.Append(" AND (PD.SUB_GRP_CD = '' OR                           ");
                strSQL.Append(" (PD.SUB_GRP_CD <> '' AND PD.SUB_ACTION_FLAG = 1))    ");
                strSQL.Append(" AND PD.ITEM_TYPE <> '99'                            ");
                strSQL.Append(" AND PD.ITEM_NO = :ITEM_NO           ");
                strSQL.Append(" AND W.WS_CD = :WS_CD                ");
                strSQL.Append(" AND W.WHS_CD = :WHS_CD              ");
                strSQL.Append(" AND W.JOC_CD = :JOC_CD              ");
                strSQL.Append(" AND W.LOT_NO = :LOT_NO              ");
                strSQL.Append(" AND W.SUPPLY_TYPE = :SUPPLY_TYPE    ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
                db.DbPsetString("LOCATION", _location);
                db.DbPsetString("JOC_CD", _joc_cd);
                db.DbPsetString("LOT_NO", _lot_no);
                db.DbPsetInt("SUPPLY_TYPE", _supply_type);
            }
            else
            {
                strSQL.Append(" FROM PLANNED_DEMAND PD                                                         ");
                strSQL.Append(" INNER JOIN PLANNED_ORDER PO ON PO.ORDER_NO = PD.ORDER_NO                       ");
                strSQL.Append(" INNER JOIN WIP_ALLOC W ON PD.DEMAND_NO = W.DEMAND_NO                           ");

                strSQL.Append(" WHERE W.ALLOC_STATUS = 0                            ");
                strSQL.Append(" AND W.SCH_FLAG IN (0,2)                             ");
                strSQL.Append(" AND (PD.SUB_GRP_CD = '' OR                           ");
                strSQL.Append(" (PD.SUB_GRP_CD <> '' AND PD.SUB_ACTION_FLAG = 1))    ");
                strSQL.Append(" AND PD.ITEM_TYPE <> '99'                            ");
                strSQL.Append(" AND PD.ITEM_NO = @ITEM_NO                           ");
                strSQL.Append(" AND W.WS_CD = @WS_CD                                ");
                strSQL.Append(" AND W.WHS_CD = @WHS_CD                              ");
                strSQL.Append(" AND W.JOC_CD = @JOC_CD                              ");
                strSQL.Append(" AND W.LOT_NO = @LOT_NO                              ");

                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WS_CD", _ws_cd);
                db.DbPsetString("@WHS_CD", _whs_cd);
                db.DbPsetString("@JOC_CD", _joc_cd);
                db.DbPsetString("@LOT_NO", _lot_no);
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
        /// 所要、在庫データを検索
        /// 
        /// 2009.02.07 ADD BY CHEN
        /// 2009.03.25 UPD BY CHEN
        /// 2011.04.01 UPD BY MATSUNO
        /// 使用画面：InvShortInq
        /// </summary>
        public DataSet GetInvShortList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("  SELECT                                                                             ");
            strSQL.Append("  SCH_ID,WS_CD,WHS_CD,ITEM_NO,ITEM_DESC,ITEM_TYPE,                                   ");
            strSQL.Append("  SCH_DISB_DATE,JOC_CD,SUM(PLAN_QTY) PLAN_QTY,ITEM_UMSR,                             ");
			strSQL.Append("  SUM(WIP_ALLOC_QTY) WIP_ALLOC_QTY,SUM(PLAN_DISB_QTY) PLAN_DISB_QTY,                 ");
			strSQL.Append("  SUM(SCRAP_QTY) SCRAP_QTY,															");//ADD BY 2010/12/15
            strSQL.Append("  INV_BAL,FREE_INV_BAL,                                                              ");
            strSQL.Append("  WIP_BAL,WIP_FREE_INV_BAL,                                                          ");
            strSQL.Append("  WHS_DESC,UMSR_DESC,WS_DESC,SCH_DESC                                                ");

            strSQL.Append("  FROM (                                                                             ");
            strSQL.Append("  SELECT                                                                             ");
            strSQL.Append("  D.SCH_ID,D.WS_CD,D.DISB_WHS WHS_CD,D.ITEM_NO,I.ITEM_DESC,I.ITEM_TYPE,              ");
            strSQL.Append("  D.SCH_DISB_DATE,ISNULL(INV.JOC_CD,CASE WHEN I.PO_TYPE = 4 THEN D.JOC_CD ELSE '*'   ");
			strSQL.Append("  END) JOC_CD,D.PLAN_QTY PLAN_QTY,D.ITEM_UMSR,                                       ");
			strSQL.Append("  SCRAP_QTY,																			");
            strSQL.Append("  D.WIP_ALLOC_QTY WIP_ALLOC_QTY,D.PLAN_DISB_QTY PLAN_DISB_QTY,                       ");
            strSQL.Append("  ISNULL(INV.INV_BAL,0) INV_BAL,ISNULL(INV.FREE_INV_BAL,0) FREE_INV_BAL,             ");
            strSQL.Append("  ISNULL(INV.WIP_BAL,0) WIP_BAL,ISNULL(INV.WIP_FREE_INV_BAL,0) WIP_FREE_INV_BAL      ");
            strSQL.Append("  ,W.WHS_DESC,S.DATA_CHAR UMSR_DESC,WS.WS_DESC,S2.DATA_CHAR SCH_DESC                 ");
            strSQL.Append("  ,ISNULL(J.ITEM_NO,ISNULL(P.ITEM_NO,PL.ITEM_NO)) PARENT_ITEM_NO             "); // 2011.04.01 Add
			if (_db_type == "ORACLE")
			{
				#region ### ORACLE ###
				db.DbParametersClear();
				strSQL.Append("  FROM ( SELECT SCH_ID,WS_CD,ITEM_NO,DISB_WHS,                               ");
				strSQL.Append("  ORDER_NO,JOC_CD,SUPPLY_TYPE,SCH_DISB_DATE,                                 ");
				strSQL.Append("  ALLOC_FLAG,DEMAND_STATUS,PLAN_QTY,ITEM_UMSR,								");
				strSQL.Append("  SCRAP_QTY,																	");//ADD BY UBIQ-LIU2010/12/15
				strSQL.Append("  WIP_ALLOC_QTY,PLAN_DISB_QTY,SUB_GRP_CD,SUB_ACTION_FLAG,ITEM_TYPE           ");
				strSQL.Append("  FROM DEMAND                                                                ");
				strSQL.Append("  WHERE ITEM_TYPE <> 99 AND DEMAND_STATUS <= 30 AND ALLOC_FLAG <> 1) D       ");
				strSQL.Append("  INNER JOIN ITEM_MASTER I ON D.ITEM_NO = I.ITEM_NO                          ");
				strSQL.Append("  LEFT OUTER JOIN                                                            ");
				strSQL.Append("  (SELECT INV.WHS_CD, SWIP.WHS_CD SWHS_CD, WIP.WS_CD, INV.ITEM_NO,           ");
				strSQL.Append("  INV.JOC_CD, SWIP.SUPPLY_TYPE,SUM(ISNULL(INV.INV_BAL,0)) INV_BAL,           ");
				strSQL.Append("  SUM(ISNULL(INV.FREE_INV_BAL,0)) FREE_INV_BAL,                              ");
				strSQL.Append("  SUM(ISNULL(WIP.INV_BAL,0) + ISNULL(SWIP.INV_BAL,0)) WIP_BAL,               ");
				strSQL.Append("  SUM(ISNULL(WIP.FREE_INV_BAL,0) + ISNULL(SWIP.FREE_INV_BAL,0))              ");
				strSQL.Append("  WIP_FREE_INV_BAL                                                           ");
				strSQL.Append("  FROM                                                                       ");
				//倉庫在庫	
				strSQL.Append("  (SELECT I.WHS_CD, I.ITEM_NO, I.JOC_CD,SUM(ISNULL(I.INV_BAL,0)) INV_BAL,    ");
				strSQL.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
				strSQL.Append("  FROM INVENTORY_DETAIL I	                                                ");
				strSQL.Append("  INNER JOIN WAREHOUSE_MASTER W                                              ");
				strSQL.Append("  ON I.WHS_CD = W.WHS_CD AND W.WHS_TYPE = 0                                  ");
				strSQL.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 0 AND I.INV_TYPE = 0                 ");
				strSQL.Append("  GROUP BY I.WHS_CD, I.ITEM_NO, I.JOC_CD) INV                                ");
				strSQL.Append("  LEFT JOIN                                                                  ");
				//現場在庫
				strSQL.Append("  (SELECT I.WS_CD, I.ITEM_NO, I.JOC_CD,SUM(ISNULL(I.INV_BAL,0)) INV_BAL,     ");
				strSQL.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
				strSQL.Append("  FROM INVENTORY_DETAIL I	                                                ");
				strSQL.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 1 AND I.INV_TYPE = 0                 ");
				strSQL.Append("  GROUP BY I.WS_CD, I.ITEM_NO, I.JOC_CD) WIP                                 ");
				strSQL.Append("  ON INV.ITEM_NO = WIP.ITEM_NO AND INV.JOC_CD = WIP.JOC_CD                   ");
				strSQL.Append("  LEFT JOIN                                                                  ");
				//支給品倉庫在庫
				strSQL.Append("  (SELECT I.WHS_CD, I.ITEM_NO, I.JOC_CD, I.SUPPLY_TYPE,                      ");
				strSQL.Append("  SUM(ISNULL(I.INV_BAL,0)) INV_BAL,                                          ");
				strSQL.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
				strSQL.Append("  FROM INVENTORY_DETAIL I                                                    ");
				strSQL.Append("  INNER JOIN WAREHOUSE_MASTER W                                              ");
				strSQL.Append("  ON I.WHS_CD = W.WHS_CD AND W.WHS_TYPE = 2                                  ");
				strSQL.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 0 AND I.INV_TYPE = 0                 ");
				strSQL.Append("  GROUP BY I.WHS_CD, I.ITEM_NO, I.JOC_CD, I.SUPPLY_TYPE) SWIP                ");
				strSQL.Append("  ON INV.ITEM_NO = SWIP.ITEM_NO AND INV.JOC_CD = SWIP.JOC_CD                 ");
				strSQL.Append("  GROUP BY INV.WHS_CD, SWIP.WHS_CD, WIP.WS_CD, INV.ITEM_NO,                  ");
				strSQL.Append("  INV.JOC_CD, SWIP.SUPPLY_TYPE) INV                                          ");
				strSQL.Append("  ON D.DISB_WHS = INV.WHS_CD AND D.ITEM_NO = INV.ITEM_NO                     ");
				strSQL.Append("  AND (D.SUPPLY_TYPE = 0 AND D.WS_CD = INV.WS_CD OR D.SUPPLY_TYPE <> 0 AND INV.WS_CD = '') ");	// 2010.10.07 Sai
				strSQL.Append("  AND CASE WHEN I.PO_TYPE = 4 THEN D.JOC_CD ELSE '*' END = INV.JOC_CD        ");
				strSQL.Append("  LEFT OUTER JOIN PUR_ORDER P ON D.ORDER_NO=P.ORDER_NO                       ");
				strSQL.Append("  LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD=V.VENDOR_CD                 ");
				strSQL.Append("  AND CASE I.BOND_TYPE WHEN 1 THEN V.BOND_SUPPLY_WHS ELSE V.SUPPLY_WHS END   ");
				strSQL.Append("  =INV.SWHS_CD AND D.SUPPLY_TYPE=INV.SUPPLY_TYPE                             ");
				strSQL.Append("  LEFT OUTER JOIN PLANNED_ORDER PO ON ((D.ORDER_NO = PO.ORDER_NO             ");
				strSQL.Append("  AND PO.WS_CD=INV.WS_CD) OR (D.ORDER_NO = PO.ORDER_NO AND                   ");
				strSQL.Append("  PO.VENDOR_CD=V.VENDOR_CD                                                   ");
				strSQL.Append("  AND CASE I.BOND_TYPE WHEN 1 THEN V.BOND_SUPPLY_WHS ELSE V.SUPPLY_WHS END   ");
				strSQL.Append("  =INV.SWHS_CD AND D.SUPPLY_TYPE=INV.SUPPLY_TYPE))                           ");
				strSQL.Append("  LEFT OUTER JOIN WORKSHOP_MASTER WS ON D.WS_CD=WS.WS_CD                     ");
				strSQL.Append("  LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01='SCH_ID'                   ");
				strSQL.Append("  AND S2.KEY02= D.SCH_ID                                                     ");
				strSQL.Append("  LEFT OUTER JOIN WAREHOUSE_MASTER W ON D.DISB_WHS=W.WHS_CD                  ");
				strSQL.Append("  LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01='ITEM_UMSR'                  ");
				strSQL.Append("  AND S.KEY02= D.ITEM_UMSR                                                   ");
				strSQL.Append("  WHERE                                                                      ");
				strSQL.Append("  D.ALLOC_FLAG<>1 AND D.DEMAND_STATUS<=30                                    ");
				strSQL.Append("  AND (D.SUB_GRP_CD = '' OR                                                  ");
				strSQL.Append("  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))                            ");
				strSQL.Append("  AND D.ITEM_TYPE <> '99'                                                    ");
				if (item_no != "")
				{
					strSQL.Append("  AND (J.ITEM_NO=@ITEM_NO OR P.ITEM_NO=@ITEM_NO OR PO.ITEM_NO=@ITEM_NO)  ");
				}
				if (sch_id != "")
				{
					strSQL.Append("  AND D.SCH_ID=@SCH_ID                                               ");
				}
				if (ws_cd != "")
				{
					strSQL.Append("  AND D.WS_CD=@WS_CD                                                 ");
				}
				if (whs_cd != "")
				{
					strSQL.Append("  AND D.DISB_WHS=@WHS_CD                                            ");
				}
				if (sch_disb_beg_date != 0)
				{
					strSQL.Append("  AND D.SCH_DISB_DATE>=@SCH_DISB_BEG_DATE                           ");
				}
				if (sch_disb_end_date != 0)
				{
					strSQL.Append("  AND D.SCH_DISB_DATE<=@SCH_DISB_END_DATE                           ");
				}
                //-->ADD BY UBIQ-SUO 2011/3/10
                if (joc_cd != "")
                {
                    strSQL.Append("  AND ((I.PO_TYPE = 4 AND INV.JOC_CD=:JOC_CD ) OR (I.PO_TYPE <> 4)) ");
                }
                //<--ADD BY UBIQ-SUO 2011/3/10
				strSQL.Append("  ) G                                                                        ");
				strSQL.Append("  GROUP BY SCH_ID,WS_CD,WHS_CD,ITEM_NO,ITEM_DESC,ITEM_TYPE,                  ");
				strSQL.Append("  SCH_DISB_DATE,JOC_CD,ITEM_UMSR,INV_BAL,                                    ");
				strSQL.Append("  FREE_INV_BAL,WIP_BAL,WIP_FREE_INV_BAL,WHS_DESC,UMSR_DESC,WS_DESC,SCH_DESC  ");
				strSQL.Append("  UNION ALL SELECT                                                                   ");
				strSQL.Append("  SCH_ID,WS_CD,WHS_CD,ITEM_NO,ITEM_DESC,ITEM_TYPE,                                   ");
				strSQL.Append("  SCH_DISB_DATE,JOC_CD,SUM(PLAN_QTY) PLAN_QTY,ITEM_UMSR,                             ");
				strSQL.Append("  0 SCRAP_QTY,																		");
				strSQL.Append("  SUM(WIP_ALLOC_QTY) WIP_ALLOC_QTY,SUM(PLAN_DISB_QTY) PLAN_DISB_QTY,                 ");
				strSQL.Append("  INV_BAL,FREE_INV_BAL,                                                              ");
				strSQL.Append("  WIP_BAL,WIP_FREE_INV_BAL,                                                          ");
				strSQL.Append("  WHS_DESC,UMSR_DESC,WS_DESC,SCH_DESC                                                ");

				strSQL.Append("  FROM (                                                                             ");
				strSQL.Append("  SELECT                                                                             ");
				strSQL.Append("  D.SCH_ID,D.WS_CD,D.DISB_WHS WHS_CD,D.ITEM_NO,I.ITEM_DESC,I.ITEM_TYPE,              ");
				strSQL.Append("  D.SCH_DISB_DATE,ISNULL(INV.JOC_CD,CASE WHEN I.PO_TYPE = 4 THEN D.JOC_CD ELSE '*'   ");
				strSQL.Append("  END) JOC_CD,D.PLAN_QTY PLAN_QTY,D.ITEM_UMSR,                                       ");
				strSQL.Append("  D.WIP_ALLOC_QTY WIP_ALLOC_QTY,D.PLAN_DISB_QTY PLAN_DISB_QTY,                       ");
				strSQL.Append("  ISNULL(INV.INV_BAL,0) INV_BAL,ISNULL(INV.FREE_INV_BAL,0) FREE_INV_BAL,             ");
				strSQL.Append("  ISNULL(INV.WIP_BAL,0) WIP_BAL,ISNULL(INV.WIP_FREE_INV_BAL,0) WIP_FREE_INV_BAL      ");
				strSQL.Append("  ,W.WHS_DESC,S.DATA_CHAR UMSR_DESC,WS.WS_DESC,S2.DATA_CHAR SCH_DESC                 ");
				strSQL.Append("  FROM                                                                       ");
				strSQL.Append("  (SELECT SCH_ID,WS_CD,ITEM_NO,DISB_WHS,ORDER_NO,JOC_CD,                     ");
				strSQL.Append("  SUPPLY_TYPE,SCH_DISB_DATE,ALLOC_FLAG,DEMAND_STATUS,PLAN_QTY,ITEM_UMSR,     ");
				strSQL.Append("  WIP_ALLOC_QTY,PLAN_DISB_QTY,SUB_GRP_CD,SUB_ACTION_FLAG,ITEM_TYPE           ");
				strSQL.Append("  FROM PLANNED_DEMAND                                                        ");
				strSQL.Append("  WHERE ITEM_TYPE <> 99 AND ALLOC_FLAG = 2 ) D                               ");

				strSQL.Append("  INNER JOIN ITEM_MASTER I ON D.ITEM_NO = I.ITEM_NO                          ");
				strSQL.Append("  LEFT OUTER JOIN                                                            ");
				strSQL.Append("  (SELECT INV.WHS_CD, SWIP.WHS_CD SWHS_CD, WIP.WS_CD, INV.ITEM_NO,           ");
				strSQL.Append("  INV.JOC_CD, SWIP.SUPPLY_TYPE,SUM(ISNULL(INV.INV_BAL,0)) INV_BAL,           ");
				strSQL.Append("  SUM(ISNULL(INV.FREE_INV_BAL,0)) FREE_INV_BAL,                              ");
				strSQL.Append("  SUM(ISNULL(WIP.INV_BAL,0) + ISNULL(SWIP.INV_BAL,0)) WIP_BAL,               ");
				strSQL.Append("  SUM(ISNULL(WIP.FREE_INV_BAL,0) + ISNULL(SWIP.FREE_INV_BAL,0))              ");
				strSQL.Append("  WIP_FREE_INV_BAL                                                           ");
				strSQL.Append("  FROM                                                                       ");
				//倉庫在庫	
				strSQL.Append("  (SELECT I.WHS_CD, I.ITEM_NO, I.JOC_CD,SUM(ISNULL(I.INV_BAL,0)) INV_BAL,    ");
				strSQL.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
				strSQL.Append("  FROM INVENTORY_DETAIL I	                                                ");
				strSQL.Append("  INNER JOIN WAREHOUSE_MASTER W                                              ");
				strSQL.Append("  ON I.WHS_CD = W.WHS_CD AND W.WHS_TYPE = 0                                  ");
				strSQL.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 0 AND I.INV_TYPE = 0                 ");
				strSQL.Append("  GROUP BY I.WHS_CD, I.ITEM_NO, I.JOC_CD) INV                                ");
				strSQL.Append("  LEFT JOIN                                                                  ");
				//現場在庫
				strSQL.Append("  (SELECT I.WS_CD, I.ITEM_NO, I.JOC_CD,SUM(ISNULL(I.INV_BAL,0)) INV_BAL,     ");
				strSQL.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
				strSQL.Append("  FROM INVENTORY_DETAIL I	                                                ");
				strSQL.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 1 AND I.INV_TYPE = 0                 ");
				strSQL.Append("  GROUP BY I.WS_CD, I.ITEM_NO, I.JOC_CD) WIP                                 ");
				strSQL.Append("  ON INV.ITEM_NO = WIP.ITEM_NO AND INV.JOC_CD = WIP.JOC_CD                   ");
				strSQL.Append("  LEFT JOIN                                                                  ");
				//支給品倉庫在庫
				strSQL.Append("  (SELECT I.WHS_CD, I.ITEM_NO, I.JOC_CD, I.SUPPLY_TYPE,                      ");
				strSQL.Append("  SUM(ISNULL(I.INV_BAL,0)) INV_BAL,                                          ");
				strSQL.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
				strSQL.Append("  FROM INVENTORY_DETAIL I                                                    ");
				strSQL.Append("  INNER JOIN WAREHOUSE_MASTER W                                              ");
				strSQL.Append("  ON I.WHS_CD = W.WHS_CD AND W.WHS_TYPE = 2                                  ");
				strSQL.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 0 AND I.INV_TYPE = 0                 ");
				strSQL.Append("  GROUP BY I.WHS_CD, I.ITEM_NO, I.JOC_CD, I.SUPPLY_TYPE) SWIP                ");
				strSQL.Append("  ON INV.ITEM_NO = SWIP.ITEM_NO AND INV.JOC_CD = SWIP.JOC_CD                 ");
				strSQL.Append("  GROUP BY INV.WHS_CD, SWIP.WHS_CD, WIP.WS_CD, INV.ITEM_NO,                  ");
				strSQL.Append("  INV.JOC_CD, SWIP.SUPPLY_TYPE) INV                                          ");
				strSQL.Append("  ON D.DISB_WHS = INV.WHS_CD AND D.ITEM_NO = INV.ITEM_NO                     ");
				strSQL.Append("  AND (D.SUPPLY_TYPE = 0 AND D.WS_CD = INV.WS_CD OR D.SUPPLY_TYPE <> 0 AND INV.WS_CD = '') ");	// 2010.10.07 Sai
				strSQL.Append("  AND CASE WHEN I.PO_TYPE = 4 THEN D.JOC_CD ELSE '*' END = INV.JOC_CD        ");
				strSQL.Append("  LEFT OUTER JOIN PUR_ORDER P ON D.ORDER_NO=P.ORDER_NO                       ");
				strSQL.Append("  LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD=V.VENDOR_CD                 ");
				strSQL.Append("  AND CASE I.BOND_TYPE WHEN 1 THEN V.BOND_SUPPLY_WHS ELSE V.SUPPLY_WHS END   ");
				strSQL.Append("  =INV.SWHS_CD AND D.SUPPLY_TYPE=INV.SUPPLY_TYPE                             ");
				strSQL.Append("  LEFT OUTER JOIN PLANNED_ORDER PO ON ((D.ORDER_NO = PO.ORDER_NO             ");
				strSQL.Append("  AND PO.WS_CD=INV.WS_CD) OR (D.ORDER_NO = PO.ORDER_NO AND                   ");
				strSQL.Append("  PO.VENDOR_CD=V.VENDOR_CD                                                   ");
				strSQL.Append("  AND CASE I.BOND_TYPE WHEN 1 THEN V.BOND_SUPPLY_WHS ELSE V.SUPPLY_WHS END   ");
				strSQL.Append("  =INV.SWHS_CD AND D.SUPPLY_TYPE=INV.SUPPLY_TYPE))                           ");

				strSQL.Append("  LEFT OUTER JOIN WAREHOUSE_MASTER W ON D.DISB_WHS=W.WHS_CD                  ");
				strSQL.Append("  LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01='ITEM_UMSR'                  ");
				strSQL.Append("  AND S.KEY02= D.ITEM_UMSR                                                   ");
				strSQL.Append("  LEFT OUTER JOIN WORKSHOP_MASTER WS ON D.WS_CD=WS.WS_CD                     ");
				strSQL.Append("  LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01='SCH_ID'                   ");
				strSQL.Append("  AND S2.KEY02= D.SCH_ID                                                     ");
				strSQL.Append("  WHERE                                                                      ");
				strSQL.Append("  D.ALLOC_FLAG<>1 AND D.DEMAND_STATUS<=30                                    ");
				strSQL.Append("  AND (D.SUB_GRP_CD = '' OR                                                  ");
				strSQL.Append("  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))                            ");
				strSQL.Append("  AND D.ITEM_TYPE <> '99'                                                    ");
				if (item_no != "")
				{
					strSQL.Append("  AND (J.ITEM_NO=@ITEM_NO OR P.ITEM_NO=@ITEM_NO OR PO.ITEM_NO=@ITEM_NO)         ");
					db.DbPsetString("@ITEM_NO", _item_no);
				}
				if (sch_id != "")
				{
					strSQL.Append("  AND D.SCH_ID=@SCH_ID                                               ");
					db.DbPsetString("@SCH_ID", _sch_id);
				}
				if (ws_cd != "")
				{
					strSQL.Append("  AND D.WS_CD=@WS_CD                                                 ");
					db.DbPsetString("@WS_CD", _ws_cd);
				}
				if (whs_cd != "")
				{
					strSQL.Append("  AND D.DISB_WHS=@WHS_CD                                            ");
					db.DbPsetString("@WHS_CD", _whs_cd);
				}
				if (sch_disb_beg_date != 0)
				{
					strSQL.Append("  AND D.SCH_DISB_DATE>=@SCH_DISB_BEG_DATE                           ");
					db.DbPsetInt("@SCH_DISB_BEG_DATE", _sch_disb_beg_date);
				}
				if (sch_disb_end_date != 0)
				{
					strSQL.Append("  AND D.SCH_DISB_DATE<=@SCH_DISB_END_DATE                           ");
					db.DbPsetInt("@SCH_DISB_END_DATE", _sch_disb_end_date);
				}
                //-->ADD BY UBIQ-SUO 2011/3/10
                if (joc_cd != "")
                {
                    strSQL.Append("  AND ((I.PO_TYPE = 4 AND INV.JOC_CD=:JOC_CD ) OR (I.PO_TYPE <> 4)) ");
                    db.DbPsetString("JOC_CD ", _joc_cd);
                }
                //<--ADD BY UBIQ-SUO 2011/3/10
				strSQL.Append("  ) G                                                                        ");
				strSQL.Append("  GROUP BY SCH_ID,WS_CD,WHS_CD,ITEM_NO,ITEM_DESC,ITEM_TYPE,                  ");
				strSQL.Append("  SCH_DISB_DATE,JOC_CD,ITEM_UMSR,INV_BAL,                                    ");
				strSQL.Append("  FREE_INV_BAL,WIP_BAL,WIP_FREE_INV_BAL,WHS_DESC,UMSR_DESC,WS_DESC,SCH_DESC  ");
				strSQL.Append("  ORDER BY WHS_CD,WS_CD,SCH_DISB_DATE,ITEM_NO                                ");
				#endregion ### ORACLE ###
			}
			else
			{
				#region ### SQL SERVER ###
				db.DbParametersClear();
				/*-UPD BEGIN-*/
				strSQL.Append("  FROM ( SELECT SCH_ID,WS_CD,ITEM_NO,DISB_WHS,                               ");
				strSQL.Append("  ORDER_NO,JOC_CD,SUPPLY_TYPE,SCH_DISB_DATE,                                 ");
				strSQL.Append("  ALLOC_FLAG,DEMAND_STATUS,PLAN_QTY,ITEM_UMSR,								");
				strSQL.Append("  SCRAP_QTY,																	");//ADD BY UBIQ-LIU2010/12/15
				strSQL.Append("  WIP_ALLOC_QTY,PLAN_DISB_QTY,SUB_GRP_CD,SUB_ACTION_FLAG,ITEM_TYPE           ");
				strSQL.Append("  FROM DEMAND                                                                ");
				strSQL.Append("  WHERE ITEM_TYPE <> 99 AND DEMAND_STATUS <= 30 AND ALLOC_FLAG <> 1) D       ");
				/*-UPD END-*/
				strSQL.Append("  INNER JOIN ITEM_MASTER I ON D.ITEM_NO = I.ITEM_NO                          ");
				strSQL.Append("  LEFT OUTER JOIN                                                            ");
				strSQL.Append("  (SELECT INV.WHS_CD, SWIP.WHS_CD SWHS_CD, WIP.WS_CD, INV.ITEM_NO,           ");
				strSQL.Append("  INV.JOC_CD, SWIP.SUPPLY_TYPE,SUM(ISNULL(INV.INV_BAL,0)) INV_BAL,           ");
				strSQL.Append("  SUM(ISNULL(INV.FREE_INV_BAL,0)) FREE_INV_BAL,                              ");
				strSQL.Append("  SUM(ISNULL(WIP.INV_BAL,0) + ISNULL(SWIP.INV_BAL,0)) WIP_BAL,               ");
				strSQL.Append("  SUM(ISNULL(WIP.FREE_INV_BAL,0) + ISNULL(SWIP.FREE_INV_BAL,0))              ");
				strSQL.Append("  WIP_FREE_INV_BAL                                                           ");
				strSQL.Append("  FROM                                                                       ");
				//倉庫在庫	
				strSQL.Append("  (SELECT I.WHS_CD, I.ITEM_NO, I.JOC_CD,SUM(ISNULL(I.INV_BAL,0)) INV_BAL,    ");
				strSQL.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
				strSQL.Append("  FROM INVENTORY_DETAIL I	                                                ");
				strSQL.Append("  INNER JOIN WAREHOUSE_MASTER W                                              ");
				strSQL.Append("  ON I.WHS_CD = W.WHS_CD AND W.WHS_TYPE = 0                                  ");
				strSQL.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 0 AND I.INV_TYPE = 0                 ");
				strSQL.Append("  GROUP BY I.WHS_CD, I.ITEM_NO, I.JOC_CD) INV                                ");
				strSQL.Append("  LEFT JOIN                                                                  ");
				//現場在庫
				strSQL.Append("  (SELECT I.WS_CD, I.ITEM_NO, I.JOC_CD,SUM(ISNULL(I.INV_BAL,0)) INV_BAL,     ");
				strSQL.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
				strSQL.Append("  FROM INVENTORY_DETAIL I	                                                ");
				strSQL.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 1 AND I.INV_TYPE = 0                 ");
				strSQL.Append("  GROUP BY I.WS_CD, I.ITEM_NO, I.JOC_CD) WIP                                 ");
				strSQL.Append("  ON INV.ITEM_NO = WIP.ITEM_NO AND INV.JOC_CD = WIP.JOC_CD                   ");
				strSQL.Append("  LEFT JOIN                                                                  ");
				//支給品倉庫在庫
				strSQL.Append("  (SELECT I.WHS_CD, I.ITEM_NO, I.JOC_CD, I.SUPPLY_TYPE,                      ");
				strSQL.Append("  SUM(ISNULL(I.INV_BAL,0)) INV_BAL,                                          ");
				strSQL.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
				strSQL.Append("  FROM INVENTORY_DETAIL I                                                    ");
				strSQL.Append("  INNER JOIN WAREHOUSE_MASTER W                                              ");
				strSQL.Append("  ON I.WHS_CD = W.WHS_CD AND W.WHS_TYPE = 2                                  ");
				strSQL.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 0 AND I.INV_TYPE = 0                 ");
				strSQL.Append("  GROUP BY I.WHS_CD, I.ITEM_NO, I.JOC_CD, I.SUPPLY_TYPE) SWIP                ");
				strSQL.Append("  ON INV.ITEM_NO = SWIP.ITEM_NO AND INV.JOC_CD = SWIP.JOC_CD                 ");
				strSQL.Append("  GROUP BY INV.WHS_CD, SWIP.WHS_CD, WIP.WS_CD, INV.ITEM_NO,                  ");
				strSQL.Append("  INV.JOC_CD, SWIP.SUPPLY_TYPE) INV                                          ");
				strSQL.Append("  ON D.DISB_WHS = INV.WHS_CD AND D.ITEM_NO = INV.ITEM_NO                     ");
                //strSQL.Append("  AND (D.SUPPLY_TYPE = 0 AND D.WS_CD = INV.WS_CD OR D.SUPPLY_TYPE <> 0 AND INV.WS_CD = '') ");	// 2010.10.07 Sai               // Del 2012.06.11 Ubiq-Sai
                strSQL.Append("  AND ((D.SUPPLY_TYPE = 0 AND D.WS_CD = ISNULL(INV.WS_CD,D.WS_CD)) OR (D.SUPPLY_TYPE <> 0 AND ISNULL(INV.WS_CD,'') = '')) ");	// Add 2012.06.11 Ubiq-Sai
                strSQL.Append("  AND CASE WHEN I.PO_TYPE = 4 THEN D.JOC_CD ELSE '*' END = INV.JOC_CD        ");
				//strSQL.Append("  LEFT OUTER JOIN JOB_ORDER J ON D.ORDER_NO = J.ORDER_NO                     ");	// 2010.10.07 Sai DEL
				//strSQL.Append("  AND J.WS_CD=INV.WS_CD                                                      ");
                strSQL.Append("  LEFT OUTER JOIN JOB_ORDER J ON D.ORDER_NO = J.ORDER_NO                     ");	// 2011.04.01 復活
                strSQL.Append("  LEFT OUTER JOIN PUR_ORDER P ON D.ORDER_NO=P.ORDER_NO                       ");
                strSQL.Append("  LEFT OUTER JOIN PLANNED_ORDER PL ON D.ORDER_NO=PL.ORDER_NO                 ");	// 2011.04.01 Add
				strSQL.Append("  LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD=V.VENDOR_CD                 ");
				strSQL.Append("  AND CASE I.BOND_TYPE WHEN 1 THEN V.BOND_SUPPLY_WHS ELSE V.SUPPLY_WHS END   ");
				strSQL.Append("  =INV.SWHS_CD AND D.SUPPLY_TYPE=INV.SUPPLY_TYPE                             ");
				/*-ADD BEGIN-*/
				strSQL.Append("  LEFT OUTER JOIN PLANNED_ORDER PO ON ((D.ORDER_NO = PO.ORDER_NO             ");
				strSQL.Append("  AND PO.WS_CD=INV.WS_CD) OR (D.ORDER_NO = PO.ORDER_NO AND                   ");
				strSQL.Append("  PO.VENDOR_CD=V.VENDOR_CD                                                   ");
				strSQL.Append("  AND CASE I.BOND_TYPE WHEN 1 THEN V.BOND_SUPPLY_WHS ELSE V.SUPPLY_WHS END   ");
				strSQL.Append("  =INV.SWHS_CD AND D.SUPPLY_TYPE=INV.SUPPLY_TYPE))                           ");
				strSQL.Append("  LEFT OUTER JOIN WORKSHOP_MASTER WS ON D.WS_CD=WS.WS_CD                     ");
				strSQL.Append("  LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01='SCH_ID'                   ");
				strSQL.Append("  AND S2.KEY02= D.SCH_ID                                                     ");
				/*-ADD END-*/
				strSQL.Append("  LEFT OUTER JOIN WAREHOUSE_MASTER W ON D.DISB_WHS=W.WHS_CD                  ");
				strSQL.Append("  LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01='ITEM_UMSR'                  ");
				strSQL.Append("  AND S.KEY02= D.ITEM_UMSR                                                   ");
				strSQL.Append("  WHERE                                                                      ");
				strSQL.Append("  D.ALLOC_FLAG<>1 AND D.DEMAND_STATUS<=30                                    ");
				strSQL.Append("  AND (D.SUB_GRP_CD = '' OR                                                  ");
				strSQL.Append("  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))                            ");
				strSQL.Append("  AND D.ITEM_TYPE <> '99'                                                    ");
				if (item_no != "")
				{
					//strSQL.Append("  AND (J.ITEM_NO=@ITEM_NO OR P.ITEM_NO=@ITEM_NO OR PO.ITEM_NO=@ITEM_NO)  ");
                    strSQL.Append("  AND ISNULL(J.ITEM_NO,ISNULL(P.ITEM_NO,PL.ITEM_NO))=@ITEM_NO       ");	// 2011.04.01 Add
					//db.DbPsetString("@ITEM_NO", _item_no);
				}
				/*-----------ADD BEGIN-------------*/
				if (sch_id != "")
				{
					strSQL.Append("  AND D.SCH_ID=@SCH_ID                                               ");
					//db.DbPsetString("@SCH_ID", _sch_id);
				}
				if (ws_cd != "")
				{
					strSQL.Append("  AND D.WS_CD=@WS_CD                                                 ");
					//db.DbPsetString("@WS_CD", _ws_cd);
				}
				/*-----ADD END-------*/
				if (whs_cd != "")
				{
					strSQL.Append("  AND D.DISB_WHS=@WHS_CD                                            ");
					//db.DbPsetString("@WHS_CD", _whs_cd);
				}
				if (sch_disb_beg_date != 0)
				{
					strSQL.Append("  AND D.SCH_DISB_DATE>=@SCH_DISB_BEG_DATE                           ");
					//db.DbPsetInt("@SCH_DISB_BEG_DATE", _sch_disb_beg_date);
				}
				if (sch_disb_end_date != 0)
				{
					strSQL.Append("  AND D.SCH_DISB_DATE<=@SCH_DISB_END_DATE                           ");
					//db.DbPsetInt("@SCH_DISB_END_DATE", _sch_disb_end_date);
				}
                //-->ADD BY UBIQ-SUO 2011/3/10
                if (joc_cd != "")
                {
                    strSQL.Append("  AND ((I.PO_TYPE = 4 AND INV.JOC_CD=@JOC_CD ) OR (I.PO_TYPE <> 4)) ");
                }
                //<--ADD BY UBIQ-SUO 2011/3/10
				/*
				strSQL.Append("  GROUP BY D.DISB_WHS,D.ITEM_NO,I.ITEM_DESC,I.ITEM_TYPE,I.PO_TYPE,           ");
				strSQL.Append("  D.SCH_DISB_DATE,INV.JOC_CD,D.ITEM_UMSR,INV.INV_BAL,                        ");
				strSQL.Append("  INV.FREE_INV_BAL,INV.WIP_BAL,INV.WIP_FREE_INV_BAL,W.WHS_DESC,S.DATA_CHAR   ");
				*/
				strSQL.Append("  ) G                                                                        ");
				strSQL.Append("  GROUP BY SCH_ID,WS_CD,WHS_CD,ITEM_NO,ITEM_DESC,ITEM_TYPE,                  ");
				strSQL.Append("  SCH_DISB_DATE,JOC_CD,ITEM_UMSR,INV_BAL,                                    ");
				strSQL.Append("  FREE_INV_BAL,WIP_BAL,WIP_FREE_INV_BAL,WHS_DESC,UMSR_DESC,WS_DESC,SCH_DESC  ");

				/*--------------------------------------------------------------*/
				strSQL.Append("  UNION ALL SELECT                                                                   ");
				strSQL.Append("  SCH_ID,WS_CD,WHS_CD,ITEM_NO,ITEM_DESC,ITEM_TYPE,                                   ");
				strSQL.Append("  SCH_DISB_DATE,JOC_CD,SUM(PLAN_QTY) PLAN_QTY,ITEM_UMSR,                             ");
				//strSQL.Append("  0 SCRAP_QTY,																		");
				strSQL.Append("  SUM(WIP_ALLOC_QTY) WIP_ALLOC_QTY,SUM(PLAN_DISB_QTY) PLAN_DISB_QTY,                 ");
                strSQL.Append("  0 SCRAP_QTY,																		"); // 2011.04.01 Move
				strSQL.Append("  INV_BAL,FREE_INV_BAL,                                                              ");
				strSQL.Append("  WIP_BAL,WIP_FREE_INV_BAL,                                                          ");
				strSQL.Append("  WHS_DESC,UMSR_DESC,WS_DESC,SCH_DESC                                                ");

				strSQL.Append("  FROM (                                                                             ");
				strSQL.Append("  SELECT                                                                             ");
				strSQL.Append("  D.SCH_ID,D.WS_CD,D.DISB_WHS WHS_CD,D.ITEM_NO,I.ITEM_DESC,I.ITEM_TYPE,              ");
				strSQL.Append("  D.SCH_DISB_DATE,ISNULL(INV.JOC_CD,CASE WHEN I.PO_TYPE = 4 THEN D.JOC_CD ELSE '*'   ");
				strSQL.Append("  END) JOC_CD,D.PLAN_QTY PLAN_QTY,D.ITEM_UMSR,                                       ");
				strSQL.Append("  D.WIP_ALLOC_QTY WIP_ALLOC_QTY,D.PLAN_DISB_QTY PLAN_DISB_QTY,                       ");
				strSQL.Append("  ISNULL(INV.INV_BAL,0) INV_BAL,ISNULL(INV.FREE_INV_BAL,0) FREE_INV_BAL,             ");
				strSQL.Append("  ISNULL(INV.WIP_BAL,0) WIP_BAL,ISNULL(INV.WIP_FREE_INV_BAL,0) WIP_FREE_INV_BAL      ");
				strSQL.Append("  ,W.WHS_DESC,S.DATA_CHAR UMSR_DESC,WS.WS_DESC,S2.DATA_CHAR SCH_DESC                 ");
                strSQL.Append("  ,ISNULL(J.ITEM_NO,ISNULL(P.ITEM_NO,PL.ITEM_NO)) PARENT_ITEM_NO             "); // 2011.04.01 Add
				//db.DbParametersClear();
				strSQL.Append("  FROM                                                                       ");
				strSQL.Append("  (SELECT SCH_ID,WS_CD,ITEM_NO,DISB_WHS,ORDER_NO,JOC_CD,                     ");
				strSQL.Append("  SUPPLY_TYPE,SCH_DISB_DATE,ALLOC_FLAG,DEMAND_STATUS,PLAN_QTY,ITEM_UMSR,     ");
				strSQL.Append("  WIP_ALLOC_QTY,PLAN_DISB_QTY,SUB_GRP_CD,SUB_ACTION_FLAG,ITEM_TYPE           ");
				strSQL.Append("  FROM PLANNED_DEMAND                                                        ");
				strSQL.Append("  WHERE ITEM_TYPE <> 99 AND ALLOC_FLAG = 2 ) D                               ");

				strSQL.Append("  INNER JOIN ITEM_MASTER I ON D.ITEM_NO = I.ITEM_NO                          ");
				strSQL.Append("  LEFT OUTER JOIN                                                            ");
				strSQL.Append("  (SELECT INV.WHS_CD, SWIP.WHS_CD SWHS_CD, WIP.WS_CD, INV.ITEM_NO,           ");
				strSQL.Append("  INV.JOC_CD, SWIP.SUPPLY_TYPE,SUM(ISNULL(INV.INV_BAL,0)) INV_BAL,           ");
				strSQL.Append("  SUM(ISNULL(INV.FREE_INV_BAL,0)) FREE_INV_BAL,                              ");
				strSQL.Append("  SUM(ISNULL(WIP.INV_BAL,0) + ISNULL(SWIP.INV_BAL,0)) WIP_BAL,               ");
				strSQL.Append("  SUM(ISNULL(WIP.FREE_INV_BAL,0) + ISNULL(SWIP.FREE_INV_BAL,0))              ");
				strSQL.Append("  WIP_FREE_INV_BAL                                                           ");
				strSQL.Append("  FROM                                                                       ");
				//倉庫在庫	
				strSQL.Append("  (SELECT I.WHS_CD, I.ITEM_NO, I.JOC_CD,SUM(ISNULL(I.INV_BAL,0)) INV_BAL,    ");
				strSQL.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
				strSQL.Append("  FROM INVENTORY_DETAIL I	                                                ");
				strSQL.Append("  INNER JOIN WAREHOUSE_MASTER W                                              ");
				strSQL.Append("  ON I.WHS_CD = W.WHS_CD AND W.WHS_TYPE = 0                                  ");
				strSQL.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 0 AND I.INV_TYPE = 0                 ");
				strSQL.Append("  GROUP BY I.WHS_CD, I.ITEM_NO, I.JOC_CD) INV                                ");
				strSQL.Append("  LEFT JOIN                                                                  ");
				//現場在庫
				strSQL.Append("  (SELECT I.WS_CD, I.ITEM_NO, I.JOC_CD,SUM(ISNULL(I.INV_BAL,0)) INV_BAL,     ");
				strSQL.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
				strSQL.Append("  FROM INVENTORY_DETAIL I	                                                ");
				strSQL.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 1 AND I.INV_TYPE = 0                 ");
				strSQL.Append("  GROUP BY I.WS_CD, I.ITEM_NO, I.JOC_CD) WIP                                 ");
				strSQL.Append("  ON INV.ITEM_NO = WIP.ITEM_NO AND INV.JOC_CD = WIP.JOC_CD                   ");
				strSQL.Append("  LEFT JOIN                                                                  ");
				//支給品倉庫在庫
				strSQL.Append("  (SELECT I.WHS_CD, I.ITEM_NO, I.JOC_CD, I.SUPPLY_TYPE,                      ");
				strSQL.Append("  SUM(ISNULL(I.INV_BAL,0)) INV_BAL,                                          ");
				strSQL.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
				strSQL.Append("  FROM INVENTORY_DETAIL I                                                    ");
				strSQL.Append("  INNER JOIN WAREHOUSE_MASTER W                                              ");
				strSQL.Append("  ON I.WHS_CD = W.WHS_CD AND W.WHS_TYPE = 2                                  ");
				strSQL.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 0 AND I.INV_TYPE = 0                 ");
				strSQL.Append("  GROUP BY I.WHS_CD, I.ITEM_NO, I.JOC_CD, I.SUPPLY_TYPE) SWIP                ");
				strSQL.Append("  ON INV.ITEM_NO = SWIP.ITEM_NO AND INV.JOC_CD = SWIP.JOC_CD                 ");
				strSQL.Append("  GROUP BY INV.WHS_CD, SWIP.WHS_CD, WIP.WS_CD, INV.ITEM_NO,                  ");
				strSQL.Append("  INV.JOC_CD, SWIP.SUPPLY_TYPE) INV                                          ");
				strSQL.Append("  ON D.DISB_WHS = INV.WHS_CD AND D.ITEM_NO = INV.ITEM_NO                     ");
				strSQL.Append("  AND (D.SUPPLY_TYPE = 0 AND D.WS_CD = INV.WS_CD OR D.SUPPLY_TYPE <> 0 AND INV.WS_CD = '') ");	// 2010.10.07 Sai
				strSQL.Append("  AND CASE WHEN I.PO_TYPE = 4 THEN D.JOC_CD ELSE '*' END = INV.JOC_CD        ");
				//strSQL.Append("  LEFT OUTER JOIN JOB_ORDER J ON D.ORDER_NO = J.ORDER_NO                     ");	// 2010.10.07 Sai DEL
				//strSQL.Append("  AND J.WS_CD=INV.WS_CD                                                      ");
                strSQL.Append("  LEFT OUTER JOIN JOB_ORDER J ON D.ORDER_NO = J.ORDER_NO                     ");	// 2011.04.01 復活
                strSQL.Append("  LEFT OUTER JOIN PUR_ORDER P ON D.ORDER_NO=P.ORDER_NO                       ");
                strSQL.Append("  LEFT OUTER JOIN PLANNED_ORDER PL ON D.ORDER_NO=PL.ORDER_NO                 ");	// 2011.04.01 Add
				strSQL.Append("  LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD=V.VENDOR_CD                 ");
				strSQL.Append("  AND CASE I.BOND_TYPE WHEN 1 THEN V.BOND_SUPPLY_WHS ELSE V.SUPPLY_WHS END   ");
				strSQL.Append("  =INV.SWHS_CD AND D.SUPPLY_TYPE=INV.SUPPLY_TYPE                             ");
				strSQL.Append("  LEFT OUTER JOIN PLANNED_ORDER PO ON ((D.ORDER_NO = PO.ORDER_NO             ");
				strSQL.Append("  AND PO.WS_CD=INV.WS_CD) OR (D.ORDER_NO = PO.ORDER_NO AND                   ");
				strSQL.Append("  PO.VENDOR_CD=V.VENDOR_CD                                                   ");
				strSQL.Append("  AND CASE I.BOND_TYPE WHEN 1 THEN V.BOND_SUPPLY_WHS ELSE V.SUPPLY_WHS END   ");
				strSQL.Append("  =INV.SWHS_CD AND D.SUPPLY_TYPE=INV.SUPPLY_TYPE))                           ");

				strSQL.Append("  LEFT OUTER JOIN WAREHOUSE_MASTER W ON D.DISB_WHS=W.WHS_CD                  ");
				strSQL.Append("  LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01='ITEM_UMSR'                  ");
				strSQL.Append("  AND S.KEY02= D.ITEM_UMSR                                                   ");
				strSQL.Append("  LEFT OUTER JOIN WORKSHOP_MASTER WS ON D.WS_CD=WS.WS_CD                     ");
				strSQL.Append("  LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01='SCH_ID'                   ");
				strSQL.Append("  AND S2.KEY02= D.SCH_ID                                                     ");
				strSQL.Append("  WHERE                                                                      ");
				strSQL.Append("  D.ALLOC_FLAG<>1 AND D.DEMAND_STATUS<=30                                    ");
				strSQL.Append("  AND (D.SUB_GRP_CD = '' OR                                                  ");
				strSQL.Append("  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))                            ");
				strSQL.Append("  AND D.ITEM_TYPE <> '99'                                                    ");
				if (item_no != "")
				{
					//strSQL.Append("  AND (J.ITEM_NO=@ITEM_NO OR P.ITEM_NO=@ITEM_NO OR PO.ITEM_NO=@ITEM_NO)         ");
                    strSQL.Append("  AND ISNULL(J.ITEM_NO,ISNULL(P.ITEM_NO,PL.ITEM_NO))=@ITEM_NO       ");	// 2011.04.01 Add
					db.DbPsetString("@ITEM_NO", _item_no);
				}
				if (sch_id != "")
				{
					strSQL.Append("  AND D.SCH_ID=@SCH_ID                                               ");
					db.DbPsetString("@SCH_ID", _sch_id);
				}
				if (ws_cd != "")
				{
					strSQL.Append("  AND D.WS_CD=@WS_CD                                                 ");
					db.DbPsetString("@WS_CD", _ws_cd);
				}
				if (whs_cd != "")
				{
					strSQL.Append("  AND D.DISB_WHS=@WHS_CD                                            ");
					db.DbPsetString("@WHS_CD", _whs_cd);
				}
				if (sch_disb_beg_date != 0)
				{
					strSQL.Append("  AND D.SCH_DISB_DATE>=@SCH_DISB_BEG_DATE                           ");
					db.DbPsetInt("@SCH_DISB_BEG_DATE", _sch_disb_beg_date);
				}
				if (sch_disb_end_date != 0)
				{
					strSQL.Append("  AND D.SCH_DISB_DATE<=@SCH_DISB_END_DATE                           ");
					db.DbPsetInt("@SCH_DISB_END_DATE", _sch_disb_end_date);
				}
                //-->ADD BY UBIQ-SUO 2011/3/10
                if (joc_cd != "")
                {
                    strSQL.Append("  AND ((I.PO_TYPE = 4 AND INV.JOC_CD=@JOC_CD ) OR (I.PO_TYPE <> 4)) ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }
                //<--ADD BY UBIQ-SUO 2011/3/10              
				/*
				strSQL.Append("  GROUP BY D.SCH_ID,D.WS_CD,D.DISB_WHS,D.ITEM_NO,I.ITEM_DESC,I.ITEM_TYPE,   ");
				strSQL.Append("  D.SCH_DISB_DATE,INV.JOC_CD,D.ITEM_UMSR,INV.INV_BAL,                        ");
				strSQL.Append("  INV.FREE_INV_BAL,INV.WIP_BAL,INV.WIP_FREE_INV_BAL,W.WHS_DESC,S.DATA_CHAR   ");
				*/
				strSQL.Append("  ) G                                                                        ");
				strSQL.Append("  GROUP BY SCH_ID,WS_CD,WHS_CD,ITEM_NO,ITEM_DESC,ITEM_TYPE,                  ");
				strSQL.Append("  SCH_DISB_DATE,JOC_CD,ITEM_UMSR,INV_BAL,                                    ");
				strSQL.Append("  FREE_INV_BAL,WIP_BAL,WIP_FREE_INV_BAL,WHS_DESC,UMSR_DESC,WS_DESC,SCH_DESC  ");
				strSQL.Append("  ORDER BY WHS_CD,WS_CD,SCH_DISB_DATE,ITEM_NO                                ");
				#endregion ### SQL SERVER ###
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
        /// 親オーダ情報を検索する
        /// 
        /// 2009.02.09 ADD BY CHEN
        /// 2009.06.10 ADD BY CHEN
        /// 
        /// 使用画面：InvShortInq
        /// </summary>
        public DataSet GetParentOrderList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                  ");
            /*---------------------ADD BEGIN --------------------*/
            strSQL.Append(" PLANNED_ORDER.ORDER_NO JOB_ORDER_NO,PLANNED_ORDER.ITEM_NO,              ");
            strSQL.Append(" PLANNED_ORDER.ITEM_DESC,PLANNED_ORDER.WS_CD,                            ");
            strSQL.Append(" CASE WHEN PLANNED_ORDER.SC_FLAG=0 THEN PLANNED_ORDER.ORDER_QTY          ");
            strSQL.Append(" ELSE PLANNED_ORDER.PO_QTY END PO_QTY,                                   ");
            strSQL.Append(" S.DATA_CHAR PO_UMSR,PLANNED_ORDER.JOC_CD,PLANNED_ORDER.SCH_START_DATE,  ");
            strSQL.Append(" PLANNED_ORDER.ALLOC_FLAG,PLANNED_ORDER.ORDER_NO,W.WS_DESC               ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PLANNED_ORDER                                                              ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON PLANNED_ORDER.WS_CD = W.WS_CD              ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'                           ");
                strSQL.Append(" AND S.KEY02 = CASE WHEN PLANNED_ORDER.SC_FLAG=0 THEN PLANNED_ORDER.ORDER_UMSR   ");
                strSQL.Append(" ELSE PLANNED_ORDER.PO_UMSR END WHERE PLANNED_ORDER.ORDER_NO                     ");
                strSQL.Append(" IN(SELECT PLANNED_DEMAND.ORDER_NO FROM PLANNED_DEMAND                           ");
                strSQL.Append(" WHERE PLANNED_DEMAND.DISB_WHS=:WHS_CD AND PLANNED_DEMAND.ITEM_NO=:ITEM_NO       ");
                strSQL.Append(" AND PLANNED_DEMAND.SCH_ID=:SCH_ID AND PLANNED_DEMAND.WS_CD=:WS_CD               ");
                strSQL.Append(" AND PLANNED_DEMAND.SCH_DISB_DATE=:SCH_DISB_DATE                                 ");
                strSQL.Append(" AND (PLANNED_DEMAND.SUB_GRP_CD = '' OR                                          ");
                strSQL.Append(" (PLANNED_DEMAND.SUB_GRP_CD <> '' AND PLANNED_DEMAND.SUB_ACTION_FLAG = 1))       ");
                strSQL.Append(" AND PLANNED_DEMAND.ITEM_TYPE <> '99'                                            ");
                if (_joc_cd != "*")
                {
                    strSQL.Append(" AND PLANNED_DEMAND.JOC_CD=:JOC_CD                                           ");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }

                strSQL.Append(" AND PLANNED_DEMAND.ALLOC_FLAG=2)                                            ");

                db.DbPsetString("SCH_ID", _sch_id);
                db.DbPsetString("WS_CD", _ws_cd);
                db.DbPsetString("WHS_CD", _whs_cd);
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetInt("SCH_DISB_DATE", _sch_disb_date);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PLANNED_ORDER                                                              ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON PLANNED_ORDER.WS_CD = W.WS_CD              ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'                           ");
                strSQL.Append(" AND S.KEY02 = CASE WHEN PLANNED_ORDER.SC_FLAG=0 THEN PLANNED_ORDER.ORDER_UMSR   ");
                strSQL.Append(" ELSE PLANNED_ORDER.PO_UMSR END WHERE PLANNED_ORDER.ORDER_NO                     ");
                strSQL.Append(" IN(SELECT PLANNED_DEMAND.ORDER_NO FROM PLANNED_DEMAND                           ");
                strSQL.Append(" WHERE PLANNED_DEMAND.DISB_WHS=@WHS_CD AND PLANNED_DEMAND.ITEM_NO=@ITEM_NO       ");
                strSQL.Append(" AND PLANNED_DEMAND.SCH_ID=@SCH_ID AND PLANNED_DEMAND.WS_CD=@WS_CD               ");
                strSQL.Append(" AND PLANNED_DEMAND.SCH_DISB_DATE=@SCH_DISB_DATE                                 ");
                strSQL.Append(" AND (PLANNED_DEMAND.SUB_GRP_CD = '' OR                                          ");
                strSQL.Append(" (PLANNED_DEMAND.SUB_GRP_CD <> '' AND PLANNED_DEMAND.SUB_ACTION_FLAG = 1))       ");
                strSQL.Append(" AND PLANNED_DEMAND.ITEM_TYPE <> '99'                                            ");
                if (_joc_cd != "*")
                {
                    strSQL.Append(" AND PLANNED_DEMAND.JOC_CD=@JOC_CD                                           ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }

                strSQL.Append(" AND PLANNED_DEMAND.ALLOC_FLAG=2)                                            ");

                db.DbPsetString("@SCH_ID", _sch_id);
                db.DbPsetString("@WS_CD", _ws_cd);
                db.DbPsetString("@WHS_CD", _whs_cd);
                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetInt("@SCH_DISB_DATE", _sch_disb_date);
            }
            strSQL.Append(" UNION ALL SELECT                                                            ");
            /*----------------------ADD END -------------------*/
            strSQL.Append(" PUR_ORDER.JOB_ORDER_NO,PUR_ORDER.ITEM_NO,PUR_ORDER.ITEM_DESC                ");
            strSQL.Append(" ,PUR_ORDER.WS_CD,PUR_ORDER.PO_QTY,S.DATA_CHAR PO_UMSR,PUR_ORDER.JOC_CD      ");
            strSQL.Append(" ,PUR_ORDER.SCH_START_DATE,PUR_ORDER.ALLOC_FLAG,PUR_ORDER.ORDER_NO,W.WS_DESC ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PUR_ORDER                                                      ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON PUR_ORDER.WS_CD = W.WS_CD      ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND S.KEY02 = PUR_ORDER.PO_UMSR                                     ");
                strSQL.Append(" WHERE PUR_ORDER.ORDER_NO IN(SELECT DEMAND.ORDER_NO FROM DEMAND      ");
                strSQL.Append(" WHERE DEMAND.DISB_WHS=:WHS_CD AND DEMAND.ITEM_NO=:ITEM_NO           ");
                strSQL.Append(" AND DEMAND.SCH_ID=@SCH_ID AND DEMAND.WS_CD=@WS_CD                   ");
                strSQL.Append(" AND DEMAND.SCH_DISB_DATE=:SCH_DISB_DATE                             ");
                strSQL.Append(" AND (DEMAND.SUB_GRP_CD = '' OR                           ");
                strSQL.Append(" (DEMAND.SUB_GRP_CD <> '' AND DEMAND.SUB_ACTION_FLAG = 1))    ");
                strSQL.Append(" AND DEMAND.ITEM_TYPE <> '99'                            ");
                if (_joc_cd != "*")
                {
                    strSQL.Append(" AND DEMAND.JOC_CD=:JOC_CD                                       ");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }

                strSQL.Append(" AND DEMAND.ALLOC_FLAG<>1 AND DEMAND.DEMAND_STATUS<=30)              ");

                db.DbPsetString("WHS_CD", _whs_cd);
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetInt("SCH_DISB_DATE", _sch_disb_date);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PUR_ORDER                                                      ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON PUR_ORDER.WS_CD = W.WS_CD      ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND S.KEY02 = PUR_ORDER.PO_UMSR                                     ");
                strSQL.Append(" WHERE PUR_ORDER.ORDER_NO IN(SELECT DEMAND.ORDER_NO FROM DEMAND      ");
                strSQL.Append(" WHERE DEMAND.DISB_WHS=@WHS_CD AND DEMAND.ITEM_NO=@ITEM_NO           ");
                strSQL.Append(" AND DEMAND.SCH_ID=@SCH_ID AND DEMAND.WS_CD=@WS_CD                   ");
                strSQL.Append(" AND DEMAND.SCH_DISB_DATE=@SCH_DISB_DATE                             ");
                strSQL.Append(" AND (DEMAND.SUB_GRP_CD = '' OR                           ");
                strSQL.Append(" (DEMAND.SUB_GRP_CD <> '' AND DEMAND.SUB_ACTION_FLAG = 1))    ");
                strSQL.Append(" AND DEMAND.ITEM_TYPE <> '99'                            ");
                if (_joc_cd != "*")
                {
                    strSQL.Append(" AND DEMAND.JOC_CD=@JOC_CD                                       ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }

                strSQL.Append(" AND DEMAND.ALLOC_FLAG<>1 AND DEMAND.DEMAND_STATUS<=30)              ");

                db.DbPsetString("@SCH_ID", _sch_id);
                db.DbPsetString("@WS_CD", _ws_cd);
                db.DbPsetString("@WHS_CD", _whs_cd);
                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetInt("@SCH_DISB_DATE", _sch_disb_date);
            }
            strSQL.Append(" UNION ALL SELECT                                                        ");
            strSQL.Append(" JOB_ORDER.JOB_ORDER_NO,JOB_ORDER.ITEM_NO,JOB_ORDER.ITEM_DESC            ");
            strSQL.Append(" ,JOB_ORDER.WS_CD,JOB_ORDER.JOB_ORDER_QTY PO_QTY,S.DATA_CHAR PO_UMSR     ");
            strSQL.Append(" ,JOB_ORDER.JOC_CD,JOB_ORDER.SCH_START_DATE,JOB_ORDER.ALLOC_FLAG         ");
            strSQL.Append(" ,JOB_ORDER.ORDER_NO,W.WS_DESC                                           ");

            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER                                                      ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON JOB_ORDER.WS_CD = W.WS_CD      ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND S.KEY02 = JOB_ORDER.ORDER_UMSR                                  ");
                strSQL.Append(" WHERE JOB_ORDER.ORDER_NO IN (SELECT DEMAND.ORDER_NO FROM DEMAND     ");
                strSQL.Append(" WHERE DEMAND.DISB_WHS=:WHS_CD AND DEMAND.ITEM_NO=:ITEM_NO           ");
                strSQL.Append(" AND DEMAND.SCH_ID=@SCH_ID AND DEMAND.WS_CD=:WS_CD                   ");
                strSQL.Append(" AND DEMAND.SCH_DISB_DATE=:SCH_DISB_DATE                             ");
                strSQL.Append(" AND (DEMAND.SUB_GRP_CD = '' OR                           ");
                strSQL.Append(" (DEMAND.SUB_GRP_CD <> '' AND DEMAND.SUB_ACTION_FLAG = 1))    ");
                strSQL.Append(" AND DEMAND.ITEM_TYPE <> '99'                            ");
                if (_joc_cd != "*")
                {
                    strSQL.Append(" AND DEMAND.JOC_CD=:JOC_CD                                       ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }

                strSQL.Append(" AND DEMAND.ALLOC_FLAG<>1 AND DEMAND.DEMAND_STATUS<=30)              ");

                db.DbPsetString("SCH_ID", _sch_id);
                db.DbPsetString("WS_CD", _ws_cd);
                db.DbPsetString("WHS_CD", _whs_cd);
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetInt("SCH_DISB_DATE", _sch_disb_date);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM JOB_ORDER                                                      ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W ON JOB_ORDER.WS_CD = W.WS_CD      ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND S.KEY02 = JOB_ORDER.ORDER_UMSR                                  ");
                strSQL.Append(" WHERE JOB_ORDER.ORDER_NO IN (SELECT DEMAND.ORDER_NO FROM DEMAND     ");
                strSQL.Append(" WHERE DEMAND.DISB_WHS=@WHS_CD AND DEMAND.ITEM_NO=@ITEM_NO           ");
                strSQL.Append(" AND DEMAND.SCH_ID=@SCH_ID AND DEMAND.WS_CD=@WS_CD                   ");
                strSQL.Append(" AND DEMAND.SCH_DISB_DATE=@SCH_DISB_DATE                             ");
                strSQL.Append(" AND (DEMAND.SUB_GRP_CD = '' OR                           ");
                strSQL.Append(" (DEMAND.SUB_GRP_CD <> '' AND DEMAND.SUB_ACTION_FLAG = 1))    ");
                strSQL.Append(" AND DEMAND.ITEM_TYPE <> '99'                            ");
                if (_joc_cd != "*")
                {
                    strSQL.Append(" AND DEMAND.JOC_CD=@JOC_CD                                       ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }

                strSQL.Append(" AND DEMAND.ALLOC_FLAG<>1 AND DEMAND.DEMAND_STATUS<=30)              ");

                db.DbPsetString("@SCH_ID", _sch_id);
                db.DbPsetString("@WS_CD", _ws_cd);
                db.DbPsetString("@WHS_CD", _whs_cd);
                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetInt("@SCH_DISB_DATE", _sch_disb_date);
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
        /// 引当解除処理
        /// 
        /// 使用画面：InvShortInq
        /// </summary>
        public int Inv_Unalloc_By_Demand_No()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_DEMAND_NO", _demand_no, ComConst.DB_IN);
            db.DbPsetString("@I_XFER_NO", _xfer_no, ComConst.DB_IN);
            db.DbPsetInt("@I_SEQ_NO", _seq_no, ComConst.DB_IN);
            db.DbPsetInt("@I_REQUEST_NO", _request_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_INV_UNALLOC_BY_DEMAND_NO");
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

        public int Wip_Unalloc_By_Demand_Seq_No()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_DEMAND_NO", _demand_no, ComConst.DB_IN);
            db.DbPsetInt("@I_SEQ_NO", _seq_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_WIP_UNALLOC_BY_DEMAND_SEQ_NO");
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
        /// 在庫データを検索
        /// 
        /// 使用画面：WipAdjReq
        /// </summary>
        public DataSet GetWipListByItemWs()//2008.04.07 ADD BY CHEN
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                              ");
            strSQL.Append(" INV.WHS_CD,                 INV.JOC_CD,         INV.LOT_NO,         ");
            strSQL.Append(" SUM(INV.INV_BAL) INV_BAL,   SUM(INV.ALLOC_QTY) ALLOC_QTY            ");
            strSQL.Append(" ,INV.JOB_ORDER_NO       "); // 2015.08.21
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL INV        ");
                strSQL.Append(" WHERE                      ");
                strSQL.Append(" INV.INV_YM=0                 ");
                strSQL.Append(" AND INV.INV_WIP_TYPE=1       ");
                strSQL.Append(" AND INV.INV_TYPE=0           ");
                strSQL.Append(" AND INV.ITEM_NO=:ITEM_NO     ");
                strSQL.Append(" AND INV.WS_CD=:WS_CD       ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WS_CD", _ws_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM INVENTORY_DETAIL INV        ");
                strSQL.Append(" WHERE                        ");
                strSQL.Append(" INV.INV_YM=0                 ");
                strSQL.Append(" AND INV.INV_WIP_TYPE=1       ");
                strSQL.Append(" AND INV.INV_TYPE=0           ");
                strSQL.Append(" AND INV.ITEM_NO=@ITEM_NO     ");
                strSQL.Append(" AND INV.WS_CD=@WS_CD         ");
                strSQL.Append(" AND (INV.INV_BAL <> 0        ");
                strSQL.Append(" OR  INV.ALLOC_QTY <> 0)      ");

                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WS_CD", _ws_cd);
            }
            strSQL.Append(" GROUP BY INV.WHS_CD,INV.JOC_CD,INV.LOT_NO  ");
            strSQL.Append(" ,INV.JOB_ORDER_NO       "); // 2015.08.21

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
        /// 欠品子部品情報と対応親品目情報を出力する
        /// 
        /// 
        /// 2009.09.09 ADD BY CHEN
        /// 使用画面：InvShortInq
        /// </summary>
        public DataSet GetInvShortItemList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();
            StringBuilder strSQL1 = new StringBuilder();

            strSQL1.Append("  SELECT                                                                             ");
            strSQL1.Append("  SCH_ID,WS_CD,WHS_CD,ITEM_NO,ITEM_DESC,ITEM_TYPE,                                   ");
            strSQL1.Append("  SCH_DISB_DATE,JOC_CD,SUM(PLAN_QTY) PLAN_QTY,                                       ");
            strSQL1.Append("  SUM(WIP_ALLOC_QTY) WIP_ALLOC_QTY,SUM(PLAN_DISB_QTY) PLAN_DISB_QTY,                 ");
            strSQL1.Append("  INV_BAL,FREE_INV_BAL,                                                              ");
            strSQL1.Append("  WIP_BAL,WIP_FREE_INV_BAL,                                                          ");
            strSQL1.Append("  WHS_DESC,ITEM_UMSR,WS_DESC,SCH_DESC                                                ");

            strSQL1.Append("  FROM (                                                                             ");
            strSQL1.Append("  SELECT                                                                             ");
            strSQL1.Append("  D.SCH_ID,D.WS_CD,D.DISB_WHS WHS_CD,D.ITEM_NO,I.ITEM_DESC,I.ITEM_TYPE,              ");
            strSQL1.Append("  D.SCH_DISB_DATE,ISNULL(INV.JOC_CD,CASE WHEN I.PO_TYPE = 4 THEN D.JOC_CD ELSE '*'   ");
            //strSQL1.Append("  END) JOC_CD,D.PLAN_QTY PLAN_QTY,D.ITEM_UMSR,                                       ");
            strSQL1.Append("  END) JOC_CD,D.PLAN_QTY PLAN_QTY,                                                   ");
            strSQL1.Append("  D.WIP_ALLOC_QTY WIP_ALLOC_QTY,D.PLAN_DISB_QTY PLAN_DISB_QTY,                       ");
            strSQL1.Append("  ISNULL(INV.INV_BAL,0) INV_BAL,ISNULL(INV.FREE_INV_BAL,0) FREE_INV_BAL,             ");
            strSQL1.Append("  ISNULL(INV.WIP_BAL,0) WIP_BAL,ISNULL(INV.WIP_FREE_INV_BAL,0) WIP_FREE_INV_BAL      ");
            strSQL1.Append("  ,W.WHS_DESC,S.DATA_CHAR ITEM_UMSR,WS.WS_DESC,S2.DATA_CHAR SCH_DESC                 ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();
                /*-----------upd--------------*/
                strSQL1.Append("  FROM ( SELECT SCH_ID,WS_CD,ITEM_NO,DISB_WHS,                               ");
                strSQL1.Append("  ORDER_NO,JOC_CD,SUPPLY_TYPE,SCH_DISB_DATE,                                 ");
                strSQL1.Append("  ALLOC_FLAG,DEMAND_STATUS,PLAN_QTY,ITEM_UMSR,                               ");
                strSQL1.Append("  WIP_ALLOC_QTY,PLAN_DISB_QTY,SUB_GRP_CD,SUB_ACTION_FLAG,ITEM_TYPE           ");
                strSQL1.Append("  FROM DEMAND                                                                ");
                strSQL1.Append("  WHERE ITEM_TYPE <> 99 AND DEMAND_STATUS <= 30 AND ALLOC_FLAG <> 1) D       ");
                /*------------upd------------*/
                strSQL1.Append("  INNER JOIN ITEM_MASTER I ON D.ITEM_NO = I.ITEM_NO                          ");
                strSQL1.Append("  LEFT OUTER JOIN                                                            ");
                strSQL1.Append("  (SELECT INV.WHS_CD, SWIP.WHS_CD SWHS_CD, WIP.WS_CD, INV.ITEM_NO,           ");
                strSQL1.Append("  INV.JOC_CD, SWIP.SUPPLY_TYPE,SUM(ISNULL(INV.INV_BAL,0)) INV_BAL,           ");
                strSQL1.Append("  SUM(ISNULL(INV.FREE_INV_BAL,0)) FREE_INV_BAL,                              ");
                strSQL1.Append("  SUM(ISNULL(WIP.INV_BAL,0) + ISNULL(SWIP.INV_BAL,0)) WIP_BAL,               ");
                strSQL1.Append("  SUM(ISNULL(WIP.FREE_INV_BAL,0) + ISNULL(SWIP.FREE_INV_BAL,0))              ");
                strSQL1.Append("  WIP_FREE_INV_BAL                                                           ");
                strSQL1.Append("  FROM                                                                       ");
                //倉庫在庫	
                strSQL1.Append("  (SELECT I.WHS_CD, I.ITEM_NO, I.JOC_CD,SUM(ISNULL(I.INV_BAL,0)) INV_BAL,    ");
                strSQL1.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
                strSQL1.Append("  FROM INVENTORY_DETAIL I	                                                ");
                strSQL1.Append("  INNER JOIN WAREHOUSE_MASTER W                                              ");
                strSQL1.Append("  ON I.WHS_CD = W.WHS_CD AND W.WHS_TYPE = 0                                  ");
                strSQL1.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 0 AND I.INV_TYPE = 0                 ");
                strSQL1.Append("  GROUP BY I.WHS_CD, I.ITEM_NO, I.JOC_CD) INV                                ");
                strSQL1.Append("  LEFT JOIN                                                                  ");
                //現場在庫
                strSQL1.Append("  (SELECT I.WS_CD, I.ITEM_NO, I.JOC_CD,SUM(ISNULL(I.INV_BAL,0)) INV_BAL,     ");
                strSQL1.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
                strSQL1.Append("  FROM INVENTORY_DETAIL I	                                                ");
                strSQL1.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 1 AND I.INV_TYPE = 0                 ");
                strSQL1.Append("  GROUP BY I.WS_CD, I.ITEM_NO, I.JOC_CD) WIP                                 ");
                strSQL1.Append("  ON INV.ITEM_NO = WIP.ITEM_NO AND INV.JOC_CD = WIP.JOC_CD                   ");
                strSQL1.Append("  LEFT JOIN                                                                  ");
                //支給品倉庫在庫
                strSQL1.Append("  (SELECT I.WHS_CD, I.ITEM_NO, I.JOC_CD, I.SUPPLY_TYPE,                      ");
                strSQL1.Append("  SUM(ISNULL(I.INV_BAL,0)) INV_BAL,                                          ");
                strSQL1.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
                strSQL1.Append("  FROM INVENTORY_DETAIL I                                                    ");
                strSQL1.Append("  INNER JOIN WAREHOUSE_MASTER W                                              ");
                strSQL1.Append("  ON I.WHS_CD = W.WHS_CD AND W.WHS_TYPE = 2                                  ");
                strSQL1.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 0 AND I.INV_TYPE = 0                 ");
                strSQL1.Append("  GROUP BY I.WHS_CD, I.ITEM_NO, I.JOC_CD, I.SUPPLY_TYPE) SWIP                ");
                strSQL1.Append("  ON INV.ITEM_NO = SWIP.ITEM_NO AND INV.JOC_CD = SWIP.JOC_CD                 ");
                strSQL1.Append("  GROUP BY INV.WHS_CD, SWIP.WHS_CD, WIP.WS_CD, INV.ITEM_NO,                  ");
                strSQL1.Append("  INV.JOC_CD, SWIP.SUPPLY_TYPE) INV                                          ");
                strSQL1.Append("  ON D.DISB_WHS = INV.WHS_CD AND D.ITEM_NO = INV.ITEM_NO                     ");
                strSQL1.Append("  AND CASE WHEN I.PO_TYPE = 4 THEN D.JOC_CD ELSE '*' END = INV.JOC_CD        ");
                strSQL1.Append("  LEFT OUTER JOIN JOB_ORDER J ON D.ORDER_NO = J.ORDER_NO                     ");
                strSQL1.Append("  AND J.WS_CD=INV.WS_CD                                                      ");
                strSQL1.Append("  LEFT OUTER JOIN PUR_ORDER P ON D.ORDER_NO=P.ORDER_NO                       ");
                strSQL1.Append("  LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD=V.VENDOR_CD                 ");
                strSQL1.Append("  AND CASE I.BOND_TYPE WHEN 1 THEN V.BOND_SUPPLY_WHS ELSE V.SUPPLY_WHS END   ");
                strSQL1.Append("  =INV.SWHS_CD AND D.SUPPLY_TYPE=INV.SUPPLY_TYPE                             ");
                strSQL1.Append("  LEFT OUTER JOIN PLANNED_ORDER PO ON ((D.ORDER_NO = PO.ORDER_NO             ");
                strSQL1.Append("  AND PO.WS_CD=INV.WS_CD) OR (D.ORDER_NO = PO.ORDER_NO AND                   ");
                strSQL1.Append("  PO.VENDOR_CD=V.VENDOR_CD                                                   ");
                strSQL1.Append("  AND CASE I.BOND_TYPE WHEN 1 THEN V.BOND_SUPPLY_WHS ELSE V.SUPPLY_WHS END   ");
                strSQL1.Append("  =INV.SWHS_CD AND D.SUPPLY_TYPE=INV.SUPPLY_TYPE))                           ");
                /*--------------------------------*/
                strSQL1.Append("  LEFT OUTER JOIN WAREHOUSE_MASTER W ON D.DISB_WHS=W.WHS_CD                  ");
                strSQL1.Append("  LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01='ITEM_UMSR'                  ");
                strSQL1.Append("  AND S.KEY02= D.ITEM_UMSR                                                   ");
                strSQL1.Append("  LEFT OUTER JOIN WORKSHOP_MASTER WS ON D.WS_CD=WS.WS_CD                     ");
                strSQL1.Append("  LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S.KEY01='SCH_ID'                    ");
                strSQL1.Append("  AND S2.KEY02= D.SCH_ID                                                     ");
                /*--------------------------------*/
                strSQL1.Append("  WHERE                                                                      ");
                strSQL1.Append("  D.ALLOC_FLAG<>1 AND D.DEMAND_STATUS<=30                                    ");
                strSQL1.Append("  AND (D.SUB_GRP_CD = '' OR                                                  ");
                strSQL1.Append("  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))                            ");
                strSQL1.Append("  AND D.ITEM_TYPE <> '99'                                                    ");
                if (item_no != "")
                {
                    strSQL1.Append("  AND (J.ITEM_NO=@ITEM_NO OR P.ITEM_NO=:ITEM_NO )         ");
                }
                if (sch_id != "")
                {
                    strSQL1.Append("  AND D.SCH_ID=:SCH_ID                                               ");
                }
                if (ws_cd != "")
                {
                    strSQL1.Append("  AND D.WS_CD=:WS_CD                                                 ");
                }
                if (whs_cd != "")
                {
                    strSQL1.Append("  AND D.DISB_WHS=:WHS_CD                                         ");
                }
                //-->ADD BY UBIQ-SUO 2011/3/10
                if (joc_cd != "")
                {
                    strSQL1.Append("  AND  INV.JOC_CD= :JOC_CD ");
                }               
                //<--ADD BY UBIQ-SUO 2011/3/10
                if (sch_disb_beg_date != 0)
                {
                    strSQL1.Append("  AND D.SCH_DISB_DATE>=:SCH_DISB_BEG_DATE                           ");
                }
                if (sch_disb_end_date != 0)
                {
                    strSQL1.Append("  AND D.SCH_DISB_DATE<=:SCH_DISB_END_DATE                           ");
                }
                strSQL1.Append("  ) G                                                                        ");
                strSQL1.Append("  GROUP BY SCH_ID,WS_CD,WHS_CD,ITEM_NO,ITEM_DESC,ITEM_TYPE,                  ");
                strSQL1.Append("  SCH_DISB_DATE,JOC_CD,ITEM_UMSR,INV_BAL,                                    ");
                strSQL1.Append("  FREE_INV_BAL,WIP_BAL,WIP_FREE_INV_BAL, WHS_DESC,UMSR_DESC,WS_DESC,SCH_DESC ");

                db.DbParametersClear();

                strSQL1.Append("  FROM                                                                       ");
                strSQL1.Append("  (SELECT SCH_ID,WS_CD,ITEM_NO,DISB_WHS,ORDER_NO,JOC_CD,                     ");
                strSQL1.Append("  SUPPLY_TYPE,SCH_DISB_DATE,ALLOC_FLAG,DEMAND_STATUS,PLAN_QTY,ITEM_UMSR,     ");
                strSQL1.Append("  WIP_ALLOC_QTY,PLAN_DISB_QTY,SUB_GRP_CD,SUB_ACTION_FLAG,ITEM_TYPE           ");
                strSQL1.Append("  FROM PLANNED_DEMAND                                                        ");
                strSQL1.Append("  WHERE ITEM_TYPE <> 99 AND ALLOC_FLAG = 2 ) D                               ");
                strSQL1.Append("  INNER JOIN ITEM_MASTER I ON D.ITEM_NO = I.ITEM_NO                          ");
                strSQL1.Append("  LEFT OUTER JOIN                                                            ");
                strSQL1.Append("  (SELECT INV.WHS_CD, SWIP.WHS_CD SWHS_CD, WIP.WS_CD, INV.ITEM_NO,           ");
                strSQL1.Append("  INV.JOC_CD, SWIP.SUPPLY_TYPE,SUM(ISNULL(INV.INV_BAL,0)) INV_BAL,           ");
                strSQL1.Append("  SUM(ISNULL(INV.FREE_INV_BAL,0)) FREE_INV_BAL,                              ");
                strSQL1.Append("  SUM(ISNULL(WIP.INV_BAL,0) + ISNULL(SWIP.INV_BAL,0)) WIP_BAL,               ");
                strSQL1.Append("  SUM(ISNULL(WIP.FREE_INV_BAL,0) + ISNULL(SWIP.FREE_INV_BAL,0))              ");
                strSQL1.Append("  WIP_FREE_INV_BAL                                                           ");
                strSQL1.Append("  FROM                                                                       ");
                //倉庫在庫	
                strSQL1.Append("  (SELECT I.WHS_CD, I.ITEM_NO, I.JOC_CD,SUM(ISNULL(I.INV_BAL,0)) INV_BAL,    ");
                strSQL1.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
                strSQL1.Append("  FROM INVENTORY_DETAIL I	                                                ");
                strSQL1.Append("  INNER JOIN WAREHOUSE_MASTER W                                              ");
                strSQL1.Append("  ON I.WHS_CD = W.WHS_CD AND W.WHS_TYPE = 0                                  ");
                strSQL1.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 0 AND I.INV_TYPE = 0                 ");
                strSQL1.Append("  GROUP BY I.WHS_CD, I.ITEM_NO, I.JOC_CD) INV                                ");
                strSQL1.Append("  LEFT JOIN                                                                  ");
                //現場在庫
                strSQL1.Append("  (SELECT I.WS_CD, I.ITEM_NO, I.JOC_CD,SUM(ISNULL(I.INV_BAL,0)) INV_BAL,     ");
                strSQL1.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
                strSQL1.Append("  FROM INVENTORY_DETAIL I	                                                ");
                strSQL1.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 1 AND I.INV_TYPE = 0                 ");
                strSQL1.Append("  GROUP BY I.WS_CD, I.ITEM_NO, I.JOC_CD) WIP                                 ");
                strSQL1.Append("  ON INV.ITEM_NO = WIP.ITEM_NO AND INV.JOC_CD = WIP.JOC_CD                   ");
                strSQL1.Append("  LEFT JOIN                                                                  ");
                //支給品倉庫在庫
                strSQL1.Append("  (SELECT I.WHS_CD, I.ITEM_NO, I.JOC_CD, I.SUPPLY_TYPE,                      ");
                strSQL1.Append("  SUM(ISNULL(I.INV_BAL,0)) INV_BAL,                                          ");
                strSQL1.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
                strSQL1.Append("  FROM INVENTORY_DETAIL I                                                    ");
                strSQL1.Append("  INNER JOIN WAREHOUSE_MASTER W                                              ");
                strSQL1.Append("  ON I.WHS_CD = W.WHS_CD AND W.WHS_TYPE = 2                                  ");
                strSQL1.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 0 AND I.INV_TYPE = 0                 ");
                strSQL1.Append("  GROUP BY I.WHS_CD, I.ITEM_NO, I.JOC_CD, I.SUPPLY_TYPE) SWIP                ");
                strSQL1.Append("  ON INV.ITEM_NO = SWIP.ITEM_NO AND INV.JOC_CD = SWIP.JOC_CD                 ");
                strSQL1.Append("  GROUP BY INV.WHS_CD, SWIP.WHS_CD, WIP.WS_CD, INV.ITEM_NO,                  ");
                strSQL1.Append("  INV.JOC_CD, SWIP.SUPPLY_TYPE) INV                                          ");
                strSQL1.Append("  ON D.DISB_WHS = INV.WHS_CD AND D.ITEM_NO = INV.ITEM_NO                     ");
                strSQL1.Append("  AND CASE WHEN I.PO_TYPE = 4 THEN D.JOC_CD ELSE '*' END = INV.JOC_CD        ");
                strSQL1.Append("  LEFT OUTER JOIN JOB_ORDER J ON D.ORDER_NO = J.ORDER_NO                     ");
                strSQL1.Append("  AND J.WS_CD=INV.WS_CD                                                      ");
                strSQL1.Append("  LEFT OUTER JOIN PUR_ORDER P ON D.ORDER_NO=P.ORDER_NO                       ");
                strSQL1.Append("  LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD=V.VENDOR_CD                 ");
                strSQL1.Append("  AND CASE I.BOND_TYPE WHEN 1 THEN V.BOND_SUPPLY_WHS ELSE V.SUPPLY_WHS END   ");
                strSQL1.Append("  =INV.SWHS_CD AND D.SUPPLY_TYPE=INV.SUPPLY_TYPE                             ");
                strSQL1.Append("  LEFT OUTER JOIN PLANNED_ORDER PO ON ((D.ORDER_NO = PO.ORDER_NO             ");
                strSQL1.Append("  AND PO.WS_CD=INV.WS_CD) OR (D.ORDER_NO = PO.ORDER_NO AND                   ");
                strSQL1.Append("  PO.VENDOR_CD=V.VENDOR_CD                                                   ");
                strSQL1.Append("  AND CASE I.BOND_TYPE WHEN 1 THEN V.BOND_SUPPLY_WHS ELSE V.SUPPLY_WHS END   ");
                strSQL1.Append("  =INV.SWHS_CD AND D.SUPPLY_TYPE=INV.SUPPLY_TYPE))                           ");

                strSQL1.Append("  LEFT OUTER JOIN WAREHOUSE_MASTER W ON D.DISB_WHS=W.WHS_CD                  ");
                strSQL1.Append("  LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01='ITEM_UMSR'                  ");
                strSQL1.Append("  AND S.KEY02= D.ITEM_UMSR                                                   ");
                strSQL1.Append("  LEFT OUTER JOIN WORKSHOP_MASTER WS ON D.WS_CD=WS.WS_CD                     ");
                strSQL1.Append("  LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01='SCH_ID'                   ");
                strSQL1.Append("  AND S2.KEY02= D.SCH_ID                                                     ");
                strSQL1.Append("  WHERE                                                                      ");
                strSQL1.Append("  D.ALLOC_FLAG<>1 AND D.DEMAND_STATUS<=30                                    ");
                strSQL1.Append("  AND (D.SUB_GRP_CD = '' OR                                                  ");
                strSQL1.Append("  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))                            ");
                strSQL1.Append("  AND D.ITEM_TYPE <> '99'                                                    ");
                if (item_no != "")
                {
                    strSQL1.Append("  AND (J.ITEM_NO=@ITEM_NO OR P.ITEM_NO=:ITEM_NO)         ");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (sch_id != "")
                {
                    strSQL1.Append("  AND D.SCH_ID=:SCH_ID                                               ");
                    db.DbPsetString("SCH_ID", _sch_id);
                }
                if (ws_cd != "")
                {
                    strSQL1.Append("  AND D.WS_CD=:WS_CD                                                 ");
                    db.DbPsetString("WS_CD", _ws_cd);
                }
                if (whs_cd != "")
                {
                    strSQL1.Append("  AND D.DISB_WHS=:WHS_CD                                            ");
                    db.DbPsetString("WHS_CD", _whs_cd);
                }
                //-->ADD BY UBIQ-SUO 2011/3/10
                if (joc_cd != "")
                {
                    strSQL1.Append("  AND  INV.JOC_CD= :JOC_CD ");
                    db.DbPsetString("JOC_CD", _joc_cd);
                }
                //if (joc_cd != "")
                //{
                //    strSQL1.Append("  AND ((I.PO_TYPE = 4 AND INV.JOC_CD=:JOC_CD ) OR (I.PO_TYPE <> 4)) ");
                //    db.DbPsetString("JOC_CD", _joc_cd);
                //}
                //<--ADD BY UBIQ-SUO 2011/3/10
                if (sch_disb_beg_date != 0)
                {
                    strSQL1.Append("  AND D.SCH_DISB_DATE>=:SCH_DISB_BEG_DATE                           ");
                    db.DbPsetInt("SCH_DISB_BEG_DATE", _sch_disb_beg_date);
                }
                if (sch_disb_end_date != 0)
                {
                    strSQL1.Append("  AND D.SCH_DISB_DATE<=:SCH_DISB_END_DATE                           ");
                    db.DbPsetInt("SCH_DISB_END_DATE", _sch_disb_end_date);
                }
                strSQL1.Append("  ) G                                                                        ");
                strSQL1.Append("  GROUP BY SCH_ID,WS_CD,WHS_CD,ITEM_NO,ITEM_DESC,ITEM_TYPE,                  ");
                strSQL1.Append("  SCH_DISB_DATE,JOC_CD,ITEM_UMSR,INV_BAL,                                    ");
                strSQL1.Append("  FREE_INV_BAL,WIP_BAL,WIP_FREE_INV_BAL,WHS_DESC,UMSR_DESC,WS_DESC,SCH_DESC  ");
            }
            else
            {
                db.DbParametersClear();
                /*-UPD BEGIN-*/
                strSQL1.Append("  FROM ( SELECT SCH_ID,WS_CD,ITEM_NO,DISB_WHS,                               ");
                strSQL1.Append("  ORDER_NO,JOC_CD,SUPPLY_TYPE,SCH_DISB_DATE,                                 ");
                strSQL1.Append("  ALLOC_FLAG,DEMAND_STATUS,PLAN_QTY,ITEM_UMSR,                               ");
                strSQL1.Append("  WIP_ALLOC_QTY,PLAN_DISB_QTY,SUB_GRP_CD,SUB_ACTION_FLAG,ITEM_TYPE           ");
                strSQL1.Append("  FROM DEMAND                                                                ");
                strSQL1.Append("  WHERE ITEM_TYPE <> 99 AND DEMAND_STATUS <= 30 AND ALLOC_FLAG <> 1) D       ");
                /*-UPD END-*/
                strSQL1.Append("  INNER JOIN ITEM_MASTER I ON D.ITEM_NO = I.ITEM_NO                          ");
                strSQL1.Append("  LEFT OUTER JOIN                                                            ");
                strSQL1.Append("  (SELECT INV.WHS_CD, SWIP.WHS_CD SWHS_CD, WIP.WS_CD, INV.ITEM_NO,           ");
                strSQL1.Append("  INV.JOC_CD, SWIP.SUPPLY_TYPE,SUM(ISNULL(INV.INV_BAL,0)) INV_BAL,           ");
                strSQL1.Append("  SUM(ISNULL(INV.FREE_INV_BAL,0)) FREE_INV_BAL,                              ");
                strSQL1.Append("  SUM(ISNULL(WIP.INV_BAL,0) + ISNULL(SWIP.INV_BAL,0)) WIP_BAL,               ");
                strSQL1.Append("  SUM(ISNULL(WIP.FREE_INV_BAL,0) + ISNULL(SWIP.FREE_INV_BAL,0))              ");
                strSQL1.Append("  WIP_FREE_INV_BAL                                                           ");
                strSQL1.Append("  FROM                                                                       ");
                //倉庫在庫	
                strSQL1.Append("  (SELECT I.WHS_CD, I.ITEM_NO, I.JOC_CD,SUM(ISNULL(I.INV_BAL,0)) INV_BAL,    ");
                strSQL1.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
                strSQL1.Append("  FROM INVENTORY_DETAIL I	                                                ");
                strSQL1.Append("  INNER JOIN WAREHOUSE_MASTER W                                              ");
                strSQL1.Append("  ON I.WHS_CD = W.WHS_CD AND W.WHS_TYPE = 0                                  ");
                strSQL1.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 0 AND I.INV_TYPE = 0                 ");
                strSQL1.Append("  GROUP BY I.WHS_CD, I.ITEM_NO, I.JOC_CD) INV                                ");
                strSQL1.Append("  LEFT JOIN                                                                  ");
                //現場在庫
                strSQL1.Append("  (SELECT I.WS_CD, I.ITEM_NO, I.JOC_CD,SUM(ISNULL(I.INV_BAL,0)) INV_BAL,     ");
                strSQL1.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
                strSQL1.Append("  FROM INVENTORY_DETAIL I	                                                ");
                strSQL1.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 1 AND I.INV_TYPE = 0                 ");
                strSQL1.Append("  GROUP BY I.WS_CD, I.ITEM_NO, I.JOC_CD) WIP                                 ");
                strSQL1.Append("  ON INV.ITEM_NO = WIP.ITEM_NO AND INV.JOC_CD = WIP.JOC_CD                   ");
                strSQL1.Append("  LEFT JOIN                                                                  ");
                //支給品倉庫在庫
                strSQL1.Append("  (SELECT I.WHS_CD, I.ITEM_NO, I.JOC_CD, I.SUPPLY_TYPE,                      ");
                strSQL1.Append("  SUM(ISNULL(I.INV_BAL,0)) INV_BAL,                                          ");
                strSQL1.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
                strSQL1.Append("  FROM INVENTORY_DETAIL I                                                    ");
                strSQL1.Append("  INNER JOIN WAREHOUSE_MASTER W                                              ");
                strSQL1.Append("  ON I.WHS_CD = W.WHS_CD AND W.WHS_TYPE = 2                                  ");
                strSQL1.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 0 AND I.INV_TYPE = 0                 ");
                strSQL1.Append("  GROUP BY I.WHS_CD, I.ITEM_NO, I.JOC_CD, I.SUPPLY_TYPE) SWIP                ");
                strSQL1.Append("  ON INV.ITEM_NO = SWIP.ITEM_NO AND INV.JOC_CD = SWIP.JOC_CD                 ");
                strSQL1.Append("  GROUP BY INV.WHS_CD, SWIP.WHS_CD, WIP.WS_CD, INV.ITEM_NO,                  ");
                strSQL1.Append("  INV.JOC_CD, SWIP.SUPPLY_TYPE) INV                                          ");
                strSQL1.Append("  ON D.DISB_WHS = INV.WHS_CD AND D.ITEM_NO = INV.ITEM_NO                     ");
                strSQL1.Append("  AND CASE WHEN I.PO_TYPE = 4 THEN D.JOC_CD ELSE '*' END = INV.JOC_CD        ");
                strSQL1.Append("  LEFT OUTER JOIN JOB_ORDER J ON D.ORDER_NO = J.ORDER_NO                     ");
                strSQL1.Append("  AND J.WS_CD=INV.WS_CD                                                      ");
                strSQL1.Append("  LEFT OUTER JOIN PUR_ORDER P ON D.ORDER_NO=P.ORDER_NO                       ");
                strSQL1.Append("  LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD=V.VENDOR_CD                 ");
                strSQL1.Append("  AND CASE I.BOND_TYPE WHEN 1 THEN V.BOND_SUPPLY_WHS ELSE V.SUPPLY_WHS END   ");
                strSQL1.Append("  =INV.SWHS_CD AND D.SUPPLY_TYPE=INV.SUPPLY_TYPE                             ");
                /*-ADD BEGIN-*/
                strSQL1.Append("  LEFT OUTER JOIN PLANNED_ORDER PO ON ((D.ORDER_NO = PO.ORDER_NO             ");
                strSQL1.Append("  AND PO.WS_CD=INV.WS_CD) OR (D.ORDER_NO = PO.ORDER_NO AND                   ");
                strSQL1.Append("  PO.VENDOR_CD=V.VENDOR_CD                                                   ");
                strSQL1.Append("  AND CASE I.BOND_TYPE WHEN 1 THEN V.BOND_SUPPLY_WHS ELSE V.SUPPLY_WHS END   ");
                strSQL1.Append("  =INV.SWHS_CD AND D.SUPPLY_TYPE=INV.SUPPLY_TYPE))                           ");
                strSQL1.Append("  LEFT OUTER JOIN WORKSHOP_MASTER WS ON D.WS_CD=WS.WS_CD                     ");
                strSQL1.Append("  LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01='SCH_ID'                   ");
                strSQL1.Append("  AND S2.KEY02= D.SCH_ID                                                     ");
                /*-ADD END-*/
                strSQL1.Append("  LEFT OUTER JOIN WAREHOUSE_MASTER W ON D.DISB_WHS=W.WHS_CD                  ");
                strSQL1.Append("  LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01='ITEM_UMSR'                  ");
                strSQL1.Append("  AND S.KEY02= D.ITEM_UMSR                                                   ");
                strSQL1.Append("  WHERE                                                                      ");
                strSQL1.Append("  D.ALLOC_FLAG<>1 AND D.DEMAND_STATUS<=30                                    ");
                strSQL1.Append("  AND (D.SUB_GRP_CD = '' OR                                                  ");
                strSQL1.Append("  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))                            ");
                strSQL1.Append("  AND D.ITEM_TYPE <> '99'                                                    ");
                if (item_no != "")
                {
                    strSQL1.Append("  AND (J.ITEM_NO=@ITEM_NO OR P.ITEM_NO=@ITEM_NO OR PO.ITEM_NO=@ITEM_NO)  ");
                }
                /*-----------ADD BEGIN-------------*/
                if (sch_id != "")
                {
                    strSQL1.Append("  AND D.SCH_ID=@SCH_ID                                               ");
                }
                if (ws_cd != "")
                {
                    strSQL1.Append("  AND D.WS_CD=@WS_CD                                                 ");
                }
                /*-----ADD END-------*/
                if (whs_cd != "")
                {
                    strSQL1.Append("  AND D.DISB_WHS=@WHS_CD                                            ");
                }
                //-->ADD BY UBIQ-SUO 2011/3/10
                if (joc_cd != "")
                {
                    strSQL1.Append("  AND INV.JOC_CD=@JOC_CD ");
                }

                //if (joc_cd != "")
                //{
                //    strSQL1.Append("  AND ((I.PO_TYPE = 4 AND INV.JOC_CD=@JOC_CD ) OR (I.PO_TYPE <> 4)) ");                    
                //}
                //<--ADD BY UBIQ-SUO 2011/3/10
                if (sch_disb_beg_date != 0)
                {
                    strSQL1.Append("  AND D.SCH_DISB_DATE>=@SCH_DISB_BEG_DATE                           ");
                }
                if (sch_disb_end_date != 0)
                {
                    strSQL1.Append("  AND D.SCH_DISB_DATE<=@SCH_DISB_END_DATE                           ");
                }

                strSQL1.Append("  ) G                                                                        ");
                strSQL1.Append("  GROUP BY SCH_ID,WS_CD,WHS_CD,ITEM_NO,ITEM_DESC,ITEM_TYPE,                  ");
                strSQL1.Append("  SCH_DISB_DATE,JOC_CD,INV_BAL,                                    ");
                strSQL1.Append("  FREE_INV_BAL,WIP_BAL,WIP_FREE_INV_BAL,WHS_DESC,ITEM_UMSR,WS_DESC,SCH_DESC  ");

                /*--------------------------------------------------------------*/
                strSQL1.Append("  UNION ALL SELECT                                                                   ");
                strSQL1.Append("  SCH_ID,WS_CD,WHS_CD,ITEM_NO,ITEM_DESC,ITEM_TYPE,                                   ");
                strSQL1.Append("  SCH_DISB_DATE,JOC_CD,SUM(PLAN_QTY) PLAN_QTY,                             ");
                strSQL1.Append("  SUM(WIP_ALLOC_QTY) WIP_ALLOC_QTY,SUM(PLAN_DISB_QTY) PLAN_DISB_QTY,                 ");
                strSQL1.Append("  INV_BAL,FREE_INV_BAL,                                                              ");
                strSQL1.Append("  WIP_BAL,WIP_FREE_INV_BAL,                                                          ");
                strSQL1.Append("  WHS_DESC,ITEM_UMSR,WS_DESC,SCH_DESC                                                ");

                strSQL1.Append("  FROM (                                                                             ");
                strSQL1.Append("  SELECT                                                                             ");
                strSQL1.Append("  D.SCH_ID,D.WS_CD,D.DISB_WHS WHS_CD,D.ITEM_NO,I.ITEM_DESC,I.ITEM_TYPE,              ");
                strSQL1.Append("  D.SCH_DISB_DATE,ISNULL(INV.JOC_CD,CASE WHEN I.PO_TYPE = 4 THEN D.JOC_CD ELSE '*'   ");
                strSQL1.Append("  END) JOC_CD,D.PLAN_QTY PLAN_QTY,                                       ");
                strSQL1.Append("  D.WIP_ALLOC_QTY WIP_ALLOC_QTY,D.PLAN_DISB_QTY PLAN_DISB_QTY,                       ");
                strSQL1.Append("  ISNULL(INV.INV_BAL,0) INV_BAL,ISNULL(INV.FREE_INV_BAL,0) FREE_INV_BAL,             ");
                strSQL1.Append("  ISNULL(INV.WIP_BAL,0) WIP_BAL,ISNULL(INV.WIP_FREE_INV_BAL,0) WIP_FREE_INV_BAL      ");
                strSQL1.Append("  ,W.WHS_DESC,S.DATA_CHAR ITEM_UMSR,WS.WS_DESC,S2.DATA_CHAR SCH_DESC                 ");
                //db.DbParametersClear();
                strSQL1.Append("  FROM                                                                       ");
                strSQL1.Append("  (SELECT SCH_ID,WS_CD,ITEM_NO,DISB_WHS,ORDER_NO,JOC_CD,                     ");
                strSQL1.Append("  SUPPLY_TYPE,SCH_DISB_DATE,ALLOC_FLAG,DEMAND_STATUS,PLAN_QTY,ITEM_UMSR,     ");
                strSQL1.Append("  WIP_ALLOC_QTY,PLAN_DISB_QTY,SUB_GRP_CD,SUB_ACTION_FLAG,ITEM_TYPE           ");
                strSQL1.Append("  FROM PLANNED_DEMAND                                                        ");
                strSQL1.Append("  WHERE ITEM_TYPE <> 99 AND ALLOC_FLAG = 2 ) D                               ");

                strSQL1.Append("  INNER JOIN ITEM_MASTER I ON D.ITEM_NO = I.ITEM_NO                          ");
                strSQL1.Append("  LEFT OUTER JOIN                                                            ");
                strSQL1.Append("  (SELECT INV.WHS_CD, SWIP.WHS_CD SWHS_CD, WIP.WS_CD, INV.ITEM_NO,           ");
                strSQL1.Append("  INV.JOC_CD, SWIP.SUPPLY_TYPE,SUM(ISNULL(INV.INV_BAL,0)) INV_BAL,           ");
                strSQL1.Append("  SUM(ISNULL(INV.FREE_INV_BAL,0)) FREE_INV_BAL,                              ");
                strSQL1.Append("  SUM(ISNULL(WIP.INV_BAL,0) + ISNULL(SWIP.INV_BAL,0)) WIP_BAL,               ");
                strSQL1.Append("  SUM(ISNULL(WIP.FREE_INV_BAL,0) + ISNULL(SWIP.FREE_INV_BAL,0))              ");
                strSQL1.Append("  WIP_FREE_INV_BAL                                                           ");
                strSQL1.Append("  FROM                                                                       ");
                //倉庫在庫	
                strSQL1.Append("  (SELECT I.WHS_CD, I.ITEM_NO, I.JOC_CD,SUM(ISNULL(I.INV_BAL,0)) INV_BAL,    ");
                strSQL1.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
                strSQL1.Append("  FROM INVENTORY_DETAIL I	                                                ");
                strSQL1.Append("  INNER JOIN WAREHOUSE_MASTER W                                              ");
                strSQL1.Append("  ON I.WHS_CD = W.WHS_CD AND W.WHS_TYPE = 0                                  ");
                strSQL1.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 0 AND I.INV_TYPE = 0                 ");
                strSQL1.Append("  GROUP BY I.WHS_CD, I.ITEM_NO, I.JOC_CD) INV                                ");
                strSQL1.Append("  LEFT JOIN                                                                  ");
                //現場在庫
                strSQL1.Append("  (SELECT I.WS_CD, I.ITEM_NO, I.JOC_CD,SUM(ISNULL(I.INV_BAL,0)) INV_BAL,     ");
                strSQL1.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
                strSQL1.Append("  FROM INVENTORY_DETAIL I	                                                ");
                strSQL1.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 1 AND I.INV_TYPE = 0                 ");
                strSQL1.Append("  GROUP BY I.WS_CD, I.ITEM_NO, I.JOC_CD) WIP                                 ");
                strSQL1.Append("  ON INV.ITEM_NO = WIP.ITEM_NO AND INV.JOC_CD = WIP.JOC_CD                   ");
                strSQL1.Append("  LEFT JOIN                                                                  ");
                //支給品倉庫在庫
                strSQL1.Append("  (SELECT I.WHS_CD, I.ITEM_NO, I.JOC_CD, I.SUPPLY_TYPE,                      ");
                strSQL1.Append("  SUM(ISNULL(I.INV_BAL,0)) INV_BAL,                                          ");
                strSQL1.Append("  SUM(ISNULL(I.INV_BAL,0) - ISNULL(I.ALLOC_QTY,0)) FREE_INV_BAL              ");
                strSQL1.Append("  FROM INVENTORY_DETAIL I                                                    ");
                strSQL1.Append("  INNER JOIN WAREHOUSE_MASTER W                                              ");
                strSQL1.Append("  ON I.WHS_CD = W.WHS_CD AND W.WHS_TYPE = 2                                  ");
                strSQL1.Append("  WHERE I.INV_YM= 0 AND I.INV_WIP_TYPE= 0 AND I.INV_TYPE = 0                 ");
                strSQL1.Append("  GROUP BY I.WHS_CD, I.ITEM_NO, I.JOC_CD, I.SUPPLY_TYPE) SWIP                ");
                strSQL1.Append("  ON INV.ITEM_NO = SWIP.ITEM_NO AND INV.JOC_CD = SWIP.JOC_CD                 ");
                strSQL1.Append("  GROUP BY INV.WHS_CD, SWIP.WHS_CD, WIP.WS_CD, INV.ITEM_NO,                  ");
                strSQL1.Append("  INV.JOC_CD, SWIP.SUPPLY_TYPE) INV                                          ");
                strSQL1.Append("  ON D.DISB_WHS = INV.WHS_CD AND D.ITEM_NO = INV.ITEM_NO                     ");
                strSQL1.Append("  AND CASE WHEN I.PO_TYPE = 4 THEN D.JOC_CD ELSE '*' END = INV.JOC_CD        ");
                strSQL1.Append("  LEFT OUTER JOIN JOB_ORDER J ON D.ORDER_NO = J.ORDER_NO                     ");
                strSQL1.Append("  AND J.WS_CD=INV.WS_CD                                                      ");
                strSQL1.Append("  LEFT OUTER JOIN PUR_ORDER P ON D.ORDER_NO=P.ORDER_NO                       ");
                strSQL1.Append("  LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD=V.VENDOR_CD                 ");
                strSQL1.Append("  AND CASE I.BOND_TYPE WHEN 1 THEN V.BOND_SUPPLY_WHS ELSE V.SUPPLY_WHS END   ");
                strSQL1.Append("  =INV.SWHS_CD AND D.SUPPLY_TYPE=INV.SUPPLY_TYPE                             ");
                strSQL1.Append("  LEFT OUTER JOIN PLANNED_ORDER PO ON ((D.ORDER_NO = PO.ORDER_NO             ");
                strSQL1.Append("  AND PO.WS_CD=INV.WS_CD) OR (D.ORDER_NO = PO.ORDER_NO AND                   ");
                strSQL1.Append("  PO.VENDOR_CD=V.VENDOR_CD                                                   ");
                strSQL1.Append("  AND CASE I.BOND_TYPE WHEN 1 THEN V.BOND_SUPPLY_WHS ELSE V.SUPPLY_WHS END   ");
                strSQL1.Append("  =INV.SWHS_CD AND D.SUPPLY_TYPE=INV.SUPPLY_TYPE))                           ");

                strSQL1.Append("  LEFT OUTER JOIN WAREHOUSE_MASTER W ON D.DISB_WHS=W.WHS_CD                  ");
                strSQL1.Append("  LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01='ITEM_UMSR'                  ");
                strSQL1.Append("  AND S.KEY02= D.ITEM_UMSR                                                   ");
                strSQL1.Append("  LEFT OUTER JOIN WORKSHOP_MASTER WS ON D.WS_CD=WS.WS_CD                     ");
                strSQL1.Append("  LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01='SCH_ID'                   ");
                strSQL1.Append("  AND S2.KEY02= D.SCH_ID                                                     ");
                strSQL1.Append("  WHERE                                                                      ");
                strSQL1.Append("  D.ALLOC_FLAG<>1 AND D.DEMAND_STATUS<=30                                    ");
                strSQL1.Append("  AND (D.SUB_GRP_CD = '' OR                                                  ");
                strSQL1.Append("  (D.SUB_GRP_CD <> '' AND D.SUB_ACTION_FLAG = 1))                            ");
                strSQL1.Append("  AND D.ITEM_TYPE <> '99'                                                    ");
                if (item_no != "")
                {
                    strSQL1.Append("  AND (J.ITEM_NO=@ITEM_NO OR P.ITEM_NO=@ITEM_NO OR PO.ITEM_NO=@ITEM_NO)         ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (sch_id != "")
                {
                    strSQL1.Append("  AND D.SCH_ID=@SCH_ID                                               ");
                    db.DbPsetString("@SCH_ID", _sch_id);
                }
                if (ws_cd != "")
                {
                    strSQL1.Append("  AND D.WS_CD=@WS_CD                                                 ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (whs_cd != "")
                {
                    strSQL1.Append("  AND D.DISB_WHS=@WHS_CD                                            ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }
                //-->ADD BY UBIQ-SUO 2011/3/10
                if (joc_cd != "")
                {
                    strSQL1.Append("  AND INV.JOC_CD=@JOC_CD ");
                    db.DbPsetString("@JOC_CD", _joc_cd);
                }               
                //<--ADD BY UBIQ-SUO 2011/3/10
                if (sch_disb_beg_date != 0)
                {
                    strSQL1.Append("  AND D.SCH_DISB_DATE>=@SCH_DISB_BEG_DATE                           ");
                    db.DbPsetInt("@SCH_DISB_BEG_DATE", _sch_disb_beg_date);
                }
                if (sch_disb_end_date != 0)
                {
                    strSQL1.Append("  AND D.SCH_DISB_DATE<=@SCH_DISB_END_DATE                           ");
                    db.DbPsetInt("@SCH_DISB_END_DATE", _sch_disb_end_date);
                }

                strSQL1.Append("  ) G                                                                        ");
                strSQL1.Append("  GROUP BY SCH_ID,WS_CD,WHS_CD,ITEM_NO,ITEM_DESC,ITEM_TYPE,                  ");
                strSQL1.Append("  SCH_DISB_DATE,JOC_CD,INV_BAL,                                              ");
                strSQL1.Append("  FREE_INV_BAL,WIP_BAL,WIP_FREE_INV_BAL,WHS_DESC,ITEM_UMSR,WS_DESC,SCH_DESC  ");
            }

            //--- sql 
            strSQL.Append("  SELECT                                                                             ");
            strSQL.Append("  SCH_ID,        WS_CD,          WS_DESC,        WHS_CD,         WHS_DESC,           ");
            strSQL.Append("  ITEM_NO,       SCH_DISB_DATE, JOC_CD,          PARENT_ITEM_NO,      ITEM_DESC,     ");
            strSQL.Append("  ITEM_TYPE,     SCH_START_DATE, PARENT_JOC_CD,  PLAN_QTY,                           ");
            strSQL.Append("  ITEM_UMSR,     WIP_ALLOC_QTY,  PLAN_DISB_QTY,                                      ");
            strSQL.Append("  INV_BAL,       FREE_INV_BAL,   WIP_BAL,        WIP_FREE_INV_BAL,                   ");
            strSQL.Append("  PO_UMSR,       ORDER_NO,       CHILD_FLAG FROM(                                    ");
            strSQL.Append("  SELECT                                                                             ");
            strSQL.Append("  SCH_ID,        WS_CD,          WS_DESC,        WHS_CD,             WHS_DESC,       ");
            strSQL.Append("  ITEM_NO,       SCH_DISB_DATE,  JOC_CD,         '' AS PARENT_ITEM_NO,ITEM_DESC,     ");
            strSQL.Append("  ITEM_TYPE,     0 AS SCH_START_DATE,            '' AS PARENT_JOC_CD,PLAN_QTY,       ");
            strSQL.Append("  ITEM_UMSR,     WIP_ALLOC_QTY, PLAN_DISB_QTY,                                       ");
            strSQL.Append("  INV_BAL,       FREE_INV_BAL,   WIP_BAL,    WIP_FREE_INV_BAL,                       ");
            strSQL.Append("  '' AS PO_UMSR, '' AS ORDER_NO, 1 AS CHILD_FLAG                                     ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append("  FROM (                                                                          ");
                strSQL.Append(strSQL1);
                strSQL.Append("   ) SHORTITEM                    ");
            }
            else
            {
                strSQL.Append("  FROM (                                                                     ");
                strSQL.Append(strSQL1);
                strSQL.Append("  ) SHORTITEM                                                                ");
            }

            strSQL.Append("  UNION ALL SELECT                                                                   ");
            strSQL.Append("  SHORTITEM.SCH_ID,          SHORTITEM.WS_CD,            SHORTITEM.WS_DESC,          ");
            strSQL.Append("  SHORTITEM.WHS_CD,          SHORTITEM.WHS_DESC,         SHORTITEM.ITEM_NO,          ");
            strSQL.Append("  SHORTITEM.SCH_DISB_DATE,   SHORTITEM.JOC_CD,                                       ");
            strSQL.Append("  PLANNED_ORDER.ITEM_NO PARENT_ITEM_NO,                  PLANNED_ORDER.ITEM_DESC,    ");
            strSQL.Append("  PLANNED_ORDER.ITEM_TYPE,   PLANNED_ORDER.SCH_START_DATE,             ");
            strSQL.Append("  PLANNED_ORDER.JOC_CD PARENT_JOC_CD,PLANNED_DEMAND.PLAN_QTY,     S2.DATA_CHAR ITEM_UMSR,    ");
            strSQL.Append("  PLANNED_DEMAND.WIP_ALLOC_QTY,      PLANNED_DEMAND.PLAN_DISB_QTY,                   ");
            strSQL.Append("  INV_BAL = CASE WHEN PLANNED_ORDER.SC_FLAG=0 THEN PLANNED_ORDER.ORDER_QTY ELSE PLANNED_ORDER.PO_QTY END,        ");
            strSQL.Append("  0 AS FREE_INV_BAL,         0 AS WIP_BAL,                0 AS WIP_FREE_INV_BAL,     ");
            strSQL.Append("  S.DATA_CHAR PO_UMSR,       PLANNED_ORDER.ORDER_NO,      0 AS CHILD_FLAG            ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append("  FROM (                                                                     ");
                strSQL.Append(strSQL1);
                strSQL.Append("  ) SHORTITEM                    ");
                strSQL.Append(" LEFT OUTER JOIN PLANNED_DEMAND ON SHORTITEM.WHS_CD = PLANNED_DEMAND.WHS_CD  ");
                strSQL.Append(" AND SHORTITEM.ITEM_NO = PLANNED_DEMAND.ITEM_NO                              ");
                strSQL.Append(" AND SHORTITEM.SCH_ID = PLANNED_DEMAND.SCH_ID                                ");
                strSQL.Append(" AND SHORTITEM.WS_CD = PLANNED_DEMAND.WS_CD                                  ");
                strSQL.Append(" AND SHORTITEM.SCH_DISB_DATE = PLANNED_DEMAND.SCH_DISB_DATE                  ");
                strSQL.Append(" AND (SHORTITEM.JOC_CD = '*' OR SHORTITEM.JOC_CD = PLANNED_DEMAND.JOC_CD )   ");
                strSQL.Append(" AND PLANNED_DEMAND.ALLOC_FLAG = 2                                           ");
                strSQL.Append(" LEFT OUTER JOIN PLANNED_ORDER                                               ");
                strSQL.Append(" ON PLANNED_DEMAND.ORDER_NO = PLANNED_ORDER.ORDER_NO                         ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER                                             ");
                strSQL.Append(" ON PLANNED_ORDER.WS_CD = WORKSHOP_MASTER.WS_CD                              ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'                 ");
                strSQL.Append(" AND S.KEY02 = CASE WHEN SC_FLAG=0 THEN PLANNED_ORDER.ORDER_UMSR ELSE PLANNED_ORDER.PO_UMSR END  ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND S2.KEY02 = PLANNED_DEMAND.ITEM_UMSR                                     ");
            }
            else
            {
                strSQL.Append("  FROM (                                                                     ");
                strSQL.Append(strSQL1);
                strSQL.Append("  ) SHORTITEM                    ");
                strSQL.Append(" INNER JOIN PLANNED_DEMAND ON SHORTITEM.WHS_CD = PLANNED_DEMAND.DISB_WHS ");
                strSQL.Append(" AND SHORTITEM.ITEM_NO = PLANNED_DEMAND.ITEM_NO                              ");
                strSQL.Append(" AND SHORTITEM.SCH_ID = PLANNED_DEMAND.SCH_ID                                ");
                strSQL.Append(" AND SHORTITEM.WS_CD = PLANNED_DEMAND.WS_CD                                  ");
                strSQL.Append(" AND SHORTITEM.SCH_DISB_DATE = PLANNED_DEMAND.SCH_DISB_DATE                  ");
                strSQL.Append(" AND (SHORTITEM.JOC_CD = '*' OR SHORTITEM.JOC_CD = PLANNED_DEMAND.JOC_CD )   ");
                strSQL.Append(" AND PLANNED_DEMAND.ALLOC_FLAG = 2                                           ");
                strSQL.Append(" INNER JOIN PLANNED_ORDER                                               ");
                strSQL.Append(" ON PLANNED_DEMAND.ORDER_NO = PLANNED_ORDER.ORDER_NO                         ");
                strSQL.Append(" INNER JOIN WORKSHOP_MASTER                                             ");
                strSQL.Append(" ON PLANNED_ORDER.WS_CD = WORKSHOP_MASTER.WS_CD                              ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'                 ");
                strSQL.Append(" AND S.KEY02 = CASE WHEN PLANNED_ORDER.SC_FLAG=0 THEN PLANNED_ORDER.ORDER_UMSR ELSE PLANNED_ORDER.PO_UMSR END  ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND S2.KEY02 = PLANNED_DEMAND.ITEM_UMSR                                     ");
            }

            strSQL.Append("  UNION ALL SELECT                                                                   ");
            strSQL.Append("  SHORTITEM.SCH_ID,          SHORTITEM.WS_CD,            SHORTITEM.WS_DESC,          ");
            strSQL.Append("  SHORTITEM.WHS_CD,          SHORTITEM.WHS_DESC,         SHORTITEM.ITEM_NO,          ");
            strSQL.Append("  SHORTITEM.SCH_DISB_DATE,   SHORTITEM.JOC_CD,                                       ");
            strSQL.Append("  PUR_ORDER.ITEM_NO PARENT_ITEM_NO,                      PUR_ORDER.ITEM_DESC,        ");
            strSQL.Append("  PUR_ORDER.ITEM_TYPE,       PUR_ORDER.SCH_START_DATE,                               ");
            strSQL.Append("  PUR_ORDER.JOC_CD PARENT_JOC_CD,DEMAND.PLAN_QTY,        S2.DATA_CHAR ITEM_UMSR,     ");
            strSQL.Append("  DEMAND.WIP_ALLOC_QTY,      DEMAND.PLAN_DISB_QTY,                                   ");
            strSQL.Append("  PUR_ORDER.PO_QTY INV_BAL,                                                          ");
            strSQL.Append("  0 AS FREE_INV_BAL,         0 AS WIP_BAL,               0 AS WIP_FREE_INV_BAL,      ");
            strSQL.Append("  S.DATA_CHAR PO_UMSR,       PUR_ORDER.JOB_ORDER_NO ORDER_NO, 0 AS CHILD_FLAG        ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append("  FROM (                                                                     ");
                strSQL.Append(strSQL1);
                strSQL.Append("  ) SHORTITEM                    ");
                strSQL.Append(" LEFT OUTER JOIN DEMAND ON SHORTITEM.WHS_CD = DEMAND.WHS_CD                  ");
                strSQL.Append(" AND SHORTITEM.ITEM_NO = DEMAND.ITEM_NO                                      ");
                strSQL.Append(" AND SHORTITEM.SCH_ID = DEMAND.SCH_ID                                        ");
                strSQL.Append(" AND SHORTITEM.WS_CD = DEMAND.WS_CD                                          ");
                strSQL.Append(" AND SHORTITEM.SCH_DISB_DATE = DEMAND.SCH_DISB_DATE                          ");
                strSQL.Append(" AND (SHORTITEM.JOC_CD = '*' OR SHORTITEM.JOC_CD = DEMAND.JOC_CD )           ");
                strSQL.Append(" AND DEMAND.ALLOC_FLAG <> 1                                                  ");
                strSQL.Append(" AND DEMAND.DEMAND_STATUS <= 30                                              ");
                strSQL.Append(" LEFT OUTER JOIN PUR_ORDER                                                   ");
                strSQL.Append(" ON  DEMAND.ORDER_NO = PUR_ORDER.ORDER_NO                                    ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER                                             ");
                strSQL.Append(" ON PUR_ORDER.WS_CD = WORKSHOP_MASTER.WS_CD                                  ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'                 ");
                strSQL.Append(" AND S.KEY02 = PUR_ORDER.PO_UMSR                                             ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND S2.KEY02 = DEMAND.ITEM_UMSR                                             ");
            }
            else
            {
                strSQL.Append("  FROM (                                                                     ");
                strSQL.Append(strSQL1);
                strSQL.Append("  ) SHORTITEM                    ");
                strSQL.Append(" INNER JOIN DEMAND ON SHORTITEM.WHS_CD = DEMAND.DISB_WHS                ");
                strSQL.Append(" AND SHORTITEM.ITEM_NO = DEMAND.ITEM_NO                                      ");
                strSQL.Append(" AND SHORTITEM.SCH_ID = DEMAND.SCH_ID                                        ");
                strSQL.Append(" AND SHORTITEM.WS_CD = DEMAND.WS_CD                                          ");
                strSQL.Append(" AND SHORTITEM.SCH_DISB_DATE = DEMAND.SCH_DISB_DATE                          ");
                strSQL.Append(" AND (SHORTITEM.JOC_CD = '*' OR SHORTITEM.JOC_CD = DEMAND.JOC_CD )           ");
                strSQL.Append(" AND DEMAND.ALLOC_FLAG <> 1                                                  ");
                strSQL.Append(" AND DEMAND.DEMAND_STATUS <= 30                                              ");
                strSQL.Append(" INNER JOIN PUR_ORDER                                                   ");
                strSQL.Append(" ON  DEMAND.ORDER_NO = PUR_ORDER.ORDER_NO                                    ");
                strSQL.Append(" INNER JOIN WORKSHOP_MASTER                                             ");
                strSQL.Append(" ON PUR_ORDER.WS_CD = WORKSHOP_MASTER.WS_CD                                  ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'                 ");
                strSQL.Append(" AND S.KEY02 = PUR_ORDER.PO_UMSR                                             ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND S2.KEY02 = DEMAND.ITEM_UMSR                                             ");

            }
            strSQL.Append("  UNION ALL SELECT                                                                   ");
            strSQL.Append("  SHORTITEM.SCH_ID,          SHORTITEM.WS_CD,            SHORTITEM.WS_DESC,          ");
            strSQL.Append("  SHORTITEM.WHS_CD,          SHORTITEM.WHS_DESC,         SHORTITEM.ITEM_NO,          ");
            strSQL.Append("  SHORTITEM.SCH_DISB_DATE,   SHORTITEM.JOC_CD,                                       ");
            strSQL.Append("  JOB_ORDER.ITEM_NO PARENT_ITEM_NO,                      JOB_ORDER.ITEM_DESC,        ");
            strSQL.Append("  JOB_ORDER.ITEM_TYPE,       JOB_ORDER.SCH_START_DATE,                               ");
            strSQL.Append("  JOB_ORDER.JOC_CD PARENT_JOC_CD,DEMAND.PLAN_QTY,        S2.DATA_CHAR ITEM_UMSR,     ");
            strSQL.Append("  DEMAND.WIP_ALLOC_QTY,      DEMAND.PLAN_DISB_QTY,                                   ");
            strSQL.Append("  JOB_ORDER.JOB_ORDER_QTY INV_BAL,                                                   ");
            strSQL.Append("  0 AS FREE_INV_BAL,         0 AS WIP_BAL,               0 AS WIP_FREE_INV_BAL,      ");
            strSQL.Append("  S.DATA_CHAR PO_UMSR,       JOB_ORDER.JOB_ORDER_NO ORDER_NO, 0 AS CHILD_FLAG        ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append("  FROM (                                                                     ");
                strSQL.Append(strSQL1);
                strSQL.Append("  ) SHORTITEM                    ");
                strSQL.Append(" LEFT OUTER JOIN DEMAND ON SHORTITEM.WHS_CD = DEMAND.WHS_CD                  ");
                strSQL.Append(" AND SHORTITEM.ITEM_NO = DEMAND.ITEM_NO                                      ");
                strSQL.Append(" AND SHORTITEM.SCH_ID = DEMAND.SCH_ID                                        ");
                strSQL.Append(" AND SHORTITEM.WS_CD = DEMAND.WS_CD                                          ");
                strSQL.Append(" AND SHORTITEM.SCH_DISB_DATE = DEMAND.SCH_DISB_DATE                          ");
                strSQL.Append(" AND (SHORTITEM.JOC_CD = '*' OR SHORTITEM.JOC_CD = DEMAND.JOC_CD )           ");
                strSQL.Append(" AND DEMAND.ALLOC_FLAG <> 1                                                  ");
                strSQL.Append(" AND DEMAND.DEMAND_STATUS <= 30                                              ");
                strSQL.Append(" LEFT OUTER JOIN PUR_ORDER                                                   ");
                strSQL.Append(" ON  DEMAND.ORDER_NO = PUR_ORDER.ORDER_NO                                    ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER                                             ");
                strSQL.Append(" ON PUR_ORDER.WS_CD = WORKSHOP_MASTER.WS_CD                                  ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'                 ");
                strSQL.Append(" AND S.KEY02 = PUR_ORDER.PO_UMSR                                             ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND S2.KEY02 = DEMAND.ITEM_UMSR )                                           ");

            }
            else
            {
                strSQL.Append("  FROM (                                                                     ");
                strSQL.Append(strSQL1);
                strSQL.Append("  ) SHORTITEM                    ");
                strSQL.Append(" INNER JOIN DEMAND ON SHORTITEM.WHS_CD = DEMAND.DISB_WHS                ");
                strSQL.Append(" AND SHORTITEM.ITEM_NO = DEMAND.ITEM_NO                                      ");
                strSQL.Append(" AND SHORTITEM.SCH_ID = DEMAND.SCH_ID                                        ");
                strSQL.Append(" AND SHORTITEM.WS_CD = DEMAND.WS_CD                                          ");
                strSQL.Append(" AND SHORTITEM.SCH_DISB_DATE = DEMAND.SCH_DISB_DATE                          ");
                strSQL.Append(" AND (SHORTITEM.JOC_CD = '*' OR SHORTITEM.JOC_CD = DEMAND.JOC_CD )           ");
                strSQL.Append(" AND DEMAND.ALLOC_FLAG <> 1                                                  ");
                strSQL.Append(" AND DEMAND.DEMAND_STATUS <= 30                                              ");
                strSQL.Append(" INNER JOIN JOB_ORDER                                                   ");
                strSQL.Append(" ON  DEMAND.ORDER_NO = JOB_ORDER.ORDER_NO                                    ");
                strSQL.Append(" INNER JOIN WORKSHOP_MASTER                                             ");
                strSQL.Append(" ON JOB_ORDER.WS_CD = WORKSHOP_MASTER.WS_CD                                  ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01 = 'ITEM_UMSR'                 ");
                strSQL.Append(" AND S.KEY02 = JOB_ORDER.ORDER_UMSR                                          ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S2 ON S2.KEY01 = 'ITEM_UMSR'               ");
                strSQL.Append(" AND S2.KEY02 = DEMAND.ITEM_UMSR  ) SHORT                                    ");
            }
            strSQL.Append(" ORDER BY                                      ");
            strSQL.Append("  SCH_ID,          WS_CD,            WHS_CD,   ");
            strSQL.Append("  ITEM_NO,         SCH_DISB_DATE,    JOC_CD,   ");
            strSQL.Append("  PARENT_ITEM_NO,  SCH_START_DATE              ");

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
        /// 在庫引当処理
        /// 
        /// 
        /// 使用画面：MfgProgressInq
        /// </summary>
        public int Disb_Alloc_By_Demand_No()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_DEMAND_NO", _demand_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_DISB_ALLOC_BY_DEMAND_NO");
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
        /// 在庫引当解除処理
        /// 
        /// 
        /// 使用画面：MfgProgressInq
        /// </summary>
        public int Disb_Unalloc_By_Demand_No()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_DEMAND_NO", _demand_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_DISB_UNALLOC_BY_DEMAND_NO");
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
        /// 月次受払表対象データを検索する
        /// <para>使用画面：月次受払表発行[InvRcvDisbList]</para>
        /// </summary>
        public DataSet GetRecvDisbMonthList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            db.DbParametersClear();
            strSQL.Append(" SELECT I.ITEM_NO,  IM.ITEM_DESC,   I.ITEM_TYPE,    I.ITEM_UMSR,         ");
            strSQL.Append(" I.BEG_INV_BAL,     I.BEG_INV_AMT,  S2.DATA_CHAR UMSR_NAME,              ");
            strSQL.Append(" I.WHS_CD,          W.WHS_DESC,                                          ");

            strSQL.Append(" ISNULL(R1.QTY,0) QTY_R1,ISNULL(R2.QTY,0) QTY_R2,ISNULL(R3.QTY,0) QTY_R3,");
            strSQL.Append(" ISNULL(R4.QTY,0) QTY_R4,ISNULL(R5.QTY,0) QTY_R5,ISNULL(R6.QTY,0) QTY_R6,");
            strSQL.Append(" ISNULL(R7.QTY,0) QTY_R7,                                                ");

            if (prc_type == 0)//評価単価=「標準単価」の場合
            {
                strSQL.Append("  ISNULL(P1.STD_PRC,0) CUR_PRC,             ");
                strSQL.Append("  ISNULL(P1.CURRENCY,S.CURRENCY) CURRENCY   ");
            }
            else if (prc_type == 1)//評価単価=月次移動平均単価の場合
            {
                strSQL.Append("  ISNULL(P2.MA_PRC,0) CUR_PRC,   ");
                strSQL.Append("  S.CURRENCY CURRENCY            ");
            }
            else//評価単価=最終仕入単価の場合
            {
                strSQL.Append("  ISNULL(P2.LAST_RCV_PRC,0) CUR_PRC, ");
                strSQL.Append("  S.CURRENCY CURRENCY                ");
            }
            strSQL.Append("  FROM                                           ");
            #region # 繰越在庫
            //繰越在庫
            strSQL.Append("  (SELECT                                                                         ");
            strSQL.Append("  WHS_CD,          ITEM_NO,             ITEM_TYPE,          ITEM_UMSR,            ");
            strSQL.Append("  SUM(BEG_INV_BAL) BEG_INV_BAL,         SUM(BEG_INV_AMT) BEG_INV_AMT              ");
            strSQL.Append("  FROM INVENTORY_DETAIL                                                           ");
            strSQL.Append("  WHERE                                                                           ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append("        INV_WIP_TYPE  =   0                                                   ");
                strSQL.Append("  AND   INV_TYPE      =   0                                                   ");
                strSQL.Append("  AND   INV_YM        =   :SYYMM                                              ");
                if (whs_cd != "")
                {
                    strSQL.Append("  AND   WHS_CD        =   :WHS_CD                                         ");
                }
            }
            else
            {
                strSQL.Append("        INV_YM        =   @SYYMM                                              ");
                strSQL.Append("  AND   INV_WIP_TYPE  =   0                                                   ");
                strSQL.Append("  AND   INV_TYPE      =   0                                                   ");
                if (whs_cd != "")
                {
                    strSQL.Append("  AND   WHS_CD        =   @WHS_CD                                         ");
                }
            }
            strSQL.Append(" GROUP BY WHS_CD,          ITEM_NO,             ITEM_TYPE,          ITEM_UMSR    ");
            strSQL.Append("  ) I                                                                            ");
            #endregion
            strSQL.Append("  LEFT JOIN (                                    ");
            #region # 受払履歴-入庫 # R1
            //受払履歴-入庫 
            strSQL.Append("  SELECT                                                         ");
            strSQL.Append("  TO_WHS_CD WHS_CD,       ITEM_NO,          SUM(QTY) QTY         ");
            strSQL.Append("  FROM RCV_DISB_TRANS                                            ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" WHERE       SLIP_TYPE   =   '01'                            ");//01：倉庫入庫
                strSQL.Append(" AND         REQ_TYPE    <>  '25'                            ");//25：部品返品
                strSQL.Append(" AND         REQ_TYPE    <>  '26'                            ");//26：製品出荷返品
                strSQL.Append("AND          TRANS_DATE  BETWEEN  :YYMM*100 AND :YYMM*100+99 ");
                if (whs_cd != "")
                {
                    strSQL.Append(" AND     TO_WHS_CD   =   :WHS_CD                     ");
                }
            }
            else
            {
                strSQL.Append(" WHERE       SLIP_TYPE   =   '01'                            ");//01：倉庫入庫
                strSQL.Append(" AND         REQ_TYPE    <>  '25'                            ");//25：部品返品
                strSQL.Append(" AND         REQ_TYPE    <>  '26'                            ");//26：製品出荷返品
                strSQL.Append("AND          TRANS_DATE  BETWEEN  @YYMM*100 AND @YYMM*100+99 ");
                if (whs_cd != "")
                {
                    strSQL.Append(" AND     TO_WHS_CD   =   @WHS_CD                     ");
                }
            }
            strSQL.Append(" GROUP BY TO_WHS_CD,          ITEM_NO                            ");
            #endregion
            strSQL.Append("  ) R1   ON I.ITEM_NO = R1.ITEM_NO               ");
            strSQL.Append("         AND I.WHS_CD = R1.WHS_CD                ");
            strSQL.Append("  LEFT JOIN (                                    ");
            #region # 受払履歴-在庫調整増 # R2
            strSQL.Append("  SELECT                                                         ");
            strSQL.Append("  TO_WHS_CD WHS_CD,       ITEM_NO,          SUM(QTY) QTY         ");
            strSQL.Append("  FROM RCV_DISB_TRANS                                            ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" WHERE       SLIP_TYPE   =   '91'                            ");//91：在庫調整増
                strSQL.Append(" AND         REQ_TYPE    <>  '25'                            ");//25：部品返品
                strSQL.Append(" AND         REQ_TYPE    <>  '26'                            ");//26：製品出荷返品
                strSQL.Append(" AND         TRANS_DATE  BETWEEN  :YYMM*100 AND :YYMM*100+99 ");
                if (whs_cd != "")
                {
                    strSQL.Append(" AND     TO_WHS_CD   =   :WHS_CD                     ");
                }
            }
            else
            {
                strSQL.Append(" WHERE       SLIP_TYPE   =   '91'                            ");//91：在庫調整増
                strSQL.Append(" AND         REQ_TYPE    <>  '25'                            ");//25：部品返品
                strSQL.Append(" AND         REQ_TYPE    <>  '26'                            ");//26：製品出荷返品
                strSQL.Append(" AND         TRANS_DATE  BETWEEN  @YYMM*100 AND @YYMM*100+99 ");
                if (whs_cd != "")
                {
                    strSQL.Append(" AND     TO_WHS_CD   =   @WHS_CD                     ");
                }
            }
            strSQL.Append(" GROUP BY TO_WHS_CD,          ITEM_NO                            ");
            #endregion
            strSQL.Append("  ) R2   ON I.ITEM_NO = R2.ITEM_NO               ");
            strSQL.Append("         AND I.WHS_CD = R2.WHS_CD                ");
            strSQL.Append("  LEFT JOIN (                                    ");
            #region # 受払履歴-出庫 # R3
            strSQL.Append("  SELECT                                                         ");
            strSQL.Append("  FROM_WHS_CD WHS_CD,       ITEM_NO,          SUM(QTY) QTY       ");
            strSQL.Append("  FROM RCV_DISB_TRANS                                            ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" WHERE       SLIP_TYPE   =   '02'                            ");//02：倉庫出庫
                strSQL.Append(" AND         REQ_TYPE    <>  '25'                            ");//25：部品返品
                strSQL.Append(" AND         REQ_TYPE    <>  '26'                            ");//26：製品出荷返品
                strSQL.Append("AND          TRANS_DATE  BETWEEN  :YYMM*100 AND :YYMM*100+99 ");
                if (whs_cd != "")
                {
                    strSQL.Append(" AND     FROM_WHS_CD   =   :WHS_CD                       ");
                }
            }
            else
            {
                strSQL.Append(" WHERE       SLIP_TYPE   =   '02'                            ");//02：倉庫出庫
                strSQL.Append(" AND         REQ_TYPE    <>  '25'                            ");//25：部品返品
                strSQL.Append(" AND         REQ_TYPE    <>  '26'                            ");//26：製品出荷返品
                strSQL.Append(" AND         TRANS_DATE  BETWEEN  @YYMM*100 AND @YYMM*100+99 ");
                if (whs_cd != "")
                {
                    strSQL.Append(" AND     FROM_WHS_CD   =   @WHS_CD                       ");
                }
            }
            strSQL.Append(" GROUP BY FROM_WHS_CD,          ITEM_NO                          ");
            #endregion
            strSQL.Append("  ) R3   ON I.ITEM_NO = R3.ITEM_NO               ");
            strSQL.Append("         AND I.WHS_CD = R3.WHS_CD                ");
            strSQL.Append("  LEFT JOIN (                                    ");
            #region # 受払履歴-返品 # R4
            strSQL.Append("  SELECT                                                         ");
            strSQL.Append("  WHS_CD,       ITEM_NO,          SUM(QTY) QTY                   ");
            strSQL.Append("  FROM (SELECT                                                   ");
            strSQL.Append("        FROM_WHS_CD WHS_CD,       ITEM_NO,        SUM(QTY) QTY   ");
            strSQL.Append("        FROM RCV_DISB_TRANS                                      ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" WHERE       SLIP_TYPE   =   '02'                            ");//02：倉庫出庫
                strSQL.Append(" AND         REQ_TYPE    =   '25'                            ");//25：部品返品
                strSQL.Append(" AND         TRANS_DATE  BETWEEN  :YYMM*100 AND :YYMM*100+99 ");
                if (whs_cd != "")
                {
                    strSQL.Append(" AND     FROM_WHS_CD   =   :WHS_CD                       ");
                }
            }
            else
            {
                strSQL.Append(" WHERE       SLIP_TYPE   =   '02'                            ");//02：倉庫出庫
                strSQL.Append(" AND         REQ_TYPE    =   '25'                            ");//25：部品返品
                strSQL.Append(" AND         TRANS_DATE  BETWEEN  @YYMM*100 AND @YYMM*100+99 ");
                if (whs_cd != "")
                {
                    strSQL.Append(" AND     FROM_WHS_CD   =   @WHS_CD                       ");
                }
            }
            strSQL.Append("     GROUP BY FROM_WHS_CD,          ITEM_NO                      ");
            strSQL.Append("     UNION ALL                                                   ");
            strSQL.Append("     SELECT                                                      ");
            strSQL.Append("     TO_WHS_CD WHS_CD,       ITEM_NO,          SUM(QTY)*(-1) QTY ");
            strSQL.Append("     FROM RCV_DISB_TRANS                                         ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" WHERE       SLIP_TYPE   =   '01'                            ");//01：倉庫入庫
                strSQL.Append(" AND         REQ_TYPE    =   '26'                            ");//26：製品出荷返品
                strSQL.Append(" AND         TRANS_DATE  BETWEEN  :YYMM*100 AND :YYMM*100+99 ");
                if (whs_cd != "")
                {
                    strSQL.Append(" AND     TO_WHS_CD   =   :WHS_CD                         ");
                }
            }
            else
            {
                strSQL.Append(" WHERE       SLIP_TYPE   =   '01'                            ");//01：倉庫入庫
                strSQL.Append(" AND         REQ_TYPE    =   '26'                            ");//26：製品出荷返品
                strSQL.Append(" AND         TRANS_DATE  BETWEEN  @YYMM*100 AND @YYMM*100+99 ");
                if (whs_cd != "")
                {
                    strSQL.Append(" AND     TO_WHS_CD   =   @WHS_CD                         ");
                }
            }
            strSQL.Append("     GROUP BY TO_WHS_CD,          ITEM_NO     ) A                ");
            strSQL.Append(" GROUP BY WHS_CD,          ITEM_NO                               ");
            #endregion
            strSQL.Append("  ) R4   ON I.ITEM_NO = R4.ITEM_NO               ");
            strSQL.Append("         AND I.WHS_CD = R4.WHS_CD                ");
            strSQL.Append("  LEFT JOIN (                                    ");
            #region # 受払履歴-在庫調整減 # R5
            strSQL.Append("  SELECT                                                         ");
            //strSQL.Append("  FROM_WHS_CD WHS_CD,       ITEM_NO,          SUM(QTY) QTY       ");	//Del 2013.01.22 Ubiq-Sai
            strSQL.Append("  TO_WHS_CD WHS_CD,       ITEM_NO,          SUM(QTY) QTY         ");		//Add 2013.01.22 Ubiq-Sai
            strSQL.Append("  FROM RCV_DISB_TRANS                                            ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" WHERE       SLIP_TYPE   =   '92'                            ");//92：在庫調整減（棚卸調整出庫）
                strSQL.Append(" AND         REQ_TYPE    <>  '25'                            ");//25：部品返品
                strSQL.Append(" AND         REQ_TYPE    <>  '26'                            ");//26：製品出荷返品
                strSQL.Append(" AND         TRANS_DATE  BETWEEN  :YYMM*100 AND :YYMM*100+99 ");
                if (whs_cd != "")
                {
                    //strSQL.Append(" AND     FROM_WHS_CD   =   :WHS_CD                       ");
                    strSQL.Append(" AND     TO_WHS_CD   =   :WHS_CD                         ");
                }
            }
            else
            {
                strSQL.Append(" WHERE       SLIP_TYPE   =   '92'                            ");//92：在庫調整減（棚卸調整出庫）
                strSQL.Append(" AND         REQ_TYPE    <>  '25'                            ");//25：部品返品
                strSQL.Append(" AND         REQ_TYPE    <>  '26'                            ");//26：製品出荷返品
                strSQL.Append(" AND         TRANS_DATE  BETWEEN  @YYMM*100 AND @YYMM*100+99 ");
                if (whs_cd != "")
                {
                    //strSQL.Append(" AND     FROM_WHS_CD   =   @WHS_CD                       ");   //Del 2013.01.22 Ubiq-Sai
                    strSQL.Append(" AND     TO_WHS_CD   =   @WHS_CD                         ");     //Add 2013.01.22 Ubiq-Sai
                }
            }
            //strSQL.Append(" GROUP BY FROM_WHS_CD,          ITEM_NO                          ");   //Del 2013.01.22 Ubiq-Sai
            strSQL.Append(" GROUP BY TO_WHS_CD,          ITEM_NO                            ");     //Add 2013.01.22 Ubiq-Sai
            #endregion
            strSQL.Append("  ) R5   ON I.ITEM_NO = R5.ITEM_NO               ");
            strSQL.Append("         AND I.WHS_CD = R5.WHS_CD                ");
            strSQL.Append("  LEFT JOIN (                                    ");
            #region # 受払履歴-振替入庫 # R6
            strSQL.Append("  SELECT                                                         ");
            strSQL.Append("  TO_WHS_CD WHS_CD,       ITEM_NO,          SUM(QTY) QTY         ");
            strSQL.Append("  FROM RCV_DISB_TRANS                                            ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" WHERE       SLIP_TYPE   =   '11'                            ");//11：振替入庫
                strSQL.Append(" AND         REQ_TYPE    <>  '25'                            ");//25：部品返品
                strSQL.Append(" AND         REQ_TYPE    <>  '26'                            ");//26：製品出荷返品
                strSQL.Append(" AND         TRANS_DATE  BETWEEN  :YYMM*100 AND :YYMM*100+99 ");
                if (whs_cd != "")
                {
                    strSQL.Append(" AND     TO_WHS_CD   =   :WHS_CD                     ");
                }
            }
            else
            {
                strSQL.Append(" WHERE       SLIP_TYPE   =   '11'                            ");//11：振替入庫
                strSQL.Append(" AND         REQ_TYPE    <>  '25'                            ");//25：部品返品
                strSQL.Append(" AND         REQ_TYPE    <>  '26'                            ");//26：製品出荷返品
                strSQL.Append(" AND         TRANS_DATE  BETWEEN  @YYMM*100 AND @YYMM*100+99 ");
                if (whs_cd != "")
                {
                    strSQL.Append(" AND     TO_WHS_CD   =   @WHS_CD                     ");
                }
            }
            strSQL.Append(" GROUP BY TO_WHS_CD,          ITEM_NO                            ");
            #endregion
            strSQL.Append("  ) R6   ON I.ITEM_NO = R6.ITEM_NO               ");
            strSQL.Append("         AND I.WHS_CD = R6.WHS_CD                ");
            strSQL.Append("  LEFT JOIN (                                    ");
            #region # 受払履歴-振替出庫 # R7
            strSQL.Append("  SELECT                                                         ");
            strSQL.Append("  FROM_WHS_CD WHS_CD,       ITEM_NO,          SUM(QTY) QTY       ");
            strSQL.Append("  FROM RCV_DISB_TRANS                                            ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" WHERE       SLIP_TYPE   =   '12'                            ");//12：振替出庫
                strSQL.Append(" AND         REQ_TYPE    <>  '25'                            ");//25：部品返品
                strSQL.Append(" AND         REQ_TYPE    <>  '26'                            ");//26：製品出荷返品
                strSQL.Append(" AND         TRANS_DATE  BETWEEN  :YYMM*100 AND :YYMM*100+99 ");
                if (whs_cd != "")
                {
                    strSQL.Append(" AND     FROM_WHS_CD   =   :WHS_CD                       ");
                }
            }
            else
            {
                strSQL.Append(" WHERE       SLIP_TYPE   =   '12'                            ");//12：振替出庫
                strSQL.Append(" AND         REQ_TYPE    <>  '25'                            ");//25：部品返品
                strSQL.Append(" AND         REQ_TYPE    <>  '26'                            ");//26：製品出荷返品
                strSQL.Append(" AND         TRANS_DATE  BETWEEN  @YYMM*100 AND @YYMM*100+99 ");
                if (whs_cd != "")
                {
                    strSQL.Append(" AND     FROM_WHS_CD   =   @WHS_CD                       ");
                }
            }
            strSQL.Append(" GROUP BY FROM_WHS_CD,          ITEM_NO                          ");
            #endregion
            strSQL.Append("  ) R7   ON I.ITEM_NO = R7.ITEM_NO               ");
            strSQL.Append("         AND I.WHS_CD = R7.WHS_CD                ");
            if (prc_type == 0)//評価単価=「標準単価」の場合
            {
                strSQL.Append("  LEFT JOIN (                                ");
                #region # 評価単価-標準単価
                strSQL.Append("  SELECT                                             ");
                strSQL.Append("  ITEM_NO,          STD_PRC,         CURRENCY        ");
                strSQL.Append("  FROM STD_PRICE_MASTER                              ");
                if (_db_type == "ORACLE")
                {
                    strSQL.Append(" WHERE       BEG_EFF_DATE   <=   :YYMM           ");
                    strSQL.Append(" AND         END_EFF_DATE   >=   :YYMM           ");
                }
                else
                {
                    strSQL.Append(" WHERE       BEG_EFF_DATE   <=   @YYMM           ");
                    strSQL.Append(" AND         END_EFF_DATE   >=   @YYMM           ");
                }
                #endregion
                strSQL.Append("  ) P1   ON I.ITEM_NO = P1.ITEM_NO           ");
            }
            else//評価単価=「最終仕入単価」と「月次移動平均単価」の場合
            {
                strSQL.Append("  LEFT JOIN (                                    ");
                #region # 評価単価-月次移動平均単価、最終仕入単価
                strSQL.Append("  SELECT                                         ");
                strSQL.Append("  WHS_CD,    ITEM_NO,     MA_PRC,    LAST_RCV_PRC");
                strSQL.Append("  FROM MONTHLY_INV                               ");
                if (_db_type == "ORACLE")
                {
                    strSQL.Append(" WHERE       YYMM    =   :YYMM               ");
                    if (_whs_cd != "")
                    {
                        strSQL.Append(" AND         WHS_CD  =   :WHS_CD         ");
                    }
                }
                else
                {
                    strSQL.Append(" WHERE       YYMM    =   @YYMM               ");
                    if (_whs_cd != "")
                    {
                        strSQL.Append(" AND         WHS_CD  =   @WHS_CD         ");
                    }
                }
                #endregion
                strSQL.Append("  ) P2   ON  I.WHS_CD    = P2.WHS_CD             ");
                strSQL.Append("         AND I.ITEM_NO   = P2.ITEM_NO            ");
            }
            strSQL.Append("  LEFT JOIN (                                        ");
            #region # 基軸通貨 S #
            strSQL.Append("  SELECT                                       ");
            strSQL.Append("  KEY02 CURRENCY                               ");
            strSQL.Append("  FROM SYSTEM_PARAMETER                        ");
            strSQL.Append("  WHERE       KEY01     =   'CURRENCY_CD'      ");
            strSQL.Append("  AND         DATA_INT  =   1                  ");
            #endregion
            strSQL.Append("  ) S  ON 1=1                                        ");
            strSQL.Append(" LEFT JOIN ITEM_MASTER IM ON IM.ITEM_NO = I.ITEM_NO  ");
            strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER W ON I.WHS_CD = W.WHS_CD ");
            strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S2 ON                    ");
            strSQL.Append(" S2.KEY01 = 'ITEM_UMSR'  AND S2.KEY02 = I.ITEM_UMSR  ");
            strSQL.Append(" WHERE I.ITEM_TYPE IN (" + _item_type_str + ")       ");
            strSQL.Append(" ORDER BY I.WHS_CD                                   ");
            if (_db_type == "ORACLE")
            {
                if (_yymm.ToString() == DateTime.Now.ToString("yyyyMM"))
                {
                    db.DbPsetInt("SYYMM", 0);//繰越在庫USED
                }
                else
                {
                    db.DbPsetInt("SYYMM", _yymm);//繰越在庫USED
                }
                db.DbPsetInt("YYMM", _yymm);
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                if (_yymm.ToString() == DateTime.Now.ToString("yyyyMM"))
                {
                    db.DbPsetInt("@SYYMM", 0);//繰越在庫USED
                }
                else
                {
                    db.DbPsetInt("@SYYMM", _yymm);//繰越在庫USED
                }
                db.DbPsetInt("@YYMM", _yymm);
                db.DbPsetString("@WHS_CD", _whs_cd);
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
        /// 製番在庫数の取得
        /// <para>使用画面：受注変更・取消[OrdSOUpd]</para>
        /// </summary>
        public int GetInvBal()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql 
            strSQL.Append("SELECT ISNULL(SUM(INV.INV_BAL),0) INV_BAL       ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM INVENTORY_DETAIL INV               ");
                strSQL.Append(" WHERE   INV.INV_YM          = 0         ");
                strSQL.Append(" AND     INV.INV_WIP_TYPE    = 0         ");
                strSQL.Append(" AND     INV.INV_TYPE        = 0         ");
                strSQL.Append(" AND     INV.WHS_CD          = :WHS_CD   ");
                strSQL.Append(" AND     INV.SUPPLY_TYPE     = 0         ");
                strSQL.Append(" AND     INV.ITEM_NO         = :ITEM_NO  ");
                strSQL.Append(" AND     INV.JOC_CD          = :JOC_CD   ");
                strSQL.Append(" AND     INV.INV_BAL         > 0         ");

                db.DbParametersClear();
                db.DbPsetString("WHS_CD", _whs_cd);
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("JOC_CD", _joc_cd);
            }
            else
            {
                strSQL.Append(" FROM INVENTORY_DETAIL INV               ");
                strSQL.Append(" WHERE   INV.INV_YM          = 0         ");
                strSQL.Append(" AND     INV.INV_WIP_TYPE    = 0         ");
                strSQL.Append(" AND     INV.INV_TYPE        = 0         ");
                strSQL.Append(" AND     INV.WHS_CD          = @WHS_CD   ");
                strSQL.Append(" AND     INV.SUPPLY_TYPE     = 0         ");
                strSQL.Append(" AND     INV.ITEM_NO         = @ITEM_NO  ");
                strSQL.Append(" AND     INV.JOC_CD          = @JOC_CD   ");
                strSQL.Append(" AND     INV.INV_BAL         > 0         ");

                db.DbParametersClear();
                db.DbPsetString("@WHS_CD", _whs_cd);
                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@JOC_CD", _joc_cd);

            }
            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _inv_bal = double.Parse(db.Row("INV_BAL"));
            }
            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// フリー製番在庫数の取得
        /// <para>使用画面：受注変更・取消[OrdSOUpd]</para>
        /// </summary>
        public int GetFreeInvBal()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql 
            strSQL.Append("SELECT ISNULL(SUM(INV.INV_BAL-INV.ALLOC_QTY),0) INV_BAL       ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM INVENTORY_DETAIL INV               ");
                strSQL.Append(" WHERE   INV.INV_YM          = 0         ");
                strSQL.Append(" AND     INV.INV_WIP_TYPE    = 0         ");
                strSQL.Append(" AND     INV.INV_TYPE        = 0         ");
                strSQL.Append(" AND     INV.WHS_CD          = :WHS_CD   ");
                strSQL.Append(" AND     INV.SUPPLY_TYPE     = 0         ");
                strSQL.Append(" AND     INV.ITEM_NO         = :ITEM_NO  ");
                strSQL.Append(" AND     INV.JOC_CD          =           ");
                strSQL.Append("  (SELECT DATA_CHAR FROM SYSTEM_PARAMETER");//UPD BY UBIQ-LIU 2010/8/9 フリー製番はシステムパラメータより抽出する。
                strSQL.Append("    WHERE KEY01    ='FREE_JOC_CD'        ");
                strSQL.Append("      AND KEY02    = '*'                 ");
                strSQL.Append("      AND KEY03    = '*'                 ");
                strSQL.Append("      AND KEY04    = '*')                ");
                strSQL.Append(" AND     INV.INV_BAL         > 0         ");
                strSQL.Append(" AND     INV.INV_BAL    > INV.ALLOC_QTY  ");

                db.DbParametersClear();
                db.DbPsetString("WHS_CD", _whs_cd);
                db.DbPsetString("ITEM_NO", _item_no);
            }
            else
            {
                strSQL.Append(" FROM INVENTORY_DETAIL INV               ");
                strSQL.Append(" WHERE   INV.INV_YM          = 0         ");
                strSQL.Append(" AND     INV.INV_WIP_TYPE    = 0         ");
                strSQL.Append(" AND     INV.INV_TYPE        = 0         ");
                strSQL.Append(" AND     INV.WHS_CD          = @WHS_CD   ");
                strSQL.Append(" AND     INV.SUPPLY_TYPE     = 0         ");
                strSQL.Append(" AND     INV.ITEM_NO         = @ITEM_NO  ");
                //strSQL.Append(" AND     INV.JOC_CD          = 'FREE'    ");
                strSQL.Append(" AND     INV.JOC_CD          =           ");//UPD BY UBIQ-LIU 2010/8/9 フリー製番はシステムパラメータより抽出する。
                strSQL.Append("  (SELECT DATA_CHAR FROM SYSTEM_PARAMETER");
                strSQL.Append("    WHERE KEY01    ='FREE_JOC_CD'        ");
                strSQL.Append("      AND KEY02    = '*'                 ");
                strSQL.Append("      AND KEY03    = '*'                 ");
                strSQL.Append("      AND KEY04    = '*')                ");
                strSQL.Append(" AND     INV.INV_BAL         > 0         ");
                strSQL.Append(" AND     INV.INV_BAL    > INV.ALLOC_QTY  ");

                db.DbParametersClear();
                db.DbPsetString("@WHS_CD", _whs_cd);
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
                _inv_bal = double.Parse(db.Row("INV_BAL"));
            }
            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// 計画製造オーダを検索する
        /// <para>使用画面：製番振替[InvJOCTransfer]</para>
        /// </summary>
        public DataSet GetJocItemPlannedOrder()
        {
            ComLibrary com = new ComLibrary();
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                              ");
            strSQL.Append(" PO.SCH_COMPL_DATE,  PO.JOC_CD,      PO.JOC_ITEM_NO, ");
            strSQL.Append(" IM.ITEM_DESC,       PO.ORDER_QTY,   INV.INV_BAL     ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PLANNED_ORDER PO                                   ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER IM ON PO.JOC_ITEM_NO = IM.ITEM_NO ");
                strSQL.Append(" LEFT JOIN (                                             ");
                strSQL.Append("     SELECT ITEM_NO,WHS_CD,JOC_CD,SUM(INV_BAL) INV_BAL   ");
                strSQL.Append("     FROM INVENTORY_DETAIL I                             ");
                strSQL.Append("     WHERE INV_YM        =0                              ");
                strSQL.Append("       AND ITEM_NO       =:ITEM_NO                       ");
                strSQL.Append("       AND WHS_CD        =:WHS_CD                        ");
                strSQL.Append("       AND INV_WIP_TYPE  =0                              ");
                strSQL.Append("       AND INV_TYPE      =0                              ");
                strSQL.Append("     GROUP BY ITEM_NO,WHS_CD,JOC_CD                      ");
                strSQL.Append("           ) INV ON PO.ITEM_NO    =INV.ITEM_NO           ");
                strSQL.Append("   AND PO.WHS_CD     =INV.WHS_CD                         ");
                strSQL.Append("   AND PO.JOC_CD     =INV.JOC_CD                         ");
                strSQL.Append(" WHERE PO.ITEM_NO    =:ITEM_NO                           ");
                strSQL.Append("   AND PO.WHS_CD     =:WHS_CD                            ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM PLANNED_ORDER PO                                   ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER IM ON PO.JOC_ITEM_NO = IM.ITEM_NO ");
                strSQL.Append(" LEFT JOIN (                                             ");
                strSQL.Append("     SELECT ITEM_NO,WHS_CD,JOC_CD,SUM(INV_BAL) INV_BAL   ");
                strSQL.Append("     FROM INVENTORY_DETAIL I                             ");
                strSQL.Append("     WHERE INV_YM        =0                              ");
                strSQL.Append("       AND ITEM_NO       =@ITEM_NO                       ");
                strSQL.Append("       AND WHS_CD        =@WHS_CD                        ");
                strSQL.Append("       AND INV_WIP_TYPE  =0                              ");
                strSQL.Append("       AND INV_TYPE      =0                              ");
                strSQL.Append("     GROUP BY ITEM_NO,WHS_CD,JOC_CD                      ");
                strSQL.Append("           ) INV ON PO.ITEM_NO    =INV.ITEM_NO           ");
                strSQL.Append("   AND PO.WHS_CD     =INV.WHS_CD                         ");
                strSQL.Append("   AND PO.JOC_CD     =INV.JOC_CD                         ");
                strSQL.Append(" WHERE PO.ITEM_NO    =@ITEM_NO                           ");
                strSQL.Append("   AND PO.WHS_CD     =@WHS_CD                            ");

                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            strSQL.Append("  ORDER BY PO.SCH_COMPL_DATE,  PO.JOC_CD             ");
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
        /// 個別製番マスタ、在庫数を検索する
        /// <para>使用画面：製番振替[InvJOCTransfer]</para>
        /// </summary>
        public DataSet GetIndividualJoc()
        {
            ComLibrary com = new ComLibrary();
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                              ");
            strSQL.Append(" NULL SCH_COMPL_DATE,  JO.JOC_CD,    NULL JOC_ITEM_NO,               ");
            strSQL.Append(" JO.JOC_DESC ITEM_DESC,NULL ORDER_QTY, ISNULL(INV.INV_BAL,0) INV_BAL ");
            if (_db_type == "ORACLE")
            {
                db.DbParametersClear();

                strSQL.Append(" FROM (SELECT 0 JOC_TYPE,   J.JOC_CD,    J.JOC_DESC      ");
                strSQL.Append("       FROM JOC_MASTER J                                 ");
                strSQL.Append("       WHERE J.JOC_CD    IN                              ");
                strSQL.Append("             (SELECT DATA_CHAR FROM SYSTEM_PARAMETER     ");
                strSQL.Append("              WHERE KEY01    ='FREE_JOC_CD'              ");
                strSQL.Append("                AND KEY02    ='*'                        ");
                strSQL.Append("                AND KEY03    ='*'                        ");
                strSQL.Append("                AND KEY04    ='*'                        ");
                strSQL.Append("              )                                          ");
                strSQL.Append("         AND J.JOC_TYPE  =1                              ");
                strSQL.Append("       UNION ALL                                         ");
                strSQL.Append("       SELECT 1 JOC_TYPE,   J.JOC_CD,    J.JOC_DESC      ");
                strSQL.Append("       FROM JOC_MASTER J                                 ");
                strSQL.Append("       WHERE J.JOC_CD    NOT IN                          ");
                strSQL.Append("             (SELECT DATA_CHAR FROM SYSTEM_PARAMETER     ");
                strSQL.Append("              WHERE KEY01    ='FREE_JOC_CD'              ");
                strSQL.Append("                AND KEY02    ='*'                        ");
                strSQL.Append("                AND KEY03    ='*'                        ");
                strSQL.Append("                AND KEY04    ='*'                        ");
                strSQL.Append("              )                                          ");
                strSQL.Append("         AND J.JOC_TYPE  =1                              ");
                strSQL.Append("      ) JO                                               ");
                strSQL.Append(" LEFT JOIN (                                             ");
                strSQL.Append("     SELECT ITEM_NO,WHS_CD,JOC_CD,SUM(INV_BAL) INV_BAL   ");
                strSQL.Append("     FROM INVENTORY_DETAIL I                             ");
                strSQL.Append("     WHERE INV_YM        =0                              ");
                strSQL.Append("       AND ITEM_NO       =:ITEM_NO                       ");
                strSQL.Append("       AND WHS_CD        =:WHS_CD                        ");
                strSQL.Append("       AND INV_WIP_TYPE  =0                              ");
                strSQL.Append("       AND INV_TYPE      =0                              ");
                strSQL.Append("     GROUP BY ITEM_NO,WHS_CD,JOC_CD                      ");
                strSQL.Append("           ) INV ON JO.JOC_CD    =INV.JOC_CD             ");

                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("WHS_CD", _whs_cd);
            }
            else
            {
                db.DbParametersClear();

                strSQL.Append(" FROM (SELECT 0 JOC_TYPE,   J.JOC_CD,    J.JOC_DESC      ");
                strSQL.Append("       FROM JOC_MASTER J                                 ");
                strSQL.Append("       WHERE J.JOC_CD    IN                              ");
                strSQL.Append("             (SELECT DATA_CHAR FROM SYSTEM_PARAMETER     ");
                strSQL.Append("              WHERE KEY01    ='FREE_JOC_CD'              ");
                strSQL.Append("                AND KEY02    ='*'                        ");
                strSQL.Append("                AND KEY03    ='*'                        ");
                strSQL.Append("                AND KEY04    ='*'                        ");
                strSQL.Append("              )                                          ");
                strSQL.Append("         AND J.JOC_TYPE  =1                              ");
                strSQL.Append("       UNION ALL                                         ");
                strSQL.Append("       SELECT 1 JOC_TYPE,   J.JOC_CD,    J.JOC_DESC      ");
                strSQL.Append("       FROM JOC_MASTER J                                 ");
                strSQL.Append("       WHERE J.JOC_CD    NOT IN                          ");
                strSQL.Append("             (SELECT DATA_CHAR FROM SYSTEM_PARAMETER     ");
                strSQL.Append("              WHERE KEY01    ='FREE_JOC_CD'              ");
                strSQL.Append("                AND KEY02    ='*'                        ");
                strSQL.Append("                AND KEY03    ='*'                        ");
                strSQL.Append("                AND KEY04    ='*'                        ");
                strSQL.Append("              )                                          ");
                strSQL.Append("         AND J.JOC_TYPE  =1                              ");
                strSQL.Append("      ) JO                                               ");
                strSQL.Append(" LEFT JOIN (                                             ");
                strSQL.Append("     SELECT ITEM_NO,WHS_CD,JOC_CD,SUM(INV_BAL) INV_BAL   ");
                strSQL.Append("     FROM INVENTORY_DETAIL I                             ");
                strSQL.Append("     WHERE INV_YM        =0                              ");
                strSQL.Append("       AND ITEM_NO       =@ITEM_NO                       ");
                strSQL.Append("       AND WHS_CD        =@WHS_CD                        ");
                strSQL.Append("       AND INV_WIP_TYPE  =0                              ");
                strSQL.Append("       AND INV_TYPE      =0                              ");
                strSQL.Append("     GROUP BY ITEM_NO,WHS_CD,JOC_CD                      ");
                strSQL.Append("           ) INV ON JO.JOC_CD    =INV.JOC_CD             ");

                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            strSQL.Append("  ORDER BY JOC_TYPE             ");
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
        /// ロット№の存在チェック 2015.11.05
        /// <para>使用画面：受入処理</para>
        /// </summary>
        public bool ChkLotNo(string pLotNo)
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;
            bool blRtn = true;

            if(pLotNo == "")
                return blRtn;

            //--- sql 
            strSQL.Append("SELECT LOT_NO       ");
            strSQL.Append(" FROM INVENTORY_DETAIL INV               ");
            strSQL.Append(" WHERE   INV.LOT_NO          = @LOT_NO   ");
            strSQL.Append(" AND     INV.INV_BAL         > 0         ");

            db.DbParametersClear();
            db.DbPsetString("@LOT_NO", pLotNo);

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.SUCCEED)
            {
                blRtn = false;
            }
            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return blRtn;
        }

        /// <summary>
        /// ロット№の存在チェック 2015.11.05
        /// <para>使用画面：受入処理</para>
        /// </summary>
        public double GetInvByLotNo(string pLotNo)
        {
            ComDB db = new ComDB(_db_type);
            ComLibrary com = new ComLibrary();
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;
            double blRtn = 0;

            if (pLotNo == "")
                return 0;

            //--- sql 
            strSQL.Append("SELECT COALESCE(MAX(INV_BAL),0) INV_BAL       ");
            strSQL.Append(" FROM INVENTORY_DETAIL INV               ");
            strSQL.Append(" WHERE   INV.LOT_NO          = @LOT_NO   ");
            if(_input_type == 0)
                strSQL.Append("   AND   INV.INV_WIP_TYPE    = 0   ");

            db.DbParametersClear();
            db.DbPsetString("@LOT_NO", pLotNo);

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.SUCCEED)
            {
                blRtn = com.StringToDouble(db.Row("INV_BAL"));
            }
            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return blRtn;
        }
    }
}
