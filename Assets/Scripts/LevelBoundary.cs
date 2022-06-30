using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -4.7f;
    public static float rightSide = 4.77f;
    private float internalLeft;
    private float internalRight;

    private void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
