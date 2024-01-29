using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gm2 : MonoBehaviour
{
    public static int fullScore = 25;
    public static int currLevel = 2;

    private float winningXup = 90f;
    private float winningXdown = 85f;
    private float winningYup = 6f;
    private float winningYdown = 2f;
    
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
            passscore.currLevel = currLevel;
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
