using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{
    public int numberOfBallsInBasket = 0;
    public GameObject winPanel;

    private void Awake()
    {
        this.numberOfBallsInBasket = 0;
    }
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
