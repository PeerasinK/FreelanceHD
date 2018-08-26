﻿using System;
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
        protected DateTime? _condition_DateFrom;
        protected DateTime? _condition_DateTo;

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

        public DateTime? condition_DateFrom { get { return _condition_DateFrom; } set { _condition_DateFrom = value; } }
        public DateTime? condition_DateTo { get { return _condition_DateTo; } set { _condition_DateTo = value; } }

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
            strSQL.Append("B.[MC_WorkingDate],    B.[CylinderNo],       B.[LineCode],         B.[PartNo],               B.[Status], ");
            strSQL.Append("B.[CA_Model],          B.[CA_DieNo],         B.[CA_SozaiYear],     B.[CA_SozaiMonth],        B.[CA_SozaiDay], ");
            strSQL.Append("B.[CA_Mc],             B.[CA_SozaiNo],       B.[ToGunshin],        B.[MarkP],                B.[MarkR], ");
            strSQL.Append("B.[MarkGR],            B.[BCAP_Lot],         B.[C1],               B.[C2],                   B.[C3], ");
            strSQL.Append("B.[C4],                B.[C5],               B.[B1],               B.[B2],                   B.[B3], ");
            strSQL.Append("B.[B4],                B.[NGProcessCode],    B.[NGOutDate],        B.[NGInDate],             B.[NGCode], ");
            strSQL.Append("B.[NGDetail],          B.[RepairOK],         B.[OFFDate],          B.[LotNo],                B.[StockInLocation], ");
            strSQL.Append("B.[LastWHLocation],    B.[StockOutDate],     B.[Reject],           B.[Location],             B.[N1_100_OUT], ");
            strSQL.Append("B.[N1_100_IN],         B.[N5_OUT],           B.[N5_IN],            B.[SPECIAL_OUT],          B.[SPECIAL_IN], ");
            strSQL.Append("B.[OTHER_OUT],         B.[OTHER_IN],         B.[MaxUpdateDate],    B.[Flag] ");

            if (_db_type == "ORACLE")
            {
                strSQL.Append(" FROM B1_BLOCK_DATA_INTERFACE B ");
                strSQL.Append(" WHERE 1=1 ");
                if (_condition_DateFrom.HasValue) strSQL.Append(" AND CAST(B.NGInDate AS DATE) >= CAST('" + _condition_DateFrom.Value + "' AS DATE) ");
                if (_condition_DateTo.HasValue) strSQL.Append(" AND CAST(B.NGInDate AS DATE) <= CAST('" + _condition_DateTo.Value + "' AS DATE) ");
                db.DbParametersClear();
            }
            else
            {
                strSQL.Append(" FROM B1_BLOCK_DATA_INTERFACE B ");
                strSQL.Append(" WHERE 1=1 ");
                if(_condition_DateFrom.HasValue) strSQL.Append(" AND CAST(B.NGInDate AS DATE) >= CAST('" + _condition_DateFrom.Value + "' AS DATE) ");
                if (_condition_DateTo.HasValue) strSQL.Append(" AND CAST(B.NGInDate AS DATE) <= CAST('" + _condition_DateTo.Value + "' AS DATE) ");
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
