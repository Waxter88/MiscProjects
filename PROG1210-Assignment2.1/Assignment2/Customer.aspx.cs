using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FormView1.PageIndex = this.DropDownList1.SelectedIndex;
            lblStatus.Text = "Ready...";
        }

        protected void FormView1_ItemDeleted(object sender, FormViewDeletedEventArgs e)
        {
            if (e.Exception != null)
            {
                e.ExceptionHandled = true;
                lblStatus.Text = "Unable to delete record. Exception: " + e.Exception.Message;
            }
            else
            {

                lblStatus.Text = "Record deleted successfully.";
            }
        }

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
        }
    }
}