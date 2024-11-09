using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switingimage : MonoBehaviour
{   
    public Sprite[] KaniEbSpritearrey;
    SpriteRenderer Spriterend;
    
    bool EbiFlag;
    bool KaniFlag;

    void Start()
    {
        Spriterend = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.gameObject.tag == "Ebi")
        {
            Spriterend.sprite = KaniEbSpritearrey[0];
            this.gameObject.tag = "dish_Ebi";
        }

        if(other.gameObject.tag == "Kani")
        {
            Spriterend.sprite = KaniEbSpritearrey[1];
            this.gameObject.tag = "dish_Kani";
        }
    }

}
