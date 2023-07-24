<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="item.aspx.cs" Inherits="finalExchangeSearch.item" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title></title><link href="bootstrabFile.css" rel="stylesheet" />
    <script src="jquery.js"></script>
    <link href="myclass.css" rel="stylesheet" />
    <style>
        body {
            font-family: 'Mukta', sans-serif;
            background-image: url(img/this.jpg);
            background-attachment: fixed;
            background-position: center center;
            background-repeat: no-repeat;
            background-size: cover;
        }
        .haiight {
            height:40px !important;
            margin-top:5px !important;
        }
        #exTextId{
            height:300px !important;
            overflow:auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container-fluid p-1" style="border-bottom: solid #fe6e00 1px">
            <a class="orgtDarkText font1" style="font-size:25px;text-decoration:none;" href="account.aspx">My account</a>
             </div>
             <div class="itemContent row justify-content-evenly p-2 m-1">

        <div class="card p-2 m-1 border-0" style="width: 18rem;">
            <asp:Label class="card-title orgtDarkText" runat="server" id="nameLabel"></asp:Label>
            <asp:Image ID="Image1" runat="server"  class="card-img-top" />
            <div class="card-body">
                <asp:Label class="card-text" runat="server" id="infoLabel"></asp:Label>
            </div>
            <asp:Label class="card-title text-primary price" id="price" runat="server"></asp:Label>
            </div>
        </div>
            <div id="editePanel" runat="server" class="container-fluid row justify-content-center">
            <div class=" row col-11 col-sm-5 col-md-5 p-2 bg-white px-4" style="border-radius:5px; height:400px !important;">
                <div class="row justify-content-center p-1">
                <asp:TextBox  placeholder="update name" id="name" class=" haiight input-group-text text-start bg-dark text-white border-0 btn-outline-secondary col-12 m-1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" class="cardBtnEdite btn btn-warning col-11 haiight "  runat="server" Text="Update" OnClick="Button1_Click" />
            </div>
                <div class="row justify-content-center p-1">
                <asp:TextBox  placeholder="update information" id="TextBox1" class="haiight input-group-text text-start bg-dark text-white border-0 btn-outline-secondary col-12 m-1" runat="server" TextMode="MultiLine"></asp:TextBox>
                <asp:Button ID="Button2"  class="cardBtnEdite btn btn-warning col-11 haiight "  runat="server" Text="Update" OnClick="Button2_Click" />
            </div>
                <div class="row justify-content-center p-1">
                <asp:TextBox  placeholder="update price" id="TextBox2" class="haiight input-group-text text-start bg-dark text-white border-0 btn-outline-secondary col-12 m-1" runat="server"></asp:TextBox>
                <asp:Button ID="Button3"  class="cardBtnEdite btn btn-warning col-11 haiight"  runat="server" Text="Update" OnClick="update_Click" />
            </div>
                <div class="row justify-content-center p-1">
                <asp:TextBox  placeholder="new exchnage" id="TextBox3" class="haiight input-group-text text-start bg-dark text-white border-0 btn-outline-secondary col-12 m-1" runat="server"></asp:TextBox>
                <asp:Button ID="Button4"  class="cardBtnEdite btn btn-warning col-11 haiight"  runat="server" Text="Add" OnClick="Button4_Click" />
            </div>
            </div>
                <div></div>
                </div>
            </div>
    </form>
</body>
</html>
