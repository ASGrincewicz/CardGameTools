using UnityEngine;

namespace Data
{
    [System.Serializable]
    public sealed class CardStat
    {
        [SerializeField] private string _name;
        [SerializeField] private int _value;
        [SerializeField] private string _description;

        public CardStat(string name, int value, string description = "")
        {
            _name = name;
            _value = value;
            _description = description;
        }
    }
}