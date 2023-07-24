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
    public partial class account1 : System.Web.UI.Page
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
            /// ama la katy daxlbwny pagekaya agar false bw daxl nabe w agaretawa bo page peshtr  
            if (cone.login == false)
            {
                Response.Redirect("index.aspx");
            }

            /// bo henanaway tawawy datakany aw kasay ka daxl bwa
            else if (cone.login == true)
            {
                cone.connection.Close();
                cone.connection.Open();
                cmd = new SqlCommand("select * from act where username='" + cone.user + "'", cone.connection);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Label1.Text = dataReader.GetString(1);
                }
                insertItem();
                emph();
            }
        }

        /// bo henanaway zhmaray mobile w email
        private void emph()
        {
            phoneEmail.Controls.Clear();
            cone.connection.Close();
            cone.connection.Open();
            cmd = new SqlCommand("select * from phnum where acc_id='"+cone.user+"' union all select * from email where acc_id='" + cone.user + "'", cone.connection);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Label1 = new Label();
                Label1.Text = dataReader.GetString(2);
                Label1.CssClass = " text-white d-block pe";
                phoneEmail.Controls.Add(Label1);
            }
            cone.connection.Close();
        }
        //// am methoda bakardet bo srinaway itemakan
        private void deleteItem(string id)
        {
            cone.connection.Close();
            cone.connection.Open();
            cmd = new SqlCommand("delete from item where id=" + id + "", cone.connection);
            cmd.ExecuteNonQuery();
            cone.connection.Close();
            insertItem();
        }
        ////// am methoda bakardet bo bang krdnaway itemalkany kasy daxl bw
        private void insertItem()
        {
            items.Controls.Clear();
            cone.connection.Close();
            cone.connection.Open();
            cmd = new SqlCommand("select * from item where acc_id='" + cone.user + "'", cone.connection);
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
                panel.CssClass = "card p-2 m-1 cardWidth ";
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
                button.Text = "Delete";
                button.ID = dataReader.GetInt32(0).ToString();
                button.CssClass = "cardBtnEdite btn btn-warning col-5 m-1 ";
                button.Click += (Object sender, EventArgs e) =>
                {
                    var b = (Button)sender;
                    deleteItem(b.ID);
                };
                btnpanel.Controls.Add(button);
                ///////////////////////////////////////
                edite.Text = "Edite";
                edite.ID = dataReader.GetInt32(0).ToString()+"n";
                edite.CssClass = "cardBtnEdite btn btn-warning col-5 m-1 ";
                edite.Click += (Object sender, EventArgs e) =>
                {
                    var d = (Button)sender;
                    editItem(d.ID);
                };
                btnpanel.Controls.Add(edite);
                items.Controls.Add(panel);

            }
            cone.connection.Close();
        }


        /// am methodana bakarde bo chwna naw page item 
        /////////////////////////////////---------------\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void editItem(string id)
        {
            cone.item = true;
            cone.idItem = id;
            Response.Redirect("item.aspx");
        }


        ///  
        /////////////////////////////////---------------\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void insertToExchange()
        {
            int idToExchange = 0;
            cone.connection.Close();
            cone.connection.Open();
            cmd = new SqlCommand("(select max(id) from item where acc_id = '" + cone.user + "' )", cone.connection);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read()) { idToExchange = dataReader.GetInt32(0); }
            cone.connection.Close();
            if (idToExchange != 0){
                string[] array = exch.Text.Split(',');
                for (int i = 0; i < array.Length; i++)
                {
                    cone.connection.Open();
                    cmd = new SqlCommand("insert into exch_ values("+idToExchange +",'" + array[i] + "')", cone.connection);
                    cmd.ExecuteNonQuery();
                    cone.connection.Close();
                }
            }
        }
        /////////////////////////////////-------bo daxlkrdny item--------\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        protected void Button1_Click(object sender, EventArgs e)
        {
            string types = typees.SelectedValue;
            if ((FileUpload1.HasFile) && (names.Text != "") && (types != ""))  
            {
                int lenght = FileUpload1.PostedFile.ContentLength;
                byte[] pic = new byte[lenght];
                FileUpload1.PostedFile.InputStream.Read(pic, 0, lenght);
                cone.connection.Close();
                cone.connection.Open();
                cmd = new SqlCommand("insert into item values(@a,@b,@c,@d,@e,@f)", cone.connection);
                cmd.Parameters.AddWithValue("@a", cone.user);
                cmd.Parameters.AddWithValue("@b", names.Text);
                cmd.Parameters.AddWithValue("@c", prices.Text);
                cmd.Parameters.AddWithValue("@d", pic);
                cmd.Parameters.AddWithValue("@e", typees.SelectedValue);
                cmd.Parameters.AddWithValue("@f", infos.Text);
                cmd.ExecuteNonQuery();
                cone.connection.Close();
                insertItem();
                insertToExchange();
            }
            else
            {
            }
        }
    }
}