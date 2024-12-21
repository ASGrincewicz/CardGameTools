using UnityEngine;

namespace Base
{
    [System.Serializable]
    public class AssetData
    {
        [SerializeField] protected string _name;
        
        public virtual string Name { get; set; }
       
    }
}