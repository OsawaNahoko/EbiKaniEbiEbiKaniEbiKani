using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{ 

     public void Load_GameScene()
    {
        SceneManager.LoadScene("1_1_Game");
    }

    public void Load_TitleScene()
    {
        SceneManager.LoadScene("0_1_Title");
    }

    public void Quit()
    {
        Application.Quit();
    }
  
}
