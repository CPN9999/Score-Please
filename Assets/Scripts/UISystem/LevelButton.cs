using System.Collections;
using System.Collections.Generic;
using FGUIStarter;
using UnityEngine;

public class LevelButton : MonoBehaviour
{
    private MenuManagerLevelsScene manager;

    private void Start()
    {
        manager = GameObject.Find("MenuManager").GetComponent<MenuManagerLevelsScene>();
    }

    public void Clicked()
    {
        manager.StartTransition(LoadScene);
    }

    private void LoadScene()
    {
        int sceneIndex = gameObject.GetComponent<CustomButton>().targetSceneIndex;
        LevelChosen.index = sceneIndex;
        MySceneManager.instance.LoadScene(2);
    }
}
