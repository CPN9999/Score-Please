using System.Collections;
using System.Collections.Generic;
using FGUIStarter;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public GameObject buttonPrefabs;


    // Start is called before the first frame update
    void Start()
    {
        TextAsset[] levels = Resources.LoadAll<TextAsset>("Levels");
        int levelCount = levels.Length;
        //Debug.Log("Total levels in build settings: " + levelCount);
        int i = 1;
        while (i<=levelCount)
        {
            int levelIndex = i; //Current level
            GameObject newButton = Instantiate(buttonPrefabs, transform);
            newButton.GetComponent<CustomButton>().targetSceneIndex = levelIndex;
            newButton.GetComponentInChildren<TextMeshProUGUI>().text = "Level " + (levelIndex).ToString();
            i++;
        }
    }
}
