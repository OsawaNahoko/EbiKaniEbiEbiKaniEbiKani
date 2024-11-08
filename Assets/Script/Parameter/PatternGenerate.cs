using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternGenerate : MonoBehaviour
{
    public int[] KaniEbiArrey = new int[4];
    //０がエビ、１がカニ
    int parame;
    int a;

    void Awake()
    {
        var ArreryLength = KaniEbiArrey.Length;
        Debug.Log("処理通ってます。");

        for(var i = 0; i < ArreryLength; ++i)
        {
            Debug.Log("処理通ってます。For");
            parame = Random.Range(0,2);
            KaniEbiArrey[i] = parame;
            Debug.Log(KaniEbiArrey[i]);
        }
    }

}
