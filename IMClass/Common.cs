using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;

namespace IMClass
{
    public class Common
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Common()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Common(string p_user_id, int p_lang)
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
        //number
        protected string _ctr_cd = "";
        protected string _ctr_sub_cd = "";
        protected string _ctr_prefix = "";
        protected int _ctr_digit = 1;
        protected string _out_num = "";
        protected string _chg_pgm = "";
        protected string _chg_user_id = "";
        protected int _update_cntr = 0;
        protected int _last_ctr = 0;
        //calander
        protected string _calendar_id = "";
        protected int _date1 = 0;
        protected int _date2 = 0;
        protected int _i_wkdays = 0;
        protected int _request_id = 0;
        protected int _date = 0;
        protected int _o_wkdays = 0;
        protected int _holiday_flag = 0;
        protected int _po_rls_flag = 0;
        protected double _std_working_hour = 0;

        protected string _whs_cd = "";
        protected string _item_no = "";
        protected int _sch_disb_date = 0;
        protected string _joc_cd = "";
        protected int _request_no = 0;
        protected string _order_no = "";
        protected string _sch_id = "";
        protected string _ws_cd = "";

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

        public string ctr_cd { get { return _ctr_cd; } set { _ctr_cd = value; } }
        public string ctr_sub_cd { get { return _ctr_sub_cd; } set { _ctr_sub_cd = value; } }
        public string ctr_prefix { get { return _ctr_prefix; } set { _ctr_prefix = value; } }
        public string out_num { get { return _out_num; } set { _out_num = value; } }
        public int ctr_digit { get { return _ctr_digit; } set { _ctr_digit = value; } }
        public int last_ctr { get { return _last_ctr; } set { _last_ctr = value; } }
  
        public string calendar_id { get { return _calendar_id; } set { _calendar_id = value; } }
        /// <summary>
        /// 指定日付


        /// </summary>
        public int date1 { get { return _date1; } set { _date1 = value; } }
        /// <summary>
        /// 指定日付間の稼働日数を編集


        /// </summary>
        public int date2 { get { return _date2; } set { _date2 = value; } }
        /// <summary>
        /// 指定日付からｎ日稼働日前/後の日付を編集


        /// </summary>
        public int i_wkdays { get { return _i_wkdays; } set { _i_wkdays = value; } }
        /// <summary>
        /// <para>1) 指定日付からｎ日稼働日後の日付を編集								
        ///	IN: I_DATE1, I_WKDAYS     OUT: O_DATE		</para>					
        ///	<para>2) 指定日付からｎ日稼働日前の日付を編集									
        ///	IN: I_DATE1, I_WKDAYS     OUT: O_DATE	</para>						
        ///<para>3) 指定日付間の稼働日数を編集											
        ///IN: I_DATE1, I_DATE2      OUT: O_WKDAYS	</para>							
        ///<para>4) 指定日の情報を編集													
        ///IN: I_DATE1    OUT: O_HOLIDAY_FLAG, O_PO_RLS_FLAG, O_STD_WORKING_HOUR </para>
        ///<para>5) 月の稼働日数数を編集(暦日指定)										
        ///IN: I_DATE1	   OUT: O_WKDAYS		</para>	
        /// </summary>
        public int request_id { get { return _request_id; } set { _request_id = value; } }
        public int date { get { return _date; } set { _date = value; } }
        public int o_wkdays { get { return _o_wkdays; } set { _o_wkdays = value; } }
        public int holiday_flag { get { return _holiday_flag; } set { _holiday_flag = value; } }
        public int po_rls_flag { get { return _po_rls_flag; } set { _po_rls_flag = value; } }
        public double std_working_hour { get { return _std_working_hour; } set { _std_working_hour = value; } }

        public string whs_cd { get { return _whs_cd; } set { _whs_cd = value; } }
        public string item_no { get { return _item_no; } set { _item_no = value; } }
        public int sch_disb_date { get { return _sch_disb_date; } set { _sch_disb_date = value; } }
        public string  joc_cd { get { return _joc_cd; } set { _joc_cd = value; } }
        public int request_no { get { return _request_no; } set { _request_no = value; } }
        public string order_no { get { return _order_no; } set { _order_no = value; } }
        public string sch_id { get { return _sch_id; } set { _sch_id = value; } }
        public string ws_cd { get { return _ws_cd; } set { _ws_cd = value; } }
       
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }
        #endregion

        /// <summary>
        /// <para>自動採番の取得

        /// </para>	
        /// 使用画面：OrdSOEntry
        /// </summary>
        public int GET_AUTO_NUM()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_CTR_CD", _ctr_cd, ComConst.DB_IN);
            db.DbPsetString("@I_CTR_SUB_CD", _ctr_sub_cd, ComConst.DB_IN);
            db.DbPsetString("@I_CTR_PREFIX", _ctr_prefix, ComConst.DB_IN);
            db.DbPsetInt("@I_CTR_DIGIT", _ctr_digit, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetString("@O_NUMBER", _out_num, ComConst.DB_OUT);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_NUMBERING");
            rtn = db.DbPgetInt("RET");

            if (rtn == ComConst.SUCCEED)
            {
                _out_num = db.DbPgetString("@O_NUMBER");
                db.DbCommit();  // Hoshina
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                db.DbRollback();  // Hoshina

                rtn = ComConst.FAILED;
            }
            return rtn;
        }

        /// <summary>
        /// <para>自動採番の戻し
        /// </para>	
        /// 使用画面：OrdSOEntry
        /// </summary>
        public int GET_AUTO_NUM_RVS()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_CTR_CD", _ctr_cd, ComConst.DB_IN);
            db.DbPsetString("@I_CTR_SUB_CD", _ctr_sub_cd, ComConst.DB_IN);
            db.DbPsetString("@I_CTR_PREFIX", _ctr_prefix, ComConst.DB_IN);
            db.DbPsetInt("@I_LAST_CTR", _last_ctr, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_NUMBERING_RVS");
            rtn = db.DbPgetInt("RET");

            if (rtn == ComConst.SUCCEED)
            {
                db.DbCommit();  // Hoshina
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                db.DbRollback();  // Hoshina

                rtn = ComConst.FAILED;
            }
            return rtn;
        }
        
        /// <summary>
        /// DateCheck
        /// <para>1) 指定日付からｎ日稼働日後の日付を編集									
        /// IN: I_DATE1, I_WKDAYS     OUT: O_DATE	</para>								
        /// 																		
        /// <para>2) 指定日付からｎ日稼働日前の日付を編集									
        /// IN: I_DATE1, I_WKDAYS     OUT: O_DATE</para>									
        /// 																		
        /// <para>3) 指定日付間の稼働日数を編集											
        /// IN: I_DATE1, I_DATE2      OUT: O_WKDAYS	</para>								
        /// 																		
        /// <para>4) 指定日の情報を編集													
        /// IN: I_DATE1    OUT: O_HOLIDAY_FLAG, O_PO_RLS_FLAG, O_STD_WORKING_HOUR</para>	
        /// 																		
        /// <para>5) 月の稼働日数数を編集(暦日指定)										
        /// IN: I_DATE1	   OUT: O_WKDAYS	</para>										
        /// 使用画面：OrdSOEntry
        /// </summary>
        public int Get_Date()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_CALENDAR_ID", _calendar_id, ComConst.DB_IN);
            db.DbPsetInt("@I_DATE1", _date1, ComConst.DB_IN);
            db.DbPsetInt("@I_DATE2", _date2, ComConst.DB_IN);
            db.DbPsetInt("@I_WKDAYS", _i_wkdays, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@I_REQUEST_ID", _request_id, ComConst.DB_IN);
            db.DbPsetInt("@O_DATE", _date, ComConst.DB_OUT);
            db.DbPsetInt("@O_WKDAYS", _o_wkdays, ComConst.DB_OUT);
            db.DbPsetInt("@O_HOLIDAY_FLAG", _holiday_flag, ComConst.DB_OUT);
            db.DbPsetInt("@O_PO_RLS_FLAG", _po_rls_flag, ComConst.DB_OUT);
            db.DbPsetDouble("@O_STD_WORKING_HOUR", _std_working_hour, ComConst.DB_OUT);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans(); // Hoshina
            rtn = db.DbStored("SP_CALENDAR_CHECK");
            rtn = db.DbPgetInt("RET");

            if (rtn == ComConst.SUCCEED)
            {
                _date = db.DbPgetInt("@O_DATE");
                _o_wkdays = db.DbPgetInt("@O_WKDAYS");
                _holiday_flag = db.DbPgetInt("@O_HOLIDAY_FLAG");
                _po_rls_flag = db.DbPgetInt("@O_PO_RLS_FLAG");
                _std_working_hour = db.DbPgetInt("@O_STD_WORKING_HOUR");
                db.DbCommit();  // Hoshina
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                db.DbRollback();  // Hoshina

                rtn = ComConst.FAILED;
            }
            return rtn;
        }
        /// <summary>
        /// 在庫引当、引当解除処理

        /// 
        /// 使用画面：InvShortInq
        /// </summary>
        public int Item_Disb_Alloc(ComDB db)
        {
            //ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_SCH_ID", _sch_id, ComConst.DB_IN);
            db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
            db.DbPsetString("@I_WHS_CD", _whs_cd, ComConst.DB_IN);
            db.DbPsetString("@I_ITEM_NO", _item_no, ComConst.DB_IN);
            db.DbPsetInt("@I_SCH_DISB_DATE", _sch_disb_date, ComConst.DB_IN);
            db.DbPsetString("@I_JOC_CD", _joc_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_REQUEST_NO", _request_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_ITEM_DISB_ALLOC");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED || rtn == 10 )
            {
                //db.DbCommit();
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                //db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }
        /// <summary>
        /// 在庫引当処理

        /// 
        /// 使用画面：InvShortInq
        /// </summary>
        public int Disb_Alloc(ComDB db)
        {
            //ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ORDER_NO", _order_no, ComConst.DB_IN);           
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_DISB_ALLOC");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                //db.DbCommit();
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                //db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }
        public int Disb_Alloc()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ORDER_NO", _order_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
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
        /// 在庫引当解除処理

        /// 
        /// 使用画面：InvShortInq
        /// </summary>
        public int Disb_UnAlloc(ComDB db)
        {
            //ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ORDER_NO", _order_no, ComConst.DB_IN);      
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            //db.DbBeginTrans();  // IMV3
            rtn = db.DbStored("SP_DISB_UNALLOC");
            rtn = db.DbPgetInt("RET");
            if (rtn == ComConst.SUCCEED)
            {
                //db.DbCommit();
            }
            else
            {
                _errcode = db.DbPgetInt("@O_ERRCODE");
                _errmsg = db.DbPgetString("@O_MSG");
                _sqlcode = db.DbPgetInt("@O_SQLCODE");
                _dbmsg = db.DbPgetString("@O_SQLMSG");
                _proc_name = db.DbPgetString("@O_PROC_NAME");
                _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                //db.DbRollback();
                rtn = ComConst.FAILED;
            }

            return rtn;
        }
        public int Disb_UnAlloc()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_ORDER_NO", _order_no, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_PGM", _chg_pgm, ComConst.DB_IN);
            db.DbPsetString("@I_CHG_USER_ID", _chg_user_id, ComConst.DB_IN);
            db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
            db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
            db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
            db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
            db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
            db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

            db.DbBeginTrans();
            rtn = db.DbStored("SP_DISB_UNALLOC");
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

        public string GetBackMenuGrp(string program_id, int lvl)
        {
            IM_Menu menu = new IM_Menu();

            menu.program_id = program_id;
            menu.lvl = lvl;

            int rtn = menu.GetBackMenuGrp();

            if (rtn == ComConst.SUCCEED)
            {
                return menu.back_menu_grp;
            }
            else
            {
                return "";
            }
        }

        //Add 2013.09.02 Ubiq-Sai Begin
        public int GetBackMenuGrpLvl(string program_id, string user_id)
        {
            IM_Menu menu = new IM_Menu();

            menu.program_id = program_id;
            menu.user_id = user_id;

            int rtn = menu.GetBackMenuGrpLvl();

            if (rtn == ComConst.SUCCEED)
            {
                return menu.glvl;
            }
            else
            {
                return 0;
            }
        }
        //Add 2013.09.02 Ubiq-Sai End

    }
}
