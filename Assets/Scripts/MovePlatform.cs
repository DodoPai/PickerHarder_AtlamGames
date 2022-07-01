using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public GameObject platform;

    private Vector3 startPos;
    private Vector3 endPos;

    [SerializeField] private PlatformTypes scriptableObject;

    private float lerpTime = 2;
    private float currentLerpTime = 0;

   

    private void Start()
    {
        scriptableObject.isTrue = false;
        startPos = platform.transform.position;
        endPos = platform.transform.position + Vector3.up * scriptableObject.distance;
    }

    private void Update()
    {
        if(scriptableObject.isTrue == true)
        {
            currentLerpTime += Time.deltaTime;
            if(currentLerpTime >= lerpTime)
            {
                currentLerpTime = lerpTime;
            }
            float Perc = currentLerpTime / lerpTime;
            platform.transform.position = Vector3.Lerp(startPos, endPos, Perc);
        }
    }







}
