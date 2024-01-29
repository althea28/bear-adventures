using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    public Transform tickObj;
    private Vector3 musicButtonCoords = new Vector3(3.88f, 1.96f, -1.8f);
    public static Vector3 musicTickCoords = new Vector3(2.31f, 2.16f, -2.12f);
    public static Quaternion musicTickRot = Quaternion.Euler(new Vector3(-128f, -90f, 0f));

    private Vector3 effectsButtonCoords = new Vector3(3.88f, 0.16f, -1.8f);
    public static Vector3 effectsTickCoords = new Vector3(1.87f, 0.55f, -2.12f);
    public static Quaternion effectsTickRot = Quaternion.Euler(new Vector3(-132f, -90f, 0f));

    public static bool musicOn = true;
    public static bool effectsOn = true;
    private GameObject bgmObj;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseDown() {
        if (isMusicButton()) {
            musicOn = !musicOn;
            //bgmSound.mute = !bgmSound.mute;
            if (musicOn) {
                Instantiate(tickObj, musicTickCoords, musicTickRot);
                bgm.musicPlay = true;
                //Instantiate(bgmObj, musicTickCoords, bgmObj.rotation);
            } else if (!musicOn) {
                tick.musicOff = true;
                bgm.musicPause = true;
            }
        } else if (isEffectsButton()) {
            effectsOn = !effectsOn;
            //turnEffectsOff(effectsOn);
            if (effectsOn) {
                Instantiate(tickObj, effectsTickCoords, effectsTickRot);
            } else if (!effectsOn) {
                tick.effectsOff = true;
            }
        }
    }

    /*void turnEffectsOff(bool change) {
        player.jumpSound.mute = change;
        player.coinSound.mute = change;
        passscore.passSound.mute = change;
        failscore.failSound.mute = change;
    }*/

    bool isMusicButton() {
        return transform.position == musicButtonCoords;
    }

    bool isEffectsButton() {
        return transform.position == effectsButtonCoords;
    }
}
