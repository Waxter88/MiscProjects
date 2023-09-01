using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmmasClassLibraryPROG1210.EmmasDataSetTableAdapters;
using EmmasClassLibraryPROG1210;

namespace EmmasWebApp
{
    public partial class Orders : System.Web.UI.Page
    {
        private static EmmasDataSet dsEmma;
        private static DataRow[] orders;
        
        static Orders()
        {
            dsEmma = new EmmasDataSet();
            orderTableAdapter daOrders = new orderTableAdapter();
            
            try
            {
                daOrders.Fill(dsEmma.orders);
            }
            catch { }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string GetOrdersCriteria()
        {
                string criteria = "";
                //by order number
                criteria += (this.txtOrderNumber.Text.Length > 0 && criteria.Length > 0) ? " AND pordNumber Like '" + this.txtOrderNumber.Text + "'"
                    : (this.txtOrderNumber.Text.Length > 0) ? " pordNumber LIKE '%" + this.txtOrderNumber.Text + "%'" : "";
                return criteria;
        }

        private void DisplayOrderInfo()
        {
            //display order info in list box (searchResults)
            if (orders.Count() > 0)
            {
                searchResults.Items.Clear();
                foreach (DataRow row in orders)
                {
                    string order = "Order #: " + row["pordNumber"].ToString() + " - Date Ordered: " + row["pordDateOrdered"].ToString();
                    string id = row["pordNumber"].ToString();

                    searchResults.Items.Add(new ListItem(order, id));
                }
                lblRecordCount.Text = orders.Count().ToString() + " orders found.";
                searchResults.DataBind();
            }
            else
            {
                lblRecordCount.Text = "No orders found.";
                searchResults.Items.Clear();
                searchResults.DataBind();
            }
        }
        //search orders
        protected void bttnSearchOrders_Click(object sender, EventArgs e)
        {
            if (txtOrderNumber.Text.Length > 0)
            {
                string criteria = GetOrdersCriteria();
                orders = dsEmma.orders.Select(criteria);
                DisplayOrderInfo();
            }
            else
            {
                lblRecordCount.Text = "Please enter a search criteria and try again.";
            }
        }
        //show all orders
        protected void bttnShowAllOrders_Click(object sender, EventArgs e)
        {
            string criteria = "";
            orders = dsEmma.orders.Select(criteria);
            DisplayOrderInfo();
        }

        protected void bttnSelectOrder_Click(object sender, EventArgs e)
        {
            searchResults.DataBind();
        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {

        }
        //inventory details
        //use query string to redirect to inventory page with inventoryID
        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}