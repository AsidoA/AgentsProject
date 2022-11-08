<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Notification.aspx.cs" Inherits="AgentsProject.manage.Notification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
           .delBtn{
    font-size:100%;
    background-color: transparent;
    background-repeat: no-repeat;
    border:none;
    color:#808080;
  }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
      <div class="container-fluid">

                    <!-- Page Heading -->
                    <div class="d-sm-flex align-items-center justify-content-between mb-4">
                        <h1 class="h3 mb-0 text-gray-800">Cards</h1>
                    </div>

                    <div class="row">
    <asp:Repeater ID="NotRpt" runat="server">
        <ItemTemplate>
   <div class="col-lg-6">
      <div class="card shadow mb-4">
                                <!-- Card Header - Dropdown -->
                                <div
                                     class="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                                    <h6 class="m-0 font-weight-bold text-primary"> <%#Eval("Pname") %> <%#Eval("Alert") %>  </h6>
                                    <div class="dropdown no-arrow">
                                        <a class="dropdown-toggle" href="#" role="button" id="dropdownMenuLink"
                                            data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                            <i class="fas fa-ellipsis-v fa-sm fa-fw text-gray-400"></i>
                                        </a>
                                        <div class="dropdown-menu dropdown-menu-right shadow animated--fade-in"
                                            aria-labelledby="dropdownMenuLink">
                                            <div class="dropdown-header">Dropdown Header:</div>
                
                                                <asp:Button ID="DelBtn" class="dropdown-item" runat="server" Text="Delete" CssClass="delBtn"  CommandArgument='<%#Eval("AlertID") %>' OnClick="DelBtn_Click" />
                     
                                        </div>
                                    </div>
                                </div>
                                <!-- Card Body -->
                                <div class="card-body">
                                    Youre Assest <%#Eval("Pname") %> Has been <%#Eval("Alert") %> By <%#Eval("fullName") %>
                                </div>
                            </div>
       </div>
            
        </ItemTemplate>
    </asp:Repeater>
                        </div>
          </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
