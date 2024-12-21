using System.Collections.Generic;
using Base;
using UnityEditor;
using UnityEngine;

namespace DataConfigs
{
    [CreateAssetMenu(fileName = "AssetManager", menuName = "Asset Manager", order = 0)]
    public class AssetManager: ScriptableObject
    {
        [SerializeField] private List<EditableAsset> _assets;
        public List<EditableAsset> Assets
        {
            get { return _assets; }
            set { _assets = value; }
        }

        public void AddAsset(EditableAsset asset)
        {
            _assets.Add(asset);
        }

        public void RemoveAsset(EditableAsset asset)
        {
            _assets.Remove(asset);
        }

        public void ClearAssets()
        {
            _assets.Clear();
        }
        
        public void SortAssets()
        {
            _assets.Sort();
        }

        public void AddAssetViaGUID(string guid)
        {
            EditableAsset asset = GetAssetViaGUID(guid);
            if (asset != null)
            {
                AddAsset(asset);
            }
        }

        public void RemoveAssetViaGUID(string guid)
        {
            EditableAsset asset = GetAssetViaGUID(guid);
            if (asset != null)
            {
                RemoveAsset(asset);
            }
        }

        private EditableAsset GetAssetViaGUID(string guid)
        {
            EditableAsset asset = AssetDatabase.LoadAssetAtPath<EditableAsset>(AssetDatabase.GUIDToAssetPath(guid));
            if (asset != null)
            {
                return asset;
            }   
            Debug.LogWarning($"Asset with GUID {guid} could not be found.");
            return null;
            
        }
    }
}