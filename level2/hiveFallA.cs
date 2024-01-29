using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiveFallA : MonoBehaviour
{
    //private float yloc;

    // Start is called before the first frame update
    void Start()
    {
        //yloc = transform.position.y;
        //Debug.Log("EXIST");
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.y < -10f) && (transform.position.z >-7f)) {
            Destroy(gameObject);
        }
        /*if ((yloc == transform.position.y) && (transform.position.z > -7f)) {
            Destroy(gameObject);
        } else {
            yloc = transform.position.y;
        }

        if ((transform.position.y < -10f) && (transform.position.z > -7f)) {
            Destroy(gameObject);
        }*/
    }
}
