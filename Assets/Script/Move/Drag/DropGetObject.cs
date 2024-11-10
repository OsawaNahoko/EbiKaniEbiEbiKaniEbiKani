using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropGetObject : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
            GameObject CollgameObject = other.gameObject;
    }
}
