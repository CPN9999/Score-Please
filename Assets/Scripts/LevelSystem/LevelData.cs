using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelData
{
    public int levelPrefabIndex;
    public Vector2 mapPos;
    public Vector2 goalPosition;
    public List<SpawnData> spawnDatas;
    public int ballToWin;
    public List<PinData> pinDatas;
}

[Serializable]
public class SpawnData
{
    public Vector2 spawnPosition;
    public int ballPrefabIndex;
    public int ballCount;
}

[Serializable]
public class PinData
{
    public Vector2 position;
    public float rotation;
    //public int pinPrefabIndex;
}
