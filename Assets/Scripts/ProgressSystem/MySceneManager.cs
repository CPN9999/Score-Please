using System.Collections;
using System.Collections.Generic;
using FGUIStarter;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    public static MySceneManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        DisapearPanel.DisapearDone += HandleCustomButtonPressed;
    }

    private void OnDisable()
    {
        DisapearPanel.DisapearDone -= HandleCustomButtonPressed;
    }

    private void HandleCustomButtonPressed(DisapearPanel button)
    {
        if (button.targetSceneIndex >= 0 &&
            button.targetSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(button.targetSceneIndex+1);
        }
        else
        {
            Debug.LogError("Scene index out of range");
        }

    }
}
