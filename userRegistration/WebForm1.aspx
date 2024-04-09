<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="userRegistration.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label id="l1" Text ="Username" runat = "server"></asp:Label>
            <asp:TextBox ID="uname" runat = "server"></asp:TextBox><br />

            <asp:Label ID="l2" Text ="Password" runat = "server"></asp:Label>
            <asp:TextBox ID="pass"  TextMode="Password" runat="server"></asp:TextBox><br />

            <asp:Label ID="l3" Text ="RePassword" runat = "server"></asp:Label>
            <asp:TextBox ID="repass"  TextMode="Password" runat="server"></asp:TextBox><br />

            <asp:Label ID="l4" Text ="Gender" runat = "server"></asp:Label>
            <asp:RadioButton ID="r1" Text="male" GroupName="gender" value="male" runat="server"></asp:RadioButton><br />
            <asp:RadioButton ID="r2" Text="female" GroupName="gender" value="female" runat="server"></asp:RadioButton><br />

            <asp:Label ID="l5" Text ="Course" runat = "server"></asp:Label>
            <asp:CheckBox ID="c1" Text="C" value="C" runat="server" /><br />
            <asp:CheckBox ID="c2" Text="C++" value="C++" runat="server" /><br />
            <asp:CheckBox ID="c3" Text="java" value="java" runat="server" /><br />

            <asp:Label ID="l6" Text ="Country" runat = "server"></asp:Label>
            <asp:DropDownList ID="country" runat="server">
              <asp:ListItem Value="">Select your country</asp:ListItem>
              <asp:ListItem>Nepal</asp:ListItem>
              <asp:ListItem>China</asp:ListItem>
              <asp:ListItem>India</asp:ListItem>
              <asp:ListItem>Other</asp:ListItem>
            </asp:DropDownList>

            <asp:Button ID="submit" Text="submit" OnClick="btn_submit" runat="server"></asp:Button>
            <asp:Label ID="l7" Text ="Result" runat = "server"></asp:Label>
        </div>
    </form>
</body>
</html>
