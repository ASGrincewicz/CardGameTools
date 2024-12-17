using Base;
using Data;
using UnityEngine;

namespace DataConfigs
{
    [CreateAssetMenu(fileName = "Card", menuName = "Card", order = 1)]
    public sealed class CardAsset: EditableAsset
    {
        [SerializeField] private CardData _cardData;
        [SerializeField] private RarityAsset _rarityAsset;
        public  CardData CardData
        {
            get { return _cardData; }
            set { _cardData = value; }
        }
        public RarityAsset RarityAsset
        {
            get { return _rarityAsset; }
            set { _rarityAsset = value; }
        }
    }
}