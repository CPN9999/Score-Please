using System.Collections;
using System.Collections.Generic;
using FGUIStarter;
using UnityEngine;

public class AddNextLevelFunc : MonoBehaviour
{
    int levelCount;
    private void Start()
    {
        TextAsset[] levels = Resources.LoadAll<TextAsset>("Levels");
        levelCount = levels.Length;
    }

    public void Clicked()
    {
        int check = LevelChosen.index;
        if (check < levelCount)
        {
            LevelChosen.index++;
            MySceneManager.instance.LoadScene(2);
        }
        else
        {
            MySceneManager.instance.LoadScene(1);
        }
    }
}
