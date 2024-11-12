using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DropGetObject : MonoBehaviour
{
    string[] targetTags = { "dish_null", "dish_Kani", "dish_Ebi" };
    
    [SerializeField] GameObject  Ebikaniprefab;
    Vector3 mypositon;
    GameObject CollgameObject;
    
    void Start()
    {
        mypositon = transform.position;
    }

    void OnTriggerStay2D(Collider2D other)
    {
          if (targetTags.Contains(other.gameObject.tag))
        {
            // Debug.Log($"CollgameObejct = {CollgameObject}");
            CollgameObject = other.gameObject;
        }
    }

    public void SwitiEbi()
    {
            if(this.CollgameObject != null)
        {
            switingDish Switi = CollgameObject.GetComponent<switingDish>();
            
            if (Switi != null)
            {
                Switi.Switi_Ebi();
                Instantiate(Ebikaniprefab,mypositon,Quaternion.identity);
                Destroy(this.gameObject);
            }
            else
            {
                
                Debug.LogWarning("Switi is still null - 'switingDish' component not found on " + CollgameObject.name);
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
            switingDish Switi = CollgameObject.GetComponent<switingDish>();
            if (Switi != null)
            {
                Switi.Switi_Kani();
                Instantiate(Ebikaniprefab,mypositon,Quaternion.identity);
                Destroy(this.gameObject);
            }
            else
            {
                Debug.LogWarning("Switi is still null - 'switingDish' component not found on " + CollgameObject.name);
            }
            }
            else
            {
                Debug.LogError("CollgameObject is null");
            }
    } 

}
