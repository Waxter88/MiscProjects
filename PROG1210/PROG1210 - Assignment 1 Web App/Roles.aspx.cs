using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROG1210;


namespace PROG1210___Assignment_1_Web_App
{
    public partial class Roles : System.Web.UI.Page
    {
        //public Role role;
        List<Role> roles;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPersonnel.Text = "";
            //Add another Web Form to the project named Roles. Display all the roles in a drop down list. When the user selects a Role display the matching Personnel by calling the property method Personnel.
            int roleID = Int32.Parse(rolesDropDown.SelectedItem.Value);
            //from Role class, get all roles
            roles = PROG1210.Role.GetAllRoles(out string status);
            foreach(Role r in roles)
            {
                if(r.ID == roleID)
                {
                    List<string> personnel = r.Personnel();
                    //display personnel in txtPersonnel
                    personnel.ForEach(p => txtPersonnel.Text += p + " \n");
                }
            }
        }
    }
}