using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmmasClassLibraryPROG1210.EmmasDataSetTableAdapters;
using EmmasClassLibraryPROG1210;
using System.Net;

namespace EmmasWebApp
{
    public partial class Inventory : System.Web.UI.Page
    {
        private static EmmasDataSet dsEmma;
        private static DataRow[] products;

        static Inventory()
        {
            dsEmma = new EmmasDataSet();
            productTableAdapter daProduct = new productTableAdapter();

            try
            {
                daProduct.Fill(dsEmma.product);
            }
            catch { }
        }

        private string GetInventoryCriteria()
        {
            string criteria = "";
            //by product name
            criteria = (this.txtInventoryProdName.Text.Length > 0 && criteria.Length > 0) ? " AND prodName LIKE '" + this.txtInventoryProdName.Text + "'"
                : (this.txtInventoryProdName.Text.Length > 0) ? " prodName LIKE '%" + this.txtInventoryProdName.Text + "%'" : "";
            //by product description
            criteria += (this.txtInventoryProdDesc.Text.Length > 0 && criteria.Length > 0) ? " AND prodDescription Like '" + this.txtInventoryProdDesc.Text + "'"
                : (this.txtInventoryProdDesc.Text.Length > 0) ? " prodDescription LIKE '%" + this.txtInventoryProdDesc.Text + "%'" : "";
            return criteria;
        }

        private void DisplayProductInfo()
        {

            //display inventory info in list box (searchResults)
            if (products.Count() > 0)
            {
                searchResults.Items.Clear();
                foreach (DataRow row in products)
                {
                    string prod = row["prodName"].ToString() + " - " + row["prodDescription"].ToString();
                    string id = row["id"].ToString();

                    searchResults.Items.Add(new ListItem(prod, id));
                }
                lblRecordCount.Text = products.Count().ToString() + " products found.";
                searchResults.DataBind();
            }
            else
            {
                lblRecordCount.Text = "No products found.";
                searchResults.Items.Clear();
                searchResults.DataBind();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        //search products
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.txtInventoryProdDesc.Text.Length > 0 || this.txtInventoryProdName.Text.Length > 0)
            {
                searchResults.Items.Clear();
                //get customer criteria
                string criteria = GetInventoryCriteria();

                //get customer info
                products = dsEmma.product.Select(criteria);

                //display customer info
                DisplayProductInfo();
            }
            else
            {
                searchResults.Items.Clear();
                searchResults.DataBind();
                lblRecordCount.Text = "Please enter a search criteria and try again.";
            }
        }

        protected void bttnShowAllInventory_Click(object sender, EventArgs e)
        {
            string criteria = "";
            products = dsEmma.product.Select(criteria);
            DisplayProductInfo();
        }

        protected void bttnSelectInventory_Click(object sender, EventArgs e)
        {
            searchResults.DataBind();
        }
    }
}