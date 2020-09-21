using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    public int RestartSceneNumber;

    //Restart Method
    public void RestartGame()
    {
        SceneManager.LoadScene(RestartSceneNumber);   //this will load he starting screen all reset
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
