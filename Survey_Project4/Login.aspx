<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Survey_Project4.Login" %>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Login_CSS.css"/>
    <%--<script src="Login_JS.js" type="text/javascript"></script>--%>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/logo.png" CssClass="logo"/>
            <asp:Button ID="about" runat="server" Text="AboutUs" CssClass="about" OnClick="about_Click" />
            <asp:Button ID="home" runat="server" Text="Home" CssClass="about" OnClick="home_Click" />

        </div>
        <div>  <asp:Label ID="mess" runat="server" Text="" CssClass="mess_label"></asp:Label>
            <br />

        </div>
        
      <div style="margin-top:45px;">
        
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
                
                <asp:Button ID="login" runat="server" Text="Login" CssClass="login_button" OnClick="login_Click" OnClientClick="LOGIN()"/>
                </div>
          
            
        </div>
      
    </form>
      
    <div class="footer" >
        <asp:Label ID="copy" runat="server" Text="orange @ 2022"></asp:Label>
    </div>
    <%--JAVASCRIPT SECTION--%>
    <%--***************************************************************************************************************--%>
    <script>
        let names1 = ["Lujain", "Lubna", "Malek", "Raghad", "Sohaib", "Mohammad", "Ahmad", "Sara", "Alaa", "Hala"];
        let IDs = ["1324", "1224", "1424", "2724", "3324", "1624", "1524", "1124", "2324", "2424"];
        let user_object = {
            username: "",
            userid: "",
        }
        function LOGIN() {
            let cond = false;
            let ex = false;
            let un = document.getElementById('<%= User_input.ClientID %>').value;
            let id = document.getElementById('<%= Id_input.ClientID %>').value;
            //if user exist in company
            for (let i = 0; i < names1.length; i++) {
           
                if (un == names1[i] && id == IDs[i]) {
                    cond = true;
                    break;
                }
                else cond = false;
            }
           
           

          //if employee fill the syrvey or not

             if (cond == true) {
                if (localStorage.length == 0) {
                    user_object.username = un;
                    user_object.userid = id;
                    localStorage.setItem(`${localStorage.length + 1}`, JSON.stringify(user_object));
                }
                else {
                    for (let i = 1; i <= localStorage.length; i++) {
                        if (un == JSON.parse(localStorage.getItem(i)).username && id == JSON.parse(localStorage.getItem(i)).userid) {
                             //if user is an Admin
                            if ((un == "Sara" && id == "1124") || (un == "Ahmad" && id == "1524")) {
                                document.getElementById("mess").innerHTML = "Welcome Admin";
                                //document.getElementById("login").setAttribute("href", "Login.aspx");
                                //Response.redirect("Login.aspx");
                                ex = true;
                                break;
                            }
                            else {
                               document.getElementById("mess").innerHTML = "You Are Already Exist";
                            document.getElementById("login").setAttribute("href", "Login.aspx");
                            Response.redirect("Login.aspx");
                            ex = true;
                            break;}
                           
                        }
                        else {
                            ex = false;
                        }
                    }
                    if (ex == false) {
                        user_object.username = un;
                        user_object.userid = id;
                        localStorage.setItem(`${localStorage.length + 1}`, JSON.stringify(user_object));
                        document.getElementById("mess").innerHTML = "Thanks For Your Time";
                        //Response.redirect("Login.aspx");
                    }
                }

                
            }
            else { document.getElementById("mess").innerHTML = "This Name Not Exist !"; }
        }

    </script>
      <%--***************************************************************************************************************--%>
      <%--END JAVASCRIPT SECTION--%>
  
</body>
</html>
