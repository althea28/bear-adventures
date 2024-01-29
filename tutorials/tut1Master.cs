using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tut1Master : MonoBehaviour
{
    private float winningXup = 17f;
    private float winningXdown = 15f;
    private float winningYup = 5f;
    private float winningYdown = -5f;

    private int minCoinsNeeded = 3;

    // Start is called before the first frame update
    void Start()
    {
       tutSkip.tutLevelScene = sceneNumMaster.level1;
        
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

            levelLoader.nextScene = sceneNumMaster.level1; //start L1;
            levelLoader.startLoad = true;
       }

       if (player.lose) {
            player.lose = false;

            levelLoader.nextScene = SceneManager.GetActiveScene().buildIndex; //start L1;
            levelLoader.startLoad = true;

        }

    }
}
