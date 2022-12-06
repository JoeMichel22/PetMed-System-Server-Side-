<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="PetMed_System_Server_Side_.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <link href="styles.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/home.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/bootstrap.min.js"></script>
    <title>Profile</title>
</head>
<body>
    <header>
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark justify-content-between px-2">
            <img src="./Images/undraw_friends.svg" width="40" height="40" alt="logo" />
            <div class="navbar-text">
                <h2>Pet Medication System</h2>
            </div>
            <ul class="navbar-nav">
                <li class="nav-item">
                    <a class="nav-link" href="Home.aspx">Home</a>
                </li>
                <li calss="nav-item">
                    <a class="nav-link" href="Pets.aspx">My Pets</a>
                </li>
                <li calss="nav-item">
                    <a class="nav-link" href="Profile.aspx">Profile</a>
                </li>
            </ul>
        </nav>
    </header>
    <form id="frmProfile" runat="server">
        <div class="text-center p-2">
            <asp:Label CssClass="text-center text-danger p-2 w-70" ID="lblErrorMessage" runat="server" Visible="False"></asp:Label>
            <asp:Label CssClass="text-center p-2 w-70 text-success" ID="lblSuccessMessage" runat="server" Visible="False"></asp:Label>

        </div>
        <div id="profile-info">
            <!-- 2 column grid layout with text inputs for the first and last names -->
            <div class="row mb-4">
                <div class="col">
                    <div class="form-outline">
                        <input type="text" id="txtName" class="form-control" runat="server" />
                        <label class="form-label" for="txtName">Name</label>
                    </div>
                </div>
            </div>

            <!-- Email input -->
            <div class="form-outline mb-4">
                <input type="email" id="txtEmail" class="form-control" runat="server" />
                <label class="form-label" for="txtEmail">Email</label>
            </div>

            <!-- Text input -->
            <div class="form-outline mb-4">
                <textarea class="form-control" id="txtAddress" rows="3" runat="server"></textarea>
                <label class="form-label" for="txtAddress">Address</label>
            </div>

            <!-- Number input -->
            <div class="form-outline mb-4">
                <input type="number" id="txtPhone" class="form-control" runat="server" />
                <label class="form-label" for="txtPhone">Phone</label>
            </div>

            <!-- Submit button -->
            <asp:Button ID="btnUpdateUser" CssClass="btn btn-primary btn-block mb-4" Text="Save Changes" runat="server" OnClick="btnUpdateUser_Click"></asp:Button>
        </div>
    </form>
</body>
</html>
