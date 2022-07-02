using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalculateBallAmount : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ballAmountText;

    [SerializeField] public int ballNumber;

    [SerializeField] private PlatformTypes scriptableObject;


   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("ball"))
        {
            ballNumber += 1;
            ballAmountText.text = "" + ballNumber;
            if (ballNumber == scriptableObject.howManyBall)
            {
                scriptableObject.isTrue = true;
                
            }
            
            

        }

    }
   





}

