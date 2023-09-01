using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PROG1210
{
    public class Role
    {
        public int ID { get; set; }
        public string RoleDescription { get; set; }

        //Add a property method for a Role object named Personnel; this property method has a get block that returns all the
        //personnel full names for that role in a collection of type List<string>.
        //Personnel Fields: FirstName, MiddleName, LastName
        //Use MovieRole to get the personnel for the role
        
        public List<string> Personnel()
        {
            {
                List<string> personnel = new List<string>();
                Data.con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Data.con;
                cmd.CommandText = "SELECT FirstName, MiddleName, LastName, roleID FROM Personnel INNER JOIN MovieRole ON Personnel.ID = MovieRole.personnelID WHERE roleID = @RoleID";
                cmd.Parameters.AddWithValue("@RoleID", ID);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string firstName = dr["FirstName"].ToString();
                    string middleName = dr["MiddleName"].ToString();
                    string lastName = dr["LastName"].ToString();
                    if (middleName == "")
                    {
                        personnel.Add(firstName + " " + lastName);
                    }
                    else
                    {
                        personnel.Add(firstName + " " + middleName + " " + lastName);
                    }
                }
                Data.con.Close();
                return personnel;
            }
        }

        override public string ToString()
        {
            return RoleDescription;
        }

        //Write a static data access method in your Role class named GetAllRoles. The method has an out parameter that
        //provides an appropriate status message and returns all role records as objects in a collection of type List<Role>.Use an
        //SQL Select statement to retrieve the records

        public static List<Role> GetAllRoles(out string status)
        {
            List<Role> roles = new List<Role>();
            status = "OK";
            try
            {
                //Create a SQLCommand object to execute the SQL statement
                string sql = "SELECT * FROM Role";
                using (SqlCommand cmd = new SqlCommand(sql, Data.con))
                {
                    //Open the connection
                    Data.con.Open();
                    //Execute the SQL statement
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        //Read the data
                        while (dr.Read())
                        {
                            Role role = new Role();
                            role.ID = (int)dr["ID"];
                            role.RoleDescription = (string)dr["RoleDescription"];
                            roles.Add(role);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                status = ex.Message;
            }
            finally
            {
                Data.con.Close();
            }
            return roles;
        }
        


    }
}
