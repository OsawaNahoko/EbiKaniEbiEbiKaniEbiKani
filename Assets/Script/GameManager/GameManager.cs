using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Tooltip("0はDish!1はConveryor!")]
    [SerializeField] GameObject[]   prfabArray;//０＿Dishprefab　１＿Conveyorprefab
    [Tooltip("0はGamestart!1はGameOver!")]
    [SerializeField] GameObject[]   GameUIArray;//０＿Gamestart　１＿GameOver
    [SerializeField] Animator[]   AnimatorArray;
    [SerializeField] ScoreData    Scoredata;
    [SerializeField] Vector3     ConveyorV3;
    Vector3 dishpositon;


    


    void Start()
    {
        StartCoroutine(GameOperation(15.0f));
        dishpositon = transform.position;

    }

    void Update()
    {
        if(Scoredata.Score <= 0)
        {
            for (int i = 0; i < AnimatorArray.Length; i++)
            {
                AnimatorArray[i].SetBool("GameOverFlag",true);
            }

            GameUIArray[0].SetActive(false);
            GameUIArray[1].SetActive(true);
        }
    }

    IEnumerator GameOperation(float WaitIETime)
    {
        while(true)
        {
            yield return new WaitForSeconds(WaitIETime);
            Instantiate(prfabArray[0],dishpositon,Quaternion.identity);
            yield return null;
            continue;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Conveyor")
        {
            Instantiate(prfabArray[1],ConveyorV3,Quaternion.identity);
        }
    }

}
