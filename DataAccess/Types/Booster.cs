using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class Booster : Observable
    {
        public Booster(CardSet set)
        {
            cardSet = set;
            if (cardSet != null) { cardSet.Boosters.Add(this); }

            fixedContent = new ObservableBoosterFixedContentCollection();
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
                    if (oldSet != null) { oldSet.Boosters.Remove(this); }
                    if (cardSet != null) { cardSet.Boosters.Add(this); }
                }
            }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { VerifyPropertyChange(ref name, ref value); }
        }
        private string code;
        public string Code
        {
            get { return code; }
            set { VerifyPropertyChange(ref code, ref value); }
        }
        private string imagePath;
        public string ImagePath
        {
            get { return imagePath; }
            set { VerifyPropertyChange(ref imagePath, ref value); }
        }

        private ObservableBoosterFixedContentCollection fixedContent;
        public ObservableBoosterFixedContentCollection FixedContent { get { return fixedContent; } }
        private ObservableBoosterRandomContentCollection randomContent;
        public ObservableBoosterRandomContentCollection RandomContent { get { return randomContent; } }
    }
}
