using System.Collections;
using System.Collections.Generic;
using FGUIStarter;
using UnityEngine;

public class PlayBehaviour : MonoBehaviour
{
    int currentSceneIndex;
    private void Awake()
    {
        currentSceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        this.gameObject.GetComponent<CustomButton>().targetSceneIndex = currentSceneIndex;
    }
}
