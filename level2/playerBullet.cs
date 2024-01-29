using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBullet : MonoBehaviour
{
    public Transform smokeObj;
    //public AudioSource poofSound;

    // Start is called before the first frame update
    void Start()
    {
        /*if (!music.effectsOn) {
            poofSound.mute = true;
        } else { 
            poofSound.mute = false;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == 10) {
            //poofSound.Play();
            Instantiate(smokeObj, transform.position, smokeObj.rotation);
            player.lose = true;
            Destroy(gameObject);
        }
    }
}
