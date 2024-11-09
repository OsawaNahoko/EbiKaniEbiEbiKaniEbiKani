using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParameterGenerate : MonoBehaviour
{
    [SerializeField] ParameterData parameterdata;
    int parame;
    
    void Awake()
    {
        int[] newKaniEbiArrey = new int[4];
        
        for (int i = 0; i < newKaniEbiArrey.Length; i++)
        {
            newKaniEbiArrey[i] = Random.Range(0, 2); // ０（エビ）か１（カニ）かをランダムに生成
        }
        parameterdata.KaniEbiArrey = newKaniEbiArrey;
    }

}
