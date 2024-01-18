<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Hyperlink_controls.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style7 {
            text-align: center;
        }
        .newStyle1 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
        .newStyle2 {
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
        }
        .newStyle3 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
        .auto-style10 {
            text-align: center;
            margin-left: 457px;
        }
        .auto-style11 {
            width: 100%;
            height: 124px;
        }
        .newStyle4 {
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
        }
        .auto-style14 {
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
            width: 123px;
        }
        .auto-style15 {
            font-weight: bold;
            text-align: center;
            margin-left: 686px;
            margin-top: 18px;
        }
        .auto-style16 {
            width: 387px;
            height: 26px;
        }
        .auto-style17 {
            width: 100%;
        }
        .auto-style18 {
            width: 455px;
            margin-left: 500px;
            margin-top: 40px;
        }
        .newStyle5 {
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
        }
        .newStyle6 {
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
        }
        .auto-style19 {
            text-align: right;
            padding-right: 10px;
        }
        .auto-style20 {
            text-align: left;
        }
        .auto-style21 {
            margin-top: 0px;
        }
        .auto-style22 {
            width: 596px;
            height: 26px;
        }
        .auto-style23 {
            height: 26px;
        }
    </style>
</head>
<body style="height: 819px">
    <form id="form1" runat="server">
        <div>
        </div>
        <div class="auto-style7">
            <h2><span class="newStyle2">Login Form</span></h2>
            <p>&nbsp;</p>
        </div>
        <p>
            </p>
        <asp:Panel ID="Panel1" runat="server" CssClass="auto-style10" Height="124px" Width="548px">
            <table class="auto-style11">
                <tr>
                    <td class="auto-style14">Username: </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Height="37px" Width="383px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style14">Password:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Height="35px" TextMode="Password" Width="383px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <p>
            <strong>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style15" Height="41px" Text="Login" Width="188px" OnClick="Button1_Click1" />
            </strong>
        </p>
        <table class="auto-style17">
            <tr>
                <td class="auto-style22"></td>
                <td class="auto-style23">
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <div class="auto-style21">
            <table class="auto-style18">
                <tr>
                    <td  rowspan="3" class="auto-style16">
                        <table class="auto-style17">
                            <tr>
                                <td class="auto-style19">
                                    <asp:Image ID="Image5" runat="server" Height="25px" ImageUrl="~/search (4).png" Width="25px" />
                                </td>
                                <td class="auto-style20">
                                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="newStyle6" NavigateUrl="https://www.google.com/">Google</asp:HyperLink>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td  rowspan="3" class="auto-style16">
                        <table class="auto-style17">
                            <tr>
                                <td class="auto-style19">
                                    <asp:Image ID="Image6" runat="server" Height="25px" ImageUrl="~/gmail.png" Width="25px" />
                                </td>
                                <td class="auto-style20">
                                    <asp:HyperLink ID="HyperLink2" runat="server" CssClass="newStyle6" NavigateUrl="https://mail.google.com/">Email</asp:HyperLink>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td  rowspan="3" class="auto-style16">
                        <table class="auto-style17">
                            <tr>
                                <td class="auto-style19">
                                    <asp:Image ID="Image7" runat="server" Height="35px" ImageUrl="~/facebook (4).png" Width="25px" />
                                </td>
                                <td class="auto-style20">
                                    <asp:HyperLink ID="HyperLink3" runat="server" CssClass="newStyle6" NavigateUrl="https://www.facebook.com/">Facebook</asp:HyperLink>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
