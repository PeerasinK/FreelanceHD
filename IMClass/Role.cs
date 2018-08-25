using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// ロールクラス
/// </summary>
namespace IMClass
{
    public class Role
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Role()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public Role(string p_user_id, int p_lang)
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
        protected int _lang = 1;
        protected string _user_id = "";
        protected string _role = "";
        protected string _role_desc = "";
        protected string _role_desc1 = "";
        protected string _role_desc2 = "";
        protected string _role_desc3 = "";
        protected string _role_desc4 = "";
        protected int _del_disable_flag = 0;
        protected DateTime _entry_date = DateTime.Now;
        protected DateTime _chg_date = DateTime.Now;
        protected string _chg_user_id = "";
        protected int _update_cntr = 0;
        protected string _dbmsg = "";
        protected string _strErr = "";

        protected string _mgmt_level = "";
        protected string _dept_no = "";
        protected string _process_no = "";
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
        public string user_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        public string role
        {
            get { return _role; }
            set { _role = value; }
        }
        public string role_desc
        {
            get { return _role_desc; }
            set { _role_desc = value; }
        }
        public string role_desc1
        {
            get { return _role_desc1; }
            set { _role_desc1 = value; }
        }
        public string role_desc2
        {
            get { return _role_desc2; }
            set { _role_desc2 = value; }
        }
        public string role_desc3
        {
            get { return _role_desc3; }
            set { _role_desc3 = value; }
        }
        public string role_desc4
        {
            get { return _role_desc4; }
            set { _role_desc4 = value; }
        }
        public int del_disable_flag
        {
            get { return _del_disable_flag; }
            set { _del_disable_flag = value; }
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
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }

        public string mgmt_level
        {
            get { return _mgmt_level; }
            set { _mgmt_level = value; }
        }
        public string dept_no
        {
            get { return _dept_no; }
            set { _dept_no = value; }
        }
        public string process_no
        {
            get { return _process_no; }
            set { _process_no = value; }
        }
        #endregion

        /// <summary>
        /// ロールの追加
        /// 
        /// 使用画面：MstRoleMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("INSERT INTO USER_ROLE_MASTER ");
            strSQL.Append("(");
            strSQL.Append("USER_GROUP_CODE, USER_GROUP_NAME, GROUP_ACTIVE, MANAGEMENT_LEVEL,");
            strSQL.Append("DEPT_NO, PROCESS_NO");
            strSQL.Append("ENTRY_DATE, UPDATE_DATE, USER_CREATE");
            strSQL.Append(") VALUES (");
            strSQL.Append("@ROLE, @ROLE_DESC, @DEL_DISABLE_FLAG, @MGMT_LEVEL,");
            strSQL.Append("@DEPT_NO, @PROCESS_NO");
            strSQL.Append("@ENTRY_DATE, @CHG_DATE, @CHG_USER_ID)");

            db.DbParametersClear();

            db.DbPsetString("@ROLE", _role);
            db.DbPsetString("@ROLE_DESC", _role_desc);
            db.DbPsetInt("@DEL_DISABLE_FLAG", _del_disable_flag);
            db.DbPsetInt("@MGMT_LEVEL", int.Parse(_mgmt_level));
            db.DbPsetInt("@DEPT_NO", int.Parse(_dept_no));
            db.DbPsetInt("@PROCESS_NO", int.Parse(_process_no));
            db.DbPsetDate("@ENTRY_DATE", DateTime.Now);
            db.DbPsetDate("@CHG_DATE", DateTime.Now);
            db.DbPsetString("@CHG_USER_ID", _chg_user_id);

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
        /// ロールの変更
        /// 
        /// 使用画面：MstRoleMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("UPDATE USER_ROLE_MASTER ");
            strSQL.Append("SET ");
            strSQL.Append("USER_GROUP_CODE = @ROLE,");
            strSQL.Append("USER_GROUP_NAME = @ROLE_DESC,");
            strSQL.Append("GROUP_ACTIVE = @DEL_DISABLE_FLAG,");
            strSQL.Append("MANAGEMENT_LEVEL = @MGMT_LEVEL,");
            strSQL.Append("DEPT_NO = @DEPT_NO,");
            strSQL.Append("PROCESS_NO = @PROCESS_NO,");
            strSQL.Append("UPDATE_DATE = @CHG_DATE,");
            strSQL.Append("USER_UPDATE = @CHG_USER_ID,");
            strSQL.Append(" WHERE ROLE = @ROLE");

            db.DbParametersClear();

            db.DbPsetString("@ROLE", _role);
            db.DbPsetString("@ROLE_DESC", _role_desc);
            db.DbPsetInt("@DEL_DISABLE_FLAG", _del_disable_flag);
            db.DbPsetString("@MGMT_LEVEL", _mgmt_level);
            db.DbPsetString("@DEPT_NO", _dept_no);
            db.DbPsetString("@PROCESS_NO", _process_no);
            db.DbPsetDate("@CHG_DATE", DateTime.Now);
            db.DbPsetString("@CHG_USER_ID", _chg_user_id);

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
        /// ロールの削除
        /// 
        /// 使用画面：MstRoleMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("DELETE FROM USER_ROLE_MASTER ");
            strSQL.Append(" WHERE ROLE = @ROLE");

            db.DbParametersClear();

            db.DbPsetString("@ROLE", _role);

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
        /// ロール一覧の取得
        /// 
        /// 使用画面：MstRoleMnt, MstUserMnt
        /// </summary>
        public DataSet GetRoleList()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            //strSQL.Append("SELECT ROLE, ROLE_DESC1, ROLE_DESC2, ROLE_DESC3,");
            //strSQL.Append("ROLE_DESC4, ");
            //switch (_lang)
            //{
            //    case 2:
            //        strSQL.Append("ROLE_DESC2 AS ROLE_DESC, ");
            //        break;
            //    case 3:
            //        strSQL.Append("ROLE_DESC3 AS ROLE_DESC, ");
            //        break;
            //    case 4:
            //        strSQL.Append("ROLE_DESC4 AS ROLE_DESC, ");
            //        break;
            //    default:
            //        strSQL.Append("ROLE_DESC1 AS ROLE_DESC, ");
            //        break;
            //}
            strSQL.Append("SELECT USER_GROUP_CODE, USER_GROUP_NAME, GROUP_ACTIVE,");
            strSQL.Append("MANAGEMENT_LEVEL, DEPT_NO, PROCESS_NO,");

            //strSQL.Append(" ENTRY_DATE, CHG_DATE, CHG_USER_ID,");
            //strSQL.Append(" UPDATE_CNTR");
            //strSQL.Append(" FROM ROLE_MASTER ");
            //strSQL.Append(" ORDER BY ROLE");
            strSQL.Append(" ENTRY_DATE, UPDATE_DATE, USER_CREATE, USER_UPDATE");
            strSQL.Append(" FROM USER_ROLE_MASTER ");

            db.DbParametersClear();
            if (_role != "")
            {
                strSQL.Append(" WHERE USER_GROUP_CODE = @ROLE ");
                db.DbPsetString("@ROLE", _role);
            }

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "role");
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
        /// ロール一覧の取得、空白行つき
        /// 
        /// 使用画面：AppRouteDef
        /// </summary>
        public DataSet GetRoleListWithBlank()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT '0' AS SORT_KEY, NULL AS ROLE, NULL AS ROLE_DESC ");

            strSQL.Append(" UNION ");

            strSQL.Append("SELECT '1', ROLE, ");

            switch (_lang)
            {
                case 2:
                    strSQL.Append("ROLE_DESC2 AS ROLE_DESC ");
                    break;
                case 3:
                    strSQL.Append("ROLE_DESC3 AS ROLE_DESC ");
                    break;
                case 4:
                    strSQL.Append("ROLE_DESC4 AS ROLE_DESC ");
                    break;
                default:
                    strSQL.Append("ROLE_DESC1 AS ROLE_DESC ");
                    break;
            }

            strSQL.Append(" FROM ROLE_MASTER ");
            strSQL.Append(" ORDER BY SORT_KEY, ROLE");

            //db.DbParametersClear();

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "role");
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
        /// ロール詳細の取得
        /// 
        /// 使用画面：MstRoleMnt
        /// </summary>
        public int GetRoleDetail()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            //strSQL.Append("SELECT ROLE_DESC1, ROLE_DESC2, ROLE_DESC3, DEL_DISABLE_FLAG,");
            //strSQL.Append("ROLE_DESC4, ");

            //switch (_lang)
            //{
            //    case 2:
            //        strSQL.Append("ROLE_DESC2 AS ROLE_DESC, ");
            //        break;
            //    case 3:
            //        strSQL.Append("ROLE_DESC3 AS ROLE_DESC, ");
            //        break;
            //    case 4:
            //        strSQL.Append("ROLE_DESC4 AS ROLE_DESC, ");
            //        break;
            //    default:
            //        strSQL.Append("ROLE_DESC1 AS ROLE_DESC, ");
            //        break;
            //}
            strSQL.Append("SELECT USER_GROUP_CODE, USER_GROUP_NAME, GROUP_ACTIVE,");
            strSQL.Append("MANAGEMENT_LEVEL, DEPT_NO, PROCESS_NO,");

            //strSQL.Append(" ENTRY_DATE, CHG_DATE, CHG_USER_ID,");
            //strSQL.Append(" UPDATE_CNTR");
            //strSQL.Append(" FROM ROLE_MASTER ");
            strSQL.Append(" ENTRY_DATE, UPDATE_DATE, USER_CREATE, USER_UPDATE");
            strSQL.Append(" FROM USER_ROLE_MASTER ");

            //strSQL.Append(" WHERE ROLE = @ROLE");
            strSQL.Append(" WHERE USER_GROUP_CODE = @ROLE");

            db.DbParametersClear();

            db.DbPsetString("@ROLE", _role);

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                _dbmsg = db.expmsg;
                _strErr = db.strErr;
            }
            else
            {
                //_role_desc1 = db.Row("ROLE_DESC1");
                //_role_desc2 = db.Row("ROLE_DESC2");
                //_role_desc3 = db.Row("ROLE_DESC3");
                //_role_desc4 = db.Row("ROLE_DESC4");
                //_role_desc = db.Row("ROLE_DESC");
                //_del_disable_flag = int.Parse(db.Row("DEL_DISABLE_FLAG"));
                //_entry_date = DateTime.Parse(db.Row("ENTRY_DATE"));
                //_chg_date = DateTime.Parse(db.Row("CHG_DATE"));
                //_chg_user_id = db.Row("CHG_USER_ID");
                //_update_cntr = int.Parse(db.Row("UPDATE_CNTR"));
                _role_desc = db.Row("USER_GROUP_NAME");
                _mgmt_level = db.Row("MANAGEMENT_LEVEL");
                _dept_no = db.Row("DEPT_NO");
                _process_no = db.Row("PROCESS_NO");
                _entry_date = DateTime.Parse(db.Row("ENTRY_DATE"));
                _chg_date = DateTime.Parse(db.Row("UPDATE_DATE"));
                _chg_user_id = db.Row("USER_UPDATE");
            }
            if (db.State() == ConnectionState.Open)
                db.DbClose();

            return rtn;
        }

        /// <summary>
        /// 指定ユーザー・ロールの追加
        /// 
        /// 使用画面：MstRoleMnt
        /// </summary>
        public int InsertUserRole()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("INSERT INTO USER_ROLE_MASTER ");
            strSQL.Append("(");
            strSQL.Append("USER_ID, ROLE, ");
            strSQL.Append("ENTRY_DATE, CHG_DATE, CHG_USER_ID,");
            strSQL.Append("UPDATE_CNTR");
            strSQL.Append(") VALUES (");
            strSQL.Append("@USER_ID, @ROLE,");
            strSQL.Append("@ENTRY_DATE, @CHG_DATE, @CHG_USER_ID, @UPDATE_CNTR)");

            db.DbParametersClear();

            db.DbPsetString("@USER_ID", _user_id);
            db.DbPsetString("@ROLE", _role);
            db.DbPsetDate("@ENTRY_DATE", DateTime.Now);
            db.DbPsetDate("@CHG_DATE", DateTime.Now);
            db.DbPsetString("@CHG_USER_ID", _chg_user_id);
            db.DbPsetInt("@UPDATE_CNTR", _update_cntr);

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
        /// 指定ユーザー・ロールの追加
        /// 
        /// 使用クラス：MstUserMnt→User.Insert
        /// </summary>
        public int InsertUserRole(ComDB db)
        {

            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("INSERT INTO USER_ROLE_MASTER ");
            strSQL.Append("(");
            strSQL.Append("USER_ID, ROLE, ");
            strSQL.Append("ENTRY_DATE, CHG_DATE, CHG_USER_ID,");
            strSQL.Append("UPDATE_CNTR");
            strSQL.Append(") VALUES (");
            strSQL.Append("@USER_ID, @ROLE,");
            strSQL.Append("@ENTRY_DATE, @CHG_DATE, @CHG_USER_ID, @UPDATE_CNTR)");

            db.DbParametersClear();

            db.DbPsetString("@USER_ID", _user_id);
            db.DbPsetString("@ROLE", _role);
            db.DbPsetDate("@ENTRY_DATE", DateTime.Now);
            db.DbPsetDate("@CHG_DATE", DateTime.Now);
            db.DbPsetString("@CHG_USER_ID", _chg_user_id);
            db.DbPsetInt("@UPDATE_CNTR", _update_cntr);

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
        /// 指定ユーザー・ロールの削除
        /// 
        /// 使用画面：MstRoleMnt
        /// </summary>
        public int DeleteUserRole()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("DELETE FROM USER_ROLE_MASTER ");
            strSQL.Append(" WHERE USER_ID = @USER_ID");
            strSQL.Append("   AND ROLE = @ROLE");

            db.DbParametersClear();

            db.DbPsetString("@USER_ID", _user_id);
            db.DbPsetString("@ROLE", _role);

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
        /// 指定ユーザーのロール一覧
        /// 
        /// 使用画面：MstUserMnt
        /// </summary>
        public DataSet GetRoleListByUser()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT UR.ROLE, R.ROLE_DESC1, R.ROLE_DESC2, R.ROLE_DESC3,");
            strSQL.Append("R.ROLE_DESC4,                                            ");
            switch (_lang)
            {
                case 2:
                    strSQL.Append("R.ROLE_DESC2 AS ROLE_DESC, ");
                    break;
                case 3:
                    strSQL.Append("R.ROLE_DESC3 AS ROLE_DESC, ");
                    break;
                case 4:
                    strSQL.Append("R.ROLE_DESC4 AS ROLE_DESC, ");
                    break;
                default:
                    strSQL.Append("R.ROLE_DESC1 AS ROLE_DESC, ");
                    break;
            }

            strSQL.Append(" UR.ENTRY_DATE, UR.CHG_DATE, UR.CHG_USER_ID,");
            strSQL.Append(" UR.UPDATE_CNTR");
            strSQL.Append(" FROM USER_ROLE_MASTER UR, ROLE_MASTER R");

            strSQL.Append(" WHERE UR.USER_ID = @USER_ID");
            strSQL.Append("   AND UR.ROLE = R.ROLE");

            strSQL.Append(" ORDER BY UR.ROLE");

            db.DbParametersClear();

            db.DbPsetString("@USER_ID", _user_id);

            try
            {
                ds = db.DbDataSet(strSQL.ToString(), "role");
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
        /// 指定ロールを持つユーザーの一覧
        /// 
        /// 使用画面：MstRoleMnt
        /// </summary>
        public DataSet GetUserListByRole()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT U.USER_ID, ");

            strSQL.Append("U.USER_FAMILY_NAME + ' ' + U.USER_FIRST_NAME AS USER_NAME ");

            strSQL.Append(" FROM USER_ROLE_MASTER UR, USER_MASTER U");

            strSQL.Append(" WHERE UR.ROLE = @ROLE");
            strSQL.Append("   AND U.USER_ID = UR.USER_ID");
            strSQL.Append("   AND U.LOGICAL_DEL_FLAG = 0 ");

            strSQL.Append(" ORDER BY U.USER_ID");

            db.DbParametersClear();

            db.DbPsetString("@ROLE", _role);

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
        /// 指定ユーザーに指定ロールの権限の有無
        /// 
        /// 使用画面@ MstRoleMnt, AppUserMenu
        /// </summary>
        public bool HasAuthority()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT ROLE");
            strSQL.Append(" FROM USER_ROLE_MASTER ");

            strSQL.Append(" WHERE USER_ID = @USER_ID");
            strSQL.Append("   AND ROLE = @ROLE");

            db.DbParametersClear();

            db.DbPsetString("@USER_ID", _user_id);
            db.DbPsetString("@ROLE", _role);

            rtn = db.DbExecuteReader(strSQL.ToString());
            if (rtn == ComConst.FAILED)
            {
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return false;
            }
            else
            {
                if (db.State() == ConnectionState.Open)
                    db.DbClose();
                return true;
            }
        }
    }

}