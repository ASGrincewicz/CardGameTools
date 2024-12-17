using Base;
using UnityEngine;

namespace Data
{
    [System.Serializable]
    public sealed class CardData: AssetData
    {
        // Name field is Inherited from AssetData
        [SerializeField] private Texture2D _artwork;
        public Texture2D Artwork
        {
            get { return _artwork; }
            set { _artwork = value; }
        }
    }
}