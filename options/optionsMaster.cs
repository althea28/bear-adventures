using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionsMaster : MonoBehaviour
{
    public Transform tickObj;

    // Start is called before the first frame update
    void Start()
    {
       
        if (music.musicOn) {
            Instantiate(tickObj, music.musicTickCoords, music.musicTickRot);
        }
        if (music.effectsOn) {
            Instantiate(tickObj, music.effectsTickCoords, music.effectsTickRot);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
