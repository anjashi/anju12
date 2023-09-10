using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
namespace WebApplication6
{
    public partial class DropDownList : System.Web.UI.Page
    {
        // global
        SqlConnection con = new SqlConnection("server=DESKTOP-6FQ9581\\MSSQLSERVER01;initial Catalog=p; intigrataed security=true");
        SqlCommand cmd;
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            // local

        }
        protected void bt_Add_Click(object sender, EventArgs e)
        {
            Property.CName = txtcname.Text.Trim;
            Property.Query = "_insertCountry";
            cmd = new SqlCommand(Property.Query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cname", Property.CName);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int res = (int)cmd.ExecuteNonQuery();
            if (res == 1)
            {
                Lb_result.Text = "Saved the Record";
            }
            else
            {
                Lb_result.Text = "Not Saved the Record";
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }


        }
    }
}