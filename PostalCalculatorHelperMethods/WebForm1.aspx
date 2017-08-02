<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PostalCalculatorHelperMethods.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Postal Calculator<br />
        <br />
        Width:<asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="widthTextBox_TextChanged"></asp:TextBox>
        <br />
        Height:<asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" OnTextChanged="heightTextBox_TextChanged"></asp:TextBox>
        <br />
        Length:<asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="lengthTextBox_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="groundButton" runat="server" Text="Ground" AutoPostBack="True" GroupName="methodGroup" OnCheckedChanged="groundButton_CheckedChanged" />
        <br />
        <asp:RadioButton ID="airButton" runat="server" Text="Air" AutoPostBack="True" GroupName="methodGroup" OnCheckedChanged="airButton_CheckedChanged" />
        <br />
        <asp:RadioButton ID="nextDayButton" runat="server" Text="Next Day" AutoPostBack="True" GroupName="methodGroup" OnCheckedChanged="nextDayButton_CheckedChanged" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
