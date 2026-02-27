using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public GameObject[] levelPrefabs;
    public GameObject[] ballPrefabs;
    public GameObject goalPrefab;
    public GameObject spawnPrefab;
    public GameObject pinPrefab;


    private void Start()
    {
        if (LevelChosen.index >= 0 && LevelChosen.index < levelPrefabs.Length)
        {
            LevelData levelData = LoadLevel(LevelChosen.index.ToString());
            if (levelData != null)
            {
                InstantiateLevel(levelData);
            }
        }
    }

    public LevelData LoadLevel(string levelName)
    {
        TextAsset jsonFile = Resources.Load<TextAsset>("Levels/" + "level" + levelName);

        if (jsonFile == null)
        {
            //Debug.Log("Level not found!");
            return null;
        }

        LevelData level = JsonUtility.FromJson<LevelData>(jsonFile.text);
        return level;
    }

    public void InstantiateLevel(LevelData levelData)
    {
        //Instantiate Map
        GameObject mapPrefab = levelPrefabs[levelData.levelPrefabIndex];
        Instantiate(mapPrefab, levelData.mapPos, Quaternion.identity);
        //Instantiate Goal
        Instantiate(goalPrefab, levelData.goalPosition, Quaternion.identity);
        //Instantiate Spawners
        foreach (SpawnData spawnData in levelData.spawnDatas)
        {
            GameObject ballPrefab = ballPrefabs[spawnData.ballPrefabIndex];
            GameObject spawner = Instantiate(spawnPrefab, spawnData.spawnPosition, Quaternion.identity);
            SpawnPosController controller = spawner.GetComponent<SpawnPosController>();
            controller.Init(ballPrefab, spawnData.ballCount);
        }
        //Instantiate Pins
        foreach (PinData pinData in levelData.pinDatas)
        {
            GameObject pin = Instantiate(pinPrefab, pinData.position, Quaternion.Euler(0f,0f,pinData.rotation));
        }
        LevelManager.Instance.numberOfBallsToWin=levelData.ballToWin;
        //Debug.Log("The Data: " + levelData.ballToWin);
        //Debug.Log(LevelManager.Instance.numberOfBallsToWin);
    }
}

