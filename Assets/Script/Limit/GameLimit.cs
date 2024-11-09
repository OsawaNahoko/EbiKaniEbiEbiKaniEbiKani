using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLimit : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
            //  Debug.Log("あたったよ");
             GameObject CollgameObject = collision.gameObject;
             Destroy(CollgameObject);
    }
}
