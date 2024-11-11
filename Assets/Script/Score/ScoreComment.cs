using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreComment : MonoBehaviour
{
    [SerializeField] ScoreData Scoredata;

    public Sprite[] CommentArrey;
    SpriteRenderer Spriterend;


    void Start()
    {
        Spriterend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        switch(Scoredata.HighScore)
        {
            case 5:
            Spriterend.sprite = CommentArrey[0];
            break;

            case 10:
            Spriterend.sprite = CommentArrey[1];
            break;

            case 50:
            Spriterend.sprite = CommentArrey[2];
            break;

            case 100:
            Spriterend.sprite = CommentArrey[3];
            break;
        }
        
    }
}
