<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="PropertiesList.aspx.cs" Inherits="AgentsProject.manage.PropertiesList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .DltBtn{
            position:absolute;
            z-index:50;
            opacity:0;
        }
       .dlBtn{
           margin-left:30%;
       }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div class="row">
  <!-- Earnings (Monthly) Card Example -->
                        <div class="col-xl-3 col-md-6 mb-4" style="margin-left:2%">
                            <div class="card border-left-primary shadow h-100 py-2">
                                <div class="card-body">
                                    <div class="row no-gutters align-items-center">
                                        <div class="col mr-2">
                                            <div class="text-xs font-weight-bold text-primary text-uppercase mb-1">
                                               Assests</div>
                                            <div class="h5 mb-0 font-weight-bold text-gray-800"><asp:Literal ID="AssLtl" runat="server" /></div>
                                        </div>
                                        <div class="col-auto">
                                            <i class="fas fa-calendar fa-2x text-gray-300"></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Earnings (Annual) Card Example -->
                        <div class="col-xl-3 col-md-6 mb-4" style="margin-left:2%">
                            <div class="card border-left-success shadow h-100 py-2">
                                <div class="card-body">
                                    <div class="row no-gutters align-items-center">
                                        <div class="col mr-2">
                                            <div class="text-xs font-weight-bold text-success text-uppercase mb-1">
                                                Future Earnings</div>
                                            <div class="h5 mb-0 font-weight-bold text-gray-800">$<asp:Literal ID="ErnLtl" runat="server" /></div>
                                        </div>
                                        <div class="col-auto">
                                            <i class="fas fa-dollar-sign fa-2x text-gray-300"></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

        </div>
     <div class="container-fluid" >
                    <!-- Page Heading -->
                    <h1 class="h3 mb-2 text-gray-800">Youre Assests</h1>
                    <!-- DataTales Example -->
                    <div class="card shadow mb-4">
                        <div class="card-header py-3" >
                            <h6 class="m-0 font-weight-bold text-primary">Click The Name Of Assest To Edit</h6>
                            <h6 class="m-0 font-weight-bold text-primary">If you edit deleted record she will be undeleted</h6>
                        </div>
                        <div class="card-body">
                            <div class="table-responsive">
                                <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                                    <thead>
                                        <tr>
                                            <th>Delete</th>
                                            <th>Assest Name</th>
                                            <th>Assest Rooms</th>
                                            <th>Assest Floor</th>
                                            <th>Assest Adress</th>
                                            <th>Assest City</th>
                                            <th>Assest Size</th>
                                            <th>Deal Type</th>
                                            <th>Assest Price</th>
                                            <th>Assest Image</th>
                                        </tr>
                                    </thead>
                                    <tfoot>
                                        <tr>
                                            <th>Delete</th>
                                            <th>Assest Name</th>
                                            <th>Assest Rooms</th>
                                            <th>Assest Floor</th>
                                            <th>Assest Adress</th>
                                            <th>Assest City</th>
                                            <th>Assest Size</th>
                                            <th>Deal Type</th>
                                            <th>Assest Price</th>
                                            <th>Assest Image</th>
                                        </tr>
                                    </tfoot>
                                    <tbody>
                                        <asp:Repeater ID="AssestRpt" runat="server">
                                            <ItemTemplate>
                                        <tr>
                                            <td><p ID="aBtn" runat="server" Visible="true"><a href="" class="btn btn-danger btn-circle btn-sm dlBtn">
                                                <%#Eval("Deleted") %>
                                                      <asp:Button ID="DltBtn" CssClass="DltBtn" runat="server" OnClick="DltBtn_Click" CommandArgument='<%#Eval("Pid") %>'/>
                                                           <i class="fas fa-trash"></i></a></p><p ID="pereDel" runat="server"><%#Eval("Deleted") %></p> </td>
                                           <td><a href="AddEdit.aspx?Pid=<%#Eval("Pid") %>"><%#Eval ("Pname") %></a></td>
                                            <td><%#Eval ("Prooms") %></td>
                                            <td><%#Eval ("Pfloor") %></td>
                                            <td><%#Eval ("Padress") %></td>
                                            <td><%#Eval ("Pcity") %></td>
                                            <td><%#Eval ("Psize") %>m2</td>
                                            <td><%#Eval ("Pdeal_type") %></td>
                                            <td><%#Eval ("Pprice") %>$</td>
                                            <td><img src="../Uploads/Images/<%#Eval("Pimage") %>" width="70" /></td>
                                        </tr>
                                                </ItemTemplate>
                                        </asp:Repeater>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>

                </div>
                <!-- /.container-fluid -->

            <!-- End of Main Content -->
            <!-- End of Footer -->

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
                <!-- Page level plugins -->
    <script src="vendor/datatables/jquery.dataTables.min.js"></script>
    <script src="vendor/datatables/dataTables.bootstrap4.min.js"></script>

    <!-- Page level custom scripts -->
    <script src="js/demo/datatables-demo.js"></script>

</asp:Content>
