<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PetMed_System_Server_Side_.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <link href="styles.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/bootstrap.min.js"></script>
    <title></title>
</head>
<body class="vh-100 w-100">
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
                                <input type="text" id="txtPassword" class="form-control form-control-lg" runat="server" />
                                <label class="form-label" for="txtPassword">Password</label>
                            </div>
                            <div class="d-flex justify-content-start pt-3">
                                <asp:Button ID="btnForgot" CssClass="btn btn-light btn-lg" Text="Forgot Password" runat="server"></asp:Button>
                                <asp:Button ID="btnRegister" CssClass="btn btn-light btn-lg ms-2 w-50" Text="Register" runat="server"></asp:Button>
                            </div>
                            <div class="d-flex justify-content-center pt-3">
                                <asp:Button ID="btnLogin" CssClass="btn btn-warning btn-lg ms-2 w-50" Text="Login" runat="server"></asp:Button>
                            </div>

                        </div><%--end card--%>
                    </div><%--end col--%>

                </div>
            </div>
        </section>
    </form>
</body>
</html>
