using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    [SerializeField] private MenuManagerLevelsScene manager;
    public void Clicked()
    {
        manager.StartTransition(LoadScene);
        
    }
    private void LoadScene()
    {
        MySceneManager.instance.LoadScene(0);
    }
}
