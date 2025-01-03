using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Tooltip("Element0 is Dish.Element1 is Converyor.")]
    [SerializeField] GameObject[]   prfabArray;//０＿Dishprefab　１＿Conveyorprefab
    [Tooltip("Element0 is Gamestart.Element1 is GameOver.")]
    [SerializeField] GameObject[]   GameUIArray;//０＿Gamestart　１＿GameOver
    [SerializeField] Animator[]     AnimatorArray;

    [SerializeField] ScoreData      Scoredata;
    [SerializeField] Vector3        ConveyorV3;
    [SerializeField] GameObject     parent_Conveyor;
    Vector3 dishpositon;

    void Start()
    {
        StartCoroutine(GameOperation(15.0f));
        dishpositon = transform.position;
        Invoke("GameUI",5.0f);
    }

    void GameUI()
    {
        GameUIArray[0].SetActive(false);
        GameUIArray[1].SetActive(true);
    }

    void Update()
    {
        if(Scoredata.Score <= 0 || Scoredata.Score >= 100 )
        {
            Destroy(parent_Conveyor,2.0f);
            for (int i = 0; i < AnimatorArray.Length; i++)
            {
                AnimatorArray[i].SetBool("GameOverFlag",true);
            }
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
            Instantiate(prfabArray[1],ConveyorV3,Quaternion.identity,parent_Conveyor.transform);
        }
    }

}
