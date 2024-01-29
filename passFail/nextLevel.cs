using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnMouseDown() {
        if (passscore.currLevel == 1) {
            levelLoader.nextScene = sceneNumMaster.tut2; 
        } else if (passscore.currLevel == 2) {
            levelLoader.nextScene = sceneNumMaster.tut3;
        }
        levelLoader.startLoad = true;
    }
}
