<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayAgain.aspx.cs" Inherits="HiLoGameASP4.PlayAgain" %>
<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="UTF-8" />
    <title>Play Again - Hi-Lo Game</title>
    <link href="Content/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="pnlPlayAgain" runat="server" CssClass="game-panel">
            <h1>Game Over</h1>
            <asp:Label ID="lblMessage" runat="server" Text="Would you like to play again?" CssClass="game-label"></asp:Label>
            <asp:Button ID="btnPlayAgain" runat="server" Text="Play Again" OnClick="btnPlayAgain_Click" CssClass="game-button" />
            <asp:Button ID="btnExit" runat="server" Text="Exit" OnClick="btnExit_Click" CssClass="game-button" />
        </asp:Panel>
    </form>
</body>
</html>
