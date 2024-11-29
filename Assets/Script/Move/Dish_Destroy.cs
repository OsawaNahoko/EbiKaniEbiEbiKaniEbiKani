using UnityEngine;

public class Dish_Destroy : MonoBehaviour
{
    GameObject[] child = new GameObject[4];

    void Awake()
    {
        for(int i = 0; i < 4; i++)
        {
            child[i] = transform.GetChild(i).gameObject;
        }
    }

    void Update()
    {
        if(child[0] == null && child[1] == null && child[2] == null && child[3] == null )
        {
            Destroy(this.gameObject);
        }
    }
}
