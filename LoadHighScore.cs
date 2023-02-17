using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadHighScore : MonoBehaviour
{
    AddScore addscore;

    int highscore;

    public TMP_Text highscoreNum;

    // Start is called before the first frame update
    void Start()
    {
        addscore = GetComponent<AddScore>();

        highscore = PlayerPrefs.GetInt("HighScore");
        highscoreNum.text = highscore.ToString();
    }

    public void SaveScore()
    {
        if(addscore.score > highscore)
        {
            PlayerPrefs.SetInt("HighScore", addscore.score);
        }
    }
}
