using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeedBoost : MonoBehaviour
{
   [SerializeField] private Rigidbody rb;
   [SerializeField] private float boostAmount = 150;


    private void Start()
    {
        //rb.isKinematic = false;
    }





    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("addBallBoost"))
        {
            rb.AddForce(transform.forward * boostAmount);
           
        }
        
    }
    

}
