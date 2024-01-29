using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelSign : MonoBehaviour
{

    public Transform brownStar;
    public Transform greyStar;

    private Vector3 l1s1Coords = new Vector3(-3.83f, 1.33f, -4.46f);
    private Quaternion l1Rotation = Quaternion.Euler(new Vector3(0f, 180f, 93.742f));

    private Vector3 l2s1Coords = new Vector3(-0.43f, 0.82f, -4.46f);
    private Quaternion l2Rotation = Quaternion.Euler(new Vector3(0f, 180f, 87f));

    private Vector3 l3s1Coords = new Vector3(2.88f, 1.46f, -4.46f);
    private Quaternion l3Rotation = Quaternion.Euler(new Vector3(0f, 180f, 94f));
    
    private Vector3 l13starDiffCoords = new Vector3(0.47f, -0.03f, 0f);
    private Vector3 l2starDiffCoords = new Vector3(0.47f, 0.03f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        if (isL3Sign()) {
            addStars(levelMenuMaster.l3stars, l3s1Coords, l13starDiffCoords, l3Rotation);
        } else if (isL2Sign()) {
            addStars(levelMenuMaster.l2stars, l2s1Coords, l2starDiffCoords, l2Rotation);
        } else if (isL1Sign()) { //if L1sign
            addStars(levelMenuMaster.l1stars, l1s1Coords, l13starDiffCoords, l1Rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (isL3Sign()) {
            levelLoader.nextScene = sceneNumMaster.tut3;
            levelLoader.startLoad = true; 
        } else if (isL2Sign()) {
            levelLoader.nextScene = sceneNumMaster.tut2;
            levelLoader.startLoad = true; 
        } else if (isL1Sign()) {
            levelLoader.nextScene = sceneNumMaster.tut1;
            levelLoader.startLoad = true;
        }
    }

    void addStars(int brownStars, Vector3 star1Coords, Vector3 starDiffCoords, Quaternion rotation) {
        for (int i =1; i <= 3 ; i++) {
            if (brownStars > 0) {
                Instantiate(brownStar, star1Coords, rotation);
                brownStars -= 1;
            } else {
                Instantiate(greyStar, star1Coords, rotation);
            }
            star1Coords += starDiffCoords;
        }

        /*if (brownStars == 0) {
            Instantiate(greyStar, star1Coords, rotation);
            Instantiate(greyStar, star1Coords + starDiffCoords, rotation);
            Instantiate(greyStar, star1Coords + (starDiffCoords *2), rotation);
        } else if (brownStars == 1)*/
    }

    bool isL1Sign() {
        return transform.position == levelMenuMaster.l1Coords;
    }

    bool isL2Sign() {
        return transform.position == levelMenuMaster.l2Coords;
    }

    bool isL3Sign() {
        return transform.position == levelMenuMaster.l3Coords;
    }
}
