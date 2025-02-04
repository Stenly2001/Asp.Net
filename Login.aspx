<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Hello_World.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
    .login-container {
      width: 350px;
      margin: 50px auto;
      background-color: #2d4d4d;
      padding: 20px;
      border-radius: 10px;
      box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
      color: #ffffff;
    }
    .login-container h2 {
      text-align: center;
      margin-bottom: 20px;
    }
    .form-group label {
      font-weight: bold;
    }
    .form-control {
      width: 100%;
      padding: 10px;
      margin: 10px 0;
      border-radius: 5px;
      border: 1px solid #ccc;
    }
    .btn-primary {
      display: block;
      width: 100%;
      padding: 10px;
      background-color: #007bff;
      border: none;
      color: #ffffff;
      border-radius: 5px;
      cursor: pointer;
      font-size: 16px;
    }
    .btn-primary:hover {
      background-color: #0056b3;
    }
    .login-container .error-message {
      color: #ff0000;
      margin-top: 10px;
    }
  </style>

  <div class="login-container">
    <h2>LOGIN PAGE</h2>

  <div class="form-group">
    <label for="exampleInputUsername">Username</label>
      <asp:TextBox ID="TextBoxUsername" class="form-control" runat="server"  aria-describedby="emailHelp" placeholder="Username"></asp:TextBox>
    
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Password</label>
            <asp:TextBox ID="TextBoxPassword" class="form-control" runat="server"  aria-describedby="emailHelp" placeholder="Password" TextMode="Password"></asp:TextBox>
  
  </div>
 
    <asp:Button ID="ButtonLogin" class="btn btn-primary" runat="server" Text="Login" OnClick="ButtonLogin_Click" />
    <br>
    <asp:Label ID="LabelMsg" runat="server" ></asp:Label>


</div>
</asp:Content>

