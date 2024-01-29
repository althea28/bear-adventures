using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starShoot : MonoBehaviour
{
    private float yDeath = -10f;
    private float lDeath = -20f;
    private float rDeath = 120f;


    void Start() {
    }

    void Update() {
        if (transform.position.z >= -14f) {
            GetComponent<Rigidbody>().AddForce(new Vector3(
                shootAngle.anglex, shootAngle.angley, 0), ForceMode.VelocityChange);
        }
        
        if ((transform.position.y <= yDeath) || (transform.position.x < lDeath) ||
            (transform.position.x > rDeath)) {
            Destroy(gameObject);
        }
    }


}
