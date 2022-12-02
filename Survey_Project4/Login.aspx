<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Survey_Project4.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Login_CSS.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/logo.png" CssClass="logo"/>
            <asp:Button ID="about" runat="server" Text="AboutUs" CssClass="about" OnClick="about_Click" />
            <asp:Button ID="home" runat="server" Text="Home" CssClass="about" OnClick="home_Click" />

        </div>
        <div>  <asp:Label ID="mess" runat="server" Text="" CssClass="mess_label"></asp:Label></div>
      
        <div style="margin-top:85px;">
           
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Rename.png" CssClass="IMG"/>
            <div class="login_div">
                <br />
                <asp:Label ID="wel" runat="server" Text="Welcome In Login Screen" CssClass="wel_st"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Label ID="username" runat="server" Text="UserName" CssClass="user_Id_label"> </asp:Label>
                <br /> <br />
                <asp:TextBox ID="User_input" runat="server" CssClass="user_Id_box"></asp:TextBox>
                <br />
                <br />
                <br />
                <asp:Label ID="id_label" runat="server" Text="Employee_ID" CssClass="user_Id_label"> </asp:Label>
                <br /> <br />
                <asp:TextBox ID="Id_input" runat="server" CssClass="user_Id_box"></asp:TextBox>
                
                <asp:Button ID="login" runat="server" Text="Login" CssClass="login_button" OnClick="login_Click" />
                </div>
          
            
        </div>
      
    </form>
      
    <div class="footer" >
        <asp:Label ID="copy" runat="server" Text="orange @ 2022"></asp:Label>
    </div>
</body>
</html>
