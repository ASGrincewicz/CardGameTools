using System.Collections.Generic;
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
        [SerializeField] private CardTypeAsset _cardTypeAsset;
        [ContextMenuItem("Set Stats", "SetStats")]
        [SerializeField] private List<CardStat> _stats;
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

        public CardTypeAsset CardTypeAsset
        {
            get { return _cardTypeAsset; }
            set { _cardTypeAsset = value; }
        }
        public List<CardStat> Stats
        {
            get
            {
                if (_stats == null)
                {
                    SetStats();
                }
                return _stats;
            }
            set { _stats = value; }
        }
        
        public void SetStats()
        {
            if (ReferenceEquals(CardTypeAsset, null))
            {
                return;
            }
            Stats = new List<CardStat>();

            foreach (StatData stat in CardTypeAsset.CardTypeData.StatsConfig)
            {
                Stats.Add(new CardStat(stat.Name,stat.CheckIfStatInRange(0),stat.Description));
            }
        }
    }
}