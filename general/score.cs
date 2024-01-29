//using System.Collections;
//using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI scoreText;
    private string coinLabel = "COINS: ";
    private int currScore;

    void Start()
    {
        scoreText.text = coinLabel + "0";
        currScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currScore != player.coinCounter) {
            changeScore(player.coinCounter);
            currScore = player.coinCounter;
        }
    }

    void changeScore(int i) {
        scoreText.text = coinLabel + i.ToString();
    }
}
