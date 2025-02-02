using Data;
using DataConfigs;
using Interfaces;
using UnityEditor;
using UnityEngine;

namespace Editor.Inspectors
{
    [CustomEditor(typeof(CardAsset))]
    public class CardAssetInspector: CustomInspectorWindow
    {
        private const string CardDataPropertyName = "_cardData";
        private const string CardNamePropertyName = "_cardName";
        private const string CardArtworkPropertyName = "_cardArtwork";
        private const string RarityAssetPropertyName = "_rarityAsset";
        private const string RarityNamePropertyName = "_rarityName";
        private const string CardTypeAssetPropertyName = "_cardTypeAsset";
        private const string CardTypeNamePropertyName = "_cardTypeName";
        private const string StatsPropertyName = "_stats";
        
        private SerializedProperty CardData { get; set; }
        
        private SerializedProperty CardName { get; set; }
        
        private SerializedProperty CardArtwork { get; set; }
        private SerializedProperty RarityAsset { get; set; }
        private SerializedProperty RarityName { get; set; }
        private SerializedProperty CardTypeAsset { get; set; }
        private SerializedProperty CardTypeName { get; set; }
        private SerializedProperty Stats { get; set; }
        protected override void OnEnable()
        {
            //CardData = serializedObject.FindProperty(CardDataPropertyName);
            CardName = serializedObject.FindProperty(CardNamePropertyName);
            CardArtwork = serializedObject.FindProperty(CardArtworkPropertyName);
            RarityAsset = serializedObject.FindProperty(RarityAssetPropertyName);
            RarityName = serializedObject.FindProperty(RarityNamePropertyName);
            CardTypeAsset = serializedObject.FindProperty(CardTypeAssetPropertyName);
            CardTypeName = serializedObject.FindProperty(CardTypeNamePropertyName);
            Stats = serializedObject.FindProperty(StatsPropertyName);
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            serializedObject.Update();
            CardAsset asset = (CardAsset) target;
           //asset.GetInfo();
            GUILayout.BeginVertical(GUILayout.Width(300));
            GUILayout.BeginHorizontal(EditorStyles.toolbar);
            DrawControlButtons();
            GUILayout.EndHorizontal();
            DrawProperties();
            GUILayout.EndVertical();
            serializedObject.ApplyModifiedProperties();
            
        }
        protected override void DrawProperties()
        {
           DrawLabel("Card Name", $"{CardName.stringValue}");
           DrawLabel("Rarity", $"{RarityName.stringValue}");
           DrawLabel("Card Type", $"{CardTypeName.stringValue}");
           
        }

        protected override void DrawControlButtons()
        {
            if (GUILayout.Button("Test"))
            {
                Debug.Log("test");
            }
        }
    }
}