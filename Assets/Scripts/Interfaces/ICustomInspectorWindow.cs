using UnityEditor;
using UnityEngine;

namespace Interfaces
{
    public interface ICustomInspectorWindow
    {
        protected void OnEnable(){}
        protected void OnDisable(){}
        protected void OnInspectorGUI(){}
        protected void DrawProperties(){}

        protected void DrawLabel((string, string) label)
        {
            DrawLabel(label.Item1, label.Item2);
        }

        protected void DrawLabel(string label)
        {
            GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            EditorGUILayout.LabelField(label,EditorStyles.boldLabel, GUILayout.Width(10), GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            GUILayout.EndHorizontal();
        }

        protected void DrawLabel(string label, string value)
        {
            GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            EditorGUILayout.LabelField(label,EditorStyles.boldLabel, GUILayout.Width(10), GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            EditorGUILayout.LabelField(value,EditorStyles.label, GUILayout.Width(100), GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            GUILayout.EndHorizontal();
        }

        protected void DrawLabel(string label, int value)
        {
            DrawLabel(label, value.ToString());
        }

        protected void DrawLabel(string label, float value)
        {
            DrawLabel(label, value.ToString());
        }

        protected void DrawLabel(string label, bool value)
        {
            DrawLabel(label, value.ToString());
        }

        protected void DrawLabels(string[] labels, string[] values)
        {
            for(int i = 0; i < labels.Length; i++)
            {
                GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
                EditorGUILayout.LabelField(labels[i],EditorStyles.boldLabel, GUILayout.Width(10), GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
                EditorGUILayout.LabelField(values[i],EditorStyles.label, GUILayout.Width(100), GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
                GUILayout.EndHorizontal();
            }
        }

        protected void DrawLabels(string[] labels, int[] values)
        {
            for(int i = 0; i < labels.Length; i++)
            {
                GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
                EditorGUILayout.LabelField(labels[i],EditorStyles.boldLabel, GUILayout.Width(10), GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
                EditorGUILayout.LabelField(values[i].ToString(),EditorStyles.label, GUILayout.Width(100), GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
                GUILayout.EndHorizontal();
            }
        }

        protected void DrawLabels(string[] labels, float[] values)
        {
            for(int i = 0; i < labels.Length; i++)
            {
                GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
                EditorGUILayout.LabelField(labels[i],EditorStyles.boldLabel, GUILayout.Width(10), GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
                EditorGUILayout.LabelField(values[i].ToString(),EditorStyles.label, GUILayout.Width(100), GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
                GUILayout.EndHorizontal();
            }
        }

        protected void DrawLabels(string[] labels, bool[] values)
        {
            for(int i = 0; i < labels.Length; i++)
            {
                GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
                EditorGUILayout.LabelField(labels[i],EditorStyles.boldLabel, GUILayout.Width(10), GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
                EditorGUILayout.LabelField(values[i].ToString(),EditorStyles.label, GUILayout.Width(100), GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
                GUILayout.EndHorizontal();
            }
        }

        protected void DrawLabels(string[] labels)
        {
            for(int i = 0; i < labels.Length; i++)
            {
                GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
                EditorGUILayout.LabelField(labels[i],EditorStyles.boldLabel, GUILayout.Width(10), GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
                GUILayout.EndHorizontal();
            }
        }
        protected void DrawControlButtons(){}

        protected void DrawSeparator()
        {
            GUILayout.Space(10);
            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
            GUILayout.Space(10);
        }

        protected extern SerializedProperty GetProperty(string propertyName);
    }
}
