using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TMS_Project
{
    public partial class Student_Login : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Student_Loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(cs);
            string query = "select * from Student_SignUp where Username = @Username and Password = @Password";
            SqlCommand Cmd = new SqlCommand(query, Con);
            Cmd.Parameters.AddWithValue("@Username", UsernameTxt.Text);
            Cmd.Parameters.AddWithValue("@Password", PasswordTxt.Text);
            Con.Open();
            SqlDataReader dr = Cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                // Response.Write("<script>alert('Login Success');</script>");
                ScriptManager.RegisterStartupScript(this, GetType(), "PopUp", "Swal.fire('Success!','You Login Succesfully!','success'); ", true);
                Session["Student_Username"] = UsernameTxt.Text;
                Response.Redirect("Student/Student_Index.aspx");
            }
            else
            {
                //Response.Write("<script>alert('Username and Password incorrect');</script>");
                ScriptManager.RegisterStartupScript(this, GetType(), "PopUp", "Swal.fire('Failure!','Please Check Username & Password!','Error'); ", true);
            }
            Con.Close();
        }
    }
}