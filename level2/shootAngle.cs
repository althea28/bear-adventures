using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootAngle : MonoBehaviour
{
    public static float anglex;
    public static float angley;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anglex = transform.position.x - playerShoot.playerx;
        angley = transform.position.y - playerShoot.playery;

      
    }
}
