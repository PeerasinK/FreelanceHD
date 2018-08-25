using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Honda.Model;
using System.Data;

namespace HondaTraceabilitySystem
{
    public partial class MCDaily : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Style.Add("display", "none");

            if (!IsPostBack)
            {
                BindingGrid();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MCDailyGenerate.aspx");
        }

        public void BindingGrid()
        {
            DataTable dt = new DataTable();
            MCDelObj objI = new MCDelObj();
            objI.DelDate = txtSelectDate.Text.Trim();
            objI.DelType = ddlDeliveryType.SelectedValue.Trim();
            objI.KDLot = txtKDLot.Text.Trim();

            dt = SQLManager.GridItemDetail(objI);

            gdvDaily.DataSource = dt;
            gdvDaily.DataBind();
        }

        protected void btnSearchModi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSelectDateModi.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please select date!!!')", true);
            }
            else
            {
                if (String.IsNullOrEmpty(txtSozaiNo.Text))
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please input SozaiNo!!!')", true);
                }
            }

            if (!String.IsNullOrEmpty(txtSelectDateModi.Text) && !String.IsNullOrEmpty(txtSozaiNo.Text))
            {
                DataTable dt = new DataTable();

                ddlLot1.DataSource = dt;
                ddlLot1.DataBind();
                ddlLot1.Items.Insert(0, new ListItem("--- SELECT ITEM ---"));
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindingGrid();
        }

        protected void btnAddModiLot1_Click(object sender, EventArgs e)
        {
            if (ddlLot1.SelectedValue != "--- Select Item ---")
            {
                txtLotNo1.Text = ddlLot1.SelectedValue.Trim();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}