using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CalculateBallAmount currentballNumber;
    [SerializeField] private PlatformTypes scriptableObject1;
    [SerializeField] private PlatformTypes scriptableObject2;
    [SerializeField] private PlatformTypes scriptableObject3;
    #region Self Variables
    public bool _isReadyToMove;

    #endregion
    #region Serialized Variables


    [SerializeField] public float speed = 10;
    [SerializeField] private float leftRightSpeed = 4;
    private bool speedBoost_;
    [SerializeField] public int maxSpeed = 100;

    #endregion

    #region GameOverandWin
    [SerializeField] public GameObject gameOverpanel;

    #endregion

    private void Start()
    {
        Time.timeScale = 1;
        gameOverpanel.SetActive(false);
        speedBoost_ = false;
        _isReadyToMove = true;
        
    }


    void FixedUpdate()
    {
        PlayerMove();
        StartCoroutine(SpeedBoost());
        



    }
    private void PlayerMove()
    {
       
        _isReadyToMove = true;
        transform.Translate(Vector3.forward * Time.fixedDeltaTime * speed, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if(this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.fixedDeltaTime * leftRightSpeed, Space.World);

            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.right * Time.fixedDeltaTime * leftRightSpeed, Space.World);

            }


        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("stop1"))
        {
            Debug.Log("Countdown started");
            Invoke("GameOverCountDown", 4f);
            StartCoroutine(DelayforPlayerMovement());
        }
        if (other.CompareTag("stop2"))
        {
            Debug.Log("Countdown started");
            Invoke("GameOverCountDownTwo", 4f);
            StartCoroutine(DelayforPlayerMovement());
        }
        if (other.CompareTag("stop3"))
        {
            Debug.Log("Countdown started");
            Invoke("GameOverCountDownThree", 4f);
            StartCoroutine(DelayforPlayerMovement());
        }




    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag ==  "speedBoost")
        {

            LevelBoundary.leftSide = -6.28f;
            LevelBoundary.rightSide = 6.47f;
            speedBoost_ = true;
        }
        if(collision.gameObject.tag == "speedDecreaser")
        {
            
            LevelBoundary.leftSide = -6.28f;
            LevelBoundary.rightSide = 6.47f;
            speed = 5;
        }
        
    }


    IEnumerator DelayforPlayerMovement() 
    {
        speed = 0;
        yield return new WaitForSeconds(5f);
       _isReadyToMove = true;
       speed = 10;

    }
   
    IEnumerator SpeedBoost()
    {

       if (speedBoost_ == true)
       {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                yield return new WaitForSeconds(0.5f);

                Debug.Log("SpeedUp");
                speed += 10;
                if (speed >= 100)
                {
                    speed = maxSpeed;
                }



            }
        }



    }
    private void GameOverCountDown()
    {
        if(scriptableObject1.isTrue == false)
        {
            if (currentballNumber.ballNumber < scriptableObject1.howManyBall)
            {
                Time.timeScale = 0;
                gameOverpanel.SetActive(true);
            }
        }
    }
    private void GameOverCountDownTwo()
    {
        if (scriptableObject2.isTrue == false)
        {
            if (currentballNumber.ballNumber < scriptableObject2.howManyBall)
            {
                Time.timeScale = 0;
                gameOverpanel.SetActive(true);
            }
        }
    }
    private void GameOverCountDownThree()
    {
        if (scriptableObject3.isTrue == false)
        {
            if (currentballNumber.ballNumber < scriptableObject3.howManyBall)
            {
                Time.timeScale = 0;
                gameOverpanel.SetActive(true);
            }
        }
    }


}
