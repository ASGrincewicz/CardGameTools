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
        [SerializeField] private string _cardName;
        [SerializeField] private Texture2D _cardArtwork;
        [SerializeField] private RarityData _rarityData;
        [SerializeField] private string _rarityName;
        [SerializeField] private CardTypeData _cardTypeData;
        [SerializeField] private string _cardTypeName;
        [ContextMenuItem("Set Stats", "SetStats")]
        [SerializeField] private List<CardStat> _stats;
        public  CardData CardData
        {
            get { return _cardData; }
            set { _cardData = value; }
        }
        
        public string CardName
        {
            get { return _cardData.Name; }
            set { _cardData.Name = value; }
        }
        
        public Texture2D CardArtwork
        {
            get { return _cardData.Artwork; }
            set { _cardData.Artwork = value; }
        }
        public RarityData RarityData
        {
            get { return _rarityData; }
            set { _rarityData = value; }
        }

        public string RarityName
        {
            get { return RarityData.Name; }
            set { RarityData.Name = value; }
        }

        public CardTypeData CardTypeData
        {
            get { return _cardTypeData; }
            set { _cardTypeData = value; }
        }
        
        public string CardTypeName
        {
            get { return CardTypeData.Name; }
            set { CardTypeData.Name = value; }
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
            if (ReferenceEquals(CardTypeData, null))
            {
                return;
            }
            Stats = new List<CardStat>();

            foreach (StatData stat in CardTypeData.StatsConfig)
            {
                Stats.Add(new CardStat(stat.Name,stat.CheckIfStatInRange(0),stat.Description));
            }
        }

        public CardData GetCardData()
        {
            return _cardData;
        }

        public string GetCardName()
        {
            return _cardName;
        }
        
        public Texture2D GetCardArtwork()
        {
            return _cardArtwork;
        }

        public string GetRarityName()
        {
            return RarityName;
        }

        public string GetCardTypeName()
        {
            Debug.Log(CardTypeName);
            return CardTypeName;
        }

        public void GetInfo()
        {
            GetCardData();
            GetCardName();
            GetCardArtwork();
            GetRarityName();
            GetCardTypeName();
            Debug.Log($"Card Info{CardTypeName}");
        }
    }
}