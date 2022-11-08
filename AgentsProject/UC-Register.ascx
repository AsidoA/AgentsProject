<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UC-Register.ascx.cs" Inherits="AgentsProject.UC_Register" %>
  <div class="container">
        <div class="card o-hidden border-0 shadow-lg my-5">
            <div class="card-body p-0">
                <!-- Nested Row within Card Body -->
                <div class="row">
                    <div class="col-lg-5 d-none d-lg-block"><img src="Uploads/Images/View.jpg" width="500" height="600" /></div>
                    <div class="col-lg-7">
                        <div class="p-5" style="margin-top:7%;margin-left:3%;">
                            <div class="text-center">
                                <h1 class="h4 text-gray-900 mb-4">Create an Account!</h1>
                            </div>
                            <form class="user">
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <asp:TextBox ID="Fname" MaxLength="20" class="form-control form-control-user" runat="server" placeholder="First Name" />
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="Lname" MaxLength="20" class="form-control form-control-user" runat="server" placeholder="Last Name" />
                                    </div>
                                </div>
                                <div class="form-group">
                                        <asp:TextBox ID="Adress" MaxLength="30" class="form-control form-control-user" runat="server" placeholder="Adress" />
                                </div>
                                <div class="form-group">
                                          <asp:TextBox ID="Email" MaxLength="50" class="form-control form-control-user" runat="server" placeholder="Email" />
                                </div>
                                <div class="form-group">
                                        <asp:TextBox ID="Password" MaxLength="20" class="form-control form-control-user" runat="server" TextMode="Password" placeholder="Password" />
                                </div>
                             <asp:Button ID="chkBtn" runat="server" class="btn btn-primary btn-block" Text="Register Account" OnClick="chkBtn_Click" />
                               </form>

                            <div class="text-center">
                                <a class="small" href="a.html"><asp:Literal ID="Ltl" runat="server" /></a>
                            </div>

                            <hr  />
                            <div class="text-center">
                                <a class="small" href="forgot-password.html">About Us</a>
                            </div>
                            <div class="text-center">
                                <a class="small" href="LoginPage.aspx">Already have an account? Login!</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>