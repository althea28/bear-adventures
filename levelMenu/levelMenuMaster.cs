using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelMenuMaster : MonoBehaviour
{
    public static int levelsAvail = 1;

    public static int l1stars = 0;
    public static int l2stars = 0;
    public static int l3stars = 0;

    public static Vector3 l1Coords = new Vector3(-3.36f, 0.47f, -4.41f);

    public Transform l2;
    public Transform l2Grey;
    public static Vector3 l2Coords = new Vector3(0f, 0.06f, -4.41f);

    public Transform l3;
    public Transform l3Grey;
    public static Vector3 l3Coords = new Vector3(3.36f, 0.64f, -4.41f);

    // Start is called before the first frame update
    void Start()
    {
        if (l1stars == 3) {
            levelsAvail = 2;
        }
        if (l2stars == 3) {
            levelsAvail = 3;
        }

        if (levelsAvail == 1) {
            Instantiate(l2Grey, l2Coords, l2Grey.rotation);
            Instantiate(l3Grey, l3Coords, l3Grey.rotation);

        } else if (levelsAvail == 2) {
            Instantiate(l2, l2Coords, l2.rotation);
            Instantiate(l3Grey, l3Coords, l3Grey.rotation);

        } else if (levelsAvail == 3) {
            Instantiate(l2, l2Coords, l2.rotation);
            Instantiate(l3, l3Coords, l3.rotation);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
