<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PetDisplay.ascx.cs" Inherits="PetMed_System_Server_Side_.PetDisplay" %>

<div class="card m-3" style="width: 18rem;">
    <div class="card-header text-center">
        <asp:Label ID="lblPetName" runat="server"></asp:Label>
    </div>
    <ul class="list-group list-group-flush">
        <li class="list-group-item"><strong>Age:</strong> 
            <asp:Label ID="lblPetAge" runat="server"></asp:Label>
        </li>
        <li class="list-group-item"><strong>Species:</strong> 
            <asp:Label ID="lblPetSpecies" runat="server"></asp:Label>
        </li>
    </ul>
    <div class="card-body d-flex justify-content-evenly">
        <asp:Button ID="btnEditPet" CssClass="btn btn-success" runat="server" Text="edit"/>
        <asp:Button ID="btnDeletePet" CssClass="btn btn-danger" runat="server" Text="delete" OnClick="btnDeletePet_Click"/>
    </div>
</div>
