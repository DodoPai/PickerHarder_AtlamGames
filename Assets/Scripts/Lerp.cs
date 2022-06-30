using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public int a;
    [SerializeField] CalculateBallAmount ballNumber;
    [SerializeField] PlatformTypes platformnEW;
    public GameObject platform;

    private Vector3 startPos;
    private Vector3 endPos;
    private float distance = 20f;
    private float lerpTime = 5;
    private float currentLerpTime;
    void Start()
    {
        startPos = platform.transform.position;
        endPos = platform.transform.position + Vector3.up * distance;

    }

    void Update()
    {
        if(a ==5)
        {
            currentLerpTime += Time.deltaTime;
            if (currentLerpTime >= lerpTime)
            {
                currentLerpTime = lerpTime;
            }
            float Perc = currentLerpTime / lerpTime;
            platform.transform.position = Vector3.Lerp(startPos, endPos, Perc);
        }
        


    }
}
