using UnityEngine;
using UnityEngine.Events;
public class DropEvent : MonoBehaviour
{
    bool inTrigger;
    public UnityEvent dropEvent;

    // Update is called once per frame
    public void Drop()
    {
        if(this.inTrigger)this.dropEvent.Invoke();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log("Enter");
        this.inTrigger = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Debug.Log("Exit");
        this.inTrigger = false;
    }
}
