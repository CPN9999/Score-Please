using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{
    public int numberOfBallsInBasket = 0;

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
            Debug.Log("You Win!");
            // You can add additional win logic here, such as loading a new level or showing a win screen.
        }
    }
}
