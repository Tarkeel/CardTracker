using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class BoosterRandomContent : Observable
    {
        public BoosterRandomContent(Booster _booster, CardSeries series, Rarity _rarity)
        {
            booster = _booster;
            cardSeries = series;
            rarity = _rarity;

            if (booster != null) { booster.RandomContent.Add(this); }
            if (cardSeries != null) { cardSeries.RandomContent.Add(this); }
            if (rarity != null) { rarity.RandomContent.Add(this); }
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { VerifyPropertyChange(ref id, ref value); }
        }
        private Booster booster;
        public Booster Booster
        {
            get { return booster; }
            set
            {
                Booster oldBooster = booster;
                if (VerifyPropertyChange(ref booster, ref value))
                {
                    if (oldBooster != null) { oldBooster.RandomContent.Remove(this); }
                    if (booster != null) { booster.RandomContent.Add(this); }
                }
            }
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
                    if (oldSeries != null) { oldSeries.RandomContent.Remove(this); }
                    if (cardSeries != null) { cardSeries.RandomContent.Add(this); }
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
                    if (oldRarity != null) { oldRarity.RandomContent.Remove(this); }
                    if (rarity != null) { rarity.RandomContent.Add(this); }
                }
            }
        }
        private int? quantity;
        public int? Quantity
        {
            get { return quantity; }
            set { VerifyPropertyChange(ref quantity, ref value); }
        }
    }
}
