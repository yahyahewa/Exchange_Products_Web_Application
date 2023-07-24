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
    public partial class item : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlDataReader dataReader;
        Panel exPanel;
        Panel btnPanel;
        TextBox exTextbox;
        Button delete;
        Button updateBtn;
        string[] array = cone.idItem.Split('n');
        protected void Page_Load(object sender, EventArgs e)
        {
            if (cone.item == false) { Response.Redirect("index.aspx");
            }
            load();
            addExchange();
        }

        // am methoda bakarde bangkrdnayway itemaka la page item
        private void load()
        {
            try
            {
                cone.connection.Close();
                cone.connection.Open();
                cmd = new SqlCommand("select * from item where id='" + array[0] + "'", cone.connection);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    nameLabel.Text = dataReader.GetString(2);
                    price.Text = dataReader.GetSqlMoney(3).ToString();
                    infoLabel.Text = dataReader.GetString(6);
                    byte[] bytes;
                    bytes = (byte[])dataReader["img"];
                    Image1.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(bytes);
                }
                cone.connection.Close();
            }
            catch
            {

            }
        }

        //bakarde bo zyadkrdny aw kalayanay bo ka amanawe bigorinawa
        /// ///////////////////////------------------\\\\\\\\\\\\\\\\\\\\\\\\\
        private void addExchange()
        {
            foreach (Control c in editePanel.Controls)
            {
                if (c.ID == "exTextId") { c.Controls.Clear(); }
            }
            exPanel = new Panel();
            exPanel.CssClass = "scroll";
            exPanel.ID = "exTextId";
            cone.connection.Close();
            cone.connection.Open();
            cmd = new SqlCommand("select * from exch_ where id_item=" + array[0] + "", cone.connection);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                /// ///////////////////////------------------\\\\\\\\\\\\\\\\\\\\\\\\\
                exTextbox = new TextBox();
                exTextbox.Text = dataReader.GetString(2);
                exTextbox.ID = dataReader.GetInt32(0).ToString() + "text";
                exTextbox.CssClass = "input-group-text text-start bg-dark text-white border-0 btn-outline-secondary col-12 m-1";
                exPanel.Controls.Add(exTextbox);
                /// ///////////////////////------------------\\\\\\\\\\\\\\\\\\\\\\\\\
                btnPanel = new Panel();
                btnPanel.CssClass = "row justify-content-center p-1";
                exPanel.Controls.Add(btnPanel);
                /// ///////////////////////------------------\\\\\\\\\\\\\\\\\\\\\\\\\
                delete = new Button();
                delete.Text = "Delete";
                delete.ID = dataReader.GetInt32(0).ToString() + "d";
                delete.CssClass = "cardBtnEdite btn btn-warning col-5 m-1";
                delete.Click += (Object sender, EventArgs e) =>
                {
                    var b = (Button)sender;
                    string[] id = b.ID.Split('d');
                    deleteMethod(id[0]);
                };
                btnPanel.Controls.Add(delete);
                /// ///////////////////////------------------\\\\\\\\\\\\\\\\\\\\\\\\\
                updateBtn = new Button();
                updateBtn.Text = "Update";
                updateBtn.ID = dataReader.GetInt32(0).ToString();
                updateBtn.CssClass = "cardBtnEdite btn btn-warning col-5 m-1";
                updateBtn.Click += (Object sender, EventArgs e) =>
                {
                    var b = (Button)sender;
                    updateMethod(b.ID);
                };
                btnPanel.Controls.Add(updateBtn);
                /// ///////////////////////------------------\\\\\\\\\\\\\\\\\\\\\\\\\
                exPanel.CssClass = "col-11 col-sm-5 col-md-5 p-2 bg-white px-4";
                editePanel.Controls.Add(exPanel);
            }
            cone.connection.Close();
        }
        // bakarde bo srinaway itemakan
        /// ///////////////////////------------------\\\\\\\\\\\\\\\\\\\\\\\\\
        private void deleteMethod(string id)
        {
            cone.connection.Close();
            cone.connection.Open();
            cmd = new SqlCommand("delete from exch_ where id=" + id + "", cone.connection);
            cmd.ExecuteNonQuery();
            cone.connection.Close();
            addExchange();
        }
        //bakarde bo update krdnaway zanyaryakan
        /// ///////////////////////------------------\\\\\\\\\\\\\\\\\\\\\\\\\
        private void updateMethod(string id)
        {
            foreach (var c in editePanel.Controls.OfType<TextBox>())
            {
                    if (c.ID == (id + "text"))
                    {
                        cone.connection.Close();
                        cone.connection.Open();
                        cmd = new SqlCommand("update exch_ set ex_to='" + c.Text + "' where id=" + id + "", cone.connection);
                        cmd.ExecuteNonQuery();
                        cone.connection.Close();
                    addExchange();
                    }
            }
        }
        /// ///////////////////////------------------\\\\\\\\\\\\\\\\\\\\\\\\\
        private void update(string query)
        {
            try
            {
                cone.connection.Close();
                cone.connection.Open();
                cmd = new SqlCommand(query, cone.connection);
                cmd.ExecuteNonQuery();
                cone.connection.Close();
                load();
            }
            catch
            {

            }
        }
        /// ///////////////////////------------------\\\\\\\\\\\\\\\\\\\\\\\\\
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                update("update item set name='" + name.Text + "' where id=" + array[0] + "");
            }
            catch
            {

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                update("update item set info='" + TextBox1.Text + "' where id=" + array[0] + "");
            }
            catch
            {

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                update("update item set price=" + TextBox2.Text + " where id=" + array[0] + "");
            }
            catch
            {

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            cone.connection.Close();
            cone.connection.Open();
            cmd = new SqlCommand("insert into exch_ values(" + array[0] + ",'" + TextBox3.Text + "')", cone.connection);
            cmd.ExecuteNonQuery();
            cone.connection.Close();
            addExchange();
        }

        protected void update_Click(object sender, EventArgs e)
        {
            try
            {
                update("update item set price=" + TextBox2.Text + " where id=" + array[0] + "");
            }
            catch
            {

            }
        }
    }
}