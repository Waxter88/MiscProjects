using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmmasClassLibraryPROG1210;
using EmmasClassLibraryPROG1210.EmmasDataSetTableAdapters;
//By: Jackson Pipe
//For: PROG1210 Final Project

//TODO: 
//Select customer from searchResults to populate customer details and perform CRUD operations on customer
//Select all customers button
namespace EmmasWebApp
{
    public partial class Customers : System.Web.UI.Page
    {
        private static EmmasDataSet dsEmma;
        private static DataRow[] customers;

        static Customers()
        {
            dsEmma = new EmmasDataSet();
            customerTableAdapter daCustomer = new customerTableAdapter();
            customerByIDTableAdapter daCustomerByID = new customerByIDTableAdapter();
            try
            {
                daCustomer.Fill(dsEmma.customer);
                //daCustomerByID.Fill(dsEmma.customer1);
            }
            catch { }
        }

        

        protected void Page_Load(object sender, EventArgs e)
        {
            Console.WriteLine("page loaded");
            if (!IsPostBack)
            {
                Console.WriteLine("page not postback");
                searchResults.DataBind();
            }
        }

        private string GetCustomerCriteria()
        {
            string criteria = "";
            //get customer by first name
            criteria = (this.txtCustFirstName.Text.Length > 0 && criteria.Length > 0) ? " AND custFirst LIKE '" + this.txtCustFirstName.Text + "'"
                : (this.txtCustFirstName.Text.Length > 0) ? " custFirst LIKE '%" + this.txtCustFirstName.Text + "%'" : "";

            //get customer by last name
            criteria += (this.txtCustLastName.Text.Length > 0 && criteria.Length > 0) ? " AND custLast LIKE '" + this.txtCustLastName.Text + "'"
                : (this.txtCustLastName.Text.Length > 0) ? " custLast LIKE '%" + this.txtCustLastName.Text + "%'" : "";

            return criteria;
        }

        private void DisplayCustomerInfo()
        {
            //display customer info in list box (searchResults)
            if (customers.Count() > 0)
            {
                searchResults.Items.Clear();
                foreach (DataRow row in customers)
                {
                    string fullName = row["custFirst"].ToString() + " " + row["custLast"].ToString();
                    string id = row["id"].ToString();

                    searchResults.Items.Add(new ListItem(fullName, id));
                }
                    lblRecordCount.Text = customers.Count().ToString() + " customers found.";
                    searchResults.DataBind();
            }
            else
            {
                lblRecordCount.Text = "No customers found.";
                searchResults.Items.Clear();
                searchResults.DataBind();
            }
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void bttnSearchCustomer_Click(object sender, EventArgs e)
        {
            //if txtCustFirstName or txtCustLastName is not empty, search for customer with that name

            if (this.txtCustFirstName.Text.Length > 0 || this.txtCustLastName.Text.Length > 0)
            {
                searchResults.Items.Clear();
                //get customer criteria
                string criteria = GetCustomerCriteria();

                //get customer info
                customers = dsEmma.customer.Select(criteria);

                //display customer info
                DisplayCustomerInfo();
            }
            else
            {
                searchResults.Items.Clear();
                searchResults.DataBind();
                lblRecordCount.Text = "Please enter a search criteria and try again.";
            }
        }

        protected void bttnSelectCustomer_Click(object sender, EventArgs e)
        {
            lblRecordCount.Text = "Selecting customer";
            searchResults.DataBind();
           
        }
        //show all customers button
        protected void Button1_Click(object sender, EventArgs e)
        {
            string criteria = "";
            customers = dsEmma.customer.Select(criteria);
            DisplayCustomerInfo();
        }
    }

}