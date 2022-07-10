using System;
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
    public partial class View_Contact : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin_Username"] == null)
            {
                Response.Redirect("Admin_Login.aspx");
            }
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Contact_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            Contact2.DataSource = data;
            Contact2.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = Contact2.Rows[e.RowIndex];
            Label ItemId = (Label)row.FindControl("LabelID");
            string Id = ItemId.Text;
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from Contact_tbl where Id = @Id";
            SqlCommand Cmd = new SqlCommand(query, con);
            Cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            int a = Cmd.ExecuteNonQuery();
            if (a > 0)
            {
                Response.Write("<script>alert('Data has been Deleted Successfully')</script>");
                BindGridView();
            }
            con.Close();
        }
    }
}