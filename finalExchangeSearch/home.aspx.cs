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
    public partial class home : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlDataReader dataReader;
        Panel panel;
        Panel btnpanel;
        Label name;
        Image Image;
        Label info;
        Label price;
        Button button;
        Button edite;
        protected void Page_Load(object sender, EventArgs e)
        {
            load("select * from item ");
            if (!Page.IsPostBack)
            {
                dropdowanlists();
            }
        }
        // 
        /////////////////////////------------\\\\\\\\\\\\\\\
        private void dropdowanlists()
        {
            namedrop.Items.Clear();
            namedrop.Items.Add("All");
            cone.connection.Close();
            cone.connection.Open();
            cmd = new SqlCommand("SELECT DISTINCT name from item ", cone.connection);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                namedrop.Items.Add(dataReader.GetString(0));
            }
            cone.connection.Close();


            /////////////////////////////--------------\\\\\\\\\\\\\\\\\\

            type.Items.Clear();
            type.Items.Add("All");
            cone.connection.Close();
            cone.connection.Open();
            cmd = new SqlCommand("SELECT DISTINCT type from item ", cone.connection);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                type.Items.Add(dataReader.GetString(0));
            }
            cone.connection.Close();
        }
        /////////////////////////------------\\\\\\\\\\\\\\\
        private void load(string query)
        {
            items.Controls.Clear();
            cone.connection.Close();
            cone.connection.Open();
            cmd = new SqlCommand(query, cone.connection);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                byte[] bytes;
                bytes = (byte[])dataReader["img"];
                panel = new Panel();
                name = new Label();
                Image = new Image();
                info = new Label();
                price = new Label();
                button = new Button();
                edite = new Button();
                btnpanel = new Panel();
                ////////////////////////////////////////
                panel.CssClass = "card p-2 m-1 cardWidth rem border-0";
                //////////////////////////////////////////
                name.CssClass = "card-title orgtDarkText";
                name.Text = dataReader.GetString(2);
                panel.Controls.Add(name);
                ///////////////////////////////////////
                Image.CssClass = "card-img-top";
                Image.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(bytes);
                panel.Controls.Add(Image);
                ///////////////////////////////////////
                info.Text = dataReader.GetString(6);
                info.CssClass = "card-text d-block";
                panel.Controls.Add(info);
                ///////////////////////////////////////
                price.CssClass = "card-title text-primary price";
                price.Text = dataReader.GetSqlMoney(3).ToString();
                panel.Controls.Add(price);
                ///////////////////////////////////////
                btnpanel.CssClass = "row justify-content-center p-1";
                panel.Controls.Add(btnpanel);
                ///////////////////////////////////////
                button.Text = "More";
                button.ID = dataReader.GetInt32(0).ToString() + "," + dataReader.GetString(1);
                button.CssClass = "cardBtnEdite btn btn-warning col-5 ";
                button.Click += (Object sender, EventArgs e) =>
                {
                    var b = (Button)sender;
                    gotoItem(b.ID);
                };
                btnpanel.Controls.Add(button);
                /////////////////////////////////////////
                items.Controls.Add(panel);

            }

            cone.connection.Close();
        }

        /////////////////////////------------\\\\\\\\\\\\\\\
        private void search(string query)
        {

            items.Controls.Clear();
            cone.connection.Close();
            cone.connection.Open();
            cmd = new SqlCommand(query, cone.connection);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                byte[] bytes;
                bytes = (byte[])dataReader["img"];
                panel = new Panel();
                name = new Label();
                Image = new Image();
                info = new Label();
                price = new Label();
                button = new Button();
                edite = new Button();
                btnpanel = new Panel();
                ////////////////////////////////////////
                panel.CssClass = "card p-2 m-1 cardWidth rem border-0";
                //////////////////////////////////////////
                name.CssClass = "card-title orgtDarkText";
                name.Text = dataReader.GetString(2);
                panel.Controls.Add(name);
                ///////////////////////////////////////
                Image.CssClass = "card-img-top";
                Image.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(bytes);
                panel.Controls.Add(Image);
                ///////////////////////////////////////
                info.Text = dataReader.GetString(6);
                info.CssClass = "card-text d-block";
                panel.Controls.Add(info);
                ///////////////////////////////////////
                price.CssClass = "card-title text-primary price";
                price.Text = dataReader.GetSqlMoney(3).ToString();
                panel.Controls.Add(price);
                ///////////////////////////////////////
                btnpanel.CssClass = "row justify-content-center p-1";
                panel.Controls.Add(btnpanel);
                ///////////////////////////////////////
                button.Text = "More";
                button.ID = dataReader.GetInt32(0).ToString() + "," + dataReader.GetString(1);
                button.CssClass = "cardBtnEdite btn btn-warning col-5 ";
                button.Click += (Object sender, EventArgs e) =>
                {
                    var b = (Button)sender;
                    gotoItem(b.ID);
                };
                btnpanel.Controls.Add(button);
                /////////////////////////////////////////
                items.Controls.Add(panel);

            }

            cone.connection.Close();
        }

        private void gotoItem(string id)
        {
            cone.gitem = id;
            Response.Redirect("gotoItem.aspx");
        }

        protected void bytype(object sender, EventArgs e)
        {
            if (type.Text == "All")
            {
                load("select * from item ");
            }
            else
            {
                search("select * from item where type='" + type.Text + "'");
            }
        }

        protected void namebtnsearch(object sender, EventArgs e)
        {
            if (namedrop.Text == "All")
            {
                load("select * from item ");
            }
            else
            {
                search("select * from item where name='" + namedrop.Text + "'");
            }
        }
    }
}