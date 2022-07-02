using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    [SerializeField] private ParticleSystem particleEffects;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "platform")
        {
            DestroyObject();
        }
    }
    private void DestroyObject()
    {
        AudioManager.instance.Play("BallSound");

        Instantiate(particleEffects, transform.position, Quaternion.identity);
        Destroy(gameObject, 0.75f);


    }
}
