using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class passscore : MonoBehaviour
{
    public static int finalScore;
    public static int fullScore;

    public static int currLevel;

    public TextMeshProUGUI scoreText;

    public Transform num1;
    public Transform num2;
    public Transform num3;
    private Vector3 numCoords = new Vector3(1f, 2.967f, -4.905f);

    public Transform brownStar;
    public Transform greyStar;
    private Vector3 star2Coords = new Vector3(0f, 2.18f, -4.95f);
    private Vector3 star3Coords = new Vector3(0.867f, 2.18f, -4.95f);

    public Transform nextLevel;
    private Vector3 nextLevelCoords = new Vector3(2.89f, 1.251f, -5f);

    public AudioSource passSound;

    // Start is called before the first frame update
    void Start()
    {

        if (music.effectsOn) {
            passSound.Play();
        }

        finalScore = player.coinCounter;
        
        //set final score stats
        scoreText.text = "SCORE: " + finalScore.ToString() + "/" + fullScore.ToString();
        
        float percentage = (float) finalScore/ (float) fullScore;
        //Debug.Log("l1stars"+levelMenuMaster.l1stars);
                    
        //set num of stars
        if (percentage < 0.5f) {
            Instantiate(greyStar, star2Coords, greyStar.rotation);
            Instantiate(greyStar, star3Coords, greyStar.rotation);
            updateStars(1);
            
        } else if ((0.5f <= percentage) && (percentage < 1f)) {
            Instantiate(brownStar, star2Coords, brownStar.rotation);
            Instantiate(greyStar, star3Coords, greyStar.rotation);
            updateStars(2);

        } else if (percentage >= 1f) {
            Instantiate(brownStar, star2Coords, brownStar.rotation);
            Instantiate(brownStar, star3Coords, brownStar.rotation);
            updateStars(3);
        }
        
        //set level number & nextlevel sign
        if (currLevel == 1) {
            Instantiate(num1, numCoords, num1.rotation);
            if (levelMenuMaster.l1stars == 3) {
                Instantiate(nextLevel, nextLevelCoords, nextLevel.rotation);
            }
        } else if (currLevel == 2) {
            Instantiate(num2, numCoords, num2.rotation);
            if (levelMenuMaster.l2stars == 3) {
                Instantiate(nextLevel, nextLevelCoords, nextLevel.rotation);
            }
        } else if (currLevel == 3) {
            Instantiate(num3, numCoords, num3.rotation);
            /*if (levelMenuMaster.l3stars == 3) {
                Instantiate(nextLevel, nextLevelCoords, nextLevel.rotation);
            }*/
        } 


        //update avail levels
        /*if ((currLevel == levelMenuMaster.levelsAvail) && (currLevel!=3)) {
            levelMenuMaster.levelsAvail = currLevel + 1;
        }*/

    }

    void updateStars(int numStars) {
        if ((currLevel == 1) && (numStars > levelMenuMaster.l1stars)) {
            levelMenuMaster.l1stars = numStars;
        } else if ((currLevel == 2) && (numStars > levelMenuMaster.l2stars)) {
            levelMenuMaster.l2stars = numStars;
        } else if ((currLevel == 3) && (numStars > levelMenuMaster.l3stars)) {
            levelMenuMaster.l2stars = numStars;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

}
