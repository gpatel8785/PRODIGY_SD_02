// FILE          : Game.aspx.cs
// PROJECT       : HiLoGameASP4
// PROGRAMMER    : Gaurav Patel
// FIRST VERSION : 03-08-2025
// DESCRIPTION   :  This file comprises all the programmatic logic to the Game.aspx, which is the page in which the user guesses in the Hi-Lo game. It controls game flow, results and session for each attempt of game.

using System;
using System.Web.UI;

namespace HiLoGameASP4
{
    public partial class Game : System.Web.UI.Page
    {
        // FUNCTION      : Page_Load
        // DESCRIPTION   : Creates the initial setting of the game and shows the welcome message on the first page load.
        // PARAMETERS    : 
        //   sender (object)   : The source of the event
        //   e (EventArgs)     : Contains the event data
        // RETURNS       : void
        private const int MAX_NUMBER = 10;
        private const int MIN_NUMBER = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            //  Set validation mode to make it supported ASP.NET validators
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            // These loaders should only start up the game on the first page load of the site
            if (!IsPostBack)
            {
                //  effective render a welcome message with the user’s name obtained from the session.
                lblWelcome.Text = $"Hello, {Session["UserName"]}. Let's play!";

                //If the session variable is null, then initialize the game state (it means first time starts the game)
                if (Session["HiddenNumber"] == null)
                {
                    // Generate a random number between 1 and 100 for the user to guess
                    Session["HiddenNumber"] = new Random().Next(MIN_NUMBER, MAX_NUMBER);
                    Session["MinRange"] = MIN_NUMBER;
                    Session["MaxRange"] = MAX_NUMBER;
                }

                // Show the first approximations to the user
                lblRange.Text = $"Guess a number between {Session["MinRange"]} and {Session["MaxRange"]}.";
            }
        }

        // FUNCTION      : btnSubmitGuess_Click
        // DESCRIPTION   :  Manages the event that occurs on click of the Submit Guess button.Confirms the user’s guess, speaks feedback to the user, if guess is correct ends the game or informs user of a new range of numbers to guess from.
        // PARAMETERS    : 
        //   sender (object)   : The source of the event
        //   e (EventArgs)     : Contains the event data
        // RETURNS       : void
        protected void btnSubmitGuess_Click(object sender, EventArgs e)
        {
            // Convert the string to an integer so that it may be compared to a number between 1 and 10
            if (int.TryParse(txtGuess.Text, out int userGuess))
            {
                // Read hidden number and current range values saved in session
                int hiddenNumber = (int)Session["HiddenNumber"];
                int minRange = (int)Session["MinRange"];
                int maxRange = (int)Session["MaxRange"];

                //  Ensure that the guess is within the allowed constrain
                if (userGuess < minRange || userGuess > maxRange)
                {
                    lblFeedback.Text = $"Please guess a number between {minRange} and {maxRange}.";
                }
                else if (userGuess < hiddenNumber)
                {
                    // Modify the get minimum range and add a comment.
                    minRange = userGuess + 1;
                    Session["MinRange"] = minRange;
                    lblFeedback.Text = "Too low!";
                }
                else if (userGuess > hiddenNumber)
                {
                    // To increase the range, and provide feedback subsequently
                    maxRange = userGuess - 1;
                    Session["MaxRange"] = maxRange;
                    lblFeedback.Text = "Too high!";
                }
                else
                {
                    // User guessed right; the game stops with a congratulatory message
                    lblFeedback.Text = "Congratulations! You guessed the correct number!";
                    btnPlayAgain.Visible = true; // Show the Play Again button for restarting
                }

                // Inform the user about the new range which has been guessed
                lblRange.Text = $"Guess a number between {minRange} and {maxRange}.";
            }
            else
            {
                // It is seen that you should inform the user to enter the correct number if parsing has failed.
                lblFeedback.Text = "Please enter a valid number.";
            }
        }

        // FUNCTION      : btnPlayAgain_Click
        // DESCRIPTION   :  Responsible for written work and/or events related with Play Again button. Terminates the current session and takes the user back to the Start page when they want to start a new game.
        // PARAMETERS    : 
        //   sender (object)   : The source of the event
        //   e (EventArgs)     : Contains the event data
        // RETURNS       : void
        protected void btnPlayAgain_Click(object sender, EventArgs e)
        {
            // To set a class session variables to their starting state, clear all session variables.
            Session.Clear();

            // To reset set the user back to Start.aspx where he/she can select START NEW GAME
            Response.Redirect("Start.aspx");
        }
    }
}
