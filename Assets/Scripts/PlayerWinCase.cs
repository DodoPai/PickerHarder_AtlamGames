using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWinCase : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
    private void Start()
    {
        winPanel.SetActive(false);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="speedDecreaser")
        {
            StartCoroutine(winDelay());
        }
    }

    public IEnumerator winDelay()
    {
        yield return new WaitForSeconds(2f);
        winPanel.SetActive(true);
        Time.timeScale = 0;

    }

}
