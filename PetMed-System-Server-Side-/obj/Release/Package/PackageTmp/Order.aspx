<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="PetMed_System_Server_Side_.Order" %>

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
        <div class="d-flex justify-content-center">
            <table>
                <tr>
                    <th>Medication ID</th>
                    <th>Name</th>
                    <th>Description</th>
                    <th>Species</th>
                    <th>Quantity Ordered</th>
                </tr>
                <asp:Repeater ID="rptOrder" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <asp:Label ID="lblMedId" runat="server" Text="<%# DataBinder.Eval(Container.DataItem, "MedId") %>"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblName" runat="server" Text="<%# DataBinder.Eval(Container.DataItem, "Name") %>"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblDescription" runat="server" Text="<%# DataBinder.Eval(Container.DataItem, "Description") %>"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblSpecies" runat="server" Text="<%# DataBinder.Eval(Container.DataItem, "Species") %>"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblOrdered" runat="server" Text="<%# DataBinder.Eval(Container.DataItem, "Order Quantity") %>"></asp:Label>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </form>
</body>
</html>
