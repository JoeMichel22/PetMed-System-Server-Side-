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

        <main class="py-3 px-4">
            <div>
                <asp:DropDownList CssClass="border-2" ID="ddlMedicationFilter" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlMedicationFilter_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <div class="d-flex justify-content-center align-items-center flex-column">
                <div>
                     <asp:Label CssClass="p-3 w-100" ID="lblError" runat="server"></asp:Label>
                </div>
                <asp:GridView ID="gvMedication" CssClass="mydatagrid table table-striped" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:TemplateField HeaderText="Select Medication">
                            <ItemTemplate>
                                <asp:CheckBox ID="chkSelectMedication" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="MedicationName" HeaderText="Drug Name" ReadOnly="True" SortExpression="Drug Name" />
                        <asp:BoundField DataField="Description" HeaderText="Description" ReadOnly="True" SortExpression="Description" />
                        <asp:BoundField DataField="Diseases" HeaderText="Diseases" ReadOnly="True" SortExpression="Diseases" />
                        <asp:BoundField DataField="Species" HeaderText="Species" ReadOnly="True" SortExpression="Species" />
                        <asp:BoundField DataField="Stock" HeaderText="Stock" ReadOnly="True" SortExpression="Stock" />
                        <asp:BoundField DataField="Price" HeaderText="Base Price" ReadOnly="True" SortExpression="Price" />
                        <asp:TemplateField HeaderText="Quantity">
                            <ItemTemplate>
                                <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
            <div>
                <asp:Button ID="btnOrder" CssClass="btn btn-primary" Text="Order" runat="server" OnClick="btnOrder_Clicked"/>
            </div>
        </main>
    </form>
</body>
</html>
