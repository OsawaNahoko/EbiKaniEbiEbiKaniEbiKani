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
        
        switch(newKaniEbiArrey[Number])
        {
            case 0:
            Spriterend.sprite = KaniEbSpritearrey[0];
            break;

            case 1:
            Spriterend.sprite = KaniEbSpritearrey[1];
            break;

            case 2:
            Spriterend.sprite = KaniEbSpritearrey[2];
            break;

            case 3:
            Spriterend.sprite = KaniEbSpritearrey[3];
            break;
        }
        // if(newKaniEbiArrey[Number] == 0)
        // {
        //     Spriterend.sprite = KaniEbSpritearrey[0];
        // }
        // else if(newKaniEbiArrey[Number] == 1)
        // {
        //     Spriterend.sprite = KaniEbSpritearrey[1];
        // }
        // else if()
    }
}
