using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int sceneNumber;
    //Restart Method
    public void NextFunction()
    {

        SceneManager.LoadScene(sceneNumber);   //this will load the medium scene after the level 1 is cleared
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
