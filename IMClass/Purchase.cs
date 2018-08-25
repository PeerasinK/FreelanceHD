using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

namespace IMClass
{
    public class Purchase
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Purchase()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Purchase(string p_user_id, int p_lang)
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
        protected int _pty_no = -1;
        protected int _beg_eff_date = 0;
        protected int _end_eff_date = 0;
        protected string _vendor_cd = "";
        protected int _supply_type = 0;
        protected string _buyer_cd = "";
        protected string _vendor_name = "";//ADD 20090210
        protected string _vendor_item_no = "";
        protected string _vendor_item_desc = "";
        protected string _pur_umsr = "";
        protected double _umsr_conv_ratio = 0.0;
        protected double _min_pur_qty = 0;
        protected double _pur_lot_size = 0;
        protected int _delv_lt_type = 0;
        protected double _std_lot_size = 0;
        protected double _delv_lt_proportion = 0;
        protected double _delv_lt = 0.0;
        protected double _transfer_lt = 0.0;
        protected double _insp_lt = 0.0;
        protected string _insp_cd = "";
        protected int _insp_freq = 0;
        protected int _recv_cnt = 0;
        protected string _item_desc = "";
        protected string _vendor_desc = "";
        protected string _buyer_desc = "";
        protected string _insp_desc = "";
        protected int _idtag_print_flag = 0;
        protected double _idtag_unit_qty = 0;

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
        //ADD by liu
        protected int _min_pur_qty_i = 0;
        protected int _min_pur_qty_p = 0;
        protected int _pur_lot_size_i;
        protected int _pur_lot_size_p;
        protected int _wip_type = 0;

        protected string _umsr_name=""; //ADD BY UBIQ-SUO 2011/3/10

        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        public int lang { get { return _lang; } set { _lang = value; } }
        public string item_no { get { return _item_no; } set { _item_no = value; } }
        public int pty_no { get { return _pty_no; } set { _pty_no = value; } }
        public int beg_eff_date { get { return _beg_eff_date; } set { _beg_eff_date = value; } }
        public int end_eff_date { get { return _end_eff_date; } set { _end_eff_date = value; } }
        public string vendor_cd { get { return _vendor_cd; } set { _vendor_cd = value; } }
        public int supply_type { get { return _supply_type; } set { _supply_type = value; } }
        public string buyer_cd { get { return _buyer_cd; } set { _buyer_cd = value; } }
        public string vendor_name { get { return _vendor_name; } set { _vendor_name = value; } }
        public string vendor_item_no { get { return _vendor_item_no; } set { _vendor_item_no = value; } }
        public string vendor_item_desc { get { return _vendor_item_desc; } set { _vendor_item_desc = value; } }
        public string pur_umsr { get { return _pur_umsr; } set { _pur_umsr = value; } }
        public double umsr_conv_ratio { get { return _umsr_conv_ratio; } set { _umsr_conv_ratio = value; } }
        public double min_pur_qty { get { return _min_pur_qty; } set { _min_pur_qty = value; } }
        public double pur_lot_size { get { return _pur_lot_size; } set { _pur_lot_size = value; } }
        public int delv_lt_type { get { return _delv_lt_type; } set { _delv_lt_type = value; } }
        public double std_lot_size { get { return _std_lot_size; } set { _std_lot_size = value; } }
        public double delv_lt_proportion { get { return _delv_lt_proportion; } set { _delv_lt_proportion = value; } }
        public double delv_lt { get { return _delv_lt; } set { _delv_lt = value; } }
        public double transfer_lt { get { return _transfer_lt; } set { _transfer_lt = value; } }
        public double insp_lt { get { return _insp_lt; } set { _insp_lt = value; } }
        public string insp_cd { get { return _insp_cd; } set { _insp_cd = value; } }
        public int insp_freq { get { return _insp_freq; } set { _insp_freq = value; } }
        public int recv_cnt { get { return _recv_cnt; } set { _recv_cnt = value; } }
        public string item_desc { get { return _item_desc; } set { _item_desc = value; } }
        public string vendor_desc { get { return _vendor_desc; } set { _vendor_desc = value; } }
        public string buyer_desc { get { return _buyer_desc; } set { _buyer_desc = value; } }
        public string insp_desc { get { return _insp_desc; } set { _insp_desc = value; } }
        public double idtag_unit_qty { get { return _idtag_unit_qty; } set { _idtag_unit_qty = value; } }
        public int idtag_print_flag { get { return _idtag_print_flag; } set { _idtag_print_flag = value; } }

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
        public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
        public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }
        //ADD BY LIU
        public int min_pur_qty_i { get { return _min_pur_qty_i; } set { _min_pur_qty_i = value; } }
        public int min_pur_qty_p { get { return _min_pur_qty_p; } set { _min_pur_qty_p = value; } }
        public int pur_lot_size_i { get { return _pur_lot_size_i; } set { _pur_lot_size_i = value; } }
        public int pur_lot_size_p { get { return _pur_lot_size_p; } set { _pur_lot_size_p = value; } }
        public int wip_type { get { return _wip_type; } set { _wip_type = value; } }

        //ADD BY UBIQ-SUO 2011/3/10
        public string umsr_name { get { return _umsr_name; } set { _umsr_name = value; } }
        #endregion

        /// <summary>
        /// 購買マスタメンテ詳細の取得

        /// 
        /// 使用画面：MstPurchaseMnt
        /// </summary>
        public int GetPurchaseDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT                                                                                                ");
            strSQL.Append("P.ITEM_NO					,P.PTY_NO					,P.BEG_EFF_DATE	  ,	                         ");
            strSQL.Append("P.END_EFF_DATE				,P.VENDOR_CD				,P.SUPPLY_TYPE	,                            ");
            strSQL.Append("P.BUYER_CD					,P.VENDOR_ITEM_NO			,P.VENDOR_ITEM_DESC,	                     ");
            strSQL.Append("P.PUR_UMSR					,P.UMSR_CONV_RATIO			,P.MIN_PUR_QTY	,                            ");
            strSQL.Append("P.PUR_LOT_SIZE				,P.DELV_LT_TYPE				,P.STD_LOT_SIZE	,                            ");
            strSQL.Append("P.DELV_LT_PROPORTION			,P.DELV_LT				    ,P.TRANSFER_LT	,	                         ");
            strSQL.Append("P.INSP_LT					,P.INSP_CD				    ,P.INSP_FREQ	,	                         ");
            strSQL.Append("P.RECV_CNT                   ,P.IDTAG_UNIT_QTY           ,P.IDTAG_PRINT_FLAG,                         ");
            strSQL.Append("P.DATA_CHAR1     ,P.DATA_CHAR2       ,P.DATA_CHAR3       ,P.DATA_CHAR4       ,P.DATA_CHAR5,           ");
            strSQL.Append("P.DATA_CHAR6     ,P.DATA_CHAR7       ,P.DATA_CHAR8       ,P.DATA_CHAR9       ,P.DATA_CHAR10,          ");
            strSQL.Append("P.DATA_NUM1		,P.DATA_NUM2		,P.DATA_NUM3		,P.DATA_NUM4		,P.DATA_NUM5,			 ");
            strSQL.Append("P.DATA_NUM6		,P.DATA_NUM7		,P.DATA_NUM8		,P.DATA_NUM9		,P.DATA_NUM10,			 ");
            strSQL.Append("P.DATA_FLAG1		,P.DATA_FLAG2		,P.DATA_FLAG3		,P.DATA_FLAG4		,P.DATA_FLAG5,			 ");
            strSQL.Append("P.DATA_FLAG6		,P.DATA_FLAG7		,P.DATA_FLAG8		,P.DATA_FLAG9		,P.DATA_FLAG10,			 ");
            strSQL.Append("P.ENTRY_DATE     ,P.CHG_DATE         ,P.CHG_PGM		    ,P.CHG_USERID	    ,P.UPDATE_CNTR,	         ");
            strSQL.Append("I.ITEM_DESC AS  ITEM_DESC   ,        V.VENDOR_NAME AS VENDOR_NAME,  	  	                             ");
            strSQL.Append("  S.DATA_CHAR  AS INSP_DESC  ,       S1.DATA_CHAR AS	BUYER_DESC  ,P.VENDOR_NAME 	AS VENDOR_NAME1,      ");
            strSQL.Append("  U1.DATA_CHAR AS UMSR_NAME      ");    // IMV3
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PURCHASE_MASTER P, ITEM_MASTER I,VENDOR_MASTER V, SYSTEM_PARAMETER S ,SYSTEM_PARAMETER S1  ");
                strSQL.Append(" WHERE                                                                                           ");
                strSQL.Append("  P.ITEM_NO               = I.ITEM_NO(+)                                                         ");
                strSQL.Append(" AND P.VENDOR_CD          = V.VENDOR_CD(+)                                                       ");
                strSQL.Append(" AND S.KEY01              = 'INSP_CD'                                                            ");
                strSQL.Append(" AND P.INSP_CD            = S.KEY02(+)                                                           ");
                strSQL.Append(" AND S1.KEY01             = 'BUYER_CD'                                                           ");
                strSQL.Append(" AND S1.KEY02             = P.BUYER_CD                                                           ");

                db.DbParametersClear();
                if (_item_no != "")
                {
                    strSQL.Append(" AND P.ITEM_NO = :ITEM_NO        ");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_pty_no != 0.0)
                {
                    strSQL.Append(" AND P.PTY_NO = :PTY_NO        ");
                    db.DbPsetInt("PTY_NO", _pty_no);
                }
                if (_beg_eff_date != 0)
                {
                    strSQL.Append(" AND P.BEG_EFF_DATE = :BEG_EFF_DATE        ");
                    db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append(" AND P.VENDOR_CD = :VENDOR_CD        ");
                    db.DbPsetString("VENDOR_CD", _vendor_cd);
                }

            }
            else
            {
                strSQL.Append(" FROM PURCHASE_MASTER P                                      ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON P.ITEM_NO = I.ITEM_NO      ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD = V.VENDOR_CD");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01= 'INSP_CD'    ");
                strSQL.Append(" AND S.KEY02        =       P.INSP_CD                        ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01= 'BUYER_CD' ");
                strSQL.Append(" AND S1.KEY02        =       P.BUYER_CD                      ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER U1 ON U1.KEY01= 'ITEM_UMSR' ");    // IMV3
                strSQL.Append(" AND U1.KEY02        =       P.PUR_UMSR                      ");
                strSQL.Append(" WHERE  1=1                                                  ");

                db.DbParametersClear();
                if (_item_no != "")
                {
                    strSQL.Append(" AND P.ITEM_NO = @ITEM_NO        ");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_pty_no >= 0)
                {
                    strSQL.Append(" AND P.PTY_NO = @PTY_NO        ");
                    db.DbPsetInt("@PTY_NO", _pty_no);
                }
                if (_beg_eff_date >= 0)
                {
                    strSQL.Append(" AND P.BEG_EFF_DATE = @BEG_EFF_DATE        ");
                    db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                }
                if (_vendor_cd != "")
                {
                    strSQL.Append(" AND P.VENDOR_CD = @VENDOR_CD        ");
                    db.DbPsetString("@VENDOR_CD", _vendor_cd);
                }

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
                _pty_no = int.Parse(db.Row("PTY_NO"));
                _beg_eff_date = int.Parse(db.Row("BEG_EFF_DATE"));
                _end_eff_date = int.Parse(db.Row("END_EFF_DATE"));
                _vendor_cd = db.Row("VENDOR_CD");
                _supply_type = int.Parse(db.Row("SUPPLY_TYPE"));
                _buyer_cd = db.Row("BUYER_CD");
                _vendor_name = db.Row("VENDOR_NAME1");
                _vendor_item_no = db.Row("VENDOR_ITEM_NO");
                _vendor_item_desc = db.Row("VENDOR_ITEM_DESC");
                _pur_umsr = db.Row("PUR_UMSR");
                _umsr_conv_ratio = double.Parse(db.Row("UMSR_CONV_RATIO"));
                _min_pur_qty = double.Parse(db.Row("MIN_PUR_QTY"));
                _pur_lot_size = double.Parse(db.Row("PUR_LOT_SIZE"));
                _delv_lt_type = int.Parse(db.Row("DELV_LT_TYPE"));
                _std_lot_size = double.Parse(db.Row("STD_LOT_SIZE"));
                _delv_lt_proportion = double.Parse(db.Row("DELV_LT_PROPORTION"));
                _delv_lt = double.Parse(db.Row("DELV_LT"));
                _transfer_lt = double.Parse(db.Row("TRANSFER_LT"));
                _insp_lt = double.Parse(db.Row("INSP_LT")); ;
                _insp_cd = db.Row("INSP_CD");
                _insp_freq = int.Parse(db.Row("INSP_FREQ"));
                _recv_cnt = int.Parse(db.Row("RECV_CNT"));
                _vendor_desc = db.Row("VENDOR_NAME");
                _item_desc = db.Row("ITEM_DESC");
                _insp_desc = db.Row("INSP_DESC");
                _buyer_desc = db.Row("BUYER_DESC");
                _idtag_unit_qty = double.Parse(db.Row("IDTAG_UNIT_QTY"));
                _idtag_print_flag = int.Parse(db.Row("IDTAG_PRINT_FLAG"));
                _data_char1 = db.Row("DATA_CHAR1");
                _data_char2 = db.Row("DATA_CHAR2");
                _data_char3 = db.Row("DATA_CHAR3");
                _data_char4 = db.Row("DATA_CHAR4");
                _data_char5 = db.Row("DATA_CHAR5");
                _data_char6 = db.Row("DATA_CHAR6");
                _data_char7 = db.Row("DATA_CHAR7");
                _data_char8 = db.Row("DATA_CHAR8");
                _data_char9 = db.Row("DATA_CHAR9");
                _data_char10 = db.Row("DATA_CHAR10");
                _data_num1 = double.Parse(db.Row("DATA_NUM1"));
                _data_num2 = double.Parse(db.Row("DATA_NUM2"));
                _data_num3 = double.Parse(db.Row("DATA_NUM3"));
                _data_num4 = double.Parse(db.Row("DATA_NUM4"));
                _data_num5 = double.Parse(db.Row("DATA_NUM5"));
                _data_num6 = double.Parse(db.Row("DATA_NUM6"));
                _data_num7 = double.Parse(db.Row("DATA_NUM7"));
                _data_num8 = double.Parse(db.Row("DATA_NUM8"));
                _data_num9 = double.Parse(db.Row("DATA_NUM9"));
                _data_num10 = double.Parse(db.Row("DATA_NUM10"));
                _data_flag1 = int.Parse(db.Row("DATA_FLAG1"));
                _data_flag2 = int.Parse(db.Row("DATA_FLAG2"));
                _data_flag3 = int.Parse(db.Row("DATA_FLAG3"));
                _data_flag4 = int.Parse(db.Row("DATA_FLAG4"));
                _data_flag5 = int.Parse(db.Row("DATA_FLAG5"));
                _data_flag6 = int.Parse(db.Row("DATA_FLAG6"));
                _data_flag7 = int.Parse(db.Row("DATA_FLAG7"));
                _data_flag8 = int.Parse(db.Row("DATA_FLAG8"));
                _data_flag9 = int.Parse(db.Row("DATA_FLAG9"));
                _data_flag10 = int.Parse(db.Row("DATA_FLAG10"));
                _umsr_name = db.Row("UMSR_NAME"); //IMV3

                _entry_date = DateTime.Parse(db.Row("ENTRY_DATE"));
                _chg_date = DateTime.Parse(db.Row("CHG_DATE"));
                _chg_pgm = db.Row("CHG_PGM");
                _chg_user_id = db.Row("CHG_USERID");
                _update_cntr = int.Parse(db.Row("UPDATE_CNTR"));
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;

        }

        /// <summary>
        /// 購買マスタメンテ一覧の取得

        /// 
        /// 使用画面：MstPurchaseMnt
        /// </summary>
        public DataSet GetPurchaseList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                                                   ");
            strSQL.Append("P.ITEM_NO					,P.PTY_NO					,P.BEG_EFF_DATE	  ,	                            ");
            strSQL.Append("P.END_EFF_DATE				,P.VENDOR_CD				,P.SUPPLY_TYPE	,                               ");
            strSQL.Append("P.BUYER_CD					,P.VENDOR_ITEM_NO			,P.VENDOR_ITEM_DESC,	                        ");
            strSQL.Append("P.PUR_UMSR					,P.UMSR_CONV_RATIO			,P.MIN_PUR_QTY	,                               ");
            strSQL.Append("P.PUR_LOT_SIZE				,P.DELV_LT_TYPE				,P.STD_LOT_SIZE	,                               ");
            strSQL.Append("P.DELV_LT_PROPORTION			,P.DELV_LT				    ,P.TRANSFER_LT	,	                            ");
            strSQL.Append("P.INSP_LT					,P.INSP_CD				    ,P.INSP_FREQ	,	                            ");
            strSQL.Append("P.RECV_CNT                   ,P.IDTAG_UNIT_QTY           ,P.IDTAG_PRINT_FLAG,                            ");
            strSQL.Append("P.DATA_CHAR1     ,P.DATA_CHAR2       ,P.DATA_CHAR3       ,P.DATA_CHAR4       ,P.DATA_CHAR5,              ");
            strSQL.Append("P.DATA_CHAR6     ,P.DATA_CHAR7       ,P.DATA_CHAR8       ,P.DATA_CHAR9       ,P.DATA_CHAR10 ,            ");
            strSQL.Append("P.DATA_NUM1		,P.DATA_NUM2		,P.DATA_NUM3		,P.DATA_NUM4		,P.DATA_NUM5,			    ");
            strSQL.Append("P.DATA_NUM6		,P.DATA_NUM7		,P.DATA_NUM8		,P.DATA_NUM9		,P.DATA_NUM10,			    ");
            strSQL.Append("P.DATA_FLAG1		,P.DATA_FLAG2		,P.DATA_FLAG3		,P.DATA_FLAG4		,P.DATA_FLAG5,			    ");
            strSQL.Append("P.DATA_FLAG6		,P.DATA_FLAG7		,P.DATA_FLAG8		,P.DATA_FLAG9		,P.DATA_FLAG10,			    ");
            strSQL.Append("P.ENTRY_DATE     ,P.CHG_DATE         ,P.CHG_PGM		    ,P.CHG_USERID	    ,P.UPDATE_CNTR	,           ");
            strSQL.Append("I.ITEM_DESC AS  ITEM_DESC   ,    V.VENDOR_NAME AS VENDOR_NAME,  	  	                                    ");
            strSQL.Append("  S.DATA_CHAR  AS INSP_DESC  	,P.VENDOR_NAME 	AS VENDOR_NAME1   	                                    ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PURCHASE_MASTER P, ITEM_MASTER I,VENDOR_MASTER V, SYSTEM_PARAMETER S   ");
                strSQL.Append(" WHERE P.ITEM_NO            = I.ITEM_NO(+)                                   ");
                strSQL.Append("   AND P.VENDOR_CD          = V.VENDOR_CD(+)                                 ");
                strSQL.Append("   AND S.KEY01              = 'INSP_CD'                                      ");
                strSQL.Append("   AND P.INSP_CD            = S.KEY02(+)                                     ");

                db.DbParametersClear();
                if (_item_no != "")
                {
                    strSQL.Append(" AND P.ITEM_NO =:ITEM_NO");
                    db.DbPsetString("ITEM_NO", _item_no);
                }
                if (_pty_no != 0)
                {
                    strSQL.Append("   AND P.PTY_NO = :PTY_NO");
                    db.DbPsetInt(" PTY_NO", _pty_no);
                }
                if (_beg_eff_date != 0)
                {
                    strSQL.Append("   AND P.BEG_EFF_DATE = :BEG_EFF_DATE");
                    db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                }

            }
            else
            {
                strSQL.Append(" FROM PURCHASE_MASTER P                                                      ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON P.ITEM_NO = I.ITEM_NO                      ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD = V.VENDOR_CD                ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01= 'INSP_CD'                    ");
                strSQL.Append(" AND S.KEY02        =       P.INSP_CD                                        ");
                strSQL.Append(" WHERE 1=1                                                                   ");

                db.DbParametersClear();
                if (_item_no != "")
                {
                    strSQL.Append(" AND P.ITEM_NO = @ITEM_NO");
                    db.DbPsetString("@ITEM_NO", _item_no);
                }
                if (_pty_no > 0)
                {
                    strSQL.Append("   AND P.PTY_NO = @PTY_NO");
                    db.DbPsetInt("@PTY_NO", _pty_no);
                }
                if (_beg_eff_date != 0)
                {
                    strSQL.Append("   AND P.BEG_EFF_DATE = @BEG_EFF_DATE");
                    db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
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
        /// 購買マスタメンテの変更
        /// 
        /// 使用画面：MstPurchaseMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();
            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PTY_NO", pty_no, ComConst.DB_IN);
            db.DbPsetInt("@I_BEG_EFF_DATE", _beg_eff_date, ComConst.DB_IN);
            db.DbPsetInt("@I_END_EFF_DATE", _end_eff_date, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_SUPPLY_TYPE", _supply_type, ComConst.DB_IN);
            db.DbPsetString("@I_BUYER_CD", _buyer_cd, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_NAME", _vendor_name, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_ITEM_NO", _vendor_item_no, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_ITEM_DESC", _vendor_item_desc, ComConst.DB_IN);
            db.DbPsetString("@I_PUR_UMSR", _pur_umsr, ComConst.DB_IN);
            db.DbPsetDouble("@I_UMSR_CONV_RATIO", _umsr_conv_ratio, ComConst.DB_IN);
            db.DbPsetDouble("@I_MIN_PUR_QTY", _min_pur_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_PUR_LOT_SIZE", _pur_lot_size, ComConst.DB_IN);
            db.DbPsetInt("@I_DELV_LT_TYPE", _delv_lt_type, ComConst.DB_IN);
            db.DbPsetDouble("@I_STD_LOT_SIZE", _std_lot_size, ComConst.DB_IN);
            db.DbPsetDouble("@I_DELV_LT_PROPORTION", _delv_lt_proportion, ComConst.DB_IN);
            db.DbPsetDouble("@I_DELV_LT", _delv_lt, ComConst.DB_IN);
            db.DbPsetDouble("@I_TRANSFER_LT", _transfer_lt, ComConst.DB_IN);
            db.DbPsetDouble("@I_INSP_LT", _insp_lt, ComConst.DB_IN);
            db.DbPsetString("@I_INSP_CD", _insp_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_INSP_FREQ", _insp_freq, ComConst.DB_IN);
            db.DbPsetInt("@I_RECV_CNT", _recv_cnt, ComConst.DB_IN);
            db.DbPsetDouble("@I_IDTAG_UNIT_QTY", _idtag_unit_qty, ComConst.DB_IN);
            db.DbPsetInt("@I_IDTAG_PRINT_FLAG", _idtag_print_flag, ComConst.DB_IN);

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
            rtn = db.DbStored("SP_PURCHASE_UPDATE");
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
        /// 購買マスタメンテの追加
        /// 
        /// 使用画面：MstPurchaseMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PTY_NO", pty_no, ComConst.DB_IN);
            db.DbPsetInt("@I_BEG_EFF_DATE", _beg_eff_date, ComConst.DB_IN);
            db.DbPsetInt("@I_END_EFF_DATE", _end_eff_date, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_SUPPLY_TYPE", _supply_type, ComConst.DB_IN);
            db.DbPsetString("@I_BUYER_CD", _buyer_cd, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_NAME", _vendor_name, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_ITEM_NO", _vendor_item_no, ComConst.DB_IN);
            db.DbPsetString("@I_VENDOR_ITEM_DESC", _vendor_item_desc, ComConst.DB_IN);
            db.DbPsetString("@I_PUR_UMSR", _pur_umsr, ComConst.DB_IN);
            db.DbPsetDouble("@I_UMSR_CONV_RATIO", _umsr_conv_ratio, ComConst.DB_IN);
            db.DbPsetDouble("@I_MIN_PUR_QTY", _min_pur_qty, ComConst.DB_IN);
            db.DbPsetDouble("@I_PUR_LOT_SIZE", _pur_lot_size, ComConst.DB_IN);
            db.DbPsetInt("@I_DELV_LT_TYPE", _delv_lt_type, ComConst.DB_IN);
            db.DbPsetDouble("@I_STD_LOT_SIZE", _std_lot_size, ComConst.DB_IN);
            db.DbPsetDouble("@I_DELV_LT_PROPORTION", _delv_lt_proportion, ComConst.DB_IN);
            db.DbPsetDouble("@I_DELV_LT", _delv_lt, ComConst.DB_IN);
            db.DbPsetDouble("@I_TRANSFER_LT", _transfer_lt, ComConst.DB_IN);
            db.DbPsetDouble("@I_INSP_LT", _insp_lt, ComConst.DB_IN);
            db.DbPsetString("@I_INSP_CD", _insp_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_INSP_FREQ", _insp_freq, ComConst.DB_IN);
            db.DbPsetInt("@I_RECV_CNT", _recv_cnt, ComConst.DB_IN);
            db.DbPsetDouble("@I_IDTAG_UNIT_QTY", _idtag_unit_qty, ComConst.DB_IN);
            db.DbPsetInt("@I_IDTAG_PRINT_FLAG", _idtag_print_flag, ComConst.DB_IN);

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
            rtn = db.DbStored("SP_PURCHASE_INSERT");
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
        /// 購買マスタメンテの削除
        /// 
        /// 使用画面：MstPurchaseMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetInt("@I_PTY_NO", _pty_no, ComConst.DB_IN);
            db.DbPsetInt("@I_BEG_EFF_DATE", _beg_eff_date, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_PURCHASE_DELETE");
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
        /// 購買マスタメンテ

        /// 
        /// 使用画面：MstItemseMnt
        /// </summary>
        public DataSet GetPurchaseList_Item()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("P.ITEM_NO					,P.PTY_NO					,P.BEG_EFF_DATE	  ,	                            ");
            strSQL.Append("P.END_EFF_DATE				,P.VENDOR_CD				,P.SUPPLY_TYPE	,                               ");
            strSQL.Append("P.BUYER_CD					,P.VENDOR_ITEM_NO			,P.VENDOR_ITEM_DESC,	                        ");
            strSQL.Append("P.PUR_UMSR					,P.UMSR_CONV_RATIO			,P.MIN_PUR_QTY	,                               ");
            strSQL.Append("P.PUR_LOT_SIZE				,P.DELV_LT_TYPE				,P.STD_LOT_SIZE	,                               ");
            strSQL.Append("P.DELV_LT_PROPORTION			,P.DELV_LT				    ,P.TRANSFER_LT	,	                            ");
            strSQL.Append("P.INSP_LT					,P.INSP_CD				    ,P.INSP_FREQ	,	                            ");
            strSQL.Append("P.RECV_CNT                  ,P.VENDOR_NAME 	AS VENDOR_NAME1             ,                               ");
            strSQL.Append("P.DATA_CHAR1     ,P.DATA_CHAR2       ,P.DATA_CHAR3       ,P.DATA_CHAR4       ,P.DATA_CHAR5,              ");
            strSQL.Append("P.DATA_CHAR6     ,P.DATA_CHAR7       ,P.DATA_CHAR8       ,P.DATA_CHAR9       ,P.DATA_CHAR10 ,            ");
            strSQL.Append("P.DATA_NUM1		,P.DATA_NUM2		,P.DATA_NUM3		,P.DATA_NUM4		,P.DATA_NUM5,			    ");
            strSQL.Append("P.DATA_NUM6		,P.DATA_NUM7		,P.DATA_NUM8		,P.DATA_NUM9		,P.DATA_NUM10,			    ");
            strSQL.Append("P.DATA_FLAG1		,P.DATA_FLAG2		,P.DATA_FLAG3		,P.DATA_FLAG4		,P.DATA_FLAG5,			    ");
            strSQL.Append("P.DATA_FLAG6		,P.DATA_FLAG7		,P.DATA_FLAG8		,P.DATA_FLAG9		,P.DATA_FLAG10,			    ");
            strSQL.Append("P.ENTRY_DATE     ,P.CHG_DATE         ,P.CHG_PGM		    ,P.CHG_USERID	    ,P.UPDATE_CNTR	,           ");
            strSQL.Append("I.ITEM_DESC AS  ITEM_DESC   ,    V.VENDOR_NAME AS VENDOR_NAME,  S1.DATA_CHAR BUYER_DESC,	  	            ");
            strSQL.Append("  S.DATA_CHAR  AS INSP_DESC  	  	");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PURCHASE_MASTER P, ITEM_MASTER I,VENDOR_MASTER V, SYSTEM_PARAMETER S, ");
                strSQL.Append(" SYSTEM_PARAMETER S1                                                        ");
                strSQL.Append(" WHERE P.ITEM_NO            = :ITEM_NO                                      ");
                strSQL.Append("   AND P.ITEM_NO            = I.ITEM_NO(+)                                  ");
                strSQL.Append("   AND P.VENDOR_CD          = V.VENDOR_CD(+)                                ");
                strSQL.Append("   AND S.KEY01              = 'INSP_CD'                                     ");
                strSQL.Append("   AND P.INSP_CD            = S.KEY02(+)                                    ");
                strSQL.Append("   AND S1.KEY01             = 'BUYER_CD'                                    ");
                strSQL.Append("   AND S1.KEY02             = P.BUYER_CD                                    ");
                strSQL.Append("   AND P.BEG_EFF_DATE <=: @BEG_EFF_DATE                                     ");
                strSQL.Append("   AND P.END_EFF_DATE >=: @END_EFF_DATE                                     ");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("END_EFF_DATE", _end_eff_date);
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM PURCHASE_MASTER P ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON P.ITEM_NO = I.ITEM_NO");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD = V.VENDOR_CD");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01= 'INSP_CD'    ");
                strSQL.Append(" AND S.KEY02        =       P.INSP_CD                        ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01= 'BUYER_CD' ");
                strSQL.Append(" AND S1.KEY02        =       P.BUYER_CD                      ");
                strSQL.Append(" WHERE P.ITEM_NO = @ITEM_NO");
                if (_beg_eff_date != 0)
                {
                    strSQL.Append(" AND P.BEG_EFF_DATE <= @BEG_EFF_DATE");
                    db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                }
                if (_end_eff_date != 0)
                {
                    strSQL.Append(" AND P.END_EFF_DATE >= @END_EFF_DATE");
                    db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
                }
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
        /// 発注ロット、納入L/Tの取得

        ///        
        /// 使用画面：MrpSchInvInq
        /// </summary>
        public int GetPurAndItemDetail()//ADD BY LIU 2008.11.10
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();

            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT                                                               ");
            strSQL.Append("I.MIN_PUR_QTY    MIN_PUR_QTY_I,      P.MIN_PUR_QTY  MIN_PUR_QTY_P  ,	");
            strSQL.Append("P.PUR_LOT_SIZE   PUR_LOT_SIZE_P,     I.PUR_LOT_SIZE PUR_LOT_SIZE_I , ");
            strSQL.Append("P.DELV_LT_TYPE,  P.STD_LOT_SIZE,     P.DELV_LT_PROPORTION,	        ");
            strSQL.Append("P.DELV_LT,       I.WIP_TYPE                                          ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PURCHASE_MASTER P, ITEM_MASTER I                           ");
                strSQL.Append(" WHERE P.ITEM_NO            = :ITEM_NO                           ");
                strSQL.Append("   AND P.BEG_EFF_DATE       <= :BEG_EFF_DATE                     ");
                strSQL.Append("   AND P.END_EFF_DATE       >= :END_EFF_DATE                     ");
                strSQL.Append("   AND P.PTY_NO       = (SELECT Min(pty_no) from PURCHASE_MASTER ");
                strSQL.Append(" WHERE ITEM_NO            = :ITEM_NO                             ");
                strSQL.Append("   AND BEG_EFF_DATE       <= :BEG_EFF_DATE                       ");
                strSQL.Append("   AND END_EFF_DATE       >= :BEG_EFF_DATE )                     ");
                strSQL.Append("   AND ITEM_NO             = I.ITEM_NO(+)                        ");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("END_EFF_DATE", _end_eff_date);
            }
            else
            {
                strSQL.Append(" FROM PURCHASE_MASTER P                                          ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON P.ITEM_NO = I.ITEM_NO          ");
                strSQL.Append(" WHERE P.ITEM_NO = @ITEM_NO                                      ");
                strSQL.Append("   AND P.BEG_EFF_DATE       <= @BEG_EFF_DATE                     ");
                strSQL.Append("   AND P.END_EFF_DATE       >= @END_EFF_DATE                     ");
                strSQL.Append("   AND P.PTY_NO  = (SELECT Min(pty_no) from PURCHASE_MASTER      ");
                strSQL.Append(" WHERE ITEM_NO            = @ITEM_NO                             ");
                strSQL.Append("   AND BEG_EFF_DATE       <= @BEG_EFF_DATE                       ");
                strSQL.Append("   AND END_EFF_DATE       >= @BEG_EFF_DATE )                     ");

                db.DbParametersClear();
                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _min_pur_qty_i = int.Parse(db.Row("MIN_PUR_QTY_I"));
                _min_pur_qty_p = int.Parse(db.Row("MIN_PUR_QTY_P"));
                _pur_lot_size_i = int.Parse(db.Row("PUR_LOT_SIZE_I"));
                _pur_lot_size_p = int.Parse(db.Row("PUR_LOT_SIZE_P"));
                _delv_lt_type = int.Parse(db.Row("DELV_LT_TYPE"));
                _std_lot_size = int.Parse(db.Row("STD_LOT_SIZE"));
                _delv_lt_proportion = int.Parse(db.Row("DELV_LT_PROPORTION"));
                _delv_lt = double.Parse(db.Row("DELV_LT"));
                _wip_type = int.Parse(db.Row("WIP_TYPE"));
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// 仕入先名称の取得

        ///        
        /// 使用画面：PurPoRlse
        /// </summary>
        public DataSet GetVendorDesc()//ADD BY CHEN 2008.11.14
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append(" DISTINCT V.VENDOR_DESC,V.VENDOR_CD	");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PURCHASE_MASTER P, VENDOR_MASTER V                           ");
                strSQL.Append(" WHERE P.ITEM_NO            = :ITEM_NO                           ");
                strSQL.Append("   AND P.VENDOR_CD = V.VENDOR_CD                      ");
                strSQL.Append("   AND P.BEG_EFF_DATE       <= CONVERT(varchar(8), GETDATE(), 112) ");
                strSQL.Append("   AND P.END_EFF_DATE       >= CONVERT(varchar(8), GETDATE(), 112) ");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);
            }
            else
            {

                strSQL.Append(" FROM PURCHASE_MASTER P ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON P.VENDOR_CD = V.VENDOR_CD ");
                strSQL.Append(" WHERE P.ITEM_NO            = @ITEM_NO                           ");
                strSQL.Append("   AND P.BEG_EFF_DATE       <= CONVERT(varchar(8), GETDATE(), 112) ");
                strSQL.Append("   AND P.END_EFF_DATE       >= CONVERT(varchar(8), GETDATE(), 112) ");

                db.DbParametersClear();
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
        /// 品目作业场所の取得

        ///        
        /// 使用画面：MstPurchaseMnt
        /// </summary>
        public int GetPurchaseList_ItemWS()//ADD BY ZHAO 2009/1/12
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();

            int rtn = 0;

            strSQL.Append(" SELECT *                                                               ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ITEM_WS_MASTER WS,WORKSHOP_MASTER WR                          ");
                strSQL.Append(" WHERE                                                              ");
                strSQL.Append("    WS.WS_CD= WR.WS_CD(+)                                           ");
                strSQL.Append("    AND  WS.ITEM_NO=:ITEM_NO                                        ");
                strSQL.Append("    AND  WR.SC_FLAG=1                                               ");
                strSQL.Append("    AND  WS.PTY_NO=:PTY_NO                                          ");
                strSQL.Append("    AND  WS.BEG_EFF_DATE<=:BEG_EFF_DATE                             ");
                strSQL.Append("    AND  WS.END_EFF_DATE>=:BEG_EFF_DATE                             ");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetDouble("PTY_NO", _pty_no);
                db.DbPsetDouble("BEG_EFF_DATE", _beg_eff_date);

            }
            else
            {
                strSQL.Append(" FROM ITEM_WS_MASTER WS                                              ");
                strSQL.Append(" INNER JOIN WORKSHOP_MASTER WR ON  WS.WS_CD= WR.WS_CD                ");
                strSQL.Append(" WHERE WS.ITEM_NO = @ITEM_NO                                         ");
                strSQL.Append(" AND  WR.SC_FLAG=1                                                   ");
                strSQL.Append(" AND  WS.PTY_NO=@PTY_NO                                              ");
                strSQL.Append("    AND  WS.BEG_EFF_DATE <=@BEG_EFF_DATE                             ");
                strSQL.Append("    AND  WS.END_EFF_DATE >=@BEG_EFF_DATE                             ");

                db.DbParametersClear();
                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetDouble("@PTY_NO", _pty_no);
                db.DbPsetDouble("@BEG_EFF_DATE", _beg_eff_date);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;

        }

        /// <summary>
        /// メーカー詳細の取得

        /// 
        /// 使用画面：PurManPORlse
        /// </summary>
        /// <returns></returns>
        public int GetPurchaseVendor()//ADD by 20090210 UBIQ-LIU
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT                                                                                                ");
            strSQL.Append("P.ITEM_NO					,P.PTY_NO					,P.BEG_EFF_DATE	  ,	                         ");
            strSQL.Append("P.END_EFF_DATE				,P.VENDOR_CD				,P.SUPPLY_TYPE	,                            ");
            strSQL.Append("P.BUYER_CD					,P.VENDOR_ITEM_NO			,P.VENDOR_ITEM_DESC,	                     ");
            strSQL.Append("P.PUR_UMSR					,P.UMSR_CONV_RATIO			,P.MIN_PUR_QTY	,                            ");
            strSQL.Append("P.PUR_LOT_SIZE				,P.DELV_LT_TYPE				,P.STD_LOT_SIZE	,                            ");
            strSQL.Append("P.DELV_LT_PROPORTION			,P.DELV_LT				    ,P.TRANSFER_LT	,	                         ");
            strSQL.Append("P.INSP_LT					,P.INSP_CD				    ,P.INSP_FREQ	,	                         ");
            strSQL.Append("P.RECV_CNT                   ,P.VENDOR_NAME 	AS VENDOR_NAME1             ,                                                                      ");
            strSQL.Append("P.DATA_CHAR1     ,P.DATA_CHAR2       ,P.DATA_CHAR3       ,P.DATA_CHAR4       ,P.DATA_CHAR5,           ");
            strSQL.Append("P.DATA_CHAR6     ,P.DATA_CHAR7       ,P.DATA_CHAR8       ,P.DATA_CHAR9       ,P.DATA_CHAR10,          ");
            strSQL.Append("P.DATA_NUM1		,P.DATA_NUM2		,P.DATA_NUM3		,P.DATA_NUM4		,P.DATA_NUM5,			 ");
            strSQL.Append("P.DATA_NUM6		,P.DATA_NUM7		,P.DATA_NUM8		,P.DATA_NUM9		,P.DATA_NUM10,			 ");
            strSQL.Append("P.DATA_FLAG1		,P.DATA_FLAG2		,P.DATA_FLAG3		,P.DATA_FLAG4		,P.DATA_FLAG5,			 ");
            strSQL.Append("P.DATA_FLAG6		,P.DATA_FLAG7		,P.DATA_FLAG8		,P.DATA_FLAG9		,P.DATA_FLAG10,			 ");
            strSQL.Append("I.ITEM_DESC,      P.VENDOR_NAME,	                                                                     ");
            strSQL.Append("  S.DATA_CHAR  AS INSP_DESC  ,       S1.DATA_CHAR AS	BUYER_DESC  	                                 ");
            strSQL.Append("  ,S3.DATA_CHAR UMSR_NAME                                                ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PURCHASE_MASTER P, ITEM_MASTER I,VENDOR_MASTER V, SYSTEM_PARAMETER S ,SYSTEM_PARAMETER S1  ");
                strSQL.Append(" WHERE                                                                                           ");
                strSQL.Append("  P.ITEM_NO               = I.ITEM_NO(+)                                                         ");
                strSQL.Append(" AND S.KEY01              = 'INSP_CD'                                                            ");
                strSQL.Append(" AND P.INSP_CD            = S.KEY02(+)                                                           ");
                strSQL.Append(" AND S1.KEY01             = 'BUYER_CD'                                                           ");
                strSQL.Append(" AND S1.KEY02             = P.BUYER_CD                                                           ");

                db.DbParametersClear();
                strSQL.Append(" AND P.ITEM_NO = :ITEM_NO                                        ");
                strSQL.Append(" AND P.PTY_NO = (SELECT MIN(PTY_NO) FROM PURCHASE_MASTER         ");
                strSQL.Append(" WHERE  ITEM_NO = :ITEM_NO AND BEG_EFF_DATE <= :BEG_EFF_DATE     ");
                strSQL.Append(" AND END_EFF_DATE >= :BEG_EFF_DATE AND VENDOR_CD = :VENDOR_CD)   ");
                strSQL.Append(" AND P.BEG_EFF_DATE <= :BEG_EFF_DATE                             ");
                strSQL.Append(" AND P.END_EFF_DATE >= :BEG_EFF_DATE                             ");
                strSQL.Append(" AND P.VENDOR_CD = :VENDOR_CD                                    ");

                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetString("ITEM_NO", _item_no);
                db.DbPsetString("VENDOR_CD", _vendor_cd);

            }
            else
            {
                strSQL.Append(" FROM PURCHASE_MASTER P                                          ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON P.ITEM_NO = I.ITEM_NO          ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S ON S.KEY01= 'INSP_CD'        ");
                strSQL.Append(" AND S.KEY02        =       P.INSP_CD                            ");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01= 'BUYER_CD'     ");
                strSQL.Append(" AND S1.KEY02        =       P.BUYER_CD                          ");

                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S3 ON  S3.KEY01  = 'ITEM_UMSR' ");
                strSQL.Append("  AND    S3.KEY02            = P.PUR_UMSR                     ");

                strSQL.Append(" WHERE  P.ITEM_NO    = @ITEM_NO                                  ");
                strSQL.Append(" AND P.PTY_NO = (SELECT MIN(PTY_NO) FROM PURCHASE_MASTER         ");
                strSQL.Append(" WHERE  ITEM_NO = @ITEM_NO AND BEG_EFF_DATE <= @BEG_EFF_DATE     ");
                strSQL.Append(" AND END_EFF_DATE >= @BEG_EFF_DATE AND VENDOR_CD = @VENDOR_CD)   ");
                strSQL.Append(" AND P.BEG_EFF_DATE <= @BEG_EFF_DATE                             ");
                strSQL.Append(" AND P.END_EFF_DATE >= @BEG_EFF_DATE                             ");
                strSQL.Append(" AND P.VENDOR_CD = @VENDOR_CD                                    ");

                db.DbPsetString("@ITEM_NO", _item_no);
                db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetString("@VENDOR_CD", _vendor_cd);
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
                _pty_no = int.Parse(db.Row("PTY_NO"));
                _beg_eff_date = int.Parse(db.Row("BEG_EFF_DATE"));
                _end_eff_date = int.Parse(db.Row("END_EFF_DATE"));
                _vendor_cd = db.Row("VENDOR_CD");
                _supply_type = int.Parse(db.Row("SUPPLY_TYPE"));
                _buyer_cd = db.Row("BUYER_CD");
                _vendor_name = db.Row("VENDOR_NAME");
                _vendor_item_no = db.Row("VENDOR_ITEM_NO");
                _vendor_item_desc = db.Row("VENDOR_ITEM_DESC");
                _pur_umsr = db.Row("PUR_UMSR");
                _umsr_conv_ratio = double.Parse(db.Row("UMSR_CONV_RATIO"));
                _min_pur_qty = double.Parse(db.Row("MIN_PUR_QTY"));
                _pur_lot_size = double.Parse(db.Row("PUR_LOT_SIZE"));
                _delv_lt_type = int.Parse(db.Row("DELV_LT_TYPE"));
                _std_lot_size = double.Parse(db.Row("STD_LOT_SIZE"));
                _delv_lt_proportion = double.Parse(db.Row("DELV_LT_PROPORTION"));
                _delv_lt = double.Parse(db.Row("DELV_LT"));
                _transfer_lt = double.Parse(db.Row("TRANSFER_LT"));
                _insp_lt = double.Parse(db.Row("INSP_LT")); ;
                _insp_cd = db.Row("INSP_CD");
                _insp_freq = int.Parse(db.Row("INSP_FREQ"));
                _recv_cnt = int.Parse(db.Row("RECV_CNT"));
                _item_desc = db.Row("ITEM_DESC");
                _insp_desc = db.Row("INSP_DESC");
                _buyer_desc = db.Row("BUYER_DESC");

                _umsr_name = db.Row("UMSR_NAME"); //ADD BY UBIQ-SUO 2011/3/10

                _data_char1 = db.Row("DATA_CHAR1");
                _data_char2 = db.Row("DATA_CHAR2");
                _data_char3 = db.Row("DATA_CHAR3");
                _data_char4 = db.Row("DATA_CHAR4");
                _data_char5 = db.Row("DATA_CHAR5");
                _data_char6 = db.Row("DATA_CHAR6");
                _data_char7 = db.Row("DATA_CHAR7");
                _data_char8 = db.Row("DATA_CHAR8");
                _data_char9 = db.Row("DATA_CHAR9");
                _data_char10 = db.Row("DATA_CHAR10");
                _data_num1 = double.Parse(db.Row("DATA_NUM1"));
                _data_num2 = double.Parse(db.Row("DATA_NUM2"));
                _data_num3 = double.Parse(db.Row("DATA_NUM3"));
                _data_num4 = double.Parse(db.Row("DATA_NUM4"));
                _data_num5 = double.Parse(db.Row("DATA_NUM5"));
                _data_num6 = double.Parse(db.Row("DATA_NUM6"));
                _data_num7 = double.Parse(db.Row("DATA_NUM7"));
                _data_num8 = double.Parse(db.Row("DATA_NUM8"));
                _data_num9 = double.Parse(db.Row("DATA_NUM9"));
                _data_num10 = double.Parse(db.Row("DATA_NUM10"));
                _data_flag1 = int.Parse(db.Row("DATA_FLAG1"));
                _data_flag2 = int.Parse(db.Row("DATA_FLAG2"));
                _data_flag3 = int.Parse(db.Row("DATA_FLAG3"));
                _data_flag4 = int.Parse(db.Row("DATA_FLAG4"));
                _data_flag5 = int.Parse(db.Row("DATA_FLAG5"));
                _data_flag6 = int.Parse(db.Row("DATA_FLAG6"));
                _data_flag7 = int.Parse(db.Row("DATA_FLAG7"));
                _data_flag8 = int.Parse(db.Row("DATA_FLAG8"));
                _data_flag9 = int.Parse(db.Row("DATA_FLAG9"));
                _data_flag10 = int.Parse(db.Row("DATA_FLAG10"));
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;

        }
        /// <summary>
        /// SNPの変更
        /// </summary>
        public int UpdateSNP()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("UPDATE PURCHASE_MASTER               ");
            strSQL.Append(" SET                              ");
            strSQL.Append(" IDTAG_UNIT_QTY = @IDTAG_UNIT_QTY           ");
            strSQL.Append(" WHERE ITEM_NO = @ITEM_NO    ");
            strSQL.Append("   AND VENDOR_CD = @VENDOR_CD    ");

            db.DbParametersClear();

            db.DbPsetDouble("@IDTAG_UNIT_QTY", _idtag_unit_qty);
            db.DbPsetString("@ITEM_NO", _item_no);
            db.DbPsetString("@VENDOR_CD", _vendor_cd);

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
