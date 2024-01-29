using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hivePieceA : MonoBehaviour
{
    public Transform fallPieceA;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if ((beehive.beehiveDamaged == transform.position) &&
            (beehive.damagedLevel == 1)){
            Instantiate(fallPieceA, transform.position, fallPieceA.rotation);
            Destroy(gameObject);
        }
    }
}
