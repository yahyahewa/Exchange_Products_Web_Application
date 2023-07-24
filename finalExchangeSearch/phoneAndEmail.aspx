<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="phoneAndEmail.aspx.cs" Inherits="finalExchangeSearch.phoneAndEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <meta name="viewport" content="width=device-width, initial-scale=1" />
     <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Lora&family=Mukta:wght@300&display=swap" rel="stylesheet" />
    <link href="bootstrabFile.css" rel="stylesheet" />
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
    <script src="jquery.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
            <h1 class="text-center orgtDarkText text-center display-1 mt-5">Exchange.com</h1>
            <label class="text-center text-dark d-block" style="font-size:12px; font-family:'Times New Roman', Times, serif">for develop your business</label>
            </div>
            <div class="container col-6 col-sm-10 col-md-7 mt-5">
                    <asp:TextBox  placeholder="add new phone number" class="btn text-start bg-dark text-white border-0 btn-outline-secondary col-12 m-1" runat="server" ID="ph"></asp:TextBox>
                <asp:Button ID="Button1" CssClass="btn col-11 p-1 text-white orgDarkBg d-block m-auto mt-2" runat="server" Text="Add" OnClick="addPhone" />
                    <asp:TextBox  placeholder="add new phone email" class="btn text-start bg-dark text-white border-0 btn-outline-secondary col-12 m-1" runat="server" ID="email"></asp:TextBox>
                <asp:Button ID="emailbtn" CssClass="btn col-11 p-1 text-white orgDarkBg d-block m-auto mt-2" runat="server" Text="Add" OnClick="addemail" />
            </div>
            <div class="container col-6 col-sm-10 col-md-7 mt-5">
                <asp:Button ID="Button2" runat="server" class="btn btn-warning text-white border-0 btn-outline-secondary col-12 m-1"  Text="Skip" OnClick="Button2_Click" />
            </div>
        </div>
    </form>
</body>
</html>
