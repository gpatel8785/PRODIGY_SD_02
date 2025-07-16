// FILE          : PlayAgain.aspx.cs
// PROJECT       : HiLoGameASP4
// PROGRAMMER    : Gaurav Patel & Het Harani
// FIRST VERSION : 12-11-2024
// DESCRIPTION   :  This is another web form file; it is the code behind PlayAgain.aspx where the user is given a message whether to play the Hi-Lo game again or not. This one manages session, clearing sessions as well as session redirection to a user preferred option.

using System;
using System.Web.UI;

namespace HiLoGameASP4
{
    public partial class PlayAgain : Page
    {
        // FUNCTION      : Page_Load
        // DESCRIPTION   : Initializes the page. Makes new page load with no client side validation active by turning the drop down’s unobtrusive validation mode off.
        // PARAMETERS    : 
        //   sender (object)   : The source of the event
        //   e (EventArgs)     : Contains the event data
        // RETURNS       : void
        protected void Page_Load(object sender, EventArgs e)
        {
            // Uncheck set unobtrusive validation mode to none if not done already because it conflicts with the new version.
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        // FUNCTION      : btnPlayAgain_Click
        // DESCRIPTION   : Terminates the session data and then reload the page Start.aspx to begin another game session..
        // PARAMETERS    : 
        //   sender (object)   : The source of the event
        //   e (EventArgs)     : Contains the event data
        // RETURNS       : void
        protected void btnPlayAgain_Click(object sender, EventArgs e)
        {
            // This clears all the session variables which will restart the game.
            Session.Clear();

            //  We re-direct the user to Start.aspx to enable them to start a new game.
            Response.Redirect("Start.aspx");
        }

        // FUNCTION      : btnExit_Click
        // DESCRIPTION   : Responsible for the control of the Exit button’s click event. Erases all the session information and forward the user to the exit page.
        // PARAMETERS    : 
        //   sender (object)   : The source of the event
        //   e (EventArgs)     : Contains the event data
        // RETURNS       : void
        protected void btnExit_Click(object sender, EventArgs e)
        {
            //  Clear up data within the selected session to exit the game session.
            Session.Clear();

            // The users should be redirected to either the Start page or any other exit page of the procedure.
            Response.Redirect("Start.aspx");
        }
    }
}
