using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beehivePieceA : MonoBehaviour
{
    public Animator fallAnim;
    private bool played = false;
    private Vector3 pieceDiff = new Vector3(0.254f, -0.073f, 0.00878f);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log((beehive.beehiveDamaged) + " " + transform.position);
        Debug.Log(beehive.damagedLevel);

       if ((beehive.beehiveDamaged + pieceDiff == transform.position) &&
           (beehive.damagedLevel == 1) &&
           (!played)) {
           fallAnim.SetBool("playA", true);
           played = true;

           Debug.Log("reach2");
       }
    }
}
