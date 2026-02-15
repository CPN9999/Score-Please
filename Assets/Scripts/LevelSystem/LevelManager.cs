using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int numberOfBallsToWin;
    public bool isLoaded = false;
    public static event Action<LevelManager> LevelLoaded;

    public static LevelManager Instance;

    private void Awake()
    {
        //Lay du lieu Level
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        LevelLoaded?.Invoke(this);
        isLoaded = true;
    }
}
