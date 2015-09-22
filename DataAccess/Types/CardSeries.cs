using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class CardSeries : Observable
    {
        public CardSeries(CardSet set)
        {
            cardSet = set;

            if (cardSet != null) { cardSet.CardSeries.Add(this); }

            prints = new ObservablePrintCollection();
            randomContent = new ObservableBoosterRandomContentCollection();
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { VerifyPropertyChange(ref id, ref value); }
        }
        private CardSet cardSet;
        public CardSet CardSet
        {
            get { return cardSet; }
            set
            {
                CardSet oldSet = cardSet;
                if (VerifyPropertyChange(ref cardSet, ref value))
                {
                    if (oldSet != null) { oldSet.CardSeries.Remove(this); }
                    if (cardSet != null) { cardSet.CardSeries.Add(this); }
                }
            }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { VerifyPropertyChange(ref name, ref value); }
        }
        private ObservablePrintCollection prints;
        public ObservablePrintCollection Prints { get; }
        private ObservableBoosterRandomContentCollection randomContent;
        public ObservableBoosterRandomContentCollection RandomContent { get { return randomContent; } }
    }
}
