using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public gameObject dishprefab;

    IEnumerator GameOperation()
    {
        while(true)
        {
            Debug.Log("繰り返しています。")

            yield return null;
            continue;
        }
    }

}
