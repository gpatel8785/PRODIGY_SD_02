<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="HiLoGameASP4.Start" %>
<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="UTF-8" />
    <title>Hi-Lo Game - Start</title>
    <link href="Content/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="pnlStart" runat="server" CssClass="game-panel">
            <h1>Welcome to Hi-Lo Game</h1>
            <asp:Label ID="lblNamePrompt" runat="server" Text="Enter your name:" AssociatedControlID="txtUserName" CssClass="game-label"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" CssClass="game-input" placeholder="Your Name"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvUserName" runat="server" ControlToValidate="txtUserName"
                ErrorMessage="Name is required." Display="Dynamic" ForeColor="Red" />
            <asp:Button ID="btnStartGame" runat="server" Text="Start Game" OnClick="btnStartGame_Click" CssClass="game-button" />
        </asp:Panel>
    </form>
</body>
</html>
