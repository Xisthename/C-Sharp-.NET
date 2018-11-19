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
    /// 2018-11-08
    /// </summary>
    public class DeckManager : Deck<Card>
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        private List<Card> cardList = new List<Card>();
        private readonly List<int> values = PlayingCards.GetCardsValue();
        private readonly List<Image> images = PlayingCards.GetCardsImage();

        /// <summary>
        /// Creates 52 cards times the parameter "decks" and adds them into a deck (list)
        /// </summary>
        /// <param name="decks"></param>
        public void InitDeck(int decks)
        {
            DeckPile.Clear();
            DiscardPile.Clear();
            cardList.Clear();

            for (int countDecks = 0; countDecks < decks; countDecks++)
            {
                for (int index = 0; index < PlayingCards.Count; index++)
                {
                    cardList.Add(new Card(values[index], images[index]));
                }
            }
            AddCards(cardList);
        }
    }
}
