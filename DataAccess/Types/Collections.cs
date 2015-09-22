using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

namespace DataAccess.Types
{
    public class ObservableGameCollection : ObservableCollection<Game> { }
    public class ObservableTypeCollection : ObservableCollection<CardType> { }
    public class ObservableFactionCollection : ObservableCollection<Faction> { }
    public class ObservableCardCollection : ObservableCollection<Card> { }
    public class ObservableAttributeCollection : ObservableCollection<CardAttribute> { }
    public class ObservableAttributeValueCollection : ObservableCollection<CardAttributeValue> { }
    public class ObservableRarityCollection : ObservableCollection<Rarity> { }
    public class ObservableCardSetCollection : ObservableCollection<CardSet> { }
    public class ObservableCardSeriesCollection : ObservableCollection<CardSeries> { }
    public class ObservablePrintCollection : ObservableCollection<CardPrint> { }
    public class ObservableBoosterCollection : ObservableCollection<Booster> { }
    public class ObservableBoosterFixedContentCollection : ObservableCollection<BoosterFixedContent> { }
    public class ObservableBoosterRandomContentCollection : ObservableCollection<BoosterRandomContent> { }
}
