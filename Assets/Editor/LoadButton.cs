using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadButton : MonoBehaviour
{
    Button loadButton;
    TMP_InputField levelNameInput;
    // Start is called before the first frame update
    void Start()
    {
        loadButton = GetComponent<Button>();
        levelNameInput = GameObject.Find("LevelToLoad").GetComponent<TMP_InputField>();
        loadButton.onClick.AddListener(LoadLevelForMe);
    }
    private void LoadLevelForMe()
    {
        string levelName = levelNameInput.text;
        LevelLoader levelLoader = GameObject.Find("LevelLoader").GetComponent<LevelLoader>();
        LevelData levelData = levelLoader.LoadLevel(levelName);
        if (levelData != null)
        {
            levelLoader.InstantiateLevel(levelData);
        }
    }
}
