using System.Collections;
using System.Collections.Generic;
using FGUIStarter;
using UnityEngine;

public class AddRestartFunc : MonoBehaviour
{
    private void Awake()
    {
        int currentSceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        this.gameObject.GetComponentInParent<CustomButton>().targetSceneIndex = currentSceneIndex-1;
    }
}
