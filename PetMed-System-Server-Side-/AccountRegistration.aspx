<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountRegistration.aspx.cs" Inherits="PetMed_System_Server_Side_.AccountRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <link href="styles.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/bootstrap.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section class="vh-100 bg-dark d-flex justify-content-center align-items-center overflow-scroll">
            <div class="container py-5">
                <div class="row d-flex justify-content-center align-items-center h-100">
                    <div class="col">
                        <div class="card card-registration border-0 h-100">
                            <div class="row g-0">
                                <div class="col-xl-6 d-none d-xl-block">
                                    <img src="./Images/seth-dog.jpg"
                                        alt="Sample photo" class="img-fluid h-100"
                                        style="border-top-left-radius: .25rem; border-bottom-left-radius: .25rem;" />
                                </div>
                                <div class="col-xl-6">
                                    <div class="card-body p-md-5 text-black">
                                        <h3 class="mb-3 text-uppercase">Account Registration</h3>

                                        <div class="form-outline mb-4">
                                            <input type="text" id="txtName" class="form-control form-control-lg" runat="server" />
                                            <label class="form-label" for="txtName">Name</label>
                                        </div>

                                        <div class="form-outline mb-4">
                                            <input type="text" id="txtAddress" class="form-control form-control-lg" runat="server" />
                                            <label class="form-label" for="txtAddress">Address</label>
                                        </div>

                                        <div class="row">
                                            <div class="col-md-6 mb-2">
                                                <div class="form-outline mb-4">
                                                    <input type="email" id="txtEmail" class="form-control form-control-lg" runat="server" />
                                                    <label class="form-label" for="txtEmail">Email</label>
                                                </div>
                                            </div>
                                            <div class="col-md-6 mb-2">
                                                <div class="form-outline mb-4">
                                                    <input type="text" id="txtPhoneNumber" class="form-control form-control-lg" runat="server" />
                                                    <label class="form-label" for="txtPhoneNumber">Phone</label>
                                                </div>
                                            </div>
                                        </div>

                                        <div class="row">
                                            <div class="col-md-6 mb-3">
                                                <div class="form-outline mb-4">
                                                    <input type="password" id="txtPassword" class="form-control form-control-lg" runat="server" />
                                                    <label class="form-label" for="form3Example97">Password</label>
                                                </div>
                                            </div>

                                            <div class="col-md-6 mb-3">
                                                <div class="form-outline mb-4">
                                                    <input type="password" id="txtConfirmPassword" class="form-control form-control-lg" runat="server" />
                                                    <label class="form-label" for="txtConfirmPassword">Confirm Password</label>
                                                </div>
                                            </div>
                                        </div>

                                        <div class="d-flex justify-content-end pt-3">
                                            <asp:Button ID="btnReset" CssClass="btn btn-light btn-lg" Text="Reset" runat="server" OnClick="btnReset_Click"></asp:Button>
                                            <asp:Button ID="btnCreateUser" CssClass="btn btn-warning btn-lg ms-2 w-50" Text="Confirm" runat="server" OnClick="btnCreateUser_Click"></asp:Button>
                                        </div>

                                        <div class="d-flex justify-content-center align-items-center pt-3">
                                            <a href="LogIn.aspx" style="transition: 1ms ease-in-out; animation: b">Log In instead</a>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="position-absolute top-0 text-warning p-5">
                <asp:Label ID="lblError" runat="server" Visible="false">Howdt</asp:Label>
            </div>
        </section>
    </form>
</body>
</html>
