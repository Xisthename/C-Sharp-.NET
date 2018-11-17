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
        public delegate void PaintCardHandler(List<Image> dealerImages, List<Image> playerImages);
        public event PaintCardHandler PaintCards;

        public delegate void CountDownTimer();
        public event CountDownTimer StartTimer;

        public delegate void UpdateTextUI(string playerName, string playerHandValue, string dealerHandValue);
        public event UpdateTextUI UpdateText;

        public delegate void UpdateScoreList(string playerName, string playerHandValue, string playerStatus);
        public event UpdateScoreList UpdateScore;


        private Dealer dealer;
        private List<Player> playerList = new List<Player>();
        private DeckManager deckManager = new DeckManager();
        private int currentPlayer;
        public bool PlayerIsPlaying { get; set; }

        public void InitPlayersAndDeck(int players, int decks)
        {
            currentPlayer = 0;
            PlayerIsPlaying = true;
            playerList.Clear();

            for (int i = 0; i < players; i++)
            {
                playerList.Add(new Player("Player " + (i + 1)));
            }
            deckManager.InitDeck(decks);
            deckManager.ShuffleDeck();
            dealer = new Dealer();
        }

        public void ShuffleDeck()
        {
            deckManager.ShuffleDeck();
        }

        public void PlayerHit()
        {
            playerList[currentPlayer].AddCardToHand(deckManager.DrawNextCard());
            PaintCards(GetDealerImages(), GetPlayerImages());
            StartTimer();
        }

        public void PlayerStand()
        {
            playerList[currentPlayer].PlayingState = PlayingStates.Stand;
            CheckIfDealersTurn();
        }

        public void CheckIfDealersTurn()
        {
            UpdateScore(GetPlayerName(), GetPlayerHandValueToString(), GetPlayerState().ToString());

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

        public void DealerPlays()
        {
            dealer.AddCardToHand(deckManager.DrawNextCard());
            StartTimer();
        }

        public void FaceLastCardUp()
        {
            if (PlayerIsPlaying)
            {
                playerList[currentPlayer].FaceUpLastCard();
                PaintCards(GetDealerImages(), GetPlayerImages());

                if (GetPlayerState() == PlayingStates.BlackJack || GetPlayerState() == PlayingStates.Thick)
                {
                    CheckIfDealersTurn();
                }
            }
            else
            {
                dealer.FaceUpLastCard(); // TODO add simple AI logic here
                PaintCards(GetDealerImages(), GetPlayerImages());
            }
            UpdateText(playerList[currentPlayer].GetName(), playerList[currentPlayer].GetHandValueToString(), dealer.GetHandValueToString());
        }

        private List<Image> GetPlayerImages()
        {
            return playerList[currentPlayer].GetImages();
        }

        private string GetPlayerHandValueToString()
        {
            return playerList[currentPlayer].GetHandValueToString();
        }

        private string GetPlayerName()
        {
            return playerList[currentPlayer].GetName();
        }
        private PlayingStates GetPlayerState()
        {
            return playerList[currentPlayer].PlayingState;
        }

        private List<Image> GetDealerImages()
        {
            return dealer.GetImages();
        }
    }
}
