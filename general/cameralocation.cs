using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameralocation : MonoBehaviour
{
    private Vector3 coordsDiff = new Vector3(0f, 2.42f, -16.17f);


    // Start is called before the first frame update
    void Start()
    {
        //coordsDiff = transform.position - player.coords;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Quaternion.Euler(0,0,0);
       transform.position = player.coords + coordsDiff;
    }
}
