using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switingimage : MonoBehaviour
{   
    int[] DishArrey = new int[4];
    public Sprite[] KaniEbSpritearrey;
    SpriteRenderer Spriterend;

    int EbiKaniCount = 1;

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

    public void Switi_Ebi()
    {
       Spriterend.sprite = KaniEbSpritearrey[0];
    }

    public void Switi_Kani()
    {
       Spriterend.sprite = KaniEbSpritearrey[1];
    }

    // void Update()
    // {
    //      switch(EbiKaniCount)
    //     {
    //         case 0:
    //         Spriterend.sprite = KaniEbSpritearrey[0];
    //         break;
    //         case 1:
    //         Spriterend.sprite = KaniEbSpritearrey[1];
    //         break;
    //         case 3:
    //         Spriterend.sprite = KaniEbSpritearrey[3];
    //         break;
    //     }
    // }

}
