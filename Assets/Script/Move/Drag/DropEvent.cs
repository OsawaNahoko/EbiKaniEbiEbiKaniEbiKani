using UnityEngine;
using UnityEngine.Events;
using System.Linq;

public class DropEvent : MonoBehaviour
{
    bool inTrigger;
    public UnityEvent dropEvent;
    string[] targetTags = { "dish_null", "dish_Kani", "dish_Ebi" };

    public void Drop()
    {
        if(this.inTrigger)this.dropEvent.Invoke();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (targetTags.Contains(other.gameObject.tag))
        {
            this.inTrigger = true;
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (targetTags.Contains(other.gameObject.tag))
        {
        this.inTrigger = false;
        }
    }
}
