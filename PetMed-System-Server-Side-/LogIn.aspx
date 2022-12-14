<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="PetMed_System_Server_Side_.LogIn" %>

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
        <section id="loginSECT" class="vh-100 bg-dark d-flex justify-content-center align-items-center overflow-scroll">
            <div class="container py-5">
                <div class="row d-flex justify-content-center align-items-center h-100">
                
                    <div class="col">
                        <div class="card card-registration border-0 h-100">
                            <h2 class="text-center">PetMed Login</h2>
                            <br />
                            <br />

                            <div class="form-outline mb-4">
                                <input type="text" id="txtEmail" class="form-control form-control-lg" runat="server" />
                                <label class="form-label" for="txtEmail">Email</label>
                            </div>
                            <div class="form-outline mb-4">
                                <input type="password" id="txtPassword" class="form-control form-control-lg" runat="server" />
                                <label class="form-label" for="txtPassword">Password</label>
                            </div>

                            <div class="d-flex justify-content-start pt-3">
                                <asp:CheckBox ID="chkSaveLoginInfo" CssClass="" Text="Save Login" runat="server"></asp:CheckBox>
                            </div>
                            <div class="d-flex justify-content-start pt-3">
                                <asp:Button ID="btnForgot" CssClass="btn btn-light btn-sm" Text="Forgot Password" runat="server" OnClick="btnForgot_Click"></asp:Button>
                                <a href="AccountRegistration.aspx" style="transition: 1ms ease-in-out; animation: b" class="m-3">Register</a>
                            </div>
                            <div class="d-flex justify-content-center pt-3">
                                <asp:Button ID="btnLogin" CssClass="btn btn-warning btn-lg ms-2 w-50" Text="Login" runat="server" OnClick="btnLogin_Click"></asp:Button>
                                <asp:Label ID="lblError" runat="server" Visible="false" CssClass="ms-3"></asp:Label>
                            </div>

                        </div><%--end card--%>
                    </div><%--end col--%>

                </div>
            </div>
        </section>
    </form>
</body>
</html>
