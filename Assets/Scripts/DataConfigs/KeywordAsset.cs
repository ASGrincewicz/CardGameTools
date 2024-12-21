using Base;
using Data;
using UnityEngine;

namespace DataConfigs
{
    [CreateAssetMenu(fileName = "Keyword", menuName = "Keyword", order = 1)]
    public class KeywordAsset: EditableAsset
    {
        [SerializeField] private KeywordData _keywordData;
        public KeywordData KeywordData
        {
            get { return _keywordData; }
            set { _keywordData = value; }
        }
    }
}