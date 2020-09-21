using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{   

    public static AudioClip RickPray, DadFalling, MortyMusic, MortyChair,DadJump;   //good
    public static AudioClip MomAngry, BodyBuilder, MortyAngry, BlueBad; //Bad
    public static AudioClip WinCheck;  //others

    static AudioSource audioSrc;


    // Start is called before the first frame update
    void Start()
    {   
        //Good Sound
        RickPray = Resources.Load<AudioClip>("RickPray");
        DadFalling = Resources.Load<AudioClip>("DadFalling");
        MortyMusic = Resources.Load<AudioClip>("MortyMusic");
        MortyChair = Resources.Load<AudioClip>("MortyChair");
        DadJump = Resources.Load<AudioClip>("DadJump");


        //Bad Sound
        MomAngry = Resources.Load<AudioClip>("MomAngry");
        BodyBuilder = Resources.Load<AudioClip>("BodyBuilder");
        MortyAngry = Resources.Load<AudioClip>("MortyAngry");
        BlueBad = Resources.Load<AudioClip>("BlueBad");

        //others
        WinCheck = Resources.Load<AudioClip>("WinCheck");

        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {

        switch (clip)
        {
            //Good
            case "RickPray":
                audioSrc.PlayOneShot(RickPray);
                break;
            case "DadFalling":
                audioSrc.PlayOneShot(DadFalling);
                break;
            case "MortyMusic":
                audioSrc.PlayOneShot(MortyMusic);
                break;
            case "MortyChair":
                audioSrc.PlayOneShot(MortyChair);
                break;
            case "DadJump":
                audioSrc.PlayOneShot(DadJump);
                break;

            //WinCheck
            case "WinCheck":
                audioSrc.PlayOneShot(WinCheck);
                break;

            //Bad
            case "MomAngry":
                    audioSrc.PlayOneShot(MomAngry);
                break;
            case "BodyBuilder":
                audioSrc.PlayOneShot(BodyBuilder);
                break;
            case "MortyAngry":
                audioSrc.PlayOneShot(MortyAngry);
                break;
            case "BlueBad":
                audioSrc.PlayOneShot(BlueBad);
                break;

        }
    }
}
