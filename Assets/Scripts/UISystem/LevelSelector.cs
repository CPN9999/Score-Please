using System.Collections;
using System.Collections.Generic;
using FGUIStarter;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public GameObject buttonPrefabs;


    // Start is called before the first frame update
    void Start()
    {
        int levelCount = SceneManager.sceneCountInBuildSettings;
        //Debug.Log("Total levels in build settings: " + levelCount);
        int i = levelCount - 2;
        while (i>0)
        {
            int levelIndex = i; //Current level
            Instantiate(buttonPrefabs, transform);
            buttonPrefabs.GetComponent<CustomButton>().targetSceneIndex = levelIndex;
            buttonPrefabs.GetComponentInChildren<TextMeshProUGUI>().text = "Level " + (levelIndex).ToString();
            i--;
        }
    }
}
