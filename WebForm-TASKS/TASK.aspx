<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TASK.aspx.cs" Inherits="WebForm_TASKS.TASK" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .Textt{
            height:12px;
            width:50px;
            text-align:center;
           
        }
        #clear{
            margin-left:40px;
        }
        .div1{
            margin-left:150px;
            margin-top:40px;
            background-color:azure;
            font-size:15pt;
            width:300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div1">
            <asp:Label ID="Label1" runat="server" Text="First Number :   "></asp:Label>
            <asp:TextBox ID="first" runat="server" CssClass="Textt"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Second Number :   " ></asp:Label>
            <asp:TextBox ID="second" runat="server" CssClass="Textt"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Result :   "></asp:Label> <br />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>

            <asp:Label ID="Result" runat="server" Text=""></asp:Label>            
            <br />
            <asp:Button ID="sum" runat="server" Text="+" OnClick="Sum_Click" />
            <asp:Button ID="sub" runat="server" Text="-" OnClick="sub_Click" />
            <asp:Button ID="multip" runat="server" Text="*" OnClick="multip_Click" />
            <asp:Button ID="Divi" runat="server" Text="/" OnClick="Divi_Click" />
            <asp:Button ID="mod" runat="server" Text="%" OnClick="Mode_Click" />
            <br /><br />
            <asp:Button ID="clear" runat="server" Text="Clear" OnClick="Clear_Click" />



            <%--------------------------------------------------------------------------%>
            <%--<asp:Label ID="Label1" runat="server" Text="First Number :   "></asp:Label>
            <asp:Label ID="first" runat="server" Text=""></asp:Label>--%>
            <%--<asp:TextBox ID="first" runat="server"></asp:TextBox>--%>
            <%--<br />
            <asp:Label ID="Label2" runat="server" Text="Second Number :   " ></asp:Label>
            <asp:Label ID="second" runat="server" Text=""></asp:Label>--%>
            <%--<asp:TextBox ID="second" runat="server"></asp:TextBox>--%>
            <%--<br />
            <asp:Label ID="Label3" runat="server" Text="Result :   "></asp:Label>
            <asp:Label ID="Result" runat="server" Text=""></asp:Label>            
            <br />
            <br />
            <asp:Button ID="n1" runat="server" Text="1" OnClick="n1_Click" />
            <asp:Button ID="n2" runat="server" Text="2" />
            <asp:Button ID="n3" runat="server" Text="3" />
            <br />
            <asp:Button ID="n4" runat="server" Text="4" />
            <asp:Button ID="n5" runat="server" Text="5" />
            <asp:Button ID="n6" runat="server" Text="6" />
            <br />
            <asp:Button ID="sum" runat="server" Text="+" OnClick="Sum_Click" />
            <asp:Button ID="sub" runat="server" Text="- " OnClick="sub_Click" />
            <asp:Button ID="multip" runat="server" Text="*" OnClick="multip_Click" />
            <br />
            <asp:Button ID="Divi" runat="server" Text="/" OnClick="Divi_Click" />
            <asp:Button ID="mod" runat="server" Text="%" OnClick="Mode_Click" />--%>
         

        </div>
    </form>
</body>
</html>
