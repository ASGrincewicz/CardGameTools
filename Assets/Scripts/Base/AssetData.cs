using UnityEngine;

namespace Base
{
    [System.Serializable]
    public class AssetData
    {
        [SerializeField] private string _name;
        
        public virtual string Name { get; set; }
       
    }
}