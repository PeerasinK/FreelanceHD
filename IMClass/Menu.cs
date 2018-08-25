using System;
using System.Web;
//using System.Web.Services;
//using System.Web.Services.Protocols;
using System.Text;
using System.Data;
using System.Web.Configuration;

/// <summary>
/// メニュークラス
/// </summary>
namespace IMClass
{
    public class IM_Menu
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public IM_Menu()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }

        public IM_Menu(string p_user_id, int p_lang)
        {
            //_company_cd = p_company_cd;
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
        //protected string _company_cd = "*";
        protected string _menu_grp = "";
        protected string _back_menu_grp = "";
        protected int _menu_grp_type = 0;
        protected string _user_id = "*";
        protected string _menu_grp_desc1 = "";
        protected string _menu_grp_desc2 = "";
        protected string _menu_grp_desc3 = "";
        protected string _menu_grp_desc4 = "";
        protected int _menu_no = 0;
        protected string _menu_item_label1 = "";
        protected string _menu_item_label2 = "";
        protected string _menu_item_label3 = "";
        protected string _menu_item_label4 = "";
        protected int _apl_type = 0;
        protected string _program_id = "";
        protected int _lvl = 0;
        protected int _glvl = 0;    //Add 2013.09.02 Ubiq-Sai
        protected int _maxlvl = 0;
        protected string _imageurl = "";
        protected int _auth_type = 0;
        protected string _dept_cd = "*";
        protected string _role = "*";
        protected int _executable_flag = 0;
        protected string _navigateurl = "";

        protected DateTime _entry_date = DateTime.Now;
        protected DateTime _chg_date = DateTime.Now;
        protected string _chg_user_id = "";
        protected int _update_cntr = 0;
        protected string _dbmsg = "";
        protected string _strErr = "";
        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        public int lang
        {
            get { return _lang; }
            set { _lang = value; }
        }

        //public string company_cd
        //{
        //    get { return _company_cd; }
        //    set { _company_cd = value; }
        //}

        public string menu_grp
        {
            get { return _menu_grp; }
            set { _menu_grp = value; }
        }

        public string back_menu_grp
        {
            get { return _back_menu_grp; }
            set { _back_menu_grp = value; }
        }

        public int menu_grp_type
        {
            get { return _menu_grp_type; }
            set { _menu_grp_type = value; }
        }
        
        public string user_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        
        public string menu_grp_desc1
        {
            get { return _menu_grp_desc1; }
            set { _menu_grp_desc1 = value; }
        }
        
        public string menu_grp_desc2
        {
            get { return _menu_grp_desc2; }
            set { _menu_grp_desc2 = value; }
        }
        
        public string menu_grp_desc3
        {
            get { return _menu_grp_desc3; }
            set { _menu_grp_desc3 = value; }
        }

        public string menu_grp_desc4
        {
            get { return _menu_grp_desc4; }
            set { _menu_grp_desc4 = value; }
        }

        public int menu_no
        {
            get { return _menu_no; }
            set { _menu_no = value; }
        }
        
        public string menu_item_label1
        {
            get { return _menu_item_label1; }
            set { _menu_item_label1 = value; }
        }
        
        public string menu_item_label2
        {
            get { return _menu_item_label2; }
            set { _menu_item_label2 = value; }
        }
        
        public string menu_item_label3
        {
            get { return _menu_item_label3; }
            set { _menu_item_label3 = value; }
        }

        public string menu_item_label4
        {
            get { return _menu_item_label4; }
            set { _menu_item_label4 = value; }
        }

        public int apl_type
        {
            get { return _apl_type; }
            set { _apl_type = value; }
        }
        
        public string program_id
        {
            get { return _program_id; }
            set { _program_id = value; }
        }

        public int lvl
        {
            get { return _lvl; }
            set { _lvl = value; }
        }
        //Add 2013.09.02 Ubiq-Sai Begin
        public int glvl
        {
            get { return _glvl; }
            set { _glvl = value; }
        }
        //Add 2013.09.02 Ubiq-Sai End
        public int maxlvl
        {
            get { return _maxlvl; }
            set { _maxlvl = value; }
        }

        public string imageurl
        {
            get { return _imageurl; }
            set { _imageurl = value; }
        }

        public int auth_type
        {
            get { return _auth_type; }
            set { _auth_type = value; }
        }

        public string dept_cd
        {
            get { return _dept_cd; }
            set { _dept_cd = value; }
        }
        
        public string role
        {
            get { return _role; }
            set { _role = value; }
        }
        
        public int executable_flag
        {
            get { return _executable_flag; }
            set { _executable_flag = value; }
        }

        public string navigateurl
        {
            get { return _navigateurl; }
            set { _navigateurl = value; }
        }
        
        public DateTime entry_date
        {
            get { return _entry_date; }
            set { _entry_date = value; }
        }
        
        public DateTime chg_date
        {
            get { return _chg_date; }
            set { _chg_date = value; }
        }
        
        public string chg_user_id
        {
            get { return _chg_user_id; }
            set { _chg_user_id = value; }
        }
        
        public int update_cntr
        {
            get { return _update_cntr; }
            set { _update_cntr = value; }
        }
        
        public string dbmsg 
        { 
            get { return _dbmsg; } 
            set { _dbmsg = value; } 
        }
        
        public string strErr 
        { 
            get { return _strErr; } 
            set { _strErr = value; } 
        }
        #endregion

        /// <summary>
        /// メニューグループの追加
        /// </summary>
        public int InsertMenuGrp()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            // Insert
            strSQL = new StringBuilder();
            if (_db_type == "ORACLE")
            {
                strSQL.Append("INSERT INTO MENU_GROUP ");
                strSQL.Append("(");
                //strSQL.Append("COMPANY_CD, MENU_GRP, MENU_GRP_TYPE, USER_ID,");
                strSQL.Append("MENU_GRP, MENU_GRP_TYPE,");
                strSQL.Append("MENU_GRP_DESC1, MENU_GRP_DESC2, MENU_GRP_DESC3, MENU_GRP_DESC4,");
                strSQL.Append("DEPT_CD, ENTRY_DATE, CHG_DATE, CHG_USER_ID, UPDATE_CNTR");
                strSQL.Append(") VALUES (");
                //strSQL.Append(":COMPANY_CD, :MENU_GRP, :MENU_GRP_TYPE, :USER_ID,");
                strSQL.Append(":MENU_GRP, :MENU_GRP_TYPE,");
                strSQL.Append(":MENU_GRP_DESC1, :MENU_GRP_DESC2, :MENU_GRP_DESC3, :MENU_GRP_DESC4,");
                strSQL.Append(":DEPT_CD, :ENTRY_DATE, :CHG_DATE, :CHG_USER_ID, :UPDATE_CNTR)");

                db.DbParametersClear();

                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetString("MENU_GRP", _menu_grp);
                db.DbPsetInt("MENU_GRP_TYPE", _menu_grp_type);
                //db.DbPsetString("USER_ID", _user_id);
                db.DbPsetString("MENU_GRP_DESC1", _menu_grp_desc1);
                db.DbPsetString("MENU_GRP_DESC2", _menu_grp_desc2);
                db.DbPsetString("MENU_GRP_DESC3", _menu_grp_desc3);
                db.DbPsetString("MENU_GRP_DESC4", _menu_grp_desc4);
                db.DbPsetString("DEPT_CD", _dept_cd);
                db.DbPsetDate("ENTRY_DATE", DateTime.Now);
                db.DbPsetDate("CHG_DATE", DateTime.Now);
                db.DbPsetString("CHG_USER_ID", _chg_user_id);
                db.DbPsetInt("UPDATE_CNTR", _update_cntr);
            }
            else
            {
                strSQL.Append("INSERT INTO MENU_GROUP ");
                strSQL.Append("(");
                //strSQL.Append("COMPANY_CD, MENU_GRP, MENU_GRP_TYPE, USER_ID,");
                strSQL.Append("MENU_GRP, MENU_GRP_TYPE,");
                strSQL.Append("MENU_GRP_DESC1, MENU_GRP_DESC2, MENU_GRP_DESC3, MENU_GRP_DESC4,");
                strSQL.Append("DEPT_CD, ENTRY_DATE, CHG_DATE, CHG_USER_ID, UPDATE_CNTR");
                strSQL.Append(") VALUES (");
                //strSQL.Append("@COMPANY_CD, @MENU_GRP, @MENU_GRP_TYPE, @USER_ID,");
                strSQL.Append("@MENU_GRP, @MENU_GRP_TYPE,");
                strSQL.Append("@MENU_GRP_DESC1, @MENU_GRP_DESC2, @MENU_GRP_DESC3, @MENU_GRP_DESC4,");
                strSQL.Append("@DEPT_CD, @ENTRY_DATE, @CHG_DATE, @CHG_USER_ID, @UPDATE_CNTR)");

                db.DbParametersClear();

                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetString("@MENU_GRP", _menu_grp);
                db.DbPsetInt("@MENU_GRP_TYPE", _menu_grp_type);
                //db.DbPsetString("@USER_ID", _user_id);
                db.DbPsetString("@MENU_GRP_DESC1", _menu_grp_desc1);
                db.DbPsetString("@MENU_GRP_DESC2", _menu_grp_desc2);
                db.DbPsetString("@MENU_GRP_DESC3", _menu_grp_desc3);
                db.DbPsetString("@MENU_GRP_DESC4", _menu_grp_desc4);
                db.DbPsetString("@DEPT_CD", _dept_cd);
                db.DbPsetDate("@ENTRY_DATE", DateTime.Now);
                db.DbPsetDate("@CHG_DATE", DateTime.Now);
                db.DbPsetString("@CHG_USER_ID", _chg_user_id);
                db.DbPsetInt("@UPDATE_CNTR", _update_cntr);
            }

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

        /// <summary>
        /// メニューグループの変更
        /// </summary>
        public int UpdateMenuGrp()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            if (_db_type == "ORACLE")
            {
                strSQL.Append("UPDATE MENU_GROUP ");
                strSQL.Append("SET ");
                strSQL.Append("MENU_GRP_TYPE = :MENU_GRP_TYPE,");
                //strSQL.Append("USER_ID = :USER_ID,");
                strSQL.Append("MENU_GRP_DESC1 = :MENU_GRP_DESC1,");
                strSQL.Append("MENU_GRP_DESC2 = :MENU_GRP_DESC2,");
                strSQL.Append("MENU_GRP_DESC3 = :MENU_GRP_DESC3,");
                strSQL.Append("MENU_GRP_DESC4 = :MENU_GRP_DESC4,");
                strSQL.Append("DEPT_CD = :DEPT_CD,");
                strSQL.Append("CHG_DATE = :CHG_DATE,");
                strSQL.Append("CHG_USER_ID = :CHG_USER_ID,");
                strSQL.Append("UPDATE_CNTR = UPDATE_CNTR + 1");
                //strSQL.Append(" WHERE COMPANY_CD = :COMPANY_CD");
                strSQL.Append("   WHERE MENU_GRP = :MENU_GRP");

                db.DbParametersClear();

                db.DbPsetInt("MENU_GRP_TYPE", _menu_grp_type);
                //db.DbPsetString("USER_ID", _user_id);
                db.DbPsetString("MENU_GRP_DESC1", _menu_grp_desc1);
                db.DbPsetString("MENU_GRP_DESC2", _menu_grp_desc2);
                db.DbPsetString("MENU_GRP_DESC3", _menu_grp_desc3);
                db.DbPsetString("MENU_GRP_DESC4", _menu_grp_desc4);
                db.DbPsetString("DEPT_CD", _dept_cd);
                db.DbPsetDate("CHG_DATE", DateTime.Now);
                db.DbPsetString("CHG_USER_ID", _chg_user_id);
                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetString("MENU_GRP", _menu_grp);
            }
            else
            {
                strSQL.Append("UPDATE MENU_GROUP ");
                strSQL.Append("SET ");
                strSQL.Append("MENU_GRP_TYPE = @MENU_GRP_TYPE,");
                //strSQL.Append("USER_ID = @USER_ID,");
                strSQL.Append("MENU_GRP_DESC1 = @MENU_GRP_DESC1,");
                strSQL.Append("MENU_GRP_DESC2 = @MENU_GRP_DESC2,");
                strSQL.Append("MENU_GRP_DESC3 = @MENU_GRP_DESC3,");
                strSQL.Append("MENU_GRP_DESC4 = @MENU_GRP_DESC4,");
                strSQL.Append("DEPT_CD = @DEPT_CD,");
                strSQL.Append("CHG_DATE = @CHG_DATE,");
                strSQL.Append("CHG_USER_ID = @CHG_USER_ID,");
                strSQL.Append("UPDATE_CNTR = UPDATE_CNTR + 1");
                //strSQL.Append(" WHERE COMPANY_CD = @COMPANY_CD");
                strSQL.Append("   WHERE MENU_GRP = @MENU_GRP");

                db.DbParametersClear();

                db.DbPsetInt("@MENU_GRP_TYPE", _menu_grp_type);
                //db.DbPsetString("USER_ID", _user_id);
                db.DbPsetString("@MENU_GRP_DESC1", _menu_grp_desc1);
                db.DbPsetString("@MENU_GRP_DESC2", _menu_grp_desc2);
                db.DbPsetString("@MENU_GRP_DESC3", _menu_grp_desc3);
                db.DbPsetString("@MENU_GRP_DESC4", _menu_grp_desc4);
                db.DbPsetString("@DEPT_CD", _dept_cd);
                db.DbPsetDate("@CHG_DATE", DateTime.Now);
                db.DbPsetString("@CHG_USER_ID", _chg_user_id);
                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetString("@MENU_GRP", _menu_grp);
            }

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

        /// <summary>
        /// メニューグループの削除
        /// </summary>
        public int DeleteMenuGrp()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            if (_db_type == "ORACLE")
            {
                strSQL.Append("DELETE FROM MENU_GROUP ");
                //strSQL.Append(" WHERE COMPANY_CD = :COMPANY_CD");
                strSQL.Append("   WHERE MENU_GRP = :MENU_GRP");

                db.DbParametersClear();

                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetString("MENU_GRP", _menu_grp);
            }
            else
            {
                strSQL.Append("DELETE FROM MENU_GROUP ");
                //strSQL.Append(" WHERE COMPANY_CD = @COMPANY_CD");
                strSQL.Append("   WHERE MENU_GRP = @MENU_GRP");

                db.DbParametersClear();

                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetString("@MENU_GRP", _menu_grp);
            }

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

        /// <summary>
        /// メニューグループ一覧の取得
        /// 
        /// 使用画面：MntUserMst
        /// </summary>
        public DataSet GetMenuGrpList()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            //strSQL.Append("SELECT MENU_GRP, MENU_GRP_TYPE, USER_ID, MENU_GRP_DESC1, MENU_GRP_DESC2, MENU_GRP_DESC3, ");
            strSQL.Append("SELECT MENU_GRP, MENU_GRP_TYPE, MENU_GRP_DESC1, MENU_GRP_DESC2, MENU_GRP_DESC3, MENU_GRP_DESC4,");

            switch (_lang)
            {
                case 2:
                    strSQL.Append(" MENU_GRP_DESC2 AS MENU_GRP_DESC, ");
                    break;

                case 3:
                    strSQL.Append(" MENU_GRP_DESC3 AS MENU_GRP_DESC, ");
                    break;

                case 4:
                    strSQL.Append(" MENU_GRP_DESC4 AS MENU_GRP_DESC, ");
                    break;

                default:
                    strSQL.Append(" MENU_GRP_DESC1 AS MENU_GRP_DESC, ");
                    break;
            }

            strSQL.Append(" DEPT_CD, ENTRY_DATE, CHG_DATE, CHG_USER_ID,");
            strSQL.Append(" UPDATE_CNTR");
            strSQL.Append(" FROM MENU_GROUP ");
            strSQL.Append(" ORDER BY MENU_GRP");
            
            //if (_db_type == "ORACLE")
            //{
            //    strSQL.Append(" WHERE (COMPANY_CD = :COMPANY_CD OR COMPANY_CD = '*')");
            //    strSQL.Append(" ORDER BY MENU_GRP");
            //    db.DbParametersClear();
            //    db.DbPsetString("COMPANY_CD", _company_cd);
            //}
            //else
            //{
            //    strSQL.Append(" WHERE (COMPANY_CD = @COMPANY_CD OR COMPANY_CD = '*')");
            //    strSQL.Append(" ORDER BY MENU_GRP");
            //    db.DbParametersClear();
            //    db.DbPsetString("@COMPANY_CD", _company_cd);
            //}

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "info");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }

                if (db.State() == ConnectionState.Open) db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open) db.DbClose();
                return null;
            }

        }

        /// <summary>
        /// メニューグループ詳細の取得
        /// </summary>
        public int GetMenuGrpDetail()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            //strSQL.Append("SELECT MENU_GRP_TYPE, USER_ID, MENU_GRP_DESC1, MENU_GRP_DESC2, MENU_GRP_DESC3, ");
            strSQL.Append("SELECT MENU_GRP_TYPE, MENU_GRP_DESC1, MENU_GRP_DESC2, MENU_GRP_DESC3, MENU_GRP_DESC4, ");
            strSQL.Append(" DEPT_CD, ENTRY_DATE, CHG_DATE, CHG_USER_ID,");
            strSQL.Append(" UPDATE_CNTR");
            strSQL.Append(" FROM MENU_GROUP ");
            
            if (_db_type == "ORACLE")
            {
                //strSQL.Append(" WHERE COMPANY_CD = :COMPANY_CD");
                strSQL.Append("   WHERE MENU_GRP = :MENU_GRP");

                db.DbParametersClear();

                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetString("MENU_GRP", _menu_grp);
            }
            else
            {
                //strSQL.Append(" WHERE COMPANY_CD = @COMPANY_CD");
                strSQL.Append("   WHERE MENU_GRP = @MENU_GRP");

                db.DbParametersClear();

                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetString("@MENU_GRP", _menu_grp);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _menu_grp_type = int.Parse(db.Row("MENU_GRP_TYPE"));
                //_user_id = db.Row("USER_ID");
                _menu_grp_desc1 = db.Row("MENU_GRP_DESC1");
                _menu_grp_desc2 = db.Row("MENU_GRP_DESC2");
                _menu_grp_desc3 = db.Row("MENU_GRP_DESC3");
                _menu_grp_desc4 = db.Row("MENU_GRP_DESC4");
                _dept_cd = db.Row("DEPT_CD");
                _entry_date = DateTime.Parse(db.Row("ENTRY_DATE"));
                _chg_date = DateTime.Parse(db.Row("CHG_DATE"));
                _chg_user_id = db.Row("CHG_USER_ID");
                _update_cntr = int.Parse(db.Row("UPDATE_CNTR"));
            }

            if (db.State() == ConnectionState.Open) db.DbClose();

            return rtn;
        }

        /// <summary>
        /// メニュー項目の追加
        /// </summary>
        public int InsertItemGrp()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            // Insert
            strSQL = new StringBuilder();
            if (_db_type == "ORACLE")
            {
                strSQL.Append("INSERT INTO MENU_ITEM ");
                strSQL.Append("(");
                //strSQL.Append("COMPANY_CD, MENU_GRP, MENU_NO,");
                strSQL.Append("MENU_GRP, MENU_NO,");
                strSQL.Append("MENU_ITEM_LABEL1, MENU_ITEM_LABEL2, MENU_ITEM_LABEL3, MENU_ITEM_LABEL4,");
                strSQL.Append("APL_TYPE, PROGRAM_ID, LEVEL, IMAGEURL,");
                strSQL.Append("ENTRY_DATE, CHG_DATE, CHG_USER_ID, UPDATE_CNTR");
                strSQL.Append(") VALUES (");
                //strSQL.Append(":COMPANY_CD, :MENU_GRP, :MENU_NO,");
                strSQL.Append(":MENU_GRP, :MENU_NO,");
                strSQL.Append(":MENU_ITEM_LABEL1, :MENU_ITEM_LABEL2, :MENU_ITEM_LABEL3, :MENU_ITEM_LABEL4,");
                strSQL.Append(":APL_TYPE, :PROGRAM_ID, :LVL, :IMAGEURL,");
                strSQL.Append(":ENTRY_DATE, :CHG_DATE, :CHG_USER_ID, :UPDATE_CNTR)");

                db.DbParametersClear();

                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetString("MENU_GRP", _menu_grp);
                db.DbPsetInt("MENU_NO", _menu_no);
                db.DbPsetString("MENU_ITEM_LABEL1", _menu_item_label1);
                db.DbPsetString("MENU_ITEM_LABEL2", _menu_item_label2);
                db.DbPsetString("MENU_ITEM_LABEL3", _menu_item_label3);
                db.DbPsetString("MENU_ITEM_LABEL4", _menu_item_label4);
                db.DbPsetInt("APL_TYPE", _apl_type);
                db.DbPsetString("PROGRAM_ID", _program_id);
                db.DbPsetInt("LVL", _lvl);
                db.DbPsetString("IMAGEURL", _imageurl);
                db.DbPsetDate("ENTRY_DATE", DateTime.Now);
                db.DbPsetDate("CHG_DATE", DateTime.Now);
                db.DbPsetString("CHG_USER_ID", _chg_user_id);
                db.DbPsetInt("UPDATE_CNTR", _update_cntr);
            }
            else
            {
                strSQL.Append("INSERT INTO MENU_ITEM ");
                strSQL.Append("(");
                //strSQL.Append("COMPANY_CD, MENU_GRP, MENU_NO,");
                strSQL.Append("MENU_GRP, MENU_NO,");
                strSQL.Append("MENU_ITEM_LABEL1, MENU_ITEM_LABEL2, MENU_ITEM_LABEL3, MENU_ITEM_LABEL4,");
                strSQL.Append("APL_TYPE, PROGRAM_ID, LEVEL, IMAGEURL,");
                strSQL.Append("ENTRY_DATE, CHG_DATE, CHG_USER_ID, UPDATE_CNTR");
                strSQL.Append(") VALUES (");
                //strSQL.Append("@COMPANY_CD, @MENU_GRP, @MENU_NO,");
                strSQL.Append("@MENU_GRP, @MENU_NO,");
                strSQL.Append("@MENU_ITEM_LABEL1, @MENU_ITEM_LABEL2, @MENU_ITEM_LABEL3, @MENU_ITEM_LABEL4,");
                strSQL.Append("@APL_TYPE, @PROGRAM_ID, @LVL, @IMAGEURL,");
                strSQL.Append("@ENTRY_DATE, @CHG_DATE, @CHG_USER_ID, @UPDATE_CNTR)");

                db.DbParametersClear();

                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetString("@MENU_GRP", _menu_grp);
                db.DbPsetInt("@MENU_NO", _menu_no);
                db.DbPsetString("@MENU_ITEM_LABEL1", _menu_item_label1);
                db.DbPsetString("@MENU_ITEM_LABEL2", _menu_item_label2);
                db.DbPsetString("@MENU_ITEM_LABEL3", _menu_item_label3);
                db.DbPsetString("@MENU_ITEM_LABEL4", _menu_item_label4);
                db.DbPsetInt("@APL_TYPE", _apl_type);
                db.DbPsetString("@PROGRAM_ID", _program_id);
                db.DbPsetInt("@LVL", _lvl);
                db.DbPsetString("@IMAGEURL", _imageurl);
                db.DbPsetDate("@ENTRY_DATE", DateTime.Now);
                db.DbPsetDate("@CHG_DATE", DateTime.Now);
                db.DbPsetString("@CHG_USER_ID", _chg_user_id);
                db.DbPsetInt("@UPDATE_CNTR", _update_cntr);
            }

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

        /// <summary>
        /// メニュー項目の変更
        /// </summary>
        public int UpdateItemGrp()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            if (_db_type == "ORACLE")
            {
                strSQL.Append("UPDATE MENU_ITEM ");
                strSQL.Append("SET ");
                strSQL.Append("MENU_ITEM_LABEL1 = :MENU_ITEM_LABEL1,");
                strSQL.Append("MENU_ITEM_LABEL2 = :MENU_ITEM_LABEL2,");
                strSQL.Append("MENU_ITEM_LABEL3 = :MENU_ITEM_LABEL3,");
                strSQL.Append("MENU_ITEM_LABEL4 = :MENU_ITEM_LABEL4,");
                strSQL.Append("APL_TYPE = :APL_TYPE,");
                strSQL.Append("PROGRAM_ID = :PROGRAM_ID,");
                strSQL.Append("LEVEL = :LVL,");
                strSQL.Append("IMAGEURL = :IMAGEURL,");
                strSQL.Append("CHG_DATE = :CHG_DATE,");
                strSQL.Append("CHG_USER_ID = :CHG_USER_ID,");
                strSQL.Append("UPDATE_CNTR = UPDATE_CNTR + 1");
                //strSQL.Append(" WHERE COMPANY_CD = :COMPANY_CD");
                strSQL.Append("   WHERE MENU_GRP = :MENU_GRP");
                strSQL.Append("   AND MENU_NO = :MENU_NO");

                db.DbParametersClear();

                db.DbPsetString("MENU_ITEM_LABEL1", _menu_item_label1);
                db.DbPsetString("MENU_ITEM_LABEL2", _menu_item_label2);
                db.DbPsetString("MENU_ITEM_LABEL3", _menu_item_label3);
                db.DbPsetString("MENU_ITEM_LABEL4", _menu_item_label4);
                db.DbPsetInt("APL_TYPE", _apl_type);
                db.DbPsetString("PROGRAM_ID", _program_id);
                db.DbPsetInt("LVL", _lvl);
                db.DbPsetString("IMAGEURL", _imageurl);
                db.DbPsetDate("CHG_DATE", DateTime.Now);
                db.DbPsetString("CHG_USER_ID", _chg_user_id);
                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetString("MENU_GRP", _menu_grp);
                db.DbPsetInt("MENU_NO", _menu_no);
            }
            else
            {
                strSQL.Append("UPDATE MENU_ITEM ");
                strSQL.Append("SET ");
                strSQL.Append("MENU_ITEM_LABEL1 = @MENU_ITEM_LABEL1,");
                strSQL.Append("MENU_ITEM_LABEL2 = @MENU_ITEM_LABEL2,");
                strSQL.Append("MENU_ITEM_LABEL3 = @MENU_ITEM_LABEL3,");
                strSQL.Append("MENU_ITEM_LABEL4 = @MENU_ITEM_LABEL4,");
                strSQL.Append("APL_TYPE = @APL_TYPE,");
                strSQL.Append("PROGRAM_ID = @PROGRAM_ID,");
                strSQL.Append("LEVEL = @LVL,");
                strSQL.Append("IMAGEURL = @IMAGEURL,");
                strSQL.Append("CHG_DATE = @CHG_DATE,");
                strSQL.Append("CHG_USER_ID = @CHG_USER_ID,");
                strSQL.Append("UPDATE_CNTR = UPDATE_CNTR + 1");
                //strSQL.Append(" WHERE COMPANY_CD = @COMPANY_CD");
                strSQL.Append("   WHERE MENU_GRP = @MENU_GRP");
                strSQL.Append("   AND MENU_NO = @MENU_NO");

                db.DbParametersClear();

                db.DbPsetString("@MENU_ITEM_LABEL1", _menu_item_label1);
                db.DbPsetString("@MENU_ITEM_LABEL2", _menu_item_label2);
                db.DbPsetString("@MENU_ITEM_LABEL3", _menu_item_label3);
                db.DbPsetString("@MENU_ITEM_LABEL4", _menu_item_label4);
                db.DbPsetInt("@APL_TYPE", _apl_type);
                db.DbPsetString("@PROGRAM_ID", _program_id);
                db.DbPsetInt("@LVL", _lvl);
                db.DbPsetString("@IMAGEURL", _imageurl);
                db.DbPsetDate("@CHG_DATE", DateTime.Now);
                db.DbPsetString("@CHG_USER_ID", _chg_user_id);
                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetString("@MENU_GRP", _menu_grp);
                db.DbPsetInt("@MENU_NO", _menu_no);
            }

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

        /// <summary>
        /// メニュー項目の削除
        /// </summary>
        public int DeleteItemGrp()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            if (_db_type == "ORACLE")
            {
                strSQL.Append("DELETE FROM MENU_ITEM ");
                //strSQL.Append(" WHERE COMPANY_CD = :COMPANY_CD");
                strSQL.Append("   WHERE MENU_GRP = :MENU_GRP");
                strSQL.Append("   AND MENU_NO = :MENU_NO");

                db.DbParametersClear();

                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetString("MENU_GRP", _menu_grp);
                db.DbPsetInt("MENU_NO", _menu_no);
            }
            else
            {
                strSQL.Append("DELETE FROM MENU_ITEM ");
                //strSQL.Append(" WHERE COMPANY_CD = @COMPANY_CD");
                strSQL.Append("   WHERE MENU_GRP = @MENU_GRP");
                strSQL.Append("   AND MENU_NO = @MENU_NO");

                db.DbParametersClear();

                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetString("@MENU_GRP", _menu_grp);
                db.DbPsetInt("@MENU_NO", _menu_no);
            }

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

        /// <summary>
        /// メニュー項目一覧の取得
        /// 
        /// 使用画面：AppUserMenu
        /// </summary>
        public DataSet GetMenuItemList()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();
            int intToday = DateTime.Now.Year * 10000 + DateTime.Now.Month * 100 + DateTime.Now.Day;

            //--- sql ORACLE
            strSQL.Append("SELECT MI.MENU_NO, MI.APL_TYPE, MI.PROGRAM_ID, MI.LEVEL, MI.IMAGEURL, ");

            switch (_lang)
            {
                case 2:
                    strSQL.Append(" MI.MENU_ITEM_LABEL2 AS MENU_ITEM_LABEL, ");
                    break;

                case 3:
                    strSQL.Append(" MI.MENU_ITEM_LABEL3 AS MENU_ITEM_LABEL, ");
                    break;

                case 4:
                    strSQL.Append(" MI.MENU_ITEM_LABEL4 AS MENU_ITEM_LABEL, ");
                    break;

                default:
                    strSQL.Append(" MI.MENU_ITEM_LABEL1 AS MENU_ITEM_LABEL, ");
                    break;
            }

            strSQL.Append(" SP.NAVIGATEURL ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM MENU_ITEM MI, APL_PROGRAM SP");
                //strSQL.Append(" WHERE (MI.COMPANY_CD = :COMPANY_CD OR MI.COMPANY_CD = '*')");
                strSQL.Append("   WHERE MI.MENU_GRP = :MENU_GRP");
                //strSQL.Append("   AND SP.COMPANY_CD(+) = '*'");
                //strSQL.Append("   AND SP.KEY01(+) = 'PROGRAM_ID'");
                strSQL.Append("   AND MI.PROGRAM_ID = SP.PROGRAM_ID(+)");
                strSQL.Append("   AND MI.PROGRAM_ID IN (");
                strSQL.Append(" SELECT P.PROGRAM_ID FROM PROGRAM_AUTHORITY P ");

                strSQL.Append(" WHERE ( P.AUTH_TYPE = 0 AND P.EXECUTABLE_FLAG = 1 AND P.USER_ID = :USER_ID ) ");
                //strSQL.Append("    OR ( P.AUTH_TYPE = 1 AND P.EXECUTABLE_FLAG = 1 AND P.DEPT_CD IN ");
                //strSQL.Append("       ( SELECT DEPT_CD FROM USER_DEPT_MASTER WHERE USER_ID = :USER_ID2 AND COMPANY_CD = :COMPANY_CD2 AND BEG_EFF_DATE <= :TODAY AND END_EFF_DATE >= :TODAY2 ) ) ");
                strSQL.Append("    OR ( P.AUTH_TYPE = 2 AND P.EXECUTABLE_FLAG = 1 AND P.ROLE IN ");
                strSQL.Append("       ( SELECT ROLE FROM USER_ROLE_MASTER WHERE USER_ID = :USER_ID ) ) ");
                strSQL.Append(" )");

                strSQL.Append(" ORDER BY MI.MENU_NO");

                db.DbParametersClear();

                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetString("MENU_GRP", _menu_grp);
                db.DbPsetString("USER_ID", _chg_user_id);
                //db.DbPsetString("USER_ID2", _chg_user_id);
                //db.DbPsetString("COMPANY_CD2", _company_cd);
                //db.DbPsetInt("TODAY", intToday);
                //db.DbPsetInt("TODAY2", intToday);
                //db.DbPsetString("USER_ID3", _chg_user_id);
            }
            else
            {
                strSQL.Append(" FROM MENU_ITEM MI LEFT OUTER JOIN APL_PROGRAM SP ON MI.PROGRAM_ID = SP.PROGRAM_ID   ");
                strSQL.Append("   WHERE MI.PROGRAM_ID IN (                                                          ");
                strSQL.Append(" SELECT P.PROGRAM_ID FROM PROGRAM_AUTHORITY P                                        ");
                strSQL.Append(" WHERE ( P.AUTH_TYPE = 0 AND P.EXECUTABLE_FLAG = 2 AND P.USER_ID = @USER_ID )        ");
                strSQL.Append("    OR ( P.AUTH_TYPE = 0 AND P.EXECUTABLE_FLAG = 1 AND P.USER_ID = @USER_ID AND      ");
                strSQL.Append("         P.PROGRAM_ID NOT IN (                                                       ");
                strSQL.Append("                               'OrdSOEntry',                                         ");
                strSQL.Append("                               'OrdSOUpd',                                           ");
                strSQL.Append("                               'OrdShipInst',                                        ");
                strSQL.Append("                               'OrdShipPriceChg',                                    ");
                strSQL.Append("                               'OrdShipAct',                                         ");
                strSQL.Append("                               'OrdShipActCancel',                                   ");
                strSQL.Append("                               'OrdReturn',                                          ");
                strSQL.Append("                               'OrdReturnCancel',                                    ");
                strSQL.Append("                               'PlanProdSimulation',                                 ");
                strSQL.Append("                               'MrpExec',                                            ");
                strSQL.Append("                               'ASRcv',                                              ");
                strSQL.Append("                               'PurInspPriceChg',                                    ");
                strSQL.Append("                               'PurPORlse',                                          ");
                strSQL.Append("                               'PurManPORlse',                                       ");
                strSQL.Append("                               'PurSupplyInst',                                      ");
                strSQL.Append("                               'PurPOChg',                                           ");
                strSQL.Append("                               'PurRcv',                                             ");
                strSQL.Append("                               'PurInsp',                                            ");
                strSQL.Append("                               'PurBlockRcv',                                        ");
                strSQL.Append("                               'PurBlockInsp',                                       ");
                strSQL.Append("                               'PurReturn',                                          ");
                strSQL.Append("                               'PurRcvCancel',                                       ");
                strSQL.Append("                               'PurInspCancel',                                      ");
                strSQL.Append("                               'PurReturnCancel',                                    ");
                strSQL.Append("                               'MfgDemandMnt',                                       ");
                strSQL.Append("                               'MfgJORlse',                                          ");
                strSQL.Append("                               'MfgManJORlse',                                       ");
                strSQL.Append("                               'MfgJOCancel',                                        ");
                strSQL.Append("                               'MfgCompl',                                           ");
                strSQL.Append("                               'MfgComplCancel',                                     ");
                strSQL.Append("                               'MfgConsumptionChg',                                  ");
                strSQL.Append("                               'MfgActManHourInput',                                 ");
                strSQL.Append("                               'MfgProcessCompl',                                    ");
                strSQL.Append("                               'MfgProcessComplCancel',                              ");
                strSQL.Append("                               'MfgJOCRlse',                                         ");
                strSQL.Append("                               'MfgInput',                                           ");     //Add 10.12.21 Ubiq-Sai
                strSQL.Append("                               'MfgProcessInput',                                    ");     //Add 10.12.21 Ubiq-Sai
                strSQL.Append("                               'MfgScrap',                                           ");     //Add 10.12.21 Ubiq-Sai
                strSQL.Append("                               'MfgInputCancel',                                     ");     //Add 10.12.21 Ubiq-Sai
                strSQL.Append("                               'MfgProcessInputCancel',                              ");     //Add 10.12.21 Ubiq-Sai
                strSQL.Append("                               'InvRcvWhs',                                          ");
                strSQL.Append("                               'InvRcvWhsCancel',                                    ");
                strSQL.Append("                               'InvComplWhs',                                        ");
                strSQL.Append("                               'InvComplWhsCancel',                                  ");
                strSQL.Append("                               'InvDisbAct',                                         ");
                strSQL.Append("                               'InvDisbActCancel',                                   ");
                strSQL.Append("                               'InvAdjReq',                                          ");
                strSQL.Append("                               'InvAdjAct',                                          ");
                strSQL.Append("                               'InvWhsTransferReq',                                  ");
                strSQL.Append("                               'InvWhsTransferAct',                                  ");
                strSQL.Append("                               'InvJOCTransfer',                                     ");
                strSQL.Append("                               'WipAdjReq',                                          ");
                strSQL.Append("                               'MonthlyTotal',                                       ");
                strSQL.Append("                               'InvStockTakingAbstract',                             ");
                strSQL.Append("                               'InvStockTakingAct',                                  ");
                strSQL.Append("                               'InvStockTakingUpd',                                  ");
                strSQL.Append("                               'WipStockTakingAbstract',                             ");
                strSQL.Append("                               'WipStockTakingAct',                                  ");
                strSQL.Append("                               'WipStockTakingUpd',                                  ");
                strSQL.Append("                               'MstOverheadGroupRateMnt',                            ");
                strSQL.Append("                               'CostStandardExec',                                   ");
                strSQL.Append("                               'ComCostDeptAllocation',                              ");
                strSQL.Append("                               'DeptCostMnt',                                        ");
                strSQL.Append("                               'BackDeptCostAllocation',                             ");
                strSQL.Append("                               'DirectDeptCostMnt',                                  ");
                strSQL.Append("                               'CostActualExec'                                      ");
                strSQL.Append("                              )                                                      ");
                strSQL.Append("       )                                                                             ");
                strSQL.Append("    OR ( P.AUTH_TYPE = 2 AND P.EXECUTABLE_FLAG = 2 AND P.ROLE IN                     ");
                strSQL.Append("       ( SELECT ROLE FROM USER_ROLE_MASTER WHERE USER_ID = @USER_ID ) )              ");
                strSQL.Append("    OR ( P.AUTH_TYPE = 2 AND P.EXECUTABLE_FLAG = 1 AND P.ROLE IN                     ");
                strSQL.Append("       ( SELECT ROLE FROM USER_ROLE_MASTER WHERE USER_ID = @USER_ID ) AND            ");
                strSQL.Append("         P.PROGRAM_ID NOT IN (                                                       ");
                strSQL.Append("                               'OrdSOEntry',                                         ");
                strSQL.Append("                               'OrdSOUpd',                                           ");
                strSQL.Append("                               'OrdShipInst',                                        ");
                strSQL.Append("                               'OrdShipPriceChg',                                    ");
                strSQL.Append("                               'OrdShipAct',                                         ");
                strSQL.Append("                               'OrdShipActCancel',                                   ");
                strSQL.Append("                               'OrdReturn',                                          ");
                strSQL.Append("                               'OrdReturnCancel',                                    ");
                strSQL.Append("                               'PlanProdSimulation',                                 ");
                strSQL.Append("                               'MrpExec',                                            ");
                strSQL.Append("                               'ASRcv',                                              ");
                strSQL.Append("                               'PurInspPriceChg',                                    ");
                strSQL.Append("                               'PurPORlse',                                          ");
                strSQL.Append("                               'PurManPORlse',                                       ");
                strSQL.Append("                               'PurSupplyInst',                                      ");
                strSQL.Append("                               'PurPOChg',                                           ");
                strSQL.Append("                               'PurRcv',                                             ");
                strSQL.Append("                               'PurInsp',                                            ");
                strSQL.Append("                               'PurBlockRcv',                                        ");
                strSQL.Append("                               'PurBlockInsp',                                       ");
                strSQL.Append("                               'PurReturn',                                          ");
                strSQL.Append("                               'PurRcvCancel',                                       ");
                strSQL.Append("                               'PurInspCancel',                                      ");
                strSQL.Append("                               'PurReturnCancel',                                    ");
                strSQL.Append("                               'MfgDemandMnt',                                       ");
                strSQL.Append("                               'MfgJORlse',                                          ");
                strSQL.Append("                               'MfgManJORlse',                                       ");
                strSQL.Append("                               'MfgJOCancel',                                        ");
                strSQL.Append("                               'MfgCompl',                                           ");
                strSQL.Append("                               'MfgComplCancel',                                     ");
                strSQL.Append("                               'MfgConsumptionChg',                                  ");
                strSQL.Append("                               'MfgActManHourInput',                                 ");
                strSQL.Append("                               'MfgProcessCompl',                                    ");
                strSQL.Append("                               'MfgProcessComplCancel',                              ");
                strSQL.Append("                               'MfgJOCRlse',                                         ");
                strSQL.Append("                               'MfgInput',                                           ");     //Add 10.12.21 Ubiq-Sai
                strSQL.Append("                               'MfgProcessInput',                                    ");     //Add 10.12.21 Ubiq-Sai
                strSQL.Append("                               'MfgScrap',                                           ");     //Add 10.12.21 Ubiq-Sai
                strSQL.Append("                               'MfgInputCancel',                                     ");     //Add 10.12.21 Ubiq-Sai
                strSQL.Append("                               'MfgProcessInputCancel',                              ");     //Add 10.12.21 Ubiq-Sai
                strSQL.Append("                               'InvRcvWhs',                                          ");
                strSQL.Append("                               'InvRcvWhsCancel',                                    ");
                strSQL.Append("                               'InvComplWhs',                                        ");
                strSQL.Append("                               'InvComplWhsCancel',                                  ");
                strSQL.Append("                               'InvDisbAct',                                         ");
                strSQL.Append("                               'InvDisbActCancel',                                   ");
                strSQL.Append("                               'InvAdjReq',                                          ");
                strSQL.Append("                               'InvAdjAct',                                          ");
                strSQL.Append("                               'InvWhsTransferReq',                                  ");
                strSQL.Append("                               'InvWhsTransferAct',                                  ");
                strSQL.Append("                               'InvJOCTransfer',                                     ");
                strSQL.Append("                               'WipAdjReq',                                          ");
                strSQL.Append("                               'MonthlyTotal',                                       ");
                strSQL.Append("                               'InvStockTakingAbstract',                             ");
                strSQL.Append("                               'InvStockTakingAct',                                  ");
                strSQL.Append("                               'InvStockTakingUpd',                                  ");
                strSQL.Append("                               'WipStockTakingAbstract',                             ");
                strSQL.Append("                               'WipStockTakingAct',                                  ");
                strSQL.Append("                               'WipStockTakingUpd',                                  ");
                strSQL.Append("                               'MstOverheadGroupRateMnt',                            ");
                strSQL.Append("                               'CostStandardExec',                                   ");
                strSQL.Append("                               'ComCostDeptAllocation',                              ");
                strSQL.Append("                               'DeptCostMnt',                                        ");
                strSQL.Append("                               'BackDeptCostAllocation',                             ");
                strSQL.Append("                               'DirectDeptCostMnt',                                  ");
                strSQL.Append("                               'CostActualExec'                                      ");
                strSQL.Append("                              )                                                      "); 
                strSQL.Append("       )                   )                                                         ");
                strSQL.Append(" AND MI.MENU_GRP = @MENU_GRP                                                         ");

                strSQL.Append(" ORDER BY MI.MENU_NO");

                db.DbParametersClear();

                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetString("@MENU_GRP", _menu_grp);
                db.DbPsetString("@USER_ID", _chg_user_id);
                //db.DbPsetString("@USER_ID2", _chg_user_id);
                //db.DbPsetString("@COMPANY_CD2", _company_cd);
                //db.DbPsetInt("@TODAY", intToday);
                //db.DbPsetInt("@TODAY2", intToday);
                //db.DbPsetString("@USER_ID3", _chg_user_id);
            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "info");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }

                if (db.State() == ConnectionState.Open) db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open) db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// メニュー項目詳細の取得
        /// </summary>
        public int GetMenuItemDetail()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT MENU_ITEM_LABEL1, MENU_ITEM_LABEL2, MENU_ITEM_LABEL3, MENU_ITEM_LABEL4, APL_TYPE, PROGRAM_ID, IMAGEURL,   ");
            strSQL.Append(" ENTRY_DATE, CHG_DATE, CHG_USER_ID,                                                                              ");
            strSQL.Append(" UPDATE_CNTR                                                                                                     ");
            strSQL.Append(" FROM MENU_ITEM                                                                                                  ");
            if (_db_type == "ORACLE")
            {
                //strSQL.Append(" WHERE COMPANY_CD = :COMPANY_CD");
                strSQL.Append("   WHERE MENU_GRP = :MENU_GRP");
                strSQL.Append("   AND MENU_NO = :MENU_NO");

                db.DbParametersClear();

                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetString("MENU_GRP", _menu_grp);
                db.DbPsetInt("MENU_NO", _menu_no);
            }
            else
            {
                //strSQL.Append(" WHERE COMPANY_CD = @COMPANY_CD");
                strSQL.Append("   WHERE MENU_GRP = @MENU_GRP");
                strSQL.Append("   AND MENU_NO = @MENU_NO");

                db.DbParametersClear();

                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetString("@MENU_GRP", _menu_grp);
                db.DbPsetInt("@MENU_NO", _menu_no);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _menu_item_label1 = db.Row("MENU_ITEM_LABEL1");
                _menu_item_label2 = db.Row("MENU_ITEM_LABEL2");
                _menu_item_label3 = db.Row("MENU_ITEM_LABEL3");
                _menu_item_label4 = db.Row("MENU_ITEM_LABEL4");
                _apl_type = int.Parse(db.Row("APL_TYPE"));
                _program_id = db.Row("PROGRAM_ID");
                _imageurl = db.Row("IMAGEURL");
                _entry_date = DateTime.Parse(db.Row("ENTRY_DATE"));
                _chg_date = DateTime.Parse(db.Row("CHG_DATE"));
                _chg_user_id = db.Row("CHG_USER_ID");
                _update_cntr = int.Parse(db.Row("UPDATE_CNTR"));
            }

            if (db.State() == ConnectionState.Open) db.DbClose();

            return rtn;
        }

        /// <summary>
        /// プログラム実行権限の追加
        /// </summary>
        public int InsertPgmAuth()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            // Insert
            strSQL = new StringBuilder();
            if (_db_type == "ORACLE")
            {
                strSQL.Append("INSERT INTO PROGRAM_AUTHORITY ");
                strSQL.Append("(");
                //strSQL.Append("COMPANY_CD, PROGRAM_ID, AUTH_TYPE,");
                strSQL.Append("PROGRAM_ID, AUTH_TYPE,");
                //strSQL.Append("USER_ID, DEPT_CD, ROLE, EXECUTABLE_FLAG,");
                strSQL.Append("USER_ID, ROLE, EXECUTABLE_FLAG,");
                strSQL.Append("ENTRY_DATE, CHG_DATE, CHG_USER_ID, UPDATE_CNTR");
                strSQL.Append(") VALUES (");
                //strSQL.Append(":COMPANY_CD, :PROGRAM_ID, :AUTH_TYPE,");
                strSQL.Append(":PROGRAM_ID, :AUTH_TYPE,");
                //strSQL.Append(":USER_ID, :DEPT_CD, :ROLE, :EXECUTABLE_FLAG,");
                strSQL.Append(":USER_ID, :ROLE, :EXECUTABLE_FLAG,");
                strSQL.Append(":ENTRY_DATE, :CHG_DATE, :CHG_USER_ID, :UPDATE_CNTR)");

                db.DbParametersClear();

                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetString("PROGRAM_ID", _program_id);
                db.DbPsetInt("AUTH_TYPE", _auth_type);
                db.DbPsetString("USER_ID", _user_id);
                //db.DbPsetString("DEPT_CD", _dept_cd);
                db.DbPsetString("ROLE", _role);
                db.DbPsetInt("EXECUTABLE_FLAG", _executable_flag);
                db.DbPsetDate("ENTRY_DATE", DateTime.Now);
                db.DbPsetDate("CHG_DATE", DateTime.Now);
                db.DbPsetString("CHG_USER_ID", _chg_user_id);
                db.DbPsetInt("UPDATE_CNTR", _update_cntr);
            }
            else
            {
                strSQL.Append("INSERT INTO PROGRAM_AUTHORITY ");
                strSQL.Append("(");
                //strSQL.Append("COMPANY_CD, PROGRAM_ID, AUTH_TYPE,");
                strSQL.Append("PROGRAM_ID, AUTH_TYPE,");
                //strSQL.Append("USER_ID, DEPT_CD, ROLE, EXECUTABLE_FLAG,");
                strSQL.Append("USER_ID, ROLE, EXECUTABLE_FLAG,");
                strSQL.Append("ENTRY_DATE, CHG_DATE, CHG_USER_ID, UPDATE_CNTR");
                strSQL.Append(") VALUES (");
                //strSQL.Append("@COMPANY_CD, @PROGRAM_ID, @AUTH_TYPE,");
                strSQL.Append("@PROGRAM_ID, @AUTH_TYPE,");
                //strSQL.Append("@USER_ID, @DEPT_CD, @ROLE, @EXECUTABLE_FLAG,");
                strSQL.Append("@USER_ID, @ROLE, @EXECUTABLE_FLAG,");
                strSQL.Append("@ENTRY_DATE, @CHG_DATE, @CHG_USER_ID, @UPDATE_CNTR)");

                db.DbParametersClear();

                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetString("@PROGRAM_ID", _program_id);
                db.DbPsetInt("@AUTH_TYPE", _auth_type);
                db.DbPsetString("@USER_ID", _user_id);
                //db.DbPsetString("@DEPT_CD", _dept_cd);
                db.DbPsetString("@ROLE", _role);
                db.DbPsetInt("@EXECUTABLE_FLAG", _executable_flag);
                db.DbPsetDate("@ENTRY_DATE", DateTime.Now);
                db.DbPsetDate("@CHG_DATE", DateTime.Now);
                db.DbPsetString("@CHG_USER_ID", _chg_user_id);
                db.DbPsetInt("@UPDATE_CNTR", _update_cntr);
            }

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

        /// <summary>
        /// プログラム実行権限の追加
        /// </summary>
        public int InsertPgmAuth(ComDB db)
        {
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            // Insert
            strSQL = new StringBuilder();
            if (_db_type == "ORACLE")
            {
                strSQL.Append("INSERT INTO PROGRAM_AUTHORITY ");
                strSQL.Append("(");
                strSQL.Append("PROGRAM_ID, AUTH_TYPE,");
                strSQL.Append("USER_ID, ROLE, EXECUTABLE_FLAG,");
                strSQL.Append("ENTRY_DATE, CHG_DATE, CHG_USER_ID, UPDATE_CNTR");
                strSQL.Append(") VALUES (");
                strSQL.Append(":PROGRAM_ID, :AUTH_TYPE,");
                strSQL.Append(":USER_ID, :ROLE, :EXECUTABLE_FLAG,");
                strSQL.Append(":ENTRY_DATE, :CHG_DATE, :CHG_USER_ID, :UPDATE_CNTR)");

                db.DbParametersClear();

                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetString("PROGRAM_ID", _program_id);
                db.DbPsetInt("AUTH_TYPE", _auth_type);
                db.DbPsetString("USER_ID", _user_id);
                //db.DbPsetString("DEPT_CD", _dept_cd);
                db.DbPsetString("ROLE", _role);
                db.DbPsetInt("EXECUTABLE_FLAG", _executable_flag);
                db.DbPsetDate("ENTRY_DATE", DateTime.Now);
                db.DbPsetDate("CHG_DATE", DateTime.Now);
                db.DbPsetString("CHG_USER_ID", _chg_user_id);
                db.DbPsetInt("UPDATE_CNTR", _update_cntr);
            }
            else
            {
                strSQL.Append("INSERT INTO PROGRAM_AUTHORITY ");
                strSQL.Append("(");
                strSQL.Append("PROGRAM_ID, AUTH_TYPE,");
                strSQL.Append("USER_ID, ROLE, EXECUTABLE_FLAG,");
                strSQL.Append("ENTRY_DATE, CHG_DATE, CHG_USER_ID, UPDATE_CNTR");
                strSQL.Append(") VALUES (");
                strSQL.Append("@PROGRAM_ID, @AUTH_TYPE,");
                strSQL.Append("@USER_ID, @ROLE, @EXECUTABLE_FLAG,");
                strSQL.Append("@ENTRY_DATE, @CHG_DATE, @CHG_USER_ID, @UPDATE_CNTR)");

                db.DbParametersClear();

                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetString("@PROGRAM_ID", _program_id);
                db.DbPsetInt("@AUTH_TYPE", _auth_type);
                db.DbPsetString("@USER_ID", _user_id);
                //db.DbPsetString("@DEPT_CD", _dept_cd);
                db.DbPsetString("@ROLE", _role);
                db.DbPsetInt("@EXECUTABLE_FLAG", _executable_flag);
                db.DbPsetDate("@ENTRY_DATE", DateTime.Now);
                db.DbPsetDate("@CHG_DATE", DateTime.Now);
                db.DbPsetString("@CHG_USER_ID", _chg_user_id);
                db.DbPsetInt("@UPDATE_CNTR", _update_cntr);
            }

            rtn = db.DbExecute(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                db.DbRollback();
            }

            return rtn;
        }

        /// <summary>
        /// プログラム実行権限の変更
        /// </summary>
        public int UpdatePgmAuth()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            if (_db_type == "ORACLE")
            {
                strSQL.Append("UPDATE PROGRAM_AUTHORITY ");
                strSQL.Append("SET ");
                strSQL.Append("EXECUTABLE_FLAG = :EXECUTABLE_FLAG,");
                strSQL.Append("CHG_DATE = :CHG_DATE,");
                strSQL.Append("CHG_USER_ID = :CHG_USER_ID,");
                strSQL.Append("UPDATE_CNTR = UPDATE_CNTR + 1");
                //strSQL.Append(" WHERE COMPANY_CD = :COMPANY_CD");
                strSQL.Append("   WHERE PROGRAM_ID = :PROGRAM_ID");
                strSQL.Append("   AND AUTH_TYPE = :AUTH_TYPE");
                strSQL.Append("   AND USER_ID = :USER_ID");
                //strSQL.Append("   AND DEPT_CD = :DEPT_CD");
                strSQL.Append("   AND ROLE = :ROLE");

                db.DbParametersClear();

                db.DbPsetInt("EXECUTABLE_FLAG", _executable_flag);
                db.DbPsetDate("CHG_DATE", DateTime.Now);
                db.DbPsetString("CHG_USER_ID", _chg_user_id);
                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetString("PROGRAM_ID", _program_id);
                db.DbPsetInt("AUTH_TYPE", _auth_type);
                db.DbPsetString("USER_ID", _user_id);
                //db.DbPsetString("DEPT_CD", _dept_cd);
                db.DbPsetString("ROLE", _role);
            }
            else
            {
                strSQL.Append("UPDATE PROGRAM_AUTHORITY ");
                strSQL.Append("SET ");
                strSQL.Append("EXECUTABLE_FLAG = @EXECUTABLE_FLAG,");
                strSQL.Append("CHG_DATE = @CHG_DATE,");
                strSQL.Append("CHG_USER_ID = @CHG_USER_ID,");
                strSQL.Append("UPDATE_CNTR = UPDATE_CNTR + 1");
                //strSQL.Append(" WHERE COMPANY_CD = @COMPANY_CD");
                strSQL.Append("   WHERE PROGRAM_ID = @PROGRAM_ID");
                strSQL.Append("   AND AUTH_TYPE = @AUTH_TYPE");
                strSQL.Append("   AND USER_ID = @USER_ID");
                //strSQL.Append("   AND DEPT_CD = @DEPT_CD");
                strSQL.Append("   AND ROLE = @ROLE");

                db.DbParametersClear();

                db.DbPsetInt("@EXECUTABLE_FLAG", _executable_flag);
                db.DbPsetDate("@CHG_DATE", DateTime.Now);
                db.DbPsetString("@CHG_USER_ID", _chg_user_id);
                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetString("@PROGRAM_ID", _program_id);
                db.DbPsetInt("@AUTH_TYPE", _auth_type);
                db.DbPsetString("@USER_ID", _user_id);
                //db.DbPsetString("@DEPT_CD", _dept_cd);
                db.DbPsetString("@ROLE", _role);
            }

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

        /// <summary>
        /// プログラム実行権限の削除
        /// </summary>
        public int DeletePgmAuth()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            if (_db_type == "ORACLE")
            {
                strSQL.Append("DELETE FROM PROGRAM_AUTHORITY ");
                //strSQL.Append(" WHERE COMPANY_CD = :COMPANY_CD");
                strSQL.Append("   WHERE PROGRAM_ID = :PROGRAM_ID");
                strSQL.Append("   AND AUTH_TYPE = :AUTH_TYPE");
                strSQL.Append("   AND USER_ID = :USER_ID");
                //strSQL.Append("   AND DEPT_CD = :DEPT_CD");
                strSQL.Append("   AND ROLE = :ROLE");

                db.DbParametersClear();

                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetString("PROGRAM_ID", _program_id);
                db.DbPsetInt("AUTH_TYPE", _auth_type);
                db.DbPsetString("USER_ID", _user_id);
                //db.DbPsetString("DEPT_CD", _dept_cd);
                db.DbPsetString("ROLE", _role);
            }
            else
            {
                strSQL.Append("DELETE FROM PROGRAM_AUTHORITY ");
                //strSQL.Append(" WHERE COMPANY_CD = @COMPANY_CD");
                strSQL.Append("   WHERE PROGRAM_ID = @PROGRAM_ID");
                strSQL.Append("   AND AUTH_TYPE  = @AUTH_TYPE ");
                strSQL.Append("   AND USER_ID    = @USER_ID   ");
                //strSQL.Append("   AND DEPT_CD    = @DEPT_CD   ");
                strSQL.Append("   AND ROLE       = @ROLE      ");

                db.DbParametersClear();

                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetString("@PROGRAM_ID", _program_id);
                db.DbPsetInt("@AUTH_TYPE", _auth_type);
                db.DbPsetString("@USER_ID", _user_id);
                //db.DbPsetString("@DEPT_CD", _dept_cd);
                db.DbPsetString("@ROLE", _role);
            }

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

        /// <summary>
        /// プログラム実行権限一覧の取得
        /// 
        /// 使用画面：MstPgmAuthMnt
        /// </summary>
        public DataSet GetPgmAuthList()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT A.PROGRAM_ID, A.AUTH_TYPE,");
            strSQL.Append(" A.USER_ID, A.ROLE, A.EXECUTABLE_FLAG,");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" U.USER_FAMILY_NAME || ' ' || U.USER_FIRST_NAME AS USER_NAME,");
            }
            else
            {
                strSQL.Append(" U.USER_FAMILY_NAME + ' ' + U.USER_FIRST_NAME AS USER_NAME,");
            }

            switch (_lang)
            {
                case 2:
                    strSQL.Append("R.ROLE_DESC2 AS ROLE_DESC, ");
                    //strSQL.Append("D.DEPT_DESC2 AS DEPT_DESC, ");
                    break;

                case 3:
                    strSQL.Append("R.ROLE_DESC3 AS ROLE_DESC, ");
                    //strSQL.Append("D.DEPT_DESC3 AS DEPT_DESC, ");
                    break;
                
                case 4:
                    strSQL.Append("R.ROLE_DESC4 AS ROLE_DESC, ");
                    //strSQL.Append("D.DEPT_DESC4 AS DEPT_DESC, ");
                    break;
                
                default:
                    strSQL.Append("R.ROLE_DESC1 AS ROLE_DESC, ");
                    //strSQL.Append("D.DEPT_DESC1 AS DEPT_DESC, ");
                    break;
            }
            
            strSQL.Append(" A.ENTRY_DATE, A.CHG_DATE, A.CHG_USER_ID,");
            strSQL.Append(" A.UPDATE_CNTR");
            
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM PROGRAM_AUTHORITY A, USER_MASTER U, ROLE_MASTER R");
                //strSQL.Append(" WHERE A.COMPANY_CD = :COMPANY_CD");
                strSQL.Append("   WHERE A.PROGRAM_ID = :PROGRAM_ID");
                strSQL.Append("   AND A.AUTH_TYPE = :AUTH_TYPE");
                strSQL.Append("   AND A.USER_ID = U.USER_ID(+)");
                strSQL.Append("   AND U.LOGICAL_DEL_FLAG(+) = 0");
                //strSQL.Append("   AND A.COMPANY_CD = D.COMPANY_CD(+)");
                //strSQL.Append("   AND A.DEPT_CD = D.DEPT_CD(+)");
                strSQL.Append("   AND A.ROLE = R.ROLE(+)");

                strSQL.Append(" ORDER BY A.USER_ID, A.ROLE");

                db.DbParametersClear();

                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetString("PROGRAM_ID", _program_id);
                db.DbPsetInt("AUTH_TYPE", _auth_type);
            }
            else
            {
                strSQL.Append(" FROM PROGRAM_AUTHORITY A ");
                strSQL.Append(" LEFT OUTER JOIN USER_MASTER U ON A.USER_ID = U.USER_ID AND U.LOGICAL_DEL_FLAG = 0");
                //strSQL.Append(" LEFT OUTER JOIN DEPT_MASTER D ON A.COMPANY_CD = D.COMPANY_CD AND A.DEPT_CD = D.DEPT_CD");
                strSQL.Append(" LEFT OUTER JOIN ROLE_MASTER R ON A.ROLE = R.ROLE");

                //strSQL.Append(" WHERE A.COMPANY_CD = @COMPANY_CD");
                strSQL.Append("   WHERE A.PROGRAM_ID = @PROGRAM_ID");
                strSQL.Append("   AND A.AUTH_TYPE  = @AUTH_TYPE ");

                strSQL.Append(" ORDER BY A.USER_ID, A.ROLE");

                db.DbParametersClear();

                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetString("@PROGRAM_ID", _program_id);
                db.DbPsetInt("@AUTH_TYPE", _auth_type);
            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "auth");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }

                if (db.State() == ConnectionState.Open) db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open) db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// プログラム実行権限詳細の取得
        /// </summary>
        public int GetPgmAuthDetail()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT EXECUTABLE_FLAG,                  ");
            strSQL.Append(" ENTRY_DATE, CHG_DATE, CHG_USER_ID,      ");
            strSQL.Append(" UPDATE_CNTR                             ");
            strSQL.Append(" FROM PROGRAM_AUTHORITY                  ");
            if (_db_type == "ORACLE")
            {
                //strSQL.Append(" WHERE COMPANY_CD = :COMPANY_CD");
                strSQL.Append("   WHERE PROGRAM_ID = :PROGRAM_ID");
                strSQL.Append("   AND AUTH_TYPE = :AUTH_TYPE");
                strSQL.Append("   AND USER_ID = :USER_ID");
                //strSQL.Append("   AND DEPT_CD = :DEPT_CD");
                strSQL.Append("   AND ROLE = :ROLE");

                db.DbParametersClear();

                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetString("PROGRAM_ID", _program_id);
                db.DbPsetInt("AUTH_TYPE", _auth_type);
                db.DbPsetString("USER_ID", _user_id);
                //db.DbPsetString("DEPT_CD", _dept_cd);
                db.DbPsetString("ROLE", _role);
            }
            else
            {
                //strSQL.Append(" WHERE COMPANY_CD = @COMPANY_CD");
                strSQL.Append("   WHERE PROGRAM_ID = @PROGRAM_ID");
                strSQL.Append("   AND AUTH_TYPE  = @AUTH_TYPE ");
                strSQL.Append("   AND USER_ID    = @USER_ID   ");
                //strSQL.Append("   AND DEPT_CD    = @DEPT_CD   ");
                strSQL.Append("   AND ROLE       = @ROLE      ");

                db.DbParametersClear();

                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetString("@PROGRAM_ID", _program_id);
                db.DbPsetInt("@AUTH_TYPE", _auth_type);
                db.DbPsetString("@USER_ID", _user_id);
                //db.DbPsetString("@DEPT_CD", _dept_cd);
                db.DbPsetString("@ROLE", _role);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _executable_flag = int.Parse(db.Row("EXECUTABLE_FLAG"));
                _entry_date = DateTime.Parse(db.Row("ENTRY_DATE"));
                _chg_date = DateTime.Parse(db.Row("CHG_DATE"));
                _chg_user_id = db.Row("CHG_USER_ID");
                _update_cntr = int.Parse(db.Row("UPDATE_CNTR"));
            }

            if (db.State() == ConnectionState.Open) db.DbClose();

            return rtn;
        }

        /// <summary>
        /// プログラムID一覧の取得
        /// 
        /// 使用画面：MstPgmAuthMnt,MstMenuItemMnt
        /// </summary>
        public DataSet GetProgramList()//ADD 20090319 UBIQ-LIU
        {
            //string database = WebConfigurationManager.ConnectionStrings["IM_DbName"].ConnectionString;
            string connectionstring = WebConfigurationManager.ConnectionStrings["IM"].ConnectionString;
            string database = "";
            //    <add name="IM" providerName="System.Data.SqlClient" connectionString="Server=ws2008;database=IMV3;user id=sa;password=sa"/>
            int startix = connectionstring.IndexOf("database=");
            int endix = -1;
            if (startix >= 0)
            {
                startix += 9;   // database= の次
                endix = connectionstring.IndexOf(";", startix);
                if (endix > startix)
                    database = connectionstring.Substring(startix, endix - startix);
            }
            if (database == "")
            {
                try
                {
                    database = WebConfigurationManager.ConnectionStrings["IM_DbName"].ConnectionString;
                }
                catch
                {
                    database = "IM";
                }
            }



            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append(" SELECT A.PROGRAM_ID,     DIC.ITEM_DESC1,     DIC.ITEM_DESC2,    ");
            strSQL.Append(" DIC.ITEM_DESC3,     DIC.ITEM_DESC4,                             ");
            switch (_lang)
            {
                case 2:
                    strSQL.Append("DIC.ITEM_DESC2 AS PROG_DESC ");
                    break;
                case 3:
                    strSQL.Append("DIC.ITEM_DESC3 AS PROG_DESC ");
                    break;
                case 4:
                    strSQL.Append("DIC.ITEM_DESC4 AS PROG_DESC ");
                    break;
                default:
                    strSQL.Append("DIC.ITEM_DESC1 AS PROG_DESC ");
                    break;
            }
            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM APL_PROGRAM A, DICTIONARY_MASTER DIC           ");
                strSQL.Append("   WHERE A.STD_ITEM = DIC.STD_ITEM                   ");
                strSQL.Append(" ORDER BY A.PROGRAM_ID                               ");
            }
            else
            {
                strSQL.Append(" FROM APL_PROGRAM A                                                                          ");
                strSQL.Append(" LEFT OUTER JOIN " + database + ".dbo.DICTIONARY_MASTER DIC ON A.STD_ITEM = DIC.STD_ITEM     ");
                strSQL.Append(" ORDER BY A.PROGRAM_ID                                                                       ");
            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "auth");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }

                if (db.State() == ConnectionState.Open) db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open) db.DbClose();
                return null;
            }
        }
        /// <summary>
        /// プログラムID一覧の取得
        /// 
        /// 使用画面：MstMenuAuthorityMnt
        /// </summary>
        public DataSet GetMenuItemAuthorityList()//ADD 20090323 UBIQ-CHEN
        {
            //string database = "PM";

            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT DISTINCT MI.PROGRAM_ID, MI.MENU_NO,");

            switch (_lang)
            {
                case 2:
                    strSQL.Append(" MI.MENU_ITEM_LABEL2 AS PROG_DESC ");
                    break;

                case 3:
                    strSQL.Append(" MI.MENU_ITEM_LABEL3 AS PROG_DESC ");
                    break;

                case 4:
                    strSQL.Append(" MI.MENU_ITEM_LABEL4 AS PROG_DESC ");
                    break;

                default:
                    strSQL.Append(" MI.MENU_ITEM_LABEL1 AS PROG_DESC ");
                    break;
            }

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM MENU_ITEM MI                                           ");
                strSQL.Append(" LEFT OUTER JOIN MENU_GROUP MG ON MI.MENU_GRP = MG.MENU_GRP  ");
                strSQL.Append(" WHERE MG.MENU_GRP = :MENU_GRP                               ");
                strSQL.Append(" ORDER BY MI.MENU_NO,MI.PROGRAM_ID                           ");

                db.DbParametersClear();
                db.DbPsetString("MENU_GRP", _menu_grp);
            }
            else
            {
                strSQL.Append(" FROM MENU_ITEM MI                                           ");
                strSQL.Append(" LEFT OUTER JOIN MENU_GROUP MG ON MI.MENU_GRP = MG.MENU_GRP  ");
                strSQL.Append(" WHERE MG.MENU_GRP = @MENU_GRP                               ");
                strSQL.Append(" ORDER BY MI.MENU_NO,MI.PROGRAM_ID                           ");

                db.DbParametersClear();
                db.DbPsetString("@MENU_GRP", _menu_grp);                
            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "auth");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }

                if (db.State() == ConnectionState.Open) db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open) db.DbClose();
                return null;
            }
        }

        /// <summary>
        /// メニューグループ一覧の取得
        /// 
        /// 使用画面：Srchproject
        /// </summary>
        public DataSet GetMenuGrpList_Srch()//ADD 20090323 UBIQ-zhao
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            //strSQL.Append("SELECT MENU_GRP, MENU_GRP_TYPE, USER_ID, MENU_GRP_DESC1, MENU_GRP_DESC2, MENU_GRP_DESC3, ");
            strSQL.Append("SELECT MENU_GRP, MENU_NO, MENU_ITEM_LABEL1, MENU_ITEM_LABEL2, MENU_ITEM_LABEL3, MENU_ITEM_LABEL4,");
            switch (_lang)
            {
                case 2:
                    strSQL.Append(" MENU_ITEM_LABEL2 AS MENU_GRP_DESC, ");
                    break;

                case 3:
                    strSQL.Append(" MENU_ITEM_LABEL3 AS MENU_GRP_DESC, ");
                    break;

                case 4:
                    strSQL.Append(" MENU_ITEM_LABEL4 AS MENU_GRP_DESC, ");
                    break;

                default:
                    strSQL.Append(" MENU_ITEM_LABEL1 AS MENU_GRP_DESC, ");
                    break;
            }
            strSQL.Append("  ENTRY_DATE, CHG_DATE, CHG_USER_ID,");
            strSQL.Append(" UPDATE_CNTR");
            strSQL.Append(" FROM MENU_ITEM ");
            strSQL.Append(" WHERE 1=1 ");
            if (_menu_grp != "")
            {
                strSQL.Append("   AND MENU_ITEM.MENU_GRP       = @MENU_GRP      ");
                db.DbPsetString("@MENU_GRP", _menu_grp);
            }
            strSQL.Append(" ORDER BY MENU_GRP");
            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "info");
                if (ds == null)
                {
                    _dbmsg = db.expmsg;
                    _strErr = db.strErr;
                }

                if (db.State() == ConnectionState.Open) db.DbClose();

                return ds;
            }
            catch
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open) db.DbClose();
                return null;
            }

        }

        /// <summary>
        /// メニュー項目の変更
        /// </summary>
        public int Piture_UpdateItemGrp()//ADD 20090323 UBIQ-zhao
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            if (_db_type == "ORACLE")
            {
                strSQL.Append("UPDATE MENU_ITEM                 ");
                strSQL.Append("SET                              ");    
                strSQL.Append("IMAGEURL = :IMAGEURL,            ");
                strSQL.Append("CHG_DATE = :CHG_DATE,            ");
                strSQL.Append("CHG_USER_ID = :CHG_USER_ID,      ");
                strSQL.Append("UPDATE_CNTR = UPDATE_CNTR + 1    ");
                strSQL.Append("   WHERE MENU_GRP = :MENU_GRP    ");
                strSQL.Append("   AND MENU_NO = :MENU_NO        ");

                db.DbParametersClear();
           
                db.DbPsetString("IMAGEURL", _imageurl);
                db.DbPsetDate("CHG_DATE", DateTime.Now);
                db.DbPsetString("CHG_USER_ID", _chg_user_id);
                //db.DbPsetString("COMPANY_CD", _company_cd);
                db.DbPsetString("MENU_GRP", _menu_grp);
                db.DbPsetInt("MENU_NO", _menu_no);
            }
            else
            {
                strSQL.Append("UPDATE MENU_ITEM                 ");
                strSQL.Append("SET                              ");
                strSQL.Append("IMAGEURL = @IMAGEURL,            ");
                strSQL.Append("CHG_DATE = @CHG_DATE,            ");
                strSQL.Append("CHG_USER_ID = @CHG_USER_ID,      ");
                strSQL.Append("UPDATE_CNTR = UPDATE_CNTR + 1    ");
                //strSQL.Append(" WHERE COMPANY_CD = @COMPANY_CD");
                strSQL.Append("   WHERE MENU_GRP = @MENU_GRP    ");
                strSQL.Append("   AND MENU_NO = @MENU_NO        ");

                db.DbParametersClear();
           
                db.DbPsetString("@IMAGEURL", _imageurl);
                db.DbPsetDate("@CHG_DATE", DateTime.Now);
                db.DbPsetString("@CHG_USER_ID", _chg_user_id);
                //db.DbPsetString("@COMPANY_CD", _company_cd);
                db.DbPsetString("@MENU_GRP", _menu_grp);
                db.DbPsetInt("@MENU_NO", _menu_no);
            }
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

        /// <summary>
        /// バックメニューグループの取得
        /// 
        /// 使用画面：共通
        /// </summary>
        public int GetBackMenuGrp()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql ORACLE
            strSQL.Append("SELECT MI.MENU_GRP, MG.DEPT_CD       ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM MENU_ITEM MI");
                strSQL.Append("   WHERE MI.LEVEL = :LVL");
                strSQL.Append("   AND MI.PROGRAM_ID = :PROGRAM_ID");

                db.DbParametersClear();

                db.DbPsetInt("LVL", _lvl);
                db.DbPsetString("PROGRAM_ID", _program_id);
            }
            else
            {
                strSQL.Append(" FROM MENU_ITEM MI                                          ");
                strSQL.Append(" LEFT OUTER JOIN MENU_GROUP MG ON MI.MENU_GRP = MG.MENU_GRP ");
                strSQL.Append("   WHERE MI.LEVEL = @LVL");
                strSQL.Append("   AND MI.PROGRAM_ID = @PROGRAM_ID");

                db.DbParametersClear();

                db.DbPsetInt("@LVL", _lvl);
                db.DbPsetString("@PROGRAM_ID", _program_id);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _back_menu_grp = db.Row("MENU_GRP");
                _dept_cd = db.Row("DEPT_CD");
            }

            if (db.State() == ConnectionState.Open) db.DbClose();

            return rtn;
        }

        //Add 2013.09.02 Ubiq-Sai Begin
        /// <summary>
        /// バックメニューグループのLEVEL取得
        /// 
        /// 使用画面：共通
        /// </summary>
        public int GetBackMenuGrpLvl()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql ORACLE
            strSQL.Append("SELECT CASE WHEN MU.MENU_GRP IS NULL THEN -1 ELSE MIN(MI.LEVEL) END LEVEL ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM MENU_ITEM MI");
                strSQL.Append(" LEFT OUTER JOIN USER_MASTER MU ON MI.MENU_GRP = MU.MENU_GRP ");
                strSQL.Append("   WHERE MU.USER_ID = :USER_ID");
                strSQL.Append("   AND MI.PROGRAM_ID = :PROGRAM_ID");

                db.DbParametersClear();

                db.DbPsetString("USER_ID", _user_id);
                db.DbPsetString("PROGRAM_ID", _program_id);
            }
            else
            {
                strSQL.Append(" FROM MENU_ITEM MI                                           ");
                strSQL.Append(" LEFT OUTER JOIN USER_MASTER MU ON MI.MENU_GRP = MU.MENU_GRP ");
                strSQL.Append("   WHERE MU.USER_ID = @USER_ID");
                strSQL.Append("   AND MI.PROGRAM_ID = @PROGRAM_ID");
                strSQL.Append("   GROUP BY MU.MENU_GRP ");

                db.DbParametersClear();

                db.DbPsetString("@USER_ID", _user_id);
                db.DbPsetString("@PROGRAM_ID", _program_id);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _glvl = int.Parse(db.Row("LEVEL").ToString());
            }

            if (db.State() == ConnectionState.Open) db.DbClose();

            return rtn;
        }
        //Add 2013.09.02 Ubiq-Sai End

        /// <summary>
        /// メニュー項目より同じProgramIdのLvl最大値の取得
        /// 
        /// 使用画面：共通
        /// </summary>
        public int GetMaxMenuItemLvl()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql ORACLE
            strSQL.Append("SELECT MAX(MI.LEVEL) MAXLVL ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM MENU_ITEM MI");
                strSQL.Append("   WHERE MI.PROGRAM_ID = :PROGRAM_ID");
                strSQL.Append("   AND MI.MENU_GRP <> :MENU_GRP");

                db.DbParametersClear();

                db.DbPsetString("PROGRAM_ID", _program_id);
                db.DbPsetString("MENU_GRP", _menu_grp);
            }
            else
            {
                strSQL.Append(" FROM MENU_ITEM MI");
                strSQL.Append("   WHERE MI.PROGRAM_ID = @PROGRAM_ID");
                strSQL.Append("   AND MI.MENU_GRP <> @MENU_GRP");

                db.DbParametersClear();

                db.DbPsetString("@PROGRAM_ID", _program_id);
                db.DbPsetString("@MENU_GRP", _menu_grp);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                if (db.Row("MAXLVL").ToString() == "")
                {
                    _maxlvl = -1;
                }
                else
                {
                    _maxlvl = int.Parse(db.Row("MAXLVL").ToString());
                }
            }

            if (db.State() == ConnectionState.Open) db.DbClose();

            return rtn;
        }

        /// <summary>
        /// ProgramIdのURLの取得
        /// 
        /// 使用画面：共通
        /// </summary>
        public int GetAplProgramDetail()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT NAVIGATEURL                       ");
            strSQL.Append("FROM APL_PROGRAM                         ");
            if (_db_type == "ORACLE")
            {
                strSQL.Append("   WHERE PROGRAM_ID = :PROGRAM_ID");
                db.DbParametersClear();
                db.DbPsetString("PROGRAM_ID", _program_id);
            }
            else
            {
                strSQL.Append("   WHERE PROGRAM_ID = @PROGRAM_ID");
                db.DbParametersClear();
                db.DbPsetString("@PROGRAM_ID", _program_id);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _navigateurl = db.Row("NAVIGATEURL");
            }

            if (db.State() == ConnectionState.Open) db.DbClose();

            return rtn;
        }

        /// <summary>
        /// Add 10.08.02 Ubiq-Sai
        /// ユーザのProgramIdの処理権限の取得
        /// 1:照会のみ  2:照会・実行可
        /// 使用画面：共通
        /// </summary>
        public int GetUserProgramAuthority()
        {
            ComDB db = new ComDB(_db_type, "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" SELECT NVL(MAX(EXECUTABLE_FLAG),1) EXECUTABLE_FLAG                                  ");
                strSQL.Append(" FROM PROGRAM_AUTHORITY                                                              ");

                strSQL.Append(" WHERE (  ( AUTH_TYPE = 0 AND USER_ID = :USER_ID )                                   ");
                strSQL.Append("       OR ( AUTH_TYPE = 2 AND ROLE IN                                                ");
                strSQL.Append("            ( SELECT ROLE FROM USER_ROLE_MASTER WHERE USER_ID = :USER_ID )           ");
                strSQL.Append("          )                                                                          ");
                strSQL.Append("       )                                                                             ");
                strSQL.Append(" AND PROGRAM_ID = :PROGRAM_ID                                                        ");

                db.DbParametersClear();
                db.DbPsetString("USER_ID", _user_id);
                db.DbPsetString("PROGRAM_ID", _program_id);
            }
            else
            {
                strSQL.Append(" SELECT ISNULL(MAX(EXECUTABLE_FLAG),0) EXECUTABLE_FLAG                               ");
                strSQL.Append(" FROM PROGRAM_AUTHORITY                                                              ");

                strSQL.Append(" WHERE (  ( AUTH_TYPE = 0 AND USER_ID = @USER_ID )                                   ");
                strSQL.Append("       OR ( AUTH_TYPE = 2 AND ROLE IN                                                ");
                strSQL.Append("            ( SELECT ROLE FROM USER_ROLE_MASTER WHERE USER_ID = @USER_ID )           ");
                strSQL.Append("          )                                                                          ");
                strSQL.Append("       )                                                                             ");
                strSQL.Append(" AND PROGRAM_ID = @PROGRAM_ID                                                        ");

                db.DbParametersClear();
                db.DbPsetString("@USER_ID", _user_id);
                db.DbPsetString("@PROGRAM_ID", _program_id);
            }

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _executable_flag = int.Parse(db.Row("EXECUTABLE_FLAG"));
            }

            if (db.State() == ConnectionState.Open) db.DbClose();

            return rtn;
        }

    }
}