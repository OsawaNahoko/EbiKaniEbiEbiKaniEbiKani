using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class judge : MonoBehaviour
{
    [SerializeField] ParameterData parameterdata;
    [SerializeField] ScoreData Scoredata;

    int[] newKaniEbiArrey = new int[4];
    int Number = -1;
    int falseCount = 0;
    int trueCount  = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "dish_null" || other.gameObject.tag == "dish_Kani" || other.gameObject.tag == "dish_Ebi")
        {
            
        newKaniEbiArrey = parameterdata.KaniEbiArrey;

        AddNumber();
        // Debug.Log($"Number{Number}");
        Debug.Log($"trueCount{trueCount}");

        if(newKaniEbiArrey[Number] == 0 && other.gameObject.tag == "dish_Ebi")
        {
            Debug.Log("正解ですエビ");
            trueCount  += 1;
            
        }
        else if (newKaniEbiArrey[Number] == 0 && other.gameObject.tag == "dish_Kani" || newKaniEbiArrey[Number] == 0 && other.gameObject.tag == "dish_null")
        {
            Debug.Log("誤りですエビ！！！");
            falseCount += 1;
        }

        if(newKaniEbiArrey[Number] == 1 && other.gameObject.tag == "dish_Kani")
        {
            Debug.Log("正解ですカニ");
            trueCount  += 1;
        }
        else if (newKaniEbiArrey[Number] == 1 && other.gameObject.tag == "dish_Ebi" || newKaniEbiArrey[Number] == 1 && other.gameObject.tag == "dish_null")
        {
            Debug.Log("誤りですカニ！！！！");
            falseCount += 1;
        }
        }
               if(trueCount == 4)
            {
                Scoredata.Score += 1;
                Debug.Log($"全問正解！");
            }
    }

    void AddNumber()
    {
        if (Number < newKaniEbiArrey.Length - 1)
        {
            Number += 1;
        }
        else if(Number == 3 )
        {
            Number     = 0;
            falseCount = 0;
            trueCount  = 0;
            Debug.Log($"初期化されました");
        }
    }
 
}
