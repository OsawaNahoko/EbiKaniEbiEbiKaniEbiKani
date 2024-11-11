using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropGetObject : MonoBehaviour
{
    GameObject CollgameObject;

    void OnTriggerEnter2D(Collider2D other)
    {
        CollgameObject = other.gameObject;
    }

    public void SwitiEbi()
    {
            if(this.CollgameObject != null)
        {
            switingimage Switi = CollgameObject.GetComponent<switingimage>();
            if (Switi != null)
            {
                Switi.Switi_Ebi();
            }
            else
            {
                Debug.LogWarning("Switi is still null - 'switingimage' component not found on " + CollgameObject.name);
            }
            }
            else
            {
                Debug.LogError("CollgameObject is null");
            }
    } 

        public void SwitiKani()
    {
            if(this.CollgameObject != null)
        {
            switingimage Switi = CollgameObject.GetComponent<switingimage>();
            if (Switi != null)
            {
                Switi.Switi_Kani();
            }
            else
            {
                Debug.LogWarning("Switi is still null - 'switingimage' component not found on " + CollgameObject.name);
            }
            }
            else
            {
                Debug.LogError("CollgameObject is null");
            }
    } 

}
