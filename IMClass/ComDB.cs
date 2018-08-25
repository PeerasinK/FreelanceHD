using System;
using System.Data;
//using System.Data.OracleClient;   // future use
using System.Data.SqlClient;
using System.Web.Configuration;
//using System.Collections.Specialized;

/// <summary>
/// DataBase�ڑ��N���X
/// </summary>
/// <remarks></remarks>
namespace IMClass
{
    public class ComDB
    {

        #region : �R���X�g���N�^
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public ComDB()
        {
            //�R�l�N�V���� �C���X�^���X�̍쐬
            _cn = new SqlConnection();
            //�R�}���h �C���X�^���X�̍쐬
            _cm = new SqlCommand();

            //web.config���R�l�N�V�����X�g�����O���擾
            _cn.ConnectionString = WebConfigurationManager.ConnectionStrings["IM"].ConnectionString;
        }

        public ComDB(string p_db_type)
        {
            _db_type = p_db_type;

            if (_db_type == "ORACLE")
            {
                /*
                //�R�l�N�V���� �C���X�^���X�̍쐬
                _cn_ora = new OracleConnection();
                //�R�}���h �C���X�^���X�̍쐬
                _cm_ora = new OracleCommand();

                //web.config���R�l�N�V�����X�g�����O���擾
                //        _cn.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString"];
                _cn_ora.ConnectionString = WebConfigurationManager.ConnectionStrings["IM"].ConnectionString;
                */
            }
            else
            {
                //�R�l�N�V���� �C���X�^���X�̍쐬
                _cn = new SqlConnection();
                //�R�}���h �C���X�^���X�̍쐬
                _cm = new SqlCommand();

                //web.config���R�l�N�V�����X�g�����O���擾
                //        _cn.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString"];
                _cn.ConnectionString = WebConfigurationManager.ConnectionStrings["IM"].ConnectionString;
            }
        }

        public ComDB(string p_db_type, string p_db)
        {
            _db_type = p_db_type;
            _db = p_db;

            if (_db_type == "ORACLE")
            {
                /*
                //�R�l�N�V���� �C���X�^���X�̍쐬
                _cn_ora = new OracleConnection();
                //�R�}���h �C���X�^���X�̍쐬
                _cm_ora = new OracleCommand();

                //web.config���R�l�N�V�����X�g�����O���擾
                //        _cn.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString"];
                _cn_ora.ConnectionString = WebConfigurationManager.ConnectionStrings["IM"].ConnectionString;
                */
            }
            else
            {
                //�R�l�N�V���� �C���X�^���X�̍쐬
                _cn = new SqlConnection();
                //�R�}���h �C���X�^���X�̍쐬
                _cm = new SqlCommand();

                //web.config���R�l�N�V�����X�g�����O���擾
                //        _cn.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString"];
                if (_db == "IM")
                {
                    _cn.ConnectionString = WebConfigurationManager.ConnectionStrings["IM"].ConnectionString;
                }
                else
                {
                    _cn.ConnectionString = WebConfigurationManager.ConnectionStrings["COM"].ConnectionString;
                }
            }
        }
        #endregion

        #region : �t�B�[���h
        /// <summary>
        /// �t�B�[���h
        /// </summary>
        protected SqlConnection _cn;
        protected SqlCommand _cm;
        protected SqlDataReader _dr;
        protected SqlDataAdapter _da;
        protected SqlTransaction _trans;
        /*
        protected OracleConnection _cn_ora;
        protected OracleCommand _cm_ora;
        protected OracleDataReader _dr_ora;
        protected OracleDataAdapter _da_ora;
        protected OracleTransaction _trans_ora;
        */
        protected string _db_type;
        protected string _db;
        protected string _strErr;
        protected string _expmsg;
        protected int _Rows;                //ADD 2011/2/4

        /// <summary>
        /// �萔��`
        /// </summary>
        //public const int SUCCEED = 0;
        //public const int FAILED = -1;
        #endregion

        #region : �v���p�e�B
        /// <summary>
        /// �v���p�e�B
        /// </summary>
        /*
        public SqlConnection cn
        {
            get { return _cn; }
            set { _cn = value; }
        }

        public SqlCommand cm
        {
            get { return _cm; }
            set { _cm = value; }
        }

        public SqlDataReader dr
        {
            get { return _dr; }
            set { _dr = value; }
        }

        public SqlDataAdapter da
        {
            get { return _da; }
            set { _da = value; }
        }
        */
        public string strErr
        {
            get { return _strErr; }
            set { _strErr = value; }
        }

        public string expmsg
        {
            get { return _expmsg; }
            set { _expmsg = value; }
        }

        public int Rows { get { return _Rows; } }   //ADD 2011/2/4
        #endregion

        #region : �f�[�^�[�x�[�X�ڑ�
        /// <summary>
        /// �f�[�^�[�x�[�X�ڑ�
        /// 
        /// ���g�p
        /// </summary>
        public SqlConnection DbConnection()
        {
            try
            {
                _cn.Open();
                return _cn;

            }
            catch (Exception e)
            {
                String strErr;

                strErr = e.ToString();
                System.Console.Out.Write(strErr);
                return _cn;
            }

        }
        #endregion

        #region : �f�[�^�[�x�[�X�ڑ��̏I��
        /// <summary>
        /// �f�[�^�[�x�[�X�ڑ��̏I��
        /// </summary>
        public Boolean DbClose()
        {
            try
            {
                if (_db_type == "ORACLE")
                {
                    /*
                    _cn_ora.Close();
                    _cn_ora.Dispose();
                     */
                }
                else
                {
                    if (_trans != null)  // 2012/03/02
                    {
                        try
                        {
                            _trans.Rollback();
                        }
                        catch { }
                        _trans = null;  //ADD 2009/3/18
                    }
                    _cn.Close();
                    _cn.Dispose();
                }

                return true;

            }
            catch (Exception e)
            {
                String strErr;

                strErr = e.ToString();
                System.Console.Out.Write(strErr);
                return false;
            }
        }
        #endregion

        #region: �R�l�N�V�������
        /// <summary>
        /// �R�l�N�V�������
        /// </summary>
        public ConnectionState State()
        {
            /*
            if (_db_type == "ORACLE")
            {
                return _cn_ora.State;
            }
            else
            {
             */
            return _cn.State;
            //}
        }
        #endregion

        #region: �g�����U�N�V�����J�n
        /// <summary>
        /// �g�����U�N�V�����J�n
        /// </summary>
        public void DbBeginTrans()
        {

            try
            {
                if (_db_type == "ORACLE")
                {
                    /*
                    if (_cn_ora.State != ConnectionState.Open)
                        _cn_ora.Open();
                    _trans_ora = _cn_ora.BeginTransaction(IsolationLevel.ReadCommitted);
                    _cm_ora.Transaction = _trans_ora;
                     */
                }
                else
                {
                    if (_cn.State != ConnectionState.Open)
                        _cn.Open();
                    _trans = _cn.BeginTransaction(IsolationLevel.ReadCommitted);
                    _cm.Transaction = _trans;
                }
            }
            catch (Exception e)
            {
                _expmsg = e.Message;
                _strErr = e.ToString();
            }
        }
        #endregion


        #region : �R�~�b�g
        /// <summary>
        /// �R�~�b�g
        /// </summary>
        public void DbCommit()
        {
            try
            {
                if (_db_type == "ORACLE")
                {
                    /*
                    _trans_ora.Commit();
                    _cn_ora.Close();
                     */
                }
                else
                {
                    try
                    {
                        _trans.Commit();
                    }
                    catch { }
                    _trans = null;  //ADD 2009/3/18
                    _cn.Close();
                    _cn.Dispose();  //ADD 2012/3/2
                }
            }
            catch (Exception e)
            {
                string strErr;

                strErr = e.ToString();
                System.Console.Out.Write(strErr);
            }
        }
        #endregion

        #region : ���[���o�b�N
        /// <summary>
        /// ���[���o�b�N
        /// </summary>
        public void DbRollback()
        {
            try
            {
                if (_db_type == "ORACLE")
                {
                    /*
                    _trans_ora.Rollback();
                    _cn_ora.Close();
                     */
                }
                else
                {
                    if (_trans != null)  // 2012/03/02
                    {
                        try
                        {
                            _trans.Rollback();
                        }
                        catch { }
                        _trans = null;  //ADD 2009/3/18
                    }
                    _cn.Close();
                    _cn.Dispose();  //ADD 2012/3/2
                }
            }
            catch (Exception e)
            {
                _expmsg = e.Message;
                _strErr = e.ToString();
            }
        }
        #endregion

        #region : SQL�̎��s
        /// <summary>
        /// SQL�̎��s
        /// </summary>
        public int DbExecute(string strSql)
        {
            //if (_db_type == "ORACLE")
            //{
            //    _cm_ora.CommandType = CommandType.Text;
            //    try
            //    {
            //        int rtn;
            //        if (_cn_ora.State != ConnectionState.Open)
            //            _cn_ora.Open();
            //        _cm_ora.Connection = _cn_ora;
            //        _cm_ora.CommandText = strSql;

            //        rtn = _cm_ora.ExecuteNonQuery();

            //        return rtn;
            //    }
            //    catch (Exception e)
            //    {
            //        _expmsg = e.Message;
            //        _strErr = e.ToString();
            //        return ComConst.FAILED;
            //    }
            //}
            //else
            //{
            _cm.CommandType = CommandType.Text;
            try
            {
                int rtn;
                if (_cn.State != ConnectionState.Open)
                    _cn.Open();
                _cm.Connection = _cn;
                _cm.CommandText = strSql;
                _cm.CommandTimeout = 0;     // 2010.09.24 add 0�͖���

                rtn = _cm.ExecuteNonQuery();
               _Rows = rtn;                //ADD 2011/2/4

                return rtn;
            }
            catch (Exception e)
            {
                _expmsg = e.Message;
                _strErr = e.ToString();
                return ComConst.FAILED;
            }
            //}
        }
        #endregion

        #region : �f�[�^���[�_
        public int DbExecuteReader(string strSql)
        {
            //if (_db_type == "ORACLE")
            //{
            //    try
            //    {
            //        _expmsg = "";
            //        _strErr = "";
            //        if (_cn_ora.State != ConnectionState.Open)
            //            _cn_ora.Open();

            //        _cm_ora.CommandType = CommandType.Text;
            //        _cm_ora.Connection = _cn_ora;
            //        _cm_ora.CommandText = strSql;
            //        //            _cm.Connection.Open();

            //        _dr_ora = _cm_ora.ExecuteReader();

            //        if (_dr_ora.Read())
            //        {
            //            return 0;
            //        }
            //        else
            //        {
            //            return ComConst.FAILED;
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        _expmsg = e.Message;
            //        _strErr = e.ToString();
            //        return -1;
            //    }
            //}
            //else
            //{
            try
            {
                _expmsg = "";
                _strErr = "";
                if (_cn.State != ConnectionState.Open)
                    _cn.Open();

                _cm.CommandType = CommandType.Text;
                _cm.Connection = _cn;
                _cm.CommandText = strSql;
                _cm.CommandTimeout = 0;     // 2010.09.24 add 0�͖���
                //            _cm.Connection.Open();

                _dr = _cm.ExecuteReader();

                if (_dr.Read())
                {
                    return 0;
                }
                else
                {
                    return ComConst.FAILED;
                }
            }
            catch (Exception e)
            {
                _expmsg = e.Message;
                _strErr = e.ToString();
                return -1;
            }
            //}
        }
        public string Row(string p_field_name)
        {
            //if (_db_type == "ORACLE")
            //{
            //    return _dr_ora[p_field_name].ToString();
            //}
            //else
            //{
            return _dr[p_field_name].ToString();
            //}
        }
        public int DbCloseReader()
        {
            try
            {
                _expmsg = "";
                _strErr = "";
                //if (_db_type == "ORACLE")
                //{
                //    _dr_ora.Close();
                //}
                //else
                //{
                _dr.Close();
                //}
            }
            catch
            {
            }
            return 0;
        }
        #endregion

        public DataSet DbDataSet(string strSql, string tblName)
        {
            //if (_db_type == "ORACLE")
            //{
            //try
            //{
            //    DataSet ds = new DataSet();
            //    _da_ora = new OracleDataAdapter();
            //    _cm_ora.CommandType = CommandType.Text;
            //    _cm_ora.Connection = _cn_ora;
            //    _da_ora.SelectCommand = _cm_ora;

            //    //--- Connection Open
            //    if (_cn_ora.State != ConnectionState.Open)
            //        _cn_ora.Open();

            //    //'--- Fill
            //    _cm_ora.CommandText = strSql;
            //    _da_ora.Fill(ds, tblName);

            //    return ds;
            //}
            //catch (Exception e)
            //{
            //    _expmsg = e.Message;
            //    _strErr = e.ToString();
            //    return null;
            //}
            //}
            //else
            //{
            try
            {
                DataSet ds = new DataSet();
                _da = new SqlDataAdapter();
                _cm.CommandType = CommandType.Text;
                _cm.Connection = _cn;
                _cm.CommandTimeout = 0;     // 2010.09.24 add 0�͖���
                _da.SelectCommand = _cm;

                //--- Connection Open
                if (_cn.State != ConnectionState.Open)
                    _cn.Open();

                //'--- Fill
                _cm.CommandText = strSql;
                _da.Fill(ds, tblName);

                return ds;
            }
            catch (Exception e)
            {
                _expmsg = e.Message;
                _strErr = e.ToString();
                return null;
            }
            //}
        }

        public int DbUpdateByDS(DataSet ds, string tblName)
        {
            //if (_db_type == "ORACLE")
            //{
            //try
            //{
            //    DataTable dt = ds.Tables[tblName];

            //    // First process deletes.
            //    _da_ora.Update(dt.Select(null, null, DataViewRowState.Deleted));

            //    // Next process updates.
            //    _da_ora.Update(dt.Select(null, null, DataViewRowState.ModifiedCurrent));

            //    // Finally, process inserts.
            //    _da_ora.Update(dt.Select(null, null, DataViewRowState.Added));

            //    return 0;
            //}
            //catch (Exception e)
            //{
            //    _expmsg = e.Message;
            //    _strErr = e.ToString();
            //    return ComConst.FAILED;
            //}
            //}
            //else
            //{
            try
            {
                DataTable dt = ds.Tables[tblName];

                // First process deletes.
                _da.Update(dt.Select(null, null, DataViewRowState.Deleted));

                // Next process updates.
                _da.Update(dt.Select(null, null, DataViewRowState.ModifiedCurrent));

                // Finally, process inserts.
                _da.Update(dt.Select(null, null, DataViewRowState.Added));

                return 0;
            }
            catch (Exception e)
            {
                _expmsg = e.Message;
                _strErr = e.ToString();
                return ComConst.FAILED;
            }
            //}
        }

        public int DbStored(string procnm)
        {
            int rtn;

            //if (_db_type == "ORACLE")
            //{
            //    _cm_ora.Connection = _cn_ora;
            //    _cm_ora.CommandText = procnm;
            //    _cm_ora.CommandType = CommandType.StoredProcedure;
            //    rtn = _cm_ora.ExecuteNonQuery();
            //    //if (rtn == 1)
            //    //{
            //    //    return int.Parse(_cm_ora.Parameters["rtn"].Value.ToString());
            //    //}
            //    //else
            //    //{
            //    //    return ComConst.FAILED;
            //    //}
            //    try
            //    {
            //        return int.Parse(_cm_ora.Parameters["rtn"].Value.ToString());
            //    }
            //    catch
            //    {
            //        return ComConst.FAILED;
            //    }
            //}
            //else
            //{
            // 2011.03.08
            if (_cn.State != ConnectionState.Open)
                _cn.Open();

            _cm.Connection = _cn;
            _cm.CommandText = procnm;
            _cm.CommandType = CommandType.StoredProcedure;
            _cm.CommandTimeout = 0;     // 2010.09.24 add 0�͖���

            try
            {
                rtn = _cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                strErr = ex.Message;
                return -1;
            }
            //if (rtn == 1)
            //{
            //    return int.Parse(_cm.Parameters["rtn"].Value.ToString());
            //}
            //else
            //{
            //    return ComConst.FAILED;
            //}
            try
            {
                return int.Parse(_cm.Parameters["RET"].Value.ToString());
            }
            catch
            {
                return ComConst.FAILED;
            }
            //}
        }

        //--------------------------------------------------------------
        // �p�����[�^�̐ݒ�
        //--------------------------------------------------------------
        // �p�����[�^�̃N���A
        public void DbParametersClear()
        {
            //if (_db_type == "ORACLE")
            //{
            //    _cm_ora.Parameters.Clear();
            //}
            //else
            //{
            _cm.Parameters.Clear();
            //}
        }

        // �ߒl
        public void DbPsetReturn()
        {
            //if (_db_type == "ORACLE")
            //{
            //    _cm_ora.Parameters.Clear();
            //    _cm_ora.Parameters.Add("rtn", OracleType.Int32, 1).Value = 0;
            //    _DirectionSet("rtn", ComConst.DB_RTN);
            //}
            //else
            //{
            _cm.Parameters.Clear();
            _cm.Parameters.Add("rtn", SqlDbType.Int, 1).Value = 0;
            _DirectionSet("rtn", ComConst.DB_RTN);
            //}
        }

        // string	
        public void DbPsetString(string name, string val)
        {
            //if (_db_type == "ORACLE")
            //{
            //    _cm_ora.Parameters.Add(name, OracleType.VarChar, 1024).Value = val;
            //}
            //else
            //{
            _cm.Parameters.Add(name, SqlDbType.NVarChar, 1024).Value = val;
            //}
        }
        public void DbPsetString(string name, string val, int direction)
        {
            //if (_db_type == "ORACLE")
            //{
            //    _cm_ora.Parameters.Add(name, OracleType.VarChar, 1024).Value = val;
            //}
            //else
            //{
            _cm.Parameters.Add(name, SqlDbType.NVarChar, 1024).Value = val;
            //}
            _DirectionSet(name, direction);
        }
        // int
        public void DbPsetInt(string name, int val)
        {
            //if (_db_type == "ORACLE")
            //{
            //    _cm_ora.Parameters.Add(name, OracleType.Int32, 1).Value = val;
            //}
            //else
            //{
            _cm.Parameters.Add(name, SqlDbType.Int, 1).Value = val;
            //}
        }
        public void DbPsetInt(string name, int val, int direction)
        {
            //if (_db_type == "ORACLE")
            //{
            //    _cm_ora.Parameters.Add(name, OracleType.Int32, 1).Value = val;
            //}
            //else
            //{
            _cm.Parameters.Add(name, SqlDbType.Int, 1).Value = val;
            //}
            _DirectionSet(name, direction);
        }

        // double
        public void DbPsetDouble(string name, double val)
        {
            //if (_db_type == "ORACLE")
            //{
            //    _cm_ora.Parameters.Add(name, OracleType.Double, 1).Value = val;
            //}
            //else
            //{
            _cm.Parameters.Add(name, SqlDbType.Decimal, 1).Value = val;
            //}
        }
        public void DbPsetDouble(string name, double val, int direction)
        {
            //if (_db_type == "ORACLE")
            //{
            //    _cm_ora.Parameters.Add(name, OracleType.Double, 1).Value = val;
            //}
            //else
            //{
            _cm.Parameters.Add(name, SqlDbType.Float, 1).Value = val;
            //}
            _DirectionSet(name, direction);
        }

        // date
        public void DbPsetDate(string name, DateTime val)
        {
            //if (_db_type == "ORACLE")
            //{
            //    _cm_ora.Parameters.Add(name, OracleType.DateTime, 1).Value = val;
            //}
            //else
            //{
            _cm.Parameters.Add(name, SqlDbType.DateTime, 1).Value = val;
            //}
        }
        public void DbPsetDate(string name, DateTime val, int direction)
        {
            //if (_db_type == "ORACLE")
            //{
            //    _cm_ora.Parameters.Add(name, OracleType.DateTime, 1).Value = val;
            //}
            //else
            //{
            _cm.Parameters.Add(name, SqlDbType.DateTime, 1).Value = val;
            //}
            _DirectionSet(name, direction);
        }

        // BigInt 2014.09.05
        public void DbPsetBigInt(string name, double val)
        {
            _cm.Parameters.Add(name, SqlDbType.BigInt, 1).Value = val;
        }
        public void DbPsetBigInt(string name, double val, int direction)
        {
            _cm.Parameters.Add(name, SqlDbType.BigInt, 1).Value = val;
            _DirectionSet(name, direction);
        }
        
        // xml	2012.04.25
        public void DbPsetXml(string name, string val, int intSize)
        {
            _cm.Parameters.Add(name, SqlDbType.Xml, intSize).Value = val;
        }
        public void DbPsetXml(string name, string val, int intSize, int direction)
        {
            _cm.Parameters.Add(name, SqlDbType.Xml, intSize).Value = val;
            _DirectionSet(name, direction);
        }

        // ���Ұ��̑����ݒ�
        private void _DirectionSet(string name, int direction)
        {
            ////if (_db_type == "ORACLE")
            ////{
            ////    switch (direction)
            ////    {
            ////        case ComConst.DB_RTN:
            ////            _cm_ora.Parameters[name].Direction = ParameterDirection.ReturnValue;
            ////            break;
            ////        case ComConst.DB_IN:
            ////            _cm_ora.Parameters[name].Direction = ParameterDirection.Input;
            ////            break;
            ////        case ComConst.DB_INOUT:
            ////            _cm_ora.Parameters[name].Direction = ParameterDirection.InputOutput;
            ////            break;
            ////        case ComConst.DB_OUT:
            ////            _cm_ora.Parameters[name].Direction = ParameterDirection.Output;
            ////            break;
            ////    }
            ////}
            ////else
            ////{
            switch (direction)
            {
                case ComConst.DB_RTN:
                    _cm.Parameters[name].Direction = ParameterDirection.ReturnValue;
                    break;
                case ComConst.DB_IN:
                    _cm.Parameters[name].Direction = ParameterDirection.Input;
                    break;
                case ComConst.DB_INOUT:
                    _cm.Parameters[name].Direction = ParameterDirection.InputOutput;
                    break;
                case ComConst.DB_OUT:
                    _cm.Parameters[name].Direction = ParameterDirection.Output;
                    break;
            }
            //}
        }

        //--------------------------------------------------------------
        // �p�����[�^�̊l��
        //--------------------------------------------------------------
        // string	
        public string DbPgetString(string name)
        {
            string val = "";
            //if (_db_type == "ORACLE")
            //{
            //    val = _cm_ora.Parameters[name].Value.ToString();
            //}
            //else
            //{
            val = _cm.Parameters[name].Value.ToString();
            //}
            return val;
        }

        // int
        public int DbPgetInt(string name)
        {
            int rtn = 0;
            try
            {
                //if (_db_type == "ORACLE")
                //{
                //    rtn = int.Parse(_cm_ora.Parameters[name].Value.ToString());
                //}
                //else
                //{
                rtn = int.Parse(_cm.Parameters[name].Value.ToString());
                //}
            }
            catch { }
            return rtn;
        }

        // double
        public double DbPgetDouble(string name)
        {
            double rtn = 0;
            try
            {
                //if (_db_type == "ORACLE")
                //{
                //    rtn = double.Parse(_cm_ora.Parameters[name].Value.ToString());
                //}
                //else
                //{
                rtn = double.Parse(_cm.Parameters[name].Value.ToString());
                //}
            }
            catch { }
            return rtn;
        }

        #region ��ADD 2010/01/06 USE BY �ڔz�聫
        //==================  ��ADD 2010/01/06 USE BY �ڔz�聫  ====================
        /// <summary>
        /// �ް�����p��������ސ����׽
        /// </summary>
        protected SqlCommandBuilder ManipulateCB=new SqlCommandBuilder();

        #region DbManipulateDT : �ް�����p�ް�ð��ق��쐬���ĕԂ�
        //-------------------------------------------------------------------
        // �ް�����p�ް�ð��ق��쐬���ĕԂ�
        //-------------------------------------------------------------------
        /// <summary>
        /// �ް�����p�ް�ð��ق��쐬���ĕԂ�
        /// </summary>
        /// <param name="strSql">���s�Ώۂ�SQL��</param>
        /// <param name="tblName">ð��ٖ�</param>
        /// <returns>DataSet(�װ���͗�O�𓊂���)</returns>
        public DataSet DbManipulateDS(string strSql, string tblName)
        {
            DataSet ds = new DataSet();
            _da = new SqlDataAdapter();
            _cm.CommandType = CommandType.Text;
            _cm.Connection = _cn;
            _da.SelectCommand = _cm;

            //--- Connection Open
            if (_cn.State != ConnectionState.Open)
                _cn.Open();

            //'--- Fill
            _cm.CommandText = strSql;
            //�ް�����p�ް���������ɺ���ނ�ݒ�
            //ManipulateDA.SelectCommand = oc;

            //���������ް���ް�����������ް�����p�ް���������ɐݒ�
            ManipulateCB.DataAdapter = _da;

            _da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            try
            {
                _da.Fill(ds, tblName);                
                return ds;
            }
            catch (SqlException e)
            {
                //_oracode = (long)e.Number;
                _expmsg = e.Message;
                _strErr = e.ToString();
                return null;
                //throw new ComException(e.Message, e.Number.ToString(), strSql, MethodInfo.GetCurrentMethod().Name);

            }
            catch
            {
                return null;
                //throw new ComException(ex.Message, null, null, MethodInfo.GetCurrentMethod().Name);
            }

        }
        #endregion      
        #endregion 20100106 ADD END
    }
}