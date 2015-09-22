using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class BoosterFixedContent : Observable
    {
        public BoosterFixedContent(Booster _booster, CardPrint print)
        {
            booster = _booster;
            cardPrint = print;

            if (booster != null) { booster.FixedContent.Add(this); }
            if (cardPrint != null) { cardPrint.FixedContent.Add(this); }
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
                    if (oldBooster != null) { oldBooster.FixedContent.Remove(this); }
                    if (booster != null) { booster.FixedContent.Add(this); }
                }
            }
        }
        private CardPrint cardPrint;
        public CardPrint CardPrint
        {
            get { return cardPrint; }
            set
            {
                CardPrint oldPrint = cardPrint;
                if (VerifyPropertyChange(ref cardPrint, ref value))
                {
                    if (oldPrint != null) { oldPrint.FixedContent.Remove(this); }
                    if (cardPrint != null) { cardPrint.FixedContent.Add(this); }
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
