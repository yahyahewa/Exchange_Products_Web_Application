<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="finalExchangeSearch.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta name="viewport" content="width=device-width, initial-scale=1" />
     <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Lora&family=Mukta:wght@300&display=swap" rel="stylesheet" />
    <link href="bootstrabFile.css" rel="stylesheet" />
    <link href="myclass.css" rel="stylesheet" />
    <script src="jquery.js"></script>
    <style>
        body {
            font-family: 'Mukta', sans-serif;
            background-image: url(img/this.jpg);
            background-attachment: fixed;
            background-position: center center;
            background-repeat: no-repeat;
            background-size: cover;
        }

        .exCont {
            height: 100vh;
            padding-top: 45vh;
            font-family: 'Lora', serif;
        }
    </style>
   
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <div class="container display-1 text-center text-capitalize exCont orgtDarkText">exchange
    <label style="display:block;font-size:12px;" class="text-white">to exchange and sale any thing</label>

    </div>
    <div class="container-fluid p-1 row justify-content-center">
        <!--aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa-->
        <div class="col-11 col-sm-8 col-md-4 p-1">
            <input type="button" value="login slide" class="text-capitalize text-center orgDarkBg border-0 col-12 btn btn-dark" id="loginButton" />
            <div class="col-12 p-1" id="loginBox">
                <asp:TextBox  placeholder="username" id="user" class="input-group-text text-start bg-dark text-white border-0 btn-outline-secondary col-12 m-1" runat="server"></asp:TextBox>
                <asp:TextBox id="inputPass1" placeholder="password" class="input-group-text text-start bg-dark border-0 text-white btn-outline-secondary col-12 m-1" runat="server" TextMode="Password"></asp:TextBox>
                <input type="checkbox" id="check1" class="form-check-input col-12 m-1" /><label class="form-check-label orgtDarkText">show passwaord</label>
                <asp:Button id="loginBtn" class="btn btn-dark col-12 orgDarkBg border-0 m-1" runat="server" Text="Login" OnClick="loginBtn_Click" />
            </div>
        </div>
        <!--aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa-->
        <div class="col-11 col-sm-8 col-md-4 p-1">
            <input type="button" value="signup slide" class="text-capitalize text-center orgDarkBg col-12 btn btn-dark border-0" id="signButton" />
         
                <div class="col-12 p-1 rounded " id="signBox">
                    <asp:TextBox  placeholder="username" class="input-group-text text-start bg-dark text-white border-0 btn-outline-secondary col-12 m-1" runat="server" ID="cusername"></asp:TextBox>
                    <label class="alert-danger col-12 m-1 p-1 text-capitalize rounded d-none d-block">required</label>
                    <asp:TextBox  id="inputPass2" placeholder="password" class="input-group-text text-start bg-dark border-0 text-white btn-outline-secondary col-12 m-1" runat="server" TextMode="Password"></asp:TextBox>
                    <label class="alert-danger col-12 m-1 p-1 text-capitalize rounded d-none">required</label>
                    <input type="checkbox" id="check2" class="form-check-input col-12 m-1" /><label class="form-check-label orgtDarkText">show passwaord</label>
                    <asp:TextBox  placeholder="name" class="input-group-text text-start bg-dark text-white border-0 btn-outline-secondary col-12 m-1" runat="server" ID="name"></asp:TextBox>
                    <label class="alert-danger col-12 m-1 p-1 text-capitalize rounded d-none">required</label>
                    <asp:TextBox  placeholder="address" class="input-group-text text-start bg-dark text-white border-0 btn-outline-secondary col-12 m-1" runat="server" ID="adr"></asp:TextBox>
                    <label class="alert-danger col-12 m-1 p-1 text-capitalize rounded d-none">required</label>
                    <asp:Button ID="signup" class="btn btn-dark col-12 orgDarkBg border-0 m-1" runat="server" Text="Next" OnClick="crete_Click" />
                </div>
            <script>
                        var inpass1 = document.getElementById("inputPass1");
                        var inpass2 = document.getElementById("inputPass2");
                        var checkBox1 = document.getElementById("check1");
                var checkBox2 = document.getElementById("check2");
                var user = document.getElementById("user").innerHTML;
                        $(document).ready(function () {
                    $("#loginBox,#signBox").slideUp();
                    $("#loginButton").click(function () { $("#loginBox").slideToggle(); })
                    $("#signButton").click(function () { $("#signBox").slideToggle(); })
                    $("#check1").click(function () {
                        if (checkBox1.checked == false) { inpass1.type = "password";  }
                        else if (checkBox1.checked == true) { inpass1.type = "text"; }
                    });
                            $("#check2").click(function () {
                                if (checkBox2.checked == false) { inpass2.type = "password"; }
                                else if (checkBox2.checked == true) { inpass2.type = "text"; }
                            });

                            $("#loginBtn").click(function () {
                                if (($("#user").val() != "") && ($("#inputPass1").val() != "")) {
                                    window.location.href = "account.html";
                                }
                                else {
                                    alert("please enter your username and password");
                                }
                                    });
                });
            </script>
        </div>
    </div>
            <div class="p-5"><a href="home.aspx" class="d-block orgtDarkText text-center display-3">Home</a></div>
    <div class="p-2 text-center text-white mt-5 mb-0 container-fluid bg-dark">Copyright 2021 www.exchange.com</div>
        </div>
    </form>
</body>
</html>
