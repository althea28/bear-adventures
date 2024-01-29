using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beehive : MonoBehaviour
{
    private int damage = 0;
    private int damage1 = 2;
    private int damage2 = 4;
    private int maxDamage = 5;
    public static int damagedLevel = 0;
    public static Vector3 beehiveDamaged = Vector3.zero;

    public Transform hivePieces;
    public AudioSource hiveBreakSound;


    // Start is called before the first frame update
    void Start()
    {
        damage = 0;
        damagedLevel = 0;
        beehiveDamaged = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (damage >= maxDamage) {
            Instantiate(hivePieces, transform.position, hivePieces.rotation);
            Destroy(gameObject);
        }
        if ((damage >= damage1)){ // && (beehiveDamaged == Vector3.zero)) {
            beehiveDamaged = transform.position;
            damagedLevel = 1;
        }
        if ((damage >= damage2)){ // && (beehiveDamaged == Vector3.zero)) {
            beehiveDamaged = transform.position;
            damagedLevel = 2;
        }

    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == 8) {
            hiveBreakSound.Play();
            Destroy(other.gameObject);
            damage++;
        }
    }

}
