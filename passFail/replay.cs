using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replay : MonoBehaviour
{

    public static int nextSceneNum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        levelLoader.nextScene = nextSceneNum; //if L1 then 2, if L2 then 3,...
        levelLoader.startLoad = true;
    }
}
