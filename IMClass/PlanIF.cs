using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Data;
using System.Collections;

//using System.Web;
//using System.Web.UI.HtmlControls;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace IMClass
{
    /// <summary>
    /// [IF取込生産計画]テーブルの構造体
    /// </summary>
    [Serializable]
    public struct IF_PROD_PLAN
    {
        //public int IF_DATE;
        //public int IF_HMS;
        public string IF_TYPE;
        public string IF_TYPE_NAME;
        public int IF_DATA_SEQ;
        public string IF_PLAN_NO;
        public string ITEM_NO;
        //public string ITEM_DESC;
        //public string WS_CD;
        //public int PLAN_YM;
        //public double ORDER_QTY;
        //public int IF_DATA_FLAG;
    }

    public class PlanIF
    {
        /// <summary>
        /// 初期生産計画データのテキストファイル
        /// ラインデータ長
        /// </summary>
        //public const int IMP_DATA_LEN = 92;
        /// <summary>
        /// Japanese code
        /// </summary>
        //public Encoding JP_ENCODING = Encoding.GetEncoding("Shift-JIS");

        #region : コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public PlanIF()
        {
            try
            {
                _db_type = WebConfigurationManager.AppSettings["db_type"];
            }
            catch { }
        }
        public PlanIF(string p_user_id, int p_lang)
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

        protected string _file_path = "";
        //protected int _file_line_cnt = 0;
        //protected string _physical_path = "";
        //protected string _save_path = "";
        //protected string _log_path = "";
        //protected string _save_file = "";
        //protected string _log_file = "";
        //protected int _len_err_cnt = 0;

        //protected IF_PROD_PLAN _if_prod_plan;
        //protected int _if_date = 0;
        //protected int _if_hms = 0;
        protected string _if_type = "";
        protected string _if_type_name = "";

        //protected string _PlanIF_cd = "";
        //protected string _PlanIF_desc1 = "";
        //protected string _PlanIF_desc2 = "";
        //protected string _PlanIF_desc3 = "";
        //protected string _PlanIF_desc4 = "";
        //protected int _PlanIF_type = 0;
        //protected int _type = 0;
        //protected string _alloc_cd = "";
        //protected string _overhead_group = "";

        //protected DateTime _entry_date;
        //protected DateTime _chg_date;
        //protected string _chg_pgm = "";
        protected string _chg_user_id = "";
        //protected int _update_cntr = 0;
        protected string _dbmsg = "";
        protected string _errmsg = "";
        protected string _strErr = "";
        protected int _errcode = 0;
        protected int _sqlcode = 0;
        protected string _proc_name = "";

        protected ArrayList lstFileInfo = new ArrayList();

        #endregion

        #region : プロパティ

        public string file_path { get { return _file_path; } set { _file_path = value; } }
        //public int file_line_cnt { get { return _file_line_cnt; } set { _file_line_cnt = value; } }
        //public string physical_path { get { return _physical_path; } set { _physical_path = value; } }
        //public string save_path { get { return _save_path; } set { _save_path = value; } }
        //public string log_path { get { return _log_path; } set { _log_path = value; } }
        //public string save_file { get { return _save_file; } set { _save_file = value; } }
        //public string log_file { get { return _log_file; } set { _log_file = value; } }
        //public int len_err_cnt { get { return _len_err_cnt; } set { _len_err_cnt = value; } }

        //public IF_PROD_PLAN if_prod_plan { get { return _if_prod_plan; } set { _if_prod_plan = value; } }
        //public int if_date { get { return _if_date; } set { _if_date = value; } }
        //public int if_hms { get { return _if_hms; } set { _if_hms = value; } }
        public string if_type { get { return _if_type; } set { _if_type = value; } }
        public string if_type_name { get { return _if_type_name; } set { _if_type_name = value; } }

        //public string PlanIF_cd { get { return _PlanIF_cd; } set { _PlanIF_cd = value; } }
        //public string PlanIF_desc1 { get { return _PlanIF_desc1; } set { _PlanIF_desc1 = value; } }
        //public string PlanIF_desc2 { get { return _PlanIF_desc2; } set { _PlanIF_desc2 = value; } }
        //public string PlanIF_desc3 { get { return _PlanIF_desc3; } set { _PlanIF_desc3 = value; } }
        //public string PlanIF_desc4 { get { return _PlanIF_desc4; } set { _PlanIF_desc4 = value; } }
        //public int PlanIF_type { get { return _PlanIF_type; } set { _PlanIF_type = value; } }
        //public int type { get { return _type; } set { _type = value; } }
        //public string alloc_cd { get { return _alloc_cd; } set { _alloc_cd = value; } }
        //public string overhead_group { get { return _overhead_group; } set { _overhead_group = value; } }

        //public string chg_pgm { get { return _chg_pgm; } set { _chg_pgm = value; } }
        public string chg_user_id { get { return _chg_user_id; } set { _chg_user_id = value; } }
        //public int update_cntr { get { return _update_cntr; } set { _update_cntr = value; } }
        public string dbmsg { get { return _dbmsg; } set { _dbmsg = value; } }
        public string errmsg { get { return _errmsg; } set { _errmsg = value; } }
        public string strErr { get { return _strErr; } set { _strErr = value; } }
        public int errcode { get { return _errcode; } set { _errcode = value; } }
        public int sqlcode { get { return _sqlcode; } set { _sqlcode = value; } }
        public int lang { get { return _lang; } set { _lang = value; } }
        #endregion

        #region ：通用函数相关

        #region ：通用函数 - 获取指定文件的文件编码函数
        /// <summary>
        /// 通用函数 - 获取指定文件的文件编码
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private static Encoding GetFileEncoding(string filePath)
        {
            Encoding encoding = null;
            FileStream fStream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            if (fStream.CanSeek)
            {
                byte[] data = new byte[4];
                fStream.Read(data, 0, 4);

                switch (data[0])
                {
                    case 0xef: // UTF8 
                        if (data.Length < 3)
                            break;
                        if (data[1] == 0xbb && data[2] == 0xbf)
                            encoding = Encoding.UTF8;
                        break;
                    case 0xfe: // UTF 16 BE 
                        if (data[1] == 0xff)
                            encoding = Encoding.BigEndianUnicode;
                        break;
                    case 0xff: // UTF 16 LE 
                        if (data[1] == 0xfe)
                            encoding = Encoding.Unicode;
                        break;
                    default:
                        //encoding = Encoding.Default;
                        encoding = Encoding.GetEncoding("Shift-JIS");
                        break;
                }
            }
            fStream.Dispose();
            fStream.Close();
            fStream = null;
            return encoding;
        }
        #endregion

        #region ：通用函数 - 字符全角转半角函数
        /// <summary>
        /// 通用函数 -
        /// 全角转半角函数(DBC case)
        /// 全角空格为12288，半角空格为32
        /// 其他字符半角(33-126)与全角(65281-65374)的对应关系是：均相差65248
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static String ToDBC(String input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 12288)
                {
                    c[i] = (char)32;
                    continue;
                }
                if (c[i] > 65280 && c[i] < 65375)
                    c[i] = (char)(c[i] - 65248);
            }
            //return new String(c);
            String strResult = new String(c);
            //--Japanes convert            
            strResult = KanaExchg(strResult, 0);
            return strResult;
        }
        #endregion

        #region ：通用函数 - 日文全半角互换函数
        /// <summary>
        /// 通用函数 - 
        /// 日文全半角互换
        /// Japanes convert
        /// </summary>
        /// <param name="str"></param>
        /// <param name="type">0.Full to Half; 1.Half to Full</param>
        /// <returns></returns>
        private static String KanaExchg(string str, int type)
        {
            //Japanes convert
            string FullKana = "ヴ,ガ,ギ,グ,ゲ,ゴ,ザ,ジ,ズ,ゼ,ゾ,ダ,ヂ,ヅ,デ,ド,バ,ビ,ブ,ベ,ボ,パ,ピ,プ,ペ,ポ,゛,。,「,」,、,・,ヲ,ァ,ィ,ゥ,ェ,ォ,ャ,ュ,ョ,ッ,ー,ア,イ,ウ,エ,オ,カ,キ,ク,ケ,コ,サ,シ,ス,セ,ソ,タ,チ,ツ,テ,ト,ナ,ニ,ヌ,ネ,ノ,ハ,ヒ,フ,ヘ,ホ,マ,ミ,ム,メ,モ,ヤ,ユ,ヨ,ラ,リ,ル,レ,ロ,ワ,ン,゜";
            string HalfKana = "ｳﾞ,ｶﾞ,ｷﾞ,ｸﾞ,ｹﾞ,ｺﾞ,ｻﾞ,ｼﾞ,ｽﾞ,ｾﾞ,ｿﾞ,ﾀﾞ,ﾁﾞ,ﾂﾞ,ﾃﾞ,ﾄﾞ,ﾊﾞ,ﾋﾞ,ﾌﾞ,ﾍﾞ,ﾎﾞ,ﾊﾟ,ﾋﾟ,ﾌﾟ,ﾍﾟ,ﾎﾟ,ﾞ,｡,｢,｣,､,･,ｦ,ｧ,ｨ,ｩ,ｪ,ｫ,ｬ,ｭ,ｮ,ｯ,ｰ,ｱ,ｲ,ｳ,ｴ,ｵ,ｶ,ｷ,ｸ,ｹ,ｺ,ｻ,ｼ,ｽ,ｾ,ｿ,ﾀ,ﾁ,ﾂ,ﾃ,ﾄ,ﾅ,ﾆ,ﾇ,ﾈ,ﾉ,ﾊ,ﾋ,ﾌ,ﾍ,ﾎ,ﾏ,ﾐ,ﾑ,ﾒ,ﾓ,ﾔ,ﾕ,ﾖ,ﾗ,ﾘ,ﾙ,ﾚ,ﾛ,ﾜ,ﾝ,ﾟ";
            string[] arrFullKaka = FullKana.Split(',');
            string[] arrHalfKana = HalfKana.Split(',');
            for (int i = 0; i < arrFullKaka.Length; i++)
            {
                if (type == 0)
                    str = str.Replace(arrFullKaka[i], arrHalfKana[i]);
                else
                    str = str.Replace(arrHalfKana[i], arrFullKaka[i]);
            }
            return str;
        }
        #endregion

        #endregion

        #region ：[IF取込生産計画]各栏位值设定 SetRecordValues()
        /// <summary>
        /// 将字符串转换成byte[]数组,再依仕样指定长度截取值
        /// </summary>
        /// <param name="IfType"></param>
        /// <param name="seq"></param>
        /// <param name="aRecord"></param>
        /// <param name="FileEncoding"></param>
        public IF_PROD_PLAN SetRecordValues(string IfType, int seq, string[] arrayRecord, Encoding FileEncoding)
        {
            ComLibrary com = new ComLibrary();

            // 数据截取及默认数据的取得
            IF_PROD_PLAN ifpp = new IF_PROD_PLAN();
            //ifpp.IF_DATE = _if_date;                                                        //データ連携日
            //ifpp.IF_HMS = _if_hms;                                                          // 連携データ区分
            ifpp.IF_TYPE = _if_type;                                                        //連携データ区分
            ifpp.IF_DATA_SEQ = seq;                                                         //データ順番
            ifpp.IF_PLAN_NO = string.Empty;                                                 //取込計画№
            ifpp.ITEM_NO = ToDBC(arrayRecord.Length > 0 ? arrayRecord[0] : "").Trim();      //品目コード

            //ifpp.ITEM_DESC = ToDBC(arrayRecord.Length > 1 ? arrayRecord[1] : "").Trim();    //品目名称

            //ifpp.WS_CD = "";                                                                //作業区コード
            //ifpp.PLAN_YM = com.StringToInt(arrayRecord.Length > 2 ? arrayRecord[2].Replace("/", "") : "0");  //計画年月
            //ifpp.ORDER_QTY = com.StringToDouble(arrayRecord.Length > 3 ? arrayRecord[3] : "0");             //計画数量
            //ifpp.IF_DATA_FLAG = 0;                                                          //取込結果区分

            return ifpp;
        }

        #endregion

        #region ：指定目录下所有[CSV]类型文件导入数据表-XML方式（レベル単位で一括追加）//2014.07.11 ADD
        /// <summary>
        /// 指定目录下所有[CSV]类型文件导入DataTable
        /// XML方式一次性导入
        /// </summary>
        /// <returns></returns>
        public int ImpFilesToDataTableBulk()
        {
            int rtn = 0;
            ComLibrary com = new ComLibrary();

            try
            {
                string strFileNm = "";
                string[] strWk = _file_path.Split('\\');
                strFileNm = strWk[strWk.Length - 1];
                string strFileNmA = "";
                string[] strWkA = strFileNm.Split('.');
                strFileNmA = strWkA[0];

                bool isEmpty = true;
                int LineCnt = 0;

                string IfType = _if_type;//連携データ区分

                StringBuilder strXML = new StringBuilder();
                strXML.Append("<IFRows>");

                Boolean err_flag = false;
                //if (_save_path != "")
                //{
                //    if (_save_path.EndsWith("\\"))
                //        _save_file = _save_path + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_" + strFileNm;
                //    else
                //        _save_file = _save_path + "\\" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_" + strFileNm;

                //}
                // LOG FILE 名 2014.09.22
                //if (_log_path != "")
                //{
                //    if (_log_path.EndsWith("\\"))
                //        _log_file = _log_path + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_" + strFileNm;
                //    else
                //        _log_file = _log_path + "\\" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_" + strFileNm;
                //}

                // FILE COPY 2014.09.22 
                //if (_save_path != "")
                //{
                //    File.Copy(_file_path, _save_file, true);
                //}

                Encoding FileEncoding = GetFileEncoding(_file_path);

                // 最初にメモリに読むこむ
                int wLineCnt = 0;

                StreamReader sr = new StreamReader(_file_path, FileEncoding);
                while (sr.Peek() >= 0)
                {
                    wLineCnt++;
                    string strRecord = sr.ReadLine();
                    FileInfoClass fi = new FileInfoClass();
                    fi.LineCnt = wLineCnt;
                    fi.Data = strRecord;
                    lstFileInfo.Add(fi);
                }
                sr.Dispose();
                sr.Close();

                TextFieldParser parser = new TextFieldParser(_file_path, FileEncoding);
                using (parser)
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(","); // 区切り文字はコンマ

                    while (!parser.EndOfData)
                    {
                        err_flag = false;
                        LineCnt++;
                        isEmpty = false;
                        string[] strRecord = parser.ReadFields(); // 1行読み込み 2014.09.22

                        string aRecord = "";
                        for (int p = 0; p < strRecord.Length; p++)
                        {
                            if (p > 0)
                                aRecord += "|";
                            aRecord += strRecord[p];
                        }
                        if (LineCnt <= lstFileInfo.Count)
                            ((FileInfoClass)lstFileInfo[LineCnt - 1]).CnvData = aRecord;

                        //各項目属性ﾁｪｯｸ
                        //年月, 数量
                        //if (!com.IsNumeric(strRecord[2].Replace("/", "")) || !com.IsNumeric(strRecord[3]))
                        //{
                        //    err_flag = true;

                        //    // 2014.10.10
                        //    if (LineCnt <= lstFileInfo.Count)
                        //    {
                        //        ((FileInfoClass)lstFileInfo[LineCnt - 1]).ErrFlag = 1;
                        //        ((FileInfoClass)lstFileInfo[LineCnt - 1]).ErrMsg = "数値エラー。";
                        //    }
                        //}

                        //数据各项值取得
                        IF_PROD_PLAN ifpl = SetRecordValues(IfType, LineCnt, strRecord, FileEncoding);


                        //if (ifpl.ITEM_NO.ToString().Length > 30
                        //|| ifpl.ITEM_DESC.ToString().Length > 50
                        //|| ifpl.PLAN_YM.ToString().Length > 6
                        //|| com.StringToDouble(ifpl.ORDER_QTY.ToString()) > 1000000000)
                        //{
                        //    err_flag = true;

                        //    if (LineCnt <= lstFileInfo.Count)
                        //    {
                        //        ((FileInfoClass)lstFileInfo[LineCnt - 1]).ErrFlag = 1;
                        //        ((FileInfoClass)lstFileInfo[LineCnt - 1]).ErrMsg += "桁数エラー。";
                        //    }
                        //}


                        if (err_flag)   // 2014.10.10
                        {
                            //_len_err_cnt++;

                            ////IF 取込データログに登録
                            //Poif poif = new Poif(_chg_user_id, _lang);
                            //Message msg = new Message(_chg_user_id, _lang);

                            //poif.if_date = ifpl.IF_DATE;
                            //poif.if_hms = ifpl.IF_HMS;
                            //poif.if_type = ifpl.IF_TYPE;
                            //poif.if_type_name = _if_type_name;
                            //poif.if_data_seq = ifpl.IF_DATA_SEQ;
                            //poif.if_data = aRecord;
                            //poif.if_data_err = msg.GetMessage("COLUMN_LENGTH_FORMAT_ERR");
                            //poif.if_data_flag = 2;
                            //poif.chg_pgm = _chg_pgm;
                            //poif.chg_user_id = _chg_user_id;
                            //poif.lang = _lang;
                            //poif.errcode = _errcode;
                            //poif.errmsg = _errmsg;
                            //poif.sqlcode = _sqlcode;
                            //poif.dbmsg = _dbmsg;

                            //rtn = poif.Ins_IF_IN_LOG();
                            //if (rtn == ComConst.FAILED)
                            //{
                            //    goto RESULT;
                            //}

                        }

                        if (!err_flag)  // 2014.09.22
                        {
                            //XML格式作成
                            strXML.Append("<IFRow ");
                            //strXML.Append(" IF_DATE=\"" + ifpl.IF_DATE.ToString() + "\"");
                            //strXML.Append(" IF_HMS=\"" + ifpl.IF_HMS.ToString() + "\"");
                            strXML.Append(" IF_TYPE=\"" + ifpl.IF_TYPE + "\"");
                            strXML.Append(" IF_DATA_SEQ=\"" + ifpl.IF_DATA_SEQ.ToString() + "\"");
                            strXML.Append(" IF_PLAN_NO=\"" + ifpl.IF_PLAN_NO + "\"");
                            strXML.Append(" ITEM_NO=\"" + ifpl.ITEM_NO + "\"");
                            //strXML.Append(" ITEM_DESC=\"" + com.XMLString(ifpl.ITEM_DESC) + "\"");
                            //strXML.Append(" WS_CD=\"" + ifpl.WS_CD + "\"");
                            //strXML.Append(" PLAN_YM=\"" + ifpl.PLAN_YM.ToString() + "\"");
                            //strXML.Append(" ORDER_QTY=\"" + ifpl.ORDER_QTY.ToString() + "\"");
                            //strXML.Append(" IF_DATA_FLAG=\"" + ifpl.IF_DATA_FLAG.ToString() + "\"");
                            //strXML.Append(" CHG_PGM=\"" + _chg_pgm + "\"");
                            strXML.Append(" CHG_USER_ID=\"" + _chg_user_id + "\"");
                            strXML.Append(" />");
                        }
                    }

                }
                strXML.Append("</IFRows>");

                //_file_line_cnt = LineCnt;

                if (isEmpty)
                {
                    Message msg = new Message(_chg_user_id, _lang);
                    _strErr = msg.GetMessage("FILE_NOT_EXIST_ERR");
                    rtn = ComConst.CHECK_ERROR;
                    goto RESULT;
                }
                else
                {
                    // [IF初期取込生産計画]の一括登録
                    #region : [IF初期取込生産計画]の一括登録
                    ComDB db = new ComDB(_db_type);
                    db.DbParametersClear();

                    db.DbPsetInt("rtn", rtn, ComConst.DB_RTN);
                    db.DbPsetXml("@I_XML", strXML.ToString(), strXML.ToString().Length, ComConst.DB_IN);
                    db.DbPsetInt("@I_LANG", _lang, ComConst.DB_IN);
                    db.DbPsetInt("@O_ERRCODE", _errcode, ComConst.DB_OUT);
                    db.DbPsetString("@O_MSG", _errmsg, ComConst.DB_OUT);
                    db.DbPsetInt("@O_SQLCODE", _sqlcode, ComConst.DB_OUT);
                    db.DbPsetString("@O_SQLMSG", _dbmsg, ComConst.DB_OUT);
                    db.DbPsetString("@O_PROC_NAME", _proc_name, ComConst.DB_OUT);

                    db.DbBeginTrans();
                    rtn = db.DbStored("SP_IF_PROD_PLAN_BULK_IMP");//一括登録
                    if (rtn == ComConst.SUCCEED)
                    {
                        db.DbCommit();
                    }
                    else
                    {
                        db.DbRollback();
                        rtn = db.DbPgetInt("rtn");
                        if (rtn > 0)
                        {
                            _errcode = db.DbPgetInt("@O_ERRCODE");
                            _errmsg = db.DbPgetString("@O_MSG");
                            _sqlcode = db.DbPgetInt("@O_SQLCODE");
                            _dbmsg = db.DbPgetString("@O_SQLMSG");
                            _proc_name = db.DbPgetString("@O_PROC_NAME");
                            _strErr = _errcode + ":" + _errmsg + "[" + _sqlcode + ":" + _dbmsg + "(" + _proc_name + ")]";
                        }
                        else
                        {
                            _strErr = db.strErr;
                        }
                        rtn = ComConst.FAILED;
                    }
                    #endregion
                }
                //File.Delete(_file_path);

            }
            catch (Exception ex)
            {
                _strErr = ex.ToString();
                rtn = ComConst.FAILED;
            }

            RESULT:
            return rtn;

        }
        #endregion


        #region ファイル情報
        /// <summary>
        /// ファイル情報 2014.10.10
        /// </summary>
        public class FileInfoClass
        {
            public int LineCnt = 0;         //行番号
            public int ErrFlag = 0;         //エラーフラグ
            public string Data;          //取込データ(生)
            public string CnvData;          //取込データ(縦棒区切り)
            public string ErrMsg = "";        //エラーメッセージ
        }
        #endregion

    }
}
