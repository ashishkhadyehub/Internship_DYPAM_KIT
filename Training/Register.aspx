<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Training.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
     <div class="container mt-3">
         <h2>Register Now</h2>
         
             <div class="mb-3 mt-3">
                 <label for="email">Name:</label>
                 <asp:TextBox runat="server" CssClass="form-control" ID="txtName"  ></asp:TextBox>
                <%--<input type="text" />--%>
             </div>
             <div class="mb-3 mt-3">
                 <label for="email">Contact:</label>
                 <asp:TextBox TextMode="Email" runat="server" CssClass="form-control" ID="txtContact"  ></asp:TextBox>
                 <%--<input type="text" />--%>
             </div>
             <div class="mb-3 mt-3">
                 <label for="email">Select City:</label>
                 <asp:DropDownList ID="ddlCities" CssClass="form-control" runat="server">
                     <asp:ListItem>Select City</asp:ListItem>
                     <asp:ListItem>Kolhapur</asp:ListItem>
                     <asp:ListItem>Pune</asp:ListItem>
                     <asp:ListItem>Mumbai</asp:ListItem>
                     <asp:ListItem>Nagpur</asp:ListItem>
                 </asp:DropDownList>
                 <%--<select>
                     <option>Kolhapur</option>
                     <option>Pune</option>
                     <option>Mumbai</option>
                     <option>Nagour</option>
                 </select>--%>
                
             </div>
         <asp:Button runat="server" ID="btnSubmit" Text="Register" CssClass="btn btn-outline-success" />

           
           
            
         
     </div>
 </div>
</asp:Content>
