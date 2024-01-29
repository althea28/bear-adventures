using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tick : MonoBehaviour
{

    public static bool musicOff = false;
    public static bool effectsOff = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((musicOff) && (isMusicTick())) {
            musicOff = false;
            Destroy(gameObject);
        } else if ((effectsOff) && (isEffectsTick())) {
            effectsOff = false;
            Destroy(gameObject);
        }
    }

    bool isMusicTick() {
        return transform.position == music.musicTickCoords;
    }

    bool isEffectsTick() {
        return transform.position == music.effectsTickCoords;
    }
}
