<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PetMed_System_Server_Side_.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <link href="styles.css" rel="stylesheet" type="text/css" />
    <link href="./Styles/home.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/bootstrap.min.js"></script>
    <title>Pet Medication</title>
</head>
<body>
    <form id="frmPetMedicationSystem" runat="server">
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

        <div class="d-flex justify-content-center">
            <asp:Label CssClass="welcome-label my-1" ID="lblWelcome" runat="server"></asp:Label>
        </div>

        <main>
            <div>
                <asp:DropDownList ID="ddlMedicationFilter" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlMedicationFilter_SelectedIndexChanged"></asp:DropDownList>
            </div>
        </main>
    </form>
</body>
</html>
