using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hivePieceB : MonoBehaviour
{
    public Transform fallPieceB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if ((beehive.beehiveDamaged == transform.position) &&
            (beehive.damagedLevel == 2)) {
            Instantiate(fallPieceB, transform.position, fallPieceB.rotation);
            Destroy(gameObject);
        } 
    }
}
