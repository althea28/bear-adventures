using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoke : MonoBehaviour
{
    public AudioSource poofSound;

    // Start is called before the first frame update
    void Start()
    {
       /*if (!music.effectsOn) {
            poofSound.mute = true;
        } else { 
            poofSound.mute = false;
        }*/

       if ((transform.position.z > 0f) && (music.effectsOn)) {
           poofSound.Play();
       }
       var main = GetComponent<ParticleSystem>().main;
       main.simulationSpeed = 9; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
