using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// 仕入先クラス
/// </summary>
namespace IMClass
{
	public class Vendor
	{
		#region : コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Vendor()
		{
			try
			{
				_db_type = WebConfigurationManager.AppSettings["db_type"];
			}
			catch { }
		}
		public Vendor(string p_user_id, int p_lang)
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
		protected string _vendor_cd = "";
		protected int _beg_eff_date = 0;
		protected int _end_eff_date = 0;
		protected int _po_stop_flag = 0;
		protected string _vendor_name = "";
		protected string _vendor_desc = "";
		protected string _vendor_name2 = "";
		protected string _vendor_desc2 = "";
		protected string _country_cd = "";
		protected int _foreign_flag = 0;
		protected string _cur_cd = "";
		protected string _supply_whs = "";
		protected string _bond_supply_whs = "";
		protected string _rej_whs = "";//ADD BY UBIQ-LIU 2010/11/23
		protected string _rej_whs_desc = "";//ADD BY UBIQ-LIU 2010/11/23
		protected int _po_slipless_flag = 0;
		protected string _po_slip_type = "";
		protected int _fcst_flag = 0;
		protected string _pay_terms = "";
		protected string _vendor_attn = "";
		protected string _telno = "";
		protected string _faxno = "";
		protected string _zip_cd = "";
		protected string _state = "";
		protected string _address1 = "";
		protected string _address2 = "";
		protected string _address3 = "";
		protected string _address4 = "";
		protected string _state2 = "";
		protected string _address2_1 = "";
		protected string _address2_2 = "";
		protected string _address2_3 = "";
		protected string _address2_4 = "";
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

		protected string _supply_whs_desc = "";
		protected string _bond_supply_whs_desc = "";

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
		//add by liu
		protected string _cur_desc = "";

		protected bool _range;  //ADD BY UBIQ-SUO 2010/09/25

		#endregion

		#region : プロパティ
		///<summary>
		/// プロパティ
		///</summary>
		public int lang { get { return _lang; } set { _lang = value; } }
		public string vendor_cd { get { return _vendor_cd; } set { _vendor_cd = value; } }
		public int beg_eff_date { get { return _beg_eff_date; } set { _beg_eff_date = value; } }
		public int end_eff_date { get { return _end_eff_date; } set { _end_eff_date = value; } }
		public int po_stop_flag { get { return _po_stop_flag; } set { _po_stop_flag = value; } }
		public string vendor_name { get { return _vendor_name; } set { _vendor_name = value; } }
		public string vendor_desc { get { return _vendor_desc; } set { _vendor_desc = value; } }
		public string vendor_name2 { get { return _vendor_name2; } set { _vendor_name2 = value; } }
		public string vendor_desc2 { get { return _vendor_desc2; } set { _vendor_desc2 = value; } }
		public string country_cd { get { return _country_cd; } set { _country_cd = value; } }
		public int foreign_flag { get { return _foreign_flag; } set { _foreign_flag = value; } }
		public string cur_cd { get { return _cur_cd; } set { _cur_cd = value; } }
		public string supply_whs { get { return _supply_whs; } set { _supply_whs = value; } }
		public string bond_supply_whs { get { return _bond_supply_whs; } set { _bond_supply_whs = value; } }
		public string rej_whs { get { return _rej_whs; } set { _rej_whs = value; } }//ADD BY UBIQ-LIU 2010/11/23
		public string rej_whs_desc { get { return _rej_whs_desc; } set { _rej_whs_desc = value; } }//ADD BY UBIQ-LIU 2010/11/23
		public int po_slipless_flag { get { return _po_slipless_flag; } set { _po_slipless_flag = value; } }
		public string po_slip_type { get { return _po_slip_type; } set { _po_slip_type = value; } }
		public int fcst_flag { get { return _fcst_flag; } set { _fcst_flag = value; } }
		public string pay_terms { get { return _pay_terms; } set { _pay_terms = value; } }
		public string vendor_attn { get { return _vendor_attn; } set { _vendor_attn = value; } }
		public string telno { get { return _telno; } set { _telno = value; } }
		public string faxno { get { return _faxno; } set { _faxno = value; } }
		public string zip_cd { get { return _zip_cd; } set { _zip_cd = value; } }
		public string state { get { return _state; } set { _state = value; } }
		public string address1 { get { return _address1; } set { _address1 = value; } }
		public string address2 { get { return _address2; } set { _address2 = value; } }
		public string address3 { get { return _address3; } set { _address3 = value; } }
		public string address4 { get { return _address4; } set { _address4 = value; } }
		public string state2 { get { return _state2; } set { _state2 = value; } }
		public string address2_1 { get { return _address2_1; } set { _address2_1 = value; } }
		public string address2_2 { get { return _address2_2; } set { _address2_2 = value; } }
		public string address2_3 { get { return _address2_3; } set { _address2_3 = value; } }
		public string address2_4 { get { return _address2_4; } set { _address2_4 = value; } }
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

		public string supply_whs_desc { get { return _supply_whs_desc; } set { _supply_whs_desc = value; } }
		public string bond_supply_whs_desc { get { return _bond_supply_whs_desc; } set { _bond_supply_whs_desc = value; } }

		public DateTime entry_date { get { return _entry_date; } set { _entry_date = value; } }
		public DateTime chg_date { get { return _chg_date; } set { _chg_date = value; } }
		public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
		public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
		public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
		public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
		public string strErr { get { return _strErr; } set { _strErr = value; } }

		public string cur_desc { get { return _cur_desc; } set { _cur_desc = value; } }

		public bool range { get { return _range; } set { _range = value; } } //ADD BY UBIQ-SUO 2010/09/25
		#endregion

		/// <summary>
		/// 仕入先の追加
		/// 
		/// 使用画面：MstVendorMnt
		/// </summary>
		public int Insert()
		{
			ComDB db = new ComDB(_db_type);
			int rtn = 0;

			db.DbParametersClear();

			db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
			db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
			db.DbPsetInt("@I_BEG_EFF_DATE", _beg_eff_date, ComConst.DB_IN);
			db.DbPsetInt("@I_END_EFF_DATE", _end_eff_date, ComConst.DB_IN);
			db.DbPsetInt("@I_PO_STOP_FLAG", _po_stop_flag, ComConst.DB_IN);
			db.DbPsetString("@I_VENDOR_NAME", _vendor_name, ComConst.DB_IN);
			db.DbPsetString("@I_VENDOR_DESC", _vendor_desc, ComConst.DB_IN);
			db.DbPsetString("@I_VENDOR_NAME2", _vendor_name2, ComConst.DB_IN);
			db.DbPsetString("@I_VENDOR_DESC2", _vendor_desc2, ComConst.DB_IN);
			db.DbPsetString("@I_COUNTRY_CD", _country_cd, ComConst.DB_IN);
			db.DbPsetInt("@I_FOREIGN_FLAG", _foreign_flag, ComConst.DB_IN);
			db.DbPsetString("@I_CUR_CD", _cur_cd, ComConst.DB_IN);
			db.DbPsetString("@I_SUPPLY_WHS", _supply_whs, ComConst.DB_IN);
			db.DbPsetString("@I_BOND_SUPPLY_WHS", _bond_supply_whs, ComConst.DB_IN);
			db.DbPsetString("@I_REJ_WHS", _rej_whs, ComConst.DB_IN);//ADD BY UBIQ-LIU 2010/11/23
			db.DbPsetInt("@I_PO_SLIPLESS_FLAG", _po_slipless_flag, ComConst.DB_IN);
			db.DbPsetString("@I_PO_SLIP_TYPE", _po_slip_type, ComConst.DB_IN);
			db.DbPsetInt("@I_FCST_FLAG", _fcst_flag, ComConst.DB_IN);
			db.DbPsetString("@I_PAY_TERMS", _pay_terms, ComConst.DB_IN);
			db.DbPsetString("@I_VENDOR_ATTN", _vendor_attn, ComConst.DB_IN);
			db.DbPsetString("@I_TELNO", _telno, ComConst.DB_IN);
			db.DbPsetString("@I_FAXNO", _faxno, ComConst.DB_IN);
			db.DbPsetString("@I_ZIP_CD", _zip_cd, ComConst.DB_IN);
			db.DbPsetString("@I_STATE", _state, ComConst.DB_IN);
			db.DbPsetString("@I_ADDRESS1", _address1, ComConst.DB_IN);
			db.DbPsetString("@I_ADDRESS2", _address2, ComConst.DB_IN);
			db.DbPsetString("@I_ADDRESS3", _address3, ComConst.DB_IN);
			db.DbPsetString("@I_ADDRESS4", _address4, ComConst.DB_IN);
			db.DbPsetString("@I_STATE2", _state2, ComConst.DB_IN);
			db.DbPsetString("@I_ADDRESS2_1", _address2_1, ComConst.DB_IN);
			db.DbPsetString("@I_ADDRESS2_2", _address2_2, ComConst.DB_IN);
			db.DbPsetString("@I_ADDRESS2_3", _address2_3, ComConst.DB_IN);
			db.DbPsetString("@I_ADDRESS2_4", _address2_4, ComConst.DB_IN);
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
			rtn = db.DbStored("SP_VENDOR_INSERT");
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
		/// 仕入先の変更
		/// 
		/// 使用画面：MstVendorMnt
		/// </summary>
		public int Update()
		{
			ComDB db = new ComDB(_db_type);
			int rtn = 0;

			db.DbParametersClear();

			db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
			db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
			db.DbPsetInt("@I_BEG_EFF_DATE", _beg_eff_date, ComConst.DB_IN);
			db.DbPsetInt("@I_END_EFF_DATE", _end_eff_date, ComConst.DB_IN);
			db.DbPsetInt("@I_PO_STOP_FLAG", _po_stop_flag, ComConst.DB_IN);
			db.DbPsetString("@I_VENDOR_NAME", _vendor_name, ComConst.DB_IN);
			db.DbPsetString("@I_VENDOR_DESC", _vendor_desc, ComConst.DB_IN);
			db.DbPsetString("@I_VENDOR_NAME2", _vendor_name2, ComConst.DB_IN);
			db.DbPsetString("@I_VENDOR_DESC2", _vendor_desc2, ComConst.DB_IN);
			db.DbPsetString("@I_COUNTRY_CD", _country_cd, ComConst.DB_IN);
			db.DbPsetInt("@I_FOREIGN_FLAG", _foreign_flag, ComConst.DB_IN);
			db.DbPsetString("@I_CUR_CD", _cur_cd, ComConst.DB_IN);
			db.DbPsetString("@I_SUPPLY_WHS", _supply_whs, ComConst.DB_IN);
			db.DbPsetString("@I_BOND_SUPPLY_WHS", _bond_supply_whs, ComConst.DB_IN);
			db.DbPsetString("@I_REJ_WHS", _rej_whs, ComConst.DB_IN);//ADD BY UBIQ-LIU 2010/11/23
			db.DbPsetInt("@I_PO_SLIPLESS_FLAG", _po_slipless_flag, ComConst.DB_IN);
			db.DbPsetString("@I_PO_SLIP_TYPE", _po_slip_type, ComConst.DB_IN);
			db.DbPsetInt("@I_FCST_FLAG", _fcst_flag, ComConst.DB_IN);
			db.DbPsetString("@I_PAY_TERMS", _pay_terms, ComConst.DB_IN);
			db.DbPsetString("@I_VENDOR_ATTN", _vendor_attn, ComConst.DB_IN);
			db.DbPsetString("@I_TELNO", _telno, ComConst.DB_IN);
			db.DbPsetString("@I_FAXNO", _faxno, ComConst.DB_IN);
			db.DbPsetString("@I_ZIP_CD", _zip_cd, ComConst.DB_IN);
			db.DbPsetString("@I_STATE", _state, ComConst.DB_IN);
			db.DbPsetString("@I_ADDRESS1", _address1, ComConst.DB_IN);
			db.DbPsetString("@I_ADDRESS2", _address2, ComConst.DB_IN);
			db.DbPsetString("@I_ADDRESS3", _address3, ComConst.DB_IN);
			db.DbPsetString("@I_ADDRESS4", _address4, ComConst.DB_IN);
			db.DbPsetString("@I_STATE2", _state2, ComConst.DB_IN);
			db.DbPsetString("@I_ADDRESS2_1", _address2_1, ComConst.DB_IN);
			db.DbPsetString("@I_ADDRESS2_2", _address2_2, ComConst.DB_IN);
			db.DbPsetString("@I_ADDRESS2_3", _address2_3, ComConst.DB_IN);
			db.DbPsetString("@I_ADDRESS2_4", _address2_4, ComConst.DB_IN);
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
			rtn = db.DbStored("SP_VENDOR_UPDATE");
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
		/// 仕入先の削除
		/// 
		/// 使用画面：MstVendorMnt
		/// </summary>
		public int Delete()
		{
			ComDB db = new ComDB(_db_type);
			int rtn = 0;

			db.DbParametersClear();

			db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
			db.DbPsetString("@I_VENDOR_CD", _vendor_cd, ComConst.DB_IN);
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
			rtn = db.DbStored("SP_VENDOR_DELETE");
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
		/// 仕入先一覧の取得
		/// 
		/// 使用画面：MstVendorMnt, SrchVendor
		/// </summary>
		public DataSet GetVendorList()
		{
			ComDB db = new ComDB(_db_type);
			ComLibrary comlibrary = new ComLibrary();
			StringBuilder strSQL = new StringBuilder();
			DataSet ds = new DataSet();

			//--- sql
			//-->ADD BY UBIQ-SUO 2010/09/25
			strSQL.Append("SELECT  COUNT(*)                                                                    ");
			//strSQL.Append("VENDOR_CD,			BEG_EFF_DATE,			END_EFF_DATE,		PO_STOP_FLAG,	");
			//strSQL.Append("VENDOR_NAME,			VENDOR_DESC,            VENDOR_NAME2,		VENDOR_DESC2,	");
			//strSQL.Append("COUNTRY_CD,		    FOREIGN_FLAG,	        CUR_CD,	            SUPPLY_WHS,		");
			//strSQL.Append("BOND_SUPPLY_WHS,		PO_SLIPLESS_FLAG,	    PO_SLIP_TYPE,	    FCST_FLAG,		");
			//strSQL.Append("PAY_TERMS,   		VENDOR_ATTN,    	    TELNO,      	    FAXNO,  		");
			//strSQL.Append("ZIP_CD,         		STATE,          	    ADDRESS1,      	    ADDRESS2,  		");
			//strSQL.Append("ADDRESS2,         	ADDRESS4,           	STATE2,          	ADDRESS2_1,     ");
			//strSQL.Append("ADDRESS2_2,         	ADDRESS2_3,           	ADDRESS2_4,                         ");
			//strSQL.Append("DATA_CHAR1,			DATA_CHAR2,			                                        ");
			//strSQL.Append("DATA_CHAR3,			DATA_CHAR4,			DATA_CHAR5,			DATA_CHAR6,			");
			//strSQL.Append("DATA_CHAR7,			DATA_CHAR8,			DATA_CHAR9,			DATA_CHAR10,		");
			//strSQL.Append("DATA_NUM1,			DATA_NUM2,			DATA_NUM3,			DATA_NUM4,			");
			//strSQL.Append("DATA_NUM5,			DATA_NUM6,			DATA_NUM7,			DATA_NUM8,			");
			//strSQL.Append("DATA_NUM9,			DATA_NUM10,			DATA_FLAG1,			DATA_FLAG2,			");
			//strSQL.Append("DATA_FLAG3,			DATA_FLAG4,			DATA_FLAG5,			DATA_FLAG6,			");
			//strSQL.Append("DATA_FLAG7,			DATA_FLAG8,			DATA_FLAG9,			DATA_FLAG10,		");
			//strSQL.Append("ENTRY_DATE,			CHG_DATE,			CHG_PGM,			CHG_USERID,			");
			//strSQL.Append("UPDATE_CNTR                                                                      ");
			strSQL.Append(" FROM VENDOR_MASTER                                                              ");
			if (_vendor_cd != "" || _vendor_name != "")
			{
				strSQL.Append(" WHERE ");
				if (_vendor_cd != "")
				{
					strSQL.Append(" VENDOR_CD LIKE '" + _vendor_cd + "%'");
					if (_vendor_name != "")
					{
						strSQL.Append(" AND ");
					}
				}
				if (_vendor_name != "")
				{
					strSQL.Append(" VENDOR_NAME LIKE '%" + _vendor_name + "%'");
				}

			}
			//strSQL.Append(" ORDER BY  VENDOR_CD");

			db.DbParametersClear();

			try
			{
				ds = db.DbDataSet(strSQL.ToString(), "TABLE");
				if (ds == null)
				{
					_dbmsg = db.expmsg;
					_strErr = db.strErr;
					return null;
				}
				//if (db.State() == ConnectionState.Open)
				//    db.DbClose();

				if (comlibrary.StringToInt(ds.Tables[0].Rows[0][0].ToString()) > 2000)
				{
					_range = true;
				}
				else
				{
					_range = false;
				}
			}
			catch
			{
				_dbmsg = db.expmsg;
				_strErr = db.strErr;
				if (db.State() == ConnectionState.Open)
					db.DbClose();
				return null;
			}
			strSQL = new StringBuilder();
			//<--ADD BY UBIQ-SUO 2010/09/25

			strSQL.Append("SELECT   TOP 2000                                                                ");
			strSQL.Append("VENDOR_CD,			BEG_EFF_DATE,			END_EFF_DATE,		PO_STOP_FLAG,	");
			strSQL.Append("VENDOR_NAME,			VENDOR_DESC,            VENDOR_NAME2,		VENDOR_DESC2,	");
			strSQL.Append("COUNTRY_CD,		    FOREIGN_FLAG,	        CUR_CD,	            SUPPLY_WHS,		");
			strSQL.Append("BOND_SUPPLY_WHS,		PO_SLIPLESS_FLAG,	    PO_SLIP_TYPE,	    FCST_FLAG,		");
			strSQL.Append("PAY_TERMS,   		VENDOR_ATTN,    	    TELNO,      	    FAXNO,  		");
			strSQL.Append("ZIP_CD,         		STATE,          	    ADDRESS1,      	    ADDRESS2,  		");
			strSQL.Append("ADDRESS2,         	ADDRESS4,           	STATE2,          	ADDRESS2_1,     ");
			strSQL.Append("ADDRESS2_2,         	ADDRESS2_3,           	ADDRESS2_4,         REJ_WHS,        ");//ADD BY UBIQ-LIU 2010/11/23 add [REJ_WHS]
			strSQL.Append("DATA_CHAR1,			DATA_CHAR2,			                                        ");
			strSQL.Append("DATA_CHAR3,			DATA_CHAR4,			DATA_CHAR5,			DATA_CHAR6,			");
			strSQL.Append("DATA_CHAR7,			DATA_CHAR8,			DATA_CHAR9,			DATA_CHAR10,		");
			strSQL.Append("DATA_NUM1,			DATA_NUM2,			DATA_NUM3,			DATA_NUM4,			");
			strSQL.Append("DATA_NUM5,			DATA_NUM6,			DATA_NUM7,			DATA_NUM8,			");
			strSQL.Append("DATA_NUM9,			DATA_NUM10,			DATA_FLAG1,			DATA_FLAG2,			");
			strSQL.Append("DATA_FLAG3,			DATA_FLAG4,			DATA_FLAG5,			DATA_FLAG6,			");
			strSQL.Append("DATA_FLAG7,			DATA_FLAG8,			DATA_FLAG9,			DATA_FLAG10,		");
			strSQL.Append("ENTRY_DATE,			CHG_DATE,			CHG_PGM,			CHG_USERID,			");
			strSQL.Append("UPDATE_CNTR                                                                      ");
			strSQL.Append(" FROM VENDOR_MASTER                                                              ");
			if (_vendor_cd != "" || _vendor_name != "")
			{
				strSQL.Append(" WHERE ");
				if (_vendor_cd != "")
				{
					strSQL.Append(" VENDOR_CD LIKE '" + _vendor_cd + "%'");
					if (_vendor_name != "")
					{
						strSQL.Append(" AND ");
					}
				}
				if (_vendor_name != "")
				{
					strSQL.Append(" VENDOR_NAME LIKE '%" + _vendor_name + "%'");
				}

			}
			strSQL.Append(" ORDER BY  VENDOR_CD");

			db.DbParametersClear();

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
		/// 仕入先詳細の取得
		/// 
		/// 使用画面：MstVendorMnt
		/// </summary>
		public int GetVendorDetail()
		{
			ComDB db = new ComDB(_db_type);
			StringBuilder strSQL = new StringBuilder();
			int rtn = 0;

			//--- sql
			strSQL.Append("SELECT                                                                           ");
			strSQL.Append("V.VENDOR_CD,			BEG_EFF_DATE,			END_EFF_DATE,		PO_STOP_FLAG,	");
			strSQL.Append("VENDOR_NAME,			VENDOR_DESC,            VENDOR_NAME2,		VENDOR_DESC2,	");
			strSQL.Append("COUNTRY_CD,		    FOREIGN_FLAG,	        CUR_CD,	            SUPPLY_WHS,		");
			strSQL.Append("BOND_SUPPLY_WHS,		PO_SLIPLESS_FLAG,	    PO_SLIP_TYPE,	    FCST_FLAG,		");
			strSQL.Append("PAY_TERMS,   		VENDOR_ATTN,    	    TELNO,      	    FAXNO,  		");
			strSQL.Append("ZIP_CD,         		STATE,          	    ADDRESS1,      	    ADDRESS2,  		");
			strSQL.Append("ADDRESS3,         	ADDRESS4,           	STATE2,          	ADDRESS2_1,     ");
			strSQL.Append("ADDRESS2_2,         	ADDRESS2_3,           	ADDRESS2_4,                         ");
			strSQL.Append("V.DATA_CHAR1,		V.DATA_CHAR2,			                                    ");
			strSQL.Append("V.DATA_CHAR3,		V.DATA_CHAR4,			V.DATA_CHAR5,		V.DATA_CHAR6,	");
			strSQL.Append("V.DATA_CHAR7,		V.DATA_CHAR8,			V.DATA_CHAR9,		V.DATA_CHAR10,	");
			strSQL.Append("V.DATA_NUM1,			V.DATA_NUM2,			V.DATA_NUM3,		V.DATA_NUM4,	");
			strSQL.Append("V.DATA_NUM5,			V.DATA_NUM6,			V.DATA_NUM7,		V.DATA_NUM8,	");
			strSQL.Append("V.DATA_NUM9,			V.DATA_NUM10,			V.DATA_FLAG1,		V.DATA_FLAG2,	");
			strSQL.Append("V.DATA_FLAG3,		V.DATA_FLAG4,			V.DATA_FLAG5,		V.DATA_FLAG6,	");
			strSQL.Append("V.DATA_FLAG7,		V.DATA_FLAG8,			V.DATA_FLAG9,		V.DATA_FLAG10,	");
			strSQL.Append("V.ENTRY_DATE,		V.CHG_DATE,			    V.CHG_PGM,			V.CHG_USERID,	");
			strSQL.Append("V.UPDATE_CNTR,                                                                   ");
			strSQL.Append("V.REJ_WHS,			W2.WHS_DESC REJ_WHS_DESC,									");
			strSQL.Append("W.WHS_DESC AS SUPPLY_WHS_DESC,         W1.WHS_DESC AS BOND_SUPPLY_WHS_DESC,      ");
			strSQL.Append("S1.DATA_CHAR AS CUR_DESC                                                         ");
			//strSQL.Append(" FROM VENDOR_MASTER V");           
			if (_db_type == "ORACLE")
			{
				strSQL.Append(" FROM VENDOR_MASTER V, WAREHOUSE_MASTER W, WAREHOUSE_MASTER W1   ");
				strSQL.Append(" WHERE V.VENDOR_CD              = :VENDOR_CD                     ");
				strSQL.Append("   AND W.SUPPLY_WHS             = W.WHS_CD(+)                    ");
				strSQL.Append("   AND W.BOND_SUPPLY_WHS    = W1.WHS_CD(+)                       ");

				db.DbParametersClear();
				db.DbPsetString("VENDOR_CD", _vendor_cd);
			}
			else
			{
				strSQL.Append(" FROM VENDOR_MASTER V                                                ");
				strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W ON V.SUPPLY_WHS = W.WHS_CD       ");
				strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W1 ON V.BOND_SUPPLY_WHS = W1.WHS_CD");
				strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W2 ON V.REJ_WHS = W2.WHS_CD		");
				strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S1 ON S1.KEY01 = 'CURRENCY_CD'     ");
				strSQL.Append(" AND S1.KEY02 = V.CUR_CD                                             ");
				strSQL.Append(" WHERE V.VENDOR_CD = @VENDOR_CD                                      ");

				db.DbParametersClear();
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
				_vendor_cd = db.Row("VENDOR_CD");
				_beg_eff_date = int.Parse(db.Row("BEG_EFF_DATE"));
				_end_eff_date = int.Parse(db.Row("END_EFF_DATE"));
				_po_stop_flag = int.Parse(db.Row("PO_STOP_FLAG"));
				_vendor_name = db.Row("VENDOR_NAME");
				_vendor_desc = db.Row("VENDOR_DESC");
				_vendor_name2 = db.Row("VENDOR_NAME2");
				_vendor_desc2 = db.Row("VENDOR_DESC2");
				_country_cd = db.Row("COUNTRY_CD");
				_foreign_flag = int.Parse(db.Row("FOREIGN_FLAG"));
				_cur_cd = db.Row("CUR_CD");
				_supply_whs = db.Row("SUPPLY_WHS");
				_bond_supply_whs = db.Row("BOND_SUPPLY_WHS");
				_rej_whs = db.Row("REJ_WHS"); //ADD BY UBIQ-LIU 2010/11/23
				_rej_whs_desc = db.Row("REJ_WHS_DESC");//ADD BY UBIQ-LIU 2010/11/23
				_po_slipless_flag = int.Parse(db.Row("PO_SLIPLESS_FLAG"));
				_po_slip_type = db.Row("PO_SLIP_TYPE");
				_fcst_flag = int.Parse(db.Row("FCST_FLAG"));
				_pay_terms = db.Row("PAY_TERMS");
				_vendor_attn = db.Row("VENDOR_ATTN");
				_telno = db.Row("TELNO");
				_faxno = db.Row("FAXNO");
				_zip_cd = db.Row("ZIP_CD");
				_state = db.Row("STATE");
				_address1 = db.Row("ADDRESS1");
				_address2 = db.Row("ADDRESS2");
				_address3 = db.Row("ADDRESS3");
				_address4 = db.Row("ADDRESS4");
				_state2 = db.Row("STATE2");
				_address2_1 = db.Row("ADDRESS2_1");
				_address2_2 = db.Row("ADDRESS2_2");
				_address2_3 = db.Row("ADDRESS2_3");
				_address2_4 = db.Row("ADDRESS2_4");
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
				_supply_whs_desc = db.Row("SUPPLY_WHS_DESC");
				_bond_supply_whs_desc = db.Row("BOND_SUPPLY_WHS_DESC");
				//ADD BY LIU 2008.11.19
				_cur_desc = db.Row("CUR_DESC");
			}

			if (db.State() == ConnectionState.Open)
				db.DbClose();
			return rtn;
		}
	}
}
