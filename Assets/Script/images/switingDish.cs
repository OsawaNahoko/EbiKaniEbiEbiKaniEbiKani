using UnityEngine;
using UnityEngine.UI;

public class switingDish : Soundplayer
{   
    public Sprite[] KaniEbSpritearrey;
    int[] DishArrey = new int[4];
    SpriteRenderer  Spriterend;


     void Start()
    {
        Spriterend = GetComponent<SpriteRenderer>();
    }

    public void Switi_Ebi()
    {
       Spriterend.sprite = KaniEbSpritearrey[0];
       this.gameObject.tag = "dish_Ebi";
       PlaySound(0);
    }

    public void Switi_Kani()
    {
       Spriterend.sprite = KaniEbSpritearrey[1];
       this.gameObject.tag = "dish_Kani";
       PlaySound(0);
    }

}
