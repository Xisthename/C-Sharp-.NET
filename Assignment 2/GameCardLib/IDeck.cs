using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-11-08
    /// </summary>

    /// <summary>
    /// Delecering a general interface with variables and methods
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IDeck<T>
    {
        int Count { get; }
        List<T> DeckPile { get; set; }
        List<T> DiscardPile { get; set; }

        void AddCards(List<T> cardList);
        void ReShuffleDeck();
        void SwapCards(List<T> data, int a, int b);
        T DrawNextCard();
    }
}
