using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class Game : Observable
    {
        public Game()
        {
            //Initialize collections
            cardTypes = new ObservableTypeCollection();
            factions = new ObservableFactionCollection();
            cards = new ObservableCardCollection();
            attributes = new ObservableAttributeCollection();
            rarities = new ObservableRarityCollection();
            cardSets = new ObservableCardSetCollection();
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { VerifyPropertyChange(ref id, ref value); }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { VerifyPropertyChange(ref name, ref value); }
        }
        private string url;
        public string Url
        {
            get { return url; }
            set { VerifyPropertyChange(ref url, ref value); }
        }
        private string publisher;
        public string Publisher
        {
            get { return publisher; }
            set { VerifyPropertyChange(ref publisher, ref value); }
        }
        private string logoPath;
        public string LogoPath
        {
            get { return logoPath; }
            set { VerifyPropertyChange(ref logoPath, ref value); }
        }
        private string basePath;
        public string BasePath
        {
            get { return basePath; }
            set { VerifyPropertyChange(ref basePath, ref value); }
        }
        private string bannerPath;
        public string BannerPath
        {
            get { return bannerPath; }
            set { VerifyPropertyChange(ref bannerPath, ref value); }
        }

        private ObservableTypeCollection cardTypes;
        public ObservableTypeCollection CardTypes { get { return cardTypes; } }
        private ObservableFactionCollection factions;
        public ObservableFactionCollection Factions { get { return factions; } }
        private ObservableCardCollection cards;
        public ObservableCardCollection Cards { get { return cards; } }
        private ObservableAttributeCollection attributes;
        public ObservableAttributeCollection Attributes { get { return attributes; } }
        private ObservableRarityCollection rarities;
        public ObservableRarityCollection Rarities { get { return rarities; } }
        private ObservableCardSetCollection cardSets;
        public ObservableCardSetCollection CardSets { get { return cardSets; } }
    }
}
