using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pearent : MonoBehaviour
{
    GameObject ColleisonObject;
    string ObjectName;

    public void Pearent()
    {
        this.gameObject.transform.parent = GameObject.Find("Kani_dish").transform;
    }

}
