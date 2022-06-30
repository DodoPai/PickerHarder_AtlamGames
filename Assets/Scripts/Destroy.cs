using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("destroyStop"))
        {
            Destroy(gameObject,5f);
        }
    }

}
