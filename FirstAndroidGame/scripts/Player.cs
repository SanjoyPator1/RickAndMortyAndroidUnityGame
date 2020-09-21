using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;
    public float moveSpeed = 1;
    public float rotateAmount =1 ;
    float rot;
    int score;
    public static int numFinal;

    public GameObject winText, corp, replayText, replayButton , nextImage, nextButton, scoreFinal;

    //Game Mode
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(mousePos.x < 0)
            {
                rot = rotateAmount;
            }
            else
            {
                rot = -rotateAmount;
            }

            transform.Rotate(0, 0, rot);
        }


    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * moveSpeed;



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        void CheckWin()  //method to check if 5 GOOD rescue
        {
            if (score >= 5)
            {
                print("Level Complete :) ");

                //play sound
                SoundManager.PlaySound("WinCheck");

                //make this game object active
                winText.SetActive(true);
                //corp.SetActive(true);
                replayText.SetActive(true);
                replayButton.SetActive(true);

                nextImage.SetActive(true);
                nextButton.SetActive(true);

                moveSpeed = 0;
            }

        }

        void Loose()
        {

            replayText.SetActive(true);
            replayButton.SetActive(true);
            moveSpeed = 0;
        }

        //Check if we touch GOOD
        if(collision.gameObject.tag == "RickPray")
        {
            //increase score
            ScoreScript.scoreValue += 100;

            Destroy(collision.gameObject);

            score++;

            CheckWin();

            //play sound
            SoundManager.PlaySound("RickPray");
        }
        else if(collision.gameObject.tag == "DadFalling")
        {
            //increase score
            ScoreScript.scoreValue += 100;

            Destroy(collision.gameObject);

            score++;

            CheckWin();

            //play sound
            SoundManager.PlaySound("DadFalling");

        }
        else if (collision.gameObject.tag == "MortyMusic")
        {
            //increase score
            ScoreScript.scoreValue += 100;

            Destroy(collision.gameObject);

            score++;

            CheckWin();

            //play sound
            SoundManager.PlaySound("MortyMusic");

        }
        else if (collision.gameObject.tag == "MortyChair")
        {
            //increase score
            ScoreScript.scoreValue += 100;

            Destroy(collision.gameObject);

            score++;

            CheckWin();
            //play sound
            SoundManager.PlaySound("MortyChair");

        }
        else if (collision.gameObject.tag == "DadJump")
        {
            //increase score
            ScoreScript.scoreValue += 100;

            Destroy(collision.gameObject);

            score++;

            CheckWin();

            //play sound
            SoundManager.PlaySound("DadJump");

        }

        

        //CHECK IF WE TOUCH BAD
        else if(collision.gameObject.tag == "MomAngry" )
        {
            //return function
            //ScoreScript obj = gameObject.AddComponent<ScoreScript>();
            //numFinal = obj.GetFinalNum();

            //setting the final score
            //obj.scoreFinal = numFinal;

            //Making invisibe the teporary score
            scoreFinal.SetActive(false);

            //reset score to 0
            ScoreScript.scoreValue = 0;

            Loose();
            Destroy(collision.gameObject);  //So that it doesn't cause echo

            //sound
            SoundManager.PlaySound("MomAngry");
            
        }
        else if (collision.gameObject.tag == "BodyBuilder")
        {
            //return function
            //numFinal = ScoreScript.getFinalNum();

            //setting the final score
            //ScoreScript.scoreFinal = numFinal;

            //Making invisibe the teporary score
            scoreFinal.SetActive(false);

            //reset score to 0
            ScoreScript.scoreValue = 0;

            Loose();
            Destroy(collision.gameObject);

            //sound
            SoundManager.PlaySound("BodyBuilder");
  
            
        }
        
        else if (collision.gameObject.tag == "MortyAngry")
        {
            //return function
            //numFinal = ScoreScript.getFinalNum();

            //setting the final score
            //ScoreScript.scoreFinal = numFinal;

            //Making invisibe the teporary score
            scoreFinal.SetActive(false);

            //reset score to 0
            ScoreScript.scoreValue = 0;

            Loose();
            Destroy(collision.gameObject);

            //sound
            SoundManager.PlaySound("MortyAngry");

        }
        else if (collision.gameObject.tag == "BlueBad")
        {
            //return function
            //numFinal = ScoreScript.getFinalNum();

            //setting the final score
            //ScoreScript.scoreFinal = numFinal;

            //Making invisibe the teporary score
            scoreFinal.SetActive(false);

            //reset score to 0
            ScoreScript.scoreValue = 0;

            Loose();
            Destroy(collision.gameObject);

            //sound
            SoundManager.PlaySound("BlueBad");

        }


    }

}
