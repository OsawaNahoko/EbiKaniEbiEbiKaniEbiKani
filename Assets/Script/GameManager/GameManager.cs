using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject dishprefab;
    [SerializeField] GameObject Conveyorprfab;
    [SerializeField] Vector3 ConveyorV3;

    [SerializeField] ScoreData Scoredata;
    Vector3 mypositon;

    void Start()
    {
        StartCoroutine(GameOperation(15.0f));
        mypositon = transform.position;
    }

    void Update()
    {
        if(Scoredata.Score <= 0)
        {
            Debug.Log("0になったよ");
        }
    }

    IEnumerator GameOperation(float WaitIETime)
    {
        while(true)
        {
            yield return new WaitForSeconds(WaitIETime);
            Instantiate(dishprefab,mypositon,Quaternion.identity);
            yield return null;
            continue;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Conveyor")
        {
            Instantiate(Conveyorprfab,ConveyorV3,Quaternion.identity);
        }
    }

}
