using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failscore : MonoBehaviour
{
    
    public Transform num1;
    public Transform num2;
    public Transform num3;
    public static int currLevel;
    private Vector3 numCoords = new Vector3(1f, 2.967f, -4.905f);

    public  AudioSource failSound;

    // Start is called before the first frame update
    void Start()
    {
        if (music.effectsOn) {
            failSound.Play();
        }
       
        //set level number
        if (currLevel == 1) {
            Instantiate(num1, numCoords, num1.rotation);
        } else if (currLevel == 2) {
            Instantiate(num2, numCoords, num2.rotation);
        } else if (currLevel == 3) {
            Instantiate(num3, numCoords, num3.rotation);
        }
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
