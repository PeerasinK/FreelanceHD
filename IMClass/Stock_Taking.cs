﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web.Configuration;
using IMClass;

namespace IMClass
{
    public class Stock_Taking
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Stock_Taking()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Stock_Taking(string p_user_id, int p_lang)
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
        protected string _db_type = "";
        protected int _lang = 1;
        protected double _inv_ym = 0.0;
        protected string _whs_cd = "";
        protected int _physical_cnt_yymm = 0;
        protected string _lot_no = "";
        protected string _item_no = "";
        protected double _page_no = 0.0;
        protected double _line_no = 0.0;
        protected double _physical_cnt_qty = 0.0;
        protected int _physical_cnt_date = 0;
        protected double _diff_rate = 0.0;
        protected double _diff_amt = 0.0;
        protected string _ws_cd = "";
        protected string _process_cd = "";
        protected int _physical_cnt_status = -1;
        //ADD UBIQ-LIU 2010/05/17
        protected int _begin_date = 0;
        protected int _end_date = 0;
        protected int _prc_type = 0;
        protected string _location = "";    // IMV3
        protected int _inv_wip_type = 0;

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

        /// <summary>
        /// プロパティ

        /// </summary>
        public double inv_ym
        {
            get { return _inv_ym; }
            set { _inv_ym = value; }
        }
        public int physical_cnt_yymm
        {
            get { return _physical_cnt_yymm; }
            set { _physical_cnt_yymm = value; }
        }
        public string whs_cd
        {
            get { return _whs_cd; }
            set { _whs_cd = value; }
        }
        public string lot_no { get { return _lot_no; } set { _lot_no = value; } }
        public string item_no { get { return _item_no; } set { _item_no = value; } }
        public double page_no { get { return _page_no; } set { _page_no = value; } }
        public double line_no { get { return _line_no; } set { _line_no = value; } }
        public double physical_cnt_qty { get { return _physical_cnt_qty; } set { _physical_cnt_qty = value; } }
        public int physical_cnt_date { get { return _physical_cnt_date; } set { _physical_cnt_date = value; } }
        public double diff_rate { get { return _diff_rate; } set { _diff_rate = value; } }
        public double diff_amt { get { return _diff_amt; } set { _diff_amt = value; } }
        public string ws_cd { get { return _ws_cd; } set { _ws_cd = value; } }
        public string process_cd { get { return _process_cd; } set { _process_cd = value; } }
        public int physical_cnt_status { get { return _physical_cnt_status; } set { _physical_cnt_status = value; } }
        public int prc_type { get { return _prc_type; } set { _prc_type = value; } }
        public string location { get { return _location; } set { _location = value; } } // IMV3
        public int inv_wip_type { get { return _inv_wip_type; } set { _inv_wip_type = value; } }

        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }
        public int lang { get { return _lang; } set { _lang = value; } }

        public int begin_date { get { return _begin_date; } set { _begin_date = value; } }
        public int end_date { get { return _end_date; } set { _end_date = value; } }
        #endregion

        /// <summary>
        ///  棚卸抽出
        /// 
        /// 使用画面：InvStockTakingAbstract
        /// </summary>
        public DataSet Get_AbstractList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //Del 2013.03.01 Ubiq-Sai Begin
            //--- sql
            //strSQL.Append(" SELECT INV.WHS_CD             ,W.WHS_DESC               , COUNT(*)    AS ITEM_NUM,              ");
            //strSQL.Append(" SUBSTRING(CONVERT(VARCHAR(8),PHISICAL.MAX_PHYSICAL_CNT_DATE),1,6) AS CNT_DATE ,                 ");
            //strSQL.Append(" CASE  MAX_INV_UPD_DATE  WHEN  0 THEN 00000000 ELSE                                              ");
            //strSQL.Append(" YEAR(CONVERT(DATETIME,CONVERT(VARCHAR(8) ,PHISICAL.MAX_INV_UPD_DATE)))*100                      ");
            //strSQL.Append(" +MONTH(CONVERT(DATETIME,CONVERT(VARCHAR(8),PHISICAL.MAX_INV_UPD_DATE))) END  AS UPD_DATE        ");
            //Del 2013.03.01 Ubiq-Sai End

            //Add 2013.03.01 Ubiq-Sai Begin
            strSQL.Append(" SELECT 																							");
            strSQL.Append(" 	INV.WHS_CD             ,W.WHS_DESC               , COUNT(*)    AS ITEM_NUM,               	");
            strSQL.Append(" 	INV.LOCATION           ,INV.INV_WIP_TYPE     	 ,"); // IMV3
            strSQL.Append(" 	SUBSTRING(CONVERT(VARCHAR(8),MAX(PHISICAL.PHYSICAL_CNT_DATE) ),1,6) AS CNT_DATE ,           ");
            strSQL.Append(" 	CASE  COALESCE(MAX(PHYSICAL_CNT_DATE),0)  WHEN  0 THEN 00000000 ELSE                        ");
            strSQL.Append(" 		YEAR(CONVERT(DATETIME,CONVERT(VARCHAR(8) ,MAX(PHYSICAL_CNT_DATE))))*100                 ");
            strSQL.Append(" 		+MONTH(CONVERT(DATETIME,CONVERT(VARCHAR(8),MAX(PHYSICAL_CNT_DATE)))) END  AS UPD_DATE   ");
            //Add 2013.03.01 Ubiq-Sai End

            //Del 2013.03.01 Ubiq-Sai Begin
            //strSQL.Append(" FROM INVENTORY_DETAIL INV                                                           ");
            //strSQL.Append(" LEFT OUTER JOIN  WAREHOUSE_MASTER W ON  INV.WHS_CD=W.WHS_CD                         ");
            //strSQL.Append(" LEFT OUTER JOIN                                                                     ");
            //strSQL.Append(" (SELECT WHS_CD,                                                                     ");
            //strSQL.Append(" MAX(PHYSICAL_CNT_DATE) as MAX_PHYSICAL_CNT_DATE ,                                   ");
            //strSQL.Append(" MAX(INV_UPD_DATE)as MAX_INV_UPD_DATE                                                ");
            //strSQL.Append(" FROM  PHISICAL_COUNT                                                                ");
            //strSQL.Append(" GROUP BY WHS_CD ) AS  PHISICAL  ON  INV.WHS_CD=PHISICAL.WHS_CD                      ");
            //strSQL.Append(" WHERE INV.INV_WIP_TYPE=0                                                            ");
            //strSQL.Append(" AND INV.INV_TYPE =0                                                                 ");
            //strSQL.Append(" AND INV.INV_YM = @INV_YM                                                            ");
            //Del 2013.03.01 Ubiq-Sai End

            //Add 2013.03.01 Ubiq-Sai Begin
            strSQL.Append(" FROM INVENTORY_DETAIL INV                                                            			");
            strSQL.Append(" LEFT OUTER JOIN  WAREHOUSE_MASTER W 															");
            strSQL.Append(" ON  INV.WHS_CD=W.WHS_CD                          												");
            strSQL.Append(" LEFT OUTER JOIN PHISICAL_COUNT PHISICAL     													");
            strSQL.Append(" ON  INV.WHS_CD=PHISICAL.WHS_CD                       											");
            strSQL.Append(" and INV.ITEM_NO =PHISICAL.ITEM_NO  																");
            strSQL.Append(" and INV.INV_WIP_TYPE=   PHISICAL.INV_WIP_TYPE 													");
            strSQL.Append(" and INV.INV_TYPE     =   PHISICAL.INV_TYPE  													");
            strSQL.Append(" and INV.LOT_NO     =   PHISICAL.LOT_NO  													");
            strSQL.Append(" and INV.LOCATION     =   PHISICAL.LOCATION  													");
            strSQL.Append(" and PHISICAL.PHYSICAL_CNT_TYPE =1																");
            strSQL.Append(" and PHiSICAL.PHYSICAL_CNT_YYMM= (SELECT MAX(PHYSICAL_CNT_YYMM) from PHISICAL_COUNT)				");
            strSQL.Append(" WHERE INV.INV_WIP_TYPE=0                                                             			");
            strSQL.Append(" AND INV.INV_TYPE =0                                                                  			");
            strSQL.Append(" AND INV.INV_YM = @INV_YM                                                             			");
            //Add 2013.03.01 Ubiq-Sai End

            db.DbParametersClear();
            db.DbPsetDouble("@INV_YM", _inv_ym);
            db.DbPsetInt("@BEGIN_DATE", _begin_date);
            db.DbPsetInt("@END_DATE", _end_date);

            if (_whs_cd != "")
            {
                strSQL.Append(" AND INV.WHS_CD = @WHS_CD");
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            // IMV3 start
            if (_location != "")
            {
                strSQL.Append(" AND INV.LOCATION = @LOCATION");
                db.DbPsetString("@LOCATION", _location);
            }
            // IMV3 end
            if (_ws_cd != "")
            {
                strSQL.Append(" AND 1 = 0");
            }

            //--> ADD BY UBIQ-LIU 2010/5/17
            strSQL.Append(" AND (INV.INV_BAL <> 0                                       ");
            strSQL.Append("      OR (INV.INV_BAL = 0                                    ");
            strSQL.Append("          AND ( (INV.LAST_RECV_DATE >= @BEGIN_DATE           ");
            strSQL.Append("                 AND INV.LAST_RECV_DATE <= @END_DATE )       ");
            strSQL.Append("             OR (INV.LAST_ADJ_IN_DATE >= @BEGIN_DATE         ");
            strSQL.Append("                 AND INV.LAST_ADJ_IN_DATE <= @END_DATE )     ");
            strSQL.Append("             OR (INV.LAST_DISB_DATE >= @BEGIN_DATE           ");
            strSQL.Append("                 AND INV.LAST_DISB_DATE <= @END_DATE )       ");
            strSQL.Append("             OR (INV.LAST_ADJ_OUT_DATE >= @BEGIN_DATE        ");
            strSQL.Append("                 AND INV.LAST_ADJ_OUT_DATE <= @END_DATE )    ");
            strSQL.Append("              )                                              ");
            strSQL.Append("         )                                                   ");
            strSQL.Append("     )                                                       ");
            //<-- END ADD
            //Del 2013.03.01 Ubiq-Sai Begin
            //strSQL.Append(" GROUP BY INV.WHS_CD  ,W.WHS_DESC,PHISICAL.MAX_PHYSICAL_CNT_DATE,                    ");
            //strSQL.Append(" MAX_INV_UPD_DATE,PHISICAL.MAX_INV_UPD_DATE,PHISICAL.MAX_INV_UPD_DATE                ");
            //Del 2013.03.01 Ubiq-Sai End
            
            //strSQL.Append(" GROUP BY INV.WHS_CD  ,W.WHS_DESC                            ");             //Add 2013.03.01 Ubiq-Sai
            //strSQL.Append(" ORDER BY INV.WHS_CD                                         ");             //Add 2013.03.01 Ubiq-Sai
            strSQL.Append(" GROUP BY INV.WHS_CD ,INV.LOCATION, W.WHS_DESC,INV.INV_WIP_TYPE                 ");             //IMV3
            //strSQL.Append(" ORDER BY INV.WHS_CD ,INV.LOCATION                             ");             //IMV3

            //Add 2015.08.21 START
            strSQL.Append(" UNION ALL	");
            strSQL.Append(" SELECT 	");
            strSQL.Append(" 	INV.WS_CD WHS_CD             ,WS.WS_DESC               , COUNT(*)    AS ITEM_NUM,               	");
            strSQL.Append(" 	INV.LOCATION                 ,INV.INV_WIP_TYPE         ,"); // IMV3
            strSQL.Append(" 	SUBSTRING(CONVERT(VARCHAR(8),MAX(PHISICAL.PHYSICAL_CNT_DATE) ),1,6) AS CNT_DATE ,           ");
            strSQL.Append(" 	CASE  COALESCE(MAX(PHYSICAL_CNT_DATE),0)  WHEN  0 THEN 00000000 ELSE                        ");
            strSQL.Append(" 		YEAR(CONVERT(DATETIME,CONVERT(VARCHAR(8) ,MAX(PHYSICAL_CNT_DATE))))*100                 ");
            strSQL.Append(" 		+MONTH(CONVERT(DATETIME,CONVERT(VARCHAR(8),MAX(PHYSICAL_CNT_DATE)))) END  AS UPD_DATE   ");

            strSQL.Append(" FROM INVENTORY_DETAIL INV                                                            			");
            strSQL.Append(" LEFT OUTER JOIN  WORKSHOP_MASTER WS 															");
            strSQL.Append(" ON  INV.WS_CD=WS.WS_CD                          												");
            strSQL.Append(" LEFT OUTER JOIN PHISICAL_COUNT PHISICAL     													");
            strSQL.Append(" ON  INV.WS_CD=PHISICAL.WS_CD                       											");
            strSQL.Append(" and INV.ITEM_NO =PHISICAL.ITEM_NO  																");
            strSQL.Append(" and INV.INV_WIP_TYPE=   PHISICAL.INV_WIP_TYPE 													");
            strSQL.Append(" and INV.INV_TYPE     =   PHISICAL.INV_TYPE  													");
            strSQL.Append(" and INV.LOT_NO     =   PHISICAL.LOT_NO  													");
            strSQL.Append(" and INV.LOCATION     =   PHISICAL.LOCATION  													");
            strSQL.Append(" and PHISICAL.PHYSICAL_CNT_TYPE =1																");
            strSQL.Append(" and PHiSICAL.PHYSICAL_CNT_YYMM= (SELECT MAX(PHYSICAL_CNT_YYMM) from PHISICAL_COUNT)				");
            strSQL.Append(" WHERE INV.INV_WIP_TYPE=1                                                             			");
            //strSQL.Append(" AND INV.INV_TYPE =0                                                                  			");
            strSQL.Append(" AND INV.INV_YM = @INV_YM                                                             			");
            //Add 2013.03.01 Ubiq-Sai End

            if (_ws_cd != "")
            {
                strSQL.Append(" AND INV.WS_CD = @WS_CD");
                db.DbPsetString("@WS_CD", _ws_cd);
            }
            if (_location != "")
            {
                strSQL.Append(" AND INV.LOCATION = @LOCATION2");
                db.DbPsetString("@LOCATION2", _location);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND 1 = 0");
            }

            //--> ADD BY UBIQ-LIU 2010/5/17
            strSQL.Append(" AND (INV.INV_BAL <> 0                                       ");
            strSQL.Append("      OR (INV.INV_BAL = 0                                    ");
            strSQL.Append("          AND ( (INV.LAST_RECV_DATE >= @BEGIN_DATE           ");
            strSQL.Append("                 AND INV.LAST_RECV_DATE <= @END_DATE )       ");
            strSQL.Append("             OR (INV.LAST_ADJ_IN_DATE >= @BEGIN_DATE         ");
            strSQL.Append("                 AND INV.LAST_ADJ_IN_DATE <= @END_DATE )     ");
            strSQL.Append("             OR (INV.LAST_DISB_DATE >= @BEGIN_DATE           ");
            strSQL.Append("                 AND INV.LAST_DISB_DATE <= @END_DATE )       ");
            strSQL.Append("             OR (INV.LAST_ADJ_OUT_DATE >= @BEGIN_DATE        ");
            strSQL.Append("                 AND INV.LAST_ADJ_OUT_DATE <= @END_DATE )    ");
            strSQL.Append("              )                                              ");
            strSQL.Append("         )                                                   ");
            strSQL.Append("     )                                                       ");
            //<-- END ADD
            //Del 2013.03.01 Ubiq-Sai Begin
            //strSQL.Append(" GROUP BY INV.WHS_CD  ,W.WHS_DESC,PHISICAL.MAX_PHYSICAL_CNT_DATE,                    ");
            //strSQL.Append(" MAX_INV_UPD_DATE,PHISICAL.MAX_INV_UPD_DATE,PHISICAL.MAX_INV_UPD_DATE                ");
            //Del 2013.03.01 Ubiq-Sai End

            //strSQL.Append(" GROUP BY INV.WHS_CD  ,W.WHS_DESC                            ");             //Add 2013.03.01 Ubiq-Sai
            //strSQL.Append(" ORDER BY INV.WHS_CD                                         ");             //Add 2013.03.01 Ubiq-Sai
            strSQL.Append(" GROUP BY INV.WS_CD ,INV.LOCATION, WS.WS_DESC ,INV.INV_WIP_TYPE ");             //IMV3
            strSQL.Append(" ORDER BY 5, 1, 4   ");             //IMV3



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
        ///  棚卸抽出
        /// 
        /// 使用画面：InvStockTakingAbstract
        /// </summary>
        public int Abstract()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetDouble("@I_PHYSICAL_CNT_YYMM", _physical_cnt_yymm, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION", _location, ComConst.DB_IN);  // IMV3
            db.DbPsetInt("@I_INV_WIP_TYPE", _inv_wip_type, ComConst.DB_IN); // 2015.08.21

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_STOCKTAKING_ABSTRACT");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                db.DbCommit();
                return rtn;
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

        public DataSet Get_StockTakingList()
        {

            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();
            //--- sql
            strSQL.Append(" SELECT  ");
            //strSQL.Append(" PH.WHS_CD , ");
            //strSQL.Append(" W.WHS_DESC , ");
            strSQL.Append(" PH.INV_WIP_TYPE,  ");   // 2015.08.22
            strSQL.Append(" CASE PH.INV_WIP_TYPE WHEN 0 THEN PH.WHS_CD ELSE PH.WS_CD END WHS_CD, ");   // 2015.08.22 
            strSQL.Append(" CASE PH.INV_WIP_TYPE WHEN 0 THEN W.WHS_DESC ELSE WS.WS_DESC END WHS_DESC, ");   // 2015.08.22 
            strSQL.Append(" PH.PAGE_NO , PH.LINE_NO,  ");
            strSQL.Append(" PH.JOC_CD ,PH.LOCATION  ,PH.ITEM_NO  ,I.ITEM_DESC ,                                                    ");
            strSQL.Append(" PH.LOT_NO ,PH.INV_BAL ,PH.ITEM_UMSR ,                                                                   ");
            strSQL.Append(" S.DATA_CHAR AS UMSR_NAME ,PH.PHYSICAL_CNT_YYMM                                                          ");
            strSQL.Append(" , PH.INV_TYPE, PH.PROCESS_CD ");   // 2015.08.22
            strSQL.Append(" , CASE PH.INV_TYPE WHEN 0 THEN '' WHEN 3 THEN 'On Process' WHEN 4 THEN 'After Process' END NOTE ");   // 2015.08.22
            strSQL.Append(" FROM                                                                                            ");
            strSQL.Append(" PHISICAL_COUNT PH                                                                               ");
            strSQL.Append(" LEFT JOIN  WAREHOUSE_MASTER W ON PH.WHS_CD=W.WHS_CD                                             ");
            strSQL.Append(" LEFT JOIN  ITEM_MASTER      I ON PH.ITEM_NO=I.ITEM_NO                                           ");
            strSQL.Append(" LEFT JOIN  SYSTEM_PARAMETER S ON PH.ITEM_UMSR=S.KEY02 AND   S.KEY01='ITEM_UMSR'                 ");
            strSQL.Append(" LEFT OUTER JOIN  WORKSHOP_MASTER WS ON  PH.WS_CD=WS.WS_CD 	"); // 2015.08.22
            //strSQL.Append(" WHERE PH.INV_WIP_TYPE=0                                                                         ");
            //strSQL.Append(" AND PH.INV_TYPE =0                                                                              ");
            strSQL.Append(" WHERE PH.PHYSICAL_CNT_STATUS<=20                                                                    ");

            db.DbParametersClear();
            if (_physical_cnt_yymm != 0.0)
            {
                strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM = @PHYSICAL_CNT_YYMM");
                db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND PH.WHS_CD = @WHS_CD");
                strSQL.Append(" AND PH.INV_WIP_TYPE = 0");  // 2015.08.22
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            if (_ws_cd != "")
            {
                strSQL.Append(" AND PH.WS_CD = @WS_CD");    // 2015.08.22
                strSQL.Append(" AND PH.INV_WIP_TYPE = 1");  // 2015.08.22
                db.DbPsetString("@WS_CD", _ws_cd);
            }

            // IMV3
            if (_location != "")
            {
                strSQL.Append(" AND PH.LOCATION = @LOCATION");
                db.DbPsetString("@LOCATION", _location);            
            }

            //strSQL.Append(" ORDER BY   PH.LINE_NO   ");
            //strSQL.Append(" ORDER BY PH.PAGE_NO,  PH.LINE_NO   ");  // IMV3
            strSQL.Append(" ORDER BY 1,2,4,5  ");  // // 2015.08.22

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
        ///  棚卸結果登録
        /// 
        /// 使用画面：InvStockTakingAct
        /// </summary>
        public DataSet Get_ActCount()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT COUNT1,COUNT2 FROM                                                 ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" ( SELECT COUNT(*) COUNT1   FROM                                       ");
                strSQL.Append(" PHISICAL_COUNT  PH  , ITEM_MASTER I                                   ");
                strSQL.Append(" WHERE  ON PH.ITEM_NO=I.ITEM_NO(+)                                     ");
                strSQL.Append(" AND PH.INV_WIP_TYPE=0                                                 ");
                strSQL.Append(" AND   PH.INV_TYPE=0                                                   ");
                strSQL.Append(" AND   PH.PHYSICAL_CNT_STATUS=0                                        ");
                strSQL.Append("  ) A ,(                                                               ");
                strSQL.Append(" SELECT COUNT(*) COUNT2 FROM                                           ");
                strSQL.Append(" PHISICAL_COUNT  PH  , ITEM_MASTER I                                   ");
                strSQL.Append(" WHERE  PH.ITEM_NO=I.ITEM_NO(+)                                        ");
                strSQL.Append(" AND PH.INV_WIP_TYPE=0                                                 ");
                strSQL.Append(" AND   PH.INV_TYPE=0                                                   ");
                strSQL.Append(" AND   PH.PHYSICAL_CNT_STATUS >=20                                     ");
                strSQL.Append("   ) B                                                                 ");

                db.DbParametersClear();
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM = :PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND PH.WHS_CD =:WHS_CD");
                    db.DbPsetString("WHS_CD", _whs_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND PH.ITEM_NO = :ITEM_NO");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_page_no != 0.0)
                {
                    strSQL.Append(" AND PH.PAGE_NO =:PAGE_NO");
                    db.DbPsetDouble("PAGE_NO", _page_no);
                }
            }
            else
            {
                strSQL.Append(" ( SELECT COUNT(*) COUNT1   FROM                                       ");
                strSQL.Append(" PHISICAL_COUNT  PH                                                    ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER I ON PH.ITEM_NO=I.ITEM_NO                       ");
                strSQL.Append(" WHERE PH.INV_WIP_TYPE=0                                               ");
                strSQL.Append(" AND   PH.INV_TYPE=0                                                   ");
                strSQL.Append(" AND   PH.PHYSICAL_CNT_STATUS=0                                        ");
                db.DbParametersClear();
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM = @PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND PH.WHS_CD = @WHS_CD");
                    strSQL.Append(" AND PH.INV_WIP_TYPE = 0");  // 2015.08.22
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH.WS_CD = @WS_CD");    // 2015.08.22
                    strSQL.Append(" AND PH.INV_WIP_TYPE = 1");  // 2015.08.22
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND PH.ITEM_NO = @ITEM_NO");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_page_no != 0.0)
                {
                    strSQL.Append(" AND PH.PAGE_NO = @PAGE_NO");
                    db.DbPsetDouble("@PAGE_NO", _page_no);
                }

                // IMV3
                if (_location != "")
                {
                    strSQL.Append(" AND PH.LOCATION = @LOCATION");
                    db.DbPsetString("@LOCATION", _location);
                }
                strSQL.Append("  ) A ,(                                                               ");
                strSQL.Append(" SELECT COUNT(*) COUNT2 FROM                                           ");
                strSQL.Append(" PHISICAL_COUNT  PH                                                    ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER I ON PH.ITEM_NO=I.ITEM_NO                       ");
                strSQL.Append(" WHERE PH.INV_WIP_TYPE=0                                               ");
                strSQL.Append(" AND   PH.INV_TYPE=0                                                   ");
                strSQL.Append(" AND   PH.PHYSICAL_CNT_STATUS >=20                                     ");

                db.DbParametersClear();
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM = @PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND PH.WHS_CD = @WHS_CD");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND PH.ITEM_NO = @ITEM_NO");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_page_no != 0.0)
                {
                    strSQL.Append(" AND PH.PAGE_NO = @PAGE_NO");
                    db.DbPsetDouble("@PAGE_NO", _page_no);
                }
                // IMV3
                if (_location != "")
                {
                    strSQL.Append(" AND PH.LOCATION = @LOCATION");
                    db.DbPsetString("@LOCATION", _location);
                }
                strSQL.Append("   ) B                                                                   ");
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
        ///  棚卸結果登録
        /// 
        /// 使用画面：InvStockTakingAct
        /// </summary>
        public DataSet Get_ActCountHT()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT COUNT1,COUNT2 FROM                                                 ");
            strSQL.Append(" ( SELECT COUNT(*) COUNT1   FROM                                       ");
            strSQL.Append(" PHISICAL_COUNT  PH                                                    ");
            strSQL.Append(" LEFT JOIN ITEM_MASTER I ON PH.ITEM_NO=I.ITEM_NO                       ");
            //strSQL.Append(" WHERE PH.INV_WIP_TYPE=0                                               ");
            //strSQL.Append(" AND   PH.INV_TYPE=0                                                   ");
            strSQL.Append(" WHERE PH.INV_WIP_TYPE=@INV_WIP_TYPE ");   // 2015.08.21
            strSQL.Append(" AND   PH.PHYSICAL_CNT_STATUS=0                                        ");
            db.DbParametersClear();
            db.DbPsetInt("@INV_WIP_TYPE", _inv_wip_type);
            if (_physical_cnt_yymm != 0.0)
            {
                strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM = @PHYSICAL_CNT_YYMM");
                db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND PH.WHS_CD = @WHS_CD");
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            if (_ws_cd != "")
            {
                strSQL.Append(" AND PH.WS_CD = @WS_CD");
                db.DbPsetString("@WS_CD", _ws_cd);    // 2015.08.21
            }
            if (_item_no != "")
            {
                strSQL.Append(" AND PH.ITEM_NO = @ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_page_no != 0.0)
            {
                strSQL.Append(" AND PH.PAGE_NO = @PAGE_NO");
                db.DbPsetDouble("@PAGE_NO", _page_no);
            }

            // IMV3
            if (_location != "")
            {
                strSQL.Append(" AND PH.LOCATION = @LOCATION");
                db.DbPsetString("@LOCATION", _location);
            }
            strSQL.Append("  ) A ,(                                                               ");
            strSQL.Append(" SELECT COUNT(*) COUNT2 FROM                                           ");
            strSQL.Append(" PHISICAL_COUNT  PH                                                    ");
            strSQL.Append(" LEFT JOIN ITEM_MASTER I ON PH.ITEM_NO=I.ITEM_NO                       ");
            //strSQL.Append(" WHERE PH.INV_WIP_TYPE=0                                               ");
            //strSQL.Append(" AND   PH.INV_TYPE=0                                                   ");
            strSQL.Append(" WHERE PH.INV_WIP_TYPE=@INV_WIP_TYPE ");   // 2015.08.21
            strSQL.Append(" AND   PH.PHYSICAL_CNT_STATUS >=20                                     ");

            db.DbParametersClear();
            db.DbPsetInt("@INV_WIP_TYPE", _inv_wip_type);
            if (_physical_cnt_yymm != 0.0)
            {
                strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM = @PHYSICAL_CNT_YYMM");
                db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND PH.WHS_CD = @WHS_CD");
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            if (_ws_cd != "")
            {
                strSQL.Append(" AND PH.WS_CD = @WS_CD");
                db.DbPsetString("@WS_CD", _ws_cd);    // 2015.08.21
            }
            if (_item_no != "")
            {
                strSQL.Append(" AND PH.ITEM_NO = @ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_page_no != 0.0)
            {
                strSQL.Append(" AND PH.PAGE_NO = @PAGE_NO");
                db.DbPsetDouble("@PAGE_NO", _page_no);
            }
            // IMV3
            if (_location != "")
            {
                strSQL.Append(" AND PH.LOCATION = @LOCATION");
                db.DbPsetString("@LOCATION", _location);
            }
            strSQL.Append("   ) B                                                                   ");

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
        ///  棚卸結果登録
        /// 
        /// 使用画面：InvStockTakingAct
        /// </summary>
        public DataSet Get_ActList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //sql
            strSQL.Append(" SELECT                                                                  ");
            strSQL.Append(" PH.PAGE_NO	,				PH.LINE_NO	,			PH.LOCATION	,       ");
            strSQL.Append(" PH.ITEM_NO	,				I.ITEM_DESC	,			PH.JOC_CD	,       ");
            strSQL.Append(" PH.LOT_NO	,				PH.INV_BAL	,			I.ITEM_UMSR	,       ");
            strSQL.Append(" PH.PHYSICAL_CNT_QTY,        S.DATA_CHAR AS UMSR_NAME                    ");
            //strSQL.Append(" , PH.ALLOC_QTY,             PH.SUPPLY_TYPE,         PH.WHS_CD           ");//ADD BY UBIQ-SUO 2012/02/23
            strSQL.Append(" , ISNULL(INV.ALLOC_QTY,0) ALLOC_QTY, PH.SUPPLY_TYPE, PH.WHS_CD          ");//ADD BY UBIQ-SUO 2012/02/23 //UPD 2012.02.27 UBIQ-SAI
            strSQL.Append(" ,PH.PHYSICAL_CNT_QTY PHYSICAL_CNT_QTY1                                  ");//ADD BY UBIQ-SUO 2012/02/28
            strSQL.Append(" ,3 HT_SEND_STATUS                                                      "); // IMV3

            // 2015.05.29
            strSQL.Append(" ,CASE PH.PHYSICAL_CNT_STATUS WHEN 30 THEN 'Inventory Updated' WHEN 20 THEN 'Input Confirmed' ELSE  ");
            strSQL.Append(" '' END STATUS ");
            
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM  PHISICAL_COUNT	PH   ,ITEM_MASTER I ,SYSTEM_PARAMETER S     ");
                strSQL.Append(" WHERE PH.ITEM_NO         =I.ITEM_NO(+)                              ");
                strSQL.Append(" AND   I.ITEM_UMSR        =S.KEY02(+)                                ");
                strSQL.Append(" AND   S.KEY01            ='ITEM_UMSR'                               ");
                strSQL.Append(" AND   PH.INV_TYPE=0                                                 ");
                strSQL.Append(" AND   PH.INV_WIP_TYPE=0                                             ");

                db.DbParametersClear();
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM = :PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND PH.WHS_CD =:WHS_CD");
                    db.DbPsetString("WHS_CD", _whs_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND PH.ITEM_NO = :ITEM_NO");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_page_no != 0.0)
                {
                    strSQL.Append(" AND PH.LOT_NO = :PAGE_NO");
                    db.DbPsetDouble("PAGE_NO", _page_no);
                }
                if (_physical_cnt_status > -1)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_STATUS = :PHYSICAL_CNT_STATUS");
                    db.DbPsetDouble("PHYSICAL_CNT_STATUS", _physical_cnt_status);
                }
                strSQL.Append(" ORDER BY  PH.PAGE_NO ,PH.LINE_NO   ");
            }
            else
            {
                strSQL.Append(" FROM  PHISICAL_COUNT	PH                                              ");

                //ADD 2012.02.27 UBIQ-SAI START
                strSQL.Append(" LEFT JOIN   (SELECT *                                                   ");
                strSQL.Append("                FROM INVENTORY_DETAIL                                    ");
                strSQL.Append("               WHERE INV_YM = 0                                          ");
                strSQL.Append("              ) INV                                                      ");
                strSQL.Append(" ON  PH.ITEM_NO			= INV.ITEM_NO			                        ");
                strSQL.Append(" AND PH.INV_WIP_TYPE		= INV.INV_WIP_TYPE		                        ");
                strSQL.Append(" AND PH.INV_TYPE			= INV.INV_TYPE			                        ");
                strSQL.Append(" AND PH.WHS_CD			= INV.WHS_CD			                        ");
                strSQL.Append(" AND PH.LOCATION			= INV.LOCATION			                        ");
                strSQL.Append(" AND PH.LOT_NO			= INV.LOT_NO			                        ");
                strSQL.Append(" AND PH.JOC_CD			= INV.JOC_CD			                        ");
                strSQL.Append(" AND PH.SUPPLY_TYPE		= INV.SUPPLY_TYPE		                        ");
                strSQL.Append(" AND PH.WS_CD			= INV.WS_CD				                        ");
                strSQL.Append(" AND PH.PROCESS_CD		= INV.PROCESS_CD		                        ");
                strSQL.Append(" AND PH.JOB_ORDER_NO		= INV.JOB_ORDER_NO		                        ");
                strSQL.Append(" AND PH.MNG_NO			= INV.MNG_NO			                        ");
                //ADD 2012.02.27 UBIQ-SAI END

                strSQL.Append(" LEFT JOIN   ITEM_MASTER I ON 	PH.ITEM_NO=I.ITEM_NO                    ");
                strSQL.Append(" LEFT JOIN   SYSTEM_PARAMETER S ON I.ITEM_UMSR=S.KEY02                   ");
                strSQL.Append(" AND  S.KEY01='ITEM_UMSR'                                                ");
                strSQL.Append(" WHERE  PH.INV_WIP_TYPE=0                                                ");
                strSQL.Append(" AND    PH.INV_TYPE=0                                                    ");

                db.DbParametersClear();
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM = @PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND PH.WHS_CD = @WHS_CD");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND PH.ITEM_NO = @ITEM_NO");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_page_no != 0.0)
                {
                    strSQL.Append(" AND PH.PAGE_NO = @PAGE_NO");
                    db.DbPsetDouble("@PAGE_NO", _page_no);
                }

                // IMV3
                if (_location != "")
                {
                    strSQL.Append(" AND PH.LOCATION = @LOCATION");
                    db.DbPsetString("@LOCATION", _location);
                }
                
                if (_physical_cnt_status > -1)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_STATUS = @PHYSICAL_CNT_STATUS");
                    db.DbPsetDouble("@PHYSICAL_CNT_STATUS", _physical_cnt_status);
                }
                strSQL.Append(" ORDER BY  PH.PAGE_NO ,PH.LINE_NO   ");
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
        ///  棚卸結果登録
        /// 
        /// 使用画面：InvStockTakingAct
        /// </summary>
        public DataSet Get_ActListHT()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //sql
            strSQL.Append(" SELECT                                                                  ");
            strSQL.Append(" P.PAGE_NO	,				P.LINE_NO	,			P.LOCATION	,       ");
            strSQL.Append(" P.ITEM_NO	,				I.ITEM_DESC	,			P.JOC_CD	,       ");
            strSQL.Append(" P.LOT_NO	,				P.INV_BAL	,			I.ITEM_UMSR	,       ");
            //strSQL.Append(" PH.HT_ACT_QTY PHYSICAL_CNT_QTY,  ");
            strSQL.Append(" CASE P.INV_WIP_TYPE WHEN 0 THEN PH.HT_ACT_QTY ELSE (CASE P.PHYSICAL_CNT_STATUS WHEN 0 THEN P.INV_BAL ELSE P.PHYSICAL_CNT_QTY END) END PHYSICAL_CNT_QTY ,  ");   // 2015.08.22
            strSQL.Append(" S.DATA_CHAR AS UMSR_NAME         ");
            strSQL.Append(" , ISNULL(INV.ALLOC_QTY,0) ALLOC_QTY, P.SUPPLY_TYPE, P.WHS_CD          ");
            //strSQL.Append(" ,PH.HT_ACT_QTY PHYSICAL_CNT_QTY1                                  ");
            strSQL.Append(" ,CASE P.INV_WIP_TYPE WHEN 0 THEN PH.HT_ACT_QTY ELSE (CASE P.PHYSICAL_CNT_STATUS WHEN 0 THEN P.INV_BAL ELSE P.PHYSICAL_CNT_QTY END) END PHYSICAL_CNT_QTY1  ");   // 2015.08.22
            //strSQL.Append(" ,PH.HT_SEND_STATUS  ");
            strSQL.Append(" ,COALESCE(PH.HT_SEND_STATUS, 3) HT_SEND_STATUS  "); // 2015.08.21
            strSQL.Append(" ,P.WHS_CD  "); // 2015.08.21
            strSQL.Append(" ,P.WS_CD   "); // 2015.08.21
            strSQL.Append(" ,P.INV_WIP_TYPE   "); // 2015.08.21

            // 2015.04.27
            strSQL.Append(" ,CASE P.PHYSICAL_CNT_STATUS WHEN 30 THEN 'Inventory Updated' WHEN 20 THEN 'Input Confirmed' ELSE  ");
            strSQL.Append(" (CASE PH.HT_SEND_STATUS WHEN 2 THEN 'HT Input Done' ELSE '' END) ");
            strSQL.Append(" END STATUS ");

            // 2015.05.22
            strSQL.Append(" ,CASE P.INV_TYPE WHEN 0 THEN '' WHEN 3 THEN 'On Process ' + P.PROCESS_CD WHEN 4 THEN 'After Process ' + P.PROCESS_CD END NOTE ");   // 2015.08.22

            //strSQL.Append(" FROM  PHISICAL_COUNT_IF	PH                                              ");
            //strSQL.Append(" LEFT JOIN   PHISICAL_COUNT P                                            ");
            strSQL.Append(" FROM  PHISICAL_COUNT	P                                              ");
            strSQL.Append(" LEFT JOIN   PHISICAL_COUNT_IF PH                                        ");
            strSQL.Append(" ON   PH.PHYSICAL_CNT_TYPE	= P.PHYSICAL_CNT_TYPE			            ");
            strSQL.Append(" AND  PH.PHYSICAL_CNT_YYMM	= P.PHYSICAL_CNT_YYMM			            ");
            strSQL.Append(" AND  PH.INV_WIP_TYPE		= P.INV_WIP_TYPE			                ");
            strSQL.Append(" AND  PH.WHS_CD			    = P.WHS_CD			                        ");
            strSQL.Append(" AND  PH.WS_CD			    = P.WS_CD			                        ");
            strSQL.Append(" AND  PH.PAGE_NO			    = P.PAGE_NO			                        ");
            strSQL.Append(" AND  PH.LINE_NO			    = P.LINE_NO			                        ");
            //ADD 2012.02.27 UBIQ-SAI START
            strSQL.Append(" LEFT JOIN   (SELECT *                                                   ");
            strSQL.Append("                FROM INVENTORY_DETAIL                                    ");
            strSQL.Append("               WHERE INV_YM = 0                                          ");
            strSQL.Append("              ) INV                                                      ");
            strSQL.Append(" ON  PH.ITEM_NO			= INV.ITEM_NO			                        ");
            strSQL.Append(" AND PH.INV_WIP_TYPE		= INV.INV_WIP_TYPE		                        ");
            strSQL.Append(" AND PH.INV_TYPE			= INV.INV_TYPE			                        ");
            strSQL.Append(" AND PH.WHS_CD			= INV.WHS_CD			                        ");
            strSQL.Append(" AND PH.LOCATION			= INV.LOCATION			                        ");
            strSQL.Append(" AND PH.LOT_NO			= INV.LOT_NO			                        ");
            strSQL.Append(" AND PH.JOC_CD			= INV.JOC_CD			                        ");
            strSQL.Append(" AND PH.SUPPLY_TYPE		= INV.SUPPLY_TYPE		                        ");
            strSQL.Append(" AND PH.WS_CD			= INV.WS_CD				                        ");
            strSQL.Append(" AND PH.PROCESS_CD		= INV.PROCESS_CD		                        ");
            strSQL.Append(" AND PH.JOB_ORDER_NO		= INV.JOB_ORDER_NO		                        ");
            strSQL.Append(" AND PH.MNG_NO			= INV.MNG_NO			                        ");
            //ADD 2012.02.27 UBIQ-SAI END

            strSQL.Append(" LEFT JOIN   ITEM_MASTER I ON 	PH.ITEM_NO=I.ITEM_NO                    ");
            strSQL.Append(" LEFT JOIN   SYSTEM_PARAMETER S ON I.ITEM_UMSR=S.KEY02                   ");
            strSQL.Append(" AND  S.KEY01='ITEM_UMSR'                                                ");
            strSQL.Append(" WHERE P.INV_WIP_TYPE=@INV_WIP_TYPE ");   // 2015.08.21
            //strSQL.Append(" WHERE  PH.INV_WIP_TYPE=0                                                ");
            //strSQL.Append(" AND    PH.INV_TYPE=0                                                    ");

            db.DbParametersClear();
            db.DbPsetInt("@INV_WIP_TYPE", _inv_wip_type);
            if (_physical_cnt_yymm != 0.0)
            {
                strSQL.Append(" AND P.PHYSICAL_CNT_YYMM = @PHYSICAL_CNT_YYMM");
                db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
            }
            if (_whs_cd != "")
            {
                strSQL.Append(" AND P.WHS_CD = @WHS_CD");
                db.DbPsetString("@WHS_CD", _whs_cd);
            }
            if (_ws_cd != "")
            {
                strSQL.Append(" AND P.WS_CD = @WS_CD");
                db.DbPsetString("@WS_CD", _ws_cd);  // 2015.08.21
            }
            if (_item_no != "")
            {
                strSQL.Append(" AND P.ITEM_NO = @ITEM_NO");
                db.DbPsetString("@ITEM_NO", _item_no);
            }
            if (_page_no != 0.0)
            {
                strSQL.Append(" AND P.PAGE_NO = @PAGE_NO");
                db.DbPsetDouble("@PAGE_NO", _page_no);
            }

            // IMV3
            if (_location != "")
            {
                strSQL.Append(" AND P.LOCATION = @LOCATION");
                db.DbPsetString("@LOCATION", _location);
            }

            if (_physical_cnt_status > -1)
            {
                strSQL.Append(" AND COALESCE(P.PHYSICAL_CNT_STATUS,0) = @PHYSICAL_CNT_STATUS");
                db.DbPsetDouble("@PHYSICAL_CNT_STATUS", _physical_cnt_status);
            }
            strSQL.Append(" ORDER BY  P.PAGE_NO ,P.LINE_NO   ");

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
        ///  棚卸結果登録
        /// 
        /// 使用画面：InvStockTakingAct
        /// </summary>
        public int Act()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetDouble("@I_PHYSICAL_CNT_YYMM", _physical_cnt_yymm, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_PAGE_NO", _page_no, ComConst.DB_IN);
            db.DbPsetDouble("@I_LINE_NO", _line_no, ComConst.DB_IN);
            db.DbPsetDouble("@I_PHYSICAL_CNT_QTY", _physical_cnt_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_PHYSICAL_CNT_DATE", _physical_cnt_date, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);  // 2015.08.21
            db.DbPsetInt("@I_INV_WIP_TYPE", _inv_wip_type, ComConst.DB_IN);   // 2015.08.21

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_STOCKTAKING_ACT");
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
        ///  棚卸結果登録
        /// 
        /// 使用画面：InvStockTakingDiffRpt
        /// </summary>
        public DataSet Get_StockTakingDiffList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //sql
            strSQL.Append(" SELECT  ");
            strSQL.Append(" PH.INV_WIP_TYPE,  ");   // 2015.08.22
            //strSQL.Append(" PH.WHS_CD,                W.WHS_DESC    ,                                                    ");
            strSQL.Append(" CASE PH.INV_WIP_TYPE WHEN 0 THEN PH.WHS_CD ELSE PH.WS_CD END WHS_CD, ");   // 2015.08.22 
            strSQL.Append(" CASE PH.INV_WIP_TYPE WHEN 0 THEN W.WHS_DESC ELSE WS.WS_DESC END WHS_DESC, ");   // 2015.08.22 
            strSQL.Append(" PH.PAGE_NO  ,    PH.LINE_NO ,    PH.LOCATION  ,        PH.ITEM_NO  ,                                             ");
            strSQL.Append(" I.ITEM_DESC ,                    PH.JOC_CD    ,        PH.LOT_NO  ,                                              ");
            strSQL.Append(" PH.INV_BAL   ,                   S.DATA_CHAR AS USMR_NAME     ,                                                  ");
            strSQL.Append(" PH.PHYSICAL_CNT_QTY    ,         PH.DIFF_QTY           ,PH.PHYSICAL_CNT_YYMM                                     ");
            strSQL.Append(" , PH.INV_TYPE, PH.PROCESS_CD ");   // 2015.08.22
            strSQL.Append(" , CASE PH.INV_TYPE WHEN 0 THEN '' WHEN 3 THEN 'On Process ' + PH.PROCESS_CD WHEN 4 THEN 'After Process ' + PH.PROCESS_CD END NOTE ");   // 2015.08.22
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PHISICAL_COUNT  PH  ,WAREHOUSE_MASTER W   , ITEM_MASTER I  , SYSTEM_PARAMETER S   ");
                strSQL.Append("  WHERE PH.WHS_CD=W.WHS_CD(+)                                                           ");
                strSQL.Append("  AND   PH.ITEM_NO=I.ITEM_NO(+)                                                         ");
                strSQL.Append("  AND   S.KEY01='ITEM_UMSR'                                                             ");
                strSQL.Append("  AND   S.KEY02=PH.ITEM_UMSR(+)                                                         ");
                strSQL.Append("  AND   INV_WIP_TYPE=0                                                                  ");
                strSQL.Append("  AND   INV_TYPE=0 AND PHYSICAL_CNT_STATUS>=20                                           ");

                db.DbParametersClear();
                if (_diff_rate != 0.0)
                {
                    strSQL.Append("  AND ABS(CASE WHEN INV_BAL<>0 AND DIFF_QTY<>0                                              ");
                    strSQL.Append("  THEN ABS(DIFF_QTY/INV_BAL)*100                                                                 ");
                    strSQL.Append("  WHEN INV_BAL=0 AND DIFF_QTY<>0 THEN 100                                               ");
                    strSQL.Append("  ELSE 0  END) >=:DIFF_RATE                                                              ");
                    db.DbPsetDouble(" DIFF_RATE", _diff_rate);

                }
                if (_diff_amt != 0.0)
                {
                    strSQL.Append("  AND ABS(DIFF_AMT) >=:DIFF_AMT                                                              ");
                    db.DbPsetDouble("DIFF_AMT", _diff_amt);
                }

                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM =:PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND PH.WHS_CD =:WHS_CD");
                    db.DbPsetString("WHS_CD", _whs_cd);
                }
                strSQL.Append(" ORDER BY  PH.LOCATION,PH.ITEM_NO                                                           ");

            }
            else
            {
                strSQL.Append(" FROM PHISICAL_COUNT  PH                                                                    ");
                strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER W ON PH.WHS_CD=W.WHS_CD                                         ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER  I    ON  PH.ITEM_NO=I.ITEM_NO                                       ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01='ITEM_UMSR'   AND S.KEY02=PH.ITEM_UMSR             ");
                strSQL.Append(" LEFT OUTER JOIN  WORKSHOP_MASTER WS ON  PH.WS_CD=WS.WS_CD 	"); // 2015.08.22
                //strSQL.Append(" WHERE INV_WIP_TYPE=0                                                                       ");
                //strSQL.Append(" AND INV_TYPE=0 AND PHYSICAL_CNT_STATUS>=20 AND DIFF_QTY <>0                                                ");
                strSQL.Append(" WHERE PHYSICAL_CNT_STATUS>=20 AND DIFF_QTY <>0                                                ");
                if (_diff_rate != 0.0)
                {
                    strSQL.Append("   AND ABS(CASE WHEN INV_BAL<>0 AND DIFF_QTY<>0                                          ");
                    strSQL.Append("   THEN ABS(DIFF_QTY/INV_BAL )*100                                                       ");//ADD 'ABS()' 20090307 UBIQ-LIU
                    strSQL.Append("   WHEN INV_BAL=0 AND DIFF_QTY<>0 THEN 100                                               ");
                    strSQL.Append("   ELSE 0  END) >=@DIFF_RATE                                                             ");
                    db.DbPsetDouble("@DIFF_RATE", _diff_rate);

                }
                if (_diff_amt != 0.0)
                {
                    strSQL.Append("  AND ABS(DIFF_AMT) >=@DIFF_AMT                                                         ");
                    db.DbPsetDouble("@DIFF_AMT", _diff_amt);
                }
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM = @PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND PH.WHS_CD = @WHS_CD");
                    strSQL.Append(" AND PH.INV_WIP_TYPE = 0");  // 2015.08.22
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH.WS_CD = @WS_CD");    // 2015.08.22
                    strSQL.Append(" AND PH.INV_WIP_TYPE = 1");  // 2015.08.22
                    db.DbPsetString("@WS_CD", _ws_cd);
                }

                // IMV3
                if (_location != "")
                {
                    strSQL.Append(" AND PH.LOCATION = @LOCATION");
                    db.DbPsetString("@LOCATION", _location);
                }
                //strSQL.Append(" ORDER BY  PH.LOCATION,PH.ITEM_NO                                                           ");
                strSQL.Append(" ORDER BY 1,2,4,5  ");  // // 2015.08.22

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
        ///  棚卸報告書
        /// 
        /// 使用画面：InvStockTakingRpt
        /// </summary>
        public DataSet Get_StockTakingRpt()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //sql
            strSQL.Append(" SELECT  ");
            //strSQL.Append(" PH.WHS_CD,                W.WHS_DESC  ,                                                     ");
            strSQL.Append(" PH.INV_WIP_TYPE,  ");   // 2015.08.22
            strSQL.Append(" CASE PH.INV_WIP_TYPE WHEN 0 THEN PH.WHS_CD ELSE PH.WS_CD END WHS_CD, ");   // 2015.08.22 
            strSQL.Append(" CASE PH.INV_WIP_TYPE WHEN 0 THEN W.WHS_DESC ELSE WS.WS_DESC END WHS_DESC, ");   // 2015.08.22 
            strSQL.Append(" CONVERT(INT,PH.PAGE_NO )  AS     PAGE_NO  ,      PH.LINE_NO ,    PH.LOCATION ,           PH.ITEM_NO ,          ");
            strSQL.Append(" I.ITEM_DESC ,                    PH.JOC_CD   ,                   PH.LOT_NO  ,            PH.PHYSICAL_CNT_QTY,  ");
            strSQL.Append(" PH.INV_BAL  ,                    S.DATA_CHAR AS USMR_NAME ,      PH.DIFF_QTY ,         ");
            //strSQL.Append(" PH.PHYSICAL_CNT_AMT,             PH.DIFF_QTY ,                 PH.DIFF_AMT,            ");
            strSQL.Append(" PH.PHYSICAL_CNT_YYMM                                                                                           ");
            // IMV3
            strSQL.Append("  ,0 STD_PRC,0 PHYSICAL_CNT_AMT,0 DIFF_AMT    ");
            strSQL.Append(" , PH.INV_TYPE, PH.PROCESS_CD ");   // 2015.08.22
            strSQL.Append(" , CASE PH.INV_TYPE WHEN 0 THEN '' WHEN 3 THEN 'On Process ' + PH.PROCESS_CD WHEN 4 THEN 'After Process ' + PH.PROCESS_CD END NOTE ");   // 2015.08.22

            /*-----------2011/03/23 add begin--------------------*/
            /* IMV3
            if (prc_type == 0)//評価単価=「標準単価」の場合
            {
                strSQL.Append("  ,ISNULL(P1.STD_PRC,0) STD_PRC,PH.PHYSICAL_CNT_QTY*ISNULL(P1.STD_PRC,0) PHYSICAL_CNT_AMT,PH.DIFF_QTY*ISNULL(P1.STD_PRC,0) DIFF_AMT    ");
            }
            else if (prc_type == 1)//評価単価=月次移動平均単価の場合
            {
                strSQL.Append("  ,ISNULL(P2.MA_PRC,0) STD_PRC,PH.PHYSICAL_CNT_QTY*ISNULL(P2.MA_PRC,0) PHYSICAL_CNT_AMT,PH.DIFF_QTY*ISNULL(P2.MA_PRC,0) DIFF_AMT   ");
            }
            else//評価単価=最終仕入単価の場合
            {
                strSQL.Append("  ,ISNULL(P2.LAST_RCV_PRC,0) STD_PRC,PH.PHYSICAL_CNT_QTY*ISNULL(P2.LAST_RCV_PRC,0) PHYSICAL_CNT_AMT,PH.DIFF_QTY*ISNULL(P2.LAST_RCV_PRC,0) DIFF_AMT ");
            }
             * */
            /*-----------2011/03/23 add end--------------------*/
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PHISICAL_COUNT  PH                                                                 ");
                strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER W ON PH.WHS_CD=W.WHS_CD                                      ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER  I     ON  PH.ITEM_NO=I.ITEM_NO                                   ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01='ITEM_UMSR' AND S.KEY02=PH.ITEM_UMSR            ");
                /*-----------2011/03/23 add begin--------------------*/
                if (prc_type == 0)//評価単価=「標準単価」の場合
                {
                    strSQL.Append("  LEFT JOIN (                                ");
                    #region # 評価単価-標準単価
                    strSQL.Append("  SELECT                                             ");
                    strSQL.Append("  ITEM_NO,          STD_PRC,         CURRENCY        ");
                    strSQL.Append("  FROM STD_PRICE_MASTER                              ");
                    strSQL.Append(" WHERE       BEG_EFF_DATE   <=   :PHYSICAL_CNT_YYMM           ");
                    strSQL.Append(" AND         END_EFF_DATE   >=   :PHYSICAL_CNT_YYMM           ");
                    #endregion
                    strSQL.Append("  ) P1   ON PH.ITEM_NO = P1.ITEM_NO           ");
                }
                else//評価単価=「最終仕入単価」と「月次移動平均単価」の場合
                {
                    strSQL.Append("  LEFT JOIN (                                    ");
                    #region # 評価単価-月次移動平均単価、最終仕入単価
                    strSQL.Append("  SELECT                                         ");
                    strSQL.Append("  WHS_CD,    ITEM_NO,     MA_PRC,    LAST_RCV_PRC");
                    strSQL.Append("  FROM MONTHLY_INV                               ");
                    strSQL.Append(" WHERE       YYMM    =   :PHYSICAL_CNT_YYMM               ");
                    if (_whs_cd != "")
                    {
                        strSQL.Append(" AND         WHS_CD  =   :WHS_CD         ");
                    }
                    #endregion
                    strSQL.Append("  ) P2   ON  PH.WHS_CD    = P2.WHS_CD             ");
                    strSQL.Append("         AND PH.ITEM_NO   = P2.ITEM_NO            ");
                }
                /*-----------2011/03/23 add end--------------------*/
                strSQL.Append("  WHERE   PH.INV_WIP_TYPE=0                                                             ");
                strSQL.Append("  AND   PH.INV_TYPE=0 AND PH.PHYSICAL_CNT_STATUS=30                                     ");
                strSQL.Append("  AND   (PH.PHYSICAL_CNT_QTY!=0 OR PH.DIFF_QTY!=0)                                      ");

                db.DbParametersClear();
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM =:PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND PH.WHS_CD =:WHS_CD");
                    db.DbPsetString("WHS_CD", _whs_cd);
                }
                strSQL.Append(" order by PH.LINE_NO                                                  ");

            }
            else
            {
                strSQL.Append(" FROM PHISICAL_COUNT  PH                                                                    ");
                strSQL.Append(" LEFT JOIN WAREHOUSE_MASTER W ON PH.WHS_CD=W.WHS_CD                                         ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER  I     ON  PH.ITEM_NO=I.ITEM_NO                                      ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01='ITEM_UMSR' AND S.KEY02=PH.ITEM_UMSR               ");
                strSQL.Append(" LEFT OUTER JOIN  WORKSHOP_MASTER WS ON  PH.WS_CD=WS.WS_CD 	"); // 2015.08.22
                /*--------------2011/03/23 add begin------------*/
                /* IMV3
                if (prc_type == 0)//評価単価=「標準単価」の場合
                {
                    strSQL.Append("  LEFT JOIN (                                ");
                    #region # 評価単価-標準単価
                    strSQL.Append("  SELECT                                             ");
                    strSQL.Append("  ITEM_NO,          STD_PRC,         CURRENCY        ");
                    strSQL.Append("  FROM STD_PRICE_MASTER                              ");
                    strSQL.Append(" WHERE       BEG_EFF_DATE   <=   @PHYSICAL_CNT_YYMM           ");
                    strSQL.Append(" AND         END_EFF_DATE   >=   @PHYSICAL_CNT_YYMM           ");
                    #endregion
                    strSQL.Append("  ) P1   ON PH.ITEM_NO = P1.ITEM_NO           ");
                }
                else//評価単価=「最終仕入単価」と「月次移動平均単価」の場合
                {
                    strSQL.Append("  LEFT JOIN (                                    ");
                    #region # 評価単価-月次移動平均単価、最終仕入単価
                    strSQL.Append("  SELECT                                         ");
                    strSQL.Append("  WHS_CD,    ITEM_NO,     MA_PRC,    LAST_RCV_PRC");
                    strSQL.Append("  FROM MONTHLY_INV                               ");
                    strSQL.Append(" WHERE       YYMM    =   @PHYSICAL_CNT_YYMM               ");
                    if (_whs_cd != "")
                    {
                        strSQL.Append(" AND         WHS_CD  =   @WHS_CD         ");
                    }
                    #endregion
                    strSQL.Append("  ) P2   ON  PH.WHS_CD    = P2.WHS_CD             ");
                    strSQL.Append("         AND PH.ITEM_NO   = P2.ITEM_NO            ");
                }
                 * */
                /*--------------2011/03/23 add end------------*/
                //strSQL.Append(" WHERE PH.INV_WIP_TYPE=0                                                                    ");
                //strSQL.Append(" AND PH.INV_TYPE=0 AND PH.PHYSICAL_CNT_STATUS=30                                            ");
                strSQL.Append(" WHERE PH.PHYSICAL_CNT_STATUS=30 ");
                strSQL.Append(" AND (PH.PHYSICAL_CNT_QTY!=0 OR PH.DIFF_QTY!=0)                                             ");

                db.DbParametersClear();
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM = @PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_whs_cd != "")
                {
                    strSQL.Append(" AND PH.WHS_CD = @WHS_CD");
                    strSQL.Append(" AND PH.INV_WIP_TYPE = 0");  // 2015.08.22
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }
                // IMV3
                if (_location != "")
                {
                    strSQL.Append(" AND PH.LOCATION = @LOCATION");
                    db.DbPsetString("@LOCATION", _location);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH.WS_CD = @WS_CD");    // 2015.08.22
                    strSQL.Append(" AND PH.INV_WIP_TYPE = 1");  // 2015.08.22
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                //strSQL.Append(" order by PH.LINE_NO                                                  ");
                strSQL.Append(" ORDER BY 1,2,4,5  ");  // // 2015.08.22
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
        ///  棚卸在庫更新
        /// 
        /// 使用画面：InvStockTakingUpd
        /// </summary>
        public DataSet Get_UpdCount()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();
            //sql
            if (_ws_cd == "")
            {
                strSQL.Append(" SELECT PC.INV_WIP_TYPE,");  // 2015.08.22
                strSQL.Append(" W.WHS_DESC, PC.WHS_CD,  ");
                strSQL.Append(" ISNULL(COUNT(*),0) AS INUM, ISNULL(A.NoinputNum,0) AS NoinputNum, ");
                strSQL.Append(" ISNULL(B.DIFFNUM,0) AS DIFFNUM, ISNULL(C.FinishNum,0) AS FinishNum                              ");
                strSQL.Append(" ,PC.LOCATION                              ");   // IMV3
                db.DbParametersClear();
                strSQL.Append("  FROM   PHISICAL_COUNT PC    LEFT JOIN                                                           ");
                strSQL.Append("  (SELECT COUNT(*) AS NOINPUTNUM  ,PH1.WHS_CD                                                     ");
                strSQL.Append("   ,PH1.LOCATION    ");  // IMV3
                strSQL.Append("   FROM PHISICAL_COUNT  PH1                                                                       ");
                strSQL.Append("  WHERE PH1.PHYSICAL_CNT_STATUS=0                                                                 ");
                strSQL.Append("  AND PH1.INV_WIP_TYPE=0           AND PH1.INV_TYPE=0                                             ");
                strSQL.Append("  AND PH1.PHYSICAL_CNT_YYMM =@PHYSICAL_CNT_YYMM                                                   ");
                if (_whs_cd != "")
                {
                    strSQL.Append("  AND PH1.WHS_CD =@WHS_CD                                                                     ");
                }
                // IMV3
                if (_location != "")
                {
                    strSQL.Append("  AND PH1.LOCATION =@LOCATION                                                                     ");
                }
                //strSQL.Append("  GROUP BY PH1.WHS_CD                                                                             ");
                strSQL.Append(" GROUP BY PH1.WHS_CD,PH1.LOCATION                                                                   ");
                strSQL.Append("  ) A ON A.WHS_CD=PC.WHS_CD AND A.LOCATION=PC.LOCATION                                        ");
                strSQL.Append("  LEFT JOIN (SELECT COUNT(*) AS DIFFNUM  ,PH2.WHS_CD                                              ");
                strSQL.Append("   ,PH2.LOCATION    ");  // IMV3
                strSQL.Append("  FROM PHISICAL_COUNT PH2                                                                         ");
                strSQL.Append("  WHERE PH2.DIFF_QTY<>0                                                                           ");
                strSQL.Append("  AND PH2.INV_WIP_TYPE=0           AND PH2.INV_TYPE=0                                             ");
                strSQL.Append("  AND PH2.PHYSICAL_CNT_YYMM =@PHYSICAL_CNT_YYMM                                                   ");
                if (_whs_cd != "")
                {
                    strSQL.Append("  AND PH2.WHS_CD =@WHS_CD                                                                     ");
                }
                // IMV3
                if (_location != "")
                {
                    strSQL.Append("  AND PH2.LOCATION =@LOCATION                                                                     ");
                }
                //strSQL.Append("  GROUP BY  PH2.WHS_CD                                                                            ");
                strSQL.Append(" GROUP BY PH2.WHS_CD,PH2.LOCATION                                                                   ");
                strSQL.Append("  ) B ON B.WHS_CD=PC.WHS_CD AND B.LOCATION=PC.LOCATION                                  ");
                strSQL.Append("  LEFT JOIN (SELECT COUNT(*) AS FinishNum , PH3.WHS_CD                                            ");
                strSQL.Append("   ,PH3.LOCATION    ");  // IMV3
                strSQL.Append("  FROM PHISICAL_COUNT  PH3                                                                        ");
                strSQL.Append("  WHERE PH3.PHYSICAL_CNT_STATUS=30                                                                ");
                strSQL.Append("  AND PH3.INV_WIP_TYPE=0           AND PH3.INV_TYPE=0                                             ");
                strSQL.Append("  AND PH3.PHYSICAL_CNT_YYMM =@PHYSICAL_CNT_YYMM                                                   ");
                if (_whs_cd != "")
                {
                    strSQL.Append("  AND PH3.WHS_CD =@WHS_CD                                                                     ");
                }
                // IMV3
                if (_location != "")
                {
                    strSQL.Append("  AND PH3.LOCATION =@LOCATION                                                                     ");
                }
                //strSQL.Append("GROUP BY PH3.WHS_CD                                                                               ");
                strSQL.Append("GROUP BY PH3.WHS_CD,PH3.LOCATION                                                                   ");
                strSQL.Append("  ) C ON C.WHS_CD=PC.WHS_CD AND C.LOCATION=PC.LOCATION                                       ");
                strSQL.Append("  LEFT outer JOIN WAREHOUSE_MASTER W ON PC.WHS_CD=W.WHS_CD                                        ");
                strSQL.Append("  WHERE PC.INV_WIP_TYPE=0           AND PC.INV_TYPE=0                                             ");

                strSQL.Append("  AND PC.PHYSICAL_CNT_YYMM =@PHYSICAL_CNT_YYMM                                                    ");
                if (_whs_cd != "")
                {
                    strSQL.Append("  AND PC.WHS_CD =@WHS_CD                                                                      ");
                    db.DbPsetString("@WHS_CD", _whs_cd);
                }
                // IMV3
                if (_location != "")
                {
                    strSQL.Append("  AND PC.LOCATION =@LOCATION                                                                      ");
                    db.DbPsetString("@LOCATION", _location);
                }
                db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                //strSQL.Append("  GROUP BY PC.WHS_CD ,W.WHS_DESC ,A.NoinputNum   ,B.DIFFNUM    ,C.FinishNum                    ");
                strSQL.Append("  GROUP BY PC.INV_WIP_TYPE, PC.WHS_CD ,W.WHS_DESC ,PC.LOCATION,A.NoinputNum   ,B.DIFFNUM    ,C.FinishNum                    ");   // IMV3
            }
            // 2015.08.22 START
            if (_ws_cd == "" && _whs_cd == "")
            {
                strSQL.Append(" UNION ALL ");  // 2015.08.22
            }
            if (_whs_cd == "")
            {
                strSQL.Append(" SELECT PC.INV_WIP_TYPE,");  // 2015.08.22
                strSQL.Append(" WS.WS_DESC WHS_DESC, PC.WS_CD WHS_CD,  ");
                strSQL.Append(" ISNULL(COUNT(*),0) AS INUM, ISNULL(A.NoinputNum,0) AS NoinputNum, ");
                strSQL.Append(" ISNULL(B.DIFFNUM,0) AS DIFFNUM, ISNULL(C.FinishNum,0) AS FinishNum                              ");
                strSQL.Append(" ,PC.LOCATION                              ");   // IMV3
                strSQL.Append("  FROM   PHISICAL_COUNT PC    LEFT JOIN                                                           ");
                strSQL.Append("  (SELECT COUNT(*) AS NOINPUTNUM  ,PH1.WS_CD                                                     ");
                strSQL.Append("   ,PH1.LOCATION    ");  // IMV3
                strSQL.Append("   FROM PHISICAL_COUNT  PH1                                                                       ");
                strSQL.Append("  WHERE PH1.PHYSICAL_CNT_STATUS=0                                                                 ");
                strSQL.Append("  AND PH1.INV_WIP_TYPE=1                                             ");
                strSQL.Append("  AND PH1.PHYSICAL_CNT_YYMM =@PHYSICAL_CNT_YYMM2                                                   ");
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND PH1.WS_CD =@WS_CD                                                                     ");
                }
                // IMV3
                if (_location != "")
                {
                    strSQL.Append("  AND PH1.LOCATION =@LOCATION2                                                                     ");
                }
                //strSQL.Append("  GROUP BY PH1.WHS_CD                                                                             ");
                strSQL.Append(" GROUP BY PH1.WS_CD,PH1.LOCATION                                                                   ");
                strSQL.Append("  ) A ON A.WS_CD=PC.WS_CD AND A.LOCATION=PC.LOCATION                                        ");
                strSQL.Append("  LEFT JOIN (SELECT COUNT(*) AS DIFFNUM  ,PH2.WS_CD                                              ");
                strSQL.Append("   ,PH2.LOCATION    ");  // IMV3
                strSQL.Append("  FROM PHISICAL_COUNT PH2                                                                         ");
                strSQL.Append("  WHERE PH2.DIFF_QTY<>0                                                                           ");
                strSQL.Append("  AND PH2.INV_WIP_TYPE=1                                             ");
                strSQL.Append("  AND PH2.PHYSICAL_CNT_YYMM =@PHYSICAL_CNT_YYMM2                                                   ");
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND PH2.WS_CD =@WS_CD                                                                     ");
                }
                // IMV3
                if (_location != "")
                {
                    strSQL.Append("  AND PH2.LOCATION =@LOCATION                                                                     ");
                }
                //strSQL.Append("  GROUP BY  PH2.WHS_CD                                                                            ");
                strSQL.Append(" GROUP BY PH2.WS_CD,PH2.LOCATION                                                                   ");
                strSQL.Append("  ) B ON B.WS_CD=PC.WS_CD AND B.LOCATION=PC.LOCATION                                  ");
                strSQL.Append("  LEFT JOIN (SELECT COUNT(*) AS FinishNum , PH3.WS_CD                                            ");
                strSQL.Append("   ,PH3.LOCATION    ");  // IMV3
                strSQL.Append("  FROM PHISICAL_COUNT  PH3                                                                        ");
                strSQL.Append("  WHERE PH3.PHYSICAL_CNT_STATUS=30                                                                ");
                strSQL.Append("  AND PH3.INV_WIP_TYPE=1                                             ");
                strSQL.Append("  AND PH3.PHYSICAL_CNT_YYMM =@PHYSICAL_CNT_YYMM2                                                   ");
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND PH3.WS_CD =@WS_CD                                                                     ");
                }
                // IMV3
                if (_location != "")
                {
                    strSQL.Append("  AND PH3.LOCATION =@LOCATION                                                                     ");
                }
                //strSQL.Append("GROUP BY PH3.WHS_CD                                                                               ");
                strSQL.Append("GROUP BY PH3.WS_CD,PH3.LOCATION                                                                   ");
                strSQL.Append("  ) C ON C.WS_CD=PC.WS_CD AND C.LOCATION=PC.LOCATION                                       ");
                strSQL.Append("  LEFT outer JOIN WORKSHOP_MASTER WS ON PC.WS_CD=WS.WS_CD                                        ");
                strSQL.Append("  WHERE PC.INV_WIP_TYPE=1                                             ");

                strSQL.Append("  AND PC.PHYSICAL_CNT_YYMM =@PHYSICAL_CNT_YYMM2                                                    ");
                if (_ws_cd != "")
                {
                    strSQL.Append("  AND PC.WS_CD =@WS_CD                                                                      ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                // IMV3
                if (_location != "")
                {
                    strSQL.Append("  AND PC.LOCATION =@LOCATION                                                                      ");
                    db.DbPsetString("@LOCATION2", _location);
                }
                db.DbPsetDouble("@PHYSICAL_CNT_YYMM2", _physical_cnt_yymm);
                //strSQL.Append("  GROUP BY PC.WHS_CD ,W.WHS_DESC ,A.NoinputNum   ,B.DIFFNUM    ,C.FinishNum                    ");
                strSQL.Append("  GROUP BY PC.INV_WIP_TYPE, PC.WS_CD ,WS.WS_DESC ,PC.LOCATION,A.NoinputNum   ,B.DIFFNUM    ,C.FinishNum                    ");   // IMV3
            }
            strSQL.Append("  ORDER BY 1, 3, 7 ");   // IMV3

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
        ///  棚卸在庫更新
        /// 
        /// 使用画面：InvStockTakingUpd
        /// </summary>
        public int Upd()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetDouble("@I_PHYSICAL_CNT_YYMM", _physical_cnt_yymm, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_LOCATION", _location, ComConst.DB_IN);  // IMV3
            db.DbPsetInt("@I_INV_WIP_TYPE", _inv_wip_type, ComConst.DB_IN); // 2015.08.21

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_STOCKTAKING_UPD");
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
        ///  仕掛棚卸抽出
        /// 
        /// 使用画面：WipStockTakingAbstract
        /// </summary>
        public DataSet Get_WipAbstractList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //sql
            //Del 2013.03.01 Ubiq-Sai Begin
            //strSQL.Append(" SELECT  INV.WS_CD ,   WS.WS_DESC     ,  INV.PROCESS_CD ,                                                ");
            //strSQL.Append(" PRO.PROCESS_DESC   ,  COUNT(*) as ITEM_QTY,                                                             ");
            //strSQL.Append(" SUBSTRING( CONVERT(VARCHAR(8),PHISICAL.MAX_PHYSICAL_CNT_DATE),1,6) AS CNT_DATE ,                        ");
            //strSQL.Append(" CASE  MAX_INV_UPD_DATE  WHEN  0 THEN 00000000 ELSE                                                      ");
            //strSQL.Append(" YEAR(CONVERT(DATETIME,CONVERT(VARCHAR(8) ,PHISICAL.MAX_INV_UPD_DATE)))*100+MONTH(CONVERT(DATETIME,      ");
            //strSQL.Append(" CONVERT(VARCHAR(8),PHISICAL.MAX_INV_UPD_DATE))) END  AS UPD_DATE                                        ");
            //Del 2013.03.01 Ubiq-Sai End

            //Add 2013.03.01 Ubiq-Sai Begin
            strSQL.Append(" SELECT  INV.WS_CD ,   WS.WS_DESC     ,  INV.PROCESS_CD ,                                                ");
            strSQL.Append(" PRO.PROCESS_DESC   ,  COUNT(*) as ITEM_QTY,                                                             ");
            strSQL.Append(" SUBSTRING( CONVERT(VARCHAR(8),MAX(PHISICAL.PHYSICAL_CNT_DATE) ),1,6) AS CNT_DATE ,                      ");
            strSQL.Append(" CASE  COALESCE(MAX(PHYSICAL_CNT_DATE),0)  WHEN  0 THEN 00000000 ELSE                                    ");
            strSQL.Append(" YEAR(CONVERT(DATETIME,CONVERT(VARCHAR(8) ,MAX(PHYSICAL_CNT_DATE))))*100+MONTH(CONVERT(DATETIME,         ");
            strSQL.Append(" CONVERT(VARCHAR(8),MAX(PHYSICAL_CNT_DATE)))) END  AS UPD_DATE                                           ");
            //Add 2013.03.01 Ubiq-Sai End

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM INVENTORY_DETAIL   INV ,                                                                       ");
                strSQL.Append(" (SELECT WS_CD, MAX(PHYSICAL_CNT_DATE) MAX_PHYSICAL_CNT_DATE ,MAX(INV_UPD_DATE) MAX_INV_UPD_DATE     ");
                strSQL.Append(" FROM PHISICAL_COUNT                                                                                 ");
                strSQL.Append(" GROUP BY WS_CD) PHISICAL  ,WORKSHOP_MASTER WS ,PROCESS_MASTER  PRO                                  ");
                strSQL.Append(" WHERE INV.WS_CD=PHISICAL.WS_CD(+)                                                                   ");
                strSQL.Append(" AND INV.WS_CD=WS.WS_CD(+)                                                                           ");
                strSQL.Append(" AND INV.PROCESS_CD= PRO.PROCESS_CD(+)                                                               ");
                strSQL.Append(" AND INV.INV_WIP_TYPE=1                                                                              ");
                strSQL.Append(" AND INV.INV_TYPE=0                                                                                  ");
                strSQL.Append(" AND INV.PHYSICAL_CNT_YYMM =:PHYSICAL_CNT_YYMM                                                       ");
                db.DbParametersClear();
                db.DbPsetDouble("PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                db.DbPsetInt("BEGIN_DATE", _begin_date);
                db.DbPsetInt("END_DATE", _end_date);
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND INV.WS_CD =:WS_CD");
                    db.DbPsetString("WS_CD", _ws_cd);
                }
                //--> ADD BY UBIQ-LIU 2010/5/17
                strSQL.Append(" AND (INV.INV_BAL <> 0                                       ");
                strSQL.Append("      OR (INV.INV_BAL = 0                                    ");
                strSQL.Append("          AND ( (INV.LAST_RECV_DATE >= :BEGIN_DATE           ");
                strSQL.Append("                 AND INV.LAST_RECV_DATE <= :END_DATE )       ");
                strSQL.Append("             OR (INV.LAST_ADJ_IN_DATE >= :BEGIN_DATE         ");
                strSQL.Append("                 AND INV.LAST_ADJ_IN_DATE <= :END_DATE )     ");
                strSQL.Append("             OR (INV.LAST_DISB_DATE >= :BEGIN_DATE           ");
                strSQL.Append("                 AND INV.LAST_DISB_DATE <= :END_DATE )       ");
                strSQL.Append("             OR (INV.LAST_ADJ_OUT_DATE >= :BEGIN_DATE        ");
                strSQL.Append("                 AND INV.LAST_ADJ_OUT_DATE <= :END_DATE )    ");
                strSQL.Append("              )                                              ");
                strSQL.Append("         )                                                   ");
                strSQL.Append("     )                                                       ");
                //<-- END ADD
            }
            else
            {

                //strSQL.Append(" FROM INVENTORY_DETAIL   INV                                                                             ");
                //strSQL.Append(" LEFT JOIN                                                                                               ");
                //strSQL.Append(" (SELECT WS_CD, MAX(PHYSICAL_CNT_DATE) MAX_PHYSICAL_CNT_DATE ,MAX(INV_UPD_DATE) MAX_INV_UPD_DATE         ");
                //strSQL.Append(" FROM PHISICAL_COUNT                                                                                     ");
                //strSQL.Append(" WHERE INV_WIP_TYPE=1                                                                                    "); //Add 2013.02.01 Ubiq-Sai Pwk_cust
                //strSQL.Append(" AND INV_TYPE=0                                                                                          "); //Add 2013.02.01 Ubiq-Sai Pwk_cust
                //strSQL.Append(" GROUP BY WS_CD) PHISICAL  ON INV.WS_CD=PHISICAL.WS_CD                                                   ");
                //strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WS        ON  INV.WS_CD=WS.WS_CD                                              ");
                //strSQL.Append(" LEFT JOIN                                                                                               ");
                //strSQL.Append(" PROCESS_MASTER  PRO       ON  INV.PROCESS_CD= PRO.PROCESS_CD                                            ");
                //strSQL.Append(" WHERE  INV.INV_WIP_TYPE=1                                                                               ");
                //strSQL.Append(" AND    INV.INV_TYPE=0                                                                                   ");
                //strSQL.Append(" AND INV.INV_YM =@INV_YM");

                strSQL.Append(" FROM INVENTORY_DETAIL   INV                                                                             ");
                strSQL.Append(" LEFT OUTER JOIN PHISICAL_COUNT PHISICAL     													");
                strSQL.Append(" ON  INV.WS_CD=PHISICAL.WS_CD                       											");
                strSQL.Append(" and INV.ITEM_NO =PHISICAL.ITEM_NO  																");
                strSQL.Append(" and INV.INV_WIP_TYPE=   PHISICAL.INV_WIP_TYPE 													");
                strSQL.Append(" and INV.INV_TYPE     =   PHISICAL.INV_TYPE  													");
                strSQL.Append(" and PHISICAL.PHYSICAL_CNT_TYPE =1																");
                strSQL.Append(" and PHiSICAL.PHYSICAL_CNT_YYMM= (SELECT MAX(PHYSICAL_CNT_YYMM) from PHISICAL_COUNT)				");
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WS        ON  INV.WS_CD=WS.WS_CD                                              ");
                strSQL.Append(" LEFT JOIN                                                                                               ");
                strSQL.Append(" PROCESS_MASTER  PRO       ON  INV.PROCESS_CD= PRO.PROCESS_CD                                            ");
                strSQL.Append(" WHERE  INV.INV_WIP_TYPE=1                                                                               ");
                strSQL.Append(" AND    INV.INV_TYPE=0                                                                                   ");
                strSQL.Append(" AND INV.INV_YM =@INV_YM");

                db.DbParametersClear();
                db.DbPsetDouble("@INV_YM", _inv_ym);
                db.DbPsetInt("@BEGIN_DATE", _begin_date);
                db.DbPsetInt("@END_DATE", _end_date);
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND INV.WS_CD =@WS_CD");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                //--> ADD BY UBIQ-LIU 2010/5/17
                strSQL.Append(" AND (INV.INV_BAL <> 0                                       ");
                strSQL.Append("      OR (INV.INV_BAL = 0                                    ");
                strSQL.Append("          AND ( (INV.LAST_RECV_DATE >= @BEGIN_DATE           ");
                strSQL.Append("                 AND INV.LAST_RECV_DATE <= @END_DATE )       ");
                strSQL.Append("             OR (INV.LAST_ADJ_IN_DATE >= @BEGIN_DATE         ");
                strSQL.Append("                 AND INV.LAST_ADJ_IN_DATE <= @END_DATE )     ");
                strSQL.Append("             OR (INV.LAST_DISB_DATE >= @BEGIN_DATE           ");
                strSQL.Append("                 AND INV.LAST_DISB_DATE <= @END_DATE )       ");
                strSQL.Append("             OR (INV.LAST_ADJ_OUT_DATE >= @BEGIN_DATE        ");
                strSQL.Append("                 AND INV.LAST_ADJ_OUT_DATE <= @END_DATE )    ");
                strSQL.Append("              )                                              ");
                strSQL.Append("         )                                                   ");
                strSQL.Append("     )                                                       ");
                //<-- END ADD
            }
            //Del 2013.03.01 Ubiq-Sai Begin
            //strSQL.Append(" GROUP BY  INV.WS_CD ,WS.WS_DESC ,INV.PROCESS_CD ,PRO.PROCESS_DESC , ");
            //strSQL.Append(" PHISICAL.MAX_PHYSICAL_CNT_DATE,MAX_INV_UPD_DATE                     ");
            //Del 2013.03.01 Ubiq-Sai End
            strSQL.Append(" GROUP BY  INV.WS_CD ,WS.WS_DESC ,INV.PROCESS_CD ,PRO.PROCESS_DESC   "); //Add 2013.03.01 Ubiq-Sai
            strSQL.Append(" ORDER BY  INV.WS_CD ,INV.PROCESS_CD                                 "); //Add 2013.02.01 Ubiq-Sai Pwk_cust
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
        ///  仕掛棚卸抽出
        /// 
        /// 使用画面：WipStockTakingAbstract
        /// </summary>
        public int WipAbstract()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetDouble("@I_PHYSICAL_CNT_YYMM", _physical_cnt_yymm, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_WIPSTOCKTAKING_ABSTRACT");
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
        ///  仕掛棚卸リスト


        /// 
        /// 使用画面：WipStockTakingList
        /// </summary>
        public DataSet Get_WipStockTakingList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //sql
            strSQL.Append("   SELECT  PH.PHYSICAL_CNT_YYMM ,    PH.WS_CD  ,    WS.WS_DESC ,                        ");
            strSQL.Append("   PH.PROCESS_CD ,     PRO.PROCESS_DESC ,   CONVERT(INT ,PH.PAGE_NO) AS PAGE_NO,        ");
            strSQL.Append("   PH.LINE_NO  ,PH.ITEM_NO  ,I.ITEM_DESC  , PH.JOC_CD ,PH.LOT_NO,PH.INV_BAL ,           ");
            strSQL.Append("   PH.ITEM_UMSR ,S.DATA_CHAR AS UMSR_NAME                                               ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PHISICAL_COUNT PH   ,WORKSHOP_MASTER  WS ,PROCESS_MASTER  PRO ,               ");
                strSQL.Append(" ITEM_MASTER   I    ,SYSTEM_PARAMETER  S                                            ");
                strSQL.Append(" WHERE  PH.WS_CD                   =WS.WS_CD(+)                                     ");
                strSQL.Append(" AND    PRO.PROCESS_CD=PH.PROCESS_CD(+)                                             ");
                strSQL.Append(" AND    I.ITEM_NO=PH.ITEM_NO(+)                                                     ");
                strSQL.Append(" AND    S.KEY01='ITEM_UMSR'  AND S.KEY02=PH.ITEM_UMSR(+)                            ");
                strSQL.Append(" AND    PH.PHYSICAL_CNT_STATUS<=20                                                    ");
                strSQL.Append(" AND    INV_TYPE=0                                                                  ");
                strSQL.Append(" AND    INV_WIP_TYPE=1                                                              ");

                db.DbParametersClear();
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM =:PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH.WS_CD =:WS_CD");
                    db.DbPsetString("WS_CD", _ws_cd);
                }
                if (_process_cd != "")
                {
                    strSQL.Append(" AND PH.PROCESS_CD =:PROCESS_CD");
                    db.DbPsetString("PROCESS_CD", _process_cd);
                }
                strSQL.Append(" ORDER BY   PH.LINE_NO  ");
            }
            else
            {
                strSQL.Append(" FROM PHISICAL_COUNT PH                                                             ");
                strSQL.Append(" LEFT JOIN   WORKSHOP_MASTER  WS on  PH.WS_CD=WS.WS_CD                              ");
                strSQL.Append(" LEFT JOIN  PROCESS_MASTER  PRO  on  PRO.PROCESS_CD=PH.PROCESS_CD                   ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER   I       on  I.ITEM_NO=PH.ITEM_NO                           ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER  S   on  S.KEY01='ITEM_UMSR'  AND S.KEY02=PH.ITEM_UMSR  ");
                strSQL.Append(" WHERE PH.PHYSICAL_CNT_STATUS<=20 AND PH.INV_TYPE=0 AND PH.INV_WIP_TYPE=1             ");

                db.DbParametersClear();
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM =@PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH.WS_CD =@WS_CD");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_process_cd != "")
                {
                    strSQL.Append(" AND PH.PROCESS_CD =@PROCESS_CD");
                    db.DbPsetString("@PROCESS_CD", _process_cd);
                }

                strSQL.Append(" ORDER BY   PH.LINE_NO  ");
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
        ///  仕掛棚卸結果登録
        /// 
        /// 使用画面：WipStockTakingAct
        /// </summary>
        public DataSet Get_WipActCount()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //sql
            strSQL.Append(" SELECT A.NOTINPUT,B.INPUT  FROM                                                             ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" (SELECT COUNT(*) AS NOTINPUT  FROM  PHISICAL_COUNT PH , ITEM_MASTER I                   ");
                strSQL.Append(" WHERE  I.ITEM_NO=PH.ITEM_NO(+)                                                          ");
                strSQL.Append(" AND  INV_WIP_TYPE=1 AND INV_TYPE=0 AND PHYSICAL_CNT_STATUS=0                            ");
                strSQL.Append("    ) A ,                                                                                ");
                strSQL.Append(" (SELECT COUNT(*) AS INPUT FROM                                                          ");
                strSQL.Append(" PHISICAL_COUNT PH,   ITEM_MASTER  I                                                     ");
                strSQL.Append(" WHERE  I.ITEM_NO=PH.ITEM_NO(+)                                                          ");
                strSQL.Append("  AND INV_WIP_TYPE=1 AND INV_TYPE=0 AND PHYSICAL_CNT_STATUS>=20) B                       ");

                db.DbParametersClear();
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM =:PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH.WS_CD =@WS_CD");
                    db.DbPsetString("WS_CD", _ws_cd);
                }
                if (_process_cd != "")
                {
                    strSQL.Append(" AND PH.PROCESS_CD =:PROCESS_CD");
                    db.DbPsetString("@PROCESS_CD", _process_cd);
                }
                if (_page_no != 0.0)
                {
                    strSQL.Append(" AND PH.PAGE_NO =:PAGE_NO");
                    db.DbPsetDouble("PAGE_NO", _page_no);
                }

            }
            else
            {

                strSQL.Append(" (SELECT COUNT(*) AS NOTINPUT  FROM  PHISICAL_COUNT PH                                   ");
                strSQL.Append(" LEFT   JOIN  ITEM_MASTER  I ON  I.ITEM_NO=PH.ITEM_NO                                    ");
                strSQL.Append(" WHERE INV_WIP_TYPE=1 AND INV_TYPE=0 AND PHYSICAL_CNT_STATUS=0                           ");
                strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM =@PHYSICAL_CNT_YYMM");

                db.DbParametersClear();
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH.WS_CD =@WS_CD");
                }
                //if (_process_cd != "")
                //{
                //    strSQL.Append(" AND PH.PROCESS_CD =@PROCESS_CD");
                //}
                if (_page_no != 0.0)
                {
                    strSQL.Append(" AND PH.PAGE_NO =@PAGE_NO");
                    db.DbPsetDouble("@PAGE_NO", _page_no);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND I.ITEM_NO =@ITEM_NO");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                db.DbPsetString("@WS_CD", _ws_cd);
                strSQL.Append("    ) A ,                                                                                ");
                strSQL.Append(" (SELECT COUNT(*) AS INPUT FROM                                                          ");
                strSQL.Append(" PHISICAL_COUNT PH                                                                       ");
                strSQL.Append(" LEFT   JOIN  ITEM_MASTER  I ON  I.ITEM_NO=PH.ITEM_NO                                    ");
                strSQL.Append(" WHERE INV_WIP_TYPE=1 AND INV_TYPE=0 AND PHYSICAL_CNT_STATUS>=20                         ");
                strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM    =   @PHYSICAL_CNT_YYMM                                      ");

                db.DbParametersClear();
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH.WS_CD =@WS_CD");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                //if (_process_cd != "")
                //{
                //    strSQL.Append(" AND PH.PROCESS_CD   =   @PROCESS_CD                         ");
                //    db.DbPsetString("@PROCESS_CD", _process_cd);
                //}
                if (_page_no != 0.0)
                {
                    strSQL.Append(" AND PH.PAGE_NO      =   @PAGE_NO                            ");
                    db.DbPsetDouble("@PAGE_NO", _page_no);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND I.ITEM_NO       =   @ITEM_NO                            ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                strSQL.Append("   ) B                  ");

                db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);


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
        ///  仕掛棚卸結果登録
        /// 
        /// 使用画面：WipStockTakingAct
        /// </summary>
        public DataSet Get_WipActList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //sql
            strSQL.Append(" SELECT PH.PAGE_NO,PH.LINE_NO,PH.ITEM_NO,                                                    ");
            strSQL.Append(" I.ITEM_DESC ,PH.JOC_CD,PH.LOT_NO  ,                                                         ");
            strSQL.Append(" PH.INV_BAL,                                                                                 ");
            strSQL.Append(" I.ITEM_UMSR,                                                                                ");
            strSQL.Append(" PH.PHYSICAL_CNT_QTY,                                                                        ");
            strSQL.Append(" S.DATA_CHAR AS UMSR_NAME                                                                    ");
            //strSQL.Append(" , PH.ALLOC_QTY,             PH.SUPPLY_TYPE,         PH.WHS_CD,      PH.WS_CD                ");//ADD BY UBIQ-SUO 2012/02/23
            strSQL.Append(" , ISNULL(INV.ALLOC_QTY,0) ALLOC_QTY, PH.SUPPLY_TYPE, PH.WHS_CD, PH.WS_CD                    ");//ADD BY UBIQ-SUO 2012/02/23   //UPD 2012.02.27 UBIQ-SAI
            strSQL.Append(" , PH.PHYSICAL_CNT_QTY PHYSICAL_CNT_QTY1                                                     ");//ADD BY UBIQ-SUO 2012/02/28
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM                                                                                    ");
                strSQL.Append(" PHISICAL_COUNT PH ,ITEM_MASTER I   ,SYSTEM_PARAMETER S                                  ");
                strSQL.Append(" WHERE I.ITEM_NO=PH.ITEM_NO(+)                                                           ");
                strSQL.Append(" AND S.KEY01='ITEM_UMSR' AND S.KEY02=PH.ITEM_UMSR(+)                                     ");
                strSQL.Append(" AND INV_WIP_TYPE=1 AND INV_TYPE=0                                                       ");
                strSQL.Append(" AND  PHYSICAL_CNT_YYMM=:PHYSICAL_CNT_YYMM                                               ");
                strSQL.Append(" AND  WS_CD=:WS_CD                                                                       ");
                strSQL.Append(" AND  PROCESS_CD=:PROCESS_CD                                                             ");
                strSQL.Append(" AND  PAGE_NO=:PAGE_NO                                                                   ");
                strSQL.Append(" AND  I.ITEM_NO=:ITEM_NO                                                                 ");

                db.DbParametersClear();
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM =:PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH.WS_CD =:WS_CD");
                    db.DbPsetString("WS_CD", _ws_cd);
                }
                //if (_process_cd != "")
                //{
                //    strSQL.Append(" AND PH.PROCESS_CD =:PROCESS_CD");
                //    db.DbPsetString("PROCESS_CD", _process_cd);
                //}
                if (_page_no != 0.0)
                {
                    strSQL.Append(" AND PH.PAGE_NO =:PAGE_NO");
                    db.DbPsetDouble("PAGE_NO", _page_no);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND I.ITEM_NO =:ITEM_NO");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_physical_cnt_status > -1)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_STATUS = @PHYSICAL_CNT_STATUS");
                    db.DbPsetDouble("@PHYSICAL_CNT_STATUS", _physical_cnt_status);
                }
                strSQL.Append(" ORDER BY  PH.PAGE_NO ,PH.LINE_NO   ");
            }
            else
            {
                strSQL.Append(" FROM                                                                                    ");
                strSQL.Append(" PHISICAL_COUNT PH                                                                       ");

                //ADD 2012.02.27 UBIQ-SAI START
                strSQL.Append(" LEFT JOIN   (SELECT *                                                                   ");
                strSQL.Append("                FROM INVENTORY_DETAIL                                                    ");
                strSQL.Append("               WHERE INV_YM = 0                                                          ");
                strSQL.Append("              ) INV                                                                      ");
                strSQL.Append(" ON  PH.ITEM_NO			= INV.ITEM_NO			                                        ");
                strSQL.Append(" AND PH.INV_WIP_TYPE		= INV.INV_WIP_TYPE		                                        ");
                strSQL.Append(" AND PH.INV_TYPE			= INV.INV_TYPE			                                        ");
                strSQL.Append(" AND PH.WHS_CD			= INV.WHS_CD			                                        ");
                strSQL.Append(" AND PH.LOCATION			= INV.LOCATION			                                        ");
                strSQL.Append(" AND PH.LOT_NO			= INV.LOT_NO			                                        ");
                strSQL.Append(" AND PH.JOC_CD			= INV.JOC_CD			                                        ");
                strSQL.Append(" AND PH.SUPPLY_TYPE		= INV.SUPPLY_TYPE		                                        ");
                strSQL.Append(" AND PH.WS_CD			= INV.WS_CD				                                        ");
                strSQL.Append(" AND PH.PROCESS_CD		= INV.PROCESS_CD		                                        ");
                strSQL.Append(" AND PH.JOB_ORDER_NO		= INV.JOB_ORDER_NO		                                        ");
                strSQL.Append(" AND PH.MNG_NO			= INV.MNG_NO			                                        ");
                //ADD 2012.02.27 UBIQ-SAI END

                strSQL.Append(" LEFT JOIN ITEM_MASTER I      ON I.ITEM_NO=PH.ITEM_NO                                    ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01='ITEM_UMSR' AND S.KEY02=PH.ITEM_UMSR            ");
                strSQL.Append(" WHERE PH.INV_WIP_TYPE = 1 AND PH.INV_TYPE = 0                                           ");

                db.DbParametersClear();
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM =@PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH.WS_CD =@WS_CD");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                //if (_process_cd != "")
                //{
                //    strSQL.Append(" AND PH.PROCESS_CD =@PROCESS_CD");
                //    db.DbPsetString("@PROCESS_CD", _process_cd);
                //}
                if (_page_no != 0.0)
                {
                    strSQL.Append(" AND PH.PAGE_NO =@PAGE_NO");
                    db.DbPsetDouble("@PAGE_NO", _page_no);
                }
                if (_item_no != "")
                {
                    strSQL.Append(" AND I.ITEM_NO =@ITEM_NO");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_physical_cnt_status > -1)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_STATUS = @PHYSICAL_CNT_STATUS");
                    db.DbPsetDouble("@PHYSICAL_CNT_STATUS", _physical_cnt_status);
                }
                strSQL.Append(" ORDER BY  PH.PAGE_NO ,PH.LINE_NO   ");
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
        ///  仕掛棚卸結果登録
        /// 
        /// 使用画面：WipStockTakingAct
        /// </summary>
        public int WipAct()
        {
            int rtn = 0;
            ComDB db = new ComDB(_db_type);

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetDouble("@I_PHYSICAL_CNT_YYMM", _physical_cnt_yymm, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetDouble("@I_PAGE_NO", _page_no, ComConst.DB_IN);
            db.DbPsetDouble("@I_LINE_NO", _line_no, ComConst.DB_IN);
            db.DbPsetDouble("@I_PHYSICAL_CNT_QTY", _physical_cnt_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_PHYSICAL_CNT_DATE", _physical_cnt_date, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_WIPSTOCKTAKING_ACT");
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
        ///  仕掛棚卸差異リスト

        /// 
        /// 使用画面：WipStockTakingDiffRpt
        /// </summary>
        public DataSet Get_WipStockTakingDiffList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //sql 
            strSQL.Append(" SELECT  PH.WS_CD,                  WS.WS_DESC,            PH.PROCESS_CD ,                                            ");
            strSQL.Append(" PRO.PROCESS_DESC,                  PH.PAGE_NO,            PH.LINE_NO,                                                ");
            strSQL.Append(" PH.ITEM_NO,                        I.ITEM_DESC ,          PH.LINE_NO,                                                ");
            strSQL.Append(" PH.JOC_CD,                         PH.LOT_NO,PH.INV_BAL,  PH.ITEM_UMSR,                                              ");
            strSQL.Append(" S.DATA_CHAR AS UMSR_NAME ,         PH.PHYSICAL_CNT_QTY,   PH.DIFF_QTY ,                                              ");
            strSQL.Append(" PH.PHYSICAL_CNT_YYMM                                                                                                 ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PHISICAL_COUNT  PH  ,JOIN WORKSHOP_MASTER WS   ,PROCESS_MASTER PRO  , SYSTEM_PARAMETER S  ,ITEM_MASTER  I  ");
                strSQL.Append("  WHERE PH.WS_CD=WS.WS_CD(+)                                                                                     ");
                strSQL.Append("  AND   PH.ITEM_NO=I.ITEM_NO(+)                                                                                  ");
                strSQL.Append("  AND   S.KEY01='ITEM_UMSR'                                                                                      ");
                strSQL.Append("  AND   PH.KEY02=PH.ITEM_UMSR(+)                                                                                 ");
                strSQL.Append("  AND   PH.PROCESS_CD=PRO.PROCESS_CD(+)                                                                          ");
                strSQL.Append("  AND   INV_WIP_TYPE=0                                                                                           ");
                strSQL.Append("  AND   INV_TYPE=0 AND PHYSICAL_CNT_STATUS>=20                                                                    ");

                db.DbParametersClear();
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM =:PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH.WS_CD =:WS_CD");
                    db.DbPsetString("WS_CD", _ws_cd);
                }
                if (_process_cd != "")
                {
                    strSQL.Append(" AND PH.PROCESS_CD =:PROCESS_CD");
                    db.DbPsetString("PROCESS_CD", _process_cd);
                }
                if (_diff_rate != 0.0)
                {
                    strSQL.Append("  AND ABS(CASE WHEN INV_BAL<>0 AND DIFF_QTY<>0                                              ");
                    strSQL.Append("  THEN ABS(DIFF_QTY/INV_BAL)*100                                                            ");//ADD 'ABS()' 20090307 UBIQ-LIU
                    strSQL.Append("  WHEN INV_BAL=0 AND DIFF_QTY<>0 THEN 100                                               ");
                    strSQL.Append("  ELSE 0  END) >=:DIFF_RATE                                                              ");
                    db.DbPsetDouble("DIFF_RATE", _diff_rate);

                }
                if (_diff_amt != 0.0)
                {
                    strSQL.Append("  AND ABS(DIFF_AMT) >=:DIFF_AMT                                                              ");
                    db.DbPsetDouble("DIFF_RATE", _diff_amt);
                }
                strSQL.Append("  order by  ITEM_NO                                                                        ");
            }
            else
            {
                strSQL.Append(" FROM  PHISICAL_COUNT PH                                                                     ");
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WS ON WS.WS_CD=PH.WS_CD                                           ");
                strSQL.Append(" LEFT JOIN PROCESS_MASTER PRO ON PRO.PROCESS_CD=PH.PROCESS_CD                                ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01='ITEM_DESC' AND S.KEY02=PH.ITEM_UMSR                ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER  I     ON I.ITEM_NO=PH.ITEM_NO                                        ");
                strSQL.Append(" WHERE PH.INV_WIP_TYPE=1 AND PH.INV_TYPE=0                                                   ");
                strSQL.Append(" AND   PH.PHYSICAL_CNT_STATUS>=20  AND DIFF_QTY<>0                                                            ");

                db.DbParametersClear();
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM =@PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH.WS_CD =@WS_CD");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_process_cd != "")
                {
                    strSQL.Append(" AND PH.PROCESS_CD =@PROCESS_CD");
                    db.DbPsetString("@PROCESS_CD", _process_cd);
                }
                if (_diff_rate != 0.0)
                {
                    strSQL.Append("  AND ABS(CASE WHEN INV_BAL<>0 AND DIFF_QTY<>0                                              ");
                    strSQL.Append("  THEN ABS(DIFF_QTY/INV_BAL)*100                                                                 ");
                    strSQL.Append("  WHEN INV_BAL=0 AND DIFF_QTY<>0 THEN 100                                               ");
                    strSQL.Append("  ELSE 0  END) >=@DIFF_RATE                                                              ");
                    db.DbPsetDouble("@DIFF_RATE", _diff_rate);

                }
                if (_diff_amt != 0.0)
                {
                    strSQL.Append("  AND ABS(DIFF_AMT) >=@DIFF_AMT                                                              ");
                    db.DbPsetDouble("@DIFF_AMT", _diff_amt);
                }

                strSQL.Append("  order by  ITEM_NO                                                              ");
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
        /// 仕掛棚卸報告書
        /// 
        /// 使用画面：WipStockTakingRpt
        /// </summary>
        public DataSet Get_WipStockTakingRpt()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //sql   
            strSQL.Append("  SELECT  PH.WS_CD,                  WS.WS_DESC,                 PH.PROCESS_CD ,                 ");
            strSQL.Append("  PRO.PROCESS_DESC,                  convert(int,PH.PAGE_NO) as PAGE_NO,                         ");
            strSQL.Append("  PH.ITEM_NO,                        I.ITEM_DESC ,                           ");
            strSQL.Append("  PH.JOC_CD,                         PH.LOT_NO,                  PH.INV_BAL,                     ");
            strSQL.Append("  PH.ITEM_UMSR,                      S.DATA_CHAR AS UMSR_NAME ,  PH.PHYSICAL_CNT_QTY,            ");
            strSQL.Append("  PH.DIFF_QTY ,                      PH.PHYSICAL_CNT_YYMM ,      PH.LINE_NO                      ");
            //strSQL.Append("  PH.DIFF_AMT  ,                   PH.PHYSICAL_CNT_AMT,PH.STD_PRC         ");
            /*-----------2011/03/23 add begin--------------------*/
            if (prc_type == 0)//評価単価=「標準単価」の場合
            {
                strSQL.Append("  ,ISNULL(P1.STD_PRC,0) STD_PRC,PH.PHYSICAL_CNT_QTY*ISNULL(P1.STD_PRC,0) PHYSICAL_CNT_AMT,PH.DIFF_QTY*ISNULL(P1.STD_PRC,0) DIFF_AMT    ");
            }
            else if (prc_type == 1)//評価単価=月次移動平均単価の場合
            {
                strSQL.Append("  ,ISNULL(P2.MA_PRC,0) STD_PRC,PH.PHYSICAL_CNT_QTY*ISNULL(P2.MA_PRC,0) PHYSICAL_CNT_AMT,PH.DIFF_QTY*ISNULL(P2.MA_PRC,0) DIFF_AMT   ");
            }
            else//評価単価=最終仕入単価の場合
            {
                strSQL.Append("  ,ISNULL(P2.LAST_RCV_PRC,0) STD_PRC,PH.PHYSICAL_CNT_QTY*ISNULL(P2.LAST_RCV_PRC,0) PHYSICAL_CNT_AMT,PH.DIFF_QTY*ISNULL(P2.LAST_RCV_PRC,0) DIFF_AMT ");
            }
            /*--------------2011/03/23 add end------------*/
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PHISICAL_COUNT  PH           ");
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WS ON WS.WS_CD=PH.WS_CD                                           ");
                strSQL.Append(" LEFT JOIN PROCESS_MASTER PRO ON PRO.PROCESS_CD=PH.PROCESS_CD                                ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01='ITEM_DESC' AND S.KEY02=PH.ITEM_UMSR                ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER  I     ON I.ITEM_NO=PH.ITEM_NO                                        ");
                /*-----------2011/03/23 add begin--------------------*/
                if (prc_type == 0)//評価単価=「標準単価」の場合
                {
                    strSQL.Append("  LEFT JOIN (                                ");
                    #region # 評価単価-標準単価
                    strSQL.Append("  SELECT                                             ");
                    strSQL.Append("  ITEM_NO,          STD_PRC,         CURRENCY        ");
                    strSQL.Append("  FROM STD_PRICE_MASTER                              ");
                    strSQL.Append(" WHERE       BEG_EFF_DATE   <=   :PHYSICAL_CNT_YYMM           ");
                    strSQL.Append(" AND         END_EFF_DATE   >=   :PHYSICAL_CNT_YYMM           ");
                    #endregion
                    strSQL.Append("  ) P1   ON PH.ITEM_NO = P1.ITEM_NO           ");
                }
                else//評価単価=「最終仕入単価」と「月次移動平均単価」の場合
                {
                    strSQL.Append("  LEFT JOIN (                                    ");
                    #region # 評価単価-月次移動平均単価、最終仕入単価
                    strSQL.Append("  SELECT                                         ");
                    strSQL.Append("  WHS_CD,    ITEM_NO,     MA_PRC,    LAST_RCV_PRC");
                    strSQL.Append("  FROM MONTHLY_INV                               ");
                    strSQL.Append(" WHERE       YYMM    =   :PHYSICAL_CNT_YYMM               ");
                    if (_whs_cd != "")
                    {
                        strSQL.Append(" AND         WHS_CD  =   :WHS_CD         ");
                    }
                    #endregion
                    strSQL.Append("  ) P2   ON  PH.WHS_CD    = P2.WHS_CD             ");
                    strSQL.Append("         AND PH.ITEM_NO   = P2.ITEM_NO            ");
                }
                /*--------------2011/03/23 add end------------*/
                strSQL.Append("  WHERE   INV_WIP_TYPE=0                                                                                           ");
                strSQL.Append("  AND   INV_TYPE=0 AND PHYSICAL_CNT_STATUS=30                                                                    ");
                strSQL.Append("  AND   (PH.PHYSICAL_CNT_QTY!=0 OR PH.DIFF_QTY!=0)                                                                 ");

                db.DbParametersClear();
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM =:PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH.WS_CD =:WS_CD");
                    db.DbPsetString("WS_CD", _ws_cd);
                }
                if (_process_cd != "")
                {
                    strSQL.Append(" AND PH.PROCESS_CD =:PROCESS_CD");
                    db.DbPsetString("PROCESS_CD", _process_cd);
                }
                strSQL.Append(" ORDER BY PH.LINE_NO                                                              ");
            }
            else
            {
                strSQL.Append(" FROM  PHISICAL_COUNT PH                                                                     ");
                strSQL.Append(" LEFT JOIN WORKSHOP_MASTER WS ON WS.WS_CD=PH.WS_CD                                           ");
                strSQL.Append(" LEFT JOIN PROCESS_MASTER PRO ON PRO.PROCESS_CD=PH.PROCESS_CD                                ");
                strSQL.Append(" LEFT JOIN SYSTEM_PARAMETER S ON S.KEY01='ITEM_DESC' AND S.KEY02=PH.ITEM_UMSR                ");
                strSQL.Append(" LEFT JOIN ITEM_MASTER  I     ON I.ITEM_NO=PH.ITEM_NO                                        ");
                /*--------------2011/03/23 add begin------------*/
                if (prc_type == 0)//評価単価=「標準単価」の場合
                {
                    strSQL.Append("  LEFT JOIN (                                ");
                    #region # 評価単価-標準単価
                    strSQL.Append("  SELECT                                             ");
                    strSQL.Append("  ITEM_NO,          STD_PRC,         CURRENCY        ");
                    strSQL.Append("  FROM STD_PRICE_MASTER                              ");
                    strSQL.Append(" WHERE       BEG_EFF_DATE   <=   @PHYSICAL_CNT_YYMM           ");
                    strSQL.Append(" AND         END_EFF_DATE   >=   @PHYSICAL_CNT_YYMM           ");
                    #endregion
                    strSQL.Append("  ) P1   ON PH.ITEM_NO = P1.ITEM_NO           ");
                }
                else//評価単価=「最終仕入単価」と「月次移動平均単価」の場合
                {
                    strSQL.Append("  LEFT JOIN (                                    ");
                    #region # 評価単価-月次移動平均単価、最終仕入単価
                    strSQL.Append("  SELECT                                         ");
                    strSQL.Append("  WHS_CD,    ITEM_NO,     MA_PRC,    LAST_RCV_PRC");
                    strSQL.Append("  FROM MONTHLY_INV                               ");
                    strSQL.Append(" WHERE       YYMM    =   @PHYSICAL_CNT_YYMM               ");
                    if (_whs_cd != "")
                    {
                        strSQL.Append(" AND         WHS_CD  =   @WHS_CD         ");
                    }
                    #endregion
                    strSQL.Append("  ) P2   ON  PH.WHS_CD    = P2.WHS_CD             ");
                    strSQL.Append("         AND PH.ITEM_NO   = P2.ITEM_NO            ");
                }
                /*--------------2011/03/23 add end------------*/
                strSQL.Append(" WHERE PH.INV_WIP_TYPE=1 AND PH.INV_TYPE=0                                                   ");
                strSQL.Append(" AND   PH.PHYSICAL_CNT_STATUS=30                                                             ");
                strSQL.Append(" AND   (PH.PHYSICAL_CNT_QTY!=0 OR PH.DIFF_QTY!=0)                                              ");

                db.DbParametersClear();
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM =@PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH.WS_CD =@WS_CD");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                if (_process_cd != "")
                {
                    strSQL.Append(" AND PH.PROCESS_CD =@PROCESS_CD");
                    db.DbPsetString("@PROCESS_CD", _process_cd);
                }
                strSQL.Append(" ORDER BY PH.LINE_NO                                                              ");
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
        /// 仕掛棚卸在庫更新
        /// 
        /// 使用画面：WipStockTakingUpd
        /// </summary>
        public DataSet Get_WipUpdCount()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //sql
            strSQL.Append("  SELECT PH.WS_CD,       WS.WS_DESC,          PH.PROCESS_CD,                                 ");
            strSQL.Append("  PRO.PROCESS_DESC ,     ISNULL(COUNT(*),0) AS ITEM_QTY,                                     ");
            strSQL.Append("  ISNULL(A.NOTIPUT,0) AS NOTIPUT, ISNULL(B.DIFFNUM ,0) AS DIFFNUM,                           ");
            strSQL.Append("  ISNULL( C.UPNUM ,0) AS UPNUM                                                               ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM  PHISICAL_COUNT  PH  ,  WORKSHOP_MASTER WS  ,  PROCESS_MASTER  PRO,                ");
                strSQL.Append(" (SELECT COUNT(*) AS NOTIPUT                                                             ");
                strSQL.Append(" FROM  PHISICAL_COUNT                                                                    ");
                strSQL.Append(" WHERE INV_WIP_TYPE=1 AND INV_TYPE=0                                                     ");
                strSQL.Append(" AND PHYSICAL_CNT_STATUS=0                                                               ");
                strSQL.Append(" AND PHYSICAL_CNT_YYMM=:PHYSICAL_CNT_YYMM                                                ");
                strSQL.Append(" AND WS_CD=:WS_CD                           ) A  ,                                       ");
                strSQL.Append(" (SELECT COUNT(*) AS NOTIPUT                                                             ");
                strSQL.Append(" FROM  PHISICAL_COUNT                                                                    ");
                strSQL.Append(" WHERE INV_WIP_TYPE=1 AND INV_TYPE=0                                                     ");
                strSQL.Append(" AND PHYSICAL_CNT_STATUS <>0                                                             ");
                strSQL.Append(" AND PHYSICAL_CNT_YYMM=:PHYSICAL_CNT_YYMM                                                ");
                strSQL.Append(" AND WS_CD=:WS_CD                           ) B  ,                                       ");
                strSQL.Append(" (SELECT COUNT(*) AS NOTIPUT                                                             ");
                strSQL.Append(" FROM  PHISICAL_COUNT                                                                    ");
                strSQL.Append(" WHERE INV_WIP_TYPE=1 AND INV_TYPE=0                                                     ");
                strSQL.Append(" AND PHYSICAL_CNT_STATUS =30                                                             ");
                strSQL.Append(" AND PHYSICAL_CNT_YYMM=:PHYSICAL_CNT_YYMM                                                ");
                strSQL.Append(" AND WS_CD=:WS_CD                           ) C                                          ");
                strSQL.Append(" WHERE INV_WIP_TYPE=1 AND INV_TYPE=0                                                     ");
                strSQL.Append(" AND    PH.WS_CD=WS.WS_CD(+)                                                             ");
                strSQL.Append(" AND    PH.PROCESS_CD=PRO.PROCESS_CD(+)                                                  ");
                strSQL.Append(" AND    PHYSICAL_CNT_YYMM=:PHYSICAL_CNT_YYMM                                             ");
                strSQL.Append(" AND    WS_CD=:WS_CD                                                                     ");
                strSQL.Append(" GROUP BY PH.WS_CD ,WS.WS_DESC  , PH.PROCESS_CD ,PRO.PROCESS_DESC,                       ");
                strSQL.Append(" A.NOTIPUT  ,  B.DIFFNUM ,     C.UPNUM                                                   ");

                db.DbParametersClear();
                if (_physical_cnt_yymm != 0.0)
                {
                    strSQL.Append(" AND PC.PHYSICAL_CNT_YYMM =:PHYSICAL_CNT_YYMM");
                    db.DbPsetDouble("PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                }
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PC.WHS_CD =:WS_CD");
                    db.DbPsetString("WS_CD", _ws_cd);
                }

                strSQL.Append(" GROUP BY PH.WS_CD ,WS.WS_DESC  , PH.PROCESS_CD ,PRO.PROCESS_DESC,                       ");
                strSQL.Append(" A.NOTIPUT  ,  B.DIFFNUM ,     C.UPNUM                                                   ");

            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM  PHISICAL_COUNT  PH                                                                ");
                strSQL.Append(" LEFT JOIN  WORKSHOP_MASTER WS  ON PH.WS_CD=WS.WS_CD                                     ");
                strSQL.Append(" LEFT JOIN  PROCESS_MASTER  PRO ON PH.PROCESS_CD=PRO.PROCESS_CD                          ");
                strSQL.Append(" LEFT JOIN (SELECT COUNT(*) AS NOTIPUT ,PH1.WS_CD                                        ");
                strSQL.Append(" FROM  PHISICAL_COUNT     PH1                                                            ");
                strSQL.Append(" WHERE PH1.PHYSICAL_CNT_STATUS=0                                                         ");
                strSQL.Append(" AND PH1.INV_WIP_TYPE=1 AND PH1.INV_TYPE=0                                               ");
                strSQL.Append(" AND PH1.PHYSICAL_CNT_YYMM=@PHYSICAL_CNT_YYMM                                            ");
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH1.WS_CD=@WS_CD                                                                ");
                }
                strSQL.Append(" GROUP BY PH1.WS_CD                                                                      ");
                strSQL.Append("  ) A  ON A.WS_CD=PH.WS_CD                                                               ");
                strSQL.Append(" LEFT JOIN (SELECT COUNT(*) AS DIFFNUM , PH2.WS_CD                                       ");
                strSQL.Append(" FROM  PHISICAL_COUNT   PH2                                                              ");
                strSQL.Append(" WHERE PH2.DIFF_QTY <>0                                                                  ");
                strSQL.Append(" AND PH2.INV_WIP_TYPE=1 AND PH2.INV_TYPE=0                                               ");
                strSQL.Append(" AND PH2.PHYSICAL_CNT_YYMM=@PHYSICAL_CNT_YYMM                                            ");
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH2.WS_CD=@WS_CD                                                                ");
                }
                strSQL.Append(" GROUP BY   PH2.WS_CD                                                                    ");
                strSQL.Append(" ) B  ON B.WS_CD=PH.WS_CD                                                                ");
                strSQL.Append(" LEFT JOIN (SELECT COUNT(*) AS UPNUM ,PH3.WS_CD                                          ");
                strSQL.Append(" FROM  PHISICAL_COUNT PH3                                                                ");
                strSQL.Append(" WHERE                                                                                   ");
                strSQL.Append(" PH3.PHYSICAL_CNT_STATUS=30                                                              ");
                strSQL.Append(" AND PH3.INV_WIP_TYPE=1 AND PH3.INV_TYPE=0                                               ");
                strSQL.Append(" AND PH3.PHYSICAL_CNT_YYMM =@PHYSICAL_CNT_YYMM                                           ");
                db.DbParametersClear();
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH3.WS_CD=@WS_CD                                                                ");
                }
                strSQL.Append(" GROUP BY PH3.WS_CD                                                                      ");
                strSQL.Append(" ) C ON C.WS_CD=PH.WS_CD                                                                 ");
                strSQL.Append(" WHERE PH.INV_WIP_TYPE=1 AND PH.INV_TYPE=0                                               ");
                strSQL.Append(" AND PH.PHYSICAL_CNT_YYMM =@PHYSICAL_CNT_YYMM                                            ");
                if (_ws_cd != "")
                {
                    strSQL.Append(" AND PH.WS_CD=@WS_CD                                                                 ");
                    db.DbPsetString("@WS_CD", _ws_cd);
                }
                db.DbPsetDouble("@PHYSICAL_CNT_YYMM", _physical_cnt_yymm);
                strSQL.Append(" GROUP BY PH.WS_CD ,WS.WS_DESC  , PH.PROCESS_CD ,PRO.PROCESS_DESC,                       ");
                strSQL.Append(" NOTIPUT  ,  DIFFNUM ,     UPNUM                                                         ");

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
        /// 仕掛棚卸在庫更新
        /// 
        /// 使用画面：WipStockTakingUpd
        /// </summary>
        public int WipUpd()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetDouble("@I_PHYSICAL_CNT_YYMM", _physical_cnt_yymm, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);

            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_WIPSTOCKTAKING_UPD");
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
