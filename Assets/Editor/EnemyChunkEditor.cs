using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//[CustomPropertyDrawer(typeof(EnemyChunk))]
public class EnemyChunkEditor : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        position.Set(position.x, position.y, position.width, position.height + EditorGUI.GetPropertyHeight(property, label));
        EditorGUI.BeginProperty(position, label, property);
        EditorGUI.PropertyField(position, property, label);
        EditorGUI.EndProperty();
        //position.Set(position.x, position.y + EditorGUIUtility.singleLineHeight, position.width, position.height);
        //var indexProperty = property.FindPropertyRelative("Index");
        //EditorGUI.PropertyField(position, property.FindPropertyRelative("Index"), new GUIContent("Index"), true);

    }
}
