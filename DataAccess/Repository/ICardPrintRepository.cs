using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Types;

namespace DataAccess.Repository
{
    public interface ICardPrintRepository
    {
        CardPrint GetCardPrint(int id);
        CardPrint GetCardPrint(CardSeries series, Rarity rarity, Card card, string title);
        CardPrint CreateOrGetCardPrint(CardSeries series, Rarity rarity, Card card, string title, bool persist = true);
        void UpdateCardPrint(CardPrint updated, bool persist = true);
        void DeleteCardPrint(CardPrint deleted, bool cascade = false);
    }
}