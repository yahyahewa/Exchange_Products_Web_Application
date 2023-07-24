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
    public partial class gotoItem : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlDataReader dataReader;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) { load(); }
        }
        //am methoda bakarde bo henanaway itemakan
        // w zhmaray mobile w email
        private void load()
        {
            try
            {
                string[] array = cone.gitem.Split(',');
                cone.connection.Close();
                cone.connection.Open();
                cmd = new SqlCommand("select * from item where id=" + array[0] + "", cone.connection);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    nameLabel.Text = dataReader.GetString(2);
                    price.Text = dataReader.GetSqlMoney(3).ToString();
                    infoLabel.Text = dataReader.GetString(6);
                    infoLabel.CssClass = "text-white";
                    byte[] bytes;
                    bytes = (byte[])dataReader["img"];
                    Image1.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(bytes);
                }

                //////////////////////////////////////---------\\\\\\\\\\\\\\\\\\\\\\\\
                cone.connection.Close();
                cone.connection.Open();
                cmd = new SqlCommand("select * from phnum where acc_id='" + array[1] + "' union all select * from email where acc_id='" + array[1] + "'", cone.connection);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Label labelPhemail = new Label();
                    labelPhemail.Text = dataReader.GetString(2);
                    labelPhemail.CssClass = "d-block text-darck  text-primary";
                    allInfo.Controls.Add(labelPhemail);
                }
                //////////////////////////////////////---------\\\\\\\\\\\\\\\\\\\\\\\\
                cone.connection.Close();
                cone.connection.Open();
                cmd = new SqlCommand("select adr from act where username='" + array[1] + "'", cone.connection);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    adr.Text = dataReader.GetString(0);
                }
                cone.connection.Close();
                //////////////////////////////////////---------\\\\\\\\\\\\\\\\\\\\\\\\
                cone.connection.Open();
                cmd = new SqlCommand("select ex_to from exch_ where id_item="+array[0]+"", cone.connection);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Label exlabel = new Label();
                    exlabel.Text = dataReader.GetString(0);
                    exlabel.CssClass = "d-block text-darck btn  col-auto d-inline-block m-2 p-2 text-white orgDarkBg";
                    exDiv.Controls.Add(exlabel);
                }
                cone.connection.Close();
            }
            catch
            {

            }
        }
    }
}