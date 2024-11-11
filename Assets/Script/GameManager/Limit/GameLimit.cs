using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLimit : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
            //  Debug.Log("あたったよ");
            GameObject CollgameObject = other.gameObject;
            Destroy(CollgameObject);
    }
}
