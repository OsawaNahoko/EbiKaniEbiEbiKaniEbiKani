using UnityEngine;
using UnityEngine.UI;

public class switingDish : Soundplayer
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
       PlaySound(0);
    }

    public void Switi_Kani()
    {
       Spriterend.sprite = KaniEbSpritearrey[1];
       this.gameObject.tag = "dish_Kani";
       PlaySound(0);
    }

}
