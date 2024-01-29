using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    private bool jumpPressed;
    private bool startTime;
    private float lastJumpTime;
    private float jumpCoolOff = 1f;

    private Vector3 spawnCoords = new Vector3(0.72f, 1.12f, 0.214f);
    private float deathCoords = -5f;

    public static int coinCounter;
    public static int minCoinsNeeded;
    public static int currLevel;

    public static float winningXup;
    public static  float winningXdown;
    public static  float winningYup;
    public static  float winningYdown;

    public static Vector3 coords;

    private float xInput;

    public AudioSource jumpSound;
    public AudioSource coinSound;
    public AudioSource fallSound;

    //public static bool playerLose = false;
    
    public static bool win;
    public static bool lose;
    //public static bool respawn;

    // Start is called before the first frame update
    void Start()
    {
        //playerLose = false;
        win = false;
        lose = false;
        transform.position = spawnCoords;
        lastJumpTime = 0f;
        coinCounter = 0; //#CHANGE LATER

        if (!music.effectsOn) {
            jumpSound.mute = true;
            coinSound.mute = true;
            fallSound.mute = true;
        } else {
            jumpSound.mute = false;
            jumpSound.mute = false;
            fallSound.mute = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        coords = transform.position;
        
        /*if (playerLose) {
            playerLose = false;
            //lose();
        }*/

        //if dead
        if (transform.position.y <= deathCoords) {
            fallSound.Play();
            lose = true;
            
            //lose();
        }
        if (transform.position.y <= deathCoords - 20f) {
            transform.position = spawnCoords;
        }

        //if win
        if ((transform.position.x >= winningXdown) && (transform.position.x <= winningXup) &&
            (transform.position.y >= winningYdown) && (transform.position.y <=winningYup) &&
            (coinCounter >= minCoinsNeeded)) {
            //win();
            win = true;
        }

        //if jumping
        if ((Input.GetKeyDown(KeyCode.UpArrow)) && (lastJumpTime == 0f)) {
            jumpPressed = true;
            startTime = true;
        }
        
        //count jump cool off time
        if (startTime) {
            lastJumpTime += Time.deltaTime;
        }

        //check if finish jump cool off time
        if (lastJumpTime >= jumpCoolOff) {
            startTime = false;
            lastJumpTime = 0f;
        }

        xInput = Input.GetAxis("Horizontal");
        
    }

    private void FixedUpdate() {
        if (jumpPressed) {
            jumpSound.Play();
            GetComponent<Rigidbody>().AddForce(Vector3.up*8, ForceMode.VelocityChange);
            jumpPressed = false;
        }

        GetComponent<Rigidbody>().velocity = new Vector3(xInput*7, GetComponent<Rigidbody>().velocity.y,0);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == 7) {
            coinSound.Play();
            Destroy(other.gameObject);
            coinCounter ++;
        }
    }

    /*private void win() {
        passscore.finalScore = coinCounter;
        passscore.currLevel = currLevel;
        replay.nextSceneNum = SceneManager.GetActiveScene().buildIndex;
        levelLoader.nextScene = sceneNumMaster.pass; //pass scene
        levelLoader.startLoad = true;
    }

    private void lose() {
        replay.nextSceneNum = SceneManager.GetActiveScene().buildIndex;
        levelLoader.nextScene = sceneNumMaster.fail;
        levelLoader.startLoad = true;
    }*/


}
