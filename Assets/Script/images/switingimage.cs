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

    public void Switi_Ebi()
    {
       Spriterend.sprite = KaniEbSpritearrey[0];
       this.gameObject.tag = "dish_Ebi";
    }

    public void Switi_Kani()
    {
       Spriterend.sprite = KaniEbSpritearrey[1];
       this.gameObject.tag = "dish_Kani";
    }

    //  void OnTriggerEnter2D(Collider2D other)
    // {

    //     if(other.gameObject.tag == "Ebi")
    //     {
    //         Spriterend.sprite = KaniEbSpritearrey[0];
    //         this.gameObject.tag = "dish_Ebi";
    //     }

    //     if(other.gameObject.tag == "Kani")
    //     {
    //         Spriterend.sprite = KaniEbSpritearrey[1];
    //         this.gameObject.tag = "dish_Kani";
    //     }
    // }

}
