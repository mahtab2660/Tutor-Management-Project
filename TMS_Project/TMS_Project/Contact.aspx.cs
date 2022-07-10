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
    public partial class Contact : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void ResetContant()
        {
            NameTextBox.Text = "";
            EmailTextBox.Text = "";
            SubjectDropDownList1.ClearSelection();
            MessageTextBox.Text = "";
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(cs);
            string sp = "spContact_Insert";
            SqlCommand Cmd = new SqlCommand(sp, Con);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue ("@Name",NameTextBox.Text);
            Cmd.Parameters.AddWithValue("@Email",EmailTextBox.Text);
            Cmd.Parameters.AddWithValue("@Subject",SubjectDropDownList1.SelectedItem.ToString());
            Cmd.Parameters.AddWithValue("@Message",MessageTextBox.Text);
            Con.Open();
            int a = Cmd.ExecuteNonQuery();
            if (a > 0)
            {
                //Response.Write("<script>alert('Form has been Submitted Succesfully')</script>");
                //Response.Write("SuccessContent");
                ScriptManager.RegisterStartupScript(this,GetType(),"PopUp", "SuccessContact();", true);
                ResetContant();
            }
            else
            {
                Response.Write("<script>alert('Form Inserted Failed')</script>");
                ScriptManager.RegisterStartupScript(this, GetType(), "PopUp", "ErrorContact();", true);
            }
            Con.Close();

        }
    }
}