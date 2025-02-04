<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Hello_World.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
  .admin-container {
    width: 390px; /* Increased width for better spacing */
    margin: 50px auto;
    background-color: #2d4d4d;
    padding: 20px;
    border-radius: 10px;
    box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
    color: #ffffff;
  }

  .admin-container h2 {
    text-align: center;
    margin-bottom: 20px;
    font-size: 24px;
  }

  .form-container {
    display: flex;
    flex-direction: column;
    align-items: center; /* Center elements */
  }

  .form-group {
    width: 100%; /* Ensure full width */
    margin-bottom: 10px; /* Spacing between inputs */
  }

  .form-group label {
    font-weight: bold;
    display: block; /* Ensure labels are on top */
    text-align: left; /* Align text to left */
    margin-bottom: 5px;
  }

  .form-control {
    width: 100%; /* Make inputs full width */
    padding: 12px;
    border-radius: 5px;
    border: 1px solid #ccc;
    font-size: 16px;
  }

  .btn-primary {
    width: 100%;
    padding: 12px;
    background-color: #007bff;
    border: none;
    color: #ffffff;
    border-radius: 5px;
    cursor: pointer;
    font-size: 18px;
    margin-top: 10px;
  }

  .btn-primary:hover {
    background-color: #0056b3;
  }

  .admin-container .error-message {
    color: #ff0000;
    margin-top: 10px;
  }
</style>


<div class="admin-container">
  <h2>ADMIN CONTROL PANEL</h2>
  <div class="form-container">

    <div class="form-group">
     <label for="exampleInputDefaultPageText1">Default Page Text 1 </label>
     <asp:TextBox ID="TextBoxDefaultPageText1" class="form-control" runat="server"  aria-describedby="emailHelp" placeholder="Default Page Text 1"></asp:TextBox>
  
    </div>
    <div class="form-group">
     <label for="exampleInputDefaultPageText2">Default Page Text 2</label>
     <asp:TextBox ID="TextBoxDefaultPageText2" class="form-control" runat="server"  aria-describedby="emailHelp" placeholder="Default Page Text 2" ></asp:TextBox>

    </div>
    <div class="form-group">
     <label for="exampleInputHeaderText">Header Text</label>
     <asp:TextBox ID="TextBoxHeaderText" class="form-control" runat="server"  aria-describedby="emailHelp" placeholder="Header Text"></asp:TextBox>
  
    </div>
    <div class="form-group">
     <label for="exampleInputFooterText">Footer Text</label>
     <asp:TextBox ID="TextBoxFooterText" class="form-control" runat="server"  aria-describedby="emailHelp" placeholder="Footer Text" ></asp:TextBox>

    </div>
  </div>

    <asp:Button ID="ButtonSaveSettings" class="btn btn-primary" runat="server" Text="Save Settings" OnClick="ButtonSaveSetting_Click" />
    <asp:Label ID="LabelMsg" runat="server" ForeColor="Red"></asp:Label>
</div>
</asp:Content>
