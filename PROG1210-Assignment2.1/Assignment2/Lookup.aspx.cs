using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2
{
    public partial class Lookup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void FormView1_ItemDeleted(object sender, FormViewDeletedEventArgs e)
        {
            if (e.Exception != null)
            {
                e.ExceptionHandled = true;
                lblStatus.Text = "Unable to delete record. Exception: " + e.Exception.Message;
            }
        }

        protected void FormView1_ModeChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "Ready...";
        }

        protected void FormView2_ItemDeleted(object sender, FormViewDeletedEventArgs e)
        {
            if (e.Exception != null)
            {
                e.ExceptionHandled = true;
                lblStatus.Text = "Unable to delete record. Exception: " + e.Exception.Message;
            }
        }

        protected void FormView2_ModeChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "Ready...";
        }

        protected void FormView3_ModeChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "Ready...";
        }

        protected void FormView3_ItemDeleted(object sender, FormViewDeletedEventArgs e)
        {
            if (e.Exception != null)
            {
                e.ExceptionHandled = true;
                lblStatus.Text = "Unable to delete record. Exception: " + e.Exception.Message;
            }
        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
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

        protected void GridView2_RowDeleted(object sender, GridViewDeletedEventArgs e)
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

        protected void GridView3_RowDeleted(object sender, GridViewDeletedEventArgs e)
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(GridView1.SelectedIndex != -1)
            {
                lblStatus.Text = "Ready...";
                this.DetailsView1.PageIndex = this.GridView1.SelectedIndex;
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridView2.SelectedIndex != -1)
            {
                lblStatus.Text = "Ready...";
                this.DetailsView2.PageIndex = this.GridView2.SelectedIndex;
            }
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridView3.SelectedIndex != -1)
            {
                lblStatus.Text = "Ready...";
                this.DetailsView3.PageIndex = this.GridView3.SelectedIndex;
            } 
        }
    }
}