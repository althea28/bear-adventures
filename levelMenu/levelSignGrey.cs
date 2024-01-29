using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelSignGrey : MonoBehaviour
{
    public Transform greyStar;
    
    private Vector3 l2s1Coords = new Vector3(-0.43f, 0.82f, -4.46f);
    private Quaternion l2Rotation = Quaternion.Euler(new Vector3(0f, 180f, 87f));

    private Vector3 l3s1Coords = new Vector3(2.88f, 1.46f, -4.46f);
    private Quaternion l3Rotation = Quaternion.Euler(new Vector3(0f, 180f, 94f));
    
    private Vector3 l13starDiffCoords = new Vector3(0.47f, -0.03f, 0f);
    private Vector3 l2starDiffCoords = new Vector3(0.47f, 0.03f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        if (isL2Sign()) {
            addStars(l2s1Coords, l2starDiffCoords, l2Rotation);
        } else if (isL3Sign()) {
            addStars(l3s1Coords, l13starDiffCoords, l3Rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void addStars(Vector3 s1Coords, Vector3 starDiffCoords, Quaternion rotation) {
        for (int i = 1 ; i <= 3; i++) {
            Instantiate(greyStar, s1Coords, rotation);
            s1Coords += starDiffCoords;
        }
    }
    
    bool isL2Sign() {
        return transform.position == levelMenuMaster.l2Coords;
    }

    bool isL3Sign() {
        return transform.position == levelMenuMaster.l3Coords;
    }

}
