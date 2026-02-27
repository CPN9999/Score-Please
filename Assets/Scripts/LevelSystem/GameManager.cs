using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        this.numberOfBallsInBasket = 0;
    }

    private void Start()
    {
        winPanel = GameObject.Find("WinPanel");
    }

    public int numberOfBallsInBasket = 0;
    public GameObject winPanel;

    private void OnEnable()
    {
        BallController.OnBallEnterBasket += CheckWinCondition;
    }

    private void OnDisable()
    {
        BallController.OnBallEnterBasket -= CheckWinCondition;
    }

    private void CheckWinCondition(BallController ballController)
    {
        this.numberOfBallsInBasket++;
        if (this.numberOfBallsInBasket >= LevelManager.Instance.numberOfBallsToWin)
        {
            winPanel.SetActive(true);
        }
    }
}
