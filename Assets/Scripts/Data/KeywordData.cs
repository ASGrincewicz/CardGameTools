using Base;
using UnityEngine;

namespace Data
{
    [System.Serializable]
    public sealed class KeywordData: AssetData
    {
        // Name field is inherited.
        [SerializeField] private string _description;
        [SerializeField] private float _weight;

        public KeywordData(string name, string description, float weight = 0.0f)
        {
            _name = name;
            _description = description;
            _weight = weight;
        }
    }
}