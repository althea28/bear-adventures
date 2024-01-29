using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bgm : MonoBehaviour
{

    public AudioSource bgmSound;
    public static bool musicPlay = false;
    public static bool musicPause = false;
    private bool musicOn = true;

    // Start is called before the first frame update
    void Start()
    {
        if (musicOn) {
            bgmSound.Play();
        }
        
    }
    
    void Awake() {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("bgm");
        if ((musicObj.Length > 1) || 
            (SceneManager.GetActiveScene().buildIndex == sceneNumMaster.pass)) {
            Destroy(this.gameObject);
        } else {
            DontDestroyOnLoad(this.gameObject);
        }

        /*int sceneNum = SceneManager.GetActiveScene().buildIndex;
        if ((sceneNum == sceneNumMaster.levelMenu) || 
            (sceneNum == sceneNumMaster.pass) ||
            (sceneNum == sceneNumMaster.fail)) {
            Destroy(gameObject);
        } else {
            DontDestroyOnLoad(gameObject);
        }*/
    }
    
    // Update is called once per frame
    void Update()
    {
        int sceneNow = SceneManager.GetActiveScene().buildIndex;

        if ((sceneNow == sceneNumMaster.level1) ||
            (sceneNow == sceneNumMaster.level2) ||
            (sceneNow == sceneNumMaster.level3)) {
            bgmSound.Pause();
            //musicOn = false;
            //Destroy(this.gameObject);
        }
        if (((sceneNow == sceneNumMaster.levelMenu) ||
            (sceneNow == sceneNumMaster.tut1) ||
            (sceneNow == sceneNumMaster.tut2) ||
            (sceneNow == sceneNumMaster.tut3)) && 
            (musicOn) && (!bgmSound.isPlaying)) {
            bgmSound.Play();
        }
        /*if ((sceneNow == sceneNumMaster.levelMenu) && 
            (musicOn) && (!bgmSound.isPlaying)) {
            bgmSound.Play();
        }*/

        if (musicPause) {
            bgmSound.Pause();
            musicPause = false;
            musicOn = false;
            //Destroy(this.gameObject);
        }
        if (musicPlay) {
            bgmSound.Play();
            musicPlay = false;
            musicOn = true;
        }
    }
}
