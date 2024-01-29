using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tut3Master : MonoBehaviour
{
    private float winningXup = 34f;
    private float winningXdown = 30f;
    private float winningYup = 10f;
    private float winningYdown = -2f;

    private int minCoinsNeeded = 4;

    // Start is called before the first frame update
    void Start()
    {
         
        tutSkip.tutLevelScene = sceneNumMaster.level3;

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

            levelLoader.nextScene = sceneNumMaster.level3; //start L1;
            levelLoader.startLoad = true;
       }

       if (player.lose) {
            player.lose = false;
            //player.respawn = true;
            levelLoader.nextScene = SceneManager.GetActiveScene().buildIndex; //start L1;
            levelLoader.startLoad = true;

        }

    }
}
