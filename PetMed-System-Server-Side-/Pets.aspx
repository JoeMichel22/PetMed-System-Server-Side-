<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pets.aspx.cs" Inherits="PetMed_System_Server_Side_.Pets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <link href="styles.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/bootstrap.min.js"></script>
    <title>My Pets</title>
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
                    <a class="nav-link" href="Pets.aspx">Your Pets</a>
                </li>
            </ul>
        </nav>
    </header>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
