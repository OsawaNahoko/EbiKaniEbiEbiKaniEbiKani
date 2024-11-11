using UnityEngine;

public class Move_dish : MonoBehaviour
{
    [SerializeField] float MoveSpeed;

    // Update is called once per frame
    void FixedUpdate()
    {
        var pos = transform.position;
        pos.x += MoveSpeed;
        transform.position = pos;
    }
}
