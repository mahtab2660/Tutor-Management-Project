<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Site.Master" AutoEventWireup="true" CodeBehind="Student_SignUp.aspx.cs" Inherits="TMS_Project.Student_SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
 <br />
    <div class="container">
         <div class="row">
             <div class="col-md-12">
                 <h1 class="jumbotron bg-primary text-white text-center">Student_Signup</h1>
             </div>
              <div class="col-md-4">
                  <asp:TextBox ID="NameTxt" runat="server" placeholder="Enter Name" CssClass="form-control"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="NameTxt" ForeColor="Red" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage="Name Required"></asp:RequiredFieldValidator>
                  <br />
                  <asp:TextBox ID="FatherNameTxt" runat="server" placeholder="Enter Father Name" CssClass="form-control"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="FatherNameTxt" ForeColor="Red" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage=" Father Name Required"></asp:RequiredFieldValidator>
                  <br />
                  <asp:TextBox ID="SurNameTxt" runat="server" placeholder="Enter Surname Name" CssClass="form-control"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="SurNameTxt" ForeColor="Red" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage=" Sur Name Required"></asp:RequiredFieldValidator>
                  <br />
                  <asp:DropDownList ID="GenderDropDownList" CssClass="form-control" runat="server">
                      <asp:ListItem>Select Gender</asp:ListItem>
                      <asp:ListItem>Male</asp:ListItem>
                      <asp:ListItem>Female</asp:ListItem>
                      <asp:ListItem></asp:ListItem>
                  </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="GenderDropDownList" InitialValue="Select Gender" ForeColor="Red" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage="Gender Required"></asp:RequiredFieldValidator>
                  <br />
                     <asp:TextBox ID="AgeTxt" runat="server" placeholder="Enter Age" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="AgeTxt" ForeColor="Red" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage=" Age Required"></asp:RequiredFieldValidator>
                  <br />
                  <asp:DropDownList ID="CountryDropDownList" CssClass="form-control" runat="server">
                      <asp:ListItem>Select Country</asp:ListItem>
                      <asp:ListItem>India</asp:ListItem>
                      <asp:ListItem>Bangladesh</asp:ListItem>
                      <asp:ListItem>Sri Lanka</asp:ListItem>
                      <asp:ListItem>Indonesia </asp:ListItem>
                      <asp:ListItem>Bhutan</asp:ListItem>
                      <asp:ListItem>Pakistan</asp:ListItem>
                      <asp:ListItem>Napal</asp:ListItem>
                      <asp:ListItem>China</asp:ListItem>
                      <asp:ListItem>Malaysia</asp:ListItem>
                      </asp:DropDownList>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="CountryDropDownList" InitialValue="Select Country" ForeColor="Red" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage="Country Required"></asp:RequiredFieldValidator>
                   </div>
              
                  <div class="col-md-4">

                       <asp:TextBox ID="CityTxt" runat="server" placeholder="Enter City" CssClass="form-control"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="CityTxt" ForeColor="Red" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage="City Required"></asp:RequiredFieldValidator>
                  <br />
                  <asp:TextBox ID="AddressTxt" TextMode="MultiLine" Rows="4" Columns="20" runat="server" placeholder="Enter Address" CssClass="form-control"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="AddressTxt" ForeColor="Red" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage=" Address Required"></asp:RequiredFieldValidator>
                  <br />
                  <asp:TextBox ID="ClassTxt" runat="server" placeholder="Enter Class" CssClass="form-control"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator10" ControlToValidate="ClassTxt" ForeColor="Red" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage=" Class Required"></asp:RequiredFieldValidator>
                  <br />
                  <asp:DropDownList ID="GoingToDropDownList" CssClass="form-control" runat="server">
                      <asp:ListItem>Going To</asp:ListItem>
                      <asp:ListItem>School</asp:ListItem>
                      <asp:ListItem>College</asp:ListItem>
                      <asp:ListItem>Unversity</asp:ListItem>
                      <asp:ListItem>Other</asp:ListItem>  
                  </asp:DropDownList>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator9" ControlToValidate="GoingToDropDownList" InitialValue="Going To" ForeColor="Red" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage="Going To  Required"></asp:RequiredFieldValidator>
                  <br />
                      <asp:TextBox ID="SubjectTxt" CssClass="form-control" placeholder="Enter Subject" runat="server"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator16" ControlToValidate="SubjectTxt" ForeColor="Red" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage=" Subject Required"></asp:RequiredFieldValidator>
             </div>
             <div class="col-md-4">
                 <asp:TextBox ID="ContactTxt" CssClass="form-control" placeholder="Enter Contact Number" runat="server"></asp:TextBox>
                 <br />
                 <asp:DropDownList ID="TuitionTypeDropDownList" CssClass="form-control" runat="server">
                     <asp:ListItem>Select Tuition Type</asp:ListItem>
                     <asp:ListItem>Online</asp:ListItem>
                     <asp:ListItem>Physical </asp:ListItem>
                    
                 </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator14" ControlToValidate="TuitionTypeDropDownList" InitialValue="Select Tuition Type" ForeColor="Red" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage="Tution Type Required"></asp:RequiredFieldValidator>
                 <br />
                 <asp:DropDownList ID="TuitionPreferredDropDownList" CssClass="form-control" runat="server">
                     <asp:ListItem>Select Tutor Prefrered</asp:ListItem>
                     <asp:ListItem>Graduate</asp:ListItem>
                     <asp:ListItem>Master</asp:ListItem>
                     <asp:ListItem>M.Phill</asp:ListItem>
                     <asp:ListItem>PHD</asp:ListItem>
                     <asp:ListItem>Other</asp:ListItem>
                 </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator15" ControlToValidate="TuitionPreferredDropDownList" InitialValue="Select Tutor Prefrered" ForeColor="Red" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage="Tution Prefreed Required"></asp:RequiredFieldValidator>
                 <br />
                 <asp:TextBox ID="UsernameTxt" placeholder="Enter Username" CssClass="form-control" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator11" ControlToValidate="UsernameTxt" ForeColor="Red" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage=" Username Required"></asp:RequiredFieldValidator>
                 <br />
                   <asp:TextBox ID="PasswordTxt" placeholder="Enter Password" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator12" ControlToValidate="PasswordTxt" ForeColor="Red" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage=" Password Required"></asp:RequiredFieldValidator>
                 <br />
                   <asp:TextBox ID="ConfirmPasswordTxt" placeholder="Enter Confirm Password" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator13" ControlToValidate="ConfirmPasswordTxt" ForeColor="Red" Display="Dynamic" SetFocusOnError="true" runat="server" ErrorMessage="Password must be identical"></asp:RequiredFieldValidator>
             </div>
              
         </div>
        <div class="row mx-auto">
               <div class="col-md-4 mx-auto">
                   <br />
                   <asp:Button ID="Submitbtn" runat="server" Text="Submit"  CssClass="btn btn-primary btn-block" />
               </div>
        </div>
        
   </div>

</asp:Content>
