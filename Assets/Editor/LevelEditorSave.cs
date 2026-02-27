using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using TMPro;

public class LevelEditorSave : MonoBehaviour
{
    public static TMP_InputField ballToWinInput;
    public static void CreateLevel()
    {
        ballToWinInput = GameObject.Find("BallToWin").GetComponent<TMP_InputField>();
        LevelData level = new LevelData();
        //SaveMap
        GameObject map = GameObject.FindGameObjectWithTag("Map");
        string mapName = map.name;
        Vector2 mapPos = map.transform.position;
        int mapIndex = int.Parse(mapName);
        level.levelPrefabIndex = mapIndex;
        level.mapPos = mapPos;

        //Save Goal
        level.goalPosition = GameObject.FindGameObjectWithTag("Goal").transform.position;

        //Save Ball To Win
        string value = ballToWinInput.text;
        int.TryParse(ballToWinInput.text, out int ballToWin);
        level.ballToWin = ballToWin;

        //Save Spawn Positions
        level.spawnDatas = new List<SpawnData>();
        List<GameObject> spawners = new List<GameObject>(GameObject.FindGameObjectsWithTag("SpawnPos"));
        foreach (GameObject spawner in spawners)
        {
            int BallIndex;
            GameObject ballPrefab = spawner.GetComponent<SpawnPosController>().ballPrefab;
            if (ballPrefab.name == "Ball")
            {
                BallIndex = 0;
            }
            else if (ballPrefab.name == "GreyBall")
            {
                BallIndex = 1;
            }
            else
            {
                BallIndex = 2;
            }
            SpawnData spawnData = new SpawnData
            {
                spawnPosition = spawner.transform.position,
                ballPrefabIndex = BallIndex,
                ballCount = spawner.GetComponent<SpawnPosController>().ballCount
            };
            level.spawnDatas.Add(spawnData);
        }

        //Save Pin Positions
        level.pinDatas = new List<PinData>();
        List<GameObject> pins = new List<GameObject>(GameObject.FindGameObjectsWithTag("Pin"));
        foreach (GameObject pin in pins)
        {
            PinData pinData = new PinData
            {
                position = pin.transform.position,
                rotation = pin.transform.rotation.eulerAngles.z
            };
            level.pinDatas.Add(pinData);
        }
        if (level.pinDatas.Count > 0)
        {
            Debug.Log("Pin count: " + level.pinDatas.Count);
        }

        string json = JsonUtility.ToJson(level, true);

        string folderPath = "Assets/Resources/Levels";
        if (!Directory.Exists(folderPath))
            Directory.CreateDirectory(folderPath);

        File.WriteAllText(folderPath + "/level" +  mapIndex +".json", json);

        AssetDatabase.Refresh();
        Debug.Log("Level created!");
    }
}
