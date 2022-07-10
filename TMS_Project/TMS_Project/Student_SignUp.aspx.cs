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
    public partial class Student_SignUp : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void ResetControl()
        {
            NameTxt.Text = "";
            FatherNameTxt.Text = "";
            SurNameTxt.Text = "";
            GenderDropDownList.ClearSelection();
            AgeTxt.Text = "";
            CountryDropDownList.ClearSelection();
            CityTxt.Text = "";
            AddressTxt.Text = "";
            ClassTxt.Text = "";
            GoingToDropDownList.ClearSelection();
            SubjectTxt.Text = "";
            ContactTxt.Text = "";
            TuitionPreferredDropDownList.ClearSelection();
            TuitionTypeDropDownList.ClearSelection();
            UsernameTxt.Text = "";
            PasswordTxt.Text = "";
            ConfirmPasswordTxt.Text = "";
        


        }

        protected void Submitbtn_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(cs);
            
            
                string query = "insert into Student_SignUp values (@Name,@Father_Name,@SurName,@Gender,@Age,@Country,@City,@Address,@Standard,@GoingTo,@Subject,@ContactNo,@TuitionType,@TutorPrefrred,@Username,@Password)";
                SqlCommand Cmd = new SqlCommand(query, Con);
                Cmd.Parameters.AddWithValue("@Name", NameTxt.Text);
                Cmd.Parameters.AddWithValue("@Father_Name", FatherNameTxt.Text);
                Cmd.Parameters.AddWithValue("@SurName", SurNameTxt.Text);
                Cmd.Parameters.AddWithValue("@Gender", GenderDropDownList.SelectedItem.ToString());
                Cmd.Parameters.AddWithValue("@Age", AgeTxt.Text);
                Cmd.Parameters.AddWithValue("@Country", CountryDropDownList.SelectedItem.ToString());
                Cmd.Parameters.AddWithValue("@City", CityTxt.Text);
                Cmd.Parameters.AddWithValue("@Address", AddressTxt.Text);
                Cmd.Parameters.AddWithValue("@Standard", ClassTxt.Text);
                Cmd.Parameters.AddWithValue("@GoingTo", GoingToDropDownList.SelectedItem.ToString());
                Cmd.Parameters.AddWithValue("@Subject", SubjectTxt.Text);
                Cmd.Parameters.AddWithValue("@ContactNo", ContactTxt.Text);
                Cmd.Parameters.AddWithValue("@TuitionType", TuitionPreferredDropDownList.SelectedItem.ToString());
                Cmd.Parameters.AddWithValue("@TutorPrefrred", TuitionPreferredDropDownList.SelectedItem.ToString());
                Cmd.Parameters.AddWithValue("@Username", UsernameTxt.Text);
                Cmd.Parameters.AddWithValue("@Password", PasswordTxt.Text);
                Con.Open();
                int a = Cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    Response.Write("<Script>alert('SignUp Succesfully')</Script>");
                    ResetControl();
                }
                else
                {
                    Response.Write("<Script>alert('Registeration Failed .. try Another Username & Password')</Script>");
                }
            
          
                Con.Close();
            

        }

     
    }
}

