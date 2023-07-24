<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="finalExchangeSearch.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="bootstrabFile.css" rel="stylesheet" />
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
        .dauto {
            margin:auto;
        }
        .itemContent {
            margin: auto;
            width: 98%;
        }
        .rem{
            width:18rem;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container p-3">
                <asp:DropDownList CssClass="btn col-11 col-sm-6 col-md-5 m-auto d-block bg-dark text-center mt-1 text-white" ID="type" runat="server"></asp:DropDownList>
                <asp:Button ID="Button1" CssClass="btn col-11 col-sm-6 col-md-5 d-block m-auto btn orgDarkBg mt-1 text-white"  runat="server" Text="Search by type" OnClick="bytype" />
                <asp:DropDownList CssClass="btn col-11 col-sm-6 col-md-5 m-auto d-block bg-dark text-center mt-1 text-white" ID="namedrop" runat="server"></asp:DropDownList>
                <asp:Button ID="Button2" CssClass="btn col-11 col-sm-6 col-md-5 d-block m-auto btn orgDarkBg mt-1 text-white"  runat="server" Text="Search by name" OnClick="namebtnsearch" />
            </div>
            <div class="itemContent row justify-content-evenly p-2 m-1" runat="server" id="items">

            </div>
        </div>
    </form>
</body>
</html>
