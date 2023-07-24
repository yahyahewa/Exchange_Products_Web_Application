using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace finalExchangeSearch
{
    public partial class phoneAndEmail : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlDataReader dataReader;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (cone.phEm == false)
            {
                Response.Redirect("index.aspx");
            }
        }



        /// bo daxlkrdny zhmaray mobile 
        protected void addPhone(object sender, EventArgs e)
        {
            try
            {
                if (ph.Text != "")
                {
                    cone.connection.Close();
                    cone.connection.Open();
                    cmd = new SqlCommand("insert into phnum values('" + cone.user + "','" + ph.Text + "')", cone.connection);
                    cmd.ExecuteNonQuery();
                    cone.connection.Close();
                }
            }
            catch
            {

            }
        }



        /// bo daxlkrdny email 
        protected void addemail(object sender, EventArgs e)
        {
            try
            {
                if (email.Text != "")
                {
                    cone.connection.Close();
                    cone.connection.Open();
                    cmd = new SqlCommand("insert into email values('" + cone.user + "','" + email.Text + "')", cone.connection);
                    cmd.ExecuteNonQuery();
                    cone.connection.Close();
                }
            }
            catch { }
        }

        /// bo chwna page my account 
        protected void Button2_Click(object sender, EventArgs e)
        {
            cone.login = true;
            Response.Redirect("account.aspx");
        }
    }
}