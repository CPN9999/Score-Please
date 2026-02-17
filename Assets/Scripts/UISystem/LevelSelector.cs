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
        int i = 1;
        while (i<levelCount-1)
        {
            int levelIndex = i; //Current level
            GameObject newButton = Instantiate(buttonPrefabs, transform);
            newButton.GetComponent<CustomButton>().targetSceneIndex = levelIndex;
            newButton.GetComponentInChildren<TextMeshProUGUI>().text = "Level " + (levelIndex).ToString();
            i++;
        }
    }
}
