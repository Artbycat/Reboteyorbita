using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(MovingStuff))]
public class MoverEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("pls click"))
        {
            var castedTarget = target as MovingStuff;
            castedTarget.Mover();
            Debug.Log("AAAAAA") ;
        }
    }
    
}
