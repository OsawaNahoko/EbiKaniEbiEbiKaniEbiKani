using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] ScoreData Scoredata;
    [SerializeField] Text HighScoreText;
    [SerializeField] Text ScoreText;

    string Scorestring;
    string HighScoreString;

    void Start()
    {
        Scoredata.Score     = 5;
        Scoredata.HighScore = 5;
    }

    void Update()
    {
        ScoreText.text      = $"業務成績:{Scorestring     = Scoredata.Score.ToString()}";
        HighScoreText.text  = $"最高成績:{HighScoreString = Scoredata.HighScore.ToString()}";

        if(Scoredata.Score > Scoredata.HighScore)
        {
            Scoredata.HighScore += 1;
        }
    }
}
