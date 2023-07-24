<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gotoItem.aspx.cs" Inherits="finalExchangeSearch.gotoItem" %>

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
        }</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="row justify-content-center pt-5 col-12">
                 <div class="card p-2 m-1 border-0 col-11 col-sm-7 col-md-5">
            <asp:Label class="card-title orgtDarkText d-block" runat="server" id="nameLabel"></asp:Label>
            <asp:Image ID="Image1" runat="server"  class="card-img-top" />
            <asp:Label class="card-title text-primary price d-block" id="price" runat="server"></asp:Label>
            <div class="card-body">
            </div>
            </div>
                <div class="col-11 col-sm-4 col-md-5 pt-5" runat="server" id="allInfo">
                <asp:Label class="card-text text-white d-block" runat="server" id="Label1">about item:</asp:Label>
                <asp:Label class="card-text d-block" runat="server" id="infoLabel"></asp:Label>
                    <br />
                    <br />
                <asp:Label class="card-text text-white d-block" runat="server" id="acds">address:</asp:Label>
                <asp:Label class="card-text d-block" runat="server" id="adr"></asp:Label>
                    <br />
                    <br />
                </div>
            </div>
            <p class="display-5 text-center orgtDarkText d-block mt-5 mb-4">Exchange with:</p>
            <div runat="server" id="exDiv" class="p-2 container row justify-content-center m-auto" >

            </div>
        </div>
    </form>
</body>
</html>
