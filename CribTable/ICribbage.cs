
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLib
{
    public interface ICribbage
    {
        Player DrawCards(ref Player[] players, ref Deck deck, int cardLimit);

        void DealHands(ref Player[] players, ref Deck deck, int cardLimit, bool drawPhase);

        Cards SendToCrib(ref Player player, ref Cards cards, Hand cribHand, ref Panel panel);

        Card PlayCard(ref Player player, ref Card card, ref PegBoardHand pegBoard, ref Panel panel);

        void ClearCards(ref Player[] players);
        
    }
}
