using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statnoray
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CG0QM8J\\SQLEXPRESS;Initial Catalog=statnory;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbluser where userEmail='" + TextBox1.Text + "' AND userPassword='" + TextBox2.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('User Already Registred Try with to login');", true);
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("insert into tbluser(userEmail,userPassword)VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "' )", con);
                cmd.ExecuteNonQuery();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('User Registerd Successfully');", true);
                //  Response.Redirect("login.aspx");
                TextBox1.Text = "";
                TextBox2.Text = "";



            }
            con.Close();
        }
    }
}