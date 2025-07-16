<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="HiLoGameASP4.Game" %>
<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="UTF-8" />
    <title>Hi-Lo Game</title>
    <link href="Content/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="pnlGame" runat="server" CssClass="game-panel">
            <h1>Hi-Lo Game</h1>
            <asp:Label ID="lblWelcome" runat="server" CssClass="game-label" />
            <asp:Label ID="lblRange" runat="server" CssClass="game-label" />
            <asp:TextBox ID="txtGuess" runat="server" CssClass="game-input" placeholder="Enter your guess" />
            <asp:RangeValidator ID="rvGuess" runat="server" ControlToValidate="txtGuess" MinimumValue="1" MaximumValue="100"
                Type="Integer" ErrorMessage="Guess must be a number between 1 and 100." Display="Dynamic" ForeColor="Red" />
            <asp:Button ID="btnSubmitGuess" runat="server" Text="Submit Guess" OnClick="btnSubmitGuess_Click" CssClass="game-button" />
            <asp:Label ID="lblFeedback" runat="server" CssClass="feedback-label" ForeColor="Red" />
            <asp:Button ID="btnPlayAgain" runat="server" Text="Play Again" OnClick="btnPlayAgain_Click" CssClass="game-button" Visible="false" />
        </asp:Panel>
    </form>
</body>
</html>
