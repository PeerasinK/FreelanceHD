using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// ���[���N���X
/// </summary>
namespace IMClass
{
    public class Role
    {
        #region : �R���X�g���N�^
        /// <summary>
        /// �R���X�g���N�^
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

        #region : �t�B�[���h
        /// <summary>
        /// �t�B�[���h
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
        #endregion

        #region : �v���p�e�B
        ///<summary>
        /// �v���p�e�B
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
        #endregion

        /// <summary>
        /// ���[���̒ǉ�
        /// 
        /// �g�p��ʁFMstRoleMnt
        /// </summary>
        public int Insert()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("INSERT INTO ROLE_MASTER ");
            strSQL.Append("(");
            strSQL.Append("ROLE, ROLE_DESC1, ROLE_DESC2, ROLE_DESC3,");
            strSQL.Append("ROLE_DESC4,");
            strSQL.Append("ENTRY_DATE, CHG_DATE, CHG_USER_ID,");
            strSQL.Append("UPDATE_CNTR");
            strSQL.Append(") VALUES (");
            strSQL.Append("@ROLE, @ROLE_DESC1, @ROLE_DESC2, @ROLE_DESC3,");
            strSQL.Append("@ROLE_DESC4,");
            strSQL.Append("@ENTRY_DATE, @CHG_DATE, @CHG_USER_ID, @UPDATE_CNTR)");

            db.DbParametersClear();

            db.DbPsetString("@ROLE", _role);
            db.DbPsetString("@ROLE_DESC1", _role_desc1);
            db.DbPsetString("@ROLE_DESC2", _role_desc2);
            db.DbPsetString("@ROLE_DESC3", _role_desc3);
            db.DbPsetString("@ROLE_DESC4", _role_desc4);
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
        /// ���[���̕ύX
        /// 
        /// �g�p��ʁFMstRoleMnt
        /// </summary>
        public int Update()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("UPDATE ROLE_MASTER ");
            strSQL.Append("SET ");
            strSQL.Append("ROLE_DESC1 = @ROLE_DESC1,");
            strSQL.Append("ROLE_DESC2 = @ROLE_DESC2,");
            strSQL.Append("ROLE_DESC3 = @ROLE_DESC3,");
            strSQL.Append("ROLE_DESC4 = @ROLE_DESC4,");
            strSQL.Append("CHG_DATE = @CHG_DATE,");
            strSQL.Append("CHG_USER_ID = @CHG_USER_ID,");
            strSQL.Append("UPDATE_CNTR = UPDATE_CNTR + 1");
            strSQL.Append(" WHERE ROLE = @ROLE");

            db.DbParametersClear();

            db.DbPsetString("@ROLE_DESC1", _role_desc1);
            db.DbPsetString("@ROLE_DESC2", _role_desc2);
            db.DbPsetString("@ROLE_DESC3", _role_desc3);
            db.DbPsetString("@ROLE_DESC4", _role_desc4);
            db.DbPsetDate("@CHG_DATE", DateTime.Now);
            db.DbPsetString("@CHG_USER_ID", _chg_user_id);
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
        /// ���[���̍폜
        /// 
        /// �g�p��ʁFMstRoleMnt
        /// </summary>
        public int Delete()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("DELETE FROM ROLE_MASTER ");
            strSQL.Append(" WHERE ROLE = @ROLE");
            strSQL.Append("   AND DEL_DISABLE_FLAG = 0");

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
        /// ���[���ꗗ�̎擾
        /// 
        /// �g�p��ʁFMstRoleMnt, MstUserMnt
        /// </summary>
        public DataSet GetRoleList()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();

            //--- sql
            strSQL.Append("SELECT ROLE, ROLE_DESC1, ROLE_DESC2, ROLE_DESC3,");
            strSQL.Append("ROLE_DESC4, ");
            switch (_lang)
            {
                case 2:
                    strSQL.Append("ROLE_DESC2 AS ROLE_DESC, ");
                    break;
                case 3:
                    strSQL.Append("ROLE_DESC3 AS ROLE_DESC, ");
                    break;
                case 4:
                    strSQL.Append("ROLE_DESC4 AS ROLE_DESC, ");
                    break;
                default:
                    strSQL.Append("ROLE_DESC1 AS ROLE_DESC, ");
                    break;
            }

            strSQL.Append(" ENTRY_DATE, CHG_DATE, CHG_USER_ID,");
            strSQL.Append(" UPDATE_CNTR");
            strSQL.Append(" FROM ROLE_MASTER ");
            strSQL.Append(" ORDER BY ROLE");

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
        /// ���[���ꗗ�̎擾�A�󔒍s��
        /// 
        /// �g�p��ʁFAppRouteDef
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
        /// ���[���ڍׂ̎擾
        /// 
        /// �g�p��ʁFMstRoleMnt
        /// </summary>
        public int GetRoleDetail()
        {
            ComDB db = new ComDB("", "COM");
            StringBuilder strSQL = new StringBuilder();
            int rtn = 0;

            //--- sql
            strSQL.Append("SELECT ROLE_DESC1, ROLE_DESC2, ROLE_DESC3, DEL_DISABLE_FLAG,");
            strSQL.Append("ROLE_DESC4, ");

            switch (_lang)
            {
                case 2:
                    strSQL.Append("ROLE_DESC2 AS ROLE_DESC, ");
                    break;
                case 3:
                    strSQL.Append("ROLE_DESC3 AS ROLE_DESC, ");
                    break;
                case 4:
                    strSQL.Append("ROLE_DESC4 AS ROLE_DESC, ");
                    break;
                default:
                    strSQL.Append("ROLE_DESC1 AS ROLE_DESC, ");
                    break;
            }

            strSQL.Append(" ENTRY_DATE, CHG_DATE, CHG_USER_ID,");
            strSQL.Append(" UPDATE_CNTR");
            strSQL.Append(" FROM ROLE_MASTER ");

            strSQL.Append(" WHERE ROLE = @ROLE");

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
                _role_desc1 = db.Row("ROLE_DESC1");
                _role_desc2 = db.Row("ROLE_DESC2");
                _role_desc3 = db.Row("ROLE_DESC3");
                _role_desc4 = db.Row("ROLE_DESC4");
                _role_desc = db.Row("ROLE_DESC");
                _del_disable_flag = int.Parse(db.Row("DEL_DISABLE_FLAG"));
                _entry_date = DateTime.Parse(db.Row("ENTRY_DATE"));
                _chg_date = DateTime.Parse(db.Row("CHG_DATE"));
                _chg_user_id = db.Row("CHG_USER_ID");
                _update_cntr = int.Parse(db.Row("UPDATE_CNTR"));
            }
            if (db.State() == ConnectionState.Open)
                db.DbClose();

            return rtn;
        }

        /// <summary>
        /// �w�胆�[�U�[�E���[���̒ǉ�
        /// 
        /// �g�p��ʁFMstRoleMnt
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
        /// �w�胆�[�U�[�E���[���̒ǉ�
        /// 
        /// �g�p�N���X�FMstUserMnt��User.Insert
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
        /// �w�胆�[�U�[�E���[���̍폜
        /// 
        /// �g�p��ʁFMstRoleMnt
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
        /// �w�胆�[�U�[�̃��[���ꗗ
        /// 
        /// �g�p��ʁFMstUserMnt
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
        /// �w�胍�[���������[�U�[�̈ꗗ
        /// 
        /// �g�p��ʁFMstRoleMnt
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
        /// �w�胆�[�U�[�Ɏw�胍�[���̌����̗L��
        /// 
        /// �g�p���@ MstRoleMnt, AppUserMenu
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