using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("quit script working");
        
    }

    void OnMouseDown() {
        //Debug.Log("quit reg");
        levelLoader.nextScene = sceneNumMaster.levelMenu;
        levelLoader.startLoad = true;
    }
}
