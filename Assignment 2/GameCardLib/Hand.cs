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
    public class Hand
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        private List<Card> hand = new List<Card>();
        public int HandCount => hand.Count;
        public PlayingStates PlayingState;

        /// <summary>
        /// Adds a new card to the hand
        /// Then the hand value is calculated and a Playingstate is set depending on the new hand value
        /// </summary>
        /// <param name="card"></param>
        public void AddCardToHand(Card card)
        {
            hand.Add(card);

            int countHand = GetHandValue();

            if (countHand == PlayingCards.BlackJack)
            {
                PlayingState = PlayingStates.BlackJack;
            }
            else if (countHand > PlayingCards.BlackJack)
            {
                PlayingState = PlayingStates.Thick;
            }
            else
            {
                PlayingState = PlayingStates.Playing;
            }
        }

        /// <summary>
        /// Returns the value of the hand
        /// </summary>
        /// <returns></returns>
        public int GetHandValue()
        {
            int handValue = 0;

            for (int i = 0; i < HandCount; i++)
            {
                handValue += hand[i].Value;
            }
            return handValue;
        }

        /// <summary>
        /// Returns the card images from the hand
        /// </summary>
        /// <returns></returns>
        public List<Image> GetImages()
        {
            List<Image> images = new List<Image>();

            for (int i = 0; i < HandCount; i++)
            {
                images.Add(hand[i].GetImage());
            }
            return images;
        }

        /// <summary>
        /// Flips over the last card added to the hand
        /// </summary>
        public void FaceUpLastCard()
        {
            hand[HandCount - 1].FaceUp = true;
        }
    }
}
