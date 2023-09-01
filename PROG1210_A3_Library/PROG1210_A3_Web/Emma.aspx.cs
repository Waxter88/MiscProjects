using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROG1210_A3_Library;
using PROG1210_A3_Library.EmmasDataSetTableAdapters;

namespace PROG1210_A3_Web
{
    public partial class Emma : System.Web.UI.Page
    {
        private static EmmasDataSet dsEmma;
        private static DataRow[] customers;
        private static DataRow[] recipts;

        static Emma()
        {
            dsEmma = new EmmasDataSet();
            customerTableAdapter daCustomer = new customerTableAdapter();
            receiptTableAdapter daRecipt = new receiptTableAdapter();
            try
            {
                daCustomer.Fill(dsEmma.customer);
                daRecipt.Fill(dsEmma.receipt);
            }
            catch { }
            
        }

        private string GetCustomerCriteria()
        {
            string criteria = "";
            //get customer by first name
            criteria = (this.txtCustFirstName.Text.Length > 0 && criteria.Length > 0) ? " AND custFirst LIKE '" + this.txtCustFirstName.Text + "'"
                : (this.txtCustFirstName.Text.Length > 0) ? " custFirst LIKE '%" + this.txtCustFirstName.Text + "%'" : "";

            //get customer by last name
            criteria += (this.txtCustLastName.Text.Length    > 0 && criteria.Length > 0) ? " AND custLast LIKE '" + this.txtCustLastName.Text + "'"
                : (this.txtCustLastName.Text.Length > 0) ? " custLast LIKE '%" + this.txtCustLastName.Text + "%'" : "";

            return criteria;
        }

        private string GetReciptCriteria()
        {
            string criteria = "";
            //get recipt by employee id
            criteria = (this.txtEmpFirstName.Text.Length > 0 && criteria.Length > 0) ? " AND empFirst LIKE '" + this.txtEmpFirstName.Text + "'"
                : (this.txtEmpFirstName.Text.Length > 0) ? " empFirst LIKE '%" + this.txtEmpFirstName.Text + "%'" : "";

            return criteria;
        }
        
        //add recipts to listRecipts
        private void DisplayRecipts()
        {
            this.listRecipts.Items.Clear();
            if (recipts.Count() > 0)
            {
                foreach (DataRow row in recipts)
                {
                    this.listRecipts.Items.Add("Recipt #" + row.ItemArray[0] + " - " + row.ItemArray[9].ToString() + " " + row.ItemArray[10].ToString());
                }
            }
            else
            {
                listRecipts.Items.Add("No record(s) found. Try widening your search criteria.");
            }
        }
        //display customer info
        private void DisplayCustomerInfo()
        {
            if(customers.Count() > 0)
            {
                foreach(DataRow row in customers)
                {
                    //declare table rows to hold table
                    TableRow tr = new TableRow();
                    //declare table cells to hold cell data
                    TableCell firstName = new TableCell();
                    TableCell lastName = new TableCell();
                    TableCell phone = new TableCell();
                    TableCell address = new TableCell();
                    TableCell city = new TableCell();
                    TableCell postal = new TableCell();
                    TableCell email = new TableCell();

                    //add data to each table cell
                    firstName.Text = row.ItemArray[1].ToString();
                    lastName.Text = row.ItemArray[2].ToString();
                    phone.Text = row.ItemArray[3].ToString();
                    address.Text = row.ItemArray[4].ToString();
                    city.Text = row.ItemArray[5].ToString();
                    postal.Text = row.ItemArray[6].ToString();
                    email.Text = row.ItemArray[7].ToString();
                    
                    //Add each table cell to the table row
                    tr.Cells.Add(firstName);
                    tr.Cells.Add(lastName);
                    tr.Cells.Add(phone);
                    tr.Cells.Add(address);
                    tr.Cells.Add(city);
                    tr.Cells.Add(postal);
                    tr.Cells.Add(email);

                    this.tblCustomerInfo.Rows.Add(tr);
                    
                }
                lblRecordCount.Text = "# Of Customers found: " + customers.Count().ToString();
            }
            else
            {
                lblRecordCount.Text = "No record(s) found.";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            if(dsEmma.customer.Count > 0 && (txtCustFirstName.Text != "" || txtCustLastName.Text != ""))
            {
                string criteria = GetCustomerCriteria();
                customers = (criteria.Length > 0) ? dsEmma.customer.Select(criteria) : dsEmma.customer.Select();
                DisplayCustomerInfo();
            }
            else
            {
                lblRecordCount.Text = "No record(s) found.";
            }
        }

        protected void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            if(dsEmma.receipt.Count > 0 && (txtEmpFirstName.Text != "" || txtEmpLastName.Text != ""))
            {
                string criteria = GetReciptCriteria();
                recipts = (criteria.Length > 0) ? dsEmma.receipt.Select(criteria) : dsEmma.receipt.Select();
                DisplayRecipts();
                lblRecordCount.Text = "# of Customers found (by employee): " + recipts.Count();
            }
            else
            {
                listRecipts.Items.Clear();
                lblRecordCount.Text = "No record(s) found.";
            }
        }

        protected void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            if(recipts.Count() > 0 && this.listRecipts.SelectedIndex != -1)
            {
                //display all customer info in txtCustomerResult
                //select customer by id
                string criteria = "id = " + recipts[this.listRecipts.SelectedIndex].ItemArray[1];
                customers = dsEmma.customer.Select(criteria);
                DisplayCustomerInfo();


            }
            


        }

        protected void txtCustFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}