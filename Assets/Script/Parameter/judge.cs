using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class judge : Soundplayer
{
    [SerializeField] ParameterData parameterdata;
    [SerializeField] ScoreData Scoredata;

    string[] targetTags = { "dish_null", "dish_Kani", "dish_Ebi" };
    int[] newKaniEbiArrey = new int[5];
    int Number = -1;
    int trueCount  = 0;

    //サウンド番号：０は正解　１は不正解

    void OnTriggerEnter2D(Collider2D other)
    {
        if (targetTags.Contains(other.gameObject.tag) && Scoredata.Score >= 0)
        {
            
        newKaniEbiArrey = parameterdata.KaniEbiArrey;

        AddNumber();
        Debug.Log($"Number = {Number}");
        // Debug.Log($"trueCount{trueCount}");

        if(newKaniEbiArrey[Number] == 0 && other.gameObject.tag == "dish_Ebi")
        {
            Debug.Log("正解ですエビ");
            Success();
        }
        else if (newKaniEbiArrey[Number] == 0 && other.gameObject.tag == "dish_Kani" || newKaniEbiArrey[Number] == 0 && other.gameObject.tag == "dish_null")
        {
            Debug.Log("誤りですエビ！！！");
            miss();
        }

        if(newKaniEbiArrey[Number] == 1 && other.gameObject.tag == "dish_Kani")
        {
            Debug.Log("正解ですカニ");
            Success();
        }
        else if (newKaniEbiArrey[Number] == 1 && other.gameObject.tag == "dish_Ebi" || newKaniEbiArrey[Number] == 1 && other.gameObject.tag == "dish_null")
        {
            Debug.Log("誤りですカニ！！！！");
            miss();
        }

        }
               if(trueCount == 4)
            {
                Scoredata.Score += 1;
                // Debug.Log("全問正解！");
            }
                if(Scoredata.Score <= 0)
            {
                Vector3 newPosition = transform.position;
                newPosition.y += 10.0f;
                transform.position = newPosition;
            }
    }

    void AddNumber()
    {
        if (Number < newKaniEbiArrey.Length - 2)
        {
            Number += 1;
        }
        else if(Number == 3 )
        {
            Number     = 0;
            trueCount  = 0;
            // Debug.Log("初期化されました");
        }
    }

    void Success()
    {
            PlaySound(0);
            trueCount  += 1;
            parameterdata.KaniEbiArrey[Number] = 2;
            parameterdata.KaniEbiArrey[4] = 2;
    }

    void miss()
    {
            PlaySound(1);
            Scoredata.Score -= 1;
            parameterdata.KaniEbiArrey[Number] = 3;
            parameterdata.KaniEbiArrey[4] = 3;
    }
 
}
