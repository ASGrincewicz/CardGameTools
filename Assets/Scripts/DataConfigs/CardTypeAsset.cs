using Base;
using Data;
using UnityEngine;

namespace DataConfigs
{
    [CreateAssetMenu(fileName = "CardType", menuName = "Card Type", order = 2)]
    public sealed class CardTypeAsset: EditableAsset
    {
        // Name field is Inherited from AssetData
        [SerializeField] private CardTypeData _cardTypeData;
        public CardTypeData CardTypeData
        {
            get { return _cardTypeData; }
            set { _cardTypeData = value; }
        }
    }
}