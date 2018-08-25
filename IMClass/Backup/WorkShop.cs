using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// 作業区クラス
/// </summary>
namespace IMClass
{
	public class WorkShop
	{
		#region : コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public WorkShop()
		{
			try
			{
				_db_type = WebConfigurationManager.AppSettings["db_type"];
			}
			catch { }

		}
		public WorkShop(string p_user_id, int p_lang)
		{
			_chg_user_id = p_user_id;
			_lang = p_lang;
			try
			{
				_db_type = WebConfigurationManager.AppSettings["db_type"];
			}
			catch
			{ }
		}

		#endregion

		#region : フィールド
		/// <summary>
		/// フィールド
		/// </summary>
		protected string _db_type = "";
		protected int _lang = 1;
		protected string _ws_cd = "";
		protected string _ws_desc = "";
		protected string _ws_desc2 = "";
		protected string _rep_ws_cd = "";
		protected string _cost_center = "";
		protected int _sc_flag = 0;
		protected string _vendor_cd = "";
		protected int _input_flag = 0;
		protected int _lot_ctrl_flag = 0;
		protected int _neg_bal_flag = 0;
		protected int _front_end_flag = 0;
		protected int _compl_flag = 0;
		protected int _auto_disb_flag = 0;
		protected string _work_inst_type = "";
		protected string _compl_slip_pattern = "";
		protected string _rej_whs = "";//ADD BY UBIQ-LIU 2010/11/24
		protected string _rej_whs_desc = "";//ADD BY UBIQ-LIU 2010/11/24
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

		protected string _rep_ws_desc = "";
		protected string _vendor_name = "";
		protected string _cost_center_name = "";
		protected double _ws_prc = 0;
		protected int _sc_flag_input = 0;

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
		public string ws_cd { get { return _ws_cd; } set { _ws_cd = value; } }
		public string ws_desc { get { return _ws_desc; } set { _ws_desc = value; } }
		public string ws_desc2 { get { return _ws_desc2; } set { _ws_desc2 = value; } }
		public string rep_ws_cd { get { return _rep_ws_cd; } set { _rep_ws_cd = value; } }
		public string cost_center { get { return _cost_center; } set { _cost_center = value; } }
		public int sc_falg { get { return _sc_flag; } set { _sc_flag = value; } }
		public string vendor_cd { get { return _vendor_cd; } set { _vendor_cd = value; } }
		public int input_flag { get { return _input_flag; } set { _input_flag = value; } }
		public int lot_ctrl_flag { get { return _lot_ctrl_flag; } set { _lot_ctrl_flag = value; } }
		public int neg_bal_flag { get { return _neg_bal_flag; } set { _neg_bal_flag = value; } }
		public int front_end_flag { get { return _front_end_flag; } set { _front_end_flag = value; } }
		public int compl_flag { get { return _compl_flag; } set { _compl_flag = value; } }
		public int auto_disb_flag { get { return _auto_disb_flag; } set { _auto_disb_flag = value; } }
		public string work_inst_type { get { return _work_inst_type; } set { _work_inst_type = value; } }
		public string compl_slip_pattern { get { return _compl_slip_pattern; } set { _compl_slip_pattern = value; } }
		public string rej_whs { get { return _rej_whs; } set { _rej_whs = value; } }//ADD BY UBIQ-LIU 2010/11/24
		public string rej_whs_desc { get { return _rej_whs_desc; } set { _rej_whs_desc = value; } }//ADD BY UBIQ-LIU 2010/11/24
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

		public string rep_ws_desc { get { return _rep_ws_desc; } set { _rep_ws_desc = value; } }
		public string vendor_name { get { return _vendor_name; } set { _vendor_name = value; } }
		public string cost_center_name { get { return _cost_center_name; } set { _cost_center_name = value; } }
		public double ws_prc { get { return _ws_prc; } set { _ws_prc = value; } }
		public int sc_flag_input { get { return _sc_flag_input; } set { _sc_flag_input = value; } }

		public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
		public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
		public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
		public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
		public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
		public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
		public string strErr { get { return _strErr; } set { _strErr = value; } }
		#endregion

		/// <summary>
		/// 作業区の追加
		/// 
		/// 使用画面：MstWsMnt
		/// </summary>
		public int Insert()
		{
			ComDB db = new ComDB(_db_type);
			int rtn = 0;

			db.DbParametersClear();

			db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
			db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
			db.DbPsetString("@I_WS_DESC", _ws_desc, ComConst.DB_IN);
			db.DbPsetString("@I_WS_DESC2", _ws_desc2, ComConst.DB_IN);
			db.DbPsetString("@I_REP_WS_CD", _rep_ws_cd, ComConst.DB_IN);
			db.DbPsetString("@I_COST_CENTER", _cost_center, ComConst.DB_IN);
			db.DbPsetInt("@I_SC_FLAG", _sc_flag, ComConst.DB_IN);
			db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
			db.DbPsetInt("@I_INPUT_FLAG", _input_flag, ComConst.DB_IN);
			db.DbPsetInt("@I_LOT_CTRL_FLAG", _lot_ctrl_flag, ComConst.DB_IN);
			db.DbPsetInt("@I_NEG_BAL_FLAG", _neg_bal_flag, ComConst.DB_IN);
			db.DbPsetInt("@I_FRONT_END_FLAG", _front_end_flag, ComConst.DB_IN);
			db.DbPsetInt("@I_COMPL_FLAG", _compl_flag, ComConst.DB_IN);
			db.DbPsetInt("@I_AUTO_DISB_FLAG", _auto_disb_flag, ComConst.DB_IN);
			db.DbPsetDouble("@I_WS_PRC", _ws_prc, ComConst.DB_IN);
			db.DbPsetString("@I_WORK_INST_TYPE", _work_inst_type, ComConst.DB_IN);
			db.DbPsetString("@I_COMPL_SLIP_PATTERN", _compl_slip_pattern, ComConst.DB_IN);
			db.DbPsetString("@I_REJ_WHS", _rej_whs, ComConst.DB_IN);//ADD BY UBIQ-LIU 2010/11/24
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
			rtn = db.DbStored("SP_WORKSHOP_INSERT");
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
		/// 作業区の変更
		/// 
		/// 使用画面：MstWsMnt
		/// </summary> 
		public int Update()
		{
			ComDB db = new ComDB(_db_type);
			int rtn = 0;

			db.DbParametersClear();

			db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
			db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
			db.DbPsetString("@I_WS_DESC", _ws_desc, ComConst.DB_IN);
			db.DbPsetString("@I_WS_DESC2", _ws_desc2, ComConst.DB_IN);
			db.DbPsetString("@I_REP_WS_CD", _rep_ws_cd, ComConst.DB_IN);
			db.DbPsetString("@I_COST_CENTER", _cost_center, ComConst.DB_IN);
			db.DbPsetInt("@I_SC_FLAG", _sc_flag, ComConst.DB_IN);
			db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
			db.DbPsetInt("@I_INPUT_FLAG", _input_flag, ComConst.DB_IN);
			db.DbPsetInt("@I_LOT_CTRL_FLAG", _lot_ctrl_flag, ComConst.DB_IN);
			db.DbPsetInt("@I_NEG_BAL_FLAG", _neg_bal_flag, ComConst.DB_IN);
			db.DbPsetInt("@I_FRONT_END_FLAG", _front_end_flag, ComConst.DB_IN);
			db.DbPsetInt("@I_COMPL_FLAG", _compl_flag, ComConst.DB_IN);
			db.DbPsetInt("@I_AUTO_DISB_FLAG", _auto_disb_flag, ComConst.DB_IN);
			db.DbPsetDouble("@I_WS_PRC", _ws_prc, ComConst.DB_IN);
			db.DbPsetString("@I_WORK_INST_TYPE", _work_inst_type, ComConst.DB_IN);
			db.DbPsetString("@I_COMPL_SLIP_PATTERN", _compl_slip_pattern, ComConst.DB_IN);
			db.DbPsetString("@I_REJ_WHS", _rej_whs, ComConst.DB_IN);//ADD BY UBIQ-LIU 2010/11/24
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

			rtn = db.DbStored("SP_WORKSHOP_UPDATE");
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
		/// 作業区の削除
		/// 
		/// 使用画面：MstWsMnt
		/// </summary>
		public int Delete()
		{
			ComDB db = new ComDB(_db_type);
			int rtn = 0;

			db.DbParametersClear();

			db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
			db.DbPsetString("@I_WS_CD", _ws_cd, ComConst.DB_IN);
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
			rtn = db.DbStored("SP_WORKSHOP_DELETE");
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
		/// 作業区一覧の取得
		/// 
		/// 使用画面：MstWsMnt
		/// </summary>
		public DataSet GetWorkShopList()
		{
			ComDB db = new ComDB(_db_type);
			StringBuilder strSQL = new StringBuilder();
			DataSet ds = new DataSet();

			//--- sql
			strSQL.Append("SELECT ");
			strSQL.Append("WS_CD,				WS_DESC,			WS_DESC2,			REP_WS_CD,			");
			strSQL.Append("COST_CENTER,			SC_FLAG,			VENDOR_CD,		    INPUT_FLAG,	        REJ_WHS,		");//ADD UBIQ-LIU 2010/11/24 ADD[REJ_WHS]
			strSQL.Append("LOT_CTRL_FLAG,	    NEG_BAL_FLAG,		FRONT_END_FLAG,		COMPL_FLAG,		    WS_PRC,         ");
			strSQL.Append("AUTO_DISB_FLAG,	    WORK_INST_TYPE,		COMPL_SLIP_PATTERN, DATA_CHAR1,			DATA_CHAR2,		");
			strSQL.Append("DATA_CHAR3,			DATA_CHAR4,			DATA_CHAR5,			DATA_CHAR6,			");
			strSQL.Append("DATA_CHAR7,			DATA_CHAR8,			DATA_CHAR9,			DATA_CHAR10,		");
			strSQL.Append("DATA_NUM1,			DATA_NUM2,			DATA_NUM3,			DATA_NUM4,			");
			strSQL.Append("DATA_NUM5,			DATA_NUM6,			DATA_NUM7,			DATA_NUM8,			");
			strSQL.Append("DATA_NUM9,			DATA_NUM10,			DATA_FLAG1,			DATA_FLAG2,			");
			strSQL.Append("DATA_FLAG3,			DATA_FLAG4,			DATA_FLAG5,			DATA_FLAG6,			");
			strSQL.Append("DATA_FLAG7,			DATA_FLAG8,			DATA_FLAG9,			DATA_FLAG10,		");
			strSQL.Append("ENTRY_DATE,			CHG_DATE,			CHG_PGM,			CHG_USERID,			");
			strSQL.Append("UPDATE_CNTR");

			db.DbParametersClear();
			if (_db_type == "ORACLE")
			{
				strSQL.Append(" FROM WORKSHOP_MASTER ");
				strSQL.Append(" WHERE 1=1          ");

				if (_sc_flag >= 0)
				{
					strSQL.Append("   AND SC_FLAG       =:SC_FLAG");
					db.DbPsetInt("SC_FLAG", _sc_flag);
				}
				strSQL.Append(" ORDER BY  WS_CD");

			}
			else
			{
				strSQL.Append(" FROM WORKSHOP_MASTER ");
				strSQL.Append(" WHERE 1=1          ");

				if (_sc_flag >= 0)
				{
					strSQL.Append("   AND SC_FLAG       =@SC_FLAG");
					db.DbPsetInt("@SC_FLAG", _sc_flag);
				}
				strSQL.Append(" ORDER BY  WS_CD");
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
		/// 作業区詳細の取得
		/// 
		/// 使用画面：MstWsMnt
		/// </summary>
		public int GetWorkShopDetail()
		{
			ComDB db = new ComDB(_db_type);
			StringBuilder strSQL = new StringBuilder();
			int rtn = 0;

			//--- sql
			strSQL.Append("SELECT                                                                                           ");
			strSQL.Append("W.WS_CD,			    W.WS_DESC,			W.WS_DESC2,			    W.REP_WS_CD,			        ");
			strSQL.Append("W.COST_CENTER,	    W.SC_FLAG,			W.VENDOR_CD,	        W.INPUT_FLAG,	                ");
			strSQL.Append("W.LOT_CTRL_FLAG,	    W.NEG_BAL_FLAG,		W.FRONT_END_FLAG,	    W.COMPL_FLAG,	                ");
			strSQL.Append("W.AUTO_DISB_FLAG,	W.WORK_INST_TYPE,   W.COMPL_SLIP_PATTERN,	W.DATA_CHAR1,	W.DATA_CHAR2,   ");
			strSQL.Append("W.DATA_CHAR3,		W.DATA_CHAR4,		W.DATA_CHAR5,		    W.DATA_CHAR6,			        ");
			strSQL.Append("W.DATA_CHAR7,		W.DATA_CHAR8,		W.DATA_CHAR9,		    W.DATA_CHAR10,  		        ");
			strSQL.Append("W.DATA_NUM1,			W.DATA_NUM2,		W.DATA_NUM3,		    W.DATA_NUM4,			        ");
			strSQL.Append("W.DATA_NUM5,			W.DATA_NUM6,		W.DATA_NUM7,		    W.DATA_NUM8,			        ");
			strSQL.Append("W.DATA_NUM9,			W.DATA_NUM10,		W.DATA_FLAG1,		    W.DATA_FLAG2,			        ");
			strSQL.Append("W.DATA_FLAG3,		W.DATA_FLAG4,		W.DATA_FLAG5,		    W.DATA_FLAG6,			        ");
			strSQL.Append("W.DATA_FLAG7,		W.DATA_FLAG8,		W.DATA_FLAG9,		    W.DATA_FLAG10,	    	        ");
			strSQL.Append("W.ENTRY_DATE,		W.CHG_DATE,			W.CHG_PGM,			    W.CHG_USERID,			        ");
			strSQL.Append("W.UPDATE_CNTR,       W.WS_PRC,			W.REJ_WHS,				WH.WHS_DESC REJ_WHS_DESC,		");//ADD UBIQ-LIU 2010/11/24 ADD[REJ_WHS]
            //strSQL.Append("W1.WS_DESC AS REP_WS_DESC,  D.DEPT_DESC1 AS COST_CENTER_NAME,        V.VENDOR_NAME				");
            strSQL.Append("W1.WS_DESC AS REP_WS_DESC,  '' AS COST_CENTER_NAME,        V.VENDOR_NAME				");   // IMV3 COMMENT OUT
            if (_db_type == "ORACLE")
			{
                //strSQL.Append(" FROM WORKSHOP_MASTER W, WORKSHOP_MASTER W1, DEPT_MASTER D,VENDOR_MASTER V ");
                strSQL.Append(" FROM WORKSHOP_MASTER W, WORKSHOP_MASTER W1, VENDOR_MASTER V ");   // IMV3 COMMENT OUT
                strSQL.Append(" WHERE W.WS_CD              = :WS_CD");
				strSQL.Append("   AND W.REP_WS_CD             = W1.WS_CD(+)");
				strSQL.Append("   W.COST_CENTER = D.DEPT_CD ");
				strSQL.Append("   AND W.VENDOR_CD           = V.VENDOR_CD(+)");

				db.DbParametersClear();
				db.DbPsetString("WS_CD", _ws_cd);
				if (_sc_flag_input == 1)
				{
					strSQL.Append("   AND W.SC_FLAG       =:SC_FLAG");
					db.DbPsetInt("SC_FLAG", _sc_flag);
				}
			}
			else
			{
				strSQL.Append(" FROM WORKSHOP_MASTER W ");
				strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER W1 ON W.REP_WS_CD = W1.WS_CD		");
                //strSQL.Append(" LEFT OUTER JOIN DEPT_MASTER D ON W.COST_CENTER = D.DEPT_CD			");  // IMV3 COMMENT OUT
				strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V ON W.VENDOR_CD = V.VENDOR_CD		");
				strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER WH ON W.REJ_WHS = WH.WHS_CD		");
				strSQL.Append(" WHERE W.WS_CD = @WS_CD");

				db.DbParametersClear();
				db.DbPsetString("@WS_CD", _ws_cd);
				if (_sc_flag_input == 1)
				{
					strSQL.Append("   AND W.SC_FLAG       =@SC_FLAG");
					db.DbPsetInt("@SC_FLAG", _sc_flag);
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
				_ws_cd = db.Row("WS_CD");
				_ws_desc = db.Row("WS_DESC");
				_ws_desc2 = db.Row("WS_DESC2");
				_rep_ws_cd = db.Row("REP_WS_CD");
				_cost_center = db.Row("COST_CENTER");
				_sc_flag = int.Parse(db.Row("SC_FLAG"));
				_vendor_cd = db.Row("VENDOR_CD");
				_input_flag = int.Parse(db.Row("INPUT_FLAG"));
				_lot_ctrl_flag = int.Parse(db.Row("LOT_CTRL_FLAG"));
				_neg_bal_flag = int.Parse(db.Row("NEG_BAL_FLAG"));
				_front_end_flag = int.Parse(db.Row("FRONT_END_FLAG"));
				_compl_flag = int.Parse(db.Row("COMPL_FLAG"));
				_auto_disb_flag = int.Parse(db.Row("AUTO_DISB_FLAG"));
				_work_inst_type = db.Row("WORK_INST_TYPE");
				_compl_slip_pattern = db.Row("COMPL_SLIP_PATTERN");
				_rej_whs = db.Row("REJ_WHS"); //ADD BY UBIQ-LIU 2010/11/24
				_rej_whs_desc = db.Row("REJ_WHS_DESC");//ADD BY UBIQ-LIU 2010/11/24
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
				_entry_date = DateTime.Parse(db.Row("ENTRY_DATE"));
				_chg_date = DateTime.Parse(db.Row("CHG_DATE"));
				_chg_pgm = db.Row("CHG_PGM");
				_chg_user_id = db.Row("CHG_USERID");
				_update_cntr = int.Parse(db.Row("UPDATE_CNTR"));
				_ws_prc = double.Parse(db.Row("WS_PRC"));
				_rep_ws_desc = db.Row("REP_WS_DESC");
				_cost_center_name = db.Row("COST_CENTER_NAME");
				_vendor_name = db.Row("VENDOR_NAME");
			}

			if (db.State() == ConnectionState.Open)
				db.DbClose();
			return rtn;
		}

	}
}
