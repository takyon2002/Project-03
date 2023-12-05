using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.AttributeUsage(System.AttributeTargets.Field, AllowMultiple = true)]
public class SeperatorAttibute : PropertyAttribute
{
    // Start is called before the first frame update
    public readonly float Height;
    public readonly float Spacings;

    public SeperatorAttibute(float height=1, float spacing=10)
    {

        height = Height;
        spacing = Spacings;

    }
}
