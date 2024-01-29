using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTut1 : MonoBehaviour
{
    private bool jumpPressed;
    private bool startTime;
    private float lastJumpTime;
    private float jumpCoolOff = 1f;

    private Vector3 spawnCoords = new Vector3(0.72f, 1.12f, 0.214f);
    private float deathCoords = -10f;
    
    public static float passXup = 18f;
    public static float passXdown = 15f;
    public static float passYup = -10f;
    public static float passYdown = 10f;
    public static int maxCoins = 3;
    

    public static Vector3 coords;

    private int coinCounter;

    private float xInput;

    public AudioSource jumpSound;
    public AudioSource coinSound;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = spawnCoords;
        coinCounter = 0;
        lastJumpTime = 0f;

        tutSkip.tutLevelScene = sceneNumMaster.level1;
        
        if (!music.effectsOn) {
            jumpSound.mute = true;
            coinSound.mute = true;
        } else {
            jumpSound.mute = false;
            jumpSound.mute = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        coords = transform.position;

        //if dead
        if (transform.position.y <= deathCoords) {
            transform.position = spawnCoords;
        }

        //if win
        if ((transform.position.x >= passXdown) && (transform.position.x <= passXup) &&
            (transform.position.y >= passYdown) && (transform.position.y >= passYup) &&
            (coinCounter == maxCoins)) { 
            passTut();
        }

        //if jumping
        if ((Input.GetKeyDown(KeyCode.Space)) && (lastJumpTime == 0f)) {
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
            coinCounter++;
        }
    }

    private void passTut() {
        levelLoader.nextScene = sceneNumMaster.level1; //start L1;
        levelLoader.startLoad = true;
    }




}
