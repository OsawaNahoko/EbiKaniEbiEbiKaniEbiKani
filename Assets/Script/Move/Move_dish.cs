using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_dish : MonoBehaviour
{
    public float MoveSpeed;

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos.x += MoveSpeed;
        transform.position = pos;
    }
}
