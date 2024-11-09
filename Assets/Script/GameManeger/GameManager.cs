using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject dishprefab;
    Vector3 mypositon;

    void Start()
    {
        StartCoroutine(GameOperation(5.0f));
        mypositon = transform.position;
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

}
