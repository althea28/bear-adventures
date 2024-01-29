using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attachPlayer : MonoBehaviour
{
    public GameObject player;
    private float xDiff;
    private float yDiff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject == player) {
            player.transform.parent = transform;
            //player.transform.localScale = new Vector3(0.7775f, 1.108f, 1.44f);
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject == player) {
            player.transform.parent = null;
        }
    }

    /*void OnTriggerEnter(Collider other) {
        if (other.gameObject == player) {
            xDiff = transform.position.x - other.transform.position.x;
            yDiff = transform.position.y - other.transform.position.y;
        }
    }

    void OnTriggerStay(Collider other) {
        if (other.gameObject == player) {
            other.transform.position.x = transform.position.x + xDiff;
            other.transform.position.y = transform.position.y + yDiff;
        }
    }*/
}

