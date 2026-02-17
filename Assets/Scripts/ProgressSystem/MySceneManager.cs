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
        CustomButton.OnCustomButtonPressed += HandleCustomButtonPressed;
    }

    private void OnDisable()
    {
        CustomButton.OnCustomButtonPressed -= HandleCustomButtonPressed;
    }

    private void HandleCustomButtonPressed(CustomButton button)
    {
        SceneManager.LoadScene(button.targetSceneIndex+1);
    }
}
