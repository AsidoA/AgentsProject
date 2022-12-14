<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="AgentsProject.LoginPage" %>
<%@ Register Src="~/UC-Register.ascx" TagPrefix="UC" TagName="Register" %>
 <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style> 
   .RegBtn{
    font-size:80%;
    background-color: transparent;
    background-repeat: no-repeat;
    border:none;
    color:#4c7ce7;
  }
   .RegBtn:hover{
    font-size:80%;
    background-color: transparent;
    background-repeat: no-repeat;
    border:none;
    color:#3b67c8;
    text-decoration:underline;
  }
    </style>
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    <title>Assests Manager Login</title>

    <!-- Custom fonts for this template-->
    <link href="manage/vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css"/>
    <link
        href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"
        rel="stylesheet"/>

    <!-- Custom styles for this template-->
    <link href="manage/css/sb-admin-2.min.css" rel="stylesheet"/>
</head>
<body style="background-color:rgb(213 213 213);">
    <form id="form1" runat="server">
        <div>
            <UC:Register ID="RegIn" runat="server" Visible="false" />

                <div  id="UcContainer" runat="server" class="container" style="margin-top:5%;" visible="true ">

        <!-- Outer Row -->
        <div class="row justify-content-center" runat="server">

            <div class="col-xl-10 col-lg-12 col-md-9">

                <div class="card o-hidden border-0 shadow-lg my-5">
                    <div class="card-body p-0">
                        <!-- Nested Row within Card Body -->
                        <div class="row">
                            <div class="col-lg-6 d-none d-lg-block"><img src="Uploads/Images/bg login.png" height="auto" /></div>
                            <div class="col-lg-6">
                                <div class="p-5">
                                    <div class="text-center">
                                        <h1 class="h4 text-gray-900 mb-4">Welcome Back!</h1>
                                    </div>
                                    <form class="user">
                                        <div class="form-group">
                                            <asp:TextBox ID="logEmail" runat="server"  class="form-control form-control-user" placeholder="Email Adress" />
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox ID="logPass" TextMode="Password" runat="server"  class="form-control form-control-user" placeholder="Personal Password" />
                                        </div>
                                        <div class="form-group">
                                            <div class="custom-control custom-checkbox small">
                                                <input type="checkbox" class="custom-control-input" id="customCheck"/>
                                                <label class="custom-control-label" for="customCheck">Remember
                                                    Me</label>
                                            </div>
                                        </div>
                                        <asp:Button ID="LogBtn" runat="server" class="btn btn-primary btn-user btn-block" Text="Login" OnClick="LogBtn_Click"  />
                                         <div class="text-center">
                                        <a class="small" href=""><asp:Literal ID="RspLtl" runat="server" /></a>
                                    </div>
                                    </form>
                                    <hr/>

                                    <div class="text-center">
                                        <a class="small" href="">Forgot Password?</a>
                                    </div>
                                    <div class="text-center">
                                        <asp:Button ID="RegDirect" runat="server" class="small" Text="Create An Account" CssClass="RegBtn" OnClick="RegDirect_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
        </div>
    </form>
     <!-- Bootstrap core JavaScript-->
    <script src="manage/vendor/jquery/jquery.min.js"></script>
    <script src="manage/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Core plugin JavaScript-->
    <script src="manage/vendor/jquery-easing/jquery.easing.min.js"></script>

    <!-- Custom scripts for all pages-->
    <script src="manage/js/sb-admin-2.min.js"></script>

</body>
</html>
