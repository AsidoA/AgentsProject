<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="AddEdit.aspx.cs" Inherits="AgentsProject.manage.AddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .FlBtn{
            position:absolute;
            z-index:50;
            opacity:0;
        }
        .Fl{
          position:relative;
         margin-left:27%
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <asp:HiddenField ID="Hiden" runat="server" />
     <div class="container">
        <div class="card o-hidden border-0 shadow-lg my-5">
            <div class="card-body p-0">
                <!-- Nested Row within Card Body -->
                <div class="row">
                    <div class="col-lg-5 d-none d-lg-block"><img src="../Uploads/Images/Reg.jpg" width="500" height="600" /></div>
                    <div class="col-lg-7">
                        <div class="p-5" style="margin-top:7%;margin-left:3%;">
                            <div class="text-center">
                                <h1 class="h4 text-gray-900 mb-4">Fill all to add assest</h1>
                            </div>
                            <form class="user">
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <asp:TextBox ID="Pname" MaxLength="50" class="form-control form-control-user" runat="server" placeholder="Assest name" />
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="Pdltype" MaxLength="10" class="form-control form-control-user" runat="server" placeholder="Rent/Sell" />
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <asp:TextBox ID="Proms" TextMode="Number" class="form-control form-control-user" runat="server" placeholder="Rooms" />
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="Pflor" TextMode="Number" class="form-control form-control-user" runat="server" placeholder="Floor" />
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <asp:TextBox ID="Paddress" MaxLength="50" class="form-control form-control-user" runat="server" placeholder="Adress" />
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="Pcity" MaxLength="10" class="form-control form-control-user" runat="server" placeholder="City" />
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <asp:TextBox ID="Psz"  TextMode="Number" class="form-control form-control-user" runat="server" placeholder="Assest Size" />
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="Ppric"  TextMode="Number" class="form-control form-control-user" runat="server" placeholder="Price" />
                                    </div>
                                </div>
                                <div class="form-group">
                                <a class="btn btn-secondary btn-icon-split Fl">
                                        <asp:FileUpload ID="Flup" class="FlBtn"  runat="server" />
                                        <span class="icon text-white-50">
                                            <i class="fas fa-arrow-right"></i>
                                        </span>
                                        <span class="text">Click To Upload Photo</span>
                                    </a>
                                    </div>
                                 <hr  />
                             <asp:Button ID="AddBtn"  runat="server" class="btn btn-primary btn-block" Text="Add Assest" OnClick="AddBtn_Click" />
                               </form>
                            <hr  />
        
                            <div class="text-center">
                                <a class="small" href=""><asp:Literal ID="commentLtl" runat="server" /></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
