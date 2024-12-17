using Base;
using UnityEditor;
using UnityEngine;

namespace Interfaces
{
    public interface ICustomEditorWindow
    { protected EditableAsset LoadedAsset { get; set;}
        protected Rect MainAreaRect { get; set; }
        protected Vector2 ScrollPosition { get; set; }
        
        public static void Init(){}
        protected void OnEnable();
        protected void OnDisable();
        protected void OpenInEditor(EditableAsset asset);
        protected void OnGUI();
        protected void SetupAreaRects();
        protected void DrawMainArea();
        protected void DrawEditableFields();
        protected void DrawControlButtons();
        
        protected void LoadAssetData(EditableAsset asset);

    }
}