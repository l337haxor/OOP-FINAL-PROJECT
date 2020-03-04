using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class Hand : CollectionBase
    {
        public Hand()
        {
            Sort();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newCard"></param>
        public void Add(Card newCard)
        {
            InnerList.Add(newCard);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="newCard"></param>
        public void Insert(int index, Card newCard)
        {
            List.Insert(index, newCard);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oldCard"></param>
        public void Remove(Card oldCard)
        {
            List.Remove(oldCard);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aCard"></param>
        /// <returns></returns>
        public bool Contains(Card aCard)
        {
            return List.Contains(aCard);
        }
        
        public void Sort()
        {
            Card lowCard = new Card();
            Console.WriteLine("\n===");

            foreach (Card card in List)
            {
                if (card.GetHashCode() <= card.GetHashCode())
                {
                    
                    Console.WriteLine(card.ToString() + " " + card.GetHashCode());
                    lowCard = card;
                }
            }
            Insert(0, lowCard);
        }
        /// <summary>
        /// Index property for Card List.
        /// </summary>
        /// <param name="pointIndex"></param>
        /// <returns>The index in the List we want.</returns>
        public Card this[int cardIndex]
        {
            get
            {
                return (Card)List[cardIndex];
            }
            set
            {
                List[cardIndex] = value;
            }
        }

        public new IEnumerator GetEnumerator()
        {
            foreach (object card in List)
            {
                System.Diagnostics.Debug.WriteLine("Returning next card...");
                //return the card
                yield return card;
            }
        }
    }
}
