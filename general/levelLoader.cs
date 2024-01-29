using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{

    public Animator transition;
    public float transitionTime = 1f;

    public static bool startLoad;
    public static int nextScene;

    //public AudioSource bgm;

    void Start() {
        startLoad = false;
        nextScene = 0;
        //bgm.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (startLoad) {
            //StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
            StartCoroutine(LoadLevel(nextScene));
            startLoad = false;
            nextScene = 0;
        }
    }

    IEnumerator LoadLevel(int levelIndex) {
        //start animation
        transition.SetTrigger("Start");

        //wait
        yield return new WaitForSeconds(transitionTime);

        //load scene
        SceneManager.LoadScene(levelIndex);
    }
}
