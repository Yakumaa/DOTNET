using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace userRegistration
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_submit(object sender, EventArgs e)
        {
            //extracting for feilds
            string username = uname.Text;
            string password = pass.Text;
            string repassword = repass.Text;
         
            string gender;
            if (r1.Checked)
            {
                gender = r1.Text;
            }
            else if (r2.Checked)
            {
                gender = r2.Text;
            }
            else
            {
                l7.Text = "Please select a gender";
                return;
            }

            string courses = "";
            if (c1.Checked)
            {
                courses += c1.Text + ", ";
            }
            if (c2.Checked)
            {
                courses += c2.Text + ", ";
            }
            if (c3.Checked)
            {
                courses += c3.Text + ", ";
            }

            string coun = "";
            if (country.SelectedValue == "")
            {
                coun = "enter your country";
            }
            else
            {
                coun = country.SelectedValue;
            }

            string cs = "Data Source=SHRIJALA-PC\\SQLEXPRESS;Initial Catalog=db_prime;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);

            try
            {
                conn.Open();
                string insQuery = "insert into tbl_reg (username, password, gender, courses, country) VALUES (" +
                    "@username, @password, @gender, @courses, @country)";
          
                SqlCommand sc = new SqlCommand(insQuery, conn);
                sc.Parameters.AddWithValue("@username", username);
                sc.Parameters.AddWithValue("@password", password);
                sc.Parameters.AddWithValue("@repassword", repassword);
                sc.Parameters.AddWithValue("@gender", gender);
                sc.Parameters.AddWithValue("@courses", courses);
                sc.Parameters.AddWithValue("@country", coun);

                int res = sc.ExecuteNonQuery();
                if (res > 0)
                {
                    l7.Text = "data inserted";
                }
                else
                {
                    l7.Text = "data not inserted";
                }
            }
            catch (SqlException error)
            {
                l7.Text = error.Message;
            }
        }
    }
}