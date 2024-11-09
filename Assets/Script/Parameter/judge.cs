using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class judge : MonoBehaviour
{
    [SerializeField] ParameterData parameterdata;

    int[] newKaniEbiArrey = new int[4];
    int Number = -1;
    int falseCount = 0;
    int trueCount  = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        newKaniEbiArrey = parameterdata.KaniEbiArrey;

        AddNumber();
        Debug.Log($"Number{Number}");

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

    void AddNumber()
    {
        if (Number < newKaniEbiArrey.Length - 1)
        {
            Number += 1;
        }
        else if(Number == 3 )
        {
            Number = 0;
        }

    }
}
