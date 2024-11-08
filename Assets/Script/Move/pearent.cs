using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pearent : MonoBehaviour
{
    GameObject[] EbiKaniObjects;
    float radius = 5.0f;

    void Start()
    {
        EbiKaniObjects = GameObject.FindGameObjectsWithTag("EbiKani");
    }

    void Update()
    {
        foreach(var EbiKani in EbiKaniObjects)
        {
            if(EbiKani == this.gameObject) continue;
            var d = EbiKani.transform.position;
            d.z = 0;

            if(d.magnitude > radius) continue;
            EbiKani.gameObject.transform.parent = this.gameObject.transform;Debug.Log("衝突えびか");
      
        }
    }


}
