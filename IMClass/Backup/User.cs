using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;
using System.Globalization;

/// <summary>
/// ユーザークラス
/// </summary>
namespace IMClass
{
    public class User
    {

        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public User()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public User(string p_user_id, int p_lang)
        {
            _user_id = p_user_id;
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
        protected string _user_id = "";
        protected int _lang = 1;
        protected string _user_family_name = "";
        protected string _user_first_name = "";
        protected int _email_send_flag = 0;
        protected string _email = "";
        protected string _tel_no = "";
        protected string _login_password = "";
        protected string _password = "";
        protected string _past_password = "";
        protected string _past_password1 = "";
        protected string _past_password2 = "";
        protected DateTime _password_miss_date;
        protected int _password_miss_count = 0;
        protected DateTime _password_update_date;
        protected DateTime _last_login_date;
        protected int _acting_approver_flag = 0;
        protected string _acting_approver1 = "";
        protected string _acting_approver2 = "";
        protected string _acting_approver3 = "";
        protected string _acting_approver4 = "";
        protected string _acting_approver5 = "";
        protected string _acting_approver6 = "";
        protected string _acting_approver7 = "";
        protected string _acting_approver8 = "";
        protected string _acting_approver9 = "";
        protected int _acting_beg_eff_date = 0;
        protected int _acting_end_eff_date = 99999999;
        protected int _logical_del_flag = 0;
        protected string _menu_grp = "";
        protected DateTime _entry_date = DateTime.Now;
        protected DateTime _chg_date = DateTime.Now;
        protected string _chg_user_id = "";
        protected int _update_cntr = 0;
        protected string _dept_cd = "";
        protected int _beg_eff_date = 0;
        protected int _end_eff_date = 0;
        protected int _main_sub_type = 0;
        protected string _appointment_cd = "";
        protected string _search_dept_cd1 = "";
        protected string _search_dept_cd2 = "";
        protected string _search_dept_cd3 = "";
        protected string _search_appointment_cd1 = "";
        protected string _search_appointment_cd2 = "";
        protected string _search_appointment_cd3 = "";
        protected string _search_name = "";
        protected string _search_user_id = "";
        protected bool _search_comp_condition = false;
        protected string _name = "";
        protected string _dept_desc = "";
        protected bool _admin_flag = false;
        protected int _history_type = 0;
        protected int _err_code = 0;
        protected int _mail_send_flag = 0;
        protected int _date_from = 0;
        protected int _date_to = 0;
        protected bool _chk0 = false;
        protected bool _chk1 = false;
        protected bool _chk3 = false;
        protected bool _chk9 = false;
        protected string _dbmsg = "";
        protected string _strErr = "";

        protected int _nest_max_row = 10000;

        #endregion

        #region : プロパティ
        ///<summary>
        /// プロパティ
        ///</summary>
        public string user_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }

        public int lang
        {
            get { return _lang; }
            set { _lang = value; }
        }

        public string user_family_name
        {
            get { return _user_family_name; }
            set { _user_family_name = value; }
        }

        public string user_first_name
        {
            get { return _user_first_name; }
            set { _user_first_name = value; }
        }

        public int email_send_flag
        {
            get { return _email_send_flag; }
            set { _email_send_flag = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string tel_no
        {
            get { return _tel_no; }
            set { _tel_no = value; }
        }

        public string login_password
        {
            get { return _login_password; }
            set { _login_password = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string past_password
        {
            get { return _past_password; }
            set { _past_password = value; }
        }

        public string past_password1
        {
            get { return _past_password1; }
            set { _past_password1 = value; }
        }

        public string past_password2
        {
            get { return _past_password2; }
            set { _past_password2 = value; }
        }

        public DateTime password_miss_date
        {
            get { return _password_miss_date; }
            set { _password_miss_date = value; }
        }

        public int password_miss_count
        {
            get { return _password_miss_count; }
            set { _password_miss_count = value; }
        }

        public DateTime password_update_date
        {
            get { return _password_update_date; }
            set { _password_update_date = value; }
        }

        public DateTime last_login_date
        {
            get { return _last_login_date; }
            set { _last_login_date = value; }
        }

        public int acting_approver_flag
        {
            get { return _acting_approver_flag; }
            set { _acting_approver_flag = value; }
        }

        public string acting_approver1
        {
            get { return _acting_approver1; }
            set { _acting_approver1 = value; }
        }

        public string acting_approver2
        {
            get { return _acting_approver2; }
            set { _acting_approver2 = value; }
        }

        public string acting_approver3
        {
            get { return _acting_approver3; }
            set { _acting_approver3 = value; }
        }

        public string acting_approver4
        {
            get { return _acting_approver4; }
            set { _acting_approver4 = value; }
        }

        public string acting_approver5
        {
            get { return _acting_approver5; }
            set { _acting_approver5 = value; }
        }

        public string acting_approver6
        {
            get { return _acting_approver6; }
            set { _acting_approver6 = value; }
        }

        public string acting_approver7
        {
            get { return _acting_approver7; }
            set { _acting_approver7 = value; }
        }

        public string acting_approver8
        {
            get { return _acting_approver8; }
            set { _acting_approver8 = value; }
        }

        public string acting_approver9
        {
            get { return _acting_approver9; }
            set { _acting_approver9 = value; }
        }

        public int acting_beg_eff_date
        {
            get { return _acting_beg_eff_date; }
            set { _acting_beg_eff_date = value; }
        }

        public int acting_end_eff_date
        {
            get { return _acting_end_eff_date; }
            set { _acting_end_eff_date = value; }
        }

        public int logical_del_flag
        {
            get { return _logical_del_flag; }
            set { _logical_del_flag = value; }
        }

        public string menu_grp
        {
            get { return _menu_grp; }
            set { _menu_grp = value; }
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

        public string dept_cd
        {
            get { return _dept_cd; }
            set { _dept_cd = value; }
        }

        public int beg_eff_date
        {
            get { return _beg_eff_date; }
            set { _beg_eff_date = value; }
        }

        public int end_eff_date
        {
            get { return _end_eff_date; }
            set { _end_eff_date = value; }
        }

        public int main_sub_type
        {
            get { return _main_sub_type; }
            set { _main_sub_type = value; }
        }

        public string appointment_cd
        {
            get { return _appointment_cd; }
            set { _appointment_cd = value; }
        }

        public string dept_desc
        {
            get { return _dept_desc; }
            set { _dept_desc = value; }
        }

        public string search_dept_cd1
        {
            get { return _search_dept_cd1; }
            set { _search_dept_cd1 = value; }
        }

        public string search_dept_cd2
        {
            get { return _search_dept_cd2; }
            set { _search_dept_cd2 = value; }
        }

        public string search_dept_cd3
        {
            get { return _search_dept_cd3; }
            set { _search_dept_cd3 = value; }
        }

        public string search_appointment_cd1
        {
            get { return _search_appointment_cd1; }
            set { _search_appointment_cd1 = value; }
        }

        public string search_appointment_cd2
        {
            get { return _search_appointment_cd2; }
            set { _search_appointment_cd2 = value; }
        }

        public string search_appointment_cd3
        {
            get { return _search_appointment_cd3; }
            set { _search_appointment_cd3 = value; }
        }

        public string search_name
        {
            get { return _search_name; }
            set { _search_name = value; }
        }

        public string search_user_id
        {
            get { return _search_user_id; }
            set { _search_user_id = value; }
        }

        public bool search_comp_condition
        {
            get { return _search_comp_condition; }
            set { _search_comp_condition = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool admin_flag
        {
            get { return _admin_flag; }
            set { _admin_flag = value; }
        }

        public int history_type
        {
            get { return _history_type; }
            set { _history_type = value; }
        }

        public int err_code
        {
            get { return _err_code; }
            set { _err_code = value; }
        }

        public int mail_send_flag
        {
            get { return _mail_send_flag; }
            set { _mail_send_flag = value; }
        }

        public int date_from
        {
            get { return _date_from; }
            set { _date_from = value; }
        }

        public int date_to
        {
            get { return _date_to; }
            set { _date_to = value; }
        }

        public bool chk0
        {
            get { return _chk0; }
            set { _chk0 = value; }
        }

        public bool chk1
        {
            get { return _chk1; }
            set { _chk1 = value; }
        }

        public bool chk3
        {
            get { return _chk3; }
            set { _chk3 = value; }
        }

        public bool chk9
        {
            get { return _chk9; }
            set { _chk9 = value; }
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
        /// ユーザーの追加
        /// 
        /// 使用画面：MstUserMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;
            Encrypto en = new Encrypto();
            string codeStr;

            //--- sql
            strSQL.Append("INSERT INTO USER_MASTER ");
            strSQL.Append("(");
            strSQL.Append("USER_ID, LANG, USER_FAMILY_NAME, USER_FIRST_NAME,");
            strSQL.Append("EMAIL_SEND_FLAG, EMAIL, TEL_NO, PASSWORD,");
            strSQL.Append("PASSWORD_MISS_COUNT,");
            strSQL.Append("PASSWORD_UPDATE_DATE, ");
            strSQL.Append("ACTING_APPROVER_FLAG,");
            strSQL.Append("ACTING_APPROVER1, ACTING_APPROVER2, ACTING_APPROVER3,");
            strSQL.Append("ACTING_APPROVER4, ACTING_APPROVER5, ACTING_APPROVER6,");
            strSQL.Append("ACTING_APPROVER7, ACTING_APPROVER8, ACTING_APPROVER9,");
            strSQL.Append("ACTING_BEG_EFF_DATE, ACTING_END_EFF_DATE, MENU_GRP, ");
            strSQL.Append("LOGICAL_DEL_FLAG,");
            strSQL.Append("ENTRY_DATE, CHG_DATE, CHG_USER_ID, UPDATE_CNTR");
            strSQL.Append(") VALUES (");
            strSQL.Append("@USER_ID, @LANG, @USER_FAMILY_NAME, @USER_FIRST_NAME,");
            strSQL.Append("@EMAIL_SEND_FLAG, @EMAIL, @TEL_NO, @PASSWORD,");
            strSQL.Append("@PASSWORD_MISS_COUNT, ");
            strSQL.Append("@PASSWORD_UPDATE_DATE, ");
            strSQL.Append("@ACTING_APPROVER_FLAG, ");
            strSQL.Append("@ACTING_APPROVER1, @ACTING_APPROVER2, @ACTING_APPROVER3, ");
            strSQL.Append("@ACTING_APPROVER4, @ACTING_APPROVER5, @ACTING_APPROVER6, ");
            strSQL.Append("@ACTING_APPROVER7, @ACTING_APPROVER8, @ACTING_APPROVER9, ");
            strSQL.Append("@ACTING_BEG_EFF_DATE, @ACTING_END_EFF_DATE, @MENU_GRP, ");
            strSQL.Append("@LOGICAL_DEL_FLAG,");
            strSQL.Append("@ENTRY_DATE, @CHG_DATE, @CHG_USER_ID, @UPDATE_CNTR)");

            db.DbParametersClear();

            db.DbPsetString("@USER_ID", _user_id);
            db.DbPsetInt("@LANG", _lang);
            db.DbPsetString("@USER_FAMILY_NAME", _user_family_name);
            db.DbPsetString("@USER_FIRST_NAME", _user_first_name);
            db.DbPsetInt("@EMAIL_SEND_FLAG", _email_send_flag);
            db.DbPsetString("@EMAIL", _email);
            db.DbPsetString("@TEL_NO", _tel_no);
            codeStr = en.Code(_password);
            db.DbPsetString("@PASSWORD", codeStr);
            db.DbPsetInt("@PASSWORD_MISS_COUNT", _password_miss_count);
            db.DbPsetDate("@PASSWORD_UPDATE_DATE", DateTime.Now);
            db.DbPsetInt("@ACTING_APPROVER_FLAG", _acting_approver_flag);
            db.DbPsetString("@ACTING_APPROVER1", _acting_approver1);
            db.DbPsetString("@ACTING_APPROVER2", _acting_approver2);
            db.DbPsetString("@ACTING_APPROVER3", _acting_approver3);
            db.DbPsetString("@ACTING_APPROVER4", _acting_approver4);
            db.DbPsetString("@ACTING_APPROVER5", _acting_approver5);
            db.DbPsetString("@ACTING_APPROVER6", _acting_approver6);
            db.DbPsetString("@ACTING_APPROVER7", _acting_approver7);
            db.DbPsetString("@ACTING_APPROVER8", _acting_approver8);
            db.DbPsetString("@ACTING_APPROVER9", _acting_approver9);
            db.DbPsetInt("@ACTING_BEG_EFF_DATE", _acting_beg_eff_date);
            db.DbPsetInt("@ACTING_END_EFF_DATE", _acting_end_eff_date);
            db.DbPsetString("@MENU_GRP", _menu_grp);
            db.DbPsetInt("@LOGICAL_DEL_FLAG", _logical_del_flag);
            db.DbPsetDate("@ENTRY_DATE", DateTime.Now);
            db.DbPsetDate("@CHG_DATE", DateTime.Now);
            db.DbPsetString("@CHG_USER_ID", _chg_user_id);
            db.DbPsetInt("@UPDATE_CNTR", _update_cntr);

            db.DbBeginTrans();

            rtn = db.DbExecute(strSQL.ToString());
            if (rtn != ComConst.FAILED)
            {
                // 
                // ユーザーロール(PUBLIC)の追加　
                // 　
                Role rol = new Role(_user_id, _lang);
                rol.role = "PUBLIC";

                rtn = rol.DeleteUserRole();
                if (rtn == ComConst.FAILED)
                {
                    _dbmsg = rol.dbmsg;
                    _strErr = rol.strErr;
                    return rtn;
                }

                rtn = rol.InsertUserRole(db);
                if (rtn == ComConst.FAILED)
                {
                    _dbmsg = rol.dbmsg;
                    _strErr = rol.strErr;
                }
                // 成功したらCommit;
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
        /// ユーザーの変更
        /// 
        /// 使用画面：MstUserMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;
            int o_acting_approver_flag, o_acting_beg_eff_date, o_acting_end_eff_date;
            string o_acting_approver1, o_acting_approver2, o_acting_approver3, o_acting_approver4, o_acting_approver5,
                o_acting_approver6, o_acting_approver7, o_acting_approver8, o_acting_approver9;

            // 代理設定変更に備えて変更前の情報を得る
            strSQL.Append("SELECT ACTING_APPROVER_FLAG,");
            strSQL.Append("ACTING_APPROVER1, ACTING_APPROVER2, ACTING_APPROVER3,");
            strSQL.Append("ACTING_APPROVER4, ACTING_APPROVER5, ACTING_APPROVER6,");
            strSQL.Append("ACTING_APPROVER7, ACTING_APPROVER8, ACTING_APPROVER9,");
            strSQL.Append("ACTING_BEG_EFF_DATE, ACTING_END_EFF_DATE ");
            strSQL.Append(" FROM USER_MASTER ");
            strSQL.Append(" WHERE USER_ID = @USER_ID");

            db.DbParametersClear();

            db.DbPsetString("@USER_ID", _user_id);

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                return rtn;
            }
            else
            {
                o_acting_approver_flag = int.Parse(db.Row("ACTING_APPROVER_FLAG"));
                o_acting_approver1 = db.Row("ACTING_APPROVER1");
                o_acting_approver2 = db.Row("ACTING_APPROVER2");
                o_acting_approver3 = db.Row("ACTING_APPROVER3");
                o_acting_approver4 = db.Row("ACTING_APPROVER4");
                o_acting_approver5 = db.Row("ACTING_APPROVER5");
                o_acting_approver6 = db.Row("ACTING_APPROVER6");
                o_acting_approver7 = db.Row("ACTING_APPROVER7");
                o_acting_approver8 = db.Row("ACTING_APPROVER8");
                o_acting_approver9 = db.Row("ACTING_APPROVER9");
                o_acting_beg_eff_date = int.Parse(db.Row("ACTING_BEG_EFF_DATE"));
                o_acting_end_eff_date = int.Parse(db.Row("ACTING_END_EFF_DATE"));
            }

            db.DbCloseReader();

            //--- sql
            strSQL = new StringBuilder();
            strSQL.Append("UPDATE USER_MASTER ");
            strSQL.Append("SET ");
            strSQL.Append("LANG = @LANG,");
            strSQL.Append("USER_FAMILY_NAME = @USER_FAMILY_NAME,");
            strSQL.Append("USER_FIRST_NAME = @USER_FIRST_NAME,");
            strSQL.Append("EMAIL_SEND_FLAG = @EMAIL_SEND_FLAG,");
            strSQL.Append("EMAIL = @EMAIL,");
            strSQL.Append("TEL_NO = @TEL_NO,");
            strSQL.Append("PASSWORD_MISS_COUNT = @PASSWORD_MISS_COUNT,");
            strSQL.Append("ACTING_APPROVER_FLAG = @ACTING_APPROVER_FLAG,");
            strSQL.Append("ACTING_APPROVER1 = @ACTING_APPROVER1,");
            strSQL.Append("ACTING_APPROVER2 = @ACTING_APPROVER2,");
            strSQL.Append("ACTING_APPROVER3 = @ACTING_APPROVER3,");
            strSQL.Append("ACTING_APPROVER4 = @ACTING_APPROVER4,");
            strSQL.Append("ACTING_APPROVER5 = @ACTING_APPROVER5,");
            strSQL.Append("ACTING_APPROVER6 = @ACTING_APPROVER6,");
            strSQL.Append("ACTING_APPROVER7 = @ACTING_APPROVER7,");
            strSQL.Append("ACTING_APPROVER8 = @ACTING_APPROVER8,");
            strSQL.Append("ACTING_APPROVER9 = @ACTING_APPROVER9,");
            strSQL.Append("ACTING_BEG_EFF_DATE = @ACTING_BEG_EFF_DATE,");
            strSQL.Append("ACTING_END_EFF_DATE = @ACTING_END_EFF_DATE,");
            strSQL.Append("MENU_GRP = @MENU_GRP,");
            strSQL.Append("LOGICAL_DEL_FLAG = @LOGICAL_DEL_FLAG,");
            strSQL.Append("CHG_DATE = @CHG_DATE,");
            strSQL.Append("CHG_USER_ID = @CHG_USER_ID,");
            strSQL.Append("UPDATE_CNTR  = UPDATE_CNTR + 1");
            strSQL.Append(" WHERE USER_ID = @USER_ID");

            db.DbParametersClear();

            db.DbPsetInt("@LANG", _lang);
            db.DbPsetString("@USER_FAMILY_NAME", _user_family_name);
            db.DbPsetString("@USER_FIRST_NAME", _user_first_name);
            db.DbPsetInt("@EMAIL_SEND_FLAG", _email_send_flag);
            db.DbPsetString("@EMAIL", _email);
            db.DbPsetString("@TEL_NO", _tel_no);
            db.DbPsetInt("@PASSWORD_MISS_COUNT", _password_miss_count);
            db.DbPsetInt("@ACTING_APPROVER_FLAG", _acting_approver_flag);
            db.DbPsetString("@ACTING_APPROVER1", _acting_approver1);
            db.DbPsetString("@ACTING_APPROVER2", _acting_approver2);
            db.DbPsetString("@ACTING_APPROVER3", _acting_approver3);
            db.DbPsetString("@ACTING_APPROVER4", _acting_approver4);
            db.DbPsetString("@ACTING_APPROVER5", _acting_approver5);
            db.DbPsetString("@ACTING_APPROVER6", _acting_approver6);
            db.DbPsetString("@ACTING_APPROVER7", _acting_approver7);
            db.DbPsetString("@ACTING_APPROVER8", _acting_approver8);
            db.DbPsetString("@ACTING_APPROVER9", _acting_approver9);
            db.DbPsetInt("@ACTING_BEG_EFF_DATE", _acting_beg_eff_date);
            db.DbPsetInt("@ACTING_END_EFF_DATE", _acting_end_eff_date);
            db.DbPsetString("@MENU_GRP", _menu_grp);
            db.DbPsetInt("@LOGICAL_DEL_FLAG", _logical_del_flag);
            db.DbPsetDate("@CHG_DATE", DateTime.Now);
            db.DbPsetString("@CHG_USER_ID", _chg_user_id);
            db.DbPsetString("@USER_ID", _user_id);

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
        /// ユーザーパスワードの変更
        /// 
        /// 使用画面：AppUserMenu
        /// </summary>
        public int UpdatePassword()
        {
            ComDB db = new ComDB("", "COM");
            Encrypto en = new Encrypto();
            string oldPass, oldPass1, oldPass2, oldPass3;
            string codeStr;
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            // SYSTEM_PARAMETERより、パスワードのチェック条件を得る
            SystemParameter sp = new SystemParameter();
            sp.key01 = "PASSWORD_MIN_DIGITS";
            if (sp.GetDetail() == ComConst.FAILED)
            {
                //return ComConst.SYS_PARA_ERR;
                sp.data_int = 0;
            }

            // 最小桁数を満たさない場合はエラー
            if (sp.data_int > 0 && _password.Length < sp.data_int)
            {
                return ComConst.PWD_MIN_LEN_ERR;
            }

            // 前回パスワードチェック回数を得る
            sp.key01 = "PASSWORD_CHECK_COUNT";
            if (sp.GetDetail() == ComConst.FAILED)
            {
                //return ComConst.SYS_PARA_ERR;
                sp.data_int = 0;
            }

            if (sp.data_int > 3)
                sp.data_int = 3;
            int intPwdChkCnt = sp.data_int;

            // 前と同じパスワードはエラー
            codeStr = en.Code(_password);
            strSQL.Append("SELECT PASSWORD, PAST_PASSWORD, PAST_PASSWORD1, PAST_PASSWORD2 ");
            strSQL.Append(" FROM USER_MASTER ");
            strSQL.Append(" WHERE USER_ID = @USER_ID");

            db.DbParametersClear();

            db.DbPsetString("@USER_ID", _user_id);

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return rtn;
            }
            else
            {
                oldPass = db.Row("PASSWORD");
                oldPass1 = db.Row("PAST_PASSWORD");
                oldPass2 = db.Row("PAST_PASSWORD1");
                oldPass3 = db.Row("PAST_PASSWORD2");
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
            }

            if (codeStr == oldPass)
            {
                return ComConst.PWD_NO_CHG;
            }

            if (intPwdChkCnt >= 1 && codeStr == oldPass1)
            {
                return ComConst.PWD_NO_CHG1;
            }

            if (intPwdChkCnt >= 2 && codeStr == oldPass2)
            {
                return ComConst.PWD_NO_CHG2;
            }

            if (intPwdChkCnt >= 3 && codeStr == oldPass3)
            {
                return ComConst.PWD_NO_CHG3;
            }

            db = new ComDB("", "COM");

            //　パスワード変更
            strSQL = new StringBuilder();
            strSQL.Append("UPDATE USER_MASTER ");
            strSQL.Append("SET ");
            strSQL.Append("PASSWORD = @PASSWORD,");
            strSQL.Append("PAST_PASSWORD = PASSWORD,");
            strSQL.Append("PAST_PASSWORD1 = PAST_PASSWORD,");
            strSQL.Append("PAST_PASSWORD2 = PAST_PASSWORD1,");
            strSQL.Append("PASSWORD_UPDATE_DATE = @PASSWORD_UPDATE_DATE,");
            strSQL.Append("UPDATE_CNTR = UPDATE_CNTR + 1");
            strSQL.Append(" WHERE USER_ID = @USER_ID");

            db.DbParametersClear();

            db.DbPsetString("@PASSWORD", codeStr);
            db.DbPsetDate("@PASSWORD_UPDATE_DATE", DateTime.Now);
            db.DbPsetString("@USER_ID", _user_id);

            db.DbBeginTrans();

            rtn = db.DbExecute(strSQL.ToString());
            if (rtn != ComConst.FAILED)
            {
                // 履歴の書き出し
                _history_type = 3;      // Pwd Chg
                _err_code = 0;
                _mail_send_flag = 0;
                rtn = InsertLoginHist();

                db.DbCommit();
            }
            else
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                db.DbRollback();
            }

            //// 指定ユーザーがADMIN権限を持つか？
            //Role role = new Role(_user_id, _lang);
            //role.role = "ADMIN";
            //role.user_id = _user_id;

            //if (role.HasAuthority())
            //{
            //    _admin_flag = true;
            //}
            //else
            //{
            //    _admin_flag = false;
            //}

            return rtn;
        }

        /// <summary>
        /// ユーザーアカウントロックの解除
        /// 
        /// 使用画面：MstUserMnt
        /// </summary>
        public int UnLock()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //　ロック解除
            strSQL.Append("UPDATE USER_MASTER ");
            strSQL.Append("SET ");
            strSQL.Append("PASSWORD_MISS_COUNT = 0,");
            strSQL.Append("LAST_LOGIN_DATE = @LAST_LOGIN_DATE");
            strSQL.Append(" WHERE USER_ID = @USER_ID");

            db.DbParametersClear();

            db.DbPsetDate("@LAST_LOGIN_DATE", DateTime.Now);
            db.DbPsetString("@USER_ID", _user_id);

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
            if (db.State() == ConnectionState.Open)
                db.DbClose();

            return rtn;
        }

        /// <summary>
        /// ユーザーの削除
        /// 
        /// 使用画面：MstUserMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;
            bool blLogicalDel = false;

            if (blLogicalDel)
            {
                //--- sql
                strSQL.Append("UPDATE USER_MASTER ");
                strSQL.Append("SET ");
                strSQL.Append("LOGICAL_DEL_FLAG = 1, ");
                strSQL.Append("CHG_DATE = @CHG_DATE,");
                strSQL.Append("CHG_USER_ID = @CHG_USER_ID,");
                strSQL.Append("UPDATE_CNTR = UPDATE_CNTR + 1");
                strSQL.Append("WHERE USER_ID = @USER_ID");

                db.DbParametersClear();

                db.DbPsetDate("@CHG_DATE", DateTime.Now);
                db.DbPsetString("@CHG_USER_ID", _chg_user_id);
                db.DbPsetString("@USER_ID", _user_id);
            }
            else
            {
                //--- sql
                strSQL.Append("DELETE FROM USER_MASTER ");
                strSQL.Append(" WHERE USER_ID = @USER_ID");

                db.DbParametersClear();

                db.DbPsetString("@USER_ID", _user_id);

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
        /// ユーザーロールの削除
        /// 
        /// 使用画面：MstUserMnt
        /// </summary>
        public int DeleteUserRoleALL()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;
            bool blLogicalDel = false;

            if (!blLogicalDel)
            {
                //--- sql
                strSQL.Append("DELETE FROM USER_ROLE_MASTER ");
                strSQL.Append(" WHERE USER_ID = @USER_ID");

                db.DbParametersClear();

                db.DbPsetString("@USER_ID", _user_id);

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

            }

            return rtn;
        }


        /// <summary>
        /// ユーザー詳細の取得
        /// 指定したUSER_IDの内容を取得する
        /// 
        /// 使用画面：MstUserMnt
        /// </summary>
        public int GetDetail()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            strSQL.Append("SELECT USER_ID, LANG, USER_FAMILY_NAME, USER_FIRST_NAME,");
            strSQL.Append("EMAIL_SEND_FLAG, EMAIL, TEL_NO, PASSWORD, PAST_PASSWORD, PAST_PASSWORD1, PAST_PASSWORD2,");
            strSQL.Append("PASSWORD_MISS_DATE, PASSWORD_MISS_COUNT,");
            strSQL.Append("PASSWORD_UPDATE_DATE, LAST_LOGIN_DATE, ACTING_APPROVER_FLAG,");
            strSQL.Append("ACTING_APPROVER1, ACTING_APPROVER2, ACTING_APPROVER3,");
            strSQL.Append("ACTING_APPROVER4, ACTING_APPROVER5, ACTING_APPROVER6,");
            strSQL.Append("ACTING_APPROVER7, ACTING_APPROVER8, ACTING_APPROVER9,");
            strSQL.Append("ACTING_BEG_EFF_DATE, ACTING_END_EFF_DATE, MENU_GRP, LOGICAL_DEL_FLAG, ");
            strSQL.Append("ENTRY_DATE, CHG_DATE, CHG_USER_ID, UPDATE_CNTR, ");

            //--- sql
            strSQL.Append(" USER_FAMILY_NAME + ' ' + USER_FIRST_NAME AS NAME");
            strSQL.Append(" FROM USER_MASTER ");

            strSQL.Append(" WHERE USER_ID = @USER_ID");

            db.DbParametersClear();

            db.DbPsetString("@USER_ID", _user_id);

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                _user_id = db.Row("USER_ID");
                _lang = int.Parse(db.Row("LANG"));
                _user_family_name = db.Row("USER_FAMILY_NAME");
                _user_first_name = db.Row("USER_FIRST_NAME");
                _email_send_flag = int.Parse(db.Row("EMAIL_SEND_FLAG"));
                _email = db.Row("EMAIL");
                _tel_no = db.Row("TEL_NO");
                _password = db.Row("PASSWORD");
                _past_password = db.Row("PAST_PASSWORD");
                _past_password1 = db.Row("PAST_PASSWORD1");
                _past_password2 = db.Row("PAST_PASSWORD2");
                _password_miss_count = int.Parse(db.Row("PASSWORD_MISS_COUNT"));
                _acting_approver_flag = int.Parse(db.Row("ACTING_APPROVER_FLAG"));
                _acting_approver1 = db.Row("ACTING_APPROVER1");
                _acting_approver2 = db.Row("ACTING_APPROVER2");
                _acting_approver3 = db.Row("ACTING_APPROVER3");
                _acting_approver4 = db.Row("ACTING_APPROVER4");
                _acting_approver5 = db.Row("ACTING_APPROVER5");
                _acting_approver6 = db.Row("ACTING_APPROVER6");
                _acting_approver7 = db.Row("ACTING_APPROVER7");
                _acting_approver8 = db.Row("ACTING_APPROVER8");
                _acting_approver9 = db.Row("ACTING_APPROVER9");
                _acting_beg_eff_date = int.Parse(db.Row("ACTING_BEG_EFF_DATE"));
                _acting_end_eff_date = int.Parse(db.Row("ACTING_END_EFF_DATE"));
                _menu_grp = db.Row("MENU_GRP");
                _logical_del_flag = int.Parse(db.Row("LOGICAL_DEL_FLAG"));
                _entry_date = DateTime.Parse(db.Row("ENTRY_DATE"));
                _chg_date = DateTime.Parse(db.Row("CHG_DATE"));
                _chg_user_id = db.Row("CHG_USER_ID");
                _update_cntr = int.Parse(db.Row("UPDATE_CNTR"));
                _name = db.Row("NAME");
                try
                {
                    _password_miss_date = DateTime.Parse(db.Row("PASSWORD_MISS_DATE"));
                }
                catch
                {
                }
                try
                {
                    _password_update_date = DateTime.Parse(db.Row("PASSWORD_UPDATE_DATE"));
                }
                catch
                {
                }
                try
                {
                    _last_login_date = DateTime.Parse(db.Row("LAST_LOGIN_DATE"));
                }
                catch
                {
                }
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return rtn;
        }

        /// <summary>
        /// ユーザー一覧の取得
        /// </summary>
        public DataSet GetUserList()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT USER_ID, LANG, USER_FAMILY_NAME, USER_FIRST_NAME,");
            strSQL.Append("EMAIL_SEND_FLAG, EMAIL, TEL_NO, ");
            strSQL.Append("PASSWORD_MISS_DATE, PASSWORD_MISS_COUNT,");
            strSQL.Append("PASSWORD_UPDATE_DATE, LAST_LOGIN_DATE, ACTING_APPROVER_FLAG,");
            strSQL.Append("ACTING_APPROVER1, ACTING_APPROVER2, ACTING_APPROVER3,");
            strSQL.Append("ACTING_APPROVER4, ACTING_APPROVER5, ACTING_APPROVER6,");
            strSQL.Append("ACTING_APPROVER7, ACTING_APPROVER8, ACTING_APPROVER9,");
            strSQL.Append("ACTING_BEG_EFF_DATE, ACTING_END_EFF_DATE,");
            strSQL.Append("ENTRY_DATE, CHG_DATE, CHG_USER_ID, UPDATE_CNTR");
            strSQL.Append(" FROM USER_MASTER ");
            strSQL.Append(" WHERE LOGICAL_DEL_FLAG = 0 ");

            db.DbParametersClear();
            if (_user_id != "")
            {
                strSQL.Append(" AND USER_ID = @USER_ID");
                db.DbPsetString("@USER_ID", _user_id);
            }
            
            strSQL.Append(" ORDER BY USER_ID");

            //db.DbParametersClear();

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "user");
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
        /// ユーザー検索一覧の取得
        /// 
        /// 使用画面：MstUserMnt, MstRoleMnt
        /// </summary>
        public DataSet GetUserSearchList()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            // 指定ユーザの"システム権限"の有無
            Role rl = new Role(_user_id, _lang);
            rl.role = "ADMIN";

            bool hasAdminRole = rl.HasAuthority();

            db.DbParametersClear();

            //--- sql   ORACLE
            strSQL.Append("SELECT U.USER_ID,                                ");
            strSQL.Append("USER_FAMILY_NAME + ' ' + USER_FIRST_NAME AS NAME ");
            strSQL.Append(" FROM USER_MASTER U                              ");
            strSQL.Append(" WHERE U.LOGICAL_DEL_FLAG = 0                    ");
            /**************** Add begin by ubiq-chen *****************/
            if (search_user_id != "")
            {
                strSQL.Append(" AND U.USER_ID LIKE '%'+ @USER_ID +'%' ");
                db.DbPsetString("@USER_ID", _search_user_id);
            }
            if (search_name != "")
            {
                strSQL.Append(" AND (U.USER_FAMILY_NAME LIKE '%'+@NAME+'%' OR USER_FIRST_NAME LIKE '%'+@NAME+'%') ");
                db.DbPsetString("@NAME", _search_name);
            }
            strSQL.Append(" ORDER BY U.USER_ID");
            /**************** Add end by ubiq-chen*******************/

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "user");
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
        /// ユーザー名の取得
        /// 指定したUSER_IDのユーザー名を取得する
        /// 
        /// 使用画面：MstUserMnt, MstRoleMnt
        /// </summary>
        public string GetUserName(string p_user_id)
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            string strUserId = "";
            int rtn = 0;

            //--- sql

            strSQL.Append("SELECT USER_FAMILY_NAME + ' ' + USER_FIRST_NAME AS USER_NAME");

            strSQL.Append(" FROM USER_MASTER ");

            strSQL.Append(" WHERE USER_ID = @USER_ID");

            db.DbParametersClear();

            db.DbPsetString("@USER_ID", p_user_id);

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                strUserId = "N/A";
            }
            else
            {
                strUserId = db.Row("USER_NAME");
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return strUserId;
        }

        /// <summary>
        /// ユーザーメール情報の取得
        /// 指定したUSER_IDのメール情報を取得する
        /// 
        /// 使用画面：SendMail.Control()
        /// </summary>
        public int GetUserMail(string p_user_id)
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT USER_FAMILY_NAME + ' ' + USER_FIRST_NAME AS USER_NAME,");

            strSQL.Append("EMAIL_SEND_FLAG, EMAIL, LANG ");

            strSQL.Append(" FROM USER_MASTER ");

            strSQL.Append(" WHERE USER_ID = @USER_ID");

            db.DbParametersClear();

            db.DbPsetString("@USER_ID", p_user_id);

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
                _email_send_flag = ComConst.FAILED;
            }
            else
            {
                _name = db.Row("USER_NAME");
                _email_send_flag = int.Parse(db.Row("EMAIL_SEND_FLAG"));
                _email = db.Row("EMAIL");
                _lang = int.Parse(db.Row("LANG"));
                if (_email == "")
                    _email_send_flag = 0;
            }

            if (db.State() == ConnectionState.Open)
                db.DbClose();
            return _email_send_flag;
        }

        /// <summary>
        /// パスワードチェック
        /// </summary>
        public bool PasswordCheck()
        {
            Encrypto en = new Encrypto();
            string codeStr;
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();

            codeStr = en.Code(_login_password);

            if (this.GetDetail() == ComConst.FAILED)
            {
                _password = "";
                return false;
            }
            else
            {
                if (_logical_del_flag == 1)
                {
                    _password = "";
                    return false;
                }
                if (codeStr == _password)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// ログイン
        /// 
        /// 戻り値：0 正常
        ///         ComConst.PWD_CHG パスワード変更
        ///         ComConst.PWD_UNMATCH パスワード不一致
        ///         ComConst.USER_LOCKED ユーザーが無効
        ///         ComConst.USER_UNMATCH ユーザーが存在しない
        /// 
        /// 使用画面：AppUserMenu
        /// </summary>
        public int Login()
        {
            int rtn;
            int intMissCnt;
            int intExpireDays;
            int intInvalidDays;

            // 履歴用項目セット
            //
            _history_type = 0;
            _err_code = 0;
            _mail_send_flag = 0;

            // ユーザー・パスワードチェック
            if (this.PasswordCheck() == false)
            {
                if (_password == "")
                {
                    // ユーザーが存在しない

                    // 履歴の書き出し
                    _history_type = 9;      // Login err
                    _err_code = 1;          // User unmatch
                    rtn = InsertLoginHist();

                    //// メール送信
                    //SendMail mail = new SendMail(_user_id, _lang);
                    //mail.mail_type = "ABNORMAL_LOGIN_ATTEMPT";
                    //mail.err_code = _err_code;
                    //rtn = mail.Control();

                    return ComConst.USER_UNMATCH;
                }
                else
                {
                    // パスワード不一致
                    // 不一致情報をDBに書く
                    _password_miss_date = DateTime.Now;
                    _password_miss_count += 1;

                    rtn = Update();

                    // 履歴の書き出し
                    _history_type = 9;      // Login err
                    _err_code = 9;          // Pwd unmatch
                    rtn = InsertLoginHist();

                    //// メール送信
                    //SendMail mail = new SendMail(_user_id, _lang);
                    //mail.mail_type = "ABNORMAL_LOGIN_ATTEMPT";
                    //mail.err_code = _err_code;
                    //rtn = mail.Control();

                    return ComConst.PWD_UNMATCH;
                }
            }

            // アカウントロックチェック
            // SYSTEM_PARAMETERより、パスワードの入力ミス回数の条件を得る
            SystemParameter sp = new SystemParameter();
            sp.key01 = "PASSWORD_MISS_COUNT";
            if (sp.GetDetail() == ComConst.FAILED)
            {
                intMissCnt = 0;
            }
            else
            {
                intMissCnt = sp.data_int;
            }

            // 入力ミス回数をオーバーしている場合は、アカウントロック
            if (intMissCnt > 0 && _password_miss_count > intMissCnt)
            {
                // 履歴の書き出し
                _history_type = 9;      // Login err
                _err_code = 3;          // Acc Lock
                rtn = InsertLoginHist();

                //// メール送信
                //SendMail mail = new SendMail(_user_id, _lang);
                //mail.mail_type = "ABNORMAL_LOGIN_ATTEMPT";
                //mail.err_code = _err_code;
                //rtn = mail.Control();

                return ComConst.USER_LOCKED;
            }

            // SYSTEM_PARAMETERより、パスワードのチェック条件を得る
            sp.key01 = "PASSWORD_EXPIRE_DAYS";
            if (sp.GetDetail() == ComConst.FAILED)
            {
                intExpireDays = 0;
            }
            else
            {
                intExpireDays = sp.data_int;
            }

            // 変更日数のチェック
            // 最後のパスワード変更日から変更日数を経過した場合、パスワード変更を促す
            //-----liu-----Calendar myCal = CultureInfo.InvariantCulture.Calendar;
            //if (intExpireDays > 0 && _password_update_date != null && _password_update_date.Year != 1 && myCal.AddDays(_password_update_date, intExpireDays) < DateTime.Now)
            //{
            //    // 履歴の書き出し
            //    rtn = InsertLoginHist();

            //    return ComConst.PWD_CHG;
            //}

            // SYSTEM_PARAMETERより、ログインの有効期限チェック条件を得る
            sp.key01 = "LOGIN_EXPIRE_DAYS";
            if (sp.GetDetail() == ComConst.FAILED)
            {
                intInvalidDays = 0;
            }
            else
            {
                intInvalidDays = sp.data_int;
            }

            // 最終ログイン後の有効期限チェック
            //-----liu-----
            //if (intInvalidDays > 0 && _last_login_date != null && _last_login_date.Year != 1 && myCal.AddDays(_last_login_date, intInvalidDays) < DateTime.Now)
            //{
            //    // 履歴の書き出し
            //    _history_type = 9;      // Login err
            //    _err_code = 3;          // Acc Lock
            //    rtn = InsertLoginHist();

            //    //// メール送信
            //    //SendMail mail = new SendMail(_user_id, _lang);
            //    //mail.mail_type = "ABNORMAL_LOGIN_ATTEMPT";
            //    //mail.err_code = _err_code;
            //    //rtn = mail.Control();

            //    return ComConst.USER_LOCKED;
            //}
            _end_eff_date = 0;

            // SYSTEM_PARAMETERより、パスワードの変更を促す条件を得る
            sp.key01 = "PASSWORD_CHG_CONFIRM_DAYS";
            int intConfDays = 0;
            if (sp.GetDetail() == ComConst.FAILED)
            {
                intConfDays = 0;
            }
            else
            {
                intConfDays = sp.data_int;
            }

            // 最後のパスワード有効期限までの日数が変更を促す日数以内のときは、パスワード有効期限までの日数をセットする
            int intWarningDays = intExpireDays - intConfDays;
            //if (intConfDays > 0 && _password_update_date != null && _password_update_date.Year != 1 && myCal.AddDays(_password_update_date, intWarningDays) < DateTime.Now)
            //{
            //    //-----liu-----TimeSpan ts = myCal.AddDays(_password_update_date, intExpireDays) - DateTime.Now;
            //    //-----liu-----_end_eff_date = ts.Days;
            //}

            // ログイン情報をUPDATE
            _last_login_date = DateTime.Now;
            _password_miss_count = 0;

            rtn = UnLock(); // Update();

            // 指定ユーザーがADMIN権限を持つか？
            Role role = new Role(_user_id, _lang);
            role.role = "ADMIN";
            role.user_id = _user_id;

            if (role.HasAuthority())
            {
                _admin_flag = true;
            }
            else
            {
                _admin_flag = false;
            }

            // 履歴の書き出し
            rtn = InsertLoginHist();

            return 0;
        }

        //
        // ログアウト
        //
        public int Logout(string p_user_id)
        {
            //
            // 履歴の書き出し
            //
            _user_id = p_user_id;
            _history_type = 1;      // Logout
            _err_code = 0;
            _mail_send_flag = 0;

            int rtn = InsertLoginHist();
            return rtn;

        }

        /// <summary>
        /// アカウントロックのチェック
        /// 
        /// 使用画面：MstUserMnt
        /// </summary>
        public bool IsAccountLocked()
        {
            int intMissCnt;
            int intInvalidDays;

            // アカウントロックチェック
            // SYSTEM_PARAMETERより、パスワードの入力ミス回数の条件を得る
            SystemParameter sp = new SystemParameter();
            sp.key01 = "PASSWORD_MISS_COUNT";
            if (sp.GetDetail() == ComConst.FAILED)
            {
                intMissCnt = 0;
            }
            else
            {
                intMissCnt = sp.data_int;
            }

            // 入力ミス回数をオーバーしている場合は、アカウントロック
            if (intMissCnt > 0 && _password_miss_count > intMissCnt)
            {
                return true;
            }

            // SYSTEM_PARAMETERより、ログインの有効期限チェック条件を得る
            sp.key01 = "LOGIN_EXPIRE_DAYS";
            if (sp.GetDetail() == ComConst.FAILED)
            {
                intInvalidDays = 0;
            }
            else
            {
                intInvalidDays = sp.data_int;
            }

            // 最終ログイン後の有効期限チェック
            //-----liu-----Calendar myCal = CultureInfo.InvariantCulture.Calendar;
            //if (intInvalidDays > 0 && _last_login_date != null && _last_login_date.Year != 1 && myCal.AddDays(_last_login_date, intInvalidDays) < DateTime.Now)
            //{
            //    return true;
            //}

            return false;
        }

        /// <summary>
        /// ログイン履歴の追加
        /// 
        /// 使用画面：Login
        /// </summary>
        public int InsertLoginHist()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;
            Encrypto en = new Encrypto();

            //--- sql
            strSQL.Append("INSERT INTO LOGIN_HIST ");
            strSQL.Append("(");
            strSQL.Append("LOGIN_DATE, USER_ID, HISTORY_TYPE, ERR_CODE, MAIL_SEND_FLAG,");
            strSQL.Append("ENTRY_DATE, CHG_DATE, CHG_USER_ID, UPDATE_CNTR");
            strSQL.Append(") VALUES (");
            strSQL.Append("@LOGIN_DATE, @USER_ID, @HISTORY_TYPE, @ERR_CODE, @MAIL_SEND_FLAG,");
            strSQL.Append("@ENTRY_DATE, @CHG_DATE, @CHG_USER_ID, @UPDATE_CNTR)");

            db.DbParametersClear();

            db.DbPsetDate("@LOGIN_DATE", DateTime.Now);
            db.DbPsetString("@USER_ID", _user_id);
            db.DbPsetInt("@HISTORY_TYPE", _history_type);
            db.DbPsetInt("@ERR_CODE", _err_code);
            db.DbPsetInt("@MAIL_SEND_FLAG", _mail_send_flag);
            db.DbPsetDate("@ENTRY_DATE", DateTime.Now);
            db.DbPsetDate("@CHG_DATE", DateTime.Now);
            db.DbPsetString("@CHG_USER_ID", _user_id);
            db.DbPsetInt("@UPDATE_CNTR", 0);

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
        /// LOGIN履歴検索一覧の取得
        /// 
        /// 使用画面：AppLoginHistInq
        /// </summary>
        public DataSet GetLoginHistList()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            db.DbParametersClear();

            //--- sql   ORACLE
            strSQL.Append("SELECT L.USER_ID, ");

            strSQL.Append("dbo.ToDateTimeSTR( L.LOGIN_DATE ) AS LOGIN_DATE, ");

            strSQL.Append("CASE L.HISTORY_TYPE WHEN 0 THEN 'Login' WHEN 1 THEN 'Logout' WHEN 3 THEN 'Pwd Chg' WHEN 9 THEN 'Login Error' ELSE ' ' END AS HISTORY_TYPE, ");
            strSQL.Append("CASE L.ERR_CODE WHEN 0 THEN 'Normal' WHEN 1 THEN 'User Unmatch' WHEN 3 THEN 'Account Locked' WHEN 9 THEN 'Pwd Unmatch' ELSE ' ' END AS ERR_CODE, ");
            strSQL.Append("CASE L.MAIL_SEND_FLAG WHEN 0 THEN ' ' WHEN 1 THEN 'Done' ELSE ' ' END AS MAIL_SEND_FLAG, ");

            strSQL.Append("U.USER_FAMILY_NAME + ' ' + U.USER_FIRST_NAME AS NAME");

            strSQL.Append(" FROM LOGIN_HIST L ");
            strSQL.Append(" LEFT OUTER JOIN USER_MASTER U ON L.USER_ID = U.USER_ID ");

            strSQL.Append(" WHERE ");
            strSQL.Append("       dbo.ToYYYYMMDD( L.LOGIN_DATE ) >= @DATE_FROM");
            db.DbPsetString("@DATE_FROM", _date_from.ToString());
            strSQL.Append("   AND dbo.ToYYYYMMDD( L.LOGIN_DATE ) <= @DATE_TO");
            db.DbPsetString("@DATE_TO", _date_to.ToString());

            if (_search_user_id != "")
            {
                strSQL.Append("   AND L.USER_ID = @USER_ID");
                db.DbPsetString("@USER_ID", _search_user_id);
            }

            strSQL.Append("   AND HISTORY_TYPE IN (");

            bool chkFlag = false;

            if (_chk0)
            {
                strSQL.Append("0");
                chkFlag = true;
            }

            if (_chk1)
            {
                if (chkFlag)
                {
                    strSQL.Append(",1");
                }
                else
                {
                    strSQL.Append("1");
                    chkFlag = true;
                }
            }

            if (_chk3)
            {
                if (chkFlag)
                {
                    strSQL.Append(",3");
                }
                else
                {
                    strSQL.Append("3");
                    chkFlag = true;
                }
            }

            if (_chk9)
            {
                if (chkFlag)
                {
                    strSQL.Append(",9");
                }
                else
                {
                    strSQL.Append("9");
                    chkFlag = true;
                }
            }

            strSQL.Append(") ");

            strSQL.Append(" ORDER BY L.LOGIN_DATE DESC, L.USER_ID");

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "user");
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
        /// ログイン履歴の削除
        /// 指定した日付以前のログイン履歴を削除する
        /// 
        /// 使用画面：AppDataDel
        /// </summary>
        public int DeleteLoginHist(DateTime p_login_date)
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("DELETE FROM LOGIN_HIST ");
            strSQL.Append(" WHERE LOGIN_DATE <= @LOGIN_DATE");

            db.DbParametersClear();

            db.DbPsetDate("@LOGIN_DATE", p_login_date);

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