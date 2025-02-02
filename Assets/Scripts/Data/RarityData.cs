using Base;
using UnityEngine;

namespace Data
{
    [System.Serializable]
    public sealed class RarityData
    {
        [SerializeField] private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}