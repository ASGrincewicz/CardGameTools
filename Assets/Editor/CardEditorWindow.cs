using Base;
using Interfaces;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class CardEditorWindow : EditorWindow, ICustomEditorWindow
    {
        private static EditorWindow _window;
        private static string Title { get; set; } = "Card Editor";

        EditableAsset ICustomEditorWindow.LoadedAsset { get; set; }

        Rect ICustomEditorWindow.MainAreaRect { get; set; }

        Vector2 ICustomEditorWindow.ScrollPosition { get; set; }

        [MenuItem("Card Game Tools/Card Editor")]
        public static void Init()
        {
            _window = GetWindow<CardEditorWindow>(Title);
        }

        void ICustomEditorWindow.OnEnable()
        {
            throw new System.NotImplementedException();
        }

        void ICustomEditorWindow.OnDisable()
        {
            throw new System.NotImplementedException();
        }

        void ICustomEditorWindow.OpenInEditor(EditableAsset asset)
        {
            throw new System.NotImplementedException();
        }
        void ICustomEditorWindow.OnGUI()
        {
            throw new System.NotImplementedException();
        }

        void ICustomEditorWindow.SetupAreaRects()
        {
            throw new System.NotImplementedException();
        }

        void ICustomEditorWindow.DrawMainArea()
        {
            throw new System.NotImplementedException();
        }

        void ICustomEditorWindow.DrawEditableFields()
        {
            throw new System.NotImplementedException();
        }

        void ICustomEditorWindow.DrawControlButtons()
        {
            throw new System.NotImplementedException();
        }

        void ICustomEditorWindow.LoadAssetData(EditableAsset asset)
        {
            throw new System.NotImplementedException();
        }
    }
}