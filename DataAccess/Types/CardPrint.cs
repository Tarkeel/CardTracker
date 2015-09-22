using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class CardPrint : Observable
    {
        public CardPrint(CardSeries series, Rarity _rarity, Card _card)
        {
            cardSeries = series;
            rarity = _rarity;
            card = _card;

            if (cardSeries != null) { cardSeries.Prints.Add(this); }
            if (rarity != null) { rarity.Prints.Add(this); }
            if (card != null) { card.Prints.Add(this); }

            fixedContent = new ObservableBoosterFixedContentCollection();
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { VerifyPropertyChange(ref id, ref value); }
        }
        private CardSeries cardSeries;
        public CardSeries CardSeries
        {
            get { return cardSeries; }
            set
            {
                CardSeries oldSeries = cardSeries;
                if (VerifyPropertyChange(ref cardSeries, ref value))
                {
                    if (oldSeries != null) { oldSeries.Prints.Remove(this); }
                    if (cardSeries != null) { cardSeries.Prints.Add(this); }
                }
            }
        }
        private Rarity rarity;
        public Rarity Rarity
        {
            get { return rarity; }
            set
            {
                Rarity oldRarity = rarity;
                if (VerifyPropertyChange(ref rarity, ref value))
                {
                    if (oldRarity != null) { oldRarity.Prints.Remove(this); }
                    if (rarity != null) { rarity.Prints.Add(this); }
                }
            }
        }
        private Card card;
        public Card Card
        {
            get { return card; }
            set
            {
                Card oldCard = card;
                if (VerifyPropertyChange(ref card, ref value))
                {
                    if (oldCard != null) { oldCard.Prints.Remove(this); }
                    if (card != null) { card.Prints.Add(this); }
                }
            }
        }
        private int? slot;
        public int? Slot
        {
            get { return slot; }
            set { VerifyPropertyChange(ref slot, ref value); }
        }
        private string artist;
        public string Artist
        {
            get { return artist; }
            set { VerifyPropertyChange(ref artist, ref value); }
        }
        private string imagePath;
        public string ImagePath
        {
            get { return imagePath; }
            set { VerifyPropertyChange(ref imagePath, ref value); }
        }

        private ObservableBoosterFixedContentCollection fixedContent;
        public ObservableBoosterFixedContentCollection FixedContent { get { return fixedContent; } }
    }
}
