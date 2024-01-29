using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mmStart : MonoBehaviour
{
    //public AudioSource clickSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        /*if (music.effectsOn) {
            clickSound.Play();
        }*/

        levelLoader.nextScene = sceneNumMaster.levelMenu;
        levelLoader.startLoad = true;
    }
}
