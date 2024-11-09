using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject dishprefab;

    void Start()
    {
        StartCoroutine("GameOperation");
    }

    IEnumerator GameOperation()
    {
        while(true)
        {
            Debug.Log("繰り返しています。");

            yield return null;
            continue;
        }
    }

}
