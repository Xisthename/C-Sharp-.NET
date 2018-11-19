using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitiesLib;

namespace GameCardLib
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-11-09
    /// </summary>
    public class GameHandler
    {
        /// <summary>
        /// Delecering necessary delegates and events
        /// </summary>
        /// <param name="dealerImages"></param>
        /// <param name="playerImages"></param>
        public delegate void PaintCardHandler(List<Image> dealerImages, List<Image> playerImages);
        public event PaintCardHandler PaintCards;

        public delegate void CountDownTimer();
        public event CountDownTimer StartTimer;

        public delegate void DisplayTimer();
        public event DisplayTimer CardDisplayTime;

        public delegate void UpdateTextUI(int cardsLeft, string playerName, int playerHandValue, int dealerHandValue);
        public event UpdateTextUI UpdateText;

        public delegate void UpdateScoreList(string playerName, int playerHandValue, string playerState);
        public event UpdateScoreList UpdateScore;

        public delegate void FinalScores(string dealerName, int dealerHandValue, string dealerResult);
        public event FinalScores UpdateFinalScore;

        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        private Dealer dealer;
        private List<Player> playerList = new List<Player>();
        private DeckManager deckManager = new DeckManager();
        private int currentPlayer;
        private int dealerLosses;
        private int dealerWins;
        public bool PlayerIsPlaying { get; set; }

        /// <summary>
        /// Constructor that takes in how many players and decks that will be used
        /// The players are created, so is the deck and a deler is created aswell
        /// </summary>
        /// <param name="players"></param>
        /// <param name="decks"></param>
        public void InitPlayersAndDeck(int players, int decks)
        {
            currentPlayer = 0;
            dealerLosses = 0;
            dealerWins = 0;
            PlayerIsPlaying = true;
            playerList.Clear();

            for (int i = 0; i < players; i++)
            {
                playerList.Add(new Player("Player " + (i + 1)));
            }
            deckManager.InitDeck(decks);
            deckManager.ShuffleDeck();
            dealer = new Dealer("Dealer");
        }

        /// <summary>
        /// Shuffles the remaining cards in the deck
        /// </summary>
        public void ShuffleDeck()
        {
            deckManager.ShuffleDeck();
        }

        /// <summary>
        /// The current player ask and receives another card to their hand 
        /// </summary>
        public void PlayerHit()
        {
            playerList[currentPlayer].AddCardToHand(deckManager.DrawNextCard());
            PaintCards(GetDealerImages(), GetPlayerImages());
            StartTimer();
        }

        /// <summary>
        /// The current player wish to stay at the current hand value
        /// </summary>
        public void PlayerStand()
        {
            playerList[currentPlayer].PlayingState = PlayingStates.Stand;
            UpdateScore(GetPlayerName(), GetPlayerHandValue(), GetPlayerState().ToString());
            CheckIfDealersTurn();
        }

        /// <summary>
        /// Checks if a new player should start playing or it's the dealers turn to play
        /// </summary>
        public void CheckIfDealersTurn()
        {
            if (currentPlayer + 1 != playerList.Count)
            {
                currentPlayer++;
                PlayerHit();
            }
            else
            {
                PlayerIsPlaying = false;
                DealerPlays();
            }
        }

        /// <summary>
        /// The dealer adds a card to it's hand
        /// </summary>
        private void DealerPlays()
        {
            dealer.AddCardToHand(deckManager.DrawNextCard());
            PaintCards(GetDealerImages(), GetPlayerImages());
            StartTimer();
        }

        /// <summary>
        /// The last card in a players or dealers hand is flipped up
        /// </summary>
        public void FlipLastCardUp()
        {
            UpdateText(deckManager.Count, playerList[currentPlayer].Name, playerList[currentPlayer].GetHandValue(), dealer.GetHandValue());

            if (PlayerIsPlaying)
            {
                playerList[currentPlayer].FaceUpLastCard();
                PaintCards(GetDealerImages(), GetPlayerImages());

                if (GetPlayerState() == PlayingStates.BlackJack || GetPlayerState() == PlayingStates.Thick)
                {
                    UpdateScore(GetPlayerName(), GetPlayerHandValue(), GetPlayerState().ToString());
                    CardDisplayTime();
                }
            }
            else
            {
                dealer.FaceUpLastCard();
                PaintCards(GetDealerImages(), GetPlayerImages());
                CardDisplayTime();
            }
        }

        /// <summary>
        /// Checks if the dealer is done and then sums up the whole turn to the user in a list
        /// </summary>
        public void CheckIfGameIsOver()
        {
            if (dealer.GetHandValue() < PlayingCards.MinStopValueForDealer)
            {
                DealerPlays();
            }
            else
            {
                for (int i = 0; i < playerList.Count; i++)
                {
                    Player player = playerList[i];

                    if (player.PlayingState == PlayingStates.Thick)
                    {
                        player.PlayingState = PlayingStates.Lost;
                    }
                    else if (player.PlayingState == PlayingStates.BlackJack || dealer.PlayingState == PlayingStates.Thick || player.GetHandValue() > dealer.GetHandValue())
                    {
                        dealerLosses++;
                        player.PlayingState = PlayingStates.Won;
                    }
                    else
                    {
                        player.PlayingState = PlayingStates.Lost;
                    }
                    UpdateScore(player.Name, player.GetHandValue(), player.PlayingState.ToString());
                }
                dealerWins = playerList.Count - dealerLosses;
                UpdateFinalScore(dealer.Name, dealer.GetHandValue(), "Wins: " + dealerWins + " & Losses: " + dealerLosses);
            }
        }

        /// <summary>
        /// Returns the current players images
        /// </summary>
        /// <returns></returns>
        private List<Image> GetPlayerImages()
        {
            return playerList[currentPlayer].GetImages();
        }

        /// <summary>
        /// Returns the current players hand value
        /// </summary>
        /// <returns></returns>
        private int GetPlayerHandValue()
        {
            return playerList[currentPlayer].GetHandValue();
        }

        /// <summary>
        /// Returns the current players name
        /// </summary>
        /// <returns></returns>
        private string GetPlayerName()
        {
            return playerList[currentPlayer].Name;
        }

        /// <summary>
        /// Returns the current players playing state
        /// </summary>
        /// <returns></returns>
        public PlayingStates GetPlayerState()
        {
            return playerList[currentPlayer].PlayingState;
        }

        /// <summary>
        /// Returns the dealers images
        /// </summary>
        /// <returns></returns>
        private List<Image> GetDealerImages()
        {
            return dealer.GetImages();
        }
    }
}
