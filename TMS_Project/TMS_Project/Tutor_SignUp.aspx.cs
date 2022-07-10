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
    public partial class Tutor_SignUp : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void ResetControl()
        {
            NameTextBox.Text = "";
           
            SurnameTextBox.Text = "";
            GenderDropDownList.ClearSelection();
            AgeTextBox.Text = "";
            CountryTextBox.Text ="";
            EmailTextBox.Text = "";
            //CityTextBox.Text = "";
            AddressTextBox.Text = "";
            QualificationDropDownList.ClearSelection();

            DegreeTextBox.Text = "";
            ExperienceDropDownList.ClearSelection();

            ContactTextBox.Text = "";
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
            ConfirmPasswordTextBox.Text = "";



        }


        protected void TutorSignUpButton_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(cs);
            
                string query = "insert into Tutor_SignUp values (@Name,@SurName,@Gender,@Age,@Email,@MeritalStatus,@Country,@Address,@Qualification,@Degree,@ContactNo,@Experience,@Username,@Password)";
                SqlCommand Cmd = new SqlCommand(query, Con);
                Cmd.Parameters.AddWithValue("@Name", NameTextBox.Text);
                Cmd.Parameters.AddWithValue("@SurName", SurnameTextBox.Text);
                Cmd.Parameters.AddWithValue("@Gender", GenderDropDownList.SelectedItem.ToString());
                Cmd.Parameters.AddWithValue("@Age", AgeTextBox.Text);
                Cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                Cmd.Parameters.AddWithValue("@MeritalStatus", MaritalStatusDropDownList.SelectedItem.ToString());
                Cmd.Parameters.AddWithValue("@Country", CountryTextBox.Text);
                Cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text);
                //Cmd.Parameters.AddWithValue("@City", CityTextBox.Text);
                Cmd.Parameters.AddWithValue("@Qualification", QualificationDropDownList.SelectedItem.ToString());
                Cmd.Parameters.AddWithValue("@Degree", DegreeTextBox.Text);
                Cmd.Parameters.AddWithValue("@ContactNo", ContactTextBox.Text);
                Cmd.Parameters.AddWithValue("@Experience", ExperienceDropDownList.SelectedItem.ToString());
                Cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
                Cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
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