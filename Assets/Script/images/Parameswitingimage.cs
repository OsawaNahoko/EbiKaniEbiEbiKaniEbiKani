using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parameswitingimage : MonoBehaviour
{
    [SerializeField] ParameterData parameterdata;

    public Sprite[] KaniEbSpritearrey;
    SpriteRenderer Spriterend;

    int[] newKaniEbiArrey = new int[4];
    public int Number;

        void Start()
    {
        Spriterend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        newKaniEbiArrey = parameterdata.KaniEbiArrey;

        if(newKaniEbiArrey[Number] == 0)
        {
            Spriterend.sprite = KaniEbSpritearrey[0];
        }
        else if(newKaniEbiArrey[Number] == 1)
        {
            Spriterend.sprite = KaniEbSpritearrey[1];
        }
    }
}
