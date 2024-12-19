using System.Collections.Generic;
using Base;
using UnityEngine;
using UnityEngine.Serialization;

namespace Data
{
    [System.Serializable]
    public sealed class CardTypeData: AssetData
    {
        [SerializeField] private List<StatData> _statsConfig;
        public List<StatData> StatsConfig
        {
            get { return _statsConfig; }
            set { _statsConfig = value; }
        }
    }
}