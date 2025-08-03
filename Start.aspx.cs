// FILE          : Start.aspx.cs
// PROJECT       : HiLoGameASP4
// PROGRAMMER    : Gaurav Patel
// FIRST VERSION : 03-08-2025
// DESCRIPTION   : This is a file for the code-behind for the Start.aspx that is a page where the user enters his/her name to start the Hi-Lo game. The name of the user is saved in a session and then the user is transferred to the main game page.

using System;
using System.Web.UI;

namespace HiLoGameASP4
{
    public partial class Start : System.Web.UI.Page
    {
        // FUNCTION      : Page_Load
        // DESCRIPTION   :Handles the page load event. It clears the unobtrusive validation modeinactive setting to avoid any form of conflict with other validators commonly deployed such as theones used in the codes above.
        // PARAMETERS    : 
        //   sender (object)   : The source of the event
        //   e (EventArgs)     : Contains the event data
        // RETURNS       : void
        protected void Page_Load(object sender, EventArgs e)
        {
            // Disable unobtrusive validation to ensure compatibility with ASP.NET validators
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        // FUNCTION      : btnStartGame_Click
        // DESCRIPTION   : Controls event of starting a new instance of the application when Start button is clicked. Saves the name that the user entered in a session variable and then forward the control to the Game page to start the game.
        // PARAMETERS    : 
        //   sender (object)   : The source of the event
        //   e (EventArgs)     : Contains the event data
        // RETURNS       : void
        protected void btnStartGame_Click(object sender, EventArgs e)
        {
            // Remove unwanted spaces from the user’s message
            string userName = txtUserName.Text.Trim();

            // Ensure that the variable for user name is not blank
            if (!string.IsNullOrEmpty(userName))
            {
                // Use a session variable to store the user’s name for the Game page
                Session["UserName"] = userName;

                // Return to the Game page to start the Hi-Lo game.
                Response.Redirect("Game.aspx");
            }
        }
    }
}
