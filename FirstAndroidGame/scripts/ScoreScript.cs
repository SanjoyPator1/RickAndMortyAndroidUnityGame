using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    public static int scoreFinal = 1;
    

    Text score;
    public GameObject finalObject;


    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        finalObject.GetComponent<Text>().text = "LOL";

    }

    // Update is called once per frame
    void Update()
    {
        score.text = scoreValue.ToString();
        if(scoreValue!= 0)
        {
            scoreFinal = scoreValue;
        }
        
        finalObject.GetComponent<Text>().text = scoreFinal.ToString();

        
    }

}
