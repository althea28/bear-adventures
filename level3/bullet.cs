using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        if (transform.rotation == Quaternion.Euler(new Vector3(0,0,0))) {
            dir = Vector3.up;
        } else if (transform.rotation == Quaternion.Euler(new Vector3(0,0,-90))) {
            dir = Vector3.right;
        } else if (transform.rotation == Quaternion.Euler(new Vector3(0,0,90))) {
            dir = Vector3.left;
        } else if (transform.rotation == Quaternion.Euler(new Vector3(0,0,180))) {
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(dir*0.5f, ForceMode.VelocityChange);

        if ((transform.position.x < -50f) || (transform.position.x > 50f) ||
            (transform.position.y < -50f) || (transform.position.y > 50f)) {
            
            Destroy(gameObject);
        }
    }
}
