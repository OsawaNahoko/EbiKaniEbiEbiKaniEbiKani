using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class judge : MonoBehaviour
{
    [SerializeField] ParameterData parameterdata;

    int[] newKaniEbiArrey = new int[4];
    int Number = -1;

      void OnTriggerEnter2D(Collider2D other)
    {
        newKaniEbiArrey = parameterdata.KaniEbiArrey;

        AddNumber();
        Debug.Log($"Number{Number}");

        if(newKaniEbiArrey[Number] == 0 && other.gameObject.tag == "dish_Ebi")
        {
            Debug.Log("正解ですエビ");
        }
        else if (newKaniEbiArrey[Number] == 0 && other.gameObject.tag == "dish_Kani" || newKaniEbiArrey[Number] == 0 && other.gameObject.tag == "dish_null")
        {
            Debug.Log("誤りですエビ！！！");
        }

        if(newKaniEbiArrey[Number] == 1 && other.gameObject.tag == "dish_Kani")
        {
            Debug.Log("正解ですカニ");
        }
        else if (newKaniEbiArrey[Number] == 1 && other.gameObject.tag == "dish_Kani" || newKaniEbiArrey[Number] == 1 && other.gameObject.tag == "dish_null")
        {
            Debug.Log("誤りですカニ！！！！");
        }

    }

    void AddNumber()
    {
        if (Number < newKaniEbiArrey.Length - 1)
        {
            Number += 1;
        }
    }
}
