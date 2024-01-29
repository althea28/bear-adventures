using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutSkip : MonoBehaviour
{

    public static int tutLevelScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        levelLoader.nextScene = tutLevelScene;
        levelLoader.startLoad = true;
    }
}
