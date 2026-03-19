<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="COOKIE_6932077.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #TextArea1 {
            margin-left: 76px;
        }
        #txtDescription {
            margin-left: 76px;
        }
        #Text {
            margin-left: 78px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 10px">
            <asp:Label ID="Label1" runat="server" Text="Category"></asp:Label>
            <asp:DropDownList ID="ddlCategory" runat="server" style="margin-left: 90px">
                <asp:ListItem>Footwear-Women`s</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Supplier"></asp:Label>
            <asp:DropDownList ID="ddlSuplier" runat="server" style="height: 22px; margin-left: 97px">
                <asp:ListItem>Nike</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Product"></asp:Label>
            <asp:TextBox ID="txtProduct" runat="server" style="margin-left: 98px"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server" style="margin-left: 78px"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Image"></asp:Label>
            <asp:TextBox ID="txtImagen" runat="server" style="margin-left: 110px"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" style="margin-left: 117px"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Number in Stock"></asp:Label>
            <asp:TextBox ID="txtNumberInStock" runat="server" style="margin-left: 42px"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Number in Order"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 41px"></asp:TextBox>
            <br />
            <asp:Label ID="Label9" runat="server" Text="Reorder Level"></asp:Label>
            <asp:TextBox ID="txtReorderLevel" runat="server" style="margin-left: 61px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnConfirm" runat="server" OnClick="BtnConfirm_Click" Text="Confirm" />
        </div>
    </form>
</body>
</html>
