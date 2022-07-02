using UnityEngine;

public class PlayerSkins : MonoBehaviour
{
    [SerializeField] public GameObject[] playerTypes;
    public int currentPlayerIndex;

    private void Start()
    {
        currentPlayerIndex = 0;
        foreach (GameObject skin in playerTypes)
        {
            skin.SetActive(false);
        }
        playerTypes[currentPlayerIndex].SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("chooseLeft"))
        {
            AudioManager.instance.Play("SkinSound");

            playerTypes[currentPlayerIndex].SetActive(false);
            currentPlayerIndex = 1;
            playerTypes[currentPlayerIndex].SetActive(true);
        }
        if (other.CompareTag("chooseRight"))
        {
            AudioManager.instance.Play("SkinSound");

            playerTypes[currentPlayerIndex].SetActive(false);
            currentPlayerIndex = 2;
            playerTypes[currentPlayerIndex].SetActive(true);
        }
        
        
            
        
    }

}
