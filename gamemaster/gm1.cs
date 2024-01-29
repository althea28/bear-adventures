using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gm1 : MonoBehaviour
{

    public static int fullScore = 25;
    public static int currLevel = 1;

    private float winningXup = 70f;
    private float winningXdown = 66f;
    private float winningYup = 8f;
    private float winningYdown = 4f;

    private int minCoinsNeeded = 0;
    
    // Start is called before the first frame update
    void Start()
    {
       player.currLevel = currLevel;
       passscore.fullScore = fullScore;

       player.minCoinsNeeded = minCoinsNeeded;
       
       player.winningXup = winningXup;
       player.winningXdown = winningXdown;
       player.winningYup = winningYup;
       player.winningYdown = winningYdown;
           
    }

    // Update is called once per frame
    void Update()
    {
       if (player.win) {

           player.win = false;

            passscore.finalScore = player.coinCounter;
            passscore.currLevel = player.currLevel;
            replay.nextSceneNum = SceneManager.GetActiveScene().buildIndex;
            levelLoader.nextScene = sceneNumMaster.pass; //pass scene
            levelLoader.startLoad = true;
       }

       if (player.lose) {
            player.lose = false;
            
            failscore.currLevel = currLevel;
           replay.nextSceneNum = SceneManager.GetActiveScene().buildIndex;
           levelLoader.nextScene = sceneNumMaster.fail;
           levelLoader.startLoad = true;
       }

    }
}
