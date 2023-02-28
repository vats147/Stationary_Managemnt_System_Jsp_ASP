using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Statnoray
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["id"]==null)
            {
                if(!IsPostBack)
                    Response.Redirect("login.aspx", false);
            }
            else
            {
                Response.Write(Session["id"]);
            }
            if(!IsPostBack)
            {
                Load_data();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CG0QM8J\\SQLEXPRESS;Initial Catalog=statnory;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblproduct1(product_Name,product_Price,product_Description,product_Category)VALUES('" + TextBox1.Text + "','" + int.Parse(TextBox2.Text) + "','" + TextBox3.Text + "','" + DropDownList1.SelectedValue + "' )",con);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
            con.Close();
            Load_data();

        }
        void Load_data()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CG0QM8J\\SQLEXPRESS;Initial Catalog=statnory;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tblproduct1",con);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CG0QM8J\\SQLEXPRESS;Initial Catalog=statnory;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update tblproduct1 set product_Name='" + TextBox1.Text + "',product_Price='" + int.Parse(TextBox2.Text) + "',product_Description='" + TextBox3.Text + "',product_Category='" + DropDownList1.SelectedValue + "'where product_Id='"+TextBox4.Text+"'", con);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
            con.Close();
            Load_data();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Load_data();

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CG0QM8J\\SQLEXPRESS;Initial Catalog=statnory;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tblproduct1 where product_Id="+TextBox4.Text, con);
            con.Open();
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                TextBox1.Text = r.GetValue(1).ToString();
                TextBox2.Text = r.GetValue(2).ToString();
                TextBox3.Text = r.GetValue(3).ToString();
                DropDownList1.SelectedValue = r.GetValue(4).ToString();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CG0QM8J\\SQLEXPRESS;Initial Catalog=statnory;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from tblproduct1 where product_Id='" + TextBox4.Text + "'", con);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Data Deleted Successfully');", true);
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            DropDownList1.SelectedValue = "Pen";
            con.Close();
            Load_data();
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}