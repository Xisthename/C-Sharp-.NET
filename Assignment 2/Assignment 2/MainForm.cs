using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameCardLib;
using UtilitiesLib;

namespace Assignment_2
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-11-07
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        private GameHandler gameHandler = new GameHandler();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the application starts some events are added to the GameHandler class and then the GUI is initialize
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            gameHandler.PaintCards += new GameHandler.PaintCardHandler(PaintCards);
            gameHandler.StartTimer += new GameHandler.CountDownTimer(StartTimer);
            gameHandler.CardDisplayTime += new GameHandler.DisplayTimer(CardDisplayTime);
            gameHandler.UpdateText += new GameHandler.UpdateTextUI(UpdateText);
            gameHandler.UpdateScore += new GameHandler.UpdateScoreList(UpdateScore);
            gameHandler.UpdateFinalScore += new GameHandler.FinalScores(UpdateFinalScore);
            InitGUI();
        }

        /// <summary>
        /// Disables some buttons for the user
        /// </summary>
        private void InitGUI()
        {
            EnableButtons(false);
        }

        /// <summary>
        /// Disables or Enables buttons for the user
        /// </summary>
        /// <param name="enableButtons"></param>
        private void EnableButtons(bool enableButtons)
        {
            startGameButton.Enabled = !enableButtons;
            shuffleButton.Enabled = enableButtons;
            hitButton.Enabled = enableButtons;
            standButton.Enabled = enableButtons;
            endGameButton.Enabled = enableButtons;
        }

        /// <summary>
        /// When a new game is started some relevant buttons is enabled, how many players and decks are sent to the GameHandler class
        /// After the players and deck has been set up the game starts off with player 1 getting a card to its hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startGameButton_Click(object sender, EventArgs e)
        {
            startGameButton.Enabled = false;
            endGameButton.Enabled = true;
            gameHandler.InitPlayersAndDeck((int)playersNumericUpDown.Value, (int)decksNumericUpDown.Value);
            gameHandler.PlayerHit(); // The player always starts out with a card in their hand
        }

        /// <summary>
        /// Shuffles the remaning cards in the deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shuffleButton_Click(object sender, EventArgs e)
        {
            gameHandler.ShuffleDeck();
        }

        /// <summary>
        /// The current player will get another card to its hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hitButton_Click(object sender, EventArgs e)
        {
            gameHandler.PlayerHit();
        }

        /// <summary>
        /// The current player wish to keep its hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void standButton_Click(object sender, EventArgs e)
        {
            gameHandler.PlayerStand();
        }

        /// <summary>
        /// Ends thecurrent game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endGameButton_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
            displayTimer.Stop();
            EnableButtons(false);
            cardsLeftLabel.Text = "Cards left in Deck:";
            dealerHandLabel.Text = "Hand Value: ";
            playerHandLabel.Text = dealerHandLabel.Text;
            playerLabel.Text = "Player";
            dealerImages.Clear();
            playerImages.Clear();
            scoreTable.Rows.Clear();
            dealerBox.Invalidate();
            playerBox.Invalidate();
        }

        /// <summary>
        /// When the PaintCards event has been raised from the GameHandler class the images from the dealer's hand and 
        /// from the current player's hand is received. Then the paint events for the dealer and the player are raised
        /// </summary>
        /// <param name="dealerImages"></param>
        /// <param name="playerImages"></param>
        private void PaintCards(List<Image> dealerImages, List<Image> playerImages)
        {
            this.dealerImages = dealerImages;
            this.playerImages = playerImages;
            dealerBox.Refresh();
            playerBox.Refresh();
        }

        /// <summary>
        /// Delecering necessary variables which is used to paint out the cards at certain coordinates
        /// </summary>
        private int column = 0;
        private int xSpace = 50;
        private int ySpace = 200;
        private int extraSpace = 0;
        private bool switchRow = false;
        private List<Image> dealerImages = new List<Image>();
        private List<Image> playerImages = new List<Image>();


        /// <summary>
        /// Paints out the cards in the dealer's hand in a user friendly spectrum 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dealerBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int index = 0; index < dealerImages.Count; index++)
            {
                if (index > 5 && !switchRow)
                {
                    switchRow = true;
                    column = 0;
                    ySpace = 50;
                    extraSpace = 25;
                }
                column++;
                g.DrawImage(dealerImages[index], column * xSpace + extraSpace, ySpace, PlayingCards.Width, PlayingCards.Height);
            }
            ResetPaintVariables();
        }

        /// <summary>
        /// Paints out the cards in the current player's hand in a user friendly spectrum 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playerBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int index = 0; index < playerImages.Count; index++)
            {
                if (index > 5 && !switchRow)
                {
                    switchRow = true;
                    column = 0;
                    ySpace = 50;
                    extraSpace = 25;
                }
                column++;
                g.DrawImage(playerImages[index], column * xSpace + extraSpace, ySpace, PlayingCards.Width, PlayingCards.Height);
            }
            ResetPaintVariables();
        }

        /// <summary>
        /// Used to reset some values used when painting out the cards on the screen
        /// </summary>
        private void ResetPaintVariables()
        {
            column = 0;
            xSpace = 50;
            ySpace = 200;
            extraSpace = 0;
            switchRow = false;
        }

        /// <summary>
        /// When the UpdateText event has been raised from the GameHandler class the cards left, the playerName, 
        /// hand value of the dealer and the player are displayed to the user
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="playerHandValue"></param>
        /// <param name="dealerHandValue"></param>
        private void UpdateText(int cardsLeft, string playerName, int playerHandValue, int dealerHandValue)
        {
            cardsLeftLabel.Text = "Cards left in Deck: " + cardsLeft;
            playerLabel.Text = playerName;
            playerHandLabel.Text = "Hand Value: " + playerHandValue;
            dealerHandLabel.Text = "Hand Value: " + dealerHandValue;
        }

        /// <summary>
        /// When the UpdateScore event has been raised from the GameHandler class the playerName, 
        /// hand value of the player and the player's current state are displayed to the user via adding them as a row in the scoreTable
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="playerHandValue"></param>
        /// <param name="playerState"></param>
        private void UpdateScore(string playerName, int playerHandValue, string playerState)
        {
            bool found = false;

            for (int i = 0; i < scoreTable.Rows.Count; i++)
            {
                if (scoreTable.Rows[i].Cells[0].Value.Equals(playerName))
                {
                    scoreTable.Rows.RemoveAt(i);
                    scoreTable.Rows.Insert(i, playerName, playerHandValue, playerState);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                scoreTable.Rows.Add(playerName, playerHandValue, playerState);
            }
        }

        /// <summary>
        /// Adds the dealers details into the scoreTable
        /// </summary>
        /// <param name="dealerName"></param>
        /// <param name="dealerHandValue"></param>
        /// <param name="dealerResult"></param>
        private void UpdateFinalScore(string dealerName, int dealerHandValue, string dealerResult)
        {
            scoreTable.Rows.Insert(0, dealerName, dealerHandValue, dealerResult);
        }

        /// <summary>
        /// When the StartTimer event has been raised from the GameHandler class some buttons are disabled and
        /// a timer is started
        /// </summary>
        private void StartTimer()
        {
            hitButton.Enabled = false;
            standButton.Enabled = false;
            shuffleButton.Enabled = false;
            countdownTimer.Start();
        }

        /// <summary>
        /// When the countdownTimer_Tick is raised the timer is stopped
        /// Some buttons are going to be enabled to the user again if it's a user that is playing
        /// Then the method FaceLastCardUp is called upon which shows the last card from either the player or the dealer depending on who is currently playing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            countdownTimer.Stop();

            if (gameHandler.PlayerIsPlaying && gameHandler.GetPlayerState() == PlayingStates.Playing)
            {
                hitButton.Enabled = true;
                standButton.Enabled = true;
                shuffleButton.Enabled = true;
            }
            gameHandler.FlipLastCardUp();
        }

        /// <summary>
        /// When the CardDisplayTime event has been raised from the GameHandler class a timer is started
        /// </summary>
        private void CardDisplayTime()
        {
            displayTimer.Start();
        }

        /// <summary>
        /// When the displayTimer_Tick is raised the timer is stopped
        /// Then either CheckIfDealersTurn or CheckIfGameIsOver is called upon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayTimer_Tick(object sender, EventArgs e)
        {
            displayTimer.Stop();

            if (gameHandler.PlayerIsPlaying)
            {
                if (gameHandler.GetPlayerState() == PlayingStates.BlackJack || gameHandler.GetPlayerState() == PlayingStates.Thick)
                {
                    gameHandler.CheckIfDealersTurn();
                }
            }
            else
            {
                gameHandler.CheckIfGameIsOver();
            }
        }
    }
}