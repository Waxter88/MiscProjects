using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;

namespace PROG1210_WebApp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button3.Visible = false;
            Button4.Visible = false;

            CalcTotalPrice();
        }

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {

        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            FormView4.ChangeMode(FormViewMode.Edit);
            
        }
        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            FormView4.UpdateItem(true);
        }
        protected void UpdateCancelButton_Click(object sender, EventArgs e)
        {
            FormView4.ChangeMode(FormViewMode.ReadOnly);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //edit
            FormView4.ChangeMode(FormViewMode.Edit);
            
            FormView3.ChangeMode(FormViewMode.Edit);
            
            Button3.Visible = true;
            Button4.Visible = true;
            Button1.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //cancel
            FormView4.ChangeMode(FormViewMode.ReadOnly);
            FormView3.ChangeMode(FormViewMode.ReadOnly);
            
            Button3.Visible = false;
            Button4.Visible = false;
            Button1.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            
            FormView4.UpdateItem(true);
            FormView3.UpdateItem(true);
            Button3.Visible = false;
            Button4.Visible = false;
            Button1.Visible = true;
            
            FormView4.DataBind();
            FormView3.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //select

        }

        protected void CalcTotalPrice()
        {
            GridView1.DataBind();
            decimal total = 0.0m;
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                total += Convert.ToDecimal(GridView1.Rows[i].Cells[2].Text);
            }
            Label1.Text = "Order Total is " + total.ToString("c");
        }
        
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            CalcTotalPrice();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.FormView5.PageIndex = this.DropDownList1.SelectedIndex;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}