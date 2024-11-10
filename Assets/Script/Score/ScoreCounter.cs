using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] ScoreData Scoredata;
    [SerializeField] Text ScoreText;
    string Scorestring;

    void Start()
    {
        Scoredata.Score = 5;
    }

    void Update()
    {
        ScoreText.text = $"業務成績:{Scorestring = Scoredata.Score.ToString()}";
    }
}
