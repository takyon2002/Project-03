using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(SeperatorAttibute))]
public class SeperatorDrawer : DecoratorDrawer
{
    // Start is called before the first frame update
    public override void OnGUI(Rect position)
    {
        SeperatorAttibute seperatorAttibute = attribute as SeperatorAttibute;
        Rect seperatorRect = 
            new Rect(position.xMin, position.yMin + seperatorAttibute.Spacings, position.width,
            seperatorAttibute.Height);
        EditorGUI.DrawRect(seperatorRect, Color.white);
    }
    
}
