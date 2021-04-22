using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BoxingGlove))]
public class BoxingGloveGUI : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        BoxingGlove glove = (BoxingGlove)target;
        if (GUILayout.Button("Attack!"))
        {
            glove.Attack();
        }
    }
}
