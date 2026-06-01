<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Training.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Form</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
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
    </form>
</body>
</html>
