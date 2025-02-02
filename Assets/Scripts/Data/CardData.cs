using Base;
using UnityEngine;

namespace Data
{
    [System.Serializable]
    public sealed class CardData
    {
        [SerializeField] private string _name;
        [SerializeField] private Texture2D _artwork;
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Texture2D Artwork
        {
            get { return _artwork; }
            set { _artwork = value; }
        }
    }
}