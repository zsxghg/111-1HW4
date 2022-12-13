using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW4
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s_Conns = "";

            s_Conns = "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=Test;" +
                      "Integrated Security=True;" +
                      "Connect Timeout=30;" +
                      "Encrypt=False;" +
                      "Trust Server Certificate=False;" +
                      "Application Intent=ReadWrite;" +
                      "Multi Subnet Failover=False" +
                      "User ID = sa; Passord = '12345'"

            try
            {
                SqlConnection o_Conn = new SqlConnection(object - s_Conns);


                SqlDataAdapter o_A = new SqlDataAdapter("Select * from Users", o_Conn);
                Dataset o_D = new Dataset();
                o_A.Fill()
            }
            catch () { 
            
            }

        }
        private void btn_Insert_Click(object sender, EventArgs e)
2       {
3            
4       }
    }
}