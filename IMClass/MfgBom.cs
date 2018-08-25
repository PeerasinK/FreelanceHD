using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Data;
/*|------------------------------------------------------------------------------------------|*/
/*|  [History]                                                                               |*/
/*|  2008/10/09     UBIQ-LIU   　Creation                                                    |*/
/*|  2010/06/29     UBIQ-LIU   　追加製番                                                    |*/
/*|------------------------------------------------------------------------------------------|*/
/// <summary>
/// MfgBomクラス
/// </summary>
namespace IMClass
{
    public class MfgBom
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MfgBom()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public MfgBom(string p_user_id, int p_lang)
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
        protected string _parent_item_no = "";
        protected string _ws_cd = "";
        protected string _parent_item_desc = "";
        protected string _parent_item_type = "";
        protected string _parent_spec_desc = "";
        protected string _parent_drawing_no = "";
        protected string _mbom_sub_cd= "";
        protected int _part_seq = 0;
        protected int _routine_seq = 0;
        protected string _child_item_no = "";
        protected string _child_item_desc = "";
        protected string _child_item_type = "";
        protected int _child_po_type = 0;
        protected int _beg_eff_date = 0;
        protected int _end_eff_date = 0;
        protected int _beg_eff_date1 = 0;
        protected int _end_eff_date1 = 0;
        protected string _process_cd = "";
        protected string _process_desc = "";
        protected int _usage_type = 0;
        protected double _usage_dec = 0;
        protected double _usage_denominator = 0;
        protected double _usage_numerator = 0;
        protected double _defect_pct = 0;
        protected string _sub_grp_cd = "";
        protected int _sub_action_flag = 0;
        protected int _stop_expl_flag = 0;
        protected int _structure_dummy_flag = 0;
        protected double _entry_lt = 0;
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
        protected double _std_prc = 0;
        protected string _child_catg_cd = "";
        protected string _child_spec_desc = "";
        protected string _child_drawing_no = "";
        protected string _child_item_umsr = "";
        protected int _tree_node_max = 0;
        protected int _pty_no = 0;
        protected string _umsr_desc = "";

        protected string _joc_cd = "";
        protected string _to_joc_cd = "";
        protected string _from_joc_cd = "";
        protected string _to_item_no = "";
        protected string _from_item_no = "";

        protected string _ws_desc = "";
        protected string _rep_routine_item_no = "";
        protected string _rep_routine_ws_cd = "";
        protected string _compl_whs = "";
        protected string _semi_whs = "";
        protected double _insp_lt = 0;
        protected int _plant_lt = 0;
        protected string _disb_whs = "";
        protected string _bond_semi_whs = "";
        protected string _bond_disb_whs = "";
        protected int _lt_type = 0;
        protected int _next_proc_cont_flag = 0;
        protected double _setup_time = 0;
        protected double _unit_time = 0;
        protected double _mfg_lt = 0;
        protected double _daily_prod_qty = 0;
        protected double _pur_lot_size = 0.0;
        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        public int lang { get { return _lang; } set { _lang = value; } }
        public string db_type { get { return _db_type; } set { _db_type = value; } }
        public string parent_item_no { get { return _parent_item_no; } set { _parent_item_no = value; } }
        public string parent_item_desc { get { return _parent_item_desc; } set { _parent_item_desc = value; } }
        public string parent_item_type { get { return _parent_item_type; } set { _parent_item_type = value; } }
        public string mbom_sub_cd { get { return _mbom_sub_cd; } set { _mbom_sub_cd = value; } }
        public string ws_cd { get { return _ws_cd; } set { _ws_cd = value; } }
        public int part_seq { get { return _part_seq; } set { _part_seq = value; } }
        public int pty_no { get { return _pty_no; } set { _pty_no = value; } }
        public int routine_seq { get { return _routine_seq; } set { _routine_seq = value; } }
        public string child_item_no { get { return _child_item_no; } set { _child_item_no = value; } }
        public string child_item_desc { get { return _child_item_desc; } set { _child_item_desc = value; } }
        public string child_item_type { get { return _child_item_type; } set { _child_item_type = value; } }
        public int child_po_type { get { return _child_po_type; } set { _child_po_type = value; } }
        public string child_catg_cd { get { return _child_catg_cd; } set { _child_catg_cd = value; } }
        public string child_spec_desc { get { return _child_spec_desc; } set { _child_spec_desc = value; } }
        public string child_drawing_no { get { return _child_drawing_no; } set { _child_drawing_no = value; } }
        public string child_item_umsr { get { return _child_item_umsr; } set { _child_item_umsr = value; } }
        public double std_prc { get { return _std_prc; } set { _std_prc = value; } }
        public int beg_eff_date { get { return _beg_eff_date; } set { _beg_eff_date = value; } }
        public int end_eff_date { get { return _end_eff_date; } set { _end_eff_date = value; } }
        public int beg_eff_date1 { get { return _beg_eff_date1; } set { _beg_eff_date1 = value; } }
        public int end_eff_date1 { get { return _end_eff_date1; } set { _end_eff_date1 = value; } }
        public string process_cd { get { return _process_cd; } set { _process_cd = value; } }
        public string process_desc { get { return _process_desc; } set { _process_desc = value; } }
        public int usage_type { get { return _usage_type; } set { _usage_type = value; } }
        public double usage_dec { get { return _usage_dec; } set { _usage_dec = value; } }
        public double usage_denominator { get { return _usage_denominator; } set { _usage_denominator = value; } }
        public double usage_numerator { get { return _usage_numerator; } set { _usage_numerator = value; } }
        public double defect_pct { get { return _defect_pct; } set { _defect_pct = value; } }
        public string sub_grp_cd { get { return _sub_grp_cd; } set { _sub_grp_cd = value; } }
        public int sub_action_flag { get { return _sub_action_flag; } set { _sub_action_flag = value; } }
        public int stop_expl_flag { get { return _stop_expl_flag; } set { _stop_expl_flag = value; } }
        public int structure_dummy_flag { get { return _structure_dummy_flag; } set { _structure_dummy_flag = value; } }
        public double entry_lt { get { return _entry_lt; } set { _entry_lt = value; } }
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
        public string umsr_desc { get { return _umsr_desc; } set { _umsr_desc = value; } }

        public string joc_cd { get { return _joc_cd; } set { _joc_cd = value; } }
        public string to_joc_cd { get { return _to_joc_cd; } set { _to_joc_cd = value; } }
        public string from_joc_cd { get { return _from_joc_cd; } set { _from_joc_cd = value; } }
        public string to_item_no { get { return _to_item_no; } set { _to_item_no = value; } }
        public string from_item_no { get { return _from_item_no; } set { _from_item_no = value; } }

        public string ws_desc { get { return _ws_desc; } set { _ws_desc = value; } }
        public string rep_routine_item_no { get { return _strErr; } set { _strErr = value; } }
        public string rep_routine_ws_cd { get { return _rep_routine_ws_cd; } set { _rep_routine_ws_cd = value; } }
        public string compl_whs { get { return _compl_whs; } set { _compl_whs = value; } }
        public string semi_whs { get { return _semi_whs; } set { _semi_whs = value; } }
        public double insp_lt { get { return _insp_lt; } set { _insp_lt = value; } }
        public int plant_lt { get { return _plant_lt; } set { _plant_lt = value; } }
        public string disb_whs { get { return _disb_whs; } set { _disb_whs = value; } }
        public string bond_semi_whs { get { return _bond_semi_whs; } set { _bond_semi_whs = value; } }
        public string bond_disb_whs { get { return _bond_disb_whs; } set { _bond_disb_whs = value; } }
        public int lt_type { get { return _lt_type; } set { _lt_type = value; } }
        public int next_proc_cont_flag { get { return _next_proc_cont_flag; } set { _next_proc_cont_flag = value; } }
        public double setup_time { get { return _setup_time; } set { _setup_time = value; } }
        public double unit_time { get { return _unit_time; } set { _unit_time = value; } }
        public double mfg_lt { get { return _mfg_lt; } set { _mfg_lt = value; } }
        public double daily_prod_qty { get { return _daily_prod_qty; } set { _daily_prod_qty = value; } }
        public double pur_lot_size { get { return _pur_lot_size; } set { _pur_lot_size = value; } }

        public int tree_node_max
        {
            get { return _tree_node_max; }
            set { _tree_node_max = value; }
        }
        #endregion

        /// <summary>
        /// 部品表詳細の取得
        /// 
        /// 使用画面：MstIMfgBomMnt
        /// </summary>
        public int GetMfgBomDetail()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append("M.PARENT_ITEM_NO,	M.PART_SEQ,			M.CHILD_ITEM_NO,    M.BEG_EFF_DATE,	        ");
            strSQL.Append("M.END_EFF_DATE,	    M.MBOM_SUB_CD,      M.PROCESS_CD,       M.USAGE_TYPE,           ");
            strSQL.Append("M.USAGE_DEC,         M.USAGE_DENOMINATOR,M.USAGE_NUMERATOR,  M.DEFECT_PCT,           ");
            strSQL.Append("M.SUB_GRP_CD,	    M.SUB_ACTION_FLAG,  M.STOP_EXPL_FLAG,	M.STRUCTURE_DUMMY_FLAG, ");
            strSQL.Append("M.ENTRY_LT,	    	M.DATA_CHAR1,	    M.DATA_CHAR2,			                    ");
            strSQL.Append("M.DATA_CHAR3,		M.DATA_CHAR4,		M.DATA_CHAR5,		M.DATA_CHAR6,			");
            strSQL.Append("M.DATA_CHAR7,		M.DATA_CHAR8,		M.DATA_CHAR9,		M.DATA_CHAR10,  		");
            strSQL.Append("M.DATA_NUM1,			M.DATA_NUM2,		M.DATA_NUM3,		M.DATA_NUM4,			");
            strSQL.Append("M.DATA_NUM5,			M.DATA_NUM6,		M.DATA_NUM7,		M.DATA_NUM8,			");
            strSQL.Append("M.DATA_NUM9,			M.DATA_NUM10,		M.DATA_FLAG1,		M.DATA_FLAG2,			");
            strSQL.Append("M.DATA_FLAG3,		M.DATA_FLAG4,		M.DATA_FLAG5,		M.DATA_FLAG6,			");
            strSQL.Append("M.DATA_FLAG7,		M.DATA_FLAG8,		M.DATA_FLAG9,		M.DATA_FLAG10,	    	");
            strSQL.Append("M.ENTRY_DATE,		M.CHG_DATE,			M.CHG_PGM,			M.CHG_USERID,			");
            strSQL.Append("M.UPDATE_CNTR,");
            strSQL.Append(" I1.ITEM_DESC AS PARENT_ITEM_DESC,  I2.ITEM_DESC AS CHILD_ITEM_DESC,");
            strSQL.Append(" I1.ITEM_TYPE AS PARENT_ITEM_TYPE,  I1.DRAWING_NO AS PARENT_DRAWING_NO ,  I1.SPEC_DESC AS PARENT_SPEC_DESC,");
            strSQL.Append(" I2.PO_TYPE AS CHILD_PO_TYPE,  I2.ITEM_TYPE AS CHILD_ITEM_TYPE ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM MFG_BOM_MASTER M, ITEM_MASTER I1,ITEM_MASTER I2 ");
                strSQL.Append(" WHERE M.PARENT_ITEM_NO   = :PARENT_ITEM_NO");
                strSQL.Append("   AND M.CHILD_ITEM_NO    = :CHILD_ITEM_NO");
                strSQL.Append("   AND M.PART_SEQ         = :PART_SEQ");
                strSQL.Append("   AND M.MBOM_SUB_CD      = :MBOM_SUB_CD");
                strSQL.Append("   AND M.BEG_EFF_DATE     <= :BEG_EFF_DATE");
                strSQL.Append("   AND M.END_EFF_DATE     >= :END_EFF_DATE");
                strSQL.Append("   AND M.PARENT_ITEM_NO   = I1.ITEM_NO(+)");
                strSQL.Append("   AND M.CHILD_ITEM_NO    = I2.ITEM_NO(+)");

                db.DbParametersClear();
                db.DbPsetString("PARENT_ITEM_NO", _parent_item_no);
                db.DbPsetString("CHILD_ITEM_NO", _child_item_no);
                db.DbPsetInt("PART_SEQ", _part_seq);
                db.DbPsetString("MBOM_SUB_CD", _mbom_sub_cd);
                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("END_EFF_DATE", _end_eff_date);
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM MFG_BOM_MASTER M                                               ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I1 ON M.PARENT_ITEM_NO   = I1.ITEM_NO   ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I2 ON M.CHILD_ITEM_NO    = I2.ITEM_NO   ");
                strSQL.Append(" WHERE M.PARENT_ITEM_NO = @PARENT_ITEM_NO                            ");
                strSQL.Append("   AND M.CHILD_ITEM_NO  = @CHILD_ITEM_NO                             ");
                strSQL.Append("   AND M.PART_SEQ       = @PART_SEQ                                  ");
                strSQL.Append("   AND M.MBOM_SUB_CD    = @MBOM_SUB_CD                               ");
                if (_beg_eff_date != 0)
                {
                    strSQL.Append("   AND M.BEG_EFF_DATE   <= @BEG_EFF_DATE");
                    db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                }
                if (_end_eff_date != 0)
                {
                    strSQL.Append("   AND M.END_EFF_DATE   >= @END_EFF_DATE");
                    db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
                }
                db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                db.DbPsetString("@CHILD_ITEM_NO", _child_item_no);
                db.DbPsetInt("@PART_SEQ", _part_seq);
                db.DbPsetString("@MBOM_SUB_CD", _mbom_sub_cd);
            }
            strSQL.Append(" ORDER BY  M.PART_SEQ");

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _parent_item_no = db.Row("PARENT_ITEM_NO");
                _part_seq = int.Parse(db.Row("PART_SEQ"));
                _child_item_no = db.Row("CHILD_ITEM_NO");
                _beg_eff_date = int.Parse(db.Row("BEG_EFF_DATE"));
                _end_eff_date = int.Parse(db.Row("END_EFF_DATE"));
                _mbom_sub_cd = db.Row("MBOM_SUB_CD");
                _process_cd = db.Row("PROCESS_CD");
                _usage_type = int.Parse(db.Row("USAGE_TYPE"));
                _usage_dec = double.Parse(db.Row("USAGE_DEC"));
                _usage_denominator = double.Parse(db.Row("USAGE_DENOMINATOR"));
                _usage_numerator = double.Parse(db.Row("USAGE_NUMERATOR"));
                _defect_pct = double.Parse(db.Row("DEFECT_PCT"));
                _sub_grp_cd = db.Row("SUB_GRP_CD");
                _sub_action_flag = int.Parse(db.Row("SUB_ACTION_FLAG"));
                _stop_expl_flag = int.Parse(db.Row("STOP_EXPL_FLAG"));
                _structure_dummy_flag = int.Parse(db.Row("STRUCTURE_DUMMY_FLAG"));
                _entry_lt = double.Parse(db.Row("ENTRY_LT"));
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
                _parent_item_desc = db.Row("PARENT_ITEM_DESC");
                _parent_item_type = db.Row("PARENT_ITEM_TYPE");
                _parent_drawing_no = db.Row("PARENT_DRAWING_NO");
                _parent_spec_desc = db.Row("PARENT_SPEC_DESC");
                _child_item_desc = db.Row("CHILD_ITEM_DESC");
                _child_item_type = db.Row("CHILD_ITEM_TYPE");
                _child_po_type = int.Parse(db.Row("CHILD_PO_TYPE"));
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }
        /// <summary>
        /// 部品表一覧の取得
        /// 
        /// 使用画面：MstMfgBomMnt
        /// </summary>
        public DataSet GetMfgBomList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            //strSQL.Append("SELECT ");
            //strSQL.Append("M.PARENT_ITEM_NO,	M.PART_SEQ,			M.CHILD_ITEM_NO,    M.BEG_EFF_DATE,	        ");
            //strSQL.Append("M.END_EFF_DATE,	    M.MBOM_SUB_CD,      M.PROCESS_CD,       M.USAGE_TYPE,           ");
            //strSQL.Append("M.USAGE_DEC,         M.USAGE_DENOMINATOR,M.USAGE_NUMERATOR,  M.DEFECT_PCT,           ");
            //strSQL.Append("M.SUB_GRP_CD,	    M.SUB_ACTION_FLAG,  M.STOP_EXPL_FLAG,	M.STRUCTURE_DUMMY_FLAG, ");
            //strSQL.Append("M.ENTRY_LT,	    	M.DATA_CHAR1,	    M.DATA_CHAR2,			                    ");
            //strSQL.Append("M.DATA_CHAR3,		M.DATA_CHAR4,		M.DATA_CHAR5,		M.DATA_CHAR6,			");
            //strSQL.Append("M.DATA_CHAR7,		M.DATA_CHAR8,		M.DATA_CHAR9,		M.DATA_CHAR10,  		");
            //strSQL.Append("M.DATA_NUM1,			M.DATA_NUM2,		M.DATA_NUM3,		M.DATA_NUM4,			");
            //strSQL.Append("M.DATA_NUM5,			M.DATA_NUM6,		M.DATA_NUM7,		M.DATA_NUM8,			");
            //strSQL.Append("M.DATA_NUM9,			M.DATA_NUM10,		M.DATA_FLAG1,		M.DATA_FLAG2,			");
            //strSQL.Append("M.DATA_FLAG3,		M.DATA_FLAG4,		M.DATA_FLAG5,		M.DATA_FLAG6,			");
            //strSQL.Append("M.DATA_FLAG7,		M.DATA_FLAG8,		M.DATA_FLAG9,		M.DATA_FLAG10,	    	");
            //strSQL.Append("M.ENTRY_DATE,		M.CHG_DATE,			M.CHG_PGM,			M.CHG_USERID,			");
            //strSQL.Append("M.UPDATE_CNTR,");
            //strSQL.Append(" I1.ITEM_DESC AS PARENT_ITEM_DESC,  I2.ITEM_DESC AS CHILD_ITEM_DESC,");
            //strSQL.Append(" I1.ITEM_TYPE AS PARENT_ITEM_TYPE,  I1.DRAWING_NO AS DRAWING_NO ,  I1.SPEC_DESC AS SPEC_DESC,");
            //strSQL.Append(" I2.PO_TYPE AS CHILD_PO_TYPE,  I2.ITEM_TYPE AS CHILD_ITEM_TYPE ");
            //strSQL.Append(" ,S3.DATA_CHAR UMSR_NAME "); // IMV3
            //strSQL.Append(" ,I2.LOT_CNTL_FLAG "); // 2015.11.24
            //strSQL.Append(" ,I2.AUTO_DISB_TYPE "); // 2015.11.27
            strSQL.Append("SELECT ");
            strSQL.Append("M.BOM_NO,	        M.BOM_LEVEL,		M.BOM_SUB_LEVEL,    M.PARENT_ITEM,	        ");
            strSQL.Append("M.CHILD_ITEM,	    M.SEQUENT,          M.USAGE_QUANTITY,                           ");
            strSQL.Append("M.ENTRY_DATE,		M.UPDATE_DATE,		M.USER_CREATE,		M.USER_UPDATE			");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM MFG_BOM_MASTER M, ITEM_MASTER I1,ITEM_MASTER I2 ");
                strSQL.Append(" WHERE M.PARENT_ITEM_NO   = :PARENT_ITEM_NO");
                strSQL.Append("   AND M.MBOM_SUB_CD      = :MBOM_SUB_CD");
                strSQL.Append("   AND M.PARENT_ITEM_NO   = I1.ITEM_NO(+)");
                strSQL.Append("   AND M.CHILD_ITEM_NO    = I2.ITEM_NO(+)");

                db.DbParametersClear();
                db.DbPsetString("PARENT_ITEM_NO", _parent_item_no);
                db.DbPsetString("MBOM_SUB_CD", _mbom_sub_cd);
            }
            else
            {
                strSQL.Append(" FROM MFG_BOM_MASTER M ");
                //strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I1 ON M.PARENT_ITEM_NO   = I1.ITEM_NO");
                //strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I2 ON M.CHILD_ITEM_NO    = I2.ITEM_NO");
                
                // IMV3
                //strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER S3 ON S3.KEY01 = 'ITEM_UMSR'               ");
                //strSQL.Append(" AND S3.KEY02        =       I2.ITEM_UMSR                                   ");

                //strSQL.Append(" WHERE M.PARENT_ITEM_NO  = @PARENT_ITEM_NO                       ");
                strSQL.Append(" WHERE M.PARENT_ITEM  = @PARENT_ITEM_NO                       ");
                //strSQL.Append("   AND M.MBOM_SUB_CD     = @MBOM_SUB_CD                          ");

                db.DbParametersClear();
                db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                //db.DbPsetString("@MBOM_SUB_CD", _mbom_sub_cd);
            }
            //strSQL.Append(" ORDER BY  M.PART_SEQ");
            strSQL.Append(" ORDER BY  M.BOM_LEVEL");
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
        /// 部品表の追加
        /// 
        /// 使用画面：MfgBOMMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PARENT_ITEM_NO", _parent_item_no, ComConst.DB_IN);
            db.DbPsetString("@I_MBOM_SUB_CD", _mbom_sub_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_PART_SEQ", _part_seq, ComConst.DB_IN);
            db.DbPsetString("@I_CHILD_ITEM_NO", _child_item_no, ComConst.DB_IN);
            db.DbPsetInt("@I_BEG_EFF_DATE", _beg_eff_date, ComConst.DB_IN);
            db.DbPsetInt("@I_END_EFF_DATE", _end_eff_date, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_USAGE_TYPE", _usage_type, ComConst.DB_IN);
            db.DbPsetDouble("@I_USAGE_DEC", _usage_dec, ComConst.DB_IN);
            db.DbPsetDouble("@I_USAGE_DENOMINATOR", _usage_denominator, ComConst.DB_IN);
            db.DbPsetDouble("@I_USAGE_NUMERATOR", _usage_numerator, ComConst.DB_IN);
            db.DbPsetDouble("@I_DEFECT_PCT", _defect_pct, ComConst.DB_IN);
            db.DbPsetString("@I_SUB_GRP_CD", _sub_grp_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_SUB_ACTION_FLAG", _sub_action_flag, ComConst.DB_IN);
            db.DbPsetInt("@I_STOP_EXPL_FLAG", _stop_expl_flag, ComConst.DB_IN);
            db.DbPsetInt("@I_STRUCTURE_DUMMY_FLAG", _structure_dummy_flag, ComConst.DB_IN);
            db.DbPsetDouble("@I_ENTRY_LT", _entry_lt, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_MFG_BOM_INSERT");
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
        /// 部品表の変更
        /// 
        /// 使用画面：MfgBOMMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PARENT_ITEM_NO", _parent_item_no, ComConst.DB_IN);
            db.DbPsetString("@I_MBOM_SUB_CD", _mbom_sub_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_PART_SEQ", _part_seq, ComConst.DB_IN);
            db.DbPsetString("@I_CHILD_ITEM_NO", _child_item_no, ComConst.DB_IN);
            db.DbPsetInt("@I_BEG_EFF_DATE", _beg_eff_date, ComConst.DB_IN);
            db.DbPsetInt("@I_END_EFF_DATE", _end_eff_date, ComConst.DB_IN);
            db.DbPsetString("@I_PROCESS_CD", _process_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_USAGE_TYPE", _usage_type, ComConst.DB_IN);
            db.DbPsetDouble("@I_USAGE_DEC", _usage_dec, ComConst.DB_IN);
            db.DbPsetDouble("@I_USAGE_DENOMINATOR", _usage_denominator, ComConst.DB_IN);
            db.DbPsetDouble("@I_USAGE_NUMERATOR", _usage_numerator, ComConst.DB_IN);
            db.DbPsetDouble("@I_DEFECT_PCT", _defect_pct, ComConst.DB_IN);
            db.DbPsetString("@I_SUB_GRP_CD", _sub_grp_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_SUB_ACTION_FLAG", _sub_action_flag, ComConst.DB_IN);
            db.DbPsetInt("@I_STOP_EXPL_FLAG", _stop_expl_flag, ComConst.DB_IN);
            db.DbPsetInt("@I_STRUCTURE_DUMMY_FLAG", _structure_dummy_flag, ComConst.DB_IN);
            db.DbPsetDouble("@I_ENTRY_LT", _entry_lt, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_MFG_BOM_UPDATE");
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
        /// 品目作業場所の削除
        /// 
        /// 使用画面：MfgBOMMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_PARENT_ITEM_NO", _parent_item_no, ComConst.DB_IN);
            db.DbPsetString("@I_DATA_CHAR1", _data_char1, ComConst.DB_IN);  // HTS
            db.DbPsetDouble("@I_DATA_NUM1", _data_num1, ComConst.DB_IN);    // HTS
            db.DbPsetDouble("@I_DATA_NUM2", _data_num2, ComConst.DB_IN);    // HTS
            //db.DbPsetString("@I_MBOM_SUB_CD", _mbom_sub_cd, ComConst.DB_IN);
            db.DbPsetInt("@I_PART_SEQ", _part_seq, ComConst.DB_IN);
            db.DbPsetString("@I_CHILD_ITEM_NO", _child_item_no, ComConst.DB_IN);
            //db.DbPsetInt("@I_BEG_EFF_DATE", _beg_eff_date, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_MFG_BOM_DELETE");
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
        /// 品目簡易登録の正展開表示 BOM
        /// 
        /// 使用画面：MstItemEntryMnt
        /// </summary>
        /// <returns></returns>
        public DataSet GetMfgBomListFwd()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            //strSQL.Append("SELECT DISTINCT A.LVL , A.PARENT_ITEM_NO, A.CHILD_ITEM_NO, A.PROCESS_CD, A.SUB_GRP_CD, A.SUB_ACTION_FLAG, ");  //Del 10.08.06 Ubiq-Sai
            strSQL.Append("SELECT A.LVL , A.PARENT_ITEM_NO, A.CHILD_ITEM_NO, A.PROCESS_CD, A.SUB_GRP_CD, A.SUB_ACTION_FLAG, ");    //Add 10.08.06 Ubiq-Sai
            strSQL.Append(" A.USAGE_TYPE, A.USAGE_DEC, A.USAGE_DENOMINATOR, A.USAGE_NUMERATOR ,PART_SEQ,");
            strSQL.Append(" SORTCOL, "); //Add 10.08.06 Ubiq-Sai
            strSQL.Append(" I1.ITEM_DESC AS PARENT_ITEM_DESC,  I2.ITEM_DESC AS CHILD_ITEM_DESC ");

            strSQL.Append(" FROM (");

            if (_db_type == "ORACLE")
            {
                strSQL.Append("SELECT ");
                strSQL.Append("LEVEL LVL,");
                strSQL.Append("PARENT_ITEM_NO , CHILD_ITEM_NO, PROCESS_CD, SUB_GRP_CD, USAGE_DEC,BEG_EFF_DATE,END_EFF_DATE");
                strSQL.Append("SUB_ACTION_FLAG , USAGE_TYPE, USAGE_DEC, USAGE_DENOMINATOR, USAGE_NUMERATOR,PART_SEQ, ");
                strSQL.Append(" PART_SEQ SORTCOL "); //Add 10.08.06 Ubiq-Sai
                strSQL.Append(" FROM MFG_BOM_MASTER M ");
                strSQL.Append(" CONNECT BY PRIOR CHILD_ITEM_NO = PARENT_ITEM_NO ");
                strSQL.Append(" AND M.BEG_EFF_DATE        <= :BEG_EFF_DATE1");
                strSQL.Append(" AND M.END_EFF_DATE        >= :END_EFF_DATE1");
                strSQL.Append(" START WITH PARENT_DEPT_CD = :PARENT_DEPT_CD ");
                strSQL.Append(" AND M.PARENT_ITEM_NO   = :PARENT_ITEM_NO");
                strSQL.Append(" AND M.BEG_EFF_DATE        <= :BEG_EFF_DATE2");
                strSQL.Append(" AND M.END_EFF_DATE        >= :END_EFF_DATE2");
                strSQL.Append(" ORDER SIBLINGS BY LVL ");
                strSQL.Append(") as A , ITEM_MASTER I1,ITEM_MASTER I2");
                strSQL.Append("   WHERE A.PARENT_ITEM_NO   = I1.ITEM_NO(+)");
                strSQL.Append("   AND A.CHILD_ITEM_NO    = I2.ITEM_NO(+)");
                db.DbParametersClear();
                db.DbPsetString("PARENT_ITEM_NO", _parent_item_no);
                db.DbPsetInt("BEG_EFF_DATE1", _beg_eff_date);
                db.DbPsetInt("END_EFF_DATE1", _end_eff_date);
                db.DbPsetInt("BEG_EFF_DATE2", _beg_eff_date);
                db.DbPsetInt("END_EFF_DATE2", _end_eff_date);

            }
            else
            {
                strSQL.Append("SELECT ");
                strSQL.Append(" LVL, PARENT_ITEM_NO, CHILD_ITEM_NO, PROCESS_CD, SUB_GRP_CD, SUB_ACTION_FLAG,");
                strSQL.Append(" USAGE_TYPE,USAGE_DEC,USAGE_DENOMINATOR,USAGE_NUMERATOR,BEG_EFF_DATE,END_EFF_DATE,PART_SEQ, ");
                strSQL.Append(" SORTCOL "); //Add 10.08.06 Ubiq-Sai
                strSQL.Append(" FROM dbo.MBOMTreeView(@JOC_CD,@PARENT_ITEM_NO,@BEG_EFF_DATE,@END_EFF_DATE)) A ");//JOC_CD ADD BY UBIQ-LIU
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I1 ON PARENT_ITEM_NO = I1.ITEM_NO");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I2 ON CHILD_ITEM_NO = I2.ITEM_NO");

                db.DbParametersClear();
                db.DbPsetString("@JOC_CD", _joc_cd);
                db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
            }
            //strSQL.Append(" ORDER BY PART_SEQ   ");   //Del 10.08.06 Ubiq-Sai
            strSQL.Append(" ORDER BY SORTCOL   ");     //Add 10.08.06 Ubiq-Sai
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
        /// 品目簡易登録の正展開表示 WS
        /// 
        /// 使用画面：MstItemEntryMnt
        /// </summary>
        /// <returns></returns>
        public DataSet GetMfgBomListFwdWithWS()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            strSQL.Append("SELECT                                                                               ");
            strSQL.Append("IW.ITEM_NO,			IW.WS_CD,			R.ROUTINE_SEQ,      R.BEG_EFF_DATE,	        ");
            strSQL.Append("R.END_EFF_DATE,	    P.PROCESS_CD,       IW.PTY_NO,                                  ");
            strSQL.Append("I.ITEM_DESC AS ITEM_DESC,                                                            ");
            strSQL.Append("M.WS_DESC AS WS_DESC, P.PROCESS_DESC AS PROCESS_DESC                                 ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ROUTINE_MASTER R, ITEM_MASTER I ,WORKSHOP_MASTER M ,PROCESS_MASTER P,ITEM_WS_MASTER IW");
                strSQL.Append(" WHERE R.ITEM_NO            = :ITEM_NO");
                strSQL.Append("   AND R.ITEM_NO             = I.ITEM_NO(+)");
                strSQL.Append("   AND R.WS_CD               = M.WS_CD(+)");
                strSQL.Append("   AND R.WS_CD               = P.WS_CD(+)");
                strSQL.Append("   AND R.PROCESS_CD          = P.PROCESS_CD(+)");
                strSQL.Append("   AND R.BEG_EFF_DATE        <= :BEG_EFF_DATE");
                strSQL.Append("   AND R.END_EFF_DATE        >= :END_EFF_DATE");
                strSQL.Append("   AND IW.BEG_EFF_DATE       <= :BEG_EFF_DATE");
                strSQL.Append("   AND IW.END_EFF_DATE       >= :END_EFF_DATE");
                strSQL.Append("   AND IW.WS_CD              = R.WS_CD");
                strSQL.Append("   AND IW.ITEM_NO            = R.ITEM_NO");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _parent_item_no);
                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("END_EFF_DATE", _end_eff_date);
            }
            else
            {
                strSQL.Append(" FROM ITEM_WS_MASTER IW                                                                  ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER M   ON IW.WS_CD     = M.WS_CD                           ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I       ON IW.ITEM_NO   = I.ITEM_NO                         ");
                strSQL.Append(" LEFT OUTER JOIN ROUTINE_MASTER R    ON IW.ITEM_NO   = R.ITEM_NO                         ");
                strSQL.Append(" AND IW.WS_CD = R.WS_CD                                                                  ");
                strSQL.Append(" AND R.BEG_EFF_DATE <= @BEG_EFF_DATE AND R.END_EFF_DATE >= @END_EFF_DATE                 ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER P ON R.WS_CD = P.WS_CD AND R.PROCESS_CD = P.PROCESS_CD   ");
                strSQL.Append(" WHERE IW.ITEM_NO = @ITEM_NO                                                             ");
                strSQL.Append("   AND IW.BEG_EFF_DATE        <= @BEG_EFF_DATE                                           ");
                strSQL.Append("   AND IW.END_EFF_DATE        >= @END_EFF_DATE                                           ");

                db.DbParametersClear();
                db.DbPsetString("@ITEM_NO", _parent_item_no);
                db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
            }
            strSQL.Append(" ORDER BY IW.PTY_NO ,ROUTINE_SEQ DESC ");
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
        /// 逆展開表示 BOM
        /// 
        /// <para>使用画面：[MstItemEntryMnt][MstMfgBomMnt]</para>
        /// </summary>
        public DataSet GetMfgBomListRvs()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            //strSQL.Append("SELECT DISTINCT A.LVL , A.PARENT_ITEM_NO, A.CHILD_ITEM_NO, A.PROCESS_CD, A.SUB_GRP_CD, A.SUB_ACTION_FLAG, ");  //Del 10.08.06 Ubiq-Sai
            strSQL.Append("SELECT A.LVL , A.PARENT_ITEM_NO, A.CHILD_ITEM_NO, A.PROCESS_CD, A.SUB_GRP_CD, A.SUB_ACTION_FLAG, ");    //Add 10.08.06 Ubiq-Sai
            strSQL.Append(" A.USAGE_TYPE, A.USAGE_DEC, A.USAGE_DENOMINATOR, A.USAGE_NUMERATOR ,PART_SEQ,                             ");
            strSQL.Append(" SORTCOL, "); //Add 10.08.06 Ubiq-Sai
            strSQL.Append(" I1.ITEM_DESC AS PARENT_ITEM_DESC,  I2.ITEM_DESC AS CHILD_ITEM_DESC                                       ");

            strSQL.Append(" FROM (");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" SELECT                                                                                      ");
                strSQL.Append(" LEVEL LVL,                                                                                  ");
                strSQL.Append(" PARENT_ITEM_NO , CHILD_ITEM_NO, PROCESS_CD, SUB_GRP_CD, USAGE_DEC,BEG_EFF_DATE,END_EFF_DATE ");
                strSQL.Append(" SUB_ACTION_FLAG , USAGE_TYPE, USAGE_DEC, USAGE_DENOMINATOR, USAGE_NUMERATOR,PART_SEQ,       ");
                strSQL.Append(" PART_SEQ SORTCOL "); //Add 10.08.06 Ubiq-Sai
                strSQL.Append(" FROM MFG_BOM_MASTER M                                                                       ");
                strSQL.Append(" CONNECT BY PRIOR PARENT_ITEM_NO = CHILD_ITEM_NO                                             ");
                strSQL.Append(" AND M.BEG_EFF_DATE        <= :BEG_EFF_DATE1                                                 ");
                strSQL.Append(" AND M.END_EFF_DATE        >= :END_EFF_DATE1                                                 ");
                strSQL.Append(" START WITH M.CHILD_ITEM_NO   = :CHILD_ITEM_NO                                               ");
                strSQL.Append(" AND M.BEG_EFF_DATE        <= :BEG_EFF_DATE2                                                 ");
                strSQL.Append(" AND M.END_EFF_DATE        >= :END_EFF_DATE2                                                 ");
                strSQL.Append(" ORDER SIBLINGS BY LVL                                                                       ");
                strSQL.Append(" ) as A , ITEM_MASTER I1,ITEM_MASTER I2                                                      ");
                strSQL.Append("   WHERE A.PARENT_ITEM_NO   = I1.ITEM_NO(+)                                                  ");
                strSQL.Append("   AND A.CHILD_ITEM_NO    = I2.ITEM_NO(+)                                                    ");
                db.DbParametersClear();
                db.DbPsetString("PARENT_ITEM_NO", _parent_item_no);
                db.DbPsetInt("BEG_EFF_DATE1", _beg_eff_date);
                db.DbPsetInt("END_EFF_DATE1", _end_eff_date);
                db.DbPsetInt("BEG_EFF_DATE2", _beg_eff_date);
                db.DbPsetInt("END_EFF_DATE2", _end_eff_date);

            }
            else
            {
                strSQL.Append(" SELECT                                                                                      ");
                strSQL.Append(" LVL, PARENT_ITEM_NO, CHILD_ITEM_NO, PROCESS_CD, SUB_GRP_CD, SUB_ACTION_FLAG,                ");
                strSQL.Append(" USAGE_TYPE,USAGE_DEC,USAGE_DENOMINATOR,USAGE_NUMERATOR,BEG_EFF_DATE,END_EFF_DATE,PART_SEQ,  ");
                strSQL.Append(" SORTCOL "); //Add 10.08.06 Ubiq-Sai
                strSQL.Append(" FROM dbo.MBOMTreeViewRvs(@JOC_NO,@CHILD_ITEM_NO,@BEG_EFF_DATE,@END_EFF_DATE)) A             ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I1 ON PARENT_ITEM_NO = I1.ITEM_NO                               ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I2 ON CHILD_ITEM_NO = I2.ITEM_NO                                ");

                db.DbParametersClear();
                db.DbPsetString("@JOC_NO", _joc_cd);
                db.DbPsetString("@CHILD_ITEM_NO", _child_item_no);
                db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
            }
            //strSQL.Append(" ORDER BY PART_SEQ");//UPD BY LIU  //Del 10.08.06 Ubiq-Sai
            strSQL.Append(" ORDER BY SORTCOL   ");     //Add 10.08.06 Ubiq-Sai
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
        /// 品目簡易登録の作業区・工順逆展開表示 
        /// 
        /// 使用画面：MstItemEntryMnt
        /// </summary>
        /// <returns></returns>
        public DataSet GetMfgBomListRcvWithWS()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            strSQL.Append("SELECT                                                                               ");
            strSQL.Append("BM.CHILD_ITEM_NO,	IW.WS_CD,			R.ROUTINE_SEQ,      R.BEG_EFF_DATE,	        ");
            strSQL.Append("R.END_EFF_DATE,	    R.PROCESS_CD,       IW.PTY_NO,          BM.PARENT_ITEM_NO,      ");
            strSQL.Append("I.ITEM_DESC AS ITEM_DESC,                BM.PROCESS_CD PROCESS,                      ");
            strSQL.Append("M.WS_DESC AS WS_DESC, P.PROCESS_DESC AS PROCESS_DESC                                 ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM ROUTINE_MASTER R, ITEM_MASTER I ,WORKSHOP_MASTER M ,PROCESS_MASTER P, ");
                strSQL.Append(" ITEM_WS_MASTER IW,MFG_BOM_MASTER BM");
                strSQL.Append(" WHERE R.ITEM_NO            = :ITEM_NO");
                strSQL.Append("   AND R.ITEM_NO             = I.ITEM_NO(+)");
                strSQL.Append("   AND R.WS_CD               = M.WS_CD(+)");
                strSQL.Append("   AND R.WS_CD               = P.WS_CD(+)");
                strSQL.Append("   AND R.PROCESS_CD          = P.PROCESS_CD(+)");
                strSQL.Append("   AND R.BEG_EFF_DATE        <= :BEG_EFF_DATE");
                strSQL.Append("   AND R.END_EFF_DATE        >= :END_EFF_DATE");
                strSQL.Append("   AND IW.BEG_EFF_DATE       <= :BEG_EFF_DATE");
                strSQL.Append("   AND IW.END_EFF_DATE       >= :END_EFF_DATE");
                strSQL.Append("   AND IW.WS_CD              = R.WS_CD");
                strSQL.Append("   AND IW.ITEM_NO            = R.ITEM_NO");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _child_item_no);
                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("END_EFF_DATE", _end_eff_date);
                db.DbPsetString("PROCESS_CD", _process_cd);
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM   MFG_BOM_MASTER BM                                                                ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_WS_MASTER IW   ON IW.ITEM_NO   = BM.PARENT_ITEM_NO                 ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER M   ON IW.WS_CD     = M.WS_CD                           ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I       ON BM.CHILD_ITEM_NO   = I.ITEM_NO                   ");
                strSQL.Append(" LEFT OUTER JOIN ROUTINE_MASTER R ON BM.PARENT_ITEM_NO   = R.ITEM_NO                     ");
                strSQL.Append(" AND IW.WS_CD = R.WS_CD                                                                  ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER P ON  R.PROCESS_CD = P.PROCESS_CD                        ");
                strSQL.Append(" AND P.WS_CD = R.WS_CD                                                                   ");
                strSQL.Append(" WHERE BM.CHILD_ITEM_NO = @ITEM_NO                                                       ");
                strSQL.Append("   AND R.BEG_EFF_DATE        <= @BEG_EFF_DATE                                            ");
                strSQL.Append("   AND R.END_EFF_DATE        >= @END_EFF_DATE                                            ");
                strSQL.Append(" AND IW.BEG_EFF_DATE     <= @BEG_EFF_DATE                                                ");
                strSQL.Append(" AND IW.END_EFF_DATE     >= @END_EFF_DATE                                                ");
                strSQL.Append("   AND (R.PROCESS_CD     =   BM.PROCESS_CD                                               ");
                strSQL.Append("         OR BM.PROCESS_CD IN ('','*') )                                                  ");
                strSQL.Append("   AND R.BEG_EFF_DATE        <= @BEG_EFF_DATE                                            ");
                strSQL.Append("   AND R.END_EFF_DATE        >= @END_EFF_DATE                                            ");
              
                db.DbPsetString("@ITEM_NO", _child_item_no);
                db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
            }
            strSQL.Append(" ORDER BY BM.PARENT_ITEM_NO,IW.WS_CD,R.ROUTINE_SEQ       ");
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
        /// 選択した子品目の、品目情報と部品表情報を表示する
        /// 
        /// 使用画面：MstItemEntryMnt
        /// </summary>
        /// <returns></returns>
        public int GetDetailofItem()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT ");
            strSQL.Append(" M.PARENT_ITEM_NO,	M.PART_SEQ,			M.CHILD_ITEM_NO,    M.BEG_EFF_DATE,	        ");
            strSQL.Append(" M.END_EFF_DATE,	    M.USAGE_TYPE,       M.USAGE_DEC,        M.USAGE_DENOMINATOR,    ");
            strSQL.Append(" M.SUB_GRP_CD,	    M.SUB_ACTION_FLAG,  M.STOP_EXPL_FLAG,	M.STRUCTURE_DUMMY_FLAG, ");
            strSQL.Append(" M.ENTRY_LT,	        M.USAGE_NUMERATOR,  M.DEFECT_PCT,       M.PROCESS_CD,           ");
            strSQL.Append(" M.MBOM_SUB_CD,                                                                      ");//ADD UBIQ-LIU 2010/05/21
            strSQL.Append(" I.ITEM_DESC AS CHILD_ITEM_DESC,         I.ITEM_TYPE AS CHILD_ITEM_TYPE,             ");
            strSQL.Append(" I.DRAWING_NO AS CHILD_DRAWING_NO,       I.SPEC_DESC AS CHILD_SPEC_DESC,             ");
            strSQL.Append(" I.PO_TYPE AS CHILD_PO_TYPE,             I.CATG_CD AS CHILD_CATG_CD,                 ");
            strSQL.Append(" I.ITEM_UMSR AS CHILD_ITEM_UMSR,         0 STD_PRC,          SP.DATA_CHAR UMSR_DESC  ");
            strSQL.Append(",I.PUR_LOT_SIZE  ");    // 2015.08.13
            
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM MFG_BOM_MASTER M, ITEM_MASTER I , STD_PRICE_MASTER S");
                strSQL.Append(" WHERE M.PARENT_ITEM_NO   = :PARENT_ITEM_NO");
                strSQL.Append(" AND M.CHILD_ITEM_NO    = :CHILD_ITEM_NO");
                strSQL.Append(" AND M.PART_SEQ    = :PART_SEQ");
                strSQL.Append(" AND M.BEG_EFF_DATE    <= :BEG_EFF_DATE");
                strSQL.Append(" AND M.END_EFF_DATE    >= :END_EFF_DATE");
                strSQL.Append(" AND S.BEG_EFF_DATE    <= :BEG_EFF_DATE");
                strSQL.Append(" AND S.END_EFF_DATE    >= :END_EFF_DATE");
                strSQL.Append(" AND S.ITEM_NO    = :CHILD_ITEM_NO");
                strSQL.Append(" AND M.CHILD_ITEM_NO    = I.ITEM_NO(+)");

                db.DbParametersClear();
                db.DbPsetString("PARENT_ITEM_NO", _parent_item_no);
                db.DbPsetString("CHILD_ITEM_NO", _child_item_no);
                db.DbPsetInt("PART_SEQ", _part_seq);
                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("END_EFF_DATE", _end_eff_date);
            }
            else
            {
                strSQL.Append(" FROM MFG_BOM_MASTER M ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I ON M.CHILD_ITEM_NO    = I.ITEM_NO");
                //strSQL.Append(" LEFT OUTER JOIN STD_PRICE_MASTER S ON  S.BEG_EFF_DATE <= @BEG_EFF_DATE"); // IMV3
                //strSQL.Append(" AND S.END_EFF_DATE >= @END_EFF_DATE AND S.ITEM_NO    = @CHILD_ITEM_NO");
                strSQL.Append(" LEFT OUTER JOIN SYSTEM_PARAMETER SP ON SP.KEY01 = 'ITEM_UMSR' AND SP.KEY02 = I.ITEM_UMSR ");
                strSQL.Append(" WHERE M.PARENT_ITEM_NO = @PARENT_ITEM_NO");
                strSQL.Append(" AND M.CHILD_ITEM_NO  = @CHILD_ITEM_NO");
                strSQL.Append(" AND M.PART_SEQ    = @PART_SEQ");
                strSQL.Append(" AND M.BEG_EFF_DATE    <= @BEG_EFF_DATE");
                strSQL.Append(" AND M.END_EFF_DATE    >= @END_EFF_DATE");

                db.DbParametersClear();
                db.DbPsetString("@PARENT_ITEM_NO", _parent_item_no);
                db.DbPsetString("@CHILD_ITEM_NO", _child_item_no);
                db.DbPsetInt("@PART_SEQ", _part_seq);
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
                _parent_item_no = db.Row("PARENT_ITEM_NO");
                _part_seq = int.Parse(db.Row("PART_SEQ"));
                _child_item_no = db.Row("CHILD_ITEM_NO");
                _beg_eff_date = int.Parse(db.Row("BEG_EFF_DATE"));
                _end_eff_date = int.Parse(db.Row("END_EFF_DATE"));
                _usage_type = int.Parse(db.Row("USAGE_TYPE"));
                _usage_dec = double.Parse(db.Row("USAGE_DEC"));
                _usage_denominator = double.Parse(db.Row("USAGE_DENOMINATOR"));
                _usage_numerator = double.Parse(db.Row("USAGE_NUMERATOR"));
                _defect_pct = double.Parse(db.Row("DEFECT_PCT"));
                _sub_grp_cd = db.Row("SUB_GRP_CD");
                _sub_action_flag = int.Parse(db.Row("SUB_ACTION_FLAG"));
                _stop_expl_flag = int.Parse(db.Row("STOP_EXPL_FLAG"));
                _structure_dummy_flag = int.Parse(db.Row("STRUCTURE_DUMMY_FLAG"));
                _entry_lt = double.Parse(db.Row("ENTRY_LT"));
                _child_catg_cd = db.Row("CHILD_CATG_CD");
                _child_drawing_no = db.Row("CHILD_DRAWING_NO");
                _child_spec_desc = db.Row("CHILD_SPEC_DESC");
                _child_item_desc = db.Row("CHILD_ITEM_DESC");
                _child_item_type = db.Row("CHILD_ITEM_TYPE");
                _child_po_type = int.Parse(db.Row("CHILD_PO_TYPE"));
                _child_item_umsr = db.Row("CHILD_ITEM_UMSR");
                _process_cd = db.Row("PROCESS_CD");
                _mbom_sub_cd = db.Row("MBOM_SUB_CD");
                _pur_lot_size = int.Parse(db.Row("PUR_LOT_SIZE"));   // 2015.08.13
                if (db.Row("STD_PRC") != "")
                {
                    _std_prc = double.Parse(db.Row("STD_PRC"));
                }
                _umsr_desc = db.Row("UMSR_DESC");
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }
        /// <summary>
        /// 選択した子品目の作業場所工順を表示する
        /// 
        /// 使用画面：MstItemEntryMnt
        /// </summary>
        /// <returns></returns>
        public DataSet GetDetailofWS()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT                                                                                                       ");
            strSQL.Append(" IW.PTY_NO,IW.BEG_EFF_DATE,IW.END_EFF_DATE,IW.WS_CD,IW.REP_ROUTINE_ITEM_NO,                                  ");
            strSQL.Append(" IW.REP_ROUTINE_WS_CD,IW.INSP_LT,IW.PLANT_LT,W1.WHS_DESC COMPL_WHS,W2.WHS_DESC SEMI_WHS,                     ");
            strSQL.Append(" W3.WHS_DESC DISB_WHS,W4.WHS_DESC BOND_SEMI_WHS,W5.WHS_DESC BOND_DISB_WHS,W.WS_DESC,P.PROCESS_DESC,          ");
            strSQL.Append(" R.ROUTINE_SEQ,R.BEG_EFF_DATE BEG_EFF_DATE1,R.END_EFF_DATE END_EFF_DATE1,R.PROCESS_CD,R.LT_TYPE,             ");
            strSQL.Append(" R.NEXT_PROC_CONT_FLAG,R.MFG_LT,R.DAILY_PROD_QTY,R.SETUP_TIME,R.UNIT_TIME,                                   ");
            strSQL.Append(" IW.ITEM_NO, I.ITEM_DESC ,R.MH_ADOPT_FLAG                                                                                    ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM WORKSHOP_MASTER W, ITEM_WS_MASTER IW,ROUTINE_MASTER R,PROCESS_MASTER P         ");
                strSQL.Append(" WAREHOUSE_MASTER W1, WAREHOUSE_MASTER W2, WAREHOUSE_MASTER W3 ,WAREHOUSE_MASTER W4, ");
                strSQL.Append(" WAREHOUSE_MASTER W5                                                                 ");
                strSQL.Append(" WHERE  IW.COMPL_WHS     = W1.WHS_CD(+)                                              ");
                strSQL.Append(" AND IW.SEMI_WHS         = W2.WHS_CD(+)                                              ");
                strSQL.Append(" AND IW.DISB_WHS         = W3.WHS_CD(+)                                              ");
                strSQL.Append(" AND IW.BOND_SEMI_WHS    =   W4.WHS_CD(+)    ");
                strSQL.Append(" AND IW.BOND_DISB_WHS    =   W5.WHS_CD(+)    ");
                strSQL.Append(" AND IW.PROCESS_CD       =   P.PROCESS_CD(+) ");
                strSQL.Append(" AND IW.ITEM_NO       =      :ITEM_NO        ");
                strSQL.Append(" AND W.WS_CD           =     IW.WS_CD        ");
                strSQL.Append(" AND IW.BEG_EFF_DATE   <=    :BEG_EFF_DATE   ");
                strSQL.Append(" AND IW.END_EFF_DATE   >=    :END_EFF_DATE   ");
                strSQL.Append(" AND R.ITEM_NO        =      :ITEM_NO        ");
                strSQL.Append(" AND R.BEG_EFF_DATE   <=     :BEG_EFF_DATE   ");
                strSQL.Append(" AND R.END_EFF_DATE   >=     :END_EFF_DATE   ");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _parent_item_no);
                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("END_EFF_DATE", _end_eff_date);
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM ITEM_WS_MASTER IW                                                      ");
                strSQL.Append(" LEFT OUTER JOIN WORKSHOP_MASTER  W  ON W.WS_CD      = IW.WS_CD              ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I       ON IW.ITEM_NO   = I.ITEM_NO             ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W1 ON IW.COMPL_WHS = W1.WHS_CD             ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W2 ON IW.SEMI_WHS  = W2.WHS_CD             ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W3 ON IW.DISB_WHS  = W3.WHS_CD             ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W4 ON IW.BOND_SEMI_WHS  =  W4.WHS_CD       ");
                strSQL.Append(" LEFT OUTER JOIN WAREHOUSE_MASTER W5 ON IW.BOND_DISB_WHS  =  W5.WHS_CD       ");
                strSQL.Append(" LEFT OUTER JOIN ROUTINE_MASTER R ON R.WS_CD      =   IW.WS_CD               ");
                if (_beg_eff_date != 0)
                {
                    strSQL.Append(" AND R.END_EFF_DATE >= @END_EFF_DATE                                     ");
                }
                if (_end_eff_date != 0)
                {
                    strSQL.Append(" AND R.BEG_EFF_DATE <= @BEG_EFF_DATE                                     ");
                }
                strSQL.Append(" AND R.ITEM_NO    =   IW.ITEM_NO                                             ");
                strSQL.Append(" LEFT OUTER JOIN PROCESS_MASTER P ON P.PROCESS_CD = R.PROCESS_CD             ");
                strSQL.Append(" AND P.WS_CD = IW.WS_CD                                                      ");
                strSQL.Append(" WHERE IW.ITEM_NO =   @ITEM_NO                                               ");
                if (_beg_eff_date != 0)
                {
                    db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                    strSQL.Append(" AND IW.BEG_EFF_DATE    <= @BEG_EFF_DATE                                     ");
                }
                if (_end_eff_date != 0)
                {
                    db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
                    strSQL.Append(" AND IW.END_EFF_DATE    >= @END_EFF_DATE                                     ");
                }
                db.DbPsetString("@ITEM_NO", _parent_item_no);
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
        /// 選択した子品目の購買・単価を表示する
        /// not complete
        /// 使用画面：MstItemEntryMnt
        /// </summary>
        /// <returns></returns>
        public DataSet GetDetailofPurchase()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT                                                                                          ");
            strSQL.Append(" P.PTY_NO,   P.BEG_EFF_DATE,     P.END_EFF_DATE, P.VENDOR_CD,    P.BUYER_CD, P.VENDOR_ITEM_NO,   ");
            strSQL.Append(" P.VENDOR_ITEM_DESC,     P.PUR_UMSR,     P.MIN_PUR_QTY,  P.PUR_LOT_SIZE,     P.DELV_LT_TYPE,     ");
            strSQL.Append(" P.DELV_LT_PROPORTION,   P.DELV_LT,      P.STD_LOT_SIZE, P.TRANSFER_LT,  P.INSP_LT,  P.INSP_CD,  ");
            //strSQL.Append(" PP.BEG_EFF_DATE BEG_EFF_DATE1,    PP.END_EFF_DATE END_EFF_DATE1, PP.TENTATIVE_PRC,  PP.ACT_PRC, ");
            strSQL.Append(" 0 UNIT_PRC_TYPE,       0 UNIT_PRC_BASE,               0 TENTATIVE_PRC,   0 ACT_PRC,         ");//UPD 20090624 UBIQ-LIU
            strSQL.Append(" 0 DUTY_PCT,        '' ACT_CUR,         0 TAX_TYPE,    P.ITEM_NO,      I.ITEM_DESC,            ");
            strSQL.Append(" V.VENDOR_NAME                                                                                   ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PURCHASE_PRICE_MASTER PP, PURCHASE_MASTER P    ");
                strSQL.Append(" WHERE P.ITEM_NO        = :ITEM_NO                   ");
                strSQL.Append(" AND S.BEG_EFF_DATE    <= :BEG_EFF_DATE              ");
                strSQL.Append(" AND S.END_EFF_DATE    >= :END_EFF_DATE              ");
                strSQL.Append(" AND S.ITEM_NO          = :CHILD_ITEM_NO             ");
                strSQL.Append(" AND M.CHILD_ITEM_NO    = I.ITEM_NO(+)               ");

                db.DbParametersClear();
                db.DbPsetString("ITEM_NO", _parent_item_no);
                db.DbPsetInt("BEG_EFF_DATE", _beg_eff_date);
                db.DbPsetInt("END_EFF_DATE", _end_eff_date);
            }
            else
            {
                db.DbParametersClear();
                strSQL.Append(" FROM PURCHASE_MASTER P                                                  ");
                strSQL.Append(" LEFT OUTER JOIN ITEM_MASTER I     ON P.ITEM_NO    = I.ITEM_NO           ");
                strSQL.Append(" LEFT OUTER JOIN VENDOR_MASTER V   ON V.VENDOR_CD  = P.VENDOR_CD         ");
                //strSQL.Append(" AND V.BEG_EFF_DATE <= @BEG_EFF_DATE                                     ");//DEL 20090323 UBIQ-LIU
                //strSQL.Append(" AND V.END_EFF_DATE >= @END_EFF_DATE                                     ");
                //strSQL.Append(" LEFT OUTER JOIN PURCHASE_PRICE_MASTER PP ON  P.ITEM_NO    = PP.ITEM_NO  ");   // imv3
                //strSQL.Append(" AND P.VENDOR_CD  = PP.VENDOR_CD                                         ");//Upd 20090317 UBIQ-LIU
                //if (_beg_eff_date != 0)
                //{
                //    strSQL.Append(" AND PP.END_EFF_DATE >= @END_EFF_DATE                                ");
                //    strSQL.Append(" AND PP.BEG_EFF_DATE <= @BEG_EFF_DATE                                ");
                //}
                strSQL.Append(" WHERE P.ITEM_NO = @ITEM_NO                                              ");
                if (_beg_eff_date != 0)
                {
                    strSQL.Append(" AND P.BEG_EFF_DATE <= @BEG_EFF_DATE                                 ");
                    db.DbPsetInt("@BEG_EFF_DATE", _beg_eff_date);
                }
                if (_end_eff_date != 0)
                {
                    strSQL.Append(" AND P.END_EFF_DATE >= @END_EFF_DATE                                 ");
                    db.DbPsetInt("@END_EFF_DATE", _end_eff_date);
                }

                db.DbPsetString("@ITEM_NO", _parent_item_no);
            }
            strSQL.Append(" ORDER BY  P.PTY_NO  ");

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
        /// 部品表コピー
        /// 
        /// <para>使用画面：MfgBOMMnt</para>
        /// </summary>
        public int BomCopy()
        {
            ComDB db = new ComDB(_db_type);
            int rtn = 0;

            db.DbParametersClear();

            db.DbPsetInt("RET", rtn, ComConst.DB_RTN);
            db.DbPsetString("@I_TO_JOC_CD", _to_joc_cd, ComConst.DB_IN);
            db.DbPsetString("@I_TO_ITEM_NO", _to_item_no, ComConst.DB_IN);
            db.DbPsetString("@I_FROM_JOC_CD", _from_joc_cd, ComConst.DB_IN);
            db.DbPsetString("@I_FROM_ITEM_NO", _from_item_no, ComConst.DB_IN);
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
            rtn = db.DbStored("SP_MFG_BOM_COPY");
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
