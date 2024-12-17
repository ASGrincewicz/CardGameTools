using Base;
using Data;
using UnityEngine;

namespace DataConfigs
{
    [CreateAssetMenu(fileName = "Rarity", menuName = "Rarity", order = 4)]
    public sealed class RarityAsset: EditableAsset
    {
        [SerializeField] private RarityData _rarityData;
        public RarityData RarityData
        {
            get { return _rarityData; }
            set { _rarityData = value; }
        }
    }
}