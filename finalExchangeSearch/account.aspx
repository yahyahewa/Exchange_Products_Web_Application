<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="account.aspx.cs" Inherits="finalExchangeSearch.account1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title><link href="bootstrabFile.css" rel="stylesheet" />
     <meta name="viewport" content="width=device-width, initial-scale=1" />
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
        .username {
            font-size: 35px;
        }

        .itemContent {
            margin: auto;
            width: 98%;
        }
        .cardWidth{width:18rem;}
        .cardBtnEdite{display:inline-block !important}
        .pe{
            font-size:13px;
            font-family:'Times New Roman';
        }
    </style>
</head>
<body class="">
    <form id="form1" runat="server">
        <div>
            <div class="container-fluid p-1" style="border-bottom: solid #fe6e00 1px">
            <a class="orgtDarkText font1" style="font-size:25px;text-decoration:none;" href="index.aspx">Exchange.com</a>
             </div>

              <div class="container-fluid p-2">
                 <asp:Label ID="Label1" runat="server" class="font1 text-dark d-block username" Text=""></asp:Label>
                  <div  id="phoneEmail" runat="server"></div>
    </div>
                 
    <div class="itemContent row justify-content-evenly p-2 m-1" id="items" runat="server">

         
    </div>
            
            <div class="container col-11 col-sm-8 col-md-4 p-1 bg-white px-4" style="border-radius:5px;">
                <asp:TextBox  placeholder="name" id="names" class="input-group-text text-start bg-dark text-white border-0 btn-outline-secondary col-12 m-1" runat="server"></asp:TextBox>
                <asp:TextBox id="prices" placeholder="price" class="input-group-text text-start bg-dark border-0 text-white btn-outline-secondary col-12 m-1" runat="server" TextMode="SingleLine"></asp:TextBox>
                <asp:DropDownList ID="typees" runat="server" class="input-group-text text-start bg-dark border-0 text-white btn-outline-secondary col-12 m-1 ">
                    <asp:ListItem>car</asp:ListItem>
                    <asp:ListItem>mobelat</asp:ListItem>
                    <asp:ListItem>petrol</asp:ListItem>
                    <asp:ListItem>clothes</asp:ListItem>
                    <asp:ListItem>home</asp:ListItem>
                    <asp:ListItem>maketing</asp:ListItem>
                    <asp:ListItem>other</asp:ListItem>
                    <asp:ListItem>food</asp:ListItem>
                </asp:DropDownList>
                    <asp:TextBox  placeholder="about item" id="infos" class="input-group-text text-start bg-dark text-white border-0 btn-outline-secondary col-12 m-1" runat="server" TextMode="MultiLine"></asp:TextBox>
                <label class="orgtDarkText" style="font-size:12px;">*use (,) to between words</label>
                <asp:TextBox id="exch" placeholder="exchange to " class="input-group-text text-start bg-dark border-0 text-white btn-outline-secondary col-12 m-1" runat="server" TextMode="SingleLine"></asp:TextBox>
                <label class="orgtDarkText d-block" style="font-size:20px;">choose image</label>
                <asp:FileUpload ID="FileUpload1" class="input-group-text text-start bg-dark border-0 text-white btn-outline-secondary col-12 m-1 " runat="server" />
                <asp:Button ID="Button1" class="btn btn-dark col-12 orgDarkBg border-0 m-1"  runat="server" Text="add" OnClick="Button1_Click" />
            </div>

        </div>
    </form>
</body>
</html>
