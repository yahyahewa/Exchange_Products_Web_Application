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
    public partial class index : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlDataReader dataReader;
        protected void Page_Load(object sender, EventArgs e)
        {
            cone.login = false;
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            /// bo loginkrdn bo nawk accountaka rastawxo ka tanha username w passowrd daxl akain
            try
            {
                int act = 0;
                cone.connection.Close();
                cone.connection.Open();
                cmd = new SqlCommand("select count(username) from act where username='" + user.Text + "' and pass='" + inputPass1.Text + "' ", cone.connection);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    act = dataReader.GetInt32(0);
                }
                if (act == 1)
                {
                    cone.login = true;
                    cone.user = user.Text;
                    Response.Redirect("account.aspx");
                }
                cone.connection.Close();
            }
            catch 
            {

            }
            }

        protected void signup_Click(object sender, EventArgs e)
        {
            if (cusername.Text != "" && name.Text != "" && inputPass2.Text != "" && adr.Text != "")
            {
                cone.connection.Close();
                cone.connection.Open();
                cmd = new SqlCommand("insert into act values('" + cusername.Text + "','" + name.Text + "','" + inputPass2.Text + "',getdate(),'" + adr.Text + "')", cone.connection);
                cmd.ExecuteNonQuery();
                cone.connection.Close();
            }
        }

        protected void crete_Click(object sender, EventArgs e)
        {
            /// bo drustkrdny account tanha username , password ,name ,adras daxl akain
            if (cusername.Text != "" && inputPass2.Text != "" && name.Text != "" && adr.Text != "")
            {
                cone.connection.Close();
                cone.connection.Open();
                cmd = new SqlCommand("insert into act values('" + cusername.Text + "','" + name.Text + "','" + inputPass2.Text + "',getdate(),'" + adr.Text + "') ", cone.connection);
                cmd.ExecuteNonQuery();
                cone.user = cusername.Text;
                cone.phEm = true;
                cone.connection.Close();
                Response.Redirect("phoneAndEmail.aspx");
            }
        }
    }
}