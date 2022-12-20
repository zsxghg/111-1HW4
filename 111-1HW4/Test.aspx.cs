using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace _111_1HW4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection s_Conn = new SqlConnection
            (ConfigurationManager.ConnectionStrings["SQLLOCAL"].ConnectionString);
            s_Conn.Open();
            SqlDataAdapter o_A = new SqlDataAdapter("Select * from Users", s_Conn);
            DataSet o_D = new DataSet();
            o_A.Fill(o_D, "talk");
            gd_View.DataSource = o_D;
            gd_View.DataBind();
            s_Conn.Close();

        }

        protected System.Void btn_Insert_Click()
        {
            SqlConnection s_Conn = new SqlConnection
            (ConfigurationManager.ConnectionStrings["SQLLOCAL"].ConnectionString);
            s_Conn.Open();
            string s_sql = "Insert into Users (Name, Birthday)" + "values(N'阿貓阿狗', '2000/10/10');";
            SqlCommand o_cmd = new SqlCommand(s_sql, s_Conn);
            int i_flag = o_cmd.ExecuteNonQuery();
            s_Conn.Close();

        }
        
    }
}
