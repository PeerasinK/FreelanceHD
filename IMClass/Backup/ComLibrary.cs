using System;
using System.Web;
using System.Web.UI;
using System.Web.Configuration;
using System.Globalization;
using System.Text;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

/// <summary>
/// �e��֐��N���X
/// </summary>
namespace IMClass
{
    public class ComLibrary
    {
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public ComLibrary()
        {
            //throw new System.NotImplementedException();
        }

        #region:���t�����̎擾
        public string GetDateFormat(string p_user_id, int p_lang)
        {
            SystemParameter sys = new SystemParameter(p_user_id, p_lang);
            sys.key01 = "DATE_FORMAT";
            int rtn = sys.GetDetail();
            if (rtn == ComConst.FAILED) sys.data_char = "yyyy/MM/dd";
            sys.data_char = CheckDateFormat(sys.data_char);
            return sys.data_char;
        }
        #endregion

        #region : ���l�֐�
        //public void RoudUp()
        //{
        //    //throw new System.NotImplementedException();
        //}

        //public void Round()
        //{
        //    //throw new System.NotImplementedException();
        //}

        /// ------------------------------------------------------------------------
        /// <summary>
        ///     �w�肵�����x�̐��l�ɐ؂�̂Ă��܂��B</summary>
        /// <param name="dValue">
        ///     �ۂߑΏۂ̔{���x���������_���B</param>
        /// <param name="iDigits">
        ///     �߂�l�̗L�������̐��x�B</param>
        /// <returns>
        ///     iDigits �ɓ��������x�̐��l�ɐ؂�̂Ă�ꂽ���l�B</returns>
        /// ------------------------------------------------------------------------
        public double ToRoundDown(double dValue, int iDigits)
        {
            double dCoef = System.Math.Pow(10, iDigits);

            return dValue > 0 ? System.Math.Floor(dValue * dCoef) / dCoef :
                                System.Math.Ceiling(dValue * dCoef) / dCoef;
        }
        #endregion

        #region Substring : �����̎��o��
        /// -----------------------------------------------------------------------------------
        /// <summary>
        ///     ������̍��[����w�肳�ꂽ���������̕������Ԃ��܂��B</summary>
        /// <param name="stTarget">
        ///     ���o�����ɂȂ镶����B</param>
        /// <param name="iLength">
        ///     ���o���������B</param>
        /// <returns>
        ///     ���[����w�肳�ꂽ���������̕�����B
        ///     �������𒴂����ꍇ�́A������S�̂��Ԃ���܂��B</returns>
        /// -----------------------------------------------------------------------------------
        public string Left(string stTarget, int iLength)
        {
            if (iLength <= stTarget.Length)
            {
                return stTarget.Substring(0, iLength);
            }

            return stTarget;
        }

        /// <summary>
        ///     ������̉E�[����w�肳�ꂽ���������̕������Ԃ��܂��B</summary>
        /// <param name="stTarget">
        ///     ���o�����ɂȂ镶����B</param>
        /// <param name="iLength">
        ///     ���o���������B</param>
        /// <returns>
        ///     �E�[����w�肳�ꂽ���������̕�����B
        ///     �������𒴂����ꍇ�́A������S�̂��Ԃ���܂��B</returns>
        public string Right(string stTarget, int iLength)
        {
            if (iLength <= stTarget.Length)
            {
                return stTarget.Substring(stTarget.Length - iLength);
            }
            return stTarget;
        }

        /// <summary>
        ///     ������̎w�肳�ꂽ�ʒu����A�w�肳�ꂽ���������̕������Ԃ��܂��B</summary>
        /// <param name="stTarget">
        ///     ���o�����ɂȂ镶����B</param>
        /// <param name="iStart">
        ///     ���o�����J�n����ʒu�B</param>
        /// <param name="iLength">
        ///     ���o���������B</param>
        /// <returns>
        ///     �w�肳�ꂽ�ʒu����w�肳�ꂽ���������̕�����B
        ///     �������𒴂����ꍇ�́A�w�肳�ꂽ�ʒu���炷�ׂĂ̕����񂪕Ԃ���܂��B</returns>
        public string Mid(string stTarget, int iStart, int iLength)
        {
            if (iStart <= stTarget.Length)
            {
                if (iStart + iLength - 1 <= stTarget.Length)
                {
                    return stTarget.Substring(iStart - 1, iLength);
                }

                return stTarget.Substring(iStart - 1);
            }

            return string.Empty;
        }
        #endregion

        #region �@VariousChange :  �ϊ��֐�
        /// <summary>
        /// BOOL�l�^�̐��l[Int]�ւ̕ϊ�
        /// </summary>
        /// <param name="blValue"></param>
        /// <returns></returns>
        public int BoolToInt(bool blValue)
        {
            if (blValue)
                return 1;
            else
                return 0;
        }
        /// <summary>
        /// BOOL������̐��l[Int]�ւ̕ϊ�
        /// </summary>
        /// <param name="blValue"></param>
        /// <returns></returns>
        public int BoolToInt(string strValue)
        {
            bool blValue = true;

            if (strValue != "true" && strValue != "false")
                return 0;
            else
                blValue = bool.Parse(strValue);

            if (blValue)
                return 1;
            else
                return 0;
        }

        /// <summary>
        /// ���l[Int]��BOOL�l�^�ւ̕ϊ�
        /// </summary>
        /// <param name="intValue"></param>
        /// <returns></returns>
        public bool IntToBool(int intValue)
        {
            if (intValue == 0)
                return false;
            else
                return true;

        }

        /// <summary>
        /// ������̐��l[int]�ւ̕ϊ�
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public int StringToInt(string strValue)
        {
            int rtnValue = 0;

            if (string.IsNullOrEmpty(strValue))
            {
            }
            else
            {
                if (IsNumeric(strValue))
                {
                    //| ���l�̎��̂�Return
                    //rtnValue = int.Parse(strValue)
                    //rtnValue = int.Parse(strValue, System.Globalization.NumberStyles.Any, null);   //Upd 2009/04/27 T.matsuno
                   try
                    {
                        rtnValue = int.Parse(strValue, System.Globalization.NumberStyles.Any, new CultureInfo("en-us"));    //UPD 2014/9/5 null��new CultureInfo("en-us")
                    }
                    catch { }
                }
                else
                {
                    //| ���l�̎��ȊO�̎��͂Ƃ肠����0��Return�@�F�@�ۗ�
                }
            }
            return rtnValue;
        }

        /// <summary>
        /// ������̐��l[int]�ւ̕ϊ�
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public double StringToDouble(string strValue)
        {
            double rtnValue = 0;

            if (string.IsNullOrEmpty(strValue))
            {
            }
            else
            {
                if (IsNumeric(strValue))
                {
                    //| ���l�̎��̂�Return
                    //rtnValue = double.Parse(strValue);
                    //rtnValue = double.Parse(strValue, System.Globalization.NumberStyles.Any, null);    //Upd 2009/04/27 T.matsuno
                    rtnValue = double.Parse(strValue, System.Globalization.NumberStyles.Any, new CultureInfo("en-us")); //UPD 2014/9/5 null��new CultureInfo("en-us")
                }
                else
                {
                    //| ���l�̎��ȊO�̎��͂Ƃ肠����0��Return�@�F�@�ۗ�
                }
            }
            return rtnValue;
        }

        /// <summary>
        /// ������̐��l[Decimal]�ւ̕ϊ�
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public decimal StringToDecimal(string strValue)
        {
            decimal rtnValue = 0;

            if (string.IsNullOrEmpty(strValue))
            {
            }
            else
            {
                if (IsNumeric(strValue))
                {
                    //| ���l�̎��̂�Return
                    //rtnValue = decimal.Parse(strValue, System.Globalization.NumberStyles.Any, null);
                    rtnValue = decimal.Parse(strValue, System.Globalization.NumberStyles.Any, new CultureInfo("en-us"));    //UPD 2014/9/5 null��new CultureInfo("en-us")
                }
                else
                {
                    //| ���l�̎��ȊO�̎��͂Ƃ肠����0��Return�@�F�@�ۗ�
                }
            }
            return rtnValue;
        }
        
        /// <summary>
        /// ������[���t�t�H�[�}�b�g]�𐔒l[int]�ւ̕ϊ�
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public int DateFormatToInt(string strValue, string p_DateFormat)
        {
            int rtnValue = 0;
            if (string.IsNullOrEmpty(strValue))
            {
            }
            else
            {
                try
                {
                    p_DateFormat = CheckDateFormat(p_DateFormat);
                    DateTime txtDate = DateTime.ParseExact(strValue, p_DateFormat, System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    rtnValue = txtDate.Year * 10000 + txtDate.Month * 100 + txtDate.Day;
                }
                catch
                {
                    string strTemp = strValue.Replace("/", "").Replace("-", "");//ADD Replace("-","") by UBIQ-LIU 2009/12/09
                    if (!int.TryParse(strTemp, out rtnValue))
                    {
                        rtnValue = 0;
                    }
                }
            }
            return rtnValue;
        }

        /// <summary>
        /// ���l[int]�𕶎���[���t�t�H�[�}�b�g]�ւ̕ϊ�
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public string IntToDateFormat(int strValue, string p_DateFormat)
        {
            string rtnValue = strValue.ToString();
            try
            {
                double yyyy = ToRoundDown(strValue / 10000, 0);
                double mm = ToRoundDown((strValue % 10000) / 100, 0);
                double dd = ToRoundDown(strValue % 100, 0);
                DateTime dt = new DateTime((int)yyyy, (int)mm, (int)dd);
                rtnValue = DateFormat(dt, p_DateFormat);
            }
            catch
            {
                //�ϊ��G���[�̏ꍇ
                if (strValue == 0 || strValue == 99999999)
                {
                    string strFormat = p_DateFormat.ToUpper().Replace('Y', '0').Replace('M', '0').Replace('D', '0');
                    rtnValue = strValue.ToString(strFormat);
                }
            }

            return rtnValue;
        }

        /// <summary>
        /// ���t�^�𕶎���[���t�t�H�[�}�b�g]�ɕϊ�
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public string DateFormat(DateTime dt, string p_DateFormat)
        {
            try
            {
                p_DateFormat = CheckDateFormat(p_DateFormat);

                return dt.ToString(p_DateFormat, DateTimeFormatInfo.InvariantInfo);//DataFoemat Change 2008.3.6 
            }
            catch
            {
                //�ϊ��G���[�̏ꍇ�͂Ƃ肠����ShortDateString��Ԃ�
                return dt.ToShortDateString();
            }
        }
        public string CheckDateFormat(string p_DateFormat)
        {
            string rtnFormat = "";
            for (int i = 0; i < p_DateFormat.Length; i++)
            {
                string w = p_DateFormat.Substring(i, 1);
                switch (w)
                {
                    case "Y": w = w.ToLower(); break;
                    case "m": w = w.ToUpper(); break;
                    case "D": w = w.ToLower(); break;

                }
                rtnFormat += w;
            }
            return rtnFormat;
        }

        /// <summary>
        /// �N���C�A���g���j�[�NID���擾
        /// 
        /// �N���C�A���g��(JavaScript)�ɂĎg�p���邽�߂�ID
        /// �FContentPlaceHolder���̃R���g���[��ID��
        /// �@���s������JavaScript�ŏ�������ۂɒʏ��ID�ł͂Ȃ��Ȃ�ׁA
        /// �@�N���C�A���g���ł̃��j�[�NID���擾����B
        /// 
        /// 2007/03/13 : ���g�p�H
        /// </summary>
        /// <param name="p_UniqueId"></param>
        /// <returns></returns>
        public string GetClientUniqueID(string p_UniqueId)
        {
            string uniq = null;
            try
            {
                uniq = (p_UniqueId.Replace("$", "_"));
            }
            catch
            {
                uniq = p_UniqueId;
            }
            return uniq;
        }

        #endregion

        #region �@Validation :  ����
        /// <summary>
        ///     �����񂪐��l�ł��邩�ǂ�����Ԃ��܂��B</summary>
        /// <param name="stTarget">
        ///     �����ΏۂƂȂ镶����B<param>
        /// <returns>
        ///     �w�肵�������񂪐��l�ł���� true�B����ȊO�� false�B</returns>
        public bool IsNumeric(string stTarget)
        {
            double dNullable;

            return double.TryParse(
                stTarget,
                System.Globalization.NumberStyles.Any,
                new CultureInfo("en-us"),       //UPD 2014/9/5 null��new CultureInfo("en-us")
                out dNullable
            );
        }
        /// <summary>
        ///     �I�u�W�F�N�g�����l�ł��邩�ǂ�����Ԃ��܂��B</summary>
        /// <param name="oTarget">
        ///     �����ΏۂƂȂ�I�u�W�F�N�g�B<param>
        /// <returns>
        ///     �w�肵���I�u�W�F�N�g�����l�ł���� true�B����ȊO�� false�B</returns>
        public bool IsNumeric(object oTarget)
        {
            //UPD 2014/9/5 -----> �s���I�h���J���}�̍�������
            if (oTarget == null) return false;
            if (oTarget.GetType() == typeof(decimal) || oTarget.GetType() == typeof(double))
                return IsNumeric(oTarget.ToString().Replace(',', '.'));
            else
                return IsNumeric(oTarget.ToString());
            //return IsNumeric(oTarget.ToString());
            //UPD 2014/9/5 <-----
        }
        #endregion

        #region : SetInitialFocus
        /// <summary>
        /// Set the InitialFocus to the given control. Only works when JavaScript is supported.
        /// </summary>
        /// <param name="control">Control to set the InitialFocus on.</param>
        public void SetInitialFocus(Control control)
        {
            if (control.Page == null)
            {
                throw new ArgumentException(
                    "The Control must be added to a Page before you can set the IntialFocus to it.");
            }
            if (control.Page.Request.Browser.JavaScript == true)
            {
                // Create JavaScript
                StringBuilder s = new StringBuilder();
                s.Append("\n<SCRIPT LANGUAGE='JavaScript'>\n");
                s.Append("<!--\n");
                s.Append("function SetInitialFocus()\n");
                s.Append("{\n");




                // Find the Form
                Control p = control.Parent;
                while (!(p is System.Web.UI.HtmlControls.HtmlForm))
                    p = p.Parent;

                string buf = p.ClientID;


                s.Append("  if (!document.");
                s.Append(buf);
                s.Append("['");
                s.Append(control.UniqueID);
                s.Append("'])\n");
                s.Append("	return;\n");

                s.Append("   document.");
                s.Append(buf);

                s.Append("['");
                s.Append(control.UniqueID);
                s.Append("'].focus();\n");

                s.Append("   if (document.");
                s.Append(buf);
                s.Append("['");
                s.Append(control.UniqueID);
                s.Append("'].tagName != 'SELECT') \n");

                s.Append("   document.");
                s.Append(buf);
                s.Append("['");
                s.Append(control.UniqueID);
                s.Append("'].select();\n");

                s.Append("}\n");
                s.Append("// -->\n");

                s.Append("window.onload = SetInitialFocus;\n");
                s.Append("</SCRIPT>");

                // Register Client Script
                control.Page.RegisterClientScriptBlock("InitialFocus", s.ToString());
            }
        }
        #endregion

        #region EditSQL �ϐ��𑕏�
        /// <summary>
        /// EditSQL �������''������
        /// </summary>
        /// <param name="o">�ϊ����I�u�W�F�N�g</param>
        /// <returns>�ϊ���̕�����</returns>
        public string EditSQL(object o)
        {
            string rtn = "";

            if (o is string)
            {
                try
                {
                    rtn = "'" + o.ToString() + "'";
                }
                catch
                {
                    rtn = "";
                }
            }
            else if (o is int)
            {
                try
                {
                    rtn = int.Parse(o.ToString()).ToString();
                }
                catch
                {
                    rtn = "0";
                }
            }
            else if (o is long)
            {
                try
                {
                    rtn = long.Parse(o.ToString()).ToString();
                }
                catch
                {
                    rtn = "0";
                }
            }
            else if (o is double)
            {
                try
                {
                    rtn = double.Parse(o.ToString()).ToString();
                }
                catch
                {
                    rtn = "0";
                }
            }
            else if (o is decimal)
            {
                try
                {
                    rtn = decimal.Parse(o.ToString()).ToString();
                }
                catch
                {
                    rtn = "0";
                }
            }

            return rtn;

        }
        #endregion

        #region Set_Attributes ��ʃt�H�[�}�b�g
        //------------------------------------------------------------------------
        // Grid Layout Panel �̎q���i�̑������ȉ��� Mode �ɂ�葮����ݒ�
        //
        //		Mode)  0:�Ɖ�  1:����
        //------------------------------------------------------------------------
        public void Set_Attributes(System.Web.UI.HtmlControls.HtmlContainerControl divC, int Mode)
        {
            string strCss = "";

            for (int i = 0; i < divC.Controls.Count; i++)
            {
                switch (divC.Controls[i].GetType().Name)
                {
                    case "Label":
                        if (((Label)divC.Controls[i]).CssClass != "fd_mtitle" && ((Label)divC.Controls[i]).CssClass != "fi_mtitle")
                        {
                            if (Mode == 1)
                            {
                                if (((Label)divC.Controls[i]).CssClass == "d_mtitle")
                                    ((Label)divC.Controls[i]).CssClass = "i_mtitle";
                                else if (((Label)divC.Controls[i]).CssClass == "d_mtitle_c")
                                    ((Label)divC.Controls[i]).CssClass = "i_mtitle_c";
                            }
                            else
                            {
                                if (((Label)divC.Controls[i]).CssClass == "i_mtitle")
                                    ((Label)divC.Controls[i]).CssClass = "d_mtitle";
                                else if (((Label)divC.Controls[i]).CssClass == "i_mtitle_c")
                                    ((Label)divC.Controls[i]).CssClass = "d_mtitle_c";
                            }
                        }
                        break;

                    case "TextBox":
                    case "NumberBox":
                        strCss = ((TextBox)divC.Controls[i]).CssClass;
                        if (Mode == 1)
                        {
                            if (((TextBox)divC.Controls[i]).CssClass != "d_label")
                            {
                                ((TextBox)divC.Controls[i]).ReadOnly = false;
                            }
                            if (divC.Controls[i].GetType().Name == "NumberBox")
                            {
                                strCss = "text_input_right_key";
                            }
                            else
                            {
                                switch (((TextBox)divC.Controls[i]).CssClass)
                                {
                                    case "text_disp_right": strCss = "text_input_right"; break;
                                    case "text_disp_center": strCss = "text_input_center"; break;
                                    case "text_disp_left": strCss = "text_input_left"; break;
                                    case "text_disp_right_key": strCss = "text_input_right_key"; break;
                                    case "text_disp_center_key": strCss = "text_input_center_key"; break;
                                    case "text_disp_left_key": strCss = "text_input_left_key"; break;
                                }
                            }
                        }
                        else
                        {
                            ((TextBox)divC.Controls[i]).ReadOnly = true;
                            if (divC.Controls[i].GetType().Name == "NumberBox")
                            {
                                strCss = "text_disp_right_key";
                            }
                            else
                            {
                                switch (((TextBox)divC.Controls[i]).CssClass)
                                {
                                    case "text_input_right": strCss = "text_disp_right"; break;
                                    case "text_input_center": strCss = "text_disp_center"; break;
                                    case "text_input_left": strCss = "text_disp_left"; break;
                                    case "text_input_right_key": strCss = "text_disp_right_key"; break;
                                    case "text_input_center_key": strCss = "text_disp_center_key"; break;
                                    case "text_input_left_key": strCss = "text_disp_left_key"; break;
                                }
                            }
                        }



                        ((TextBox)divC.Controls[i]).CssClass = strCss;
                        break;
                    /**
                                        case "NumberBox" :
                                            if (Mode == 1 || Mode == 0 || Mode == 4 ) {
                                                ((TextBox)divC.Controls[i]).ReadOnly = false;
                                                ((TextBox)divC.Controls[i]).ForeColor = Color.Black;
                                            }
                                            else {
                                                ((TextBox)divC.Controls[i]).ReadOnly = true;
                                                ((TextBox)divC.Controls[i]).ForeColor = Color.Gray;
                                            }							
                                            break;
                    **/
                    case "DropDownList":
                        if (Mode == 1)
                            ((DropDownList)divC.Controls[i]).Enabled = true;
                        else
                            ((DropDownList)divC.Controls[i]).Enabled = false;
                        break;

                    case "CheckBox":
                        if (Mode == 1)
                            ((CheckBox)divC.Controls[i]).Enabled = true;
                        else
                            ((CheckBox)divC.Controls[i]).Enabled = false;
                        break;
                    case "RadioButtonList":
                        if (Mode == 1)
                            ((RadioButtonList)divC.Controls[i]).Enabled = true;
                        else
                            ((RadioButtonList)divC.Controls[i]).Enabled = false;
                        break;

                }
            }
        }

        public string DateFormat(string p, string p_2)
        {
            throw new NotImplementedException();
        }
        #endregion

        //ADD BY UBIQ-LIU 2010/8/24
        #region # javascript �����ϊ� #
        /// <summary>
        /// �V���{�����g���ꍇ�A�ϊ������������߂�
        /// </summary>
        /// <param name="instr">�R�[�h�A����</param>
        /// <returns>�ϊ�����������</returns>
        public string SetJsStr(string instr)
        {
            return instr.Replace("'", "\\'");//�R�[�h�A���̂Ɂu'�v���g���ꍇ�A�u\\'�v�̕ϊ�
        }
        #endregion

        #region # CSV �����ϊ� #
        /// <summary>
        /// �u,�v���g���ꍇ�A�ϊ������������߂�
        /// </summary>
        /// <param name="instr">������</param>
        /// <returns>�ϊ�����������(�܁u,�v)</returns>
        public string SetCsvStr(string instr)
        {
            //�������Ɂu,�v���g�����ꍇ
            if (instr.IndexOf(",") != -1)
            {
                return "\"" + instr + "\"" + Getcharacter();
            }
            else//���̑��ꍇ
            {
                return "=\"" + instr + "\"" + Getcharacter();
            }
        }
        #endregion

        //add by ubiq-suo 2010/10/21 start
        #region # ��؂蕶�� #
        public string Getcharacter()
        {
            return "\t";
        }
        #endregion
        //add by ubiq-suo 2010/10/21 end

        #region SetddlData �����ޯ���ɕ\���l��Ă���(SQL)
        /// <summary>
        /// �����ޯ���ɕ\���l��Ă���
        /// </summary>
        /// <param name="ddl">�����ޯ��</param>
        /// <param name="SQL">SQL��</param>
        /// <param name="blank">�擪�ɋ󔒂�Ă���</param>
        /// <param name="Description">Description��Ă���</param>
        public void SetDdlData(object ddl, string SQL, bool blank)
        {
            ComDB db = new ComDB();
            DataSet ds = db.DbDataSet(SQL, "ddlData");
            db.DbClose();   //add by suo 2010/05/25
            if (ds != null && ds.Tables["ddlData"] != null)
            {
                DataTable dt = ds.Tables["ddlData"];
                dt.Columns[0].ColumnName = "VALUE";
                dt.Columns[1].ColumnName = "DISP";

                if (blank)
                {
                    //���ݸ�s�̒ǉ�
                    DataRow _dr = dt.NewRow();
                    dt.Rows.InsertAt(_dr, 0);
                }

                try
                {
                    if (ddl is System.Web.UI.WebControls.DropDownList)
                    {
                        //�����ޯ���ɾ��
                        ((DropDownList)ddl).DataSource = dt;
                        ((DropDownList)ddl).DataTextField = "DISP";
                        ((DropDownList)ddl).DataValueField = "VALUE";
                        ((DropDownList)ddl).DataBind();
                    }
                    //Add by Ubiq-Zhu 2010/04/20
                    else if (ddl is System.Web.UI.WebControls.ListBox)
                    {
                        ((ListBox)ddl).DataSource = dt;
                        ((ListBox)ddl).DataTextField = "DISP";
                        ((ListBox)ddl).DataValueField = "VALUE";
                        ((ListBox)ddl).DataBind();
                    }
                    //else if (ddl is AjaxDataControls.GridViewDropDownListColumn)
                    //{
                    //    //datagridview�̺��ނɾ��
                    //    ((GridViewDropDownListColumn)ddl).DisplayMember = "DISP";
                    //    ((GridViewDropDownListColumn)ddl).ValueMember = "VALUE";
                    //    ((GridViewDropDownListColumn)ddl).DataSource = dt;
                    //    ((GridViewDropDownListColumn)ddl).DataBind();
                    //}
                }
                catch
                {
                    //throw new ComException(e.Message, null, null, MethodInfo.GetCurrentMethod().Name);
                    return;
                }
            }

        }
        #endregion

        /// <summary>
        /// EditString �w�蕶������Œ蒷�ɂ���B�؎̂ĂƁA' 'PADDING
        /// </summary>
        /// <param name="o">�ϊ����I�u�W�F�N�g</param>
        /// <returns>�ϊ���̕�����</returns>
        public string EditString(string inStr, int len)
        {
            string rtnStr = inStr;

            if (inStr.Length > len)
                rtnStr = inStr.Substring(0, len);
            else
                rtnStr = inStr.PadRight(len, ' ');

            return rtnStr;

        }

    }
}