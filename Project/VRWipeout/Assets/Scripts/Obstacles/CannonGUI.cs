using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Cannon))]
public class CannonGUI : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Cannon cannonScript = (Cannon)target;
        if(GUILayout.Button("Fire Cannon"))
        {
            cannonScript.FireCannon();
        }
    }
}
