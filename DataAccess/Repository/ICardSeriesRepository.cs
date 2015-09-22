using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Types;

namespace DataAccess.Repository
{
    public interface ICardSeriesRepository
    {
        CardSeries GetCardSeries(int id);
        CardSeries GetCardSeries(CardSet cardSet, string title);
        CardSeries CreateOrGetCardSeries(CardSet cardSet, string title, bool persist = true);
        void UpdateCardSeries(CardSeries updated, bool persist = true);
        void DeleteCardSeries(CardSeries deleted, bool cascade = false);
    }
}