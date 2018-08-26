using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Configuration;

namespace IMClass
{
    public class AEBlock
    {
        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AEBlock()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public AEBlock(string p_user_id, int p_lang)
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

        protected string _db_type = "";
        protected int _lang = 0;

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

        protected string _umsr_desc = "";
        #endregion

        #region : プロパティ

        public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string errmsg { get { return _errmsg; } set { _errmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }
        public int errcode { get { return _errcode; } set { _errcode = value; } }
        public int sqlcode { get { return _sqlcode; } set { _sqlcode = value; } }
        public int lang { get { return _lang; } set { _lang = value; } }

        public string umsr_desc { get { return _umsr_desc; } set { _umsr_desc = value; } }

        #endregion

        /// <summary>
        /// Get data from B1_BLOCK_DATA_INTERFACE
        /// </summary>
        public DataSet GetAEBlockList()
        {
            ComDB db = new ComDB(_db_type);
            StringBuilder strSQL = new StringBuilder();
            DataSet ds = new DataSet();
            ComLibrary comlibrary = new ComLibrary();

            strSQL = new StringBuilder();
            //--- sql
            strSQL.Append("SELECT TOP 2000 ");
            strSQL.Append("[MC_WorkingDate],    [CylinderNo],       [LineCode],         [PartNo],               [Status], ");
            strSQL.Append("[CA_Model],          [CA_DieNo],         [CA_SozaiYear],     [CA_SozaiMonth],        [CA_SozaiDay], ");
            strSQL.Append("[CA_Mc],             [CA_SozaiNo],       [ToGunshin],        [MarkP],                [MarkR], ");
            strSQL.Append("[MarkGR],            [BCAP_Lot],         [C1],               [C2],                   [C3], ");
            strSQL.Append("[C4],                [C5],               [B1],               [B2],                   [B3], ");
            strSQL.Append("[B4],                [NGProcessCode],    [NGOutDate],        [NGInDate],             [NGCode], ");
            strSQL.Append("[NGDetail],          [RepairOK],         [OFFDate],          [LotNo],                [StockInLocation], ");
            strSQL.Append("[LastWHLocation],    [StockOutDate],     [Reject],           [Location],             [N1_100_OUT], ");
            strSQL.Append("[N1_100_IN],         [N5_OUT],           [N5_IN],            [SPECIAL_OUT],          [SPECIAL_IN], ");
            strSQL.Append("[OTHER_OUT],         [OTHER_IN],         [MaxUpdateDate],    [Flag] ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM B1_BLOCK_DATA_INTERFACE B ");
                strSQL.Append(" WHERE 1=1 ");
                db.DbParametersClear();
            }
            else
            {
                strSQL.Append(" FROM B1_BLOCK_DATA_INTERFACE B ");
                strSQL.Append(" WHERE 1=1 ");
                db.DbParametersClear();
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
    }
}
