using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    public Transform starShoot;

    public static float playerx;
    public static float playery;

    public AudioSource shootSound;

    public Transform beeAttack;
    public Transform beeBite;
    public Transform bear;
    public AudioSource beeBuzzSound;

    // Start is called before the first frame update
    void Start()
    {
        if (!music.effectsOn) {
            beeBuzzSound.mute = true;
        } else { 
            beeBuzzSound.mute = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        playerx = transform.position.x;
        playery = transform.position.y;

        if (Input.GetKeyDown(KeyCode.Space)) {
            shootSound.Play();
            Instantiate(starShoot, transform.position, transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == 9) {
            beeBuzzSound.Play();
            Instantiate(beeAttack, other.gameObject.transform.position, beeAttack.rotation);
            Instantiate(beeAttack, other.gameObject.transform.position, 
                Quaternion.Euler(new Vector3(0, 90, 0)));

            Transform bites = Instantiate(beeBite, transform.position + new Vector3(-.09f,-.02f,0f), 
                beeBite.rotation, bear) as Transform;
            bites.transform.localScale = new Vector3(.012f, .027f, .039f);

            player.lose = true;
        }
    }


}
