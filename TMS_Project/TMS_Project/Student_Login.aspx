<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Site.Master" AutoEventWireup="true" CodeBehind="Student_Login.aspx.cs" Inherits="TMS_Project.Student_Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
      <div class="container">
            <div class="row">
                <div class="col-md-4 mx-auto" style="box-shadow: 0px 3px 32px -1px rgba(0,0,0,0.75);-webkit-box-shadow: 0px 3px 32px -1px rgba(0,0,0,0.75);-moz-box-shadow: 0px 3px 32px -1px rgba(0,0,0,0.75);">
                  <br />
                    <div class="jumbotron bg-primary text-center text-white">
                        <h2>Student Login</h2>
                    </div>
                    <asp:TextBox ID="UsernameTxt" runat="server" placeholder="Enter Username"  CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="UsernameTxt" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" runat="server" ErrorMessage="Username Required"></asp:RequiredFieldValidator>
                    <br />
                    <asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password" placeholder="Enter Password" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="PasswordTxt" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" runat="server" ErrorMessage="Password Required"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Button ID="Student_Loginbtn" runat="server" Text="Login" OnClick="Student_Loginbtn_Click" CssClass="btn btn-primary btn-block"  />
                    <br />
                    <a href ="~/Tutor_Login.aspx" class="text-center">Not Registered Yet?Click Here</a>
                </div>
            </div>
        </div>
</asp:Content>
