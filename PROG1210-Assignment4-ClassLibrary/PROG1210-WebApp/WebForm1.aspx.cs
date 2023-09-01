using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROG1210_WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.FormView1.PageIndex = this.DropDownList1.SelectedIndex;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DataListItem gRow = (DataListItem)btn.Parent;
            //get selected customerID
            int pkID = (int)(DataList1.DataKeys[gRow.ItemIndex]);
            Response.Redirect("WebForm2.aspx?pkID=" + pkID);
        }

    }
}