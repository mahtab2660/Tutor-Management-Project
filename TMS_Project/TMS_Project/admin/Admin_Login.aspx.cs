﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TMS_Project.admin
{
    public partial class Admin_Login : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Admin_Login where Username = @Username and Password = @Password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Username", UsernameTxt.Text);
            cmd.Parameters.AddWithValue("@Password", PasswordTxt.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                //Response.Write("<script>alert('Login SuccessFull');</script>");
                Session["Admin_Username"] = UsernameTxt.Text;
                Response.Redirect("Admin_Index.aspx");
            }
            else
            {
                //Response.Write("<script>alert('Username Or Password is Incorrect');</script>");
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "Swal.fire('Failure','Username Or Password is Incorrect','error')", true);
            }
            con.Close();

        }
    }
}



