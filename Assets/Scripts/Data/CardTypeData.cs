using System.Collections.Generic;
using Base;
using UnityEngine;
using UnityEngine.Serialization;

namespace Data
{
    [System.Serializable]
    public sealed class CardTypeData
    {
        [SerializeField] private string _name;
        [SerializeField] private List<StatData> _statsConfig;
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<StatData> StatsConfig
        {
            get { return _statsConfig; }
            set { _statsConfig = value; }
        }
    }
}