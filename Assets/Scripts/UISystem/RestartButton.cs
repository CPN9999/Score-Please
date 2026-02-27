using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
   public void Clicked()
    {
        Time.timeScale = 1f;
        MySceneManager.instance.LoadScene(MySceneManager.instance.GetCurrentSceneIndex());
    }
}
