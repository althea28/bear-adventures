using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelBgm : MonoBehaviour
{
    public AudioSource levelBgmSound;

    // Start is called before the first frame update
    void Start()
    {
        if (music.musicOn) {
            levelBgmSound.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
